' Name:         Debug Project
' Purpose:      Displays the area of a circle
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtRadius_Enter(sender As Object, e As EventArgs) Handles txtRadius.Enter
        txtRadius.SelectAll()
    End Sub

    Private Sub txtRadius_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRadius.KeyPress
        ' allows numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRadius_TextChanged(sender As Object, e As EventArgs) Handles txtRadius.TextChanged
        lblArea.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays the area of a circle

        Dim myCircle As Circle
        Dim dblRadius As Double
        Dim dblArea As Double

        Double.TryParse(txtRadius.Text, dblRadius)
        myCircle = New Circle(dblRadius)

        dblArea = myCircle.GetArea
        lblArea.Text = dblArea.ToString("N2")

        txtRadius.Focus()
    End Sub
End Class
