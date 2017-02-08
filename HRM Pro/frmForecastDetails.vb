Imports System.Data.SqlClient
Public Class frmForecastDetails

    Private Sub frmForecastDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        DtFrm.Text = DateTime.Now.Date
        DtTo.Text = DateTime.Now.Date

    End Sub
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        LoadForecastDetails()
    End Sub
    Private Sub LoadForecastDetails()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select ResNo,ResDate,Guest,ResType,Topcode,ArrDate,DepDate,AdultQty,ChildrenQty,InfantsQty,MealPlan from dbo.[Reservation.Master] where Status='OPEN' AND ArrDate >= @FromDate and ArrDate <= @ToDate order by ArrDate", Conn)
            dcSearch.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = DtTo.DateTime.Date
            dcSearch.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = DtFrm.DateTime.Date

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            If dsMain.Tables(0).Rows.Count > 0 Then

                gcForecast.DataSource = dsMain.Tables(0)

            Else

                MessageBox.Show("No Records", "Arrivals", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

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

            'dcIns = New SqlCommand("select * from rpt_Expected_Arrival_Departures_View where Status='OPEN'", Conn)
            '' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            'dcIns.CommandType = CommandType.Text
            'dcIns.ExecuteNonQuery()

            dcIns = New SqlCommand("LoadRptForecast_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@frmDate", SqlDbType.DateTime).Value = DtFrm.DateTime
            'dcIns.Parameters.Add("@toDate", SqlDbType.DateTime).Value = DtTo.DateTime

            dcIns.ExecuteNonQuery()



            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            ReportName = "Forecast.rpt"
            rptTitle = "Forecast Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 2

            frmReportViewer.paraRepName = "parafrmDate"
            frmReportViewer.paraRepVale = DtFrm.Text.ToString

            frmReportViewer.paraRepName2 = "paratoDate"
            frmReportViewer.paraRepVale2 = DtTo.Text.ToString

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click
        InsertTemp()
        printreport()
    End Sub
    Private Sub InsertTemp()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("RptOccRepPaxMealPlan_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@frmDate", SqlDbType.DateTime).Value = DtFrm.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@toDate", SqlDbType.DateTime).Value = DtTo.DateTime.Date
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub

    Private Sub frmForecastDetails_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class