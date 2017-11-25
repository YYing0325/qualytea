Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Connect_To_Access_Performance

    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim dataFile = My.MySettings.Default.database_path
    Dim connString = provider & dataFile


    Public Function getEmployeesNameByDepartment(ByVal departmentId As Int16) As List(Of String)

        Dim list = New List(Of String)
        Try
            myConnection.ConnectionString = connString
            myConnection.Open()

            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [employees] where [department_id]=" & departmentId, myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            While dr.Read
                If dr.HasRows = True Then
                    Dim empId = dr("employee_id")
                    Dim firstName = dr("first_name")
                    Dim lastName = dr("last_name")
                    list.Add(empId.ToString & " | " & firstName & " " + lastName)
                End If
            End While
            myConnection.Close()

        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try

        Return list
    End Function

    Public Function getHistoryPoint(ByVal empId As String, ByVal performanceYear As String) As Dictionary(Of String, String)
        Dim dict1 = New Dictionary(Of String, String)
        myConnection.ConnectionString = connString
        myConnection.Open()
        Try
            Dim empCmd As OleDbCommand = New OleDbCommand("SELECT * FROM [employees] WHERE [employee_id]=" & empId, myConnection)
            Dim dr As OleDbDataReader = empCmd.ExecuteReader
            While dr.Read
                If dr.HasRows = True Then


                    Dim empCmd2 As OleDbCommand = New OleDbCommand("SELECT * FROM [employee_kpi] WHERE [credit_year]=" & performanceYear, myConnection)
                    Dim dr2 As OleDbDataReader = empCmd2.ExecuteReader
                    While dr2.Read
                        If dr2.HasRows = True Then
                            dict1.Add("point", dr("point"))
                        End If
                    End While
                End If
            End While
            myConnection.Close()

        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
        Return dict1
    End Function

    Public Function getCurrentPoint(ByVal empId As String) As Dictionary(Of String, String)
        Dim dict = New Dictionary(Of String, String)
        myConnection.ConnectionString = connString
        myConnection.Open()
        Try
            Dim empCmd As OleDbCommand = New OleDbCommand("SELECT * FROM [employees] WHERE [employee_id]=" & empId, myConnection)
            Dim dr As OleDbDataReader = empCmd.ExecuteReader
            While dr.Read
                If dr.HasRows = True Then
                    dict.Add("point", dr("point"))

                End If
            End While
            myConnection.Close()

        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
        Return dict
    End Function

    Public Sub updateCurrentPoint(ByVal dict As Dictionary(Of String, String))

        Try
            Dim query = "UPDATE [employees] SET [point]=?" & _
        " WHERE [point]=? AND [employee_id]=?"
            myConnection.ConnectionString = connString

            Using cmd = New OleDbCommand(query, myConnection)
                myConnection.Open()
                cmd.Parameters.AddWithValue("@p1", dict.Item("newPoint"))
                cmd.Parameters.AddWithValue("@p2", dict.Item("currentPoint"))
                cmd.Parameters.AddWithValue("@p3", dict.Item("empId"))
                cmd.ExecuteNonQuery()
                myConnection.Close()
            End Using

            MsgBox("Voucher redeem successfully. Please get the voucher from counter after 3 working days.", MsgBoxStyle.OkOnly, "Congratulation!")
        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try

    End Sub

    Public Sub addToVoucherRedeemed(ByVal data As Dictionary(Of String, String))
        'Should be use to insert data of voucher reedeemed into database
        Try
            Dim accStr = "INSERT INTO voucher_redeem([employee_id],[voucher_company_id],[voucher_amount]) VALUES(@employee_id,@voucher_company_id,@voucher_amount)"
            myConnection.ConnectionString = connString
            Using accquery As New System.Data.OleDb.OleDbCommand(accStr, myConnection)
                myConnection.Open()
                accquery.Parameters.AddWithValue("@employee_id", data.Item("employee_id").ToString)
                accquery.Parameters.AddWithValue("@voucher_company_id", data.Item("voucher_company_id").ToString)
                accquery.Parameters.AddWithValue("@voucher_amount", data.Item("voucher_amount").ToString)
                accquery.ExecuteNonQuery()
                myConnection.Close()
            End Using

        Catch ex As Exception
            MsgBox("Connection To Database Failed: " & ex.Message.ToString)
        End Try
    End Sub

    Public Sub getEvaluationList(ByVal datagrid As DataGridView)
        Try
            myConnection.ConnectionString = connString
            Dim query = "SELECT * FROM [employees] "

            Dim table As New DataTable
            table.Columns.Add("Employee ID", GetType(String))
            table.Columns.Add("First Name", GetType(String))
            table.Columns.Add("Last Name", GetType(String))
            table.Columns.Add("Quality & Productivity", GetType(String))
            table.Columns.Add("Flexibility", GetType(String))
            table.Columns.Add("Initiative", GetType(String))
            table.Columns.Add("Dependability", GetType(String))
            table.Columns.Add("Collaboration", GetType(String))
            table.Columns.Add("Communication", GetType(String))
            table.Columns.Add("Problem Solving", GetType(String))
            table.Columns.Add("Technology Skill", GetType(String))
            table.Columns.Add("Preseverance", GetType(String))
            table.Columns.Add("Agility", GetType(String))
            table.Columns.Add("Credit Year", GetType(String))
            table.Columns.Add("Total Point", GetType(String))

            Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                myConnection.Open()
                Using dr As OleDbDataReader = cmd.ExecuteReader
                    While dr.Read
                        Dim credit_year = 0
                        Dim total_point = 0
                        Dim query2 = "SELECT * FROM [employee_kpi] where [employee_id]=" & Convert.ToInt32(dr("employee_id"))
                        Using cmd2 As OleDbCommand = New OleDbCommand(query2, myConnection)
                            Using dr2 As OleDbDataReader = cmd2.ExecuteReader
                                While dr2.Read
                                    credit_year = dr2("credit_year")
                                    total_point = dr2("point")
                                End While
                            End Using
                            'table.Rows.Add(dr("employee_id"), dr("first_name"), dr("last_name"), credit_year, total_point)

                        End Using

                        Dim c1 = 0
                        Dim c2 = 0
                        Dim c3 = 0
                        Dim c4 = 0
                        Dim c5 = 0
                        Dim c6 = 0
                        Dim c7 = 0
                        Dim c8 = 0
                        Dim c9 = 0
                        Dim c10 = 0
                        Dim query3 = "SELECT * FROM [performance_evaluation] where [employee_id]=" & Convert.ToInt32(dr("employee_id"))
                        Using cmd3 As OleDbCommand = New OleDbCommand(query3, myConnection)
                            Using dr3 As OleDbDataReader = cmd3.ExecuteReader
                                While dr3.Read
                                    c1 = dr3("c1_quality_productivity")
                                    c2 = dr3("c2_flexibility")
                                    c3 = dr3("c3_initiative")
                                    c4 = dr3("c4_dependability")
                                    c5 = dr3("c5_collaboration")
                                    c6 = dr3("c6_communication")
                                    c7 = dr3("c7_problem_solving")
                                    c8 = dr3("c8_technology_skill")
                                    c9 = dr3("c9_perseverance")
                                    c10 = dr3("c10_agility")
                                End While
                            End Using
                            table.Rows.Add(dr("employee_id"), dr("first_name"), dr("last_name"), c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, credit_year, total_point)

                        End Using
                    End While
                End Using

            End Using

            datagrid.DataSource = table
            datagrid.Refresh()
            myConnection.Close()
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
    End Sub
End Class
