' Name:         Update Prices Project
' Purpose:      Updates each value stored in an array
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private dblPrices() As Double = {6, 12, 33.5, 10, 9.5, 25.5, 7, 8.35, 9.75, 3.5}

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOriginal_Click(sender As Object, e As EventArgs) Handles btnOriginal.Click
        ' returns array to the original values

        dblPrices(0) = 6
        dblPrices(1) = 12
        dblPrices(2) = 33.5
        dblPrices(3) = 10
        dblPrices(4) = 9.5
        dblPrices(5) = 25.5
        dblPrices(6) = 7
        dblPrices(7) = 8.35
        dblPrices(8) = 9.75
        dblPrices(9) = 3.5
        ' clears list box
        lstNew.Items.Clear()
    End Sub

    Private Sub btnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click
        ' updates each price and displays the updated prices in a list box


    End Sub

End Class
