' Name:         Item Prices Project
' Purpose:      Displays prices in combo boxes
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

        ' left-aligns the prices
        For dblPrice As Double = 9.45 To 11.45 Step 0.25
            cboLeft.Items.Add(dblPrice.ToString("N2"))
        Next dblPrice
        cboLeft.SelectedIndex = 0

        ' right-aligns the prices

    End Sub
End Class

