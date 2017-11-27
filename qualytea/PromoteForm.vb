Public Class PromoteForm

    Public empId = 0

    Private Sub PromoteForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connectToAccess = New Connect_To_Access_Job_Applicants()
        Dim department = connectToAccess.getDepartmentList()
        Dim job = connectToAccess.getJobList()
        cmb_department.DataSource = New BindingSource(department, Nothing)
        cmb_department.ValueMember = "Key"
        cmb_department.DisplayMember = "Value"
        cmb_job.DataSource = New BindingSource(job, Nothing)
        cmb_job.ValueMember = "Key"
        cmb_job.DisplayMember = "Value"
    End Sub

    Private Sub btn_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_confirm.Click
        Dim department = Convert.ToInt32(Me.cmb_department.SelectedValue)
        Dim job = Convert.ToInt32(Me.cmb_job.SelectedValue)
        Dim salary = Convert.ToInt32(Me.input_salary.Text)
        Dim connectToAccess = New Connect_To_Access_Job_Applicants()
        connectToAccess.promoteEmployee(empId.ToString, salary, department, job)
        MsgBox("Employee is promoted")
        landing_page.JobApplicantsComponent1.data_grid_current_employee.Refresh()
    End Sub
End Class