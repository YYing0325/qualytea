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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.btn_performance_management = New System.Windows.Forms.Button
        Me.btn_my_leave = New System.Windows.Forms.Button
        Me.btn_my_training = New System.Windows.Forms.Button
        Me.btn_home = New System.Windows.Forms.Button
        Me.emp_id = New System.Windows.Forms.Label
        Me.lbl_emp_id = New System.Windows.Forms.Label
        Me.btn_payroll_management = New System.Windows.Forms.Button
        Me.btn_job_applicants = New System.Windows.Forms.Button
        Me.btn_logout = New System.Windows.Forms.Button
        Me.btn_my_performance = New System.Windows.Forms.Button
        Me.btn_training_management = New System.Windows.Forms.Button
        Me.btn_leave_management = New System.Windows.Forms.Button
        Me.btn_personal = New System.Windows.Forms.Button
        Me.PerformanceManagement1 = New WindowsApplication1.PerformanceManagement
        Me.LeaveManagement1 = New WindowsApplication1.LeaveManagement
        Me.TrainingManagement1 = New WindowsApplication1.TrainingManagement
        Me.MyTraining1 = New WindowsApplication1.MyTraining
        Me.MyPerformance1 = New WindowsApplication1.MyPerformance
        Me.MyLeave1 = New WindowsApplication1.MyLeave
        Me.HomeDashboard1 = New WindowsApplication1.HomeDashboard
        Me.Attendance1 = New WindowsApplication1.Attendance
        Me.ChangePassword1 = New WindowsApplication1.ChangePassword
        Me.EditProfile1 = New WindowsApplication1.EditProfile
        Me.JobApplicantsComponent1 = New WindowsApplication1.JobApplicantsComponent
        Me.PersonalDetailsComponent1 = New WindowsApplication1.PersonalDetailsComponent
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_performance_management)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_my_leave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_my_training)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_home)
        Me.SplitContainer1.Panel1.Controls.Add(Me.emp_id)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_emp_id)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_payroll_management)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_job_applicants)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_logout)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_my_performance)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_training_management)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_leave_management)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_personal)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SplitContainer1.Panel2.Controls.Add(Me.PerformanceManagement1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LeaveManagement1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TrainingManagement1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MyTraining1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MyPerformance1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MyLeave1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.HomeDashboard1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Attendance1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ChangePassword1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditProfile1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.JobApplicantsComponent1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PersonalDetailsComponent1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1204, 662)
        Me.SplitContainer1.SplitterDistance = 409
        Me.SplitContainer1.TabIndex = 0
        '
        'btn_performance_management
        '
        Me.btn_performance_management.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_performance_management.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_performance_management.FlatAppearance.BorderSize = 0
        Me.btn_performance_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_performance_management.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_performance_management.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_performance_management.Location = New System.Drawing.Point(7, 82)
        Me.btn_performance_management.Name = "btn_performance_management"
        Me.btn_performance_management.Size = New System.Drawing.Size(411, 54)
        Me.btn_performance_management.TabIndex = 13
        Me.btn_performance_management.Text = "Performance Management"
        Me.btn_performance_management.UseVisualStyleBackColor = False
        '
        'btn_my_leave
        '
        Me.btn_my_leave.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_my_leave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_my_leave.FlatAppearance.BorderSize = 0
        Me.btn_my_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_my_leave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_my_leave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_my_leave.Location = New System.Drawing.Point(15, 23)
        Me.btn_my_leave.Name = "btn_my_leave"
        Me.btn_my_leave.Size = New System.Drawing.Size(411, 54)
        Me.btn_my_leave.TabIndex = 12
        Me.btn_my_leave.Text = "My Leave And Payroll "
        Me.btn_my_leave.UseVisualStyleBackColor = False
        '
        'btn_my_training
        '
        Me.btn_my_training.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_my_training.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_my_training.FlatAppearance.BorderSize = 0
        Me.btn_my_training.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_my_training.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_my_training.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_my_training.Location = New System.Drawing.Point(3, 142)
        Me.btn_my_training.Name = "btn_my_training"
        Me.btn_my_training.Size = New System.Drawing.Size(411, 54)
        Me.btn_my_training.TabIndex = 11
        Me.btn_my_training.Text = "My Training"
        Me.btn_my_training.UseVisualStyleBackColor = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_home.FlatAppearance.BorderSize = 0
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_home.Location = New System.Drawing.Point(8, 231)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(411, 54)
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
        'btn_payroll_management
        '
        Me.btn_payroll_management.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_payroll_management.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_payroll_management.FlatAppearance.BorderSize = 0
        Me.btn_payroll_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_payroll_management.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_payroll_management.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_payroll_management.Location = New System.Drawing.Point(2, 442)
        Me.btn_payroll_management.Name = "btn_payroll_management"
        Me.btn_payroll_management.Size = New System.Drawing.Size(409, 54)
        Me.btn_payroll_management.TabIndex = 3
        Me.btn_payroll_management.Text = "Leave And Payroll Management"
        Me.btn_payroll_management.UseVisualStyleBackColor = False
        '
        'btn_job_applicants
        '
        Me.btn_job_applicants.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_job_applicants.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_job_applicants.FlatAppearance.BorderSize = 0
        Me.btn_job_applicants.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_job_applicants.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_job_applicants.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_job_applicants.Location = New System.Drawing.Point(-2, 559)
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
        'btn_my_performance
        '
        Me.btn_my_performance.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_my_performance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_my_performance.FlatAppearance.BorderSize = 0
        Me.btn_my_performance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_my_performance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_my_performance.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_my_performance.Location = New System.Drawing.Point(0, 353)
        Me.btn_my_performance.Name = "btn_my_performance"
        Me.btn_my_performance.Size = New System.Drawing.Size(416, 54)
        Me.btn_my_performance.TabIndex = 10
        Me.btn_my_performance.Text = "My Performance"
        Me.btn_my_performance.UseVisualStyleBackColor = False
        '
        'btn_training_management
        '
        Me.btn_training_management.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_training_management.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_training_management.FlatAppearance.BorderSize = 0
        Me.btn_training_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_training_management.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_training_management.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_training_management.Location = New System.Drawing.Point(2, 401)
        Me.btn_training_management.Name = "btn_training_management"
        Me.btn_training_management.Size = New System.Drawing.Size(416, 54)
        Me.btn_training_management.TabIndex = 2
        Me.btn_training_management.Text = "Training Management"
        Me.btn_training_management.UseVisualStyleBackColor = False
        '
        'btn_leave_management
        '
        Me.btn_leave_management.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_leave_management.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_leave_management.FlatAppearance.BorderSize = 0
        Me.btn_leave_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_leave_management.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_leave_management.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_leave_management.Location = New System.Drawing.Point(2, 498)
        Me.btn_leave_management.Name = "btn_leave_management"
        Me.btn_leave_management.Size = New System.Drawing.Size(409, 54)
        Me.btn_leave_management.TabIndex = 1
        Me.btn_leave_management.Text = "Leave And Payroll Management"
        Me.btn_leave_management.UseVisualStyleBackColor = False
        '
        'btn_personal
        '
        Me.btn_personal.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btn_personal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_personal.FlatAppearance.BorderSize = 0
        Me.btn_personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_personal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_personal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_personal.Location = New System.Drawing.Point(3, 302)
        Me.btn_personal.Name = "btn_personal"
        Me.btn_personal.Size = New System.Drawing.Size(411, 54)
        Me.btn_personal.TabIndex = 0
        Me.btn_personal.Text = "Personal Information"
        Me.btn_personal.UseVisualStyleBackColor = False
        '
        'PerformanceManagement1
        '
        Me.PerformanceManagement1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PerformanceManagement1.Location = New System.Drawing.Point(0, 0)
        Me.PerformanceManagement1.Name = "PerformanceManagement1"
        Me.PerformanceManagement1.Size = New System.Drawing.Size(791, 662)
        Me.PerformanceManagement1.TabIndex = 14
        '
        'LeaveManagement1
        '
        Me.LeaveManagement1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeaveManagement1.Location = New System.Drawing.Point(0, 0)
        Me.LeaveManagement1.Name = "LeaveManagement1"
        Me.LeaveManagement1.Size = New System.Drawing.Size(791, 662)
        Me.LeaveManagement1.TabIndex = 13
        '
        'TrainingManagement1
        '
        Me.TrainingManagement1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrainingManagement1.Location = New System.Drawing.Point(0, 0)
        Me.TrainingManagement1.Name = "TrainingManagement1"
        Me.TrainingManagement1.Size = New System.Drawing.Size(791, 662)
        Me.TrainingManagement1.TabIndex = 12
        '
        'MyTraining1
        '
        Me.MyTraining1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyTraining1.Location = New System.Drawing.Point(0, 0)
        Me.MyTraining1.Name = "MyTraining1"
        Me.MyTraining1.Size = New System.Drawing.Size(791, 662)
        Me.MyTraining1.TabIndex = 11
        '
        'MyPerformance1
        '
        Me.MyPerformance1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyPerformance1.Location = New System.Drawing.Point(0, 0)
        Me.MyPerformance1.Name = "MyPerformance1"
        Me.MyPerformance1.Size = New System.Drawing.Size(791, 662)
        Me.MyPerformance1.TabIndex = 10
        '
        'MyLeave1
        '
        Me.MyLeave1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyLeave1.Location = New System.Drawing.Point(0, 0)
        Me.MyLeave1.Name = "MyLeave1"
        Me.MyLeave1.Size = New System.Drawing.Size(791, 662)
        Me.MyLeave1.TabIndex = 9
        '
        'HomeDashboard1
        '
        Me.HomeDashboard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeDashboard1.Location = New System.Drawing.Point(0, 0)
        Me.HomeDashboard1.Name = "HomeDashboard1"
        Me.HomeDashboard1.Size = New System.Drawing.Size(791, 662)
        Me.HomeDashboard1.TabIndex = 5
        '
        'Attendance1
        '
        Me.Attendance1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Attendance1.Location = New System.Drawing.Point(0, 0)
        Me.Attendance1.Name = "Attendance1"
        Me.Attendance1.Size = New System.Drawing.Size(791, 662)
        Me.Attendance1.TabIndex = 8
        '
        'ChangePassword1
        '
        Me.ChangePassword1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangePassword1.Location = New System.Drawing.Point(0, 0)
        Me.ChangePassword1.Name = "ChangePassword1"
        Me.ChangePassword1.Size = New System.Drawing.Size(791, 662)
        Me.ChangePassword1.TabIndex = 3
        '
        'EditProfile1
        '
        Me.EditProfile1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditProfile1.Location = New System.Drawing.Point(0, 0)
        Me.EditProfile1.Name = "EditProfile1"
        Me.EditProfile1.Size = New System.Drawing.Size(791, 662)
        Me.EditProfile1.TabIndex = 2
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
        'PersonalDetailsComponent1
        '
        Me.PersonalDetailsComponent1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PersonalDetailsComponent1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PersonalDetailsComponent1.Location = New System.Drawing.Point(0, 0)
        Me.PersonalDetailsComponent1.Name = "PersonalDetailsComponent1"
        Me.PersonalDetailsComponent1.Size = New System.Drawing.Size(791, 662)
        Me.PersonalDetailsComponent1.TabIndex = 0
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_leave_management As System.Windows.Forms.Button
    Friend WithEvents btn_training_management As System.Windows.Forms.Button
    Friend WithEvents btn_payroll_management As System.Windows.Forms.Button
    Friend WithEvents btn_personal As System.Windows.Forms.Button
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_job_applicants As System.Windows.Forms.Button
    Friend WithEvents lbl_emp_id As System.Windows.Forms.Label
    Friend WithEvents emp_id As System.Windows.Forms.Label
    Friend WithEvents HomeDashboard1 As WindowsApplication1.HomeDashboard
    Friend WithEvents btn_home As System.Windows.Forms.Button
    Friend WithEvents Attendance1 As WindowsApplication1.Attendance
    Friend WithEvents ChangePassword1 As WindowsApplication1.ChangePassword
    Friend WithEvents EditProfile1 As WindowsApplication1.EditProfile
    Friend WithEvents JobApplicantsComponent1 As WindowsApplication1.JobApplicantsComponent
    Friend WithEvents PersonalDetailsComponent1 As WindowsApplication1.PersonalDetailsComponent
    Friend WithEvents btn_my_performance As System.Windows.Forms.Button
    Friend WithEvents btn_performance_management As System.Windows.Forms.Button
    Friend WithEvents btn_my_leave As System.Windows.Forms.Button
    Friend WithEvents btn_my_training As System.Windows.Forms.Button
    Friend WithEvents PerformanceManagement1 As WindowsApplication1.PerformanceManagement
    Friend WithEvents LeaveManagement1 As WindowsApplication1.LeaveManagement
    Friend WithEvents TrainingManagement1 As WindowsApplication1.TrainingManagement
    Friend WithEvents MyTraining1 As WindowsApplication1.MyTraining
    Friend WithEvents MyPerformance1 As WindowsApplication1.MyPerformance
    Friend WithEvents MyLeave1 As WindowsApplication1.MyLeave
End Class
