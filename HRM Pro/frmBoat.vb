Imports System.Data.SqlClient

Public Class frmBoat

    Private Sub frmBoat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


      

            DevExpress.Skins.SkinManager.EnableFormSkins()
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

            LoadGrid()

            tabBoat.TabPages(1).PageEnabled = False

      

        


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub ClearFields()

        txtBoatNo.Text = ""
        txtDName.Text = ""
        txtMinpas.Text = ""
        txtMaxpas.Text = ""
        txtFLimite.Text = ""
        txtBoatNo.Enabled = True


    End Sub
    Private Sub InsertBoat()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        Dim CurrentUser As String = CurrUser

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("InsertBoatMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@BoatID", SqlDbType.VarChar).Value = autoid.ToString()
        dcInsertNewAcc.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = txtBoatNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@DriverName", SqlDbType.VarChar).Value = txtDName.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MinPassengers", SqlDbType.Int).Value = txtMinpas.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MaxPassengers", SqlDbType.Int).Value = txtMaxpas.Text.Trim
        dcInsertNewAcc.Parameters.Add("@FuelLimite", SqlDbType.VarChar).Value = txtFLimite.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Boat Details Saved Successfully", "Save Boat Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()
    End Sub
    Private Sub LoadGrid()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()


            dcSearch = New SqlCommand("select BoatNo,DriverName,MinPassengers,MaxPassengers,FuelLimite from dbo.[Boat.Master] where status='OPEN'", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


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

    Private Sub gcBoat_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ShowGridDets()

        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select BoatNo,DriverName,MinPassengers,MaxPassengers,FuelLimite from dbo.[Boat.Master] where Status='OPEN' and BoatNo= '{0}'", gvBoat.GetRowCellValue(gvBoat.FocusedRowHandle, "BoatNo")), Conn)
            daShow.Fill(dsShow)



            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If
            tabBoat.TabPages(1).PageEnabled = True
            tabBoat.SelectedTabPageIndex = 1

            txtBoatNo.Text = dsShow.Tables(0).Rows(0).Item("BoatNo")
            txtDName.Text = dsShow.Tables(0).Rows(0).Item("DriverName")
            txtMinpas.Text = dsShow.Tables(0).Rows(0).Item("MinPassengers")
            txtMaxpas.Text = dsShow.Tables(0).Rows(0).Item("MaxPassengers")
            txtFLimite.Text = dsShow.Tables(0).Rows(0).Item("FuelLimite")

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        Finally

            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()

        End Try

    End Sub

    Private Sub gvBoat_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub InactiveBoat()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveBoat_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = txtBoatNo.Text.Trim

       Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Boat Details Inactivated Successfully", "Inactive Boat Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub

    Function DSCheckInsertBoatTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim BoatNo As String = txtBoatNo.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[Boat.Master] where BoatNo=@BoatNo", Conn)
            dcSearch.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = BoatNo

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertBoatTemp = dsMain
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

    Private Sub txtMaxpas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False

        End If

    End Sub

    Private Sub txtMinpas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If

    End Sub
    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatMaster", "Add")

        If CheckAccess = True Then


            If String.Compare(btnAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btnAdd.Text = "Save"
                btnEdit.Enabled = False
                btnInactive.Enabled = False
                tabBoat.TabPages(1).PageEnabled = True
                tabBoat.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                    Exit Sub

                Else

                    Dim dscheckAddbefore As New DataSet
                    dscheckAddbefore = DSCheckInsertBoatTemp()


                    If dscheckAddbefore Is Nothing Then

                        Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Boat Details", "Save  Boat Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If bt = Windows.Forms.DialogResult.Yes Then
                            InsertBoat()

                        End If


                    Else
                        MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    End If

                    LoadGrid()

                    btnAdd.Text = "Add"
                    btnEdit.Enabled = True
                    btnInactive.Enabled = True
                    tabBoat.TabPages(1).PageEnabled = False
                    tabBoat.SelectedTabPageIndex = 0
                    Exit Sub
                End If
            End If



        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtBoatNo.Text, "", False) = 0 Or String.Compare(txtMinpas.Text, "", False) = 0 Or String.Compare(txtMaxpas.Text, "", False) = 0, 0, 1)

    End Function

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatMaster", "Edit")

        If CheckAccess = True Then






            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Boat Details", "Update Boat Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    EditBoatDetails()


                End If
                LoadGrid()
                tabBoat.TabPages(1).PageEnabled = False
                tabBoat.SelectedTabPageIndex = 0

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub
    Private Sub EditBoatDetails()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("UpdateBoatMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@BoatNo", SqlDbType.VarChar).Value = txtBoatNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@DriverName", SqlDbType.VarChar).Value = txtDName.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MinPassengers", SqlDbType.VarChar).Value = txtMinpas.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MaxPassengers", SqlDbType.VarChar).Value = txtMaxpas.Text.Trim
        dcInsertNewAcc.Parameters.Add("@FuelLimite", SqlDbType.VarChar).Value = txtFLimite.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Boat Details Updated Successfully", "Update Boat Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub

    Private Sub btnInactive_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatMaster", "Delete")

        If CheckAccess = True Then



            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This Boat Details", "Inactive Boat Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveBoat()


                End If
                LoadGrid()
                tabBoat.TabPages(1).PageEnabled = False
                tabBoat.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Private Sub gvBoat_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvBoat.DoubleClick

        ShowGridDets()
        txtBoatNo.Enabled = False


    End Sub

    Private Sub txtMinpas_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMinpas.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtMaxpas_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaxpas.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtFLimite_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFLimite.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.btnAdd.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub frmBoat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class

