' Name:         Kettleson Project
' Purpose:      Display the annual bonus
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged
        ' clear annual bonus

        lblBonus.Text = String.Empty
    End Sub
End Class
