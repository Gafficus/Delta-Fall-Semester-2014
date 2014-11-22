' Name:         Temperature Solution
' Purpose:      Convert a temperature to either Celsius or Fahrenheit
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtTemp.TextChanged, radCelsius.Click, radFahrenheit.Click
        lblResult.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtTemp_Enter(sender As Object, e As EventArgs) Handles txtTemp.Enter
        txtTemp.SelectAll()
    End Sub

End Class
