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
        Me.cbx_trStatus101 = New System.Windows.Forms.ComboBox
        Me.lb_trStatus101 = New System.Windows.Forms.Label
        Me.cbx_trRoles101 = New System.Windows.Forms.ComboBox
        Me.RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRDataSet = New WindowsApplication1.HRDataSet
        Me.lb_trRole101 = New System.Windows.Forms.Label
        Me.bt_Save101 = New System.Windows.Forms.Button
        Me.dtp_trDate101 = New System.Windows.Forms.DateTimePicker
        Me.txt_courseDesc101 = New System.Windows.Forms.TextBox
        Me.lb_trcoursedescription101 = New System.Windows.Forms.Label
        Me.bt_cancel101 = New System.Windows.Forms.Button
        Me.bt_submit101 = New System.Windows.Forms.Button
        Me.cbx_trVenue101 = New System.Windows.Forms.ComboBox
        Me.LocationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.cb_trFinanceDept = New System.Windows.Forms.CheckBox
        Me.cb_trHRDept = New System.Windows.Forms.CheckBox
        Me.cb_trTaxDepartment = New System.Windows.Forms.CheckBox
        Me.cb_trSafetyDept = New System.Windows.Forms.CheckBox
        Me.cb_trPurchasingDept = New System.Windows.Forms.CheckBox
        Me.cb_trSalesDept = New System.Windows.Forms.CheckBox
        Me.LocationsTableAdapter = New WindowsApplication1.HRDataSetTableAdapters.locationsTableAdapter
        Me.JobsTableAdapter = New WindowsApplication1.HRDataSetTableAdapters.jobsTableAdapter
        Me.My_Training_Panel101.SuspendLayout()
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tr_gpbx101.SuspendLayout()
        Me.SuspendLayout()
        '
        'My_Training_Panel101
        '
        Me.My_Training_Panel101.Controls.Add(Me.cbx_trStatus101)
        Me.My_Training_Panel101.Controls.Add(Me.lb_trStatus101)
        Me.My_Training_Panel101.Controls.Add(Me.cbx_trRoles101)
        Me.My_Training_Panel101.Controls.Add(Me.lb_trRole101)
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
        'cbx_trStatus101
        '
        Me.cbx_trStatus101.AllowDrop = True
        Me.cbx_trStatus101.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_trStatus101.FormattingEnabled = True
        Me.cbx_trStatus101.Items.AddRange(New Object() {"New", "Old"})
        Me.cbx_trStatus101.Location = New System.Drawing.Point(214, 345)
        Me.cbx_trStatus101.Name = "cbx_trStatus101"
        Me.cbx_trStatus101.Size = New System.Drawing.Size(238, 21)
        Me.cbx_trStatus101.TabIndex = 77
        '
        'lb_trStatus101
        '
        Me.lb_trStatus101.AutoSize = True
        Me.lb_trStatus101.Location = New System.Drawing.Point(99, 345)
        Me.lb_trStatus101.Name = "lb_trStatus101"
        Me.lb_trStatus101.Size = New System.Drawing.Size(37, 13)
        Me.lb_trStatus101.TabIndex = 76
        Me.lb_trStatus101.Text = "Status"
        '
        'cbx_trRoles101
        '
        Me.cbx_trRoles101.DataSource = Me.RolesBindingSource
        Me.cbx_trRoles101.DisplayMember = "job_title"
        Me.cbx_trRoles101.FormattingEnabled = True
        Me.cbx_trRoles101.Location = New System.Drawing.Point(214, 315)
        Me.cbx_trRoles101.Name = "cbx_trRoles101"
        Me.cbx_trRoles101.Size = New System.Drawing.Size(238, 21)
        Me.cbx_trRoles101.TabIndex = 75
        Me.cbx_trRoles101.ValueMember = "job_id"
        '
        'RolesBindingSource
        '
        Me.RolesBindingSource.DataMember = "jobs"
        Me.RolesBindingSource.DataSource = Me.HRDataSet
        '
        'HRDataSet
        '
        Me.HRDataSet.DataSetName = "HRDataSet"
        Me.HRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lb_trRole101
        '
        Me.lb_trRole101.AutoSize = True
        Me.lb_trRole101.Location = New System.Drawing.Point(99, 318)
        Me.lb_trRole101.Name = "lb_trRole101"
        Me.lb_trRole101.Size = New System.Drawing.Size(34, 13)
        Me.lb_trRole101.TabIndex = 74
        Me.lb_trRole101.Text = "Roles"
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
        Me.dtp_trDate101.Location = New System.Drawing.Point(214, 129)
        Me.dtp_trDate101.Name = "dtp_trDate101"
        Me.dtp_trDate101.Size = New System.Drawing.Size(238, 20)
        Me.dtp_trDate101.TabIndex = 72
        '
        'txt_courseDesc101
        '
        Me.txt_courseDesc101.Location = New System.Drawing.Point(214, 81)
        Me.txt_courseDesc101.Multiline = True
        Me.txt_courseDesc101.Name = "txt_courseDesc101"
        Me.txt_courseDesc101.Size = New System.Drawing.Size(238, 40)
        Me.txt_courseDesc101.TabIndex = 48
        '
        'lb_trcoursedescription101
        '
        Me.lb_trcoursedescription101.AutoSize = True
        Me.lb_trcoursedescription101.Location = New System.Drawing.Point(97, 94)
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
        Me.cbx_trVenue101.Location = New System.Drawing.Point(214, 185)
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
        'txt_trTime101
        '
        Me.txt_trTime101.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_trTime101.Location = New System.Drawing.Point(214, 155)
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
        Me.txt_trCode101.Location = New System.Drawing.Point(214, 23)
        Me.txt_trCode101.Multiline = True
        Me.txt_trCode101.Name = "txt_trCode101"
        Me.txt_trCode101.Size = New System.Drawing.Size(238, 20)
        Me.txt_trCode101.TabIndex = 46
        '
        'lb_tr_date101
        '
        Me.lb_tr_date101.AutoSize = True
        Me.lb_tr_date101.Location = New System.Drawing.Point(99, 135)
        Me.lb_tr_date101.Name = "lb_tr_date101"
        Me.lb_tr_date101.Size = New System.Drawing.Size(30, 13)
        Me.lb_tr_date101.TabIndex = 53
        Me.lb_tr_date101.Text = "Date"
        '
        'lb_tr_requireddepartment101
        '
        Me.lb_tr_requireddepartment101.AutoSize = True
        Me.lb_tr_requireddepartment101.Location = New System.Drawing.Point(97, 228)
        Me.lb_tr_requireddepartment101.Name = "lb_tr_requireddepartment101"
        Me.lb_tr_requireddepartment101.Size = New System.Drawing.Size(108, 13)
        Me.lb_tr_requireddepartment101.TabIndex = 50
        Me.lb_tr_requireddepartment101.Text = "Required Department"
        '
        'lb_tr_venue101
        '
        Me.lb_tr_venue101.AutoSize = True
        Me.lb_tr_venue101.Location = New System.Drawing.Point(97, 193)
        Me.lb_tr_venue101.Name = "lb_tr_venue101"
        Me.lb_tr_venue101.Size = New System.Drawing.Size(38, 13)
        Me.lb_tr_venue101.TabIndex = 49
        Me.lb_tr_venue101.Text = "Venue"
        '
        'lb_tr_time101
        '
        Me.lb_tr_time101.AutoSize = True
        Me.lb_tr_time101.Location = New System.Drawing.Point(97, 166)
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
        Me.lb_tr_code101.Location = New System.Drawing.Point(97, 30)
        Me.lb_tr_code101.Name = "lb_tr_code101"
        Me.lb_tr_code101.Size = New System.Drawing.Size(32, 13)
        Me.lb_tr_code101.TabIndex = 45
        Me.lb_tr_code101.Text = "Code"
        '
        'tr_gpbx101
        '
        Me.tr_gpbx101.Controls.Add(Me.cb_trFinanceDept)
        Me.tr_gpbx101.Controls.Add(Me.cb_trHRDept)
        Me.tr_gpbx101.Controls.Add(Me.cb_trTaxDepartment)
        Me.tr_gpbx101.Controls.Add(Me.cb_trSafetyDept)
        Me.tr_gpbx101.Controls.Add(Me.cb_trPurchasingDept)
        Me.tr_gpbx101.Controls.Add(Me.cb_trSalesDept)
        Me.tr_gpbx101.Location = New System.Drawing.Point(214, 212)
        Me.tr_gpbx101.Name = "tr_gpbx101"
        Me.tr_gpbx101.Size = New System.Drawing.Size(544, 91)
        Me.tr_gpbx101.TabIndex = 71
        Me.tr_gpbx101.TabStop = False
        '
        'cb_trFinanceDept
        '
        Me.cb_trFinanceDept.AutoSize = True
        Me.cb_trFinanceDept.Location = New System.Drawing.Point(6, 15)
        Me.cb_trFinanceDept.Name = "cb_trFinanceDept"
        Me.cb_trFinanceDept.Size = New System.Drawing.Size(122, 17)
        Me.cb_trFinanceDept.TabIndex = 57
        Me.cb_trFinanceDept.Text = "Finance Department"
        Me.cb_trFinanceDept.UseVisualStyleBackColor = True
        '
        'cb_trHRDept
        '
        Me.cb_trHRDept.AutoSize = True
        Me.cb_trHRDept.Location = New System.Drawing.Point(5, 38)
        Me.cb_trHRDept.Name = "cb_trHRDept"
        Me.cb_trHRDept.Size = New System.Drawing.Size(255, 17)
        Me.cb_trHRDept.TabIndex = 58
        Me.cb_trHRDept.Text = "Human Resourse and Administration Department"
        Me.cb_trHRDept.UseVisualStyleBackColor = True
        '
        'cb_trTaxDepartment
        '
        Me.cb_trTaxDepartment.AutoSize = True
        Me.cb_trTaxDepartment.Location = New System.Drawing.Point(6, 61)
        Me.cb_trTaxDepartment.Name = "cb_trTaxDepartment"
        Me.cb_trTaxDepartment.Size = New System.Drawing.Size(102, 17)
        Me.cb_trTaxDepartment.TabIndex = 63
        Me.cb_trTaxDepartment.Text = "Tax Department"
        Me.cb_trTaxDepartment.UseVisualStyleBackColor = True
        '
        'cb_trSafetyDept
        '
        Me.cb_trSafetyDept.AutoSize = True
        Me.cb_trSafetyDept.Location = New System.Drawing.Point(275, 15)
        Me.cb_trSafetyDept.Name = "cb_trSafetyDept"
        Me.cb_trSafetyDept.Size = New System.Drawing.Size(232, 17)
        Me.cb_trSafetyDept.TabIndex = 60
        Me.cb_trSafetyDept.Text = "Food Safety and Environmental Department"
        Me.cb_trSafetyDept.UseVisualStyleBackColor = True
        '
        'cb_trPurchasingDept
        '
        Me.cb_trPurchasingDept.AutoSize = True
        Me.cb_trPurchasingDept.Location = New System.Drawing.Point(275, 61)
        Me.cb_trPurchasingDept.Name = "cb_trPurchasingDept"
        Me.cb_trPurchasingDept.Size = New System.Drawing.Size(137, 17)
        Me.cb_trPurchasingDept.TabIndex = 62
        Me.cb_trPurchasingDept.Text = "Purchasing Department"
        Me.cb_trPurchasingDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb_trPurchasingDept.UseVisualStyleBackColor = True
        '
        'cb_trSalesDept
        '
        Me.cb_trSalesDept.AutoSize = True
        Me.cb_trSalesDept.Location = New System.Drawing.Point(275, 38)
        Me.cb_trSalesDept.Name = "cb_trSalesDept"
        Me.cb_trSalesDept.Size = New System.Drawing.Size(181, 17)
        Me.cb_trSalesDept.TabIndex = 61
        Me.cb_trSalesDept.Text = "Sales and Marketing Department"
        Me.cb_trSalesDept.UseVisualStyleBackColor = True
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
        CType(Me.RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tr_gpbx101.ResumeLayout(False)
        Me.tr_gpbx101.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents My_Training_Panel101 As System.Windows.Forms.Panel
    Friend WithEvents bt_cancel101 As System.Windows.Forms.Button
    Friend WithEvents bt_submit101 As System.Windows.Forms.Button
    Friend WithEvents cb_trTaxDepartment As System.Windows.Forms.CheckBox
    Friend WithEvents cb_trPurchasingDept As System.Windows.Forms.CheckBox
    Friend WithEvents cb_trSalesDept As System.Windows.Forms.CheckBox
    Friend WithEvents cb_trSafetyDept As System.Windows.Forms.CheckBox
    Friend WithEvents cb_trHRDept As System.Windows.Forms.CheckBox
    Friend WithEvents cb_trFinanceDept As System.Windows.Forms.CheckBox
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
    Friend WithEvents cbx_trRoles101 As System.Windows.Forms.ComboBox
    Friend WithEvents lb_trRole101 As System.Windows.Forms.Label
    Friend WithEvents cbx_trStatus101 As System.Windows.Forms.ComboBox
    Friend WithEvents lb_trStatus101 As System.Windows.Forms.Label
    Friend WithEvents RolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JobsTableAdapter As WindowsApplication1.HRDataSetTableAdapters.jobsTableAdapter

End Class
