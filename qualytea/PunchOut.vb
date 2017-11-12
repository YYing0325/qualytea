Public Class PunchOut
    Public empId = ""
    Public dateTime As DateTime

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim connectToAccess = New Connect_To_Access()
        connectToAccess.punchOut(empId, dateTime)
        Me.Close()
    End Sub
End Class