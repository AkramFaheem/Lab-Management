Public Class frmOSDashBoard

    Public AccIDVar As Integer
    Public AccIDType As Integer

    Public CoIDVar As Integer

    Public ImageFrom As Integer

    Public _Filename As String = ""
    Public pathname As String = ""


    Public MonthVar As Integer
    Public YearVar As Integer
    Public CompanyID As Integer = 10

    Public TimeVar As New DateTime()

    Public SafAcccVar As String

    Dim MLocation As Point
    Public UserFullName As String

    Protected Sub Shutdown()
        ' It's a good idea to make the system tray icon invisible before ending
        ' the application, otherwise, it can linger in the tray when the application
        ' is no longer running.

        'On Error Resume Next

        'If _connection.State = ConnectionState.Open Then

        '    _connection.Close()

        'End If

        'If conn.State = ConnectionState.Open Then

        '    conn.close()

        'End If



        'SysNotify.Visible = False
        Application.Exit()

    End Sub

    Private Sub BTClose_MouseHover(sender As Object, e As EventArgs) Handles BTClose.MouseHover
        BTClose.Image = My.Resources.ResourceManager.GetObject("if_Close_green")
    End Sub

    Private Sub BTMin_Click(sender As Object, e As EventArgs) Handles BTMin.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub BTClose_MouseLeave(sender As Object, e As EventArgs) Handles BTClose.MouseLeave
        BTClose.Image = My.Resources.ResourceManager.GetObject("if_Close_1891023")
    End Sub

    Private Sub BTMin_MouseHover(sender As Object, e As EventArgs) Handles BTMin.MouseHover
        BTMin.Image = My.Resources.ResourceManager.GetObject("icons8_minimize_window")
    End Sub

    Private Sub BTMin_MouseLeave(sender As Object, e As EventArgs) Handles BTMin.MouseLeave
        BTMin.Image = My.Resources.ResourceManager.GetObject("icons8_minimize_window__1_")
    End Sub


    Private Sub PanTitle_Paint(sender As Object, e As PaintEventArgs) Handles PanTitle.Paint

        'Dim MGraphics As Graphics = e.Graphics
        'Dim MPen As New Pen(Color.FromArgb(96, 155, 173), 1)

        'Dim Area As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)
        'Dim LGradient As New LinearGradientBrush(Area, Color.FromArgb(0, 0, 139), Color.FromArgb(0, 255, 255), LinearGradientMode.ForwardDiagonal)
        'MGraphics.FillRectangle(LGradient, Area)
        'MGraphics.DrawRectangle(MPen, Area)

    End Sub

    Private Sub PanTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles PanTitle.MouseDown

        MLocation = e.Location

    End Sub

    Private Sub PanTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles PanTitle.MouseMove

        If String.Compare(Control.MouseButtons.ToString(), "Left") = 0 Then
            Dim MSize As New Size(MLocation)
            MSize.Width = e.X - MLocation.X
            MSize.Height = e.Y - MLocation.Y
            Location = Point.Add(Location, MSize)
        End If

    End Sub


    Private Sub BTClose_Click(sender As Object, e As EventArgs) Handles BTClose.Click

        _DeleteTemporaryImages()

        Call Shutdown()

    End Sub

    Private Sub btSlide_Click(sender As Object, e As EventArgs) Handles btSlide.Click

        If SlidPanel.Width = 40 Then

            For x = 40 To 190 Step 5

                SlidPanel.Width = x

            Next

            HubTimer.Enabled = True
            HubTimer.Start()

            Exit Sub

        End If

        If SlidPanel.Width = 190 Then

            For x = 190 To 40 Step -5

                SlidPanel.Width = x

            Next

        End If

    End Sub

    Private Sub HubTimer_Tick(sender As Object, e As EventArgs) Handles HubTimer.Tick

        If HubTimer.Interval = 3000 Then

            If SlidPanel.Width = 190 Then

                For x = 190 To 40 Step -5

                    SlidPanel.Width = x

                Next

            End If

        End If

        HubTimer.Stop()

    End Sub

    Private Sub frmSalesSupervisorMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.Manual
        With Screen.PrimaryScreen.WorkingArea
            Me.SetBounds(.Left, .Top, .Width, .Height)
        End With

    End Sub

    Private Sub SideSplitt_Panel1_MouseEnter(sender As Object, e As EventArgs) Handles SideSplit.MouseEnter


        If SlidPanel.Width = 40 Then

            For x = 40 To 190 Step 5

                SlidPanel.Width = x

            Next

            HubTimer.Enabled = True
            HubTimer.Start()

            Exit Sub

        End If

    End Sub

    Private Sub BtTestsSetup_Click(sender As Object, e As EventArgs) Handles btProfilesSetup.Click


        If SlidPanel.Width = 190 Then


            For x = 190 To 40 Step -10

                SlidPanel.Width = x

            Next

        End If

        If IsFormOpen(frmProfilesSetup) = False Then

            Title.Text = "Dashboard - Profiles Setup Interface"
            Text = "Dashboard - Profiles Setup Interface"

            MainPanel.Controls.Clear()
            'Dim xx As New frmWaiting
            frmProfilesSetup.Close()

            frmProfilesSetup.TopLevel = False
            MainPanel.Height = frmProfilesSetup.Height
            MainPanel.Controls.Add(frmProfilesSetup)
            frmProfilesSetup.Parent = MainPanel
            'xx.Show()

            frmProfilesSetup.AccIDVar = AccIDVar
            frmProfilesSetup.UserFullName = UserFullName
            frmProfilesSetup.AccIDType = AccIDType
            frmProfilesSetup.Show()

        Else

            Title.Text = "Dashboard - Profiles Setup Interface"
            Text = "Dashboard - Profiles Setup Interface"

            frmProfilesSetup.Height = MainPanel.Height
            frmProfilesSetup.Width = MainPanel.Width

            frmProfilesSetup.Parent = MainPanel

            frmProfilesSetup.Show()

            frmProfilesSetup.BringToFront()

        End If

    End Sub

    Public Sub BtFrontDisk_Click(sender As Object, e As EventArgs) Handles btRegistration.Click

        If btSlide.Visible = True Then

            If SlidPanel.Width = 190 Then

                For x = 190 To 40 Step -10

                    SlidPanel.Width = x

                Next

            End If

        End If


        operation("Delete From TransactionTempCounters where UserID = " & AccIDVar & "")

        If IsFormOpen(FrmReg) = False Then

            Title.Text = "Dashboard - Registration"
            Text = "Dashboard - Registration"

            MainPanel.Controls.Clear()
            'Dim xx As New frmWaiting
            FrmReg.Close()

            FrmReg.TopLevel = False
            MainPanel.Height = FrmReg.Height
            MainPanel.Controls.Add(FrmReg)
            FrmReg.Parent = MainPanel
            'xx.Show()

            FrmReg.AccIDVar = AccIDVar
            FrmReg.UserFullName = UserFullName
            FrmReg.AccIDType = AccIDType
            FrmReg.Show()

        Else

            Title.Text = "Dashboard - Registration"
            Text = "Dashboard - Registration"

            FrmReg.Height = MainPanel.Height
            FrmReg.Width = MainPanel.Width

            FrmReg.Parent = MainPanel

            FrmReg.Show()

            FrmReg.BringToFront()

        End If

    End Sub

    Private Sub frmOSDashBoard_Activated(sender As Object, e As EventArgs) Handles Me.Activated


        TimeVar = DateTime.Parse(Now.TimeOfDay.ToString)

        lblUserName.Text = " System Login By " & UserFullName & "  Login Time " & TimeVar.ToString("dd:MM:yyyy hh:mm:ss tt")

    End Sub

    Public Sub BtResults_Click(sender As Object, e As EventArgs) Handles btResults.Click

        If SlidPanel.Width = 190 Then

            For x = 190 To 40 Step -10

                SlidPanel.Width = x

            Next

        End If

        If IsFormOpen(frmResultes) = False Then

            Title.Text = "Dashboard - Entry Resultes"
            Text = "Dashboard - Entry Resultes"

            MainPanel.Controls.Clear()
            'Dim xx As New frmWaiting
            frmResultes.Close()

            frmResultes.TopLevel = False
            MainPanel.Height = frmResultes.Height
            MainPanel.Controls.Add(frmResultes)
            frmResultes.Parent = MainPanel
            'xx.Show()

            frmResultes.AccIDVar = AccIDVar
            frmResultes.UserFullName = UserFullName
            frmResultes.AccIDType = AccIDType
            frmResultes.Show()

        Else

            Title.Text = "Dashboard - Entry Resultes"
            Text = "Dashboard - Entry Resultes"

            frmResultes.Height = MainPanel.Height
            frmResultes.Width = MainPanel.Width

            frmResultes.Parent = MainPanel

            frmResultes.Show()

            frmResultes.BringToFront()

        End If

    End Sub

End Class