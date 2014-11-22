Public Class Form1

    Private Sub btnArray_Click(sender As Object, e As EventArgs) Handles btnArray.Click
        Dim intBalance(3, 5) As Integer
        intBalance(1, 3) = 100
        txtBox.Text = Convert.ToString(intBalance(1, 3))
    End Sub
End Class
