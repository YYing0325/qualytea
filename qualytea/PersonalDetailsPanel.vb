Imports System.Data.OleDb
Public Class PersonalDetailsComponent
    Public empId = "0"
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
            Dim personalDetailsComponent As New PersonalDetailsComponent
            landing_page.emp_id.Text = emp("employee_id").ToString
            Me.emp_id.Text = emp("employee_id").ToString
            Me.emp_first_name.Text = emp("first_name").ToString
            Me.emp_last_name.Text = emp("last_name").ToString
            Me.emp_email.Text = emp("email").ToString
            Me.emp_phone_no.Text = emp("phone_number").ToString
            Me.emp_hire_date.Text = emp("hire_date").ToString
            Me.emp_salary.Text = emp("salary").ToString
            Me.emp_gender.Text = emp("gender").ToString
            Me.emp_nationality.Text = emp("nationality").ToString
            Me.emp_birthdate.Text = emp("birth_date").ToString
            Me.emp_national_id.Text = emp("national_id").ToString
            Me.emp_address.Text = emp("address").ToString
            Me.emp_e_contact_person.Text = emp("emergency_contact_person").ToString
            Me.emp_emergency_contact.Text = emp("emergency_contact").ToString
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_change_password.Click
        landing_page.ChangePassword1.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_national_id.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emp_address.Click

    End Sub

    Private Sub Image_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img_profile.Click
        If (Not System.IO.Directory.Exists("Resource")) Then
            System.IO.Directory.CreateDirectory("Resource")
        End If


        Dim OpenFileDialog1 As New OpenFileDialog
        With OpenFileDialog1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
            .FilterIndex = 2

            '
            If .ShowDialog = DialogResult.OK Then
                Dim FName() As String = OpenFileDialog1.FileName.Split("\\")
                If Not System.IO.File.Exists(OpenFileDialog1.FileName) Then
                    System.IO.File.Copy(OpenFileDialog1.FileName, "Resource\\" + FName(FName.Length - 1))
                End If
                img_profile.Image = Image.FromFile(.FileName)
            End If
        End With

    End Sub

    Private Sub FormOnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btn_edit_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_profile.Click
        landing_page.EditProfile1.Show()
        landing_page.EditProfile1.getProfile()
        Me.Hide()
    End Sub
End Class
