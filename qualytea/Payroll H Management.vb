Imports System.Data.OleDb

Public Class Payroll_H_Management
    Public empId = "0"
    Private Sub FormOnLoad(ByVal ByValsender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim connectToAccess = New Connect_To_Access()
        Dim dict = connectToAccess.getSalary(4)
        Me.lbbasic_salary280.Text = dict.Item("basic_salary").ToString
        Me.lbovertime280.Text = dict.Item("overtime").ToString
        Me.lballowance280.Text = dict.Item("allowance").ToString
        Me.lbepf280.Text = dict.Item("epf").ToString
        Me.lbsocso280.Text = dict.Item("socso").ToString
        Me.lbclaims280.Text = dict.Item("claims").ToString
        Me.lbothers280.Text = dict.Item("others").ToString

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new_claim.Click
        Claims_Application_Form.Show()
        Me.Hide()

    End Sub
End Class
