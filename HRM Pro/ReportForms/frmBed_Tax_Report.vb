Imports System.Data.SqlClient
Public Class frmBed_Tax_Report

    Private Sub frmBed_Tax_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtResDate.Text = Date.Today
        dtResDate2.Text = Date.Today

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Try

            'Dim Conn As New SqlConnection(ConnString)
            'Dim sqlString As String
            'Dim dcIns As New SqlCommand()
            'Dim daMain As New SqlDataAdapter()
            'Dim dsMain As New DataSet


            'Dim ReportName As String = ""
            'Dim rptTitle As String = ""

            'Dim fltString As String

            'Dim frmMonth As Integer = dtResDate.DateTime.Date.Month
            'Dim toMonth As Integer = dtResDate2.DateTime.Date.Month

            'Dim frmYear As Integer = dtResDate.DateTime.Date.Year
            'Dim toYear As Integer = dtResDate2.DateTime.Date.Year

            'Try

            '    Conn.Open()

            '    dcIns = New SqlCommand("select * from TempBedTax", Conn)
            '    ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            '    dcIns.CommandType = CommandType.Text
            '    dcIns.ExecuteNonQuery()

            '    ' dtResDate.DateTime.Month

            '    fltString = ""

            '    'fltString = "Month({View_1Bed_Tax_Report.ArriveDate}) = #" & frmMonth & "# And Year({View_1Bed_Tax_Report.ArriveDate}) =#" & frmYear & "# Or Month({View_1Bed_Tax_Report.DepDate}) = #" & toMonth & "#  And Year({View_1Bed_Tax_Report.DepDate}) = #" & toYear & "#"

            '    ' fltString = "Month({View_1Bed_Tax_Report.ArriveDate}) = " & frmMonth & " And Year({View_1Bed_Tax_Report.ArriveDate}) =" & frmYear & " Or Month({View_1Bed_Tax_Report.DepDate}) = " & toMonth & "  And Year({View_1Bed_Tax_Report.DepDate}) = " & toYear & ""

            '    'fltString = "Month({View_1Bed_Tax_Report.ArriveDate}) = frmMonth  And Year({View_1Bed_Tax_Report.ArriveDate}) =frmYear Or Month({View_1Bed_Tax_Report.DepDate}) = toMonth And Year({View_1Bed_Tax_Report.DepDate}) = toYear"




            '    ReportName = "New Bed_Tax_Report.rpt"
            '    rptTitle = "Bed_Tax_Report"

            '    frmReportViewer.rptPath = ReportName
            '    frmReportViewer.rptTitle = rptTitle
            '    frmReportViewer.selectionForumla = fltString
            '    frmReportViewer.reporttype = 2

            '    frmReportViewer.paraRepName = "frmDate"
            '    frmReportViewer.paraRepVale = dtResDate.DateTime.Date

            '    frmReportViewer.paraRepName2 = "toDate2"
            '    frmReportViewer.paraRepVale2 = dtResDate2.DateTime.Date


            '    frmReportViewer.Show()

            InsertTemp()

            printreport()





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub InsertTemp()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("TempRptBedTax_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = dtResDate2.DateTime.Date


        ' dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub


    Private Sub printreport()
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

            dcIns = New SqlCommand("LoadRptBedTax_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date

            dcIns.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            ReportName = "New Bed_Tax_Report_Rash.rpt"
            rptTitle = "New Bed Tax Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = "paraArrdate"
            frmReportViewer.paraRepVale = dtResDate.Text.ToString

            'frmReportViewer.paraRepName2 = "paratoDate"
            ' frmReportViewer.paraRepVale2 = ""

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

End Class