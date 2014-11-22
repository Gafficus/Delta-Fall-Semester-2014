' Name:         Part Number Project
' Purpose:      Selects the appropriate delivery method from a list box
' Programmer:   Nathan Gaffney on 9-9-2014
'Chapter 8 Lesson C Exercise 6

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

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        Dim partId As String
        partId = txtPartNum.Text
        If partId Like "[0-9][0-9][Mm][Ss]" Then
            lstDelivery.SelectedIndex = 0
        ElseIf partId Like "[0-9][0-9][Mm][Pp]" Then
            lstDelivery.SelectedIndex = 1
        ElseIf partId Like "[0-9][0-9][Ff][Ss]" Then
            lstDelivery.SelectedIndex = 2
        ElseIf partId Like "[0-9][0-9][Ff][Oo]" Then
            lstDelivery.SelectedIndex = 3
        ElseIf partId Like "[0-9][0-9][Uu]" Then
            lstDelivery.SelectedIndex = 4
        Else
            MessageBox.Show("The Part Number " + partId + " is invalid.")
        End If
    End Sub
End Class
