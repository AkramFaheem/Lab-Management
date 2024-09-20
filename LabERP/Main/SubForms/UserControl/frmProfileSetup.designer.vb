<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfileSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfileSetup))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.btMini = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btClose = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.dgvTestValues = New System.Windows.Forms.DataGridView()
        Me.TLProfileImage = New System.Windows.Forms.TableLayoutPanel()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.btExplorer = New System.Windows.Forms.Button()
        Me.pbMain = New System.Windows.Forms.PictureBox()
        Me.cbTrans = New System.Windows.Forms.ComboBox()
        Me.txtFamily = New System.Windows.Forms.TextBox()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.lblTestName = New System.Windows.Forms.Label()
        Me.PDFdialog = New System.Windows.Forms.OpenFileDialog()
        Me.PanelGRUD = New System.Windows.Forms.Panel()
        Me.btUpdateName = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TopPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        CType(Me.dgvTestValues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLProfileImage.SuspendLayout()
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGRUD.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.Black
        Me.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TopPanel.Controls.Add(Me.btMini)
        Me.TopPanel.Controls.Add(Me.Label5)
        Me.TopPanel.Controls.Add(Me.btClose)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(943, 33)
        Me.TopPanel.TabIndex = 356
        '
        'btMini
        '
        Me.btMini.BackColor = System.Drawing.Color.Black
        Me.btMini.BackgroundImage = CType(resources.GetObject("btMini.BackgroundImage"), System.Drawing.Image)
        Me.btMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btMini.Dock = System.Windows.Forms.DockStyle.Right
        Me.btMini.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btMini.ForeColor = System.Drawing.Color.Black
        Me.btMini.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btMini.Location = New System.Drawing.Point(869, 0)
        Me.btMini.Margin = New System.Windows.Forms.Padding(4)
        Me.btMini.Name = "btMini"
        Me.btMini.Size = New System.Drawing.Size(37, 31)
        Me.btMini.TabIndex = 12
        Me.btMini.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(239, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Profile Setup"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btClose
        '
        Me.btClose.BackColor = System.Drawing.Color.Black
        Me.btClose.BackgroundImage = CType(resources.GetObject("btClose.BackgroundImage"), System.Drawing.Image)
        Me.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btClose.ForeColor = System.Drawing.Color.Black
        Me.btClose.Location = New System.Drawing.Point(906, 0)
        Me.btClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(35, 31)
        Me.btClose.TabIndex = 7
        Me.btClose.UseVisualStyleBackColor = False
        '
        'MainPanel
        '
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.dgvTestValues)
        Me.MainPanel.Controls.Add(Me.TLProfileImage)
        Me.MainPanel.Controls.Add(Me.cbTrans)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MainPanel.Location = New System.Drawing.Point(0, 33)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(590, 448)
        Me.MainPanel.TabIndex = 357
        '
        'dgvTestValues
        '
        Me.dgvTestValues.AllowUserToAddRows = False
        Me.dgvTestValues.AllowUserToDeleteRows = False
        Me.dgvTestValues.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTestValues.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTestValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTestValues.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTestValues.Location = New System.Drawing.Point(200, 34)
        Me.dgvTestValues.Name = "dgvTestValues"
        Me.dgvTestValues.RowHeadersVisible = False
        Me.dgvTestValues.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTestValues.RowTemplate.Height = 30
        Me.dgvTestValues.Size = New System.Drawing.Size(388, 412)
        Me.dgvTestValues.TabIndex = 504
        '
        'TLProfileImage
        '
        Me.TLProfileImage.ColumnCount = 1
        Me.TLProfileImage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLProfileImage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLProfileImage.Controls.Add(Me.btUpdate, 0, 2)
        Me.TLProfileImage.Controls.Add(Me.btExplorer, 0, 1)
        Me.TLProfileImage.Controls.Add(Me.pbMain, 0, 0)
        Me.TLProfileImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.TLProfileImage.Location = New System.Drawing.Point(0, 34)
        Me.TLProfileImage.Name = "TLProfileImage"
        Me.TLProfileImage.RowCount = 3
        Me.TLProfileImage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLProfileImage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TLProfileImage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TLProfileImage.Size = New System.Drawing.Size(200, 412)
        Me.TLProfileImage.TabIndex = 503
        '
        'btUpdate
        '
        Me.btUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btUpdate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdate.Location = New System.Drawing.Point(3, 322)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(194, 87)
        Me.btUpdate.TabIndex = 389
        Me.btUpdate.Text = "Save Image"
        Me.btUpdate.UseVisualStyleBackColor = True
        '
        'btExplorer
        '
        Me.btExplorer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btExplorer.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExplorer.Location = New System.Drawing.Point(3, 274)
        Me.btExplorer.Name = "btExplorer"
        Me.btExplorer.Size = New System.Drawing.Size(194, 42)
        Me.btExplorer.TabIndex = 388
        Me.btExplorer.Text = "Explorer"
        Me.btExplorer.UseVisualStyleBackColor = True
        '
        'pbMain
        '
        Me.pbMain.BackColor = System.Drawing.Color.White
        Me.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbMain.Location = New System.Drawing.Point(3, 3)
        Me.pbMain.Name = "pbMain"
        Me.pbMain.Size = New System.Drawing.Size(194, 265)
        Me.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMain.TabIndex = 387
        Me.pbMain.TabStop = False
        '
        'cbTrans
        '
        Me.cbTrans.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbTrans.DropDownHeight = 150
        Me.cbTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTrans.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold)
        Me.cbTrans.ForeColor = System.Drawing.Color.Black
        Me.cbTrans.FormattingEnabled = True
        Me.cbTrans.IntegralHeight = False
        Me.cbTrans.Location = New System.Drawing.Point(0, 0)
        Me.cbTrans.Name = "cbTrans"
        Me.cbTrans.Size = New System.Drawing.Size(588, 34)
        Me.cbTrans.TabIndex = 501
        '
        'txtFamily
        '
        Me.txtFamily.BackColor = System.Drawing.Color.Black
        Me.txtFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFamily.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtFamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtFamily.ForeColor = System.Drawing.Color.White
        Me.txtFamily.Location = New System.Drawing.Point(0, 163)
        Me.txtFamily.Multiline = True
        Me.txtFamily.Name = "txtFamily"
        Me.txtFamily.Size = New System.Drawing.Size(349, 98)
        Me.txtFamily.TabIndex = 396
        '
        'btAdd
        '
        Me.btAdd.BackColor = System.Drawing.Color.DarkGreen
        Me.btAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAdd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.ForeColor = System.Drawing.Color.Lime
        Me.btAdd.Location = New System.Drawing.Point(0, 126)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(349, 318)
        Me.btAdd.TabIndex = 386
        Me.btAdd.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Insert " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Profile"
        Me.btAdd.UseVisualStyleBackColor = False
        '
        'lblTestName
        '
        Me.lblTestName.BackColor = System.Drawing.Color.Black
        Me.lblTestName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTestName.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.lblTestName.ForeColor = System.Drawing.Color.Lime
        Me.lblTestName.Location = New System.Drawing.Point(0, 0)
        Me.lblTestName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTestName.Name = "lblTestName"
        Me.lblTestName.Size = New System.Drawing.Size(349, 126)
        Me.lblTestName.TabIndex = 9
        Me.lblTestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelGRUD
        '
        Me.PanelGRUD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelGRUD.Controls.Add(Me.btUpdateName)
        Me.PanelGRUD.Controls.Add(Me.btDelete)
        Me.PanelGRUD.Controls.Add(Me.txtFamily)
        Me.PanelGRUD.Controls.Add(Me.Label1)
        Me.PanelGRUD.Controls.Add(Me.btAdd)
        Me.PanelGRUD.Controls.Add(Me.lblTestName)
        Me.PanelGRUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGRUD.Location = New System.Drawing.Point(590, 33)
        Me.PanelGRUD.Name = "PanelGRUD"
        Me.PanelGRUD.Size = New System.Drawing.Size(353, 448)
        Me.PanelGRUD.TabIndex = 358
        '
        'btUpdateName
        '
        Me.btUpdateName.BackColor = System.Drawing.Color.Black
        Me.btUpdateName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btUpdateName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btUpdateName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdateName.ForeColor = System.Drawing.Color.Lime
        Me.btUpdateName.Location = New System.Drawing.Point(0, 344)
        Me.btUpdateName.Name = "btUpdateName"
        Me.btUpdateName.Size = New System.Drawing.Size(349, 55)
        Me.btUpdateName.TabIndex = 399
        Me.btUpdateName.Text = "Update Profile Name"
        Me.btUpdateName.UseVisualStyleBackColor = False
        '
        'btDelete
        '
        Me.btDelete.BackColor = System.Drawing.Color.Red
        Me.btDelete.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btDelete.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelete.ForeColor = System.Drawing.Color.White
        Me.btDelete.Location = New System.Drawing.Point(0, 399)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(349, 45)
        Me.btDelete.TabIndex = 398
        Me.btDelete.Text = "Delete Profile"
        Me.btDelete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 126)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 37)
        Me.Label1.TabIndex = 397
        Me.Label1.Text = "Profile Name Of Update:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmProfileSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(943, 481)
        Me.Controls.Add(Me.PanelGRUD)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProfileSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إعداد الحركات المالية"
        Me.TopPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        CType(Me.dgvTestValues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLProfileImage.ResumeLayout(False)
        CType(Me.pbMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGRUD.ResumeLayout(False)
        Me.PanelGRUD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents btMini As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btClose As Button
    Friend WithEvents MainPanel As Panel
    Friend WithEvents cbTrans As ComboBox
    Friend WithEvents PDFdialog As OpenFileDialog
    Friend WithEvents lblTestName As Label
    Friend WithEvents btAdd As Button
    Friend WithEvents txtFamily As TextBox
    Friend WithEvents TLProfileImage As TableLayoutPanel
    Friend WithEvents btExplorer As Button
    Friend WithEvents pbMain As PictureBox
    Friend WithEvents dgvTestValues As DataGridView
    Friend WithEvents PanelGRUD As Panel
    Friend WithEvents btDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btUpdate As Button
    Friend WithEvents btUpdateName As Button
End Class
