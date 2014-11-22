' Name:         Morgan Industries Project
' Purpose:      Displays specific records from a dataset
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeesDataSet.tblEmploy' table. You can move, or remove it, as needed.
        Me.TblEmployTableAdapter.Fill(Me.EmployeesDataSet.tblEmploy)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ' selects records whose last name 
        ' begins with the user's entry

        Const strPROMPT As String = "One or more letters " &
            "(leave empty to retrieve all records):"

        ' get the last name
        Dim strFindName As String =
            InputBox(strPROMPT, "Find Last Name").ToUpper

        ' select records matching the last name

    End Sub
End Class
