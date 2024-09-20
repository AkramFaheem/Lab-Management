<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPateintProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPateintProfile))
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtPayeeName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCellPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbRecType = New System.Windows.Forms.ComboBox()
        Me.cbAreas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBGender = New System.Windows.Forms.ComboBox()
        Me.CMBAge = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btAddAddress = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.lblListName = New System.Windows.Forms.Label()
        Me.BTClose = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(10, 231)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 15)
        Me.Label27.TabIndex = 136
        Me.Label27.Text = "Record Type:"
        '
        'txtPayeeName
        '
        Me.txtPayeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtPayeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPayeeName.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.txtPayeeName.Location = New System.Drawing.Point(73, 33)
        Me.txtPayeeName.Name = "txtPayeeName"
        Me.txtPayeeName.Size = New System.Drawing.Size(360, 29)
        Me.txtPayeeName.TabIndex = 160
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Name:"
        '
        'txtCellPhone
        '
        Me.txtCellPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCellPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCellPhone.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.txtCellPhone.Location = New System.Drawing.Point(73, 104)
        Me.txtCellPhone.Name = "txtCellPhone"
        Me.txtCellPhone.Size = New System.Drawing.Size(168, 29)
        Me.txtCellPhone.TabIndex = 165
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 21)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "Mobile:"
        '
        'cbRecType
        '
        Me.cbRecType.FormattingEnabled = True
        Me.cbRecType.Location = New System.Drawing.Point(89, 227)
        Me.cbRecType.Name = "cbRecType"
        Me.cbRecType.Size = New System.Drawing.Size(160, 21)
        Me.cbRecType.TabIndex = 167
        '
        'cbAreas
        '
        Me.cbAreas.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.cbAreas.FormattingEnabled = True
        Me.cbAreas.Location = New System.Drawing.Point(73, 68)
        Me.cbAreas.Name = "cbAreas"
        Me.cbAreas.Size = New System.Drawing.Size(360, 29)
        Me.cbAreas.TabIndex = 316
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 317
        Me.Label3.Text = "Address:"
        '
        'CMBGender
        '
        Me.CMBGender.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female"})
        Me.CMBGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CMBGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBGender.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.CMBGender.FormattingEnabled = True
        Me.CMBGender.Items.AddRange(New Object() {"N/A", "Male", "Female"})
        Me.CMBGender.Location = New System.Drawing.Point(73, 140)
        Me.CMBGender.Name = "CMBGender"
        Me.CMBGender.Size = New System.Drawing.Size(168, 29)
        Me.CMBGender.TabIndex = 320
        '
        'CMBAge
        '
        Me.CMBAge.AutoCompleteCustomSource.AddRange(New String() {"1 Day", "2 Days", "3 Days", "4 Days", "5 Days", "6 Days", "7 Days", "8 Days", "9 Days", "10 Days", "11 Days", "12 Days", "13 Days", "14 Days", "15 Days", "16 Days", "17 Days", "18 Days", "19 Days", "20 Days", "21 Days", "22 Days", "23 Days", "24 Days", "25 Days", "26 Days", "27 Days", "28 Days", "29 Days", "1 Month", "2 Months", "3  Months", "4  Months", "5  Months", "6  Months", "7  Months", "8  Months", "9  Months", "10  Months", "11  Months", "1 Yr", "2 Yrs", "3 Yrs", "4 yrs", "5 Yrs", "6 Yrs", "7 Yrs", "8 Yrs", "9 Yrs", "10 Yrs", "11 Yrs", "12 Yrs", "13 Yrs", "14 Yrs", "15 Yrs", "16 Yrs", "17 Yrs", "18 Yrs", "19 Yrs", "20 Yrs", "21 Yrs", "22 Yrs", "23 Yrs", "24 Yrs", "25 Yrs", "26 Yrs", "27 Yrs", "28 Yrs", "29 Yrs", "30 Yrs", "31 Yrs", "32 Yrs", "33 Yrs", "34 Yrs", "35 Yrs", "36 Yrs", "37 Yrs", "38 Yrs", "39 Yrs", "40 Yrs", "41 Yrs", "42 Yrs", "43 Yrs", "44 Yrs", "45 Yrs", "46 Yrs", "47 Yrs", "48 Yrs", "49 Yrs", "50 Yrs", "51 Yrs", "52 Yrs", "53 Yrs", "54 Yrs", "55 Yrs", "56 Yrs", "57 Yrs", "58 Yrs", "59 Yrs", "60 Yrs", "61 Yrs", "62 Yrs", "63 Yrs", "64 Yrs", "65 Yrs", "66 Yrs", "67 Yrs", "68 Yrs", "69 Yrs", "70 Yrs", "71 Yrs", "72 Yrs", "73 Yrs", "74 Yrs", "75 Yrs", "76 Yrs", "77 Yrs", "78 Yrs", "79 Yrs", "80 Yrs", "81 Yrs", "82 Yrs", "83 Yrs", "84 Yrs", "85 Yrs", "86 Yrs", "87 Yrs", "88 Yrs", "89 Yrs", "90 Yrs", "91 Yrs", "92 Yrs", "93 Yrs", "94 Yrs", "95 Yrs", "96 Yrs", "97 Yrs", "98 Yrs", "99 Yrs", "100 Yrs", "101 Yrs", "102 Yrs", "103 Yrs", "104 Yrs", "105 Yrs", "106 Yrs", "107 Yrs", "108 Yrs", "109 Yrs", "110 Yrs"})
        Me.CMBAge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CMBAge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBAge.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.CMBAge.FormattingEnabled = True
        Me.CMBAge.Items.AddRange(New Object() {"N/A", "1 Day", "2 Days", "3 Days", "4 Days", "5 Days", "6 Days", "7 Days", "8 Days", "9 Days", "10 Days", "11 Days", "12 Days", "13 Days", "14 Days", "15 Days", "16 Days", "17 Days", "18 Days", "19 Days", "20 Days", "21 Days", "22 Days", "23 Days", "24 Days", "25 Days", "26 Days", "27 Days", "28 Days", "29 Days", "1 Month", "2 Months", "3  Months", "4  Months", "5  Months", "6  Months", "7  Months", "8  Months", "9  Months", "10  Months", "11  Months", "1 Yr", "2 Yrs", "3 Yrs", "4 yrs", "5 Yrs", "6 Yrs", "7 Yrs", "8 Yrs", "9 Yrs", "10 Yrs", "11 Yrs", "12 Yrs", "13 Yrs", "14 Yrs", "15 Yrs", "16 Yrs", "17 Yrs", "18 Yrs", "19 Yrs", "20 Yrs", "21 Yrs", "22 Yrs", "23 Yrs", "24 Yrs", "25 Yrs", "26 Yrs", "27 Yrs", "28 Yrs", "29 Yrs", "30 Yrs", "31 Yrs", "32 Yrs", "33 Yrs", "34 Yrs", "35 Yrs", "36 Yrs", "37 Yrs", "38 Yrs", "39 Yrs", "40 Yrs", "41 Yrs", "42 Yrs", "43 Yrs", "44 Yrs", "45 Yrs", "46 Yrs", "47 Yrs", "48 Yrs", "49 Yrs", "50 Yrs", "51 Yrs", "52 Yrs", "53 Yrs", "54 Yrs", "55 Yrs", "56 Yrs", "57 Yrs", "58 Yrs", "59 Yrs", "60 Yrs", "61 Yrs", "62 Yrs", "63 Yrs", "64 Yrs", "65 Yrs", "66 Yrs", "67 Yrs", "68 Yrs", "69 Yrs", "70 Yrs", "71 Yrs", "72 Yrs", "73 Yrs", "74 Yrs", "75 Yrs", "76 Yrs", "77 Yrs", "78 Yrs", "79 Yrs", "80 Yrs", "81 Yrs", "82 Yrs", "83 Yrs", "84 Yrs", "85 Yrs", "86 Yrs", "87 Yrs", "88 Yrs", "89 Yrs", "90 Yrs", "91 Yrs", "92 Yrs", "93 Yrs", "94 Yrs", "95 Yrs", "96 Yrs", "97 Yrs", "98 Yrs", "99 Yrs", "100 Yrs", "101 Yrs", "102 Yrs", "103 Yrs", "104 Yrs", "105 Yrs", "106 Yrs", "107 Yrs", "108 Yrs", "109 Yrs", "110 Yrs"})
        Me.CMBAge.Location = New System.Drawing.Point(290, 104)
        Me.CMBAge.Name = "CMBAge"
        Me.CMBAge.Size = New System.Drawing.Size(143, 29)
        Me.CMBAge.TabIndex = 318
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(9, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 321
        Me.Label2.Text = "Gender:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(250, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 21)
        Me.Label5.TabIndex = 319
        Me.Label5.Text = "Age:"
        '
        'txtAddress
        '
        Me.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAddress.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.txtAddress.Location = New System.Drawing.Point(73, 175)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(168, 29)
        Me.txtAddress.TabIndex = 322
        '
        'btAddAddress
        '
        Me.btAddAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAddAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAddAddress.Font = New System.Drawing.Font("Times New Roman", 14.25!)
        Me.btAddAddress.Location = New System.Drawing.Point(248, 176)
        Me.btAddAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btAddAddress.Name = "btAddAddress"
        Me.btAddAddress.Size = New System.Drawing.Size(185, 27)
        Me.btAddAddress.TabIndex = 335
        Me.btAddAddress.Text = "Add New Address"
        Me.btAddAddress.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.BackColor = System.Drawing.Color.Black
        Me.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSave.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.btSave.ForeColor = System.Drawing.Color.White
        Me.btSave.Location = New System.Drawing.Point(248, 139)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(185, 34)
        Me.btSave.TabIndex = 152
        Me.btSave.Text = "Update"
        Me.btSave.UseVisualStyleBackColor = False
        '
        'lblListName
        '
        Me.lblListName.BackColor = System.Drawing.Color.Transparent
        Me.lblListName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblListName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListName.ForeColor = System.Drawing.Color.Green
        Me.lblListName.Location = New System.Drawing.Point(0, -1)
        Me.lblListName.Name = "lblListName"
        Me.lblListName.Size = New System.Drawing.Size(403, 32)
        Me.lblListName.TabIndex = 337
        Me.lblListName.Text = "Patient Profile"
        '
        'BTClose
        '
        Me.BTClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTClose.BackColor = System.Drawing.Color.Transparent
        Me.BTClose.BackgroundImage = CType(resources.GetObject("BTClose.BackgroundImage"), System.Drawing.Image)
        Me.BTClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTClose.Location = New System.Drawing.Point(400, 1)
        Me.BTClose.Name = "BTClose"
        Me.BTClose.Size = New System.Drawing.Size(32, 30)
        Me.BTClose.TabIndex = 338
        Me.BTClose.UseVisualStyleBackColor = False
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.BTClose)
        Me.MainPanel.Controls.Add(Me.CMBAge)
        Me.MainPanel.Controls.Add(Me.txtPayeeName)
        Me.MainPanel.Controls.Add(Me.lblListName)
        Me.MainPanel.Controls.Add(Me.btSave)
        Me.MainPanel.Controls.Add(Me.cbRecType)
        Me.MainPanel.Controls.Add(Me.txtCellPhone)
        Me.MainPanel.Controls.Add(Me.Label1)
        Me.MainPanel.Controls.Add(Me.Label27)
        Me.MainPanel.Controls.Add(Me.cbAreas)
        Me.MainPanel.Controls.Add(Me.Label4)
        Me.MainPanel.Controls.Add(Me.btAddAddress)
        Me.MainPanel.Controls.Add(Me.Label3)
        Me.MainPanel.Controls.Add(Me.txtAddress)
        Me.MainPanel.Controls.Add(Me.Label5)
        Me.MainPanel.Controls.Add(Me.CMBGender)
        Me.MainPanel.Controls.Add(Me.Label2)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(434, 206)
        Me.MainPanel.TabIndex = 339
        '
        'frmPateintProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmPateintProfile"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtPayeeName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCellPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbRecType As System.Windows.Forms.ComboBox
    Friend WithEvents cbAreas As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CMBGender As System.Windows.Forms.ComboBox
    Friend WithEvents CMBAge As System.Windows.Forms.ComboBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btAddAddress As Button
    Private WithEvents lblListName As Label
    Friend WithEvents BTClose As Button
    Friend WithEvents MainPanel As Panel
End Class
