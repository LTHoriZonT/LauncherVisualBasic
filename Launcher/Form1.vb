Imports System.Net
Imports System.IO
Imports System.IO.Compression
Public Class Form1
    WithEvents Webclient1 As New WebClient
    WithEvents Webclient2 As New WebClient
    Dim versaoatual As String = "1.0.0.0"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim versaodosite As String = Webclient1.DownloadString("https://dl.dropboxusercontent.com/s/fuhca414wikfgis/versao.txt?dl=1&token_hash=AAEh6crMalj09q8FJD8UDtWfBwjV8bxxP7KOhYYDFiVkEQ")
        If versaodosite > versaoatual Then
            MessageBox.Show("Atualização Disponivel   >>>...113MB...<<< ")
            Webclient2.DownloadFileAsync(New Uri("https://dl.dropboxusercontent.com/s/sr5fp3nqe8nb9gp/att.zip?dl=1&token_hash=AAF-kNW2L9Dh7faAa4kvAVbWfvJG4X4iLSmbBqhvc4TdAA"), "C:\Program Files\att.zip")
            MessageBox.Show("Launcher Feito por ANGEL_GM & Vandro")
        End If
    End Sub

    Private Sub Webclient2_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles Webclient2.DownloadProgressChanged
        ProgressBar1.Maximum = e.TotalBytesToReceive
        ProgressBar1.Value = e.BytesReceived
    End Sub
    Private Sub Extrair()
        If MessageBox.Show("Instalando.. Espere Alguns Segundos") Then

        End If
        Dim Username As String = Environment.UserName
        Dim AppData As String = "C:\Users\" & Username & "\AppData\Roaming"
        Dim AD As String = AppData & "\.minecraft"

        Dim sc As New Shell32.Shell
        IO.Directory.CreateDirectory(AD)
        Dim _pasta As Shell32.Folder = sc.NameSpace(AD)
        Dim _arquivo As Shell32.Folder = sc.NameSpace("C:\Program Files\att.zip")
        _pasta.CopyHere(_arquivo.Items, 4)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Extrair()
        If MessageBox.Show("Instalado.. Ja pode Jogar!!") Then

        End If
    End Sub
    Private Sub ProgressBar2_Click(sender As Object, e As EventArgs) Handles ProgressBar2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
End Class
