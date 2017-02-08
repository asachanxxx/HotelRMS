Imports System.Data.SqlClient

Public Class frmReservertionRoomAssign
    Dim RoomTypeMain As String
    Dim PubId As Integer = 0
    Dim PubResno As String = ""



    Private Sub frmReservertionRoomAssign_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' LoadVacantRooms()
        'LoadNextDayVacantRooms()
        'LoadReservertionsDetz()
    End Sub

    Private Sub cmdUpdate_Click(sender As System.Object, e As System.EventArgs) Handles cmdUpdate.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "AssignRoom", "Add")

        If CheckAccess = True Then


            If gvMain.RowCount = 0 Then
                Exit Sub
            End If

            '--- what m donna do is... 
            ' if update clicked, remove the all the records from the reservertionroomassign and recreate

            If IsUpdateAll() Then
                MsgBox("Successfully Updated", MsgBoxStyle.Information, ErrTitle)
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Function IsUpdateAll() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand
        Dim sqlStr As String

        Try
            Conn.Open()

            'sqlStr = "delete from ReservertionRoomAssign where resno like '" & cmbReservation.GetColumnValue("ResNo") & "'"
            'dcExec = New SqlCommand(sqlStr, Conn)
            'dcExec.ExecuteNonQuery()
            'dcExec.Dispose()

            '       CDate(gvMain.GetRowCellValue(i, "ResDate")) & "','" & gvMain.GetRowCellValue(i, "RoomNo") & "')"

                'sqlStr = "insert into ReservertionRoomAssign(ResNo,ResDate,RoomNo) values(@ResNo,@ResDate,@RoomNo)"

                dcExec = New SqlCommand("spResAssignRoom", Conn)
                dcExec.CommandType = CommandType.StoredProcedure

            dcExec.Parameters.Add("@ResNo", SqlDbType.NVarChar).Value = cmbReservation.GetColumnValue("ResNo") ' gvMain.GetRowCellDisplayText(i, "ResNo")
                'dcExec.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = gvMain.GetRowCellDisplayText(i, "ResDate")
                'dcExec.Parameters.Add("@RoomNo", SqlDbType.NVarChar).Value = gvMain.GetRowCellDisplayText(i, "RoomNo")

                dcExec.ExecuteNonQuery()
                

           

            Return True
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcExec.Dispose()

        End Try

    End Function
    Sub LoadVacantRooms(ByVal RoomType As String)




        Dim getRoomType As String = RoomType

        Dim Conn As New SqlConnection(ConnString)
        'Dim daGetAll As New SqlDataAdapter(String.Format("select Roomno from [rooms.master] where category ='{0}' and status ='vacant' and roomno not in (select roomno from ReservertionRoomAssign)", RoomType), Conn)

        ' Dim daGetAll As New SqlDataAdapter(String.Format("select Roomno from [rooms.master] where Category='" & getRoomType & "' and   status ='vacant' and roomno not in (select roomno from ReservertionRoomAssign)"), Conn)


        Dim daGetAll As New SqlDataAdapter(String.Format("select Roomno from [rooms.master] where  IsInactive=0 and  Category='" & getRoomType & "' and   status ='vacant' "), Conn)


        '  Dim daGetAll As New SqlDataAdapter(String.Format("select Roomno from [rooms.master] where Category='" & getRoomType & "' and   status ='vacant' ", Conn))



        '  Dim daGetAll As New SqlDataAdapter(String.Format("select Roomno from [rooms.master] where    status ='vacant' and roomno not in (select roomno from ReservertionRoomAssign)"), Conn)

        Dim dsShow As New DataSet

        Try

            cmbVacant.Properties.Items.Clear()
            cmbVacant.Text = ""

            daGetAll.Fill(dsShow)

            For i As Integer = 0 To dsShow.Tables(0).Rows.Count - 1

                '---- before we show them, we need to check whether given room already assigned.... 

                cmbVacant.Properties.Items.Add(dsShow.Tables(0).Rows(i).Item(0))

            Next

            cmbVacant.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetAll.Dispose()
            dsShow.Dispose()
        End Try


    End Sub

    Sub LoadNextDayVacantRooms()
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetAll As New SqlDataAdapter()
        Dim dsShow As New DataSet
        ' Dim dcGetAll As New SqlCommand(String.Format("select Roomno from GuestRegistration where DepDate=@DepDate and roomno not in (select roomno from reservertionroomassign)"), Conn)



        Dim dcGetAll As New SqlCommand(String.Format("select Roomno from GuestRegistration where DepDate=@DepDate"), Conn)

        Try

            Conn.Open()
            'dcGetAll.Parameters.Add("", SqlDbType.DateTime).Value = Now.Date.AddDays(1)
            dcGetAll.Parameters.Add("@DepDate", SqlDbType.DateTime).Value = Now.Date.AddDays(1)


            daGetAll.SelectCommand = dcGetAll
            daGetAll.Fill(dsShow)

            cmbNDVacant.Properties.Items.Clear()
            cmbNDVacant.Text = ""

            For i As Integer = 0 To dsShow.Tables(0).Rows.Count - 1

                '---- before we show them, we need to check whether given room already assigned.... 

                cmbNDVacant.Properties.Items.Add(dsShow.Tables(0).Rows(i).Item(0))

            Next

            cmbNDVacant.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetAll.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub LoadReservertionsDetz()

        Dim Conn As New SqlConnection(ConnString)


        Dim dsReserveration As New DataSet
        Dim dcRes As New SqlCommand
        Dim daReservation As New SqlDataAdapter()
        Try
            

            'Dim sqlStr As String = "select distinct ResNo,Guest,ResDate,NoOfDays,Operator from vwReservertionMasterOnly WHERE arrDate =@YDay or arrdate =@Today and " & _
            '    " ResNo COLLATE SQL_Latin1_General_CP1_CI_AI NOT IN (SELECT ReservationNo FROM GuestRegistration)"

            Dim sqlStr As String = "select distinct ResNo,Guest,ResDate,NoOfDays,Operator from vwReservertionMasterOnly where arrDate=@NextArrDate"
            'SELECT * FROM  vwReservertionMasterOnly 
            'WHERE arrdate = '2012-10-29' or ArrDate = '2012-10-30' and  ResNo COLLATE SQL_Latin1_General_CP1_CI_AI NOT IN (SELECT ReservationNo FROM dbo.GuestRegistration)

            Conn.Open()
            dcRes = New SqlCommand(sqlStr, Conn)
            dcRes.Parameters.Add("@NextArrDate", SqlDbType.DateTime).Value = Now.Date.AddDays(1)


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

    Function LoadReservertionDetails() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcRun As New SqlCommand(String.Format("select * from vwReservertionMaster where Resno like '{0}'", cmbReservation.GetColumnValue("ResNo")), Conn)
        Dim daGetGuest As New SqlDataAdapter()
        Dim dsShowguest As New DataSet

        Try
            Conn.Open()

            daGetGuest.SelectCommand = dcRun

            daGetGuest.Fill(dsShowguest)


            If dsShowguest.Tables(0).Rows.Count = 0 Then
                Exit Function
            End If

            
            RoomTypeMain = IIf(IsDBNull(dsShowguest.Tables(0).Rows(0).Item("Room")), "", dsShowguest.Tables(0).Rows(0).Item("Room"))


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetGuest.Dispose()
            dsShowguest.Dispose()
            dcRun.Dispose()
        End Try

    End Function
    Sub LoadReservationRoomType()
        Dim Conn As New SqlConnection(ConnString)
        'Dim daGetAll As New SqlDataAdapter(String.Format("select Roomno from [rooms.master] where category ='{0}' and status ='vacant' and roomno not in (select roomno from ReservertionRoomAssign)", RoomType), Conn)

        Dim daGetAll As New SqlDataAdapter(String.Format("select distinct Room from vwReservertionMaster where Resno like '{0}'", cmbReservation.GetColumnValue("ResNo")), Conn)
        Dim dsShow As New DataSet

        Try

            cmbRoomtype.Properties.Items.Clear()
            cmbRoomtype.Text = ""

            daGetAll.Fill(dsShow)

            For i As Integer = 0 To dsShow.Tables(0).Rows.Count - 1

                '---- before we show them, we need to check whether given room already assigned.... 

                cmbRoomtype.Properties.Items.Add(dsShow.Tables(0).Rows(i).Item(0))

            Next

            cmbRoomtype.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetAll.Dispose()
            dsShow.Dispose()
        End Try


    End Sub
    Sub LoadReservationRoomBedType()
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetAll As New SqlDataAdapter()
        Dim dsShow As New DataSet
        Dim dcGetAll As New SqlCommand(String.Format("select Roomtype from vwReservertionMaster where Resno=@Resno and Room=@Room"), Conn)

        Try

            Conn.Open()

            dcGetAll.Parameters.Add("@Resno", SqlDbType.VarChar).Value = cmbReservation.GetColumnValue("ResNo")
            dcGetAll.Parameters.Add("@Room", SqlDbType.VarChar).Value = cmbRoomtype.Text.Trim


            daGetAll.SelectCommand = dcGetAll
            daGetAll.Fill(dsShow)

            cmbBedtype.Properties.Items.Clear()
            cmbBedtype.Text = ""

            For i As Integer = 0 To dsShow.Tables(0).Rows.Count - 1

                '---- before we show them, we need to check whether given room already assigned.... 

                cmbBedtype.Properties.Items.Add(dsShow.Tables(0).Rows(i).Item(0))

            Next

            cmbBedtype.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetAll.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Sub LoadReservationRoomBedTypeCount()
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetAll As New SqlDataAdapter()
        Dim dsShow As New DataSet
        Dim dcGetAll As New SqlCommand(String.Format("select RoomCount,TotPax from vwReservertionMaster where Resno=@Resno and Room=@Room and Roomtype=@Roomtype"), Conn)

        Try

            Conn.Open()

            dcGetAll.Parameters.Add("@Resno", SqlDbType.VarChar).Value = cmbReservation.GetColumnValue("ResNo")
            dcGetAll.Parameters.Add("@Room", SqlDbType.VarChar).Value = cmbRoomtype.Text.Trim
            dcGetAll.Parameters.Add("@Roomtype", SqlDbType.VarChar).Value = cmbBedtype.Text.Trim


            daGetAll.SelectCommand = dcGetAll
            daGetAll.Fill(dsShow)

            'cmbBedtype.Properties.Items.Clear()
            'cmbBedtype.Text = ""

            'For i As Integer = 0 To dsShow.Tables(0).Rows.Count - 1

            '---- before we show them, we need to check whether given room already assigned.... 
            lblRoomQty.Text = dsShow.Tables(0).Rows(0).Item(0)



            lblPax.Text = (Convert.ToInt16((dsShow.Tables(0).Rows(0).Item(1))) / Convert.ToInt16(lblRoomQty.Text)).ToString()
            'cmbBedtype.Properties.Items.Add(dsShow.Tables(0).Rows(i).Item(0))

            'Next

            'cmbBedtype.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetAll.Dispose()
            dsShow.Dispose()
        End Try
    End Sub

    Private Sub cmbReservation_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbReservation.EditValueChanged
        LoadReservertionDetails()
        LoadReservationRoomType()

        LoadVacantRooms(RoomTypeMain)
        LoadNextDayVacantRooms()


        LoadGridDetz(cmbReservation.GetColumnValue("ResNo"))
    End Sub

    Private Sub LoadGridDetz(ByVal ReservertionNo As String)
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetAll As New SqlDataAdapter()
        Dim dsShow As New DataSet
        Dim dcExec As New SqlCommand
        Dim sqlStr As String

        Try
            Conn.Open()

            'sqlStr = "delete from TempResRoomAssign where resno like '" & cmbReservation.GetColumnValue("ResNo") & "'"
            'dcExec = New SqlCommand(sqlStr, Conn)
            'dcExec.ExecuteNonQuery()
            'dcExec.Dispose()

            'sqlStr = String.Format("insert into TempResRoomAssign(ResNo,Room,BedType,RoomCount,RoomPax,ResDate,RoomNo) select ResNo,Room,BedType,RoomCount,RoomPax,ResDate,RoomNo  from ReservertionRoomAssign where ResNo like '{0}'", ReservertionNo)
            'dcExec = New SqlCommand(sqlStr, Conn)
            'dcExec.ExecuteNonQuery()
            'dcExec.Dispose()

            ' daGetAll = New SqlDataAdapter(String.Format("select Id, ResNo,Room,BedType,RoomCount,RoomPax,ResDate,RoomNo  from TempResRoomAssign where ResNo like '{0}'", ReservertionNo), Conn)

            daGetAll = New SqlDataAdapter(String.Format("select Id, ResNo,Room,BedType,RoomCount,RoomPax,ResDate,RoomNo  from ReservertionRoomAssign where ResNo like '{0}'", ReservertionNo), Conn)

            daGetAll.Fill(dsShow)

            grdReservation.DataSource = dsShow.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetAll.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Private Sub cmdVacAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdVacAdd.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "AssignRoom", "Add")

        If CheckAccess = True Then



            Try


                        Dim getPassResno As String = cmbReservation.Text
                        Dim getPassRoomno As String = cmbVacant.Text
                        Dim getPassRoom As String = cmbRoomtype.Text
                        Dim getPassBedtype As String = cmbBedtype.Text


                Dim dscheckRoomAddbefore As New DataSet
                dscheckRoomAddbefore = DSCheckAddRoomNoBefore(dtDate.DateTime.Date, getPassRoomno)

                If dscheckRoomAddbefore.Tables(0) Is DBNull.Value Or dscheckRoomAddbefore.Tables(0).Rows.Count = 0 Then


                    Dim ConnStr As String = ConnString
                    Dim Conn As New SqlConnection(ConnStr)
                    Dim dcInsertNewAcc As New SqlCommand

                    dcInsertNewAcc = New SqlCommand("UpdateRoomInResAssign", Conn)
                    dcInsertNewAcc.CommandType = CommandType.StoredProcedure

                    dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = getPassResno
                    dcInsertNewAcc.Parameters.Add("@Roomno ", SqlDbType.VarChar).Value = getPassRoomno
                    dcInsertNewAcc.Parameters.Add("@Room", SqlDbType.VarChar).Value = getPassRoom
                    dcInsertNewAcc.Parameters.Add("@Bedtype", SqlDbType.VarChar).Value = getPassBedtype
                    dcInsertNewAcc.Parameters.Add("@Id", SqlDbType.Int).Value = PubId

                    Conn.Open()
                    dcInsertNewAcc.ExecuteNonQuery()

                    Conn.Close()

                    LoadGridDetz(cmbReservation.GetColumnValue("ResNo"))


                Else

                    If dscheckRoomAddbefore.Tables(0).Rows.Count > 0 Then

                        MessageBox.Show("Room No Already Assigned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub

                    End If
                End If


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try



        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Function DSCheckAddRoomNoBefore(ByVal Resdate As DateTime, ByVal Roomno As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            Dim getResdate As DateTime = Resdate
            Dim getRoomno As String = Roomno



            dcSearch = New SqlCommand("select * from dbo.[ReservertionRoomAssign] where  ResDate=@ResDate and RoomNo=@RoomNo", Conn)
            'dcSearch.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = getResno
            dcSearch.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = getResdate
            dcSearch.Parameters.Add("@RoomNo", SqlDbType.VarChar).Value = getRoomno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            'Dim count As Integer = dsMain.Tables(0).Rows.Count
            'If count > 0 Then
            DSCheckAddRoomNoBefore = dsMain


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

    Private Sub cmdNDAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdNDAdd.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "AssignRoom", "Add")

        If CheckAccess = True Then



            Try



                Dim ConnStr As String = ConnString
                Dim Conn As New SqlConnection(ConnStr)
                Dim dcInsertNewAcc As New SqlCommand

                Dim getPassResno As String = cmbReservation.Text
                Dim getPassRoomno As String = cmbNDVacant.Text
                Dim getPassRoom As String = cmbRoomtype.Text
                Dim getPassBedtype As String = cmbBedtype.Text


                Dim dscheckRoomAddbefore As New DataSet
                dscheckRoomAddbefore = DSCheckAddRoomNoBefore(dtDate.DateTime.Date, getPassRoomno)

                If dscheckRoomAddbefore.Tables(0) Is DBNull.Value Or dscheckRoomAddbefore.Tables(0).Rows.Count = 0 Then

                   


                    dcInsertNewAcc = New SqlCommand("UpdateRoomInResAssign", Conn)
                    dcInsertNewAcc.CommandType = CommandType.StoredProcedure

                    dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = getPassResno
                    dcInsertNewAcc.Parameters.Add("@Roomno ", SqlDbType.VarChar).Value = getPassRoomno
                    dcInsertNewAcc.Parameters.Add("@Room", SqlDbType.VarChar).Value = getPassRoom
                    dcInsertNewAcc.Parameters.Add("@Bedtype", SqlDbType.VarChar).Value = getPassBedtype
                    dcInsertNewAcc.Parameters.Add("@Id", SqlDbType.Int).Value = PubId

                    Conn.Open()
                    dcInsertNewAcc.ExecuteNonQuery()

                    Conn.Close()



                    LoadGridDetz(cmbReservation.GetColumnValue("ResNo"))



                Else

                    If dscheckRoomAddbefore.Tables(0).Rows.Count > 0 Then

                        MessageBox.Show("Room No Already Assigned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub

                    End If
                End If




            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


            ''cmbVacant.Properties.Items.Remove(cmbVacant.Text)
            'Dim Conn As New SqlConnection(ConnString)
            'Dim dcExec As New SqlCommand
            'Dim sqlstr As String = ""

            'Try
            '    If cmbNDVacant.SelectedIndex < 0 Then
            '        Exit Sub
            '    End If

            '    Conn.Open()


            '    sqlstr = "insert into TempResRoomAssign(ResNo,Room,BedType,RoomCount,RoomPax,ResDate,RoomNo) values(@ResNo,@Room,@BedType,@RoomCount,@RoomPax,@ResDate,@RoomNo)"

            '    dcExec = New SqlCommand(sqlstr, Conn)
            '    dcExec.Parameters.Add("@ResNo", SqlDbType.NVarChar).Value = cmbReservation.GetColumnValue("ResNo")
            '    dcExec.Parameters.Add("@Room", SqlDbType.NVarChar).Value = cmbRoomtype.Text
            '    dcExec.Parameters.Add("@BedType", SqlDbType.NVarChar).Value = cmbBedtype.Text
            '    dcExec.Parameters.Add("@RoomCount", SqlDbType.Int).Value = 1
            '    dcExec.Parameters.Add("@RoomPax", SqlDbType.Int).Value = Convert.ToInt32(lblPax.Text)


            '    dcExec.Parameters.Add("@ResDate", SqlDbType.DateTime).Value = cmbReservation.GetColumnValue("ResDate")
            '    dcExec.Parameters.Add("@RoomNo", SqlDbType.NVarChar).Value = cmbNDVacant.Text

            '    dcExec.ExecuteNonQuery()

            '    '------ 

            '    gvMain.AddNewRow()
            '    gvMain.SetRowCellValue(gvMain.FocusedRowHandle, "ResNo", cmbReservation.GetColumnValue("ResNo"))
            '    gvMain.SetRowCellValue(gvMain.FocusedRowHandle, "Room", cmbReservation.GetColumnValue("Room"))
            '    gvMain.SetRowCellValue(gvMain.FocusedRowHandle, "BedType", cmbReservation.GetColumnValue("BedType"))

            '    gvMain.SetRowCellValue(gvMain.FocusedRowHandle, "RoomCount", cmbReservation.GetColumnValue("RoomCount"))
            '    gvMain.SetRowCellValue(gvMain.FocusedRowHandle, "RoomPax", cmbReservation.GetColumnValue("RoomPax"))
            '    gvMain.SetRowCellValue(gvMain.FocusedRowHandle, "ResDate", cmbReservation.GetColumnValue("ResDate"))
            '    gvMain.SetRowCellValue(gvMain.FocusedRowHandle, "RoomNo", cmbNDVacant.Text)


            '    cmbVacant.Properties.Items.RemoveAt(cmbVacant.SelectedIndex)
            '    cmbVacant.RefreshEditValue()

            '    cmbVacant.EditValue = ""



            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            'Finally
            '    Conn.Dispose()
            '    dcExec.Dispose()
            'End Try

            'If cmbNDVacant.SelectedIndex < 0 Then
            '    Exit Sub
            'End If

            'gvMain.AddNewRow()
            'gvMain.SetRowCellValue(gvMain.FocusedRowHandle, "ResNo", cmbReservation.GetColumnValue("ResNo"))
            'gvMain.SetRowCellValue(gvMain.FocusedRowHandle, "ResDate", cmbReservation.GetColumnValue("ResDate"))
            'gvMain.SetRowCellValue(gvMain.FocusedRowHandle, "RoomNo", cmbNDVacant.Text)

            ''cmbVacant.Properties.Items.Remove(cmbVacant.Text)

            'cmbNDVacant.Properties.Items.RemoveAt(cmbNDVacant.SelectedIndex)
            'cmbNDVacant.RefreshEditValue()

            'cmbNDVacant.EditValue = ""

            'gvMain.Focus()



        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub gvMain_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gvMain.KeyDown
        If e.KeyCode = Keys.Delete Then

            If gvMain.RowCount = 0 Then
                Exit Sub
            End If

            Dim Conn As New SqlConnection(ConnString)
            Dim dcExec As New SqlCommand
            Dim sqlstr As String = ""

            Try
               

                Conn.Open()


                sqlstr = "delete from TempResRoomAssign where resno =@ResNo and roomno = @RoomNo"

                dcExec = New SqlCommand(sqlstr, Conn)
                dcExec.Parameters.Add("@ResNo", SqlDbType.NVarChar).Value = cmbReservation.GetColumnValue("ResNo")
                dcExec.Parameters.Add("@RoomNo", SqlDbType.NVarChar).Value = gvMain.GetFocusedRowCellValue("RoomNo")

                dcExec.ExecuteNonQuery()

                gvMain.DeleteRow(gvMain.FocusedRowHandle)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Finally
                Conn.Dispose()
                dcExec.Dispose()
            End Try

        End If
    End Sub

    Private Sub cmbRoomtype_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRoomtype.EditValueChanged
        LoadReservationRoomBedType()

        LoadVacantRooms(cmbRoomtype.Text.Trim)
        LoadNextDayVacantRooms()
       

    End Sub

    Private Sub cmbBedtype_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBedtype.EditValueChanged
        'LoadReservationRoomBedTypeCount()
    End Sub

    Private Sub cmbBedtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBedtype.SelectedIndexChanged
        LoadReservationRoomBedTypeCount()

        LoadVacantRooms(cmbRoomtype.Text.Trim)
        LoadNextDayVacantRooms()


    End Sub

    Private Sub cmbRoomtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRoomtype.SelectedIndexChanged
        LoadVacantRooms(cmbRoomtype.Text.Trim)
        LoadNextDayVacantRooms()
    End Sub

    Private Sub gvMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvMain.Click

        PubId = gvMain.GetRowCellValue(gvMain.FocusedRowHandle, "Id")
        PubResno = gvMain.GetRowCellValue(gvMain.FocusedRowHandle, "ResNo")

    End Sub

    Private Sub btView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btView.Click

        cmbReservation.Properties.DataSource = Nothing

        LoadReservertionsDetzByDate()

    End Sub

    Private Sub btReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReset.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "AssignRoom", "Add")

        If CheckAccess = True Then



            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Remove this Reservation From Room Assign", "Inactive Assign Rooms", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    ResetRooms()
                    LoadGridDetz(cmbReservation.GetColumnValue("ResNo"))

                End If



            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try




        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub
    Private Sub ResetRooms()


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("DeleteRoomByRoomAssign_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = PubResno

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Room Assign Inactivated Successfully", "Inactive Room Assign", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
End Class