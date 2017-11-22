Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Connect_To_Access_Training
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim dataFile = My.MySettings.Default.database_path
    Dim connString = provider & dataFile
    Public emp_id As String

    Public Sub getNewTrainingList(ByVal dataGrid As DataGridView, ByVal empId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [employee_trainings] WHERE [employee_id]=? AND [status]=?" 'this will show only new employee
            'Dim query = "SELECT * FROM [employee_trainings]" 'this will show all training course
            Dim table As New DataTable
            table.Columns.Add("ID", GetType(String))
            table.Columns.Add("Code", GetType(String))
            table.Columns.Add("Course", GetType(String))
            table.Columns.Add("Course Description", GetType(String))
            table.Columns.Add("Date", GetType(String))
            table.Columns.Add("Time", GetType(String))
            table.Columns.Add("Venue", GetType(String))
            table.Columns.Add("Required Dept", GetType(String))


            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId) 'remark this so that will show all from training table.
                cmd.Parameters.AddWithValue("@p2", "N") 'remark this so that will show all from training table.
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
                                            table.Rows.Add(dr2("training_id"), dr2("training_code"), dr2("training_name"), dr2("training_description"), dr2("Training_datetime"), dr2("expired_at"), dr2("venue"), dr2("required_dept"))
                                            dataGrid.DataSource = table
                                            If dataGrid.ColumnCount.Equals(8) Then
                                                Dim btn As New DataGridViewButtonColumn()
                                                dataGrid.Columns.Add(btn)
                                                btn.HeaderText = ""
                                                btn.Text = "Accept"
                                                btn.Name = "btn_accept"
                                                btn.ToolTipText = "Click to accept the training"
                                                btn.UseColumnTextForButtonValue = True

                                                Dim btn1 As New DataGridViewButtonColumn()
                                                dataGrid.Columns.Add(btn1)
                                                btn1.HeaderText = ""
                                                btn1.Text = "Reject"
                                                btn1.Name = "btn_reject"
                                                btn.ToolTipText = "Click to reject the training"
                                                btn1.UseColumnTextForButtonValue = True
                                            End If
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
            table.Columns.Add("ID", GetType(String))
            table.Columns.Add("Code", GetType(String))
            table.Columns.Add("Course", GetType(String))
            table.Columns.Add("Course Description", GetType(String))
            table.Columns.Add("Date", GetType(String))
            table.Columns.Add("Time", GetType(String))
            table.Columns.Add("Venue", GetType(String))
            table.Columns.Add("Required Dept", GetType(String))

            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId) 'remark this so that will show all from training table.
                cmd.Parameters.AddWithValue("@p2", "P") 'remark this so that will show all from training table.
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
                                            'table.Rows.Add(dr2("training_id"), dr2("training_code"), dr2("training_name"), dr2("training_description"), dr2("Training_datetime"), dr2("expired_at"), dr2("required_dept"))
                                            table.Rows.Add(dr2("training_id"), dr2("training_code"), dr2("training_name"), dr2("training_description"), dr2("Training_datetime"), dr2("expired_at"), dr2("venue"), dr2("required_dept"))
                                            dataGrid.DataSource = table
                                            If dataGrid.ColumnCount.Equals(8) Then
                                                Dim btn As New DataGridViewButtonColumn()
                                                dataGrid.Columns.Add(btn)
                                                btn.HeaderText = ""
                                                btn.Text = "Completed Training"
                                                btn.Name = "btn_completedTraining"
                                                btn.ToolTipText = "Click to accept the training"
                                                btn.UseColumnTextForButtonValue = True
                                            End If
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

    Public Sub getCompletionList(ByVal dataGrid As DataGridView, ByVal empId As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [employee_trainings] WHERE [employee_id]=? AND [status]=?" 'this will show only new employee
            'Dim query = "SELECT * FROM [employee_trainings]" 'this will show all training course
            Dim table As New DataTable
            table.Columns.Add("ID", GetType(String))
            table.Columns.Add("Code", GetType(String))
            table.Columns.Add("Course", GetType(String))
            table.Columns.Add("Course Description", GetType(String))
            table.Columns.Add("Date", GetType(String))
            table.Columns.Add("Time", GetType(String))
            table.Columns.Add("Venue", GetType(String))
            table.Columns.Add("Required Dept", GetType(String))


            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", empId) 'remark this so that will show all from training table.
                cmd.Parameters.AddWithValue("@p2", "C") 'remark this so that will show all from training table.
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
                                            'table.Rows.Add(dr2("training_id"), dr2("training_code"), dr2("training_name"), dr2("training_description"), dr2("Training_datetime"), dr2("expired_at"), dr2("required_dept"))
                                            table.Rows.Add(dr2("training_id"), dr2("training_code"), dr2("training_name"), dr2("training_description"), dr2("Training_datetime"), dr2("expired_at"), dr2("venue"), dr2("required_dept"))
                                            dataGrid.DataSource = table
                                            If dataGrid.ColumnCount.Equals(8) Then
                                                Dim btn As New DataGridViewButtonColumn()
                                                dataGrid.Columns.Add(btn)
                                                btn.HeaderText = ""
                                                btn.Text = "Feedback"
                                                btn.Name = "btn_Feedback"
                                                btn.ToolTipText = "Click to accept the training"
                                                btn.UseColumnTextForButtonValue = True

                                            End If
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

            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows Then
                            table.Rows.Add(dr("training_id"), dr("training_code"), dr("training_name"), dr("training_description"), dr("Training_datetime"), dr("expired_at"), dr("venue"), dr("required_dept"))
                            dataGrid.DataSource = table
                            If dataGrid.ColumnCount.Equals(8) Then
                                Dim btn As New DataGridViewButtonColumn()
                                dataGrid.Columns.Add(btn)
                                btn.HeaderText = ""
                                btn.Text = "Generate"
                                btn.Name = "btn_Generate"
                                btn.ToolTipText = "Click to accept the training"
                                btn.UseColumnTextForButtonValue = True
                            End If
                        End If
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

    Public Sub getFeedBackList(ByVal cBox As ComboBox)
        myConnection.ConnectionString = connString
        cBox.Items.Clear()
        Try
            myConnection.Open()
            Dim query = "SELECT training_id,Code_id FROM training_feedback group by training_id,code_id"
            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows Then
                            cBox.Items.Add(dr("training_id").ToString + " - " + dr("Code_id").ToString)
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        myConnection.Close()
    End Sub

    Public Sub getTrainingDetailList(ByVal dataGrid As DataGridView, ByVal trainingCode As String)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [employee_trainings] WHERE [training_code]=? AND [status]=?" 'this will show all training course
            Dim table As New DataTable
            table.Columns.Add("Employee ID", GetType(String))
            table.Columns.Add("Employee Name", GetType(String))
            table.Columns.Add("Department", GetType(String))

            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                cmd.Parameters.AddWithValue("@p1", trainingCode)
                cmd.Parameters.AddWithValue("@p2", "P")
                myConnection.Open()
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        If dr.HasRows Then
                            Dim empId = dr("employee_id")
                            Dim query2 = "SELECT * FROM employees WHERE employee_id=?"
                            Using cmd2 As OleDbCommand = New OleDbCommand(query2, myConnection)
                                cmd2.Parameters.AddWithValue("@p1", empId)
                                Using dr2 As OleDbDataReader = cmd2.ExecuteReader
                                    While dr2.Read
                                        If dr2.HasRows Then
                                            Dim lastName = dr2("last_name")
                                            Dim firstName = dr2("first_name")
                                            Dim departmentId = dr2("department_id")
                                            Dim name = firstName + " " + lastName
                                            Dim query3 = "SELECT * FROM [departments] WHERE [department_id]=?"
                                            Using cmd3 As OleDbCommand = New OleDbCommand(query3, myConnection)
                                                cmd3.Parameters.AddWithValue("@p1", departmentId)
                                                Using dr3 As OleDbDataReader = cmd3.ExecuteReader
                                                    While dr3.Read
                                                        If dr3.HasRows Then
                                                            Dim departmentName = dr3("department_name")
                                                            table.Rows.Add(empId, name, departmentName)
                                                        End If
                                                    End While


                                                End Using
                                            End Using
                                        End If
                                    End While
                                    

                                End Using
                            End Using
                        End If
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

    Public Function getTrainingNameByCode(ByVal trainingCode As String) As String
        Dim trainingName = ""
        myConnection.ConnectionString = connString
        Dim query = "SELECT * FROM [trainings] WHERE [training_code]=?"
        Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
            myConnection.Open()
            cmd.Parameters.AddWithValue("@p1", trainingCode)
            Using dr As OleDbDataReader = cmd.ExecuteReader
                While dr.Read
                    If dr.HasRows Then
                        trainingName = dr("training_name")
                    End If
                End While

            End Using
            myConnection.Close()
        End Using
        Return trainingName
    End Function

    Public Function getTrainingCodeList() As List(Of String)
        Dim list = New List(Of String)
        myConnection.ConnectionString = connString
        Dim query = "SELECT [training_code] FROM [trainings]"
        Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
            myConnection.Open()
            Using dr As OleDbDataReader = cmd.ExecuteReader
                While dr.Read
                    If dr.HasRows Then
                        Dim trainingCode = dr("training_code")
                        list.Add(trainingCode)
                    End If
                End While

            End Using
            myConnection.Close()
        End Using
        Return list
    End Function

    Public Function getLocationList() As List(Of String)
        Dim list = New List(Of String)
        myConnection.ConnectionString = connString
        Dim query = "SELECT * FROM [locations]"
        Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
            myConnection.Open()
            Using dr As OleDbDataReader = cmd.ExecuteReader
                While dr.Read
                    If dr.HasRows Then
                        Dim locationId = dr("location_id")
                        Dim streetAddress = dr("street_address")
                        Dim city = dr("city")
                        Dim state = dr("state")
                        Dim address = streetAddress + "," + city + "," + state
                        list.Add(address)
                    End If
                End While

            End Using
            myConnection.Close()
        End Using
        Return list
    End Function

End Class