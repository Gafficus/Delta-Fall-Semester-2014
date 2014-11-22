' Name:         Product Project
' Purpose:      Displays the product IDs entered by the user
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtId_Enter(sender As Object, e As EventArgs) Handles txtId.Enter
        txtId.SelectAll()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' adds a product ID to a list

        Dim strId As String

        ' remove any leading and trailing spaces

        ' verify length


        txtId.Focus()
    End Sub

End Class
