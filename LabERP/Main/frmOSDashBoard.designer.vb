<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOSDashBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOSDashBoard))
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.btResults = New System.Windows.Forms.Button()
        Me.btRegistration = New System.Windows.Forms.Button()
        Me.btProfilesSetup = New System.Windows.Forms.Button()
        Me.btReportsCenter = New System.Windows.Forms.Button()
        Me.SideSplit = New System.Windows.Forms.SplitContainer()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.SalesDuty = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HubTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Title = New System.Windows.Forms.Label()
        Me.btSlide = New System.Windows.Forms.Button()
        Me.BTMin = New System.Windows.Forms.Button()
        Me.BTClose = New System.Windows.Forms.Button()
        Me.SlidPanel = New System.Windows.Forms.Panel()
        Me.PanTitle = New System.Windows.Forms.Panel()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.lblUserName = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.SideSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SideSplit.Panel1.SuspendLayout()
        Me.SideSplit.SuspendLayout()
        Me.ListsMenu.SuspendLayout()
        Me.SlidPanel.SuspendLayout()
        Me.PanTitle.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(190, 29)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1458, 759)
        Me.MainPanel.TabIndex = 15
        '
        'btResults
        '
        Me.btResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btResults.Dock = System.Windows.Forms.DockStyle.Top
        Me.btResults.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btResults.FlatAppearance.BorderSize = 0
        Me.btResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btResults.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btResults.ForeColor = System.Drawing.Color.Black
        Me.btResults.Image = CType(resources.GetObject("btResults.Image"), System.Drawing.Image)
        Me.btResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btResults.Location = New System.Drawing.Point(0, 76)
        Me.btResults.Name = "btResults"
        Me.btResults.Size = New System.Drawing.Size(190, 38)
        Me.btResults.TabIndex = 3
        Me.btResults.Text = "Results"
        Me.btResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btResults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btResults.UseVisualStyleBackColor = True
        '
        'btRegistration
        '
        Me.btRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btRegistration.Dock = System.Windows.Forms.DockStyle.Top
        Me.btRegistration.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btRegistration.FlatAppearance.BorderSize = 0
        Me.btRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRegistration.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btRegistration.ForeColor = System.Drawing.Color.Black
        Me.btRegistration.Image = Global.LabERP.My.Resources.Resources.Hema
        Me.btRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btRegistration.Location = New System.Drawing.Point(0, 38)
        Me.btRegistration.Name = "btRegistration"
        Me.btRegistration.Size = New System.Drawing.Size(190, 38)
        Me.btRegistration.TabIndex = 4
        Me.btRegistration.Text = "Registration"
        Me.btRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btRegistration.UseVisualStyleBackColor = True
        '
        'btProfilesSetup
        '
        Me.btProfilesSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btProfilesSetup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btProfilesSetup.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btProfilesSetup.FlatAppearance.BorderSize = 0
        Me.btProfilesSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btProfilesSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btProfilesSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btProfilesSetup.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btProfilesSetup.ForeColor = System.Drawing.Color.Black
        Me.btProfilesSetup.Image = Global.LabERP.My.Resources.Resources._8552_00001
        Me.btProfilesSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btProfilesSetup.Location = New System.Drawing.Point(0, 0)
        Me.btProfilesSetup.Name = "btProfilesSetup"
        Me.btProfilesSetup.Size = New System.Drawing.Size(190, 38)
        Me.btProfilesSetup.TabIndex = 6
        Me.btProfilesSetup.Text = "Profiles Setup"
        Me.btProfilesSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btProfilesSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btProfilesSetup.UseVisualStyleBackColor = True
        '
        'btReportsCenter
        '
        Me.btReportsCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btReportsCenter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btReportsCenter.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btReportsCenter.FlatAppearance.BorderSize = 0
        Me.btReportsCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btReportsCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btReportsCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btReportsCenter.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btReportsCenter.ForeColor = System.Drawing.Color.Black
        Me.btReportsCenter.Image = CType(resources.GetObject("btReportsCenter.Image"), System.Drawing.Image)
        Me.btReportsCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btReportsCenter.Location = New System.Drawing.Point(0, 374)
        Me.btReportsCenter.Name = "btReportsCenter"
        Me.btReportsCenter.Size = New System.Drawing.Size(190, 38)
        Me.btReportsCenter.TabIndex = 9
        Me.btReportsCenter.Text = "Reports Center"
        Me.btReportsCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btReportsCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btReportsCenter.UseVisualStyleBackColor = True
        Me.btReportsCenter.Visible = False
        '
        'SideSplit
        '
        Me.SideSplit.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SideSplit.Location = New System.Drawing.Point(0, 0)
        Me.SideSplit.Name = "SideSplit"
        Me.SideSplit.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SideSplit.Panel1
        '
        Me.SideSplit.Panel1.Controls.Add(Me.btResults)
        Me.SideSplit.Panel1.Controls.Add(Me.btRegistration)
        Me.SideSplit.Panel1.Controls.Add(Me.btProfilesSetup)
        Me.SideSplit.Panel1.Controls.Add(Me.btReportsCenter)
        Me.SideSplit.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SideSplit.Panel2
        '
        Me.SideSplit.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SideSplit.Size = New System.Drawing.Size(190, 757)
        Me.SideSplit.SplitterDistance = 412
        Me.SideSplit.SplitterWidth = 1
        Me.SideSplit.TabIndex = 10
        '
        'btSearch
        '
        Me.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btSearch.FlatAppearance.BorderSize = 0
        Me.btSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSearch.ForeColor = System.Drawing.Color.White
        Me.btSearch.Location = New System.Drawing.Point(1, 7)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(37, 36)
        Me.btSearch.TabIndex = 1
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'SalesDuty
        '
        Me.SalesDuty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SalesDuty.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.SalesDuty.ForeColor = System.Drawing.Color.White
        Me.SalesDuty.Name = "SalesDuty"
        Me.SalesDuty.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.SalesDuty.ShowShortcutKeys = False
        Me.SalesDuty.Size = New System.Drawing.Size(114, 36)
        Me.SalesDuty.Text = "الشحن"
        Me.SalesDuty.ToolTipText = "الدخول لشاشة النظام الرئيسية"
        '
        'ListsMenu
        '
        Me.ListsMenu.BackColor = System.Drawing.Color.Navy
        Me.ListsMenu.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ListsMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ListsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesDuty})
        Me.ListsMenu.Name = "ContextMenuStrip1"
        Me.ListsMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListsMenu.ShowImageMargin = False
        Me.ListsMenu.ShowItemToolTips = False
        Me.ListsMenu.Size = New System.Drawing.Size(115, 40)
        '
        'HubTimer
        '
        Me.HubTimer.Interval = 3000
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Dock = System.Windows.Forms.DockStyle.Left
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Location = New System.Drawing.Point(40, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(118, 26)
        Me.Title.TabIndex = 6
        Me.Title.Text = "Dashboard"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btSlide
        '
        Me.btSlide.BackgroundImage = CType(resources.GetObject("btSlide.BackgroundImage"), System.Drawing.Image)
        Me.btSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btSlide.Dock = System.Windows.Forms.DockStyle.Left
        Me.btSlide.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btSlide.FlatAppearance.BorderSize = 0
        Me.btSlide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btSlide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSlide.ForeColor = System.Drawing.Color.White
        Me.btSlide.Location = New System.Drawing.Point(0, 0)
        Me.btSlide.Name = "btSlide"
        Me.btSlide.Size = New System.Drawing.Size(40, 27)
        Me.btSlide.TabIndex = 7
        Me.btSlide.UseVisualStyleBackColor = True
        '
        'BTMin
        '
        Me.BTMin.BackColor = System.Drawing.Color.Transparent
        Me.BTMin.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTMin.ForeColor = System.Drawing.Color.Transparent
        Me.BTMin.Image = CType(resources.GetObject("BTMin.Image"), System.Drawing.Image)
        Me.BTMin.Location = New System.Drawing.Point(1568, 0)
        Me.BTMin.Name = "BTMin"
        Me.BTMin.Size = New System.Drawing.Size(39, 27)
        Me.BTMin.TabIndex = 3
        Me.BTMin.UseVisualStyleBackColor = False
        '
        'BTClose
        '
        Me.BTClose.BackColor = System.Drawing.Color.Transparent
        Me.BTClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTClose.Image = CType(resources.GetObject("BTClose.Image"), System.Drawing.Image)
        Me.BTClose.Location = New System.Drawing.Point(1607, 0)
        Me.BTClose.Name = "BTClose"
        Me.BTClose.Size = New System.Drawing.Size(39, 27)
        Me.BTClose.TabIndex = 2
        Me.BTClose.UseVisualStyleBackColor = False
        '
        'SlidPanel
        '
        Me.SlidPanel.BackColor = System.Drawing.Color.White
        Me.SlidPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SlidPanel.Controls.Add(Me.SideSplit)
        Me.SlidPanel.Controls.Add(Me.btSearch)
        Me.SlidPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SlidPanel.Location = New System.Drawing.Point(0, 29)
        Me.SlidPanel.Name = "SlidPanel"
        Me.SlidPanel.Size = New System.Drawing.Size(190, 759)
        Me.SlidPanel.TabIndex = 14
        '
        'PanTitle
        '
        Me.PanTitle.BackColor = System.Drawing.Color.White
        Me.PanTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanTitle.Controls.Add(Me.lblCompanyName)
        Me.PanTitle.Controls.Add(Me.Title)
        Me.PanTitle.Controls.Add(Me.btSlide)
        Me.PanTitle.Controls.Add(Me.BTMin)
        Me.PanTitle.Controls.Add(Me.BTClose)
        Me.PanTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTitle.ForeColor = System.Drawing.Color.Black
        Me.PanTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanTitle.Name = "PanTitle"
        Me.PanTitle.Size = New System.Drawing.Size(1648, 29)
        Me.PanTitle.TabIndex = 13
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblCompanyName.ForeColor = System.Drawing.Color.Black
        Me.lblCompanyName.Location = New System.Drawing.Point(1157, 0)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(411, 26)
        Me.lblCompanyName.TabIndex = 8
        Me.lblCompanyName.Text = "The Medical Lab and Consultation Center"
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUserName})
        Me.StatusBar.Location = New System.Drawing.Point(0, 788)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(1648, 22)
        Me.StatusBar.TabIndex = 16
        '
        'lblUserName
        '
        Me.lblUserName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(0, 17)
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmOSDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1648, 810)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.SlidPanel)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.PanTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOSDashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dash Board"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SideSplit.Panel1.ResumeLayout(False)
        CType(Me.SideSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SideSplit.ResumeLayout(False)
        Me.ListsMenu.ResumeLayout(False)
        Me.SlidPanel.ResumeLayout(False)
        Me.PanTitle.ResumeLayout(False)
        Me.PanTitle.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents btResults As Button
    Friend WithEvents btRegistration As Button
    Friend WithEvents btProfilesSetup As Button
    Friend WithEvents btReportsCenter As Button
    Friend WithEvents SideSplit As SplitContainer
    Friend WithEvents btSearch As Button
    Friend WithEvents SalesDuty As ToolStripMenuItem
    Friend WithEvents ListsMenu As ContextMenuStrip
    Friend WithEvents HubTimer As Timer
    Friend WithEvents Title As Label
    Friend WithEvents btSlide As Button
    Friend WithEvents BTMin As Button
    Friend WithEvents BTClose As Button
    Friend WithEvents SlidPanel As Panel
    Friend WithEvents PanTitle As Panel
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents lblUserName As ToolStripStatusLabel
End Class
