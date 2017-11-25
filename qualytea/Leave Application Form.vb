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
        landing_page.MyLeave1.Show()
        Dim empId = landing_page.emp_id.Text

        Dim connectToAccess = New Connect_To_Access_Leave
        connectToAccess.addToMyLeave(empId, cb_type_of_leave.SelectedItem, dtp_leave_from.Value, dtp_leave_until.Value, cb_reason.SelectedItem)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class