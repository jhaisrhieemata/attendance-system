Public Class progressbar

    Private Sub progressbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = 0
        ProgressBar1.Maximum = 100
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 5
        Label1.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value >= 100 Then
            Timer1.Enabled = False
            MsgBox("Successful!", vbInformation, "Attendance Form")
            Me.Close()
            frm_mainform.Show()
            ProgressBar1.Value = 0
            Label1.Text = ProgressBar1.Value & "%"

        End If
    End Sub
End Class