' Name:         Debug Project
' Purpose:      Displays commission amounts
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays commission amounts

        Const dblCOMM_RATE As Double = 0.05
        Dim strInput As String
        Dim dblSales As Double
        Dim dblComm As Double

        strInput = InputBox("Sales:", "Sales")
        Double.TryParse(strInput, dblSales)
        Do
            strInput = InputBox("Sales:", "Sales")
            Double.TryParse(strInput, dblSales)
            dblComm = dblSales * dblCOMM_RATE
            MessageBox.Show(dblComm.ToString("C2"), "Commission",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Loop Until dblSales <= 0

    End Sub
End Class
