Imports System.Data.SqlClient

Public Class frmGINReport

    Private Sub frmGINReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        dtDateFrom.Text = Date.Today
        dtDateTo.Text = Date.Today

        LoadCombos() ' Load Bincard Departments
        LoadGridDets()

    End Sub

    Sub LoadCombos()
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsFrom, dsShow As New DataSet

        Try

            '----- Load Department Master

            daGetDets = New SqlDataAdapter("select DepartmentID,Department from DepartmentMaster where departmentid <> 'Ware House'", Conn)
            daGetDets.Fill(dsFrom)

            Dim dtDefault As DataRow = dsFrom.Tables(0).NewRow

            dtDefault.Item(0) = "All"
            dtDefault.Item(1) = "All Departments"

            dsFrom.Tables(0).Rows.Add(dtDefault)

            With cmbDepartment_Item.Properties
                .DataSource = dsFrom.Tables(0)
                .DisplayMember = "Department"
                .ValueMember = "DepartmentID"
                .AutoSearchColumnIndex = 0
                .Columns(0).Width = 125
                .Columns(1).Width = 275
                .PopupWidth = 400

                cmbDepartment_Item.EditValue = "All"
                'cmbFrom.Text = "Ware House"
                'cmbFrom.Enabled = False
                'cmbFrom.SelectedText = "Ware House"
                'cmbDepartment_Item.EditValue = "Ware House"
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


    ''' <summary>
    ''' Its Load Grid Details
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Sub LoadGridDets()

        If String.IsNullOrEmpty(dtDateFrom.Text) Or String.IsNullOrEmpty(dtDateTo.Text) Then
            Exit Sub
        End If

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim SqlString As String = ""

        If rbAll.Checked Then
            SqlString = String.Format("select * from GINMaster where GINDate >=@FromDate and GINDate <=@ToDate order by GINCode ", dtDateFrom.Text, dtDateTo.Text)
        Else
            If cmbDepartment_Item.GetColumnValue("DepartmentID") = "All" Then
                SqlString = String.Format("select * from GINMaster where GINDate >=@FromDate and GINDate <=@ToDate order by GINCode")
            Else
                SqlString = String.Format("select * from GINMaster where ToDept like '{0}' and  GINDate >=@FromDate and GINDate <=@ToDate order by GINCode", cmbDepartment_Item.GetColumnValue("DepartmentID"))
            End If

        End If
        Dim dcExec As New SqlCommand
        Dim daGetDets As New SqlDataAdapter(SqlString, Conn)
        Dim dsShow As New DataSet

        Try
            Conn.Open()
            dcExec = New SqlCommand(SqlString, Conn)
            dcExec.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = dtDateFrom.DateTime.Date
            dcExec.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = dtDateTo.DateTime.Date

            daGetDets.SelectCommand = dcExec
            daGetDets.Fill(dsShow)

            gridGIN.DataSource = dsShow.Tables(0)

            dsShow.Dispose()
            daGetDets.Dispose()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim SelectFormula As String = ""
        
        frmReportViewerZ.rptPath = "rptGIN.rpt"
        frmReportViewerZ.rptTitle = String.Format("Stock As At {0} ", Now.Date.ToLongDateString)

        SelectFormula = String.Format(" {{vwGINMasterDetail.GINDate}} >=#{0}# and {{vwGINMasterDetail.GINDate}} <=#{1}# ", dtDateFrom.DateTime.Date, dtDateTo.DateTime.Date)

        If rbAll.Checked Then

            If Not cmbDepartment_Item.GetColumnValue("DepartmentID") = "All" Then

                frmReportViewerZ.selectionForumla = String.Format("and {{vwGINMasterDetail.ToDept}} ='{0}'", cmbDepartment_Item.GetColumnValue("DepartmentID")) ' and {vwGINMasterDetail.GINCode} "
            End If

        Else
            Dim GINCode As String = gvItemReq.GetFocusedRowCellValue("GINCode")
            If String.IsNullOrEmpty(GINCode) Then
                MsgBox("Please select Good Issue Note number to print", MsgBoxStyle.Critical, ErrTitle)
            End If
            frmReportViewerZ.selectionForumla = String.Format(" {{vwGINMasterDetail.GINCode}} ='{0}'", GINCode)
        End If
        'String.Format("{{vwItemInventoryFull.Location}}  ='{0}'", cmbDepartment_Item.GetColumnValue("DepartmentID")) ' String.Format("{{Report_BinCard.BILLDATE}} >=#{0}# and {{Report_BinCard.BILLDATE}} #<={1}#", dtDateFrom.DateTime.Date, dtDateTo.DateTime.Date)

        frmReportViewerZ.Show()

    End Sub

    Private Sub cmbDepartment_Item_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbDepartment_Item.EditValueChanged

    End Sub

    Private Sub dtDateFrom_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles dtDateFrom.EditValueChanged, dtDateTo.EditValueChanged

        If Not dtDateFrom.Text = "" And Not dtDateTo.Text = "" Then
            LoadGridDets()
        End If

    End Sub

    Private Sub rbSingleItem_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbSingleItem.CheckedChanged, rbAll.CheckedChanged
        LoadGridDets()
    End Sub
End Class