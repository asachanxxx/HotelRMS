Imports System.Data.SqlClient
Public Class frmSpaservices

    Public PubServiceId As Integer = 0

    Private Sub frmSpaservices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGrid()

    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select * from dbo.[Spa.Services] where Status='OPEN' order by ServiceId", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            GcSpa.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        If String.Compare(btAdd.Text, "Add", False) = 0 Then

            ClearFields()
            btAdd.Text = "Save"
            btEdit.Enabled = False
            btDel.Enabled = False
            tabSpaService.SelectedTabPageIndex = 1

        Else

            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Spa Service Details", "Save Spa Service Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InsertSpaServices()


                End If
                LoadGrid()

                btAdd.Text = "Add"
                btEdit.Enabled = True
                btDel.Enabled = True
                tabSpaService.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try
        End If
    End Sub
    Sub ClearFields()

        txtService.Text = ""
        txtServiceDetail.Text = ""
        txtServiceAmt.Text = ""

    End Sub

    Private Sub txtServiceAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtServiceAmt.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.btAdd.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub
    Private Sub InsertSpaServices()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InsertSpaServices_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@ServiceName", SqlDbType.VarChar).Value = txtService.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ServiceDes", SqlDbType.VarChar).Value = txtServiceDetail.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ServiceAmount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtServiceAmt.Text.Trim)
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = "Rashad"

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Spa Service Details Saved Successfully", "Save Spa Service Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Conn.Close()
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Spa Service Details", "Update Spa Service Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                UpdateSpaServices()


            End If
            LoadGrid()
            tabSpaService.SelectedTabPageIndex = 0
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub UpdateSpaServices()

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand


            dcInsertNewAcc = New SqlCommand("UpdateSpaServices_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@ServiceId", SqlDbType.Int).Value = PubServiceId
            dcInsertNewAcc.Parameters.Add("@ServiceName", SqlDbType.VarChar).Value = txtService.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ServiceDes", SqlDbType.VarChar).Value = txtServiceDetail.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ServiceAmount", SqlDbType.Decimal).Value = Convert.ToDecimal(txtServiceAmt.Text.Trim)
            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Spa Service Details Updated Successfully", "Update Spa Service Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub

    Private Sub GcSpaview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GcSpaview.DoubleClick
        ShowGridDets()
    End Sub
    Private Sub ShowGridDets()

        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Spa.Services]  where Status='OPEN' and ServiceId= '{0}' ", GcSpaview.GetRowCellValue(GcSpaview.FocusedRowHandle, "ServiceId")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabSpaService.SelectedTabPageIndex = 1

            PubServiceId = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("ServiceId"))
            txtService.Text = dsShow.Tables(0).Rows(0).Item("ServiceName")
            txtServiceDetail.Text = dsShow.Tables(0).Rows(0).Item("ServiceDes")
            txtServiceAmt.Text = dsShow.Tables(0).Rows(0).Item("ServiceAmount")


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click
        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Delete This Spa Service Details", "Delete Spa Service Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                InactiveSpaService()


            End If
            LoadGrid()
            tabSpaService.SelectedTabPageIndex = 0
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub InactiveSpaService()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        dcInsertNewAcc = New SqlCommand("InactiveSpaService_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@ServiceId", SqlDbType.Int).Value = PubServiceId
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Spa Service Details Deleted Successfully", "Delete Spa Service Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Conn.Close()
    End Sub

    Private Sub frmSpaservices_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class