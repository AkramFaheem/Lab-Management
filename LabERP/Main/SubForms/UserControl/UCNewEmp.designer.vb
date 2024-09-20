<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCNewEmp
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.LinkTransaction = New System.Windows.Forms.LinkLabel()
        Me.PBEmp = New System.Windows.Forms.PictureBox()
        CType(Me.PBEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkTransaction
        '
        Me.LinkTransaction.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LinkTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkTransaction.LinkColor = System.Drawing.Color.Black
        Me.LinkTransaction.Location = New System.Drawing.Point(0, 74)
        Me.LinkTransaction.Name = "LinkTransaction"
        Me.LinkTransaction.Size = New System.Drawing.Size(125, 36)
        Me.LinkTransaction.TabIndex = 11
        Me.LinkTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBEmp
        '
        Me.PBEmp.BackColor = System.Drawing.Color.White
        Me.PBEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBEmp.Location = New System.Drawing.Point(0, 0)
        Me.PBEmp.Name = "PBEmp"
        Me.PBEmp.Size = New System.Drawing.Size(125, 74)
        Me.PBEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBEmp.TabIndex = 8
        Me.PBEmp.TabStop = False
        '
        'UCNewEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.PBEmp)
        Me.Controls.Add(Me.LinkTransaction)
        Me.Name = "UCNewEmp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(125, 110)
        CType(Me.PBEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PBEmp As PictureBox
    Friend WithEvents LinkTransaction As LinkLabel
End Class
