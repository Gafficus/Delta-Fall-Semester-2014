' Name:         Debug Project
' Purpose:      Display the contents of a dataset
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        ' fill the dataset with data

        Me.TblFriendsTableAdapter.Fill(Me.FriendsDataSet)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ' move to the previous record

        TblFriendsBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' move to the next record

        TblFriendsBindingSource.MoveLast()
    End Sub
End Class
