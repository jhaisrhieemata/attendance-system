Imports MySql.Data.MySqlClient
Public Class frm_mainform
    Public myConnection As New MySqlConnection
    Public MyCommand As New MySqlCommand
    Public MyAdaptor As New MySqlDataAdapter
    Public MyReader As MySqlDataReader
    Private MySQLUSER As String = "root"
    Private MySQLHOST As String = "localhost"
    Private MySQLPASS As String = ""
    Private MySQLDBSE As String = "student"

    Dim xlApp As Microsoft.Office.Interop.Excel.Application
    Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
    Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frm_mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_info.Load("", ListView1)
        For Each Column As ColumnHeader In Me.ListView1.Columns
            Column.Width = -2

        Next
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim STR As String
        STR = "server=" & MySQLHOST & ";user=" & MySQLUSER & ";password=" & MySQLPASS & ";database=" & MySQLDBSE
        myConnection.ConnectionString = STR
        myConnection.Open()

        Try
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "insert into student.attendance (student_id, name, course , major , year, time_in, time_out) values ('" & txt_student_id.Text & "','" & txt_name.Text & "','" & cmb_course.Text & "','" & cmb_major.Text & "','" & cmb_year.Text & "','" & dtp_time_in.Value & "','" & dtp_time_out.Value & "')"
            MyCommand.ExecuteNonQuery()

            MsgBox("Successfull Inserted", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Failed")
        End Try
        lbl_id.Text = ""
        txt_student_id.Text = ""
        txt_name.Text = ""
        cmb_course.Text = ""
        cmb_major.Text = ""
        cmb_year.Text = ""
        dtp_time_in.Value = Now
        dtp_time_out.Value = Now

        ListView1.Items.Clear()
        Load_info.Load("", ListView1)
        myConnection.Close()
    End Sub
    Dim Load_info As New queries_attendance

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count <> 0 Then
            With ListView1.SelectedItems(0)
                lbl_id.Text = .SubItems(0).Text
                txt_student_id.Text = .SubItems(1).Text
                txt_name.Text = .SubItems(2).Text
                cmb_course.Text = .SubItems(3).Text
                cmb_major.Text = .SubItems(4).Text
                cmb_year.Text = .SubItems(5).Text
                dtp_time_in.Value = .SubItems(6).Text
                dtp_time_out.Value = .SubItems(7).Text
            End With
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        lbl_id.Text = ""
        txt_student_id.Text = ""
        txt_name.Text = ""
        cmb_course.Text = ""
        cmb_major.Text = ""
        cmb_year.Text = ""
        dtp_time_in.Value = Now
        dtp_time_out.Value = Now
        txt_student_id.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim STR As String
        STR = "server=" & MySQLHOST & ";user=" & MySQLUSER & ";password=" & MySQLPASS & ";database=" & MySQLDBSE
        myConnection.ConnectionString = STR
        myConnection.Open()

        Try
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "update student.attendance set id= '" & lbl_id.Text & "', student_id='" & txt_student_id.Text & "', name= '" & txt_name.Text & " ', course= '" & cmb_course.Text & "', major= '" & cmb_major.Text & "', year= '" & cmb_year.Text & "', time_in= '" & dtp_time_in.Value & "', time_out= '" & dtp_time_out.Value & "' where id= '" & lbl_id.Text & "' "
            MyCommand.ExecuteNonQuery()
            MsgBox("Successfull Update", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Failed")
        End Try
        lbl_id.Text = ""
        txt_student_id.Text = ""
        txt_name.Text = ""
        cmb_course.Text = ""
        cmb_major.Text = ""
        cmb_year.Text = ""
        dtp_time_in.Value = Now
        dtp_time_out.Value = Now
        ListView1.Items.Clear()
        Load_info.Load("", ListView1)
        myConnection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim STR As String
        STR = "server=" & MySQLHOST & ";user=" & MySQLUSER & ";password=" & MySQLPASS & ";database=" & MySQLDBSE
        myConnection.ConnectionString = STR
        myConnection.Open()

        Try
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "delete from student.attendance where id  = '" & lbl_id.Text & "'"
            MyCommand.ExecuteNonQuery()
            MsgBox("Successfull Deleted", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Failed")
        End Try
        lbl_id.Text = ""
        txt_student_id.Text = ""
        txt_name.Text = ""
        cmb_course.Text = ""
        cmb_major.Text = ""
        cmb_year.Text = ""
        dtp_time_in.Value = Now
        dtp_time_out.Value = Now
        ListView1.Items.Clear()
        Load_info.Load("", ListView1)
        myConnection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        lbl_id.Text = ""
        txt_student_id.Text = ""
        txt_name.Text = ""
        cmb_course.Text = ""
        cmb_major.Text = ""
        cmb_year.Text = ""
        dtp_time_in.Value = Now
        dtp_time_out.Value = Now
        txt_student_id.Focus()
    End Sub


    Private Sub btn_clearDB_Click(sender As Object, e As EventArgs) Handles btn_clearDB.Click
        Dim STR As String
        STR = "server=" & MySQLHOST & ";user=" & MySQLUSER & ";password=" & MySQLPASS & ";database=" & MySQLDBSE
        myConnection.ConnectionString = STR
        myConnection.Open()

        Try
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "truncate table attendance"
            MyCommand.ExecuteNonQuery()
            MsgBox("Successfull Deleted", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Failed")
        End Try
        lbl_id.Text = ""
        txt_student_id.Text = ""
        txt_name.Text = ""
        cmb_course.Text = ""
        cmb_major.Text = ""
        cmb_year.Text = ""
        dtp_time_in.Value = Now
        dtp_time_out.Value = Now
        ListView1.Items.Clear()
        Load_info.Load("", ListView1)
        myConnection.Close()
    End Sub

    Private Sub dtp_time_out_ValueChanged(sender As Object, e As EventArgs) Handles dtp_time_out.ValueChanged

    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Open(Application.StartupPath & "\Book1")
        xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
        Dim currCOL, currROW, x As Integer
        currCOL = 1
        currROW = 8
        With Me
            Dim y As Integer = ListView1.Items.Count - 1
            For x = 0 To y
                xlWorkSheet.Cells(currROW, currCOL + 0) = ListView1.Items(x).SubItems(0).Text
                xlWorkSheet.Cells(currROW, currCOL + 1) = ListView1.Items(x).SubItems(1).Text
                xlWorkSheet.Cells(currROW, currCOL + 2) = ListView1.Items(x).SubItems(2).Text
                xlWorkSheet.Cells(currROW, currCOL + 3) = ListView1.Items(x).SubItems(3).Text
                xlWorkSheet.Cells(currROW, currCOL + 4) = ListView1.Items(x).SubItems(4).Text
                xlWorkSheet.Cells(currROW, currCOL + 5) = ListView1.Items(x).SubItems(5).Text
                xlWorkSheet.Cells(currROW, currCOL + 6) = ListView1.Items(x).SubItems(6).Text
                xlWorkSheet.Cells(currROW, currCOL + 7) = ListView1.Items(x).SubItems(7).Text
                currROW += 1
            Next
            xlApp.Visible = True
        End With

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim query_search As String
        Dim pass As New queries_attendance
        query_search = "Select * from attendance where name LIKE '%" & Me.txt_search.Text & "%' or id LIKE '%" & txt_search.Text & "%'or student_id LIKE '%" & Me.txt_search.Text & "%' or course LIKE '%" & Me.txt_search.Text & "%' or major LIKE '%" & Me.txt_search.Text & "%' or year LIKE '%" & Me.txt_search.Text & "%' order by id asc  "
        ListView1.Items.Clear()
        pass.Load(query_search, ListView1)
    End Sub

    Private Sub btn_sendEmail_Click(sender As Object, e As EventArgs) Handles btn_sendEmail.Click
        frm_mail.Show()
        Me.Hide()

    End Sub

    Private Sub btn_back_login_Click(sender As Object, e As EventArgs) Handles btn_back_login.Click
        Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class