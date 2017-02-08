Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports System.Runtime.Serialization

Public Class frmPurchReq
    Public Itemcode, Itemname, CurrQty, OrdQty As String
    Public frmGridRow As Double

    Private Sub cmdNew_Click(sender As System.Object, e As System.EventArgs) Handles cmdNew.Click



        Dim CheckAccess As Boolean = UserPermission(CurrUser, "PurchaseRequisitions", "Add")

        If CheckAccess = True Then




        If cmdNew.Text = "New" Then

            ClearFields()

            tabMain.SelectedTabPageIndex = 1
            tabMain.TabPages(0).PageEnabled = False

            cmdNew.Text = "Record"
            cmdEdit.Enabled = False
            cmdDelete.Enabled = False
        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub
            End If

            If Not InsertNewItemReq("Add") Then
                Exit Sub
            End If

            DeleteTempTable()

            MsgBox("Successfully Inserted...", , ErrTitle)

            cmdNew.Text = "New"
            cmdEdit.Enabled = True
            cmdDelete.Enabled = True

            LoadMain()
            tabMain.TabPages(0).PageEnabled = True
            tabMain.SelectedTabPageIndex = 0
            End If



        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub frmPurchReq_EnabledChanged(sender As Object, e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled Then

            LoadGridDets()
           
        End If
    End Sub

    Private Sub frmPurchReq_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadMain()
        'LoadGridDets()
        LoadCombos()

        dtReqDate.Text = Now.Date

        txtReqID.Properties.ReadOnly = True

    End Sub

    Private Sub gvItemDets_CellValueChanged2(ByVal sender As System.Object, ByVal e As CellValueChangedEventArgs)

        'If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) Then
        '    frmItemSelection.frmHandle = Me
        '    Me.frmGridRow = e.RowHandle
        '    frmItemSelection.Show()
        '    Me.Enabled = False

        'End If
    End Sub

    Private Sub gvItemDets_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
        If gvItemDets.RowCount > 0 Then
            If gvItemDets.GetRowCellValue(gvItemDets.RowCount - 1, "Itemcode") = "" Then
                Exit Sub
            End If

            gvItemDets.SetRowCellValue(e.RowHandle, "Itemcode", Guid.NewGuid)


        End If
    End Sub

    Private Sub gvPOReq_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvPOReq.DoubleClick
        ShowFields(gvPOReq.GetFocusedRowCellValue("POReqCode"))
    End Sub


#Region " Proc & Functions "

    Sub ClearFields()

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter("select * from POReqMaster where status=1", Conn)
        Dim dsShow As New DataSet

        Dim dcDel As New SqlCommand



        Try

            Conn.Open()

            txtReference.Text = ""
            txtReqID.Text = GetPOReqCode()
            txtRequestBy.Text = CurrUser
            cmbPriority.Text = "Medium"
            txtUIDMaster.Text = Guid.NewGuid.ToString()

            dcDel = New SqlCommand(String.Format("delete from poreqtemporary where curruser like '{0}'", CurrUser), Conn)
            dcDel.ExecuteNonQuery()


            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daGetDets = New SqlDataAdapter("select * from poreqtemporary where itemcode like 'nothing'", Conn)
            daGetDets.Fill(dsShow)

            gridItemDets.DataSource = dsShow.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            dcDel.Dispose()
            dsShow.Dispose()
            daGetDets.Dispose()
        End Try


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

        If String.Compare(Proc, "Add", False) = 0 Then
            Procedure = "spPOReqInsert"
        Else
            Procedure = "spPOReqEdit"
        End If

        Dim dcExecProc As New SqlCommand()

        Try


            '/* 
            '    In this process two things going to happen. 
            ' 1) Insert all the details to temp table 
            ' 2) Run the stored procedures to insert all the details from temp table
            '*/


            Conn.Open()


            For i As Int16 = 0 To gvItemDets.RowCount - 1


                If gvItemDets.GetRowCellValue(i, "Itemcode") = "" Then
                    Exit For
                End If

                If IsDBNull(gvItemDets.GetRowCellValue(i, "OrdQty")) Then
                    Throw New Exception("Order Quantytity must be non zero value")
                    Exit For
                End If

            Next


            dcExecProc = New SqlCommand(Procedure, Conn)
            dcExecProc.CommandType = CommandType.StoredProcedure


            Dim UIDMaster As Guid = New Guid(txtUIDMaster.Text)

            With dcExecProc.Parameters
                .Add("@POREQCODE", SqlDbType.NVarChar, 50).Value = txtReqID.Text
                .Add("@ReqDate", SqlDbType.Date).Value = dtReqDate.Text
                .Add("@CREATEDBY", SqlDbType.NVarChar).Value = txtRequestBy.Text
                .Add("@SUPPLIERID", SqlDbType.NVarChar).Value = IIf(IsNothing(cmbSupplier.GetColumnValue("Suppliercode")), String.Empty, cmbSupplier.GetColumnValue("Suppliercode"))
                .Add("@Reference", SqlDbType.NVarChar).Value = txtReference.Text
                .Add("@PRIORITYLEVEL", SqlDbType.NVarChar).Value = cmbPriority.Text
                .Add("@UIDMASTER", SqlDbType.UniqueIdentifier).Value = UIDMaster
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

  

    End Function

    Sub ShowFields(ByVal POReqcode As String)

        Dim Conn As New SqlConnection(modMain.ConnString)

        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet
        Dim dcRunProcs As New SqlCommand()

        Try

            dcRunProcs = New SqlCommand("spPOReqView", Conn)
            dcRunProcs.CommandType = CommandType.StoredProcedure

            With dcRunProcs.Parameters
                .Add("@POREQCODE", SqlDbType.NVarChar).Value = POReqcode
                .Add("@CURRUSER", SqlDbType.NVarChar).Value = CurrUser
            End With

            daGetDets.SelectCommand = dcRunProcs
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If



            txtReference.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Reference")), "", dsShow.Tables(0).Rows(0).Item("Reference"))
            txtReqID.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("POReqCode")), "", dsShow.Tables(0).Rows(0).Item("POReqCode"))
            txtRequestBy.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("CreatedBy")), "", dsShow.Tables(0).Rows(0).Item("CreatedBy"))
            dtReqDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ReqDate")), "", dsShow.Tables(0).Rows(0).Item("ReqDate"))
            cmbPriority.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("PriorityLevel")), "", dsShow.Tables(0).Rows(0).Item("PriorityLevel"))
            cmbSupplier.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("SupplierID")), "", dsShow.Tables(0).Rows(0).Item("SupplierID"))
            txtUIDMaster.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("UIDMaster")), "", dsShow.Tables(0).Rows(0).Item("UIDMaster").ToString())

            gridItemDets.DataSource = dsShow.Tables(0)


            'gvItemDets.Columns("ItemRate").Dispose()

            'Dim datacol As New DataColumn("ItemRate", System.Type.GetType("System.Double"))
            'dsShow.Tables(0).Columns.Add(datacol)

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

    Sub LoadMain()

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter("select * from POReqMaster where status=1 order by POReqCode", Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            gridPOReq.DataSource = dsShow.Tables(0)

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
        Dim daGetDets As New SqlDataAdapter("select * from POReqMaster where status=1 order by POReqCode", Conn)
        Dim dsShow As New DataSet

        Try
 
            gridItemDets.DataSource = Nothing

            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daGetDets = New SqlDataAdapter(String.Format("select * from POReqtemporary where curruser like '{0}' and POReqCode like '{1}' ", CurrUser, txtReqID.Text), Conn)
            daGetDets.Fill(dsShow)

 
            gridItemDets.DataSource = dsShow.Tables(0)

            Dim CurrQty As Double

            For i As Int16 = 0 To gvItemDets.RowCount - 1
                CurrQty = GetCurrItemQty(gvItemDets.GetRowCellValue(i, "Itemcode"))
                gvItemDets.SetRowCellValue(i, "CurrQty", CurrQty)
            Next

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

            daGetDets = New SqlDataAdapter("select Suppliercode,Suppliername from SupplierMaster", Conn)
            daGetDets.Fill(dsShow)

            With cmbSupplier.Properties
                .DataSource = dsShow.Tables(0)
                .DisplayMember = "Suppliername"
                .ValueMember = "Suppliercode"
                .Columns(0).Width = 125
                .Columns(1).Width = 275
                .PopupWidth = 400

            End With

            '----- Load Item Master to Grid

            'daGridLookup = New SqlDataAdapter("select Itemcode from ItemMaster", Conn)
            'daGridLookup.Fill(dsGridLookup)

            'For i As Integer = 0 To dsGridLookup.Tables(0).Rows.Count - 1
            '    repItemList.Items.Add(dsGridLookup.Tables(0).Rows(i).Item(0))
            'Next



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
        Return IIf(String.Compare(txtReqID.Text, "", False) = 0 Or String.Compare(dtReqDate.Text, "", False) = 0 Or ItemcodeValid() = False Or IsNothing(cmbSupplier.GetColumnValue("Suppliercode")), 0, 1)
    End Function

    Function GetPOReqCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "POReq"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output

            dcGetCode.ExecuteNonQuery()

            GetPOReqCode = dcGetCode.Parameters("@Currcode").Value


            Return GetPOReqCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function

    Function InactivateRequisition(ByVal ItemReqCode As String) As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExecDel As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Dim msgbxrslt As MsgBoxResult = MsgBox("Are you sure,you want to delete this PO Requisition", MsgBoxStyle.YesNo, ErrTitle)

            If msgbxrslt = MsgBoxResult.No Then
                Return False
            End If

            Conn.Open()

            dcExecDel = New SqlCommand(String.Format("update POReqMaster set status = 0 where POReqCode ='{0}'", ItemReqCode), Conn)
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

    Function ItemcodeValid() As Boolean

        Try
            If gvItemDets.RowCount = 0 Then
                Return False
            End If

            For i As Integer = 0 To gvItemDets.RowCount - 1
                If IsDBNull(gvItemDets.GetRowCellValue(i, "Itemcode")) Then
                    Throw New Exception("Itemcode can't be empty")
                End If
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        End Try

    End Function

    Function GetCurrItemQty(ByVal Itemcode As String) As Double

        Dim Conn As New SqlConnection(ConnString)
        Dim daGetCurrQty As New SqlDataAdapter()
        Dim dsShowMe As New DataSet

        Try

            daGetCurrQty = New SqlDataAdapter(String.Format("select Stocks from ItemMaster where Itemcode like '{0}'", Itemcode), Conn)
            daGetCurrQty.Fill(dsShowMe)

            If dsShowMe.Tables(0).Rows.Count > 0 Then
                GetCurrItemQty = IIf(IsDBNull(dsShowMe.Tables(0).Rows(0).Item(0)), 0, dsShowMe.Tables(0).Rows(0).Item(0))
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

    Function AuthorizeRequisition(ByVal ItemReqCode As String) As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExecDel As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Dim msgbxrslt As MsgBoxResult = MsgBox("Do you want to Authorized this Purchase Order Requisition", MsgBoxStyle.YesNo, ErrTitle)

            If msgbxrslt = MsgBoxResult.No Then
                Return False
            End If

            Conn.Open()

            dcExecDel = New SqlCommand(String.Format("update POReqMaster set IsAuthorized = 1 where POReqCode ='{0}'", ItemReqCode), Conn)
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

    Function CertifyRequisition(ByVal ItemReqCode As String) As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExecDel As New SqlCommand()

        Dim dcExecDel2 As New SqlCommand()

        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Dim msgbxrslt As MsgBoxResult = MsgBox("Do you want to Certified this Purchase Order", MsgBoxStyle.YesNo, ErrTitle)

            If msgbxrslt = MsgBoxResult.No Then
                Return False
            End If

            Conn.Open()

            dcExecDel = New SqlCommand(String.Format("update POReqMaster set IsCertified = 1 where POReqCode ='{0}'", ItemReqCode), Conn)
            dcExecDel.ExecuteNonQuery()


            dcExecDel2 = New SqlCommand(String.Format("update bnmaster set IsAuthorized = 1 where BNCode ='{0}'", ItemReqCode), Conn)
            dcExecDel2.ExecuteNonQuery()



            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcExecDel.Dispose()

        End Try

    End Function

    Function DataAuthenticationChecking(ByVal RowHandle As Int16) As Boolean
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try

            '----- Load Department Master
            Dim POReqCode As String = gvPOReq.GetRowCellValue(RowHandle, "POReqCode")

            If String.IsNullOrEmpty(POReqCode) Then
                Exit Function
            End If

            daGetDets = New SqlDataAdapter(String.Format("select IsAuthorized,IsCertified from POReqMaster where POReqCode like '{0}'", POReqCode), Conn)
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count > 0 Then
                cmdAuthorized.Enabled = Not dsShow.Tables(0).Rows(0).Item(0)
                cmdCertified.Enabled = Not dsShow.Tables(0).Rows(0).Item(1)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Function


    ''' <summary>
    ''' Validate for Any Purchase Requisition is created for given Item Requisition
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function EntryVaidation() As Boolean
        Dim Conn As New SqlConnection(ConnString)


        Dim daGetCode As New SqlDataAdapter(String.Format("Select POReqCode from POMaster where POReqCode like '{0}'", txtReqID.Text.Trim), Conn)
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

        Dim dcExecProc As New SqlCommand() '"Delete from POReqTemporary where curruser like '" & CurrUser & "'", Conn)

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

            sqlstring = String.Format("Delete from POReqTemporary where curruser like '{0}'", CurrUser)

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

    Sub UpdateItems()

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim TransInsert As SqlTransaction
        Dim IsTransEnable As Boolean = False  'Track the transection status

        Dim dcExecProc As New SqlCommand() '"Delete from POReqTemporary where curruser like '" & CurrUser & "'", Conn)

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


            Dim sqlstring As String = "update POReqTemporary set ordqty =@OrdQty where poreqcode = @poreqcode and itemcode=@itemcode"


            'sqlstring = String.Format("Delete from POReqTemporary where curruser like '{0}'", CurrUser)

            dcExecProc = New SqlCommand(sqlstring, Conn)
            With dcExecProc.Parameters
                .Add("@poreqcode", SqlDbType.NVarChar).Value = txtReqID.Text
                .Add("@itemcode", SqlDbType.NVarChar).Value = gvItemDets.GetRowCellValue(gvItemDets.FocusedRowHandle, "Itemcode")
                .Add("@OrdQty", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(gvItemDets.FocusedRowHandle, "OrdQty")
            End With


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

    Private Sub cmdItemReq_Click(sender As System.Object, e As System.EventArgs) Handles cmdItemReq.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "PurchaseRequisitions", "Add")

        If CheckAccess = True Then


            If cmdNew.Text = "Record" Or cmdEdit.Text = "Save" And txtReqID.Text <> "" Then
                frmItemReqConvertion.txtPurchReqCode.Text = txtReqID.Text
                frmItemReqConvertion.Show()
                Me.Enabled = False
            End If




        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "PurchaseRequisitions", "Edit")

        If CheckAccess = True Then




            If String.Compare(cmdEdit.Text, "Edit", False) = 0 Then


                cmdEdit.Text = "Save"
                cmdNew.Enabled = False
                cmdDelete.Enabled = False

                txtReqID.Properties.ReadOnly = True

                tabMain.SelectedTabPageIndex = 1
                tabMain.TabPages(0).PageEnabled = False

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not EntryVaidation() Then
                    MsgBox("Purchase Order created for this PO Requisition, You can't modify.", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InsertNewItemReq("Edit") Then
                    Exit Sub
                End If

                DeleteTempTable()
                MsgBox("Successfully Update...", , ErrTitle)

                cmdEdit.Text = "Edit"
                cmdNew.Enabled = True
                cmdDelete.Enabled = True

                'txtReqID.Properties.ReadOnly = False

                tabMain.SelectedTabPageIndex = 0
                tabMain.TabPages(0).PageEnabled = True

            End If


        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub



    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "PurchaseRequisitions", "Delete")

        If CheckAccess = True Then



            If String.IsNullOrEmpty(txtReqID.Text) Then
                Exit Sub
            End If
            If InactivateRequisition(txtReqID.Text) Then
                MsgBox("Successfully Deleted", , ErrTitle)

                LoadMain()
                tabMain.SelectedTabPageIndex = 0
            Else
                MsgBox("Unsuccessful Delete operation", MsgBoxStyle.Critical, ErrTitle)
            End If



        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub

    
    Private Sub cmdAuthorized_Click(sender As System.Object, e As System.EventArgs) Handles cmdAuthorized.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "PurchaseRequisitions", "Authorize")

        If CheckAccess = True Then



            If String.IsNullOrEmpty(txtReqID.Text) Then
                Exit Sub
            End If
            If AuthorizeRequisition(txtReqID.Text) Then
                MsgBox("Authorization Successfull", , ErrTitle)
                DataAuthenticationChecking(gvPOReq.FocusedRowHandle)
                LoadMain()
                tabMain.SelectedTabPageIndex = 0
            Else
                MsgBox("Authorization Failed", MsgBoxStyle.Critical, ErrTitle)
            End If



        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub cmdCertified_Click(sender As System.Object, e As System.EventArgs) Handles cmdCertified.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "PurchaseRequisitions", "Certify")

        If CheckAccess = True Then




            If String.IsNullOrEmpty(txtReqID.Text) Then
                Exit Sub
            End If
            If CertifyRequisition(txtReqID.Text) Then
                MsgBox("Successfully Certified", , ErrTitle)
                DataAuthenticationChecking(gvPOReq.FocusedRowHandle)

                LoadMain()
                tabMain.SelectedTabPageIndex = 0
            Else
                MsgBox("Failed to Certify the Purchase Order Requisition", MsgBoxStyle.Critical, ErrTitle)
            End If



        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub

   
    Private Sub cmdPrint_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrint.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "PurchaseRequisitions", "Print")

        If CheckAccess = True Then


            If txtReqID.Text = "" Then
                MsgBox("Select PO Requisition to print", MsgBoxStyle.Critical)
                Exit Sub

            End If
            'frmPurchReq_Report.POReqCode = txtReqID.Text

            'frmPurchReq_Report.btnPrint_Click()

            frmReportViewerZ.selectionForumla = String.Format("{{rptPurchaseRequisition.POReqCode}}='{0}'", txtReqID.Text)
            frmReportViewerZ.rptPath = "rptPurchaseRequisition.rpt"
            frmReportViewerZ.rptTitle = "Purchase Requisition_Report"
            frmReportViewerZ.Show()

            'frmReportViewerZ.rptPath = ReportName
            'frmReportViewerZ.rptTitle = rptTitle
            'frmReportViewerZ.selectionForumla = fltString



        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub gvPOReq_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPOReq.FocusedRowChanged
        DataAuthenticationChecking(e.FocusedRowHandle)
    End Sub

    Private Sub gvPOReq_SelectionChanged(sender As System.Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles gvPOReq.SelectionChanged
        DataAuthenticationChecking(gvPOReq.FocusedRowHandle)
    End Sub

    Private Sub gvItemDets_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvItemDets.CellValueChanged

        If cmdAuthorized.Enabled = False OrElse cmdCertified.Enabled = False Then
            MsgBox("Authorized or Certified Requisition can not be Edited", MsgBoxStyle.Critical, ErrTitle)
            Exit Sub
        End If

        If e.Column.FieldName = "OrdQty" Then

            If IsDBNull(gvItemDets.GetRowCellValue(gvItemDets.FocusedRowHandle, "OrdQty")) OrElse gvItemDets.GetRowCellValue(gvItemDets.FocusedRowHandle, "OrdQty") < 0 Then
                MsgBox("Invalid Qty,please type in correct format", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub
            ElseIf gvItemDets.GetRowCellValue(gvItemDets.FocusedRowHandle, "OrdQty") = 0 Then
                MsgBox("Zero Qty not allowed", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub
            End If

            'If cmdEdit.Text = "Save" Then
            UpdateItems()
            'End If

        End If

    End Sub
End Class