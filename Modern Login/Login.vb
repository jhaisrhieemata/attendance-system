Public Class Login

    Private Sub txt_username_MouseHover(sender As Object, e As EventArgs) Handles txt_username.MouseHover
        Dim uname As String = txt_username.Text
        If uname = "" Or uname = "Username" Then
            txt_username.Text = ""
        Else
            txt_username.Text = uname
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text = "admin" And txt_password.Text = "admin" Then
            progressbar.Show()
            Me.Hide()
            txt_username.Clear()
            txt_password.Clear()
        Else
            MsgBox("Invalid username or password")

        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_register.Show()
        Me.Hide()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_username.Text = "Username"
    End Sub

    Private Sub Login_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        If txt_username.Text = "" Then
            txt_username.Text = "Username"
        End If
    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        If txt_username.Text = "" Then
            txt_username.Text = "Username"
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
