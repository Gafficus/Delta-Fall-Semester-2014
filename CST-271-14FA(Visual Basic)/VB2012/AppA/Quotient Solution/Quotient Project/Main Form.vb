' Name:         Quotient Project
' Purpose:      Divide two numbers and display the quotient
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' display the result of dividing two numbers

        Dim decNumerator As Decimal
        Dim decDenominator As Decimal
        Dim decQuotient As Decimal

        Decimal.TryParse(txtNumerator.Text, decNumerator)
        Decimal.TryParse(txtDenominator.Text, decDenominator)

        decQuotient = decNumerator / decDenominator

        lblQuotient.Text = decQuotient.ToString("N2")
    End Sub
End Class
