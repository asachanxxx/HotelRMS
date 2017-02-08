Imports System.Data.SqlClient


Public Class frmExchangeRate
    Public PubExchangeId As Integer = 0

    Private Sub frmExchangeRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGrid()

        tabExchangeRateDetails.TabPages(1).PageEnabled = False

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ExchangeRateMaster", "Add")

        If CheckAccess = True Then



            If String.Compare(btnAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btnAdd.Text = "Save"
                btnEdit.Enabled = False
                btnInactive.Enabled = False
                tabExchangeRateDetails.TabPages(1).PageEnabled = True
                tabExchangeRateDetails.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                    Exit Sub

                Else

                    Dim dscheckAddbefore As New DataSet
                    dscheckAddbefore = DSCheckInsertExchangeRateTemp()

                    If dscheckAddbefore Is Nothing Then

                        Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Exchange Rates Details", "Save Exchange Rates Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If bt = Windows.Forms.DialogResult.Yes Then
                            InsertExchangeRate()

                        End If

                    Else
                        MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                    End If
                    LoadGrid()

                    btnAdd.Text = "Add"
                    btnEdit.Enabled = True
                    btnInactive.Enabled = True
                    tabExchangeRateDetails.TabPages(1).PageEnabled = False
                    tabExchangeRateDetails.SelectedTabPageIndex = 0

                    Exit Sub

                End If
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtCurCode.Text, "", False) = 0 Or String.Compare(txtRCurrency.Text, "", False) = 0 Or String.Compare(txtsellingRate.Text, "", False) = 0 Or String.Compare(txtBuyingRate.Text, "", False) = 0, 0, 1)

    End Function
    Sub ClearFields()

        txtCurCode.Text = ""
        txtRCurrency.Text = ""
        txtsellingRate.Text = ""
        txtBuyingRate.Text = ""
        txtCurCode.Enabled = Enabled

    End Sub

    Private Sub InsertExchangeRate()

        Try

            Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InsertExchangeRateMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@RepCurrencyCode", SqlDbType.VarChar).Value = txtCurCode.Text.Trim
        dcInsertNewAcc.Parameters.Add("@RepCurrencyName", SqlDbType.VarChar).Value = txtRCurrency.Text.Trim
            dcInsertNewAcc.Parameters.Add("@SellingRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtsellingRate.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@BuyingRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtBuyingRate.Text.Trim)
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = "Thilini"


            Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Exchange Rates Details Saved Successfully", "Save Exchange Rates Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()
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


            dcSearch = New SqlCommand("select ExchangeRateID,RepCurrencyCode,RepCurrencyName,SellingRate from dbo.[ExchangeRate.Master] where  Status='OPEN'", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcExchangeRate.DataSource = dsMain.Tables(0)

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
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[ExchangeRate.Master] where  Status='OPEN' and ExchangeRateID= '{0}'", gvExchangeRate.GetRowCellValue(gvExchangeRate.FocusedRowHandle, "ExchangeRateID")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If
            tabExchangeRateDetails.TabPages(1).PageEnabled = True
            tabExchangeRateDetails.SelectedTabPageIndex = 1

            PubExchangeId = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("ExchangeRateID"))
            txtCurCode.Text = dsShow.Tables(0).Rows(0).Item("RepCurrencyCode")
            txtRCurrency.Text = dsShow.Tables(0).Rows(0).Item("RepCurrencyName")
            txtsellingRate.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("SellingRate"))
            txtBuyingRate.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("BuyingRate"))



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Private Sub gcExchangeRate_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcExchangeRate.DoubleClick

    End Sub

    Private Sub gVExchangeRate_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvExchangeRate.DoubleClick
        ShowGridDets()
        txtCurCode.Enabled = False

    End Sub

    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ExchangeRateMaster", "Delete")

        If CheckAccess = True Then




            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive This Exchange Rate Details", "Inactive Exchange Rate Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveExchangeRates()


                End If
                LoadGrid()
                tabExchangeRateDetails.TabPages(1).PageEnabled = False
                tabExchangeRateDetails.SelectedTabPageIndex = 0

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Private Sub InactiveExchangeRates()
        Try

        
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveExchangeRateMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@ExchangeRateNo", SqlDbType.Int).Value = PubExchangeId

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Exchange Rate Details Inactivated Successfully", "Inactive Exchange Rate Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub


    Function DSCheckInsertExchangeRateTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim ExchangeRateNo As String = txtCurCode.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[ExchangeRate.Master] where RepCurrencyCode=@RepCurrencyCode", Conn)
            dcSearch.Parameters.Add("@RepCurrencyCode", SqlDbType.VarChar).Value = ExchangeRateNo


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertExchangeRateTemp = dsMain
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


    Private Sub txtRCurrency_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRCurrency.KeyPress
        e.KeyChar = UCase(e.KeyChar)

    End Sub

    Private Sub txtsellingRate_keyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsellingRate.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtBuyingRate.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If


    End Sub

    Private Sub txtBuyingRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuyingRate.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtBuyingRate.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If

    End Sub
    Private Sub EditExchangeRate()
        Try

        
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("UpdateExchangeRate_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@ExchangeRateID", SqlDbType.Int).Value = PubExchangeId
            dcInsertNewAcc.Parameters.Add("@RepCurrencyCode", SqlDbType.VarChar).Value = txtCurCode.Text
        dcInsertNewAcc.Parameters.Add("@RepCurrencyName", SqlDbType.VarChar).Value = txtRCurrency.Text.Trim
            dcInsertNewAcc.Parameters.Add("@SellingRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtsellingRate.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@BuyingRate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtsellingRate.Text.Trim)


        Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Exchange Rate Details Updated Successfully", "Update Exchange Rate Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ExchangeRateMaster", "Edit")

        If CheckAccess = True Then



            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Exchange Rate Details", "Update Exchange Rate Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    EditExchangeRate()


                End If
                LoadGrid()
                tabExchangeRateDetails.TabPages(1).PageEnabled = False
                tabExchangeRateDetails.SelectedTabPageIndex = 0

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub txtCurCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCurCode.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub frmExchangeRate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class