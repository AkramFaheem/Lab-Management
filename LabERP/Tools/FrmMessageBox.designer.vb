<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMessageBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMessageBox))
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.ImgType = New System.Windows.Forms.PictureBox()
        Me.MIMgList = New System.Windows.Forms.ImageList(Me.components)
        Me.LblMessage = New System.Windows.Forms.Label()
        CType(Me.ImgType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblHeader
        '
        Me.LblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblHeader.Font = New System.Drawing.Font("Calibri", 12.25!, System.Drawing.FontStyle.Bold)
        Me.LblHeader.Location = New System.Drawing.Point(0, 0)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblHeader.Size = New System.Drawing.Size(429, 25)
        Me.LblHeader.TabIndex = 1
        Me.LblHeader.Text = "For Test"
        Me.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblHeader.UseCompatibleTextRendering = True
        '
        'ImgType
        '
        Me.ImgType.BackColor = System.Drawing.Color.Transparent
        Me.ImgType.Location = New System.Drawing.Point(380, 34)
        Me.ImgType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ImgType.Name = "ImgType"
        Me.ImgType.Size = New System.Drawing.Size(40, 47)
        Me.ImgType.TabIndex = 3
        Me.ImgType.TabStop = False
        '
        'MIMgList
        '
        Me.MIMgList.ImageStream = CType(resources.GetObject("MIMgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.MIMgList.TransparentColor = System.Drawing.Color.Transparent
        Me.MIMgList.Images.SetKeyName(0, "M_Error")
        Me.MIMgList.Images.SetKeyName(1, "M_Infomations")
        Me.MIMgList.Images.SetKeyName(2, "M_Exlamation")
        Me.MIMgList.Images.SetKeyName(3, "M_Stop")
        Me.MIMgList.Images.SetKeyName(4, "M_Question")
        '
        'LblMessage
        '
        Me.LblMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblMessage.BackColor = System.Drawing.Color.Transparent
        Me.LblMessage.ForeColor = System.Drawing.Color.Black
        Me.LblMessage.Location = New System.Drawing.Point(8, 38)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(366, 49)
        Me.LblMessage.TabIndex = 2
        Me.LblMessage.Text = "LblMessage"
        '
        'FrmMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 133)
        Me.Controls.Add(Me.ImgType)
        Me.Controls.Add(Me.LblMessage)
        Me.Controls.Add(Me.LblHeader)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMessageBox"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ImgType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblHeader As System.Windows.Forms.Label
    Friend WithEvents ImgType As System.Windows.Forms.PictureBox
    Friend WithEvents MIMgList As System.Windows.Forms.ImageList
    Friend WithEvents LblMessage As System.Windows.Forms.Label
End Class
