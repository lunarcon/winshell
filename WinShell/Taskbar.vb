Imports Microsoft.Win32

Public Class Taskbar
    Private Function GetCurrentWallpaper() As String
        Dim rkWallPaper As RegistryKey = Registry.CurrentUser.OpenSubKey("Control Panel\Desktop", False)
        Dim WallpaperPath As String = rkWallPaper.GetValue("WallPaper").ToString()
        rkWallPaper.Close()
        Return WallpaperPath
    End Function
    Private Sub Taskbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Location = New Point(0, Screen.PrimaryScreen.WorkingArea.Height)
        Width = Screen.PrimaryScreen.WorkingArea.Width


    End Sub

End Class