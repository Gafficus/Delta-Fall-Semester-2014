' Name:         Sales Tax Project
' Purpose:      Displays a sales tax amount
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates a sales tax amount

        Dim decSales As Decimal
        Dim decRate As Decimal
        Dim decTax As Decimal

        ' remove any leading or trailing spaces from the text box
        txtRate.Text = txtRate.Text.Trim

        ' if necessary, remove the percent sign from the text box


        Decimal.TryParse(txtSales.Text, decSales)
        Decimal.TryParse(txtRate.Text, decRate)

        If decRate > 1 Then
            decRate = decRate / 100
        End If

        decTax = decSales * decRate
        lblTax.Text = decTax.ToString("C2")

        txtSales.Focus()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub txtRate_Enter(sender As Object, e As EventArgs) Handles txtRate.Enter
        txtRate.SelectAll()
    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        lblTax.Text = String.Empty
    End Sub

    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged
        lblTax.Text = String.Empty
    End Sub
End Class

