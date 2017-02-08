Imports System.Data.SqlClient

Public Class House_Count

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim Conn As New SqlConnection(ConnString)
        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet



        Dim bdayMonth As Integer = dtResDate.DateTime.Date.Month
        Dim bdayday As Integer = dtResDate.DateTime.Date.Day


        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("housecnt_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

            'dcIns = New SqlCommand("select * from View_1Birthday_Report", Conn)
            dcIns.Parameters.Add("@dDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date


            'dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()



            'fltString = "Month({View_1Birthday_Report.DOB}) = " & bdayMonth & " And Day({View_1Birthday_Report.DOB}) =" & bdayday & ""



            ReportName = "rpthouse.rpt"
            rptTitle = "House Counr_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1


            frmReportViewer.paraRepName = ""
            frmReportViewer.paraRepVale = ""

            'frmReportViewer.paraRepName = "fromDate"
            'frmReportViewer.paraRepVale = dtResDate.Text.ToString

            'frmReportViewer.paraRepName2 = "toDate"
            'frmReportViewer.paraRepVale2 = dtResDate2.Text.ToString

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()


        End Try
    End Sub

    Private Sub House_Count_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtResDate.DateTime = DateTime.Now


    End Sub
End Class