<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mail))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_emailSender = New System.Windows.Forms.TextBox()
        Me.txt_passSender = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_emailRec = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.txt_body = New System.Windows.Forms.TextBox()
        Me.btn_sendEmail = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_location = New System.Windows.Forms.Label()
        Me.btn_back_mainform = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btn_back_mainform)
        Me.Panel1.Controls.Add(Me.lbl_location)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.btn_sendEmail)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(131, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 563)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_passSender)
        Me.GroupBox1.Controls.Add(Me.txt_emailSender)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Location = New System.Drawing.Point(32, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "From"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'txt_emailSender
        '
        Me.txt_emailSender.BackColor = System.Drawing.Color.Black
        Me.txt_emailSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_emailSender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_emailSender.ForeColor = System.Drawing.Color.LightGray
        Me.txt_emailSender.Location = New System.Drawing.Point(135, 35)
        Me.txt_emailSender.Name = "txt_emailSender"
        Me.txt_emailSender.Size = New System.Drawing.Size(262, 26)
        Me.txt_emailSender.TabIndex = 2
        '
        'txt_passSender
        '
        Me.txt_passSender.BackColor = System.Drawing.Color.Black
        Me.txt_passSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_passSender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_passSender.ForeColor = System.Drawing.Color.LightGray
        Me.txt_passSender.Location = New System.Drawing.Point(135, 75)
        Me.txt_passSender.Name = "txt_passSender"
        Me.txt_passSender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_passSender.Size = New System.Drawing.Size(262, 26)
        Me.txt_passSender.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_body)
        Me.GroupBox2.Controls.Add(Me.txt_title)
        Me.GroupBox2.Controls.Add(Me.txt_emailRec)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.LightGray
        Me.GroupBox2.Location = New System.Drawing.Point(32, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 290)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Title:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Body:"
        '
        'txt_emailRec
        '
        Me.txt_emailRec.BackColor = System.Drawing.Color.Black
        Me.txt_emailRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_emailRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_emailRec.ForeColor = System.Drawing.Color.LightGray
        Me.txt_emailRec.Location = New System.Drawing.Point(135, 33)
        Me.txt_emailRec.Name = "txt_emailRec"
        Me.txt_emailRec.Size = New System.Drawing.Size(375, 26)
        Me.txt_emailRec.TabIndex = 4
        '
        'txt_title
        '
        Me.txt_title.BackColor = System.Drawing.Color.Black
        Me.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title.ForeColor = System.Drawing.Color.LightGray
        Me.txt_title.Location = New System.Drawing.Point(135, 74)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(375, 26)
        Me.txt_title.TabIndex = 5
        '
        'txt_body
        '
        Me.txt_body.BackColor = System.Drawing.Color.Black
        Me.txt_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_body.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_body.ForeColor = System.Drawing.Color.LightGray
        Me.txt_body.Location = New System.Drawing.Point(135, 115)
        Me.txt_body.Multiline = True
        Me.txt_body.Name = "txt_body"
        Me.txt_body.Size = New System.Drawing.Size(375, 142)
        Me.txt_body.TabIndex = 6
        '
        'btn_sendEmail
        '
        Me.btn_sendEmail.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_sendEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sendEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sendEmail.ForeColor = System.Drawing.Color.Black
        Me.btn_sendEmail.Location = New System.Drawing.Point(167, 472)
        Me.btn_sendEmail.Name = "btn_sendEmail"
        Me.btn_sendEmail.Size = New System.Drawing.Size(88, 31)
        Me.btn_sendEmail.TabIndex = 51
        Me.btn_sendEmail.Text = "Send "
        Me.btn_sendEmail.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.White
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel1.Image = CType(resources.GetObject("LinkLabel1.Image"), System.Drawing.Image)
        Me.LinkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(316, 472)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(88, 31)
        Me.LinkLabel1.TabIndex = 52
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Attachment"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl_location
        '
        Me.lbl_location.BackColor = System.Drawing.Color.White
        Me.lbl_location.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_location.ForeColor = System.Drawing.Color.Black
        Me.lbl_location.Location = New System.Drawing.Point(266, 516)
        Me.lbl_location.Name = "lbl_location"
        Me.lbl_location.Size = New System.Drawing.Size(230, 31)
        Me.lbl_location.TabIndex = 53
        Me.lbl_location.Text = "File From:"
        Me.lbl_location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_back_mainform
        '
        Me.btn_back_mainform.BackColor = System.Drawing.Color.DarkRed
        Me.btn_back_mainform.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back_mainform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back_mainform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_mainform.ForeColor = System.Drawing.Color.Black
        Me.btn_back_mainform.Location = New System.Drawing.Point(463, 472)
        Me.btn_back_mainform.Name = "btn_back_mainform"
        Me.btn_back_mainform.Size = New System.Drawing.Size(79, 31)
        Me.btn_back_mainform.TabIndex = 57
        Me.btn_back_mainform.Text = "Back"
        Me.btn_back_mainform.UseVisualStyleBackColor = False
        '
        'frm_mail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1073, 656)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_mail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_mail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_emailSender As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_passSender As System.Windows.Forms.TextBox
    Friend WithEvents txt_body As System.Windows.Forms.TextBox
    Friend WithEvents txt_title As System.Windows.Forms.TextBox
    Friend WithEvents txt_emailRec As System.Windows.Forms.TextBox
    Friend WithEvents btn_sendEmail As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl_location As System.Windows.Forms.Label
    Friend WithEvents btn_back_mainform As System.Windows.Forms.Button
End Class
