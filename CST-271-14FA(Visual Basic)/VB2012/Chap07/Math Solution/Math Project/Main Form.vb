' Name:         Math Project
' Purpose:      Displays the sum of and difference
'               between two numbers
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate the sum and difference

    End Sub

    Private Sub txtNum1_Enter(sender As Object, e As EventArgs) Handles txtNum1.Enter
        txtNum1.SelectAll()
    End Sub

    Private Sub txtNum2_Enter(sender As Object, e As EventArgs) Handles txtNum2.Enter
        txtNum2.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtNum1.KeyPress, txtNum2.KeyPress
        ' allow only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles txtNum1.TextChanged, txtNum2.TextChanged
        lblSum.Text = String.Empty
        lblDifference.Text = String.Empty
    End Sub
End Class
