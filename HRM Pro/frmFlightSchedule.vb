Imports System.Data.SqlClient
Public Class frmFlightSchedule
    Public PubDisId As Integer = 0
    Private Sub frmFlightSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadGrid()
        cmbDay.SelectedIndex = 0
        cmbType.SelectedIndex = 0
        cmbCountry.SelectedIndex = 0

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

       
    End Sub
    Sub ClearFields()

        'txtFlightSceID.Text = ""
        cmbDay.SelectedIndex = 0
        cmbCountry.SelectedIndex = 0
        txtFlightNo.Text = ""
        tmScheduleTime.Text = ""
        cmbType.SelectedIndex = 0

    End Sub
    Private Sub InsertFlightSchedule()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()

        dcInsertNewAcc = New SqlCommand("InsertFlightSchedule_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@Day", SqlDbType.VarChar).Value = cmbDay.Text.Trim
        dcInsertNewAcc.Parameters.Add("@FlightNo", SqlDbType.VarChar).Value = txtFlightNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Country", SqlDbType.VarChar).Value = cmbCountry.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ScheduleTime", SqlDbType.DateTime).Value = tmScheduleTime.Text
        dcInsertNewAcc.Parameters.Add("@Type", SqlDbType.VarChar).Value = cmbType.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = CurrUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Flight Details Saved Successfully", "Save Flight Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Private Sub LoadGrid()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select FlightScheduleID,Day,FlightNo,Country,convert(char(5), ScheduleTime, 108) [Time],Type from dbo.[FlightSchedule.Master] where Status='OPEN'", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcFlightSchedule.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadGridByDayType()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim GetcmbGridDay As String = cmbGridDay.Text.Trim
            Dim GetcmbGridType As String = cmbGridType.Text.Trim

            dcSearch = New SqlCommand("select FlightScheduleID,Day,FlightNo,Country,convert(char(5),ScheduleTime, 108) [Time],Type from dbo.[FlightSchedule.Master] where Day=@Day and Type=@Type and Status='OPEN' order by Day,Type", Conn)
            dcSearch.Parameters.Add("@Day", SqlDbType.VarChar).Value = GetcmbGridDay
            dcSearch.Parameters.Add("@Type", SqlDbType.VarChar).Value = GetcmbGridType


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcFlightSchedule.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub gcFlightSchedule_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick

    End Sub

    Private Sub ShowGridDets()

        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select FlightScheduleID,Day,FlightNo,Country,convert(char(5), ScheduleTime, 108) [Time],Type from dbo.[FlightSchedule.Master] where Status='OPEN' and FlightScheduleID= '{0}' order by Day,Type", gvFlightSchedule.GetRowCellValue(gvFlightSchedule.FocusedRowHandle, "FlightScheduleID")), Conn)
            daShow.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If
            tabFlightSchedule.TabPages(1).PageEnabled = True

            tabFlightSchedule.SelectedTabPageIndex = 1

            PubDisId = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("FlightScheduleID"))
            cmbDay.Text = dsShow.Tables(0).Rows(0).Item("Day")
            cmbDay.ClosePopup()
            txtFlightNo.Text = dsShow.Tables(0).Rows(0).Item("FlightNo")
            cmbCountry.Text = dsShow.Tables(0).Rows(0).Item("Country")
            cmbCountry.ClosePopup()
            tmScheduleTime.Time = dsShow.Tables(0).Rows(0).Item("Time")
            cmbType.Text = dsShow.Tables(0).Rows(0).Item("Type")
            cmbType.ClosePopup()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Private Sub gvFlightSchedule_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvFlightSchedule.DoubleClick

        ShowGridDets()
        'txtFlightSceID.Enabled = False

    End Sub
    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub InactiveFlightSchedule()


        Dim ConnSt As String = ConnString
        Dim Conn As New SqlConnection(ConnSt)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveFlightSchedule_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@FlightScheduleID", SqlDbType.Int).Value = PubDisId

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Flight Inactived Successfully", "Inactive Flight Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Private Sub frmFlightSchedule_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadGrid()
        cmbDay.SelectedIndex = 0
        cmbType.SelectedIndex = 0
        cmbGridType.SelectedIndex = 0
        cmbGridDay.SelectedIndex = 0
        cmbCountry.SelectedIndex = 0

        tabFlightSchedule.TabPages(1).PageEnabled = False
        tmScheduleTime.Text = DateTime.Now

    End Sub

    Private Sub btGridview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGridview.Click

        LoadGridByDayType()

    End Sub

    Private Sub txtFlightNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFlightNo.KeyPress

        e.KeyChar = UCase(e.KeyChar)

    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

       
    End Sub
    Private Sub UpdateFlightDetails()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("UpdateFlightDetails_SP", Conn)

        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@FlightScheduleID", SqlDbType.VarChar).Value = PubDisId
        dcInsertNewAcc.Parameters.Add("@Day", SqlDbType.VarChar).Value = cmbDay.Text.Trim
        dcInsertNewAcc.Parameters.Add("@FlightNo", SqlDbType.VarChar).Value = txtFlightNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Country", SqlDbType.VarChar).Value = cmbCountry.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ScheduleTime", SqlDbType.DateTime).Value = Convert.ToDateTime(tmScheduleTime.Text.Trim())
        dcInsertNewAcc.Parameters.Add("@Type", SqlDbType.VarChar).Value = cmbType.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Flight Details Updated Successfully", "Update Flight Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "FlightMaster", "Add")

        If CheckAccess = True Then


            If String.Compare(btnAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btnAdd.Text = "Save"
                btnEdit.Enabled = False
                btnInactive.Enabled = False
                tabFlightSchedule.TabPages(1).PageEnabled = True
                tabFlightSchedule.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                    Exit Sub

                Else

                    'Dim dscheckAddbefore As New DataSet
                    'dscheckAddbefore = DSCheckInsertFlightScheduleTemp()

                    'If dscheckAddbefore Is Nothing Then

                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Flight Details", "Save Flight Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If bt = Windows.Forms.DialogResult.Yes Then
                        InsertFlightSchedule()


                        'End If


                    Else
                        Exit Sub

                    End If

                    LoadGrid()

                    btnAdd.Text = "Add"
                    btnEdit.Enabled = True
                    btnInactive.Enabled = True
                    tabFlightSchedule.TabPages(1).PageEnabled = False
                    tabFlightSchedule.SelectedTabPageIndex = 0
                    Exit Sub

                End If
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub btnInactive_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "FlightMaster", "Delete")

        If CheckAccess = True Then




            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive Flight Details", "Inactive Flight Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveFlightSchedule()


                End If
                LoadGrid()
                tabFlightSchedule.TabPages(1).PageEnabled = False
                tabFlightSchedule.SelectedTabPageIndex = 0

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub btnEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "FlightMaster", "Edit")

        If CheckAccess = True Then



            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update Flight Details", "Update Flight Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    UpdateFlightDetails()


                End If
                LoadGrid()
                tabFlightSchedule.TabPages(1).PageEnabled = False
                tabFlightSchedule.SelectedTabPageIndex = 0

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtFlightNo.Text, "", False) = 0 Or String.Compare(cmbDay.Text, "", False) = 0 Or String.Compare(cmbCountry.Text, "", False) = 0 Or String.Compare(cmbType.Text, "", False) = 0, 0, 1)

    End Function

    Private Sub frmFlightSchedule_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class