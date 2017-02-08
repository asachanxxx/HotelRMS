Imports System.Net.Mail

Public Class frmMail

    Private Sub frmMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Try


           Dim mail As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("rashad.dheen@gmail.com")
            mail.[To].Add("rashad@infocraft.lk")
            mail.Subject = "Test Mail - 1"
            mail.Body = "mail with attachment"

            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment("Registration Form.pdf")
            mail.Attachments.Add(attachment)

            SmtpServer.Port = 587
            SmtpServer.Credentials = New System.Net.NetworkCredential("rashad.dheen@gmail.com", "Zanred@100")
            SmtpServer.EnableSsl = True

            SmtpServer.Send(mail)
            MessageBox.Show("mail Send")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub
End Class