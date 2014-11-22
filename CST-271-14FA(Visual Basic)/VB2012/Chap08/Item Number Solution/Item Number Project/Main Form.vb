' Name:         Item Number Project
' Purpose:      Verifies an item number's format
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtItemNum_Enter(sender As Object, e As EventArgs) Handles txtItemNum.Enter
        txtItemNum.SelectAll()
    End Sub

    Private Sub txtItemNum_TextChanged(sender As Object, e As EventArgs) Handles txtItemNum.TextChanged
        lblVerification.Text = String.Empty
    End Sub

End Class
