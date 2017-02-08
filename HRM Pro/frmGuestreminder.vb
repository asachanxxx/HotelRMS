Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Public Class frmGuestreminder

    Private Sub frmGuestreminder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtDateDep.Text = DateTime.Now.ToShortDateString
        dtBillSettlement.Text = DateTime.Now.ToShortDateString

    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestReminder", "Print")

        If CheckAccess = True Then


            InsertGuestReminderPrint()
            PrintReminderLetter()

            gcDep.DataSource = Nothing

            LoadReservationDepartureDetails()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub btnViewDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDep.Click
        LoadReservationDepartureDetails()

    End Sub
    Private Sub LoadReservationDepartureDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select Roomno,ReservationNo,DepDate, convert(char(5), DTime, 108) [DepTime],DFlight,DepTo,FullName,Country  from GuestRegistration where IsBillingGuest=1 and DepDate=@DepDate order by DTime,roomno", Conn)
            dcSearch.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = dtDateDep.DateTime.Date

            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            If (Not dsMain Is Nothing) Then
                gcDep.DataSource = dsMain.Tables(0)



            End If

            If dsMain.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("No Records", "Departures", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            gcDep.Refresh()


            Dim dtcol As New DataColumn("select", System.Type.GetType("System.Boolean"))
            dsMain.Tables(0).Columns.Add(dtcol)

            'Dim dtcol As New DataColumn
            'dtcol.ColumnName = "select"
            'dsMain.Tables(0).Columns.Add(dtcol)



            'gcDep.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub PrintReminderLetter()
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
            dcIns = New SqlCommand("select * from Guest_Reminder_View", Conn)
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()

            fltString = ""
           

            ReportName = "Guest_Reminder.rpt"
            rptTitle = "Guest_Reminder_Letter"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            frmReportViewer.paraRepName = "fromDate"
            frmReportViewer.paraRepVale = ""


            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub btnViewDep_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnViewDep.KeyDown
        If e.KeyCode = Keys.Enter Then
            gcDep.Focus()
        End If
    End Sub

    Private Sub dtBillSettlement_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtBillSettlement.KeyDown
        If e.KeyCode = Keys.Enter Then
            TimeBillSF.Focus()
        End If
    End Sub

    Private Sub TimeBillSF_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TimeBillSF.KeyDown
        If e.KeyCode = Keys.Enter Then
            TimeBillST.Focus()
        End If
    End Sub

    Private Sub TimeBillST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TimeBillST.KeyDown
        If e.KeyCode = Keys.Enter Then
            TimeWakeup.Focus()
        End If
    End Sub

    Private Sub TimeWakeup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TimeWakeup.KeyDown
        If e.KeyCode = Keys.Enter Then
            TimeLCollection.Focus()
        End If
    End Sub

    Private Sub TimeLCollection_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TimeLCollection.KeyDown
        If e.KeyCode = Keys.Enter Then
            TimeMealS.Focus()
        End If
    End Sub

    Private Sub TimeMealS_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TimeMealS.KeyDown
        If e.KeyCode = Keys.Enter Then
            TimeFinalBill.Focus()
        End If
    End Sub

    Private Sub TimeFinalBill_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TimeFinalBill.KeyDown
        If e.KeyCode = Keys.Enter Then
            TimeHDep.Focus()
        End If
    End Sub

    Private Sub TimeHDep_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TimeHDep.KeyDown
        If e.KeyCode = Keys.Enter Then
            btPrint.Focus()
        End If
    End Sub
    Private Sub InsertGuestReminderPrint()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        Dim CurrentUser As String = CurrUser

        Dim GetRoomno As String = ""
        Dim GetGuest As String = ""
        Dim GetCountry As String = ""



        For i As Integer = 0 To gvDep.RowCount - 1

            If (Not IsDBNull(gvDep.GetRowCellValue(i, "select"))) Then

                GetRoomno = gvDep.GetRowCellValue(i, "Roomno")
                GetGuest = gvDep.GetRowCellValue(i, "FullName")
                GetCountry = gvDep.GetRowCellValue(i, "Country")


            End If

        Next


        InsertData(GetRoomno, GetGuest, GetCountry)


        
    End Sub
    Private Sub InsertData(ByVal Roomno, ByVal Guest, ByVal Country)


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim passRoomno As String = Roomno
        Dim passGuest As String = Guest
        Dim passCountry As String = Country

        Dim GetCountryID As Integer = 1


        Dim dscheckcountry As New DataSet

        dscheckcountry = DSGetCountryId(passCountry)

        If dscheckcountry.Tables(0) Is DBNull.Value Then
            GetCountryID = 1
            Exit Sub

        Else

            If CheckEng.Checked = True Then

                GetCountryID = 1

            Else

                If dscheckcountry.Tables(0).Rows.Count > 0 Then
                    GetCountryID = Convert.ToInt16(dscheckcountry.Tables(0).Rows(0)(0))
                End If

            End If

            


        End If



        Dim GetWTimeWakeupRES As String = ""
        Dim GetWTimeMealREQ As String = ""

        If CbWake.Checked = True Then

            GetWTimeWakeupRES = "YES"


        Else

            GetWTimeWakeupRES = "NO"


        End If



        If CbMR.Checked = True Then

            GetWTimeMealREQ = "YES"

        Else

            GetWTimeMealREQ = "NO"

        End If



        dcInsertNewAcc = New SqlCommand("InsertGuestReminderPrint_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@Roomno", SqlDbType.VarChar).Value = passRoomno
        dcInsertNewAcc.Parameters.Add("@Guest", SqlDbType.VarChar).Value = passGuest
        dcInsertNewAcc.Parameters.Add("@CountryId", SqlDbType.Int).Value = GetCountryID
        dcInsertNewAcc.Parameters.Add("@BillSetDate", SqlDbType.DateTime).Value = dtBillSettlement.Text
        dcInsertNewAcc.Parameters.Add("@TimeBillSF", SqlDbType.DateTime).Value = TimeBillSF.Text
        dcInsertNewAcc.Parameters.Add("@TimeBillST", SqlDbType.DateTime).Value = TimeBillST.Text
        dcInsertNewAcc.Parameters.Add("@TimeWakeup", SqlDbType.DateTime).Value = TimeWakeup.Text
        dcInsertNewAcc.Parameters.Add("@TimeLCollection", SqlDbType.DateTime).Value = TimeLCollection.Text
        dcInsertNewAcc.Parameters.Add("@TimeMealS", SqlDbType.DateTime).Value = TimeMealS.Text
        dcInsertNewAcc.Parameters.Add("@TimeFinalBill", SqlDbType.DateTime).Value = TimeFinalBill.Text
        dcInsertNewAcc.Parameters.Add("@TimeHDep", SqlDbType.DateTime).Value = TimeHDep.Text
        dcInsertNewAcc.Parameters.Add("@TimeWakeupRES", SqlDbType.VarChar).Value = GetWTimeWakeupRES
        dcInsertNewAcc.Parameters.Add("@TimeMealREQ", SqlDbType.VarChar).Value = GetWTimeMealREQ




        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub


    Function DSGetCountryId(ByVal passCountry As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()

            Dim GetCountry As String = passCountry

            dcSearch = New SqlCommand("select Id from LanguageTranslate where Country=@Country", Conn)
            dcSearch.Parameters.Add("@Country", SqlDbType.VarChar).Value = GetCountry


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            DSGetCountryId = dsMain

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function

    Private Sub frmGuestreminder_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub gvDep_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvDep.CellValueChanged
        'If gvDep.GetRowCellValue(e.RowHandle, "GINQty") > gvDep.GetRowCellValue(e.RowHandle, "select") Then
        '    cmdNew.Enabled = False

        'End If
    End Sub
End Class