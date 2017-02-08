Imports System.Data.SqlClient
Public Class frmItemConumption

    Private Sub frmItemConumption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadOutlets()
    End Sub
    Private Sub LoadOutlets()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Department from [DepartmentMaster]  order by Department", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            cbTopcode.Properties.Items.Add("ALL")

            While (DscountTest < Dscount)

                cbTopcode.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cbTopcode.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

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

            dcIns = New SqlCommand("select * from rpt_ItemConsumption", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()

            If cbTopcode.Text = "ALL" Then


                'fltString = "Date({rpt_ItemConsumption.Date}) =>#" & dtResDate.Text & "# "
                fltString = "DateValue ({rpt_ItemConsumption.Date})=#" & dtResDate.Text & "# "


                'CONVERT (DATE, [Date]) =#" & dtResDate.Text & "#  and active=1 and Department='Coffee Shop'



            Else

                Dim gettopcode As String = cbTopcode.Text.Trim

                fltString = "DateValue ({rpt_ItemConsumption.Date})=#" & dtResDate.Text & "#  and {rpt_ItemConsumption.Department} ='" + gettopcode + "'"


            End If



            'and {rpt_Reservation_Creation___Deletion_Report_View.Status}='CLOSED'

            ReportName = "ItemConsumption.rpt"
            rptTitle = "Item_Consumption_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = "fromDate"
            frmReportViewer.paraRepVale = dtResDate.Text.ToString

            'frmReportViewer.paraRepName2 = "toDate"
            'frmReportViewer.paraRepVale2 = dtResDate2.Text.ToString


            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub
End Class