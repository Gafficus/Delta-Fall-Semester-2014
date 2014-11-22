' Name:         Debug Project
' Purpose:      Inserts a space after each letter 
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtLetters_Enter(sender As Object, e As EventArgs) Handles txtLetters.Enter
        txtLetters.SelectAll()
    End Sub

    Private Sub txtLetters_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLetters.KeyPress
        ' accepts only letters and the Backspace key

        If (e.KeyChar.ToString.ToUpper < "A" OrElse e.KeyChar.ToString.ToUpper > "Z") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLetters_TextChanged(sender As Object, e As EventArgs) Handles txtLetters.TextChanged
        lblLettersWithSpaces.Text = String.Empty
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        ' inserts a space after each letter

        Dim strLetters As String

        strLetters = txtLetters.Text

        If strLetters.Length = 5 Then
            lblLettersWithSpaces.Text = strLetters.Substring(0, 1)
            For intIndex As Integer = 0 To strLetters.Length - 1
                lblLettersWithSpaces.Text = lblLettersWithSpaces.Text & " " & strLetters.Substring(intIndex, 0)
            Next intIndex
        Else
            MessageBox.Show("Please enter 5 letters", "Debugging Exercise", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtLetters.Focus()
    End Sub
End Class
