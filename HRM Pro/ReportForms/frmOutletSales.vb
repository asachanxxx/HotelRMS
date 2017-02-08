Imports System.Data.SqlClient


Public Class frmOutletSales

    Private Sub frmOutletSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        dtDate.Text = Date.Today
        dtDate2.Text = Date.Today



        LoadOutlets()


    End Sub
    Private Sub LoadOutlets()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Department from [DepartmentMaster]  order by Department", Conn)

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

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        InsertTemp()
        print()

    End Sub

    Private Sub InsertTemp()

      

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand



        Dim outlettype As Integer = 0

        If cbTopcode.Text.Trim = "ALL" Then
            outlettype = 2

        Else
            outlettype = 1

        End If


        dcInsertNewAcc = New SqlCommand("RptOutletsalesDetail_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@frmDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@toDate", SqlDbType.DateTime).Value = dtDate2.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@outlet", SqlDbType.VarChar).Value = cbTopcode.Text.Trim
        dcInsertNewAcc.Parameters.Add("@type", SqlDbType.Int).Value = outlettype


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

            dcIns = New SqlCommand("select * from TempOutletsalesDetail order by OutletMasBill", Conn)

          

            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()



            ReportName = "rptOutletsalesdetails.rpt"
            rptTitle = "rptOutletsalesdetails_Report"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = ""
            frmReportViewer.paraRepVale = dtDate.Text.ToString



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

End Class