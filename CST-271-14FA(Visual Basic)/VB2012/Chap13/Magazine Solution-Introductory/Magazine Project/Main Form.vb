' Name:         Magazine Project
' Purpose:      Selects specific records
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MagazinesDataSet.tblMagazine' table. You can move, or remove it, as needed.
        Me.TblMagazineTableAdapter.Fill(Me.MagazinesDataSet.tblMagazine)

    End Sub

    Private Sub btnCode_Click(sender As Object, e As EventArgs) Handles btnCode.Click
        ' displays the record whose Code field contains EX33


    End Sub

    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        ' displays the record whose MagName field contains Visual Basic


    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        ' displays all of the records


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
