<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.����ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.�������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.�������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.�������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ASIL = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.����ToolStripMenuItem, Me.������������ToolStripMenuItem, Me.�������ToolStripMenuItem, Me.�������ToolStripMenuItem, Me.������ToolStripMenuItem, Me.ImageToolStripMenuItem, Me.MMToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.�������������ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1020, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '����ToolStripMenuItem
        '
        Me.����ToolStripMenuItem.Name = "����ToolStripMenuItem"
        Me.����ToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.����ToolStripMenuItem.Text = "������"
        Me.����ToolStripMenuItem.Visible = False
        '
        '������������ToolStripMenuItem
        '
        Me.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem"
        Me.������������ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.������������ToolStripMenuItem.Text = "���� ��������"
        Me.������������ToolStripMenuItem.Visible = False
        '
        '�������ToolStripMenuItem
        '
        Me.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem"
        Me.�������ToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.�������ToolStripMenuItem.Text = "�������"
        Me.�������ToolStripMenuItem.Visible = False
        '
        '�������ToolStripMenuItem
        '
        Me.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem"
        Me.�������ToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.�������ToolStripMenuItem.Text = "�������"
        Me.�������ToolStripMenuItem.Visible = False
        '
        '������ToolStripMenuItem
        '
        Me.������ToolStripMenuItem.Name = "������ToolStripMenuItem"
        Me.������ToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.������ToolStripMenuItem.Text = "������"
        Me.������ToolStripMenuItem.Visible = False
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ImageToolStripMenuItem.Text = "image "
        Me.ImageToolStripMenuItem.Visible = False
        '
        'MMToolStripMenuItem
        '
        Me.MMToolStripMenuItem.Name = "MMToolStripMenuItem"
        Me.MMToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.MMToolStripMenuItem.Text = "MM"
        Me.MMToolStripMenuItem.Visible = False
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.RefreshToolStripMenuItem.Text = "refresh"
        Me.RefreshToolStripMenuItem.Visible = False
        '
        '�������������ToolStripMenuItem
        '
        Me.�������������ToolStripMenuItem.Name = "�������������ToolStripMenuItem"
        Me.�������������ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.�������������ToolStripMenuItem.Text = "������ �������"
        Me.�������������ToolStripMenuItem.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.HOSBITAL.My.Resources.Resources.test_tube11
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1030, 719)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ASIL
        '
        Me.ASIL.Icon = CType(resources.GetObject("ASIL.Icon"), System.Drawing.Icon)
        Me.ASIL.Text = "asil prog"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HOSBITAL.My.Resources.Resources.test_tube11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1020, 742)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ����ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ASIL As System.Windows.Forms.NotifyIcon
    Friend WithEvents ������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
