Imports System.Data.SqlClient
Imports System.Xml
Imports System.Text.RegularExpressions
Public Class frmProfomainvoice

    Public PubResno As String = ""
    Public PubResType As String = ""
    Public PubIsContract As Integer = 0
    Public PubTopcontractId As String = 0
    Public PubAdultQty As Integer = 0
    Public PubChildQty As Integer = 0
    Public PubInfantsQty As Integer = 0
    Public PubShift As String = "Day"
    Public PubArrTime As DateTime
    Public PubDepTime As DateTime
    Public PubIsEdit As Integer = 0
    Public PubTopcode As String = ""
    Public PubMP As String = ""
    Public PubResdate As DateTime
    Public PubDepdate As DateTime
    Public PubPrefixcode As String = ""
    Public PubMaintype As String = ""
    Public PubDisId As Integer = 0
    Public PubResno2 As String = ""
    Public PubResno3 As String = ""
    Public PubArrTransType As String = ""
    Public PubDepTransType As String = ""
    Public PubArrDate As DateTime

    Public PubMFraction As String = ""


    Public ReportName As String
    Public rptTitle As String
    Public SF As String = ""

    Public getDayTransRateA As Decimal = 0
    Public getNightTransRateA As Decimal = 0


    Public getDayTransRateC As Decimal = 0
    Public getNightTransRateC As Decimal = 0

    Public getDayTransRateI As Decimal = 0
    Public getNightTransRateI As Decimal = 0





    Public PubAISeparately As Decimal = 0
    Public PubAdultSeparately As Decimal = 0
    Public PubChildSeparately As Decimal = 0





    Private Sub frmProfomainvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadGrid()
        LoadTopcodes()
        LoadTax()

        GetServerDate()
        cbTopcode.SelectedIndex = 0
        cmbResnos.SelectedIndex = 0
        ' DtToday.Text = Date.Now.Date
        ' dtArrivalDate.Text = Date.Now.Date

        tabProforma.TabPages(1).PageEnabled = False
        tabProforma.TabPages(0).PageEnabled = True


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


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
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
    Private Sub LoadResCodesAllTop()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT * FROM dbo.[Reservation.Master] where Status='OPEN' AND IsProformaCreated=0 AND ResType='TOP' order by ResNo desc", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer


            If Dscount > 0 Then

                While (DscountTest < Dscount)

                    cmbResnos.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbResnos.SelectedIndex = 0

            Else

                MessageBox.Show("No Records Found", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbResnos.Properties.Items.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadResCodesAllTopByDate()

        'Dim Conn As New SqlConnection(ConnString)
        'Dim daMain As New SqlDataAdapter
        'Dim dsMain As New DataSet
        'Dim dcSearch As New SqlCommand
        'Try
        '    Conn.Open()
        '    dcSearch = New SqlCommand("SELECT * FROM dbo.[Reservation.Master] where Status='OPEN' AND IsProformaCreated=0 AND ResType='TOP' AND ArrDate=@Arrdate order by ResNo", Conn)
        '    dcSearch.Parameters.Add("@Arrdate", SqlDbType.DateTime).Value = dtArrivalDate.DateTime.Date

        '    daMain = New SqlDataAdapter()
        '    daMain.SelectCommand = dcSearch
        '    daMain.Fill(dsMain)

        '    Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
        '    Dim DscountTest As Integer


        '    If Dscount > 0 Then

        '        While (DscountTest < Dscount)

        '            cmbResnos.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
        '            DscountTest = DscountTest + 1

        '        End While

        '        cmbResnos.SelectedIndex = 0

        '    Else

        '        MessageBox.Show("No Records Found", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        cmbResnos.Properties.Items.Clear()
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        'Finally
        '    Conn.Dispose()
        '    daMain.Dispose()
        '    dsMain.Dispose()
        'End Try
    End Sub
    Private Sub LoadResCodesByTop()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT * FROM dbo.[Reservation.Master] where Status='OPEN' AND IsProformaCreated=0 AND ResType='TOP' AND Topcode=@Topcode order by ResNo desc", Conn)
            dcSearch.Parameters.Add("@Topcode", SqlDbType.NVarChar).Value = cbTopcode.Text.Trim

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            If Dscount > 0 Then


                While (DscountTest < Dscount)

                    cmbResnos.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbResnos.SelectedIndex = 0


            Else

                MessageBox.Show("No Records Found", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbResnos.Properties.Items.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadResCodesByTopDate()

        'Dim Conn As New SqlConnection(ConnString)
        'Dim daMain As New SqlDataAdapter
        'Dim dsMain As New DataSet
        'Dim dcSearch As New SqlCommand
        'Try
        '    Conn.Open()
        '    dcSearch = New SqlCommand("SELECT * FROM dbo.[Reservation.Master] where Status='OPEN' AND IsProformaCreated=0 AND ResType='TOP' AND Topcode=@Topcode AND ArrDate=@Arrdate order by ResNo desc", Conn)
        '    dcSearch.Parameters.Add("@Topcode", SqlDbType.NVarChar).Value = cbTopcode.Text.Trim
        '    dcSearch.Parameters.Add("@Arrdate", SqlDbType.DateTime).Value = dtArrivalDate.DateTime.Date


        '    daMain = New SqlDataAdapter()
        '    daMain.SelectCommand = dcSearch
        '    daMain.Fill(dsMain)

        '    Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
        '    Dim DscountTest As Integer

        '    If Dscount > 0 Then


        '        While (DscountTest < Dscount)

        '            cmbResnos.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
        '            DscountTest = DscountTest + 1

        '        End While

        '        cmbResnos.SelectedIndex = 0


        '    Else

        '        MessageBox.Show("No Records Found", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        cmbResnos.Properties.Items.Clear()
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        'Finally
        '    Conn.Dispose()
        '    daMain.Dispose()
        '    dsMain.Dispose()
        'End Try
    End Sub
    Private Sub LoadResCodesOthers()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT * FROM dbo.[Reservation.Master] where Status='OPEN' AND IsProformaCreated=0 AND ResType !='TOP'  order by ResNo,ResType", Conn)
            dcSearch.Parameters.Add("@Topcode", SqlDbType.NVarChar).Value = cbTopcode.Text.Trim

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            If Dscount > 0 Then

                While (DscountTest < Dscount)

                    cmbResnos.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbResnos.SelectedIndex = 0

            Else

                MessageBox.Show("No Records Found", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbResnos.Properties.Items.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub btSearchtop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearchtop.Click
        Try


            If cbTopcode.Text = "ALL" Then
                cmbResnos.Properties.Items.Clear()
                LoadResCodesAllTop()
            Else
                cmbResnos.Properties.Items.Clear()
                LoadResCodesByTop()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub

    Private Sub btSearchothers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearchothers.Click
        cmbResnos.Properties.Items.Clear()
        LoadResCodesOthers()
    End Sub
    Private Sub btResDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResDetails.Click

        Try




            If CheckPerformaCreated() = False Then
         



                gcPax.DataSource = Nothing
                gcResdetails.DataSource = Nothing
                gcTaxDetail.DataSource = Nothing

                getDayTransRateA = 0
                getNightTransRateA = 0
                getDayTransRateC = 0
                getNightTransRateC = 0
                getDayTransRateI = 0
                getNightTransRateI = 0



                PubAISeparately = 0
                PubAdultSeparately = 0
                PubChildSeparately = 0

                LoadResDetails()


                Dim DSPax As New DataSet
                DSPax = DSLoadResPaxDetails()

                If DSPax.Tables(0).Rows.Count > 0 Then

                    gcPax.DataSource = DSPax.Tables(0)

                End If

                Dim getTopcodeinv As String = ""
                Dim getTypeInv As String = ""


                If PubResType = "TOP" Then
                    getTypeInv = "TOP"
                    getTopcodeinv = PubTopcode
                End If

                If PubResType = "FIT" Then
                    getTypeInv = "FIT"
                    getTopcodeinv = "FIT"
                End If


                If PubResType = "COM" Then
                    getTypeInv = "COM"
                    getTopcodeinv = "COM"
                End If


                Dim GetProinvNo As String = GetProInvCode(getTypeInv, getTopcodeinv)

                If GetProinvNo = "" Then
                    MessageBox.Show("Proforma Invoice Code Not Defined For This TOP,Contact System Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Else
                    txtProninvno.Text = GetProinvNo

                End If



                txtTransferrate.Text = ""

                GetTransferRateArrival()
                GetTransferRateDeparture()

                'GetArrTransferRateTopContracts()
                'GetDepTransferRateTopContracts()

                DeleteProInvPeriodRate()
                LoadRoomRatesTopContracts()
                LoadBedTax()
                LoadDiscounts()


            Else



                MsgBox("Performa Is Created For This Reservation No", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub


            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
        'txtFinaltot.Text = Convert.ToDecimal(txtRate.Text.Trim) + Convert.ToDecimal(txtTransferrateArr.Text.Trim)


    End Sub
    Private Sub LoadResDetails()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getResno As String = cmbResnos.Text.Trim

            Conn.Open()
            ' dcSearch = New SqlCommand("select ResNo,ResDate,Guest,ResType,Topcode,IsTopcontract,TopContractId,ArrDate,DepDate,ArrFlight,DepFlight,convert(char(5), ArrTime, 108) [ArrTime],convert(char(5), DepTime, 108) [DepTime],ArrTrans,DepTrans,PaxId,AdultQty,ChildrenQty,InfantsQty,MealPlan,Rate,DisPlanId,OfferId,AmenId,Total,PayMode,PayExpiryDate,PayCCNo,Guestlikes,Guestdislikes,BillingInst,Remarks,Refno,PaymentStatus,Status,IsProformaCreated,ProfomaInvoiceno,EnteredBy,EnteredDate,InactivatedBy,InactivatedDate from dbo.[Reservation.Master] where ResNo=@ResNo", Conn)
            dcSearch = New SqlCommand("select ResNo,ResDate,Guest,ResType,Topcode,IsTopcontract,TopContractId,ArrDate,DepDate,ArrFlight,DepFlight,convert(char(5), ArrTime, 108) [ArrTime],convert(char(5), DepTime, 108) [DepTime],ArrTrans,DepTrans,PaxId,AdultQty,ChildrenQty,InfantsQty,MealPlan,Rate,DisPlanId,OfferId,AmenId,Total,PayMode,PayExpiryDate,PayCCNo,Guestlikes,Guestdislikes,BillingInst,Remarks,Refno,Status,IsProformaCreated,ProfomaInvoiceno,EnteredBy,EnteredDate,InactivatedBy,InactivatedDate,ArrTransTime,DepTransTime from dbo.[Reservation.Master] where ResNo=@ResNo and IsProformaCreated=0 and Status='OPEN'", Conn)


            dcSearch.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = getResno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then
                gcResdetails.DataSource = dsMain.Tables(0)


                If PubIsEdit = 1 Then


                Else
                    txtRate.Text = dsMain.Tables(0).Rows(0)(20).ToString

                End If


                txtDisscounts.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0)(24).ToString) - Convert.ToDecimal(dsMain.Tables(0).Rows(0)(20).ToString)
                ' txtFinaltot.Text = dsMain.Tables(0).Rows(0)(24).ToString

                PubResType = dsMain.Tables(0).Rows(0)(3).ToString
                PubIsContract = Convert.ToInt16(dsMain.Tables(0).Rows(0)(5).ToString)
                PubTopcontractId = dsMain.Tables(0).Rows(0)(6).ToString
                PubTopcode = dsMain.Tables(0).Rows(0)(4).ToString
                PubMP = dsMain.Tables(0).Rows(0)(19).ToString
                PubResdate = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(1))
                PubDepdate = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(8))

                PubDisId = Convert.ToInt16(dsMain.Tables(0).Rows(0)(21).ToString)

                PubAdultQty = Convert.ToInt16(dsMain.Tables(0).Rows(0)(16).ToString)
                PubChildQty = Convert.ToInt16(dsMain.Tables(0).Rows(0)(17).ToString)
                PubInfantsQty = Convert.ToInt16(dsMain.Tables(0).Rows(0)(18).ToString)

                PubArrTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(11).ToString)
                PubDepTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(12).ToString)

                PubArrDate = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(7))

                Dim inDtArr As DateTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(7).ToString)
                'Dim inTimeArr As DateTime = dsMain.Tables(0).Rows(0)(11)
                'Dim OriArrTime As DateTime = inDtArr.AddTicks(inTimeArr.Ticks)

                Dim inDtDep As DateTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(8).ToString)
                'Dim inTimeDep As DateTime = dsMain.Tables(0).Rows(0)(12)
                'Dim OriDepTime As DateTime = inDtDep.AddTicks(inTimeDep.Ticks)

                ' Dim theDays As Integer = OriDepTime.Subtract(OriArrTime).TotalDays

                Dim theDays As Integer = DateDiff(DateInterval.Day, inDtArr, inDtDep)


                txtBednights.Text = theDays.ToString



                If (Not IsDBNull(dsMain.Tables(0).Rows(0).Item("ArrTransTime"))) Then

                    PubArrTransType = dsMain.Tables(0).Rows(0).Item("ArrTransTime")

                Else
                    PubArrTransType = ""
                End If

                If (Not IsDBNull(dsMain.Tables(0).Rows(0).Item("DepTransTime"))) Then

                    PubDepTransType = dsMain.Tables(0).Rows(0).Item("DepTransTime")

                Else
                    PubDepTransType = ""
                End If



            Else

                MessageBox.Show("Proforma Invoice Is Already Created or Data Unavailable for Invoicing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)




            End If

        



            'Payment Status Change
            'txtPaystatus.Text = dsMain.Tables(0).Rows(0)(33).ToString


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Function CheckPerformaCreated() As Boolean


        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getResno As String = cmbResnos.Text.Trim

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
    Private Sub LoadResDetailsInvCreated()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getResno As String = cmbResnos.Text.Trim

            Conn.Open()
            ' dcSearch = New SqlCommand("select ResNo,ResDate,Guest,ResType,Topcode,IsTopcontract,TopContractId,ArrDate,DepDate,ArrFlight,DepFlight,convert(char(5), ArrTime, 108) [ArrTime],convert(char(5), DepTime, 108) [DepTime],ArrTrans,DepTrans,PaxId,AdultQty,ChildrenQty,InfantsQty,MealPlan,Rate,DisPlanId,OfferId,AmenId,Total,PayMode,PayExpiryDate,PayCCNo,Guestlikes,Guestdislikes,BillingInst,Remarks,Refno,PaymentStatus,Status,IsProformaCreated,ProfomaInvoiceno,EnteredBy,EnteredDate,InactivatedBy,InactivatedDate from dbo.[Reservation.Master] where ResNo=@ResNo", Conn)
            dcSearch = New SqlCommand("select ResNo,ResDate,Guest,ResType,Topcode,IsTopcontract,TopContractId,ArrDate,DepDate,ArrFlight,DepFlight,convert(char(5), ArrTime, 108) [ArrTime],convert(char(5), DepTime, 108) [DepTime],ArrTrans,DepTrans,PaxId,AdultQty,ChildrenQty,InfantsQty,MealPlan,Rate,DisPlanId,OfferId,AmenId,Total,PayMode,PayExpiryDate,PayCCNo,Guestlikes,Guestdislikes,BillingInst,Remarks,Refno,Status,IsProformaCreated,ProfomaInvoiceno,EnteredBy,EnteredDate,InactivatedBy,InactivatedDate,ArrTransTime,DepTransTime from dbo.[Reservation.Master] where ResNo=@ResNo", Conn)


            dcSearch.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = getResno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then
                gcResdetails.DataSource = dsMain.Tables(0)


                If PubIsEdit = 1 Then


                Else
                    txtRate.Text = dsMain.Tables(0).Rows(0)(20).ToString

                End If


                txtDisscounts.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0)(24).ToString) - Convert.ToDecimal(dsMain.Tables(0).Rows(0)(20).ToString)
                ' txtFinaltot.Text = dsMain.Tables(0).Rows(0)(24).ToString

                PubResType = dsMain.Tables(0).Rows(0)(3).ToString
                PubIsContract = Convert.ToInt16(dsMain.Tables(0).Rows(0)(5).ToString)
                PubTopcontractId = dsMain.Tables(0).Rows(0)(6).ToString
                PubTopcode = dsMain.Tables(0).Rows(0)(4).ToString
                PubMP = dsMain.Tables(0).Rows(0)(19).ToString
                PubResdate = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(1))

                PubDisId = Convert.ToInt16(dsMain.Tables(0).Rows(0)(21).ToString)

                PubAdultQty = Convert.ToInt16(dsMain.Tables(0).Rows(0)(16).ToString)
                PubChildQty = Convert.ToInt16(dsMain.Tables(0).Rows(0)(17).ToString)
                PubInfantsQty = Convert.ToInt16(dsMain.Tables(0).Rows(0)(18).ToString)

                PubArrTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(11).ToString)
                PubDepTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(12).ToString)


                Dim inDtArr As DateTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(7).ToString)
                'Dim inTimeArr As DateTime = dsMain.Tables(0).Rows(0)(11)
                'Dim OriArrTime As DateTime = inDtArr.AddTicks(inTimeArr.Ticks)

                Dim inDtDep As DateTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(8).ToString)
                'Dim inTimeDep As DateTime = dsMain.Tables(0).Rows(0)(12)
                'Dim OriDepTime As DateTime = inDtDep.AddTicks(inTimeDep.Ticks)

                ' Dim theDays As Integer = OriDepTime.Subtract(OriArrTime).TotalDays

                Dim theDays As Integer = DateDiff(DateInterval.Day, inDtArr, inDtDep)


                txtBednights.Text = theDays.ToString



                If (Not IsDBNull(dsMain.Tables(0).Rows(0).Item("ArrTransTime"))) Then

                    PubArrTransType = dsMain.Tables(0).Rows(0).Item("ArrTransTime")

                Else
                    PubArrTransType = ""
                End If

                If (Not IsDBNull(dsMain.Tables(0).Rows(0).Item("DepTransTime"))) Then

                    PubDepTransType = dsMain.Tables(0).Rows(0).Item("DepTransTime")

                Else
                    PubDepTransType = ""
                End If



            Else

                MessageBox.Show("Data Unavailable for Invoicing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)


            End If





            'Payment Status Change
            'txtPaystatus.Text = dsMain.Tables(0).Rows(0)(33).ToString


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Function DSLoadResPaxDetails() As DataSet
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getResno As String = cmbResnos.Text.Trim

            Conn.Open()
            dcSearch = New SqlCommand("SELECT  dbo.[Reservation.Room].Room, dbo.[Reservation.Room].Roomtype, dbo.[Reservation.Room].RoomCount,dbo.[Reservation.Room].BedNights ,dbo.[Reservation.Room].TotPax ,dbo.[Reservation.Master].AdultQty,dbo.[Reservation.Master].ChildrenQty,dbo.[Reservation.Room].ResRoomId FROM  dbo.[Reservation.Master] INNER JOIN  dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo where dbo.[Reservation.Master].ResNo=@ResNo", Conn)
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
    Private Sub LoadTax()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getResno As String = cmbResnos.Text.Trim

            Conn.Open()
            dcSearch = New SqlCommand("select TaxID,TaxName,Taxpercentage from dbo.[Tax.Master] where Status='OPEN'", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            With cmbTax.Properties
                .DataSource = dsMain.Tables(0)
                .DisplayMember = "TaxName"
                .ValueMember = "TaxID"
                .Columns(0).Width = 5
                .Columns(1).Width = 12
                .Columns(2).Width = 5
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
    Private Sub InsertTaxTemp()


        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand



            Dim Resno As String = cmbResnos.Text.Trim
            Dim ProInvno As String = txtProninvno.Text.Trim
            Dim Taxid As Integer = IIf(IsNothing(cmbTax.GetColumnValue("TaxID")), String.Empty, cmbTax.GetColumnValue("TaxID"))

            Dim CurrentUser As String = CurrUser

            dcInsertNewAcc = New SqlCommand("InsertInvProTaxTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcInsertNewAcc.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = Resno
            dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = ProInvno
            dcInsertNewAcc.Parameters.Add("@Taxid", SqlDbType.Int).Value = Taxid
            dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try


    End Sub
    Function DSCheckAddTaxTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim CurrentUser As String = CurrUser


            Dim ReservationNo As String = cmbResnos.Text.Trim
            Dim ProInvNo As String = txtProninvno.Text.Trim
            Dim TaxId As Integer = IIf(IsNothing(cmbTax.GetColumnValue("TaxID")), String.Empty, cmbTax.GetColumnValue("TaxID"))
            Dim Createdby As String = CurrentUser

            dcSearch = New SqlCommand("select * from dbo.[Invoice.Proforma.Tax.Temp] where ReservationNo=@ReservationNo and ProInvNo=@ProInvNo and Taxid=@TaxId and Createdby=@Createdby", Conn)
            dcSearch.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = ReservationNo
            dcSearch.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = ProInvNo
            dcSearch.Parameters.Add("@TaxId", SqlDbType.Int).Value = TaxId
            dcSearch.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = Createdby

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckAddTaxTemp = dsMain
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
    Private Sub btTaxApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTaxApply.Click
        Try

            If PubIsEdit = 0 Then
                Dim dscheckTaxAddbefore As New DataSet
                dscheckTaxAddbefore = DSCheckAddTaxTemp()

                If dscheckTaxAddbefore Is Nothing Then
                    InsertTaxTemp()
                    LoadInvTaxDetails()

                Else
                    MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If

            End If


            If PubIsEdit = 1 Then

                DeleteProInvTax(txtProninvno.Text.Trim)

                Dim dscheckTaxAddbefore As New DataSet
                dscheckTaxAddbefore = DSCheckAddTaxTemp()

                If dscheckTaxAddbefore Is Nothing Then
                    InsertTaxTemp()
                    LoadInvTaxDetails()

                Else
                    MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub LoadInvTaxDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim Resno As String = cmbResnos.Text.Trim
            Dim ProInvno As String = txtProninvno.Text.Trim

            dcSearch = New SqlCommand("SELECT dbo.[Invoice.Proforma.Tax.Temp].Taxid, dbo.[Tax.Master].TaxName FROM dbo.[Invoice.Proforma.Tax.Temp] INNER JOIN dbo.[Tax.Master] ON dbo.[Invoice.Proforma.Tax.Temp].Taxid = dbo.[Tax.Master].TaxID WHERE dbo.[Invoice.Proforma.Tax.Temp].ReservationNo=@Resno AND dbo.[Invoice.Proforma.Tax.Temp].ProInvNo=@ProInvno", Conn)
            dcSearch.Parameters.Add("@Resno", SqlDbType.VarChar).Value = Resno
            dcSearch.Parameters.Add("@ProInvno", SqlDbType.VarChar).Value = ProInvno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            gcTaxDetail.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadInvTaxMasterDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Dim dcInsertNewAcc As New SqlCommand

        Try
            Conn.Open()

            Dim Resno As String = cmbResnos.Text.Trim
            Dim ProInvno As String = txtProninvno.Text.Trim

            dcSearch = New SqlCommand("SELECT dbo.[Invoice.Proforma.Tax].Taxid, dbo.[Tax.Master].TaxName ,[Invoice.Proforma.Tax].ReservationNo,dbo.[Invoice.Proforma.Tax].ProInvNo FROM dbo.[Invoice.Proforma.Tax] INNER JOIN dbo.[Tax.Master] ON dbo.[Invoice.Proforma.Tax].Taxid = dbo.[Tax.Master].TaxID WHERE dbo.[Invoice.Proforma.Tax].ReservationNo=@Resno AND dbo.[Invoice.Proforma.Tax].ProInvNo=@ProInvno", Conn)
            dcSearch.Parameters.Add("@Resno", SqlDbType.VarChar).Value = Resno
            dcSearch.Parameters.Add("@ProInvno", SqlDbType.VarChar).Value = ProInvno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            Conn.Close()

            '---------------------------------------------------------------------------------------

            Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

            DeleteTempProInvTax(cmbResnos.Text.Trim)

            Dim CurrentUser As String = CurrUser

            While DScount >= 0

                dcInsertNewAcc = New SqlCommand("InsertInvProTaxTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
                dcInsertNewAcc.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(2).ToString
                dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(3).ToString
                dcInsertNewAcc.Parameters.Add("@Taxid", SqlDbType.Int).Value = Convert.ToInt16(dsMain.Tables(0).Rows(DScount)(0).ToString)
                dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()
                DScount = DScount - 1
            End While

            LoadInvTaxDetails()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub GetTransferRateArrival()


        Dim passShift As String = ""
        Dim passTransRate As Decimal = 0





        Try


            '-------------------------------------------  Get Rate Non Top-------------------------------------------------------

            If PubResType <> "TOP" Then


                If PubArrTransType = "" Then

                    If PubArrTime.Hour > 17 Or PubArrTime.Hour < 5 Then
                        passShift = "NIGHT"
                    Else
                        passShift = "DAY"
                    End If

                Else
                    passShift = PubArrTransType


                End If








                If CbInfantsRate.Checked = True Then

                    If PubAdultQty > 0 Then

                        Dim dsgetNonTopRate As New DataSet
                        dsgetNonTopRate = DSGetTransferRate(PubResType, "Adults", passShift)


                        If dsgetNonTopRate.Tables(0) Is DBNull.Value Or dsgetNonTopRate.Tables(0).Rows.Count = 0 Then

                            MessageBox.Show("Arrival Transfer Rate Not Assigned for-Adults" + PubResType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else


                            If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then


                                Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubAdultQty)

                                passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubAdultQty)

                                If passShift = "DAY" Then
                                    getDayTransRateA = getDayTransRateA + getIndRate
                                End If

                                If passShift = "NIGHT" Then
                                    getNightTransRateA = getNightTransRateA + getIndRate
                                End If



                            End If

                        End If

                    End If


                    If PubChildQty > 0 Then

                        Dim dsgetNonTopRate As New DataSet
                        dsgetNonTopRate = DSGetTransferRate(PubResType, "Children", passShift)

                        If dsgetNonTopRate.Tables(0) Is DBNull.Value Or dsgetNonTopRate.Tables(0).Rows.Count = 0 Then

                            MessageBox.Show("Arrival Transfer Rate Not Assigned for-Adults" + PubResType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else

                            If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then

                                Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubChildQty)

                                passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubChildQty)

                                If passShift = "DAY" Then
                                    getDayTransRateC = getDayTransRateC + getIndRate
                                End If

                                If passShift = "NIGHT" Then
                                    getNightTransRateC = getNightTransRateC + getIndRate
                                End If


                            End If
                        End If


                    End If

                    Dim finalTranArr As Decimal = passTransRate / 2

                    Dim finalDayTrans As Decimal = (getDayTransRateA + getDayTransRateC) / 2
                    Dim finalNightTrans As Decimal = (getNightTransRateA + getNightTransRateC) / 2



                    txtRateDayT.Text = finalDayTrans.ToString
                    txtRateNightT.Text = finalNightTrans.ToString

                    txtTransferrateArr.Text = finalTranArr.ToString



                Else

                    If PubAdultQty > 0 Then

                        Dim dsgetNonTopRate As New DataSet
                        dsgetNonTopRate = DSGetTransferRate(PubResType, "Adults", passShift)


                        If dsgetNonTopRate.Tables(0) Is DBNull.Value Or dsgetNonTopRate.Tables(0).Rows.Count = 0 Then

                            MessageBox.Show("Arrival Transfer Rate Not Assigned for-Adults : " + PubResType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else

                            If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then


                                Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubAdultQty)

                                passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubAdultQty)

                                If passShift = "DAY" Then
                                    getDayTransRateA = getDayTransRateA + getIndRate
                                End If

                                If passShift = "NIGHT" Then
                                    getNightTransRateA = getNightTransRateA + getIndRate
                                End If





                            End If
                        End If


                    End If


                    If PubChildQty > 0 Then

                        Dim dsgetNonTopRate As New DataSet
                        dsgetNonTopRate = DSGetTransferRate(PubResType, "Children : ", passShift)


                        If dsgetNonTopRate.Tables(0) Is DBNull.Value Then
                            MessageBox.Show("Arrival Transfer Rate Not Assigned for-Children" + PubResType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else


                            If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then


                                Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubChildQty)

                                passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubChildQty)


                                If passShift = "DAY" Then
                                    getDayTransRateC = getDayTransRateC + getIndRate
                                End If

                                If passShift = "NIGHT" Then
                                    getNightTransRateC = getNightTransRateC + getIndRate
                                End If




                            End If
                        End If


                    End If


                    If PubInfantsQty > 0 Then

                        Dim dsgetNonTopRate As New DataSet
                        dsgetNonTopRate = DSGetTransferRate(PubResType, "Infants", passShift)


                        If dsgetNonTopRate.Tables(0) Is DBNull.Value Then
                            MessageBox.Show("Arrival Transfer Rate Not Assigned for-Infants : " + PubResType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else

                            If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then

                                Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubInfantsQty)

                                passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubInfantsQty)


                                If passShift = "DAY" Then
                                    getDayTransRateI = getDayTransRateI + getIndRate
                                End If

                                If passShift = "NIGHT" Then
                                    getNightTransRateI = getNightTransRateI + getIndRate
                                End If




                            End If
                        End If


                    End If

                    Dim finalTransArrival As Decimal = passTransRate / 2

                    Dim finalDayTrans As Decimal = (getDayTransRateA + getDayTransRateC + getDayTransRateI) / 2
                    Dim finalNightTrans As Decimal = (getNightTransRateA + getNightTransRateC + getNightTransRateI) / 2



                    txtRateDayT.Text = finalDayTrans.ToString
                    txtRateNightT.Text = finalNightTrans.ToString


                    txtTransferrateArr.Text = finalTransArrival.ToString

                End If

            Else
                GetArrTransferRateTopContracts()
                'txtTransferrateArr.Text = "0.00"

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try


    End Sub
    Private Sub GetTransferRateDeparture()


        Dim passShift As String = ""
        Dim passTransRate As Decimal = 0

        Try


            '-------------------------------------------  Get Rate Non Top-------------------------------------------------------

            If PubResType <> "TOP" Then


                If PubDepTransType = "" Then

                    If PubArrTime.Hour > 17 Or PubArrTime.Hour < 5 Then
                        passShift = "NIGHT"
                    Else
                        passShift = "DAY"
                    End If

                Else
                    passShift = PubDepTransType


                End If







                'If PubDepTime.Hour > 17 Or PubDepTime.Hour < 5 Then
                '    passShift = "NIGHT"
                'Else
                '    passShift = "DAY"
                'End If







                If CbInfantsRate.Checked = True Then

                    If PubAdultQty > 0 Then

                        Dim dsgetNonTopRate As New DataSet
                        dsgetNonTopRate = DSGetTransferRate(PubResType, "Adults", passShift)


                        If dsgetNonTopRate.Tables(0) Is DBNull.Value Or dsgetNonTopRate.Tables(0).Rows.Count = 0 Then

                            MessageBox.Show("Departure Transfer Rate Not Assigned for-Adults : " + PubResType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else


                            If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then

                                Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubAdultQty)


                                passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubAdultQty)

                                If passShift = "DAY" Then
                                    getDayTransRateA = getDayTransRateA + getIndRate
                                End If

                                If passShift = "NIGHT" Then
                                    getNightTransRateA = getNightTransRateA + getIndRate
                                End If



                            End If
                        End If


                    End If


                    If PubChildQty > 0 Then

                        Dim dsgetNonTopRate As New DataSet
                        dsgetNonTopRate = DSGetTransferRate(PubResType, "Children", passShift)

                        If dsgetNonTopRate.Tables(0) Is DBNull.Value Or dsgetNonTopRate.Tables(0).Rows.Count = 0 Then

                            MessageBox.Show("Departure Transfer Rate Not Assigned for-Children : " + PubResType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else

                            If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then

                                Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubChildQty)


                                passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubChildQty)


                                If passShift = "DAY" Then
                                    getDayTransRateC = getDayTransRateC + getIndRate
                                End If

                                If passShift = "NIGHT" Then
                                    getNightTransRateC = getNightTransRateC + getIndRate
                                End If


                            End If
                        End If


                    End If

                Else

                    If PubAdultQty > 0 Then

                        Dim dsgetNonTopRate As New DataSet
                        dsgetNonTopRate = DSGetTransferRate(PubResType, "Adults", passShift)


                        If dsgetNonTopRate.Tables(0) Is DBNull.Value Or dsgetNonTopRate.Tables(0).Rows.Count = 0 Then

                            MessageBox.Show("Departure Transfer Rate Not Assigned for-Adults : " + PubResType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else

                            If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then


                                Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubAdultQty)

                                passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubAdultQty)

                                If passShift = "DAY" Then
                                    getDayTransRateA = getDayTransRateA + getIndRate
                                End If

                                If passShift = "NIGHT" Then
                                    getNightTransRateA = getNightTransRateA + getIndRate
                                End If


                            End If
                        End If

                    End If


                    If PubChildQty > 0 Then

                        Dim dsgetNonTopRate As New DataSet
                        dsgetNonTopRate = DSGetTransferRate(PubResType, "Children", passShift)

                        If dsgetNonTopRate.Tables(0) Is DBNull.Value Or dsgetNonTopRate.Tables(0).Rows.Count = 0 Then

                            MessageBox.Show("Departure Transfer Rate Not Assigned for-Children : " + PubResType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else

                            If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then

                                Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubChildQty)

                                passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubChildQty)

                                If passShift = "DAY" Then
                                    getDayTransRateC = getDayTransRateC + getIndRate
                                End If

                                If passShift = "NIGHT" Then
                                    getNightTransRateC = getNightTransRateC + getIndRate
                                End If


                            End If
                        End If

                    End If


                    If PubInfantsQty > 0 Then

                        Dim dsgetNonTopRate As New DataSet
                        dsgetNonTopRate = DSGetTransferRate(PubResType, "Infants", passShift)

                        If dsgetNonTopRate.Tables(0) Is DBNull.Value Or dsgetNonTopRate.Tables(0).Rows.Count = 0 Then

                            MessageBox.Show("Departure Transfer Rate Not Assigned for-Infants : " + PubResType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            Exit Sub
                        Else

                            If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then


                                Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubInfantsQty)
                                passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(7))) * PubInfantsQty)


                                If passShift = "DAY" Then
                                    getDayTransRateI = getDayTransRateI + getIndRate
                                End If

                                If passShift = "NIGHT" Then
                                    getNightTransRateI = getNightTransRateI + getIndRate
                                End If




                            End If
                        End If


                    End If

                    Dim dimFinaTransDep As Decimal = passTransRate / 2
                    Dim finalDayTrans As Decimal = (getDayTransRateA + getDayTransRateC + getDayTransRateI) / 2
                    Dim finalNightTrans As Decimal = (getNightTransRateA + getNightTransRateC + getNightTransRateI) / 2



                    txtRateDayT.Text = finalDayTrans.ToString
                    txtRateNightT.Text = finalNightTrans.ToString



                    txtTransferrateDep.Text = dimFinaTransDep.ToString
                End If


            Else
                GetDepTransferRateTopContracts()
                'txtTransferrateDep.Text = "0.00"

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub GetArrTransferRateTopContracts()


        Dim passShift As String = ""
        Dim passTransRate As Decimal = 0

        Try


            '-------------------------------------------  Get Rate Top Contracts-------------------------------------------------------

            If PubResType = "TOP" Then


                If PubArrTransType = "" Then

                    If PubArrTime.Hour > 17 Or PubArrTime.Hour < 5 Then
                        passShift = "NIGHT"
                    Else
                        passShift = "DAY"
                    End If

                Else
                    passShift = PubArrTransType


                End If







                If PubAdultQty > 0 Then

                    Dim dsgetNonTopRate As New DataSet
                    dsgetNonTopRate = DSGetTransferRateTopContracts(PubTopcode, "Adults", passShift, PubResdate)

                    If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then


                        Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(4))) * PubAdultQty)

                        passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(4))) * PubAdultQty)


                        If passShift = "DAY" Then
                            getDayTransRateA = getDayTransRateA + getIndRate
                        End If

                        If passShift = "NIGHT" Then
                            getNightTransRateA = getNightTransRateA + getIndRate
                        End If






                    Else
                        MessageBox.Show("Transfer Rates Are Not Defined For Adults In The Activ Contract", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If

                End If


                If PubChildQty > 0 Then

                    Dim dsgetNonTopRate As New DataSet
                    dsgetNonTopRate = DSGetTransferRateTopContracts(PubTopcode, "Children", passShift, PubResdate)

                    If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then

                        Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(4))) * PubChildQty)

                        passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(4))) * PubChildQty)

                        If passShift = "DAY" Then
                            getDayTransRateC = getDayTransRateC + getIndRate
                        End If

                        If passShift = "NIGHT" Then
                            getNightTransRateC = getNightTransRateC + getIndRate
                        End If





                    Else
                        MessageBox.Show("Transfer Rates Are Not Defined For Children In The Activ Contract", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If

                End If


                If PubInfantsQty > 0 Then

                    Dim dsgetNonTopRate As New DataSet
                    dsgetNonTopRate = DSGetTransferRateTopContracts(PubTopcode, "Infants", passShift, PubResdate)

                    If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then



                        Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(4))) * PubInfantsQty)
                        passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(4))) * PubInfantsQty)


                        If passShift = "DAY" Then
                            getDayTransRateI = getDayTransRateI + getIndRate
                        End If

                        If passShift = "NIGHT" Then
                            getNightTransRateI = getNightTransRateI + getIndRate
                        End If




                    Else
                        MessageBox.Show("Transfer Rates Are Not Defined For Infants In The Activ Contract", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If

                End If

                Dim finalTransConArr As Decimal = passTransRate / 2

                Dim finalDayTrans As Decimal = (getDayTransRateA + getDayTransRateC + getDayTransRateI) / 2
                Dim finalNightTrans As Decimal = (getNightTransRateA + getNightTransRateC + getNightTransRateI) / 2



                txtRateDayT.Text = finalDayTrans.ToString
                txtRateNightT.Text = finalNightTrans.ToString


                txtTransferrateArr.Text = finalTransConArr.ToString

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub GetDepTransferRateTopContracts()


        Dim passShift As String = ""
        Dim passTransRate As Decimal = 0

        Try



            '-------------------------------------------  Get Rate Top Contracts-------------------------------------------------------

            If PubResType = "TOP" Then


                If PubDepTransType = "" Then


                    If PubDepTime.Hour > 17 Or PubDepTime.Hour < 5 Then
                        passShift = "NIGHT"
                    Else
                        passShift = "DAY"
                    End If

                Else
                    passShift = PubDepTransType


                End If






                If PubAdultQty > 0 Then

                    Dim dsgetNonTopRate As New DataSet
                    dsgetNonTopRate = DSGetTransferRateTopContracts(PubTopcode, "Adults", passShift, PubDepdate)

                    If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then



                        Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(4))) * PubAdultQty)

                        passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(4))) * PubAdultQty)


                        If passShift = "DAY" Then
                            getDayTransRateA = getDayTransRateA + getIndRate
                        End If

                        If passShift = "NIGHT" Then
                            getNightTransRateA = getNightTransRateA + getIndRate
                        End If






                    Else
                        MessageBox.Show("Transfer Rates Are Not Defined For Adults In The Activ Contract", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If

                End If


                If PubChildQty > 0 Then

                    Dim dsgetNonTopRate As New DataSet
                    dsgetNonTopRate = DSGetTransferRateTopContracts(PubTopcode, "Children", passShift, PubDepdate)

                    If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then


                        Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(4))) * PubChildQty)

                        passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(4))) * PubChildQty)


                        If passShift = "DAY" Then
                            getDayTransRateC = getDayTransRateC + getIndRate
                        End If

                        If passShift = "NIGHT" Then
                            getNightTransRateC = getNightTransRateC + getIndRate
                        End If





                    Else
                        MessageBox.Show("Transfer Rates Are Not Defined For Children In The Activ Contract", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If

                End If


                If PubInfantsQty > 0 Then

                    Dim dsgetNonTopRate As New DataSet
                    dsgetNonTopRate = DSGetTransferRateTopContracts(PubTopcode, "Infants", passShift, PubDepdate)

                    If dsgetNonTopRate.Tables(0).Rows.Count > 0 Then


                        Dim getIndRate As Decimal = ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(4))) * PubInfantsQty)

                        passTransRate = passTransRate + ((Convert.ToDecimal(dsgetNonTopRate.Tables(0).Rows(0)(4))) * PubInfantsQty)


                        If passShift = "DAY" Then
                            getDayTransRateI = getDayTransRateI + getIndRate
                        End If

                        If passShift = "NIGHT" Then
                            getNightTransRateI = getNightTransRateI + getIndRate
                        End If







                    Else
                        MessageBox.Show("Transfer Rates Are Not Defined For Infants In The Activ Contract", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If

                End If

                Dim finalTransCondep As Decimal = passTransRate / 2


                Dim finalDayTrans As Decimal = (getDayTransRateA + getDayTransRateC + getDayTransRateI) / 2
                Dim finalNightTrans As Decimal = (getNightTransRateA + getNightTransRateC + getNightTransRateI) / 2



                txtRateDayT.Text = finalDayTrans.ToString
                txtRateNightT.Text = finalNightTrans.ToString


                txtTransferrateDep.Text = finalTransCondep.ToString

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Function DSGetTransferRate(ByVal resType As String, ByVal guestType As String, ByVal shift As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim getResType As String = resType
            Dim getGuestType As String = guestType
            Dim getShift As String = shift


            dcSearch = New SqlCommand("select * from dbo.[Boat.Transferrates] where TopcontractId=' ' and Custype=@ResType and Guesttype=@GuesType and Shift=@Shift", Conn)
            dcSearch.Parameters.Add("@ResType", SqlDbType.VarChar).Value = getResType
            dcSearch.Parameters.Add("@GuesType", SqlDbType.VarChar).Value = getGuestType
            dcSearch.Parameters.Add("@Shift", SqlDbType.VarChar).Value = getShift


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            ' If count > 0 Then
            DSGetTransferRate = dsMain
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
    Function DSGetTransferRateTopContracts(ByVal TopId As String, ByVal Guesttype As String, ByVal Shift As String, ByVal ResDate As DateTime) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim getTopId As String = TopId
            Dim getGuesttype As String = Guesttype
            Dim getShift As String = Shift
            Dim getResDate As DateTime = ResDate

            dcSearch = New SqlCommand("GetTransferRateContracts_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcSearch.Parameters.Add("@TopId", SqlDbType.VarChar).Value = getTopId
            dcSearch.Parameters.Add("@Guesttype", SqlDbType.VarChar).Value = getGuesttype
            dcSearch.Parameters.Add("@Shift", SqlDbType.VarChar).Value = getShift
            dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = getResDate

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            'If count > 0 Then
            DSGetTransferRateTopContracts = dsMain
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
    Private Sub InsertInvProMaster()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Dim numtostrcls As New clsConversion

        Dim CurrentUser As String = CurrUser


        Dim FinalTotWords As String = numtostrcls.ConvertNumberToWords(Convert.ToDecimal(txtFinaltot.Text.Trim))


        Try




            dcInsertNewAcc = New SqlCommand("InsertInvProMaster_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ResNO", SqlDbType.VarChar).Value = cmbResnos.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ProInvDate", SqlDbType.DateTime).Value = DtToday.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRate.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@DisscountRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtDisscounts.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@TransferRateArr", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTransferrateArr.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@TransferRateDep", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTransferrateDep.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@TransferRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTransferrate.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@FinalTot", SqlDbType.Decimal).Value = Convert.ToDecimal(txtFinaltot.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@BedNights", SqlDbType.Int).Value = Convert.ToInt16(txtBednights.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@BedTax", SqlDbType.Int).Value = Convert.ToDecimal(txtBedtimetax.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@TotBedtax", SqlDbType.Int).Value = Convert.ToDecimal(txtTotBedtimetax.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = txtRemarks.Text.Trim
            dcInsertNewAcc.Parameters.Add("@RefNo", SqlDbType.VarChar).Value = txtReferences.Text.Trim
            dcInsertNewAcc.Parameters.Add("@RefNoTop", SqlDbType.VarChar).Value = txtReferencesTop.Text.Trim()
            dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser
            dcInsertNewAcc.Parameters.Add("@PrefixCode", SqlDbType.VarChar).Value = PubPrefixcode
            dcInsertNewAcc.Parameters.Add("@ResType", SqlDbType.VarChar).Value = PubMaintype
            dcInsertNewAcc.Parameters.Add("@ProInvNoMas", SqlDbType.VarChar).Value = txtProninvnoMas.Text.Trim
            dcInsertNewAcc.Parameters.Add("@FinaltotWords", SqlDbType.VarChar).Value = FinalTotWords

            dcInsertNewAcc.Parameters.Add("@AdultRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRateAdult.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@ChildRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRateChild.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@AiRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRateAI.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@DayTransRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRateDayT.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@NightTransRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRateNightT.Text.Trim)


            dcInsertNewAcc.Parameters.Add("@Xamsnit", SqlDbType.Decimal).Value = Convert.ToDecimal(txt24dinner.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@Newyrnit", SqlDbType.Decimal).Value = Convert.ToDecimal(txtNewyeardinner.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@DisName", SqlDbType.VarChar).Value = txtDiscountname.Text.Trim


            PubResno = cmbResnos.Text.Trim


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Pro Forma Invoice Saved Successfully", "Save Pro Forma Invoice Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub InsertInvRatesPeriod(ByVal Resno As String, ByVal sdate As Date, ByVal edate As Date, ByVal chdate As Date, ByVal rate As Decimal, ByVal rateType As String, ByVal Room As String, ByVal RoomType As String, ByVal RoomID As Integer, ByVal Pax As Integer)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Dim getResno As String = Resno
        Dim getsdate As Date = sdate
        Dim getedate As Date = edate
        Dim getchdate As Date = chdate
        Dim geterate As Decimal = rate
        Dim getrateType As String = rateType
        Dim getRoom As String = Room
        Dim getRoomType As String = RoomType
        Dim getRoomId As Integer = RoomID
        Dim getPax As Integer = Pax

        Try

            dcInsertNewAcc = New SqlCommand("InsertPeriodRates_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = getResno
            dcInsertNewAcc.Parameters.Add("@Sdate", SqlDbType.Date).Value = getsdate
            dcInsertNewAcc.Parameters.Add("@Edate", SqlDbType.Date).Value = getedate
            dcInsertNewAcc.Parameters.Add("@Chdate", SqlDbType.Date).Value = getchdate
            dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = geterate
            dcInsertNewAcc.Parameters.Add("@Type", SqlDbType.VarChar).Value = getrateType
            dcInsertNewAcc.Parameters.Add("@Room", SqlDbType.VarChar).Value = getRoom
            dcInsertNewAcc.Parameters.Add("@RoomType", SqlDbType.VarChar).Value = getRoomType
            dcInsertNewAcc.Parameters.Add("@RoomId", SqlDbType.Int).Value = getRoomId
            dcInsertNewAcc.Parameters.Add("@Pax", SqlDbType.Int).Value = getPax



            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub InsertInvProTax()

        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim CurrentUser As String = CurrUser

            dcSearch = New SqlCommand("select * from dbo.[Invoice.Proforma.Tax.Temp] where ReservationNo=@ReservationNo AND Createdby=@Createdby", Conn)
            dcSearch.Parameters.Add("@ReservationNo", SqlDbType.VarChar).Value = cmbResnos.Text.Trim
            dcSearch.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            Conn.Close()

            Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

            While DScount >= 0

                dcInsertNewAcc = New SqlCommand("InsertInvProTax_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@ResNO", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(1).ToString
                dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(2).ToString
                dcInsertNewAcc.Parameters.Add("@Taxid", SqlDbType.Int).Value = dsMain.Tables(0).Rows(DScount)(3).ToString

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()
                DScount = DScount - 1
            End While

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Pro-formaInvoicing", "Add")

        If CheckAccess = True Then




            Try


                If String.Compare(btAdd.Text, "Create", False) = 0 Then

                    ClearFields()
                    btAdd.Text = "Save"
                    btEdit.Enabled = False
                    btDel.Enabled = False
                    btPrint.Enabled = False
                    btRev.Enabled = False
                    tabProforma.TabPages(1).PageEnabled = True
                    tabProforma.TabPages(0).PageEnabled = False


                    tabProforma.SelectedTabPageIndex = 1

                Else

                    If FieldValidation() = False Then
                        MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                        Exit Sub
                    Else
                        Dim dscheckAddbefore As New DataSet
                        dscheckAddbefore = DSCheckInsertProInv()

                        If dscheckAddbefore Is Nothing Then

                            Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Proforma Invoice", "Save Proforma Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                            If bt = Windows.Forms.DialogResult.Yes Then
                                InsertInvProMaster()
                                InsertInvProTax()

                                UpdatePeriodrates()

                                DeleteTempTax(cmbResnos.Text.Trim)
                            End If

                        Else
                            MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If




                        LoadGrid()

                        btAdd.Text = "Create"
                        btEdit.Enabled = True
                        btDel.Enabled = True
                        btPrint.Enabled = True
                        btRev.Enabled = True
                        tabProforma.TabPages(1).PageEnabled = False
                        tabProforma.TabPages(0).PageEnabled = True
                        tabProforma.SelectedTabPageIndex = 0
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub UpdatePeriodrates()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()
            dcSearch = New SqlCommand("select (convert(varchar,dateadd(day,-1,max(Validsdate)),103)  +  '  TO  ' + convert(varchar,dateadd(day,-1,max(Validedate)),103) ) as Period ,sum(Rate) as Rate from [Invoice.Performa.PeriodRates]  where resno=@Resno  group by Validsdate", Conn)
            dcSearch.Parameters.Add("@Resno", SqlDbType.VarChar).Value = cmbResnos.Text.Trim

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then



                If dsMain.Tables(0).Rows.Count = 1 Then

                    Dim P1 As String = dsMain.Tables(0).Rows(0)(0).ToString
                    Dim P1rate As Decimal = dsMain.Tables(0).Rows(0)(1).ToString


                    UpdateP1P2(P1, P1rate, "", 0, cmbResnos.Text.Trim, txtProninvno.Text.Trim, 1)

                End If


                If dsMain.Tables(0).Rows.Count = 2 Then

                    Dim P1 As String = dsMain.Tables(0).Rows(0)(0).ToString
                    Dim P1rate As Decimal = dsMain.Tables(0).Rows(0)(1).ToString

                    Dim P2 As String = dsMain.Tables(0).Rows(1)(0).ToString
                    Dim P2rate As Decimal = dsMain.Tables(0).Rows(1)(1).ToString


                    UpdateP1P2(P1, P1rate, P2, P2rate, cmbResnos.Text.Trim, txtProninvno.Text.Trim, 2)

                End If




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
    Private Sub UpdateP1P2(ByVal P1 As String, ByVal P1rate As Decimal, ByVal P2 As String, ByVal P2rate As Decimal, ByVal resno As String, ByVal invno As String, ByVal Ptype As Integer)

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getP1 As String = P1
            Dim getP1rate As Decimal = P1rate

            Dim getP2 As String = P2
            Dim getP2rate As Decimal = P2rate

            Dim getresno As String = resno
            Dim getinvno As String = invno


            Dim getPType As Integer = Ptype


            If getPType = 1 Then



                dcInsertNewAcc = New SqlCommand("update [Invoice.Proforma.Master] set P1=@P1 , P1rate=@P1rate  where ResNO=@Resno and ProInvNo=@Invno", Conn)
                dcInsertNewAcc.CommandType = CommandType.Text

                dcInsertNewAcc.Parameters.Add("@P1", SqlDbType.VarChar).Value = getP1
                dcInsertNewAcc.Parameters.Add("@P1rate", SqlDbType.Decimal).Value = getP1rate

                dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = getresno
                dcInsertNewAcc.Parameters.Add("@Invno", SqlDbType.VarChar).Value = getinvno

            End If





            If getPType = 2 Then



                dcInsertNewAcc = New SqlCommand("update [Invoice.Proforma.Master] set P1=@P1 , P2=@P2 , P1rate=@P1rate , P2rate=@P2rate where ResNO=@Resno and ProInvNo=@Invno", Conn)
                dcInsertNewAcc.CommandType = CommandType.Text

                dcInsertNewAcc.Parameters.Add("@P1", SqlDbType.VarChar).Value = getP1
                dcInsertNewAcc.Parameters.Add("@P2", SqlDbType.VarChar).Value = getP2
                dcInsertNewAcc.Parameters.Add("@P1rate", SqlDbType.Decimal).Value = getP1rate
                dcInsertNewAcc.Parameters.Add("@P2rate", SqlDbType.Decimal).Value = getP2rate
                dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = getresno
                dcInsertNewAcc.Parameters.Add("@Invno", SqlDbType.VarChar).Value = getinvno

            End If


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Sub ClearFields()

        txtProninvno.Text = "PRO-INV-"
        txtProninvnoMas.Text = GetProInvCodeMas("PROMAIN")

        GetServerDate()

        gcResdetails.DataSource = Nothing
        gcPax.DataSource = Nothing
        gcTaxDetail.DataSource = Nothing
        txtRate.Text = ""
        txtDisscounts.Text = ""
        txtTransferrateArr.Text = ""

        txtFinaltot.Text = ""
        txtBednights.Text = ""
        txtRemarks.Text = ""
        txtReferences.Text = ""
        txtReferencesTop.Text = ""

        txtBedtimetax.Text = "6"
        txtTotBedtimetax.Text = ""

    End Sub
    Function FieldValidation() As Boolean
        Return IIf(String.Compare(cmbResnos.Text, "", False) = 0 Or String.Compare(txtRate.Text, "", False) = 0 Or String.Compare(txtTransferrateArr.Text, "", False) = 0 Or String.Compare(txtFinaltot.Text, "", False) = 0 Or String.Compare(txtBednights.Text, "", False) = 0, 0, 1)
    End Function
    Function DSCheckInsertProInv() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select * from dbo.[Invoice.Proforma.Master] where ProInvNo=@ProInvNo and ResNO=@ResNO", Conn)
            dcSearch.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text.Trim
            dcSearch.Parameters.Add("@ResNO", SqlDbType.VarChar).Value = cmbResnos.Text.Trim

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertProInv = dsMain
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
    Private Sub DeleteTempTax(ByVal getResno As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Dim Resno As String = getResno

        dcInsertNewAcc = New SqlCommand("DelTempTaxProInv_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = Resno
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[Invoice.Proforma.Master] where status='OPEN' order by ProInvNoMas desc", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcProforma.DataSource = dsMain.Tables(0)

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
            PubIsEdit = 1

            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select *  from dbo.[Invoice.Proforma.Master] where ProInvNo= '{0}'", gvProforma.GetRowCellValue(gvProforma.FocusedRowHandle, "ProInvNo")), Conn)
            daShow.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabProforma.TabPages(1).PageEnabled = True
            tabProforma.TabPages(0).PageEnabled = False

            tabProforma.SelectedTabPageIndex = 1

            txtProninvno.Text = dsShow.Tables(0).Rows(0).Item("ProInvNo")
            PubResno = dsShow.Tables(0).Rows(0).Item("ProInvNo")
            PubResno3 = dsShow.Tables(0).Rows(0).Item("ResNO")

            'txtProninvno.Enabled = False



            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("ProInvNoMas"))) Then
                Dim MasTaxInv As String = dsShow.Tables(0).Rows(0).Item("ProInvNoMas")

                If MasTaxInv = "" Then
                    txtProninvnoMas.Text = ""

                Else
                    txtProninvnoMas.Text = MasTaxInv

                End If


            Else

                txtProninvnoMas.Text = ""

            End If







            DtToday.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("ProInvDate"))
            DtToday.Enabled = False

            cmbResnos.Text = dsShow.Tables(0).Rows(0).Item("ResNO")
            PubResno2 = dsShow.Tables(0).Rows(0).Item("ResNO")
            cmbResnos.ClosePopup()



            txtRate.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("Rate"))


            txtDisscounts.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("DisscountRate"))
            txtTransferrateArr.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("TransferRateArr"))
            txtTransferrateDep.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("TransferRateDep"))
            txtTransferrate.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("TransferRate"))
            txtFinaltot.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("FinalTot"))
            txtBednights.Text = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("BedNights"))
            txtBedtimetax.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("BedTax"))
            txtTotBedtimetax.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("TotBedtax"))
            txtRemarks.Text = dsShow.Tables(0).Rows(0).Item("Remarks")
            txtReferences.Text = dsShow.Tables(0).Rows(0).Item("RefNo")
            txtReferencesTop.Text = dsShow.Tables(0).Rows(0).Item("RefNoTop")
            txtDiscountname.Text = dsShow.Tables(0).Rows(0).Item("Disname")


            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("AdultRate"))) Then

                txtRateAdult.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("AdultRate"))

            Else

                txtRateAdult.Text = "0.00"

            End If



            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("ChildRate"))) Then

                txtRateChild.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("ChildRate"))

            Else

                txtRateChild.Text = "0.00"

            End If



            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("AiRate"))) Then

                txtRateAI.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("AiRate"))

            Else

                txtRateAI.Text = "0.00"

            End If


            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("DayTransRate"))) Then

                txtRateDayT.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("DayTransRate"))

            Else

                txtRateDayT.Text = "0.00"

            End If



            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("NightTransRate"))) Then

                txtRateNightT.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("NightTransRate"))

            Else

                txtRateNightT.Text = "0.00"

            End If



            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("Xamsnit"))) Then

                txt24dinner.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("Xamsnit"))
                CheckEdit1.Checked = True

            Else

                txt24dinner.Text = "0.00"

            End If




            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("Newyrnit"))) Then

                txtNewyeardinner.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("Newyrnit"))
                CheckEdit2.Checked = True

            Else

                txtNewyeardinner.Text = "0.00"

            End If





            ' LoadResDetails()

            LoadResDetailsInvCreated()

            Dim DSPax As New DataSet
            DSPax = DSLoadResPaxDetails()

            If DSPax.Tables(0).Rows.Count > 0 Then
                gcPax.DataSource = DSPax.Tables(0)
            End If


            LoadInvTaxMasterDetails()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub gvProforma_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvProforma.DoubleClick
        ShowGridDets()
    End Sub
    Private Sub DeleteTempProInvTax(ByVal getResno As String)

        Try


            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim Resno As String = getResno

            dcInsertNewAcc = New SqlCommand("DelTempTaxProInv_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = Resno

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try


    End Sub
    Private Sub DeleteTempProInvTaxByTaxId(ByVal getProInvNo As String, ByVal getProTaxId As Integer)

        Try


            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim ProInvNo As String = getProInvNo
            Dim TaxId As Integer = getProTaxId

            dcInsertNewAcc = New SqlCommand("DelTaxTempProInvBytaxId_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = getProInvNo
            dcInsertNewAcc.Parameters.Add("@TaxId", SqlDbType.VarChar).Value = getProTaxId


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub DeleteProInvTax(ByVal getProInvNo As String)

        Try


            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim ProInvNo As String = getProInvNo

            dcInsertNewAcc = New SqlCommand("DelTaxProInv_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = ProInvNo

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub DeleteProInvPeriodRate()

        Try


            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand


            dcInsertNewAcc = New SqlCommand("DelResInPeriodRate_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = cmbResnos.Text.Trim

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub btTaxdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTaxdel.Click
        Try

            DeleteTempProInvTaxByTaxId(txtProninvno.Text.Trim, Convert.ToInt16(gvProTax.GetRowCellValue(gvProTax.FocusedRowHandle, "Taxid")))

            gcTaxDetail.DataSource = Nothing
            LoadInvTaxDetails()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        End Try
    End Sub
    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Pro-formaInvoicing", "Edit")

        If CheckAccess = True Then


            Try


                If String.Compare(btEdit.Text, "Edit", False) = 0 Then

                    btEdit.Text = "Update"
                    btAdd.Enabled = False
                    btDel.Enabled = False
                    btPrint.Enabled = False
                    btRev.Enabled = False

                    ' tabProforma.SelectedTabPageIndex = 1

                Else
                    If FieldValidation() = False Then
                        MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                        Exit Sub
                    Else
                        Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Proforma Invoice", "Update Proforma Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If bt = Windows.Forms.DialogResult.Yes Then

                            UpdateProInvMaster()

                            Dim dscheckAddbefore As New DataSet
                            dscheckAddbefore = DSCheckProInvTaxMaster()

                            If dscheckAddbefore Is Nothing Then
                                InsertInvProTax()
                            End If
                            DeleteTempTax(cmbResnos.Text.Trim)
                        End If

                    End If

                    LoadGrid()

                    btEdit.Text = "Edit"
                    btAdd.Enabled = True
                    btDel.Enabled = True
                    tabProforma.TabPages(1).PageEnabled = False
                    tabProforma.SelectedTabPageIndex = 0

                    tabProforma.TabPages(0).PageEnabled = True

                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub UpdateProInvMaster()

        Try
            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand
            Dim numtostrcls As New clsConversion

            Dim FinalTotWords As String = numtostrcls.ConvertNumberToWords(Convert.ToDecimal(txtFinaltot.Text.Trim))


            dcInsertNewAcc = New SqlCommand("UpdateProInvMas_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ResNO", SqlDbType.VarChar).Value = cmbResnos.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRate.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@DisscountRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtDisscounts.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@TransferRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTransferrateArr.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@FinalTot", SqlDbType.Decimal).Value = Convert.ToDecimal(txtFinaltot.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@BedNights", SqlDbType.Int).Value = Convert.ToInt16(txtBednights.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@BedTax", SqlDbType.Int).Value = Convert.ToDecimal(txtBedtimetax.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@TotBedtax", SqlDbType.Int).Value = Convert.ToDecimal(txtTotBedtimetax.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = txtRemarks.Text.Trim
            dcInsertNewAcc.Parameters.Add("@RefNo", SqlDbType.VarChar).Value = txtReferences.Text.Trim
            dcInsertNewAcc.Parameters.Add("@RefNoTop", SqlDbType.VarChar).Value = txtReferencesTop.Text.Trim()
            dcInsertNewAcc.Parameters.Add("@FinaltotWords", SqlDbType.VarChar).Value = FinalTotWords
            dcInsertNewAcc.Parameters.Add("@NightTransRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRateNightT.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@DayTransRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRateDayT.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@AiRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRateAI.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@ChildRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRateChild.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@AdultRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtRateAdult.Text.Trim)

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Proforma Invoice Updated Successfully", "Update Proforma Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub UpdateResPaymentDeails()

        Try
            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand


            dcInsertNewAcc = New SqlCommand("UpdateResMasterPaymentStatus_SP", Conn) With {.CommandType = CommandType.StoredProcedure}


            dcInsertNewAcc.Parameters.Add("@ResNO", SqlDbType.VarChar).Value = cmbResnos.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Paymentstatus", SqlDbType.VarChar).Value = txtPaystatus.Text.Trim

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Payment Details Updated Successfully", "Update Payment Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Function DSCheckProInvTaxMaster() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select * from dbo.[Invoice.Proforma.Tax] where ProInvNo=@ProInvNo", Conn)
            dcSearch.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text.Trim


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckProInvTaxMaster = dsMain
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
    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Pro-formaInvoicing", "Delete")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Delete This Proforma Invoice", "Delete Proforma Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveProInv()


                End If
                LoadGrid()
                tabProforma.TabPages(1).PageEnabled = False
                tabProforma.TabPages(0).PageEnabled = True
                tabProforma.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Private Sub InactiveProInv()

        Try

            Dim CurrentUser As String = CurrUser


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand
            dcInsertNewAcc = New SqlCommand("InactiveProInv_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Inactivatedby", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Proforma Invoice Deleted Successfully", "Delete  Proforma Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub btUpdateRates_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GetArrTransferRateTopContracts()
        'GetDepTransferRateTopContracts()
    End Sub
    Private Sub txtTransferrateArr_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransferrateArr.EditValueChanged, txtTransferrateDep.EditValueChanged
        txtTransferrate.Text = IIf(String.IsNullOrEmpty(txtTransferrateArr.Text), 0, Val(txtTransferrateArr.Text)) + IIf(String.IsNullOrEmpty(txtTransferrateDep.Text), 0, Val(txtTransferrateDep.Text))
    End Sub

    Private Sub txtRate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRate.EditValueChanged

        txtFinaltot.Text = IIf(String.IsNullOrEmpty(txtRate.Text), 0, Val(txtRate.Text)) - IIf(String.IsNullOrEmpty(txtDisscounts.Text), 0, Val(txtDisscounts.Text)) + IIf(String.IsNullOrEmpty(txtTransferrate.Text), 0, Val(txtTransferrate.Text)) + IIf(String.IsNullOrEmpty(txt24dinner.Text), 0, Val(txt24dinner.Text)) + IIf(String.IsNullOrEmpty(txtNewyeardinner.Text), 0, Val(txtNewyeardinner.Text))

        '  txtFinaltot.Text = IIf(String.IsNullOrEmpty(txtRate.Text), 0, Val(txtRate.Text)) - IIf(String.IsNullOrEmpty(txtDisscounts.Text), 0, Val(txtDisscounts.Text)) + IIf(String.IsNullOrEmpty(txtTransferrate.Text), 0, Val(txtTransferrate.Text))
    End Sub
    Private Sub LoadRoomRatesTopContracts()


        Try
            '-----------------------For Top------------------------------------------------------------------------------------
            If PubResType = "TOP" Then

                Dim DSPax As New DataSet
                DSPax = DSLoadResPaxDetails()
                ' Dim Gettotbednights As Integer = Convert.ToInt16(txtBednights.Text.Trim) - 1


                '  Dim Gettotbednights As Integer = Convert.ToInt16(txtBednights.Text.Trim)

                Dim GetResDate As DateTime = PubResdate


                Dim FinalGetRate As Decimal


                If DSPax.Tables(0).Rows.Count > 0 Then

                    Dim GetRate As Decimal = 0.0

                    Dim DScount As Integer = DSPax.Tables(0).Rows.Count - 1

                    Dim GetChildrenQty As Integer = Convert.ToInt16(DSPax.Tables(0).Rows(DScount)(6))



                    While DScount >= 0

                        Dim Gettotbednights As Integer = Convert.ToInt16(DSPax.Tables(0).Rows(DScount)(3)) - 1

                        Dim GetResDateInc As Integer = 0


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

                                Dim GetValidSdate As Date = Convert.ToDateTime(DSRoomRates.Tables(0).Rows(0)(1)).ToShortDateString
                                Dim GetValidEdate As Date = Convert.ToDateTime(DSRoomRates.Tables(0).Rows(0)(2)).ToShortDateString


                                Dim GetResRoomId As Integer = Convert.ToInt16(DSPax.Tables(0).Rows(DScount)(7))


                                Dim CalRoomRate As Decimal = 0

                                If GetChildrenQty > 0 Then

                                    Dim Chilldqty As Integer = GetChildrenQty

                                    Dim DSRoomRatesChild As New DataSet
                                    DSRoomRatesChild = DSGetRoomRateTopContracts(PubTopcode, PubMP, DSPax.Tables(0).Rows(DScount)(0).ToString, "Child", DateAdd(DateInterval.Day, +GetResDateInc, GetResDate))

                                    If DSRoomRatesChild.Tables(0).Rows.Count > 0 Then

                                        CalRoomRate = GetRoomRate * GetTotPax
                                        Dim ChildRate As Decimal = Convert.ToDecimal(DSRoomRatesChild.Tables(0).Rows(0)(0)) * Chilldqty

                                        Dim NewAdultRate As Decimal = (CalRoomRate / GetTotPax)
                                        Dim NewCalRoomRate As Decimal = NewAdultRate * (GetTotPax - Chilldqty) + ChildRate

                                        CalRoomRate = NewCalRoomRate
                                        PubAdultSeparately = PubAdultSeparately + (NewCalRoomRate - ChildRate)
                                        PubChildSeparately = PubChildSeparately + ChildRate

                                        InsertInvRatesPeriod(cmbResnos.Text.Trim, GetValidSdate, GetValidEdate, DateAdd(DateInterval.Day, +GetResDateInc, GetResDate), (NewCalRoomRate - ChildRate), "Adult", DSPax.Tables(0).Rows(DScount)(0).ToString, DSPax.Tables(0).Rows(DScount)(1).ToString, GetResRoomId, GetTotPax)
                                        InsertInvRatesPeriod(cmbResnos.Text.Trim, GetValidSdate, GetValidEdate, DateAdd(DateInterval.Day, +GetResDateInc, GetResDate), ChildRate, "Child", DSPax.Tables(0).Rows(DScount)(0).ToString, DSPax.Tables(0).Rows(DScount)(1).ToString, GetResRoomId, GetTotPax)



                                    End If





                                Else

                                    CalRoomRate = GetRoomRate * GetTotPax
                                    PubAdultSeparately = PubAdultSeparately + CalRoomRate

                                    InsertInvRatesPeriod(cmbResnos.Text.Trim, GetValidSdate, GetValidEdate, DateAdd(DateInterval.Day, +GetResDateInc, GetResDate), CalRoomRate, "Adult", DSPax.Tables(0).Rows(DScount)(0).ToString, DSPax.Tables(0).Rows(DScount)(1).ToString, GetResRoomId, GetTotPax)

                                End If



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
                    txtRate.Text = GetRate.ToString





                    FinalGetRate = GetRate


                    txtRateAdult.Text = PubAdultSeparately.ToString
                    txtRateChild.Text = PubChildSeparately.ToString


                End If



                '----------------------------------------------------------------------






               



                    '----------------------------------------------------------------------------

                    Dim GrantTotalAI As Decimal = 0

                    If PubMP = "AI" Then

                        Dim getAdultcount As Integer = 0
                        Dim getChildcount As Integer = 0
                        Dim getInfantscount As Integer = 0


                        Dim GrantTotaAd As Decimal = 0
                        Dim GrantTotalChd As Decimal = 0
                        Dim GrantTotalInfants As Decimal = 0


                        Dim bednights As Integer = Convert.ToInt16(txtBednights.Text.Trim)

                        Dim dsgetAllInclusive As New DataSet


                        If PubAdultQty = 0 Then
                            getAdultcount = 0

                        Else
                            getAdultcount = PubAdultQty
                            dsgetAllInclusive = DSLoadAllInclusiveContracts(PubTopcode, "Adults")
                            GrantTotaAd = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getAdultcount * bednights
                            GrantTotalAI = GrantTotalAI + GrantTotaAd
                        End If


                        If PubChildQty = 0 Then
                            getChildcount = 0

                        Else
                            getChildcount = PubChildQty
                            dsgetAllInclusive = DSLoadAllInclusiveContracts(PubTopcode, "Children")
                            GrantTotalChd = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getChildcount * bednights
                            GrantTotalAI = GrantTotalAI + GrantTotalChd

                        End If


                        If PubInfantsQty = 0 Then
                            getInfantscount = 0

                        Else

                            getInfantscount = PubInfantsQty
                            dsgetAllInclusive = DSLoadAllInclusiveContracts(PubTopcode, "Infants")
                            GrantTotalInfants = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getInfantscount * bednights
                            GrantTotalAI = GrantTotalAI + GrantTotalInfants

                        End If




                    End If

                    txtRate.Text = FinalGetRate + GrantTotalAI
                    PubAISeparately = PubAISeparately + GrantTotalAI
                    txtRateAI.Text = PubAISeparately
                    '-------------------------------------------------------------------------

                End If






                '---------------------------------------------------------------------------






                '---------------------------------------------------------------------------































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

                    Dim Gettotbednights As Integer = Convert.ToInt16(txtBednights.Text.Trim) - 1
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

                    Dim GrantTotalAI As Decimal = 0

                    If PubMP = "AI" Then

                        Dim getAdultcount As Integer = 0
                        Dim getChildcount As Integer = 0
                        Dim getInfantscount As Integer = 0


                        Dim GrantTotaAd As Decimal = 0
                        Dim GrantTotalChd As Decimal = 0
                        Dim GrantTotalInfants As Decimal = 0


                        Dim bednights As Integer = Convert.ToInt16(txtBednights.Text.Trim)

                        Dim dsgetAllInclusive As New DataSet


                        If PubAdultQty = 0 Then
                            getAdultcount = 0

                        Else
                            getAdultcount = PubAdultQty
                            dsgetAllInclusive = DSLoadAllInclusiveFITS("FIT", "Adults")
                            GrantTotaAd = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getAdultcount * bednights
                            GrantTotalAI = GrantTotalAI + GrantTotaAd
                        End If


                        If PubChildQty = 0 Then
                            getChildcount = 0

                        Else
                            getChildcount = PubChildQty
                            dsgetAllInclusive = DSLoadAllInclusiveFITS("FIT", "Children")
                            GrantTotalChd = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getChildcount * bednights
                            GrantTotalAI = GrantTotalAI + GrantTotalChd

                        End If


                        If PubInfantsQty = 0 Then
                            getInfantscount = 0

                        Else

                            getInfantscount = PubInfantsQty
                            dsgetAllInclusive = DSLoadAllInclusiveFITS("FIT", "Infants")
                            GrantTotalInfants = Convert.ToDecimal(dsgetAllInclusive.Tables(0).Rows(0)(0).ToString) * getInfantscount * bednights
                            GrantTotalAI = GrantTotalAI + GrantTotalInfants

                        End If
                    End If



                    '-------------------------------------------------------------------------------
                    txtRate.Text = TotRatePerContract + GrantTotalAI

                    PubAISeparately = PubAISeparately + GrantTotalAI


                    txtRateAI.Text = PubAISeparately



                    'txtTotal.Text = GrandTotRatePerContract
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

                    Dim Gettotbednights As Integer = Convert.ToInt16(txtBednights.Text.Trim) - 1
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

                    txtRate.Text = TotRatePerContract
                    'txtTotal.Text = GrandTotRatePerContract
                End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
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
    Private Sub LoadDiscounts()


        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim Disscountid As Integer = PubDisId

            Conn.Open()
            dcSearch = New SqlCommand("select dbo.[Discounts.Master].DisAmt from dbo.[Discounts.Master] where dbo.[Discounts.Master].DisID=@GetDisId", Conn)
            dcSearch.Parameters.Add("@GetDisId", SqlDbType.Int).Value = PubDisId

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            If dsMain.Tables(0).Rows.Count > 0 Then

                Dim Dscount As Decimal = Convert.ToDecimal(dsMain.Tables(0).Rows(0)(0).ToString)
                Dim getTotal As Decimal = Convert.ToDecimal(Convert.ToDecimal(txtRate.Text.Trim) - (Convert.ToDecimal(txtRate.Text.Trim) * (Dscount / 100)))
                txtDisscounts.Text = getTotal.ToString



            Else

                txtDisscounts.Text = "0.00"


            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub


    Private Sub LoadBedTax()

        Dim TotPax As Integer = PubAdultQty + PubChildQty + PubInfantsQty



        Dim TotBedtax As Decimal



        If PubArrDate > "2014-11-30" Then

            TotBedtax = Val(txtBednights.Text.Trim) * 0 * TotPax


        ElseIf PubDepdate <= "2014-11-30" Then

            TotBedtax = Val(txtBednights.Text.Trim) * Val(txtBedtimetax.Text.Trim) * TotPax


        ElseIf PubDepdate >= "2014-11-30" And PubArrDate <= "2014-11-30" Then

            Dim inDtDep As DateTime = Convert.ToDateTime("2014" + "/" + "11" + "/" + "30")

            Dim theDays As Integer = DateDiff(DateInterval.Day, inDtDep, PubDepdate)

            Dim thetotdays As Integer = Convert.ToInt16(txtBednights.Text.Trim)


            Dim theDiff As Integer = thetotdays - theDays

            ' TotBedtax = Convert.ToInt16(txtBednights.Text.Trim) - theDays * Val(txtBedtimetax.Text.Trim) * TotPax


            'If PubDepdate = "2014-12-01" Then

            TotBedtax = (theDiff + 1) * Val(txtBedtimetax.Text.Trim) * TotPax

            'Else

            'TotBedtax = theDiff * Val(txtBedtimetax.Text.Trim) * TotPax

            'End If





        End If




        txtTotBedtimetax.Text = Val(txtBednights.Text.Trim) * Val(txtBedtimetax.Text.Trim) * TotPax

        ' txtTotBedtimetax.Text = "0.00"


    End Sub

    Private Sub txtBedtimetax_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBedtimetax.EditValueChanged
        LoadBedTax()
    End Sub
    Function GetProInvCode(ByVal maintype As String, ByVal topcode As String) As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()

        Try

            Dim GetTopcode As String = maintype
            Dim GetPrefix As String = "INV-PRO-" & topcode & "-"

            PubPrefixcode = GetPrefix
            PubMaintype = GetTopcode

            Conn.Open()


            'dcGetCode = New SqlCommand("spGetAutoNo_ProInv", Conn)
            dcGetCode = New SqlCommand("spGetAutoNo_ProInv_Top", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = GetTopcode
            dcGetCode.Parameters.Add("@PREFIX1", SqlDbType.NVarChar).Value = GetPrefix
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output
            dcGetCode.ExecuteNonQuery()


            If (Not IsDBNull(dcGetCode.Parameters("@Currcode").Value)) Then

                GetProInvCode = dcGetCode.Parameters("@Currcode").Value

                Return GetProInvCode

            Else

                GetProInvCode = ""

                Return GetProInvCode

            End If





        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function
    Function GetProInvCodeMas(ByVal maintype As String) As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()

        Try

            Dim GetTopcode As String = maintype
            Dim GetPrefix As String = "PRO-ERI-13-"

            PubPrefixcode = GetPrefix
            PubMaintype = GetTopcode

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo_ProInv", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = GetTopcode
            dcGetCode.Parameters.Add("@PREFIX1", SqlDbType.NVarChar).Value = GetPrefix
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output
            dcGetCode.ExecuteNonQuery()




            If (Not IsDBNull(dcGetCode.Parameters("@Currcode").Value)) Then

                GetProInvCodeMas = dcGetCode.Parameters("@Currcode").Value


                Return GetProInvCodeMas

            Else

                GetProInvCodeMas = ""

                Return GetProInvCodeMas

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function

    Private Sub cbTopcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTopcode.SelectedIndexChanged

    End Sub
    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Pro-formaInvoicing", "Print")

        If CheckAccess = True Then




            If PubResType = "TOP" Then

                If PubTopcode = "BOC" Or PubTopcode = "AGD" Or PubTopcode = "EXP" Or PubTopcode = "WEB" Or PubTopcode = "FITA" Or PubTopcode = "FITL" Or PubTopcode = "FITD" Then
                    PrintPerformaFitTop()

                Else
                    PrintPerforma()
                End If

            Else
                PrintPerformaFit()
            End If
            tabProforma.TabPages(1).PageEnabled = False
            tabProforma.TabPages(0).PageEnabled = True
            tabProforma.SelectedTabPageIndex = 0

            'Dim TestDecimal As Decimal = 123.2
            ''Dim strStringValue As String = IIf(TestDecimal = 0.0, "", TestDecimal.ToString())
            'Dim numtostrcls As New clsConversion


            ' '' MsgBox(strStringValue)

            'MsgBox(numtostrcls.ConvertNumberToWords(TestDecimal))


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Function retWord(ByVal Num As Decimal) As String
        'This two dimensional array store the primary word convertion of number.
        retWord = ""
        Dim ArrWordList(,) As Object = {{0, ""}, {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"}, _
                                        {5, "Five"}, {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"}, _
                                        {10, "Ten"}, {11, "Eleven"}, {12, "Twelve"}, {13, "Thirteen"}, {14, "Fourteen"}, _
                                        {15, "Fifteen"}, {16, "Sixteen"}, {17, "Seventeen"}, {18, "Eighteen"}, {19, "Nineteen"}, _
                                        {20, "Twenty"}, {30, "Thirty"}, {40, "Forty"}, {50, "Fifty"}, {60, "Sixty"}, _
                                        {70, "Seventy"}, {80, "Eighty"}, {90, "Ninety"}, {100, "Hundred"}, {1000, "Thousand"}, _
                                        {100000, "Lakh"}, {10000000, "Crore"}}

        Dim i As Integer
        For i = 0 To UBound(ArrWordList)
            If Num = ArrWordList(i, 0) Then
                retWord = ArrWordList(i, 1)
                Exit For
            End If
        Next
        Return retWord
    End Function
    'test===============================================
    Public Class clsConversion

        Dim mOnesArray(8) As String
        Dim mOneTensArray(9) As String
        Dim mTensArray(7) As String
        Dim mPlaceValues(4) As String
        Public Sub New()

            mOnesArray(0) = "One"
            mOnesArray(1) = "Two"
            mOnesArray(2) = "Three"
            mOnesArray(3) = "Four"
            mOnesArray(4) = "Five"
            mOnesArray(5) = "Six"
            mOnesArray(6) = "Seven"
            mOnesArray(7) = "Eight"
            mOnesArray(8) = "Nine"

            mOneTensArray(0) = "Ten"
            mOneTensArray(1) = "Eleven"
            mOneTensArray(2) = "Twelve"
            mOneTensArray(3) = "Thirteen"
            mOneTensArray(4) = "Fourteen"
            mOneTensArray(5) = "Fifteen"
            mOneTensArray(6) = "Sixteen"
            mOneTensArray(7) = "Seventeen"
            mOneTensArray(8) = "Eightteen"
            mOneTensArray(9) = "Eineteen"

            mTensArray(0) = "Twenty"
            mTensArray(1) = "Thirty"
            mTensArray(2) = "Forty"
            mTensArray(3) = "Fifty"
            mTensArray(4) = "Sixty"
            mTensArray(5) = "Seventy"
            mTensArray(6) = "Eighty"
            mTensArray(7) = "Ninety"

            mPlaceValues(0) = "Hundred"
            mPlaceValues(1) = "Thousand"
            mPlaceValues(2) = "Million"
            mPlaceValues(3) = "Billion"
            mPlaceValues(4) = "Trillion"


            Dim PumMFration2 As String

        End Sub

        Protected Function GetoneTens(ByVal OnetensDigit As Integer) As String

            GetoneTens = ""

            If OnetensDigit = 0 Then
                Exit Function
            End If

            GetoneTens = mOneTensArray(OnetensDigit)

        End Function
        Protected Function GetOnes(ByVal OneDigit As Integer) As String

            GetOnes = ""

            If OneDigit = 0 Then
                Exit Function
            End If

            GetOnes = mOnesArray(OneDigit - 1)

        End Function


        Protected Function GetTens(ByVal TensDigit As Integer) As String

            GetTens = ""

            If TensDigit = 0 Or TensDigit = 1 Then
                Exit Function
            End If

            GetTens = mTensArray(TensDigit - 2)

        End Function
        Public Function ConvertNumberToWords(ByVal NumberValue As String) As String

            Dim Delimiter As String = " "
            Dim TensDelimiter As String = " "
            Dim mNumberValue As String = ""
            Dim mNumbers As String = ""
            Dim mNumWord As String = ""
            Dim mFraction As String = ""
            Dim mNumberStack() As String
            Dim j As Integer = 0
            Dim i As Integer = 0
            Dim mOneTens As Boolean = False

            Dim RashAmt As String = "0"

            ConvertNumberToWords = ""

            ' validate input
            Try
                j = CDbl(NumberValue)
            Catch ex As Exception
                ConvertNumberToWords = "Invalid input."
                Exit Function
            End Try

            ' get fractional part {if any}
            If InStr(NumberValue, ".") = 0 Then
                ' no fraction
                mNumberValue = NumberValue

                RashAmt = "0"
            Else
                mNumberValue = Microsoft.VisualBasic.Left(NumberValue, InStr(NumberValue, ".") - 1)
                mFraction = Mid(NumberValue, InStr(NumberValue, ".")) ' + 1)
                mFraction = Math.Round(CSng(mFraction), 2) * 100

                If CInt(mFraction) = 0 Then
                    mFraction = ""

                    RashAmt = "0"

                Else
                    'mFraction = "&& " & mFraction & "/100"




                    Dim getMfraction As String = mFraction


                    'If mFraction = "" Then
                    '    RashAmt = "0"


                    'Else
                    RashAmt = mFraction
                    'End If




                    Dim tmpfraction As String
                    Dim tens, onces, onctens As String
                    tens = GetTens(Val(Mid(mFraction, 1, 1)))
                    onces = GetOnes(Val(Mid(mFraction, 2, 1)))
                    onctens = GetoneTens(Val(Mid(mFraction, 2, 1)))



                    If tens <> "" And onces <> "" Then
                        tmpfraction = tens & " " & onces

                    End If



                    If tens <> "" And onces = "" Then
                        tmpfraction = tens
                    End If

                    If tens = "" And onces <> "" Then
                        tmpfraction = onces
                    End If


                    If tens = "" And onces <> "" And onctens <> "" Then
                        tmpfraction = onctens
                    End If


                    'tmpfraction = onctens
                    ' tmpfraction = tens & " " & onces
                    mFraction = tmpfraction
                End If
            End If
            mNumbers = mNumberValue.ToCharArray

            ' move numbers to stack/array backwards
            For j = mNumbers.Length - 1 To 0 Step -1
                ReDim Preserve mNumberStack(i)

                mNumberStack(i) = mNumbers(j)
                i += 1
            Next

            For j = mNumbers.Length - 1 To 0 Step -1
                Select Case j
                    Case 0, 3, 6, 9, 12
                        ' ones  value
                        If Not mOneTens Then
                            mNumWord &= GetOnes(Val(mNumberStack(j))) & Delimiter
                        End If

                        Select Case j
                            Case 3
                                ' thousands
                                mNumWord &= mPlaceValues(1) & Delimiter

                            Case 6
                                ' millions
                                mNumWord &= mPlaceValues(2) & Delimiter

                            Case 9
                                ' billions
                                mNumWord &= mPlaceValues(3) & Delimiter

                            Case 12
                                ' trillions
                                mNumWord &= mPlaceValues(4) & Delimiter
                        End Select


                    Case Is = 1, 4, 7, 10, 13
                        ' tens value
                        If Val(mNumberStack(j)) = 0 Then
                            mNumWord &= GetOnes(Val(mNumberStack(j - 1))) & Delimiter
                            mOneTens = True
                            Exit Select
                        End If

                        If Val(mNumberStack(j)) = 1 Then
                            mNumWord &= mOneTensArray(Val(mNumberStack(j - 1))) & Delimiter
                            mOneTens = True
                            Exit Select
                        End If

                        mNumWord &= GetTens(Val(mNumberStack(j)))

                        ' this places the tensdelimiter; check for succeeding 0
                        If Val(mNumberStack(j - 1)) <> 0 Then
                            mNumWord &= TensDelimiter
                        End If
                        mOneTens = False

                    Case Else
                        ' hundreds value 
                        mNumWord &= GetOnes(Val(mNumberStack(j))) & Delimiter

                        If Val(mNumberStack(j)) <> 0 Then
                            mNumWord &= mPlaceValues(0) & Delimiter
                        End If
                End Select
            Next


            If RashAmt <= 10 Then
                Dim NewCents As String = ""


                If RashAmt = "0" Then
                    NewCents = "Zero"
                End If

                If RashAmt = "1" Then
                    NewCents = "One"
                End If


                If RashAmt = "2" Then
                    NewCents = "Two"
                End If

                If RashAmt = "3" Then
                    NewCents = "Three"
                End If


                If RashAmt = "4" Then
                    NewCents = "Four"
                End If



                If RashAmt = "5" Then
                    NewCents = "Five"
                End If

                If RashAmt = "6" Then
                    NewCents = "Six"
                End If

                If RashAmt = "7" Then
                    NewCents = "Seven"
                End If

                If RashAmt = "8" Then
                    NewCents = "Eight"
                End If


                If RashAmt = "9" Then
                    NewCents = "Nine"
                End If

                If RashAmt = "10" Then
                    NewCents = "Ten"
                End If

                Return mNumWord & " and " & NewCents & " cents Only"

            Else

                Return mNumWord & " and " & mFraction & " cents Only"

            End If









        End Function



    End Class


    'test===========================================



    Private Sub PrintPerforma()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from rpt_Proforma_Invoice_NewFormat", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaProinv As String = PubResno
            Dim ParaResno As String = PubResno3
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            fltString = "{rpt_Proforma_Invoice_NewFormat.ProInvNo}='" & ParaProinv & "' and {rpt_Proforma_Invoice_NewFormat.PeriodResno}='" & ParaResno & "'"

            ReportName = "ProformaInvoice.rpt"
            rptTitle = "Proforma Invoice"

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
    Private Sub PrintPerformaFit()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from rpt_Proforma_Invoice_Fit", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaProinv As String = PubResno
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            fltString = "{rpt_Proforma_Invoice_Fit.ProInvNo}='" & ParaProinv & "'"

            ReportName = "ProformaInvoiceFit.rpt"
            rptTitle = "Proforma Invoice FIT"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub
    Private Sub PrintPerformaFitTop()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from rpt_Proforma_Invoice_Fit", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaProinv As String = PubResno
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            fltString = "{rpt_Proforma_Invoice_Fit.ProInvNo}='" & ParaProinv & "'"

            ReportName = "ProformaInvoiceFitTop.rpt"
            rptTitle = "Proforma Invoice FIT"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub XtraTabPage1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles XtraTabPage1.Paint

    End Sub

    Private Sub CbInfantsRate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbInfantsRate.CheckedChanged
        GetTransferRateArrival()
    End Sub

    Private Sub btRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRev.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Pro-formaInvoicing", "Reverse")

        If CheckAccess = True Then

            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Reverse This Proforma Invoice", "Reverse Proforma Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    ReverseProInv()

                End If
                LoadGrid()
                tabProforma.TabPages(1).PageEnabled = False
                tabProforma.TabPages(0).PageEnabled = True

                tabProforma.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Private Sub ReverseProInv()

        Try



            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand
            dcInsertNewAcc = New SqlCommand("UpdateResMasProInvRev_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = PubResno2
            dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = PubResno
            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Proforma Invoice Reverse Successfully", "Reverse Proforma Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try


    End Sub
    Function DSGetRoomDetailsFIT() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            Dim ReservationNo As String = cmbResnos.Text.Trim


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

    Private Sub btupdatepayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdatepayment.Click
        UpdateResPaymentDeails()
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click

    End Sub
    Private Sub frmProfomainvoice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub dtArrivalDate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtArrivalDate.EditValueChanged


        'Try


        '    If cbTopcode.Text = "ALL" Then
        '        cmbResnos.Properties.Items.Clear()
        '        LoadResCodesAllTopByDate()
        '    Else
        '        cmbResnos.Properties.Items.Clear()
        '        LoadResCodesByTopDate()
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        'End Try
    End Sub

    Private Sub gcProforma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcProforma.Click

    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged

        If CheckEdit1.Checked = True Then

            txt24dinner.Text = (PubAdultQty * 100) + (PubChildQty * 50)

        Else

            txt24dinner.Text = "0.00"

        End If


    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        If CheckEdit2.Checked = True Then

            txtNewyeardinner.Text = (PubAdultQty * 102) + (PubChildQty * 51)

        Else

            txtNewyeardinner.Text = "0.00"

        End If
    End Sub

    Private Sub txt24dinner_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt24dinner.EditValueChanged
        txtFinaltot.Text = IIf(String.IsNullOrEmpty(txtRate.Text), 0, Val(txtRate.Text)) - IIf(String.IsNullOrEmpty(txtDisscounts.Text), 0, Val(txtDisscounts.Text)) + IIf(String.IsNullOrEmpty(txtTransferrate.Text), 0, Val(txtTransferrate.Text)) + IIf(String.IsNullOrEmpty(txt24dinner.Text), 0, Val(txt24dinner.Text)) + IIf(String.IsNullOrEmpty(txtNewyeardinner.Text), 0, Val(txtNewyeardinner.Text))
    End Sub

    Private Sub txtNewyeardinner_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewyeardinner.EditValueChanged
        txtFinaltot.Text = IIf(String.IsNullOrEmpty(txtRate.Text), 0, Val(txtRate.Text)) - IIf(String.IsNullOrEmpty(txtDisscounts.Text), 0, Val(txtDisscounts.Text)) + IIf(String.IsNullOrEmpty(txtTransferrate.Text), 0, Val(txtTransferrate.Text)) + IIf(String.IsNullOrEmpty(txt24dinner.Text), 0, Val(txt24dinner.Text)) + IIf(String.IsNullOrEmpty(txtNewyeardinner.Text), 0, Val(txtNewyeardinner.Text))
    End Sub

    Private Sub txtDisscounts_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisscounts.EditValueChanged
        txtFinaltot.Text = IIf(String.IsNullOrEmpty(txtRate.Text), 0, Val(txtRate.Text)) - IIf(String.IsNullOrEmpty(txtDisscounts.Text), 0, Val(txtDisscounts.Text)) + IIf(String.IsNullOrEmpty(txtTransferrate.Text), 0, Val(txtTransferrate.Text)) + IIf(String.IsNullOrEmpty(txt24dinner.Text), 0, Val(txt24dinner.Text)) + IIf(String.IsNullOrEmpty(txtNewyeardinner.Text), 0, Val(txtNewyeardinner.Text))
    End Sub

    Private Sub txtTransferrate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransferrate.EditValueChanged
        txtFinaltot.Text = IIf(String.IsNullOrEmpty(txtRate.Text), 0, Val(txtRate.Text)) - IIf(String.IsNullOrEmpty(txtDisscounts.Text), 0, Val(txtDisscounts.Text)) + IIf(String.IsNullOrEmpty(txtTransferrate.Text), 0, Val(txtTransferrate.Text)) + IIf(String.IsNullOrEmpty(txt24dinner.Text), 0, Val(txt24dinner.Text)) + IIf(String.IsNullOrEmpty(txtNewyeardinner.Text), 0, Val(txtNewyeardinner.Text))
    End Sub
End Class