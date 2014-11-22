' Name:         State ID Project
' Purpose:      Displays the state ID in uppercase
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' displays the ID in uppercase

        lblUppercase.Text = txtState.Text.ToUpper
        txtState.Focus()
    End Sub

    Private Sub txtState_TextChanged(sender As Object, e As EventArgs) Handles txtState.TextChanged
        lblUppercase.Text = String.Empty
    End Sub

End Class
