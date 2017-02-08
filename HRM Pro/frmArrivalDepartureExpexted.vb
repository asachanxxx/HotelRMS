Imports System.Data.SqlClient
Public Class frmArrivalDepartureExpexted

    Private Sub frmArrivalDepartureExpexted_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()


        dtDateDep.Text = DateTime.Now.Date
        dtDateArr.Text = DateTime.Now.Date

    End Sub
    Private Sub LoadExpectcedArrivals()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()


            dcSearch = New SqlCommand("select ResNo,convert(char(5),ArrTime, 108) [ArrTime],ArrFlight,Guest,(AdultQty+ChildrenQty+InfantsQty) as TotPax,MealPlan,Topcode,DepDate,ArrTrans,Remarks from dbo.[Reservation.Master] where Status='OPEN' AND  ArrDate=@ArrDate order by ArrTime", Conn)
            dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDateArr.DateTime.Date

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcGuestArr.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()

        End Try

    End Sub

    Private Sub btnViewDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDep.Click

        LoadExpectcedDeparture()

    End Sub
    Private Sub LoadExpectcedDeparture()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()

            'convert(char(5),ArrTime, 108) [dbo.[Reservation.Master].DepTime]
            dcSearch = New SqlCommand("select ReservationNo,ReservationDate,GuestRegNo,GuestRegDate,ArriveDate,ArriveFrom,DepDate,DepTo,AFlight,DFlight,convert(char(5),ATime, 108) [ATime],convert(char(5),DTime, 108) [DTime],FullName,PassportNo,PPDateOfIssue,PPPlaceOfIssue,Nationality,Country,HomeAddress,Profession,DOB,NoOfVisitMaldives,NoOfVisitEriyadu,RoomType,RoomNo,RoomShareWith,IsBillingGuest FROM dbo.[GuestRegistration]  WHERE dbo.[GuestRegistration].DepDate= @DepDate order by dbo.[GuestRegistration].DepDate", Conn)
            dcSearch.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDateDep.DateTime.Date

            


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcGuestDep.DataSource = dsMain.Tables(0)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()

        End Try

    End Sub

    Private Sub btnViewarr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewarr.Click

        LoadExpectcedArrivals()

    End Sub

    Private Sub InsertTemp()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("RptExpectedArrival_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDateArr.DateTime.Date

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub InsertTempDep()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("RptExpectedDeparture_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDateDep.DateTime.Date

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub


    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

            dcIns = New SqlCommand("select * from rpt_Expected_Arrival_Departures_View", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()



            ' fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate}='" & "2012/10/22" & "'"
            fltString = "{rpt_Expected_Arrival_Departures_View.ResDate}=#" & "2012/10/22" & "#"

            ReportName = "Expected_Arrival_List.rpt"
            rptTitle = "Expected_Arrival_List"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        InsertTemp()
        printreport()
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

            dcIns = New SqlCommand("LoadRptExpectedArrival_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDateArr.DateTime.Date

            dcIns.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            ReportName = "Expected_Arrival_List.rpt"
            rptTitle = "Expected Arrival List Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 2

            frmReportViewer.paraRepName = "paraArrdate"
            frmReportViewer.paraRepVale = dtDateArr.Text.ToString

            frmReportViewer.paraRepName2 = "paratoDate"
            frmReportViewer.paraRepVale2 = ""

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub
    Private Sub printreportDep()
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

            dcIns = New SqlCommand("LoadRptExpectedDeparture_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDateArr.DateTime.Date

            dcIns.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            ReportName = "Expected_Departure_List.rpt"
            rptTitle = "Expected Departure List Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 2

            frmReportViewer.paraRepName = "paraArrdate"
            frmReportViewer.paraRepVale = dtDateDep.Text.ToString

            frmReportViewer.paraRepName2 = "paratoDate"
            frmReportViewer.paraRepVale2 = ""

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub btPrintDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrintDep.Click
        InsertTempDep()
        printreportDep()

    End Sub

    Private Sub frmArrivalDepartureExpexted_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class