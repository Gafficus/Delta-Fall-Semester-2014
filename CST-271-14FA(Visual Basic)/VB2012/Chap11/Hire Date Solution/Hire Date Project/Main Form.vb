' Name:         Hire Date Project
' Purpose:      Displays a month number and day number, separated by a slash
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstMonth_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstMonth.SelectedValueChanged
        lblHireDate.Text = String.Empty
    End Sub

    Private Sub lstDay_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstDay.SelectedValueChanged
        lblHireDate.Text = String.Empty
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list boxes with values

        For intMonth As Integer = 1 To 12
            lstMonth.Items.Add(intMonth.ToString)
        Next intMonth

        For intDay As Integer = 1 To 31
            lstDay.Items.Add(intDay.ToString)
        Next intDay

        lstMonth.SelectedIndex = 0
        lstDay.SelectedIndex = 0
    End Sub

End Class
