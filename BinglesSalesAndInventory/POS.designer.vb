<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POS
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POS))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAmountDue = New System.Windows.Forms.TextBox()
        Me.DataGridOrder = New System.Windows.Forms.DataGridView()
        Me.DataGridRENTAL = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.res_id = New System.Windows.Forms.TextBox()
        Me.panelItems = New System.Windows.Forms.Panel()
        Me.rbRENTAL = New System.Windows.Forms.RadioButton()
        Me.rbSELLING = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridSELLING = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.panelCatering = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridViewViand = New System.Windows.Forms.DataGridView()
        Me.rbITEMS = New System.Windows.Forms.RadioButton()
        Me.rbCatering = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelService = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridViewServices = New System.Windows.Forms.DataGridView()
        Me.rbServices = New System.Windows.Forms.RadioButton()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.lblLogs = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtrental = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.rbFull = New System.Windows.Forms.RadioButton()
        Me.rbPartial = New System.Windows.Forms.RadioButton()
        Me.pcbxAddToCart = New System.Windows.Forms.PictureBox()
        Me.pcbxRemoveToCart = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridRENTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelItems.SuspendLayout()
        CType(Me.DataGridSELLING, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCatering.SuspendLayout()
        CType(Me.DataGridViewViand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelService.SuspendLayout()
        CType(Me.DataGridViewServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pcbxAddToCart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbxRemoveToCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "AMOUNT DUE:"
        '
        'txtAmountDue
        '
        Me.txtAmountDue.Enabled = False
        Me.txtAmountDue.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountDue.ForeColor = System.Drawing.Color.Blue
        Me.txtAmountDue.Location = New System.Drawing.Point(97, 241)
        Me.txtAmountDue.Name = "txtAmountDue"
        Me.txtAmountDue.Size = New System.Drawing.Size(173, 32)
        Me.txtAmountDue.TabIndex = 16
        '
        'DataGridOrder
        '
        Me.DataGridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridOrder.BackgroundColor = System.Drawing.Color.White
        Me.DataGridOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOrder.Location = New System.Drawing.Point(16, 36)
        Me.DataGridOrder.Name = "DataGridOrder"
        Me.DataGridOrder.RowHeadersVisible = False
        Me.DataGridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridOrder.Size = New System.Drawing.Size(376, 178)
        Me.DataGridOrder.TabIndex = 78
        '
        'DataGridRENTAL
        '
        Me.DataGridRENTAL.AllowUserToAddRows = False
        Me.DataGridRENTAL.AllowUserToDeleteRows = False
        Me.DataGridRENTAL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridRENTAL.BackgroundColor = System.Drawing.Color.White
        Me.DataGridRENTAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridRENTAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRENTAL.Location = New System.Drawing.Point(19, 48)
        Me.DataGridRENTAL.Name = "DataGridRENTAL"
        Me.DataGridRENTAL.ReadOnly = True
        Me.DataGridRENTAL.RowHeadersVisible = False
        Me.DataGridRENTAL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridRENTAL.Size = New System.Drawing.Size(487, 103)
        Me.DataGridRENTAL.TabIndex = 94
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 18)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "RESERVATION ID:"
        '
        'res_id
        '
        Me.res_id.Enabled = False
        Me.res_id.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.res_id.Location = New System.Drawing.Point(160, 19)
        Me.res_id.Name = "res_id"
        Me.res_id.Size = New System.Drawing.Size(81, 25)
        Me.res_id.TabIndex = 92
        '
        'panelItems
        '
        Me.panelItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelItems.Controls.Add(Me.rbRENTAL)
        Me.panelItems.Controls.Add(Me.rbSELLING)
        Me.panelItems.Controls.Add(Me.Label6)
        Me.panelItems.Controls.Add(Me.DataGridRENTAL)
        Me.panelItems.Controls.Add(Me.DataGridSELLING)
        Me.panelItems.Controls.Add(Me.Label12)
        Me.panelItems.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelItems.Location = New System.Drawing.Point(17, 51)
        Me.panelItems.Name = "panelItems"
        Me.panelItems.Size = New System.Drawing.Size(538, 178)
        Me.panelItems.TabIndex = 96
        '
        'rbRENTAL
        '
        Me.rbRENTAL.AutoSize = True
        Me.rbRENTAL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbRENTAL.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRENTAL.Location = New System.Drawing.Point(56, 18)
        Me.rbRENTAL.Name = "rbRENTAL"
        Me.rbRENTAL.Size = New System.Drawing.Size(121, 22)
        Me.rbRENTAL.TabIndex = 102
        Me.rbRENTAL.TabStop = True
        Me.rbRENTAL.Text = "RENTAL ITEMS"
        Me.rbRENTAL.UseVisualStyleBackColor = True
        '
        'rbSELLING
        '
        Me.rbSELLING.AutoSize = True
        Me.rbSELLING.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSELLING.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSELLING.Location = New System.Drawing.Point(213, 18)
        Me.rbSELLING.Name = "rbSELLING"
        Me.rbSELLING.Size = New System.Drawing.Size(124, 22)
        Me.rbSELLING.TabIndex = 103
        Me.rbSELLING.TabStop = True
        Me.rbSELLING.Text = "SELLING ITEMS"
        Me.rbSELLING.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "ITEMS"
        '
        'DataGridSELLING
        '
        Me.DataGridSELLING.AllowUserToAddRows = False
        Me.DataGridSELLING.AllowUserToDeleteRows = False
        Me.DataGridSELLING.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridSELLING.BackgroundColor = System.Drawing.Color.White
        Me.DataGridSELLING.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridSELLING.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSELLING.Location = New System.Drawing.Point(19, 48)
        Me.DataGridSELLING.Name = "DataGridSELLING"
        Me.DataGridSELLING.ReadOnly = True
        Me.DataGridSELLING.RowHeadersVisible = False
        Me.DataGridSELLING.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSELLING.Size = New System.Drawing.Size(487, 103)
        Me.DataGridSELLING.TabIndex = 95
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label12.Location = New System.Drawing.Point(427, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 20)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "VATION ID:"
        '
        'panelCatering
        '
        Me.panelCatering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelCatering.Controls.Add(Me.Label9)
        Me.panelCatering.Controls.Add(Me.DataGridViewViand)
        Me.panelCatering.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelCatering.Location = New System.Drawing.Point(17, 51)
        Me.panelCatering.Name = "panelCatering"
        Me.panelCatering.Size = New System.Drawing.Size(538, 178)
        Me.panelCatering.TabIndex = 97
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(-2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 18)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "CATERING"
        '
        'DataGridViewViand
        '
        Me.DataGridViewViand.AllowUserToAddRows = False
        Me.DataGridViewViand.AllowUserToDeleteRows = False
        Me.DataGridViewViand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewViand.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewViand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewViand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewViand.Location = New System.Drawing.Point(19, 23)
        Me.DataGridViewViand.Name = "DataGridViewViand"
        Me.DataGridViewViand.ReadOnly = True
        Me.DataGridViewViand.RowHeadersVisible = False
        Me.DataGridViewViand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewViand.Size = New System.Drawing.Size(503, 138)
        Me.DataGridViewViand.TabIndex = 94
        '
        'rbITEMS
        '
        Me.rbITEMS.AutoSize = True
        Me.rbITEMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbITEMS.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbITEMS.Location = New System.Drawing.Point(268, 18)
        Me.rbITEMS.Name = "rbITEMS"
        Me.rbITEMS.Size = New System.Drawing.Size(66, 22)
        Me.rbITEMS.TabIndex = 98
        Me.rbITEMS.TabStop = True
        Me.rbITEMS.Text = "ITEMS"
        Me.rbITEMS.UseVisualStyleBackColor = True
        '
        'rbCatering
        '
        Me.rbCatering.AutoSize = True
        Me.rbCatering.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbCatering.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCatering.Location = New System.Drawing.Point(352, 18)
        Me.rbCatering.Name = "rbCatering"
        Me.rbCatering.Size = New System.Drawing.Size(92, 22)
        Me.rbCatering.TabIndex = 99
        Me.rbCatering.TabStop = True
        Me.rbCatering.Text = "CATERING"
        Me.rbCatering.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(34, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 18)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "PRICE:"
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(138, 320)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(173, 26)
        Me.txtPrice.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(316, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "QUANTITY:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(34, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 18)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "ITEM:"
        '
        'txtItemCode
        '
        Me.txtItemCode.Enabled = False
        Me.txtItemCode.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(138, 244)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(173, 26)
        Me.txtItemCode.TabIndex = 106
        '
        'txtItem
        '
        Me.txtItem.Enabled = False
        Me.txtItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(138, 281)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(173, 26)
        Me.txtItem.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "ITEM CODE:"
        '
        'panelService
        '
        Me.panelService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelService.Controls.Add(Me.Label10)
        Me.panelService.Controls.Add(Me.DataGridViewServices)
        Me.panelService.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelService.Location = New System.Drawing.Point(17, 51)
        Me.panelService.Name = "panelService"
        Me.panelService.Size = New System.Drawing.Size(538, 178)
        Me.panelService.TabIndex = 97
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(-2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 18)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "SERVICES"
        '
        'DataGridViewServices
        '
        Me.DataGridViewServices.AllowUserToAddRows = False
        Me.DataGridViewServices.AllowUserToDeleteRows = False
        Me.DataGridViewServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewServices.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewServices.Location = New System.Drawing.Point(19, 23)
        Me.DataGridViewServices.Name = "DataGridViewServices"
        Me.DataGridViewServices.ReadOnly = True
        Me.DataGridViewServices.RowHeadersVisible = False
        Me.DataGridViewServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewServices.Size = New System.Drawing.Size(503, 138)
        Me.DataGridViewServices.TabIndex = 94
        '
        'rbServices
        '
        Me.rbServices.AutoSize = True
        Me.rbServices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbServices.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbServices.Location = New System.Drawing.Point(447, 18)
        Me.rbServices.Name = "rbServices"
        Me.rbServices.Size = New System.Drawing.Size(92, 22)
        Me.rbServices.TabIndex = 113
        Me.rbServices.TabStop = True
        Me.rbServices.Text = "SERVICES"
        Me.rbServices.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblName.Location = New System.Drawing.Point(15, 344)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(124, 20)
        Me.lblName.TabIndex = 114
        Me.lblName.Text = "RESERVATION ID:"
        '
        'lblEvent
        '
        Me.lblEvent.AutoSize = True
        Me.lblEvent.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEvent.ForeColor = System.Drawing.Color.SkyBlue
        Me.lblEvent.Location = New System.Drawing.Point(173, 261)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(124, 20)
        Me.lblEvent.TabIndex = 115
        Me.lblEvent.Text = "RESERVATION ID:"
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcess.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(258, 29)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(107, 48)
        Me.btnProcess.TabIndex = 79
        Me.btnProcess.Text = "PROCESS"
        Me.btnProcess.UseVisualStyleBackColor = False
        '
        'lblLogs
        '
        Me.lblLogs.AutoSize = True
        Me.lblLogs.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogs.ForeColor = System.Drawing.Color.SkyBlue
        Me.lblLogs.Location = New System.Drawing.Point(12, 246)
        Me.lblLogs.Name = "lblLogs"
        Me.lblLogs.Size = New System.Drawing.Size(79, 20)
        Me.lblLogs.TabIndex = 119
        Me.lblLogs.Text = "VATION ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtrental)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.res_id)
        Me.GroupBox1.Controls.Add(Me.rbITEMS)
        Me.GroupBox1.Controls.Add(Me.rbCatering)
        Me.GroupBox1.Controls.Add(Me.rbServices)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtItem)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.txtItemCode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.pcbxAddToCart)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.pcbxRemoveToCart)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.panelCatering)
        Me.GroupBox1.Controls.Add(Me.panelService)
        Me.GroupBox1.Controls.Add(Me.panelItems)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 375)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Details"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label13.Location = New System.Drawing.Point(318, 325)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 21)
        Me.Label13.TabIndex = 123
        Me.Label13.Text = "Label13"
        '
        'txtrental
        '
        Me.txtrental.AutoSize = True
        Me.txtrental.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtrental.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtrental.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtrental.Location = New System.Drawing.Point(312, 332)
        Me.txtrental.Name = "txtrental"
        Me.txtrental.Size = New System.Drawing.Size(0, 20)
        Me.txtrental.TabIndex = 122
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(415, 268)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(140, 26)
        Me.txtQuantity.TabIndex = 121
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(415, 236)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(140, 26)
        Me.txtSearch.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(316, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "ORDER:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.DataGridOrder)
        Me.GroupBox2.Controls.Add(Me.txtAmountDue)
        Me.GroupBox2.Controls.Add(Me.lblLogs)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblEvent)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(593, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 375)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order Process"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtPayment)
        Me.GroupBox3.Controls.Add(Me.rbFull)
        Me.GroupBox3.Controls.Add(Me.rbPartial)
        Me.GroupBox3.Controls.Add(Me.btnProcess)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(19, 281)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 83)
        Me.GroupBox3.TabIndex = 120
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(4, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 16)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "Down Payment"
        '
        'txtPayment
        '
        Me.txtPayment.Enabled = False
        Me.txtPayment.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.ForeColor = System.Drawing.Color.Blue
        Me.txtPayment.Location = New System.Drawing.Point(96, 49)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(156, 29)
        Me.txtPayment.TabIndex = 121
        '
        'rbFull
        '
        Me.rbFull.AutoSize = True
        Me.rbFull.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFull.Location = New System.Drawing.Point(158, 23)
        Me.rbFull.Name = "rbFull"
        Me.rbFull.Size = New System.Drawing.Size(98, 20)
        Me.rbFull.TabIndex = 1
        Me.rbFull.TabStop = True
        Me.rbFull.Text = "Full Payment"
        Me.rbFull.UseVisualStyleBackColor = True
        '
        'rbPartial
        '
        Me.rbPartial.AutoSize = True
        Me.rbPartial.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPartial.Location = New System.Drawing.Point(34, 23)
        Me.rbPartial.Name = "rbPartial"
        Me.rbPartial.Size = New System.Drawing.Size(113, 20)
        Me.rbPartial.TabIndex = 0
        Me.rbPartial.TabStop = True
        Me.rbPartial.Text = "Partial Payment"
        Me.rbPartial.UseVisualStyleBackColor = True
        '
        'pcbxAddToCart
        '
        Me.pcbxAddToCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbxAddToCart.Image = CType(resources.GetObject("pcbxAddToCart.Image"), System.Drawing.Image)
        Me.pcbxAddToCart.Location = New System.Drawing.Point(404, 304)
        Me.pcbxAddToCart.Name = "pcbxAddToCart"
        Me.pcbxAddToCart.Size = New System.Drawing.Size(60, 60)
        Me.pcbxAddToCart.TabIndex = 102
        Me.pcbxAddToCart.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pcbxAddToCart, "Add to cart")
        '
        'pcbxRemoveToCart
        '
        Me.pcbxRemoveToCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbxRemoveToCart.Image = CType(resources.GetObject("pcbxRemoveToCart.Image"), System.Drawing.Image)
        Me.pcbxRemoveToCart.Location = New System.Drawing.Point(483, 304)
        Me.pcbxRemoveToCart.Name = "pcbxRemoveToCart"
        Me.pcbxRemoveToCart.Size = New System.Drawing.Size(60, 60)
        Me.pcbxRemoveToCart.TabIndex = 103
        Me.pcbxRemoveToCart.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pcbxRemoveToCart, "Remove from cart")
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1015, 400)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "POS"
        Me.Text = "POS"
        CType(Me.DataGridOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridRENTAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelItems.ResumeLayout(False)
        Me.panelItems.PerformLayout()
        CType(Me.DataGridSELLING, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCatering.ResumeLayout(False)
        Me.panelCatering.PerformLayout()
        CType(Me.DataGridViewViand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelService.ResumeLayout(False)
        Me.panelService.PerformLayout()
        CType(Me.DataGridViewServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.pcbxAddToCart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbxRemoveToCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAmountDue As System.Windows.Forms.TextBox
    Friend WithEvents DataGridOrder As System.Windows.Forms.DataGridView
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents DataGridRENTAL As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents res_id As System.Windows.Forms.TextBox
    Friend WithEvents panelItems As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents panelCatering As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewViand As System.Windows.Forms.DataGridView
    Friend WithEvents rbITEMS As System.Windows.Forms.RadioButton
    Friend WithEvents rbCatering As System.Windows.Forms.RadioButton
    Friend WithEvents pcbxAddToCart As System.Windows.Forms.PictureBox
    Friend WithEvents pcbxRemoveToCart As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelService As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewServices As System.Windows.Forms.DataGridView
    Friend WithEvents rbServices As System.Windows.Forms.RadioButton
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblEvent As System.Windows.Forms.Label
    Friend WithEvents lblLogs As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents rbFull As System.Windows.Forms.RadioButton
    Friend WithEvents rbPartial As System.Windows.Forms.RadioButton
    Friend WithEvents txtrental As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridSELLING As System.Windows.Forms.DataGridView
    Friend WithEvents rbRENTAL As System.Windows.Forms.RadioButton
    Friend WithEvents rbSELLING As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
