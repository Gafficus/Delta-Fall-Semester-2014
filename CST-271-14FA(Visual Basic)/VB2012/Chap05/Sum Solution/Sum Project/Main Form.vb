' Name:         Sum Project
' Purpose:      Display the sum of two numbers
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtNum1_Enter(sender As Object, e As EventArgs) Handles txtNum1.Enter
        txtNum1.SelectAll()
    End Sub

    Private Sub txtNum2_Enter(sender As Object, e As EventArgs) Handles txtNum2.Enter
        txtNum2.SelectAll()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtNum1.TextChanged, txtNum2.TextChanged
        lblSum.Text = String.Empty
    End Sub

End Class
