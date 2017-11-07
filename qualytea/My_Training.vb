Public Class My_Training
    Private Sub btn_trAddNew102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_trAddNew102.Click
        My_Training_AddNew.onAddNewLoad()
        My_Training_AddNew.Show()
    End Sub
    Public Sub RefeshDataGrid()
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.getTrainingManagementList(Me.DataGridView2)
    End Sub

    Private Sub btn_trdetails102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_trdetails102.Click
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.getTrainingManagementList(me.DataGridView2)
    End Sub

    Private Sub btn_tredit102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tredit102.Click

        Dim currentRow As Integer = Me.DataGridView2.CurrentRow.Index
        Dim currentCell As Integer = Me.DataGridView2.CurrentCell.RowIndex
        Dim currentDataID As String = Me.DataGridView2.Rows(currentRow).Cells(0).Value.ToString
        Dim currentId As String = Me.DataGridView2.CurrentRow.Cells(0).Value.ToString
        MsgBox(currentId, MsgBoxStyle.OkOnly, "ok")
    End Sub


    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView2.Click
        Dim currentId As String = Me.DataGridView2.CurrentRow.Cells(0).Value.ToString
        Dim editFrom As New My_Training_AddNew
        editFrom.OnEditLoad(currentId, "c")
        'editFrom.ShowDialog()
        'editFrom.ShowDialog()
    End Sub
End Class
