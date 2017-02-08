Imports System.Data.SqlClient
Public Class frmMasterbillStaff
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
    Private Sub LabelControl13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub LoadEmp(ByVal PassEmpType As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getEmpType As String = PassEmpType

            Conn.Open()
            dcSearch = New SqlCommand("select Empno,EmpName from [Emp] where Status='OPEN' AND Category=@Category order by Empno", Conn)
            dcSearch.Parameters.Add("@Category", SqlDbType.NVarChar).Value = getEmpType

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            Dim newCustomersRow As DataRow = dsMain.Tables(0).NewRow()


            'While (DscountTest < Dscount)

            '    cbTopcode2.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
            '    DscountTest = DscountTest + 1

            'End While

            With cbEmp.Properties
                .DataSource = dsMain.Tables(0)
                .DisplayMember = "EmpName"
                .ValueMember = "Empno"
                .Columns(0).Width = 100
                .Columns(1).Width = 150
                .PopupWidth = 400
                .AutoSearchColumnIndex = 1
                .TextEditStyle = True

            End With

            'cbTopcode2.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub


    Private Sub cmbEmpType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpType.SelectedIndexChanged

        cbEmp.Properties.DataSource = Nothing
        cbEmp.Visible = True
        LoadEmp(cmbEmpType.Text.Trim)


    End Sub
    Private Sub LoadPaid(ByVal Empname As String)
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

            'dcPaid = New SqlCommand("SELECT distinct '' as t, o.[BillNo] as 'Bill No' ,o.[KOTBOTNo] ,o.[MasterBillGenerated],o.[MasterBillNo] ,o.[Paid] ,o.[ReciptNo]  as Receipt,(o.[Total]-o.discountAmount) as 'Amount',o.[RoomNo],o.[ReservationNo] ,o.[Type],'guest' as guest,'' as 'sum','' as balance,'' as grandTot,p.[Description] as 'PayType', o.BillGeneratedDate, d.Department,''as 'GrandTotaloftheInvoices'  ,'' as 'ServiceCharge',''as 'Total',''as 'GSTTax'   ,''as 'GrandTotal' ,''as 'Discountgiven','' as Discount,''as 'AdvancePaid',''as 'NetAmounttobesettled' , g.DepDate,g.ArriveDate,'' opdetail,'' department1,'' departmenttot  FROM [OutLetBillMaster] o inner join dbo.KotBotMaster k on k.Id=o.KOTBOTNo inner join  dbo.GuestRegistration g  on g.ReservationNo =o.ReservationNo  inner join dbo.DepartmentMaster d on k.Department =d.DepartmentID Collate SQL_Latin1_General_CP1_CI_AS inner join [PaymentType] P on P.[PaymentTypeCode]=[PayType]  inner join dbo.[Room.CurrentStatus] c on  c.ReservationNo = o.ReservationNo where o.[Paid]=1 and o.[MasterBillGenerated]=0 and g.IsBillingGuest =1 and o.[RoomNo] ='" & Empname & "'", Conn)

            dcPaid = New SqlCommand("SELECT o.[BillNo]  as 'Bill No' ,o.[KOTBOTNo] ,o.[MasterBillGenerated],o.[MasterBillNo] ,o.[Paid] ,o.[ReciptNo] as Receipt ,(o.[Total]-o.discountAmount) as 'Amount',o.[RoomNo],o.[ReservationNo] ,o.[Type],o.BillGeneratedDate, o.Department,o.OutletMasBill as OutMasNo , '' as 'sum' , '' as 'guest' , '' as 'PayType' ,'' as 'balance' , '' as grandTot ,'' as opdetail ,''as 'Department1'  , ''as 'departmenttot' , ''as 'GrandTotaloftheInvoices'  ,'' as 'ServiceCharge'  FROM dbo.OutLetBillMaster o INNER JOIN  dbo.Emp ON o.ReservationNo = dbo.Emp.EmpName  where o.ReservationNo='" & Empname & "' and o.Paid=1 and o.MasterBillGenerated=0 and o.BillGeneratedDate >= '2015-05-01'", Conn)

            daApid = New SqlDataAdapter()
            daApid.SelectCommand = dcPaid
            daApid.Fill(dsPaid)

            If (Not dsPaid Is Nothing) Then
                GridControlPaid.DataSource = dsPaid.Tables(0)
                dsPaid.Tables(0).TableName = "Paid"
                Dim I As Integer
                For I = 0 To dsPaid.Tables(0).Rows.Count - 1
                    paidAmount = Double.Parse(dsPaid.Tables(0).Rows(I)("Amount").ToString())
                    dsPaid.Tables(0).Rows(I)("ReservationNo") = cbEmp.Text
                    totalPaidAmount = totalPaidAmount + paidAmount
                Next
                TextEditPaid.Text = totalPaidAmount.ToString()
            End If
            Conn.Close()

            Conn.Open()


            'dcUnPaid = New SqlCommand("SELECT distinct '' as t, o.[BillNo]  as 'Bill No' ,o.[KOTBOTNo] ,o.[MasterBillGenerated],o.[MasterBillNo] ,o.[Paid] ,o.[ReciptNo] as Receipt ,(o.[Total]-o.discountAmount) as 'Amount',o.[RoomNo],o.[ReservationNo] ,o.[Type],'guest' as guest,'sum' as 'sum','' as balance,'' as grandTot,isnull(p.[Description],'') as 'PayType',  o.BillGeneratedDate, d.Department,''as 'GrandTotaloftheInvoices'  ,'' as 'ServiceCharge',''as 'Total',''as 'GSTTax'   ,''as 'GrandTotal' ,''as 'Discountgiven','' as Discount ,''as 'AdvancePaid',''as 'NetAmounttobesettled' , g.DepDate,g.ArriveDate,'' opdetail,'' department1,'' departmenttot ,o.OutletMasBill as OutMasNo  FROM [OutLetBillMaster] o inner join dbo.KotBotMaster k on k.Id=o.KOTBOTNo inner join  dbo.GuestRegistration g  on g.ReservationNo =o.ReservationNo  inner join dbo.DepartmentMaster d on k.Department =d.DepartmentID Collate SQL_Latin1_General_CP1_CI_AS  inner join dbo.[Room.CurrentStatus] c on  c.ReservationNo = o.ReservationNo left join [PaymentType] P on P.[PaymentTypeCode]=[PayType] where o.[MasterBillGenerated]=0 and g.IsBillingGuest =1 and o.[RoomNo] ='" & RoomNo & "' and o.ReservationNo = (select  ReservationNo from dbo.[Room.CurrentStatus] where RoomNo='" & RoomNo & "')", Conn)



            dcUnPaid = New SqlCommand("SELECT ''as 'Department1'  , ''as 'departmenttot'  , ''as 'GrandTotaloftheInvoices'  ,'' as 'ServiceCharge',''as 'Total',''as 'GSTTax'   ,''as 'GrandTotal' ,''as 'Discountgiven','' as Discount,''as 'AdvancePaid',''as 'NetAmounttobesettled', '' as DepDate, '' as ArriveDate, '' as opdetail,  '' as PayType,  '' as t , 'guest' as guest,'' as 'sum','' as balance,'' as grandTot, o.[BillNo]  as 'Bill No' ,o.[KOTBOTNo] ,o.[MasterBillGenerated],o.[MasterBillNo] ,o.[Paid] ,o.[ReciptNo] as Receipt ,(o.[Total]-o.discountAmount) as 'Amount',o.[RoomNo],o.[ReservationNo] ,o.[Type],o.BillGeneratedDate, o.Department,o.OutletMasBill as OutMasNo FROM dbo.OutLetBillMaster o INNER JOIN  dbo.Emp ON o.ReservationNo = dbo.Emp.EmpName  where o.ReservationNo='" & Empname & "' and o.MasterBillGenerated=0 and o.BillGeneratedDate >= '2015-05-01'", Conn)



            daUnpid = New SqlDataAdapter()
            daUnpid.SelectCommand = dcUnPaid
            daUnpid.Fill(dsUnPaid)
            If (Not dsUnPaid Is Nothing) Then
                GridControUnPaidBill.DataSource = dsUnPaid.Tables(0)
                Dim I As Integer
                For I = 0 To dsUnPaid.Tables(0).Rows.Count - 1
                    unPaidAmount = Double.Parse(dsUnPaid.Tables(0).Rows(I)("Amount").ToString())
                    dsUnPaid.Tables(0).Rows(I)("ReservationNo") = cbEmp.Text
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

    Private Sub cbEmp_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEmp.EditValueChanged

       

        loadmasterBillData()


        GridControl2.DataSource = Nothing


        LoadBillSumDetails()


        txtFinalTot.Text = IIf(String.IsNullOrEmpty(TextEditTotal.Text), 0, Val(TextEditTotal.Text)) - IIf(String.IsNullOrEmpty(txtdisscount.Text), 0, Val(txtdisscount.Text))

    End Sub
    Private Sub LoadBillSumDetails()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getEmp As String = cbEmp.Text.Trim

            Conn.Open()
            'dcSearch = New SqlCommand("SELECT  d.Department,sum((o.[Total]-o.discountAmount)+o.tax + o.serviceCharge) as 'Amount',max(o.[ReservationNo]) as ReservationNO ,max(g.DepDate) AS DepartureDate,max(g.ArriveDate)as ArrivalDate,max (dbo.[Reservation.Master].Topcode) as TopCode,max(dbo.[Reservation.Master].MealPlan) as MealPlan FROM  dbo.OutLetBillMaster AS o INNER JOIN  dbo.KotBotMaster AS k ON k.Id = o.KOTBOTNo INNER JOIN dbo.GuestRegistration AS g ON g.ReservationNo = o.ReservationNo INNER JOIN  dbo.DepartmentMaster AS d ON k.Department = d.DepartmentID COLLATE SQL_Latin1_General_CP1_CI_AS INNER JOIN   dbo.[Room.CurrentStatus] AS c ON c.ReservationNo = o.ReservationNo INNER JOIN  dbo.[Reservation.Master] ON g.ReservationNo = dbo.[Reservation.Master].ResNo LEFT OUTER JOIN   dbo.PaymentType AS P ON P.PaymentTypeCode = o.PayType WHERE  (o.MasterBillGenerated = 0) AND (g.IsBillingGuest = 1) AND (o.RoomNo = @Roomno) AND (o.ReservationNo =(SELECT     ReservationNo  FROM   dbo.[Room.CurrentStatus]  WHERE  (RoomNo = @Roomno))) group by   d.Department ", Conn)



            dcSearch = New SqlCommand("SELECT  o.Department,sum((o.[Total]-o.discountAmount)+o.tax + o.serviceCharge) as 'Amount' FROM dbo.OutLetBillMaster o INNER JOIN  dbo.Emp ON o.ReservationNo = dbo.Emp.EmpName where(o.Paid = 0) and (o.MasterBillGenerated = 0) AND (o.ReservationNo = @emp)  and o.BillGeneratedDate >= '2015-05-01'  group by   o.Department", Conn)


            dcSearch.Parameters.Add("@emp", SqlDbType.VarChar).Value = getEmp

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

    Private Sub loadmasterBillData()

        'TextEditGuest.Text = ""
        'LoadUserData(cbEmp.Text)

        If (String.IsNullOrEmpty(cbEmp.Text.Trim())) Then
            MsgBox("Select a valid Employee", MsgBoxStyle.Critical, "Error..")
        Else
            LoadPaid(cbEmp.Text)
        End If
    End Sub
    'Private Sub LoadUserData(ByVal RoomNo As String)
    '    Dim Conn As New SqlConnection(ConnString)
    '    Dim daMain As New SqlDataAdapter
    '    Dim dsGuest As New DataSet
    '    Dim dcSearch As New SqlCommand
    '    Try
    '        Conn.Open()
    '        'dcSearch = New SqlCommand("select c.ReservationNo,c.BillingGuest as 'GuestName' from [Guest.RegisterMaster] R inner join [Room.CurrentStatus] c on c.ReservationNo=R.ReservationNo where R.IsMasterRecord=1 and c.RoomNo='" & RoomNo & "'", Conn)
    '        dcSearch = New SqlCommand("select c.ReservationNo,c.BillingGuest as 'GuestName' from [GuestRegistration] R inner join [Room.CurrentStatus] c on c.ReservationNo=R.ReservationNo where R.IsBillingGuest=1 and c.RoomNo='" & RoomNo & "'", Conn)
    '        daMain = New SqlDataAdapter()
    '        daMain.SelectCommand = dcSearch
    '        daMain.Fill(dsGuest)
    '        If (Not dsGuest Is Nothing) Then
    '            If (dsGuest.Tables(0).Rows.Count > 0) Then
    '                If (IsDBNull(dsGuest.Tables(0).Rows(0)("GuestName"))) Then
    '                    cbEmp.Text = ""
    '                Else
    '                    cbEmp.Text = dsGuest.Tables(0).Rows(0)("GuestName")
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
    '    Finally
    '        Conn.Dispose()
    '        daMain.Dispose()
    '    End Try
    'End Sub

    Private Sub frmMasterbillStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadPayMethod()

        'dsCurrency = New DataSet()
        LoadCurrencyType()

        'dsCurrency = New DataSet()

        LoadTaxRates()


        LoadGridMasterbill()

    End Sub

    Private Sub LabelControl17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

            'While (DscountTest < Dscount)
            '    ComboBoxPayMethod.Properties.Items.Add(dsPayMethod.Tables(0).Rows(DscountTest)(0).ToString())
            '    DscountTest = DscountTest + 1
            'End While
            'ComboBoxPayMethod.SelectedIndex = 0

            DscountTest = 0
            While (DscountTest < Dscount)
                ComboBoxPayMethod.Properties.Items.Add(dsPayMethodMAster.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While
            ComboBoxPayMethod.SelectedIndex = 0
            'ComboBoxPayMethod.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            '  dsMain.Dispose()
        End Try
    End Sub
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


            'While (DscountTest < Dscount)
            '    ComboBoxEditCurrency.Properties.Items.Add(dsCurrency.Tables(0).Rows(DscountTest)("RepCurrencyCode").ToString())
            '    DscountTest = DscountTest + 1
            'End While

            DscountTest = 0
            ComboBoxEditCurrency.Properties.Items.Clear()
            While (DscountTest < Dscount)
                ComboBoxEditCurrency.Properties.Items.Add(dsCurrency.Tables(0).Rows(DscountTest)("RepCurrencyCode").ToString())
                DscountTest = DscountTest + 1
            End While

            'ComboBoxEditCurrency.SelectedIndex = 0
            ComboBoxEditCurrency.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daCurrency.Dispose()
        End Try
    End Sub

    Private Sub ComboBoxPayMethod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxPayMethod.SelectedIndexChanged
        Try
            Dim PayMethod As String = ComboBoxPayMethod.Text
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

    Private Sub txtFinalTot_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFinalTot.KeyPress
        txtFinalTot.Text = IIf(String.IsNullOrEmpty(TextEditTotal.Text), 0, Val(TextEditTotal.Text))
    End Sub

    Private Sub txtdisscount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdisscount.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.btnCreateBilling.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If


        ' txtFinalTot.Text = IIf(String.IsNullOrEmpty(TextEditTotal.Text), 0, Val(TextEditTotal.Text)) - IIf(String.IsNullOrEmpty(txtdisscount.Text), 0, Val(txtdisscount.Text))



    End Sub

    Private Sub SimpleButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCreateBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateBilling.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Master billing", "MasterBill")

        If CheckAccess = True Then

            If FieldValidation() = False Then
                MsgBox("Payment Details must be filled", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub
            Else

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
                If (tabMain.SelectedTabPageIndex <> 0) Then
                    tabMain.SelectedTabPageIndex = 0
                ElseIf (tabMain.SelectedTabPageIndex = 0) Then
                    Dim bt As DialogResult = MessageBox.Show("Do you want to generate master bill for : " & cbEmp.Text,
                                                             " Master bill Generate ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


                    If bt = Windows.Forms.DialogResult.Yes Then
                        Dim isValid As Boolean = Validate()
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

                            Dim StaffDiss As Decimal = Decimal.Parse(txtdisscount.Text)



                            If (String.IsNullOrEmpty(TextEditServiceCharges.Text)) Then
                                ServiceCharge = 0
                            Else
                                ServiceCharge = Double.Parse(TextEditServiceCharges.Text)
                            End If

                            Conn.Open()
                            dcMasterBill = New SqlCommand("genarate_masterBill_staff_SP", Conn)
                            dcMasterBill.CommandType = CommandType.StoredProcedure
                            dcMasterBill.Parameters.Add("billNo ", SqlDbType.VarChar).Value = autoid
                            dcMasterBill.Parameters.Add("OutLetbillNo", SqlDbType.VarChar).Value = billnumbers
                            dcMasterBill.Parameters.Add("taxrate", SqlDbType.Decimal).Value = taxRate
                            dcMasterBill.Parameters.Add("ServiceCharge", SqlDbType.Decimal).Value = ServiceCharge
                            dcMasterBill.Parameters.Add("CreatedBy", SqlDbType.VarChar).Value = CurrentUser
                            dcMasterBill.Parameters.Add("Empno", SqlDbType.VarChar).Value = cbEmp.EditValue.ToString()
                            dcMasterBill.Parameters.Add("EmpName", SqlDbType.VarChar).Value = cbEmp.Text.ToString()
                            dcMasterBill.Parameters.Add("StaffDiss", SqlDbType.Decimal).Value = StaffDiss


                            dcMasterBill.ExecuteNonQuery()
                            Conn.Close()

                            Dim dt As New DataTable()
                            dt = dsUnPaid.Tables(0).Clone()

                            Dim drBlank1 As DataRow = dt.NewRow()
                            drBlank1("t") = "Paid recipts"
                            drBlank1("MasterBillNo") = autoid
                            drBlank1("guest") = cbEmp.Text
                            drBlank1("RoomNo") = cmbEmpType.Text
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
                                    'dr("DepDate") = dsPaid.Tables(0).Rows(k)("BillGeneratedDate")
                                    'dr("ArriveDate") = dsPaid.Tables(0).Rows(k)("ArriveDate")
                                    dr("opdetail") = dsPaid.Tables(0).Rows(k)("opdetail")
                                    dt.Rows.Add(dr)
                                Next
                            End If

                            Dim drBlank2 As DataRow = dt.NewRow()
                            dt.Rows.Add(drBlank2)

                            Dim drBlank3 As DataRow = dt.NewRow()
                            drBlank3("MasterBillNo") = autoid
                            drBlank3("guest") = cbEmp.Text
                            drBlank3("RoomNo") = cmbEmpType.Text
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



            End If


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub LoadGridMasterbill()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from billmaster where [TYPE]='STAFF' order by billno desc", Conn)


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
        ComboBoxPayMethod.SelectedIndex = 0
    End Sub

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
        Dim currencyCode = ComboBoxEditCurrency.Text 'getCurrencyCode(billNo)
        Try

            Dim reciptNo As String = String.Empty
            Dim PayType As String = ComboBoxPayMethod.Text.Trim()

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
            dcInsertNewAccDetail.Parameters.Add("Type", SqlDbType.VarChar).Value = "Staff Master Bill"
            dcInsertNewAccDetail.Parameters.Add("Bank", SqlDbType.VarChar).Value = TextEditBankMaster.Text
            dcInsertNewAccDetail.ExecuteNonQuery()
            Conn.Close()



            drDetail = OutLetBillRecipet.NewRow()
            drDetail("BillNo") = billNo
            drDetail("Date") = DateTime.Now()
            drDetail("RoomNo") = cbEmp.EditValue.ToString()
            drDetail("ReceiptNo") = reciptNo
            drDetail("PayMethod") = getPayTypeDescriptionMaster(ComboBoxPayMethod.Text)
            drDetail("amount") = Double.Parse(TotalWithCurr)
            drDetail("GuestName") = cbEmp.Text
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

            ShowReportView(New StaffReceipt, dsOutLetBillRecipet)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            dcInsertNewAccDetail.Dispose()
        End Try
    End Sub

    Private Sub ShowReportView(ByVal reportClass As CrystalDecisions.CrystalReports.Engine.ReportClass, ByVal dataSet As System.Data.DataSet)
        Dim frmReport As New frmViewReport(reportClass, dataSet)
        frmReport.Show()
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

    Private Function getPayTypeDescriptionMaster(ByVal number As String) As String
        Try
            Dim PayMethod As String = ComboBoxPayMethod.Text
            LabelControlPayMethodMaster.Text = ""
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


    Private Sub PrintMasInv()


        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String






        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from TempMasBillStaff", Conn)

            ' dcIns.Parameters.Add("@Mbill", SqlDbType.VarChar).Value = GetPassMbilno

            'Dim CrDbno As String = txtcndn.Text.Trim

            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtcndn.Text) & "'"

            fltString = ""
            'fltString = "{rpt_dbcr_note_view.CrDbNo}='" & Trim(txtcndn.Text) & "'"




            ReportName = "MasBillPrintStaff.rpt"
            rptTitle = "Staff- Master Bill"







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
    Private Sub PrintMasInvReprint()


        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String






        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from TempMasBillStaff", Conn)

            ' dcIns.Parameters.Add("@Mbill", SqlDbType.VarChar).Value = GetPassMbilno

            'Dim CrDbno As String = txtcndn.Text.Trim

            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtcndn.Text) & "'"

            fltString = ""
            'fltString = "{rpt_dbcr_note_view.CrDbNo}='" & Trim(txtcndn.Text) & "'"




            ReportName = "MasBillPrintStaff-Reprint.rpt"
            rptTitle = "Staff- Master Bill"







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

        dcInsertNewAcc = New SqlCommand("InsertMasBillStaff_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@MasBillno", SqlDbType.VarChar).Value = GetPassMbilno

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()




    End Sub
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return Nothing
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
        End Try
    End Function
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
    Private Function getToOperatorNumber(ByVal resNumber As String) As String
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

    Private Sub btViewDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewDetails.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Master billing", "MasterBill")

        If CheckAccess = True Then


            Dim GetMasBillNo As String = gvProforma.GetRowCellValue(gvProforma.FocusedRowHandle, "BillNo")

            InsertTempMasBill(GetMasBillNo)

            PrintMasInvReprint()


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Function FieldValidation() As Boolean


        If (ComboBoxPayMethod.Text = "CH") Or (ComboBoxPayMethod.Text = "GI") Then

            Return IIf(String.Compare(ComboBoxEditCurrency.Text, "", False) = 0 Or String.Compare(ComboBoxPayMethod.Text, "", False) = 0, 0, 1)



        Else

            Return IIf(String.Compare(TextEditPayMethodNumberMater.Text, "", False) = 0 Or String.Compare(TextEditBankMaster.Text, "", False) = 0, 0, 1)

        End If




    End Function
End Class