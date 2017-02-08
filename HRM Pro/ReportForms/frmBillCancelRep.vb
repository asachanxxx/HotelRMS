Imports System.Data.SqlClient
Public Class frmBillCancelRep

    Private Sub frmBillCancelRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtResDate.Text = Date.Today
        todate.Text = Date.Today
    End Sub

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



            dcInsertNewAcc = New SqlCommand("CancelBillrpt_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date

            dcInsertNewAcc.ExecuteNonQuery()


            Conn.Close()

            ' ReportName = "rptmasterbillsum.rpt"
            ReportName = "rptCancellBill.rpt"
            rptTitle = "Cancel Bill Report"
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