' Name:         Reverse Letters Project
' Purpose:      Reverses the letters in a word
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtWord_Enter(sender As Object, e As EventArgs) Handles txtWord.Enter
        txtWord.SelectAll()
    End Sub

    Private Sub txtWord_TextChanged(sender As Object, e As EventArgs) Handles txtWord.TextChanged
        lblReverse.Text = String.Empty
    End Sub

End Class
