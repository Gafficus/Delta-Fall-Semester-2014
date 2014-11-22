' Name:         Jerrili Project
' Purpose:      Display the total owed
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles txtPrice.TextChanged, txtQuantity.TextChanged
        ' clear total owed

        lblTotal.Text = String.Empty
    End Sub
End Class
