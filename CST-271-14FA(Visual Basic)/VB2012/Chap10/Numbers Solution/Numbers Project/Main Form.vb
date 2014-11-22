' Name:         Numbers Project
' Purpose:      Displays numbers and updates the numbers by 1; the numbers
'               are stored in a sequential access file
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the contents of the numbers.txt file


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' stores the contents of the numbers.txt file in an array
        ' increases by 1 each number stored in the array
        ' writes the array contents to the file


    End Sub
End Class
