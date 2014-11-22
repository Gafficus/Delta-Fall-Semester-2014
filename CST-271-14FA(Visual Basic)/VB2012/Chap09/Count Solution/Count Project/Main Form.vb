' Name:         Count Project
' Purpose:      Displays the number of times the numbers 1 through 9
'               appear in a two-dimensional array
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the number of times a value appears in a two-dimensional array

        Dim intNumbers(,) As Integer = {{1, 8},
                                        {4, 5},
                                        {7, 9},
                                        {3, 1},
                                        {9, 3},
                                        {5, 9},
                                        {8, 8},
                                        {9, 9},
                                        {7, 3},
                                        {2, 1},
                                        {5, 4}}

    End Sub

End Class
