' *****************************************************************
' Team Number: 55
' Team Member 1 Details: Lolo, P (220053780)
' Team Member 2 Details: Mukansi, N (220082219)
' Team Member 3 Details: Monare, TM (221022037)
' Team Member 4 Details: Baloyi, MP (221048179)
' Practical: Team Project
' Class name: TB
' *****************************************************************
Option Explicit On
Option Strict On
Option Infer Off

<Serializable()> Public Class TB
    Inherits Disease
    Private _Stages As Integer

    Public Sub New(Symptom As Integer, Cause As Integer, Risk As Double, Stages As Integer)
        MyBase.New(Symptom, Cause, Risk)
        _Stages = Stages
    End Sub

    Public Property Stages As Integer
        Get
            Return _Stages
        End Get
        Set(value As Integer)
            _Stages = value
        End Set
    End Property

    ''Methods
    Public Overrides Function MoreInfo() As String
        Dim Info As String
        Info = "ABOUT TUBERCULOSIS " & Environment.NewLine & "
A potentially serious infectious bacterial disease that mainly affects the lungs.
The bacteria that cause TB are spread when an infected person coughs or sneezes.
Most people infected with the bacteria that cause tuberculosis don't have symptoms. 
When symptoms do occur, they usually include a cough (sometimes blood-tinged), weight loss, night sweats and fever.
Treatment isn't always required for those without symptoms. 
Patients with active symptoms will require a long course of treatment involving multiple antibiotics."
        Return Info
    End Function

    Public Function TB_Info() As String

        Cause = CInt(InputBox("Microscopic droplets released into the air. This can happen when someone with the untreated, active form of tuberculosis 
1-coughs
2-speaks
3-sneezes 
4-spits 
5-laughs
6-sings", "Which one hae you expereinced?"))
        If Cause = 0 Then
            MsgBox("You may not have the disease cause you were not exposed to the causes, although it is wise to be aware of the causes")
        Else
            Symptom = CInt(InputBox("1-Coughing up blood or mucus
2-Chest pain, or pain with breathing or coughing
3-Unintentional weight loss
4-Fatigue
5-Fever
6-Night sweats
7-Chills
8-Loss of appetite", "How many symptoms have you experienced?"))
            If Symptom > 3 And Symptom < 8 Then
                MsgBox("Get tested")
            Else
                MoreInfo()
            End If
        End If
        Return MoreInfo()
    End Function

    Public Overrides Function CalcRisk() As String
        Risk = (Symptom / 8) * 100

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
