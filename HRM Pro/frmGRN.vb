Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Imports System.Runtime.Serialization
Imports System.Xml

Public Class frmGRN

    Public Itemcode, Itemname, CurrQty, OrdQty As String
    Public frmGridRow As Double
    Dim IsCanSave As Boolean

    Private Sub cmdNew_Click(sender As System.Object, e As System.EventArgs) Handles cmdNew.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GoodReceivedNote", "Add")

        If CheckAccess = True Then




        If cmdNew.Text = "New" Then

            ClearFields()

            tabMain.SelectedTabPageIndex = 1
            tabMain.TabPages(0).PageEnabled = False

            cmdNew.Text = "Record"
            cmdEdit.Enabled = False
            cmdDelete.Enabled = False
            IsCanSave = True
        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub
            End If

            'IsExpiryItem()

            If Not IsCanSave Then
                MsgBox("Zero Quantity Values need to be filed", , ErrTitle)
                Exit Sub
            End If

            If Not InsertNewGRN("Add") Then
                Exit Sub
            End If

            MsgBox("Successfully Inserted...", , ErrTitle)
            tabMain.TabPages(0).PageEnabled = True
            LoadMain(True, True)

            tabMain.SelectedTabPageIndex = 0

            cmdNew.Text = "New"
            cmdEdit.Enabled = True
            cmdDelete.Enabled = True

            End If



        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub frmGRN_EnabledChanged(sender As Object, e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled Then

            LoadGridDets()

        End If
    End Sub

    Private Sub frmGRN_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtFrom.DateTime = Now.Date
        dtTo.DateTime = Now.Date


        LoadMain(True, True)
        'LoadGridDets()
        'LoadCombos()

        dtReqDate.Text = Now.Date

        txtReqID.Properties.ReadOnly = True

    End Sub


    Private Sub gvBNMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvBNMain.DoubleClick
        ShowFields(gvBNMain.GetFocusedRowCellValue("GRNCode"))
    End Sub


#Region " Proc & Functions "

    Sub ClearFields()

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Dim dcDel As New SqlCommand



        Try

            Conn.Open()

            txtReference.Text = ""
            txtReqID.Text = GetGRNCode()
            txtDhoniName.Text = ""
            txtUIDMaster.Text = Guid.NewGuid.ToString()
            txtDhoniCaptain.Text = ""
            txtDhoniName.Text = ""

            txtPrepairedBy.Text = CurrUser


            dcDel = New SqlCommand(String.Format("delete from GRNtemporary where curruser like '{0}'", CurrUser), Conn)
            dcDel.ExecuteNonQuery()


            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daGetDets = New SqlDataAdapter("select * from GRNtemporary where itemcode like 'nothing'", Conn)
            daGetDets.Fill(dsShow)

            txtSuppInvoice.Text = ""

            gridGRNDetail.DataSource = dsShow.Tables(0)

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
    Function InsertNewGRN(ByVal Proc As String) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim Procedure As String

        If String.Compare(Proc, "Add", False) = 0 Then
            Procedure = "spGRNInsert"
        Else
            Procedure = "spGRNEdit"
        End If

        Dim dcExecProc As New SqlCommand()

        Try


            '/* 
            '    In this process two things going to happen. 
            ' 1) Insert all the details to temp table 
            ' 2) Run the stored procedures to insert all the details from temp table
            '*/


            Conn.Open()


            For i As Int16 = 0 To gvGRNDetail.RowCount - 1


                If gvGRNDetail.GetRowCellValue(i, "Itemcode") = "" Then
                    Exit For
                End If

                If IsDBNull(gvGRNDetail.GetRowCellValue(i, "GRNQty")) Then
                    Throw New Exception("Order Quantytity must be non zero value")
                    IsCanSave = False

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
                .Add("@GRNCODE", SqlDbType.NVarChar, 50).Value = txtReqID.Text
                .Add("@GRNDate", SqlDbType.Date).Value = dtReqDate.Text
                .Add("@PrepairedBy", SqlDbType.NVarChar).Value = txtPrepairedBy.Text
                .Add("@DhoniName", SqlDbType.NVarChar).Value = txtDhoniName.Text
                .Add("@Reference", SqlDbType.NVarChar).Value = txtReference.Text
                .Add("@Dhonicaptain", SqlDbType.NVarChar).Value = txtDhoniCaptain.Text
                .Add("@UIDMASTER", SqlDbType.UniqueIdentifier).Value = UIDMaster
                .Add("@SupplierInv", SqlDbType.NVarChar).Value = txtSuppInvoice.Text
                .Add("@CurrUser", SqlDbType.NVarChar).Value = CurrUser
            End With

            dcExecProc.ExecuteNonQuery()

            IsCanSave = True

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

            sqlStr = "UPDATE GRNTEMPORARY SET GRNQTY=@GRNQTY , Itemprice=@GRNPRICE WHERE GRNCODE=@GRNCODE AND POCODE =@POCODE AND ITEMCODE=@ITEMCODE"

            Conn.Open()

            InsTrans = Conn.BeginTransaction
            IsTrans = True

            dcExec = New SqlCommand(sqlStr, Conn)
            dcExec.Transaction = InsTrans


            With dcExec.Parameters
                .Add("@GRNCODE", SqlDbType.NVarChar).Value = txtReqID.Text
                .Add("@POCODE", SqlDbType.NVarChar).Value = gvGRNDetail.GetGroupRowValue(Row, gvGRNDetail.Columns("POCode"))
                .Add("@ITEMCODE", SqlDbType.NVarChar).Value = gvGRNDetail.GetRowCellValue(Row, "Itemcode")
                .Add("@GRNQTY", SqlDbType.Float).Value = gvGRNDetail.GetRowCellValue(Row, "GRNQty")
                .Add("@GRNPRICE", SqlDbType.Float).Value = gvGRNDetail.GetRowCellValue(Row, "Itemprice")

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

        Dim daGetDets As New SqlDataAdapter(String.Format("select * from GRNMaster where GRNCode like '{0}'", BNcode), Conn)
        Dim dsShow As New DataSet
        Dim dcRunProcs As New SqlCommand

        Try


            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If


            txtReference.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Reference")), "", dsShow.Tables(0).Rows(0).Item("Reference"))
            txtReqID.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("GRNCode")), "", dsShow.Tables(0).Rows(0).Item("GRNCode"))
            txtDhoniName.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("DhoniName")), "", dsShow.Tables(0).Rows(0).Item("DhoniName"))
            dtReqDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("GRNDate")), "", dsShow.Tables(0).Rows(0).Item("GRNDate"))
            txtDhoniCaptain.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("DhoniCaptain")), "", dsShow.Tables(0).Rows(0).Item("DhoniCaptain"))
            txtUIDMaster.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("UID")), "", dsShow.Tables(0).Rows(0).Item("UID").ToString())
            txtPrepairedBy.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("PrepairedBy")), "", dsShow.Tables(0).Rows(0).Item("PrepairedBy"))
            txtSuppInvoice.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("SupplierInv")), "", dsShow.Tables(0).Rows(0).Item("SupplierInv"))

            daGetDets.Dispose()
            dsShow.Dispose()

            '---------------------------------------------------------------

            dcRunProcs = New SqlCommand("spGRNDetView", Conn)
            dcRunProcs.CommandType = CommandType.StoredProcedure

            With dcRunProcs.Parameters
                .Add("@GRNCODE", SqlDbType.NVarChar).Value = BNcode
                .Add("@CURRUSER", SqlDbType.NVarChar).Value = CurrUser
            End With

            daGetDets = New SqlDataAdapter
            dsShow = New DataSet

            daGetDets.SelectCommand = dcRunProcs
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            gridGRNDetail.DataSource = dsShow.Tables(0)

            Dim View As GridView = gvGRNDetail
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
        Dim daGetDets As New SqlDataAdapter() '("select * from GRNMaster where status=1 order by GRNCode", Conn)
        Dim dsShow As New DataSet

        Dim sqlstr As String = ""

        If All And Open Then
            sqlstr = "select * from GRNMaster where status=1 order by GRNCode"
        ElseIf All And Not Open Then
            sqlstr = "select * from GRNMaster where status=0 order by GRNCode"
        ElseIf Not All And Open Then
            sqlstr = "select * from GRNMaster where status=1 and GRNDate >=@From and GRNDate <=@To order by GRNCode"
        ElseIf Not All And Not Open Then
            sqlstr = "select * from GRNMaster where status=0 and GRNDate >=@From and GRNDate <=@To order by GRNCode"
        End If

        Dim dcGetDetails As New SqlCommand()

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

            daGetDets = New SqlDataAdapter("select * from grnmaster where status = 1", Conn)
            daGetDets.Fill(dsShow)

            gridBNMain.DataSource = dsShow.Tables(0)

            daGetDets.Dispose()
            dsShow.Dispose()

            '------

            gridGRNDetail.DataSource = Nothing

            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            dsShow = New DataSet
            daGetDets = New SqlDataAdapter(String.Format("select * from grntemporary where curruser like '{0}' and grnCode like '{1}' ", CurrUser, txtReqID.Text), Conn)
            daGetDets.Fill(dsShow)


            gridGRNDetail.DataSource = dsShow.Tables(0)

            Dim View As GridView = gvGRNDetail
            View.BeginSort()
            Try
                View.ClearGrouping()
                View.Columns("POCode").GroupIndex = 0
                'View.Columns("Category").GroupIndex = 1
            Finally
                View.EndSort()
                View.ExpandAllGroups()
            End Try



            'Dim CurrQty As Double

            'For i As Int16 = 0 To gvBNDetail.RowCount - 1
            '    CurrQty = GetCurrItemQty(gvBNDetail.GetRowCellValue(i, "Itemcode"))
            '    gvBNDetail.SetRowCellValue(i, "CurrQty", CurrQty)
            'Next

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

    Function GetGRNCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "GRN"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output

            dcGetCode.ExecuteNonQuery()

            GetGRNCode = dcGetCode.Parameters("@Currcode").Value


            Return GetGRNCode
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
            If gvGRNDetail.RowCount = 0 Then
                Return False
            End If

            For i As Integer = 0 To gvGRNDetail.RowCount - 1
                If IsDBNull(gvGRNDetail.GetRowCellValue(i, "Itemcode")) Then
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

    Function IsExpiryItem(ByVal ItemCode As String) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try

            daGetDets = New SqlDataAdapter("select Expiryitem from itemmaster where itemcode like '" & ItemCode & "'", Conn)
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows(0).Item(0) Then
                IsExpiryItem = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()

        End Try


    End Function

#End Region

    Private Sub cmdItemReq_Click(sender As System.Object, e As System.EventArgs) Handles cmdItemReq.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GoodReceivedNote", "Add")

        If CheckAccess = True Then




            If cmdNew.Text = "Record" Or cmdEdit.Text = "Save" And txtReqID.Text <> "" Then
                frmGRNConversion.txtPurchReqCode.Text = txtReqID.Text
                frmGRNConversion.Show()
                Me.Enabled = False
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub

    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click
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

            If Not InsertNewGRN("Edit") Then
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


    Private Sub gvBNDetail_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvGRNDetail.CellValueChanged

        If e.Column.FieldName = "GRNQty" Then

            If Not IsValidGRNQty Then
                Exit Sub
            End If

            gvGRNDetail.SetFocusedRowCellValue("TaxValue", TaxCalc(gvGRNDetail.GetFocusedRowCellValue("GRNQty"), gvGRNDetail.GetFocusedRowCellValue("Itemprice"), gvGRNDetail.GetFocusedRowCellValue("TaxCode")))
            gvGRNDetail.SetFocusedRowCellValue("SubTotal", SetSubTotal(gvGRNDetail.GetFocusedRowCellValue("GRNQty"), gvGRNDetail.GetFocusedRowCellValue("Itemprice"), gvGRNDetail.GetFocusedRowCellValue("TaxValue")))


           

            LoadGrnTotal()



            'gvItemDets.SetFocusedRowCellValue("SubTotal", SetSubTotz)
            'gvItemDets.SetFocusedRowCellValue("SubTotal",

            'Dim Totalz As Double() = SetGrandTotz()


            'txtSubtot.Text = Totalz(0)
            'txtTaxValue.Text = Totalz(1)
            'txtPOTot.Text = Totalz(2)

        End If

    End Sub

    Function IsValidGRNQty() As Boolean

        Try
            If gvGRNDetail.GetFocusedRowCellValue("GRNQty") > gvGRNDetail.GetFocusedRowCellValue("BNQty") Then
                gvGRNDetail.SetFocusedRowCellValue("GRNQty", gvGRNDetail.GetFocusedRowCellValue("BNQty"))
                Throw New Exception("You can't enter more than Bote Note Qty")
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        End Try

    End Function


    Private Sub cmdPrint_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrint.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GoodReceivedNote", "Print")

        If CheckAccess = True Then




        If txtReqID.Text = "" Then
                MsgBox("Select GRN to print", MsgBoxStyle.Critical)
            Exit Sub

        End If


        frmReportViewerZ.rptPath = "rptGRN.rpt"
            frmReportViewerZ.rptTitle = "Good Received Note"
        frmReportViewerZ.selectionForumla = "{vwGRNMasterDetail.GRNCode}  = '" & txtReqID.Text & "'" ', cmbDepartment_General.GetColumnValue("DepartmentID")) ' String.Format("{{Report_BinCard.BILLDATE}} >=#{0}# and {{Report_BinCard.BILLDATE}} #<={1}#", dtDateFrom.DateTime.Date, dtDateTo.DateTime.Date)


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

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

    End Sub


    Sub LoadGrnTotal()
      
        If gvGRNDetail.RowCount > 1 Then
            Dim iTax As Decimal = 0

            'if you have the other column to get the result you  could add a new one like these above 
            For index As Integer = 0 To gvGRNDetail.RowCount - 1

                '  MessageBox.Show("Cell value 8 " + gvGRNDetail.GetRowCellValue(index, "SubTotal"))

                Dim passGrnQty As Integer


                If (Not IsDBNull(gvGRNDetail.GetRowCellValue(index, "GRNQty"))) Then

                    passGrnQty = gvGRNDetail.GetRowCellValue(index, "GRNQty")


                Else

                    passGrnQty = 0


                End If


                iTax += Convert.ToDouble(gvGRNDetail.GetRowCellValue(index, "Itemprice")) * passGrnQty





                'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
            Next

            txtGrnTot.Text = iTax.ToString
            'if you have the other column to get the result you  could add a new one like these above 
        End If
    End Sub








    Private Sub gvGRNDetail_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvGRNDetail.RowClick
        'LoadGrnTotal()
    End Sub

    Private Sub gvGRNDetail_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gvGRNDetail.RowCellClick
        'LoadGrnTotal()
    End Sub

    Private Sub gvGRNDetail_RowUpdated(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvGRNDetail.RowUpdated
        'LoadGrnTotal()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If gvGRNDetail.RowCount > 1 Then
            Dim iTax As Integer = 0

            'if you have the other column to get the result you  could add a new one like these above 
            For index As Integer = 0 To gvGRNDetail.RowCount - 1

                '  MessageBox.Show("Cell value 8 " + gvGRNDetail.GetRowCellValue(index, "SubTotal"))

                iTax += Convert.ToDouble(gvGRNDetail.GetRowCellValue(index, "SubTotal"))


                'if you have the other column to get the result you  could add a new one like these above (just change Cells(2) to the one you added)
            Next

            txtGrnTot.Text = iTax.ToString
            'if you have the other column to get the result you  could add a new one like these above 
        End If
    End Sub
End Class