' Name:         Harrison Project
' Purpose:      Display the largest number stored in the 
'               first column of a two-dimensional array
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the largest number stored in the first column of the two-dimensional array

        Dim intQuantities(,) As Integer = {{356, 700}, {245, 67}, {56, 89}, {546, 678}, {100, 2}}
 
    End Sub
End Class
