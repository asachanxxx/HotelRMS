Imports System.Data.SqlClient
Public Class NewfrmBooking_Check_List_Report

    Private Sub NewfrmBooking_Check_List_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        dtResDate.Text = Date.Today
        dtResDate2.Text = Date.Today

        LoadTopcodes()


    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        InsertTemp()
        print()


    End Sub
    Private Sub InsertTemp()

        If cbTopcode.Text = "ALL" Then



            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            dcInsertNewAcc = New SqlCommand("RptBookingList_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@frmDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtResDate2.DateTime.Date

            Conn.Open()
            dcInsertNewAcc.CommandTimeout = 100

            dcInsertNewAcc.ExecuteNonQuery()

            Conn.Close()

        Else

            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            dcInsertNewAcc = New SqlCommand("RptBookingListTOPWise_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@frmDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtResDate2.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@Topcode", SqlDbType.VarChar).Value = cbTopcode.Text.Trim

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()

            Conn.Close()


        End If

    End Sub
    Private Sub print()
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

            dcIns = New SqlCommand("select * from TempRptBookingList order by arrdate", Conn)

            'dcIns = New SqlCommand("select * from View_1Booking_Check_List_Report where View_1Booking_Check_List_Report.ArrDate > @frmdate and View_1Booking_Check_List_Report.ArrDate <  @todate ", Conn)


            'dcIns.Parameters.Add("@frmdate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
            'dcIns.Parameters.Add("@todate", SqlDbType.DateTime).Value = dtResDate2.DateTime.Date

            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()



            'fltString = ""
            'fltString = "{View_1Booking_Check_List_Report.ArrDate}>= #" & dtResDate.DateTime & "# and {View_1Booking_Check_List_Report.ArrDate}< =#" & dtResDate2.DateTime & "# "

            ' fltString = "{rpt_Occupancy_Report_Of_Rooms_By_Bedding_View.ReservationDate} >=#" & dtResDate.Text & "# and {rpt_Occupancy_Report_Of_Rooms_By_Bedding_View.ReservationDate}<=#" & dtResDate2.Text & "# "

            'fltString = "{View_1Booking_Check_List_Report.ArrDate} = '2013-2-1'"

            ReportName = "NewBooking_Check_List_Report.rpt"
            rptTitle = "NewBooking_Check_List_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = ""
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

            cbTopcode.Properties.Items.Add("ALL")

            While (DscountTest < Dscount)

                cbTopcode.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cbTopcode.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub


    Private Sub NewfrmBooking_Check_List_Report_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class