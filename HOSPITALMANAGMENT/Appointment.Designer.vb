<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRemarks = New System.Windows.Forms.TextBox()
        Me.DTPDates = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDoctorIDs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPatientIDs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAppointment = New System.Windows.Forms.TextBox()
        Me.lbappointment = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightCyan
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(332, 351)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(78, 46)
        Me.btnClose.TabIndex = 80
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightCyan
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(246, 351)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 46)
        Me.btnAdd.TabIndex = 79
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 14)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Remarks"
        '
        'TxtRemarks
        '
        Me.TxtRemarks.BackColor = System.Drawing.Color.LightCyan
        Me.TxtRemarks.ForeColor = System.Drawing.Color.Black
        Me.TxtRemarks.Location = New System.Drawing.Point(21, 193)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(389, 140)
        Me.TxtRemarks.TabIndex = 77
        '
        'DTPDates
        '
        Me.DTPDates.Location = New System.Drawing.Point(235, 96)
        Me.DTPDates.Name = "DTPDates"
        Me.DTPDates.Size = New System.Drawing.Size(173, 20)
        Me.DTPDates.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(235, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 14)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Appointment Date"
        '
        'txtDoctorIDs
        '
        Me.txtDoctorIDs.BackColor = System.Drawing.Color.LightCyan
        Me.txtDoctorIDs.Location = New System.Drawing.Point(124, 97)
        Me.txtDoctorIDs.Name = "txtDoctorIDs"
        Me.txtDoctorIDs.Size = New System.Drawing.Size(89, 20)
        Me.txtDoctorIDs.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "DoctorID"
        '
        'txtPatientIDs
        '
        Me.txtPatientIDs.BackColor = System.Drawing.Color.LightCyan
        Me.txtPatientIDs.Location = New System.Drawing.Point(21, 97)
        Me.txtPatientIDs.Name = "txtPatientIDs"
        Me.txtPatientIDs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPatientIDs.Size = New System.Drawing.Size(91, 20)
        Me.txtPatientIDs.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 14)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "PatientID"
        '
        'txtAppointment
        '
        Me.txtAppointment.BackColor = System.Drawing.Color.LightCyan
        Me.txtAppointment.Location = New System.Drawing.Point(27, 368)
        Me.txtAppointment.Name = "txtAppointment"
        Me.txtAppointment.Size = New System.Drawing.Size(85, 20)
        Me.txtAppointment.TabIndex = 70
        '
        'lbappointment
        '
        Me.lbappointment.AutoSize = True
        Me.lbappointment.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbappointment.Location = New System.Drawing.Point(26, 354)
        Me.lbappointment.Name = "lbappointment"
        Me.lbappointment.Size = New System.Drawing.Size(82, 14)
        Me.lbappointment.TabIndex = 69
        Me.lbappointment.Text = "AppointmentID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 14)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.BackColor = System.Drawing.Color.LightCyan
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Done", "Waiting", "Ongoing", "NoAppoint"})
        Me.cbStatus.Location = New System.Drawing.Point(22, 144)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(90, 21)
        Me.cbStatus.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(133, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 31)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Appointment"
        '
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(433, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtRemarks)
        Me.Controls.Add(Me.DTPDates)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDoctorIDs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPatientIDs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAppointment)
        Me.Controls.Add(Me.lbappointment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Appointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appointment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtRemarks As TextBox
    Friend WithEvents DTPDates As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDoctorIDs As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPatientIDs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAppointment As TextBox
    Friend WithEvents lbappointment As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label6 As Label
End Class
