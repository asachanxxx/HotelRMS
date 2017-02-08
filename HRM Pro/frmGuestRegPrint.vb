Imports System.Data.SqlClient
Public Class frmGuestRegPrint
    Public ReportName As String
    Public rptTitle As String
    Public SF As String = ""
    Public PubResno As String = ""
    Public PubTotPax As String = ""
    Public PubRoomNo As String = ""
    Private Sub frmGuestRegPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btView.Click
        cmbReservation.Properties.DataSource = Nothing

        LoadReservertionsDetzByDate()
    End Sub
    Private Sub LoadReservertionsDetzByDate()

        Dim Conn As New SqlConnection(ConnString)


        Dim dsReserveration As New DataSet
        Dim dcRes As New SqlCommand
        Dim daReservation As New SqlDataAdapter()
        Try



            Dim sqlStr As String = "select distinct ResNo,Guest,ResDate,NoOfDays,Operator from vwReservertionMasterOnly where Status='OPEN' AND arrDate=@NextArrDate"


            Conn.Open()
            dcRes = New SqlCommand(sqlStr, Conn)
            dcRes.Parameters.Add("@NextArrDate", SqlDbType.DateTime).Value = dtDate.DateTime.Date


            daReservation = New SqlDataAdapter()
            daReservation.SelectCommand = dcRes

            daReservation.Fill(dsReserveration)



            '//////////////// old no need anymore... 
            ' so we can't load them in lookup edit.only the way we can show them as 
            With cmbReservation.Properties
                .DataSource = dsReserveration.Tables(0)
                .AutoSearchColumnIndex = 0
                .PopupWidth = 500
                .DisplayMember = "ResNo"
                .ValueMember = "ResNo"
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()

            dcRes.Dispose()
            daReservation.Dispose()
            dsReserveration.Dispose()
        End Try
    End Sub

    Private Sub cmbReservation_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReservation.EditValueChanged
        LoadReservertionDetails()
    End Sub
    Function LoadReservertionDetails() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcRun As New SqlCommand(String.Format("select * from view_regcard_print_res where Resno like '{0}'", cmbReservation.GetColumnValue("ResNo")), Conn)
        Dim daGetGuest As New SqlDataAdapter()
        Dim dsShowguest As New DataSet

        Try
            Conn.Open()

            daGetGuest.SelectCommand = dcRun

            daGetGuest.Fill(dsShowguest)


            grdReservation.DataSource = dsShowguest.Tables(0)

            ' MessageBox.Show(" No of Records" + dsShowguest.Tables(0).Rows.Count.ToString)


            If dsShowguest.Tables(0).Rows.Count = 0 Then
                Exit Function
            End If


            'RoomTypeMain = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("Room")), "", dsShowguest.Tables(0).Rows(0).Item("Room"))


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetGuest.Dispose()
            dsShowguest.Dispose()
            dcRun.Dispose()
        End Try

    End Function

   
    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestRegistration", "Add")

        If CheckAccess = True Then

            PrintRegCard()

        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub
    Private Sub PrintRegCard()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from view_guest_reg_card_res", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaRegno As String = PubResno
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            fltString = "{view_guest_reg_card_res.ResNo}='" & ParaRegno & "'"





            MessageBox.Show("No Of  Guest Registration Card Need To Print::  " + PubTotPax + "  for Room No " + PubRoomNo, "Print Guest Registration ", MessageBoxButtons.OK)

           

            ReportName = "GuestregistrationCardRes.rpt"
                    rptTitle = "Guest Registration"






            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            'frmReportViewer.paraRepName = "TestPara"
            'frmReportViewer.paraRepVale = DtToday.Text.ToString

            'frmReportViewer.paraRepName2 = "TestPara2"
            'frmReportViewer.paraRepVale2 = DtToday.Text.ToString


            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub gvMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvMain.Click
        PubResno = gvMain.GetRowCellValue(gvMain.FocusedRowHandle, "ResNo")
        PubTotPax = gvMain.GetRowCellValue(gvMain.FocusedRowHandle, "RoomPax")
        PubRoomNo = gvMain.GetRowCellValue(gvMain.FocusedRowHandle, "RoomNo")
    End Sub
End Class