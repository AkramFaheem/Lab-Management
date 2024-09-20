'Option Strict On

Option Explicit On

Imports System
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Collections.Generic

Public Class frmStatus
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents MIMgList As System.Windows.Forms.ImageList
    Friend WithEvents ImgType As System.Windows.Forms.PictureBox

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatus))
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.MIMgList = New System.Windows.Forms.ImageList(Me.components)
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.ImgType = New System.Windows.Forms.PictureBox()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(34, 19)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStatus.Size = New System.Drawing.Size(451, 71)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Please Wait Until Complate Your Request"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.MIMgList.Images.SetKeyName(5, "AppIcon")
        '
        'PicBox
        '
        Me.PicBox.BackColor = System.Drawing.Color.Transparent
        Me.PicBox.Image = CType(resources.GetObject("PicBox.Image"), System.Drawing.Image)
        Me.PicBox.Location = New System.Drawing.Point(490, 33)
        Me.PicBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(52, 47)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 4
        Me.PicBox.TabStop = False
        '
        'ImgType
        '
        Me.ImgType.BackColor = System.Drawing.Color.Transparent
        Me.ImgType.Location = New System.Drawing.Point(10, 7)
        Me.ImgType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ImgType.Name = "ImgType"
        Me.ImgType.Size = New System.Drawing.Size(22, 23)
        Me.ImgType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgType.TabIndex = 5
        Me.ImgType.TabStop = False
        '
        'frmStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 112)
        Me.ControlBox = False
        Me.Controls.Add(Me.ImgType)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.lblStatus)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStatus"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "«·—Ã«¡ «·«‰ Ÿ«— ﬁ·Ì·«"
        Me.TopMost = True
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overloads Sub Show(ByVal Message As String, ByVal MIcon As MessageBoxIcon)
        lblStatus.Text = Message

        If MessageBoxIcon.Asterisk = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Asterisk.ToBitmap()
        End If

        If MessageBoxIcon.Error = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Error.ToBitmap()
        End If

        If MessageBoxIcon.Exclamation = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Exclamation.ToBitmap()
        End If

        If MessageBoxIcon.Hand = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Hand.ToBitmap()
        End If

        If MessageBoxIcon.Information = MIcon Then
            ImgType.Image = MIMgList.Images(1)
        End If

        If MessageBoxIcon.Question = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Question.ToBitmap()
        End If

        If MessageBoxIcon.Stop = MIcon Then
            ImgType.Image = MIMgList.Images(3)
        End If

        If MessageBoxIcon.Warning = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Warning.ToBitmap()
        End If

        Me.Show()

        Application.DoEvents()
    End Sub

    Private Sub lblStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblStatus.Click

    End Sub

    Private Sub lblStatus_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles lblStatus.Paint


        'Dim MGraphics As Graphics = e.Graphics
        'Dim MPen As New Pen(Color.FromArgb(96, 155, 173), 1)

        'Dim Area As New Rectangle(0, 0, lblStatus.Width - 1, lblStatus.Height - 1)
        'Dim LGradient As New LinearGradientBrush(Area, Color.FromArgb(96, 160, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.BackwardDiagonal)
        'MGraphics.FillRectangle(LGradient, Area)
        'MGraphics.DrawRectangle(MPen, Area)

        'Dim DrawFont As New Font("Calibri", 20, FontStyle.Regular)
        'Dim DrawBrush As New SolidBrush(Color.Red)
        'Dim DrawPoint As New PointF(2.0F, 6.0F)

        'Dim DrawGradientBrush As New LinearGradientBrush(e.Graphics.ClipBounds, Color.White, _
        '       Color.FromArgb(122, 158, 226), LinearGradientMode.ForwardDiagonal)

        'e.Graphics.DrawString(lblStatus.Text, DrawFont, DrawBrush, DrawPoint)


    End Sub

    Private Sub frmStatus_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim MGraphics As Graphics = e.Graphics
        Dim MPen As New Pen(Color.FromArgb(96, 155, 173), 1)

        Dim Area As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim LGradient As New LinearGradientBrush(Area, Color.FromArgb(200, 200, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical)
        MGraphics.FillRectangle(LGradient, Area)
        MGraphics.DrawRectangle(MPen, Area)

    End Sub

    Private Sub frmStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
