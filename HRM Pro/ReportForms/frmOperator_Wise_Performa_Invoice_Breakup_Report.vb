Imports System.Data.SqlClient
Public Class frmOperator_Wise_Performa_Invoice_Breakup_Report

    Private Sub frmOperator_Wise_Performa_Invoice_Breakup_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtDate.Text = Date.Today
        dtDate2.Text = Date.Today
        LoadTopcodes()
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

            dcIns = New SqlCommand("select * from rpt_Operator_Wise_Performa_Invoice_Breakup_Report_View order by ArrDate", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            If cmbOperatorID.Text = "ALL" Then

                fltString = "{rpt_Operator_Wise_Performa_Invoice_Breakup_Report_View.ArrDate}>=#" & dtDate.Text & "# and {rpt_Operator_Wise_Performa_Invoice_Breakup_Report_View.ArrDate}<=#" & dtDate2.Text & "#"

            Else
                fltString = "{rpt_Operator_Wise_Performa_Invoice_Breakup_Report_View.Topcode} ='" & cmbOperatorID.Text & "' and {rpt_Operator_Wise_Performa_Invoice_Breakup_Report_View.ArrDate}>=#" & dtDate.Text & "# and {rpt_Operator_Wise_Performa_Invoice_Breakup_Report_View.ArrDate}<=#" & dtDate2.Text & "#"
            End If

            'fltString = ""
            ' fltString = "{rpt_Operator_Wise_Performa_Invoice_Breakup_Report_View.ProInvDate} >=#" & dtDate.Text & "# and {rpt_Operator_Wise_Performa_Invoice_Breakup_Report_View.ProInvDate}<=#" & dtDate2.Text & "# "




            ReportName = "Operator_Wise_Performa_Invoice_Breakup_Report.rpt"
            rptTitle = "Operator_Wise_Performa_Invoice_Breakup_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 2

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

    Private Sub LoadTopcodes()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select TopCode from [Touroperator.Master] WHERE Status='ACTIVE' order by TopCode", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer



            cmbOperatorID.Properties.Items.Add("ALL")



            While (DscountTest < Dscount)

                cmbOperatorID.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbOperatorID.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
End Class