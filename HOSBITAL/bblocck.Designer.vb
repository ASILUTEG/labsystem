<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bblocck
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
        Me.FDG = New System.Windows.Forms.DataGridView
        Me.tname = New System.Windows.Forms.TextBox
        CType(Me.FDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FDG
        '
        Me.FDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FDG.Location = New System.Drawing.Point(1, 4)
        Me.FDG.Name = "FDG"
        Me.FDG.Size = New System.Drawing.Size(436, 528)
        Me.FDG.TabIndex = 1
        '
        'tname
        '
        Me.tname.Location = New System.Drawing.Point(24, 538)
        Me.tname.Name = "tname"
        Me.tname.Size = New System.Drawing.Size(100, 20)
        Me.tname.TabIndex = 2
        '
        'bblocck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 537)
        Me.Controls.Add(Me.tname)
        Me.Controls.Add(Me.FDG)
        Me.Name = "bblocck"
        Me.Text = "bblocck"
        CType(Me.FDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FDG As System.Windows.Forms.DataGridView
    Friend WithEvents tname As System.Windows.Forms.TextBox
End Class
