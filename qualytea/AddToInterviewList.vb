Public Class AddToInterviewList

    Public applicant_resume

    Private Sub btn_edit_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_profile.Click
        Dim dict As New Dictionary(Of String, String)
        dict.Add("first_name", first_name.Text.ToString)
        dict.Add("last_name", last_name.Text.ToString)
        dict.Add("national_id", national_id.Text.ToString)
        dict.Add("gender", gender.Text.ToString)
        dict.Add("added_at", DateAndTime.Now.ToString)
        dict.Add("email", email_address.Text.ToString)
        dict.Add("tel_no", tel_no.Text.ToString)
        dict.Add("position_applied", position_applied.Text.ToString)
        dict.Add("resume", applicant_resume.ToString)
        dict.Add("accepted", 0)
        dict.Add("interview_date", interview_date.SelectionRange.Start.ToString("dd/MM/yyyy"))
        dict.Add("interview_time", dropdown_interview_time.SelectedItem.ToString)
        dict.Add("interview_venue", dropdown_interview_venue.SelectedItem.ToString)
        dict.Add("interview_by", dropdown_interview_by.SelectedItem.ToString)
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.addToInterviewList(dict)
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub interview_date_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles interview_date.DateChanged

    End Sub

    Private Sub dropdown_interview_time_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dropdown_interview_time.SelectedIndexChanged

    End Sub
End Class