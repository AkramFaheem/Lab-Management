<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoComplate
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
        Me.HistoSplit = New System.Windows.Forms.SplitContainer()
        Me.TLPHistoHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCancer = New System.Windows.Forms.ComboBox()
        Me.txtReport = New System.Windows.Forms.RichTextBox()
        Me.TLPHistoRegDate = New System.Windows.Forms.TableLayoutPanel()
        Me.txtRequest = New System.Windows.Forms.TextBox()
        Me.DTPRegistrationDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSetup = New System.Windows.Forms.Button()
        CType(Me.HistoSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HistoSplit.Panel1.SuspendLayout()
        Me.HistoSplit.Panel2.SuspendLayout()
        Me.HistoSplit.SuspendLayout()
        Me.TLPHistoHeader.SuspendLayout()
        Me.TLPHistoRegDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'HistoSplit
        '
        Me.HistoSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.HistoSplit.Location = New System.Drawing.Point(0, 0)
        Me.HistoSplit.Name = "HistoSplit"
        Me.HistoSplit.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'HistoSplit.Panel1
        '
        Me.HistoSplit.Panel1.Controls.Add(Me.TLPHistoHeader)
        Me.HistoSplit.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'HistoSplit.Panel2
        '
        Me.HistoSplit.Panel2.Controls.Add(Me.txtReport)
        Me.HistoSplit.Panel2.Controls.Add(Me.TLPHistoRegDate)
        Me.HistoSplit.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HistoSplit.Size = New System.Drawing.Size(507, 561)
        Me.HistoSplit.SplitterDistance = 40
        Me.HistoSplit.SplitterWidth = 1
        Me.HistoSplit.TabIndex = 0
        '
        'TLPHistoHeader
        '
        Me.TLPHistoHeader.ColumnCount = 3
        Me.TLPHistoHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TLPHistoHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPHistoHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLPHistoHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPHistoHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPHistoHeader.Controls.Add(Me.btnSetup, 2, 0)
        Me.TLPHistoHeader.Controls.Add(Me.Label1, 0, 0)
        Me.TLPHistoHeader.Controls.Add(Me.cbCancer, 1, 0)
        Me.TLPHistoHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPHistoHeader.Location = New System.Drawing.Point(0, 0)
        Me.TLPHistoHeader.Name = "TLPHistoHeader"
        Me.TLPHistoHeader.RowCount = 1
        Me.TLPHistoHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPHistoHeader.Size = New System.Drawing.Size(507, 40)
        Me.TLPHistoHeader.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(57, 40)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Reg:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbCancer
        '
        Me.cbCancer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbCancer.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCancer.FormattingEnabled = True
        Me.cbCancer.Location = New System.Drawing.Point(66, 3)
        Me.cbCancer.Name = "cbCancer"
        Me.cbCancer.Size = New System.Drawing.Size(388, 31)
        Me.cbCancer.TabIndex = 13
        '
        'txtReport
        '
        Me.txtReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtReport.Location = New System.Drawing.Point(0, 40)
        Me.txtReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtReport.Name = "txtReport"
        Me.txtReport.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtReport.Size = New System.Drawing.Size(507, 480)
        Me.txtReport.TabIndex = 10
        Me.txtReport.Text = ""
        '
        'TLPHistoRegDate
        '
        Me.TLPHistoRegDate.ColumnCount = 3
        Me.TLPHistoRegDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.TLPHistoRegDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159.0!))
        Me.TLPHistoRegDate.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPHistoRegDate.Controls.Add(Me.txtRequest, 0, 0)
        Me.TLPHistoRegDate.Controls.Add(Me.DTPRegistrationDate, 0, 0)
        Me.TLPHistoRegDate.Controls.Add(Me.Label2, 0, 0)
        Me.TLPHistoRegDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.TLPHistoRegDate.Location = New System.Drawing.Point(0, 0)
        Me.TLPHistoRegDate.Name = "TLPHistoRegDate"
        Me.TLPHistoRegDate.RowCount = 1
        Me.TLPHistoRegDate.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPHistoRegDate.Size = New System.Drawing.Size(507, 40)
        Me.TLPHistoRegDate.TabIndex = 11
        '
        'txtRequest
        '
        Me.txtRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRequest.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.txtRequest.Location = New System.Drawing.Point(308, 3)
        Me.txtRequest.Name = "txtRequest"
        Me.txtRequest.Size = New System.Drawing.Size(196, 35)
        Me.txtRequest.TabIndex = 15
        '
        'DTPRegistrationDate
        '
        Me.DTPRegistrationDate.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPRegistrationDate.Dock = System.Windows.Forms.DockStyle.Left
        Me.DTPRegistrationDate.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.DTPRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPRegistrationDate.Location = New System.Drawing.Point(149, 3)
        Me.DTPRegistrationDate.Name = "DTPRegistrationDate"
        Me.DTPRegistrationDate.Size = New System.Drawing.Size(153, 35)
        Me.DTPRegistrationDate.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(140, 40)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sample Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSetup
        '
        Me.btnSetup.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSetup.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetup.Image = Global.LabERP.My.Resources.Resources.icons8_test_32
        Me.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSetup.Location = New System.Drawing.Point(460, 3)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(44, 34)
        Me.btnSetup.TabIndex = 14
        Me.btnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'frmHistoComplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(507, 561)
        Me.Controls.Add(Me.HistoSplit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHistoComplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.HistoSplit.Panel1.ResumeLayout(False)
        Me.HistoSplit.Panel2.ResumeLayout(False)
        CType(Me.HistoSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HistoSplit.ResumeLayout(False)
        Me.TLPHistoHeader.ResumeLayout(False)
        Me.TLPHistoRegDate.ResumeLayout(False)
        Me.TLPHistoRegDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HistoSplit As SplitContainer
    Friend WithEvents TLPHistoHeader As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCancer As ComboBox
    Friend WithEvents txtReport As RichTextBox
    Friend WithEvents btnSetup As Button
    Friend WithEvents TLPHistoRegDate As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents DTPRegistrationDate As DateTimePicker
    Friend WithEvents txtRequest As TextBox
End Class
