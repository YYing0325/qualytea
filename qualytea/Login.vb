Imports System.Data.OleDb

Public Class cmdlogin

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = My.MySettings.Default.database_path
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [login] WHERE [username]='" & tbusername.Text & "'AND [password] = '" & tbpassword.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim userFound As Boolean = False
        Dim employeeId As Integer = 0
        While dr.Read
            userFound = True
            employeeId = CInt(dr("employee_id").ToString)
        End While
        If userFound = True Then
            Dim empCmd As OleDbCommand = New OleDbCommand("SELECT * FROM [employees] WHERE [employee_id]=" & employeeId & "", myConnection)
            Dim emp As OleDbDataReader = empCmd.ExecuteReader
            'While emp.Read
            emp.Read()
            FrmWelcome.lbl_welcome_name.Text = "Hi " & emp("first_name") & ","
            Dim personalDetailsComponent As New PersonalDetailsComponent
            landing_page.emp_id.Text = emp("employee_id").ToString

            Dim departmentId As Integer = CInt(emp("department_id").ToString)
            Dim jobId As Integer = CInt(emp("job_id").ToString)
            Dim depCmd As OleDbCommand = New OleDbCommand("SELECT * FROM [departments] WHERE [department_id]=" & departmentId & "", myConnection)
            Dim dep As OleDbDataReader = depCmd.ExecuteReader
            My.MySettings.Default.attendance_status = emp("attendance_status").ToString

            Dim jobCmd As OleDbCommand = New OleDbCommand("SELECT * FROM [jobs] WHERE [job_id]=" & jobId & "", myConnection)
            Dim job As OleDbDataReader = jobCmd.ExecuteReader
            While job.Read
                'personalDetailsComponent.emp_job.Text = job("job_title").ToString
            End While

            'End While
            'FrmWelcome.Show()
            landing_page.Show()
            Me.Hide()
        Else
            MsgBox("Sorry, username or password invalid!", MsgBoxStyle.OkOnly, "Invalid")
        End If
        myConnection.Close()

        Dim connectToSql = New Connect_To_SQL()
        connectToSql.connect()

    End Sub

    Private Sub cbrmbr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbrmbr.CheckedChanged
        If cbrmbr.Checked = True Then
            My.MySettings.Default.username = tbusername.Text
            My.MySettings.Default.password = tbpassword.Text
            My.MySettings.Default.remember_me = cbrmbr.Checked
            My.MySettings.Default.Save()
        Else
            My.MySettings.Default.username = ""
            My.MySettings.Default.password = ""
            My.MySettings.Default.remember_me = cbrmbr.Checked
            My.MySettings.Default.Save()
        End If
        
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tbusername.Text = My.MySettings.Default.username
        tbpassword.Text = My.MySettings.Default.password
        cbrmbr.Checked = My.MySettings.Default.remember_me
    End Sub

    Private Sub btnFirstTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirstTime.Click
        FirstTimeSignUp.Show()
        Me.Hide()
    End Sub

    Private Sub tbpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbpassword.TextChanged

    End Sub
End Class