' Name:         Part Number Project
' Purpose:      Selects the appropriate delivery method from a list box
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with values

        lstDelivery.Items.Add("Mail - Standard")
        lstDelivery.Items.Add("Mail - Priority")
        lstDelivery.Items.Add("FedEx - Standard")
        lstDelivery.Items.Add("FedEx - Overnight")
        lstDelivery.Items.Add("UPS")
    End Sub

    Private Sub txtPartNum_Enter(sender As Object, e As EventArgs) Handles txtPartNum.Enter
        txtPartNum.SelectAll()
    End Sub

    Private Sub txtPartNum_TextChanged(sender As Object, e As EventArgs) Handles txtPartNum.TextChanged
        ' clears the list box selection

        lstDelivery.SelectedIndex = -1
    End Sub

End Class
