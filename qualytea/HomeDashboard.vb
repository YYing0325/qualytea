Public Class HomeDashboard

    Private Sub btnPunchInOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPunchInOut.Click
        MsgBox(My.MySettings.Default.attendance_status)
        If My.MySettings.Default.attendance_status.ToString.Equals("checked_out") Then
            'PunchIn.Show()
            My.MySettings.Default.attendance_status = "checked_in"
        ElseIf My.MySettings.Default.attendance_status.Equals("checked_in") Then
            'PunchOut.Show()
            My.MySettings.Default.attendance_status = "checked_out"
        ElseIf My.MySettings.Default.attendance_status.Equals("") Then
            'PunchIn.Show()
            My.MySettings.Default.attendance_status = "checked_in"
        End If
    End Sub

    Private Sub dashboard_panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles dashboard_panel.Paint
        If My.MySettings.Default.attendance_status.Equals("checked_out") Then
            btnPunchInOut.Text = "Punch-In"
        ElseIf My.MySettings.Default.attendance_status.Equals("checked_in") Then
            btnPunchInOut.Text = "Punch-Out"
        ElseIf My.MySettings.Default.attendance_status.Equals("") Then
            btnPunchInOut.Text = "Punch-In"
        End If
    End Sub
End Class
