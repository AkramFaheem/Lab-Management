<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReg
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MainSplit = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBLPNoR = New System.Windows.Forms.Label()
        Me.dgvProfiles = New System.Windows.Forms.DataGridView()
        Me.TXTFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SecondSplit = New System.Windows.Forms.SplitContainer()
        Me.ChkAllItems = New System.Windows.Forms.CheckBox()
        Me.dgvSelectedTest = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TLPConsultant = New System.Windows.Forms.TableLayoutPanel()
        Me.TXTconsultant = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvSelectedProfile = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PatientProfilePanel = New System.Windows.Forms.Panel()
        Me.TXTPatientName = New System.Windows.Forms.TextBox()
        Me.btPatientUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvRegisteredRoutine = New System.Windows.Forms.DataGridView()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.TXTRoutineFilter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btHide = New System.Windows.Forms.Button()
        Me.ExpandToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplit.Panel1.SuspendLayout()
        Me.MainSplit.Panel2.SuspendLayout()
        Me.MainSplit.SuspendLayout()
        CType(Me.dgvProfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SecondSplit.Panel1.SuspendLayout()
        Me.SecondSplit.Panel2.SuspendLayout()
        Me.SecondSplit.SuspendLayout()
        CType(Me.dgvSelectedTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPConsultant.SuspendLayout()
        CType(Me.dgvSelectedProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientProfilePanel.SuspendLayout()
        CType(Me.dgvRegisteredRoutine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainSplit
        '
        Me.MainSplit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.MainSplit.Location = New System.Drawing.Point(0, 0)
        Me.MainSplit.Name = "MainSplit"
        '
        'MainSplit.Panel1
        '
        Me.MainSplit.Panel1.Controls.Add(Me.Label6)
        Me.MainSplit.Panel1.Controls.Add(Me.LBLPNoR)
        Me.MainSplit.Panel1.Controls.Add(Me.dgvProfiles)
        Me.MainSplit.Panel1.Controls.Add(Me.TXTFilter)
        Me.MainSplit.Panel1.Controls.Add(Me.Label1)
        '
        'MainSplit.Panel2
        '
        Me.MainSplit.Panel2.Controls.Add(Me.SecondSplit)
        Me.MainSplit.Size = New System.Drawing.Size(1354, 798)
        Me.MainSplit.SplitterDistance = 343
        Me.MainSplit.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(203, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total:"
        '
        'LBLPNoR
        '
        Me.LBLPNoR.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LBLPNoR.Location = New System.Drawing.Point(272, 4)
        Me.LBLPNoR.Name = "LBLPNoR"
        Me.LBLPNoR.Size = New System.Drawing.Size(66, 28)
        Me.LBLPNoR.TabIndex = 5
        Me.LBLPNoR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvProfiles
        '
        Me.dgvProfiles.AllowUserToAddRows = False
        Me.dgvProfiles.AllowUserToDeleteRows = False
        Me.dgvProfiles.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProfiles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProfiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProfiles.Location = New System.Drawing.Point(0, 64)
        Me.dgvProfiles.Name = "dgvProfiles"
        Me.dgvProfiles.RowHeadersVisible = False
        Me.dgvProfiles.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProfiles.RowTemplate.Height = 30
        Me.dgvProfiles.Size = New System.Drawing.Size(343, 734)
        Me.dgvProfiles.TabIndex = 2
        '
        'TXTFilter
        '
        Me.TXTFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.TXTFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.TXTFilter.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFilter.Location = New System.Drawing.Point(0, 35)
        Me.TXTFilter.Name = "TXTFilter"
        Me.TXTFilter.Size = New System.Drawing.Size(343, 29)
        Me.TXTFilter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Profiles List"
        '
        'SecondSplit
        '
        Me.SecondSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SecondSplit.Location = New System.Drawing.Point(0, 0)
        Me.SecondSplit.Name = "SecondSplit"
        '
        'SecondSplit.Panel1
        '
        Me.SecondSplit.Panel1.Controls.Add(Me.ChkAllItems)
        Me.SecondSplit.Panel1.Controls.Add(Me.dgvSelectedTest)
        Me.SecondSplit.Panel1.Controls.Add(Me.Label4)
        Me.SecondSplit.Panel1.Controls.Add(Me.TLPConsultant)
        Me.SecondSplit.Panel1.Controls.Add(Me.btnSave)
        Me.SecondSplit.Panel1.Controls.Add(Me.dgvSelectedProfile)
        Me.SecondSplit.Panel1.Controls.Add(Me.Label3)
        Me.SecondSplit.Panel1.Controls.Add(Me.PatientProfilePanel)
        '
        'SecondSplit.Panel2
        '
        Me.SecondSplit.Panel2.Controls.Add(Me.dgvRegisteredRoutine)
        Me.SecondSplit.Panel2.Controls.Add(Me.btRefresh)
        Me.SecondSplit.Panel2.Controls.Add(Me.TXTRoutineFilter)
        Me.SecondSplit.Panel2.Controls.Add(Me.Label5)
        Me.SecondSplit.Panel2.Controls.Add(Me.btHide)
        Me.SecondSplit.Size = New System.Drawing.Size(1007, 798)
        Me.SecondSplit.SplitterDistance = 554
        Me.SecondSplit.TabIndex = 0
        '
        'ChkAllItems
        '
        Me.ChkAllItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAllItems.AutoSize = True
        Me.ChkAllItems.BackColor = System.Drawing.Color.Transparent
        Me.ChkAllItems.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.ChkAllItems.ForeColor = System.Drawing.Color.Red
        Me.ChkAllItems.Location = New System.Drawing.Point(504, 392)
        Me.ChkAllItems.Name = "ChkAllItems"
        Me.ChkAllItems.Size = New System.Drawing.Size(15, 14)
        Me.ChkAllItems.TabIndex = 418
        Me.ChkAllItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkAllItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ChkAllItems.UseVisualStyleBackColor = False
        '
        'dgvSelectedTest
        '
        Me.dgvSelectedTest.AllowUserToAddRows = False
        Me.dgvSelectedTest.AllowUserToDeleteRows = False
        Me.dgvSelectedTest.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelectedTest.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSelectedTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSelectedTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSelectedTest.Location = New System.Drawing.Point(0, 381)
        Me.dgvSelectedTest.Name = "dgvSelectedTest"
        Me.dgvSelectedTest.RowHeadersVisible = False
        Me.dgvSelectedTest.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSelectedTest.RowTemplate.Height = 30
        Me.dgvSelectedTest.Size = New System.Drawing.Size(554, 370)
        Me.dgvSelectedTest.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(0, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 35)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Selected Test:"
        '
        'TLPConsultant
        '
        Me.TLPConsultant.ColumnCount = 2
        Me.TLPConsultant.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TLPConsultant.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPConsultant.Controls.Add(Me.TXTconsultant, 0, 0)
        Me.TLPConsultant.Controls.Add(Me.Label13, 0, 0)
        Me.TLPConsultant.Dock = System.Windows.Forms.DockStyle.Top
        Me.TLPConsultant.Location = New System.Drawing.Point(0, 308)
        Me.TLPConsultant.Name = "TLPConsultant"
        Me.TLPConsultant.RowCount = 1
        Me.TLPConsultant.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPConsultant.Size = New System.Drawing.Size(554, 38)
        Me.TLPConsultant.TabIndex = 16
        '
        'TXTconsultant
        '
        Me.TXTconsultant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTconsultant.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.TXTconsultant.Location = New System.Drawing.Point(139, 3)
        Me.TXTconsultant.Name = "TXTconsultant"
        Me.TXTconsultant.Size = New System.Drawing.Size(412, 35)
        Me.TXTconsultant.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 38)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Consultant:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.LabERP.My.Resources.Resources.front
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(0, 751)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(554, 47)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Register     "
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgvSelectedProfile
        '
        Me.dgvSelectedProfile.AllowUserToAddRows = False
        Me.dgvSelectedProfile.AllowUserToDeleteRows = False
        Me.dgvSelectedProfile.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelectedProfile.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSelectedProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSelectedProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvSelectedProfile.Location = New System.Drawing.Point(0, 73)
        Me.dgvSelectedProfile.Name = "dgvSelectedProfile"
        Me.dgvSelectedProfile.RowHeadersVisible = False
        Me.dgvSelectedProfile.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSelectedProfile.RowTemplate.Height = 30
        Me.dgvSelectedProfile.Size = New System.Drawing.Size(554, 235)
        Me.dgvSelectedProfile.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(0, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 35)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Selected Profiles:"
        '
        'PatientProfilePanel
        '
        Me.PatientProfilePanel.Controls.Add(Me.TXTPatientName)
        Me.PatientProfilePanel.Controls.Add(Me.btPatientUpdate)
        Me.PatientProfilePanel.Controls.Add(Me.Label2)
        Me.PatientProfilePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PatientProfilePanel.Location = New System.Drawing.Point(0, 0)
        Me.PatientProfilePanel.Name = "PatientProfilePanel"
        Me.PatientProfilePanel.Size = New System.Drawing.Size(554, 38)
        Me.PatientProfilePanel.TabIndex = 15
        '
        'TXTPatientName
        '
        Me.TXTPatientName.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.TXTPatientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TXTPatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXTPatientName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTPatientName.Font = New System.Drawing.Font("Times New Roman", 20.0!)
        Me.TXTPatientName.Location = New System.Drawing.Point(95, 0)
        Me.TXTPatientName.Name = "TXTPatientName"
        Me.TXTPatientName.Size = New System.Drawing.Size(415, 38)
        Me.TXTPatientName.TabIndex = 6
        '
        'btPatientUpdate
        '
        Me.btPatientUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btPatientUpdate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btPatientUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btPatientUpdate.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btPatientUpdate.Location = New System.Drawing.Point(510, 0)
        Me.btPatientUpdate.Name = "btPatientUpdate"
        Me.btPatientUpdate.Size = New System.Drawing.Size(44, 38)
        Me.btPatientUpdate.TabIndex = 395
        Me.btPatientUpdate.Text = "Edit"
        Me.btPatientUpdate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 22.0!)
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 38)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvRegisteredRoutine
        '
        Me.dgvRegisteredRoutine.AllowUserToAddRows = False
        Me.dgvRegisteredRoutine.AllowUserToDeleteRows = False
        Me.dgvRegisteredRoutine.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegisteredRoutine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRegisteredRoutine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegisteredRoutine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegisteredRoutine.Location = New System.Drawing.Point(21, 64)
        Me.dgvRegisteredRoutine.Name = "dgvRegisteredRoutine"
        Me.dgvRegisteredRoutine.RowHeadersVisible = False
        Me.dgvRegisteredRoutine.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegisteredRoutine.RowTemplate.Height = 30
        Me.dgvRegisteredRoutine.Size = New System.Drawing.Size(428, 687)
        Me.dgvRegisteredRoutine.TabIndex = 14
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
        Me.btRefresh.Location = New System.Drawing.Point(21, 751)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(428, 47)
        Me.btRefresh.TabIndex = 494
        Me.btRefresh.Text = "Refresh"
        Me.btRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btRefresh.UseVisualStyleBackColor = False
        '
        'TXTRoutineFilter
        '
        Me.TXTRoutineFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.TXTRoutineFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.TXTRoutineFilter.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRoutineFilter.Location = New System.Drawing.Point(21, 35)
        Me.TXTRoutineFilter.Name = "TXTRoutineFilter"
        Me.TXTRoutineFilter.Size = New System.Drawing.Size(428, 29)
        Me.TXTRoutineFilter.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(21, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 35)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Daily Routine"
        '
        'btHide
        '
        Me.btHide.BackColor = System.Drawing.Color.ForestGreen
        Me.btHide.Dock = System.Windows.Forms.DockStyle.Left
        Me.btHide.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.btHide.Location = New System.Drawing.Point(0, 0)
        Me.btHide.Name = "btHide"
        Me.btHide.Size = New System.Drawing.Size(21, 798)
        Me.btHide.TabIndex = 14
        Me.btHide.Text = "<"
        Me.btHide.UseVisualStyleBackColor = False
        '
        'ExpandToolTip
        '
        Me.ExpandToolTip.IsBalloon = True
        Me.ExpandToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ExpandToolTip.ToolTipTitle = "TMLCC"
        '
        'FrmReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1354, 798)
        Me.Controls.Add(Me.MainSplit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainSplit.Panel1.ResumeLayout(False)
        Me.MainSplit.Panel1.PerformLayout()
        Me.MainSplit.Panel2.ResumeLayout(False)
        CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplit.ResumeLayout(False)
        CType(Me.dgvProfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SecondSplit.Panel1.ResumeLayout(False)
        Me.SecondSplit.Panel1.PerformLayout()
        Me.SecondSplit.Panel2.ResumeLayout(False)
        Me.SecondSplit.Panel2.PerformLayout()
        CType(Me.SecondSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SecondSplit.ResumeLayout(False)
        CType(Me.dgvSelectedTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPConsultant.ResumeLayout(False)
        Me.TLPConsultant.PerformLayout()
        CType(Me.dgvSelectedProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientProfilePanel.ResumeLayout(False)
        Me.PatientProfilePanel.PerformLayout()
        CType(Me.dgvRegisteredRoutine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainSplit As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents SecondSplit As SplitContainer
    Friend WithEvents dgvProfiles As DataGridView
    Friend WithEvents TXTFilter As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTPatientName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents TXTRoutineFilter As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvSelectedTest As DataGridView
    Friend WithEvents dgvSelectedProfile As DataGridView
    Friend WithEvents dgvRegisteredRoutine As DataGridView
    Friend WithEvents btHide As Button
    Friend WithEvents PatientProfilePanel As Panel
    Friend WithEvents btPatientUpdate As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LBLPNoR As Label
    Friend WithEvents TLPConsultant As TableLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents TXTconsultant As TextBox
    Friend WithEvents btRefresh As Button
    Friend WithEvents ExpandToolTip As ToolTip
    Friend WithEvents ChkAllItems As CheckBox
End Class
