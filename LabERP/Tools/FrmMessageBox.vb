Option Explicit On

Imports System
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Collections.Generic

#Region "About Author"

REM Name    : Gehan Fernando
REM Product : MSN MessageBox [ v 1.0.0 ]
REM Date    : 27-Feb-2007
REM Company : Aklo Information Technologies (Pvt) Ltd.

#End Region

Public Class FrmMessageBox
    Inherits Form

    Dim NewFrmMessageBox As FrmMessageBox

    Dim WithEvents CmdOk As Button
    Dim WithEvents CmdYes As Button
    Dim WithEvents CmdNo As Button
    Dim WithEvents CmdCancel As Button
    Dim WithEvents CmdAbort As Button
    Dim WithEvents CmdRetry As Button
    Dim WithEvents CmdIgnore As Button

    Dim RetValue As String
    Dim MLocation As Point
    Dim BSize As Size = Nothing
    Dim BFont As New Font("Calibri", 10, FontStyle.Regular)
    Dim Ico As Icon

    Private Sub FrmMessageBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LblHeader.Width = Me.Width

    End Sub

    Private Sub LblHeader_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles LblHeader.Paint

        Dim MGraphics As Graphics = e.Graphics
        Dim MPen As New Pen(Color.FromArgb(96, 155, 173), 1)

        Dim Area As New Rectangle(0, 0, LblHeader.Width - 1, LblHeader.Height - 1)
        Dim LGradient As New LinearGradientBrush(Area, Color.FromArgb(96, 160, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.BackwardDiagonal)
        MGraphics.FillRectangle(LGradient, Area)
        MGraphics.DrawRectangle(MPen, Area)

        Dim DrawFont As New Font("Calibri", 11, FontStyle.Bold)
        Dim DrawBrush As New SolidBrush(Color.Black)
        Dim DrawPoint As New PointF(1.0F, 6.0F)

        Dim DrawGradientBrush As New LinearGradientBrush(e.Graphics.ClipBounds, Color.White, _
               Color.FromArgb(122, 158, 226), LinearGradientMode.ForwardDiagonal)

        e.Graphics.DrawString(LblHeader.Text, DrawFont, DrawBrush, DrawPoint)

    End Sub

    Private Sub FrmMessageBox_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        Dim MGraphics As Graphics = e.Graphics
        Dim MPen As New Pen(Color.FromArgb(96, 155, 173), 1)

        Dim Area As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        Dim LGradient As New LinearGradientBrush(Area, Color.FromArgb(200, 200, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical)
        MGraphics.FillRectangle(LGradient, Area)
        MGraphics.DrawRectangle(MPen, Area)

    End Sub

    Private Sub LblHeader_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblHeader.MouseDown

        MLocation = e.Location

    End Sub

    Private Sub LblHeader_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblHeader.MouseMove

        If String.Compare(Control.MouseButtons.ToString(), "Left") = 0 Then
            Dim MSize As New Size(MLocation)
            MSize.Width = e.X - MLocation.X
            MSize.Height = e.Y - MLocation.Y
            Me.Location = Point.Add(Me.Location, MSize)
        End If

    End Sub

    Public Function ShowMessage(ByVal MMessage As String, ByVal MTitle As String, _
                                ByVal MIcon As MessageBoxIcon, ByVal MButton As MessageBoxButtons, _
                                ByRef NewFrmMessageBox As FrmMessageBox) As String

        NewFrmMessageBox.LblHeader.Text = MTitle.ToString().Trim()
        NewFrmMessageBox.LblMessage.Text = MMessage.ToString.Trim()

        If MessageBoxIcon.Asterisk = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Asterisk.ToBitmap()
            GoTo Show_Buttons
        End If

        If MessageBoxIcon.Error = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Error.ToBitmap()
            GoTo Show_Buttons
        End If

        If MessageBoxIcon.Exclamation = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Exclamation.ToBitmap()
            GoTo Show_Buttons
        End If

        If MessageBoxIcon.Hand = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Hand.ToBitmap()
            GoTo Show_Buttons
        End If

        If MessageBoxIcon.Information = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Information.ToBitmap()
            GoTo Show_Buttons
        End If

        If MessageBoxIcon.None = MIcon Then
            GoTo Show_Buttons
        End If

        If MessageBoxIcon.Question = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Question.ToBitmap()
            GoTo Show_Buttons
        End If

        If MessageBoxIcon.Stop = MIcon Then
            ImgType.Image = MIMgList.Images(3)
            GoTo Show_Buttons
        End If

        If MessageBoxIcon.Warning = MIcon Then
            ImgType.Image = System.Drawing.SystemIcons.Warning.ToBitmap()
            GoTo Show_Buttons
        End If

Show_Buttons:
        If MessageBoxButtons.AbortRetryIgnore = MButton Then
            Call LoadButtons_AbortRetryIgnore()
            GoTo Show_Dialog
        End If

        If MessageBoxButtons.OK = MButton Then
            Call LoadButtons_OK()
            GoTo Show_Dialog
        End If

        If MessageBoxButtons.OKCancel = MButton Then
            Call LoadButtons_OKCancel()
            GoTo Show_Dialog
        End If

        If MessageBoxButtons.RetryCancel = MButton Then
            Call LoadButtons_RetryCancel()
            GoTo Show_Dialog
        End If

        If MessageBoxButtons.YesNo = MButton Then
            Call LoadButtons_YesNo()
            GoTo Show_Dialog
        End If

        If MessageBoxButtons.YesNoCancel = MButton Then
            Call LoadButtons_YesNoCancel()
            GoTo Show_Dialog
        End If

Show_Dialog:
        NewFrmMessageBox.ShowDialog()
        Return RetValue

    End Function

    Private Sub LoadButtons_AbortRetryIgnore()

        REM --------------------------------
        BSize = New Size(58, 24)

        CmdAbort = New Button
        Dim BLocation As New Point(296, 155)
        Call CommanSet(CmdAbort, "&Abort", BSize, BLocation)
        BLocation = Nothing

        REM --------------------------------

        CmdRetry = New Button
        BLocation = New Point(356, 155)
        Call CommanSet(CmdRetry, "&Retry", BSize, BLocation)
        BLocation = Nothing

        REM --------------------------------

        CmdIgnore = New Button
        BLocation = New Point(416, 155)
        Call CommanSet(CmdIgnore, "&Ignore", BSize, BLocation)
        BLocation = Nothing

    End Sub

    Private Sub LoadButtons_OK()

        BSize = New Size(60, 26)

        CmdOk = New Button
        Dim BLocation As New Point(325, 100)
        Call CommanSet(CmdOk, "&Ok", BSize, BLocation)

    End Sub

    Private Sub LoadButtons_OKCancel()

        REM --------------------------------
        BSize = New Size(100, 26)

        CmdOk = New Button
        Dim BLocation As New Point(210, 100)
        Call CommanSet(CmdOk, "&Ok", BSize, BLocation)
        BLocation = Nothing

        REM --------------------------------

        CmdCancel = New Button
        BLocation = New Point(315, 100)
        Call CommanSet(CmdCancel, "&Cancel", BSize, BLocation)
        BLocation = Nothing

    End Sub

    Private Sub LoadButtons_RetryCancel()

        REM --------------------------------
        BSize = New Size(58, 24)

        CmdRetry = New Button
        Dim BLocation As New Point(356, 155)
        Call CommanSet(CmdRetry, "&Retry", BSize, BLocation)
        BLocation = Nothing

        REM --------------------------------

        CmdCancel = New Button
        BLocation = New Point(416, 155)
        Call CommanSet(CmdCancel, "&Cancel", BSize, BLocation)
        BLocation = Nothing

    End Sub

    Private Sub LoadButtons_YesNo()

        REM --------------------------------
        BSize = New Size(60, 26)

        CmdYes = New Button
        Dim BLocation As New Point(295, 100)
        Call CommanSet(CmdYes, "&Yes", BSize, BLocation)
        BLocation = Nothing

        REM --------------------------------

        CmdNo = New Button
        BLocation = New Point(360, 100)
        Call CommanSet(CmdNo, "&No", BSize, BLocation)
        BLocation = Nothing

    End Sub

    Private Sub LoadButtons_YesNoCancel()

        REM --------------------------------
        BSize = New Size(58, 24)

        CmdYes = New Button
        Dim BLocation As New Point(296, 155)
        Call CommanSet(CmdYes, "&Yes", BSize, BLocation)
        BLocation = Nothing

        REM --------------------------------

        CmdNo = New Button
        BLocation = New Point(356, 155)
        Call CommanSet(CmdNo, "&No", BSize, BLocation)
        BLocation = Nothing

        REM --------------------------------

        CmdCancel = New Button
        BLocation = New Point(416, 155)
        Call CommanSet(CmdCancel, "&Cancel", BSize, BLocation)
        BLocation = Nothing

    End Sub

    Private Sub CommanSet(ByVal Btn As Button, ByVal Txt As String, ByVal Sz As Size, ByVal Lc As Point)

        With Btn
            .Size = Sz
            .Text = Txt
            .BackColor = Color.Transparent
            .FlatAppearance.BorderSize = 0
            .FlatStyle = FlatStyle.Popup
            .Location = Lc
            .Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = BFont
            .Visible = True
        End With

        Me.Controls.Add(Btn)

    End Sub

    Private Sub CmdAbort_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdAbort.Click

        RetValue = "Abort"
        Me.Dispose()

    End Sub

    Private Sub CmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdCancel.Click

        RetValue = "Cancel"
        Me.Dispose()

    End Sub

    Private Sub CmdIgnore_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdIgnore.Click

        RetValue = "Ignore"
        Me.Dispose()

    End Sub

    Private Sub CmdNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdNo.Click

        RetValue = "No"
        Me.Dispose()

    End Sub

    Private Sub CmdRetry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdRetry.Click

        RetValue = "Retry"
        Me.Dispose()

    End Sub

    Private Sub CmdYes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdYes.Click

        RetValue = "Yes"
        Me.Dispose()

    End Sub

    Private Sub CmdOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdOk.Click

        RetValue = "Ok"
        Me.Dispose()

    End Sub

    Private Sub LblMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMessage.Click

    End Sub

    Private Sub LblHeader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblHeader.Click

    End Sub

    Private Sub lblBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

End Class