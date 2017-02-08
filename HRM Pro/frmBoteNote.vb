Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Imports System.Runtime.Serialization
Imports System.Xml


Public Class frmBoteNote

    Public Itemcode, Itemname, CurrQty, OrdQty As String
    Public frmGridRow As Double

    Private Sub cmdNew_Click(sender As System.Object, e As System.EventArgs) Handles cmdNew.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatNote", "Add")

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

                If Not InsertNewPO("Add") Then
                    Exit Sub
                End If

                MsgBox("Successfully Inserted...", , ErrTitle)
                LoadMain(True, True)

                cmdNew.Text = "New"
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True

                tabMain.TabPages(0).PageEnabled = True
            End If



        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub frmBN_EnabledChanged(sender As Object, e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled Then

            LoadGridDets()

        End If
    End Sub

    Private Sub frmBN_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtFrom.Text = Now.Date
        dtTo.Text = Now.Date

        LoadMain(True, True)
        'LoadGridDets()
        'LoadCombos()

        dtReqDate.Text = Now.Date

        txtReqID.Properties.ReadOnly = True

    End Sub


    Private Sub gvBNMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvBNMain.DoubleClick
        ShowFields(gvBNMain.GetFocusedRowCellValue("BNCode"))
    End Sub


#Region " Proc & Functions "

    Sub ClearFields()

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter("select * from BNMaster where status=1", Conn)
        Dim dsShow As New DataSet

        Dim dcDel As New SqlCommand



        Try

            Conn.Open()

            txtReference.Text = ""
            txtReqID.Text = GetBNCode()
            txtDhoniName.Text = ""
            txtUIDMaster.Text = Guid.NewGuid.ToString()
            txtDhoniCaptain.Text = ""
            txtDhoniName.Text = ""

            txtPrepairedBy.Text = CurrUser


            dcDel = New SqlCommand(String.Format("delete from bntemporary where curruser like '{0}'", CurrUser), Conn)
            dcDel.ExecuteNonQuery()


            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daGetDets = New SqlDataAdapter("select * from bntemporary where itemcode like 'nothing'", Conn)
            daGetDets.Fill(dsShow)

            gridBNDetail.DataSource = dsShow.Tables(0)

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
    Function InsertNewPO(ByVal Proc As String) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim Procedure As String

        If String.Compare(Proc, "Add", False) = 0 Then
            Procedure = "spBNInsert"
        Else
            Procedure = "spBNEdit"
        End If

        Dim dcExecProc As New SqlCommand()

        Try


            '/* 
            '    In this process two things going to happen. 
            ' 1) Insert all the details to temp table 
            ' 2) Run the stored procedures to insert all the details from temp table
            '*/


            Conn.Open()


            For i As Int16 = 0 To gvBNDetail.RowCount - 1


                If gvBNDetail.GetRowCellValue(i, "Itemcode") = "" Then
                    Exit For
                End If

                If IsDBNull(gvBNDetail.GetRowCellValue(i, "BNQty")) Then
                    Throw New Exception("Order Quantytity must be non zero value")
                    Exit For
                End If


                '---- before inserting to the master records
                ' we need to supply bnqty
                ' in order to do this, update the bntemporary table.

                UpdateBNTemp(i)

            Next


            dcExecProc = New SqlCommand(Procedure, Conn)
            dcExecProc.CommandType = CommandType.StoredProcedure


            Dim UIDMaster As Guid = New Guid(txtUIDMaster.Text)

            With dcExecProc.Parameters
                .Add("@BNCODE", SqlDbType.NVarChar, 50).Value = txtReqID.Text
                .Add("@BNDate", SqlDbType.Date).Value = dtReqDate.Text
                .Add("@PrepairedBy", SqlDbType.NVarChar).Value = txtPrepairedBy.Text
                .Add("@DhoniName", SqlDbType.NVarChar).Value = txtDhoniName.Text
                .Add("@Reference", SqlDbType.NVarChar).Value = txtReference.Text
                .Add("@Dhonicaptain", SqlDbType.NVarChar).Value = txtDhoniCaptain.Text
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

    Function UpdateBNTemp(ByVal Row As Double) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim dcExec As New SqlCommand()
        Dim InsTrans As SqlTransaction
        Dim sqlStr As String = ""
        Dim IsTrans As Boolean = False

        Try

            sqlStr = "UPDATE BNTEMPORARY SET BNQTY=@BNQTY WHERE BNCODE=@BNCODE AND POCODE =@POCODE AND ITEMCODE=@ITEMCODE"

            Conn.Open()

            InsTrans = Conn.BeginTransaction
            IsTrans = True

            dcExec = New SqlCommand(sqlStr, Conn)
            dcExec.Transaction = InsTrans


            With dcExec.Parameters
                .Add("@BNCODE", SqlDbType.NVarChar).Value = txtReqID.Text
                .Add("@POCODE", SqlDbType.NVarChar).Value = gvBNDetail.GetGroupRowValue(Row, gvBNDetail.Columns("POCode"))
                .Add("@ITEMCODE", SqlDbType.NVarChar).Value = gvBNDetail.GetRowCellValue(Row, "Itemcode")
                .Add("@BNQTY", SqlDbType.Float).Value = gvBNDetail.GetRowCellValue(Row, "BNQty")

                dcExec.ExecuteNonQuery()

            End With

            InsTrans.Commit()
            IsTrans = False

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False

        Finally

            If IsTrans Then
                InsTrans.Rollback()
                IsTrans = False
            End If

            Conn.Dispose()
            dcExec.Dispose()

        End Try

    End Function

    Sub ShowFields(ByVal BNcode As String)

        Dim Conn As New SqlConnection(modMain.ConnString)

        Dim daGetDets As New SqlDataAdapter(String.Format("select * from BNMaster where BNcode like '{0}'", BNcode), Conn)
        Dim dsShow As New DataSet
        Dim dcRunProcs As New SqlCommand

        Try

  
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If


            txtReference.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Reference")), "", dsShow.Tables(0).Rows(0).Item("Reference"))
            txtReqID.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("BNCode")), "", dsShow.Tables(0).Rows(0).Item("BNCode"))
            txtDhoniName.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("DhoniName")), "", dsShow.Tables(0).Rows(0).Item("DhoniName"))
            dtReqDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("BNDate")), "", dsShow.Tables(0).Rows(0).Item("BNDate"))
            txtDhoniCaptain.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("DhoniCaptain")), "", dsShow.Tables(0).Rows(0).Item("DhoniCaptain"))
            txtUIDMaster.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("UID")), "", dsShow.Tables(0).Rows(0).Item("UID").ToString())
            txtPrepairedBy.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("PrepairedBy")), "", dsShow.Tables(0).Rows(0).Item("PrepairedBy"))


            daGetDets.Dispose()
            dsShow.Dispose()

            '---------------------------------------------------------------

            dcRunProcs = New SqlCommand("spBNDetView", Conn)
            dcRunProcs.CommandType = CommandType.StoredProcedure

            With dcRunProcs.Parameters
                .Add("@BNCODE", SqlDbType.NVarChar).Value = BNcode
                .Add("@CURRUSER", SqlDbType.NVarChar).Value = CurrUser
            End With

            daGetDets = New SqlDataAdapter
            dsShow = New DataSet

            daGetDets.SelectCommand = dcRunProcs
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            gridBNDetail.DataSource = dsShow.Tables(0)

            Dim View As GridView = gvBNDetail
            View.BeginSort()
            Try
                View.ClearGrouping()
                View.Columns("POCode").GroupIndex = 0
                'View.Columns("Category").GroupIndex = 1
            Finally
                View.EndSort()
                View.ExpandAllGroups()
            End Try


            tabMain.SelectedTabPageIndex = 1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()

        End Try


    End Sub

    Sub LoadMain(ByVal All As Boolean, ByVal Open As Boolean)

        Dim Conn As New SqlConnection(modMain.ConnString)

        Dim sqlstr As String

        If All And Open Then
            sqlstr = "select * from BNMaster where status=1 order by BNCode"
        ElseIf All And Not Open Then
            sqlstr = "select * from BNMaster where status=0 order by BNCode"
        ElseIf Not All And Open Then
            sqlstr = "select * from BNMaster where status=1 and bndate >=@From and bndate <=@To order by BNCode"
        ElseIf Not All And Not Open Then
            sqlstr = "select * from BNMaster where status=0 and bndate >=@From and bndate <=@To order by BNCode"
        End If

        Dim dcGetDetails As New SqlCommand()

        Dim daGetDets As New SqlDataAdapter() ' SqlDataAdapter("select * from BNMaster where status=1 order by BNCode", Conn)
        Dim dsShow As New DataSet

        Try

            Conn.Open()

            dcGetDetails = New SqlCommand(sqlstr, Conn)
            dcGetDetails.Parameters.Add("@FROM", SqlDbType.DateTime).Value = dtFrom.DateTime
            dcGetDetails.Parameters.Add("@TO", SqlDbType.DateTime).Value = dtTo.DateTime


            daGetDets.SelectCommand = dcGetDetails
            daGetDets.Fill(dsShow)

            gridBNMain.DataSource = dsShow.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            dcGetDetails.Dispose()
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
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try

            daGetDets = New SqlDataAdapter("select * from bnmaster where status = 1", Conn)
            daGetDets.Fill(dsShow)

            gridBNMain.DataSource = dsShow.Tables(0)

            daGetDets.Dispose()
            dsShow.Dispose()

            '------

            gridBNDetail.DataSource = Nothing

            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            dsShow = New DataSet
            daGetDets = New SqlDataAdapter(String.Format("select * from BNtemporary where curruser like '{0}' and BNCode like '{1}' ", CurrUser, txtReqID.Text), Conn)
            'daGetDets = New SqlDataAdapter(String.Format("select * from BNtemporary where curruser like '{0}' and BNCode like '{1}' ", CurrUser, txtReqID.Text), Conn)
            daGetDets.Fill(dsShow)


            gridBNDetail.DataSource = dsShow.Tables(0)

            Dim View As GridView = gvBNDetail
            View.BeginSort()
            Try
                View.ClearGrouping()
                View.Columns("POCode").GroupIndex = 0
                'View.Columns("Category").GroupIndex = 1
            Finally
                View.EndSort()
                View.ExpandAllGroups()
            End Try



            Dim CurrQty As Double

            For i As Int16 = 0 To gvBNDetail.RowCount - 1
                CurrQty = (gvBNDetail.GetRowCellValue(i, "ProcessQty"))
                gvBNDetail.SetRowCellValue(i, "BNQty", CurrQty)
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

            'With cmbSupplier.Properties
            '    .DataSource = dsShow.Tables(0)
            '    .DisplayMember = "Suppliername"
            '    .ValueMember = "Suppliercode"
            '    .Columns(0).Width = 125
            '    .Columns(1).Width = 275
            '    .PopupWidth = 400

            'End With

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
        Return IIf(String.Compare(txtReqID.Text, "", False) = 0 Or String.Compare(dtReqDate.Text, "", False) = 0 Or ItemcodeValid() = False, 0, 1)
    End Function

    Function GetBNCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "BN"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output

            dcGetCode.ExecuteNonQuery()

            GetBNCode = dcGetCode.Parameters("@Currcode").Value


            Return GetBNCode
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
            If gvBNDetail.RowCount = 0 Then
                Return False
            End If

            For i As Integer = 0 To gvBNDetail.RowCount - 1
                If IsDBNull(gvBNDetail.GetRowCellValue(i, "Itemcode")) Then
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

    Function TaxCalc(ByVal ItemQty As Double, ByVal ItemPrice As Double, ByVal TaxCode As String) As Double

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet
        Dim TaxVal As Double

        Try

            daGetDets = New SqlDataAdapter(String.Format("select Percentage from TaxMaster where taxcode like'{0}'", TaxCode), Conn)
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count > 0 Then

                If dsShow.Tables(0).Rows(0).Item("Percentage") > 0 Then
                    TaxVal = ItemQty * ItemPrice * dsShow.Tables(0).Rows(0).Item(0) / 100
                    TaxCalc = TaxVal
                End If

            Else
                TaxCalc = 0
            End If

            Return TaxCalc

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Function

    Function SetSubTotal(ByVal Qty As Double, ByVal Price As Double, ByVal TaxVal As Double) As Double
        Try
            Dim SubTot As Double

            SubTot = Qty * Price + TaxVal
            SetSubTotal = SubTot

            Return SetSubTotal
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0

        End Try

    End Function

    Function InactivateRequisition(ByVal ItemReqCode As String) As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExecDel As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Dim msgbxrslt As MsgBoxResult = MsgBox("Are you sure,you want to delete this Purchase Order", MsgBoxStyle.YesNo, ErrTitle)

            If msgbxrslt = MsgBoxResult.No Then
                Return False
            End If

            Conn.Open()

            dcExecDel = New SqlCommand(String.Format("update POMaster set status = 0 where POCode ='{0}'", ItemReqCode), Conn)
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


#End Region

    Private Sub cmdItemReq_Click(sender As System.Object, e As System.EventArgs) Handles cmdItemReq.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatNote", "Add")

        If CheckAccess = True Then



            If cmdNew.Text <> "Record" And (cmdEdit.Text <> "Save" Or txtReqID.Text = "") Then
                Return
            End If

            frmPOConvertion.txtPurchReqCode.Text = txtReqID.Text
            'frmPOConvertion.IsEdit = True


            'If cmdEdit.Text = "Save" Then

            '    frmPOConvertion.IsEdit = True

            'Else

            frmPOConvertion.IsEdit = False

            'End If



            frmPOConvertion.Show()
            Me.Enabled = False

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatNote", "Edit")

        If CheckAccess = True Then



            If String.Compare(cmdEdit.Text, "Edit", False) = 0 Then


                cmdEdit.Text = "Save"
                cmdNew.Enabled = False
                cmdDelete.Enabled = False

                txtReqID.Properties.ReadOnly = True

                tabMain.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InsertNewPO("Edit") Then
                    Exit Sub
                End If

                MsgBox("Successfully Update...", , ErrTitle)

                cmdEdit.Text = "Edit"
                cmdNew.Enabled = True
                cmdDelete.Enabled = True

                'txtReqID.Properties.ReadOnly = False

                tabMain.SelectedTabPageIndex = 0

            End If


        Else

            MsgBox("You Do Not Have Access")


        End If






    End Sub



    Private Sub GroupBox5_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub gvBNDetail_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvBNDetail.CellValueChanged

        If e.Column.FieldName = "BNQty" Then

            gvBNDetail.SetFocusedRowCellValue("TaxValue", TaxCalc(gvBNDetail.GetFocusedRowCellValue("BNQty"), gvBNDetail.GetFocusedRowCellValue("Itemprice"), gvBNDetail.GetFocusedRowCellValue("TaxCode")))
            gvBNDetail.SetFocusedRowCellValue("SubTotal", SetSubTotal(gvBNDetail.GetFocusedRowCellValue("BNQty"), gvBNDetail.GetFocusedRowCellValue("Itemprice"), gvBNDetail.GetFocusedRowCellValue("TaxValue")))

            'gvItemDets.SetFocusedRowCellValue("SubTotal", SetSubTotz)
            'gvItemDets.SetFocusedRowCellValue("SubTotal",

            'Dim Totalz As Double() = SetGrandTotz()


            'txtSubtot.Text = Totalz(0)
            'txtTaxValue.Text = Totalz(1)
            'txtPOTot.Text = Totalz(2)

        End If

    End Sub


    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatNote", "Delete")

        If CheckAccess = True Then





            'when boatnoat cancel, inactive current boat noat, enable po.
            If String.IsNullOrEmpty(txtReqID.Text) Then
                Exit Sub
            End If

            If InactivateRequisition(txtReqID.Text) Then
                MsgBox("Successfully Deleted", , ErrTitle)
                tabMain.SelectedTabPageIndex = 0
            Else
                MsgBox("Unsuccessful Delete operation", MsgBoxStyle.Critical, ErrTitle)
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatNote", "Print")

        If CheckAccess = True Then




        If txtReqID.Text = "" Then
            MsgBox("Select Bote Note to print", MsgBoxStyle.Critical)
            Exit Sub

        End If


        frmReportViewerZ.rptPath = "rptBoteNote.rpt"
        frmReportViewerZ.rptTitle = "Bote Note Report"
        frmReportViewerZ.selectionForumla = "{vwBoteNote.BNCode}  = '" & txtReqID.Text & "'" ', cmbDepartment_General.GetColumnValue("DepartmentID")) ' String.Format("{{Report_BinCard.BILLDATE}} >=#{0}# and {{Report_BinCard.BILLDATE}} #<={1}#", dtDateFrom.DateTime.Date, dtDateTo.DateTime.Date)


            frmReportViewerZ.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub

    Private Sub optOpen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optOpen.CheckedChanged, optClosed.CheckedChanged
        LoadMain(True, optOpen.Checked)
    End Sub

    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        LoadMain(False, optOpen.Checked)
    End Sub

    
    Private Sub cmdAuthorized_Click(sender As System.Object, e As System.EventArgs) Handles cmdAuthorized.Click
        If String.IsNullOrEmpty(txtReqID.Text) Then
            Exit Sub
        End If

        If AthorizePO(txtReqID.Text) Then
            MsgBox("Successfully Authorized", , ErrTitle)
            DataAuthenticationChecking(gvBNMain.FocusedRowHandle)
            LoadMain(True, True)
            tabMain.SelectedTabPageIndex = 0
        Else
            MsgBox("Unsuccessful Authorized operation", MsgBoxStyle.Critical, ErrTitle)
        End If
    End Sub

#Region " Authorize "

    Function AthorizePO(ByVal POCode As String) As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExecDel As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Dim msgbxrslt As MsgBoxResult = MsgBox("Do you want to Authorized this Boat Note", MsgBoxStyle.YesNo, ErrTitle)

            If msgbxrslt = MsgBoxResult.No Then
                Return False
            End If

            Conn.Open()




            Dim BNCode As String = gvBNMain.GetRowCellValue(gvBNMain.FocusedRowHandle, "BNCode")


            dcExecDel = New SqlCommand(String.Format("update BNMaster set IsAuthorized = 1 where BNCode ='{0}'", BNCode), Conn)
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


    Function DataAuthenticationChecking(ByVal RowHandle As Int16) As Boolean
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try

            '----- Load Department Master

            Dim BNCode As String = gvBNMain.GetRowCellValue(RowHandle, "BNCode")

            If String.IsNullOrEmpty(BNCode) Then
                Exit Function
            End If

            daGetDets = New SqlDataAdapter(String.Format("select IsAuthorized from BNMaster where BNCode like '{0}'", BNCode), Conn)
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count > 0 Then
                cmdAuthorized.Enabled = Not dsShow.Tables(0).Rows(0).Item(0)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Function



#End Region
End Class