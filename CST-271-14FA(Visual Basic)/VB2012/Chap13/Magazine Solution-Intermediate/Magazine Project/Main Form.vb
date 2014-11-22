' Name:         Magazine Project
' Purpose:      Selects specific records
'               Also displays the average cost of a magazine
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MagazinesDataSet.tblMagazine' table. You can move, or remove it, as needed.
        Me.TblMagazineTableAdapter.Fill(Me.MagazinesDataSet.tblMagazine)

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        ' displays all of the records


    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' displays records having a cost of $4 or more


    End Sub

    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        ' displays records whose names begin with the letter C


    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        ' displays the average cost


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
