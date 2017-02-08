Imports System.Data.SqlClient
Public Class NewOccupancyTopDetails

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        InsertTemp()
        Print()
    End Sub

    Private Sub NewOccupancyTopDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtResDate.Text = Date.Today
        dtResDate2.Text = Date.Today

        LoadTopcodes()

    End Sub

    Private Sub InsertTemp()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        DeleteTempOccTbl()

        Dim startDate As DateTime = dtResDate.DateTime.Date
        Dim endDate As DateTime = dtResDate2.DateTime.Date

        Dim NoofDays As Integer = DateDiff(DateInterval.Day, startDate, endDate) + 1


        Dim getStartDate As DateTime = startDate

        While (getStartDate <= endDate)


            dcInsertNewAcc = New SqlCommand("TempOccuTopDetailsRpt_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = getStartDate
            dcInsertNewAcc.Parameters.Add("@Days", SqlDbType.Int).Value = NoofDays
            dcInsertNewAcc.Parameters.Add("@Top", SqlDbType.VarChar).Value = cbTopcode.Text.Trim
            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()


            getStartDate = DateAdd(DateInterval.Day, 1, getStartDate)


        End While

    End Sub
    Private Sub DeleteTempOccTbl()


        Try



            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            dcInsertNewAcc = New SqlCommand("delete from TempOccupTopDetailRpt", Conn)
            dcInsertNewAcc.CommandType = CommandType.Text


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

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



            ReportName = "OccupancyTopDetail.rpt"
            rptTitle = "Occupancy Report By TOP Details"

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
    Private Sub LoadTopcodes()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select TopCode from [Touroperator.Master] WHERE Status='ACTIVE' order by TopCode", Conn)

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
End Class