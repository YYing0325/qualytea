<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voucher_redeem_v2
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
        Me.lbtotalrewardpoint1 = New System.Windows.Forms.Label
        Me.bt_clear = New System.Windows.Forms.Button
        Me.btredeem1 = New System.Windows.Forms.Button
        Me.lb_available_point = New System.Windows.Forms.Label
        Me.lbcongratulation1 = New System.Windows.Forms.Label
        Me.lb_voucher_code = New System.Windows.Forms.Label
        Me.cb_voucher_id = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'lbtotalrewardpoint1
        '
        Me.lbtotalrewardpoint1.AutoSize = True
        Me.lbtotalrewardpoint1.Location = New System.Drawing.Point(21, 20)
        Me.lbtotalrewardpoint1.Name = "lbtotalrewardpoint1"
        Me.lbtotalrewardpoint1.Size = New System.Drawing.Size(123, 13)
        Me.lbtotalrewardpoint1.TabIndex = 55
        Me.lbtotalrewardpoint1.Text = "Available Reward Point :"
        '
        'bt_clear
        '
        Me.bt_clear.Location = New System.Drawing.Point(498, 344)
        Me.bt_clear.Name = "bt_clear"
        Me.bt_clear.Size = New System.Drawing.Size(75, 23)
        Me.bt_clear.TabIndex = 54
        Me.bt_clear.Text = "Clear"
        Me.bt_clear.UseVisualStyleBackColor = True
        '
        'btredeem1
        '
        Me.btredeem1.Location = New System.Drawing.Point(394, 344)
        Me.btredeem1.Name = "btredeem1"
        Me.btredeem1.Size = New System.Drawing.Size(75, 23)
        Me.btredeem1.TabIndex = 53
        Me.btredeem1.Text = "Redeem"
        Me.btredeem1.UseVisualStyleBackColor = True
        '
        'lb_available_point
        '
        Me.lb_available_point.AutoSize = True
        Me.lb_available_point.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_available_point.Location = New System.Drawing.Point(150, 20)
        Me.lb_available_point.Name = "lb_available_point"
        Me.lb_available_point.Size = New System.Drawing.Size(19, 13)
        Me.lb_available_point.TabIndex = 59
        Me.lb_available_point.Text = "xx"
        '
        'lbcongratulation1
        '
        Me.lbcongratulation1.AutoSize = True
        Me.lbcongratulation1.Location = New System.Drawing.Point(22, 76)
        Me.lbcongratulation1.Name = "lbcongratulation1"
        Me.lbcongratulation1.Size = New System.Drawing.Size(575, 13)
        Me.lbcongratulation1.TabIndex = 56
        Me.lbcongratulation1.Text = "Congratulation! You are elegible to redeem the following cash voucher by using th" & _
            "e reward point that you have collected."
        '
        'lb_voucher_code
        '
        Me.lb_voucher_code.AutoSize = True
        Me.lb_voucher_code.Location = New System.Drawing.Point(21, 140)
        Me.lb_voucher_code.Name = "lb_voucher_code"
        Me.lb_voucher_code.Size = New System.Drawing.Size(96, 13)
        Me.lb_voucher_code.TabIndex = 60
        Me.lb_voucher_code.Text = "Available Voucher:"
        '
        'cb_voucher_id
        '
        Me.cb_voucher_id.FormattingEnabled = True
        Me.cb_voucher_id.Location = New System.Drawing.Point(153, 137)
        Me.cb_voucher_id.Name = "cb_voucher_id"
        Me.cb_voucher_id.Size = New System.Drawing.Size(121, 21)
        Me.cb_voucher_id.TabIndex = 61
        '
        'voucher_redeem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cb_voucher_id)
        Me.Controls.Add(Me.lb_voucher_code)
        Me.Controls.Add(Me.lbtotalrewardpoint1)
        Me.Controls.Add(Me.bt_clear)
        Me.Controls.Add(Me.btredeem1)
        Me.Controls.Add(Me.lb_available_point)
        Me.Controls.Add(Me.lbcongratulation1)
        Me.Name = "voucher_redeem"
        Me.Size = New System.Drawing.Size(622, 400)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbtotalrewardpoint1 As System.Windows.Forms.Label
    Friend WithEvents bt_clear As System.Windows.Forms.Button
    Friend WithEvents btredeem1 As System.Windows.Forms.Button
    Friend WithEvents lb_available_point As System.Windows.Forms.Label
    Friend WithEvents lbcongratulation1 As System.Windows.Forms.Label
    Friend WithEvents lb_voucher_code As System.Windows.Forms.Label
    Friend WithEvents cb_voucher_id As System.Windows.Forms.ComboBox

End Class
