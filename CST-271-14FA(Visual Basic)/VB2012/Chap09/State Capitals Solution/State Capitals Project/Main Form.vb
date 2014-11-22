' Name:         State Capitals Project
' Purpose:      Display a capital name followed by a comma,
'               a space, and the state name
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private strStates() As String = {"Alabama", "Arizona", "California", "Georgia", "Tennessee"}
    Private strCapitals() As String = {"Montgomery", "Phoenix", "Sacramento", "Atlanta", "Nashville"}

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the contents of the arrays using this format: capital, state

         lstCapsAndStates.Items.Clear()
    End Sub
End Class
