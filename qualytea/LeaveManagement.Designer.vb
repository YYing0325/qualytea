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
        Me.tab_salary = New System.Windows.Forms.TabPage
        Me.datagrid_salary = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tab_salary.SuspendLayout()
        CType(Me.datagrid_salary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
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
        'datagrid_salary
        '
        Me.datagrid_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_salary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid_salary.Location = New System.Drawing.Point(3, 3)
        Me.datagrid_salary.Name = "datagrid_salary"
        Me.datagrid_salary.Size = New System.Drawing.Size(868, 368)
        Me.datagrid_salary.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_salary)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(882, 400)
        Me.TabControl1.TabIndex = 0
        '
        'LeaveManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "LeaveManagement"
        Me.Size = New System.Drawing.Size(882, 400)
        Me.tab_salary.ResumeLayout(False)
        CType(Me.datagrid_salary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_salary As System.Windows.Forms.TabPage
    Friend WithEvents datagrid_salary As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl

End Class
