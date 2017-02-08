Imports System.Data.SqlClient

Public Class NewOccupancyRoomGraphical

    Private Sub NewOccupancyRoomGraphical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        dtResDate.Text = Date.Today
        dtResDate2.Text = Date.Today
    End Sub
    Private Sub InsertTemp()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        DeleteTempOccTbl()

        Dim startDate As DateTime = dtResDate.DateTime.Date
        Dim endDate As DateTime = dtResDate2.DateTime.Date

        Dim NoofDays As Integer = DateDiff(DateInterval.Day, startDate, endDate) + 1


        Dim getStartDate As DateTime = startDate

        While (getStartDate <= endDate)


            dcInsertNewAcc = New SqlCommand("TempOccupancyRpt_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = getStartDate
            dcInsertNewAcc.Parameters.Add("@Days", SqlDbType.Int).Value = NoofDays
            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()


            getStartDate = DateAdd(DateInterval.Day, 1, getStartDate)


        End While



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

            dcIns = New SqlCommand("LoadTempOccupancyRpt_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

            dcIns.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            'ReportName = "New_Occupancy_Report.rpt"
            ReportName = "New_Occupancy_Report _Graphical.rpt"


            rptTitle = "New_Occupancy_Report"

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
    Private Sub DeleteTempOccTbl()


        Try



            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            dcInsertNewAcc = New SqlCommand("delete from TempOccupancyRpt", Conn)
            dcInsertNewAcc.CommandType = CommandType.Text


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        InsertTemp()
        printreport()
    End Sub

    Private Sub NewOccupancyRoomGraphical_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class