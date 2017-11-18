Public Class PerformanceManagement

    Private Sub bt_clear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_clear1.Click
        cb_department.Text = ""
        cb_emp_name.Text = ""
        cb_pf1.Text = ""
        cb_pf2.Text = ""
        cb_pf3.Text = ""
        cb_pf4.Text = ""
        cb_pf5.Text = ""
        cb_pf6.Text = ""
        cb_pf7.Text = ""
        cb_pf8.Text = ""
        cb_pf9.Text = ""
        cb_pf10.Text = ""
    End Sub

    Private Sub btsubmit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsubmit1.Click
        'Calculation
        Dim c1 = cb_pf1.SelectedIndex
        Dim c2 = cb_pf2.SelectedIndex
        Dim c3 = cb_pf3.SelectedIndex
        Dim c4 = cb_pf4.SelectedIndex
        Dim c5 = cb_pf5.SelectedIndex
        Dim c6 = cb_pf6.SelectedIndex
        Dim c7 = cb_pf7.SelectedIndex
        Dim c8 = cb_pf8.SelectedIndex
        Dim c9 = cb_pf9.SelectedIndex
        Dim c10 = cb_pf10.SelectedIndex
        Dim TotalPoint = c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10
        MsgBox(TotalPoint)
        Dim connectToAccess = New Connect_To_Access
        Dim dict = New Dictionary(Of String, Int32)

        dict.Add("department_id", 2)
        dict.Add("employee_id", 7)
        dict.Add("performance_year", 2017)
        dict.Add("c1_quality_productivity", cb_pf1.SelectedIndex)
        dict.Add("c2_flexibility", cb_pf2.SelectedIndex)
        dict.Add("c3_initiative", cb_pf3.SelectedIndex)
        dict.Add("c4_dependability", cb_pf4.SelectedIndex)
        dict.Add("c5_collaboration", cb_pf5.SelectedIndex)
        dict.Add("c6_communication", cb_pf6.SelectedIndex)
        dict.Add("c7_problem_solving", cb_pf7.SelectedIndex)
        dict.Add("c8_technology_skill", cb_pf8.SelectedIndex)
        dict.Add("c9_perseverance", cb_pf9.SelectedIndex)
        dict.Add("c10_agility", cb_pf10.SelectedIndex)
        dict.Add("point", TotalPoint)

        connectToAccess.addToEvaluation(dict)
        connectToAccess.addTotalPoint(dict)
    End Sub

    Private Sub cb_department_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_department.SelectedIndexChanged
        Dim dep As String = Me.cb_department.SelectedItem
        Dim departmentId = 2
        If dep = "" Then
        ElseIf dep = "Administration" Then
            departmentId = 2
        ElseIf dep = "Human Resource" Then
            departmentId = 7
        End If
        Dim list As New List(Of String)
        list.Clear()
        cb_emp_name.Items.Clear()
        Dim connectToAccess = New Connect_To_Access_Performance()


        list = connectToAccess.getEmployeesNameByDepartment(departmentId)
        For Each i In list
            cb_emp_name.Items.Add(i)
        Next
        cb_emp_name.Refresh()
    End Sub

End Class
