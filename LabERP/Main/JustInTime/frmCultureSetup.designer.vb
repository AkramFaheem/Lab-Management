<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCultureSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCultureSetup))
        Me.dgMain = New System.Windows.Forms.DataGridView()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.btMini = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btRefresh = New System.Windows.Forms.Button()
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgMain
        '
        Me.dgMain.AllowUserToDeleteRows = False
        Me.dgMain.AllowUserToOrderColumns = True
        Me.dgMain.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMain.GridColor = System.Drawing.Color.MistyRose
        Me.dgMain.Location = New System.Drawing.Point(0, 33)
        Me.dgMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgMain.Name = "dgMain"
        Me.dgMain.RowHeadersVisible = False
        Me.dgMain.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMain.RowTemplate.Height = 30
        Me.dgMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMain.Size = New System.Drawing.Size(535, 503)
        Me.dgMain.TabIndex = 300
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
        Me.TopPanel.Size = New System.Drawing.Size(535, 33)
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
        Me.btMini.Location = New System.Drawing.Point(461, 0)
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
        Me.Label5.Text = "Culture Lock-up Setup"
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
        Me.btClose.Location = New System.Drawing.Point(498, 0)
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
        Me.btRefresh.Location = New System.Drawing.Point(0, 536)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(535, 33)
        Me.btRefresh.TabIndex = 412
        Me.btRefresh.Text = "Refresh"
        Me.btRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btRefresh.UseVisualStyleBackColor = False
        '
        'frmCultureSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(535, 569)
        Me.Controls.Add(Me.dgMain)
        Me.Controls.Add(Me.btRefresh)
        Me.Controls.Add(Me.TopPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCultureSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Culture Lock-up Setup"
        CType(Me.dgMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgMain As DataGridView
    Friend WithEvents TopPanel As Panel
    Friend WithEvents btMini As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btClose As Button
    Friend WithEvents btRefresh As Button
End Class
