Public Class frm_register

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_username.Text = ""
        txt_password.Text = ""
        txt_id.Text = ""
        txt_name.Text = ""
        txt_address.Text = ""
        dtp_date.Value = Now
        rb_male.Checked = False
        rb_female.Checked = False
        txt_age.Text = ""

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_female.CheckedChanged

    End Sub
End Class