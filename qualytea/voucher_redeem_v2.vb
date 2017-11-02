Public Class voucher_redeem_v2

    Private Sub btredeem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btredeem1.Click
        MsgBox("Voucher redeem successfully. Please check your email.", MsgBoxStyle.OkOnly, "Congratulation!")
    End Sub

    Private Sub bt_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_clear.Click
        cb_voucher_id.Text = ""
    End Sub
End Class
