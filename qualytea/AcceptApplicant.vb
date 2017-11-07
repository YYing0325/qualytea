Public Class AcceptApplicant

    Private firstName = ""
    Private lastName = ""
    Private email = ""
    Private telNumber = ""
    Private gender = ""
    Private nationalId = ""
    Private jobOffered = ""
    Private departmentId = ""
    Private salary = ""
    Private hireDate = ""
    Private intervieweeId = ""


    Public Sub setFirstName(ByVal firstName As String)
        Me.firstName = firstName
    End Sub

    Public Sub setLastName(ByVal lastName As String)
        Me.lastName = lastName
    End Sub
    Public Sub setEmail(ByVal email As String)
        Me.email = email
    End Sub
    Public Sub setTelNumber(ByVal telNumber As String)
        Me.telNumber = telNumber
    End Sub
    Public Sub setGender(ByVal gender As String)
        Me.gender = gender
    End Sub
    Public Sub setNationalId(ByVal nationalId As String)
        Me.nationalId = nationalId
    End Sub

    Public Sub setIntervieweeId(ByVal intervieweeId As String)
        Me.intervieweeId = intervieweeId
    End Sub

    Private Sub AcceptApplicant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        input_job_offered.Items.Clear()
        input_department.Items.Clear()

        Dim connectToAccess = New Connect_To_Access()
        Dim jobList = connectToAccess.getJobList()
        input_job_offered.DataSource = New BindingSource(jobList, Nothing)
        input_job_offered.DisplayMember = "Value"
        input_job_offered.ValueMember = "Key"
        Dim deptList = connectToAccess.getDepartmentList()
        input_department.DataSource = New BindingSource(deptList, Nothing)
        input_department.DisplayMember = "Value"
        input_department.ValueMember = "Key"

        intervieweeFirstName.Text = Me.firstName
        intervieweeLastName.Text = Me.lastName
    End Sub

    Private Sub btn_accept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_accept.Click

        jobOffered = input_job_offered.SelectedValue
        salary = input_salary.Text.ToString
        departmentId = input_department.SelectedValue
        hireDate = calendar_hire_date.SelectionRange.Start.ToString("yyyy-MM-dd")

        Dim dict = New Dictionary(Of String, String)
        dict.Add("first_name", Me.firstName)
        dict.Add("last_name", Me.lastName)
        dict.Add("national_id", Me.nationalId)
        dict.Add("gender", Me.gender)
        dict.Add("department_id", Me.departmentId)
        dict.Add("job_id", Me.jobOffered)
        dict.Add("salary", Me.salary)
        dict.Add("hire_date", Me.hireDate)
        dict.Add("email", Me.email)
        dict.Add("tel_no", Me.telNumber)

        Dim connectToAccess = New Connect_To_Access()
        Dim empId = connectToAccess.createProfile(dict)
        If Not empId = -1 Then
            connectToAccess.acceptApplicant(Me.intervieweeId, Me.jobOffered, Me.departmentId, empId)
            Me.Close()
        End If

    End Sub
End Class