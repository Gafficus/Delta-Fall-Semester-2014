' Name:         Tax Calculator Project
' Purpose:      Displays the sales tax
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub lstRates_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstRates.SelectedValueChanged
        lblTax.Text = String.Empty
    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        lblTax.Text = String.Empty
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with tax rates

        For dblRate As Double = 0.02 To 0.1 Step 0.01
            lstRates.Items.Add(dblRate.ToString("P0"))
        Next dblRate
        lstRates.SelectedIndex = 0
    End Sub

End Class
