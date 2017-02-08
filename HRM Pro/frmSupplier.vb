Imports System.Data.SqlClient

Public Class frmSupplier

    Private Sub frmSupplier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGridDets()

        dtCreate.Text = Format(Now.Date, "dd/MM/yyyy")
        tabSupplier.TabPages(2).PageVisible = False
    End Sub

#Region " Proc & Functions "

    Sub ClearFields()

        txtAccountno.Text = ""
        txtAddress.Text = ""
        txtBalance.Text = ""
        txtCompany.Text = ""
        txtCountry.Text = ""
        txtEmail.Text = ""
        txtFax.Text = ""
        txtPhone1.Text = ""
        txtPhone2.Text = ""
        txtReference.Text = ""
        txtSuppliercode.Text = GetSupplierCode
        txtSupplierName.Text = ""
        txtWeb.Text = ""

    End Sub

    ''' <summary>
    ''' Insert New Supplier
    ''' </summary>
    ''' <returns>True-Sucess,False-Failed</returns>
    ''' <remarks></remarks>
    Function InsertNewSupplier(ByVal Proc As String) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim Procedure As String

        If String.Compare(Proc, "Add", False) = 0 Then
            Procedure = "spSupplierMasterAdd"
        ElseIf String.Compare(Proc, "Edit", False) = 0 Then
            Procedure = "spSupplierMasterEdit"
        ElseIf String.Compare(Proc, "InActive", False) = 0 Then
            Procedure = "spSupplierMasterInActive"
        End If

        Dim dcExecProc As New SqlCommand(Procedure, Conn)

        Try
            Conn.Open()

            dcExecProc.CommandType = CommandType.StoredProcedure

            With dcExecProc.Parameters
                .Add("@Suppliercode", SqlDbType.NVarChar).Value = txtSuppliercode.Text
                .Add("@Suppliername", SqlDbType.NVarChar).Value = txtSupplierName.Text
                .Add("@Address", SqlDbType.NVarChar).Value = txtAddress.Text
                .Add("@Country", SqlDbType.NVarChar).Value = txtCountry.Text
                .Add("@Company", SqlDbType.NVarChar).Value = txtCompany.Text
                .Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text
                .Add("@Web", SqlDbType.NVarChar).Value = txtWeb.Text
                .Add("@Phone1", SqlDbType.NVarChar).Value = txtPhone1.Text
                .Add("@Phone2", SqlDbType.NVarChar).Value = txtPhone2.Text
                .Add("@Fax", SqlDbType.NVarChar).Value = txtFax.Text
                .Add("@Bank", SqlDbType.NVarChar).Value = txtBank.Text
                .Add("@Accountno", SqlDbType.NVarChar).Value = txtAccountno.Text
                .Add("@Reference", SqlDbType.NVarChar).Value = txtReference.Text
                .Add("@Createdate", SqlDbType.Date).Value = dtCreate.Text
                '.Add("@Status", SqlDbType.NVarChar).Value = chkStatus.Checked
                '.Add("@Balance", SqlDbType.NVarChar).Value = txtBalance.Text

            End With

            dcExecProc.ExecuteNonQuery()

            Return 1
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            dcExecProc.Dispose()
        End Try

    End Function

    Sub ShowFields(ByVal Suppliercode As String)

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter(String.Format("select * from suppliermaster where suppliercode like '{0}'", Suppliercode), Conn)
        Dim dsShow As New DataSet

        Try

            daGetDets.Fill(dsShow)

            txtAccountno.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Accountno")), "", dsShow.Tables(0).Rows(0).Item("Accountno"))
            txtAddress.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Address")), "", dsShow.Tables(0).Rows(0).Item("Address"))
            txtBalance.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Balance")), "", dsShow.Tables(0).Rows(0).Item("Balance"))
            txtCompany.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Company")), "", dsShow.Tables(0).Rows(0).Item("Company"))
            txtCountry.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Country")), "", dsShow.Tables(0).Rows(0).Item("Country"))
            txtEmail.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Email")), "", dsShow.Tables(0).Rows(0).Item("Email"))
            txtFax.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Fax")), "", dsShow.Tables(0).Rows(0).Item("Fax"))
            txtPhone1.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Phone1")), "", dsShow.Tables(0).Rows(0).Item("Phone1"))
            txtPhone2.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Phone2")), "", dsShow.Tables(0).Rows(0).Item("Phone2"))
            txtReference.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Reference")), "", dsShow.Tables(0).Rows(0).Item("Reference"))
            txtSuppliercode.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Suppliercode")), "", dsShow.Tables(0).Rows(0).Item("Suppliercode"))
            txtSupplierName.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("SupplierName")), "", dsShow.Tables(0).Rows(0).Item("SupplierName"))
            txtWeb.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Web")), "", dsShow.Tables(0).Rows(0).Item("Web"))
            dtCreate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Createdate")), "", dsShow.Tables(0).Rows(0).Item("Createdate"))
            txtBank.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Bank")), "", dsShow.Tables(0).Rows(0).Item("Bank"))
            'txtAccountno.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("")), "", dsShow.Tables(0).Rows(0).Item(""))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()

        End Try


    End Sub

    ''' <summary>
    ''' Its Load Grid Details
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Sub LoadGridDets()

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter("select * from suppliermaster", Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            gridSupplier.DataSource = dsShow.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Function FieldValidation() As Boolean
        Return IIf(String.Compare(txtSuppliercode.Text, "", False) = 0 Or String.Compare(txtSupplierName.Text, "", False) = 0, 0, 1)
    End Function

    Function GetSupplierCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "Supplier"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output


            'drGetDets = dcGetCode.ExecuteReader
            dcGetCode.ExecuteNonQuery()


            'If drGetDets.Read Then
            GetSupplierCode = dcGetCode.Parameters("@Currcode").Value
            'Else
            'GetSupplierCode = ""
            'End If


            'If Not IsDBNull(dsGetDets.Tables(0).Rows(0).Item(0)) Then
            '    GetSupplierCode = dsGetDets.Tables(0).Rows(0).Item(0).ToString
            'Else
            '    GetSupplierCode = ""
            'End If

            Return GetSupplierCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return GetSupplierCode
        Finally
            Conn.Dispose()
            ' drGetDets.Close()

        End Try

    End Function

    ''' <summary>
    ''' TODO need to wirte Inactive Supplier
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Function InActiveSupplier() As Boolean

    End Function

#End Region


#Region " Control Events "

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click

       



            Dim CheckAccess As Boolean = UserPermission(CurrUser, "SupplierMaster", "Add")

            If CheckAccess = True Then


                If String.Compare(cmdAdd.Text, "Add", False) = 0 Then

                    ClearFields()
                    cmdAdd.Text = "Save"
                    cmdEdit.Enabled = False
                    cmdDelete.Enabled = False
                    tabSupplier.SelectedTabPageIndex = 1
                    tabSupplier.TabPages(0).PageEnabled = False

                Else

                    If FieldValidation() = False Then
                        MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                        Exit Sub
                    End If

                    If Not InsertNewSupplier("Add") Then
                        Exit Sub
                    End If

                    MsgBox("Successfully Inserted...", , ErrTitle)


                    LoadGridDets()

                    cmdAdd.Text = "Add"
                    cmdEdit.Enabled = True
                    cmdDelete.Enabled = True
                    tabSupplier.SelectedTabPageIndex = 0


                    tabSupplier.TabPages(0).PageEnabled = True
                End If

            Else

                MsgBox("You Do Not Have Access")


            End If






    End Sub

    Private Sub vwMain_DoubleClick(sender As System.Object, e As System.EventArgs) Handles vwMain.DoubleClick

        If vwMain.GetRowCellValue(vwMain.FocusedRowHandle, "Suppliercode") Is Nothing Then 'verification for suppliercode is blank or not
            Exit Sub
        End If

        tabSupplier.SelectedTabPageIndex = 1
        ShowFields(vwMain.GetRowCellValue(vwMain.FocusedRowHandle, "Suppliercode"))

    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "SupplierMaster", "Edit")

        If CheckAccess = True Then


        If String.Compare(cmdEdit.Text, "Edit", False) = 0 Then

            If txtSuppliercode.Text = "" Then
                Exit Sub
            End If

            cmdEdit.Text = "Save"
            cmdAdd.Enabled = False
            cmdDelete.Enabled = False
            txtSuppliercode.Properties.ReadOnly = True
            tabSupplier.SelectedTabPageIndex = 1

            tabSupplier.TabPages(0).PageEnabled = False

        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub
            End If

            If Not InsertNewSupplier("Edit") Then
                Exit Sub
            End If

            MsgBox("Successfully Update...", , ErrTitle)

            cmdEdit.Text = "Edit"
            cmdAdd.Enabled = True
            cmdDelete.Enabled = True
            txtSuppliercode.Properties.ReadOnly = False
            tabSupplier.SelectedTabPageIndex = 0
            tabSupplier.TabPages(0).PageEnabled = True

            End If


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "SupplierMaster", "Delete")

        If CheckAccess = True Then


            If String.Compare(cmdDelete.Text, "In Active", False) = 0 Then


                cmdDelete.Text = "Save"
                cmdAdd.Enabled = False
                cmdEdit.Enabled = False
                tabSupplier.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If InActiveSupplier() Then
                    Exit Sub
                End If

                MsgBox("Successfully Update...", , ErrTitle)

                cmdDelete.Text = "In Active"
                cmdAdd.Enabled = True
                cmdEdit.Enabled = True
                tabSupplier.SelectedTabPageIndex = 0

            End If

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub
#End Region


    Private Sub PictureEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureEdit1.EditValueChanged

    End Sub

    Private Sub frmSupplier_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class