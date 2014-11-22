' Name:         Laury Project
' Purpose:      Displays a shipping charge based on the number of items ordered
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtordered_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrdered.KeyPress
        ' allows the text box to accept numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtordered_TextChanged(sender As Object, e As EventArgs) Handles txtOrdered.TextChanged
        lblShipping.Text = String.Empty
    End Sub

End Class
