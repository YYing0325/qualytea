<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyTraining
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.data_grid_TrComplete = New System.Windows.Forms.DataGridView
        Me.lb_trCompletedTraining = New System.Windows.Forms.Label
        Me.lb_trNewtraining = New System.Windows.Forms.Label
        Me.data_grid_TrProgress = New System.Windows.Forms.DataGridView
        Me.data_grid_TrNewTraining = New System.Windows.Forms.DataGridView
        Me.lb_trInProgress = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lb_q1104 = New System.Windows.Forms.Label
        Me.lb_q2104 = New System.Windows.Forms.Label
        Me.lb_q3104 = New System.Windows.Forms.Label
        Me.lb_q4104 = New System.Windows.Forms.Label
        Me.lb_q5104 = New System.Windows.Forms.Label
        Me.lb_trRecommend104 = New System.Windows.Forms.Label
        Me.lb_trNo104 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lb_trCourse104 = New System.Windows.Forms.Label
        Me.lb_tremployee104 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.data_grid_TrComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_grid_TrProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_grid_TrNewTraining, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(711, 631)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.data_grid_TrComplete)
        Me.TabPage1.Controls.Add(Me.lb_trCompletedTraining)
        Me.TabPage1.Controls.Add(Me.lb_trNewtraining)
        Me.TabPage1.Controls.Add(Me.data_grid_TrProgress)
        Me.TabPage1.Controls.Add(Me.data_grid_TrNewTraining)
        Me.TabPage1.Controls.Add(Me.lb_trInProgress)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(703, 605)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "My Training"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'data_grid_TrComplete
        '
        Me.data_grid_TrComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_TrComplete.Location = New System.Drawing.Point(6, 429)
        Me.data_grid_TrComplete.Name = "data_grid_TrComplete"
        Me.data_grid_TrComplete.Size = New System.Drawing.Size(675, 151)
        Me.data_grid_TrComplete.TabIndex = 13
        '
        'lb_trCompletedTraining
        '
        Me.lb_trCompletedTraining.AutoSize = True
        Me.lb_trCompletedTraining.Location = New System.Drawing.Point(3, 403)
        Me.lb_trCompletedTraining.Name = "lb_trCompletedTraining"
        Me.lb_trCompletedTraining.Size = New System.Drawing.Size(98, 13)
        Me.lb_trCompletedTraining.TabIndex = 12
        Me.lb_trCompletedTraining.Text = "Completed Training"
        '
        'lb_trNewtraining
        '
        Me.lb_trNewtraining.AutoSize = True
        Me.lb_trNewtraining.Location = New System.Drawing.Point(6, 17)
        Me.lb_trNewtraining.Name = "lb_trNewtraining"
        Me.lb_trNewtraining.Size = New System.Drawing.Size(70, 13)
        Me.lb_trNewtraining.TabIndex = 11
        Me.lb_trNewtraining.Text = "New Training"
        '
        'data_grid_TrProgress
        '
        Me.data_grid_TrProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_TrProgress.Location = New System.Drawing.Point(6, 233)
        Me.data_grid_TrProgress.Name = "data_grid_TrProgress"
        Me.data_grid_TrProgress.Size = New System.Drawing.Size(675, 151)
        Me.data_grid_TrProgress.TabIndex = 10
        '
        'data_grid_TrNewTraining
        '
        Me.data_grid_TrNewTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_TrNewTraining.Location = New System.Drawing.Point(6, 36)
        Me.data_grid_TrNewTraining.Name = "data_grid_TrNewTraining"
        Me.data_grid_TrNewTraining.Size = New System.Drawing.Size(675, 151)
        Me.data_grid_TrNewTraining.TabIndex = 9
        '
        'lb_trInProgress
        '
        Me.lb_trInProgress.AutoSize = True
        Me.lb_trInProgress.Location = New System.Drawing.Point(3, 208)
        Me.lb_trInProgress.Name = "lb_trInProgress"
        Me.lb_trInProgress.Size = New System.Drawing.Size(60, 13)
        Me.lb_trInProgress.TabIndex = 8
        Me.lb_trInProgress.Text = "In Progress"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "New Training"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(822, 602)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Feedback"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 9
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.68217!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.31783!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 317.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lb_q1104, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lb_q2104, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lb_q3104, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lb_q4104, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lb_q5104, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lb_trRecommend104, 8, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lb_trNo104, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 46)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(801, 69)
        Me.TableLayoutPanel2.TabIndex = 130
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee"
        '
        'lb_q1104
        '
        Me.lb_q1104.AutoSize = True
        Me.lb_q1104.Location = New System.Drawing.Point(240, 0)
        Me.lb_q1104.Name = "lb_q1104"
        Me.lb_q1104.Size = New System.Drawing.Size(21, 13)
        Me.lb_q1104.TabIndex = 3
        Me.lb_q1104.Text = "Q1"
        '
        'lb_q2104
        '
        Me.lb_q2104.AutoSize = True
        Me.lb_q2104.Location = New System.Drawing.Point(285, 0)
        Me.lb_q2104.Name = "lb_q2104"
        Me.lb_q2104.Size = New System.Drawing.Size(21, 13)
        Me.lb_q2104.TabIndex = 4
        Me.lb_q2104.Text = "Q2"
        '
        'lb_q3104
        '
        Me.lb_q3104.AutoSize = True
        Me.lb_q3104.Location = New System.Drawing.Point(334, 0)
        Me.lb_q3104.Name = "lb_q3104"
        Me.lb_q3104.Size = New System.Drawing.Size(21, 13)
        Me.lb_q3104.TabIndex = 5
        Me.lb_q3104.Text = "Q3"
        '
        'lb_q4104
        '
        Me.lb_q4104.AutoSize = True
        Me.lb_q4104.Location = New System.Drawing.Point(382, 0)
        Me.lb_q4104.Name = "lb_q4104"
        Me.lb_q4104.Size = New System.Drawing.Size(21, 13)
        Me.lb_q4104.TabIndex = 6
        Me.lb_q4104.Text = "Q4"
        '
        'lb_q5104
        '
        Me.lb_q5104.AutoSize = True
        Me.lb_q5104.Location = New System.Drawing.Point(434, 0)
        Me.lb_q5104.Name = "lb_q5104"
        Me.lb_q5104.Size = New System.Drawing.Size(21, 13)
        Me.lb_q5104.TabIndex = 7
        Me.lb_q5104.Text = "Q5"
        '
        'lb_trRecommend104
        '
        Me.lb_trRecommend104.AutoSize = True
        Me.lb_trRecommend104.Location = New System.Drawing.Point(486, 0)
        Me.lb_trRecommend104.Name = "lb_trRecommend104"
        Me.lb_trRecommend104.Size = New System.Drawing.Size(90, 13)
        Me.lb_trRecommend104.TabIndex = 8
        Me.lb_trRecommend104.Text = "Recommendation"
        '
        'lb_trNo104
        '
        Me.lb_trNo104.AutoSize = True
        Me.lb_trNo104.Location = New System.Drawing.Point(3, 0)
        Me.lb_trNo104.Name = "lb_trNo104"
        Me.lb_trNo104.Size = New System.Drawing.Size(21, 26)
        Me.lb_trNo104.TabIndex = 0
        Me.lb_trNo104.Text = "No."
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.68217!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.31783!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lb_trCourse104, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lb_trCourse104
        '
        Me.lb_trCourse104.AutoSize = True
        Me.lb_trCourse104.Location = New System.Drawing.Point(-132, 0)
        Me.lb_trCourse104.Name = "lb_trCourse104"
        Me.lb_trCourse104.Size = New System.Drawing.Size(1, 13)
        Me.lb_trCourse104.TabIndex = 1
        Me.lb_trCourse104.Text = "Course"
        '
        'lb_tremployee104
        '
        Me.lb_tremployee104.AutoSize = True
        Me.lb_tremployee104.Location = New System.Drawing.Point(132, 0)
        Me.lb_tremployee104.Name = "lb_tremployee104"
        Me.lb_tremployee104.Size = New System.Drawing.Size(53, 13)
        Me.lb_tremployee104.TabIndex = 2
        Me.lb_tremployee104.Text = "Employee"
        '
        'MyTraining
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MyTraining"
        Me.Size = New System.Drawing.Size(711, 631)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.data_grid_TrComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_grid_TrProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_grid_TrNewTraining, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lb_trNewtraining As System.Windows.Forms.Label
    Friend WithEvents data_grid_TrProgress As System.Windows.Forms.DataGridView
    Friend WithEvents data_grid_TrNewTraining As System.Windows.Forms.DataGridView
    Friend WithEvents lb_trInProgress As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents data_grid_TrComplete As System.Windows.Forms.DataGridView
    Friend WithEvents lb_trCompletedTraining As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lb_trCourse104 As System.Windows.Forms.Label
    Friend WithEvents lb_tremployee104 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_q1104 As System.Windows.Forms.Label
    Friend WithEvents lb_q2104 As System.Windows.Forms.Label
    Friend WithEvents lb_q3104 As System.Windows.Forms.Label
    Friend WithEvents lb_q4104 As System.Windows.Forms.Label
    Friend WithEvents lb_q5104 As System.Windows.Forms.Label
    Friend WithEvents lb_trRecommend104 As System.Windows.Forms.Label
    Friend WithEvents lb_trNo104 As System.Windows.Forms.Label

End Class
