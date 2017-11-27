<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainingManagement
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.btn_trAddNew102 = New System.Windows.Forms.Button
        Me.btn_trdelete102 = New System.Windows.Forms.Button
        Me.btn_tredit102 = New System.Windows.Forms.Button
        Me.btn_trdetails102 = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tab_training = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cbx_feedback101 = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dataGrid_Feedback = New System.Windows.Forms.DataGridView
        Me.HRDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRDataSet = New WindowsApplication1.HRDataSet
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tab_training.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dataGrid_Feedback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.Border
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 23
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(711, 650)
        Me.DataGridView2.TabIndex = 11
        '
        'btn_trAddNew102
        '
        Me.btn_trAddNew102.Location = New System.Drawing.Point(3, 3)
        Me.btn_trAddNew102.Name = "btn_trAddNew102"
        Me.btn_trAddNew102.Size = New System.Drawing.Size(75, 27)
        Me.btn_trAddNew102.TabIndex = 10
        Me.btn_trAddNew102.Text = "Add New +"
        Me.btn_trAddNew102.UseVisualStyleBackColor = True
        '
        'btn_trdelete102
        '
        Me.btn_trdelete102.Location = New System.Drawing.Point(633, 3)
        Me.btn_trdelete102.Name = "btn_trdelete102"
        Me.btn_trdelete102.Size = New System.Drawing.Size(75, 21)
        Me.btn_trdelete102.TabIndex = 14
        Me.btn_trdelete102.Text = "Delete"
        Me.btn_trdelete102.UseVisualStyleBackColor = True
        '
        'btn_tredit102
        '
        Me.btn_tredit102.Location = New System.Drawing.Point(552, 3)
        Me.btn_tredit102.Name = "btn_tredit102"
        Me.btn_tredit102.Size = New System.Drawing.Size(75, 21)
        Me.btn_tredit102.TabIndex = 13
        Me.btn_tredit102.Text = "Edit"
        Me.btn_tredit102.UseVisualStyleBackColor = True
        '
        'btn_trdetails102
        '
        Me.btn_trdetails102.Location = New System.Drawing.Point(471, 3)
        Me.btn_trdetails102.Name = "btn_trdetails102"
        Me.btn_trdetails102.Size = New System.Drawing.Size(75, 21)
        Me.btn_trdetails102.TabIndex = 12
        Me.btn_trdetails102.Text = "Details"
        Me.btn_trdetails102.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_training)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(725, 700)
        Me.TabControl1.TabIndex = 15
        '
        'tab_training
        '
        Me.tab_training.Controls.Add(Me.Panel3)
        Me.tab_training.Controls.Add(Me.Panel4)
        Me.tab_training.Location = New System.Drawing.Point(4, 22)
        Me.tab_training.Name = "tab_training"
        Me.tab_training.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_training.Size = New System.Drawing.Size(717, 674)
        Me.tab_training.TabIndex = 0
        Me.tab_training.Text = "TrainingList"
        Me.tab_training.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(711, 650)
        Me.Panel3.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_trAddNew102)
        Me.Panel4.Controls.Add(Me.btn_trdetails102)
        Me.Panel4.Controls.Add(Me.btn_tredit102)
        Me.Panel4.Controls.Add(Me.btn_trdelete102)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(711, 46)
        Me.Panel4.TabIndex = 16
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(717, 390)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Feedback"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbx_feedback101)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 46)
        Me.Panel1.TabIndex = 3
        '
        'cbx_feedback101
        '
        Me.cbx_feedback101.FormattingEnabled = True
        Me.cbx_feedback101.Location = New System.Drawing.Point(20, 12)
        Me.cbx_feedback101.Name = "cbx_feedback101"
        Me.cbx_feedback101.Size = New System.Drawing.Size(121, 20)
        Me.cbx_feedback101.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dataGrid_Feedback)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(711, 335)
        Me.Panel2.TabIndex = 2
        '
        'dataGrid_Feedback
        '
        Me.dataGrid_Feedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid_Feedback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGrid_Feedback.Location = New System.Drawing.Point(0, 0)
        Me.dataGrid_Feedback.Name = "dataGrid_Feedback"
        Me.dataGrid_Feedback.RowTemplate.Height = 23
        Me.dataGrid_Feedback.Size = New System.Drawing.Size(711, 335)
        Me.dataGrid_Feedback.TabIndex = 0
        '
        'HRDataSet
        '
        Me.HRDataSet.DataSetName = "HRDataSet"
        Me.HRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrainingManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "TrainingManagement"
        Me.Size = New System.Drawing.Size(725, 700)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_training.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dataGrid_Feedback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_trAddNew102 As System.Windows.Forms.Button
    Friend WithEvents btn_trdelete102 As System.Windows.Forms.Button
    Friend WithEvents btn_tredit102 As System.Windows.Forms.Button
    Friend WithEvents btn_trdetails102 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_training As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbx_feedback101 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dataGrid_Feedback As System.Windows.Forms.DataGridView
    Friend WithEvents HRDataSet As WindowsApplication1.HRDataSet
    Friend WithEvents HRDataSetBindingSource As System.Windows.Forms.BindingSource

End Class
