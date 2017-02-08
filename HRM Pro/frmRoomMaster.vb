Imports System.Data.SqlClient

Public Class frmRoomMaster
    Private Sub frmRoomMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        cmbCategory.SelectedIndex = 0
        cmbStatus.SelectedIndex = 0
        LoadGrid()
    End Sub
    Private Sub InsertRoomMaster()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()

        dcInsertNewAcc = New SqlCommand("InsertRoomMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@Roomno", SqlDbType.Int).Value = Convert.ToInt32(txtRoomno.Text.Trim)
        dcInsertNewAcc.Parameters.Add("@Category", SqlDbType.VarChar).Value = cmbCategory.Text.Trim
        dcInsertNewAcc.Parameters.Add("@status", SqlDbType.VarChar).Value = cmbStatus.Text.Trim
        dcInsertNewAcc.Parameters.Add("@createdby", SqlDbType.VarChar).Value = CurrUser


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Room Details Saved Successfully", "Save Room", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Function DSCheckInsertRoomMaster() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Roomno As Integer = Convert.ToInt32(txtRoomno.Text.Trim)


            dcSearch = New SqlCommand("select * from dbo.[Rooms.Master] where Roomno=@Roomno", Conn)
            dcSearch.Parameters.Add("@Roomno", SqlDbType.VarChar).Value = Roomno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertRoomMaster = dsMain
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
            dcSearch = New SqlCommand("select Roomno,Category,Status from dbo.[Rooms.Master] where IsInactive=0 order by Roomno,Category,Status", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcRoomMaster.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadGridInactive()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Roomno,Category,Status from dbo.[Rooms.Master] where IsInactive=1 order by Roomno,Category,Status", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcRoomMaster.DataSource = dsMain.Tables(0)

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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Rooms.Master]  where Roomno= '{0}' ", gvRoomMaster.GetRowCellValue(gvRoomMaster.FocusedRowHandle, "Roomno")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabRooms.SelectedTabPageIndex = 1

            txtRoomno.Text = dsShow.Tables(0).Rows(0).Item("Roomno")

            cmbCategory.Text = dsShow.Tables(0).Rows(0).Item("Category")
            cmbCategory.ClosePopup()




            cmbStatus.Text = dsShow.Tables(0).Rows(0).Item("Status")
            cmbStatus.ClosePopup()

            If cmbStatus.Text = "occupied" Then
                cmbStatus.Enabled = False

            Else
                cmbStatus.Enabled = True
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room Master", "Add")

        Dim CheckAccess2 As Boolean = UserPermission(CurrUser, "RoomStatus", "Add")


        Dim CheckAccess3 As Boolean = UserPermission(CurrUser, "Housekeeping", "Add")


        If CheckAccess = True Or CheckAccess2 = True Or CheckAccess3 = True Then


            If String.Compare(btnAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btnAdd.Text = "Save"
                btnEdit.Enabled = False
                'btnInactive.Enabled = False
                tabRooms.SelectedTabPageIndex = 1

            Else


                Dim dscheckAddbefore As New DataSet
                dscheckAddbefore = DSCheckInsertRoomMaster()

                If dscheckAddbefore Is Nothing Then
                    InsertRoomMaster()

                Else
                    MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                End If

                LoadGrid()

                btnAdd.Text = "Add"
                btnEdit.Enabled = True
                'btnInactive.Enabled = True
                tabRooms.SelectedTabPageIndex = 0
                Exit Sub
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Sub ClearFields()

        txtRoomno.Text = ""

    End Sub
    Function FieldValidation() As Boolean
        Return IIf(String.Compare(txtRoomno.Text, "", False) = 0, 0, 1)
    End Function

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room Master", "Edit")

        Dim CheckAccess2 As Boolean = UserPermission(CurrUser, "RoomStatus", "Edit")

        Dim CheckAccess3 As Boolean = UserPermission(CurrUser, "Housekeeping", "Edit")

        If CheckAccess = True Or CheckAccess2 = True Or CheckAccess3 = True Then

            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update Room", "Update Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    UpdateRoom()


                End If
                LoadGrid()
                tabRooms.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Private Sub UpdateRoom()

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand


            dcInsertNewAcc = New SqlCommand("UpdateRoom_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Roomno", SqlDbType.VarChar).Value = txtRoomno.Text
            dcInsertNewAcc.Parameters.Add("@Category", SqlDbType.VarChar).Value = cmbCategory.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = cmbStatus.Text.Trim


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Room Updated Successfully", "Update Room Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub InactiveRoom()

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand


            dcInsertNewAcc = New SqlCommand("InactiveRoom_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Roomno", SqlDbType.VarChar).Value = txtRoomno.Text
            dcInsertNewAcc.Parameters.Add("@Inactiveby", SqlDbType.VarChar).Value = CurrUser

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Room Inactivated Successfully", "Inactive Room Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub gvRoomMaster_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvRoomMaster.DoubleClick
        ShowGridDets()
    End Sub

    Private Sub frmRoomMaster_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub btInactiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInactiv.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room Master", "Edit")

        Dim CheckAccess2 As Boolean = UserPermission(CurrUser, "RoomStatus", "Edit")

        Dim CheckAccess3 As Boolean = UserPermission(CurrUser, "Housekeeping", "Edit")

        If CheckAccess = True Or CheckAccess2 = True Or CheckAccess3 = True Then

            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This Room", "Inactive Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveRoom()


                End If
                LoadGrid()
                tabRooms.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

   
End Class