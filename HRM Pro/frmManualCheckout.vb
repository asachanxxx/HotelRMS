Imports System.Data.SqlClient
Public Class frmManualCheckout

    Public PubRoomNo As String = "NOROOM"

    Private Sub frmManualCheckout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()


        LoadGrid()
        btnManualCheout.Enabled = False

    End Sub

    Private Sub LoadGrid()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()


            dcSearch = New SqlCommand("select * from [Room.CurrentStatus] order by RoomNo", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcBoat.DataSource = dsMain.Tables(0)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        Finally

            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()

        End Try

    End Sub

    Private Sub gvBoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvBoat.Click

        PubRoomNo = gvBoat.GetRowCellValue(gvBoat.FocusedRowHandle, "RoomNo").ToString

        btnManualCheout.Enabled = True


    End Sub

    Private Sub btnManualCheout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManualCheout.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Manual Checkout", "Add")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Check Out Room No " + PubRoomNo, "Manual Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then


                    If PubRoomNo <> "NOROOM" Then



                        CheckOutManual(PubRoomNo)

                    Else

                        MessageBox.Show("Please Select A Room No By Click On the Grid", "Manual Checkout", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop)


                    End If


                End If
                LoadGrid()

                PubRoomNo = "NOROOM"
                btnManualCheout.Enabled = False


                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub CheckOutManual(ByVal passRoomNo As String)

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        dcInsertNewAcc = New SqlCommand("ManualCheckOut_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@roomno", SqlDbType.VarChar).Value = passRoomNo
        dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = CurrUser


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Room No-" + PubRoomNo + "  CheckedOut Successfully", "Manual Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
End Class