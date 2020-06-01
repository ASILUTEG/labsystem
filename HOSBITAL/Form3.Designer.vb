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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnEncrypt = New System.Windows.Forms.Button
        Me.btnDecrypt = New System.Windows.Forms.Button
        Me.TxtEncrypt = New System.Windows.Forms.TextBox
        Me.TxtEncryptResult = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.someurl = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.USERNAME = New System.Windows.Forms.TextBox
        Me.PASSWORD = New System.Windows.Forms.TextBox
        Me.ESL_NO = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(25, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 114)
        Me.TextBox1.TabIndex = 0
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(134, 170)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(137, 23)
        Me.btnEncrypt.TabIndex = 1
        Me.btnEncrypt.Text = "PDF"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(134, 143)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(137, 23)
        Me.btnDecrypt.TabIndex = 2
        Me.btnDecrypt.Text = "TEST"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'TxtEncrypt
        '
        Me.TxtEncrypt.Location = New System.Drawing.Point(12, 172)
        Me.TxtEncrypt.Name = "TxtEncrypt"
        Me.TxtEncrypt.Size = New System.Drawing.Size(100, 20)
        Me.TxtEncrypt.TabIndex = 3
        '
        'TxtEncryptResult
        '
        Me.TxtEncryptResult.Location = New System.Drawing.Point(199, 222)
        Me.TxtEncryptResult.Name = "TxtEncryptResult"
        Me.TxtEncryptResult.Size = New System.Drawing.Size(96, 20)
        Me.TxtEncryptResult.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 253)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "USER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'someurl
        '
        Me.someurl.Location = New System.Drawing.Point(199, 196)
        Me.someurl.Name = "someurl"
        Me.someurl.Size = New System.Drawing.Size(164, 20)
        Me.someurl.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(215, 106)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(164, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(215, 59)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(80, 20)
        Me.TextBox3.TabIndex = 8
        '
        'USERNAME
        '
        Me.USERNAME.Location = New System.Drawing.Point(12, 198)
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.Size = New System.Drawing.Size(100, 20)
        Me.USERNAME.TabIndex = 9
        '
        'PASSWORD
        '
        Me.PASSWORD.Location = New System.Drawing.Point(12, 222)
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.Size = New System.Drawing.Size(100, 20)
        Me.PASSWORD.TabIndex = 10
        '
        'ESL_NO
        '
        Me.ESL_NO.Location = New System.Drawing.Point(12, 248)
        Me.ESL_NO.Name = "ESL_NO"
        Me.ESL_NO.Size = New System.Drawing.Size(100, 20)
        Me.ESL_NO.TabIndex = 11
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 295)
        Me.Controls.Add(Me.ESL_NO)
        Me.Controls.Add(Me.PASSWORD)
        Me.Controls.Add(Me.USERNAME)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.someurl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtEncryptResult)
        Me.Controls.Add(Me.TxtEncrypt)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents TxtEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents TxtEncryptResult As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents someurl As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents USERNAME As System.Windows.Forms.TextBox
    Friend WithEvents PASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents ESL_NO As System.Windows.Forms.TextBox
End Class
