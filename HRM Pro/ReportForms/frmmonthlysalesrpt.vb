Imports System.Data.SqlClient

Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit


Public Class frmmonthlysalesrpt

    Private Sub frmmonthlysalesrpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtResDate.Text = Date.Today
        dtResDate2.Text = Date.Today
    End Sub
    Private Sub resnoload()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()
            dcSearch = New SqlCommand("select * from [Reservation.Master] where (MealPlan ='AI') and ArrDate>=@fdate  and DepDate <=@tdate", Conn)
            dcSearch.Parameters.Add("@fdate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
            dcSearch.Parameters.Add("@tdate", SqlDbType.DateTime).Value = dtResDate2.DateTime.Date
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            cmbbno.Refresh()
            cmbbno.Items.Clear()
            cmbbno.Invalidate()
            'cmbobilno.Refresh()
            'i = 0
            If Dscount > 0 Then
                While (DscountTest < Dscount)

                    cmbbno.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbbno.SelectedIndex = 0


            Else
                cmbbno.Refresh()
                cmbbno.Items.Clear()
                cmbbno.Invalidate()
                MsgBox("No Records found")
                cmbbno.Text = ""
            End If


           
            Conn.Close()

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub roomnoload()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()
            dcSearch = New SqlCommand("select RoomNo from GuestRegistration where ReservationNo  =@resno and IsBillingGuest =1", Conn)
            dcSearch.Parameters.Add("@resno", SqlDbType.VarChar).Value = cmbbno.Text.Trim
            'dcSearch.Parameters.Add("@tdate", SqlDbType.DateTime).Value = dtResDate2.DateTime.Date

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            cmbresno.Refresh()
            cmbresno.Items.Clear()
            cmbresno.Invalidate()
            'cmbobilno.Refresh()
            'i = 0
            If Dscount > 0 Then
                While (DscountTest < Dscount)

                    cmbresno.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                    DscountTest = DscountTest + 1

                End While

                cmbresno.SelectedIndex = 0


            Else
                cmbresno.Refresh()
                cmbresno.Items.Clear()
                cmbresno.Invalidate()
                MsgBox("No Records found")
                cmbresno.Text = ""
            End If



            Conn.Close()

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub cmbobilno_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtResDate2_EditValueChanged(sender As Object, e As EventArgs) Handles dtResDate2.EditValueChanged
        resnoload()
    End Sub

    Private Sub cmbbno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbno.SelectedIndexChanged
        roomnoload()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        salesprint()
    End Sub
    Private Sub salesprint()
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim ReportName As String = ""
        Dim rptTitle As String = ""

        Dim fltString As String
        ' Try
        Conn.Open()
        'Dim Passtopcode As String = topcode

        dcInsertNewAcc = New SqlCommand("monthlysalesrpt_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@fDate", SqlDbType.DateTime).Value = dtResDate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@tDate", SqlDbType.DateTime).Value = dtResDate2.DateTime.Date

        ' dcInsertNewAcc.Parameters.Add("@billno", SqlDbType.VarChar).Value = cmbbilno.Text.ToString
        dcInsertNewAcc.Parameters.Add("@rno", SqlDbType.VarChar).Value = cmbresno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@resno", SqlDbType.VarChar).Value = cmbbno.Text.Trim

        'MsgBox(dtResDate.DateTime.Date + cmbobilno.Text.Trim)

        dcInsertNewAcc.CommandTimeout = 100

        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
        fltString = ""
        ' fltString = "{rpt_Expected_Arrival_Departures_View.ResDate} >=#" & DtFrm.Text & "# and {rpt_Expected_Arrival_Departures_View.ResDate} <=#" & DtTo.Text & "# "

        'ReportName = "New_Occupancy_Report.rpt"
        ReportName = "rptmonthlysalesrpt.rpt"

        ' ReportName = "New_Occupancy_Report _Graphical.rpt"


        rptTitle = "Monthly Sales Report"

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
            If New System.IO.DirectoryInfo(Path.Combine(Application.StartupPath, "SalesReports")).Exists = False Then
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "SalesReports"))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnexl_Click(sender As Object, e As EventArgs) Handles btnexl.Click
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        'nd dataset
        Dim Conn2 As New SqlConnection(ConnString)
        Dim daMain2 As New SqlDataAdapter
        Dim dsMain2 As New DataSet
        Dim dcSearch2 As New SqlCommand

        '3rd data set
        Dim Conn3 As New SqlConnection(ConnString)
        Dim daMain3 As New SqlDataAdapter
        Dim dsMain3 As New DataSet
        Dim dcSearch3 As New SqlCommand

        '4th
        Dim Conn4 As New SqlConnection(ConnString)
        Dim daMain4 As New SqlDataAdapter
        Dim dsMain4 As New DataSet
        Dim dcSearch4 As New SqlCommand
        CheckOutPutFolder()

        Try
            Conn.Open()
            dcSearch = New SqlCommand("monthlysalesrpt_SP", Conn)
            dcSearch.CommandType = CommandType.StoredProcedure
            dcSearch.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcSearch.Parameters.Add("@tdate", SqlDbType.Date).Value = dtResDate2.DateTime.Date
            dcSearch.Parameters.Add("@rno", SqlDbType.VarChar).Value = cmbresno.Text.Trim
            dcSearch.Parameters.Add("@resno", SqlDbType.VarChar).Value = cmbbno.Text.Trim

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
            '///dcSearch = New SqlCommand("SELECT date, mbilno, rno,dep,  mainbar, SUM(cofe) AS cofe, SUM(spa) AS Spa, SUM(res) AS res, SUM(min) AS min, SUM(staff) AS staff, SUM(bl) AS bl, SUM(misrab) AS misrab,SUM(trans) AS trans, SUM(tot) AS tot, SUM(tax) AS tax, SUM(scharge) AS scharge, SUM(dis) AS dis, SUM(gtot) AS gtot FROM  dbo.tblmbilsumxle  where (date between @fdate and @tdate) GROUP BY date, mbilno, rno, dep, mainbar ORDER BY [date],[mbilno],rno", Conn)
            '////dcSearch.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            '///dcSearch.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date
            ' Dim dcIns As String = "SELECT * FROM tblmbilsum "
            ' SqlAdapter
            '///daMain = New SqlDataAdapter()
            '///daMain.SelectCommand = dcSearch
            '///daMain.Fill(dsMain)
            '//Conn.Close()
            '/// con2 opend
            Conn2.Open()
            'dcSearch2 = New SqlCommand("SELECT date, mbilno, rno,dep,  mainbar, SUM(cofe) AS cofe, SUM(spa) AS Spa, SUM(res) AS res, SUM(min) AS min, SUM(staff) AS staff, SUM(bl) AS bl, SUM(misrab) AS misrab,SUM(trans) AS trans, SUM(tot) AS tot, SUM(tax) AS tax, SUM(scharge) AS scharge, SUM(dis) AS dis, SUM(gtot) AS gtot FROM  dbo.tblmbilsumxle  where (date between @fdate and @tdate) GROUP BY date, mbilno, rno, dep, mainbar ORDER BY [date],[mbilno],rno", Conn)
            dcSearch2 = New SqlCommand("select dec,bildate,sum(qty )AS QTY,cost ,saleprice  from tblmonthlysalesrpt group by dec,bildate ,qty ,cost ,saleprice ", Conn)

            '//dcSearch2.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            '//dcSearch2.Parameters.Add("@tdate", SqlDbType.Date).Value = dtResDate2.DateTime.Date
            ' Dim dcIns As String = "SELECT * FROM tblmbilsum "
            ' SqlAdapter
            daMain2 = New SqlDataAdapter()
            daMain2.SelectCommand = dcSearch2
            daMain2.Fill(dsMain2)
            Conn2.Close()
            Conn3.Open()
            'dcSearch2 = New SqlCommand("SELECT date, mbilno, rno,dep,  mainbar, SUM(cofe) AS cofe, SUM(spa) AS Spa, SUM(res) AS res, SUM(min) AS min, SUM(staff) AS staff, SUM(bl) AS bl, SUM(misrab) AS misrab,SUM(trans) AS trans, SUM(tot) AS tot, SUM(tax) AS tax, SUM(scharge) AS scharge, SUM(dis) AS dis, SUM(gtot) AS gtot FROM  dbo.tblmbilsumxle  where (date between @fdate and @tdate) GROUP BY date, mbilno, rno, dep, mainbar ORDER BY [date],[mbilno],rno", Conn)
            dcSearch3 = New SqlCommand(" select bildate  from tblmonthlysalesrpt group by bildate", Conn)

            '//dcSearch2.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            '//dcSearch2.Parameters.Add("@tdate", SqlDbType.Date).Value = dtResDate2.DateTime.Date
            ' Dim dcIns As String = "SELECT * FROM tblmbilsum "
            ' SqlAdapter
            daMain3 = New SqlDataAdapter()
            daMain3.SelectCommand = dcSearch3
            daMain3.Fill(dsMain3)
            Conn3.Close()

            Conn4.Open()
            dcSearch4 = New SqlCommand("  select dec from tblmonthlysalesrpt group by dec", Conn)
            daMain4 = New SqlDataAdapter()
            daMain4.SelectCommand = dcSearch4
            daMain4.Fill(dsMain4)
            Conn4.Close()
            xlWorkSheet.Cells(5, 1) = "Sprits and Beer"

            'this look for item name
            '///// For i = 0 To dsMain4.Tables(0).Rows.Count - 1
            'Column
            '////For j = 0 To dsMain4.Tables(0).Columns.Count - 1
            '  If dsMain2.Tables(0).Rows(i).Item(1) Then
            '////xlWorkSheet.Cells(5, 2 + i) = dsMain4.Tables(0).Rows(i).Item(0)
            '////  Next
            '//// xlWorkSheet.Cells(6 + i, 1) = dsMain2.Tables(0).Rows(i).Item(0)
            '//// Next
            'this loop for date
            For i = 0 To dsMain3.Tables(0).Rows.Count - 1
                'Column
                For j = 0 To dsMain3.Tables(0).Columns.Count - 1
                    '  If dsMain2.Tables(0).Rows(i).Item(1) Then
                    xlWorkSheet.Cells(5, 2 + i) = dsMain3.Tables(0).Rows(i).Item(0)
                Next
                'xlWorkSheet.Cells(6 + i, 1) = dsMain2.Tables(0).Rows(i).Item(0)
            Next

            xlWorkSheet.Cells(5, 2 + i) = "Total"
            xlWorkSheet.Cells(5, 3 + i) = "Sell Price"
            xlWorkSheet.Cells(5, 4 + i) = "Cst Price"
            xlWorkSheet.Cells(5, 5 + i) = "Space Total"
            xlWorkSheet.Cells(5, 6 + i) = " CP Total"
            xlWorkSheet.Cells(5, 7 + i) = " Profit"

            ' this loop for item name
            For i = 0 To dsMain4.Tables(0).Rows.Count - 1
                'column
                For j = 0 To dsMain4.Tables(0).Columns.Count - 1

                Next
                ' xlworksheet.cells(6 + i, 1) = dsmain2.tables(0).rows(i).item(0)
                xlWorkSheet.cells(6 + i, 1) = dsMain4.Tables(0).Rows(i).Item(0)
            Next

            ''this is for item name from dataset2

            'For i = 0 To dsMain2.Tables(0).Rows.Count - 1
            '    'Column
            '    For j = 0 To dsMain2.Tables(0).Columns.Count - 1
            '        '  If dsMain2.Tables(0).Rows(i).Item(1) Then
            '        'xlWorkSheet.Cells(5, 2 + i) = dsMain2.Tables(0).Rows(i).Item(0)
            '    Next
            '    xlWorkSheet.Cells(6 + i, 1) = dsMain2.Tables(0).Rows(i).Item(0)
            'Next

            For k = 0 To dsMain4.Tables(0).Rows.Count - 1
                For i = 0 To dsMain2.Tables(0).Rows.Count - 1
                    ' If (dsMain2.Tables(0).Rows(k).Item(0) = DirectCast(xlWorkSheet.Cells(6 + i, 1), Excel.Range).Value) Then
                    If (dsMain4.Tables(0).Rows(k).Item(0)) = (dsMain2.Tables(0).Rows(i).Item(0)) Then
                        For d = 0 To dsMain3.Tables(0).Rows.Count - 1
                            ' If DirectCast(xlWorkSheet.Cells(5, 2 + d), Excel.Range).Value)=(dsMain3.Tables(0).Rows(d).Item(1) then
                            If (dsMain2.Tables(0).Rows(i).Item(1) = DirectCast(xlWorkSheet.Cells(5, 2 + d), Excel.Range).Value) Then
                                xlWorkSheet.Cells(6 + k, 2 + d) = dsMain2.Tables(0).Rows(i).Item(2)
                                xlWorkSheet.Cells(6 + k, 5 + d) = dsMain2.Tables(0).Rows(i).Item(4)
                                xlWorkSheet.Cells(6 + k, 6 + d) = dsMain2.Tables(0).Rows(i).Item(3)
                                'For s = ((dsMain2.Tables(0).Rows.Count - 1) - 1) To dsMain2.Tables(0).Rows.Count - 1
                                'For s = ((dsMain2.Tables(0).Rows.Count) - (dsMain2.Tables(0).Rows.Count - 1)) + k To dsMain2.Tables(0).Rows.Count - 1
                                For s = i To dsMain2.Tables(0).Rows.Count - 1
                                    If (dsMain4.Tables(0).Rows(k).Item(0)) = (dsMain2.Tables(0).Rows(s).Item(0)) Then
                                        For h = (dsMain3.Tables(0).Rows.Count - 1) - d To dsMain3.Tables(0).Rows.Count - 1
                                            If (dsMain2.Tables(0).Rows(s).Item(1) = DirectCast(xlWorkSheet.Cells(5, 2 + h), Excel.Range).Value) Then
                                                xlWorkSheet.Cells(6 + k, 2 + h) = dsMain2.Tables(0).Rows(s).Item(2)
                                                xlWorkSheet.Cells(6 + k, 4 + h) = dsMain2.Tables(0).Rows(s).Item(4)
                                                xlWorkSheet.Cells(6 + k, 5 + h) = dsMain2.Tables(0).Rows(s).Item(3)

                                            End If
                                        Next
                                    End If
                                Next

                            End If

                        Next

                    End If

                Next

            Next

            'to get the total
            Dim a As Integer = dsMain3.Tables(0).Rows.Count
            Dim gtot As Integer = dsMain4.Tables(0).Rows.Count + 6
            Dim gto As Integer = dsMain4.Tables(0).Rows.Count
            For i = 0 To dsMain4.Tables(0).Rows.Count - 1
                'column
                'For j = 0 To dsMain4.Tables(0).Columns.Count - 1

                'Next
                ' xlworksheet.cells(6 + i, 1) = dsmain2.tables(0).rows(i).item(0)
                xlWorkSheet.Cells(6 + i, 1) = dsMain4.Tables(0).Rows(i).Item(0)
                ' xlWorkSheet.Cells.Item(i + 6, 2 + a) = "=SUM(b" & 6 + i & " :c" & i + 6 & ")"
                ' xlWorkSheet.Cells.Item(i + 6, 2 + a) = "=sum(R6C:R[-1]C)"
                xlWorkSheet.Cells.Item(i + 6, 2 + a) = "=sum(RC[-2]:RC[-1])"
                xlWorkSheet.Cells.Item(i + 6, 5 + a) = "=(RC[-3]*RC[-2])"
                xlWorkSheet.Cells.Item(i + 6, 6 + a) = "=(RC[-4]*RC[-2])"
                xlWorkSheet.Cells.Item(i + 6, 7 + a) = "=(RC[-2]-RC[-1])"
                'xlWorkSheet.Cells.Item(i + 6, 2 + a) =xlWorkSheet SUM(xlWorkSheet.Range(xlWorkSheet.Cells(6 + i, 2), xlWorkSheet.Cells(6 + i, 2)))

                ' xlWorkSheet.Cells.Item(i + 6, 2 + a) = "=SUM(Range(Cells(6+i,2),Cells(6+i,2)))"

                'xlWorkSheet.Cells.Item(gtot + 6, 2 + a) = "=sum(R[-" & gtot & " ]C:R[-1]C)"

            Next
            For k = 0 To dsMain3.Tables(0).Rows.Count
                xlWorkSheet.Cells.Item(gtot + 2, k + 2) = "=sum(R[-" & gto + 2 & "]C:R[-2]C)"
                ' xlWorkSheet.Cells.Item(gtot + 5, 2 + i) = "=sum(R[-10]C:R[-4]C)"
                'xlWorkSheet.Cells.Item(gtot + 6, 2 + a) = "=sum(R[4 ]C:R[1]C)"
            Next
            Dim gt As Integer = dsMain3.Tables(0).Rows.Count
            xlWorkSheet.Cells.Item(gtot + 2, gt + 1) = "=sum(R[-" & gto + 2 & "]C:R[-2]C)"
            xlWorkSheet.Cells.Item(gtot + 2, gt + 2) = "=sum(R[-" & gto + 2 & "]C:R[-2]C)"
            xlWorkSheet.Cells.Item(gtot + 2, gt + 3) = "=sum(R[-" & gto + 2 & "]C:R[-2]C)"
            xlWorkSheet.Cells.Item(gtot + 2, gt + 4) = "=sum(R[-" & gto + 2 & "]C:R[-2]C)"
            xlWorkSheet.Cells.Item(gtot + 2, gt + 5) = "=sum(R[-" & gto + 2 & "]C:R[-2]C)"
            xlWorkSheet.Cells.Item(gtot + 2, gt + 6) = "=sum(R[-" & gto + 2 & "]C:R[-2]C)"
            xlWorkSheet.Cells.Item(gtot + 2, gt + 7) = "=sum(R[-" & gto + 2 & "]C:R[-2]C)"
            xlWorkSheet.Range(xlWorkSheet.Cells(gtot + 2, gt), xlWorkSheet.Cells(gtot + 2, gt + 7)).Font.Bold = True
            'xlWorkSheet.Range(xlWorkSheet.Cells(5, 1), xlWorkSheet.Cells(5, 9)).Font.Bold = True
            'For i = 0 To dsMain3.Tables(0).Rows.Count - 1
            'Column
            '333  For j = 0 To dsMain2.Tables(0).Rows.Count - 1
            '///If dsMain2.Tables(0).Rows(i).Item(0) = xlWorkSheet.Range("A" & 6 + i).Value And dsMain2.Tables(0).Rows(i).Item(1) = xlWorkSheet.Range("B5").Value Then
            ' For d = 0 To dsMain4.Tables(0).Rows.Count - 1
            '333 If (dsMain2.Tables(0).Rows(j).Item(0) = DirectCast(xlWorkSheet.Cells(6 + j, 1), Excel.Range).Value) Then
            '333 For d = 0 To dsMain4.Tables(0).Rows.Count - 1
            '333 If (dsMain2.Tables(0).Rows(j).Item(1) = DirectCast(xlWorkSheet.Cells(5, 2 + d), Excel.Range).Value) Then

            '3333 xlWorkSheet.Cells(6 + j, 2 + d) = dsMain2.Tables(0).Rows(j).Item(2)
            '333 End If
            '333  Next

            '333  End If
            '333  Next

            'Next
            ''' Else
            '''xlWorkSheet.Cells(6 + i, 3) = dsMain2.Tables(0).Rows(i).Item(2)
            ''End If
            ''Else

            'DirectCast(ws.Cells(1, 1), Excel.Range)
            '' End If


            'Next
            'xlWorkSheet.Cells(6 + i, 1) = dsMain2.Tables(0).Rows(i).Item(0)
            'Next




            'con2 closed
            '///    xlWorkSheet.Cells(3, 1) = "Date"
            'xlWorkSheet.Cells(3, 2) = "Master Bill No"
            'xlWorkSheet.Cells(3, 3) = "Room No"
            'xlWorkSheet.Cells(3, 4) = "Department"
            'xlWorkSheet.Cells(3, 5) = "Main Bar"
            'xlWorkSheet.Cells(3, 6) = "Coffee Shop"
            'xlWorkSheet.Cells(3, 7) = "GardenSpa"
            'xlWorkSheet.Cells(3, 8) = "Restaurant Bar"
            'xlWorkSheet.Cells(3, 9) = "Mini Bar"
            'xlWorkSheet.Cells(3, 10) = "Staff Kitchen"
            'xlWorkSheet.Cells(3, 11) = "B/L"
            'xlWorkSheet.Cells(3, 12) = "mishrapshop"
            'xlWorkSheet.Cells(3, 13) = "Transfer"
            'xlWorkSheet.Cells(3, 14) = "Total"
            'xlWorkSheet.Cells(3, 15) = "Tax"
            'xlWorkSheet.Cells(3, 16) = "Service Charge"
            'xlWorkSheet.Cells(3, 17) = "Discount"
            'xlWorkSheet.Cells(3, 18) = "Grand Total"

            '////

            '//// 2nd loop
            '  For i = 0 To dsMain2.Tables(0).Rows.Count - 1
            'Column
            'For j = 0 To dsMain2.Tables(0).Columns.Count - 1
            'xlWorkSheet.Cells(i + 4, j + 1) = dsMain2.Tables(0).Rows(i).Item(j)
            ' Next
            '  Next

            '////

            'For i = 0 To dsMain.Tables(0).Rows.Count - 1
            '    'Column
            '    For j = 0 To dsMain.Tables(0).Columns.Count - 1
            '        ' this i change to header line cells >>>



            '        If dsMain.Tables(0).Rows(i).Item(3) = "Main Bar" Then
            '            xlWorkSheet.Cells(i + 4, 5) = dsMain.Tables(0).Rows(i).Item(13)
            '        ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Coffee Shop" Then
            '            xlWorkSheet.Cells(i + 4, 6) = dsMain.Tables(0).Rows(i).Item(13)
            '        ElseIf dsMain.Tables(0).Rows(i).Item(3) = "GardenSpa" Then
            '            xlWorkSheet.Cells(i + 4, 7) = dsMain.Tables(0).Rows(i).Item(13)
            '        ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Restaurant Bar" Then
            '            xlWorkSheet.Cells(i + 4, 8) = dsMain.Tables(0).Rows(i).Item(13)
            '        ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Mini Bar" Then
            '            xlWorkSheet.Cells(i + 4, 9) = dsMain.Tables(0).Rows(i).Item(13)
            '        ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Staff Kitchen" Then
            '            xlWorkSheet.Cells(i + 4, 10) = dsMain.Tables(0).Rows(i).Item(13)
            '        ElseIf dsMain.Tables(0).Rows(i).Item(3) = "B/L" Then
            '            xlWorkSheet.Cells(i + 4, 11) = dsMain.Tables(0).Rows(i).Item(13)
            '        ElseIf dsMain.Tables(0).Rows(i).Item(3) = "mishrapshop" Then
            '            xlWorkSheet.Cells(i + 4, 12) = dsMain.Tables(0).Rows(i).Item(13)
            '        ElseIf dsMain.Tables(0).Rows(i).Item(3) = "Transfer" Then
            '            xlWorkSheet.Cells(i + 4, 13) = dsMain.Tables(0).Rows(i).Item(13)
            '        End If
            '        xlWorkSheet.Cells(i + 4, j + 1) = dsMain.Tables(0).Rows(i).Item(j)
            '    Next
            'Next

            'HardCode in Excel sheet
            ' this i change to footer line cells  >>>
            xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(1, 10)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 10)).Merge()
            xlWorkSheet.Cells(1, 1) = "ERIYADU ISLAND RESORT"
            xlWorkSheet.Cells(2, 1) = "Month Of " & MonthName(Month(dtResDate2.DateTime.Date)) & " Sales Report FROM " & CDate(dtResDate.DateTime.Date) & Chr(13) & " TO " & CDate(dtResDate2.DateTime.Date)



            '///xlWorkSheet.Cells(i + 5, 2) = "Total"
            'xlWorkSheet.Cells.Item(i + 5, 5) = "=SUM(e4:e" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 6) = "=SUM(f4:f" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 7) = "=SUM(g4:g" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 8) = "=SUM(h4:h" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 9) = "=SUM(i4:i" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 10) = "=SUM(j4:j" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 11) = "=SUM(k4:k" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 12) = "=SUM(l4:l" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 13) = "=SUM(m4:m" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 14) = "=SUM(n4:n" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 15) = "=SUM(o4:o" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 16) = "=SUM(p4:p" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 17) = "=SUM(q4:q" & i + 3 & ")"
            'xlWorkSheet.Cells.Item(i + 5, 18) = "=SUM(r4:r" & i + 3 & ")"
            xlWorkBook.ActiveSheet.Columns.AutoFit()
            If System.IO.File.Exists(Path.Combine(Application.StartupPath & "\SalesReports\" & "SalesReports-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx")) = False Then
                xlWorkSheet.SaveAs(Path.Combine(Application.StartupPath & "\SalesReports\" & "SalesReports-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))
                xlApp.Workbooks.Open(Path.Combine(Application.StartupPath & "\SalesReports\" & "SalesReports-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))
                xlWorkBook.Close()
                xlApp.Quit()
                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                'Msg Box of Excel Sheet Path
                MsgBox("The " & "SalesReports-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx" & " saved in " & vbCrLf & Application.StartupPath & "\SalesReports\")
                'xlApp.Workbooks.Open(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))

            Else
                Dim respond As String = MsgBox("The " & "SalesReports-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx" & " Found in " & vbCrLf & Application.StartupPath & "\SalesReports\" & vbCrLf & "Do You want Save a copy? ", vbYesNo, vbInformation)
                If respond = vbYes Then
                    xlWorkSheet.SaveAs(Path.Combine(Application.StartupPath & "\SalesReports\" & "SalesReports-" & dtResDate.DateTime.Date.ToString("MMMM") & "copy.xlsx"))
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

   
    Private Sub txttest_Click(sender As Object, e As EventArgs) Handles txttest.Click

    End Sub
End Class