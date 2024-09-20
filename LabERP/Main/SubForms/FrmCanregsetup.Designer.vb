<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCanregsetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCanregsetup))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTDescription = New System.Windows.Forms.TextBox()
        Me.TXTCode = New System.Windows.Forms.TextBox()
        Me.CbProfile = New System.Windows.Forms.ComboBox()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.BtUpdate = New System.Windows.Forms.Button()
        Me.BtDelete = New System.Windows.Forms.Button()
        Me.DGVCanList = New System.Windows.Forms.DataGridView()
        Me.BTNew = New System.Windows.Forms.Button()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.btMini = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btClose = New System.Windows.Forms.Button()
        CType(Me.DGVCanList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(41, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(36, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Profile:"
        '
        'TXTDescription
        '
        Me.TXTDescription.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDescription.Location = New System.Drawing.Point(85, 40)
        Me.TXTDescription.Name = "TXTDescription"
        Me.TXTDescription.Size = New System.Drawing.Size(227, 26)
        Me.TXTDescription.TabIndex = 2
        '
        'TXTCode
        '
        Me.TXTCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCode.Location = New System.Drawing.Point(85, 76)
        Me.TXTCode.Name = "TXTCode"
        Me.TXTCode.Size = New System.Drawing.Size(227, 26)
        Me.TXTCode.TabIndex = 3
        '
        'CbProfile
        '
        Me.CbProfile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProfile.FormattingEnabled = True
        Me.CbProfile.Location = New System.Drawing.Point(85, 112)
        Me.CbProfile.Name = "CbProfile"
        Me.CbProfile.Size = New System.Drawing.Size(227, 27)
        Me.CbProfile.TabIndex = 4
        Me.CbProfile.Text = "Please select profile"
        '
        'BtSave
        '
        Me.BtSave.FlatAppearance.BorderSize = 2
        Me.BtSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtSave.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.BtSave.ForeColor = System.Drawing.Color.White
        Me.BtSave.Location = New System.Drawing.Point(85, 145)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(227, 39)
        Me.BtSave.TabIndex = 5
        Me.BtSave.Text = "Save"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'BtUpdate
        '
        Me.BtUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtUpdate.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.BtUpdate.ForeColor = System.Drawing.Color.White
        Me.BtUpdate.Location = New System.Drawing.Point(200, 190)
        Me.BtUpdate.Name = "BtUpdate"
        Me.BtUpdate.Size = New System.Drawing.Size(112, 39)
        Me.BtUpdate.TabIndex = 6
        Me.BtUpdate.Text = "Update"
        Me.BtUpdate.UseVisualStyleBackColor = True
        '
        'BtDelete
        '
        Me.BtDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtDelete.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.BtDelete.ForeColor = System.Drawing.Color.White
        Me.BtDelete.Location = New System.Drawing.Point(85, 190)
        Me.BtDelete.Name = "BtDelete"
        Me.BtDelete.Size = New System.Drawing.Size(109, 39)
        Me.BtDelete.TabIndex = 6
        Me.BtDelete.Text = "Delete"
        Me.BtDelete.UseVisualStyleBackColor = True
        '
        'DGVCanList
        '
        Me.DGVCanList.AllowUserToAddRows = False
        Me.DGVCanList.AllowUserToDeleteRows = False
        Me.DGVCanList.AllowUserToResizeRows = False
        Me.DGVCanList.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 14.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCanList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVCanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCanList.Location = New System.Drawing.Point(318, 39)
        Me.DGVCanList.Name = "DGVCanList"
        Me.DGVCanList.RowHeadersVisible = False
        Me.DGVCanList.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVCanList.RowTemplate.Height = 40
        Me.DGVCanList.Size = New System.Drawing.Size(471, 190)
        Me.DGVCanList.TabIndex = 7
        '
        'BTNew
        '
        Me.BTNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTNew.FlatAppearance.BorderSize = 0
        Me.BTNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNew.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BTNew.Location = New System.Drawing.Point(6, 241)
        Me.BTNew.Name = "BTNew"
        Me.BTNew.Size = New System.Drawing.Size(783, 39)
        Me.BTNew.TabIndex = 8
        Me.BTNew.Text = "Refresh"
        Me.BTNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNew.UseVisualStyleBackColor = False
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TopPanel.Controls.Add(Me.btMini)
        Me.TopPanel.Controls.Add(Me.Label5)
        Me.TopPanel.Controls.Add(Me.btClose)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(797, 33)
        Me.TopPanel.TabIndex = 357
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
        Me.btMini.Location = New System.Drawing.Point(723, 0)
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
        Me.btClose.Location = New System.Drawing.Point(760, 0)
        Me.btClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(35, 31)
        Me.btClose.TabIndex = 7
        Me.btClose.UseVisualStyleBackColor = False
        '
        'FrmCanregsetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(797, 289)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.BTNew)
        Me.Controls.Add(Me.DGVCanList)
        Me.Controls.Add(Me.BtDelete)
        Me.Controls.Add(Me.BtUpdate)
        Me.Controls.Add(Me.BtSave)
        Me.Controls.Add(Me.CbProfile)
        Me.Controls.Add(Me.TXTCode)
        Me.Controls.Add(Me.TXTDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCanregsetup"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Cancer Registry Setup"
        CType(Me.DGVCanList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTDescription As TextBox
    Friend WithEvents TXTCode As TextBox
    Friend WithEvents CbProfile As ComboBox
    Friend WithEvents BtSave As Button
    Friend WithEvents BtUpdate As Button
    Friend WithEvents BtDelete As Button
    Friend WithEvents DGVCanList As DataGridView
    Friend WithEvents BTNew As Button
    Friend WithEvents TopPanel As Panel
    Friend WithEvents btMini As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btClose As Button
End Class
