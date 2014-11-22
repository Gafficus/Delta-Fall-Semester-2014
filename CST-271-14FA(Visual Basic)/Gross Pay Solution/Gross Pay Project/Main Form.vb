' Name:         Gross Pay Project
' Purpose:      Writes gross pay amounts to a sequential access file.
'               Also reads the file and displays the gross pay amounts.
' Programmer:   Nathan Gaffney on 7-Oct-2014
'VISUAL BASIC PRG II - CST-271-FA710-14FA-COURSE

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtGrossPay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrossPay.KeyPress
        ' allows the text box to accept only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim outFile As IO.StreamWriter
        outFile = IO.File.AppendText("gross.txt")
        outFile.WriteLine(txtGrossPay.Text)
        outFile.Close()
        lstContents.Items.Clear()
        txtGrossPay.Focus()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim inFile As IO.StreamReader
        Dim strGross As String
        lstContents.Items.Clear()
        If IO.File.Exists("gross.txt") Then
            inFile = IO.File.OpenText("gross.txt")
            Do Until inFile.Peek = -1
                strGross = inFile.ReadLine
                lstContents.Items.Add(strGross)
            Loop
            inFile.Close()
        Else
            MessageBox.Show("Can't find the file.")
            Me.Close()
        End If
    End Sub
End Class
