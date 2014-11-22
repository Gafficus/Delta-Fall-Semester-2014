' Name:         Inventory Project
' Purpose:      Multiplies each array element by 2 and then
'               displays the array's contents in a list box
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' multiplies each array element by 2 and then displays the results in a list box

        Dim intInventory(,) As Integer = {{45, 67}, {2, 4}, {50, 7}, {9, 8}}


    End Sub
End Class
