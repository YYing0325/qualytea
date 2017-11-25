Public Class LeaveManagement

    Private Sub datagrid_salary_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagrid_salary.CellContentClick

    End Sub

    Sub handleCellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagrid_salary.CellClick

        If datagrid_salary.Columns(e.ColumnIndex).Name = "btn_approve_salary" Then
            Dim salary = datagrid_salary.Rows(e.RowIndex).Cells("Salary").Value
            Dim employeeId = datagrid_salary.Rows(e.RowIndex).Cells("Employee ID").Value
            Dim approvedBy = Convert.ToInt32(landing_page.emp_id.Text)
            Dim epf = salary * 0.11
            Dim allowance = 100
            Dim socso = 19.75
            'To calculate the salary of the month

            Dim baseSalary = salary - epf - socso
            MsgBox(baseSalary)
            Dim connectToAccess = New Connect_To_Access_Leave()
            Dim data = New Dictionary(Of String, Integer)
            data.Add("employee_id", Convert.ToInt32(employeeId))
            data.Add("payment_amount", baseSalary)
            data.Add("overtime", 0)
            data.Add("allowance", allowance)
            data.Add("epf", epf)
            data.Add("socso", socso)
            data.Add("approved_by", approvedBy)

            connectToAccess.approveSalary(data)

        End If
        If datagrid_salary.Columns(e.ColumnIndex).Name = "btn_approve_claims" Then
            Dim claims = datagrid_salary.Rows(e.RowIndex).Cells("Claims").Value
            Dim employeeId = datagrid_salary.Rows(e.RowIndex).Cells("Employee ID").Value
            Dim approvedBy = Convert.ToInt32(landing_page.emp_id.Text)
            
            MsgBox("Your Claims Have Been Approved")
            Dim connectToAccess = New Connect_To_Access_Leave()
            Dim data = New Dictionary(Of String, Integer)
            data.Add("employee_id", Convert.ToInt32(employeeId))
            data.Add("total_amount", 150)

            connectToAccess.approveClaims(data)
        End If
        If datagrid_salary.Columns(e.ColumnIndex).Name = "btn_approve_leaves" Then
            Dim leaves = datagrid_salary.Rows(e.RowIndex).Cells("Leaves").Value
            Dim employeeId = datagrid_salary.Rows(e.RowIndex).Cells("Employee ID").Value
            Dim approvedBy = Convert.ToInt32(landing_page.emp_id.Text)

            MsgBox("Your Leaves Have Been Approved")
            Dim connectToAccess = New Connect_To_Access_Leave()
            Dim data = New Dictionary(Of String, Integer)
            data.Add("employee_id", Convert.ToInt32(employeeId))
            data.Add("total_amount", 150)

            connectToAccess.approveLeaves(data)
        End If

    End Sub

End Class
