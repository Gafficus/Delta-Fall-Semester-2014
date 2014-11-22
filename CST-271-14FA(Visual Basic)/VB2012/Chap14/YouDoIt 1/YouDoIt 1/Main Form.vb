Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NamesDataSet.tblNames' table. You can move, or remove it, as needed.
        Me.TblNamesTableAdapter.Fill(Me.NamesDataSet.tblNames)

    End Sub
End Class
