' Name:         City Project
' Purpose:      Adds city names that start with L or Ch to a list box
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCity_Enter(sender As Object, e As EventArgs) Handles txtCity.Enter
        txtCity.SelectAll()
    End Sub

End Class
