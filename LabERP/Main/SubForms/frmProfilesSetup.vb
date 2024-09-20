
Public Class frmProfilesSetup

    Public AccIDVar As Integer
    Public AccIDType As Integer

    Public UserFullName As String
    Public SafAcccVar As String
    Public DisAccVar As String


    Public TestID As Integer = 0
    Public ValueID As Integer = 0
    Public LevelID As Integer = 0
    Public PCinCNT As Integer

    Public ValueIDVar As Object
    Public ValueNameVar As Object
    Public RecStatus As Object

    Public scItemNamesAutoComplete As New AutoCompleteStringCollection
    Public scItemFamilyAutoComplete As New AutoCompleteStringCollection
    Public scItemSubFamilyAutoComplete As New AutoCompleteStringCollection

    Public Sub AutoFill()

        Call AutoCompleteFill(scItemNamesAutoComplete, "TestValues", "ValueName", 1, txtValue)

    End Sub

    Public Sub GetItem(ByVal _TestId As Integer, ByVal _ValueID As Integer)

        search("Select * from ProfilesTestsView where TestID = " & _TestId & " and ValueID = " & _ValueID & "")

        If myreader.HasRows = True Then

            TestID = myreader(0)
            ValueIDVar = myreader(2)
            txtValue.Text = myreader(3).ToString
            txtUnit.Text = myreader(4)

            txtNR.Text = myreader(5).ToString
            RecStatus = myreader(7)
            btSave.Enabled = False

            btUpdate.Enabled = True
            btDelete.Enabled = True


        End If

    End Sub

    Public Sub CLS()

        TestID = Nothing
        ValueID = Nothing
        LevelID = Nothing
        PCinCNT = Nothing

        Call CreateDGV()

        Call GetItemsFamily()

        TestsTree.Nodes.Clear()
        txtProfile.Text = ""
        txtValue.Text = ""
        txtUnit.Text = ""

        txtNR.Text = ""

        lblProfileTests.Text = ""

        btSave.Enabled = True

        btUpdate.Enabled = False
        btDelete.Enabled = False

    End Sub
    Public Sub Clear()

        TestID = Nothing
        ValueID = Nothing
        LevelID = Nothing
        PCinCNT = Nothing
        txtProfile.Text = ""
        txtValue.Text = ""
        txtUnit.Text = ""

        txtNR.Text = ""

        lblProfileTests.Text = ""

        btSave.Enabled = True

        btUpdate.Enabled = False
        btDelete.Enabled = False

    End Sub

    Public Sub GetItemsFamily()

        search("SELECT [TestId],[TestName] FROM [TestsMaster] order by TestName ASC ")

        If myreader.HasRows = True Then

            Do

                Try
                    FLP01.Controls.Clear()

                    Do

                        Dim NewEmp As New UCNewEmp

                        NewEmp.TransType = myreader(0)
                        NewEmp.AccIDVar = AccIDVar

                        FLP01.Controls.Add(NewEmp)

                    Loop Until myreader.Read = False

                Catch ex As Exception


                End Try

            Loop Until myreader.Read = False

        End If
    End Sub

    Public Sub CreateDGV()

        'dgvItemsList.Columns.Clear()

        'Call dgvCreate(dgvItemsList, 1, 130, "No", False)
        'Call dgvCreate(dgvItemsList, 1, 100, "Code", False)
        'Call dgvCreate(dgvItemsList, 1, 0, "Name", True)
        'Call dgvCreate(dgvItemsList, 4, 80, "Details", True)

        'dgvStores.Columns.Clear()

        'Call dgvCreate(dgvStores, 1, 130, "No", False)
        'Call dgvCreate(dgvStores, 1, 0, "Name", True)
        'Call dgvCreate(dgvStores, 1, 150, "Qty", True)


    End Sub

    Private Sub frmItemSetup_Shown(sender As Object, e As EventArgs) Handles Me.Shown


        Call CreateDGV()

        Call AutoFill()

        Call GetItemsFamily()

    End Sub

    Private Sub BtSetup_Click(sender As Object, e As EventArgs) Handles btSetup.Click

        frmProfileSetup.AccIDVar = AccIDVar
        frmProfileSetup.ShowDialog()

    End Sub

    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click

        Call CLS()

    End Sub

    Private Sub ItemsTree_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TestsTree.AfterSelect

        Dim TempDisplay As String = txtProfile.Text

        LevelID = TestsTree.SelectedNode.Level

        If LevelID = 0 Then

            search("select * from TestValues where ValueName = '" & TestsTree.SelectedNode.Text & "' and TestID = " & TestID & "")

            If myreader.HasRows = True Then

                ValueID = myreader(0)

                Call GetItem(TestID, ValueID)

            End If

        Else

        End If

    End Sub

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click

        Dim Frm As New FrmMessageBox
        Dim Result As String

        If txtProfile.Text = Nothing Or txtValue.Text = Nothing Then

            Result = Frm.ShowMessage("Profile or Value name field cannot be empty ", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.OK, Frm)

            Exit Sub

        End If


        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try

            Call ShowProgress("Saving  Values", MessageDirection.Right, 2000)

#Region "Saving Data Entered"

            cmd.CommandText = "UPDATE [TestValues] SET [TestID] = " &
                                             TestID & " , [ValueName] ='" &
                                             txtValue.Text & "' , [Unit] = '" &
                                             txtUnit.Text & "', [NormalRange] = '" &
                                             txtNR.Text & "'  WHERE [ValueId] = " &
                                             ValueID & ""
            cmd.ExecuteNonQuery()



#End Region

            TransOne.Commit()

            '******************** 
            Dim FrmCHK As New FrmMessageBox
            Dim ResultCHK As String

            ResultCHK = FrmCHK.ShowMessage("Do You Want To update Another Test", "TMLCC",
                            MessageBoxIcon.Exclamation, MessageBoxButtons.YesNo, FrmCHK)

            If ResultCHK = "Yes" Then

                txtValue.Text = ""
                txtNR.Text = ""
                txtUnit.Text = ""

                txtValue.Focus()

                search("Select * From TestValues where TestId = " & TestID & " order by Ordering")

                If myreader.HasRows = True Then

                    Dim x As Integer = 0
                    Dim TempText As TreeNode
                    TestsTree.Nodes.Clear()
                    'TestID = frmProfileSetup.TransType
                    TestID = myreader(1)

                    Do

                        TempText = TestsTree.Nodes.Add(myreader(2))

                    Loop Until myreader.Read = False


                End If

                TestsTree.ExpandAll()


            End If

            If ResultCHK = "No" Then

                Call CLS()

            End If


            '********************


            'Call CLS()

        Catch ex As Exception

            Dim FrmError As New FrmMessageBox
            Dim ResultError

            ResultError = FrmError.ShowMessage(ex.Message, "TMLCC",
                   MessageBoxIcon.Information, MessageBoxButtons.OK, FrmError)

            TransOne.Rollback()

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click

        Dim Frm As New FrmMessageBox
        Dim Result As String


        If txtProfile.Text = Nothing Or TestID = Nothing Then

            Result = Frm.ShowMessage("Please select profile! ", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.OK, Frm)

            Exit Sub

        End If

        If txtValue.Text = Nothing Then

            Result = Frm.ShowMessage("Value name Field is required ", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.OK, Frm)
            txtValue.Focus()

            Exit Sub

        End If

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try

            Call ShowProgress("Registering Transations", MessageDirection.Right, 2000)

            cmd.CommandText = "INSERT INTO [TestValues] ([TestID],[ValueName],[Unit],[NormalRange]) VALUES (" &
                                                                      TestID & " , '" &
                                                                      txtValue.Text & "' , '" &
                                                                      txtUnit.Text & "' , '" &
                                                                      txtNR.Text & "')"
            cmd.ExecuteNonQuery()

            TransOne.Commit()

            Dim FrmCHK As New FrmMessageBox
            Dim ResultCHK As String

            ResultCHK = FrmCHK.ShowMessage("Do You Want To Add Another Test", "TMLCC",
                            MessageBoxIcon.Exclamation, MessageBoxButtons.YesNo, FrmCHK)

            If ResultCHK = "Yes" Then

                txtValue.Text = ""
                txtNR.Text = ""
                txtUnit.Text = ""

                txtValue.Focus()

            End If

            If ResultCHK = "No" Then

                Call CLS()

            End If

        Catch ex As Exception

            Dim FrmError As New FrmMessageBox
            Dim ResultError

            ResultError = FrmError.ShowMessage(ex.Message, "TMLCC",
               MessageBoxIcon.Information, MessageBoxButtons.OK, FrmError)

            TransOne.Rollback()

        Finally

            conn.Close()

        End Try
    End Sub

    Private Sub LLPrintProfileList_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLPrintProfileList.LinkClicked

        Dim Rpt As New ProfileList
        GETSERVERNAMEANDDATABASENAME(Rpt, "LabERPDB")
        FrmReport.CRView.ReportSource = Rpt
        FrmReport.CRView.Zoom(1)
        FrmReport.CRView.RefreshReport()
        FrmReport.Show()

    End Sub

    Private Sub BtDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click


        Dim Frm As New FrmMessageBox
        Dim Result As String

        If txtProfile.Text = Nothing Then

            Result = Frm.ShowMessage("Please select profile test? ", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.OK, Frm)

            Exit Sub

        End If

        Result = Frm.ShowMessage("Are You Sure? ", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.YesNo, Frm)

        If Result = "No" Then

            Exit Sub

        End If

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try

            Call ShowProgress("Deleting", MessageDirection.Right, 2000)

#Region "Delete Data"

            cmd.CommandText = "Delete From [TestValues] WHERE [ValueId] = " & ValueID & " and [TestID] = " & TestID & " "

            cmd.ExecuteNonQuery()



#End Region

            TransOne.Commit()

            Call CLS()

        Catch ex As Exception

            Dim FrmError As New FrmMessageBox
            Dim ResultError

            ResultError = FrmError.ShowMessage(ex.Message, "TMLCC",
                   MessageBoxIcon.Information, MessageBoxButtons.OK, FrmError)

            TransOne.Rollback()

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub FLP01_Paint(sender As Object, e As PaintEventArgs) Handles FLP01.Paint

    End Sub

    Private Sub frmProfilesSetup_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated



    End Sub

    Public Sub BtHide_Click(sender As Object, e As EventArgs) Handles btHide.Click



        If MainSplit.Panel2Collapsed = True Then

            btHide.Text = "<"

            MainSplit.Panel2Collapsed = False

        ElseIf MainSplit.Panel2Collapsed = False Then

            btHide.Text = ">"

            MainSplit.Panel2Collapsed = True

        End If

    End Sub


End Class