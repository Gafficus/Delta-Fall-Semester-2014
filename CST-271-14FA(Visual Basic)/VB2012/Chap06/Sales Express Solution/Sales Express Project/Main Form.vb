' Name:         Sales Express Project
' Purpose:      Displays the average sales amount
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the average sales amount

        Const strPROMPT As String =
            "Enter a sales amount. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Sales Entry"
        Dim strInputSales As String
        Dim decSales As Decimal
        Dim intNumSales As Integer
        Dim decTotalSales As Decimal
        Dim decAvgSales As Decimal

        ' get first sales amount

        ' repeat as long as the user enters a sales amount
       

        ' verify that the counter is greater than 0
        
    End Sub

End Class
