Imports System.Data.SqlClient
Public Class frmLaunchsectionfoodrates

    Private Sub frmLaunchsectionfoodrates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGrid()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If String.Compare(btnAdd.Text, "Add", False) = 0 Then

            ClearFields()
            btnAdd.Text = "Save"
            btnEdit.Enabled = False
            btnInactive.Enabled = False
            tabLaunchSectionFoodRates.SelectedTabPageIndex = 1

        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                Exit Sub

            Else

                Dim dscheckAddbefore As New DataSet
                dscheckAddbefore = DSCheckInsertLaunchsectionfoodratesTemp()

                If dscheckAddbefore Is Nothing Then


                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Launch Section Food Rates Details", "Save Launch Section Food Rates Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then
                        InsertLaunchsectionfoodrates()
                        MessageBox.Show("Launch Section Food Rates Details Saved Successfully", "Save Launch Section Food Rates Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Else
                    MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                End If

                LoadGrid()
                btnAdd.Text = "Add"
                btnEdit.Enabled = True
                btnInactive.Enabled = True
                tabLaunchSectionFoodRates.SelectedTabPageIndex = 0

                Exit Sub

            End If
        End If

    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtMealNo.Text, "", False) = 0 Or String.Compare(CmbMealType.Text, "", False) = 0 Or String.Compare(txtRate.Text, "", False) = 0, 0, 1)

    End Function
    Sub ClearFields()

        txtMealNo.Text = ""
        CmbMealType.Text = ""
        tmSTime.Text = ""
        tmETime.Text = ""
        txtRate.Text = ""

    End Sub
    Private Sub InsertLaunchsectionfoodrates()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("InsertBoatMealVoucherRates_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@MealID", SqlDbType.VarChar).Value = autoid.ToString()
        dcInsertNewAcc.Parameters.Add("@MealNo", SqlDbType.VarChar).Value = txtMealNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MealType", SqlDbType.VarChar).Value = CmbMealType.Text.Trim
        dcInsertNewAcc.Parameters.Add("@STime", SqlDbType.DateTime).Value = Convert.ToDateTime(tmSTime.Text.Trim())
        dcInsertNewAcc.Parameters.Add("@ETime", SqlDbType.DateTime).Value = Convert.ToDateTime(tmETime.Text.Trim())
        dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.VarChar).Value = txtRate.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = "Thilini"

        
            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()

    End Sub
    Private Sub LoadGrid()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()


            dcSearch = New SqlCommand("select MealNo,MealType,convert(char(5), STime, 108) [StartTime],convert(char(5), ETime, 108) [EndTime],Rate from dbo.[Boat.MealVoucherRates] where Status='OPEN'", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcLSectionFoodRates.DataSource = dsMain.Tables(0)

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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Boat.MealVoucherRates] where Status='OPEN' and MealNo= '{0}'", gvSectionFoodRates.GetRowCellValue(gvSectionFoodRates.FocusedRowHandle, "MealNo")), Conn)
            daShow.Fill(dsShow)



            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabLaunchSectionFoodRates.SelectedTabPageIndex = 1

            txtMealNo.Text = dsShow.Tables(0).Rows(0).Item("MealNo")
            CmbMealType.Text = dsShow.Tables(0).Rows(0).Item("MealType")
            tmSTime.Time = dsShow.Tables(0).Rows(0).Item("STime")
            tmETime.Time = dsShow.Tables(0).Rows(0).Item("ETime")
            txtRate.Text = dsShow.Tables(0).Rows(0).Item("Rate")


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub gcLSectionFoodRates_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabLaunchSectionFoodRates.DoubleClick

    End Sub

    Private Sub gvLSectionFoodRates_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvSectionFoodRates.DoubleClick

        ShowGridDets()
        txtMealNo.Enabled = False

    End Sub

    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click

        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive Launch Section Food Rates Details", "Inactive Launch Section Food Rates Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                InactiveLaunchsectionfoodrates()
                MessageBox.Show("Launch Section Food Rates Inactived Successfully", "Inactive Launch Section Food Rate Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            LoadGrid()
            tabLaunchSectionFoodRates.SelectedTabPageIndex = 0

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub InactiveLaunchsectionfoodrates()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveBoatMealVoucherRates_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@MealNo", SqlDbType.VarChar).Value = txtMealNo.Text.Trim


        Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub

    Private Sub txtRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress

        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtMealNo.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub


    Function DSCheckInsertLaunchsectionfoodratesTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()
            Dim MealNo As String = txtMealNo.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[Boat.MealVoucherRates] where MealNo=@MealNo", Conn)
            dcSearch.Parameters.Add("@MealNo", SqlDbType.VarChar).Value = MealNo

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertLaunchsectionfoodratesTemp = dsMain
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

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Update Launch Section Food Rates Details", "Update Launch Section Food Rates Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                UpdateLaunchsectionfoodrates()
                MessageBox.Show("Launch Section Food Rates Details Updated Successfully", "Update Launch Section Food Rates Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            LoadGrid()
            tabLaunchSectionFoodRates.SelectedTabPageIndex = 0

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub UpdateLaunchsectionfoodrates()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("UpdateBoatMealVoucherRates_SP", Conn)

        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        'dcInsertNewAcc.Parameters.Add("@MealID", SqlDbType.VarChar).Value = autoid.ToString()
        dcInsertNewAcc.Parameters.Add("@MealNo", SqlDbType.VarChar).Value = txtMealNo.Text.Trim
        dcInsertNewAcc.Parameters.Add("@MealType", SqlDbType.VarChar).Value = CmbMealType.Text.Trim
        dcInsertNewAcc.Parameters.Add("@STime", SqlDbType.DateTime).Value = Convert.ToDateTime(tmSTime.Text.Trim())
        dcInsertNewAcc.Parameters.Add("@ETime", SqlDbType.DateTime).Value = Convert.ToDateTime(tmETime.Text.Trim())
        dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.VarChar).Value = txtRate.Text.Trim
       
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
End Class