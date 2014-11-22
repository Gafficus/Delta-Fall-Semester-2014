' Name:         Cerruti Project
' Purpose:      Displays gross pay, taxes, and net pay
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' GetFwt function


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        ' select the existing text

        txtName.SelectAll()
    End Sub

    Private Sub cboAllowances_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboAllowances.KeyPress
        ' allow only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles lstHours.SelectedValueChanged,
        lstRates.SelectedValueChanged, radSingle.CheckedChanged, radMarried.CheckedChanged,
        txtName.TextChanged, cboAllowances.TextChanged

        lblGross.Text = String.Empty
        lblFwt.Text = String.Empty
        lblFica.Text = String.Empty
        lblNet.Text = String.Empty
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fill list boxes and combo box with values
        ' then select a default value in each

        For dblHours As Double = 0 To 55 Step 0.5
            lstHours.Items.Add(dblHours.ToString("N1"))
        Next dblHours

        For dblRates As Double = 7.5 To 15.5 Step 0.5
            lstRates.Items.Add(dblRates.ToString("N2"))
        Next dblRates

        For intAllow As Integer = 0 To 10
            cboAllowances.Items.Add(intAllow.ToString)
        Next intAllow

        lstHours.SelectedItem = "40.0"
        lstRates.SelectedItem = "9.50"
        cboAllowances.SelectedIndex = 0
    End Sub

End Class
