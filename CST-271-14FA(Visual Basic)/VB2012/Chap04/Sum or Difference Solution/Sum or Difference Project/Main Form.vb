' Name:         Sum or Difference Project
' Purpose:      Display the sum of two numbers or
'               the difference between both numbers
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtOperation.TextChanged, txtFirst.TextChanged, txtSecond.TextChanged
        ' clear lblAnswer

        lblAnswer.Text = String.Empty
    End Sub
End Class
