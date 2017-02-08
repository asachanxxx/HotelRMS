Imports System.Data.SqlClient
Public Class frmDBbackup


    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader

    Private Sub frmDBbackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


       




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click




        Dim bt As DialogResult = MessageBox.Show("Do You Want To Take the DB Backup", "DB Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If bt = Windows.Forms.DialogResult.Yes Then

            Try


                Dim sqlConn As New SqlConnection(ConnString)

                sqlConn.Open()



                Dim passyear As String = DateTime.Now.Year
                Dim passmonth As String = DateTime.Now.Month
                Dim passday As String = DateTime.Now.Day
                Dim passHour As String = DateTime.Now.Hour
                Dim passmin As String = DateTime.Now.Minute
                Dim passsec As String = DateTime.Now.Second


                Dim BackupTime As String = passyear + "" + passmonth + "" + passday + " " + passHour + "" + passmin + "" + passsec

                Dim GetDBName As String = RMSDBNAME

                Dim GetPath As String = DBBACKUPPATH

                Dim GetFilename As String = GetDBName + "_" + "Backup" + "_" + BackupTime + CurrUser + ".bak'"


                ' Dim GetFilename As String = GetDBName + "_" + "Backup2.bak'"


                Dim passcommand = "BACKUP DATABASE" + " " + GetDBName + " " + GetPath + GetFilename


                'Dim sCommand = "BACKUP DATABASE [RMSJUN] TO DISK = N'D:\DBBACKING\Backup.bak' WITH COPY_ONLY"

                Dim sCommand = passcommand

                Using sqlCmd As New SqlCommand(sCommand, sqlConn)
                    sqlCmd.ExecuteNonQuery()
                    MessageBox.Show("DB Backup done Successfully", "DB Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            End Try


        End If


    End Sub
End Class