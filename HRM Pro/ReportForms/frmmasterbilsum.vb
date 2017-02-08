Imports System.Data.SqlClient
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit

Public Class frmmasterbilsum

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


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

            dcInsertNewAcc = New SqlCommand("mbilsum_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date
            
            dcInsertNewAcc.ExecuteNonQuery()

            'fltString = " {BillMaster.Date} >='" & dtResDate.DateTime.Date & "' and {BillMaster.Date} <='" & todate.DateTime.Date & "' "
            'fltString = "Month({View_1Birthday_Report.DOB}) = " & bdayMonth & " And Day({View_1Birthday_Report.DOB}) =" & bdayday & " Between Month({View_1Birthday_Report.DOB}) = " & tomonth & " And Day({View_1Birthday_Report.DOB}) =" & today & """"
            'fltString = "{rpt_House_Count_Report_View.ResDate} >=#" & dtResDate.Text & "# and {rpt_House_Count_Report_View.ResDate}<=#" & dtResDate2.Text & "# "

            Conn.Close()



            UpdateCreditnotes()


            UpdateTaxSchSums()

            ' ReportName = "rptmasterbillsum.rpt"
            ReportName = "rptmbilsum.rpt"
            rptTitle = "Master Bill Summary Report"
            ''  fltString = ""
            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            ''frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1


            'frmReportViewer.paraRepName = ""
            ' frmReportViewer.paraRepVale = ""

            frmReportViewer.paraRepName = "fromDate"
            frmReportViewer.paraRepVale = dtResDate.Text.ToString

            frmReportViewer.paraRepName2 = "toDate"
            frmReportViewer.paraRepVale2 = todate.Text.ToString

            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            '  Conn.Dispose()
            '  dcIns.Dispose()


        End Try
    End Sub

    Private Sub frmmasterbilsum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtResDate.Text = Date.Today
        todate.Text = Date.Today
    End Sub

    Private Sub btnxle_Click(sender As Object, e As EventArgs) Handles btnxle.Click
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        'nd dataset
        Dim Conn2 As New SqlConnection(ConnString)
        Dim daMain2 As New SqlDataAdapter
        Dim dsMain2 As New DataSet
        Dim dcSearch2 As New SqlCommand
        CheckOutPutFolder()

        Try
            Conn.Open()
            dcSearch = New SqlCommand("mbilsumxle_SP", Conn)
            dcSearch.CommandType = CommandType.StoredProcedure
            dcSearch.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcSearch.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date

            dcSearch.ExecuteNonQuery()
            Conn.Close()
            Conn.Open()
            'Make Connection ' Ammar
            ' Dim cnn As DataAccess = New DataAccess(Conn)
            ' Variable ' Ammar
            Dim i, j As Integer
            'Excel WorkBook object ' Ammar
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            ' Sheet Name or Number ' Ammar
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            ' Sql QUery ' Ammar
            '  xlWorkBook.Sheets.Select("A1:A2")
            'dcSearch = New SqlCommand("select [BillGeneratedDate],[MasterBillNo],[RoomNo],[Department],' ',' ',' ',' ',' ',' ',' ',' ',' ',[discount],[discountAmount],[tax],[serviceCharge],[Total] ,[fdate],[tdate] from tbloutletwisesale where ([BillGeneratedDate] between @fdate and @tdate) and  masterbillgenerated=1 order by [BillGeneratedDate],[MasterBillNo],RoomNo ", Conn)
            'dcSearch = New SqlCommand("select [date],[mbilno],[rno],[dep],' ',' ',' ',' ',' ',' ',' ',' ',' ',[tot],[tax],[scharge],[dis],[gtot],[fdate],[tdate] from tblmbilsum where ([date] between '2013-06-01' and '2013-06-30')  order by [Date],[mbilno],rno", Conn)
            ' last working ///dcSearch = New SqlCommand("select [date],[mbilno],[rno],[dep],0,0,0,0,0,0,0,0,0,sum([tot]),sum([tax]),sum([scharge]),sum([dis]),sum([gtot]),[fdate],[tdate] from tblmbilsum where ([date] between '2013-06-01' and '2013-06-30') group by date,mbilno ,rno ,dep,[tot],[tax],[scharge],[dis],[gtot],[fdate],[tdate]  order by [Date],[mbilno],rno", Conn)
            dcSearch = New SqlCommand("SELECT date, mbilno, rno,dep,  mainbar, SUM(cofe) AS cofe, SUM(spa) AS Spa, SUM(res) AS res, SUM(min) AS min, SUM(staff) AS staff, SUM(bl) AS bl, SUM(misrab) AS misrab,SUM(trans) AS trans, SUM(tot) AS tot, SUM(tax) AS tax, SUM(scharge) AS scharge, SUM(dis) AS dis, SUM(gtot) AS gtot FROM  dbo.tblmbilsumxle  where (date between @fdate and @tdate) GROUP BY date, mbilno, rno, dep, mainbar ORDER BY [date],[mbilno],rno", Conn)
            dcSearch.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcSearch.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date
            ' Dim dcIns As String = "SELECT * FROM tblmbilsum "
            ' SqlAdapter
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            Conn.Close()
            '/// con2 opend
            Conn2.Open()
            'dcSearch2 = New SqlCommand("SELECT date, mbilno, rno,dep,  mainbar, SUM(cofe) AS cofe, SUM(spa) AS Spa, SUM(res) AS res, SUM(min) AS min, SUM(staff) AS staff, SUM(bl) AS bl, SUM(misrab) AS misrab,SUM(trans) AS trans, SUM(tot) AS tot, SUM(tax) AS tax, SUM(scharge) AS scharge, SUM(dis) AS dis, SUM(gtot) AS gtot FROM  dbo.tblmbilsumxle  where (date between @fdate and @tdate) GROUP BY date, mbilno, rno, dep, mainbar ORDER BY [date],[mbilno],rno", Conn)
            dcSearch2 = New SqlCommand("SELECT date, mbilno, rno, mainbar, SUM(cofe) AS cofe, SUM(spa) AS Spa, SUM(res) AS res, SUM(min) AS min, SUM(staff) AS staff, SUM(bl) AS bl, SUM(misrab) AS misrab,SUM(trans) AS trans, SUM(tot) AS tot, SUM(tax) AS tax, SUM(scharge) AS scharge, SUM(dis) AS dis, SUM(gtot) AS gtot FROM  dbo.tblmbilsumxle GROUP BY date, mbilno, rno,  mainbar ORDER BY [date],[mbilno],rno", Conn)

            dcSearch2.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcSearch2.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date
            ' Dim dcIns As String = "SELECT * FROM tblmbilsum "
            ' SqlAdapter
            daMain2 = New SqlDataAdapter()
            daMain2.SelectCommand = dcSearch2
            daMain2.Fill(dsMain2)
            Conn2.Close()

            'con2 closed
            xlWorkSheet.Cells(3, 1) = "Date"
            xlWorkSheet.Cells(3, 2) = "Master Bill No"
            xlWorkSheet.Cells(3, 3) = "Room No"
            xlWorkSheet.Cells(3, 4) = "Department"
            xlWorkSheet.Cells(3, 5) = "Main Bar"
            xlWorkSheet.Cells(3, 6) = "Coffee Shop"
            xlWorkSheet.Cells(3, 7) = "GardenSpa"
            xlWorkSheet.Cells(3, 8) = "Restaurant Bar"
            xlWorkSheet.Cells(3, 9) = "Mini Bar"
            xlWorkSheet.Cells(3, 10) = "Staff Kitchen"
            xlWorkSheet.Cells(3, 11) = "B/L"
            xlWorkSheet.Cells(3, 12) = "mishrapshop"
            xlWorkSheet.Cells(3, 13) = "Transfer"
            xlWorkSheet.Cells(3, 14) = "Total"
            xlWorkSheet.Cells(3, 15) = "Tax"
            xlWorkSheet.Cells(3, 16) = "Service Charge"
            xlWorkSheet.Cells(3, 17) = "Discount"
            xlWorkSheet.Cells(3, 18) = "Grand Total"



            '//// 2nd loop
            '  For i = 0 To dsMain2.Tables(0).Rows.Count - 1
            'Column
            'For j = 0 To dsMain2.Tables(0).Columns.Count - 1
            'xlWorkSheet.Cells(i + 4, j + 1) = dsMain2.Tables(0).Rows(i).Item(j)
            ' Next
            '  Next

            '////

            For i = 0 To dsMain.Tables(0).Rows.Count - 1
                'Column
                For j = 0 To dsMain.Tables(0).Columns.Count - 1
                    ' this i change to header line cells >>>
                    If dsMain.Tables(0).Rows(i).Item(3) = "Main Bar" Then
                        xlWorkSheet.Cells(i + 4, 5) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Coffee Shop" Then
                        xlWorkSheet.Cells(i + 4, 6) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "GardenSpa" Then
                        xlWorkSheet.Cells(i + 4, 7) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Restaurant Bar" Then
                        xlWorkSheet.Cells(i + 4, 8) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Mini Bar" Then
                        xlWorkSheet.Cells(i + 4, 9) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Staff Kitchen" Then
                        xlWorkSheet.Cells(i + 4, 10) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "B/L" Then
                        xlWorkSheet.Cells(i + 4, 11) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "mishrapshop" Then
                        xlWorkSheet.Cells(i + 4, 12) = dsMain.Tables(0).Rows(i).Item(13)
                    ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Transfer" Then
                        xlWorkSheet.Cells(i + 4, 13) = dsMain.Tables(0).Rows(i).Item(13)
                    End If
                    xlWorkSheet.Cells(i + 4, j + 1) = dsMain.Tables(0).Rows(i).Item(j)
                Next
            Next

            'HardCode in Excel sheet
            ' this i change to footer line cells  >>>
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 10)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 10)).Merge()
            xlWorkSheet.Cells(1, 1) = "ERIYADU ISLAND RESORT"
            xlWorkSheet.Cells(2, 1) = "MASTER BILL COLLECTION FROM " & CDate(dtResDate.DateTime.Date) & Chr(13) & " TO " & CDate(todate.DateTime.Date)
            xlWorkSheet.Range(xlWorkSheet.Cells(i + 5, 1), xlWorkSheet.Cells(i + 5, 18)).Font.Bold = True


            xlWorkSheet.Cells(i + 5, 2) = "Total"
            xlWorkSheet.Cells.Item(i + 5, 5) = "=SUM(e4:e" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 6) = "=SUM(f4:f" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 7) = "=SUM(g4:g" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 8) = "=SUM(h4:h" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 9) = "=SUM(i4:i" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 10) = "=SUM(j4:j" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 11) = "=SUM(k4:k" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 12) = "=SUM(l4:l" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 13) = "=SUM(m4:m" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 14) = "=SUM(n4:n" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 15) = "=SUM(o4:o" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 16) = "=SUM(p4:p" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 17) = "=SUM(q4:q" & i + 3 & ")"
            xlWorkSheet.Cells.Item(i + 5, 18) = "=SUM(r4:r" & i + 3 & ")"
            xlWorkBook.ActiveSheet.Columns.AutoFit()
            If System.IO.File.Exists(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx")) = False Then
                xlWorkSheet.SaveAs(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))
                xlApp.Workbooks.Open(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))
                xlWorkBook.Close()
                xlApp.Quit()
                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                'Msg Box of Excel Sheet Path
                MsgBox("The " & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx" & " saved in " & vbCrLf & Application.StartupPath & "\MasterBillReports\")
                'xlApp.Workbooks.Open(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))

            Else
                Dim respond As String = MsgBox("The " & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx" & " Found in " & vbCrLf & Application.StartupPath & "\MasterBillReports\" & vbCrLf & "Do You want Save a copy? ", vbYesNo, vbInformation)
                If respond = vbYes Then
                    xlWorkSheet.SaveAs(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & "copy.xlsx"))
                    xlWorkBook.Close()
                    xlApp.Quit()
                    releaseObject(xlApp)
                    releaseObject(xlWorkBook)
                    releaseObject(xlWorkSheet)
                Else
                    Exit Sub

                End If
            End If

        Catch ex As Exception

        End Try

    End Sub


    ' Function of Realease Object in Excel Sheet
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub CheckOutPutFolder()
        Try
            If New System.IO.DirectoryInfo(Path.Combine(Application.StartupPath, "MasterBillReports")).Exists = False Then
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "MasterBillReports"))
            End If
        Catch ex As Exception
        End Try
    End Sub
    
    Private Sub UpdateCreditnotes()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from dbo.[tblmbilsum]", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0


                    Dim Mbillno As String = dsMain.Tables(0).Rows(DScount)(1).ToString


                    Dim getRoomDS As New DataSet
                    getRoomDS = DSGetMBillCredit(Mbillno)

                    'Dim getBillwiseSum As New DataSet
                    'getBillwiseSum = DSGetMBillSums(Mbillno)







                    'If getRoomDS.Tables(0) Is DBNull.Value Or getRoomDS.Tables(0) Is Nothing Then

                    If getRoomDS Is Nothing Then

                        UpdateCreditDetails(Mbillno, 0, 0, 0)

                    Else



                        Dim cntot As Integer = Convert.ToInt16(getRoomDS.Tables(0).Rows(0)(7).ToString)
                        Dim cntax As Integer = Convert.ToInt16(getRoomDS.Tables(0).Rows(0)(16).ToString)
                        Dim cnschar As Integer = Convert.ToInt16(getRoomDS.Tables(0).Rows(0)(17).ToString)


                        UpdateCreditDetails(Mbillno, cntot, cntax, cnschar)

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
    Private Sub UpdateTaxSchSums()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Distinct mbilno from dbo.[tblmbilsum]", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then


                Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

                While DScount >= 0


                    Dim Mbillno As String = dsMain.Tables(0).Rows(DScount)(0).ToString



                    Dim getBillwiseSum As New DataSet
                    getBillwiseSum = DSGetMBillSums(Mbillno)





                    'If getRoomDS.Tables(0) Is DBNull.Value Or getRoomDS.Tables(0) Is Nothing Then

                    


                    Dim tottax As Integer = Convert.ToInt16(getBillwiseSum.Tables(0).Rows(0)(0).ToString)
                    Dim totscharge As Integer = Convert.ToInt16(getBillwiseSum.Tables(0).Rows(0)(1).ToString)
                    Dim totdis As Integer = Convert.ToInt16(getBillwiseSum.Tables(0).Rows(0)(2).ToString)


                    UpdateDepWiseSum(Mbillno, tottax, totscharge, totdis)



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


    Function DSGetMBillCredit(ByVal PassMbill As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim getPassMbill As String = PassMbill
           



            dcSearch = New SqlCommand("select * from dbo.[Invoice.CrDb.Master] where TaxInvNo=@Mbill", Conn)
            dcSearch.Parameters.Add("@Mbill", SqlDbType.VarChar).Value = getPassMbill
      


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count

            

            If count = 0 Or count < 0 Then
                DSGetMBillCredit = Nothing

            Else
                DSGetMBillCredit = dsMain
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function
    Function DSGetMBillSums(ByVal PassMbill As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim getPassMbill As String = PassMbill




            dcSearch = New SqlCommand("select sum(tax)as tax ,sum(scharge)as scharge,sum(dis)as dis from tblmbilsum where mbilno=@Mbill", Conn)
            dcSearch.Parameters.Add("@Mbill", SqlDbType.VarChar).Value = getPassMbill



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count



            If count = 0 Or count < 0 Then
                DSGetMBillSums = Nothing

            Else
                DSGetMBillSums = dsMain
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function

    Private Sub UpdateCreditDetails(ByVal PassMbillno As String, ByVal PassCrTot As Integer, ByVal PassCrTax As Integer, ByVal PassScahrge As Integer)

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getPassMbillno As String = PassMbillno
            Dim gePassCrTot As Integer = PassCrTot
            Dim getPassCrTax As Integer = PassCrTax
            Dim getPassScahrge As Integer = PassScahrge
           

            dcInsertNewAcc = New SqlCommand("UpdateMBillCrDetails_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Mbill", SqlDbType.VarChar).Value = getPassMbillno
            dcInsertNewAcc.Parameters.Add("@cntot", SqlDbType.Int).Value = gePassCrTot
            dcInsertNewAcc.Parameters.Add("@cntax", SqlDbType.Int).Value = getPassCrTax
            dcInsertNewAcc.Parameters.Add("@cnscharge", SqlDbType.Int).Value = getPassScahrge



            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub




    Private Sub UpdateDepWiseSum(ByVal PassMbillno As String, ByVal PassCrTax As Integer, ByVal PassScahrge As Integer, ByVal PassDis As Integer)

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand

            Dim getPassMbillno As String = PassMbillno

            Dim getPassCrTax As Integer = PassCrTax
            Dim getPassScahrge As Integer = PassScahrge
            Dim gePassDis As Integer = PassDis


            dcInsertNewAcc = New SqlCommand("UpdateMBillSumTaxSch_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Mbill", SqlDbType.VarChar).Value = getPassMbillno
            dcInsertNewAcc.Parameters.Add("@cntax", SqlDbType.Int).Value = getPassCrTax
            dcInsertNewAcc.Parameters.Add("@cnscharge", SqlDbType.Int).Value = getPassScahrge
            dcInsertNewAcc.Parameters.Add("@cndis", SqlDbType.Int).Value = gePassDis


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub

End Class