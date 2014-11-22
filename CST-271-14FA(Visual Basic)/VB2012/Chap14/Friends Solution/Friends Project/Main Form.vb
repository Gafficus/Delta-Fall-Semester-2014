' Name:         Friends Project
' Purpose:      Displays the records in order by
'               first name within last name
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FriendsDataSet.tblFriends' table. You can move, or remove it, as needed.
        Me.TblFriendsTableAdapter.Fill(Me.FriendsDataSet.tblFriends)
        TblFriendsBindingSource.Sort = "Last"
    End Sub
End Class
