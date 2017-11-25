Imports System.Data.OleDb

Public Class My_Training_Feedback
    Dim CurrentTrainingId As String
    Dim CurrentEmpID As String
    Dim CurrentCourseName As String
    Private Sub tr_Feedbackform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_cancel103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cancel103.Click
        Me.Close()
    End Sub

    Private Sub bt_submit103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_submit103.Click
        doSubmitFeedback()
        MsgBox("Successful Submit !!!", MsgBoxStyle.OkOnly, "Record Submitted G1 :")
        My.Forms.landing_page.TrainingManagement1.RefeshDataGrid()
        Me.Close()
    End Sub
    Private Function GetFeedbackValue(ByVal mObj As Object) As Integer
        Dim mGroupbox As GroupBox = mObj
        Dim value As Integer
        For Each rbButton As RadioButton In mGroupbox.Controls
            If rbButton.Checked Then
                value = CInt(rbButton.Name.Substring(rbButton.Name.Length - 1))
            End If
        Next
        Return value
    End Function
    Private Sub doSubmitFeedback()
        Dim Q1 As Integer = GetFeedbackValue(GroupBox1)
        Dim Q2 As Integer = GetFeedbackValue(GroupBox2)
        Dim Q3 As Integer = GetFeedbackValue(GroupBox3)
        Dim Q4 As Integer = GetFeedbackValue(GroupBox4)
        Dim Q5 As Integer = GetFeedbackValue(GroupBox5)
        Dim myConnection As OleDbConnection = New OleDbConnection
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        Dim dataFile = My.MySettings.Default.database_path
        Dim connString As Object = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim query1 = "INSERT INTO training_feedback(training_id,code_id,employee_id,Completion_Time,Q1,Q2,Q3,Q4,Q5)VALUES(?,?,?,?,?,?,?,?,?)"
        Dim cmd1 As OleDbCommand = New OleDbCommand(query1, myConnection)
        Try
            cmd1.Parameters.Add(New OleDbParameter("Training_id", CType(CInt(CurrentTrainingId), Integer)))
            cmd1.Parameters.Add(New OleDbParameter("code_id", CType(CurrentCourseName, String)))
            cmd1.Parameters.Add(New OleDbParameter("employee_id", CType(CInt(CurrentEmpID), Integer)))
            cmd1.Parameters.Add(New OleDbParameter("Completion_Time", CType(Date.Now.ToString("dd'/'MM'/'yyyy"), String)))
            cmd1.Parameters.Add(New OleDbParameter("Q1", CType(Q1, String)))
            cmd1.Parameters.Add(New OleDbParameter("Q2", CType(Q2, String)))
            cmd1.Parameters.Add(New OleDbParameter("Q3", CType(Q3, String)))
            cmd1.Parameters.Add(New OleDbParameter("Q4", CType(Q4, String)))
            cmd1.Parameters.Add(New OleDbParameter("Q5", CType(Q5, String)))
            cmd1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Connection To Database Failed:" & ex.Message.ToString)
        End Try
        myConnection.Close()
    End Sub

    Public Sub onFeedbackShow(ByVal TrainId As String, ByVal CourseName As String, ByVal empId As String)
        CurrentTrainingId = TrainId
        CurrentEmpID = empId
        CurrentCourseName = CourseName
        'lbl_FeedbackHeader.Text = "Employee: " + empId + "For course: " + TrainId
        Me.Show()
    End Sub
End Class