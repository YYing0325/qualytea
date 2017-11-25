Imports System.ComponentModel
Public Class landing_page
    Private Sub SplitContainer1_Panel1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        loadingControl()
        'Dim t1 As System.Threading.Thread = New System.Threading.Thread(AddressOf Me.loadingControl)
        't1.Start()
    End Sub

    Private Sub loadingControl()
        ' Full Width
        Me.btn_home.Width = SplitContainer1.Panel1.Width
        Me.btn_personal.Width = SplitContainer1.Panel1.Width
        Me.btn_training_management.Width = SplitContainer1.Panel1.Width
        Me.btn_my_performance.Width = SplitContainer1.Panel1.Width
        Me.btn_leave_management.Width = SplitContainer1.Panel1.Width
        Me.btn_payroll_management.Width = SplitContainer1.Panel1.Width
        Me.btn_job_applicants.Width = SplitContainer1.Panel1.Width
        Me.btn_logout.Width = SplitContainer1.Panel1.Width
        Me.btn_my_leave.Width = SplitContainer1.Panel1.Width
        Me.btn_performance_management.Width = SplitContainer1.Panel1.Width
        Me.btn_my_training.Width = SplitContainer1.Panel1.Width
        'Me.logo.Width = SplitContainer1.Panel1.Width

        ' Position
        Me.btn_job_applicants.Location = New Point(0, Me.btn_logout.Location.Y - 50)
        Me.btn_performance_management.Location = New Point(0, Me.btn_job_applicants.Location.Y - 50)
        Me.btn_payroll_management.Location = New Point(0, Me.btn_performance_management.Location.Y - 50)
        Me.btn_leave_management.Location = New Point(0, Me.btn_performance_management.Location.Y - 50)
        Me.btn_training_management.Location = New Point(0, Me.btn_leave_management.Location.Y - 50)
        Me.btn_my_performance.Location = New Point(0, Me.btn_training_management.Location.Y - 50)
        Me.btn_my_leave.Location = New Point(0, Me.btn_my_performance.Location.Y - 50)
        Me.btn_my_training.Location = New Point(0, Me.btn_my_leave.Location.Y - 50)
        Me.btn_personal.Location = New Point(0, Me.btn_my_training.Location.Y - 50)
        Me.btn_home.Location = New Point(0, Me.btn_personal.Location.Y - 50)
        'Me.logo.Location = New Point(0, Me.emp_id.Bottom)
        'Me.logo.Height = Me.btn_home.Top - Me.emp_id.Bottom

        'Me.HomeDashboard1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.MyTraining1.Hide()
        Me.MyPerformance1.Hide()
        Me.MyLeave1.Hide()
        Me.LeaveManagement1.Hide()
        Me.PerformanceManagement1.Hide()
        Me.TrainingManagement1.Hide()
    End Sub

    Private Sub SplitContainer1_Panel1_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Shown
        Loading.Close()
        Me.Show()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_personal.Click
        Dim personalDetailsComponent = Me.PersonalDetailsComponent1
        personalDetailsComponent.Show()
        personalDetailsComponent.Dock = DockStyle.Fill
        personalDetailsComponent.Size = New Size(SplitContainer1.Panel2.Width, SplitContainer1.Panel2.Height)
        personalDetailsComponent.empId = Me.emp_id.Text
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
        Me.MyTraining1.Hide()
        Me.MyPerformance1.Hide()
        Me.MyLeave1.Hide()
        Me.LeaveManagement1.Hide()
        Me.PerformanceManagement1.Hide()
        Me.TrainingManagement1.Hide()
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
        Me.MyTraining1.Hide()
        Me.MyPerformance1.Hide()
        Me.MyLeave1.Hide()
        Me.LeaveManagement1.Hide()
        Me.PerformanceManagement1.Hide()
        Me.TrainingManagement1.Hide()


    End Sub

    Private Sub btn_TrainingManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_training_management.Click
        'Me.TrainingManagement1.Show()
        Dim connectToAccess = New Connect_To_Access_Training()
        'connectToAccess.getNewTrainingList(Me.TrainingManagement1.DataGridView1, Me.emp_id.Text.ToString)
        connectToAccess.getTrainingManagementList(Me.TrainingManagement1.DataGridView2)
        connectToAccess.getFeedBackList(Me.TrainingManagement1.cbx_feedback101)
        Me.TrainingManagement1.Show()
        Me.HomeDashboard1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.MyTraining1.Hide()
        Me.MyPerformance1.Hide()
        Me.MyLeave1.Hide()
        Me.LeaveManagement1.Hide()
        Me.PerformanceManagement1.Hide()

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
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.MyTraining1.Hide()
        Me.MyPerformance1.Hide()
        Me.MyLeave1.Hide()
        Me.LeaveManagement1.Hide()
        Me.PerformanceManagement1.Hide()
        Me.TrainingManagement1.Hide()

    End Sub

    Private Sub btn_leave_management_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_leave_management.Click
        Me.HomeDashboard1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.MyTraining1.Hide()
        Me.MyPerformance1.Hide()
        Me.MyLeave1.Hide()
        Me.PerformanceManagement1.Hide()
        Me.TrainingManagement1.Hide()
        Dim connectToAccess = New Connect_To_Access
        'connectToAccess.getNewLeaveList(Me.Leave_H_Management1.datagrid_my_leave, Me.emp_id.Text.ToString)
        'connectToAccess.getEmployeeLeaves(Me.Leave_H_Management1.datagrid_leave_history, Me.emp_id.Text.ToString)
        'connectToAccess.getEmployeeLeavesRequest(Me.Leave_H_Management1.datagrid_leave_request, Me.emp_id.Text.ToString)
        Me.LeaveManagement1.Show()

    End Sub

    Private Sub btn_payroll_management_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_payroll_management.Click
        Me.HomeDashboard1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.MyTraining1.Hide()
        Me.MyPerformance1.Hide()
        Me.MyLeave1.Hide()
        Me.LeaveManagement1.Hide()
        Me.PerformanceManagement1.Hide()
        Me.TrainingManagement1.Hide()
        Me.LeaveManagement1.Show()

    End Sub


    Private Sub btn_performance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_my_performance.Click
        Me.MyPerformance1.Show()
        Me.HomeDashboard1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.MyTraining1.Hide()
        Me.MyLeave1.Hide()
        Me.LeaveManagement1.Hide()
        Me.PerformanceManagement1.Hide()
        Me.TrainingManagement1.Hide()
    End Sub

    Private Sub btn_my_leave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_my_leave.Click
        Me.HomeDashboard1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.MyTraining1.Hide()
        Me.MyPerformance1.Hide()
        Me.MyLeave1.Show()
        Me.LeaveManagement1.Hide()
        Me.PerformanceManagement1.Hide()
        Me.TrainingManagement1.Hide()
    End Sub

    Private Sub btn_performance_management_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_performance_management.Click
        Me.HomeDashboard1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.MyTraining1.Hide()
        Me.MyPerformance1.Hide()
        Me.MyLeave1.Hide()
        Me.LeaveManagement1.Hide()
        Me.TrainingManagement1.Hide()
        Me.PerformanceManagement1.Show()
        Dim connectToAccess = New Connect_To_Access_Performance
        connectToAccess.getEvaluationList(Me.PerformanceManagement1.datagrid_evaluation)
    End Sub

    Private Sub btn_my_training_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_my_training.Click
        Dim connectToAccessTraining = New Connect_To_Access_Training()
        connectToAccessTraining.emp_id = Me.emp_id.ToString
        connectToAccessTraining.getNewTrainingList(Me.MyTraining1.data_grid_TrNewTraining, Me.emp_id.Text.ToString)
        connectToAccessTraining.getInProgressTrainingList(Me.MyTraining1.data_grid_TrProgress, Me.emp_id.Text.ToString)
        connectToAccessTraining.getCompletionList(Me.MyTraining1.data_grid_TrComplete, Me.emp_id.Text.ToString)

        Me.HomeDashboard1.Hide()
        Me.PersonalDetailsComponent1.Hide()
        Me.JobApplicantsComponent1.Hide()
        Me.EditProfile1.Hide()
        Me.ChangePassword1.Hide()
        Me.Attendance1.Hide()
        Me.MyTraining1.Show()
        Me.MyPerformance1.Hide()
        Me.MyLeave1.Hide()
        Me.LeaveManagement1.Hide()
        Me.PerformanceManagement1.Hide()
        Me.TrainingManagement1.Hide()
    End Sub

    Private Sub PerformanceManagement1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerformanceManagement1.Load

    End Sub
End Class