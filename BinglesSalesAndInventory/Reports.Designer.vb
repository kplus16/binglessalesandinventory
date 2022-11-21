<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsForm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNonFoodSales = New System.Windows.Forms.Label()
        Me.txtTotalFoodSales = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.txtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.txtDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.gbFood = New System.Windows.Forms.GroupBox()
        Me.btn_SalesGenerate = New System.Windows.Forms.Button()
        Me.DataGridViewsales = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.DataGridViewInventory = New System.Windows.Forms.DataGridView()
        Me.gbFood.SuspendLayout()
        CType(Me.DataGridViewsales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNonFoodSales
        '
        Me.txtNonFoodSales.AutoSize = True
        Me.txtNonFoodSales.Location = New System.Drawing.Point(427, 70)
        Me.txtNonFoodSales.Name = "txtNonFoodSales"
        Me.txtNonFoodSales.Size = New System.Drawing.Size(0, 13)
        Me.txtNonFoodSales.TabIndex = 17
        Me.txtNonFoodSales.Visible = False
        '
        'txtTotalFoodSales
        '
        Me.txtTotalFoodSales.AutoSize = True
        Me.txtTotalFoodSales.Location = New System.Drawing.Point(149, 69)
        Me.txtTotalFoodSales.Name = "txtTotalFoodSales"
        Me.txtTotalFoodSales.Size = New System.Drawing.Size(0, 13)
        Me.txtTotalFoodSales.TabIndex = 16
        Me.txtTotalFoodSales.Visible = False
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.ForeColor = System.Drawing.Color.Black
        Me.lblFrom.Location = New System.Drawing.Point(18, 33)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(51, 21)
        Me.lblFrom.TabIndex = 14
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.Black
        Me.lblTo.Location = New System.Drawing.Point(197, 34)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(33, 21)
        Me.lblTo.TabIndex = 13
        Me.lblTo.Text = "To:"
        '
        'txtDateTo
        '
        Me.txtDateTo.CustomFormat = "yyyy-MM-dd"
        Me.txtDateTo.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateTo.Location = New System.Drawing.Point(240, 31)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(102, 29)
        Me.txtDateTo.TabIndex = 12
        '
        'txtDateFrom
        '
        Me.txtDateFrom.CustomFormat = "yyyy-MM-dd"
        Me.txtDateFrom.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateFrom.Location = New System.Drawing.Point(73, 31)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(106, 29)
        Me.txtDateFrom.TabIndex = 11
        '
        'gbFood
        '
        Me.gbFood.Controls.Add(Me.btn_SalesGenerate)
        Me.gbFood.Controls.Add(Me.DataGridViewsales)
        Me.gbFood.Controls.Add(Me.txtDateFrom)
        Me.gbFood.Controls.Add(Me.txtDateTo)
        Me.gbFood.Controls.Add(Me.lblFrom)
        Me.gbFood.Controls.Add(Me.lblTo)
        Me.gbFood.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFood.ForeColor = System.Drawing.Color.Black
        Me.gbFood.Location = New System.Drawing.Point(12, 12)
        Me.gbFood.Name = "gbFood"
        Me.gbFood.Size = New System.Drawing.Size(485, 376)
        Me.gbFood.TabIndex = 10
        Me.gbFood.TabStop = False
        Me.gbFood.Text = "Sales Report"
        '
        'btn_SalesGenerate
        '
        Me.btn_SalesGenerate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_SalesGenerate.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SalesGenerate.Location = New System.Drawing.Point(374, 27)
        Me.btn_SalesGenerate.Name = "btn_SalesGenerate"
        Me.btn_SalesGenerate.Size = New System.Drawing.Size(93, 38)
        Me.btn_SalesGenerate.TabIndex = 15
        Me.btn_SalesGenerate.Text = "Generate"
        Me.btn_SalesGenerate.UseVisualStyleBackColor = False
        '
        'DataGridViewsales
        '
        Me.DataGridViewsales.AllowUserToAddRows = False
        Me.DataGridViewsales.AllowUserToResizeColumns = False
        Me.DataGridViewsales.AllowUserToResizeRows = False
        Me.DataGridViewsales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewsales.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewsales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewsales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewsales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewsales.EnableHeadersVisualStyles = False
        Me.DataGridViewsales.Location = New System.Drawing.Point(16, 74)
        Me.DataGridViewsales.MultiSelect = False
        Me.DataGridViewsales.Name = "DataGridViewsales"
        Me.DataGridViewsales.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewsales.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewsales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewsales.Size = New System.Drawing.Size(451, 280)
        Me.DataGridViewsales.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.DataGridViewInventory)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(518, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 376)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory Report"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPrint.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(386, 25)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(81, 38)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'DataGridViewInventory
        '
        Me.DataGridViewInventory.AllowUserToAddRows = False
        Me.DataGridViewInventory.AllowUserToResizeColumns = False
        Me.DataGridViewInventory.AllowUserToResizeRows = False
        Me.DataGridViewInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewInventory.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewInventory.EnableHeadersVisualStyles = False
        Me.DataGridViewInventory.Location = New System.Drawing.Point(16, 69)
        Me.DataGridViewInventory.MultiSelect = False
        Me.DataGridViewInventory.Name = "DataGridViewInventory"
        Me.DataGridViewInventory.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewInventory.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInventory.Size = New System.Drawing.Size(451, 285)
        Me.DataGridViewInventory.TabIndex = 0
        '
        'ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1015, 400)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNonFoodSales)
        Me.Controls.Add(Me.txtTotalFoodSales)
        Me.Controls.Add(Me.gbFood)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportsForm"
        Me.Text = "Reports"
        Me.gbFood.ResumeLayout(False)
        Me.gbFood.PerformLayout()
        CType(Me.DataGridViewsales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNonFoodSales As System.Windows.Forms.Label
    Friend WithEvents txtTotalFoodSales As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbFood As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewsales As System.Windows.Forms.DataGridView
    Friend WithEvents btn_SalesGenerate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents DataGridViewInventory As System.Windows.Forms.DataGridView
End Class
