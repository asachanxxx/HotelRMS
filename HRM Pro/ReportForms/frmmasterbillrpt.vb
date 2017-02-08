Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
Public Class frmmasterbillrpt

    Private Sub frmmasterbillrpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calfrom.Text = Date.Today
        calto.Text = Date.Today
        roomnoload()
    End Sub

    Private Sub roomnoload()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()
            dcSearch = New SqlCommand("select DISTINCT  RoomNo from BillMaster order by RoomNo", Conn)
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbbno.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While
            cmbbno.SelectedIndex = 0
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub filterbyroomno()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        'Dim i As Integer

        Try
            Conn.Open()
            dcSearch = New SqlCommand(" select DISTINCT BillNo from BillMaster where (date between @fdate and @tdate) and roomno= @rno", Conn)

            dcSearch.Parameters.Add("@rno", SqlDbType.VarChar).Value = cmbbno.Text.Trim
            dcSearch.Parameters.Add("@fdate", SqlDbType.DateTime).Value = calfrom.DateTime.Date
            dcSearch.Parameters.Add("@tdate", SqlDbType.DateTime).Value = calto.DateTime.Date
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer


            cmbmbilno.Refresh()
            cmbmbilno.Items.Clear()
            cmbmbilno.Invalidate()

            'i = 0
            If Dscount > 0 Then
                While (DscountTest < Dscount)

                    cmbmbilno.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbmbilno.SelectedIndex = 0


               
            Else
                cmbmbilno.Refresh()
                cmbmbilno.Items.Clear()
                cmbmbilno.Invalidate()
                MsgBox("No Records found")
                cmbmbilno.Text = ""
            End If

            ' cmbobilno.SelectedIndex = 0
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub cmbbno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbno.SelectedIndexChanged
        filterbyroomno()
    End Sub
    Private Sub mbillprint()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        Dim fltString As String
        ' Try
        Conn.Open()
        'Dim Passtopcode As String = topcode

        dcInsertNewAcc = New SqlCommand("masterbilreprint_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@fDate", SqlDbType.DateTime).Value = calfrom.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@tDate", SqlDbType.DateTime).Value = calto.DateTime.Date

        ' dcInsertNewAcc.Parameters.Add("@billno", SqlDbType.VarChar).Value = cmbbilno.Text.ToString
        dcInsertNewAcc.Parameters.Add("@billno", SqlDbType.VarChar).Value = cmbmbilno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@roomno", SqlDbType.VarChar).Value = cmbbno.Text.Trim

        'MsgBox(dtResDate.DateTime.Date + cmbobilno.Text.Trim)


        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
        fltString = ""
        ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

        'ReportName = "New_Occupancy_Report.rpt"
        ReportName = "rpmasterbillsumreprint.rpt"

        ' ReportName = "New_Occupancy_Report _Graphical.rpt"


        rptTitle = "Master Bill Summary Re-Print"

        frmReportViewer.rptPath = ReportName
        frmReportViewer.rptTitle = rptTitle
        'frmReportViewer.selectionForumla = fltString
        frmReportViewer.reporttype = 1


        'frmReportViewer.paraRepName = "para"
        'frmReportViewer.paraRepVale = dattoday.DateTime.Date
        'frmReportViewer.selectionForumla = dattoday.DateTime.Date

        'frmReportViewer.paraRepName2 = "toDate"
        'rmReportViewer.paraRepVale2 = dtResDate2.Text.ToString


        frmReportViewer.Show()
    End Sub

    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        mbillprint()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
End Class