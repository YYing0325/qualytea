<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeaveManagement
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tab_leave = New System.Windows.Forms.TabPage
        Me.tab_salary = New System.Windows.Forms.TabPage
        Me.datagrid_leave_request = New System.Windows.Forms.DataGridView
        Me.tab_claims = New System.Windows.Forms.TabPage
        Me.datagrid_claim = New System.Windows.Forms.DataGridView
        Me.datagrid_salary = New System.Windows.Forms.DataGridView
        Me.TabControl1.SuspendLayout()
        Me.tab_leave.SuspendLayout()
        Me.tab_salary.SuspendLayout()
        CType(Me.datagrid_leave_request, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_claims.SuspendLayout()
        CType(Me.datagrid_claim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagrid_salary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_salary)
        Me.TabControl1.Controls.Add(Me.tab_leave)
        Me.TabControl1.Controls.Add(Me.tab_claims)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(882, 400)
        Me.TabControl1.TabIndex = 0
        '
        'tab_leave
        '
        Me.tab_leave.Controls.Add(Me.datagrid_leave_request)
        Me.tab_leave.Location = New System.Drawing.Point(4, 22)
        Me.tab_leave.Name = "tab_leave"
        Me.tab_leave.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_leave.Size = New System.Drawing.Size(874, 374)
        Me.tab_leave.TabIndex = 0
        Me.tab_leave.Text = "Leave"
        Me.tab_leave.UseVisualStyleBackColor = True
        '
        'tab_salary
        '
        Me.tab_salary.Controls.Add(Me.datagrid_salary)
        Me.tab_salary.Location = New System.Drawing.Point(4, 22)
        Me.tab_salary.Name = "tab_salary"
        Me.tab_salary.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_salary.Size = New System.Drawing.Size(874, 374)
        Me.tab_salary.TabIndex = 1
        Me.tab_salary.Text = "Salary"
        Me.tab_salary.UseVisualStyleBackColor = True
        '
        'datagrid_leave_request
        '
        Me.datagrid_leave_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_leave_request.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid_leave_request.Location = New System.Drawing.Point(3, 3)
        Me.datagrid_leave_request.Name = "datagrid_leave_request"
        Me.datagrid_leave_request.Size = New System.Drawing.Size(868, 368)
        Me.datagrid_leave_request.TabIndex = 1
        '
        'tab_claims
        '
        Me.tab_claims.Controls.Add(Me.datagrid_claim)
        Me.tab_claims.Location = New System.Drawing.Point(4, 22)
        Me.tab_claims.Name = "tab_claims"
        Me.tab_claims.Size = New System.Drawing.Size(874, 374)
        Me.tab_claims.TabIndex = 2
        Me.tab_claims.Text = "Claims"
        Me.tab_claims.UseVisualStyleBackColor = True
        '
        'datagrid_claim
        '
        Me.datagrid_claim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_claim.Location = New System.Drawing.Point(3, 43)
        Me.datagrid_claim.Name = "datagrid_claim"
        Me.datagrid_claim.Size = New System.Drawing.Size(802, 286)
        Me.datagrid_claim.TabIndex = 2
        '
        'datagrid_salary
        '
        Me.datagrid_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_salary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid_salary.Location = New System.Drawing.Point(3, 3)
        Me.datagrid_salary.Name = "datagrid_salary"
        Me.datagrid_salary.Size = New System.Drawing.Size(868, 368)
        Me.datagrid_salary.TabIndex = 2
        '
        'LeaveManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "LeaveManagement"
        Me.Size = New System.Drawing.Size(882, 400)
        Me.TabControl1.ResumeLayout(False)
        Me.tab_leave.ResumeLayout(False)
        Me.tab_salary.ResumeLayout(False)
        CType(Me.datagrid_leave_request, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_claims.ResumeLayout(False)
        CType(Me.datagrid_claim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagrid_salary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_leave As System.Windows.Forms.TabPage
    Friend WithEvents tab_salary As System.Windows.Forms.TabPage
    Friend WithEvents datagrid_leave_request As System.Windows.Forms.DataGridView
    Friend WithEvents tab_claims As System.Windows.Forms.TabPage
    Friend WithEvents datagrid_salary As System.Windows.Forms.DataGridView
    Friend WithEvents datagrid_claim As System.Windows.Forms.DataGridView

End Class
