Imports System.Data.SqlClient

Public Class NewfrmExpectedArrivalDeparture
    Dim pubroomcount As Integer = 0
    Private Sub NewfrmExpectedArrivalDeparture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtDate.Text = DateTime.Now.Date
        'dtDateArr.Text = DateTime.Now.Date
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim Conn As New SqlConnection(ConnString)
        Dim daGetAll As New SqlDataAdapter()
        Dim dsShow As New DataSet
        Dim dcExec As New SqlCommand
        Dim sqlStr As String
        Dim dscheckAddbefore As New DataSet
        dscheckAddbefore = DSCheckAddRoomnos(dtDate.DateTime.Date.AddDays(+1))

        If dscheckAddbefore Is Nothing Then



            GetReservations()


        Else


            Conn.Open()

            Dim Getdata As DateTime = dtDate.DateTime.Date.AddDays(+1)


            Dim dscheckAddbeforeAdded As New DataSet
            dscheckAddbeforeAdded = DSCheckAddRoomnosAlready(dtDate.DateTime.Date.AddDays(+1))



            If dscheckAddbeforeAdded Is Nothing Then
                Dim ddd As Integer = 0
            Else
                If dscheckAddbeforeAdded.Tables(0).Rows.Count > 0 Then



                    Dim daMain As New SqlDataAdapter
                    Dim dsMain As New DataSet
                    Dim dcSearch As New SqlCommand

                    Dim PubRoomNo As String = ""

                    Dim DScount As Integer = dscheckAddbeforeAdded.Tables(0).Rows.Count - 1

                    While DScount >= 0


                        Dim resno As String = dscheckAddbeforeAdded.Tables(0).Rows(DScount)(0).ToString

                        'dcSearch = New SqlCommand("SELECT TOP (100) PERCENT dbo.[Reservation.Master].ResNo, dbo.[Reservation.Room].Room, dbo.[Reservation.Room].Roomtype, dbo.[Reservation.Room].RoomCount,dbo.[Reservation.Room].TotPax, dbo.[Reservation.Master].ResDate FROM   dbo.[Reservation.Room] INNER JOIN  dbo.[Reservation.Master] ON dbo.[Reservation.Room].ReservationNo = dbo.[Reservation.Master].ResNo  where   dbo.[Reservation.Master].ResNo=@resno  and  dbo.[Reservation.Master].Status='OPEN' ORDER BY    dbo.[Reservation.Master].ResNo", Conn)
                        'dcSearch.Parameters.Add("@resno", SqlDbType.VarChar).Value = resno

                        'daMain = New SqlDataAdapter()
                        'daMain.SelectCommand = dcSearch
                        'daMain.Fill(dsMain)


                        Dim daMain2 As New SqlDataAdapter
                        Dim dsMain2 As New DataSet
                        Dim dcSearch2 As New SqlCommand


                        'If dsMain.Tables(0).Rows.Count > 0 Then

                        '    Dim DScount2 As Integer = dsMain.Tables(0).Rows.Count - 1

                        '    While DScount2 >= 0

                        PubRoomNo = ""


                        dcSearch2 = New SqlCommand("SELECT dbo.[Reservation.Room].Room,dbo.[Reservation.Room].Roomtype , sum (dbo.[Reservation.Room].RoomCount) as RoomCount,sum (dbo.[Reservation.Room].TotPax) as TotPax  FROM   dbo.[Reservation.Room] INNER JOIN  dbo.[Reservation.Master] ON dbo.[Reservation.Room].ReservationNo = dbo.[Reservation.Master].ResNo  where   dbo.[Reservation.Master].ResNo=@resno  and  dbo.[Reservation.Master].Status='OPEN' group by dbo.[Reservation.Room].Room,dbo.[Reservation.Room].Roomtype", Conn)





                        dcSearch2.Parameters.Add("@resno", SqlDbType.VarChar).Value = resno

                        daMain2 = New SqlDataAdapter()
                        daMain2.SelectCommand = dcSearch2
                        daMain2.Fill(dsMain2)



                        If dsMain2.Tables(0).Rows.Count > 0 Then


                            Dim DScount3 As Integer = dsMain2.Tables(0).Rows.Count - 1


                            While DScount3 >= 0


                                Dim Resno2 As String = dscheckAddbeforeAdded.Tables(0).Rows(DScount)(0).ToString
                                Dim RoomCount As Integer = Convert.ToInt16(dsMain2.Tables(0).Rows(DScount3)(2).ToString)
                                Dim Room As String = dsMain2.Tables(0).Rows(DScount3)(0).ToString
                                Dim RoomType As String = dsMain2.Tables(0).Rows(DScount3)(1).ToString
                                Dim Totpax As Integer = Convert.ToInt16(dsMain2.Tables(0).Rows(DScount3)(3).ToString)
                                Dim ResDate As DateTime = dtDate.DateTime.Date.AddDays(+1)


                                '----- check already added 

                                If RoomCount = 1 Then

                                    'Dim dscheckAddbefore As New DataSet
                                    'dscheckAddbefore = DSCheckAddRoomnos(Resno)

                                    'If dscheckAddbefore Is Nothing Then

                                    InsertAssignRoomOri(resno, Room, RoomType, RoomCount, Totpax, ResDate, "")

                                    'End If


                                Else

                                    'Dim dscheckAddbefore As New DataSet
                                    'dscheckAddbefore = DSCheckAddRoomnos(Resno)

                                    'If dscheckAddbefore Is Nothing Then


                                    ' Dim DSRommcount As Integer = Convert.ToInt16(dsMain2.Tables(0).Rows(DScount3)(3).ToString) - 1


                                    Dim DSRommcount As Integer = RoomCount

                                    ' Dim TotpaxPerroom As Integer = Totpax / RoomCount

                                    Dim TotpaxPerroomInt As Integer = Totpax / RoomCount
                                    Dim TotpaxPerroomDec As Decimal = Totpax / RoomCount

                                    Dim NewTotpaxPerroom As Integer = 0
                                    Dim BalanceTotpaxPerRoom As Integer = 0

                                    If TotpaxPerroomDec > TotpaxPerroomInt Then
                                        NewTotpaxPerroom = TotpaxPerroomInt + 1
                                        InsertAssignRoomOri(resno, Room, RoomType, 1, NewTotpaxPerroom, ResDate, "")
                                        BalanceTotpaxPerRoom = (Totpax - NewTotpaxPerroom) / (RoomCount - 1)
                                        DSRommcount = DSRommcount - 1

                                    Else

                                        InsertAssignRoomOri(resno, Room, RoomType, 1, TotpaxPerroomInt, ResDate, "")
                                        BalanceTotpaxPerRoom = (Totpax - TotpaxPerroomInt) / (RoomCount - 1)
                                        DSRommcount = DSRommcount - 1

                                    End If


                                    While DSRommcount > 0

                                        InsertAssignRoomOri(resno, Room, RoomType, 1, BalanceTotpaxPerRoom, ResDate, "")
                                        DSRommcount = DSRommcount - 1

                                    End While



                                End If

                                DScount3 = DScount3 - 1

                            End While


                            'End If



                            'End If

                            ' IsUpdateAll(Resno)

                            '    DScount2 = DScount2 - 1




                            'End While

                        Else
                            Exit Sub

                        End If

                DScount = DScount - 1
                    End While
                End If

            End If

        End If




        '  DeleteResRoomAssign(Getdata)

        ' GetReservations()

        Conn.Dispose()




        InsertTemp()
        '  UpdateroomnosProcess()

        'UpdateroomnosProcessStandard("Single")
        'UpdateroomnosProcessDeluxe("Single")
        'UpdateroomnosProcessSuperior("Single")





        'UpdateroomnosProcessStandard("Double")
        'UpdateroomnosProcessDeluxe("Double")
        'UpdateroomnosProcessSuperior("Double")




        'UpdateroomnosProcessStandard("Triple")
        'UpdateroomnosProcessDeluxe("Triple")
        'UpdateroomnosProcessSuperior("Triple")


        'UpdateroomnosProcessStandard("Child")
        'UpdateroomnosProcessDeluxe("Child")
        'UpdateroomnosProcessSuperior("Child")

        UpdateDepSameDayArrival()
        UpdateArrTodayNotCheckinDepTom()

        UpdateStatusArrivals()
        UpdateStatusDeparture()
        UpdateDepTotPax()


        printreport()

    End Sub
    Private Sub DeleteResRoomAssign(ByVal getResdate As DateTime)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Dim ResDate As DateTime = getResdate

        dcInsertNewAcc = New SqlCommand("DeleteResRoomAssign_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        dcInsertNewAcc.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = ResDate

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Private Sub DeleteResRoomAssignTemp(ByVal getResdate As DateTime)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Dim ResDate As DateTime = getResdate

        dcInsertNewAcc = New SqlCommand("DeleteResRoomAssignTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        dcInsertNewAcc.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = ResDate

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub


    Private Sub InsertTemp()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("TempRptExpectedArrDep_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date.AddDays(+1)


        ' dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub InsertTempAny()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("TempRptExpArrDepAny_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date.AddDays(+1)


        ' dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub InsertTempDepSameDay(ByVal ReservationNo As String, ByVal FullName As String, ByVal AdultQty As Integer, ByVal ChildrenQty As Integer, ByVal InfantsQty As Integer, ByVal MealPlan As String, ByVal Topcode As String, ByVal DepFlight As String, ByVal DepTime As DateTime, ByVal DTime As DateTime, ByVal DepTo As String, ByVal Remarks As String, ByVal DepRoomCount As Integer, ByVal DepTotPax As Integer, ByVal RoomPax As Integer, ByVal RoomType As String, ByVal Roomno As String, ByVal Dep As String)

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        Dim getReservationNo As String = ReservationNo
        Dim getFullName As String = FullName
        Dim getAdultQty As Integer = AdultQty
        Dim getChildrenQty As Integer = ChildrenQty
        Dim getInfantsQty As Integer = InfantsQty
        Dim getMealPlan As String = MealPlan
        Dim getTopcode As String = Topcode
        Dim getDepFlight As String = DepFlight
        Dim getDepTime As DateTime = DepTime
        Dim getDTime As DateTime = DTime
        Dim getDepTo As String = DepTo
        Dim getRemarks As String = Remarks
        Dim getDepRoomCount As Integer = DepRoomCount
        Dim getDepTotPax As Integer = DepTotPax
        Dim getRoomPax As Integer = RoomPax
        Dim getRoomType As String = RoomType
        Dim getRoomNo As String = Roomno
        Dim getDep As String = Dep

        dcInsertNewAcc = New SqlCommand("TempRptExpectedArrDepForSameDayDep_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date.AddDays(+1)
        dcInsertNewAcc.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = getReservationNo
        dcInsertNewAcc.Parameters.Add("@FullName", SqlDbType.VarChar).Value = getFullName
        dcInsertNewAcc.Parameters.Add("@AdultQty", SqlDbType.Int).Value = getAdultQty
        dcInsertNewAcc.Parameters.Add("@ChildrenQty", SqlDbType.Int).Value = getChildrenQty
        dcInsertNewAcc.Parameters.Add("@InfantsQty", SqlDbType.Int).Value = getInfantsQty
        dcInsertNewAcc.Parameters.Add("@MealPlan", SqlDbType.VarChar).Value = getMealPlan
        dcInsertNewAcc.Parameters.Add("@Topcode", SqlDbType.VarChar).Value = getTopcode
        dcInsertNewAcc.Parameters.Add("@DepFlight", SqlDbType.VarChar).Value = getDepFlight
        dcInsertNewAcc.Parameters.Add("@DepTime", SqlDbType.DateTime).Value = getDepTime
        dcInsertNewAcc.Parameters.Add("@DTime", SqlDbType.DateTime).Value = getDTime
        dcInsertNewAcc.Parameters.Add("@DepTo", SqlDbType.VarChar).Value = getDepTo
        dcInsertNewAcc.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = getRemarks
        dcInsertNewAcc.Parameters.Add("@DepRoomCount", SqlDbType.Int).Value = getDepRoomCount
        dcInsertNewAcc.Parameters.Add("@DepTotPax", SqlDbType.Int).Value = getDepTotPax
        dcInsertNewAcc.Parameters.Add("@RoomPax", SqlDbType.Int).Value = getRoomPax
        dcInsertNewAcc.Parameters.Add("@RoomType", SqlDbType.VarChar).Value = getRoomType
        dcInsertNewAcc.Parameters.Add("@RoomNo", SqlDbType.VarChar).Value = getRoomNo
        dcInsertNewAcc.Parameters.Add("@Dep", SqlDbType.VarChar).Value = getDep


        ' dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub UpdateroomnosProcessSuperior(ByVal PassingBedtype As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        pubroomcount = 0

        Dim PubRoomNo As String = ""
        Dim PubRoom As String = ""
        Dim PubBedtype As String = ""
        Dim GetPassingBedtype As String = PassingBedtype

        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[TempRptExpectedArrDep] where Status='Arrival'", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0

                    PubRoomNo = ""


                    Dim Resno As String = dsMain.Tables(0).Rows(DScount)(1).ToString

                    Dim getRoomDS As New DataSet
                    getRoomDS = DSGetAssignRoomnos(Resno, "Superior", GetPassingBedtype)


                    'If getRoomDS.Tables(0) Is DBNull.Value Or getRoomDS.Tables(0) Is Nothing Then

                    If getRoomDS Is Nothing Then
                        Dim erroe As Integer = 1
                    Else


                        If getRoomDS.Tables(0).Rows.Count > 0 Then

                            If getRoomDS.Tables(0).Rows.Count = 1 Then

                                PubRoomNo = getRoomDS.Tables(0).Rows(0)(0).ToString
                                pubroomcount = pubroomcount + 1

                            Else

                                Dim DSRommcount As Integer = getRoomDS.Tables(0).Rows.Count - 1

                                While DSRommcount >= 0

                                    PubRoomNo = PubRoomNo + "," + getRoomDS.Tables(0).Rows(DSRommcount)(0).ToString
                                    pubroomcount = pubroomcount + 1
                                    DSRommcount = DSRommcount - 1

                                End While

                            End If




                            UpdateRoom(PubRoomNo, Resno, pubroomcount, "Superior", GetPassingBedtype)

                        End If

                    End If

                    DScount = DScount - 1



                End While






            Else
                Exit Sub

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try



    End Sub
    Private Sub UpdateroomnosProcessDeluxe(ByVal PassingBedtype As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        pubroomcount = 0

        Dim PubRoomNo As String = ""
        Dim PubRoom As String = ""
        Dim PubBedtype As String = ""
        Dim GetPassingBedtype As String = PassingBedtype

        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[TempRptExpectedArrDep] where Status='Arrival'", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0

                    PubRoomNo = ""


                    Dim Resno As String = dsMain.Tables(0).Rows(DScount)(1).ToString

                    Dim getRoomDS As New DataSet
                    getRoomDS = DSGetAssignRoomnos(Resno, "Deluxe", GetPassingBedtype)


                    'If getRoomDS.Tables(0) Is DBNull.Value Or getRoomDS.Tables(0) Is Nothing Then

                    If getRoomDS Is Nothing Then
                        Dim erroe As Integer = 1
                    Else


                        If getRoomDS.Tables(0).Rows.Count > 0 Then

                            If getRoomDS.Tables(0).Rows.Count = 1 Then

                                PubRoomNo = getRoomDS.Tables(0).Rows(0)(0).ToString
                                pubroomcount = pubroomcount + 1

                            Else

                                Dim DSRommcount As Integer = getRoomDS.Tables(0).Rows.Count - 1

                                While DSRommcount >= 0

                                    PubRoomNo = PubRoomNo + "," + getRoomDS.Tables(0).Rows(DSRommcount)(0).ToString
                                    pubroomcount = pubroomcount + 1
                                    DSRommcount = DSRommcount - 1

                                End While

                            End If




                            UpdateRoom(PubRoomNo, Resno, pubroomcount, "Deluxe", GetPassingBedtype)

                        End If

                    End If

                    DScount = DScount - 1



                End While






            Else
                Exit Sub

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try



    End Sub
    Private Sub UpdateroomnosProcessStandard(ByVal PassingBedtype As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        pubroomcount = 0

        Dim PubRoomNo As String = ""
        Dim PubRoom As String = ""
        Dim PubBedtype As String = ""

        Dim GetPassingBedtype As String = PassingBedtype

        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[TempRptExpectedArrDep] where Status='Arrival'", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0

                    PubRoomNo = ""


                    Dim Resno As String = dsMain.Tables(0).Rows(DScount)(1).ToString

                    Dim getRoomDS As New DataSet
                    getRoomDS = DSGetAssignRoomnos(Resno, "Standard", GetPassingBedtype)


                    'If getRoomDS.Tables(0) Is DBNull.Value Or getRoomDS.Tables(0) Is Nothing Then

                    If getRoomDS Is Nothing Then
                        Dim erroe As Integer = 1
                    Else


                        If getRoomDS.Tables(0).Rows.Count > 0 Then

                            If getRoomDS.Tables(0).Rows.Count = 1 Then

                                PubRoomNo = getRoomDS.Tables(0).Rows(0)(0).ToString
                                pubroomcount = pubroomcount + 1

                            Else

                                Dim DSRommcount As Integer = getRoomDS.Tables(0).Rows.Count - 1

                                While DSRommcount >= 0

                                    PubRoomNo = PubRoomNo + "," + getRoomDS.Tables(0).Rows(DSRommcount)(0).ToString
                                    pubroomcount = pubroomcount + 1
                                    DSRommcount = DSRommcount - 1

                                End While

                            End If




                            UpdateRoom(PubRoomNo, Resno, pubroomcount, "Standard", GetPassingBedtype)

                        End If

                    End If

                    DScount = DScount - 1



                End While






            Else
                Exit Sub

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try



    End Sub
    Private Sub UpdateStatusArrivals()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()
            dcSearch = New SqlCommand("select convert(char(5),ResTime, 108) [FlightTime] , ReservationNo from dbo.[TempRptExpectedArrDep] where Status='Arrival'", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0

                    Dim FlightTime As DateTime = dsMain.Tables(0).Rows(DScount)(0)

                    Dim ReservationNo As String = dsMain.Tables(0).Rows(DScount)(1).ToString


                    Dim passShift As String = ""


                    'If FlightTime.Hour >= 17 And FlightTime.Hour <= 5 Then
                    If FlightTime.Hour >= 17 Then

                        passShift = "6.Night Arrival"

                    ElseIf (FlightTime.Hour >= 5 And FlightTime.Hour <= 12) Or (FlightTime.Hour >= 0 And FlightTime.Hour <= 5) Then

                        passShift = "4.Morning Arrival"

                    ElseIf FlightTime.Hour >= 12 And FlightTime.Hour <= 17 Then

                        passShift = "5.Afternoon/Evening Arrival"

                    End If




                    'Dim Time5PM As DateTime = " 1900-01-01 17:00:00.000"
                    'Dim Time5AM As DateTime = " 1900-01-01 05:00:00.000"
                    'Dim Time12PM As DateTime = " 1900-01-01 12:00:00.000"



                    'If FlightTime >= Time5PM And FlightTime <= Time5AM Then

                    '    passShift = "6.Night Arrival"

                    'ElseIf FlightTime >= Time5AM And FlightTime <= Time12PM Then

                    '    passShift = "4.Morning Arrival"

                    'ElseIf FlightTime >= Time12PM And FlightTime <= Time5PM Then

                    '    passShift = "5.Afternoon/Evening Arrival"

                    'End If







                    UpdateExpArrStatus(passShift, ReservationNo)


                    DScount = DScount - 1

                End While

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub UpdateStatusArrivalsAny()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()
            dcSearch = New SqlCommand("select convert(char(5),ResTime, 108) [FlightTime] , ReservationNo from dbo.[TempRptExpArrDepAnyDate] where Status='Arrival'", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0

                    Dim FlightTime As DateTime = dsMain.Tables(0).Rows(DScount)(0)

                    Dim ReservationNo As String = dsMain.Tables(0).Rows(DScount)(1).ToString


                    Dim passShift As String = ""


                    'If FlightTime.Hour >= 17 And FlightTime.Hour <= 5 Then
                    If FlightTime.Hour >= 17 Then

                        passShift = "6.Night Arrival"

                    ElseIf (FlightTime.Hour >= 5 And FlightTime.Hour <= 12) Or (FlightTime.Hour >= 0 And FlightTime.Hour <= 5) Then

                        passShift = "4.Morning Arrival"

                    ElseIf FlightTime.Hour >= 12 And FlightTime.Hour <= 17 Then

                        passShift = "5.Afternoon/Evening Arrival"

                    End If




                    'Dim Time5PM As DateTime = " 1900-01-01 17:00:00.000"
                    'Dim Time5AM As DateTime = " 1900-01-01 05:00:00.000"
                    'Dim Time12PM As DateTime = " 1900-01-01 12:00:00.000"



                    'If FlightTime >= Time5PM And FlightTime <= Time5AM Then

                    '    passShift = "6.Night Arrival"

                    'ElseIf FlightTime >= Time5AM And FlightTime <= Time12PM Then

                    '    passShift = "4.Morning Arrival"

                    'ElseIf FlightTime >= Time12PM And FlightTime <= Time5PM Then

                    '    passShift = "5.Afternoon/Evening Arrival"

                    'End If







                    UpdateExpArrStatusAny(passShift, ReservationNo)


                    DScount = DScount - 1

                End While

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub UpdateStatusDeparture()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()
            dcSearch = New SqlCommand("select convert(char(5),ResTime, 108) [FlightTime] , ReservationNo from dbo.[TempRptExpectedArrDep] where Status='Departure' ", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0

                    Dim FlightTime As DateTime = dsMain.Tables(0).Rows(DScount)(0)

                    Dim ReservationNo As String = dsMain.Tables(0).Rows(DScount)(1).ToString


                    Dim passShift As String = ""


                    ' If FlightTime.Hour >= 17 And FlightTime.Hour <= 5 Then

                    If FlightTime.Hour >= 17 Then



                        passShift = "3.Night Departure"

                    ElseIf (FlightTime.Hour >= 5 And FlightTime.Hour <= 12) Or (FlightTime.Hour >= 0 And FlightTime.Hour <= 5) Then



                        passShift = "1.Morning Departure"

                    ElseIf FlightTime.Hour >= 12 And FlightTime.Hour <= 17 Then

                        passShift = "2.Afternoon/Evening Departure"

                    End If


                    UpdateExpArrStatusAny(passShift, ReservationNo)


                    DScount = DScount - 1

                End While

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub UpdateStatusDepartureAny()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()
            dcSearch = New SqlCommand("select convert(char(5),ResTime, 108) [FlightTime] , ReservationNo from dbo.[TempRptExpArrDepAnyDate] where Status='Departure' ", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0

                    Dim FlightTime As DateTime = dsMain.Tables(0).Rows(DScount)(0)

                    Dim ReservationNo As String = dsMain.Tables(0).Rows(DScount)(1).ToString


                    Dim passShift As String = ""


                    ' If FlightTime.Hour >= 17 And FlightTime.Hour <= 5 Then

                    If FlightTime.Hour >= 17 Then



                        passShift = "3.Night Departure"

                    ElseIf (FlightTime.Hour >= 5 And FlightTime.Hour <= 12) Or (FlightTime.Hour >= 0 And FlightTime.Hour <= 5) Then



                        passShift = "1.Morning Departure"

                    ElseIf FlightTime.Hour >= 12 And FlightTime.Hour <= 17 Then

                        passShift = "2.Afternoon/Evening Departure"

                    End If


                    UpdateExpArrStatusAny(passShift, ReservationNo)


                    DScount = DScount - 1

                End While

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub UpdateDepTotPax()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()
            dcSearch = New SqlCommand("select ReportDate, RoomNo from dbo.[TempRptExpectedArrDep] where Status like '%Departure' ", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0


                    Dim DepDate As DateTime = Convert.ToDateTime(dsMain.Tables(0).Rows(DScount)(0))
                    Dim RoomNo As Integer = dsMain.Tables(0).Rows(DScount)(1)

                    UpdateDepTotPax(DepDate, RoomNo)


                    DScount = DScount - 1

                End While

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub UpdateDepSameDayArrival()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()
            'dcSearch = New SqlCommand("SELECT dbo.[Reservation.Master].Resno,   sum (dbo.[Reservation.Room].RoomCount) as RoomCount,sum (dbo.[Reservation.Room].TotPax) as TotPax  FROM   dbo.[Reservation.Room] INNER JOIN  dbo.[Reservation.Master] ON dbo.[Reservation.Room].ReservationNo = dbo.[Reservation.Master].ResNo  where   dbo.[Reservation.Master].arrdate=@ResDate  and dbo.[Reservation.Master].depdate=@ResDate  and  dbo.[Reservation.Master].Status='OPEN' group by dbo.[Reservation.Master].Resno", Conn)


            dcSearch = New SqlCommand("SELECT dbo.[Reservation.Master].Resno,dbo.[Reservation.Master].guest , dbo.[Reservation.Master].AdultQty,dbo.[Reservation.Master].ChildrenQty,dbo.[Reservation.Master].InfantsQty,dbo.[Reservation.Master].MealPlan,dbo.[Reservation.Master].Topcode,dbo.[Reservation.Master].DepFlight,dbo.[Reservation.Master].DepTime,dbo.[Reservation.Master].Remarks , sum (dbo.[Reservation.Room].RoomCount) as RoomCount,sum (dbo.[Reservation.Room].TotPax) as TotPax  FROM   dbo.[Reservation.Room] INNER JOIN  dbo.[Reservation.Master] ON dbo.[Reservation.Room].ReservationNo = dbo.[Reservation.Master].ResNo  where   dbo.[Reservation.Master].arrdate=@ResDate and dbo.[Reservation.Master].depdate=@ResDate  and  dbo.[Reservation.Master].Status='OPEN' group by dbo.[Reservation.Master].Resno,dbo.[Reservation.Master].guest , dbo.[Reservation.Master].AdultQty,dbo.[Reservation.Master].ChildrenQty,dbo.[Reservation.Master].InfantsQty,dbo.[Reservation.Master].MealPlan,dbo.[Reservation.Master].Topcode,dbo.[Reservation.Master].DepFlight,dbo.[Reservation.Master].DepTime ,dbo.[Reservation.Master].Remarks", Conn)

            dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date.AddDays(+1)
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)





            If dsMain Is Nothing Then
                Dim aa As Integer = 10


            Else




                If dsMain.Tables(0).Rows.Count > 0 Then


                    Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                    While DScount >= 0





                        Dim ReservationNo As String = dsMain.Tables(0).Rows(DScount)(0)
                        Dim FullName As String = dsMain.Tables(0).Rows(DScount)(1)
                        Dim AdultQty As Integer = dsMain.Tables(0).Rows(DScount)(2)
                        Dim ChildrenQty As Integer = dsMain.Tables(0).Rows(DScount)(3)
                        Dim InfantsQty As Integer = dsMain.Tables(0).Rows(DScount)(4)
                        Dim MealPlan As String = dsMain.Tables(0).Rows(DScount)(5)
                        Dim Topcode As String = dsMain.Tables(0).Rows(DScount)(6)
                        Dim DepFlight As String = dsMain.Tables(0).Rows(DScount)(7)
                        Dim DepTime As DateTime = Convert.ToDateTime(dsMain.Tables(0).Rows(DScount)(8))
                        Dim Remarks As String = dsMain.Tables(0).Rows(DScount)(9)
                        Dim DepRoomCount As Integer = dsMain.Tables(0).Rows(DScount)(10)
                        Dim DepTotPax As Integer = dsMain.Tables(0).Rows(DScount)(11)


                        InsertTempDepSameDay(ReservationNo,
                                             FullName,
                                             AdultQty,
                                             ChildrenQty,
                                             InfantsQty,
                                             MealPlan,
                                             Topcode,
                                             DepFlight,
                                             DepTime,
                                            "1900-01-01",
                                             "",
                                             Remarks,
                                             DepRoomCount,
                                             DepTotPax,
                                             DepTotPax,
                                             "",
                                             "",
                                            DepTime)

                        DScount = DScount - 1

                    End While

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub UpdateArrTodayNotCheckinDepTom()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        


        Try
            Conn.Open()
            'dcSearch = New SqlCommand("SELECT dbo.[Reservation.Master].Resno,   sum (dbo.[Reservation.Room].RoomCount) as RoomCount,sum (dbo.[Reservation.Room].TotPax) as TotPax  FROM   dbo.[Reservation.Room] INNER JOIN  dbo.[Reservation.Master] ON dbo.[Reservation.Room].ReservationNo = dbo.[Reservation.Master].ResNo  where   dbo.[Reservation.Master].arrdate=@ResDate  and dbo.[Reservation.Master].depdate=@ResDate  and  dbo.[Reservation.Master].Status='OPEN' group by dbo.[Reservation.Master].Resno", Conn)


            dcSearch = New SqlCommand("select Resno from [reservation.master] where status='OPEN' AND arrdate=@ArrDate and depdate=@DepDate and Resno not in (select ReservationNo from [GuestRegistration])", Conn)

            dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            dcSearch.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date.AddDays(+1)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)





            If dsMain Is Nothing Then
                Dim aa As Integer = 10


            Else


                If dsMain.Tables(0).Rows.Count > 0 Then


                   



                    Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                    While DScount >= 0


                        'Conn.Open()
                        'dcSearch = New SqlCommand("SELECT dbo.[Reservation.Master].Resno,   sum (dbo.[Reservation.Room].RoomCount) as RoomCount,sum (dbo.[Reservation.Room].TotPax) as TotPax  FROM   dbo.[Reservation.Room] INNER JOIN  dbo.[Reservation.Master] ON dbo.[Reservation.Room].ReservationNo = dbo.[Reservation.Master].ResNo  where   dbo.[Reservation.Master].arrdate=@ResDate  and dbo.[Reservation.Master].depdate=@ResDate  and  dbo.[Reservation.Master].Status='OPEN' group by dbo.[Reservation.Master].Resno", Conn)
                        Dim daMain2 As New SqlDataAdapter
                        Dim dsMain2 As New DataSet
                        Dim dcSearch2 As New SqlCommand

                        'dcSearch2 = New SqlCommand("SELECT dbo.[Reservation.Master].Resno,dbo.[Reservation.Master].guest , dbo.[Reservation.Master].AdultQty,dbo.[Reservation.Master].ChildrenQty,dbo.[Reservation.Master].InfantsQty,dbo.[Reservation.Master].MealPlan,dbo.[Reservation.Master].Topcode,dbo.[Reservation.Master].DepFlight,dbo.[Reservation.Master].DepTime,dbo.[Reservation.Master].Remarks , sum (dbo.[Reservation.Room].RoomCount) as RoomCount,sum (dbo.[Reservation.Room].TotPax) as TotPax  FROM   dbo.[Reservation.Room] INNER JOIN  dbo.[Reservation.Master] ON dbo.[Reservation.Room].ReservationNo = dbo.[Reservation.Master].ResNo  where dbo.[Reservation.Master].Resno=@Resno   and  dbo.[Reservation.Master].Status='OPEN' group by dbo.[Reservation.Master].Resno,dbo.[Reservation.Master].guest , dbo.[Reservation.Master].AdultQty,dbo.[Reservation.Master].ChildrenQty,dbo.[Reservation.Master].InfantsQty,dbo.[Reservation.Master].MealPlan,dbo.[Reservation.Master].Topcode,dbo.[Reservation.Master].DepFlight,dbo.[Reservation.Master].DepTime ,dbo.[Reservation.Master].Remarks", Conn)

                        'dcSearch2 = New SqlCommand("SELECT dbo.[Reservation.Master].Resno, dbo.[Reservation.Master].Guest, dbo.[Reservation.Master].AdultQty, dbo.[Reservation.Master].ChildrenQty, dbo.[Reservation.Master].InfantsQty, dbo.[Reservation.Master].MealPlan, dbo.[Reservation.Master].Topcode, dbo.[Reservation.Master].DepFlight, dbo.[Reservation.Master].DepTime, dbo.[Reservation.Master].Remarks, SUM(dbo.[Reservation.Room].RoomCount) AS RoomCount, SUM(dbo.[Reservation.Room].TotPax) AS TotPax,  dbo.ReservertionRoomAssign.RoomNo FROM dbo.[Reservation.Room] INNER JOIN dbo.[Reservation.Master] ON dbo.[Reservation.Room].ReservationNo = dbo.[Reservation.Master].ResNo LEFT OUTER JOIN  dbo.ReservertionRoomAssign ON dbo.[Reservation.Master].ResNo = dbo.ReservertionRoomAssign.ResNo WHERE     (dbo.[Reservation.Master].ResNo = @Resno) AND (dbo.[Reservation.Master].Status = 'OPEN') GROUP BY dbo.[Reservation.Master].Guest, dbo.[Reservation.Master].AdultQty, dbo.[Reservation.Master].ChildrenQty, dbo.[Reservation.Master].InfantsQty, dbo.[Reservation.Master].MealPlan, dbo.[Reservation.Master].Topcode, dbo.[Reservation.Master].DepFlight, dbo.[Reservation.Master].DepTime, dbo.[Reservation.Master].Remarks, dbo.[Reservation.Master].ResNo, dbo.ReservertionRoomAssign.RoomNo", Conn)



                        dcSearch2 = New SqlCommand("SELECT dbo.[Reservation.Master].ResNo, dbo.[Reservation.Master].Guest, dbo.ReservertionRoomAssign.RoomPax, dbo.[Reservation.Master].MealPlan, dbo.[Reservation.Master].Topcode, dbo.[Reservation.Master].DepFlight, dbo.[Reservation.Master].DepTime, dbo.[Reservation.Master].Remarks, dbo.ReservertionRoomAssign.RoomNo, dbo.ReservertionRoomAssign.RoomCount FROM  dbo.[Reservation.Master] LEFT OUTER JOIN  dbo.ReservertionRoomAssign ON dbo.[Reservation.Master].ResNo = dbo.ReservertionRoomAssign.ResNo WHERE  (dbo.[Reservation.Master].ResNo = @Resno) AND (dbo.[Reservation.Master].Status = 'OPEN')", Conn)



                        dcSearch2.Parameters.Add("@Resno", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(0)
                        daMain2 = New SqlDataAdapter()
                        daMain2.SelectCommand = dcSearch2
                        daMain2.Fill(dsMain2)


                        Dim DScount2 As Integer = dsMain2.Tables(0).Rows.Count - 1

                        While DScount2 >= 0

                            'MsgBox("resno:" + dsMain2.Tables(0).Rows(DScount)(0).ToString)


                            Dim ReservationNo As String = dsMain.Tables(0).Rows(DScount)(0)
                            Dim FullName As String = dsMain2.Tables(0).Rows(DScount2)(1)
                            Dim AdultQty As Integer = dsMain2.Tables(0).Rows(DScount2)(2)
                            ' Dim ChildrenQty As Integer = dsMain2.Tables(0).Rows(0)(3)
                            Dim ChildrenQty As Integer = 0

                            'Dim InfantsQty As Integer = dsMain2.Tables(0).Rows(0)(4)
                            Dim InfantsQty As Integer = 0

                            Dim MealPlan As String = dsMain2.Tables(0).Rows(DScount2)(3)
                            Dim Topcode As String = dsMain2.Tables(0).Rows(DScount2)(4)
                            Dim DepFlight As String = dsMain2.Tables(0).Rows(DScount2)(5)
                            Dim DepTime As DateTime = Convert.ToDateTime(dsMain2.Tables(0).Rows(DScount2)(6))
                            Dim Remarks As String = dsMain2.Tables(0).Rows(DScount2)(7)
                            Dim DepRoomCount As Integer = dsMain2.Tables(0).Rows(DScount2)(9)
                            Dim DepTotPax As Integer = dsMain2.Tables(0).Rows(DScount2)(2)





                            Dim RoomNO As String = IIf(IsDBNull(dsMain2.Tables(0).Rows(DScount2)(8)), "0", dsMain2.Tables(0).Rows(DScount2)(8))

                            InsertTempDepSameDay(ReservationNo,
                                                 FullName,
                                                 AdultQty,
                                                 ChildrenQty,
                                                 InfantsQty,
                                                 MealPlan,
                                                 Topcode,
                                                 DepFlight,
                                                 DepTime,
                                                DepTime,
                                                 "",
                                                 Remarks,
                                                 DepRoomCount,
                                                 DepTotPax,
                                                 DepTotPax,
                                                 "",
                                                 RoomNO,
                                                 DepTime)


                            DScount2 = DScount2 - 1

                        End While

                        DScount = DScount - 1

                    End While

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub




    Private Sub UpdateRoom(ByVal PassPubroomnos As String, ByVal PassResno As String, ByVal Passpubroomcount As Integer, ByVal PassRoom As String, ByVal PassBedtype As String)

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getPassPubroomnos As String = PassPubroomnos
            Dim getPassResno As String = PassResno
            Dim getPasspubroomcount As Integer = Passpubroomcount
            Dim getPassRoom As String = PassRoom
            Dim getPassBedtype As String = PassBedtype


            dcInsertNewAcc = New SqlCommand("UpdateExpectedArrivalRooms_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = getPassResno
            dcInsertNewAcc.Parameters.Add("@PubRoom", SqlDbType.VarChar).Value = getPassPubroomnos
            dcInsertNewAcc.Parameters.Add("@RoomCount", SqlDbType.Int).Value = getPasspubroomcount
            dcInsertNewAcc.Parameters.Add("@Room", SqlDbType.VarChar).Value = getPassRoom
            dcInsertNewAcc.Parameters.Add("@Bedtype", SqlDbType.VarChar).Value = getPassBedtype


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub UpdateExpArrStatus(ByVal PassStatus As String, ByVal PassResno As String)

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getPassStatus As String = PassStatus
            Dim getPassResno As String = PassResno
            

            dcInsertNewAcc = New SqlCommand("UpdateExpArrivalStatus_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = getPassResno
            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = PassStatus



            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub UpdateExpArrStatusAny(ByVal PassStatus As String, ByVal PassResno As String)

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getPassStatus As String = PassStatus
            Dim getPassResno As String = PassResno


            dcInsertNewAcc = New SqlCommand("UpdateExpArrivalStatusAny_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = getPassResno
            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = PassStatus



            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub UpdateDepTotPax(ByVal PassDepdate As DateTime, ByVal PassRoomno As Integer)

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getPassDepdate As DateTime = PassDepdate
            Dim getPassRoomno As Integer = PassRoomno


            dcInsertNewAcc = New SqlCommand("UpdateDepTotPax_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Depdate", SqlDbType.DateTime).Value = getPassDepdate
            dcInsertNewAcc.Parameters.Add("@rmno", SqlDbType.Int).Value = getPassRoomno



            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Function DSGetAssignRoomnos(ByVal Passresno As String, ByVal PassRoom As String, ByVal PassBedType As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim getPassresno As String = Passresno
            Dim getPassRoom As String = PassRoom
            Dim getPassBedType As String = PassBedType



            dcSearch = New SqlCommand("select Roomno,Room,BedType from ReservertionRoomAssign where ResNo=@Reservationno and Room=@Room and BedType=@BedType", Conn)
            dcSearch.Parameters.Add("@Reservationno", SqlDbType.VarChar).Value = getPassresno
            dcSearch.Parameters.Add("@Room", SqlDbType.VarChar).Value = getPassRoom
            dcSearch.Parameters.Add("@BedType", SqlDbType.VarChar).Value = getPassBedType



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count

            'If getRoomDS.Tables(0) Is DBNull.Value Or getRoomDS.Tables(0) Is Nothing Or getRoomDS.Tables(0).Rows.Count = 0 Then
            '    Exit Function


            If count = 0 Or count < 0 Then
                DSGetAssignRoomnos = Nothing

            Else
                DSGetAssignRoomnos = dsMain
            End If



            'If count > 0 Then
            '    DSGetAssignRoomnos = dsMain
            'End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function
    Private Sub InsertAssignRoom(ByVal PassResNo As String, ByVal PassRoom As String, ByVal PassBedType As String, ByVal PassRoomCount As Integer, ByVal PassRoomPax As Integer, ByVal PassResDate As DateTime, ByVal RoomNo As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand
        Dim sqlstr As String = ""

        Try


            Conn.Open()


            Dim getPassResNo As String = PassResNo
            Dim getPassRoom As String = PassRoom
            Dim getPassBedType As String = PassBedType
            Dim getPassRoomCount As Integer = PassRoomCount
            Dim getPassRoomPax As Integer = PassRoomPax
            Dim getPassResDate As DateTime = PassResDate
            Dim getRoomNo As String = RoomNo

            sqlstr = "insert into TempResRoomAssign(ResNo,Room,BedType,RoomCount,RoomPax,ResDate,RoomNo) values(@ResNo,@Room,@BedType,@RoomCount,@RoomPax,@ResDate,@RoomNo)"

            dcExec = New SqlCommand(sqlstr, Conn)
            dcExec.Parameters.Add("@ResNo", SqlDbType.NVarChar).Value = getPassResNo
            dcExec.Parameters.Add("@Room", SqlDbType.NVarChar).Value = getPassRoom
            dcExec.Parameters.Add("@BedType", SqlDbType.NVarChar).Value = getPassBedType
            dcExec.Parameters.Add("@RoomCount", SqlDbType.Int).Value = getPassRoomCount
            dcExec.Parameters.Add("@RoomPax", SqlDbType.Int).Value = getPassRoomPax
            dcExec.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = getPassResDate
            dcExec.Parameters.Add("@RoomNo", SqlDbType.NVarChar).Value = getRoomNo

            dcExec.ExecuteNonQuery()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            dcExec.Dispose()
        End Try


    End Sub
    Private Sub InsertAssignRoomOri(ByVal PassResNo As String, ByVal PassRoom As String, ByVal PassBedType As String, ByVal PassRoomCount As Integer, ByVal PassRoomPax As Integer, ByVal PassResDate As DateTime, ByVal RoomNo As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand
        Dim sqlstr As String = ""

        Try


            Conn.Open()


            Dim getPassResNo As String = PassResNo
            Dim getPassRoom As String = PassRoom
            Dim getPassBedType As String = PassBedType
            Dim getPassRoomCount As Integer = PassRoomCount
            Dim getPassRoomPax As Integer = PassRoomPax
            Dim getPassResDate As DateTime = PassResDate
            Dim getRoomNo As String = RoomNo

            sqlstr = "insert into ReservertionRoomAssign(ResNo,Room,BedType,RoomCount,RoomPax,ResDate,RoomNo) values(@ResNo,@Room,@BedType,@RoomCount,@RoomPax,@ResDate,@RoomNo)"

            dcExec = New SqlCommand(sqlstr, Conn)
            dcExec.Parameters.Add("@ResNo", SqlDbType.NVarChar).Value = getPassResNo
            dcExec.Parameters.Add("@Room", SqlDbType.NVarChar).Value = getPassRoom
            dcExec.Parameters.Add("@BedType", SqlDbType.NVarChar).Value = getPassBedType
            dcExec.Parameters.Add("@RoomCount", SqlDbType.Int).Value = getPassRoomCount
            dcExec.Parameters.Add("@RoomPax", SqlDbType.Int).Value = getPassRoomPax
            dcExec.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = getPassResDate
            dcExec.Parameters.Add("@RoomNo", SqlDbType.NVarChar).Value = getRoomNo

            dcExec.ExecuteNonQuery()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            dcExec.Dispose()
        End Try


    End Sub
    Private Sub GetReservations()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Dim dcExec As New SqlCommand
        Dim sqlStr As String

        pubroomcount = 0

        Dim PubRoomNo As String = ""
        

        Dim getDate As DateTime = dtDate.DateTime.Date.AddDays(+1)

        Try
            Conn.Open()


            DeleteResRoomAssignTemp(getDate)



            ' dcSearch = New SqlCommand("SELECT TOP (100) PERCENT dbo.[Reservation.Master].ResNo, dbo.[Reservation.Room].Room, dbo.[Reservation.Room].Roomtype, dbo.[Reservation.Room].RoomCount,dbo.[Reservation.Room].TotPax, dbo.[Reservation.Master].ResDate FROM   dbo.[Reservation.Room] INNER JOIN  dbo.[Reservation.Master] ON dbo.[Reservation.Room].ReservationNo = dbo.[Reservation.Master].ResNo  where   dbo.[Reservation.Master].ResDate=@ARRDATE  and  dbo.[Reservation.Master].Status='OPEN' ORDER BY    dbo.[Reservation.Master].ResNo", Conn)


            dcSearch = New SqlCommand("SELECT dbo.[Reservation.Room].Room,dbo.[Reservation.Room].Roomtype , dbo.[Reservation.Master].ResNo,sum (dbo.[Reservation.Room].RoomCount) as RoomCount,sum (dbo.[Reservation.Room].TotPax) as TotPax  FROM   dbo.[Reservation.Room] INNER JOIN  dbo.[Reservation.Master] ON dbo.[Reservation.Room].ReservationNo = dbo.[Reservation.Master].ResNo  where   dbo.[Reservation.Master].ResDate=@ARRDATE and  dbo.[Reservation.Master].Status='OPEN' group by dbo.[Reservation.Room].Room,dbo.[Reservation.Room].Roomtype,dbo.[Reservation.Master].ResNo", Conn)


            dcSearch.Parameters.Add("@ARRDATE", SqlDbType.DateTime).Value = getDate

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0

                    PubRoomNo = ""


                    Dim Resno As String = dsMain.Tables(0).Rows(DScount)(2).ToString
                    Dim RoomCount As Integer = Convert.ToInt16(dsMain.Tables(0).Rows(DScount)(3).ToString)
                    Dim Room As String = dsMain.Tables(0).Rows(DScount)(0).ToString
                    Dim RoomType As String = dsMain.Tables(0).Rows(DScount)(1).ToString
                    Dim Totpax As Integer = Convert.ToInt16(dsMain.Tables(0).Rows(DScount)(4).ToString)
                    Dim ResDate As DateTime = getDate


                    '----- check already added 


                        If RoomCount = 1 Then

                        'Dim dscheckAddbefore As New DataSet
                        'dscheckAddbefore = DSCheckAddRoomnos(Resno)

                        'If dscheckAddbefore Is Nothing Then

                        InsertAssignRoom(Resno, Room, RoomType, RoomCount, Totpax, ResDate, "")

                        'End If



                    Else


                        Dim DSRommcount As Integer = RoomCount


                        Dim TotpaxPerroomInt As Integer = Totpax / RoomCount
                        Dim TotpaxPerroomDec As Decimal = Totpax / RoomCount

                        Dim NewTotpaxPerroom As Integer = 0
                        Dim BalanceTotpaxPerRoom As Integer = 0

                        If TotpaxPerroomDec > TotpaxPerroomInt Then
                            NewTotpaxPerroom = TotpaxPerroomInt + 1
                            InsertAssignRoom(Resno, Room, RoomType, 1, NewTotpaxPerroom, ResDate, "")
                            BalanceTotpaxPerRoom = (Totpax - NewTotpaxPerroom) / (RoomCount - 1)
                            DSRommcount = DSRommcount - 1

                        Else

                            InsertAssignRoom(Resno, Room, RoomType, 1, TotpaxPerroomInt, ResDate, "")
                            BalanceTotpaxPerRoom = (Totpax - TotpaxPerroomInt) / (RoomCount - 1)
                            DSRommcount = DSRommcount - 1

                        End If


                        While DSRommcount > 0

                            InsertAssignRoom(Resno, Room, RoomType, 1, BalanceTotpaxPerRoom, ResDate, "")
                            DSRommcount = DSRommcount - 1

                        End While




                        'Dim DSRommcount As Integer = Convert.ToInt16(dsMain.Tables(0).Rows(DScount)(3).ToString) - 1
                        'Dim TotpaxPerroom As Integer = Totpax / RoomCount

                        'While DSRommcount >= 0

                        '    InsertAssignRoom(Resno, Room, RoomType, 1, TotpaxPerroom, ResDate, "")
                        '    DSRommcount = DSRommcount - 1

                        'End While


                        'End If

                    End If

            IsUpdateAll(Resno)

            DScount = DScount - 1




                End While

            Else
                Exit Sub

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try


    End Sub
    Function DSCheckAddRoomnos(ByVal PassResDate As DateTime) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim GetPassResDate As DateTime = PassResDate


            dcSearch = New SqlCommand("select * from ReservertionRoomAssign where ResDate=@ResDate", Conn)

            ' dcSearch = New SqlCommand("select * from [reservation.master] where resdate=@ResDate and Resno not in (select Resno from [ReservertionRoomAssign] where resdate=@ResDate )", Conn)
            dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = GetPassResDate

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckAddRoomnos = dsMain
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
    Function DSCheckAddRoomnosAlready(ByVal PassResDate As DateTime) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim GetPassResDate As DateTime = PassResDate


            ' dcSearch = New SqlCommand("select * from ReservertionRoomAssign where ResDate=@ResDate", Conn)

            dcSearch = New SqlCommand("select * from [reservation.master] where status='OPEN' AND resdate=@ResDate and Resno not in (select Resno from [ReservertionRoomAssign] where resdate=@ResDate )", Conn)
            dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = GetPassResDate

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckAddRoomnosAlready = dsMain
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

    Function IsUpdateAll(ByVal PassResno As String) As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand
        Dim sqlStr As String

        Try
            Conn.Open()

            Dim GetPassResno As String = PassResno

            dcExec = New SqlCommand("spResAssignRoom", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            dcExec.Parameters.Add("@ResNo", SqlDbType.NVarChar).Value = GetPassResno ' gvMain.GetRowCellDisplayText(i, "ResNo")
            'dcExec.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = gvMain.GetRowCellDisplayText(i, "ResDate")
            'dcExec.Parameters.Add("@RoomNo", SqlDbType.NVarChar).Value = gvMain.GetRowCellDisplayText(i, "RoomNo")

            dcExec.ExecuteNonQuery()




            Return True
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcExec.Dispose()

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

            dcIns = New SqlCommand("LoadRptExpectedArrival_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

            dcIns.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            ReportName = "NewExpected_Arrival_&_Departures.rpt"
            rptTitle = "NewExpected_Arrival_&_Departures"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = "paraArrdate"
            frmReportViewer.paraRepVale = dtDate.Text.ToString

            'frmReportViewer.paraRepName2 = "paratoDate"
            ' frmReportViewer.paraRepVale2 = ""

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub
    Private Sub printreportAny()
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

            dcIns = New SqlCommand("LoadRptExpectedArrivalAny_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

            dcIns.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            ReportName = "NewExpected_Arrival_&_Departures_Any.rpt"
            rptTitle = "NewExpected_Arrival_&_Departures-Any Date"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = "paraArrdate"
            frmReportViewer.paraRepVale = dtDate.Text.ToString

            'frmReportViewer.paraRepName2 = "paratoDate"
            ' frmReportViewer.paraRepVale2 = ""

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub NewfrmExpectedArrivalDeparture_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub btReportAny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReportAny.Click
        InsertTempAny()
        UpdateStatusArrivalsAny()
        UpdateStatusDepartureAny()
        printreportAny()
    End Sub
End Class