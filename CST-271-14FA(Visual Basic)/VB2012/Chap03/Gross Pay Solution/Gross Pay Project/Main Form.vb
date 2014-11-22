' Name:         Gross Pay Project
' Purpose:      Displays an employee's gross pay
' Programmer:   <your name> on <current date>

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate an employee's gross pay

        lblGross.Text = Val(txtHours.Text) * Val(txtPayRate.Text)
        lblGross.Text = Format(lblGross.Text, "Currency")

    End Sub
End Class
