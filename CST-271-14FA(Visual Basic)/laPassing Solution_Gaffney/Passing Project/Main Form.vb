' Name:         Passing Project
' Purpose:      Demonstrates passing variables by value and by reference
' Programmer:   NAthan Gaffney on 27-Aug-2014
'Chapter 7 LEsson A Exercise A

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub GetName(ByRef strNameEntry As String) 'Changed ByVal to ByRef because a string is not a value and cannot be passed as one.
        strNameEntry = InputBox("Enter your name:", "Name")
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strMyName As String = String.Empty

        Call GetName(strMyName)
        lblName.Text = strMyName 'This will now display the correct input because it is using the location of the strMyName variable.
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
