' Name:         CD Project
' Purpose:      Adds and deletes list box entries
'               Reads information from a sequential access file
'               Writes information to a sequential access file
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' save the list box information

        ' declare a StreamWriter variable

        ' open the file for output

        ' write each line in the list box


        ' close the file

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with data 
        ' stored in a sequential access file

        ' declare variables

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' adds CD information to the list box

        ' declare variables

        ' get the CD information

        ' format the price, then concatenate the
        ' input items, using 40 spaces for the 
        ' CD name, 25 spaces for the artist name,
        ' and 5 spaces for the price

        ' add the information to the list box

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' removes the selected line from the list box

        ' if a line is selected, remove the line

    End Sub
End Class
