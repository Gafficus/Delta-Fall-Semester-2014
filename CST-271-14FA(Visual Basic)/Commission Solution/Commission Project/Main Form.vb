' Name:         Commission Project
' Purpose:      Displays a commission
' Programmer:   Nathan Gaffney on 9-9-2014
'Chapter 8 Lessob B Exercise 2

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSales_TextChanged(sender As Object, e As EventArgs) Handles txtSales.TextChanged

        lblCommission.Text = String.Empty
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CommisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommisionToolStripMenuItem.Click
        Dim numSale As Double
        numSale = Convert.ToDouble(txtSales.Text)
        lblCommission.Text = "$" + CStr(Math.Round(numSale * 1.02, 2)) 'Places the commision into 
    End Sub

    Private Sub CommisionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CommisionToolStripMenuItem1.Click
        Dim numSale As Double
        numSale = Convert.ToDouble(txtSales.Text)
        lblCommission.Text = "$" + CStr(Math.Round(numSale * 1.05, 2))
    End Sub
End Class
