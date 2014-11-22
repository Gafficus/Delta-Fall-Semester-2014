' Name:         Formula Project
' Purpose:      Displays the area of either a parallelogram or a triangle
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtBase.KeyPress, txtHeight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles radParallelogram.CheckedChanged, radTriangle.CheckedChanged, txtBase.TextChanged, txtHeight.TextChanged
        lblAnswer.Text = String.Empty
    End Sub

End Class
