Public Class My_Training_Detail

    Private Sub lb_code105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_trcode105.Click

    End Sub

    Private Sub My_Training_Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connectToAccess = New Connect_To_Access_Training()
        Dim list = connectToAccess.getTrainingCodeList()
        cmb_code.DataSource = list
        cmb_code.SelectedItem = -1
        Dim course = connectToAccess.getTrainingNameByCode(list.Item(0))
        lbl_course_name.Text = course
        connectToAccess.getTrainingDetailList(Data_GridView_Detail, list.Item(0))
    End Sub

    Private Sub cmb_code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_code.SelectedIndexChanged
        Dim connectToAccess = New Connect_To_Access_Training()
        Dim course = connectToAccess.getTrainingNameByCode(cmb_code.SelectedItem)
        lbl_course_name.Text = course
        connectToAccess.getTrainingDetailList(Data_GridView_Detail, cmb_code.SelectedItem)
    End Sub
End Class