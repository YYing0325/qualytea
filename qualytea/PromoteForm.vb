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
End Class