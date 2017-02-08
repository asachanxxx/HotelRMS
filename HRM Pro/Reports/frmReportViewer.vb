Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmReportViewer

    Public rptPath As String = ""
    Private northwindCustomersReport As ReportDocument
    Public selectionForumla As String = ""
    Public rptTitle As String = ""
    Public paraRepName As String = ""
    Public paraRepVale As String = ""
    Public paraRepName2 As String = ""
    Public paraRepVale2 As String = ""
    Public reporttype As Integer




    Private Sub frmReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ConfigureCrystalReports()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Function ConfigureCrystalReports()
        Try


            If reporttype = 1 Then

                'Dim ServerName As String = "INFORMS\INFOCRAFT"


                '-----------------------------------------------------------------------

                ' Dim ServerName As String = "RASHAD-PC\RASHADSQL"
                Dim ServerName As String = "192.168.0.100\INFOCRAFT"

                '----------------------------------------------------------------------

                northwindCustomersReport = New ReportDocument()
                Dim reportPath As String = String.Format("{0}\Reports\{1}", Application.StartupPath, rptPath) ' "tmpReport.rpt" '"rptQuation.rpt"
                northwindCustomersReport.Load(reportPath)
                northwindCustomersReport.Refresh()


                Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
                myConnectionInfo.ServerName = ServerName

                myConnectionInfo.DatabaseName = "RMSDB"


                '  myConnectionInfo.DatabaseName = "RmsLive"
                ' myConnectionInfo.DatabaseName = "RmsJAN"

                '-------------------------------------------------------------------------------------

                myConnectionInfo.UserID = "sa"
                myConnectionInfo.Password = "infocraft.com"

                'myConnectionInfo.UserID = "sa"
                'myConnectionInfo.Password = "password@123"

                '----------------------------------------------------------------------------------------


                SetDBLogonForReport(myConnectionInfo, northwindCustomersReport)
                myCrystalReportViewer.SelectionFormula = selectionForumla

                'Dim crParameterFieldDefinitions As ParameterFieldDefinitions
                'Dim crParameterFieldDefinition As ParameterFieldDefinition
                'Dim crParameterValues As New ParameterValues
                'Dim crParameterDiscreteValue As New ParameterDiscreteValue

                'crParameterDiscreteValue.Value = paraRepVale
                'crParameterFieldDefinitions = northwindCustomersReport.DataDefinition.ParameterFields
                'crParameterFieldDefinition = crParameterFieldDefinitions.Item(paraRepName)
                'crParameterValues = crParameterFieldDefinition.CurrentValues

                'Dim crParameterFieldDefinitions2 As ParameterFieldDefinitions
                'Dim crParameterFieldDefinition2 As ParameterFieldDefinition
                'Dim crParameterValues2 As New ParameterValues
                'Dim crParameterDiscreteValue2 As New ParameterDiscreteValue

                'crParameterValues.Clear()
                'crParameterValues.Add(crParameterDiscreteValue)
                'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                'crParameterDiscreteValue2.Value = paraRepVale2
                'crParameterFieldDefinitions2 = northwindCustomersReport.DataDefinition.ParameterFields
                'crParameterFieldDefinition2 = crParameterFieldDefinitions2.Item(paraRepName2)
                'crParameterValues2 = crParameterFieldDefinition2.CurrentValues

                'crParameterValues2.Clear()
                'crParameterValues2.Add(crParameterDiscreteValue2)
                'crParameterFieldDefinition2.ApplyCurrentValues(crParameterValues2)

                northwindCustomersReport.SummaryInfo.ReportTitle = rptTitle
                myCrystalReportViewer.ReportSource = northwindCustomersReport

            End If





            If reporttype = 2 Then



                'Dim ServerName As String = "INFORMS\INFOCRAFT"

                '------------------------------------------------------------

                '  Dim ServerName As String = "RASHAD-PC\RASHADSQL"
                Dim ServerName As String = "192.168.0.100\INFOCRAFT"


                '------------------------------------------------------------



                northwindCustomersReport = New ReportDocument()
                Dim reportPath As String = String.Format("{0}\Reports\{1}", Application.StartupPath, rptPath) ' "tmpReport.rpt" '"rptQuation.rpt"
                northwindCustomersReport.Load(reportPath)
                northwindCustomersReport.Refresh()
                Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()

                myConnectionInfo.ServerName = ServerName

                myConnectionInfo.DatabaseName = "RMSDB"

                ' myConnectionInfo.DatabaseName = "RmsLive"

                '  myConnectionInfo.DatabaseName = "RmsJAN"

                '----------------------------------------------------------------

                'myConnectionInfo.UserID = "sa"
                'myConnectionInfo.Password = "password@123"


                myConnectionInfo.UserID = "sa"
                myConnectionInfo.Password = "infocraft.com"


                '------------------------------------------------------------

                SetDBLogonForReport(myConnectionInfo, northwindCustomersReport)
                myCrystalReportViewer.SelectionFormula = selectionForumla

                Dim crParameterFieldDefinitions As ParameterFieldDefinitions
                Dim crParameterFieldDefinition As ParameterFieldDefinition
                Dim crParameterValues As New ParameterValues
                Dim crParameterDiscreteValue As New ParameterDiscreteValue

                crParameterDiscreteValue.Value = paraRepVale
                crParameterFieldDefinitions = northwindCustomersReport.DataDefinition.ParameterFields
                crParameterFieldDefinition = crParameterFieldDefinitions.Item(paraRepName)
                crParameterValues = crParameterFieldDefinition.CurrentValues

                Dim crParameterFieldDefinitions2 As ParameterFieldDefinitions
                Dim crParameterFieldDefinition2 As ParameterFieldDefinition
                Dim crParameterValues2 As New ParameterValues
                Dim crParameterDiscreteValue2 As New ParameterDiscreteValue

                crParameterValues.Clear()
                crParameterValues.Add(crParameterDiscreteValue)
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

                crParameterDiscreteValue2.Value = paraRepVale2
                crParameterFieldDefinitions2 = northwindCustomersReport.DataDefinition.ParameterFields
                crParameterFieldDefinition2 = crParameterFieldDefinitions2.Item(paraRepName2)
                crParameterValues2 = crParameterFieldDefinition2.CurrentValues

                crParameterValues2.Clear()
                crParameterValues2.Add(crParameterDiscreteValue2)
                crParameterFieldDefinition2.ApplyCurrentValues(crParameterValues2)

                northwindCustomersReport.SummaryInfo.ReportTitle = rptTitle
                myCrystalReportViewer.ReportSource = northwindCustomersReport


            End If





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
End Class