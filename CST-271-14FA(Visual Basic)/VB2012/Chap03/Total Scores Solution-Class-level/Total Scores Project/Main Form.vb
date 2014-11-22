' Name:         Total Scores Project
' Purpose:      Displays the total of the scores entered by the user
' Programmer:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    ' class-level variable used
    ' to accumulate the scores

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
