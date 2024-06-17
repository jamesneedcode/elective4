<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patientsnotes
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
        Me.txtDoctorIDs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPatientIDs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnoteIDs = New System.Windows.Forms.TextBox()
        Me.lbnoteid = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPNoteDates = New System.Windows.Forms.DateTimePicker()
        Me.TxtnotedContents = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDoctorIDs
        '
        Me.txtDoctorIDs.BackColor = System.Drawing.Color.LightCyan
        Me.txtDoctorIDs.Location = New System.Drawing.Point(123, 85)
        Me.txtDoctorIDs.Name = "txtDoctorIDs"
        Me.txtDoctorIDs.Size = New System.Drawing.Size(89, 20)
        Me.txtDoctorIDs.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "DoctorID"
        '
        'txtPatientIDs
        '
        Me.txtPatientIDs.BackColor = System.Drawing.Color.LightCyan
        Me.txtPatientIDs.Location = New System.Drawing.Point(26, 85)
        Me.txtPatientIDs.Name = "txtPatientIDs"
        Me.txtPatientIDs.Size = New System.Drawing.Size(91, 20)
        Me.txtPatientIDs.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 14)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "PatientID"
        '
        'txtnoteIDs
        '
        Me.txtnoteIDs.BackColor = System.Drawing.Color.LightCyan
        Me.txtnoteIDs.Location = New System.Drawing.Point(26, 311)
        Me.txtnoteIDs.Name = "txtnoteIDs"
        Me.txtnoteIDs.Size = New System.Drawing.Size(105, 20)
        Me.txtnoteIDs.TabIndex = 49
        '
        'lbnoteid
        '
        Me.lbnoteid.AutoSize = True
        Me.lbnoteid.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnoteid.Location = New System.Drawing.Point(28, 297)
        Me.lbnoteid.Name = "lbnoteid"
        Me.lbnoteid.Size = New System.Drawing.Size(42, 14)
        Me.lbnoteid.TabIndex = 48
        Me.lbnoteid.Text = "NoteID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(229, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 14)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Note Date"
        '
        'DTPNoteDates
        '
        Me.DTPNoteDates.Location = New System.Drawing.Point(229, 84)
        Me.DTPNoteDates.Name = "DTPNoteDates"
        Me.DTPNoteDates.Size = New System.Drawing.Size(186, 20)
        Me.DTPNoteDates.TabIndex = 56
        '
        'TxtnotedContents
        '
        Me.TxtnotedContents.BackColor = System.Drawing.Color.LightCyan
        Me.TxtnotedContents.Location = New System.Drawing.Point(26, 134)
        Me.TxtnotedContents.Multiline = True
        Me.TxtnotedContents.Name = "TxtnotedContents"
        Me.TxtnotedContents.Size = New System.Drawing.Size(389, 140)
        Me.TxtnotedContents.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 14)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Note Content"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(336, 297)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(79, 47)
        Me.btnClose.TabIndex = 68
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(245, 297)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 47)
        Me.btnAdd.TabIndex = 67
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(142, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 31)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "PatientNote"
        '
        'Patientsnotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(440, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtnotedContents)
        Me.Controls.Add(Me.DTPNoteDates)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDoctorIDs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPatientIDs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnoteIDs)
        Me.Controls.Add(Me.lbnoteid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Patientsnotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PatientNote"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDoctorIDs As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPatientIDs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnoteIDs As TextBox
    Friend WithEvents lbnoteid As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DTPNoteDates As DateTimePicker
    Friend WithEvents TxtnotedContents As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button

    Private Sub Patientsnotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Label6 As Label
End Class
