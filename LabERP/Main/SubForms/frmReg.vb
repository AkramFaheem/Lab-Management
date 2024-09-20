Public Class FrmReg

    Public AccIDVar As Integer
    Public AccIDType As Integer

    Public UserFullName As String
    Public SafAcccVar As String
    Public DisAccVar As String


    Public TestID As Integer = 0
    Public RootID As Integer = 0
    Public LevelID As Integer = 0
    Public PCinCNT As Integer

    Public RowNo As Integer

    Public MonthVar As Integer
    Public YearVar As Integer

    Public labNoVar As Integer = 0
    Public TransIDTemp As String = Nothing

    Public FrqTotalVar As Integer = 0

    Public TransID As String

    Public AccountNoVar As String
    Public ExpAccNoVar As String

    Public PayeeID As Object
    Public PayeeName As Object

    Public ValueIDVar As Object
    Public ValueNameVar As Object

    Public scItemNamesAutoComplete As New AutoCompleteStringCollection
    Public scItemFamilyAutoComplete As New AutoCompleteStringCollection
    Public scItemSubFamilyAutoComplete As New AutoCompleteStringCollection


    Private Sub ToolTipTexts()

        'If btExpand.Tag = 0 Then

        '    ExpandToolTip.SetToolTip(Me.btExpand, "أضغط هنا لعرض التقرير بكامل الصفحة")

        'ElseIf btExpand.Tag = 1 Then

        '    ExpandToolTip.SetToolTip(Me.btExpand, "أضغط هنا لاستعادة قسم المعطيات والتقارير")

        'End If

    End Sub

    Public Sub AutoFill()

        Call AutoCompleteFill(scItemNamesAutoComplete, "CrDrMaster", "DescripName", 1, TXTPatientName)

    End Sub

    Public Sub GetRoutine()

        Dim x As Integer = 0

        dgvRegisteredRoutine.Rows.Clear()

        search("SELECT [TransID],[TransDate],[PayeeName],[AccountNo],[TestId],[ProfileName],[LabNo] FROM [TransactionsMaster] where [TransDate] = '" &
                                                     Now.Date & "' and [TransType] = 10 and [RecStatus] = 0")

        If myreader.HasRows = True Then


            Do

                dgvRegisteredRoutine.Rows.Add()

                dgvRegisteredRoutine.Rows(x).Cells(0).Value = myreader(0)
                dgvRegisteredRoutine.Rows(x).Cells(1).Value = myreader(2)
                dgvRegisteredRoutine.Rows(x).Cells(2).Value = myreader(5)
                dgvRegisteredRoutine.Rows(x).Cells(3).Value = myreader(6)

                dgvRegisteredRoutine.Rows(x).Cells(5).Value = myreader(4)

                x += 1

            Loop Until myreader.Read = False

            'LBLWNoR.Text = dgvWaitting.DisplayedRowCount(True)

        End If

    End Sub

    Public Sub ProfilesList()

        search("Select * from TestsMaster")

        If myreader.HasRows = True Then

            Dim x As Integer = 0

            dgvProfiles.Rows.Clear()

            Do

                dgvProfiles.Rows.Add()

                dgvProfiles.Rows(x).Cells(0).Value = myreader(0)
                dgvProfiles.Rows(x).Cells(1).Value = myreader(1)

                x += 1

            Loop Until myreader.Read = False
            LBLPNoR.Text = x.ToString
        End If

    End Sub

    Public Sub CLS()


        Dim frmStatusMessage As New frmStatus()

        frmStatusMessage.Show("Please Wait...!", MessageBoxIcon.Information)

        TestID = Nothing
        RootID = Nothing
        LevelID = Nothing
        PCinCNT = Nothing

        TXTPatientName.Text = ""
        TXTconsultant.Text = ""

        TXTFilter.Text = Nothing

        AccountNoVar = Nothing
        PayeeID = Nothing
        PayeeName = Nothing
        FrqTotalVar = 0

        TransIDTemp = Nothing

        dgvSelectedProfile.Rows.Clear()
        dgvSelectedTest.Rows.Clear()

        scItemNamesAutoComplete.Clear()

        Call AutoFill()

        operation("Delete From TransactionTempCounters where UserID = " & AccIDVar & "")

        Call GetRoutine()

        'ChkAllItems.Checked = False

        frmStatusMessage.Close()

    End Sub

    Public Sub CreateDGV()

        dgvProfiles.Columns.Clear()

        Call dgvCreate(dgvProfiles, 1, 130, "No", False)
        Call dgvCreate(dgvProfiles, 1, 0, "Name", True)
        Call dgvCreate(dgvProfiles, 4, 70, "Select", True)
        Call dgvCreate(dgvProfiles, 4, 20, "?", True)

        dgvSelectedProfile.Columns.Clear()

        Call dgvCreate(dgvSelectedProfile, 1, 130, "No", False)
        Call dgvCreate(dgvSelectedProfile, 1, 0, "Name", True)
        Call dgvCreate(dgvSelectedProfile, 1, 100, "Lab No", False)
        Call dgvCreate(dgvSelectedProfile, 4, 80, "Remove", True)
        Call dgvCreate(dgvSelectedProfile, 1, 130, "TestID", False)

        dgvSelectedTest.Columns.Clear()

        Call dgvCreate(dgvSelectedTest, 1, 130, "No", False)
        Call dgvCreate(dgvSelectedTest, 1, 0, "Name", True)
        Call dgvCreate(dgvSelectedTest, 4, 80, "Remove", False)
        Call dgvCreate(dgvSelectedTest, 1, 130, "TestID", False)
        Call dgvCreate(dgvSelectedTest, 1, 130, "Unit", False)
        Call dgvCreate(dgvSelectedTest, 1, 130, "NR", False)
        Call dgvCreate(dgvSelectedTest, 1, 130, "TransID", False)
        Call dgvCreate(dgvSelectedTest, 2, 60, "", True)

        dgvRegisteredRoutine.Columns.Clear()

        Call dgvCreate(dgvRegisteredRoutine, 1, 130, "TransID", False)
        Call dgvCreate(dgvRegisteredRoutine, 1, 0, "Name", True)
        Call dgvCreate(dgvRegisteredRoutine, 1, 160, "Profile", True)

        Call dgvCreate(dgvRegisteredRoutine, 1, 100, "Lab No", False)
        Call dgvCreate(dgvRegisteredRoutine, 4, 80, "Remove", True)
        Call dgvCreate(dgvRegisteredRoutine, 1, 130, "TestID", False)

    End Sub

    Private Sub FrmReg_Shown(sender As Object, e As EventArgs) Handles Me.Shown


    End Sub

    Private Sub TXTFilter_Click(sender As Object, e As EventArgs) Handles TXTFilter.Click
        TXTFilter.Text = Nothing
        TXTFilter.ForeColor = Color.Black
    End Sub

    Private Sub TXTRoutineFilter_Click(sender As Object, e As EventArgs) Handles TXTRoutineFilter.Click
        'TXTRoutineFilter.Text = Nothing
        'TXTRoutineFilter.ForeColor = Color.Black
    End Sub

    Private Sub TXTFilter_LostFocus(sender As Object, e As EventArgs) Handles TXTFilter.LostFocus
        'If TXTFilter.Text = Nothing Then
        '    TXTFilter.Text = "Filter by profile name"
        '    TXTFilter.ForeColor = Color.Gray
        'End If
    End Sub

    Private Sub TXTRoutineFilter_LostFocus(sender As Object, e As EventArgs) Handles TXTRoutineFilter.LostFocus
        'If TXTRoutineFilter.Text = Nothing Then
        '    TXTRoutineFilter.Text = "Filter by patient name"
        '    TXTRoutineFilter.ForeColor = Color.Gray
        'End If
    End Sub

    Private Sub TXTPatientName_Click(sender As Object, e As EventArgs) Handles TXTPatientName.Click

        If TXTPatientName.Text = "Type Patient Name ..." Then

            TXTPatientName.Text = Nothing

        End If

        TXTPatientName.ForeColor = Color.Black
    End Sub

    Private Sub TXTPatientName_LostFocus(sender As Object, e As EventArgs) Handles TXTPatientName.LostFocus
        If TXTPatientName.Text = Nothing Then
            TXTPatientName.Text = "Type Patient Name ..."
            TXTPatientName.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub DgvProfiles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProfiles.CellContentClick

        Dim Frm As New FrmMessageBox
        Dim Result As String

        Dim x As Integer = 0

        If dgvSelectedProfile.Rows.Count > 0 Then

            x = dgvSelectedProfile.Rows.Count

        End If

        If e.ColumnIndex = 3 Then

            If dgvProfiles.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                search("select * from TestValues where TestID = " & dgvProfiles.Rows(e.RowIndex).Cells(0).Value & "")

                If myreader.HasRows = True Then

                    Dim TempString As String = Nothing

                    Do

                        TempString += myreader(2) & vbCrLf

                    Loop Until myreader.Read = False

                    ExpandToolTip.SetToolTip(dgvProfiles, TempString)

                End If

            End If

            Exit Sub

        End If

        If e.ColumnIndex = 2 Then

            If dgvProfiles.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                Dim TestID As String = dgvProfiles.Rows(e.RowIndex).Cells(0).Value
                Dim y As Integer = 0


                For Each row As DataGridViewRow In dgvSelectedProfile.Rows

                    If dgvSelectedProfile.Rows(y).Cells(0).Value = TestID Then

                        Result = Frm.ShowMessage("Profile already Selected", "TMLCC", MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

                        Exit Sub

                    End If

                    y += 1

                Next

                SerTemp("select max(LabNo) as Last from TransactionTempCounters where UserID = " & AccIDVar & "")

                If Not IsDBNull(TempReader(0)) Then

                    labNoVar = TempReader(0) + 1

                    cmd.CommandText = "UPDATE [TransactionTempCounters] SET [LabNo] = " & labNoVar & " WHERE [UserID] =  '" & AccIDVar & "'"
                    GoTo FillCrid

                    Exit Sub

                Else

                    search("Select count([TransID]) FROM [TransactionsMaster] where TransDate = '" & Now.Date & "' and TransType = 10")

                    If Not IsDBNull(myreader(0)) Then

                        labNoVar = myreader(0) + 1

                        GoTo FillCrid

                    End If

                End If

            End If

        End If

FillCrid:

        operation("INSERT INTO [TransactionTempCounters] VALUES (" &
                                            labNoVar & " , " &
                                            dgvProfiles.Rows(e.RowIndex).Cells(0).Value & " , " &
                                            AccIDVar & ")")

        dgvSelectedProfile.Rows.Add()

        dgvSelectedProfile.Rows(x).Cells(0).Value = dgvProfiles.Rows(e.RowIndex).Cells(0).Value
        dgvSelectedProfile.Rows(x).Cells(1).Value = dgvProfiles.Rows(e.RowIndex).Cells(1).Value
        dgvSelectedProfile.Rows(x).Cells(2).Value = labNoVar
        dgvSelectedProfile.Rows(x).Cells(4).Value = dgvProfiles.Rows(e.RowIndex).Cells(0).Value

        search("select * from TestValues where TestID = " & dgvProfiles.Rows(e.RowIndex).Cells(0).Value & " order by Ordering")

        If myreader.HasRows = True Then

            x = dgvSelectedTest.Rows.Count

            Do

                dgvSelectedTest.Rows.Add()

                dgvSelectedTest.Rows(x).Cells(0).Value = myreader(0)
                dgvSelectedTest.Rows(x).Cells(1).Value = myreader(2)
                dgvSelectedTest.Rows(x).Cells(3).Value = dgvProfiles.Rows(e.RowIndex).Cells(0).Value

                If Not IsDBNull(myreader(3)) Then

                    dgvSelectedTest.Rows(x).Cells(4).Value = myreader(3).ToString

                Else

                    dgvSelectedTest.Rows(x).Cells(4).Value = "-"

                End If

                If Not IsDBNull(myreader(4)) Then

                    dgvSelectedTest.Rows(x).Cells(5).Value = myreader(4).ToString

                Else

                    dgvSelectedTest.Rows(x).Cells(5).Value = "-"

                End If

                x += 1

            Loop Until myreader.Read = False

        End If

    End Sub

    Private Sub DgvSelectedProfile_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSelectedProfile.CellContentClick

        Dim Frm As New FrmMessageBox
        Dim Result As String

        If e.ColumnIndex = 3 Then

            If dgvSelectedProfile.Rows(e.RowIndex).Cells(0).Value <> Nothing Then


                Result = Frm.ShowMessage("Profile already Selected", "TMLCC", MessageBoxIcon.Information, MessageBoxButtons.YesNo, Frm)

                If Result = "No" Then

                    Exit Sub

                End If

                Dim y As Integer

                For y = dgvSelectedTest.Rows.Count - 1 To 0 Step -1

                    If dgvSelectedTest.Rows(y).Cells(3).Value = dgvSelectedProfile.Rows(e.RowIndex).Cells(0).Value Then

                        dgvSelectedTest.Rows.RemoveAt(y)

                    End If

                Next

                If dgvSelectedProfile.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                    operation("Delete From TransactionTempCounters where LabNo = " &
                                         dgvSelectedProfile.Rows(e.RowIndex).Cells(2).Value & " and TestID = " &
                                         dgvSelectedProfile.Rows(e.RowIndex).Cells(4).Value & "  and UserID = " &
                                         AccIDVar & "")

                    dgvSelectedProfile.Rows.RemoveAt(e.RowIndex)

                End If

            End If

        End If

    End Sub

    Private Sub TXTFilter_TextChanged(sender As Object, e As EventArgs) Handles TXTFilter.TextChanged

        Dim x As Integer = 0

        Try

            If TXTFilter.Text <> Nothing Then

                search("SELECT * FROM [TestsMaster] where [TestName] like '" & TXTFilter.Text & "%'")

                If myreader.HasRows = True Then

                    dgvProfiles.Rows.Clear()

                    Do

                        dgvProfiles.Rows.Add()

                        dgvProfiles.Rows(x).Cells(0).Value = myreader(0)
                        dgvProfiles.Rows(x).Cells(1).Value = myreader(1)

                        x += 1

                    Loop Until myreader.Read = False
                    LBLPNoR.Text = x.ToString
                End If

            End If

            If TXTFilter.Text = Nothing Then

                search("SELECT * FROM [TestsMaster]")

                If myreader.HasRows = True Then

                    x = 0

                    dgvProfiles.Rows.Clear()

                    Do

                        dgvProfiles.Rows.Add()

                        dgvProfiles.Rows(x).Cells(0).Value = myreader(0)
                        dgvProfiles.Rows(x).Cells(1).Value = myreader(1)

                        x += 1

                    Loop Until myreader.Read = False

                    LBLPNoR.Text = x.ToString

                End If

            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub TXTPatientName_TextChanged(sender As Object, e As EventArgs) Handles TXTPatientName.TextChanged


    End Sub

    Private Sub TXTPatientName_Leave(sender As Object, e As EventArgs) Handles TXTPatientName.Leave

        If TXTPatientName.Text = "" Or TXTPatientName.Text = "Type Patient Name ..." Then

            Exit Sub

        End If

        search("SELECT * FROM CrDrMaster where DescripName = '" & TXTPatientName.Text & "'")

        If myreader.HasRows = True Then

            AccountNoVar = myreader(0)
            PayeeID = myreader(0)
            TXTPatientName.Text = myreader(1)

            FrqTotalVar = myreader(12)

        ElseIf myreader.HasRows = False Then

            AccountNoVar = Nothing
            PayeeID = Nothing

            frmPateintProfile.AccountNoVar = Nothing
            frmPateintProfile.PayeeID = Nothing
            frmPateintProfile.txtPayeeName.Text = TXTPatientName.Text
            frmPateintProfile.AccIDVar = AccIDVar
            frmPateintProfile.FromVar = 1

            frmPateintProfile.ShowDialog()

        End If

    End Sub

    Private Sub BtPatientUpdate_Click(sender As Object, e As EventArgs) Handles btPatientUpdate.Click

        Dim x As Integer = 0
        Dim Frm As New FrmMessageBox
        Dim Result As String

        If TXTPatientName.Text = "" Then

            Exit Sub

        End If

        search("SELECT * FROM CrDrMaster where DescripName = '" & TXTPatientName.Text & "'")

        If myreader.HasRows = True Then

            AccountNoVar = myreader(0)
            PayeeID = myreader(0)
            PayeeName = myreader(1)

            Result = Frm.ShowMessage("Do You Want To Update This Patient Record?", "TMLCC",
                                MessageBoxIcon.Information, MessageBoxButtons.YesNo, Frm)

            If Result = "No" Then

                Exit Sub

            End If

            If Result = "Yes" Then

                frmPateintProfile.AccountNoVar = AccountNoVar
                frmPateintProfile.PayeeID = PayeeID
                frmPateintProfile.PayName = PayeeName

                frmPateintProfile.txtPayeeName.Text = PayeeName
                frmPateintProfile.txtCellPhone.Text = myreader(2)
                frmPateintProfile.LocIDVar = myreader(11)
                frmPateintProfile.cbAreas.SelectedValue = myreader(11)
                frmPateintProfile.CMBAge.Text = myreader(13)
                frmPateintProfile.CMBGender.Text = myreader(14)

                frmPateintProfile.AccIDVar = AccIDVar
                frmPateintProfile.FromVar = 1

                frmPateintProfile.ShowDialog()

            End If

        End If

    End Sub

    Private Sub DgvSelectedTest_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSelectedTest.CellContentClick

        Dim Frm As New FrmMessageBox
        Dim Result As String

        If e.ColumnIndex = 2 Then

            If dgvSelectedTest.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                'Result = Frm.ShowMessage("Remove This Test?", "TMLCC", MessageBoxIcon.Information, MessageBoxButtons.YesNo, Frm)

                'If Result = "No" Then

                '    Exit Sub

                'End If

                dgvSelectedTest.Rows.RemoveAt(e.RowIndex)

            End If

        End If

    End Sub

    Private Sub BtHide_Click(sender As Object, e As EventArgs) Handles btHide.Click

        If SecondSplit.Panel1Collapsed = True Then

            btHide.Text = "<"

            SecondSplit.Panel1Collapsed = False

        ElseIf SecondSplit.Panel1Collapsed = False Then

            btHide.Text = ">"

            SecondSplit.Panel1Collapsed = True

        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim Frm As New FrmMessageBox
        Dim Result As String

        Dim YearPart As String = Now.ToString("yy")
        Dim MonthPart As String = Now.ToString("MM")

        If (dgvSelectedProfile.Rows.Count = 0) Then
            Exit Sub
        End If

        If dgvSelectedProfile.Rows(0).Cells(0).Value <> 2 Then

            If dgvSelectedTest.Rows.Count = 0 Then

                Exit Sub

            End If

        End If

        If TXTPatientName.Text = "" Or AccountNoVar = Nothing Then

            Result = Frm.ShowMessage("Please Type Patient Name.? ", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.OK, Frm)

            Exit Sub

        End If

        If TXTconsultant.Text = "" Then

            TXTconsultant.Text = "N/A"

        End If

        YearVar = Now.Year
        MonthVar = Now.Month

        FrqTotalVar += 1

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try

            Call ShowProgress("Registering Transations", MessageDirection.Right, 2000)

#Region "Registering"

            Dim x As Integer = 0

            For Each row As DataGridViewRow In dgvSelectedProfile.Rows

                If dgvSelectedProfile.Rows(x).Cells(0).Value <> Nothing Then


                    cmd.CommandText = "INSERT INTO [TransactionsMaster] ([TransDate],[YearID],[MonthID],[TransType],[Prefix],[PayeeName],[UserID],[frq]," &
                                                            "[AccountNo],[TestId],[ProfileName],[LabNo],[consultant]) VALUES ('" &
                                                                            Now.Date & "' , " &
                                                                            YearVar & " , " & MonthVar & " , 10 , 'Case' , '" &
                                                                            TXTPatientName.Text & "' , " &
                                                                            AccIDVar & " , " &
                                                                            FrqTotalVar & " , '" &
                                                                            AccountNoVar & "' , " &
                                                                            dgvSelectedProfile.Rows(x).Cells(0).Value & " , '" &
                                                                            dgvSelectedProfile.Rows(x).Cells(1).Value & "'  , " &
                                                                            dgvSelectedProfile.Rows(x).Cells(2).Value & " , '" &
                                                                            TXTconsultant.Text & "')"
                    cmd.ExecuteNonQuery()

                    TransIDTemp = Nothing

                    cmd.CommandText = "select TransID from TransactionsMaster where TransDate = '" &
                                                                 Now.Date & "' and AccountNo = '" &
                                                                 AccountNoVar & "' and TransType = 10 and TestId =  " &
                                                                 dgvSelectedProfile.Rows(x).Cells(0).Value & " and LabNo =  " &
                                                                 dgvSelectedProfile.Rows(x).Cells(2).Value & ""

                    myreader = cmd.ExecuteReader()

                    myreader.Read()

                    If myreader.HasRows = True Then

                        TransIDTemp = myreader(0)

                    End If

                    myreader.Close()

                    Dim y As Integer = 0

                    For Each TempRow As DataGridViewRow In dgvSelectedTest.Rows

                        If dgvSelectedTest.Rows(y).Cells(3).Value = dgvSelectedProfile.Rows(x).Cells(0).Value Then

                            dgvSelectedTest.Rows(y).Cells(6).Value = TransIDTemp

                        End If

                        y += 1

                    Next

                    cmd.CommandText = "Delete From TransactionTempCounters where LabNo = " &
                                             dgvSelectedProfile.Rows(x).Cells(2).Value & " and UserID = " &
                                             AccIDVar & ""
                    cmd.ExecuteNonQuery()

                    x += 1

                Else

                    x += 1


                End If

            Next

            x = 0

            For Each row As DataGridViewRow In dgvSelectedTest.Rows

                If dgvSelectedTest.Rows(x).Cells(7).Value = True Then

                    If dgvSelectedTest.Rows(x).Cells(0).Value <> Nothing Then

                        cmd.CommandText = "INSERT INTO [TransactionsDetails] ([TransID],[TestId],[ValueId],[TransDate],[TestName],[Unit],[NormalRange],[OrderDetails]) VALUES (" &
                                                                               dgvSelectedTest.Rows(x).Cells(6).Value & " , " &
                                                                               dgvSelectedTest.Rows(x).Cells(3).Value & " , " &
                                                                               dgvSelectedTest.Rows(x).Cells(0).Value & " , '" &
                                                                               Now.Date & "' , '" &
                                                                               dgvSelectedTest.Rows(x).Cells(1).Value & "' , '" &
                                                                               dgvSelectedTest.Rows(x).Cells(4).Value.ToString & "' , '" &
                                                                               dgvSelectedTest.Rows(x).Cells(5).Value.ToString & "' , " & x & " )"
                        cmd.ExecuteNonQuery()

                    End If

                    x += 1

                Else

                    x += 1

                End If

            Next

            cmd.CommandText = "UPDATE [CrDrMaster] SET [TotalFreq] = " & FrqTotalVar & " WHERE [AccountNo] =  '" & AccountNoVar & "'"

            cmd.ExecuteNonQuery()

#End Region

            TransOne.Commit()

            Call CLS()

        Catch ex As Exception

            Dim FrmError As New FrmMessageBox
            Dim ResultError

            ResultError = FrmError.ShowMessage("Please Check Data", "TMLCC",
                   MessageBoxIcon.Information, MessageBoxButtons.OK, FrmError)

            TransOne.Rollback()

        Finally

            conn.Close()

        End Try



    End Sub

    Private Sub DgvRegisteredRoutine_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegisteredRoutine.CellContentClick


        Dim frmAsk As New FrmMessageBox
        Dim ResultAsk As String

        If e.ColumnIndex = 4 Then

            ResultAsk = frmAsk.ShowMessage("Are You Sure ...?", "TMLCC",
                                      MessageBoxIcon.Information, MessageBoxButtons.YesNo, frmAsk)

            If ResultAsk = "Yes" Then

                If dgvRegisteredRoutine.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                    Call ShowProgress("Deleting Transation", MessageDirection.Right, 2000)

                    operation("Delete from TransactionsMaster where TransID = '" & dgvRegisteredRoutine.Rows(e.RowIndex).Cells(0).Value & "'")

                    operation("Delete from TransactionsDetails where TransID = '" & dgvRegisteredRoutine.Rows(e.RowIndex).Cells(0).Value & "'")

                    Call CLS()

                End If

            End If

        End If

    End Sub

    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click

        Call CLS()

    End Sub

    Private Sub FrmReg_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated


        Call CreateDGV()
        Call AutoFill()

        TXTFilter.Text = "Filter by profile name"
        TXTFilter.ForeColor = Color.Gray
        TXTPatientName.Text = "Type Patient Name ..."
        TXTPatientName.ForeColor = Color.Gray

        Call ProfilesList()
        Call GetRoutine()

    End Sub

    Private Sub dgvProfiles_MouseMove(sender As Object, e As MouseEventArgs) Handles dgvProfiles.MouseMove


    End Sub

    Private Sub dgvProfiles_MouseHover(sender As Object, e As EventArgs) Handles dgvProfiles.MouseHover


    End Sub

    Private Sub TXTRoutineFilter_TextChanged(sender As Object, e As EventArgs) Handles TXTRoutineFilter.TextChanged

        Dim x As Integer = 0

        If TXTRoutineFilter.Text <> Nothing Then

            search("SELECT [TransID],[TransDate],[PayeeName],[AccountNo],[TestId],[ProfileName],[LabNo] FROM [TransactionsMaster] where [PayeeName] like '" &
                                                                                                     TXTRoutineFilter.Text & "%' and  [TransDate] = '" &
                                                                                                     Now.Date & "' and [TransType] = 10 and [RecStatus] = 0")

            If myreader.HasRows = True Then

                dgvRegisteredRoutine.Rows.Clear()

                Do

                    dgvRegisteredRoutine.Rows.Add()

                    dgvRegisteredRoutine.Rows(x).Cells(0).Value = myreader(0)
                    dgvRegisteredRoutine.Rows(x).Cells(1).Value = myreader(2)
                    dgvRegisteredRoutine.Rows(x).Cells(2).Value = myreader(5)
                    dgvRegisteredRoutine.Rows(x).Cells(3).Value = myreader(6)

                    dgvRegisteredRoutine.Rows(x).Cells(5).Value = myreader(4)

                    x += 1

                Loop Until myreader.Read = False

            End If

        End If

        If TXTRoutineFilter.Text = Nothing Then

            Call GetRoutine()

        End If

    End Sub

    Private Sub ChkAllItems_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAllItems.CheckedChanged

        Dim Frm As New FrmMessageBox
        Dim Result As String
        Dim x As Integer = 0

        If dgvSelectedTest.Rows.Count < 1 Then

            Result = Frm.ShowMessage("No Tests To Select", "TLMCC",
                                   MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

            Exit Sub

        End If

        If ChkAllItems.Checked = True Then

            For Each row As DataGridViewRow In dgvSelectedTest.Rows

                dgvSelectedTest.Rows(x).Cells(7).Value = True

                x += 1

            Next

        End If

        If ChkAllItems.Checked = False Then

            For Each row As DataGridViewRow In dgvSelectedTest.Rows

                dgvSelectedTest.Rows(x).Cells(7).Value = False

                x += 1

            Next

        End If

    End Sub

    Private Sub FrmReg_MaximizedBoundsChanged(sender As Object, e As EventArgs) Handles Me.MaximizedBoundsChanged

    End Sub
End Class
