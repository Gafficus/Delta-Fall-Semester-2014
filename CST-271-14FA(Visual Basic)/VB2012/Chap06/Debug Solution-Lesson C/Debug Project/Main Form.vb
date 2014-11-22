' Name:         Debug Project
' Purpose:      Displays the number of positive integers, negative integers, 
'               and zeros entered by the user.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' displays the number of positive integers, 
        ' the number of negative integers, 
        ' and the number of zeros entered

        Const strPROMPT As String = "Enter an integer. Click Cancel to end. "
        Dim strInput As String
        Dim intNumber As Integer
        Dim intPositive As Integer
        Dim intNegative As Integer
        Dim intZero As Integer
        Dim blnIsInteger As Boolean

        strInput = InputBox(strPROMPT, "Number Entry", "0")
        Do While strInput <> String.Empty
            blnIsInteger = Integer.TryParse(strInput, intNumber)
            If blnIsInteger Then
                ' update appropriate counter
                If intNumber > 0 Then
                    intPositive = 1
                ElseIf intNumber < 0 Then
                    intNegative = 1
                Else
                    intZero = 1
                End If
                strInput = InputBox(strPROMPT, "Number Entry", "0")
            Else
                MessageBox.Show("Please enter a whole number.",
                                "Integer Entry", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
            End If
        Loop

        ' display counters
        lblPositive.Text = intPositive.ToString
        lblNegative.Text = intNegative.ToString
        lblZero.Text = intZero.ToString
    End Sub
End Class
