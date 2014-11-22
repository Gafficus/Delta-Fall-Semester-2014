' Name:         Optional Project
' Purpose:      Displays a bonus amount
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub CalcBonus(ByVal dblTotalSales As Double,
                          ByRef dblBonusAmount As Double,
                          ByVal dblBonusRate As Double)
        ' calculates the bonus amount

        dblBonusAmount = dblTotalSales * dblBonusRate
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates a bonus amount

        Dim strCode As String
        Dim strInputRate As String
        Dim dblSales As Double
        Dim dblBonus As Double
        Dim dblRate As Double

        strCode = txtCode.Text.ToUpper
        Double.TryParse(txtSales.Text, dblSales)

        ' if the salesperson's code is "A", get the bonus rate;
        ' otherwise, use the default bonus rate
        If strCode = "A" Then
            strInputRate = InputBox("Rate:", "Rate Entry")
            Double.TryParse(strInputRate, dblRate)
            ' calculate and display the bonus
            Call CalcBonus(dblSales, dblBonus, dblRate)
            lblBonus.Text = dblBonus.ToString("C2")
        Else
            ' calculate and display the bonus
            Call CalcBonus(dblSales, dblBonus)
            lblBonus.Text = dblBonus.ToString("C2")
        End If

        txtCode.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCode_Enter(sender As Object, e As EventArgs) Handles txtCode.Enter
        txtCode.SelectAll()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtCode.TextChanged, txtSales.TextChanged
        lblBonus.Text = String.Empty
    End Sub
End Class
