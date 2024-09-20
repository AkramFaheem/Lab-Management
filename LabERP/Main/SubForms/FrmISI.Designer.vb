<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmISI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmISI))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTISIValue = New System.Windows.Forms.TextBox()
        Me.BTNew = New System.Windows.Forms.Button()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.BTUpdate = New System.Windows.Forms.Button()
        Me.BTDelete = New System.Windows.Forms.Button()
        Me.CHKIsActive = New System.Windows.Forms.CheckBox()
        Me.DGVISIValue = New System.Windows.Forms.DataGridView()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.btMini = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btRefresh = New System.Windows.Forms.Button()
        CType(Me.DGVISIValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ISI Value:"
        '
        'TXTISIValue
        '
        Me.TXTISIValue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTISIValue.Location = New System.Drawing.Point(85, 44)
        Me.TXTISIValue.Name = "TXTISIValue"
        Me.TXTISIValue.Size = New System.Drawing.Size(66, 26)
        Me.TXTISIValue.TabIndex = 10
        '
        'BTNew
        '
        Me.BTNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNew.Location = New System.Drawing.Point(6, 89)
        Me.BTNew.Name = "BTNew"
        Me.BTNew.Size = New System.Drawing.Size(114, 33)
        Me.BTNew.TabIndex = 11
        Me.BTNew.Text = "Refresh"
        Me.BTNew.UseVisualStyleBackColor = True
        Me.BTNew.Visible = False
        '
        'BtSave
        '
        Me.BtSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSave.Location = New System.Drawing.Point(7, 89)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(240, 33)
        Me.BtSave.TabIndex = 12
        Me.BtSave.Text = "Save"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'BTUpdate
        '
        Me.BTUpdate.Enabled = False
        Me.BTUpdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTUpdate.Location = New System.Drawing.Point(6, 134)
        Me.BTUpdate.Name = "BTUpdate"
        Me.BTUpdate.Size = New System.Drawing.Size(114, 33)
        Me.BTUpdate.TabIndex = 13
        Me.BTUpdate.Text = "Update"
        Me.BTUpdate.UseVisualStyleBackColor = True
        '
        'BTDelete
        '
        Me.BTDelete.Enabled = False
        Me.BTDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTDelete.Location = New System.Drawing.Point(133, 134)
        Me.BTDelete.Name = "BTDelete"
        Me.BTDelete.Size = New System.Drawing.Size(114, 33)
        Me.BTDelete.TabIndex = 14
        Me.BTDelete.Text = "Delete"
        Me.BTDelete.UseVisualStyleBackColor = True
        '
        'CHKIsActive
        '
        Me.CHKIsActive.AutoSize = True
        Me.CHKIsActive.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKIsActive.Location = New System.Drawing.Point(164, 43)
        Me.CHKIsActive.Name = "CHKIsActive"
        Me.CHKIsActive.Size = New System.Drawing.Size(81, 23)
        Me.CHKIsActive.TabIndex = 15
        Me.CHKIsActive.Text = "Is Active"
        Me.CHKIsActive.UseVisualStyleBackColor = True
        '
        'DGVISIValue
        '
        Me.DGVISIValue.BackgroundColor = System.Drawing.Color.White
        Me.DGVISIValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVISIValue.Location = New System.Drawing.Point(250, 37)
        Me.DGVISIValue.Name = "DGVISIValue"
        Me.DGVISIValue.RowHeadersVisible = False
        Me.DGVISIValue.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVISIValue.Size = New System.Drawing.Size(312, 137)
        Me.DGVISIValue.TabIndex = 16
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
        Me.TopPanel.Size = New System.Drawing.Size(568, 33)
        Me.TopPanel.TabIndex = 358
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
        Me.btMini.Location = New System.Drawing.Point(494, 0)
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
        Me.Label5.Font = New System.Drawing.Font("Calibri", 19.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(419, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ISI Setup"
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
        Me.btClose.Location = New System.Drawing.Point(531, 0)
        Me.btClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(35, 31)
        Me.btClose.TabIndex = 7
        Me.btClose.UseVisualStyleBackColor = False
        '
        'btRefresh
        '
        Me.btRefresh.BackColor = System.Drawing.Color.Black
        Me.btRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btRefresh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btRefresh.FlatAppearance.BorderSize = 0
        Me.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRefresh.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.btRefresh.ForeColor = System.Drawing.Color.White
        Me.btRefresh.Location = New System.Drawing.Point(0, 183)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(568, 33)
        Me.btRefresh.TabIndex = 413
        Me.btRefresh.Text = "Refresh"
        Me.btRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btRefresh.UseVisualStyleBackColor = False
        '
        'FrmISI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(568, 216)
        Me.Controls.Add(Me.btRefresh)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.DGVISIValue)
        Me.Controls.Add(Me.CHKIsActive)
        Me.Controls.Add(Me.BTDelete)
        Me.Controls.Add(Me.BTUpdate)
        Me.Controls.Add(Me.BtSave)
        Me.Controls.Add(Me.BTNew)
        Me.Controls.Add(Me.TXTISIValue)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmISI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ISI Value Setup"
        CType(Me.DGVISIValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTISIValue As TextBox
    Friend WithEvents BTNew As Button
    Friend WithEvents BtSave As Button
    Friend WithEvents BTUpdate As Button
    Friend WithEvents BTDelete As Button
    Friend WithEvents CHKIsActive As CheckBox
    Friend WithEvents DGVISIValue As DataGridView
    Friend WithEvents TopPanel As Panel
    Friend WithEvents btMini As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btClose As Button
    Friend WithEvents btRefresh As Button
End Class
