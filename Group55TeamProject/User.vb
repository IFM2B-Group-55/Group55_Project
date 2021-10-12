' *****************************************************************
' Team Number: 55
' Team Member 1 Details: Lolo, P (220053780)
' Team Member 2 Details: Mukansi, N (220082219)
' Team Member 3 Details: Monare, TM (221022037)
' Team Member 4 Details: Baloyi, MP (221048179)
' Practical: Team Project
' Class name: User
' *****************************************************************
Option Explicit On
Option Strict On
Option Infer Off

<Serializable()> Public Class User
    Private _name As String
    Private _age As Integer
    Private _id As Double
    Private Shared _numUser As Integer

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Age() As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    Public Property Id() As Double
        Get
            Return _id
        End Get
        Set(value As Double)
            _id = value
        End Set
    End Property

    Public Shared Property numUser As Integer
        Get
            Return numUser
        End Get
        Set(value As Integer)
            _numUser = value
        End Set
    End Property

    Public Function Display() As String
        Dim disp As String
        disp = "Name: " & _name & Environment.NewLine &
                "Age: " & CStr(_age) & Environment.NewLine &
                "Id: " & CStr(_id) & Environment.NewLine
        Return disp
    End Function

    Public Sub New(name As String, age As Integer, id As Double, numuser As Integer)
        _name = name
        _age = age
        _id = id
        _numUser = numuser
    End Sub

End Class
