' Name:         Jacobson Project
' Purpose:      Display a new password
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtOrigPassword_TextChanged(sender As Object, e As EventArgs) Handles txtOrigPassword.TextChanged
        lblNewPassword.Text = String.Empty
    End Sub

End Class
