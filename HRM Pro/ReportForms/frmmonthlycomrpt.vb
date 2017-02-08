Imports System.Data.SqlClient
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit

Public Class frmmonthlycomrpt

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        Dim bdayMonth As Integer = dtResDate.DateTime.Date.Month
        Dim bdayday As Integer = dtResDate.DateTime.Date.Day
        Dim tomonth As Integer = todate.DateTime.Date.Month
        Dim today As Integer = todate.DateTime.Date.Day



        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        Dim fltString As String

        Try

            Conn.Open()

            '  dcIns = New SqlCommand("select * from billmaster where BillMaster.Date between @bilfdate and @biltdate", Conn)
            ' dcIns.Parameters.Add("@bilfdate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date.ToString
            'dcIns.Parameters.Add("@biltdate", SqlDbType.DateTime).Value = todate.DateTime.Date.ToString

            dcInsertNewAcc = New SqlCommand("monthlycomrpt_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date

            dcInsertNewAcc.ExecuteNonQuery()

            'fltString = " {BillMaster.Date} >='" & dtResDate.DateTime.Date & "' and {BillMaster.Date} <='" & todate.DateTime.Date & "' "
            'fltString = "Month({View_1Birthday_Report.DOB}) = " & bdayMonth & " And Day({View_1Birthday_Report.DOB}) =" & bdayday & " Between Month({View_1Birthday_Report.DOB}) = " & tomonth & " And Day({View_1Birthday_Report.DOB}) =" & today & """"
            'fltString = "{rpt_House_Count_Report_View.ResDate} >=#" & dtResDate.Text & "# and {rpt_House_Count_Report_View.ResDate}<=#" & dtResDate2.Text & "# "

            Conn.Close()

            ' ReportName = "rptmasterbillsum.rpt"
            ReportName = "rptmonthlycomrpt.rpt"
            rptTitle = "COMPLIMENTARY Report"
            ''  fltString = ""
            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            ''frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1


            'frmReportViewer.paraRepName = ""
            ' frmReportViewer.paraRepVale = ""

            frmReportViewer.paraRepName = "fromDate"
            frmReportViewer.paraRepVale = dtResDate.Text.ToString

            frmReportViewer.paraRepName2 = "toDate"
            frmReportViewer.paraRepVale2 = todate.Text.ToString

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            '  Conn.Dispose()
            '  dcIns.Dispose()


        End Try
    End Sub

    Private Sub frmmasterbilsum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtResDate.Text = Date.Today
        todate.Text = Date.Today
    End Sub

    Private Sub btnxle_Click(sender As Object, e As EventArgs) Handles btnxle.Click
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        CheckOutPutFolder()

        Try
            Conn.Open()
            dcSearch = New SqlCommand("mbilsumxle_SP", Conn)
            dcSearch.CommandType = CommandType.StoredProcedure
            dcSearch.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcSearch.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date

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
            dcSearch = New SqlCommand("SELECT date, mbilno, rno, dep, mainbar, SUM(cofe) AS cofe, SUM(spa) AS Spa, SUM(res) AS res, SUM(min) AS min, SUM(staff) AS staff, SUM(bl) AS bl, SUM(misrab) AS misrab,SUM(trans) AS trans, SUM(tot) AS tot, SUM(tax) AS tax, SUM(scharge) AS scharge, SUM(dis) AS dis, SUM(gtot) AS gtot FROM  dbo.tblmbilsumxle GROUP BY date, mbilno, rno, dep, mainbar ORDER BY [date],[mbilno],rno", Conn)
            dcSearch.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcSearch.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date
            ' Dim dcIns As String = "SELECT * FROM tblmbilsum "
            ' SqlAdapter
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            xlWorkSheet.Cells(3, 1) = "Date"
            xlWorkSheet.Cells(3, 2) = "Master Bill No"
            xlWorkSheet.Cells(3, 3) = "Room No"
            xlWorkSheet.Cells(3, 4) = "Department"
            xlWorkSheet.Cells(3, 5) = "Main Bar"
            xlWorkSheet.Cells(3, 6) = "Coffee Shop"
            xlWorkSheet.Cells(3, 7) = "GardenSpa"
            xlWorkSheet.Cells(3, 8) = "Restaurant Bar"
            xlWorkSheet.Cells(3, 9) = "Mini Bar"
            xlWorkSheet.Cells(3, 10) = "Staff Kitchen"
            xlWorkSheet.Cells(3, 11) = "B/L"
            xlWorkSheet.Cells(3, 12) = "mishrapshop"
            xlWorkSheet.Cells(3, 13) = "Transfer"
            xlWorkSheet.Cells(3, 14) = "Total"
            xlWorkSheet.Cells(3, 15) = "Tax"
            xlWorkSheet.Cells(3, 16) = "Service Charge"
            xlWorkSheet.Cells(3, 17) = "Discount"
            xlWorkSheet.Cells(3, 18) = "Grand Total"

            For i = 0 To dsMain.Tables(0).Rows.Count - 1
                'Column
                For j = 0 To dsMain.Tables(0).Columns.Count - 1
                    ' this i change to header line cells >>>
                    If dsMain.Tables(0).Rows(i).Item(3) = "Main Bar" Then
                        xlWorkSheet.Cells(i + 4, 5) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Coffee Shop" Then
                        xlWorkSheet.Cells(i + 4, 6) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "GardenSpa" Then
                        xlWorkSheet.Cells(i + 4, 7) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Restaurant Bar" Then
                        xlWorkSheet.Cells(i + 4, 8) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Mini Bar" Then
                        xlWorkSheet.Cells(i + 4, 9) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Staff Kitchen" Then
                        xlWorkSheet.Cells(i + 4, 10) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "B/L" Then
                        xlWorkSheet.Cells(i + 4, 11) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "mishrapshop" Then
                        xlWorkSheet.Cells(i + 4, 12) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Transfer" Then
                        xlWorkSheet.Cells(i + 4, 13) = dsMain.Tables(0).Rows(i).Item(13)
                    End If
                    xlWorkSheet.Cells(i + 4, j + 1) = dsMain.Tables(0).Rows(i).Item(j)
                Next
            Next

            'HardCode in Excel sheet
            ' this i change to footer line cells  >>>
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 10)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 10)).Merge()
            xlWorkSheet.Cells(1, 1) = "ERIYADU ISLAND RESORT"
            xlWorkSheet.Cells(2, 1) = "MASTER BILL COLLECTION FROM " & CDate(dtResDate.DateTime.Date) & Chr(13) & " TO " & CDate(todate.DateTime.Date)

            xlWorkSheet.Cells(i + 5, 2) = "Total"
            xlWorkSheet.Cells.Item(i + 5, 5) = "=SUM(e2:e" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 6) = "=SUM(f2:f" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 7) = "=SUM(g2:g" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 8) = "=SUM(h2:h" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 9) = "=SUM(i2:i" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 10) = "=SUM(j2:j" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 11) = "=SUM(k2:k" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 12) = "=SUM(l2:l" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 13) = "=SUM(m2:m" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 14) = "=SUM(n2:n" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 15) = "=SUM(o2:o" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 16) = "=SUM(o2:p" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 17) = "=SUM(q2:q" & i & ")"
            xlWorkSheet.Cells.Item(i + 5, 18) = "=SUM(r2:r" & i & ")"
            xlWorkBook.ActiveSheet.Columns.AutoFit()
            If System.IO.File.Exists(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx")) = False Then
                xlWorkSheet.SaveAs(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))
                xlApp.Workbooks.Open(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))
                xlWorkBook.Close()
                xlApp.Quit()
                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                'Msg Box of Excel Sheet Path
                MsgBox("The " & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx" & " saved in " & vbCrLf & Application.StartupPath & "\MasterBillReports\")
                'xlApp.Workbooks.Open(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))

            Else
                Dim respond As String = MsgBox("The " & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx" & " Found in " & vbCrLf & Application.StartupPath & "\MasterBillReports\" & vbCrLf & "Do You want Save a copy? ", vbYesNo, vbInformation)
                If respond = vbYes Then
                    xlWorkSheet.SaveAs(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & "copy.xlsx"))
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
            If New System.IO.DirectoryInfo(Path.Combine(Application.StartupPath, "MasterBillReports")).Exists = False Then
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "MasterBillReports"))
            End If
        Catch ex As Exception
        End Try
    End Sub



End Class