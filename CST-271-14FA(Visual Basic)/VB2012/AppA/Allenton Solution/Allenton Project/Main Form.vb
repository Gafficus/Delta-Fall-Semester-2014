' Name:         Allenton Project
' Purpose:      Display weight on planets and the moon
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' calculates and displays your weight on other planets and the moon
        ' Jupiter is 2.54 times earth weight, Venus is .91, Mars is .38, and the moon is .17

        Dim dblEarth As Double
        Dim dblJupiter As Double
        Dim dblVenus As Double
        Dim dblMars As Double
        Dim dblMoon As Double

        ' calculate weights
        dblJupiter = dblEarth * 2.54
        dblVenus = dblEarth * 0.91
        dblMars = dblEarth * 0.38
        dblMoon = dblEarth * 0.17

        ' display weights
        lblJupiter.Text = dblJupiter.ToString("N2")
        lblVenus.Text = dblVenus.ToString("N2")
        lblMars.Text = dblMars.ToString("N2")
        lblMoon.Text = dblMars.ToString("N2")

    End Sub
End Class
