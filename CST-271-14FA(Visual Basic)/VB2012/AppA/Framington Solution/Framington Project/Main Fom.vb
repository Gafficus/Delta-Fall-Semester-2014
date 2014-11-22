' Name:         Framington Project
' Purpose:      Display the number of tables needed to
'               seat guests at a party
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' calculates the number of tables that seat 10, the number
        ' of tables that seat 5, and the number of guests remaining
        ' example: 67 guests need 6 tables of 10 and 1
        ' table of 5, with 2 guests remaining
        Dim intGuests As Integer
        Dim intTable10 As Integer
        Dim intTable5 As Integer
        Dim intRemain As Integer

        ' assign input to a variable
        Integer.TryParse(txtGuests.Text, intGuests)

        ' perform calculations
        intTable10 = intGuests / 10
        intRemain = intGuests - intTable10 * 10
        intTable5 = intRemain / 5
        intRemain = intRemain - intTable5 * 5

        ' display calculated results
        lblTable10.Text = intTable10
        lblTable5.Text = intTable5
        lblRemain.Text = intRemain

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
