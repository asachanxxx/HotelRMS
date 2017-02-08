Imports System
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Security.Cryptography
Public Class frmRegister

    Private key() As Byte = {}
    Private IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
    Private Const EncryptionKey As String = "abcdefgh"


    Private Sub frmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim getEncrypt As String = Encrypt(txtMain.Text.Trim)

        txtkey.Text = getEncrypt

    End Sub
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

    Private Function Left(ByVal EncryptionKey As String, ByVal p2 As Integer) As Char()
        Throw New NotImplementedException
    End Function

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim getDecrypt As String = Decrypt(txtkey.Text)

        txtKeyUni.Text = getDecrypt
    End Sub
End Class