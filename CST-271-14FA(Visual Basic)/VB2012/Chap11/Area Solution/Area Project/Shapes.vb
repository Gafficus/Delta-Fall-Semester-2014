' Name:         Shapes.vb
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

' base class
Public Class Square
    Public Property Side As Double

    Public Sub New()
        _Side = 0
    End Sub

    Public Sub New(ByVal dblS As Double)
        Side = dblS
    End Sub

    Public Function GetArea() As Double
        ' returns the area of a square
        Return _Side ^ 2
    End Function
End Class

' derived class
