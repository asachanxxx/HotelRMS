Imports System.Data.SqlClient
Imports System.Data
Public Class frmmonthlycomEMP

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

            dcInsertNewAcc = New SqlCommand("monthlycomEMP_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date

            dcInsertNewAcc.ExecuteNonQuery()

            'fltString = " {BillMaster.Date} >='" & dtResDate.DateTime.Date & "' and {BillMaster.Date} <='" & todate.DateTime.Date & "' "
            'fltString = "Month({View_1Birthday_Report.DOB}) = " & bdayMonth & " And Day({View_1Birthday_Report.DOB}) =" & bdayday & " Between Month({View_1Birthday_Report.DOB}) = " & tomonth & " And Day({View_1Birthday_Report.DOB}) =" & today & """"
            'fltString = "{rpt_House_Count_Report_View.ResDate} >=#" & dtResDate.Text & "# and {rpt_House_Count_Report_View.ResDate}<=#" & dtResDate2.Text & "# "

            Conn.Close()

            ' ReportName = "rptmasterbillsum.rpt"
            ReportName = "rptmonthlycomEMP.rpt"
            rptTitle = "COMPLIMENTARY Report FOR Employee"
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
End Class