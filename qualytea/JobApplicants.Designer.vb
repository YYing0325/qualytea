<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobApplicantsComponent
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
        Me.panel_applicants = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.data_grid_applicants = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.data_grid_interview = New System.Windows.Forms.DataGridView
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.data_grid_rejected_applicant = New System.Windows.Forms.DataGridView
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.data_grid_accepted_applicant = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.data_grid_current_employee = New System.Windows.Forms.DataGridView
        Me.panel_applicants.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.data_grid_applicants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.data_grid_interview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.data_grid_rejected_applicant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.data_grid_accepted_applicant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.data_grid_current_employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_applicants
        '
        Me.panel_applicants.AutoSize = True
        Me.panel_applicants.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel_applicants.Controls.Add(Me.TabControl1)
        Me.panel_applicants.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_applicants.Location = New System.Drawing.Point(0, 0)
        Me.panel_applicants.Name = "panel_applicants"
        Me.panel_applicants.Size = New System.Drawing.Size(703, 653)
        Me.panel_applicants.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(703, 653)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.data_grid_applicants)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(695, 627)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New Applicants"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'data_grid_applicants
        '
        Me.data_grid_applicants.AllowUserToAddRows = False
        Me.data_grid_applicants.AllowUserToDeleteRows = False
        Me.data_grid_applicants.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_grid_applicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_applicants.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_grid_applicants.Location = New System.Drawing.Point(3, 3)
        Me.data_grid_applicants.Name = "data_grid_applicants"
        Me.data_grid_applicants.RowTemplate.Height = 23
        Me.data_grid_applicants.Size = New System.Drawing.Size(689, 621)
        Me.data_grid_applicants.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.data_grid_interview)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(695, 627)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Interview List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'data_grid_interview
        '
        Me.data_grid_interview.AllowUserToAddRows = False
        Me.data_grid_interview.AllowUserToDeleteRows = False
        Me.data_grid_interview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_grid_interview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_interview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_grid_interview.Location = New System.Drawing.Point(3, 3)
        Me.data_grid_interview.Name = "data_grid_interview"
        Me.data_grid_interview.RowTemplate.Height = 23
        Me.data_grid_interview.Size = New System.Drawing.Size(689, 621)
        Me.data_grid_interview.TabIndex = 7
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.data_grid_rejected_applicant)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(695, 627)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Rejected Applicant"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'data_grid_rejected_applicant
        '
        Me.data_grid_rejected_applicant.AllowUserToAddRows = False
        Me.data_grid_rejected_applicant.AllowUserToDeleteRows = False
        Me.data_grid_rejected_applicant.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_grid_rejected_applicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_rejected_applicant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_grid_rejected_applicant.Location = New System.Drawing.Point(0, 0)
        Me.data_grid_rejected_applicant.Name = "data_grid_rejected_applicant"
        Me.data_grid_rejected_applicant.RowTemplate.Height = 23
        Me.data_grid_rejected_applicant.Size = New System.Drawing.Size(695, 627)
        Me.data_grid_rejected_applicant.TabIndex = 8
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.data_grid_accepted_applicant)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(695, 627)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Accepted Applicant"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'data_grid_accepted_applicant
        '
        Me.data_grid_accepted_applicant.AllowUserToAddRows = False
        Me.data_grid_accepted_applicant.AllowUserToDeleteRows = False
        Me.data_grid_accepted_applicant.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_grid_accepted_applicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_accepted_applicant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_grid_accepted_applicant.Location = New System.Drawing.Point(3, 3)
        Me.data_grid_accepted_applicant.Name = "data_grid_accepted_applicant"
        Me.data_grid_accepted_applicant.RowTemplate.Height = 23
        Me.data_grid_accepted_applicant.Size = New System.Drawing.Size(689, 621)
        Me.data_grid_accepted_applicant.TabIndex = 8
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.data_grid_current_employee)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(695, 627)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Current Employees "
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'data_grid_current_employee
        '
        Me.data_grid_current_employee.AllowUserToAddRows = False
        Me.data_grid_current_employee.AllowUserToDeleteRows = False
        Me.data_grid_current_employee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_grid_current_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_current_employee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_grid_current_employee.Location = New System.Drawing.Point(0, 0)
        Me.data_grid_current_employee.Name = "data_grid_current_employee"
        Me.data_grid_current_employee.RowTemplate.Height = 23
        Me.data_grid_current_employee.Size = New System.Drawing.Size(695, 627)
        Me.data_grid_current_employee.TabIndex = 8
        '
        'JobApplicantsComponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.panel_applicants)
        Me.Name = "JobApplicantsComponent"
        Me.Size = New System.Drawing.Size(703, 653)
        Me.panel_applicants.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.data_grid_applicants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.data_grid_interview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.data_grid_rejected_applicant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.data_grid_accepted_applicant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.data_grid_current_employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_applicants As System.Windows.Forms.Panel
    Friend WithEvents data_grid_applicants As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents data_grid_interview As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents data_grid_rejected_applicant As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents data_grid_accepted_applicant As System.Windows.Forms.DataGridView
    Friend WithEvents data_grid_current_employee As System.Windows.Forms.DataGridView

End Class
