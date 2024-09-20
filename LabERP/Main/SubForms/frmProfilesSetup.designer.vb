<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfilesSetup
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
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.MainSplit = New System.Windows.Forms.SplitContainer()
        Me.FLP01 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btHide = New System.Windows.Forms.Button()
        Me.LLPrintProfileList = New System.Windows.Forms.LinkLabel()
        Me.btSetup = New System.Windows.Forms.Button()
        Me.FirstSplit = New System.Windows.Forms.SplitContainer()
        Me.TestsTree = New System.Windows.Forms.TreeView()
        Me.lblProfileTests = New System.Windows.Forms.Label()
        Me.SecondSplit = New System.Windows.Forms.SplitContainer()
        Me.ItemSplit = New System.Windows.Forms.SplitContainer()
        Me.TLPItemDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtProfile = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNR = New System.Windows.Forms.RichTextBox()
        Me.BottonsPanel = New System.Windows.Forms.Panel()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplit.Panel1.SuspendLayout()
        Me.MainSplit.Panel2.SuspendLayout()
        Me.MainSplit.SuspendLayout()
        CType(Me.FirstSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FirstSplit.Panel1.SuspendLayout()
        Me.FirstSplit.Panel2.SuspendLayout()
        Me.FirstSplit.SuspendLayout()
        CType(Me.SecondSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SecondSplit.Panel1.SuspendLayout()
        Me.SecondSplit.Panel2.SuspendLayout()
        Me.SecondSplit.SuspendLayout()
        CType(Me.ItemSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemSplit.Panel1.SuspendLayout()
        Me.ItemSplit.Panel2.SuspendLayout()
        Me.ItemSplit.SuspendLayout()
        Me.TLPItemDetails.SuspendLayout()
        Me.BottonsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btRefresh
        '
        Me.btRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btRefresh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btRefresh.FlatAppearance.BorderSize = 0
        Me.btRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRefresh.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btRefresh.ForeColor = System.Drawing.Color.White
        Me.btRefresh.Location = New System.Drawing.Point(0, 796)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btRefresh.Size = New System.Drawing.Size(175, 35)
        Me.btRefresh.TabIndex = 493
        Me.btRefresh.Text = "Refresh"
        Me.btRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btRefresh.UseVisualStyleBackColor = False
        '
        'MainSplit
        '
        Me.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.MainSplit.Location = New System.Drawing.Point(0, 0)
        Me.MainSplit.Name = "MainSplit"
        '
        'MainSplit.Panel1
        '
        Me.MainSplit.Panel1.Controls.Add(Me.FLP01)
        Me.MainSplit.Panel1.Controls.Add(Me.btHide)
        Me.MainSplit.Panel1.Controls.Add(Me.LLPrintProfileList)
        Me.MainSplit.Panel1.Controls.Add(Me.btSetup)
        Me.MainSplit.Panel1.Controls.Add(Me.btRefresh)
        '
        'MainSplit.Panel2
        '
        Me.MainSplit.Panel2.Controls.Add(Me.FirstSplit)
        Me.MainSplit.Size = New System.Drawing.Size(1255, 831)
        Me.MainSplit.SplitterDistance = 175
        Me.MainSplit.TabIndex = 494
        '
        'FLP01
        '
        Me.FLP01.AllowDrop = True
        Me.FLP01.AutoScroll = True
        Me.FLP01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FLP01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLP01.Location = New System.Drawing.Point(0, 44)
        Me.FLP01.Name = "FLP01"
        Me.FLP01.Size = New System.Drawing.Size(154, 715)
        Me.FLP01.TabIndex = 492
        '
        'btHide
        '
        Me.btHide.BackColor = System.Drawing.Color.ForestGreen
        Me.btHide.Dock = System.Windows.Forms.DockStyle.Right
        Me.btHide.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.btHide.Location = New System.Drawing.Point(154, 44)
        Me.btHide.Name = "btHide"
        Me.btHide.Size = New System.Drawing.Size(21, 715)
        Me.btHide.TabIndex = 2
        Me.btHide.Text = "<"
        Me.btHide.UseVisualStyleBackColor = False
        '
        'LLPrintProfileList
        '
        Me.LLPrintProfileList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LLPrintProfileList.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LLPrintProfileList.Location = New System.Drawing.Point(0, 759)
        Me.LLPrintProfileList.Name = "LLPrintProfileList"
        Me.LLPrintProfileList.Size = New System.Drawing.Size(175, 37)
        Me.LLPrintProfileList.TabIndex = 494
        Me.LLPrintProfileList.TabStop = True
        Me.LLPrintProfileList.Text = "Print Profiles List"
        Me.LLPrintProfileList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btSetup
        '
        Me.btSetup.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btSetup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btSetup.FlatAppearance.BorderSize = 0
        Me.btSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSetup.ForeColor = System.Drawing.Color.DarkGreen
        Me.btSetup.Location = New System.Drawing.Point(0, 0)
        Me.btSetup.Name = "btSetup"
        Me.btSetup.Size = New System.Drawing.Size(175, 44)
        Me.btSetup.TabIndex = 491
        Me.btSetup.Text = "Profile Setup"
        Me.btSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btSetup.UseVisualStyleBackColor = False
        '
        'FirstSplit
        '
        Me.FirstSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FirstSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.FirstSplit.Location = New System.Drawing.Point(0, 0)
        Me.FirstSplit.Name = "FirstSplit"
        '
        'FirstSplit.Panel1
        '
        Me.FirstSplit.Panel1.Controls.Add(Me.TestsTree)
        Me.FirstSplit.Panel1.Controls.Add(Me.lblProfileTests)
        '
        'FirstSplit.Panel2
        '
        Me.FirstSplit.Panel2.Controls.Add(Me.SecondSplit)
        Me.FirstSplit.Size = New System.Drawing.Size(1076, 831)
        Me.FirstSplit.SplitterDistance = 442
        Me.FirstSplit.TabIndex = 3
        '
        'TestsTree
        '
        Me.TestsTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TestsTree.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.TestsTree.Location = New System.Drawing.Point(0, 35)
        Me.TestsTree.Name = "TestsTree"
        Me.TestsTree.RightToLeftLayout = True
        Me.TestsTree.Size = New System.Drawing.Size(442, 796)
        Me.TestsTree.TabIndex = 456
        '
        'lblProfileTests
        '
        Me.lblProfileTests.BackColor = System.Drawing.Color.Transparent
        Me.lblProfileTests.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProfileTests.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lblProfileTests.Location = New System.Drawing.Point(0, 0)
        Me.lblProfileTests.Name = "lblProfileTests"
        Me.lblProfileTests.Size = New System.Drawing.Size(442, 35)
        Me.lblProfileTests.TabIndex = 11
        Me.lblProfileTests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SecondSplit
        '
        Me.SecondSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SecondSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SecondSplit.Location = New System.Drawing.Point(0, 0)
        Me.SecondSplit.Name = "SecondSplit"
        Me.SecondSplit.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SecondSplit.Panel1
        '
        Me.SecondSplit.Panel1.Controls.Add(Me.ItemSplit)
        '
        'SecondSplit.Panel2
        '
        Me.SecondSplit.Panel2.Controls.Add(Me.txtNR)
        Me.SecondSplit.Panel2.Controls.Add(Me.BottonsPanel)
        Me.SecondSplit.Size = New System.Drawing.Size(630, 831)
        Me.SecondSplit.SplitterDistance = 194
        Me.SecondSplit.TabIndex = 0
        '
        'ItemSplit
        '
        Me.ItemSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.ItemSplit.Location = New System.Drawing.Point(0, 0)
        Me.ItemSplit.Name = "ItemSplit"
        Me.ItemSplit.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ItemSplit.Panel1
        '
        Me.ItemSplit.Panel1.Controls.Add(Me.TLPItemDetails)
        Me.ItemSplit.Panel1.Controls.Add(Me.Label1)
        '
        'ItemSplit.Panel2
        '
        Me.ItemSplit.Panel2.Controls.Add(Me.Label14)
        Me.ItemSplit.Size = New System.Drawing.Size(630, 194)
        Me.ItemSplit.SplitterDistance = 157
        Me.ItemSplit.TabIndex = 0
        '
        'TLPItemDetails
        '
        Me.TLPItemDetails.ColumnCount = 2
        Me.TLPItemDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.TLPItemDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPItemDetails.Controls.Add(Me.txtValue, 1, 1)
        Me.TLPItemDetails.Controls.Add(Me.txtUnit, 1, 2)
        Me.TLPItemDetails.Controls.Add(Me.txtProfile, 1, 0)
        Me.TLPItemDetails.Controls.Add(Me.Label5, 0, 2)
        Me.TLPItemDetails.Controls.Add(Me.Label4, 0, 1)
        Me.TLPItemDetails.Controls.Add(Me.Label2, 0, 0)
        Me.TLPItemDetails.Location = New System.Drawing.Point(0, 35)
        Me.TLPItemDetails.Name = "TLPItemDetails"
        Me.TLPItemDetails.RowCount = 3
        Me.TLPItemDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPItemDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPItemDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPItemDetails.Size = New System.Drawing.Size(618, 115)
        Me.TLPItemDetails.TabIndex = 0
        '
        'txtValue
        '
        Me.txtValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtValue.BackColor = System.Drawing.Color.White
        Me.txtValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtValue.Location = New System.Drawing.Point(158, 41)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(457, 30)
        Me.txtValue.TabIndex = 405
        '
        'txtUnit
        '
        Me.txtUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtUnit.BackColor = System.Drawing.Color.White
        Me.txtUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtUnit.Location = New System.Drawing.Point(158, 79)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(457, 30)
        Me.txtUnit.TabIndex = 397
        '
        'txtProfile
        '
        Me.txtProfile.BackColor = System.Drawing.Color.White
        Me.txtProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProfile.Enabled = False
        Me.txtProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtProfile.Location = New System.Drawing.Point(158, 3)
        Me.txtProfile.Name = "txtProfile"
        Me.txtProfile.Size = New System.Drawing.Size(457, 30)
        Me.txtProfile.TabIndex = 395
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(3, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 39)
        Me.Label5.TabIndex = 391
        Me.Label5.Text = "Unit:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(3, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 38)
        Me.Label4.TabIndex = 390
        Me.Label4.Text = "Value Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 38)
        Me.Label2.TabIndex = 388
        Me.Label2.Text = "Profile:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 35)
        Me.Label1.TabIndex = 393
        Me.Label1.Text = "Value Record:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(630, 38)
        Me.Label14.TabIndex = 409
        Me.Label14.Text = "Normal Range:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNR
        '
        Me.txtNR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtNR.Location = New System.Drawing.Point(0, 0)
        Me.txtNR.Name = "txtNR"
        Me.txtNR.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtNR.Size = New System.Drawing.Size(630, 587)
        Me.txtNR.TabIndex = 1
        Me.txtNR.Text = ""
        '
        'BottonsPanel
        '
        Me.BottonsPanel.Controls.Add(Me.btSave)
        Me.BottonsPanel.Controls.Add(Me.btUpdate)
        Me.BottonsPanel.Controls.Add(Me.btDelete)
        Me.BottonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottonsPanel.Location = New System.Drawing.Point(0, 587)
        Me.BottonsPanel.Name = "BottonsPanel"
        Me.BottonsPanel.Size = New System.Drawing.Size(630, 46)
        Me.BottonsPanel.TabIndex = 0
        '
        'btSave
        '
        Me.btSave.BackColor = System.Drawing.Color.Black
        Me.btSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btSave.FlatAppearance.BorderSize = 0
        Me.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSave.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btSave.ForeColor = System.Drawing.Color.White
        Me.btSave.Location = New System.Drawing.Point(305, 0)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(113, 46)
        Me.btSave.TabIndex = 428
        Me.btSave.Text = "Save"
        Me.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btSave.UseVisualStyleBackColor = False
        '
        'btUpdate
        '
        Me.btUpdate.BackColor = System.Drawing.Color.Gray
        Me.btUpdate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btUpdate.Enabled = False
        Me.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btUpdate.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.btUpdate.ForeColor = System.Drawing.Color.White
        Me.btUpdate.Location = New System.Drawing.Point(418, 0)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(111, 46)
        Me.btUpdate.TabIndex = 429
        Me.btUpdate.Text = "Update"
        Me.btUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btUpdate.UseVisualStyleBackColor = False
        '
        'btDelete
        '
        Me.btDelete.BackColor = System.Drawing.Color.Maroon
        Me.btDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btDelete.Enabled = False
        Me.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btDelete.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.btDelete.ForeColor = System.Drawing.Color.White
        Me.btDelete.Location = New System.Drawing.Point(529, 0)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(101, 46)
        Me.btDelete.TabIndex = 430
        Me.btDelete.Text = "Delete"
        Me.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btDelete.UseVisualStyleBackColor = False
        '
        'frmProfilesSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1255, 831)
        Me.Controls.Add(Me.MainSplit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProfilesSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Setup Item"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainSplit.Panel1.ResumeLayout(False)
        Me.MainSplit.Panel2.ResumeLayout(False)
        CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplit.ResumeLayout(False)
        Me.FirstSplit.Panel1.ResumeLayout(False)
        Me.FirstSplit.Panel2.ResumeLayout(False)
        CType(Me.FirstSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FirstSplit.ResumeLayout(False)
        Me.SecondSplit.Panel1.ResumeLayout(False)
        Me.SecondSplit.Panel2.ResumeLayout(False)
        CType(Me.SecondSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SecondSplit.ResumeLayout(False)
        Me.ItemSplit.Panel1.ResumeLayout(False)
        Me.ItemSplit.Panel1.PerformLayout()
        Me.ItemSplit.Panel2.ResumeLayout(False)
        CType(Me.ItemSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemSplit.ResumeLayout(False)
        Me.TLPItemDetails.ResumeLayout(False)
        Me.TLPItemDetails.PerformLayout()
        Me.BottonsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btRefresh As Button
    Friend WithEvents MainSplit As SplitContainer
    Friend WithEvents btSetup As Button
    Friend WithEvents FLP01 As FlowLayoutPanel
    Friend WithEvents btHide As Button
    Friend WithEvents FirstSplit As SplitContainer
    Friend WithEvents lblProfileTests As Label
    Friend WithEvents TestsTree As TreeView
    Friend WithEvents SecondSplit As SplitContainer
    Friend WithEvents ItemSplit As SplitContainer
    Friend WithEvents TLPItemDetails As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProfile As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BottonsPanel As Panel
    Friend WithEvents txtNR As RichTextBox
    Friend WithEvents btSave As Button
    Friend WithEvents btUpdate As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents LLPrintProfileList As LinkLabel
End Class
