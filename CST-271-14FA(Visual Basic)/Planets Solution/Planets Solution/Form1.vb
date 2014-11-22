'' Name:         Planets Project
' Purpose:      Convert Weight from planet to planet
' Programmer:   NAthan Gaffney on 3-Sep-2014
'Chapter 7 LEsson b Exercise 3
'==============================================
'
'Start Without Debugging will produce an unhandled exceptiopn error.
'
'==============================================

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPlanetWeight.Items.Add("Mercury")
        cmbPlanetWeight.Items.Add("Venus")
        cmbPlanetWeight.Items.Add("Mars")
        cmbPlanetWeight.Items.Add("Jupiter")
        cmbPlanetWeight.Items.Add("Saturn")
        cmbPlanetWeight.Items.Add("Neptune")
        cmbPlanetWeight.Items.Add("Uranus")
        cmbPlanetWeight.Items.Add("Pluto")
        cmbPlanetWeight.SelectedIndex = 0
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub cmbPlanetWeight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlanetWeight.SelectedIndexChanged
        Dim mass As Double = 0 'Mass
        Dim g As Double = 0 'Acceleration due to gravity
        mass = Convert.ToDouble(txtEarthWeight.Text) / 9.8 ' Removing g from earth weight to get mass
        If cmbPlanetWeight.SelectedIndex = 0 Then
            g = 3.703
        ElseIf cmbPlanetWeight.SelectedIndex = 1 Then
            g = 8.872
        ElseIf cmbPlanetWeight.SelectedIndex = 2 Then
            g = 3.728
        ElseIf cmbPlanetWeight.SelectedIndex = 3 Then
            g = 25.93
        ElseIf cmbPlanetWeight.SelectedIndex = 4 Then
            g = 11.19
        ElseIf cmbPlanetWeight.SelectedIndex = 5 Then
            g = 9.01
        ElseIf cmbPlanetWeight.SelectedIndex = 6 Then
            g = 11.28
        ElseIf cmbPlanetWeight.SelectedIndex = 7 Then
            g = 0.583
        End If
        lblWeight.Text = Convert.ToString(mass * g)
    End Sub

End Class
