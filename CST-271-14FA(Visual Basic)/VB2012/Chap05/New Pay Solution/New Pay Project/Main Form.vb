' Name:         New Pay Project
' Purpose:      Calculates an employee's new pay
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearNewPay(sender As Object, e As EventArgs) Handles txtOld.TextChanged, txtRate.TextChanged
        lblNew.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays the new pay

        Dim dblOld As Double
        Dim dblRate As Double
        Dim dblNew As Double

        ' convert the input to numbers
        Double.TryParse(txtOld.Text, dblOld)
        Double.TryParse(txtRate.Text, dblRate)

        ' calculate and display the new pay
        dblNew = dblOld + dblOld * dblRate
        lblNew.Text = dblNew.ToString("C2")

        ' set the focus
        txtOld.Focus()
    End Sub
End Class
