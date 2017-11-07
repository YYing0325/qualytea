<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cmdlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cmdlogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbusername = New System.Windows.Forms.Label
        Me.lbpassword = New System.Windows.Forms.Label
        Me.tbusername = New System.Windows.Forms.TextBox
        Me.tbpassword = New System.Windows.Forms.TextBox
        Me.cbrmbr = New System.Windows.Forms.CheckBox
        Me.btnlogin = New System.Windows.Forms.Button
        Me.btnFirstTime = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(134, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lbusername
        '
        Me.lbusername.AutoSize = True
        Me.lbusername.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbusername.Location = New System.Drawing.Point(27, 132)
        Me.lbusername.Name = "lbusername"
        Me.lbusername.Size = New System.Drawing.Size(68, 15)
        Me.lbusername.TabIndex = 2
        Me.lbusername.Text = "Username:"
        '
        'lbpassword
        '
        Me.lbpassword.AutoSize = True
        Me.lbpassword.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpassword.Location = New System.Drawing.Point(27, 169)
        Me.lbpassword.Name = "lbpassword"
        Me.lbpassword.Size = New System.Drawing.Size(64, 15)
        Me.lbpassword.TabIndex = 3
        Me.lbpassword.Text = "Password:"
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(88, 129)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(243, 21)
        Me.tbusername.TabIndex = 4
        '
        'tbpassword
        '
        Me.tbpassword.Location = New System.Drawing.Point(88, 166)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpassword.Size = New System.Drawing.Size(243, 21)
        Me.tbpassword.TabIndex = 5
        '
        'cbrmbr
        '
        Me.cbrmbr.AutoSize = True
        Me.cbrmbr.Location = New System.Drawing.Point(39, 217)
        Me.cbrmbr.Name = "cbrmbr"
        Me.cbrmbr.Size = New System.Drawing.Size(97, 17)
        Me.cbrmbr.TabIndex = 6
        Me.cbrmbr.Text = "Remember me!"
        Me.cbrmbr.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnlogin.Location = New System.Drawing.Point(248, 259)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(83, 36)
        Me.btnlogin.TabIndex = 7
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btnFirstTime
        '
        Me.btnFirstTime.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnFirstTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirstTime.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFirstTime.Location = New System.Drawing.Point(39, 259)
        Me.btnFirstTime.Name = "btnFirstTime"
        Me.btnFirstTime.Size = New System.Drawing.Size(130, 33)
        Me.btnFirstTime.TabIndex = 8
        Me.btnFirstTime.Text = "First Time Login"
        Me.btnFirstTime.UseVisualStyleBackColor = False
        '
        'cmdlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(366, 319)
        Me.Controls.Add(Me.btnFirstTime)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.cbrmbr)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.tbusername)
        Me.Controls.Add(Me.lbpassword)
        Me.Controls.Add(Me.lbusername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "cmdlogin"
        Me.Text = "Login "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbusername As System.Windows.Forms.Label
    Friend WithEvents lbpassword As System.Windows.Forms.Label
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents tbpassword As System.Windows.Forms.TextBox
    Friend WithEvents cbrmbr As System.Windows.Forms.CheckBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btnFirstTime As System.Windows.Forms.Button
End Class
