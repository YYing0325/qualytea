Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Connect_To_Access

    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim dataFile = My.MySettings.Default.database_path
    Dim connString = provider & dataFile


    Public Sub getInterviewList(ByVal dataGrid As DataGridView)
        Try
            myConnection.ConnectionString = connString
            myConnection.Open()

            Dim table As New DataTable
            table.Columns.Add("Status", GetType(String))
            table.Columns.Add("Interviewee Id", GetType(String))
            table.Columns.Add("First Name", GetType(String))
            table.Columns.Add("Last Name", GetType(String))
            table.Columns.Add("National Id", GetType(String))
            table.Columns.Add("Gender", GetType(String))
            table.Columns.Add("Added At", GetType(String))
            table.Columns.Add("Email", GetType(String))
            table.Columns.Add("Tel No", GetType(String))
            table.Columns.Add("Position Applied", GetType(String))
            table.Columns.Add("Resume", GetType(String))
            table.Columns.Add("Interview Date", GetType(String))
            table.Columns.Add("Interview Time", GetType(String))
            table.Columns.Add("Interviewed By", GetType(String))
            table.Columns.Add("Interview Venue", GetType(String))

            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [interview] WHERE [accepted]=0", myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                If dr.HasRows = True Then
                    Dim str = Convert.ToString(dr(0))
                    Dim accepted = ""
                    If dr("accepted") = 0 Then
                        accepted = "Not Yet Interviewed"
                    ElseIf dr("accepted") = 1 Then
                        accepted = "Accepted"
                    ElseIf dr("accepted") = 2 Then
                        accepted = "Rejected"
                    End If
                    table.Rows.Add(accepted, dr("interviewee_id"), dr("first_name"), dr("last_name"), dr("national_id"), dr("gender"), dr("created_at"), dr("email"), dr("tel_no"), dr("position"), dr("resume"), dr("interview_date"), dr("interview_time"), dr("interview_by"), dr("interview_venue"))
                End If
            End While
            dataGrid.DataSource = table

            If dataGrid.ColumnCount.Equals(15) Then
                Dim btnDownloadResume As New DataGridViewButtonColumn()
                dataGrid.Columns.Add(btnDownloadResume)
                btnDownloadResume.HeaderText = "Download Resume"
                btnDownloadResume.Text = "Download Resume"
                btnDownloadResume.Name = "btn_dl_resume"
                btnDownloadResume.ToolTipText = "Download the resume for preview"
                btnDownloadResume.UseColumnTextForButtonValue = True

                Dim btnAcceptApplicant As New DataGridViewButtonColumn()
                dataGrid.Columns.Add(btnAcceptApplicant)
                btnAcceptApplicant.HeaderText = "Accept"
                btnAcceptApplicant.Text = "Accept"
                btnAcceptApplicant.Name = "btn_accept"
                btnAcceptApplicant.ToolTipText = "Accept applicant"
                btnAcceptApplicant.UseColumnTextForButtonValue = True

                Dim btnRejectApplicant As New DataGridViewButtonColumn()
                dataGrid.Columns.Add(btnRejectApplicant)
                btnRejectApplicant.HeaderText = "Reject"
                btnRejectApplicant.Text = "Reject"
                btnRejectApplicant.Name = "btn_reject"
                btnRejectApplicant.ToolTipText = "Reject applicant"
                btnRejectApplicant.UseColumnTextForButtonValue = True
            End If

            myConnection.Close()
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try

    End Sub

    Public Sub addToInterviewList(ByVal data As Dictionary(Of String, String))

        Try
            Dim sqlStr = "INSERT INTO interview([first_name],[last_name],[national_id],[gender],[created_at],[email],[tel_no],[position],[resume],[accepted],[interview_date],[interview_time],[interview_venue],[interview_by]) VALUES(@first_name, @last_name, @national_id, @gender, @created_at, @email, @tel_no, @position, @resume, @accepted, @interview_date, @interview_time, @interview_venue, @interview_by )"

            myConnection.ConnectionString = connString
            Using sqlquery As New System.Data.OleDb.OleDbCommand(sqlStr, myConnection)
                myConnection.Open()
                sqlquery.Parameters.AddWithValue("@first_name", data.Item("first_name").ToString)
                sqlquery.Parameters.AddWithValue("@last_name", data.Item("last_name").ToString)
                sqlquery.Parameters.AddWithValue("@national_id", data.Item("national_id").ToString)
                sqlquery.Parameters.AddWithValue("@gender", data.Item("gender").ToString)
                sqlquery.Parameters.AddWithValue("@created_at", data.Item("added_at").ToString)
                sqlquery.Parameters.AddWithValue("@email", data.Item("email").ToString)
                sqlquery.Parameters.AddWithValue("@tel_no", data.Item("tel_no").ToString)
                sqlquery.Parameters.AddWithValue("@position", data.Item("position_applied").ToString)
                sqlquery.Parameters.AddWithValue("@resume", data.Item("resume").ToString)
                sqlquery.Parameters.AddWithValue("@accepted", Convert.ToInt16(data.Item("accepted").ToString))
                sqlquery.Parameters.AddWithValue("@interview_date", data.Item("interview_date").ToString)
                sqlquery.Parameters.AddWithValue("@interview_time", data.Item("interview_time").ToString)
                sqlquery.Parameters.AddWithValue("@interview_venue", data.Item("interview_venue").ToString)
                sqlquery.Parameters.AddWithValue("@interview_by", data.Item("interview_by").ToString)
                sqlquery.ExecuteNonQuery()
                myConnection.Close()
            End Using
            MsgBox("Applicant succesfully added into interviewee list.")
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub acceptApplicant(ByVal intervieweeId As String, ByVal jobOffered As String, ByVal departmentId As String, ByVal employeeId As String)

        Try
            Dim query = "UPDATE [interview] SET [accepted]=1, [department_id]=" & departmentId & ", [emp_id]=" & employeeId & ", [job_offered]=" & jobOffered & " " & _
       " WHERE [interviewee_id]=" & intervieweeId
            myConnection.ConnectionString = connString

            Using cmd = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.ExecuteNonQuery()
                myConnection.Close()
            End Using

            MsgBox("Applicant is accepted.")
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub rejectApplicant(ByVal interviewee_id As String)

        Try
            Dim query = "UPDATE [interview] SET [accepted]=?" & _
       " WHERE [interviewee_id]=?"
            myConnection.ConnectionString = connString

            Using cmd = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", 2)
                cmd.Parameters.AddWithValue("@p2", interviewee_id)
                cmd.ExecuteNonQuery()
                myConnection.Close()
            End Using

            MsgBox("Applicant is rejected.")
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub getAttendanceList(ByVal dataGrid As DataGridView, ByVal empId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [employee_attendance] WHERE [employee_id]=?"
            Dim table As New DataTable
            table.Columns.Add("Time In", GetType(String))
            table.Columns.Add("Time Out", GetType(String))
            table.Columns.Add("Working Hour", GetType(String))
            table.Columns.Add("Note", GetType(String))
            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId)
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows = True Then
                            table.Rows.Add(dr("check_in_at"), dr("check_out_at"), dr("working_minutes"), dr("note"))
                        End If
                    End While
                End Using
                
                dataGrid.DataSource = table
                myConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
    End Sub

    Public Sub getNewTrainingList(ByVal dataGrid As DataGridView, ByVal empId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [employee_trainings] WHERE [employee_id]=? AND [status]=?"
            Dim table As New DataTable
            table.Columns.Add("Code", GetType(String))
            table.Columns.Add("Course", GetType(String))
            table.Columns.Add("Course Description", GetType(String))
            table.Columns.Add("Date", GetType(String))
            table.Columns.Add("Expired At", GetType(String))
            table.Columns.Add("Location", GetType(String))

            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId)
                cmd.Parameters.AddWithValue("@p2", "new")
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows = True Then
                            'table.Rows.Add(dr("check_in_at"), dr("check_out_at"), dr("working_minutes"), dr("note"))
                            Dim trainingId = dr("training_id")
                            Dim query2 = "SELECT * FROM [trainings] WHERE [training_id]=?"
                            Using cmd2 As OleDbCommand = New OleDbCommand(query2, myConnection)
                                cmd2.Parameters.AddWithValue("@p3", trainingId)
                                Using dr2 As OleDbDataReader = cmd2.ExecuteReader
                                    While dr2.Read
                                        If dr2.HasRows = True Then
                                            table.Rows.Add(dr2("training_id"), dr2("training_name"), dr2("training_description"), dr2("training_datetime"), dr2("expired_at"), dr2("location"))
                                        End If
                                    End While
                                End Using
                            End Using
                        End If
                    End While
                End Using

                dataGrid.DataSource = table
                myConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
    End Sub

    Public Sub registerUser(ByVal data As Dictionary(Of String, String))

        Try
            Dim sqlStr = "INSERT INTO login([username],[password],[employee_id]) VALUES (@username, @password, @employee_id)"

            myConnection.ConnectionString = connString
            Using sqlquery As New System.Data.OleDb.OleDbCommand(sqlStr, myConnection)
                myConnection.Open()
                sqlquery.Parameters.AddWithValue("@username", data.Item("username").ToString)
                sqlquery.Parameters.AddWithValue("@password", data.Item("password").ToString)
                sqlquery.Parameters.AddWithValue("@employee_id", data.Item("employee_id").ToString)

                sqlquery.ExecuteNonQuery()
                myConnection.Close()
            End Using
            MsgBox("User is succesfully registered.")
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub updatePassword(ByVal dict As Dictionary(Of String, String))

        Try
            Dim query = "UPDATE [login] SET [password]=?" & _
       " WHERE [password]=? AND [employee_id]=?"
            myConnection.ConnectionString = connString

            Using cmd = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", dict.Item("newPassword"))
                cmd.Parameters.AddWithValue("@p2", dict.Item("oldPassword"))
                cmd.Parameters.AddWithValue("@p3", dict.Item("empId"))
                Dim affectedRow = cmd.ExecuteNonQuery()
                If affectedRow = 1 Then
                    MsgBox("Your password has been changed")
                Else
                    MsgBox("Please provide correct current password.")
                End If
                myConnection.Close()
            End Using


        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub getAcceptedList(ByVal dataGrid As DataGridView)
        Try
            myConnection.ConnectionString = connString
            myConnection.Open()

            Dim table As New DataTable
            table.Columns.Add("Interviewee Id", GetType(String))
            table.Columns.Add("First Name", GetType(String))
            table.Columns.Add("Last Name", GetType(String))
            table.Columns.Add("National Id", GetType(String))
            table.Columns.Add("Gender", GetType(String))
            table.Columns.Add("Email", GetType(String))
            table.Columns.Add("Tel No", GetType(String))
            table.Columns.Add("Job Offered", GetType(String))
            table.Columns.Add("Employee Id", GetType(String))

            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [interview] WHERE [accepted]=1", myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                If dr.HasRows = True Then
                    Dim jobOffered = dr("job_offered")
                    Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT * FROM [jobs] WHERE [job_id]=" & jobOffered)
                    Dim dr2 As OleDbDataReader = cmd2.ExecuteReader
                    While dr2.Read
                        If dr2.HasRows = True Then
                            Dim job = dr("job_title")
                            table.Rows.Add(dr("interviewee_id"), dr("first_name"), dr("last_name"), dr("national_id"), dr("gender"), dr("email"), dr("tel_no"), job, dr("emp_id"))
                        End If
                    End While
                End If
            End While
            dataGrid.DataSource = table

            myConnection.Close()
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try

    End Sub

    Public Function getJobList() As Dictionary(Of String, String)
        Dim dict As New Dictionary(Of String, String)
        Try
            myConnection.ConnectionString = connString
            myConnection.Open()

            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [jobs]", myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                If dr.HasRows = True Then
                    Dim jobId = dr("job_id")
                    Dim jobTitle = dr("job_title")
                    dict.Add(jobId, jobTitle)
                End If
            End While
            myConnection.Close()
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
        Return dict
    End Function

    Public Function getDepartmentList() As Dictionary(Of String, String)
        Dim dict As New Dictionary(Of String, String)
        Try
            myConnection.ConnectionString = connString
            myConnection.Open()

            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [departments]", myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                If dr.HasRows = True Then
                    Dim depId = dr("department_id")
                    Dim depName = dr("department_name")
                    dict.Add(depId, depName)
                End If
            End While
            myConnection.Close()
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
        Return dict
    End Function

    Public Function createProfile(ByVal Data As Dictionary(Of String, String)) As Integer
        Try
            Dim sqlStr = "INSERT INTO employees([first_name],[last_name],[national_id],[gender],[department_id],[job_id],[salary],[active],[first_time],[created_at],[email],[phone_number],[hire_date]) VALUES(@first_name,@last_name,@national_id,@gender,@department_id,@job_id,@salary,@active,@first_time,@created_at,@email,@tel_no, @hire_date )"
            myConnection.ConnectionString = connString
            Using sqlquery As New System.Data.OleDb.OleDbCommand(sqlStr, myConnection)
                myConnection.Open()
                sqlquery.Parameters.AddWithValue("@first_name", Data.Item("first_name").ToString)
                sqlquery.Parameters.AddWithValue("@last_name", Data.Item("last_name").ToString)
                sqlquery.Parameters.AddWithValue("@national_id", Data.Item("national_id").ToString)
                sqlquery.Parameters.AddWithValue("@gender", Data.Item("gender").ToString)
                sqlquery.Parameters.AddWithValue("@department_id", Convert.ToInt32(Data.Item("department_id")))
                sqlquery.Parameters.AddWithValue("@job_id", Convert.ToInt32(Data.Item("job_id")))
                sqlquery.Parameters.AddWithValue("@salary", Data.Item("salary").ToString)
                sqlquery.Parameters.AddWithValue("@active", 1)
                sqlquery.Parameters.AddWithValue("@first_time", 1)
                sqlquery.Parameters.AddWithValue("@created_at", System.DateTime.Now.Date.ToString("yyyy-MM-dd"))
                sqlquery.Parameters.AddWithValue("@hire_date", Data.Item("hire_date").ToString)
                sqlquery.Parameters.AddWithValue("@email", Data.Item("email").ToString)
                sqlquery.Parameters.AddWithValue("@tel_no", Data.Item("tel_no").ToString)
                sqlquery.ExecuteNonQuery()
                myConnection.Close()
            End Using
            MsgBox("User Profile is created")
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
            Return -1
        End Try

        Try
            Dim sqlStr2 = "SELECT MAX(employee_id) FROM employees"
            Using sqlquery2 As New System.Data.OleDb.OleDbCommand(sqlStr2, myConnection)
                myConnection.Open()
                Dim res = Int32.Parse(sqlquery2.ExecuteScalar().ToString())
                myConnection.Close()
                MsgBox(res)
                Return res
            End Using

        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
            Return -1
        End Try

    End Function

    Public Sub getRejectedList(ByVal dataGrid As DataGridView)
        Try
            myConnection.ConnectionString = connString
            myConnection.Open()

            Dim table As New DataTable
            table.Columns.Add("Status", GetType(String))
            table.Columns.Add("Interviewee Id", GetType(String))
            table.Columns.Add("First Name", GetType(String))
            table.Columns.Add("Last Name", GetType(String))
            table.Columns.Add("National Id", GetType(String))
            table.Columns.Add("Gender", GetType(String))
            table.Columns.Add("Email", GetType(String))
            table.Columns.Add("Tel No", GetType(String))
            table.Columns.Add("Position Applied", GetType(String))
            table.Columns.Add("Resume", GetType(String))
            table.Columns.Add("Remark", GetType(String))

            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [interview] WHERE [accepted]=0", myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                If dr.HasRows = True Then
                    Dim str = Convert.ToString(dr(0))
                    Dim accepted = ""
                    If dr("accepted") = 0 Then
                        accepted = "Not Yet Interviewed"
                    ElseIf dr("accepted") = 1 Then
                        accepted = "Accepted"
                    ElseIf dr("accepted") = 2 Then
                        accepted = "Rejected"
                    End If
                    table.Rows.Add(accepted, dr("interviewee_id"), dr("first_name"), dr("last_name"), dr("national_id"), dr("gender"), dr("created_at"), dr("email"), dr("tel_no"), dr("position"), dr("resume"), dr("interview_date"), dr("interview_time"), dr("interview_by"), dr("interview_venue"))
                End If
            End While
            dataGrid.DataSource = table

            If dataGrid.ColumnCount.Equals(15) Then
                Dim btnDownloadResume As New DataGridViewButtonColumn()
                dataGrid.Columns.Add(btnDownloadResume)
                btnDownloadResume.HeaderText = "Download Resume"
                btnDownloadResume.Text = "Download Resume"
                btnDownloadResume.Name = "btn_dl_resume"
                btnDownloadResume.ToolTipText = "Download the resume for preview"
                btnDownloadResume.UseColumnTextForButtonValue = True

                Dim btnAcceptApplicant As New DataGridViewButtonColumn()
                dataGrid.Columns.Add(btnAcceptApplicant)
                btnAcceptApplicant.HeaderText = "Accept"
                btnAcceptApplicant.Text = "Accept"
                btnAcceptApplicant.Name = "btn_accept"
                btnAcceptApplicant.ToolTipText = "Accept applicant"
                btnAcceptApplicant.UseColumnTextForButtonValue = True

                Dim btnRejectApplicant As New DataGridViewButtonColumn()
                dataGrid.Columns.Add(btnRejectApplicant)
                btnRejectApplicant.HeaderText = "Reject"
                btnRejectApplicant.Text = "Reject"
                btnRejectApplicant.Name = "btn_reject"
                btnRejectApplicant.ToolTipText = "Reject applicant"
                btnRejectApplicant.UseColumnTextForButtonValue = True
            End If

            myConnection.Close()
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try

    End Sub




End Class
