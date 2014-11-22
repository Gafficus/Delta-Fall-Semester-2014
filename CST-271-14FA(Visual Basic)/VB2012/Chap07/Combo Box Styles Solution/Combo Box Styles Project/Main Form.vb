' Name:         Combo Box Styles Project
' Purpose:      Demonstrates the three styles of combo boxes
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the combo boxes with values

        cboName.Items.Add("Amy")
        cboName.Items.Add("Beth")
        cboName.Items.Add("Carl")
        cboName.Items.Add("Dan")
        cboName.Items.Add("Jan")
        cboName.SelectedIndex = 0

        cboCity.Items.Add("London")
        cboCity.Items.Add("Madrid")
        cboCity.Items.Add("Paris")
        cboCity.SelectedItem = "Madrid"

        cboState.Items.Add("Alabama")
        cboState.Items.Add("Maine")
        cboState.Items.Add("New York")
        cboState.Items.Add("South Dakota")
        cboState.Text = "New York"
    End Sub
End Class
