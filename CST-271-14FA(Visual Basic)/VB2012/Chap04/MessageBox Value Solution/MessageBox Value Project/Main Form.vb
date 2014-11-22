' Name:         MessageBox Value Project
' Purpose:      Displays a gross pay amount
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtHours_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHours.KeyPress
        ' accepts only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
        ' clears the gross pay

        lblGross.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates gross pay

        Const dblPAY_RATE As Double = 7.65
        Dim dblHours As Double
        Dim dblGross As Double

        ' convert hours worked to a number
        Double.TryParse(txtHours.Text, dblHours)

        ' calculate and display the gross pay
        dblGross = dblHours * dblPAY_RATE

        lblGross.Text = dblGross.ToString()

        ' set the focus
        txtHours.Focus()
    End Sub
End Class
