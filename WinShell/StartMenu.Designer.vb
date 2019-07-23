<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartMenu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ProfilePic = New System.Windows.Forms.Button()
        Me.IndexBar = New System.Windows.Forms.Panel()
        Me.PinnedBtn = New System.Windows.Forms.Button()
        Me.AllAppsBtn = New System.Windows.Forms.Button()
        Me.TimelineBtn = New System.Windows.Forms.Button()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.SearchBoxPadding = New System.Windows.Forms.Panel()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.UserGreet = New System.Windows.Forms.Button()
        Me.Ico1 = New System.Windows.Forms.Button()
        Me.Ico2 = New System.Windows.Forms.Button()
        Me.Ico3 = New System.Windows.Forms.Button()
        Me.Ico4 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Scrollthing = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SearchBoxPadding.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ProfilePic)
        Me.Panel1.Controls.Add(Me.IndexBar)
        Me.Panel1.Controls.Add(Me.PinnedBtn)
        Me.Panel1.Controls.Add(Me.AllAppsBtn)
        Me.Panel1.Controls.Add(Me.TimelineBtn)
        Me.Panel1.Controls.Add(Me.SettingsBtn)
        Me.Panel1.Controls.Add(Me.SearchBoxPadding)
        Me.Panel1.Controls.Add(Me.UserGreet)
        Me.Panel1.Controls.Add(Me.Ico1)
        Me.Panel1.Controls.Add(Me.Ico2)
        Me.Panel1.Controls.Add(Me.Ico3)
        Me.Panel1.Controls.Add(Me.Ico4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 40)
        Me.Panel1.Size = New System.Drawing.Size(498, 725)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(47, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 189)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(485, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(13, 725)
        Me.Panel4.TabIndex = 27
        '
        'ProfilePic
        '
        Me.ProfilePic.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProfilePic.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ProfilePic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ProfilePic.FlatAppearance.BorderSize = 0
        Me.ProfilePic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ProfilePic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ProfilePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProfilePic.Font = New System.Drawing.Font("Segoe MDL2 Assets", 50.25!)
        Me.ProfilePic.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ProfilePic.Location = New System.Drawing.Point(196, 26)
        Me.ProfilePic.Margin = New System.Windows.Forms.Padding(0)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Padding = New System.Windows.Forms.Padding(7, 4, 0, 0)
        Me.ProfilePic.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProfilePic.Size = New System.Drawing.Size(100, 100)
        Me.ProfilePic.TabIndex = 13
        Me.ProfilePic.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ProfilePic.UseVisualStyleBackColor = False
        '
        'IndexBar
        '
        Me.IndexBar.BackColor = System.Drawing.SystemColors.Highlight
        Me.IndexBar.Location = New System.Drawing.Point(0, 543)
        Me.IndexBar.Name = "IndexBar"
        Me.IndexBar.Size = New System.Drawing.Size(4, 30)
        Me.IndexBar.TabIndex = 21
        '
        'PinnedBtn
        '
        Me.PinnedBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PinnedBtn.FlatAppearance.BorderSize = 0
        Me.PinnedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PinnedBtn.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.PinnedBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.PinnedBtn.Location = New System.Drawing.Point(51, 535)
        Me.PinnedBtn.Name = "PinnedBtn"
        Me.PinnedBtn.Size = New System.Drawing.Size(444, 45)
        Me.PinnedBtn.TabIndex = 20
        Me.PinnedBtn.Text = "Pinned"
        Me.PinnedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PinnedBtn.UseVisualStyleBackColor = True
        '
        'AllAppsBtn
        '
        Me.AllAppsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.AllAppsBtn.FlatAppearance.BorderSize = 0
        Me.AllAppsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AllAppsBtn.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.AllAppsBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.AllAppsBtn.Location = New System.Drawing.Point(51, 580)
        Me.AllAppsBtn.Name = "AllAppsBtn"
        Me.AllAppsBtn.Size = New System.Drawing.Size(444, 45)
        Me.AllAppsBtn.TabIndex = 19
        Me.AllAppsBtn.Text = "All Apps"
        Me.AllAppsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AllAppsBtn.UseVisualStyleBackColor = True
        '
        'TimelineBtn
        '
        Me.TimelineBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TimelineBtn.FlatAppearance.BorderSize = 0
        Me.TimelineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TimelineBtn.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.TimelineBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.TimelineBtn.Location = New System.Drawing.Point(51, 624)
        Me.TimelineBtn.Name = "TimelineBtn"
        Me.TimelineBtn.Size = New System.Drawing.Size(444, 45)
        Me.TimelineBtn.TabIndex = 18
        Me.TimelineBtn.Text = "Timeline"
        Me.TimelineBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TimelineBtn.UseVisualStyleBackColor = True
        '
        'SettingsBtn
        '
        Me.SettingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SettingsBtn.FlatAppearance.BorderSize = 0
        Me.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsBtn.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.SettingsBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.SettingsBtn.Location = New System.Drawing.Point(51, 668)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(444, 45)
        Me.SettingsBtn.TabIndex = 17
        Me.SettingsBtn.Text = "Settings"
        Me.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingsBtn.UseVisualStyleBackColor = True
        '
        'SearchBoxPadding
        '
        Me.SearchBoxPadding.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.SearchBoxPadding.Controls.Add(Me.SearchBtn)
        Me.SearchBoxPadding.Controls.Add(Me.SearchBox)
        Me.SearchBoxPadding.Location = New System.Drawing.Point(51, 211)
        Me.SearchBoxPadding.Name = "SearchBoxPadding"
        Me.SearchBoxPadding.Padding = New System.Windows.Forms.Padding(15, 7, 10, 7)
        Me.SearchBoxPadding.Size = New System.Drawing.Size(394, 42)
        Me.SearchBoxPadding.TabIndex = 16
        '
        'SearchBtn
        '
        Me.SearchBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.SearchBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Segoe MDL2 Assets", 11.05!)
        Me.SearchBtn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.SearchBtn.Location = New System.Drawing.Point(356, 7)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(28, 28)
        Me.SearchBtn.TabIndex = 23
        Me.SearchBtn.Text = ""
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'SearchBox
        '
        Me.SearchBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchBox.Font = New System.Drawing.Font("Segoe UI", 13.25!)
        Me.SearchBox.ForeColor = System.Drawing.SystemColors.Menu
        Me.SearchBox.Location = New System.Drawing.Point(15, 7)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(369, 24)
        Me.SearchBox.TabIndex = 15
        Me.SearchBox.Text = "Search"
        '
        'UserGreet
        '
        Me.UserGreet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.UserGreet.FlatAppearance.BorderSize = 0
        Me.UserGreet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.UserGreet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.UserGreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserGreet.Font = New System.Drawing.Font("Segoe UI", 18.25!, System.Drawing.FontStyle.Bold)
        Me.UserGreet.ForeColor = System.Drawing.SystemColors.Control
        Me.UserGreet.Location = New System.Drawing.Point(0, 126)
        Me.UserGreet.Name = "UserGreet"
        Me.UserGreet.Size = New System.Drawing.Size(498, 70)
        Me.UserGreet.TabIndex = 14
        Me.UserGreet.Text = "Good greeting, username"
        Me.UserGreet.UseVisualStyleBackColor = True
        '
        'Ico1
        '
        Me.Ico1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Ico1.FlatAppearance.BorderSize = 0
        Me.Ico1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ico1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ico1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ico1.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!)
        Me.Ico1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Ico1.Location = New System.Drawing.Point(12, 535)
        Me.Ico1.Name = "Ico1"
        Me.Ico1.Size = New System.Drawing.Size(41, 45)
        Me.Ico1.TabIndex = 23
        Me.Ico1.Text = ""
        Me.Ico1.UseVisualStyleBackColor = True
        '
        'Ico2
        '
        Me.Ico2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Ico2.FlatAppearance.BorderSize = 0
        Me.Ico2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ico2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ico2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ico2.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!)
        Me.Ico2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Ico2.Location = New System.Drawing.Point(12, 580)
        Me.Ico2.Name = "Ico2"
        Me.Ico2.Size = New System.Drawing.Size(41, 45)
        Me.Ico2.TabIndex = 24
        Me.Ico2.Text = ""
        Me.Ico2.UseVisualStyleBackColor = True
        '
        'Ico3
        '
        Me.Ico3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Ico3.FlatAppearance.BorderSize = 0
        Me.Ico3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ico3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ico3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ico3.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!)
        Me.Ico3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Ico3.Location = New System.Drawing.Point(12, 624)
        Me.Ico3.Name = "Ico3"
        Me.Ico3.Size = New System.Drawing.Size(41, 45)
        Me.Ico3.TabIndex = 25
        Me.Ico3.Text = ""
        Me.Ico3.UseVisualStyleBackColor = True
        '
        'Ico4
        '
        Me.Ico4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Ico4.FlatAppearance.BorderSize = 0
        Me.Ico4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ico4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ico4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ico4.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!)
        Me.Ico4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Ico4.Location = New System.Drawing.Point(12, 668)
        Me.Ico4.Name = "Ico4"
        Me.Ico4.Size = New System.Drawing.Size(41, 45)
        Me.Ico4.TabIndex = 26
        Me.Ico4.Text = ""
        Me.Ico4.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(498, 27)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(32, 0, 32, 32)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(583, 698)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Scrollthing)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1061, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(20, 698)
        Me.Panel2.TabIndex = 0
        '
        'Scrollthing
        '
        Me.Scrollthing.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Scrollthing.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Scrollthing.FlatAppearance.BorderSize = 0
        Me.Scrollthing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Scrollthing.Location = New System.Drawing.Point(8, 10)
        Me.Scrollthing.Name = "Scrollthing"
        Me.Scrollthing.Size = New System.Drawing.Size(5, 40)
        Me.Scrollthing.TabIndex = 0
        Me.Scrollthing.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(498, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(583, 27)
        Me.Panel3.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.WinShell.My.Resources.Resources._37
        Me.PictureBox1.Location = New System.Drawing.Point(563, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 27)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(498, 92)
        Me.Panel5.TabIndex = 29
        Me.Panel5.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 73)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(498, 19)
        Me.Panel6.TabIndex = 0
        '
        'StartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1081, 725)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartMenu"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.SearchBoxPadding.ResumeLayout(False)
        Me.SearchBoxPadding.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchBoxPadding As Panel
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents UserGreet As Button
    Friend WithEvents ProfilePic As Button
    Friend WithEvents PinnedBtn As Button
    Friend WithEvents AllAppsBtn As Button
    Friend WithEvents TimelineBtn As Button
    Friend WithEvents SettingsBtn As Button
    Friend WithEvents IndexBar As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SearchBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Ico1 As Button
    Friend WithEvents Ico2 As Button
    Friend WithEvents Ico3 As Button
    Friend WithEvents Ico4 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Scrollthing As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
End Class
