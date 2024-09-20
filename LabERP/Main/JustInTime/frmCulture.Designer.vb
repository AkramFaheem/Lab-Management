<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCulture
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
        Me.SplitMain = New System.Windows.Forms.SplitContainer()
        Me.txtCulture = New System.Windows.Forms.RichTextBox()
        Me.TLPDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitSensitive = New System.Windows.Forms.SplitContainer()
        Me.chksensitive = New System.Windows.Forms.CheckedListBox()
        Me.txtsensitive = New System.Windows.Forms.TextBox()
        Me.SplitResistant = New System.Windows.Forms.SplitContainer()
        Me.chkresistant = New System.Windows.Forms.CheckedListBox()
        Me.txtresistant = New System.Windows.Forms.TextBox()
        CType(Me.SplitMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitMain.Panel1.SuspendLayout()
        Me.SplitMain.Panel2.SuspendLayout()
        Me.SplitMain.SuspendLayout()
        Me.TLPDetails.SuspendLayout()
        CType(Me.SplitSensitive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitSensitive.Panel1.SuspendLayout()
        Me.SplitSensitive.Panel2.SuspendLayout()
        Me.SplitSensitive.SuspendLayout()
        CType(Me.SplitResistant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitResistant.Panel1.SuspendLayout()
        Me.SplitResistant.Panel2.SuspendLayout()
        Me.SplitResistant.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitMain
        '
        Me.SplitMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitMain.Location = New System.Drawing.Point(0, 0)
        Me.SplitMain.Name = "SplitMain"
        Me.SplitMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitMain.Panel1
        '
        Me.SplitMain.Panel1.Controls.Add(Me.txtCulture)
        '
        'SplitMain.Panel2
        '
        Me.SplitMain.Panel2.Controls.Add(Me.TLPDetails)
        Me.SplitMain.Size = New System.Drawing.Size(507, 561)
        Me.SplitMain.SplitterDistance = 109
        Me.SplitMain.TabIndex = 0
        '
        'txtCulture
        '
        Me.txtCulture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCulture.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.txtCulture.Location = New System.Drawing.Point(0, 0)
        Me.txtCulture.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCulture.Name = "txtCulture"
        Me.txtCulture.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtCulture.Size = New System.Drawing.Size(507, 109)
        Me.txtCulture.TabIndex = 11
        Me.txtCulture.Text = ""
        '
        'TLPDetails
        '
        Me.TLPDetails.ColumnCount = 2
        Me.TLPDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPDetails.Controls.Add(Me.Label3, 1, 0)
        Me.TLPDetails.Controls.Add(Me.Label1, 0, 0)
        Me.TLPDetails.Controls.Add(Me.SplitSensitive, 0, 1)
        Me.TLPDetails.Controls.Add(Me.SplitResistant, 1, 1)
        Me.TLPDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPDetails.Location = New System.Drawing.Point(0, 0)
        Me.TLPDetails.Name = "TLPDetails"
        Me.TLPDetails.RowCount = 2
        Me.TLPDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TLPDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPDetails.Size = New System.Drawing.Size(507, 448)
        Me.TLPDetails.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(256, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(248, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Resistant To:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(247, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Sensitive To:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitSensitive
        '
        Me.SplitSensitive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitSensitive.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitSensitive.Location = New System.Drawing.Point(3, 28)
        Me.SplitSensitive.Name = "SplitSensitive"
        '
        'SplitSensitive.Panel1
        '
        Me.SplitSensitive.Panel1.Controls.Add(Me.chksensitive)
        '
        'SplitSensitive.Panel2
        '
        Me.SplitSensitive.Panel2.Controls.Add(Me.txtsensitive)
        Me.SplitSensitive.Size = New System.Drawing.Size(247, 417)
        Me.SplitSensitive.SplitterDistance = 82
        Me.SplitSensitive.TabIndex = 13
        '
        'chksensitive
        '
        Me.chksensitive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chksensitive.FormattingEnabled = True
        Me.chksensitive.Location = New System.Drawing.Point(0, 0)
        Me.chksensitive.Name = "chksensitive"
        Me.chksensitive.Size = New System.Drawing.Size(82, 417)
        Me.chksensitive.TabIndex = 23
        '
        'txtsensitive
        '
        Me.txtsensitive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtsensitive.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.txtsensitive.Location = New System.Drawing.Point(0, 0)
        Me.txtsensitive.Multiline = True
        Me.txtsensitive.Name = "txtsensitive"
        Me.txtsensitive.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsensitive.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtsensitive.Size = New System.Drawing.Size(161, 417)
        Me.txtsensitive.TabIndex = 20
        '
        'SplitResistant
        '
        Me.SplitResistant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitResistant.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitResistant.Location = New System.Drawing.Point(256, 28)
        Me.SplitResistant.Name = "SplitResistant"
        '
        'SplitResistant.Panel1
        '
        Me.SplitResistant.Panel1.Controls.Add(Me.chkresistant)
        '
        'SplitResistant.Panel2
        '
        Me.SplitResistant.Panel2.Controls.Add(Me.txtresistant)
        Me.SplitResistant.Size = New System.Drawing.Size(248, 417)
        Me.SplitResistant.SplitterDistance = 82
        Me.SplitResistant.TabIndex = 14
        '
        'chkresistant
        '
        Me.chkresistant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkresistant.FormattingEnabled = True
        Me.chkresistant.Location = New System.Drawing.Point(0, 0)
        Me.chkresistant.Name = "chkresistant"
        Me.chkresistant.Size = New System.Drawing.Size(82, 417)
        Me.chkresistant.TabIndex = 24
        '
        'txtresistant
        '
        Me.txtresistant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtresistant.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.txtresistant.Location = New System.Drawing.Point(0, 0)
        Me.txtresistant.Multiline = True
        Me.txtresistant.Name = "txtresistant"
        Me.txtresistant.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtresistant.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtresistant.Size = New System.Drawing.Size(162, 417)
        Me.txtresistant.TabIndex = 25
        '
        'frmCulture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(507, 561)
        Me.Controls.Add(Me.SplitMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCulture"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Culture Results Enrty"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitMain.Panel1.ResumeLayout(False)
        Me.SplitMain.Panel2.ResumeLayout(False)
        CType(Me.SplitMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitMain.ResumeLayout(False)
        Me.TLPDetails.ResumeLayout(False)
        Me.SplitSensitive.Panel1.ResumeLayout(False)
        Me.SplitSensitive.Panel2.ResumeLayout(False)
        Me.SplitSensitive.Panel2.PerformLayout()
        CType(Me.SplitSensitive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitSensitive.ResumeLayout(False)
        Me.SplitResistant.Panel1.ResumeLayout(False)
        Me.SplitResistant.Panel2.ResumeLayout(False)
        Me.SplitResistant.Panel2.PerformLayout()
        CType(Me.SplitResistant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitResistant.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitMain As SplitContainer
    Friend WithEvents TLPDetails As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCulture As RichTextBox
    Friend WithEvents SplitSensitive As SplitContainer
    Friend WithEvents chksensitive As CheckedListBox
    Friend WithEvents txtsensitive As TextBox
    Friend WithEvents SplitResistant As SplitContainer
    Friend WithEvents chkresistant As CheckedListBox
    Friend WithEvents txtresistant As TextBox
End Class
