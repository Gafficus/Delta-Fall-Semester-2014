' Name:         Kelley Project
' Purpose:      Display a bonus amount
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate a bonus amount

        Dim dblSales As Double
        Dim dblBonus As Double

        Double.TryParse(txtSales.Text, dblSales)

        dblBonus = dblSales * 0.1
        lblBonus.Text = dblBonus.ToString("C2")
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        lblBonus.Text = String.Empty
    End Sub
End Class
