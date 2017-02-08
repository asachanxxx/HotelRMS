Imports System.Data.SqlClient
Public Class frmTaxinvoice
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
    Public PubPrefixcode As String = ""
    Public PubMaintype As String = ""
    Public PubResno As String = ""
    Public PubTaxInvno As String = ""
    Public PubProInvno As String = ""
    Public ReportName As String
    Public rptTitle As String
    Public SF As String = ""
    Public PubMFraction As String = ""

    Public PubAdultRate As Decimal = 0.0
    Public PubChildRate As Decimal = 0.0
    Public PubAiRate As Decimal = 0.0
    Public PubDayTransRate As Decimal = 0.0
    Public PubNightTransRate As Decimal = 0.0
    Public IsTaxUpdated As Integer = 0



    Private Sub frmTaxinvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadGrid()
        LoadTopcodes()
        LoadTax()
        GetServerDate()
        cbTopcode.SelectedIndex = 0
        cmbProInvNo.SelectedIndex = 0
        ' DtToday.Text = Date.Now.Date

        tabTaxinvocie.TabPages(1).PageEnabled = False

        tabTaxinvocie.TabPages(0).PageEnabled = True



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
            dcSearch = New SqlCommand("select TopCode from [Touroperator.Master] order by TopCode", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer



            If Dscount > 0 Then

                cbTopcode.Properties.Items.Add("ALL")

                While (DscountTest < Dscount)

                    cbTopcode.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cbTopcode.SelectedIndex = 0

            Else
                MessageBox.Show("No Records Found", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadProInvAllTop()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT dbo.[Reservation.Master].ProfomaInvoiceno FROM dbo.[Reservation.Master] INNER JOIN dbo.[Invoice.Proforma.Master] ON dbo.[Reservation.Master].ResNo = dbo.[Invoice.Proforma.Master].ResNO WHERE (dbo.[Reservation.Master].Status = 'OPEN') AND (dbo.[Reservation.Master].IsProformaCreated = 1) AND (dbo.[Reservation.Master].ResType = 'TOP') AND dbo.[Invoice.Proforma.Master].IsTaxInv=0 AND dbo.[Invoice.Proforma.Master].Status='OPEN' ORDER BY dbo.[Reservation.Master].ProfomaInvoiceno", Conn)



            ' dcSearch = New SqlCommand("SELECT dbo.[Invoice.Proforma.Master].ProInvNoMas FROM dbo.[Reservation.Master] INNER JOIN dbo.[Invoice.Proforma.Master] ON dbo.[Reservation.Master].ResNo = dbo.[Invoice.Proforma.Master].ResNO WHERE (dbo.[Reservation.Master].Status = 'OPEN') AND (dbo.[Reservation.Master].IsProformaCreated = 1) AND (dbo.[Reservation.Master].ResType = 'TOP') AND dbo.[Invoice.Proforma.Master].IsTaxInv=0 AND dbo.[Invoice.Proforma.Master].Status='OPEN' ORDER BY dbo.[Reservation.Master].ProfomaInvoiceno", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer


            If Dscount > 0 Then

                While (DscountTest < Dscount)

                    cmbProInvNo.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbProInvNo.SelectedIndex = 0


            Else

                MessageBox.Show("No Records Found", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadProInvByTop()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT dbo.[Reservation.Master].ProfomaInvoiceno FROM dbo.[Reservation.Master] INNER JOIN dbo.[Invoice.Proforma.Master] ON dbo.[Reservation.Master].ResNo = dbo.[Invoice.Proforma.Master].ResNO WHERE (dbo.[Reservation.Master].Status = 'OPEN') AND (dbo.[Reservation.Master].IsProformaCreated = 1) AND (dbo.[Reservation.Master].ResType = 'TOP') AND dbo.[Invoice.Proforma.Master].IsTaxInv=0 AND dbo.[Reservation.Master].Topcode=@Topcode AND dbo.[Invoice.Proforma.Master].Status='OPEN'  ORDER BY dbo.[Reservation.Master].ProfomaInvoiceno", Conn)


            ' dcSearch = New SqlCommand("SELECT dbo.[Invoice.Proforma.Master].ProInvNoMas FROM dbo.[Reservation.Master] INNER JOIN dbo.[Invoice.Proforma.Master] ON dbo.[Reservation.Master].ResNo = dbo.[Invoice.Proforma.Master].ResNO WHERE (dbo.[Reservation.Master].Status = 'OPEN') AND (dbo.[Reservation.Master].IsProformaCreated = 1) AND (dbo.[Reservation.Master].ResType = 'TOP') AND dbo.[Invoice.Proforma.Master].IsTaxInv=0 AND dbo.[Reservation.Master].Topcode=@Topcode AND dbo.[Invoice.Proforma.Master].Status='OPEN'  ORDER BY dbo.[Reservation.Master].ProfomaInvoiceno", Conn)



            dcSearch.Parameters.Add("@Topcode", SqlDbType.NVarChar).Value = cbTopcode.Text.Trim

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            If Dscount > 0 Then



                While (DscountTest < Dscount)

                    cmbProInvNo.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbProInvNo.SelectedIndex = 0

            Else

                MessageBox.Show("No Records Found", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadProInvOthers()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT dbo.[Reservation.Master].ProfomaInvoiceno FROM dbo.[Reservation.Master] INNER JOIN dbo.[Invoice.Proforma.Master] ON dbo.[Reservation.Master].ResNo = dbo.[Invoice.Proforma.Master].ResNO WHERE (dbo.[Reservation.Master].Status = 'OPEN') AND (dbo.[Reservation.Master].IsProformaCreated = 1) AND (dbo.[Reservation.Master].ResType != 'TOP')AND dbo.[Invoice.Proforma.Master].IsTaxInv=0 AND dbo.[Invoice.Proforma.Master].Status='OPEN' ORDER BY dbo.[Reservation.Master].ProfomaInvoiceno", Conn)
            dcSearch.Parameters.Add("@Topcode", SqlDbType.NVarChar).Value = cbTopcode.Text.Trim

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbProInvNo.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbProInvNo.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub btSearchtop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearchtop.Click
        If cbTopcode.Text = "ALL" Then
            cmbProInvNo.Properties.Items.Clear()
            LoadProInvAllTop()
        Else
            cmbProInvNo.Properties.Items.Clear()
            LoadProInvByTop()
        End If
    End Sub
    Private Sub LoadTax()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try


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

    Private Sub btSearchothers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearchothers.Click
        cmbProInvNo.Properties.Items.Clear()
        LoadProInvOthers()
    End Sub
    Private Sub LoadResDetails()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getProinvno As String = cmbProInvNo.Text.Trim

            Conn.Open()
            'dcSearch = New SqlCommand("select ResNo,ResDate,Guest,ResType,Topcode,IsTopcontract,TopContractId,ArrDate,DepDate,ArrFlight,DepFlight,convert(char(5), ArrTime, 108) [ArrTime],convert(char(5), DepTime, 108) [DepTime],ArrTrans,DepTrans,PaxId,AdultQty,ChildrenQty,InfantsQty,MealPlan,Rate,DisPlanId,OfferId,AmenId,Total,PayMode,PayExpiryDate,PayCCNo,Guestlikes,Guestdislikes,BillingInst,Remarks,Refno,Status,IsProformaCreated,ProfomaInvoiceno,EnteredBy,EnteredDate,InactivatedBy,InactivatedDate from dbo.[Reservation.Master] where ProfomaInvoiceno=@ProfomaInvoiceno", Conn)


            dcSearch = New SqlCommand("select ResNo,ResDate,Guest,ResType,Topcode,IsTopcontract,TopContractId,ArrDate,DepDate,ArrFlight,DepFlight,convert(char(5), ArrTime, 108) [ArrTime],convert(char(5), DepTime, 108) [DepTime],ArrTrans,DepTrans,PaxId,AdultQty,ChildrenQty,InfantsQty,MealPlan,Rate,DisPlanId,OfferId,AmenId,Total,PayMode,PayExpiryDate,PayCCNo,Guestlikes,Guestdislikes,BillingInst,Remarks,Refno,Status,IsProformaCreated,ProfomaInvoiceno,EnteredBy,EnteredDate,InactivatedBy,InactivatedDate from dbo.[Reservation.Master] where ProfomaInvoiceno=@ProfomaInvoiceno", Conn)


            ' dcSearch = New SqlCommand("SELECT     TOP (100) PERCENT dbo.[Reservation.Master].ResNo, dbo.[Reservation.Master].ResDate, dbo.[Reservation.Master].Guest, dbo.[Reservation.Master].ResType,dbo.[Reservation.Master].Topcode, dbo.[Reservation.Master].IsTopcontract, dbo.[Reservation.Master].TopContractId, dbo.[Reservation.Master].ArrDate,dbo.[Reservation.Master].DepDate, dbo.[Reservation.Master].ArrFlight, dbo.[Reservation.Master].DepFlight, CONVERT(char(5), dbo.[Reservation.Master].ArrTime, 108) AS ArrTime, CONVERT(char(5), dbo.[Reservation.Master].DepTime, 108) AS DepTime, dbo.[Reservation.Master].ArrTrans, dbo.[Reservation.Master].DepTrans, dbo.[Reservation.Master].PaxId, dbo.[Reservation.Master].AdultQty, dbo.[Reservation.Master].ChildrenQty, dbo.[Reservation.Master].InfantsQty, dbo.[Reservation.Master].MealPlan, dbo.[Reservation.Master].Rate, dbo.[Reservation.Master].DisPlanId, dbo.[Reservation.Master].OfferId, dbo.[Reservation.Master].AmenId, dbo.[Reservation.Master].Total, dbo.[Reservation.Master].PayMode, dbo.[Reservation.Master].PayExpiryDate, dbo.[Reservation.Master].PayCCNo, dbo.[Reservation.Master].Guestlikes, dbo.[Reservation.Master].Guestdislikes, dbo.[Reservation.Master].BillingInst,dbo.[Reservation.Master].Remarks, dbo.[Reservation.Master].Refno, dbo.[Reservation.Master].Status, dbo.[Reservation.Master].IsProformaCreated, dbo.[Reservation.Master].ProfomaInvoiceno, dbo.[Reservation.Master].EnteredBy, dbo.[Reservation.Master].EnteredDate, dbo.[Reservation.Master].InactivatedBy, dbo.[Reservation.Master].InactivatedDate, dbo.[Invoice.Proforma.Master].ProInvNoMas FROM  dbo.[Reservation.Master] INNER JOIN   dbo.[Invoice.Proforma.Master] ON dbo.[Reservation.Master].ResNo = dbo.[Invoice.Proforma.Master].ResNO WHERE  dbo.[Invoice.Proforma.Master].ProInvNoMas=@ProfomaInvoiceno AND  (dbo.[Invoice.Proforma.Master].Status = 'OPEN')", Conn)

            dcSearch.Parameters.Add("@ProfomaInvoiceno", SqlDbType.VarChar).Value = getProinvno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcResdetails.DataSource = dsMain.Tables(0)

            PubResno = dsMain.Tables(0).Rows(0)(0).ToString
            PubTopcode = dsMain.Tables(0).Rows(0)(4).ToString

            PubResType = dsMain.Tables(0).Rows(0)(3).ToString
            PubIsContract = Convert.ToInt16(dsMain.Tables(0).Rows(0)(5).ToString)
            PubTopcontractId = dsMain.Tables(0).Rows(0)(6).ToString

            PubAdultQty = Convert.ToInt16(dsMain.Tables(0).Rows(0)(16).ToString)
            PubChildQty = Convert.ToInt16(dsMain.Tables(0).Rows(0)(17).ToString)
            PubInfantsQty = Convert.ToInt16(dsMain.Tables(0).Rows(0)(18).ToString)

            PubArrTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(11).ToString)
            PubDepTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(12).ToString)




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadResPaxDetails()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getResno As String = PubResno.ToString

            Conn.Open()
            dcSearch = New SqlCommand("SELECT  dbo.[Reservation.Room].Room, dbo.[Reservation.Room].Roomtype, dbo.[Reservation.Room].RoomCount  FROM  dbo.[Reservation.Master] INNER JOIN  dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo where dbo.[Reservation.Master].ResNo=@ResNo", Conn)
            dcSearch.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = getResno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcPax.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub btResDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResDetails.Click

        gcPax.DataSource = Nothing
        gcResdetails.DataSource = Nothing
        gcTaxDetail.DataSource = Nothing


        LoadResDetails()
        LoadResPaxDetails()
        LoadProInvDetail()
        LoadProTaxToTaxInv()

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



        Dim getTaxInvno As String = GetTaxInvCode(getTypeInv, getTopcodeinv)

        If getTaxInvno = "" Then
            MessageBox.Show("Tax Invoice Code Not Defined For This TOP, Contact System Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            txtTaxinvno.Text = getTaxInvno
        End If







    End Sub
    Private Sub LoadProInvDetail()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getProinvno As String = cmbProInvNo.Text.Trim

            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[Invoice.Proforma.Master] where ProInvNo=@Proinvno and Status='OPEN'", Conn)


            'dcSearch = New SqlCommand("select * from dbo.[Invoice.Proforma.Master] where ProInvNoMas=@Proinvno and Status='OPEN'", Conn)

            dcSearch.Parameters.Add("@Proinvno", SqlDbType.VarChar).Value = getProinvno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            If dsMain.Tables(0).Rows.Count > 0 Then

                txtRate.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("Rate"))
                txtDisscounts.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("DisscountRate"))
                txtTransferrateArr.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("TransferRateArr"))
                txtTransferrateDep.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("TransferRateDep"))
                txtTransferrate.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("TransferRate"))
                txtFinaltot.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("FinalTot"))
                txtBednights.Text = Convert.ToInt16(dsMain.Tables(0).Rows(0).Item("BedNights"))
                txtBedtimetax.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("BedTax"))
                txtTotBedtimetax.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("TotBedtax"))
                txtRemarks.Text = dsMain.Tables(0).Rows(0).Item("Remarks")
                txtReferences.Text = dsMain.Tables(0).Rows(0).Item("RefNo")
                txtReferencesTop.Text = dsMain.Tables(0).Rows(0).Item("RefNoTop")


                If (Not IsDBNull(dsMain.Tables(0).Rows(0).Item("AdultRate"))) Then

                    PubAdultRate = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("AdultRate"))

                Else
                    PubAdultRate = 0.0
                End If



                If (Not IsDBNull(dsMain.Tables(0).Rows(0).Item("ChildRate"))) Then

                    PubChildRate = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("ChildRate"))

                Else
                    PubChildRate = 0.0
                End If



                If (Not IsDBNull(dsMain.Tables(0).Rows(0).Item("AiRate"))) Then

                    PubAiRate = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("AiRate"))

                Else
                    PubAiRate = 0.0
                End If


                If (Not IsDBNull(dsMain.Tables(0).Rows(0).Item("DayTransRate"))) Then

                    PubDayTransRate = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("DayTransRate"))

                Else
                    PubDayTransRate = 0.0

                End If


                If (Not IsDBNull(dsMain.Tables(0).Rows(0).Item("NightTransRate"))) Then

                    PubNightTransRate = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("NightTransRate"))

                Else
                    PubNightTransRate = 0.0

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
   
    Private Sub btAddTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddTax.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TaxInvoicing", "Add")

        If CheckAccess = True Then



            Try


                If String.Compare(btAddTax.Text, "Create", False) = 0 Then

                    ClearFields()
                    btAddTax.Text = "Save"
                    btEdit.Enabled = False
                    btDel.Enabled = False
                    btPrint.Enabled = False
                    btRev.Enabled = False

                    tabTaxinvocie.TabPages(1).PageEnabled = True

                    tabTaxinvocie.TabPages(0).PageEnabled = False
                    tabTaxinvocie.SelectedTabPageIndex = 1

                Else

                    If FieldValidation() = False Then
                        MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                        Exit Sub
                    Else
                        Dim dscheckAddbefore As New DataSet
                        dscheckAddbefore = DSCheckInsertTaxInv()

                        If dscheckAddbefore Is Nothing Then

                            Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Tax Invoice", "Save Tax Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                            If bt = Windows.Forms.DialogResult.Yes Then

                                If IsTaxUpdated = 0 Then

                                    MsgBox("Apply Taxes", MsgBoxStyle.Critical, ErrTitle)

                                Else

                                    InsertInvTaxMaster()
                                    InsertTaxInvTax()
                                    DeleteTempTax()
                                    LoadGrid()

                                End If

                               
                            End If

                        Else
                            MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If

                        LoadGrid()

                        btAddTax.Text = "Create"
                        btEdit.Enabled = True
                        btDel.Enabled = True
                        btPrint.Enabled = True
                        btRev.Enabled = True
                        tabTaxinvocie.TabPages(1).PageEnabled = False
                        tabTaxinvocie.TabPages(0).PageEnabled = True
                        tabTaxinvocie.SelectedTabPageIndex = 0
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
    Sub ClearFields()

        txtTaxinvno.Text = "TAX-INV-"
        txtTaxinvnoMas.Text = GetTaxInvCodeMas("TAXMAIN")
        gcResdetails.DataSource = Nothing
        gcPax.DataSource = Nothing
        gcTaxDetail.DataSource = Nothing

        GetServerDate()

        txtRate.Text = ""
        txtDisscounts.Text = ""
        txtTransferrateArr.Text = ""

        txtFinaltot.Text = ""
        txtBednights.Text = ""
        txtBedtimetax.Text = "6"
        txtTotBedtimetax.Text = ""
        txtRemarks.Text = ""
        txtReferences.Text = ""
        txtReferencesTop.Text = ""

        IsTaxUpdated = 0



    End Sub

    Function FieldValidation() As Boolean
        Return IIf(String.Compare(cmbProInvNo.Text, "", False) = 0 Or String.Compare(txtRate.Text, "", False) = 0 Or String.Compare(txtTransferrateArr.Text, "", False) = 0 Or String.Compare(txtFinaltot.Text, "", False) = 0 Or String.Compare(txtBednights.Text, "", False) = 0, 0, 1)
    End Function
    Function DSCheckInsertTaxInv() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select * from dbo.[Invoice.Tax.Master] where TaxInvNo=@TaxInvNo and ProInvNo=@ProInvNo", Conn)
            dcSearch.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = txtTaxinvno.Text.Trim
            dcSearch.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = cmbProInvNo.Text.Trim

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertTaxInv = dsMain
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
    'test

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

                    RashAmt = mFraction

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
    'test

    Private Sub InsertInvTaxMaster()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Dim numtostrcls As New clsConversion

        Dim CurrentUser As String = CurrUser
        Dim FinalTotWords As String = numtostrcls.ConvertNumberToWords(Convert.ToDecimal(txtFinaltot.Text.Trim))

        Try

            dcInsertNewAcc = New SqlCommand("InsertInvTaxMaster_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = txtTaxinvno.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ResNO", SqlDbType.VarChar).Value = PubResno
            dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = cmbProInvNo.Text.Trim
            dcInsertNewAcc.Parameters.Add("@TaxInvDate", SqlDbType.DateTime).Value = DtToday.DateTime.Date
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
            dcInsertNewAcc.Parameters.Add("@TaxInvNoMas", SqlDbType.VarChar).Value = txtTaxinvnoMas.Text.Trim
            dcInsertNewAcc.Parameters.Add("@FinaltotWords", SqlDbType.VarChar).Value = FinalTotWords


            dcInsertNewAcc.Parameters.Add("@AdultRate", SqlDbType.Decimal).Value = PubAdultRate
            dcInsertNewAcc.Parameters.Add("@ChildRate", SqlDbType.Decimal).Value = PubChildRate
            dcInsertNewAcc.Parameters.Add("@AiRate", SqlDbType.Decimal).Value = PubAiRate
            dcInsertNewAcc.Parameters.Add("@DayTransRate", SqlDbType.Decimal).Value = PubDayTransRate
            dcInsertNewAcc.Parameters.Add("@NightTransRate", SqlDbType.Decimal).Value = PubNightTransRate


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub InsertTaxInvTax()

        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim CurrentUser As String = CurrUser

            dcSearch = New SqlCommand("select * from dbo.[Invoice.Tax.Tax.Temp] where ProInvNo=@ProInvNo AND Createdby=@Createdby", Conn)
            dcSearch.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = cmbProInvNo.Text.Trim
            dcSearch.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            Conn.Close()

            Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

            While DScount >= 0

                dcInsertNewAcc = New SqlCommand("InsertTaxInvTax_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(1).ToString
                dcInsertNewAcc.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(2).ToString
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
    Private Sub DeleteTempTax()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        ' Dim ProInvNo As String = getProInvNo

        dcInsertNewAcc = New SqlCommand("DelTempTaxInvTaxSave_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        'dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = ProInvNo
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
            ' dcSearch = New SqlCommand("select * from dbo.[Invoice.Tax.Master] where status='OPEN' order by TaxInvNo", Conn)

            dcSearch = New SqlCommand("SELECT dbo.[Invoice.Tax.Master].*, dbo.[Invoice.Proforma.Master].ProInvNoMas , dbo.[Invoice.Proforma.Master].ResNO FROM dbo.[Invoice.Tax.Master] INNER JOIN  dbo.[Invoice.Proforma.Master] ON dbo.[Invoice.Tax.Master].ProInvNo = dbo.[Invoice.Proforma.Master].ProInvNo where dbo.[Invoice.Tax.Master].status='OPEN' order by dbo.[Invoice.Tax.Master].TaxInvNoMas desc", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcTaxinv.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Function GetTaxInvCode(ByVal maintype As String, ByVal topcode As String) As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()

        Try

            Dim GetTopcode As String = maintype
            Dim GetPrefix As String = "INV-TAX-" & topcode & "-"

            PubPrefixcode = GetPrefix
            PubMaintype = GetTopcode

            Conn.Open()

            ' dcGetCode = New SqlCommand("spGetAutoNo_ProInv", Conn)
            dcGetCode = New SqlCommand("spGetAutoNo_ProInv_Top", Conn)

            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = GetTopcode
            dcGetCode.Parameters.Add("@PREFIX1", SqlDbType.NVarChar).Value = GetPrefix
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output
            dcGetCode.ExecuteNonQuery()

            GetTaxInvCode = dcGetCode.Parameters("@Currcode").Value

            Return GetTaxInvCode

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function
    Function GetTaxInvCodeMas(ByVal maintype As String) As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()

        Try

            Dim GetTopcode As String = maintype
            Dim GetPrefix As String = "TAX-ERI-13-"

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

            GetTaxInvCodeMas = dcGetCode.Parameters("@Currcode").Value

            Return GetTaxInvCodeMas

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function

    Private Sub btTaxApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTaxApply.Click
        Try

            If PubIsEdit = 0 Then
                Dim dscheckTaxAddbefore As New DataSet
                dscheckTaxAddbefore = DSCheckAddTaxTemp()

                If dscheckTaxAddbefore Is Nothing Then


                    IsTaxUpdated = 1

                    InsertTaxTemp()
                    LoadInvTaxDetails()

                Else
                    MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If

            End If


            If PubIsEdit = 1 Then


                IsTaxUpdated = 1

                DeleteProInvTax(txtTaxinvno.Text.Trim)

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
    Function DSCheckAddTaxTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim CurrentUser As String = CurrUser

            Dim TaxInvNo As String = txtTaxinvno.Text.Trim
            Dim ProInvNo As String = cmbProInvNo.Text.Trim
            Dim TaxId As Integer = IIf(IsNothing(cmbTax.GetColumnValue("TaxID")), String.Empty, cmbTax.GetColumnValue("TaxID"))
            Dim Createdby As String = CurrentUser

            dcSearch = New SqlCommand("select * from dbo.[Invoice.Tax.Tax.Temp] where TaxInvNo=@TaxInvNo and ProInvNo=@ProInvNo and Taxid=@TaxId and Createdby=@Createdby", Conn)
            dcSearch.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = TaxInvNo
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
    Private Sub InsertTaxTemp()

        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim CurrentUser As String = CurrUser

            Dim Taxinvno As String = txtTaxinvno.Text.Trim
            Dim ProInvno As String = cmbProInvNo.Text.Trim
            Dim Taxid As Integer = IIf(IsNothing(cmbTax.GetColumnValue("TaxID")), String.Empty, cmbTax.GetColumnValue("TaxID"))


            dcInsertNewAcc = New SqlCommand("InsertTaxInvTaxTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = ProInvno
            dcInsertNewAcc.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = Taxinvno
            dcInsertNewAcc.Parameters.Add("@Taxid", SqlDbType.Int).Value = Taxid
            dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

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

            Dim Taxinvno As String = txtTaxinvno.Text.Trim
            Dim ProInvno As String = cmbProInvNo.Text.Trim

            dcSearch = New SqlCommand("SELECT dbo.[Invoice.Tax.Tax.Temp].Taxid, dbo.[Tax.Master].TaxName FROM dbo.[Invoice.Tax.Tax.Temp] INNER JOIN dbo.[Tax.Master] ON dbo.[Invoice.Tax.Tax.Temp].Taxid = dbo.[Tax.Master].TaxID WHERE dbo.[Invoice.Tax.Tax.Temp].TaxInvNo=@TaxInvNo AND dbo.[Invoice.Tax.Tax.Temp].ProInvno=@ProInvno", Conn)
            dcSearch.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = Taxinvno
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
    Private Sub DeleteProInvTax(ByVal getProInvNo As String)

        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim Taxinvno As String = txtTaxinvno.Text.Trim

            dcInsertNewAcc = New SqlCommand("DelTaxInvTax_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcInsertNewAcc.Parameters.Add("@Taxinvno", SqlDbType.VarChar).Value = Taxinvno

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub btTaxdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTaxdel.Click
        Try

            DeleteTempProInvTaxByTaxId(txtTaxinvno.Text.Trim, Convert.ToInt16(gvProTax.GetRowCellValue(gvProTax.FocusedRowHandle, "Taxid")))

            gcTaxDetail.DataSource = Nothing
            LoadInvTaxDetails()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        End Try
    End Sub
    Private Sub DeleteTempProInvTaxByTaxId(ByVal getTaxInvNo As String, ByVal getProTaxId As Integer)

        Try


            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim TaxInvNo As String = getTaxInvNo
            Dim TaxId As Integer = getProTaxId

            dcInsertNewAcc = New SqlCommand("DelTaxTempTaxInvBytaxId_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcInsertNewAcc.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = TaxInvNo
            dcInsertNewAcc.Parameters.Add("@TaxId", SqlDbType.VarChar).Value = TaxId


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub LoadProTaxToTaxInv()

        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            ' dcSearch = New SqlCommand("select * from dbo.[Invoice.Proforma.Tax] where ProInvNo=@ProInvNo", Conn)


            dcSearch = New SqlCommand("select * from dbo.[Invoice.Proforma.Tax] where ProInvNo=@ProInvNo", Conn)


            dcSearch.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = cmbProInvNo.Text.Trim

            Conn.Open()
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            Conn.Close()

            Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

            While DScount >= 0

                dcInsertNewAcc = New SqlCommand("InsertTaxInvTaxTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(1).ToString
                dcInsertNewAcc.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(2).ToString
                dcInsertNewAcc.Parameters.Add("@Taxid", SqlDbType.Int).Value = dsMain.Tables(0).Rows(DScount)(3).ToString

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()
                DScount = DScount - 1
            End While

            LoadInvTaxDetails()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub PrintTaxInv()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from rpt_Tax_Invoice", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaProinv As String = PubTaxInvno
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            fltString = "{rpt_Tax_Invoice.TaxInvNo}='" & ParaProinv & "'"

            ReportName = "TaxInvoice.rpt"
            rptTitle = "Tax Invoice"

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
    Private Sub PrintTaxInvFITTop()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from rpt_Tax_Invoice", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaProinv As String = PubTaxInvno
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            fltString = "{rpt_Tax_Invoice.TaxInvNo}='" & ParaProinv & "'"

            ReportName = "TaxInvoiceFITTop.rpt"
            rptTitle = "Tax Invoice"

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
    Private Sub PrintTaxInvTop()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from rpt_Tax_Invoice_Top", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaProinv As String = PubTaxInvno
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            fltString = "{rpt_Tax_Invoice_Top.TaxInvNo}='" & ParaProinv & "'"




            Dim bt As DialogResult = MessageBox.Show("Do You Want To Print Mauritius Bank Tax Invoice", "Print Tax Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If bt = Windows.Forms.DialogResult.Yes Then

                ReportName = "TaxInvoiceTopOtherBank.rpt"
                rptTitle = "Tax Invoice"


            Else

                ReportName = "TaxInvoiceTop.rpt"
                rptTitle = "Tax Invoice"

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
    Private Sub ShowGridDets()
        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            PubIsEdit = 1

            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select *  from dbo.[Invoice.Tax.Master] where TaxInvNo= '{0}'", gvtaxinvs.GetRowCellValue(gvtaxinvs.FocusedRowHandle, "TaxInvNo")), Conn)
            daShow.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabTaxinvocie.TabPages(1).PageEnabled = True
            tabTaxinvocie.TabPages(0).PageEnabled = False

            tabTaxinvocie.SelectedTabPageIndex = 1

            txtTaxinvno.Text = dsShow.Tables(0).Rows(0).Item("TaxInvNo")
            PubTaxInvno = dsShow.Tables(0).Rows(0).Item("TaxInvNo")

            '  txtTaxinvno.Enabled = False



            If (Not IsDBNull(dsShow.Tables(0).Rows(0).Item("TaxInvNoMas"))) Then

                Dim MasTaxInv As String = dsShow.Tables(0).Rows(0).Item("TaxInvNoMas")

                If MasTaxInv = "" Then
                    txtTaxinvnoMas.Text = ""

                Else
                    txtTaxinvnoMas.Text = MasTaxInv

                End If

            Else

                txtTaxinvnoMas.Text = ""


            End If
            



            DtToday.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("TaxInvDate"))
            DtToday.Enabled = False

            cmbProInvNo.Text = dsShow.Tables(0).Rows(0).Item("ProInvNo")
            PubProInvno = dsShow.Tables(0).Rows(0).Item("ProInvNo")
            cmbProInvNo.ClosePopup()


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

            LoadResDetails()

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
    Function DSLoadResPaxDetails() As DataSet
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getProInv As String = cmbProInvNo.Text.Trim

            Conn.Open()
            dcSearch = New SqlCommand("SELECT  dbo.[Reservation.Room].Room, dbo.[Reservation.Room].Roomtype, dbo.[Reservation.Room].RoomCount,dbo.[Reservation.Room].BedNights  FROM  dbo.[Reservation.Master] INNER JOIN  dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo where dbo.[Reservation.Master].ProfomaInvoiceno=@ResNo", Conn)
            dcSearch.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = getProInv

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
    Private Sub LoadInvTaxMasterDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Dim dcInsertNewAcc As New SqlCommand

        Try
            Conn.Open()

            Dim ProInvno As String = cmbProInvNo.Text.Trim
            Dim TaxInvno As String = txtTaxinvno.Text.Trim

            dcSearch = New SqlCommand("SELECT dbo.[Invoice.Tax.Tax].Taxid, dbo.[Tax.Master].TaxName ,[Invoice.Tax.Tax].ProInvNo,dbo.[Invoice.Tax.Tax].TaxInvNo FROM dbo.[Invoice.Tax.Tax] INNER JOIN dbo.[Tax.Master] ON dbo.[Invoice.Tax.Tax].Taxid = dbo.[Tax.Master].TaxID WHERE dbo.[Invoice.Tax.Tax].ProInvNo=@ProInvNo AND dbo.[Invoice.Tax.Tax].TaxInvNo=@TaxInvNo", Conn)
            dcSearch.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = TaxInvno
            dcSearch.Parameters.Add("@ProInvno", SqlDbType.VarChar).Value = ProInvno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            Conn.Close()

            '---------------------------------------------------------------------------------------

            Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

            DeleteTempProInvTax(cmbProInvNo.Text.Trim)

            Dim CurrentUser As String = CurrUser


            While DScount >= 0

                dcInsertNewAcc = New SqlCommand("InsertTaxInvTaxTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
                dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(2).ToString
                dcInsertNewAcc.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(3).ToString
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
    Private Sub DeleteTempProInvTax(ByVal getProInvno As String)

        Try


            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim ProInvno As String = getProInvno

            dcInsertNewAcc = New SqlCommand("DelTempTaxInvTax_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
            dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = ProInvno

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try


    End Sub

    Private Sub gvtaxinvs_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvtaxinvs.DoubleClick
        ShowGridDets()
    End Sub

    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TaxInvoicing", "Print")

        If CheckAccess = True Then


            If PubResType = "TOP" Then

                If PubTopcode = "BOC" Or PubTopcode = "AGD" Or PubTopcode = "EXP" Or PubTopcode = "WEB" Or PubTopcode = "FITA" Or PubTopcode = "FITL" Or PubTopcode = "FITD" Then
                    PrintTaxInvFITTop()

                Else

                    PrintTaxInvTop()

                End If


                Else
                    PrintTaxInv()
                End If


                tabTaxinvocie.TabPages(1).PageEnabled = False
                tabTaxinvocie.TabPages(0).PageEnabled = True
                tabTaxinvocie.SelectedTabPageIndex = 0


            Else

                MsgBox("You Do Not Have Access")


            End If



    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TaxInvoicing", "Delete")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Delete This Tax Invoice", "Delete Tax Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveTaxInv()


                End If
                LoadGrid()
                tabTaxinvocie.SelectedTabPageIndex = 0

                tabTaxinvocie.TabPages(1).PageEnabled = False
                tabTaxinvocie.TabPages(0).PageEnabled = True

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub InactiveTaxInv()

        Try

        Dim CurrentUser As String = CurrUser

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        dcInsertNewAcc = New SqlCommand("InactiveTaxInv_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = PubTaxInvno
        dcInsertNewAcc.Parameters.Add("@UserId", SqlDbType.VarChar).Value = CurrentUser
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Tax Invoice Deleted Successfully", "Delete Tax Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub btRev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRev.Click
        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Reverse This Tax Invoice", "Reverse Tax Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                ReverseTaxInv()

            End If
            LoadGrid()
            tabTaxinvocie.SelectedTabPageIndex = 0
            tabTaxinvocie.TabPages(1).PageEnabled = False
            tabTaxinvocie.TabPages(0).PageEnabled = True

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub ReverseTaxInv()

        Try

        

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        dcInsertNewAcc = New SqlCommand("UpdateInvProMasTaxInvRev_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = PubProInvno
        dcInsertNewAcc.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = PubTaxInvno
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Tax Invoice Reverse Successfully", "Reverse Tax Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click

    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click

    End Sub

    Private Sub frmTaxinvoice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub txtDisscounts_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisscounts.EditValueChanged
        txtFinaltot.Text = IIf(String.IsNullOrEmpty(txtRate.Text), 0, Val(txtRate.Text)) - IIf(String.IsNullOrEmpty(txtDisscounts.Text), 0, Val(txtDisscounts.Text)) + IIf(String.IsNullOrEmpty(txtTransferrate.Text), 0, Val(txtTransferrate.Text))
    End Sub

    Private Sub gcTaxinv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcTaxinv.Click

    End Sub
End Class