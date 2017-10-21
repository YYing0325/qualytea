<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWelcome))
        Me.Welcome = New System.Windows.Forms.PictureBox
        Me.lblwelcome = New System.Windows.Forms.Label
        Me.btncontinue = New System.Windows.Forms.Button
        Me.lbl_welcome_name = New System.Windows.Forms.Label
        CType(Me.Welcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Welcome
        '
        Me.Welcome.Image = CType(resources.GetObject("Welcome.Image"), System.Drawing.Image)
        Me.Welcome.InitialImage = CType(resources.GetObject("Welcome.InitialImage"), System.Drawing.Image)
        Me.Welcome.Location = New System.Drawing.Point(84, 23)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Size = New System.Drawing.Size(114, 83)
        Me.Welcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Welcome.TabIndex = 0
        Me.Welcome.TabStop = False
        '
        'lblwelcome
        '
        Me.lblwelcome.Font = New System.Drawing.Font("Lato", 8.25!)
        Me.lblwelcome.Location = New System.Drawing.Point(-5, 157)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(297, 12)
        Me.lblwelcome.TabIndex = 1
        Me.lblwelcome.Text = "Welcome to Qualytea HR system!"
        Me.lblwelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btncontinue
        '
        Me.btncontinue.Location = New System.Drawing.Point(84, 195)
        Me.btncontinue.Name = "btncontinue"
        Me.btncontinue.Size = New System.Drawing.Size(114, 21)
        Me.btncontinue.TabIndex = 2
        Me.btncontinue.Text = "Continue"
        Me.btncontinue.UseVisualStyleBackColor = True
        '
        'lbl_welcome_name
        '
        Me.lbl_welcome_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_welcome_name.Font = New System.Drawing.Font("Lato", 8.25!)
        Me.lbl_welcome_name.Location = New System.Drawing.Point(-8, 121)
        Me.lbl_welcome_name.Name = "lbl_welcome_name"
        Me.lbl_welcome_name.Size = New System.Drawing.Size(300, 13)
        Me.lbl_welcome_name.TabIndex = 3
        Me.lbl_welcome_name.Text = "Hi"
        Me.lbl_welcome_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lbl_welcome_name)
        Me.Controls.Add(Me.btncontinue)
        Me.Controls.Add(Me.lblwelcome)
        Me.Controls.Add(Me.Welcome)
        Me.Name = "FrmWelcome"
        Me.Text = "Welcome"
        CType(Me.Welcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Welcome As System.Windows.Forms.PictureBox
    Friend WithEvents lblwelcome As System.Windows.Forms.Label
    Friend WithEvents btncontinue As System.Windows.Forms.Button
    Friend WithEvents lbl_welcome_name As System.Windows.Forms.Label

End Class
