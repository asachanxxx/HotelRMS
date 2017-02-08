Imports System.Data.SqlClient
Public Class NewfrmGuest_List_In_House

    Private Sub NewfrmGuest_List_In_House_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        dtResDate.Text = Date.Today
        'dtResDate2.Text = Date.Today
        dtfrom.Text = Date.Today
        dtto.Text = Date.Today
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

            dcIns = New SqlCommand("select * from View_1Guest_List_For_IN_HOUSE", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()



            fltString = ""
            'fltString = "{rpt_Occupancy_Report_Of_Rooms_By_Bedding_View.ReservationDate}=#" & dtResDate.Text & "#"
            ' fltString = "{View_1Guest_List_For_IN_HOUSE.ResDate} >=#" & dtResDate.Text & "#"


            ReportName = "rptguestINhouse.rpt"
            rptTitle = "NewGuest_List_For_In_House"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = ""
            frmReportViewer.paraRepVale = ""

            'frmReportViewer.paraRepName2 = "toDate"
            ' frmReportViewer.paraRepVale2 = dtResDate2.Text.ToString

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub NewfrmGuest_List_In_House_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub LabelControl2_Click(sender As Object, e As EventArgs) Handles LabelControl2.Click

    End Sub

    Private Sub LabelControl4_Click(sender As Object, e As EventArgs) Handles LabelControl4.Click

    End Sub

    Private Sub btnviewhis_Click(sender As Object, e As EventArgs) Handles btnviewhis.Click
        'InsertTempvwhis()
        printreportvwhis()
    End Sub


    Private Sub printreportvwhis()
        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        ' Dim bdayMonth As Integer = dtResDate.DateTime.Date.Month
        ' Dim bdayday As Integer = dtResDate.DateTime.Date.Day
        ' Dim tomonth As Integer = todate.DateTime.Date.Month
        ' Dim today As Integer = todate.DateTime.Date.Day



        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        'Dim fltString As String

        Try

            Conn.Open()

            ' dcIns = New SqlCommand("select * from View_1Birthday_Report where month(dob) between " & bdayMonth & " and " & tomonth & " and  DAY (dob) between " & bdayday & " and " & today & "", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            dcInsertNewAcc = New SqlCommand("inhousevwhis_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@fDate", SqlDbType.DateTime).Value = dtfrom.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@tdate", SqlDbType.DateTime).Value = dtto.DateTime.Date
           
            ' dcIns.ExecuteNonQuery()
            dcInsertNewAcc.ExecuteNonQuery()


            'fltString = "Month({View_1Birthday_Report.DOB}) = " & bdayMonth & " And Day({View_1Birthday_Report.DOB}) =" & bdayday & " Between Month({View_1Birthday_Report.DOB}) = " & tomonth & " And Day({View_1Birthday_Report.DOB}) =" & today & """"


            If chkroom.Checked = True Then
                ReportName = "rptguestINhousehis.rpt"
                rptTitle = "Guest in House history view"
                frmReportViewer.rptPath = ReportName
                frmReportViewer.rptTitle = rptTitle
                frmReportViewer.reporttype = 1
                frmReportViewer.Show()
            ElseIf chkarr.Checked = True Then
                ReportName = "rptguestINhousehisbyarr.rpt"
                rptTitle = "Guest in House history view"
                frmReportViewer.rptPath = ReportName
                frmReportViewer.rptTitle = rptTitle
                frmReportViewer.reporttype = 1
                frmReportViewer.Show()
            ElseIf chkmp.Checked = True Then
                ReportName = "rptguestINhousehisbymp.rpt"
                rptTitle = "Guest in House history view"
                frmReportViewer.rptPath = ReportName
                frmReportViewer.rptTitle = rptTitle
                frmReportViewer.reporttype = 1
                frmReportViewer.Show()
            ElseIf chktop.Checked = True Then
                ReportName = "rptguestINhousehisbytop.rpt"
                rptTitle = "Guest in House history view"
                frmReportViewer.rptPath = ReportName
                frmReportViewer.rptTitle = rptTitle
                frmReportViewer.reporttype = 1
                frmReportViewer.Show()



            End If
            


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()


        End Try
    End Sub

    Private Sub chkroom_CheckedChanged(sender As Object, e As EventArgs) Handles chkroom.CheckedChanged
        If chkroom.Checked = True Then
            chkmp.Checked = False
            chktop.Checked = False
            chkarr.Checked = False
        Else
            chkroom.Checked = False
        End If
    End Sub

    Private Sub chkarr_CheckedChanged(sender As Object, e As EventArgs) Handles chkarr.CheckedChanged
        If chkarr.Checked = True Then
            chkmp.Checked = False
            chktop.Checked = False
            chkroom.Checked = False
        Else
            chkarr.Checked = False
        End If
    End Sub

    Private Sub chkmp_CheckedChanged(sender As Object, e As EventArgs) Handles chkmp.CheckedChanged
        If chkmp.Checked = True Then
            chkarr.Checked = False
            chktop.Checked = False
            chkroom.Checked = False
        Else
            chkmp.Checked = False
        End If
    End Sub

    Private Sub chktop_CheckedChanged(sender As Object, e As EventArgs) Handles chktop.CheckedChanged
        If chktop.Checked = True Then
            chkmp.Checked = False
            chkroom.Checked = False
            chkarr.Checked = False
        Else
            chktop.Checked = False
        End If
    End Sub
End Class