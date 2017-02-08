Imports System.Data.SqlClient
Public Class frmGuestregister

    Private Sub frmGuestregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadGrid()

        dtBday.Text = Now.Date

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If String.Compare(btnAdd.Text, "Add", False) = 0 Then

            ClearFields()
            btnAdd.Text = "Save"
            btnEdit.Enabled = False
            btnInactive.Enabled = False
            tabGuestDetails.SelectedTabPageIndex = 1

        Else


            Dim dscheckAddbefore As New DataSet
            dscheckAddbefore = DSCheckInsertGuestDetailsTemp()

            If dscheckAddbefore Is Nothing Then
                InsertGuestDetails()

            Else
                MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End If

            LoadGrid()
            btnAdd.Text = "Add"
            btnEdit.Enabled = True
            btnInactive.Enabled = True
            tabGuestDetails.SelectedTabPageIndex = 0

            Exit Sub

        End If
    End Sub
    Sub ClearFields()

        txtGID.Text = ""
        txtGName.Text = ""
        txtPassportNo.Text = ""
        txtAddress.Text = ""
        txtNationality.Text = ""
        txtCRes.Text = ""
        txtMNo.Text = ""
        txtHNo.Text = ""
        txtOccupation.Text = ""

    End Sub
    Private Sub InsertGuestDetails()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("InsertGuestMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@GuestID", SqlDbType.VarChar).Value = txtGID.Text
        dcInsertNewAcc.Parameters.Add("@GuestName", SqlDbType.VarChar).Value = txtGName.Text.Trim
        dcInsertNewAcc.Parameters.Add("@PassportNo", SqlDbType.VarChar).Value = txtPassportNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAddress.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Nationality", SqlDbType.VarChar).Value = txtNationality.Text.Trim
        dcInsertNewAcc.Parameters.Add("@CountryOfResidence", SqlDbType.VarChar).Value = txtCRes.Text.Trim
        dcInsertNewAcc.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dtBday.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MobileNo", SqlDbType.Int).Value = txtMNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@HomePhone", SqlDbType.Int).Value = txtHNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Occupation", SqlDbType.VarChar).Value = txtOccupation.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = "Thilini"

        Dim result = MessageBox.Show("Entered All Fields?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the no button was pressed ... 
        If (result = DialogResult.Yes) Then
            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Successfully saved", "Add Guest Master", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Conn.Close()

    End Sub
    Function DSCheckInsertGuestDetailsTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim GuestID As String = txtGID.Text.Trim


            dcSearch = New SqlCommand("select * from dbo.[GuestMaster] where GuestID=@GuestID", Conn)
            dcSearch.Parameters.Add("@GuestID", SqlDbType.VarChar).Value = GuestID

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertGuestDetailsTemp = dsMain
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


            dcSearch = New SqlCommand("select GuestRegno,FullName,PassportNo,PPDateOfIssue,Nationality,Country,Profession from dbo.[GuestRegistration] order by Fullname", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcGuestDetails.DataSource = dsMain.Tables(0)

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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[GuestMaster] where Status='OPEN' and  GuestID= '{0}'", gvGuestDetails.GetRowCellValue(gvGuestDetails.FocusedRowHandle, "GuestID")), Conn)
            daShow.Fill(dsShow)




            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabGuestDetails.SelectedTabPageIndex = 1

            txtGID.Text = dsShow.Tables(0).Rows(0).Item("GuestID")
            txtGName.Text = dsShow.Tables(0).Rows(0).Item("GuestName")
            txtPassportNo.Text = dsShow.Tables(0).Rows(0).Item("PassportNo")
            txtAddress.Text = dsShow.Tables(0).Rows(0).Item("Address")
            txtNationality.Text = dsShow.Tables(0).Rows(0).Item("Nationality")
            txtCRes.Text = dsShow.Tables(0).Rows(0).Item("CountryOfResidence")
            dtBday.Text = dsShow.Tables(0).Rows(0).Item("DateOfBirth")
            txtMNo.Text = dsShow.Tables(0).Rows(0).Item("MobileNo")
            txtHNo.Text = dsShow.Tables(0).Rows(0).Item("HomePhone")
            txtOccupation.Text = dsShow.Tables(0).Rows(0).Item("Occupation")
           


            'If Val(txtNBTVal.Text) > 0 Then
            '    chkNBT.Checked = True
            'Else
            '    chkNBT.Checked = False
            'End If

            'If Val(txtVATVal.Text) > 0 Then
            '    chkVAT.Checked = True
            'Else
            '    chkNBT.Checked = False
            'End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Private Sub gvGuestDetails_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvGuestDetails.DoubleClick
        ShowGridDets()
        txtGID.Enabled = False
    End Sub
    Private Sub EditGuestDetails()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("UpdateGuestMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@GuestID", SqlDbType.VarChar).Value = txtGID.Text
        dcInsertNewAcc.Parameters.Add("@GuestName", SqlDbType.VarChar).Value = txtGName.Text.Trim
        dcInsertNewAcc.Parameters.Add("@PassportNo", SqlDbType.VarChar).Value = txtPassportNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtAddress.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Nationality", SqlDbType.VarChar).Value = txtNationality.Text.Trim
        dcInsertNewAcc.Parameters.Add("@CountryOfResidence", SqlDbType.VarChar).Value = txtCRes.Text.Trim
        dcInsertNewAcc.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dtBday.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MobileNo", SqlDbType.Int).Value = txtMNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@HomePhone", SqlDbType.Int).Value = txtHNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Occupation", SqlDbType.VarChar).Value = txtOccupation.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Guest Details", "Update Sea Condition Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                EditGuestDetails()

                MessageBox.Show("Guest Details Updated Successfully", "Update Guest Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            LoadGrid()
            tabGuestDetails.SelectedTabPageIndex = 0

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub InactiveGuestDetails()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveGuestMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@GuestID", SqlDbType.VarChar).Value = txtGID.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub

    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click
        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This Guest Details", "Inactive Guest Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                InactiveGuestDetails()
                MessageBox.Show("Guest Details Inactivated Successfully", "Inactive Guest Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            LoadGrid()
            tabGuestDetails.SelectedTabPageIndex = 0

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
End Class