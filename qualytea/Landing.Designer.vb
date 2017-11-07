<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class landing_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(landing_page))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btn_home = New System.Windows.Forms.Button
        Me.emp_id = New System.Windows.Forms.Label
        Me.lbl_emp_id = New System.Windows.Forms.Label
        Me.btn_payroll = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btn_job_applicants = New System.Windows.Forms.Button
        Me.btn_logout = New System.Windows.Forms.Button
        Me.btn_work_management = New System.Windows.Forms.Button
        Me.btn_time_management = New System.Windows.Forms.Button
        Me.btn_personal = New System.Windows.Forms.Button
        Me.PersonalDetailsComponent2 = New WindowsApplication1.PersonalDetailsComponent
        Me.PersonalDetailsComponent1 = New WindowsApplication1.PersonalDetailsComponent
        Me.JobApplicantsComponent1 = New WindowsApplication1.JobApplicantsComponent
        Me.EditProfile1 = New WindowsApplication1.EditProfile
        Me.ChangePassword1 = New WindowsApplication1.ChangePassword
        Me.Attendance1 = New WindowsApplication1.Attendance
        Me.HomeDashboard1 = New WindowsApplication1.HomeDashboard
        Me.My_Training = New WindowsApplication1.My_Training
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_home)
        Me.SplitContainer1.Panel1.Controls.Add(Me.emp_id)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_emp_id)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_payroll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_job_applicants)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_logout)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_work_management)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_time_management)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_personal)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SplitContainer1.Panel2.Controls.Add(Me.My_Training)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PersonalDetailsComponent2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.HomeDashboard1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Attendance1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChangePassword1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditProfile1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.JobApplicantsComponent1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PersonalDetailsComponent1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1204, 662)
        Me.SplitContainer1.SplitterDistance = 409
        Me.SplitContainer1.TabIndex = 0
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_home.FlatAppearance.BorderSize = 0
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_home.Location = New System.Drawing.Point(0, 261)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(411, 50)
        Me.btn_home.TabIndex = 9
        Me.btn_home.Text = "Home"
        Me.btn_home.UseVisualStyleBackColor = False

        '
        'emp_id
        '
        Me.emp_id.AutoSize = True
        Me.emp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.emp_id.Location = New System.Drawing.Point(123, 7)
        Me.emp_id.Name = "emp_id"
        Me.emp_id.Size = New System.Drawing.Size(14, 13)
        Me.emp_id.TabIndex = 8
        Me.emp_id.Text = "X"
        '
        'lbl_emp_id
        '
        Me.lbl_emp_id.AutoSize = True
        Me.lbl_emp_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl_emp_id.Location = New System.Drawing.Point(12, 7)
        Me.lbl_emp_id.Name = "lbl_emp_id"
        Me.lbl_emp_id.Size = New System.Drawing.Size(73, 13)
        Me.lbl_emp_id.TabIndex = 7
        Me.lbl_emp_id.Text = "Employee ID :"
        '
        'btn_payroll
        '
        Me.btn_payroll.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_payroll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_payroll.FlatAppearance.BorderSize = 0
        Me.btn_payroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_payroll.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_payroll.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_payroll.Location = New System.Drawing.Point(0, 461)
        Me.btn_payroll.Name = "btn_payroll"
        Me.btn_payroll.Size = New System.Drawing.Size(409, 50)
        Me.btn_payroll.TabIndex = 3
        Me.btn_payroll.Text = "Payroll Management"
        Me.btn_payroll.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(406, 240)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btn_job_applicants
        '
        Me.btn_job_applicants.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_job_applicants.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_job_applicants.FlatAppearance.BorderSize = 0
        Me.btn_job_applicants.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_job_applicants.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_job_applicants.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_job_applicants.Location = New System.Drawing.Point(0, 554)
        Me.btn_job_applicants.Name = "btn_job_applicants"
        Me.btn_job_applicants.Size = New System.Drawing.Size(411, 54)
        Me.btn_job_applicants.TabIndex = 5
        Me.btn_job_applicants.Text = "Job Applicants"
        Me.btn_job_applicants.UseVisualStyleBackColor = False
        '
        'btn_logout
        '
        Me.btn_logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_logout.Location = New System.Drawing.Point(0, 608)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(409, 54)
        Me.btn_logout.TabIndex = 4
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_work_management
        '
        Me.btn_work_management.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_work_management.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_work_management.FlatAppearance.BorderSize = 0
        Me.btn_work_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_work_management.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_work_management.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_work_management.Location = New System.Drawing.Point(0, 391)
        Me.btn_work_management.Name = "btn_work_management"
        Me.btn_work_management.Size = New System.Drawing.Size(416, 54)
        Me.btn_work_management.TabIndex = 2
        Me.btn_work_management.Text = "Work Management"
        Me.btn_work_management.UseVisualStyleBackColor = False
        '
        'btn_time_management
        '
        Me.btn_time_management.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_time_management.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_time_management.FlatAppearance.BorderSize = 0
        Me.btn_time_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_time_management.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_time_management.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_time_management.Location = New System.Drawing.Point(0, 445)
        Me.btn_time_management.Name = "btn_time_management"
        Me.btn_time_management.Size = New System.Drawing.Size(409, 54)
        Me.btn_time_management.TabIndex = 1
        Me.btn_time_management.Text = "Leave Management"
        Me.btn_time_management.UseVisualStyleBackColor = False
        '
        'btn_personal
        '
        Me.btn_personal.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_personal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_personal.FlatAppearance.BorderSize = 0
        Me.btn_personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_personal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_personal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_personal.Location = New System.Drawing.Point(0, 337)
        Me.btn_personal.Name = "btn_personal"
        Me.btn_personal.Size = New System.Drawing.Size(411, 54)
        Me.btn_personal.TabIndex = 0
        Me.btn_personal.Text = "Personal Information"
        Me.btn_personal.UseVisualStyleBackColor = False
        '
        'HomeDashboard1
        '
        Me.HomeDashboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeDashboard1.Location = New System.Drawing.Point(0, 0)
        Me.HomeDashboard1.Name = "HomeDashboard1"
        Me.HomeDashboard1.Size = New System.Drawing.Size(791, 611)
        Me.HomeDashboard1.TabIndex = 5
        'btn_finance
        '
        'Me.btn_finance.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        'Me.btn_finance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        'Me.btn_finance.FlatAppearance.BorderSize = 0
        'Me.btn_finance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        'Me.btn_finance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.btn_finance.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        'Me.btn_finance.Location = New System.Drawing.Point(-248, 78)
        'Me.btn_finance.Name = "btn_finance"
        'Me.btn_finance.Size = New System.Drawing.Size(409, 54)
        'Me.btn_finance.TabIndex = 3
        'Me.btn_finance.Text = "Finance"
        'Me.btn_finance.UseVisualStyleBackColor = False
        '
        'PersonalDetailsComponent2
        '
        Me.PersonalDetailsComponent2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PersonalDetailsComponent2.Location = New System.Drawing.Point(136, 425)
        Me.PersonalDetailsComponent2.Name = "PersonalDetailsComponent2"
        Me.PersonalDetailsComponent2.Size = New System.Drawing.Size(8, 20)
        Me.PersonalDetailsComponent2.TabIndex = 7
        '
        'PersonalDetailsComponent1
        '
        Me.PersonalDetailsComponent1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PersonalDetailsComponent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonalDetailsComponent1.Location = New System.Drawing.Point(0, 0)
        Me.PersonalDetailsComponent1.Name = "PersonalDetailsComponent1"
        Me.PersonalDetailsComponent1.Size = New System.Drawing.Size(791, 662)
        Me.PersonalDetailsComponent1.TabIndex = 0
        '
        'JobApplicantsComponent1
        '
        Me.JobApplicantsComponent1.AutoSize = True
        Me.JobApplicantsComponent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JobApplicantsComponent1.Location = New System.Drawing.Point(0, 0)
        Me.JobApplicantsComponent1.Name = "JobApplicantsComponent1"
        Me.JobApplicantsComponent1.Size = New System.Drawing.Size(791, 662)
        Me.JobApplicantsComponent1.TabIndex = 1
        '
        'EditProfile1
        '
        Me.EditProfile1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditProfile1.Location = New System.Drawing.Point(0, 0)
        Me.EditProfile1.Name = "EditProfile1"
        Me.EditProfile1.Size = New System.Drawing.Size(791, 662)
        Me.EditProfile1.TabIndex = 2
        '
        'ChangePassword1
        '
        Me.ChangePassword1.Location = New System.Drawing.Point(0, 0)
        Me.ChangePassword1.Name = "ChangePassword1"
        Me.ChangePassword1.Size = New System.Drawing.Size(940, 723)
        Me.ChangePassword1.TabIndex = 3
        '
        'Attendance1
        '
        Me.Attendance1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Attendance1.Location = New System.Drawing.Point(0, 0)
        Me.Attendance1.Name = "Attendance1"
        Me.Attendance1.Size = New System.Drawing.Size(791, 662)
        Me.Attendance1.TabIndex = 4
        Me.Attendance1.Visible = False
        '
        'HomeDashboard1
        '
        Me.HomeDashboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeDashboard1.Location = New System.Drawing.Point(0, 0)
        Me.HomeDashboard1.Name = "HomeDashboard1"
        Me.HomeDashboard1.Size = New System.Drawing.Size(791, 662)
        Me.HomeDashboard1.TabIndex = 5
        '
        'My_Training
        '
        Me.My_Training.Dock = System.Windows.Forms.DockStyle.Fill
        Me.My_Training.Location = New System.Drawing.Point(0, 0)
        Me.My_Training.Name = "My_Training"
        Me.My_Training.Size = New System.Drawing.Size(791, 662)
        Me.My_Training.TabIndex = 6
        '
        'landing_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 662)
        Me.Controls.Add(Me.SplitContainer1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "landing_page"
        Me.Text = "Landing"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_time_management As System.Windows.Forms.Button
    Friend WithEvents btn_work_management As System.Windows.Forms.Button
    Friend WithEvents btn_payroll As System.Windows.Forms.Button
    Friend WithEvents btn_personal As System.Windows.Forms.Button
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_job_applicants As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_emp_id As System.Windows.Forms.Label
    Friend WithEvents emp_id As System.Windows.Forms.Label
    Friend WithEvents PersonalDetailsComponent2 As WindowsApplication1.PersonalDetailsComponent
    Friend WithEvents My_Training As WindowsApplication1.My_Training
    Friend WithEvents HomeDashboard1 As WindowsApplication1.HomeDashboard
    Friend WithEvents btn_home As System.Windows.Forms.Button
    Friend WithEvents Attendance1 As WindowsApplication1.Attendance
    Friend WithEvents ChangePassword1 As WindowsApplication1.ChangePassword
    Friend WithEvents EditProfile1 As WindowsApplication1.EditProfile
    Friend WithEvents JobApplicantsComponent1 As WindowsApplication1.JobApplicantsComponent
    Friend WithEvents PersonalDetailsComponent1 As WindowsApplication1.PersonalDetailsComponent
End Class
