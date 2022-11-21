<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notification
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabReservation = New System.Windows.Forms.TabPage()
        Me.DataGridUPEVENTS = New System.Windows.Forms.DataGridView()
        Me.TabStocks = New System.Windows.Forms.TabPage()
        Me.DataGridINSTOCKS = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabReservation.SuspendLayout()
        CType(Me.DataGridUPEVENTS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabStocks.SuspendLayout()
        CType(Me.DataGridINSTOCKS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 380)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Notification"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(638, 340)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 34)
        Me.btnClose.TabIndex = 63
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabReservation)
        Me.TabControl1.Controls.Add(Me.TabStocks)
        Me.TabControl1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(15, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(698, 312)
        Me.TabControl1.TabIndex = 0
        '
        'TabReservation
        '
        Me.TabReservation.Controls.Add(Me.DataGridUPEVENTS)
        Me.TabReservation.Location = New System.Drawing.Point(4, 30)
        Me.TabReservation.Name = "TabReservation"
        Me.TabReservation.Padding = New System.Windows.Forms.Padding(3)
        Me.TabReservation.Size = New System.Drawing.Size(690, 278)
        Me.TabReservation.TabIndex = 0
        Me.TabReservation.Text = "Upcoming Events"
        Me.TabReservation.UseVisualStyleBackColor = True
        '
        'DataGridUPEVENTS
        '
        Me.DataGridUPEVENTS.AllowUserToAddRows = False
        Me.DataGridUPEVENTS.AllowUserToDeleteRows = False
        Me.DataGridUPEVENTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridUPEVENTS.BackgroundColor = System.Drawing.Color.White
        Me.DataGridUPEVENTS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridUPEVENTS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridUPEVENTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridUPEVENTS.Location = New System.Drawing.Point(6, 15)
        Me.DataGridUPEVENTS.Name = "DataGridUPEVENTS"
        Me.DataGridUPEVENTS.ReadOnly = True
        Me.DataGridUPEVENTS.RowHeadersVisible = False
        Me.DataGridUPEVENTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridUPEVENTS.Size = New System.Drawing.Size(678, 258)
        Me.DataGridUPEVENTS.TabIndex = 104
        '
        'TabStocks
        '
        Me.TabStocks.Controls.Add(Me.DataGridINSTOCKS)
        Me.TabStocks.Location = New System.Drawing.Point(4, 29)
        Me.TabStocks.Name = "TabStocks"
        Me.TabStocks.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStocks.Size = New System.Drawing.Size(690, 279)
        Me.TabStocks.TabIndex = 1
        Me.TabStocks.Text = "Insufficient Stocks"
        Me.TabStocks.UseVisualStyleBackColor = True
        '
        'DataGridINSTOCKS
        '
        Me.DataGridINSTOCKS.AllowUserToAddRows = False
        Me.DataGridINSTOCKS.AllowUserToDeleteRows = False
        Me.DataGridINSTOCKS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridINSTOCKS.BackgroundColor = System.Drawing.Color.White
        Me.DataGridINSTOCKS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridINSTOCKS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridINSTOCKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridINSTOCKS.Location = New System.Drawing.Point(6, 10)
        Me.DataGridINSTOCKS.Name = "DataGridINSTOCKS"
        Me.DataGridINSTOCKS.ReadOnly = True
        Me.DataGridINSTOCKS.RowHeadersVisible = False
        Me.DataGridINSTOCKS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridINSTOCKS.Size = New System.Drawing.Size(678, 258)
        Me.DataGridINSTOCKS.TabIndex = 105
        '
        'Notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(753, 404)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Notification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notification"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabReservation.ResumeLayout(False)
        CType(Me.DataGridUPEVENTS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabStocks.ResumeLayout(False)
        CType(Me.DataGridINSTOCKS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabReservation As System.Windows.Forms.TabPage
    Friend WithEvents TabStocks As System.Windows.Forms.TabPage
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents DataGridUPEVENTS As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridINSTOCKS As System.Windows.Forms.DataGridView
End Class
