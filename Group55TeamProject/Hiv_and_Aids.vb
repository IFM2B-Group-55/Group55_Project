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
        Info = "ABOUT HIV/AIDS " & Environment.NewLine & "What Is HIV?
HIV(human immunodeficiency virus) Is a virus that attacks cells In the body that help the body fight infection, making the person more susceptible To other infections And diseases. It Is spread through contact With a person's HIV-positive bodily fluids, most commonly during unprotected sex (sex without a condom or HIV medicine to prevent or treat HIV) or through sharing injection drug equipment. If HIV is not treated, it can lead to the disease AIDS (acquired immunodeficiency syndrome).
The human body Is incapable Of eliminating HIV, And there Is no effective HIV cure. So, once you have HIV, you will have it for the rest of your life.

        What Is AIDS?
        AIDS Is the advanced stage of HIV infection that occurs when the body's immune system is severely compromised by the virus.
In the United States, most people with HIV do Not develop AIDS because taking HIV medication on a daily basis as prescribed prevents the disease from progressing. When a person with HIV has progressed to AIDS, their CD4 cell count falls below 200 cells per cubic millimeter of blood (200 cells/mm3). (CD4 counts in people with a healthy immune system range between 500 And 1,600 cells/mm3.) Or, regardless of CD4 count, they develop one Or more opportunistic infections.

        How Do I Know If I Have HIV?
        The only sure way To know If you have HIV Is To Get tested. The testing process Is relatively simple. You can request an HIV test from your doctor. They are also available at many medical clinics, substance abuse programs, community health centers, And hospitals.A home testing kit can also be purchased at a pharmacy or online. Use the HIV Services Locator to find an HIV testing location near you. Self-testing for HIV is also an option. Self-testing enables people to take an HIV test and receive their results in the privacy of their own home or another private location. A self-test kit can be purchased at a pharmacy or online. Self-test kits are also available for free from some health departments or community-based organizations."
        Return Info
    End Function

    Public Function Hiv_Aids_Info() As String
        Cause = CInt(InputBox("1-Having unprotected anal or vaginal sex
2-Having another sexually transmitted infection (STI) such as syphilis, herpes, chlamydia, gonorrhoea and bacterial vaginosis;
3-Sharing contaminated needles, syringes and other injecting equipment and drug solutions when injecting drugs;
4-Receiving unsafe injections, blood transfusions and tissue transplantation, and medical procedures that involve unsterile cutting or piercing; and
5-Experiencing accidental needle stick injuries, including among health workers", "How many were you exposed to?"))
        If Cause = 0 Then
            MsgBox("You may not have the disease cause you were not exposed to the causes, although it is wise to be aware of the causes")
        Else
            Symptom = CInt(InputBox("1-Swollen lymph nodes, 
2-Weight loss, 
3-Fever, 
4-Diarrhoea
5-cough", "How many symptoms have you experienced?"))
            If Symptom > 3 And Symptom < 5 Then
                MsgBox("Get tested and to prevent the disease from spreading incase you test positive you
have the option to abstain from (not have) sex.
You can have more secure sex.
When you bleed, you can take general precautions to avoid transmission.
Take post-exposure prophylaxis (treatment) as soon as possible after being exposed to HIV.
Take anti-retroviral therapy if you are a mother to reduce the risk of HIV transmission to your unborn child.
Medical researchers hope that one day they will be able to develop an HIV vaccine that will prevent people from becoming infected with HIV.")
            Else
                MoreInfo()
            End If
        End If
        Return MoreInfo()
    End Function

    Public Overrides Function CalcRisk() As String
        Risk = (Symptom / 5) * 100

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
