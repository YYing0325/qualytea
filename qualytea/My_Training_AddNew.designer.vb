<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class My_Training_AddNew
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
        Me.components = New System.ComponentModel.Container
        Me.My_Training_Panel101 = New System.Windows.Forms.Panel
        Me.bt_Save101 = New System.Windows.Forms.Button
        Me.dtp_trDate101 = New System.Windows.Forms.DateTimePicker
        Me.txt_courseDesc101 = New System.Windows.Forms.TextBox
        Me.lb_trcoursedescription101 = New System.Windows.Forms.Label
        Me.bt_cancel101 = New System.Windows.Forms.Button
        Me.bt_submit101 = New System.Windows.Forms.Button
        Me.cbx_trVenue101 = New System.Windows.Forms.ComboBox
        Me.LocationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRDataSet = New WindowsApplication1.HRDataSet
        Me.txt_trTime101 = New System.Windows.Forms.TextBox
        Me.txt_trCourse101 = New System.Windows.Forms.TextBox
        Me.txt_trCode101 = New System.Windows.Forms.TextBox
        Me.lb_tr_date101 = New System.Windows.Forms.Label
        Me.lb_tr_requireddepartment101 = New System.Windows.Forms.Label
        Me.lb_tr_venue101 = New System.Windows.Forms.Label
        Me.lb_tr_time101 = New System.Windows.Forms.Label
        Me.lb_tr_course101 = New System.Windows.Forms.Label
        Me.lb_tr_code101 = New System.Windows.Forms.Label
        Me.tr_gpbx101 = New System.Windows.Forms.GroupBox
        Me.rb_All101 = New System.Windows.Forms.RadioButton
        Me.rb_trPurchasingDept101 = New System.Windows.Forms.RadioButton
        Me.rb_trSalesDept101 = New System.Windows.Forms.RadioButton
        Me.rb_trSafetyDept101 = New System.Windows.Forms.RadioButton
        Me.rb_trHRDept101 = New System.Windows.Forms.RadioButton
        Me.rb_trFinanceDept101 = New System.Windows.Forms.RadioButton
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationsTableAdapter = New WindowsApplication1.HRDataSetTableAdapters.locationsTableAdapter
        Me.JobsTableAdapter = New WindowsApplication1.HRDataSetTableAdapters.jobsTableAdapter
        Me.My_Training_Panel101.SuspendLayout()
        CType(Me.LocationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tr_gpbx101.SuspendLayout()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'My_Training_Panel101
        '
        Me.My_Training_Panel101.Controls.Add(Me.bt_Save101)
        Me.My_Training_Panel101.Controls.Add(Me.dtp_trDate101)
        Me.My_Training_Panel101.Controls.Add(Me.txt_courseDesc101)
        Me.My_Training_Panel101.Controls.Add(Me.lb_trcoursedescription101)
        Me.My_Training_Panel101.Controls.Add(Me.bt_cancel101)
        Me.My_Training_Panel101.Controls.Add(Me.bt_submit101)
        Me.My_Training_Panel101.Controls.Add(Me.cbx_trVenue101)
        Me.My_Training_Panel101.Controls.Add(Me.txt_trTime101)
        Me.My_Training_Panel101.Controls.Add(Me.txt_trCourse101)
        Me.My_Training_Panel101.Controls.Add(Me.txt_trCode101)
        Me.My_Training_Panel101.Controls.Add(Me.lb_tr_date101)
        Me.My_Training_Panel101.Controls.Add(Me.lb_tr_requireddepartment101)
        Me.My_Training_Panel101.Controls.Add(Me.lb_tr_venue101)
        Me.My_Training_Panel101.Controls.Add(Me.lb_tr_time101)
        Me.My_Training_Panel101.Controls.Add(Me.lb_tr_course101)
        Me.My_Training_Panel101.Controls.Add(Me.lb_tr_code101)
        Me.My_Training_Panel101.Controls.Add(Me.tr_gpbx101)
        Me.My_Training_Panel101.Dock = System.Windows.Forms.DockStyle.Fill
        Me.My_Training_Panel101.Location = New System.Drawing.Point(0, 0)
        Me.My_Training_Panel101.Name = "My_Training_Panel101"
        Me.My_Training_Panel101.Size = New System.Drawing.Size(1066, 485)
        Me.My_Training_Panel101.TabIndex = 0
        '
        'bt_Save101
        '
        Me.bt_Save101.Location = New System.Drawing.Point(130, 440)
        Me.bt_Save101.Name = "bt_Save101"
        Me.bt_Save101.Size = New System.Drawing.Size(75, 23)
        Me.bt_Save101.TabIndex = 73
        Me.bt_Save101.Text = "Save"
        Me.bt_Save101.UseVisualStyleBackColor = True
        '
        'dtp_trDate101
        '
        Me.dtp_trDate101.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_trDate101.Location = New System.Drawing.Point(214, 158)
        Me.dtp_trDate101.Name = "dtp_trDate101"
        Me.dtp_trDate101.Size = New System.Drawing.Size(238, 20)
        Me.dtp_trDate101.TabIndex = 72
        '
        'txt_courseDesc101
        '
        Me.txt_courseDesc101.Location = New System.Drawing.Point(214, 94)
        Me.txt_courseDesc101.Multiline = True
        Me.txt_courseDesc101.Name = "txt_courseDesc101"
        Me.txt_courseDesc101.Size = New System.Drawing.Size(238, 40)
        Me.txt_courseDesc101.TabIndex = 48
        '
        'lb_trcoursedescription101
        '
        Me.lb_trcoursedescription101.AutoSize = True
        Me.lb_trcoursedescription101.Location = New System.Drawing.Point(97, 117)
        Me.lb_trcoursedescription101.Name = "lb_trcoursedescription101"
        Me.lb_trcoursedescription101.Size = New System.Drawing.Size(96, 13)
        Me.lb_trcoursedescription101.TabIndex = 70
        Me.lb_trcoursedescription101.Text = "Course Description"
        '
        'bt_cancel101
        '
        Me.bt_cancel101.Location = New System.Drawing.Point(356, 440)
        Me.bt_cancel101.Name = "bt_cancel101"
        Me.bt_cancel101.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancel101.TabIndex = 69
        Me.bt_cancel101.Text = "Cancel"
        Me.bt_cancel101.UseVisualStyleBackColor = True
        '
        'bt_submit101
        '
        Me.bt_submit101.Location = New System.Drawing.Point(219, 440)
        Me.bt_submit101.Name = "bt_submit101"
        Me.bt_submit101.Size = New System.Drawing.Size(75, 23)
        Me.bt_submit101.TabIndex = 68
        Me.bt_submit101.Text = "Submit"
        Me.bt_submit101.UseVisualStyleBackColor = True
        '
        'cbx_trVenue101
        '
        Me.cbx_trVenue101.DataSource = Me.LocationsBindingSource
        Me.cbx_trVenue101.DisplayMember = "street_address"
        Me.cbx_trVenue101.FormattingEnabled = True
        Me.cbx_trVenue101.Location = New System.Drawing.Point(214, 246)
        Me.cbx_trVenue101.Name = "cbx_trVenue101"
        Me.cbx_trVenue101.Size = New System.Drawing.Size(238, 21)
        Me.cbx_trVenue101.TabIndex = 55
        Me.cbx_trVenue101.ValueMember = "location_id"
        '
        'LocationsBindingSource
        '
        Me.LocationsBindingSource.DataMember = "locations"
        Me.LocationsBindingSource.DataSource = Me.HRDataSet
        '
        'HRDataSet
        '
        Me.HRDataSet.DataSetName = "HRDataSet"
        Me.HRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_trTime101
        '
        Me.txt_trTime101.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_trTime101.Location = New System.Drawing.Point(214, 205)
        Me.txt_trTime101.Name = "txt_trTime101"
        Me.txt_trTime101.Size = New System.Drawing.Size(238, 20)
        Me.txt_trTime101.TabIndex = 52
        '
        'txt_trCourse101
        '
        Me.txt_trCourse101.Location = New System.Drawing.Point(214, 53)
        Me.txt_trCourse101.Name = "txt_trCourse101"
        Me.txt_trCourse101.Size = New System.Drawing.Size(238, 20)
        Me.txt_trCourse101.TabIndex = 47
        '
        'txt_trCode101
        '
        Me.txt_trCode101.Location = New System.Drawing.Point(214, 16)
        Me.txt_trCode101.Multiline = True
        Me.txt_trCode101.Name = "txt_trCode101"
        Me.txt_trCode101.Size = New System.Drawing.Size(238, 20)
        Me.txt_trCode101.TabIndex = 46
        '
        'lb_tr_date101
        '
        Me.lb_tr_date101.AutoSize = True
        Me.lb_tr_date101.Location = New System.Drawing.Point(99, 162)
        Me.lb_tr_date101.Name = "lb_tr_date101"
        Me.lb_tr_date101.Size = New System.Drawing.Size(30, 13)
        Me.lb_tr_date101.TabIndex = 53
        Me.lb_tr_date101.Text = "Date"
        '
        'lb_tr_requireddepartment101
        '
        Me.lb_tr_requireddepartment101.AutoSize = True
        Me.lb_tr_requireddepartment101.Location = New System.Drawing.Point(97, 290)
        Me.lb_tr_requireddepartment101.Name = "lb_tr_requireddepartment101"
        Me.lb_tr_requireddepartment101.Size = New System.Drawing.Size(108, 13)
        Me.lb_tr_requireddepartment101.TabIndex = 50
        Me.lb_tr_requireddepartment101.Text = "Required Department"
        '
        'lb_tr_venue101
        '
        Me.lb_tr_venue101.AutoSize = True
        Me.lb_tr_venue101.Location = New System.Drawing.Point(99, 254)
        Me.lb_tr_venue101.Name = "lb_tr_venue101"
        Me.lb_tr_venue101.Size = New System.Drawing.Size(38, 13)
        Me.lb_tr_venue101.TabIndex = 49
        Me.lb_tr_venue101.Text = "Venue"
        '
        'lb_tr_time101
        '
        Me.lb_tr_time101.AutoSize = True
        Me.lb_tr_time101.Location = New System.Drawing.Point(99, 212)
        Me.lb_tr_time101.Name = "lb_tr_time101"
        Me.lb_tr_time101.Size = New System.Drawing.Size(30, 13)
        Me.lb_tr_time101.TabIndex = 48
        Me.lb_tr_time101.Text = "Time"
        '
        'lb_tr_course101
        '
        Me.lb_tr_course101.AutoSize = True
        Me.lb_tr_course101.Location = New System.Drawing.Point(97, 60)
        Me.lb_tr_course101.Name = "lb_tr_course101"
        Me.lb_tr_course101.Size = New System.Drawing.Size(40, 13)
        Me.lb_tr_course101.TabIndex = 47
        Me.lb_tr_course101.Text = "Course"
        '
        'lb_tr_code101
        '
        Me.lb_tr_code101.AutoSize = True
        Me.lb_tr_code101.Location = New System.Drawing.Point(99, 23)
        Me.lb_tr_code101.Name = "lb_tr_code101"
        Me.lb_tr_code101.Size = New System.Drawing.Size(32, 13)
        Me.lb_tr_code101.TabIndex = 45
        Me.lb_tr_code101.Text = "Code"
        '
        'tr_gpbx101
        '
        Me.tr_gpbx101.Controls.Add(Me.rb_All101)
        Me.tr_gpbx101.Controls.Add(Me.rb_trPurchasingDept101)
        Me.tr_gpbx101.Controls.Add(Me.rb_trSalesDept101)
        Me.tr_gpbx101.Controls.Add(Me.rb_trSafetyDept101)
        Me.tr_gpbx101.Controls.Add(Me.rb_trHRDept101)
        Me.tr_gpbx101.Controls.Add(Me.rb_trFinanceDept101)
        Me.tr_gpbx101.Location = New System.Drawing.Point(214, 278)
        Me.tr_gpbx101.Name = "tr_gpbx101"
        Me.tr_gpbx101.Size = New System.Drawing.Size(544, 91)
        Me.tr_gpbx101.TabIndex = 71
        Me.tr_gpbx101.TabStop = False
        '
        'rb_All101
        '
        Me.rb_All101.AutoSize = True
        Me.rb_All101.Location = New System.Drawing.Point(322, 58)
        Me.rb_All101.Name = "rb_All101"
        Me.rb_All101.Size = New System.Drawing.Size(94, 17)
        Me.rb_All101.TabIndex = 5
        Me.rb_All101.TabStop = True
        Me.rb_All101.Text = "All Department"
        Me.rb_All101.UseVisualStyleBackColor = True
        '
        'rb_trPurchasingDept101
        '
        Me.rb_trPurchasingDept101.AutoSize = True
        Me.rb_trPurchasingDept101.Location = New System.Drawing.Point(322, 34)
        Me.rb_trPurchasingDept101.Name = "rb_trPurchasingDept101"
        Me.rb_trPurchasingDept101.Size = New System.Drawing.Size(136, 17)
        Me.rb_trPurchasingDept101.TabIndex = 4
        Me.rb_trPurchasingDept101.TabStop = True
        Me.rb_trPurchasingDept101.Text = "Purchasing Department"
        Me.rb_trPurchasingDept101.UseVisualStyleBackColor = True
        '
        'rb_trSalesDept101
        '
        Me.rb_trSalesDept101.AutoSize = True
        Me.rb_trSalesDept101.Location = New System.Drawing.Point(322, 11)
        Me.rb_trSalesDept101.Name = "rb_trSalesDept101"
        Me.rb_trSalesDept101.Size = New System.Drawing.Size(180, 17)
        Me.rb_trSalesDept101.TabIndex = 3
        Me.rb_trSalesDept101.TabStop = True
        Me.rb_trSalesDept101.Text = "Sales and Marketing Department"
        Me.rb_trSalesDept101.UseVisualStyleBackColor = True
        '
        'rb_trSafetyDept101
        '
        Me.rb_trSafetyDept101.AutoSize = True
        Me.rb_trSafetyDept101.Location = New System.Drawing.Point(7, 57)
        Me.rb_trSafetyDept101.Name = "rb_trSafetyDept101"
        Me.rb_trSafetyDept101.Size = New System.Drawing.Size(231, 17)
        Me.rb_trSafetyDept101.TabIndex = 2
        Me.rb_trSafetyDept101.TabStop = True
        Me.rb_trSafetyDept101.Text = "Food Safety and Environmental Department"
        Me.rb_trSafetyDept101.UseVisualStyleBackColor = True
        '
        'rb_trHRDept101
        '
        Me.rb_trHRDept101.AutoSize = True
        Me.rb_trHRDept101.Location = New System.Drawing.Point(7, 34)
        Me.rb_trHRDept101.Name = "rb_trHRDept101"
        Me.rb_trHRDept101.Size = New System.Drawing.Size(254, 17)
        Me.rb_trHRDept101.TabIndex = 1
        Me.rb_trHRDept101.TabStop = True
        Me.rb_trHRDept101.Text = "Human Resourse and Administration Department"
        Me.rb_trHRDept101.UseVisualStyleBackColor = True
        '
        'rb_trFinanceDept101
        '
        Me.rb_trFinanceDept101.AutoSize = True
        Me.rb_trFinanceDept101.Location = New System.Drawing.Point(7, 11)
        Me.rb_trFinanceDept101.Name = "rb_trFinanceDept101"
        Me.rb_trFinanceDept101.Size = New System.Drawing.Size(121, 17)
        Me.rb_trFinanceDept101.TabIndex = 0
        Me.rb_trFinanceDept101.TabStop = True
        Me.rb_trFinanceDept101.Text = "Finance Department"
        Me.rb_trFinanceDept101.UseVisualStyleBackColor = True
        '
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataMember = "jobs"
        Me.RolesBindingSource.DataSource = Me.HRDataSet
        '
        'LocationsTableAdapter
        '
        Me.LocationsTableAdapter.ClearBeforeFill = True
        '
        'JobsTableAdapter
        '
        Me.JobsTableAdapter.ClearBeforeFill = True
        '
        'My_Training_AddNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 485)
        Me.Controls.Add(Me.My_Training_Panel101)
        Me.Name = "My_Training_AddNew"
        Me.Text = "My_Training_AddNew"
        Me.My_Training_Panel101.ResumeLayout(False)
        Me.My_Training_Panel101.PerformLayout()
        CType(Me.LocationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tr_gpbx101.ResumeLayout(False)
        Me.tr_gpbx101.PerformLayout()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents My_Training_Panel101 As System.Windows.Forms.Panel
    Friend WithEvents bt_cancel101 As System.Windows.Forms.Button
    Friend WithEvents bt_submit101 As System.Windows.Forms.Button
    Friend WithEvents cbx_trVenue101 As System.Windows.Forms.ComboBox
    Friend WithEvents txt_trCourse101 As System.Windows.Forms.TextBox
    Friend WithEvents txt_trCode101 As System.Windows.Forms.TextBox
    Friend WithEvents lb_tr_date101 As System.Windows.Forms.Label
    Friend WithEvents lb_tr_requireddepartment101 As System.Windows.Forms.Label
    Friend WithEvents lb_tr_venue101 As System.Windows.Forms.Label
    Friend WithEvents lb_tr_time101 As System.Windows.Forms.Label
    Friend WithEvents lb_tr_course101 As System.Windows.Forms.Label
    Friend WithEvents lb_tr_code101 As System.Windows.Forms.Label
    Friend WithEvents txt_courseDesc101 As System.Windows.Forms.TextBox
    Friend WithEvents lb_trcoursedescription101 As System.Windows.Forms.Label
    Friend WithEvents tr_gpbx101 As System.Windows.Forms.GroupBox
    Friend WithEvents HRDataSet As WindowsApplication1.HRDataSet
    Friend WithEvents LocationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocationsTableAdapter As WindowsApplication1.HRDataSetTableAdapters.locationsTableAdapter
    Friend WithEvents dtp_trDate101 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_trTime101 As System.Windows.Forms.TextBox
    Friend WithEvents bt_Save101 As System.Windows.Forms.Button
    Friend WithEvents RolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobsTableAdapter As WindowsApplication1.HRDataSetTableAdapters.jobsTableAdapter
    Friend WithEvents rb_All101 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_trPurchasingDept101 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_trSalesDept101 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_trSafetyDept101 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_trHRDept101 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_trFinanceDept101 As System.Windows.Forms.RadioButton

End Class
