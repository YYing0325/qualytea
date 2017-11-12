<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lb_code105 = New System.Windows.Forms.Label
        Me.lb_course105 = New System.Windows.Forms.Label
        Me.lb_participantlist = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.txt_trCode105 = New System.Windows.Forms.TextBox
        Me.txt_trCourse = New System.Windows.Forms.TextBox
        Me.lb_trStaff105 = New System.Windows.Forms.Label
        Me.lb_trEmployeename105 = New System.Windows.Forms.Label
        Me.lb_trDepartment105 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_code105
        '
        Me.lb_code105.AutoSize = True
        Me.lb_code105.Location = New System.Drawing.Point(32, 50)
        Me.lb_code105.Name = "lb_code105"
        Me.lb_code105.Size = New System.Drawing.Size(35, 13)
        Me.lb_code105.TabIndex = 0
        Me.lb_code105.Text = "Code:"
        '
        'lb_course105
        '
        Me.lb_course105.AutoSize = True
        Me.lb_course105.Location = New System.Drawing.Point(32, 77)
        Me.lb_course105.Name = "lb_course105"
        Me.lb_course105.Size = New System.Drawing.Size(43, 13)
        Me.lb_course105.TabIndex = 1
        Me.lb_course105.Text = "Course:"
        '
        'lb_participantlist
        '
        Me.lb_participantlist.AutoSize = True
        Me.lb_participantlist.Location = New System.Drawing.Point(35, 140)
        Me.lb_participantlist.Name = "lb_participantlist"
        Me.lb_participantlist.Size = New System.Drawing.Size(72, 13)
        Me.lb_participantlist.TabIndex = 2
        Me.lb_participantlist.Text = "Participate list"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.82482!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.17518!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lb_trStaff105, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_trEmployeename105, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_trDepartment105, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(38, 177)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(450, 100)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'txt_trCode105
        '
        Me.txt_trCode105.Location = New System.Drawing.Point(127, 43)
        Me.txt_trCode105.Name = "txt_trCode105"
        Me.txt_trCode105.Size = New System.Drawing.Size(100, 20)
        Me.txt_trCode105.TabIndex = 4
        '
        'txt_trCourse
        '
        Me.txt_trCourse.Location = New System.Drawing.Point(127, 70)
        Me.txt_trCourse.Name = "txt_trCourse"
        Me.txt_trCourse.Size = New System.Drawing.Size(100, 20)
        Me.txt_trCourse.TabIndex = 5
        '
        'lb_trStaff105
        '
        Me.lb_trStaff105.AutoSize = True
        Me.lb_trStaff105.Location = New System.Drawing.Point(3, 0)
        Me.lb_trStaff105.Name = "lb_trStaff105"
        Me.lb_trStaff105.Size = New System.Drawing.Size(67, 13)
        Me.lb_trStaff105.TabIndex = 0
        Me.lb_trStaff105.Text = "Employee ID"
        '
        'lb_trEmployeename105
        '
        Me.lb_trEmployeename105.AutoSize = True
        Me.lb_trEmployeename105.Location = New System.Drawing.Point(156, 0)
        Me.lb_trEmployeename105.Name = "lb_trEmployeename105"
        Me.lb_trEmployeename105.Size = New System.Drawing.Size(84, 13)
        Me.lb_trEmployeename105.TabIndex = 1
        Me.lb_trEmployeename105.Text = "Employee Name"
        '
        'lb_trDepartment105
        '
        Me.lb_trDepartment105.AutoSize = True
        Me.lb_trDepartment105.Location = New System.Drawing.Point(299, 0)
        Me.lb_trDepartment105.Name = "lb_trDepartment105"
        Me.lb_trDepartment105.Size = New System.Drawing.Size(62, 13)
        Me.lb_trDepartment105.TabIndex = 2
        Me.lb_trDepartment105.Text = "Department"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 371)
        Me.Controls.Add(Me.txt_trCourse)
        Me.Controls.Add(Me.txt_trCode105)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lb_participantlist)
        Me.Controls.Add(Me.lb_course105)
        Me.Controls.Add(Me.lb_code105)
        Me.Name = "Form4"
        Me.Text = "Details"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_code105 As System.Windows.Forms.Label
    Friend WithEvents lb_course105 As System.Windows.Forms.Label
    Friend WithEvents lb_participantlist As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_trCode105 As System.Windows.Forms.TextBox
    Friend WithEvents txt_trCourse As System.Windows.Forms.TextBox
    Friend WithEvents lb_trStaff105 As System.Windows.Forms.Label
    Friend WithEvents lb_trEmployeename105 As System.Windows.Forms.Label
    Friend WithEvents lb_trDepartment105 As System.Windows.Forms.Label
End Class
