<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appointmentrecord
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidshow = New System.Windows.Forms.TextBox()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvAppointment = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtpointer = New System.Windows.Forms.TextBox()
        CType(Me.dgvAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, -94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 33)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Patient Record"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-336, -46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Patient ID"
        '
        'txtidshow
        '
        Me.txtidshow.Location = New System.Drawing.Point(-339, -33)
        Me.txtidshow.Name = "txtidshow"
        Me.txtidshow.Size = New System.Drawing.Size(100, 20)
        Me.txtidshow.TabIndex = 23
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.LightCyan
        Me.btnedit.Location = New System.Drawing.Point(329, 293)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(100, 45)
        Me.btnedit.TabIndex = 22
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightCyan
        Me.btnClose.Location = New System.Drawing.Point(435, 293)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 45)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dgvAppointment
        '
        Me.dgvAppointment.AllowUserToAddRows = False
        Me.dgvAppointment.AllowUserToDeleteRows = False
        Me.dgvAppointment.BackgroundColor = System.Drawing.Color.LightCyan
        Me.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAppointment.Location = New System.Drawing.Point(25, 75)
        Me.dgvAppointment.Name = "dgvAppointment"
        Me.dgvAppointment.ReadOnly = True
        Me.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAppointment.Size = New System.Drawing.Size(490, 200)
        Me.dgvAppointment.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(291, 32)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Appointment Record"
        '
        'Txtpointer
        '
        Me.Txtpointer.Location = New System.Drawing.Point(71, 412)
        Me.Txtpointer.Name = "Txtpointer"
        Me.Txtpointer.Size = New System.Drawing.Size(100, 20)
        Me.Txtpointer.TabIndex = 27
        '
        'appointmentrecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(546, 355)
        Me.Controls.Add(Me.Txtpointer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidshow)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvAppointment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "appointmentrecord"
        Me.Text = "appointmentrecord"
        CType(Me.dgvAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidshow As TextBox
    Friend WithEvents btnedit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvAppointment As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtpointer As TextBox
End Class
