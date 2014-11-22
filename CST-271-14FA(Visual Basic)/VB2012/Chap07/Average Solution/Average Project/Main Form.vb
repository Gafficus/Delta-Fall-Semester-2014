' Name:         Average Project
' Purpose:      Displays the average score
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAvg_Click(sender As Object, e As EventArgs) Handles btnAvg.Click
        ' calculates the average of 4 scores

    End Sub

    Private Sub txtScore1_Enter(sender As Object, e As EventArgs) Handles txtScore1.Enter
        txtScore1.SelectAll()
    End Sub

    Private Sub txtScore2_Enter(sender As Object, e As EventArgs) Handles txtScore2.Enter
        txtScore2.SelectAll()
    End Sub

    Private Sub txtScore3_Enter(sender As Object, e As EventArgs) Handles txtScore3.Enter
        txtScore3.SelectAll()
    End Sub

    Private Sub txtScore4_Enter(sender As Object, e As EventArgs) Handles txtScore4.Enter
        txtScore4.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtScore1.KeyPress,
        txtScore2.KeyPress, txtScore3.KeyPress, txtScore4.KeyPress
        ' allow only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtScore1.TextChanged,
                txtScore2.TextChanged, txtScore3.TextChanged, txtScore4.TextChanged
        lblAvg.Text = String.Empty
    End Sub
End Class
