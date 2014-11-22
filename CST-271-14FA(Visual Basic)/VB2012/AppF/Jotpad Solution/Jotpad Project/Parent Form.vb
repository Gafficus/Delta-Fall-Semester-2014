' Name:         Jotpad Project
' Purpose:      Parent form in an MDI application
'               Saves text to and reads text from
'               a sequential access file
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmParent

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        ' reads information from a sequential access file

        Dim inFile As IO.StreamReader
        Dim strFileName As String

        ' get the filename
        strFileName = InputBox("Filename", "Jotpad")

        If IO.File.Exists(strFileName) Then
            ' open the file for input
            inFile = IO.File.OpenText(strFileName)
            ' assign the file's contents to the
            ' text box on the child form

            ' close the file
            inFile.Close()
        Else
            MessageBox.Show("Can't locate " & strFileName,
                           "Jotpad", MessageBoxButtons.OK,
                           MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        ' saves information to a sequential access file

        Dim outFile As IO.StreamWriter
        Dim strFileName As String

        ' get the filename
        strFileName = InputBox("Filename", "Jotpad")

        If strFileName <> String.Empty Then
            ' open the file for output
            outFile = IO.File.CreateText(strFileName)
            ' write the text to the file

            MessageBox.Show("Saved to " & strFileName,
                            "Jotpad", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            ' close the file
            outFile.Close()
        End If
    End Sub
End Class
