' *****************************************************************
' Team Number: 55
' Team Member 1 Details: Lolo, P (220053780)
' Team Member 2 Details: Mukansi, N (220082219)
' Team Member 3 Details: Monare, TM (221022037)
' Team Member 4 Details: Baloyi, MP (221048179)
' Practical: Team Project
' Class name: frmDiseaseCombat

Option Explicit On
Option Strict On
Option Infer Off

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmDiseaseCombat
    Private File As FileStream
    Private BF As BinaryFormatter
    Private Filename As String = "Millenuim_Goal_6.Ifm"
    Private ObjDisease() As Disease
    Private numDisease As Integer = 0
    Private numUsers As Integer
    Private Users() As User

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim name As String
        Dim age As Integer
        Dim id As Double
        numUsers += 1
        ReDim Preserve Users(numUsers)

        name = InputBox("Enter Name")
        age = CInt(InputBox("Enter Age"))
        id = CDbl(InputBox("Enter Id"))

        Users(numUsers) = New User(name, age, id, numUsers)
        MsgBox("your user Number is " & CStr(numUsers))
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim nUser As Integer
        nUser = CInt(InputBox("Enter User Number"))

        txtDisplay.Text = Users(nUser).Display
    End Sub

    Private Sub btnActivity_Click(sender As Object, e As EventArgs) Handles btnActivity.Click

        numDisease += 1
        ReDim Preserve ObjDisease(numDisease)
        Dim Disease_Type As Integer
        Dim Symptom As Integer
        Dim Cause As Integer
        Dim Risk As Double
        Dim Species As String = " "
        Dim Stages As Integer
        Dim Var As String = " "
        Disease_Type = CInt(InputBox(" : 1 - Hiv/Aids , 2 - Malaria, 3 - TB"))

        Select Case Disease_Type
            Case 1 'Hiv/Aids
                txtDisplay.Clear()
                Dim objHiv_Aids As Hiv_and_Aids = New Hiv_and_Aids(Symptom, Cause, Risk, Species) ' intiate

                objHiv_Aids.Hiv_Aids_Info()
                txtRisk.Text = objHiv_Aids.CalcRisk()


                'Upcasting
                ObjDisease(numDisease) = objHiv_Aids

            Case 2 'Malaria

                Dim objMalaria As Malaria = New Malaria(Symptom, Cause, Risk, Var, Stages) ' initiate
                objMalaria.Malaria_Info()
                txtRisk.Text = objMalaria.CalcRisk()


                'upcasting
                ObjDisease(numDisease) = objMalaria
            Case 3 'TB
                txtDisplay.Clear()
                Dim objTB As TB = New TB(Symptom, Cause, Risk, Stages) ' initiate
                objTB.TB_Info()
                txtRisk.Text = objTB.CalcRisk()


                'upcasting
                ObjDisease(numDisease) = objTB

        End Select

        txtDisplay.Text = " "

        For d As Integer = 1 To numDisease
            'polymorphism
            txtDisplay.Clear()
            txtDisplay.Text &= ObjDisease(d).MoreInfo() & Environment.NewLine
        Next d
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        File = New FileStream(Filename, FileMode.Create, FileAccess.Write) 'initite
        BF = New BinaryFormatter() 'initiate
        For h As Integer = 1 To numDisease
            BF.Serialize(File, ObjDisease(h))
        Next
        FileClose()
        File = Nothing
        BF = Nothing
        MessageBox.Show("Information Saved")
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        txtDisplay.Clear()
        File = New FileStream(Filename, FileMode.Open, FileAccess.Read) 'initiate
        BF = New BinaryFormatter() ' initiate
        While File.Position < File.Length
            Dim d As Disease
            d = DirectCast(BF.Deserialize(File), Disease)
            txtDisplay.Text &= d.MoreInfo() & Environment.NewLine & Environment.NewLine
        End While
        File.Close()
    End Sub
End Class
