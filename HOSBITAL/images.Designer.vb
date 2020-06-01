<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class images
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picCapture = New System.Windows.Forms.PictureBox
        Me.btnStop = New Glass.GlassButton
        Me.btnSave = New Glass.GlassButton
        Me.btnStart = New Glass.GlassButton
        Me.lstDevices = New System.Windows.Forms.ListBox
        Me.sfdImage = New System.Windows.Forms.SaveFileDialog
        Me.pb3 = New System.Windows.Forms.PictureBox
        Me.cin = New Glass.GlassButton
        Me.GlassButton1 = New Glass.GlassButton
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCapture
        '
        Me.picCapture.BackColor = System.Drawing.Color.Transparent
        Me.picCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCapture.Location = New System.Drawing.Point(3, 12)
        Me.picCapture.Name = "picCapture"
        Me.picCapture.Size = New System.Drawing.Size(919, 474)
        Me.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCapture.TabIndex = 213
        Me.picCapture.TabStop = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Red
        Me.btnStop.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Blue
        Me.btnStop.GlowColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStop.InnerBorderColor = System.Drawing.Color.MistyRose
        Me.btnStop.Location = New System.Drawing.Point(272, 513)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.OuterBorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnStop.Size = New System.Drawing.Size(10, 10)
        Me.btnStop.TabIndex = 217
        Me.btnStop.Text = "Stop Preview"
        Me.btnStop.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Red
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Blue
        Me.btnSave.GlowColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.InnerBorderColor = System.Drawing.Color.MistyRose
        Me.btnSave.Location = New System.Drawing.Point(803, 503)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OuterBorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.Size = New System.Drawing.Size(58, 39)
        Me.btnSave.TabIndex = 216
        Me.btnSave.Text = "«·—Ê‘ …"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Red
        Me.btnStart.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Blue
        Me.btnStart.GlowColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStart.InnerBorderColor = System.Drawing.Color.MistyRose
        Me.btnStart.Location = New System.Drawing.Point(867, 503)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.OuterBorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnStart.Size = New System.Drawing.Size(55, 39)
        Me.btnStart.TabIndex = 215
        Me.btnStart.Text = "Start"
        '
        'lstDevices
        '
        Me.lstDevices.FormattingEnabled = True
        Me.lstDevices.Location = New System.Drawing.Point(905, 493)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(10, 4)
        Me.lstDevices.TabIndex = 218
        '
        'pb3
        '
        Me.pb3.BackColor = System.Drawing.Color.Transparent
        Me.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb3.Location = New System.Drawing.Point(3, 492)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(122, 98)
        Me.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb3.TabIndex = 225
        Me.pb3.TabStop = False
        '
        'cin
        '
        Me.cin.BackColor = System.Drawing.Color.Red
        Me.cin.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cin.ForeColor = System.Drawing.Color.Blue
        Me.cin.GlowColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cin.InnerBorderColor = System.Drawing.Color.MistyRose
        Me.cin.Location = New System.Drawing.Point(711, 503)
        Me.cin.Name = "cin"
        Me.cin.OuterBorderColor = System.Drawing.Color.WhiteSmoke
        Me.cin.Size = New System.Drawing.Size(66, 39)
        Me.cin.TabIndex = 226
        Me.cin.Text = "Õ÷Ê—"
        '
        'GlassButton1
        '
        Me.GlassButton1.BackColor = System.Drawing.Color.Red
        Me.GlassButton1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlassButton1.ForeColor = System.Drawing.Color.Blue
        Me.GlassButton1.GlowColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GlassButton1.InnerBorderColor = System.Drawing.Color.MistyRose
        Me.GlassButton1.Location = New System.Drawing.Point(644, 503)
        Me.GlassButton1.Name = "GlassButton1"
        Me.GlassButton1.OuterBorderColor = System.Drawing.Color.WhiteSmoke
        Me.GlassButton1.Size = New System.Drawing.Size(66, 39)
        Me.GlassButton1.TabIndex = 227
        Me.GlassButton1.Text = "«‰’—«›"
        '
        'images
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 593)
        Me.Controls.Add(Me.GlassButton1)
        Me.Controls.Add(Me.cin)
        Me.Controls.Add(Me.pb3)
        Me.Controls.Add(Me.lstDevices)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picCapture)
        Me.Name = "images"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "images"
        CType(Me.picCapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCapture As System.Windows.Forms.PictureBox
    Friend WithEvents btnStop As Glass.GlassButton
    Friend WithEvents btnSave As Glass.GlassButton
    Friend WithEvents btnStart As Glass.GlassButton
    Friend WithEvents lstDevices As System.Windows.Forms.ListBox
    Friend WithEvents sfdImage As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pb3 As System.Windows.Forms.PictureBox
    Friend WithEvents cin As Glass.GlassButton
    Friend WithEvents GlassButton1 As Glass.GlassButton
End Class
