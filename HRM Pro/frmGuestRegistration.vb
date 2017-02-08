Imports System.Data.SqlClient

Public Class frmGuestRegistration

    Dim IsValidRegistration As Boolean
    Public ReservertionNo As String


    Public ReportName As String
    Public rptTitle As String
    Public SF As String = ""

    Private Sub frmGuestRegistration_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmReservertionSearch.Show()
        frmReservertionSearch.LoadGuestDetails()
    End Sub

    Private Sub frmGuestRegistration_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txtGuestRegNo.Properties.ReadOnly = True
        txtReservationNo.Properties.ReadOnly = True
        dtReservationDate.Properties.ReadOnly = True
        txtTourOperator.Properties.ReadOnly = True
        txtNoOfPerson.Properties.ReadOnly = True
        txtMP.Properties.ReadOnly = True
        txtGuestRegd.Properties.ReadOnly = True
        txtGuestTot.Properties.ReadOnly = True
        dtRegDate.Properties.ReadOnly = True

        dtArriveDate.EditValue = Now.Date
        dtDepartureDate.EditValue = Now.Date
        '  dtDOB.EditValue = Now.Date

        'dtPPDateofIssue.EditValue = Now.Date

        dtRegDate.EditValue = Now.Date
        dtReservationDate.EditValue = Now.Date

        tabMain.TabPages(0).PageVisible = False

        '----  what im gonna do is when reservertion no came from previous screen we can load its
        ' current details in this form..
        tabMain.SelectedTabPageIndex = 1
        'LoadReservertionDetails(ReservertionNo)
        LoadReservertionDetails()

        LoadGuestSearchCombo()

        LoadRoomShareWith()

        

        LoadGuestSearch(0)
    End Sub


#Region " Proc & Funcs "


   
   
    Sub ClearAllRecords()

        'txtArriveFrom.Text = ""
        'txtAFlight.Text = ""
        'txtDepartureTo.Text = ""
        'txtDFlight.Text = ""
        'txtFullName.Text = ""
        txtGuestRegd.Text = GetTotalReservations()
        txtGuestRegNo.Text = GetGuestRegCode() ' = "", NewGRegNo, GetGuestRegCode())
        'txtGuestTot.Text = ""
        txtHomeAdd.Text = ""
        'txtMP.Text = ""
        cmbCountry.SelectedIndex = 0
        txtNationality.Text = ""
        'txtNoOfPerson.Text = ""
        txtPassportNo.Text = ""
        txtPPPlaceOfIssue.Text = ""
        'txtProfession.Text = "EMPLOYED"
        txtProfession.Text = ""
        'txtReservationNo.Text = ""
        'txtRoom.Text = ""
        txtTotVisitMaldives.Text = ""
        'txtTourOperator.Text = ""

        chkIsBillingGuest.Checked = False
        cmbBedtax.SelectedIndex = 0


        txtTelephne.Text = ""
        txtCity.Text = ""
        txtEmail.Text = ""
        cmbpaymode.SelectedIndex = 0
        cmbCCType.Text = ""
        txtTotVisitEriyadu.Text = ""
        txtCompany.Text = ""


        'dtPPDateofIssue.EditValue = ""
        'dtDOB.EditValue = ""





        IsValidRegistration = IIf(ReservertionNo = "", False, True)

        'cmbShareWith.Text = ""

        LoadRoomShareWith()
    End Sub

    Function ValidateGuestRegistration() As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetRes As New SqlDataAdapter(String.Format("select resno from vwReservertionMaster where resno like '{0}'", txtReservationNo.Text), Conn)
        Dim dsGetRes As New DataSet

        Try

            daGetRes.Fill(dsGetRes)

            If dsGetRes.Tables(0).Rows.Count > 0 Then
                If IsDBNull(dsGetRes.Tables(0).Rows(0).Item(0)) Or dsGetRes.Tables(0).Rows(0).Item(0) Is Nothing Then
                    ValidateGuestRegistration = False
                Else
                    ValidateGuestRegistration = True
                End If
            Else
                ValidateGuestRegistration = False
            End If

            Return ValidateGuestRegistration
        Catch ex As ApplicationException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally

            Conn.Dispose()
            daGetRes.Dispose()
            dsGetRes.Dispose()

        End Try


    End Function

    Function FieldValidation() As Boolean
        ' Return IIf(String.Compare(txtReservationNo.Text, "", False) = 0 Or String.Compare(dtReservationDate.Text, "", False) = 0 Or String.Compare(txtFullName.Text, "", False) = 0 Or String.Compare(txtPassportNo.Text, "", False) = 0 Or String.Compare(cmbRoomNo.Text, "", False) = 0, 0, 1)


        Return IIf(String.Compare(txtReservationNo.Text, "", False) = 0 Or String.Compare(dtReservationDate.Text, "", False) = 0 Or String.Compare(txtFullName.Text, "", False) = 0 Or String.Compare(cmbRoomNo.Text, "", False) = 0, 0, 1)


    End Function

    Function InsertNewGuest(ByVal spToRun As String) As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand
        Dim sqlString As String

        Try

            Conn.Open()


            '---- REMOVE TEMP TABLE

            dcExec = New SqlCommand(String.Format("delete from GuestRegistrationTemp where curruser ='{0}'", CurrUser), Conn)

            dcExec.ExecuteNonQuery()

            dcExec.Dispose()


            '----- insert new details

            sqlString = "INSERT INTO dbo.GuestRegistrationTemp ( ReservationNo ,ReservationDate ,GuestRegNo ,GuestRegDate ,ArriveDate ,ArriveFrom ,DepDate ,DepTo ,AFlight ,DFlight ,ATime,DTime,FullName ,PassportNo ,PPDateOfIssue ,PPPlaceOfIssue ,Nationality ,Country ,HomeAddress ,Profession ,DOB ,NoOfVisitMaldives ,NoOfVisitEriyadu ,RoomType ,RoomNo,RoomShareWith,IsBillingGuest,IsBedTaxApply,CurrUser,Tel,Email,Company,City,PayType,CcType)" & _
                        " VALUES  ( @ReservationNo ,@ReservationDate ,@GuestRegNo ,@GuestRegDate ,@ArriveDate ,@ArriveFrom ,@DepDate ,@DepTo ,@AFlight ,@DFlight ,@ATime,@DTime,@FullName ,@PassportNo ,@PPDateOfIssue ,@PPPlaceOfIssue ,@Nationality ,@Country ,@HomeAddress ,@Profession ,@DOB ,@NoOfVisitMaldives ,@NoOfVisitEriyadu ,@RoomType ,@RoomNo,@RoomShareWith,@IsBillingGuest,@IsBedTaxApply,@CurrUser,@Tel,@Email,@Company,@City,@PayType,@CcType)"

            dcExec = New SqlCommand(sqlString, Conn)


            dcExec.Parameters.Add("@ReservationNo", SqlDbType.NVarChar).Value = txtReservationNo.Text
            dcExec.Parameters.Add("@ReservationDate", SqlDbType.Date).Value = dtReservationDate.Text
            dcExec.Parameters.Add("@GuestRegNo", SqlDbType.NVarChar).Value = txtGuestRegNo.Text
            dcExec.Parameters.Add("@GuestRegDate", SqlDbType.Date).Value = dtRegDate.Text
            dcExec.Parameters.Add("@ArriveDate", SqlDbType.Date).Value = dtArriveDate.Text
            dcExec.Parameters.Add("@ArriveFrom", SqlDbType.NVarChar).Value = txtArriveFrom.Text
            dcExec.Parameters.Add("@DepDate", SqlDbType.Date).Value = dtDepartureDate.Text
            dcExec.Parameters.Add("@DepTo", SqlDbType.NVarChar).Value = txtDepartureTo.Text
            dcExec.Parameters.Add("@AFlight", SqlDbType.NVarChar).Value = txtAFlight.Text
            dcExec.Parameters.Add("@DFlight", SqlDbType.NVarChar).Value = txtDFlight.Text

            dcExec.Parameters.Add("@ATime", SqlDbType.DateTime).Value = Convert.ToDateTime(txtArrtime.Text.Trim)
            dcExec.Parameters.Add("@DTime", SqlDbType.DateTime).Value = Convert.ToDateTime(txtDepTime.Text.Trim)



            dcExec.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = txtFullName.Text
            dcExec.Parameters.Add("@PassportNo", SqlDbType.NVarChar).Value = txtPassportNo.Text
            dcExec.Parameters.Add("@PPDateOfIssue", SqlDbType.Date).Value = dtPPDateofIssue.Text
            dcExec.Parameters.Add("@PPPlaceOfIssue", SqlDbType.NVarChar).Value = txtPPPlaceOfIssue.Text
            dcExec.Parameters.Add("@Nationality", SqlDbType.NVarChar).Value = txtNationality.Text
            dcExec.Parameters.Add("@Country", SqlDbType.NVarChar).Value = cmbCountry.Text
            dcExec.Parameters.Add("@HomeAddress", SqlDbType.NVarChar).Value = txtHomeAdd.Text
            dcExec.Parameters.Add("@Profession", SqlDbType.NVarChar).Value = txtProfession.Text
            dcExec.Parameters.Add("@DOB", SqlDbType.Date).Value = dtDOB.Text
            dcExec.Parameters.Add("@NoOfVisitMaldives", SqlDbType.NVarChar).Value = txtTotVisitMaldives.Text
            dcExec.Parameters.Add("@NoOfVisitEriyadu", SqlDbType.NVarChar).Value = txtTotVisitEriyadu.Text
            dcExec.Parameters.Add("@RoomType", SqlDbType.NVarChar).Value = txtRoom.Text
            dcExec.Parameters.Add("@RoomNo", SqlDbType.NVarChar).Value = cmbRoomNo.Text
            dcExec.Parameters.Add("@RoomShareWith", SqlDbType.NVarChar).Value = cmbShareWith.Text
            dcExec.Parameters.Add("@IsBillingGuest", SqlDbType.NVarChar).Value = chkIsBillingGuest.Checked

            
            dcExec.Parameters.Add("@IsBedTaxApply", SqlDbType.VarChar).Value = cmbBedtax.Text.Trim


            dcExec.Parameters.Add("@CurrUser", SqlDbType.NVarChar).Value = CurrUser


            dcExec.Parameters.Add("@Tel", SqlDbType.VarChar).Value = txtTelephne.Text.Trim
            dcExec.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text.Trim
            dcExec.Parameters.Add("@Company", SqlDbType.VarChar).Value = txtCompany.Text.Trim
            dcExec.Parameters.Add("@City", SqlDbType.VarChar).Value = txtCity.Text.Trim
            dcExec.Parameters.Add("@PayType", SqlDbType.VarChar).Value = cmbpaymode.Text.Trim
            dcExec.Parameters.Add("@CcType", SqlDbType.VarChar).Value = cmbCCType.Text.Trim



            dcExec.ExecuteNonQuery()

            dcExec.Dispose()

            '----- now run sp...

            dcExec = New SqlCommand(spToRun, Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            dcExec.Parameters.Add("@ReservertionNo", SqlDbType.NVarChar).Value = txtReservationNo.Text
            dcExec.Parameters.Add("@GuestRegNo", SqlDbType.NVarChar).Value = txtGuestRegNo.Text
            dcExec.Parameters.Add("@PassportNo", SqlDbType.NVarChar).Value = txtPassportNo.Text
            dcExec.Parameters.Add("@CurrUser", SqlDbType.NVarChar).Value = CurrUser
            dcExec.ExecuteNonQuery()


            InsertNewGuest = True

        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            InsertNewGuest = False
        Catch ex As ApplicationException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            InsertNewGuest = False
        Finally
            Conn.Dispose()
            dcExec.Dispose()

        End Try

    End Function

    Function GetGuestRegCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "GR"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output

            dcGetCode.ExecuteNonQuery()


            'GetGuestRegCode = IIf(dcGetCode.Parameters("@Currcode").Value.ToString = "", NewGRegNo, dcGetCode.Parameters("@Currcode").Value)

            GetGuestRegCode = dcGetCode.Parameters("@Currcode").Value.ToString
            Return GetGuestRegCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function

    Function NewGRegNo() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand("insert into AutoNumberMaster (prefix,incnumber,totallength,maintype,currcode) values('GR','1','10','GR','GR00000001')", Conn)

        Try
            Conn.Open()

            dcExec.ExecuteNonQuery()

            Return "GR00000001"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcExec.Dispose()
        End Try


    End Function

    Sub LoadGuestSearchCombo()

        Dim Conn As New SqlConnection(ConnString)
        Dim daGetGuest As New SqlDataAdapter("select FullName,Country,PassportNo from GuestRegistrationHistory", Conn)
        Dim dsShowguest As New DataSet

        Try
            daGetGuest.Fill(dsShowguest)

            With cmbGuestSearch.Properties
                .DataSource = dsShowguest.Tables(0)
                .DisplayMember = "FullName"
                .ValueMember = "PassportNo"
                .PopupWidth = 450

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetGuest.Dispose()
            dsShowguest.Dispose()
        End Try

    End Sub

    Sub LoadRoomShareWith()
        '---- when new guest registration clicked we need to list given reservation guests,so its easy to set room no.

        Dim Conn As New SqlConnection(ConnString)
        Dim daGetGuest As New SqlDataAdapter(String.Format("select FullName from GuestRegistration where reservationno like '{0}'", txtReservationNo.Text), Conn)
        Dim dsShowguest As New DataSet

        Try
            daGetGuest.Fill(dsShowguest)

            Dim drnew As DataRow = dsShowguest.Tables(0).NewRow
            drnew.Item(0) = ""

            dsShowguest.Tables(0).Rows.Add(drnew)


            With cmbShareWith.Properties
                .DataSource = dsShowguest.Tables(0)
                .DisplayMember = "FullName"
                .ValueMember = "FullName"
                .PopupWidth = 200

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetGuest.Dispose()
            dsShowguest.Dispose()
        End Try

    End Sub

    Sub LoadReservertionDetails()

        Dim Conn As New SqlConnection(ConnString)
        'Dim daGetGuest As New SqlDataAdapter(String.Format("select ResNo,ResDate,Guest,ResType,Topcode,IsTopcontract, TopContractId, ArrDate,DepDate,ArrFlight,DepFlight,convert(char(5),ArrTime, 108) [ArrTime],convert(char(5),DepTime, 108) [DepTime],ArrTrans,DepTrans, PaxId, AdultQty, ChildrenQty, InfantsQty, MealPlan, Rate, DisPlanId, OfferId, AmenId,Total, PayMode, PayExpiryDate, PayCCNo, Guestlikes,Guestdislikes, BillingInst, Remarks, Refno, Status, IsProformaCreated, ProfomaInvoiceno,EnteredBy, EnteredDate, InactivatedBy, InactivatedDate, Room, TopName from vwReservertionMaster where Status='OPEN' AND Resno like '{0}'", ReservertionNo), Conn)

        Dim daGetGuest As New SqlDataAdapter(String.Format("select ResNo,ResDate,Guest,ResType,Topcode,IsTopcontract, TopContractId, ArrDate,DepDate,ArrFlight,DepFlight,convert(char(5),ArrTime, 108) [ArrTime],convert(char(5),DepTime, 108) [DepTime],ArrTrans,DepTrans, PaxId, AdultQty, ChildrenQty, InfantsQty, MealPlan, Rate, DisPlanId, OfferId, AmenId,Total, PayMode, PayExpiryDate, PayCCNo, Guestlikes,Guestdislikes, BillingInst, Remarks, Refno, Status, IsProformaCreated, ProfomaInvoiceno,EnteredBy, EnteredDate, InactivatedBy, InactivatedDate, Room, TopName from vwReservertionMasterGuestReg where Status='OPEN' AND Resno like '{0}'", ReservertionNo), Conn)






        Dim dsShowguest As New DataSet

        Try
            daGetGuest.Fill(dsShowguest)


            If dsShowguest.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            txtReservationNo.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("Resno")), "", dsShowguest.Tables(0).Rows(0).Item("Resno"))
            dtReservationDate.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("ResDate")), "", dsShowguest.Tables(0).Rows(0).Item("ResDate"))

            txtFullName.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("Guest")), "", dsShowguest.Tables(0).Rows(0).Item("Guest"))


            txtTourOperator.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("TopName")), "", dsShowguest.Tables(0).Rows(0).Item("TopName"))
            txtTOPCode.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("Topcode")), "", dsShowguest.Tables(0).Rows(0).Item("Topcode"))

            Dim adults As Integer = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("AdultQty")), 0, dsShowguest.Tables(0).Rows(0).Item("AdultQty"))
            Dim child As Integer = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("ChildrenQty")), 0, dsShowguest.Tables(0).Rows(0).Item("ChildrenQty"))
            Dim Infants As Integer = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("InfantsQty")), 0, dsShowguest.Tables(0).Rows(0).Item("InfantsQty"))


            txtNoOfPerson.Text = adults + child + Infants '---- need to knw wht to take.
            txtGuestTot.Text = adults + child + Infants
            txtGuestRegd.Text = GetTotalReservations()





            txtMP.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("MealPlan")), "", dsShowguest.Tables(0).Rows(0).Item("MealPlan"))
            txtArriveFrom.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("ArrTrans")), "", dsShowguest.Tables(0).Rows(0).Item("ArrTrans"))
            dtArriveDate.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("ArrDate")), "", dsShowguest.Tables(0).Rows(0).Item("ArrDate"))
            txtAFlight.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("ArrFlight")), "", dsShowguest.Tables(0).Rows(0).Item("ArrFlight"))
            txtDepartureTo.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("DepTrans")), "", dsShowguest.Tables(0).Rows(0).Item("DepTrans"))
            dtDepartureDate.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("DepDate")), "", dsShowguest.Tables(0).Rows(0).Item("DepDate"))
            txtArrtime.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("ArrTime")), "", dsShowguest.Tables(0).Rows(0).Item("ArrTime"))
            txtDepTime.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("DepTime")), "", dsShowguest.Tables(0).Rows(0).Item("DepTime"))

           

            txtDFlight.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("DepFlight")), "", dsShowguest.Tables(0).Rows(0).Item("DepFlight"))
            txtRoom.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("Room")), "", dsShowguest.Tables(0).Rows(0).Item("Room"))

            LoadAvailableRooms()

            LoadGuestDetailsGrid()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetGuest.Dispose()
            dsShowguest.Dispose()
        End Try

    End Sub

    Function GetTotalReservations() As Integer

        Dim Conn As New SqlConnection(ConnString)
        Dim daGetTot As New SqlDataAdapter(String.Format("select count(GuestRegNo) from GuestRegistration where ReservationNo ='{0}'", ReservertionNo), Conn)
        Dim dsShow As New DataSet

        Try

            daGetTot.Fill(dsShow)

                Return dsShow.Tables(0).Rows(0).Item(0)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            daGetTot.Dispose()
            dsShow.Dispose()
        End Try


    End Function

    Sub GetGuestDetsfromHistory(ByVal PPNo As String) ', ByVal Name As String)
        Dim Conn As New SqlConnection(ConnString)
        Dim sqlstr As String = String.Format("select * from GuestRegistrationHistory where passportno like '{0}'", PPNo)


        Dim daGetGuest As New SqlDataAdapter(sqlstr, Conn)
        Dim dsShowguest As New DataSet

        Try
            daGetGuest.Fill(dsShowguest)

            If dsShowguest.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            txtFullName.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("FullName")), "", dsShowguest.Tables(0).Rows(0).Item("FullName"))
            txtPassportNo.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("PassportNo")), "", dsShowguest.Tables(0).Rows(0).Item("PassportNo"))
            dtPPDateofIssue.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("PPDateOfIssue")), "", dsShowguest.Tables(0).Rows(0).Item("PPDateOfIssue"))
            txtPPPlaceOfIssue.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("PPPlaceOfIssue")), "", dsShowguest.Tables(0).Rows(0).Item("PPPlaceOfIssue"))
            txtNationality.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("Nationality")), "", dsShowguest.Tables(0).Rows(0).Item("Nationality"))
            cmbCountry.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("Country")), "", dsShowguest.Tables(0).Rows(0).Item("Country"))
            txtHomeAdd.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("HomeAddress")), "", dsShowguest.Tables(0).Rows(0).Item("HomeAddress"))
            txtProfession.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("Profession")), "", dsShowguest.Tables(0).Rows(0).Item("Profession"))
            dtDOB.Text = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("DOB")), "", dsShowguest.Tables(0).Rows(0).Item("DOB"))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetGuest.Dispose()
            dsShowguest.Dispose()
        End Try
    End Sub

    Sub LoadAvailableRooms()

        'Dim Conn As New SqlConnection(ConnString)
        'Dim daGetAll As New SqlDataAdapter(String.Format("select Roomno from [rooms.master] where category ='{0}' and status ='vacant'", txtRoom.Text), Conn)
        'Dim dsShow As New DataSet

        'Try

        '    daGetAll.Fill(dsShow)

        '    For i As Integer = 0 To dsShow.Tables(0).Rows.Count - 1

        '        cmbRoomNo.Properties.Items.Add(dsShow.Tables(0).Rows(i).Item(0))

        '    Next

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        'Finally
        '    Conn.Dispose()
        '    daGetAll.Dispose()
        '    dsShow.Dispose()
        'End Try


        '---- 
        '---- according to the new requirement they need to assign rooms in reservertion time,from that only we can take the rooms.


        Dim Conn As New SqlConnection(ConnString)
        ' Dim daGetAll As New SqlDataAdapter(String.Format("select Roomno from [rooms.master] where category ='{0}' and status ='vacant'", txtRoom.Text), Conn)
        Dim daGetAll As New SqlDataAdapter(String.Format("select Roomno from ReservertionRoomAssign where Resno ='{0}'", txtReservationNo.Text), Conn)
        Dim dsShow As New DataSet

        Try

            cmbRoomNo.Properties.Items.Clear()
            cmbRoomNo.Text = ""

            daGetAll.Fill(dsShow)

            For i As Integer = 0 To dsShow.Tables(0).Rows.Count - 1

                cmbRoomNo.Properties.Items.Add(dsShow.Tables(0).Rows(i).Item(0))

            Next

            cmbRoomNo.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetAll.Dispose()
            dsShow.Dispose()
        End Try





    End Sub
    Sub LoadAvailableRoomsManual()

        Dim Conn As New SqlConnection(ConnString)
        ' Dim daGetAll As New SqlDataAdapter(String.Format("select Roomno from [rooms.master] where category ='{0}' and status ='vacant'", txtRoom.Text), Conn)

        Dim daGetAll As New SqlDataAdapter(String.Format("select Roomno from [rooms.master] where IsInactive=0 and status ='vacant'"), Conn)

        Dim dsShow As New DataSet

        Try

            daGetAll.Fill(dsShow)

            For i As Integer = 0 To dsShow.Tables(0).Rows.Count - 1

                cmbRoomNo.Properties.Items.Add(dsShow.Tables(0).Rows(i).Item(0))

            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetAll.Dispose()
            dsShow.Dispose()
        End Try
    End Sub


    Sub LoadGuestDetailsGrid()

        Dim Conn As New SqlConnection(ConnString)
        Dim daGetGuest As New SqlDataAdapter(String.Format("select * from GuestRegistration where Reservationno like '{0}'", ReservertionNo), Conn)
        Dim dsShowguest As New DataSet

        Try
            daGetGuest.Fill(dsShowguest)

            gridGuestDetails.DataSource = dsShowguest.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetGuest.Dispose()
            dsShowguest.Dispose()
        End Try

    End Sub

    Sub DisplayGuestDetz(ByVal GuestRegno As String)

        Dim Conn As New SqlConnection(ConnString)
        ' Dim daGetDetz As New SqlDataAdapter(String.Format("select * from GuestRegistration where GuestRegNo like '{0}'", GuestRegno), Conn)

        Dim daGetDetz As New SqlDataAdapter(String.Format("select ReservationNo,FullName,ReservationDate,GuestRegNo,GuestRegDate,ArriveDate,ArriveFrom,DepDate,DepTo,AFlight,DFlight,convert(char(5),ATime, 108) [ATime],convert(char(5),DTime, 108) [DTime],FullName,PassportNo,PPDateOfIssue,PPPlaceOfIssue,Nationality,Country,HomeAddress,Profession,DOB,NoOfVisitMaldives,NoOfVisitEriyadu,RoomType,RoomNo,RoomShareWith,IsBillingGuest,Tel,Email,Company,City,GPayType,CcType from GuestRegistration where GuestRegNo like '{0}'", GuestRegno), Conn)



        Dim dsShowDetz As New DataSet

        Try

            daGetDetz.Fill(dsShowDetz)

            If dsShowDetz.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If


            txtReservationNo.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("ReservationNo")), "", dsShowDetz.Tables(0).Rows(0).Item("ReservationNo"))
            txtFullName.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("FullName")), "", dsShowDetz.Tables(0).Rows(0).Item("FullName"))
            dtReservationDate.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("ReservationDate")), "", dsShowDetz.Tables(0).Rows(0).Item("ReservationDate"))
            txtGuestRegNo.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("GuestRegNo")), "", dsShowDetz.Tables(0).Rows(0).Item("GuestRegNo"))
            dtRegDate.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("GuestRegDate")), "", dsShowDetz.Tables(0).Rows(0).Item("GuestRegDate"))
            dtArriveDate.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("ArriveDate")), "", dsShowDetz.Tables(0).Rows(0).Item("ArriveDate"))
            txtArriveFrom.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("ArriveFrom")), "", dsShowDetz.Tables(0).Rows(0).Item("ArriveFrom"))
            dtDepartureDate.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("DepDate")), "", dsShowDetz.Tables(0).Rows(0).Item("DepDate"))
            txtDepartureTo.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("DepTo")), "", dsShowDetz.Tables(0).Rows(0).Item("DepTo"))
            txtAFlight.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("AFlight")), "", dsShowDetz.Tables(0).Rows(0).Item("AFlight"))
            txtDFlight.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("DFlight")), "", dsShowDetz.Tables(0).Rows(0).Item("DFlight"))

            txtArrtime.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("ATime")), "", dsShowDetz.Tables(0).Rows(0).Item("ATime"))
            txtDepTime.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("DTime")), "", dsShowDetz.Tables(0).Rows(0).Item("DTime"))

            txtFullName.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("FullName")), "", dsShowDetz.Tables(0).Rows(0).Item("FullName"))
            txtPassportNo.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("PassportNo")), "", dsShowDetz.Tables(0).Rows(0).Item("PassportNo"))
            dtPPDateofIssue.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("PPDateOfIssue")), "", dsShowDetz.Tables(0).Rows(0).Item("PPDateOfIssue"))
            txtPPPlaceOfIssue.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("PPPlaceOfIssue")), "", dsShowDetz.Tables(0).Rows(0).Item("PPPlaceOfIssue"))
            txtNationality.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("Nationality")), "", dsShowDetz.Tables(0).Rows(0).Item("Nationality"))
            cmbCountry.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("Country")), "", dsShowDetz.Tables(0).Rows(0).Item("Country"))
            txtHomeAdd.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("HomeAddress")), "", dsShowDetz.Tables(0).Rows(0).Item("HomeAddress"))
            txtProfession.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("Profession")), "", dsShowDetz.Tables(0).Rows(0).Item("Profession"))
            dtDOB.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("DOB")), "", dsShowDetz.Tables(0).Rows(0).Item("DOB"))
            txtTotVisitMaldives.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("NoOfVisitMaldives")), "", dsShowDetz.Tables(0).Rows(0).Item("NoOfVisitMaldives"))
            txtTotVisitEriyadu.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("NoOfVisitEriyadu")), "", dsShowDetz.Tables(0).Rows(0).Item("NoOfVisitEriyadu"))
            txtRoom.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("RoomType")), "", dsShowDetz.Tables(0).Rows(0).Item("RoomType"))
            cmbRoomNo.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("RoomNo")), "", dsShowDetz.Tables(0).Rows(0).Item("RoomNo"))
            cmbShareWith.EditValue = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("RoomShareWith")), "", dsShowDetz.Tables(0).Rows(0).Item("RoomShareWith"))
            chkIsBillingGuest.Checked = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("IsBillingGuest")), 0, dsShowDetz.Tables(0).Rows(0).Item("IsBillingGuest"))


            txtCity.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("City")), "", dsShowDetz.Tables(0).Rows(0).Item("City"))
            txtTelephne.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("Tel")), "", dsShowDetz.Tables(0).Rows(0).Item("Tel"))
            txtCompany.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("Company")), "", dsShowDetz.Tables(0).Rows(0).Item("Company"))
            txtEmail.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("Email")), "", dsShowDetz.Tables(0).Rows(0).Item("Email"))
            cmbpaymode.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("GPayType")), "", dsShowDetz.Tables(0).Rows(0).Item("GPayType"))
            cmbCCType.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("CcType")), "", dsShowDetz.Tables(0).Rows(0).Item("CcType"))



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDetz.Dispose()
            dsShowDetz.Dispose()
        End Try


    End Sub

    Sub LoadGuestSearch(ByVal SortColumn As Integer)

        Dim Conn As New SqlConnection(ConnString)
        Dim daGetGuest As New SqlDataAdapter("select * from GuestRegistrationHistory", Conn) 'GuestRegistrationHistory
        Dim dsShowguest As New DataSet

        Try
            daGetGuest.Fill(dsShowguest)
            'cmbGuestSearch.Properties.DataSource = Nothing

            'gridGuestDetails.DataSource = dsShowguest.Tables(0)
            With cmbGuestSearch.Properties
                .DataSource = dsShowguest.Tables(0)
                .AutoSearchColumnIndex = SortColumn
                .PopupWidth = 400
                .DisplayMember = "FullName"
                .ValueMember = "PassportNo"

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetGuest.Dispose()
            dsShowguest.Dispose()
        End Try

    End Sub


#End Region


    Private Sub txtFullName_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtFullName.EditValueChanging
        'If Not IsValidRegistration Then
        '    e.Cancel = True
        'End If
    End Sub

    Private Sub txtReservationNo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtReservationNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ValidateGuestRegistration()
        End If
    End Sub

    Private Sub txtReservationNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)

        ValidateGuestRegistration()
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestRegistration", "Add")

        If CheckAccess = True Then


            If String.Compare(cmdNew.Text, "New Guest", False) = 0 Then

                ClearAllRecords()

                cmdNew.Text = "Save"
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False

                tabMain.SelectedTabPageIndex = 1
                tabMain.TabPages(0).PageEnabled = False

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Val(txtGuestRegd.Text) = Val(txtGuestTot.Text) Then
                    MsgBox("Guest Registration Count Exceed Maximum Pax", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InsertNewGuest("spGuestRegInsert") Then
                    Exit Sub
                End If

                MsgBox("Successfully Inserted...", , ErrTitle)

                LoadGuestDetailsGrid()

                cmdNew.Text = "New Guest"
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True

                tabMain.TabPages(0).PageEnabled = False

            End If

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub cmbShareWith_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For i As Integer = 0 To gvGuestDetails.RowCount - 1

            If gvGuestDetails.GetRowCellValue(i, "FullName") = cmbShareWith.GetColumnValue("FullName") Then
                cmbRoomNo.EditValue = gvGuestDetails.GetRowCellValue(i, "RoomNo")
            End If

        Next

    End Sub

    Private Sub gvGuestDetails_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvGuestDetails.FocusedRowChanged
        If cmdNew.Text = "Save" Then
            Exit Sub
        End If

        DisplayGuestDetz(gvGuestDetails.GetRowCellValue(e.FocusedRowHandle, "GuestRegNo"))
    End Sub


    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestRegistration", "Edit")

        If CheckAccess = True Then


            If String.Compare(cmdEdit.Text, "Edit", False) = 0 Then


                cmdEdit.Text = "Save"
                cmdNew.Enabled = False
                cmdDelete.Enabled = False

                tabMain.SelectedTabPageIndex = 1

                'gvSelling.OptionsBehavior.Editable = True

                'IsSellEdited = False

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                'If Val(txtGuestRegd.Text) = Val(txtGuestTot.Text) Then
                '    MsgBox("Guest Registration Count Exceed Maximum Pax", MsgBoxStyle.Critical, ErrTitle)
                '    Exit Sub
                'End If

                If Not InsertNewGuest("spGuestRegEdit") Then
                    Exit Sub
                End If

                MsgBox("Successfully Updated...", , ErrTitle)

                LoadGuestDetailsGrid()

                cmdEdit.Text = "Edit"
                cmdNew.Enabled = True
                cmdDelete.Enabled = True

                tabMain.TabPages(0).PageEnabled = False

            End If


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub cmbGuestSearch_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---- if guest record found then we need to show their details 
        GetGuestDetsfromHistory(cmbGuestSearch.GetColumnValue("PassportNo"))

    End Sub

    Private Sub rbPP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPP.CheckedChanged, rbByName.CheckedChanged
        If rbPP.Checked Then
            txtSearchByPP.Visible = True
            cmbGuestSearch.Visible = False
            'LoadGuestSearch(0)
            'cmbGuestSearch.Properties.AutoSearchColumnIndex = 0
        ElseIf rbByName.Checked Then
            cmbGuestSearch.Visible = True
            txtSearchByPP.Visible = False
            'LoadGuestSearch(1)
            'cmbGuestSearch.Properties.AutoSearchColumnIndex = 2
        End If

    End Sub

    Private Sub txtSearchByPP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchByPP.KeyDown
        If e.KeyCode = Keys.Enter Then
            GetGuestDetsfromHistory(txtSearchByPP.Text)
        End If
    End Sub


    Private Sub frmGuestRegistration_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub btLoadrooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadAvailableRoomsManual()

    End Sub

    Private Sub txtFullName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFullName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFullName.Text = "" Then
                MsgBox("Enter Guest Name")
            Else
                txtPassportNo.Focus()
            End If

        End If
    End Sub

    Private Sub txtPassportNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassportNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPassportNo.Text = "" Then
                MsgBox("Enter Passport No")
            Else
                dtPPDateofIssue.Focus()
            End If

        End If
    End Sub

    Private Sub dtPPDateofIssue_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtPPDateofIssue.KeyDown
        If e.KeyCode = Keys.Enter Then
            
            txtPPPlaceOfIssue.Focus()


        End If
    End Sub

    Private Sub txtPPPlaceOfIssue_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPPPlaceOfIssue.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtHomeAdd.Focus()

        End If
    End Sub

    Private Sub txtHomeAdd_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHomeAdd.KeyDown

        If e.KeyCode = Keys.Enter Then
            txtCity.Focus()
        End If

    End Sub

    Private Sub txtNationality_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNationality.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtDOB.Focus()
        End If
    End Sub

    Private Sub cmbCountry_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCountry.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNationality.Focus()
        End If
    End Sub

    Private Sub txtProfession_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProfession.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCompany.Focus()
        End If
    End Sub

    Private Sub dtDOB_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtDOB.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProfession.Focus()
        End If
    End Sub

    Private Sub txtTotVisitMaldives_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotVisitMaldives.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTotVisitEriyadu.Focus()
        End If
    End Sub

    Private Sub txtTotVisitEriyadu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotVisitEriyadu.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbRoomNo.Focus()
        End If
    End Sub

    Private Sub cmbRoomNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)


        If e.KeyCode = Keys.Enter Then
            chkIsBillingGuest.Focus()
        End If
    End Sub

    Private Sub chkIsBillingGuest_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmbRoomNo.Focus()
        End If
    End Sub

    Private Sub cmbShareWith_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            cmdNew.Focus()
        End If
    End Sub

    Private Sub txtFullName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFullName.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtPassportNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassportNo.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtPPPlaceOfIssue_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPPPlaceOfIssue.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtHomeAdd_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHomeAdd.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtNationality_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNationality.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtProfession_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProfession.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtTotVisitMaldives_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotVisitMaldives.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtTotVisitEriyadu_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotVisitEriyadu.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

    End Sub

    Private Sub cmbCountry_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCountry.SelectedValueChanged


        If cmbCountry.Text.Trim = "Albania" Then

            txtNationality.Text = "Albanian"

        ElseIf cmbCountry.Text.Trim = "Armenia" Then

            txtNationality.Text = "Armenian"


        ElseIf cmbCountry.Text.Trim = "Australia" Then

            txtNationality.Text = "Australian"

        ElseIf cmbCountry.Text.Trim = "Austria" Then

            txtNationality.Text = "Austrian"

        ElseIf cmbCountry.Text.Trim = "Azerbaijan" Then

            txtNationality.Text = "Azerbaijani"


        ElseIf cmbCountry.Text.Trim = "Bangladesh" Then

            txtNationality.Text = "Bangladeshi"


        ElseIf cmbCountry.Text.Trim = "Bangladesh" Then

            txtNationality.Text = "Bangladeshi"


        ElseIf cmbCountry.Text.Trim = "Belarus" Then

            txtNationality.Text = "Belarusian"

        ElseIf cmbCountry.Text.Trim = "Belgium" Then

            txtNationality.Text = "Belgian"

        ElseIf cmbCountry.Text.Trim = "Bolivia" Then

            txtNationality.Text = "Bolivian"




        ElseIf cmbCountry.Text.Trim = "Brazil" Then

            txtNationality.Text = "Brazilian"

        ElseIf cmbCountry.Text.Trim = "United Kingdom" Then

            txtNationality.Text = "British"

        ElseIf cmbCountry.Text.Trim = "Bulgaria" Then

            txtNationality.Text = "Bulgarian"

        ElseIf cmbCountry.Text.Trim = "Cambodia" Then

            txtNationality.Text = "Cambodian"



        ElseIf cmbCountry.Text.Trim = "Canada" Then

            txtNationality.Text = "Canadian"

        ElseIf cmbCountry.Text.Trim = "Cape Verde Islands" Then

            txtNationality.Text = "Cape Verdean"

        ElseIf cmbCountry.Text.Trim = "China" Then

            txtNationality.Text = "Chinese"



        ElseIf cmbCountry.Text.Trim = "Colombia" Then

            txtNationality.Text = "Colombian"

        ElseIf cmbCountry.Text.Trim = "Cuba" Then

            txtNationality.Text = "Cuban"

        ElseIf cmbCountry.Text.Trim = "Czech Republic" Then

            txtNationality.Text = "Czech"




        ElseIf cmbCountry.Text.Trim = "Denmark" Then

            txtNationality.Text = "Danish"


        ElseIf cmbCountry.Text.Trim = "Dominica" Then

            txtNationality.Text = "Dominican"

        ElseIf cmbCountry.Text.Trim = "Dominican Republic" Then

            txtNationality.Text = "Dominican"

        ElseIf cmbCountry.Text.Trim = "Egypt" Then

            txtNationality.Text = "Egyptian"

        ElseIf cmbCountry.Text.Trim = "Denmark" Then

            txtNationality.Text = "Danish"

        ElseIf cmbCountry.Text.Trim = "France" Then

            txtNationality.Text = "French"

        ElseIf cmbCountry.Text.Trim = "Germany" Then

            txtNationality.Text = "German"



        ElseIf cmbCountry.Text.Trim = "Ghana" Then

            txtNationality.Text = "Ghanaian"

        ElseIf cmbCountry.Text.Trim = "Greece" Then

            txtNationality.Text = "Greek"

        ElseIf cmbCountry.Text.Trim = "Netherlands" Then

            txtNationality.Text = "Dutch"


        ElseIf cmbCountry.Text.Trim = "Holland" Then

            txtNationality.Text = "Dutch"


        ElseIf cmbCountry.Text.Trim = "Iceland" Then

            txtNationality.Text = "Icelandic"


        ElseIf cmbCountry.Text.Trim = "India" Then

            txtNationality.Text = "Indian"

        ElseIf cmbCountry.Text.Trim = "Indonesia" Then

            txtNationality.Text = "Indonesian"

        ElseIf cmbCountry.Text.Trim = "Ireland" Then

            txtNationality.Text = "Irish"

        ElseIf cmbCountry.Text.Trim = "Italy" Then

            txtNationality.Text = "Italian"

        ElseIf cmbCountry.Text.Trim = "Jamaica" Then

            txtNationality.Text = "Jamaican"

        ElseIf cmbCountry.Text.Trim = "Japan" Then

            txtNationality.Text = "Japanese"

        ElseIf cmbCountry.Text.Trim = "Kenya" Then

            txtNationality.Text = "Kenyan"


        ElseIf cmbCountry.Text.Trim = "Kuwait" Then

            txtNationality.Text = "Kuwaiti"

        ElseIf cmbCountry.Text.Trim = "Malaysia" Then

            txtNationality.Text = "Malaysian"

        ElseIf cmbCountry.Text.Trim = "Maldives" Then

            txtNationality.Text = "Maldivian"

        ElseIf cmbCountry.Text.Trim = "Mexico" Then

            txtNationality.Text = "Mexican"

        ElseIf cmbCountry.Text.Trim = "Nepal" Then

            txtNationality.Text = "Nepalese"






        ElseIf cmbCountry.Text.Trim = "Netherlands" Then

            txtNationality.Text = "Dutch"


        ElseIf cmbCountry.Text.Trim = "New Zealand" Then

            txtNationality.Text = "New Zealand"


        ElseIf cmbCountry.Text.Trim = "Oman" Then

            txtNationality.Text = "Omani"


        ElseIf cmbCountry.Text.Trim = "Pakistan" Then

            txtNationality.Text = "Pakistani"


        ElseIf cmbCountry.Text.Trim = "Philippines" Then

            txtNationality.Text = "Philippine"


        ElseIf cmbCountry.Text.Trim = "Poland" Then

            txtNationality.Text = "Polish"


        ElseIf cmbCountry.Text.Trim = "Portugal" Then

            txtNationality.Text = "Portuguese"


        ElseIf cmbCountry.Text.Trim = "Romania" Then

            txtNationality.Text = "Romanian"


        ElseIf cmbCountry.Text.Trim = "Russia" Then

            txtNationality.Text = "Russian"


        ElseIf cmbCountry.Text.Trim = "Saudi Arabia" Then

            txtNationality.Text = "Saudi Arabian"

        ElseIf cmbCountry.Text.Trim = "Scotland" Then

            txtNationality.Text = "Scottish"

        ElseIf cmbCountry.Text.Trim = "Singapore" Then

            txtNationality.Text = "Singaporean"


        ElseIf cmbCountry.Text.Trim = "South Africa" Then

            txtNationality.Text = "South African"

        ElseIf cmbCountry.Text.Trim = "Spain" Then

            txtNationality.Text = "Spanish"

        ElseIf cmbCountry.Text.Trim = "Sri Lanka" Then

            txtNationality.Text = "Sri Lankan"

        ElseIf cmbCountry.Text.Trim = "Sweden" Then

            txtNationality.Text = "Swedish"




        ElseIf cmbCountry.Text.Trim = "Switzerland" Then

            txtNationality.Text = "Swiss"


        ElseIf cmbCountry.Text.Trim = "Thailand" Then

            txtNationality.Text = "Thai"


        ElseIf cmbCountry.Text.Trim = "Turkey" Then

            txtNationality.Text = "Turkish"


        ElseIf cmbCountry.Text.Trim = "United Arab Emirates" Then

            txtNationality.Text = "Emirati"


        ElseIf cmbCountry.Text.Trim = "United States of America" Then

            txtNationality.Text = "American"


        ElseIf cmbCountry.Text.Trim = "Uzbekistan" Then

            txtNationality.Text = "Uzbek"



        ElseIf cmbCountry.Text.Trim = "Zimbabwe" Then

            txtNationality.Text = "Zimbabwean"


        Else


            txtNationality.Text = ""




        End If

        txtProfession.Text = "EMPLOYED"


    End Sub
    Private Sub PrintRegCard()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from view_guest_reg_card", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaRegno As String = txtGuestRegNo.Text.Trim
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            fltString = "{view_guest_reg_card.GuestRegNo}='" & ParaRegno & "'"





            Dim bt As DialogResult = MessageBox.Show("Do You Want To Print Default Guest Registration", "Print Guest Registration ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If bt = Windows.Forms.DialogResult.Yes Then

                If txtPassportNo.Text = "" Then

                    ReportName = "GuestregistrationCardEnglishNoDates.rpt"
                    rptTitle = "Guest Registration"

                Else

                    ReportName = "GuestregistrationCardEnglish.rpt"
                    rptTitle = "Guest Registration"

                End If

               


            Else



                If txtPassportNo.Text = "" Then

                    ReportName = "GuestregistrationCardEnglishNoDates.rpt"
                    rptTitle = "Guest Registration"

                Else

                    ReportName = "GuestregistrationCardNoDates.rpt"
                    rptTitle = "Guest Registration"

                End If


                

            End If

            

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
   

    Private Sub btGuestRegcard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGuestRegcard.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestRegistration", "Add")

        If CheckAccess = True Then

            PrintRegCard()
          
        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub btLoadrooms_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLoadrooms.Click
        LoadAvailableRoomsManual()
    End Sub

    Private Sub txtCity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCity.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtCity_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTelephne.Focus()
        End If
    End Sub

    Private Sub txtTelephne_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTelephne.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtEmail.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbpaymode.Focus()
        End If
    End Sub

    Private Sub cmbpaymode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbpaymode.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbCCType.Focus()
        End If
    End Sub

    Private Sub cmbCCType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCCType.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbCountry.Focus()
        End If
    End Sub

    Private Sub cmbCCType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCCType.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtCompany_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCompany.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTotVisitMaldives.Focus()
        End If
    End Sub

    Private Sub txtCompany_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompany.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
End Class
