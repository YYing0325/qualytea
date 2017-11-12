<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class My_Training
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lb_trNewtraining = New System.Windows.Forms.Label
        Me.data_grid_TrComplete = New System.Windows.Forms.DataGridView
        Me.data_grid_TrProgress = New System.Windows.Forms.DataGridView
        Me.data_grid_TrNewTraining = New System.Windows.Forms.DataGridView
        Me.lb_trCompletedTraining = New System.Windows.Forms.Label
        Me.lb_trInProgress = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btn_trdelete102 = New System.Windows.Forms.Button
        Me.btn_tredit102 = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.btn_trdetails102 = New System.Windows.Forms.Button
        Me.btn_trAddNew102 = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lb_trCourse104 = New System.Windows.Forms.Label
        Me.lb_tremployee104 = New System.Windows.Forms.Label
        Me.lb_q1104 = New System.Windows.Forms.Label
        Me.lb_q2104 = New System.Windows.Forms.Label
        Me.lb_q3104 = New System.Windows.Forms.Label
        Me.lb_q4104 = New System.Windows.Forms.Label
        Me.lb_q5104 = New System.Windows.Forms.Label
        Me.lb_trRecommend104 = New System.Windows.Forms.Label
        Me.lb_trNo104 = New System.Windows.Forms.Label
        Me.TrainingsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRDataSet = New WindowsApplication1.HRDataSet
        Me.TrainingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrainingsTableAdapter = New WindowsApplication1.HRDataSetTableAdapters.trainingsTableAdapter
        Me.TableAdapterManager1 = New WindowsApplication1.HRDataSetTableAdapters.TableAdapterManager
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.lbno101 = New System.Windows.Forms.Label
        Me.lbcourse104 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.data_grid_TrComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_grid_TrProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_grid_TrNewTraining, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TrainingsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrainingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(618, 410)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(119, 62)
        Me.DataGridView1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(903, 608)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lb_trNewtraining)
        Me.TabPage1.Controls.Add(Me.data_grid_TrComplete)
        Me.TabPage1.Controls.Add(Me.data_grid_TrProgress)
        Me.TabPage1.Controls.Add(Me.data_grid_TrNewTraining)
        Me.TabPage1.Controls.Add(Me.lb_trCompletedTraining)
        Me.TabPage1.Controls.Add(Me.lb_trInProgress)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(895, 582)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "My Training"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lb_trNewtraining
        '
        Me.lb_trNewtraining.AutoSize = True
        Me.lb_trNewtraining.Location = New System.Drawing.Point(31, 15)
        Me.lb_trNewtraining.Name = "lb_trNewtraining"
        Me.lb_trNewtraining.Size = New System.Drawing.Size(70, 13)
        Me.lb_trNewtraining.TabIndex = 6
        Me.lb_trNewtraining.Text = "New Training"
        '
        'data_grid_TrComplete
        '
        Me.data_grid_TrComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_TrComplete.Location = New System.Drawing.Point(31, 425)
        Me.data_grid_TrComplete.Name = "data_grid_TrComplete"
        Me.data_grid_TrComplete.Size = New System.Drawing.Size(702, 151)
        Me.data_grid_TrComplete.TabIndex = 5
        '
        'data_grid_TrProgress
        '
        Me.data_grid_TrProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_TrProgress.Location = New System.Drawing.Point(31, 231)
        Me.data_grid_TrProgress.Name = "data_grid_TrProgress"
        Me.data_grid_TrProgress.Size = New System.Drawing.Size(702, 151)
        Me.data_grid_TrProgress.TabIndex = 4
        '
        'data_grid_TrNewTraining
        '
        Me.data_grid_TrNewTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_TrNewTraining.Location = New System.Drawing.Point(31, 34)
        Me.data_grid_TrNewTraining.Name = "data_grid_TrNewTraining"
        Me.data_grid_TrNewTraining.Size = New System.Drawing.Size(702, 151)
        Me.data_grid_TrNewTraining.TabIndex = 3
        '
        'lb_trCompletedTraining
        '
        Me.lb_trCompletedTraining.AutoSize = True
        Me.lb_trCompletedTraining.Location = New System.Drawing.Point(28, 399)
        Me.lb_trCompletedTraining.Name = "lb_trCompletedTraining"
        Me.lb_trCompletedTraining.Size = New System.Drawing.Size(98, 13)
        Me.lb_trCompletedTraining.TabIndex = 2
        Me.lb_trCompletedTraining.Text = "Completed Training"
        '
        'lb_trInProgress
        '
        Me.lb_trInProgress.AutoSize = True
        Me.lb_trInProgress.Location = New System.Drawing.Point(28, 206)
        Me.lb_trInProgress.Name = "lb_trInProgress"
        Me.lb_trInProgress.Size = New System.Drawing.Size(60, 13)
        Me.lb_trInProgress.TabIndex = 1
        Me.lb_trInProgress.Text = "In Progress"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Training"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_trdelete102)
        Me.TabPage2.Controls.Add(Me.btn_tredit102)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.btn_trdetails102)
        Me.TabPage2.Controls.Add(Me.btn_trAddNew102)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(895, 582)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Training Management"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_trdelete102
        '
        Me.btn_trdelete102.Location = New System.Drawing.Point(800, 156)
        Me.btn_trdelete102.Name = "btn_trdelete102"
        Me.btn_trdelete102.Size = New System.Drawing.Size(75, 23)
        Me.btn_trdelete102.TabIndex = 11
        Me.btn_trdelete102.Text = "Delete"
        Me.btn_trdelete102.UseVisualStyleBackColor = True
        '
        'btn_tredit102
        '
        Me.btn_tredit102.Location = New System.Drawing.Point(732, 156)
        Me.btn_tredit102.Name = "btn_tredit102"
        Me.btn_tredit102.Size = New System.Drawing.Size(75, 23)
        Me.btn_tredit102.TabIndex = 10
        Me.btn_tredit102.Text = "Edit"
        Me.btn_tredit102.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(20, 57)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(702, 151)
        Me.DataGridView2.TabIndex = 9
        '
        'btn_trdetails102
        '
        Me.btn_trdetails102.Location = New System.Drawing.Point(728, 91)
        Me.btn_trdetails102.Name = "btn_trdetails102"
        Me.btn_trdetails102.Size = New System.Drawing.Size(75, 23)
        Me.btn_trdetails102.TabIndex = 8
        Me.btn_trdetails102.Text = "Details"
        Me.btn_trdetails102.UseVisualStyleBackColor = True
        '
        'btn_trAddNew102
        '
        Me.btn_trAddNew102.Location = New System.Drawing.Point(20, 22)
        Me.btn_trAddNew102.Name = "btn_trAddNew102"
        Me.btn_trAddNew102.Size = New System.Drawing.Size(75, 29)
        Me.btn_trAddNew102.TabIndex = 7
        Me.btn_trAddNew102.Text = "Add New +"
        Me.btn_trAddNew102.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(895, 582)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Feedback"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel1.Controls.Add(Me.lb_tremployee104, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_q1104, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_q2104, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_q3104, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_q4104, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_q5104, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_trRecommend104, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lb_trNo104, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(32, 75)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(801, 100)
        Me.TableLayoutPanel1.TabIndex = 129
        '
        'lb_trCourse104
        '
        Me.lb_trCourse104.AutoSize = True
        Me.lb_trCourse104.Location = New System.Drawing.Point(40, 0)
        Me.lb_trCourse104.Name = "lb_trCourse104"
        Me.lb_trCourse104.Size = New System.Drawing.Size(40, 13)
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
        'lb_q1104
        '
        Me.lb_q1104.AutoSize = True
        Me.lb_q1104.Location = New System.Drawing.Point(268, 0)
        Me.lb_q1104.Name = "lb_q1104"
        Me.lb_q1104.Size = New System.Drawing.Size(21, 13)
        Me.lb_q1104.TabIndex = 3
        Me.lb_q1104.Text = "Q1"
        '
        'lb_q2104
        '
        Me.lb_q2104.AutoSize = True
        Me.lb_q2104.Location = New System.Drawing.Point(311, 0)
        Me.lb_q2104.Name = "lb_q2104"
        Me.lb_q2104.Size = New System.Drawing.Size(21, 13)
        Me.lb_q2104.TabIndex = 4
        Me.lb_q2104.Text = "Q2"
        '
        'lb_q3104
        '
        Me.lb_q3104.AutoSize = True
        Me.lb_q3104.Location = New System.Drawing.Point(353, 0)
        Me.lb_q3104.Name = "lb_q3104"
        Me.lb_q3104.Size = New System.Drawing.Size(21, 13)
        Me.lb_q3104.TabIndex = 5
        Me.lb_q3104.Text = "Q3"
        '
        'lb_q4104
        '
        Me.lb_q4104.AutoSize = True
        Me.lb_q4104.Location = New System.Drawing.Point(400, 0)
        Me.lb_q4104.Name = "lb_q4104"
        Me.lb_q4104.Size = New System.Drawing.Size(21, 13)
        Me.lb_q4104.TabIndex = 6
        Me.lb_q4104.Text = "Q4"
        '
        'lb_q5104
        '
        Me.lb_q5104.AutoSize = True
        Me.lb_q5104.Location = New System.Drawing.Point(444, 0)
        Me.lb_q5104.Name = "lb_q5104"
        Me.lb_q5104.Size = New System.Drawing.Size(21, 13)
        Me.lb_q5104.TabIndex = 7
        Me.lb_q5104.Text = "Q5"
        '
        'lb_trRecommend104
        '
        Me.lb_trRecommend104.AutoSize = True
        Me.lb_trRecommend104.Location = New System.Drawing.Point(488, 0)
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
        Me.lb_trNo104.Size = New System.Drawing.Size(24, 13)
        Me.lb_trNo104.TabIndex = 0
        Me.lb_trNo104.Text = "No."
        '
        'TrainingsBindingSource1
        '
        Me.TrainingsBindingSource1.DataMember = "trainings"
        Me.TrainingsBindingSource1.DataSource = Me.HRDataSetBindingSource
        '
        'HRDataSetBindingSource
        '
        Me.HRDataSetBindingSource.DataSource = Me.HRDataSet
        Me.HRDataSetBindingSource.Position = 0
        '
        'HRDataSet
        '
        Me.HRDataSet.DataSetName = "HRDataSet"
        Me.HRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrainingsBindingSource
        '
        Me.TrainingsBindingSource.DataMember = "trainings"
        Me.TrainingsBindingSource.DataSource = Me.HRDataSetBindingSource
        '
        'TrainingsTableAdapter
        '
        Me.TrainingsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.locationsTableAdapter = Nothing
        Me.TableAdapterManager1.trainingsTableAdapter = Me.TrainingsTableAdapter
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.HRDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 9
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.68217!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.31783!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lbno101, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'lbno101
        '
        Me.lbno101.AutoSize = True
        Me.lbno101.Location = New System.Drawing.Point(3, 0)
        Me.lbno101.Name = "lbno101"
        Me.lbno101.Size = New System.Drawing.Size(1, 13)
        Me.lbno101.TabIndex = 0
        Me.lbno101.Text = "No."
        '
        'lbcourse104
        '
        Me.lbcourse104.AutoSize = True
        Me.lbcourse104.Location = New System.Drawing.Point(40, 0)
        Me.lbcourse104.Name = "lbcourse104"
        Me.lbcourse104.Size = New System.Drawing.Size(40, 13)
        Me.lbcourse104.TabIndex = 1
        Me.lbcourse104.Text = "Course"
        '
        'My_Training
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "My_Training"
        Me.Size = New System.Drawing.Size(903, 608)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.data_grid_TrComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_grid_TrProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_grid_TrNewTraining, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TrainingsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrainingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents data_grid_TrNewTraining As System.Windows.Forms.DataGridView
    Friend WithEvents lb_trCompletedTraining As System.Windows.Forms.Label
    Friend WithEvents lb_trInProgress As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents data_grid_TrProgress As System.Windows.Forms.DataGridView
    Friend WithEvents data_grid_TrComplete As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_trdetails102 As System.Windows.Forms.Button
    Friend WithEvents btn_trAddNew102 As System.Windows.Forms.Button
    Friend WithEvents btn_trdelete102 As System.Windows.Forms.Button
    Friend WithEvents btn_tredit102 As System.Windows.Forms.Button
    Friend WithEvents TrainingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HRDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HRDataSet As WindowsApplication1.HRDataSet
    Friend WithEvents TrainingsTableAdapter As WindowsApplication1.HRDataSetTableAdapters.trainingsTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.HRDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TrainingsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbno101 As System.Windows.Forms.Label
    Friend WithEvents lbcourse104 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lb_trCourse104 As System.Windows.Forms.Label
    Friend WithEvents lb_tremployee104 As System.Windows.Forms.Label
    Friend WithEvents lb_q1104 As System.Windows.Forms.Label
    Friend WithEvents lb_q2104 As System.Windows.Forms.Label
    Friend WithEvents lb_q3104 As System.Windows.Forms.Label
    Friend WithEvents lb_q4104 As System.Windows.Forms.Label
    Friend WithEvents lb_q5104 As System.Windows.Forms.Label
    Friend WithEvents lb_trRecommend104 As System.Windows.Forms.Label
    Friend WithEvents lb_trNo104 As System.Windows.Forms.Label
    Friend WithEvents lb_trNewtraining As System.Windows.Forms.Label

End Class
