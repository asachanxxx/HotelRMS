Imports System.Data.SqlClient

Public Class frmPasswordChange

    Private Sub frmPasswordChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        txtUName.Text = CurrUser
        'txtNewpass.Properties.ReadOnly = True
        'txtNewpassRe.Properties.ReadOnly = True
        btnAdd.Enabled = False



    End Sub
    Function DSCheckInsertUserTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Username As String = CurrUser

            dcSearch = New SqlCommand("select * from dbo.[Admin.UsersSys] where Username=@Username", Conn)
            dcSearch.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertUserTemp = dsMain
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function

    Private Sub txCurrpass_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txCurrpass.Leave

        Dim dscheckAddbefore As New DataSet
        dscheckAddbefore = DSCheckInsertUserTemp()

        If dscheckAddbefore Is Nothing Then
            Exit Sub

        Else

            Dim Typepass As String = ""

            If (Not IsDBNull(dscheckAddbefore.Tables(0).Rows(0).Item("Password"))) Then

                Typepass = dscheckAddbefore.Tables(0).Rows(0).Item("Password")

                If txCurrpass.Text.Trim = Typepass Then

                    txtNewpass.Enabled = True

                    txtNewpassRe.Enabled = True


                    btnAdd.Enabled = True



                Else

                    MessageBox.Show("Entered Password Is Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    txtNewpass.Enabled = False

                    txtNewpassRe.Enabled = False

                End If

            Else
                Typepass = ""


            End If

        End If


    End Sub

    Private Sub txtNewpassRe_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewpassRe.Leave
        'If txtNewpass.Text.Trim = txtNewpassRe.Text.Trim Then
        '    btnAdd.Enabled = True
        '    btnAdd.Focus()

        'Else

        '    MessageBox.Show("Re Type the Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        'End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtNewpass.Text.Trim = txtNewpassRe.Text.Trim Then
            btnAdd.Enabled = True
            btnAdd.Focus()
            EditUserPass()

        Else

            MessageBox.Show("Re Type the Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If




    End Sub

    Private Function EditUserPass() As Boolean

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()

        Try

            dcInsertNewAcc = New SqlCommand("UpdateUserPass_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure



            dcInsertNewAcc.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUName.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtNewpassRe.Text.Trim
           


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Password  Updated Successfully. Please Re-Login to the System", "UpdatePassword", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcInsertNewAcc.Dispose()

        End Try




        Conn.Close()

    End Function

    Private Sub txtNewpassRe_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewpassRe.EditValueChanged

    End Sub

    Private Sub txCurrpass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txCurrpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txCurrpass.Text <> "" Then
                Dim dscheckAddbefore As New DataSet
                dscheckAddbefore = DSCheckInsertUserTemp()

                If dscheckAddbefore Is Nothing Then
                    Exit Sub

                Else

                    Dim Typepass As String = ""

                    If (Not IsDBNull(dscheckAddbefore.Tables(0).Rows(0).Item("Password"))) Then

                        Typepass = dscheckAddbefore.Tables(0).Rows(0).Item("Password")

                        If txCurrpass.Text.Trim = Typepass Then

                            txtNewpass.Enabled = True

                            txtNewpassRe.Enabled = True


                            btnAdd.Enabled = True

                            txtNewpass.Focus()

                        Else

                            MessageBox.Show("Entered Password Is Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            txtNewpass.Enabled = False

                            txtNewpassRe.Enabled = False

                        End If

                    Else
                        Typepass = ""


                    End If

                End If












            End If
        End If
    End Sub

    Private Sub txtNewpass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNewpass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtNewpass.Text <> "" Then
                txtNewpassRe.Focus()
            End If
        End If
    End Sub

    Private Sub txtNewpassRe_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNewpassRe.KeyDown


        If e.KeyCode = Keys.Enter Then
            If txtNewpassRe.Text <> "" Then
                btnAdd.Focus()
            End If
        End If




    End Sub
End Class