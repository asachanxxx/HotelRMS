Imports System.Data.SqlClient
Public Class NewfrmRoom_Staus_Report

    Private Sub NewfrmRoom_Staus_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        dtResDate.Text = Date.Today
        'dtResDate2.Text = Date.Today
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

            dcIns = New SqlCommand("select * from View_1Room_Status_Report", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()



            fltString = ""
            'fltString = "{rpt_Occupancy_Report_Of_Rooms_By_Bedding_View.ReservationDate}=#" & dtResDate.Text & "#"
            'fltString = "{View_1Room_Status_Report.ReservationDate}=#" & dtResDate.Text & "#"



            ReportName = "NewRoom_Status_Report.rpt"
            rptTitle = "NewRoom_Status_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = "fromDate"
            frmReportViewer.paraRepVale = dtResDate.Text.ToString

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

    Private Sub NewfrmRoom_Staus_Report_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub dtResDate_EditValueChanged(sender As Object, e As EventArgs) Handles dtResDate.EditValueChanged
      
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        ' Dim bdayMonth As Integer = dtResDate.DateTime.Date.Month
        ' Dim bdayday As Integer = dtResDate.DateTime.Date.Day
        ' Dim tomonth As Integer = todate.DateTime.Date.Month
        ' Dim today As Integer = todate.DateTime.Date.Day



        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        'Dim fltString As String

        Try

            Conn.Open()

            ' dcIns = New SqlCommand("select * from View_1Birthday_Report where month(dob) between " & bdayMonth & " and " & tomonth & " and  DAY (dob) between " & bdayday & " and " & today & "", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            dcInsertNewAcc = New SqlCommand("loadroomsts_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@selDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
            ' dcInsertNewAcc.Parameters.Add("@tdate", SqlDbType.DateTime).Value = dtto.DateTime.Date

            ' dcIns.ExecuteNonQuery()
            dcInsertNewAcc.ExecuteNonQuery()


            'fltString = "Month({View_1Birthday_Report.DOB}) = " & bdayMonth & " And Day({View_1Birthday_Report.DOB}) =" & bdayday & " Between Month({View_1Birthday_Report.DOB}) = " & tomonth & " And Day({View_1Birthday_Report.DOB}) =" & today & """"

            ReportName = "rptRmStatusbydate.rpt"
            rptTitle = "Room Status by Date"
            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.reporttype = 1
            frmReportViewer.Show()
           


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()


        End Try
    End Sub
End Class