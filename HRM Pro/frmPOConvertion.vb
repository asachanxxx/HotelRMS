Imports System.Data.SqlClient

Public Class frmPOConvertion

    Public IsEdit As Boolean = False

    Private Sub frmPOConvertion_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmBoteNote.Enabled = True
    End Sub

    Private Sub frmPOConvertion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        txtPurchReqCode.Properties.ReadOnly = True

        If IsEdit Then
            gvPOMain.Columns("IsSelect").OptionsColumn.AllowEdit = False
        End If

        LoadGridMaster()
    End Sub


    Private Sub gvPOMain_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPOMain.FocusedRowChanged
        LoadGridDetails()
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click

        If IIf(IsDBNull(gvPOMain.GetFocusedRowCellValue("IsSelect")), 0, gvPOMain.GetFocusedRowCellValue("IsSelect")) = True Then
            Call InsertBNTemp()

            MsgBox("Details Added Successfully....", , ErrTitle)
        End If

    End Sub

    Private Sub cmdRemove_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemove.Click
        If gvPOMain.GetFocusedRowCellValue("IsSelect") Then

            Dim msgrst As MsgBoxResult = MsgBox("Are you sure,you want to delete current Purchase Order Details", MsgBoxStyle.YesNo)

            If msgrst = MsgBoxResult.Yes Then
                Call RemoveBNPOTemp()

                gvPOMain.SetFocusedRowCellValue("IsSelect", 0)

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

            If IsEdit Then
                'sqlStr = "select distinct POCode from BNTemporary where curruser like '" & CurrUser & "' group by pocode order by POCode "
                sqlStr = "SELECT * FROM dbo.POMaster WHERE POCode in  ( SELECT DISTINCT POCode FROM dbo.BNTemporary WHERE CurrUser LIKE '" & CurrUser & "')"
            Else
                sqlStr = "select * from POMaster where status=1 and IsAuthorized = 1 order by POCode"
            End If
            daGetDets = New SqlDataAdapter(sqlStr, Conn)
            daGetDets.Fill(dsShow)

            Dim datacol As New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))
            dsShow.Tables(0).Columns.Add(datacol)

            gridPOMain.DataSource = dsShow.Tables(0)

            For i As Integer = 0 To gvPOMain.RowCount - 1
                gvPOMain.SetRowCellValue(i, "IsSelect", POItemChkStat(i))
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


        Dim daGetDets, daItemReq As New SqlDataAdapter()
        Dim dsShow, dsItemReq As New DataSet

        Try

            sqlString = String.Format("select * from PODetails where POCode like '{0}'", gvPOMain.GetRowCellValue(gvPOMain.FocusedRowHandle, "POCode"))
            daItemReq = New SqlDataAdapter(sqlString, Conn)

            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daItemReq.Fill(dsItemReq)


            '----
            Dim datacol As New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))
            Dim dcBNQty As New DataColumn("BNQty", System.Type.GetType("System.Double"))

            dsItemReq.Tables(0).Columns.Add(datacol)
            dsItemReq.Tables(0).Columns.Add(dcBNQty)

            gridPODetail.DataSource = dsItemReq.Tables(0)


            For i As Int16 = 0 To gvPODetail.RowCount - 1

                sqlString = String.Format("select count(itemcode) from BNTEMPORARY where POCode like '{0}' and Itemcode like '{1}'", gvPOMain.GetRowCellValue(gvPOMain.FocusedRowHandle, "POCode"), gvPODetail.GetRowCellValue(i, "Itemcode"))
                daGetDets = New SqlDataAdapter(sqlString, Conn)
                daGetDets.Fill(dsShow)


                'datacol = New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))

                If dsShow.Tables(0).Rows.Count > 0 Then
                    If dsShow.Tables(0).Rows(i).Item(0) > 0 Then
                        gvPODetail.SetRowCellValue(i, "IsSelect", True)
                    Else
                        gvPODetail.SetRowCellValue(i, "IsSelect", False)
                    End If

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

    Function POItemChkStat(ByVal i As Double) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)

        Dim POCode As String = gvPOMain.GetRowCellValue(i, "POCode")
        'Dim ItemCode As String = gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemCode")
        'Dim daGetDets As New SqlDataAdapter(String.Format("select count(itemcode) from BNTemporary where POCode like '{0}' and curruser like '{1}'", POCode, CurrUser), Conn)
        Dim daGetDets As New SqlDataAdapter(String.Format("select count(itemcode) from BNTemporary where POCode like '{0}'", POCode), Conn)
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

    Function InsertBNTemp() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcIns As New SqlCommand()
        Dim InsTrans As SqlTransaction
        Dim IsTran As Boolean

        Try

            Conn.Open()



            InsTrans = Conn.BeginTransaction
            IsTran = True


            For i As Int16 = 0 To gvPODetail.RowCount - 1

                If gvPOMain.GetFocusedRowCellValue("IsSelect") Then

                    'If gvPODetail.GetRowCellValue(i, "IsSelect") Then
                    dcIns = New SqlCommand("spBNPOTempInsert", Conn)
                    dcIns.CommandType = CommandType.StoredProcedure
                    dcIns.Transaction = InsTrans

                    With dcIns.Parameters
                        .Add("@BNCODE", SqlDbType.NVarChar).Value = txtPurchReqCode.Text
                        .Add("@POCODE", SqlDbType.NVarChar).Value = gvPOMain.GetRowCellValue(gvPOMain.FocusedRowHandle, "POCode")
                        .Add("@ITEMCODE", SqlDbType.NVarChar).Value = gvPODetail.GetRowCellValue(i, "Itemcode")
                        .Add("@INSERT", SqlDbType.Bit).Value = IIf(gvPODetail.GetRowCellValue(i, "IsSelect") = True, 1, 0)
                        .Add("@CURRUSER", SqlDbType.NVarChar).Value = CurrUser
                    End With

                    dcIns.ExecuteNonQuery()
                    'End If

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

    Function RemoveBNPOTemp() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcIns As New SqlCommand()

        Try

            
            Conn.Open()

            dcIns = New SqlCommand("spBNPOTempRemove", Conn)
            dcIns.CommandType = CommandType.StoredProcedure

            With dcIns.Parameters
                .Add("@BNCODE", SqlDbType.NVarChar).Value = txtPurchReqCode.Text
                .Add("@POCODE", SqlDbType.NVarChar).Value = gvPOMain.GetFocusedRowCellValue("POCode")
                .Add("@DELETE", SqlDbType.Bit).Value = gvPOMain.GetFocusedRowCellValue("IsSelect")
                .Add("@CURRUSER", SqlDbType.NVarChar).Value = CurrUser

            End With

            dcIns.ExecuteNonQuery()

            gridPODetail.DataSource = Nothing


            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcIns.Dispose()
        End Try



    End Function

#End Region

    
    
End Class