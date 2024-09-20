<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultes
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTPatientName = New System.Windows.Forms.TextBox()
        Me.btPatientUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvRequestedTests = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btHide = New System.Windows.Forms.Button()
        Me.PatientProfilePanel = New System.Windows.Forms.Panel()
        Me.SecondSplit = New System.Windows.Forms.SplitContainer()
        Me.RequestPanel = New System.Windows.Forms.Panel()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.DetailsPanel = New System.Windows.Forms.Panel()
        Me.TLDetailsPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.txtLabNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTconsultant = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTclinicalinfo = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbCancer = New System.Windows.Forms.ComboBox()
        Me.DTPReportDate = New System.Windows.Forms.DateTimePicker()
        Me.lblcanreg = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBLPRNo = New System.Windows.Forms.Label()
        Me.LBLHRNo = New System.Windows.Forms.Label()
        Me.dgvPrintRoutine = New System.Windows.Forms.DataGridView()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.TXTRoutineFilter = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvWaitting = New System.Windows.Forms.DataGridView()
        Me.TXTFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainSplit = New System.Windows.Forms.SplitContainer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBLWNoR = New System.Windows.Forms.Label()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRequestedTests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientProfilePanel.SuspendLayout()
        CType(Me.SecondSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SecondSplit.Panel1.SuspendLayout()
        Me.SecondSplit.Panel2.SuspendLayout()
        Me.SecondSplit.SuspendLayout()
        Me.RequestPanel.SuspendLayout()
        Me.DetailsPanel.SuspendLayout()
        Me.TLDetailsPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvPrintRoutine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvWaitting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplit.Panel1.SuspendLayout()
        Me.MainSplit.Panel2.SuspendLayout()
        Me.MainSplit.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvHistory
        '
        Me.dgvHistory.AllowUserToAddRows = False
        Me.dgvHistory.AllowUserToDeleteRows = False
        Me.dgvHistory.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvHistory.Location = New System.Drawing.Point(21, 26)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.RowHeadersVisible = False
        Me.dgvHistory.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvHistory.RowTemplate.Height = 30
        Me.dgvHistory.Size = New System.Drawing.Size(412, 296)
        Me.dgvHistory.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(21, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Patient History:"
        '
        'TXTPatientName
        '
        Me.TXTPatientName.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.TXTPatientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TXTPatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TXTPatientName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTPatientName.Font = New System.Drawing.Font("Times New Roman", 22.0!)
        Me.TXTPatientName.Location = New System.Drawing.Point(94, 0)
        Me.TXTPatientName.Name = "TXTPatientName"
        Me.TXTPatientName.Size = New System.Drawing.Size(393, 41)
        Me.TXTPatientName.TabIndex = 6
        '
        'btPatientUpdate
        '
        Me.btPatientUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btPatientUpdate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btPatientUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btPatientUpdate.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btPatientUpdate.Location = New System.Drawing.Point(487, 0)
        Me.btPatientUpdate.Name = "btPatientUpdate"
        Me.btPatientUpdate.Size = New System.Drawing.Size(44, 41)
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
        Me.Label2.Size = New System.Drawing.Size(94, 41)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvRequestedTests
        '
        Me.dgvRequestedTests.AllowUserToAddRows = False
        Me.dgvRequestedTests.AllowUserToDeleteRows = False
        Me.dgvRequestedTests.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequestedTests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRequestedTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequestedTests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRequestedTests.Location = New System.Drawing.Point(0, 0)
        Me.dgvRequestedTests.Name = "dgvRequestedTests"
        Me.dgvRequestedTests.RowHeadersVisible = False
        Me.dgvRequestedTests.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRequestedTests.RowTemplate.Height = 30
        Me.dgvRequestedTests.Size = New System.Drawing.Size(531, 288)
        Me.dgvRequestedTests.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(0, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 35)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Requested Tests:"
        '
        'btHide
        '
        Me.btHide.BackColor = System.Drawing.Color.ForestGreen
        Me.btHide.Dock = System.Windows.Forms.DockStyle.Left
        Me.btHide.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.btHide.Location = New System.Drawing.Point(0, 0)
        Me.btHide.Name = "btHide"
        Me.btHide.Size = New System.Drawing.Size(21, 700)
        Me.btHide.TabIndex = 14
        Me.btHide.Text = "<"
        Me.btHide.UseVisualStyleBackColor = False
        '
        'PatientProfilePanel
        '
        Me.PatientProfilePanel.Controls.Add(Me.TXTPatientName)
        Me.PatientProfilePanel.Controls.Add(Me.btPatientUpdate)
        Me.PatientProfilePanel.Controls.Add(Me.Label2)
        Me.PatientProfilePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.PatientProfilePanel.Location = New System.Drawing.Point(0, 0)
        Me.PatientProfilePanel.Name = "PatientProfilePanel"
        Me.PatientProfilePanel.Size = New System.Drawing.Size(531, 41)
        Me.PatientProfilePanel.TabIndex = 15
        '
        'SecondSplit
        '
        Me.SecondSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SecondSplit.Location = New System.Drawing.Point(0, 0)
        Me.SecondSplit.Name = "SecondSplit"
        '
        'SecondSplit.Panel1
        '
        Me.SecondSplit.Panel1.Controls.Add(Me.RequestPanel)
        Me.SecondSplit.Panel1.Controls.Add(Me.Label3)
        Me.SecondSplit.Panel1.Controls.Add(Me.DetailsPanel)
        Me.SecondSplit.Panel1.Controls.Add(Me.btnSave)
        Me.SecondSplit.Panel1.Controls.Add(Me.PatientProfilePanel)
        '
        'SecondSplit.Panel2
        '
        Me.SecondSplit.Panel2.Controls.Add(Me.Label8)
        Me.SecondSplit.Panel2.Controls.Add(Me.LBLPRNo)
        Me.SecondSplit.Panel2.Controls.Add(Me.LBLHRNo)
        Me.SecondSplit.Panel2.Controls.Add(Me.dgvPrintRoutine)
        Me.SecondSplit.Panel2.Controls.Add(Me.btRefresh)
        Me.SecondSplit.Panel2.Controls.Add(Me.TXTRoutineFilter)
        Me.SecondSplit.Panel2.Controls.Add(Me.Label4)
        Me.SecondSplit.Panel2.Controls.Add(Me.dgvHistory)
        Me.SecondSplit.Panel2.Controls.Add(Me.Label5)
        Me.SecondSplit.Panel2.Controls.Add(Me.btHide)
        Me.SecondSplit.Panel2.Controls.Add(Me.Label7)
        Me.SecondSplit.Size = New System.Drawing.Size(968, 700)
        Me.SecondSplit.SplitterDistance = 531
        Me.SecondSplit.TabIndex = 0
        '
        'RequestPanel
        '
        Me.RequestPanel.Controls.Add(Me.dgvRequestedTests)
        Me.RequestPanel.Controls.Add(Me.txtNote)
        Me.RequestPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RequestPanel.Location = New System.Drawing.Point(0, 270)
        Me.RequestPanel.Name = "RequestPanel"
        Me.RequestPanel.Size = New System.Drawing.Size(531, 386)
        Me.RequestPanel.TabIndex = 17
        '
        'txtNote
        '
        Me.txtNote.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtNote.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.txtNote.Location = New System.Drawing.Point(0, 288)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNote.Size = New System.Drawing.Size(531, 98)
        Me.txtNote.TabIndex = 18
        '
        'DetailsPanel
        '
        Me.DetailsPanel.Controls.Add(Me.TLDetailsPanel)
        Me.DetailsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DetailsPanel.Location = New System.Drawing.Point(0, 41)
        Me.DetailsPanel.Name = "DetailsPanel"
        Me.DetailsPanel.Size = New System.Drawing.Size(531, 194)
        Me.DetailsPanel.TabIndex = 16
        '
        'TLDetailsPanel
        '
        Me.TLDetailsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TLDetailsPanel.ColumnCount = 2
        Me.TLDetailsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.TLDetailsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLDetailsPanel.Controls.Add(Me.txtLabNo, 1, 3)
        Me.TLDetailsPanel.Controls.Add(Me.Label10, 0, 3)
        Me.TLDetailsPanel.Controls.Add(Me.Label9, 0, 2)
        Me.TLDetailsPanel.Controls.Add(Me.TXTconsultant, 1, 1)
        Me.TLDetailsPanel.Controls.Add(Me.Label11, 0, 0)
        Me.TLDetailsPanel.Controls.Add(Me.Label13, 0, 1)
        Me.TLDetailsPanel.Controls.Add(Me.TXTclinicalinfo, 1, 0)
        Me.TLDetailsPanel.Controls.Add(Me.TableLayoutPanel1, 1, 2)
        Me.TLDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLDetailsPanel.Location = New System.Drawing.Point(0, 0)
        Me.TLDetailsPanel.Name = "TLDetailsPanel"
        Me.TLDetailsPanel.RowCount = 4
        Me.TLDetailsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLDetailsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TLDetailsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TLDetailsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TLDetailsPanel.Size = New System.Drawing.Size(531, 194)
        Me.TLDetailsPanel.TabIndex = 2
        '
        'txtLabNo
        '
        Me.txtLabNo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLabNo.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.txtLabNo.Location = New System.Drawing.Point(113, 154)
        Me.txtLabNo.Name = "txtLabNo"
        Me.txtLabNo.Size = New System.Drawing.Size(412, 35)
        Me.txtLabNo.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.Label10.Location = New System.Drawing.Point(6, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 40)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Lab No:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.Label9.Location = New System.Drawing.Point(6, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 40)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Rep Date:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTconsultant
        '
        Me.TXTconsultant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTconsultant.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.TXTconsultant.Location = New System.Drawing.Point(113, 68)
        Me.TXTconsultant.Name = "TXTconsultant"
        Me.TXTconsultant.Size = New System.Drawing.Size(412, 35)
        Me.TXTconsultant.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.Label11.Location = New System.Drawing.Point(6, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 59)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Clinical:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.Label13.Location = New System.Drawing.Point(6, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 40)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Consultant:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTclinicalinfo
        '
        Me.TXTclinicalinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTclinicalinfo.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.TXTclinicalinfo.Location = New System.Drawing.Point(113, 6)
        Me.TXTclinicalinfo.Multiline = True
        Me.TXTclinicalinfo.Name = "TXTclinicalinfo"
        Me.TXTclinicalinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTclinicalinfo.Size = New System.Drawing.Size(412, 53)
        Me.TXTclinicalinfo.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.36077!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbCancer, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DTPReportDate, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblcanreg, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(113, 111)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(412, 34)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'cbCancer
        '
        Me.cbCancer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbCancer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbCancer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCancer.FormattingEnabled = True
        Me.cbCancer.IntegralHeight = False
        Me.cbCancer.Location = New System.Drawing.Point(238, 3)
        Me.cbCancer.Name = "cbCancer"
        Me.cbCancer.Size = New System.Drawing.Size(171, 29)
        Me.cbCancer.TabIndex = 16
        Me.cbCancer.Visible = False
        '
        'DTPReportDate
        '
        Me.DTPReportDate.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPReportDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DTPReportDate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPReportDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPReportDate.Location = New System.Drawing.Point(3, 3)
        Me.DTPReportDate.Name = "DTPReportDate"
        Me.DTPReportDate.Size = New System.Drawing.Size(117, 29)
        Me.DTPReportDate.TabIndex = 14
        '
        'lblcanreg
        '
        Me.lblcanreg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblcanreg.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.lblcanreg.Location = New System.Drawing.Point(126, 0)
        Me.lblcanreg.Name = "lblcanreg"
        Me.lblcanreg.Size = New System.Drawing.Size(106, 42)
        Me.lblcanreg.TabIndex = 15
        Me.lblcanreg.Text = "CanReg:"
        Me.lblcanreg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblcanreg.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.LabERP.My.Resources.Resources.icons8_update_32
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(0, 656)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(531, 44)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save Result    "
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(230, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 22)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Total:"
        '
        'LBLPRNo
        '
        Me.LBLPRNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPRNo.Location = New System.Drawing.Point(290, 325)
        Me.LBLPRNo.Name = "LBLPRNo"
        Me.LBLPRNo.Size = New System.Drawing.Size(74, 23)
        Me.LBLPRNo.TabIndex = 19
        '
        'LBLHRNo
        '
        Me.LBLHRNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLHRNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLHRNo.Location = New System.Drawing.Point(259, 0)
        Me.LBLHRNo.Name = "LBLHRNo"
        Me.LBLHRNo.Size = New System.Drawing.Size(68, 26)
        Me.LBLHRNo.TabIndex = 17
        '
        'dgvPrintRoutine
        '
        Me.dgvPrintRoutine.AllowUserToAddRows = False
        Me.dgvPrintRoutine.AllowUserToDeleteRows = False
        Me.dgvPrintRoutine.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrintRoutine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPrintRoutine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrintRoutine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPrintRoutine.Location = New System.Drawing.Point(21, 377)
        Me.dgvPrintRoutine.Name = "dgvPrintRoutine"
        Me.dgvPrintRoutine.RowHeadersVisible = False
        Me.dgvPrintRoutine.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPrintRoutine.RowTemplate.Height = 30
        Me.dgvPrintRoutine.Size = New System.Drawing.Size(412, 279)
        Me.dgvPrintRoutine.TabIndex = 16
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
        Me.btRefresh.Location = New System.Drawing.Point(21, 656)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(412, 44)
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
        Me.TXTRoutineFilter.Location = New System.Drawing.Point(21, 348)
        Me.TXTRoutineFilter.Name = "TXTRoutineFilter"
        Me.TXTRoutineFilter.Size = New System.Drawing.Size(412, 29)
        Me.TXTRoutineFilter.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(21, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 26)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Ready To Print List:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(205, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 22)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Total:"
        '
        'dgvWaitting
        '
        Me.dgvWaitting.AllowUserToAddRows = False
        Me.dgvWaitting.AllowUserToDeleteRows = False
        Me.dgvWaitting.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvWaitting.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvWaitting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWaitting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWaitting.Location = New System.Drawing.Point(0, 64)
        Me.dgvWaitting.Name = "dgvWaitting"
        Me.dgvWaitting.RowHeadersVisible = False
        Me.dgvWaitting.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvWaitting.RowTemplate.Height = 30
        Me.dgvWaitting.Size = New System.Drawing.Size(394, 636)
        Me.dgvWaitting.TabIndex = 2
        '
        'TXTFilter
        '
        Me.TXTFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.TXTFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.TXTFilter.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFilter.Location = New System.Drawing.Point(0, 35)
        Me.TXTFilter.Name = "TXTFilter"
        Me.TXTFilter.Size = New System.Drawing.Size(394, 29)
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
        Me.Label1.Size = New System.Drawing.Size(207, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registered List"
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
        Me.MainSplit.Panel1.Controls.Add(Me.Label6)
        Me.MainSplit.Panel1.Controls.Add(Me.LBLWNoR)
        Me.MainSplit.Panel1.Controls.Add(Me.dgvWaitting)
        Me.MainSplit.Panel1.Controls.Add(Me.TXTFilter)
        Me.MainSplit.Panel1.Controls.Add(Me.Label1)
        '
        'MainSplit.Panel2
        '
        Me.MainSplit.Panel2.Controls.Add(Me.SecondSplit)
        Me.MainSplit.Size = New System.Drawing.Size(1366, 700)
        Me.MainSplit.SplitterDistance = 394
        Me.MainSplit.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(213, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total:"
        '
        'LBLWNoR
        '
        Me.LBLWNoR.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LBLWNoR.Location = New System.Drawing.Point(275, 10)
        Me.LBLWNoR.Name = "LBLWNoR"
        Me.LBLWNoR.Size = New System.Drawing.Size(69, 25)
        Me.LBLWNoR.TabIndex = 3
        '
        'frmResultes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 700)
        Me.Controls.Add(Me.MainSplit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmResultes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Entry Resultes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRequestedTests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientProfilePanel.ResumeLayout(False)
        Me.PatientProfilePanel.PerformLayout()
        Me.SecondSplit.Panel1.ResumeLayout(False)
        Me.SecondSplit.Panel1.PerformLayout()
        Me.SecondSplit.Panel2.ResumeLayout(False)
        Me.SecondSplit.Panel2.PerformLayout()
        CType(Me.SecondSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SecondSplit.ResumeLayout(False)
        Me.RequestPanel.ResumeLayout(False)
        Me.RequestPanel.PerformLayout()
        Me.DetailsPanel.ResumeLayout(False)
        Me.TLDetailsPanel.ResumeLayout(False)
        Me.TLDetailsPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvPrintRoutine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvWaitting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplit.Panel1.ResumeLayout(False)
        Me.MainSplit.Panel1.PerformLayout()
        Me.MainSplit.Panel2.ResumeLayout(False)
        CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplit.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTPatientName As TextBox
    Friend WithEvents btPatientUpdate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvRequestedTests As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btHide As Button
    Friend WithEvents PatientProfilePanel As Panel
    Friend WithEvents SecondSplit As SplitContainer
    Friend WithEvents TXTRoutineFilter As TextBox
    Friend WithEvents dgvWaitting As DataGridView
    Friend WithEvents TXTFilter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MainSplit As SplitContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvPrintRoutine As DataGridView
    Friend WithEvents DetailsPanel As Panel
    Friend WithEvents TLDetailsPanel As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTconsultant As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TXTclinicalinfo As TextBox
    Friend WithEvents LBLWNoR As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LBLPRNo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBLHRNo As Label
    Friend WithEvents RequestPanel As Panel
    Friend WithEvents btRefresh As Button
    Friend WithEvents txtNote As TextBox
    Friend WithEvents txtLabNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DTPReportDate As DateTimePicker
    Friend WithEvents lblcanreg As Label
    Friend WithEvents cbCancer As ComboBox
End Class
