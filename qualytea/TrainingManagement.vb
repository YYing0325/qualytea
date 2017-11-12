Public Class TrainingManagement

    Private Sub btn_trAddNew102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_trAddNew102.Click
        My_Training_AddNew.onAddNewLoad()
        My_Training_AddNew.Show()
    End Sub
    Public Sub RefeshDataGrid()
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.getTrainingManagementList(Me.DataGridView2)
    End Sub

    Private Sub DataGridView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView2.Click
        'Dim currentId As String = Me.DataGridView2.CurrentRow.Cells(0).Value.ToString
        'Dim editFrom As New My_Training_AddNew
        'editFrom.OnEditLoad(currentId, "c")
        'editFrom.ShowDialog()
        'editFrom.ShowDialog()
    End Sub
End Class
