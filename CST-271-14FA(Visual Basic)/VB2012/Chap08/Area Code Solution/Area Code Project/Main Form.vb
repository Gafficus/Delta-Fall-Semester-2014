' Name:         Area Code Project
' Purpose:      Changes the area code in a phone number to 800
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtOriginal_Enter(sender As Object, e As EventArgs) Handles txtOriginal.Enter
        txtOriginal.SelectAll()
    End Sub

    Private Sub txtOriginal_TextChanged(sender As Object, e As EventArgs) Handles txtOriginal.TextChanged
        lblNew.Text = String.Empty
    End Sub

End Class
