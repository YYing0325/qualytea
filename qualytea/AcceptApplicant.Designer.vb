<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcceptApplicant
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
        Me.lblIntervieweeFirstName = New System.Windows.Forms.Label
        Me.lblIntervieweeLastName = New System.Windows.Forms.Label
        Me.lblJobOffered = New System.Windows.Forms.Label
        Me.intervieweeFirstName = New System.Windows.Forms.Label
        Me.intervieweeLastName = New System.Windows.Forms.Label
        Me.input_job_offered = New System.Windows.Forms.ComboBox
        Me.btn_accept = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.lblSalary = New System.Windows.Forms.Label
        Me.input_salary = New System.Windows.Forms.TextBox
        Me.calendar_hire_date = New System.Windows.Forms.MonthCalendar
        Me.lblHireDate = New System.Windows.Forms.Label
        Me.input_department = New System.Windows.Forms.ComboBox
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblIntervieweeFirstName
        '
        Me.lblIntervieweeFirstName.AutoSize = True
        Me.lblIntervieweeFirstName.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.lblIntervieweeFirstName.Location = New System.Drawing.Point(23, 40)
        Me.lblIntervieweeFirstName.Name = "lblIntervieweeFirstName"
        Me.lblIntervieweeFirstName.Size = New System.Drawing.Size(64, 15)
        Me.lblIntervieweeFirstName.TabIndex = 0
        Me.lblIntervieweeFirstName.Text = "First Name"
        '
        'lblIntervieweeLastName
        '
        Me.lblIntervieweeLastName.AutoSize = True
        Me.lblIntervieweeLastName.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.lblIntervieweeLastName.Location = New System.Drawing.Point(23, 98)
        Me.lblIntervieweeLastName.Name = "lblIntervieweeLastName"
        Me.lblIntervieweeLastName.Size = New System.Drawing.Size(62, 15)
        Me.lblIntervieweeLastName.TabIndex = 1
        Me.lblIntervieweeLastName.Text = "Last Name"
        '
        'lblJobOffered
        '
        Me.lblJobOffered.AutoSize = True
        Me.lblJobOffered.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.lblJobOffered.Location = New System.Drawing.Point(23, 214)
        Me.lblJobOffered.Name = "lblJobOffered"
        Me.lblJobOffered.Size = New System.Drawing.Size(70, 15)
        Me.lblJobOffered.TabIndex = 2
        Me.lblJobOffered.Text = "Job Offered"
        '
        'intervieweeFirstName
        '
        Me.intervieweeFirstName.AutoSize = True
        Me.intervieweeFirstName.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.intervieweeFirstName.Location = New System.Drawing.Point(127, 40)
        Me.intervieweeFirstName.Name = "intervieweeFirstName"
        Me.intervieweeFirstName.Size = New System.Drawing.Size(64, 15)
        Me.intervieweeFirstName.TabIndex = 3
        Me.intervieweeFirstName.Text = "First Name"
        '
        'intervieweeLastName
        '
        Me.intervieweeLastName.AutoSize = True
        Me.intervieweeLastName.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.intervieweeLastName.Location = New System.Drawing.Point(127, 95)
        Me.intervieweeLastName.Name = "intervieweeLastName"
        Me.intervieweeLastName.Size = New System.Drawing.Size(62, 15)
        Me.intervieweeLastName.TabIndex = 4
        Me.intervieweeLastName.Text = "Last Name"
        '
        'input_job_offered
        '
        Me.input_job_offered.FormattingEnabled = True
        Me.input_job_offered.Location = New System.Drawing.Point(127, 210)
        Me.input_job_offered.Name = "input_job_offered"
        Me.input_job_offered.Size = New System.Drawing.Size(230, 20)
        Me.input_job_offered.TabIndex = 5
        '
        'btn_accept
        '
        Me.btn_accept.Location = New System.Drawing.Point(611, 356)
        Me.btn_accept.Name = "btn_accept"
        Me.btn_accept.Size = New System.Drawing.Size(75, 23)
        Me.btn_accept.TabIndex = 6
        Me.btn_accept.Text = "Accept"
        Me.btn_accept.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(507, 356)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.lblSalary.Location = New System.Drawing.Point(23, 272)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(39, 15)
        Me.lblSalary.TabIndex = 8
        Me.lblSalary.Text = "Salary"
        '
        'input_salary
        '
        Me.input_salary.Location = New System.Drawing.Point(127, 270)
        Me.input_salary.Name = "input_salary"
        Me.input_salary.Size = New System.Drawing.Size(230, 21)
        Me.input_salary.TabIndex = 9
        '
        'calendar_hire_date
        '
        Me.calendar_hire_date.Location = New System.Drawing.Point(459, 63)
        Me.calendar_hire_date.MaxSelectionCount = 1
        Me.calendar_hire_date.Name = "calendar_hire_date"
        Me.calendar_hire_date.TabIndex = 10
        '
        'lblHireDate
        '
        Me.lblHireDate.AutoSize = True
        Me.lblHireDate.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.lblHireDate.Location = New System.Drawing.Point(456, 39)
        Me.lblHireDate.Name = "lblHireDate"
        Me.lblHireDate.Size = New System.Drawing.Size(57, 15)
        Me.lblHireDate.TabIndex = 11
        Me.lblHireDate.Text = "Hire Date"
        '
        'input_department
        '
        Me.input_department.FormattingEnabled = True
        Me.input_department.Location = New System.Drawing.Point(127, 150)
        Me.input_department.Name = "input_department"
        Me.input_department.Size = New System.Drawing.Size(230, 20)
        Me.input_department.TabIndex = 12
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.lblDepartment.Location = New System.Drawing.Point(23, 156)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(70, 15)
        Me.lblDepartment.TabIndex = 13
        Me.lblDepartment.Text = "Department"
        '
        'AcceptApplicant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 403)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.input_department)
        Me.Controls.Add(Me.lblHireDate)
        Me.Controls.Add(Me.calendar_hire_date)
        Me.Controls.Add(Me.input_salary)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_accept)
        Me.Controls.Add(Me.input_job_offered)
        Me.Controls.Add(Me.intervieweeLastName)
        Me.Controls.Add(Me.intervieweeFirstName)
        Me.Controls.Add(Me.lblJobOffered)
        Me.Controls.Add(Me.lblIntervieweeLastName)
        Me.Controls.Add(Me.lblIntervieweeFirstName)
        Me.Name = "AcceptApplicant"
        Me.Text = "AcceptApplicant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIntervieweeFirstName As System.Windows.Forms.Label
    Friend WithEvents lblIntervieweeLastName As System.Windows.Forms.Label
    Friend WithEvents lblJobOffered As System.Windows.Forms.Label
    Friend WithEvents intervieweeFirstName As System.Windows.Forms.Label
    Friend WithEvents intervieweeLastName As System.Windows.Forms.Label
    Friend WithEvents input_job_offered As System.Windows.Forms.ComboBox
    Friend WithEvents btn_accept As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents input_salary As System.Windows.Forms.TextBox
    Friend WithEvents calendar_hire_date As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblHireDate As System.Windows.Forms.Label
    Friend WithEvents input_department As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
End Class
