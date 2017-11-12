<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeDashboard
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
        Me.dashboard_panel = New System.Windows.Forms.Panel
        Me.btnPunchInOut = New System.Windows.Forms.Button
        Me.lblMonth = New System.Windows.Forms.Label
        Me.lblTodayMonth = New System.Windows.Forms.Label
        Me.datagrid_attendance = New System.Windows.Forms.DataGridView
        Me.dashboard_panel.SuspendLayout()
        CType(Me.datagrid_attendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dashboard_panel
        '
        Me.dashboard_panel.AutoSize = True
        Me.dashboard_panel.Controls.Add(Me.btnPunchInOut)
        Me.dashboard_panel.Controls.Add(Me.lblMonth)
        Me.dashboard_panel.Controls.Add(Me.lblTodayMonth)
        Me.dashboard_panel.Controls.Add(Me.datagrid_attendance)
        Me.dashboard_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboard_panel.Location = New System.Drawing.Point(0, 0)
        Me.dashboard_panel.Name = "dashboard_panel"
        Me.dashboard_panel.Size = New System.Drawing.Size(791, 611)
        Me.dashboard_panel.TabIndex = 49
        '
        'btnPunchInOut
        '
        Me.btnPunchInOut.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPunchInOut.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunchInOut.Location = New System.Drawing.Point(633, 47)
        Me.btnPunchInOut.Name = "btnPunchInOut"
        Me.btnPunchInOut.Size = New System.Drawing.Size(158, 23)
        Me.btnPunchInOut.TabIndex = 0
        Me.btnPunchInOut.Text = "Punch-In"
        Me.btnPunchInOut.UseVisualStyleBackColor = False
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Lato Medium", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(42, 55)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(52, 15)
        Me.lblMonth.TabIndex = 45
        Me.lblMonth.Text = "Month:"
        '
        'lblTodayMonth
        '
        Me.lblTodayMonth.AutoSize = True
        Me.lblTodayMonth.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodayMonth.Location = New System.Drawing.Point(113, 55)
        Me.lblTodayMonth.Name = "lblTodayMonth"
        Me.lblTodayMonth.Size = New System.Drawing.Size(82, 15)
        Me.lblTodayMonth.TabIndex = 46
        Me.lblTodayMonth.Text = "Todays'Month"
        '
        'datagrid_attendance
        '
        Me.datagrid_attendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid_attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_attendance.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.datagrid_attendance.Location = New System.Drawing.Point(0, 85)
        Me.datagrid_attendance.Name = "datagrid_attendance"
        Me.datagrid_attendance.RowTemplate.Height = 23
        Me.datagrid_attendance.Size = New System.Drawing.Size(791, 526)
        Me.datagrid_attendance.TabIndex = 47
        '
        'HomeDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dashboard_panel)
        Me.Name = "HomeDashboard"
        Me.Size = New System.Drawing.Size(791, 611)
        Me.dashboard_panel.ResumeLayout(False)
        Me.dashboard_panel.PerformLayout()
        CType(Me.datagrid_attendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dashboard_panel As System.Windows.Forms.Panel
    Friend WithEvents btnPunchInOut As System.Windows.Forms.Button
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblTodayMonth As System.Windows.Forms.Label
    Friend WithEvents datagrid_attendance As System.Windows.Forms.DataGridView

End Class
