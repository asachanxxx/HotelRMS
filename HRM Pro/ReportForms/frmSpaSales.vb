Imports System.Data.SqlClient
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
Public Class frmSpaSales

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Dim Conn2 As New SqlConnection(ConnString)
        Dim daMain2 As New SqlDataAdapter
        Dim dsMain2 As New DataSet
        Dim dcSearch2 As New SqlCommand

        CheckOutPutFolder()

        'Make Connection ' Ammar
        ' Dim cnn As DataAccess = New DataAccess(Conn)
        ' Variable ' Ammar
        Dim i, j As Integer
        Try
            Conn.Open()

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
            dcSearch = New SqlCommand("SELECT sum(Total+tax+serviceCharge ) AS  Tot from OutLetBillMaster where Department='GardenSpa' and ReservationNo ='Direct'  and (BillGeneratedDate between @fdate and @tdate)", Conn)
            dcSearch.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcSearch.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date
            ' Dim dcIns As String = "SELECT * FROM tblmbilsum "
            ' SqlAdapter
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            Conn.Close()

            '//////

            Conn2.Open()
            'dcSearch2 = New SqlCommand("SELECT date, mbilno, rno,dep,  mainbar, SUM(cofe) AS cofe, SUM(spa) AS Spa, SUM(res) AS res, SUM(min) AS min, SUM(staff) AS staff, SUM(bl) AS bl, SUM(misrab) AS misrab,SUM(trans) AS trans, SUM(tot) AS tot, SUM(tax) AS tax, SUM(scharge) AS scharge, SUM(dis) AS dis, SUM(gtot) AS gtot FROM  dbo.tblmbilsumxle  where (date between @fdate and @tdate) GROUP BY date, mbilno, rno, dep, mainbar ORDER BY [date],[mbilno],rno", Conn)
            dcSearch2 = New SqlCommand("SELECT sum(Total+tax+serviceCharge ) AS  Tot from OutLetBillMaster where Department='GardenSpa' and ReservationNo <>'Direct' and (BillGeneratedDate between @fdate and @tdate)", Conn)
            dcSearch2.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            dcSearch2.Parameters.Add("@tdate", SqlDbType.Date).Value = todate.DateTime.Date
            '//dcSearch2.Parameters.Add("@fdate", SqlDbType.Date).Value = dtResDate.DateTime.Date
            '//dcSearch2.Parameters.Add("@tdate", SqlDbType.Date).Value = dtResDate2.DateTime.Date
            ' Dim dcIns As String = "SELECT * FROM tblmbilsum "
            ' SqlAdapter
            daMain2 = New SqlDataAdapter()
            daMain2.SelectCommand = dcSearch2
            daMain2.Fill(dsMain2)
            Conn2.Close()

            '//////




            xlWorkSheet.Cells(3, 4) = "ERIYADU ISLAND RESORT"
            xlWorkSheet.Range(xlWorkSheet.Cells(3, 4), xlWorkSheet.Cells(3, 7)).Font.Size = 18
            xlWorkSheet.Range(xlWorkSheet.Cells(3, 4), xlWorkSheet.Cells(3, 7)).Font.Bold = True
            xlWorkSheet.Cells(4, 4) = "platinum Capital Holdings Private Limited, MF Building, Chandnee Magu, Male"
            xlWorkSheet.Cells(5, 4) = "Phone : 6644487, Fax: 6645926, e-mail: eriaccs@pch.com.mv"
            xlWorkSheet.Cells(6, 4) = "STATEMENT SPA SALES " & dtResDate.DateTime.Date.ToString("MMMM")
            xlWorkSheet.Range(xlWorkSheet.Cells(9, 1), xlWorkSheet.Cells(9, 1)).Font.Size = 15
            xlWorkSheet.Range(xlWorkSheet.Cells(9, 1), xlWorkSheet.Cells(9, 1)).Font.Underline = True
            xlWorkSheet.Range(xlWorkSheet.Cells(6, 4), xlWorkSheet.Cells(6, 10)).Font.Bold = True
            xlWorkSheet.Cells(7, 4) = "INCOME SHARING WITH GARDEN SPA"

            xlWorkSheet.Range(xlWorkSheet.Cells(7, 4), xlWorkSheet.Cells(7, 10)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(3, 4), xlWorkSheet.Cells(3, 7)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(4, 4), xlWorkSheet.Cells(4, 10)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(5, 4), xlWorkSheet.Cells(5, 10)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(6, 4), xlWorkSheet.Cells(6, 10)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(7, 4), xlWorkSheet.Cells(7, 10)).Merge()

            xlWorkSheet.Cells(8, 10) = "All Figures are in US$"
            xlWorkSheet.Range(xlWorkSheet.Cells(8, 10), xlWorkSheet.Cells(8, 11)).Merge()
            xlWorkSheet.Range(xlWorkSheet.Cells(8, 10), xlWorkSheet.Cells(8, 11)).Font.Bold = True
            xlWorkSheet.Cells(9, 1) = "SALES"
            xlWorkSheet.Range(xlWorkSheet.Cells(9, 1), xlWorkSheet.Cells(9, 1)).Font.Bold = True
            xlWorkSheet.Cells(9, 3) = "Treatment - Credit Sales"
            xlWorkSheet.Cells(9, 6) = dsMain2.Tables(0).Rows(0).Item(0)
            xlWorkSheet.Cells(10, 3) = "          - Cash Sales"
            xlWorkSheet.Cells(10, 6) = dsMain.Tables(0).Rows(0).Item(0)
            xlWorkSheet.Cells(11, 3) = "Directors/relatives/VIP bill (50%)"

            xlWorkSheet.Cells.Item(11, 10) = "=SUM(f8:f10)"





            xlWorkSheet.Cells(13, 4) = "SALES FOR THE MONTH"
            xlWorkSheet.Range(xlWorkSheet.Cells(13, 4), xlWorkSheet.Cells(13, 4)).Font.Bold = True
            xlWorkSheet.Cells.Item(13, 10) = "=SUM(f8:f10)"

            xlWorkSheet.Cells(16, 1) = "EXPENSES"
            xlWorkSheet.Range(xlWorkSheet.Cells(16, 1), xlWorkSheet.Cells(16, 1)).Font.Bold = True
            xlWorkSheet.Cells(16, 3) = "Salary May"
            xlWorkSheet.Cells(17, 3) = "Commission to staff"
            xlWorkSheet.Cells(18, 3) = "Item issued to SPA"

            xlWorkSheet.Cells.Item(18, 10) = "=SUM(f16:f18)"
            xlWorkSheet.Cells.Item(19, 10) = "=SUM(f16:f18)"

            xlWorkSheet.Cells(21, 3) = "NET AMOUNT FOR INCOME SHARING"
            xlWorkSheet.Range(xlWorkSheet.Cells(21, 3), xlWorkSheet.Cells(21, 3)).Font.Bold = True
            xlWorkSheet.Cells.Item(21, 10) = "=j13+j19"

            xlWorkSheet.Cells(23, 1) = "INCOME SHARING"
            xlWorkSheet.Range(xlWorkSheet.Cells(23, 1), xlWorkSheet.Cells(23, 1)).Font.Bold = True
            xlWorkSheet.Cells(24, 3) = "ERIYADU SHARE"
            xlWorkSheet.Range(xlWorkSheet.Cells(24, 3), xlWorkSheet.Cells(24, 3)).Font.Bold = True
            xlWorkSheet.Cells(25, 3) = "Share 70%"
            xlWorkSheet.Cells.Item(25, 6) = "=((J13+J19)*70)/100"
            xlWorkSheet.Cells(26, 3) = "GARDEN SPA"
            xlWorkSheet.Range(xlWorkSheet.Cells(26, 3), xlWorkSheet.Cells(26, 3)).Font.Bold = True
            xlWorkSheet.Cells(27, 3) = "Share 30%"
            xlWorkSheet.Cells.Item(27, 6) = "=((J13+J19)*30)/100"

            xlWorkSheet.Cells(29, 5) = "TOTAL"
            xlWorkSheet.Range(xlWorkSheet.Cells(29, 5), xlWorkSheet.Cells(29, 5)).Font.Bold = True
            xlWorkSheet.Cells.Item(29, 6) = "=J13+J19"

            xlWorkSheet.Range(xlWorkSheet.Cells(29, 6), xlWorkSheet.Cells(29, 6)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(27, 6), xlWorkSheet.Cells(27, 6)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(25, 6), xlWorkSheet.Cells(25, 6)).Font.Bold = True

            xlWorkSheet.Range(xlWorkSheet.Cells(21, 10), xlWorkSheet.Cells(21, 10)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(19, 10), xlWorkSheet.Cells(19, 10)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(13, 10), xlWorkSheet.Cells(13, 10)).Font.Bold = True
            xlWorkSheet.Range(xlWorkSheet.Cells(11, 10), xlWorkSheet.Cells(11, 10)).Font.Bold = True




            xlWorkSheet.Cells(35, 1) = "Mangala Rathnayaka"
            xlWorkSheet.Cells(35, 10) = "Manager"
            xlWorkSheet.Cells(36, 1) = "Chief Accountant"
            xlWorkSheet.Cells(36, 10) = "Eriyadu Island Resort"



            xlWorkBook.ActiveSheet.Columns.AutoFit()
            If System.IO.File.Exists(Path.Combine(Application.StartupPath & "\SpaSalesReports\" & "SpaSales-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx")) = False Then
                xlWorkSheet.SaveAs(Path.Combine(Application.StartupPath & "\SpaSalesReports\" & "SpaSales-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))
                xlApp.Workbooks.Open(Path.Combine(Application.StartupPath & "\SpaSalesReports\" & "SpaSales-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))
                xlWorkBook.Close()
                xlApp.Quit()
                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                'Msg Box of Excel Sheet Path
                MsgBox("The " & "SpaSales-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx" & " saved in " & vbCrLf & Application.StartupPath & "\SpaSalesReports\")
                'xlApp.Workbooks.Open(Path.Combine(Application.StartupPath & "\MasterBillReports\" & "MasterBill-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx"))

            Else
                Dim respond As String = MsgBox("The " & "SpaSales-" & dtResDate.DateTime.Date.ToString("MMMM") & ".xlsx" & " Found in " & vbCrLf & Application.StartupPath & "\SpaSalesReports\" & vbCrLf & "Do You want Save a copy? ", vbYesNo, vbInformation)
                If respond = vbYes Then
                    xlWorkSheet.SaveAs(Path.Combine(Application.StartupPath & "\SpaSalesReports\" & "SpaSales-" & dtResDate.DateTime.Date.ToString("MMMM") & "copy.xlsx"))
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
            If New System.IO.DirectoryInfo(Path.Combine(Application.StartupPath, "SpaSalesReports")).Exists = False Then
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "SpaSalesReports"))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmSpaSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtResDate.Text = Today.Date

        todate.Text = Today.Date



    End Sub
End Class