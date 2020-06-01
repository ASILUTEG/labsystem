<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.XpGradientPanel1 = New mdobler.XPCommonControls.XPGradientPanel
        Me.XpLine1 = New mdobler.XPCommonControls.XPLine
        Me.XpTextBox1 = New mdobler.XPCommonControls.XPTextBox
        Me.XpLinkedLabelIcon1 = New mdobler.XPCommonControls.XPLinkedLabelIcon
        Me.XpListView1 = New mdobler.XPCommonControls.XPListView
        Me.XpLoginEntry1 = New mdobler.XPCommonControls.XPLoginEntry
        Me.XpSoftBarrier1 = New mdobler.XPCommonControls.XPSoftBarrier
        Me.XpTaskPanel1 = New mdobler.XPCommonControls.XPTaskPanel
        Me.VistaMenuControl1 = New VistaMenuControl.VistaMenuControl
        Me.XpLine1.SuspendLayout()
        Me.XpSoftBarrier1.SuspendLayout()
        Me.SuspendLayout()
        '
        'XpGradientPanel1
        '
        Me.XpGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.XpGradientPanel1.Name = "XpGradientPanel1"
        Me.XpGradientPanel1.Size = New System.Drawing.Size(191, 85)
        Me.XpGradientPanel1.TabIndex = 0
        '
        'XpLine1
        '
        Me.XpLine1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.XpLine1.Controls.Add(Me.XpTextBox1)
        Me.XpLine1.Location = New System.Drawing.Point(12, 104)
        Me.XpLine1.Name = "XpLine1"
        Me.XpLine1.Size = New System.Drawing.Size(226, 122)
        Me.XpLine1.TabIndex = 0
        '
        'XpTextBox1
        '
        Me.XpTextBox1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.XpTextBox1.Location = New System.Drawing.Point(122, 18)
        Me.XpTextBox1.Name = "XpTextBox1"
        Me.XpTextBox1.PasswortChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.XpTextBox1.Size = New System.Drawing.Size(57, 23)
        Me.XpTextBox1.TabIndex = 0
        Me.XpTextBox1.Text = "XpTextBox1"
        '
        'XpLinkedLabelIcon1
        '
        Me.XpLinkedLabelIcon1.BackColor = System.Drawing.Color.Transparent
        Me.XpLinkedLabelIcon1.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.XpLinkedLabelIcon1.LinkArea = New System.Windows.Forms.LinkArea(0, 18)
        Me.XpLinkedLabelIcon1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.XpLinkedLabelIcon1.Location = New System.Drawing.Point(403, 148)
        Me.XpLinkedLabelIcon1.Name = "XpLinkedLabelIcon1"
        Me.XpLinkedLabelIcon1.Size = New System.Drawing.Size(101, 13)
        Me.XpLinkedLabelIcon1.TabIndex = 1
        Me.XpLinkedLabelIcon1.Text = "XpLinkedLabelIcon1"
        Me.XpLinkedLabelIcon1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'XpListView1
        '
        Me.XpListView1.Location = New System.Drawing.Point(329, 240)
        Me.XpListView1.Name = "XpListView1"
        Me.XpListView1.Size = New System.Drawing.Size(184, 220)
        Me.XpListView1.TabIndex = 2
        Me.XpListView1.UseCompatibleStateImageBehavior = False
        '
        'XpLoginEntry1
        '
        Me.XpLoginEntry1.BackColor = System.Drawing.Color.Transparent
        Me.XpLoginEntry1.HasPassword = False
        Me.XpLoginEntry1.Location = New System.Drawing.Point(640, 220)
        Me.XpLoginEntry1.Name = "XpLoginEntry1"
        Me.XpLoginEntry1.Size = New System.Drawing.Size(52, 60)
        Me.XpLoginEntry1.TabIndex = 3
        '
        'XpSoftBarrier1
        '
        Me.XpSoftBarrier1.BackColor = System.Drawing.Color.Transparent
        Me.XpSoftBarrier1.BackgroundImage = Global.HOSBITAL.My.Resources.Resources.login_button_01
        Me.XpSoftBarrier1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.XpSoftBarrier1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.XpSoftBarrier1.Controls.Add(Me.VistaMenuControl1)
        Me.XpSoftBarrier1.Location = New System.Drawing.Point(310, 1)
        Me.XpSoftBarrier1.Name = "XpSoftBarrier1"
        Me.XpSoftBarrier1.Padding = New System.Windows.Forms.Padding(0, 48, 0, 0)
        Me.XpSoftBarrier1.Size = New System.Drawing.Size(148, 97)
        Me.XpSoftBarrier1.TabIndex = 4
        '
        'XpTaskPanel1
        '
        Me.XpTaskPanel1.AutoScroll = True
        Me.XpTaskPanel1.BackColor = System.Drawing.Color.Transparent
        Me.XpTaskPanel1.Location = New System.Drawing.Point(553, 39)
        Me.XpTaskPanel1.Name = "XpTaskPanel1"
        Me.XpTaskPanel1.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.XpTaskPanel1.Size = New System.Drawing.Size(195, 95)
        Me.XpTaskPanel1.TabIndex = 5
        '
        'VistaMenuControl1
        '
        Me.VistaMenuControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.VistaMenuControl1.BackImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.VistaMenuControl1.BackMenuImage = Nothing
        Me.VistaMenuControl1.CheckOnClick = False
        Me.VistaMenuControl1.FlatSeparators = False
        Me.VistaMenuControl1.FlatSeparatorsColor = System.Drawing.Color.Silver
        Me.VistaMenuControl1.ItemHeight = 48
        Me.VistaMenuControl1.ItemWidth = 150
        Me.VistaMenuControl1.Location = New System.Drawing.Point(0, 0)
        Me.VistaMenuControl1.MaximumSize = New System.Drawing.Size(300, 400)
        Me.VistaMenuControl1.MenuEndColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.VistaMenuControl1.MenuInnerBorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.VistaMenuControl1.MenuOrientation = VistaMenuControl.VistaMenuControl.VistaMenuOrientation.Vertical
        Me.VistaMenuControl1.MenuOuterBorderColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.VistaMenuControl1.MenuStartColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.VistaMenuControl1.MinimumSize = New System.Drawing.Size(100, 46)
        Me.VistaMenuControl1.Name = "VistaMenuControl1"
        Me.VistaMenuControl1.RenderSeparators = True
        Me.VistaMenuControl1.SelectedItem = -1
        Me.VistaMenuControl1.SideBar = False
        Me.VistaMenuControl1.SideBarBitmap = Nothing
        Me.VistaMenuControl1.SideBarCaption = "Vista Cool Menu"
        Me.VistaMenuControl1.SideBarEndGradient = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.VistaMenuControl1.SideBarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.VistaMenuControl1.SideBarFontColor = System.Drawing.Color.White
        Me.VistaMenuControl1.SideBarStartGradient = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.VistaMenuControl1.Size = New System.Drawing.Size(145, 94)
        Me.VistaMenuControl1.TabIndex = 0
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1020, 534)
        Me.Controls.Add(Me.XpTaskPanel1)
        Me.Controls.Add(Me.XpSoftBarrier1)
        Me.Controls.Add(Me.XpLoginEntry1)
        Me.Controls.Add(Me.XpListView1)
        Me.Controls.Add(Me.XpLinkedLabelIcon1)
        Me.Controls.Add(Me.XpLine1)
        Me.Controls.Add(Me.XpGradientPanel1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.XpLine1.ResumeLayout(False)
        Me.XpSoftBarrier1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpGradientPanel1 As mdobler.XPCommonControls.XPGradientPanel
    Friend WithEvents XpLine1 As mdobler.XPCommonControls.XPLine
    Friend WithEvents XpTextBox1 As mdobler.XPCommonControls.XPTextBox
    Friend WithEvents XpLinkedLabelIcon1 As mdobler.XPCommonControls.XPLinkedLabelIcon
    Friend WithEvents XpListView1 As mdobler.XPCommonControls.XPListView
    Friend WithEvents XpLoginEntry1 As mdobler.XPCommonControls.XPLoginEntry
    Friend WithEvents XpSoftBarrier1 As mdobler.XPCommonControls.XPSoftBarrier
    Friend WithEvents VistaMenuControl1 As VistaMenuControl.VistaMenuControl
    Friend WithEvents XpTaskPanel1 As mdobler.XPCommonControls.XPTaskPanel
End Class
