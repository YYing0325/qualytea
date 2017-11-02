Public Class landing_page

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint
        ' Full Width
        Me.WindowState = FormWindowState.Maximized
        Me.btn_home.Width = SplitContainer1.Panel1.Width
        Me.btn_personal.Width = SplitContainer1.Panel1.Width
        Me.btn_work_management.Width = SplitContainer1.Panel1.Width
        Me.btn_time_management.Width = SplitContainer1.Panel1.Width
        Me.btn_finance.Width = SplitContainer1.Panel1.Width
        Me.btn_job_applicants.Width = SplitContainer1.Panel1.Width
        Me.btn_logout.Width = SplitContainer1.Panel1.Width
        ' Text
        Me.btn_personal.Text = "Personal Information"
        Me.btn_work_management.Text = "Work Management"
        Me.btn_time_management.Text = "Time Management"
        Me.btn_finance.Text = "Finance Management"
        Me.btn_job_applicants.Text = "Job Applicants"
        Me.btn_logout.Text = "Logout"
        ' Position
        Me.btn_job_applicants.Location = New Point(0, Me.btn_logout.Location.Y - 50)
        Me.btn_finance.Location = New Point(0, Me.btn_job_applicants.Location.Y - 50)
        Me.btn_time_management.Location = New Point(0, Me.btn_finance.Location.Y - 50)
        Me.btn_work_management.Location = New Point(0, Me.btn_time_management.Location.Y - 50)
        Me.btn_personal.Location = New Point(0, Me.btn_work_management.Location.Y - 50)
        Me.btn_home.Location = New Point(0, Me.btn_personal.Location.Y - 50)

        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.Performance1.Hide()
        Me.Performance_overview1.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_personal.Click
        Dim personalDetailsComponent = Me.PersonalDetailsComponent1
        PersonalDetailsComponent.Show()
        PersonalDetailsComponent.Dock = DockStyle.Fill
        PersonalDetailsComponent.Size = New Size(SplitContainer1.Panel2.Width, SplitContainer1.Panel2.Height)
        PersonalDetailsComponent.empId = Me.emp_id.Text
        personalDetailsComponent.getProfile()

        Dim editProfileComponent = Me.EditProfile1
        editProfileComponent.Dock = DockStyle.Fill
        editProfileComponent.empId = Me.emp_id.Text

        Me.ChangePassword1.empId = Me.emp_id.Text
        Me.ChangePassword1.changeEmpId()

        Me.JobApplicantsComponent1.Hide()
        Me.HomeDashboard1.Hide()
        Me.Performance1.Hide()
        Me.Performance_overview1.Hide()
    End Sub

    Private Sub JobApplicant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_job_applicants.Click
        Dim connectToSql = New Connect_To_SQL()
        connectToSql.getApplicantsData(Me.JobApplicantsComponent1.data_grid_applicants)
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.getInterviewList(Me.JobApplicantsComponent1.data_grid_interview)
        Dim jobApplicantComponent = Me.JobApplicantsComponent1
        jobApplicantComponent.Show()
        Me.JobApplicantsComponent1.Dock = DockStyle.Fill
        Me.JobApplicantsComponent1.Size = New Size(SplitContainer1.Panel2.Width, SplitContainer1.Panel2.Height)
        Me.PersonalDetailsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.HomeDashboard1.Hide()
        Me.Performance1.Hide()
        Me.Performance_overview1.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_time_management.Click
        Me.Performance1.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work_management.Click
        'Dim connectToAccess = New Connect_To_Access
        'connectToAccess.getNewTrainingList(Me.Performance1.data_grid_new_training, Me.emp_id.Text.ToString)
        'Me.Performance1.Show()
        Me.Performance_overview1.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click

    End Sub

    Private Sub lbl_name_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DownloadResume_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'If data_grid_applicants.Columns(e.ColumnIndex).Name = "btn_dl_resume" Then
        'MsgBox("Download Resume")
        'End If

    End Sub

    Private Sub panel_time_management_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Label1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_emp_id.Click

    End Sub

    Private Sub emp_id_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emp_id.Click

    End Sub

    Private Sub Landing_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Me_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.getAttendanceList(HomeDashboard1.datagrid_attendance, Me.emp_id.Text.ToString)
    End Sub

    Private Sub btn_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_home.Click
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.Performance1.Hide()
        Me.HomeDashboard1.Show()
        Me.Performance_overview1.Hide()
    End Sub

    Private Sub btn_finance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_finance.Click
        Me.Performance1.Hide()
        Me.Performance_overview1.Hide()
    End Sub
End Class