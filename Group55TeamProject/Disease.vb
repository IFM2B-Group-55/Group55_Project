' *****************************************************************
' Team Number: 55
' Team Member 1 Details: Lolo, P (220053780)
' Team Member 2 Details: Mukansi, N (220082219)
' Team Member 3 Details: Monare, TM (221022037)
' Team Member 4 Details: Baloyi, MP (221048179)
' Practical: Team Project
' Class name: Disease
' *****************************************************************
Option Explicit On
Option Strict On
Option Infer Off

<Serializable()> Public Class Disease
    Private _Symptom As Integer
    Private _Cause As Integer
    Private _Risk As Double     'To be reviewed ... There might be no need for it

    'Constrructor
    Public Sub New(Symptom As Integer, Cause As Integer, Risk As Double)
        _Symptom = Symptom
        _Cause = Cause
        _Risk = Risk

    End Sub

    'Property methods 
    Public Property Symptom() As Integer
        Get
            Return _Symptom
        End Get
        Set(value As Integer)
            _Symptom = value
        End Set
    End Property

    Public Property Cause() As Integer
        Get
            Return _Cause
        End Get
        Set(value As Integer)
            _Cause = value
        End Set
    End Property

    Public Property Risk() As Double
        Get
            Return _Risk
        End Get
        Set(value As Double)
            _Risk = value
        End Set
    End Property

    'Methods
    'Çalculating risk for an individual
    Public Overridable Function CalcRisk() As String
        Return "Risk : 0.00 %"
    End Function

    Public Overridable Function MoreInfo() As String
        Return "Nothing"
    End Function

    'Public Overridable Function Display() As String
    '    Dim Temp As String
    '    Temp = "Why"
    '    Return Temp
    'End Function

End Class
