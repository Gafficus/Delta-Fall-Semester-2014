' Name:         Mount Rushmore Project
' Purpose:      Display an appropriate message
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        ' clear message

        lblMsg.Text = String.Empty
    End Sub
End Class
