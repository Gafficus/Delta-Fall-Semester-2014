' Name:         Blane Project
' Purpose:      Display the total amount owed
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtRegistrants_Enter(sender As Object, e As EventArgs) Handles txtRegistrants.Enter
        txtRegistrants.SelectAll()
    End Sub

    Private Sub txtRegistrants_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRegistrants.KeyPress
        ' accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRegistrants_TextChanged(sender As Object, e As EventArgs) Handles txtRegistrants.TextChanged
        lblTotalOwed.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the total amount owed

        Dim intRegistrants As Integer
        Dim intTotalDue As Integer

        ' assign input to a variable
        Integer.TryParse(txtRegistrants.Text, intRegistrants)

        ' determine total owed


        ' display total owed
        lblTotalOwed.Text = intTotalDue.ToString("C0")

        txtRegistrants.Focus()
    End Sub
End Class
