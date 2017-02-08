Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Data.SqlClient


Public Class frmInventory_Report
    Public POReqCode As String = ""
    Private northwindCustomersReport As ReportDocument
    Public StartDate, EndDate As String  'Range Values
    Public IsParamAvl As Boolean  ' boolean chk

    Public rptPath As String = ""
    Public selectionForumla As String = ""
    Public rptTitle As String = ""
    Public ReportTitle As String = ""


    Private Sub frmGRN_Raised_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        dtDateFrom.Text = Date.Today
        dtDateTo.Text = Date.Today

        LoadCombos() ' Load Bincard Departments

        Select Case ReportTitle
            Case "Bincard Report"

                gbDate.Visible = True
                gbItem.Visible = True
                gbDepartment_General.Visible = False
            Case "Stock In Hand Report"

                gbDate.Visible = False
                gbItem.Visible = False
                gbDepartment_General.Visible = True

            Case "Item WriteOff Report"
                gbDate.Visible = True
                gbItem.Visible = False
                gbDepartment_General.Visible = False
            Case "Item Ajustment"
                gbDate.Visible = True
                gbItem.Visible = False
                gbDepartment_General.Visible = False

            Case "Deparment Wise Consumption"
                gbDate.Visible = True
                gbItem.Visible = False
                gbDepartment_General.Visible = True

            Case "Deparment Wise Stock Report"
                gbDate.Visible = True
                gbItem.Visible = False
                gbDepartment_General.Visible = True

            Case "PO vs BN Report"
                gbDate.Visible = True
                gbItem.Visible = False
                gbDepartment_General.Visible = False
        End Select

    End Sub


    Public Sub btnPrint_Clickx()

        Dim Conn As New SqlConnection(ConnString)
        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet


        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        Dim fltString As String

        Try

            Conn.Open()

            'dcIns = New SqlCommand("select * from rpt_GRN_Raised_Report_View", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            'dcIns.CommandType = CommandType.Text
            'dcIns.ExecuteNonQuery()



            'fltString = ""
            'fltString = "{rpt_GRN_Raised_Report_View.GRNDate}>=#" & dtDate.Text & "#  and {rpt_GRN_Raised_Report_View.GRNDate}<=#" & dtDate2.Text & "#"
            'fltString = "{rptPurchaseRequisition.ReqDate}>=#" & dtDate.Text & "#  and {rptPurchaseRequisition.ReqDate}<=#" & dtDate2.Text & "#"
            fltString = String.Format("{{rptPurchaseRequisition.POReqCode}}='{0}'", POReqCode)
            ReportName = "rptPurchaseRequisition.rpt"
            rptTitle = "Purchase Requisition_Report"

            frmReportViewerZ.rptPath = ReportName
            frmReportViewerZ.rptTitle = rptTitle
            frmReportViewerZ.selectionForumla = fltString

            frmReportViewerZ.paraRepName = "fromDate"
            frmReportViewerZ.paraRepVale = dtDateFrom.Text.ToString

            frmReportViewerZ.paraRepName2 = "toDate"
            frmReportViewerZ.paraRepVale2 = dtDateTo.Text.ToString



            frmReportViewerZ.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'Conn.Dispose()
            'dcIns.Dispose()

        End Try
    End Sub

    Public Function ConfigureCrystalReports()
        Try
            '"Data Source=AMAZIR-I3\SQLEXPRESS2008;Initial Catalog=RMSDB;Persist Security Info=True;User ID=sa;Password=infocraft.com;;Connection Timeout=120"
            '//// First of all we have to get machine name
            ' Call the global function
            Dim ServerName As String = "AMAZIR-I3\SQLEXPRESS2008"
            'Dim ServerName As String = GetComputerName(ComPath) & "\SBSCC"

            'Dim ServerName As String = "ROADRUNNER\SQLEXPRESS"
            'Dim ServerName As String = My.Computer.Name & "\SQLEXPRESS" '  "\SQLEXPRESS"

            northwindCustomersReport = New ReportDocument()
            'Dim mypath As String = AppDomain.CurrentDomain.BaseDirectory
            'Dim reportPath As String = "E:\Projects\HRM Pro 14102012\HRM Pro\HRM Pro\bin\Debug\Reports\" & rptPath ' String.Format("\Reports\{1}", , rptPath) ' "tmpReport.rpt" '"rptQuation.rpt"
            northwindCustomersReport.Load(rptPath)

            '"(local)\SQLEXPRESS"  "mafaz\SQLEXPRESS" ' '"(local)\SQLEXPRESS" '"PORTABEE\SQLEXPRESS" '
            Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo() With {.ServerName = "AMMUPCHOUSE\SQLEXPRESS2008", .DatabaseName = "RMSdb", .IntegratedSecurity = False}

            'myConnectionInfo.UserID = "xxxx" '"sa"
            'myConnectionInfo.Password = "xxxx"  '"vctt" '

            myConnectionInfo.UserID = "sa" '"sa"
            myConnectionInfo.Password = "infocraft.com"  '"vctt" '


            '///// check for formula field..
            'myCrystalReportViewer.SelectionFormula = "{myTestView.QTNNumber} ='QTN0000002'"

            'myCrystalReportViewer.SelectionFormula = "{vwPOHBill.PODate}=#13/12/2008#" '"{vwPOHBill.SupplierId} ='S002'" '
            'myReport.SelectionFormula = selectionForumla

            'northwindCustomersReport.SummaryInfo.ReportTitle = rptTitle

            'myReport.ReportSource = northwindCustomersReport

            SetDBLogonForReport(myConnectionInfo, northwindCustomersReport)


            If IsParamAvl Then

                '---- with sql parameter passing 
                northwindCustomersReport.SetParameterValue("@From", StartDate)
                northwindCustomersReport.SetParameterValue("@To", EndDate)

                '---- this is crystal report param passing 
                '---------------------------
                'Dim crParameterFieldDefinitions As ParameterFieldDefinitions
                'Dim crParameterFieldDefinition1 As ParameterFieldDefinition

                'Dim crParameterValues As New ParameterValues
                'Dim crParameterDiscreteValue1 As New ParameterDiscreteValue

                ''StartDate = Format(StartDate, "yyyy-MM-dd")

                'crParameterDiscreteValue1.Value = StartDate


                'crParameterFieldDefinitions = northwindCustomersReport.DataDefinition.ParameterFields
                'crParameterFieldDefinition1 = crParameterFieldDefinitions.Item("@From")
                'crParameterValues = crParameterFieldDefinition1.CurrentValues

                'crParameterValues.Clear()

                'crParameterValues.Add(crParameterDiscreteValue1)
                'crParameterFieldDefinition1.ApplyCurrentValues(crParameterValues)


                'Dim crParameterFieldDefinition2 As ParameterFieldDefinition
                'Dim crParameterDiscreteValue2 As New ParameterDiscreteValue
                'crParameterDiscreteValue2.Value = EndDate
                'crParameterFieldDefinition2 = crParameterFieldDefinitions.Item("@To")
                'crParameterValues = crParameterFieldDefinition2.CurrentValues
                'crParameterValues.Add(crParameterDiscreteValue2)

                'crParameterFieldDefinition2.ApplyCurrentValues(crParameterValues)

                '---------------------------

            End If


            ' myReport.SelectionFormula = selectionForumla

            'northwindCustomersReport.SummaryInfo.ReportTitle = rptTitle

            'myReport.ReportSource = northwindCustomersReport
            'myReport.Refresh()



            ''----------------------------------
            'Dim field1 As ParameterField = Me.myReport.ParameterFieldInfo(0)
            ''Dim field2 As ParameterField = Me.myReport.ParameterFieldInfo(1)
            'Dim val1 As New ParameterDiscreteValue()
            ''Dim val2 As New ParameterDiscreteValue()

            'If AsOf Then
            '    val1.Value = "@CURRDATE"
            '    field1.CurrentValues.Add(val1)
            'Else
            '    val1.Value = "@CURRDATE"
            '    'val2.Value = "value2"
            '    field1.CurrentValues.Add(val1)
            '    'field2.CurrentValues.Add(val2)
            'End If

            ''-----------------------------------------

            'SetDBLogonForReport(myConnectionInfo, northwindCustomersReport)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next

    End Sub

#Region " BinCard "
    Function BinCard_SP() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand()

        Try
            Conn.Open()

            dcExec = New SqlCommand("sp_BinCard_Report", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            dcExec.Parameters.Add("@FROMDATE", SqlDbType.DateTime).Value = dtDateFrom.DateTime.Date
            dcExec.Parameters.Add("@TODATE", SqlDbType.DateTime).Value = dtDateTo.DateTime.Date
            dcExec.Parameters.Add("@DEPARTMENT", SqlDbType.NVarChar).Value = cmbDepartment_Item.GetColumnValue("DepartmentID")
            dcExec.Parameters.Add("@ITEMCODE", SqlDbType.NVarChar).Value = cmbItem.GetColumnValue("Itemcode")

            dcExec.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            dcExec.Dispose()
            Conn.Dispose()
        End Try

    End Function

    Function BinCard_SP_Dep() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand()

        Try
            Conn.Open()

            dcExec = New SqlCommand("sp_BinCard_Report_Dep", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            dcExec.Parameters.Add("@FROMDATE", SqlDbType.DateTime).Value = dtDateFrom.DateTime.Date
            dcExec.Parameters.Add("@TODATE", SqlDbType.DateTime).Value = dtDateTo.DateTime.Date
            dcExec.Parameters.Add("@DEPARTMENT", SqlDbType.NVarChar).Value = cmbDepartment_General.GetColumnValue("DepartmentID")
            'dcExec.Parameters.Add("@ITEMCODE", SqlDbType.NVarChar).Value = cmbItem.GetColumnValue("Itemcode")

            dcExec.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            dcExec.Dispose()
            Conn.Dispose()
        End Try

    End Function

    Function BinCard_SP_Cat() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand()

        Try
            Conn.Open()

            dcExec = New SqlCommand("sp_BinCard_Report_Cat", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            dcExec.Parameters.Add("@FROMDATE", SqlDbType.DateTime).Value = dtDateFrom.DateTime.Date
            dcExec.Parameters.Add("@TODATE", SqlDbType.DateTime).Value = dtDateTo.DateTime.Date
            dcExec.Parameters.Add("@DEPARTMENT", SqlDbType.NVarChar).Value = cmbDepartment_General.GetColumnValue("DepartmentID")
            'dcExec.Parameters.Add("@ITEMCODE", SqlDbType.NVarChar).Value = cmbItem.GetColumnValue("Itemcode")

            dcExec.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            dcExec.Dispose()
            Conn.Dispose()
        End Try

    End Function

    Function POBN_SP_Report() As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand()

        Try
            Conn.Open()

            dcExec = New SqlCommand("sp_POandBN_Report", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            dcExec.Parameters.Add("@FROMDATE", SqlDbType.DateTime).Value = dtDateFrom.DateTime.Date
            dcExec.Parameters.Add("@TODATE", SqlDbType.DateTime).Value = dtDateTo.DateTime.Date
            'dcExec.Parameters.Add("@DEPARTMENT", SqlDbType.NVarChar).Value = cmbDepartment_General.GetColumnValue("DepartmentID")
            'dcExec.Parameters.Add("@ITEMCODE", SqlDbType.NVarChar).Value = cmbItem.GetColumnValue("Itemcode")

            dcExec.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            dcExec.Dispose()
            Conn.Dispose()
        End Try
    End Function

    Sub LoadCombos()
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets, daGridLookup As New SqlDataAdapter()
        Dim dsFrom, dsShow, dsGridLookup As New DataSet

        Try

            '----- Load Department Master

            daGetDets = New SqlDataAdapter("select DepartmentID,Department from DepartmentMaster", Conn)
            daGetDets.Fill(dsFrom)

            With cmbDepartment_Item.Properties
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
                'cmbDepartment_Item.EditValue = "Ware House"
            End With

            With cmbDepartment_General.Properties
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
            daGridLookup.Dispose()
            dsGridLookup.Dispose()
        End Try
    End Sub

    Sub LoadItem_Bincard(ByVal Location As String)

        Dim Conn As New SqlConnection(modMain.ConnString)


        'Dim daMainDets As New SqlDataAdapter(String.Format("select * from ItemMaster where itemcode like '{0}'", Itemcode), Conn)
        Dim daGetDets As New SqlDataAdapter(String.Format("select * from vwItemLocWise where status=1 and location='{0}'", cmbDepartment_Item.GetColumnValue("DepartmentID")), Conn)
        Dim dsMDets As New DataSet

        'Dim daGridLookup As New SqlDataAdapter()
        'Dim dsGridLookup As New DataSet

        daGetDets.Fill(dsMDets)
        Try

            'daGridLookup = New SqlDataAdapter("select Itemcode,Description from DepartmentMaster", Conn)
            'daGridLookup.Fill(dsGridLookup)

            With cmbItem.Properties
                .DataSource = dsMDets.Tables(0)
                .DisplayMember = "Description"
                .ValueMember = "Itemcode"
                .AutoSearchColumnIndex = 0
                .Columns(0).Width = 125
                .Columns(1).Width = 275
                .PopupWidth = 400
                'cmbFrom.Text = "Ware House"
                'cmbFrom.Enabled = False
                'cmbFrom.SelectedText = "Ware House"
                'cmbDepartment_Item.EditValue = "Ware House"
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            'dsGridLookup.Dispose()
            dsMDets.Dispose()
            dsMDets.Dispose()

        End Try


    End Sub
#End Region

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        Select Case ReportTitle

            Case "Bincard Report"

                'gbDate.Visible = True
                'gbItem.Visible = True


                If Not BinCard_SP() Then
                    MsgBox("Can't Process Bincard Report", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                frmReportViewerZ.rptPath = "rptBINCardReport.rpt"
                frmReportViewerZ.rptTitle = String.Format("Bincard from {0} To {1}", dtDateFrom.DateTime.ToLongDateString, dtDateTo.DateTime.ToLongDateString)
                frmReportViewerZ.selectionForumla = "" ' String.Format("{{Report_BinCard.BILLDATE}} >=#{0}# and {{Report_BinCard.BILLDATE}} #<={1}#", dtDateFrom.DateTime.Date, dtDateTo.DateTime.Date)
            Case "Stock In Hand Report"

                gbDate.Visible = False
                gbItem.Visible = False
                gbDepartment_General.Visible = True

                frmReportViewerZ.rptPath = "rptStockInHand.rpt"
                frmReportViewerZ.rptTitle = String.Format("Stock As At {0} ", Now.Date.ToLongDateString)
                frmReportViewerZ.selectionForumla = String.Format("{{vwItemInventoryFull.Location}}  ='{0}'", cmbDepartment_General.GetColumnValue("DepartmentID")) ' String.Format("{{Report_BinCard.BILLDATE}} >=#{0}# and {{Report_BinCard.BILLDATE}} #<={1}#", dtDateFrom.DateTime.Date, dtDateTo.DateTime.Date)

                '{vwItemInventoryFull.Location}

            Case "Item WriteOff Report"
                gbDate.Visible = True
                gbItem.Visible = False
                gbDepartment_General.Visible = False

                frmReportViewerZ.rptPath = "rptItemWriteOff.rpt"
                frmReportViewerZ.rptTitle = String.Format("Stock Write off from  {0} to {1} ", dtDateFrom.Text, dtDateTo.Text)
                frmReportViewerZ.selectionForumla = "{vwItemWriteOff.KICDate}  >='" & dtDateFrom.Text & "' and {vwItemWriteOff.KICDate} <='" & dtDateTo.Text & "'"
                'frmReportViewerZ.selectionForumla = String.Format("{vwItemWriteOff.KICDate}  >=#{0}# and {vwItemWriteOff.KICDate} <=#{1}#", dtDateFrom.DateTime.Date, dtDateTo.DateTime.Date) ' String.Format("{{Report_BinCard.BILLDATE}} >=#{0}# and {{Report_BinCard.BILLDATE}} #<={1}#", dtDateFrom.DateTime.Date, dtDateTo.DateTime.Date)

            Case "Item Ajustment"
                gbDate.Visible = True
                gbItem.Visible = False
                gbDepartment_General.Visible = False

                frmReportViewerZ.rptPath = "rptItemAdjusment.rpt"
                frmReportViewerZ.rptTitle = String.Format("Stock Adjustments from  {0} to {1} ", dtDateFrom.Text, dtDateTo.Text)
                frmReportViewerZ.selectionForumla = "{vwItemAdjustment.TRANSDATE}  >=#" & dtDateFrom.DateTime & "# and {vwItemAdjustment.TRANSDATE} <=#" & dtDateTo.DateTime & "#"

            Case "Deparment Wise Consumption"
                If Not BinCard_SP_Dep() Then
                    MsgBox("Can't Process Departmentwise Consumption Report", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                frmReportViewerZ.rptPath = "rptConsumptionReportDep.rpt"
                frmReportViewerZ.rptTitle = String.Format("Consumption Report from {0} To {1}", dtDateFrom.DateTime.ToLongDateString, dtDateTo.DateTime.ToLongDateString)
                frmReportViewerZ.selectionForumla = "" ' String.Format("{{Report_BinCard.BILLDATE}} >=#{0}# and {{Report_BinCard.BILLDATE}} #<={1}#", dtDateFrom.DateTime.Date, dtDateTo.DateTime.Date)

            Case "Deparment Wise Stock Report"
                If Not BinCard_SP_Cat() Then
                    MsgBox("Can't Process Departmentwise Stock Report", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                frmReportViewerZ.rptPath = "rptStockReport_Depwise.rpt"
                frmReportViewerZ.rptTitle = String.Format("Stock Report from {0} To {1}", dtDateFrom.DateTime.ToLongDateString, dtDateTo.DateTime.ToLongDateString)
                frmReportViewerZ.selectionForumla = "" ' String.Format("{{Report_BinCard.BILLDATE}} >=#{0}# and {{Report_BinCard.BILLDATE}} #<={1}#", dtDateFrom.DateTime.Date, dtDateTo.DateTime.Date)

            Case "PO vs BN Report"
                If Not POBN_SP_Report() Then
                    MsgBox("Can't Process PO vs BN Report", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                frmReportViewerZ.rptPath = "rptPOandBNDiff.rpt"
                frmReportViewerZ.rptTitle = String.Format("Stock Report from {0} To {1}", dtDateFrom.DateTime.ToLongDateString, dtDateTo.DateTime.ToLongDateString)
                frmReportViewerZ.selectionForumla = "" ' String.Format("{{Report_BinCard.BILLDATE}} >=#{0}# and {{Report_BinCard.BILLDATE}} #<={1}#", dtDateFrom.DateTime.Date, dtDateTo.DateTime.Date)

        End Select

        frmReportViewerZ.Show()

    End Sub

    Private Sub cmbDepartment_Item_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbDepartment_Item.EditValueChanged

        If cmbDepartment_Item.GetColumnValue("DepartmentID") <> "" Then
            LoadItem_Bincard(cmbDepartment_Item.GetColumnValue("DepartmentID"))
        End If
    End Sub
End Class