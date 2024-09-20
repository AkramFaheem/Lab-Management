<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainDashBoard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainDashBoard))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BTISIValue = New FontAwesome.Sharp.IconButton()
        Me.btReportCenter = New FontAwesome.Sharp.IconButton()
        Me.PanelRear = New System.Windows.Forms.Panel()
        Me.btResult = New FontAwesome.Sharp.IconButton()
        Me.btRegistration = New FontAwesome.Sharp.IconButton()
        Me.btTestsProfile = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.ImgHome = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btSetting = New FontAwesome.Sharp.IconButton()
        Me.btReadyToPrint = New FontAwesome.Sharp.IconButton()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDeskTop = New System.Windows.Forms.Panel()
        Me.ListsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Waiting = New System.Windows.Forms.ToolStripMenuItem()
        Me.Postponed = New System.Windows.Forms.ToolStripMenuItem()
        Me.DelayedCases = New System.Windows.Forms.ToolStripMenuItem()
        Me.Exception = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaseCorrection = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ISI = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMails = New System.Windows.Forms.ToolStripMenuItem()
        Me.Users = New System.Windows.Forms.ToolStripMenuItem()
        Me.Recovery = New System.Windows.Forms.ToolStripMenuItem()
        Me.Culture = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListsMenu.SuspendLayout()
        Me.SettingMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BTISIValue)
        Me.PanelMenu.Controls.Add(Me.btReportCenter)
        Me.PanelMenu.Controls.Add(Me.PanelRear)
        Me.PanelMenu.Controls.Add(Me.btResult)
        Me.PanelMenu.Controls.Add(Me.btRegistration)
        Me.PanelMenu.Controls.Add(Me.btTestsProfile)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(127, 693)
        Me.PanelMenu.TabIndex = 2
        '
        'BTISIValue
        '
        Me.BTISIValue.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTISIValue.FlatAppearance.BorderSize = 0
        Me.BTISIValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTISIValue.ForeColor = System.Drawing.Color.Gray
        Me.BTISIValue.IconChar = FontAwesome.Sharp.IconChar.Italic
        Me.BTISIValue.IconColor = System.Drawing.Color.White
        Me.BTISIValue.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BTISIValue.IconSize = 32
        Me.BTISIValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTISIValue.Location = New System.Drawing.Point(0, 414)
        Me.BTISIValue.Name = "BTISIValue"
        Me.BTISIValue.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.BTISIValue.Size = New System.Drawing.Size(127, 47)
        Me.BTISIValue.TabIndex = 11
        Me.BTISIValue.Text = "ISI Value"
        Me.BTISIValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTISIValue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTISIValue.UseVisualStyleBackColor = True
        Me.BTISIValue.Visible = False
        '
        'btReportCenter
        '
        Me.btReportCenter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btReportCenter.FlatAppearance.BorderSize = 0
        Me.btReportCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btReportCenter.ForeColor = System.Drawing.Color.Gray
        Me.btReportCenter.IconChar = FontAwesome.Sharp.IconChar.Newspaper
        Me.btReportCenter.IconColor = System.Drawing.Color.White
        Me.btReportCenter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btReportCenter.IconSize = 32
        Me.btReportCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btReportCenter.Location = New System.Drawing.Point(0, 461)
        Me.btReportCenter.Name = "btReportCenter"
        Me.btReportCenter.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btReportCenter.Size = New System.Drawing.Size(127, 47)
        Me.btReportCenter.TabIndex = 9
        Me.btReportCenter.Text = "Report Center"
        Me.btReportCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btReportCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btReportCenter.UseVisualStyleBackColor = True
        Me.btReportCenter.Visible = False
        '
        'PanelRear
        '
        Me.PanelRear.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelRear.Location = New System.Drawing.Point(0, 508)
        Me.PanelRear.Name = "PanelRear"
        Me.PanelRear.Size = New System.Drawing.Size(127, 185)
        Me.PanelRear.TabIndex = 3
        '
        'btResult
        '
        Me.btResult.Dock = System.Windows.Forms.DockStyle.Top
        Me.btResult.FlatAppearance.BorderSize = 0
        Me.btResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btResult.ForeColor = System.Drawing.Color.Gray
        Me.btResult.IconChar = FontAwesome.Sharp.IconChar.Microscope
        Me.btResult.IconColor = System.Drawing.Color.White
        Me.btResult.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btResult.IconSize = 32
        Me.btResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btResult.Location = New System.Drawing.Point(0, 173)
        Me.btResult.Name = "btResult"
        Me.btResult.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btResult.Size = New System.Drawing.Size(127, 47)
        Me.btResult.TabIndex = 7
        Me.btResult.Text = "Result"
        Me.btResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btResult.UseVisualStyleBackColor = True
        '
        'btRegistration
        '
        Me.btRegistration.Dock = System.Windows.Forms.DockStyle.Top
        Me.btRegistration.FlatAppearance.BorderSize = 0
        Me.btRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRegistration.ForeColor = System.Drawing.Color.Gray
        Me.btRegistration.IconChar = FontAwesome.Sharp.IconChar.Registered
        Me.btRegistration.IconColor = System.Drawing.Color.White
        Me.btRegistration.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btRegistration.IconSize = 32
        Me.btRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btRegistration.Location = New System.Drawing.Point(0, 126)
        Me.btRegistration.Name = "btRegistration"
        Me.btRegistration.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btRegistration.Size = New System.Drawing.Size(127, 47)
        Me.btRegistration.TabIndex = 10
        Me.btRegistration.Text = "Register"
        Me.btRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btRegistration.UseVisualStyleBackColor = True
        '
        'btTestsProfile
        '
        Me.btTestsProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.btTestsProfile.FlatAppearance.BorderSize = 0
        Me.btTestsProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTestsProfile.ForeColor = System.Drawing.Color.Gray
        Me.btTestsProfile.IconChar = FontAwesome.Sharp.IconChar.ProductHunt
        Me.btTestsProfile.IconColor = System.Drawing.Color.White
        Me.btTestsProfile.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btTestsProfile.IconSize = 32
        Me.btTestsProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btTestsProfile.Location = New System.Drawing.Point(0, 79)
        Me.btTestsProfile.Name = "btTestsProfile"
        Me.btTestsProfile.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btTestsProfile.Size = New System.Drawing.Size(127, 47)
        Me.btTestsProfile.TabIndex = 5
        Me.btTestsProfile.Text = "Profiles Setup"
        Me.btTestsProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btTestsProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btTestsProfile.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.ImgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Padding = New System.Windows.Forms.Padding(0, 10, 10, 0)
        Me.PanelLogo.Size = New System.Drawing.Size(127, 79)
        Me.PanelLogo.TabIndex = 3
        '
        'ImgHome
        '
        Me.ImgHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ImgHome.BackgroundImage = CType(resources.GetObject("ImgHome.BackgroundImage"), System.Drawing.Image)
        Me.ImgHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ImgHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImgHome.ForeColor = System.Drawing.Color.Transparent
        Me.ImgHome.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ImgHome.IconColor = System.Drawing.Color.Transparent
        Me.ImgHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ImgHome.IconSize = 69
        Me.ImgHome.Location = New System.Drawing.Point(0, 10)
        Me.ImgHome.Name = "ImgHome"
        Me.ImgHome.Size = New System.Drawing.Size(117, 69)
        Me.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgHome.TabIndex = 0
        Me.ImgHome.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.btSetting)
        Me.PanelTitleBar.Controls.Add(Me.btReadyToPrint)
        Me.PanelTitleBar.Controls.Add(Me.btnMaximize)
        Me.PanelTitleBar.Controls.Add(Me.btnMinimize)
        Me.PanelTitleBar.Controls.Add(Me.btnExit)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(127, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(1323, 45)
        Me.PanelTitleBar.TabIndex = 3
        '
        'btSetting
        '
        Me.btSetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSetting.AutoSize = True
        Me.btSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btSetting.FlatAppearance.BorderSize = 0
        Me.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSetting.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btSetting.ForeColor = System.Drawing.Color.White
        Me.btSetting.IconChar = FontAwesome.Sharp.IconChar.Server
        Me.btSetting.IconColor = System.Drawing.Color.White
        Me.btSetting.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btSetting.IconSize = 24
        Me.btSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSetting.Location = New System.Drawing.Point(994, 5)
        Me.btSetting.Name = "btSetting"
        Me.btSetting.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btSetting.Size = New System.Drawing.Size(203, 30)
        Me.btSetting.TabIndex = 9
        Me.btSetting.Text = "Setting"
        Me.btSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSetting.UseVisualStyleBackColor = False
        '
        'btReadyToPrint
        '
        Me.btReadyToPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btReadyToPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btReadyToPrint.FlatAppearance.BorderSize = 0
        Me.btReadyToPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btReadyToPrint.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReadyToPrint.ForeColor = System.Drawing.Color.White
        Me.btReadyToPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btReadyToPrint.IconColor = System.Drawing.Color.White
        Me.btReadyToPrint.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btReadyToPrint.IconSize = 24
        Me.btReadyToPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btReadyToPrint.Location = New System.Drawing.Point(835, 5)
        Me.btReadyToPrint.Name = "btReadyToPrint"
        Me.btReadyToPrint.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btReadyToPrint.Size = New System.Drawing.Size(153, 30)
        Me.btReadyToPrint.TabIndex = 6
        Me.btReadyToPrint.Text = "Print Out List"
        Me.btReadyToPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btReadyToPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btReadyToPrint.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.BackgroundImage = CType(resources.GetObject("btnMaximize.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMaximize.ForeColor = System.Drawing.Color.Transparent
        Me.btnMaximize.Location = New System.Drawing.Point(1242, 6)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(39, 29)
        Me.btnMaximize.TabIndex = 5
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMinimize.ForeColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(1203, 6)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(39, 29)
        Me.btnMinimize.TabIndex = 4
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(1281, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(39, 29)
        Me.btnExit.TabIndex = 3
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(44, 7)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(62, 32)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.Lime
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.Lime
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(6, 8)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDeskTop
        '
        Me.PanelDeskTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDeskTop.BackgroundImage = CType(resources.GetObject("PanelDeskTop.BackgroundImage"), System.Drawing.Image)
        Me.PanelDeskTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDeskTop.Location = New System.Drawing.Point(127, 45)
        Me.PanelDeskTop.Name = "PanelDeskTop"
        Me.PanelDeskTop.Size = New System.Drawing.Size(1323, 648)
        Me.PanelDeskTop.TabIndex = 4
        '
        'ListsMenu
        '
        Me.ListsMenu.BackColor = System.Drawing.Color.Navy
        Me.ListsMenu.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ListsMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ListsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Waiting, Me.Postponed, Me.DelayedCases, Me.Exception, Me.CaseCorrection})
        Me.ListsMenu.Name = "ContextMenuStrip1"
        Me.ListsMenu.ShowImageMargin = False
        Me.ListsMenu.ShowItemToolTips = False
        Me.ListsMenu.Size = New System.Drawing.Size(164, 184)
        '
        'Waiting
        '
        Me.Waiting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Waiting.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Waiting.ForeColor = System.Drawing.Color.White
        Me.Waiting.Name = "Waiting"
        Me.Waiting.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.Waiting.ShowShortcutKeys = False
        Me.Waiting.Size = New System.Drawing.Size(163, 36)
        Me.Waiting.Text = "Waitting"
        Me.Waiting.ToolTipText = "الدخول لشاشة النظام الرئيسية"
        '
        'Postponed
        '
        Me.Postponed.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Postponed.ForeColor = System.Drawing.Color.White
        Me.Postponed.Name = "Postponed"
        Me.Postponed.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.Postponed.ShowShortcutKeys = False
        Me.Postponed.Size = New System.Drawing.Size(163, 36)
        Me.Postponed.Text = "Postponed"
        '
        'DelayedCases
        '
        Me.DelayedCases.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.DelayedCases.ForeColor = System.Drawing.Color.White
        Me.DelayedCases.Name = "DelayedCases"
        Me.DelayedCases.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DelayedCases.ShowShortcutKeys = False
        Me.DelayedCases.Size = New System.Drawing.Size(163, 36)
        Me.DelayedCases.Text = "Delayed"
        '
        'Exception
        '
        Me.Exception.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Exception.ForeColor = System.Drawing.Color.White
        Me.Exception.Name = "Exception"
        Me.Exception.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.Exception.ShowShortcutKeys = False
        Me.Exception.Size = New System.Drawing.Size(163, 36)
        Me.Exception.Text = "Exception"
        '
        'CaseCorrection
        '
        Me.CaseCorrection.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.CaseCorrection.ForeColor = System.Drawing.Color.White
        Me.CaseCorrection.Name = "CaseCorrection"
        Me.CaseCorrection.Size = New System.Drawing.Size(163, 36)
        Me.CaseCorrection.Text = "P. History"
        '
        'SettingMenu
        '
        Me.SettingMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.SettingMenu.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.SettingMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.SettingMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ISI, Me.EMails, Me.Users, Me.Recovery, Me.Culture})
        Me.SettingMenu.Name = "ContextMenuStrip1"
        Me.SettingMenu.ShowImageMargin = False
        Me.SettingMenu.ShowItemToolTips = False
        Me.SettingMenu.Size = New System.Drawing.Size(210, 206)
        '
        'ISI
        '
        Me.ISI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ISI.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.ISI.ForeColor = System.Drawing.Color.White
        Me.ISI.Name = "ISI"
        Me.ISI.ShowShortcutKeys = False
        Me.ISI.Size = New System.Drawing.Size(209, 36)
        Me.ISI.Text = "ISI Setup"
        '
        'EMails
        '
        Me.EMails.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.EMails.ForeColor = System.Drawing.Color.White
        Me.EMails.Name = "EMails"
        Me.EMails.ShowShortcutKeys = False
        Me.EMails.Size = New System.Drawing.Size(209, 36)
        Me.EMails.Text = "E Mails"
        Me.EMails.Visible = False
        '
        'Users
        '
        Me.Users.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Users.ForeColor = System.Drawing.Color.White
        Me.Users.Name = "Users"
        Me.Users.ShowShortcutKeys = False
        Me.Users.Size = New System.Drawing.Size(209, 36)
        Me.Users.Text = "Users"
        Me.Users.Visible = False
        '
        'Recovery
        '
        Me.Recovery.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Recovery.ForeColor = System.Drawing.Color.White
        Me.Recovery.Name = "Recovery"
        Me.Recovery.ShowShortcutKeys = False
        Me.Recovery.Size = New System.Drawing.Size(209, 36)
        Me.Recovery.Text = "Data Recovery"
        Me.Recovery.Visible = False
        '
        'Culture
        '
        Me.Culture.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Culture.ForeColor = System.Drawing.Color.White
        Me.Culture.Name = "Culture"
        Me.Culture.Size = New System.Drawing.Size(209, 36)
        Me.Culture.Text = "Culture Setup"
        '
        'frmMainDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 693)
        Me.Controls.Add(Me.PanelDeskTop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainDashBoard"
        Me.Text = "Main DashBoard"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListsMenu.ResumeLayout(False)
        Me.SettingMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents ImgHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btRegistration As FontAwesome.Sharp.IconButton
    Friend WithEvents btReportCenter As FontAwesome.Sharp.IconButton
    Friend WithEvents btResult As FontAwesome.Sharp.IconButton
    Friend WithEvents btTestsProfile As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelRear As Panel
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDeskTop As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btReadyToPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents ListsMenu As ContextMenuStrip
    Friend WithEvents Waiting As ToolStripMenuItem
    Friend WithEvents Postponed As ToolStripMenuItem
    Friend WithEvents DelayedCases As ToolStripMenuItem
    Friend WithEvents Exception As ToolStripMenuItem
    Friend WithEvents CaseCorrection As ToolStripMenuItem
    Friend WithEvents BTISIValue As FontAwesome.Sharp.IconButton
    Friend WithEvents btSetting As FontAwesome.Sharp.IconButton
    Friend WithEvents SettingMenu As ContextMenuStrip
    Friend WithEvents ISI As ToolStripMenuItem
    Friend WithEvents EMails As ToolStripMenuItem
    Friend WithEvents Users As ToolStripMenuItem
    Friend WithEvents Recovery As ToolStripMenuItem
    Friend WithEvents Culture As ToolStripMenuItem
End Class
