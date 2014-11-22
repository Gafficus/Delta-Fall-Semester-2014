' Name:         Conversion Functions Project
' Purpose:      Demonstrates the use of the Visual Basic conversion functions
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the total price

        Dim decPrice As Decimal
        Dim decTotalPrice As Decimal
        Dim intNumberOfItems As Integer

        ' convert input to numbers
        Decimal.TryParse(txtPrice.Text, decPrice)
        Integer.TryParse(txtPurchased.Text, intNumberOfItems)

        ' calculate and display the total price
        decTotalPrice = decPrice * Convert.ToDecimal(intNumberOfItems)
        lblTotalPrice.Text = Convert.ToString(decTotalPrice)

    End Sub
End Class
