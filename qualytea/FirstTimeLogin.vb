Public Class FirstTimeSignUp

    Private Sub FirstTimeSignUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_next_FirstTimeUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Dim connectToAccess = New Connect_To_Access()
        Dim username = tbusername.Text.ToString
        Dim password = mtbpassword.Text.ToString
        Dim confirmPassword = mtbconfirmedpassword.Text.ToString
        Dim empId = tbemployeeID.Text.ToString

        Dim dictionary As New Dictionary(Of String, String)
        dictionary.Add("username", username)
        dictionary.Add("password", password)
        dictionary.Add("employee_id", empId)

        If password = confirmPassword Then
            'connectToAccess.registerUser(dictionary)
            FirstTimeLogin2.Show()
            FirstTimeLogin2.setEmpId(empId)
            Me.Hide()
        Else
            MsgBox("Password does not match!")
        End If
    End Sub
End Class