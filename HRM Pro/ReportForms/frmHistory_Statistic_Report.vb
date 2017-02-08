
Imports System.Data.SqlClient
Public Class frmHistory_Statistic_Report

    Private Sub frmHistory_Statistic_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        dtResDate.Text = Date.Today
        dtResDate2.Text = Date.Today
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim Conn As New SqlConnection(ConnString)
        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet


        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from rpt_History_Statistic_Report_View", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            dtResDate.DateTime.Date.ToString()

            'fltString = ""
            'fltString = "{rpt_History_Statistic_Report_View.GuestRegDate} >=#" & dtResDate.Text & "# and {rpt_History_Statistic_Report_View.GuestRegDate}<=#" & dtResDate2.Text & "# "

            fltString = "{rpt_History_Statistic_Report_View.GuestRegDate} >=#" & dtResDate.Text & "# and {rpt_History_Statistic_Report_View.GuestRegDate}<=#" & dtResDate2.Text & "# "

            ReportName = "History_Statistic_Report.rpt"
            rptTitle = "History_Statistic_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 2

            frmReportViewer.paraRepName = "fromDate"
            frmReportViewer.paraRepVale = dtResDate.Text.ToString

            frmReportViewer.paraRepName2 = "toDate"
            frmReportViewer.paraRepVale2 = dtResDate2.Text.ToString


            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub
End Class