<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PunchOut
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
        Me.tbNote = New System.Windows.Forms.TextBox
        Me.lblNote = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblPunchTimeIn = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.currentTime = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'tbNote
        '
        Me.tbNote.Location = New System.Drawing.Point(77, 117)
        Me.tbNote.Multiline = True
        Me.tbNote.Name = "tbNote"
        Me.tbNote.Size = New System.Drawing.Size(227, 122)
        Me.tbNote.TabIndex = 15
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(14, 131)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(29, 12)
        Me.lblNote.TabIndex = 13
        Me.lblNote.Text = "Note"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(14, 72)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(29, 12)
        Me.lblTime.TabIndex = 12
        Me.lblTime.Text = "Time"
        '
        'lblPunchTimeIn
        '
        Me.lblPunchTimeIn.AutoSize = True
        Me.lblPunchTimeIn.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPunchTimeIn.Location = New System.Drawing.Point(12, 9)
        Me.lblPunchTimeIn.Name = "lblPunchTimeIn"
        Me.lblPunchTimeIn.Size = New System.Drawing.Size(121, 20)
        Me.lblPunchTimeIn.TabIndex = 11
        Me.lblPunchTimeIn.Text = "Punch Time-Out"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(229, 269)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.Location = New System.Drawing.Point(148, 269)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'currentTime
        '
        Me.currentTime.AutoSize = True
        Me.currentTime.Location = New System.Drawing.Point(77, 71)
        Me.currentTime.Name = "currentTime"
        Me.currentTime.Size = New System.Drawing.Size(77, 12)
        Me.currentTime.TabIndex = 18
        Me.currentTime.Text = "Current Time"
        '
        'PunchOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 299)
        Me.Controls.Add(Me.currentTime)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.tbNote)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblPunchTimeIn)
        Me.Name = "PunchOut"
        Me.Text = "Punch Out"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbNote As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblPunchTimeIn As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents currentTime As System.Windows.Forms.Label
End Class
