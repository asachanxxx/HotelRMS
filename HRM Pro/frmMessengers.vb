Imports System.Data.SqlClient
Imports System.Xml
Public Class frmMessengers

    Dim PubCurrentUser As String = CurrUser
    Dim PubMsgId As Integer = 0


    Private Sub frmMessengers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtDateDep.Text = DateTime.Now.ToShortDateString
        LoadGrid()
        LoadUsers()

        txtMsgFrm.Text = PubCurrentUser
        tabmsg.TabPages(1).PageEnabled = False

    End Sub
    Private Sub LoadUsers()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT * FROM dbo.[Admin.UsersSys] order by Fullname", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer


            If Dscount > 0 Then

                While (DscountTest < Dscount)

                    cmbUsers.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(1).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbUsers.SelectedIndex = 0

            Else

                MessageBox.Show("No Records Found", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbUsers.Properties.Items.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadGrid()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        gcMessenger.DataSource = Nothing

        Try
            Conn.Open()


            dcSearch = New SqlCommand("select * from Messenger where IsRead=0 and MsgTo=@MsgTo and MsgADate >= @Todate order by MessId", Conn)
            dcSearch.Parameters.Add("@MsgTo", SqlDbType.VarChar).Value = PubCurrentUser
            dcSearch.Parameters.Add("@Todate", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcMessenger.DataSource = dsMain.Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        Finally

            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()

        End Try

    End Sub
    Private Sub LoadGridRead()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        gcMessenger.DataSource = Nothing

        Try
            Conn.Open()


            dcSearch = New SqlCommand("select * from Messenger where IsRead=1 and MsgTo=@MsgTo and MsgADate >= @Todate order by MessId", Conn)
            dcSearch.Parameters.Add("@MsgTo", SqlDbType.VarChar).Value = PubCurrentUser
            dcSearch.Parameters.Add("@Todate", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcMessenger.DataSource = dsMain.Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        Finally

            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()

        End Try

    End Sub
    Private Sub LoadGridReadExp()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        gcMessenger.DataSource = Nothing

        Try
            Conn.Open()


            dcSearch = New SqlCommand("select * from Messenger where IsRead=1 and MsgTo=@MsgTo and MsgADate <= @Todate order by MessId", Conn)
            dcSearch.Parameters.Add("@MsgTo", SqlDbType.VarChar).Value = PubCurrentUser
            dcSearch.Parameters.Add("@Todate", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcMessenger.DataSource = dsMain.Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        Finally

            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()

        End Try

    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click

        If String.Compare(btAdd.Text, "New Msg", False) = 0 Then

            ClearFields()
            btAdd.Text = "Save Msg"
            btRead.Enabled = False

            tabmsg.TabPages(1).PageEnabled = True
            tabmsg.SelectedTabPageIndex = 1

        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                Exit Sub

            Else


                Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Message", "Save Message Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then
                    InsertMsg()

                  
                End If

                LoadGrid()

                btAdd.Text = "New Msg"

                btRead.Enabled = True
                tabmsg.TabPages(1).PageEnabled = False
                tabmsg.SelectedTabPageIndex = 0
                Exit Sub
            End If

        End If

    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(cmbUsers.Text, "", False) = 0 Or String.Compare(txtMsg.Text, "", False) = 0, 0, 1)

    End Function

    Sub ClearFields()

        txtMsg.Text = ""
        cmbUsers.SelectedIndex = 0
        dtDateDep.Text = DateTime.Now.ToShortDateString


    End Sub
    Private Sub InsertMsg()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim CurrentUser As String = CurrUser

        dcInsertNewAcc = New SqlCommand("InsertMessenger_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@MsgFrom", SqlDbType.VarChar).Value = txtMsgFrm.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MsgTo", SqlDbType.VarChar).Value = cmbUsers.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Msg", SqlDbType.VarChar).Value = txtMsg.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MsgADate", SqlDbType.DateTime).Value = dtDateDep.Text
        dcInsertNewAcc.Parameters.Add("@EnteredBy", SqlDbType.VarChar).Value = CurrentUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Message Details Saved Successfully", "Save Message Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()
    End Sub
    Private Sub ReadMsg()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("UpdateReadMsg_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@MsgId", SqlDbType.Int).Value = PubMsgId
        dcInsertNewAcc.Parameters.Add("@ReadBy", SqlDbType.VarChar).Value = PubCurrentUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
        LoadGrid()

    End Sub

    Private Sub btRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRead.Click
        If PubMsgId = 0 Then
            MsgBox("Select A Message To Update Read Status", MsgBoxStyle.Critical, ErrTitle)
        Else
            ReadMsg()
        End If


    End Sub

    Private Sub gvMessenger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvMessenger.Click
        PubMsgId = gvMessenger.GetRowCellValue(gvMessenger.FocusedRowHandle, "MessId")
    End Sub

    Private Sub btUnread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUnread.Click
        LoadGrid()
    End Sub

    Private Sub btReadNEx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReadNEx.Click
        LoadGridRead()
    End Sub

    Private Sub btReadE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReadE.Click
        LoadGridReadExp()
    End Sub

    Private Sub frmMessengers_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class