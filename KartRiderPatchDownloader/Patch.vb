﻿Imports System.IO
Imports System.Net
Imports System.Text

Module Patch

    Dim win_http As New WinHttp.WinHttpRequest

    Public Function GetPatchFilesWithHTTP(ver As String) As String
        win_http.Open("GET", patchURL & ver & "/files.nfo2")
        win_http.Send()

        Return Win_HTTP.ResponseText
    End Function

    Public Function CheckPatchVersion(ver As String) As Boolean

        Dim nfoStr As String = GetPatchFilesWithHTTP(ver)
        If nfoStr.Contains("DO NOT edit this line") = False Then
            Return False
        End If

        Return True
    End Function

    Public Function CheckLatestPatchVersion(ver As String) As String

        Dim tmpVer As String = ver

        For i = 1 To 20
            If CheckPatchVersion(tmpVer) Then
                Console.WriteLine("Check latest patch version..." & tmpVer)
                i = 0
            End If

            tmpVer += 1
        Next

        Return tmpVer
    End Function
End Module