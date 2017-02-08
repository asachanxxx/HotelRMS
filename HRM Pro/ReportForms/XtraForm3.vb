Imports System.Data.SqlClient
Imports System.Xml
Imports System.Text.RegularExpressions

Public Class frmtopcon

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub loadtopcon()

        If cmbtoplist.EditValue = "ALL" Then
            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand
            'MsgBox("Code is " + cmbtoplist.EditValue)
            dcInsertNewAcc = New SqlCommand("RPTtopconALL_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            'dcInsertNewAcc.Parameters.Add("@TOP", SqlDbType.Char).Value = cbotopcon.EditValue
            'dcInsertNewAcc.Parameters.Add("@TOP", SqlDbType.Char).Value = Mid(cmbtoplist.EditValue, 1, 4)
            Conn.Open()

            dcInsertNewAcc.CommandTimeout = 100

            dcInsertNewAcc.ExecuteNonQuery()

            Conn.Close()
        Else

            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            dcInsertNewAcc = New SqlCommand("RPTtopcon_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            'dcInsertNewAcc.Parameters.Add("@TOP", SqlDbType.Char).Value = cbotopcon.EditValue
            dcInsertNewAcc.Parameters.Add("@TOP", SqlDbType.Char).Value = Mid(cmbtoplist.EditValue, 1, 4)
            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()

            Conn.Close()

        End If
        

        

    End Sub
    Private Sub printtopcon()
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

            dcIns = New SqlCommand("LoadRPTtopcon_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            'dcIns.Parameters.Add("@ArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
            'dcIns.Parameters.Add("@Month", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
            'dcIns.Parameters.Add("@Year", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
            dcIns.ExecuteNonQuery()

            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            'ReportName = "New_Occupancy_Report.rpt"
            ReportName = "rpttopcon.rpt"

            ' ReportName = "New_Occupancy_Report _Graphical.rpt"


            rptTitle = "Tour Operator Contract List"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            'frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            'frmReportViewer.paraRepName = "fromDate"
            ' frmReportViewer.paraRepVale = dtResDate.Text.ToString

            'frmReportViewer.paraRepName2 = "toDate"
            'rmReportViewer.paraRepVale2 = dtResDate2.Text.ToString

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try

    End Sub
    Private Sub XtraForm3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()
            dcSearch = New SqlCommand("select TopCode,TopName from [Touroperator.Master] where Status='active' order by TopCode", Conn)
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            'Dim dsCcount As Integer = dsMain.Tables(0).Columns.Count
            'Dim DscountTest As Integer

            Dim newCustomersRow As DataRow = dsMain.Tables(0).NewRow()



            'While (DscountTest < Dscount)

            'cbTopcode2.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
            '    DscountTest = DscountTest + 1

            'End While
            cmbtoplist.Properties.Items.Add("ALL")

            'While (DscountTest < Dscount)
            'cmbtoplist.Properties.Items.Add(dsMain.Tables(0).Columns(0)(DscountTest).tostring())

            For rowcount As Integer = 0 To Dscount - 1
                'For colcount As Integer = 0 To dsCcount - 1

                cmbtoplist.Properties.Items.Add(dsMain.Tables(0).Rows(rowcount)(0).ToString() + " - " + dsMain.Tables(0).Rows(rowcount)(1).ToString())
                'cmbtoplist.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(colcount).ToString())

                'DscountTest = DscountTest + 1
                'colcount = colcount + 1
                'Next

                rowcount = rowcount + 1

            Next

            'End While
            cmbtoplist.SelectedIndex = 0


7:

            'cbotopcon.Properties.Columns.Add(New LookUpColumnInfo("TopCode", "ALL", 100))
            'lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name", 80));

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        loadtopcon()
        printtopcon()
    End Sub


   
End Class