Public Class Claims_Application_Form

    Private Sub btapply211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btapply211.Click
        MsgBox("Your application is being processed.", MsgBoxStyle.Information, "Thank You!")
        Close()
        Dim connectToAccess = New Connect_To_Access
        connectToAccess.getClaimsList(landing_page.Payroll_H_Management1.datagrid_payroll_mgmt, landing_page.emp_id.Text.ToString)
        connectToAccess.getClaimsStatus(landing_page.Payroll_H_Management1.datagrid_payroll_mgmt, landing_page.emp_id.Text.ToString)
        landing_page.Payroll_H_Management1.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtype.SelectedIndexChanged

    End Sub
End Class