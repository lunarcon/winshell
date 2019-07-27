Imports System.IO

Public Class RecentActivities
    Private Sub RecentActivities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate("C:\Users\Aditya\AppData\Roaming\Microsoft\Windows\Recent", FlowLayoutPanel1, 1)
    End Sub
    Private Sub Populate(Fpsth As String, FlowPanel As FlowLayoutPanel, mode As Integer) ' 1 for pinned, 2 for all apps, 3 for search
        Do Until FlowPanel.Controls.Count = 0
            For Each c As Button In FlowPanel.Controls
                FlowPanel.Controls.Remove(c)
                c.Dispose()
            Next
        Loop

        If Not Fpsth Is Nothing AndAlso Directory.Exists(Fpsth) Then
            Try
                Dim il As Integer = 0
                For Each file As String In Directory.GetFiles(Fpsth)
                    il += 1
                    If mode = 1 And Path.GetFileNameWithoutExtension(file).Contains("desktop") = False Then
                        Dim appicon = AddIcon(file, 1)
                        Dim appname = Path.GetFileNameWithoutExtension(file)
                        Dim ab As New Button
                        ab.BackColor = My.Settings.ThemeColor
                        ab.FlatAppearance.BorderSize = 0
                        ab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                        ab.Font = New System.Drawing.Font("Segoe UI", 10.25!)
                        ab.ForeColor = System.Drawing.Color.White
                        ab.Margin = New Padding(13)
                        ab.Name = "  " & appname.ToString
                        ab.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
                        ab.Size = New System.Drawing.Size(290, 145)
                        ab.TabIndex = 0
                        ab.Text = appname.ToString
                        ab.FlatAppearance.BorderColor = Color.FromArgb(255, 20, 20, 20)
                        ab.TextAlign = System.Drawing.ContentAlignment.BottomLeft
                        ab.UseVisualStyleBackColor = False
                        ab.Visible = True
                        ab.BackgroundImage = appicon
                        ab.BackgroundImageLayout = ImageLayout.Center
                        ab.Tag = Path.GetExtension(file)
                        FlowPanel.Controls.Add(ab)
                    End If
                    If il >= 10 Then
                        Exit For
                    End If
                Next

            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Function AddIcon(fname As String, mode As Integer)
        Dim size
        If mode = 1 Then
            size = CType(ExtractLargeIconFromFile.ShellEx.IconSizeEnum.LargeIcon48, ExtractLargeIconFromFile.ShellEx.IconSizeEnum)
        ElseIf mode = 2 Then
            size = CType(ExtractLargeIconFromFile.ShellEx.IconSizeEnum.MediumIcon32, ExtractLargeIconFromFile.ShellEx.IconSizeEnum)
        End If
#Disable Warning BC42104
        Return ExtractLargeIconFromFile.ShellEx.GetBitmapFromFilePath(fname, size)
#Enable Warning BC42104
    End Function
End Class