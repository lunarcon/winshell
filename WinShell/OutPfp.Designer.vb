<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutPfp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProfilePic = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProfilePic
        '
        Me.ProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ProfilePic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProfilePic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ProfilePic.FlatAppearance.BorderSize = 0
        Me.ProfilePic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ProfilePic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ProfilePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProfilePic.Font = New System.Drawing.Font("Segoe MDL2 Assets", 50.25!)
        Me.ProfilePic.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ProfilePic.Location = New System.Drawing.Point(0, 0)
        Me.ProfilePic.Margin = New System.Windows.Forms.Padding(0)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Padding = New System.Windows.Forms.Padding(7, 4, 0, 0)
        Me.ProfilePic.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProfilePic.Size = New System.Drawing.Size(100, 100)
        Me.ProfilePic.TabIndex = 14
        Me.ProfilePic.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ProfilePic.UseVisualStyleBackColor = True
        '
        'OutPfp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(100, 100)
        Me.Controls.Add(Me.ProfilePic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(100, 100)
        Me.Name = "OutPfp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "OutPfp"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProfilePic As Button
End Class
