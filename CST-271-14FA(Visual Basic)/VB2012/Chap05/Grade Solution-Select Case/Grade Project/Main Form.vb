' Name:         Grade Project
' Purpose:      Displays a message based on a letter grade
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtGrade_Enter(sender As Object, e As EventArgs) Handles txtGrade.Enter
        txtGrade.SelectAll()
    End Sub

    Private Sub txtGrade_TextChanged(sender As Object, e As EventArgs) Handles txtGrade.TextChanged
        lblMsg.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays a message corresponding to a grade


    End Sub
End Class
