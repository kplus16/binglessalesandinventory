<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_custname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_eventname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateneeded = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.reservation_panel = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLogs = New System.Windows.Forms.Label()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btn_reserve = New System.Windows.Forms.Button()
        Me.timeneeded = New System.Windows.Forms.DateTimePicker()
        Me.pnl_sched = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnArchived = New System.Windows.Forms.Button()
        Me.date_check = New System.Windows.Forms.DateTimePicker()
        Me.schedule_data = New System.Windows.Forms.DataGridView()
        Me.reservation_panel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnl_sched.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.schedule_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Name"
        '
        'txt_custname
        '
        Me.txt_custname.Location = New System.Drawing.Point(148, 65)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.Size = New System.Drawing.Size(183, 29)
        Me.txt_custname.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Event Name"
        '
        'txt_eventname
        '
        Me.txt_eventname.Location = New System.Drawing.Point(148, 103)
        Me.txt_eventname.Name = "txt_eventname"
        Me.txt_eventname.Size = New System.Drawing.Size(183, 29)
        Me.txt_eventname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Address"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(148, 140)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(183, 67)
        Me.txt_address.TabIndex = 6
        Me.txt_address.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date Needed"
        '
        'dateneeded
        '
        Me.dateneeded.CustomFormat = "yyyy-MM-dd"
        Me.dateneeded.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateneeded.Location = New System.Drawing.Point(148, 216)
        Me.dateneeded.Name = "dateneeded"
        Me.dateneeded.Size = New System.Drawing.Size(183, 29)
        Me.dateneeded.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Time Needed"
        '
        'reservation_panel
        '
        Me.reservation_panel.BackColor = System.Drawing.Color.SkyBlue
        Me.reservation_panel.Controls.Add(Me.GroupBox2)
        Me.reservation_panel.Location = New System.Drawing.Point(0, 1)
        Me.reservation_panel.Name = "reservation_panel"
        Me.reservation_panel.Size = New System.Drawing.Size(378, 398)
        Me.reservation_panel.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLogs)
        Me.GroupBox2.Controls.Add(Me.lblEvent)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.btn_reserve)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.timeneeded)
        Me.GroupBox2.Controls.Add(Me.txt_address)
        Me.GroupBox2.Controls.Add(Me.txt_custname)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_eventname)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dateneeded)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 376)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reservation"
        '
        'lblLogs
        '
        Me.lblLogs.AutoSize = True
        Me.lblLogs.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogs.ForeColor = System.Drawing.Color.SkyBlue
        Me.lblLogs.Location = New System.Drawing.Point(16, 318)
        Me.lblLogs.Name = "lblLogs"
        Me.lblLogs.Size = New System.Drawing.Size(124, 20)
        Me.lblLogs.TabIndex = 118
        Me.lblLogs.Text = "RESERVATION ID:"
        '
        'lblEvent
        '
        Me.lblEvent.AutoSize = True
        Me.lblEvent.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEvent.ForeColor = System.Drawing.Color.SkyBlue
        Me.lblEvent.Location = New System.Drawing.Point(194, 32)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(124, 20)
        Me.lblEvent.TabIndex = 117
        Me.lblEvent.Text = "RESERVATION ID:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.SkyBlue
        Me.lblName.Location = New System.Drawing.Point(35, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(153, 21)
        Me.lblName.TabIndex = 116
        Me.lblName.Text = "RESERVATION ID:"
        '
        'btn_reserve
        '
        Me.btn_reserve.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_reserve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reserve.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reserve.Location = New System.Drawing.Point(187, 300)
        Me.btn_reserve.Name = "btn_reserve"
        Me.btn_reserve.Size = New System.Drawing.Size(126, 57)
        Me.btn_reserve.TabIndex = 11
        Me.btn_reserve.Text = "Proceed to POS"
        Me.btn_reserve.UseVisualStyleBackColor = False
        '
        'timeneeded
        '
        Me.timeneeded.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeneeded.Location = New System.Drawing.Point(148, 252)
        Me.timeneeded.Name = "timeneeded"
        Me.timeneeded.ShowUpDown = True
        Me.timeneeded.Size = New System.Drawing.Size(183, 29)
        Me.timeneeded.TabIndex = 10
        '
        'pnl_sched
        '
        Me.pnl_sched.BackColor = System.Drawing.Color.SkyBlue
        Me.pnl_sched.Controls.Add(Me.GroupBox1)
        Me.pnl_sched.Location = New System.Drawing.Point(369, 1)
        Me.pnl_sched.Name = "pnl_sched"
        Me.pnl_sched.Size = New System.Drawing.Size(645, 398)
        Me.pnl_sched.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnArchived)
        Me.GroupBox1.Controls.Add(Me.date_check)
        Me.GroupBox1.Controls.Add(Me.schedule_data)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 376)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Schedule"
        '
        'btnArchived
        '
        Me.btnArchived.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnArchived.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArchived.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArchived.Location = New System.Drawing.Point(506, 23)
        Me.btnArchived.Name = "btnArchived"
        Me.btnArchived.Size = New System.Drawing.Size(83, 38)
        Me.btnArchived.TabIndex = 12
        Me.btnArchived.Text = "Archived"
        Me.btnArchived.UseVisualStyleBackColor = False
        '
        'date_check
        '
        Me.date_check.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_check.Location = New System.Drawing.Point(29, 32)
        Me.date_check.Name = "date_check"
        Me.date_check.Size = New System.Drawing.Size(286, 29)
        Me.date_check.TabIndex = 1
        '
        'schedule_data
        '
        Me.schedule_data.AllowUserToAddRows = False
        Me.schedule_data.AllowUserToDeleteRows = False
        Me.schedule_data.AllowUserToResizeColumns = False
        Me.schedule_data.AllowUserToResizeRows = False
        Me.schedule_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.schedule_data.BackgroundColor = System.Drawing.Color.White
        Me.schedule_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.schedule_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.schedule_data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.schedule_data.Location = New System.Drawing.Point(29, 67)
        Me.schedule_data.Name = "schedule_data"
        Me.schedule_data.ReadOnly = True
        Me.schedule_data.RowHeadersVisible = False
        Me.schedule_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.schedule_data.Size = New System.Drawing.Size(560, 290)
        Me.schedule_data.TabIndex = 0
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1015, 400)
        Me.Controls.Add(Me.pnl_sched)
        Me.Controls.Add(Me.reservation_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reservation"
        Me.Text = "Reservation"
        Me.reservation_panel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnl_sched.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.schedule_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_custname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_eventname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dateneeded As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents reservation_panel As System.Windows.Forms.Panel
    Friend WithEvents timeneeded As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_reserve As System.Windows.Forms.Button
    Friend WithEvents pnl_sched As System.Windows.Forms.Panel
    Friend WithEvents date_check As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents schedule_data As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEvent As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblLogs As System.Windows.Forms.Label
    Friend WithEvents btnArchived As System.Windows.Forms.Button
End Class
