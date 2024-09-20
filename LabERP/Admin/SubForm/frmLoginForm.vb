Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class frmLoginForm

    Public AccIDVar As Integer
    Public AccIDType As Integer

    Public UserFullName As String
    Public SafAcccVar As String
    Public DisAccVar As String

    Public FromVar As Integer
    Public CurrentRecord As Integer
    Public AutoFillCHK As Integer = 0


    Public SeedVar As Integer = 1000000
    Public RecPrefix As String

    Public PayeeID As Object = Nothing
    Public PayName As Object = Nothing
    Public LocIDVar As Integer = 1
    Private Sub FrmLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set backgroundcolors, forcolors
        ' borders size, color
        ' flat style
        'Panel1.BackColor = Color.FromArgb(120, 0, 0, 0)
        'Panel2.BackColor = Color.FromArgb(120, 0, 0, 0)


        Label1.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent


        'Label2.ForeColor = Color.White
        'Label3.ForeColor = Color.White


        ButtonClose.FlatStyle = FlatStyle.Flat
        ButtonMinimize.FlatStyle = FlatStyle.Flat
        ButtonClose.FlatAppearance.BorderSize = 0
        ButtonMinimize.FlatAppearance.BorderSize = 0

        TextBoxUserName.BackColor = Color.AliceBlue
        TextBoxPassWord.BackColor = Color.AliceBlue
        TextBoxChangePW.BackColor = Color.AliceBlue

        TextBoxUserName.ForeColor = Color.FromArgb(39, 174, 96)
        TextBoxPassWord.ForeColor = Color.FromArgb(39, 174, 96)
        TextBoxChangePW.ForeColor = Color.FromArgb(39, 174, 96)

        ButtonLogin.FlatStyle = FlatStyle.Flat
        ButtonLogin.BackColor = Color.FromArgb(39, 174, 96)
        ButtonLogin.ForeColor = Color.White
        ButtonLogin.FlatAppearance.BorderColor = Color.White

    End Sub

    Private Sub ButtonClose_MouseHover(sender As Object, e As EventArgs) Handles ButtonClose.MouseHover

        ButtonClose.FlatAppearance.BorderSize = 1
        ButtonClose.FlatAppearance.BorderColor = Color.White

    End Sub

    Private Sub ButtonClose_MouseLeave(sender As Object, e As EventArgs) Handles ButtonClose.MouseLeave

        ButtonClose.FlatAppearance.BorderSize = 0

    End Sub

    Private Sub ButtonMinimize_MouseHover(sender As Object, e As EventArgs) Handles ButtonMinimize.MouseHover

        ButtonMinimize.FlatAppearance.BorderSize = 1
        ButtonMinimize.FlatAppearance.BorderColor = Color.White

    End Sub

    Private Sub ButtonMinimize_MouseLeave(sender As Object, e As EventArgs) Handles ButtonMinimize.MouseLeave

        ButtonMinimize.FlatAppearance.BorderSize = 0

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        Application.Exit()

    End Sub

    Private Sub ButtonMinimize_Click(sender As Object, e As EventArgs) Handles ButtonMinimize.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

opencon:
        Dim Frm As New FrmMessageBox
        Dim Result As String

        Dim objCryp = New Crypt("pogisichris")

        If TextBoxUserName.Text <> Nothing Then

            search("select * from BasUsers where UserName = '" & TextBoxUserName.Text & "'")

            If myreader.HasRows = True Then

                AccIDVar = myreader(0)

            End If

            If myreader.HasRows = False Then

                Result = Frm.ShowMessage("User Not Exist   ????", "TMLCC",
                                               MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

                TextBoxUserName.Text = Nothing
                TextBoxPassWord.Text = Nothing

                TextBoxUserName.Focus()

                Exit Sub

            End If

        End If

        If TextBoxPassWord.Text <> "" Then

            search("select * from BasUsers where UserID = " & AccIDVar & "")

            If TextBoxPassWord.Text = objCryp.DecryptData(Trim(myreader("PW"))) Then

                If myreader(3) = 1 Then

                    Hide()

                    AccIDType = myreader(3)
                    UserFullName = myreader(4)
                    SafAcccVar = myreader(5)
                    DisAccVar = myreader(6)

                    frmMainDashBoard.AccIDVar = AccIDVar
                    frmMainDashBoard.UserFullName = UserFullName
                    frmMainDashBoard.AccIDType = AccIDType
                    frmMainDashBoard.SafAcccVar = SafAcccVar

                    'frmMainDashBoard.btSafe.Visible = True
                    'frmMainDashBoard.btBankAudit.Visible = True
                    frmMainDashBoard.btReportCenter.Visible = True
                    frmMainDashBoard.btSetting.Visible = True
                    frmMainDashBoard.Show()

                ElseIf myreader(3) = 2 Then

                    Hide()

                    AccIDType = myreader(3)
                    UserFullName = myreader(4)
                    SafAcccVar = myreader(5)
                    DisAccVar = myreader(6)

                    frmMainDashBoard.AccIDVar = AccIDVar
                    frmMainDashBoard.UserFullName = UserFullName
                    frmMainDashBoard.AccIDType = AccIDType
                    frmMainDashBoard.SafAcccVar = SafAcccVar

                    frmMainDashBoard.btTestsProfile.Visible = False

                    frmMainDashBoard.Show()

                ElseIf myreader(3) = 3 Then

                    Hide()

                    AccIDType = myreader(3)
                    UserFullName = myreader(4)
                    SafAcccVar = myreader(5)
                    DisAccVar = myreader(6)

                    frmMainDashBoard.AccIDVar = AccIDVar
                    frmMainDashBoard.UserFullName = UserFullName
                    frmMainDashBoard.AccIDType = AccIDType
                    frmMainDashBoard.SafAcccVar = SafAcccVar

                    frmMainDashBoard.btTestsProfile.Visible = False
                    frmMainDashBoard.btResult.Visible = False

                    frmMainDashBoard.Show()


                ElseIf myreader(3) = 4 Then

                    Hide()

                    AccIDType = myreader(3)
                    UserFullName = myreader(4)
                    SafAcccVar = myreader(5)
                    DisAccVar = myreader(6)

                ElseIf myreader(3) = 5 Then

                    Hide()

                    AccIDType = myreader(3)
                    UserFullName = myreader(4)
                    SafAcccVar = myreader(5)
                    DisAccVar = myreader(6)

                    frmOSDashBoard.AccIDVar = AccIDVar
                    frmOSDashBoard.UserFullName = UserFullName
                    frmOSDashBoard.AccIDType = AccIDType
                    frmOSDashBoard.SafAcccVar = SafAcccVar

                    'frmOSDashBoard.btBankAudit.Visible = True

                    frmOSDashBoard.Show()


                ElseIf myreader(3) = 6 Then

                    Hide()

                    AccIDType = myreader(3)
                    UserFullName = myreader(4)


                ElseIf myreader(3) = 7 Then

                    Hide()

                    AccIDType = myreader(3)
                    UserFullName = myreader(4)
                    SafAcccVar = myreader(5)
                    DisAccVar = myreader(6)

                    frmOSDashBoard.AccIDVar = AccIDVar
                    frmOSDashBoard.UserFullName = UserFullName
                    frmOSDashBoard.AccIDType = AccIDType
                    frmOSDashBoard.SafAcccVar = SafAcccVar

                    frmOSDashBoard.Show()

                ElseIf myreader(3) = 8 Then

                    Hide()

                    AccIDType = myreader(3)
                    UserFullName = myreader(4)

                ElseIf myreader(3) = 9 Then

                    Hide()

                    AccIDType = myreader(3)
                    UserFullName = myreader(4)


                ElseIf myreader(3) = 10 Then

                    Hide()

                    AccIDType = myreader(3)
                    UserFullName = myreader(4)

                End If

            Else


                Result = Frm.ShowMessage("Pass Word Wrong Try Again", "Mahamahani Lab",
                                               MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

                TextBoxPassWord.Text = Nothing
                TextBoxPassWord.Focus()

            End If


        Else

            Result = Frm.ShowMessage("You Must Enter PassWord", "Mahamahani Lab",
                                               MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

            TextBoxPassWord.Focus()

        End If

    End Sub

    Private Sub TextBoxPassWord_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassWord.TextChanged

    End Sub

    Private Sub TextBoxPassWord_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPassWord.KeyDown

        If e.KeyCode = Keys.Enter Then

            ButtonLogin_Click(sender, e)

        End If

    End Sub

    Private Sub CbCompany_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LBLChangePW_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LBLChangePW.LinkClicked


        Dim Frm As New FrmMessageBox
        Dim Result As String

        Dim objCryp = New Crypt("pogisichris")


        If TextBoxPassWord.Text = Nothing Then

            Result = Frm.ShowMessage("Old PassWord Must Be Typed", "TMLCC",
                                               MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

            Exit Sub

        End If

        If TextBoxChangePW.Text = Nothing Then

            Result = Frm.ShowMessage("New PassWord Must Be Typed", "TMLCC",
                                               MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

            Exit Sub

        End If


        search("select * from BasUsers where UserName = '" & TextBoxUserName.Text & "'")

        If myreader.HasRows = False Then

            Exit Sub

        End If

        If TextBoxPassWord.Text <> objCryp.DecryptData(Trim(myreader(2))) Then

            Result = Frm.ShowMessage("PassWord Incorrect", "TMLCC",
                                               MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

            TextBoxPassWord.Focus()

            Exit Sub

        End If

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        'Try


        cmd.CommandText = "UPDATE BasUsers set [PW] = @PW where UserName = '" & TextBoxUserName.Text & "'"

        cmd.Parameters.Add(New SqlParameter("@PW", SqlDbType.VarChar))
        'cmd.Parameters.Add(New sqlParameter("@RecImage", bytImage))
        cmd.Parameters("@PW").Value = objCryp.EncryptData(TextBoxChangePW.Text)

        cmd.ExecuteNonQuery()

        TransOne.Commit()

        conn.Close()

        Result = Frm.ShowMessage("Old PassWord Changed", "TMLCC",
                                          MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

        TextBoxUserName.Text = ""
        TextBoxPassWord.Text = ""
        TextBoxChangePW.Text = ""

        TextBoxUserName.Focus()

        'Me.cbDirection.DataSource = Nothing

        'Me.cbDirection.Focus()

        'Catch ex As Exception

        '    Result = Frm.ShowMessage("الرجاء إخيار أسم المستخدم", "Ali Abd Elsatir HISTO CENTER", _
        '                                      MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

        '    TransOne.Rollback()

        'Finally

        '    conn.Close()

        'End Try
    End Sub

    Private Sub frmLoginForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        TextBoxUserName.Focus()

    End Sub



    'Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    '    Dim AccountNoVar As String = Nothing

    '    search("SELECT  COUNT(AccountNo) AS Total FROM CrDrMaster where Prefix = '" & RecPrefix & "'")

    '    SeedVar += myreader(0)

    '    For i As Integer = myreader(0) + 1 To 8000000

    '        SeedVar += 1

    '        AccountNoVar = RecPrefix & SeedVar

    '        SerTemp("select * from CrDrMaster where AccountNo = '" & AccountNoVar & "'")

    '        If TempReader.HasRows = False Then

    '            i = 8000001

    '        End If

    '    Next

    '    search("select * from master")

    '    Do

    '        operation("INSERT INTO [CrDrMaster] ([AccountNo],[DescripName],[LocID],[date_birth],[sex],[pat_id]) VALUES ('" &
    '                                                             AccountNoVar & "' , '" &
    '                                                             myreader(1) & "' , " &
    '                                                             myreader(2) & " , '" &
    '                                                             myreader(3) & "' , '" &
    '                                                             myreader(4) & "' , '" &
    '                                                             myreader(0) & "')")



    '        SeedVar += 1

    '        AccountNoVar = RecPrefix & SeedVar


    '    Loop Until myreader.Read = False

    'End Sub

End Class