' Name:         Addison Playhouse Project
' Purpose:      Displays the records contained in a dataset
'               Also allows the user to add, delete, and 
'               display specific records
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PlayDataSet.tblReservations' table. You can move, or remove it, as needed.
        Me.TblReservationsTableAdapter.Fill(Me.PlayDataSet.tblReservations)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPatron_Enter(sender As Object, e As EventArgs) Handles txtPatron.Enter
        txtPatron.SelectAll()
    End Sub

    Private Sub txtPhone_Enter(sender As Object, e As EventArgs) Handles txtPhone.Enter
        txtPhone.SelectAll()
    End Sub

    Private Sub txtSeat_Enter(sender As Object, e As EventArgs) Handles txtSeat.Enter
        txtSeat.SelectAll()
    End Sub

    Private Sub txtSeat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSeat.KeyPress
        ' allows the text box to accept only numbers and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

End Class
