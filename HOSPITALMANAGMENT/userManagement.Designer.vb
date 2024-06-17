<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userManagement
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidshow = New System.Windows.Forms.TextBox()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvuser = New System.Windows.Forms.DataGridView()
        Me.btDelete = New System.Windows.Forms.Button()
        CType(Me.dgvuser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(246, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 33)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "User"
        '
        'txtidshow
        '
        Me.txtidshow.BackColor = System.Drawing.Color.LightCyan
        Me.txtidshow.Location = New System.Drawing.Point(47, 390)
        Me.txtidshow.Name = "txtidshow"
        Me.txtidshow.Size = New System.Drawing.Size(100, 20)
        Me.txtidshow.TabIndex = 23
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.LightCyan
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(367, 291)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(95, 49)
        Me.btnedit.TabIndex = 22
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightCyan
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(468, 291)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 49)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dgvuser
        '
        Me.dgvuser.AllowUserToAddRows = False
        Me.dgvuser.AllowUserToDeleteRows = False
        Me.dgvuser.BackgroundColor = System.Drawing.Color.LightCyan
        Me.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvuser.Location = New System.Drawing.Point(28, 58)
        Me.dgvuser.Name = "dgvuser"
        Me.dgvuser.ReadOnly = True
        Me.dgvuser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvuser.Size = New System.Drawing.Size(528, 227)
        Me.dgvuser.TabIndex = 20
        '
        'btDelete
        '
        Me.btDelete.BackColor = System.Drawing.Color.LightCyan
        Me.btDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelete.Location = New System.Drawing.Point(266, 291)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(95, 49)
        Me.btDelete.TabIndex = 26
        Me.btDelete.Text = "DELETE"
        Me.btDelete.UseVisualStyleBackColor = False
        Me.btDelete.Visible = False
        '
        'userManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(597, 361)
        Me.Controls.Add(Me.btDelete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtidshow)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvuser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userManagament"
        CType(Me.dgvuser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtidshow As TextBox
    Friend WithEvents btnedit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvuser As DataGridView
    Friend WithEvents btDelete As Button
End Class
