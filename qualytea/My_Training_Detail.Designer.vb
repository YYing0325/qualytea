<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class My_Training_Detail
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
        Me.lb_trcourse105 = New System.Windows.Forms.Label
        Me.lb_trcode105 = New System.Windows.Forms.Label
        Me.lb_trParticipantlist105 = New System.Windows.Forms.Label
        Me.Data_GridView_Detail = New System.Windows.Forms.DataGridView
        Me.cmb_code = New System.Windows.Forms.ComboBox
        Me.lbl_course_name = New System.Windows.Forms.Label
        CType(Me.Data_GridView_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_trcourse105
        '
        Me.lb_trcourse105.AutoSize = True
        Me.lb_trcourse105.Location = New System.Drawing.Point(31, 77)
        Me.lb_trcourse105.Name = "lb_trcourse105"
        Me.lb_trcourse105.Size = New System.Drawing.Size(43, 13)
        Me.lb_trcourse105.TabIndex = 7
        Me.lb_trcourse105.Text = "Course:"
        '
        'lb_trcode105
        '
        Me.lb_trcode105.AutoSize = True
        Me.lb_trcode105.Location = New System.Drawing.Point(31, 40)
        Me.lb_trcode105.Name = "lb_trcode105"
        Me.lb_trcode105.Size = New System.Drawing.Size(35, 13)
        Me.lb_trcode105.TabIndex = 6
        Me.lb_trcode105.Text = "Code:"
        '
        'lb_trParticipantlist105
        '
        Me.lb_trParticipantlist105.AutoSize = True
        Me.lb_trParticipantlist105.Location = New System.Drawing.Point(41, 131)
        Me.lb_trParticipantlist105.Name = "lb_trParticipantlist105"
        Me.lb_trParticipantlist105.Size = New System.Drawing.Size(72, 13)
        Me.lb_trParticipantlist105.TabIndex = 10
        Me.lb_trParticipantlist105.Text = "Participate list"
        '
        'Data_GridView_Detail
        '
        Me.Data_GridView_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_GridView_Detail.Location = New System.Drawing.Point(34, 156)
        Me.Data_GridView_Detail.Name = "Data_GridView_Detail"
        Me.Data_GridView_Detail.Size = New System.Drawing.Size(499, 173)
        Me.Data_GridView_Detail.TabIndex = 12
        '
        'cmb_code
        '
        Me.cmb_code.FormattingEnabled = True
        Me.cmb_code.Location = New System.Drawing.Point(85, 37)
        Me.cmb_code.Name = "cmb_code"
        Me.cmb_code.Size = New System.Drawing.Size(214, 21)
        Me.cmb_code.TabIndex = 13
        Me.cmb_code.Text = "Select Training Code"
        '
        'lbl_course_name
        '
        Me.lbl_course_name.AutoSize = True
        Me.lbl_course_name.Location = New System.Drawing.Point(82, 77)
        Me.lbl_course_name.Name = "lbl_course_name"
        Me.lbl_course_name.Size = New System.Drawing.Size(70, 13)
        Me.lbl_course_name.TabIndex = 14
        Me.lbl_course_name.Text = "Not Available"
        '
        'My_Training_Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 371)
        Me.Controls.Add(Me.lbl_course_name)
        Me.Controls.Add(Me.cmb_code)
        Me.Controls.Add(Me.Data_GridView_Detail)
        Me.Controls.Add(Me.lb_trParticipantlist105)
        Me.Controls.Add(Me.lb_trcourse105)
        Me.Controls.Add(Me.lb_trcode105)
        Me.Name = "My_Training_Detail"
        Me.Text = "My_Training_Detail"
        CType(Me.Data_GridView_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_trcourse105 As System.Windows.Forms.Label
    Friend WithEvents lb_trcode105 As System.Windows.Forms.Label
    Friend WithEvents lb_trParticipantlist105 As System.Windows.Forms.Label
    Friend WithEvents Data_GridView_Detail As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_code As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_course_name As System.Windows.Forms.Label
End Class
