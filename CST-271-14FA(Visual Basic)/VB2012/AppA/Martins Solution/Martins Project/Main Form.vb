' Name:         Martins Project
' Purpose:      Display the gain or loss on a stock
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGainLoss_Click(sender As Object, e As EventArgs) Handles btnGainLoss.Click
        ' calculates and displays the gain or loss on a stock

        Dim intShares As Integer
        Dim decOpenPrice As Decimal
        Dim decClosePrice As Decimal
        Dim decGainLoss As Decimal

        ' assign input to variables
        Integer.TryParse(txtShares.Text, intShares)
        Decimal.TryParse(txtOpening.Text, decClosePrice)
        Decimal.TryParse(txtClosing.Text, decClosePrice)

        ' calculate and display gain or loss
        decGainLoss = decClosePrice - decOpenPrice * intShares
        lblGainLoss.Text = decGainLoss.ToString("C2")

    End Sub
End Class
