Imports System.IO
Imports System.Net
Imports System.Text

Module Downloader

    Sub Main()
        Console.WriteLine("KartRider Patch Downloader (KR)")
        System.Windows.Forms.Application.EnableVisualStyles()
        System.Windows.Forms.Application.Run(New frmSettings)

        Console.Write("Get patch files list...")

        Dim nfo2Data As String = GetPatchFilesWithHTTP(patchVersion)
        downloadFiles = New List(Of String)

        For i = 1 To UBound(Split(nfo2Data, vbCrLf)) - 1
            downloadFiles.Add(Split(Split(nfo2Data, vbCrLf)(i), """,")(0).Replace("""", ""))
        Next

        Console.WriteLine("OK")

        Console.WriteLine("Create patch files directory.")

        CreateDirectory("patch\" & patchVersion)
        CreateDirectory("patch\" & patchVersion & "\Data")
        CreateDirectory("patch\" & patchVersion & "\HackShield")
        CreateDirectory("patch\" & patchVersion & "\BlackCipher")
        CreateDirectory("patch\" & patchVersion & "\XignCode")

        Console.WriteLine("Start download...")

        For i = 0 To downloadFiles.Count - 1
            DownloadFile(i)
        Next

        Console.WriteLine("Download compelte. Press any key to exit.")
        Console.ReadLine()

    End Sub

    Sub DownloadFile(i As Integer)
        Console.Write("Download " & downloadFiles(i) & ".gz...")
        Dim Client As New WebClient
        Client.DownloadFile(New Uri(patchURL & patchVersion & "/" & downloadFiles(i).Replace("\", "/") & ".gz"), "patch\" & patchVersion & "\" & downloadFiles(i) & ".gz")
        Console.WriteLine("OK")
    End Sub

    Sub CreateDirectory(path As String)
        If Directory.Exists(path) = False Then
            Directory.CreateDirectory(path)
        End If
    End Sub

End Module
