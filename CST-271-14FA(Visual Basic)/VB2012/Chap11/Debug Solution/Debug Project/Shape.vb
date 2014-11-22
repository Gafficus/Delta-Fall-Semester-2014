' Name:         Shape.vb
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

' base class
Public Class Shape
    Private _dblArea As Double

    Public ReadOnly Property Area() As Double
        Get
            Return _dblArea
        End Get
    End Property

    Public Sub New()
        _dblArea = 0
    End Sub

    Public Overridden Function GetArea() As Double
    ' will be overridden in the derived class
       Return 0
    End Function

End Class

' derived class
Public Class Circle
    Inherits Shape

    Private _dblRadius As Double

    Public Property Radius() As Double
        Get
            Return _dblRadius
        End Get
        Set(value As Double)
            _dblRadius = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        _dblRadius = 0
    End Sub

    Public Sub New(ByVal dblR As Double)
        MyBase.New()
    End Sub

    Public Overrides Function GetArea() As Double
        Const dblPI As Double = 3.14

        Return dblPI * _dblRadius ^ 2
    End Function

End Class