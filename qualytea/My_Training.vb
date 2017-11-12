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

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel1.Paint

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

    Private Sub btn_trGenerateData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_trGenerateData.Click
        Dim currentId As String = Me.DataGridView2.CurrentRow.Cells(0).Value.ToString
        Dim currentCourse As String = Me.DataGridView2.CurrentRow.Cells(1).Value.ToString
        Dim editFrom As New My_Training_AddNew
        editFrom.doGenerateData(currentId, currentCourse)
    End Sub
End Class
