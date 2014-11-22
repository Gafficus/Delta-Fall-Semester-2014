' Name:         Norbert Project
' Purpose:      Display the number of gallons 
'               needed to fill a rectangular pool
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Structure Dimensions
        Public dblLength As Double
        Public dblWidth As Double
        Public dblDepth As Double
    End Structure

    Private Function GetGallons(ByVal pool As Dimensions) As Double
        ' calculates and returns the number of gallons

        Const dblGAL_PER_CUBIC_FOOT As Double = 7.48

        Return pool.dblLength * pool.dblWidth *
          pool.dblDepth * dblGAL_PER_CUBIC_FOOT
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays the number of gallons

        Dim poolSize As Dimensions
        Dim dblGallons As Double

        Double.TryParse(txtLength.Text, poolSize.dblLength)
        Double.TryParse(txtWidth.Text, poolSize.dblWidth)
        Double.TryParse(txtDepth.Text, poolSize.dblDepth)

        dblGallons = GetGallons(poolSize)
        lblGallons.Text = dblGallons.ToString("N0")

        txtLength.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtDepth_Enter(sender As Object, e As EventArgs) Handles txtDepth.Enter
        txtDepth.SelectAll()
    End Sub

    Private Sub txtLength_Enter(sender As Object, e As EventArgs) Handles txtLength.Enter
        txtLength.SelectAll()
    End Sub

    Private Sub txtWidth_Enter(sender As Object, e As EventArgs) Handles txtWidth.Enter
        txtWidth.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs
                        ) Handles txtLength.KeyPress, txtWidth.KeyPress,
                        txtDepth.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearGallons(sender As Object, e As EventArgs
                         ) Handles txtLength.TextChanged,
                         txtWidth.TextChanged, txtDepth.TextChanged
        lblGallons.Text = String.Empty
    End Sub
End Class
