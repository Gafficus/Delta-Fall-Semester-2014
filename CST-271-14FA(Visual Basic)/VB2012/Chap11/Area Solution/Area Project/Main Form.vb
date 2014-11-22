' Name:         Area Project
' Purpose:      Display the area of a square or 
'               the surface area of a cube
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        ' displays the area of a square


    End Sub

    Private Sub btnCube_Click(sender As Object, e As EventArgs) Handles btnCube.Click
        ' displays the surface area of a cube


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSide_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSide.KeyPress
        ' accepts only numbers, the period, and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSide_TextChanged(sender As Object, e As EventArgs) Handles txtSide.TextChanged
        lblArea.Text = String.Empty
    End Sub
End Class
