Imports System.Data.OleDb

Public Class MyTraining
    Private myConnection As OleDbConnection = New OleDbConnection
    Private provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Private dataFile = My.MySettings.Default.database_path
    Private connString As Object = provider & dataFile
    Private Mode As Char = "S"
    Private CurrentID As String


    Sub handleCellClick_NewTraining(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data_grid_TrNewTraining.CellClick
        If data_grid_TrNewTraining.Columns(e.ColumnIndex).Name = "btn_accept" Then
            MsgBox("Response has been submitted. " + e.RowIndex.ToString + "   Column" + e.ColumnIndex.ToString + " collum 0：" + data_grid_TrNewTraining.Rows(e.RowIndex).Cells("ID").Value.ToString)
            doAddToInProgress(data_grid_TrNewTraining.Rows(e.RowIndex).Cells("ID").Value.ToString, landing_page.emp_id.Text.ToString)
        End If

        If data_grid_TrNewTraining.Columns(e.ColumnIndex).Name = "btn_reject" Then
            MsgBox("Response has been rejected.")
            doRejectTraining(data_grid_TrNewTraining.Rows(e.RowIndex).Cells("ID").Value.ToString, landing_page.emp_id.Text.ToString)
        End If
        Dim connectToAccessTraining = New Connect_To_Access_Training()
        connectToAccessTraining.emp_id = landing_page.emp_id.ToString
        connectToAccessTraining.getNewTrainingList(landing_page.MyTraining1.data_grid_TrNewTraining, landing_page.emp_id.Text.ToString)
        connectToAccessTraining.getInProgressTrainingList(landing_page.MyTraining1.data_grid_TrProgress, landing_page.emp_id.Text.ToString)


        'Dim dr As New System.Windows.Forms.DataGridViewRow
        'For Each dr As data_grid_TrNewTraining.SelectedRows
        'Me.data_grid_TrProgress.Rows.Add()
        'Next
    End Sub
    Sub handleCellClick_InProgress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data_grid_TrProgress.CellClick
        If data_grid_TrProgress.Columns(e.ColumnIndex).Name = "btn_completedTraining" Then
            MsgBox("Completed Training have been summitted.")
            doAddToCompletion(data_grid_TrProgress.Rows(e.RowIndex).Cells("ID").Value.ToString, landing_page.emp_id.Text.ToString)
        End If
        Dim connectToAccessTraining = New Connect_To_Access_Training()
        connectToAccessTraining.emp_id = landing_page.emp_id.ToString
        connectToAccessTraining.getInProgressTrainingList(landing_page.MyTraining1.data_grid_TrProgress, landing_page.emp_id.Text.ToString)
        connectToAccessTraining.getCompletionList(landing_page.MyTraining1.data_grid_TrComplete, landing_page.emp_id.Text.ToString)



    End Sub
    Sub handleCellClick_CompletedTraining(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data_grid_TrComplete.CellClick
        If data_grid_TrComplete.Columns(e.ColumnIndex).Name = "btn_Feedback" Then
            Dim mMyTrainingFeedback = New My_Training_Feedback
            mMyTrainingFeedback.onFeedbackShow(data_grid_TrComplete.Rows(e.RowIndex).Cells("ID").Value.ToString, data_grid_TrComplete.Rows(e.RowIndex).Cells("Code").Value.ToString, landing_page.emp_id.Text.ToString)
        End If


    End Sub
    Private Sub data_grid_TrProgress_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data_grid_TrProgress.CellContentClick


    End Sub

    Private Sub Testing()
        Dim dict As New Dictionary(Of String, String)
        'dict.Add("first_name", first_name.Text.ToString)
        'dict.Add("last_name", last_name.Text.ToString)
        'dict.Add("national_id", national_id.Text.ToString)
        'dict.Add("gender", gender.Text.ToString)
        'dict.Add("added_at", DateAndTime.Now.ToString)
        'dict.Add("email", email_address.Text.ToString)
        'dict.Add("tel_no", tel_no.Text.ToString)
        'dict.Add("position_applied", position_applied.Text.ToString)
        'dict.Add("resume", applicant_resume.ToString)
        'dict.Add("accepted", 0)
        'dict.Add("interview_date", interview_date.SelectionRange.Start.ToString("dd/MM/yyyy"))
        'dict.Add("interview_time", dropdown_interview_time.SelectedItem.ToString)
        'dict.Add("interview_venue", dropdown_interview_venue.SelectedItem.ToString)
        'dict.Add("interview_by", dropdown_interview_by.SelectedItem.ToString)
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.addToInterviewList(dict)
    End Sub

    Public Sub doAddToInProgress(ByVal TrainId As String, ByVal empId As String)
        doUpdateTrainingStatus("P", TrainId, empId)
    End Sub

    Private Sub doAddToCompletion(ByVal TrainId As String, ByVal empId As String)
        doUpdateTrainingStatus("C", TrainId, empId)
    End Sub

    Private Sub doRejectTraining(ByVal TrainId As String, ByVal empId As String)
        doUpdateTrainingStatus("R", TrainId, empId)
    End Sub

    Private Sub doUpdateTrainingStatus(ByVal Training_status As String, ByVal TrainID As String, ByVal EmpId As String)
        Me.CurrentID = TrainID
        myConnection.ConnectionString = connString
        myConnection.Open()

        Dim query1 As String
        query1 = "UPDATE employee_trainings SET status=""" + Training_status + """ WHERE employee_id=" + EmpId + " and training_id=" + TrainID
        Dim cmd As OleDbCommand = New OleDbCommand(query1, myConnection)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "OK")
        End Try
        myConnection.Close()
    End Sub
    Public Sub doGerenateData(ByVal TrainId As String, ByVal trainingCode As String, ByVal RequiredDept As String)
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim Time As DateTime = DateTime.Now
        Dim query1 = "SELECT employee_id from employees where department_id=" + RequiredDept
        Dim cmd1 As OleDbCommand = New OleDbCommand(query1, myConnection)
        Try
            Using dr1 As OleDbDataReader = cmd1.ExecuteReader
                While dr1.Read
                    If dr1.HasRows Then
                        Dim EmpID = dr1("employee_id")
                        'Dim query2 = "INSERT INTO employee_trainings SET employee_id=" + EmpID.ToString + ",training_id=" + TrainId + ",status=""N"", created_at=""" + New Date + """"
                        Dim query2 = "INSERT INTO employee_trainings(employee_id,training_id, training_code, status,created_at)VALUES(?,?,?,?,?)"
                        Console.WriteLine(query2)
                        Dim cmd2 As OleDbCommand = New OleDbCommand(query2, myConnection)
                        cmd2.Parameters.Add(New OleDbParameter("employee_id", CType(EmpID.ToString, String)))
                        cmd2.Parameters.Add(New OleDbParameter("training_id", CType(TrainId, String)))
                        cmd2.Parameters.Add(New OleDbParameter("training_code", CType(trainingCode, String)))
                        cmd2.Parameters.Add(New OleDbParameter("status", CType("N", String)))
                        cmd2.Parameters.Add(New OleDbParameter("created_at", CType(Date.Now.ToString("dd'/'MM'/'yyyy"), String)))
                        cmd2.ExecuteNonQuery()
                    End If
                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "OK")
        End Try
        myConnection.Close()
    End Sub

    Private Sub data_grid_TrComplete_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data_grid_TrComplete.CellContentClick

    End Sub


End Class
