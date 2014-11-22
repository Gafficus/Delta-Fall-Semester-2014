' Name:         Academy Award Project
' Purpose:      Displays the records stored in a dataset
'               Allows the user to add records to and 
'               delete records from a dataset
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MoviesDataSet.tblMovies' table. You can move, or remove it, as needed.
        Me.TblMoviesTableAdapter.Fill(Me.MoviesDataSet.tblMovies)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' add a record to the dataset


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' delete a record from the dataset


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAddYear_Enter(sender As Object, e As EventArgs) Handles txtAddYear.Enter
        txtAddYear.SelectAll()
    End Sub

    Private Sub txtDirector_Enter(sender As Object, e As EventArgs) Handles txtDirector.Enter
        txtDirector.SelectAll()
    End Sub

    Private Sub txtLength_Enter(sender As Object, e As EventArgs) Handles txtLength.Enter
        txtLength.SelectAll()
    End Sub

    Private Sub txtTitle_Enter(sender As Object, e As EventArgs) Handles txtTitle.Enter
        txtTitle.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) _
        Handles txtAddYear.KeyPress, txtLength.KeyPress
        ' allows the text box to accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
