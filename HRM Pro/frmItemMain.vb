Imports System.Data.SqlClient

Public Class frmItemMain 

   
#Region " Proc & Functions "
    Dim strArr() As String
    Dim IsSellEdited As Boolean


    Sub ClearFields()

        txtPacking.Text = ""
        txtAvgCost.Text = "0"
        txtConsumption.Text = "0"
        txtCurrStock.Text = "0"
        txtDescription.Text = ""

        If cmbCategory.GetColumnValue("CATEGORYID") <> "" Then
            txtItemCode.Text = GetItemCode()
        End If

        txtLastCost.Text = "0"
        txtNOTE.Text = ""
        txtROL.Text = "0"
        txtROQ.Text = "0"
        txtStockValue.Text = "0"
        cmbTaxcode.Text = "0"
        txtShots.Text = "0"
 
    End Sub

    ''' <summary>
    ''' Insert New Item
    ''' </summary>
    ''' <returns>True-Sucess,False-Failed</returns>
    ''' <remarks></remarks>
    Function InsertNewItem(ByVal Proc As String) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim Procedure As String

        If String.Compare(Proc, "Add", False) = 0 Then
            Procedure = "spItemMasterAdd"
        Else
            Procedure = "spItemMasterEdit"
        End If

        Dim dcExecProc As New SqlCommand(Procedure, Conn)


        Dim dcSell As New SqlCommand()
        Try
            Conn.Open()

            '----- we need to enter selling price detail if exists when editing
            If String.Compare(Proc, "Add", False) <> 0 Then

                'If chkIsNonInv.Checked Then
                '    Throw New Exception("Non inventory Items can not be splittered")
                'End If
                
                dcSell = New SqlCommand(String.Format("delete from itemsellingdetailstemp where curruser='{0}'", CurrUser), Conn)
                dcSell.ExecuteNonQuery()

                dcSell.Dispose()
                '----------------

                If Not IsSellEdited Then
                    GoTo ProcHere
                End If

                For i As Int16 = 0 To gvSelling.RowCount - 2

                    If IsDBNull(gvSelling.GetRowCellValue(i, "SellingPrice")) Or gvSelling.GetRowCellValue(i, "SellingPrice") Is Nothing Or IsDBNull(gvSelling.GetRowCellValue(i, "DepartmentID")) Then
                        Throw New Exception("Selling price details incomplete,set the Department and Selling prices correctly")
                    End If

                    dcSell = New SqlCommand("insert into ItemSellingDetailsTemp (itemcode,sellingprice,DepartmentID ,LastUpdateDate,LastSellingPrice,CurrUser) values(" & _
                                     "@itemcode,@sellingprice,@DepartmentID ,@LastUpdateDate,@LastSellingPrice,@CurrUser)", Conn)

                    With dcSell.Parameters
                        .Add("@itemcode", SqlDbType.NVarChar).Value = txtItemCode.Text.Trim
                        .Add("@sellingprice", SqlDbType.Float).Value = gvSelling.GetRowCellValue(i, "SellingPrice")
                        .Add("@DepartmentID", SqlDbType.NVarChar).Value = gvSelling.GetRowCellValue(i, "DepartmentID")
                        .Add("@LastUpdateDate", SqlDbType.Date).Value = Now.Date
                        .Add("@LastSellingPrice", SqlDbType.Float).Value = IIf(strArr(i) Is Nothing, 0, strArr(i)) ' gvSelling.GetRowCellValue(i, "OrgSellPrice")
                        .Add("@CurrUser", SqlDbType.NVarChar).Value = CurrUser ' gvSelling.GetRowCellValue(i, "SellingPrice")

                    End With

                    dcSell.ExecuteNonQuery()
ihere:
                Next


            End If


            '----------------------

ProcHere:

            dcExecProc.CommandType = CommandType.StoredProcedure

            With dcExecProc.Parameters
                .Add("@Itemcode", SqlDbType.NVarChar, 50).Value = txtItemCode.Text
                .Add("@Description", SqlDbType.NVarChar, 150).Value = txtDescription.Text
                .Add("@BillingDesc", SqlDbType.NVarChar, 150).Value = txtBillingDesc.Text
                .Add("@Packing", SqlDbType.NVarChar).Value = txtPacking.Text
                .Add("@CreateDate", SqlDbType.DateTime).Value = dtCreateDate.DateTime
                .Add("@UOM", SqlDbType.NVarChar, 20).Value = cmbUOM.GetColumnValue("UOMCode")
                .Add("@Status", SqlDbType.Bit).Value = 1
                .Add("@Avgcost", SqlDbType.Float).Value = IIf(txtAvgCost.Text = "", 0, txtAvgCost.Text)
                .Add("@Stockvalue", SqlDbType.Float).Value = IIf(txtStockValue.Text = "", 0, txtStockValue.Text)
                .Add("@Lastcost", SqlDbType.Float).Value = IIf(txtLastCost.Text = "", 0, txtLastCost.Text)
                .Add("@Stocks", SqlDbType.Float).Value = IIf(txtCurrStock.Text = "", 0, txtCurrStock.Text)
                .Add("@ROL", SqlDbType.Float).Value = IIf(txtROL.Text = "", 0, txtROL.Text)
                .Add("@ROQ", SqlDbType.Float).Value = IIf(txtROQ.Text = "", 0, txtROQ.Text)
                .Add("@WeeklyConsumption", SqlDbType.Float).Value = IIf(txtConsumption.Text = "", 0, txtConsumption.Text)
                .Add("@Expiryitem", SqlDbType.Bit).Value = chkIsExpiry.Checked
                .Add("@Suppliercode", SqlDbType.NVarChar).Value = cmbSupplier.GetColumnValue("Suppliercode")
                .Add("@Taxcode", SqlDbType.NVarChar).Value = cmbTaxcode.Text
                .Add("@Notes", SqlDbType.NVarChar).Value = txtNOTE.Text
                .Add("@CatCode", SqlDbType.NVarChar).Value = cmbCategory.GetColumnValue("CATEGORYID")
                .Add("@IsSplit", SqlDbType.Bit).Value = chkIsSplit.Checked
                .Add("@NoOfShots", SqlDbType.Int).Value = Math.Abs(CInt(txtNoOfShots.Text))
                .Add("@IsNonInv", SqlDbType.Bit).Value = chkIsNonInv.Checked
                If Not String.Compare(Proc, "Add", False) = 0 Then
                    .Add("@CURRUSER", SqlDbType.NVarChar).Value = CurrUser 'cmbCategory.GetColumnValue("CATEGORYID")
                End If

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
            dcSell.Dispose()
        End Try

    End Function

    Sub ShowFields(ByVal Itemcode As String)

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter(String.Format("select * from ItemMaster where Itemcode like '{0}'", Itemcode), Conn)
        Dim dsShow As New DataSet

        Try

            daGetDets.Fill(dsShow)

            txtAvgCost.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Avgcost")), "", dsShow.Tables(0).Rows(0).Item("Avgcost"))
            txtConsumption.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("WeeklyConsumption")), "", dsShow.Tables(0).Rows(0).Item("WeeklyConsumption"))
            txtCurrStock.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Stocks")), "", dsShow.Tables(0).Rows(0).Item("Stocks"))
            txtDescription.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Description")), "", dsShow.Tables(0).Rows(0).Item("Description"))
            txtBillingDesc.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("BillingDesc")), "", dsShow.Tables(0).Rows(0).Item("BillingDesc"))

            txtItemCode.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Itemcode")), "", dsShow.Tables(0).Rows(0).Item("Itemcode"))
            txtLastCost.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Lastcost")), "", dsShow.Tables(0).Rows(0).Item("Lastcost"))
            txtNOTE.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Notes")), "", dsShow.Tables(0).Rows(0).Item("Notes"))
            txtROL.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ROL")), "", dsShow.Tables(0).Rows(0).Item("ROL"))
            txtROQ.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ROQ")), "", dsShow.Tables(0).Rows(0).Item("ROQ"))
            txtStockValue.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Stockvalue")), "", dsShow.Tables(0).Rows(0).Item("Stockvalue"))

            cmbTaxcode.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Taxcode")), "", dsShow.Tables(0).Rows(0).Item("Taxcode"))
            cmbTaxcode.ClosePopup()


            dtCreateDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("CreateDate")), "", dsShow.Tables(0).Rows(0).Item("CreateDate"))

            cmbUOM.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("UOM")), "", dsShow.Tables(0).Rows(0).Item("UOM"))
            cmbUOM.ClosePopup()
            txtPacking.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Packing")), "", dsShow.Tables(0).Rows(0).Item("Packing"))

            chkStatus.Checked = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Status")), "", dsShow.Tables(0).Rows(0).Item("Status"))
            chkIsExpiry.Checked = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Expiryitem")), "", dsShow.Tables(0).Rows(0).Item("Expiryitem"))

            cmbSupplier.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Suppliercode")), "", dsShow.Tables(0).Rows(0).Item("Suppliercode"))
            cmbSupplier.ClosePopup()

            cmbCategory.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Category")), "", dsShow.Tables(0).Rows(0).Item("Category"))
            cmbCategory.ClosePopup()

            chkIsSplit.Checked = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("IsSplit")), 0, dsShow.Tables(0).Rows(0).Item("IsSplit"))
            txtShots.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("TotShots")), "0", dsShow.Tables(0).Rows(0).Item("TotShots"))
            txtNoOfShots.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("NoOfShots")), "0", dsShow.Tables(0).Rows(0).Item("NoOfShots"))

            chkIsNonInv.Checked = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("IsNonInv")), 0, dsShow.Tables(0).Rows(0).Item("IsNonInv"))

            daGetDets.Dispose()
            dsShow.Dispose()

            '---- Selling Price editing option comes only editing time.creation time its disabled.

            daGetDets = New SqlDataAdapter(String.Format("select * from ItemSellingDetail where itemcode like '{0}'", txtItemCode.Text.Trim), Conn)
            daGetDets.Fill(dsShow)


            '----- Here we need to store current value
            Dim datacol As New DataColumn("OrgSellPrice", System.Type.GetType("System.Double"))
            dsShow.Tables(0).Columns.Add(datacol)

            gcSelling.DataSource = dsShow.Tables(0)

            'For i As Integer = 0 To gvSelling.RowCount - 1
            '    MsgBox(String.Format("{0} {1}", gvSelling.GetRowCellValue(i, "DepartmentID"), gvSelling.GetRowCellValue(i, "SellingPrice")))

            'Next

            ReDim strArr(gvSelling.RowCount - 1) 'As String

            For i As Integer = 0 To gvSelling.RowCount - 1
                'gvSelling.SetRowCellValue(i, "OrgSellPrice", gvSelling.GetRowCellValue(i, "SellingPrice"))

                If IsDBNull(gvSelling.GetRowCellValue(i, "DepartmentID")) Or gvSelling.GetRowCellValue(i, "DepartmentID") Is Nothing Then
                    gvSelling.DeleteRow(i)
                    'Else
                    '    strArr(i) = gvSelling.GetRowCellValue(i, "SellingPrice")
                End If

            Next

            For i As Integer = 0 To gvSelling.RowCount - 1
                'gvSelling.SetRowCellValue(i, "OrgSellPrice", gvSelling.GetRowCellValue(i, "SellingPrice"))

                If IsDBNull(gvSelling.GetRowCellValue(i, "DepartmentID")) Or gvSelling.GetRowCellValue(i, "DepartmentID") Is Nothing Then
                    'gvSelling.DeleteRow(i)
                Else
                    strArr(i) = gvSelling.GetRowCellValue(i, "SellingPrice")
                End If

            Next

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
        Dim daGetDets As New SqlDataAdapter("select * from ItemMaster where status=1", Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            grdItem.DataSource = dsShow.Tables(0)



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
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet


        Try

            '----- Load UOM Master

            daGetDets = New SqlDataAdapter("select UOMCode,Description from UOMMaster", Conn)
            daGetDets.Fill(dsShow)

            With cmbUOM.Properties
                .DataSource = dsShow.Tables(0)
                .DisplayMember = "UOMCode"
                .ValueMember = "UOMCode"
                .Columns(0).Width = 125
                .Columns(1).Width = 275
                .PopupWidth = 400
            End With


            daGetDets.Dispose()
            dsShow.Dispose()

            '----- Load Supplier Master

            daGetDets = New SqlDataAdapter("select Suppliercode,Suppliername from SupplierMaster", Conn)
            dsShow = New DataSet
            daGetDets.Fill(dsShow)

            With cmbSupplier.Properties
                .DataSource = dsShow.Tables(0)
                .DisplayMember = "Suppliername"
                .ValueMember = "Suppliercode"
                .Columns(0).Width = 125
                .Columns(1).Width = 275
                .PopupWidth = 400
            End With

            daGetDets.Dispose()
            dsShow.Dispose()


            '----- Load Category Master

            daGetDets = New SqlDataAdapter("select CATEGORYID,CATEGORYNAME from CategoryMaster", Conn)
            dsShow = New DataSet
            daGetDets.Fill(dsShow)

            With cmbCategory.Properties
                .DataSource = dsShow.Tables(0)
                .DisplayMember = "CATEGORYID"
                .ValueMember = "CATEGORYID"
                .Columns(0).Width = 125
                .Columns(1).Width = 275
                .PopupWidth = 400
            End With

            daGetDets.Dispose()
            dsShow.Dispose()

            '----- Load Taxcode Master

            daGetDets = New SqlDataAdapter("select Taxcode,Description from Taxmaster", Conn)
            dsShow = New DataSet
            daGetDets.Fill(dsShow)

            With cmbTaxcode.Properties
                .DataSource = dsShow.Tables(0)
                .DisplayMember = "Taxcode"
                .ValueMember = "Taxcode"
                .Columns(0).Width = 125
                .Columns(1).Width = 275
                .PopupWidth = 400
            End With

            daGetDets.Dispose()
            dsShow.Dispose()

            '----- Load Department Master

            dsShow = New DataSet

            daGetDets = New SqlDataAdapter("select DepartmentID,Department from DepartmentMaster", Conn)
            daGetDets.Fill(dsShow)

            With repDeparment

                .DataSource = dsShow.Tables(0)
                .DisplayMember = "DepartmentID"
                .ValueMember = "DepartmentID"
                '.Columns(0).Width = 125
                '.Columns(1).Width = 275
                '.PopupWidth = 400

            End With


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Function GetCodeLength() As Integer

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter("select * from itemcodesetting", Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count > 0 Then
                GetCodeLength = dsShow.Tables(0).Rows(0).Item("itemcodelength")
            Else
                GetCodeLength = 0
            End If

            Return GetCodeLength
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try


    End Function

    Function FieldValidation() As Boolean
        Return IIf(String.Compare(txtItemCode.Text, "", False) = 0 Or String.Compare(txtDescription.Text, "", False) = 0 Or String.Compare(cmbCategory.Text, "", False) = 0 Or String.Compare(cmbUOM.Text, "", False) = 0 Or String.Compare(cmbSupplier.Text, "", False) = 0 Or String.Compare(cmbTaxcode.Text, "", False) = 0, 0, 1)
    End Function

    Function ShotValidation() As Boolean
        If chkIsSplit.Checked Then
            If String.IsNullOrEmpty(txtNoOfShots.Text) Then
                Return False
            ElseIf IsNumeric(Val(txtNoOfShots.Text)) = False Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Function GetItemCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNoItem", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "Item"
            dcGetCode.Parameters.Add("@CatCode", SqlDbType.NVarChar).Value = cmbCategory.GetColumnValue("CATEGORYID")
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output


            'drGetDets = dcGetCode.ExecuteReader
            dcGetCode.ExecuteNonQuery()


            'If drGetDets.Read Then
            GetItemCode = dcGetCode.Parameters("@Currcode").Value
            'Else
            'GetSupplierCode = ""
            'End If


            'If Not IsDBNull(dsGetDets.Tables(0).Rows(0).Item(0)) Then
            '    GetSupplierCode = dsGetDets.Tables(0).Rows(0).Item(0).ToString
            'Else
            '    GetSupplierCode = ""
            'End If

            Return GetItemCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()
            ' drGetDets.Close()

        End Try

    End Function

    Function InActiveItem(ByVal ItemCode As String) As Boolean
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim dcExec As New SqlCommand(String.Format("update itemmaster set status = 0 where itemcode like '{0}'", ItemCode), Conn)

        Try
            Conn.Open()

            dcExec.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            dcExec.Dispose()
        End Try
    End Function

    Function SearchItem() As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()

        Dim sqlStr As String = ""

        Dim dsShow As New DataSet

        Try
            If optbycode.Checked Then
                sqlStr = String.Format("Select * from ItemMaster where status=1 and  itemcode like '{0}%' order by itemcode", txtsearch.Text)
            Else
                sqlStr = String.Format("Select * from ItemMaster where status=1 and description like '%{0}%' order by itemcode", txtsearch.Text)
            End If

            daGetDets = New SqlDataAdapter(sqlStr, Conn)
            daGetDets.Fill(dsShow)

            grdItem.DataSource = dsShow.Tables(0)
            Return 1
            'Return GetCodeLength()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try
    End Function

#End Region


#Region " Control Events "


    Private Sub gvItem_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvItem.DoubleClick
        If gvItem.GetRowCellValue(gvItem.FocusedRowHandle, "Itemcode") Is Nothing Then 'verification for suppliercode is blank or not
            Exit Sub
        End If

        tabMain.SelectedTabPageIndex = 1
        ShowFields(gvItem.GetRowCellValue(gvItem.FocusedRowHandle, "Itemcode"))

    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Items", "Add")

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

                If ShotValidation() = False Then
                    MsgBox("Please specify how many Shots for 1 Bottle.", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InsertNewItem("Add") Then
                    Exit Sub
                End If


                LoadGridDets()

                MsgBox("Successfully Inserted...", , ErrTitle)

                tabMain.TabPages(0).PageEnabled = True

                cmdNew.Text = "New"
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True
                tabMain.SelectedTabPageIndex = 0

            End If

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub cmbCategory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.EditValueChanged
        If String.Compare(cmdNew.Text, "Save", False) = 0 Then
            txtItemCode.Text = GetItemCode()
        End If

    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Items", "Edit")

        If CheckAccess = True Then


            If String.Compare(cmdEdit.Text, "Edit", False) = 0 Then


                cmdEdit.Text = "Save"
                cmdNew.Enabled = False
                cmdDelete.Enabled = False

                tabMain.SelectedTabPageIndex = 1
                tabMain.TabPages(0).PageEnabled = False

                gvSelling.OptionsBehavior.Editable = True

                IsSellEdited = False

            Else

                gvSelling.OptionsBehavior.Editable = False

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If ShotValidation() = False Then
                    MsgBox("Please specify how many Shots for 1 Bottle.", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InsertNewItem("Edit") Then
                    Exit Sub
                End If

                MsgBox("Successfully Update...", , ErrTitle)

                tabMain.TabPages(0).PageEnabled = False

                cmdEdit.Text = "Edit"
                cmdNew.Enabled = True
                cmdDelete.Enabled = True
                tabMain.SelectedTabPageIndex = 0
                tabMain.TabPages(0).PageEnabled = True
                IsSellEdited = False

            End If

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub cmbUOM_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbUOM.EditValueChanged
        cmbUOM.EditValue = cmbUOM.GetColumnValue("UOMCode")
    End Sub
#End Region


#Region " Form Events "
    Private Sub frmItemMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGridDets()
        LoadCombos()

        dtCreateDate.Text = Now.Date

        txtItemCode.Properties.ReadOnly = True
        txtAvgCost.Properties.ReadOnly = True
        txtLastCost.Properties.ReadOnly = True
        txtCurrStock.Properties.ReadOnly = True
        txtConsumption.Properties.ReadOnly = True

    End Sub

#End Region


    Private Sub gvSelling_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvSelling.CellValueChanged
        IsSellEdited = True

    End Sub

    Private Sub chkIsSplit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkIsSplit.CheckedChanged
        If chkIsSplit.Checked Then

            If chkIsNonInv.Checked Then
                MsgBox("Non inventory items can't be split")
                chkIsSplit.Checked = False
                Exit Sub

            End If

            txtShots.Visible = True
        Else
            txtShots.Visible = False
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click

        If cmdNew.Enabled = False Or cmdEdit.Enabled = False Then
            Dim msgres As MsgBoxResult = MsgBox("There are unsaved datas in this form, do you want to cancel this process")
            If msgres = MsgBoxResult.Yes Then
                Me.Close()

            End If
        Else
            Me.Close()
        End If
        'Me.Close()
    End Sub

    Private Sub txtsearch_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.EditValueChanged
        SearchItem()
    End Sub

    Private Sub chkIsNonInv_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkIsNonInv.CheckedChanged
        If chkIsSplit.Checked Then
            MsgBox("Split can not be a non inventory item.")
            chkIsNonInv.Checked = False
        End If
       
    End Sub

    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Items", "Delete")

        If CheckAccess = True Then


            If txtItemCode.Text = "" Then
                MsgBox("Select item to in activate", MsgBoxStyle.Critical, ErrTitle)
            Else
                'Dim msgres As MsgBoxResult = MsgBox("Once item inactivated, you can't find in Item List in any process,Continue ?")
                'If msgres = MsgBoxResult.Yes Then

                Dim bt As DialogResult = MessageBox.Show("Once item inactivated, you can't find in Item List in any process,Continue ?", "Inactive Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then

                    InActiveItem(txtItemCode.Text)


                    End If


                '  InActiveItem(txtItemCode.Text)
                End If
            'End If

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub frmItemMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class