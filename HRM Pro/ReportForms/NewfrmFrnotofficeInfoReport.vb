Imports System.Data.SqlClient
Public Class NewfrmFrnotofficeInfoReport

    Private Sub NewfrmOccupancy_Status_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        dtResDate.Text = Date.Today
        ' dtResDate2.Text = Date.Today
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        InsertTempOccupancy()
        'InsertTempNationality()
        'InsertTempRptTourOperator()
        'InsertTempMealPlan()
        'InsertTempDepMealPlan()
        printreport()
    End Sub
    Private Sub InsertTempOccupancy()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        dcInsertNewAcc = New SqlCommand("TempOccupancyFrontOfficeRpt_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@ArrDate1", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@ArrDate2", SqlDbType.DateTime).Value = dtResDate.DateTime.Date.AddDays(1)
        dcInsertNewAcc.Parameters.Add("@ArrDate3", SqlDbType.DateTime).Value = dtResDate.DateTime.Date.AddDays(2)
        dcInsertNewAcc.Parameters.Add("@ArrDate4", SqlDbType.DateTime).Value = dtResDate.DateTime.Date.AddDays(3)
        dcInsertNewAcc.Parameters.Add("@ArrDate5", SqlDbType.DateTime).Value = dtResDate.DateTime.Date.AddDays(4)
        dcInsertNewAcc.Parameters.Add("@ArrDate6", SqlDbType.DateTime).Value = dtResDate.DateTime.Date.AddDays(5)
        dcInsertNewAcc.Parameters.Add("@ArrDate7", SqlDbType.DateTime).Value = dtResDate.DateTime.Date.AddDays(6)

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub InsertTempRptTourOperator()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        dcInsertNewAcc = New SqlCommand("TempRptTourOperator_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        'dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
        ' dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Dat


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()

    End Sub
    Private Sub InsertTempNationality()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        dcInsertNewAcc = New SqlCommand("TempNationality_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        'dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
        ' dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Dat


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub InsertTempMealPlan()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        dcInsertNewAcc = New SqlCommand("TempMealPlan_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        'dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
        ' dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Dat


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub InsertTempDepMealPlan()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        dcInsertNewAcc = New SqlCommand("TempDepMealPlan_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        'dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
        ' dcInsertNewAcc.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Dat


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

            dcIns = New SqlCommand("LoadTempOccupancyFrontOffRpt_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure

            'dcIns = New SqlCommand("LoadTempNationality_SP", Conn)
            'dcIns.CommandType = CommandType.StoredProcedure

            'dcIns = New SqlCommand("LoadTempRptTourOperator_SP", Conn)
            'dcIns.CommandType = CommandType.StoredProcedure

            'dcIns = New SqlCommand("LoadTempMealPlan_SP", Conn)
            'dcIns.CommandType = CommandType.StoredProcedure

            'dcIns = New SqlCommand("LoadDepTempMealPlan_SP", Conn)
            'dcIns.CommandType = CommandType.StoredProcedure

            
            dcIns.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            ReportName = "Front_Office_Information_Report.rpt"
            rptTitle = "Front_Office_Information_Report"

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

    Private Sub NewfrmFrnotofficeInfoReport_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class