' Name:         Morgan Industries Project
' Purpose:      Displays the records stored in a dataset
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub TblEmployBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblEmployBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.TblEmployBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.EmployeesDataSet)
            MessageBox.Show("Changed saved", "Morgan Industries",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Morgan Industries",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeesDataSet.tblEmploy' table. You can move, or remove it, as needed.
        Me.TblEmployTableAdapter.Fill(Me.EmployeesDataSet.tblEmploy)

    End Sub
End Class
