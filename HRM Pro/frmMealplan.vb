Imports System.Data.SqlClient
Public Class frmMealplan

    Private Sub frmMealplan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGrid()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "MealPlans", "Add")

        If CheckAccess = True Then


            If String.Compare(btnAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btnAdd.Text = "Save"
                btnEdit.Enabled = False
                btnInactive.Enabled = False
                tabMealplan.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                    Exit Sub


                Else

                    Dim dscheckAddbefore As New DataSet
                    dscheckAddbefore = DSCheckInsertMealPlanTemp()

                    If dscheckAddbefore Is Nothing Then


                        Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Meal Plan Details", "Save Meal Plan Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If bt = Windows.Forms.DialogResult.Yes Then
                            InsertMealPlan()

                        End If

                    Else
                        MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    End If

                    LoadGrid()

                    btnAdd.Text = "Add"
                    btnEdit.Enabled = True
                    btnInactive.Enabled = True
                    tabMealplan.SelectedTabPageIndex = 0
                    Exit Sub

                End If
            End If



        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtMealType.Text, "", False) = 0 Or String.Compare(MemoDes.Text, "", False) = 0, 0, 1)

    End Function

    Sub ClearFields()

        txtMealType.Text = ""
        MemoDes.Text = ""


    End Sub
    Private Sub InsertMealPlan()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InsertMealplan_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure


        dcInsertNewAcc.Parameters.Add("@MealType", SqlDbType.VarChar).Value = txtMealType.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Des", SqlDbType.VarChar).Value = MemoDes.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = "Thilini"

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Meal Plan Details Saved Successfully", "Save Meal Plan Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Function DSCheckInsertMealPlanTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim MealType As String = txtMealType.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[MealPlan.Master] where MealType=@MealType", Conn)
            dcSearch.Parameters.Add("@MealType", SqlDbType.VarChar).Value = MealType

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertMealPlanTemp = dsMain
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
    Private Sub LoadGrid()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select MealID,MealType,Des from dbo.[MealPlan.Master] where status='OPEN' order by MealID", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcMealPlans.DataSource = dsMain.Tables(0)

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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[MealPlan.Master] where Status= 'OPEN' and  MealID= '{0}'", gvMealPlans.GetRowCellValue(gvMealPlans.FocusedRowHandle, "MealID")), Conn)
            daShow.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabMealplan.SelectedTabPageIndex = 1

            txtMealType.Text = dsShow.Tables(0).Rows(0).Item("MealType")
            MemoDes.Text = dsShow.Tables(0).Rows(0).Item("Des")


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Private Sub gvMealPlans_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvMealPlans.DoubleClick

        ShowGridDets()
        txtMealType.Enabled = False

    End Sub
    Private Sub InactiveMealPlan()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveMealPlan_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@MealType", SqlDbType.VarChar).Value = txtMealType.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Meal Plan Inactived Successfully", "Inactive Meal Plan Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub

    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "MealPlans", "Delete")

        If CheckAccess = True Then



            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive Meal Plan Details", "Inactive Meal Plan Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveMealPlan()


                End If
                LoadGrid()
                tabMealplan.SelectedTabPageIndex = 0

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try



        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub txtMealType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMealType.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "MealPlans", "Edit")

        If CheckAccess = True Then




            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Meal Plan Details", "Update Meal Plan Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    UpdateMealPlanDetails()


                End If
                LoadGrid()
                tabMealplan.SelectedTabPageIndex = 0

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub UpdateMealPlanDetails()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("UpdateMealPlan_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

       dcInsertNewAcc.Parameters.Add("@MealType", SqlDbType.VarChar).Value = txtMealType.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Des", SqlDbType.VarChar).Value = MemoDes.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Meal Plan Details Updated Successfully", "Update Meal Plan Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub

    Private Sub frmMealplan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class