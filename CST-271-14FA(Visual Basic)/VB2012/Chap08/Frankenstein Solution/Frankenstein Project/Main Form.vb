' Name:         Frankenstein Project
' Purpose:      A game that allows the user to guess a
'               word letter-by-letter
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private strWord As String
    Private intIncorrect As Integer

    Private Sub DisplayPicture()
        ' display appropriate picture

        Select Case intIncorrect
            Case 1
                picHead.Visible = True
            Case 2
                picHeadTorso.Visible = True
            Case 3
                picHeadTorsoOneArm.Visible = True
            Case 4
                picHeadTorsoTwoArms.Visible = True
            Case 5
                picHeadTorsoArmsOneLeg.Visible = True
            Case 6
                picFullBody.Visible = True
        End Select
    End Sub

    Private Sub DetermineGameOver(ByVal blnADashWasReplaced As Boolean)
        ' determine whether the game is over and
        ' take the appropriate action

        If blnADashWasReplaced = True Then
            ' if the word does not contain any dashes, 
            ' the game is over because player 2 
            ' guessed the word
            If lblWord.Text.Contains("-") = False Then
                MessageBox.Show("Great guessing!",
                                "Game Over",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                btnCheck.Enabled = False
                intIncorrect = 0
            End If
        Else
            ' if the user made 6 incorrect guesses,
            ' the game is over
            If intIncorrect = 6 Then
                MessageBox.Show("Sorry, the word is " &
                                strWord & ".",
                                "Game Over",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                btnCheck.Enabled = False
                intIncorrect = 0
            End If
        End If
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        ' check if the letter appears in the word

        Dim strLetter As String
        Dim blnDashReplaced As Boolean

        strLetter = txtLetter.Text

        ' look at each letter in the word


        If blnDashReplaced = True Then
            Call DetermineGameOver(blnDashReplaced)
        Else  ' no dash was replaced
            lblIncorrect.Text =
                lblIncorrect.Text & " " & strLetter
            intIncorrect = intIncorrect + 1
            Call DisplayPicture()
            Call DetermineGameOver(blnDashReplaced)
        End If

        ' clear text box and set focus
        txtLetter.Text = String.Empty
        txtLetter.Focus()
    End Sub
End Class
