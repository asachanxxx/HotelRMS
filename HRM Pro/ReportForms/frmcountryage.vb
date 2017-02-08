Imports System.Data.SqlClient
Public Class frmcountryage

    Private Sub LabelControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        loadcountrynage()
        printCountrynage()

    End Sub

    Private Sub loadcountrynage()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        dcInsertNewAcc = New SqlCommand("GuestCountryAge_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@selDate", SqlDbType.DateTime).Value = calFrom.DateTime.Date
        ' dcInsertNewAcc = New SqlCommand("SELECT @AGE=DATEDIFF(YY,dbo.GuestRegistration.DOB,GETDATE()) FROM GuestRegistration   DELETE FROM tblcountrynage", Conn)
        'dcInsertNewAcc.CommandType = CommandType.Text
        Conn.Open()
        'dcInsertNewAcc.CommandText
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Private Sub printCountrynage()
        Dim Conn As New SqlConnection(ConnString)
        Dim sqlString As String
        Dim dcgst As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet


        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        Dim fltString As String

        Try

            Conn.Open()

            dcgst = New SqlCommand("LoadGuestCountryAge_SP", Conn)
            dcgst.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@Month", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
            'dcIns.Parameters.Add("@Year", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
            dcgst.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            If chkcountry.Checked = True Then
                'ReportName = "New_Occupancy_Report.rpt"
                ReportName = "rptGuestbyCountry.rpt"

                ' ReportName = "New_Occupancy_Report _Graphical.rpt"


                rptTitle = "Guests' Country  Wise Report"

                frmReportViewer.rptPath = ReportName
                frmReportViewer.rptTitle = rptTitle
                'frmReportViewer.selectionForumla = fltString
                frmReportViewer.reporttype = 1

                'frmReportViewer.paraRepName = "fromDate"
                ' frmReportViewer.paraRepVale = dtResDate.Text.ToString

                'frmReportViewer.paraRepName2 = "toDate"
                'rmReportViewer.paraRepVale2 = dtResDate2.Text.ToString

                frmReportViewer.Show()
            End If
            If chkage.Checked = True Then

                'ReportName = "New_Occupancy_Report.rpt"
                ReportName = "rptGuestbyAge.rpt"

                ' ReportName = "New_Occupancy_Report _Graphical.rpt"


                rptTitle = "Guests' Age Wise Report"

                frmReportViewer.rptPath = ReportName
                frmReportViewer.rptTitle = rptTitle
                'frmReportViewer.selectionForumla = fltString
                frmReportViewer.reporttype = 1

                'frmReportViewer.paraRepName = "fromDate"
                ' frmReportViewer.paraRepVale = dtResDate.Text.ToString

                'frmReportViewer.paraRepName2 = "toDate"
                'rmReportViewer.paraRepVale2 = dtResDate2.Text.ToString

                frmReportViewer.Show()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcgst.Dispose()

        End Try
    End Sub

    Private Sub frmcountryage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        calFrom.Text = Date.Today
        'calTo.Text = Date.Today
    End Sub

    Private Sub LabelControl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkage.CheckedChanged
        If chkcountry.CheckState = CheckState.Checked Then
            chkcountry.CheckState = CheckState.Unchecked
        Else
            chkage.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub chkcountry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcountry.CheckedChanged
        If chkage.CheckState = CheckState.Checked Then
            chkage.CheckState = CheckState.Unchecked

        Else
            chkcountry.CheckState = CheckState.Checked

        End If
    End Sub
End Class