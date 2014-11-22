' Name:         Bonus Project
' Purpose:      Calculates a salesperson's bonus 
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates a bonus amount

        Dim dblSales As Double
        Dim dblBonus As Double

        Double.TryParse(txtSales.Text, dblSales)

        If dblSales <= 0 Then
            dblBonus = 0
        ElseIf dblSales <= 5000 Then
            dblBonus = dblSales * 0.05
        Else
            dblBonus = dblSales * 0.1
        End If

        lblBonus.Text = dblBonus.ToString("C2")
        txtSales.Focus()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        lblBonus.Text = String.Empty
    End Sub
End Class
