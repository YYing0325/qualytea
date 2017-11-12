<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Claims_Application_Form
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
        Me.tbamount = New System.Windows.Forms.TextBox
        Me.lbamount = New System.Windows.Forms.Label
        Me.tbsalary = New System.Windows.Forms.TextBox
        Me.tbremarks = New System.Windows.Forms.TextBox
        Me.lbproject = New System.Windows.Forms.Label
        Me.lbremarks = New System.Windows.Forms.Label
        Me.btapply211 = New System.Windows.Forms.Button
        Me.lbtype = New System.Windows.Forms.Label
        Me.cbtype = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'tbamount
        '
        Me.tbamount.Location = New System.Drawing.Point(146, 147)
        Me.tbamount.Name = "tbamount"
        Me.tbamount.Size = New System.Drawing.Size(100, 20)
        Me.tbamount.TabIndex = 140
        '
        'lbamount
        '
        Me.lbamount.AutoSize = True
        Me.lbamount.Location = New System.Drawing.Point(56, 155)
        Me.lbamount.Name = "lbamount"
        Me.lbamount.Size = New System.Drawing.Size(72, 13)
        Me.lbamount.TabIndex = 139
        Me.lbamount.Text = "Amount (RM):"
        '
        'tbsalary
        '
        Me.tbsalary.Location = New System.Drawing.Point(146, 187)
        Me.tbsalary.Name = "tbsalary"
        Me.tbsalary.Size = New System.Drawing.Size(497, 20)
        Me.tbsalary.TabIndex = 137
        '
        'tbremarks
        '
        Me.tbremarks.Location = New System.Drawing.Point(146, 225)
        Me.tbremarks.Name = "tbremarks"
        Me.tbremarks.Size = New System.Drawing.Size(497, 20)
        Me.tbremarks.TabIndex = 132
        '
        'lbproject
        '
        Me.lbproject.AutoSize = True
        Me.lbproject.Location = New System.Drawing.Point(56, 190)
        Me.lbproject.Name = "lbproject"
        Me.lbproject.Size = New System.Drawing.Size(75, 13)
        Me.lbproject.TabIndex = 136
        Me.lbproject.Text = "Project/event:"
        '
        'lbremarks
        '
        Me.lbremarks.AutoSize = True
        Me.lbremarks.Location = New System.Drawing.Point(56, 228)
        Me.lbremarks.Name = "lbremarks"
        Me.lbremarks.Size = New System.Drawing.Size(52, 13)
        Me.lbremarks.TabIndex = 131
        Me.lbremarks.Text = "Remarks:"
        '
        'btapply211
        '
        Me.btapply211.Location = New System.Drawing.Point(565, 339)
        Me.btapply211.Name = "btapply211"
        Me.btapply211.Size = New System.Drawing.Size(78, 23)
        Me.btapply211.TabIndex = 129
        Me.btapply211.Text = "Apply"
        Me.btapply211.UseVisualStyleBackColor = True
        '
        'lbtype
        '
        Me.lbtype.AutoSize = True
        Me.lbtype.Location = New System.Drawing.Point(56, 118)
        Me.lbtype.Name = "lbtype"
        Me.lbtype.Size = New System.Drawing.Size(78, 13)
        Me.lbtype.TabIndex = 128
        Me.lbtype.Text = "Type of claims:"
        '
        'cbtype
        '
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.Items.AddRange(New Object() {"Accomodations", "Transportations (Include fuel and toll fees)"})
        Me.cbtype.Location = New System.Drawing.Point(148, 115)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(497, 21)
        Me.cbtype.TabIndex = 141
        '
        'Claims_Application_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 512)
        Me.Controls.Add(Me.cbtype)
        Me.Controls.Add(Me.tbamount)
        Me.Controls.Add(Me.lbamount)
        Me.Controls.Add(Me.tbsalary)
        Me.Controls.Add(Me.tbremarks)
        Me.Controls.Add(Me.lbproject)
        Me.Controls.Add(Me.lbremarks)
        Me.Controls.Add(Me.btapply211)
        Me.Controls.Add(Me.lbtype)
        Me.Name = "Claims_Application_Form"
        Me.Text = "Claims_Application_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbamount As System.Windows.Forms.TextBox
    Friend WithEvents lbamount As System.Windows.Forms.Label
    Friend WithEvents tbsalary As System.Windows.Forms.TextBox
    Friend WithEvents tbremarks As System.Windows.Forms.TextBox
    Friend WithEvents lbproject As System.Windows.Forms.Label
    Friend WithEvents lbremarks As System.Windows.Forms.Label
    Friend WithEvents btapply211 As System.Windows.Forms.Button
    Friend WithEvents lbtype As System.Windows.Forms.Label
    Friend WithEvents cbtype As System.Windows.Forms.ComboBox
End Class
