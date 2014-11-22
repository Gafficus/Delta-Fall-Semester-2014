' Name:         Car Emporium Project
' Purpose:      Display the highest commission amount and the
'               number of salespeople who were paid that amount
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        ' displays the highest commission and the
        ' number who were paid that amount

        Dim intCommissions() As Integer = {2500, 3400, 1000,
                                           3400, 2500, 1000,
                                           2850, 3000, 2780, 1890}


        lblHighest.Text = intHighest.ToString("C0")
        lblSalespeople.Text = intSalespeople.ToString
    End Sub
End Class
