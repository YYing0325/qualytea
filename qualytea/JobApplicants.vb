Imports System.Net.WebClient
Public Class JobApplicantsComponent
    Private Sub fillTable()
        Dim dataGrid = Me.data_grid_applicants
        Dim connectToSQL = New Connect_To_SQL
        connectToSQL.getApplicantsData(dataGrid)
        Dim connectToAccess = New Connect_To_Access
        connectToAccess.getInterviewList(Me.data_grid_interview)
    End Sub

    Sub handleCellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data_grid_applicants.CellClick

        If data_grid_applicants.Columns(e.ColumnIndex).Name = "btn_dl_resume" Then
            Dim dlUrl = data_grid_applicants.Rows(e.RowIndex).Cells("Resume").Value
            Dim fileNameArr = dlUrl.ToString.Split("/")
            Dim fileName = fileNameArr(fileNameArr.Length - 1)
            My.Computer.Network.DownloadFile("http://" & dlUrl, "C:\Users\Yingyee\Desktop\" & fileName)
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
            My.Computer.Network.DownloadFile("http://" & dlUrl, "C:\Users\Yingyee\Desktop\" & fileName)
        End If

        If data_grid_interview.Columns(e.ColumnIndex).Name = "btn_accept" Then
            Dim intervieweeId = data_grid_interview.Rows(e.RowIndex).Cells("Interviewee Id").Value
            Dim connectToAccess = New Connect_To_Access()
            connectToAccess.acceptApplicant(intervieweeId)
        End If

        If data_grid_interview.Columns(e.ColumnIndex).Name = "btn_reject" Then
            Dim intervieweeId = data_grid_interview.Rows(e.RowIndex).Cells("Interviewee Id").Value
            Dim connectToAccess = New Connect_To_Access()
            connectToAccess.rejectApplicant(intervieweeId)


        End If
    End Sub


End Class
