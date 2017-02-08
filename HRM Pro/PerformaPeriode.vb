Imports System.Data.SqlClient

Public Class PerformaPeriode

    Private Sub PerformaPeriode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub LoadGrid()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

    





        Try
            Conn.Open()


            dcSearch = New SqlCommand("select * from [Invoice.Performa.PeriodRates]  where  RoomId is null", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcBoat.DataSource = dsMain.Tables(0)



            Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1


            While DScount >= 0



                Dim resno As String = dsMain.Tables(0).Rows(DScount)(1)

                Dim room As String = dsMain.Tables(0).Rows(DScount)(7)

                Dim roomtype As String = dsMain.Tables(0).Rows(DScount)(8)


                Dim daMain2 As New SqlDataAdapter
                Dim dsMain2 As New DataSet
                Dim dcSearch2 As New SqlCommand


                dcSearch2 = New SqlCommand("select * from [Reservation.Room]  where ReservationNo=@Resno and Room=@Room and Roomtype=@RoomTyp", Conn)

                dcSearch2.Parameters.Add("@Resno", SqlDbType.VarChar).Value = resno
                dcSearch2.Parameters.Add("@Room", SqlDbType.VarChar).Value = room
                dcSearch2.Parameters.Add("@RoomTyp", SqlDbType.VarChar).Value = roomtype


                daMain2.SelectCommand = dcSearch2
                daMain2.Fill(dsMain2)




                If dsMain2.Tables(0).Rows.Count = 1 Then


                    Dim getRoomId As Integer = Convert.ToInt16(dsMain2.Tables(0).Rows(0)(0))
                    Dim getPax As Integer = Convert.ToInt16(dsMain2.Tables(0).Rows(0)(9))

                    Dim dcInsertNewAcc As New SqlCommand

                    dcInsertNewAcc = New SqlCommand("update [Invoice.Performa.PeriodRates] set RoomId=@Roomid , Pax = @Pax where Resno=@Resno and Room=@Room and RoomType=@RoomTyp", Conn)
                    dcInsertNewAcc.CommandType = CommandType.Text
                    dcInsertNewAcc.Parameters.Add("@Roomid", SqlDbType.Int).Value = getRoomId
                    dcInsertNewAcc.Parameters.Add("@Pax", SqlDbType.Int).Value = getPax
                    dcInsertNewAcc.Parameters.Add("@Resno", SqlDbType.VarChar).Value = resno

                    dcInsertNewAcc.Parameters.Add("@Room", SqlDbType.VarChar).Value = room
                    dcInsertNewAcc.Parameters.Add("@RoomTyp", SqlDbType.VarChar).Value = roomtype


                    'Conn.Open()
                    dcInsertNewAcc.ExecuteNonQuery()




                End If



                DScount = DScount - 1

            End While





        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

        Finally

            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()

        End Try

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        LoadGrid()

    End Sub
End Class