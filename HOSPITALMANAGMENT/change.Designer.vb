<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change
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
        Me.cbshow = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtnew = New System.Windows.Forms.TextBox()
        Me.lbnew = New System.Windows.Forms.Label()
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbshow
        '
        Me.cbshow.AutoSize = True
        Me.cbshow.ForeColor = System.Drawing.Color.Black
        Me.cbshow.Location = New System.Drawing.Point(211, 50)
        Me.cbshow.Name = "cbshow"
        Me.cbshow.Size = New System.Drawing.Size(97, 17)
        Me.cbshow.TabIndex = 65
        Me.cbshow.Text = "Show Pasword"
        Me.cbshow.UseVisualStyleBackColor = True
        Me.cbshow.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightCyan
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(307, 76)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 40)
        Me.btnSave.TabIndex = 64
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightCyan
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(391, 76)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 40)
        Me.btnCancel.TabIndex = 63
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtnew
        '
        Me.txtnew.BackColor = System.Drawing.Color.LightCyan
        Me.txtnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnew.ForeColor = System.Drawing.Color.Black
        Me.txtnew.Location = New System.Drawing.Point(211, 22)
        Me.txtnew.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnew.Name = "txtnew"
        Me.txtnew.Size = New System.Drawing.Size(260, 26)
        Me.txtnew.TabIndex = 62
        '
        'lbnew
        '
        Me.lbnew.AutoSize = True
        Me.lbnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnew.ForeColor = System.Drawing.Color.Black
        Me.lbnew.Location = New System.Drawing.Point(26, 28)
        Me.lbnew.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbnew.Name = "lbnew"
        Me.lbnew.Size = New System.Drawing.Size(172, 20)
        Me.lbnew.TabIndex = 61
        Me.lbnew.Text = "Enter new Password"
        '
        'Txtid
        '
        Me.Txtid.Location = New System.Drawing.Point(49, 188)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(100, 20)
        Me.Txtid.TabIndex = 66
        '
        'change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(503, 132)
        Me.Controls.Add(Me.Txtid)
        Me.Controls.Add(Me.cbshow)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtnew)
        Me.Controls.Add(Me.lbnew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "change"
        Me.Text = "change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbshow As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtnew As TextBox
    Friend WithEvents lbnew As Label
    Friend WithEvents Txtid As TextBox
End Class
