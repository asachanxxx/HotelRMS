Imports System.Data.SqlClient

Public Class frmRoomblock

    Private Sub frmRoomblock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadRooms()
    End Sub
    Private Sub LoadRooms()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Roomno from dbo.[Room.CurrentStatus] order by Roomno", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            Dim newCustomersRow As DataRow = dsMain.Tables(0).NewRow()

            While (DscountTest < Dscount)

                cmbRoom.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbRoom.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub btblock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btblock.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room Block", "Block")

        If CheckAccess = True Then



            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand


            dcInsertNewAcc = New SqlCommand("UpdateBillBlockTrue_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@RoomNo", SqlDbType.VarChar).Value = cmbRoom.Text.Trim


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Room Blocked Successfully", "Block Room", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()



        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub btUnblock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUnblock.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room Block", "UnBlock")

        If CheckAccess = True Then



            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand


            dcInsertNewAcc = New SqlCommand("UpdateBillBlockFalse_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@RoomNo", SqlDbType.VarChar).Value = cmbRoom.Text.Trim


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Room UnBlocked Successfully", "UnBlock Room", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()



        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub frmRoomblock_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class