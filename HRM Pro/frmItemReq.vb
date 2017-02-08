Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports System.Runtime.Serialization
Imports System

Public Class frmItemReq

    Public Itemcode, Itemname, CurrQty, OrdQty As String
    Public frmGridRow As Double

    Private Sub frmItemReq_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled Then
            gvItemDets.SetRowCellValue(frmGridRow, "Itemcode", Itemcode)
            Itemcode = String.Empty

            gvItemDets.SetRowCellValue(frmGridRow, "Itemname", Itemname)
            gvItemDets.SetRowCellValue(frmGridRow, "CurrQty", CurrQty)
        End If
    End Sub

    Private Sub frmItemReq_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGridDets()
        LoadCombos()

        dtReqDate.Text = Now.Date

        txtReqID.Properties.ReadOnly = True

    End Sub

#Region " Proc & Functions "

    Sub ClearFields()

        txtReference.Text = ""
        txtReqID.Text = GetItemReqCode()
        txtRequestBy.Text = CurrUser
        cmbPriority.Text = "Medium"

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter("select * from ItemReqMaster where status=1", Conn)
        Dim dsShow As New DataSet

        '--- here what i hv done is, get a dummy dataset for itemreqdetails
        daGetDets = New SqlDataAdapter("select * from itemreqtemporary where itemcode like 'nothing'", Conn)
        daGetDets.Fill(dsShow)

        gridItemDets.DataSource = dsShow.Tables(0)


        'gridItemDets.DataSource = Nothing
    End Sub

    ''' <summary>
    ''' Insert New Item Req 
    ''' </summary>
    ''' <returns>True-Sucess,False-Failed</returns>
    ''' <remarks></remarks>
    Function InsertNewItemReq(ByVal Proc As String) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim Procedure As String
        Dim TransInsert As SqlTransaction
        Dim IsTransEnable As Boolean = False  'Track the transection status

        If String.Compare(Proc, "Add", False) = 0 Then
            Procedure = "spItemReqAdd"
        Else
            Procedure = "spItemReqEdit"
        End If

        Dim dcExecProc As New SqlCommand(Procedure, Conn)

        Try


            '/* 
            '    In this process two things going to happen. 
            ' 1) Insert all the details to temp table 
            ' 2) Run the stored procedures to insert all the details from temp table
            '*/


            Conn.Open()

            '--- Assign the transection
            TransInsert = Conn.BeginTransaction
            IsTransEnable = True


            Dim sqlstring As String = ""

            '------- remove any previous entries if exists

            sqlstring = String.Format("Delete from ItemReqTemporary where curruser like '{0}'", CurrUser)

            dcExecProc = New SqlCommand(sqlstring, Conn)
            dcExecProc.Transaction = TransInsert

            dcExecProc.ExecuteNonQuery()




            For i As Int16 = 0 To gvItemDets.RowCount - 1

                
                If gvItemDets.GetRowCellValue(i, "Itemcode") = "" Then
                    Exit For
                End If

                If IsDBNull(gvItemDets.GetRowCellValue(i, "OrdQty")) Then
                    Throw New Exception("Order Quantytity must be non zero value")
                    Exit For
                End If


                sqlstring = "Insert Into ItemReqTemporary (ItemReqCode,ReqDate,ReqBy,Department,Reference,Itemcode,Itemname,CurrQty,OrdQty,UID,PriorityLevel,CurrUser) values("
                sqlstring = sqlstring & "@ItemReqCode,@ReqDate,@ReqBy,@Department,@Reference,@Itemcode,@Itemname,@CurrQty,@OrdQty,@UID,@Priority,@CurrUser)"

                dcExecProc = New SqlCommand(sqlstring, Conn)
                dcExecProc.Transaction = TransInsert



                With dcExecProc.Parameters
                    .Add("@ItemReqCode", SqlDbType.NVarChar, 50).Value = txtReqID.Text
                    .Add("@ReqDate", SqlDbType.Date).Value = dtReqDate.Text
                    .Add("@ReqBy", SqlDbType.NVarChar).Value = txtRequestBy.Text
                    .Add("@Department", SqlDbType.NVarChar).Value = IIf(IsNothing(cmbDepartment.GetColumnValue("DepartmentID")), String.Empty, cmbDepartment.GetColumnValue("DepartmentID"))
                    .Add("@Reference", SqlDbType.NVarChar).Value = txtReference.Text
                    .Add("@Itemcode", SqlDbType.NVarChar).Value = gvItemDets.GetRowCellValue(i, "Itemcode")
                    .Add("@Itemname", SqlDbType.NVarChar).Value = gvItemDets.GetRowCellValue(i, "Itemname")
                    .Add("@CurrQty", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "CurrQty") ' GetCurrItemQty(Conn, TransInsert, gvItemDets.GetRowCellValue(i, "Itemcode"))
                    .Add("@OrdQty", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "OrdQty")
                    .Add("@UID", SqlDbType.UniqueIdentifier).Value = IIf(IsDBNull(gvItemDets.GetRowCellValue(i, "UID")), Guid.NewGuid, gvItemDets.GetRowCellValue(i, "UID"))
                    .Add("@Priority", SqlDbType.NVarChar).Value = cmbPriority.Text
                    .Add("@CurrUser", SqlDbType.NVarChar).Value = CurrUser
                End With

                dcExecProc.ExecuteNonQuery()

            Next


            TransInsert.Commit()
            IsTransEnable = False

            dcExecProc.Dispose()

            '--------------------------------------------------

            dcExecProc = New SqlCommand(Procedure, Conn)
            dcExecProc.CommandType = CommandType.StoredProcedure

            With dcExecProc.Parameters
                .Add("@CurrUser", SqlDbType.NVarChar).Value = CurrUser
            End With

            dcExecProc.ExecuteNonQuery()

            Return 1
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            dcExecProc.Dispose()

        End Try

        If IsTransEnable Then
            TransInsert.Rollback()
        End If


    End Function

    Sub ShowFields(ByVal ItemReqcode As String)

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter(String.Format("select * from ItemReqMaster where ItemReqcode like '{0}'", ItemReqcode), Conn)
        Dim dsShow As New DataSet

        Try

            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            txtReference.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Reference")), "", dsShow.Tables(0).Rows(0).Item("Reference"))
            txtReqID.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ItemReqCode")), "", dsShow.Tables(0).Rows(0).Item("ItemReqCode"))
            txtRequestBy.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ReqBy")), "", dsShow.Tables(0).Rows(0).Item("ReqBy"))
            dtReqDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ReqDate")), "", dsShow.Tables(0).Rows(0).Item("ReqDate"))
            cmbPriority.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("PriorityLevel")), "", dsShow.Tables(0).Rows(0).Item("PriorityLevel"))
            cmbDepartment.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Department")), "", dsShow.Tables(0).Rows(0).Item("Department"))

            daGetDets.Dispose()
            dsShow.Dispose()


            '----- Load the item grid dets
            daGetDets = New SqlDataAdapter(String.Format("select * from ItemReqDetail where ItemReqcode like '{0}'", ItemReqcode), Conn)
            dsShow = New DataSet

            daGetDets.Fill(dsShow)


            gridItemDets.DataSource = dsShow.Tables(0)

            tabMain.SelectedTabPageIndex = 1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()

        End Try


    End Sub

    ''' <summary>
    ''' Its Load Grid Details
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Sub LoadGridDets()

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter("select * from ItemReqMaster where status=1 order by ItemReqCode", Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            gridItemReq.DataSource = dsShow.Tables(0)

            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daGetDets = New SqlDataAdapter("select * from itemreqtemporary where itemcode like 'nothing'", Conn)
            daGetDets.Fill(dsShow)

            gridItemDets.DataSource = dsShow.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Sub LoadCombos()
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets, daGridLookup As New SqlDataAdapter()
        Dim dsShow, dsGridLookup As New DataSet

        Try

            '----- Load Department Master

            daGetDets = New SqlDataAdapter("select DepartmentID,Department from DepartmentMaster", Conn)
            daGetDets.Fill(dsShow)

            With cmbDepartment.Properties
                .DataSource = dsShow.Tables(0)
                .DisplayMember = "Department"
                .ValueMember = "DepartmentID"
                .Columns(0).Width = 125
                .Columns(1).Width = 275
                .PopupWidth = 400

            End With

            '----- Load Item Master to Grid

            daGridLookup = New SqlDataAdapter("select Itemcode from ItemMaster", Conn)
            daGridLookup.Fill(dsGridLookup)

            For i As Integer = 0 To dsGridLookup.Tables(0).Rows.Count - 1
                repItemList.Items.Add(dsGridLookup.Tables(0).Rows(i).Item(0))
            Next



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
            daGridLookup.Dispose()
            dsGridLookup.Dispose()
        End Try
    End Sub

    Function FieldValidation() As Boolean
        Return IIf(String.Compare(txtReqID.Text, "", False) = 0 Or String.Compare(dtReqDate.Text, "", False) = 0 Or ItemcodeValid() = False, 0, 1)
    End Function

    Function GetItemReqCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "ItemReq"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output

            dcGetCode.ExecuteNonQuery()

            GetItemReqCode = dcGetCode.Parameters("@Currcode").Value
            

            Return GetItemReqCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function

  
    Function ItemcodeValid() As Boolean

        Try
            'If gvItemDets.RowCount > 1 Then
            '    gvItemDets.DeleteRow(gvItemDets.RowCount)
            'End If

            Dim i As Int16
            For i = 0 To gvItemDets.RowCount - 2
                If IsDBNull(gvItemDets.GetRowCellValue(i, "Itemcode")) Then
                    Throw New Exception("Itemcode can't be empty")
                ElseIf gvItemDets.GetRowCellValue(i, "Itemcode") Is Nothing Then
                    Throw New Exception("Itemcode can't be empty")
                End If
            Next

            If gvItemDets.RowCount = 1 Then
                Return False ' coz no row found
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        End Try

    End Function

    Function GetCurrItemQty(ByVal Conn As SqlConnection, ByVal TransIns As SqlTransaction, ByVal Itemcode As String) As Double

        Dim daGetCurrQty As New SqlDataAdapter()
        Dim dsShowMe As New DataSet

        Try

            daGetCurrQty = New SqlDataAdapter(String.Format("select Stocks from ItemMaster where Itemcode like '{0}'", Itemcode), Conn)
            daGetCurrQty.Fill(dsShowMe)

            If dsShowMe.Tables(0).Rows.Count > 0 Then
                GetCurrItemQty = dsShowMe.Tables(0).Rows(0).Item(0)
            Else
                GetCurrItemQty = 0
            End If

            Return GetCurrItemQty
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            daGetCurrQty.Dispose()
            dsShowMe.Dispose()
        End Try

    End Function

    Function InactivateRequisition(ByVal ItemReqCode As String) As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExecDel As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Dim msgbxrslt As MsgBoxResult = MsgBox("Are you sure,you want to delete this Item Requisition", MsgBoxStyle.YesNo, ErrTitle)

            If msgbxrslt = MsgBoxResult.No Then
                Return False
            End If

            Conn.Open()

            dcExecDel = New SqlCommand(String.Format("update ItemReqMaster set status = 0 where ItemReqCode ='{0}'", ItemReqCode), Conn)
            dcExecDel.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcExecDel.Dispose()

        End Try

    End Function

    ''' <summary>
    ''' Validate for Any Purchase Requisition is created for given Item Requisition
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function EntryVaidation() As Boolean
        Dim Conn As New SqlConnection(ConnString)


        Dim daGetCode As New SqlDataAdapter(String.Format("Select ItemReqCode from POReqDetails where ItemReqCode like '{0}'", txtReqID.Text.Trim), Conn)
        Dim dsGetDets As New DataSet

        Try

            daGetCode.Fill(dsGetDets)

            If dsGetDets.Tables(0).Rows.Count > 0 Then
                Return False 'Records found

            End If
            

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            daGetCode.Dispose()
            dsGetDets.Dispose()

        End Try

    End Function

    Sub DeleteTempTable()

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim TransInsert As SqlTransaction
        Dim IsTransEnable As Boolean = False  'Track the transection status

        Dim dcExecProc As New SqlCommand("Delete from ItemReqTemporary where curruser like '" & CurrUser & "'", Conn)

        Try


            '/* 
            '    In this process two things going to happen. 
            ' 1) Insert all the details to temp table 
            ' 2) Run the stored procedures to insert all the details from temp table
            '*/


            Conn.Open()

            '--- Assign the transection
            TransInsert = Conn.BeginTransaction
            IsTransEnable = True


            Dim sqlstring As String = ""

            '------- remove any previous entries if exists

            sqlstring = String.Format("Delete from ItemReqTemporary where curruser like '{0}'", CurrUser)

            dcExecProc = New SqlCommand(sqlstring, Conn)
            dcExecProc.Transaction = TransInsert

            dcExecProc.ExecuteNonQuery()

            TransInsert.Commit()
            IsTransEnable = False

            dcExecProc.Dispose()

            '--------------------------------------------------

       
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)

        Finally
            Conn.Dispose()
            dcExecProc.Dispose()

        End Try

        If IsTransEnable Then
            TransInsert.Rollback()
        End If


    End Sub
#End Region

    Private Sub gvItemDets_CellValueChanged(ByVal sender As System.Object, ByVal e As CellValueChangedEventArgs) Handles gvItemDets.CellValueChanged

        If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) Then
            frmItemSelection.frmHandle = Me
            Me.frmGridRow = e.RowHandle
            frmItemSelection.Show()
            'Me.Enabled = False

        End If
    End Sub

    Private Sub gvItemDets_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvItemDets.InitNewRow
        If gvItemDets.RowCount > 0 Then
            If gvItemDets.GetRowCellValue(gvItemDets.RowCount - 1, "Itemcode") = "" Then
                Exit Sub
            End If

            gvItemDets.SetRowCellValue(e.RowHandle, "Itemcode", Guid.NewGuid)


        End If
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ItemRequest", "Add")

        If CheckAccess = True Then




            If String.Compare(cmdNew.Text, "&New", False) = 0 Then

                ClearFields()
                cmdNew.Text = "&Save"
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False

                tabMain.SelectedTabPageIndex = 1
                tabMain.TabPages(0).PageEnabled = False
            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InsertNewItemReq("Add") Then
                    Exit Sub
                End If

                LoadGridDets()

                '------ we need to delete temporary files after saving the records

                DeleteTempTable()


                MsgBox("Successfully Inserted...", , ErrTitle)



                tabMain.TabPages(0).PageEnabled = True

                cmdNew.Text = "&New"
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True
                LoadGridDets()
                tabMain.SelectedTabPageIndex = 0

            End If


        Else

            MsgBox("You Do Not Have Access")


        End If





    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ItemRequest", "Edit")

        If CheckAccess = True Then





            If String.Compare(cmdEdit.Text, "&Edit", False) = 0 Then

                If txtReqID.Text = "" Or String.IsNullOrWhiteSpace(txtReqID.Text) Or String.IsNullOrEmpty(txtReqID.Text) Then
                    Exit Sub
                End If

                cmdEdit.Text = "&Save"
                cmdNew.Enabled = False
                cmdDelete.Enabled = False

                tabMain.SelectedTabPageIndex = 1
                tabMain.TabPages(0).PageEnabled = False

                txtReqID.Properties.ReadOnly = True

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not EntryVaidation() Then
                    MsgBox("Purchase Requisition created for this Item Requisition, You can't modify.", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InsertNewItemReq("Edit") Then
                    Exit Sub
                End If

                MsgBox("Successfully Update...", , ErrTitle)
                DeleteTempTable()

                cmdEdit.Text = "&Edit"
                cmdNew.Enabled = True
                cmdDelete.Enabled = True
                tabMain.TabPages(0).PageEnabled = True
                'txtReqID.Properties.ReadOnly = False
                LoadGridDets()

                tabMain.SelectedTabPageIndex = 0


            End If

        Else

            MsgBox("You Do Not Have Access")


        End If





    End Sub

    Private Sub gvItemReq_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvItemReq.DoubleClick
        ShowFields(gvItemReq.GetFocusedRowCellValue("ItemReqCode"))
    End Sub

    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ItemRequest", "Delete")

        If CheckAccess = True Then




            If String.IsNullOrEmpty(txtReqID.Text) Then

                Exit Sub
            End If

            If InactivateRequisition(txtReqID.Text) Then
                MsgBox("Successfully Deleted", , ErrTitle)
                LoadGridDets()
                tabMain.SelectedTabPageIndex = 0
            Else
                MsgBox("Unsuccessful Delete operation", MsgBoxStyle.Critical, ErrTitle)
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub gvItemDets_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gvItemDets.KeyDown
        If e.Alt = True And e.KeyCode = Keys.I Then
            ''If gvItemDets.RowCount > 0 And gvItemDets.FocusedRowHandle <> 0 And String.IsNullOrEmpty(Itemcode) Then
            ''Dim x As New CellValueChangedEventArgs(gvItemDets.FocusedRowHandle, gvItemDets.Columns("Itemcode"))
            ''If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) Then
            'frmItemSelection.frmHandle = Me
            'Me.frmGridRow = gvItemDets.FocusedRowHandle ' e.RowHandle
            'frmItemSelection.Show()
            ''Me.Enabled = False

            Dim x As New CellValueChangedEventArgs(gvItemDets.FocusedRowHandle, gvItemDets.Columns("Itemcode"), "")
            gvItemDets_CellValueChanged(sender, x)

            'End If
        End If
    End Sub

    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        If cmdNew.Enabled = False Or cmdEdit.Enabled = False Then
            Dim msgres As MsgBoxResult = MsgBox("There are unsaved datas in this form, do you want to cancel this process", MsgBoxStyle.YesNo)
            If msgres = MsgBoxResult.Yes Then
                Me.Close()

            End If
        Else
            Me.Close()
        End If

    End Sub

    Private Sub cmdPrint_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrint.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ItemRequest", "Print")

        If CheckAccess = True Then






            If txtReqID.Text = "" Then
                MsgBox("Select PO Requisition to print", MsgBoxStyle.Critical)
                Exit Sub

            End If
            'frmPurchReq_Report.POReqCode = txtReqID.Text

            'frmPurchReq_Report.btnPrint_Click()

            frmReportViewerZ.selectionForumla = String.Format("{{vwItemReqMasterDetail.ItemReqCode}}='{0}'", txtReqID.Text)
            frmReportViewerZ.rptPath = "rptItemRequisition.rpt"
            frmReportViewerZ.rptTitle = "Item Requisition Report"
            frmReportViewerZ.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If





    End Sub
End Class