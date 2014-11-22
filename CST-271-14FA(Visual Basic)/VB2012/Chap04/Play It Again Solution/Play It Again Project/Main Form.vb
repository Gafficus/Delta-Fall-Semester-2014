' Name:         Play It Again Project
' Purpose:      Calculates the total number
'               of discs sold and the total
'               sales amount
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDvds.Text = String.Empty
        txtBluRays.Text = String.Empty
        lblTotalDiscs.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMessage.Text = String.Empty
        ' send the focus to the DVDs box
        txtDvds.Focus()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' print the sales receipt

        Me.Width = Me.Width - 165
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        Me.Width = Me.Width + 165

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of discs sold and total sales

        Const strPROMPT As String = "Salesclerk's name:"
        Const strTITLE As String = "Name Entry"
        Const decDISC_PRICE As Decimal = 7D
        Const decTAX_RATE As Decimal = 0.03D
        Dim intDvds As Integer
        Dim intBluRays As Integer
        Dim intTotalDiscs As Integer
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalSales As Decimal
        Static strClerk As String

        ' assign the name to the variable
        strClerk = InputBox(strPROMPT, strTITLE, strClerk)

        ' calculate total number of discs sold
        Integer.TryParse(txtDvds.Text, intDvds)
        Integer.TryParse(txtBluRays.Text, intBluRays)
        intTotalDiscs = intDvds + intBluRays

        ' calculate the subtotal
        decSubtotal = intTotalDiscs * decDISC_PRICE

        ' calculate the sales tax
        decSalesTax = decSubtotal * decTAX_RATE

        ' calculate the total sales
        decTotalSales = decSubtotal + decSalesTax

        ' display total amounts
        lblTotalDiscs.Text = Convert.ToString(intTotalDiscs)
        lblTotalSales.Text = decTotalSales.ToString("C2")

        ' display tax and salesclerk's name
        lblMessage.Text = "The sales tax was " &
            Convert.ToString(decSalesTax) & "." &
            ControlChars.NewLine & strClerk

    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtDvds.TextChanged, txtBluRays.TextChanged
        ' clears the total discs, total sales, and message

        lblTotalDiscs.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMessage.Text = String.Empty

    End Sub
End Class
