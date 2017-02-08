Imports System.Data.SqlClient
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit

Public Class frmmonthlycomother

    Private Sub frmmonthlycomother_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtResDate.Text = Date.Today
        todate.Text = Date.Today
    End Sub

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

            

            dcInsertNewAcc = New SqlCommand("monthlycomother_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date

            dcInsertNewAcc.ExecuteNonQuery()

            'fltString = " {BillMaster.Date} >='" & dtResDate.DateTime.Date & "' and {BillMaster.Date} <='" & todate.DateTime.Date & "' "
            'fltString = "Month({View_1Birthday_Report.DOB}) = " & bdayMonth & " And Day({View_1Birthday_Report.DOB}) =" & bdayday & " Between Month({View_1Birthday_Report.DOB}) = " & tomonth & " And Day({View_1Birthday_Report.DOB}) =" & today & """"
            'fltString = "{rpt_House_Count_Report_View.ResDate} >=#" & dtResDate.Text & "# and {rpt_House_Count_Report_View.ResDate}<=#" & dtResDate2.Text & "# "

            Conn.Close()

            ' ReportName = "rptmasterbillsum.rpt"
            ReportName = "rptmonthlycomother.rpt"
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
End Class