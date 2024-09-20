Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class frmMainDashBoard

    Public AccIDVar As Integer
    Public AccIDType As Integer
    Public BossExist As Integer

    Public BossUserID As Integer
    Public FinanceYear As Integer

    Public UserFullName As String
    Public SafAcccVar As String
    Public DisAccVar As String

    Public FromVar As Integer = 0

    Dim MLocation As Point

    Public TimeVar As New DateTime()

    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 47)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub
    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form, _text As String)

        'Open only form'

        'WindowState = FormWindowState.Maximized

        'If currentChildForm IsNot Nothing Then
        '    currentChildForm.Close()
        'End If
        'currentChildForm = childForm
        ''end'
        'PanelDeskTop.Controls.Clear()

        'childForm.TopLevel = False
        'childForm.FormBorderStyle = FormBorderStyle.None
        'childForm.Dock = DockStyle.Fill
        'PanelDeskTop.Controls.Add(childForm)
        'PanelDeskTop.Tag = childForm
        'childForm.Parent = PanelDeskTop
        'childForm.BringToFront()
        'childForm.Show()
        lblFormTitle.Text = childForm.Text

        WindowState = FormWindowState.Maximized

        If IsFormOpen(childForm) = False Then

            Text = _text

            PanelDeskTop.Controls.Clear()

            childForm.TopLevel = False
            PanelDeskTop.Height = childForm.Height
            PanelDeskTop.Controls.Add(childForm)
            childForm.Parent = PanelDeskTop
            'xx.Show()

            childForm.Show()

        Else

            Text = _text

            childForm.Height = PanelDeskTop.Height
            childForm.Width = PanelDeskTop.Width

            childForm.Parent = PanelDeskTop

            childForm.Show()

            childForm.BringToFront()

        End If
    End Sub
    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Reset()

        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.MediumPurple
        lblFormTitle.Text = "Home"
        Text = Nothing

    End Sub
    'Events'
    'Reset'
    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles ImgHome.Click
        'If currentChildForm IsNot Nothing Then
        '    currentChildForm.Close()
        'End If

        PanelDeskTop.Controls.Clear()

        Reset()
    End Sub

    Private Sub FrmMainDashBoard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    'Close-Maximize-Minimize'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub FrmMainDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PanelTitleBar_Paint(sender As Object, e As PaintEventArgs) Handles PanelTitleBar.Paint

    End Sub

    Private Sub BtResult_Click(sender As Object, e As EventArgs) Handles btResult.Click

        ActivateButton(sender, RGBColors.color1)
        WindowState = FormWindowState.Maximized

        If IsFormOpen(frmResultes) = False Then

            Text = "Dashboard - Entry Results"
            lblFormTitle.Text = Text

            PanelDeskTop.Controls.Clear()
            'Dim xx As New frmWaiting
            frmResultes.Close()

            frmResultes.TopLevel = False
            PanelDeskTop.Height = frmResultes.Height
            PanelDeskTop.Controls.Add(frmResultes)
            frmResultes.Parent = PanelDeskTop
            'xx.Show()

            frmResultes.AccIDVar = AccIDVar
            frmResultes.UserFullName = UserFullName
            frmResultes.AccIDType = AccIDType
            frmResultes.Show()

        Else

            Text = "Dashboard - Entry Results"

            lblFormTitle.Text = Text

            frmResultes.Height = PanelDeskTop.Height
            frmResultes.Width = PanelDeskTop.Width

            frmResultes.Parent = PanelDeskTop

            frmResultes.Show()

            frmResultes.BringToFront()

        End If

    End Sub

    Private Sub BtTestsProfile_Click(sender As Object, e As EventArgs) Handles btTestsProfile.Click

        ActivateButton(sender, RGBColors.color1)
        WindowState = FormWindowState.Maximized

        If IsFormOpen(frmProfilesSetup) = False Then

            Text = "Dashboard - Profiles Setup Interface"
            lblFormTitle.Text = Text

            PanelDeskTop.Controls.Clear()
            'Dim xx As New frmWaiting
            frmProfilesSetup.Close()

            frmProfilesSetup.TopLevel = False
            PanelDeskTop.Height = frmProfilesSetup.Height
            PanelDeskTop.Controls.Add(frmProfilesSetup)
            frmProfilesSetup.Parent = PanelDeskTop
            'xx.Show()

            frmProfilesSetup.AccIDVar = AccIDVar
            frmProfilesSetup.UserFullName = UserFullName
            frmProfilesSetup.AccIDType = AccIDType
            frmProfilesSetup.Show()

        Else

            Text = "Dashboard - Profiles Setup Interface"
            lblFormTitle.Text = Text

            frmProfilesSetup.Height = PanelDeskTop.Height
            frmProfilesSetup.Width = PanelDeskTop.Width

            frmProfilesSetup.Parent = PanelDeskTop

            frmProfilesSetup.Show()

            frmProfilesSetup.BringToFront()

        End If

    End Sub

    Public Sub BtRegistration_Click(sender As Object, e As EventArgs) Handles btRegistration.Click

        ActivateButton(sender, RGBColors.color1)

        WindowState = FormWindowState.Maximized

        If IsFormOpen(FrmReg) = False Then

            Text = "Dashboard - Registration"
            lblFormTitle.Text = Text

            PanelDeskTop.Controls.Clear()
            'Dim xx As New frmWaiting
            FrmReg.Close()

            FrmReg.TopLevel = False
            PanelDeskTop.Height = FrmReg.Height
            PanelDeskTop.Controls.Add(FrmReg)
            FrmReg.Parent = PanelDeskTop
            'xx.Show()

            FrmReg.AccIDVar = AccIDVar
            FrmReg.UserFullName = UserFullName
            FrmReg.AccIDType = AccIDType
            FrmReg.Show()

        Else

            Text = "Dashboard - Registration"
            lblFormTitle.Text = Text

            FrmReg.Height = PanelDeskTop.Height
            FrmReg.Width = PanelDeskTop.Width

            FrmReg.Parent = PanelDeskTop

            FrmReg.Show()

            FrmReg.BringToFront()

        End If

    End Sub

    Private Sub frmMainDashBoard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Application.Exit()

    End Sub

    Private Sub btReportCenter_Click(sender As Object, e As EventArgs) Handles btReportCenter.Click
        FrmReportCenter.Show()
        FrmReportCenter.BringToFront()
    End Sub

    Private Sub BTISIValue_Click(sender As Object, e As EventArgs) Handles BTISIValue.Click
        FrmISI.Show()
        FrmISI.BringToFront()
    End Sub

    Private Sub BtReadyToPrint_Click(sender As Object, e As EventArgs) Handles btReadyToPrint.Click

    End Sub

    Private Sub BtSetting_Click(sender As Object, e As EventArgs) Handles btSetting.Click

        SettingMenu.Show(btSetting.PointToScreen(New Point(0, btSetting.Height)))

    End Sub

    Private Sub ISI_Click(sender As Object, e As EventArgs) Handles ISI.Click
        FrmISI.Show()
        FrmISI.BringToFront()
    End Sub

    Private Sub Culture_Click(sender As Object, e As EventArgs) Handles Culture.Click
        frmCultureSetup.Show()
        frmCultureSetup.BringToFront()
    End Sub
End Class