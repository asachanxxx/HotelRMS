Imports System.Data.SqlClient


Public Class frmCosting

    Public Itemcode, Itemname, UOM, OrdQty As String
    Public frmGridRow As Double
#Region " Proc & Functions "

    Sub ClearFields()
        txtItemcode.Text = ""
        txtDescription.Text = ""

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter("select * from ItemCostMaster where Itemcode ='Nothing'", Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            grdItemMain.DataSource = dsShow.Tables(0)

            daGetDets.Dispose()
            dsShow.Dispose()

            '----------------------------

            daGetDets = New SqlDataAdapter("select * from ItemCostDetails where SubItemcode='Nothing'", Conn)
            daGetDets.Fill(dsShow)

            gridTemplate.DataSource = dsShow.Tables(0)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try


    End Sub

    ''' <summary>
    ''' Insert New Item
    ''' </summary>
    ''' <returns>True-Sucess,False-Failed</returns>
    ''' <remarks></remarks>
    Function InsertNewItem(ByVal Proc As String) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim Procedure As String

        If String.Compare(Proc, "Add", False) = 0 Then
            Procedure = "spItemCostAdd"
        Else
            Procedure = "spItemCostEdit"
        End If

        Dim dcExecProc As New SqlCommand()
        Dim TransIns As SqlTransaction


        Try
            Conn.Open()

            TransIns = Conn.BeginTransaction

            Dim sqlStr As String

            sqlStr = String.Format("Delete from ItemCostTemporary where CurrUser like '{0}'", CurrUser)

            dcExecProc = New SqlCommand(sqlStr, Conn)
            dcExecProc.Dispose()


            For i As Int16 = 0 To gvTemplate.RowCount - 2


                sqlStr = "INSERT INTO ITEMCostTEMPORARY (ItemCode,Description,CreateDate,UOMMaster,SubItemCode,SubItemName,RequiredQty,UOMDetails,CurrUser,FinalPrice,costPrice) VALUES("
                sqlStr += "@ItemCode,@Description,@CreateDate,@UOMMaster,@SubItemCode,@SubItemName,@RequiredQty,@UOMDetails,@CurrUser,@FinalPrice,@costPrice)"

                dcExecProc = New SqlCommand(sqlStr, Conn)
                dcExecProc.Transaction = TransIns

                With dcExecProc.Parameters
                    .Add("@Itemcode", SqlDbType.NVarChar, 50).Value = txtItemcode.Text
                    .Add("@Description", SqlDbType.NVarChar, 150).Value = txtDescription.Text
                    .Add("@CreateDate", SqlDbType.Date).Value = dtCreateDate.DateTime.Date
                    .Add("@UOMMaster", SqlDbType.NVarChar, 20).Value = cmbUOM.GetColumnValue("UOMCode")
                    .Add("@SubItemCode", SqlDbType.NVarChar).Value = gvTemplate.GetRowCellValue(i, "SubItemCode")
                    .Add("@SubItemName", SqlDbType.NVarChar).Value = gvTemplate.GetRowCellValue(i, "SubItemName")
                    .Add("@RequiredQty", SqlDbType.Float).Value = gvTemplate.GetRowCellValue(i, "RequiredQty")
                    .Add("@UOMDetails", SqlDbType.NVarChar).Value = gvTemplate.GetRowCellValue(i, "UOM")
                    .Add("@CurrUser", SqlDbType.NVarChar).Value = CurrUser
                    .Add("@FinalPrice", SqlDbType.Float).Value = txtFinalPrice.Text
                    .Add("@CostPrice", SqlDbType.Float).Value = gvTemplate.GetRowCellValue(i, "CostPrice")
                End With

                dcExecProc.ExecuteNonQuery()
            Next

            TransIns.Commit()
            dcExecProc.Dispose()

            '-----------------------------------------------------------------------

            dcExecProc = New SqlCommand(Procedure, Conn)
            dcExecProc.CommandType = CommandType.StoredProcedure

            With dcExecProc.Parameters
                .Add("@Itemcode", SqlDbType.NVarChar, 50).Value = txtItemcode.Text
                .Add("@CurrUser", SqlDbType.NVarChar).Value = CurrUser

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

    Sub ShowFields(ByVal Itemcode As String)

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets, daDets As New SqlDataAdapter()
        Dim dsShow, dsDets As New DataSet

        Try

            tabMain.SelectedTabPageIndex = 1

            daGetDets = New SqlDataAdapter(String.Format("select * from ItemCostMaster where IsNonInv <> 1 and Itemcode like '{0}'", Itemcode), Conn)
            daGetDets.Fill(dsShow)

            txtDescription.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Description")), "", dsShow.Tables(0).Rows(0).Item("Description"))
            txtItemcode.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Itemcode")), "", dsShow.Tables(0).Rows(0).Item("Itemcode"))
            dtCreateDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("CreateDate")), "", dsShow.Tables(0).Rows(0).Item("CreateDate"))
            cmbUOM.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("UOM")), "", dsShow.Tables(0).Rows(0).Item("UOM"))
            txtFinalPrice.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("FINALPRICE")), "0", dsShow.Tables(0).Rows(0).Item("FINALPRICE"))

            daDets = New SqlDataAdapter(String.Format("select * from ItemCostDetails where MainItemcode like '{0}'", Itemcode), Conn)
            daDets.Fill(dsDets)


            gridTemplate.DataSource = dsDets.Tables(0)

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
        Dim daGetDets As New SqlDataAdapter("select * from ItemCostMaster WHERE IsNonInv <> 1", Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            grdItemMain.DataSource = dsShow.Tables(0)

            daGetDets.Dispose()
            dsShow.Dispose()

            '----------------------------

            daGetDets = New SqlDataAdapter("select * from ItemCostDetails where SubItemcode='Nothing'", Conn)
            daGetDets.Fill(dsShow)

            gridTemplate.DataSource = dsShow.Tables(0)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Sub LoadCombos()
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try

            '----- Load UOM Master

            daGetDets = New SqlDataAdapter("select UOMCode,Description from UOMMaster", Conn)
            daGetDets.Fill(dsShow)

            With cmbUOM.Properties
                .DataSource = dsShow.Tables(0)
                .DisplayMember = "UOMCode"
                .ValueMember = "UOMCode"
                '.Columns(0).Width = 125
                '.Columns(1).Width = 275
                .PopupWidth = 400
            End With


            daGetDets.Dispose()
            dsShow.Dispose()

            '----- Load Supplier Master

            daGetDets = New SqlDataAdapter("select UOMCode,Description from UOMMaster", Conn)
            dsShow = New DataSet
            daGetDets.Fill(dsShow)

            With repcmbUOM
                .DataSource = dsShow.Tables(0)
                .DisplayMember = "UOMCode"
                .ValueMember = "UOMCode"
                '.Columns(0).Width = 125
                '.Columns(1).Width = 275
                .PopupWidth = 400
            End With

            daGetDets.Dispose()
            dsShow.Dispose()




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
                GetCodeLength = dsShow.Tables(0).Rows(0).Item("itemcodelength")
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
        Return IIf(String.Compare(txtItemcode.Text, "", False) = 0 Or String.Compare(txtDescription.Text, "", False) = 0 Or String.Compare(cmbUOM.Text, "", False) = 0 Or ItemcodeValid() = False, 0, 1)
    End Function

    Function InActiveItem(ByVal ItemCode As String) As Boolean
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim dcExec As New SqlCommand(String.Format("update ItemCostMaster set status = 0 where itemcode like '{0}'", ItemCode), Conn)

        Try
            Conn.Open()

            dcExec.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            dcExec.Dispose()
        End Try
    End Function

    Function ItemcodeValid() As Boolean

        Try
            'If gvItemDets.RowCount > 1 Then
            '    gvItemDets.DeleteRow(gvItemDets.RowCount)
            'End If

            Dim i As Int16
            For i = 0 To gvTemplate.RowCount - 2
                If IsDBNull(gvTemplate.GetRowCellValue(i, "SubItemCode")) Then
                    Throw New Exception("Itemcode can't be empty")
                ElseIf gvTemplate.GetRowCellValue(i, "SubItemCode") Is Nothing Then
                    Throw New Exception("Itemcode can't be empty")
                ElseIf IsDBNull(gvTemplate.GetRowCellValue(i, "RequiredQty")) Then
                    Throw New Exception("Required Qty can't be empty")

                End If
            Next

            If gvTemplate.RowCount = 1 Then
                Return False ' coz no row found
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        End Try

    End Function

    Function FindItemCost(ByVal ItemCode As String, ByVal ReqQty As Double) As Double
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter("select * from itemmaster where itemcode like '" & ItemCode & "'", Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count > 0 Then
                Return (ReqQty * IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("AvgCost")), 0, dsShow.Tables(0).Rows(0).Item("AvgCost")))
            Else
                Return 0
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try
    End Function

    Sub CalcFinalCost()

        Dim FinalCost As Double
        For i As Integer = 0 To gvTemplate.RowCount - 1
            FinalCost += IIf(IsDBNull(gvTemplate.GetRowCellValue(i, "CostPrice")), 0, gvTemplate.GetRowCellValue(i, "CostPrice"))
        Next

        txtFinalPrice.Text = FinalCost

    End Sub
#End Region

    Private Sub gvTemplate_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvTemplate.CellValueChanged
        If e.Column.FieldName = "SubItemCode" And String.IsNullOrEmpty(Itemcode) Then
            frmItemSelection.frmHandle = Me
            Me.frmGridRow = e.RowHandle
            frmItemSelection.Show()
            Me.Enabled = False

        ElseIf e.Column.FieldName = "RequiredQty" And Not String.IsNullOrEmpty(gvTemplate.GetRowCellValue(e.RowHandle, "SubItemCode")) Then

            '---- in this place we can give the cost price for sub item
            gvTemplate.SetRowCellValue(e.RowHandle, "CostPrice", FindItemCost(gvTemplate.GetRowCellValue(e.RowHandle, "SubItemCode"), gvTemplate.GetRowCellValue(e.RowHandle, "RequiredQty")))

        ElseIf e.Column.FieldName = "CostPrice" Then
            CalcFinalCost()

        End If

        ' CalcFinalCost()
    End Sub

    Private Sub frmItemTemplate_EnabledChanged(sender As Object, e As System.EventArgs) Handles Me.EnabledChanged
        If Me.Enabled Then
            gvTemplate.SetRowCellValue(frmGridRow, "SubItemCode", Itemcode)
            Itemcode = String.Empty

            gvTemplate.SetRowCellValue(frmGridRow, "SubItemName", Itemname)
            gvTemplate.SetRowCellValue(frmGridRow, "UOM", UOM)
            gvTemplate.SetRowCellValue(frmGridRow, "RequiredQty", 0)
            gvTemplate.SetRowCellValue(frmGridRow, "CostPrice", 0)

        End If
    End Sub

    Private Sub frmItemTemplate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGridDets()
        dtCreateDate.Text = Now.Date
        LoadCombos()

    End Sub

    Private Sub cmdNew_Click(sender As System.Object, e As System.EventArgs) Handles cmdNew.Click
        If String.Compare(cmdNew.Text, "New", False) = 0 Then

            ClearFields()
            cmdNew.Text = "Save"
            cmdEdit.Enabled = False
            cmdDelete.Enabled = False

            tabMain.SelectedTabPageIndex = 1
            tabMain.TabPages(0).PageEnabled = False

        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub
            End If

            If Not InsertNewItem("Add") Then
                Exit Sub
            End If

            MsgBox("Successfully Inserted...", , ErrTitle)

            tabMain.TabPages(0).PageEnabled = True
            cmdNew.Text = "New"
            cmdEdit.Enabled = True
            cmdDelete.Enabled = True
            LoadGridDets()
            tabMain.SelectedTabPageIndex = 0

        End If
    End Sub

    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click
        If String.Compare(cmdEdit.Text, "Edit", False) = 0 Then


            cmdEdit.Text = "Save"
            cmdNew.Enabled = False
            cmdDelete.Enabled = False

            tabMain.SelectedTabPageIndex = 1
            txtItemcode.Properties.ReadOnly = True
            tabMain.TabPages(0).PageEnabled = False
        Else

            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub
            End If

            If Not InsertNewItem("Edit") Then
                Exit Sub
            End If

            MsgBox("Successfully Update...", , ErrTitle)

            cmdEdit.Text = "Edit"
            cmdNew.Enabled = True
            cmdDelete.Enabled = True

            txtItemcode.Properties.ReadOnly = False

            tabMain.TabPages(0).PageEnabled = True
            tabMain.SelectedTabPageIndex = 0

        End If
    End Sub

    Private Sub gvItemMain_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gvItemMain.DoubleClick
        ShowFields(gvItemMain.GetFocusedRowCellValue("ItemCode"))
    End Sub

    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click
        If txtItemcode.Text = "" Then
            MsgBox("Select item to in activate", MsgBoxStyle.Critical, ErrTitle)
        Else
            Dim msgres As MsgBoxResult = MsgBox("Once item inactivated, you can't find in Item List in any process,Continue ?")
            If msgres = MsgBoxResult.Yes Then
                InActiveItem(txtItemcode.Text)
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub gvTemplate_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvTemplate.InitNewRow

    End Sub

    Private Sub gvTemplate_RowCountChanged(sender As Object, e As System.EventArgs) Handles gvTemplate.RowCountChanged
        CalcFinalCost()
    End Sub
End Class
