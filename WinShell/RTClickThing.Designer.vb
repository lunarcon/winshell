<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RTClickThing
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
        Me.Ico4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ico4
        '
        Me.Ico4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Ico4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Ico4.FlatAppearance.BorderSize = 0
        Me.Ico4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ico4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ico4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ico4.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!)
        Me.Ico4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Ico4.Location = New System.Drawing.Point(0, 0)
        Me.Ico4.Name = "Ico4"
        Me.Ico4.Size = New System.Drawing.Size(41, 34)
        Me.Ico4.TabIndex = 27
        Me.Ico4.Text = ""
        Me.Ico4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(41, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 34)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Open app location"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RTClickThing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(200, 34)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Ico4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RTClickThing"
        Me.Opacity = 0R
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "RTClickThing"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ico4 As Button
    Friend WithEvents Button1 As Button
End Class
