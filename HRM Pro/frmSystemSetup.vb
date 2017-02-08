Imports System.Data.SqlClient

Public Class frmSystemSetup

    Private Sub frmSystemSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()


    End Sub


#Region " Tax "


#Region " Proc & Functions "

    'Sub ClearFields()

    '    txtDesc_Tax.Text = ""
    '    txtTaxCode.Text = ""
    '    txtTaxPer.Text = "0"
    '    txtTaxVal.Text = "0"


    'End Sub

    ' ''' <summary>
    ' ''' Insert New Category
    ' ''' </summary>
    ' ''' <returns>True-Sucess,False-Failed</returns>
    ' ''' <remarks></remarks>
    'Function InsertNewCategory(ByVal Proc As String) As Boolean

    '    Dim Conn As New SqlConnection(modMain.ConnString)
    '    Dim Procedure As String

    '    If String.Compare(Proc, "Add", False) = 0 Then
    '        Procedure = "spItemCategoryAdd"
    '    Else
    '        Procedure = "spItemCategoryEdit"
    '    End If

    '    Dim dcExecProc As New SqlCommand(Procedure, Conn)

    '    Try
    '        Conn.Open()

    '        dcExecProc.CommandType = CommandType.StoredProcedure

    '        With dcExecProc.Parameters
    '            .Add("@CategoryID", SqlDbType.NVarChar).Value = txtCategoryID.Text
    '            .Add("@Category", SqlDbType.NVarChar).Value = txtCategory.Text
    '            .Add("@Description", SqlDbType.NVarChar).Value = txtDescription.Text

    '        End With

    '        dcExecProc.ExecuteNonQuery()

    '        Return 1
    '    Catch ex As SqlException
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
    '        Return 0
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
    '        Return 0
    '    Finally
    '        Conn.Dispose()
    '        dcExecProc.Dispose()
    '    End Try

    'End Function

    'Sub ShowFields(ByVal CategoryID As String)

    '    Dim Conn As New SqlConnection(modMain.ConnString)
    '    Dim daGetDets As New SqlDataAdapter(String.Format("select * from CategoryMaster where categoryid like '{0}'", CategoryID), Conn)
    '    Dim dsShow As New DataSet

    '    Try

    '        daGetDets.Fill(dsShow)

    '        txtCategory.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("CATEGORYNAME")), "", dsShow.Tables(0).Rows(0).Item("CATEGORYNAME"))
    '        txtCategoryID.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("CATEGORYID")), "", dsShow.Tables(0).Rows(0).Item("CATEGORYID"))
    '        txtDescription.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("DESCRIPTION")), "", dsShow.Tables(0).Rows(0).Item("DESCRIPTION"))
    '        txtLastItemCode.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("LASTITEMCODE")), "", dsShow.Tables(0).Rows(0).Item("LASTITEMCODE"))


    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
    '    Finally
    '        Conn.Dispose()
    '        daGetDets.Dispose()
    '        dsShow.Dispose()

    '    End Try


    'End Sub

    ' ''' <summary>
    ' ''' Its Load Grid Details
    ' ''' </summary>
    ' ''' <remarks></remarks>
    ' ''' 
    'Sub LoadGridDets()

    '    Dim Conn As New SqlConnection(modMain.ConnString)
    '    Dim daGetDets As New SqlDataAdapter("select CategoryID,Categoryname from CategoryMaster", Conn)
    '    Dim dsShow As New DataSet

    '    Try
    '        daGetDets.Fill(dsShow)

    '        gridCategory.DataSource = dsShow.Tables(0)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
    '    Finally
    '        Conn.Dispose()
    '        daGetDets.Dispose()
    '        dsShow.Dispose()
    '    End Try

    'End Sub

    'Function FieldValidation() As Boolean
    '    Return IIf(String.Compare(txtTaxCode.Text, "", False) = 0 Or String.Compare(txtDesc_Tax.Text, "", False) = 0, 0, 1)
    'End Function

    'Function GetCategoryCode() As String

    '    Dim Conn As New SqlConnection(ConnString)
    '    Dim dcGetCode As New SqlCommand()
    '    'Dim drGetDets As SqlDataReader


    '    'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
    '    'Dim dsGetDets As New DataSet

    '    Try

    '        Conn.Open()

    '        dcGetCode = New SqlCommand("spGetAutoNo", Conn)
    '        dcGetCode.CommandType = CommandType.StoredProcedure
    '        dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "Supplier"
    '        dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
    '        dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output


    '        'drGetDets = dcGetCode.ExecuteReader
    '        dcGetCode.ExecuteNonQuery()


    '        'If drGetDets.Read Then
    '        GetCategoryCode = dcGetCode.Parameters("@Currcode").Value
    '        'Else
    '        'GetSupplierCode = ""
    '        'End If


    '        'If Not IsDBNull(dsGetDets.Tables(0).Rows(0).Item(0)) Then
    '        '    GetSupplierCode = dsGetDets.Tables(0).Rows(0).Item(0).ToString
    '        'Else
    '        '    GetSupplierCode = ""
    '        'End If

    '        Return GetCategoryCode
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
    '        Return GetCategoryCode
    '    Finally
    '        Conn.Dispose()
    '        ' drGetDets.Close()

    '    End Try

    'End Function

    'Function InActiveCategory() As Boolean

    'End Function

#End Region



#End Region

End Class