Imports System.Data.SqlClient
Public Class frmDisscountBilling

    Public PubDisId As Integer = 0


    Private Sub frmDisscountBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadGrid()
        tabDiscou.TabPages(1).PageEnabled = False

    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select ID,DisCountType,Name,Amount from dbo.[KotBotDiscountType] order by ID", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            GcDisscounts.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Discount Billing", "Add")

        If CheckAccess = True Then





            If String.Compare(btAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btAdd.Text = "Save"
                btEdit.Enabled = False
                tabDiscou.TabPages(1).PageEnabled = True
                tabDiscou.SelectedTabPageIndex = 1

            Else

                Try

                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Discount Details", "Save Discount Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then

                        InsertDiscount()


                    End If
                    LoadGrid()
                    btAdd.Text = "Add"
                    btEdit.Enabled = True
                    tabDiscou.TabPages(1).PageEnabled = False
                    tabDiscou.SelectedTabPageIndex = 0
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

        DisplanName.Text = ""
        DisplanAmt.Text = ""
    End Sub
    Private Sub InsertDiscount()

        Try

            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            dcInsertNewAcc = New SqlCommand("InsertBillingDisscount_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            Dim CurrentUser As String = CurrUser

            dcInsertNewAcc.Parameters.Add("@DisCountType", SqlDbType.VarChar).Value = cmbDistype.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Amount", SqlDbType.Float).Value = Convert.ToDouble(DisplanAmt.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@Name", SqlDbType.VarChar).Value = DisplanName.Text.Trim
           

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Discount Details Saved Successfully", "Save Discount Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Discount Billing", "Edit")

        If CheckAccess = True Then



            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Discount Details", "Update Disocunt Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    UpdateDiscount()


                End If
                LoadGrid()
                tabDiscou.TabPages(1).PageEnabled = False
                tabDiscou.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try



        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
    Private Sub UpdateDiscount()

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand


            dcInsertNewAcc = New SqlCommand("UpdateKotBotDiscount", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@ID", SqlDbType.Int).Value = PubDisId
           
            dcInsertNewAcc.Parameters.Add("@DisCountType", SqlDbType.VarChar).Value = cmbDistype.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Amount", SqlDbType.Float).Value = Convert.ToDouble(DisplanAmt.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@Name", SqlDbType.VarChar).Value = DisplanName.Text.Trim

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Discount Details Updated Successfully", "Update Discount Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub ShowGridDets()
        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try


            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[KotBotDiscountType]  where  ID= '{0}' ", GcDisscountview.GetRowCellValue(GcDisscountview.FocusedRowHandle, "ID")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If


            tabDiscou.TabPages(1).PageEnabled = True
            tabDiscou.SelectedTabPageIndex = 1

            PubDisId = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("ID"))
            DisplanName.Text = dsShow.Tables(0).Rows(0).Item("Name")
            DisplanAmt.Text = Convert.ToDouble(dsShow.Tables(0).Rows(0).Item("Amount"))
            cmbDistype.Text = dsShow.Tables(0).Rows(0).Item("DisCountType")
            cmbDistype.ClosePopup()

            If cmbDistype.Text = "Percentage" Then

                lbldistype.Text = "Discount %"
            End If

            If cmbDistype.Text = "Value" Then
                lbldistype.Text = "Discount Value"
            End If


           



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Private Sub GcDisscountview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GcDisscountview.DoubleClick
        ShowGridDets()
    End Sub

    Private Sub cmbDistype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDistype.SelectedIndexChanged
        If cmbDistype.Text = "Percentage" Then
            lbldistype.Text = "Discount %"
        End If

        If cmbDistype.Text = "Value" Then
            lbldistype.Text = "Discount Value"
        End If
    End Sub

    Private Sub DisplanAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DisplanAmt.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.DisplanName.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub frmDisscountBilling_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class