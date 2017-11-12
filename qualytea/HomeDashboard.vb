Public Class HomeDashboard

    Private Sub btnPunchInOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPunchInOut.Click

        If My.MySettings.Default.attendance_status.ToString.Equals("checked_out") Then

            Dim punchIn = New PunchIn()
            punchIn.Show()
            punchIn.empId = landing_page.emp_id.Text.ToString
            punchIn.dateTime = DateTime.Now
            punchIn.currentTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        ElseIf My.MySettings.Default.attendance_status.Equals("checked_in") Then
            Dim punchOut = New PunchOut()
            punchOut.Show()
            punchOut.empId = landing_page.emp_id.Text.ToString
            punchOut.dateTime = DateTime.Now
            punchOut.currentTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        ElseIf My.MySettings.Default.attendance_status.Equals("") Then
            Dim punchIn = New PunchIn()
            punchIn.Show()
            punchIn.empId = landing_page.emp_id.Text.ToString
            punchIn.dateTime = DateTime.Now
            punchIn.currentTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
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
