<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginform))
        Me.email = New System.Windows.Forms.TextBox()
        Me.btlogin = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbshow = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.LightCyan
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.email.Location = New System.Drawing.Point(60, 102)
        Me.email.Multiline = True
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(218, 25)
        Me.email.TabIndex = 1
        '
        'btlogin
        '
        Me.btlogin.BackColor = System.Drawing.Color.LightCyan
        Me.btlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btlogin.Location = New System.Drawing.Point(69, 210)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(93, 44)
        Me.btlogin.TabIndex = 3
        Me.btlogin.Text = "LOG IN"
        Me.btlogin.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCyan
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(178, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 44)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "SIGN UP"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cbshow
        '
        Me.cbshow.AutoSize = True
        Me.cbshow.BackColor = System.Drawing.Color.Transparent
        Me.cbshow.Location = New System.Drawing.Point(60, 177)
        Me.cbshow.Name = "cbshow"
        Me.cbshow.Size = New System.Drawing.Size(102, 17)
        Me.cbshow.TabIndex = 7
        Me.cbshow.Text = "Show Password"
        Me.cbshow.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(115, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 29)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "LOG IN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(57, 81)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(57, 129)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 18)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Password:"
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.LightCyan
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.password.Location = New System.Drawing.Point(60, 149)
        Me.password.Margin = New System.Windows.Forms.Padding(2)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(218, 24)
        Me.password.TabIndex = 84
        Me.password.UseSystemPasswordChar = True
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(349, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbshow)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btlogin)
        Me.Controls.Add(Me.email)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loginform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents email As TextBox
    Friend WithEvents btlogin As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cbshow As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents password As TextBox
End Class
