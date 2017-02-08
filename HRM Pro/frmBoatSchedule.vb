Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmBoatSchedule
    Public PubAvaliable As Integer = 0
    Public PubNewAvilabe As Integer = 0
    Public PubBoatScheduleMasterID As String = 0
    Public PubScheduleDetailID As String = 0
    Public ReportName As String
    Public rptTitle As String
    Public SF As String = ""
    Dim unboundDataOutLetBill As New ArrayList()
    Private Sub frmBoatSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()


        gvArr.OptionsSelection.MultiSelect = True
        gvArr.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect

        LoadBoatNo()
        LoadBoatNoDeparture()


        LoadBoatScheduleMasterDetail()
        LoadBoatScheduleMasterDetailDeparture()

        dtDateDep.Text = Now.Date
        dtDateArr.Text = Now.Date
        dtSum.Text = Now.Date


        cmbStartPoint.SelectedIndex = 0
        cmbEndPoint.SelectedIndex = 0
        cmbDes1.SelectedIndex = 0
        cmbDes2.SelectedIndex = 0
        cmbDes3.SelectedIndex = 0
        cmbDes4.SelectedIndex = 0

        'cmbBoatNoDeparture.SelectedIndex = 0
        'cmbBoatNo.SelectedIndex = 0


        cmbStartPointDep.SelectedIndex = 0
        cmbEndPointDep.SelectedIndex = 0
        cmbDes1Dep.SelectedIndex = 0
        cmbDes2Dep.SelectedIndex = 0
        cmbDes3Dep.SelectedIndex = 0
        cmbDes4Dep.SelectedIndex = 0

        tabBoatSchedDetails.TabPages(1).PageEnabled = False
        tabBoatSchedDetails.TabPages(2).PageEnabled = False

    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddArr.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatScheduling", "Add")

        If CheckAccess = True Then


            If String.Compare(btnAddArr.Text, "Add Arrivals", False) = 0 Then

                ClearFieldsArrival()
                btnAddArr.Text = "Save"
                btnAddDep.Enabled = False
                btnArrInactive.Enabled = False
                btnDepInactive.Enabled = False
                tabBoatSchedDetails.TabPages(1).PageEnabled = True
                tabBoatSchedDetails.SelectedTabPageIndex = 1



            Else

                'Dim dscheckAddbefore As New DataSet
                'dscheckAddbefore = DSCheckInsertBoatTemp()


                'If dscheckAddbefore Is Nothing Then

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Boat Schedule Details", "Save  Boat  Schedule", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    PubBoatScheduleMasterID = System.Guid.NewGuid().ToString()
                    PubScheduleDetailID = System.Guid.NewGuid().ToString()

                    InsertBoatSchedule(PubBoatScheduleMasterID, PubScheduleDetailID)

                    DelBoatScheduleTemp()



                End If


                '    Else
                '    MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                'End If


                LoadBoatScheduleMasterDetail()

                btnAddArr.Text = "Add Arrivals"
                btnAddDep.Enabled = True
                btnArrInactive.Enabled = True
                btnDepInactive.Enabled = True
                tabBoatSchedDetails.TabPages(1).PageEnabled = False
                tabBoatSchedDetails.TabPages(2).PageEnabled = False
                tabBoatSchedDetails.SelectedTabPageIndex = 0
                Exit Sub
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Sub ClearFieldsArrival()

        txtAvailable.Text = ""
        txtAvailable.Text = ""


        ' cmbBoatNo.SelectedIndex = 0
        gcArr.DataSource = Nothing

        txtOthers.Text = ""
        gcAssignBSchedule.DataSource = Nothing

        cmbStartPoint.SelectedIndex = 0
        cmbEndPoint.SelectedIndex = 0
        cmbDes1.SelectedIndex = 0
        cmbDes2.SelectedIndex = 0
        cmbDes3.SelectedIndex = 0
        cmbDes4.SelectedIndex = 0

        DelBoatScheduleTemp()


    End Sub
    Sub ClearFieldsDeparture()

        txtTotSeatsDep.Text = ""
        txtAvailableDep.Text = ""

        'cmbBoatNoDeparture.SelectedIndex = -1
        'cmbBoatNoDeparture.SelectedIndex = 0
        gcDep.DataSource = Nothing

        txtothersDepartre.Text = ""
        gcAssignBScheduleDep.DataSource = Nothing

        cmbStartPointDep.SelectedIndex = 0
        cmbEndPointDep.SelectedIndex = 0
        cmbDes1Dep.SelectedIndex = 0
        cmbDes2Dep.SelectedIndex = 0
        cmbDes3Dep.SelectedIndex = 0
        cmbDes4Dep.SelectedIndex = 0

        DelBoatScheduleTemp()

    End Sub
    Private Sub DelBoatScheduleTemp()
        Try


            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim CurrentUser As String = CurrUser

            dcInsertNewAcc = New SqlCommand("DeleteBoatScheduleTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcInsertNewAcc.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNo.Text.Trim
            dcInsertNewAcc.Parameters.Add("@UserId", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        End Try

    End Sub


    Function DSCheckAddBoatScheduleTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim boatno As String = cmbBoatNo.Text.Trim
            dcSearch = New SqlCommand("select * from dbo.[BoatSchedule.Temp] where BoatNo=@boatno", Conn)
            dcSearch.Parameters.Add("@boatno", SqlDbType.VarChar).Value = boatno
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckAddBoatScheduleTemp = dsMain
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

    Private Sub btnViewResevations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewResevations.Click
        LoadReservationArrivalDetails()

    End Sub
    Private Sub LoadReservationArrivalDetails()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            ' dcSearch = New SqlCommand("select ResNo,convert(char(5), ArrTime, 108) [ArrTime],ArrFlight,Guest,AdultQty,ChildrenQty,InfantsQty from dbo.[Reservation.Master] where  ArrDate=@ArrDate order by ArrTime", Conn)

            dcSearch = New SqlCommand("select ResNo,convert(char(5), ArrTime, 108) [ArrTime],ArrFlight,Guest,AdultQty,ChildrenQty,InfantsQty from dbo.[Reservation.Master] where dbo.[Reservation.Master].status='OPEN' AND ArrDate=@ArrDate and ResNo not in (SELECT dbo.[BoatSchedule.Detail].Resno FROM  dbo.[BoatSchedule.Master] INNER JOIN  dbo.[BoatSchedule.Detail] ON dbo.[BoatSchedule.Master].ScheduleDetailID = dbo.[BoatSchedule.Detail].BoatScheduleMasterID LEFT OUTER JOIN dbo.[Reservation.Master] ON dbo.[BoatSchedule.Detail].ResNo = dbo.[Reservation.Master].ResNo WHERE   dbo.[BoatSchedule.Master].TripDate = @ArrDate  and dbo.[BoatSchedule.Master].Status='OPEN' and dbo.[BoatSchedule.Master].ReservationType='Arrival' ) order by ArrTime", Conn)

            dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDateArr.DateTime.Date

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            If (Not dsMain Is Nothing) Then
                gcArr.DataSource = dsMain.Tables(0)

            End If

            If dsMain.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("No Records", "Arrivals", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

          


            gcArr.Refresh()


            Dim dtcol As New DataColumn("select", System.Type.GetType("System.Boolean"))
            dsMain.Tables(0).Columns.Add(dtcol)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadBoatNo()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select BoatNo from [Boat.Master] where Status='OPEN' order by BoatNo", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbBoatNo.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            '  cmbBoatNo.SelectedIndex = 1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadTotalSeats(ByVal boatno As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Passboatno As String = boatno

            dcSearch = New SqlCommand("select MaxPassengers from [Boat.Master] where  BoatNo=@Passboatno", Conn)
            dcSearch.Parameters.Add("@PASSBOATNO", SqlDbType.VarChar).Value = Passboatno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            txtTotalSeats.Text = dsMain.Tables(0).Rows(0)(0).ToString()
            txtAvailable.Text = dsMain.Tables(0).Rows(0)(0).ToString()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub cmbBoatNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBoatNo.SelectedIndexChanged
        LoadTotalSeats(cmbBoatNo.Text.Trim)
    End Sub

    Private Sub InsertBoatScheduleTemp(ByVal Resno As String, ByVal Guest As String, ByVal PaxCount As Integer)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim getResno As String = Resno
        Dim getGuest As String = Guest
        Dim getTotpax As Integer = PaxCount
        Dim CurrentUser As String = CurrUser

        dcInsertNewAcc = New SqlCommand("InsertBoatScheduleTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}


        dcInsertNewAcc.Parameters.Add("@BDate", SqlDbType.Date).Value = dtDateArr.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ReservationType", SqlDbType.VarChar).Value = "Arrival"
        dcInsertNewAcc.Parameters.Add("@ResNo ", SqlDbType.VarChar).Value = getResno
        dcInsertNewAcc.Parameters.Add("@Guest", SqlDbType.VarChar).Value = getGuest
        dcInsertNewAcc.Parameters.Add("@NoOfPax", SqlDbType.Int).Value = getTotpax
        dcInsertNewAcc.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = CurrentUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()



    End Sub
    Private Sub InsertBoatScheduleOtherTemp()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim CurrentUser As String = CurrUser

        dcInsertNewAcc = New SqlCommand("InsertBoatScheduleTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}


        dcInsertNewAcc.Parameters.Add("@BDate", SqlDbType.Date).Value = dtDateArr.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ReservationType", SqlDbType.VarChar).Value = "Arrival-Other"
        dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = ""
        dcInsertNewAcc.Parameters.Add("@Guest", SqlDbType.VarChar).Value = txtOthers.Text.Trim
        dcInsertNewAcc.Parameters.Add("@NoOfPax", SqlDbType.Int).Value = "1"
        dcInsertNewAcc.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = CurrentUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub

    Private Sub gvArr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvArr.Click


    End Sub

    Private Sub btnAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssign.Click

        DelBoatScheduleTemp()

        PubAvaliable = Convert.ToInt16(txtAvailable.Text.Trim)

        PubNewAvilabe = PubAvaliable


        If txtAvailable.Text > 0 Then


            For i As Integer = 0 To gvArr.RowCount - 1


                'Dim s As String = gvArr.GetRowCellValue(i, "select")


                If (Not IsDBNull(gvArr.GetRowCellValue(i, "select"))) Then


                    'If gvArr.GetRowCellValue(i, "select") Then

                    Dim getResno As String = gvArr.GetRowCellValue(i, "ResNo")
                    Dim getGuest As String = gvArr.GetRowCellValue(i, "Guest")
                    Dim getTotPax As Integer = Convert.ToInt16(gvArr.GetRowCellValue(i, "AdultQty")) + Convert.ToInt16(gvArr.GetRowCellValue(i, "ChildrenQty")) + Convert.ToInt16(gvArr.GetRowCellValue(i, "InfantsQty"))
                    InsertBoatScheduleTemp(getResno, getGuest, getTotPax)

                    PubNewAvilabe = PubNewAvilabe - getTotPax
                    txtAvailable.Text = PubNewAvilabe

                    'LoadAssingedBoatSchedule()
                    LoadBoatScheduleTemp()
                End If

            Next

        Else
            MessageBox.Show("Seats Full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Sub
    'Private Sub GridView3_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView3.CustomUnboundColumnData
    '    If (e.Column.FieldName = "GridColumn24") Then
    '        If (unboundDataOutLetBill.Count > e.ListSourceRowIndex) Then
    '            If (e.IsGetData = True) Then
    '                e.Value = unboundDataOutLetBill(e.ListSourceRowIndex)
    '            Else
    '                unboundDataOutLetBill(e.ListSourceRowIndex) = e.Value
    '            End If
    '        End If

    '    End If
    'End Sub

    Private Sub LoadBoatScheduleTemp()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()

            Dim CurrentUser As String = CurrUser
            dcSearch = New SqlCommand("select * from dbo.[BoatSchedule.Temp] where  BoatNo=@BoatNo and CreatedBy=@user", Conn)
            dcSearch.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNo.Text.Trim
            dcSearch.Parameters.Add("@user", SqlDbType.VarChar).Value = CurrentUser

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcAssignBSchedule.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub InsertBoatSchedule(ByVal PubBoatScheduleMasterID As String, ByVal PubScheduleDetailID As String)

        Try

       
        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand


        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Dim BoatScheduleMasterID As String = PubBoatScheduleMasterID
        Dim ScheduleDetailID As String = PubScheduleDetailID

            Dim CurrentUser As String = CurrUser
        dcSearch = New SqlCommand("select * from dbo.[BoatSchedule.Temp] where  BoatNo=@BoatNo and CreatedBy=@user", Conn)
        dcSearch.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNo.Text.Trim
            dcSearch.Parameters.Add("@user", SqlDbType.VarChar).Value = CurrentUser

        Conn.Open()
        daMain = New SqlDataAdapter()
        daMain.SelectCommand = dcSearch
        daMain.Fill(dsMain)
        Conn.Close()

            Dim DScount As Integer = dsMain.Tables(0).Rows.Count



        dcInsertNewAcc = New SqlCommand("InsertBoatScheduleMaster_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

        'Dim ScheduleDetailIDautoid As String = System.Guid.NewGuid().ToString()

        dcInsertNewAcc.Parameters.Add("@TripDate", SqlDbType.Date).Value = dtDateArr.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TripTime", SqlDbType.DateTime).Value = TimeEdit1.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ScheduleDetailID", SqlDbType.VarChar).Value = BoatScheduleMasterID
        dcInsertNewAcc.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ReservationType", SqlDbType.VarChar).Value = "Arrival"
        dcInsertNewAcc.Parameters.Add("@TripStart", SqlDbType.VarChar).Value = cmbStartPoint.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TripEnd", SqlDbType.VarChar).Value = cmbEndPoint.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Destination1", SqlDbType.VarChar).Value = cmbDes1.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Destination2", SqlDbType.VarChar).Value = cmbDes2.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Destination3", SqlDbType.VarChar).Value = cmbDes3.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Destination4", SqlDbType.VarChar).Value = cmbDes4.Text.Trim
            dcInsertNewAcc.Parameters.Add("@TotalPax", SqlDbType.Int).Value = Convert.ToInt16(txtTotalSeats.Text.Trim) - Convert.ToInt16(txtAvailable.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
            dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = CurrentUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()



        Dim DScount1 As Integer = dsMain.Tables(0).Rows.Count - 1


        While DScount1 >= 0

            Dim autoid As String = System.Guid.NewGuid().ToString()

            dcInsertNewAcc = New SqlCommand("InsertBoatScheduleDetail_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            'Dim BoatScheduleMasterIDautoid As String = System.Guid.NewGuid().ToString()


            dcInsertNewAcc.Parameters.Add("@BoatScheduleMasterID", SqlDbType.VarChar).Value = BoatScheduleMasterID
            dcInsertNewAcc.Parameters.Add("@BDate", SqlDbType.Date).Value = dsMain.Tables(0).Rows(DScount1)(1).ToString()
            dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(3).ToString()
            dcInsertNewAcc.Parameters.Add("@Guest", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(4).ToString()
            dcInsertNewAcc.Parameters.Add("@NoOfPax", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount1)(5).ToString())
            dcInsertNewAcc.Parameters.Add("@ReservationType", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(2).ToString()
            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
                dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
            DScount1 = DScount1 - 1
        End While

            MessageBox.Show("Boat Schedule Saved Successfully", "Save Boat  Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        
        End Try
    End Sub
    Private Sub LoadBoatScheduleMasterDetail()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select BoatScheduleMID,TripDate,convert(char(5),TripTime, 108) [Time],BoatNo,TripStart,TripEnd,Destination1,Destination2,Destination3,Destination4 from dbo.[BoatSchedule.Master] where Status='OPEN' AND ReservationType='Arrival' order by BoatScheduleMID,BoatNo", Conn)
            'dcSearch.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNo.Text.Trim

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcBoatSched.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadBoatScheduleMasterDetailByday()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select BoatScheduleMID,TripDate,convert(char(5),TripTime, 108) [Time],BoatNo,TripStart,TripEnd,Destination1,Destination2,Destination3,Destination4 from dbo.[BoatSchedule.Master] where TripDate=@tripdate and Status='OPEN' AND ReservationType='Arrival' order by BoatScheduleMID,BoatNo", Conn)
            dcSearch.Parameters.Add("@tripdate", SqlDbType.DateTime).Value = dtSum.DateTime.Date

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)





            If (Not dsMain Is Nothing) Then
                gcBoatSched.DataSource = dsMain.Tables(0)

            End If

            If dsMain.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("No Arrival Boat Schedule", " Arrival Boat Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If





        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub


    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArrInactive.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatScheduling", "Delete")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This Boat Schedule Details", "Inactive Boat Schedule Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveBoatSchedule()


                End If
                LoadBoatScheduleMasterDetail()
                tabBoatSchedDetails.TabPages(1).PageEnabled = False
                tabBoatSchedDetails.TabPages(2).PageEnabled = False
                tabBoatSchedDetails.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub InactiveBoatSchedule()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveBoatSchedule_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@BoatScheduleMID", SqlDbType.Int).Value = gvBoatSched.GetRowCellValue(gvBoatSched.FocusedRowHandle, "BoatScheduleMID")

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Boat Schedule Details Inactivated Successfully", "Inactive Boat Schedule Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Private Sub InactiveBoatScheduleDep()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveBoatSchedule_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@BoatScheduleMID", SqlDbType.Int).Value = gvBoatSchedDep.GetRowCellValue(gvBoatSchedDep.FocusedRowHandle, "BoatScheduleMID")

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Boat Schedule Details Inactivated Successfully", "Inactive Boat Schedule Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub

    Private Sub btnViewDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDep.Click
        LoadReservationDepartureDetails()
    End Sub
    Private Sub LoadReservationDepartureDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            ' dcSearch = New SqlCommand("SELECT     dbo.[Reservation.Master].ResNo, convert(char(5), dbo.[Reservation.Master].DepTime, 108) [Time], dbo.[Reservation.Master].DepFlight, dbo.[Reservation.Master].Guest,dbo.[Reservation.Master].AdultQty, dbo.[Reservation.Master].ChildrenQty, dbo.[Reservation.Master].InfantsQty FROM dbo.[Reservation.Master] INNER JOIN dbo.GuestRegistration ON dbo.[Reservation.Master].ResNo = dbo.GuestRegistration.ReservationNo where dbo.GuestRegistration.IsBillingGuest=1  and dbo.GuestRegistration.DepDate=@DepDate order by dbo.[Reservation.Master].DepTime", Conn)

            dcSearch = New SqlCommand("SELECT distinct dbo.[Reservation.Master].ResNo, convert(char(5), dbo.[Reservation.Master].DepTime, 108) [Time], dbo.[Reservation.Master].DepFlight, dbo.[Reservation.Master].Guest,dbo.[Reservation.Master].AdultQty, dbo.[Reservation.Master].ChildrenQty, dbo.[Reservation.Master].InfantsQty FROM dbo.[Reservation.Master] INNER JOIN dbo.GuestRegistration ON dbo.[Reservation.Master].ResNo = dbo.GuestRegistration.ReservationNo where dbo.GuestRegistration.IsBillingGuest=1  and dbo.GuestRegistration.DepDate=@DepDate  and ResNo not in (SELECT dbo.[Reservation.Master].Resno FROM  dbo.[BoatSchedule.Master] INNER JOIN  dbo.[BoatSchedule.Detail] ON dbo.[BoatSchedule.Master].ScheduleDetailID = dbo.[BoatSchedule.Detail].BoatScheduleMasterID LEFT OUTER JOIN dbo.[Reservation.Master] ON dbo.[BoatSchedule.Detail].ResNo = dbo.[Reservation.Master].ResNo WHERE   dbo.[BoatSchedule.Master].TripDate = @DepDate  and dbo.[BoatSchedule.Master].Status='OPEN' and dbo.[BoatSchedule.Master].ReservationType='Departure') ", Conn)


            dcSearch.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDateDep.DateTime.Date

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            If (Not dsMain Is Nothing) Then
                gcDep.DataSource = dsMain.Tables(0)

            End If

            If dsMain.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("No Records", "Departures", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If




            gcDep.Refresh()


            Dim dtcol As New DataColumn("select", System.Type.GetType("System.Boolean"))
            dsMain.Tables(0).Columns.Add(dtcol)

            'Dim dtcol As New DataColumn
            'dtcol.ColumnName = "select"
            'dsMain.Tables(0).Columns.Add(dtcol)



            'gcDep.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadReservationSameDayDepartureDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            ' dcSearch = New SqlCommand("SELECT     dbo.[Reservation.Master].ResNo, convert(char(5), dbo.[Reservation.Master].DepTime, 108) [Time], dbo.[Reservation.Master].DepFlight, dbo.[Reservation.Master].Guest,dbo.[Reservation.Master].AdultQty, dbo.[Reservation.Master].ChildrenQty, dbo.[Reservation.Master].InfantsQty FROM dbo.[Reservation.Master] INNER JOIN dbo.GuestRegistration ON dbo.[Reservation.Master].ResNo = dbo.GuestRegistration.ReservationNo where dbo.GuestRegistration.IsBillingGuest=1  and dbo.GuestRegistration.DepDate=@DepDate order by dbo.[Reservation.Master].DepTime", Conn)

            dcSearch = New SqlCommand("SELECT dbo.[Reservation.Master].ResNo, convert(char(5), dbo.[Reservation.Master].DepTime, 108) [Time], dbo.[Reservation.Master].DepFlight, dbo.[Reservation.Master].Guest,dbo.[Reservation.Master].AdultQty, dbo.[Reservation.Master].ChildrenQty, dbo.[Reservation.Master].InfantsQty FROM dbo.[Reservation.Master]  where dbo.[Reservation.Master].Status='OPEN' and  dbo.[Reservation.Master].arrdate=@DepDate and dbo.[Reservation.Master].depdate=@DepDate", Conn)



            dcSearch.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDateDep.DateTime.Date

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            If (Not dsMain Is Nothing) Then
                gcDep.DataSource = dsMain.Tables(0)

            End If

            If dsMain.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("No Records", "Departures", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If




            gcDep.Refresh()


            Dim dtcol As New DataColumn("select", System.Type.GetType("System.Boolean"))
            dsMain.Tables(0).Columns.Add(dtcol)

            'Dim dtcol As New DataColumn
            'dtcol.ColumnName = "select"
            'dsMain.Tables(0).Columns.Add(dtcol)



            'gcDep.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub btnAssignDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignDep.Click

        DelBoatScheduleTemp()

        PubAvaliable = Convert.ToInt16(txtAvailableDep.Text.Trim)

        PubNewAvilabe = PubAvaliable

        If txtAvailableDep.Text > 0 Then

            For i As Integer = 0 To gvDep.RowCount - 1

                If (Not IsDBNull(gvDep.GetRowCellValue(i, "select"))) Then


                    Dim getResno As String = gvDep.GetRowCellValue(i, "ResNo")
                    Dim getGuest As String = gvDep.GetRowCellValue(i, "Guest")
                    Dim getTotPax As Integer = Convert.ToInt16(gvDep.GetRowCellValue(i, "AdultQty")) + Convert.ToInt16(gvDep.GetRowCellValue(i, "ChildrenQty")) + Convert.ToInt16(gvDep.GetRowCellValue(i, "InfantsQty"))
                    InsertBoatScheduleTempDeparture(getResno, getGuest, getTotPax)

                    PubNewAvilabe = PubNewAvilabe - getTotPax
                    txtAvailableDep.Text = PubNewAvilabe


                    LoadBoatScheduleTempDeparture()

                End If

            Next
        Else
            MessageBox.Show("Seats Full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Sub

    Private Sub btnAssOthersArr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssOthersArr.Click

        PubAvaliable = Convert.ToInt16(txtAvailable.Text.Trim)

        PubNewAvilabe = PubAvaliable

        If (Convert.ToInt16(txtAvailable.Text.Trim) > 0) Then

            'Dim getTotPax1 As Integer = Convert.ToInt16(gvArr.GetRowCellValue(0, "Other")) + Convert.ToInt16(gvArr.GetRowCellValue(0, "AdultQty")) + Convert.ToInt16(gvArr.GetRowCellValue(0, "ChildrenQty")) + Convert.ToInt16(gvArr.GetRowCellValue(0, "InfantsQty"))

            InsertBoatScheduleOtherTemp()

            PubNewAvilabe = PubNewAvilabe - 1
            txtAvailable.Text = PubNewAvilabe

            LoadBoatScheduleTemp()

        Else
            MessageBox.Show("Seats Full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If

        txtOthers.Text = ""


    End Sub

    Private Sub btnAssOthersDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssOthersDep.Click

        PubAvaliable = Convert.ToInt16(txtAvailableDep.Text.Trim)

        PubNewAvilabe = PubAvaliable

        If (Convert.ToInt16(txtAvailableDep.Text.Trim) > 0) Then

            'Dim getTotPax1 As Integer = Convert.ToInt16(gvDep.GetRowCellValue(0, "Other")) + Convert.ToInt16(gvDep.GetRowCellValue(0, "AdultQty")) + Convert.ToInt16(gvDep.GetRowCellValue(0, "ChildrenQty")) + Convert.ToInt16(gvDep.GetRowCellValue(0, "InfantsQty"))

            InsertBoatScheduleOtherTempDeparture()

            PubNewAvilabe = PubNewAvilabe - 1
            txtAvailableDep.Text = PubNewAvilabe

            LoadBoatScheduleTempDeparture()

        Else
            MessageBox.Show("Seats Full", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If

        txtothersDepartre.Text = ""



    End Sub

    Private Sub LoadBoatNoDeparture()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select BoatNo from [Boat.Master] where Status='OPEN' order by BoatNo", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbBoatNoDeparture.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            'cmbBoatNoDeparture.SelectedIndex = 1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadTotalSeatsDeparture(ByVal boatno As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Passboatno As String = boatno

            dcSearch = New SqlCommand("select MaxPassengers from [Boat.Master] where  BoatNo=@Passboatno", Conn)
            dcSearch.Parameters.Add("@PASSBOATNO", SqlDbType.VarChar).Value = Passboatno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            txtTotSeatsDep.Text = dsMain.Tables(0).Rows(0)(0).ToString()
            txtAvailableDep.Text = dsMain.Tables(0).Rows(0)(0).ToString()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub cmbBoatNoDeparture_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBoatNoDeparture.SelectedIndexChanged

        LoadTotalSeatsDeparture(cmbBoatNoDeparture.Text.Trim)

    End Sub

    Private Sub LoadBoatScheduleTempDeparture()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()

            Dim CurrentUser As String = CurrUser

            dcSearch = New SqlCommand("select * from dbo.[BoatSchedule.Temp] where  BoatNo=@BoatNo and CreatedBy=@user", Conn)
            dcSearch.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNoDeparture.Text.Trim
            dcSearch.Parameters.Add("@user", SqlDbType.VarChar).Value = CurrentUser

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcAssignBScheduleDep.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub InsertBoatScheduleTempDeparture(ByVal Resno As String, ByVal Guest As String, ByVal PaxCount As Integer)

        Try

        

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim getResno As String = Resno
        Dim getGuest As String = Guest
        Dim getTotpax As Integer = PaxCount

        dcInsertNewAcc = New SqlCommand("InsertBoatScheduleTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            Dim CurrentUser As String = CurrUser

        dcInsertNewAcc.Parameters.Add("@BDate", SqlDbType.Date).Value = dtDateDep.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ReservationType", SqlDbType.VarChar).Value = "Departure"
        dcInsertNewAcc.Parameters.Add("@ResNo ", SqlDbType.VarChar).Value = getResno
        dcInsertNewAcc.Parameters.Add("@Guest", SqlDbType.VarChar).Value = getGuest
        dcInsertNewAcc.Parameters.Add("@NoOfPax", SqlDbType.Int).Value = getTotpax
        dcInsertNewAcc.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNoDeparture.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
            dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = CurrentUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        
        End Try



    End Sub
    Private Sub InsertBoatScheduleOtherTempDeparture()

        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand


            Dim CurrentUser As String = CurrUser
            dcInsertNewAcc = New SqlCommand("InsertBoatScheduleTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}


            dcInsertNewAcc.Parameters.Add("@BDate", SqlDbType.Date).Value = dtDateDep.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ReservationType", SqlDbType.VarChar).Value = "Departure-Other"
            dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = ""
            dcInsertNewAcc.Parameters.Add("@Guest", SqlDbType.VarChar).Value = txtothersDepartre.Text.Trim
            dcInsertNewAcc.Parameters.Add("@NoOfPax", SqlDbType.Int).Value = "1"
            dcInsertNewAcc.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNoDeparture.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
            dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        End Try

    End Sub

    Private Sub InsertBoatScheduleDeparture(ByVal PubBoatScheduleMasterID As String, ByVal PubScheduleDetailID As String)

        Try
            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim CurrentUser As String = CurrUser

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand
            Dim BoatScheduleMasterID As String = PubBoatScheduleMasterID
            Dim ScheduleDetailID As String = PubScheduleDetailID


            dcSearch = New SqlCommand("select * from dbo.[BoatSchedule.Temp] where  BoatNo=@BoatNo and CreatedBy=@user", Conn)
            dcSearch.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNoDeparture.Text.Trim
            dcSearch.Parameters.Add("@user", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            Conn.Close()

            Dim DScount As Integer = dsMain.Tables(0).Rows.Count

            dcInsertNewAcc = New SqlCommand("InsertBoatScheduleMaster_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            'Dim ScheduleDetailIDautoid As String = System.Guid.NewGuid().ToString()

            dcInsertNewAcc.Parameters.Add("@TripDate", SqlDbType.Date).Value = dtDateDep.Text.Trim
            dcInsertNewAcc.Parameters.Add("@TripTime", SqlDbType.DateTime).Value = TimeEditDep.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ScheduleDetailID", SqlDbType.VarChar).Value = BoatScheduleMasterID
            dcInsertNewAcc.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNoDeparture.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ReservationType", SqlDbType.VarChar).Value = "Departure"
            dcInsertNewAcc.Parameters.Add("@TripStart", SqlDbType.VarChar).Value = cmbStartPointDep.Text.Trim
            dcInsertNewAcc.Parameters.Add("@TripEnd", SqlDbType.VarChar).Value = cmbEndPointDep.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Destination1", SqlDbType.VarChar).Value = cmbDes1Dep.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Destination2", SqlDbType.VarChar).Value = cmbDes2Dep.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Destination3", SqlDbType.VarChar).Value = cmbDes3Dep.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Destination4", SqlDbType.VarChar).Value = cmbDes4Dep.Text.Trim
            dcInsertNewAcc.Parameters.Add("@TotalPax", SqlDbType.Int).Value = Convert.ToInt16(txtTotSeatsDep.Text.Trim) - Convert.ToInt16(txtAvailableDep.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
            dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()



            Dim DScount1 As Integer = dsMain.Tables(0).Rows.Count - 1


            While DScount1 >= 0

                Dim autoid As String = System.Guid.NewGuid().ToString()

                dcInsertNewAcc = New SqlCommand("InsertBoatScheduleDetail_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                'Dim BoatScheduleMasterIDautoid As String = System.Guid.NewGuid().ToString()


                dcInsertNewAcc.Parameters.Add("@BoatScheduleMasterID", SqlDbType.VarChar).Value = BoatScheduleMasterID
                dcInsertNewAcc.Parameters.Add("@BDate", SqlDbType.Date).Value = dsMain.Tables(0).Rows(DScount1)(1).ToString()
                dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(3).ToString()
                dcInsertNewAcc.Parameters.Add("@Guest", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(4).ToString()
                dcInsertNewAcc.Parameters.Add("@NoOfPax", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount1)(5).ToString())
                dcInsertNewAcc.Parameters.Add("@ReservationType", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount1)(2).ToString()
                dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
                dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser


                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()
                DScount1 = DScount1 - 1
            End While

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        End Try
    End Sub
    Private Sub LoadBoatScheduleMasterDetailDeparture()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select BoatScheduleMID,TripDate,convert(char(5),TripTime, 108) [Time],BoatNo,TripStart,TripEnd,Destination1,Destination2,Destination3,Destination4 from dbo.[BoatSchedule.Master] where Status='OPEN' and ReservationType='Departure' order by BoatScheduleMID,BoatNo", Conn)
            'dcSearch.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = cmbBoatNoDeparture.Text.Trim

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcBoatSchedDep.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadBoatScheduleMasterDetailDepartureByday()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select BoatScheduleMID,TripDate,convert(char(5),TripTime, 108) [Time],BoatNo,TripStart,TripEnd,Destination1,Destination2,Destination3,Destination4 from dbo.[BoatSchedule.Master] where TripDate=@tripdate and  Status='OPEN' and ReservationType='Departure' order by BoatScheduleMID,BoatNo", Conn)
            dcSearch.Parameters.Add("@tripdate", SqlDbType.DateTime).Value = dtSum.DateTime.Date

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If (Not dsMain Is Nothing) Then
                gcBoatSchedDep.DataSource = dsMain.Tables(0)

            End If

            If dsMain.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("No Departure Boat Schedules", "Departure Boat Schedules", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If





        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub btnAddDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDep.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatScheduling", "Add")

        If CheckAccess = True Then





            If String.Compare(btnAddDep.Text, "Add Departure", False) = 0 Then

                ClearFieldsDeparture()
                btnAddDep.Text = "Save"
                btnAddArr.Enabled = False
                btnDepInactive.Enabled = False
                btnDepInactive.Enabled = False
                tabBoatSchedDetails.TabPages(2).PageEnabled = True
                tabBoatSchedDetails.SelectedTabPageIndex = 2



            Else

                'Dim dscheckAddbefore As New DataSet
                'dscheckAddbefore = DSCheckInsertBoatTemp()


                'If dscheckAddbefore Is Nothing Then

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Boat Schedule Details", "Save  Boat  Schedule", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    PubBoatScheduleMasterID = System.Guid.NewGuid().ToString()
                    PubScheduleDetailID = System.Guid.NewGuid().ToString()

                    InsertBoatScheduleDeparture(PubBoatScheduleMasterID, PubScheduleDetailID)

                    DelBoatScheduleTemp()



                End If


                '    Else
                '    MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                'End If


                LoadBoatScheduleMasterDetailDeparture()

                btnAddDep.Text = "Add Departure"
                btnAddArr.Enabled = True
                btnDepInactive.Enabled = True
                btnDepInactive.Enabled = True
                tabBoatSchedDetails.TabPages(1).PageEnabled = False
                tabBoatSchedDetails.TabPages(2).PageEnabled = False
                tabBoatSchedDetails.SelectedTabPageIndex = 0
                Exit Sub
            End If

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub gvArr_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gvArr.CustomUnboundColumnData
        'If (e.Column.FieldName = "select") Then
        '    If (unboundDataOutLetBill.Count > e.ListSourceRowIndex) Then
        '        If (e.IsGetData = True) Then
        '            e.Value = unboundDataOutLetBill(e.ListSourceRowIndex)
        '        Else
        '            unboundDataOutLetBill(e.ListSourceRowIndex) = e.Value
        '        End If
        '    End If

        'End If
    End Sub

    Private Sub PrintBoatScheduleArrival()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from rpt_view_Boatschedule_Arrival", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaProinv As Integer = gvBoatSched.GetRowCellValue(gvBoatSched.FocusedRowHandle, "BoatScheduleMID")
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            'fltString = "{ rpt_view_Boatschedule_Arrival.BoatScheduleMID}='" & ParaProinv & "'"

            fltString = "{ rpt_view_Boatschedule_Arrival.BoatScheduleMID}=" & ParaProinv & ""

            ReportName = "BoatSheduleArrivals.rpt"
            rptTitle = "Boat Schedule- Arrivals"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            'frmReportViewer.paraRepName = "TestPara"
            'frmReportViewer.paraRepVale = DtToday.Text.ToString

            'frmReportViewer.paraRepName2 = "TestPara2"
            'frmReportViewer.paraRepVale2 = DtToday.Text.ToString


            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub
    Private Sub PrintBoatScheduleDeparture()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from rpt_view_Boatschedule_Arrival", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaProinv As Integer = gvBoatSchedDep.GetRowCellValue(gvBoatSchedDep.FocusedRowHandle, "BoatScheduleMID")
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            'fltString = "{ rpt_view_Boatschedule_Arrival.BoatScheduleMID}='" & ParaProinv & "'"

            fltString = "{ rpt_view_Boatschedule_Arrival.BoatScheduleMID}=" & ParaProinv & ""

            ReportName = "BoatSheduleArrivals.rpt"
            rptTitle = "Boat Schedule- Deapature"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            'frmReportViewer.paraRepName = "TestPara"
            'frmReportViewer.paraRepVale = DtToday.Text.ToString

            'frmReportViewer.paraRepName2 = "TestPara2"
            'frmReportViewer.paraRepVale2 = DtToday.Text.ToString


            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

  
    Private Sub btViewArrivals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewArrivals.Click
        PrintBoatScheduleArrival()
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btViewDepa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewDepa.Click
        PrintBoatScheduleDeparture()
    End Sub

    Private Sub btnDepInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepInactive.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatScheduling", "Delete")

        If CheckAccess = True Then





            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This Boat Schedule Details", "Inactive Boat Schedule Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveBoatScheduleDep()


                End If
                LoadBoatScheduleMasterDetailDeparture()
                tabBoatSchedDetails.TabPages(1).PageEnabled = False
                tabBoatSchedDetails.TabPages(2).PageEnabled = False
                tabBoatSchedDetails.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub frmBoatSchedule_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub btViewSchdules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewSchdules.Click
        LoadBoatScheduleMasterDetailByday()
        LoadBoatScheduleMasterDetailDepartureByday()


    End Sub

    Private Sub btViewall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewall.Click
        LoadBoatScheduleMasterDetail()
        LoadBoatScheduleMasterDetailDeparture()
    End Sub
    Private Sub InsertTemp()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("tempRptBoatInformation_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtSum.DateTime.Date
        ' dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub InsertTempstaff()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("BoatInformationstaff_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtSum.DateTime.Date
        ' dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub


    Private Sub printreportstaff()
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

            dcIns = New SqlCommand("LoadBoatInformationstaff_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

            dcIns.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            ReportName = "rptBoatInformationstaff.rpt"
            rptTitle = "Staff BoatInformation_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = "paraArrdate"
            frmReportViewer.paraRepVale = dtSum.Text.ToString

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

            dcIns = New SqlCommand("LoadTempRptBoatInformation_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

            dcIns.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            ReportName = "NewBoatInformation_Report.rpt"
            rptTitle = "Guest BoatInformation_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = "paraArrdate"
            frmReportViewer.paraRepVale = dtSum.Text.ToString

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


    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatScheduling", "Print")

        If CheckAccess = True Then



            InsertTemp()
            ' UpdateStatusMasterArrival()
            ' UpdateStatusMasterDeparture()
            printreport()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub txtothersDepartre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtothersDepartre.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtOthers_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOthers.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub Updatetatus(ByVal PassStatus As String, ByVal PasstripTime As String)

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getPassStatus As String = PassStatus
            Dim getPasstripTime As String = PasstripTime


            dcInsertNewAcc = New SqlCommand("UpdateBoatScheduleStatus_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Triptime", SqlDbType.VarChar).Value = getPasstripTime
            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = PassStatus



            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub UpdatetatusDep(ByVal PassStatus As String, ByVal PasstripTime As DateTime)

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getPassStatus As String = PassStatus
            Dim getPasstripTime As DateTime = PasstripTime


            dcInsertNewAcc = New SqlCommand("UpdateBoatScheduleStatusDep_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Triptime", SqlDbType.DateTime).Value = getPasstripTime
            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = PassStatus



            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub

    Private Sub UpdateStatusMasterArrival()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()
            dcSearch = New SqlCommand("select distinct convert(char(5),TripTime, 108) [TripTime] from dbo.[TempRptBoatInformation] where Status='Arrival'", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0

                    Dim TripTime As DateTime = dsMain.Tables(0).Rows(DScount)(0)



                    Dim passShift As String = ""


                    'If FlightTime.Hour >= 17 And FlightTime.Hour <= 5 Then
                    If TripTime.Hour >= 17 Then

                        passShift = "6.Night Arrival"

                    ElseIf TripTime.Hour >= 5 And TripTime.Hour <= 12 Then

                        passShift = "4.Morning Arrival"

                    ElseIf TripTime.Hour >= 12 And TripTime.Hour <= 17 Then

                        passShift = "5.Afternoon/Evening Arrival"

                    End If







                    Dim TripTimeS As String = TripTime.ToString


                    Updatetatus(passShift, TripTimeS)


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

    Private Sub UpdateStatusMasterDeparture()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()
            dcSearch = New SqlCommand("select distinct convert(char(5),TripTime, 108) [TripTime] from dbo.[TempRptBoatInformation] where Status='Departure'", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0

                    Dim TripTime As DateTime = dsMain.Tables(0).Rows(DScount)(0)



                    Dim passShift As String = ""



                    If TripTime.Hour >= 17 Then



                        passShift = "3.Night Departure"

                    ElseIf TripTime.Hour >= 5 And TripTime.Hour <= 12 Then

                        passShift = "1.Morning Departure"

                    ElseIf TripTime.Hour >= 12 And TripTime.Hour <= 17 Then

                        passShift = "2.Afternoon/Evening Departure"

                    End If










                    UpdatetatusDep(passShift, TripTime)


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


    Private Sub btprintstf_Click(sender As Object, e As EventArgs) Handles btprintstf.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatScheduling", "Print")

        If CheckAccess = True Then



            InsertTempstaff()
            ' UpdateStatusMasterArrival()
            ' UpdateStatusMasterDeparture()
            printreportstaff()


        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        LoadReservationSameDayDepartureDetails()
    End Sub
End Class