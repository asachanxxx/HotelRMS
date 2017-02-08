Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports System.Xml


Public Class frmItemSelection

    Public frmHandle As New XtraForm
    Public InvLocation As String = ""
    Public PubMP As String = ""

 

    Private Sub frmItemSelection_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmHandle.Enabled = True
    End Sub 'this ll handles the form

    Private Sub frmItemSelection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        txtsearch.Focus()

        LoadGridDets()



        frmHandle.Enabled = False

       
        txtsearch.Focus()

    End Sub

    Sub LoadGridDets()

        Dim sqlstr As String = ""
        Dim Conn As New SqlConnection(modMain.ConnString)

        gvItemSelection.Columns("TotShots").VisibleIndex = -1

        If frmHandle.Name = "frmGIN" Then
            sqlstr = String.Format("select * from vwItemSelection where location like '{0}' and  status=1 and IsNonInv=0", InvLocation)
        ElseIf frmHandle.Name = "frmKitchenStockMainvb" Then
            sqlstr = String.Format("select * from vwItemSelection where location like '{0}' and  status=1", InvLocation)

        ElseIf frmHandle.Name = "frmItemReq" Then
            sqlstr = String.Format("select * from vwItemSelection where status=1 and IsNonInv=0")

        ElseIf frmHandle.Name = "frmCoktailItemCreation" Then

            'qui: is all cocktail items is splitted ?
            gvItemSelection.Columns("TotShots").Visible = True
            gvItemSelection.Columns("TotShots").VisibleIndex = 3
            sqlstr = String.Format("select * from vwItemSelectionWithShots where location like '{0}' and status=1", InvLocation)
        ElseIf frmHandle.Name = "frmKOT_BOT_Billing" Then

            sqlstr = String.Format("select * from vwItemSelection where location like '{0}' and status=1 or (IsNonInv = 1 and status=1)", InvLocation)
            'sqlstr = String.Format("select * from vwItemSelection where location like '{0}' and status=1 or IsNonInv = 1", InvLocation)
            ' sqlstr = String.Format("select * from vwItemSelection where location like '{0}' or location is null and status=1 or IsNonInv = 1", InvLocation)
        Else
            sqlstr = "select * from ItemMaster where  status=1"
        End If

        Dim daGetDets As New SqlDataAdapter(sqlstr, Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            gridItemSelection.DataSource = dsShow.Tables(0)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Function SearchItem() As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()

        Dim sqlStr As String = ""

        Dim dsShow As New DataSet

        Try
            If optbycode.Checked Then

                'If TypeName() <> "rbItemMaster" Then
                '    sqlStr = "select * from ItemTemplateMaster"
                'Else
                '    sqlStr = "select * from vwItemSelection where status=1 and location ='House Keeping'"
                'End If

                If frmHandle.Name = "frmGIN" Then
                    sqlStr = String.Format("select * from vwItemSelection where itemcode like '{0}%' and location like '{1}' and  status=1 and IsNonInv=0", txtsearch.Text, InvLocation)
                ElseIf frmHandle.Name = "frmKitchenStockMainvb" Then
                    sqlStr = String.Format("select * from vwItemSelection where itemcode like '{0}%' and location like '{1}' and  status=1", txtsearch.Text, InvLocation)


                ElseIf frmHandle.Name = "frmCoktailItemCreation" Then
                    'qui: is all cocktail items is splitted ?
                    sqlStr = String.Format("select * from vwItemSelectionWithShots where itemcode like '{0}%' and location like '{1}' and status=1", txtsearch.Text, InvLocation)

                  


                ElseIf frmHandle.Name = "frmItemReq" Then
                    'qui: is all cocktail items is splitted ?
                    sqlStr = String.Format("Select * from ItemMaster where itemcode like '{0}%' and status=1 and IsNonInv=0 order by itemcode", txtsearch.Text)




                    'ElseIf frmHandle.Name = "frmKOT_BOT_Billing" Then
                    '    sqlStr = String.Format("select * from vwItemSelection where itemcode like '{0}%' and location like '{1}' and status=1 or IsNonInv = 1", txtsearch.Text, InvLocation)


                ElseIf frmHandle.Name = "frmKOT_BOT_Billing" Then
                    'sqlStr = String.Format("select * from vwItemSelection where itemcode like '{0}%' and location like '{1}' and status=1 or IsNonInv = 1", txtsearch.Text, InvLocation)

                    ' sqlStr = String.Format("select aa.* from (select * from vwItemSelection where location like '{1}' and status=1 or IsNonInv = 1)  as aa where aa.itemcode like '{0}%'", txtsearch.Text, InvLocation)

                    sqlStr = String.Format("select aa.* from (select * from vwItemSelection where location like '{1}' and status=1 or (IsNonInv = 1 and status=1))  as aa where aa.itemcode like '{0}%'", txtsearch.Text, InvLocation)




                Else
                    ' sqlStr = String.Format("select * from ItemMaster where  status=1 and itemcode like '{0}%' order by itemcode", txtsearch.Text)

                    'sqlStr = String.Format("select aa.* from (select * from vwItemSelection where location like '{1}' and status=1 or IsNonInv = 1)  as aa where aa.itemcode like '{0}%'", txtsearch.Text, InvLocation)

                    sqlStr = String.Format("select aa.* from (select * from vwItemSelection where location like '{1}' and status=1 or (IsNonInv = 1 and status=1))  as aa where aa.itemcode like '{0}%'", txtsearch.Text, InvLocation)


                End If

                ''sqlStr = String.Format("Select * from ItemMaster where itemcode like '{0}%' order by itemcode", txtsearch.Text)


            Else

                If frmHandle.Name = "frmGIN" Then
                    sqlStr = String.Format("select * from vwItemSelection where description like '%{0}%' and location like '{1}' and  status=1 and IsNonInv=0", txtsearch.Text, InvLocation)
                ElseIf frmHandle.Name = "frmKitchenStockMainvb" Then
                    sqlStr = String.Format("select * from vwItemSelection where description like '%{0}%' and location like '{1}' and  status=1", txtsearch.Text, InvLocation)

                ElseIf frmHandle.Name = "frmCoktailItemCreation" Then
                    'qui: is all cocktail items is splitted ?
                    sqlStr = String.Format("select * from vwItemSelectionWithShots where description like '%{0}%' and location like '{1}' and status=1", txtsearch.Text, InvLocation)







                ElseIf frmHandle.Name = "frmItemReq" Then
                    'qui: is all cocktail items is splitted ?
                    sqlStr = String.Format("Select * from ItemMaster where description like '%{0}%' and status=1 and IsNonInv=0  order by itemcode", txtsearch.Text)



                    'ElseIf frmHandle.Name = "frmKOT_BOT_Billing" Then
                    '    sqlStr = String.Format("select * from vwItemSelection where description like '{0}%' and location like '{1}' and status=1 or IsNonInv = 1", txtsearch.Text, InvLocation)

                ElseIf frmHandle.Name = "frmKOT_BOT_Billing" Then

                    sqlStr = String.Format("select aa.* from (select * from vwItemSelection where location like '{1}' and status=1 or (IsNonInv = 1 and status=1))  as aa where aa.description like '%{0}%'", txtsearch.Text, InvLocation)

                    ' sqlStr = String.Format("select aa.* from (select * from vwItemSelection where location like '{1}' and status=1 or IsNonInv = 1)  as aa where aa.description like '%{0}%'", txtsearch.Text, InvLocation)

                    ' select  aa.* from (select * from vwItemSelection where location like 'Coffee Shop' and status=1 or IsNonInv = 1)  as aa where aa.description like 'l%'

                Else
                    'sqlStr = String.Format("select * from ItemMaster where  status=1 and description like '{0}%' order by itemcode", txtsearch.Text)

                    ' sqlStr = String.Format("select aa.* from (select * from vwItemSelection where location like '{1}' and status=1 or IsNonInv = 1)  as aa where aa.description like '%{0}%'", txtsearch.Text, InvLocation)

                    sqlStr = String.Format("select aa.* from (select * from vwItemSelection where location like '{1}' and  status=1 or (IsNonInv = 1 and status=1))   as aa where aa.description like '%{0}%'", txtsearch.Text, InvLocation)


                End If

                'sqlStr = String.Format("Select * from ItemMaster where description like '{0}%' order by itemcode", txtsearch.Text)
            End If

            daGetDets = New SqlDataAdapter(sqlStr, Conn)
            daGetDets.Fill(dsShow)

            gridItemSelection.DataSource = dsShow.Tables(0)

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


    Private Sub gvItemSelection_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvItemSelection.DoubleClick
       
        ' Call gvItemSelection_KeyDown(Nothing, New KeyEventArgs(Keys.Enter))
    End Sub

    Private Sub gvItemSelection_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvItemSelection.KeyDown
        If e.KeyCode = Keys.Enter Then
            If frmHandle.Name = "frmItemReq" Then
                frmItemReq.Itemcode = gvItemSelection.GetFocusedRowCellValue("Itemcode")
                frmItemReq.Itemname = gvItemSelection.GetFocusedRowCellValue("Description")
                frmItemReq.CurrQty = IIf(IsDBNull(gvItemSelection.GetFocusedRowCellValue("Stocks")), 0, gvItemSelection.GetFocusedRowCellValue("Stocks"))

                Me.Close()

            ElseIf frmHandle.Name = "frmGIN" Then

                frmGIN.Itemcode = gvItemSelection.GetFocusedRowCellValue("Itemcode")
                frmGIN.Itemname = gvItemSelection.GetFocusedRowCellValue("Description")
                frmGIN.CurrQty = gvItemSelection.GetFocusedRowCellValue("Stocks")
                Me.Close()

            ElseIf frmHandle.Name = "frmItemTemplate" Then
                frmItemTemplate.Itemcode = gvItemSelection.GetFocusedRowCellValue("Itemcode")
                frmItemTemplate.Itemname = gvItemSelection.GetFocusedRowCellValue("Description")
                frmItemTemplate.UOM = gvItemSelection.GetFocusedRowCellValue("UOM")
                Me.Close()
            ElseIf frmHandle.Name = "frmKitchenStockMainvb" Then

                frmKitchenStockMainvb.Itemcode = gvItemSelection.GetFocusedRowCellValue("Itemcode")
                frmKitchenStockMainvb.Itemname = gvItemSelection.GetFocusedRowCellValue("Description")
                frmKitchenStockMainvb.CurrQty = gvItemSelection.GetFocusedRowCellValue("Stocks")
                Me.Close()


            ElseIf frmHandle.Name = "frmCosting" Then
                frmCosting.Itemcode = gvItemSelection.GetFocusedRowCellValue("Itemcode")
                frmCosting.Itemname = gvItemSelection.GetFocusedRowCellValue("Description")
                frmCosting.UOM = gvItemSelection.GetFocusedRowCellValue("UOM")
                Me.Close()


            ElseIf frmHandle.Name = "frmCoktailItemCreation" Then
                frmCoktailItemCreation.Itemcode = gvItemSelection.GetFocusedRowCellValue("Itemcode")
                frmCoktailItemCreation.Itemname = gvItemSelection.GetFocusedRowCellValue("Description")
                frmCoktailItemCreation.UOM = gvItemSelection.GetFocusedRowCellValue("UOM")
                Me.Close()

            ElseIf frmHandle.Name = "frmKOT_BOT_Billing" Then



                frmKOT_BOT_Billing.Itemcode = gvItemSelection.GetFocusedRowCellValue("Itemcode")
                frmKOT_BOT_Billing.Itemname = gvItemSelection.GetFocusedRowCellValue("BillingDesc")

                ' frmKOT_BOT_Billing.Itemname = gvItemSelection.GetFocusedRowCellValue("Description")

                frmKOT_BOT_Billing.Itemprice = gvItemSelection.GetFocusedRowCellValue("Itemprice")









                If IsNonInv(gvItemSelection.GetFocusedRowCellValue("Itemcode")) Then
                    frmKOT_BOT_Billing.TotQty = -1
                Else

                    If gvItemSelection.GetFocusedRowCellValue("IsSplit") = True Then

                        frmKOT_BOT_Billing.TotQty = IIf(IsDBNull(gvItemSelection.GetFocusedRowCellValue("TotShots")), 0, gvItemSelection.GetFocusedRowCellValue("TotShots"))

                    Else

                        frmKOT_BOT_Billing.TotQty = IIf(IsDBNull(gvItemSelection.GetFocusedRowCellValue("Stocks")), 0, gvItemSelection.GetFocusedRowCellValue("Stocks"))
                    End If








                End If
                Me.Close()
            ElseIf frmHandle.Name = "DirectPurchase" Then

                DirectPurchase.Itemcode = gvItemSelection.GetFocusedRowCellValue("Itemcode")
                DirectPurchase.Itemname = gvItemSelection.GetFocusedRowCellValue("Description")

                '------------ADDED BY RASHAD 
                DirectPurchase.Itemprice = gvItemSelection.GetFocusedRowCellValue("Itemprice")
                If IsNonInv(gvItemSelection.GetFocusedRowCellValue("Itemcode")) Then
                    DirectPurchase.TotQty = -1

                Else


                    If gvItemSelection.GetFocusedRowCellValue("IsSplit") = True Then

                        DirectPurchase.TotQty = IIf(IsDBNull(gvItemSelection.GetFocusedRowCellValue("TotShots")), 0, gvItemSelection.GetFocusedRowCellValue("TotShots"))

                    Else

                        DirectPurchase.TotQty = IIf(IsDBNull(gvItemSelection.GetFocusedRowCellValue("Stocks")), 0, gvItemSelection.GetFocusedRowCellValue("Stocks"))
                    End If






                    'DirectPurchase.TotQty = IIf(IsDBNull(gvItemSelection.GetFocusedRowCellValue("Stocks")), 0, gvItemSelection.GetFocusedRowCellValue("Stocks"))

                End If

                '--------------------------------------------------

                Me.Close()
            End If

            '  frmHandle.Enabled = True

        End If

    End Sub

    Private Sub txtsearch_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.EditValueChanged
        SearchItem()
    End Sub

    Private Function IsNonInv(ByVal ItemCode As String) As Boolean
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()

        Dim sqlStr As String = ""

        Dim dsShow As New DataSet

        Try

            sqlStr = String.Format("select IsNonInv from vwItemSelection where itemcode like '" & ItemCode & "'")

            daGetDets = New SqlDataAdapter(sqlStr, Conn)
            daGetDets.Fill(dsShow)

            Return dsShow.Tables(0).Rows(0).Item(0)

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

    Private Sub txtsearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtsearch.Text = "" Then
                MsgBox("Please Enter Item Name/Code")

            Else
                gvItemSelection.Focus()

            End If


        End If
    End Sub
End Class