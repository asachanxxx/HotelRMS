
Imports System.Data.SqlClient
Public Class frmUserGroupAssignProcess
    Public PubId As Integer = 0
    Public PubSysFId As Integer = 0
    Public pubGroupId As String = 0

    Private Sub frmUserGroupAssignProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGrid()
        LoadGroupID()
        LoadFunctionName()


        'cmbGID.SelectedIndex = 0
        'cmbFunctionName.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If String.Compare(btnAdd.Text, "Add", False) = 0 Then


            btnAdd.Text = "Save"
            btnDelete.Enabled = False
            tabUserGroupAssignProcess.SelectedTabPageIndex = 1

        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                Exit Sub


            Else

                Dim dscheckAddbefore As New DataSet
                dscheckAddbefore = DSCheckInsertUserGroupAssignProcessTemp()

                If dscheckAddbefore Is Nothing Then

                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This User Group Assign Process Details", "Save User Group Assign Process Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then

                        'InsertUsergroupAssignProcessTemp()
                        InsertUserGroupAssignProcess()
                        MessageBox.Show("User Group Assign Process Details Saved Successfully", "Save User Group Assign Process Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If


                Else
                    MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                End If

                LoadGrid()

                btnAdd.Text = "Add"
                btnDelete.Enabled = True
                tabUserGroupAssignProcess.SelectedTabPageIndex = 0
                Exit Sub

            End If
        End If
    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(cmbGID.Text, "", False) = 0 Or String.Compare(cmbFunctionName.Text, "", False) = 0 Or String.Compare(cmbProcess.Text, "", False) = 0, 0, 1)

    End Function

    Private Sub InsertUserGroupAssignProcess()


        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Dim GroupId As String = PubGroupId

        'Dim TransTopContractId As String = PubTransTopContractId




        dcSearch = New SqlCommand("select * from dbo.[Admin.UsergroupAssignProcess] where GroupId=@GroupId", Conn)
        dcSearch.Parameters.Add("@GroupId", SqlDbType.Int).Value = GroupId
        Conn.Open()
        daMain = New SqlDataAdapter()
        daMain.SelectCommand = dcSearch
        daMain.Fill(dsMain)
        Conn.Close()


        Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1


        While DScount >= 0

            Dim autoid As String = System.Guid.NewGuid().ToString()

            dcInsertNewAcc = New SqlCommand("InsertUsergroupsAssignProcess_SP", Conn)


            dcInsertNewAcc.Parameters.Add("@Id", SqlDbType.Int).Value = autoid.ToString()
            dcInsertNewAcc.Parameters.Add("@GroupId", SqlDbType.Int).Value = Convert.ToInt16(cmbGID.Text.Trim())
            dcInsertNewAcc.Parameters.Add("@SystemfunctionsId", SqlDbType.Int).Value = PubSysFId

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
            DScount = DScount - 1
        End While
    End Sub
    Function DSCheckInsertUserGroupAssignProcessTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim GroupId As String = cmbGID.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[Admin.UsergroupAssignProcess] where GroupId=@GroupId", Conn)
            dcSearch.Parameters.Add("@GroupId", SqlDbType.Int).Value = GroupId

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertUserGroupAssignProcessTemp = dsMain
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
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select Id,GroupId,SystemfunctionsId from dbo.[Admin.UsergroupAssignProcess]", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcUserGroupAssignProcess.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Admin.UsergroupAssignProcess] where Id= '{0}'", gvUserGroupAssignProcess.GetRowCellValue(gvUserGroupAssignProcess.FocusedRowHandle, "Id")), Conn)
            daShow.Fill(dsShow)




            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabUserGroupAssignProcess.SelectedTabPageIndex = 1


            cmbGID.Text = dsShow.Tables(0).Rows(0).Item("GroupId")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Private Sub gvUserGroupAssignProcess_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvUserGroupAssignProcess.DoubleClick
        ShowGridDets()

    End Sub
    Private Sub LoadGroupID()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Id from [Admin.Usergroups] order by Id", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbGID.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbGID.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
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

            dcSearch = New SqlCommand("select  Name from [Admin.Usergroups] where  Id=@Passgid", Conn)
            dcSearch.Parameters.Add("@PASSGID", SqlDbType.Int).Value = Passgid

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            txtGroupName.Text = dsMain.Tables(0).Rows(0)(0).ToString()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub cmbGID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGID.SelectedIndexChanged
        LoadGroupName(cmbGID.Text)
    End Sub
    Private Sub LoadProcess(ByVal fname As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Passfname As String = fname

            dcSearch = New SqlCommand("select Process from [Admin.Systemfunctions] where  FunctionName=@Passfname", Conn)
            dcSearch.Parameters.Add("@PASSFNAME", SqlDbType.VarChar).Value = Passfname

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            cmbProcess.Text = dsMain.Tables(0).Rows(0)(0).ToString()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadFunctionName()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Distinct FunctionName from [Admin.Systemfunctions] order by FunctionName", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbFunctionName.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbFunctionName.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub cmbFunctionName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFunctionName.SelectedIndexChanged
        LoadProcess(cmbFunctionName.Text)
    End Sub
    Private Sub DeleteUserGroupAssignProcess()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("DeleteUserGroupAssignProcess_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@GroupId", SqlDbType.Int).Value = cmbGID.Text.Trim


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This User Group Assign Process Details", "Inactive User Group Assign Process Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                DeleteUserGroupAssignProcess()
                MessageBox.Show("User Group Assign Process Details Inactivated Successfully", "Inactive User Group Assign Process Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            LoadGrid()
            tabUserGroupAssignProcess.SelectedTabPageIndex = 0
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub

    Private Sub btnAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssign.Click
        InsertUsergroupAssignProcessTemp()
        LoadUsergroupAssignProcessTemp()
    End Sub

    Private Sub InsertUsergroupAssignProcessTemp()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand



        dcInsertNewAcc = New SqlCommand("InsertUsergroupAssignProcessTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}


        dcInsertNewAcc.Parameters.Add("@GroupId", SqlDbType.Int).Value = cmbGID.Text.Trim
        dcInsertNewAcc.Parameters.Add("@GroupName", SqlDbType.VarChar).Value = txtGroupName.Text.Trim
        dcInsertNewAcc.Parameters.Add("@FunctionName", SqlDbType.VarChar).Value = cmbFunctionName.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Process", SqlDbType.VarChar).Value = cmbProcess.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = "Thilini"

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Sub LoadUsergroupAssignProcessTemp()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()


            dcSearch = New SqlCommand("select GroupName,FunctionName,Process from dbo.[UsergroupAssignProcess.Temp] where  GroupName=@GroupName and CreatedBy=@user", Conn)
            dcSearch.Parameters.Add("@GroupName", SqlDbType.VarChar).Value = txtGroupName.Text.Trim
            dcSearch.Parameters.Add("@user", SqlDbType.VarChar).Value = "Thilini"

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcUserGroupAssignProcessTemp.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
End Class