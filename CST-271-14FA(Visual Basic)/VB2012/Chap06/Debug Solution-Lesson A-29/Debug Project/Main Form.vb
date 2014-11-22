' Name:         Debug Project
' Purpose:      Displays the numbers 10 through 1
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the numbers 10, 9, 8, 7, 6, 5, 4, 3, 2, and 1

        For intNum As Integer = 10 To 1 Step 1
            lblNums.Text = lblNums.Text &
                intNum.ToString & ControlChars.NewLine
        Next intNum
    End Sub
End Class
