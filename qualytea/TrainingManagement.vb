Imports System.Data.OleDb

Public Class TrainingManagement
    Public m_myTraining As New MyTraining
    Private Sub btn_trAddNew102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_trAddNew102.Click
        My_Training_AddNew.onAddNewLoad()
        My_Training_AddNew.Show()
    End Sub
    Public Sub RefeshDataGrid()
        Dim connectToAccess = New Connect_To_Access_Training()
        connectToAccess.getTrainingManagementList(Me.DataGridView2)
    End Sub

    Private Sub btn_trdetails102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_trdetails102.Click
        My_Training_Detail.Show()
        'Dim connectToAccess = New Connect_To_Access()
        'connectToAccess.getTrainingManagementList(Me.DataGridView2)
    End Sub

    Private Sub btn_tredit102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tredit102.Click

        'Dim currentRow As Integer = Me.DataGridView2.CurrentRow.Index
        'Dim currentCell As Integer = Me.DataGridView2.CurrentCell.RowIndex
        'Dim currentDataID As String = Me.DataGridView2.Rows(currentRow).Cells(0).Value.ToString
        'Dim currentId As String = Me.DataGridView2.CurrentRow.Cells(0).Value.ToString
        'MsgBox(currentId, MsgBoxStyle.OkOnly, "ok")

        Dim currentId As String = Me.DataGridView2.CurrentRow.Cells(0).Value.ToString
        Dim editFrom As New My_Training_AddNew
        editFrom.OnEditLoad(currentId, "c")
    End Sub


    Private Sub DataGridView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView2.Click
        'Dim currentId As String = Me.DataGridView2.CurrentRow.Cells(0).Value.ToString
        'Dim editFrom As New My_Training_AddNew
        'editFrom.OnEditLoad(currentId, "c")
        'editFrom.ShowDialog()
        'editFrom.ShowDialog()

    End Sub

    Private Sub DataGridView2_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentDoubleClick
        Dim currentId As String = Me.DataGridView2.CurrentRow.Cells(0).Value.ToString
        Dim editFrom As New My_Training_AddNew
        editFrom.OnEditLoad(currentId, "c")
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btn_trdelete102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_trdelete102.Click
        Dim currentId As String = Me.DataGridView2.CurrentRow.Cells(0).Value.ToString
        Dim currentCourse As String = Me.DataGridView2.CurrentRow.Cells(1).Value.ToString
        Dim editFrom As New My_Training_AddNew
        'editFrom.OnEditLoad(currentId, "c")
        editFrom.doDeleteRecord(currentId, currentCourse)


    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub
    Sub handleCellClick_Generate(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If DataGridView2.Columns(e.ColumnIndex).Name = "btn_Generate" Then
            m_myTraining.doGerenateData(DataGridView2.Rows(e.RowIndex).Cells("ID").Value.ToString, DataGridView2.Rows(e.RowIndex).Cells("Code").Value.ToString, DataGridView2.Rows(e.RowIndex).Cells("Required Dept").Value.ToString)
            MsgBox("Response have been generate")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_feedback101.SelectedIndexChanged
        Dim myConnection As OleDbConnection = New OleDbConnection
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        Dim dataFile = My.MySettings.Default.database_path
        Dim connString As Object = provider & dataFile
        Dim selectedId = cbx_feedback101.SelectedItem.ToString.Split("-")

        If selectedId.Length > 1 Then
            Try
                myConnection.ConnectionString = connString
                Dim query = "SELECT Employees.First_name, Employees.Last_name,training_feedback.Q1,training_feedback.Q2,training_feedback.Q3,training_feedback.Q4,training_feedback.Q5 FROM training_feedback left join Employees ON training_feedback.employee_id = employees.employee_id where training_id=?" 'this will show all training course
                Dim table As New DataTable
                table.Columns.Add("Frisr Name", GetType(String))
                table.Columns.Add("Last Name", GetType(String))
                table.Columns.Add("Q1", GetType(String))
                table.Columns.Add("Q2", GetType(String))
                table.Columns.Add("Q3", GetType(String))
                table.Columns.Add("Q4", GetType(String))
                table.Columns.Add("Q5", GetType(String))

                Using cmd As OleDbCommand = New OleDbCommand(query, myConnection)
                    myConnection.Open()
                    cmd.Parameters.AddWithValue("@p1", selectedId(0))
                    Using dr As OleDbDataReader = cmd.ExecuteReader
                        While dr.Read
                            table.Rows.Add(dr("First_name"), dr("Last_name"), dr("Q1"), dr("Q2"), dr("Q3"), dr("Q4"), dr("Q5"))

                        End While

                    End Using

                End Using
                dataGrid_Feedback.DataSource = table
                dataGrid_Feedback.Refresh()
                myConnection.Close()
            Catch ex As Exception
                MsgBox("Connection To Database Failed:" & ex.Message.ToString)
            End Try
        End If

    End Sub
End Class
