Imports System.Data.SqlClient
Public Class NewfrmOccupancyTOP

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        InsertTemp()
        print()
    End Sub

    Private Sub NewfrmOccupancyTOP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtResDate.Text = Date.Today
        dtResDate2.Text = Date.Today
    End Sub

    Private Sub InsertTemp()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("RptRptOccupancyTOP_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@frmDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtResDate2.DateTime.Date
        Conn.Open()
        dcInsertNewAcc.CommandTimeout = 100

        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub

    Private Sub print()
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

            dcIns = New SqlCommand("select * from rpt_Occupancy_Report_Of_Room_By_Operator_View", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()



            fltString = ""
            'fltString = "{rpt_Occupancy_Report_Of_Room_By_Operator_View.EnteredDate} >=#" & dtResDate.Text & "# and {rpt_Occupancy_Report_Of_Room_By_Operator_View.EnteredDate}<=#" & dtResDate2.Text & "#"



            ReportName = "NewOccuReportResByTOP.rpt"
            rptTitle = "Occupancy Report By TOP"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = ""
            frmReportViewer.paraRepVale = ""

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


    Private Sub NewfrmOccupancyTOP_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class