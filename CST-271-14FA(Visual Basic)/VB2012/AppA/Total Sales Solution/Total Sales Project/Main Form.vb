' Name:         Total Sales Project
' Purpose:      Display the total sales
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays the total sales

        ' declare variables
        Dim intJack As Integer
        Dim intMary As Integer
        Dim intKhalid As Integer
        Dim intSharon As Integer
        Dim intTotal As Intger

        ' assign input to variables
        Integer.TryParse(txtJack.Text, intJack
        Integer.TryParse(txtMary.Text, intMary)
        Integer.TryParse(txtKhalid.Text, intKhalid)
        Integer.TryParse(txtSharon.Text, intSharon)

        ' calculate total sales
        inTotal = intJack + intMary + intKhalid + intSharon

        ' display total sales
        lblTotal.Text = intTotal.ToString("C0")
    End Sub
End Class
