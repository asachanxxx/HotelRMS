Imports System.Data.SqlClient
Public Class frmItem_Request_Raised_Report

    Private Sub frmItem_Request_Raised_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        dtDate.Text = Date.Today
        dtDate2.Text = Date.Today

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

            dcIns = New SqlCommand("select * from rpt_Item_Request_Raised_Report_View", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            Dim getFrmDate As DateTime = dtDate.DateTime.Date
            Dim getToDate As DateTime = dtDate2.DateTime.Date



            'fltString = ""
            fltString = "{rpt_Item_Request_Raised_Report_View.ReqDate} >=#" & dtDate.Text & "# and {rpt_Item_Request_Raised_Report_View.ReqDate}<=#" & dtDate2.Text & "#"


            '{rpt_Item_Request_Raised_Report_View.ReqDate} >=#" & dtDate.Text & "# and {rpt_Item_Request_Raised_Report_View.ReqDate}<=#" & dtDate2.Text & "#"


            'fltString = "{rpt_Item_Request_Raised_Report_View.ReqDate} >=getFrmDate and {rpt_Item_Request_Raised_Report_View.ReqDate}<=getToDate"



            'fltString = "{rpt_Item_Request_Raised_Report_View.ReqDate} >='2012-10-01' and {rpt_Item_Request_Raised_Report_View.ReqDate}<='2012-10-21'"

            ReportName = "Item_Request_Raised_Report.rpt"
            rptTitle = "Item_Request_Raised_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString

            frmReportViewer.paraRepName = "fromDate"
            frmReportViewer.paraRepVale = dtDate.Text.ToString

            frmReportViewer.paraRepName2 = "toDate"
            frmReportViewer.paraRepVale2 = dtDate2.Text.ToString


            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub
End Class