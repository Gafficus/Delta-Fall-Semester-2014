' Name:         Gross Pay Project
' Purpose:      Display an employee's gross pay
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtHours_Enter(sender As Object, e As EventArgs) Handles txtHours.Enter
        txtHours.SelectAll()
    End Sub

    Private Sub txtRate_Enter(sender As Object, e As EventArgs) Handles txtRate.Enter
        txtRate.SelectAll()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtHours.TextChanged, txtRate.TextChanged
        lblGross.Text = String.Empty
    End Sub
End Class
