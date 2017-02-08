Imports System.Xml
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class frmLogin

    Private key() As Byte = {}
    Private IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
    Private Const EncryptionKey As String = "abcdefgh"
    Dim PubSdate As DateTime
    Dim PubEdate As DateTime



    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()


        GetServerDate()

        'MsgBox(modMain.ReadSetting("DB_Datasource"))
        ' MsgBox(modMain.ConnString)


       



    End Sub
    Private Sub GetServerDate()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select GETDATE()as sysdate", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim SysDate As DateTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0).Item("sysdate"))


            dtDate.Text = SysDate



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub btLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogin.Click


        If CheckingLicense() = False Then

            MsgBox("Info RMS License Key Expired. Please Contact System Administrators To Activate", MsgBoxStyle.Critical, ErrTitle)


        Else

            Dim theDays As Integer = DateDiff(DateInterval.Day, dtDate.DateTime.Date, PubEdate)


            If theDays <= 30 Then



                lblerror.Text = "Info RMS License Key Will Be Expired With In " + theDays.ToString + " Days..."


            End If



            If FieldValidation() = False Then
                MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                Exit Sub

            Else

                Dim dscheckuser As New DataSet
                dscheckuser = DSCheckValidUser()


                If dscheckuser.Tables(0) Is DBNull.Value Or dscheckuser.Tables(0).Rows.Count = 0 Or dscheckuser.Tables(0).Rows.Count < 0 Then


                    MessageBox.Show("User Name/Password Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Else

                    Dim Username As String = dscheckuser.Tables(0).Rows(0).Item("Fullname")
                    Dim UserId As String = dscheckuser.Tables(0).Rows(0).Item("UserId")
                    CurrUser = dscheckuser.Tables(0).Rows(0).Item("Username")



                    frmMain.Show()

                    Me.Close()

                End If

                'If dscheckuser.Tables(0).Rows.Count > 0 Then

                '    Dim Username As String = dscheckuser.Tables(0).Rows(0).Item("Fullname")
                '    Dim UserId As String = dscheckuser.Tables(0).Rows(0).Item("UserId")
                '    CurrUser = dscheckuser.Tables(0).Rows(0).Item("Username")
                '    frmMain.Show()

                'Else

                '    MessageBox.Show("User Name/Password Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                'End If

            End If

        End If


    End Sub
    Function DSCheckValidUser() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select * from dbo.[Admin.UsersSys] where Username=@Username and Password=@Password", Conn)
            dcSearch.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUsername.Text.Trim
            dcSearch.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPass.Text.Trim



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            'If count > 0 Then
            DSCheckValidUser = dsMain



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
    Function DSGetKey() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select * from dbo.[Admin.Keys]", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            'If count > 0 Then
            DSGetKey = dsMain



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
    Function CheckingLicense() As Boolean

        Try

            Dim getkeys As String = CheckValidity()



            PubSdate = Convert.ToDateTime(getkeys.Substring(0, 9).ToString)
            PubEdate = Convert.ToDateTime(getkeys.Substring(11, 9).ToString)


            ' dtDate.Text = "2014-4-09"



            If dtDate.DateTime.Date <= PubEdate And dtDate.DateTime.Date >= PubSdate Then

                Return True

            Else

                Return False


            End If

        Catch ex As Exception

            Return False

        End Try


    End Function
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtUsername.Text, "", False) = 0 Or String.Compare(txtPass.Text, "", False) = 0, 0, 1)

    End Function
    Public Function CheckValidity() As String
        Try


            Dim DSCheckGetkey As DataSet = DSGetKey()

            Dim CurKey As String = DSCheckGetkey.Tables(0).Rows(0)(1).ToString



            Dim getDecrypt As String = Decrypt(CurKey)


            Dim getLastDate As String = getDecrypt.Substring(1, 1) + getDecrypt.Substring(16, 1)

            Dim Sdate As String = "20" + getDecrypt.Substring(8, 1) + getDecrypt.Substring(3, 1) + "-" + getDecrypt.Substring(5, 1) + "-" + "01"

            Dim Edate As String = "20" + getDecrypt.Substring(13, 1) + getDecrypt.Substring(18, 1) + "-" + getDecrypt.Substring(10, 1) + "-" + getLastDate.ToString


            ' Dim Edate As String = "20" + getDecrypt.Substring(13, 1) + getDecrypt.Substring(18, 1) + "-" + getDecrypt.Substring(10, 1) + "-" + "31"






            Return Sdate + "::" + Edate





        Catch ex As Exception

            MsgBox("Info RMS License Key is Invalid", MsgBoxStyle.Critical, ErrTitle)

        End Try
    End Function
    Public Function Encrypt(ByVal stringToEncrypt As String) As String
        Try
            key = System.Text.Encoding.UTF8.GetBytes(EncryptionKey)
            Dim des As New DESCryptoServiceProvider
            Dim inputByteArray() As Byte = Encoding.UTF8.GetBytes(stringToEncrypt)
            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Return Convert.ToBase64String(ms.ToArray())
        Catch ex As Exception
            'oops - add your exception logic
        End Try
    End Function
    Public Function Decrypt(ByVal stringToDecrypt As String) As String
        Try
            Dim inputByteArray(stringToDecrypt.Length) As Byte
            key = System.Text.Encoding.UTF8.GetBytes(EncryptionKey)
            Dim des As New DESCryptoServiceProvider
            inputByteArray = Convert.FromBase64String(stringToDecrypt)
            Dim ms As New MemoryStream
            Dim cs As New CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8
            Return encoding.GetString(ms.ToArray())
        Catch ex As Exception
            'oops - add your exception logic
        End Try
    End Function

    Private Sub txtUsername_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtUsername.Text <> "" Then
                txtPass.Focus()
            End If
        End If
    End Sub

    Private Sub txtPass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPass.Text <> "" Then
                btLogin.Focus()
            End If
        End If
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub frmLogin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Me.Close()
    End Sub
End Class