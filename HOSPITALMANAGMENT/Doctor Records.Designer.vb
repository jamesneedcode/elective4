<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class currentdoctor
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
        Me.txtidshow = New System.Windows.Forms.TextBox()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvdoctor = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvdoctor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidshow
        '
        Me.txtidshow.BackColor = System.Drawing.Color.LightCyan
        Me.txtidshow.Location = New System.Drawing.Point(29, 102)
        Me.txtidshow.Name = "txtidshow"
        Me.txtidshow.Size = New System.Drawing.Size(100, 20)
        Me.txtidshow.TabIndex = 22
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.LightCyan
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(1072, 458)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(110, 47)
        Me.btnedit.TabIndex = 20
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightCyan
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1188, 458)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 47)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dgvdoctor
        '
        Me.dgvdoctor.AllowUserToAddRows = False
        Me.dgvdoctor.AllowUserToDeleteRows = False
        Me.dgvdoctor.BackgroundColor = System.Drawing.Color.LightCyan
        Me.dgvdoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdoctor.Location = New System.Drawing.Point(26, 142)
        Me.dgvdoctor.Name = "dgvdoctor"
        Me.dgvdoctor.ReadOnly = True
        Me.dgvdoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdoctor.Size = New System.Drawing.Size(1262, 301)
        Me.dgvdoctor.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Doctor ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(536, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 31)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Doctor Record"
        '
        'currentdoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1327, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidshow)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvdoctor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "currentdoctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor_Records"
        CType(Me.dgvdoctor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtidshow As TextBox
    Friend WithEvents btnedit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvdoctor As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
