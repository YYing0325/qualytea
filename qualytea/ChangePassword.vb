Public Class ChangePassword
    Public empId = "0"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        landing_page.PersonalDetailsComponent1.Show()
    End Sub

    Public Sub changeEmpId()
        Me.emp_id.Text = empId
    End Sub
End Class
