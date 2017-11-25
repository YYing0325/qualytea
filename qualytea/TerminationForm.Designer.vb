<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TerminationForm
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
        Me.data_time_picker_termination = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_confirm = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'data_time_picker_termination
        '
        Me.data_time_picker_termination.Location = New System.Drawing.Point(185, 56)
        Me.data_time_picker_termination.Name = "data_time_picker_termination"
        Me.data_time_picker_termination.Size = New System.Drawing.Size(200, 21)
        Me.data_time_picker_termination.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Termination Date"
        '
        'btn_confirm
        '
        Me.btn_confirm.Location = New System.Drawing.Point(31, 139)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(354, 26)
        Me.btn_confirm.TabIndex = 2
        Me.btn_confirm.Text = "Confirm"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'TerminationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 194)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.data_time_picker_termination)
        Me.Name = "TerminationForm"
        Me.Text = "TerminationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data_time_picker_termination As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_confirm As System.Windows.Forms.Button
End Class
