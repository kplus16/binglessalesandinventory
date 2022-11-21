<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Header = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pcbxCATERING = New System.Windows.Forms.PictureBox()
        Me.pcbxRESERVATION = New System.Windows.Forms.PictureBox()
        Me.pcbxSupplier = New System.Windows.Forms.PictureBox()
        Me.pcbxACCOUNTS = New System.Windows.Forms.PictureBox()
        Me.pcbxREPORTS = New System.Windows.Forms.PictureBox()
        Me.pcbxITEMS = New System.Windows.Forms.PictureBox()
        Me.pcbxSERVICES = New System.Windows.Forms.PictureBox()
        Me.time = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LOGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKUPDATABSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbxCATERING, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbxRESERVATION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbxSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbxACCOUNTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbxREPORTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbxITEMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbxSERVICES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Header.BackgroundImage = CType(resources.GetObject("Header.BackgroundImage"), System.Drawing.Image)
        Me.Header.Controls.Add(Me.lblTitle)
        Me.Header.Controls.Add(Me.PictureBox1)
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1017, 120)
        Me.Header.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(936, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(59, 20)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "NAME"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(922, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 86)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.pcbxCATERING)
        Me.Panel1.Controls.Add(Me.pcbxRESERVATION)
        Me.Panel1.Controls.Add(Me.pcbxSupplier)
        Me.Panel1.Controls.Add(Me.pcbxACCOUNTS)
        Me.Panel1.Controls.Add(Me.pcbxREPORTS)
        Me.Panel1.Controls.Add(Me.pcbxITEMS)
        Me.Panel1.Controls.Add(Me.pcbxSERVICES)
        Me.Panel1.Location = New System.Drawing.Point(0, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1017, 128)
        Me.Panel1.TabIndex = 2
        '
        'pcbxCATERING
        '
        Me.pcbxCATERING.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbxCATERING.Image = Global.BinglesSalesAndInventory.My.Resources.Resources.catering
        Me.pcbxCATERING.Location = New System.Drawing.Point(162, 2)
        Me.pcbxCATERING.Name = "pcbxCATERING"
        Me.pcbxCATERING.Size = New System.Drawing.Size(120, 119)
        Me.pcbxCATERING.TabIndex = 4
        Me.pcbxCATERING.TabStop = False
        '
        'pcbxRESERVATION
        '
        Me.pcbxRESERVATION.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbxRESERVATION.Image = Global.BinglesSalesAndInventory.My.Resources.Resources.resevation
        Me.pcbxRESERVATION.Location = New System.Drawing.Point(10, 2)
        Me.pcbxRESERVATION.Name = "pcbxRESERVATION"
        Me.pcbxRESERVATION.Size = New System.Drawing.Size(121, 119)
        Me.pcbxRESERVATION.TabIndex = 6
        Me.pcbxRESERVATION.TabStop = False
        '
        'pcbxSupplier
        '
        Me.pcbxSupplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbxSupplier.Image = CType(resources.GetObject("pcbxSupplier.Image"), System.Drawing.Image)
        Me.pcbxSupplier.Location = New System.Drawing.Point(594, 2)
        Me.pcbxSupplier.Name = "pcbxSupplier"
        Me.pcbxSupplier.Size = New System.Drawing.Size(121, 119)
        Me.pcbxSupplier.TabIndex = 0
        Me.pcbxSupplier.TabStop = False
        '
        'pcbxACCOUNTS
        '
        Me.pcbxACCOUNTS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbxACCOUNTS.Image = CType(resources.GetObject("pcbxACCOUNTS.Image"), System.Drawing.Image)
        Me.pcbxACCOUNTS.Location = New System.Drawing.Point(889, 2)
        Me.pcbxACCOUNTS.Name = "pcbxACCOUNTS"
        Me.pcbxACCOUNTS.Size = New System.Drawing.Size(121, 119)
        Me.pcbxACCOUNTS.TabIndex = 5
        Me.pcbxACCOUNTS.TabStop = False
        '
        'pcbxREPORTS
        '
        Me.pcbxREPORTS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbxREPORTS.Image = CType(resources.GetObject("pcbxREPORTS.Image"), System.Drawing.Image)
        Me.pcbxREPORTS.Location = New System.Drawing.Point(742, 2)
        Me.pcbxREPORTS.Name = "pcbxREPORTS"
        Me.pcbxREPORTS.Size = New System.Drawing.Size(120, 119)
        Me.pcbxREPORTS.TabIndex = 3
        Me.pcbxREPORTS.TabStop = False
        '
        'pcbxITEMS
        '
        Me.pcbxITEMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbxITEMS.Image = CType(resources.GetObject("pcbxITEMS.Image"), System.Drawing.Image)
        Me.pcbxITEMS.Location = New System.Drawing.Point(306, 2)
        Me.pcbxITEMS.Name = "pcbxITEMS"
        Me.pcbxITEMS.Size = New System.Drawing.Size(118, 119)
        Me.pcbxITEMS.TabIndex = 2
        Me.pcbxITEMS.TabStop = False
        '
        'pcbxSERVICES
        '
        Me.pcbxSERVICES.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbxSERVICES.Image = Global.BinglesSalesAndInventory.My.Resources.Resources.ballon
        Me.pcbxSERVICES.Location = New System.Drawing.Point(450, 2)
        Me.pcbxSERVICES.Name = "pcbxSERVICES"
        Me.pcbxSERVICES.Size = New System.Drawing.Size(121, 119)
        Me.pcbxSERVICES.TabIndex = 1
        Me.pcbxSERVICES.TabStop = False
        '
        'time
        '
        Me.time.Enabled = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(0, 247)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1017, 404)
        Me.Panel4.TabIndex = 5
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGSToolStripMenuItem, Me.LOGOUTToolStripMenuItem, Me.BACKUPDATABSEToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(174, 70)
        '
        'LOGSToolStripMenuItem
        '
        Me.LOGSToolStripMenuItem.Name = "LOGSToolStripMenuItem"
        Me.LOGSToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LOGSToolStripMenuItem.Text = "LOGS"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'BACKUPDATABSEToolStripMenuItem
        '
        Me.BACKUPDATABSEToolStripMenuItem.Name = "BACKUPDATABSEToolStripMenuItem"
        Me.BACKUPDATABSEToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.BACKUPDATABSEToolStripMenuItem.Text = "BACK UP DATABSE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 651)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Header)
        Me.IsMdiContainer = True
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bingle's Sales and Inventory"
        Me.Header.ResumeLayout(False)
        Me.Header.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pcbxCATERING, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbxRESERVATION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbxSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbxACCOUNTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbxREPORTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbxITEMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbxSERVICES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Header As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pcbxACCOUNTS As System.Windows.Forms.PictureBox
    Friend WithEvents pcbxCATERING As System.Windows.Forms.PictureBox
    Friend WithEvents pcbxREPORTS As System.Windows.Forms.PictureBox
    Friend WithEvents pcbxITEMS As System.Windows.Forms.PictureBox
    Friend WithEvents pcbxSERVICES As System.Windows.Forms.PictureBox
    Friend WithEvents time As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents pcbxSupplier As System.Windows.Forms.PictureBox
    Friend WithEvents pcbxRESERVATION As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LOGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents BACKUPDATABSEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
