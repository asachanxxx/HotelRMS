Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Net.Mail

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

                ' Dim ServerName As String = "RASHAD-PC"
                ' Dim ServerName As String = "192.168.0.100\INFOCRAFT"

                Dim ServerName As String = RMSDBSVR

                '----------------------------------------------------------------------

                northwindCustomersReport = New ReportDocument()
                Dim reportPath As String = String.Format("{0}\Reports\{1}", Application.StartupPath, rptPath) ' "tmpReport.rpt" '"rptQuation.rpt"
                northwindCustomersReport.Load(reportPath)
                northwindCustomersReport.Refresh()


                Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
                myConnectionInfo.ServerName = ServerName

                myConnectionInfo.DatabaseName = RMSDBNAME

                'myConnectionInfo.DatabaseName = "RMSDB"
                ' myConnectionInfo.DatabaseName = "RmsLive"
                '  myConnectionInfo.DatabaseName = "RMSJUN"

                '-------------------------------------------------------------------------------------

                myConnectionInfo.UserID = RMSDBUSER
                myConnectionInfo.Password = RMSDBPASS

                'myConnectionInfo.UserID = "sa"
                'myConnectionInfo.Password = "password@123"

                '----------------------------------------------------------------------------------------


                SetDBLogonForReport(myConnectionInfo, northwindCustomersReport)
                myCrystalReportViewer.SelectionFormula = selectionForumla

             

                northwindCustomersReport.SummaryInfo.ReportTitle = rptTitle
                myCrystalReportViewer.ReportSource = northwindCustomersReport





                If Pubmailfunction = 1 Then



                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Send Reservation Confirmation To Guest", "Email Reservation Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


                    If bt = Windows.Forms.DialogResult.Yes Then



                        If PubResEmail = "" Then


                            MsgBox("Guest's E-mail address is not defined", MsgBoxStyle.Critical, "SBSCC Exception")

                        Else

                            Dim ExPdfFile As String = "D:\ReservationConfirmations\" + PubResConNo + ".pdf"

                            Dim CrExportOptions As ExportOptions
                            Dim CrDiskFileDestinationOptions As New  _
                            DiskFileDestinationOptions()
                            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                            CrDiskFileDestinationOptions.DiskFileName = _
                                                        ExPdfFile.ToString()
                            CrExportOptions = northwindCustomersReport.ExportOptions
                            With CrExportOptions
                                .ExportDestinationType = ExportDestinationType.DiskFile
                                .ExportFormatType = ExportFormatType.PortableDocFormat
                                .DestinationOptions = CrDiskFileDestinationOptions
                                .FormatOptions = CrFormatTypeOptions
                            End With
                            northwindCustomersReport.Export()



                            Dim mail As New MailMessage()
                            Dim SmtpServer As New SmtpClient("smtp.gmail.com")

                            ' Dim SmtpServer As New SmtpClient("mail.pch.com.mv")

                            mail.From = New MailAddress("Res.confirmations@gmail.com")
                            mail.[To].Add("rashad@infocraft.lk")
                            mail.Subject = "Reservation Confirmation-" + PubResConNo
                            mail.Body = "Please find the attached Reservation Confirmation for Reservation no : " + PubResConNo.ToString

                            Dim attachment As System.Net.Mail.Attachment
                            attachment = New System.Net.Mail.Attachment(ExPdfFile)
                            mail.Attachments.Add(attachment)

                            SmtpServer.Port = 587
                            ' SmtpServer.Port = 26

                            SmtpServer.Credentials = New System.Net.NetworkCredential("res.confirmations@gmail.com", "Eriyadu@123")
                            SmtpServer.EnableSsl = True

                            SmtpServer.Send(mail)
                            MessageBox.Show("Reservation Confirmation has been sent to Guest's Email " + PubResEmail.ToString, "Email Send to Guest", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        End If

                        '-------------------------------------



                    End If


                    '-----------------------------------------

                End If


            End If





            If reporttype = 2 Then



                'Dim ServerName As String = "INFORMS\INFOCRAFT"

                '------------------------------------------------------------

                ' Dim ServerName As String = "RASHAD-PC"
                ' Dim ServerName As String = "192.168.0.100\INFOCRAFT"
                Dim ServerName As String = RMSDBSVR


                '------------------------------------------------------------



                northwindCustomersReport = New ReportDocument()
                Dim reportPath As String = String.Format("{0}\Reports\{1}", Application.StartupPath, rptPath) ' "tmpReport.rpt" '"rptQuation.rpt"
                northwindCustomersReport.Load(reportPath)
                northwindCustomersReport.Refresh()
                Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()

                myConnectionInfo.ServerName = ServerName


                myConnectionInfo.DatabaseName = RMSDBNAME



                'myConnectionInfo.DatabaseName = "RMSDB"

                ' myConnectionInfo.DatabaseName = "RmsLive"

                ' myConnectionInfo.DatabaseName = "RMSJUN"

                '----------------------------------------------------------------

                'myConnectionInfo.UserID = "sa"
                'myConnectionInfo.Password = "password@123"


                myConnectionInfo.UserID = RMSDBUSER
                myConnectionInfo.Password = RMSDBPASS


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