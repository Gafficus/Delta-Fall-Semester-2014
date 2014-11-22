' Name:         Debug Project
' Purpose:      Displays the numbers 1 through 4
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the numbers 1, 2, 3, and 4

        Dim intNumber As Integer = 1
        Do While intNumber < 5
            lblNums.Text = lblNums.Text &
                intNumber.ToString & ControlChars.NewLine
        Loop
    End Sub
End Class
