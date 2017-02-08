Imports System.Data.SqlClient
Imports System.Xml

Public Class frmDbcrnote
   
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
    Public PubCrDbNo As String = ""
    Public PubMasBillTotal As Decimal = 0
    Public PubMasBillGst As Decimal = 0
    Public PubMasBillScharge As Decimal = 0
    Public PubMasDep As String
    Public PubMasTot As Decimal = 0
    Public PubMasGst As Decimal = 0
    Public PubMasScharge As Decimal = 0




    Private Sub btSearchtop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearchtop.Click
        If cbTopcode.Text = "ALL" Then
            cmbtax.Properties.Items.Clear()
            LoadProInvAllTop()
        Else
            cmbtax.Properties.Items.Clear()
            LoadProInvByTop()
        End If
    End Sub
    Private Sub topload()

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

                '  cbTopcode.Properties.Items.Add("ALL")

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


    Private Sub frmDbcrnote_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        DtToday.Text = DateTime.Now
        DtMasbillFrom.Text = DateTime.Now
        DtMasbillTo.Text = DateTime.Now
        Dttoday2.Text = DateTime.Now


        topload()
        taxload()
        gridtaxload()
        gridMbillload()


    End Sub
    Private Sub gridtaxload()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[Invoice.CrDb.Master] where status='OPEN' and Maintype !='MBILL' order by CrDbNo", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            grdTaxinv.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub gridMbillload()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[Invoice.CrDb.Master] where status='OPEN' and Maintype ='MBILL' order by CrDbNo", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcMbCnSum.DataSource = dsMain.Tables(0)

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
            dcSearch = New SqlCommand("SELECT dbo.[Invoice.Tax.Master].TaxInvNo FROM dbo.[Reservation.Master] INNER JOIN dbo.[Invoice.Tax.Master] ON dbo.[Reservation.Master].ResNo = dbo.[Invoice.Tax.Master].ResNO WHERE   (dbo.[Reservation.Master].IsProformaCreated = 1) AND (dbo.[Reservation.Master].ResType = 'TOP') AND (dbo.[Invoice.Tax.Master].Status = 'OPEN' ) ORDER BY dbo.[Reservation.Master].ProfomaInvoiceno", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer


            If Dscount > 0 Then

                While (DscountTest < Dscount)

                    cmbtax.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbtax.SelectedIndex = 0


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
            dcSearch = New SqlCommand("SELECT     TOP (100) PERCENT dbo.[Invoice.Tax.Master].TaxInvNoMas FROM dbo.[Reservation.Master] INNER JOIN dbo.[Invoice.Tax.Master] ON dbo.[Reservation.Master].ResNo = dbo.[Invoice.Tax.Master].ResNO WHERE   (dbo.[Reservation.Master].IsProformaCreated = 1) AND (dbo.[Reservation.Master].ResType = 'TOP') AND (dbo.[Reservation.Master].Topcode = @Topcode) AND (dbo.[Invoice.Tax.Master].Status = 'OPEN') AND (dbo.[Invoice.Tax.Master].Status = 'OPEN') ORDER BY dbo.[Reservation.Master].ProfomaInvoiceno", Conn)
            dcSearch.Parameters.Add("@Topcode", SqlDbType.NVarChar).Value = cbTopcode.Text.Trim

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            If Dscount > 0 Then



                While (DscountTest < Dscount)

                    cmbtax.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbtax.SelectedIndex = 0

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

    Private Sub taxload()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select TaxInvNo  from [Invoice.Tax.Master] where Status='OPEN' order by TaxInvNo ", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer



            If Dscount > 0 Then

                ' cmbtax.Properties.Items.Add("ALL")

                While (DscountTest < Dscount)

                    cmbtax.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbtax.SelectedIndex = 0

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
    Private Sub LoadMasbills()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select BillNo from BillMaster  where [Date]  > @Fdate  and  [Date]  < @Tdate order by BillNo", Conn)
            dcSearch.Parameters.Add("@Fdate", SqlDbType.Date).Value = DtMasbillFrom.DateTime.Date
            dcSearch.Parameters.Add("@Tdate", SqlDbType.Date).Value = DtMasbillTo.DateTime.Date
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer



            If Dscount > 0 Then

                ' cmbtax.Properties.Items.Add("ALL")

                While (DscountTest < Dscount)

                    cmbBills.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbtax.SelectedIndex = 0

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

    Private Sub CeInvBase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CeInvBase.CheckedChanged
        If CeInvBase.Checked = True Then
            cmbtax.Enabled = False
        Else
            cmbtax.Enabled = True
        End If
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

                cmbtax.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbtax.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub btSearchothers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearchothers.Click
        cmbtax.Properties.Items.Clear()
        LoadProInvOthers()
    End Sub

    Private Sub btResDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResDetails.Click

        gcResdetails.DataSource = Nothing


        LoadResDetails()

       

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

            'gcPax.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadProInvDetail()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getProinvno As String = cmbtax.Text.Trim

            Conn.Open()
            dcSearch = New SqlCommand("select * from [Invoice.Tax.Master]   where TaxInvNo =@Proinvno  and Status='OPEN'", Conn)
            dcSearch.Parameters.Add("@Proinvno", SqlDbType.VarChar).Value = getProinvno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            If dsMain.Tables(0).Rows.Count > 0 Then

                'txtRate.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("Rate"))
                'txtDisscounts.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("DisscountRate"))
                'txtTransferrateArr.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("TransferRateArr"))
                'txtTransferrateDep.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("TransferRateDep"))
                'txtTransferrate.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("TransferRate"))
                txtFinaltot.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("FinalTot"))
                'txtBednights.Text = Convert.ToInt16(dsMain.Tables(0).Rows(0).Item("BedNights"))
                'txtBedtimetax.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("BedTax"))
                'txtTotBedtimetax.Text = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("TotBedtax"))
                'txtRemarks.Text = dsMain.Tables(0).Rows(0).Item("Remarks")
                txtReferences.Text = dsMain.Tables(0).Rows(0).Item("RefNo")
                txtReferencesTop.Text = dsMain.Tables(0).Rows(0).Item("RefNoTop")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadProTaxToTaxInv()

        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            dcSearch = New SqlCommand("select * from [Invoice.Tax.Master]  where TaxInvNo =@ProInvNo", Conn)
            dcSearch.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = cmbtax.Text.Trim

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
    Private Sub LoadInvTaxDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim Taxinvno As String = txtcndn.Text.Trim
            Dim ProInvno As String = cmbtax.Text.Trim

            dcSearch = New SqlCommand("SELECT dbo.[Invoice.Tax.Tax.Temp].Taxid, dbo.[Tax.Master].TaxName FROM dbo.[Invoice.Tax.Tax.Temp] INNER JOIN dbo.[Tax.Master] ON dbo.[Invoice.Tax.Tax.Temp].Taxid = dbo.[Tax.Master].TaxID WHERE dbo.[Invoice.Tax.Tax.Temp].TaxInvNo=@TaxInvNo AND dbo.[Invoice.Tax.Tax.Temp].ProInvno=@ProInvno", Conn)
            dcSearch.Parameters.Add("@TaxInvNo", SqlDbType.VarChar).Value = Taxinvno
            dcSearch.Parameters.Add("@ProInvno", SqlDbType.VarChar).Value = ProInvno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            'gcTaxDetail.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    'Private Sub PrintTaxInv()
    '    Dim Conn As New SqlConnection(ConnString)


    '    Dim sqlString As String
    '    Dim dcIns As New SqlCommand()
    '    Dim daMain As New SqlDataAdapter()
    '    Dim dsMain As New DataSet

    '    Dim fltString As String

    '    Try

    '        Conn.Open()

    '        dcIns = New SqlCommand("select * from rpt_dbcr_note_view", Conn)
    '        ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

    '        Dim CrDbno As String = "ParaProinv"
    '        dcIns.CommandType = CommandType.Text
    '        dcIns.ExecuteNonQuery()


    '        ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

    '        fltString = "{rpt_dbcr_note_view.CrDbNo}='" & CrDbno & "'"




    '        If cmbtype.Text.Trim = "CreditNote" Then

    '            ReportName = "CreditNoteTop.rpt"
    '            rptTitle = "Credit Note"

    '        Else

    '            ReportName = "DebitNoteTop.rpt"
    '            rptTitle = "Debit Note"

    '        End If




    '        frmReportViewer.rptPath = ReportName
    '        frmReportViewer.rptTitle = rptTitle
    '        frmReportViewer.selectionForumla = fltString
    '        frmReportViewer.reporttype = 1

    '        'frmReportViewer.paraRepName = "TestPara"
    '        'frmReportViewer.paraRepVale = DtToday.Text.ToString

    '        'frmReportViewer.paraRepName2 = "TestPara2"
    '        'frmReportViewer.paraRepVale2 = DtToday.Text.ToString


    '        frmReportViewer.Show()


    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        Conn.Dispose()
    '        dcIns.Dispose()

    '    End Try
    'End Sub

    Private Sub LoadResDetails()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getProinvno As String = cmbtax.Text.Trim

            Conn.Open()
            dcSearch = New SqlCommand("SELECT     ResNO , ProInvNo,TaxInvNo, TaxInvDate, Rate,  FinalTot, TotBedtax, TransferRate, DisscountRate FROM  dbo.[Invoice.Tax.Master] where [Invoice.Tax.Master].TaxInvNoMas=@ProfomaInvoiceno", Conn)
            dcSearch.Parameters.Add("@ProfomaInvoiceno", SqlDbType.VarChar).Value = getProinvno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcResdetails.DataSource = dsMain.Tables(0)

            'PubResno = dsMain.Tables(0).Rows(0)(0).ToString
            'PubTopcode = dsMain.Tables(0).Rows(0)(4).ToString

            ' PubResType = dsMain.Tables(0).Rows(0)(3).ToString
            ' PubIsContract = Convert.ToInt16(dsMain.Tables(0).Rows(0)(5).ToString)
            'PubTopcontractId = dsMain.Tables(0).Rows(0)(6).ToString

            ' PubAdultQty = Convert.ToInt16(dsMain.Tables(0).Rows(0)(16).ToString)
            ' PubChildQty = Convert.ToInt16(dsMain.Tables(0).Rows(0)(17).ToString)
            ' PubInfantsQty = Convert.ToInt16(dsMain.Tables(0).Rows(0)(18).ToString)

            '// PubArrTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(11).ToString)
            ' PubDepTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0)(12).ToString)




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadMasBillDetails()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getcmbBills As String = cmbBills.Text.Trim

            Conn.Open()
            dcSearch = New SqlCommand("SELECT  dbo.OutLetBillMaster.Department, sum(dbo.OutLetBillMaster.Total)as Total, sum(dbo.OutLetBillMaster.discount) as Discount, sum(dbo.OutLetBillMaster.tax) as GST,sum(dbo.OutLetBillMaster.serviceCharge) as Scharge FROM  dbo.BillMaster INNER JOIN  dbo.OutLetBillMaster ON dbo.BillMaster.BillNo = dbo.OutLetBillMaster.MasterBillNo where dbo.BillMaster.BillNo=@MasBillno group by dbo.OutLetBillMaster.Department", Conn)
            dcSearch.Parameters.Add("@MasBillno", SqlDbType.VarChar).Value = getcmbBills

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            PubMasBillTotal = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("Total"))
            PubMasBillGst = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("GST"))
            PubMasBillScharge = Convert.ToDecimal(dsMain.Tables(0).Rows(0).Item("Scharge"))


            gcmasbill.DataSource = dsMain.Tables(0)




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
    
    Function GetTaxInvCode(ByVal maintype As String, ByVal topcode As String) As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()

        Try

            Dim GetTopcode As String = maintype
            Dim GetPrefix As String = "TAX-CNDN-" & topcode & "-"

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

    Private Sub gvtaxinvs_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvtaxinvs.DoubleClick
        ShowGridDets()
    End Sub
    Private Sub ShowGridDets()


        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            PubIsEdit = 1

            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select *  from dbo.[Invoice.CrDb.Master] where CrDbNo= '{0}'", gvtaxinvs.GetRowCellValue(gvtaxinvs.FocusedRowHandle, "CrDbNo")), Conn)
            daShow.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabTaxinvocie.TabPages(1).PageEnabled = True
            tabTaxinvocie.TabPages(0).PageEnabled = False

            tabTaxinvocie.SelectedTabPageIndex = 1



            PubCrDbNo = dsShow.Tables(0).Rows(0).Item("CrDbNo")

            CmbtopFit.Text = dsShow.Tables(0).Rows(0).Item("MainType")
            CmbtopFit.ClosePopup()



            cbTopcode.Text = dsShow.Tables(0).Rows(0).Item("Topcode")

            txtcndn.Text = dsShow.Tables(0).Rows(0).Item("CrDbNo")

            DtToday.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("CrDbDate"))

            cmbtax.Text = dsShow.Tables(0).Rows(0).Item("TaxInvNo")
            cmbtax.ClosePopup()


            cmbtype.Text = dsShow.Tables(0).Rows(0).Item("CrDbType")
            cmbtype.ClosePopup()


            DtToday.Enabled = False
            txtFinaltot.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("Amount"))
            txtNarration.Text = dsShow.Tables(0).Rows(0).Item("Narration")

            txtReferences.Text = dsShow.Tables(0).Rows(0).Item("Ref")
            txtReferencesTop.Text = dsShow.Tables(0).Rows(0).Item("OtherRef")




            txtTaxGST.Text = IIf(IsDBNull(Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("GST"))), "", Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("GST")))


            txtTaxSch.Text = IIf(IsDBNull(Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("SCharge"))), "", Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("SCharge")))




            LoadResDetails()






        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub ShowGridDetsMasb()


        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            PubIsEdit = 1

            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select *  from dbo.[Invoice.CrDb.Master] where CrDbNo= '{0}'", gvMbCnSum.GetRowCellValue(gvMbCnSum.FocusedRowHandle, "CrDbNo")), Conn)
            daShow.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabTaxinvocie.TabPages(2).PageEnabled = True
            tabTaxinvocie.TabPages(0).PageEnabled = False
            tabTaxinvocie.TabPages(1).PageEnabled = False

            tabTaxinvocie.SelectedTabPageIndex = 2



            PubCrDbNo = dsShow.Tables(0).Rows(0).Item("CrDbNo")

            'CmbtopFit.Text = dsShow.Tables(0).Rows(0).Item("MainType")
            'CmbtopFit.ClosePopup()










            'cbTopcode.Text = dsShow.Tables(0).Rows(0).Item("Topcode")

            txtMbillCN.Text = dsShow.Tables(0).Rows(0).Item("CrDbNo")

            Dttoday2.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("CrDbDate"))

            cmbBills.Text = dsShow.Tables(0).Rows(0).Item("TaxInvNo")
            cmbBills.ClosePopup()


            'cmbtype.Text = dsShow.Tables(0).Rows(0).Item("CrDbType")
            'cmbtype.ClosePopup()


            Dttoday2.Enabled = False



            txtAmt.Text = IIf(IsDBNull(Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("MasCrTot"))), "", Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("MasCrTot")))

            txtNewGST.Text = IIf(IsDBNull(Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("GST"))), "", Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("GST")))


            txtNewScharge.Text = IIf(IsDBNull(Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("SCharge"))), "", Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("SCharge")))



            'txtAmt.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("MasCrTot"))
            ' txtNewGST.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("GST"))
            ' txtNewScharge.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("SCharge"))

            txtNar.Text = dsShow.Tables(0).Rows(0).Item("Narration")

            txtRef.Text = dsShow.Tables(0).Rows(0).Item("Ref")

            txtOutlet.Text = dsShow.Tables(0).Rows(0).Item("OtherRef")



            'LoadResDetails()






        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
   
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
            Else
                mNumberValue = Microsoft.VisualBasic.Left(NumberValue, InStr(NumberValue, ".") - 1)
                mFraction = Mid(NumberValue, InStr(NumberValue, ".")) ' + 1)
                mFraction = Math.Round(CSng(mFraction), 2) * 100

                If CInt(mFraction) = 0 Then
                    mFraction = ""
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
    Private Sub InsertCreDbNote()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Dim numtostrcls As New clsConversion

        Dim CurrentUser As String = CurrUser

        Dim GrandTot As Decimal = Convert.ToDecimal(txtFinaltot.Text.Trim) + Convert.ToDecimal(txtTaxGST.Text.Trim) + Convert.ToDecimal(txtTaxSch.Text.Trim)
        Dim FinalTotWords As String = numtostrcls.ConvertNumberToWords(GrandTot)

        Try

            dcInsertNewAcc = New SqlCommand("InsertcndnTaxMaster_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@CrDbNo", SqlDbType.VarChar).Value = txtcndn.Text.Trim

            dcInsertNewAcc.Parameters.Add("@MainType", SqlDbType.VarChar).Value = CmbtopFit.Text.Trim

            dcInsertNewAcc.Parameters.Add("@CrDbType", SqlDbType.VarChar).Value = cmbtype.Text.Trim

            If CeInvBase.Checked = True Then
                dcInsertNewAcc.Parameters.Add("@IsInvBased", SqlDbType.VarChar).Value = 0
                dcInsertNewAcc.Parameters.Add("@TaxInvNo ", SqlDbType.VarChar).Value = ""
            Else
                dcInsertNewAcc.Parameters.Add("@IsInvBased", SqlDbType.VarChar).Value = 1
                dcInsertNewAcc.Parameters.Add("@TaxInvNo ", SqlDbType.VarChar).Value = cmbtax.Text.Trim
            End If


            dcInsertNewAcc.Parameters.Add("@CrDbDate", SqlDbType.DateTime).Value = DtToday.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@Topcode", SqlDbType.VarChar).Value = cbTopcode.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Amount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtFinaltot.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@AmountWords", SqlDbType.VarChar).Value = FinalTotWords
            dcInsertNewAcc.Parameters.Add("@Narration", SqlDbType.VarChar).Value = txtNarration.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Ref", SqlDbType.VarChar).Value = txtReferences.Text.Trim
            dcInsertNewAcc.Parameters.Add("@OtherRef", SqlDbType.VarChar).Value = txtReferencesTop.Text.Trim


            If CmbtopFit.Text.Trim = "TOP" Then

                dcInsertNewAcc.Parameters.Add("@FIT", SqlDbType.VarChar).Value = ""
                dcInsertNewAcc.Parameters.Add("@FITAdd", SqlDbType.VarChar).Value = ""
                dcInsertNewAcc.Parameters.Add("@FITInv", SqlDbType.VarChar).Value = ""


            End If


            If CmbtopFit.Text.Trim = "FIT" Then

                dcInsertNewAcc.Parameters.Add("@FIT", SqlDbType.VarChar).Value = txtFitname.Text.Trim
                dcInsertNewAcc.Parameters.Add("@FITAdd", SqlDbType.VarChar).Value = txtFitadd.Text.Trim
                dcInsertNewAcc.Parameters.Add("@FITInv", SqlDbType.VarChar).Value = txtFitInvNo.Text.Trim


            End If

            dcInsertNewAcc.Parameters.Add("@GST", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTaxGST.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@SCharge", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTaxSch.Text.Trim)

            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
            dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser


            Dim type As String = ""
            Dim prefix As String = ""


            If cmbtype.Text = "CreditNote" Then
                type = "CRNOTE"
                prefix = "CRN-ERI-13-"
            End If


            If cmbtype.Text = "DebitNote" Then
                type = "DBNOTE"
                prefix = "DBN-ERI-13-"
            End If



            dcInsertNewAcc.Parameters.Add("@ResType", SqlDbType.VarChar).Value = type
            dcInsertNewAcc.Parameters.Add("@PrefixCode", SqlDbType.VarChar).Value = prefix


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub InsertMasbillCreNote()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Dim numtostrcls As New clsConversion

        Dim CurrentUser As String = CurrUser
        Dim FinalTotWords As String = numtostrcls.ConvertNumberToWords(Convert.ToDecimal(txtAmt.Text.Trim) + Convert.ToDecimal(txtNewGST.Text.Trim) + Convert.ToDecimal(txtNewScharge.Text.Trim))

        Try

            dcInsertNewAcc = New SqlCommand("InsertMasbillcn_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@CrDbNo", SqlDbType.VarChar).Value = txtMbillCN.Text.Trim
            dcInsertNewAcc.Parameters.Add("@TaxInvNo ", SqlDbType.VarChar).Value = cmbBills.Text.Trim
            dcInsertNewAcc.Parameters.Add("@CrDbDate", SqlDbType.DateTime).Value = Dttoday2.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@Amount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtAmt.Text.Trim) + Convert.ToDecimal(txtNewGST.Text.Trim) + Convert.ToDecimal(txtNewScharge.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@AmountWords", SqlDbType.VarChar).Value = FinalTotWords
            dcInsertNewAcc.Parameters.Add("@Narration", SqlDbType.VarChar).Value = txtNar.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Ref", SqlDbType.VarChar).Value = txtRef.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
            dcInsertNewAcc.Parameters.Add("@GST", SqlDbType.Decimal).Value = Convert.ToDecimal(txtNewGST.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@SCharge", SqlDbType.Decimal).Value = Convert.ToDecimal(txtNewScharge.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@MasCrtot", SqlDbType.Decimal).Value = Convert.ToDecimal(txtAmt.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@OtherRef", SqlDbType.VarChar).Value = txtOutlet.Text.Trim


            dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser

            dcInsertNewAcc.Parameters.Add("@ResType", SqlDbType.VarChar).Value = "MCRNOTE"
            dcInsertNewAcc.Parameters.Add("@PrefixCode", SqlDbType.VarChar).Value = "MRN-ERI-13-"


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Sub ClearFields()

        txtcndn.Text = ""
        gcResdetails.DataSource = Nothing
        txtFinaltot.Text = ""
        txtReferences.Text = ""
        txtReferencesTop.Text = ""
        txtNarration.Text = ""


    End Sub
    Function GetTaxInvCodeMas(ByVal maintype As String, ByVal prefix As String) As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()

        Try

            Dim GetTopcode As String = maintype
            Dim GetPrefix As String = prefix

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
    Function FieldValidation() As Boolean
        ' Return IIf(String.Compare(cmbtax.Text, "", False) = 0 Or String.Compare(txtRate.Text, "", False) = 0 Or String.Compare(txtTransferrateArr.Text, "", False) = 0 Or String.Compare(txtFinaltot.Text, "", False) = 0 Or String.Compare(txtBednights.Text, "", False) = 0, 0, 1)
        Return IIf(String.Compare(txtcndn.Text, "", False) = 0 Or String.Compare(txtNarration.Text, "", False) = 0 Or String.Compare(txtFinaltot.Text, "", False) = 0, 0, 1)
    End Function
    Function FieldValidationmasCn() As Boolean
        ' Return IIf(String.Compare(cmbtax.Text, "", False) = 0 Or String.Compare(txtRate.Text, "", False) = 0 Or String.Compare(txtTransferrateArr.Text, "", False) = 0 Or String.Compare(txtFinaltot.Text, "", False) = 0 Or String.Compare(txtBednights.Text, "", False) = 0, 0, 1)
        Return IIf(String.Compare(txtMbillCN.Text, "", False) = 0 Or String.Compare(txtNar.Text, "", False) = 0 Or String.Compare(txtAmt.Text, "", False) = 0 Or String.Compare(cmbBills.Text, "", False) = 0, 0, 1)
    End Function
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[Invoice.CrDb.Master] where status='OPEN'  and Maintype !='MBILL' order by CrDbNo", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            grdTaxinv.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadGridMbill()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[Invoice.CrDb.Master] where status='OPEN'  and Maintype ='MBILL' order by CrDbNo", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcMbCnSum.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub btAddTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddTax.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "CrDbNote", "Add")

        If CheckAccess = True Then



            Try


                If String.Compare(btAddTax.Text, "Create", False) = 0 Then

                    ClearFields()
                    btAddTax.Text = "Save"
                    ' btEdit.Enabled = False
                    btDel.Enabled = False
                    btPrint.Enabled = False
                    ' btRev.Enabled = False

                    tabTaxinvocie.TabPages(1).PageEnabled = True

                    tabTaxinvocie.TabPages(0).PageEnabled = False
                    tabTaxinvocie.SelectedTabPageIndex = 1

                Else

                    If FieldValidation() = False Then
                        MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                        Exit Sub
                    Else
                       



                        Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Credit/Debit Note", "Save Credit/Debit Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If bt = Windows.Forms.DialogResult.Yes Then
                            InsertCreDbNote()
                            LoadGrid()
                        End If


                    LoadGrid()

                    btAddTax.Text = "Create"
                        btDel.Enabled = True
                    btPrint.Enabled = True
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
    Private Sub PrintTaxInv()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from  [TempInvoiceCrDbMaster]", Conn)

            'dcIns.Parameters.Add("@CrDbNo", SqlDbType.VarChar).Value = txtcndn.Text.Trim

            'Dim CrDbno As String = txtcndn.Text.Trim

            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtcndn.Text) & "'"

            fltString = ""
            'fltString = "{rpt_dbcr_note_view.CrDbNo}='" & Trim(txtcndn.Text) & "'"




            If cmbtype.Text.Trim = "CreditNote" And CmbtopFit.Text = "TOP" Then

                ReportName = "CreditNoteTop.rpt"
                rptTitle = "Credit Note"

            End If


            If cmbtype.Text.Trim = "DebitNote" And CmbtopFit.Text = "TOP" Then

                ReportName = "DebitNoteTop.rpt"
                rptTitle = "Debit Note"


            End If


            If cmbtype.Text.Trim = "CreditNote" And CmbtopFit.Text = "FIT" Then

                ReportName = "CreditNoteFIT.rpt"
                rptTitle = "Credit Note"

            End If


            If cmbtype.Text.Trim = "DebitNote" And CmbtopFit.Text = "FIT" Then

               
                ReportName = "DebitNoteTopFIT.rpt"
                rptTitle = "Debit Note"


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
    Private Sub PrintMasbillCN()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from  [TempInvoiceCrDbMaster]", Conn)

            'dcIns.Parameters.Add("@CrDbNo", SqlDbType.VarChar).Value = txtcndn.Text.Trim

            'Dim CrDbno As String = txtcndn.Text.Trim

            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtcndn.Text) & "'"

            fltString = ""
            'fltString = "{rpt_dbcr_note_view.CrDbNo}='" & Trim(txtcndn.Text) & "'"




            'If cmbtype.Text.Trim = "CreditNote" And CmbtopFit.Text = "TOP" Then

            '    ReportName = "CreditNoteTop.rpt"
            '    rptTitle = "Credit Note"

            'End If


            'If cmbtype.Text.Trim = "DebitNote" And CmbtopFit.Text = "TOP" Then

            '    ReportName = "DebitNoteTop.rpt"
            '    rptTitle = "Debit Note"


            'End If


            'If cmbtype.Text.Trim = "CreditNote" And CmbtopFit.Text = "FIT" Then

            '    ReportName = "CreditNoteFIT.rpt"
            '    rptTitle = "Credit Note"

            'End If


            'If cmbtype.Text.Trim = "DebitNote" And CmbtopFit.Text = "FIT" Then

            ReportName = "CreditNoteMasbill.rpt"
            rptTitle = "Credit Note"


            'End If


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
    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click

        InsertTempCrdbDetails(PubCrDbNo)
        PrintTaxInv()
    End Sub
    Private Sub InsertTempCrdbDetails(ByVal passCrDbNo As String)

        Dim GetpassCrDbNo As String = passCrDbNo

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("TempInsertCrDb_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@CrDbNo", SqlDbType.VarChar).Value = GetpassCrDbNo


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()



    End Sub
    Private Sub InsertTempCrdbMbillDetails(ByVal passCrDbNo As String)

        Dim GetpassCrDbNo As String = passCrDbNo

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        'Dim GetGst As Decimal = Convert.ToDecimal(txtNewGST.Text.ToString)
        'Dim GetScharge As Decimal = Convert.ToDecimal(txtNewScharge.Text.ToString)
        'Dim GetTotal As Decimal = Convert.ToDecimal(txtAmt.Text.ToString)


        dcInsertNewAcc = New SqlCommand("TempInsertCrDbMbill_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@CrDbNo", SqlDbType.VarChar).Value = GetpassCrDbNo
        'dcInsertNewAcc.Parameters.Add("@Gst", SqlDbType.Decimal).Value = GetGst
        'dcInsertNewAcc.Parameters.Add("@Scharge", SqlDbType.Decimal).Value = GetScharge
        'dcInsertNewAcc.Parameters.Add("@CrTot", SqlDbType.Decimal).Value = GetTotal


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()



    End Sub

    Private Sub cmbtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtype.SelectedIndexChanged

        If cmbtype.Text = "CreditNote" Then
            txtcndn.Text = GetTaxInvCodeMas("CRNOTE", "CRN-ERI-13-")
        End If

        If cmbtype.Text = "DebitNote" Then
            txtcndn.Text = GetTaxInvCodeMas("DBNOTE", "DBN-ERI-13-")
        End If





    End Sub

    
    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "CrDbNote", "Delete")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Delete This Credit/Debit Note", "Delete Credit/Debit Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveCrDb()


                End If
                LoadGrid()
                tabTaxinvocie.TabPages(1).PageEnabled = False
                tabTaxinvocie.TabPages(0).PageEnabled = True
                tabTaxinvocie.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub InactiveCrDb()

        Try

            Dim CurrentUser As String = CurrUser


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand
            dcInsertNewAcc = New SqlCommand("InactiveCrDb_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@CrDbNo", SqlDbType.VarChar).Value = txtcndn.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Inactivatedby", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Credit/Debit Note Deleted Successfully", "Delete  Credit/Debit Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub InactiveMasCr()

        Try

            Dim CurrentUser As String = CurrUser


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand
            dcInsertNewAcc = New SqlCommand("InactiveCrDb_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@CrDbNo", SqlDbType.VarChar).Value = txtMbillCN.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Inactivatedby", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Mas Bill Credit Note Deleted Successfully", "Delete Credit Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub

    Private Sub Cmbtop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbtopFit.SelectedIndexChanged

        If CmbtopFit.Text = "TOP" Then
            lblName.Text = "Tour Operator"
            txtFitname.Visible = False
            lblAddfit.Visible = False
            txtFitadd.Visible = False
            lblFitInvNo.Visible = False
            txtFitInvNo.Visible = False

        End If


        If CmbtopFit.Text = "FIT" Then

            lblName.Text = "FIT Name"
            txtFitname.Visible = True
            lblAddfit.Visible = True
            txtFitadd.Visible = True
            lblFitInvNo.Visible = True
            txtFitInvNo.Visible = True


        End If





    End Sub

    Private Sub btViewmasbills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewmasbills.Click

        LoadMasbills()

    End Sub

    Private Sub btViewmasbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewmasbill.Click

        gcmasbill.DataSource = Nothing


        LoadMasBillDetails()

    End Sub

    Private Sub btMasBillcrnote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMasBillcrnote.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "CrDbNote", "Add")

        If CheckAccess = True Then



            Try


                If String.Compare(btMasBillcrnote.Text, "Create-MasBill", False) = 0 Then

                    ClearFields()
                    btMasBillcrnote.Text = "Save"
                    ' btEdit.Enabled = False
                    btDel.Enabled = False
                    btPrint.Enabled = False
                    btAddTax.Enabled = False
                    ' btRev.Enabled = False

                    tabTaxinvocie.TabPages(2).PageEnabled = True

                    tabTaxinvocie.TabPages(0).PageEnabled = False
                    tabTaxinvocie.TabPages(1).PageEnabled = False

                    tabTaxinvocie.SelectedTabPageIndex = 2

                Else

                    If FieldValidationmasCn() = False Then
                        MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                        Exit Sub
                    Else




                        Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Master Bill Credit Note", "Save Credit Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If bt = Windows.Forms.DialogResult.Yes Then

                            InsertMasbillCreNote()
                            LoadGridMbill()
                        End If


                        LoadGridMbill()

                        btMasBillcrnote.Text = "Create-MasBill"
                        btDel.Enabled = True
                        btPrint.Enabled = True
                        btAddTax.Enabled = True
                        tabTaxinvocie.TabPages(1).PageEnabled = False
                        tabTaxinvocie.TabPages(2).PageEnabled = False
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

        txtMbillCN.Text = GetTaxInvCodeMas("MCRNOTE", "MRN-ERI-13-")




    End Sub

    Private Sub txtAmt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmt.Leave


        'txtNewGST.Text = (PubMasBillGst / PubMasBillTotal) * Convert.ToDecimal(txtAmt.Text.Trim)

        'txtNewScharge.Text = (PubMasBillScharge / PubMasBillTotal) * Convert.ToDecimal(txtAmt.Text.Trim)

    End Sub

    Private Sub gvmasbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvmasbill.Click

        PubMasDep = gvmasbill.GetRowCellValue(gvmasbill.FocusedRowHandle, "Department")
        PubMasTot = Convert.ToDecimal(gvmasbill.GetRowCellValue(gvmasbill.FocusedRowHandle, "Total"))
        PubMasGst = Convert.ToDecimal(gvmasbill.GetRowCellValue(gvmasbill.FocusedRowHandle, "GST"))
        PubMasScharge = Convert.ToDecimal(gvmasbill.GetRowCellValue(gvmasbill.FocusedRowHandle, "Scharge"))

        txtAmt.Text = PubMasTot
        txtNewGST.Text = PubMasGst
        txtNewScharge.Text = PubMasScharge
        txtOutlet.Text = PubMasDep


    End Sub

    Private Sub gvMbCnSum_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvMbCnSum.DoubleClick
        ShowGridDetsMasb()
    End Sub

    Private Sub btDelMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelMas.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "CrDbNote", "Delete")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Delete This Master Bill Credit Note", "Delete Credit Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveMasCr()


                End If
                LoadGridMbill()

                tabTaxinvocie.TabPages(1).PageEnabled = False
                tabTaxinvocie.TabPages(2).PageEnabled = False

                tabTaxinvocie.TabPages(0).PageEnabled = True
                tabTaxinvocie.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub btPrintmas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrintmas.Click
        InsertTempCrdbMbillDetails(PubCrDbNo)
        PrintMasbillCN()
    End Sub
End Class