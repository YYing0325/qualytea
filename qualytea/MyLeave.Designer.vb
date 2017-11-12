<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyLeave
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
        Me.datagrid_leave_history = New System.Windows.Forms.DataGridView
        Me.lbnew_leave = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tab_salary = New System.Windows.Forms.TabPage
        Me.tab_leave = New System.Windows.Forms.TabPage
        Me.lbtotal280 = New System.Windows.Forms.Label
        Me.lbothers280 = New System.Windows.Forms.Label
        Me.lbclaims280 = New System.Windows.Forms.Label
        Me.lbsocso280 = New System.Windows.Forms.Label
        Me.lbepf280 = New System.Windows.Forms.Label
        Me.lballowance280 = New System.Windows.Forms.Label
        Me.lbovertime280 = New System.Windows.Forms.Label
        Me.lbbasic_salary280 = New System.Windows.Forms.Label
        Me.cbmonth = New System.Windows.Forms.ComboBox
        Me.lbtotal = New System.Windows.Forms.Label
        Me.lbothers = New System.Windows.Forms.Label
        Me.lbbasicsalary = New System.Windows.Forms.Label
        Me.lbclaims = New System.Windows.Forms.Label
        Me.lbsocso = New System.Windows.Forms.Label
        Me.lbepf = New System.Windows.Forms.Label
        Me.lballowance = New System.Windows.Forms.Label
        Me.lbovertime = New System.Windows.Forms.Label
        Me.lbmonth = New System.Windows.Forms.Label
        Me.tab_claims = New System.Windows.Forms.TabPage
        Me.datagrid_payroll_mgmt = New System.Windows.Forms.DataGridView
        Me.btn_new_claim = New System.Windows.Forms.Button
        CType(Me.datagrid_leave_history, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tab_salary.SuspendLayout()
        Me.tab_leave.SuspendLayout()
        Me.tab_claims.SuspendLayout()
        CType(Me.datagrid_payroll_mgmt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagrid_leave_history
        '
        Me.datagrid_leave_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_leave_history.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.datagrid_leave_history.Location = New System.Drawing.Point(3, 83)
        Me.datagrid_leave_history.Name = "datagrid_leave_history"
        Me.datagrid_leave_history.Size = New System.Drawing.Size(714, 300)
        Me.datagrid_leave_history.TabIndex = 5
        '
        'lbnew_leave
        '
        Me.lbnew_leave.Location = New System.Drawing.Point(0, 38)
        Me.lbnew_leave.Name = "lbnew_leave"
        Me.lbnew_leave.Size = New System.Drawing.Size(112, 23)
        Me.lbnew_leave.TabIndex = 4
        Me.lbnew_leave.Text = "+ New Leave"
        Me.lbnew_leave.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_salary)
        Me.TabControl1.Controls.Add(Me.tab_leave)
        Me.TabControl1.Controls.Add(Me.tab_claims)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(728, 436)
        Me.TabControl1.TabIndex = 6
        '
        'tab_salary
        '
        Me.tab_salary.Controls.Add(Me.lbtotal280)
        Me.tab_salary.Controls.Add(Me.lbothers280)
        Me.tab_salary.Controls.Add(Me.lbclaims280)
        Me.tab_salary.Controls.Add(Me.lbsocso280)
        Me.tab_salary.Controls.Add(Me.lbepf280)
        Me.tab_salary.Controls.Add(Me.lballowance280)
        Me.tab_salary.Controls.Add(Me.lbovertime280)
        Me.tab_salary.Controls.Add(Me.lbbasic_salary280)
        Me.tab_salary.Controls.Add(Me.cbmonth)
        Me.tab_salary.Controls.Add(Me.lbtotal)
        Me.tab_salary.Controls.Add(Me.lbothers)
        Me.tab_salary.Controls.Add(Me.lbbasicsalary)
        Me.tab_salary.Controls.Add(Me.lbclaims)
        Me.tab_salary.Controls.Add(Me.lbsocso)
        Me.tab_salary.Controls.Add(Me.lbepf)
        Me.tab_salary.Controls.Add(Me.lballowance)
        Me.tab_salary.Controls.Add(Me.lbovertime)
        Me.tab_salary.Controls.Add(Me.lbmonth)
        Me.tab_salary.Location = New System.Drawing.Point(4, 22)
        Me.tab_salary.Name = "tab_salary"
        Me.tab_salary.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_salary.Size = New System.Drawing.Size(720, 410)
        Me.tab_salary.TabIndex = 0
        Me.tab_salary.Text = "Salary"
        Me.tab_salary.UseVisualStyleBackColor = True
        '
        'tab_leave
        '
        Me.tab_leave.Controls.Add(Me.datagrid_leave_history)
        Me.tab_leave.Controls.Add(Me.lbnew_leave)
        Me.tab_leave.Location = New System.Drawing.Point(4, 22)
        Me.tab_leave.Name = "tab_leave"
        Me.tab_leave.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_leave.Size = New System.Drawing.Size(720, 386)
        Me.tab_leave.TabIndex = 1
        Me.tab_leave.Text = "Leave"
        Me.tab_leave.UseVisualStyleBackColor = True
        '
        'lbtotal280
        '
        Me.lbtotal280.AutoSize = True
        Me.lbtotal280.Location = New System.Drawing.Point(409, 358)
        Me.lbtotal280.Name = "lbtotal280"
        Me.lbtotal280.Size = New System.Drawing.Size(45, 13)
        Me.lbtotal280.TabIndex = 158
        Me.lbtotal280.Text = "Label10"
        '
        'lbothers280
        '
        Me.lbothers280.AutoSize = True
        Me.lbothers280.Location = New System.Drawing.Point(409, 323)
        Me.lbothers280.Name = "lbothers280"
        Me.lbothers280.Size = New System.Drawing.Size(39, 13)
        Me.lbothers280.TabIndex = 157
        Me.lbothers280.Text = "Label9"
        '
        'lbclaims280
        '
        Me.lbclaims280.AutoSize = True
        Me.lbclaims280.Location = New System.Drawing.Point(409, 289)
        Me.lbclaims280.Name = "lbclaims280"
        Me.lbclaims280.Size = New System.Drawing.Size(39, 13)
        Me.lbclaims280.TabIndex = 156
        Me.lbclaims280.Text = "Label8"
        '
        'lbsocso280
        '
        Me.lbsocso280.AutoSize = True
        Me.lbsocso280.Location = New System.Drawing.Point(409, 259)
        Me.lbsocso280.Name = "lbsocso280"
        Me.lbsocso280.Size = New System.Drawing.Size(39, 13)
        Me.lbsocso280.TabIndex = 155
        Me.lbsocso280.Text = "Label7"
        '
        'lbepf280
        '
        Me.lbepf280.AutoSize = True
        Me.lbepf280.Location = New System.Drawing.Point(409, 226)
        Me.lbepf280.Name = "lbepf280"
        Me.lbepf280.Size = New System.Drawing.Size(39, 13)
        Me.lbepf280.TabIndex = 154
        Me.lbepf280.Text = "Label6"
        '
        'lballowance280
        '
        Me.lballowance280.AutoSize = True
        Me.lballowance280.Location = New System.Drawing.Point(409, 197)
        Me.lballowance280.Name = "lballowance280"
        Me.lballowance280.Size = New System.Drawing.Size(39, 13)
        Me.lballowance280.TabIndex = 153
        Me.lballowance280.Text = "Label5"
        '
        'lbovertime280
        '
        Me.lbovertime280.AutoSize = True
        Me.lbovertime280.Location = New System.Drawing.Point(409, 162)
        Me.lbovertime280.Name = "lbovertime280"
        Me.lbovertime280.Size = New System.Drawing.Size(39, 13)
        Me.lbovertime280.TabIndex = 152
        Me.lbovertime280.Text = "Label4"
        '
        'lbbasic_salary280
        '
        Me.lbbasic_salary280.AutoSize = True
        Me.lbbasic_salary280.Location = New System.Drawing.Point(409, 128)
        Me.lbbasic_salary280.Name = "lbbasic_salary280"
        Me.lbbasic_salary280.Size = New System.Drawing.Size(39, 13)
        Me.lbbasic_salary280.TabIndex = 151
        Me.lbbasic_salary280.Text = "Label3"
        '
        'cbmonth
        '
        Me.cbmonth.FormattingEnabled = True
        Me.cbmonth.Items.AddRange(New Object() {"January ", "February", "March ", "April", "May", "June", "July", "August", "September", "October", "November", "December "})
        Me.cbmonth.Location = New System.Drawing.Point(319, 15)
        Me.cbmonth.Name = "cbmonth"
        Me.cbmonth.Size = New System.Drawing.Size(177, 21)
        Me.cbmonth.TabIndex = 150
        '
        'lbtotal
        '
        Me.lbtotal.AutoSize = True
        Me.lbtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtotal.Location = New System.Drawing.Point(225, 355)
        Me.lbtotal.Name = "lbtotal"
        Me.lbtotal.Size = New System.Drawing.Size(39, 16)
        Me.lbtotal.TabIndex = 149
        Me.lbtotal.Text = "Total"
        '
        'lbothers
        '
        Me.lbothers.AutoSize = True
        Me.lbothers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbothers.Location = New System.Drawing.Point(225, 321)
        Me.lbothers.Name = "lbothers"
        Me.lbothers.Size = New System.Drawing.Size(47, 16)
        Me.lbothers.TabIndex = 148
        Me.lbothers.Text = "Others"
        '
        'lbbasicsalary
        '
        Me.lbbasicsalary.AutoSize = True
        Me.lbbasicsalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbbasicsalary.Location = New System.Drawing.Point(225, 126)
        Me.lbbasicsalary.Name = "lbbasicsalary"
        Me.lbbasicsalary.Size = New System.Drawing.Size(84, 16)
        Me.lbbasicsalary.TabIndex = 147
        Me.lbbasicsalary.Text = "Basic Salary"
        '
        'lbclaims
        '
        Me.lbclaims.AutoSize = True
        Me.lbclaims.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbclaims.Location = New System.Drawing.Point(225, 292)
        Me.lbclaims.Name = "lbclaims"
        Me.lbclaims.Size = New System.Drawing.Size(49, 16)
        Me.lbclaims.TabIndex = 146
        Me.lbclaims.Text = "Claims"
        '
        'lbsocso
        '
        Me.lbsocso.AutoSize = True
        Me.lbsocso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsocso.Location = New System.Drawing.Point(225, 261)
        Me.lbsocso.Name = "lbsocso"
        Me.lbsocso.Size = New System.Drawing.Size(55, 16)
        Me.lbsocso.TabIndex = 145
        Me.lbsocso.Text = "SOCSO"
        '
        'lbepf
        '
        Me.lbepf.AutoSize = True
        Me.lbepf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbepf.Location = New System.Drawing.Point(225, 230)
        Me.lbepf.Name = "lbepf"
        Me.lbepf.Size = New System.Drawing.Size(34, 16)
        Me.lbepf.TabIndex = 144
        Me.lbepf.Text = "EPF"
        '
        'lballowance
        '
        Me.lballowance.AutoSize = True
        Me.lballowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lballowance.Location = New System.Drawing.Point(225, 197)
        Me.lballowance.Name = "lballowance"
        Me.lballowance.Size = New System.Drawing.Size(70, 16)
        Me.lballowance.TabIndex = 143
        Me.lballowance.Text = "Allowance"
        '
        'lbovertime
        '
        Me.lbovertime.AutoSize = True
        Me.lbovertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbovertime.Location = New System.Drawing.Point(225, 162)
        Me.lbovertime.Name = "lbovertime"
        Me.lbovertime.Size = New System.Drawing.Size(62, 16)
        Me.lbovertime.TabIndex = 142
        Me.lbovertime.Text = "Overtime"
        '
        'lbmonth
        '
        Me.lbmonth.AutoSize = True
        Me.lbmonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmonth.Location = New System.Drawing.Point(225, 15)
        Me.lbmonth.Name = "lbmonth"
        Me.lbmonth.Size = New System.Drawing.Size(44, 16)
        Me.lbmonth.TabIndex = 141
        Me.lbmonth.Text = "Month"
        '
        'tab_claims
        '
        Me.tab_claims.Controls.Add(Me.datagrid_payroll_mgmt)
        Me.tab_claims.Controls.Add(Me.btn_new_claim)
        Me.tab_claims.Location = New System.Drawing.Point(4, 22)
        Me.tab_claims.Name = "tab_claims"
        Me.tab_claims.Size = New System.Drawing.Size(720, 386)
        Me.tab_claims.TabIndex = 2
        Me.tab_claims.Text = "Claims"
        Me.tab_claims.UseVisualStyleBackColor = True
        '
        'datagrid_payroll_mgmt
        '
        Me.datagrid_payroll_mgmt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_payroll_mgmt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.datagrid_payroll_mgmt.Location = New System.Drawing.Point(0, 86)
        Me.datagrid_payroll_mgmt.Name = "datagrid_payroll_mgmt"
        Me.datagrid_payroll_mgmt.Size = New System.Drawing.Size(720, 300)
        Me.datagrid_payroll_mgmt.TabIndex = 6
        '
        'btn_new_claim
        '
        Me.btn_new_claim.Location = New System.Drawing.Point(3, 31)
        Me.btn_new_claim.Name = "btn_new_claim"
        Me.btn_new_claim.Size = New System.Drawing.Size(106, 36)
        Me.btn_new_claim.TabIndex = 5
        Me.btn_new_claim.Text = "+ New Claim"
        Me.btn_new_claim.UseVisualStyleBackColor = True
        '
        'MyLeave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MyLeave"
        Me.Size = New System.Drawing.Size(728, 412)
        CType(Me.datagrid_leave_history, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_salary.ResumeLayout(False)
        Me.tab_salary.PerformLayout()
        Me.tab_leave.ResumeLayout(False)
        Me.tab_claims.ResumeLayout(False)
        CType(Me.datagrid_payroll_mgmt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datagrid_leave_history As System.Windows.Forms.DataGridView
    Friend WithEvents lbnew_leave As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_salary As System.Windows.Forms.TabPage
    Friend WithEvents tab_leave As System.Windows.Forms.TabPage
    Friend WithEvents lbtotal280 As System.Windows.Forms.Label
    Friend WithEvents lbothers280 As System.Windows.Forms.Label
    Friend WithEvents lbclaims280 As System.Windows.Forms.Label
    Friend WithEvents lbsocso280 As System.Windows.Forms.Label
    Friend WithEvents lbepf280 As System.Windows.Forms.Label
    Friend WithEvents lballowance280 As System.Windows.Forms.Label
    Friend WithEvents lbovertime280 As System.Windows.Forms.Label
    Friend WithEvents lbbasic_salary280 As System.Windows.Forms.Label
    Friend WithEvents cbmonth As System.Windows.Forms.ComboBox
    Friend WithEvents lbtotal As System.Windows.Forms.Label
    Friend WithEvents lbothers As System.Windows.Forms.Label
    Friend WithEvents lbbasicsalary As System.Windows.Forms.Label
    Friend WithEvents lbclaims As System.Windows.Forms.Label
    Friend WithEvents lbsocso As System.Windows.Forms.Label
    Friend WithEvents lbepf As System.Windows.Forms.Label
    Friend WithEvents lballowance As System.Windows.Forms.Label
    Friend WithEvents lbovertime As System.Windows.Forms.Label
    Friend WithEvents lbmonth As System.Windows.Forms.Label
    Friend WithEvents tab_claims As System.Windows.Forms.TabPage
    Friend WithEvents datagrid_payroll_mgmt As System.Windows.Forms.DataGridView
    Friend WithEvents btn_new_claim As System.Windows.Forms.Button

End Class
