Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit

Public Class frmoutbillreprint

    Private Sub frmmbillreprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        roomnoload()
        bilnoload()


        dtResDate.Text = Date.Today
        dtResDate2.Text = Date.Today

    End Sub
    Private Sub bilnoload()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()
            dcSearch = New SqlCommand("select BillNo from OutLetBillMaster order by billno", Conn)
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim newCustomersRow As DataRow = dsMain.Tables(0).NewRow()
            For rowcount As Integer = 0 To Dscount - 1
                ' cmbbilno.Properties.Items.Add(dsMain.Tables(0).Rows(rowcount)(0).ToString())
                cmbbno.Items.Add(dsMain.Tables(0).Rows(rowcount)(0).ToString())
                rowcount = rowcount + 1
            Next
            'cmbbno.SelectedIndex = 0
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try


    End Sub
    Private Sub roomnoload()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()
            dcSearch = New SqlCommand("select RoomNo from [Room.CurrentStatus] order by roomno", Conn)
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer
            ' Dim newCustomersRow As DataRow = dsMain.Tables(0).NewRow()
            ' For rowcount As Integer = 0 To Dscount - 1
            'cmbobilno.Properties.Items.Add(dsMain.Tables(0).Rows(rowcount)(0).ToString())
            '  rowcount = rowcount + 1
            ' Next
            While (DscountTest < Dscount)

                cmbobilno.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While
            cmbobilno.SelectedIndex = 0
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub roomnopuldown()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        'Dim i As Integer

        Try
            Conn.Open()
            ' dcSearch = New SqlCommand("select * from OutLetBillMaster where (BillGeneratedDate between '" + dtResDate.ToString + "' and '" + dtResDate2.ToString + "')  and roomno= " + cmbobilno.Text.ToString, Conn)
            dcSearch = New SqlCommand("select BillNo from OutLetBillMaster where (BillGeneratedDate between @fdate and @tdate)  and roomno= @rno", Conn)

            dcSearch.Parameters.Add("@fdate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
            dcSearch.Parameters.Add("@tdate", SqlDbType.DateTime).Value = dtResDate2.DateTime.Date
            dcSearch.Parameters.Add("@rno", SqlDbType.VarChar).Value = cmbobilno.Text.Trim
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            'Dim newCustomersRow As DataRow = dsMain.Tables(0).NewRow()
            cmbbno.Refresh()
            cmbbno.Items.Clear()
            cmbbno.Invalidate()
            'cmbobilno.Refresh()
            'i = 0
            If Dscount > 0 Then
                While (DscountTest < Dscount)

                    cmbbno.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbbno.SelectedIndex = 0


                '' For rowcount As Integer = 0 To Dscount - 1


                ''cmbbno.Items.Add(dsMain.Tables(0).Rows(rowcount)(0).ToString())
                'cmbbilno.Properties.Items.Add(dsMain.Tables(0).Rows(rowcount)(0).ToString())
                ''rowcount = rowcount + 1
                ''Next
                ''cmbbno.SelectedIndex = 0
            Else
                cmbbno.Refresh()
                cmbbno.Items.Clear()
                cmbbno.Invalidate()
                MsgBox("No Records found")
                cmbbno.Text = ""
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
    Private Sub outbillreprint()
         Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        Dim fltString As String
        ' Try
        Conn.Open()
        'Dim Passtopcode As String = topcode

        dcInsertNewAcc = New SqlCommand("outletbilreprint_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@fDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@tDate", SqlDbType.DateTime).Value = dtResDate2.DateTime.Date

        ' dcInsertNewAcc.Parameters.Add("@billno", SqlDbType.VarChar).Value = cmbbilno.Text.ToString
        dcInsertNewAcc.Parameters.Add("@billno", SqlDbType.VarChar).Value = cmbbno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@roomno", SqlDbType.VarChar).Value = cmbobilno.Text.Trim

        'MsgBox(dtResDate.DateTime.Date + cmbobilno.Text.Trim)


        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
        fltString = ""
        ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

        'ReportName = "New_Occupancy_Report.rpt"
        ReportName = "rptoutletbillsum.rpt"

        ' ReportName = "New_Occupancy_Report _Graphical.rpt"


        rptTitle = "Outlet Bill Summary"

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

    

   
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        outbillreprint()
        ' MsgBox("clicked")

    End Sub

    Private Sub cmbobilno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbobilno.SelectedIndexChanged
        'select * from OutLetBillMaster  where RoomNo=150 and BillGeneratedDate= '2013-03-06'
        ' roomnopuldown()
        
    End Sub

    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        roomnopuldown()
    End Sub
End Class