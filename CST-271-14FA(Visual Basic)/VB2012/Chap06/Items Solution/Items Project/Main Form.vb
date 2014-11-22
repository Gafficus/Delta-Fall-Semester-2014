' Name:         Items Project
' Purpose:      Demonstrates the Insert, Remove, Remove At, and Clear methods
'               and the Count property of the Items collection
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with values, then selects the first value

        lstNames.Items.Add("Jameston, Harry")
        lstNames.Items.Add("Neven, John")
        lstNames.Items.Add("Smith, Mary")
        lstNames.Items.Add("Woods, Janet")
        lstNames.Items.Add("Yardley, Pat")
        lstNames.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ' adds a name at a specified position in the list box


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' removes a specified name from the list box


    End Sub

    Private Sub btnRemoveAt_Click(sender As Object, e As EventArgs) Handles btnRemoveAt.Click
        ' removes a name from a specified position in the list box


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' removes all of the items from the list box


    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        ' displays the number of items in the list box


    End Sub
End Class
