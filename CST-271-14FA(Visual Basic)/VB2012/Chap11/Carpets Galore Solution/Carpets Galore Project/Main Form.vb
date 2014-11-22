' Name:         Carpets Galore Project
' Purpose:      Displays the number of square yards of 
'               carpet and the cost of the carpet
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' displays square yards and cost of carpet

        ' instantiate a Rectangle object

        ' declare variables

        ' assign values to the object's Public properties

        ' calculate the square yards

        ' calculate the carpet cost

        ' display output

    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs
        ) Handles lstLength.SelectedValueChanged,
        lstWidth.SelectedValueChanged, lstPrice.SelectedValueChanged
        lblSquareYards.Text = String.Empty
        lblCost.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list boxes with data
        ' and then selects a default item

        For dblNums As Double = 4 To 30 Step 0.5
            lstLength.Items.Add(dblNums.ToString("N1"))
            lstWidth.Items.Add(dblNums.ToString("N1"))
        Next dblNums

        For dblPrices As Double = 5 To 25 Step 0.5
            lstPrice.Items.Add(dblPrices.ToString("N2"))
        Next dblPrices

        lstLength.SelectedItem = "10.0"
        lstWidth.SelectedItem = "10.0"
        lstPrice.SelectedItem = "8.00"
    End Sub
End Class
