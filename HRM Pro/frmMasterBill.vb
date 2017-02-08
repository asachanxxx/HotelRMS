Imports System.Data.SqlClient
Imports System.Xml
Public Class frmMasterBill

    Dim Pubtotal2012 As Decimal = 0
    Dim Pubtotal2013 As Decimal = 0

    Dim PubService2012 As Decimal = 0
    Dim PubService2013 As Decimal = 0

    Dim PubServiceTotal2012 As Decimal = 0
    Dim PubServiceTotal2013 As Decimal = 0
    Dim PubGst2012 As Decimal = 0
    Dim PubGst2013 As Decimal = 0
    Public PubGrandTot2012 As Decimal = 0
    Public PubGrandTot2013 As Decimal = 0
    Public PubGrandTot As Decimal = 0
    Public ReportName As String
    Public rptTitle As String
    Public SF As String = ""
    Private Sub txtBillamount2012_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBillamount2012.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtGrandTotal.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtBillamount2013_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBillamount2013.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtGrandTotal.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtScharge2012_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtScharge2012.KeyDown
        'Dim DSep As String = "."
        'If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

        '    If e.KeyChar = CChar(DSep) Then

        '        e.Handled = True

        '    ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

        '        Me.txtGrandTotal.Select() ''<---jump to next text box after press Enter  

        '        e.Handled = False

        '    Else

        '        e.Handled = True
        '    End If

        'End If
    End Sub

    Private Sub txtScharge2013_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtScharge2013.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtGrandTotal.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtTotal2012_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal2012.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtGrandTotal.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtTotal2013_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal2013.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtGrandTotal.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtTotGst2012_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotGst2012.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtGrandTotal.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtTotGst2013_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotGst2013.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtGrandTotal.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtGrandTotal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrandTotal.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtGrandTotal.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub frmMasterBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        LoadGrid()
        LoadTopcodes()

        cmbOutlets.SelectedIndex = 0

        DtArrival.Text = DateTime.Now.Date
        DtDep.Text = DateTime.Now.Date

        tabMasbill.TabPages(1).PageEnabled = False

    End Sub
    Private Sub txtScharge2012_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtScharge2012.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtGrandTotal.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub
    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Master billing-Temp", "Add")

        If CheckAccess = True Then



            If String.Compare(btAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btAdd.Text = "Save"
                btEdit.Enabled = False
                btDel.Enabled = False
                tabMasbill.TabPages(1).PageEnabled = True
                tabMasbill.SelectedTabPageIndex = 1

            Else

                Try

                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Master Bill", "Save Master Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then

                        InsertMasterBill()

                    End If
                    LoadGrid()
                    btAdd.Text = "Add"
                    btEdit.Enabled = True
                    btDel.Enabled = True
                    tabMasbill.TabPages(1).PageEnabled = False
                    tabMasbill.SelectedTabPageIndex = 0
                    gcBill.DataSource = Nothing
                    Exit Sub

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
                End Try
            End If

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select * from dbo.[MasterBill] order by MasBillNo", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            GcMasterBill.DataSource = dsMain.Tables(0)

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
    Sub ClearFields()


        Dim dsMasBillNo As New DataSet
        dsMasBillNo = DSGetMasNo()

        Dim MasterBillno As String = "MB-" + dsMasBillNo.Tables(0).Rows(0)(0).ToString


        txtMasbillno.Text = MasterBillno
        DeleteMasBillTemp()
        txtRoomno.Text = ""
        txtGuest.Text = ""
        txtRegno.Text = ""
        cmbOutlets.SelectedIndex = 0
        txtBillamount2012.Text = "0"
        txtBillamount2013.Text = "0"

        gcBill.DataSource = Nothing

        txtScharge2012.Text = "0"
        txtScharge2013.Text = "0"


        txtSchargeTot2013.Text = "0"
        txtSchargeTot2012.Text = "0"

        txtGst2012.Text = "0"
        txtGst2013.Text = "0"

        txtTotal2012.Text = "0"
        txtTotal2013.Text = "0"

        txtTotGst2012.Text = "0"
        txtTotGst2013.Text = "0"

        txtGrandTotal.Text = "0"



    End Sub
    Function DSGetMasNo() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            dcSearch = New SqlCommand("select Masbillno from dbo.[AutoNos]", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            DSGetMasNo = dsMain

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function
    Private Sub InsertMasterBill()

        Try

            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand


            dcInsertNewAcc = New SqlCommand("InsertMasterBill_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            Dim CurrentUser As String = CurrUser

            dcInsertNewAcc.Parameters.Add("@MasBillNo", SqlDbType.VarChar).Value = txtMasbillno.Text
            dcInsertNewAcc.Parameters.Add("@GeneratedBy", SqlDbType.VarChar).Value = CurrentUser
            dcInsertNewAcc.Parameters.Add("@RoomNo", SqlDbType.Int).Value = Convert.ToInt16(txtRoomno.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@Guest", SqlDbType.VarChar).Value = txtGuest.Text.Trim
            dcInsertNewAcc.Parameters.Add("@TopCode", SqlDbType.VarChar).Value = cbTopcode.Text
            dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = DtArrival.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = DtDep.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@Regno", SqlDbType.VarChar).Value = txtRegno.Text

            dcInsertNewAcc.Parameters.Add("@RatePre", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotal2012.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@RatePost", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotal2013.Text.Trim)

            dcInsertNewAcc.Parameters.Add("@SchargePre", SqlDbType.Decimal).Value = Convert.ToDecimal(txtScharge2012.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@SchargePost", SqlDbType.Decimal).Value = Convert.ToDecimal(txtScharge2013.Text.Trim)

            dcInsertNewAcc.Parameters.Add("@GstPre", SqlDbType.Decimal).Value = Convert.ToDecimal(txtGst2012.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@GstPost", SqlDbType.Decimal).Value = Convert.ToDecimal(txtGst2013.Text.Trim)

            dcInsertNewAcc.Parameters.Add("@TotalPre", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotGst2012.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@TotalPost", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTotGst2013.Text.Trim)


            dcInsertNewAcc.Parameters.Add("@GrandTotal", SqlDbType.Decimal).Value = Convert.ToDecimal(txtGrandTotal.Text.Trim)

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Master Bill Saved Successfully", "Save Master Bill", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()


            InsertMasterBillDetail()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub

    Private Sub InsertMasterBillDetail()

        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim CurrentUser As String = CurrUser

            dcSearch = New SqlCommand("select * from dbo.[MasterBillDetail_Temp]  where MasBillNo=@MasBillNo", Conn)
            dcSearch.Parameters.Add("@MasBillNo", SqlDbType.VarChar).Value = txtMasbillno.Text.Trim


            Conn.Open()
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            Conn.Close()

            Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1


            While DScount >= 0

                dcInsertNewAcc = New SqlCommand("InsertMasterBillDetail_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@MasBillNo", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(1).ToString
                dcInsertNewAcc.Parameters.Add("@Outlet", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(3).ToString
                dcInsertNewAcc.Parameters.Add("@Year", SqlDbType.Int).Value = dsMain.Tables(0).Rows(DScount)(4).ToString
                dcInsertNewAcc.Parameters.Add("@Amount", SqlDbType.Decimal).Value = dsMain.Tables(0).Rows(DScount)(5).ToString
                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()
                DScount = DScount - 1
            End While

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub


    Private Sub InsertMasBillDetailTemp(ByVal year As Integer)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InsertMasBillDetailTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

        Dim CurrentUser As String = CurrUser

        Dim GetYear As String = year

        Dim GetAmount As Decimal = 0

        If GetYear = 2012 Then
            GetAmount = Convert.ToDecimal(txtBillamount2012.Text.Trim)
        End If

        If GetYear = 2013 Then
            GetAmount = Convert.ToDecimal(txtBillamount2013.Text.Trim)
        End If

        dcInsertNewAcc.Parameters.Add("@Masterbillno", SqlDbType.VarChar).Value = txtMasbillno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Roomno", SqlDbType.VarChar).Value = txtRoomno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Outlet", SqlDbType.VarChar).Value = cmbOutlets.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Year", SqlDbType.Int).Value = GetYear
        dcInsertNewAcc.Parameters.Add("@Amount", SqlDbType.Decimal).Value = GetAmount
        dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub

    Private Sub add2012_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add2012.Click
        If FieldValidationRooms() = False Then
            MsgBox("Enter Room No", MsgBoxStyle.Critical, ErrTitle)

        Else

            Dim getService2012 As Decimal
            InsertMasBillDetailTemp(2012)
            LoadOutletbilltemp()

            Dim gettot2012 As Decimal = Convert.ToDecimal(txtBillamount2012.Text.Trim)

            If cmbOutlets.Text = "Dive/Surf" Or cmbOutlets.Text = "Misraabshop" Then
                getService2012 = 0
            Else
                getService2012 = gettot2012 * 0.1
            End If


            Pubtotal2012 = Pubtotal2012 + gettot2012

            PubService2012 = PubService2012 + getService2012

            txtTotal2012.Text = Pubtotal2012
            txtScharge2012.Text = PubService2012

            PubServiceTotal2012 = Pubtotal2012 + PubService2012
            txtSchargeTot2012.Text = PubServiceTotal2012

            PubGst2012 = PubServiceTotal2012 * 0.06

            txtGst2012.Text = PubGst2012

            PubGrandTot2012 = PubServiceTotal2012 + PubGst2012


            txtTotGst2012.Text = PubGrandTot2012


            PubGrandTot = PubGrandTot2013 + PubGrandTot2012

            txtGrandTotal.Text = PubGrandTot

            txtBillamount2012.Text = ""
        End If

    End Sub

    Private Sub add2013_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add2013.Click

        If FieldValidationRooms() = False Then
            MsgBox("Enter Room No", MsgBoxStyle.Critical, ErrTitle)

        Else

            Dim getService2013 As Decimal

            InsertMasBillDetailTemp(2013)
            LoadOutletbilltemp()


            Dim gettot2013 As Decimal = Convert.ToDecimal(txtBillamount2013.Text.Trim)

            If cmbOutlets.Text = "Dive/Surf" Or cmbOutlets.Text = "Misraabshop" Or cmbOutlets.Text = "BedTax" Then
                getService2013 = 0
            Else
                getService2013 = gettot2013 * 0.1
            End If



            Pubtotal2013 = Pubtotal2013 + gettot2013
            PubService2013 = PubService2013 + getService2013

            txtTotal2013.Text = Pubtotal2013
            txtScharge2013.Text = PubService2013


            PubServiceTotal2013 = Pubtotal2013 + PubService2013
            txtSchargeTot2013.Text = PubServiceTotal2013




            If cmbOutlets.Text = "BedTax" Then
                ' PubGst2013 = PubServiceTotal2013

            Else

                PubGst2013 = PubServiceTotal2013 * 0.08


            End If


            ' PubGst2013 = PubServiceTotal2013 * 0.08

            txtGst2013.Text = PubGst2013


            PubGrandTot2013 = PubServiceTotal2013 + PubGst2013

            txtTotGst2013.Text = PubGrandTot2013


            PubGrandTot = PubGrandTot2013 + PubGrandTot2012

            txtGrandTotal.Text = PubGrandTot

            txtBillamount2013.Text = ""


        End If

    End Sub
    Function FieldValidationRooms() As Boolean
        Return IIf(String.Compare(txtRoomno.Text, "", False) = 0, 0, 1)
    End Function


    Private Sub LoadOutletbilltemp()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim CurrentUser As String = CurrUser

            dcSearch = New SqlCommand("select Outlet,Amount from dbo.[MasterBillDetail_Temp] where MasBillNo=@MasBillNo and Room=@Room order by Year", Conn)
            dcSearch.Parameters.Add("@MasBillNo", SqlDbType.VarChar).Value = txtMasbillno.Text.Trim
            dcSearch.Parameters.Add("@Room", SqlDbType.VarChar).Value = txtRoomno.Text.Trim


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            gcBill.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub DeleteMasBillTemp()

        Try

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Dim CurrentUser As String = CurrUser

        dcInsertNewAcc = New SqlCommand("DelMasDetailTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        dcInsertNewAcc.Parameters.Add("@MasBillNo", SqlDbType.VarChar).Value = txtMasbillno.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub

    Private Sub txtRoomno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRoomno.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub PrintMasterBill()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from Rpt_View_MasterBillPrint", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaProinv As Integer = GcMasterBillView.GetRowCellValue(GcMasterBillView.FocusedRowHandle, "Id")
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            'fltString = "{ rpt_view_Boatschedule_Arrival.BoatScheduleMID}='" & ParaProinv & "'"

            fltString = "{Rpt_View_MasterBillPrint.Id}=" & ParaProinv & ""

            ReportName = "MasterBill.rpt"
            rptTitle = "Master Bill"

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

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Master billing-Temp", "Print")

        If CheckAccess = True Then


            PrintMasterBill()

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
End Class