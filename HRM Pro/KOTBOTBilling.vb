Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports System.Runtime.Serialization
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
'Imports System.Configuration
Imports System.Xml

Public Class KOTBOTBilling
    Public Itemcode, Itemname, Itemqty, Itemprice, KotBotNo, mode As String
    Public frmGridRow As Double
    Dim dsDepartments As New DataSet
    Dim dsPayMethod As New DataSet
    Dim dsPayMethodMAster As New DataSet
    Dim dsCurrency As New DataSet
    Dim dsTaxRates As New DataSet
    Dim dsDepartmentsOutLet As New DataSet
    Dim unboundData As New ArrayList()
    Dim unboundDataOutLetBill As New ArrayList()
    Dim dsItemList As New DataSet
    Dim dsPaid As New DataSet
    Dim dsUnPaid As New DataSet
    Public PubMasNo As String = ""
    Public ReportName As String
    Public rptTitle As String
    Public PubFinalMasterAmount As Decimal = 0
    Public PubBillNoCancel As String = "NOBILL"
    Private Sub KOTBOTBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
        ' LoadGridDets()
        ' loadKotDataGrid()
        ' LoadDepartmentID()
        ' LoadDepartment(cmboutletID.Text.Trim, 1)
        ' LoadDepartmentsForOutLetBill()
        LoadGridMasterbill()
        LoadRoomNo()
        loadPayMethod()
        dsCurrency = New DataSet()
        LoadCurrencyType()
        LoadTaxRates()
        ' cmbType.SelectedIndex = 0
    End Sub
    Private Sub LoadTaxRates()
        Dim Conn As New SqlConnection(ConnString)
        Dim daTax As New SqlDataAdapter
        Dim dcTax As New SqlCommand
        Try
            Conn.Open()
            dcTax = New SqlCommand(" SELECT [TaxID],[TaxName],[Description] ,[Taxpercentage] FROM [Tax.Master] ", Conn)
            daTax = New SqlDataAdapter()
            daTax.SelectCommand = dcTax
            daTax.Fill(dsTaxRates)
            Dim Dscount As Integer = dsTaxRates.Tables(0).Rows.Count
            Dim DscountTest As Integer
            DscountTest = 0
            ComboBoxEditTax.Properties.Items.Clear()
            While (DscountTest < Dscount)
                ComboBoxEditTax.Properties.Items.Add(dsTaxRates.Tables(0).Rows(DscountTest)("Description").ToString())
                DscountTest = DscountTest + 1
            End While
            ComboBoxEditTax.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daTax.Dispose()
        End Try
    End Sub
    Private Sub LoadGridMasterbill()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from billmaster where [TYPE]='GUEST' order by billno desc", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcProforma.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Function getTextRates(ByVal taxCode As String) As Decimal
        Dim rate As Decimal = 1
        Dim j As Integer
        For j = 0 To dsTaxRates.Tables(0).Rows.Count - 1
            If (dsTaxRates.Tables(0).Rows(j)("Description").ToString().Trim() = taxCode.Trim()) Then
                rate = Decimal.Parse(dsTaxRates.Tables(0).Rows(j)("Taxpercentage").ToString().Trim())
            End If
        Next
        getTextRates = rate
    End Function

    Private Sub LoadCurrencyType()

        Dim Conn As New SqlConnection(ConnString)
        Dim daCurrency As New SqlDataAdapter

        Dim dcCurrency As New SqlCommand
        Try
            Conn.Open()
            dcCurrency = New SqlCommand("SELECT [RepCurrencyCode],[RepCurrencyName] ,[SellingRate] ,[BuyingRate] FROM [ExchangeRate.Master] ORDER BY [RepCurrencyCode]", Conn)
            daCurrency = New SqlDataAdapter()
            daCurrency.SelectCommand = dcCurrency
            daCurrency.Fill(dsCurrency)
            Dim Dscount As Integer = dsCurrency.Tables(0).Rows.Count
            Dim DscountTest As Integer
            DscountTest = 0
            ComboBoxEditCurrency.Properties.Items.Clear()
            While (DscountTest < Dscount)
                ComboBoxEditCurrency.Properties.Items.Add(dsCurrency.Tables(0).Rows(DscountTest)("RepCurrencyCode").ToString())
                DscountTest = DscountTest + 1
            End While

            DscountTest = 0
            ComboBoxEditCurrencymaster.Properties.Items.Clear()
            While (DscountTest < Dscount)
                ComboBoxEditCurrencymaster.Properties.Items.Add(dsCurrency.Tables(0).Rows(DscountTest)("RepCurrencyCode").ToString())
                DscountTest = DscountTest + 1
            End While

            ComboBoxEditCurrencymaster.SelectedIndex = 0
            ComboBoxEditCurrency.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daCurrency.Dispose()
        End Try
    End Sub

    'Private Sub KOTBOTBilling_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EnabledChanged
    '    If Me.Enabled Then
    '        Dim dataRowList() As DataRow
    '        gvItemDets.SetRowCellValue(frmGridRow, "Itemcode", Itemcode)
    '        gvItemDets.SetRowCellValue(frmGridRow, "Itemname", Itemname)
    '        gvItemDets.SetRowCellValue(frmGridRow, "Itemqty", Itemqty)
    '        If (Itemcode Is Nothing) Then
    '            Itemcode = ""
    '        End If
    '        If (Itemname Is Nothing) Then
    '            Itemname = ""
    '        End If
    '        If (Itemqty Is Nothing) Then
    '            Itemqty = 0
    '        End If

    '        If (Not dsItemList Is Nothing) Then
    '            If (dsItemList.Tables.Count > 0) Then

    '                dataRowList = dsItemList.Tables(0).Select(String.Format("Itemcode ='{0}'", Itemcode.Trim()))
    '                If (Not dataRowList Is Nothing) Then
    '                    If (dataRowList.Length > 0) Then
    '                        Dim val As String = dataRowList(0)("SellingPrice").ToString()
    '                        gvItemDets.SetRowCellValue(frmGridRow, "Itemprice", val)
    '                    End If
    '                End If
    '            End If
    '        End If
    '        Itemcode = Nothing
    '        Itemname = Nothing
    '        Itemqty = Nothing
    '    End If
    'End Sub

#Region "Proc & Functions"

    'Sub ClearFields()
    '    txtOutlet.Text = ""
    '    ' txtRefBillNo.Text = ""
    '    txtResNo.Text = ""
    '    txtGuest.Text = ""
    '    Dim Conn As New SqlConnection(modMain.ConnString)
    '    Dim daGetDets As New SqlDataAdapter()
    '    Dim dsShow As New DataSet
    '    '--- here what i hv done is, get a dummy dataset for itemreqdetails
    '    daGetDets = New SqlDataAdapter("select Itemcode,Itemname,Itemqty,Itemprice,UID from BillingTemp where itemcode like 'nothing'", Conn)
    '    daGetDets.Fill(dsShow)
    '    gridItemDets.DataSource = dsShow.Tables(0)
    '    'gridItemDets.DataSource = Nothing
    'End Sub
#End Region
    ''' <summary>
    ''' Insert NewKOTBOTBilling
    ''' </summary>
    ''' <returns>True-Sucess,False-Failed</returns>
    ''' <remarks></remarks>
    'Function InsertNewKOTBOTBilling(ByVal Proc As String) As Boolean

    '    Dim Conn As New SqlConnection(modMain.ConnString)
    '    Dim Procedure As String
    '    Dim TransInsert As SqlTransaction
    '    Dim IsTransEnable As Boolean = False  'Track the transection status

    '    If String.Compare(Proc, "Add", False) = 0 Then
    '        Procedure = "spItemReqAdd"
    '    Else
    '        Procedure = "spItemReqEdit"
    '    End If

    '    Dim dcExecProc As New SqlCommand(Procedure, Conn)

    '    Try


    '        '/* 
    '        '    In this process two things going to happen. 
    '        ' 1) Insert all the details to temp table 
    '        ' 2) Run the stored procedures to insert all the details from temp table
    '        '*/


    '        Conn.Open()

    '        '--- Assign the transection
    '        TransInsert = Conn.BeginTransaction
    '        IsTransEnable = True


    '        Dim sqlstring As String = ""

    '        '------- remove any previous entries if exists

    '        ' sqlstring = String.Format("Delete from BillingTemp where KOTBOTNo like '{0}' And Users like '{0}'", KOTBOTNo,Users),Conn)

    '        dcExecProc = New SqlCommand(sqlstring, Conn)
    '        dcExecProc.Transaction = TransInsert

    '        dcExecProc.ExecuteNonQuery()

    '        For i As Int16 = 0 To gvItemDets.RowCount - 1

    '            If gvItemDets.GetRowCellValue(i, "Itemcode") = "" Then
    '                Exit For
    '            End If

    '            If IsDBNull(gvItemDets.GetRowCellValue(i, "Itemprice")) Then
    '                Throw New Exception("Item price must be non zero value")
    '                Exit For
    '            End If


    '            sqlstring = "Insert Into BillingTemp(TempID,Type,Outlet,Date,KOTBOTNo,RoomNo,ReservationNo,Guest,Itemcode,Itemname,Itemqty,Itemprice,Users("
    '            sqlstring = sqlstring & "@TempID,@Type,@Outlet,@Date,@KOTBOTNo,@RoomNo,@ReservationNo,@Guest,@Itemcode,@Itemname,@Itemqty,@Itemprice,@Users)"

    '            dcExecProc = New SqlCommand(sqlstring, Conn)
    '            dcExecProc.Transaction = TransInsert



    '            With dcExecProc.Parameters
    '                .Add("@TempID", SqlDbType.NVarChar).Value = "001"
    '                .Add("@Type", SqlDbType.Date).Value = cmbType.Text
    '                .Add("@Outlet", SqlDbType.NVarChar).Value = cmboutletID.Text
    '                .Add("@Date", SqlDbType.NVarChar).Value = dtDate.Text
    '                .Add("@KOTBOTNo", SqlDbType.NVarChar).Value = "K01"
    '                .Add("@RoomNo", SqlDbType.NVarChar).Value =
    '                .Add("@ReservationNo", SqlDbType.NVarChar).Value = txtResNo.Text
    '                .Add("@Guest", SqlDbType.Float).Value = txtGuest.Text
    '                .Add("@Itemcode", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "Itemcode")
    '                .Add("@Itemname", SqlDbType.UniqueIdentifier).Value = gvItemDets.GetRowCellValue(i, "Itemname")
    '                .Add("@Itemqty", SqlDbType.NVarChar).Value = gvItemDets.GetRowCellValue(i, "Itemqty")
    '                .Add("@Itemprice", SqlDbType.NVarChar).Value = gvItemDets.GetRowCellValue(i, "Itemprice")
    '                .Add("@User", SqlDbType.NVarChar).Value = "User"
    '            End With

    '            dcExecProc.ExecuteNonQuery()

    '        Next


    '        TransInsert.Commit()
    '        IsTransEnable = False

    '        dcExecProc.Dispose()

    '        '--------------------------------------------------

    '        dcExecProc = New SqlCommand(Procedure, Conn)
    '        dcExecProc.CommandType = CommandType.StoredProcedure

    '        With dcExecProc.Parameters
    '            .Add("@CurrUser", SqlDbType.VarChar).Value = CurrUser
    '        End With

    '        dcExecProc.ExecuteNonQuery()

    '        Return 1
    '    Catch ex As SqlException
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
    '        Return 0
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
    '        Return 0
    '    Finally
    '        Conn.Dispose()
    '        dcExecProc.Dispose()

    '    End Try

    '    If IsTransEnable Then
    '        TransInsert.Rollback()
    '    End If

    'End Function

    'Sub ShowFields(ByVal kotID As String)
    '    Dim dsShow As New DataSet
    '    Dim dsShowDetail As New DataSet
    '    KotBotNo = kotID
    '    mode = "Edit"
    '    Dim Conn As New SqlConnection(modMain.ConnString)
    '    Dim daGetItemToDisplay As New SqlDataAdapter("SELECT [ItemCode] as 'Itemcode',[ItemName] as 'Itemname',[Qty] as 'Itemqty',[UnitPrice] as 'Itemprice' FROM [KotBotDetail] where KOTBOTID='" & kotID & "'", Conn)
    '    Dim daGetDets As New SqlDataAdapter("SELECT * FROM [KotBotMaster] where [id]='" & kotID & "'", Conn)

    '    Try

    '        Conn.Open()
    '        daGetDets.Fill(dsShow)
    '        Conn.Close()

    '        Conn.Open()
    '        daGetItemToDisplay.Fill(dsShowDetail)
    '        Conn.Close()

    '        If (Not dsShowDetail Is Nothing) Then
    '            gridItemDets.DataSource = dsShowDetail.Tables(0)
    '        End If

    '        cmbType.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Type")), "", dsShow.Tables(0).Rows(0).Item("Type"))
    '        dtDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Date")), "", dsShow.Tables(0).Rows(0).Item("Date"))
    '        cmbRmNo.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("RoomNo")), "", dsShow.Tables(0).Rows(0).Item("RoomNo"))
    '        txtResNo.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ReservationNo")), "", dsShow.Tables(0).Rows(0).Item("ReservationNo"))
    '        LoadUserData(dsShow.Tables(0).Rows(0).Item("RoomNo"), 1)
    '        daGetDets.Dispose()
    '        dsShow.Dispose()

    '        tabMain.SelectedTabPageIndex = 1

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
    '    Finally
    '        Conn.Dispose()
    '        daGetDets.Dispose()
    '        dsShow.Dispose()

    '    End Try


    'End Sub
    ''' <summary>
    ''' Its Load Grid Details
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    'Sub loadKotDataGrid()
    '    Dim Conn As New SqlConnection(modMain.ConnString)
    '    '  Dim daGetDets As New SqlDataAdapter("SELECT top 0 [ItemCode] as 'Itemcode',[ItemName] as 'Itemname',[Qty] as 'Itemqty',[UnitPrice] as 'Itemprice' FROM [KotBotDetail]", Conn)
    '    Dim daGetItemToDisplay As New SqlDataAdapter("SELECT [Id] as KOTBOTNo,[Date],[RoomNo] as 'Room No',[ReservationNo] as 'Reservation No',[Type],[Department] FROM [KotBotMaster] where [BillGenerated] =0", Conn)
    '    Dim dsShow As New DataSet
    '    Dim dsMainShow As New DataSet

    '    Try

    '        If (Not daGetItemToDisplay Is Nothing) Then
    '            daGetItemToDisplay.Fill(dsMainShow)
    '        End If

    '        '  gridItemDets.DataSource = dsShow.Tables(0)
    '        gcKOTBOTBilling.DataSource = dsMainShow.Tables(0)
    '        dsShow.Dispose()
    '        dsMainShow.Dispose()
    '        daGetItemToDisplay.Dispose()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
    '    Finally
    '        Conn.Dispose()
    '        dsShow.Dispose()
    '        daGetItemToDisplay.Dispose()
    '        dsMainShow.Dispose()
    '    End Try
    'End Sub

    'Sub LoadGridDets()

    '    Dim Conn As New SqlConnection(modMain.ConnString)
    '    Dim daGetDets As New SqlDataAdapter("SELECT top 0 [ItemCode] as 'Itemcode',[ItemName] as 'Itemname',[Qty] as 'Itemqty',[UnitPrice] as 'Itemprice' FROM [KotBotDetail] ", Conn)
    '    '  Dim daGetItemToDisplay As New SqlDataAdapter("SELECT [Id] as KOTBOTNo,[Date],[RoomNo] as 'Room No',[ReservationNo] as 'Reservation No',[Type],[Department] FROM [KotBotMaster]", Conn)
    '    Dim dsShow As New DataSet
    '    '    Dim dsMainShow As New DataSet

    '    Try
    '        If (Not daGetDets Is Nothing) Then
    '            daGetDets.Fill(dsShow)
    '        End If

    '        'If (Not daGetItemToDisplay Is Nothing) Then
    '        '    daGetItemToDisplay.Fill(dsMainShow)
    '        'End If

    '        gridItemDets.DataSource = dsShow.Tables(0)
    '        '   gcKOTBOTBilling.DataSource = dsMainShow.Tables(0)

    '        dsShow.Dispose()
    '        '   dsMainShow.Dispose()
    '        daGetDets.Dispose()
    '        '   daGetItemToDisplay.Dispose()

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
    '    Finally
    '        Conn.Dispose()
    '        daGetDets.Dispose()
    '        dsShow.Dispose()
    '        '     daGetItemToDisplay.Dispose()
    '        '    dsMainShow.Dispose()
    '    End Try
    'End Sub

    Private Function GetDataForSQL(ByVal sql As String) As Data.DataTable
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter(sql, Conn)

        Dim dsShow As New DataSet

        Try
            If (Not daGetDets Is Nothing) Then
                daGetDets.Fill(dsShow)
            End If
            dsShow.Dispose()

            daGetDets.Dispose()

            GetDataForSQL = dsShow.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try
    End Function

    Private Function getOutLetBillNO() As String
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim daGetDets As SqlDataAdapter
        Try

            Conn.Open()
            daGetDets = New SqlDataAdapter("select isnull(MAX(no),0) as no from [OutLetBillMaster]", Conn)
            Dim dsShow As DataSet = New DataSet
            daGetDets.Fill(dsShow)
            If (Not dsShow Is Nothing) Then
                If (dsShow.Tables(0).Rows.Count > 0) Then
                    getOutLetBillNO = dsShow.Tables(0).Rows(0)("no")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
            Return Nothing
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
        End Try
    End Function

    Private Function getNewKotBotNO() As String
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim daGetDets As SqlDataAdapter
        Try

            Conn.Open()
            daGetDets = New SqlDataAdapter("select isnull(MAX(no),0) as no from [KotBotMaster]", Conn)
            Dim dsShow As DataSet = New DataSet
            daGetDets.Fill(dsShow)
            If (Not dsShow Is Nothing) Then
                If (dsShow.Tables(0).Rows.Count > 0) Then
                    getNewKotBotNO = dsShow.Tables(0).Rows(0)("no")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
            Return Nothing
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
        End Try
    End Function



    Private Function getCurrencyCode(ByVal billc As String) As String
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim daGetDets As SqlDataAdapter
        Try

            Conn.Open()
            Dim sql As String = "select CurrencyCode from [OutLetBillMaster] where [BillNo]='" & billc & "'"
            daGetDets = New SqlDataAdapter(sql, Conn)
            Dim dsShow As DataSet = New DataSet
            daGetDets.Fill(dsShow)
            If (Not dsShow Is Nothing) Then
                If (dsShow.Tables(0).Rows.Count > 0) Then
                    getCurrencyCode = dsShow.Tables(0).Rows(0)("CurrencyCode").ToString()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
            Return Nothing
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
        End Try
    End Function

    Private Function getNewBillNO() As String
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim daGetDets As SqlDataAdapter
        Try

            Conn.Open()
            daGetDets = New SqlDataAdapter("select isnull(MAX(no),0) as no from [OutLetBillMaster]", Conn)
            Dim dsShow As DataSet = New DataSet
            daGetDets.Fill(dsShow)
            If (Not dsShow Is Nothing) Then
                If (dsShow.Tables(0).Rows.Count > 0) Then
                    getNewBillNO = dsShow.Tables(0).Rows(0)("no").ToString()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
            Return Nothing
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
        End Try
    End Function


    Private Sub ShowReportView(ByVal reportClass As CrystalDecisions.CrystalReports.Engine.ReportClass, ByVal dataSet As System.Data.DataSet)
        Dim frmReport As New frmViewReport(reportClass, dataSet)
        frmReport.Show()
    End Sub

    Function DSCheckInsertBillingTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim RefBillNo As String = "" 'txtRefBillNo.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[KotBotMaster] where id=@RefBillNo", Conn)
            dcSearch.Parameters.Add("@RefBillNo", SqlDbType.VarChar).Value = RefBillNo

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertBillingTemp = dsMain
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function

    'Private Sub LoadDepartmentID()

    '    Dim Conn As New SqlConnection(ConnString)
    '    Dim daMain As New SqlDataAdapter
    '    '   Dim dsDepartments As New DataSet
    '    Dim dcSearch As New SqlCommand
    '    Try
    '        Conn.Open()
    '        '  dcSearch = New SqlCommand("select DepartmentID from [DepartmentMaster] order by DepartmentID", Conn)
    '        dcSearch = New SqlCommand("SELECT [DepartmentID],[Description] FROM [DepartmentMaster] order by DepartmentID", Conn)

    '        daMain = New SqlDataAdapter()
    '        daMain.SelectCommand = dcSearch
    '        daMain.Fill(dsDepartments)

    '        Dim Dscount As Integer = dsDepartments.Tables(0).Rows.Count
    '        Dim DscountTest As Integer

    '        While (DscountTest < Dscount)
    '            cmboutletID.Properties.Items.Add(dsDepartments.Tables(0).Rows(DscountTest)(0).ToString())
    '            DscountTest = DscountTest + 1
    '        End While

    '        cmboutletID.SelectedIndex = 0

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
    '    Finally
    '        Conn.Dispose()
    '        daMain.Dispose()
    '        '  dsMain.Dispose()
    '    End Try
    'End Sub

    'Private Sub LoadDepartment(ByVal DepartmentID As String, ByVal combo As Int32)
    '    Try
    '        Dim PassDepartmentID As String = DepartmentID
    '        If (Not dsDepartments Is Nothing) Then
    '            Dim dataRowList() As DataRow
    '            dataRowList = dsDepartments.Tables(0).Select(String.Format("DepartmentID ='{0}'", PassDepartmentID))
    '            If (Not dataRowList Is Nothing) Then
    '                If (dataRowList.Length > 0) Then
    '                    If (combo = 1) Then
    '                        txtOutlet.Text = dataRowList(0)("Description").ToString()
    '                    ElseIf (combo = 2) Then
    '                        txtOutletName.Text = dataRowList(0)("Description").ToString()
    '                    End If

    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
    '    End Try
    'End Sub

    Private Sub LoadRoomNo()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            '   dcSearch = New SqlCommand("select Roomno from [Rooms.Master] order by Roomno", Conn)
            dcSearch = New SqlCommand("select [RoomNo] from [Room.CurrentStatus] order by [RoomNo]", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            DscountTest = 0
            While (DscountTest < Dscount)
                ComboBoxRoomNo.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While

            DscountTest = 0
            While (DscountTest < Dscount)
                ComboRoom.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While

            ComboRoom.SelectedIndex = 0
            ComboBoxRoomNo.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    ' 
    'Private Sub loadCurrency()
    '    Dim Conn As New SqlConnection(ConnString)
    '    Dim daMain As New SqlDataAdapter
    '    Dim dcSearch As New SqlCommand
    '    Try
    '        Conn.Open()
    '        dcSearch = New SqlCommand("SELECT [Currency],[CurrencuSymbol],[Country] FROM [dbo].[CurrencyType]", Conn)

    '        daMain = New SqlDataAdapter()
    '        daMain.SelectCommand = dcSearch
    '        daMain.Fill(dsCurrency)

    '        Dim Dscount As Integer = dsCurrency.Tables(0).Rows.Count
    '        Dim DscountTest As Integer = 0


    '        While (DscountTest < Dscount)
    '            ComboBoxEditCurrency.Properties.Items.Add(dsCurrency.Tables(0).Rows(DscountTest)(0).ToString())
    '            DscountTest = DscountTest + 1
    '        End While
    '        ComboBoxEditCurrency.SelectedIndex = 0
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
    '    Finally
    '        Conn.Dispose()
    '        daMain.Dispose()
    '    End Try
    'End Sub

    Private Sub loadPayMethod()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        '      Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT [PaymentTypeCode],[Description],[NumberRequired],[BankRequired] FROM [dbo].[PaymentType]", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsPayMethod)

            dsPayMethodMAster = dsPayMethod.Copy()

            Dim Dscount As Integer = dsPayMethod.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)
                ComboBoxPayMethod.Properties.Items.Add(dsPayMethod.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While
            ComboBoxPayMethod.SelectedIndex = 0

            DscountTest = 0
            While (DscountTest < Dscount)
                ComboBoxEditPayMethod.Properties.Items.Add(dsPayMethodMAster.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While
            ComboBoxPayMethod.SelectedIndex = 0
            ComboBoxEditPayMethod.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            '  dsMain.Dispose()
        End Try
    End Sub

    'Private Sub cmboutletID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    LoadDepartment(cmboutletID.Text, 1)
    '    LoadCombos(cmboutletID.Text)
    'End Sub

    'Private Sub gvKOTBOTBilling_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ShowFields(gvKOTBOTBilling.GetFocusedRowCellValue("KOTBOTNo"))
    'End Sub

    'Private Sub gvItemDets_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
    '    If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) Then
    '        If (Not IsDBNull(e.Value)) Then
    '            Dim RefBillNo As String = e.Value
    '            frmItemSelection.frmHandle = Me
    '            frmItemSelection.InvLocation = cmboutletID.Text
    '            Me.frmGridRow = e.RowHandle
    '            frmItemSelection.Show()
    '            Me.Enabled = False
    '        End If
    '    End If
    'End Sub

    'Private Sub gvItemDets_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '    If gvItemDets.RowCount > 0 Then
    '        If gvItemDets.GetRowCellValue(gvItemDets.RowCount - 1, "Itemcode") = "" Then
    '            Exit Sub
    '        End If

    '        gvItemDets.SetRowCellValue(e.RowHandle, "Itemcode", Guid.NewGuid)
    '    End If
    'End Sub

    'Private Sub cmbRmNo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
    '    txtResNo.Text = ""
    '    txtGuest.Text = ""
    '    LoadUserData(cmbRmNo.Text, 1)
    'End Sub

    Private Sub LoadUserData(ByVal RoomNo As String)
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsGuest As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            'dcSearch = New SqlCommand("select c.ReservationNo,c.BillingGuest as 'GuestName' from [Guest.RegisterMaster] R inner join [Room.CurrentStatus] c on c.ReservationNo=R.ReservationNo where R.IsMasterRecord=1 and c.RoomNo='" & RoomNo & "'", Conn)
            dcSearch = New SqlCommand("select c.ReservationNo,c.BillingGuest as 'GuestName' from [GuestRegistration] R inner join [Room.CurrentStatus] c on c.ReservationNo=R.ReservationNo where R.IsBillingGuest=1 and c.RoomNo='" & RoomNo & "'", Conn)
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsGuest)
            If (Not dsGuest Is Nothing) Then
                If (dsGuest.Tables(0).Rows.Count > 0) Then
                    If (IsDBNull(dsGuest.Tables(0).Rows(0)("GuestName"))) Then
                        TextEditGuest.Text = ""
                        txtresno.Text = ""
                    Else
                        TextEditGuest.Text = dsGuest.Tables(0).Rows(0)("GuestName")
                        txtresno.Text = dsGuest.Tables(0).Rows(0)("ReservationNo")

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
        End Try
    End Sub

    'Sub LoadCombos(depNo As String)
    '    Dim Conn As New SqlConnection(modMain.ConnString)
    '    Dim daGetDets, daGridLookup As New SqlDataAdapter()
    '    Dim dsShow, dsGridLookup As New DataSet
    '    Try

    '        '----- Load Item Master to Grid
    '        daGridLookup = New SqlDataAdapter(" SELECT its.[Itemcode],it.[Description],its.[SellingPrice] FROM [ItemSellingDetail] its inner join dbo.ItemMaster It on IT.Itemcode=its.Itemcode  WHERE its.[DepartmentID]='" & depNo & "'", Conn)
    '        daGridLookup.Fill(dsGridLookup)
    '        dsItemList = dsGridLookup

    '        For i As Integer = 0 To dsGridLookup.Tables(0).Rows.Count - 1
    '            repItemList.Items.Add(dsGridLookup.Tables(0).Rows(i).Item(0))
    '        Next

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
    '    Finally
    '        Conn.Dispose()
    '        daGetDets.Dispose()
    '        dsShow.Dispose()
    '        daGridLookup.Dispose()
    '        dsGridLookup.Dispose()
    '    End Try
    'End Sub

    '    Private Sub gvItemDets_CellValueChanging(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvItemDets.CellValueChanging

    '        If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) Then
    '            Dim RefBillNo As String = e.Value
    '            Dim PassDepartmentID As String = e.Value
    '            If (Not dsItemList Is Nothing) Then
    '                Dim dataRowList() As DataRow
    '                dataRowList = dsItemList.Tables(0).Select(String.Format("Itemcode ='{0}'", PassDepartmentID.Trim()))
    '                If (Not dataRowList Is Nothing) Then
    '                    If (dataRowList.Length > 0) Then
    '                        Dim dd As String = dataRowList(0)("Description").ToString()
    '                        Dim val As String = dataRowList(0)("SellingPrice").ToString()

    '                        gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemname", dd)
    '                        gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemprice", val)
    '                    End If
    '                End If
    '            End If


    '        End If
    '    End Sub
    'End Class

    'Private Sub gvItemDets_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvItemDets.CellValueChanged

    '    Dim view As GridView = TryCast(sender, GridView)
    '    If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) Then

    '        Dim RefBillNo As String = e.Value
    '        Dim PassDepartmentID As String = e.Value
    '        If (Not dsItemList Is Nothing) Then
    '            Dim dataRowList() As DataRow
    '            dataRowList = dsItemList.Tables(0).Select(String.Format("Itemcode ='{0}'", PassDepartmentID.Trim()))
    '            If (Not dataRowList Is Nothing) Then
    '                If (dataRowList.Length > 0) Then
    '                    Dim dd As String = dataRowList(0)("Description").ToString()
    '                    Dim val As String = dataRowList(0)("SellingPrice").ToString()
    '                    view.SetRowCellValue(e.RowHandle, "Itemname", dd)
    '                    view.SetRowCellValue(e.RowHandle, "Itemprice", val)
    '                    'gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemname", dd)
    '                    ' gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemprice", val)
    '                End If
    '            End If
    '        End If


    '    End If
    'End Sub

    'Private Sub btnInactive_Click(sender As System.Object, e As System.EventArgs)
    '    Dim Conn As SqlConnection
    '    Dim command As SqlCommand
    '    Try
    '        If (tabMain.SelectedTabPageIndex <> 1) Then
    '            tabMain.SelectedTabPageIndex = 1
    '        Else
    '            KotBotNo = gvKOTBOTBilling.GetFocusedRowCellValue("KOTBOTNo")

    '            Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive the selected KotBot", " KotBot to Inactive ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '            If bt = Windows.Forms.DialogResult.Yes Then
    '                If (String.IsNullOrEmpty(KotBotNo)) Then
    '                    MessageBox.Show("Please select KotBot to Inactive", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                Else
    '                    Dim sqlstring As String = ""
    '                    Dim ConnStr As String = ConnString
    '                    Conn = New SqlConnection(ConnStr)
    '                    command = New SqlCommand
    '                    Dim dcInsertNewAccDetail As New SqlCommand

    '                    Conn.Open()
    '                    sqlstring = "UPDATE [KotBotMaster] SET [Active] = 0  WHERE Id=" & KotBotNo
    '                    command = New SqlCommand(sqlstring, Conn)
    '                    command.ExecuteNonQuery()
    '                    Conn.Close()

    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
    '    Finally
    '        If (Not Conn Is Nothing) Then
    '            Conn.Dispose()
    '        End If
    '    End Try

    'End Sub

    Private Sub btnBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim unboundValue As Object = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Unbound1")
        '    unboundValue = Not (boolean)unboundValue
        'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Unbound1", unboundValue)
    End Sub

    Dim NumberRequiredNotGiven As Boolean = False
    Dim BankNotGiven As Boolean = False

    Private Function validate() As Boolean

        Dim PayMethod As String = ComboBoxEditPayMethod.Text
        Dim NumberRequired As Boolean = False
        Dim BankRequired As Boolean = False

        If (Not PayMethod Is Nothing) Then
            Dim dataRowList() As DataRow
            dataRowList = dsPayMethod.Tables(0).Select(String.Format("PaymentTypeCode ='{0}'", PayMethod))
            If (Not dataRowList Is Nothing) Then
                If (dataRowList.Length > 0) Then
                    If (dataRowList(0)("NumberRequired").ToString().ToLower() = "true") Then
                        NumberRequired = True
                    End If
                End If
            End If
            If (Not dataRowList Is Nothing) Then
                If (dataRowList.Length > 0) Then
                    If (dataRowList(0)("BankRequired").ToString().ToLower() = "true") Then
                        BankRequired = True
                    End If
                End If
            End If
        End If

        If (BankRequired = True) Then
            If (String.IsNullOrEmpty(TextEditBankMaster.Text)) Then
                BankNotGiven = True
                MsgBox("Please Fill Payment Details", MsgBoxStyle.Critical, "Error.")
                validate = False
                Return False
            End If
        End If

        If (NumberRequired = True) Then
            If (String.IsNullOrEmpty(TextEditPayMethodNumberMater.Text)) Then
                NumberRequiredNotGiven = True
                MsgBox("Please select " & LabelControlPayMethod.Text, MsgBoxStyle.Critical, "Error.")
                validate = False
                Return False
            End If
        End If
        validate = True
    End Function

    Private Function getToOperatorNumber(resNumber As String) As String
        Dim toOperator As String = ""
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets, datoOperator As New SqlDataAdapter()
        Dim dsShow, dsOperator As New DataSet
        Try

            Dim sql As String = "SELECT dbo.[Reservation.Master].ResNo, dbo.[Reservation.Master].Topcode, dbo.[Touroperator.Master].TopName FROM  dbo.[Reservation.Master] INNER JOIN dbo.[Touroperator.Master] ON dbo.[Reservation.Master].Topcode  COLLATE  SQL_Latin1_General_CP1_CI_AS = dbo.[Touroperator.Master].TopCode where dbo.[Reservation.Master].ResNo='" & resNumber & "'"
            datoOperator = New SqlDataAdapter(Sql, Conn)
            datoOperator.Fill(dsOperator)

            If (Not dsOperator Is Nothing) Then
                If (dsOperator.Tables(0).Rows.Count > 0) Then
                    toOperator = dsOperator.Tables(0).Rows(0)("TopName")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
            datoOperator.Dispose()
            dsOperator.Dispose()
        End Try

        getToOperatorNumber = toOperator
    End Function
    Function GetMasBillNo() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()

        Try

          

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "MBILL"
            ' dcGetCode.Parameters.Add("@PREFIX1", SqlDbType.NVarChar).Value = GetPrefix
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output
            dcGetCode.ExecuteNonQuery()




            If (Not IsDBNull(dcGetCode.Parameters("@Currcode").Value)) Then

                GetMasBillNo = dcGetCode.Parameters("@Currcode").Value


                Return GetMasBillNo

            Else

                GetMasBillNo = ""

                Return GetMasBillNo

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function
    Private Sub btnCreateBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateBilling.Click



        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Master billing", "MasterBill")

        If CheckAccess = True Then




            Dim CurrentUser As String = CurrUser

            Dim bill As String = ""
            Dim BillGeneratedDate As String = ""
            Dim Department As String = ""
            Dim GrandTotaloftheInvoices As Double = 0
            Dim ServiceCharge As Double = 0
            Dim Total As Double = 0
            Dim GSTTax As Decimal 'Double = 0
            Dim GrandTotal As Decimal = 0
            Dim Discountgiven As Double = 0
            Dim AdvancePaid As Double = 0
            Dim NetAmounttobesettled As Double = 0
            Dim Discount As Double
            If (tabMain.SelectedTabPageIndex <> 1) Then
                tabMain.SelectedTabPageIndex = 1
            ElseIf (tabMain.SelectedTabPageIndex = 1) Then
                Dim bt As DialogResult = MessageBox.Show("Do you want to generate master bill for Room Number: " & ComboBoxRoomNo.Text,
                                                         " Master bill Generate ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then
                    Dim isValid As Boolean = validate()
                    If (isValid = True) Then
                        Dim cnumberPart As String = ""
                        Dim ConnStr As String = ConnString
                        Dim Conn As New SqlConnection(ConnStr)
                        Dim dcMasterBill As New SqlCommand
                        Dim dateVal As DateTime = DateTime.Now
                        Dim intNo As Integer = getNewBillNO()
                        intNo = intNo + 1
                        'unpaid
                        cnumberPart = intNo.ToString()
                        Dim billnumbers As String = String.Empty
                        Dim paid As String = String.Empty

                        'Dim autoid As String = "MB" & dateVal.Year.ToString().Trim() & dateVal.Month.ToString().Trim() & dateVal.Day.ToString().Trim() & cnumberPart

                        Dim autoid As String = GetMasBillNo()
                        PubMasNo = autoid



                        Dim I As Integer
                        Dim DataRowCount As Integer = GridView1.DataRowCount
                        For I = 0 To DataRowCount - 1
                            paid = String.Empty
                            paid = GridView1.GetRowCellValue(I, "Paid")
                            If (paid.ToLower().Trim() = "false") Then
                                Dim outLetBill As String = GridView1.GetRowCellValue(I, "Bill No")
                                billnumbers = billnumbers & outLetBill & ","

                                dsUnPaid.Tables(0).Rows(I)("sum") = TextEditUnPaid.Text
                            End If
                        Next
                        I = 0

                        DataRowCount = GridView4.DataRowCount
                        For I = 0 To DataRowCount - 1
                            Dim outLetBill As String = GridView4.GetRowCellValue(I, "Bill No")
                            billnumbers = billnumbers & outLetBill & ","
                            dsPaid.Tables(0).Rows(I)("sum") = TextEditPaid.Text
                        Next
                        If (billnumbers.Length > 0) Then
                            billnumbers = billnumbers.Remove(billnumbers.Length - 1)
                        End If
                        Dim rmsDbDataSet As New DataSet

                        Dim taxRate As Decimal = getTextRates(ComboBoxEditTax.Text)
                        Dim serCharge As Decimal = Decimal.Parse(TextEditServiceCharge.Text)
                        Dim t As Double = Double.Parse(TextEditUnPaid.Text) * (taxRate / 100)
                        Dim s As Double = Double.Parse(TextEditUnPaid.Text) * (serCharge / 100)
                        Dim g As Double = t + s + Double.Parse(TextEditTotal.Text)

                        If (String.IsNullOrEmpty(TextEditServiceCharges.Text)) Then
                            ServiceCharge = 0
                        Else
                            ServiceCharge = Double.Parse(TextEditServiceCharges.Text)
                        End If

                        Conn.Open()
                        dcMasterBill = New SqlCommand("genarate_masterBill_SP", Conn)
                        dcMasterBill.CommandType = CommandType.StoredProcedure
                        dcMasterBill.Parameters.Add("billNo ", SqlDbType.VarChar).Value = autoid
                        dcMasterBill.Parameters.Add("OutLetbillNo", SqlDbType.VarChar).Value = billnumbers
                        dcMasterBill.Parameters.Add("taxrate", SqlDbType.Decimal).Value = taxRate
                        dcMasterBill.Parameters.Add("ServiceCharge", SqlDbType.Decimal).Value = ServiceCharge
                        dcMasterBill.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value = CurrentUser


                        dcMasterBill.ExecuteNonQuery()
                        Conn.Close()

                        Dim dt As New DataTable()
                        dt = dsUnPaid.Tables(0).Clone()

                        Dim drBlank1 As DataRow = dt.NewRow()
                        drBlank1("t") = "Paid recipts"
                        drBlank1("MasterBillNo") = autoid
                        drBlank1("guest") = TextEditGuest.Text
                        drBlank1("RoomNo") = ComboBoxRoomNo.Text
                        drBlank1("balance") = TextEditUnPaid.Text
                        drBlank1("grandTot") = TextEditTotal.Text
                        dt.Rows.Add(drBlank1)

                        If (Not dsPaid Is Nothing) Then
                            Dim k As Integer
                            For k = 0 To dsPaid.Tables(0).Rows.Count - 1
                                Dim dr As DataRow = dt.NewRow()
                                If (k = 0) Then
                                    bill = dsPaid.Tables(0).Rows(k)("Bill No")
                                End If
                                dr("MasterBillNo") = autoid
                                dr("Receipt") = dsPaid.Tables(0).Rows(k)("Receipt")
                                dr("Bill No") = dsPaid.Tables(0).Rows(k)("Bill No")
                                dr("Amount") = dsPaid.Tables(0).Rows(k)("Amount")
                                dr("RoomNo") = dsPaid.Tables(0).Rows(k)("RoomNo")
                                dr("guest") = dsPaid.Tables(0).Rows(k)("guest")
                                dr("PayType") = dsPaid.Tables(0).Rows(k)("PayType")
                                dr("sum") = dsPaid.Tables(0).Rows(k)("sum")
                                dr("balance") = TextEditTotal.Text
                                dr("grandTot") = g.ToString() ' TextEditUnPaid.Text
                                dr("BillGeneratedDate") = dsPaid.Tables(0).Rows(k)("BillGeneratedDate")
                                dr("Department") = dsPaid.Tables(0).Rows(k)("Department")
                                dr("DepDate") = dsPaid.Tables(0).Rows(k)("BillGeneratedDate")
                                dr("ArriveDate") = dsPaid.Tables(0).Rows(k)("ArriveDate")
                                dr("opdetail") = dsPaid.Tables(0).Rows(k)("opdetail")
                                dt.Rows.Add(dr)
                            Next
                        End If

                        Dim drBlank2 As DataRow = dt.NewRow()
                        dt.Rows.Add(drBlank2)

                        Dim drBlank3 As DataRow = dt.NewRow()
                        drBlank3("MasterBillNo") = autoid
                        drBlank3("guest") = TextEditGuest.Text
                        drBlank3("RoomNo") = ComboBoxRoomNo.Text
                        drBlank3("balance") = TextEditUnPaid.Text
                        drBlank3("grandTot") = TextEditTotal.Text
                        drBlank3("t") = "Un Piad Bills"

                        dt.Rows.Add(drBlank3)
                        paid = String.Empty
                        If (Not dsUnPaid Is Nothing) Then
                            Dim J As Integer
                            For J = 0 To dsUnPaid.Tables(0).Rows.Count - 1
                                Dim dr As DataRow = dt.NewRow()
                                paid = String.Empty
                                paid = dsUnPaid.Tables(0).Rows(J)("Paid")
                                If (paid.Trim().ToLower() = "false") Then
                                    dr("Bill No") = dsUnPaid.Tables(0).Rows(J)("Bill No")
                                    dr("Receipt") = dsUnPaid.Tables(0).Rows(J)("Receipt")
                                    dr("MasterBillNo") = autoid ' dsUnPaid.Tables(0).Rows(J)("Bill No")
                                    dr("Amount") = dsUnPaid.Tables(0).Rows(J)("Amount")
                                    dr("RoomNo") = dsUnPaid.Tables(0).Rows(J)("RoomNo")
                                    dr("guest") = dsUnPaid.Tables(0).Rows(J)("guest")
                                    dr("PayType") = dsUnPaid.Tables(0).Rows(J)("PayType")
                                    dr("sum") = dsUnPaid.Tables(0).Rows(J)("sum")
                                    dr("balance") = TextEditTotal.Text
                                    dr("grandTot") = g.ToString() 'TextEditUnPaid.Text
                                    dr("Department") = dsUnPaid.Tables(0).Rows(J)("Department")
                                    dr("BillGeneratedDate") = dsUnPaid.Tables(0).Rows(J)("BillGeneratedDate")
                                    dr("DepDate") = dsUnPaid.Tables(0).Rows(J)("BillGeneratedDate")
                                    dr("ArriveDate") = dsUnPaid.Tables(0).Rows(J)("ArriveDate")
                                    dr("opdetail") = dsUnPaid.Tables(0).Rows(J)("opdetail")
                                    dt.Rows.Add(dr)
                                End If
                            Next
                        End If

                        Dim drBlank5 As DataRow = dt.NewRow()
                        drBlank5("GrandTotaloftheInvoices") = TextEditUnPaid.Text ' TextEditPaid.Text
                        drBlank5("MasterBillNo") = autoid
                        dt.Rows.Add(drBlank5)

                        GrandTotaloftheInvoices = Double.Parse(TextEditUnPaid.Text)

                        ' ServiceCharge = GrandTotaloftheInvoices * 0.1
                        Dim drBlank7 As DataRow = dt.NewRow()
                        Total = ServiceCharge + GrandTotaloftheInvoices
                        Dim taxrates As Decimal = taxRate / 100
                        GSTTax = Total * taxrates
                        GrandTotal = GSTTax + Total

                        If String.IsNullOrEmpty(TextEditDiscount.Text) Then
                            Discount = GrandTotal - Discountgiven
                        Else
                            Discountgiven = Double.Parse(TextEditDiscount.Text)
                            Discount = GrandTotal - Discountgiven
                        End If

                        Dim advance As Double = Double.Parse(TextEditPaid.Text)
                        NetAmounttobesettled = Discount - advance
                        rmsDbDataSet.Tables.Add(dt)
                        rmsDbDataSet.Tables(0).TableName = "Table"

                        Dim dt2 As DataTable = getdeparmentwise()
                        dt2.TableName = "t2"
                        rmsDbDataSet.Tables.Add(dt2)
                        rmsDbDataSet.Tables(1).TableName = "t2"

                        '     rmsDbDataSet.WriteXmlSchema("c:\master11.xsd")
                        Dim res As String = ""
                        Dim toOperator As String = ""
                        If (Not dsUnPaid Is Nothing) Then
                            If (dsUnPaid.Tables(0).Rows.Count > 0) Then
                                toOperator = getToOperatorNumber(dsUnPaid.Tables(0).Rows(0)("ReservationNo"))
                            End If
                        End If

                        Dim l As Integer
                        For l = 0 To rmsDbDataSet.Tables(0).Rows.Count - 1
                            rmsDbDataSet.Tables(0).Rows(l)("GrandTotaloftheInvoices") = FormatNumber(TextEditUnPaid.Text, 2)

                            rmsDbDataSet.Tables(0).Rows(l)("ServiceCharge") = FormatNumber(ServiceCharge, 2)
                            rmsDbDataSet.Tables(0).Rows(l)("Total") = FormatNumber(Total, 2)
                            rmsDbDataSet.Tables(0).Rows(l)("GSTTax") = "GST Tax     (" & ComboBoxEditTax.Text & " %)                                                                                                   " & FormatNumber(GSTTax, 2)

                            If String.IsNullOrEmpty(TextEditDiscount.Text) Then
                                rmsDbDataSet.Tables(0).Rows(l)("Discountgiven") = "0"
                            Else
                                rmsDbDataSet.Tables(0).Rows(l)("Discountgiven") = FormatNumber(TextEditDiscount.Text, 2)
                            End If
                            If String.IsNullOrEmpty(TextEditDiscount.Text) Then
                                rmsDbDataSet.Tables(0).Rows(l)("sum") = ""
                            Else
                                rmsDbDataSet.Tables(0).Rows(l)("sum") = FormatNumber(Discount, 2)
                            End If
                            rmsDbDataSet.Tables(0).Rows(l)("AdvancePaid") = FormatNumber(TextEditPaid.Text, 2)
                            rmsDbDataSet.Tables(0).Rows(l)("NetAmounttobesettled") = FormatNumber(NetAmounttobesettled, 2)
                            rmsDbDataSet.Tables(0).Rows(l)("GrandTotal") = FormatNumber(GrandTotal, 2)
                            rmsDbDataSet.Tables(0).Rows(l)("Discount") = FormatNumber(Discount, 2)
                            rmsDbDataSet.Tables(0).Rows(l)("opdetail") = toOperator

                        Next

                        ''''''''''''''''
                        Dim jj As Integer
                        jj = 0
                        For jj = 0 To dt2.Rows.Count - 1
                            Dim dr As DataRow = dt.NewRow()
                            dr("MasterBillNo") = ""
                            dr("Receipt") = ""
                            dr("Bill No") = ""
                            '   dr("Amount") = 0
                            dr("RoomNo") = ""
                            dr("guest") = ""
                            dr("PayType") = ""
                            dr("sum") = ""
                            dr("balance") = ""
                            dr("grandTot") = ""
                            ' dr("BillGeneratedDate") = 
                            dr("Department") = ""
                            '    dr("DepDate") = ""
                            '   dr("ArriveDate") = ""
                            dr("opdetail") = ""
                            dr("Department1") = dt2.Rows(jj)("Department").ToString()
                            dr("departmenttot") = dt2.Rows(jj)("Amount").ToString()

                            dr("GrandTotaloftheInvoices") = FormatNumber(TextEditUnPaid.Text, 2)

                            dr("ServiceCharge") = FormatNumber(ServiceCharge, 2)
                            dr("Total") = FormatNumber(Total, 2)
                            dr("GSTTax") = "GST Tax     (" & ComboBoxEditTax.Text & " %)                                                                                                   " & FormatNumber(GSTTax, 2)

                            If String.IsNullOrEmpty(TextEditDiscount.Text) Then
                                dr("Discountgiven") = "0"
                            Else
                                dr("Discountgiven") = FormatNumber(TextEditDiscount.Text, 2)
                            End If
                            If String.IsNullOrEmpty(TextEditDiscount.Text) Then
                                dr("sum") = ""
                            Else
                                dr("sum") = FormatNumber(Discount, 2)
                            End If
                            dr("AdvancePaid") = FormatNumber(TextEditPaid.Text, 2)
                            dr("NetAmounttobesettled") = FormatNumber(NetAmounttobesettled, 2)
                            dr("GrandTotal") = FormatNumber(GrandTotal, 2)
                            dr("Discount") = FormatNumber(Discount, 2)
                            dr("opdetail") = toOperator
                            dt.Rows.Add(dr)
                        Next
                        ''''''''''''''




                        '   PrintMasInv(PubMasNo)

                        InsertTempMasBill(PubMasNo)

                        PrintMasInv()



                        LoadFinalMasBillAmount(PubMasNo)


                        UpdateMasBillTbl(PubMasNo, PubFinalMasterAmount)


                        'ShowReportView(New MasterBill1, rmsDbDataSet)

                        Dim GetNetAmtToSettle As Decimal = FormatNumber(NetAmounttobesettled, 2)

                        Dim PassMasBillno As String = PubMasNo

                        oulteltbill(PubFinalMasterAmount, PassMasBillno)


                        '  oulteltbill(GetNetAmtToSettle, PassMasBillno)

                        ' oulteltbill(FormatNumber(NetAmounttobesettled, 2), bill)
                        clear()
                        loadmasterBillData()
                        TextEditDiscount.Text = ""


                        LoadGridMasterbill()

                    End If
                End If
            End If





        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub clear()
        If (Not dsPaid Is Nothing) Then
            dsPaid.Tables(0).Clear()
        End If

        If (Not dsUnPaid Is Nothing) Then
            dsUnPaid.Tables(0).Clear()
        End If
        TextEditServiceCharges.Text = ""
        TextEditDiscount.Text = ""
        TextEditPayMaster.Text = ""
        TextEditPayMethodNumberMater.Text = ""
        TextEditBankMaster.Text = ""
        TextEditUnPaid.Text = ""
        TextEditPaid.Text = ""
        TextEditTotal.Text = ""
        ComboBoxEditPayMethod.SelectedIndex = 0
    End Sub

    Private Function getdeparmentwise() As DataTable
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsDepartment As New DataSet
        Dim dcSearch As New SqlCommand
        Dim dt As New DataTable
        Dim Department As String = ""
        Dim Amount As Decimal = 0
        dt.Columns.Add("Department")
        dt.Columns.Add("Amount")
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT [DepartmentID]  ,[Department] ,[Description] FROM [DepartmentMaster]", Conn)
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsDepartment)
            If (Not dsDepartment Is Nothing) Then
                Dim intDepart As Integer = 0
                For intDepart = 0 To dsDepartment.Tables(0).Rows.Count - 1
                    Amount = 0

                    Dim foundRows() As DataRow = dsUnPaid.Tables(0).Select("Department ='" & dsDepartment.Tables(0).Rows(intDepart)("Department").ToString().Trim() & "'")
                    If (foundRows.Length > 0) Then
                        Dim foundcount As Integer = 0
                        For foundcount = 0 To foundRows.Length - 1
                            Amount = Amount + Decimal.Parse(foundRows(foundcount)("Amount"))
                        Next
                    End If
                    'Dim unpaidFoundRows() As DataRow = dsUnPaid.Tables(0).Select("Department ='" & dsDepartment.Tables(0).Rows(intDepart)("Department").ToString().Trim() & "'")
                    'If (unpaidFoundRows.Length > 0) Then
                    '    Dim unpaidFoundcount As Integer = 0
                    '    For unpaidFoundcount = 0 To foundRows.Length - 1
                    '        Amount = Amount + Decimal.Parse(foundRows(unpaidFoundcount)("Amount"))
                    '    Next
                    'End If

                    If (Amount > 0) Then
                        Dim dr As DataRow = dt.NewRow()
                        dr("Department") = dsDepartment.Tables(0).Rows(intDepart)("Department").ToString().Trim()
                        dr("Amount") = Amount
                        dt.Rows.Add(dr)
                    End If
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
        End Try

        getdeparmentwise = dt
    End Function
    Private Sub ComboBoxRoomNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxRoomNo.SelectedIndexChanged
        loadmasterBillData()


        GridControl2.DataSource = Nothing


        LoadBillSumDetails()



        ' loadServiceCharge()
    End Sub
    Private Sub LoadBillSumDetails()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getRoomno As String = ComboBoxRoomNo.Text.Trim

            Conn.Open()
            dcSearch = New SqlCommand("SELECT  d.Department,sum((o.[Total]-o.discountAmount)+o.tax + o.serviceCharge) as 'Amount',max(o.[ReservationNo]) as ReservationNO ,max(g.DepDate) AS DepartureDate,max(g.ArriveDate)as ArrivalDate,max (dbo.[Reservation.Master].Topcode) as TopCode,max(dbo.[Reservation.Master].MealPlan) as MealPlan FROM  dbo.OutLetBillMaster AS o INNER JOIN  dbo.KotBotMaster AS k ON k.Id = o.KOTBOTNo INNER JOIN dbo.GuestRegistration AS g ON g.ReservationNo = o.ReservationNo INNER JOIN  dbo.DepartmentMaster AS d ON k.Department = d.DepartmentID COLLATE SQL_Latin1_General_CP1_CI_AS INNER JOIN   dbo.[Room.CurrentStatus] AS c ON c.ReservationNo = o.ReservationNo INNER JOIN  dbo.[Reservation.Master] ON g.ReservationNo = dbo.[Reservation.Master].ResNo LEFT OUTER JOIN   dbo.PaymentType AS P ON P.PaymentTypeCode = o.PayType WHERE  (o.MasterBillGenerated = 0) AND (g.IsBillingGuest = 1) AND (o.RoomNo = @Roomno) AND (o.ReservationNo =(SELECT     ReservationNo  FROM   dbo.[Room.CurrentStatus]  WHERE  (RoomNo = @Roomno))) group by   d.Department ", Conn)
            dcSearch.Parameters.Add("@Roomno", SqlDbType.VarChar).Value = getRoomno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            GridControl2.DataSource = dsMain.Tables(0)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    'Private Sub loadServiceCharge()
    '    If (String.IsNullOrEmpty(TextEditUnPaid.Text)) Then
    '        TextEditUnPaid.Text = "0"
    '    End If
    '    Dim GrandTotaloftheInvoices As Double = Double.Parse(TextEditUnPaid.Text)
    '    Dim ServiceCharge As Double = GrandTotaloftheInvoices * 0.1
    '    TextEditServiceCharges.Text = FormatNumber(ServiceCharge, 2)

    'End Sub

    Private Sub loadmasterBillData()
        TextEditGuest.Text = ""
        LoadUserData(ComboBoxRoomNo.Text)
        If (String.IsNullOrEmpty(TextEditGuest.Text.Trim())) Then
            MsgBox("Master guest for this room is not define", MsgBoxStyle.Critical, "Error..")
        Else
            LoadPaid(ComboBoxRoomNo.Text)
        End If
    End Sub

    Private Sub DateSelect_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LoadPaid(ByVal RoomNo As String)
        Dim Conn As New SqlConnection(ConnString)

        dsPaid = New DataSet
        dsUnPaid = New DataSet

        Dim daApid As New SqlDataAdapter
        Dim daUnpid As New SqlDataAdapter

        Dim dcPaid As New SqlCommand
        Dim dcUnPaid As New SqlCommand
        Dim unPaidAmount As Double
        Dim serviceCharge As Double
        Dim totalUnPaidAmount As Double
        Dim totalUnPaidServiceChargeAmount As Double
        Dim paidAmount As Double
        Dim totalPaidAmount As Double
        Try
            Conn.Open()
            dcPaid = New SqlCommand("SELECT distinct '' as t, o.[BillNo] as 'Bill No' ,o.[KOTBOTNo] ,o.[MasterBillGenerated],o.[MasterBillNo] ,o.[Paid] ,o.[ReciptNo]  as Receipt,(o.[Total]-o.discountAmount) as 'Amount',o.[RoomNo],o.[ReservationNo] ,o.[Type],'guest' as guest,'' as 'sum','' as balance,'' as grandTot,p.[Description] as 'PayType', o.BillGeneratedDate, d.Department,''as 'GrandTotaloftheInvoices'  ,'' as 'ServiceCharge',''as 'Total',''as 'GSTTax'   ,''as 'GrandTotal' ,''as 'Discountgiven','' as Discount,''as 'AdvancePaid',''as 'NetAmounttobesettled' , g.DepDate,g.ArriveDate,'' opdetail,'' department1,'' departmenttot  FROM [OutLetBillMaster] o inner join dbo.KotBotMaster k on k.Id=o.KOTBOTNo inner join  dbo.GuestRegistration g  on g.ReservationNo =o.ReservationNo  inner join dbo.DepartmentMaster d on k.Department =d.DepartmentID Collate SQL_Latin1_General_CP1_CI_AS inner join [PaymentType] P on P.[PaymentTypeCode]=[PayType]  inner join dbo.[Room.CurrentStatus] c on  c.ReservationNo = o.ReservationNo where o.[Paid]=1 and o.[MasterBillGenerated]=0 and g.IsBillingGuest =1 and o.[RoomNo] ='" & RoomNo & "'", Conn)

            ' dcPaid = New SqlCommand("SELECT     '' AS t, o.BillNo AS 'Bill No', o.KOTBOTNo, o.MasterBillGenerated, o.MasterBillNo, o.Paid, o.ReciptNo AS Receipt, o.Total - o.discountAmount AS 'Amount', o.RoomNo, o.ReservationNo, o.Type, 'guest' AS guest, '' AS 'sum', '' AS balance, '' AS grandTot, P.Description AS 'PayType', o.BillGeneratedDate, d.Department, '' AS 'GrandTotaloftheInvoices', '' AS 'ServiceCharge', '' AS 'Total', '' AS 'GSTTax', '' AS 'GrandTotal', '' AS 'Discountgiven', '' AS Discount, '' AS 'AdvancePaid', '' AS 'NetAmounttobesettled', '' AS opdetail, '' AS department1, '' AS departmenttot FROM  dbo.OutLetBillMaster AS o INNER JOIN    dbo.KotBotMaster AS k ON k.Id = o.KOTBOTNo INNER JOIN  dbo.DepartmentMaster AS d ON k.Department = d.DepartmentID COLLATE SQL_Latin1_General_CP1_CI_AS INNER JOIN  dbo.PaymentType AS P ON P.PaymentTypeCode = o.PayType INNER JOIN   dbo.[Room.CurrentStatus] AS c ON c.ReservationNo = o.ReservationNo WHERE     (o.Paid = 1) AND (o.MasterBillGenerated = 0) AND o.RoomNo = '" & RoomNo & "'", Conn)

            daApid = New SqlDataAdapter()
            daApid.SelectCommand = dcPaid
            daApid.Fill(dsPaid)

            If (Not dsPaid Is Nothing) Then
                GridControlPaid.DataSource = dsPaid.Tables(0)
                dsPaid.Tables(0).TableName = "Paid"
                Dim I As Integer
                For I = 0 To dsPaid.Tables(0).Rows.Count - 1
                    paidAmount = Double.Parse(dsPaid.Tables(0).Rows(I)("Amount").ToString())
                    dsPaid.Tables(0).Rows(I)("guest") = TextEditGuest.Text
                    totalPaidAmount = totalPaidAmount + paidAmount
                Next
                TextEditPaid.Text = totalPaidAmount.ToString()
            End If
            Conn.Close()

            Conn.Open()
            ' dcUnPaid = New SqlCommand("SELECT distinct '' as t, o.[BillNo]  as 'Bill No' ,o.[KOTBOTNo] ,o.[MasterBillGenerated],o.[MasterBillNo] ,o.[Paid] ,o.[ReciptNo] as Receipt ,(o.[Total]-o.discountAmount) as 'Amount',o.[RoomNo],o.[ReservationNo] ,o.[Type],'guest' as guest,'sum' as 'sum','' as balance,'' as grandTot,isnull(p.[Description],'') as 'PayType',  o.BillGeneratedDate, d.Department,''as 'GrandTotaloftheInvoices'  ,'' as 'ServiceCharge',''as 'Total',''as 'GSTTax'   ,''as 'GrandTotal' ,''as 'Discountgiven','' as Discount ,''as 'AdvancePaid',''as 'NetAmounttobesettled' , g.DepDate,g.ArriveDate,'' opdetail,'' department1,'' departmenttot   FROM [OutLetBillMaster] o inner join dbo.KotBotMaster k on k.Id=o.KOTBOTNo inner join  dbo.GuestRegistration g  on g.ReservationNo =o.ReservationNo  inner join dbo.DepartmentMaster d on k.Department =d.DepartmentID Collate SQL_Latin1_General_CP1_CI_AS  inner join dbo.[Room.CurrentStatus] c on  c.ReservationNo = o.ReservationNo left join [PaymentType] P on P.[PaymentTypeCode]=[PayType] where o.[MasterBillGenerated]=0 and g.IsBillingGuest =1 and o.[RoomNo] ='" & RoomNo & "'", Conn)


            dcUnPaid = New SqlCommand("SELECT distinct '' as t, o.[BillNo]  as 'Bill No' ,o.[KOTBOTNo] ,o.[MasterBillGenerated],o.[MasterBillNo] ,o.[Paid] ,o.[ReciptNo] as Receipt ,(o.[Total]-o.discountAmount) as 'Amount',o.[RoomNo],o.[ReservationNo] ,o.[Type],'guest' as guest,'sum' as 'sum','' as balance,'' as grandTot,isnull(p.[Description],'') as 'PayType',  o.BillGeneratedDate, d.Department,''as 'GrandTotaloftheInvoices'  ,'' as 'ServiceCharge',''as 'Total',''as 'GSTTax'   ,''as 'GrandTotal' ,''as 'Discountgiven','' as Discount ,''as 'AdvancePaid',''as 'NetAmounttobesettled' , g.DepDate,g.ArriveDate,'' opdetail,'' department1,'' departmenttot ,o.OutletMasBill as OutMasNo  FROM [OutLetBillMaster] o inner join dbo.KotBotMaster k on k.Id=o.KOTBOTNo inner join  dbo.GuestRegistration g  on g.ReservationNo =o.ReservationNo  inner join dbo.DepartmentMaster d on k.Department =d.DepartmentID Collate SQL_Latin1_General_CP1_CI_AS  inner join dbo.[Room.CurrentStatus] c on  c.ReservationNo = o.ReservationNo left join [PaymentType] P on P.[PaymentTypeCode]=[PayType] where o.[MasterBillGenerated]=0 and g.IsBillingGuest =1 and o.[RoomNo] ='" & RoomNo & "' and o.ReservationNo = (select  ReservationNo from dbo.[Room.CurrentStatus] where RoomNo='" & RoomNo & "')", Conn)


            'dcUnPaid = New SqlCommand("SELECT     '' AS t, o.BillNo AS 'Bill No', o.KOTBOTNo, o.MasterBillGenerated, o.MasterBillNo, o.Paid, o.ReciptNo AS Receipt, o.Total - o.discountAmount AS 'Amount', o.RoomNo, o.ReservationNo, o.Type, 'guest' AS guest, 'sum' AS 'sum', '' AS balance, '' AS grandTot, ISNULL(P.Description, '') AS 'PayType', o.BillGeneratedDate, d.Department, '' AS 'GrandTotaloftheInvoices', '' AS 'ServiceCharge', '' AS 'Total', '' AS 'GSTTax', '' AS 'GrandTotal', '' AS 'Discountgiven', '' AS Discount, '' AS 'AdvancePaid',  '' AS 'NetAmounttobesettled', '' AS opdetail, '' AS department1, '' AS departmenttot FROM dbo.OutLetBillMaster AS o INNER JOIN  dbo.KotBotMaster AS k ON k.Id = o.KOTBOTNo INNER JOIN   dbo.DepartmentMaster AS d ON k.Department = d.DepartmentID COLLATE SQL_Latin1_General_CP1_CI_AS INNER JOIN   dbo.[Room.CurrentStatus] AS c ON c.ReservationNo = o.ReservationNo LEFT OUTER JOIN     dbo.PaymentType AS P ON P.PaymentTypeCode = o.PayType WHERE     (o.MasterBillGenerated = 0) AND o.RoomNo = '" & RoomNo & "'", Conn)

            daUnpid = New SqlDataAdapter()
            daUnpid.SelectCommand = dcUnPaid
            daUnpid.Fill(dsUnPaid)
            If (Not dsUnPaid Is Nothing) Then
                GridControUnPaidBill.DataSource = dsUnPaid.Tables(0)
                Dim I As Integer
                For I = 0 To dsUnPaid.Tables(0).Rows.Count - 1
                    unPaidAmount = Double.Parse(dsUnPaid.Tables(0).Rows(I)("Amount").ToString())
                    dsUnPaid.Tables(0).Rows(I)("guest") = TextEditGuest.Text
                    totalUnPaidAmount = totalUnPaidAmount + unPaidAmount


                    If (Not dsUnPaid.Tables(0).Rows(I)("Department").ToString().ToLower() = "divingschool") Then
                        If (Not dsUnPaid.Tables(0).Rows(I)("Department").ToString().ToLower() = "mishrapshop") Then
                            serviceCharge = Double.Parse(dsUnPaid.Tables(0).Rows(I)("Amount").ToString())
                            totalUnPaidServiceChargeAmount = totalUnPaidServiceChargeAmount + serviceCharge
                        End If
                    End If
                Next
                TextEditUnPaid.Text = totalUnPaidAmount.ToString()
                dsUnPaid.Tables(0).TableName = "dsUnPaid"
            End If
            Conn.Close()

            serviceCharge = totalUnPaidServiceChargeAmount * 0.1
            TextEditServiceCharges.Text = FormatNumber(serviceCharge, 2)

            Dim balance As Double = totalUnPaidAmount - totalPaidAmount
            If ((balance) > 0) Then
                TextEditTotal.Text = balance.ToString()
                btnCreateBilling.Enabled = False
                If (balance > 0) Then
                    btnCreateBilling.Enabled = False
                End If

                If (balance = 0) Then
                    btnCreateBilling.Enabled = True
                End If
            Else
                TextEditTotal.Text = "0"
                'Rashad Added
                btnCreateBilling.Enabled = True
            End If
            btnCreateBilling.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daApid.Dispose()
            daUnpid.Dispose()
        End Try
    End Sub

    'Private Sub LoadKOTBOTData(RoomNo As String)
    '    Dim Conn As New SqlConnection(ConnString)
    '    Dim dsKOTBOT As New DataSet
    '    Dim daMain As New SqlDataAdapter
    '    Dim dcSearch As New SqlCommand
    '    Try
    '        Conn.Open()
    '        dcSearch = New SqlCommand("SELECT k.[Id] as KOTBOTID,k.[Date] ,k.[RoomNo],g.GuestName ,k.[Type],k.[Department] FROM [KotBotMaster] k inner join [Guest.RegisterMaster] R on k.ReservationNo =R.ReservationNo inner join [Guest.Master] g  on g.GuestID =R.GuestId where k.Active=1 and k.BillGenerated =0 and k.RoomNo='" & RoomNo & "'", Conn)
    '        daMain = New SqlDataAdapter()
    '        daMain.SelectCommand = dcSearch
    '        daMain.Fill(dsKOTBOT)
    '        If (Not dsKOTBOT Is Nothing) Then
    '            GridControUnPaidBill.DataSource = dsKOTBOT.Tables(0)

    '            For i As Int16 = 0 To GridView1.RowCount - 1
    '                unboundData.Add(False)
    '            Next

    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
    '    Finally
    '        Conn.Dispose()
    '        daMain.Dispose()
    '    End Try
    'End Sub

    'Private Sub SimpleButtonCreateOutLetBilling_Click(sender As System.Object, e As System.EventArgs)
    '    Dim DataRowCount As Integer = GridView2.DataRowCount
    '    Try
    '        If (tabMain.SelectedTabPageIndex <> 2) Then
    '            tabMain.SelectedTabPageIndex = 2
    '        ElseIf (tabMain.SelectedTabPageIndex = 2) Then
    '            Dim cnumberPart As String = ""
    '            Dim ConnStr As String = ConnString
    '            Dim Conn As New SqlConnection(ConnStr)
    '            Dim dcInsertNewAcc As New SqlCommand
    '            Dim dcInsertNewAccDetail As New SqlCommand
    '            Dim dateVal As DateTime = Convert.ToDateTime(dtDate.Text)
    '            Dim intNo As Integer = getNewBillNO() ' getNewKotBotNO()
    '            intNo = intNo + 1
    '            cnumberPart = intNo.ToString()

    '            Dim autoid As String = "BO" & dateVal.Year.ToString().Trim() & dateVal.Month.ToString().Trim() & dateVal.Day.ToString().Trim() & cnumberPart
    '            Dim I As Integer
    '            For I = 0 To DataRowCount - 1
    '                Dim s As String = GridView2.GetRowCellValue(I, "GridColumn12")
    '                If (Boolean.Parse(s) = True) Then
    '                    '               If GridView2.GetDataRow(I) Then
    '                    ' If GridView2.IsRowSelected(I) Then
    '                    Conn.Open()
    '                    Dim KOTBOTID As String = GridView2.GetRowCellValue(I, "KOTBOTID")
    '                    dcInsertNewAccDetail = New SqlCommand("genarate_OutLetBill_SP", Conn)
    '                    dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
    '                    dcInsertNewAccDetail.Parameters.Add("KOTBOTID ", SqlDbType.VarChar).Value = KOTBOTID
    '                    dcInsertNewAccDetail.Parameters.Add("billNo", SqlDbType.VarChar).Value = autoid
    '                    dcInsertNewAccDetail.ExecuteNonQuery()
    '                    Conn.Close()
    '                End If
    '                ' End If
    '            Next

    '            Dim sqlBillHeader As String = "  SELECT B.[BillNo] as id ,B.[BillGeneratedDate] as Date ,B.[RoomNo],B.[ReservationNo],B.[Type],'Department' as 'Department',g.GuestName as 'GuestName'  FROM [OutLetBillMaster] B inner join [Guest.RegisterMaster] R ON R.ReservationNo  = B.ReservationNo  inner join [Guest.Master] g on g.GuestID=R.GuestId  WHERE [BillNo]='" & autoid & "'"
    '            Dim sqlBillDetail As String = " SELECT [BillNo] as KotBotId, [ItemCode],[ItemName],[Qty],[UnitPrice] FROM [BillDetail] where BillNo = '" & autoid & "'"
    '            Dim dtBillHeader As DataTable = GetDataForSQL(sqlBillHeader)
    '            Dim dtBillDetail As DataTable = GetDataForSQL(sqlBillDetail)

    '            dtBillHeader.TableName = "KotBotMaster"
    '            dtBillDetail.TableName = "KotBotDetails"

    '            Dim rmsDbDataSet As New DataSet
    '            rmsDbDataSet.Tables.Add(dtBillHeader.Copy())
    '            rmsDbDataSet.Tables.Add(dtBillDetail.Copy())
    '            ShowReportView(New Kot_Bot_Bill, rmsDbDataSet)
    '            LoadKOTBOTDataOutLet(ComboDept.Text)
    '            loadKotDataGrid()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
    '    Finally
    '        ' Conn.Dispose()
    '        ' daMain.Dispose()
    '        '  dsMain.Dispose()
    '    End Try

    'End Sub

    Private Sub tabMain_TabIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabMain.TabIndexChanged
        'If (tabMain.SelectedTabPageIndex = 2) Then
        '    LoadDepartmentsForOutLetBill()
        '  End If
        If (tabMain.SelectedTabPageIndex = 0) Then
            ComboRoom.Focus()
        End If
        If (tabMain.SelectedTabPageIndex = 1) Then
            ComboBoxRoomNo.Focus()
        End If
    End Sub


    'Private Sub LoadDepartmentsForOutLetBill()

    '    Dim Conn As New SqlConnection(ConnString)
    '    Dim daMain As New SqlDataAdapter
    '    '   Dim dsDepartments As New DataSet
    '    Dim dcSearch As New SqlCommand
    '    Try
    '        Conn.Open()
    '        dcSearch = New SqlCommand("SELECT [DepartmentID],[Description] FROM [DepartmentMaster] order by DepartmentID", Conn)

    '        daMain = New SqlDataAdapter()
    '        daMain.SelectCommand = dcSearch
    '        daMain.Fill(dsDepartmentsOutLet)

    '        Dim Dscount As Integer = dsDepartments.Tables(0).Rows.Count
    '        Dim DscountTest As Integer

    '        While (DscountTest < Dscount)
    '            ComboDept.Properties.Items.Add(dsDepartments.Tables(0).Rows(DscountTest)(0).ToString())
    '            DscountTest = DscountTest + 1
    '        End While
    '        ComboDept.SelectedIndex = 0

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
    '    Finally
    '        Conn.Dispose()
    '        daMain.Dispose()
    '        '  dsMain.Dispose()
    '    End Try
    'End Sub

    'Private Sub ComboDept_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
    '    txtOutletName.Text = ""
    '    LoadDepartment(ComboDept.Text, 2)
    '    LoadKOTBOTDataOutLet(ComboDept.Text)
    'End Sub

    'Private Sub LoadKOTBOTDataOutLet(department As String)
    '    Dim Conn As New SqlConnection(ConnString)
    '    Dim dsKOTBOT As New DataSet
    '    Dim daMain As New SqlDataAdapter
    '    Dim dcSearch As New SqlCommand
    '    Try
    '        Conn.Open()
    '        dcSearch = New SqlCommand("SELECT k.[Id] as KOTBOTID,k.[Date] ,k.[RoomNo],g.GuestName ,k.[Type],k.[Department] FROM [KotBotMaster] k inner join [Guest.RegisterMaster] R on k.ReservationNo =R.ReservationNo inner join [Guest.Master] g  on g.GuestID =R.GuestId where k.Active=1 and k.BillGenerated =0 and k.Department='" & department & "'", Conn)
    '        daMain = New SqlDataAdapter()
    '        daMain.SelectCommand = dcSearch
    '        daMain.Fill(dsKOTBOT)
    '        If (Not dsKOTBOT Is Nothing) Then
    '            GridControlOutLetBill.DataSource = dsKOTBOT.Tables(0)

    '            For i As Int16 = 0 To GridView2.RowCount - 1
    '                unboundData.Add(False)
    '            Next
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
    '    Finally
    '        Conn.Dispose()
    '        daMain.Dispose()
    '        '  dsMain.Dispose()
    '    End Try
    'End Sub

    Private Sub GridView1_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData
        'If (e.Column.FieldName = "GridColumn20") Then
        '    If (unboundData.Count > e.ListSourceRowIndex) Then 
        '    If (e.IsGetData = True) Then
        '        e.Value = unboundData(e.ListSourceRowIndex)
        '    Else
        '        unboundData(e.ListSourceRowIndex) = e.Value
        '        End If
        '    End If

        'End If

    End Sub

    '------------------------------***********************Print****************************************

    Private Sub PrintMasInv()


        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String






        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from TempMasBillNewFormat", Conn)

            ' dcIns.Parameters.Add("@Mbill", SqlDbType.VarChar).Value = GetPassMbilno

            'Dim CrDbno As String = txtcndn.Text.Trim

            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtcndn.Text) & "'"

            fltString = ""
            'fltString = "{rpt_dbcr_note_view.CrDbNo}='" & Trim(txtcndn.Text) & "'"




            ReportName = "MasBillPrintRash.rpt"
            rptTitle = "Master Bill"







            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            'frmReportViewer.paraRepName = "TestPara"
            'frmReportViewer.paraRepVale = DtToday.Text.ToString

            'frmReportViewer.paraRepName2 = "TestPara2"
            'frmReportViewer.paraRepVale2 = DtToday.Text.ToString


            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub
    Private Sub PrintMbillPreview()


        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String






        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from MasBillPreview", Conn)

            ' dcIns.Parameters.Add("@Mbill", SqlDbType.VarChar).Value = GetPassMbilno

            'Dim CrDbno As String = txtcndn.Text.Trim

            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtcndn.Text) & "'"

            fltString = ""
            'fltString = "{rpt_dbcr_note_view.CrDbNo}='" & Trim(txtcndn.Text) & "'"




            ReportName = "MasBillPrintPreview.rpt"
            rptTitle = "Master Bill Preview"







            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            'frmReportViewer.paraRepName = "TestPara"
            'frmReportViewer.paraRepVale = DtToday.Text.ToString

            'frmReportViewer.paraRepName2 = "TestPara2"
            'frmReportViewer.paraRepVale2 = DtToday.Text.ToString


            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub InsertTempMasBill(ByVal passMbilno As String)

        Dim GetPassMbilno As String = passMbilno

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InsertMasBillNewFormat_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        
        dcInsertNewAcc.Parameters.Add("@MasBillno", SqlDbType.VarChar).Value = GetPassMbilno

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()




    End Sub
    Private Sub InsertTempMasBillWeekly(ByVal passMbilno As String)

        Dim GetPassMbilno As String = passMbilno

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InsertMasBillNewFormat_WeeklyBill_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@MasBillno", SqlDbType.VarChar).Value = GetPassMbilno

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()




    End Sub
    Private Sub InsertTempMasBillPreview(ByVal passroomno As String, ByVal passresno As String, ByVal passuser As String)

        Dim GetPassRoomno As String = passroomno
        Dim GetPassResno As String = passresno
        Dim GetPassUser As String = passuser

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("MasBillPreview_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@Roomno", SqlDbType.VarChar).Value = GetPassRoomno
        dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = GetPassResno
        dcInsertNewAcc.Parameters.Add("@Previewby", SqlDbType.VarChar).Value = GetPassUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()




    End Sub
    Private Sub LoadFinalMasBillAmount(ByVal passMasBillno As String)
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand



        Dim daMain2 As New SqlDataAdapter
        Dim dsMain2 As New DataSet
        Dim dcSearch2 As New SqlCommand


        Try
            Conn.Open()


            Dim getpassMasBillno As String = passMasBillno

            dcSearch2 = New SqlCommand("select sum (Total) as Total from OutLetBillMaster where masterbillno=@MasBNo and Paid=1", Conn)
            dcSearch2.Parameters.Add("@MasBNo", SqlDbType.VarChar).Value = getpassMasBillno
            daMain2 = New SqlDataAdapter()
            daMain2.SelectCommand = dcSearch2
            daMain2.Fill(dsMain2)

            Dim PaidAmount As Decimal = Convert.ToDecimal(IIf(IsDBNull(dsMain2.Tables(0).Rows(0).Item("Total")), 0, dsMain2.Tables(0).Rows(0).Item("Total")))





            'dcSearch = New SqlCommand("select ((sum(Total) + sum(tax+serviceCharge) )- sum (discountAmount)) - (select sum (Total) from OutLetBillMaster where masterbillno=@MasBNo and Paid=1) from OutLetBillMaster where masterbillno=@MasBNo", Conn)
            dcSearch = New SqlCommand("select ((sum(Total) + sum(tax+serviceCharge) )- sum (discountAmount)) from OutLetBillMaster where masterbillno=@MasBNo", Conn)
            dcSearch.Parameters.Add("@MasBNo", SqlDbType.VarChar).Value = getpassMasBillno
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            PubFinalMasterAmount = (Convert.ToDecimal(dsMain.Tables(0).Rows(0)(0).ToString)) - PaidAmount

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    'Function UpdateMasBillTbl(ByVal passMasBillno As String, ByVal passFinalAmt As Decimal) As Boolean
    '    Dim Conn As New SqlConnection(modMain.ConnString)


    '    Dim getpassMasBillno As String = passMasBillno
    '    Dim getpassFinalAmt As Decimal = passFinalAmt

    '    Dim dcExec As New SqlCommand(String.Format("update billmaster set Total = @MasBAmt where BillNo=@MasBNo", Conn))

    '    dcExec.Parameters.Add("@MasBNo", SqlDbType.VarChar).Value = getpassMasBillno
    '    dcExec.Parameters.Add("@MasBAmt", SqlDbType.Decimal).Value = getpassFinalAmt


    '    Try
    '        Conn.Open()

    '        dcExec.ExecuteNonQuery()

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
    '        Return 0
    '    Finally
    '        Conn.Dispose()
    '        dcExec.Dispose()
    '    End Try
    'End Function

    Private Sub UpdateMasBillTbl(ByVal passMasBillno As String, ByVal passFinalAmt As Decimal)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Dim getpassMasBillno As String = passMasBillno
        Dim getpassFinalAmt As Decimal = passFinalAmt


        dcInsertNewAcc = New SqlCommand("update billmaster set Total = @MasBAmt where BillNo=@MasBNo", Conn) With {.CommandType = CommandType.Text}

        dcInsertNewAcc.Parameters.Add("@MasBNo", SqlDbType.VarChar).Value = getpassMasBillno
        dcInsertNewAcc.Parameters.Add("@MasBAmt", SqlDbType.Decimal).Value = getpassFinalAmt

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub

    Private Sub CancelBill()

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand


            dcInsertNewAcc = New SqlCommand("InsertBillCancellationLogs_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@CancelBy", SqlDbType.VarChar).Value = CurrUser
            dcInsertNewAcc.Parameters.Add("@BillNo", SqlDbType.VarChar).Value = PubBillNoCancel



            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Selected Bill Cancelled Successfully", "Cancel Bill", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub







    '-----------------------------*******************************End***************************************




    Private Sub ComboBoxPayMethod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxPayMethod.SelectedIndexChanged
        Try
            Dim PayMethod As String = ComboBoxPayMethod.Text
            LabelControlPayMethod.Text = ""
            If (Not PayMethod Is Nothing) Then
                Dim dataRowList() As DataRow
                dataRowList = dsPayMethod.Tables(0).Select(String.Format("PaymentTypeCode ='{0}'", PayMethod))
                If (Not dataRowList Is Nothing) Then
                    If (dataRowList.Length > 0) Then
                        TextEditPay.Text = dataRowList(0)("Description").ToString()
                        If (dataRowList(0)("NumberRequired").ToString().ToLower() = "true") Then
                            TextEditPayMethodNumber.Enabled = True
                            LabelControlPayMethod.Text = dataRowList(0)("Description").ToString() + " No."
                        Else
                            TextEditPayMethodNumber.Enabled = False
                            LabelControlPayMethod.Text = ""
                        End If

                        If (dataRowList(0)("BankRequired").ToString().ToLower() = "true") Then
                            TextEditBank.Enabled = True
                        Else
                            TextEditBank.Enabled = False
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        End Try
    End Sub

    Private Function getPaymethod(ByVal number As String, ByVal append As Boolean) As String
        Try
            Dim PayMethod As String = ComboBoxPayMethod.Text
            LabelControlPayMethod.Text = ""
            If (Not PayMethod Is Nothing) Then
                Dim dataRowList() As DataRow
                dataRowList = dsPayMethod.Tables(0).Select(String.Format("PaymentTypeCode ='{0}'", PayMethod))
                If (Not dataRowList Is Nothing) Then
                    If (dataRowList.Length > 0) Then
                        If (dataRowList(0)("NumberRequired").ToString().ToLower() = "true") Then
                            If (append = True) Then
                                getPaymethod = dataRowList(0)("Description").ToString() & "No: " & number
                            Else
                                getPaymethod = dataRowList(0)("Description").ToString()
                            End If
                        Else
                            getPaymethod = ""
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Function

    Private Function getPayTypeDescription(ByVal number As String) As String
        Try
            Dim PayMethod As String = ComboBoxPayMethod.Text
            LabelControlPayMethod.Text = ""
            If (Not PayMethod Is Nothing) Then
                Dim dataRowList() As DataRow
                dataRowList = dsPayMethod.Tables(0).Select(String.Format("PaymentTypeCode ='{0}'", PayMethod))
                If (Not dataRowList Is Nothing) Then
                    If (dataRowList.Length > 0) Then

                        getPayTypeDescription = dataRowList(0)("Description").ToString()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Function

    Private Sub ComboRoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboRoom.SelectedIndexChanged
        If (validUser(ComboRoom.Text)) Then
            loadPaydata()
        Else
            MessageBox.Show("Guest is block or Master guest for this room is not define. please contact administration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function validUser(ByVal RoomNo As String) As Boolean
        'Throw New NotImplementedException
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsGuest As New DataSet
        Dim guest As String = ""
        Dim isValid As Boolean = False
        Dim block As String = ""
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select isnull(c.IsBillBlock,1) as IsBillBlock,c.BillingGuest from [Room.CurrentStatus] c where c.RoomNo='" & RoomNo & "'", Conn)
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsGuest)
            If (Not dsGuest Is Nothing) Then
                If (dsGuest.Tables(0).Rows.Count > 0) Then
                    If (IsDBNull(dsGuest.Tables(0).Rows(0)("BillingGuest"))) Then
                        guest = ""
                    Else
                        guest = dsGuest.Tables(0).Rows(0)("BillingGuest")
                    End If

                    If (IsDBNull(dsGuest.Tables(0).Rows(0)("IsBillBlock"))) Then
                        block = "1"
                    Else
                        block = dsGuest.Tables(0).Rows(0)("IsBillBlock")
                    End If

                    If Not String.IsNullOrEmpty(guest) Then
                        If block = "False" Then
                            validUser = True ' MessageBox.Show("Guest is block. please contact administration.")
                        Else
                            validUser = False
                        End If
                    Else
                        validUser = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
        End Try
    End Function
    Private Sub loadPaydata()
        Dim Conn As New SqlConnection(ConnString)
        Dim dsKOTBOT As New DataSet
        Dim daMain As New SqlDataAdapter
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            ' dcSearch = New SqlCommand("SELECT OB.[BillNo] as 'Bill No',convert(VARCHAR(10), k.Date, 111) as 'KOTBOT Date',OB.[KOTBOTNo] as 'KOTBOT No',OB.[Total],OB.[RoomNo] as 'Room No',g.[GuestName] as 'Guest Name',d.[Description] AS 'Department' FROM [OutLetBillMaster] OB inner join [Guest.RegisterMaster] R on ob.ReservationNo =R.ReservationNo  inner join [Guest.Master] g  on g.GuestID =R.GuestId  inner join [KotBotMaster] k  on k.Id = OB.KOTBOTNo   inner join [DepartmentMaster] d on k.Department = d.DepartmentID Collate SQL_Latin1_General_CP1_CI_AS  where ob.Paid =0 and  OB.[RoomNo] ='" & ComboRoom.Text & "'", Conn)
            ' dcSearch = New SqlCommand("SELECT dbo.OutLetBillMaster.BillNo AS 'Bill No', CONVERT(VARCHAR(10), dbo.KotBotMaster.Date, 111) AS 'KOTBOT Date', dbo.OutLetBillMaster.KOTBOTNo AS 'KOTBOT No',dbo.OutLetBillMaster.Total, dbo.OutLetBillMaster.RoomNo AS 'Room No', dbo.GuestRegistration.FullName AS 'Guest Name',dbo.DepartmentMaster.Description AS 'Department' FROM dbo.OutLetBillMaster INNER JOIN dbo.KotBotMaster ON dbo.OutLetBillMaster.KOTBOTNo = dbo.KotBotMaster.Id INNER JOIN dbo.DepartmentMaster ON dbo.KotBotMaster.Department = dbo.DepartmentMaster.DepartmentID INNER JOIN dbo.GuestRegistration ON dbo.OutLetBillMaster.ReservationNo = dbo.GuestRegistration.ReservationNo and  dbo.OutLetBillMaster.[RoomNo] ='" & ComboRoom.Text & "'", Conn)
            ' dcSearch = New SqlCommand("SELECT dbo.OutLetBillMaster.BillNo AS 'Bill No', CONVERT(VARCHAR(10), dbo.KotBotMaster.Date, 111) AS 'KOTBOT Date', dbo.OutLetBillMaster.KOTBOTNo AS 'KOTBOT No', (dbo.OutLetBillMaster.Total-dbo.OutLetBillMaster.discountAmount) as Total, dbo.OutLetBillMaster.RoomNo AS 'Room No',   dbo.[Room.CurrentStatus].BillingGuest AS 'Guest Name',dbo.DepartmentMaster.Description AS 'Department' FROM dbo.OutLetBillMaster INNER JOIN dbo.KotBotMaster ON dbo.OutLetBillMaster.KOTBOTNo = dbo.KotBotMaster.Id INNER JOIN dbo.DepartmentMaster ON dbo.KotBotMaster.Department = dbo.DepartmentMaster.DepartmentID INNER JOIN dbo.[Room.CurrentStatus] ON dbo.OutLetBillMaster.ReservationNo = dbo.[Room.CurrentStatus].ReservationNo and  dbo.OutLetBillMaster.[RoomNo] ='" & ComboRoom.Text & "' AND  dbo.OutLetBillMaster.[Paid]=0 ", Conn)



            'dcSearch = New SqlCommand("SELECT   dbo.OutLetBillMaster.BillNo AS 'Bill No', CONVERT(VARCHAR(10), dbo.KotBotMaster.Date, 111) AS 'KOTBOT Date', dbo.OutLetBillMaster.KOTBOTNo AS 'KOTBOT No', dbo.OutLetBillMaster.Total - dbo.OutLetBillMaster.discountAmount AS Expr1, dbo.OutLetBillMaster.RoomNo AS 'Room No',dbo.[Room.CurrentStatus].BillingGuest AS 'Guest Name', dbo.DepartmentMaster.Description FROM  dbo.OutLetBillMaster INNER JOIN  dbo.KotBotMaster ON dbo.OutLetBillMaster.KOTBOTNo = dbo.KotBotMaster.Id INNER JOIN   dbo.DepartmentMaster ON dbo.KotBotMaster.Department = dbo.DepartmentMaster.DepartmentID INNER JOIN   dbo.[Room.CurrentStatus] ON dbo.OutLetBillMaster.RoomNo = dbo.[Room.CurrentStatus].RoomNo WHERE  dbo.OutLetBillMaster.RoomNo  ='" & ComboRoom.Text & "' AND dbo.OutLetBillMaster.Paid = 0", Conn)

            dcSearch = New SqlCommand("SELECT   dbo.OutLetBillMaster.BillNo AS 'Bill No', CONVERT(VARCHAR(10), dbo.KotBotMaster.Date, 111) AS 'KOTBOT Date', dbo.OutLetBillMaster.KOTBOTNo AS 'KOTBOT No', dbo.OutLetBillMaster.Total - dbo.OutLetBillMaster.discountAmount AS Total, dbo.OutLetBillMaster.RoomNo AS 'Room No',dbo.[Room.CurrentStatus].BillingGuest AS 'Guest Name', dbo.DepartmentMaster.Description as Department FROM  dbo.OutLetBillMaster INNER JOIN  dbo.KotBotMaster ON dbo.OutLetBillMaster.KOTBOTNo = dbo.KotBotMaster.Id INNER JOIN   dbo.DepartmentMaster ON dbo.KotBotMaster.Department = dbo.DepartmentMaster.DepartmentID INNER JOIN   dbo.[Room.CurrentStatus] ON dbo.OutLetBillMaster.RoomNo = dbo.[Room.CurrentStatus].RoomNo WHERE  dbo.OutLetBillMaster.MasterBillNo = '' and dbo.OutLetBillMaster.RoomNo  ='" & ComboRoom.Text & "' AND dbo.OutLetBillMaster.Paid = 0 and (dbo.OutLetBillMaster.ReservationNo= (select ReservationNo from [Room.CurrentStatus] where RoomNo='" & ComboRoom.Text & "'))", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsKOTBOT)

            If (Not dsKOTBOT Is Nothing) Then
                GridControl1.DataSource = dsKOTBOT.Tables(0)
            End If
            GridControl1.Refresh()
            For i As Int16 = 0 To GridView3.RowCount - 1
                unboundDataOutLetBill.Add(False)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            '  dsMain.Dispose()
        End Try
    End Sub
    Private Sub loadPaydataStaff()
        Dim Conn As New SqlConnection(ConnString)
        Dim dsKOTBOT As New DataSet
        Dim daMain As New SqlDataAdapter
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            ' dcSearch = New SqlCommand("SELECT OB.[BillNo] as 'Bill No',convert(VARCHAR(10), k.Date, 111) as 'KOTBOT Date',OB.[KOTBOTNo] as 'KOTBOT No',OB.[Total],OB.[RoomNo] as 'Room No',g.[GuestName] as 'Guest Name',d.[Description] AS 'Department' FROM [OutLetBillMaster] OB inner join [Guest.RegisterMaster] R on ob.ReservationNo =R.ReservationNo  inner join [Guest.Master] g  on g.GuestID =R.GuestId  inner join [KotBotMaster] k  on k.Id = OB.KOTBOTNo   inner join [DepartmentMaster] d on k.Department = d.DepartmentID Collate SQL_Latin1_General_CP1_CI_AS  where ob.Paid =0 and  OB.[RoomNo] ='" & ComboRoom.Text & "'", Conn)
            ' dcSearch = New SqlCommand("SELECT dbo.OutLetBillMaster.BillNo AS 'Bill No', CONVERT(VARCHAR(10), dbo.KotBotMaster.Date, 111) AS 'KOTBOT Date', dbo.OutLetBillMaster.KOTBOTNo AS 'KOTBOT No',dbo.OutLetBillMaster.Total, dbo.OutLetBillMaster.RoomNo AS 'Room No', dbo.GuestRegistration.FullName AS 'Guest Name',dbo.DepartmentMaster.Description AS 'Department' FROM dbo.OutLetBillMaster INNER JOIN dbo.KotBotMaster ON dbo.OutLetBillMaster.KOTBOTNo = dbo.KotBotMaster.Id INNER JOIN dbo.DepartmentMaster ON dbo.KotBotMaster.Department = dbo.DepartmentMaster.DepartmentID INNER JOIN dbo.GuestRegistration ON dbo.OutLetBillMaster.ReservationNo = dbo.GuestRegistration.ReservationNo and  dbo.OutLetBillMaster.[RoomNo] ='" & ComboRoom.Text & "'", Conn)
            dcSearch = New SqlCommand("SELECT dbo.OutLetBillMaster.BillNo AS 'Bill No', CONVERT(VARCHAR(10), dbo.KotBotMaster.Date, 111) AS 'KOTBOT Date', dbo.OutLetBillMaster.KOTBOTNo AS 'KOTBOT No', (dbo.OutLetBillMaster.Total-dbo.OutLetBillMaster.discountAmount) as Total, dbo.OutLetBillMaster.RoomNo AS 'Room No', dbo.OutLetBillMaster.ReservationNo    AS 'Guest Name',dbo.DepartmentMaster.Description AS 'Department' FROM dbo.OutLetBillMaster INNER JOIN dbo.KotBotMaster ON dbo.OutLetBillMaster.KOTBOTNo = dbo.KotBotMaster.Id INNER JOIN dbo.DepartmentMaster ON dbo.KotBotMaster.Department = dbo.DepartmentMaster.DepartmentID  AND  dbo.OutLetBillMaster.[Paid]=0  and dbo.OutLetBillMaster.Type='BCOM'", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsKOTBOT)

            If (Not dsKOTBOT Is Nothing) Then
                GridControl1.DataSource = dsKOTBOT.Tables(0)
            End If
            GridControl1.Refresh()
            For i As Int16 = 0 To GridView3.RowCount - 1
                unboundDataOutLetBill.Add(False)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            '  dsMain.Dispose()
        End Try
    End Sub

    Private Function getsellingRate(ByVal currenyCode As String) As Decimal
        Dim rate As Decimal = 1
        Dim j As Integer
        For j = 0 To dsCurrency.Tables(0).Rows.Count - 1
            If (dsCurrency.Tables(0).Rows(j)("RepCurrencyCode").ToString().Trim() = currenyCode.Trim()) Then
                rate = Decimal.Parse(dsCurrency.Tables(0).Rows(j)("SellingRate").ToString().Trim())
            End If
        Next
        getsellingRate = rate
    End Function

    Private Sub SimpleButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButtonSave.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Master billing", "PayBill")

        Dim CheckAccess2 As Boolean = UserPermission(CurrUser, "Payments", "PayBill")


        If CheckAccess = True Or CheckAccess2 = True Then

            Dim Conn As New SqlConnection
            Dim OutLetBillRecipet As New DataTable
            OutLetBillRecipet.TableName = "OutLetBillRecipet"
            OutLetBillRecipet.Columns.Add("BillNo")
            OutLetBillRecipet.Columns.Add("Date")
            OutLetBillRecipet.Columns.Add("RoomNo")
            OutLetBillRecipet.Columns.Add("ReceiptNo")
            OutLetBillRecipet.Columns.Add("PayMethod")
            OutLetBillRecipet.Columns.Add("amount", System.Type.GetType("System.Double"))
            OutLetBillRecipet.Columns.Add("GuestName")
            OutLetBillRecipet.Columns.Add("PayMethodNo")
            OutLetBillRecipet.Columns.Add("Currency")


            Dim dsOutLetBillRecipet As New DataSet
            Dim dcInsertNewAccDetail As New SqlCommand
            Try
                If (tabMain.SelectedTabPageIndex <> 0) Then
                    tabMain.SelectedTabPageIndex = 0
                ElseIf (tabMain.SelectedTabPageIndex = 0) Then
                    If (String.IsNullOrEmpty(ComboBoxPayMethod.Text.Trim())) Then
                        MsgBox("Please Select a payment method", MsgBoxStyle.Critical, ErrTitle)
                        ComboBoxPayMethod.Focus()
                    Else
                        Dim reciptNo As String = String.Empty
                        Dim PayType As String = ComboBoxPayMethod.Text.Trim()
                        Dim DataRowCount As Integer = GridView3.DataRowCount

                        Dim selected As Boolean = False
                        Dim j As Integer
                        For j = 0 To DataRowCount - 1
                            Dim s As String = GridView3.GetRowCellValue(j, "GridColumn24")
                            If (Boolean.Parse(s) = True) Then
                                selected = True
                            End If
                        Next

                        Dim PayMethod As String = ComboBoxPayMethod.Text
                        Dim NumberRequired As Boolean = False
                        Dim BankRequired As Boolean = False

                        If (Not PayMethod Is Nothing) Then
                            Dim dataRowList() As DataRow
                            dataRowList = dsPayMethod.Tables(0).Select(String.Format("PaymentTypeCode ='{0}'", PayMethod))
                            If (Not dataRowList Is Nothing) Then
                                If (dataRowList.Length > 0) Then
                                    If (dataRowList(0)("NumberRequired").ToString().ToLower() = "true") Then
                                        NumberRequired = True
                                    End If
                                End If
                            End If
                            If (Not dataRowList Is Nothing) Then
                                If (dataRowList.Length > 0) Then
                                    If (dataRowList(0)("BankRequired").ToString().ToLower() = "true") Then
                                        BankRequired = True
                                    End If
                                End If
                            End If
                        End If

                        Dim proceed As Boolean = False
                        If (BankRequired = True) Then
                            If (String.IsNullOrEmpty(TextEditBank.Text)) Then
                                MsgBox("Please Fill Payment Details", MsgBoxStyle.Critical, "Error.")
                                proceed = False
                            Else
                                proceed = True
                            End If
                        Else
                            proceed = True
                        End If

                        If (proceed = True) Then
                            If (NumberRequired = True) Then
                                If (String.IsNullOrEmpty(TextEditPayMethodNumber.Text)) Then
                                    MsgBox("Please select " & LabelControlPayMethod.Text, MsgBoxStyle.Critical, "Error.")
                                Else
                                    If (selected = True) Then
                                        Conn = New SqlConnection(ConnString)
                                        Dim I As Integer
                                        For I = 0 To DataRowCount - 1
                                            Dim s As String = GridView3.GetRowCellValue(I, "GridColumn24")
                                            If (Boolean.Parse(s) = True) Then
                                                Conn.Open()
                                                Dim drDetail As DataRow = OutLetBillRecipet.NewRow()
                                                Dim OutLetBillNo As String = GridView3.GetRowCellValue(I, "Bill No")
                                                '  dcInsertNewAccDetail = New SqlCommand("OutLet_Bill_Pay_SP", Conn)

                                                dcInsertNewAccDetail = New SqlCommand("OutLet_Bill_Pay_SP_Bill", Conn)

                                                dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
                                                reciptNo = "REC-" & OutLetBillNo
                                                dcInsertNewAccDetail.Parameters.Add("billNo", SqlDbType.VarChar).Value = OutLetBillNo
                                                dcInsertNewAccDetail.Parameters.Add("reciptNo", SqlDbType.VarChar).Value = reciptNo
                                                dcInsertNewAccDetail.Parameters.Add("payType", SqlDbType.VarChar).Value = PayType
                                                dcInsertNewAccDetail.Parameters.Add("Amount", SqlDbType.Float).Value = GridView3.GetRowCellValue(I, "Total")
                                                dcInsertNewAccDetail.Parameters.Add("ChqORCreditCardNumber", SqlDbType.VarChar).Value = TextEditPayMethodNumber.Text
                                                dcInsertNewAccDetail.Parameters.Add("CurrencyCode", SqlDbType.VarChar).Value = ComboBoxEditCurrency.Text
                                                dcInsertNewAccDetail.Parameters.Add("SellingRate", SqlDbType.Decimal).Value = getsellingRate(ComboBoxEditCurrency.Text)
                                                dcInsertNewAccDetail.Parameters.Add("Type", SqlDbType.VarChar).Value = "Out Let Bill"
                                                dcInsertNewAccDetail.Parameters.Add("Bank", SqlDbType.VarChar).Value = TextEditBank.Text
                                                dcInsertNewAccDetail.ExecuteNonQuery()
                                                Conn.Close()

                                                drDetail("BillNo") = OutLetBillNo
                                                drDetail("Date") = GridView3.GetRowCellValue(I, "KOTBOT Date")
                                                drDetail("RoomNo") = GridView3.GetRowCellValue(I, "Room No")
                                                drDetail("ReceiptNo") = reciptNo
                                                drDetail("PayMethod") = getPayTypeDescription(PayType) + " Receipt "
                                                drDetail("amount") = GridView3.GetRowCellValue(I, "Total")
                                                drDetail("GuestName") = GridView3.GetRowCellValue(I, "Guest Name")
                                                drDetail("PayMethodNo") = getPaymethod(TextEditPayMethodNumber.Text, True)
                                                drDetail("Currency") = ComboBoxEditCurrency.Text
                                                OutLetBillRecipet.Rows.Add(drDetail)
                                            End If
                                        Next
                                        dsOutLetBillRecipet.Tables.Clear()
                                        dsOutLetBillRecipet.Tables.Add(OutLetBillRecipet)
                                        loadPaydata()
                                        loadmasterBillData()
                                        ShowReportView(New Receipt, dsOutLetBillRecipet)
                                    Else
                                        MsgBox("Please Select Bills to Pay.", MsgBoxStyle.Critical, "Error")
                                    End If
                                End If
                            Else
                                If (selected = True) Then
                                    Conn = New SqlConnection(ConnString)
                                    Dim I As Integer
                                    For I = 0 To DataRowCount - 1
                                        Dim s As String = GridView3.GetRowCellValue(I, "GridColumn24")
                                        If (Boolean.Parse(s) = True) Then
                                            Conn.Open()
                                            Dim drDetail As DataRow = OutLetBillRecipet.NewRow()
                                            Dim OutLetBillNo As String = GridView3.GetRowCellValue(I, "Bill No")
                                            '  dcInsertNewAccDetail = New SqlCommand("OutLet_Bill_Pay_SP", Conn)


                                            dcInsertNewAccDetail = New SqlCommand("OutLet_Bill_Pay_SP_Bill", Conn)

                                            dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
                                            reciptNo = "REC" & OutLetBillNo
                                            dcInsertNewAccDetail.Parameters.Add("billNo", SqlDbType.VarChar).Value = OutLetBillNo
                                            dcInsertNewAccDetail.Parameters.Add("reciptNo", SqlDbType.VarChar).Value = reciptNo
                                            dcInsertNewAccDetail.Parameters.Add("payType", SqlDbType.VarChar).Value = PayType
                                            dcInsertNewAccDetail.Parameters.Add("Amount", SqlDbType.Float).Value = GridView3.GetRowCellValue(I, "Total")
                                            dcInsertNewAccDetail.Parameters.Add("ChqORCreditCardNumber", SqlDbType.VarChar).Value = TextEditPayMethodNumber.Text
                                            dcInsertNewAccDetail.Parameters.Add("CurrencyCode", SqlDbType.VarChar).Value = ComboBoxEditCurrency.Text
                                            dcInsertNewAccDetail.Parameters.Add("SellingRate", SqlDbType.Decimal).Value = getsellingRate(ComboBoxEditCurrency.Text)
                                            dcInsertNewAccDetail.Parameters.Add("Bank", SqlDbType.VarChar).Value = TextEditBank.Text
                                            dcInsertNewAccDetail.Parameters.Add("Type", SqlDbType.VarChar).Value = "Out Let Bill"
                                            dcInsertNewAccDetail.ExecuteNonQuery()
                                            Conn.Close()

                                            drDetail("BillNo") = OutLetBillNo
                                            drDetail("Date") = GridView3.GetRowCellValue(I, "KOTBOT Date")
                                            drDetail("RoomNo") = GridView3.GetRowCellValue(I, "Room No")
                                            drDetail("ReceiptNo") = reciptNo
                                            drDetail("PayMethod") = getPayTypeDescription(PayType) + " Receipt "
                                            drDetail("amount") = GridView3.GetRowCellValue(I, "Total")
                                            drDetail("GuestName") = GridView3.GetRowCellValue(I, "Guest Name")
                                            drDetail("PayMethodNo") = getPaymethod(TextEditPayMethodNumber.Text, True)
                                            drDetail("Currency") = ComboBoxEditCurrency.Text
                                            OutLetBillRecipet.Rows.Add(drDetail)
                                        End If
                                    Next
                                    dsOutLetBillRecipet.Tables.Clear()
                                    dsOutLetBillRecipet.Tables.Add(OutLetBillRecipet)
                                    loadPaydata()
                                    loadmasterBillData()
                                    ShowReportView(New Receipt, dsOutLetBillRecipet)
                                Else
                                    MsgBox("Please Select Bills to Pay.", MsgBoxStyle.Critical, "Error")
                                End If
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Finally
                Conn.Dispose()
                dcInsertNewAccDetail.Dispose()
            End Try




        Else

            MsgBox("You Do Not Have Access")


        End If





    End Sub

    Private Function getPayTypeDescriptionMaster(ByVal number As String) As String
        Try
            Dim PayMethod As String = ComboBoxPayMethod.Text
            LabelControlPayMethod.Text = ""
            If (Not PayMethod Is Nothing) Then
                Dim dataRowList() As DataRow
                dataRowList = dsPayMethodMAster.Tables(0).Select(String.Format("PaymentTypeCode ='{0}'", PayMethod))
                If (Not dataRowList Is Nothing) Then
                    If (dataRowList.Length > 0) Then

                        getPayTypeDescriptionMaster = dataRowList(0)("Description").ToString()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Function

    '  End Function
    Private Sub oulteltbill(ByVal s As Decimal, ByVal billNo As String)
        Dim Conn As New SqlConnection
        Dim OutLetBillRecipet As New DataTable
        OutLetBillRecipet.TableName = "OutLetBillRecipet"
        OutLetBillRecipet.Columns.Add("BillNo")
        OutLetBillRecipet.Columns.Add("Date")
        OutLetBillRecipet.Columns.Add("RoomNo")
        OutLetBillRecipet.Columns.Add("ReceiptNo")
        OutLetBillRecipet.Columns.Add("PayMethod")
        OutLetBillRecipet.Columns.Add("amount", System.Type.GetType("System.Double"))
        OutLetBillRecipet.Columns.Add("GuestName")
        OutLetBillRecipet.Columns.Add("PayMethodNo")
        OutLetBillRecipet.Columns.Add("Currency")
        Dim OutLetBillNo As String = ""
        Dim dsOutLetBillRecipet As New DataSet
        Dim dcInsertNewAccDetail As New SqlCommand
        Dim currencyCode = ComboBoxEditCurrencymaster.Text 'getCurrencyCode(billNo)
        Try

            Dim reciptNo As String = String.Empty
            Dim PayType As String = ComboBoxEditPayMethod.Text.Trim()

            Dim intNo As Integer = getNewBillNO()
            intNo = intNo + 1

            Conn = New SqlConnection(ConnString)
            Conn.Open()
            Dim drDetail As DataRow = OutLetBillRecipet.NewRow()

            dcInsertNewAccDetail = New SqlCommand("OutLet_Bill_Pay_SP", Conn)
            dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure

            ' reciptNo = "REC-" & intNo
            reciptNo = "REC-" & billNo

            Dim GetCurrencyTotal As Decimal = getsellingRate(currencyCode)

            Dim TotalWithCurr As Decimal = GetCurrencyTotal * s



            dcInsertNewAccDetail.Parameters.Add("billNo", SqlDbType.VarChar).Value = billNo
            dcInsertNewAccDetail.Parameters.Add("reciptNo", SqlDbType.VarChar).Value = reciptNo
            dcInsertNewAccDetail.Parameters.Add("payType", SqlDbType.VarChar).Value = PayType
            ' dcInsertNewAccDetail.Parameters.Add("Amount", SqlDbType.Float).Value = s
            dcInsertNewAccDetail.Parameters.Add("Amount", SqlDbType.Float).Value = TotalWithCurr
            dcInsertNewAccDetail.Parameters.Add("ChqORCreditCardNumber", SqlDbType.VarChar).Value = TextEditPayMethodNumberMater.Text
            dcInsertNewAccDetail.Parameters.Add("CurrencyCode", SqlDbType.VarChar).Value = currencyCode
            dcInsertNewAccDetail.Parameters.Add("SellingRate", SqlDbType.Decimal).Value = getsellingRate(currencyCode)
            dcInsertNewAccDetail.Parameters.Add("Type", SqlDbType.VarChar).Value = "Master Bill Balance"
            dcInsertNewAccDetail.Parameters.Add("Bank", SqlDbType.VarChar).Value = TextEditBankMaster.Text
            dcInsertNewAccDetail.ExecuteNonQuery()
            Conn.Close()



            drDetail = OutLetBillRecipet.NewRow()
            drDetail("BillNo") = billNo
            drDetail("Date") = DateTime.Now()
            drDetail("RoomNo") = ComboBoxRoomNo.Text
            drDetail("ReceiptNo") = reciptNo
            drDetail("PayMethod") = getPayTypeDescriptionMaster(ComboBoxEditPayMethod.Text)
            drDetail("amount") = Double.Parse(TotalWithCurr)
            drDetail("GuestName") = TextEditGuest.Text
            Dim bankData As String = ""

            If (Not String.IsNullOrEmpty(TextEditBankMaster.Text)) Then
                bankData = TextEditPayMethodNumberMater.Text & "   " & TextEditBankMaster.Text
            Else
                bankData = TextEditPayMethodNumberMater.Text
            End If

            drDetail("PayMethodNo") = bankData
            drDetail("Currency") = currencyCode
            OutLetBillRecipet.Rows.Add(drDetail)

            dsOutLetBillRecipet.Tables.Clear()
            dsOutLetBillRecipet.Tables.Add(OutLetBillRecipet)

            ShowReportView(New Receipt, dsOutLetBillRecipet)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            dcInsertNewAccDetail.Dispose()
        End Try
    End Sub

    'Private Sub oulteltbill(ByVal t As Decimal, ByVal s As Decimal, ByVal billNo As String)
    '    Dim Conn As New SqlConnection
    '    Dim OutLetBillRecipet As New DataTable
    '    OutLetBillRecipet.TableName = "OutLetBillRecipet"
    '    OutLetBillRecipet.Columns.Add("BillNo")
    '    OutLetBillRecipet.Columns.Add("Date")
    '    OutLetBillRecipet.Columns.Add("RoomNo")
    '    OutLetBillRecipet.Columns.Add("ReceiptNo")
    '    OutLetBillRecipet.Columns.Add("PayMethod")
    '    OutLetBillRecipet.Columns.Add("amount")
    '    OutLetBillRecipet.Columns.Add("GuestName")
    '    OutLetBillRecipet.Columns.Add("PayMethodNo")
    '    OutLetBillRecipet.Columns.Add("Currency")
    '    Dim OutLetBillNo As String = ""
    '    Dim dsOutLetBillRecipet As New DataSet
    '    Dim dcInsertNewAccDetail As New SqlCommand
    '    Dim currencyCode = getCurrencyCode(billNo)
    '    Try

    '        Dim reciptNo As String = String.Empty
    '        Dim PayType As String = "" 'ComboBoxPayMethod.Text.Trim()
    '        '     Dim DataRowCount As Integer = GridView3.DataRowCount
    '        Dim intNo As Integer = getNewBillNO()
    '        intNo = intNo + 1

    '        Conn = New SqlConnection(ConnString)
    '        Conn.Open()
    '        Dim drDetail As DataRow = OutLetBillRecipet.NewRow()

    '        dcInsertNewAccDetail = New SqlCommand("OutLet_Bill_Pay_SP", Conn)
    '        dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
    '        reciptNo = "REC/SER/Tax/" & intNo
    '        dcInsertNewAccDetail.Parameters.Add("billNo", SqlDbType.VarChar).Value = "Tax "
    '        dcInsertNewAccDetail.Parameters.Add("reciptNo", SqlDbType.VarChar).Value = reciptNo
    '        dcInsertNewAccDetail.Parameters.Add("payType", SqlDbType.VarChar).Value = PayType
    '        dcInsertNewAccDetail.Parameters.Add("Amount", SqlDbType.Float).Value = t
    '        dcInsertNewAccDetail.Parameters.Add("ChqORCreditCardNumber", SqlDbType.VarChar).Value = ""
    '        dcInsertNewAccDetail.Parameters.Add("CurrencyCode", SqlDbType.VarChar).Value = currencyCode
    '        dcInsertNewAccDetail.Parameters.Add("SellingRate", SqlDbType.Decimal).Value = getsellingRate(ComboBoxEditCurrency.Text)
    '        dcInsertNewAccDetail.Parameters.Add("Type", SqlDbType.VarChar).Value = "Out Let Bill"
    '        dcInsertNewAccDetail.ExecuteNonQuery()
    '        Conn.Close()

    '        Conn.Open()

    '        OutLetBillNo = "" ' GridView3.GetRowCellValue(I, "Bill No")
    '        dcInsertNewAccDetail = New SqlCommand("OutLet_Bill_Pay_SP", Conn)
    '        dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
    '        reciptNo = "REC/SER/Tax/" & intNo
    '        dcInsertNewAccDetail.Parameters.Add("billNo", SqlDbType.VarChar).Value = "Service Charges"
    '        dcInsertNewAccDetail.Parameters.Add("reciptNo", SqlDbType.VarChar).Value = reciptNo
    '        dcInsertNewAccDetail.Parameters.Add("payType", SqlDbType.VarChar).Value = PayType
    '        dcInsertNewAccDetail.Parameters.Add("Amount", SqlDbType.Float).Value = s
    '        dcInsertNewAccDetail.Parameters.Add("ChqORCreditCardNumber", SqlDbType.VarChar).Value = ""
    '        dcInsertNewAccDetail.Parameters.Add("CurrencyCode", SqlDbType.VarChar).Value = currencyCode
    '        dcInsertNewAccDetail.Parameters.Add("SellingRate", SqlDbType.Decimal).Value = getsellingRate(ComboBoxEditCurrency.Text)
    '        dcInsertNewAccDetail.Parameters.Add("Type", SqlDbType.VarChar).Value = "Out Let Bill"

    '        dcInsertNewAccDetail.ExecuteNonQuery()
    '        Conn.Close()

    '        drDetail = OutLetBillRecipet.NewRow()
    '        drDetail("BillNo") = "Tax"
    '        drDetail("Date") = DateTime.Now()
    '        drDetail("RoomNo") = ComboBoxRoomNo.Text
    '        drDetail("ReceiptNo") = reciptNo
    '        drDetail("PayMethod") = "Tax & Service Charge Receipt "
    '        drDetail("amount") = t
    '        drDetail("GuestName") = TextEditGuest.Text
    '        drDetail("PayMethodNo") = ""
    '        drDetail("Currency") = currencyCode
    '        OutLetBillRecipet.Rows.Add(drDetail)

    '        drDetail = OutLetBillRecipet.NewRow()
    '        drDetail("BillNo") = "Service Charges"
    '        drDetail("Date") = DateTime.Now()
    '        drDetail("RoomNo") = ComboBoxRoomNo.Text
    '        drDetail("ReceiptNo") = reciptNo
    '        drDetail("PayMethod") = "Tax & Service Charge Receipt "
    '        drDetail("amount") = s
    '        drDetail("GuestName") = TextEditGuest.Text
    '        drDetail("PayMethodNo") = ""
    '        drDetail("Currency") = currencyCode
    '        OutLetBillRecipet.Rows.Add(drDetail)

    '        dsOutLetBillRecipet.Tables.Clear()
    '        dsOutLetBillRecipet.Tables.Add(OutLetBillRecipet)

    '        ShowReportView(New Receipt, dsOutLetBillRecipet)

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
    '    Finally
    '        Conn.Dispose()
    '        dcInsertNewAccDetail.Dispose()
    '    End Try
    'End Sub

    Private Sub GridView3_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView3.CustomUnboundColumnData
        If (e.Column.FieldName = "GridColumn24") Then
            If (unboundDataOutLetBill.Count > e.ListSourceRowIndex) Then
                If (e.IsGetData = True) Then
                    e.Value = unboundDataOutLetBill(e.ListSourceRowIndex)
                Else
                    unboundDataOutLetBill(e.ListSourceRowIndex) = e.Value
                End If
            End If

        End If
    End Sub

    Private Sub GridView2_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs)
        If (e.Column.FieldName = "GridColumn12") Then
            If (unboundData.Count > e.ListSourceRowIndex) Then
                If (e.IsGetData = True) Then
                    e.Value = unboundData(e.ListSourceRowIndex)
                Else
                    unboundData(e.ListSourceRowIndex) = e.Value
                End If
            End If
        End If
    End Sub



    Private Sub ComboBoxEditPayMethod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEditPayMethod.SelectedIndexChanged
        Try
            Dim PayMethod As String = ComboBoxEditPayMethod.Text
            LabelControlPayMethodMaster.Text = ""
            If (Not PayMethod Is Nothing) Then
                Dim dataRowList() As DataRow
                dataRowList = dsPayMethodMAster.Tables(0).Select(String.Format("PaymentTypeCode ='{0}'", PayMethod))
                If (Not dataRowList Is Nothing) Then
                    If (dataRowList.Length > 0) Then
                        TextEditPayMaster.Text = dataRowList(0)("Description").ToString()
                        If (dataRowList(0)("NumberRequired").ToString().ToLower() = "true") Then
                            TextEditPayMethodNumberMater.Enabled = True
                            LabelControlPayMethodMaster.Text = dataRowList(0)("Description").ToString() + " No."
                        Else
                            TextEditPayMethodNumberMater.Enabled = False
                            LabelControlPayMethodMaster.Text = ""
                        End If

                        If (dataRowList(0)("BankRequired").ToString().ToLower() = "true") Then
                            TextEditBankMaster.Enabled = True
                        Else
                            TextEditBankMaster.Enabled = False
                        End If

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        End Try
    End Sub

    Private Sub ComboRoom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboRoom.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxEditCurrency.Focus()
        End If
    End Sub

    Private Sub ComboBoxEditCurrency_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEditCurrency.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxPayMethod.Focus()
        End If
    End Sub

    Private Sub ComboBoxPayMethod_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxPayMethod.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridControl1.Focus()
        End If
    End Sub

    Private Sub ComboBoxRoomNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxRoomNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxEditTax.Focus()
        End If
    End Sub

    Private Sub ComboBoxEditTax_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEditTax.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextEditServiceCharges.Focus()
        End If
    End Sub

    Private Sub TextEditServiceCharge_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEditServiceCharge.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub TextEditServiceCharges_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEditServiceCharges.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextEditDiscount.Focus()
        End If
    End Sub

    Private Sub TextEditDiscount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEditDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxEditCurrencymaster.Focus()
        End If
    End Sub

    Private Sub ComboBoxEditPayMethod_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEditPayMethod.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCreateBilling.Focus()
        End If
    End Sub

    Private Sub ComboBoxEditCurrencymaster_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEditCurrencymaster.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxEditPayMethod.Focus()
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        loadPaydataStaff()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        InsertTempMasBill("MBILL-13-00014")

        PrintMasInv()
    End Sub

    Private Sub GridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.Click

        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Paid") = 0 Then

            PubBillNoCancel = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Bill No")

        Else

            PubBillNoCancel = "NOBILLS"
        End If


    End Sub

    Private Sub btBillReverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBillReverse.Click



        Dim CheckAccess As Boolean = UserPermission(CurrUser, "KOTBOTBilling", "Delete")

        If CheckAccess = True Then






            Try

                If PubBillNoCancel <> "NOBILLS" Then


                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Reverce this Bill", "Reverce Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then

                        CancelBill()


                    End If

                Else

                    MsgBox("Paid Bills Can not Reverce", MsgBoxStyle.Critical, ErrTitle)


                End If



            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try



        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub

    Private Sub btViewDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewDetails.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Master billing", "MasterBill")

        If CheckAccess = True Then


            Dim GetMasBillNo As String = gvProforma.GetRowCellValue(gvProforma.FocusedRowHandle, "BillNo")

            InsertTempMasBill(GetMasBillNo)

            PrintMasInv()



        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub

    Private Sub gvProforma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvProforma.Click
        ' PubBillNoCancel = GridView1.gvProforma(gvProforma.FocusedRowHandle, "Bill No")
    End Sub

    Private Sub btMasBillWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMasBillWeek.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Master billing", "MasterBill")

        If CheckAccess = True Then




            Dim CurrentUser As String = CurrUser

            Dim bill As String = ""
            Dim BillGeneratedDate As String = ""
            Dim Department As String = ""
            Dim GrandTotaloftheInvoices As Double = 0
            Dim ServiceCharge As Double = 0
            Dim Total As Double = 0
            Dim GSTTax As Decimal 'Double = 0
            Dim GrandTotal As Decimal = 0
            Dim Discountgiven As Double = 0
            Dim AdvancePaid As Double = 0
            Dim NetAmounttobesettled As Double = 0
            Dim Discount As Double
            If (tabMain.SelectedTabPageIndex <> 1) Then
                tabMain.SelectedTabPageIndex = 1
            ElseIf (tabMain.SelectedTabPageIndex = 1) Then
                Dim bt As DialogResult = MessageBox.Show("Do you want to generate weekly master bill for Room Number: " & ComboBoxRoomNo.Text,
                                                         " Master bill Generate ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then
                    Dim isValid As Boolean = validate()
                    If (isValid = True) Then
                        Dim cnumberPart As String = ""
                        Dim ConnStr As String = ConnString
                        Dim Conn As New SqlConnection(ConnStr)
                        Dim dcMasterBill As New SqlCommand
                        Dim dateVal As DateTime = DateTime.Now
                        Dim intNo As Integer = getNewBillNO()
                        intNo = intNo + 1
                        'unpaid
                        cnumberPart = intNo.ToString()
                        Dim billnumbers As String = String.Empty
                        Dim paid As String = String.Empty

                        'Dim autoid As String = "MB" & dateVal.Year.ToString().Trim() & dateVal.Month.ToString().Trim() & dateVal.Day.ToString().Trim() & cnumberPart

                        Dim autoid As String = GetMasBillNo()
                        PubMasNo = autoid



                        Dim I As Integer
                        Dim DataRowCount As Integer = GridView1.DataRowCount
                        For I = 0 To DataRowCount - 1
                            paid = String.Empty
                            paid = GridView1.GetRowCellValue(I, "Paid")
                            If (paid.ToLower().Trim() = "false") Then
                                Dim outLetBill As String = GridView1.GetRowCellValue(I, "Bill No")
                                billnumbers = billnumbers & outLetBill & ","
                                dsUnPaid.Tables(0).Rows(I)("sum") = TextEditUnPaid.Text
                            End If
                        Next
                        I = 0

                        DataRowCount = GridView4.DataRowCount
                        For I = 0 To DataRowCount - 1
                            Dim outLetBill As String = GridView4.GetRowCellValue(I, "Bill No")
                            billnumbers = billnumbers & outLetBill & ","
                            dsPaid.Tables(0).Rows(I)("sum") = TextEditPaid.Text
                        Next
                        If (billnumbers.Length > 0) Then
                            billnumbers = billnumbers.Remove(billnumbers.Length - 1)
                        End If
                        Dim rmsDbDataSet As New DataSet

                        Dim taxRate As Decimal = getTextRates(ComboBoxEditTax.Text)
                        Dim serCharge As Decimal = Decimal.Parse(TextEditServiceCharge.Text)
                        Dim t As Double = Double.Parse(TextEditUnPaid.Text) * (taxRate / 100)
                        Dim s As Double = Double.Parse(TextEditUnPaid.Text) * (serCharge / 100)
                        Dim g As Double = t + s + Double.Parse(TextEditTotal.Text)

                        If (String.IsNullOrEmpty(TextEditServiceCharges.Text)) Then
                            ServiceCharge = 0
                        Else
                            ServiceCharge = Double.Parse(TextEditServiceCharges.Text)
                        End If

                        Conn.Open()
                        dcMasterBill = New SqlCommand("genarate_masterBill_Weekly_SP", Conn)
                        dcMasterBill.CommandType = CommandType.StoredProcedure
                        dcMasterBill.Parameters.Add("billNo ", SqlDbType.VarChar).Value = autoid
                        dcMasterBill.Parameters.Add("OutLetbillNo", SqlDbType.VarChar).Value = billnumbers
                        dcMasterBill.Parameters.Add("taxrate", SqlDbType.Decimal).Value = taxRate
                        dcMasterBill.Parameters.Add("ServiceCharge", SqlDbType.Decimal).Value = ServiceCharge
                        dcMasterBill.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value = CurrentUser


                        dcMasterBill.ExecuteNonQuery()
                        Conn.Close()

                        Dim dt As New DataTable()
                        dt = dsUnPaid.Tables(0).Clone()

                        Dim drBlank1 As DataRow = dt.NewRow()
                        drBlank1("t") = "Paid recipts"
                        drBlank1("MasterBillNo") = autoid
                        drBlank1("guest") = TextEditGuest.Text
                        drBlank1("RoomNo") = ComboBoxRoomNo.Text
                        drBlank1("balance") = TextEditUnPaid.Text
                        drBlank1("grandTot") = TextEditTotal.Text
                        dt.Rows.Add(drBlank1)

                        If (Not dsPaid Is Nothing) Then
                            Dim k As Integer
                            For k = 0 To dsPaid.Tables(0).Rows.Count - 1
                                Dim dr As DataRow = dt.NewRow()
                                If (k = 0) Then
                                    bill = dsPaid.Tables(0).Rows(k)("Bill No")
                                End If
                                dr("MasterBillNo") = autoid
                                dr("Receipt") = dsPaid.Tables(0).Rows(k)("Receipt")
                                dr("Bill No") = dsPaid.Tables(0).Rows(k)("Bill No")
                                dr("Amount") = dsPaid.Tables(0).Rows(k)("Amount")
                                dr("RoomNo") = dsPaid.Tables(0).Rows(k)("RoomNo")
                                dr("guest") = dsPaid.Tables(0).Rows(k)("guest")
                                dr("PayType") = dsPaid.Tables(0).Rows(k)("PayType")
                                dr("sum") = dsPaid.Tables(0).Rows(k)("sum")
                                dr("balance") = TextEditTotal.Text
                                dr("grandTot") = g.ToString() ' TextEditUnPaid.Text
                                dr("BillGeneratedDate") = dsPaid.Tables(0).Rows(k)("BillGeneratedDate")
                                dr("Department") = dsPaid.Tables(0).Rows(k)("Department")
                                dr("DepDate") = dsPaid.Tables(0).Rows(k)("BillGeneratedDate")
                                dr("ArriveDate") = dsPaid.Tables(0).Rows(k)("ArriveDate")
                                dr("opdetail") = dsPaid.Tables(0).Rows(k)("opdetail")
                                dt.Rows.Add(dr)
                            Next
                        End If

                        Dim drBlank2 As DataRow = dt.NewRow()
                        dt.Rows.Add(drBlank2)

                        Dim drBlank3 As DataRow = dt.NewRow()
                        drBlank3("MasterBillNo") = autoid
                        drBlank3("guest") = TextEditGuest.Text
                        drBlank3("RoomNo") = ComboBoxRoomNo.Text
                        drBlank3("balance") = TextEditUnPaid.Text
                        drBlank3("grandTot") = TextEditTotal.Text
                        drBlank3("t") = "Un Piad Bills"

                        dt.Rows.Add(drBlank3)
                        paid = String.Empty
                        If (Not dsUnPaid Is Nothing) Then
                            Dim J As Integer
                            For J = 0 To dsUnPaid.Tables(0).Rows.Count - 1
                                Dim dr As DataRow = dt.NewRow()
                                paid = String.Empty
                                paid = dsUnPaid.Tables(0).Rows(J)("Paid")
                                If (paid.Trim().ToLower() = "false") Then
                                    dr("Bill No") = dsUnPaid.Tables(0).Rows(J)("Bill No")
                                    dr("Receipt") = dsUnPaid.Tables(0).Rows(J)("Receipt")
                                    dr("MasterBillNo") = autoid ' dsUnPaid.Tables(0).Rows(J)("Bill No")
                                    dr("Amount") = dsUnPaid.Tables(0).Rows(J)("Amount")
                                    dr("RoomNo") = dsUnPaid.Tables(0).Rows(J)("RoomNo")
                                    dr("guest") = dsUnPaid.Tables(0).Rows(J)("guest")
                                    dr("PayType") = dsUnPaid.Tables(0).Rows(J)("PayType")
                                    dr("sum") = dsUnPaid.Tables(0).Rows(J)("sum")
                                    dr("balance") = TextEditTotal.Text
                                    dr("grandTot") = g.ToString() 'TextEditUnPaid.Text
                                    dr("Department") = dsUnPaid.Tables(0).Rows(J)("Department")
                                    dr("BillGeneratedDate") = dsUnPaid.Tables(0).Rows(J)("BillGeneratedDate")
                                    dr("DepDate") = dsUnPaid.Tables(0).Rows(J)("BillGeneratedDate")
                                    dr("ArriveDate") = dsUnPaid.Tables(0).Rows(J)("ArriveDate")
                                    dr("opdetail") = dsUnPaid.Tables(0).Rows(J)("opdetail")
                                    dt.Rows.Add(dr)
                                End If
                            Next
                        End If

                        Dim drBlank5 As DataRow = dt.NewRow()
                        drBlank5("GrandTotaloftheInvoices") = TextEditUnPaid.Text ' TextEditPaid.Text
                        drBlank5("MasterBillNo") = autoid
                        dt.Rows.Add(drBlank5)

                        GrandTotaloftheInvoices = Double.Parse(TextEditUnPaid.Text)

                        ' ServiceCharge = GrandTotaloftheInvoices * 0.1
                        Dim drBlank7 As DataRow = dt.NewRow()
                        Total = ServiceCharge + GrandTotaloftheInvoices
                        Dim taxrates As Decimal = taxRate / 100
                        GSTTax = Total * taxrates
                        GrandTotal = GSTTax + Total

                        If String.IsNullOrEmpty(TextEditDiscount.Text) Then
                            Discount = GrandTotal - Discountgiven
                        Else
                            Discountgiven = Double.Parse(TextEditDiscount.Text)
                            Discount = GrandTotal - Discountgiven
                        End If

                        Dim advance As Double = Double.Parse(TextEditPaid.Text)
                        NetAmounttobesettled = Discount - advance
                        rmsDbDataSet.Tables.Add(dt)
                        rmsDbDataSet.Tables(0).TableName = "Table"

                        Dim dt2 As DataTable = getdeparmentwise()
                        dt2.TableName = "t2"
                        rmsDbDataSet.Tables.Add(dt2)
                        rmsDbDataSet.Tables(1).TableName = "t2"

                        '     rmsDbDataSet.WriteXmlSchema("c:\master11.xsd")
                        Dim res As String = ""
                        Dim toOperator As String = ""
                        If (Not dsUnPaid Is Nothing) Then
                            If (dsUnPaid.Tables(0).Rows.Count > 0) Then
                                toOperator = getToOperatorNumber(dsUnPaid.Tables(0).Rows(0)("ReservationNo"))
                            End If
                        End If

                        Dim l As Integer
                        For l = 0 To rmsDbDataSet.Tables(0).Rows.Count - 1
                            rmsDbDataSet.Tables(0).Rows(l)("GrandTotaloftheInvoices") = FormatNumber(TextEditUnPaid.Text, 2)

                            rmsDbDataSet.Tables(0).Rows(l)("ServiceCharge") = FormatNumber(ServiceCharge, 2)
                            rmsDbDataSet.Tables(0).Rows(l)("Total") = FormatNumber(Total, 2)
                            rmsDbDataSet.Tables(0).Rows(l)("GSTTax") = "GST Tax     (" & ComboBoxEditTax.Text & " %)                                                                                                   " & FormatNumber(GSTTax, 2)

                            If String.IsNullOrEmpty(TextEditDiscount.Text) Then
                                rmsDbDataSet.Tables(0).Rows(l)("Discountgiven") = "0"
                            Else
                                rmsDbDataSet.Tables(0).Rows(l)("Discountgiven") = FormatNumber(TextEditDiscount.Text, 2)
                            End If
                            If String.IsNullOrEmpty(TextEditDiscount.Text) Then
                                rmsDbDataSet.Tables(0).Rows(l)("sum") = ""
                            Else
                                rmsDbDataSet.Tables(0).Rows(l)("sum") = FormatNumber(Discount, 2)
                            End If
                            rmsDbDataSet.Tables(0).Rows(l)("AdvancePaid") = FormatNumber(TextEditPaid.Text, 2)
                            rmsDbDataSet.Tables(0).Rows(l)("NetAmounttobesettled") = FormatNumber(NetAmounttobesettled, 2)
                            rmsDbDataSet.Tables(0).Rows(l)("GrandTotal") = FormatNumber(GrandTotal, 2)
                            rmsDbDataSet.Tables(0).Rows(l)("Discount") = FormatNumber(Discount, 2)
                            rmsDbDataSet.Tables(0).Rows(l)("opdetail") = toOperator

                        Next

                        ''''''''''''''''
                        Dim jj As Integer
                        jj = 0
                        For jj = 0 To dt2.Rows.Count - 1
                            Dim dr As DataRow = dt.NewRow()
                            dr("MasterBillNo") = ""
                            dr("Receipt") = ""
                            dr("Bill No") = ""
                            '   dr("Amount") = 0
                            dr("RoomNo") = ""
                            dr("guest") = ""
                            dr("PayType") = ""
                            dr("sum") = ""
                            dr("balance") = ""
                            dr("grandTot") = ""
                            ' dr("BillGeneratedDate") = 
                            dr("Department") = ""
                            '    dr("DepDate") = ""
                            '   dr("ArriveDate") = ""
                            dr("opdetail") = ""
                            dr("Department1") = dt2.Rows(jj)("Department").ToString()
                            dr("departmenttot") = dt2.Rows(jj)("Amount").ToString()

                            dr("GrandTotaloftheInvoices") = FormatNumber(TextEditUnPaid.Text, 2)

                            dr("ServiceCharge") = FormatNumber(ServiceCharge, 2)
                            dr("Total") = FormatNumber(Total, 2)
                            dr("GSTTax") = "GST Tax     (" & ComboBoxEditTax.Text & " %)                                                                                                   " & FormatNumber(GSTTax, 2)

                            If String.IsNullOrEmpty(TextEditDiscount.Text) Then
                                dr("Discountgiven") = "0"
                            Else
                                dr("Discountgiven") = FormatNumber(TextEditDiscount.Text, 2)
                            End If
                            If String.IsNullOrEmpty(TextEditDiscount.Text) Then
                                dr("sum") = ""
                            Else
                                dr("sum") = FormatNumber(Discount, 2)
                            End If
                            dr("AdvancePaid") = FormatNumber(TextEditPaid.Text, 2)
                            dr("NetAmounttobesettled") = FormatNumber(NetAmounttobesettled, 2)
                            dr("GrandTotal") = FormatNumber(GrandTotal, 2)
                            dr("Discount") = FormatNumber(Discount, 2)
                            dr("opdetail") = toOperator
                            dt.Rows.Add(dr)
                        Next
                        ''''''''''''''




                        '   PrintMasInv(PubMasNo)

                        InsertTempMasBillWeekly(PubMasNo)

                        PrintMasInv()



                        LoadFinalMasBillAmount(PubMasNo)


                        UpdateMasBillTbl(PubMasNo, PubFinalMasterAmount)


                        'ShowReportView(New MasterBill1, rmsDbDataSet)

                        Dim GetNetAmtToSettle As Decimal = FormatNumber(NetAmounttobesettled, 2)

                        Dim PassMasBillno As String = PubMasNo

                        oulteltbill(PubFinalMasterAmount, PassMasBillno)


                        '  oulteltbill(GetNetAmtToSettle, PassMasBillno)

                        ' oulteltbill(FormatNumber(NetAmounttobesettled, 2), bill)
                        clear()
                        loadmasterBillData()
                        TextEditDiscount.Text = ""


                        LoadGridMasterbill()

                    End If
                End If
            End If





        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub btMbilpre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMbilpre.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Master billing", "MasterBill")

        If CheckAccess = True Then




            Try

                Dim bt As DialogResult = MessageBox.Show("Do you want to generate Master Bill Preview for Room Number: " & ComboBoxRoomNo.Text,
                                                          " Master Bill Preview", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InsertTempMasBillPreview(ComboBoxRoomNo.Text.Trim, txtresno.Text.Trim, CurrUser)
                    PrintMbillPreview()
                End If



                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "INFO Exception")

            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If







    End Sub
End Class
' 