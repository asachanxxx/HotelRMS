Imports System.Data.SqlClient
Public Class frmGuestFeedBack_Comments

    Public PubResNo As String = ""

    Private Sub GuestFeedBack_Comments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        cmbRoomNo.SelectedIndex = 0

        LoadGrid()
        LoadRoomNo()
        LoadGuestID()


        tabGuestFeddBackComments.TabPages(1).PageEnabled = False

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestFeedbackAndComments", "Add")

        If CheckAccess = True Then




            If String.Compare(btnAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btnAdd.Text = "Save"
                btnEdit.Enabled = False
                btnInactive.Enabled = False

                tabGuestFeddBackComments.TabPages(1).PageEnabled = True
                tabGuestFeddBackComments.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub

                Else

                    Dim result = MessageBox.Show("Do You Want To Save Comments", "Guest Comments", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    ' If the no button was pressed ... 
                    If (result = DialogResult.Yes) Then
                        InsertGuestFeedBack_Comments()

                    End If

                    LoadGrid()

                    btnAdd.Text = "Add"
                    btnEdit.Enabled = True
                    btnInactive.Enabled = True

                    tabGuestFeddBackComments.TabPages(1).PageEnabled = False
                    tabGuestFeddBackComments.SelectedTabPageIndex = 0

                    Exit Sub

                End If

            End If

        Else

            MsgBox("You Do Not Have Access")


        End If






    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(cmbRoomNo.Text, "", False) = 0 Or String.Compare(MemoGuestComments.Text, "", False) = 0, 0, 1)

    End Function
    Private Sub LoadRoomDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Passtopcode As String = cmbRoomNo.Text.Trim

            dcSearch = New SqlCommand("select ReservationNo from [Room.CurrentStatus] where RoomNo=@RoomNo", Conn)
            dcSearch.Parameters.Add("@RoomNo", SqlDbType.NVarChar).Value = Passtopcode

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            PubResNo = dsMain.Tables(0).Rows(0)(0).ToString()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Sub ClearFields()

        'cmbRoomNo.Text = ""
        'cmbGuestID.Text = ""
        MemoGuestComments.Text = ""

    End Sub

    Private Sub InsertGuestFeedBack_Comments()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        Dim CurrentUser As String = CurrUser

        dcInsertNewAcc = New SqlCommand("InsertGuestFeedback_Comments_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@RoomNo", SqlDbType.VarChar).Value = cmbRoomNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Reservation", SqlDbType.VarChar).Value = PubResNo
        dcInsertNewAcc.Parameters.Add("@GuestComments", SqlDbType.VarChar).Value = MemoGuestComments.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Enteredby", SqlDbType.VarChar).Value = CurrentUser


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Guest Comments Successfully saved", "Add GuestFeedback and Comments ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub

    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click


        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This FeedBack & Comments Details", "Inactive FeedBack & Comments Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                InactiveGuestFeedBack_Comments()


            End If

            LoadGrid()

            tabGuestFeddBackComments.TabPages(1).PageEnabled = False
            tabGuestFeddBackComments.SelectedTabPageIndex = 0

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try


    End Sub

    Private Sub InactiveGuestFeedBack_Comments()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveGuestFeedback_Comments_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@RoomNo", SqlDbType.VarChar).Value = cmbRoomNo.Text.Trim


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("FeedBack & Comments  Details Inactived Successfully", "Inactive FeedBack & Comments Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Private Sub LoadGrid()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select RoomNo,Resevationno,GuestComments from dbo.[GuestFeedback_Comments] where status='OPEN'", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcGuestFeedback_Comments.DataSource = dsMain.Tables(0)

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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[GuestFeedback_Comments] where Status='OPEN' and RoomNo= '{0}'", gvGuestFeedback_Comments.GetRowCellValue(gvGuestFeedback_Comments.FocusedRowHandle, "RoomNo")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If


            tabGuestFeddBackComments.TabPages(1).PageEnabled = True
            tabGuestFeddBackComments.SelectedTabPageIndex = 1

            cmbRoomNo.Text = dsShow.Tables(0).Rows(0).Item("RoomNo")
            'cmbGuestID.Text = dsShow.Tables(0).Rows(0).Item("GuestID")
            MemoGuestComments.Text = dsShow.Tables(0).Rows(0).Item("GuestComments")


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Private Sub gvGuestFeedback_Comments_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvGuestFeedback_Comments.DoubleClick

        ShowGridDets()
        cmbRoomNo.Enabled = False

    End Sub
    Private Sub LoadRoomNo()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Roomno,ReservationNo,BillingGuest from [Room.CurrentStatus] order by Roomno", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbRoomNo.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbRoomNo.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub LoadGuestID()

        'Dim Conn As New SqlConnection(ConnString)
        'Dim daMain As New SqlDataAdapter
        'Dim dsMain As New DataSet
        'Dim dcSearch As New SqlCommand
        'Try
        '    Conn.Open()
        '    dcSearch = New SqlCommand("select GuestID from [GuestMaster] order by GuestID", Conn)

        '    daMain = New SqlDataAdapter()
        '    daMain.SelectCommand = dcSearch
        '    daMain.Fill(dsMain)

        '    Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
        '    Dim DscountTest As Integer

        '    While (DscountTest < Dscount)

        '        cmbGuestID.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
        '        DscountTest = DscountTest + 1

        '    End While

        '    cmbGuestID.SelectedIndex = 0

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        'Finally
        '    Conn.Dispose()
        '    daMain.Dispose()
        '    dsMain.Dispose()
        'End Try

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This FeedBack & Comments Details", "Update FeedBack & Comments Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                UpdateGuestFeedBackComments()


            End If
            LoadGrid()

            tabGuestFeddBackComments.TabPages(1).PageEnabled = False
            tabGuestFeddBackComments.SelectedTabPageIndex = 0
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub

    Private Sub UpdateGuestFeedBackComments()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("UpdateGuestFeedbackCommentsDetails_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

         dcInsertNewAcc.Parameters.Add("@RoomNo", SqlDbType.VarChar).Value = cmbRoomNo.Text.Trim
        'dcInsertNewAcc.Parameters.Add("@GuestID", SqlDbType.VarChar).Value = cmbGuestID.Text.Trim
        dcInsertNewAcc.Parameters.Add("@GuestComments", SqlDbType.VarChar).Value = MemoGuestComments.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("FeedBack & Comments Details Updated Successfully", "Update FeedBack & Comments Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub

    Private Sub cmbRoomNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRoomNo.SelectedIndexChanged
        LoadRoomDetails()
    End Sub

    Private Sub frmGuestFeedBack_Comments_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class