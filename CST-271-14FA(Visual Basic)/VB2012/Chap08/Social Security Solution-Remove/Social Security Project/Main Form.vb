' Name:         Social Security Project
' Purpose:      Removes the dashes from a social security number
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As System.EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As System.EventArgs) Handles txtNumber.TextChanged
        lblNumber.Text = String.Empty
    End Sub

End Class

