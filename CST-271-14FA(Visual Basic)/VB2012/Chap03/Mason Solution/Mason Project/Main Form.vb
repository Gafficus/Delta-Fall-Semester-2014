' Name:         Mason Project
' Purpose:      Displays the projected sales for each of 3 regions
' Programmer:   <your name> on <current date>

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear screen

        txtReg1Sales.Text = String.Empty
        txtReg2Sales.Text = String.Empty
        txtReg3Sales.Text = String.Empty
        txtReg1IncPer.Text = String.Empty
        txtReg2IncPer.Text = String.Empty
        txtReg3IncPer.Text = String.Empty
        lblReg1ProjSales.Text = String.Empty
        lblReg2ProjSales.Text = String.Empty
        lblReg3ProjSales.Text = String.Empty
    End Sub
End Class
