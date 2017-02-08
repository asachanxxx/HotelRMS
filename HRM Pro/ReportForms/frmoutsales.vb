Imports System.Data.SqlClient
Imports System.Data
Public Class frmoutsales

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim ConnStr2 As String = ConnString
        'Dim Conn2 As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc2 As New SqlCommand


        Dim bdayMonth As Integer = dtResDate.DateTime.Date.Month
        Dim bdayday As Integer = dtResDate.DateTime.Date.Day
        Dim tomonth As Integer = todate.DateTime.Date.Month
        Dim today As Integer = todate.DateTime.Date.Day



        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        Dim fltString As String

        Try

            Conn.Open()

            '  dcIns = New SqlCommand("select * from billmaster where BillMaster.Date between @bilfdate and @biltdate", Conn)
            ' dcIns.Parameters.Add("@bilfdate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date.ToString
            'dcIns.Parameters.Add("@biltdate", SqlDbType.DateTime).Value = todate.DateTime.Date.ToString

            dcInsertNewAcc = New SqlCommand("outsales_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date

            dcInsertNewAcc.CommandTimeout = 100

            dcInsertNewAcc.ExecuteNonQuery()

            UpdateAiMp()

            'fltString = " {BillMaster.Date} >='" & dtResDate.DateTime.Date & "' and {BillMaster.Date} <='" & todate.DateTime.Date & "' "
            'fltString = "Month({View_1Birthday_Report.DOB}) = " & bdayMonth & " And Day({View_1Birthday_Report.DOB}) =" & bdayday & " Between Month({View_1Birthday_Report.DOB}) = " & tomonth & " And Day({View_1Birthday_Report.DOB}) =" & today & """"
            'fltString = "{rpt_House_Count_Report_View.ResDate} >=#" & dtResDate.Text & "# and {rpt_House_Count_Report_View.ResDate}<=#" & dtResDate2.Text & "# "

           
            ' ReportName = "rptmasterbillsum.rpt"
           
            ' Conn2.Open()

            '  dcIns = New SqlCommand("select * from billmaster where BillMaster.Date between @bilfdate and @biltdate", Conn)
            ' dcIns.Parameters.Add("@bilfdate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date.ToString
            'dcIns.Parameters.Add("@biltdate", SqlDbType.DateTime).Value = todate.DateTime.Date.ToString

            dcInsertNewAcc2 = New SqlCommand("outsalescancel_SP", Conn)
            dcInsertNewAcc2.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc2.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcInsertNewAcc2.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date

            dcInsertNewAcc2.ExecuteNonQuery()

            Conn.Close()
            If opt1.Checked = True Then
                ReportName = "rptoutsales.rpt"
                rptTitle = "Outlet Sales  Report"
                ''  fltString = ""
                frmReportViewer.rptPath = ReportName
                frmReportViewer.rptTitle = rptTitle
                ''frmReportViewer.selectionForumla = fltString
                frmReportViewer.reporttype = 1

                'frmReportViewer.paraRepName = ""
                ' frmReportViewer.paraRepVale = ""

                '  frmReportViewer.paraRepName = "fromDate"
                ' frmReportViewer.paraRepVale = dtResDate.Text.ToString

                ' frmReportViewer.paraRepName2 = "toDate"
                ' frmReportViewer.paraRepVale2 = todate.Text.ToString

                frmReportViewer.Show()
            Else
                ReportName = "rptoutsalescancel.rpt"
                rptTitle = "Outlet Sales  Bill canceled Report"
                ''  fltString = ""
                frmReportViewer.rptPath = ReportName
                frmReportViewer.rptTitle = rptTitle
                ''frmReportViewer.selectionForumla = fltString
                frmReportViewer.reporttype = 1

                'frmReportViewer.paraRepName = ""
                ' frmReportViewer.paraRepVale = ""

                ' frmReportViewer.paraRepName = "fromDate"
                ' frmReportViewer.paraRepVale = dtResDate.Text.ToString

                ' frmReportViewer.paraRepName2 = "toDate"
                ' frmReportViewer.paraRepVale2 = todate.Text.ToString

                frmReportViewer.Show()
            End If


            ' Conn2.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            '  Conn.Dispose()
            '  dcIns.Dispose()


        End Try
    End Sub
    Private Sub UpdateAiMp()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

   

        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from  dbo.tbloutsales  where resno='Direct'  and dirresno like 'RES%'", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0


                    Dim Resno As String = dsMain.Tables(0).Rows(DScount)(13).ToString
                    Dim Bill As String = dsMain.Tables(0).Rows(DScount)(3).ToString

                    Dim getRoomDS As New DataSet
                    getRoomDS = DSGetMPfrmRES(Resno)



                    'If getRoomDS.Tables(0) Is DBNull.Value Or getRoomDS.Tables(0) Is Nothing Then

                    If getRoomDS Is Nothing Then
                        Dim erroe As Integer = 1
                    Else


                        If getRoomDS.Tables(0).Rows.Count > 0 Then

                            Dim MP As String = getRoomDS.Tables(0).Rows(0)(0).ToString

                            If MP = "AI" Then

                                UpdateDRMP(Resno, Bill, MP)

                            End If




                        End If

                    End If

                    DScount = DScount - 1



                End While






            Else
                Exit Sub

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try



    End Sub
    Private Sub UpdateDRMP(ByVal PassResno As String, ByVal PassBillNo As String, ByVal PassMP As String)

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand


            Dim getPassResno As String = PassResno
            Dim getPassBillNo As String = PassBillNo
            Dim getPassMP As String = PassMP

            dcInsertNewAcc = New SqlCommand("UpdatedrMP_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = getPassResno
            dcInsertNewAcc.Parameters.Add("@Bill", SqlDbType.VarChar).Value = getPassBillNo
            dcInsertNewAcc.Parameters.Add("@Mp", SqlDbType.VarChar).Value = getPassMP



            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Function DSGetMPfrmRES(ByVal Passresno As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim getPassresno As String = Passresno

            dcSearch = New SqlCommand("select Mealplan from [Reservation.master] where Resno=@Reservationno", Conn)
            dcSearch.Parameters.Add("@Reservationno", SqlDbType.VarChar).Value = getPassresno
            



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count

            'If getRoomDS.Tables(0) Is DBNull.Value Or getRoomDS.Tables(0) Is Nothing Or getRoomDS.Tables(0).Rows.Count = 0 Then
            '    Exit Function


            If count = 0 Or count < 0 Then
                DSGetMPfrmRES = Nothing

            Else
                DSGetMPfrmRES = dsMain
            End If



            'If count > 0 Then
            '    DSGetAssignRoomnos = dsMain
            'End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function

    Private Sub frmoutsales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtResDate.Text = Date.Today
        todate.Text = Date.Today
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles opt1.CheckedChanged

    End Sub
End Class