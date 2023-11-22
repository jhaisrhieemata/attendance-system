<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_sendEmail = New System.Windows.Forms.Button()
        Me.btn_clearDB = New System.Windows.Forms.Button()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.student_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.course = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.major = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.year = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.time_in = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dtp_time_in = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_year = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_major = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_course = New System.Windows.Forms.ComboBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_student_id = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_time_out = New System.Windows.Forms.DateTimePicker()
        Me.time_out = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_back_login = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btn_back_login)
        Me.Panel1.Controls.Add(Me.txt_search)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtp_time_out)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_id)
        Me.Panel1.Controls.Add(Me.btn_sendEmail)
        Me.Panel1.Controls.Add(Me.btn_clearDB)
        Me.Panel1.Controls.Add(Me.btn_export)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.btn_new)
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.dtp_time_in)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.cmb_year)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cmb_major)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cmb_course)
        Me.Panel1.Controls.Add(Me.txt_name)
        Me.Panel1.Controls.Add(Me.txt_student_id)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1014, 450)
        Me.Panel1.TabIndex = 0
        '
        'btn_sendEmail
        '
        Me.btn_sendEmail.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_sendEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sendEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sendEmail.ForeColor = System.Drawing.Color.Black
        Me.btn_sendEmail.Location = New System.Drawing.Point(633, 403)
        Me.btn_sendEmail.Name = "btn_sendEmail"
        Me.btn_sendEmail.Size = New System.Drawing.Size(90, 31)
        Me.btn_sendEmail.TabIndex = 50
        Me.btn_sendEmail.Text = "Send Email"
        Me.btn_sendEmail.UseVisualStyleBackColor = False
        '
        'btn_clearDB
        '
        Me.btn_clearDB.BackColor = System.Drawing.Color.DarkRed
        Me.btn_clearDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clearDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearDB.ForeColor = System.Drawing.Color.Black
        Me.btn_clearDB.Location = New System.Drawing.Point(93, 374)
        Me.btn_clearDB.Name = "btn_clearDB"
        Me.btn_clearDB.Size = New System.Drawing.Size(79, 31)
        Me.btn_clearDB.TabIndex = 49
        Me.btn_clearDB.Text = "Clear DB"
        Me.btn_clearDB.UseVisualStyleBackColor = False
        '
        'btn_export
        '
        Me.btn_export.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export.ForeColor = System.Drawing.Color.Black
        Me.btn_export.Location = New System.Drawing.Point(254, 374)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(80, 31)
        Me.btn_export.TabIndex = 48
        Me.btn_export.Text = "Export"
        Me.btn_export.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Maroon
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Location = New System.Drawing.Point(766, 403)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(80, 31)
        Me.btn_delete.TabIndex = 47
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.Location = New System.Drawing.Point(495, 403)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(80, 31)
        Me.btn_update.TabIndex = 46
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.ForeColor = System.Drawing.Color.Black
        Me.btn_new.Location = New System.Drawing.Point(374, 403)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(80, 31)
        Me.btn_new.TabIndex = 45
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.DarkRed
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(93, 326)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(79, 31)
        Me.btn_cancel.TabIndex = 44
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.DarkGreen
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Location = New System.Drawing.Point(254, 326)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(80, 31)
        Me.btn_save.TabIndex = 43
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Location = New System.Drawing.Point(350, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 338)
        Me.Panel2.TabIndex = 42
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.student_id, Me.fname, Me.course, Me.major, Me.year, Me.time_in, Me.time_out})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.ForeColor = System.Drawing.Color.DimGray
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(634, 338)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'student_id
        '
        Me.student_id.Text = "Student ID"
        Me.student_id.Width = 85
        '
        'fname
        '
        Me.fname.Text = "Name"
        Me.fname.Width = 90
        '
        'course
        '
        Me.course.Text = "Course"
        Me.course.Width = 107
        '
        'major
        '
        Me.major.Text = "Major"
        Me.major.Width = 91
        '
        'year
        '
        Me.year.Text = "Year"
        Me.year.Width = 64
        '
        'time_in
        '
        Me.time_in.Text = "Time in"
        Me.time_in.Width = 72
        '
        'dtp_time_in
        '
        Me.dtp_time_in.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_time_in.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_time_in.Location = New System.Drawing.Point(92, 286)
        Me.dtp_time_in.Name = "dtp_time_in"
        Me.dtp_time_in.Size = New System.Drawing.Size(80, 26)
        Me.dtp_time_in.TabIndex = 39
        Me.dtp_time_in.Value = New Date(2021, 11, 9, 18, 8, 7, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(7, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 20)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Time in:"
        '
        'cmb_year
        '
        Me.cmb_year.BackColor = System.Drawing.Color.Black
        Me.cmb_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_year.ForeColor = System.Drawing.Color.White
        Me.cmb_year.FormattingEnabled = True
        Me.cmb_year.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year"})
        Me.cmb_year.Location = New System.Drawing.Point(92, 239)
        Me.cmb_year.Name = "cmb_year"
        Me.cmb_year.Size = New System.Drawing.Size(242, 28)
        Me.cmb_year.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightGray
        Me.Label11.Location = New System.Drawing.Point(7, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 20)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Year:"
        '
        'cmb_major
        '
        Me.cmb_major.BackColor = System.Drawing.Color.Black
        Me.cmb_major.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_major.ForeColor = System.Drawing.Color.White
        Me.cmb_major.FormattingEnabled = True
        Me.cmb_major.Items.AddRange(New Object() {"IT20", "IT21", "IT22", "IT23", "IT24", "IT25", "Major in Enlish", "Major in Math", "Introduction of Linguistic"})
        Me.cmb_major.Location = New System.Drawing.Point(92, 187)
        Me.cmb_major.Name = "cmb_major"
        Me.cmb_major.Size = New System.Drawing.Size(242, 28)
        Me.cmb_major.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(7, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 20)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Major:"
        '
        'cmb_course
        '
        Me.cmb_course.BackColor = System.Drawing.Color.Black
        Me.cmb_course.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_course.ForeColor = System.Drawing.Color.White
        Me.cmb_course.FormattingEnabled = True
        Me.cmb_course.Items.AddRange(New Object() {"BSIT", "BSBA ", "BEED"})
        Me.cmb_course.Location = New System.Drawing.Point(92, 128)
        Me.cmb_course.Name = "cmb_course"
        Me.cmb_course.Size = New System.Drawing.Size(242, 28)
        Me.cmb_course.TabIndex = 27
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.Black
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.White
        Me.txt_name.Location = New System.Drawing.Point(92, 79)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(242, 26)
        Me.txt_name.TabIndex = 26
        '
        'txt_student_id
        '
        Me.txt_student_id.BackColor = System.Drawing.Color.Black
        Me.txt_student_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_student_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_student_id.ForeColor = System.Drawing.Color.White
        Me.txt_student_id.Location = New System.Drawing.Point(92, 37)
        Me.txt_student_id.Name = "txt_student_id"
        Me.txt_student_id.Size = New System.Drawing.Size(242, 26)
        Me.txt_student_id.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(3, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Course:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(4, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(4, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Student ID"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_id.Location = New System.Drawing.Point(8, 17)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(21, 16)
        Me.lbl_id.TabIndex = 51
        Me.lbl_id.Text = "ID"
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(178, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Timeout:"
        '
        'dtp_time_out
        '
        Me.dtp_time_out.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_time_out.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_time_out.Location = New System.Drawing.Point(254, 286)
        Me.dtp_time_out.Name = "dtp_time_out"
        Me.dtp_time_out.Size = New System.Drawing.Size(80, 26)
        Me.dtp_time_out.TabIndex = 53
        Me.dtp_time_out.Value = New Date(2021, 11, 9, 18, 8, 15, 0)
        '
        'time_out
        '
        Me.time_out.Text = "Time out"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(346, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Search:"
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.Color.Black
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.Color.White
        Me.txt_search.Location = New System.Drawing.Point(416, 12)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(228, 26)
        Me.txt_search.TabIndex = 55
        '
        'btn_back_login
        '
        Me.btn_back_login.BackColor = System.Drawing.Color.DarkRed
        Me.btn_back_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_login.ForeColor = System.Drawing.Color.Black
        Me.btn_back_login.Location = New System.Drawing.Point(886, 403)
        Me.btn_back_login.Name = "btn_back_login"
        Me.btn_back_login.Size = New System.Drawing.Size(79, 31)
        Me.btn_back_login.TabIndex = 56
        Me.btn_back_login.Text = "Exit"
        Me.btn_back_login.UseVisualStyleBackColor = False
        '
        'frm_mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1083, 489)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_mainform"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmb_course As System.Windows.Forms.ComboBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_student_id As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtp_time_in As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_year As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_major As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents student_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents fname As System.Windows.Forms.ColumnHeader
    Friend WithEvents course As System.Windows.Forms.ColumnHeader
    Friend WithEvents major As System.Windows.Forms.ColumnHeader
    Friend WithEvents year As System.Windows.Forms.ColumnHeader
    Friend WithEvents time_in As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_clearDB As System.Windows.Forms.Button
    Friend WithEvents btn_sendEmail As System.Windows.Forms.Button
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtp_time_out As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents time_out As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_back_login As System.Windows.Forms.Button
End Class
