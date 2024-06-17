<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor
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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.lbID = New System.Windows.Forms.Label()
        Me.txtphonenumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dateselect = New System.Windows.Forms.DateTimePicker()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.txtnationality = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmiddlename = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.brnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtfirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtexp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbSpecialty = New System.Windows.Forms.ComboBox()
        Me.cbquali = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.LightCyan
        Me.txtid.Location = New System.Drawing.Point(36, 285)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(92, 20)
        Me.txtid.TabIndex = 68
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(33, 268)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(55, 14)
        Me.lbID.TabIndex = 67
        Me.lbID.Text = "Doctor ID"
        '
        'txtphonenumber
        '
        Me.txtphonenumber.BackColor = System.Drawing.Color.LightCyan
        Me.txtphonenumber.Location = New System.Drawing.Point(36, 231)
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Size = New System.Drawing.Size(165, 20)
        Me.txtphonenumber.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(33, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 14)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Phone Number"
        '
        'dateselect
        '
        Me.dateselect.CalendarMonthBackground = System.Drawing.Color.AliceBlue
        Me.dateselect.Location = New System.Drawing.Point(398, 131)
        Me.dateselect.Name = "dateselect"
        Me.dateselect.Size = New System.Drawing.Size(181, 20)
        Me.dateselect.TabIndex = 53
        '
        'gender
        '
        Me.gender.BackColor = System.Drawing.Color.LightCyan
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.gender.Location = New System.Drawing.Point(282, 130)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(106, 21)
        Me.gender.TabIndex = 52
        '
        'txtnationality
        '
        Me.txtnationality.BackColor = System.Drawing.Color.LightCyan
        Me.txtnationality.Location = New System.Drawing.Point(225, 231)
        Me.txtnationality.Name = "txtnationality"
        Me.txtnationality.Size = New System.Drawing.Size(152, 20)
        Me.txtnationality.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(222, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 14)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Nationality"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(395, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 14)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Date of Birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(279, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 14)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Gender"
        '
        'txtmiddlename
        '
        Me.txtmiddlename.BackColor = System.Drawing.Color.LightCyan
        Me.txtmiddlename.Location = New System.Drawing.Point(427, 81)
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.Size = New System.Drawing.Size(152, 20)
        Me.txtmiddlename.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Middle Name"
        '
        'brnCancel
        '
        Me.brnCancel.BackColor = System.Drawing.Color.AliceBlue
        Me.brnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnCancel.Location = New System.Drawing.Point(493, 285)
        Me.brnCancel.Name = "brnCancel"
        Me.brnCancel.Size = New System.Drawing.Size(86, 42)
        Me.brnCancel.TabIndex = 45
        Me.brnCancel.Text = "CANCEL"
        Me.brnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.AliceBlue
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(388, 285)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 42)
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtfirstName
        '
        Me.txtfirstName.BackColor = System.Drawing.Color.LightCyan
        Me.txtfirstName.Location = New System.Drawing.Point(207, 82)
        Me.txtfirstName.Name = "txtfirstName"
        Me.txtfirstName.Size = New System.Drawing.Size(214, 20)
        Me.txtfirstName.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 14)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "First Name"
        '
        'txtlastname
        '
        Me.txtlastname.BackColor = System.Drawing.Color.LightCyan
        Me.txtlastname.Location = New System.Drawing.Point(32, 81)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(169, 20)
        Me.txtlastname.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Last Name"
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.LightCyan
        Me.txtaddress.Location = New System.Drawing.Point(32, 130)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(244, 20)
        Me.txtaddress.TabIndex = 70
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(30, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 14)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Address"
        '
        'txtexp
        '
        Me.txtexp.BackColor = System.Drawing.Color.LightCyan
        Me.txtexp.Location = New System.Drawing.Point(225, 179)
        Me.txtexp.Name = "txtexp"
        Me.txtexp.Size = New System.Drawing.Size(152, 20)
        Me.txtexp.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(222, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 14)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Year of Experience"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(383, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 14)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Qualification"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 14)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Specialization"
        '
        'cbSpecialty
        '
        Me.cbSpecialty.BackColor = System.Drawing.Color.LightCyan
        Me.cbSpecialty.FormattingEnabled = True
        Me.cbSpecialty.Items.AddRange(New Object() {"Allergy and Immunology", "Anesthesiology", "Cardiology", "Dermatology", "Emergency Medicine", "Endocrinology", "Family Medicine", "Gastroenterology", "Geriatrics", "Hematology", "Infectious Diseases", "Internal Medicine", "Nephrology", "Neurology", "Neurosurgery", "Obstetrics and Gynecology (OB/GYN)", "Oncology", "Ophthalmology", "Orthopedic Surgery", "Otolaryngology (ENT)", "Pediatrics", "Physical Medicine and Rehabilitation (PM&R)", "Plastic Surgery", "Psychiatry", "Pulmonology", "Radiology", "Rheumatology", "Sleep Medicine", "Sports Medicine", "Urology"})
        Me.cbSpecialty.Location = New System.Drawing.Point(33, 178)
        Me.cbSpecialty.Name = "cbSpecialty"
        Me.cbSpecialty.Size = New System.Drawing.Size(168, 21)
        Me.cbSpecialty.TabIndex = 77
        '
        'cbquali
        '
        Me.cbquali.BackColor = System.Drawing.Color.LightCyan
        Me.cbquali.FormattingEnabled = True
        Me.cbquali.Items.AddRange(New Object() {"Doctor of Medicine (M.D.)", "Doctor of Osteopathic Medicine (D.O.)", "Bachelor of Medicine, Bachelor of Surgery (MBBS)", "Bachelor of Surgery (B.S.)", "Doctor of Dental Medicine (DMD)", "Doctor of Pharmacy (Pharm.D.)", "Doctor of Veterinary Medicine (DVM or VMD)", "Doctor of Pharmacy (Pharm.D.)", "Bachelor of Science in Nursing (BSN)", "Licensed Practical Nurse (LPN)", "Doctor of Physical Therapy (DPT)", "Doctor of Chiropractic (D.C.)", "Doctor of Optometry (O.D.)", "Doctor of Podiatric Medicine (DPM)", "Master of Science in Nursing (MSN)", "Physician Assistant (PA-C)", "Doctor of Nursing Practice (DNP)", "Master of Public Health (MPH)", "Master of Health Administration (MHA)", "Doctor of Philosophy (Ph.D.)", "Certified Nursing Assistant (CNA)", "Certified Medical Assistant (CMA)", "Certified Registered Nurse Anesthetist (CRNA)", "Certified Nurse Midwife (CNM)", "Certified Nurse Practitioner (CNP)", " Registered Dietitian Nutritionist (RDN)", "Licensed Clinical Social Worker (LCSW)", "Licensed Marriage and Family Therapist (LMFT)", "Doctor of Clinical Psychology (Psy.D.)", "Doctor of Occupational Therapy (OTD)", "Board Certifications and Specialties"})
        Me.cbquali.Location = New System.Drawing.Point(386, 179)
        Me.cbquali.Name = "cbquali"
        Me.cbquali.Size = New System.Drawing.Size(193, 21)
        Me.cbquali.TabIndex = 78
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(263, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 29)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Doctor"
        '
        'Doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(619, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbquali)
        Me.Controls.Add(Me.cbSpecialty)
        Me.Controls.Add(Me.txtexp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.txtphonenumber)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dateselect)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.txtnationality)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtmiddlename)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.brnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtfirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Doctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtid As TextBox
    Friend WithEvents lbID As Label
    Friend WithEvents txtphonenumber As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dateselect As DateTimePicker
    Friend WithEvents gender As ComboBox
    Friend WithEvents txtnationality As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmiddlename As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents brnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtfirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtexp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbSpecialty As ComboBox
    Friend WithEvents cbquali As ComboBox
    Friend WithEvents Label10 As Label
End Class
