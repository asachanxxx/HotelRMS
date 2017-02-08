Imports System.Data.SqlClient
Public Class frmEventBoard

    Private Sub frmEventBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGrid()
        LoadRoomNo()
        LoadGuestID()

        cmbRmNo.SelectedIndex = 0
        cmbGuestID.SelectedIndex = 0


        tabEventBoard.TabPages(1).PageEnabled = False

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click


        If String.Compare(btnAdd.Text, "Add", False) = 0 Then

            ClearFields()
            btnAdd.Text = "Save"
            btnEdit.Enabled = False
            btnInactive.Enabled = False
            tabEventBoard.TabPages(1).PageEnabled = True
            tabEventBoard.SelectedTabPageIndex = 1
        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub

            Else

                Dim dscheckAddbefore As New DataSet
                dscheckAddbefore = DSCheckInsertEventBoard()

                If dscheckAddbefore Is Nothing Then

                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Event Board Details", "Save Event Board Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then
                        InsertEventBoard()
                        MessageBox.Show("Event Board Details Saved Successfully", "Save Event Board Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                   
                Else
                    MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                End If

                LoadGrid()

                btnAdd.Text = "Add"
                btnEdit.Enabled = True
                btnInactive.Enabled = True
                tabEventBoard.TabPages(1).PageEnabled = False
                tabEventBoard.SelectedTabPageIndex = 0
                Exit Sub
            End If
        End If

    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(cmbRmNo.Text, "", False) = 0 Or String.Compare(cmbGuestID.Text, "", False) = 0 Or String.Compare(txtEventNo.Text, "", False) = 0, 0, 1)

    End Function

    Sub ClearFields()


        txtEventNo.Text = ""
        txtEventName.Text = ""
        txtEventRate.Text = ""

    End Sub
    Private Sub InsertEventBoard()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("InsertEventBoard_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@RoomNo", SqlDbType.VarChar).Value = cmbRmNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@GuestID", SqlDbType.VarChar).Value = cmbGuestID.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EventID", SqlDbType.VarChar).Value = txtEventNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EventName", SqlDbType.VarChar).Value = txtEventName.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EventRate", SqlDbType.Decimal).Value = txtEventRate.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = "Thilini"


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select RoomNo,GuestID,EventID,EventName,EventRate from dbo.[EventBoard] where status='OPEN'", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcEventBoard.DataSource = dsMain.Tables(0)

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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[EventBoard] where RoomNo= '{0}'", gvEventBoard.GetRowCellValue(gvEventBoard.FocusedRowHandle, "RoomNo")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If
            tabEventBoard.TabPages(1).PageEnabled = True
            tabEventBoard.SelectedTabPageIndex = 1

            cmbRmNo.Text = dsShow.Tables(0).Rows(0).Item("RoomNo")
            cmbGuestID.Text = dsShow.Tables(0).Rows(0).Item("GuestID")
            txtEventNo.Text = dsShow.Tables(0).Rows(0).Item("EventID")
            txtEventName.Text = dsShow.Tables(0).Rows(0).Item("EventName")
            txtEventRate.Text = dsShow.Tables(0).Rows(0).Item("EventRate")


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

    Private Sub gvEventBoard_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvEventBoard.DoubleClick
        ShowGridDets()
        cmbRmNo.Enabled = False
    End Sub

    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click

        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This Event Board Details", "Inactive Event Board Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                InactiveEventBoard()


            End If
            LoadGrid()
            tabEventBoard.TabPages(1).PageEnabled = False
            tabEventBoard.SelectedTabPageIndex = 0

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub InactiveEventBoard()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveEventBoard_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@RoomNo", SqlDbType.VarChar).Value = cmbRmNo.Text.Trim

            Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Event Board Details Inactivated Successfully", "InactiveEvent Board Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()
    End Sub
    Function DSCheckInsertEventBoard() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim RoomNo As String = cmbRmNo.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[EventBoard] where RoomNo=@RoomNo", Conn)
            dcSearch.Parameters.Add("@RoomNo", SqlDbType.VarChar).Value = RoomNo

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertEventBoard = dsMain
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

    Private Sub txtEventNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEventNo.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtEventRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEventRate.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.cmbRmNo.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If

    End Sub
    Private Sub LoadRoomNo()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Roomno from [Rooms.Master] order by Roomno", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbRmNo.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbRmNo.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadGuestID()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select GuestID from [GuestMaster] order by GuestID", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbGuestID.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbGuestID.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub EditEventBoard()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("UpdateEventBoard_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@RoomNo", SqlDbType.VarChar).Value = cmbRmNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@GuestID", SqlDbType.VarChar).Value = cmbGuestID.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EventID", SqlDbType.VarChar).Value = txtEventNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EventName", SqlDbType.VarChar).Value = txtEventName.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EventRate", SqlDbType.VarChar).Value = txtEventRate.Text.Trim

            Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Event Board Details Updated Successfully", "Update Event Board Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Event Board Details", "Update Event Board Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                EditEventBoard()


            End If
            LoadGrid()
            tabEventBoard.TabPages(1).PageEnabled = False
            tabEventBoard.SelectedTabPageIndex = 0

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        LoadEventsDeatails()
    End Sub
    Private Sub LoadEventsDeatails()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select EventID,EventName,EventRate from dbo.[EventBoard] where  EventID=@EventID order by EventID", Conn)
            dcSearch.Parameters.Add("@EventID", SqlDbType.VarChar).Value = txtEventNo.Text.Trim

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            gcEvents.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
End Class
