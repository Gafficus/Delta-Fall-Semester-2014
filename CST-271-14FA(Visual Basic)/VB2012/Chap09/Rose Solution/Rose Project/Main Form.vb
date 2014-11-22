' Name:         Rose Project
' Purpose:      Displays the price of a ticket
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSection.SelectedIndexChanged
        lblPrice.Text = String.Empty
    End Sub

End Class
