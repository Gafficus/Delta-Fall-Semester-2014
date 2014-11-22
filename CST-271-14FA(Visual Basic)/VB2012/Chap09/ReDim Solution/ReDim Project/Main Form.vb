' Name:         ReDim Project
' Purpose:      Display the sales amounts stored in an array
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' class-level array
    Private intSales(3) As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the sales amounts stored in an array

        Const strPROMPT As String = "Enter a sales amount."
        Dim strInputSales As String
        Dim intSaleAmt As Integer
        Dim intSubscript As Integer
        Dim blnIsValid As Boolean

        Do Until intSubscript = intSales.Length
            strInputSales = InputBox(strPROMPT, "Sales Listing")
            blnIsValid = Integer.TryParse(strInputSales, intSaleAmt)
            If blnIsValid Then
                intSales(intSubscript) = intSaleAmt
                intSubscript += 1
            Else
                MessageBox.Show("Invalid sales", "Sales Listing",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Loop

        ' display the sales amounts
        lstSales.Items.Clear()
        For intSub As Integer = 0 To intSales.GetUpperBound(0)
            lstSales.Items.Add(intSales(intSub).ToString)
        Next intSub
    End Sub
End Class
