<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FIND
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
        Me.SNAME = New System.Windows.Forms.TextBox
        Me.NFLD = New System.Windows.Forms.TextBox
        CType(Me.FDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FDG
        '
        Me.FDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FDG.Location = New System.Drawing.Point(8, 56)
        Me.FDG.Name = "FDG"
        Me.FDG.Size = New System.Drawing.Size(436, 507)
        Me.FDG.TabIndex = 0
        '
        'SNAME
        '
        Me.SNAME.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SNAME.ForeColor = System.Drawing.Color.Blue
        Me.SNAME.Location = New System.Drawing.Point(9, 12)
        Me.SNAME.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.SNAME.Name = "SNAME"
        Me.SNAME.Size = New System.Drawing.Size(411, 20)
        Me.SNAME.TabIndex = 241
        Me.SNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NFLD
        '
        Me.NFLD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NFLD.ForeColor = System.Drawing.Color.Blue
        Me.NFLD.Location = New System.Drawing.Point(9, 38)
        Me.NFLD.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.NFLD.Name = "NFLD"
        Me.NFLD.Size = New System.Drawing.Size(10, 20)
        Me.NFLD.TabIndex = 242
        Me.NFLD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NFLD.Visible = False
        '
        'FIND
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 564)
        Me.Controls.Add(Me.NFLD)
        Me.Controls.Add(Me.SNAME)
        Me.Controls.Add(Me.FDG)
        Me.Name = "FIND"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FIND"
        CType(Me.FDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FDG As System.Windows.Forms.DataGridView
    Friend WithEvents SNAME As System.Windows.Forms.TextBox
    Friend WithEvents NFLD As System.Windows.Forms.TextBox
End Class
