Imports System.Data.SqlClient
Public Class frmUserAssignGroup

    Private Sub frmUserAssignGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGrid()
        LoadGroupID()
        LoadUserID()

        'cmbGroupID.SelectedIndex = 0
        'cmbUserID.SelectedIndex = 0
        gvUserAssignGroup.Columns(0).Visible = False
    End Sub

    Private Sub ClearAll()
        txtUserGroupname.Text = ""
        txtUserName.Text = ""
        cmbGroup.EditValue = ""
        cmbUser.EditValue = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssign.Click
        If String.Compare(btnAssign.Text, "Assign", False) = 0 Then

            ClearAll()

            btnAssign.Text = "Save"

            btnDelete.Enabled = False
            tabUserAssignGroup.SelectedTabPageIndex = 1

        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                Exit Sub

            Else

                Dim dscheckAddbefore As New DataSet
                dscheckAddbefore = DSCheckInsertUserAssignGroupTemp()

                If dscheckAddbefore Is Nothing Then

                    'Dim bt As DialogResult = MessageBox.Show("Do You Want To Assign User To This Group ", "Assign User", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    'If bt = Windows.Forms.DialogResult.Yes Then
                    If Not InsertUserAssignGroup() Then
                        Exit Sub

                    End If
                    'MessageBox.Show(" Details Saved Successfully", "Save Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'End If
                    LoadGrid()

                    btnAssign.Text = "Assign"

                    btnDelete.Enabled = True
                    tabUserAssignGroup.SelectedTabPageIndex = 0

                Else
                    MessageBox.Show("Record already Assign", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                End If

            End If

            

        End If

    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(cmbUser.GetColumnValue("Userid"), "", False) = 0 Or String.Compare(cmbGroup.GetColumnValue("Name"), "", False) = 0, 0, 1)

    End Function
    Private Function InsertUserAssignGroup() As Boolean

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()

        Try
            dcInsertNewAcc = New SqlCommand("InsertUserAssigngroups_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Id", SqlDbType.VarChar).Value = autoid.ToString()
            dcInsertNewAcc.Parameters.Add("@GroupId", SqlDbType.VarChar).Value = cmbGroup.GetColumnValue("Name")
            dcInsertNewAcc.Parameters.Add("@UserId", SqlDbType.VarChar).Value = cmbUser.GetColumnValue("Username")

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
    Function DSCheckInsertUserAssignGroupTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim GroupId As String = cmbGroup.GetColumnValue("Name")

            dcSearch = New SqlCommand("select * from dbo.[Admin.UserAssignGroup] where GroupId=@GroupId", Conn)
            dcSearch.Parameters.Add("@GroupId", SqlDbType.VarChar).Value = GroupId

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertUserAssignGroupTemp = dsMain
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


            dcSearch = New SqlCommand("select Id,GroupId,UserId from dbo.[Admin.UserAssignGroup]", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcUserAssignGroup.DataSource = dsMain.Tables(0)


            
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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Admin.UserAssignGroup] where GroupId= '{0}'", gvUserAssignGroup.GetRowCellValue(gvUserAssignGroup.FocusedRowHandle, "GroupId")), Conn)
            daShow.Fill(dsShow)




            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabUserAssignGroup.SelectedTabPageIndex = 1

            cmbGroup.EditValue = dsShow.Tables(0).Rows(0).Item("groupid")
            cmbUser.EditValue = dsShow.Tables(0).Rows(0).Item("userid")
            'cmbGroupID.Text = dsShow.Tables(0).Rows(0).Item("GroupId")
            ' txtUserGroupname.Text = dsShow.Tables(0).Rows(0).Item("Username")
            gvUserAssignGroup.Columns(0).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Private Sub gvUserAssignGroup_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvUserAssignGroup.DoubleClick
        ShowGridDets()
    End Sub
    Private Function DeleteUserAssignGroup() As Boolean


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Try

            dcInsertNewAcc = New SqlCommand("DeleteUserAssignGroup_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@Username ", SqlDbType.VarChar).Value = cmbUser.GetColumnValue("Username")

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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This User Assign Group Details", "Inactive  User Assign Group Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                If DeleteUserAssignGroup() Then
                    MessageBox.Show(" User Assign Group Details Removed Successfully", "Inactive  User Assign Group Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadGrid()
                    tabUserAssignGroup.SelectedTabPageIndex = 0
                    ' Exit Sub

                End If
  
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        End Try

    End Sub
    Private Sub LoadGroupID()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Name,Description from [Admin.Usergroups] order by Id", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim datRow As DataRow = dsMain.Tables(0).NewRow

            datRow(0) = ""
            datRow(1) = ""

            dsMain.Tables(0).Rows.Add(datRow)

            With cmbGroup
                .Properties.DataSource = dsMain.Tables(0)
                .Properties.DisplayMember = "Name"
                .Properties.ValueMember = "Name"
                .Properties.PopupWidth = 400

            End With

            'While (DscountTest < Dscount)

            '    cmbGroupID.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
            '    DscountTest = DscountTest + 1

            'End While

            'cmbGroupID.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadGroupName(ByVal gid As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Passgid As String = gid

            dcSearch = New SqlCommand("select Name from [Admin.Usergroups] where  Id=@Passgid", Conn)
            dcSearch.Parameters.Add("@PASSGID", SqlDbType.VarChar).Value = Passgid

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            txtUserGroupname.Text = dsMain.Tables(0).Rows(0)(0).ToString()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub cmbGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroup.EditValueChanged
        'LoadGroupName(cmbGroupID.Text)
        txtUserGroupname.Text = cmbGroup.GetColumnValue("Description")
    End Sub
    Private Sub LoadUserID()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Username,Fullname from [Admin.UsersSys] order by UserId", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            With cmbUser.Properties
                .DataSource = dsMain.Tables(0)
                .DisplayMember = "Username"
                .ValueMember = "Username"
                .PopupWidth = 400
            End With


            Dim datRow As DataRow = dsMain.Tables(0).NewRow

            datRow(0) = ""
            datRow(1) = ""

            dsMain.Tables(0).Rows.Add(datRow)

            'Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            'Dim DscountTest As Integer

            'While (DscountTest < Dscount)

            '    cmbUserID.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
            '    DscountTest = DscountTest + 1

            'End While

            'cmbUserID.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub LoadUserName(ByVal uid As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Passuid As String = uid

            dcSearch = New SqlCommand("select Username from [Admin.UsersSys] where  UserId=@Passuid", Conn)
            dcSearch.Parameters.Add("@PASSUID", SqlDbType.VarChar).Value = Passuid

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            txtUserName.Text = dsMain.Tables(0).Rows(0)(0).ToString()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    

    Private Sub cmbUser_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbUser.EditValueChanged
        txtUserName.Text = cmbUser.GetColumnValue("Fullname")
    End Sub
End Class