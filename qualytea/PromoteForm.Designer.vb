<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromoteForm
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
        Me.cmb_job = New System.Windows.Forms.ComboBox
        Me.input_salary = New System.Windows.Forms.TextBox
        Me.cmb_department = New System.Windows.Forms.ComboBox
        Me.lbl_department = New System.Windows.Forms.Label
        Me.lbl_job = New System.Windows.Forms.Label
        Me.lbl_salary = New System.Windows.Forms.Label
        Me.btn_confirm = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmb_job
        '
        Me.cmb_job.FormattingEnabled = True
        Me.cmb_job.Location = New System.Drawing.Point(131, 92)
        Me.cmb_job.Name = "cmb_job"
        Me.cmb_job.Size = New System.Drawing.Size(218, 20)
        Me.cmb_job.TabIndex = 0
        '
        'input_salary
        '
        Me.input_salary.Location = New System.Drawing.Point(131, 138)
        Me.input_salary.Name = "input_salary"
        Me.input_salary.Size = New System.Drawing.Size(218, 21)
        Me.input_salary.TabIndex = 1
        '
        'cmb_department
        '
        Me.cmb_department.FormattingEnabled = True
        Me.cmb_department.Location = New System.Drawing.Point(131, 45)
        Me.cmb_department.Name = "cmb_department"
        Me.cmb_department.Size = New System.Drawing.Size(218, 20)
        Me.cmb_department.TabIndex = 2
        '
        'lbl_department
        '
        Me.lbl_department.AutoSize = True
        Me.lbl_department.Location = New System.Drawing.Point(25, 48)
        Me.lbl_department.Name = "lbl_department"
        Me.lbl_department.Size = New System.Drawing.Size(65, 12)
        Me.lbl_department.TabIndex = 3
        Me.lbl_department.Text = "Department"
        '
        'lbl_job
        '
        Me.lbl_job.AutoSize = True
        Me.lbl_job.Location = New System.Drawing.Point(25, 95)
        Me.lbl_job.Name = "lbl_job"
        Me.lbl_job.Size = New System.Drawing.Size(23, 12)
        Me.lbl_job.TabIndex = 4
        Me.lbl_job.Text = "Job"
        '
        'lbl_salary
        '
        Me.lbl_salary.AutoSize = True
        Me.lbl_salary.Location = New System.Drawing.Point(25, 141)
        Me.lbl_salary.Name = "lbl_salary"
        Me.lbl_salary.Size = New System.Drawing.Size(41, 12)
        Me.lbl_salary.TabIndex = 5
        Me.lbl_salary.Text = "Salary"
        '
        'btn_confirm
        '
        Me.btn_confirm.Location = New System.Drawing.Point(27, 196)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(322, 23)
        Me.btn_confirm.TabIndex = 6
        Me.btn_confirm.Text = "Confirm"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'PromoteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 247)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.lbl_salary)
        Me.Controls.Add(Me.lbl_job)
        Me.Controls.Add(Me.lbl_department)
        Me.Controls.Add(Me.cmb_department)
        Me.Controls.Add(Me.input_salary)
        Me.Controls.Add(Me.cmb_job)
        Me.Name = "PromoteForm"
        Me.Text = "PromoteForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_job As System.Windows.Forms.ComboBox
    Friend WithEvents input_salary As System.Windows.Forms.TextBox
    Friend WithEvents cmb_department As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_department As System.Windows.Forms.Label
    Friend WithEvents lbl_job As System.Windows.Forms.Label
    Friend WithEvents lbl_salary As System.Windows.Forms.Label
    Friend WithEvents btn_confirm As System.Windows.Forms.Button
End Class
