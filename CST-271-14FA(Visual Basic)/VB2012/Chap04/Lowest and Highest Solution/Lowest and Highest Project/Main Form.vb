' Name:         Lowest and Highest Project
' Purpose:      Display the lowest and highest of two scores
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtScore1.TextChanged, txtScore2.TextChanged
        ' clear message

        lblMessage.Text = String.Empty
    End Sub
End Class
