Imports System.Net.Mail
Public Class frm_mail

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OpenFileDialog1.ShowDialog()
        lbl_location.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_sendEmail_Click(sender As Object, e As EventArgs) Handles btn_sendEmail.Click
        Try
            Dim email As New MailMessage()
            Dim smtp As New SmtpClient("smtp.gmail.com")
            email.From = New MailAddress(txt_emailSender.Text)
            email.Subject = txt_title.Text
            email.Body = txt_body.Text
            email.To.Add(txt_emailRec.Text)
            Dim attach As System.Net.Mail.Attachment
            attach = New System.Net.Mail.Attachment(lbl_location.Text)
            email.Attachments.Add(attach)
            smtp.Port = 587
            smtp.Credentials = New System.Net.NetworkCredential(txt_emailSender.Text, txt_passSender.Text)
            smtp.EnableSsl = True
            smtp.Send(email)
            MessageBox.Show("Message Sent!")
            txt_body.Text = ""
            txt_emailRec.Text = ""
            txt_emailSender.Text = ""
            txt_passSender.Text = ""
            txt_title.Text = ""
            lbl_location.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_back_mainform_Click(sender As Object, e As EventArgs) Handles btn_back_mainform.Click
        frm_mainform.Show()
        Me.Hide()

    End Sub
End Class