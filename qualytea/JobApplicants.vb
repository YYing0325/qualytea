Imports System.Net.WebClient
Public Class JobApplicantsComponent
    'Private Sub fillTable()
    'Dim dataGrid = Me.data_grid_applicants
    'Dim connectToSQL = New Connect_To_SQL
    ' connectToSQL.getApplicantsData(dataGrid)
    ' Dim connectToAccess = New Connect_To_Access
    'connectToAccess.getInterviewList(Me.data_grid_interview)
    ' End Sub

    Sub handleCellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data_grid_applicants.CellClick

        If data_grid_applicants.Columns(e.ColumnIndex).Name = "btn_dl_resume" Then
            Dim dlUrl = data_grid_applicants.Rows(e.RowIndex).Cells("Resume").Value
            Dim fileNameArr = dlUrl.ToString.Split("/")
            Dim fileName = fileNameArr(fileNameArr.Length - 1)
            My.Computer.Network.DownloadFile("http://" & dlUrl, fileName)
            MsgBox("File Downloaded")
        End If

        If data_grid_applicants.Columns(e.ColumnIndex).Name = "btn_invite_interview" Then

            Dim status = data_grid_applicants.Rows(e.RowIndex).Cells("Status").Value
            Dim firstName = data_grid_applicants.Rows(e.RowIndex).Cells("First Name").Value
            Dim lastName = data_grid_applicants.Rows(e.RowIndex).Cells("Last Name").Value
            Dim gender = data_grid_applicants.Rows(e.RowIndex).Cells("Gender").Value
            Dim nationalId = data_grid_applicants.Rows(e.RowIndex).Cells("National Id").Value
            Dim email = data_grid_applicants.Rows(e.RowIndex).Cells("Email").Value
            Dim telNo = data_grid_applicants.Rows(e.RowIndex).Cells("Tel No").Value
            Dim positionApplied = data_grid_applicants.Rows(e.RowIndex).Cells("Position Applied").Value
            Dim qualification = data_grid_applicants.Rows(e.RowIndex).Cells("Qualification").Value
            Dim academicResult = data_grid_applicants.Rows(e.RowIndex).Cells("Academic Result").Value
            Dim resumeVar = data_grid_applicants.Rows(e.RowIndex).Cells("Resume").Value

            AddToInterviewList.first_name.Text = firstName.ToString
            AddToInterviewList.last_name.Text = lastName.ToString
            AddToInterviewList.gender.Text = gender.ToString
            AddToInterviewList.national_id.Text = nationalId.ToString
            AddToInterviewList.email_address.Text = email.ToString
            AddToInterviewList.tel_no.Text = telNo.ToString
            AddToInterviewList.position_applied.Text = positionApplied.ToString
            AddToInterviewList.applicant_resume = resumeVar.ToString

            AddToInterviewList.Show()

        End If
    End Sub

    Sub handleCellClick2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data_grid_interview.CellClick

        If data_grid_interview.Columns(e.ColumnIndex).Name = "btn_dl_resume" Then
            Dim dlUrl = data_grid_interview.Rows(e.RowIndex).Cells("Resume").Value
            Dim fileNameArr = dlUrl.ToString.Split("/")
            Dim fileName = fileNameArr(fileNameArr.Length - 1)
            My.Computer.Network.DownloadFile("http://" & dlUrl, fileName)
            MsgBox("File is downloaded.")
        End If

        If data_grid_interview.Columns(e.ColumnIndex).Name = "btn_accept" Then
            Dim intervieweeId = data_grid_interview.Rows(e.RowIndex).Cells("Interviewee Id").Value

            Dim firstName = data_grid_interview.Rows(e.RowIndex).Cells("First Name").Value
            Dim lastName = data_grid_interview.Rows(e.RowIndex).Cells("Last Name").Value
            Dim gender = data_grid_interview.Rows(e.RowIndex).Cells("Gender").Value
            Dim nationalId = data_grid_interview.Rows(e.RowIndex).Cells("National ID").Value
            Dim email = data_grid_interview.Rows(e.RowIndex).Cells("Email").Value
            Dim telNo = data_grid_interview.Rows(e.RowIndex).Cells("Tel No").Value

            AcceptApplicant.setFirstName(firstName)
            AcceptApplicant.setLastName(lastName)
            AcceptApplicant.setGender(gender.ToString)
            AcceptApplicant.setNationalId(nationalId.ToString)
            AcceptApplicant.setEmail(email.ToString)
            AcceptApplicant.setTelNumber(telNo.ToString)
            AcceptApplicant.setIntervieweeId(intervieweeId)
            AcceptApplicant.Show()
        End If

        If data_grid_interview.Columns(e.ColumnIndex).Name = "btn_reject" Then
            Dim intervieweeId = data_grid_interview.Rows(e.RowIndex).Cells("Interviewee Id").Value
            Dim connectToAccess = New Connect_To_Access()
            connectToAccess.rejectApplicant(intervieweeId)
        End If
    End Sub


    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As TabControlEventArgs) _
     Handles TabControl1.Selected

        If e.TabPageIndex = 0 Then
            Dim connectToSql = New Connect_To_SQL()
            connectToSql.getApplicantsData(Me.data_grid_applicants)
        ElseIf e.TabPageIndex = 1 Then
            Dim connectToAccess = New Connect_To_Access()
            connectToAccess.getInterviewList(Me.data_grid_interview)
        ElseIf e.TabPageIndex = 2 Then
            Dim connectToAccess = New Connect_To_Access_Job_Applicants()
            connectToAccess.getApplicantList(Me.data_grid_rejected_applicant, 2)
        ElseIf e.TabPageIndex = 3 Then
            Dim connectToAccess = New Connect_To_Access_Job_Applicants()
            connectToAccess.getApplicantList(Me.data_grid_accepted_applicant, 1)
        ElseIf e.TabPageIndex = 4 Then
            Dim connectToAccess = New Connect_To_Access_Job_Applicants()
            connectToAccess.getEmployeeList(Me.data_grid_current_employee)
        End If

    End Sub


    Sub handleCellClick3(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data_grid_current_employee.CellClick
        Dim empId = data_grid_current_employee.Rows(e.RowIndex).Cells("Employee Id").Value
        If data_grid_current_employee.Columns(e.ColumnIndex).Name = "btn_promote" Then
            PromoteForm.empId = empId
            PromoteForm.Show()
        ElseIf data_grid_current_employee.Columns(e.ColumnIndex).Name = "btn_terminate" Then
            Dim connectToAccess = New Connect_To_Access_Job_Applicants()
            connectToAccess.terminateEmployee(empId)
            MsgBox("Employee is terminated")
            data_grid_current_employee.Refresh()
            data_grid_current_employee.Update()

        End If

        
    End Sub


End Class
