Imports System.Data.SqlClient
Public Class frmPerforma_Invoice_Raised_Report
   

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Try

            InsertTemp()
            printreport()





            'Dim Conn As New SqlConnection(ConnString)
            'Dim sqlString As String
            'Dim dcIns As New SqlCommand()
            'Dim daMain As New SqlDataAdapter()
            'Dim dsMain As New DataSet


            'Dim ReportName As String = ""
            'Dim rptTitle As String = ""

            'Dim fltString As String

            'Try

            '    Conn.Open()

            '    dcIns = New SqlCommand("select * from rpt_Performa_Invoice_Raised_Report_View", Conn)
            '    ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            '    dcIns.CommandType = CommandType.Text
            '    dcIns.ExecuteNonQuery()



            '    'fltString = ""
            '    fltString = "{rpt_Performa_Invoice_Raised_Report_View.ArrDate}>=#" & dtDate.Text & "# and {rpt_Performa_Invoice_Raised_Report_View.ArrDate}<=#" & dtDate2.Text & "#"







            '    ReportName = "Performa_Invoice_Raised_Report.rpt"
            '    rptTitle = "Performa_Invoice_Raised_Report"

            '    frmReportViewer.rptPath = ReportName
            '    frmReportViewer.rptTitle = rptTitle
            '    frmReportViewer.selectionForumla = fltString

            '    frmReportViewer.paraRepName = "fromDate"
            '    frmReportViewer.paraRepVale = dtDate.Text.ToString

            '    frmReportViewer.paraRepName2 = "toDate"
            '    frmReportViewer.paraRepVale2 = dtDate2.Text.ToString


            '    frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub InsertTemp()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("TempPerformaInvoiceRaisedRpt_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = dtDate2.DateTime.Date


        ' dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub printreport()
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

            dcIns = New SqlCommand("SELECT * FROM TempPerformaInvoiceRaisedRpt", Conn)
            dcIns.CommandType = CommandType.Text
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

            dcIns.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            ReportName = "Performa_Invoice_Raised_Report.rpt"
            rptTitle = "Performa_Invoice_Raised_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = "paraArrdate"
            frmReportViewer.paraRepVale = dtDate.Text.ToString

            'frmReportViewer.paraRepName2 = "paratoDate"
            ' frmReportViewer.paraRepVale2 = ""

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub frmPerforma_Invoice_Raised_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        dtDate.Text = Date.Today
        dtDate2.Text = Date.Today
    End Sub
End Class