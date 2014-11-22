' Name:         Debug Project
' Purpose:      Displays bonus amounts
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strInput As String
        Dim dblSales As Double
        Dim dblBonus As Double

        strInput = InputBox("Sales amount:", "Sales")
        Do While strInput <> String.Empty
            Double.TryParse(strInput, dblSales)
            dblBonus = dblSales * 0.1
            MessageBox.Show(dblBonus.ToString("C2"), "Bonus",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information)
        Loop
    End Sub
End Class
