Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class My_Training_AddNew

    Private myConnection As OleDbConnection = New OleDbConnection
    Private provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Private dataFile = My.MySettings.Default.database_path
    Private connString As Object = provider & dataFile
    Private Mode As Char = "S"
    Private CurrentID As String = ""

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub bt_submit101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_submit101.Click
        Dim txtTrainingType As String = GetTrainingTypeList()

        'Dim myConnection As OleDbConnection = New OleDbConnection
        'Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Dim dataFile = My.MySettings.Default.database_path
        'Dim connString As Object = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim query1 As String
        query1 = "INSERT INTO trainings (training_code,training_name,training_type_id,training_description,training_datetime,training_time,Expired_at,Venue,created_at,created_by,required_dept,required_role,required_Status)VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(query1, myConnection)
        cmd.Parameters.Add(New OleDbParameter("training_code", CType(txt_trCode101.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("training_name", CType(txt_trCourse101.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("training_type_id", CType("2", String)))
        cmd.Parameters.Add(New OleDbParameter("training_description", CType(txt_courseDesc101.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("training_datetime", CType(dtp_trDate101.Value.ToString, String)))
        cmd.Parameters.Add(New OleDbParameter("training_time", CType(txt_trTime101.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Expired_at", CType(New DateTime, String)))
        cmd.Parameters.Add(New OleDbParameter("Venue", CType(cbx_trVenue101.SelectedValue.ToString, String)))
        cmd.Parameters.Add(New OleDbParameter("created_at", CType(New DateTime, String)))
        cmd.Parameters.Add(New OleDbParameter("created_by", CType("5", String)))
        cmd.Parameters.Add(New OleDbParameter("required_dept", CType(txtTrainingType, String)))
        cmd.Parameters.Add(New OleDbParameter("required_role", CType(cbx_trRoles101.SelectedValue.ToString, String)))
        cmd.Parameters.Add(New OleDbParameter("required_Status", CType(cbx_trStatus101.SelectedItem.ToString, String)))
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Successful Submit !!!", MsgBoxStyle.OkOnly, "Record Submitted")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "OK")
        End Try
        myConnection.Close()
        My.Forms.landing_page.My_Training.RefeshDataGrid()
        Me.Close()
    End Sub

    Private Sub bt_cancel101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel101.Click
        Me.Close()
    End Sub


    Private Sub My_Training_AddNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRDataSet.jobs' table. You can move, or remove it, as needed.
        Me.JobsTableAdapter.Fill(Me.HRDataSet.jobs)
        
    End Sub
    Private Sub LoadLocationFromDatabase()
        'TODO: This line of code loads data into the 'HRDataSet.locations' table. You can move, or remove it, as needed.
        Me.HRDataSet.Clear()

        Me.LocationsTableAdapter.Fill(Me.HRDataSet.locations)
        Me.JobsTableAdapter.Fill(Me.HRDataSet.jobs)
    End Sub

    Private Sub cbx_trVenue101_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_trVenue101.SelectedIndexChanged
        'MsgBox(cbx_trVenue101.SelectedValue.ToString, MsgBoxStyle.OkOnly, "oK")
    End Sub

    Private Sub dtp_trDate101_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_trDate101.ValueChanged

    End Sub

    Private Sub LocationsBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationsBindingSource.CurrentChanged

    End Sub

    Public Sub OnEditLoad(ByVal id As String, ByVal mode As Char)
        Me.CurrentID = id
        Me.bt_submit101.Enabled = False
        Me.bt_submit101.Visible = False
        Me.bt_Save101.Enabled = True
        Me.bt_Save101.Visible = True
        Me.LoadLocationFromDatabase()
        'Dim cbxTrainigtype As CheckBox = tr_gpbx101.
        'Dim txtTrainingType As String = GetTrainingTypeList()

        Try
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim query1 As String
            query1 = "SELECT * FROM [trainings] where [training_id]=?"
            Dim cmd As OleDbCommand = New OleDbCommand(query1, myConnection)
            cmd.Parameters.AddWithValue("@p1", id)
            Using dr2 As OleDbDataReader = cmd.ExecuteReader
                While dr2.Read
                    If dr2.HasRows Then
                        txt_trCode101.Text = dr2("training_code").ToString
                        txt_trCourse101.Text = dr2("training_name").ToString
                        txt_courseDesc101.Text = dr2("training_description").ToString
                        dtp_trDate101.Value = dr2("training_datetime").ToString
                        txt_trTime101.Text = dr2("training_time").ToString
                        cbx_trVenue101.SelectedValue = dr2("venue").ToString
                        cbx_trRoles101.SelectedValue = dr2("required_role").ToString
                        cbx_trStatus101.SelectedValue = dr2("required_status").ToString
                        Dim txtTrainingType As String = dr2("required_dept").ToString
                        Dim patern As String = "\,"
                        Dim TrainingTypeList() As String = Regex.Split(txtTrainingType, ",")
                        For Each trainingtype As String In TrainingTypeList
                            Select Case trainingtype
                                Case StrComp(trainingtype.Trim, "14")
                                    Console.WriteLine(trainingtype.ToString)
                                Case trainingtype.Equals("2")
                                    cb_trFinanceDept.Checked = True
                                Case trainingtype.Equals("3")
                                    cb_trHRDept.Checked = True
                                Case trainingtype.Equals("4")
                                    cb_trTaxDepartment.Checked = True
                                Case trainingtype.Equals("5")
                                    cb_trSafetyDept.Checked = True
                                Case trainingtype.Equals("6")
                                    cb_trSalesDept.Checked = True
                                Case trainingtype.Equals("7")
                                    cb_trPurchasingDept.Checked = True
                            End Select

                        Next

                        'cbx_trVenue101.SelectedIndex = cbx_trVenue101.SelectedIndex(cbx_trVenue101.SelectedValue)
                        'cbx_trVenue101.SelectedIndex = cbx_trVenue101.FindString(cbx_trVenue101.Text)
                        'cbx_trVenue101.SelectedValue = cbx_trVenue101.FindString(dr2("venue").ToString)
                        'cbx_trVenue101.SelectedValue(dr2("venue").ToString).
                    End If
                End While
            End Using
            myConnection.Close()
            Me.ShowDialog()
        Catch ex As Exception
            MsgBox("Exceptiion: " + ex.Message, MsgBoxStyle.OkOnly, "OK")
        End Try
    End Sub

    Private Sub BTN_OnEditeSave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Save101.Click
        Dim txtTrainingType As String = GetTrainingTypeList()
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim query1 As String
        query1 = "UPDATE [trainings] SET [training_code]=""" + txt_trCode101.Text
        query1 += """ ,[training_name]=""" + txt_trCourse101.Text
        query1 += """ ,[training_type_id]=""2"" ,[training_description]=""" + txt_courseDesc101.Text
        query1 += """ ,[training_datetime]=""" + dtp_trDate101.Value.ToString
        query1 += """ ,[training_time]=""" + txt_trTime101.Text
        query1 += """ ,[Expired_at]=""" + New DateTime
        query1 += """ ,[Venue]=""" + cbx_trVenue101.SelectedValue.ToString
        query1 += """ ,[created_at]=""" + New DateTime
        query1 += """ ,[created_by]=""" + "5"
        query1 += """ ,[required_role]=""" + cbx_trRoles101.SelectedValue.ToString
        query1 += """ ,[required_status]=""" + cbx_trStatus101.SelectedItem.ToString
        query1 += """ ,[required_dept]=""" + txtTrainingType.ToString
        query1 += """  WHERE [training_id]=" + Me.CurrentID + ""

        Dim cmd As OleDbCommand = New OleDbCommand(query1, myConnection)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Successful Submit !!!", MsgBoxStyle.OkOnly, "Record Submitted")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "OK")
        End Try
        myConnection.Close()
        My.Forms.landing_page.My_Training.RefeshDataGrid()
        Me.Close()
    End Sub

    Public Sub onAddNewLoad()
        Me.bt_submit101.Enabled = True
        Me.bt_submit101.Visible = True
        Me.bt_Save101.Enabled = False
        Me.bt_Save101.Visible = False
        Me.LoadLocationFromDatabase()
    End Sub
    'TODO: Get Value from checkbox and combine into a string seperated by comma (,)
    Public Function GetTrainingTypeList() As String
        '****************get checked box item set as training type, ready to save as required department*****
        '**** start *****
        Dim txtTrainingType As String = ""
        For Each gbCheck As CheckBox In tr_gpbx101.Controls
            If gbCheck.Checked Then
                'gbCheckList += "   " & gbCheck.Text
                Select Case gbCheck.Text
                    Case "Finance Department"
                        txtTrainingType += "8,"
                    Case "Human Resourse and Administration Department"
                        txtTrainingType += "2,"
                    Case "Tax Department"
                        txtTrainingType += "9,"
                    Case "Food Safety and Environmental Department"
                        txtTrainingType += "10,"
                    Case "Sales and Marketing Department"
                        txtTrainingType += "11,"
                    Case "Purchasing Department"
                        txtTrainingType += "12,"
                End Select
            End If
        Next
        If String.IsNullOrEmpty(txtTrainingType) Then
            txtTrainingType = ""
        Else
            txtTrainingType = txtTrainingType.Substring(0, txtTrainingType.LastIndexOf(","))
        End If
        Return txtTrainingType
    End Function

    Private Sub My_Training_Panel101_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles My_Training_Panel101.Paint

    End Sub

    Private Sub lb_tr_code101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_tr_code101.Click

    End Sub

    Private Sub txt_trCode101_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_trCode101.TextChanged

    End Sub

    Public Sub doDeleteRecord(ByVal id As String, ByVal CourseName As String)
        Me.CurrentID = id

        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim query1 As String
        query1 = "delete FROM [trainings] where [training_id]=" + CurrentID
        Dim cmd As OleDbCommand = New OleDbCommand(query1, myConnection)
        Dim MsgBoxResult = MsgBox("Are you want to permanently delete this record? : " + CourseName, MsgBoxStyle.YesNo, "Delete Record!!")

        If MsgBoxResult = Microsoft.VisualBasic.MsgBoxResult.Yes Then
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Successful Deleted !!!", MsgBoxStyle.OkOnly, "Record Deleted")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "OK")
            End Try
        End If
        myConnection.Close()
        My.Forms.landing_page.My_Training.RefeshDataGrid()

    End Sub

    Public Sub doGenerateData(ByVal id As String, ByVal status As String)
        Me.CurrentID = id
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim query1 As String
        Dim query2 As String
        query1 = "Select [required_role],[required_status], [required_dept] From trainings where training_id=?"
        Dim cmd As OleDbCommand = New OleDbCommand(query1, myConnection)
        cmd.Parameters.AddWithValue("@p1", CurrentID)
        Try
            Using dr2 As OleDbDataReader = cmd.ExecuteReader
                While dr2.Read
                    If dr2.HasRows Then
                        query2 = "select employee_id From employees where first_time=? and job_id=? and department_id=?"
                        Dim cmd2 As OleDbCommand = New OleDbCommand(query2, myConnection)

                        If String.Equals(dr2("required_status").ToString, "New Employee") Then
                            cmd2.Parameters.AddWithValue("@p1", "Y")
                        Else
                            cmd2.Parameters.AddWithValue("@p1", "N")
                        End If
                        cmd2.Parameters.AddWithValue("@p2", dr2("required_role").ToString)

                        Dim txtRequiredDept As String = dr2("required_dept").ToString
                        Dim patern As String = "\,"
                        Dim DepartmentList() As String = Regex.Split(txtRequiredDept, ",")

                        For Each dept_id As String In DepartmentList
                            cmd2.Parameters.AddWithValue("@p3", dept_id.ToString)
                            Console.WriteLine(dept_id)
                            Using dr3 As OleDbDataReader = cmd2.ExecuteReader
                                While dr3.Read
                                    If dr3.HasRows Then
                                        Dim query3 = "insert into employee_trainings (training_id,employee_id,created_at)values(?,?,?)"
                                        Dim cmd3 As OleDbCommand = New OleDbCommand(query3, myConnection)
                                        cmd3.Parameters.AddWithValue("@p1", CurrentID)
                                        cmd3.Parameters.AddWithValue("@p2", dr3("employee_id"))
                                        cmd3.ExecuteNonQuery()
                                    End If
                                End While
                            End Using

                        Next

                        'cmd2.Parameters.AddWithValue("@p3", dr2("required_dept").ToString)

                    End If
                End While
            End Using
            'cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "OK")
        End Try
        myConnection.Close()

    End Sub

    Private Sub cbx_trRoles101_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_trRoles101.SelectedIndexChanged

    End Sub

    Private Sub cbx_trStatus101_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_trStatus101.SelectedIndexChanged

    End Sub
End Class
