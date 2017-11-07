Public Class ChangePassword
    Public empId = "0"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        landing_page.PersonalDetailsComponent1.Show()
    End Sub

    Public Sub changeEmpId()
        Me.emp_id.Text = empId
    End Sub

    Private Sub btn_edit_profile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit_profile.Click
        Dim inputOldPassword = input_old_password.Text.ToString
        Dim inputNewPassword = input_new_password.Text.ToString
        Dim inputConfirmPassword = input_confirm_password.Text.ToString
        If inputNewPassword = inputConfirmPassword Then
            Dim dict = New Dictionary(Of String, String)
            dict.Add("oldPassword", Me.input_old_password.Text)
            dict.Add("newPassword", Me.input_new_password.Text)
            dict.Add("empId", Me.empId)
            Dim connectToAccess = New Connect_To_Access()
            connectToAccess.updatePassword(dict)
        Else
            MsgBox("Please make sure your new password and confirm password are equal!")
        End If
        Me.Hide()
        landing_page.PersonalDetailsComponent1.getProfile()
        landing_page.PersonalDetailsComponent1.Show()
    End Sub
End Class
