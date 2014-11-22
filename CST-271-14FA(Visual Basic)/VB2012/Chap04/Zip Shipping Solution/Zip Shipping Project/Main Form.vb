' Name:         Zip Shipping Project
' Purpose:      Displays a shipping charge that is based on a ZIP code
' Programmer:	<your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtZip_Enter(sender As Object, e As EventArgs) Handles txtZip.Enter
        txtZip.SelectAll()
    End Sub

    Private Sub txtZip_TextChanged(sender As Object, e As EventArgs) Handles txtZip.TextChanged
        lblShipping.Text = String.Empty
    End Sub
End Class
