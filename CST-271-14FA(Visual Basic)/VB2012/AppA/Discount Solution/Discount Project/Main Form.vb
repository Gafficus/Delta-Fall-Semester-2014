' Name:         Discount Project
' Purpose:      Display three discount amounts
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays a 10%, 20%, and
        ' 30% discount on an item's price

        ' declare variables
        Dim decPrice As Decimal
        Dim decDiscount10 As Decimal
        Dim decDiscount20 As Decimal
        Dim decDiscount30 As Decimal

        ' calculate discounts
        decDiscount10 = decPrice * 0.1D
        decDiscount20 = decPrice * 0.2D
        decDiscount30 = decPrice * 0.3D

        ' display discounts
        lbl10.Text = decDiscount10.ToString("N2")
        lbl20.Text = decDiscount20.ToString("N2")
        lbl30.Text = decDiscount30.ToString("N2")
    End Sub
End Class
