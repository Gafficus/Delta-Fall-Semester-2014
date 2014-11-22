' Name:         Magazine Project
' Purpose:      Displays the records stored in a dataset
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MagazinesDataSet.tblMagazine' table. You can move, or remove it, as needed.
        Me.TblMagazineTableAdapter.Fill(Me.MagazinesDataSet.tblMagazine)

    End Sub
End Class
