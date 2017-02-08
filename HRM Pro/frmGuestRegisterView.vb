Imports System.Data.SqlClient
Public Class frmGuestRegisterView

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
    Private Sub frmGuestRegisterView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGuestSummary("")
    End Sub

    Private Sub txtSearchByPP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchByPP.EditValueChanged
        If rbByName.Checked Then
            LoadGuestSummary(String.Format(" where fullname like '{0}%'", txtSearchByPP.Text))
        Else
            LoadGuestSummary(String.Format(" where passportno like '{0}%'", txtSearchByPP.Text))
        End If
    End Sub

    Private Sub frmGuestRegisterView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class