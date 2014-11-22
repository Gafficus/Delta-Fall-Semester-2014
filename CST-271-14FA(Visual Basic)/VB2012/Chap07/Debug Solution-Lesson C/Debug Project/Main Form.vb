' Name:         Debug Project
' Purpose:      Calculates and displays an area
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Function GetArea(ByVal intLen As Integer, ByVal intWid As Integer) As Integer
        Dim intArea As Integer

        intArea = intLen * intWid
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calls a function to calculate the area and then displays the area

        Dim intLength As Integer
        Dim intWidth As Integer
        Dim intArea As Integer

        intLength = Convert.ToInt32(lstLength.SelectedItem.ToString)
        intWidth = Convert.ToInt32(lstWidth.SelectedItem.ToString)
        intArea = GetArea(intLength, intWidth)
        lblArea.Text = Convert.ToString(intArea)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the list boxes with data

        For intNum As Integer = 10 To 40 Step 5
            lstLength.Items.Add(intNum)
        Next intNum

        For intNum As Integer = 10 To 40 Step 5
            lstWidth.Items.Add(intNum)
        Next intNum

        'select first item in each list box
        lstLength.SelectedIndex = 0
        lstWidth.SelectedIndex = 0
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles lstLength.SelectedIndexChanged, lstWidth.SelectedIndexChanged
        lblArea.Text = String.Empty
    End Sub
End Class
