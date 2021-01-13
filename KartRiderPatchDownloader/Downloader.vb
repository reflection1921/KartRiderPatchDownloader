Imports System.IO
Imports System.Net
Imports System.Text

Module Downloader

    Dim _patchVersionPath As String

    Sub Main()
        Console.WriteLine("KartRider Patch Downloader (KR)")

        System.Windows.Forms.Application.EnableVisualStyles()
        System.Windows.Forms.Application.Run(New frmSettings)

        _patchVersionPath = locale & "_" & patchVersion

        Console.Write("Get patch files list...")

        Dim nfo2Data As String = GetPatchFilesWithHTTP(patchVersion)
        downloadFiles = New List(Of String)

        For i = 1 To UBound(Split(nfo2Data, vbCrLf)) - 1
            downloadFiles.Add(Split(Split(nfo2Data, vbCrLf)(i), """,")(0).Replace("""", ""))
        Next

        Console.WriteLine("OK")

        Console.WriteLine("Create patch files directory.")

        CreateDirectory("patch")
        CreateDirectory("patch\" & _patchVersionPath)
        CreateDirectory("patch\" & _patchVersionPath & "\Data")
        CreateDirectory("patch\" & _patchVersionPath & "\HackShield")
        CreateDirectory("patch\" & _patchVersionPath & "\BlackCipher")
        CreateDirectory("patch\" & _patchVersionPath & "\XignCode")

        Console.WriteLine("Start download...")

        For i = 0 To downloadFiles.Count - 1
            DownloadFile(i)
        Next

        '//Extract gz
        If isExtract Then
            For i = 0 To downloadFiles.Count - 1
                Console.Write("Decompress " & downloadFiles(i) & ".gz...")
                Decompress(New FileInfo("patch\" & _patchVersionPath & "\" & downloadFiles(i) & ".gz"))
                File.Delete("patch\" & _patchVersionPath & "\" & downloadFiles(i) & ".gz")
                Console.WriteLine("OK")
            Next
        End If

        Console.WriteLine("Download compelte. Press any key to exit.")
        Console.ReadLine()

    End Sub

    Sub DownloadFile(i As Integer)
        Console.Write("Download " & downloadFiles(i) & ".gz...")
        Dim Client As New WebClient
        Client.DownloadFile(New Uri(patchURL & patchVersion & "/" & downloadFiles(i).Replace("\", "/") & ".gz"), "patch\" & _patchVersionPath & "\" & downloadFiles(i) & ".gz")
        Console.WriteLine("OK")
    End Sub

    Sub CreateDirectory(path As String)
        If Directory.Exists(path) = False Then
            Directory.CreateDirectory(path)
        End If
    End Sub

End Module
