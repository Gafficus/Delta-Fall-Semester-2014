' Name:         Trim Method Project
' Purpose:      Remove leading/trailing dollar signs, spaces, or percent signs
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnTrim_Click(sender As Object, e As EventArgs) Handles btnTrim.Click
        ' removes any leading or trailing
        ' dollar signs, spaces, or percent signs


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        lblInput.Text = String.Empty
    End Sub
End Class
