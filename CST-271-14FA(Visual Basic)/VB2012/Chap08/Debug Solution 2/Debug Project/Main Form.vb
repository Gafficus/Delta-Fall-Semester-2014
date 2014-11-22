' Name:         Debug Project
' Purpose:      Displays the total due
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list box with prices

        For decPrice As Decimal = 5 To 10 Step 0.5D
            lstPrices.Items.Add(decPrice.ToString("C2"))
        Next decPrice
        lstPrices.SelectedIndex = 0
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the total due

        Dim intQuantity As Integer
        Dim decPrice As Decimal
        Dim decDue As Decimal

        Integer.TryParse(txtQuantity.Text, intQuantity)
        Decimal.TryParse(lstPrices.SelectedItem.ToString, decPrice)

        decDue = intQuantity * decPrice
        lblDue.Text = decDue.ToString("C2")
    End Sub

    Private Sub txtQuantity_Enter(sender As Object, e As EventArgs) Handles txtQuantity.Enter
        txtQuantity.SelectAll()
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        ' accepts only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged, lstPrices.SelectedIndexChanged
        lblDue.Text = String.Empty
    End Sub
End Class
