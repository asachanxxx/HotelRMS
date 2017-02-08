Imports System.Data.SqlClient
Public Class frmUserGroups

    Private Sub frmUserGroups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadGrid()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If String.Compare(btnAdd.Text, "Add", False) = 0 Then

            ClearFields()
            btnAdd.Text = "Save"
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            tabUserGroup.SelectedTabPageIndex = 1

            chkStatus.Properties.ReadOnly = False
        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                Exit Sub

            Else

                Dim dscheckAddbefore As New DataSet
                dscheckAddbefore = DSCheckInsertUserGroupTemp()

                If dscheckAddbefore Is Nothing Then

                    'Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This User Group Details", "Save  User Group Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    'If bt = Windows.Forms.DialogResult.Yes Then
                    'InsertUserGroup()
                    'MessageBox.Show("User Group Details Saved Successfully", "Save User Group Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'End If

                    If Not InsertUserGroup() Then
                        Exit Sub
                    End If

                    LoadGrid()

                    btnAdd.Text = "Add"
                    btnEdit.Enabled = True
                    btnDelete.Enabled = True
                    tabUserGroup.SelectedTabPageIndex = 0

                    chkStatus.Properties.ReadOnly = True
                Else
                    MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If

            End If


            ' Exit Sub

        End If


    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtUserGroupname.Text, "", False) = 0 Or String.Compare(MemoDes.Text, "", False) = 0, 0, 1)

    End Function
    Sub ClearFields()

        txtUserGroupname.Text = ""
        MemoDes.Text = ""
        txtCreateBy.Text = CurrUser
        dtCreateDate.DateTime = Now.Date

        txtUserGroupname.Properties.ReadOnly = False
    End Sub
    Private Function InsertUserGroup() As Boolean

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()



        Try
            dcInsertNewAcc = New SqlCommand("InsertUsergroups_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtUserGroupname.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Description", SqlDbType.VarChar).Value = MemoDes.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.Bit).Value = 1
            dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = txtCreateBy.Text
            dcInsertNewAcc.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = dtCreateDate.DateTime


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcInsertNewAcc.Dispose()
        End Try


    End Function
    Function DSCheckInsertUserGroupTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Name As String = txtUserGroupname.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[Admin.Usergroups] where Name=@Name", Conn)
            dcSearch.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertUserGroupTemp = dsMain
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
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


            dcSearch = New SqlCommand("select Id,Name,Description from dbo.[Admin.Usergroups]", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcUserGroup.DataSource = dsMain.Tables(0)

            gcUserGroup.Width = 440
            gvUserGroup.Columns(0).Width = 50
            gvUserGroup.Columns(1).Width = 175
            gvUserGroup.Columns(2).Width = 200

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Admin.Usergroups] where Name= '{0}'", gvUserGroup.GetRowCellValue(gvUserGroup.FocusedRowHandle, "Name")), Conn)
            daShow.Fill(dsShow)




            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabUserGroup.SelectedTabPageIndex = 1

            txtUserGroupname.Text = dsShow.Tables(0).Rows(0).Item("Name")
            MemoDes.Text = dsShow.Tables(0).Rows(0).Item("Description")
            txtCreateBy.Text = dsShow.Tables(0).Rows(0).Item("createdby")
            dtCreateDate.DateTime = dsShow.Tables(0).Rows(0).Item("createddate")
            chkStatus.Checked = dsShow.Tables(0).Rows(0).Item("status")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Private Sub gvUserGroup_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvUserGroup.DoubleClick
        ShowGridDets()
        txtUserGroupname.Properties.ReadOnly = True
    End Sub
    Private Sub DeleteUserGroup()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveUserGroup_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtUserGroupname.Text.Trim


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click


        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This User Group Details", "Inactive User Group Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                DeleteUserGroup()
                MessageBox.Show("User Group Details Inactivated Successfully", "Inactive User Group Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            LoadGrid()
            tabUserGroup.SelectedTabPageIndex = 0
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        End Try
    End Sub
    Private Function EditUserGroup() As Boolean

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()

        Try

            dcInsertNewAcc = New SqlCommand("UpdateUserGroup_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtUserGroupname.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Description", SqlDbType.VarChar).Value = MemoDes.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = txtCreateBy.Text
            dcInsertNewAcc.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = dtCreateDate.DateTime

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()

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

            'Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This User Group Details", "Update User Group Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'If bt = Windows.Forms.DialogResult.Yes Then

            If Not FieldValidation() Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub
            End If

            If EditUserGroup() Then

                LoadGrid()
                tabUserGroup.SelectedTabPageIndex = 0
                MessageBox.Show("User Group Details Updated Successfully", "Update User Group Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
            'EditUserGroup()
            ' End If


            'Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)

        End Try
    End Sub
End Class