Imports System.Data.OleDb
Public Class performance_overview
    Public empId = "0"
    Private Sub FormOnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim connectToAccess = New Connect_To_Access()
        Dim dict = connectToAccess.getEvaluation(4, "2017")
        Me.emp_dept.Text = dict.Item("department").ToString
        Me.emp_first_name.Text = dict.Item("first_name").ToString
        Me.emp_last_name.Text = dict.Item("last_name").ToString
        Me.perf_year.Text = dict.Item("performance_year").ToString
        Me.c1_mark.Text = dict.Item("c1_quality_productivity").ToString
        Me.c2_mark.Text = dict.Item("c2_flexibility").ToString
        Me.c3_mark.Text = dict.Item("c3_initiative").ToString
        Me.c4_mark.Text = dict.Item("c4_dependability").ToString
        Me.c5_mark.Text = dict.Item("c5_collaboration").ToString
        Me.c6_mark.Text = dict.Item("c6_communication").ToString
        Me.c7_mark.Text = dict.Item("c7_problem_solving").ToString
        Me.c8_mark.Text = dict.Item("c8_technology_skill").ToString
        Me.c9_mark.Text = dict.Item("c9_perseverance").ToString
        Me.c10_mark.Text = dict.Item("c10_agility").ToString

        'Calculation
        Dim c1 As Integer
        Dim c2 As Integer
        Dim c3 As Integer
        Dim c4 As Integer
        Dim c5 As Integer
        Dim c6 As Integer
        Dim c7 As Integer
        Dim c8 As Integer
        Dim c9 As Integer
        Dim c10 As Integer
        Dim total As Integer

        c1 = c1_mark.Text
        c2 = c2_mark.Text
        c3 = c3_mark.Text
        c4 = c4_mark.Text
        c5 = c5_mark.Text
        c6 = c6_mark.Text
        c7 = c7_mark.Text
        c8 = c8_mark.Text
        c9 = c9_mark.Text
        c10 = c10_mark.Text
        total = c1 + c2 + c4 + c5 + c6 + c7 + c8 + c9 + c10
        Me.c_avg_mark.Text = total
        Me.lb_available_point.Text = total

    End Sub
    
    Private Sub bt_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_clear.Click
        rb_aeon.Checked = False
        rb_cosas_united.Checked = False
        rb_court_mammoth.Checked = False
        rb_ikea.Checked = False
        rb_samsung.Checked = False
        rb_senheng.Checked = False
        rb_tesco.Checked = False
        rb_universal_traveller.Checked = False
        rb_watson.Checked = False
        rb_yu_yan_sang.Checked = False
        rb_rm20.Checked = False
        rb_rm50.Checked = False
        rb_rm100.Checked = False
    End Sub

    Private Sub btredeem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btredeem1.Click
        MsgBox("Voucher redeem successfully. Please check your email.", MsgBoxStyle.OkOnly, "Congratulation!")
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
