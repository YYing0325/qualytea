<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.panel_personal = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.input_email = New System.Windows.Forms.TextBox
        Me.input_first_name = New System.Windows.Forms.TextBox
        Me.input_last_name = New System.Windows.Forms.TextBox
        Me.lbl_newPassword = New System.Windows.Forms.Label
        Me.lbl_currentPassword = New System.Windows.Forms.Label
        Me.lbl_confirmPassword = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.img_profile = New System.Windows.Forms.PictureBox
        Me.btn_edit_profile = New System.Windows.Forms.Button
        Me.lbl_emp_id = New System.Windows.Forms.Label
        Me.emp_id = New System.Windows.Forms.Label
        Me.panel_personal.SuspendLayout()
        CType(Me.img_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_personal
        '
        Me.panel_personal.Controls.Add(Me.Button1)
        Me.panel_personal.Controls.Add(Me.input_email)
        Me.panel_personal.Controls.Add(Me.input_first_name)
        Me.panel_personal.Controls.Add(Me.input_last_name)
        Me.panel_personal.Controls.Add(Me.lbl_newPassword)
        Me.panel_personal.Controls.Add(Me.lbl_currentPassword)
        Me.panel_personal.Controls.Add(Me.lbl_confirmPassword)
        Me.panel_personal.Controls.Add(Me.Label1)
        Me.panel_personal.Controls.Add(Me.img_profile)
        Me.panel_personal.Controls.Add(Me.btn_edit_profile)
        Me.panel_personal.Controls.Add(Me.lbl_emp_id)
        Me.panel_personal.Controls.Add(Me.emp_id)
        Me.panel_personal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_personal.Location = New System.Drawing.Point(0, 0)
        Me.panel_personal.Name = "panel_personal"
        Me.panel_personal.Size = New System.Drawing.Size(940, 667)
        Me.panel_personal.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(23, 584)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 33)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'input_email
        '
        Me.input_email.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_email.Location = New System.Drawing.Point(317, 221)
        Me.input_email.Name = "input_email"
        Me.input_email.Size = New System.Drawing.Size(196, 23)
        Me.input_email.TabIndex = 43
        '
        'input_first_name
        '
        Me.input_first_name.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_first_name.Location = New System.Drawing.Point(317, 125)
        Me.input_first_name.Name = "input_first_name"
        Me.input_first_name.Size = New System.Drawing.Size(196, 23)
        Me.input_first_name.TabIndex = 41
        '
        'input_last_name
        '
        Me.input_last_name.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_last_name.Location = New System.Drawing.Point(317, 317)
        Me.input_last_name.Name = "input_last_name"
        Me.input_last_name.Size = New System.Drawing.Size(196, 23)
        Me.input_last_name.TabIndex = 40
        '
        'lbl_newPassword
        '
        Me.lbl_newPassword.AutoSize = True
        Me.lbl_newPassword.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_newPassword.Location = New System.Drawing.Point(314, 203)
        Me.lbl_newPassword.Name = "lbl_newPassword"
        Me.lbl_newPassword.Size = New System.Drawing.Size(84, 15)
        Me.lbl_newPassword.TabIndex = 34
        Me.lbl_newPassword.Text = "New Password"
        '
        'lbl_currentPassword
        '
        Me.lbl_currentPassword.AutoSize = True
        Me.lbl_currentPassword.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currentPassword.Location = New System.Drawing.Point(314, 107)
        Me.lbl_currentPassword.Name = "lbl_currentPassword"
        Me.lbl_currentPassword.Size = New System.Drawing.Size(100, 15)
        Me.lbl_currentPassword.TabIndex = 29
        Me.lbl_currentPassword.Text = "Current Password"
        '
        'lbl_confirmPassword
        '
        Me.lbl_confirmPassword.AutoSize = True
        Me.lbl_confirmPassword.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirmPassword.Location = New System.Drawing.Point(314, 299)
        Me.lbl_confirmPassword.Name = "lbl_confirmPassword"
        Me.lbl_confirmPassword.Size = New System.Drawing.Size(103, 15)
        Me.lbl_confirmPassword.TabIndex = 28
        Me.lbl_confirmPassword.Text = "Confirm Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Change Password"
        '
        'img_profile
        '
        Me.img_profile.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.img_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.img_profile.Image = CType(resources.GetObject("img_profile.Image"), System.Drawing.Image)
        Me.img_profile.InitialImage = CType(resources.GetObject("img_profile.InitialImage"), System.Drawing.Image)
        Me.img_profile.Location = New System.Drawing.Point(31, 107)
        Me.img_profile.Name = "img_profile"
        Me.img_profile.Size = New System.Drawing.Size(232, 233)
        Me.img_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.img_profile.TabIndex = 23
        Me.img_profile.TabStop = False
        '
        'btn_edit_profile
        '
        Me.btn_edit_profile.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_edit_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_profile.Font = New System.Drawing.Font("Lato", 9.0!)
        Me.btn_edit_profile.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit_profile.Location = New System.Drawing.Point(554, 584)
        Me.btn_edit_profile.Name = "btn_edit_profile"
        Me.btn_edit_profile.Size = New System.Drawing.Size(218, 33)
        Me.btn_edit_profile.TabIndex = 21
        Me.btn_edit_profile.Text = "Confirm"
        Me.btn_edit_profile.UseVisualStyleBackColor = False
        '
        'lbl_emp_id
        '
        Me.lbl_emp_id.AutoSize = True
        Me.lbl_emp_id.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_emp_id.Location = New System.Drawing.Point(28, 27)
        Me.lbl_emp_id.Name = "lbl_emp_id"
        Me.lbl_emp_id.Size = New System.Drawing.Size(75, 15)
        Me.lbl_emp_id.TabIndex = 16
        Me.lbl_emp_id.Text = "Employee Id:"
        '
        'emp_id
        '
        Me.emp_id.AutoSize = True
        Me.emp_id.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_id.Location = New System.Drawing.Point(109, 27)
        Me.emp_id.Name = "emp_id"
        Me.emp_id.Size = New System.Drawing.Size(14, 15)
        Me.emp_id.TabIndex = 15
        Me.emp_id.Text = "0"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel_personal)
        Me.Name = "ChangePassword"
        Me.Size = New System.Drawing.Size(940, 667)
        Me.panel_personal.ResumeLayout(False)
        Me.panel_personal.PerformLayout()
        CType(Me.img_profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_personal As System.Windows.Forms.Panel
    Friend WithEvents input_email As System.Windows.Forms.TextBox
    Friend WithEvents input_first_name As System.Windows.Forms.TextBox
    Friend WithEvents input_last_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_newPassword As System.Windows.Forms.Label
    Friend WithEvents lbl_currentPassword As System.Windows.Forms.Label
    Friend WithEvents lbl_confirmPassword As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents img_profile As System.Windows.Forms.PictureBox
    Friend WithEvents btn_edit_profile As System.Windows.Forms.Button
    Friend WithEvents lbl_emp_id As System.Windows.Forms.Label
    Friend WithEvents emp_id As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
