' *****************************************************************
' Team Number: 55
' Team Member 1 Details: Lolo, P (220053780)
' Team Member 2 Details: Mukansi, N (220082219)
' Team Member 3 Details: Monare, TM (221022037)
' Team Member 4 Details: Baloyi, MP (221048179)
' Practical: Team Project
' Class name: Malaria
' *****************************************************************
Option Explicit On
Option Strict On
Option Infer Off

<Serializable()> Public Class Malaria
    Inherits Disease
    Private _Variant As String
    Private _Stages As Integer

    'Constructor
    Public Sub New(Symptom As Integer, Cause As Integer, Risk As Double, Var As String, Stages As Integer)
        MyBase.New(Symptom, Cause, Risk)
        _Variant = Var
        _Stages = Stages
    End Sub

    'Property Methods
    Public Property Var As String
        Get
            Return _Variant
        End Get
        Set(value As String)
            _Variant = value
        End Set
    End Property

    Public Property Stages As Integer
        Get
            Return _Stages
        End Get
        Set(value As Integer)
            _Stages = value
        End Set
    End Property

    'Methods
    Public Overrides Function MoreInfo() As String
        Dim Info As String
        Info = "ABOUT MALARIA " & Environment.NewLine & " A disease caused by a plasmodium parasite, transmitted by the bite of infected mosquitoes.
The severity of malaria varies based on the species of plasmodium.
Symptoms are chills, fever and sweating, usually occurring a few weeks after being bitten.
People travelling to areas where malaria is common typically take protective
drugs before, during and after their trip. Treatment includes antimalarial drugs."
        Return Info
    End Function

    Public Function Malaria_Info() As String
        Cause = CInt(InputBox("1-A single-celled parasite of the genus plasmodium" & Environment.NewLine &
                              "2.Mosquito bite" & Environment.NewLine &
                              "3.Blood transfusion" & Environment.NewLine &
                              "4.Organ transplant" & Environment.NewLine &
                               "5.The shared use of needles or syringes contaminated with blood",
                                 "How many were you exposed to?"))
        If Cause = 0 Then
            MsgBox("You may not have the disease cause you were not exposed to the causes, although it is wise to be aware of the causes")
        Else
            Symptom = CInt(InputBox("1-Fever
2-Chills
3-General feeling of discomfort
4-Headache
5-Nausea and vomiting
6-Diarrhea
7-Abdominal pain
8-Muscle or joint pain
9-Fatigue
10-Rapid breathing
11-Rapid heart rate
12-Cough", "How many symptoms have you experienced?"))


        End If
        Return MoreInfo()
    End Function

    'Calculating the risk of malaria
    Public Overrides Function CalcRisk() As String
        Risk = (Symptom / 12) * 100

        Select Case Risk
            Case < 50
                Return "Low Risk"
            Case 50 To 75
                Return "High Risk"
            Case > 75
                Return "Extreanly High Risk"
            Case Else
                Return "No Risk!"
        End Select
    End Function
End Class
