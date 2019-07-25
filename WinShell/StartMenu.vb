Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Management
Imports System.Xml
Imports System.Windows.Threading
Imports System.Windows.Forms
Imports IWshRuntimeLibrary
Imports System.Windows.Interop
Imports System.Windows.Shell

Public Class StartMenu

    Dim sdr As Control
    Dim pinnedapps As String = CStr("C:\Users\" & GetUserName() & "\AppData\Roaming\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar\")
    Dim allapps As String = CStr("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\")
    Dim navFld As String = pinnedapps
    Dim greet As String
    Dim bmp As New PictureBox
    Dim objShell = CreateObject("Shell.Application")

    Private Sub editoptopen(sender As Object, e As EventArgs)

    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub StartMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundthethingy(Me, 20)
        Backfrm.Show()

        If My.Settings.start_in_non_tile_mode = True Then
            Panel4.Visible = False
            Panel2.Visible = False
            Width = Panel1.Width - 10
            IndexBar.Visible = False
            CenterToScreen()
            Label1.Text = "This is an experimental feature and hence has a lot of bugs. Currently for testing purposes only. If you wish to continue using the app normally, set the flag you changed to its default value."
        Else
            Label1.Text += vbNewLine & vbNewLine & "Tip: You can now pin and unpin apps! Right click an app tile for options."
        End If
        If My.Settings.openclose_animation = True Then
            Timer2.Enabled = True
            Timer2.Start()
        Else
            If My.Settings.transparent = True Then
                Opacity = 0.94
            Else
                Opacity = 1
            End If
        End If
        ' Taskbar.Width = Screen.PrimaryScreen.WorkingArea.Width
        ' Taskbar.Show()
        If Now.Hour < 12 And Now.Hour > 4 Then
            greet = "morning"
        ElseIf Now.Hour >= 12 And Now.Hour < 16 Then
            greet = "afternoon"
        ElseIf Now.Hour >= 16 And Now.Hour <= 20 Then
            greet = "evening"
        Else
            greet = "night"
        End If

        roundthethingy(SearchBoxPadding, 12)
        Populate(pinnedapps, FlowLayoutPanel1, 1)
        bmp.BackgroundImage = GetUserTile(My.User.Name.ToString)
        RoundPic(bmp)
        ProfilePic.BackgroundImage = bmp.BackgroundImage
        If My.Settings.show_pfp_outside_form = False Then
            ProfilePic.Visible = True
        Else
            ProfilePic.Visible = False
            OutPfp.Show()
            OutPfp.ProfilePic.BackgroundImage = bmp.BackgroundImage
            UserGreet.Location = New Point(UserGreet.Location.X, UserGreet.Location.Y - 70)
            SearchBoxPadding.Location = New Point(SearchBoxPadding.Location.X, SearchBoxPadding.Location.Y - 70)
            Label1.Text = "This is an experimental feature and hence has a lot of bugs. Currently for testing purposes only. If you wish to continue using the app normally, set the flag you changed to its default value."
        End If

        UserGreet.Text = "Good " & greet & ", " & GetUserName()
        roundthethingy(ProfilePic, 100)
        roundthethingy(SearchBtn, 25)
        roundthethingy(Scrollthing, 3)
        For Each f As Control In Me.Controls
            If f.Name.Contains("Search") = False Then
                AddHandler f.MouseClick, AddressOf MEME
            End If
        Next
        Dim at As New Panel, pin As New Button, fileloc As New Button
        at.Name = "CTMENUPANEL"
        pin.Name = "PIN"
        fileloc.Name = "FILELOC"
        at.BackColor = Color.FromArgb(255, 40, 40, 40)
        at.Width = 145
        at.Controls.Add(fileloc)
        at.Controls.Add(pin)
        at.Visible = False
        pin.Dock = System.Windows.Forms.DockStyle.Left
        pin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        pin.FlatAppearance.BorderSize = 0
        pin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        pin.Font = New System.Drawing.Font("Segoe MDL2 Assets", 13.0!)
        pin.ForeColor = System.Drawing.SystemColors.ButtonFace
        pin.Location = New System.Drawing.Point(0, 0)
        pin.Name = "Ico4"
        pin.Size = New System.Drawing.Size(40, 34)
        pin.TabIndex = 27
        pin.Text = ""
        pin.UseVisualStyleBackColor = True
        fileloc.Dock = System.Windows.Forms.DockStyle.Fill
        fileloc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        fileloc.FlatAppearance.BorderSize = 0
        fileloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        fileloc.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        fileloc.ForeColor = System.Drawing.SystemColors.ButtonFace
        fileloc.Location = New System.Drawing.Point(41, 0)
        fileloc.Name = "Button1"
        fileloc.Size = New System.Drawing.Size(90, 34)
        fileloc.TabIndex = 28
        fileloc.Text = "Open location"
        fileloc.UseVisualStyleBackColor = True
        at.Height = pin.Width
        at.BringToFront()
        Me.Controls.Add(at)
        AddHandler pin.Click, AddressOf pinunpin
        roundthethingy(at, 10)

    End Sub

    Private Sub ShowOptions(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        Dim h = Controls.Find("CTMENUPANEL", 1)
        For Each ll As Control In h
            If e.Button = MouseButtons.Right And ll.Tag = "" Then
                Dim v = Controls.Find("CTMENUPANEL", 1)
                For Each dd As Control In v
                    dd.Tag = sender.text
                    sender.text = ""
                    dd.Visible = True
                    dd.BringToFront()
                    dd.Location = New Point(sender.location.x + Panel1.Width - dd.Width + 145, sender.location.y + 133)
                    sdr = sender

                    If sender.Width = 145 Then
                        Dim x = dd.Controls.Find("Ico4", 1)

                        For Each g As Button In x
                            g.Text = ""
                        Next
                    Else
                        dd.Location = New Point(sender.location.x + Panel1.Width - dd.Width + 200, sender.location.y + 32)
                        Dim b = dd.Controls.Find("Ico4", 1)
                        For Each g As Button In b
                            g.Text = ""
                        Next
                    End If
                Next

            End If
        Next
    End Sub
    Private Sub pinunpin()
        Dim appnom = sdr.Text & ".lnk"
        Dim v = Controls.Find("CTMENUPANEL", 1)
        For Each dd As Control In v
            appnom = dd.Tag
            If sdr.Width = 145 Then
                My.Computer.FileSystem.DeleteFile(pinnedapps & appnom & ".lnk")
                Populate(pinnedapps, FlowLayoutPanel1, 1)
            Else
                appnom = dd.Tag.Remove(0, 5) & ".lnk"
                Try
                    My.Computer.FileSystem.CopyFile(allapps & appnom, pinnedapps & appnom)
                Catch ex As Exception
                End Try
                PinnedBtn.PerformClick()
            End If
            dd.Tag = ""
        Next
        Dim g = Controls.Find("CTMENUPANEL", 1)
        For Each ff As Control In v
            ff.Visible = False
        Next

    End Sub
    Private Sub MEME()
        Dim v = Controls.Find("CTMENUPANEL", 1)
        If My.Settings.show_pfp_outside_form = True Then
            OutPfp.BringToFront()
        End If
        For Each dd As Control In v
            If dd.Visible = True Then
                sdr.Text = dd.Tag
                dd.Visible = False
                dd.Tag = ""
            End If
        Next
        If SearchBox.BackColor <> Color.FromArgb(255, 10, 10, 10) Then
            SearchBox.BackColor = Color.FromArgb(255, 10, 10, 10)
            SearchBoxPadding.BackColor = Color.FromArgb(255, 10, 10, 10)
            SearchBox.ForeColor = SystemColors.Menu
            SearchBtn.ForeColor = SystemColors.ControlLight
            SearchBox.Text = "Search"
            ActiveControl = Nothing
        End If
    End Sub
    Private Sub createjlist()

    End Sub
    Private Sub RoundPic(pic As Control)
        Dim originalImage = pic.BackgroundImage
        pic.BackgroundImageLayout = ImageLayout.Zoom
        Dim croppedImage As New Bitmap(originalImage.Width, originalImage.Height)
        'Prepare to draw on the new image.
        Using g = Graphics.FromImage(croppedImage)
            Dim path As New GraphicsPath
            path.AddEllipse(0, 0, croppedImage.Width, croppedImage.Height)
            Dim reg As New Region(path)
            'Draw only within the specified ellipse.
            g.Clip = reg
            g.DrawImage(originalImage, Point.Empty)
        End Using
        'Display the new image.
        pic.BackgroundImage = croppedImage
    End Sub
    <DllImport("shell32", EntryPoint:="#261", CharSet:=CharSet.Unicode, PreserveSig:=False)>
    Public Shared Sub GetUserTilePath(username As String, whatever As UInt32, picpath As StringBuilder, maxLength As Integer)
    End Sub
    Declare Function GetUserName Lib "advapi32.dll" Alias _
       "GetUserNameA" (ByVal lpBuffer As String,
       ByRef nSize As Integer) As Integer
    Public Function GetUserName() As String
        Dim iReturn As Integer
        Dim userName As String
        userName = New String(CChar(" "), 50)
        iReturn = GetUserName(userName, 50)
        GetUserName = userName.Substring(0, userName.IndexOf(Chr(0)))
    End Function
    Public Function GetUserTilePath(username As String) As String
        Dim sb As StringBuilder
        sb = New StringBuilder(1000)
        GetUserTilePath(username, 2147483648, sb, sb.Capacity)
        Return sb.ToString()
    End Function

    Public Function GetUserTile(username As String) As Image
        Return Image.FromFile(GetUserTilePath(username))
    End Function
    Private Sub roundthethingy(oj As Object, rad As Integer)
        If My.Settings.round_edges = True Then
            Dim p As New Drawing2D.GraphicsPath()
            p.StartFigure()
            p.AddArc(New Rectangle(0, 0, rad, rad), 180, 90)
            p.AddLine(rad, 0, oj.Width - rad, 0)
            p.AddArc(New Rectangle(oj.Width - rad, 0, rad, rad), -90, 90)
            p.AddLine(oj.Width, rad, oj.Width, oj.Height - rad)
            p.AddArc(New Rectangle(oj.Width - rad, oj.Height - rad, rad, rad), 0, 90)
            p.AddLine(oj.Width - rad, oj.Height, rad, oj.Height)
            p.AddArc(New Rectangle(0, oj.Height - rad, rad, rad), 90, 90)
            p.CloseFigure()
            oj.Region = New Region(p)
        End If
    End Sub
    Private Sub OpenFile(sender As Button, e As EventArgs)
        If sender.Tag <> "&addapp" Then
            Dim fullname = sender.Name.ToString
            Dim ext As String = "\"
            ext = sender.Tag.ToString
            Try
                Dim path = navFld + fullname + ext
                Process.Start(path)
            Catch
                sender.BackgroundImage = PictureBox1.Image
                FlowLayoutPanel1.Controls.Remove(sender)
            End Try
            If My.Settings.openclose_animation = True Then
                Timer3.Enabled = True
                Timer3.Start()
            End If
        Else
            AllAppsBtn.PerformClick()
        End If
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
                For Each file As String In Directory.GetFiles(Fpsth)
                    If mode = 1 And Path.GetFileNameWithoutExtension(file).Contains("desktop") = False Then
                        Dim appicon = AddIcon(file, 1)
                        Dim appname = Path.GetFileNameWithoutExtension(file)
                        Dim ab As New Button
                        ab.BackColor = Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(155, Byte), Integer))
                        ab.FlatAppearance.BorderSize = 0
                        ab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                        ab.Font = New System.Drawing.Font("Segoe UI", 10.25!)
                        ab.ForeColor = System.Drawing.Color.White
                        ab.Margin = New Padding(13)
                        ab.Name = appname.ToString
                        ab.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
                        ab.Size = New System.Drawing.Size(145, 145)
                        ab.TabIndex = 0
                        ab.Text = appname.ToString
                        ab.FlatAppearance.BorderColor = Color.FromArgb(255, 20, 20, 20)
                        ab.TextAlign = System.Drawing.ContentAlignment.BottomCenter
                        ab.UseVisualStyleBackColor = False
                        ab.Visible = True
                        ab.BackgroundImage = appicon
                        ab.BackgroundImageLayout = ImageLayout.Center
                        ab.Tag = Path.GetExtension(file)
                        FlowLayoutPanel1.Controls.Add(ab)
                        AddHandler ab.Click, AddressOf OpenFile
                        roundthethingy(ab, 10)
                        AddHandler ab.MouseDown, AddressOf ShowOptions
                    ElseIf mode = 2 Then
                        Dim appicon = AddIcon(file, 2)
                        Dim appname = Path.GetFileNameWithoutExtension(file)
                        Dim ab As New Button
                        ab.BackColor = Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
                        ab.FlatAppearance.BorderSize = 0
                        ab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                        ab.Font = New System.Drawing.Font("Segoe UI", 12.25!)
                        ab.ForeColor = System.Drawing.Color.White
                        ab.Margin = New Padding(11)
                        ab.Name = appname.ToString
                        ab.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
                        ab.Size = New System.Drawing.Size(500, 50)
                        ab.TabIndex = 0
                        ab.Text = appname.ToString
                        ab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                        ab.Text = ab.Text.PadLeft(ab.Text.Length + 5)
                        ab.ImageAlign = ContentAlignment.MiddleLeft
                        ab.UseVisualStyleBackColor = False
                        ab.Visible = True
                        ab.Image = appicon
                        ab.TextImageRelation = TextImageRelation.ImageBeforeText
                        ab.FlatAppearance.BorderColor = Color.FromArgb(255, 20, 20, 20)
                        ab.Tag = Path.GetExtension(file)
                        FlowLayoutPanel1.Controls.Add(ab)
                        AddHandler ab.Click, AddressOf OpenFile
                        If My.Settings.round_allapps_list = True Then
                            roundthethingy(ab, 20)
                        End If
                        AddHandler ab.MouseDown, AddressOf ShowOptions
                    ElseIf mode = 3 Then
                        If UCase(Path.GetFileNameWithoutExtension(file)).Contains(UCase(SearchBox.Text)) Or UCase(SearchBox.Text).Contains(UCase(Path.GetFileNameWithoutExtension(file))) Then
                            If UCase(Path.GetFileNameWithoutExtension(file)).StartsWith(UCase(SearchBox.Text)) Or UCase(Path.GetFileNameWithoutExtension(file)).Contains(UCase(" " & SearchBox.Text)) Then
                                Dim appicon = AddIcon(file, 2)
                                Dim appname = Path.GetFileNameWithoutExtension(file)
                                Dim ab As New Button
                                ab.BackColor = Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
                                ab.FlatAppearance.BorderSize = 0
                                ab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                                ab.Font = New System.Drawing.Font("Segoe UI", 12.25!)
                                ab.ForeColor = System.Drawing.Color.White
                                ab.Margin = New Padding(11)
                                ab.Name = appname.ToString
                                ab.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
                                ab.Size = New System.Drawing.Size(500, 50)
                                ab.TabIndex = 0
                                ab.Text = appname.ToString
                                ab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                                ab.Text = ab.Text.PadLeft(ab.Text.Length + 5)
                                ab.ImageAlign = ContentAlignment.MiddleLeft
                                ab.UseVisualStyleBackColor = False
                                ab.Visible = True
                                ab.Image = appicon
                                ab.FlatAppearance.BorderColor = Color.FromArgb(255, 20, 20, 20)
                                ab.TextImageRelation = TextImageRelation.ImageBeforeText
                                ab.Tag = Path.GetExtension(file)
                                FlowLayoutPanel1.Controls.Add(ab)
                                AddHandler ab.Click, AddressOf OpenFile
                                If My.Settings.round_allapps_list = True Then
                                    roundthethingy(ab, 20)
                                End If
                                AddHandler ab.MouseDown, AddressOf ShowOptions
                            End If
                        End If
                    End If
                Next
            Catch ex As Exception
            End Try
        End If
        If mode = 1 Then
            Dim ab As New Button
            ab.BackColor = Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
            ab.FlatAppearance.BorderSize = 0
            ab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            ab.Font = New System.Drawing.Font("Segoe UI", 50.25!)
            ab.ForeColor = System.Drawing.Color.White
            ab.Margin = New Padding(11)
            ab.Name = "AddApp"
            ab.Padding = New System.Windows.Forms.Padding(10, 0, 0, 10)
            ab.Size = New System.Drawing.Size(145, 145)
            ab.TabIndex = 0
            ab.Text = "+"
            ab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ab.UseVisualStyleBackColor = False
            ab.Visible = True
            ab.BackgroundImage = Nothing
            ab.BackgroundImageLayout = ImageLayout.Center
            ab.Tag = "&addapp"
            ab.FlatAppearance.BorderColor = Color.FromArgb(255, 20, 20, 20)
            FlowLayoutPanel1.Controls.Add(ab)
            AddHandler ab.Click, AddressOf OpenFile
            roundthethingy(ab, 10)
        End If
        Dim pnlRectScreen As Rectangle = FlowLayoutPanel1.Parent.RectangleToScreen(FlowLayoutPanel1.Bounds)
        For Each child As Control In FlowLayoutPanel1.Controls
            Dim childRectScreen As Rectangle = FlowLayoutPanel1.RectangleToScreen(child.Bounds)
            If pnlRectScreen.IntersectsWith(childRectScreen) Then
                If pnlRectScreen.Contains(childRectScreen) Then
                    Scrollthing.Visible = False
                Else
                    Scrollthing.Visible = True
                End If
            Else
                Scrollthing.Visible = True
            End If
        Next
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

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles SearchBox.MouseEnter, SearchBoxPadding.MouseEnter
        If SearchBox.Focused = False Then
            SearchBox.BackColor = Color.FromArgb(255, 50, 50, 50)
            SearchBoxPadding.BackColor = Color.FromArgb(255, 50, 50, 50)
        End If
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles SearchBox.MouseLeave, SearchBoxPadding.MouseLeave
        If SearchBox.Focused = False Then
            SearchBox.BackColor = Color.FromArgb(255, 10, 10, 10)
            SearchBoxPadding.BackColor = Color.FromArgb(255, 10, 10, 10)
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles SearchBox.Click
        SearchBox.Text = ""
        SearchBox.BackColor = Color.White
        SearchBox.ForeColor = Color.Black
        SearchBtn.ForeColor = Color.Black
        SearchBoxPadding.BackColor = Color.White
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles SearchBox.LostFocus
        SearchBox.BackColor = Color.FromArgb(255, 10, 10, 10)
        SearchBoxPadding.BackColor = Color.FromArgb(255, 10, 10, 10)
        SearchBox.ForeColor = SystemColors.Menu
        SearchBtn.ForeColor = SystemColors.ControlLight
        SearchBox.Text = "Search"
    End Sub

    Private Sub ProfilePic_Click(sender As Object, e As EventArgs) Handles ProfilePic.Click
        Process.Start("ms-settings:yourinfo")

        Timer3.Enabled = True
        Timer3.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        IndexBar.Location = New Point(IndexBar.Location.X, sender.Location.Y + 7)
        Process.Start("ms-settings:")

        Timer3.Enabled = True
        Timer3.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TimelineBtn.Click
        IndexBar.Location = New Point(IndexBar.Location.X, sender.Location.Y + 7)

        objShell.WindowSwitcher

        Timer3.Enabled = True
        Timer3.Start()
    End Sub

    Private Sub PinnedBtn_Click(sender As Object, e As EventArgs) Handles PinnedBtn.Click
        IndexBar.Location = New Point(IndexBar.Location.X, sender.Location.Y + 7)
        Populate(pinnedapps, FlowLayoutPanel1, 1)

    End Sub

    Private Sub AllappsBtn_Click(sender As Object, e As EventArgs) Handles AllAppsBtn.Click
        IndexBar.Location = New Point(IndexBar.Location.X, sender.Location.Y + 7)
        Populate(allapps, FlowLayoutPanel1, 2)
    End Sub


    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        Dim TheControl As Control = CType(sender, Control)
        Dim oRAngle As Rectangle = New Rectangle(0, 0, TheControl.Width, TheControl.Height)
        Dim oGradientBrush As Brush = New LinearGradientBrush(
                                      oRAngle, Color.Transparent,
                                      Color.FromArgb(200, 10, 10, 10),
                                      Drawing.Drawing2D _
                                      .LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(oGradientBrush, oRAngle)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        If SearchBox.BackColor = Color.White Then
            IndexBar.Location = New Point(IndexBar.Location.X, AllAppsBtn.Location.Y + 7)
            Populate(allapps, FlowLayoutPanel1, 3)
        End If
    End Sub

    Private Sub ProfilePic_MouseEnter(sender As Object, e As EventArgs) Handles ProfilePic.MouseEnter
        ProfilePic.Text = ""
        sender.BackgroundImage = Nothing
    End Sub

    Private Sub ProfilePic_MouseLeave(sender As Object, e As EventArgs) Handles ProfilePic.MouseLeave
        ProfilePic.Text = ""
        ProfilePic.BackgroundImage = bmp.BackgroundImage
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub SearchBoxPadding_Paint(sender As Object, e As PaintEventArgs) Handles SearchBoxPadding.Paint

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Opacity += 0.08
        Backfrm.Opacity += 0.08
        If Opacity >= 0.9 Then
            Timer2.Stop()
            'Timer3.Enabled = True
            'Timer3.Start()
            Timer2.Enabled = False
            Opacity = 0.88
            Backfrm.Opacity = 1
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer2.Enabled = False
        Timer2.Stop()
        Opacity -= 0.08
        Backfrm.Opacity -= 0.08
        If Opacity <= 0.1 Then
            Timer3.Enabled = False
            Timer3.Stop()
            Close()
            End
        End If
    End Sub

    Private Sub FlowLayoutPanel1_MouseWheel(sender As FlowLayoutPanel, e As MouseEventArgs) Handles FlowLayoutPanel1.MouseWheel
        Scrollthing.Location = New Point(Scrollthing.Location.X, 10 + (FlowLayoutPanel1.VerticalScroll.Value / 2))
        If Math.Abs(e.Delta) >= 1 Then
            Dim v = Controls.Find("CTMENUPANEL", 1)
            For Each dd As Control In v
                If dd.Visible = True Then
                    sdr.Text = dd.Tag
                    dd.Visible = False
                    dd.Tag = ""
                End If
            Next
        End If
    End Sub



End Class

