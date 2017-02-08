Imports System.Data.SqlClient


Public Class frmSeacondition

    Private Sub frmSeacondition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGrid()

        cmbSeaCondition.SelectedIndex = 0

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "SeaConditionMaster", "Add")

        If CheckAccess = True Then



            If String.Compare(btnAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btnAdd.Text = "Save"
                btnEdit.Enabled = False
                btnInactive.Enabled = False
                tabSeaCondition.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                    Exit Sub


                Else


                    Dim dscheckAddbefore As New DataSet
                    dscheckAddbefore = DSCheckInsertSeaConditionTemp()

                    If dscheckAddbefore Is Nothing Then

                        Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Sea Condition Details", "Save Sea Condition Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If bt = Windows.Forms.DialogResult.Yes Then
                            InsertSeaCondition()

                        End If


                    Else
                        MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    End If

                    LoadGrid()
                    btnAdd.Text = "Add"
                    btnEdit.Enabled = True
                    btnInactive.Enabled = True
                    tabSeaCondition.SelectedTabPageIndex = 0

                    Exit Sub

                End If
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtID.Text, "", False) = 0 Or String.Compare(cmbSeaCondition.Text, "", False) = 0 Or String.Compare(txtFrom.Text, "", False) = 0 Or String.Compare(txtTo.Text, "", False) = 0, 0, 1)

    End Function
    Sub ClearFields()

        txtID.Text = ""
        txtFrom.Text = ""
        txtTo.Text = ""
        txtDuration.Text = ""

    End Sub
    Private Sub InsertSeaCondition()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("InsertBoatsSeaCondition_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@SeaConditionID", SqlDbType.VarChar).Value = txtID.Text
        dcInsertNewAcc.Parameters.Add("@SeaCondition", SqlDbType.VarChar).Value = cmbSeaCondition.Text.Trim
        dcInsertNewAcc.Parameters.Add("@RunningTimeFrom", SqlDbType.DateTime).Value = txtFrom.Text.Trim
        dcInsertNewAcc.Parameters.Add("@RunningTimeTo", SqlDbType.DateTime).Value = txtTo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Duration", SqlDbType.VarChar).Value = txtDuration.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = "Thilini"


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Sea Condition Details Saved Successfully", "Save Sea Condition  Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Private Sub LoadGrid()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select SeaConditionID,SeaCondition,RunningTimeFrom,RunningTimeTo,Duration from dbo.[Boat.SeaCondition] where status='OPEN'", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcSeaCondition.DataSource = dsMain.Tables(0)

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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Boat.SeaCondition] where Status='OPEN' and  SeaConditionID= '{0}'", gvSeaCondition.GetRowCellValue(gvSeaCondition.FocusedRowHandle, "SeaConditionID")), Conn)
            daShow.Fill(dsShow)




            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabSeaCondition.SelectedTabPageIndex = 1

            txtID.Text = dsShow.Tables(0).Rows(0).Item("SeaConditionID")
            cmbSeaCondition.Text = dsShow.Tables(0).Rows(0).Item("SeaCondition")
            cmbSeaCondition.ClosePopup()
            txtFrom.Text = dsShow.Tables(0).Rows(0).Item("RunningTimeFrom")
            txtTo.Text = dsShow.Tables(0).Rows(0).Item("RunningTimeTo")
            txtDuration.Text = dsShow.Tables(0).Rows(0).Item("Duration")


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Private Sub gvSeaCondition_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvSeaCondition.DoubleClick

        ShowGridDets()
        txtID.Enabled = False

    End Sub

    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "SeaConditionMaster", "Delete")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This Sea Condition Details", "Inactive Sea Condition Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveSeaCondition()


                End If
                LoadGrid()
                tabSeaCondition.SelectedTabPageIndex = 0

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub InactiveSeaCondition()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveBoatsSeaCondition_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@SeaConditionID", SqlDbType.VarChar).Value = txtID.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Sea Condition Details Inactivated Successfully", "Inactive Sea Condition Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub

    Function DSCheckInsertSeaConditionTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim SeaConditionID As String = txtID.Text.Trim


            dcSearch = New SqlCommand("select * from dbo.[Boat.SeaCondition] where SeaConditionID=@SeaConditionID", Conn)
            dcSearch.Parameters.Add("@SeaConditionID", SqlDbType.VarChar).Value = SeaConditionID

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertSeaConditionTemp = dsMain
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
    Private Sub EditSeaCondition()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("UpdateSeacondition_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure


        dcInsertNewAcc.Parameters.Add("@SeaConditionID", SqlDbType.VarChar).Value = txtID.Text.Trim
        dcInsertNewAcc.Parameters.Add("@SeaCondition", SqlDbType.VarChar).Value = cmbSeaCondition.Text.Trim
        dcInsertNewAcc.Parameters.Add("@RunningTimeFrom", SqlDbType.DateTime).Value = txtFrom.Text.Trim
        dcInsertNewAcc.Parameters.Add("@RunningTimeTo", SqlDbType.DateTime).Value = txtTo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Duration", SqlDbType.VarChar).Value = txtDuration.Text.Trim


        
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Sea Condition Details Updated Successfully", "Update Sea Condition Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click



        Dim CheckAccess As Boolean = UserPermission(CurrUser, "SeaConditionMaster", "Edit")

        If CheckAccess = True Then




            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Sea Condition Details", "Update Sea Condition Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    EditSeaCondition()


                End If
                LoadGrid()
                tabSeaCondition.SelectedTabPageIndex = 0

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub txtDuration_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDuration.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtTo.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub frmSeacondition_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class