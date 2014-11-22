' Name:         Hours Worked Project
' Purpose:      Display the total hours worked
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays the total number
        ' of hours worked during 4 weeks

        ' declare variables
        Dim dblWeek1 As Double
        Dim dblWeek2 As Double
        Dim dblWeek3 As Double
        Dim dblWeek4 As Double
        Dim dblTotal As Double

        ' assign input to variables
        Double.TryParse(txtWeek1.Text, dblWeek1)
        Double.TryParse(txtWeek2.Text, dblWeek2)
        Double.TryParse(txtWeek3.Text, dblWeek2)
        Double.TryParse(txtWeek4.Text, dblWeek4)

        ' calculate total hours worked
        dblTotal = dblWeek1 + dblWeek2 + dblWeek3 + dblWeek4

        ' display total hours worked
        lblTotal.Text = dblTotal.ToString("N1")
    End Sub
End Class
