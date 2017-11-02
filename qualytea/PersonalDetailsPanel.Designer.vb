<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalDetailsComponent
    Inherits System.Windows.Forms.UserControl



    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonalDetailsComponent))
        Me.panel_personal = New System.Windows.Forms.Panel
        Me.emp_emergency_contact = New System.Windows.Forms.Label
        Me.emp_e_contact_person = New System.Windows.Forms.Label
        Me.emp_address = New System.Windows.Forms.Label
        Me.lbl_emergency_contact = New System.Windows.Forms.Label
        Me.lbl_e_contact_person = New System.Windows.Forms.Label
        Me.lbl_address = New System.Windows.Forms.Label
        Me.emp_national_id = New System.Windows.Forms.Label
        Me.emp_birthdate = New System.Windows.Forms.Label
        Me.emp_nationality = New System.Windows.Forms.Label
        Me.emp_gender = New System.Windows.Forms.Label
        Me.lbl_gender = New System.Windows.Forms.Label
        Me.lbl_national_id = New System.Windows.Forms.Label
        Me.lbl_dob = New System.Windows.Forms.Label
        Me.lbl_nationality = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.img_profile = New System.Windows.Forms.PictureBox
        Me.btn_change_password = New System.Windows.Forms.Button
        Me.btn_edit_profile = New System.Windows.Forms.Button
        Me.emp_job = New System.Windows.Forms.Label
        Me.lbl_job = New System.Windows.Forms.Label
        Me.lbl_emp_id = New System.Windows.Forms.Label
        Me.emp_id = New System.Windows.Forms.Label
        Me.emp_department = New System.Windows.Forms.Label
        Me.emp_salary = New System.Windows.Forms.Label
        Me.emp_hire_date = New System.Windows.Forms.Label
        Me.lbl_department = New System.Windows.Forms.Label
        Me.lbl_salary = New System.Windows.Forms.Label
        Me.lbl_hire_date = New System.Windows.Forms.Label
        Me.emp_phone_no = New System.Windows.Forms.Label
        Me.lbl_phone_no = New System.Windows.Forms.Label
        Me.emp_email = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.emp_last_name = New System.Windows.Forms.Label
        Me.lbl_last_name = New System.Windows.Forms.Label
        Me.emp_first_name = New System.Windows.Forms.Label
        Me.lbl_first_name = New System.Windows.Forms.Label
        Me.lbl_personal_title = New System.Windows.Forms.Label
        Me.edit_profile_tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.panel_personal.SuspendLayout()
        CType(Me.img_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_personal
        '
        Me.panel_personal.Controls.Add(Me.emp_emergency_contact)
        Me.panel_personal.Controls.Add(Me.emp_e_contact_person)
        Me.panel_personal.Controls.Add(Me.emp_address)
        Me.panel_personal.Controls.Add(Me.lbl_emergency_contact)
        Me.panel_personal.Controls.Add(Me.lbl_e_contact_person)
        Me.panel_personal.Controls.Add(Me.lbl_address)
        Me.panel_personal.Controls.Add(Me.emp_national_id)
        Me.panel_personal.Controls.Add(Me.emp_birthdate)
        Me.panel_personal.Controls.Add(Me.emp_nationality)
        Me.panel_personal.Controls.Add(Me.emp_gender)
        Me.panel_personal.Controls.Add(Me.lbl_gender)
        Me.panel_personal.Controls.Add(Me.lbl_national_id)
        Me.panel_personal.Controls.Add(Me.lbl_dob)
        Me.panel_personal.Controls.Add(Me.lbl_nationality)
        Me.panel_personal.Controls.Add(Me.Label2)
        Me.panel_personal.Controls.Add(Me.Label1)
        Me.panel_personal.Controls.Add(Me.img_profile)
        Me.panel_personal.Controls.Add(Me.btn_change_password)
        Me.panel_personal.Controls.Add(Me.btn_edit_profile)
        Me.panel_personal.Controls.Add(Me.emp_job)
        Me.panel_personal.Controls.Add(Me.lbl_job)
        Me.panel_personal.Controls.Add(Me.lbl_emp_id)
        Me.panel_personal.Controls.Add(Me.emp_id)
        Me.panel_personal.Controls.Add(Me.emp_department)
        Me.panel_personal.Controls.Add(Me.emp_salary)
        Me.panel_personal.Controls.Add(Me.emp_hire_date)
        Me.panel_personal.Controls.Add(Me.lbl_department)
        Me.panel_personal.Controls.Add(Me.lbl_salary)
        Me.panel_personal.Controls.Add(Me.lbl_hire_date)
        Me.panel_personal.Controls.Add(Me.emp_phone_no)
        Me.panel_personal.Controls.Add(Me.lbl_phone_no)
        Me.panel_personal.Controls.Add(Me.emp_email)
        Me.panel_personal.Controls.Add(Me.lbl_email)
        Me.panel_personal.Controls.Add(Me.emp_last_name)
        Me.panel_personal.Controls.Add(Me.lbl_last_name)
        Me.panel_personal.Controls.Add(Me.emp_first_name)
        Me.panel_personal.Controls.Add(Me.lbl_first_name)
        Me.panel_personal.Controls.Add(Me.lbl_personal_title)
        Me.panel_personal.Location = New System.Drawing.Point(3, -2)
        Me.panel_personal.Name = "panel_personal"
        Me.panel_personal.Size = New System.Drawing.Size(793, 693)
        Me.panel_personal.TabIndex = 3
        '
        'emp_emergency_contact
        '
        Me.emp_emergency_contact.AutoSize = True
        Me.emp_emergency_contact.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_emergency_contact.Location = New System.Drawing.Point(582, 445)
        Me.emp_emergency_contact.MaximumSize = New System.Drawing.Size(400, 0)
        Me.emp_emergency_contact.Name = "emp_emergency_contact"
        Me.emp_emergency_contact.Size = New System.Drawing.Size(104, 16)
        Me.emp_emergency_contact.TabIndex = 39
        Me.emp_emergency_contact.Text = "017-7778888"
        '
        'emp_e_contact_person
        '
        Me.emp_e_contact_person.AutoSize = True
        Me.emp_e_contact_person.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_e_contact_person.Location = New System.Drawing.Point(349, 445)
        Me.emp_e_contact_person.MaximumSize = New System.Drawing.Size(400, 0)
        Me.emp_e_contact_person.Name = "emp_e_contact_person"
        Me.emp_e_contact_person.Size = New System.Drawing.Size(98, 16)
        Me.emp_e_contact_person.TabIndex = 38
        Me.emp_e_contact_person.Text = "Lim Kee Loon"
        '
        'emp_address
        '
        Me.emp_address.AutoSize = True
        Me.emp_address.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_address.Location = New System.Drawing.Point(21, 445)
        Me.emp_address.MaximumSize = New System.Drawing.Size(400, 0)
        Me.emp_address.Name = "emp_address"
        Me.emp_address.Size = New System.Drawing.Size(186, 16)
        Me.emp_address.TabIndex = 37
        Me.emp_address.Text = "20, Lorong 4, Taman Indah"
        '
        'lbl_emergency_contact
        '
        Me.lbl_emergency_contact.AutoSize = True
        Me.lbl_emergency_contact.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emergency_contact.Location = New System.Drawing.Point(582, 417)
        Me.lbl_emergency_contact.Name = "lbl_emergency_contact"
        Me.lbl_emergency_contact.Size = New System.Drawing.Size(110, 15)
        Me.lbl_emergency_contact.TabIndex = 36
        Me.lbl_emergency_contact.Text = "Emergency Contact"
        '
        'lbl_e_contact_person
        '
        Me.lbl_e_contact_person.AutoSize = True
        Me.lbl_e_contact_person.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_e_contact_person.Location = New System.Drawing.Point(349, 417)
        Me.lbl_e_contact_person.Name = "lbl_e_contact_person"
        Me.lbl_e_contact_person.Size = New System.Drawing.Size(155, 15)
        Me.lbl_e_contact_person.TabIndex = 35
        Me.lbl_e_contact_person.Text = "Emergency Contact (Person)"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.Location = New System.Drawing.Point(21, 417)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(49, 15)
        Me.lbl_address.TabIndex = 34
        Me.lbl_address.Text = "Address"
        '
        'emp_national_id
        '
        Me.emp_national_id.AutoSize = True
        Me.emp_national_id.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_national_id.Location = New System.Drawing.Point(582, 334)
        Me.emp_national_id.Name = "emp_national_id"
        Me.emp_national_id.Size = New System.Drawing.Size(128, 16)
        Me.emp_national_id.TabIndex = 33
        Me.emp_national_id.Text = "900502-02-5302"
        '
        'emp_birthdate
        '
        Me.emp_birthdate.AutoSize = True
        Me.emp_birthdate.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_birthdate.Location = New System.Drawing.Point(349, 334)
        Me.emp_birthdate.Name = "emp_birthdate"
        Me.emp_birthdate.Size = New System.Drawing.Size(94, 16)
        Me.emp_birthdate.TabIndex = 32
        Me.emp_birthdate.Text = "19/11/2012"
        '
        'emp_nationality
        '
        Me.emp_nationality.AutoSize = True
        Me.emp_nationality.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_nationality.Location = New System.Drawing.Point(198, 334)
        Me.emp_nationality.Name = "emp_nationality"
        Me.emp_nationality.Size = New System.Drawing.Size(76, 16)
        Me.emp_nationality.TabIndex = 31
        Me.emp_nationality.Text = "Malaysian"
        '
        'emp_gender
        '
        Me.emp_gender.AutoSize = True
        Me.emp_gender.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_gender.Location = New System.Drawing.Point(21, 334)
        Me.emp_gender.Name = "emp_gender"
        Me.emp_gender.Size = New System.Drawing.Size(41, 16)
        Me.emp_gender.TabIndex = 30
        Me.emp_gender.Text = "Male"
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.Location = New System.Drawing.Point(21, 308)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(46, 15)
        Me.lbl_gender.TabIndex = 29
        Me.lbl_gender.Text = "Gender"
        '
        'lbl_national_id
        '
        Me.lbl_national_id.AutoSize = True
        Me.lbl_national_id.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_national_id.Location = New System.Drawing.Point(582, 308)
        Me.lbl_national_id.Name = "lbl_national_id"
        Me.lbl_national_id.Size = New System.Drawing.Size(88, 15)
        Me.lbl_national_id.TabIndex = 28
        Me.lbl_national_id.Text = "NRIC/ Passport"
        '
        'lbl_dob
        '
        Me.lbl_dob.AutoSize = True
        Me.lbl_dob.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dob.Location = New System.Drawing.Point(349, 308)
        Me.lbl_dob.Name = "lbl_dob"
        Me.lbl_dob.Size = New System.Drawing.Size(75, 15)
        Me.lbl_dob.TabIndex = 27
        Me.lbl_dob.Text = "Date of Birth"
        '
        'lbl_nationality
        '
        Me.lbl_nationality.AutoSize = True
        Me.lbl_nationality.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nationality.Location = New System.Drawing.Point(198, 308)
        Me.lbl_nationality.Name = "lbl_nationality"
        Me.lbl_nationality.Size = New System.Drawing.Size(65, 15)
        Me.lbl_nationality.TabIndex = 26
        Me.lbl_nationality.Text = "Nationality"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 501)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Job Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Contact Information"
        '
        'img_profile
        '
        Me.img_profile.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.img_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.img_profile.Image = CType(resources.GetObject("img_profile.Image"), System.Drawing.Image)
        Me.img_profile.InitialImage = CType(resources.GetObject("img_profile.InitialImage"), System.Drawing.Image)
        Me.img_profile.Location = New System.Drawing.Point(23, 64)
        Me.img_profile.Name = "img_profile"
        Me.img_profile.Size = New System.Drawing.Size(144, 171)
        Me.img_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.img_profile.TabIndex = 23
        Me.img_profile.TabStop = False
        Me.edit_profile_tooltip.SetToolTip(Me.img_profile, "Click to edit profile picture")
        '
        'btn_change_password
        '
        Me.btn_change_password.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_change_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_change_password.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.btn_change_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_change_password.Location = New System.Drawing.Point(324, 191)
        Me.btn_change_password.Name = "btn_change_password"
        Me.btn_change_password.Size = New System.Drawing.Size(155, 36)
        Me.btn_change_password.TabIndex = 22
        Me.btn_change_password.Text = "Change Password"
        Me.btn_change_password.UseVisualStyleBackColor = False
        '
        'btn_edit_profile
        '
        Me.btn_edit_profile.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_edit_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_profile.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.btn_edit_profile.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit_profile.Location = New System.Drawing.Point(190, 191)
        Me.btn_edit_profile.Name = "btn_edit_profile"
        Me.btn_edit_profile.Size = New System.Drawing.Size(110, 36)
        Me.btn_edit_profile.TabIndex = 21
        Me.btn_edit_profile.Text = "Edit Profile"
        Me.btn_edit_profile.UseVisualStyleBackColor = False
        '
        'emp_job
        '
        Me.emp_job.AutoSize = True
        Me.emp_job.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_job.Location = New System.Drawing.Point(198, 580)
        Me.emp_job.Name = "emp_job"
        Me.emp_job.Size = New System.Drawing.Size(61, 16)
        Me.emp_job.TabIndex = 18
        Me.emp_job.Text = "Random"
        '
        'lbl_job
        '
        Me.lbl_job.AutoSize = True
        Me.lbl_job.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_job.Location = New System.Drawing.Point(198, 550)
        Me.lbl_job.Name = "lbl_job"
        Me.lbl_job.Size = New System.Drawing.Size(26, 15)
        Me.lbl_job.TabIndex = 17
        Me.lbl_job.Text = "Job"
        '
        'lbl_emp_id
        '
        Me.lbl_emp_id.AutoSize = True
        Me.lbl_emp_id.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emp_id.Location = New System.Drawing.Point(28, 29)
        Me.lbl_emp_id.Name = "lbl_emp_id"
        Me.lbl_emp_id.Size = New System.Drawing.Size(75, 15)
        Me.lbl_emp_id.TabIndex = 16
        Me.lbl_emp_id.Text = "Employee Id:"
        '
        'emp_id
        '
        Me.emp_id.AutoSize = True
        Me.emp_id.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_id.Location = New System.Drawing.Point(109, 29)
        Me.emp_id.Name = "emp_id"
        Me.emp_id.Size = New System.Drawing.Size(14, 15)
        Me.emp_id.TabIndex = 15
        Me.emp_id.Text = "0"
        '
        'emp_department
        '
        Me.emp_department.AutoSize = True
        Me.emp_department.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_department.Location = New System.Drawing.Point(349, 580)
        Me.emp_department.Name = "emp_department"
        Me.emp_department.Size = New System.Drawing.Size(106, 16)
        Me.emp_department.TabIndex = 14
        Me.emp_department.Text = "Administration"
        '
        'emp_salary
        '
        Me.emp_salary.AutoSize = True
        Me.emp_salary.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_salary.Location = New System.Drawing.Point(23, 580)
        Me.emp_salary.Name = "emp_salary"
        Me.emp_salary.Size = New System.Drawing.Size(53, 16)
        Me.emp_salary.TabIndex = 13
        Me.emp_salary.Text = "$3000"
        '
        'emp_hire_date
        '
        Me.emp_hire_date.AutoSize = True
        Me.emp_hire_date.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_hire_date.Location = New System.Drawing.Point(582, 580)
        Me.emp_hire_date.Name = "emp_hire_date"
        Me.emp_hire_date.Size = New System.Drawing.Size(94, 16)
        Me.emp_hire_date.TabIndex = 12
        Me.emp_hire_date.Text = "19/11/2012"
        '
        'lbl_department
        '
        Me.lbl_department.AutoSize = True
        Me.lbl_department.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_department.Location = New System.Drawing.Point(349, 550)
        Me.lbl_department.Name = "lbl_department"
        Me.lbl_department.Size = New System.Drawing.Size(70, 15)
        Me.lbl_department.TabIndex = 11
        Me.lbl_department.Text = "Department"
        '
        'lbl_salary
        '
        Me.lbl_salary.AutoSize = True
        Me.lbl_salary.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_salary.Location = New System.Drawing.Point(23, 550)
        Me.lbl_salary.Name = "lbl_salary"
        Me.lbl_salary.Size = New System.Drawing.Size(39, 15)
        Me.lbl_salary.TabIndex = 10
        Me.lbl_salary.Text = "Salary"
        '
        'lbl_hire_date
        '
        Me.lbl_hire_date.AutoSize = True
        Me.lbl_hire_date.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hire_date.Location = New System.Drawing.Point(582, 550)
        Me.lbl_hire_date.Name = "lbl_hire_date"
        Me.lbl_hire_date.Size = New System.Drawing.Size(57, 15)
        Me.lbl_hire_date.TabIndex = 9
        Me.lbl_hire_date.Text = "Hire Date"
        '
        'emp_phone_no
        '
        Me.emp_phone_no.AutoSize = True
        Me.emp_phone_no.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_phone_no.Location = New System.Drawing.Point(495, 152)
        Me.emp_phone_no.Name = "emp_phone_no"
        Me.emp_phone_no.Size = New System.Drawing.Size(104, 16)
        Me.emp_phone_no.TabIndex = 8
        Me.emp_phone_no.Text = "016-6667777"
        '
        'lbl_phone_no
        '
        Me.lbl_phone_no.AutoSize = True
        Me.lbl_phone_no.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone_no.Location = New System.Drawing.Point(495, 134)
        Me.lbl_phone_no.Name = "lbl_phone_no"
        Me.lbl_phone_no.Size = New System.Drawing.Size(60, 15)
        Me.lbl_phone_no.TabIndex = 7
        Me.lbl_phone_no.Text = "Phone No"
        '
        'emp_email
        '
        Me.emp_email.AutoSize = True
        Me.emp_email.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_email.Location = New System.Drawing.Point(187, 152)
        Me.emp_email.Name = "emp_email"
        Me.emp_email.Size = New System.Drawing.Size(136, 16)
        Me.emp_email.TabIndex = 6
        Me.emp_email.Text = "test@qualytea.com"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(187, 134)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(39, 15)
        Me.lbl_email.TabIndex = 5
        Me.lbl_email.Text = "Email "
        '
        'emp_last_name
        '
        Me.emp_last_name.AutoSize = True
        Me.emp_last_name.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_last_name.Location = New System.Drawing.Point(493, 80)
        Me.emp_last_name.Name = "emp_last_name"
        Me.emp_last_name.Size = New System.Drawing.Size(51, 25)
        Me.emp_last_name.TabIndex = 4
        Me.emp_last_name.Text = "Lim "
        '
        'lbl_last_name
        '
        Me.lbl_last_name.AutoSize = True
        Me.lbl_last_name.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_last_name.Location = New System.Drawing.Point(493, 65)
        Me.lbl_last_name.Name = "lbl_last_name"
        Me.lbl_last_name.Size = New System.Drawing.Size(62, 15)
        Me.lbl_last_name.TabIndex = 3
        Me.lbl_last_name.Text = "Last Name"
        '
        'emp_first_name
        '
        Me.emp_first_name.AutoSize = True
        Me.emp_first_name.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_first_name.Location = New System.Drawing.Point(185, 80)
        Me.emp_first_name.Name = "emp_first_name"
        Me.emp_first_name.Size = New System.Drawing.Size(92, 25)
        Me.emp_first_name.TabIndex = 2
        Me.emp_first_name.Text = "Ying Yee"
        '
        'lbl_first_name
        '
        Me.lbl_first_name.AutoSize = True
        Me.lbl_first_name.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_first_name.Location = New System.Drawing.Point(187, 64)
        Me.lbl_first_name.Name = "lbl_first_name"
        Me.lbl_first_name.Size = New System.Drawing.Size(64, 15)
        Me.lbl_first_name.TabIndex = 1
        Me.lbl_first_name.Text = "First Name"
        '
        'lbl_personal_title
        '
        Me.lbl_personal_title.AutoSize = True
        Me.lbl_personal_title.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_personal_title.Location = New System.Drawing.Point(20, 269)
        Me.lbl_personal_title.Name = "lbl_personal_title"
        Me.lbl_personal_title.Size = New System.Drawing.Size(191, 23)
        Me.lbl_personal_title.TabIndex = 0
        Me.lbl_personal_title.Text = "Personal Information"
        '
        'edit_profile_tooltip
        '
        Me.edit_profile_tooltip.AutoPopDelay = 5000
        Me.edit_profile_tooltip.InitialDelay = 500
        Me.edit_profile_tooltip.ReshowDelay = 10
        Me.edit_profile_tooltip.ShowAlways = True
        Me.edit_profile_tooltip.ToolTipTitle = "Profile Picture"
        '
        'PersonalDetailsComponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.panel_personal)
        Me.Name = "PersonalDetailsComponent"
        Me.Size = New System.Drawing.Size(799, 691)
        Me.panel_personal.ResumeLayout(False)
        Me.panel_personal.PerformLayout()
        CType(Me.img_profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_personal As System.Windows.Forms.Panel
    Friend WithEvents emp_job As System.Windows.Forms.Label
    Friend WithEvents lbl_job As System.Windows.Forms.Label
    Friend WithEvents lbl_emp_id As System.Windows.Forms.Label
    Friend WithEvents emp_id As System.Windows.Forms.Label
    Friend WithEvents emp_department As System.Windows.Forms.Label
    Friend WithEvents emp_salary As System.Windows.Forms.Label
    Friend WithEvents emp_hire_date As System.Windows.Forms.Label
    Friend WithEvents lbl_department As System.Windows.Forms.Label
    Friend WithEvents lbl_salary As System.Windows.Forms.Label
    Friend WithEvents lbl_hire_date As System.Windows.Forms.Label
    Friend WithEvents emp_phone_no As System.Windows.Forms.Label
    Friend WithEvents lbl_phone_no As System.Windows.Forms.Label
    Friend WithEvents emp_email As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents emp_last_name As System.Windows.Forms.Label
    Friend WithEvents lbl_last_name As System.Windows.Forms.Label
    Friend WithEvents emp_first_name As System.Windows.Forms.Label
    Friend WithEvents lbl_first_name As System.Windows.Forms.Label
    Friend WithEvents lbl_personal_title As System.Windows.Forms.Label
    Friend WithEvents btn_edit_profile As System.Windows.Forms.Button
    Friend WithEvents btn_change_password As System.Windows.Forms.Button
    Friend WithEvents img_profile As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_national_id As System.Windows.Forms.Label
    Friend WithEvents lbl_dob As System.Windows.Forms.Label
    Friend WithEvents lbl_nationality As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents emp_national_id As System.Windows.Forms.Label
    Friend WithEvents emp_birthdate As System.Windows.Forms.Label
    Friend WithEvents emp_nationality As System.Windows.Forms.Label
    Friend WithEvents emp_gender As System.Windows.Forms.Label
    Friend WithEvents lbl_gender As System.Windows.Forms.Label
    Friend WithEvents lbl_emergency_contact As System.Windows.Forms.Label
    Friend WithEvents lbl_e_contact_person As System.Windows.Forms.Label
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents emp_address As System.Windows.Forms.Label
    Friend WithEvents emp_emergency_contact As System.Windows.Forms.Label
    Friend WithEvents emp_e_contact_person As System.Windows.Forms.Label
    Friend WithEvents edit_profile_tooltip As System.Windows.Forms.ToolTip



End Class
