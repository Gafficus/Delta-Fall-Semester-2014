' Name:         Salary Project
' Purpose:      Calculates an employee's new salary
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the new salary

        ' declare variables

        ' assign name and salary to Worker object's properties

        ' assign raise percentage to a variable

        ' calculate and display the new salary

    End Sub

    Private Sub txtCurrent_Enter(sender As Object, e As EventArgs) Handles txtCurrent.Enter
        txtCurrent.SelectAll()
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtRaisePercent_Enter(sender As Object, e As EventArgs) Handles txtRaisePercent.Enter
        txtRaisePercent.SelectAll()
    End Sub

    Private Sub txtCurrent_TextChanged(sender As Object, e As EventArgs) Handles txtCurrent.TextChanged
        lblNew.Text = String.Empty
    End Sub

    Private Sub txtRaisePercent_TextChanged(sender As Object, e As EventArgs) Handles txtRaisePercent.TextChanged
        lblNew.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
