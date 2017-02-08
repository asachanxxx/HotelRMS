Imports System.Data.SqlClient
Public Class NewfrmOccupanAdv

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        DeleteTempOccTbl()

        InsertPaxMPAI("AI")

        InsertPaxMPAI("FB")

        InsertPaxMPAI("HB")

        InsertPaxByTOP()

        InsertPaxByTOPArrivals()

        InsertPaxByTOPDeparture()


        InsertPaxRoomSTD("Deluxe")

        InsertPaxRoomSTD("Standard")

        InsertPaxRoomSTD("Superior")


        InsertRoomByTOP()


        InsertRoomByTOPArrivals()

        InsertRoomsByTOPDeparture()


        InsertPaxRoomType("Single")
        InsertPaxRoomType("Double")
        InsertPaxRoomType("Triple")


        printreport()

    End Sub
    Private Sub DeleteTempOccTbl()


        Try



            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            dcInsertNewAcc = New SqlCommand("delete from TempOccupancyStatusAdvance", Conn)
            dcInsertNewAcc.CommandType = CommandType.Text


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

    End Sub
    Private Sub InsertPaxMPAI(ByVal MP As String)

        Try

       
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim getMP As String = MP


        dcInsertNewAcc = New SqlCommand("TempOccupancyAdvMp_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = getMP
            dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "A - PAX BY MEALPLAN"
        dcInsertNewAcc.Parameters.Add("@OccDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

    End Sub
    Private Sub InsertPaxByTOP()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand


        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        dcSearch = New SqlCommand("select  Topcode,SUM (AdultQty + ChildrenQty) as Totpax  from dbo.[Reservation.Master] where  dbo.[Reservation.Master].ArrDate <=  @Occdate AND dbo.[Reservation.Master].DepDate >= @Occdate and dbo.[Reservation.Master].Status='OPEN'  GROUP BY Topcode", Conn)
        dcSearch.Parameters.Add("@Occdate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date

        Conn.Open()
        daMain = New SqlDataAdapter()
        daMain.SelectCommand = dcSearch
        daMain.Fill(dsMain)
        Conn.Close()


        Dim DScount1 As Integer = dsMain.Tables(0).Rows.Count - 1

        While DScount1 >= 0


            dcInsertNewAcc = New SqlCommand("TempOccupancyAdv_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(0).ToString()
            dcInsertNewAcc.Parameters.Add("@DayBreackOcc", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount1)(1).ToString())
            dcInsertNewAcc.Parameters.Add("@Arrivals", SqlDbType.Int).Value = 0
            dcInsertNewAcc.Parameters.Add("@Departure", SqlDbType.Int).Value = 0
            dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "B - PAX BY OPERATOR"
            dcInsertNewAcc.Parameters.Add("@PasaDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
            DScount1 = DScount1 - 1

        End While

    End Sub
    Private Sub InsertRoomByTOP()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand


        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        dcSearch = New SqlCommand("SELECT [Reservation.Master].Topcode,SUM ( dbo.[Reservation.Room].RoomCount)FROM  dbo.[Reservation.Master] INNER JOIN dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo Where dbo.[Reservation.Master].ArrDate <= @Occdate  AND dbo.[Reservation.Master].DepDate >= @Occdate and dbo.[Reservation.Master].Status='OPEN'  GROUP BY [Reservation.Master].Topcode", Conn)
        dcSearch.Parameters.Add("@Occdate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date

        Conn.Open()
        daMain = New SqlDataAdapter()
        daMain.SelectCommand = dcSearch
        daMain.Fill(dsMain)
        Conn.Close()


        Dim DScount1 As Integer = dsMain.Tables(0).Rows.Count - 1

        While DScount1 >= 0


            dcInsertNewAcc = New SqlCommand("TempOccupancyAdv_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(0).ToString()
            dcInsertNewAcc.Parameters.Add("@DayBreackOcc", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount1)(1).ToString())
            dcInsertNewAcc.Parameters.Add("@Arrivals", SqlDbType.Int).Value = 0
            dcInsertNewAcc.Parameters.Add("@Departure", SqlDbType.Int).Value = 0
            dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "D - RMS BY OPERATOR"
            dcInsertNewAcc.Parameters.Add("@PasaDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date



            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
            DScount1 = DScount1 - 1

        End While

    End Sub
    Private Sub InsertPaxByTOPArrivals()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand


        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        dcSearch = New SqlCommand("select Topcode,SUM (AdultQty + ChildrenQty)  from dbo.[Reservation.Master] where dbo.[Reservation.Master].ArrDate=@Occdate and  dbo.[Reservation.Master].Status='OPEN' GROUP BY Topcode", Conn)
        dcSearch.Parameters.Add("@Occdate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date

        Conn.Open()
        daMain = New SqlDataAdapter()
        daMain.SelectCommand = dcSearch
        daMain.Fill(dsMain)
        Conn.Close()


        Dim DScount1 As Integer = dsMain.Tables(0).Rows.Count - 1

        While DScount1 >= 0


            Dim Topcodes As String = dsMain.Tables(0).Rows(DScount1)(0).ToString

            Dim dscheckAddbefore As New DataSet
            dscheckAddbefore = dscheckAddbeforeTop(Topcodes)


            If dscheckAddbefore.Tables(0).Rows.Count > 0 Then

                dcInsertNewAcc = New SqlCommand("UpdateTempOccupancyAdvPaxArrival_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(0).ToString
                dcInsertNewAcc.Parameters.Add("@Arrivals", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount1)(1).ToString())
                dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "B - PAX BY OPERATOR"

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()




            Else

                dcInsertNewAcc = New SqlCommand("TempOccupancyAdv_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(0).ToString
                dcInsertNewAcc.Parameters.Add("@DayBreackOcc", SqlDbType.Int).Value = 0
                dcInsertNewAcc.Parameters.Add("@Arrivals", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount1)(1).ToString())
                dcInsertNewAcc.Parameters.Add("@Departure", SqlDbType.Int).Value = 0
                dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "B - PAX BY OPERATOR"
                dcInsertNewAcc.Parameters.Add("@PasaDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date


                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()


            End If

           
            DScount1 = DScount1 - 1

        End While

    End Sub
    Private Sub InsertRoomByTOPArrivals()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand


        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        dcSearch = New SqlCommand("SELECT [Reservation.Master].Topcode,SUM( dbo.[Reservation.Room].RoomCount)FROM  dbo.[Reservation.Master] INNER JOIN  dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo Where dbo.[Reservation.Master].ArrDate = @Occdate  and dbo.[Reservation.Master].Status='OPEN'  GROUP BY [Reservation.Master].Topcode", Conn)
        dcSearch.Parameters.Add("@Occdate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date

        Conn.Open()
        daMain = New SqlDataAdapter()
        daMain.SelectCommand = dcSearch
        daMain.Fill(dsMain)
        Conn.Close()


        Dim DScount1 As Integer = dsMain.Tables(0).Rows.Count - 1

        While DScount1 >= 0


            Dim Topcodes As String = dsMain.Tables(0).Rows(DScount1)(0).ToString

            Dim dscheckAddbefore As New DataSet
            dscheckAddbefore = dscheckAddbeforeTopRoom(Topcodes)


            If dscheckAddbefore.Tables(0).Rows.Count > 0 Then

                dcInsertNewAcc = New SqlCommand("UpdateTempOccupancyAdvPaxArrival_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(0).ToString
                dcInsertNewAcc.Parameters.Add("@Arrivals", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount1)(1).ToString())
                dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "D - RMS BY OPERATOR"

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()




            Else

                dcInsertNewAcc = New SqlCommand("TempOccupancyAdv_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(0).ToString
                dcInsertNewAcc.Parameters.Add("@DayBreackOcc", SqlDbType.Int).Value = 0
                dcInsertNewAcc.Parameters.Add("@Arrivals", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount1)(1).ToString())
                dcInsertNewAcc.Parameters.Add("@Departure", SqlDbType.Int).Value = 0
                dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "D - RMS BY OPERATOR"
                dcInsertNewAcc.Parameters.Add("@PasaDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()


            End If


            DScount1 = DScount1 - 1

        End While

    End Sub
    Private Sub InsertPaxByTOPDeparture()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand


        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        dcSearch = New SqlCommand("select  Topcode,SUM (AdultQty + ChildrenQty)  from dbo.[Reservation.Master] where dbo.[Reservation.Master].DepDate=@Occdate and  dbo.[Reservation.Master].Status='OPEN' GROUP BY Topcode", Conn)
        dcSearch.Parameters.Add("@Occdate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date

        Conn.Open()
        daMain = New SqlDataAdapter()
        daMain.SelectCommand = dcSearch
        daMain.Fill(dsMain)
        Conn.Close()


        Dim DScount1 As Integer = dsMain.Tables(0).Rows.Count - 1

        While DScount1 >= 0


            Dim Topcodes As String = dsMain.Tables(0).Rows(DScount1)(0).ToString

            Dim dscheckAddbefore As New DataSet
            dscheckAddbefore = dscheckAddbeforeTop(Topcodes)


            If dscheckAddbefore.Tables(0).Rows.Count > 0 Then

                dcInsertNewAcc = New SqlCommand("UpdateTempOccupancyAdvPaxDeparture_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(0).ToString
                dcInsertNewAcc.Parameters.Add("@Departure", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount1)(1).ToString())
                dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "B - PAX BY OPERATOR"

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()




            Else

                dcInsertNewAcc = New SqlCommand("TempOccupancyAdv_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(0).ToString
                dcInsertNewAcc.Parameters.Add("@DayBreackOcc", SqlDbType.Int).Value = 0
                dcInsertNewAcc.Parameters.Add("@Arrivals", SqlDbType.Int).Value = 0
                dcInsertNewAcc.Parameters.Add("@Departure", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount1)(1).ToString())
                dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "B - PAX BY OPERATOR"
                dcInsertNewAcc.Parameters.Add("@PasaDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()


            End If


            DScount1 = DScount1 - 1

        End While

    End Sub
    Private Sub InsertRoomsByTOPDeparture()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand


        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        dcSearch = New SqlCommand("SELECT [Reservation.Master].Topcode,SUM( dbo.[Reservation.Room].RoomCount)FROM  dbo.[Reservation.Master] INNER JOIN dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo Where dbo.[Reservation.Master].DepDate = @Occdate and dbo.[Reservation.Master].Status='OPEN'  GROUP BY [Reservation.Master].Topcode", Conn)
        dcSearch.Parameters.Add("@Occdate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date

        Conn.Open()
        daMain = New SqlDataAdapter()
        daMain.SelectCommand = dcSearch
        daMain.Fill(dsMain)
        Conn.Close()


        Dim DScount1 As Integer = dsMain.Tables(0).Rows.Count - 1

        While DScount1 >= 0


            Dim Topcodes As String = dsMain.Tables(0).Rows(DScount1)(0).ToString

            Dim dscheckAddbefore As New DataSet
            dscheckAddbefore = dscheckAddbeforeTop(Topcodes)


            If dscheckAddbefore.Tables(0).Rows.Count > 0 Then

                dcInsertNewAcc = New SqlCommand("UpdateTempOccupancyAdvPaxDeparture_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(0).ToString
                dcInsertNewAcc.Parameters.Add("@Departure", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount1)(1).ToString())
                dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "D - RMS BY OPERATOR"

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()




            Else

                dcInsertNewAcc = New SqlCommand("TempOccupancyAdv_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(0).ToString
                dcInsertNewAcc.Parameters.Add("@DayBreackOcc", SqlDbType.Int).Value = 0
                dcInsertNewAcc.Parameters.Add("@Arrivals", SqlDbType.Int).Value = 0
                dcInsertNewAcc.Parameters.Add("@Departure", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount1)(1).ToString())
                dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "D - RMS BY OPERATOR"
                dcInsertNewAcc.Parameters.Add("@PasaDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()


            End If


            DScount1 = DScount1 - 1

        End While

    End Sub
    Function dscheckAddbeforeTop(ByVal topcode As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim getTopcode As String = topcode

            dcSearch = New SqlCommand("select * from TempOccupancyStatusAdvance where Particular=@topcode and [GROUP]='B - PAX BY OPERATOR'", Conn)
            dcSearch.Parameters.Add("@topcode", SqlDbType.VarChar).Value = getTopcode


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                dscheckAddbeforeTop = dsMain
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function
    Function dscheckAddbeforeTopRoom(ByVal topcode As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim getTopcode As String = topcode

            dcSearch = New SqlCommand("select * from TempOccupancyStatusAdvance where Particular=@topcode and [GROUP]='D - RMS BY OPERATOR'", Conn)
            dcSearch.Parameters.Add("@topcode", SqlDbType.VarChar).Value = getTopcode


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                dscheckAddbeforeTopRoom = dsMain
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
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

            dcIns = New SqlCommand("select * from TempOccupancyStatusAdvance", Conn)
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()

            fltString = ""



            ReportName = "NewOccupancy_Status_Advance_Report.rpt"
            rptTitle = "Occupancy_Status_Advance_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1


            frmReportViewer.paraRepName = "date"
            frmReportViewer.paraRepVale = dtResDate.DateTime.Date


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
    Private Sub InsertPaxRoomSTD(ByVal Room As String)

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getRoom As String = Room


            dcInsertNewAcc = New SqlCommand("TempOccupancyAdvRoom_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = getRoom
            dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "C - RMS BY CATEGORY"
            dcInsertNewAcc.Parameters.Add("@OccDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

    End Sub
    Private Sub InsertPaxRoomType(ByVal RoomType As String)

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getRoomType As String = RoomType


            dcInsertNewAcc = New SqlCommand("TempOccupancyAdvRType_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@Particular", SqlDbType.VarChar).Value = getRoomType
            dcInsertNewAcc.Parameters.Add("@Group", SqlDbType.VarChar).Value = "E - RMS BY TYPE"
            dcInsertNewAcc.Parameters.Add("@OccDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

    End Sub

    Private Sub NewfrmOccupanAdv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtResDate.Text = DateTime.Now.Date
    End Sub

    Private Sub NewfrmOccupanAdv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class