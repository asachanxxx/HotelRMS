Imports System.Data.SqlClient
Public Class frmTax
    Public PubTaxId As Integer = 0

    Private Sub frmTax_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadGrid()

        tabTax.TabPages(1).PageEnabled = False

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TaxMaster", "Add")

        If CheckAccess = True Then



            If String.Compare(btnAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btnAdd.Text = "Save"
                btnEdit.Enabled = False
                btnInactive.Enabled = False
                tabTax.TabPages(1).PageEnabled = True
                tabTax.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                Else

                    Try

                        Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Tax Details", "Save Tax Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If bt = Windows.Forms.DialogResult.Yes Then
                            InsertTax()
                        End If
                        LoadGrid()

                        btnAdd.Text = "Add"
                        btnEdit.Enabled = True
                        btnInactive.Enabled = True
                        tabTax.TabPages(1).PageEnabled = False
                        tabTax.SelectedTabPageIndex = 0
                        Exit Sub

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
                    End Try
                End If
            End If

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Sub ClearFields()
        txtName.Text = ""
        MemoDes.Text = ""
        txtTax.Text = ""
    End Sub
    Private Sub InsertTax()

        Try

       
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InsertTax_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@TaxName", SqlDbType.VarChar).Value = txtName.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Description", SqlDbType.VarChar).Value = MemoDes.Text.Trim
            dcInsertNewAcc.Parameters.Add("@SDate", SqlDbType.DateTime).Value = DisplanSdate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@EDate", SqlDbType.DateTime).Value = DisplanEdate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@Taxpercentage", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTax.Text.Trim)
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = "Thilini"
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
            MessageBox.Show("Tax Details Saved Successfully", "Save Tax Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            dcSearch = New SqlCommand("select TaxID,TaxName,Taxpercentage from dbo.[Tax.Master] where Status='OPEN'", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcTax.DataSource = dsMain.Tables(0)

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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Tax.Master] where Status='OPEN' and TaxID= '{0}'", gvTax.GetRowCellValue(gvTax.FocusedRowHandle, "TaxID")), Conn)
            daShow.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If
            tabTax.TabPages(1).PageEnabled = True
            tabTax.SelectedTabPageIndex = 1
            PubTaxId = gvTax.GetRowCellValue(gvTax.FocusedRowHandle, "TaxID")
            txtName.Text = dsShow.Tables(0).Rows(0).Item("TaxName")
            MemoDes.Text = dsShow.Tables(0).Rows(0).Item("Description")
            txtTax.Text = dsShow.Tables(0).Rows(0).Item("Taxpercentage")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub gvTax_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvTax.DoubleClick
        ShowGridDets()
    End Sub
    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TaxMaster", "Delete")

        If CheckAccess = True Then



            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This Tax", "Inactive Tax Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveTax()
                    MessageBox.Show("Tax Inactived Successfully", "Inactive Tax Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                LoadGrid()
                tabTax.TabPages(1).PageEnabled = False
                tabTax.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Private Sub InactiveTax()

        Try

            Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveTax_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@TaxID", SqlDbType.Int).Value = PubTaxId

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
           
        Conn.Close()

         Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub UpdateTax()
        Try

       
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("UpdateTaxDetails_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@TaxID", SqlDbType.Int).Value = PubTaxId
        dcInsertNewAcc.Parameters.Add("@TaxName", SqlDbType.VarChar).Value = txtName.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Description", SqlDbType.VarChar).Value = MemoDes.Text.Trim
            dcInsertNewAcc.Parameters.Add("@SDate", SqlDbType.DateTime).Value = DisplanSdate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@EDate", SqlDbType.DateTime).Value = DisplanEdate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@Taxpercentage", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTax.Text.Trim)

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
            MessageBox.Show("Tax Details Updated Successfully", "Update Tax Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Function FieldValidation() As Boolean
        Return IIf(String.Compare(txtName.Text, "", False) = 0 Or String.Compare(MemoDes.Text, "", False) = 0 Or String.Compare(txtTax.Text, "", False) = 0, 0, 1)
    End Function
    Private Sub txtTax_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTax.KeyPress
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
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TaxMaster", "Edit")

        If CheckAccess = True Then



            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Tax Details", "Update Tax Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    UpdateTax()


                End If
                LoadGrid()
                tabTax.TabPages(1).PageEnabled = False
                tabTax.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub frmTax_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class