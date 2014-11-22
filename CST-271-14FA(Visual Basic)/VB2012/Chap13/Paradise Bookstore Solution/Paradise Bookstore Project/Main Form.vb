' Name:         Paradise Bookstore Project
' Purpose:      Displays all records or only those
'               for a specific author. Also displays
'               the total value of the books.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer On  ' using LINQ

Public Class frmMain

    Private Sub TblBooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblBooksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblBooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooksDataSet)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooksDataSet.tblBooks' table. You can move, or remove it, as needed.
        Me.TblBooksTableAdapter.Fill(Me.BooksDataSet.tblBooks)

    End Sub
End Class
