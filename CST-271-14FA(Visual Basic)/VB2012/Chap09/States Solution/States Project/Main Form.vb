' Name:         States Project
' Purpose:      Displays the selected list box item
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with array values and
        ' then selects the first item


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstMonths_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstStates.SelectedValueChanged
        ' displays the selected item in a label control

        lblSelectedItem.Text = lstStates.SelectedItem.ToString
    End Sub
End Class
