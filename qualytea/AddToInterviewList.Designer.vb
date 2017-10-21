<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddToInterviewList
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
        Me.lbl_first_name = New System.Windows.Forms.Label
        Me.first_name = New System.Windows.Forms.Label
        Me.lbl_interview_date = New System.Windows.Forms.Label
        Me.interview_date = New System.Windows.Forms.MonthCalendar
        Me.Label1 = New System.Windows.Forms.Label
        Me.dropdown_interview_time = New System.Windows.Forms.ComboBox
        Me.dropdown_interview_by = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dropdown_interview_venue = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_last_name = New System.Windows.Forms.Label
        Me.last_name = New System.Windows.Forms.Label
        Me.lbl_gender = New System.Windows.Forms.Label
        Me.gender = New System.Windows.Forms.Label
        Me.lbl_national_id = New System.Windows.Forms.Label
        Me.national_id = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.email_address = New System.Windows.Forms.Label
        Me.lbl_tel_no = New System.Windows.Forms.Label
        Me.tel_no = New System.Windows.Forms.Label
        Me.lbl_position_applied = New System.Windows.Forms.Label
        Me.position_applied = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btn_edit_profile = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbl_first_name
        '
        Me.lbl_first_name.AutoSize = True
        Me.lbl_first_name.Font = New System.Drawing.Font("Lato Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_first_name.Location = New System.Drawing.Point(67, 51)
        Me.lbl_first_name.Name = "lbl_first_name"
        Me.lbl_first_name.Size = New System.Drawing.Size(91, 18)
        Me.lbl_first_name.TabIndex = 0
        Me.lbl_first_name.Text = "First Name"
        '
        'first_name
        '
        Me.first_name.AutoSize = True
        Me.first_name.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_name.Location = New System.Drawing.Point(296, 51)
        Me.first_name.Name = "first_name"
        Me.first_name.Size = New System.Drawing.Size(112, 18)
        Me.first_name.TabIndex = 1
        Me.first_name.Text = "your first name"
        '
        'lbl_interview_date
        '
        Me.lbl_interview_date.AutoSize = True
        Me.lbl_interview_date.Font = New System.Drawing.Font("Lato Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_interview_date.Location = New System.Drawing.Point(525, 51)
        Me.lbl_interview_date.Name = "lbl_interview_date"
        Me.lbl_interview_date.Size = New System.Drawing.Size(121, 18)
        Me.lbl_interview_date.TabIndex = 2
        Me.lbl_interview_date.Text = "Interview Date"
        '
        'interview_date
        '
        Me.interview_date.Location = New System.Drawing.Point(528, 78)
        Me.interview_date.MaxSelectionCount = 1
        Me.interview_date.Name = "interview_date"
        Me.interview_date.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(525, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Interview Time"
        '
        'dropdown_interview_time
        '
        Me.dropdown_interview_time.FormattingEnabled = True
        Me.dropdown_interview_time.Items.AddRange(New Object() {"9.00AM - 10.00AM", "10.00AM - 11.00AM", "11.00AM - 12.00PM", "2.00PM - 3.00PM", "3.00PM - 4.00PM", "4.00PM - 5.00PM"})
        Me.dropdown_interview_time.Location = New System.Drawing.Point(525, 288)
        Me.dropdown_interview_time.Name = "dropdown_interview_time"
        Me.dropdown_interview_time.Size = New System.Drawing.Size(294, 20)
        Me.dropdown_interview_time.TabIndex = 5
        '
        'dropdown_interview_by
        '
        Me.dropdown_interview_by.FormattingEnabled = True
        Me.dropdown_interview_by.Items.AddRange(New Object() {"Lim Ying Yee", "Sarvesh Rau A/L Lechum", "Sufinaz Binti Marzuki", "Anwar Faiz Bin Mohd Ali"})
        Me.dropdown_interview_by.Location = New System.Drawing.Point(525, 427)
        Me.dropdown_interview_by.Name = "dropdown_interview_by"
        Me.dropdown_interview_by.Size = New System.Drawing.Size(294, 20)
        Me.dropdown_interview_by.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(525, 406)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Interview By"
        '
        'dropdown_interview_venue
        '
        Me.dropdown_interview_venue.FormattingEnabled = True
        Me.dropdown_interview_venue.Items.AddRange(New Object() {"HQ Office, Grande Height - Meeting Room ", "HQ Office, Grande Height - Conference Room", "HQ Office, Grande Height - Training Room"})
        Me.dropdown_interview_venue.Location = New System.Drawing.Point(525, 358)
        Me.dropdown_interview_venue.Name = "dropdown_interview_venue"
        Me.dropdown_interview_venue.Size = New System.Drawing.Size(294, 20)
        Me.dropdown_interview_venue.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lato Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(525, 337)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Interview Venue"
        '
        'lbl_last_name
        '
        Me.lbl_last_name.AutoSize = True
        Me.lbl_last_name.Font = New System.Drawing.Font("Lato Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_last_name.Location = New System.Drawing.Point(67, 113)
        Me.lbl_last_name.Name = "lbl_last_name"
        Me.lbl_last_name.Size = New System.Drawing.Size(88, 18)
        Me.lbl_last_name.TabIndex = 10
        Me.lbl_last_name.Text = "Last Name"
        '
        'last_name
        '
        Me.last_name.AutoSize = True
        Me.last_name.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_name.Location = New System.Drawing.Point(296, 113)
        Me.last_name.Name = "last_name"
        Me.last_name.Size = New System.Drawing.Size(109, 18)
        Me.last_name.TabIndex = 11
        Me.last_name.Text = "your last name"
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Font = New System.Drawing.Font("Lato Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.Location = New System.Drawing.Point(67, 175)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(63, 18)
        Me.lbl_gender.TabIndex = 12
        Me.lbl_gender.Text = "Gender"
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.Location = New System.Drawing.Point(296, 175)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(90, 18)
        Me.gender.TabIndex = 13
        Me.gender.Text = "your gender"
        '
        'lbl_national_id
        '
        Me.lbl_national_id.AutoSize = True
        Me.lbl_national_id.Font = New System.Drawing.Font("Lato Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_national_id.Location = New System.Drawing.Point(68, 299)
        Me.lbl_national_id.Name = "lbl_national_id"
        Me.lbl_national_id.Size = New System.Drawing.Size(121, 18)
        Me.lbl_national_id.TabIndex = 14
        Me.lbl_national_id.Text = "NRIC/Passport"
        '
        'national_id
        '
        Me.national_id.AutoSize = True
        Me.national_id.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.national_id.Location = New System.Drawing.Point(296, 237)
        Me.national_id.Name = "national_id"
        Me.national_id.Size = New System.Drawing.Size(117, 18)
        Me.national_id.TabIndex = 15
        Me.national_id.Text = "your national ID"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Lato Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(67, 237)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(50, 18)
        Me.lbl_email.TabIndex = 16
        Me.lbl_email.Text = "Email"
        '
        'email_address
        '
        Me.email_address.AutoSize = True
        Me.email_address.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_address.Location = New System.Drawing.Point(296, 299)
        Me.email_address.Name = "email_address"
        Me.email_address.Size = New System.Drawing.Size(80, 18)
        Me.email_address.TabIndex = 17
        Me.email_address.Text = "your email"
        '
        'lbl_tel_no
        '
        Me.lbl_tel_no.AutoSize = True
        Me.lbl_tel_no.Font = New System.Drawing.Font("Lato Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tel_no.Location = New System.Drawing.Point(68, 361)
        Me.lbl_tel_no.Name = "lbl_tel_no"
        Me.lbl_tel_no.Size = New System.Drawing.Size(62, 18)
        Me.lbl_tel_no.TabIndex = 18
        Me.lbl_tel_no.Text = "Tel No."
        '
        'tel_no
        '
        Me.tel_no.AutoSize = True
        Me.tel_no.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tel_no.Location = New System.Drawing.Point(296, 361)
        Me.tel_no.Name = "tel_no"
        Me.tel_no.Size = New System.Drawing.Size(82, 18)
        Me.tel_no.TabIndex = 19
        Me.tel_no.Text = "your tel no"
        '
        'lbl_position_applied
        '
        Me.lbl_position_applied.AutoSize = True
        Me.lbl_position_applied.Font = New System.Drawing.Font("Lato Medium", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_position_applied.Location = New System.Drawing.Point(67, 423)
        Me.lbl_position_applied.Name = "lbl_position_applied"
        Me.lbl_position_applied.Size = New System.Drawing.Size(131, 18)
        Me.lbl_position_applied.TabIndex = 20
        Me.lbl_position_applied.Text = "Position Applied"
        '
        'position_applied
        '
        Me.position_applied.AutoSize = True
        Me.position_applied.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.position_applied.Location = New System.Drawing.Point(296, 423)
        Me.position_applied.Name = "position_applied"
        Me.position_applied.Size = New System.Drawing.Size(99, 18)
        Me.position_applied.TabIndex = 21
        Me.position_applied.Text = "your position"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(70, 532)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 33)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_edit_profile
        '
        Me.btn_edit_profile.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_edit_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_profile.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.btn_edit_profile.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit_profile.Location = New System.Drawing.Point(601, 532)
        Me.btn_edit_profile.Name = "btn_edit_profile"
        Me.btn_edit_profile.Size = New System.Drawing.Size(218, 33)
        Me.btn_edit_profile.TabIndex = 61
        Me.btn_edit_profile.Text = "Confirm"
        Me.btn_edit_profile.UseVisualStyleBackColor = False
        '
        'AddToInterviewList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 577)
        Me.Controls.Add(Me.btn_edit_profile)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.position_applied)
        Me.Controls.Add(Me.lbl_position_applied)
        Me.Controls.Add(Me.tel_no)
        Me.Controls.Add(Me.lbl_tel_no)
        Me.Controls.Add(Me.email_address)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.national_id)
        Me.Controls.Add(Me.lbl_national_id)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.last_name)
        Me.Controls.Add(Me.lbl_last_name)
        Me.Controls.Add(Me.dropdown_interview_venue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dropdown_interview_by)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dropdown_interview_time)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.interview_date)
        Me.Controls.Add(Me.lbl_interview_date)
        Me.Controls.Add(Me.first_name)
        Me.Controls.Add(Me.lbl_first_name)
        Me.Name = "AddToInterviewList"
        Me.Text = "AddToInterviewListModal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_first_name As System.Windows.Forms.Label
    Friend WithEvents first_name As System.Windows.Forms.Label
    Friend WithEvents lbl_interview_date As System.Windows.Forms.Label
    Friend WithEvents interview_date As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dropdown_interview_time As System.Windows.Forms.ComboBox
    Friend WithEvents dropdown_interview_by As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dropdown_interview_venue As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_last_name As System.Windows.Forms.Label
    Friend WithEvents last_name As System.Windows.Forms.Label
    Friend WithEvents lbl_gender As System.Windows.Forms.Label
    Friend WithEvents gender As System.Windows.Forms.Label
    Friend WithEvents lbl_national_id As System.Windows.Forms.Label
    Friend WithEvents national_id As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents email_address As System.Windows.Forms.Label
    Friend WithEvents lbl_tel_no As System.Windows.Forms.Label
    Friend WithEvents tel_no As System.Windows.Forms.Label
    Friend WithEvents lbl_position_applied As System.Windows.Forms.Label
    Friend WithEvents position_applied As System.Windows.Forms.Label
    Friend WithEvents resume_file As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_edit_profile As System.Windows.Forms.Button
End Class
