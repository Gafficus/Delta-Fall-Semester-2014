' Name:         Beachwood Project
' Purpose:      Display the total pounds of coffee
'               ordered and the total price of the order,
'               including sales tax and shipping
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays the total pounds of coffee ordered
        ' and the total price of the order, including sales tax and shipping

        ' declare constants and variables
        Const decPRICE_PER_POUND As Decimal = 11.15
        Const decSALES_TAX_RATE As Decimal = 0.02
        Const decSHIPPING_CHARGE As Decimal = 5.0

        Dim intRegular As Integer
        Dim intDecaf As Integer
        Dim intTotalPounds As Integer
        Dim decSubTotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalPrice As Decimal

        ' assign input to variables
        Integer.TryParse(txtRegular.Text, intRegular)
        Integer.TryParse(txtDecaf.Text, intDecaf

        ' perform calculations
        decSubTotal = intTotalPounds * decPRICE_PER_POUND
        decSalesTax = decSubTotal * decSALES_TAX_RATE
        decTotalPrice = decSubTotal + decSalesTax

        ' display shipping and calculated results
        lblPounds.Text = intTotalPounds
        lblTotalPrice.Text = decTotalPrice.ToString("C2")
    End Sub
End Class
