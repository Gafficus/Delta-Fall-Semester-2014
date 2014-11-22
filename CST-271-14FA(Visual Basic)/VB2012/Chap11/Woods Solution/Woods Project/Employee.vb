' Name:         Employee.vb
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class Employee
    Public Property Number As String
    Public Property EmpName As String

    Public Sub New()
        _Number = String.Empty
        _EmpName = String.Empty
    End Sub

    Public Sub New(ByVal strNum As String,
                   ByVal strName As String)
        _Number = strNum
        _EmpName = strName
    End Sub

    Public Function GetGross(ByVal dblSalary As Double) As Double
        ' calculates the gross pay for salaried
        ' employees, who are paid twice per month

        Return dblSalary / 24
    End Function

    Public Function GetGross(ByVal dblHours As Double,
                             ByVal dblRate As Double) As Double
        ' calculates the weekly gross pay for hourly employees

        Return dblHours * dblRate
    End Function
End Class
