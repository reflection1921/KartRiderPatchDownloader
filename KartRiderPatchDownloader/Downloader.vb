Imports System.IO
Imports System.Net
Imports System.Text

Module Downloader

    Sub Main()
        Console.WriteLine("KartRider Patch Downloader (KR)")
        System.Windows.Forms.Application.EnableVisualStyles()
        System.Windows.Forms.Application.Run(New frmSettings)

        'CreateDirectory("patch\" & KRVersion)
        'CreateDirectory("patch\" & KRVersion & "\Data")
        'CreateDirectory("patch\" & KRVersion & "\HackShield")
        'CreateDirectory("patch\" & KRVersion & "\BlackCipher")
        'CreateDirectory("patch\" & KRVersion & "\XignCode")
    End Sub

    Sub CreateDirectory(path As String)
        If Directory.Exists(path) = False Then
            Directory.CreateDirectory(path)
        End If
    End Sub





    Function GetPatchFileList(ver As String) As Boolean

        '//tw: http://tw.cdnpatch.kartrider.beanfun.com/kartrider/(version)/files.nfo2 '//2095
        '//kr: "http://kart.dn.nexoncdn.co.kr/patch/" & ver & "/files.nfo2"
        Dim getReq As HttpWebRequest = WebRequest.Create("http://kart.dn.nexoncdn.co.kr/patch/" & ver & "/files.nfo2")

        With getReq
            .Method = "GET"
            .UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0"
        End With

        Dim response As HttpWebResponse = getReq.GetResponse()

        Dim html As String = Nothing
        Using sr As New StreamReader(response.GetResponseStream, Encoding.UTF8)
            html = sr.ReadToEnd
        End Using

        If html.Contains("DO NOT edit this line") = False Then
            Return False
        End If

        For i = 1 To UBound(Split(html, vbCrLf)) - 1
            Dim downloadFilePath As String = Split(Split(html, vbCrLf)(i), """,")(0)
            downloadFilePath = Replace(downloadFilePath, """", "") & ".gz"
            downloadFiles.Add(downloadFilePath)
        Next

        Return True


    End Function

End Module
