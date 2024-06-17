<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notesrecord
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidshow = New System.Windows.Forms.TextBox()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dgvnotes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvnotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "NotesID"
        '
        'txtidshow
        '
        Me.txtidshow.BackColor = System.Drawing.Color.LightCyan
        Me.txtidshow.Location = New System.Drawing.Point(28, 85)
        Me.txtidshow.Name = "txtidshow"
        Me.txtidshow.Size = New System.Drawing.Size(100, 20)
        Me.txtidshow.TabIndex = 27
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.LightCyan
        Me.btnedit.Location = New System.Drawing.Point(388, 356)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(110, 47)
        Me.btnedit.TabIndex = 26
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightCyan
        Me.btnClose.Location = New System.Drawing.Point(504, 356)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 47)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'dgvnotes
        '
        Me.dgvnotes.AllowUserToAddRows = False
        Me.dgvnotes.AllowUserToDeleteRows = False
        Me.dgvnotes.BackgroundColor = System.Drawing.Color.LightCyan
        Me.dgvnotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvnotes.Location = New System.Drawing.Point(26, 111)
        Me.dgvnotes.Name = "dgvnotes"
        Me.dgvnotes.ReadOnly = True
        Me.dgvnotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvnotes.Size = New System.Drawing.Size(578, 239)
        Me.dgvnotes.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 31)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = " Patientnotes Record"
        '
        'notesrecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(631, 424)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidshow)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvnotes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "notesrecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patientsnotes Records"
        CType(Me.dgvnotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtidshow As TextBox
    Friend WithEvents btnedit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvnotes As DataGridView
    Friend WithEvents Label2 As Label
End Class
