' Name:         Debug Project
' Purpose:      Displays the city name included in an address
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtAddress_Enter(sender As Object, e As EventArgs) Handles txtAddress.Enter
        txtAddress.SelectAll()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the city name

        Const strPROMPT As String =
            "Please enter a city name followed by a comma, a space, and a state name."
        Dim strAddress As String
        Dim strCity As String
        Dim intIndex As Integer

        strAddress = txtAddress.Text

        ' find the comma
        intIndex = strAddress.IndexOf(",")

        If intIndex <> -1 Then
            ' if the address contains a comma,
            ' assign the city name to the strCity variable,
            ' then display the city name; otherwise,
            ' display an appropriate message
            strCity = strAddress.Substring(intIndex, strAddress.Length - 1)
            MessageBox.Show(strCity, "City Name",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(strPROMPT, "City Name",
                 MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        txtAddress.Focus()
    End Sub
End Class
