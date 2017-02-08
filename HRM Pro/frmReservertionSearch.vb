Imports System.Data.SqlClient

Public Class frmReservertionSearch
    Dim IsReservertion As Boolean = False

    Private Sub frmReservertionSearch_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Enabled = True
    End Sub

    Private Sub frmReservertionSearch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        frmMain.Enabled = False
        LoadGuestDetails()
        SearchByDate("", False)
        dtRFrom.Text = Now.Date
        dtRTo.Text = Now.Date

    End Sub

    Sub LoadGuestDetails()
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetGuest As New SqlDataAdapter("select distinct ResNo,Guest,ResDate,NoOfDays,Operator,RoomNo,GuestRegDate,GuestRegNo from vwReservertionMasterSearch", Conn)
        Dim dsShowguest As New DataSet
        Dim dsReserveration As New DataSet
        Dim dcRes As New SqlCommand
        Dim daReservation As New SqlDataAdapter()
        Try
            daGetGuest.Fill(dsShowguest)

            '--- show in the grid 
            gridReservertion.DataSource = dsShowguest

            '---- show in the search box

            With cmbGuestSearch.Properties
                .DataSource = dsShowguest.Tables(0)
                .AutoSearchColumnIndex = 1
                .PopupWidth = 500
                .DisplayMember = "Guest"
                .ValueMember = "ResNo"
            End With

            '--- and also we can show them in the grid



            '---- 09022013 ----'
            '/*******************
            ' in this process new modification is done... 
            ' as per their requirement in this combo only need to show current date reservertions and day before reservertion. not done.
            '********************/
            'daGetGuest.Dispose()

            'Dim sqlStr As String = "select distinct ResNo,Guest,ResDate,NoOfDays,Operator from vwReservertionMasterOnly WHERE arrDate =@YDay or arrdate =@Today and " & _
            '    " ResNo COLLATE SQL_Latin1_General_CP1_CI_AI NOT IN (SELECT ReservationNo FROM GuestRegistration)"

            ''SELECT * FROM  vwReservertionMasterOnly 
            ''WHERE arrdate = '2012-10-29' or ArrDate = '2012-10-30' and  ResNo COLLATE SQL_Latin1_General_CP1_CI_AI NOT IN (SELECT ReservationNo FROM dbo.GuestRegistration)

            'Conn.Open()
            'dcRes = New SqlCommand(sqlStr, Conn)
            'dcRes.Parameters.Add("@YDay", SqlDbType.DateTime).Value = Now.Date.AddDays(-1)
            'dcRes.Parameters.Add("@Today", SqlDbType.DateTime).Value = Now.Date

            'daReservation = New SqlDataAdapter()
            'daReservation.SelectCommand = dcRes

            'daReservation.Fill(dsReserveration)



            '//////////////// old no need anymore... 
            ' so we can't load them in lookup edit.only the way we can show them as 
            'With cmbReservation.Properties
            '    .DataSource = dsReserveration.Tables(0)
            '    .AutoSearchColumnIndex = 0
            '    .PopupWidth = 500
            '    .DisplayMember = "ResNo"
            '    .ValueMember = "ResNo"
            'End With




            '//////////////////-----Added Rashad 

            LoadResToRegYst()

            '////////////////////////////////



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetGuest.Dispose()
            dsShowguest.Dispose()
            daReservation.Dispose()
            dsReserveration.Dispose()
        End Try
    End Sub
    Sub LoadResToRegYst()


        Dim Conn As New SqlConnection(ConnString)
        Dim dsShowguest As New DataSet
        Dim dsReserveration As New DataSet
        Dim dcRes As New SqlCommand
        Dim daReservation As New SqlDataAdapter()

        Try


            Dim sqlStr As String = "select distinct ResNo,Guest,ResDate,NoOfDays,Operator from vwReservertionMasterOnly WHERE Status='OPEN' and arrDate =@YDay and " & _
                   " ResNo COLLATE SQL_Latin1_General_CP1_CI_AI NOT IN (SELECT ReservationNo FROM GuestRegistration)"

            'SELECT * FROM  vwReservertionMasterOnly 
            'WHERE arrdate = '2012-10-29' or ArrDate = '2012-10-30' and  ResNo COLLATE SQL_Latin1_General_CP1_CI_AI NOT IN (SELECT ReservationNo FROM dbo.GuestRegistration)

            Conn.Open()
            dcRes = New SqlCommand(sqlStr, Conn)
            dcRes.Parameters.Add("@YDay", SqlDbType.DateTime).Value = Now.Date.AddDays(-1)
            dcRes.Parameters.Add("@Today", SqlDbType.DateTime).Value = Now.Date



            'Dim Ydays As Date = "2013 - 3 - 28"
            'Dim Tdays As Date = "2013 - 3 - 29"


            'dcRes.Parameters.Add("@YDay", SqlDbType.DateTime).Value = Ydays
            'dcRes.Parameters.Add("@Today", SqlDbType.DateTime).Value = Tdays



            daReservation = New SqlDataAdapter()
            daReservation.SelectCommand = dcRes

            daReservation.Fill(dsReserveration)



            '//////////////// old no need anymore... 
            ' so we can't load them in lookup edit.only the way we can show them as 

            If dsReserveration.Tables(0).Rows.Count > 0 Then
                With cmbReservation.Properties
                    .DataSource = dsReserveration.Tables(0)
                    .AutoSearchColumnIndex = 0
                    .PopupWidth = 500
                    .DisplayMember = "ResNo"
                    .ValueMember = "ResNo"
                End With


            Else


                LoadResToRegToday()



            End If

            

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            dsShowguest.Dispose()
            daReservation.Dispose()
            dsReserveration.Dispose()
        End Try



    End Sub
    Sub LoadResToRegToday()


        Dim Conn As New SqlConnection(ConnString)
        Dim dsShowguest As New DataSet
        Dim dsReserveration As New DataSet
        Dim dcRes As New SqlCommand
        Dim daReservation As New SqlDataAdapter()

        Try


            Dim sqlStr As String = "select distinct ResNo,Guest,ResDate,NoOfDays,Operator from vwReservertionMasterOnly WHERE Status='OPEN' and arrDate =@Today and " & _
                   " ResNo COLLATE SQL_Latin1_General_CP1_CI_AI NOT IN (SELECT ReservationNo FROM GuestRegistration)"

            'SELECT * FROM  vwReservertionMasterOnly 
            'WHERE arrdate = '2012-10-29' or ArrDate = '2012-10-30' and  ResNo COLLATE SQL_Latin1_General_CP1_CI_AI NOT IN (SELECT ReservationNo FROM dbo.GuestRegistration)

            Conn.Open()
            dcRes = New SqlCommand(sqlStr, Conn)

            dcRes.Parameters.Add("@YDay", SqlDbType.DateTime).Value = Now.Date.AddDays(-1)
            dcRes.Parameters.Add("@Today", SqlDbType.DateTime).Value = Now.Date



            'Dim Ydays As Date = "2013 - 3 - 28"
            'Dim Tdays As Date = "2013 - 3 - 29"


            'dcRes.Parameters.Add("@YDay", SqlDbType.DateTime).Value = Ydays
            'dcRes.Parameters.Add("@Today", SqlDbType.DateTime).Value = Tdays



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
            dsShowguest.Dispose()
            daReservation.Dispose()
            dsReserveration.Dispose()
        End Try



    End Sub


    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        SearchByDate("where GuestRegDate >=@FromDate and GuestRegDate <=@ToDate", True)
    End Sub

    Sub SearchByDate(ByVal WhereClause As String, ByVal IsDateType As Boolean)
        Dim Conn As New SqlConnection(ConnString)
        Dim sqlstring As String = "select distinct ResNo,Guest,ResDate,NoOfDays,Operator,RoomNo,GuestRegDate,GuestRegNo from vwReservertionMasterSearch " & WhereClause

        'If String.IsNullOrEmpty(WhereClause) Then
        '    sqlstring = "select distinct ResNo,Guest,ResDate,NoOfDays,Operator from vwReservertionMasterSearch " & WhereClause
        'Else
        '    sqlstring = "select distinct ResNo,Guest,ResDate,NoOfDays,Operator from vwReservertionMasterSearch " & WhereClause
        'End If

        Dim dcGetGuest As New SqlCommand(sqlstring, Conn)
        Dim daGetGuest As New SqlDataAdapter
        Dim dsShowguest As New DataSet

        Try

            Conn.Open()

            If IsDateType Then
                dcGetGuest.Parameters.Add("@FromDate", SqlDbType.Date).Value = dtRFrom.Text
                dcGetGuest.Parameters.Add("@ToDate", SqlDbType.Date).Value = dtRTo.Text
            End If

            daGetGuest.SelectCommand = dcGetGuest
            daGetGuest.Fill(dsShowguest)

            gridReservertion.DataSource = dsShowguest.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetGuest.Dispose()
            dsShowguest.Dispose()
        End Try
    End Sub



    Private Sub cmbReservation_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbReservation.EditValueChanged, cmbGuestSearch.EditValueChanged
        If cmbGuestSearch.IsModified Then
            SearchByDate(String.Format("where Guest like '{0}%'", cmbGuestSearch.Text), False)
            IsReservertion = False
        Else
            IsReservertion = True
            'SearchByDate(String.Format("where ResNo='{0}'", cmbReservation.GetColumnValue("ResNo")), False)
        End If

    End Sub

    Private Sub cmdSelect_Click(sender As System.Object, e As System.EventArgs) Handles cmdSelect.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestRegistration", "View")

        If CheckAccess = True Then


            If IsReservertion Then
                frmGuestRegistration.ReservertionNo = cmbReservation.GetColumnValue("ResNo")
            Else
                If IsDBNull(gvResevertion.GetFocusedRowCellValue("ResNo")) Or gvResevertion.GetFocusedRowCellValue("ResNo") Is Nothing Then
                    MsgBox("Please select a Reservertion No to continue...")
                    Exit Sub
                End If

                frmGuestRegistration.ReservertionNo = gvResevertion.GetFocusedRowCellValue("ResNo")
            End If

            frmGuestRegistration.Show()
            Me.Hide()



        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub txtSearchByPP_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtSearchByPP.EditValueChanged
        SearchByDate(String.Format("where Guest like '{0}%'", txtSearchByPP.Text), False)
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub
End Class