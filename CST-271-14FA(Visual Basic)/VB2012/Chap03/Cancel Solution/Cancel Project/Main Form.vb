' Name:         Cancel Project
' Purpose:      Demonstrates the use of a form's CancelButton property
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' class-level variable
    Private strNameEntry As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' saves the contents of the text box before clearing the contents

        strNameEntry = txtName.Text
        txtName.Text = String.Empty
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ' reinstates the name in the text box

        txtName.Text = strNameEntry
    End Sub
End Class
