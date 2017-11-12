
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Connect_To_SQL

    'Dim connection As New SqlConnection("Data Source=qualytea.000webhostapp.com,3306; Network Library=DBMSSOCN; Initial Catalog= ")
    Public Sub connect()
        Dim conn = New MySqlConnection("Server=sql122.main-hosting.eu; Uid=u483372381_ajemu; Pwd=qualytea; Database=u483372381_yvusa")
        Try
            conn.Open()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Cannot connect to database")

        End Try
    End Sub

    Public Sub getApplicantsData(ByVal dataGrid As DataGridView)
        Dim conn = New MySqlConnection("Server=sql122.main-hosting.eu; Uid=u483372381_ajemu; Pwd=qualytea; Database=u483372381_yvusa")

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("Select form_value from bsnu_db7_forms", conn)
            Dim table As New DataTable
            table.Columns.Add("Status", GetType(String))
            table.Columns.Add("First Name", GetType(String))
            table.Columns.Add("Last Name", GetType(String))
            table.Columns.Add("Gender", GetType(String))
            table.Columns.Add("National Id", GetType(String))
            table.Columns.Add("Email", GetType(String))
            table.Columns.Add("Tel No", GetType(String))
            table.Columns.Add("Position Applied", GetType(String))
            table.Columns.Add("Qualification", GetType(String))
            table.Columns.Add("Academic Result", GetType(String))
            table.Columns.Add("Resume", GetType(String))

            Dim data = cmd.ExecuteReader()
            While data.Read
                If data.HasRows = True Then
                    Dim str = Convert.ToString(data(0))
                    Dim flist = convertStringToList(str)
                    table.Rows.Add(flist(0), flist(1), flist(2), flist(3), flist(4), flist(5), flist(6), flist(7), flist(8), flist(9), "qualytea.xyz/wp-content/uploads/cfdb7_uploads/" & flist(10))
                End If
            End While
            dataGrid.DataSource = table
            Dim btn As New DataGridViewButtonColumn()
            If dataGrid.ColumnCount.Equals(11) Then
                dataGrid.Columns.Add(btn)
                btn.HeaderText = "Download Resume"
                btn.Text = "Download Resume"
                btn.Name = "btn_dl_resume"
                btn.ToolTipText = "Download the resume for preview"
                btn.UseColumnTextForButtonValue = True

                Dim inviteForInterview As New DataGridViewButtonColumn()
                dataGrid.Columns.Add(inviteForInterview)
                inviteForInterview.HeaderText = "Invite for Interview"
                inviteForInterview.Text = "Invite"
                inviteForInterview.Name = "btn_invite_interview"
                inviteForInterview.UseColumnTextForButtonValue = True
            End If
           
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Cannot connect to database: " & ex.Message.ToString)
        End Try
    End Sub

    Private Function convertStringToList(ByVal str As String)
        Dim count As Integer
        Dim list As New List(Of String)
        Dim strArr = Regex.Split(str.Substring(4, str.Length - 5), "\{|\}")
        For count = 0 To strArr.Length - 1
            Dim stringArr = strArr(count).Split(";")
            For c = 0 To stringArr.Length - 1
                Dim sArr = stringArr(c).Split(":")
                For i = 0 To sArr.Length - 1

                    If i Mod 2 = 0 Then
                        If Not sArr(i).Equals("s") Then
                            If Not sArr(i).Equals("") Then

                                list.Add(sArr(i).Trim(""""))
                            End If
                        End If

                    End If
                Next
            Next
        Next
        Dim flist As New List(Of String)
        For index As Integer = 0 To list.Count - 1
            If Not index Mod 2 = 0 Then
                flist.Add(list(index))
            End If
        Next
        Return flist
    End Function





End Class
