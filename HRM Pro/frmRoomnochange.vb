Imports System.Data.SqlClient
Imports System.Xml
Public Class frmRoomnochange
    Dim PubResType As String = ""
    Dim PubTopcode As String = ""
    Dim PubMP As String = ""
    Dim PubResno As String = ""
    Dim PubtheDays As Integer = 0
    Dim PubResdate As DateTime = DateTime.Now.ToShortDateString()
    Dim PubGrandTotal As Decimal = 0
    Private Sub frmRoomnochange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGrid()
        LoadRooms()

        cmbChangeType.SelectedIndex = 0

    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[Room.CurrentStatus] order by RoomNo", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcRoomMaster.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub ShowGridDets()
        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Room.CurrentStatus]  where RoomNo= '{0}' ", gvRoomMaster.GetRowCellValue(gvRoomMaster.FocusedRowHandle, "RoomNo")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabRooms.SelectedTabPageIndex = 1

            txtRoomno.Text = dsShow.Tables(0).Rows(0).Item("Roomno")


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub LoadRooms()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Roomno from dbo.[Rooms.Master] where IsInactive=0 and Status='vacant' order by Roomno,Category,Status", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            Dim newCustomersRow As DataRow = dsMain.Tables(0).NewRow()

            While (DscountTest < Dscount)

                cmbRoom.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbRoom.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub gvRoomMaster_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvRoomMaster.DoubleClick
        ShowGridDets()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room number Change", "Add")

        If CheckAccess = True Then



            If String.Compare(btnAdd.Text, "Change Room", False) = 0 Then


                btnAdd.Text = "Save"

                tabRooms.SelectedTabPageIndex = 1

            Else

                UpdatechangeRoom()
                'ChangeRoomPayment()



                LoadGrid()

                btnAdd.Text = "Change Room"

                tabRooms.SelectedTabPageIndex = 0
                Exit Sub
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Private Sub UpdatechangeRoom()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        Dim CurrentUser As String = CurrUser

        dcInsertNewAcc = New SqlCommand("UpdateRoomNoChange_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@NewRoomNo", SqlDbType.VarChar).Value = cmbRoom.Text.Trim
        dcInsertNewAcc.Parameters.Add("@OldRoomNo", SqlDbType.VarChar).Value = txtRoomno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ChangeType", SqlDbType.VarChar).Value = cmbChangeType.Text.Trim
        dcInsertNewAcc.Parameters.Add("@UserId", SqlDbType.VarChar).Value = CurrentUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Room Changed Successfully", "Save Room", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()
    End Sub
    Private Sub ChangeRoomPayment()

        Dim CurrRoomType As String = ""
        Dim NewRoomType As String = ""
        Dim CurrRoomTypePo As Integer = 0
        Dim NewRoomTypePo As Integer = 0



        '-------------get the current room type

        Dim dsGetRoomtype As New DataSet
        dsGetRoomtype = DSRoomType(txtRoomno.Text.Trim)

        If dsGetRoomtype Is Nothing Then
            Exit Sub

        Else

            CurrRoomType = dsGetRoomtype.Tables(0).Rows(0)(0).ToString

            If CurrRoomType = "Superior" Then
                CurrRoomTypePo = 3
            End If

            If CurrRoomType = "Deluxe" Then
                CurrRoomTypePo = 2
            End If

            If CurrRoomType = "Standard" Then
                CurrRoomTypePo = 1
            End If


        End If



        '----------------------get the changed room type

        Dim dsGetChangedRoomtype As New DataSet
        dsGetChangedRoomtype = DSRoomType(cmbRoom.Text.Trim)

        If dsGetChangedRoomtype Is Nothing Then
            Exit Sub

        Else

            NewRoomType = dsGetChangedRoomtype.Tables(0).Rows(0)(0).ToString



            If NewRoomType = "Superior" Then
                NewRoomTypePo = 3
            End If

            If NewRoomType = "Deluxe" Then
                NewRoomTypePo = 2
            End If

            If NewRoomType = "Standard" Then
                NewRoomTypePo = 1
            End If


        End If

        '-------------------if room type is high get the rate from change date to dep date 

        If NewRoomTypePo > CurrRoomTypePo Then

            Dim Depdate As DateTime
            Dim DepTime As DateTime
            Dim dsDepDate As New DataSet
            dsDepDate = DSGetDepDate(cmbRoom.Text.Trim)

            If dsDepDate Is Nothing Then
                Exit Sub

            Else
                Depdate = Convert.ToDateTime(dsDepDate.Tables(0).Rows(0)(2))
                DepTime = Convert.ToDateTime(dsDepDate.Tables(0).Rows(0)(6))

                PubResType = dsDepDate.Tables(0).Rows(0)(3).ToString
                PubTopcode = dsDepDate.Tables(0).Rows(0)(4).ToString
                PubMP = dsDepDate.Tables(0).Rows(0)(5).ToString
                PubResno = dsDepDate.Tables(0).Rows(0)(1).ToString


                Dim inDtArr As DateTime = DateTime.Now.ToShortDateString()
                Dim inTimeArr As DateTime = "12:00"
                Dim OriArrTime As DateTime = inDtArr.AddTicks(inTimeArr.Ticks)

                Dim inDtDep As DateTime = Depdate
                Dim inTimeDep As DateTime = DepTime
                Dim OriDepTime As DateTime = inDtDep.AddTicks(inTimeDep.Ticks)

                Dim theDays As Integer = OriDepTime.Subtract(OriArrTime).TotalDays

                PubtheDays = theDays

                LoadRoomRatesTopContracts()

                InsertBillingKOTBOT()


            End If

        End If


            '------------------ send details to the outlet bill 

    End Sub
    Private Sub LoadRoomRatesTopContracts()


        Try

            '-----------------------For Top------------------------------------------------------------------------------------
            If PubResType = "TOP" Then

                Dim DSPax As New DataSet
                DSPax = DSLoadResPaxDetails()
                Dim Gettotbednights As Integer = PubtheDays - 1
                Dim GetResDate As DateTime = PubResdate
                Dim GetResDateInc As Integer = 0

                Dim FinalGetRate As Decimal


                If DSPax.Tables(0).Rows.Count > 0 Then

                    Dim GetRate As Decimal = 0.0

                    Dim DScount As Integer = DSPax.Tables(0).Rows.Count - 1

                    While DScount >= 0

                        While Gettotbednights >= 0

                            Dim DSRoomRates As New DataSet
                            ' DSRoomRates = DSGetRoomRateTopContracts(PubTopcode, PubMP, DSPax.Tables(0).Rows(DScount)(0).ToString, DSPax.Tables(0).Rows(DScount)(1).ToString, PubResdate)
                            DSRoomRates = DSGetRoomRateTopContracts(PubTopcode, PubMP, DSPax.Tables(0).Rows(DScount)(0).ToString, DSPax.Tables(0).Rows(DScount)(1).ToString, DateAdd(DateInterval.Day, +GetResDateInc, GetResDate))

                            If DSRoomRates.Tables(0).Rows.Count > 0 Then

                                Dim GetRoomRate As Decimal = Convert.ToDecimal(DSRoomRates.Tables(0).Rows(0)(0))
                                Dim GetRoomQty As Integer = Convert.ToInt16(DSPax.Tables(0).Rows(DScount)(2))
                                Dim GetBednights As Integer = Convert.ToInt16(DSPax.Tables(0).Rows(DScount)(3))
                                Dim GetTotPax As Integer = Convert.ToInt16(DSPax.Tables(0).Rows(DScount)(4))

                                'Dim CalRoomRate = GetRoomRate * GetRoomQty * GetTotPax
                                Dim CalRoomRate = GetRoomRate * GetTotPax


                                GetRate = GetRate + CalRoomRate

                            Else
                                MessageBox.Show("Room Rates Are Not Defined For This Room Type In The Activ Contract", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                Exit While
                            End If

                            Gettotbednights = Gettotbednights - 1
                            GetResDateInc = GetResDateInc + 1

                        End While
                        DScount = DScount - 1
                    End While
                    'txtRate.Text = GetRate.ToString

                    FinalGetRate = GetRate

                    PubGrandTotal = FinalGetRate
                End If


                '-------------------------------------------------------------------------

            End If

            '-----------------------For FIT------------------------------------------------------------------------------------


            If PubResType = "FIT" Then



                Dim DSFITRoomDetails As New DataSet
                DSFITRoomDetails = DSGetRoomDetailsFIT()
                Dim DScount As Integer = DSFITRoomDetails.Tables(0).Rows.Count - 1

                Dim conRoom As String
                Dim conRoomType As String
                Dim conRoomCount As Integer
                Dim RatePerContract As Decimal
                Dim TotRatePerContract As Decimal
                Dim conBednights As Integer
                Dim conTotPax As Integer


                Dim GrandTotRatePerContract As Decimal

                Dim Gettotbednights As Integer = PubtheDays - 1
                Dim TotRatePerContract2 As Decimal

                Dim GetResDateInc As Integer = 0
                Dim GetResDate As DateTime = PubResdate

                Dim GetMealPlan As String = PubMP


                While DScount >= 0

                    While Gettotbednights >= 0

                        conRoom = DSFITRoomDetails.Tables(0).Rows(DScount)(1).ToString
                        conRoomType = DSFITRoomDetails.Tables(0).Rows(DScount)(2).ToString
                        conRoomCount = Convert.ToInt16(DSFITRoomDetails.Tables(0).Rows(DScount)(3).ToString)
                        conBednights = Convert.ToInt16(DSFITRoomDetails.Tables(0).Rows(DScount)(4).ToString)
                        conTotPax = Convert.ToInt16(DSFITRoomDetails.Tables(0).Rows(DScount)(5).ToString)

                        Dim dsGetContractRateFit As New DataSet
                        ' dsGetContractRateFit = DSLoadRoomRatesFits(DtResdate.DateTime.Date, conRoom, cmbMealplan.Text.Trim, conRoomType)
                        dsGetContractRateFit = DSLoadRoomRatesFits(DateAdd(DateInterval.Day, +GetResDateInc, GetResDate), conRoom, GetMealPlan, conRoomType, "FIT")

                        If dsGetContractRateFit Is Nothing Then

                            MessageBox.Show("Rates are not defined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit While

                        Else

                            'TotRatePerContract2 = TotRatePerContract2 + (RatePerContract * conRoomCount * conTotPax)
                            'GrandTotRatePerContract = GrandTotRatePerContract + TotRatePerContract2

                            RatePerContract = Convert.ToDecimal(dsGetContractRateFit.Tables(0).Rows(0)(10).ToString)

                            'TotRatePerContract = TotRatePerContract + (RatePerContract * conRoomCount * conTotPax)

                            TotRatePerContract = TotRatePerContract + (RatePerContract * conTotPax)


                            ' GrandTotRatePerContract = GrandTotRatePerContract + TotRatePerContract

                        End If

                        Gettotbednights = Gettotbednights - 1
                        GetResDateInc = GetResDateInc + 1

                    End While

                    DScount = DScount - 1

                End While


                '------------------------------------------------------------------------------

             


                '-------------------------------------------------------------------------------
                'txtRate.Text = TotRatePerContract + GrantTotalAI
                'txtTotal.Text = GrandTotRatePerContract

                PubGrandTotal = GrandTotRatePerContract

            End If


            '-----------------------For com------------------------------------------------------------------------------------


            If PubResType = "COM" Then



                Dim DSFITRoomDetails As New DataSet
                DSFITRoomDetails = DSGetRoomDetailsFIT()
                Dim DScount As Integer = DSFITRoomDetails.Tables(0).Rows.Count - 1

                Dim conRoom As String
                Dim conRoomType As String
                Dim conRoomCount As Integer
                Dim RatePerContract As Decimal
                Dim TotRatePerContract As Decimal
                Dim conBednights As Integer
                Dim conTotPax As Integer


                Dim GrandTotRatePerContract As Decimal

                Dim Gettotbednights As Integer = PubtheDays - 1
                Dim TotRatePerContract2 As Decimal

                Dim GetResDateInc As Integer = 0
                Dim GetResDate As DateTime = PubResdate

                Dim GetMealPlan As String = PubMP


                While DScount >= 0

                    While Gettotbednights >= 0

                        conRoom = DSFITRoomDetails.Tables(0).Rows(DScount)(1).ToString
                        conRoomType = DSFITRoomDetails.Tables(0).Rows(DScount)(2).ToString
                        conRoomCount = Convert.ToInt16(DSFITRoomDetails.Tables(0).Rows(DScount)(3).ToString)
                        conBednights = Convert.ToInt16(DSFITRoomDetails.Tables(0).Rows(DScount)(4).ToString)
                        conTotPax = Convert.ToInt16(DSFITRoomDetails.Tables(0).Rows(DScount)(5).ToString)

                        Dim dsGetContractRateFit As New DataSet
                        ' dsGetContractRateFit = DSLoadRoomRatesFits(DtResdate.DateTime.Date, conRoom, cmbMealplan.Text.Trim, conRoomType)
                        dsGetContractRateFit = DSLoadRoomRatesFits(DateAdd(DateInterval.Day, +GetResDateInc, GetResDate), conRoom, GetMealPlan, conRoomType, "COM")

                        If dsGetContractRateFit Is Nothing Then

                            MessageBox.Show("Rates are not defined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit While

                        Else

                            'TotRatePerContract2 = TotRatePerContract2 + (RatePerContract * conRoomCount * conTotPax)
                            'GrandTotRatePerContract = GrandTotRatePerContract + TotRatePerContract2

                            RatePerContract = Convert.ToDecimal(dsGetContractRateFit.Tables(0).Rows(0)(10).ToString)

                            '  TotRatePerContract = TotRatePerContract + (RatePerContract * conRoomCount * conTotPax)


                            TotRatePerContract = TotRatePerContract + (RatePerContract * conTotPax)


                            ' GrandTotRatePerContract = GrandTotRatePerContract + TotRatePerContract

                        End If

                        Gettotbednights = Gettotbednights - 1
                        GetResDateInc = GetResDateInc + 1

                    End While

                    DScount = DScount - 1

                End While

                'txtRate.Text = TotRatePerContract
                'txtTotal.Text = GrandTotRatePerContract

                PubGrandTotal = GrandTotRatePerContract

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Function DSLoadAllInclusiveFITS(ByVal ValRestype As String, ByVal ValCategory As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Restype As String = ValRestype
            Dim Category As String = ValCategory


            dcSearch = New SqlCommand("SelectContractDetailResAI_FIT", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcSearch.Parameters.Add("@ResType", SqlDbType.VarChar).Value = Restype
            dcSearch.Parameters.Add("@Category", SqlDbType.VarChar).Value = Category


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSLoadAllInclusiveFITS = dsMain
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
    Function DSLoadRoomRatesFits(ByVal ValResDate As DateTime, ByVal ValRoom As String, ByVal ValPackage As String, ByVal ValRoomType As String, ByVal ResType As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim getCusType As String = ResType
            'If CbFit.Checked = True Then
            '    getCusType = "FIT"
            'End If
            'If CbCompl.Checked = True Then
            '    getCusType = "COM"
            'End If


            Dim getPackage As String = ""


            Dim ResDate As DateTime = ValResDate
            Dim Room As String = ValRoom
            Dim Package As String = ValPackage
            Dim RoomType As String = ValRoomType

            If Package = "AI" Then
                getPackage = "FB"
            Else
                getPackage = Package
            End If


            dcSearch = New SqlCommand("SelectContractDetailResFit_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcSearch.Parameters.Add("@CusType", SqlDbType.VarChar).Value = getCusType
            dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = ResDate
            dcSearch.Parameters.Add("@RoomType", SqlDbType.VarChar).Value = Room
            dcSearch.Parameters.Add("@Packagetype", SqlDbType.VarChar).Value = getPackage
            dcSearch.Parameters.Add("@Countype", SqlDbType.VarChar).Value = RoomType

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSLoadRoomRatesFits = dsMain
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
    Function DSGetRoomDetailsFIT() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            Dim ReservationNo As String = PubResno


            dcSearch = New SqlCommand("SELECT dbo.[Reservation.Master].ResNo, dbo.[Reservation.Room].Room, dbo.[Reservation.Room].Roomtype, dbo.[Reservation.Room].RoomCount,dbo.[Reservation.Room].BedNights, dbo.[Reservation.Room].TotPax FROM dbo.[Reservation.Master] INNER JOIN dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo where dbo.[Reservation.Master].ResNo=@ReservationNo", Conn)
            dcSearch.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = ReservationNo


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSGetRoomDetailsFIT = dsMain
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
    Function DSLoadResPaxDetails() As DataSet
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getResno As String = PubResno

            Conn.Open()
            dcSearch = New SqlCommand("SELECT  dbo.[Reservation.Room].Room, dbo.[Reservation.Room].Roomtype, dbo.[Reservation.Room].RoomCount,dbo.[Reservation.Room].BedNights ,dbo.[Reservation.Room].TotPax FROM  dbo.[Reservation.Master] INNER JOIN  dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo where dbo.[Reservation.Master].ResNo=@ResNo", Conn)
            dcSearch.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = getResno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then

                DSLoadResPaxDetails = dsMain
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Function
    Function DSGetRoomRateTopContracts(ByVal TopId As String, ByVal PackageType As String, ByVal Room As String, ByVal RoomType As String, ByVal ResDate As DateTime) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim getPackage As String = ""

            Dim getTopId As String = TopId
            Dim getPackageType As String = PackageType
            Dim getRoom As String = Room
            Dim getRoomType As String = RoomType
            Dim getResDate As DateTime = ResDate

            If getPackageType = "AI" Then
                getPackage = "FB"
            Else
                getPackage = getPackageType
            End If



            dcSearch = New SqlCommand("GetRoomRateContracts_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcSearch.Parameters.Add("@TopId", SqlDbType.VarChar).Value = getTopId
            dcSearch.Parameters.Add("@PackageType", SqlDbType.VarChar).Value = getPackage
            dcSearch.Parameters.Add("@Room", SqlDbType.VarChar).Value = getRoom
            dcSearch.Parameters.Add("@RoomType", SqlDbType.VarChar).Value = getRoomType
            dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = getResDate

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            'If count > 0 Then
            DSGetRoomRateTopContracts = dsMain
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
    Function DSLoadAllInclusiveContracts(ByVal ValTopId As String, ByVal ValCategory As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim TopId As String = ValTopId
            Dim Category As String = ValCategory


            dcSearch = New SqlCommand("SelectContractDetailResAI_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcSearch.Parameters.Add("@Topid", SqlDbType.VarChar).Value = TopId
            dcSearch.Parameters.Add("@Category", SqlDbType.VarChar).Value = Category


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSLoadAllInclusiveContracts = dsMain
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
    Function DSRoomType(ByVal Roomno As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim getRoomNo As String = Roomno

            dcSearch = New SqlCommand("select Category from dbo.[Rooms.Master] where Roomno=@Rooomno", Conn)
            dcSearch.Parameters.Add("@Rooomno", SqlDbType.VarChar).Value = getRoomNo


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSRoomType = dsMain
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
    Function DSGetDepDate(ByVal Roomno As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim getRoomNo As String = Roomno

            dcSearch = New SqlCommand("SELECT dbo.[Room.CurrentStatus].RoomNo, dbo.GuestRegistration.ReservationNo, dbo.GuestRegistration.DepDate,dbo.[Reservation.Master].ResType ,dbo.[Reservation.Master].Topcode,dbo.[Reservation.Master].MealPlan ,dbo.GuestRegistration.DTime  FROM dbo.[Room.CurrentStatus] INNER JOIN dbo.[Reservation.Master] ON dbo.[Room.CurrentStatus].ReservationNo = dbo.[Reservation.Master].ResNo INNER JOIN dbo.GuestRegistration ON dbo.[Reservation.Master].ResNo = dbo.GuestRegistration.ReservationNo where dbo.GuestRegistration.IsBillingGuest=1 and dbo.[Room.CurrentStatus].RoomNo=@Rooomno", Conn)
            dcSearch.Parameters.Add("@Rooomno", SqlDbType.VarChar).Value = getRoomNo


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSGetDepDate = dsMain
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
    Private Function getNewKotBotNO() As String
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim daGetDets As SqlDataAdapter
        Try

            Conn.Open()
            daGetDets = New SqlDataAdapter("select isnull(MAX(no),0) as no from [KotBotMaster]", Conn)
            Dim dsShow As DataSet = New DataSet
            daGetDets.Fill(dsShow)
            If (Not dsShow Is Nothing) Then
                If (dsShow.Tables(0).Rows.Count > 0) Then
                    getNewKotBotNO = dsShow.Tables(0).Rows(0)("no")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return Nothing
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
        End Try
    End Function
    Private Sub InsertBillingKOTBOT()
        Dim cnumberPart As String = ""
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim dcInsertNewAccDetail As New SqlCommand
        Dim dcUpdateInventory As New SqlCommand

        Dim dateVal As DateTime = System.DateTime.Now() 'Convert.ToDateTime(dtDate.Text)
        Dim intNo As Integer = getNewKotBotNO()
        intNo = intNo + 1
        cnumberPart = intNo.ToString()

        Dim autoid As String = ""
        'KOT20121004
        Dim KotBotDetails As New DataTable

        Dim TransIns As SqlTransaction
        Dim IsTrans As Boolean = False

        Try
            KotBotDetails.TableName = "KotBotDetails"
            KotBotDetails.Columns.Add("KotBotId")
            KotBotDetails.Columns.Add("ItemCode")
            KotBotDetails.Columns.Add("ItemName")
            KotBotDetails.Columns.Add("Qty")
            KotBotDetails.Columns.Add("UnitPrice")

            Conn.Open()
            TransIns = Conn.BeginTransaction
            IsTrans = True

            'Dim DataRowCount As Integer = gvItemDets.DataRowCount
            'Dim I As Integer
            'For I = 0 To DataRowCount - 1
            Dim drDetail As DataRow = KotBotDetails.NewRow()
            Dim CellValNaME As String = "Room Change Charges"
            Dim CellValItemCode As String = "SIT0000002"
            Dim CellValQty As Int32 = 1
            Dim CellValPrice As Double = Double.Parse(PubGrandTotal)



            drDetail("KotBotId") = autoid
            drDetail("ItemCode") = CellValItemCode
            drDetail("ItemName") = CellValNaME
            drDetail("Qty") = CellValQty.ToString()
            drDetail("UnitPrice") = CellValPrice.ToString()
            KotBotDetails.Rows.Add(drDetail)

            dcInsertNewAccDetail = New SqlCommand("InsertBillingKOTBOTDetail_SP", Conn)
            dcInsertNewAccDetail.Transaction = TransIns

            dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
            dcInsertNewAccDetail.Parameters.Add("KOTBOTID ", SqlDbType.VarChar).Value = autoid.ToString()
            dcInsertNewAccDetail.Parameters.Add("ItemCode", SqlDbType.VarChar).Value = CellValItemCode
            dcInsertNewAccDetail.Parameters.Add("ItemName", SqlDbType.VarChar).Value = CellValNaME
            dcInsertNewAccDetail.Parameters.Add("Qty", SqlDbType.Int).Value = CellValQty
            dcInsertNewAccDetail.Parameters.Add("UnitPrice", SqlDbType.Money).Value = CellValPrice
            dcInsertNewAccDetail.ExecuteNonQuery()
            '    Next
            'Conn.Close()

            'Conn.Open()
            dcInsertNewAcc = New SqlCommand("InsertBillingKOTBOT_SP", Conn)
            dcInsertNewAcc.Transaction = TransIns

            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("Id", SqlDbType.VarChar).Value = autoid.ToString()
            dcInsertNewAcc.Parameters.Add("Date", SqlDbType.DateTime).Value = DateTime.Now().ToString() 'dtDate.Text.Trim
            dcInsertNewAcc.Parameters.Add("RoomNo", SqlDbType.VarChar).Value = cmbRoom.Text.Trim
            dcInsertNewAcc.Parameters.Add("BillGenerated", SqlDbType.Bit).Value = False
            dcInsertNewAcc.Parameters.Add("ReservationNo", SqlDbType.VarChar).Value = PubResno
            dcInsertNewAcc.Parameters.Add("CreatedBy ", SqlDbType.VarChar).Value = ""
            dcInsertNewAcc.Parameters.Add("Type", SqlDbType.VarChar).Value = "RSERVICE"
            dcInsertNewAcc.Parameters.Add("Department", SqlDbType.VarChar).Value = "FOFFICE"
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
            '----- my sp should come here 'zuhri        
            '---------------------
            TransIns.Commit()
            IsTrans = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            If IsTrans Then
                TransIns.Rollback()
            End If

            Conn.Dispose()
            dcInsertNewAcc.Dispose()
            dcInsertNewAccDetail.Dispose()
            dcUpdateInventory.Dispose()
        End Try
        TransIns.Dispose()

    End Sub




    Private Sub frmRoomnochange_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class