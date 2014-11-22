' Name:         MusicBox Project
' Purpose:      Selects specific records
'               Also displays the number of music boxes
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On   ' using LINQ

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MusicBoxDataSet.tblBox' table. You can move, or remove it, as needed.
        Me.TblBoxTableAdapter.Fill(Me.MusicBoxDataSet.tblBox)

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        ' displays all of the records


    End Sub

    Private Sub btnShape_Click(sender As Object, e As EventArgs) Handles btnShape.Click
        ' displays music boxes having the selected shape


    End Sub

    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        ' displays either gift music boxes or purchased music boxes


    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        ' displays the number of music boxes


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
