' Name:         MusicBox Project
' Purpose:      Selects specific records
'               Also displays the number of music boxes
' Programmer:   Nathan Gaffney on 19/NOV/2014

Option Explicit On
Option Strict On
Option Infer On   ' using LINQ

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MusicBoxDataSet.tblBox' table. You can move, or remove it, as needed.
        Me.TblBoxTableAdapter.Fill(Me.MusicBoxDataSet.tblBox)

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        ' displays all of the records

        Dim allRecords = From data In MusicBoxDataSet.tblBox
            Select data

        TblBoxBindingSource.DataSource = allRecords.AsDataView
    End Sub

    Private Sub btnShape_Click(sender As Object, e As EventArgs) Handles btnShape.Click
        ' displays music boxes having the selected shape
        If radOctagon.Checked Then
            Dim octagons = From data In MusicBoxDataSet.tblBox
            Where data.Shape = "Octagon"
            Select data

            TblBoxBindingSource.DataSource = octagons.AsDataView
        ElseIf radRectangle.Checked Then
            Dim rectangles = From data In MusicBoxDataSet.tblBox
                Where data.Shape = "Rectangle"
                Select data
            TblBoxBindingSource.DataSource = rectangles.AsDataView
        Else
            Dim round = From data In MusicBoxDataSet.tblBox
                Where data.Shape = "Round"
                Select data
            TblBoxBindingSource.DataSource = round.AsDataView
        End If

    End Sub

    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        ' displays either gift music boxes or purchased music boxes
        If radGift.Checked Then
            Dim gifts = From data In MusicBoxDataSet.tblBox
            Where data.Source = "Gift"
            Select data

            TblBoxBindingSource.DataSource = gifts.AsDataView
        ElseIf radPurchased.Checked Then
            Dim purchases = From data In MusicBoxDataSet.tblBox
                Where data.Source = "Purchase"
                Select data
            TblBoxBindingSource.DataSource = purchases.AsDataView
        End If

    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        ' displays the number of music boxes
        Dim intCounter As Integer = Aggregate data In MusicBoxDataSet.tblBox
            Into Count()
        MessageBox.Show("There are currently: " & intCounter & " total enteries.")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
