<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PATHO
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
        Me.tar = New System.Windows.Forms.TextBox
        Me.c = New Glass.GlassButton
        Me.SuspendLayout()
        '
        'tar
        '
        Me.tar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tar.Location = New System.Drawing.Point(2, 12)
        Me.tar.Multiline = True
        Me.tar.Name = "tar"
        Me.tar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tar.Size = New System.Drawing.Size(913, 489)
        Me.tar.TabIndex = 20
        Me.tar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c
        '
        Me.c.BackColor = System.Drawing.Color.Red
        Me.c.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.ForeColor = System.Drawing.Color.Blue
        Me.c.GlowColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.c.InnerBorderColor = System.Drawing.Color.MistyRose
        Me.c.Location = New System.Drawing.Point(442, 507)
        Me.c.Name = "c"
        Me.c.OuterBorderColor = System.Drawing.Color.WhiteSmoke
        Me.c.Size = New System.Drawing.Size(107, 30)
        Me.c.TabIndex = 161
        Me.c.Text = "Õ›Ÿ «·‰ ÌÃ…"
        '
        'PATHO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 543)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.tar)
        Me.Name = "PATHO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PATHO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tar As System.Windows.Forms.TextBox
    Friend WithEvents c As Glass.GlassButton
End Class
