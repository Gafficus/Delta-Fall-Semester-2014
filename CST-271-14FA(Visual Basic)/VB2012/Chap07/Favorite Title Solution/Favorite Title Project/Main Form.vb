' Name:         Favorite Title Project
' Purpose:      Displays a message that contains a
'               movie title or a song title
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' independent Sub procedure


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearMsg(sender As Object, e As EventArgs) Handles radMovie.CheckedChanged, radSong.CheckedChanged
        lblMsg.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' gets the title and then calls
        ' a procedure to display the title

        Dim strCategory As String
        Dim strTitle As String

        If radMovie.Checked Then
            strCategory = "movie"
            strTitle =
                InputBox("Your favorite movie?", "Movie")
        Else
            strCategory = "song"
            strTitle = InputBox("Your favorite song?", "Song")
        End If


    End Sub
End Class
