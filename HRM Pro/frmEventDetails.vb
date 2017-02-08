Imports System.Data.SqlClient

Public Class frmEventDetails

    Private Sub frmEventDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()


        tabEventDetails.TabPages(1).PageEnabled = False
        LoadGrid()

    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If String.Compare(btnAdd.Text, "Add", False) = 0 Then

            ClearFields()
            btnAdd.Text = "Save"
            btnEdit.Enabled = False
            btnInactive.Enabled = False
            tabEventDetails.TabPages(1).PageEnabled = True
            tabEventDetails.SelectedTabPageIndex = 1

        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                Exit Sub

            Else

                Dim dscheckAddbefore As New DataSet
                dscheckAddbefore = DSCheckInsertEventDetailsTemp()


                If dscheckAddbefore Is Nothing Then

                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Event Details", "Save Event Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then
                        InsertEventDetails()

                    End If

                Else

                    MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                End If

                LoadGrid()

                btnAdd.Text = "Add"
                btnEdit.Enabled = True
                btnInactive.Enabled = True
                tabEventDetails.TabPages(1).PageEnabled = False
                tabEventDetails.SelectedTabPageIndex = 0

                Exit Sub

            End If
        End If

    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtEventNo.Text, "", False) = 0 Or String.Compare(dtEventDate.Text, "", False) = 0 Or String.Compare(txtMaxNo.Text, "", False) = 0 Or String.Compare(txtMinNo.Text, "", False) = 0 Or String.Compare(cmbStatus.Text, "", False) = 0, 0, 1)

    End Function
    Sub ClearFields()

        txtEventNo.Text = ""
        txtEventName.Text = ""
        MemoEventDes.Text = ""
        dtEventDate.Text = ""
        txtRate.Text = ""
        txtMaxNo.Text = ""
        txtMinNo.Text = ""
        cmbStatus.Text = ""

    End Sub
    Private Sub InsertEventDetails()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("InsertEvents_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@EventID", SqlDbType.VarChar).Value = autoid.ToString()
        dcInsertNewAcc.Parameters.Add("@EventNo", SqlDbType.VarChar).Value = txtEventNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EventName", SqlDbType.VarChar).Value = txtEventName.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EventDescription", SqlDbType.VarChar).Value = MemoEventDes.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EventDate", SqlDbType.DateTime).Value = dtEventDate.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = txtRate.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MaxNo", SqlDbType.Int).Value = txtMaxNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MinNo", SqlDbType.Int).Value = txtMinNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = cmbStatus.Text.Trim
        dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = "Thilini"


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Event Details Saved Successfully", "Save Event Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Private Sub LoadGrid()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select EventNo,EventName,EventDescription,EventDate,Rate,MaxNo,MinNo  from dbo.[Event.Master] where Status='Open Event'", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcEvent.DataSource = dsMain.Tables(0)

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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Event.Master] where  EventNo= '{0}'", gvEventDetails.GetRowCellValue(gvEventDetails.FocusedRowHandle, "EventNo")), Conn)
            daShow.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabEventDetails.TabPages(1).PageEnabled = True
            tabEventDetails.SelectedTabPageIndex = 1

            txtEventNo.Text = dsShow.Tables(0).Rows(0).Item("EventNo")
            txtEventName.Text = dsShow.Tables(0).Rows(0).Item("EventName")
            MemoEventDes.Text = dsShow.Tables(0).Rows(0).Item("EventDescription")
            dtEventDate.Text = dsShow.Tables(0).Rows(0).Item("EventDate")
            txtRate.Text = dsShow.Tables(0).Rows(0).Item("Rate")
            txtMaxNo.Text = dsShow.Tables(0).Rows(0).Item("MaxNo")
            txtMinNo.Text = dsShow.Tables(0).Rows(0).Item("MinNo")
            cmbStatus.Text = dsShow.Tables(0).Rows(0).Item("Status")
            cmbStatus.ClosePopup()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Private Sub gcEvent_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcEvent.DoubleClick

    End Sub

    Private Sub gvEventDetails_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvEventDetails.DoubleClick

        ShowGridDets()
        txtEventNo.Enabled = False

    End Sub

    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click


        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This Event Details", "Inactive Event Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                InactiveEventDetails()


            End If
            LoadGrid()
            tabEventDetails.TabPages(1).PageEnabled = False
            tabEventDetails.SelectedTabPageIndex = 0
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub InactiveEventDetails()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveEvents_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@EventNo", SqlDbType.VarChar).Value = txtEventNo.Text.Trim


            Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Event Details Inactivated Successfully", "Inactive Event Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()
    End Sub

    Private Sub txtMaxNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaxNo.KeyPress

        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If

    End Sub

    Private Sub txtMinNo_keyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMinNo.KeyPress

        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If

    End Sub

    Private Sub txtRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtMaxNo.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If

    End Sub

    Function DSCheckInsertEventDetailsTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim EventNo As String = txtEventNo.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[Event.Master] where EventNo=@EventNo", Conn)
            dcSearch.Parameters.Add("@EventNo", SqlDbType.VarChar).Value = EventNo

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertEventDetailsTemp = dsMain
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

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Update Event Details", "Update Event Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                UpdateEventDetails()


            End If
            LoadGrid()
            tabEventDetails.TabPages(1).PageEnabled = False
            tabEventDetails.SelectedTabPageIndex = 0

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub UpdateEventDetails()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("UpdateEvents_SP", Conn)

        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@EventNo", SqlDbType.VarChar).Value = txtEventNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EventName", SqlDbType.VarChar).Value = txtEventName.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EventDescription", SqlDbType.VarChar).Value = MemoEventDes.Text.Trim
        dcInsertNewAcc.Parameters.Add("@EventDate", SqlDbType.DateTime).Value = dtEventDate.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = txtRate.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MaxNo", SqlDbType.Int).Value = txtMaxNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MinNo", SqlDbType.Int).Value = txtMinNo.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Event Details Updated Successfully", "Update Event Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()
    End Sub

End Class