Imports System.Data.SqlClient
Public Class frmRoomChange

    Private Sub frmRoomChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        cmbRoom.SelectedIndex = 0
        cmbRoomtyp.SelectedIndex = 0
        LoadTopcodes()

    End Sub
    Private Sub LoadTopcodes()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select TopCode from [Touroperator.Master] order by TopCode", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            cbTopcode.Properties.Items.Add("ALL")

            While (DscountTest < Dscount)

                cbTopcode.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cbTopcode.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub


    Private Sub btSearchtop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearchtop.Click
        Try


            If cbTopcode.Text = "ALL" Then
                cmbResnos.Properties.Items.Clear()
                LoadResCodesAllTop()
            Else
                cmbResnos.Properties.Items.Clear()
                LoadResCodesByTop()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub LoadResCodesAllTop()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT * FROM dbo.[Reservation.Master] where Status='OPEN' AND IsProformaCreated=0 AND ResType='TOP' order by ResNo", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer


            If Dscount > 0 Then

                While (DscountTest < Dscount)

                    cmbResnos.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbResnos.SelectedIndex = 0

            Else

                MessageBox.Show("No Records Found", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbResnos.Properties.Items.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadResCodesByTop()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT * FROM dbo.[Reservation.Master] where Status='OPEN' AND IsProformaCreated=0 AND ResType='TOP' AND Topcode=@Topcode order by ResNo", Conn)
            dcSearch.Parameters.Add("@Topcode", SqlDbType.NVarChar).Value = cbTopcode.Text.Trim

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            If Dscount > 0 Then


                While (DscountTest < Dscount)

                    cmbResnos.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbResnos.SelectedIndex = 0


            Else

                MessageBox.Show("No Records Found", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbResnos.Properties.Items.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadResCodesOthers()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT * FROM dbo.[Reservation.Master] where Status='OPEN' AND IsProformaCreated=0 AND ResType !='TOP'  order by ResNo,ResType", Conn)
            dcSearch.Parameters.Add("@Topcode", SqlDbType.NVarChar).Value = cbTopcode.Text.Trim

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            If Dscount > 0 Then

                While (DscountTest < Dscount)

                    cmbResnos.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbResnos.SelectedIndex = 0

            Else

                MessageBox.Show("No Records Found", "Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbResnos.Properties.Items.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub btSearchothers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearchothers.Click
        cmbResnos.Properties.Items.Clear()
        LoadResCodesOthers()
    End Sub

    Private Sub btResDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResDetails.Click
        Try


            gcPax.DataSource = Nothing
            gcResdetails.DataSource = Nothing


            LoadResDetails()

            LoadRoomDetails()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub LoadRoomDetails()
        Dim DSPax As New DataSet
        DSPax = DSLoadResPaxDetails()

        If DSPax.Tables(0).Rows.Count > 0 Then

            gcPax.DataSource = DSPax.Tables(0)

        End If
    End Sub


    Private Sub LoadResDetails()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getResno As String = cmbResnos.Text.Trim

            Conn.Open()
            dcSearch = New SqlCommand("select ResNo,ResDate,Guest,ResType,Topcode,IsTopcontract,TopContractId,ArrDate,DepDate,ArrFlight,DepFlight,convert(char(5), ArrTime, 108) [ArrTime],convert(char(5), DepTime, 108) [DepTime],ArrTrans,DepTrans,PaxId,AdultQty,ChildrenQty,InfantsQty,MealPlan,BedNights,Rate,DisPlanId,OfferId,AmenId,Total,PayMode,PayExpiryDate,PayCCNo,Guestlikes,Guestdislikes,BillingInst,Remarks,Refno,Status,IsProformaCreated,ProfomaInvoiceno,EnteredBy,EnteredDate,InactivatedBy,InactivatedDate from dbo.[Reservation.Master] where ResNo=@ResNo", Conn)
            dcSearch.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = getResno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcResdetails.DataSource = dsMain.Tables(0)



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Function DSLoadResPaxDetails() As DataSet
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getResno As String = cmbResnos.Text.Trim

            Conn.Open()
            dcSearch = New SqlCommand("SELECT  dbo.[Reservation.Room].Room, dbo.[Reservation.Room].Roomtype, dbo.[Reservation.Room].RoomCount,dbo.[Reservation.Room].BedNights ,dbo.[Reservation.Room].ResRoomId FROM  dbo.[Reservation.Master] INNER JOIN  dbo.[Reservation.Room] ON dbo.[Reservation.Master].ResNo = dbo.[Reservation.Room].ReservationNo where dbo.[Reservation.Master].ResNo=@ResNo", Conn)
            dcSearch.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = getResno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then

                DSLoadResPaxDetails = dsMain
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Function

    Private Sub LabelControl18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl18.Click

    End Sub

    Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room Allocation Edit", "Edit")

        If CheckAccess = True Then





            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update Room", "Update Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    Dim RoomId As Integer = Convert.ToInt16(gvroomdetails.GetRowCellValue(gvroomdetails.FocusedRowHandle, "ResRoomId"))

                    If RoomId.ToString = "" Then

                        MessageBox.Show("Please Select A Row", "Room Details", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    Else

                        If FieldValidation() = False Then
                            MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                            Exit Sub
                        Else

                            UpdateRoom(RoomId)
                        End If
                    End If

                End If
                LoadRoomDetails()

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Function FieldValidation() As Boolean
        Return IIf(String.Compare(txtRoomcount.Text, "", False) = 0 Or String.Compare(txtBednights.Text, "", False) = 0, 0, 1)
    End Function
    Private Sub UpdateRoom(ByVal roomid As Integer)
        Try
            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getRoomid As Integer = roomid

            dcInsertNewAcc = New SqlCommand("UpdateResRoomChange_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@ResRoomId", SqlDbType.Int).Value = getRoomid
            dcInsertNewAcc.Parameters.Add("@Room", SqlDbType.VarChar).Value = cmbRoom.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Roomtype", SqlDbType.VarChar).Value = cmbRoomtyp.Text.Trim
            dcInsertNewAcc.Parameters.Add("@RoomCount", SqlDbType.Int).Value = Convert.ToInt16(txtRoomcount.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@BedNights", SqlDbType.Int).Value = Convert.ToInt16(txtBednights.Text.Trim)

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
            MessageBox.Show("Room Details Updated Successfully", "Room Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub btDelRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelRoom.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room Allocation Edit", "Delete")

        If CheckAccess = True Then





            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Delete Room", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    Dim RoomId As Integer = Convert.ToInt16(gvroomdetails.GetRowCellValue(gvroomdetails.FocusedRowHandle, "ResRoomId"))

                    If RoomId.ToString = "" Then

                        MessageBox.Show("Please Select A Row", "Room Details", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    Else

                        DelRoom(RoomId)

                    End If


                End If
                LoadRoomDetails()

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub
    Private Sub DelRoom(ByVal roomid As Integer)
        Try
            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            dcInsertNewAcc = New SqlCommand("DelResRoomChange_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            Dim getRoomid As Integer = roomid

            dcInsertNewAcc.Parameters.Add("@ResRoomId", SqlDbType.Int).Value = getRoomid

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
            MessageBox.Show("Room Details Deleted Successfully", "Room Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub

    Private Sub txtRoomcount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRoomcount.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtBednights_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBednights.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub frmRoomChange_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class