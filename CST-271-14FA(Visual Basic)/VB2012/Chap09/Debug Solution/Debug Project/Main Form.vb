' Name:         Debug Project
' Purpose:      Displays the contents of an array in two list boxes
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the first and last names in list boxes

        Dim strNames() As String = {{"Mary", "Jones"},
                                     {"Susan", "Washington"},
                                     {"Carol", "O'Brien"},
                                     {"Jacob", "Harper"},
                                     {"Sue", "Chen"}}

        ' clear list boxes, then display names
        lstFirst.Items.Clear()
        lstLast.Items.Clear()
        For intRow As Integer = 1 To strNames.GetUpperBound(1)
            lstFirst.Items.Add(strNames(intRow, 0))
            lstLast.Items.Add(strNames(intRow, 1))
        Next intRow
    End Sub
End Class
