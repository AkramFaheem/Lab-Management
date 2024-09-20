Public Class UCNewEmp

    Public AccountNoVar As String
    Public TransType As Integer
    Public AccIDVar As Integer

    Public CoIDVar As Integer

    Public Sub LLNewEmp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkTransaction.LinkClicked

        Call frmProfilesSetup.Clear()

        SerTemp("SELECT * FROM [TestsMaster] where [TestId] = " & TransType & "")

        frmProfilesSetup.TestID = TransType
        frmProfilesSetup.txtProfile.Text = TempReader(1) + " "

        frmProfilesSetup.lblProfileTests.Text = TempReader(1) & " Tests"

        frmProfilesSetup.TestsTree.Nodes.Clear()

        'Call DISPLAYTREEVIEW(0, Nothing, frmProfilesSetup.TestsTree, "TestValues", 1, "RootID", TransType)

        search("Select * From TestValues where TestId = " & TransType & " order by Ordering")

        If myreader.HasRows = True Then

            Dim x As Integer = 0
            Dim TempText As TreeNode

            frmProfilesSetup.TestID = TransType

            Do

                TempText = frmProfilesSetup.TestsTree.Nodes.Add(myreader(2))

            Loop Until myreader.Read = False


        End If

        frmProfilesSetup.TestsTree.ExpandAll()

        If frmProfilesSetup.MainSplit.Panel2Collapsed = True Then

            frmProfilesSetup.BtHide_Click(sender, e)

        End If

    End Sub

    Private Sub LLEmpName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        'frmPRDashBoard.WindowState = FormWindowState.Minimized

        'Call FrmEmploye.Retrive(AccountNoVar)

        ''FrmEmploye.BringToFront()
        'FrmEmploye.Show()

        'FrmEmploye.BTSave.Enabled = False

        'FrmEmploye.BTUpdate.Enabled = True
        'FrmEmploye.BTDelete.Enabled = True

    End Sub

    Private Sub UCNewEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SerTemp("SELECT * FROM [TestsMaster] where [TestId] = '" & TransType & "'")

        If TempReader.HasRows = True Then

            LinkTransaction.Text = TempReader(1)

            Dim bytImage() As Byte

            Try

                bytImage = CType(TempReader(2), Byte())
                Dim ms As New System.IO.MemoryStream(bytImage)
                Dim bmImage As New Bitmap(ms)
                ms.Close()

                PBEmp.BackgroundImage = bmImage

                'Me.pbEmp.Image = bmImage
                'Me.pbEmp.Refresh()


            Catch ex As Exception

                PBEmp.BackgroundImage = Nothing
                'MsgBox(ex.ToString)

            End Try

        End If



    End Sub

    Private Sub UCNewEmp_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick


    End Sub

    Private Sub PBEmp_Click(sender As Object, e As EventArgs) Handles PBEmp.Click

    End Sub


End Class
