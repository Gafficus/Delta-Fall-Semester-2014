' Name:         Hawkins Project
' Purpose:      Display the ending balance
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the ending balance based on the beginning
        ' balance, amount earned, and amount spent

        Dim decBegin As Decimal
        Dim decEarned As Decimal
        Dim decSpent As Decimal
        Dim decEnding As Decimal

        ' assign input to variables
        Decimal.TryParse(txtBegin.Text, decBegin)
        Decimal.TryParse(txtSpent.Text, decSpent)

        ' calculate and display ending balance
        decEnding = decBegin + decEarned - decSpent
        lblEnding = decEnding.ToString("C2")
    End Sub
End Class
