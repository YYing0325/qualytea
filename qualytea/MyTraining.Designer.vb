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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lb_trCourse104 = New System.Windows.Forms.Label
        Me.lb_tremployee104 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.data_grid_TrComplete = New System.Windows.Forms.DataGridView
        Me.lb_trCompletedTraining = New System.Windows.Forms.Label
        Me.lb_trNewtraining = New System.Windows.Forms.Label
        Me.data_grid_TrProgress = New System.Windows.Forms.DataGridView
        Me.data_grid_TrNewTraining = New System.Windows.Forms.DataGridView
        Me.lb_trInProgress = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.My_training = New System.Windows.Forms.TabControl
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.data_grid_TrComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_grid_TrProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_grid_TrNewTraining, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.My_training.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TabPage1.Size = New System.Drawing.Size(763, 605)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "My Training"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'data_grid_TrComplete
        '
        Me.data_grid_TrComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_TrComplete.Location = New System.Drawing.Point(6, 429)
        Me.data_grid_TrComplete.Name = "data_grid_TrComplete"
        Me.data_grid_TrComplete.Size = New System.Drawing.Size(738, 151)
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
        Me.data_grid_TrProgress.Size = New System.Drawing.Size(738, 151)
        Me.data_grid_TrProgress.TabIndex = 10
        '
        'data_grid_TrNewTraining
        '
        Me.data_grid_TrNewTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_TrNewTraining.Location = New System.Drawing.Point(6, 36)
        Me.data_grid_TrNewTraining.Name = "data_grid_TrNewTraining"
        Me.data_grid_TrNewTraining.Size = New System.Drawing.Size(738, 151)
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
        'My_training
        '
        Me.My_training.Controls.Add(Me.TabPage1)
        Me.My_training.Dock = System.Windows.Forms.DockStyle.Fill
        Me.My_training.Location = New System.Drawing.Point(0, 0)
        Me.My_training.Name = "My_training"
        Me.My_training.SelectedIndex = 0
        Me.My_training.Size = New System.Drawing.Size(771, 631)
        Me.My_training.TabIndex = 14
        '
        'MyTraining
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.My_training)
        Me.Name = "MyTraining"
        Me.Size = New System.Drawing.Size(771, 631)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.data_grid_TrComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_grid_TrProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_grid_TrNewTraining, System.ComponentModel.ISupportInitialize).EndInit()
        Me.My_training.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lb_trCourse104 As System.Windows.Forms.Label
    Friend WithEvents lb_tremployee104 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents data_grid_TrComplete As System.Windows.Forms.DataGridView
    Friend WithEvents lb_trCompletedTraining As System.Windows.Forms.Label
    Friend WithEvents lb_trNewtraining As System.Windows.Forms.Label
    Friend WithEvents data_grid_TrProgress As System.Windows.Forms.DataGridView
    Friend WithEvents data_grid_TrNewTraining As System.Windows.Forms.DataGridView
    Friend WithEvents lb_trInProgress As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents My_training As System.Windows.Forms.TabControl

End Class
