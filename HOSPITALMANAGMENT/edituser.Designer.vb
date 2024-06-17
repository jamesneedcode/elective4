<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edituser
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
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnpassword = New System.Windows.Forms.Button()
        Me.btnFullname = New System.Windows.Forms.Button()
        Me.btnemail = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.LightCyan
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btncancel.Location = New System.Drawing.Point(195, 123)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(153, 40)
        Me.btncancel.TabIndex = 45
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnpassword
        '
        Me.btnpassword.BackColor = System.Drawing.Color.LightCyan
        Me.btnpassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnpassword.Location = New System.Drawing.Point(195, 69)
        Me.btnpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.btnpassword.Name = "btnpassword"
        Me.btnpassword.Size = New System.Drawing.Size(153, 40)
        Me.btnpassword.TabIndex = 44
        Me.btnpassword.Text = "Change Password"
        Me.btnpassword.UseVisualStyleBackColor = False
        '
        'btnFullname
        '
        Me.btnFullname.BackColor = System.Drawing.Color.LightCyan
        Me.btnFullname.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFullname.Location = New System.Drawing.Point(22, 123)
        Me.btnFullname.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFullname.Name = "btnFullname"
        Me.btnFullname.Size = New System.Drawing.Size(156, 40)
        Me.btnFullname.TabIndex = 43
        Me.btnFullname.Text = "Change Fullname"
        Me.btnFullname.UseVisualStyleBackColor = False
        '
        'btnemail
        '
        Me.btnemail.BackColor = System.Drawing.Color.LightCyan
        Me.btnemail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnemail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnemail.Location = New System.Drawing.Point(22, 69)
        Me.btnemail.Margin = New System.Windows.Forms.Padding(2)
        Me.btnemail.Name = "btnemail"
        Me.btnemail.Size = New System.Drawing.Size(156, 40)
        Me.btnemail.TabIndex = 42
        Me.btnemail.Text = "Change Email"
        Me.btnemail.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(131, 19)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 29)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Edit User"
        '
        'edituser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(372, 181)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnpassword)
        Me.Controls.Add(Me.btnFullname)
        Me.Controls.Add(Me.btnemail)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "edituser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "edituser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncancel As Button
    Friend WithEvents btnpassword As Button
    Friend WithEvents btnFullname As Button
    Friend WithEvents btnemail As Button
    Friend WithEvents Label5 As Label
End Class
