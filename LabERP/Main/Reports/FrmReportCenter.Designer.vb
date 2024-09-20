<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportCenter
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PBar = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnGenerateReport = New System.Windows.Forms.Button()
        Me.RBtCommon10 = New System.Windows.Forms.RadioButton()
        Me.CmbCanreg = New System.Windows.Forms.ComboBox()
        Me.RBtHaematology = New System.Windows.Forms.RadioButton()
        Me.RBtHisto = New System.Windows.Forms.RadioButton()
        Me.DTPTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBProfiles = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CMBProfiles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PBar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnGenerateReport)
        Me.GroupBox1.Controls.Add(Me.RBtCommon10)
        Me.GroupBox1.Controls.Add(Me.CmbCanreg)
        Me.GroupBox1.Controls.Add(Me.RBtHaematology)
        Me.GroupBox1.Controls.Add(Me.RBtHisto)
        Me.GroupBox1.Controls.Add(Me.DTPTo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DTPFrom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 141)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Criteria"
        '
        'PBar
        '
        Me.PBar.Location = New System.Drawing.Point(80, 228)
        Me.PBar.Name = "PBar"
        Me.PBar.Size = New System.Drawing.Size(220, 22)
        Me.PBar.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-1, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnGenerateReport
        '
        Me.BtnGenerateReport.Location = New System.Drawing.Point(333, 94)
        Me.BtnGenerateReport.Name = "BtnGenerateReport"
        Me.BtnGenerateReport.Size = New System.Drawing.Size(200, 35)
        Me.BtnGenerateReport.TabIndex = 8
        Me.BtnGenerateReport.Text = "Generate report"
        Me.BtnGenerateReport.UseVisualStyleBackColor = True
        '
        'RBtCommon10
        '
        Me.RBtCommon10.AutoSize = True
        Me.RBtCommon10.Location = New System.Drawing.Point(228, 62)
        Me.RBtCommon10.Name = "RBtCommon10"
        Me.RBtCommon10.Size = New System.Drawing.Size(87, 19)
        Me.RBtCommon10.TabIndex = 7
        Me.RBtCommon10.TabStop = True
        Me.RBtCommon10.Text = "Common 10"
        Me.RBtCommon10.UseVisualStyleBackColor = True
        Me.RBtCommon10.Visible = False
        '
        'CmbCanreg
        '
        Me.CmbCanreg.FormattingEnabled = True
        Me.CmbCanreg.Location = New System.Drawing.Point(333, 58)
        Me.CmbCanreg.Name = "CmbCanreg"
        Me.CmbCanreg.Size = New System.Drawing.Size(200, 23)
        Me.CmbCanreg.TabIndex = 6
        '
        'RBtHaematology
        '
        Me.RBtHaematology.AutoSize = True
        Me.RBtHaematology.Location = New System.Drawing.Point(131, 62)
        Me.RBtHaematology.Name = "RBtHaematology"
        Me.RBtHaematology.Size = New System.Drawing.Size(96, 19)
        Me.RBtHaematology.TabIndex = 5
        Me.RBtHaematology.TabStop = True
        Me.RBtHaematology.Text = "Haematology"
        Me.RBtHaematology.UseVisualStyleBackColor = True
        '
        'RBtHisto
        '
        Me.RBtHisto.AutoSize = True
        Me.RBtHisto.Location = New System.Drawing.Point(14, 62)
        Me.RBtHisto.Name = "RBtHisto"
        Me.RBtHisto.Size = New System.Drawing.Size(109, 19)
        Me.RBtHisto.TabIndex = 4
        Me.RBtHisto.TabStop = True
        Me.RBtHisto.Text = "Histopathology"
        Me.RBtHisto.UseVisualStyleBackColor = True
        '
        'DTPTo
        '
        Me.DTPTo.CustomFormat = ""
        Me.DTPTo.Location = New System.Drawing.Point(333, 23)
        Me.DTPTo.Name = "DTPTo"
        Me.DTPTo.Size = New System.Drawing.Size(200, 22)
        Me.DTPTo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(303, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To:"
        '
        'DTPFrom
        '
        Me.DTPFrom.CustomFormat = ""
        Me.DTPFrom.Location = New System.Drawing.Point(80, 23)
        Me.DTPFrom.Name = "DTPFrom"
        Me.DTPFrom.Size = New System.Drawing.Size(200, 22)
        Me.DTPFrom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date from:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Report by Profile:"
        '
        'CMBProfiles
        '
        Me.CMBProfiles.FormattingEnabled = True
        Me.CMBProfiles.Location = New System.Drawing.Point(114, 101)
        Me.CMBProfiles.Name = "CMBProfiles"
        Me.CMBProfiles.Size = New System.Drawing.Size(166, 23)
        Me.CMBProfiles.TabIndex = 19
        '
        'FrmReportCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 144)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportCenter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Center"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBtHaematology As RadioButton
    Friend WithEvents RBtHisto As RadioButton
    Friend WithEvents DTPTo As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DTPFrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnGenerateReport As Button
    Friend WithEvents CmbCanreg As ComboBox
    Friend WithEvents RBtCommon10 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents PBar As ProgressBar
    Friend WithEvents CMBProfiles As ComboBox
    Friend WithEvents Label3 As Label
End Class
