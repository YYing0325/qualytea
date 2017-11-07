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
        Me.lblemployeeID = New System.Windows.Forms.Label
        Me.tbemployeeID = New System.Windows.Forms.TextBox
        Me.lblusername = New System.Windows.Forms.Label
        Me.tbusername = New System.Windows.Forms.TextBox
        Me.lblpassword = New System.Windows.Forms.Label
        Me.lblconfirmedpassword = New System.Windows.Forms.Label
        Me.btnnext = New System.Windows.Forms.Button
        Me.mtbpassword = New System.Windows.Forms.MaskedTextBox
        Me.mtbconfirmedpassword = New System.Windows.Forms.MaskedTextBox
        Me.SuspendLayout()
        '
        'lblemployeeID
        '
        Me.lblemployeeID.AutoSize = True
        Me.lblemployeeID.Location = New System.Drawing.Point(26, 58)
        Me.lblemployeeID.Name = "lblemployeeID"
        Me.lblemployeeID.Size = New System.Drawing.Size(77, 12)
        Me.lblemployeeID.TabIndex = 0
        Me.lblemployeeID.Text = "Employee ID:"
        '
        'tbemployeeID
        '
        Me.tbemployeeID.Location = New System.Drawing.Point(199, 55)
        Me.tbemployeeID.Name = "tbemployeeID"
        Me.tbemployeeID.Size = New System.Drawing.Size(125, 21)
        Me.tbemployeeID.TabIndex = 1
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(28, 85)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(59, 12)
        Me.lblusername.TabIndex = 2
        Me.lblusername.Text = "Username:"
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(199, 82)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(125, 21)
        Me.tbusername.TabIndex = 3
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(28, 112)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(59, 12)
        Me.lblpassword.TabIndex = 4
        Me.lblpassword.Text = "Password:"
        '
        'lblconfirmedpassword
        '
        Me.lblconfirmedpassword.AutoSize = True
        Me.lblconfirmedpassword.Location = New System.Drawing.Point(26, 139)
        Me.lblconfirmedpassword.Name = "lblconfirmedpassword"
        Me.lblconfirmedpassword.Size = New System.Drawing.Size(107, 12)
        Me.lblconfirmedpassword.TabIndex = 6
        Me.lblconfirmedpassword.Text = "Confirm Password:"
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnext.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnnext.Location = New System.Drawing.Point(308, 177)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(83, 33)
        Me.btnnext.TabIndex = 8
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'mtbpassword
        '
        Me.mtbpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mtbpassword.Location = New System.Drawing.Point(199, 109)
        Me.mtbpassword.Name = "mtbpassword"
        Me.mtbpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtbpassword.Size = New System.Drawing.Size(125, 21)
        Me.mtbpassword.TabIndex = 9
        '
        'mtbconfirmedpassword
        '
        Me.mtbconfirmedpassword.Location = New System.Drawing.Point(199, 136)
        Me.mtbconfirmedpassword.Name = "mtbconfirmedpassword"
        Me.mtbconfirmedpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtbconfirmedpassword.Size = New System.Drawing.Size(125, 21)
        Me.mtbconfirmedpassword.TabIndex = 10
        '
        'FirstTimeSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 230)
        Me.Controls.Add(Me.mtbconfirmedpassword)
        Me.Controls.Add(Me.mtbpassword)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.lblconfirmedpassword)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.tbusername)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.tbemployeeID)
        Me.Controls.Add(Me.lblemployeeID)
        Me.Name = "FirstTimeSignUp"
        Me.Text = "FirstTimeLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblemployeeID As System.Windows.Forms.Label
    Friend WithEvents tbemployeeID As System.Windows.Forms.TextBox
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lblconfirmedpassword As System.Windows.Forms.Label
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents mtbpassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbconfirmedpassword As System.Windows.Forms.MaskedTextBox
End Class
