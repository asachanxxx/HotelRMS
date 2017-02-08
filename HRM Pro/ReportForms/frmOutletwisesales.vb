Imports System.Data.SqlClient
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmOutletwisesales

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        '' Dim Conn As New SqlConnection(ConnString)
        '' Dim sqlString As String
        '' Dim dcIns As New SqlCommand()
        '' Dim daMain As New SqlDataAdapter()
        '' Dim dsMain As New DataSet
        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        Dim fltString As String

        Try

            Conn.Open()

            ''dcIns = New SqlCommand("select * from rpt_Outletwise_sales", Conn)
            '' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text
            dcInsertNewAcc = New SqlCommand("outletwisesale_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@fdate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@tdate", SqlDbType.DateTime).Value = dtDate2.DateTime.Date

            ' dcIns.CommandType = CommandType.Text
            ''dcIns.ExecuteNonQuery()
            dcInsertNewAcc.ExecuteNonQuery()


            'fltString = ""
            ' fltString = "{rpt_Operator_Wise_Performa_Invoice_Breakup_Report_View.ProInvDate} >=#" & dtDate.Text & "# and {rpt_Operator_Wise_Performa_Invoice_Breakup_Report_View.ProInvDate}<=#" & dtDate2.Text & "# "
            ' fltString = "{rpt_Outletwise_sales.BillGeneratedDate}>=#" & dtDate.Text & "# and {rpt_Outletwise_sales.BillGeneratedDate}<=#" & dtDate2.Text & "#"



            ReportName = "rptoutletwisesale.rpt"
            rptTitle = "Outletwise_Sales_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            ' frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            ' frmReportViewer.paraRepName = "fromDate"
            ' frmReportViewer.paraRepVale = dtDate.Text.ToString

            'frmReportViewer.paraRepName2 = "toDate"
            ' frmReportViewer.paraRepVale2 = dtDate2.Text.ToString


            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub frmOutletwisesales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtDate.Text = Date.Today
        dtDate2.Text = Date.Today
    End Sub

    Private Sub btnxle_Click(sender As Object, e As EventArgs) Handles btnxle.Click
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
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
            dcSearch = New SqlCommand("select [BillGeneratedDate],[MasterBillNo],[RoomNo],[Department],' ',' ',' ',' ',' ',[discount],[discountAmount],[tax],[serviceCharge],[Total] ,[fdate],[tdate] from tbloutletwisesale where masterbillgenerated=1", Conn)

            ' Dim dcIns As String = "SELECT * FROM tblmbilsum "
            ' SqlAdapter
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            ''Dim dscmd As New SqlDataAdapter(Sql, Conn.ConnectionString)
            ' DataSet
            '' Dim ds As New DataSet
            ''dscmd.Fill(dsMain)
            'COLUMN NAME ADD IN EXCEL SHEET OR HEADING 
            ''  xlWorkSheet.Cells(1, 1).Value = "First Name"
            '' xlWorkSheet.Cells(1, 2).Value = "Last Name"
            ''  xlWorkSheet.Cells(1, 3).Value = "Full Name"
            '' xlWorkSheet.Cells(1, 4).Value = "Salary"
            ' SQL Table Transfer to Excel
            xlWorkSheet.Cells(1, 1) = "Date"
            xlWorkSheet.Cells(1, 2) = "Master Bill No"
            xlWorkSheet.Cells(1, 3) = "Room No"
            xlWorkSheet.Cells(1, 4) = "Department"
            xlWorkSheet.Cells(1, 5) = "Main Bar"
            xlWorkSheet.Cells(1, 6) = "Coffee Shop"
            xlWorkSheet.Cells(1, 7) = "GardenSpa"
            xlWorkSheet.Cells(1, 8) = "Restaurant Bar"
            xlWorkSheet.Cells(1, 9) = "Restaurant Bar"
            xlWorkSheet.Cells(1, 10) = "Discount"
            xlWorkSheet.Cells(1, 11) = "Discount Amount"
            xlWorkSheet.Cells(1, 12) = "Tax"
            xlWorkSheet.Cells(1, 13) = "Service Charge"
            xlWorkSheet.Cells(1, 14) = "Total"

            For i = 0 To dsMain.Tables(0).Rows.Count - 1
                'Column
                For j = 0 To dsMain.Tables(0).Columns.Count - 1
                    ' this i change to header line cells >>>
                    If dsMain.Tables(0).Rows(i).Item(3) = "Main Bar" Then
                        xlWorkSheet.Cells(i + 2, 5) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Coffee Shop" Then
                        xlWorkSheet.Cells(i + 2, 6) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "GardenSpa" Then
                        xlWorkSheet.Cells(i + 2, 7) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Restaurant Bar" Then
                        xlWorkSheet.Cells(i + 2, 8) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Restaurant Bar" Then
                        xlWorkSheet.Cells(i + 2, 9) = dsMain.Tables(0).Rows(i).Item(13)
                    End If
                    xlWorkSheet.Cells(i + 2, j + 1) = dsMain.Tables(0).Rows(i).Item(j)
                Next
            Next
            'HardCode in Excel sheet
            ' this i change to footer line cells  >>>
            xlWorkSheet.Cells(i + 3, 7) = "Total"
            xlWorkSheet.Cells.Item(i + 3, 8) = "=SUM(H2:H18)"
            ' Save as path of excel sheet
            xlWorkSheet.SaveAs("D:\vbexcel.xlsx")
            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            'Msg Box of Excel Sheet Path
            MsgBox("You can find the file D:\vbexcel.xlsx")
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
End Class
