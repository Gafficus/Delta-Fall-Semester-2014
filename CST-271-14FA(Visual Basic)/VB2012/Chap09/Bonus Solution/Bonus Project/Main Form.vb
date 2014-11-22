' Name:         Bonus Project
' Purpose:      Displays the sum of 3 array elements
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays the sum of three array elements

        Dim intNums(,) As Integer = {{4, 6, 7, 9},
                                     {8, 90, 8, 20},
                                     {25, 67, 10, 20}}


    End Sub
End Class
