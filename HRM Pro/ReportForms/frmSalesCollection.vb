Imports System.Data.SqlClient
Public Class frmSalesCollection

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
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
            'dcInsertNewAcc = New SqlCommand("outletsalescol_SP", Conn)
            dcInsertNewAcc = New SqlCommand("outletsalesdirect_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@fdate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@tdate", SqlDbType.DateTime).Value = dtDate2.DateTime.Date

            ' dcIns.CommandType = CommandType.Text
            ''dcIns.ExecuteNonQuery()
            dcInsertNewAcc.ExecuteNonQuery()


            'fltString = ""
            ' fltString = "{rpt_Operator_Wise_Performa_Invoice_Breakup_Report_View.ProInvDate} >=#" & dtDate.Text & "# and {rpt_Operator_Wise_Performa_Invoice_Breakup_Report_View.ProInvDate}<=#" & dtDate2.Text & "# "
            ' fltString = "{rpt_Outletwise_sales.BillGeneratedDate}>=#" & dtDate.Text & "# and {rpt_Outletwise_sales.BillGeneratedDate}<=#" & dtDate2.Text & "#"



            ReportName = "rptoutletsalescoldirect.rpt"
            rptTitle = "Outletwise_Direct_Sales_Report"

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

    Private Sub frmSalesCollection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtDate.Text = Date.Today
        dtDate2.Text = Date.Today
    End Sub
End Class