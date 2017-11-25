Public Class MyLeave

    Private Sub cbmonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbmonth.SelectedIndexChanged
        Dim intSelectedIndex As Integer
        intSelectedIndex = cbmonth.SelectedIndex
        Dim connectToAccess = New Connect_To_Access_Leave()
        Dim dict As Dictionary(Of String, String) = connectToAccess.getPayrollByMonth(landing_page.emp_id.Text, intSelectedIndex)
        If (dict.ContainsKey("payment_amount")) Then
            Me.lbbasic_salary280.Text = dict("payment_amount")
            Me.lbovertime280.Text = dict("overtime")
            Me.lballowance280.Text = dict("allowance")
            Me.lbepf280.Text = dict("epf")
            Me.lbsocso280.Text = dict("socso")
            Me.lbclaims280.Text = dict("claims")
            Dim total As Int32 = Convert.ToInt32(dict("payment_amount")) + Convert.ToInt32(dict("overtime")) + Convert.ToInt32(dict("allowance")) + Convert.ToInt32(dict("epf")) + Convert.ToInt32(dict("socso")) + Convert.ToInt32(dict("claims"))
            Me.lbtotal280.Text = total
        Else
            MsgBox("The salary for the month is not yet out.")
        End If

    End Sub

    Private Sub lbnew_leave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbnew_leave.Click
        Leave_Application_Form.Show()
        Me.Hide()
    End Sub
End Class
