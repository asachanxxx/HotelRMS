Imports System.Data.SqlClient

Public Class frmGuestView

#Region " Procs & Funs "

    Sub LoadGuestSummary(ByVal WhereClause As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daGetGuest As New SqlDataAdapter("select * from GuestRegistration" & WhereClause, Conn)
        Dim dsShowguest As New DataSet


        Try

            daGetGuest.Fill(dsShowguest)

            gridGuestList.DataSource = dsShowguest.Tables(0)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetGuest.Dispose()
            dsShowguest.Dispose()
        End Try

    End Sub

    Sub DisplayGuestDetz(ByVal GuestRegno As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daGetDetz As New SqlDataAdapter(String.Format("select * from GuestRegistration where GuestRegNo like '{0}'", GuestRegno), Conn)
        Dim dsShowDetz As New DataSet

        Try

            daGetDetz.Fill(dsShowDetz)

            If dsShowDetz.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabMain.SelectedTabPageIndex = 1

            txtReservationNo.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("ReservationNo")), "", dsShowDetz.Tables(0).Rows(0).Item("ReservationNo"))
            dtReservationDate.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("ReservationDate")), "", dsShowDetz.Tables(0).Rows(0).Item("ReservationDate"))
            txtGuestRegNo.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("GuestRegNo")), "", dsShowDetz.Tables(0).Rows(0).Item("GuestRegNo"))
            dtRegDate.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("GuestRegDate")), "", dsShowDetz.Tables(0).Rows(0).Item("GuestRegDate"))
            dtArriveDate.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("ArriveDate")), "", dsShowDetz.Tables(0).Rows(0).Item("ArriveDate"))
            txtArriveFrom.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("ArriveFrom")), "", dsShowDetz.Tables(0).Rows(0).Item("ArriveFrom"))
            dtDepartureDate.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("DepDate")), "", dsShowDetz.Tables(0).Rows(0).Item("DepDate"))
            txtDepartureTo.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("DepTo")), "", dsShowDetz.Tables(0).Rows(0).Item("DepTo"))
            txtAFlight.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("AFlight")), "", dsShowDetz.Tables(0).Rows(0).Item("AFlight"))
            txtDFlight.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("DFlight")), "", dsShowDetz.Tables(0).Rows(0).Item("DFlight"))
            txtFullName.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("FullName")), "", dsShowDetz.Tables(0).Rows(0).Item("FullName"))
            txtPassportNo.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("PassportNo")), "", dsShowDetz.Tables(0).Rows(0).Item("PassportNo"))
            dtPPDateofIssue.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("PPDateOfIssue")), "", dsShowDetz.Tables(0).Rows(0).Item("PPDateOfIssue"))
            txtPPPlaceOfIssue.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("PPPlaceOfIssue")), "", dsShowDetz.Tables(0).Rows(0).Item("PPPlaceOfIssue"))
            txtNationality.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("Nationality")), "", dsShowDetz.Tables(0).Rows(0).Item("Nationality"))
            cmbCountry.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("Country")), "", dsShowDetz.Tables(0).Rows(0).Item("Country"))
            txtHomeAdd.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("HomeAddress")), "", dsShowDetz.Tables(0).Rows(0).Item("HomeAddress"))
            txtProfession.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("Profession")), "", dsShowDetz.Tables(0).Rows(0).Item("Profession"))
            dtDOB.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("DOB")), "", dsShowDetz.Tables(0).Rows(0).Item("DOB"))
            txtTotVisitMaldives.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("NoOfVisitMaldives")), "", dsShowDetz.Tables(0).Rows(0).Item("NoOfVisitMaldives"))
            txtTotVisitEriyadu.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("NoOfVisitEriyadu")), "", dsShowDetz.Tables(0).Rows(0).Item("NoOfVisitEriyadu"))
            txtRoom.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("RoomType")), "", dsShowDetz.Tables(0).Rows(0).Item("RoomType"))
            cmbRoomNo.Text = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("RoomNo")), "", dsShowDetz.Tables(0).Rows(0).Item("RoomNo"))
            cmbShareWith.EditValue = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("RoomShareWith")), "", dsShowDetz.Tables(0).Rows(0).Item("RoomShareWith"))
            chkIsBillingGuest.Checked = IIf(IsDBNull(dsShowDetz.Tables(0).Rows(0).Item("IsBillingGuest")), 0, dsShowDetz.Tables(0).Rows(0).Item("IsBillingGuest"))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDetz.Dispose()
            dsShowDetz.Dispose()
        End Try


    End Sub


#End Region

    Private Sub frmGuestView_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub

    Private Sub frmGuestView_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '---- Load guest registration main details
        LoadGuestSummary("")
    End Sub

    Private Sub txtSearchByPP_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtSearchByPP.EditValueChanged

        If rbByName.Checked Then
            LoadGuestSummary(String.Format(" where fullname like '{0}%'", txtSearchByPP.Text))
        Else
            LoadGuestSummary(String.Format(" where passportno like '{0}%'", txtSearchByPP.Text))
        End If

    End Sub

    Private Sub gvGuestList_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gvGuestList.DoubleClick
        Dim GuestRegNo As String = gvGuestList.GetRowCellValue(gvGuestList.FocusedRowHandle, "GuestRegNo")
        DisplayGuestDetz(GuestRegNo)
    End Sub

    Private Sub gvGuestList_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles gvGuestList.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim GuestRegNo As String = gvGuestList.GetRowCellValue(gvGuestList.FocusedRowHandle, "GuestRegNo")
            DisplayGuestDetz(GuestRegNo)
        End If
    End Sub
End Class