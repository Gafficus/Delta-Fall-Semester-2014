' Name:         Rearrange Name Project
' Purpose:      Change a name from first, space, and last 
'               to last, comma, space, and first
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRearrange_Click(sender As Object, e As EventArgs) Handles btnRearrange.Click
        ' rearranges and then displays a name

        Dim strName As String
        Dim strFirstName As String
        Dim strLastName As String
        Dim intIndex As Integer

        ' assign the input to a variable
        strName = txtName.Text.Trim

        ' search for the space in the name

        ' if the input contains a space
        If  Then
            ' separate the first and last names

            ' display last name, comma, space, and first name

        Else    ' the name does not contain a space
            MessageBox.Show("Invalid name format",
                            "Rearrange Name",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub
End Class
