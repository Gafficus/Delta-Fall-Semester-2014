' Name:         Norbert Project
' Purpose:      Display the number of gallons 
'               needed to fill a rectangular pool
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain


    Private Function GetGallons(ByVal dblLen As Double,
                                ByVal dblWid As Double,
                                ByVal dblDep As Double) As Double
        ' calculates and returns the number of gallons

        Const dblGAL_PER_CUBIC_FOOT As Double = 7.48

        Return dblLen * dblWid * dblDep * dblGAL_PER_CUBIC_FOOT
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays the number of gallons

        Dim dblPoolLength As Double
        Dim dblPoolWidth As Double
        Dim dblPoolDepth As Double
        Dim dblGallons As Double

        Double.TryParse(txtLength.Text, dblPoolLength)
        Double.TryParse(txtWidth.Text, dblPoolWidth)
        Double.TryParse(txtDepth.Text, dblPoolDepth)

        dblGallons =
            GetGallons(dblPoolLength, dblPoolWidth, dblPoolDepth)
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
