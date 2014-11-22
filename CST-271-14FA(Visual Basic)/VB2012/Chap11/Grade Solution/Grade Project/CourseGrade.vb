' Name:         CourseGrade.vb
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class CourseGrade
    Private _intScore1 As Integer
    Private _intScore2 As Integer
    
    Public Property Score1 As Integer
        Get
            Return _intScore1
        End Get
        Set(value As Integer)
            _intScore1 = value
        End Set
    End Property

    Public Property Score2 As Integer
        Get
            Return _intScore2
        End Get
        Set(value As Integer)
            _intScore2 = value
        End Set
    End Property


End Class
