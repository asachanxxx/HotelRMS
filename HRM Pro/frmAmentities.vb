Imports System.Data.SqlClient
Public Class frmAmentities
    Public PubDisId As Integer = 0

    Private Sub frmAmentities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadGrid()


        tabAmentities.TabPages(1).PageEnabled = False
    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[Amentities.Master] where Status='OPEN' order by AmentitiesID", Conn)
            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            GcAmenities.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub InsertAmentities()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim CurrentUser As String = CurrUser

        dcInsertNewAcc = New SqlCommand("InsertAmentitiesMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@AmentitiesName", SqlDbType.VarChar).Value = txtAmename.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Details", SqlDbType.VarChar).Value = txtAmeDetails.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()


        Conn.Close()
    End Sub
    Private Sub ShowGridDets()
        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Amentities.Master]  where Status='OPEN' and AmentitiesID= '{0}' ", GcAmenitiesview.GetRowCellValue(GcAmenitiesview.FocusedRowHandle, "AmentitiesID")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If
            tabAmentities.TabPages(1).PageEnabled = True
            tabAmentities.SelectedTabPageIndex = 1

            PubDisId = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("AmentitiesID"))
            txtAmename.Text = dsShow.Tables(0).Rows(0).Item("AmentitiesName")
            txtAmeDetails.Text = dsShow.Tables(0).Rows(0).Item("Details")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub UpdateAmentities()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("UpdateAmentities_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@AmentitiesID", SqlDbType.Int).Value = PubDisId
        dcInsertNewAcc.Parameters.Add("@AmentitiesName", SqlDbType.VarChar).Value = txtAmename.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Details", SqlDbType.VarChar).Value = txtAmeDetails.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Private Sub DeleteAmentities()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveAmentities_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@AmentitiesID", SqlDbType.Int).Value = PubDisId
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Amentities Details Inactivated Successfully", "Inactivate Amentities Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()
    End Sub
    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Amentities", "Add")

        If CheckAccess = True Then



            If String.Compare(btAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btAdd.Text = "Save"
                btEdit.Enabled = False
                btDel.Enabled = False
                tabAmentities.TabPages(1).PageEnabled = True
                tabAmentities.SelectedTabPageIndex = 1

            Else

                Try

                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Amentities Details", "Save Amentities Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then

                        InsertAmentities()
                        MessageBox.Show("Amentities Details Saved Successfully", "Save Amentities Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                    LoadGrid()

                    btAdd.Text = "Add"
                    btEdit.Enabled = True
                    btDel.Enabled = True
                    tabAmentities.TabPages(1).PageEnabled = False
                    tabAmentities.SelectedTabPageIndex = 0
                    Exit Sub

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
                End Try
            End If



        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Sub ClearFields()

        txtAmename.Text = ""
        txtAmeDetails.Text = ""
    End Sub
    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Amentities", "Edit")

        If CheckAccess = True Then




            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Amentities Details", "Update Amentities Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    UpdateAmentities()
                    MessageBox.Show("Amentities Details Updated Successfully", "Update Amentities Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                LoadGrid()
                tabAmentities.TabPages(1).PageEnabled = False
                tabAmentities.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Amentities", "Delete")

        If CheckAccess = True Then




            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Delete This Amentities Details", "Delete Amentities Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    DeleteAmentities()


                End If
                LoadGrid()
                tabAmentities.TabPages(1).PageEnabled = False
                tabAmentities.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub

    Private Sub GcAmenitiesview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GcAmenitiesview.DoubleClick
        ShowGridDets()
    End Sub

    Private Sub frmAmentities_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class