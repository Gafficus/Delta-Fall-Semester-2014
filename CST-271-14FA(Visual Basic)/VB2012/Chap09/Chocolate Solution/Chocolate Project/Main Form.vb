' Name:         Chocolate Project
' Purpose:      Display the contents of an array
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' declare class-level array


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' display the array's contents

        lstPounds.Items.Clear()

    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click
        ' display the array's contents

        lstPounds.Items.Clear()

    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' display the array's contents

        lstPounds.Items.Clear()

    End Sub

    Private Sub btnAscending_Click(sender As Object, e As EventArgs) Handles btnAscending.Click
        ' sort the array values in ascending order

        lstPounds.Items.Clear()

    End Sub

    Private Sub btnDescending_Click(sender As Object, e As EventArgs) Handles btnDescending.Click
        ' sort the array values in descending order
        lstPounds.Items.Clear()

    End Sub
End Class
