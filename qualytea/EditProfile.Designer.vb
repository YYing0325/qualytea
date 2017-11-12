<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditProfile))
        Me.lbl_personal_title = New System.Windows.Forms.Label
        Me.lbl_first_name = New System.Windows.Forms.Label
        Me.lbl_last_name = New System.Windows.Forms.Label
        Me.lbl_email = New System.Windows.Forms.Label
        Me.lbl_phone_no = New System.Windows.Forms.Label
        Me.emp_id = New System.Windows.Forms.Label
        Me.lbl_emp_id = New System.Windows.Forms.Label
        Me.img_profile = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_nationality = New System.Windows.Forms.Label
        Me.lbl_dob = New System.Windows.Forms.Label
        Me.lbl_national_id = New System.Windows.Forms.Label
        Me.lbl_gender = New System.Windows.Forms.Label
        Me.lbl_address = New System.Windows.Forms.Label
        Me.lbl_e_contact_person = New System.Windows.Forms.Label
        Me.lbl_emergency_contact = New System.Windows.Forms.Label
        Me.input_last_name = New System.Windows.Forms.TextBox
        Me.input_first_name = New System.Windows.Forms.TextBox
        Me.input_phone_no = New System.Windows.Forms.TextBox
        Me.input_email = New System.Windows.Forms.TextBox
        Me.input_gender = New System.Windows.Forms.TextBox
        Me.input_nationality = New System.Windows.Forms.TextBox
        Me.input_birth_date = New System.Windows.Forms.TextBox
        Me.input_national_id = New System.Windows.Forms.TextBox
        Me.panel_personal = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.emp_job = New System.Windows.Forms.Label
        Me.lbl_job = New System.Windows.Forms.Label
        Me.emp_department = New System.Windows.Forms.Label
        Me.emp_salary = New System.Windows.Forms.Label
        Me.emp_hire_date = New System.Windows.Forms.Label
        Me.lbl_department = New System.Windows.Forms.Label
        Me.lbl_salary = New System.Windows.Forms.Label
        Me.lbl_hire_date = New System.Windows.Forms.Label
        Me.input_emergency_contact = New System.Windows.Forms.TextBox
        Me.input_emergency_contact_person = New System.Windows.Forms.TextBox
        Me.input_address = New System.Windows.Forms.TextBox
        Me.btn_edit_profile = New System.Windows.Forms.Button
        CType(Me.img_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_personal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_personal_title
        '
        Me.lbl_personal_title.AutoSize = True
        Me.lbl_personal_title.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_personal_title.Location = New System.Drawing.Point(20, 248)
        Me.lbl_personal_title.Name = "lbl_personal_title"
        Me.lbl_personal_title.Size = New System.Drawing.Size(191, 23)
        Me.lbl_personal_title.TabIndex = 0
        Me.lbl_personal_title.Text = "Personal Information"
        '
        'lbl_first_name
        '
        Me.lbl_first_name.AutoSize = True
        Me.lbl_first_name.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_first_name.Location = New System.Drawing.Point(187, 59)
        Me.lbl_first_name.Name = "lbl_first_name"
        Me.lbl_first_name.Size = New System.Drawing.Size(64, 15)
        Me.lbl_first_name.TabIndex = 1
        Me.lbl_first_name.Text = "First Name"
        '
        'lbl_last_name
        '
        Me.lbl_last_name.AutoSize = True
        Me.lbl_last_name.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_last_name.Location = New System.Drawing.Point(493, 60)
        Me.lbl_last_name.Name = "lbl_last_name"
        Me.lbl_last_name.Size = New System.Drawing.Size(62, 15)
        Me.lbl_last_name.TabIndex = 3
        Me.lbl_last_name.Text = "Last Name"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(187, 124)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(39, 15)
        Me.lbl_email.TabIndex = 5
        Me.lbl_email.Text = "Email "
        '
        'lbl_phone_no
        '
        Me.lbl_phone_no.AutoSize = True
        Me.lbl_phone_no.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone_no.Location = New System.Drawing.Point(495, 124)
        Me.lbl_phone_no.Name = "lbl_phone_no"
        Me.lbl_phone_no.Size = New System.Drawing.Size(60, 15)
        Me.lbl_phone_no.TabIndex = 7
        Me.lbl_phone_no.Text = "Phone No"
        '
        'emp_id
        '
        Me.emp_id.AutoSize = True
        Me.emp_id.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_id.Location = New System.Drawing.Point(109, 27)
        Me.emp_id.Name = "emp_id"
        Me.emp_id.Size = New System.Drawing.Size(14, 15)
        Me.emp_id.TabIndex = 15
        Me.emp_id.Text = "0"
        '
        'lbl_emp_id
        '
        Me.lbl_emp_id.AutoSize = True
        Me.lbl_emp_id.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emp_id.Location = New System.Drawing.Point(28, 27)
        Me.lbl_emp_id.Name = "lbl_emp_id"
        Me.lbl_emp_id.Size = New System.Drawing.Size(75, 15)
        Me.lbl_emp_id.TabIndex = 16
        Me.lbl_emp_id.Text = "Employee Id:"
        '
        'img_profile
        '
        Me.img_profile.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.img_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.img_profile.Image = CType(resources.GetObject("img_profile.Image"), System.Drawing.Image)
        Me.img_profile.InitialImage = CType(resources.GetObject("img_profile.InitialImage"), System.Drawing.Image)
        Me.img_profile.Location = New System.Drawing.Point(23, 59)
        Me.img_profile.Name = "img_profile"
        Me.img_profile.Size = New System.Drawing.Size(144, 158)
        Me.img_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.img_profile.TabIndex = 23
        Me.img_profile.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Contact Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 462)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Job Details"
        '
        'lbl_nationality
        '
        Me.lbl_nationality.AutoSize = True
        Me.lbl_nationality.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nationality.Location = New System.Drawing.Point(198, 284)
        Me.lbl_nationality.Name = "lbl_nationality"
        Me.lbl_nationality.Size = New System.Drawing.Size(65, 15)
        Me.lbl_nationality.TabIndex = 26
        Me.lbl_nationality.Text = "Nationality"
        '
        'lbl_dob
        '
        Me.lbl_dob.AutoSize = True
        Me.lbl_dob.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dob.Location = New System.Drawing.Point(349, 284)
        Me.lbl_dob.Name = "lbl_dob"
        Me.lbl_dob.Size = New System.Drawing.Size(75, 15)
        Me.lbl_dob.TabIndex = 27
        Me.lbl_dob.Text = "Date of Birth"
        '
        'lbl_national_id
        '
        Me.lbl_national_id.AutoSize = True
        Me.lbl_national_id.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_national_id.Location = New System.Drawing.Point(582, 284)
        Me.lbl_national_id.Name = "lbl_national_id"
        Me.lbl_national_id.Size = New System.Drawing.Size(88, 15)
        Me.lbl_national_id.TabIndex = 28
        Me.lbl_national_id.Text = "NRIC/ Passport"
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.Location = New System.Drawing.Point(21, 284)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(46, 15)
        Me.lbl_gender.TabIndex = 29
        Me.lbl_gender.Text = "Gender"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.Location = New System.Drawing.Point(21, 385)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(49, 15)
        Me.lbl_address.TabIndex = 34
        Me.lbl_address.Text = "Address"
        '
        'lbl_e_contact_person
        '
        Me.lbl_e_contact_person.AutoSize = True
        Me.lbl_e_contact_person.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_e_contact_person.Location = New System.Drawing.Point(349, 385)
        Me.lbl_e_contact_person.Name = "lbl_e_contact_person"
        Me.lbl_e_contact_person.Size = New System.Drawing.Size(155, 15)
        Me.lbl_e_contact_person.TabIndex = 35
        Me.lbl_e_contact_person.Text = "Emergency Contact (Person)"
        '
        'lbl_emergency_contact
        '
        Me.lbl_emergency_contact.AutoSize = True
        Me.lbl_emergency_contact.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emergency_contact.Location = New System.Drawing.Point(582, 385)
        Me.lbl_emergency_contact.Name = "lbl_emergency_contact"
        Me.lbl_emergency_contact.Size = New System.Drawing.Size(110, 15)
        Me.lbl_emergency_contact.TabIndex = 36
        Me.lbl_emergency_contact.Text = "Emergency Contact"
        '
        'input_last_name
        '
        Me.input_last_name.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_last_name.Location = New System.Drawing.Point(496, 79)
        Me.input_last_name.Name = "input_last_name"
        Me.input_last_name.Size = New System.Drawing.Size(196, 23)
        Me.input_last_name.TabIndex = 40
        '
        'input_first_name
        '
        Me.input_first_name.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_first_name.Location = New System.Drawing.Point(190, 79)
        Me.input_first_name.Name = "input_first_name"
        Me.input_first_name.Size = New System.Drawing.Size(196, 23)
        Me.input_first_name.TabIndex = 41
        '
        'input_phone_no
        '
        Me.input_phone_no.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_phone_no.Location = New System.Drawing.Point(496, 142)
        Me.input_phone_no.Name = "input_phone_no"
        Me.input_phone_no.Size = New System.Drawing.Size(196, 23)
        Me.input_phone_no.TabIndex = 42
        '
        'input_email
        '
        Me.input_email.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_email.Location = New System.Drawing.Point(190, 142)
        Me.input_email.Name = "input_email"
        Me.input_email.Size = New System.Drawing.Size(196, 23)
        Me.input_email.TabIndex = 43
        '
        'input_gender
        '
        Me.input_gender.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_gender.Location = New System.Drawing.Point(23, 302)
        Me.input_gender.Name = "input_gender"
        Me.input_gender.Size = New System.Drawing.Size(144, 23)
        Me.input_gender.TabIndex = 44
        '
        'input_nationality
        '
        Me.input_nationality.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_nationality.Location = New System.Drawing.Point(201, 302)
        Me.input_nationality.Name = "input_nationality"
        Me.input_nationality.Size = New System.Drawing.Size(129, 23)
        Me.input_nationality.TabIndex = 45
        '
        'input_birth_date
        '
        Me.input_birth_date.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_birth_date.Location = New System.Drawing.Point(352, 301)
        Me.input_birth_date.Name = "input_birth_date"
        Me.input_birth_date.Size = New System.Drawing.Size(203, 23)
        Me.input_birth_date.TabIndex = 46
        '
        'input_national_id
        '
        Me.input_national_id.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_national_id.Location = New System.Drawing.Point(585, 301)
        Me.input_national_id.Name = "input_national_id"
        Me.input_national_id.Size = New System.Drawing.Size(129, 23)
        Me.input_national_id.TabIndex = 47
        '
        'panel_personal
        '
        Me.panel_personal.Controls.Add(Me.Button1)
        Me.panel_personal.Controls.Add(Me.emp_job)
        Me.panel_personal.Controls.Add(Me.lbl_job)
        Me.panel_personal.Controls.Add(Me.emp_department)
        Me.panel_personal.Controls.Add(Me.emp_salary)
        Me.panel_personal.Controls.Add(Me.emp_hire_date)
        Me.panel_personal.Controls.Add(Me.lbl_department)
        Me.panel_personal.Controls.Add(Me.lbl_salary)
        Me.panel_personal.Controls.Add(Me.lbl_hire_date)
        Me.panel_personal.Controls.Add(Me.input_emergency_contact)
        Me.panel_personal.Controls.Add(Me.input_emergency_contact_person)
        Me.panel_personal.Controls.Add(Me.input_address)
        Me.panel_personal.Controls.Add(Me.input_national_id)
        Me.panel_personal.Controls.Add(Me.input_birth_date)
        Me.panel_personal.Controls.Add(Me.input_nationality)
        Me.panel_personal.Controls.Add(Me.input_gender)
        Me.panel_personal.Controls.Add(Me.input_email)
        Me.panel_personal.Controls.Add(Me.input_phone_no)
        Me.panel_personal.Controls.Add(Me.input_first_name)
        Me.panel_personal.Controls.Add(Me.input_last_name)
        Me.panel_personal.Controls.Add(Me.lbl_emergency_contact)
        Me.panel_personal.Controls.Add(Me.lbl_e_contact_person)
        Me.panel_personal.Controls.Add(Me.lbl_address)
        Me.panel_personal.Controls.Add(Me.lbl_gender)
        Me.panel_personal.Controls.Add(Me.lbl_national_id)
        Me.panel_personal.Controls.Add(Me.lbl_dob)
        Me.panel_personal.Controls.Add(Me.lbl_nationality)
        Me.panel_personal.Controls.Add(Me.Label2)
        Me.panel_personal.Controls.Add(Me.Label1)
        Me.panel_personal.Controls.Add(Me.img_profile)
        Me.panel_personal.Controls.Add(Me.btn_edit_profile)
        Me.panel_personal.Controls.Add(Me.lbl_emp_id)
        Me.panel_personal.Controls.Add(Me.emp_id)
        Me.panel_personal.Controls.Add(Me.lbl_phone_no)
        Me.panel_personal.Controls.Add(Me.lbl_email)
        Me.panel_personal.Controls.Add(Me.lbl_last_name)
        Me.panel_personal.Controls.Add(Me.lbl_first_name)
        Me.panel_personal.Controls.Add(Me.lbl_personal_title)
        Me.panel_personal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_personal.Location = New System.Drawing.Point(0, 0)
        Me.panel_personal.Name = "panel_personal"
        Me.panel_personal.Size = New System.Drawing.Size(1095, 678)
        Me.panel_personal.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(23, 584)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 33)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'emp_job
        '
        Me.emp_job.AutoSize = True
        Me.emp_job.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_job.Location = New System.Drawing.Point(198, 537)
        Me.emp_job.Name = "emp_job"
        Me.emp_job.Size = New System.Drawing.Size(61, 16)
        Me.emp_job.TabIndex = 58
        Me.emp_job.Text = "Random"
        '
        'lbl_job
        '
        Me.lbl_job.AutoSize = True
        Me.lbl_job.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_job.Location = New System.Drawing.Point(198, 510)
        Me.lbl_job.Name = "lbl_job"
        Me.lbl_job.Size = New System.Drawing.Size(26, 15)
        Me.lbl_job.TabIndex = 57
        Me.lbl_job.Text = "Job"
        '
        'emp_department
        '
        Me.emp_department.AutoSize = True
        Me.emp_department.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_department.Location = New System.Drawing.Point(349, 537)
        Me.emp_department.Name = "emp_department"
        Me.emp_department.Size = New System.Drawing.Size(106, 16)
        Me.emp_department.TabIndex = 56
        Me.emp_department.Text = "Administration"
        '
        'emp_salary
        '
        Me.emp_salary.AutoSize = True
        Me.emp_salary.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_salary.Location = New System.Drawing.Point(23, 537)
        Me.emp_salary.Name = "emp_salary"
        Me.emp_salary.Size = New System.Drawing.Size(53, 16)
        Me.emp_salary.TabIndex = 55
        Me.emp_salary.Text = "$3000"
        '
        'emp_hire_date
        '
        Me.emp_hire_date.AutoSize = True
        Me.emp_hire_date.Font = New System.Drawing.Font("Lato Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_hire_date.Location = New System.Drawing.Point(582, 537)
        Me.emp_hire_date.Name = "emp_hire_date"
        Me.emp_hire_date.Size = New System.Drawing.Size(94, 16)
        Me.emp_hire_date.TabIndex = 54
        Me.emp_hire_date.Text = "19/11/2012"
        '
        'lbl_department
        '
        Me.lbl_department.AutoSize = True
        Me.lbl_department.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_department.Location = New System.Drawing.Point(349, 510)
        Me.lbl_department.Name = "lbl_department"
        Me.lbl_department.Size = New System.Drawing.Size(70, 15)
        Me.lbl_department.TabIndex = 53
        Me.lbl_department.Text = "Department"
        '
        'lbl_salary
        '
        Me.lbl_salary.AutoSize = True
        Me.lbl_salary.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_salary.Location = New System.Drawing.Point(23, 510)
        Me.lbl_salary.Name = "lbl_salary"
        Me.lbl_salary.Size = New System.Drawing.Size(39, 15)
        Me.lbl_salary.TabIndex = 52
        Me.lbl_salary.Text = "Salary"
        '
        'lbl_hire_date
        '
        Me.lbl_hire_date.AutoSize = True
        Me.lbl_hire_date.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hire_date.Location = New System.Drawing.Point(582, 510)
        Me.lbl_hire_date.Name = "lbl_hire_date"
        Me.lbl_hire_date.Size = New System.Drawing.Size(57, 15)
        Me.lbl_hire_date.TabIndex = 51
        Me.lbl_hire_date.Text = "Hire Date"
        '
        'input_emergency_contact
        '
        Me.input_emergency_contact.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_emergency_contact.Location = New System.Drawing.Point(585, 403)
        Me.input_emergency_contact.Name = "input_emergency_contact"
        Me.input_emergency_contact.Size = New System.Drawing.Size(129, 23)
        Me.input_emergency_contact.TabIndex = 50
        '
        'input_emergency_contact_person
        '
        Me.input_emergency_contact_person.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_emergency_contact_person.Location = New System.Drawing.Point(352, 403)
        Me.input_emergency_contact_person.Name = "input_emergency_contact_person"
        Me.input_emergency_contact_person.Size = New System.Drawing.Size(203, 23)
        Me.input_emergency_contact_person.TabIndex = 49
        '
        'input_address
        '
        Me.input_address.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_address.Location = New System.Drawing.Point(23, 403)
        Me.input_address.Name = "input_address"
        Me.input_address.Size = New System.Drawing.Size(307, 23)
        Me.input_address.TabIndex = 48
        '
        'btn_edit_profile
        '
        Me.btn_edit_profile.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_edit_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_profile.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.btn_edit_profile.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit_profile.Location = New System.Drawing.Point(554, 584)
        Me.btn_edit_profile.Name = "btn_edit_profile"
        Me.btn_edit_profile.Size = New System.Drawing.Size(218, 33)
        Me.btn_edit_profile.TabIndex = 21
        Me.btn_edit_profile.Text = "Confirm"
        Me.btn_edit_profile.UseVisualStyleBackColor = False
        '
        'EditProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel_personal)
        Me.Name = "EditProfile"
        Me.Size = New System.Drawing.Size(1095, 678)
        CType(Me.img_profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_personal.ResumeLayout(False)
        Me.panel_personal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_personal_title As System.Windows.Forms.Label
    Friend WithEvents lbl_first_name As System.Windows.Forms.Label
    Friend WithEvents lbl_last_name As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_phone_no As System.Windows.Forms.Label
    Friend WithEvents emp_id As System.Windows.Forms.Label
    Friend WithEvents lbl_emp_id As System.Windows.Forms.Label
    Friend WithEvents img_profile As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_nationality As System.Windows.Forms.Label
    Friend WithEvents lbl_dob As System.Windows.Forms.Label
    Friend WithEvents lbl_national_id As System.Windows.Forms.Label
    Friend WithEvents lbl_gender As System.Windows.Forms.Label
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents lbl_e_contact_person As System.Windows.Forms.Label
    Friend WithEvents lbl_emergency_contact As System.Windows.Forms.Label
    Friend WithEvents input_last_name As System.Windows.Forms.TextBox
    Friend WithEvents input_first_name As System.Windows.Forms.TextBox
    Friend WithEvents input_phone_no As System.Windows.Forms.TextBox
    Friend WithEvents input_email As System.Windows.Forms.TextBox
    Friend WithEvents input_gender As System.Windows.Forms.TextBox
    Friend WithEvents input_nationality As System.Windows.Forms.TextBox
    Friend WithEvents input_birth_date As System.Windows.Forms.TextBox
    Friend WithEvents input_national_id As System.Windows.Forms.TextBox
    Friend WithEvents panel_personal As System.Windows.Forms.Panel
    Friend WithEvents input_emergency_contact As System.Windows.Forms.TextBox
    Friend WithEvents input_emergency_contact_person As System.Windows.Forms.TextBox
    Friend WithEvents input_address As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents emp_job As System.Windows.Forms.Label
    Friend WithEvents lbl_job As System.Windows.Forms.Label
    Friend WithEvents emp_department As System.Windows.Forms.Label
    Friend WithEvents emp_salary As System.Windows.Forms.Label
    Friend WithEvents emp_hire_date As System.Windows.Forms.Label
    Friend WithEvents lbl_department As System.Windows.Forms.Label
    Friend WithEvents lbl_salary As System.Windows.Forms.Label
    Friend WithEvents lbl_hire_date As System.Windows.Forms.Label
    Friend WithEvents btn_edit_profile As System.Windows.Forms.Button

End Class
