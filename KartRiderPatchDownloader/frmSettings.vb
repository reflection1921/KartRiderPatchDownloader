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

        Console.WriteLine("Select region..." & cbRegion.Text)

        patchVersion = ParseSavedVersion(locale)

    End Sub

    Private Sub btnCheckLatest_Click(sender As Object, e As EventArgs) Handles btnCheckLatest.Click
        patchVersion = CheckLatestPatchVersion(patchVersion)
        txtVersion.Text = patchVersion
        File.WriteAllText(locale & ".dat", patchVersion)
        Console.WriteLine("Select version..." & patchVersion)

        gbVersion.Enabled = False
        gbOption.Enabled = True
        btnApply.Enabled = True
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
        If CheckPatchVersion(txtVersion.Text) Then
            patchVersion = txtVersion.Text
            Console.WriteLine("Select version..." & patchVersion)

            gbVersion.Enabled = False
            gbOption.Enabled = True
            btnApply.Enabled = True
        Else
            MsgBox("Invalid patch version.", vbCritical, "KRPD")
        End If
    End Sub

    Private Sub chkExtractGZ_CheckedChanged(sender As Object, e As EventArgs) Handles chkExtractGZ.CheckedChanged
        If chkExtractGZ.Checked = True Then
            chkCopy.Enabled = True
        Else
            chkCopy.Enabled = False
        End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        isExtract = chkExtractGZ.Checked
        If chkCopy.Enabled And chkCopy.Checked Then
            isInstall = True
        Else
            isInstall = False
        End If

        Console.WriteLine("Extract *.gz..." & isExtract)
        Console.WriteLine("Copy to KartRider install path..." & isInstall)

        Me.Close()
    End Sub
End Class