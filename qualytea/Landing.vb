Public Class landing_page

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint
        ' Full Width
        Me.WindowState = FormWindowState.Maximized
        Me.btn_home.Width = SplitContainer1.Panel1.Width
        Me.btn_personal.Width = SplitContainer1.Panel1.Width
        Me.btn_work_management.Width = SplitContainer1.Panel1.Width
        Me.btn_performance.Width = SplitContainer1.Panel1.Width
        Me.btn_leave_management.Width = SplitContainer1.Panel1.Width
        Me.btn_payroll_management.Width = SplitContainer1.Panel1.Width
        Me.btn_job_applicants.Width = SplitContainer1.Panel1.Width
        Me.btn_logout.Width = SplitContainer1.Panel1.Width
        Me.logo.Width = SplitContainer1.Panel1.Width

        ' Position
        Me.btn_job_applicants.Location = New Point(0, Me.btn_logout.Location.Y - 50)
        Me.btn_payroll_management.Location = New Point(0, Me.btn_job_applicants.Location.Y - 50)
        Me.btn_leave_management.Location = New Point(0, Me.btn_payroll_management.Location.Y - 50)
        Me.btn_work_management.Location = New Point(0, Me.btn_leave_management.Location.Y - 50)
        Me.btn_performance.Location = New Point(0, Me.btn_work_management.Location.Y - 50)
        Me.btn_personal.Location = New Point(0, Me.btn_performance.Location.Y - 50)
        Me.btn_home.Location = New Point(0, Me.btn_personal.Location.Y - 50)
        Me.logo.Location = New Point(0, Me.emp_id.Bottom)
        Me.logo.Height = Me.btn_home.Top - Me.emp_id.Bottom

        Me.HomeDashboard1.Show()
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.My_Training.Hide()
        Me.Performance1.Hide()
        Me.Performance_overview1.Hide()
        Me.Leave_H_Management1.Hide()
        Me.Payroll_H_Management1.Hide()
        Me.Performance_evaluation1.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_personal.Click
        Dim personalDetailsComponent = Me.PersonalDetailsComponent1
        PersonalDetailsComponent.Show()
        PersonalDetailsComponent.Dock = DockStyle.Fill
        PersonalDetailsComponent.Size = New Size(SplitContainer1.Panel2.Width, SplitContainer1.Panel2.Height)
        PersonalDetailsComponent.empId = Me.emp_id.Text
        personalDetailsComponent.getProfile()
        personalDetailsComponent.Show()
        Dim editProfileComponent = Me.EditProfile1
        editProfileComponent.Dock = DockStyle.Fill
        editProfileComponent.empId = Me.emp_id.Text

        Me.ChangePassword1.empId = Me.emp_id.Text
        Me.ChangePassword1.changeEmpId()

        Me.HomeDashboard1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.My_Training.Hide()
        Me.Performance1.Hide()
        Me.Performance_overview1.Hide()
        Me.Leave_H_Management1.Hide()
        Me.Payroll_H_Management1.Hide()
        Me.Performance_evaluation1.Hide()
    End Sub

    Private Sub JobApplicant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_job_applicants.Click
        Dim connectToSql = New Connect_To_SQL()
        connectToSql.getApplicantsData(Me.JobApplicantsComponent1.data_grid_applicants)

        Me.JobApplicantsComponent1.Show()
        Me.JobApplicantsComponent1.Dock = DockStyle.Fill
        Me.JobApplicantsComponent1.Size = New Size(SplitContainer1.Panel2.Width, SplitContainer1.Panel2.Height)

        Me.HomeDashboard1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.My_Training.Hide()
        Me.Performance1.Hide()
        Me.Performance_overview1.Hide()
        Me.Leave_H_Management1.Hide()
        Me.Payroll_H_Management1.Hide()
        Me.Performance_evaluation1.Hide()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_work_management.Click
        Me.My_Training.Show()
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.getNewTrainingList(Me.My_Training.data_grid_TrNewTraining, Me.emp_id.Text.ToString)
        connectToAccess.getTrainingManagementList(Me.My_Training.DataGridView2)

        Me.HomeDashboard1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.Performance1.Hide()
        Me.Performance_overview1.Hide()
        Me.Leave_H_Management1.Hide()
        Me.Payroll_H_Management1.Hide()
        Me.Performance_evaluation1.Hide()

    End Sub

    Private Sub Landing_Closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Me_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.getAttendanceList(HomeDashboard1.datagrid_attendance, Me.emp_id.Text.ToString)
    End Sub

    Private Sub btn_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_home.Click
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.getAttendanceList(HomeDashboard1.datagrid_attendance, Me.emp_id.Text.ToString)
        Me.HomeDashboard1.Show()
        Me.JobApplicantsComponent1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.My_Training.Hide()
        Me.Performance1.Hide()
        Me.Performance_overview1.Hide()
        Me.Leave_H_Management1.Hide()
        Me.Payroll_H_Management1.Hide()
        Me.Performance_evaluation1.Hide()

    End Sub

    Private Sub btn_leave_management_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_leave_management.Click
        Me.HomeDashboard1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.My_Training.Hide()
        Me.Performance1.Hide()
        Me.Performance_overview1.Hide()
        Me.Payroll_H_Management1.Hide()
        Me.Performance_evaluation1.Hide()
        Dim connectToAccess = New Connect_To_Access
        'connectToAccess.getNewLeaveList(Me.Leave_H_Management1.datagrid_my_leave, Me.emp_id.Text.ToString)
        connectToAccess.getEmployeeLeaves(Me.Leave_H_Management1.datagrid_leave_history, Me.emp_id.Text.ToString)
        connectToAccess.getEmployeeLeavesRequest(Me.Leave_H_Management1.datagrid_leave_request, Me.emp_id.Text.ToString)
        Me.Leave_H_Management1.Show()

    End Sub

    Private Sub btn_payroll_management_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_payroll_management.Click
        Me.HomeDashboard1.Show()
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.My_Training.Hide()
        Me.Performance1.Hide()
        Me.Performance_overview1.Hide()
        Me.Leave_H_Management1.Hide()
        Me.Performance_evaluation1.Hide()
        Me.Payroll_H_Management1.Show()
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.getClaimsList(Me.Payroll_H_Management1.datagrid_payroll_mgmt, Me.emp_id.Text.ToString)
        connectToAccess.getClaimsStatus(Me.Payroll_H_Management1.datagrid_status, Me.emp_id.Text.ToString)

    End Sub


    Private Sub btn_performance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_performance.Click
        Me.Performance_overview1.Show()
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.getNewTrainingList(Me.My_Training.data_grid_TrNewTraining, Me.emp_id.Text.ToString)
        connectToAccess.getTrainingManagementList(Me.My_Training.DataGridView2)

        Me.HomeDashboard1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.Performance1.Hide()
        Me.My_Training.Hide()
        Me.Leave_H_Management1.Hide()
        Me.Payroll_H_Management1.Hide()
        Me.Performance_evaluation1.Hide()
    End Sub
End Class