' Name:         Game Show Project
' Purpose:      Write names to and read names 
'               from a sequential access file
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        ' writes a name to a sequential access file

        ' declare a StreamWriter variable

        ' open the file for append

        ' write the name on a separate line in the file

        ' close the file

        ' clear the list box and then set the focus
        lstContestants.Items.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ' reads names from a sequential access file 
        ' and displays them in the interface

        ' declare variables

        ' clear previous names from the list box
        lstContestants.Items.Clear()

        ' determine whether the file exists

    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub
End Class
