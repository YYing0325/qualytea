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

            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [interview]", myConnection)
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

    Public Sub acceptApplicant(ByVal interviewee_id As String)

        Try
            Dim query = "UPDATE [interview] SET [accepted]=?" & _
       " WHERE [interviewee_id]=?"
            myConnection.ConnectionString = connString

            Using cmd = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", 1)
                cmd.Parameters.AddWithValue("@p2", interviewee_id)
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
            table.Columns.Add("Required Role", GetType(String))
            table.Columns.Add("Required Status", GetType(String))


            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId) 'remark this so that will show all from training table.
                cmd.Parameters.AddWithValue("@p2", "new") 'remark this so that will show all from training table.
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows = True Then
                            'table.Rows.Add(dr("check_in_at"), dr("check_out_at"), dr("working_minutes"), dr("note"))
                            Dim trainingId = dr("training_id")
                            Dim query2 = "SELECT * FROM [trainings] WHERE [training_id]=?"
                            'Dim query2 = "SELECT * FROM [trainings]"
                            Using cmd2 As OleDbCommand = New OleDbCommand(query2, myConnection)
                                cmd2.Parameters.AddWithValue("@p1", trainingId)
                                Using dr2 As OleDbDataReader = cmd2.ExecuteReader
                                    While dr2.Read
                                        If dr2.HasRows = True Then
                                            table.Rows.Add(dr2("training_code"), dr2("training_name"), dr2("training_description"), dr2("Training_datetime"), dr2("expired_at"), dr2("venue"), dr2("required_dept"), dr2("required_role"), dr2("required_status"))
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
            table.Columns.Add("Required Role", GetType(String))
            table.Columns.Add("Required Status", GetType(String))




            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId) 'remark this so that will show all from training table.
                cmd.Parameters.AddWithValue("@p2", "new") 'remark this so that will show all from training table.
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
                                            table.Rows.Add(dr2("training_id"), dr2("training_code"), dr2("training_name"), dr2("training_description"), dr2("Training_datetime"), dr2("expired_at"), dr2("required_dept"), dr2("required_role"), dr2("required_status"))
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
            table.Columns.Add("Required Role", GetType(String))
            table.Columns.Add("Required Status", GetType(String))


            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        table.Rows.Add(dr("training_id"), dr("training_code"), dr("training_name"), dr("training_description"), dr("Training_datetime"), dr("expired_at"), dr("venue"), dr("required_dept"), dr("required_role"), dr("required_status"))
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
End Class

