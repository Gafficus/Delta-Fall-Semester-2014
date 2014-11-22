' Name:         Passing Project
' Purpose:      Demonstrates passing variables by value and by reference
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub GetName(ByVal strNameEntry As String)
        strNameEntry = InputBox("Enter your name:", "Name")
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strMyName As String = String.Empty

        Call GetName(strMyName)
        lblName.Text = strMyName
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
