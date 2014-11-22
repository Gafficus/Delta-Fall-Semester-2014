' Name:         Treasures Project
' Purpose:      Display an item's price
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' declare parallel arrays
    Private strIds() As String =
        {"BX35", "CR20", "FE15", "KW10", "MM67"}
    Private intPrices() As Integer = {13, 10, 12, 24, 4}

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtId_Enter(sender As Object, e As EventArgs) Handles txtId.Enter
        txtId.SelectAll()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        lblPrice.Text = String.Empty
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' displays the price associated with an ID

        Dim strSearchForId As String
        Dim intSub As Integer

        strSearchForId = txtId.Text

        ' search the strIds array for the ID
        ' continue searching until the end of
        ' the array or the ID is found
        Do Until intSub = strIds.Length OrElse
            strSearchForId = strIds(intSub)
            intSub += 1
        Loop

        If intSub < strIds.Length Then
            lblPrice.Text = intPrices(intSub).ToString("C0")
        Else
            MessageBox.Show("Invalid ID", "Treasures",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub
End Class
