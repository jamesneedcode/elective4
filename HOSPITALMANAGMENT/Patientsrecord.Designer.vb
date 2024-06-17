<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmpatientsrecords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtidshow = New System.Windows.Forms.TextBox()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvpatientrec = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvpatientrec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidshow
        '
        Me.txtidshow.BackColor = System.Drawing.Color.LightCyan
        Me.txtidshow.Location = New System.Drawing.Point(37, 82)
        Me.txtidshow.Name = "txtidshow"
        Me.txtidshow.Size = New System.Drawing.Size(100, 20)
        Me.txtidshow.TabIndex = 17
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.LightCyan
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(1095, 460)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(95, 49)
        Me.btnedit.TabIndex = 15
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightCyan
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1208, 460)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 49)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dgvpatientrec
        '
        Me.dgvpatientrec.AllowUserToAddRows = False
        Me.dgvpatientrec.AllowUserToDeleteRows = False
        Me.dgvpatientrec.BackgroundColor = System.Drawing.Color.LightCyan
        Me.dgvpatientrec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpatientrec.Location = New System.Drawing.Point(34, 128)
        Me.dgvpatientrec.Name = "dgvpatientrec"
        Me.dgvpatientrec.ReadOnly = True
        Me.dgvpatientrec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvpatientrec.Size = New System.Drawing.Size(1262, 301)
        Me.dgvpatientrec.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Patient ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(535, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 33)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Patient Record"
        '
        'frmpatientsrecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1322, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidshow)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvpatientrec)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmpatientsrecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patients Records"
        CType(Me.dgvpatientrec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtidshow As TextBox
    Friend WithEvents btnedit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvpatientrec As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
