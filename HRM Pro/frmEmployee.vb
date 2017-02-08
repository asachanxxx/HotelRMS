Imports System.Data.SqlClient
Public Class frmEmployee

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Employee Master", "Add")

        If CheckAccess = True Then


            If String.Compare(btnAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btnAdd.Text = "Save"
                btnEdit.Enabled = False

                tabBoat.TabPages(1).PageEnabled = True
                tabBoat.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                    Exit Sub

                Else


                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Emp Details", "Save Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If bt = Windows.Forms.DialogResult.Yes Then
                        InsertEmp()

                        End If

                    LoadGrid()

                    btnAdd.Text = "Add"
                    btnEdit.Enabled = True

                    tabBoat.TabPages(1).PageEnabled = False
                    tabBoat.SelectedTabPageIndex = 0
                    Exit Sub
                End If
            End If



        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Sub ClearFields()

        txtEmpNo.Text = ""
        txtEmpName.Text = ""
        cmbdep.SelectedIndex = 0
        cmbCategory.SelectedIndex = 0

    End Sub


    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtEmpNo.Text, "", False) = 0 Or String.Compare(txtEmpName.Text, "", False) = 0 Or String.Compare(cmbCategory.Text, "", False) = 0 Or String.Compare(cmbdep.Text, "", False) = 0, 0, 1)

    End Function
    Private Sub LoadGrid()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()


            dcSearch = New SqlCommand("select EmpId,Empno,EmpName,Dep,Category from dbo.[Emp] where status='OPEN'", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcBoat.DataSource = dsMain.Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        Finally

            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()

        End Try

    End Sub

    Private Sub InsertEmp()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        Dim CurrentUser As String = CurrUser

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("InsertEmp_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure


        dcInsertNewAcc.Parameters.Add("@Empno", SqlDbType.VarChar).Value = txtEmpNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EmpName", SqlDbType.VarChar).Value = txtEmpName.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Dep", SqlDbType.VarChar).Value = cmbdep.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Category", SqlDbType.VarChar).Value = cmbCategory.Text.Trim
        dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = CurrUser


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Employee Details Saved Successfully", "Save Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Employee Master", "Edit")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactivate This Employee", "Inactive Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveEmp(empid.Text)


                End If
                LoadGrid()
                tabBoat.TabPages(1).PageEnabled = False
                tabBoat.SelectedTabPageIndex = 0

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub InactiveEmp(ByVal passEmpId As Integer)

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        dcInsertNewAcc = New SqlCommand("InactiveEmp_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@EmpId", SqlDbType.Int).Value = passEmpId
        dcInsertNewAcc.Parameters.Add("@InactiveUser", SqlDbType.VarChar).Value = CurrUser


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Employee Inactivated Successfully", "Inactive Employees", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub

    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGrid()

        tabBoat.TabPages(1).PageEnabled = False


    End Sub
    Private Sub ShowGridDets()

        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select EmpId,Empno,EmpName,Dep,Category from dbo.[Emp] where Status='OPEN' and EmpId= '{0}'", gvBoat.GetRowCellValue(gvBoat.FocusedRowHandle, "EmpId")), Conn)
            daShow.Fill(dsShow)



            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If
            tabBoat.TabPages(1).PageEnabled = True
            tabBoat.SelectedTabPageIndex = 1


            empid.Text = dsShow.Tables(0).Rows(0).Item("EmpId")
            txtEmpNo.Text = dsShow.Tables(0).Rows(0).Item("Empno")
            txtEmpName.Text = dsShow.Tables(0).Rows(0).Item("EmpName")
            cmbdep.Text = dsShow.Tables(0).Rows(0).Item("Dep")
            cmbdep.ClosePopup()
            cmbCategory.Text = dsShow.Tables(0).Rows(0).Item("Category")
            cmbCategory.ClosePopup()


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        Finally

            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()

        End Try

    End Sub

    Private Sub gvBoat_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvBoat.DoubleClick
        ShowGridDets()
    End Sub

    Private Sub txtEmpNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmpNo.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtEmpName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmpName.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
End Class