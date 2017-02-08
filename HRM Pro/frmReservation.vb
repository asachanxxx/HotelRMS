Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
Imports System.Xml
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Text.RegularExpressions
Public Class frmReservation
    Public PubResType As String = ""
    Public PubDisID As Integer = 0
    Public PubOffID As Integer = 0
    Public PubAmentID As Integer = 0
    Public PubIscontract As Integer = 0
    Public PubContractId As String = ""
    Public PubPaxId As String = ""
    Public PubIsEdit As String = ""
    Public PubDoEdit As Integer = 0

    Public PubEdtResNo As String = ""
    Public PubEdtResDate As DateTime
    Public PubEdtGuest As String = ""
    Public PubEdtArrDate As DateTime
    Public PubEdtDepDate As DateTime
    Public PubEdtArrFlight As String = ""
    Public PubEdtDepFlight As String = ""
    Public PubEdtArrTime As String = ""
    Public PubEdtDepTime As String = ""
    Public PubEdtArrTrans As String = ""
    Public PubEdtDepTrans As String = ""
    Public PubEdtAdultQty As String = ""
    Public PubEdtChildrenQty As String = ""
    Public PubEdtInfantsQty As String = ""
    Public PubEdtMealPlan As String = ""
    Public PubEdtDisPlan As String = ""
    Public PubEdtOfferId As String = ""
    Public PubEdtAmenId As String = ""
    Public PubEdtRate As Decimal = 0.0
    Public PubEdtTotal As Decimal = 0.0
    Public PubEdtPayMode As String = ""
    Public PubEdtPayExpiryDate As DateTime
    Public PubEdtPayCCNo As String = ""
    Public PubEdtGuestlikes As String = ""
    Public PubEdtGuestdislikes As String = ""
    Public PubEdtBillingInst As String = ""
    Public PubEdtRemarks As String = ""
    Public PubEdtRefno As String = ""

    Public PubEdtRoom1 As String = ""
    Public PubEdtRoom2 As String = ""
    Public PubEdtRoom3 As String = ""
    Public PubEdtRoom4 As String = ""
    Public PubEdtRoom5 As String = ""
    Public PubEdtRoom6 As String = ""
    Public PubEdtRoom7 As String = ""
    Public PubEdtRoom8 As String = ""
    Public PubEdtRoom9 As String = ""
    Public PubEdtRoom10 As String = ""

    Public PubEdtRoomType1 As String = ""
    Public PubEdtRoomType2 As String = ""
    Public PubEdtRoomType3 As String = ""
    Public PubEdtRoomType4 As String = ""
    Public PubEdtRoomType5 As String = ""
    Public PubEdtRoomType6 As String = ""
    Public PubEdtRoomType7 As String = ""
    Public PubEdtRoomType8 As String = ""
    Public PubEdtRoomType9 As String = ""
    Public PubEdtRoomType10 As String = ""

    Public PubEdtRoomQty1 As String = ""
    Public PubEdtRoomQty2 As String = ""
    Public PubEdtRoomQty3 As String = ""
    Public PubEdtRoomQty4 As String = ""
    Public PubEdtRoomQty5 As String = ""
    Public PubEdtRoomQty6 As String = ""
    Public PubEdtRoomQty7 As String = ""
    Public PubEdtRoomQty8 As String = ""
    Public PubEdtRoomQty9 As String = ""
    Public PubEdtRoomQty10 As String = ""

    Public PubIsProformaCreated As Integer = 0
    Public PubProfomaInvoiceno As String = ""

    Public ReportName As String
    Public rptTitle As String
    Public SF As String = ""


    Private Sub frmReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()


        GetServerDate()
        'DtToday.Text = Now.Date
        ' DtResdate.Text = Now.Date
        'DtArrival.Text = Now.Date
        'DtDep.Text = DateAdd(DateInterval.Day, 1, Now.Date)
        DtExpiry.Text = Now.Date

        cmbRoom.SelectedIndex = 0
        cmbRoomtyp.SelectedIndex = 0
        'cbTopcode2.SelectedIndex = 0
        cmbMealplan.SelectedIndex = 0
        cmbpaymode.SelectedIndex = 0
        cmbArrTrans.SelectedIndex = 0
        cmbDepTrans.SelectedIndex = 0
        cmbArrType.SelectedIndex = 0
        cmbDepType.SelectedIndex = 0
        cmbArrTransTime.SelectedIndex = 0
        cmbDepTransTime.SelectedIndex = 0

        'gbBookingtype.Enabled = False
        'gbArridep.Enabled = False
        'gbpayment.Enabled = False
        'gbOthers.Enabled = False


        LoadTopcodes()
        LoadMealPalns()
        'LoadDiscounts()
        'LoadOffers()
        LoadAmentites()
        LoadGrid()



        txtArrMonth.Text = DateTime.Now.Month
        txtArrDay.Text = DateTime.Now.Day
        txtArryear.Text = DateTime.Now.Year

        txtDepMonth.Text = DateTime.Now.Month
        txtDepDay.Text = DateTime.Now.Day
        txtDepyear.Text = DateTime.Now.Year




        tabReservation.TabPages(1).PageEnabled = False


        btAdd.Focus()

    End Sub
    Private Sub LoadTopcodes()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select TopCode,TopName from [Touroperator.Master] where Status='Active' order by TopCode", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            Dim newCustomersRow As DataRow = dsMain.Tables(0).NewRow()


            'While (DscountTest < Dscount)

            '    cbTopcode2.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
            '    DscountTest = DscountTest + 1

            'End While

            With cbTopcode.Properties
                .DataSource = dsMain.Tables(0)
                .DisplayMember = "TopName"
                .ValueMember = "TopCode"
                .Columns(0).Width = 100
                .Columns(1).Width = 150
                .PopupWidth = 400
                .AutoSearchColumnIndex = 1
                .TextEditStyle = True

            End With

            'cbTopcode2.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub GetServerDate()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select GETDATE()as sysdate", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim SysDate As DateTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0).Item("sysdate"))


            DtToday.Text = SysDate
            DtResdate.Text = SysDate


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadMealPalns()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Distinct MealType from dbo.[MealPlan.Master]  where Status='OPEN'", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbMealplan.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbMealplan.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadTopName(ByVal topcode As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Passtopcode As String = topcode

            dcSearch = New SqlCommand("select TopName from [Touroperator.Master] where  TopCode=@Passtopcode", Conn)
            dcSearch.Parameters.Add("@PASSTOPCODE", SqlDbType.NVarChar).Value = Passtopcode

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            CbTop.Text = dsMain.Tables(0).Rows(0)(0).ToString()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub DtResdate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtResdate.EditValueChanged

        If PubIsEdit = "EDIT" Then
            Exit Sub
        Else
            If (DtToday.DateTime.Date > DtResdate.DateTime.Date) Then
                MessageBox.Show("You Can not do reservation for backed dates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                txtGuesname.Enabled = False

                Exit Sub
            Else
                gbBookingtype.Enabled = True

                txtArrMonth.Text = DtResdate.DateTime.Date.Month
                txtArrDay.Text = DtResdate.DateTime.Date.Day
                txtArryear.Text = DtResdate.DateTime.Date.Year

                ' DtArrival.Text = DtResdate.DateTime.Date
                txtGuesname.Enabled = True

            End If
        End If

    End Sub
    Private Sub DtArrival_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtArrival.EditValueChanged
        'If (DtResdate.DateTime.Date > DtArrival.DateTime.Date) Then
        '    MessageBox.Show("Guest arrival date should be greater than reservation date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'Else
        '    DtDep.Enabled = True
        '    cmbDepFlight.Enabled = True
        '    cmbArriFlight.Properties.Items.Clear()
        '    LoadFlightArrival()
        'End If
        'DtResdate.Text = DtArrival.DateTime.Date
        'LoadDiscounts()
    End Sub

    Private Sub ArriDateChange()

        'If PubIsEdit = "EDIT" Then
        '    Exit Sub
        'Else

        ' Dim getArrdate As Date = Convert.ToDateTime(txtArrMonth.Text + "/" + txtArrDay.Text + "/" + txtArryear.Text)

        Dim getArrdate As Date = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)


        'If (DtResdate.DateTime.Date > DtArrival.DateTime.Date) Then
        If (DtResdate.DateTime.Date > getArrdate) Then
            MessageBox.Show("Guest arrival date should be greater than reservation date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            'DtDep.Enabled = True
            cmbDepFlight.Enabled = True
            cmbArriFlight.Properties.Items.Clear()
            LoadFlightArrival(getArrdate)
        End If
        DtResdate.Text = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)
        LoadDiscounts()
        'End If


    End Sub

    Private Sub DtDep_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtDep.EditValueChanged

        'If IsDate(DtDep.Text) = False Then
        '    Exit Sub
        'End If

        'If (DtArrival.DateTime.Date > DtDep.DateTime.Date) Then
        '    MessageBox.Show("Guest departure date should be greater than arrival date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'Else

        '    cmbDepFlight.Properties.Items.Clear()
        '    LoadFlightDeparture()

        '    gbPax1.Enabled = True

        'End If
    End Sub
    Private Sub DepDateChange()
        ' If IsDate(DtDep.Text) = False Then

        Dim getDepdate2 As Date = Convert.ToDateTime(txtDepyear.Text + "/" + txtDepMonth.Text + "/" + txtDepDay.Text)

        If IsDate(getDepdate2) = False Then
            Exit Sub
        End If

        Dim getArrdate As Date = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)

        Dim getDepdate As Date = Convert.ToDateTime(txtDepyear.Text + "/" + txtDepMonth.Text + "/" + txtDepDay.Text)




        'If (DtArrival.DateTime.Date > DtDep.DateTime.Date) Then
        If (getArrdate.Date > getDepdate.Date) Then
            MessageBox.Show("Guest departure date should be greater than arrival date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            cmbDepFlight.Properties.Items.Clear()
            LoadFlightDeparture()



            If CheckPerformaCreated() = False Then

                gbPax1.Enabled = True


            End If


            End If
    End Sub
    Private Sub LoadFlightArrival(ByVal grtdate As Date)
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()



            'Dim GetcmbGridDay As String = DtArrival.DateTime.DayOfWeek.ToString

            Dim GetcmbGridDay As String = grtdate.Date.DayOfWeek.ToString

            dcSearch = New SqlCommand("select FlightNo from dbo.[FlightSchedule.Master] where Day=@Day and Type='Arrival' and Status='OPEN' order by FlightNo", Conn)
            dcSearch.Parameters.Add("@Day", SqlDbType.VarChar).Value = GetcmbGridDay

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer


            If Dscount <= 0 Then
                MessageBox.Show("There is no arrival flights scheduled in the system", "Arrival Flights", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End If

            While (DscountTest < Dscount)

                cmbArriFlight.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            'cmbArriFlight.SelectedIndex = 0


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadFlightArrivalTime()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim getArrdate As Date = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)

            'Dim GetcmbGridDay As String = DtArrival.DateTime.DayOfWeek.ToString
            Dim GetcmbGridDay As String = getArrdate.DayOfWeek.ToString
            Dim GetFlightno As String = cmbArriFlight.Text.Trim

            dcSearch = New SqlCommand("select convert(char(5),ScheduleTime, 108) [Time] from dbo.[FlightSchedule.Master] where Day=@Day and Type='Arrival' and Status='OPEN' and FlightNo=@Flightno order by FlightNo", Conn)
            dcSearch.Parameters.Add("@Day", SqlDbType.VarChar).Value = GetcmbGridDay
            dcSearch.Parameters.Add("@Flightno", SqlDbType.VarChar).Value = GetFlightno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim getarrtime As String = dsMain.Tables(0).Rows(0)(0).ToString

            If dsMain.Tables(0).Rows.Count > 0 Then

                txtArrTime.Text = dsMain.Tables(0).Rows(0)(0)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadFlightDeparture()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            Dim getDepdate As Date = Convert.ToDateTime(txtDepyear.Text + "/" + txtDepMonth.Text + "/" + txtDepDay.Text)


            Dim GetcmbGridDay As String = getDepdate.DayOfWeek.ToString

            dcSearch = New SqlCommand("select FlightNo from dbo.[FlightSchedule.Master] where Day=@Day and Type='Departure' and Status='OPEN' order by FlightNo", Conn)
            dcSearch.Parameters.Add("@Day", SqlDbType.VarChar).Value = GetcmbGridDay

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer


            If Dscount <= 0 Then

                MessageBox.Show("There is no departure flights scheduled in the system", "Arrival Flights", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End If

            While (DscountTest < Dscount)
                cmbDepFlight.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While

            'cmbDepFlight.SelectedIndex = 0


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadFlightDepTime()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()



            Dim getDepdate As Date = Convert.ToDateTime(txtDepyear.Text + "/" + txtDepMonth.Text + "/" + txtDepDay.Text)
            Dim GetcmbGridDay As String = getDepdate.DayOfWeek.ToString

            Dim GetFlightno As String = cmbDepFlight.Text.Trim

            dcSearch = New SqlCommand("select convert(char(5),ScheduleTime, 108) [Time]  from dbo.[FlightSchedule.Master] where Day=@Day and Type='Departure' and Status='OPEN' and FlightNo=@Flightno order by FlightNo", Conn)
            dcSearch.Parameters.Add("@Day", SqlDbType.VarChar).Value = GetcmbGridDay
            dcSearch.Parameters.Add("@Flightno", SqlDbType.VarChar).Value = GetFlightno

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            If dsMain.Tables(0).Rows.Count > 0 Then

                txtDepTime.Text = dsMain.Tables(0).Rows(0)(0)

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Reservation", "Add")

        If CheckAccess = True Then


            'cmbArrType.SelectedIndex = 0
            'cmbDepType.SelectedIndex = 0


            'Me.txtGuesname.SelectionStart = True
            'txtGuesname.Select()



            If String.Compare(btAdd.Text, "&Add", False) = 0 Then

                ClearFields()
                btAdd.Text = "Save"
                btEdit.Enabled = False
                btDel.Enabled = False
                btApprove.Enabled = False
                tabReservation.TabPages(1).PageEnabled = True
                tabReservation.SelectedTabPageIndex = 1

                txtGuesname.Focus()

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                Else
                    Dim dscheckAddbefore As New DataSet
                    dscheckAddbefore = DSCheckInsertResRoom()

                    Dim dscheckResAddbefore As New DataSet
                    dscheckResAddbefore = DSCheckInsertResMaster()

                    If dscheckAddbefore Is Nothing Or dscheckResAddbefore Is Nothing Then

                        Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Reservation Details", "Save Reservation Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


                        If bt = Windows.Forms.DialogResult.Yes Then

                            InsertResRoomCount()
                            InsertReservationMaster()
                            DeleteTempRoomCount(txtReservationno.Text.Trim)



                            cmbArrType.SelectedIndex = 0
                            cmbDepType.SelectedIndex = 0

                        End If
                    Else
                        MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If

                    LoadGrid()

                    btAdd.Text = "&Add"
                    btEdit.Enabled = True
                    btDel.Enabled = True
                    btApprove.Enabled = True
                    tabReservation.TabPages(1).PageEnabled = False
                    tabReservation.SelectedTabPageIndex = 0

                    gbpax2.Enabled = False
                    gbpayment.Enabled = False
                    gbOthers.Enabled = False
                    Exit Sub
                End If
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Private Sub txtRoomcount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRoomcount.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtadultcount_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtadultcount.EditValueChanged, txtchildcount.EditValueChanged, txtinfantcount.EditValueChanged
        ' txtcounttot.Text = Convert.ToInt16(txtadultcount.Text) + Convert.ToInt16(txtchildcount.Text) + Convert.ToInt16(txtinfantcount.Text)
        txtcounttot.Text = IIf(String.IsNullOrEmpty(txtadultcount.Text), 0, Val(txtadultcount.Text)) + IIf(String.IsNullOrEmpty(txtchildcount.Text), 0, Val(txtchildcount.Text)) + IIf(String.IsNullOrEmpty(txtinfantcount.Text), 0, Val(txtinfantcount.Text))
        totPaxrooms.Text = IIf(String.IsNullOrEmpty(txtadultcount.Text), 0, Val(txtadultcount.Text)) + IIf(String.IsNullOrEmpty(txtchildcount.Text), 0, Val(txtchildcount.Text)) + IIf(String.IsNullOrEmpty(txtinfantcount.Text), 0, Val(txtinfantcount.Text))

    End Sub
    Private Sub txtadultcount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtadultcount.KeyPress

        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtchildcount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchildcount.KeyPress

        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtinfantcount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtinfantcount.KeyPress

        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub CbFit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbFit.CheckedChanged
        If CbFit.Checked = True Then
            CbCompl.Checked = False
            CbTop.Checked = False
            ' gbArridep.Enabled = True
            PubResType = "RATEFIT"

        End If
    End Sub
    Private Sub CbCompl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbCompl.CheckedChanged
        If CbCompl.Checked = True Then
            CbFit.Checked = False
            CbTop.Checked = False
            ' gbArridep.Enabled = True
            PubResType = "RATEFIT"
        End If
    End Sub
    Private Sub CbTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTop.CheckedChanged
        If CbTop.Checked = True Then
            CbFit.Checked = False
            CbCompl.Checked = False
            cbTopcode.Enabled = True
            'gbArridep.Enabled = True
            PubResType = "RATECON"
            cbTopcode.Focus()

            cbTopcode.EditValue = "Maldiviana Tours"
            ' cbTopcode.ShowPopup()

        End If
    End Sub
    Private Sub InsertResRoomCountTemp()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()

        Dim Restype As String = ""



        If CbTop.Checked = True Then
            Restype = "TOP"
        End If

        If CbCompl.Checked = True Then
            Restype = "COM"
        End If

        If CbFit.Checked = True Then
            Restype = "FIT"
        End If

        Dim CurrentUser As String = CurrUser
        dcInsertNewAcc = New SqlCommand("InsertResRoomTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

        dcInsertNewAcc.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = txtReservationno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ReservationDate", SqlDbType.DateTime).Value = DtResdate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@ReservationType", SqlDbType.VarChar).Value = Restype
        dcInsertNewAcc.Parameters.Add("@Room", SqlDbType.VarChar).Value = cmbRoom.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Roomtype", SqlDbType.VarChar).Value = cmbRoomtyp.Text.Trim
        dcInsertNewAcc.Parameters.Add("@RoomCount", SqlDbType.Int).Value = Convert.ToInt16(txtRoomcount.Text.Trim)
        dcInsertNewAcc.Parameters.Add("@BedNights", SqlDbType.Int).Value = Convert.ToInt16(txtBednights.Text.Trim)
        dcInsertNewAcc.Parameters.Add("@TotPax", SqlDbType.Int).Value = Convert.ToInt16(totPaxrooms.Text.Trim)
        dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Sub cmbDepFlight_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepFlight.SelectedIndexChanged
        LoadFlightDepTime()
        gbPax.Enabled = True
    End Sub
    Private Sub cmbAmmenties_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gbpayment.Enabled = True
        gbOthers.Enabled = True
    End Sub
    Function DSCheckAddRoomTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim CurrentUser As String = CurrUser
            Dim ReservationNo As String = txtReservationno.Text.Trim
            Dim Room As String = cmbRoom.Text
            Dim Roomtype As String = cmbRoomtyp.Text
            Dim Createdby As String = CurrentUser

            dcSearch = New SqlCommand("select * from dbo.[Reservation.Room.Temp] where ReservationNo=@ReservationNo and Room=@Room and Roomtype=@Roomtype and Createdby=@Createdby", Conn)
            dcSearch.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = ReservationNo
            dcSearch.Parameters.Add("@Room", SqlDbType.VarChar).Value = Room
            dcSearch.Parameters.Add("@Roomtype", SqlDbType.VarChar).Value = Roomtype
            dcSearch.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = Createdby

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckAddRoomTemp = dsMain
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
    Function DSCheckAddResRoomMaster() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim ReservationNo As String = txtReservationno.Text.Trim
            dcSearch = New SqlCommand("select * from dbo.[Reservation.Room] where ReservationNo=@ReservationNo", Conn)
            dcSearch.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = ReservationNo


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            'Dim count As Integer = dsMain.Tables(0).Rows.Count
            'If count > 0 Then
            DSCheckAddResRoomMaster = dsMain


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
    Private Sub btAddRoomcount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddRoomcount.Click

        Try



            DtResdate.Text = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)


            If FieldValidationRooms() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

            Else

                GetBedNigts()
                txtRate.Text = ""
                txtTotal.Text = ""
                gbpax2.Enabled = True


                If PubDoEdit = 1 Then

                    Dim dscheckRoomAddbefore As New DataSet
                    dscheckRoomAddbefore = DSCheckAddResRoomMaster()

                    If dscheckRoomAddbefore.Tables(0) Is DBNull.Value Then
                        Exit Sub
                    Else
                        If dscheckRoomAddbefore.Tables(0).Rows.Count > 0 Then

                            Dim dsLoadMasPaX As New DataSet
                            dsLoadMasPaX = DSGetPaxDetails(txtReservationno.Text.Trim)
                            DeleteResRoomCount(txtReservationno.Text.Trim)

                        End If
                    End If

                End If


                'Dim dsCheckRoomcountType As New DataSet
                'Dim dsCheckRoomcountRes As New DataSet
                'Dim RoomCountRes As Integer = 0
                'Dim RoomCountType As Integer = 0



                'dsCheckRoomcountType = GetRoomCountByType()
                'dsCheckRoomcountRes = GetRoomCountByReservation()


                'If dsCheckRoomcountRes Is Nothing Then

                '    RoomCountRes = 0

                'Else

                '    If dsCheckRoomcountRes.Tables(0).Rows(0)(0) Is DBNull.Value Then
                '        RoomCountRes = 0
                '    Else
                '        RoomCountRes = Convert.ToInt16(dsCheckRoomcountRes.Tables(0).Rows(0)(0))
                '    End If

                'End If


                'If dsCheckRoomcountType Is Nothing Then
                '    RoomCountType = 0

                'Else

                '    If dsCheckRoomcountType.Tables(0).Rows(0)(0) Is DBNull.Value Then
                '        RoomCountType = 0

                '    Else
                '        RoomCountType = Convert.ToInt16(dsCheckRoomcountType.Tables(0).Rows(0)(0))

                '    End If

                'End If


                'Dim BalanceRoomcout As Integer = RoomCountType - RoomCountRes

                'If RoomCountType = 0 Then

                '    MessageBox.Show("Selected Room Is Not Configured In The System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '    Exit Sub

                'Else
                '    If RoomCountType <= RoomCountRes Then
                '        MessageBox.Show("Selected Room Is  Not Available For Reservation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '        Exit Sub
                '    Else
                '        If BalanceRoomcout >= Convert.ToInt16(txtRoomcount.Text.Trim) Then
                '            CheckResRoomDetails()
                '        Else
                '            MessageBox.Show("No Of Rooms Can Not Exceed The No Of Free Rooms", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '            Exit Sub
                '        End If

                '    End If
                'End If

                CheckResRoomDetails()
                btGetrate.Focus()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            'dsCheckRoomcountType.Dispose()
            'dsCheckRoomcountRes.Dispose()
        End Try
    End Sub
    Private Sub txtGuesname_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtGuesname.EditValueChanging
        gbBookingtype.Enabled = True
        'DtResdate.Enabled = False
    End Sub
    Private Sub LoadResRoomDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Resno As String = txtReservationno.Text.Trim


            dcSearch = New SqlCommand("select Room,Roomtype,RoomCount,TotPax  from dbo.[Reservation.Room.Temp] where ReservationNo=@Resno order by Room", Conn)
            dcSearch.Parameters.Add("@Resno", SqlDbType.NVarChar).Value = Resno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            gcRoomcount.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Function DSContractDetailsTopWise() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim TopId As String = cbTopcode.GetColumnValue("TopCode")

            dcSearch = New SqlCommand("select * from  dbo.[Touroperator.Contracts] where TopId=@TopId and Iscurrent='1' and Isinactive=0", Conn)
            dcSearch.Parameters.Add("@TopId", SqlDbType.VarChar).Value = TopId

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSContractDetailsTopWise = dsMain
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
    Function DSLoadRoomRatesContracts(ByVal ValTopId As String, ByVal ValResDate As DateTime, ByVal ValRoom As String, ByVal ValPackage As String, ByVal ValRoomType As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Dim getPackage As String = ""
        Try
            Conn.Open()
            Dim TopId As String = ValTopId
            Dim ResDate As DateTime = ValResDate
            Dim Room As String = ValRoom
            Dim Package As String = ValPackage
            Dim RoomType As String = ValRoomType

            If Package = "AI" Then
                getPackage = "FB"
            Else
                getPackage = Package
            End If

            dcSearch = New SqlCommand("SelectContractDetailRes_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcSearch.Parameters.Add("@Topid", SqlDbType.VarChar).Value = TopId
            dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = ResDate
            dcSearch.Parameters.Add("@RoomType", SqlDbType.VarChar).Value = Room
            dcSearch.Parameters.Add("@Packagetype", SqlDbType.VarChar).Value = getPackage
            dcSearch.Parameters.Add("@Countype", SqlDbType.VarChar).Value = RoomType

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSLoadRoomRatesContracts = dsMain
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
    Function DSLoadRoomRatesFits(ByVal ValResDate As DateTime, ByVal ValRoom As String, ByVal ValPackage As String, ByVal ValRoomType As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim getCusType As String = ""
            Dim getPackage As String = ""


            If CbFit.Checked = True Then
                getCusType = "FIT"
            End If
            If CbCompl.Checked = True Then
                getCusType = "COM"
            End If

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
    Function DSLoadRoomRatesTopNonContracts(ByVal ValResDate As DateTime, ByVal ValRoom As String, ByVal ValPackage As String, ByVal ValRoomType As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim getCusType As String = ""
            If CbTop.Checked = True Then
                getCusType = "TOPNONCONTRACT"
            End If


            Dim ResDate As DateTime = ValResDate
            Dim Room As String = ValRoom
            Dim Package As String = ValPackage
            Dim RoomType As String = ValRoomType

            dcSearch = New SqlCommand("SelectContractDetailResFit_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcSearch.Parameters.Add("@CusType", SqlDbType.VarChar).Value = getCusType
            dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = ResDate
            dcSearch.Parameters.Add("@RoomType", SqlDbType.VarChar).Value = Room
            dcSearch.Parameters.Add("@Packagetype", SqlDbType.VarChar).Value = Package
            dcSearch.Parameters.Add("@Countype", SqlDbType.VarChar).Value = RoomType

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSLoadRoomRatesTopNonContracts = dsMain
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
    Private Sub CheckResRoomDetails()


        'If PubResType = "RATECON" Then

        '    Dim dscheckAddbefore As New DataSet
        '    dscheckAddbefore = DSLoadRoomRatesContracts(cbTopcode.GetColumnValue("TopCode"), DtResdate.DateTime.Date, cmbRoom.Text.Trim, cmbMealplan.Text.Trim, cmbRoomtyp.Text.Trim)

        '    If dscheckAddbefore Is Nothing Then
        '        MessageBox.Show("Error On Contracts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Else

        '        'Dim AllocateRoom As Integer = Convert.ToInt16(dscheckAddbefore.Tables(0).Rows(0)(6).ToString)
        '        'Dim BalanceRoom As Integer = Convert.ToInt16(dscheckAddbefore.Tables(0).Rows(0)(7).ToString)

        '        'If BalanceRoom = 0 Then
        '        '    MessageBox.Show("All Rooms Are Allocated For This Operator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '        'End If

        '        'If BalanceRoom <= AllocateRoom Then
        '        '    If BalanceRoom >= Convert.ToInt16(txtRoomcount.Text.Trim) Then
        '        Dim dscheckRoomAddbefore As New DataSet
        '        dscheckRoomAddbefore = DSCheckAddRoomTemp()

        '        If dscheckRoomAddbefore Is Nothing Then
        '            InsertResRoomCountTemp()
        '            LoadResRoomDetails()
        '            gbpax2.Enabled = True
        '        Else
        '            MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '        End If

        '        '            Else
        '        '        MessageBox.Show("You Can Not Exceed The Balance Room Count", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '        '    End If
        '        'End If
        '    End If

        'Else

        Dim dscheckRoomAddbefore As New DataSet
        dscheckRoomAddbefore = DSCheckAddRoomTemp()

        If dscheckRoomAddbefore Is Nothing Then
            InsertResRoomCountTemp()
            LoadResRoomDetails()
            gbpax2.Enabled = True
        Else

            MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If
        'End If

    End Sub
    Private Sub LoadDiscounts()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try


            If CbTop.Checked = True Then

                ' Dim ResDate As DateTime = DtResdate.DateTime.Date

                Dim ResDate As DateTime = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)
                Conn.Open()
                dcSearch = New SqlCommand("SELECT dbo.[Discounts.Master].DisID, dbo.[Discounts.Master].DisPlan, dbo.[Discounts.Master].DisAmt FROM dbo.[Discounts.Master] INNER JOIN dbo.[Discounts.Detail] ON dbo.[Discounts.Master].SelectiveDetailId = dbo.[Discounts.Detail].DisId where dbo.[Discounts.Master].Selective=1 AND Status='OPEN' and Applicable='TOP' AND  dbo.[Discounts.Detail].TopCode=@Topcode  and (dbo.[Discounts.Master].DisSDate <= @ResDate) AND (dbo.[Discounts.Master].DisEDate >= @ResDate) order by DisID", Conn)
                dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = ResDate
                dcSearch.Parameters.Add("@Topcode", SqlDbType.VarChar).Value = cbTopcode.GetColumnValue("TopCode")

                daMain = New SqlDataAdapter()
                daMain.SelectCommand = dcSearch
                daMain.Fill(dsMain)

                Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
                'Dim DscountTest As Integer


                With cmbDisscounts.Properties
                    .DataSource = dsMain.Tables(0)
                    .DisplayMember = "DisPlan"
                    .ValueMember = "DisID"
                    .Columns(0).Width = 100
                    .Columns(1).Width = 150
                    .PopupWidth = 400
                    .AutoSearchColumnIndex = 1
                    .TextEditStyle = True

                End With
            End If



            If CbCompl.Checked = True Then

                Dim ResDate As DateTime = DtResdate.DateTime.Date
                Conn.Open()
                dcSearch = New SqlCommand("select dbo.[Discounts.Master].DisID,dbo.[Discounts.Master].DisPlan,dbo.[Discounts.Master].DisAmt from dbo.[Discounts.Master] where Status='OPEN' and Applicable='COM' OR Applicable='ALL' and (dbo.[Discounts.Master].DisSDate <= @ResDate) AND (dbo.[Discounts.Master].DisEDate >= @ResDate) order by DisID", Conn)
                dcSearch.Parameters.Add("@ResDate", SqlDbType.VarChar).Value = ResDate

                daMain = New SqlDataAdapter()
                daMain.SelectCommand = dcSearch
                daMain.Fill(dsMain)

                Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
                'Dim DscountTest As Integer


                With cmbDisscounts.Properties
                    .DataSource = dsMain.Tables(0)
                    .DisplayMember = "DisPlan"
                    .ValueMember = "DisID"
                    .Columns(0).Width = 100
                    .Columns(1).Width = 150
                    .PopupWidth = 400
                    .AutoSearchColumnIndex = 1
                    .TextEditStyle = True

                End With
            End If

            If CbFit.Checked = True Then

                Dim ResDate As DateTime = DtResdate.DateTime.Date
                Conn.Open()
                dcSearch = New SqlCommand("select dbo.[Discounts.Master].DisID,dbo.[Discounts.Master].DisPlan,dbo.[Discounts.Master].DisAmt from dbo.[Discounts.Master] where Status='OPEN' and Applicable='FIT' OR Applicable='ALL' and (dbo.[Discounts.Master].DisSDate <= @ResDate) AND (dbo.[Discounts.Master].DisEDate >= @ResDate) order by DisID", Conn)
                dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = ResDate

                daMain = New SqlDataAdapter()
                daMain.SelectCommand = dcSearch
                daMain.Fill(dsMain)

                Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
                'Dim DscountTest As Integer


                With cmbDisscounts.Properties
                    .DataSource = dsMain.Tables(0)
                    .DisplayMember = "DisPlan"
                    .ValueMember = "DisID"
                    .Columns(0).Width = 100
                    .Columns(1).Width = 150
                    .PopupWidth = 400
                    .AutoSearchColumnIndex = 1
                    .TextEditStyle = True

                End With
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadDiscountsTopALL()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try

            If CbTop.Checked = True Then

                Dim ResDate As DateTime = DtResdate.DateTime.Date
                Conn.Open()
                dcSearch = New SqlCommand("SELECT dbo.[Discounts.Master].DisID, dbo.[Discounts.Master].DisPlan, dbo.[Discounts.Master].DisAmt FROM dbo.[Discounts.Master] where   dbo.[Discounts.Master].Selective=0 AND Status='OPEN' and Applicable='TOP' and Credit=1 and Prepaid=1 and Others=1 and (dbo.[Discounts.Master].DisSDate <= @ResDate) AND (dbo.[Discounts.Master].DisEDate >= @ResDate) order by DisID", Conn)
                dcSearch.Parameters.Add("@ResDate", SqlDbType.VarChar).Value = ResDate

                daMain = New SqlDataAdapter()
                daMain.SelectCommand = dcSearch
                daMain.Fill(dsMain)

                Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
                'Dim DscountTest As Integer


                With cmbDisscounts.Properties
                    .DataSource = dsMain.Tables(0)
                    .DisplayMember = "DisPlan"
                    .ValueMember = "DisID"
                    .Columns(0).Width = 100
                    .Columns(1).Width = 150
                    .PopupWidth = 400
                    .AutoSearchColumnIndex = 1
                    .TextEditStyle = True

                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadOffers()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim ResDate As DateTime = DtResdate.DateTime.Date
            Conn.Open()
            dcSearch = New SqlCommand("select dbo.[Offers.Master].OfferID,dbo.[Offers.Master].OfferName from dbo.[Offers.Master] where Status='OPEN' and (dbo.[Offers.Master].OfferSDate <= @ResDate) AND (dbo.[Offers.Master].OfferEDate >= @ResDate) order by OfferID", Conn)
            dcSearch.Parameters.Add("@ResDate", SqlDbType.VarChar).Value = ResDate

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            'Dim DscountTest As Integer


            With cmbOffers.Properties
                .DataSource = dsMain.Tables(0)
                .DisplayMember = "OfferName"
                .ValueMember = "OfferID"
                .Columns(0).Width = 100
                .Columns(1).Width = 150
                .PopupWidth = 400

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadDiscountById(ByVal getdisid As Integer)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim DiscountId As Integer = getdisid
            Conn.Open()
            dcSearch = New SqlCommand("select dbo.[Discounts.Master].DisID, dbo.[Discounts.Master].DisPlan, dbo.[Discounts.Master].DisAmt from dbo.[Discounts.Master] where dbo.[Discounts.Master].DisID=@DiscountID", Conn)
            dcSearch.Parameters.Add("@DiscountID", SqlDbType.Int).Value = DiscountId

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            'Dim DscountTest As Integer
            cmbDisscounts.EditValue = dsMain.Tables(0).Rows(0)(1)
            'cmbDisscounts.ClosePopup()

            With cmbDisscounts.Properties
                .DataSource = dsMain.Tables(0)
                .DisplayMember = "DisPlan"
                .ValueMember = "DisID"
                .Columns(0).Width = 100
                .Columns(1).Width = 150
                .PopupWidth = 400

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadAmentites()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Conn.Open()
            dcSearch = New SqlCommand("select dbo.[Amentities.Master].AmentitiesID,dbo.[Amentities.Master].AmentitiesName  from dbo.[Amentities.Master] where Status='OPEN' order by AmentitiesID", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            'Dim DscountTest As Integer

            'While (DscountTest < Dscount)

            '    cmbAmmenties1.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
            '    DscountTest = DscountTest + 1

            'End While

            'cmbAmmenties1.SelectedIndex = 0

            With cmbAmmenties.Properties
                .DataSource = dsMain.Tables(0)
                .DisplayMember = "AmentitiesName"
                .ValueMember = "AmentitiesID"
                .Columns(0).Width = 100
                .Columns(1).Width = 150
                .PopupWidth = 400

            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadAmentitesById(ByVal getAmenID As Integer)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim AmenID As Integer = getAmenID

            Conn.Open()
            dcSearch = New SqlCommand("select dbo.[Amentities.Master].AmentitiesID,dbo.[Amentities.Master].AmentitiesName  from dbo.[Amentities.Master] where AmentitiesID=@AmenID", Conn)
            dcSearch.Parameters.Add("@AmenID", SqlDbType.Int).Value = AmenID

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            'Dim DscountTest As Integer

            'While (DscountTest < Dscount)

            '    cmbAmmenties1.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
            '    DscountTest = DscountTest + 1

            'End While

            'cmbAmmenties1.SelectedIndex = 0
            cmbAmmenties.Text = dsMain.Tables(0).Rows(0)(1).ToString
            'cmbAmmenties.ClosePopup()

            With cmbAmmenties.Properties
                .DataSource = dsMain.Tables(0)
                .DisplayMember = "AmentitiesName"
                .ValueMember = "AmentitiesID"
                .Columns(0).Width = 100
                .Columns(1).Width = 150
                .PopupWidth = 400

            End With



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub btGetrate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGetrate.Click


        If PubDoEdit = 1 Then

            If CbFit.Checked = True Then
                PubResType = "RATEFIT"
            End If


            If CbCompl.Checked = True Then
                PubResType = "RATEFIT"
            End If

            If CbTop.Checked = True Then
                PubResType = "RATECON"
            End If


            If PubResType = "RATECON" Then

                PubContractId = ""

                Dim dscheckAddbefore As New DataSet
                dscheckAddbefore = DSContractDetailsTopWise()

                If dscheckAddbefore Is Nothing Then
                    PubResType = "RATENOCON"

                Else

                    PubResType = "RATECON"
                    PubIscontract = 1

                    Dim ConSDate As DateTime = Convert.ToDateTime(dscheckAddbefore.Tables(0).Rows(0)(4).ToString)
                    Dim ConEDate As DateTime = Convert.ToDateTime(dscheckAddbefore.Tables(0).Rows(0)(5).ToString)
                    PubContractId = dscheckAddbefore.Tables(0).Rows(0)(0).ToString

                End If

            End If

        End If


        txtRate.Text = ""
        txtTotal.Text = ""

        Dim dsgetRoomCount As New DataSet
        dsgetRoomCount = DSGetRoomTempDetails()

        If dsgetRoomCount Is Nothing Then

            MessageBox.Show("You Have To Select Room Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        gbpayment.Enabled = True
        gbOthers.Enabled = True

        '-------------------------------------------------------------------------------------------------------------------

        If dsgetRoomCount.Tables(0).Rows.Count = 1 Then

            If PubResType = "RATECON" Then

                Dim Gettotbednights As Integer = Convert.ToInt16(txtBednights.Text.Trim) - 1
                Dim TotRatePerContract As Decimal
                Dim GrandTotRatePerContract As Decimal
                Dim GetResDateInc As Integer = 0
                Dim GetResDate As DateTime = DtResdate.DateTime.Date

                While Gettotbednights >= 0

                    Dim dsGetContractRate As New DataSet
                    ' dsGetContractRate = DSLoadRoomRatesContracts(cbTopcode.GetColumnValue("TopCode"), DtResdate.DateTime.Date, cmbRoom.Text.Trim, cmbMealplan.Text.Trim, cmbRoomtyp.Text.Trim)
                    dsGetContractRate = DSLoadRoomRatesContracts(cbTopcode.GetColumnValue("TopCode"), DateAdd(DateInterval.Day, +GetResDateInc, GetResDate), cmbRoom.Text.Trim, cmbMealplan.Text.Trim, cmbRoomtyp.Text.Trim)

                    If dsGetContractRate Is Nothing Then
                        MessageBox.Show("Rates are not defined for this Contracts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        txtRate.Text = "0.00"
                        txtTotal.Text = "0.00"

                        Exit While
                    Else

                        'If txtchildcount.Text.Trim = "" Then
                        '    txtchildcount.Text = "0"

                        'End If

                        Dim getchildqty As Integer = Convert.ToInt16(txtchildcount.Text.Trim)

                        Dim RatePerContract As Decimal = Convert.ToDecimal(dsGetContractRate.Tables(0).Rows(0)(8).ToString)


                        If getchildqty > 0 Then

                            Dim Chilldqty As Integer = getchildqty

                            Dim DSRoomRatesChild As New DataSet
                            DSRoomRatesChild = DSLoadRoomRatesContracts(cbTopcode.GetColumnValue("TopCode"), DateAdd(DateInterval.Day, +GetResDateInc, GetResDate), cmbRoom.Text.Trim, cmbMealplan.Text.Trim, "Child")

                            If DSRoomRatesChild.Tables(0).Rows.Count > 0 Then

                                TotRatePerContract = RatePerContract * Convert.ToInt16(totPaxrooms.Text.Trim)
                                Dim ChildRate As Decimal = Convert.ToDecimal(DSRoomRatesChild.Tables(0).Rows(0)(8)) * Chilldqty

                                Dim NewAdultRate As Decimal = (TotRatePerContract / Convert.ToInt16(totPaxrooms.Text.Trim))
                                Dim NewCalRoomRate As Decimal = NewAdultRate * (Convert.ToInt16(totPaxrooms.Text.Trim) - Chilldqty) + ChildRate

                                TotRatePerContract = NewCalRoomRate

                            End If



                        Else

                            TotRatePerContract = RatePerContract * Convert.ToInt16(totPaxrooms.Text.Trim)

                        End If





                        GrandTotRatePerContract = GrandTotRatePerContract + TotRatePerContract

                    End If
                    Gettotbednights = Gettotbednights - 1
                    GetResDateInc = GetResDateInc + 1

                End While

                Dim GrantTotalAI As Decimal = 0

                If cmbMealplan.Text.Trim = "AI" Then

                    Dim getAdultcount As Integer = 0
                    Dim getChildcount As Integer = 0
                    Dim getInfantscount As Integer = 0


                    Dim GrantTotaAd As Decimal = 0
                    Dim GrantTotalChd As Decimal = 0
                    Dim GrantTotalInfants As Decimal = 0


                    Dim bednights As Integer = Convert.ToInt16(txtBednights.Text.Trim)

                    Dim dsgetAllInclusive As New DataSet


                    If txtadultcount.Text.Trim = "" Then
                        getAdultcount = 0

                    Else
                        getAdultcount = Convert.ToInt16(txtadultcount.Text.Trim)
                        dsgetAllInclusive = DSLoadAllInclusiveContracts(cbTopcode.GetColumnValue("TopCode"), "Adults")
                        GrantTotaAd = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getAdultcount * bednights
                        GrantTotalAI = GrantTotalAI + GrantTotaAd
                    End If


                    If txtchildcount.Text.Trim = "" Then
                        getChildcount = 0

                    Else
                        getChildcount = Convert.ToInt16(txtchildcount.Text.Trim)
                        dsgetAllInclusive = DSLoadAllInclusiveContracts(cbTopcode.GetColumnValue("TopCode"), "Children")
                        GrantTotalChd = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getChildcount * bednights
                        GrantTotalAI = GrantTotalAI + GrantTotalChd

                    End If


                    If txtinfantcount.Text.Trim = "" Then
                        getInfantscount = 0

                    Else

                        getInfantscount = Convert.ToInt16(txtinfantcount.Text.Trim)
                        dsgetAllInclusive = DSLoadAllInclusiveContracts(cbTopcode.GetColumnValue("TopCode"), "Infants")
                        GrantTotalInfants = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getInfantscount * bednights
                        GrantTotalAI = GrantTotalAI + GrantTotalInfants

                    End If
                End If

                txtRate.Text = GrandTotRatePerContract + GrantTotalAI
                txtTotal.Text = GrandTotRatePerContract + GrantTotalAI

            End If


            If PubResType = "RATEFIT" Then

                Dim Gettotbednights As Integer = Convert.ToInt16(txtBednights.Text.Trim) - 1
                Dim TotRatePerContract3 As Decimal
                Dim GrandTotRatePerContract As Decimal
                Dim GetResDateInc As Integer = 0
                Dim GetResDate As DateTime = DtResdate.DateTime.Date

                While Gettotbednights >= 0

                    Dim dsGetContractRateFit As New DataSet
                    'dsGetContractRateFit = DSLoadRoomRatesFits(DtResdate.DateTime.Date, cmbRoom.Text.Trim, cmbMealplan.Text.Trim, cmbRoomtyp.Text.Trim)
                    dsGetContractRateFit = DSLoadRoomRatesFits(DateAdd(DateInterval.Day, +GetResDateInc, GetResDate), cmbRoom.Text.Trim, cmbMealplan.Text.Trim, cmbRoomtyp.Text.Trim)

                    If dsGetContractRateFit Is Nothing Then
                        MessageBox.Show("Rates are not defined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        txtRate.Text = "0.00"
                        txtTotal.Text = "0.00"
                        Exit While
                    Else

                        Dim RatePerContract As Decimal = Convert.ToDecimal(dsGetContractRateFit.Tables(0).Rows(0)(10).ToString)
                        ' TotRatePerContract3 = RatePerContract * Convert.ToInt16(txtRoomcount.Text.Trim) * Convert.ToInt16(totPaxrooms.Text.Trim)
                        TotRatePerContract3 = RatePerContract * Convert.ToInt16(totPaxrooms.Text.Trim)

                        GrandTotRatePerContract = GrandTotRatePerContract + TotRatePerContract3


                    End If
                    Gettotbednights = Gettotbednights - 1
                    GetResDateInc = GetResDateInc + 1

                End While



                Dim GrantTotalAI As Decimal = 0

                If cmbMealplan.Text.Trim = "AI" Then

                    Dim getAdultcount As Integer = 0
                    Dim getChildcount As Integer = 0
                    Dim getInfantscount As Integer = 0


                    Dim GrantTotaAd As Decimal = 0
                    Dim GrantTotalChd As Decimal = 0
                    Dim GrantTotalInfants As Decimal = 0


                    Dim bednights As Integer = Convert.ToInt16(txtBednights.Text.Trim)

                    Dim dsgetAllInclusive As New DataSet


                    If txtadultcount.Text.Trim = "" Then
                        getAdultcount = 0

                    Else
                        getAdultcount = Convert.ToInt16(txtadultcount.Text.Trim)
                        dsgetAllInclusive = DSLoadAllInclusiveFITS("FIT", "Adults")
                        GrantTotaAd = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getAdultcount * bednights
                        GrantTotalAI = GrantTotalAI + GrantTotaAd
                    End If


                    If txtchildcount.Text.Trim = "" Then
                        getChildcount = 0

                    Else
                        getChildcount = Convert.ToInt16(txtchildcount.Text.Trim)
                        dsgetAllInclusive = DSLoadAllInclusiveFITS("FIT", "Children")
                        GrantTotalChd = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getChildcount * bednights
                        GrantTotalAI = GrantTotalAI + GrantTotalChd

                    End If


                    If txtinfantcount.Text.Trim = "" Then
                        getInfantscount = 0

                    Else

                        getInfantscount = Convert.ToInt16(txtinfantcount.Text.Trim)
                        dsgetAllInclusive = DSLoadAllInclusiveFITS("FIT", "Infants")
                        GrantTotalInfants = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getInfantscount * bednights
                        GrantTotalAI = GrantTotalAI + GrantTotalInfants

                    End If
                End If

                txtRate.Text = GrandTotRatePerContract + GrantTotalAI
                txtTotal.Text = GrandTotRatePerContract + GrantTotalAI

            End If

            '------------------------------------------------------------------------------------------------------------------------------

            If PubResType = "RATENOCON" Then

                MessageBox.Show("Contract Not Assigned to the selected Tour Operator.Defualt Room Rates Will Be Apply ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim Gettotbednights As Integer = Convert.ToInt16(txtBednights.Text.Trim) - 1
                Dim TotRatePerContract3 As Decimal
                Dim GrandTotRatePerContract As Decimal
                Dim GetResDateInc As Integer = 0
                Dim GetResDate As DateTime = DtResdate.DateTime.Date

                While Gettotbednights >= 0

                    Dim dsGetContractRateFit As New DataSet
                    'dsGetContractRateFit = DSLoadRoomRatesFits(DtResdate.DateTime.Date, cmbRoom.Text.Trim, cmbMealplan.Text.Trim, cmbRoomtyp.Text.Trim)

                    dsGetContractRateFit = DSLoadRoomRatesTopNonContracts(DateAdd(DateInterval.Day, +GetResDateInc, GetResDate), cmbRoom.Text.Trim, cmbMealplan.Text.Trim, cmbRoomtyp.Text.Trim)


                    If dsGetContractRateFit Is Nothing Then

                        MessageBox.Show("Rates are not defined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        txtRate.Text = "0.00"
                        txtTotal.Text = "0.00"
                        Exit While
                    Else
                        Dim RatePerContract As Decimal = Convert.ToDecimal(dsGetContractRateFit.Tables(0).Rows(0)(10).ToString)
                        ' TotRatePerContract3 = RatePerContract * Convert.ToInt16(txtRoomcount.Text.Trim) * Convert.ToInt16(totPaxrooms.Text.Trim)

                        TotRatePerContract3 = RatePerContract * Convert.ToInt16(totPaxrooms.Text.Trim)

                        GrandTotRatePerContract = GrandTotRatePerContract + TotRatePerContract3
                    End If

                    Gettotbednights = Gettotbednights - 1
                    GetResDateInc = GetResDateInc + 1

                End While


                txtRate.Text = GrandTotRatePerContract
                txtTotal.Text = GrandTotRatePerContract

            End If
        End If


        '--------------------------------------------------------------------------------------------------------------------------------------

        If dsgetRoomCount.Tables(0).Rows.Count > 1 Then

            If PubResType = "RATECON" Then

                Dim DScount As Integer = dsgetRoomCount.Tables(0).Rows.Count - 1
                Dim conRoom As String
                Dim conRoomType As String
                Dim conRoomCount As Integer
                Dim RatePerContract As Decimal
                Dim TotRatePerContract As Decimal
                Dim conBednights As Integer
                Dim conTotPax As Integer
                Dim GrandTotRatePerContract As Decimal

                Dim Gettotbednights As Integer = Convert.ToInt16(txtBednights.Text.Trim) - 1
                Dim TotRatePerContract2 As Decimal

                Dim GetResDateInc As Integer = 0
                Dim GetResDate As DateTime = DtResdate.DateTime.Date


                While DScount >= 0



                    While Gettotbednights >= 0


                        conRoom = dsgetRoomCount.Tables(0).Rows(DScount)(4).ToString
                        conRoomType = dsgetRoomCount.Tables(0).Rows(DScount)(5).ToString
                        conRoomCount = Convert.ToInt16(dsgetRoomCount.Tables(0).Rows(DScount)(6).ToString)
                        conBednights = Convert.ToInt16(dsgetRoomCount.Tables(0).Rows(DScount)(7).ToString)
                        conTotPax = Convert.ToInt16(dsgetRoomCount.Tables(0).Rows(DScount)(8).ToString)

                        Dim dsGetContractRate As New DataSet
                        'dsGetContractRate = DSLoadRoomRatesContracts(cbTopcode.GetColumnValue("TopCode"), DtResdate.DateTime.Date, conRoom, cmbMealplan.Text.Trim, conRoomType)
                        dsGetContractRate = DSLoadRoomRatesContracts(cbTopcode.GetColumnValue("TopCode"), DateAdd(DateInterval.Day, +GetResDateInc, GetResDate), conRoom, cmbMealplan.Text.Trim, conRoomType)
                        If dsGetContractRate Is Nothing Then
                            MessageBox.Show("Rates are not defined for this Contracts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            txtRate.Text = "0.00"
                            txtTotal.Text = "0.00"
                            Exit While

                        Else

                            RatePerContract = Convert.ToDecimal(dsGetContractRate.Tables(0).Rows(0)(8).ToString)
                            'TotRatePerContract2 = TotRatePerContract2 + (RatePerContract * conRoomCount * conTotPax)

                            TotRatePerContract2 = TotRatePerContract2 + (RatePerContract * conTotPax)

                            GrandTotRatePerContract = GrandTotRatePerContract + TotRatePerContract2



                        End If

                        Gettotbednights = Gettotbednights - 1
                        GetResDateInc = GetResDateInc + 1

                    End While

                    DScount = DScount - 1

                End While



                Dim GrantTotalAI As Decimal = 0

                If cmbMealplan.Text.Trim = "AI" Then

                    Dim getAdultcount As Integer = 0
                    Dim getChildcount As Integer = 0
                    Dim getInfantscount As Integer = 0


                    Dim GrantTotaAd As Decimal = 0
                    Dim GrantTotalChd As Decimal = 0
                    Dim GrantTotalInfants As Decimal = 0


                    Dim bednights As Integer = Convert.ToInt16(txtBednights.Text.Trim)

                    Dim dsgetAllInclusive As New DataSet


                    If txtadultcount.Text.Trim = "" Then
                        getAdultcount = 0

                    Else
                        getAdultcount = Convert.ToInt16(txtadultcount.Text.Trim)
                        dsgetAllInclusive = DSLoadAllInclusiveContracts(cbTopcode.GetColumnValue("TopCode"), "Adults")
                        GrantTotaAd = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getAdultcount * bednights
                        GrantTotalAI = GrantTotalAI + GrantTotaAd
                    End If


                    If txtchildcount.Text.Trim = "" Then
                        getChildcount = 0

                    Else
                        getChildcount = Convert.ToInt16(txtchildcount.Text.Trim)
                        dsgetAllInclusive = DSLoadAllInclusiveContracts(cbTopcode.GetColumnValue("TopCode"), "Children")
                        GrantTotalChd = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getChildcount * bednights
                        GrantTotalAI = GrantTotalAI + GrantTotalChd

                    End If


                    If txtinfantcount.Text.Trim = "" Then
                        getInfantscount = 0

                    Else

                        getInfantscount = Convert.ToInt16(txtinfantcount.Text.Trim)
                        dsgetAllInclusive = DSLoadAllInclusiveContracts(cbTopcode.GetColumnValue("TopCode"), "Infants")
                        GrantTotalInfants = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getInfantscount * bednights
                        GrantTotalAI = GrantTotalAI + GrantTotalInfants

                    End If
                End If

                txtRate.Text = GrandTotRatePerContract + GrantTotalAI
                txtTotal.Text = GrandTotRatePerContract + GrantTotalAI

            End If






            If PubResType = "RATEFIT" Then


                Dim DScount As Integer = dsgetRoomCount.Tables(0).Rows.Count - 1
                Dim conRoom As String
                Dim conRoomType As String
                Dim conRoomCount As Integer
                Dim RatePerContract As Decimal
                Dim TotRatePerContract As Decimal
                Dim conBednights As Integer
                Dim conTotPax As Integer


                Dim GrandTotRatePerContract As Decimal

                Dim Gettotbednights As Integer = Convert.ToInt16(txtBednights.Text.Trim) - 1
                Dim TotRatePerContract2 As Decimal

                Dim GetResDateInc As Integer = 0
                Dim GetResDate As DateTime = DtResdate.DateTime.Date

                While DScount >= 0

                    While Gettotbednights >= 0

                        conRoom = dsgetRoomCount.Tables(0).Rows(DScount)(4).ToString
                        conRoomType = dsgetRoomCount.Tables(0).Rows(DScount)(5).ToString
                        conRoomCount = Convert.ToInt16(dsgetRoomCount.Tables(0).Rows(DScount)(6).ToString)
                        conBednights = Convert.ToInt16(dsgetRoomCount.Tables(0).Rows(DScount)(7).ToString)
                        conTotPax = Convert.ToInt16(dsgetRoomCount.Tables(0).Rows(DScount)(8).ToString)

                        Dim dsGetContractRateFit As New DataSet
                        ' dsGetContractRateFit = DSLoadRoomRatesFits(DtResdate.DateTime.Date, conRoom, cmbMealplan.Text.Trim, conRoomType)
                        dsGetContractRateFit = DSLoadRoomRatesFits(DateAdd(DateInterval.Day, +GetResDateInc, GetResDate), conRoom, cmbMealplan.Text.Trim, conRoomType)

                        If dsGetContractRateFit Is Nothing Then

                            MessageBox.Show("Rates are not defined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            txtRate.Text = "0.00"
                            txtTotal.Text = "0.00"
                            Exit While


                        Else

                            'TotRatePerContract2 = TotRatePerContract2 + (RatePerContract * conRoomCount * conTotPax)
                            'GrandTotRatePerContract = GrandTotRatePerContract + TotRatePerContract2

                            RatePerContract = Convert.ToDecimal(dsGetContractRateFit.Tables(0).Rows(0)(10).ToString)
                            ' TotRatePerContract = TotRatePerContract + (RatePerContract * conRoomCount * conTotPax)

                            TotRatePerContract = TotRatePerContract + (RatePerContract * conTotPax)
                            GrandTotRatePerContract = GrandTotRatePerContract + TotRatePerContract

                        End If

                        Gettotbednights = Gettotbednights - 1
                        GetResDateInc = GetResDateInc + 1

                    End While

                    DScount = DScount - 1

                End While


                Dim GrantTotalAI As Decimal = 0

                If cmbMealplan.Text.Trim = "AI" Then

                    Dim getAdultcount As Integer = 0
                    Dim getChildcount As Integer = 0
                    Dim getInfantscount As Integer = 0


                    Dim GrantTotaAd As Decimal = 0
                    Dim GrantTotalChd As Decimal = 0
                    Dim GrantTotalInfants As Decimal = 0


                    Dim bednights As Integer = Convert.ToInt16(txtBednights.Text.Trim)

                    Dim dsgetAllInclusive As New DataSet


                    If txtadultcount.Text.Trim = "" Then
                        getAdultcount = 0

                    Else
                        getAdultcount = Convert.ToInt16(txtadultcount.Text.Trim)
                        dsgetAllInclusive = DSLoadAllInclusiveFITS("FIT", "Adults")
                        GrantTotaAd = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getAdultcount * bednights
                        GrantTotalAI = GrantTotalAI + GrantTotaAd
                    End If


                    If txtchildcount.Text.Trim = "" Then
                        getChildcount = 0

                    Else
                        getChildcount = Convert.ToInt16(txtchildcount.Text.Trim)
                        dsgetAllInclusive = DSLoadAllInclusiveFITS("FIT", "Children")
                        GrantTotalChd = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getChildcount * bednights
                        GrantTotalAI = GrantTotalAI + GrantTotalChd

                    End If


                    If txtinfantcount.Text.Trim = "" Then
                        getInfantscount = 0

                    Else

                        getInfantscount = Convert.ToInt16(txtinfantcount.Text.Trim)
                        dsgetAllInclusive = DSLoadAllInclusiveFITS("FIT", "Infants")
                        GrantTotalInfants = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getInfantscount * bednights
                        GrantTotalAI = GrantTotalAI + GrantTotalInfants

                    End If
                End If





                txtRate.Text = GrandTotRatePerContract + GrantTotalAI
                txtTotal.Text = GrandTotRatePerContract + GrantTotalAI

            End If


            If PubResType = "RATENOCON" Then

                Dim DScount As Integer = dsgetRoomCount.Tables(0).Rows.Count - 1
                Dim conRoom As String
                Dim conRoomType As String
                Dim conRoomCount As Integer
                Dim RatePerContract As Decimal
                Dim TotRatePerContract As Decimal
                Dim conBednights As Integer
                Dim conTotPax As Integer


                Dim GrandTotRatePerContract As Decimal

                Dim Gettotbednights As Integer = Convert.ToInt16(txtBednights.Text.Trim) - 1
                Dim TotRatePerContract2 As Decimal

                Dim GetResDateInc As Integer = 0
                Dim GetResDate As DateTime = DtResdate.DateTime.Date





                While DScount >= 0

                    While Gettotbednights >= 0

                        conRoom = dsgetRoomCount.Tables(0).Rows(DScount)(4).ToString
                        conRoomType = dsgetRoomCount.Tables(0).Rows(DScount)(5).ToString
                        conRoomCount = Convert.ToInt16(dsgetRoomCount.Tables(0).Rows(DScount)(6).ToString)
                        conBednights = Convert.ToInt16(dsgetRoomCount.Tables(0).Rows(DScount)(7).ToString)
                        conTotPax = Convert.ToInt16(dsgetRoomCount.Tables(0).Rows(DScount)(8).ToString)

                        Dim dsGetContractRateFit As New DataSet
                        ' dsGetContractRateFit = DSLoadRoomRatesFits(DtResdate.DateTime.Date, conRoom, cmbMealplan.Text.Trim, conRoomType)
                        dsGetContractRateFit = DSLoadRoomRatesTopNonContracts(DateAdd(DateInterval.Day, +GetResDateInc, GetResDate), cmbRoom.Text.Trim, cmbMealplan.Text.Trim, cmbRoomtyp.Text.Trim)

                        If dsGetContractRateFit Is Nothing Then

                            MessageBox.Show("Rates are not defined", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            txtRate.Text = "0.00"
                            txtTotal.Text = "0.00"
                            Exit While


                        Else

                            'TotRatePerContract2 = TotRatePerContract2 + (RatePerContract * conRoomCount * conTotPax)
                            'GrandTotRatePerContract = GrandTotRatePerContract + TotRatePerContract2
                            RatePerContract = Convert.ToDecimal(dsGetContractRateFit.Tables(0).Rows(0)(10).ToString)
                            'TotRatePerContract = TotRatePerContract + (RatePerContract * conRoomCount * conTotPax)

                            TotRatePerContract = TotRatePerContract + (RatePerContract * conTotPax)

                            GrandTotRatePerContract = GrandTotRatePerContract + TotRatePerContract

                        End If

                        Gettotbednights = Gettotbednights - 1
                        GetResDateInc = GetResDateInc + 1

                    End While

                    DScount = DScount - 1

                End While

                txtRate.Text = GrandTotRatePerContract
                txtTotal.Text = GrandTotRatePerContract
            End If
        End If
        gbpayment.Enabled = True
        gbOthers.Enabled = True
        LoadDiscounts()

        btAdd.Focus()

    End Sub
    Private Sub GetDiscountRate()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try




            Dim Disscountid As Integer = IIf(IsNothing(cmbDisscounts.GetColumnValue("DisID")), String.Empty, cmbDisscounts.GetColumnValue("DisID"))
            PubDisID = Disscountid

            Conn.Open()
            dcSearch = New SqlCommand("select dbo.[Discounts.Master].DisAmt ,dbo.[Discounts.Master].DisType from dbo.[Discounts.Master] where dbo.[Discounts.Master].DisID=@GetDisId", Conn)
            dcSearch.Parameters.Add("@GetDisId", SqlDbType.Int).Value = Disscountid

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            If dsMain.Tables(0).Rows.Count > 0 Then

                If dsMain.Tables(0).Rows(0)(1).ToString = "Value" Then

                    Dim Dscount As Decimal = Convert.ToDecimal(dsMain.Tables(0).Rows(0)(0).ToString)
                    Dim getTotal As Decimal = Convert.ToDecimal(Convert.ToDecimal(txtRate.Text.Trim)) - Dscount
                    txtTotal.Text = getTotal.ToString

                Else

                    Dim Dscount As Decimal = Convert.ToDecimal(dsMain.Tables(0).Rows(0)(0).ToString)
                    Dim getTotal As Decimal = Convert.ToDecimal(Convert.ToDecimal(txtRate.Text.Trim) - (Convert.ToDecimal(txtRate.Text.Trim) * (Dscount / 100)))
                    txtTotal.Text = getTotal.ToString

                End If
            Else

                txtTotal.Text = txtRate.Text


            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub


    Private Sub cmbDisscounts_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDisscounts.EditValueChanged
        If PubIsEdit <> "EDIT" Then

            GetDiscountRate()

        Else

            'PubDisID = IIf(IsNothing(cmbDisscounts.GetColumnValue("DisID")), String.Empty, cmbDisscounts.GetColumnValue("DisID"))


        End If

    End Sub
    Function DSGetRoomTempDetails() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim CurrentUser As String = CurrUser
            Dim ReservationNo As String = txtReservationno.Text.Trim
            Dim Createdby As String = CurrentUser

            dcSearch = New SqlCommand("select * from dbo.[Reservation.Room.Temp] where ReservationNo=@ReservationNo and Createdby=@Createdby", Conn)
            dcSearch.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = ReservationNo
            dcSearch.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = Createdby

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSGetRoomTempDetails = dsMain
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
    Private Sub InsertReservationMaster()

        Try

            Dim CurrentUser As String = CurrUser
            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim Restype As String = ""
            Dim Topcode As String = ""
            Dim Iscontract As Integer = 0
            Dim contractId As String = ""
            Dim getAdultcount As Integer = 0
            Dim getChildcount As Integer = 0
            Dim getInfantscount As Integer = 0


            '-----------------------------------------------------------------------------------
            If CbTop.Checked = True Then
                Restype = "TOP"
                Topcode = cbTopcode.GetColumnValue("TopCode")
            End If

            If CbCompl.Checked = True Then
                Restype = "COM"
                Topcode = ""
            End If

            If CbFit.Checked = True Then
                Restype = "FIT"
                Topcode = ""
            End If
            '-----------------------------------------------------------------------------------
            If PubIscontract = 1 Then
                Iscontract = 1
            Else
                Iscontract = 0
            End If

            '-----------------------------------------------------------------------------------
            If PubContractId = "" Then

                contractId = ""

            Else
                contractId = PubContractId

            End If
            '-----------------------------------------------------------------------------------

            If txtadultcount.Text.Trim = "" Then
                getAdultcount = 0
            Else
                getAdultcount = Convert.ToInt16(txtadultcount.Text.Trim)
            End If

            If txtchildcount.Text.Trim = "" Then
                getChildcount = 0
            Else
                getChildcount = Convert.ToInt16(txtchildcount.Text.Trim)
            End If


            If txtinfantcount.Text.Trim = "" Then
                getInfantscount = 0
            Else
                getInfantscount = Convert.ToInt16(txtinfantcount.Text.Trim)
            End If

            '-----------------------------------------------------------------------------------

            dcInsertNewAcc = New SqlCommand("InsertReservationMaster_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = txtReservationno.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = DtResdate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@Guest", SqlDbType.VarChar).Value = txtGuesname.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ResType", SqlDbType.VarChar).Value = Restype
            dcInsertNewAcc.Parameters.Add("@Topcode", SqlDbType.VarChar).Value = Topcode

            dcInsertNewAcc.Parameters.Add("@IsTopcontract", SqlDbType.Int).Value = Iscontract
            dcInsertNewAcc.Parameters.Add("@TopContractId", SqlDbType.VarChar).Value = contractId





            dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)
            dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = Convert.ToDateTime(txtDepyear.Text + "/" + txtDepMonth.Text + "/" + txtDepDay.Text)


            'dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = DtArrival.DateTime.Date
            'dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = DtDep.DateTime.Date



            If cmbArrType.Text.Trim = "Other" Then

                dcInsertNewAcc.Parameters.Add("@ArrFlight", SqlDbType.VarChar).Value = txtOtherArr.Text.Trim
                dcInsertNewAcc.Parameters.Add("@DepFlight", SqlDbType.VarChar).Value = txtOtherDep.Text.Trim
                dcInsertNewAcc.Parameters.Add("@ArrTime", SqlDbType.DateTime).Value = Convert.ToDateTime(txtArrTime.Text.Trim)
                dcInsertNewAcc.Parameters.Add("@DepTime", SqlDbType.DateTime).Value = Convert.ToDateTime(txtDepTime.Text.Trim)

            Else


                dcInsertNewAcc.Parameters.Add("@ArrFlight", SqlDbType.VarChar).Value = cmbArriFlight.Text.Trim
                dcInsertNewAcc.Parameters.Add("@DepFlight", SqlDbType.VarChar).Value = cmbDepFlight.Text.Trim
                dcInsertNewAcc.Parameters.Add("@ArrTime", SqlDbType.DateTime).Value = txtArrTime.Text.Trim
                dcInsertNewAcc.Parameters.Add("@DepTime", SqlDbType.DateTime).Value = txtDepTime.Text.Trim

            End If





            dcInsertNewAcc.Parameters.Add("@ArrTrans", SqlDbType.VarChar).Value = cmbArrTrans.Text.Trim
            dcInsertNewAcc.Parameters.Add("@DepTrans", SqlDbType.VarChar).Value = cmbDepTrans.Text.Trim


            dcInsertNewAcc.Parameters.Add("@PaxId", SqlDbType.VarChar).Value = PubPaxId

            dcInsertNewAcc.Parameters.Add("@AdultQty", SqlDbType.Int).Value = getAdultcount
            dcInsertNewAcc.Parameters.Add("@ChildrenQty", SqlDbType.Int).Value = getChildcount
            dcInsertNewAcc.Parameters.Add("@InfantsQty", SqlDbType.Int).Value = getInfantscount
            dcInsertNewAcc.Parameters.Add("@MealPlan", SqlDbType.VarChar).Value = cmbMealplan.Text.Trim
            dcInsertNewAcc.Parameters.Add("@BedNights", SqlDbType.Int).Value = Convert.ToInt16(txtBednights.Text.Trim)

            dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRate.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@DisPlanId", SqlDbType.Int).Value = PubDisID
            dcInsertNewAcc.Parameters.Add("@OfferId", SqlDbType.Int).Value = PubOffID

            dcInsertNewAcc.Parameters.Add("@AmenId", SqlDbType.Int).Value = PubAmentID
            dcInsertNewAcc.Parameters.Add("@Total", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotal.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@PayMode", SqlDbType.VarChar).Value = cmbpaymode.Text.Trim
            dcInsertNewAcc.Parameters.Add("@PayExpiryDate", SqlDbType.DateTime).Value = DtExpiry.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@PayCCNo", SqlDbType.VarChar).Value = txtCCno.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Guestlikes", SqlDbType.VarChar).Value = txtguestlike.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Guestdislikes", SqlDbType.VarChar).Value = txtguestdislike.Text.Trim
            dcInsertNewAcc.Parameters.Add("@BillingInst", SqlDbType.VarChar).Value = txtBillinginst.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = txtRemarks.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Refno", SqlDbType.VarChar).Value = txtRefno.Text.Trim

            If PubDisID <> 0 Then
                dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "PENDING_DIS"
            Else
                dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
            End If


            dcInsertNewAcc.Parameters.Add("@EnteredBy", SqlDbType.VarChar).Value = CurrentUser
            dcInsertNewAcc.Parameters.Add("@EnteredDate", SqlDbType.DateTime).Value = DateTime.Now
            dcInsertNewAcc.Parameters.Add("@InactivatedBy", SqlDbType.VarChar).Value = ""
            dcInsertNewAcc.Parameters.Add("@InactivatedDate", SqlDbType.DateTime).Value = "1900/1/1"


            dcInsertNewAcc.Parameters.Add("@ArrTransTime", SqlDbType.VarChar).Value = cmbArrTransTime.Text.Trim
            dcInsertNewAcc.Parameters.Add("@DepTransTime", SqlDbType.VarChar).Value = cmbDepTransTime.Text.Trim


            dcInsertNewAcc.Parameters.Add("@Country", SqlDbType.VarChar).Value = cmbCountry.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Nationality", SqlDbType.VarChar).Value = txtNationality.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text.Trim

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Reservation Details Saved Successfully", "Save Reservation Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub cmbAmmenties_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAmmenties.EditValueChanged
        PubAmentID = IIf(IsNothing(cmbAmmenties.GetColumnValue("AmentitiesID")), String.Empty, cmbAmmenties.GetColumnValue("AmentitiesID"))
    End Sub
    Private Sub InsertResRoomCount()

        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand
            Dim CurrentUser As String = CurrUser

            dcSearch = New SqlCommand("select * from dbo.[Reservation.Room.Temp]  where ReservationNo=@ReservationNo and ReservationDate=@ReservationDate and Createdby=@Createdby", Conn)
            dcSearch.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = txtReservationno.Text.Trim
            dcSearch.Parameters.Add("@ReservationDate", SqlDbType.DateTime).Value = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)
            dcSearch.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            Conn.Close()

            Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

            Dim autoid As String = System.Guid.NewGuid().ToString()
            PubPaxId = autoid

            While DScount >= 0

                dcInsertNewAcc = New SqlCommand("InsertResRoom_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@ResPaxId", SqlDbType.VarChar).Value = autoid
                dcInsertNewAcc.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(1).ToString
                dcInsertNewAcc.Parameters.Add("@ReservationDate", SqlDbType.DateTime).Value = Convert.ToDateTime(dsMain.Tables(0).Rows(DScount)(2).ToString)
                dcInsertNewAcc.Parameters.Add("@ReservationType", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(3).ToString
                dcInsertNewAcc.Parameters.Add("@Room", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(4).ToString
                dcInsertNewAcc.Parameters.Add("@Roomtype", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(5).ToString
                dcInsertNewAcc.Parameters.Add("@RoomCount", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount)(6).ToString)
                dcInsertNewAcc.Parameters.Add("@BedNights", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount)(7).ToString)
                dcInsertNewAcc.Parameters.Add("@TotPax", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount)(8).ToString)
                dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()
                DScount = DScount - 1
            End While

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Function DSCheckInsertResRoom() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim CurrentUser As String = CurrUser
            Dim Reservationno As String = txtReservationno.Text.Trim
            Dim getCreatedby As String = CurrentUser

            dcSearch = New SqlCommand("select * from dbo.[Reservation.Room] where ReservationNo=@Reservationno and Createdby=@Createdby", Conn)
            dcSearch.Parameters.Add("@Reservationno", SqlDbType.VarChar).Value = Reservationno
            dcSearch.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = getCreatedby

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertResRoom = dsMain
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
    Sub ClearFields()




        txtReservationno.Text = GetReservationCode()
        'DtResdate.Text = DateTime.Now
        txtGuesname.Text = ""
        CbFit.Checked = False
        CbCompl.Checked = False
        CbTop.Checked = False
        ' gbBookingtype.Enabled = False
        '  gbArridep.Enabled = False
        txtRoomcount.Text = ""
        txtadultcount.Text = ""
        txtchildcount.Text = ""
        txtinfantcount.Text = ""
        txtcounttot.Text = ""
        txtBednights.Text = ""
        txtRate.Text = ""
        txtTotal.Text = ""
        txtCCno.Text = ""
        txtguestlike.Text = ""
        txtguestdislike.Text = ""
        txtBillinginst.Text = ""
        txtRemarks.Text = ""
        gcRoomcount.DataSource = Nothing
        PubIscontract = 0
        PubContractId = ""

        lblArrivalFlight.Text = "Flight"
        cmbArriFlight.Visible = True
        txtOtherArr.Visible = False
        ' txtArrTime.Properties.ReadOnly = True
        lblDepFlight.Text = "Flight"
        cmbDepFlight.Visible = True
        txtOtherDep.Visible = False
        '  txtDepTime.Properties.ReadOnly = True

        txtArrTime.Text = ""
        txtDepTime.Text = ""


        cmbRoom.SelectedIndex = 0
        cmbRoomtyp.SelectedIndex = 0
        ' cbTopcode2.SelectedIndex = 0
        cmbMealplan.SelectedIndex = 0
        cmbpaymode.SelectedIndex = 0
        cmbArrTrans.SelectedIndex = 0
        cmbDepTrans.SelectedIndex = 0
        cmbArrType.SelectedIndex = 0
        cmbDepType.SelectedIndex = 0

        cmbArrTransTime.SelectedIndex = 0
        cmbDepTransTime.SelectedIndex = 0

        cmbCountry.SelectedIndex = 0
        txtNationality.Text = ""

        txtEmail.Text = ""


        txtArrMonth.Text = DateTime.Now.Month
        txtArrDay.Text = DateTime.Now.Day
        txtArryear.Text = DateTime.Now.Year

        txtDepMonth.Text = DateTime.Now.Month
        txtDepDay.Text = DateTime.Now.Day
        txtDepyear.Text = DateTime.Now.Year

        cmbDepFlight.Text = ""
        cmbArriFlight.Text = ""

        gbpayment.Enabled = True

        gbOthers.Enabled = True




        DeleteTempRoomCount(txtReservationno.Text.Trim)

    End Sub
    Function DSCheckInsertResMaster() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim CurrentUser As String = CurrUser
            Dim Reservationno As String = txtReservationno.Text.Trim
            Dim getCreatedby As String = CurrentUser

            dcSearch = New SqlCommand("select * from dbo.[Reservation.Master] where ResNo=@Reservationno and EnteredBy=@Createdby", Conn)
            dcSearch.Parameters.Add("@Reservationno", SqlDbType.VarChar).Value = Reservationno
            dcSearch.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = getCreatedby

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertResMaster = dsMain
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
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[Reservation.Master] where Status='OPEN'  AND DepDate > @depdate order by ResNo desc ", Conn)



            dcSearch.Parameters.Add("@depdate", SqlDbType.DateTime).Value = DtToday.DateTime.Date
            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)



            If dsMain.Tables(0).Rows.Count > 0 Then
                gcReservation.DataSource = dsMain.Tables(0)

            Else
                MessageBox.Show("No Reservations Records Found", "Reservvation Details", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadGridbyTopRes()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[Reservation.Master] where Status='OPEN' and Refno like '%" & txtTopReference.Text.Trim & "%' order by ResNo", Conn)
            'dcSearch.Parameters.Add("@Refno", SqlDbType.VarChar).Value = txtTopReference.Text.Trim
            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)



            If dsMain.Tables(0).Rows.Count > 0 Then
                gcReservation.DataSource = dsMain.Tables(0)

            Else
                MessageBox.Show("No Reservations Records Found", "Reservvation Details", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadGridPendingDis()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[Reservation.Master] where Status='PENDING_DIS' order by ResNo", Conn)

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then
                gcReservation.DataSource = dsMain.Tables(0)

            Else
                MessageBox.Show("No Pending Discount Reservations", "Approve Discount Details", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadGridBydate(ByVal Resdate As DateTime)
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Dim getResDate As DateTime = Resdate


        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[Reservation.Master] where Status='OPEN'  and ArrDate=@ResDate order by ResNo", Conn)
            dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = getResDate

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)



            If dsMain.Tables(0).Rows.Count > 0 Then
                gcReservation.DataSource = dsMain.Tables(0)

            Else
                MessageBox.Show("No Reservations Records Found", "Reservation Details", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub txtRate_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtRate.EditValueChanging
        txtTotal.Text = txtRate.Text
    End Sub
    Function FieldValidation() As Boolean
        Return IIf(String.Compare(txtReservationno.Text, "", False) = 0 Or String.Compare(txtGuesname.Text, "", False) = 0 Or String.Compare(txtcounttot.Text, "", False) = 0 Or String.Compare(txtRate.Text, "", False) = 0 Or String.Compare(txtTotal.Text, "", False) = 0, 0, 1)
    End Function
    Function FieldValidationRooms() As Boolean
        Return IIf(String.Compare(txtcounttot.Text, "", False) = 0 Or String.Compare(totPaxrooms.Text, "", False) = 0 Or String.Compare(txtRoomcount.Text, "", False) = 0, 0, 1)
    End Function
    Private Sub btView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btView.Click
        gcReservation.DataSource = Nothing
        LoadGridBydate(DtViewdate.DateTime.Date)
    End Sub

    Private Sub btViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewAll.Click
        gcReservation.DataSource = Nothing
        LoadGrid()
    End Sub
    Private Sub ShowGridDets()
        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try

            gbBookingtype.Enabled = False
            ' gbArridep.Enabled = False
            gbPax1.Enabled = False

            btAdd.Enabled = False

            PubIsEdit = "EDIT"
            LoadTopcodes()
            LoadDiscounts()
            LoadAmentites()

            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select ResNo,ResDate,Guest,ResType,Topcode,IsTopcontract,TopContractId,ArrDate,DepDate,ArrFlight,DepFlight,convert(char(5), ArrTime, 108) [ArrTime],convert(char(5), DepTime, 108) [DepTime],ArrTrans,DepTrans,PaxId,AdultQty,ChildrenQty,InfantsQty,MealPlan,BedNights,Rate,DisPlanId,OfferId,AmenId,Total,PayMode,PayExpiryDate,PayCCNo,Guestlikes,Guestdislikes,BillingInst,Remarks,Refno,PaymentStatus,Status,IsProformaCreated,ProfomaInvoiceno,EnteredBy,EnteredDate,InactivatedBy,InactivatedDate,ArrTransTime,DepTransTime,Country,Nationality,Email from dbo.[Reservation.Master] where ResNo= '{0}'", GviewReservation.GetRowCellValue(GviewReservation.FocusedRowHandle, "ResNo")), Conn)
            daShow.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If


            tabReservation.TabPages(1).PageEnabled = True
            tabReservation.SelectedTabPageIndex = 1

            txtReservationno.Text = dsShow.Tables(0).Rows(0).Item("ResNo")
            PubEdtResNo = dsShow.Tables(0).Rows(0).Item("ResNo")

            DtResdate.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("ResDate"))
            PubEdtResDate = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("ResDate"))

            DtToday.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("EnteredDate"))
            DtResdate.ClosePopup()

            txtGuesname.Text = dsShow.Tables(0).Rows(0).Item("Guest")
            PubEdtGuest = dsShow.Tables(0).Rows(0).Item("Guest")


            If dsShow.Tables(0).Rows(0).Item("ResType") = "TOP" Then
                CbTop.Checked = True
                ' cbTopcode.Text = dsShow.Tables(0).Rows(0).Item("Topcode")
                cbTopcode.EditValue = dsShow.Tables(0).Rows(0).Item("Topcode")

            End If

            If dsShow.Tables(0).Rows(0).Item("ResType") = "FIT" Then
                CbFit.Checked = True
                cbTopcode.Text = ""
                cbTopcode.ClosePopup()

            End If

            If dsShow.Tables(0).Rows(0).Item("ResType") = "COM" Then
                CbCompl.Checked = True
                cbTopcode.Text = ""
                cbTopcode.ClosePopup()
            End If

            ' cbTopcode2.ClosePopup()



            txtArrMonth.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("ArrDate")).Month

            txtArrDay.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("ArrDate")).Day

            txtArryear.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("ArrDate")).Year

            txtDepMonth.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("DepDate")).Month
            txtDepDay.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("DepDate")).Day
            txtDepyear.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("DepDate")).Year




            ' DtArrival.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("ArrDate"))
            PubEdtArrDate = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("ArrDate"))

            ' DtDep.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("DepDate"))
            PubEdtDepDate = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("DepDate"))

            'DtArrival.ClosePopup()
            'DtDep.ClosePopup()


            PubIsProformaCreated = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("IsProformaCreated"))
            PubProfomaInvoiceno = dsShow.Tables(0).Rows(0).Item("ProfomaInvoiceno")


            cmbArriFlight.Text = dsShow.Tables(0).Rows(0).Item("ArrFlight")
            PubEdtArrFlight = dsShow.Tables(0).Rows(0).Item("ArrFlight")
            cmbArriFlight.ClosePopup()

            cmbDepFlight.Text = dsShow.Tables(0).Rows(0).Item("DepFlight")
            PubEdtDepFlight = dsShow.Tables(0).Rows(0).Item("DepFlight")
            cmbDepFlight.ClosePopup()

            txtArrTime.Text = dsShow.Tables(0).Rows(0).Item("ArrTime")
            PubEdtArrTime = dsShow.Tables(0).Rows(0).Item("ArrTime")


            txtDepTime.Text = dsShow.Tables(0).Rows(0).Item("DepTime")
            PubEdtDepTime = dsShow.Tables(0).Rows(0).Item("DepTime")

            cmbArrTrans.Text = dsShow.Tables(0).Rows(0).Item("ArrTrans")
            PubEdtArrTrans = dsShow.Tables(0).Rows(0).Item("ArrTrans")
            cmbArrTrans.ClosePopup()



            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("ArrTransTime"))) Then

                cmbArrTransTime.Text = dsShow.Tables(0).Rows(0).Item("ArrTransTime")
                cmbArrTransTime.ClosePopup()

            Else
                cmbArrTransTime.Text = ""
                cmbArrTransTime.ClosePopup()

            End If


            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("DepTransTime"))) Then

                cmbDepTransTime.Text = dsShow.Tables(0).Rows(0).Item("DepTransTime")
                cmbDepTransTime.ClosePopup()

            Else
                cmbDepTransTime.Text = ""
                cmbDepTransTime.ClosePopup()

            End If






            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("Country"))) Then

                cmbCountry.Text = dsShow.Tables(0).Rows(0).Item("Country")
                cmbCountry.ClosePopup()

            Else
                cmbCountry.Text = ""
                cmbCountry.ClosePopup()

            End If


            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("Nationality"))) Then

                txtNationality.Text = dsShow.Tables(0).Rows(0).Item("Nationality")

            Else
                txtNationality.Text = ""


            End If


            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("Email"))) Then

                txtEmail.Text = dsShow.Tables(0).Rows(0).Item("Email")

            Else
                txtEmail.Text = ""


            End If



            cmbDepTrans.Text = dsShow.Tables(0).Rows(0).Item("DepTrans")
            PubEdtDepTrans = dsShow.Tables(0).Rows(0).Item("DepTrans")
            cmbDepTrans.ClosePopup()

            txtBednights.Text = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("BedNights"))

            'Pax details

            Dim dsLoadPax As New DataSet

            ' dsLoadPax = DSGetPaxDetails(dsShow.Tables(0).Rows(0).Item("ResNo"))
            dsLoadPax = DSGetPaxDetailsResMaster(dsShow.Tables(0).Rows(0).Item("ResNo"))

            If dsLoadPax IsNot Nothing Then

                gcRoomcount.DataSource = dsLoadPax.Tables(0)

                If dsLoadPax.Tables(0).Rows.Count = 1 Then

                    PubEdtRoom1 = dsLoadPax.Tables(0).Rows(0)(0)
                    PubEdtRoomType1 = dsLoadPax.Tables(0).Rows(0)(1)
                    PubEdtRoomQty1 = dsLoadPax.Tables(0).Rows(0)(2)

                End If


                If dsLoadPax.Tables(0).Rows.Count = 2 Then

                    PubEdtRoom1 = dsLoadPax.Tables(0).Rows(0)(0)
                    PubEdtRoomType1 = dsLoadPax.Tables(0).Rows(0)(1)
                    PubEdtRoomQty1 = dsLoadPax.Tables(0).Rows(0)(2)

                    PubEdtRoom2 = dsLoadPax.Tables(0).Rows(1)(0)
                    PubEdtRoomType2 = dsLoadPax.Tables(0).Rows(1)(1)
                    PubEdtRoomQty2 = dsLoadPax.Tables(0).Rows(1)(2)

                End If


                If dsLoadPax.Tables(0).Rows.Count = 3 Then

                    PubEdtRoom1 = dsLoadPax.Tables(0).Rows(0)(0)
                    PubEdtRoomType1 = dsLoadPax.Tables(0).Rows(0)(1)
                    PubEdtRoomQty1 = dsLoadPax.Tables(0).Rows(0)(2)

                    PubEdtRoom2 = dsLoadPax.Tables(0).Rows(1)(0)
                    PubEdtRoomType2 = dsLoadPax.Tables(0).Rows(1)(1)
                    PubEdtRoomQty2 = dsLoadPax.Tables(0).Rows(1)(2)

                    PubEdtRoom3 = dsLoadPax.Tables(0).Rows(2)(0)
                    PubEdtRoomType3 = dsLoadPax.Tables(0).Rows(2)(1)
                    PubEdtRoomQty3 = dsLoadPax.Tables(0).Rows(2)(2)

                End If


                If dsLoadPax.Tables(0).Rows.Count = 4 Then

                    PubEdtRoom1 = dsLoadPax.Tables(0).Rows(0)(0)
                    PubEdtRoomType1 = dsLoadPax.Tables(0).Rows(0)(1)
                    PubEdtRoomQty1 = dsLoadPax.Tables(0).Rows(0)(2)

                    PubEdtRoom2 = dsLoadPax.Tables(0).Rows(1)(0)
                    PubEdtRoomType2 = dsLoadPax.Tables(0).Rows(1)(1)
                    PubEdtRoomQty2 = dsLoadPax.Tables(0).Rows(1)(2)

                    PubEdtRoom3 = dsLoadPax.Tables(0).Rows(2)(0)
                    PubEdtRoomType3 = dsLoadPax.Tables(0).Rows(2)(1)
                    PubEdtRoomQty3 = dsLoadPax.Tables(0).Rows(2)(2)

                    PubEdtRoom4 = dsLoadPax.Tables(0).Rows(3)(0)
                    PubEdtRoomType4 = dsLoadPax.Tables(0).Rows(3)(1)
                    PubEdtRoomQty4 = dsLoadPax.Tables(0).Rows(3)(2)

                End If


                If dsLoadPax.Tables(0).Rows.Count = 5 Then

                    PubEdtRoom1 = dsLoadPax.Tables(0).Rows(0)(0)
                    PubEdtRoomType1 = dsLoadPax.Tables(0).Rows(0)(1)
                    PubEdtRoomQty1 = dsLoadPax.Tables(0).Rows(0)(2)

                    PubEdtRoom2 = dsLoadPax.Tables(0).Rows(1)(0)
                    PubEdtRoomType2 = dsLoadPax.Tables(0).Rows(1)(1)
                    PubEdtRoomQty2 = dsLoadPax.Tables(0).Rows(1)(2)

                    PubEdtRoom3 = dsLoadPax.Tables(0).Rows(2)(0)
                    PubEdtRoomType3 = dsLoadPax.Tables(0).Rows(2)(1)
                    PubEdtRoomQty3 = dsLoadPax.Tables(0).Rows(2)(2)

                    PubEdtRoom4 = dsLoadPax.Tables(0).Rows(3)(0)
                    PubEdtRoomType4 = dsLoadPax.Tables(0).Rows(3)(1)
                    PubEdtRoomQty4 = dsLoadPax.Tables(0).Rows(3)(2)

                    PubEdtRoom5 = dsLoadPax.Tables(0).Rows(4)(0)
                    PubEdtRoomType5 = dsLoadPax.Tables(0).Rows(4)(1)
                    PubEdtRoomQty5 = dsLoadPax.Tables(0).Rows(4)(2)


                End If


                If dsLoadPax.Tables(0).Rows.Count = 6 Then

                    PubEdtRoom1 = dsLoadPax.Tables(0).Rows(0)(0)
                    PubEdtRoomType1 = dsLoadPax.Tables(0).Rows(0)(1)
                    PubEdtRoomQty1 = dsLoadPax.Tables(0).Rows(0)(2)

                    PubEdtRoom2 = dsLoadPax.Tables(0).Rows(1)(0)
                    PubEdtRoomType2 = dsLoadPax.Tables(0).Rows(1)(1)
                    PubEdtRoomQty2 = dsLoadPax.Tables(0).Rows(1)(2)

                    PubEdtRoom3 = dsLoadPax.Tables(0).Rows(2)(0)
                    PubEdtRoomType3 = dsLoadPax.Tables(0).Rows(2)(1)
                    PubEdtRoomQty3 = dsLoadPax.Tables(0).Rows(2)(2)

                    PubEdtRoom4 = dsLoadPax.Tables(0).Rows(3)(0)
                    PubEdtRoomType4 = dsLoadPax.Tables(0).Rows(3)(1)
                    PubEdtRoomQty4 = dsLoadPax.Tables(0).Rows(3)(2)

                    PubEdtRoom5 = dsLoadPax.Tables(0).Rows(4)(0)
                    PubEdtRoomType5 = dsLoadPax.Tables(0).Rows(4)(1)
                    PubEdtRoomQty5 = dsLoadPax.Tables(0).Rows(4)(2)

                    PubEdtRoom6 = dsLoadPax.Tables(0).Rows(5)(0)
                    PubEdtRoomType6 = dsLoadPax.Tables(0).Rows(5)(1)
                    PubEdtRoomQty6 = dsLoadPax.Tables(0).Rows(5)(2)


                End If


                If dsLoadPax.Tables(0).Rows.Count = 7 Then

                    PubEdtRoom1 = dsLoadPax.Tables(0).Rows(0)(0)
                    PubEdtRoomType1 = dsLoadPax.Tables(0).Rows(0)(1)
                    PubEdtRoomQty1 = dsLoadPax.Tables(0).Rows(0)(2)

                    PubEdtRoom2 = dsLoadPax.Tables(0).Rows(1)(0)
                    PubEdtRoomType2 = dsLoadPax.Tables(0).Rows(1)(1)
                    PubEdtRoomQty2 = dsLoadPax.Tables(0).Rows(1)(2)

                    PubEdtRoom3 = dsLoadPax.Tables(0).Rows(2)(0)
                    PubEdtRoomType3 = dsLoadPax.Tables(0).Rows(2)(1)
                    PubEdtRoomQty3 = dsLoadPax.Tables(0).Rows(2)(2)

                    PubEdtRoom4 = dsLoadPax.Tables(0).Rows(3)(0)
                    PubEdtRoomType4 = dsLoadPax.Tables(0).Rows(3)(1)
                    PubEdtRoomQty4 = dsLoadPax.Tables(0).Rows(3)(2)

                    PubEdtRoom5 = dsLoadPax.Tables(0).Rows(4)(0)
                    PubEdtRoomType5 = dsLoadPax.Tables(0).Rows(4)(1)
                    PubEdtRoomQty5 = dsLoadPax.Tables(0).Rows(4)(2)

                    PubEdtRoom6 = dsLoadPax.Tables(0).Rows(5)(0)
                    PubEdtRoomType6 = dsLoadPax.Tables(0).Rows(5)(1)
                    PubEdtRoomQty6 = dsLoadPax.Tables(0).Rows(5)(2)

                    PubEdtRoom7 = dsLoadPax.Tables(0).Rows(6)(0)
                    PubEdtRoomType7 = dsLoadPax.Tables(0).Rows(6)(1)
                    PubEdtRoomQty7 = dsLoadPax.Tables(0).Rows(6)(2)


                End If


                If dsLoadPax.Tables(0).Rows.Count = 8 Then

                    PubEdtRoom1 = dsLoadPax.Tables(0).Rows(0)(0)
                    PubEdtRoomType1 = dsLoadPax.Tables(0).Rows(0)(1)
                    PubEdtRoomQty1 = dsLoadPax.Tables(0).Rows(0)(2)

                    PubEdtRoom2 = dsLoadPax.Tables(0).Rows(1)(0)
                    PubEdtRoomType2 = dsLoadPax.Tables(0).Rows(1)(1)
                    PubEdtRoomQty2 = dsLoadPax.Tables(0).Rows(1)(2)

                    PubEdtRoom3 = dsLoadPax.Tables(0).Rows(2)(0)
                    PubEdtRoomType3 = dsLoadPax.Tables(0).Rows(2)(1)
                    PubEdtRoomQty3 = dsLoadPax.Tables(0).Rows(2)(2)

                    PubEdtRoom4 = dsLoadPax.Tables(0).Rows(3)(0)
                    PubEdtRoomType4 = dsLoadPax.Tables(0).Rows(3)(1)
                    PubEdtRoomQty4 = dsLoadPax.Tables(0).Rows(3)(2)

                    PubEdtRoom5 = dsLoadPax.Tables(0).Rows(4)(0)
                    PubEdtRoomType5 = dsLoadPax.Tables(0).Rows(4)(1)
                    PubEdtRoomQty5 = dsLoadPax.Tables(0).Rows(4)(2)

                    PubEdtRoom6 = dsLoadPax.Tables(0).Rows(5)(0)
                    PubEdtRoomType6 = dsLoadPax.Tables(0).Rows(5)(1)
                    PubEdtRoomQty6 = dsLoadPax.Tables(0).Rows(5)(2)

                    PubEdtRoom7 = dsLoadPax.Tables(0).Rows(6)(0)
                    PubEdtRoomType7 = dsLoadPax.Tables(0).Rows(6)(1)
                    PubEdtRoomQty7 = dsLoadPax.Tables(0).Rows(6)(2)

                    PubEdtRoom8 = dsLoadPax.Tables(0).Rows(7)(0)
                    PubEdtRoomType8 = dsLoadPax.Tables(0).Rows(7)(1)
                    PubEdtRoomQty8 = dsLoadPax.Tables(0).Rows(7)(2)


                End If


                If dsLoadPax.Tables(0).Rows.Count = 9 Then

                    PubEdtRoom1 = dsLoadPax.Tables(0).Rows(0)(0)
                    PubEdtRoomType1 = dsLoadPax.Tables(0).Rows(0)(1)
                    PubEdtRoomQty1 = dsLoadPax.Tables(0).Rows(0)(2)

                    PubEdtRoom2 = dsLoadPax.Tables(0).Rows(1)(0)
                    PubEdtRoomType2 = dsLoadPax.Tables(0).Rows(1)(1)
                    PubEdtRoomQty2 = dsLoadPax.Tables(0).Rows(1)(2)

                    PubEdtRoom3 = dsLoadPax.Tables(0).Rows(2)(0)
                    PubEdtRoomType3 = dsLoadPax.Tables(0).Rows(2)(1)
                    PubEdtRoomQty3 = dsLoadPax.Tables(0).Rows(2)(2)

                    PubEdtRoom4 = dsLoadPax.Tables(0).Rows(3)(0)
                    PubEdtRoomType4 = dsLoadPax.Tables(0).Rows(3)(1)
                    PubEdtRoomQty4 = dsLoadPax.Tables(0).Rows(3)(2)

                    PubEdtRoom5 = dsLoadPax.Tables(0).Rows(4)(0)
                    PubEdtRoomType5 = dsLoadPax.Tables(0).Rows(4)(1)
                    PubEdtRoomQty5 = dsLoadPax.Tables(0).Rows(4)(2)

                    PubEdtRoom6 = dsLoadPax.Tables(0).Rows(5)(0)
                    PubEdtRoomType6 = dsLoadPax.Tables(0).Rows(5)(1)
                    PubEdtRoomQty6 = dsLoadPax.Tables(0).Rows(5)(2)

                    PubEdtRoom7 = dsLoadPax.Tables(0).Rows(6)(0)
                    PubEdtRoomType7 = dsLoadPax.Tables(0).Rows(6)(1)
                    PubEdtRoomQty7 = dsLoadPax.Tables(0).Rows(6)(2)

                    PubEdtRoom8 = dsLoadPax.Tables(0).Rows(7)(0)
                    PubEdtRoomType8 = dsLoadPax.Tables(0).Rows(7)(1)
                    PubEdtRoomQty8 = dsLoadPax.Tables(0).Rows(7)(2)

                    PubEdtRoom9 = dsLoadPax.Tables(0).Rows(8)(0)
                    PubEdtRoomType9 = dsLoadPax.Tables(0).Rows(8)(1)
                    PubEdtRoomQty9 = dsLoadPax.Tables(0).Rows(8)(2)


                End If


                If dsLoadPax.Tables(0).Rows.Count = 10 Then

                    PubEdtRoom1 = dsLoadPax.Tables(0).Rows(0)(0)
                    PubEdtRoomType1 = dsLoadPax.Tables(0).Rows(0)(1)
                    PubEdtRoomQty1 = dsLoadPax.Tables(0).Rows(0)(2)

                    PubEdtRoom2 = dsLoadPax.Tables(0).Rows(1)(0)
                    PubEdtRoomType2 = dsLoadPax.Tables(0).Rows(1)(1)
                    PubEdtRoomQty2 = dsLoadPax.Tables(0).Rows(1)(2)

                    PubEdtRoom3 = dsLoadPax.Tables(0).Rows(2)(0)
                    PubEdtRoomType3 = dsLoadPax.Tables(0).Rows(2)(1)
                    PubEdtRoomQty3 = dsLoadPax.Tables(0).Rows(2)(2)

                    PubEdtRoom4 = dsLoadPax.Tables(0).Rows(3)(0)
                    PubEdtRoomType4 = dsLoadPax.Tables(0).Rows(3)(1)
                    PubEdtRoomQty4 = dsLoadPax.Tables(0).Rows(3)(2)

                    PubEdtRoom5 = dsLoadPax.Tables(0).Rows(4)(0)
                    PubEdtRoomType5 = dsLoadPax.Tables(0).Rows(4)(1)
                    PubEdtRoomQty5 = dsLoadPax.Tables(0).Rows(4)(2)

                    PubEdtRoom6 = dsLoadPax.Tables(0).Rows(5)(0)
                    PubEdtRoomType6 = dsLoadPax.Tables(0).Rows(5)(1)
                    PubEdtRoomQty6 = dsLoadPax.Tables(0).Rows(5)(2)

                    PubEdtRoom7 = dsLoadPax.Tables(0).Rows(6)(0)
                    PubEdtRoomType7 = dsLoadPax.Tables(0).Rows(6)(1)
                    PubEdtRoomQty7 = dsLoadPax.Tables(0).Rows(6)(2)

                    PubEdtRoom8 = dsLoadPax.Tables(0).Rows(7)(0)
                    PubEdtRoomType8 = dsLoadPax.Tables(0).Rows(7)(1)
                    PubEdtRoomQty8 = dsLoadPax.Tables(0).Rows(7)(2)

                    PubEdtRoom9 = dsLoadPax.Tables(0).Rows(8)(0)
                    PubEdtRoomType9 = dsLoadPax.Tables(0).Rows(8)(1)
                    PubEdtRoomQty9 = dsLoadPax.Tables(0).Rows(8)(2)

                    PubEdtRoom10 = dsLoadPax.Tables(0).Rows(9)(0)
                    PubEdtRoomType10 = dsLoadPax.Tables(0).Rows(9)(1)
                    PubEdtRoomQty10 = dsLoadPax.Tables(0).Rows(9)(2)


                End If


            End If


            ' DeleteResRoomCount(dsShow.Tables(0).Rows(0).Item("ResNo"))

            '--------------------------

            txtadultcount.Text = dsShow.Tables(0).Rows(0).Item("AdultQty")
            PubEdtAdultQty = dsShow.Tables(0).Rows(0).Item("AdultQty")

            txtchildcount.Text = dsShow.Tables(0).Rows(0).Item("ChildrenQty")
            PubEdtChildrenQty = dsShow.Tables(0).Rows(0).Item("ChildrenQty")

            txtinfantcount.Text = dsShow.Tables(0).Rows(0).Item("InfantsQty")
            PubEdtInfantsQty = dsShow.Tables(0).Rows(0).Item("InfantsQty")


            txtcounttot.Text = Convert.ToInt16(txtadultcount.Text.Trim) + Convert.ToInt16(txtchildcount.Text.Trim) + Convert.ToInt16(txtinfantcount.Text.Trim)

            cmbMealplan.Text = dsShow.Tables(0).Rows(0).Item("MealPlan")
            PubEdtMealPlan = dsShow.Tables(0).Rows(0).Item("MealPlan")
            cmbMealplan.ClosePopup()


            LoadDiscounts()

            'LoadDiscountById(Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("DisPlanId")))

            'Dim disss As Integer = (dsShow.Tables(0).Rows(0).Item("DisPlanId"))

            'MessageBox.Show("displanid:" + disss)

            cmbDisscounts.EditValue = dsShow.Tables(0).Rows(0).Item("DisPlanId")




            'cmbDisscounts.EditValue = IIf(IsNothing(cmbDisscounts.GetColumnValue("DisID")), String.Empty, cmbDisscounts.GetColumnValue("DisID"))

            ' cmbDisscounts.EditValue = IIf(IsNothing(cmbDisscounts.GetColumnValue("DisID")), String.Empty, cmbDisscounts.GetColumnValue("DisID"))
            'PubEdtDisPlan = cmbDisscounts.Text






            'cmbOffers.EditValue = dsShow.Tables(0).Rows(0).Item("OfferId")
            'PubEdtOfferId = cmbOffers.Text
            'LoadAmentitesById(Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("AmenId")))
            cmbAmmenties.EditValue = dsShow.Tables(0).Rows(0).Item("AmenId")
            PubEdtAmenId = cmbAmmenties.Text

            gbBookingtype.Enabled = False

            txtRate.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("Rate"))
            PubEdtRate = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("Rate"))

            txtTotal.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("Total"))
            PubEdtTotal = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("Total"))

            cmbpaymode.Text = dsShow.Tables(0).Rows(0).Item("PayMode")
            PubEdtPayMode = dsShow.Tables(0).Rows(0).Item("PayMode")
            cmbpaymode.ClosePopup()

            DtExpiry.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("PayExpiryDate"))
            PubEdtPayExpiryDate = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("PayExpiryDate"))

            DtExpiry.ClosePopup()

            txtCCno.Text = dsShow.Tables(0).Rows(0).Item("PayCCNo")
            PubEdtPayCCNo = dsShow.Tables(0).Rows(0).Item("PayCCNo")


            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("PaymentStatus"))) Then

                txtPaymentStatus.Text = dsShow.Tables(0).Rows(0).Item("PaymentStatus")

            Else
                txtPaymentStatus.Text = ""

            End If





            txtguestlike.Text = dsShow.Tables(0).Rows(0).Item("Guestlikes")
            PubEdtGuestlikes = dsShow.Tables(0).Rows(0).Item("Guestlikes")

            txtguestdislike.Text = dsShow.Tables(0).Rows(0).Item("Guestdislikes")
            PubEdtGuestdislikes = dsShow.Tables(0).Rows(0).Item("Guestdislikes")

            txtBillinginst.Text = dsShow.Tables(0).Rows(0).Item("BillingInst")
            PubEdtBillingInst = dsShow.Tables(0).Rows(0).Item("BillingInst")

            txtRemarks.Text = dsShow.Tables(0).Rows(0).Item("Remarks")
            PubEdtRemarks = dsShow.Tables(0).Rows(0).Item("Remarks")

            txtRefno.Text = dsShow.Tables(0).Rows(0).Item("Refno")
            PubEdtRefno = dsShow.Tables(0).Rows(0).Item("Refno")





            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("Country"))) Then

                cmbCountry.Text = dsShow.Tables(0).Rows(0).Item("Country")
                cmbCountry.ClosePopup()

            Else
                cmbCountry.Text = ""

            End If



            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("Nationality"))) Then

                txtNationality.Text = dsShow.Tables(0).Rows(0).Item("Nationality")

            Else
                txtNationality.Text = ""

            End If





        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Function DSGetPaxDetails(ByVal Resno As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Dim daMain2 As New SqlDataAdapter
        Dim dsMain2 As New DataSet
        Dim dcSearch2 As New SqlCommand

        Dim Restype As String = ""

        Dim CurrentUser As String = CurrUser

        Dim dcInsertNewAcc As New SqlCommand

        Try
            Conn.Open()

            Dim getResno As String = Resno
            dcSearch = New SqlCommand("select Room,Roomtype,RoomCount from dbo.[Reservation.Room] where ReservationNo=@ReservationNo order by Room,Roomtype", Conn)
            dcSearch.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = getResno
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then

                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0

                    If CbTop.Checked = True Then
                        Restype = "TOP"
                    End If

                    If CbCompl.Checked = True Then
                        Restype = "COM"
                    End If

                    If CbFit.Checked = True Then
                        Restype = "FIT"
                    End If


                    dcInsertNewAcc = New SqlCommand("InsertResRoomTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                    dcInsertNewAcc.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = getResno
                    ' dcInsertNewAcc.Parameters.Add("@ReservationDate", SqlDbType.DateTime).Value = DtResdate.DateTime.Date


                    'Dim getresdate As DateTime = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)

                    dcInsertNewAcc.Parameters.Add("@ReservationDate", SqlDbType.DateTime).Value = DtResdate.DateTime.Date

                    dcInsertNewAcc.Parameters.Add("@ReservationType", SqlDbType.VarChar).Value = Restype
                    dcInsertNewAcc.Parameters.Add("@Room", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(0).ToString
                    dcInsertNewAcc.Parameters.Add("@Roomtype", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(1).ToString
                    dcInsertNewAcc.Parameters.Add("@RoomCount", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount)(2).ToString)
                    dcInsertNewAcc.Parameters.Add("@BedNights", SqlDbType.Int).Value = Convert.ToInt16(txtBednights.Text.Trim)
                    dcInsertNewAcc.Parameters.Add("@TotPax", SqlDbType.Int).Value = Convert.ToInt16(totPaxrooms.Text.Trim)





                    dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser


                    dcInsertNewAcc.ExecuteNonQuery()

                    DScount = DScount - 1
                End While
            End If

            dcSearch2 = New SqlCommand("select Room,Roomtype,RoomCount from dbo.[Reservation.Room.Temp] where ReservationNo=@ReservationNo", Conn)
            dcSearch2.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = getResno
            daMain2 = New SqlDataAdapter()
            daMain2.SelectCommand = dcSearch2
            daMain2.Fill(dsMain2)
            DSGetPaxDetails = dsMain2
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function
    Function DSGetPaxDetailsResMaster(ByVal Resno As String) As DataSet
        Dim Conn As New SqlConnection(ConnString)

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()

            Dim getResno As String = Resno
            dcSearch = New SqlCommand("select Room,Roomtype,RoomCount from dbo.[Reservation.Room] where ReservationNo=@ReservationNo order by Room,Roomtype", Conn)
            dcSearch.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = getResno
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSGetPaxDetailsResMaster = dsMain
            End If
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function

    Private Sub GviewReservation_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GviewReservation.DoubleClick

        ShowGridDets()

        gbBookingtype.Enabled = False
        gbArridep.Enabled = False
        gbPax1.Enabled = False
        gbpax2.Enabled = False
        gbpayment.Enabled = False
        gbOthers.Enabled = False
        DtResdate.Enabled = False
        txtGuesname.Enabled = False
        'cmbCountry.Enabled = False
        'txtNationality.Enabled = False
        ' txtEmail.Enabled = False

        gbpayment.Enabled = True
        gbOthers.Enabled = True
        btDel.Enabled = True


    End Sub
    Private Sub gcViewRoomCount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            gcViewRoomCount.DeleteRow(gcViewRoomCount.FocusedRowHandle)
        End If
        DeleteTempRoomCount(txtReservationno.Text.Trim)
    End Sub
    Private Sub DeleteResRoomCount(ByVal getResno As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Dim Resno As String = getResno

        dcInsertNewAcc = New SqlCommand("DeleteResRoomRates_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = Resno

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Private Sub DeleteTempRoomCount(ByVal getResno As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Dim Resno As String = getResno

        dcInsertNewAcc = New SqlCommand("DeleteTempRoomRates_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = Resno
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    'Private Sub DeleteTempRoomCountByUser(ByVal getResno As String)

    '    Dim Conn As New SqlConnection(ConnString)
    '    Dim dcInsertNewAcc As New SqlCommand

    '    Dim daMain As New SqlDataAdapter
    '    Dim dsMain As New DataSet
    '    Dim dcSearch As New SqlCommand

    '    Dim Resno As String = getResno

    '    dcInsertNewAcc = New SqlCommand("DeleteTempRoomRates_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
    '    dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = Resno
    '    Conn.Open()
    '    dcInsertNewAcc.ExecuteNonQuery()
    '    Conn.Close()

    'End Sub
    Private Sub DeleteTempRoomByRoom(ByVal getResno As String, ByVal getRoom As String, ByVal getRoomType As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Dim Resno As String = getResno
        Dim Room As String = getRoom
        Dim RoomType As String = getRoomType


        dcInsertNewAcc = New SqlCommand("DeleteTempbyRoom_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = Resno
        dcInsertNewAcc.Parameters.Add("@Room", SqlDbType.VarChar).Value = Room
        dcInsertNewAcc.Parameters.Add("@Type", SqlDbType.VarChar).Value = RoomType

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Sub UpdateReservationMaster()

        Try
            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim Restype As String = ""
            Dim Topcode As String = ""
            Dim Iscontract As Integer = 0
            Dim contractId As String = ""
            Dim getAdultcount As Integer = 0
            Dim getChildcount As Integer = 0
            Dim getInfantscount As Integer = 0


            Dim getArrdate As Date = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)

            Dim getDepdate As Date = Convert.ToDateTime(txtDepyear.Text + "/" + txtDepMonth.Text + "/" + txtDepDay.Text)




            '-----------------------------------------------------------------------------------
            If CbTop.Checked = True Then
                Restype = "TOP"
                Topcode = cbTopcode.GetColumnValue("TopCode")
            End If

            If CbCompl.Checked = True Then
                Restype = "COM"
                Topcode = ""
            End If

            If CbFit.Checked = True Then
                Restype = "FIT"
                Topcode = ""
            End If
            '-----------------------------------------------------------------------------------
            If PubIscontract = 1 Then
                Iscontract = 1
            Else
                Iscontract = 0
            End If

            '-----------------------------------------------------------------------------------
            If PubContractId = "" Then

                contractId = ""

            Else
                contractId = PubContractId

            End If
            '-----------------------------------------------------------------------------------

            If txtadultcount.Text.Trim = "" Then
                getAdultcount = 0
            Else
                getAdultcount = Convert.ToInt16(txtadultcount.Text.Trim)
            End If

            If txtchildcount.Text.Trim = "" Then
                getChildcount = 0
            Else
                getChildcount = Convert.ToInt16(txtchildcount.Text.Trim)
            End If


            If txtinfantcount.Text.Trim = "" Then
                getInfantscount = 0
            Else
                getInfantscount = Convert.ToInt16(txtinfantcount.Text.Trim)
            End If

            '-----------------------------------------------------------------------------------
            If PubEdtAdultQty <> getAdultcount Then
                InsertLogs(txtReservationno.Text.Trim, "PaxAdultQty", getAdultcount.ToString, PubEdtAdultQty)
            End If


            If PubEdtChildrenQty <> getChildcount Then
                InsertLogs(txtReservationno.Text.Trim, "PaxChildrentQty", getChildcount.ToString, PubEdtChildrenQty)
            End If

            If PubEdtInfantsQty <> getInfantscount Then
                InsertLogs(txtReservationno.Text.Trim, "PaxChildrentQty", getInfantscount.ToString, PubEdtInfantsQty)
            End If


            If PubEdtResDate <> DtResdate.DateTime.Date Then
                InsertLogs(txtReservationno.Text.Trim, "ReservationDate", DtResdate.DateTime.Date, PubEdtResDate)
            End If

            If PubEdtGuest <> txtGuesname.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "Guest", txtGuesname.Text.Trim, PubEdtGuest)
            End If


            'If PubEdtArrDate <> DtArrival.DateTime.Date Then
            If PubEdtArrDate <> getArrdate.Date Then
                ' InsertLogs(txtReservationno.Text.Trim, "ArrivalDate", DtArrival.DateTime.Date, PubEdtArrDate)
                InsertLogs(txtReservationno.Text.Trim, "ArrivalDate", getArrdate.Date, PubEdtArrDate)
            End If

            ' If PubEdtDepDate <> DtDep.DateTime.Date Then
            If PubEdtDepDate <> getDepdate.Date Then
                ' InsertLogs(txtReservationno.Text.Trim, "DepartureDate", DtDep.DateTime.Date, PubEdtDepDate)
                InsertLogs(txtReservationno.Text.Trim, "DepartureDate", getDepdate.Date, PubEdtDepDate)
            End If


            If PubEdtArrFlight <> cmbArriFlight.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "ArrivalFlight", cmbArriFlight.Text.Trim, PubEdtArrFlight)
            End If

            If PubEdtDepFlight <> cmbDepFlight.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "DepartureFlight", cmbDepFlight.Text.Trim, PubEdtDepFlight)
            End If

            If PubEdtArrTime <> txtArrTime.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "ArrivalFlightTime", txtArrTime.Text.Trim, PubEdtArrTime)
            End If

            If PubEdtDepTime <> txtDepTime.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "DepartureFlightTime", txtDepTime.Text.Trim, PubEdtDepTime)
            End If

            If PubEdtArrTrans <> cmbArrTrans.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "ArrivalTransfer", cmbArrTrans.Text.Trim, PubEdtArrTrans)
            End If

            If PubEdtDepTrans <> cmbDepTrans.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "DepartureTransfer", cmbDepTrans.Text.Trim, PubEdtDepTrans)
            End If


            If PubEdtMealPlan <> cmbMealplan.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "MealPlan", cmbMealplan.Text.Trim, PubEdtMealPlan)
            End If



            Dim newDisPlan As String = cmbDisscounts.Text.Trim

            If PubEdtDisPlan <> newDisPlan Then
                InsertLogs(txtReservationno.Text.Trim, "DiscountPlan", newDisPlan, PubEdtDisPlan)
            End If

            Dim newOfferPlan As String = cmbOffers.Text.Trim

            If PubEdtOfferId <> newOfferPlan Then
                InsertLogs(txtReservationno.Text.Trim, "Offers", newOfferPlan, PubEdtOfferId)
            End If

            Dim newAmentis As String = cmbAmmenties.Text.Trim

            If PubEdtAmenId <> newAmentis Then
                InsertLogs(txtReservationno.Text.Trim, "Amentities", newAmentis, PubEdtAmenId)
            End If

            If PubEdtRate <> Convert.ToDecimal(txtRate.Text.Trim) Then
                InsertLogs(txtReservationno.Text.Trim, "Rate", Convert.ToDecimal(txtRate.Text.Trim), PubEdtRate)
            End If

            If PubEdtTotal <> Convert.ToDecimal(txtTotal.Text.Trim) Then
                InsertLogs(txtReservationno.Text.Trim, "Total", Convert.ToDecimal(txtTotal.Text.Trim), PubEdtTotal)
            End If

            If PubEdtPayMode <> cmbpaymode.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "PayMode", cmbpaymode.Text.Trim, PubEdtPayMode)
            End If

            If PubEdtPayExpiryDate <> DtExpiry.DateTime.Date Then
                InsertLogs(txtReservationno.Text.Trim, "CCExpiryDate", DtExpiry.DateTime.Date, PubEdtPayExpiryDate)
            End If


            If PubEdtPayCCNo <> txtCCno.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "CCNo", txtCCno.Text.Trim, PubEdtPayCCNo)
            End If


            If PubEdtGuestlikes <> txtguestlike.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "GuestLikes", txtguestlike.Text.Trim, PubEdtGuestlikes)
            End If

            If PubEdtGuestdislikes <> txtguestlike.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "GuestDisLikes", txtguestlike.Text.Trim, PubEdtGuestdislikes)
            End If


            If PubEdtBillingInst <> txtBillinginst.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "BillingInstructions", txtBillinginst.Text.Trim, PubEdtBillingInst)
            End If

            If PubEdtRemarks <> txtRemarks.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "Remarks", txtRemarks.Text.Trim, PubEdtRemarks)
            End If


            If PubEdtRefno <> txtRefno.Text.Trim Then
                InsertLogs(txtReservationno.Text.Trim, "RefNo", txtRefno.Text.Trim, PubEdtRefno)
            End If



            '----------------------Check The Pax Room Detail Change----------------------------------------------------------

            Dim dsLoadPax As New DataSet

            dsLoadPax = DSGetPaxDetailsResMaster(txtReservationno.Text.Trim)

            If dsLoadPax IsNot Nothing Then

                If dsLoadPax.Tables(0).Rows.Count = 1 Then

                    If PubEdtRoom1 <> dsLoadPax.Tables(0).Rows(0)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(0)(0).ToString, PubEdtRoom1)
                    End If

                    If PubEdtRoomType1 <> dsLoadPax.Tables(0).Rows(0)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(0)(1).ToString, PubEdtRoomType1)
                    End If

                    If PubEdtRoomQty1 <> dsLoadPax.Tables(0).Rows(0)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(0)(2).ToString, PubEdtRoomQty1)
                    End If

                End If

                '--------------------------------------------------------------------------------------------------------------

                If dsLoadPax.Tables(0).Rows.Count = 2 Then

                    If PubEdtRoom1 <> dsLoadPax.Tables(0).Rows(0)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(0)(0).ToString, PubEdtRoom1)
                    End If

                    If PubEdtRoomType1 <> dsLoadPax.Tables(0).Rows(0)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(0)(1).ToString, PubEdtRoomType1)
                    End If

                    If PubEdtRoomQty1 <> dsLoadPax.Tables(0).Rows(0)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(0)(2).ToString, PubEdtRoomQty1)
                    End If

                    If PubEdtRoom2 <> dsLoadPax.Tables(0).Rows(1)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(1)(0).ToString, PubEdtRoom2)
                    End If

                    If PubEdtRoomType2 <> dsLoadPax.Tables(0).Rows(1)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(1)(1).ToString, PubEdtRoomType2)
                    End If

                    If PubEdtRoomQty2 <> dsLoadPax.Tables(0).Rows(1)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(1)(2).ToString, PubEdtRoomQty2)
                    End If

                End If


                '---------------------------------------------------------------------------------------------------------------

                If dsLoadPax.Tables(0).Rows.Count = 3 Then

                    If PubEdtRoom1 <> dsLoadPax.Tables(0).Rows(0)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(0)(0).ToString, PubEdtRoom1)
                    End If

                    If PubEdtRoomType1 <> dsLoadPax.Tables(0).Rows(0)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(0)(1).ToString, PubEdtRoomType1)
                    End If

                    If PubEdtRoomQty1 <> dsLoadPax.Tables(0).Rows(0)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(0)(2).ToString, PubEdtRoomQty1)
                    End If

                    If PubEdtRoom2 <> dsLoadPax.Tables(0).Rows(1)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(1)(0).ToString, PubEdtRoom2)
                    End If

                    If PubEdtRoomType2 <> dsLoadPax.Tables(0).Rows(1)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(1)(1).ToString, PubEdtRoomType2)
                    End If

                    If PubEdtRoomQty2 <> dsLoadPax.Tables(0).Rows(1)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(1)(2).ToString, PubEdtRoomQty2)
                    End If

                    If PubEdtRoom3 <> dsLoadPax.Tables(0).Rows(2)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(2)(0).ToString, PubEdtRoom3)
                    End If

                    If PubEdtRoomType3 <> dsLoadPax.Tables(0).Rows(2)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(2)(1).ToString, PubEdtRoomType3)
                    End If

                    If PubEdtRoomQty3 <> dsLoadPax.Tables(0).Rows(2)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(2)(2).ToString, PubEdtRoomQty3)
                    End If

                End If


                '-----------------------------------------------------------------------------------------------------------------

                If dsLoadPax.Tables(0).Rows.Count = 4 Then

                    If PubEdtRoom1 <> dsLoadPax.Tables(0).Rows(0)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(0)(0).ToString, PubEdtRoom1)
                    End If

                    If PubEdtRoomType1 <> dsLoadPax.Tables(0).Rows(0)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(0)(1).ToString, PubEdtRoomType1)
                    End If

                    If PubEdtRoomQty1 <> dsLoadPax.Tables(0).Rows(0)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(0)(2).ToString, PubEdtRoomQty1)
                    End If

                    If PubEdtRoom2 <> dsLoadPax.Tables(0).Rows(1)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(1)(0).ToString, PubEdtRoom2)
                    End If

                    If PubEdtRoomType2 <> dsLoadPax.Tables(0).Rows(1)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(1)(1).ToString, PubEdtRoomType2)
                    End If

                    If PubEdtRoomQty2 <> dsLoadPax.Tables(0).Rows(1)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(1)(2).ToString, PubEdtRoomQty2)
                    End If

                    If PubEdtRoom3 <> dsLoadPax.Tables(0).Rows(2)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(2)(0).ToString, PubEdtRoom3)
                    End If

                    If PubEdtRoomType3 <> dsLoadPax.Tables(0).Rows(2)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(2)(1).ToString, PubEdtRoomType3)
                    End If

                    If PubEdtRoomQty3 <> dsLoadPax.Tables(0).Rows(2)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(2)(2).ToString, PubEdtRoomQty3)
                    End If

                    If PubEdtRoom4 <> dsLoadPax.Tables(0).Rows(3)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(3)(0).ToString, PubEdtRoom4)
                    End If

                    If PubEdtRoomType4 <> dsLoadPax.Tables(0).Rows(3)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(3)(1).ToString, PubEdtRoomType4)
                    End If

                    If PubEdtRoomQty4 <> dsLoadPax.Tables(0).Rows(3)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(3)(2).ToString, PubEdtRoomQty4)
                    End If

                End If

                '---------------------------------------------------------------------------------------------------------------

                If dsLoadPax.Tables(0).Rows.Count = 5 Then

                    If PubEdtRoom1 <> dsLoadPax.Tables(0).Rows(0)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(0)(0).ToString, PubEdtRoom1)
                    End If

                    If PubEdtRoomType1 <> dsLoadPax.Tables(0).Rows(0)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(0)(1).ToString, PubEdtRoomType1)
                    End If

                    If PubEdtRoomQty1 <> dsLoadPax.Tables(0).Rows(0)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(0)(2).ToString, PubEdtRoomQty1)
                    End If

                    If PubEdtRoom2 <> dsLoadPax.Tables(0).Rows(1)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(1)(0).ToString, PubEdtRoom2)
                    End If

                    If PubEdtRoomType2 <> dsLoadPax.Tables(0).Rows(1)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(1)(1).ToString, PubEdtRoomType2)
                    End If

                    If PubEdtRoomQty2 <> dsLoadPax.Tables(0).Rows(1)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(1)(2).ToString, PubEdtRoomQty2)
                    End If

                    If PubEdtRoom3 <> dsLoadPax.Tables(0).Rows(2)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(2)(0).ToString, PubEdtRoom3)
                    End If

                    If PubEdtRoomType3 <> dsLoadPax.Tables(0).Rows(2)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(2)(1).ToString, PubEdtRoomType3)
                    End If

                    If PubEdtRoomQty3 <> dsLoadPax.Tables(0).Rows(2)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(2)(2).ToString, PubEdtRoomQty3)
                    End If

                    If PubEdtRoom4 <> dsLoadPax.Tables(0).Rows(3)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(3)(0).ToString, PubEdtRoom4)
                    End If

                    If PubEdtRoomType4 <> dsLoadPax.Tables(0).Rows(3)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(3)(1).ToString, PubEdtRoomType4)
                    End If

                    If PubEdtRoomQty4 <> dsLoadPax.Tables(0).Rows(3)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(3)(2).ToString, PubEdtRoomQty4)
                    End If

                    If PubEdtRoom5 <> dsLoadPax.Tables(0).Rows(4)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(4)(0).ToString, PubEdtRoom5)
                    End If

                    If PubEdtRoomType5 <> dsLoadPax.Tables(0).Rows(4)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(4)(1).ToString, PubEdtRoomType5)
                    End If

                    If PubEdtRoomQty5 <> dsLoadPax.Tables(0).Rows(4)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(4)(2).ToString, PubEdtRoomQty5)
                    End If

                End If


                '-------------------------------------------------------------------------------------------------------------------

                If dsLoadPax.Tables(0).Rows.Count = 6 Then

                    If PubEdtRoom1 <> dsLoadPax.Tables(0).Rows(0)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(0)(0).ToString, PubEdtRoom1)
                    End If

                    If PubEdtRoomType1 <> dsLoadPax.Tables(0).Rows(0)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(0)(1).ToString, PubEdtRoomType1)
                    End If

                    If PubEdtRoomQty1 <> dsLoadPax.Tables(0).Rows(0)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(0)(2).ToString, PubEdtRoomQty1)
                    End If

                    If PubEdtRoom2 <> dsLoadPax.Tables(0).Rows(1)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(1)(0).ToString, PubEdtRoom2)
                    End If

                    If PubEdtRoomType2 <> dsLoadPax.Tables(0).Rows(1)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(1)(1).ToString, PubEdtRoomType2)
                    End If

                    If PubEdtRoomQty2 <> dsLoadPax.Tables(0).Rows(1)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(1)(2).ToString, PubEdtRoomQty2)
                    End If

                    If PubEdtRoom3 <> dsLoadPax.Tables(0).Rows(2)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(2)(0).ToString, PubEdtRoom3)
                    End If

                    If PubEdtRoomType3 <> dsLoadPax.Tables(0).Rows(2)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(2)(1).ToString, PubEdtRoomType3)
                    End If

                    If PubEdtRoomQty3 <> dsLoadPax.Tables(0).Rows(2)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(2)(2).ToString, PubEdtRoomQty3)
                    End If

                    If PubEdtRoom4 <> dsLoadPax.Tables(0).Rows(3)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(3)(0).ToString, PubEdtRoom4)
                    End If

                    If PubEdtRoomType4 <> dsLoadPax.Tables(0).Rows(3)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(3)(1).ToString, PubEdtRoomType4)
                    End If

                    If PubEdtRoomQty4 <> dsLoadPax.Tables(0).Rows(3)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(3)(2).ToString, PubEdtRoomQty4)
                    End If

                    If PubEdtRoom5 <> dsLoadPax.Tables(0).Rows(4)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(4)(0).ToString, PubEdtRoom5)
                    End If

                    If PubEdtRoomType5 <> dsLoadPax.Tables(0).Rows(4)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(4)(1).ToString, PubEdtRoomType5)
                    End If

                    If PubEdtRoomQty5 <> dsLoadPax.Tables(0).Rows(4)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(4)(2).ToString, PubEdtRoomQty5)
                    End If

                    If PubEdtRoom6 <> dsLoadPax.Tables(0).Rows(5)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(5)(0).ToString, PubEdtRoom6)
                    End If

                    If PubEdtRoomType6 <> dsLoadPax.Tables(0).Rows(5)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(5)(1).ToString, PubEdtRoomType6)
                    End If

                    If PubEdtRoomQty6 <> dsLoadPax.Tables(0).Rows(5)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(5)(2).ToString, PubEdtRoomQty6)
                    End If

                End If

                '---------------------------------------------------------------------------------------------------------------

                If dsLoadPax.Tables(0).Rows.Count = 7 Then

                    If PubEdtRoom1 <> dsLoadPax.Tables(0).Rows(0)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(0)(0).ToString, PubEdtRoom1)
                    End If

                    If PubEdtRoomType1 <> dsLoadPax.Tables(0).Rows(0)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(0)(1).ToString, PubEdtRoomType1)
                    End If

                    If PubEdtRoomQty1 <> dsLoadPax.Tables(0).Rows(0)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(0)(2).ToString, PubEdtRoomQty1)
                    End If

                    If PubEdtRoom2 <> dsLoadPax.Tables(0).Rows(1)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(1)(0).ToString, PubEdtRoom2)
                    End If

                    If PubEdtRoomType2 <> dsLoadPax.Tables(0).Rows(1)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(1)(1).ToString, PubEdtRoomType2)
                    End If

                    If PubEdtRoomQty2 <> dsLoadPax.Tables(0).Rows(1)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(1)(2).ToString, PubEdtRoomQty2)
                    End If

                    If PubEdtRoom3 <> dsLoadPax.Tables(0).Rows(2)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(2)(0).ToString, PubEdtRoom3)
                    End If

                    If PubEdtRoomType3 <> dsLoadPax.Tables(0).Rows(2)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(2)(1).ToString, PubEdtRoomType3)
                    End If

                    If PubEdtRoomQty3 <> dsLoadPax.Tables(0).Rows(2)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(2)(2).ToString, PubEdtRoomQty3)
                    End If

                    If PubEdtRoom4 <> dsLoadPax.Tables(0).Rows(3)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(3)(0).ToString, PubEdtRoom4)
                    End If

                    If PubEdtRoomType4 <> dsLoadPax.Tables(0).Rows(3)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(3)(1).ToString, PubEdtRoomType4)
                    End If

                    If PubEdtRoomQty4 <> dsLoadPax.Tables(0).Rows(3)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(3)(2).ToString, PubEdtRoomQty4)
                    End If

                    If PubEdtRoom5 <> dsLoadPax.Tables(0).Rows(4)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(4)(0).ToString, PubEdtRoom5)
                    End If

                    If PubEdtRoomType5 <> dsLoadPax.Tables(0).Rows(4)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(4)(1).ToString, PubEdtRoomType5)
                    End If

                    If PubEdtRoomQty5 <> dsLoadPax.Tables(0).Rows(4)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(4)(2).ToString, PubEdtRoomQty5)
                    End If

                    If PubEdtRoom6 <> dsLoadPax.Tables(0).Rows(5)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(5)(0).ToString, PubEdtRoom6)
                    End If

                    If PubEdtRoomType6 <> dsLoadPax.Tables(0).Rows(5)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(5)(1).ToString, PubEdtRoomType6)
                    End If

                    If PubEdtRoomQty6 <> dsLoadPax.Tables(0).Rows(5)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(5)(2).ToString, PubEdtRoomQty6)
                    End If

                    If PubEdtRoom7 <> dsLoadPax.Tables(0).Rows(6)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(6)(0).ToString, PubEdtRoom7)
                    End If

                    If PubEdtRoomType7 <> dsLoadPax.Tables(0).Rows(6)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(6)(1).ToString, PubEdtRoomType7)
                    End If

                    If PubEdtRoomQty7 <> dsLoadPax.Tables(0).Rows(6)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(5)(2).ToString, PubEdtRoomQty7)
                    End If


                End If


                '------------------------------------------------------------------------------------------------------------------

                If dsLoadPax.Tables(0).Rows.Count = 8 Then

                    If PubEdtRoom1 <> dsLoadPax.Tables(0).Rows(0)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(0)(0).ToString, PubEdtRoom1)
                    End If

                    If PubEdtRoomType1 <> dsLoadPax.Tables(0).Rows(0)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(0)(1).ToString, PubEdtRoomType1)
                    End If

                    If PubEdtRoomQty1 <> dsLoadPax.Tables(0).Rows(0)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(0)(2).ToString, PubEdtRoomQty1)
                    End If

                    If PubEdtRoom2 <> dsLoadPax.Tables(0).Rows(1)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(1)(0).ToString, PubEdtRoom2)
                    End If

                    If PubEdtRoomType2 <> dsLoadPax.Tables(0).Rows(1)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(1)(1).ToString, PubEdtRoomType2)
                    End If

                    If PubEdtRoomQty2 <> dsLoadPax.Tables(0).Rows(1)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(1)(2).ToString, PubEdtRoomQty2)
                    End If

                    If PubEdtRoom3 <> dsLoadPax.Tables(0).Rows(2)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(2)(0).ToString, PubEdtRoom3)
                    End If

                    If PubEdtRoomType3 <> dsLoadPax.Tables(0).Rows(2)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(2)(1).ToString, PubEdtRoomType3)
                    End If

                    If PubEdtRoomQty3 <> dsLoadPax.Tables(0).Rows(2)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(2)(2).ToString, PubEdtRoomQty3)
                    End If

                    If PubEdtRoom4 <> dsLoadPax.Tables(0).Rows(3)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(3)(0).ToString, PubEdtRoom4)
                    End If

                    If PubEdtRoomType4 <> dsLoadPax.Tables(0).Rows(3)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(3)(1).ToString, PubEdtRoomType4)
                    End If

                    If PubEdtRoomQty4 <> dsLoadPax.Tables(0).Rows(3)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(3)(2).ToString, PubEdtRoomQty4)
                    End If

                    If PubEdtRoom5 <> dsLoadPax.Tables(0).Rows(4)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(4)(0).ToString, PubEdtRoom5)
                    End If

                    If PubEdtRoomType5 <> dsLoadPax.Tables(0).Rows(4)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(4)(1).ToString, PubEdtRoomType5)
                    End If

                    If PubEdtRoomQty5 <> dsLoadPax.Tables(0).Rows(4)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(4)(2).ToString, PubEdtRoomQty5)
                    End If

                    If PubEdtRoom6 <> dsLoadPax.Tables(0).Rows(5)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(5)(0).ToString, PubEdtRoom6)
                    End If

                    If PubEdtRoomType6 <> dsLoadPax.Tables(0).Rows(5)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(5)(1).ToString, PubEdtRoomType6)
                    End If

                    If PubEdtRoomQty6 <> dsLoadPax.Tables(0).Rows(5)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(5)(2).ToString, PubEdtRoomQty6)
                    End If

                    If PubEdtRoom7 <> dsLoadPax.Tables(0).Rows(6)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(6)(0).ToString, PubEdtRoom7)
                    End If

                    If PubEdtRoomType7 <> dsLoadPax.Tables(0).Rows(6)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(6)(1).ToString, PubEdtRoomType7)
                    End If

                    If PubEdtRoomQty7 <> dsLoadPax.Tables(0).Rows(6)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(6)(2).ToString, PubEdtRoomQty7)
                    End If

                    If PubEdtRoom8 <> dsLoadPax.Tables(0).Rows(7)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(7)(0).ToString, PubEdtRoom8)
                    End If

                    If PubEdtRoomType8 <> dsLoadPax.Tables(0).Rows(7)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(7)(1).ToString, PubEdtRoomType8)
                    End If

                    If PubEdtRoomQty8 <> dsLoadPax.Tables(0).Rows(7)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(7)(2).ToString, PubEdtRoomQty8)
                    End If

                End If


                '-------------------------------------------------------------------------------------------------------------------

                If dsLoadPax.Tables(0).Rows.Count = 9 Then

                    If PubEdtRoom1 <> dsLoadPax.Tables(0).Rows(0)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(0)(0).ToString, PubEdtRoom1)
                    End If

                    If PubEdtRoomType1 <> dsLoadPax.Tables(0).Rows(0)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(0)(1).ToString, PubEdtRoomType1)
                    End If

                    If PubEdtRoomQty1 <> dsLoadPax.Tables(0).Rows(0)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(0)(2).ToString, PubEdtRoomQty1)
                    End If

                    If PubEdtRoom2 <> dsLoadPax.Tables(0).Rows(1)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(1)(0).ToString, PubEdtRoom2)
                    End If

                    If PubEdtRoomType2 <> dsLoadPax.Tables(0).Rows(1)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(1)(1).ToString, PubEdtRoomType2)
                    End If

                    If PubEdtRoomQty2 <> dsLoadPax.Tables(0).Rows(1)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(1)(2).ToString, PubEdtRoomQty2)
                    End If

                    If PubEdtRoom3 <> dsLoadPax.Tables(0).Rows(2)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(2)(0).ToString, PubEdtRoom3)
                    End If

                    If PubEdtRoomType3 <> dsLoadPax.Tables(0).Rows(2)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(2)(1).ToString, PubEdtRoomType3)
                    End If

                    If PubEdtRoomQty3 <> dsLoadPax.Tables(0).Rows(2)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(2)(2).ToString, PubEdtRoomQty3)
                    End If

                    If PubEdtRoom4 <> dsLoadPax.Tables(0).Rows(3)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(3)(0).ToString, PubEdtRoom4)
                    End If

                    If PubEdtRoomType4 <> dsLoadPax.Tables(0).Rows(3)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(3)(1).ToString, PubEdtRoomType4)
                    End If

                    If PubEdtRoomQty4 <> dsLoadPax.Tables(0).Rows(3)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(3)(2).ToString, PubEdtRoomQty4)
                    End If

                    If PubEdtRoom5 <> dsLoadPax.Tables(0).Rows(4)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(4)(0).ToString, PubEdtRoom5)
                    End If

                    If PubEdtRoomType5 <> dsLoadPax.Tables(0).Rows(4)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(4)(1).ToString, PubEdtRoomType5)
                    End If

                    If PubEdtRoomQty5 <> dsLoadPax.Tables(0).Rows(4)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(4)(2).ToString, PubEdtRoomQty5)
                    End If

                    If PubEdtRoom6 <> dsLoadPax.Tables(0).Rows(5)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(5)(0).ToString, PubEdtRoom6)
                    End If

                    If PubEdtRoomType6 <> dsLoadPax.Tables(0).Rows(5)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(5)(1).ToString, PubEdtRoomType6)
                    End If

                    If PubEdtRoomQty6 <> dsLoadPax.Tables(0).Rows(5)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(5)(2).ToString, PubEdtRoomQty6)
                    End If

                    If PubEdtRoom7 <> dsLoadPax.Tables(0).Rows(6)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(6)(0).ToString, PubEdtRoom7)
                    End If

                    If PubEdtRoomType7 <> dsLoadPax.Tables(0).Rows(6)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(6)(1).ToString, PubEdtRoomType7)
                    End If

                    If PubEdtRoomQty7 <> dsLoadPax.Tables(0).Rows(6)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(6)(2).ToString, PubEdtRoomQty7)
                    End If

                    If PubEdtRoom8 <> dsLoadPax.Tables(0).Rows(7)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(7)(0).ToString, PubEdtRoom8)
                    End If

                    If PubEdtRoomType8 <> dsLoadPax.Tables(0).Rows(7)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(7)(1).ToString, PubEdtRoomType8)
                    End If

                    If PubEdtRoomQty8 <> dsLoadPax.Tables(0).Rows(7)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(7)(2).ToString, PubEdtRoomQty8)
                    End If

                    If PubEdtRoom9 <> dsLoadPax.Tables(0).Rows(8)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(8)(0).ToString, PubEdtRoom9)
                    End If

                    If PubEdtRoomType9 <> dsLoadPax.Tables(0).Rows(8)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(8)(1).ToString, PubEdtRoomType9)
                    End If

                    If PubEdtRoomQty9 <> dsLoadPax.Tables(0).Rows(8)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(8)(2).ToString, PubEdtRoomQty9)
                    End If


                End If

                '----------------------------------------------------------------------------------------------------------------------

                If dsLoadPax.Tables(0).Rows.Count = 10 Then

                    If PubEdtRoom1 <> dsLoadPax.Tables(0).Rows(0)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(0)(0).ToString, PubEdtRoom1)
                    End If

                    If PubEdtRoomType1 <> dsLoadPax.Tables(0).Rows(0)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(0)(1).ToString, PubEdtRoomType1)
                    End If

                    If PubEdtRoomQty1 <> dsLoadPax.Tables(0).Rows(0)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(0)(2).ToString, PubEdtRoomQty1)
                    End If

                    If PubEdtRoom2 <> dsLoadPax.Tables(0).Rows(1)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(1)(0).ToString, PubEdtRoom2)
                    End If

                    If PubEdtRoomType2 <> dsLoadPax.Tables(0).Rows(1)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(1)(1).ToString, PubEdtRoomType2)
                    End If

                    If PubEdtRoomQty2 <> dsLoadPax.Tables(0).Rows(1)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(1)(2).ToString, PubEdtRoomQty2)
                    End If

                    If PubEdtRoom3 <> dsLoadPax.Tables(0).Rows(2)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(2)(0).ToString, PubEdtRoom3)
                    End If

                    If PubEdtRoomType3 <> dsLoadPax.Tables(0).Rows(2)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(2)(1).ToString, PubEdtRoomType3)
                    End If

                    If PubEdtRoomQty3 <> dsLoadPax.Tables(0).Rows(2)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(2)(2).ToString, PubEdtRoomQty3)
                    End If

                    If PubEdtRoom4 <> dsLoadPax.Tables(0).Rows(3)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(3)(0).ToString, PubEdtRoom4)
                    End If

                    If PubEdtRoomType4 <> dsLoadPax.Tables(0).Rows(3)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(3)(1).ToString, PubEdtRoomType4)
                    End If

                    If PubEdtRoomQty4 <> dsLoadPax.Tables(0).Rows(3)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(3)(2).ToString, PubEdtRoomQty4)
                    End If

                    If PubEdtRoom5 <> dsLoadPax.Tables(0).Rows(4)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(4)(0).ToString, PubEdtRoom5)
                    End If

                    If PubEdtRoomType5 <> dsLoadPax.Tables(0).Rows(4)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(4)(1).ToString, PubEdtRoomType5)
                    End If

                    If PubEdtRoomQty5 <> dsLoadPax.Tables(0).Rows(4)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(4)(2).ToString, PubEdtRoomQty5)
                    End If

                    If PubEdtRoom6 <> dsLoadPax.Tables(0).Rows(5)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(5)(0).ToString, PubEdtRoom6)
                    End If

                    If PubEdtRoomType6 <> dsLoadPax.Tables(0).Rows(5)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(5)(1).ToString, PubEdtRoomType6)
                    End If

                    If PubEdtRoomQty6 <> dsLoadPax.Tables(0).Rows(5)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(5)(2).ToString, PubEdtRoomQty6)
                    End If

                    If PubEdtRoom7 <> dsLoadPax.Tables(0).Rows(6)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(6)(0).ToString, PubEdtRoom7)
                    End If

                    If PubEdtRoomType7 <> dsLoadPax.Tables(0).Rows(6)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(6)(1).ToString, PubEdtRoomType7)
                    End If

                    If PubEdtRoomQty7 <> dsLoadPax.Tables(0).Rows(6)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(6)(2).ToString, PubEdtRoomQty7)
                    End If

                    If PubEdtRoom8 <> dsLoadPax.Tables(0).Rows(7)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(7)(0).ToString, PubEdtRoom8)
                    End If

                    If PubEdtRoomType8 <> dsLoadPax.Tables(0).Rows(7)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(7)(1).ToString, PubEdtRoomType8)
                    End If

                    If PubEdtRoomQty8 <> dsLoadPax.Tables(0).Rows(7)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(7)(2).ToString, PubEdtRoomQty8)
                    End If

                    If PubEdtRoom9 <> dsLoadPax.Tables(0).Rows(8)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(8)(0).ToString, PubEdtRoom9)
                    End If

                    If PubEdtRoomType9 <> dsLoadPax.Tables(0).Rows(8)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(8)(1).ToString, PubEdtRoomType9)
                    End If

                    If PubEdtRoomQty9 <> dsLoadPax.Tables(0).Rows(8)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(8)(2).ToString, PubEdtRoomQty9)
                    End If

                    If PubEdtRoom10 <> dsLoadPax.Tables(0).Rows(9)(0).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "Room", dsLoadPax.Tables(0).Rows(9)(0).ToString, PubEdtRoom10)
                    End If

                    If PubEdtRoomType10 <> dsLoadPax.Tables(0).Rows(9)(1).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomType", dsLoadPax.Tables(0).Rows(9)(1).ToString, PubEdtRoomType10)
                    End If

                    If PubEdtRoomQty10 <> dsLoadPax.Tables(0).Rows(9)(2).ToString Then
                        InsertLogs(txtReservationno.Text.Trim, "RoomCount", dsLoadPax.Tables(0).Rows(9)(2).ToString, PubEdtRoomQty10)
                    End If


                End If


            End If
            '-------------------------------------------------------------------------------------------------------------------

            dcInsertNewAcc = New SqlCommand("UpdateResMaster_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = txtReservationno.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = DtResdate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@Guest", SqlDbType.VarChar).Value = txtGuesname.Text.Trim

            'dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = DtArrival.DateTime.Date
            'dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = DtDep.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = getArrdate.Date
            dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = getDepdate.Date

            dcInsertNewAcc.Parameters.Add("@ArrFlight", SqlDbType.VarChar).Value = cmbArriFlight.Text.Trim
            dcInsertNewAcc.Parameters.Add("@DepFlight", SqlDbType.VarChar).Value = cmbDepFlight.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ArrTime", SqlDbType.VarChar).Value = txtArrTime.Text.Trim
            dcInsertNewAcc.Parameters.Add("@DepTime", SqlDbType.VarChar).Value = txtDepTime.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ArrTrans", SqlDbType.VarChar).Value = cmbArrTrans.Text.Trim
            dcInsertNewAcc.Parameters.Add("@DepTrans", SqlDbType.VarChar).Value = cmbDepTrans.Text.Trim

            dcInsertNewAcc.Parameters.Add("@PaxId", SqlDbType.VarChar).Value = PubPaxId

            dcInsertNewAcc.Parameters.Add("@AdultQty", SqlDbType.Int).Value = getAdultcount
            dcInsertNewAcc.Parameters.Add("@ChildrenQty", SqlDbType.Int).Value = getChildcount
            dcInsertNewAcc.Parameters.Add("@InfantsQty", SqlDbType.Int).Value = getInfantscount
            dcInsertNewAcc.Parameters.Add("@MealPlan", SqlDbType.VarChar).Value = cmbMealplan.Text.Trim
            dcInsertNewAcc.Parameters.Add("@BedNights", SqlDbType.Int).Value = Convert.ToInt16(txtBednights.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRate.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@DisPlanId", SqlDbType.Int).Value = PubDisID
            dcInsertNewAcc.Parameters.Add("@OfferId", SqlDbType.Int).Value = PubOffID
            dcInsertNewAcc.Parameters.Add("@AmenId", SqlDbType.Int).Value = PubAmentID
            dcInsertNewAcc.Parameters.Add("@Total", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotal.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@PayMode", SqlDbType.VarChar).Value = cmbpaymode.Text.Trim
            dcInsertNewAcc.Parameters.Add("@PayExpiryDate", SqlDbType.DateTime).Value = DtExpiry.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@PayCCNo", SqlDbType.VarChar).Value = txtCCno.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Guestlikes", SqlDbType.VarChar).Value = txtguestlike.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Guestdislikes", SqlDbType.VarChar).Value = txtguestdislike.Text.Trim
            dcInsertNewAcc.Parameters.Add("@BillingInst", SqlDbType.VarChar).Value = txtBillinginst.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = txtRemarks.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Refno", SqlDbType.VarChar).Value = txtRefno.Text.Trim


            dcInsertNewAcc.Parameters.Add("@ArrTransTime", SqlDbType.VarChar).Value = cmbArrTransTime.Text.Trim
            dcInsertNewAcc.Parameters.Add("@DepTransTime", SqlDbType.VarChar).Value = cmbDepTransTime.Text.Trim

            dcInsertNewAcc.Parameters.Add("@Country", SqlDbType.VarChar).Value = cmbCountry.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Nationality", SqlDbType.VarChar).Value = txtNationality.Text.Trim

            dcInsertNewAcc.Parameters.Add("@ResType", SqlDbType.VarChar).Value = Restype
            dcInsertNewAcc.Parameters.Add("@Topcode", SqlDbType.VarChar).Value = Topcode

            dcInsertNewAcc.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text.Trim


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Reservation Details Updated Successfully", "Update Reservation Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Reservation", "Edit")

        If CheckAccess = True Then


            If CheckPerformaCreated() = False Then


                If String.Compare(btEdit.Text, "Edit", False) = 0 Then


                    gbBookingtype.Enabled = True
                    DtResdate.Enabled = True
                    txtGuesname.Enabled = True
                    gbArridep.Enabled = True
                    gbPax1.Enabled = True
                    gbpax2.Enabled = True
                    gbpayment.Enabled = True
                    gbOthers.Enabled = True
                    'cmbCountry.Enabled = True
                    'txtNationality.Enabled = True
                    'txtEmail.Enabled = True

                    PubDoEdit = 1

                    btEdit.Text = "Update"
                    btAdd.Enabled = False
                    btDel.Enabled = False

                    ' tabReservation.SelectedTabPageIndex = 1

                Else
                    If FieldValidation() = False Then
                        MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                        Exit Sub
                    Else
                        Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Reservation Details", "Update Reservation Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If bt = Windows.Forms.DialogResult.Yes Then

                            InsertResRoomCount()
                            UpdateReservationMaster()
                            DeleteTempRoomCount(txtReservationno.Text.Trim)


                        End If

                    End If

                    LoadGrid()

                    btEdit.Text = "Edit"
                    btAdd.Enabled = True
                    btDel.Enabled = True
                    tabReservation.TabPages(1).PageEnabled = False
                    tabReservation.SelectedTabPageIndex = 0
                    Exit Sub
                End If



            Else



                '-----------------------------------------------------------------------

                If String.Compare(btEdit.Text, "Edit", False) = 0 Then


                    MsgBox("You are not allowed to Edit.Performa Is Created For This Reservation No", MsgBoxStyle.Critical, ErrTitle)

                    gbArridep.Enabled = True
                    gbpayment.Enabled = True
                    gbOthers.Enabled = True


                    cmbArrType.Enabled = False
                    cmbDepType.Enabled = False
                    txtArrDay.Enabled = False
                    txtArrMonth.Enabled = False
                    txtArryear.Enabled = False

                    txtDepDay.Enabled = False
                    txtDepMonth.Enabled = False
                    txtDepyear.Enabled = False

                    btGetFlightArr.Enabled = True
                    btGetFlights.Enabled = True
                    cmbArriFlight.Enabled = True
                    txtOtherArr.Enabled = True
                    cmbDepFlight.Enabled = True
                    txtOtherDep.Enabled = True
                    txtArrTime.Enabled = True
                    txtDepTime.Enabled = True

                    PubDoEdit = 1

                    btEdit.Text = "Update"
                    btAdd.Enabled = False
                    btDel.Enabled = False

                    ' tabReservation.SelectedTabPageIndex = 1

                Else
                    'If FieldValidation() = False Then
                    '    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    '    Exit Sub
                    'Else
                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Update Flight Details", "Update Flight Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then

                        'InsertResRoomCount()
                        UpdateReservationMaster()
                        'DeleteTempRoomCount(txtReservationno.Text.Trim)


                        'End If

                End If

                LoadGrid()

                btEdit.Text = "Edit"
                btAdd.Enabled = True
                btDel.Enabled = True
                tabReservation.TabPages(1).PageEnabled = False
                tabReservation.SelectedTabPageIndex = 0
                Exit Sub
            End If





            '------------------------------------------------------------------------





            Exit Sub


        End If



        Else

        MsgBox("You Do Not Have Access")


        End If

    End Sub
    Function CheckPerformaCreated() As Boolean


        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getResno As String = txtReservationno.Text.Trim

            Conn.Open()
            dcSearch = New SqlCommand("select IsProformaCreated from dbo.[Reservation.Master] where ResNo=@ResNo and Status='OPEN'", Conn)

            dcSearch.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = getResno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            Dim GetPerformaStatus As Integer = 2

            If dsMain.Tables(0).Rows.Count > 0 Then


                GetPerformaStatus = Convert.ToInt16(dsMain.Tables(0).Rows(0)(0).ToString)


                If GetPerformaStatus = 1 Then

                    Return True


                Else

                    Return False

                End If





            Else

                MessageBox.Show("Invalid Reservation No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)


            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Function
    Function GetRoomCountByType() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Conn.Open()
            dcSearch = New SqlCommand("select COUNT(*) from dbo.[Rooms.Master] where Category=@Category and IsInactive='0'", Conn)
            dcSearch.Parameters.Add("@Category", SqlDbType.VarChar).Value = cmbRoom.Text.Trim


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                GetRoomCountByType = dsMain
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
    Function GetRoomCountByReservation() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Dim CurrentUser As String = CurrUser


            Dim getArrdate As Date = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)

            Dim getDepdate As Date = Convert.ToDateTime(txtDepyear.Text + "/" + txtDepMonth.Text + "/" + txtDepDay.Text)



            Conn.Open()
            dcSearch = New SqlCommand("SelectRoomCountRes_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = DtResdate.DateTime.Date
            'dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = DtArrival.DateTime.Date
            'dcSearch.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = DtDep.DateTime.Date

            dcSearch.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = getArrdate.Date
            dcSearch.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = getDepdate.Date

            dcSearch.Parameters.Add("@Room", SqlDbType.VarChar).Value = cmbRoom.Text.Trim
            dcSearch.Parameters.Add("@Userid", SqlDbType.VarChar).Value = CurrentUser

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                GetRoomCountByReservation = dsMain
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

    Function GetReservationCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "Reservation"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output

            dcGetCode.ExecuteNonQuery()

            GetReservationCode = dcGetCode.Parameters("@Currcode").Value


            Return GetReservationCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function

    Private Sub cmbArriFlight_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArriFlight.SelectedIndexChanged
        LoadFlightArrivalTime()
    End Sub

    Private Sub cmbOffers_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOffers.EditValueChanged
        PubOffID = IIf(IsNothing(cmbOffers.GetColumnValue("OfferID")), String.Empty, cmbOffers.GetColumnValue("OfferID"))
    End Sub

    Private Sub cmbArrType_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbArrType.SelectedValueChanged
        If cmbArrType.Text.Trim = "Other" Then
            lblArrivalFlight.Text = "Source"
            cmbArriFlight.Visible = False
            txtOtherArr.Visible = True
            'txtArrTime.Properties.ReadOnly = False
            txtArrTime.Text = "00:00"



        Else
            lblArrivalFlight.Text = "Flight"
            cmbArriFlight.Visible = True
            txtOtherArr.Visible = False
            ' txtArrTime.Properties.ReadOnly = True
        End If
    End Sub
    Private Sub cmbDepType_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepType.SelectedValueChanged

        If cmbDepType.Text.Trim = "Other" Then
            lblDepFlight.Text = "Source"
            cmbDepFlight.Visible = False
            txtOtherDep.Visible = True
            'txtDepTime.Properties.ReadOnly = False
            txtDepTime.Text = "00:00"

        Else

            lblDepFlight.Text = "Flight"
            cmbDepFlight.Visible = True
            txtOtherDep.Visible = False
            'txtDepTime.Properties.ReadOnly = True

        End If
    End Sub
    Private Sub txtRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.cmbDisscounts.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub btPendingApp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPendingApp.Click
        gcReservation.DataSource = Nothing
        LoadGridPendingDis()
    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Reservation", "Delete")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Delete This Reservation Details", "Delete Reservation Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveReservation()


                End If
                LoadGrid()
                tabReservation.TabPages(1).PageEnabled = False
                tabReservation.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Private Sub InactiveReservation()

        Dim CurrentUser As String = CurrUser

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        dcInsertNewAcc = New SqlCommand("InactiveReservation_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = txtReservationno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@UserId", SqlDbType.VarChar).Value = CurrentUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Reservation Details Deleted Successfully", "Delete Reservation Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Conn.Close()
    End Sub



    Private Sub btApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btApprove.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Reservation", "Approve")

        If CheckAccess = True Then



            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Approve Disscount Details", "Approve/Reject Discount Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    ApproveDisscount()


                Else

                    RejectDisscount()


                End If
                LoadGridPendingDis()
                tabReservation.TabPages(1).PageEnabled = False
                tabReservation.SelectedTabPageIndex = 0

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub ApproveDisscount()


        Dim ConnSt As String = ConnString
        Dim Conn As New SqlConnection(ConnSt)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("ApproveDiscount_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = GviewReservation.GetRowCellValue(GviewReservation.FocusedRowHandle, "ResNo")
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("You Have Approved The Discount", "Approve/Reject Discount Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Conn.Close()
    End Sub
    Private Sub RejectDisscount()


        Dim ConnSt As String = ConnString
        Dim Conn As New SqlConnection(ConnSt)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("RejectDiscount_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = GviewReservation.GetRowCellValue(GviewReservation.FocusedRowHandle, "ResNo")
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("You Have Rejected The Discount", "Approve/Reject Discount Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Conn.Close()
    End Sub
    Private Sub btDelRoomcount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelRoomcount.Click
        Try
            If PubDoEdit = 1 Then

                Dim dscheckRoomAddbefore As New DataSet
                dscheckRoomAddbefore = DSCheckAddResRoomMaster()


                If dscheckRoomAddbefore.Tables(0).Rows(0)(0) Is DBNull.Value Then
                    Exit Sub
                Else
                    If dscheckRoomAddbefore.Tables(0).Rows.Count > 0 Then

                        Dim dsLoadMasPaX As New DataSet
                        dsLoadMasPaX = DSGetPaxDetails(txtReservationno.Text.Trim)
                        DeleteResRoomCount(txtReservationno.Text.Trim)

                    End If
                End If

            End If

            gbpax2.Enabled = True
            DeleteTempRoomByRoom(txtReservationno.Text.Trim, gcViewRoomCount.GetRowCellValue(gcViewRoomCount.FocusedRowHandle, "Room"), gcViewRoomCount.GetRowCellValue(gcViewRoomCount.FocusedRowHandle, "Roomtype"))
            gcRoomcount.DataSource = Nothing
            LoadResRoomDetails()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        End Try
    End Sub
    Private Sub InsertLogs(ByVal Refno As String, ByVal EditField As String, ByVal EditValue As String, ByVal PreValue As String)

        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getRefno As String = Refno
            Dim getEditField As String = EditField
            Dim getEditValue As String = EditValue
            Dim getPreValue As String = PreValue
            Dim CurrentUser As String = CurrUser

            dcInsertNewAcc = New SqlCommand("InsertLogs_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@LogType", SqlDbType.VarChar).Value = "Res_Edit"
            dcInsertNewAcc.Parameters.Add("@Refno", SqlDbType.VarChar).Value = getRefno
            dcInsertNewAcc.Parameters.Add("@EditField", SqlDbType.VarChar).Value = getEditField
            dcInsertNewAcc.Parameters.Add("@EditValue", SqlDbType.VarChar).Value = getEditValue
            dcInsertNewAcc.Parameters.Add("@PreValue", SqlDbType.VarChar).Value = getPreValue
            dcInsertNewAcc.Parameters.Add("@Updatedby", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub cbTopcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If PubIsEdit = "EDIT" Then
            Exit Sub
        Else

            PubContractId = ""

            'LoadTopName(cbTopcode.Text)

            CbFit.Checked = False
            CbCompl.Checked = False

            Dim dscheckAddbefore As New DataSet
            dscheckAddbefore = DSContractDetailsTopWise()

            If dscheckAddbefore Is Nothing Then
                'MessageBox.Show("No active contracts with selected Tour Operator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                gbArridep.Enabled = True
                PubResType = "RATENOCON"


            Else
                'txtRate.Properties.ReadOnly = True
                PubResType = "RATECON"
                PubIscontract = 1

                Dim ConSDate As DateTime = Convert.ToDateTime(dscheckAddbefore.Tables(0).Rows(0)(4).ToString)
                Dim ConEDate As DateTime = Convert.ToDateTime(dscheckAddbefore.Tables(0).Rows(0)(5).ToString)
                PubContractId = dscheckAddbefore.Tables(0).Rows(0)(0).ToString


                If DtResdate.DateTime.Date >= ConSDate And DtResdate.DateTime.Date <= ConEDate Then
                    If CbTop.Checked = True Then
                        gbArridep.Enabled = True
                    Else
                        '  gbArridep.Enabled = False
                    End If

                Else
                    'MessageBox.Show("Reservation Date is not with in the Active Contract Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    ' cbTopcode.SelectedIndex = cbTopcode.SelectedIndex + 1
                    'gbArridep.Enabled = False
                End If

            End If

        End If

    End Sub

    Private Sub frmReservation_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub frmReservation_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        'Dim dscheckRoomAddbefore As New DataSet
        'dscheckRoomAddbefore = DSCheckAddResRoomMaster()
        'If dscheckRoomAddbefore.Tables(0).Rows(0)(0) Is DBNull.Value And dscheckRoomAddbefore.Tables(0).Rows.Count = 0 Then
        '    InsertResRoomCount()
        '    DeleteTempRoomCount(txtReservationno.Text.Trim)
        'End If
    End Sub
    Private Sub GetBedNigts()

        Dim inDtArr As DateTime = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)

        'Dim inTimeArr As DateTime = Convert.ToDateTime(txtArrTime.Text.Trim)
        'Dim OriArrTime As DateTime = inDtArr.AddTicks(inTimeArr.Ticks)


        Dim inDtDep As DateTime = Convert.ToDateTime(txtDepyear.Text + "/" + txtDepMonth.Text + "/" + txtDepDay.Text)

        'Dim inTimeDep As DateTime = Convert.ToDateTime(txtDepTime.Text.Trim)
        'Dim OriDepTime As DateTime = inDtDep.AddTicks(inTimeDep.Ticks)

        'Dim theDays As Integer = OriDepTime.Subtract(OriArrTime).TotalDays

        Dim theDays As Integer = DateDiff(DateInterval.Day, inDtArr, inDtDep)


        txtBednights.Text = theDays.ToString
    End Sub

    Private Sub cmbMealplan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMealplan.EditValueChanged
        ' GetBedNigts()
    End Sub

    Private Sub cmbMealplan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMealplan.SelectedIndexChanged
        ' GetBedNigts()
    End Sub

    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btGetFlights_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGetFlights.Click

        Dim getArrdate As Date = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)

        Dim getDepdate As Date = Convert.ToDateTime(txtDepyear.Text + "/" + txtDepMonth.Text + "/" + txtDepDay.Text)

        If getArrdate > getDepdate Then
            MessageBox.Show("Departure date can not be less than the arrival", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            gbPax.Enabled = False
            Exit Sub
        Else


            If CheckPerformaCreated() = False Then



                gbPax.Enabled = True
                DepDateChange()
                cmbDepFlight.Focus()


            Else

                DepDateChange()
                cmbDepFlight.Focus()



            End If


            End If



    End Sub

    Private Sub btGetFlightArr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGetFlightArr.Click

        Dim getArrdate As Date = Convert.ToDateTime(txtArryear.Text + "/" + txtArrMonth.Text + "/" + txtArrDay.Text)

        If getArrdate < DtToday.DateTime.Date Then
            MessageBox.Show("You can not do backdated reservations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            gbPax.Enabled = False
            Exit Sub

        Else
            gbPax.Enabled = True
            ArriDateChange()
            cmbArriFlight.Focus()

        End If




    End Sub

    Private Sub btViewTopRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewTopRef.Click
        gcReservation.DataSource = Nothing
        LoadGridbyTopRes()
    End Sub
    Private Sub btgetTopallDis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btgetTopallDis.Click
        LoadDiscountsTopALL()
    End Sub

    Private Sub cbTopcode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTopcode.EditValueChanged
        If PubIsEdit = "EDIT" Then
            Exit Sub
        Else

            PubContractId = ""

            ' LoadTopName(cbTopcode.Text)

            CbFit.Checked = False
            CbCompl.Checked = False

            Dim dscheckAddbefore As New DataSet
            dscheckAddbefore = DSContractDetailsTopWise()

            If dscheckAddbefore Is Nothing Then
                'MessageBox.Show("No active contracts with selected Tour Operator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                ' gbArridep.Enabled = True
                PubResType = "RATENOCON"


            Else
                'txtRate.Properties.ReadOnly = True
                PubResType = "RATECON"
                PubIscontract = 1

                Dim ConSDate As DateTime = Convert.ToDateTime(dscheckAddbefore.Tables(0).Rows(0)(4).ToString)
                Dim ConEDate As DateTime = Convert.ToDateTime(dscheckAddbefore.Tables(0).Rows(0)(5).ToString)
                PubContractId = dscheckAddbefore.Tables(0).Rows(0)(0).ToString


                If DtResdate.DateTime.Date >= ConSDate And DtResdate.DateTime.Date <= ConEDate Then
                    If CbTop.Checked = True Then
                        'gbArridep.Enabled = True
                    Else
                        ' gbArridep.Enabled = False
                    End If

                Else

                    ' gbArridep.Enabled = False
                End If

            End If

        End If
    End Sub

    Private Sub txtGuesname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuesname.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtGuesname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuesname.Enter

    End Sub
    Private Sub txtGuesname_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGuesname.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtGuesname.Text <> "" Then

                cmbCountry.Focus()


            End If


        End If
    End Sub

    Private Sub frmReservation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then


            If btAdd.Text = "Add" Then
                btAdd_Click(sender, New System.EventArgs())
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If


    End Sub

    Private Sub frmReservation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        MessageBox.Show("Enter")
    End Sub



    Private Sub TextEdit1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then

        End If




    End Sub
    Private Sub txtMonth_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtArrMonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtArrMonth.Text = "" Then
                MsgBox("Enter Month")
            ElseIf Convert.ToInt16(txtArrMonth.Text.Trim) >= 13 Then
                MsgBox("Invalid Month")

            Else
                txtArryear.Focus()
            End If


        End If

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtArrMonth_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArrMonth.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then

            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtArrDay_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArrDay.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtArryear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArryear.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtDepMonth_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDepMonth.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtDepDay_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDepDay.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtDepyear_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDepyear.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtArrDay_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtArrDay.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtArrDay.Text = "" Then
                MsgBox("Enter Day")
            ElseIf Convert.ToInt16(txtArrDay.Text.Trim) > 31 Then
                MsgBox("Invalid Day")

            Else
                txtArrMonth.Focus()
            End If
        End If
    End Sub

    Private Sub txtArryear_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtArryear.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtArryear.Text = "" Then
                MsgBox("Enter Year")
            Else
                If cmbArrType.Text = "Flight" Then
                    btGetFlightArr.Focus()
                Else
                    txtOtherArr.Focus()
                End If

            End If
        End If
    End Sub
    Private Sub txtDepMonth_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDepMonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDepMonth.Text = "" Then
                MsgBox("Enter Month")
            ElseIf Convert.ToInt16(txtDepMonth.Text.Trim) >= 13 Then
                MsgBox("Invalid Month")

            Else
                txtDepyear.Focus()
            End If


        End If
    End Sub

    Private Sub txtDepDay_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDepDay.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDepDay.Text = "" Then
                MsgBox("Enter Day")
            ElseIf Convert.ToInt16(txtDepDay.Text.Trim) > 31 Then
                MsgBox("Invalid Day")

            Else
                txtDepMonth.Focus()
            End If
        End If
    End Sub

    Private Sub btGetFlightArr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btGetFlightArr.KeyDown
        If e.KeyCode = Keys.Enter Then
            ArriDateChange()
            cmbArriFlight.Focus()
        End If
    End Sub

    Private Sub cmbArriFlight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbArriFlight.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbArriFlight.Text = "" Then
                txtArrTime.Text = "12:00"
                cmbArriFlight.Text = "UNKNOWN"
            End If
            txtArrTime.Focus()
        End If
    End Sub

    Private Sub txtArrTime_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtArrTime.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbArrTrans.Focus()
        End If
    End Sub

    Private Sub cmbArrTrans_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbArrTrans.KeyPress

    End Sub

    Private Sub cmbArrTrans_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbArrTrans.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtDepMonth.Text = txtArrMonth.Text
            txtDepDay.Text = txtArrDay.Text
            txtDepyear.Text = txtArryear.Text

            cmbArrTransTime.Focus()
            'cmbDepType.Focus()
            ' txtDepDay.Focus()
        End If
    End Sub

    Private Sub cbTopcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbTopcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' txtArrDay.Focus()

            cmbArrType.Focus()
        End If
    End Sub

    Private Sub txtDepyear_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDepyear.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDepyear.Text = "" Then
                MsgBox("Enter Year")

            Else

                If cmbDepType.Text = "Flight" Then
                    btGetFlights.Focus()
                Else
                    txtOtherDep.Focus()
                End If


                '   btGetFlights.Focus()

            End If
        End If
    End Sub



    Private Sub cmbDepFlight_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDepFlight.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbDepFlight.Text = "" Then
                txtDepTime.Text = "12:00"
                cmbDepFlight.Text = "UNKNOWN"
            End If

            txtDepTime.Focus()
        End If
    End Sub

    Private Sub txtDepTime_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDepTime.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbDepTrans.Focus()
        End If
    End Sub

    Private Sub cmbDepTrans_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDepTrans.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbDepTransTime.Focus()
        End If

    End Sub

    Private Sub txtadultcount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtadultcount.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtchildcount.Focus()
        End If
    End Sub

    Private Sub txtchildcount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtchildcount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtchildcount.Text = "" Then
                txtchildcount.Text = "0"
            End If

            txtinfantcount.Focus()
        End If

    End Sub

    Private Sub txtinfantcount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtinfantcount.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txtinfantcount.Text = "" Then
                txtinfantcount.Text = "0"
            End If
            cmbMealplan.Focus()
        End If


    End Sub

    Private Sub cmbMealplan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMealplan.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbRoom.Focus()
        End If

    End Sub

    Private Sub cmbRoom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRoom.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbRoomtyp.Focus()
        End If

    End Sub

    Private Sub cmbRoomtyp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRoomtyp.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRoomcount.Focus()
        End If


    End Sub

    Private Sub txtRoomcount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRoomcount.KeyDown
        If e.KeyCode = Keys.Enter Then
            totPaxrooms.Focus()
        End If

    End Sub

    Private Sub totPaxrooms_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles totPaxrooms.KeyDown
        If e.KeyCode = Keys.Enter Then
            btAddRoomcount.Focus()
        End If
    End Sub

    Private Sub btAddRoomcount_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btAddRoomcount.KeyDown

    End Sub

    Private Sub btGetrate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btGetrate.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' cmbDisscounts.Focus()
            btAdd.Focus()
        End If

    End Sub

    Private Sub cmbDisscounts_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDisscounts.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbAmmenties.Focus()
        End If
    End Sub

    Private Sub cmbAmmenties_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAmmenties.KeyDown
        If e.KeyCode = Keys.Enter Then
            btAdd.Focus()
        End If
    End Sub








    Private Sub gcReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcReservation.Click

    End Sub


    Private Sub txtOtherArr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOtherArr.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtOtherArr.Text = "" Then
                MsgBox("Enter Other Source")
            Else
                txtArrTime.Focus()
            End If

        End If

    End Sub

    Private Sub cmbArrType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbArrType.KeyDown

        If e.KeyCode = Keys.Enter Then
            If cmbArrType.Text = "" Then
                MsgBox("Select Arrival Type")
            Else
                txtArrDay.Focus()
            End If

        End If


    End Sub

    Private Sub cmbDepType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDepType.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbDepType.Text = "" Then
                MsgBox("Select Departure Type")
            Else
                txtDepDay.Focus()
            End If

        End If
    End Sub

    Private Sub txtOtherDep_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOtherDep.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtOtherDep.Text = "" Then
                MsgBox("Enter Other Source")
            Else
                txtDepTime.Focus()
            End If

        End If
    End Sub

    Private Sub cmbArrTransTime_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbArrTransTime.KeyDown

        If e.KeyCode = Keys.Enter Then
            If cmbArrTransTime.Text = "" Then
                MsgBox("Enter Transfer Time")
            Else
                cmbDepType.Focus()


            End If

        End If

    End Sub

    Private Sub cmbDepTransTime_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbDepTransTime.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtadultcount.Focus()
        End If
    End Sub



    Private Sub PrintResConfirmation()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from view_print_resconfirmation", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaResno As String = txtReservationno.Text.Trim
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            fltString = "{view_print_resconfirmation.ResNo}='" & ParaResno & "'"

            PubResConNo = ParaResno

            PubResEmail = txtEmail.Text.Trim

            ReportName = "ResConfirmation.rpt"
            rptTitle = "RES_CON" + "_" + ParaResno.ToString()




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





    Private Sub btprintres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btprintres.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Reservation", "Add")

        If CheckAccess = True Then

            Pubmailfunction = 1

            PrintResConfirmation()


        Else

            MsgBox("You Do Not Have Access")


        End If


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


            txtNationality.Text = cmbCountry.Text.Trim




        End If
    End Sub

    Private Sub cmbCountry_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCountry.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtGuesname.Text <> "" Then

                txtEmail.Focus()


            End If


        End If
    End Sub

    Private Sub txtEmail_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim email As String = txtEmail.Text

        If EmailAddressCheck(email) = False Then

            Dim result As DialogResult _
            = MessageBox.Show("The email address you entered is not valid." & _
                                       " Do you want re-enter it?", "Invalid Email Address", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            End If

        End If
    End Sub
    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" & _
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True

        Else
            EmailAddressCheck = False

        End If
    End Function

    Private Sub txtEmail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtGuesname.Text <> "" Then
                CbTop.Checked = True
                cbTopcode.Focus()

                cbTopcode.EditValue = "Maldiviana Tours"
                ' CbTop.SelectAll()

            End If
        End If
    End Sub
End Class
