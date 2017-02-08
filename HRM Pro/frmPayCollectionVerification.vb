Imports System.Data.SqlClient
Imports System.Xml
Public Class frmPayCollectionVerification


    Public PubOutletMasbill As String = ""
    Public PubOutletMasbillTotal As Decimal = 0
    Public PubMasbill As String = ""
    Public PubMasbillTotal As Decimal = 0
    Public PubPassMastype As Integer = 0

    Private Sub frmPayCollectionVerification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

      


        dtCashDatef.Text = Date.Today.ToShortDateString
        dtCashDatet.Text = Date.Today.ToShortDateString


        dtDateMbf.Text = Date.Today.ToShortDateString
        dtDateMbT.Text = Date.Today.ToShortDateString

        LoadRoomNo()

        cmboutletID.SelectedIndex = 0



    End Sub


    Private Sub LoadRoomNo()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            'dcSearch = New SqlCommand("select Roomno from [Rooms.Master] order by Roomno", Conn)
            dcSearch = New SqlCommand("select [Roomno] from [Rooms.Master] order by [Roomno] ", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)
                cmbRoombilllist.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While

            
            cmbRoombilllist.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub LoadCashBills()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT  dbo.OutLetBillMaster.BillNo, dbo.OutLetBillMaster.BillGeneratedDate, dbo.OutLetBillMaster.BillGeneratedBy, dbo.OutLetBillMaster.OutletMasBill, dbo.OutLetBillMaster.Total - dbo.OutLetBillMaster.discountAmount + dbo.OutLetBillMaster.tax + dbo.OutLetBillMaster.serviceCharge AS PaidAmt,dbo.OutLetBillMaster.PayType, dbo.KotBotMaster.ManualBillno, dbo.OutLetBillMaster.Department FROM  dbo.OutLetBillMaster INNER JOIN dbo.KotBotMaster ON dbo.OutLetBillMaster.KOTBOTNo = dbo.KotBotMaster.Id WHERE     (dbo.OutLetBillMaster.ReservationNo = 'direct') AND (dbo.OutLetBillMaster.IsPaid = 0) and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.OutLetBillMaster.BillGeneratedDate)) >= @DateCashF and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.OutLetBillMaster.BillGeneratedDate)) <= @DateCashT order by dbo.OutLetBillMaster.BillNo", Conn)

            dcSearch.Parameters.Add("@DateCashF", SqlDbType.DateTime).Value = dtCashDatef.DateTime.Date


            dcSearch.Parameters.Add("@DateCashT", SqlDbType.DateTime).Value = dtCashDatet.DateTime.Date


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcCashbills.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadCashBillsByDep()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()




            dcSearch = New SqlCommand("SELECT  dbo.OutLetBillMaster.BillNo, dbo.OutLetBillMaster.BillGeneratedDate, dbo.OutLetBillMaster.BillGeneratedBy, dbo.OutLetBillMaster.OutletMasBill, dbo.OutLetBillMaster.Total - dbo.OutLetBillMaster.discountAmount + dbo.OutLetBillMaster.tax + dbo.OutLetBillMaster.serviceCharge AS PaidAmt,dbo.OutLetBillMaster.PayType, dbo.KotBotMaster.ManualBillno, dbo.OutLetBillMaster.Department FROM  dbo.OutLetBillMaster INNER JOIN dbo.KotBotMaster ON dbo.OutLetBillMaster.KOTBOTNo = dbo.KotBotMaster.Id WHERE   dbo.OutLetBillMaster.Department=@Dep and   (dbo.OutLetBillMaster.ReservationNo = 'direct') AND (dbo.OutLetBillMaster.IsPaid = 0) and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.OutLetBillMaster.BillGeneratedDate)) >= @DateCashF and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.OutLetBillMaster.BillGeneratedDate)) <= @DateCashT order by dbo.OutLetBillMaster.BillNo", Conn)

            dcSearch.Parameters.Add("@DateCashF", SqlDbType.DateTime).Value = dtCashDatef.DateTime.Date


            dcSearch.Parameters.Add("@DateCashT", SqlDbType.DateTime).Value = dtCashDatet.DateTime.Date

            dcSearch.Parameters.Add("@Dep", SqlDbType.VarChar).Value = cmboutletID.Text.Trim


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcCashbills.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadMasterBills()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT   dbo.BillMaster.BillNo, dbo.BillMaster.Date, dbo.BillMaster.CreatedBy, dbo.BillMaster.RoomNo, dbo.BillMaster.ReservationNo , dbo.BillMaster.Type,dbo.BillMaster.Total, dbo.OutLetBillPaymentMethodDetail.PayamentMethod FROM   dbo.BillMaster INNER JOIN dbo.OutLetBillPaymentMethodDetail ON dbo.BillMaster.BillNo = dbo.OutLetBillPaymentMethodDetail.OutLetBillNo WHERE     (dbo.BillMaster.IsPaid = 0) and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.BillMaster.Date)) >= @DateCashF and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.BillMaster.Date)) <= @DateCashT order by dbo.BillMaster.billno", Conn)

            dcSearch.Parameters.Add("@DateCashF", SqlDbType.DateTime).Value = dtDateMbf.DateTime.Date


            dcSearch.Parameters.Add("@DateCashT", SqlDbType.DateTime).Value = dtDateMbT.DateTime.Date


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcMasbill.DataSource = dsMain.Tables(0)

            PubPassMastype = 1


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadMasterBillsStaff()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT   dbo.BillMaster.BillNo, dbo.BillMaster.Date, dbo.BillMaster.CreatedBy, dbo.BillMaster.RoomNo ,dbo.BillMaster.ReservationNo , dbo.BillMaster.Type, dbo.BillMaster.Total, dbo.OutLetBillPaymentMethodDetail.PayamentMethod FROM   dbo.BillMaster INNER JOIN dbo.OutLetBillPaymentMethodDetail ON dbo.BillMaster.BillNo = dbo.OutLetBillPaymentMethodDetail.OutLetBillNo WHERE     (dbo.BillMaster.IsPaid = 0) and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.BillMaster.Date)) >=  @DateCashF and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.BillMaster.Date)) <= @DateCashT  and dbo.BillMaster.Type='STAFF'  order by dbo.BillMaster.billno", Conn)

            dcSearch.Parameters.Add("@DateCashF", SqlDbType.DateTime).Value = dtDateMbf.DateTime.Date


            dcSearch.Parameters.Add("@DateCashT", SqlDbType.DateTime).Value = dtDateMbT.DateTime.Date


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcMasbill.DataSource = dsMain.Tables(0)

            PubPassMastype = 1


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadMasterBillsByRoom()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT   dbo.BillMaster.BillNo, dbo.BillMaster.Date, dbo.BillMaster.CreatedBy, dbo.BillMaster.RoomNo, dbo.BillMaster.ReservationNo , dbo.BillMaster.Type,dbo.BillMaster.Total, dbo.OutLetBillPaymentMethodDetail.PayamentMethod FROM dbo.BillMaster INNER JOIN  dbo.OutLetBillPaymentMethodDetail ON dbo.BillMaster.BillNo = dbo.OutLetBillPaymentMethodDetail.OutLetBillNo WHERE    dbo.BillMaster.RoomNo=@Rmno and (dbo.BillMaster.IsPaid = 0) and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.BillMaster.Date)) >= @DateCashF and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.BillMaster.Date)) <= @DateCashT order by dbo.BillMaster.billno", Conn)

            dcSearch.Parameters.Add("@DateCashF", SqlDbType.DateTime).Value = dtDateMbf.DateTime.Date


            dcSearch.Parameters.Add("@DateCashT", SqlDbType.DateTime).Value = dtDateMbT.DateTime.Date

            dcSearch.Parameters.Add("@Rmno", SqlDbType.VarChar).Value = cmbRoombilllist.Text.Trim


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcMasbill.DataSource = dsMain.Tables(0)


            PubPassMastype = 2

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub btViewCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewCash.Click


        If cmboutletID.Text.Trim = "ALL" Then

            LoadCashBills()


        Else

            LoadCashBillsByDep()

        End If




    End Sub

    Private Sub gvCashbills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvCashbills.Click

        PubOutletMasbill = gvCashbills.GetRowCellValue(gvCashbills.FocusedRowHandle, "OutletMasBill")
        PubOutletMasbillTotal = Convert.ToDecimal(gvCashbills.GetRowCellValue(gvCashbills.FocusedRowHandle, "PaidAmt"))
        txtGotamtCash.Text = PubOutletMasbillTotal.ToString
        chCash.Checked = True
        txtCashnotCash.Text = ""
        txtNarCash.Text = ""

        txtGotamtCash.Focus()

    End Sub

    Private Sub btUpdateCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdateCash.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "PaymentsVerification", "Add")

        If CheckAccess = True Then


            If gvCashbills.RowCount = 0 Then
                Exit Sub
            End If

            '--- what m donna do is... 
            ' if update clicked, remove the all the records from the reservertionroomassign and recreate

            Dim getIscheck As Integer = 0


            If chCash.Checked = True Then
                getIscheck = 1
            End If





            If IsUpdateCashbills(getIscheck, Convert.ToDecimal(txtGotamtCash.Text.Trim), txtNarCash.Text.Trim, txtCashnotCash.Text.Trim, PubOutletMasbill) Then
                MsgBox("Successfully Updated", MsgBoxStyle.Information, ErrTitle)
            End If



            If cmboutletID.Text.Trim = "ALL" Then

                LoadCashBills()


            Else

                LoadCashBillsByDep()

            End If


            chCash.Checked = False
            txtGotamtCash.Text = ""
            txtCashnotCash.Text = ""
            txtNarCash.Text = ""




        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub
    Function IsUpdateCashbills(ByVal IsPaid As Integer, ByVal PaidAmt As Decimal, ByVal PaidNar As String, ByVal CashNote As String, ByVal OutletMasBill As String) As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand
        Dim sqlStr As String

        Try
            Conn.Open()

            dcExec = New SqlCommand("UpdateCashBillsPaids_SP", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            dcExec.Parameters.Add("@IsPaid", SqlDbType.Int).Value = IsPaid
            dcExec.Parameters.Add("@PaidAmt", SqlDbType.Decimal).Value = PaidAmt
            dcExec.Parameters.Add("@PaidNar", SqlDbType.VarChar).Value = PaidNar
            dcExec.Parameters.Add("@CashNote", SqlDbType.VarChar).Value = CashNote
            dcExec.Parameters.Add("@OutletMasBill", SqlDbType.VarChar).Value = OutletMasBill

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
    Function IsUpdateMasterbills(ByVal IsPaid As Integer, ByVal PaidAmt As Decimal, ByVal PaidNar As String, ByVal CashNote As String, ByVal OutletMasBill As String) As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand
        Dim sqlStr As String

        Try
            Conn.Open()

            dcExec = New SqlCommand("UpdateMasterBillsPaids_SP", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            dcExec.Parameters.Add("@IsPaid", SqlDbType.Int).Value = IsPaid
            dcExec.Parameters.Add("@PaidAmt", SqlDbType.Decimal).Value = PaidAmt
            dcExec.Parameters.Add("@PaidNar", SqlDbType.VarChar).Value = PaidNar
            dcExec.Parameters.Add("@CashNote", SqlDbType.VarChar).Value = CashNote
            dcExec.Parameters.Add("@MasBill", SqlDbType.VarChar).Value = OutletMasBill

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

    Private Sub btViewMbilAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewMbilAll.Click
        LoadMasterBills()
    End Sub

    Private Sub btViewMbil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewMbil.Click
        LoadMasterBillsByRoom()
    End Sub

    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGotamtMbil.EditValueChanged

    End Sub

    Private Sub gvMasbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvMasbill.Click
        PubMasbill = gvMasbill.GetRowCellValue(gvMasbill.FocusedRowHandle, "BillNo")
        PubMasbillTotal = Convert.ToDecimal(gvMasbill.GetRowCellValue(gvMasbill.FocusedRowHandle, "Total"))
        txtGotamtMbil.Text = PubMasbillTotal.ToString
        ChMbill.Checked = True
        txtCashnotMbill.Text = ""
        txtNarMbil.Text = ""
        txtGotamtMbil.Focus()

    End Sub

    Private Sub btUpdateMbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdateMbill.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "PaymentsVerification", "Add")

        If CheckAccess = True Then


            If gvMasbill.RowCount = 0 Then
                Exit Sub
            End If

            '--- what m donna do is... 
            ' if update clicked, remove the all the records from the reservertionroomassign and recreate

            Dim getIscheck As Integer = 0


            If ChMbill.Checked = True Then
                getIscheck = 1
            End If





            If IsUpdateMasterbills(getIscheck, Convert.ToDecimal(txtGotamtMbil.Text.Trim), txtNarMbil.Text.Trim, txtCashnotMbill.Text.Trim, PubMasbill) Then
                MsgBox("Successfully Updated", MsgBoxStyle.Information, ErrTitle)
            End If


            If PubPassMastype = 1 Then
                LoadMasterBills()
            End If

            If PubPassMastype = 2 Then
                LoadMasterBillsByRoom()
            End If


            ChMbill.Checked = False
            txtGotamtMbil.Text = ""
            txtCashnotMbill.Text = ""
            txtNarMbil.Text = ""




        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub txtGotamtCash_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGotamtCash.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.btUpdateCash.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtGotamtMbil_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGotamtMbil.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.btUpdateCash.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub XtraTabPage2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles XtraTabPage2.Paint

    End Sub

    Private Sub txtGotamtCash_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGotamtCash.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtCashnotCash.Focus()

        End If
    End Sub

    Private Sub txtCashnotCash_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCashnotCash.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtNarCash.Focus()

        End If
    End Sub

    Private Sub txtNarCash_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNarCash.KeyDown
        If e.KeyCode = Keys.Enter Then

            btUpdateCash.Focus()

        End If
    End Sub

    Private Sub txtGotamtMbil_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGotamtMbil.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtCashnotMbill.Focus()

        End If
    End Sub

    Private Sub txtCashnotMbill_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCashnotMbill.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtNarMbil.Focus()

        End If
    End Sub

    Private Sub txtCashnotMbill_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCashnotMbill.EditValueChanged

    End Sub

    Private Sub txtNarMbil_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNarMbil.KeyDown
        If e.KeyCode = Keys.Enter Then

            btUpdateMbill.Focus()

        End If
    End Sub

    Private Sub btviewStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btviewStaff.Click
        LoadMasterBillsStaff()
    End Sub
End Class