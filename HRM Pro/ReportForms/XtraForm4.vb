
Imports System.Data.SqlClient

Public Class frmDailyFrnt

   
    Private Sub insertcom()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("com_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.AddWithValue("@selDate", dtdate.DateTime.Date)


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub insertvisoff()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("visoff_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.AddWithValue("@selDate", dtdate.DateTime.Date)


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub inserttdykit()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("tdykit_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.AddWithValue("@selDate", dtdate.DateTime.Date)


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub insertdailyocc()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("dailyocc_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.AddWithValue("@selDate", dtdate.DateTime.Date)


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub insertroomcount()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("roomcount_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.AddWithValue("@selDate", dtdate.DateTime.Date)


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub inserttdymp()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("tdymp_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.AddWithValue("@selDate", dtdate.DateTime.Date)


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub inserttodayroom()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("todayroom_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@selDate", SqlDbType.DateTime).Value = dtdate.DateTime.Date.ToString


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub insertfrntGuest()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("frntGuest_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.AddWithValue("@selDate", dtdate.DateTime.Date)


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()
    End Sub
    Private Sub insertfrntGuestArr()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Conn.Open()

        dcInsertNewAcc = New SqlCommand("frntGuestArr_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.AddWithValue("@selDate", dtdate.DateTime.Date)



        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()

       
    End Sub
    Private Sub insertrec()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Conn.Open()

        dcInsertNewAcc = New SqlCommand("rec_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.AddWithValue("@mrn", txtmor.Text.ToString)
        dcInsertNewAcc.Parameters.AddWithValue("@aft", txtaft.Text.ToString)
        dcInsertNewAcc.Parameters.AddWithValue("@eve", txteve.Text.ToString)
        dcInsertNewAcc.Parameters.AddWithValue("@ni8", txtni8.Text.ToString)
        dcInsertNewAcc.Parameters.AddWithValue("@selDate", dtdate.DateTime.Date)



        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()


    End Sub
    Private Sub printfrntdaily()

        Dim Conn As New SqlConnection(ConnString)
        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet


        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        Dim fltString As String

        Try
             


            dcIns = New SqlCommand("mainRPT_SP", Conn)
            dcIns.CommandType = CommandType.StoredProcedure
            dcIns.Parameters.AddWithValue("@dDate", dtdate.DateTime.Date)

            Conn.Open()
            dcIns.ExecuteNonQuery()
            Conn.Close()


            fltString = ""
            ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

            'ReportName = "New_Occupancy_Report.rpt"
            ReportName = "DailyFrontOfficeInfo.rpt"

            ' ReportName = "New_Occupancy_Report _Graphical.rpt"


            rptTitle = "Daily Front Office Information"

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


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'insertcom()
        insertvisoff()
        inserttdykit()
        insertdailyocc()
        insertroomcount()
        inserttdymp()
        inserttodayroom()
        insertfrntGuest()
        insertfrntGuestArr()
        insertrec()
        printfrntdaily()

    End Sub
    Private Sub rec()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from tblvisoff", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            If dsMain.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            txtmgt.Text = dsMain.Tables(0).Rows(0)(2).ToString()
            txt1.Text = dsMain.Tables(0).Rows(0)(3).ToString()
            txtd.Text = dsMain.Tables(0).Rows(1)(2).ToString()
            txt3.Text = dsMain.Tables(0).Rows(1)(3).ToString()
            txtj.Text = dsMain.Tables(0).Rows(2)(2).ToString()
            txt4.Text = dsMain.Tables(0).Rows(2)(3).ToString()
            txts.Text = dsMain.Tables(0).Rows(3)(2).ToString()
            txt5.Text = dsMain.Tables(0).Rows(3)(3).ToString()
            txtw.Text = dsMain.Tables(0).Rows(4)(2).ToString()
            txt6.Text = dsMain.Tables(0).Rows(4)(3).ToString()
            txtspa.Text = dsMain.Tables(0).Rows(5)(2).ToString()
            txt7.Text = dsMain.Tables(0).Rows(5)(3).ToString()
            txtv.Text = dsMain.Tables(0).Rows(0)(0).ToString()
            v1.Text = dsMain.Tables(0).Rows(0)(1).ToString()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub bil()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select bilin from tblcom order by bilin", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbbil.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbroomno.SelectedIndex = 1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub comdetail()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select rno from tblcom order by rno", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbroomno.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbroomno.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub frmDailyFrnt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from tblrec", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            dtdate.Text = Date.Today
            lbldat.Text = Date.Today.ToString("dddd d MMM yyyy")
            txtmor.Text = dsMain.Tables(0).Rows(0)(0).ToString()
            txtaft.Text = dsMain.Tables(0).Rows(0)(1).ToString()
            txteve.Text = dsMain.Tables(0).Rows(0)(2).ToString()
            txtni8.Text = dsMain.Tables(0).Rows(0)(3).ToString()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
        comdetail()
        rec()



    End Sub

    

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnup.Click
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("UPDATE tblvisoff set Opax= " + txt1.Text + " WHERE office= " + "'" + "Mangmt" + "'" + "UPDATE tblvisoff set Opax= " + txt3.Text + " WHERE office= " + "'" + "D/Sch" + "'" + "UPDATE tblvisoff set Opax= " + txt4.Text + " WHERE office= " + "'" + "J/Sch" + "'" + "UPDATE tblvisoff set Opax= " + txt5.Text + " WHERE office= " + "'" + "S/Sch" + "'" + "UPDATE tblvisoff set Opax= " + txt6.Text + " WHERE office= " + "'" + "W/Sch" + "'" + "UPDATE tblvisoff set Opax= " + txt7.Text + " WHERE office= " + "'" + "SPA" + "'" + "UPDATE tblvisoff set vPax= " + v1.Text + " WHERE Visitors= " + "'" + "Visitor" + "'", Conn)
            'dcSearch = New SqlCommand("UPDATE tblvisoff set Opax= " + txt3.Text + " WHERE office= " + "'" + "D/Sch" + "'", Conn)
            MsgBox("Record Has been updated")
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        'Dim dcIns As New SqlCommand()
        Dim dcInsertNewAcc As New SqlCommand

        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        Dim fltString As String


        dcInsertNewAcc = New SqlCommand("todayroom_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@selDate", SqlDbType.Date).Value = dtdate.DateTime.Date


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()

        Conn.Close()


    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmbroomno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbroomno.SelectedIndexChanged
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from tblcom WHERE rno=" + cmbroomno.Text, Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            'Dim DscountTest As Integer


            txtname.Text = dsMain.Tables(0).Rows(0)(1).ToString()
            cmbbil.Text = dsMain.Tables(0).Rows(0)(2).ToString()
            txtpax.Text = dsMain.Tables(0).Rows(0)(3).ToString()
            txtdep.Text = dsMain.Tables(0).Rows(0)(4).ToString()
            'cmbroomno.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
            'DscountTest = DscountTest + 1





        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("UPDATE tblcom set name= " + "'" + txtname.Text + "'" + " WHERE rno= " + cmbroomno.Text + "UPDATE tblcom set bilin= " + "'" + cmbbil.Text + "'" + " WHERE rno= " + cmbroomno.Text + "UPDATE tblcom set pax= " + txtpax.Text + " WHERE rno= " + cmbroomno.Text + "UPDATE tblcom set depdate= " + "'" + txtdep.Text + "'" + " WHERE rno= " + cmbroomno.Text, Conn)
            'dcSearch = New SqlCommand("UPDATE tblvisoff set Opax= " + txt3.Text + " WHERE office= " + "'" + "D/Sch" + "'", Conn)
            MsgBox("Record Has been updated")
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
End Class