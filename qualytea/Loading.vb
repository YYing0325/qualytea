Public Class Loading
    Public empId = ""
    Private Sub Me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Shown
        landing_page.Show()
        Dim tmr As New System.Timers.Timer()

        tmr.Interval = 5000
        tmr.Enabled = True
        tmr.Start()
        Me.Close()
        'Dim t1 As System.Threading.Thread = New System.Threading.Thread(AddressOf Me.loadingControl)
        't1.Start()
    End Sub

End Class