' Name:         Salary Project
' Purpose:      Displays the salary amount associated with a code
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private intSalaries() As Integer = {25000, 35000, 55000, 70000, 80200, 90500}

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the salary amount associated with a code

        Dim strInputCode As String
        Dim intCode As Integer
        Dim intSubscript As Integer

        strInputCode = InputBox("Salary code (1-6)", "Salary")
        Integer.TryParse(strInputCode, intCode)
        ' subtract 1 from the code to get the appropriate subscript
        intSubscript = intCode - 1

        If intSubscript >= 0 AndAlso intSubscript < intSalaries.Length Then
            lblSalary.Text = intSalaries(intSubscript).ToString("C0")
        Else
            lblSalary.Text = String.Empty
            MessageBox.Show("The salary code must be from 1 through 6.",
                            "Salary", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If

    End Sub
End Class
