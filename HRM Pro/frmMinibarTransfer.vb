Imports System.Data.SqlClient

Public Class frmMinibarTransfer

    Public Itemcode, Itemname, CurrQty, OrdQty, Templatecode As String
    Public frmGridRow As Double

    Private Sub frmMinibarTransfer_EnabledChanged(sender As Object, e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled Then

            'If String.IsNullOrEmpty(Templatecode) Then
            '    gvItemDets.SetRowCellValue(frmGridRow, "Itemcode", Itemcode)
            '    Itemcode = String.Empty

            '    gvItemDets.SetRowCellValue(frmGridRow, "Itemname", Itemname)
            '    gvItemDets.SetRowCellValue(frmGridRow, "Stocks", CurrQty)
            'Else
            '    Call InsertItemTemplateDets(Templatecode)
            'End If

            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            Dim dsshow As New DataSet
            Dim daGetDets As New SqlDataAdapter
            Dim conn As New SqlConnection(ConnString)

            Try

                gridItemDets.DataSource = Nothing

                dsshow = New DataSet
                daGetDets = New SqlDataAdapter(String.Format("select * from MiniBarTransfertemporary where MBTCode like '{0}'", txtMBTCode.Text), conn)
                daGetDets.Fill(dsshow)

                gridItemDets.DataSource = dsshow.Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Finally
                conn.Dispose()
                dsshow.Dispose()
                daGetDets.Dispose()
            End Try

           
        End If

    End Sub


    Private Sub frmMinibarTransfer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGridDets()
        LoadCombos()

        dtMBTDate.Text = Now.Date

        txtMBTCode.Properties.ReadOnly = True

        'gvItemDets.AddNewRow()
        ' gvItemDets.SetRowCellValue(gvItemDets.RowCount - 1, "Stocks", "10")

    End Sub

#Region " Proc & Functions "

    Sub ClearFields()

        txtReference.Text = ""
        txtMBTCode.Text = GetGINCode()
        txtTransferedBy.Text = CurrUser
        txtUIDMaster.Text = ""



        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet
        Dim dcDel As New SqlCommand()

        Try
            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daGetDets = New SqlDataAdapter("select * from minibartransfertemporary where MBTCode like 'nothing'", Conn)
            daGetDets.Fill(dsShow)

            gridItemDets.DataSource = dsShow.Tables(0)

            '---- finally delete all the records from temporary table....
            Conn.Open()

            dcDel = New SqlCommand(String.Format("Delete from minibartransfertemporary where CurrUser like '{0}'", CurrUser), Conn)
            dcDel.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
            dcDel.Dispose()
        End Try



        'gridItemDets.DataSource = Nothing
    End Sub

    ''' <summary>
    ''' Insert New Item Req 
    ''' </summary>
    ''' <returns>True-Sucess,False-Failed</returns>
    ''' <remarks></remarks>
    Function InsertNewGIN(ByVal Proc As String) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim Procedure As String
        Dim TransInsert As SqlTransaction
        Dim IsTransEnable As Boolean = False  'Track the transection status

        If String.Compare(Proc, "Add", False) = 0 Then
            Procedure = "spMBTInsert"
        Else
            Procedure = "spMBTEdit"
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

            sqlstring = String.Format("Delete from MiniBarTransferTemporary where curruser like '{0}'", CurrUser)

            dcExecProc = New SqlCommand(sqlstring, Conn)
            dcExecProc.Transaction = TransInsert

            dcExecProc.ExecuteNonQuery()




            For i As Int16 = 0 To gvItemDets.RowCount - 1


                If gvItemDets.GetRowCellValue(i, "Itemcode") = "" Then
                    Exit For
                End If

                If IsDBNull(gvItemDets.GetRowCellValue(i, "MBarQty")) Then
                    Throw New Exception("Order Quantytity must be non zero value")
                    Exit For
                End If


                sqlstring = "Insert Into MiniBarTransferTemporary (MBTCode,MBTDate,TransferedBy,RoomNo,Reference,FromDept,Itemcode,Itemname,MBarQty,Stocks,CurrUser) values("
                sqlstring = sqlstring & "@MBTCode,@MBTDate,@TransferedBy,@RoomNo,@Reference,@FromDept,@Itemcode,@Itemname,@MBarQty,@Stocks,@CurrUser)"

                dcExecProc = New SqlCommand(sqlstring, Conn)
                dcExecProc.Transaction = TransInsert



                With dcExecProc.Parameters
                    .Add("@MBTCode", SqlDbType.NVarChar, 50).Value = txtMBTCode.Text
                    .Add("@MBTDate", SqlDbType.Date).Value = dtMBTDate.Text
                    .Add("@TransferedBy", SqlDbType.NVarChar).Value = txtTransferedBy.Text
                    .Add("@RoomNo", SqlDbType.NVarChar).Value = IIf(IsNothing(cmbTo.GetColumnValue("RoomNo")), String.Empty, cmbTo.GetColumnValue("RoomNo"))
                    '.Add("@UIDMaster", SqlDbType.NVarChar).Value = txtUIDMaster.Text
                    .Add("@Reference", SqlDbType.NVarChar).Value = txtReference.Text
                    .Add("@FromDept", SqlDbType.NVarChar).Value = IIf(IsNothing(cmbFrom.GetColumnValue("DepartmentID")), String.Empty, cmbFrom.GetColumnValue("DepartmentID"))
                    .Add("@Itemcode", SqlDbType.NVarChar, 50).Value = gvItemDets.GetRowCellValue(i, "Itemcode")
                    .Add("@Itemname", SqlDbType.NVarChar, 50).Value = gvItemDets.GetRowCellValue(i, "Itemname")
                    .Add("@Stocks", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "Stocks") ' GetCurrItemQty(Conn, TransInsert, gvItemDets.GetRowCellValue(i, "Itemcode"))
                    .Add("@MBarQty", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "MBarQty")
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
                .Add("@MBTCODE", SqlDbType.NVarChar).Value = txtMBTCode.Text
                .Add("@FromDep", SqlDbType.NVarChar).Value = IIf(IsNothing(cmbFrom.GetColumnValue("DepartmentID")), String.Empty, cmbFrom.GetColumnValue("DepartmentID"))
                .Add("@ToDep", SqlDbType.NVarChar).Value = "MiniBar" 'IIf(IsNothing(cmbFrom.GetColumnValue("DepartmentID")), String.Empty, cmbFrom.GetColumnValue("DepartmentID"))
                .Add("@RoomNo", SqlDbType.NVarChar).Value = IIf(IsNothing(cmbTo.GetColumnValue("RoomNo")), String.Empty, cmbTo.GetColumnValue("RoomNo"))
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

    Sub ShowFields(ByVal MBTcode As String)

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter(String.Format("select * from MiniBarTransferMaster where MBtcode like '{0}'", MBTcode), Conn)
        Dim dsShow As New DataSet

        Try

            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            txtReference.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Reference")), "", dsShow.Tables(0).Rows(0).Item("Reference"))
            txtMBTCode.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("MBTCode")), "", dsShow.Tables(0).Rows(0).Item("MBTCode"))
            txtTransferedBy.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("TransferedBy")), "", dsShow.Tables(0).Rows(0).Item("TransferedBy"))
            dtMBTDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("MBTDate")), "", dsShow.Tables(0).Rows(0).Item("MBTDate"))
            cmbFrom.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("FromDept")), "", dsShow.Tables(0).Rows(0).Item("FromDept"))
            cmbTo.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("RoomNO")), "", dsShow.Tables(0).Rows(0).Item("RoomNO"))


            daGetDets.Dispose()
            dsShow.Dispose()


            '----- Load the item grid dets
            daGetDets = New SqlDataAdapter(String.Format("select * from MiniBarTransferDetails where MBTCode like '{0}'", MBTcode), Conn)
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
        Dim daGetDets As New SqlDataAdapter("select * from MiniBarTransferMaster order by MBTCode", Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            gridItemReq.DataSource = dsShow.Tables(0)

            dsShow.Dispose()
            daGetDets.Dispose()


            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            dsShow = New DataSet
            daGetDets = New SqlDataAdapter("select * from MiniBarTransfertemporary where MBTCode like 'nothing'", Conn)
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
        Dim dsFrom, dsShow, dsGridLookup As New DataSet

        Try

            '----- Load Department Master




            daGetDets = New SqlDataAdapter("select DepartmentID,Department from DepartmentMaster where DepartmentID = 'House Keeping' ", Conn)
            daGetDets.Fill(dsFrom)


            'Dim dtDefault As DataRow = dsFrom.Tables(0).NewRow

            'dtDefault.Item(0) = "Ware House"
            'dtDefault.Item(1) = "Ware House"


            'dsShow.Tables(0).Rows.Add(dtDefault)

            With cmbFrom.Properties
                .DataSource = dsFrom.Tables(0)
                .DisplayMember = "Department"
                .ValueMember = "DepartmentID"
                .AutoSearchColumnIndex = 0
                '.Columns(0).Width = 125
                '.Columns(1).Width = 275
                '.PopupWidth = 400
                'cmbFrom.Text = "Ware House"
                'cmbFrom.Enabled = False
                'cmbFrom.SelectedText = "Ware House"
                cmbFrom.EditValue = "House Keeping"
            End With

            daGetDets.Dispose()
            dsShow.Dispose()

            '-------------------------------------

            daGetDets = New SqlDataAdapter("select RoomNo from [Rooms.Master]", Conn)
            daGetDets.Fill(dsShow)

            With cmbTo.Properties
                .DataSource = dsShow.Tables(0)
                .DisplayMember = "RoomNo"
                .ValueMember = "RoomNo"
                '.Columns(0).Width = 125
                '.Columns(1).Width = 275

                .AutoSearchColumnIndex = 0
                'cmbTo.EditValue = "Ware House"

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
        Return IIf(String.Compare(txtMBTCode.Text, "", False) = 0 Or String.Compare(dtMBTDate.Text, "", False) = 0 Or String.Compare(cmbTo.Text, "", False) = 0 Or ItemcodeValid() = False, 0, 1)
    End Function

    Function GetGINCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "MiniBar"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output

            dcGetCode.ExecuteNonQuery()

            GetGINCode = dcGetCode.Parameters("@Currcode").Value


            Return GetGINCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function

    Function InActiveCategory() As Boolean

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

    Function GetCurrItemQty(ByVal Conn As SqlConnection, ByVal Itemcode As String) As Double

        Dim daGetCurrQty As New SqlDataAdapter()
        Dim dsShowMe As New DataSet

        Try

            daGetCurrQty = New SqlDataAdapter(String.Format("select Stocks from vwItemSelection where Itemcode like '{0}' and Location like 'House Keeping'", Itemcode), Conn)
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

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GINSforMiniBar", "Add")

        If CheckAccess = True Then




            If String.Compare(cmdNew.Text, "New", False) = 0 Then

                ClearFields()
                cmdNew.Text = "Save"
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False

                tabMain.SelectedTabPageIndex = 1
                tabMain.TabPages(0).PageEnabled = False
            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InsertNewGIN("Add") Then
                    Exit Sub
                End If

                MsgBox("Successfully Inserted...", , ErrTitle)

                cmdNew.Text = "New"
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True
                LoadGridDets()
                tabMain.SelectedTabPageIndex = 0
                tabMain.TabPages(0).PageEnabled = True

            End If



        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If String.Compare(cmdEdit.Text, "Edit", False) = 0 Then


            cmdEdit.Text = "Save"
            cmdNew.Enabled = False
            cmdDelete.Enabled = False

            tabMain.SelectedTabPageIndex = 1
            txtMBTCode.Properties.ReadOnly = True

        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub
            End If

            If Not InsertNewGIN("Edit") Then
                Exit Sub
            End If

            MsgBox("Successfully Update...", , ErrTitle)

            cmdEdit.Text = "Edit"
            cmdNew.Enabled = True
            cmdDelete.Enabled = True

            'txtReqID.Properties.ReadOnly = False

            tabMain.SelectedTabPageIndex = 0

        End If
    End Sub

    Private Sub gvItemDets_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowFields(gvItemDets.GetFocusedRowCellValue("MBTCode"))
    End Sub


    Private Sub gvItemReq_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gvItemReq.DoubleClick
        ShowFields(gvItemReq.GetFocusedRowCellValue("MBTCode"))
    End Sub


    Sub InsertItemTemplateDets(ByVal TplCode As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daTpl As New SqlDataAdapter()
        Dim dsGetAll As New DataSet

        
        Try

            Conn.Open()

            daTpl = New SqlDataAdapter(String.Format("select * from ItemTemplateDetails where MainItemCode like '{0}'", TplCode), Conn)
            daTpl.Fill(dsGetAll)

            'gridItemDets.DataSource = Nothing

            


            For i As Int16 = 0 To dsGetAll.Tables(0).Rows.Count - 1
                gvItemDets.AddNewRow()
                frmGridRow = i 'gvItemDets.RowCount - 1
                gvItemDets.SetRowCellValue(frmGridRow, "Itemcode", dsGetAll.Tables(0).Rows(i).Item("SubItemCode"))
                gvItemDets.SetRowCellValue(frmGridRow, "Itemname", dsGetAll.Tables(0).Rows(i).Item("SubItemName"))
                gvItemDets.SetRowCellValue(frmGridRow, "Stocks", GetCurrItemQty(Conn, dsGetAll.Tables(0).Rows(i).Item("SubItemCode")))

            Next


            For i As Int16 = 0 To gvItemDets.RowCount - 1

                If gvItemDets.GetRowCellValue(i, "Itemcode").ToString = "" Then
                    gvItemDets.DeleteRow(i)
                End If

            Next

            Templatecode = String.Empty

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daTpl.Dispose()
            dsGetAll.Dispose()

        End Try


    End Sub
#End Region

    Private Sub gvItemDets_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvItemDets.CellValueChanged
        If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) And String.IsNullOrEmpty(Templatecode) And Not String.IsNullOrEmpty(cmbFrom.EditValue) Then

            If txtMBTCode.Text = "" Then
                MsgBox("Transfer Code cannot be empty..", MsgBoxStyle.Critical, ErrTitle)
            End If

            frmMinibarItemSelect.frmHandle = Me
            Me.frmGridRow = e.RowHandle
            frmMinibarItemSelect.InvLocation = cmbFrom.EditValue
            frmMinibarItemSelect.MBTCode = txtMBTCode.Text
            frmMinibarItemSelect.Show()
            Me.Enabled = False

        End If
    End Sub



    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        If cmdNew.Enabled = False Or cmdEdit.Enabled = False Then
            Dim msgres As MsgBoxResult = MsgBox("There are unsaved datas in this form, do you want to cancel this process")
            If msgres = MsgBoxResult.Yes Then
                Me.Close()

            End If
        End If
    End Sub

    Private Sub frmMinibarTransfer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class