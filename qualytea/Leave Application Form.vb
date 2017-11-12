Public Class Leave_Application_Form

    Private Sub Leave_Application_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_apply.Click

        MsgBox("Your application is being processed.", MsgBoxStyle.Information, "Thank You!")
        Close()
        Dim connectToAccess = New Connect_To_Access
        connectToAccess.getEmployeeLeaves(landing_page.Leave_H_Management1.datagrid_leave_history, landing_page.emp_id.Text.ToString)
        connectToAccess.getEmployeeLeavesRequest(landing_page.Leave_H_Management1.datagrid_leave_request, landing_page.emp_id.Text.ToString)
        landing_page.Leave_H_Management1.Show()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class