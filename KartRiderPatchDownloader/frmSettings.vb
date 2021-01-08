Imports System.IO

Public Class frmSettings

    Dim locale As String

    Private Sub btnRegionApply_Click(sender As Object, e As EventArgs) Handles btnRegionApply.Click
        '//tw: http://tw.cdnpatch.kartrider.beanfun.com/kartrider/(version)/files.nfo2 '//2095
        '//kr: "http://kart.dn.nexoncdn.co.kr/patch/" & ver & "/files.nfo2" '//4693

        If cbRegion.SelectedIndex = 0 Then
            patchURL = "http://kart.dn.nexoncdn.co.kr/patch/"
            locale = "kr"
        ElseIf cbRegion.SelectedIndex = 1 Then
            patchURL = "http://tw.cdnpatch.kartrider.beanfun.com/kartrider/"
            locale = "tw"
        Else
            MsgBox("Invalid Region. Select again please.", vbCritical, "KRPD")
            Return
        End If

        gbRegion.Enabled = False
        gbVersion.Enabled = True

        Console.WriteLine("Select Region..." & cbRegion.Text)

        patchVersion = ParseSavedVersion(locale)

    End Sub

    Private Sub btnCheckLatest_Click(sender As Object, e As EventArgs) Handles btnCheckLatest.Click
        patchVersion = CheckLatestPatchVersion(patchVersion)
        File.WriteAllText(locale & ".dat", patchVersion)
    End Sub

    Function ParseSavedVersion(_locale As String) As String
        If File.Exists(_locale & ".dat") Then
            Return File.ReadAllText(_locale & ".dat")
        Else
            If _locale = "kr" Then
                Return "4693"
            ElseIf _locale = "tw" Then
                Return "2095"
            Else
                Return "4693"
            End If
        End If

    End Function

    Private Sub btnCheckManually_Click(sender As Object, e As EventArgs) Handles btnCheckManually.Click

    End Sub
End Class