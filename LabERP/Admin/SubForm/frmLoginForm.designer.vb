<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.TextBoxChangePW = New System.Windows.Forms.TextBox()
        Me.TextBoxPassWord = New System.Windows.Forms.TextBox()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLChangePW = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonMinimize = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ButtonLogin)
        Me.Panel1.Controls.Add(Me.TextBoxChangePW)
        Me.Panel1.Controls.Add(Me.TextBoxPassWord)
        Me.Panel1.Controls.Add(Me.TextBoxUserName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LBLChangePW)
        Me.Panel1.Location = New System.Drawing.Point(43, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(374, 229)
        Me.Panel1.TabIndex = 0
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Font = New System.Drawing.Font("Times New Roman", 26.25!)
        Me.ButtonLogin.Location = New System.Drawing.Point(8, 162)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(358, 56)
        Me.ButtonLogin.TabIndex = 9
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'TextBoxChangePW
        '
        Me.TextBoxChangePW.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TextBoxChangePW.Location = New System.Drawing.Point(99, 92)
        Me.TextBoxChangePW.Name = "TextBoxChangePW"
        Me.TextBoxChangePW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxChangePW.Size = New System.Drawing.Size(263, 35)
        Me.TextBoxChangePW.TabIndex = 7
        '
        'TextBoxPassWord
        '
        Me.TextBoxPassWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TextBoxPassWord.Location = New System.Drawing.Point(99, 50)
        Me.TextBoxPassWord.Name = "TextBoxPassWord"
        Me.TextBoxPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassWord.Size = New System.Drawing.Size(263, 35)
        Me.TextBoxPassWord.TabIndex = 6
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.TextBoxUserName.Location = New System.Drawing.Point(99, 1)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(263, 41)
        Me.TextBoxUserName.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(29, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 40)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "PW:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        '
        'LBLChangePW
        '
        Me.LBLChangePW.AutoSize = True
        Me.LBLChangePW.BackColor = System.Drawing.Color.Transparent
        Me.LBLChangePW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLChangePW.Font = New System.Drawing.Font("Times New Roman", 22.0!)
        Me.LBLChangePW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBLChangePW.LinkColor = System.Drawing.Color.White
        Me.LBLChangePW.Location = New System.Drawing.Point(142, 126)
        Me.LBLChangePW.Name = "LBLChangePW"
        Me.LBLChangePW.Size = New System.Drawing.Size(226, 34)
        Me.LBLChangePW.TabIndex = 8
        Me.LBLChangePW.TabStop = True
        Me.LBLChangePW.Text = "Change Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(60, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ButtonMinimize
        '
        Me.ButtonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMinimize.Image = Global.LabERP.My.Resources.Resources.icons8_minimize_window__1_
        Me.ButtonMinimize.Location = New System.Drawing.Point(370, 7)
        Me.ButtonMinimize.Name = "ButtonMinimize"
        Me.ButtonMinimize.Size = New System.Drawing.Size(34, 29)
        Me.ButtonMinimize.TabIndex = 1
        Me.ButtonMinimize.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonClose.Image = Global.LabERP.My.Resources.Resources.if_Close_1891023
        Me.ButtonClose.Location = New System.Drawing.Point(407, 6)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(31, 29)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'frmLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(445, 404)
        Me.Controls.Add(Me.ButtonMinimize)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Login Screen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxChangePW As TextBox
    Friend WithEvents TextBoxPassWord As TextBox
    Friend WithEvents TextBoxUserName As TextBox
    Friend WithEvents LBLChangePW As LinkLabel
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonMinimize As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
