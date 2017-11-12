<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leave_H_Management
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
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.datagrid_leave_request = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.datagrid_leave_history = New System.Windows.Forms.DataGridView
        Me.lbnew_leave = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2.SuspendLayout()
        CType(Me.datagrid_leave_request, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.datagrid_leave_history, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.datagrid_leave_request)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(955, 518)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Leave Request"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'datagrid_leave_request
        '
        Me.datagrid_leave_request.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_leave_request.Location = New System.Drawing.Point(6, 67)
        Me.datagrid_leave_request.Name = "datagrid_leave_request"
        Me.datagrid_leave_request.Size = New System.Drawing.Size(778, 122)
        Me.datagrid_leave_request.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.datagrid_leave_history)
        Me.TabPage3.Controls.Add(Me.lbnew_leave)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(955, 518)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "My Leave"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'datagrid_leave_history
        '
        Me.datagrid_leave_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_leave_history.Location = New System.Drawing.Point(31, 121)
        Me.datagrid_leave_history.Name = "datagrid_leave_history"
        Me.datagrid_leave_history.Size = New System.Drawing.Size(734, 90)
        Me.datagrid_leave_history.TabIndex = 3
        '
        'lbnew_leave
        '
        Me.lbnew_leave.Location = New System.Drawing.Point(31, 55)
        Me.lbnew_leave.Name = "lbnew_leave"
        Me.lbnew_leave.Size = New System.Drawing.Size(118, 23)
        Me.lbnew_leave.TabIndex = 2
        Me.lbnew_leave.Text = "+ New Leave"
        Me.lbnew_leave.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(963, 544)
        Me.TabControl1.TabIndex = 0
        '
        'Leave_H_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Leave_H_Management"
        Me.Size = New System.Drawing.Size(969, 547)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.datagrid_leave_request, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.datagrid_leave_history, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents datagrid_leave_request As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents datagrid_leave_history As System.Windows.Forms.DataGridView
    Friend WithEvents lbnew_leave As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl

End Class
