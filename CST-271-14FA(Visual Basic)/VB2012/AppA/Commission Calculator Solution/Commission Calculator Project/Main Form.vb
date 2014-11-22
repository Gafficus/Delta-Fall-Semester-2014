' Name:         Commission Calculator Project
' Purpose:      Display the quarterly commission
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' calculates and displays the quarterly commission

        ' declare named constant
        Const decRATE As Decimal = 0.1

        ' declare variables
        Dim decSales1 As Decimal
        Dim decSales2 As Decimal
        Dim decSales3 As Decimal
        Dim decCommission As Decimal

        ' assign input to variables
        Decimal.TryParse(txtSales1, decSales1)
        Decimal.TryParse(txtSales2, decSales2)
        Decimal.TryParse(txtSales3, decSales3)

        ' calculate and display commission
        decCommission = decSales1 + decSales2 + decSales3 * decRATE
        lblCommission.Text = decCommission.ToString("C2")
    End Sub

End Class
