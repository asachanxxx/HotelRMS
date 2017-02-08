Imports System.Data.SqlClient
Imports System.Xml
Public Class frmAllinclusive


    Public PubRatesId As String = ""

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "All Inclusive Rates", "Add")

        If CheckAccess = True Then



            If String.Compare(btnAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btnAdd.Text = "Save"
                btnEdit.Enabled = False

                tabRoomrates.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                    Exit Sub

                Else

                    Try

                        Dim dscheckAddbefore As New DataSet
                        dscheckAddbefore = DSCheckInsertAI()

                        If dscheckAddbefore Is Nothing Then

                            Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This All Inclusive Rate Details", "Save  All Inclusive Rates", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If bt = Windows.Forms.DialogResult.Yes Then

                                InsertAllinclusive()


                            End If
                            LoadGrid()

                            btnAdd.Text = "Add"
                            btnEdit.Enabled = True

                            tabRoomrates.SelectedTabPageIndex = 0
                            Exit Sub

                        Else
                            MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
                    End Try
                End If
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Private Sub InsertAllinclusive()


        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InsertAllInclusives_SP", Conn) With {.CommandType = CommandType.StoredProcedure}


        Dim getCusType As String = ""


        If cmbGuesttype.Text = "FIT" Then
            getCusType = "FIT"

        End If


        If cmbGuesttype.Text = "COMPLEMENTARY" Then
            getCusType = "COM"

        End If

        If cmbGuesttype.Text = "TOP NON CONTRACTS" Then
            getCusType = "TOPNONCONTRACT"

        End If


        Dim autoid As String = System.Guid.NewGuid().ToString()
        dcInsertNewAcc = New SqlCommand("InsertAllInclusives_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

        dcInsertNewAcc.Parameters.Add("@InclusiveId", SqlDbType.VarChar).Value = autoid
        dcInsertNewAcc.Parameters.Add("@Custype", SqlDbType.VarChar).Value = getCusType
        dcInsertNewAcc.Parameters.Add("@CusId", SqlDbType.VarChar).Value = ""
        dcInsertNewAcc.Parameters.Add("@IncluTopContractId", SqlDbType.VarChar).Value = ""
        dcInsertNewAcc.Parameters.Add("@TopContractId", SqlDbType.VarChar).Value = ""
        dcInsertNewAcc.Parameters.Add("@Category", SqlDbType.VarChar).Value = cmbCustype.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Rates", SqlDbType.Decimal).Value = Convert.ToDecimal(txtrate.Text.Trim)


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("All Inclusive Rate Details Saved Successfully", "Save Room Rates", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Custype,Category,Rates,InclusiveId from dbo.[Meals.Allinclusive] where Custype != 'TOP'", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcRoomRates.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Sub ClearFields()

        cmbCustype.SelectedIndex = 0
        txtrate.Text = ""
    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtrate.Text, "", False) = 0, 0, 1)

    End Function
    Function DSCheckInsertAI() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim getcustype As String = cmbGuesttype.Text.Trim
            Dim getrateType As String = cmbCustype.Text.Trim


            dcSearch = New SqlCommand("select * from  dbo.[Meals.Allinclusive] where Custype=@Custype and Category=@Category", Conn)
            dcSearch.Parameters.Add("@Custype", SqlDbType.VarChar).Value = getcustype
            dcSearch.Parameters.Add("@Category", SqlDbType.VarChar).Value = getrateType
   

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertAI = dsMain
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

    Private Sub frmAllinclusive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadGrid()
    End Sub
    Private Sub ShowGridDets()
        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Meals.Allinclusive]  where InclusiveId= '{0}' ", gviewRoomrate.GetRowCellValue(gviewRoomrate.FocusedRowHandle, "InclusiveId")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabRoomrates.SelectedTabPageIndex = 1

            PubRatesId = dsShow.Tables(0).Rows(0).Item("InclusiveId")
            cmbGuesttype.Text = dsShow.Tables(0).Rows(0).Item("Custype")
            cmbGuesttype.ClosePopup()
            cmbCustype.Text = dsShow.Tables(0).Rows(0).Item("Category")
            cmbCustype.ClosePopup()


            txtrate.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("Rates"))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "All Inclusive Rates", "Edit")

        If CheckAccess = True Then

            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update All Inclusive Rates", "Update All Inclusive Rates", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    UpdateAllinclusive()



                End If
                LoadGrid()
                tabRoomrates.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Private Sub UpdateAllinclusive()

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand


            dcInsertNewAcc = New SqlCommand("UpdateAllinclusive_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@InclusiveId", SqlDbType.VarChar).Value = PubRatesId
            dcInsertNewAcc.Parameters.Add("@Custype", SqlDbType.VarChar).Value = cmbGuesttype.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Category", SqlDbType.VarChar).Value = cmbCustype.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Rates", SqlDbType.Decimal).Value = txtrate.Text.Trim


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("All Inclusive Rates Updated Successfully", "Update All Inclusive Rate Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub

    Private Sub gviewRoomrate_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gviewRoomrate.DoubleClick
        ShowGridDets()
    End Sub

    Private Sub frmAllinclusive_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class