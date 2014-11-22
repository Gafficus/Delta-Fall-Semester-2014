' Name:         Test Scores Project
' Purpose:      Displays the number of test scores
'               and the average test score
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private intScores() As Integer = {78, 90, 100, 76, 83, 85, 98, 45}

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAvg_Click(sender As Object, e As EventArgs) Handles btnAvg.Click
        ' display the number of test scores and the average test score



    End Sub
End Class
