Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Imports System.Runtime.Serialization
Imports System.Xml


Public Class frmGRNConversion

    Private Sub frmGRNConversion_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmGRN.Enabled = True
    End Sub

    Private Sub frmGRNConversion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        txtPurchReqCode.Properties.ReadOnly = True

        LoadGridMaster()

    End Sub

#Region " Proc & Functions "

    ''' <summary>
    ''' Its Load Grid Details
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Sub LoadGridMaster()

        Dim Conn As New SqlConnection(modMain.ConnString)
        'Dim daGetDets As New SqlDataAdapter("select * from BNMaster where status=1 and IsAuthorized=1 order by BNCode", Conn)


        Dim daGetDets As New SqlDataAdapter("SELECT   MAX( dbo.BNMaster.BNCode) as  BNCode , max (dbo.BNMaster.BNDate) as BNDate,max (dbo.BNMaster.Reference) as Reference ,MAX(dbo.BNMaster.PrepairedBy) as PrepairedBy,max(dbo.BNMaster.AuthorizedBy)  as AuthorizedBy,max(dbo.BNMaster.DhoniName)  as DhoniName,max(dbo.BNMaster.DhoniCaptain)  as DhoniCaptain FROM dbo.BNMaster INNER JOIN dbo.BNDetails ON dbo.BNMaster.BNCode = dbo.BNDetails.BNCode where dbo.BNMaster.IsAuthorized=1 and BNDetails.IsProcessed = 0 group by dbo.BNMaster.BNCode order by dbo.BNMaster.BNCode", Conn)


        Dim dsShow As New DataSet

        Try
            daGetDets.Fill(dsShow)

            '----
            Dim datacol As New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))
            'Dim dcBNQty As New DataColumn("Qty", System.Type.GetType("System.Double"))

            dsShow.Tables(0).Columns.Add(datacol)

            gridBNMain.DataSource = dsShow.Tables(0)
            For i As Integer = 0 To gvBNMain.RowCount - 1
                gvBNMain.SetRowCellValue(i, "IsSelect", BNItemChkStat(i))
            Next


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

            sqlString = String.Format("select * from BNDetails where IsProcessed=0 and BNCode like '{0}'", gvBNMain.GetRowCellValue(gvBNMain.FocusedRowHandle, "BNCode").ToString.Trim)
            daItemReq = New SqlDataAdapter(sqlString, Conn)

            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daItemReq.Fill(dsItemReq)


            '----
            Dim datacol As New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))
            'Dim dcBNQty As New DataColumn("Qty", System.Type.GetType("System.Double"))

            dsItemReq.Tables(0).Columns.Add(datacol)
            ' dsItemReq.Tables(0).Columns.Add(dcBNQty)




            gridBNDetail.DataSource = dsItemReq.Tables(0)




            Dim View As GridView = gvBNDetail
            View.BeginSort()
            Try
                View.ClearGrouping()
                View.Columns("POCode").GroupIndex = 0
                'View.Columns("Category").GroupIndex = 1
            Finally
                View.EndSort()
                View.ExpandAllGroups()
            End Try




            For i As Int16 = 0 To gvBNDetail.RowCount - 1

                sqlString = String.Format("select count(itemcode) from GRNTEMPORARY where BNCode like '{0}' and Itemcode like '{1}'", gvBNMain.GetRowCellValue(gvBNMain.FocusedRowHandle, "BNCode"), gvBNDetail.GetRowCellValue(i, "Itemcode"))
                daGetDets = New SqlDataAdapter(sqlString, Conn)
                daGetDets.Fill(dsShow)


                'datacol = New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))

                If dsShow.Tables(0).Rows.Count > 0 Then
                    If dsShow.Tables(0).Rows(i).Item(0) > 0 Then
                        gvBNDetail.SetRowCellValue(i, "IsSelect", True)
                    Else
                        gvBNDetail.SetRowCellValue(i, "IsSelect", False)
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

    Function BNItemChkStat(ByVal i As Double) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)

        Dim BNCode As String = gvBNMain.GetRowCellValue(i, "BNCode")
        'Dim ItemCode As String = gvItemReq.GetRowCellValue(gvItemReq.FocusedRowHandle, "ItemCode")
        Dim daGetDets As New SqlDataAdapter(String.Format("select count(itemcode) from GRNTemporary where BNCode like '{0}'", BNCode), Conn)
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

    Function InsertGRNTemp() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcIns As New SqlCommand()
        Dim InsTrans As SqlTransaction
        Dim IsTran As Boolean

        Try

            Conn.Open()





            '--- what im gonna do is.... remove the botenote details from the system,
            'coz only one bote note details can have for a given grn

            'dcIns = New SqlCommand("Delete from GRNTemporary where grncode=@grnno and curruser=@curruser", Conn)
            dcIns = New SqlCommand("Delete from GRNTemporary", Conn) '23/02/2013

            'With dcIns.Parameters
            '    .Add("@grnno", SqlDbType.NVarChar).Value = txtPurchReqCode.Text
            '    .Add("@curruser", SqlDbType.NVarChar).Value = CurrUser
            'End With

            dcIns.ExecuteNonQuery()

            dcIns.Dispose()



            '-----------------------------------------------------

            InsTrans = Conn.BeginTransaction
            IsTran = True


            For i As Int16 = 0 To gvBNDetail.RowCount - 1

                If gvBNMain.GetFocusedRowCellValue("IsSelect") And Not gvBNDetail.GetGroupRowValue(i, gvBNDetail.Columns("POCode")) Is Nothing Then

                    dcIns = New SqlCommand("spGRNTempInsert", Conn)
                    dcIns.CommandType = CommandType.StoredProcedure
                    dcIns.Transaction = InsTrans

                    With dcIns.Parameters
                        .Add("@GRNCODE", SqlDbType.NVarChar).Value = txtPurchReqCode.Text
                        .Add("@BNCODE", SqlDbType.NVarChar).Value = gvBNMain.GetRowCellValue(gvBNMain.FocusedRowHandle, "BNCode")
                        .Add("@POCODE", SqlDbType.NVarChar).Value = gvBNDetail.GetGroupRowValue(i, gvBNDetail.Columns("POCode"))
                        .Add("@ITEMCODE", SqlDbType.NVarChar).Value = gvBNDetail.GetRowCellValue(i, "Itemcode")
                        .Add("@INSERT", SqlDbType.Bit).Value = gvBNDetail.GetRowCellValue(i, "IsSelect")
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

    Function RemoveBNPOTemp() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcIns As New SqlCommand()

        Try

            Conn.Open()

            dcIns = New SqlCommand("spBNPOTempRemove", Conn)
            dcIns.CommandType = CommandType.StoredProcedure

            With dcIns.Parameters
                .Add("@BNCODE", SqlDbType.NVarChar).Value = txtPurchReqCode.Text
                .Add("@POCODE", SqlDbType.NVarChar).Value = gvBNMain.GetFocusedRowCellValue("POCode")
                .Add("@DELETE", SqlDbType.Bit).Value = gvBNMain.GetFocusedRowCellValue("IsSelect")
                .Add("@CURRUSER", SqlDbType.NVarChar).Value = CurrUser

            End With

            dcIns.ExecuteNonQuery()

            gridBNDetail.DataSource = Nothing


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


    Private Sub gvBNMain_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvBNMain.FocusedRowChanged
        LoadGridDetails()
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        If IIf(IsDBNull(gvBNMain.GetFocusedRowCellValue("IsSelect")), 0, gvBNMain.GetFocusedRowCellValue("IsSelect")) = True Then
            Call InsertGRNTemp()

            MsgBox("Details Added Successfully....", , ErrTitle)

            '---- coz only one botenote can be selected....

            Me.Close()

        End If
    End Sub

    Private Sub cmdRemove_Click(sender As System.Object, e As System.EventArgs) Handles cmdRemove.Click
        If gvBNMain.GetFocusedRowCellValue("IsSelect") Then

            Dim msgrst As MsgBoxResult = MsgBox("Are you sure,you want to delete current Purchase Order Details", MsgBoxStyle.YesNo)

            If msgrst = MsgBoxResult.Yes Then
                Call RemoveBNPOTemp()

                gvBNMain.SetFocusedRowCellValue("IsSelect", 0)

                MsgBox("Details Removed Successfully....", , ErrTitle)
            End If

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class