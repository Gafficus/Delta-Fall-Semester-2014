' Name:         Westin Project
' Purpose:      Displays the contents of an array in list boxes
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private strParts(,) As String = {{"A123", "10"},
                                     {"B456", "36"},
                                     {"X467", "101"},
                                     {"R122", "2"},
                                     {"Z894", "75"},
                                     {"A356", "97"}}

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
