' Name:         Kensington Project
' Purpose:      Displays a grade based on the number of points the user enters
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain


    Private Sub txtPossible_TextChanged(sender As Object, e As EventArgs) Handles txtPossible.TextChanged
        ' disable the Display Grade button until the user creates a new grading scale, then
        ' clear the grade

        btnDisplay.Enabled = False
        lblGrade.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays a student's grade

 

        txtEarned.Focus()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' fill arrays with values



        ' enable the Display Grade button 
        btnDisplay.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtEarned_Enter(sender As Object, e As EventArgs) Handles txtEarned.Enter
        txtEarned.SelectAll()
    End Sub

    Private Sub txtPossible_Enter(sender As Object, e As EventArgs) Handles txtPossible.Enter
        txtPossible.SelectAll()
    End Sub


    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtPossible.KeyPress, txtEarned.KeyPress
        ' accepts only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEarned_TextChanged(sender As Object, e As EventArgs) Handles txtEarned.TextChanged
        lblGrade.Text = String.Empty
    End Sub
End Class
