Imports i00SpellCheck
Public Class frmResultes

    Public AccIDVar As Integer
    Public AccIDType As Integer

    Public UserFullName As String
    Public SafAcccVar As String
    Public DisAccVar As String


    Public TestID As Integer = 0
    Public RootID As Integer = 0
    Public LevelID As Integer = 0
    Public PCinCNT As Integer
    Public ChkTestID As Integer = 0

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
    Public scItemValuesAutoComplete As New AutoCompleteStringCollection
    Public scItemSubFamilyAutoComplete As New AutoCompleteStringCollection
    Public ISIValue As Decimal = 0
    '**********Adding cancer registery combo box in result form
    Private Sub ComboFill()

        Call FillCombo(cbCancer, "BasCancers", "InternationalCode", "CanRegID", 1, 1, "TestId", 1)

    End Sub

    Public Sub AutoFill()

        Call AutoCompleteFill(scItemNamesAutoComplete, "CrDrMaster", "DescripName", 1, TXTPatientName)
        Call AutoCompleteFill(scItemValuesAutoComplete, "BasValueOptions", "ValueOptions", 0)

    End Sub

    Public Sub CLS()

        Dim frmStatusMessage As New frmStatus()

        frmStatusMessage.Show("Please Wait...!", MessageBoxIcon.Information)

        TestID = Nothing
        RootID = Nothing
        LevelID = Nothing
        PCinCNT = Nothing

        TXTPatientName.Text = ""
        TXTclinicalinfo.Text = ""
        TXTconsultant.Text = ""
        txtLabNo.Text = ""
        txtNote.Text = ""

        LBLWNoR.Text = ""
        LBLHRNo.Text = ""
        LBLPRNo.Text = ""
        cbCancer.Text = Nothing
        '*****hide haematolgy canreg lable and combobox 
        lblcanreg.Visible = False
        cbCancer.Visible = False
        '******************************************
        frmHistoComplate.txtReport.Text = ""
        frmHistoComplate.txtRequest.Text = ""
        frmHistoComplate.cbCancer.SelectedValue = 100

        frmCulture.FillChkLists(1)

        AccountNoVar = Nothing
        PayeeID = Nothing
        PayeeName = Nothing
        FrqTotalVar = 0

        TransIDTemp = Nothing
        ChkTestID = 0

        dgvWaitting.Rows.Clear()
        dgvRequestedTests.Rows.Clear()
        dgvHistory.Rows.Clear()
        dgvPrintRoutine.Rows.Clear()

        Call GetRoutine()
        Call GetPrintList()
        Call AutoFill()

        frmStatusMessage.Close()

    End Sub

    Public Sub CreateDGV()

        dgvWaitting.Columns.Clear()

        Call dgvCreate(dgvWaitting, 1, 130, "No", False)
        Call dgvCreate(dgvWaitting, 1, 130, "Name", True)
        Call dgvCreate(dgvWaitting, 1, 0, "Profile", True)
        Call dgvCreate(dgvWaitting, 1, 80, "labNo", False)
        Call dgvCreate(dgvWaitting, 1, 0, "TransID", False)

        Call dgvCreate(dgvWaitting, 4, 60, "Select", True)
        Call dgvCreate(dgvWaitting, 4, 60, "Delete", True)

        dgvRequestedTests.Columns.Clear()

        Call dgvCreate(dgvRequestedTests, 1, 130, "No", False)
        Call dgvCreate(dgvRequestedTests, 1, 0, "Name", True)
        Call dgvCreate(dgvRequestedTests, 1, 130, "Value", True)
        Call dgvCreate(dgvRequestedTests, 1, 130, "TransID", False)
        Call dgvCreate(dgvRequestedTests, 1, 130, "TestID", False)

        dgvHistory.Columns.Clear()

        Call dgvCreate(dgvHistory, 3, 74, "Date", True)
        Call dgvCreate(dgvHistory, 1, 0, "No", False)
        Call dgvCreate(dgvHistory, 1, 0, "Profile", True)
        Call dgvCreate(dgvHistory, 1, 100, "TransID", False)
        Call dgvCreate(dgvHistory, 4, 50, "Upd", True)
        Call dgvCreate(dgvHistory, 4, 50, "Prev", True)
        Call dgvCreate(dgvHistory, 1, 0, "TestID", False)
        Call dgvCreate(dgvHistory, 4, 50, "Del", True)
        dgvPrintRoutine.Columns.Clear()

        Call dgvCreate(dgvPrintRoutine, 1, 130, "TransID", False)
        Call dgvCreate(dgvPrintRoutine, 1, 100, "LabNo", False)
        Call dgvCreate(dgvPrintRoutine, 1, 0, "Name", True)
        Call dgvCreate(dgvPrintRoutine, 1, 100, "Profile", True)
        Call dgvCreate(dgvPrintRoutine, 4, 50, "Get", True)
        Call dgvCreate(dgvPrintRoutine, 4, 50, "Prev", True)
        Call dgvCreate(dgvPrintRoutine, 1, 0, "TestID", False)
        Call dgvCreate(dgvPrintRoutine, 4, 50, "Del", True)

    End Sub

    Public Sub GetRoutine()

        Dim x As Integer = 0



        search("SELECT [TransID],[TransDate],[PayeeName],[AccountNo],[TestId],[ProfileName],[LabNo] FROM [TransactionsMaster] where [TransType] = 10 and [RecStatus] = 0")

        If myreader.HasRows = True Then

            dgvWaitting.Rows.Clear()

            Do

                dgvWaitting.Rows.Add()

                dgvWaitting.Rows(x).Cells(0).Value = myreader(4)
                dgvWaitting.Rows(x).Cells(1).Value = myreader(2)
                dgvWaitting.Rows(x).Cells(2).Value = myreader(5)
                dgvWaitting.Rows(x).Cells(3).Value = myreader(6)
                dgvWaitting.Rows(x).Cells(4).Value = myreader(0)

                x += 1

            Loop Until myreader.Read = False

            LBLWNoR.Text = x.ToString


        End If

    End Sub

    Public Sub GetPrintList()

        Dim x As Integer = 0

        search("SELECT [TransID],[TransDate],[PayeeName],[AccountNo],[TestId],[ProfileName],[LabNo] FROM [TransactionsMaster] where [TransType] = 10 and [RecStatus] = 1")

        If myreader.HasRows = True Then

            dgvPrintRoutine.Rows.Clear()

            Do

                dgvPrintRoutine.Rows.Add()

                dgvPrintRoutine.Rows(x).Cells(0).Value = myreader(0)
                dgvPrintRoutine.Rows(x).Cells(1).Value = myreader(6)
                dgvPrintRoutine.Rows(x).Cells(2).Value = myreader(2)
                dgvPrintRoutine.Rows(x).Cells(3).Value = myreader(5)
                dgvPrintRoutine.Rows(x).Cells(6).Value = myreader(4)

                x += 1

            Loop Until myreader.Read = False
            LBLPRNo.Text = x.ToString
        End If

    End Sub

    Public Sub GetHistory(ByVal _AccountNo As String)

        Dim Row As Integer = 0
        dgvHistory.Rows.Clear()

        SerTemp("SELECT [TransID],[TransDate],[PayeeName],[AccountNo],[TestId],[ProfileName],[LabNo] FROM [TransactionsMaster] where [AccountNo] = '" &
                                                            _AccountNo & "' and [TransType] = 10 And [RecStatus] = 2")

        If TempReader.HasRows = True Then

            AccountNoVar = _AccountNo


            Do

                dgvHistory.Rows.Add()

                dgvHistory.Rows(Row).Cells(0).Value = TempReader(1)
                dgvHistory.Rows(Row).Cells(1).Value = TempReader(6)
                dgvHistory.Rows(Row).Cells(2).Value = TempReader(5)
                dgvHistory.Rows(Row).Cells(3).Value = TempReader(0)
                dgvHistory.Rows(Row).Cells(6).Value = TempReader(4)

                Row += 1

            Loop Until TempReader.Read = False
            LBLHRNo.Text = Row.ToString
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
        Dim HistoReport As String = "N/A"
        Dim Request As String = "N/A"
        Dim CanReg As Integer = 100
        Dim LabNoTemp As String = "N/A"
        Dim RegDate As Date

        Dim x As Integer = 0

        SerTemp("Select ISIValue from ISIValue where IsActive = '" & True & "'")

        If TempReader.HasRows = True Then

            ISIValue = TempReader(0)

        End If

        If ChkTestID = 0 Then

            If ((dgvRequestedTests.Columns.Count = 0) Or (dgvRequestedTests.Rows.Count = 0)) Then
                Exit Sub
            End If

        End If

        If TXTPatientName.Text = "" Or AccountNoVar = Nothing Then

            Result = Frm.ShowMessage("Please Type Patient Name.? ", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.OK, Frm)

            Exit Sub

        End If

        search("select * From CrDrMaster where AccountNo = '" & AccountNoVar & "'")

        If myreader.HasRows = False Then

            Result = Frm.ShowMessage("Please Check Patient Profile.? ", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.OK, Frm)


            TXTPatientName.Focus()
            Exit Sub

        End If

        If myreader.HasRows = True Then

            If myreader(1) <> TXTPatientName.Text Then

                Result = Frm.ShowMessage("Please Check Patient Profile.? ", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.OK, Frm)
                TXTPatientName.Focus()

                Exit Sub

            End If

        End If

        If TXTclinicalinfo.Text = "" Then

            TXTclinicalinfo.Text = "N/A"

        End If

        If TXTconsultant.Text = "" Then

            TXTconsultant.Text = "N/A"

        End If

        If txtNote.Text = "" Then

            txtNote.Text = "N/A"

        End If

        Dim RBCTemp As Double = 0
        Dim HBTemp As Double = 0
        Dim HCTTemp As Double = 0

        If TestID = 1 Then

            x = 0

            For Each row As DataGridViewRow In dgvRequestedTests.Rows

                If dgvRequestedTests.Rows(x).Cells(0).Value = 2 Then

                    RBCTemp = dgvRequestedTests.Rows(x).Cells(2).Value

                End If

                If dgvRequestedTests.Rows(x).Cells(0).Value = 3 Then

                    HBTemp = dgvRequestedTests.Rows(x).Cells(2).Value

                End If

                If dgvRequestedTests.Rows(x).Cells(0).Value = 4 Then

                    HCTTemp = dgvRequestedTests.Rows(x).Cells(2).Value

                End If

                x += 1

            Next

            x = 0

            For Each row As DataGridViewRow In dgvRequestedTests.Rows

                If dgvRequestedTests.Rows(x).Cells(0).Value = 5 Then

                    dgvRequestedTests.Rows(x).Cells(2).Value = Math.Round(((HCTTemp / RBCTemp)) * 10, 1)

                End If


                If dgvRequestedTests.Rows(x).Cells(0).Value = 6 Then

                    dgvRequestedTests.Rows(x).Cells(2).Value = Math.Round(((HBTemp / RBCTemp)) * 10, 1)

                End If

                If dgvRequestedTests.Rows(x).Cells(0).Value = 7 Then

                    dgvRequestedTests.Rows(x).Cells(2).Value = Math.Round(((HBTemp / HCTTemp)) * 100, 1)

                End If

                If dgvRequestedTests.Rows(x).Cells(0).Value = 31 Then

                    dgvRequestedTests.Rows(x).Cells(2).Value = Math.Round((HBTemp * 6.8), 0)

                End If

                x += 1

            Next

            CanReg = cbCancer.SelectedValue

        End If

        Dim SerumIron As Double = 0
        Dim TotalIron As Double = 0

        If TestID = 11 Then

            x = 0

            For Each row As DataGridViewRow In dgvRequestedTests.Rows

                If dgvRequestedTests.Rows(x).Cells(0).Value = 227 Then

                    SerumIron = dgvRequestedTests.Rows(x).Cells(2).Value

                End If

                If dgvRequestedTests.Rows(x).Cells(0).Value = 228 Then

                    TotalIron = dgvRequestedTests.Rows(x).Cells(2).Value

                End If

                x += 1

            Next

            x = 0

            For Each row As DataGridViewRow In dgvRequestedTests.Rows

                If dgvRequestedTests.Rows(x).Cells(0).Value = 229 Then

                    dgvRequestedTests.Rows(x).Cells(2).Value = Math.Round(((SerumIron / TotalIron)) * 100, 1)

                End If

                x += 1

            Next

        End If

        Dim PTTime As Double = 0
        Dim PTControl As Double = 0

        Dim PTTTime As Double = 0
        Dim PTTControl As Double = 0

        If TestID = 20 Then

            x = 0

            For Each row As DataGridViewRow In dgvRequestedTests.Rows

                If dgvRequestedTests.Rows(x).Cells(0).Value = 175 Then

                    PTTime = dgvRequestedTests.Rows(x).Cells(2).Value

                End If

                If dgvRequestedTests.Rows(x).Cells(0).Value = 176 Then

                    PTControl = dgvRequestedTests.Rows(x).Cells(2).Value

                End If

                If dgvRequestedTests.Rows(x).Cells(0).Value = 179 Then

                    PTTTime = dgvRequestedTests.Rows(x).Cells(2).Value

                End If

                If dgvRequestedTests.Rows(x).Cells(0).Value = 180 Then

                    PTTControl = dgvRequestedTests.Rows(x).Cells(2).Value

                End If

                x += 1

            Next

            x = 0

            For Each row As DataGridViewRow In dgvRequestedTests.Rows

                If dgvRequestedTests.Rows(x).Cells(0).Value = 177 Then

                    dgvRequestedTests.Rows(x).Cells(2).Value = Math.Round(((PTTime / PTControl)), 2)

                End If


                If dgvRequestedTests.Rows(x).Cells(0).Value = 178 Then

                    dgvRequestedTests.Rows(x).Cells(2).Value = Math.Round(((PTTime / PTControl) ^ ISIValue), 2)

                End If

                If dgvRequestedTests.Rows(x).Cells(0).Value = 181 Then

                    dgvRequestedTests.Rows(x).Cells(2).Value = Math.Round(((PTTTime / PTTControl)) ^ ISIValue, 2)

                End If

                x += 1

            Next

        End If

        If TestID = 2 Then

            If frmHistoComplate.txtReport.Text = "" Or txtLabNo.Text = "" Or frmHistoComplate.cbCancer.SelectedValue = Nothing Then

                Result = Frm.ShowMessage("Either report field or Lab No or Cancer registery value is empty", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.OK, Frm)

                Exit Sub

            End If

            HistoReport = frmHistoComplate.txtReport.Text.ToString
            LabNoTemp = txtLabNo.Text
            CanReg = frmHistoComplate.cbCancer.SelectedValue
            RegDate = frmHistoComplate.DTPRegistrationDate.Value.Date
            Request = frmHistoComplate.txtRequest.Text
        End If

        If txtLabNo.Text = "" Then

            txtLabNo.Text = "N/A"

        End If

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try

            Call ShowProgress("Saving Entered Values", MessageDirection.Right, 2000)

#Region "Saving Data Entered"

            If TestID = 2 Then

                cmd.CommandText = "UPDATE [TransactionsMaster] SET [RecStatus] = 1 , [clinic_info] = '" &
                                                                   TXTclinicalinfo.Text & "' , [Request] = '" &
                                                                   Request & "', [consultant] = '" &
                                                                   TXTconsultant.Text & "' , [ReportDate] = '" &
                                                                   DTPReportDate.Value.Date & "' , [Macro] = '" &
                                                                   HistoReport & "' , [HistoLabNo] = '" &
                                                                   LabNoTemp & "' , [CanRegID] = " &
                                                                   CanReg & " , [TransDate] = '" &
                                                                   RegDate & "' , [ProfileName] = '" &
                                                                   frmHistoComplate.txtRequest.Text & "' WHERE [TransID] = '" &
                                                                   TransIDTemp & "' and [TestId] = " &
                                                                   TestID & ""
                cmd.ExecuteNonQuery()

                GoTo fromhere

            End If

            If TestID = 9 Then

                    cmd.CommandText = "UPDATE [TransactionsMaster] SET [RecStatus] = 1 , [clinic_info] = '" &
                                                                       TXTclinicalinfo.Text & "' ,[consultant] = '" &
                                                                       TXTconsultant.Text & "' , [Notes] = '" &
                                                                       txtNote.Text & "' , [ReportDate] = '" &
                                                                       DTPReportDate.Value.Date & "' , [HistoLabNo] = '" &
                                                                       txtLabNo.Text & "',[CanRegID] = " &
                                                                       CanReg & " WHERE [TransID] = '" &
                                                                       TransIDTemp & "' and [TestId] = " &
                                                                       TestID & ""
                    cmd.ExecuteNonQuery()


                    cmd.CommandText = "UPDATE [TransactionsDetails] SET [RealValue] = '" &
                                                                         frmCulture.txtCulture.Text & "' WHERE [TransID] = '" &
                                                                         TransIDTemp & "' and [TestId] = " &
                                                                         TestID & " and [ValueId] = 1322"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "UPDATE [TransactionsDetails] SET [RealValue] = '" &
                                                                        frmCulture.txtsensitive.Text & "' WHERE [TransID] = '" &
                                                                        TransIDTemp & "' and [TestId] = " &
                                                                        TestID & " and [ValueId] = 4400"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "UPDATE [TransactionsDetails] SET [RealValue] = '" &
                                                                        frmCulture.txtresistant.Text & "' WHERE [TransID] = '" &
                                                                        TransIDTemp & "' and [TestId] = " &
                                                                        TestID & " and [ValueId] = 4401"
                    cmd.ExecuteNonQuery()

                GoTo fromhere

            End If


                cmd.CommandText = "UPDATE [TransactionsMaster] SET [RecStatus] = 1 , [clinic_info] = '" &
                                                                   TXTclinicalinfo.Text & "' ,[consultant] = '" &
                                                                   TXTconsultant.Text & "' , [Notes] = '" &
                                                                   txtNote.Text & "' , [ReportDate] = '" &
                                                                   DTPReportDate.Value.Date & "' , [HistoLabNo] = '" &
                                                                   txtLabNo.Text & "',[CanRegID] = " &
                                                                   CanReg & " WHERE [TransID] = '" &
                                                                   TransIDTemp & "' and [TestId] = " &
                                                                   TestID & ""
                cmd.ExecuteNonQuery()

                x = 0

                For Each row As DataGridViewRow In dgvRequestedTests.Rows

                    If dgvRequestedTests.Rows(x).Cells(4).Value <> Nothing Then

                        cmd.CommandText = "UPDATE [TransactionsDetails] SET [RealValue] = '" &
                                                                     dgvRequestedTests.Rows(x).Cells(2).Value & "' WHERE [TransID] = '" &
                                                                     TransIDTemp & "' and [TestId] = " &
                                                                     TestID & " and [ValueId] = " &
                                                                     dgvRequestedTests.Rows(x).Cells(0).Value & ""
                        cmd.ExecuteNonQuery()

                        x += 1

                    Else

                        x += 1

                    End If


                Next




#End Region

fromhere:

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

    Private Sub frmResultes_Shown(sender As Object, e As EventArgs) Handles Me.Shown


    End Sub

    Private Sub DgvWaitting_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWaitting.CellContentClick

        If e.ColumnIndex = 5 Then

            If dgvWaitting.Rows(e.RowIndex).Cells(4).Value <> Nothing Then


                search("SELECT [TransID],[PayeeName],[AccountNo],[TestId],[ProfileName],[LabNo],[consultant] FROM [TransactionsMaster] where [TransID] = '" &
                                                           dgvWaitting.Rows(e.RowIndex).Cells(4).Value & "' and [TransType] = 10 And [RecStatus] = 0 and [TestId] = '" &
                                                           dgvWaitting.Rows(e.RowIndex).Cells(0).Value & "'")
                If myreader.HasRows = True Then

                    TXTPatientName.Text = myreader(1)
                    TXTconsultant.Text = myreader(6).ToString

                    TransIDTemp = dgvWaitting.Rows(e.RowIndex).Cells(4).Value
                    TestID = myreader(3)
                    AccountNoVar = myreader(2)

                    If myreader(3) = 2 Then

                        If IsFormOpen(frmHistoComplate) = False Then

                            RequestPanel.Controls.Clear()
                            'Dim xx As New frmWaiting
                            frmHistoComplate.Close()
                            frmHistoComplate.TopLevel = False
                            RequestPanel.Height = frmHistoComplate.Height
                            RequestPanel.Controls.Add(frmHistoComplate)
                            frmHistoComplate.Parent = RequestPanel
                            'xx.Show()

                            '****** hide cancer registery lable and combo box if profile is not haematology
                            lblcanreg.Visible = False
                            cbCancer.Visible = False
                            cbCancer.Text = Nothing
                            '***************************

                            frmHistoComplate.Show()
                            frmHistoComplate.BringToFront()


                        Else
                            '****** hide cancer registery lable and combo box if profile is not haematology
                            lblcanreg.Visible = False
                            cbCancer.Visible = False
                            cbCancer.Text = Nothing
                            '***************************

                            frmHistoComplate.Height = RequestPanel.Height
                            frmHistoComplate.Width = RequestPanel.Width

                            frmHistoComplate.Parent = RequestPanel

                            frmHistoComplate.Show()

                            frmHistoComplate.BringToFront()

                        End If

                        frmHistoComplate.txtRequest.Text = myreader(4)

                        ChkTestID = 1

                        GoTo FromHere

                    End If

                    If myreader(3) = 9 Then

                        If IsFormOpen(frmCulture) = False Then

                            RequestPanel.Controls.Clear()
                            'Dim xx As New frmWaiting
                            frmCulture.Close()
                            frmCulture.TopLevel = False
                            RequestPanel.Height = frmCulture.Height
                            RequestPanel.Controls.Add(frmCulture)
                            frmCulture.Parent = RequestPanel
                            'xx.Show()

                            '****** hide cancer registery lable and combo box if profile is not haematology
                            lblcanreg.Visible = False
                            cbCancer.Visible = False
                            cbCancer.Text = Nothing
                            '***************************

                            frmCulture.Show()
                            frmCulture.BringToFront()


                        Else
                            '****** hide cancer registery lable and combo box if profile is not haematology
                            lblcanreg.Visible = False
                            cbCancer.Visible = False
                            cbCancer.Text = Nothing
                            '***************************

                            frmCulture.Height = RequestPanel.Height
                            frmCulture.Width = RequestPanel.Width

                            frmCulture.Parent = RequestPanel

                            frmCulture.Show()

                            frmCulture.BringToFront()

                        End If

                        ChkTestID = 1

                        GoTo FromHere

                    End If

                    'If myreader(3) <> 2 Then

                    frmHistoComplate.Hide()
                    frmCulture.Hide()

                    dgvRequestedTests.Parent = RequestPanel
                    dgvRequestedTests.Height = 253
                    dgvRequestedTests.Width = 532

                    txtNote.Parent = RequestPanel
                    txtNote.Width = 532
                    txtNote.Height = 98

                    dgvRequestedTests.BringToFront()

                    dgvRequestedTests.Rows.Clear()

                    '****** hide cancer registery lable and combo box if profile is not haematology
                    lblcanreg.Visible = False
                    cbCancer.Visible = False
                    '***************************

                    '******* Show cancer registry lable and combo box if profile is haamatology
                    If myreader(3) = 1 Then
                        lblcanreg.Visible = True
                        cbCancer.Visible = True
                        cbCancer.Text = Nothing
                    End If
                    '***************************
                    SerJIT("SELECT [TransID],[TestId],[ValueId],[TransDate],[TestName] FROM [TransactionsDetails] where TransID = '" &
                                                                dgvWaitting.Rows(e.RowIndex).Cells(4).Value & "' and Testid  = " &
                                                                dgvWaitting.Rows(e.RowIndex).Cells(0).Value & " order by OrderDetails")

                    If JITReader.HasRows = True Then

                        Dim Y As Integer = 0

                        Do

                            dgvRequestedTests.Rows.Add()

                            dgvRequestedTests.Rows(Y).Cells(0).Value = JITReader(2)
                            dgvRequestedTests.Rows(Y).Cells(1).Value = JITReader(4)
                            dgvRequestedTests.Rows(Y).Cells(3).Value = JITReader(0)
                            dgvRequestedTests.Rows(Y).Cells(4).Value = JITReader(2)

                            Y += 1

                        Loop Until JITReader.Read = False


                    End If

                    ChkTestID = 0

                    'End If

FromHere:

                    Call GetHistory(myreader(2))

                End If

            End If

        End If
        '* delete from transaction master and transaction details
        Dim frmAsk As New FrmMessageBox
        Dim ResultAsk As String

        If e.ColumnIndex = 6 Then

            ResultAsk = frmAsk.ShowMessage("Are You Sure ...?", "TMLCC",
                                      MessageBoxIcon.Information, MessageBoxButtons.YesNo, frmAsk)

            If ResultAsk = "Yes" Then

                If dgvWaitting.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                    Call ShowProgress("Deleting Transation", MessageDirection.Right, 2000)

                    operation("Delete from TransactionsMaster where TransID = '" & dgvWaitting.Rows(e.RowIndex).Cells(4).Value & "'")

                    operation("Delete from TransactionsDetails where TransID = '" & dgvWaitting.Rows(e.RowIndex).Cells(4).Value & "'")

                    Call CLS()

                End If

            End If

        End If

    End Sub

    Private Sub DgvRequestedTests_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequestedTests.CellContentClick

    End Sub

    Private Sub dgvRequestedTests_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequestedTests.CellEnter

        Dim dgv As DataGridView = CType(sender, DataGridView)

        On Error Resume Next

        If dgv(e.ColumnIndex, e.RowIndex).EditType.ToString() = "System.Windows.Forms.DataGridViewComboBoxEditingControl" Then
            SendKeys.Send("{F4}")
        End If

        If dgv(e.ColumnIndex, e.RowIndex).EditType.ToString() = "System.Windows.Forms.DataGridViewTextBoxEditingControl" Then
            SendKeys.Send("{F2}")
        End If

        If dgv(e.ColumnIndex, e.RowIndex).EditType.ToString() <> "System.Windows.Forms.DataGridViewTextBoxEditingControl" Then
            SendKeys.Send("{F2}")
        End If

    End Sub

    Private Sub dgvRequestedTests_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvRequestedTests.EditingControlShowing


        If dgvRequestedTests.CurrentCell.ColumnIndex = 2 AndAlso TypeOf e.Control Is TextBox Then

            With DirectCast(e.Control, TextBox)

                '.RightToLeft = LeftRightAlignment.Right
                '.TextAlign = HorizontalAlignment.Right

                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = scItemValuesAutoComplete


            End With

        Else

            On Error Resume Next

            With DirectCast(e.Control, TextBox)

                .AutoCompleteMode = Nothing
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = Nothing

            End With

        End If

    End Sub

    Private Sub dgvRequestedTests_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvRequestedTests.CellBeginEdit

        If e.ColumnIndex = 1 Then

            dgvRequestedTests.CurrentCell = dgvRequestedTests(2, e.RowIndex)

        End If

    End Sub

    Private Sub DgvPrintRoutine_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrintRoutine.CellContentClick

        Dim Frm As New FrmMessageBox
        Dim Result As String

        Dim TestIDTemp As Integer = 0
        Dim CanReg As Integer = 0

        If e.ColumnIndex = 4 Then

            If dgvPrintRoutine.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                search("SELECT [TransID],[PayeeName],[AccountNo],[TestId],[ProfileName],[LabNo],[clinic_info]," &
                                                "[consultant],[Notes],[TransDate],[Macro],[CanRegID],[HistoLabNo] FROM [TransactionsMaster] where [TransID] = '" &
                                                           dgvPrintRoutine.Rows(e.RowIndex).Cells(0).Value & "' and [TransType] = 10 And [RecStatus] = 1")
                If myreader.HasRows = True Then

                    TXTPatientName.Text = myreader(1)

                    TXTclinicalinfo.Text = myreader(6).ToString
                    TXTconsultant.Text = myreader(7).ToString
                    txtNote.Text = myreader(8).ToString
                    txtLabNo.Text = myreader(12)
                    CanReg = myreader(11)
                    Call GetHistory(myreader(2))

                    TransIDTemp = dgvPrintRoutine.Rows(e.RowIndex).Cells(0).Value
                    TestID = myreader(3)
                    AccountNoVar = myreader(2)


                    If TestID = 2 Then

                        If IsFormOpen(frmHistoComplate) = False Then

                            RequestPanel.Controls.Clear()
                            'Dim xx As New frmWaiting
                            frmHistoComplate.Close()

                            frmHistoComplate.TopLevel = False
                            RequestPanel.Height = frmHistoComplate.Height
                            RequestPanel.Controls.Add(frmHistoComplate)
                            frmHistoComplate.Parent = RequestPanel
                            'xx.Show()

                            frmHistoComplate.Show()
                            frmHistoComplate.BringToFront()

                        Else

                            frmHistoComplate.Height = RequestPanel.Height
                            frmHistoComplate.Width = RequestPanel.Width

                            frmHistoComplate.Parent = RequestPanel

                            frmHistoComplate.Show()

                            frmHistoComplate.BringToFront()

                        End If

                        frmHistoComplate.cbCancer.SelectedValue = myreader(11)
                        frmHistoComplate.DTPRegistrationDate.Value = myreader(9)
                        frmHistoComplate.txtRequest.Text = myreader(4)
                        frmHistoComplate.txtReport.Text = myreader(10)

                        ChkTestID = 1

                        GoTo fromhere

                    End If

                    If TestID = 9 Then

                        If IsFormOpen(frmCulture) = False Then

                            RequestPanel.Controls.Clear()
                            'Dim xx As New frmWaiting
                            frmCulture.Close()

                            frmCulture.TopLevel = False
                            RequestPanel.Height = frmCulture.Height
                            RequestPanel.Controls.Add(frmCulture)
                            frmCulture.Parent = RequestPanel
                            'xx.Show()

                            frmCulture.Show()
                            frmCulture.BringToFront()

                        Else

                            frmCulture.Height = RequestPanel.Height
                            frmCulture.Width = RequestPanel.Width

                            frmCulture.Parent = RequestPanel

                            frmCulture.Show()

                            frmCulture.BringToFront()

                        End If

                        SerJIT("SELECT [TransID],[TestId],[ValueId],[TransDate],[TestName],[RealValue] FROM [TransactionsDetails] where TransID = '" &
                                                                                               dgvPrintRoutine.Rows(e.RowIndex).Cells(0).Value & "'")

                        If JITReader.HasRows = True Then

                            Do

                                If JITReader(2) = 1322 Then

                                    frmCulture.txtCulture.Text = JITReader(5)

                                End If

                                If JITReader(2) = 4400 Then

                                    frmCulture.txtsensitive.Text = JITReader(5)

                                End If

                                If JITReader(2) = 4401 Then

                                    frmCulture.txtresistant.Text = JITReader(5)

                                End If


                            Loop Until JITReader.Read = False

                        End If

                        ChkTestID = 1

                        GoTo fromhere

                    End If

                    frmHistoComplate.Hide()
                    frmCulture.Hide()

                    dgvRequestedTests.Parent = RequestPanel
                    'dgvRequestedTests.Height = RequestPanel.Height
                    'dgvRequestedTests.Width = RequestPanel.Width
                    dgvRequestedTests.Height = 253
                    dgvRequestedTests.Width = 532

                    txtNote.Parent = RequestPanel
                    txtNote.Width = 532
                    txtNote.Height = 98


                    dgvRequestedTests.BringToFront()

                    dgvRequestedTests.Rows.Clear()

                    '****** hide cancer registery lable and combo box if profile is not haematology
                    lblcanreg.Visible = False
                    cbCancer.Visible = False
                    '***************************

                    '******* Show cancer registry lable and combo box if profile is haamatology
                    If TestID = 1 Then
                        lblcanreg.Visible = True
                        cbCancer.Visible = True

                        SerTemp("select InternationalCode from BasCancers where CanRegID = " & CanReg & "")
                        If TempReader.HasRows Then

                            cbCancer.Text = TempReader(0)

                        End If

                    End If
                    '***************************


                    SerJIT("SELECT [TransID],[TestId],[ValueId],[TransDate],[TestName],[RealValue] FROM [TransactionsDetails] where TransID = '" &
                                                            dgvPrintRoutine.Rows(e.RowIndex).Cells(0).Value & "' and Testid  = " &
                                                            myreader(3) & "")

                    If JITReader.HasRows = True Then

                        Dim Y As Integer = 0

                        dgvRequestedTests.Rows.Clear()

                        Do

                            dgvRequestedTests.Rows.Add()

                            dgvRequestedTests.Rows(Y).Cells(0).Value = JITReader(2)
                            dgvRequestedTests.Rows(Y).Cells(1).Value = JITReader(4)
                            dgvRequestedTests.Rows(Y).Cells(2).Value = JITReader(5)
                            dgvRequestedTests.Rows(Y).Cells(3).Value = JITReader(0)
                            dgvRequestedTests.Rows(Y).Cells(4).Value = JITReader(2)

                            Y += 1

                        Loop Until JITReader.Read = False

                    End If

                    ChkTestID = 0

                End If

fromhere:

            End If

        End If

        Dim frmAsk As New FrmMessageBox
        Dim ResultAsk As String

        If e.ColumnIndex = 5 Then


            Try

                If dgvPrintRoutine.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                    search("SELECT [TransID],[AccountNo],[Transdate],[LabNo],[TestID] FROM [TransactionsMaster] where [TransID] = '" &
                                                                   dgvPrintRoutine.Rows(e.RowIndex).Cells(0).Value & "' and [TransType] = 10 And [RecStatus] = 1")
                    If myreader.HasRows = True Then

                        TestID = myreader(4)

                        operation("Update  [RepTemp] set TransID ='" &
                                                      myreader(0) & "', StartDate= '" &
                                                      myreader(2) & "', AccountNo = '" &
                                                      myreader(1) & "', LabNo = " &
                                                      myreader(4) & " where UserID = " &
                                                      AccIDVar & "")

                        operation("Update  [TransactionsMaster]  set RecStatus = 2 where TransID = " & myreader(0) & "")

                    End If

                End If

                If TestID = 1 Then

                    Dim Rpt As New CRHaematology
                    GETSERVERNAMEANDDATABASENAME(Rpt, "LabERPDB")
                    Rpt.RecordSelectionFormula = "{RepTemp.userID} =(" & AccIDVar & ")"
                    FrmReport.CRView.ReportSource = Rpt
                    FrmReport.CRView.Zoom(1)
                    FrmReport.CRView.RefreshReport()
                    FrmReport.Show()


                ElseIf TestID = 2 Then

                    ResultAsk = frmAsk.ShowMessage("Print on A4 ...?", "TMLCC",
                                      MessageBoxIcon.Information, MessageBoxButtons.YesNo, frmAsk)

                    If ResultAsk = "Yes" Then

                        Dim Rpt As New CRHistoA4
                        GETSERVERNAMEANDDATABASENAME(Rpt, "LabERPDB")
                        Rpt.RecordSelectionFormula = "{RepTemp.userID} =(" & AccIDVar & ")"
                        FrmReport.CRView.ReportSource = Rpt
                        FrmReport.CRView.Zoom(1)
                        FrmReport.CRView.RefreshReport()
                        FrmReport.Show()

                    End If

                    If ResultAsk = "No" Then

                        Dim Rpt As New CRHistomini
                        GETSERVERNAMEANDDATABASENAME(Rpt, "LabERPDB")
                        Rpt.RecordSelectionFormula = "{RepTemp.userID} =(" & AccIDVar & ")"
                        FrmReport.CRView.ReportSource = Rpt
                        FrmReport.CRView.Zoom(1)
                        FrmReport.CRView.RefreshReport()
                        FrmReport.Show()

                    End If

                ElseIf TestID = 9 Then


                    Dim Rpt As New Culture
                    GETSERVERNAMEANDDATABASENAME(Rpt, "LabERPDB")
                    Rpt.RecordSelectionFormula = "{RepTemp.userID} =(" & AccIDVar & ")"
                    FrmReport.CRView.ReportSource = Rpt
                    FrmReport.CRView.Zoom(1)
                    FrmReport.CRView.RefreshReport()
                    FrmReport.Show()

                Else

                    Dim Rpt As New Result
                    GETSERVERNAMEANDDATABASENAME(Rpt, "LabERPDB")
                    Rpt.RecordSelectionFormula = "{RepTemp.userID} =(" & AccIDVar & ")"
                    FrmReport.CRView.ReportSource = Rpt
                    FrmReport.CRView.Zoom(1)
                    FrmReport.CRView.RefreshReport()
                    FrmReport.Show()

                End If

                Call CLS()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try



        End If

        '*******Delete from transaction master and transdetails
        If e.ColumnIndex = 7 Then

            ResultAsk = frmAsk.ShowMessage("Are You Sure ...?", "TMLCC",
                                      MessageBoxIcon.Information, MessageBoxButtons.YesNo, frmAsk)

            If ResultAsk = "Yes" Then

                If dgvPrintRoutine.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                    Call ShowProgress("Deleting Transation", MessageDirection.Right, 2000)

                    operation("Delete from TransactionsMaster where TransID = '" & dgvPrintRoutine.Rows(e.RowIndex).Cells(0).Value & "'")

                    operation("Delete from TransactionsDetails where TransID = '" & dgvPrintRoutine.Rows(e.RowIndex).Cells(0).Value & "'")

                    Call CLS()

                End If

            End If

        End If

    End Sub


    Private Sub dgvHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistory.CellContentClick

        Dim TestIDTemp As Integer = 0
        Dim CanReg As Integer = 0

        If e.ColumnIndex = 4 Then

            If dgvHistory.Rows(e.RowIndex).Cells(3).Value <> Nothing Then

                search("SELECT [TransID],[PayeeName],[AccountNo],[TestId],[ProfileName],[LabNo],[clinic_info]," &
                                                "[consultant],[Notes],[TransDate],[Macro],[CanRegID],[HistoLabNo],[request] FROM [TransactionsMaster] where [TransID] = '" &
                                                                                                    dgvHistory.Rows(e.RowIndex).Cells(3).Value & "'")
                If myreader.HasRows = True Then

                    TXTPatientName.Text = myreader(1)

                    TXTclinicalinfo.Text = myreader(6).ToString
                    TXTconsultant.Text = myreader(7).ToString
                    txtNote.Text = myreader(8).ToString
                    txtLabNo.Text = myreader(12).ToString

                    CanReg = myreader(11)
                    TestIDTemp = myreader(3)

                    TransIDTemp = dgvHistory.Rows(e.RowIndex).Cells(3).Value
                    TestID = myreader(3)
                    AccountNoVar = myreader(2)


                    If TestID = 2 Then

                        If IsFormOpen(frmHistoComplate) = False Then

                            RequestPanel.Controls.Clear()
                            'Dim xx As New frmWaiting
                            frmHistoComplate.Close()

                            frmHistoComplate.TopLevel = False
                            RequestPanel.Height = frmHistoComplate.Height
                            RequestPanel.Controls.Add(frmHistoComplate)
                            frmHistoComplate.Parent = RequestPanel
                            'xx.Show()

                            frmHistoComplate.Show()
                            frmHistoComplate.BringToFront()

                        Else

                            frmHistoComplate.Height = RequestPanel.Height
                            frmHistoComplate.Width = RequestPanel.Width

                            frmHistoComplate.Parent = RequestPanel

                            frmHistoComplate.Show()

                            frmHistoComplate.BringToFront()

                        End If

                        frmHistoComplate.cbCancer.SelectedValue = myreader(11)
                        frmHistoComplate.DTPRegistrationDate.Value = myreader(9)
                        frmHistoComplate.txtReport.Text = myreader(10)
                        frmHistoComplate.txtRequest.Text = myreader(13).ToString

                        ChkTestID = 1

                        GoTo fromhere

                    End If

                    If TestID = 9 Then

                        If IsFormOpen(frmCulture) = False Then

                            RequestPanel.Controls.Clear()
                            'Dim xx As New frmWaiting
                            frmCulture.Close()

                            frmCulture.TopLevel = False
                            RequestPanel.Height = frmCulture.Height
                            RequestPanel.Controls.Add(frmCulture)
                            frmCulture.Parent = RequestPanel
                            'xx.Show()

                            frmCulture.Show()
                            frmCulture.BringToFront()

                        Else

                            frmCulture.Height = RequestPanel.Height
                            frmCulture.Width = RequestPanel.Width

                            frmCulture.Parent = RequestPanel

                            frmCulture.Show()

                            frmCulture.BringToFront()

                        End If

                        SerJIT("SELECT [TransID],[TestId],[ValueId],[TransDate],[TestName],[RealValue] FROM [TransactionsDetails] where TransID = '" &
                                                                                                dgvHistory.Rows(e.RowIndex).Cells(3).Value & "'")

                        If JITReader.HasRows = True Then

                            Do

                                If JITReader(2) = 1322 Then

                                    frmCulture.txtCulture.Text = JITReader(5)

                                End If

                                If JITReader(2) = 4400 Then

                                    frmCulture.txtsensitive.Text = JITReader(5)

                                End If

                                If JITReader(2) = 4401 Then

                                    frmCulture.txtresistant.Text = JITReader(5)

                                End If


                            Loop Until JITReader.Read = False

                        End If

                        ChkTestID = 1

                        GoTo fromhere

                        End If


                        '****** hide cancer registery lable and combo box if profile is not haematology
                        lblcanreg.Visible = False
                    cbCancer.Visible = False
                    '***************************

                    '******* Show cancer registry lable and combo box if profile is haamatology
                    If TestID = 1 Then
                        lblcanreg.Visible = True
                        cbCancer.Visible = True

                        SerTemp("select InternationalCode from BasCancers where CanRegID = " & CanReg & "")
                        If TempReader.HasRows Then

                            cbCancer.Text = TempReader(0)

                        End If

                    End If
                    '***************************


                    SerJIT("SELECT [TransID],[TestId],[ValueId],[TransDate],[TestName],[RealValue] FROM [TransactionsDetails] where TransID = '" &
                                                                                                dgvHistory.Rows(e.RowIndex).Cells(3).Value & "' and Testid  = " &
                                                                                                TestIDTemp & "")

                    If JITReader.HasRows = True Then

                        frmHistoComplate.Hide()
                        frmCulture.Hide()

                        dgvRequestedTests.Parent = RequestPanel
                        'dgvRequestedTests.Height = RequestPanel.Height
                        'dgvRequestedTests.Width = RequestPanel.Width
                        dgvRequestedTests.Height = 253
                        dgvRequestedTests.Width = 532
                        txtNote.Parent = RequestPanel
                        txtNote.Width = 532
                        txtNote.Height = 98

                        dgvRequestedTests.BringToFront()

                        dgvRequestedTests.Rows.Clear()

                        Dim Y As Integer = 0

                        dgvRequestedTests.Rows.Clear()

                        Do

                            dgvRequestedTests.Rows.Add()

                            dgvRequestedTests.Rows(Y).Cells(0).Value = JITReader(2)
                            dgvRequestedTests.Rows(Y).Cells(1).Value = JITReader(4)
                            dgvRequestedTests.Rows(Y).Cells(2).Value = JITReader(5)
                            dgvRequestedTests.Rows(Y).Cells(3).Value = JITReader(0)
                            dgvRequestedTests.Rows(Y).Cells(4).Value = JITReader(2)

                            Y += 1

                        Loop Until JITReader.Read = False

                    End If

                    ChkTestID = 0

                End If


fromhere:

            End If

        End If

        Dim frmAsk As New FrmMessageBox
        Dim ResultAsk As String

        If e.ColumnIndex = 5 Then


            Try

                If dgvHistory.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                    search("SELECT [TransID],[AccountNo],[Transdate],[LabNo],[TestID] FROM [TransactionsMaster] where [TransID] = '" &
                                                                   dgvHistory.Rows(e.RowIndex).Cells(3).Value & "' and [TransType] = 10 And [RecStatus] = 2")
                    If myreader.HasRows = True Then


                        TestID = myreader(4)

                        operation("Update  [RepTemp] set TransID ='" &
                                            myreader(0) & "', StartDate = '" &
                                            myreader(2) & "' , AccountNo = '" &
                                            myreader(1) & "', LabNo = " &
                                            myreader(4) & " where UserID = " &
                                            AccIDVar & "")


                    End If


                End If

                If TestID = 1 Then

                    Dim Rpt As New CRHaematology
                    GETSERVERNAMEANDDATABASENAME(Rpt, "LabERPDB")
                    Rpt.RecordSelectionFormula = "{RepTemp.userID} =(" & AccIDVar & ")"
                    FrmReport.CRView.ReportSource = Rpt
                    FrmReport.CRView.Zoom(1)
                    FrmReport.CRView.RefreshReport()
                    FrmReport.Show()



                ElseIf TestID = 2 Then

                    ResultAsk = frmAsk.ShowMessage("Print on A4 ...?", "TMLCC",
                                      MessageBoxIcon.Information, MessageBoxButtons.YesNo, frmAsk)

                    If ResultAsk = "Yes" Then

                        Dim Rpt As New CRHistoA4
                        GETSERVERNAMEANDDATABASENAME(Rpt, "LabERPDB")
                        Rpt.RecordSelectionFormula = "{RepTemp.userID} =(" & AccIDVar & ")"
                        FrmReport.CRView.ReportSource = Rpt
                        FrmReport.CRView.Zoom(1)
                        FrmReport.CRView.RefreshReport()
                        FrmReport.Show()

                    End If

                    If ResultAsk = "No" Then

                        Dim Rpt As New CRHistomini
                        GETSERVERNAMEANDDATABASENAME(Rpt, "LabERPDB")
                        Rpt.RecordSelectionFormula = "{RepTemp.userID} =(" & AccIDVar & ")"
                        FrmReport.CRView.ReportSource = Rpt
                        FrmReport.CRView.Zoom(1)
                        FrmReport.CRView.RefreshReport()
                        FrmReport.Show()

                    End If

                ElseIf TestID = 9 Then


                    Dim Rpt As New Culture
                    GETSERVERNAMEANDDATABASENAME(Rpt, "LabERPDB")
                    Rpt.RecordSelectionFormula = "{RepTemp.userID} =(" & AccIDVar & ")"
                    FrmReport.CRView.ReportSource = Rpt
                    FrmReport.CRView.Zoom(1)
                    FrmReport.CRView.RefreshReport()
                    FrmReport.Show()

                Else

                    Dim Rpt As New Result
                    GETSERVERNAMEANDDATABASENAME(Rpt, "LabERPDB")
                    Rpt.RecordSelectionFormula = "{RepTemp.userID} =(" & AccIDVar & ") and {VResult.RealValue} <> ''"
                    FrmReport.CRView.ReportSource = Rpt
                    FrmReport.CRView.Zoom(1)
                    FrmReport.CRView.RefreshReport()
                    FrmReport.Show()

                End If


            Catch ex As Exception

                MsgBox(ex.Message)

            End Try


        End If

        '******* Delete from transaction master and transdetails
        If e.ColumnIndex = 7 Then

            ResultAsk = frmAsk.ShowMessage("Are You Sure ...?", "TMLCC",
                                      MessageBoxIcon.Information, MessageBoxButtons.YesNo, frmAsk)

            If ResultAsk = "Yes" Then

                If dgvHistory.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                    Call ShowProgress("Deleting Transation", MessageDirection.Right, 2000)

                    operation("Delete from TransactionsMaster where TransID = '" & dgvHistory.Rows(e.RowIndex).Cells(3).Value & "'")

                    operation("Delete from TransactionsDetails where TransID = '" & dgvHistory.Rows(e.RowIndex).Cells(3).Value & "'")

                    Call CLS()

                End If

            End If

        End If

    End Sub

    Private Sub TXTPatientName_LostFocus(sender As Object, e As EventArgs) Handles TXTPatientName.LostFocus

        If TXTPatientName.Text = "" Then

            Exit Sub

        End If

        search("SELECT * FROM CrDrMaster where DescripName = '" & TXTPatientName.Text & "'")

        If myreader.HasRows = True Then

            AccountNoVar = myreader(0)
            PayeeID = myreader(0)
            TXTPatientName.Text = myreader(1)

            Call GetHistory(AccountNoVar)

            dgvRequestedTests.Rows.Clear()
            TXTclinicalinfo.Text = Nothing
            TXTconsultant.Text = Nothing
            frmHistoComplate.txtReport.Text = ""
            frmHistoComplate.txtRequest.Text = ""

        End If

        If myreader.HasRows = False Then

            dgvHistory.Rows.Clear()
            dgvRequestedTests.Rows.Clear()
            TXTclinicalinfo.Text = Nothing
            TXTconsultant.Text = Nothing
            frmHistoComplate.txtReport.Text = ""
            frmHistoComplate.txtRequest.Text = ""

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

    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click

        Call CLS()

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
            TXTPatientName.Text = myreader(1)

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
                frmPateintProfile.FromVar = 2

                frmPateintProfile.ShowDialog()

            End If

        End If

    End Sub



    Private Sub frmResultes_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated

        Call CreateDGV()
        Call AutoFill()

        Call GetRoutine()
        Call GetPrintList()
        Call ComboFill()

    End Sub


    Private Sub TXTFilter_TextChanged(sender As Object, e As EventArgs) Handles TXTFilter.TextChanged

        Dim x As Integer = 0

        Try

            If TXTFilter.Text <> Nothing Then

                search("SELECT [TransID],[TransDate],[PayeeName],[AccountNo],[TestId],[ProfileName],[LabNo] FROM [TransactionsMaster] where [PayeeName] like '" &
                                                                                                     TXTFilter.Text & "%' and [TransType] = 10 and [RecStatus] = 0")

                If myreader.HasRows = True Then

                    dgvWaitting.Rows.Clear()

                    Do

                        dgvWaitting.Rows.Add()

                        dgvWaitting.Rows(x).Cells(0).Value = myreader(4)
                        dgvWaitting.Rows(x).Cells(1).Value = myreader(2)
                        dgvWaitting.Rows(x).Cells(2).Value = myreader(5)
                        dgvWaitting.Rows(x).Cells(3).Value = myreader(6)
                        dgvWaitting.Rows(x).Cells(4).Value = myreader(0)

                        x += 1

                    Loop Until myreader.Read = False

                    LBLWNoR.Text = x.ToString

                End If

            End If

            If TXTFilter.Text = Nothing Then

                Call GetRoutine()

            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmResultes_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        If Visible = False Then

            DisableSpellCheck

        End If

    End Sub

    Private Sub txtNote_Click(sender As Object, e As EventArgs) Handles txtNote.Click

    End Sub

    Private Sub TXTRoutineFilter_TextChanged(sender As Object, e As EventArgs) Handles TXTRoutineFilter.TextChanged
        '    Dim x As Integer = 0

        '    Try

        '        If TXTRoutineFilter.Text <> Nothing Then

        '            search("SELECT [TransID],[TransDate],[PayeeName],[AccountNo],[TestId],[ProfileName],[LabNo] FROM [TransactionsMaster] where [PayeeName] like '" &
        '                                                                                                 TXTRoutineFilter.Text & "%' and [TransType] = 10 and [RecStatus] = 1")

        '            If myreader.HasRows = True Then

        '                dgvPrintRoutine.Rows.Clear()

        '                Do

        '                    dgvPrintRoutine.Rows.Add()

        '                    dgvPrintRoutine.Rows(x).Cells(0).Value = myreader(4)
        '                    dgvPrintRoutine.Rows(x).Cells(1).Value = myreader(2)
        '                    dgvPrintRoutine.Rows(x).Cells(2).Value = myreader(5)
        '                    dgvPrintRoutine.Rows(x).Cells(3).Value = myreader(6)
        '                    dgvPrintRoutine.Rows(x).Cells(4).Value = myreader(0)

        '                    x += 1

        '                Loop Until myreader.Read = False

        '                LBLPRNo.Text = dgvPrintRoutine.DisplayedRowCount(True)

        '            End If

        '        End If

        '        If TXTFilter.Text = Nothing Then

        '            Call GetRoutine()

        '        End If


        '    Catch ex As Exception

        '    End Try
    End Sub

    Private Sub frmResultes_Load(sender As Object, e As EventArgs) Handles Me.Load


        'EnableControlExtensions()
        txtNote.EnableSpellCheck()


    End Sub

    Private Sub TXTPatientName_TextChanged(sender As Object, e As EventArgs) Handles TXTPatientName.TextChanged

    End Sub
End Class