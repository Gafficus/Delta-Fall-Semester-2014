' Name:         New Pay Project
' Purpose:      Display the new weekly pay
' Programmmer:  <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays the new weekly pay
        ' using a raise rate of 3%

        Const dblRATE As Double = 0.3
        Dim dblNewPay As Decimal
        Dim dblCurrentPay As Decimal

        Double.TryParse(txtCurrentPay.Text, dblCurrentPay)

        dblNewPay = dblCurrentPay + dblRATE * dblNewPay
        lblNewPay.Text = dblNewPay.ToString("C2")
    End Sub

End Class
