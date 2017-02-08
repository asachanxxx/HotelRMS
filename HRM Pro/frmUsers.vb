Imports System.Data.SqlClient
Imports System.Xml
Public Class frmUsers

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadGrid()
        dtDate.DateTime = Now.Date
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If String.Compare(btnAdd.Text, "Add", False) = 0 Then


            ClearFields()
            btnAdd.Text = "Save"
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            tabUsersDetails.TabPages(1).PageEnabled = True
            tabUsersDetails.SelectedTabPageIndex = 1


        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                Exit Sub


            Else

                Dim dscheckAddbefore As New DataSet
                dscheckAddbefore = DSCheckInsertUserTemp()

                If dscheckAddbefore Is Nothing Then

                    'Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This User Details", "Save User Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    ' If bt = Windows.Forms.DialogResult.Yes Then
                    If Not InsertUser() Then
                        Exit Sub
                    End If

                    LoadGrid()

                    btnAdd.Text = "Add"
                    btnEdit.Enabled = True

                    tabUsersDetails.TabPages(1).PageEnabled = False
                    tabUsersDetails.SelectedTabPageIndex = 0





                    'Exit Sub

                Else
                    MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End If

            

            End If
        End If
    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtUName.Text, "", False) = 0 Or String.Compare(txtUpw.Text, "", False) = 0, 0, 1)

    End Function
    Sub ClearFields()

        txtUName.Text = ""
        txtUpw.Text = ""
        txtCreatedBy.Text = CurrUser
        txtFullName.Text = ""

    End Sub
    Private Function InsertUser() As Boolean

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()

        Try
            dcInsertNewAcc = New SqlCommand("InsertUser_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@UserId", SqlDbType.VarChar).Value = autoid.ToString()
            dcInsertNewAcc.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUName.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtUpw.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.Bit).Value = 1 'chkStatus.Checked
            dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = txtCreatedBy.Text
            dcInsertNewAcc.Parameters.Add("@fullname", SqlDbType.VarChar).Value = txtFullName.Text
            dcInsertNewAcc.Parameters.Add("@CreateDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date




            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("User Details Added Successfully", "Add User Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Function DSCheckInsertUserTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Username As String = txtUName.Text.Trim

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
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select Username as [User Name],fullname as [Full Name] from dbo.[Admin.UsersSys] where Status='1'", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcUser.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
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
            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Admin.UsersSys] where Username= '{0}'", gvUser.GetRowCellValue(gvUser.FocusedRowHandle, "User Name")), Conn)
            daShow.Fill(dsShow)



            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If


            tabUsersDetails.TabPages(1).PageEnabled = True
            tabUsersDetails.SelectedTabPageIndex = 1

            txtUName.Text = dsShow.Tables(0).Rows(0).Item("Username")
            txtUpw.Text = dsShow.Tables(0).Rows(0).Item("Password")
            txtFullName.Text = dsShow.Tables(0).Rows(0).Item("fullname")
            txtCreatedBy.Text = dsShow.Tables(0).Rows(0).Item("createby")
            dtDate.Text = dsShow.Tables(0).Rows(0).Item("createddate")
            chkStatus.Checked = dsShow.Tables(0).Rows(0).Item("status")


            btnEdit.Text = "Update"

            txtUName.Enabled = False
            txtFullName.Enabled = False
            txtCreatedBy.Enabled = False
            dtDate.Enabled = False
            chkStatus.Enabled = False



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub InactiveUser()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveUser_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUName.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Function EditUser() As Boolean

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()

        Try

            dcInsertNewAcc = New SqlCommand("UpdateUser_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure


            'dcInsertNewAcc.Parameters.Add("@UserId", SqlDbType.VarChar).Value = autoid.ToString()
            dcInsertNewAcc.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUName.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtUpw.Text.Trim
            'dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.Bit).Value = chkStatus.Checked
            'dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = txtCreatedBy.Text
            'dcInsertNewAcc.Parameters.Add("@fullname", SqlDbType.VarChar).Value = txtFullName.Text
            'dcInsertNewAcc.Parameters.Add("@CreateDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date



            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("User Details Updated Successfully", "Update User Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Try

           
            If String.Compare(btnEdit.Text, "Edit", False) = 0 Then

              
                btnAdd.Enabled = False

                btnEdit.Text = "Update"
                'btnEdit.Enabled = False
                btnDelete.Enabled = False
                tabUsersDetails.TabPages(1).PageEnabled = True
                tabUsersDetails.SelectedTabPageIndex = 1




                'txtUName.Properties.ReadOnly = True
            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                    Exit Sub


                Else


                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This User Details", "Update User Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then

                        If Not EditUser() Then
                            Exit Sub
                        End If

                    End If



                    LoadGrid()

                    btnAdd.Enabled = True
                    btnEdit.Text = "Edit"
                    btnEdit.Enabled = True
                    btnDelete.Enabled = True
                    tabUsersDetails.TabPages(1).PageEnabled = False
                    tabUsersDetails.SelectedTabPageIndex = 0

                    txtUName.Enabled = True
                    txtFullName.Enabled = True
                    txtCreatedBy.Enabled = True
                    dtDate.Enabled = True
                    chkStatus.Enabled = True



                    End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This User Details", "Inactive User Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                InactiveUser()
                MessageBox.Show("User Details Inactivated Successfully", "Inactive User Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            LoadGrid()
            tabUsersDetails.SelectedTabPageIndex = 0
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        End Try
    End Sub

    Private Sub gvUser_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvUser.DoubleClick
        ShowGridDets()

    End Sub
End Class