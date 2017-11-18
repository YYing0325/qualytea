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

    Public Sub getInProgressTrainingList(ByVal dataGrid As DataGridView, ByVal empId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [employee_trainings] WHERE [employee_id]=? AND [status]=?" 'this will show only new employee
            'Dim query = "SELECT * FROM [employee_trainings]" 'this will show all training course
            Dim table As New DataTable
            table.Columns.Add("Code", GetType(String))
            table.Columns.Add("Course", GetType(String))
            table.Columns.Add("Course Description", GetType(String))
            table.Columns.Add("Date", GetType(String))
            table.Columns.Add("Time", GetType(String))
            table.Columns.Add("Venue", GetType(String))
            table.Columns.Add("Required Dept", GetType(String))
            table.Columns.Add("Remarks", GetType(String))



            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                'cmd.Parameters.AddWithValue("@p1", empId) 'remark this so that will show all from training table.
                'cmd.Parameters.AddWithValue("@p2", "new") 'remark this so that will show all from training table.
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows = True Then
                            'table.Rows.Add(dr("check_in_at"), dr("check_out_at"), dr("working_minutes"), dr("note"))
                            Dim trainingId = dr("training_id")
                            Dim query2 = "SELECT * FROM [trainings] WHERE [training_id]=?"
                            Using cmd2 As OleDbCommand = New OleDbCommand(query2, myConnection)
                                cmd2.Parameters.AddWithValue("@p1", trainingId)
                                Using dr2 As OleDbDataReader = cmd2.ExecuteReader
                                    While dr2.Read
                                        If dr2.HasRows = True Then
                                            table.Rows.Add(dr2("training_id"), dr2("training_code"), dr2("training_name"), dr2("training_description"), dr2("Training_datetime"), dr2("expired_at"), dr2("venue"))
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

    Public Sub getTrainingManagementList(ByVal dataGrid As DataGridView)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [trainings]" 'this will show all training course
            Dim table As New DataTable
            table.Columns.Add("ID", GetType(String))
            table.Columns.Add("Code", GetType(String))
            table.Columns.Add("Course", GetType(String))
            table.Columns.Add("Course Description", GetType(String))
            table.Columns.Add("Date", GetType(String))
            table.Columns.Add("Time", GetType(String))
            table.Columns.Add("Venue", GetType(String))
            table.Columns.Add("Required Dept", GetType(String))
            table.Columns.Add("Remarks", GetType(String))
            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        table.Rows.Add(dr("training_id"), dr("training_code"), dr("training_name"), dr("training_description"), dr("Training_datetime"), dr("expired_at"), dr("venue"), dr("remark"))
                    End While
                End Using

            End Using
            dataGrid.DataSource = table
            dataGrid.Refresh()
            myConnection.Close()
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

    Public Function getEvaluation(ByVal empId As String, ByVal performanceYear As String) As Dictionary(Of String, String)
        Dim dict = New Dictionary(Of String, String)
        myConnection.ConnectionString = connString
        myConnection.Open()
        Try
            Dim empCmd As OleDbCommand = New OleDbCommand("SELECT * FROM [employees] WHERE [employee_id]=" & empId, myConnection)
            Dim dr As OleDbDataReader = empCmd.ExecuteReader
            While dr.Read
                If dr.HasRows = True Then
                    dict.Add("first_name", dr("first_name"))
                    dict.Add("last_name", dr("last_name"))
                    dict.Add("department_id", dr("department_id"))
                    dict.Add("point", dr("point"))
                    Dim deptId = Convert.ToInt32(dr("department_id"))

                    Dim empCmd2 As OleDbCommand = New OleDbCommand("SELECT * FROM [departments] WHERE [department_id]=" & deptId, myConnection)
                    Dim dr2 As OleDbDataReader = empCmd2.ExecuteReader
                    While dr2.Read
                        If dr2.HasRows = True Then
                            dict.Add("department", dr2("department_name"))
                        End If
                    End While


                    Dim empCmd3 As OleDbCommand = New OleDbCommand("SELECT * FROM [performance_evaluation] WHERE [performance_year]=" & performanceYear, myConnection)
                    Dim dr3 As OleDbDataReader = empCmd3.ExecuteReader
                    While dr3.Read
                        If dr3.HasRows = True Then
                            dict.Add("performance_year", dr3("performance_year").ToString)
                            dict.Add("c1_quality_productivity", dr3("c1_quality_productivity").ToString)
                            dict.Add("c2_flexibility", dr3("c2_flexibility").ToString)
                            dict.Add("c3_initiative", dr3("c3_initiative").ToString)
                            dict.Add("c4_dependability", dr3("c4_dependability").ToString)
                            dict.Add("c5_collaboration", dr3("c5_collaboration").ToString)
                            dict.Add("c6_communication", dr3("c6_communication").ToString)
                            dict.Add("c7_problem_solving", dr3("c7_problem_solving").ToString)
                            dict.Add("c8_technology_skill", dr3("c8_technology_skill").ToString)
                            dict.Add("c9_perseverance", dr3("c9_perseverance").ToString)
                            dict.Add("c10_agility", dr3("c10_agility").ToString)
                        End If
                    End While
                End If
            End While
            myConnection.Close()

        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
        Return dict
    End Function

    Public Sub addToEvaluation(ByVal data As Dictionary(Of String, Int32))
        'Should be use to insert data of performance_evaluation.vb
        Try
            Dim accStr = "INSERT INTO performance_evaluation([department_id],[employee_id],[performance_year],[c1_quality_productivity],[c2_flexibility],[c3_initiative],[c4_dependability],[c5_collaboration],[c6_communication],[c7_problem_solving],[c8_technology_skill],[c9_perseverance],[c10_agility]) VALUES(@department_id,@employee_id,@performance_year,@c1_quality_productivity,@c2_flexibility,@c3_initiative,@c4_dependability,@c5_collaboration,@c6_communication,@c7_problem_solving,@c8_technology_skill,@c9_perseverance,@c10_agility)"

            myConnection.ConnectionString = connString
            Using accquery As New System.Data.OleDb.OleDbCommand(accStr, myConnection)
                myConnection.Open()

                accquery.Parameters.AddWithValue("@department_id", data.Item("department_id"))
                accquery.Parameters.AddWithValue("@employee_id", data.Item("employee_id"))
                accquery.Parameters.AddWithValue("@performance_year", data.Item("performance_year"))
                accquery.Parameters.AddWithValue("@c1_quality_productivity", data.Item("c1_quality_productivity"))
                accquery.Parameters.AddWithValue("@c2_flexibility", data.Item("c2_flexibility"))
                accquery.Parameters.AddWithValue("@c3_initiative", data.Item("c3_initiative"))
                accquery.Parameters.AddWithValue("@c4_dependability", data.Item("c4_dependability"))
                accquery.Parameters.AddWithValue("@c5_collaboration", data.Item("c5_collaboration"))
                accquery.Parameters.AddWithValue("@c6_communication", data.Item("c6_communication"))
                accquery.Parameters.AddWithValue("@c7_problem_solving", data.Item("c7_problem_solving"))
                accquery.Parameters.AddWithValue("@c8_technology_skill", data.Item("c8_technology_skill"))
                accquery.Parameters.AddWithValue("@c9_perseverance", data.Item("c9_perseverance"))
                accquery.Parameters.AddWithValue("@c10_agility", data.Item("c10_agility"))
                accquery.ExecuteNonQuery()
                myConnection.Close()
            End Using
            MsgBox("Evaluation succesfully added into database.")
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub addTotalPoint(ByVal data As Dictionary(Of String, Integer))
        'Should be use to insert calculated total point of the year to kpi history
        Try
            Dim accStr = "INSERT INTO [employee_kpi]([employee_id],[credit_year],[point]) VALUES(@employee_id,@credit_year,@point)"
            myConnection.ConnectionString = connString
            Using accquery As New System.Data.OleDb.OleDbCommand(accStr, myConnection)
                myConnection.Open()
                accquery.Parameters.AddWithValue("@employee_id", data.Item("employee_id"))
                accquery.Parameters.AddWithValue("@credit_year", data.Item("performance_year"))
                accquery.Parameters.AddWithValue("@point)", data.Item("point"))

                accquery.ExecuteNonQuery()
                myConnection.Close()
            End Using

        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub getAttendanceList(ByVal dataGrid As DataGridView, ByVal empId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [employee_attendance] WHERE [employee_id]=?"
            Dim table As New DataTable
            table.Columns.Add("Date", GetType(Date))
            table.Columns.Add("Time In", GetType(String))
            table.Columns.Add("Time Out", GetType(String))
            table.Columns.Add("Working Minutes", GetType(String))
            table.Columns.Add("Note", GetType(String))
            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId)
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows = True Then
                            table.Rows.Add(dr("attendance_date"), dr("check_in_at"), dr("check_out_at"), dr("working_minutes"), dr("note"))
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

    Public Sub getNewLeaveList(ByVal dataGrid As DataGridView, ByVal empId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [leave] WHERE [employee_id]=?"
            Dim table As New DataTable
            table.Columns.Add("Type of Leave", GetType(String))
            table.Columns.Add("Entitled Leave", GetType(String))
            table.Columns.Add("Taken Leave", GetType(String))
            table.Columns.Add("Balance", GetType(String))

            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId)
                'cmd.Parameters.AddWithValue("@p2", "new")
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows = True Then
                            table.Rows.Add(dr("type_of_leave"), dr("entitled_leave"), dr("taken_leave"), dr("balance"))

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
                            Dim trainingId = dr("training_id")
                            Dim query2 = "SELECT * FROM [trainings] WHERE [training_id]=?"
                            Using cmd2 As OleDbCommand = New OleDbCommand(query2, myConnection)
                                cmd2.Parameters.AddWithValue("@p1", trainingId)
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

    Public Sub getApplicationList(ByVal dataGrid As DataGridView, ByVal requestId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [leave_history] WHERE [leave_request_id]=?"
            Dim table As New DataTable
            table.Columns.Add("Type of Leave", GetType(String))
            table.Columns.Add("From (Date)", GetType(String))
            table.Columns.Add("Until (Date)", GetType(String))
            table.Columns.Add("Status", GetType(String))
            table.Columns.Add("Remark", GetType(String))

            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", requestId)
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows = True Then
                            Dim reqId = dr("leave request_id")
                            table.Rows.Add(dr("type_of_leave"), dr("from_(date)"), dr("until_(date)"), dr("status"), dr("remark"))
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

    Public Sub getEmployeeLeaves(ByVal dataGrid As DataGridView, ByVal empId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [employee_leaves] WHERE [employee_id]=?"
            Dim table As New DataTable
            'table.Columns.Add("First Name ", GetType(String))
            'table.Columns.Add("Last Name ", GetType(String))
            table.Columns.Add("Type of Leave", GetType(String))
            table.Columns.Add("Applied At", GetType(String))
            table.Columns.Add("From (Date)", GetType(String))
            table.Columns.Add("Until (Date)", GetType(String))
            table.Columns.Add("Apporved At", GetType(String))
            table.Columns.Add("Approved By", GetType(String))

            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId)
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows = True Then
                            table.Rows.Add(dr("leave_type"), dr("applied_at"), dr("leave_date(from)"), dr("leave_date(until)"), dr("approved_at"), dr("approved_by"))

                        End If
                    End While
                End Using
            End Using
            dataGrid.DataSource = table
            myConnection.Close()

        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
    End Sub

    Public Sub addToMyLeave(ByVal data As Dictionary(Of String, String))
        'Should be use to insert data of Employee Leaves tab inside employee_leaves
        Try
            Dim accStr = "INSERT INTO employee_leaves([employee_id],[leave_type],[leave_date(from)],[leave_date(until)],[status]) VALUES(@employee_id,@leave_type,@leave_date(from),@leave_date(until),@status)"
            myConnection.ConnectionString = connString
            Using accquery As New System.Data.OleDb.OleDbCommand(accStr, myConnection)
                myConnection.Open()
                accquery.Parameters.AddWithValue("@employee_id", data.Item("employee_id").ToString)
                accquery.Parameters.AddWithValue("@leave_type", data.Item("leave_type").ToString)
                accquery.Parameters.AddWithValue("@leave_date(from)", data.Item("leave_date(from)").ToString)
                accquery.Parameters.AddWithValue("@leave_date(until)", data.Item("leave_date(until)").ToString)
                accquery.Parameters.AddWithValue("@status", data.Item("status").ToString)
                accquery.ExecuteNonQuery()
                myConnection.Close()
            End Using
            'MsgBox("Leave succesfully added into database.")
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub getEmployeeLeavesRequest(ByVal dataGrid As DataGridView, ByVal empId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [employee_leaves] WHERE [employee_id]=?"
            Dim table As New DataTable
            'table.Columns.Add("First Name ", GetType(String))
            'table.Columns.Add("Last Name ", GetType(String))
            table.Columns.Add("Type of Leave", GetType(String))
            table.Columns.Add("Applied At", GetType(String))
            table.Columns.Add("From (Date)", GetType(String))
            table.Columns.Add("Until (Date)", GetType(String))
            table.Columns.Add("Apporved At", GetType(String))
            table.Columns.Add("Approved By", GetType(String))


            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId)
                'cmd.Parameters.AddWithValue("@p2", "new")
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows = True Then
                            Dim leaveId = dr("leave_id")
                            'Dim query2 = "SELECT * FROM [employee_leaves] WHERE [leave_id]=?"
                            'Using cmd2 As OleDbCommand = New OleDbCommand(query2, myConnection)
                            'cmd2.Parameters.AddWithValue("@p1", leaveId)
                            'Using dr2 As OleDbDataReader = cmd2.ExecuteReader
                            'While dr2.Read
                            'If dr2.HasRows = True Then
                            table.Rows.Add(dr("leave_type"), dr("applied_at"), dr("leave_date(from)"), dr("leave_date(until)"), dr("approved_at"), dr("approved_by"))

                        End If
                    End While
                    dataGrid.DataSource = table
                    If dataGrid.ColumnCount.Equals(8) Then
                        Dim btn As New DataGridViewButtonColumn()
                        dataGrid.Columns.Add(btn)
                        btn.HeaderText = "Status"
                        btn.Text = "Accept"
                        btn.Name = "btn_accept"
                        btn.ToolTipText = "Click to approve the leaves"
                        btn.UseColumnTextForButtonValue = True

                        Dim btn1 As New DataGridViewButtonColumn()
                        dataGrid.Columns.Add(btn1)
                        btn1.HeaderText = "Status"
                        btn1.Text = "Reject"
                        btn1.Name = "btn_reject"
                        btn.ToolTipText = "Click to reject the leaves"
                        btn1.UseColumnTextForButtonValue = True
                    End If
                End Using
            End Using
            'End If
            'End While
            dataGrid.DataSource = table
            myConnection.Close()
            'End Using
            'End Using
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
    End Sub

    Public Sub getClaimsList(ByVal dataGrid As DataGridView, ByVal empId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [claims] WHERE [employee_id]=?"
            Dim table As New DataTable
            table.Columns.Add("Type of Claims", GetType(String))
            table.Columns.Add("Total Amount", GetType(String))
            table.Columns.Add("Project/Event", GetType(String))
            table.Columns.Add("Purposes", GetType(String))
            table.Columns.Add("Attachment", GetType(String))

            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId)
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows = True Then
                            table.Rows.Add(dr("type_of_claims"), dr("total_amount"), dr("project/event"), dr("purposes"), dr("attachment"))

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

    Public Sub getClaimsStatus(ByVal dataGrid As DataGridView, ByVal empId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [claims] WHERE [employee_id]=?"
            Dim table As New DataTable
            table.Columns.Add("Type of Claims", GetType(String))
            table.Columns.Add("Total Amount", GetType(String))
            table.Columns.Add("Project/Event", GetType(String))
            table.Columns.Add("Purposes", GetType(String))
            table.Columns.Add("Status", GetType(String))
            table.Columns.Add("Remarks", GetType(String))

            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId)
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows = True Then
                            table.Rows.Add(dr("type_of_claims"), dr("total_amount"), dr("project/event"), dr("purposes"), dr("status"), dr("remarks"))

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

    Public Sub punchIn(ByVal empId As String, ByVal punchInTime As DateTime, ByVal note As String)
        Try
            Dim accStr = "INSERT INTO [employee_attendance]([employee_id],[check_in_at],[attendance_date],[note]) VALUES(@employee_id,@check_in_at,@attendance_date,@note)"
            myConnection.ConnectionString = connString
            Using accquery As New System.Data.OleDb.OleDbCommand(accStr, myConnection)
                myConnection.Open()
                accquery.Parameters.AddWithValue("@employee_id", Convert.ToInt16(empId))
                accquery.Parameters.AddWithValue("@check_in_at", punchInTime.TimeOfDay)
                accquery.Parameters.AddWithValue("@attendance_date", punchInTime.Date)
                accquery.Parameters.AddWithValue("@note", note)
                accquery.ExecuteNonQuery()
                myConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try
        Dim var = "checked_in"
        Try
            Dim query = "UPDATE [employees] SET [attendance_status]='" & var & "' WHERE [employee_id]=" & empId
            Using cmd = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.ExecuteNonQuery()
                myConnection.Close()
            End Using

            My.Settings.punch_in_time = punchInTime
            My.Settings.punch_in_note = note
            My.Settings.attendance_status = var
        Catch ex As Exception
            MsgBox("Connection To Employee Database Failed: " & ex.Message.ToString)
        End Try
        Me.getAttendanceList(landing_page.HomeDashboard1.datagrid_attendance, empId)

    End Sub

    Public Sub punchOut(ByVal empId As String, ByVal punchOutTime As DateTime)
        Dim punchInTime = Format(My.Settings.punch_in_time, "h:mm:ss tt")
        Dim punchInDate = Format(My.Settings.punch_in_time.Date, "MM/dd/yyyy")
        ' still need note as param
        Dim note = My.Settings.punch_in_note.ToString
        Dim totalWorkingMinutes = (punchOutTime - My.Settings.punch_in_time).TotalMinutes
        Try
            Dim query2 = "UPDATE [employee_attendance] SET [check_out_at] = #" & punchOutTime.ToShortTimeString & "#, [working_minutes] = " & totalWorkingMinutes & ", [note]='" & note & "'" & _
       " WHERE [employee_id] = " & empId & " AND [check_in_at] = #" & punchInTime & "# AND [attendance_date] = #" & punchInDate & "#"
            myConnection.ConnectionString = connString

            Using cmd = New OleDbCommand(query2, myConnection)
                myConnection.Open()
                cmd.ExecuteNonQuery()
                myConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

        Dim var = "checked_out"
        Try
            Dim query = "UPDATE [employees] SET [attendance_status]='" & var & "' WHERE [employee_id]=" & empId
            Using cmd = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.ExecuteNonQuery()
                myConnection.Close()
            End Using
            My.Settings.attendance_status = var
        Catch ex As Exception
            MsgBox("Connection To Employee Database Failed: " & ex.Message.ToString)
        End Try
        Me.getAttendanceList(landing_page.HomeDashboard1.datagrid_attendance, empId)
    End Sub

End Class
