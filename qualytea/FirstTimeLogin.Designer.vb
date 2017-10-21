<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstTimeSignUp
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
        Me.lblEmployeeId = New System.Windows.Forms.Label
        Me.tbEmployeeId = New System.Windows.Forms.TextBox
        Me.lblUsername = New System.Windows.Forms.Label
        Me.tbUsernameFirstTimeUser = New System.Windows.Forms.TextBox
        Me.lblPasswordFirstTime = New System.Windows.Forms.Label
        Me.tbPasswordFirstTimeUser = New System.Windows.Forms.TextBox
        Me.lblConfirmPasswordFirstTime = New System.Windows.Forms.Label
        Me.tbConfirmPasswordFirstTimeUser = New System.Windows.Forms.TextBox
        Me.btnNextFirstTimeUser = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblEmployeeId
        '
        Me.lblEmployeeId.AutoSize = True
        Me.lblEmployeeId.Location = New System.Drawing.Point(26, 58)
        Me.lblEmployeeId.Name = "lblEmployeeId"
        Me.lblEmployeeId.Size = New System.Drawing.Size(77, 12)
        Me.lblEmployeeId.TabIndex = 0
        Me.lblEmployeeId.Text = "Employee ID:"
        '
        'tbEmployeeId
        '
        Me.tbEmployeeId.Location = New System.Drawing.Point(199, 55)
        Me.tbEmployeeId.Name = "tbEmployeeId"
        Me.tbEmployeeId.Size = New System.Drawing.Size(125, 21)
        Me.tbEmployeeId.TabIndex = 1
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(28, 85)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(59, 12)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Username:"
        '
        'tbUsernameFirstTimeUser
        '
        Me.tbUsernameFirstTimeUser.Location = New System.Drawing.Point(199, 82)
        Me.tbUsernameFirstTimeUser.Name = "tbUsernameFirstTimeUser"
        Me.tbUsernameFirstTimeUser.Size = New System.Drawing.Size(125, 21)
        Me.tbUsernameFirstTimeUser.TabIndex = 3
        '
        'lblPasswordFirstTime
        '
        Me.lblPasswordFirstTime.AutoSize = True
        Me.lblPasswordFirstTime.Location = New System.Drawing.Point(28, 112)
        Me.lblPasswordFirstTime.Name = "lblPasswordFirstTime"
        Me.lblPasswordFirstTime.Size = New System.Drawing.Size(59, 12)
        Me.lblPasswordFirstTime.TabIndex = 4
        Me.lblPasswordFirstTime.Text = "Password:"
        '
        'tbPasswordFirstTimeUser
        '
        Me.tbPasswordFirstTimeUser.Location = New System.Drawing.Point(199, 109)
        Me.tbPasswordFirstTimeUser.Name = "tbPasswordFirstTimeUser"
        Me.tbPasswordFirstTimeUser.Size = New System.Drawing.Size(125, 21)
        Me.tbPasswordFirstTimeUser.TabIndex = 5
        '
        'lblConfirmPasswordFirstTime
        '
        Me.lblConfirmPasswordFirstTime.AutoSize = True
        Me.lblConfirmPasswordFirstTime.Location = New System.Drawing.Point(26, 139)
        Me.lblConfirmPasswordFirstTime.Name = "lblConfirmPasswordFirstTime"
        Me.lblConfirmPasswordFirstTime.Size = New System.Drawing.Size(107, 12)
        Me.lblConfirmPasswordFirstTime.TabIndex = 6
        Me.lblConfirmPasswordFirstTime.Text = "Confirm Password:"
        '
        'tbConfirmPasswordFirstTimeUser
        '
        Me.tbConfirmPasswordFirstTimeUser.Location = New System.Drawing.Point(199, 136)
        Me.tbConfirmPasswordFirstTimeUser.Name = "tbConfirmPasswordFirstTimeUser"
        Me.tbConfirmPasswordFirstTimeUser.Size = New System.Drawing.Size(125, 21)
        Me.tbConfirmPasswordFirstTimeUser.TabIndex = 7
        '
        'btnNextFirstTimeUser
        '
        Me.btnNextFirstTimeUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNextFirstTimeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextFirstTimeUser.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextFirstTimeUser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNextFirstTimeUser.Location = New System.Drawing.Point(308, 177)
        Me.btnNextFirstTimeUser.Name = "btnNextFirstTimeUser"
        Me.btnNextFirstTimeUser.Size = New System.Drawing.Size(83, 33)
        Me.btnNextFirstTimeUser.TabIndex = 8
        Me.btnNextFirstTimeUser.Text = "Next"
        Me.btnNextFirstTimeUser.UseVisualStyleBackColor = False
        '
        'FirstTimeSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 230)
        Me.Controls.Add(Me.btnNextFirstTimeUser)
        Me.Controls.Add(Me.tbConfirmPasswordFirstTimeUser)
        Me.Controls.Add(Me.lblConfirmPasswordFirstTime)
        Me.Controls.Add(Me.tbPasswordFirstTimeUser)
        Me.Controls.Add(Me.lblPasswordFirstTime)
        Me.Controls.Add(Me.tbUsernameFirstTimeUser)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.tbEmployeeId)
        Me.Controls.Add(Me.lblEmployeeId)
        Me.Name = "FirstTimeSignUp"
        Me.Text = "FirstTimeLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmployeeId As System.Windows.Forms.Label
    Friend WithEvents tbEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents tbUsernameFirstTimeUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordFirstTime As System.Windows.Forms.Label
    Friend WithEvents tbPasswordFirstTimeUser As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPasswordFirstTime As System.Windows.Forms.Label
    Friend WithEvents tbConfirmPasswordFirstTimeUser As System.Windows.Forms.TextBox
    Friend WithEvents btnNextFirstTimeUser As System.Windows.Forms.Button
End Class
