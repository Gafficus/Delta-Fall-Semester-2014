' Name:         Debug Project
' Purpose:      Displays the number of times the Count button is pressed
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        ' display the number of times the Count button is pressed

        Dim intNumTimes As Integer

        ' add 1 to the variable each time the button is pressed
        intNumTimes = intNumTimes + 1

        ' display message
        lblMessage.Text = "Number of times you pressed the Count button: " &
            Convert.ToString(intNumTimes)
    End Sub
End Class
