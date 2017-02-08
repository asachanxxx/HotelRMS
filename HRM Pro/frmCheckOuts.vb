Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCheckOuts

    Private Sub frmCheckInCheckOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtDateDep.Text = DateTime.Now.ToShortDateString


        gvDep.OptionsSelection.MultiSelect = True
        gvDep.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect

    End Sub

    Private Sub LoadReservationDepartureDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select Roomno,ReservationNo,GuestRegNo,DepDate, convert(char(5), DTime, 108) [DTime],DFlight,DepTo,FullName,Country  from GuestRegistration where DepDate=@DepDate order by DTime,roomno", Conn)
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
    Private Sub btnViewDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDep.Click

        LoadReservationDepartureDetails()

    End Sub

    Private Sub UpdateDepTime(ByVal Regno As String, ByVal depatime As DateTime)

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand


        Dim getRegno As String = Regno
        Dim getdepatime As DateTime = depatime

        dcInsertNewAcc = New SqlCommand("UpdateHotelDepTime_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@Regno", SqlDbType.VarChar).Value = getRegno
        dcInsertNewAcc.Parameters.Add("@Deptime", SqlDbType.DateTime).Value = getdepatime

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub

    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Checkout", "Add")

        If CheckAccess = True Then




            For i As Integer = 0 To gvDep.RowCount - 1


                'Dim s As String = gvArr.GetRowCellValue(i, "select")


                If (Not IsDBNull(gvDep.GetRowCellValue(i, "select"))) Then


                    'If gvArr.GetRowCellValue(i, "select") Then




                    Dim getRegno As String = gvDep.GetRowCellValue(i, "GuestRegNo")
                    Dim getDepTime As DateTime = TimeHDep.Time

                    UpdateDepTime(getRegno, getDepTime)

                    LoadReservationDepartureDetails()

                End If



            Next

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
End Class