Imports System.Data.SqlClient

Public Class frmItemAdjustment

    Private Sub frmItemAdjustment_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGridMain()
        LoadCombos()

        dtAdjDate.Text = Now.Date

        lblFoundrecords.Text = gvMain.RowCount & "# Records Found"

        txtAdjNo.Text = GetAdjCode()

        txtAdjNo.Properties.ReadOnly = True
        txtAvgCost.Properties.ReadOnly = True
        txtCategory.Properties.ReadOnly = True
        txtItemCode.Properties.ReadOnly = True
        txtDescription.Properties.ReadOnly = True

    End Sub

#Region " Procs & Funcs "


    Sub ClearFields()

        txtAvgCost.Text = "0"
        txtCategory.Text = ""
        txtDescription.Text = ""
        txtItemCode.Text = ""
        txtNewAvgCost.Text = "0"
        txtProcessQty.Text = "0"

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter(("select * from vwItemLocWise where Itemcode like 'Nothing'"), Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            gcAdjust.DataSource = dsShow.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Sub ShowFields(ByVal Itemcode As String)

        Dim Conn As New SqlConnection(modMain.ConnString)

        'Dim daGetDets As New SqlDataAdapter(String.Format("select * from vwItemLocWise where Itemcode like '{0}' and status=1", Itemcode), Conn)
        Dim dsShow As New DataSet

        Dim daMainDets As New SqlDataAdapter(String.Format("select * from ItemMaster where itemcode like '{0}'", Itemcode), Conn)
        Dim daGetDets As New SqlDataAdapter(String.Format("select * from vwItemLocWise where Itemcode like '{0}' and status=1 and location='" & cmbLocation.Text & "'", Itemcode), Conn)
        Dim dsMDets As New DataSet

        Try

            daMainDets.Fill(dsMDets)
            daGetDets.Fill(dsShow)



            txtAvgCost.Text = IIf(IsDBNull(dsMDets.Tables(0).Rows(0).Item("Avgcost")), "", dsMDets.Tables(0).Rows(0).Item("Avgcost"))
            txtCategory.Text = IIf(IsDBNull(dsMDets.Tables(0).Rows(0).Item("Category")), "", dsMDets.Tables(0).Rows(0).Item("Category"))
            txtDescription.Text = IIf(IsDBNull(dsMDets.Tables(0).Rows(0).Item("Description")), "", dsMDets.Tables(0).Rows(0).Item("Description"))
            txtItemCode.Text = IIf(IsDBNull(dsMDets.Tables(0).Rows(0).Item("Itemcode")), "", dsMDets.Tables(0).Rows(0).Item("Itemcode"))
            txtNewAvgCost.Text = 0 ' IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Avgcost")), "", dsShow.Tables(0).Rows(0).Item("Avgcost"))
            txtProcessQty.Text = 0 ' IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Avgcost")), "", dsShow.Tables(0).Rows(0).Item("Avgcost"))
            txtTotShots.Text = 0 ' IIf(IsDBNull(dsMDets.Tables(0).Rows(0).Item("TotShots")), "0", dsMDets.Tables(0).Rows(0).Item("TotShotsS"))
            'daGetDets.Fill(dsShow)

            chkIsSplit.Checked = True
            chkIsSplit.Checked = IIf(IsDBNull(dsMDets.Tables(0).Rows(0).Item("IsSplit")), 0, dsMDets.Tables(0).Rows(0).Item("IsSplit"))

            chkIsNonInv.Checked = True
            chkIsNonInv.Checked = IIf(IsDBNull(dsMDets.Tables(0).Rows(0).Item("IsNonInv")), 0, dsMDets.Tables(0).Rows(0).Item("IsNonInv"))

            '------------------------------

            'daGetDets.Fill(dsShow)

            gcAdjust.DataSource = dsShow.Tables(0) ' dsMDets.Tables(0) ' dsShow.Tables(0)

            If IsDBNull(dsMDets.Tables(0).Rows(0).Item("TotShots")) Then
                txtTotShots.Properties.ReadOnly = True
            ElseIf dsMDets.Tables(0).Rows(0).Item("TotShots") = 0 Then
                txtTotShots.Properties.ReadOnly = True
            Else
                txtTotShots.Properties.ReadOnly = False
            End If

            If gvAdjust.GetRowCellValue(0, "TotShots") >= 0 Then
                gvAdjust.Columns("TotShots").Visible = True
            Else
                gvAdjust.Columns("TotShots").Visible = False
            End If

            'If dsShow.Tables(0).Rows.Count = 0 Then
            '    ClearFields()
            '    Exit Sub
            'End If



            tabMain.SelectedTabPageIndex = 1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            'daGetDets.Dispose()
            'dsShow.Dispose()
            dsMDets.Dispose()
            daMainDets.Dispose()


        End Try


    End Sub

    Sub LoadGridMain()

        'GROUP BY dbo.ItemInventory.Itemcode, dbo.ItemInventory.Itemname, dbo.ItemMaster.Category, dbo.ItemMaster.Avgcost, dbo.ItemInventory.Stock, dbo.ItemInventory.Location, 
        'dbo.ItemMaster.Status()

        Dim Conn As New SqlConnection(modMain.ConnString)
        'Dim sqlstring As String = "select dbo.ItemInventory.Itemcode, dbo.ItemInventory.Itemname, dbo.ItemMaster.Category, dbo.ItemMaster.Avgcost, sum(dbo.ItemInventory.Stock) as stock,dbo.ItemMaster.Status from vwItemLocWise where status=1 GROUP BY dbo.ItemInventory.Itemcode, dbo.ItemInventory.Itemname, dbo.ItemMaster.Category, dbo.ItemMaster.Avgcost, dbo.ItemInventory.Stock,dbo.ItemMaster.Status "


        Dim daGetDets As New SqlDataAdapter("select * from ItemMaster where status=1  and IsNonInv = 0", Conn)
        Dim dsShow As New DataSet

        '--- load outlet cmbo


        Try
            daGetDets.Fill(dsShow)

            gcMain.DataSource = dsShow.Tables(0)



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
        Dim daGetDets, daGridLookup As New SqlDataAdapter()
        Dim dsFrom, dsShow, dsGridLookup As New DataSet

        Try

            '----- Load Department Master

            daGetDets = New SqlDataAdapter("select DepartmentID,Department from DepartmentMaster", Conn)
            daGetDets.Fill(dsFrom)

            With cmbLocation.Properties
                .DataSource = dsFrom.Tables(0)
                .DisplayMember = "Department"
                .ValueMember = "DepartmentID"
                .AutoSearchColumnIndex = 0
                .Columns(0).Width = 125
                .Columns(1).Width = 275
                .PopupWidth = 400
                'cmbFrom.Text = "Ware House"
                'cmbFrom.Enabled = False
                'cmbFrom.SelectedText = "Ware House"
                cmbLocation.EditValue = "Ware House"
            End With

            daGetDets.Dispose()
            dsShow.Dispose()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
            daGridLookup.Dispose()
            dsGridLookup.Dispose()
        End Try
    End Sub


    Function FieldValidation() As Boolean

        txtTotShots.Text = IIf(txtTotShots.Text = "", 0, txtTotShots.Text)
        txtProcessQty.Text = IIf(txtProcessQty.Text = "", 0, txtProcessQty.Text)

        If rbAdd.Checked Or rbDeduct.Checked Then
            If txtAdjNo.Text = "" Then
                Return False
            ElseIf txtProcessQty.Text = "0" And txtTotShots.Text = "0" Then
                Return False
            End If
        Else
            If txtAdjNo.Text = "" Or txtNewAvgCost.Text = "0" Or txtNewAvgCost.Text = "" Then
                Return False

                'ElseIf chkIsSplit.Checked Then
                '    Return False


            End If
        End If

        Return True

    End Function

    Function InsertNewItem() As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Const Procedure As String = "spItemAdjustment"

        'If String.Compare(Proc, "Add", False) = 0 Then
        ' Else
        'Procedure = "spItemMasterEdit"
        'End If

        Dim dcExecProc As New SqlCommand(Procedure, Conn)

        Try
            Conn.Open()

            dcExecProc.CommandType = CommandType.StoredProcedure

            With dcExecProc.Parameters

                .Add("@AdjustNo", SqlDbType.NVarChar, 50).Value = txtAdjNo.Text
                .Add("@AdjDate", SqlDbType.DateTime, 50).Value = dtAdjDate.Text
                .Add("@Itemcode", SqlDbType.NVarChar, 50).Value = txtItemCode.Text
                .Add("@Location", SqlDbType.NVarChar, 100).Value = cmbLocation.Text

                If rbAdd.Checked Then
                    .Add("@PROCQTY", SqlDbType.Float).Value = txtProcessQty.Text
                ElseIf rbDeduct.Checked Then
                    .Add("@PROCQTY", SqlDbType.Float).Value = -1 * Val(txtProcessQty.Text)
                End If

                If rbValue.Checked Then
                    .Add("@NEWCOST", SqlDbType.Float).Value = txtNewAvgCost.Text
                    .Add("@PROCQTY", SqlDbType.Float).Value = 0
                Else
                    .Add("@NEWCOST", SqlDbType.Float).Value = 0
                    '.Add("@PROCQTY", SqlDbType.Float).Value = 0

                End If

                .Add("@Type", SqlDbType.NVarChar, 50).Value = IIf(rbValue.Checked, "Value", "Stock")


                '.Add("@PROCSHOTS", SqlDbType.Int, 50).Value = IIf(txtTotShots.Text = "", "0", txtTotShots.Text)
                txtTotShots.Text = IIf(txtTotShots.Text = "", "0", txtTotShots.Text)

                If rbAdd.Checked Then
                    .Add("@PROCSHOTS", SqlDbType.Int).Value = txtTotShots.Text
                ElseIf rbDeduct.Checked Then

                    .Add("@PROCSHOTS", SqlDbType.Int).Value = -1 * Val(txtTotShots.Text)
                Else
                    .Add("@PROCSHOTS", SqlDbType.Int).Value = 0
                End If

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

    Function GetAdjCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "Adj"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output

            dcGetCode.ExecuteNonQuery()

            GetAdjCode = dcGetCode.Parameters("@Currcode").Value


            Return GetAdjCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function

    Function SearchItem() As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()

        Dim sqlStr As String = ""

        Dim dsShow As New DataSet

        Try
            If optbycode.Checked Then
                sqlStr = String.Format("Select * from ItemMaster where itemcode like '{0}%' order by itemcode", txtsearch.Text)
            Else
                sqlStr = String.Format("Select * from ItemMaster where status=1 and description like '%{0}%' order by itemcode", txtsearch.Text)
            End If

            daGetDets = New SqlDataAdapter(sqlStr, Conn)
            daGetDets.Fill(dsShow)

            gcMain.DataSource = dsShow.Tables(0)
            lblFoundrecords.Text = String.Format(" {0} ", gvMain.RowCount)

            Return 1
            'Return GetCodeLength()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try
    End Function

#End Region

    Private Sub cmdUpdate_Click(sender As System.Object, e As System.EventArgs) Handles cmdUpdate.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Item Adjustment", "Add")

        If CheckAccess = True Then



            If Not rbAdd.Checked And Not rbDeduct.Checked And Not rbValue.Checked Then
                MsgBox("Please Select one of Action(Add/Deduct Items or Update Cost Price).", MsgBoxStyle.Critical, ErrTitle)
                Exit Sub
            End If

            If FieldValidation() Then
                If InsertNewItem() Then

                    MsgBox(IIf(rbValue.Checked, "Value Update Successfull", "Qty Update Succesfully"))

                    ShowFields(txtItemCode.Text)
                    LoadGridMain()
                End If
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub rbCommon_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbAdd.CheckedChanged, rbDeduct.CheckedChanged, rbValue.CheckedChanged

        If rbAdd.Checked Or rbDeduct.Checked Then
            gbStock.Enabled = True
            gbCost.Enabled = False
        Else
            gbCost.Enabled = True
            gbStock.Enabled = False
        End If

    End Sub

    Private Sub gvMain_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gvMain.DoubleClick
        If gvMain.GetRowCellValue(gvMain.FocusedRowHandle, "Itemcode") Is Nothing Then 'verification for suppliercode is blank or not
            Exit Sub
        End If

        tabMain.SelectedTabPageIndex = 1
        ShowFields(gvMain.GetRowCellValue(gvMain.FocusedRowHandle, "Itemcode"))
    End Sub

    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        Me.Close()

    End Sub


    Private Sub chkIsSplit_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkIsSplit.CheckedChanged
        If chkIsSplit.Checked Then
            If cmbLocation.Text = "Ware House" Then
                txtProcessQty.Enabled = True
                txtTotShots.Enabled = False
            Else
                txtProcessQty.Enabled = False
                txtTotShots.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmbLocation_ListChanged(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles cmbLocation.ListChanged
        
    End Sub

    Private Sub cmbLocation_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbLocation.EditValueChanged
        If txtItemCode.Text = "" Then
            Exit Sub

        End If
        ShowFields(txtItemCode.Text)

        If chkIsSplit.Checked Then
            If cmbLocation.Text = "Ware House" Then
                txtProcessQty.Enabled = True
                txtTotShots.Enabled = False
            Else
                txtProcessQty.Enabled = False
                txtTotShots.Enabled = True
            End If
        Else
            txtProcessQty.Enabled = True
            txtTotShots.Enabled = False
        End If
    End Sub

    Private Sub chkIsNonInv_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkIsNonInv.CheckedChanged
        If chkIsSplit.Checked Then
            If cmbLocation.Text = "Ware House" Then
                txtProcessQty.Enabled = False
                txtTotShots.Enabled = False
                'txtNewAvgCost.Enabled = False
            Else
                txtProcessQty.Enabled = False
                txtTotShots.Enabled = True
                'txtNewAvgCost.Enabled = False
            End If

        End If
    End Sub

    Private Sub txtsearch_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.EditValueChanged
        SearchItem()
    End Sub

    Private Sub txtTotShots_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtTotShots.EditValueChanged

    End Sub

    Private Sub txtProcessQty_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtProcessQty.EditValueChanged

    End Sub

    Private Sub txtProcessQty_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtProcessQty.KeyDown
        If e.KeyCode = 109 Or e.KeyCode = 189 Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtTotShots_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTotShots.KeyDown
        If e.KeyCode = 109 Or e.KeyCode = 189 Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub frmItemAdjustment_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click

    End Sub
End Class