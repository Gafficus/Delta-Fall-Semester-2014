' Name:         Debug Project
' Purpose:      Displays a commission amount
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub GetCommission(ByVal dblRate As Double, ByVal dblS1 As Double,
                              ByVal dblS2 As Double, ByVal dblComm As Double)
        ' calculates a commission amount

        dblComm = (dblS1 + dblS2) * dblRate
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays a commission amount

        Dim dblStore1 As Double
        Dim dblStore2 As Double
        Dim dblRate As Double
        Dim dblCommission As Double

        Double.TryParse(txtStore1.Text, dblStore1)
        Double.TryParse(txtStore2.Text, dblStore2)
        Double.TryParse(txtRate.Text, dblRate)

        Call GetCommission(dblStore1, dblStore2, dblRate, dblCommission)

        lblComm.Text = dblCommission.ToString("C2")
    End Sub

    Private Sub txtStore1_Enter(sender As Object, e As EventArgs) Handles txtStore1.Enter
        txtStore1.SelectAll()
    End Sub

    Private Sub txtStore2_Click(sender As Object, e As EventArgs) Handles txtStore2.Click
        txtStore2.SelectAll()
    End Sub

    Private Sub txtRate_Enter(sender As Object, e As EventArgs) Handles txtRate.Enter
        txtRate.SelectAll()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtRate.TextChanged, txtStore1.TextChanged,
                        txtStore2.TextChanged
        lblComm.Text = String.Empty
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtRate.KeyPress,
                txtStore1.KeyPress, txtStore2.KeyPress
        ' allow only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
