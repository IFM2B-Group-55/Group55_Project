' *****************************************************************
' Team Number: 55
' Team Member 1 Details: Lolo, P (220053780)
' Team Member 2 Details: Mukansi, N (220082219)
' Team Member 3 Details: Monare, TM (221022037)
' Team Member 4 Details: Baloyi, MP (221048179)
' Practical: Team Project
' Class name: Hiv_and_Aids
' *****************************************************************
Option Explicit On
Option Strict On
Option Infer Off

<Serializable()> Public Class Hiv_and_Aids
    Inherits Disease
    Private _Species As String

    Public Sub New(Symptom As Integer, Cause As Integer, Risk As Double, Species As String)
        MyBase.New(Symptom, Cause, Risk)
        _Species = Species
    End Sub

    Public Property Species As String
        Get
            Return _Species
        End Get
        Set(value As String)
            _Species = value
        End Set
    End Property

    'Methods

    Public Overrides Function MoreInfo() As String
        Dim Info As String
        Info = "ABOUT HIV/AIDS " & Environment.NewLine & "A virus that attacks cells that help the body fight infection. 
It is spread by contact with certain bodily fluids of a person with HIV, most commonly during
unprotected sex, or through sharing injection during iquipment.
N.B. If left untreated, HIV can lead to the disease AIDS
The human body can't get rid of HIV and no effective HIV cure exists. So, once you have HIV, you have it for life."
        Return Info
    End Function

    Public Function Hiv_Aids_Info() As String

        Cause = CInt(InputBox("1-Having unprotected anal or vaginal sex
2-Having another sexually transmitted infection (STI) such as syphilis, herpes, chlamydia, gonorrhoea and bacterial vaginosis;
3-Sharing contaminated needles, syringes and other injecting equipment and drug solutions when injecting drugs;
4-Receiving unsafe injections, blood transfusions and tissue transplantation, and medical procedures that involve unsterile cutting or piercing; and
5-Experiencing accidental needle stick injuries, including among health workers", "How many were you exposed to?"))
        If Cause = 0 Then
            MsgBox("You need to take more drugs")
        Else
            Symptom = CInt(InputBox("1-Swollen lymph nodes, 
2-Weight loss, 
3-Fever, 
4-Diarrhoea
5-cough", "How many symptomds have you experienced?"))
            If Symptom > 3 Then
                MsgBox("Get tested")
            Else
                MoreInfo()

            End If

        End If
        Return MoreInfo()
    End Function

    'Public Overrides Function Display() As String

    'End Function

End Class
