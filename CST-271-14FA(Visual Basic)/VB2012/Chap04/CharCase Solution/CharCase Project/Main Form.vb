' Name:         CharCase Project
' Purpose:      Displays a message indicating whether an ID is valid
'               or invalid
' Programmer:  <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        lblMsg.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strId As String

        strId = txtId.Text
        If strId = "AB12" OrElse strId = "XY59" OrElse strId = "TV45" Then
            lblMsg.Text = "Valid ID"
        Else
            lblMsg.Text = "Invalid ID"
        End If
    End Sub
End Class
