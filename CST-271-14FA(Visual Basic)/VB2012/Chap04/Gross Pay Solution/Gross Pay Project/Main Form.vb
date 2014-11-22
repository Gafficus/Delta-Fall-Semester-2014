' Name:         Gross Pay Project
' Purpose:      Display the gross pay
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
        ' clear gross pay

        lblGross.Text = String.Empty
    End Sub
End Class
