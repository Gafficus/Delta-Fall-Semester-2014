' Name:         Date Project
' Purpose:      Changes the year number in a date from "yy" to "20yy"
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtDate_Enter(sender As Object, e As EventArgs) Handles txtDate.Enter
        txtDate.SelectAll()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ' changes a year number from "yy" to "20yy"


        txtDate.Focus()
    End Sub
End Class

