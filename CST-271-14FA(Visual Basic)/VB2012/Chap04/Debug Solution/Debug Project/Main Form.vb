' Name:         Debug Project
' Purpose:      Displays a commission amount 
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCode_Enter(sender As Object, e As EventArgs) Handles txtCode.Enter
        txtCode.SelectAll()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress, txtSales.KeyPress
        ' allows only numbers, the period, and the Backspace key

        If e.KeyChar < "0" OrElse e.KeyChar > "9" AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates a commission amount

        Const strMESSAGE As String = "Your commission is "
        Dim strCode As String
        Dim dblSales As Double
        Dim dblComm As Double

        strCode = txtCode.Text

        ' convert sales amount to a number
        Double.TryParse(txtSales.Text, dblSales)

        ' calculate commission
        If strCode = "1" OrElse strCode = "2" OrElse
            strCode = "3" AndAlso dblSales > 5000 Then
            dblComm = dblSales * 0.05
        Else
            dblComm = dblSales * 0.03
        End If

        MessageBox.Show(strMESSAGE & dblComm.ToString("C2"),
                        "Commission Calculator",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' set the focus
        txtCode.Focus()
    End Sub

End Class
