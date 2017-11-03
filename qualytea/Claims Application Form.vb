Public Class Claims_Application_Form

    Private Sub btapply211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btapply211.Click
        MsgBox("Your application is being processed.", MsgBoxStyle.Information, "Thank You!")
        Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtype.SelectedIndexChanged

    End Sub
End Class