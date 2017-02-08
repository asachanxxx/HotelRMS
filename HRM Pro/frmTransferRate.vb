Imports System.Data.SqlClient
Imports System.Xml
Public Class frmTransferRate
    Public PubTransd As String = ""
    Private Sub frmTransferRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        Cmbguestype.SelectedIndex = 0
        cmbResType.SelectedIndex = 0
        CmbShift.SelectedIndex = 0
        LoadGrid()
    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            dcSearch = New SqlCommand("select * from dbo.[Boat.Transferrates] where TopcontractId=' ' order by Custype,Guesttype,Shift", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            If dsMain.Tables(0).Rows.Count > 0 Then
                gcTransfer.DataSource = dsMain.Tables(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub InsertTransRates()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InsertTransRate_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

        Dim getCusType As String = ""
        Dim getCusId As String = ""

        If cmbResType.Text = "FIT" Then
            getCusType = "FIT"
            getCusId = "FIT Customer"
        End If

        If cmbResType.Text = "COM" Then
            getCusType = "COM"
            getCusId = "COM Customer"
        End If

        If cmbResType.Text = "TOP" Then
            getCusType = "TOP"
            getCusId = "TOP Customer"
        End If

        Dim Ratesautoid As String = System.Guid.NewGuid().ToString()

        dcInsertNewAcc.Parameters.Add("@TransferrateId", SqlDbType.VarChar).Value = Ratesautoid
        dcInsertNewAcc.Parameters.Add("@Custype", SqlDbType.VarChar).Value = getCusType
        dcInsertNewAcc.Parameters.Add("@CusId", SqlDbType.VarChar).Value = getCusId
        dcInsertNewAcc.Parameters.Add("@TransTopContracid", SqlDbType.VarChar).Value = ""
        dcInsertNewAcc.Parameters.Add("@TopcontractId", SqlDbType.VarChar).Value = ""
        dcInsertNewAcc.Parameters.Add("@Guesttype", SqlDbType.VarChar).Value = Cmbguestype.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Shift", SqlDbType.VarChar).Value = CmbShift.Text
        dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtrate.Text.Trim)
        dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = "Rashad"
        

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Transfer Rate Saved Successfully", "Save Transfer Rates", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Boat Rates", "Add")

        If CheckAccess = True Then


            If String.Compare(btnAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btnAdd.Text = "Save"
                btnEdit.Enabled = False

                tabTransrate.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                Else

                    Try

                        Dim dscheckAddbefore As New DataSet
                        dscheckAddbefore = DSCheckInsertTransRates()

                        If dscheckAddbefore Is Nothing Then

                            Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Transfer Rate", "Save Transfer Rates", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If bt = Windows.Forms.DialogResult.Yes Then

                                InsertTransRates()


                            End If
                            LoadGrid()

                            btnAdd.Text = "Add"
                            btnEdit.Enabled = True
                            tabTransrate.SelectedTabPageIndex = 0
                            Exit Sub

                        Else
                            MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
                    End Try
                End If
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Function DSCheckInsertTransRates() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim getRestype As String = cmbResType.Text.Trim
            Dim getGuesttype As String = Cmbguestype.Text
            Dim getShift As String = CmbShift.Text

            dcSearch = New SqlCommand("select * from dbo.[Boat.Transferrates] where Custype=@Custype and Guesttype=@Guesttype and Shift=@Shift", Conn)
            dcSearch.Parameters.Add("@Custype", SqlDbType.VarChar).Value = getRestype
            dcSearch.Parameters.Add("@Guesttype", SqlDbType.VarChar).Value = getGuesttype
            dcSearch.Parameters.Add("@Shift", SqlDbType.VarChar).Value = getShift
     

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertTransRates = dsMain
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

        txtrate.Text = ""

    End Sub

    Private Sub txtrate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrate.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.btnAdd.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub
    Function FieldValidation() As Boolean
        Return IIf(String.Compare(txtrate.Text, "", False) = 0, 0, 1)
    End Function
    Private Sub UpdateTransRate()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("UpdateTransferRate_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@TransferrateId", SqlDbType.VarChar).Value = PubTransd
        dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = txtrate.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Transfer Rate Updated Successfully", "Update Transfer Rate", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()
    End Sub
    Private Sub ShowGridDets()
        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Boat.Transferrates]  where TransferrateId= '{0}' ", gviewTransrate.GetRowCellValue(gviewTransrate.FocusedRowHandle, "TransferrateId")), Conn)
            daShow.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabTransrate.SelectedTabPageIndex = 1

            PubTransd = dsShow.Tables(0).Rows(0).Item("TransferrateId")
            cmbResType.Text = dsShow.Tables(0).Rows(0).Item("Custype")
            cmbResType.ClosePopup()
            Cmbguestype.Text = dsShow.Tables(0).Rows(0).Item("Guesttype")
            Cmbguestype.ClosePopup()
            CmbShift.Text = dsShow.Tables(0).Rows(0).Item("Shift")
            CmbShift.ClosePopup()

            txtrate.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("Rate"))
            'txtrate.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub gviewTransrate_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gviewTransrate.DoubleClick
        ShowGridDets()
        Cmbguestype.Enabled = False
        cmbResType.Enabled = False
        CmbShift.Enabled = False
        btnAdd.Enabled = False
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Boat Rates", "Edit")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Transfer Rate", "Update Transfer Rate", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    UpdateTransRate()


                End If
                LoadGrid()
                tabTransrate.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub frmTransferRate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class