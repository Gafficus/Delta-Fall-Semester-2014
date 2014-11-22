' Name:         ListBox Project
' Purpose:      Adds items to a list box
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        lstAnimal.Items.Add("Dog")
        lstAnimal.Items.Add("Cat")
        lstAnimal.Items.Add("Horse")

        For intCode As Integer = 100 To 105
            lstCode.Items.Add(intCode.ToString)
        Next intCode

        ' select default item in each list box
        lstAnimal.SelectedIndex = 0
        lstCode.SelectedIndex = 0
    End Sub
End Class
