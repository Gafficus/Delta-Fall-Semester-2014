' Name:         Quantity Project
' Purpose:      Displays the results of adding 1 or
'               subtracting 1 from each array value
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' class-level array
    Private intQuantities() As Integer = {45, 67, 2, 5, 90}

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' adds 1 to each array value and then displays the array

        lstQuantities.Items.Clear()

    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        ' subtracts 1 from each array value and then displays the array

        lstQuantities.Items.Clear()

    End Sub
End Class
