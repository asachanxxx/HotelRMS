Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports System.Runtime.Serialization
Imports System.Xml

Public Class frmGIN

    Public Itemcode, Itemname, CurrQty, OrdQty As String
    Public frmGridRow As Double
 
    Private Sub frmGIN_EnabledChanged(sender As Object, e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled Then
            gvItemDets.SetRowCellValue(frmGridRow, "Itemcode", Itemcode)
            Itemcode = String.Empty

            gvItemDets.SetRowCellValue(frmGridRow, "Itemname", Itemname)
            gvItemDets.SetRowCellValue(frmGridRow, "Stocks", CurrQty)
        End If
    End Sub

    Private Sub frmGIN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGridDets()
        LoadCombos()

        dtGINDate.Text = Now.Date

        txtGINCode.Properties.ReadOnly = True
    End Sub



#Region " Proc & Functions "

    Sub ClearFields()

        txtReference.Text = ""
        txtGINCode.Text = GetGINCode()
        txtCreatedBy.Text = CurrUser
        txtUIDMaster.Text = ""



        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet
        Dim dcDel As New SqlCommand()

        Try
            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daGetDets = New SqlDataAdapter("select * from gintemporary where itemcode like 'nothing'", Conn)
            daGetDets.Fill(dsShow)

            gridItemDets.DataSource = dsShow.Tables(0)

            '---- finally delete all the records from temporary table....
            Conn.Open()

            dcDel = New SqlCommand(String.Format("Delete from GinTemporary where CurrUser like '{0}'", CurrUser), Conn)
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
            Procedure = "spGINInsert"
        Else
            Procedure = "spGINEdit"
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

            sqlstring = String.Format("Delete from GINTemporary where curruser like '{0}'", CurrUser)

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


                sqlstring = "Insert Into GINTemporary (GINCode,GINDate,CreatedBy,FromDept,ToDept,Reference,Itemcode,Itemname,Stocks,GINQty,CurrUser) values("
                sqlstring = sqlstring & "@GINCode,@GINDate,@CreatedBy,@FromDept,@ToDept,@Reference,@Itemcode,@Itemname,@Stocks,@GINQty,@CurrUser)"

                dcExecProc = New SqlCommand(sqlstring, Conn)
                dcExecProc.Transaction = TransInsert



                With dcExecProc.Parameters
                    .Add("@GINCode", SqlDbType.NVarChar, 50).Value = txtGINCode.Text
                    .Add("@GINDate", SqlDbType.Date).Value = dtGINDate.Text
                    .Add("@CreatedBy", SqlDbType.NVarChar).Value = txtCreatedBy.Text
                    .Add("@FromDept", SqlDbType.NVarChar).Value = IIf(IsNothing(cmbFrom.GetColumnValue("DepartmentID")), String.Empty, cmbFrom.GetColumnValue("DepartmentID"))
                    .Add("@ToDept", SqlDbType.NVarChar).Value = IIf(IsNothing(cmbTo.GetColumnValue("DepartmentID")), String.Empty, cmbTo.GetColumnValue("DepartmentID"))
                    .Add("@Reference", SqlDbType.NVarChar).Value = txtReference.Text
                    .Add("@Itemcode", SqlDbType.NVarChar).Value = gvItemDets.GetRowCellValue(i, "Itemcode")
                    .Add("@Itemname", SqlDbType.NVarChar).Value = gvItemDets.GetRowCellValue(i, "Itemname")
                    .Add("@Stocks", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "Stocks") ' GetCurrItemQty(Conn, TransInsert, gvItemDets.GetRowCellValue(i, "Itemcode"))
                    .Add("@GINQty", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "GINQty")
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
                .Add("@GINCODE", SqlDbType.NVarChar).Value = txtGINCode.Text
                .Add("@FromDep", SqlDbType.NVarChar).Value = IIf(IsNothing(cmbFrom.GetColumnValue("DepartmentID")), String.Empty, cmbFrom.GetColumnValue("DepartmentID"))
                .Add("@ToDep", SqlDbType.NVarChar).Value = IIf(IsNothing(cmbTo.GetColumnValue("DepartmentID")), String.Empty, cmbTo.GetColumnValue("DepartmentID"))
                .Add("@GINDATE", SqlDbType.DateTime).Value = dtGINDate.DateTime.Date
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

    Sub ShowFields(ByVal GINcode As String)

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter(String.Format("select * from GINMaster where GINcode like '{0}'", GINcode), Conn)
        Dim dsShow As New DataSet

        Try

            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            txtReference.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Reference")), "", dsShow.Tables(0).Rows(0).Item("Reference"))
            txtGINCode.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("GINCode")), "", dsShow.Tables(0).Rows(0).Item("GINCode"))
            txtCreatedBy.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("CreatedBy")), "", dsShow.Tables(0).Rows(0).Item("CreatedBy"))
            dtGINDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("GINDate")), "", dsShow.Tables(0).Rows(0).Item("GINDate"))
            cmbFrom.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("FromDept")), "", dsShow.Tables(0).Rows(0).Item("FromDept"))
            cmbTo.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ToDept")), "", dsShow.Tables(0).Rows(0).Item("ToDept"))

            daGetDets.Dispose()
            dsShow.Dispose()


            '----- Load the item grid dets
            daGetDets = New SqlDataAdapter(String.Format("select * from GINDetails where GINcode like '{0}'", GINcode), Conn)
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
        Dim daGetDets As New SqlDataAdapter("select * from GINMaster order by GINCode", Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            gridItemReq.DataSource = dsShow.Tables(0)

            dsShow.Dispose()
            daGetDets.Dispose()


            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            dsShow = New DataSet
            daGetDets = New SqlDataAdapter("select * from GINtemporary where itemcode like 'nothing'", Conn)
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

            


            daGetDets = New SqlDataAdapter("select DepartmentID,Department from DepartmentMaster where DepartmentID = 'Ware House' ", Conn)
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
                cmbFrom.EditValue = "Ware House"
            End With

            daGetDets.Dispose()
            dsShow.Dispose()

            '-------------------------------------

            daGetDets = New SqlDataAdapter("select DepartmentID,Department from DepartmentMaster where DepartmentID <> 'Ware House'", Conn)
            daGetDets.Fill(dsShow)

            With cmbTo.Properties
                .DataSource = dsShow.Tables(0)
                .DisplayMember = "Department"
                .ValueMember = "DepartmentID"
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
        Return IIf(String.Compare(txtGINCode.Text, "", False) = 0 Or String.Compare(dtGINDate.Text, "", False) = 0 Or String.Compare(cmbTo.Text, "", False) = 0 Or ItemcodeValid() = False, 0, 1)
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
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "GIN"
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

#End Region

    Private Sub gvItemDets_CellValueChanged(ByVal sender As System.Object, ByVal e As CellValueChangedEventArgs) Handles gvItemDets.CellValueChanged

        'If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) And Not String.IsNullOrEmpty(cmbFrom.EditValue) Then
        '    frmItemSelection.frmHandle = Me
        '    Me.frmGridRow = e.RowHandle
        '    frmItemSelection.InvLocation = cmbFrom.EditValue
        '    frmItemSelection.Show()
        '    ' Me.Enabled = False

        'ElseIf e.Column.FieldName = "GINQty" Then

        '    If gvItemDets.GetRowCellValue(e.RowHandle, "GINQty") > gvItemDets.GetRowCellValue(e.RowHandle, "Stocks") Then
        '        cmdNew.Enabled = False

        '    End If

        'End If


        If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) And Not String.IsNullOrEmpty(cmbFrom.EditValue) Then
            frmItemSelection.frmHandle = Me
            Me.frmGridRow = e.RowHandle
            frmItemSelection.InvLocation = cmbFrom.EditValue
            frmItemSelection.Show()
            ' Me.Enabled = False

        ElseIf e.Column.FieldName = "GINQty" Then

            If gvItemDets.GetRowCellValue(e.RowHandle, "GINQty") > 0 AndAlso gvItemDets.GetRowCellValue(e.RowHandle, "GINQty") > gvItemDets.GetRowCellValue(e.RowHandle, "Stocks") Then
                cmdNew.Enabled = False

            End If

        End If









    End Sub

    Private Sub gvItemDets_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
        If gvItemDets.RowCount > 0 Then
            If gvItemDets.GetRowCellValue(gvItemDets.RowCount - 1, "Itemcode") = "" Then
                Exit Sub
            End If

            gvItemDets.SetRowCellValue(e.RowHandle, "Itemcode", Guid.NewGuid)


        End If
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GoodIssuedNote", "Add")

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

            If txtGINCode.Text = "" Then
                Exit Sub
            End If

            cmdEdit.Text = "Save"
            cmdNew.Enabled = False
            cmdDelete.Enabled = False

            tabMain.SelectedTabPageIndex = 1
            txtGINCode.Properties.ReadOnly = True
            tabMain.TabPages(0).PageEnabled = False
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
            LoadGridDets()
            tabMain.SelectedTabPageIndex = 0
            tabMain.TabPages(0).PageEnabled = True

        End If
    End Sub

    Private Sub gvItemDets_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvItemDets.DoubleClick
        ShowFields(gvItemDets.GetFocusedRowCellValue("GINCode"))
    End Sub

    Private Sub gvItemReq_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gvItemReq.DoubleClick
        ShowFields(gvItemReq.GetFocusedRowCellValue("GINCode"))
    End Sub


    Private Sub frmGIN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

    End Sub
End Class