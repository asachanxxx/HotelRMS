Imports System.Data.SqlClient
Public Class NewfrmOccupancy_Status_Report

    Private Sub NewfrmOccupancy_Status_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        dtResDate.Text = Date.Today
        dtResDate2.Text = Date.Today
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

            ReportName = "New_Occupancy_Report.rpt"
            ' ReportName = "New_Occupancy_Report _Graphical.rpt"


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

    Private Sub NewfrmOccupancy_Status_Report_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class