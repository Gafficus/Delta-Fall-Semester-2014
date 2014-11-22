' Name:         Turner Project
' Purpose:      Calculates a 2% sales tax
' Programmer:   <your name> on <current date>

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for next sales tax calculation

        txtSale.Text = String.Empty
        lblTax.Text = String.Empty
        txtSale.Focus()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate 2% sales tax

        lblTax.Text = Val(txtSale) * 2
        lblTax.Text = Format(lblTax.Text, Currency)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' print the interface

        Me.Height = Me.Height - 75
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        Me.Height = Me.Height + 75

    End Sub
End Class
