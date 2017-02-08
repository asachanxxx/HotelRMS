Imports System.Data.SqlClient
Public Class frmMonthlyoccuRPT

    Private Sub NewfrmOccupancy_Status_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        dtResDate.Text = Date.Today
        dtResDate.Text = Year(Date.Today)
        'dtResDate2.Text = Date.Today
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        InsertTemp()
        printreport()
    End Sub
    Private Sub InsertTemp()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        DeleteTempOccTbl()

        'Dim startDate As DateTime = dtResDate.DateTime.Date
        'Dim endDate As DateTime = dtResDate2.DateTime.Date
        Dim SMonth As Integer = 1
        Dim EMonth As Integer = 12
        Dim rptYear As Integer = Year(dtResDate.DateTime.Date)



        'Dim NoofDays As Integer = DateDiff(DateInterval.Day, startDate, endDate) + 1
        'Dim noofMonths As Integer = DateDiff(DateInterval.Month) + 1
        'Dim noofMonths As Integer = DateDiff(DateInterval.Month, SMonth)
        'Dim getStartDate As DateTime = startDate
        ' Dim getStartYear As DateTime = Year(rptYear)
        Dim MDays As Integer
        'While (getStartDate <= endDate)
        Do While (SMonth <= EMonth)
            'For SMonth = SMonth To EMonth Step 1

            dcInsertNewAcc = New SqlCommand("MonthlyOccupancyRpt_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            'dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = getStartDate
            'dcInsertNewAcc.Parameters.Add("@Days", SqlDbType.Int).Value = NoofDays
            dcInsertNewAcc.Parameters.Add("@Month", SqlDbType.Int).Value = SMonth
            dcInsertNewAcc.Parameters.Add("@Year", SqlDbType.Int).Value = rptYear
            'MDays = FormatDateTime(Day(DateSerial(rptYear, SMonth + 1, 0)))

            dcInsertNewAcc.Parameters.Add("@MDays", SqlDbType.Int).Value = NoOfDays(rptYear, SMonth)
            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()

            Conn.Close()

            SMonth = SMonth + 1
            'getStartDate = DateAdd(DateInterval.Day, 1, getStartDate)

            'Next


        Loop



    End Sub
    Function NoOfDays(ByVal MyYear As Integer, ByVal MyMonth As Integer) As Integer


        Return DateTime.DaysInMonth(MyYear, MyMonth)


    End Function

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

            dcIns = New SqlCommand("LoadMonthlyOccupancyRpt_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@Month", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
            'dcIns.Parameters.Add("@Year", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
            dcIns.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            'ReportName = "New_Occupancy_Report.rpt"
            ReportName = "occupancyMonthly.rpt"

            ' ReportName = "New_Occupancy_Report _Graphical.rpt"


            rptTitle = "Monthly_Occupancy_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            'frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            'frmReportViewer.paraRepName = "fromDate"
            ' frmReportViewer.paraRepVale = dtResDate.Text.ToString

            'frmReportViewer.paraRepName2 = "toDate"
            'rmReportViewer.paraRepVale2 = dtResDate2.Text.ToString

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

            dcInsertNewAcc = New SqlCommand("delete from tblMonthlyOccupancyRpt", Conn)
            dcInsertNewAcc.CommandType = CommandType.Text


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

    End Sub
    Function DSCheckAddTempOccupancyRpt() As DataSet

        'Dim Conn As New SqlConnection(ConnString)
        'Dim daMain As New SqlDataAdapter
        'Dim dsMain As New DataSet
        'Dim dcSearch As New SqlCommand

        'Try
        '    Conn.Open()

        '    Dim StartDate As DateTime = StartDate
        '    Dim EndDate As DateTime = EndDate

        '    While (EndDate >= StartDate)

        '        Dim CountofSingle As Integer = CountofSingle
        '        Dim CountofDouble As Integer = CountofDouble
        '        Dim CountofTriple As Integer = CountofTriple

        '        Dim countofFB As Integer = countofFB
        '        Dim countofHB As Integer = countofHB
        '        Dim countofAI As Integer = countofAI

        '        Dim countofSuperior As Integer = countofSuperior
        '        Dim countofDELUX As Integer = countofDELUX
        '        Dim countofSTANDARD As Integer = countofSTANDARD


        '        '-----get the Roomby beeding SGL,DBL,TPL --------

        '        dcSearch = New SqlCommand("SELECT SUM( dbo.[Reservation.Room].RoomCount) FROM dbo.[Reservation.Master] INNER JOIN dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo where  dbo.[Reservation.Master].ArrDate= StartDate AND dbo.[Reservation.Room].Roomtype='Single'", Conn)
        '        dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = StartDate

        '        dcSearch = New SqlCommand("SELECT SUM( dbo.[Reservation.Room].RoomCount) FROM dbo.[Reservation.Master] INNER JOIN dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo where  dbo.[Reservation.Master].ArrDate= StartDate AND dbo.[Reservation.Room].Roomtype='Double'", Conn)
        '        dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = StartDate

        '        dcSearch = New SqlCommand("SELECT SUM( dbo.[Reservation.Room].RoomCount) FROM dbo.[Reservation.Master] INNER JOIN dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo where  dbo.[Reservation.Master].ArrDate= StartDate AND dbo.[Reservation.Room].Roomtype='Triple'", Conn)
        '        dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = StartDate

        '        '-----// get the pax by meal plan FB,HB,AI --------

        '        dcSearch = New SqlCommand("select sum  (AdultQty + childrenqty) as TotCount  from [Reservation.Master]  where  ArrDate=startdate and MealPlan='FB'", Conn)
        '        dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = StartDate

        '        dcSearch = New SqlCommand("select sum  (AdultQty + childrenqty) as TotCount  from [Reservation.Master]  where  ArrDate=startdate and MealPlan='HB'", Conn)
        '        dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = StartDate

        '        dcSearch = New SqlCommand("select sum  (AdultQty + childrenqty) as TotCount  from [Reservation.Master]  where  ArrDate=startdate and MealPlan='AI'", Conn)
        '        dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = StartDate

        '        '-----// get the ROOM BY TYPE--------

        '        dcSearch = New SqlCommand("SELECT SUM( dbo.[Reservation.Room].RoomCount) FROM dbo.[Reservation.Master] INNER JOIN dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo where  dbo.[Reservation.Master].ArrDate=startdate AND dbo.[Reservation.Room].Room='Superior'", Conn)
        '        dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = StartDate

        '        dcSearch = New SqlCommand("SELECT SUM( dbo.[Reservation.Room].RoomCount) FROM dbo.[Reservation.Master] INNER JOIN dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo where  dbo.[Reservation.Master].ArrDate=startdate AND dbo.[Reservation.Room].Room='DELUX'", Conn)
        '        dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = StartDate

        '        dcSearch = New SqlCommand("SELECT SUM( dbo.[Reservation.Room].RoomCount) FROM dbo.[Reservation.Master] INNER JOIN dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo where  dbo.[Reservation.Master].ArrDate=startdate AND dbo.[Reservation.Room].Room='STANDARD'", Conn)
        '        dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = StartDate



        '    End While

        '    daMain = New SqlDataAdapter()
        '    daMain.SelectCommand = dcSearch
        '    daMain.Fill(dsMain)

        '    Dim count As Integer = dsMain.Tables(0).Rows.Count
        '    If count > 0 Then
        '        DSCheckAddTempOccupancyRpt = dsMain
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        '    Return Nothing
        'Finally
        '    Conn.Dispose()
        '    daMain.Dispose()
        '    dsMain.Dispose()
        'End Try
    End Function

    Private Sub LabelControl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl3.Click

    End Sub

    Private Sub LabelControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl1.Click

    End Sub
End Class