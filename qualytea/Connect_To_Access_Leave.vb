Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Connect_To_Access_Leave

    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim dataFile = My.MySettings.Default.database_path
    Dim connString = provider & dataFile


    Public Function getPayrollByMonth(ByVal empId As String, ByVal month As Int32) As Dictionary(Of String, String)
        Dim dict = New Dictionary(Of String, String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [payroll] WHERE [employee_id]=? AND [payment_month]=? AND [payment_year]=?"
            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId)
                cmd.Parameters.AddWithValue("@p2", month)
                cmd.Parameters.AddWithValue("@p3", 2017)
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows = True Then
                            dict.Add("employee_id", empId)
                            dict.Add("month", month)
                            dict.Add("payment_amount", dr("payment_amount"))
                            dict.Add("overtime", dr("overtime"))
                            dict.Add("allowance", dr("allowance"))
                            dict.Add("epf", dr("epf"))
                            dict.Add("socso", dr("socso"))
                            dict.Add("claims", dr("claims"))
                            ' ADD HERE
                        End If
                    End While
                End Using
                myConnection.Close()
            End Using
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
        Return dict
    End Function

    Public Sub getEmployeeSalary(ByVal datagrid As DataGridView)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [employees] "

            Dim table As New DataTable
            table.Columns.Add("Employee ID", GetType(String))
            table.Columns.Add("First Name", GetType(String))
            table.Columns.Add("Last Name", GetType(String))
            table.Columns.Add("Department ID", GetType(String))
            table.Columns.Add("Job ID", GetType(String))
            table.Columns.Add("Salary", GetType(String))
            table.Columns.Add("Claims", GetType(String))
            table.Columns.Add("Leaves", GetType(String))
            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        Dim claims = 0
                        Dim query2 = "SELECT * FROM [claims] where [employee_id]=" & Convert.ToInt32(dr("employee_id"))
                        Using cmd2 As OleDbCommand = New OleDbCommand(query2, myConnection)

                            Using dr2 As OleDbDataReader = cmd2.ExecuteReader
                                While dr2.Read
                                    claims = dr2("total_amount")
                                End While
                            End Using

                        End Using

                        Dim leaves = 0
                        Dim query3 = "SELECT * FROM [leave] where [employee_id]=" & Convert.ToInt32(dr("employee_id"))
                        Using cmd3 As OleDbCommand = New OleDbCommand(query3, myConnection)

                            Using dr3 As OleDbDataReader = cmd3.ExecuteReader
                                While dr3.Read
                                    leaves = dr3("total_amount")
                                End While
                            End Using
                            table.Rows.Add(dr("employee_id"), dr("first_name"), dr("last_name"), dr("department_id"), dr("job_id"), dr("salary"), claims, leaves)

                        End Using
                    End While
                End Using

            End Using

            datagrid.DataSource = table

            If datagrid.ColumnCount.Equals(8) Then
                Dim btnApproveSalary As New DataGridViewButtonColumn()
                datagrid.Columns.Add(btnApproveSalary)
                btnApproveSalary.HeaderText = "Approve Salary"
                btnApproveSalary.Text = "Approve"
                btnApproveSalary.Name = "btn_approve_salary"
                btnApproveSalary.ToolTipText = "Approve Salary for employees"
                btnApproveSalary.UseColumnTextForButtonValue = True

                Dim btnApproveClaims As New DataGridViewButtonColumn()
                datagrid.Columns.Add(btnApproveClaims)
                btnApproveClaims.HeaderText = "Approve Claims"
                btnApproveClaims.Text = "Approve"
                btnApproveClaims.Name = "btn_approve_claims"
                btnApproveClaims.ToolTipText = "Approve Claims for employees"
                btnApproveClaims.UseColumnTextForButtonValue = True

                Dim btnApproveLeaves As New DataGridViewButtonColumn()
                datagrid.Columns.Add(btnApproveLeaves)
                btnApproveLeaves.HeaderText = "Approve Leaves"
                btnApproveLeaves.Text = "Approve"
                btnApproveLeaves.Name = "btn_approve_leaves"
                btnApproveLeaves.ToolTipText = "Approve Leaves for employees"
                btnApproveLeaves.UseColumnTextForButtonValue = True
            End If

            datagrid.Refresh()
            myConnection.Close()
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
    End Sub

    Public Sub approveSalary(ByVal data As Dictionary(Of String, Integer))
        'Should be use to insert data of Employee Leaves tab inside employee_leaves
        Try
            Dim accStr = "INSERT INTO [payroll]([employee_id],[payment_amount],[overtime],[allowance],[epf],[socso],[approved_by]) VALUES(@employee_id,@payment_amount,@overtime,@allowance,@epf,@socso,@approved_by)"
            myConnection.ConnectionString = connString
            Using accquery As New System.Data.OleDb.OleDbCommand(accStr, myConnection)
                myConnection.Open()
                accquery.Parameters.AddWithValue("@employee_id", data.Item("employee_id"))
                accquery.Parameters.AddWithValue("@payment_amount", data.Item("payment_amount"))
                accquery.Parameters.AddWithValue("@overtime)", data.Item("overtime"))
                accquery.Parameters.AddWithValue("@allowance)", data.Item("allowance"))
                accquery.Parameters.AddWithValue("@epf", data.Item("epf"))
                accquery.Parameters.AddWithValue("@socso", data.Item("socso"))
                accquery.Parameters.AddWithValue("@payment_month", 1)
                accquery.Parameters.AddWithValue("@payment_month", 2)
                accquery.Parameters.AddWithValue("@payment_month", 3)
                accquery.Parameters.AddWithValue("@payment_month", 4)
                accquery.Parameters.AddWithValue("@payment_month", 5)
                accquery.Parameters.AddWithValue("@payment_month", 6)
                accquery.Parameters.AddWithValue("@payment_month", 7)
                accquery.Parameters.AddWithValue("@payment_month", 8)
                accquery.Parameters.AddWithValue("@payment_month", 9)
                accquery.Parameters.AddWithValue("@payment_month", 10)
                accquery.Parameters.AddWithValue("@payment_month", 11)
                accquery.Parameters.AddWithValue("@approved_by", data.Item("approved_by"))

                accquery.ExecuteNonQuery()
                myConnection.Close()
            End Using
            MsgBox("Salary succesfully added into database.")
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

    End Sub
    Public Sub approveClaims(ByVal data As Dictionary(Of String, Integer))
        'Should be use to insert data of Employee Claims tab inside employee_claims
        Try
            Dim accStr = "INSERT INTO [claims]([employee_id],[total_amount]) VALUES(@employee_id,@total_amount)"
            myConnection.ConnectionString = connString
            Using accquery As New System.Data.OleDb.OleDbCommand(accStr, myConnection)
                myConnection.Open()
                accquery.Parameters.AddWithValue("@employee_id", data.Item("employee_id"))
                'accquery.Parameters.AddWithValue("@type_of_claims)", data.Item("type_of_claims"))
                accquery.Parameters.AddWithValue("@total_amount)", data.Item("total_amount"))
                'accquery.Parameters.AddWithValue("@claims_month", 1)
                'accquery.Parameters.AddWithValue("@claims_month", 2)
                'accquery.Parameters.AddWithValue("@claims_month", 3)
                'accquery.Parameters.AddWithValue("@claims_month", 4)
                'accquery.Parameters.AddWithValue("@claims_month", 5)
                'accquery.Parameters.AddWithValue("@claims_month", 6)
                'accquery.Parameters.AddWithValue("@claims_month", 7)
                'accquery.Parameters.AddWithValue("@claims_month", 8)
                'accquery.Parameters.AddWithValue("@claims_month", 9)
                'accquery.Parameters.AddWithValue("@claims_month", 10)
                'accquery.Parameters.AddWithValue("@claims_month", 11)

                accquery.ExecuteNonQuery()
                myConnection.Close()
            End Using
            'MsgBox("Claims succesfully added into database.")
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

    End Sub
    Public Sub approveLeaves(ByVal data As Dictionary(Of String, Integer))
        'Should be use to insert data of Employee Leaves tab inside employee_claims
        Try
            Dim accStr = "INSERT INTO [leave]([employee_id],[total_amount]) VALUES(@employee_id,@total_amount)"
            myConnection.ConnectionString = connString
            Using accquery As New System.Data.OleDb.OleDbCommand(accStr, myConnection)
                myConnection.Open()
                accquery.Parameters.AddWithValue("@employee_id", data.Item("employee_id"))
                'accquery.Parameters.AddWithValue("@type_of_claims)", data.Item("type_of_claims"))
                accquery.Parameters.AddWithValue("@total_amount)", data.Item("total_amount"))

                accquery.ExecuteNonQuery()
                myConnection.Close()
            End Using
            MsgBox("Leaves succesfully added into database.")
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub addToMyLeave(ByVal empId As String, ByVal LeaveType As String, ByVal LeaveFrom As DateTime, ByVal LeaveTill As DateTime, ByVal reason As String)
        'Save application of leaveto database
        Try
            Dim accStr = "INSERT INTO employee_leaves([employee_id],[leave_type],[leave_from],[leave_till],[reason]) VALUES(@employee_id,@leave_type,@leave_from,@leave_till,@reason)"
            myConnection.ConnectionString = connString
            Using accquery As New System.Data.OleDb.OleDbCommand(accStr, myConnection)
                myConnection.Open()
                accquery.Parameters.AddWithValue("@employee_id", Convert.ToInt16(empId))
                accquery.Parameters.AddWithValue("@leave_type", LeaveType)
                accquery.Parameters.AddWithValue("@leave_from", LeaveFrom.Date)
                accquery.Parameters.AddWithValue("@leave_till)", LeaveTill.Date)
                accquery.Parameters.AddWithValue("@reason", reason)
                accquery.ExecuteNonQuery()
                myConnection.Close()
            End Using
            'MsgBox("Leave succesfully added into database.")
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try
    End Sub

    Public Sub getMyLeave(ByVal dataGrid As DataGridView, ByVal empId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [employee_leaves]"
            Dim table As New DataTable
            table.Columns.Add("Type of Leave", GetType(String))
            table.Columns.Add("Date (From)", GetType(String))
            table.Columns.Add("Date (Till)", GetType(String))
            table.Columns.Add("Reason", GetType(String))
            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        table.Rows.Add(dr("leave_type"), dr("leave_from"), dr("leave_till"), dr("reason"))
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