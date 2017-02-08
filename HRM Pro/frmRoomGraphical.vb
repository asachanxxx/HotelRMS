Imports System.Data.SqlClient
Public Class frmRoomGraphical

    Private panelList As New List(Of Panel)

    Public daMain As New SqlDataAdapter
    Public dsMain As New DataSet
    Public DScount As Integer
    Private Sub frmRoomGraphical_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Conn As New SqlConnection(ConnString)
        'Dim daMain As New SqlDataAdapter
        'Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT   TOP (100) PERCENT dbo.[Rooms.Master].Roomno, dbo.[Rooms.Master].Category, dbo.[Rooms.Master].Status, dbo.[Room.CurrentStatus].BillingGuest,dbo.[Room.CurrentStatus].ReservationNo FROM dbo.[Room.CurrentStatus] RIGHT OUTER JOIN dbo.[Rooms.Master] ON dbo.[Room.CurrentStatus].RoomNo = dbo.[Rooms.Master].Roomno where dbo.[Rooms.Master].IsInactive=0 ORDER BY dbo.[Rooms.Master].Roomno", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            DScount = dsMain.Tables(0).Rows.Count - 1




            displayrow1()

            displayrow2()

            displayrow3()

            displayrow4()

            displayrow5()
            displayrow6()
            displayrow7()

            displayrow8()

            displayrow9()
            displayrow10()
            displayrow11()
            displayrow12()
            displayrow13()
            displayrow14()
            displayrow15()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub displayrow1()

        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)



            If (i = 1) Then
                newPanel.Location = New Point(10, 10)
                newPanel.BackColor = SystemColors.ButtonHighlight
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 10)
            End If





            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill

            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite



            If (i = 2) Then
                newLabel.BorderStyle = BorderStyle.Fixed3D
                newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                newLabel.Text = "OCCUPIED"

            End If


            If (i = 3) Then
                newLabel.BorderStyle = BorderStyle.Fixed3D
                newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                newLabel.Text = "VACANT"

            End If


            If (i = 4) Then
                newLabel.BorderStyle = BorderStyle.Fixed3D
                newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                newLabel.Text = "DIRTY"

            End If


            If (i = 5) Then
                newLabel.BorderStyle = BorderStyle.Fixed3D
                newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                newLabel.Text = "OUT OF SERVICE"

            End If


            If (i = 6) Then
                newPanel.BackColor = SystemColors.ControlLightLight


            End If

            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite
            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next

    End Sub
    Private Sub displayrow2()


        For i = 1 To 6

            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Green


            If (i = 1) Then
                newPanel.Location = New Point(10, 70)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 70)
            End If

            Dim newLabel As New Label

            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill



            If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then



                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(i - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(i - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(i - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(i - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(i - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(i - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(i - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(i - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(i - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next

    End Sub
    Private Sub displayrow3()



        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.DarkMagenta



            If (i = 1) Then
                newPanel.Location = New Point(10, 120)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 120)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill


            Dim Getrow As Integer = i + 6


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 7) Or (Getrow = 8) Or (Getrow = 9) Or (Getrow = 10) Or (Getrow = 11) Or (Getrow = 12) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next

    End Sub
    Private Sub displayrow4()
        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Black


            If (i = 1) Then
                newPanel.Location = New Point(10, 170)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 170)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill


            Dim Getrow As Integer = i + 12


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 13) Or (Getrow = 14) Or (Getrow = 15) Or (Getrow = 16) Or (Getrow = 17) Or (Getrow = 18) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next
    End Sub
    Private Sub displayrow5()
        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Black


            If (i = 1) Then
                newPanel.Location = New Point(10, 220)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 220)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill

            Dim Getrow As Integer = i + 18


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 19) Or (Getrow = 20) Or (Getrow = 21) Or (Getrow = 22) Or (Getrow = 23) Or (Getrow = 24) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next

    End Sub
    Private Sub displayrow6()
        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Green


            If (i = 1) Then
                newPanel.Location = New Point(10, 270)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 270)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill

            Dim Getrow As Integer = i + 24


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 25) Or (Getrow = 26) Or (Getrow = 27) Or (Getrow = 28) Or (Getrow = 29) Or (Getrow = 30) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next

    End Sub
    Private Sub displayrow7()
        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Brown


            If (i = 1) Then
                newPanel.Location = New Point(10, 320)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 320)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill

            Dim Getrow As Integer = i + 30


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 31) Or (Getrow = 32) Or (Getrow = 33) Or (Getrow = 34) Or (Getrow = 35) Or (Getrow = 36) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next
    End Sub
    Private Sub displayrow8()
        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Brown


            If (i = 1) Then
                newPanel.Location = New Point(10, 370)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 370)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill

            Dim Getrow As Integer = i + 36


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 37) Or (Getrow = 38) Or (Getrow = 39) Or (Getrow = 40) Or (Getrow = 41) Or (Getrow = 42) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next

    End Sub
    Private Sub displayrow9()
        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Bisque


            If (i = 1) Then
                newPanel.Location = New Point(10, 420)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 420)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill

            Dim Getrow As Integer = i + 42


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 43) Or (Getrow = 44) Or (Getrow = 45) Or (Getrow = 46) Or (Getrow = 47) Or (Getrow = 48) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next

    End Sub
    Private Sub displayrow10()
        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Bisque


            If (i = 1) Then
                newPanel.Location = New Point(10, 470)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 470)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill

            Dim Getrow As Integer = i + 48


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 49) Or (Getrow = 50) Or (Getrow = 51) Or (Getrow = 52) Or (Getrow = 53) Or (Getrow = 54) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next

    End Sub
    Private Sub displayrow11()
        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Maroon


            If (i = 1) Then
                newPanel.Location = New Point(10, 520)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 520)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill

            Dim Getrow As Integer = i + 54


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 55) Or (Getrow = 56) Or (Getrow = 57) Or (Getrow = 58) Or (Getrow = 59) Or (Getrow = 60) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next


    End Sub
    Private Sub displayrow12()
        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Maroon


            If (i = 1) Then
                newPanel.Location = New Point(10, 570)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 570)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill

            Dim Getrow As Integer = i + 60


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 61) Or (Getrow = 62) Or (Getrow = 63) Or (Getrow = 64) Or (Getrow = 65) Or (Getrow = 66) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next


    End Sub
    Private Sub displayrow13()
        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Maroon


            If (i = 1) Then
                newPanel.Location = New Point(10, 620)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 620)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill

            Dim Getrow As Integer = i + 66


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 67) Or (Getrow = 68) Or (Getrow = 69) Or (Getrow = 70) Or (Getrow = 71) Or (Getrow = 72) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next


    End Sub
    Private Sub displayrow14()
        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Maroon


            If (i = 1) Then
                newPanel.Location = New Point(10, 670)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 670)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill

            Dim Getrow As Integer = i + 72


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 73) Or (Getrow = 74) Or (Getrow = 75) Or (Getrow = 76) Or (Getrow = 77) Or (Getrow = 78) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next


    End Sub
    Private Sub displayrow15()
        For i = 1 To 6
            Dim newPanel As New Panel
            newPanel.Name = "MyPanel" & i
            newPanel.Size = New Size(220, 50)
            newPanel.BackColor = Color.Maroon


            If (i = 1) Then
                newPanel.Location = New Point(10, 720)
            Else
                newPanel.Location = New Point(10 * i + ((i - 1) * newPanel.Width), 720)
            End If

            Dim newLabel As New Label
            newLabel.Name = "MyLabel" & i
            newLabel.Dock = DockStyle.Fill

            Dim Getrow As Integer = i + 78


            '  If (i = 1) Or (i = 2) Or (i = 3) Or (i = 4) Or (i = 5) Or (i = 6) Then

            If (Getrow = 79) Or (Getrow = 80) Or (Getrow = 81) Or (Getrow = 82) Or (Getrow = 83) Or (Getrow = 84) Then


                newLabel.BorderStyle = BorderStyle.Fixed3D


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "vacant" Then
                    newPanel.BackColor = Color.FromArgb(&H0, &H0, &H99)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "occupied" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString() + "  ::  " + dsMain.Tables(0).Rows(Getrow - 1)(3).ToString()
                End If


                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "dirty" Then

                    newPanel.BackColor = Color.FromArgb(&H99, &H0, &H66)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()
                End If

                If dsMain.Tables(0).Rows(Getrow - 1)(2).ToString() = "out of service" Then
                    newPanel.BackColor = Color.FromArgb(&H99, &H66, &H0)
                    newLabel.Text = dsMain.Tables(0).Rows(Getrow - 1)(0).ToString()

                End If



            End If


            newLabel.TextAlign = ContentAlignment.MiddleCenter
            newLabel.ForeColor = Color.FloralWhite

            newLabel.BorderStyle = BorderStyle.Fixed3D

            newPanel.Controls.Add(newLabel)

            Me.Controls.Add(newPanel)


            ' save panel in generic list
            panelList.Add(newPanel)
        Next


    End Sub


    Private Sub SimpleButton58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class