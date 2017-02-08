Imports System.Data.SqlClient

Public Class frmItemReqConvertion

    Private Sub frmItemReqConvertion_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPurchReq.Enabled = True
    End Sub

    Private Sub frmItemReqConvertion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        txtPurchReqCode.Properties.ReadOnly = True

        LoadGridMaster()
    End Sub


    Private Sub gvItemReq_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvItemReq.FocusedRowChanged
        LoadGridDetails()
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click

        If IIf(IsDBNull(gvItemReq.GetFocusedRowCellValue("IsSelect")), 0, gvItemReq.GetFocusedRowCellValue("IsSelect")) = True Then
            Call InsertPOReqTemp()

            MsgBox("Details Added Successfully....", , ErrTitle)
        End If

    End Sub

    Private Sub cmdRemove_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemove.Click
        If gvItemReq.GetFocusedRowCellValue("IsSelect") Then

            Dim msgrst As MsgBoxResult = MsgBox("Are you sure,you want to delete current Item Requisition Details", MsgBoxStyle.YesNo)

            If msgrst = MsgBoxResult.Yes Then
                Call RemovePOReqTemp()

                gvItemReq.SetFocusedRowCellValue("IsSelect", 0)

                MsgBox("Details Removed Successfully....", , ErrTitle)
            End If

        End If
    End Sub

#Region " Proc & Functions "

    ''' <summary>
    ''' Its Load Grid Details
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Sub LoadGridMaster()

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim sqlStr As String = ""

        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try

            daGetDets = New SqlDataAdapter("select * from ItemReqMaster where status=1 order by ItemReqCode", Conn)
            daGetDets.Fill(dsShow)

            Dim datacol As New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))
            dsShow.Tables(0).Columns.Add(datacol)

            gridItemReq.DataSource = dsShow.Tables(0)

            For i As Integer = 0 To gvItemReq.RowCount - 1
                gvItemReq.SetRowCellValue(i, "IsSelect", POItemChkStat(i))
            Next

            ''--- here what i hv done is, get a dummy dataset for itemreqdetails
            'daGetDets = New SqlDataAdapter("select * from itemreqtemporary where itemcode like 'nothing'", Conn)
            'daGetDets.Fill(dsShow)

            'gridItemReq.DataSource = dsShow.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Sub LoadGridDetails()
        Dim Conn As New SqlConnection(modMain.ConnString)

        Dim sqlString As String = ""
        Dim chkStatus As Boolean = False


        ' String.Format("select * from ItemReqDetail where ItemReqCode like '{0}'", gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemReqCode"))
        Dim daGetDets, daItemReq As New SqlDataAdapter()
        Dim dsShow, dsItemReq As New DataSet

        Try

            sqlString = String.Format("select * from ItemReqDetail where ItemReqCode like '{0}'", gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemReqCode"))
            daItemReq = New SqlDataAdapter(sqlString, Conn)

            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daItemReq.Fill(dsItemReq)


            '----
            Dim datacol As New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))
            dsItemReq.Tables(0).Columns.Add(datacol)


            gridItemDetail.DataSource = dsItemReq.Tables(0)




            For i As Int16 = 0 To gvItemDetail.RowCount - 1

                sqlString = String.Format("select count(itemcode) from POReqTemporary where ItemReqCode like '{0}' and Itemcode like '{1}'", gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemReqCode"), gvItemDetail.GetRowCellValue(i, "Itemcode"))
                daGetDets = New SqlDataAdapter(sqlString, Conn)
                daGetDets.Fill(dsShow)


                'datacol = New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))

                If dsShow.Tables(0).Rows.Count > 0 Then
                    If dsShow.Tables(0).Rows(i).Item(0) > 0 Then
                        gvItemDetail.SetRowCellValue(i, "IsSelect", True)
                    Else
                        gvItemDetail.SetRowCellValue(i, "IsSelect", False)
                    End If

                End If

            Next

            '            sqlString = String.Format("select * from POReqTemporary where ItemReqCode like '{0}' and Itemcode like {1}", gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemReqCode"), gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemReqCode"))
            '            daGetDets = New SqlDataAdapter(sqlString, Conn)

            '            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            '            daGetDets.Fill(dsShow)

            '            chkStatus = True

            '            If Not dsShow.Tables(0).Rows.Count > 0 Then

            '                chkStatus = False

            '                sqlString = String.Format("select * from ItemReqDetail where ItemReqCode like '{0}'", gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemReqCode"))
            '                daItemReq = New SqlDataAdapter(sqlString, Conn)

            '                '--- here what i hv done is, get a dummy dataset for itemreqdetails
            '                daItemReq.Fill(dsItemReq)


            '            End If


            '            Dim datacol As New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))


            '            If chkStatus Then
            '                dsShow.Tables(0).Columns.Add(datacol)
            '                gridItemDetail.DataSource = dsShow.Tables(0)
            '            Else
            '                dsItemReq.Tables(0).Columns.Add(datacol)
            '                gridItemDetail.DataSource = dsItemReq.Tables(0)
            '            End If

            'Grid:

            '            For i As Integer = 0 To gvItemDetail.RowCount - 1
            '                If IIf(IsDBNull(gvItemReq.GetFocusedRowCellValue("IsSelect")), False, gvItemReq.GetFocusedRowCellValue("IsSelect")) Then
            '                    gvItemDetail.SetRowCellValue(i, "IsSelect", chkStatus)
            '                    'Else
            '                    '    gvItemDetail.SetRowCellValue(i, "IsSelect", 0)
            '                Else
            '                    gvItemDetail.SetRowCellValue(i, "IsSelect", 0)
            '                End If

            '            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Function POItemChkStat(ByVal i As Double) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)

        Dim ItemReqCode As String = gvItemReq.GetRowCellValue(i, "ItemReqCode")
        'Dim ItemCode As String = gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemCode")
        Dim daGetDets As New SqlDataAdapter(String.Format("select count(itemcode) from POReqTemporary where ItemReqCode like '{0}'", ItemReqCode), Conn)
        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count > 0 Then
                If dsShow.Tables(0).Rows(0).Item(0) = 0 Then
                    Return 0
                End If
            End If

            Return 1


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Function

    Function InsertPOReqTemp() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcIns As New SqlCommand()
        Dim InsTrans As SqlTransaction
        Dim IsTran As Boolean

        Try

            Conn.Open()



            InsTrans = Conn.BeginTransaction
            IsTran = True


            For i As Int16 = 0 To gvItemDetail.RowCount - 1

                If gvItemDetail.GetFocusedRowCellValue("IsSelect") Then

                    dcIns = New SqlCommand("spPOReqTempInsert", Conn)
                    dcIns.CommandType = CommandType.StoredProcedure
                    dcIns.Transaction = InsTrans

                    With dcIns.Parameters
                        .Add("@POREQCODE", SqlDbType.NVarChar).Value = txtPurchReqCode.Text
                        .Add("@ITEMREQCODE", SqlDbType.NVarChar).Value = gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemReqCode")
                        .Add("@ITEMCODE", SqlDbType.NVarChar).Value = gvItemDetail.GetRowCellValue(i, "Itemcode")
                        .Add("@ITEMNAME", SqlDbType.NVarChar).Value = gvItemDetail.GetRowCellValue(i, "Itemname")
                        .Add("@ORDQTY", SqlDbType.Float).Value = gvItemDetail.GetRowCellValue(i, "OrdQty")
                        .Add("@INSERT", SqlDbType.Bit).Value = gvItemDetail.GetRowCellValue(i, "IsSelect")
                        .Add("@CURRUSER", SqlDbType.NVarChar).Value = CurrUser
                    End With

                    dcIns.ExecuteNonQuery()
                End If

            Next

            InsTrans.Commit()
            IsTran = False

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally

            If IsTran Then
                InsTrans.Rollback()
                IsTran = False
            End If

            Conn.Dispose()
            dcIns.Dispose()

        End Try



    End Function

    Function RemovePOReqTemp() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcIns As New SqlCommand()

        Try

            Conn.Open()

            dcIns = New SqlCommand("spPOReqTempRemove", Conn)
            dcIns.CommandType = CommandType.StoredProcedure

            With dcIns.Parameters
                .Add("@POREQCODE", SqlDbType.NVarChar).Value = txtPurchReqCode.Text
                .Add("@ITEMREQCODE", SqlDbType.NVarChar).Value = gvItemReq.GetFocusedRowCellValue("ItemReqCode")
                .Add("@DELETE", SqlDbType.Bit).Value = gvItemReq.GetFocusedRowCellValue("IsSelect")
                .Add("@CURRUSER", SqlDbType.NVarChar).Value = CurrUser

            End With

            dcIns.ExecuteNonQuery()

            gridItemDetail.DataSource = Nothing


            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcIns.Dispose()
        End Try



    End Function


    Sub LoadGridDetailsOLD()
        Dim Conn As New SqlConnection(modMain.ConnString)

        Dim sqlString As String = ""
        Dim chkStatus As Boolean = False


        ' String.Format("select * from ItemReqDetail where ItemReqCode like '{0}'", gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemReqCode"))
        Dim daGetDets, daItemReq As New SqlDataAdapter()
        Dim dsShow, dsItemReq As New DataSet

        Try

            sqlString = String.Format("select * from POReqTemporary where ItemReqCode like '{0}'", gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemReqCode"))
            daGetDets = New SqlDataAdapter(sqlString, Conn)

            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daGetDets.Fill(dsShow)

            chkStatus = True

            If Not dsShow.Tables(0).Rows.Count > 0 Then

                chkStatus = False

                sqlString = String.Format("select * from ItemReqDetail where ItemReqCode like '{0}'", gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemReqCode"))
                daItemReq = New SqlDataAdapter(sqlString, Conn)

                '--- here what i hv done is, get a dummy dataset for itemreqdetails
                daItemReq.Fill(dsItemReq)


            End If


            Dim datacol As New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))


            If chkStatus Then
                dsShow.Tables(0).Columns.Add(datacol)
                gridItemDetail.DataSource = dsShow.Tables(0)
            Else
                dsItemReq.Tables(0).Columns.Add(datacol)
                gridItemDetail.DataSource = dsItemReq.Tables(0)
            End If

Grid:

            For i As Integer = 0 To gvItemDetail.RowCount - 1
                If IIf(IsDBNull(gvItemReq.GetFocusedRowCellValue("IsSelect")), False, gvItemReq.GetFocusedRowCellValue("IsSelect")) Then
                    gvItemDetail.SetRowCellValue(i, "IsSelect", chkStatus)
                    'Else
                    '    gvItemDetail.SetRowCellValue(i, "IsSelect", 0)
                Else
                    gvItemDetail.SetRowCellValue(i, "IsSelect", 0)
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

#End Region


End Class