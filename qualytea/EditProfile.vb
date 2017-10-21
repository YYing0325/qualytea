Imports System.Data.OleDb
Public Class EditProfile
    Public empId = "0"
    Private Sub FormOnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.getProfile()
    End Sub

    Public Sub getProfile()
        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "D:\Documents\HR.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()


        Dim employeeId = CInt(empId.ToString)
        Dim empCmd As OleDbCommand = New OleDbCommand("SELECT * FROM [employees] WHERE [employee_id]=" & employeeId & "", myConnection)
        Dim emp As OleDbDataReader = empCmd.ExecuteReader
        While emp.Read
            FrmWelcome.lbl_welcome_name.Text = "Hi " & emp("first_name") & ","
            Dim personalDetailsComponent As New PersonalDetailsComponent
            landing_page.emp_id.Text = emp("employee_id").ToString
            Me.emp_id.Text = emp("employee_id").ToString
            Me.input_first_name.Text = emp("first_name").ToString
            Me.input_last_name.Text = emp("last_name").ToString
            Me.input_email.Text = emp("email").ToString
            Me.input_phone_no.Text = emp("phone_number").ToString
            Me.emp_hire_date.Text = emp("hire_date").ToString
            Me.emp_salary.Text = emp("salary").ToString
            Me.input_gender.Text = emp("gender").ToString
            Me.input_nationality.Text = emp("nationality").ToString
            Me.input_birth_date.Text = emp("birth_date").ToString
            Me.input_national_id.Text = emp("national_id").ToString
            Me.input_address.Text = emp("address").ToString
            Me.input_emergency_contact_person.Text = emp("emergency_contact_person").ToString
            Me.input_emergency_contact.Text = emp("emergency_contact").ToString
            Dim departmentId As Integer = CInt(emp("department_id").ToString)
            Dim jobId As Integer = CInt(emp("job_id").ToString)
            Dim depCmd As OleDbCommand = New OleDbCommand("SELECT * FROM [departments] WHERE [department_id]=" & departmentId & "", myConnection)
            Dim dep As OleDbDataReader = depCmd.ExecuteReader
            While dep.Read
                Me.emp_department.Text = dep("department_name").ToString
            End While

            Dim jobCmd As OleDbCommand = New OleDbCommand("SELECT * FROM [jobs] WHERE [job_id]=" & jobId & "", myConnection)
            Dim job As OleDbDataReader = jobCmd.ExecuteReader
            While job.Read
                Me.emp_job.Text = job("job_title").ToString
            End While

        End While

        myConnection.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        landing_page.PersonalDetailsComponent1.Show()
    End Sub

    Private Sub btn_edit_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_profile.Click
        Dim provider As String
        Dim dataFile As String
        Dim connString As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "D:\Documents\HR.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim firstName = Me.input_first_name.Text.ToString
        Dim lastName = Me.input_last_name.Text.ToString
        Dim email = Me.input_email.Text.ToString
        Dim phoneNumber = Me.input_phone_no.Text.ToString
        Dim gender = Me.input_gender.Text.ToString
        Dim nationality = Me.input_nationality.Text.ToString
        Dim birthDate = Me.input_birth_date.Text.ToString
        Dim nationalId = Me.input_national_id.Text.ToString
        Dim address = Me.input_address.Text.ToString
        Dim emergencyContactPerson = Me.input_emergency_contact_person.Text.ToString
        Dim emergencyContact = Me.input_emergency_contact.Text.ToString

        Dim employeeId = CInt(empId.ToString)
        Dim query = "UPDATE employees SET first_name=?, last_name=?, email=?, " & _
        "phone_number=?, gender=?, nationality=?, birth_date=?," & _
        "national_id=?, address=?, emergency_contact_person=?, emergency_contact=?" & _
        " WHERE employee_id=?"

        Using cmd = New OleDbCommand(query, myConnection)
            cmd.Parameters.AddWithValue("@p1", firstName)
            cmd.Parameters.AddWithValue("@p2", lastName)
            cmd.Parameters.AddWithValue("@p3", email)
            cmd.Parameters.AddWithValue("@p4", phoneNumber)
            cmd.Parameters.AddWithValue("@p5", gender)
            cmd.Parameters.AddWithValue("@p6", nationality)
            cmd.Parameters.AddWithValue("@p7", birthDate)
            cmd.Parameters.AddWithValue("@p8", nationalId)
            cmd.Parameters.AddWithValue("@p9", address)
            cmd.Parameters.AddWithValue("@p10", emergencyContactPerson)
            cmd.Parameters.AddWithValue("@p11", emergencyContact)
            cmd.Parameters.AddWithValue("@p12", employeeId)
            cmd.ExecuteNonQuery()
        End Using


        myConnection.Close()
        MsgBox("Profile has been updated.")
        Me.Hide()
        landing_page.PersonalDetailsComponent1.getProfile()
        landing_page.PersonalDetailsComponent1.Show()
    End Sub
End Class
