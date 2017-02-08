Imports System.Xml
Imports System.Data.SqlClient

Public Class frmItemCategory 

  

    Private Sub frmItemCategory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGridDets()

        txtLastItemCode.Properties.ReadOnly = True
    End Sub


#Region " Proc & Functions "

    Sub ClearFields()

        txtCategory.Text = ""
        txtCategoryID.Text = ""
        txtDescription.Text = ""
        txtLastItemCode.Text = ""


    End Sub

    ''' <summary>
    ''' Insert New Category
    ''' </summary>
    ''' <returns>True-Sucess,False-Failed</returns>
    ''' <remarks></remarks>
    Function InsertNewCategory(ByVal Proc As String) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim Procedure As String

        If String.Compare(Proc, "Add", False) = 0 Then
            Procedure = "spItemCategoryAdd"
        Else
            Procedure = "spItemCategoryEdit"
        End If

        Dim dcExecProc As New SqlCommand(Procedure, Conn)

        Try
            Conn.Open()

            dcExecProc.CommandType = CommandType.StoredProcedure

            With dcExecProc.Parameters
                .Add("@CategoryID", SqlDbType.NVarChar).Value = txtCategoryID.Text
                .Add("@Category", SqlDbType.NVarChar).Value = txtCategory.Text
                .Add("@Description", SqlDbType.NVarChar).Value = txtDescription.Text
 
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

    Sub ShowFields(ByVal CategoryID As String)

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter(String.Format("select * from CategoryMaster where categoryid like '{0}'", CategoryID), Conn)
        Dim dsShow As New DataSet

        Try

            daGetDets.Fill(dsShow)

            txtCategory.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("CATEGORYNAME")), "", dsShow.Tables(0).Rows(0).Item("CATEGORYNAME"))
            txtCategoryID.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("CATEGORYID")), "", dsShow.Tables(0).Rows(0).Item("CATEGORYID"))
            txtDescription.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("DESCRIPTION")), "", dsShow.Tables(0).Rows(0).Item("DESCRIPTION"))
            txtLastItemCode.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("LASTITEMCODE")), "", dsShow.Tables(0).Rows(0).Item("LASTITEMCODE"))


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
        Dim daGetDets As New SqlDataAdapter("select CategoryID,Categoryname from CategoryMaster", Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            gridCategory.DataSource = dsShow.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Function GetCodeLength() As Integer

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter("select * from itemcodesetting", Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count > 0 Then
                GetCodeLength = dsShow.Tables(0).Rows(0).Item("itemcategorylength")
            Else
                GetCodeLength = 0
            End If

            Return GetCodeLength
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try


    End Function

    Function FieldValidation() As Boolean
        Return IIf(String.Compare(txtCategoryID.Text, "", False) = 0 Or String.Compare(txtCategory.Text, "", False) = 0, 0, 1)
    End Function

    Function GetCategoryCode() As String

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
            GetCategoryCode = dcGetCode.Parameters("@Currcode").Value
            'Else
            'GetSupplierCode = ""
            'End If


            'If Not IsDBNull(dsGetDets.Tables(0).Rows(0).Item(0)) Then
            '    GetSupplierCode = dsGetDets.Tables(0).Rows(0).Item(0).ToString
            'Else
            '    GetSupplierCode = ""
            'End If

            Return GetCategoryCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return GetCategoryCode
        Finally
            Conn.Dispose()
            ' drGetDets.Close()

        End Try

    End Function

    Function InActiveCategory() As Boolean

    End Function

#End Region


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ItemCategory", "Add")

        If CheckAccess = True Then


            If String.Compare(cmdAdd.Text, "Add", False) = 0 Then

                ClearFields()
                cmdAdd.Text = "Save"
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False

                txtCategoryID.Focus()

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InsertNewCategory("Add") Then
                    Exit Sub
                End If

                MsgBox("Successfully Inserted...", , ErrTitle)

                LoadGridDets()

                cmdAdd.Text = "Add"
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True


            End If


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ItemCategory", "Edit")

        If CheckAccess = True Then



            If String.Compare(cmdEdit.Text, "Edit", False) = 0 Then
                cmdEdit.Text = "Save"
                cmdAdd.Enabled = False
                cmdDelete.Enabled = False

                txtCategoryID.Properties.ReadOnly = True
            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InsertNewCategory("Edit") Then
                    Exit Sub
                End If

                MsgBox("Successfully Update...", , ErrTitle)

                cmdEdit.Text = "Edit"
                cmdAdd.Enabled = True
                cmdDelete.Enabled = True

                txtCategoryID.Properties.ReadOnly = False

            End If


        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ItemCategory", "Delete")

        If CheckAccess = True Then




            If String.Compare(cmdEdit.Text, "Edit", False) = 0 Then


                cmdEdit.Text = "Save"
                cmdAdd.Enabled = False
                cmdDelete.Enabled = False

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InActiveCategory() Then
                    Exit Sub
                End If

                MsgBox("Successfully Update...", , ErrTitle)

                cmdEdit.Text = "Edit"
                cmdAdd.Enabled = True
                cmdDelete.Enabled = True

            End If


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub txtCategoryID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCategoryID.EditValueChanged
        If txtCategoryID.Text.Length < GetCodeLength() Then
            txtCategoryID.Properties.ReadOnly = False
        Else
            txtCategoryID.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub txtCategoryID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCategoryID.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            If cmdEdit.Text = "Save" Then
                txtCategoryID.Properties.ReadOnly = True
            Else
                txtCategoryID.Properties.ReadOnly = False
            End If

        End If
    End Sub

    Private Sub vwMain_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles vwMain.FocusedRowChanged
        If vwMain.GetRowCellValue(vwMain.FocusedRowHandle, "CategoryID") Is Nothing Then 'verification for suppliercode is blank or not
            Exit Sub
        End If
        ShowFields(vwMain.GetRowCellValue(vwMain.FocusedRowHandle, "CategoryID"))
    End Sub


    Private Sub frmItemCategory_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class