Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class frmTourOperators

    Private Sub frmTourOperators_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadGrid()

        cmbTopgroup.SelectedIndex = 0
        cmbTopstatus.SelectedIndex = 0
        cmbToppri.SelectedIndex = 0

    End Sub
    Private Sub btadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btadd.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TourOperatorMaster", "Add")

        If CheckAccess = True Then



            If String.Compare(btadd.Text, "Add", False) = 0 Then

                ClearFields()
                btadd.Text = "Save"
                btedit.Enabled = False
                btnInactive.Enabled = False
                tabTop.SelectedTabPageIndex = 1


            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                    Exit Sub


                Else

                    InsertTourop()
                    MessageBox.Show("Tour Operator Details Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    LoadGrid()
                    btadd.Text = "Add"
                    btedit.Enabled = True
                    btnInactive.Enabled = True
                    tabTop.SelectedTabPageIndex = 0


                    Exit Sub
                End If
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtTopcode.Text, "", False) = 0 Or String.Compare(txtTopname.Text, "", False) = 0 Or String.Compare(txtToptel.Text, "", False) = 0 Or String.Compare(cmbTopgroup.Text, "", False) = 0 Or String.Compare(cmbTopstatus.Text, "", False) = 0 Or String.Compare(cmbToppri.Text, "", False) = 0, 0, 1)

    End Function
    Sub ClearFields()

        txtTopcode.Text = ""
        txtTopname.Text = ""
        txtToptel.Text = ""
        txtTopemail.Text = ""
        txtTopAdd.Text = ""
        txtTopFax.Text = ""
        txtTopConPer.Text = ""
        txtTopcode.Enabled = True


    End Sub
    Private Sub InsertTourop()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("InsertTourOpMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@TopId", SqlDbType.VarChar).Value = autoid.ToString()
        dcInsertNewAcc.Parameters.Add("@TopCode", SqlDbType.VarChar).Value = txtTopcode.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TopName", SqlDbType.VarChar).Value = txtTopname.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TopTel", SqlDbType.VarChar).Value = txtToptel.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TopFax", SqlDbType.VarChar).Value = txtTopFax.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TopAdd", SqlDbType.VarChar).Value = txtTopAdd.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ContactPer", SqlDbType.VarChar).Value = txtTopConPer.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TopEmail", SqlDbType.VarChar).Value = txtTopemail.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TopGroup", SqlDbType.VarChar).Value = cmbTopgroup.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = cmbTopstatus.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Priority", SqlDbType.VarChar).Value = cmbToppri.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TinNo", SqlDbType.VarChar).Value = txtTinno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = "rashad"

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


            dcSearch = New SqlCommand("select TopCode,TopName,TopGroup from dbo.[Touroperator.Master] Where Status= 'Active'", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcTop.DataSource = dsMain.Tables(0)

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
            txtTopcode.Enabled = False

            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Touroperator.Master] where Status= 'Active' and TopCode= '{0}'", gvTourOperator.GetRowCellValue(gvTourOperator.FocusedRowHandle, "TopCode")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabTop.SelectedTabPageIndex = 1

            txtTopcode.Text = dsShow.Tables(0).Rows(0).Item("TopCode")
            txtTopname.Text = dsShow.Tables(0).Rows(0).Item("TopName")
            txtToptel.Text = dsShow.Tables(0).Rows(0).Item("TopTel")
            txtTopFax.Text = dsShow.Tables(0).Rows(0).Item("TopFax")
            txtTopemail.Text = dsShow.Tables(0).Rows(0).Item("TopEmail")
            txtTopAdd.Text = dsShow.Tables(0).Rows(0).Item("TopAdd")
            txtTopConPer.Text = dsShow.Tables(0).Rows(0).Item("ContactPer")
            cmbTopgroup.Text = dsShow.Tables(0).Rows(0).Item("TopGroup")
            cmbTopgroup.ClosePopup()
            cmbTopstatus.Text = dsShow.Tables(0).Rows(0).Item("Status")
            cmbTopstatus.ClosePopup()
            cmbToppri.Text = dsShow.Tables(0).Rows(0).Item("Priority")
            cmbToppri.ClosePopup()

            txtTopConPer.Text = dsShow.Tables(0).Rows(0).Item("ContactPer")

            txtTinno.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("TinNo")), "", dsShow.Tables(0).Rows(0).Item("TinNo"))






        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub gvTourOperator_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvTourOperator.DoubleClick

        ShowGridDets()
        txtTopcode.Enabled = False

    End Sub
    Private Sub txtTopcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTopcode.KeyPress

        e.KeyChar = UCase(e.KeyChar)

    End Sub
    Private Sub txtTopemail_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTopemail.Validating

        Dim email As String = txtTopemail.Text

        If EmailAddressCheck(email) = False Then

            Dim result As DialogResult _
            = MessageBox.Show("The email address you entered is not valid." & _
                                       " Do you want re-enter it?", "Invalid Email Address", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            End If

        End If

    End Sub
    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" & _
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True

        Else
            EmailAddressCheck = False

        End If
    End Function
    Private Sub UpdateTop()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("UpdateTopMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@TopCode", SqlDbType.VarChar).Value = txtTopcode.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TopName", SqlDbType.VarChar).Value = txtTopname.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TopTel", SqlDbType.VarChar).Value = txtToptel.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TopFax", SqlDbType.VarChar).Value = txtTopFax.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TopEmail", SqlDbType.VarChar).Value = txtTopemail.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TopAdd", SqlDbType.VarChar).Value = txtTopAdd.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ContactPer", SqlDbType.VarChar).Value = txtTopConPer.Text.Trim
        dcInsertNewAcc.Parameters.Add("@TopGroup", SqlDbType.VarChar).Value = cmbTopgroup.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = cmbTopstatus.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Priority", SqlDbType.VarChar).Value = cmbToppri.Text.Trim

        dcInsertNewAcc.Parameters.Add("@TinNo", SqlDbType.VarChar).Value = txtTinno.Text.Trim




        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub

    Private Sub btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TourOperatorMaster", "Edit")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update Operator Details", "Update Operator Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    UpdateTop()
                    MessageBox.Show("Operator Details Updated Successfully", "Update Operator Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                LoadGrid()
                tabTop.SelectedTabPageIndex = 0
                txtTopcode.Enabled = True
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TourOperatorMaster", "Delete")

        If CheckAccess = True Then




            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive Operator Details", "Inactive Operator Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveTourOperatorDetails()
                    MessageBox.Show("Operator Details Inactived Successfully", "Inactive Operator Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                LoadGrid()
                tabTop.SelectedTabPageIndex = 0

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Private Sub InactiveTourOperatorDetails()


        Dim ConnSt As String = ConnString
        Dim Conn As New SqlConnection(ConnSt)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InactiveTourOpMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@TopCode", SqlDbType.VarChar).Value = txtTopcode.Text.Trim

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub

    Private Sub frmTourOperators_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class