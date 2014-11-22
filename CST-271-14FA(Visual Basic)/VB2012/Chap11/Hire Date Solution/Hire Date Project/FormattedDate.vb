' Name:         FormattedDate.vb
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class FormattedDate
    Private _strMonth As String
    Private _strDay As String

    Public Property Month() As String
        Get
            Return _strMonth
        End Get
        Set(value As String)
            Dim intMonth As Integer
            Integer.TryParse(value, intMonth)
            If intMonth < 1 OrElse intMonth > 12 Then
                _strMonth = String.Empty
            Else
                _strMonth = value
            End If
        End Set
    End Property

    Public Property Day() As String
        Get
            Return _strDay
        End Get
        Set(value As String)
            _strDay = value
        End Set
    End Property

End Class
