Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmMinibarItemSelect

    Public frmHandle As New XtraForm
    Public InvLocation As String = ""
    Public MBTCode As String = ""



    Private Sub frmItemSelection_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'frmHandle.Enabled = True
        frmMinibarTransfer.Enabled = True
    End Sub 'this ll handles the form

    Private Sub frmItemSelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadGridDets("rbItemMaster")

    End Sub

    Sub LoadGridDets(ByVal TypeName As String)

        Dim sqlstr As String = ""
        Dim Conn As New SqlConnection(modMain.ConnString)

        If TypeName <> "rbItemMaster" Then
            sqlstr = "select * from ItemTemplateMaster"
        Else
            sqlstr = "select * from vwItemSelection where status=1 and location ='House Keeping'"
        End If

        Dim daGetDets As New SqlDataAdapter(sqlstr, Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            If TypeName <> "rbItemMaster" Then
                gridItemTemplate.DataSource = dsShow.Tables(0)
            Else
                gridItemSelection.DataSource = dsShow.Tables(0)
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Private Sub gvItemSelection_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvItemSelection.DoubleClick

        ' Call gvItemSelection_KeyDown(Nothing, New KeyEventArgs(Keys.Enter))
    End Sub

    Private Sub gvItemSelection_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvItemSelection.KeyDown
        If e.KeyCode = Keys.Enter Then

            '---- insert selected item details to temp table...

            Call InsertItemtoTemp(gvItemSelection.GetFocusedRowCellValue("Itemcode"))

            'If frmHandle.Name = "frmMinibarTransfer" Then
            '    frmMinibarTransfer.Itemcode = gvItemSelection.GetFocusedRowCellValue("Itemcode")
            '    frmMinibarTransfer.Itemname = gvItemSelection.GetFocusedRowCellValue("Description")
            '    frmMinibarTransfer.CurrQty = gvItemSelection.GetFocusedRowCellValue("Stocks")
            '    frmMinibarTransfer.Templatecode = ""
            Me.Close()

            'End If


        End If

    End Sub

    Private Sub rbItemMaster_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbItemMaster.CheckedChanged, rbItemTemplate.CheckedChanged

        Dim rbGen As RadioButton = sender

        If rbItemMaster.Checked Then
            gridItemTemplate.Visible = False
            gridItemSelection.Visible = True

            LoadGridDets("rbItemMaster")
        Else
            gridItemTemplate.Visible = True
            gridItemSelection.Visible = False

            LoadGridDets("rbItemTemplate")
        End If
    End Sub

    Private Sub gvItemTemplate_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gvItemTemplate.KeyDown
        'If frmHandle.Name = "frmMinibarTransfer" Then
        '    frmMinibarTransfer.Itemcode = ""
        '    frmMinibarTransfer.Itemname = ""
        '    frmMinibarTransfer.CurrQty = ""
        '    frmMinibarTransfer.Templatecode = gvItemTemplate.GetFocusedRowCellValue("ItemCode")
        '    Me.Close()
        'End If

        InsertItemtoTemp(gvItemTemplate.GetFocusedRowCellValue("ItemCode"))
        Me.Close()

    End Sub


    Sub InsertItemtoTemp(ByVal Itemcode As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcIns, dcSearch As New SqlCommand
        Dim TransIns As SqlTransaction
        Dim IsTransError As Boolean = False
        Dim sqlStr As String = String.Empty


        Dim daTpl As New SqlDataAdapter()
        Dim dsGetAll As New DataSet

        Try
            Conn.Open()



            If rbItemMaster.Checked Then

                TransIns = Conn.BeginTransaction

                dcIns = New SqlCommand("spMBTTempInsert", Conn)
                dcIns.CommandType = CommandType.StoredProcedure

                IsTransError = True
                dcIns.Transaction = TransIns

                dcIns.Parameters.Add("@MBTCode", SqlDbType.NVarChar).Value = MBTCode
                dcIns.Parameters.Add("@Itemcode", SqlDbType.NVarChar).Value = Itemcode
                dcIns.Parameters.Add("@Insert", SqlDbType.Bit).Value = 1
                dcIns.Parameters.Add("@CurrUser", SqlDbType.NVarChar).Value = CurrUser

                dcIns.ExecuteNonQuery()

            Else

                dcSearch = New SqlCommand(String.Format("select * from ItemTemplateDetails where MainItemCode like '{0}'", Itemcode), Conn)
                daTpl = New SqlDataAdapter()

                daTpl.SelectCommand = dcSearch
                daTpl.Fill(dsGetAll)

                'gridItemDets.DataSource = Nothing


                TransIns = Conn.BeginTransaction

                For i As Int16 = 0 To dsGetAll.Tables(0).Rows.Count - 1

                    dcIns = New SqlCommand("spMBTTempInsert", Conn)
                    dcIns.CommandType = CommandType.StoredProcedure

                    IsTransError = True
                    dcIns.Transaction = TransIns

                    dcIns.Parameters.Add("@MBTCode", SqlDbType.NVarChar).Value = MBTCode
                    dcIns.Parameters.Add("@Itemcode", SqlDbType.NVarChar).Value = dsGetAll.Tables(0).Rows(i).Item("SubItemCode")
                    dcIns.Parameters.Add("@Insert", SqlDbType.Bit).Value = 1 'dsGetAll.Tables(0).Rows(i).Item("Itemcode")
                    dcIns.Parameters.Add("@CurrUser", SqlDbType.NVarChar).Value = CurrUser

                    dcIns.ExecuteNonQuery()
                Next



            End If


            TransIns.Commit()
            IsTransError = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)

        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try

        If IsTransError Then
            TransIns.Rollback()
        End If

        TransIns.Dispose()
    End Sub

    Function SearchItem() As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()

        Dim sqlStr As String = ""


        Dim dsShow As New DataSet

        Try

            If rbItemMaster.Checked Then
                'String.Format("select * from vwItemSelection where itemcode like '{0}%' and status=1 and location ='House Keeping'", txtsearch.Text)

                If optbycode.Checked Then
                    sqlStr = String.Format("select * from vwItemSelection where itemcode like '{0}%' and status=1 and location ='House Keeping'", txtsearch.Text)
                Else
                    sqlStr = String.Format("select * from vwItemSelection where description like '{0}%' and status=1 and location ='House Keeping'", txtsearch.Text)
                End If

                'sqlStr = "select * from vwItemSelection where status=1 and location ='House Keeping'"

                daGetDets = New SqlDataAdapter(sqlStr, Conn)
                daGetDets.Fill(dsShow)

                gridItemSelection.DataSource = dsShow.Tables(0)

            Else

                If optbycode.Checked Then
                    sqlStr = String.Format("select * from ItemTemplateMaster where itemcode like '{0}%'", txtsearch.Text)
                Else
                    sqlStr = String.Format("select * from ItemTemplateMaster where description like '{0}%'", txtsearch.Text)
                End If

                daGetDets = New SqlDataAdapter(sqlStr, Conn)
                daGetDets.Fill(dsShow)

                gridItemTemplate.DataSource = dsShow.Tables(0)

            End If

            

            ' Return GetCodeLength()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try
    End Function

    Private Sub txtsearch_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtsearch.EditValueChanged
        SearchItem()
    End Sub

End Class