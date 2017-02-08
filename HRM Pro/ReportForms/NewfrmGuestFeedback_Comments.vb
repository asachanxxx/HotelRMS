Imports System.Data.SqlClient
Public Class NewfrmGuestFeedback_Comments

    Private Sub NewfrmGuestFeedback_Comments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtResDate.Text = DateTime.Now.Date
        dtfrom.Text = Date.Today
        dtto.Text = Date.Today

        LoadRoomNo()
    End Sub
    Private Sub LoadRoomNo()

        'Dim Conn As New SqlConnection(ConnString)
        'Dim daMain As New SqlDataAdapter
        'Dim dsMain As New DataSet
        'Dim dcSearch As New SqlCommand
        'Try
        '    Conn.Open()
        '    dcSearch = New SqlCommand("select Roomno from [Rooms.Master] order by Roomno", Conn)

        '    daMain = New SqlDataAdapter()
        '    daMain.SelectCommand = dcSearch
        '    daMain.Fill(dsMain)

        '    Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
        '    Dim DscountTest As Integer

        '    While (DscountTest < Dscount)

        '        cmbRm.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
        '        DscountTest = DscountTest + 1

        '    End While

        '    cmbRm.SelectedIndex = 0

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        'Finally
        '    Conn.Dispose()
        '    daMain.Dispose()
        '    dsMain.Dispose()
        'End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim Conn As New SqlConnection(ConnString)
        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet


        Dim ReportName As String = ""
        Dim rptTitle As String = ""


        Dim frmMonth As Integer = dtResDate.DateTime.Date.Month

        Dim frmYear As Integer = dtResDate.DateTime.Date.Year

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from View_1Guest_Feedback_Comments", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text


            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()



            fltString = ""
            'fltString = "{View_1Guest_Feedback_Comments.EnteredDate} = #" & dtResDate.Text & "#"

            'fltString = "Month({View_1Guest_Feedback_Comments.EnteredDate}) = " & frmMonth & " And Year({View_1Guest_Feedback_Comments.EnteredDate}) =" & frmYear & ""


            ReportName = "NewGuestFeedBack_Comments.rpt"
            rptTitle = "NewGuestFeedBack_Comments"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1


            frmReportViewer.paraRepName = ""
            frmReportViewer.paraRepVale = ""

            'frmReportViewer.paraRepName = "fromDate"
            'frmReportViewer.paraRepVale = dtResDate.Text.ToString

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

    Private Sub NewfrmGuestFeedback_Comments_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub btnviewhis_Click(sender As Object, e As EventArgs) Handles btnviewhis.Click
        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


      


        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        'Dim fltString As String

        Try

            Conn.Open()

            ' dcIns = New SqlCommand("select * from View_1Birthday_Report where month(dob) between " & bdayMonth & " and " & tomonth & " and  DAY (dob) between " & bdayday & " and " & today & "", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            dcInsertNewAcc = New SqlCommand("feedbk_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@fDate", SqlDbType.DateTime).Value = dtfrom.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@tdate", SqlDbType.DateTime).Value = dtto.DateTime.Date

            ' dcIns.ExecuteNonQuery()
            dcInsertNewAcc.ExecuteNonQuery()


            'fltString = "Month({View_1Birthday_Report.DOB}) = " & bdayMonth & " And Day({View_1Birthday_Report.DOB}) =" & bdayday & " Between Month({View_1Birthday_Report.DOB}) = " & tomonth & " And Day({View_1Birthday_Report.DOB}) =" & today & """"



            ReportName = "rptfeedbk.rpt"
            rptTitle = "Guest Feedback report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            ' frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1


      
            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()


        End Try
    End Sub
End Class