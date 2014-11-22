'Created by: NAthan Gaffney
'Date: 10-September-2014
'This program is to practice creating and populating an array.
'Chapter 9 Lesson A Exercise1
Public Class Form1

    Private Sub btnArray_Click(sender As Object, e As EventArgs) Handles btnArray.Click
        Dim intQuantities(15) As Integer
        intQuantities(2) = 10
        MessageBox.Show(intQuantities(2))
    End Sub
End Class
