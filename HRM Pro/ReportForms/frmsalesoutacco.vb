Imports System.Data.SqlClient
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
Public Class frmsalesoutacco

    Private Sub frmsalesoutacco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtResDate.Text = Date.Today
        dtResDate2.Text = Date.Today
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        CheckOutPutFolder()

        Try
            Conn.Open()
            dcSearch = New SqlCommand("salesoutacco_SP", Conn)
            dcSearch.CommandType = CommandType.StoredProcedure
            dcSearch.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcSearch.Parameters.Add("@tdate", SqlDbType.Date).Value = dtResDate2.DateTime.Date

            dcSearch.ExecuteNonQuery()
            Conn.Close()
            Conn.Open()
            'Make Connection ' Ammar
            ' Dim cnn As DataAccess = New DataAccess(Conn)
            ' Variable ' Ammar
            Dim i, j As Integer
            'Excel WorkBook object ' Ammar
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            ' Sheet Name or Number ' Ammar
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            ' Sql QUery ' Ammar
            '  xlWorkBook.Sheets.Select("A1:A2")
            'dcSearch = New SqlCommand("select [BillGeneratedDate],[MasterBillNo],[RoomNo],[Department],' ',' ',' ',' ',' ',' ',' ',' ',' ',[discount],[discountAmount],[tax],[serviceCharge],[Total] ,[fdate],[tdate] from tbloutletwisesale where ([BillGeneratedDate] between @fdate and @tdate) and  masterbillgenerated=1 order by [BillGeneratedDate],[MasterBillNo],RoomNo ", Conn)
            'dcSearch = New SqlCommand("select [date],[mbilno],[rno],[dep],' ',' ',' ',' ',' ',' ',' ',' ',' ',[tot],[tax],[scharge],[dis],[gtot],[fdate],[tdate] from tblmbilsum where ([date] between '2013-06-01' and '2013-06-30')  order by [Date],[mbilno],rno", Conn)
            ' last working ///dcSearch = New SqlCommand("select [date],[mbilno],[rno],[dep],0,0,0,0,0,0,0,0,0,sum([tot]),sum([tax]),sum([scharge]),sum([dis]),sum([gtot]),[fdate],[tdate] from tblmbilsum where ([date] between '2013-06-01' and '2013-06-30') group by date,mbilno ,rno ,dep,[tot],[tax],[scharge],[dis],[gtot],[fdate],[tdate]  order by [Date],[mbilno],rno", Conn)
            ' dcSearch = New SqlCommand("SELECT date, mbilno, rno, dep, mainbar, SUM(cofe) AS cofe, SUM(spa) AS Spa, SUM(res) AS res, SUM(min) AS min, SUM(staff) AS staff, SUM(bl) AS bl, SUM(misrab) AS misrab,SUM(trans) AS trans, SUM(tot) AS tot, SUM(tax) AS tax, SUM(scharge) AS scharge, SUM(dis) AS dis, SUM(gtot) AS gtot FROM  dbo.tblmbilsumxle GROUP BY date, mbilno, rno, dep, mainbar ORDER BY [date],[mbilno],rno", Conn)
            dcSearch = New SqlCommand("select moutdep,mbiltot,cashdep,cashtot from tblsalesoutacco  ", Conn)
            dcSearch.CommandType = CommandType.Text
            dcSearch.ExecuteNonQuery()
            '//dcSearch.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            ' //dcSearch.Parameters.Add("@tdate", SqlDbType.Date).Value = dtResDate2.DateTime.Date
            ' Dim dcIns As String = "SELECT * FROM tblmbilsum "
            ' SqlAdapter
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            xlWorkSheet.Cells(3, 1) = "S.No"
            xlWorkSheet.Cells(3, 2) = "Outlet"
            xlWorkSheet.Cells(3, 3) = "Master Bill US$"
            xlWorkSheet.Cells(3, 4) = "Cash US$"
            xlWorkSheet.Cells(3, 5) = "Total US$"
            xlWorkSheet.Cells(3, 6) = "Staff US$"
            xlWorkSheet.Cells(3, 7) = "PErmit/Maldi US$"
            xlWorkSheet.Cells(3, 8) = "Net Amount Taxable"
            '///outlet names
            xlWorkSheet.Cells(4, 2) = "OUTLET SALES"
            xlWorkSheet.Cells(5, 2) = "Main Bar"
            xlWorkSheet.Cells(5, 1) = "1"
            xlWorkSheet.Cells(6, 2) = "Coffee Shop"
            xlWorkSheet.Cells(6, 1) = "2"
            xlWorkSheet.Cells(7, 2) = "GardenSpa"
            xlWorkSheet.Cells(7, 1) = "3"
            xlWorkSheet.Cells(8, 2) = "MiniBar"
            xlWorkSheet.Cells(8, 1) = "4"
            xlWorkSheet.Cells(9, 2) = "mishrapshop"
            xlWorkSheet.Cells(9, 1) = "5"
            xlWorkSheet.Cells(10, 2) = "Restaurant Bar"
            xlWorkSheet.Cells(10, 1) = "6"
            xlWorkSheet.Cells(11, 2) = "Staff Kitchen"
            xlWorkSheet.Cells(11, 1) = "7"
            xlWorkSheet.Cells(12, 2) = "Transfer"
            xlWorkSheet.Cells(12, 1) = "8"
            xlWorkSheet.Cells(13, 2) = "B/L"
            xlWorkSheet.Cells(13, 1) = "9"
            xlWorkSheet.Cells(14, 2) = "Excursion"
            xlWorkSheet.Cells(14, 1) = "10"
            xlWorkSheet.Cells(15, 2) = "Water Sports"
            xlWorkSheet.Cells(15, 1) = "11"
            xlWorkSheet.Cells(16, 2) = "Snokel Rent"
            xlWorkSheet.Cells(16, 1) = "12"
            xlWorkSheet.Cells(17, 2) = "Laundry"
            xlWorkSheet.Cells(17, 1) = "13"
            xlWorkSheet.Cells(18, 2) = "Misc.Office"
            xlWorkSheet.Cells(18, 1) = "15"
            xlWorkSheet.Cells(19, 2) = "FIT Accommodation"
            xlWorkSheet.Cells(19, 1) = "16"
            xlWorkSheet.Cells(20, 2) = "FIT Transfer"
            xlWorkSheet.Cells(20, 1) = "15"
            xlWorkSheet.Cells(21, 2) = "Bed Tax"
            xlWorkSheet.Cells(21, 1) = "17"
            xlWorkSheet.Cells(22, 2) = "Discount Given"
            xlWorkSheet.Cells(22, 1) = "18"
            xlWorkSheet.Cells(23, 2) = "Service Charge"
            xlWorkSheet.Cells(23, 1) = "19"
            xlWorkSheet.Cells(24, 2) = "Total:"
            xlWorkSheet.Cells(25, 2) = "GST"
            xlWorkSheet.Cells(27, 2) = "INCOME SHARING"
            ' /// SAME LINE INE INCOME SHARING
            xlWorkSheet.Cells(27, 4) = "Share to pary"
            xlWorkSheet.Cells(27, 5) = "GST to Party"
            xlWorkSheet.Cells(27, 6) = "GST to ERI"
            xlWorkSheet.Cells(28, 1) = "1"
            xlWorkSheet.Cells(29, 1) = "2"
            '///
            xlWorkSheet.Cells(28, 2) = "Misraab Shop(with GST)"
            xlWorkSheet.Cells(29, 2) = "Total Dive with GST"
            xlWorkSheet.Cells(33, 2) = "ACCOMMODATION /TRANSFER"
            '//under accommodation /transfer
            xlWorkSheet.Cells(34, 3) = "Total Amount"
            xlWorkSheet.Cells(34, 4) = "Bed Tax"
            xlWorkSheet.Cells(34, 5) = "S/C"
            xlWorkSheet.Cells(34, 6) = "Permit"
            xlWorkSheet.Cells(34, 7) = "GST"
            xlWorkSheet.Cells(34, 8) = "Net Taxable Amt"
            '///
            xlWorkSheet.Cells(35, 2) = "Invoice"
            xlWorkSheet.Cells(39, 1) = "Total"
            xlWorkSheet.Cells(42, 1) = "Abstract"
            xlWorkSheet.Cells(42, 6) = "Total Sales"
            xlWorkSheet.Cells(43, 1) = "Total Sales"
            xlWorkSheet.Cells(44, 1) = "Less Staff"
            xlWorkSheet.Cells(45, 1) = "Maldivian/Permit Holder"
            xlWorkSheet.Cells(46, 1) = "Bed Tax"
            xlWorkSheet.Cells(47, 1) = "Service Charge"
            xlWorkSheet.Cells(49, 1) = "Total Sales after set off"
            xlWorkSheet.Cells(44, 5) = "TOTAL T-GST Calculated @ 8%"
            xlWorkSheet.Cells(45, 5) = "Less GST Misraab shop"
            xlWorkSheet.Cells(46, 5) = "Less Euro Drivers GST Liability"
            xlWorkSheet.Cells(47, 5) = "GST Payable"


            'xlWorkSheet.Cells(3, 9) = "Mini Bar"
            ' xlWorkSheet.Cells(3, 10) = "Staff Kitchen"
            'xlWorkSheet.Cells(3, 11) = "B/L"
            'xlWorkSheet.Cells(3, 12) = "mishrapshop"
            ' xlWorkSheet.Cells(3, 13) = "Transfer"
            'xlWorkSheet.Cells(3, 14) = "Total"
            'xlWorkSheet.Cells(3, 15) = "Tax"
            ' xlWorkSheet.Cells(3, 16) = "Service Charge"
            ' xlWorkSheet.Cells(3, 17) = "Discount"
            ' xlWorkSheet.Cells(3, 18) = "Grand Total"

            For i = 0 To dsMain.Tables(0).Rows.Count - 1
                'Column
                For j = 0 To dsMain.Tables(0).Columns.Count - 1
                    ' this i change to header line cells >>>
                    If dsMain.Tables(0).Rows(i).Item(0) = "Main Bar" Then
                        xlWorkSheet.Cells(5, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "Coffee Shop" Then
                        xlWorkSheet.Cells(6, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "GardenSpa" Then
                        xlWorkSheet.Cells(7, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "MiniBar" Then
                        xlWorkSheet.Cells(8, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "mishrapshop" Then
                        xlWorkSheet.Cells(9, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "Restaurant Bar" Then
                        xlWorkSheet.Cells(10, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "Staff Kitchen" Then
                        xlWorkSheet.Cells(11, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "Transfer" Then
                        xlWorkSheet.Cells(12, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "B/L" Then
                        xlWorkSheet.Cells(13, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "Excursion" Then
                        xlWorkSheet.Cells(13, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "Water Sports" Then
                        xlWorkSheet.Cells(13, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "Snokel Rent" Then
                        xlWorkSheet.Cells(13, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "Laundry" Then
                        xlWorkSheet.Cells(13, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "FIT Accommodation" Then
                        xlWorkSheet.Cells(13, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "FIT Transfer" Then
                        xlWorkSheet.Cells(13, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "Bed Tax" Then
                        xlWorkSheet.Cells(13, 3) = dsMain.Tables(0).Rows(i).Item(1)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "Discount Given" Then
                        xlWorkSheet.Cells(13, 3) = dsMain.Tables(0).Rows(i).Item(1)

                    End If
                    If dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "Main Bar" Then
                        xlWorkSheet.Cells(5, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "Coffee Shop" Then
                        xlWorkSheet.Cells(6, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "GardenSpa" Then
                        xlWorkSheet.Cells(7, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "MiniBar" Then
                        xlWorkSheet.Cells(8, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "mishrapshop" Then
                        xlWorkSheet.Cells(9, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "Restaurant Bar" Then
                        xlWorkSheet.Cells(10, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "Staff Kitchen" Then
                        xlWorkSheet.Cells(11, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "Transfer" Then
                        xlWorkSheet.Cells(12, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "B/L" Then
                        xlWorkSheet.Cells(13, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "Excursion" Then
                        xlWorkSheet.Cells(14, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "Water Sports" Then
                        xlWorkSheet.Cells(15, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "Snokel Rent" Then
                        xlWorkSheet.Cells(16, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "Laundry" Then
                        xlWorkSheet.Cells(17, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "FIT Accommodation" Then
                        xlWorkSheet.Cells(18, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "FIT Transfer" Then
                        xlWorkSheet.Cells(19, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "Bed Tax" Then
                        xlWorkSheet.Cells(20, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "cash" And dsMain.Tables(0).Rows(i).Item(2) = "Discount Given" Then
                        xlWorkSheet.Cells(21, 4) = dsMain.Tables(0).Rows(i).Item(3)
                    ElseIf dsMain.Tables(0).Rows(i).Item(0) = "inv" Then
                        xlWorkSheet.Cells(35, 3) = dsMain.Tables(0).Rows(i).Item(2)
                        xlWorkSheet.Cells(35, 4) = dsMain.Tables(0).Rows(i).Item(3)

                    End If
                    'xlWorkSheet.Cells(i + 5, j + 2) = dsMain.Tables(0).Rows(i).Item(j)
                Next
            Next

            'HardCode in Excel sheet
            ' this i change to footer line cells  >>>
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 10)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 10)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(33, 2), xlWorkSheet.Cells(33, 3)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(43, 1), xlWorkSheet.Cells(43, 2)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(44, 1), xlWorkSheet.Cells(44, 2)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(45, 1), xlWorkSheet.Cells(45, 2)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(46, 1), xlWorkSheet.Cells(46, 2)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(47, 1), xlWorkSheet.Cells(47, 2)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(44, 5), xlWorkSheet.Cells(44, 6)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(45, 5), xlWorkSheet.Cells(45, 6)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(46, 5), xlWorkSheet.Cells(46, 6)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(47, 5), xlWorkSheet.Cells(47, 6)).Merge()
            xlWorkSheet.Cells(1, 1) = "ERIYADU ISLAND RESORT"
            xlWorkSheet.Cells(2, 1) = "SALES OUTLETS/ ACCOMODATION REPORT FROM " & CDate(dtResDate.DateTime.Date) & Chr(13) & " TO " & CDate(dtResDate2.DateTime.Date)

            '  xlWorkSheet.Cells(i + 5, 2) = "Total"
            '//total
            xlWorkSheet.Range(xlWorkSheet.Cells(5, 3), xlWorkSheet.Cells(50, 8)).NumberFormat = "#,##0.00"

            xlWorkSheet.Cells.Item(5, 5) = "=SUM(C5:D5)"
            xlWorkSheet.Cells.Item(6, 5) = "=SUM(C6:D6)"
            xlWorkSheet.Cells.Item(7, 5) = "=SUM(C7:D7)"
            xlWorkSheet.Cells.Item(8, 5) = "=SUM(C8:D8)"
            xlWorkSheet.Cells.Item(9, 5) = "=SUM(C9:D9)"
            xlWorkSheet.Cells.Item(10, 5) = "=SUM(C10:D10)"
            xlWorkSheet.Cells.Item(11, 5) = "=SUM(C11:D11)"
            xlWorkSheet.Cells.Item(12, 5) = "=SUM(C12:D12)"
            xlWorkSheet.Cells.Item(13, 5) = "=SUM(C13:D13)"
            xlWorkSheet.Cells.Item(14, 5) = "=SUM(C14:D14)"
            xlWorkSheet.Cells.Item(15, 5) = "=SUM(C15:D15)"
            xlWorkSheet.Cells.Item(16, 5) = "=SUM(C16:D16)"
            xlWorkSheet.Cells.Item(17, 5) = "=SUM(C17:D17)"
            xlWorkSheet.Cells.Item(18, 5) = "=SUM(C18:D18)"
            xlWorkSheet.Cells.Item(19, 5) = "=SUM(C19:D19)"
            xlWorkSheet.Cells.Item(20, 5) = "=SUM(C20:D20)"
            xlWorkSheet.Cells.Item(21, 5) = "=SUM(C21:D21)"
            xlWorkSheet.Cells.Item(22, 5) = "=SUM(C22:D22)"
            '//net amount
            xlWorkSheet.Cells.Item(5, 8) = "=SUM(C5:G5)"
            xlWorkSheet.Cells.Item(6, 8) = "=SUM(C6:G6)"
            xlWorkSheet.Cells.Item(7, 8) = "=SUM(C7:G7)"
            xlWorkSheet.Cells.Item(8, 8) = "=SUM(C8:G8)"
            xlWorkSheet.Cells.Item(9, 8) = "=SUM(C9:G9)"
            xlWorkSheet.Cells.Item(10, 8) = "=SUM(C10:G10)"
            xlWorkSheet.Cells.Item(11, 8) = "=SUM(C11:G11)"
            xlWorkSheet.Cells.Item(12, 8) = "=SUM(C12:G12)"
            xlWorkSheet.Cells.Item(13, 8) = "=SUM(C13:G13)"
            xlWorkSheet.Cells.Item(14, 8) = "=SUM(C14:G14)"
            xlWorkSheet.Cells.Item(15, 8) = "=SUM(C15:G15)"
            xlWorkSheet.Cells.Item(16, 8) = "=SUM(C16:G16)"
            xlWorkSheet.Cells.Item(17, 8) = "=SUM(C17:G17)"
            xlWorkSheet.Cells.Item(18, 8) = "=SUM(C18:G18)"
            xlWorkSheet.Cells.Item(19, 8) = "=SUM(C19:G19)"
            xlWorkSheet.Cells.Item(20, 8) = "=SUM(C20:G20)"
            xlWorkSheet.Cells.Item(21, 8) = "=SUM(C21:G21)"
            xlWorkSheet.Cells.Item(22, 8) = "=SUM(C22:G22)"

            ' xlWorkSheet.Cells.Item(23, 5) = "=SUM(C22:D22)"
            ' xlWorkSheet.Cells.Item(24, 5) = "=SUM(C23:D23)"
            'xlWorkSheet.Cells.Item(25, 5) = "=SUM(C24:D24)"
            ' xlWorkSheet.Cells.Item(26, 5) = "=SUM(C25:D25)"
            'xlWorkSheet.Cells.Item(8, 5) = "=SUM(C9:D9)"
            ' xlWorkSheet.Cells.Item(8, 5) = "=SUM(C9:D9)"
            ' xlWorkSheet.Cells.Item(8, 5) = "=SUM(C9:D9)"
            ' xlWorkSheet.Cells.Item(8, 5) = "=SUM(C9:D9)"
            ' xlWorkSheet.Cells.Item(8, 5) = "=SUM(C9:D9)"

            ' //CERVICE CHARGE
            xlWorkSheet.Cells.Item(23, 3) = "=(SUM(C5:C21)-C22)*10/100"

            xlWorkSheet.Cells.Item(23, 4) = "=(SUM(D5:D21)-D22)*10/100"
            xlWorkSheet.Cells.Item(23, 5) = "=(SUM(E5:E21)-E22)*10/100"
            xlWorkSheet.Cells.Item(23, 6) = "=(SUM(F5:F21)-F22)*10/100"
            xlWorkSheet.Cells.Item(23, 7) = "=(SUM(G5:G21)-G22)*10/100"
            xlWorkSheet.Cells.Item(23, 8) = "=(SUM(H5:H21)-H22)*10/100"
            ' //TOTAL + SERVICE CHAGER
            xlWorkSheet.Cells.Item(24, 3) = "=SUM(C5:C22)"
            xlWorkSheet.Cells.Item(24, 4) = "=SUM(D5:D22)"
            xlWorkSheet.Cells.Item(24, 5) = "=SUM(E5:E22)"
            xlWorkSheet.Cells.Item(24, 6) = "=SUM(F5:F22)"
            xlWorkSheet.Cells.Item(24, 7) = "=SUM(G5:G22)"
            xlWorkSheet.Cells.Item(24, 8) = "=SUM(H5:H22)"
            ' //GST *%
            xlWorkSheet.Cells.Item(25, 3) = "=(C24*8)/100"
            xlWorkSheet.Cells.Item(25, 4) = "=(D24*8)/100"
            xlWorkSheet.Cells.Item(25, 5) = "=(E24*8)/100"
            xlWorkSheet.Cells.Item(25, 6) = "=(F24*8)/100"
            xlWorkSheet.Cells.Item(25, 7) = "=(G24*8)/100"
            xlWorkSheet.Cells.Item(25, 8) = "=(H24*8)/100"
            ' TOTAL SERVICE CHARGE+ GST
            xlWorkSheet.Cells.Item(26, 3) = "=SUM(C24:C25)"
            xlWorkSheet.Cells.Item(26, 4) = "=SUM(D24:D25)"
            xlWorkSheet.Cells.Item(26, 5) = "=SUM(E24:E25)"
            xlWorkSheet.Cells.Item(26, 6) = "=SUM(F24:F25)"
            xlWorkSheet.Cells.Item(26, 7) = "=SUM(G24:G25)"
            xlWorkSheet.Cells.Item(26, 8) = "=SUM(H24:H25)"
            xlWorkSheet.Range("A3", "H3").Font.Bold = True
            xlWorkSheet.Range("C26", "H26").Font.Bold = True
            xlWorkSheet.Range("B27", "F27").Font.Bold = True
            xlWorkSheet.Range("B27", "F27").Font.Underline = True
            xlWorkSheet.Range("B4", "B4").Font.Underline = True
            xlWorkSheet.Range("B4", "B4").Font.Bold = True
            xlWorkSheet.Range("A39", "H39").Font.Bold = True
            xlWorkSheet.Range("A42", "H42").Font.Bold = True
            xlWorkSheet.Range("a42", "a42").Font.Underline = True
            xlWorkSheet.Range("A49", "D49").Font.Bold = True
            xlWorkSheet.Range("E44", "H44").Font.Bold = True
            xlWorkSheet.Range("E47", "H44").Font.Bold = True
            xlWorkSheet.Range("H46", "H46").Font.Underline = True
            xlWorkSheet.Range("c26", "H26").Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = LineStyle.SingleLine
            xlWorkSheet.Range("c26", "H26").Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = LineStyle.DoubleLine
            xlWorkSheet.Range("A31", "H31").Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = LineStyle.SingleLine
            xlWorkSheet.Range("A31", "H31").Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = LineStyle.SingleLine
            xlWorkSheet.Range("A39", "H39").Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = LineStyle.SingleLine
            xlWorkSheet.Range("A39", "H39").Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = LineStyle.SingleLine
            '//INCOME SHARING TOTA AFTER MANUL ENTER DIVE AND MASHRIB SHOP
            xlWorkSheet.Cells.Item(31, 3) = "=SUM(C28:C29)"
            xlWorkSheet.Cells.Item(31, 8) = "=SUM(H26:H26)"
            xlWorkSheet.Cells.Item(39, 3) = "=SUM(c35:c35)"
            xlWorkSheet.Cells.Item(39, 4) = "=SUM(d35:d35)"
            xlWorkSheet.Cells.Item(39, 5) = "=SUM(e35:e35)"
            xlWorkSheet.Cells.Item(39, 6) = "=SUM(f35:f35)"
            xlWorkSheet.Cells.Item(39, 7) = "=SUM(e35:e35)"

            xlWorkSheet.Cells.Item(39, 8) = "=C39-D39"
            xlWorkSheet.Cells.Item(35, 8) = "=C35-D35"

            xlWorkSheet.Cells.Item(42, 8) = "=C31+H26+H39"
            xlWorkSheet.Cells.Item(43, 3) = "=E26+C31+C39"
            xlWorkSheet.Cells.Item(44, 3) = "=g26"

            xlWorkSheet.Cells.Item(45, 3) = "=-(g26+f39)"
            xlWorkSheet.Cells.Item(46, 3) = "=-d35"
            xlWorkSheet.Cells.Item(49, 3) = "=SUM(c43:c47)"
            xlWorkSheet.Cells.Item(44, 8) = "=(h42/108)*8"
            xlWorkSheet.Cells.Item(45, 8) = "=-e28"
            xlWorkSheet.Cells.Item(46, 8) = "=-e29"
            xlWorkSheet.Cells.Item(47, 8) = "=SUM(h44:h46)"

            ' xlWorkSheet.Cells.Item(i + 5, 6) = "=SUM(f2:f" & i & ")"
            ' xlWorkSheet.Cells.Item(i + 5, 7) = "=SUM(g2:g" & i & ")"
            '  xlWorkSheet.Cells.Item(i + 5, 8) = "=SUM(h2:h" & i & ")"
            ' xlWorkSheet.Cells.Item(i + 5, 9) = "=SUM(i2:i" & i & ")"
            '  xlWorkSheet.Cells.Item(i + 5, 10) = "=SUM(j2:j" & i & ")"
            '  xlWorkSheet.Cells.Item(i + 5, 11) = "=SUM(k2:k" & i & ")"
            '  xlWorkSheet.Cells.Item(i + 5, 12) = "=SUM(l2:l" & i & ")"
            '  xlWorkSheet.Cells.Item(i + 5, 13) = "=SUM(m2:m" & i & ")"
            '  xlWorkSheet.Cells.Item(i + 5, 14) = "=SUM(n2:n" & i & ")"
            ' xlWorkSheet.Cells.Item(i + 5, 15) = "=SUM(o2:o" & i & ")"
            ' xlWorkSheet.Cells.Item(i + 5, 16) = "=SUM(o2:p" & i & ")"
            ' xlWorkSheet.Cells.Item(i + 5, 17) = "=SUM(q2:q" & i & ")"
            ' xlWorkSheet.Cells.Item(i + 5, 18) = "=SUM(r2:r" & i & ")"
            xlWorkBook.ActiveSheet.Columns.AutoFit()
            If System.IO.File.Exists(Path.Combine(Application.StartupPath & "\SalesoutletaccoReports\" & "Salesoutletacco-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx")) = False Then
                xlWorkSheet.SaveAs(Path.Combine(Application.StartupPath & "\SalesoutletaccoReports\" & "Salesoutletacco-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))
                ' xlApp.Workbooks.Open(Path.Combine(Application.StartupPath & "\SalesoutletaccoReports\" & "Salesoutletacco-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))
                xlWorkBook.Close()
                xlApp.Quit()
                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)
                ' xlApp.Workbooks.Open(Path.Combine(Application.StartupPath & "\SalesoutletaccoReports\" & "Salesoutletacco-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))

                'Msg Box of Excel Sheet Path
                MsgBox("The " & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx" & " saved in " & vbCrLf & Application.StartupPath & "\SalesoutletaccoReports\")
                'xlApp.Workbooks.Open(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))

            Else
                Dim respond As String = MsgBox("The " & "Salesoutletacco-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx" & " Found in " & vbCrLf & Application.StartupPath & "\SalesoutletaccoReports\" & vbCrLf & "Do You want Save a copy? ", vbYesNo, vbInformation)
                If respond = vbYes Then
                    xlWorkSheet.SaveAs(Path.Combine(Application.StartupPath & "\SalesoutletaccoReports\" & "Salesoutletacco-" & dtResDate.DateTime.Date.ToString("MMMM") & "copy.xlsx"))
                    xlWorkBook.Close()
                    xlApp.Quit()
                    releaseObject(xlApp)
                    releaseObject(xlWorkBook)
                    releaseObject(xlWorkSheet)
                Else
                    Exit Sub

                End If
            End If

        Catch ex As Exception

        End Try

    End Sub


    ' Function of Realease Object in Excel Sheet
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub CheckOutPutFolder()
        Try
            If New System.IO.DirectoryInfo(Path.Combine(Application.StartupPath, "SalesoutletaccoReports")).Exists = False Then
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "SalesoutletaccoReports"))
            End If
        Catch ex As Exception
        End Try
    End Sub


End Class