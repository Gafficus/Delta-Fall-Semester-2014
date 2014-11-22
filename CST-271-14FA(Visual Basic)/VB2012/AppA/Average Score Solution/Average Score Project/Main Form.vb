' Name:         Average Score Project
' Purpose:      Display the average score
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays the average of two test scores

        ' declare variables
        Dim dblScore1 As Double
        Dim dblScore2 As Double
        Dim dblAverage As Double

        ' assign input to variables
        Double.TryParse(txtScore1.Text, dblScore1)
        Double.TryParse(txtScore2.Text, dblScore2)

        ' calculate average score
        dblAverage = dblScore1 + dblScore2 / 2

        ' display average score
        lblAvg.Text = dblAverage
    End Sub

End Class
