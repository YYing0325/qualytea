Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Connect_To_Access_Job_Applicants

    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim dataFile = My.MySettings.Default.database_path
    Dim connString = provider & dataFile


    Public Sub getApplicantList(ByVal dataGrid As DataGridView, ByVal applicantType As Int16)
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
            table.Columns.Add("Position Applied", GetType(String))
            table.Columns.Add("Resume", GetType(String))

            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [interview] WHERE [accepted]=" & applicantType, myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                If dr.HasRows = True Then
                   
                    table.Rows.Add(dr("interviewee_id"), dr("first_name"), dr("last_name"), dr("national_id"), dr("gender"), dr("email"), dr("tel_no"), dr("position"), dr("resume"))
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

    Public Sub getEmployeeList(ByVal dataGrid As DataGridView)
        Try
            myConnection.ConnectionString = connString
            myConnection.Open()

            Dim table As New DataTable
            table.Columns.Add("Active", GetType(Integer))
            table.Columns.Add("Employee Id", GetType(Integer))
            table.Columns.Add("Department", GetType(String))
            table.Columns.Add("Job", GetType(String))
            table.Columns.Add("First Name", GetType(String))
            table.Columns.Add("Last Name", GetType(String))
            table.Columns.Add("Email", GetType(String))
            table.Columns.Add("Gender", GetType(String))
            table.Columns.Add("Phone Number", GetType(String))
            table.Columns.Add("National Id", GetType(String))
            table.Columns.Add("Nationality", GetType(String))
            table.Columns.Add("Birth Date", GetType(String))
            table.Columns.Add("Address", GetType(String))
            table.Columns.Add("Emergency Contact Person", GetType(String))
            table.Columns.Add("Emergency Contact", GetType(String))
            table.Columns.Add("Hire Date", GetType(String))
            table.Columns.Add("Salary", GetType(String))
            table.Columns.Add("Termination Date", GetType(String))


            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [employees] ", myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                If dr.HasRows = True Then
                    Dim active = dr("active")
                    Dim empId = dr("employee_id")
                    Dim departmentId = dr("department_id")
                    Dim jobId = dr("job_id")
                    Dim firstName = dr("first_name")
                    Dim lastName = dr("last_name")
                    Dim email = dr("email")
                    Dim gender = dr("gender")
                    Dim phoneNumber = dr("phone_number")
                    Dim nationalId = dr("national_id")
                    Dim nationality = dr("nationality")
                    Dim birthdate = dr("birth_date")
                    Dim address = dr("address")
                    Dim emergencyContactPerson = dr("emergency_contact_person")
                    Dim emergencyContact = dr("emergency_contact")
                    Dim hireDate = dr("hire_date")
                    Dim salary = dr("salary")
                    Dim termination = dr("termination_date")
                    table.Rows.Add(active, empId, departmentId, jobId, firstName, lastName, email, gender, phoneNumber, nationalId, nationality, birthdate, address, emergencyContactPerson, emergencyContact, hireDate, salary, termination)
                End If
            End While
            dataGrid.DataSource = table

            If dataGrid.ColumnCount.Equals(18) Then
                Dim btnDownloadResume As New DataGridViewButtonColumn()
                dataGrid.Columns.Add(btnDownloadResume)
                btnDownloadResume.HeaderText = "Promote"
                btnDownloadResume.Text = "Promote"
                btnDownloadResume.Name = "btn_promote"
                btnDownloadResume.ToolTipText = "Promote Employee"
                btnDownloadResume.UseColumnTextForButtonValue = True

                Dim btnAcceptApplicant As New DataGridViewButtonColumn()
                dataGrid.Columns.Add(btnAcceptApplicant)
                btnAcceptApplicant.HeaderText = "Terminate"
                btnAcceptApplicant.Text = "Terminate"
                btnAcceptApplicant.Name = "btn_terminate"
                btnAcceptApplicant.ToolTipText = "Terminate Employee"
                btnAcceptApplicant.UseColumnTextForButtonValue = True

            End If

            myConnection.Close()
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
    End Sub


    Public Function getDepartmentList() As Dictionary(Of Integer, String)
        Dim dict = New Dictionary(Of Integer, String)
        Try
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [departments] ", myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                If dr.HasRows = True Then
                    Dim departmentId = dr("department_id")
                    Dim departmentName = dr("department_name")

                    dict.Add(departmentId, departmentName)

                End If
            End While
            myConnection.Close()
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
        Return dict
    End Function

    Public Function getJobList() As Dictionary(Of Integer, String)
        Dim dict = New Dictionary(Of Integer, String)
        Try
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [jobs] ", myConnection)
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


End Class
