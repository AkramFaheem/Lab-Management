Public Class frmPateintProfile

    Public FromVar As Integer
    Public CurrentRecord As Integer
    Public AutoFillCHK As Integer = 0

    Public AccIDVar As Integer
    Public AccIDType As Integer

    Public UDBVar As Integer

    Public SeedVar As Integer = 1000000
    Public RecPrefix As String

    Public PayeeID As Object = Nothing
    Public PayName As Object = Nothing

    Public LocIDVar As Integer = Nothing

    Public AccountNoVar As String = Nothing

    Public scPayeeNameAutoComplete As New AutoCompleteStringCollection

    Public Sub AutoFill()

        Call AutoCompleteFill(scPayeeNameAutoComplete, "CrDrMaster", "DescripName", 1, txtPayeeName)

    End Sub

    Private Sub ComboFill()

        If FromVar = 1 Then

            Call FillCombo(cbRecType, "BasRecTypes", "Description", "TypeID", 1)

        ElseIf FromVar = 2 Then

            Call FillCombo(cbRecType, "BasRecTypes", "Description", "TypeID", 1, 1, "AccountorCHK", 1)

        ElseIf FromVar = 3 Then

            Call FillCombo(cbRecType, "BasRecTypes", "Description", "TypeID", 1, 1, "AccountorCHK", 1)

        End If

        Call FillCombo(cbAreas, "BasLocality", "LocName", "LocID", 2)

    End Sub

    Private Sub frmMasterTools_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Call ComboFill()

        txtPayeeName.AutoCompleteCustomSource = Nothing

        Call AutoFill()

        txtPayeeName.AutoCompleteCustomSource = scPayeeNameAutoComplete

        If FromVar = 1 Then

            cbRecType.SelectedValue = 12
            cbRecType.Enabled = False
            RecPrefix = "PAT"

        End If

        If FromVar = 2 Or FromVar = 3 Then

            cbRecType.Enabled = True

        End If

        cbAreas.SelectedValue = LocIDVar

    End Sub

    Private Sub doclean(ByVal parentCtr As Control)

        'Me.FinancedName.AutoCompleteMode = AutoCompleteMode.None

        Dim ctr As Control

        Dim x As Integer = parentCtr.Controls.Count

        For Each ctr In parentCtr.Controls

            If TypeOf ctr Is TextBox Then

                ctr.Text = ""

            ElseIf TypeOf ctr Is ComboBox Then

                DirectCast(ctr, ComboBox).SelectedIndex = -1

                DirectCast(ctr, ComboBox).Text = ""

            ElseIf TypeOf ctr Is DataGridView Then

                DirectCast(ctr, DataGridView).DataSource = Nothing

            End If

            doclean(ctr)

        Next

        PayeeID = Nothing
        btSave.Enabled = True

    End Sub

    Private Sub btRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim frmStatusMessage As New frmStatus()

        frmStatusMessage.Show("Please Wait Until Complate Your Request", MessageBoxIcon.Information)

        Me.txtPayeeName.AutoCompleteCustomSource = Nothing

        Call doclean(Me)

        Call ComboFill()
        Call AutoFill()

        PayeeID = Nothing
        PayName = Nothing
        AccountNoVar = Nothing

        frmStatusMessage.Close()

    End Sub

    Private Sub btExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'frmSupplyTransactions.txtPayeeName.Text = Nothing

        Me.Hide()

    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click

        Dim Frm As New FrmMessageBox
        Dim Result As String


        If cbRecType.SelectedValue = Nothing Then

            Result = Frm.ShowMessage("PLease Select Record Type", "TMLCC",
                                   MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

            Exit Sub

        End If

        If txtPayeeName.Text = "" Then

            Result = Frm.ShowMessage("Please Type The Name", "TMLCC",
                                   MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

            Exit Sub

        End If

        If txtCellPhone.Text = "" Then

            txtCellPhone.Text = "N/A"

        End If

        If cbAreas.Text = Nothing Then

            cbAreas.SelectedValue = "264"

        End If

        If CMBAge.Text = Nothing Then

            CMBAge.SelectedText = "N/A"
        End If

        If CMBGender.Text = Nothing Then

            CMBGender.Text = "N/A"

        End If
        search("select * from CrDrMaster where DescripName = '" & txtPayeeName.Text & "'")

        If myreader.HasRows = True Then

            If PayeeID = Nothing Then

                Result = Frm.ShowMessage("This Name Exist", "TMLCC",
                               MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

                Exit Sub

            End If

        End If

        If PayName <> txtPayeeName.Text Then

            search("select * from CrDrMaster where DescripName = '" & txtPayeeName.Text & "'")


            If myreader.HasRows = True Then

                Result = Frm.ShowMessage("This Name Exist", "TMLCC",
                               MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

                Exit Sub

            End If


        End If

        search("select * from BasRecTypes where TypeID = " & Me.cbRecType.SelectedValue & "")

        If myreader.HasRows = True Then

            RecPrefix = myreader(2)

        End If

        If AccountNoVar = Nothing Then

            RecPrefix = "PAT"

            search("SELECT  COUNT(AccountNo) AS Total FROM CrDrMaster where Prefix = '" & Me.RecPrefix & "'")

            SeedVar += myreader(0)

            For i As Integer = myreader(0) + 1 To 8000000

                SeedVar += 1

                AccountNoVar = RecPrefix & SeedVar

                SerTemp("select * from CrDrMaster where AccountNo = '" & AccountNoVar & "'")

                If TempReader.HasRows = False Then

                    i = 8000001

                End If

            Next

        End If

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try

            If Me.PayeeID = Nothing Then

                cmd.CommandText = "INSERT INTO [CrDrMaster] ([AccountNo],[DescripName],[CellPhone],[TypeID],[Prefix],[LocID],[date_birth],[sex]) VALUES ('" &
                                               AccountNoVar & "' , '" &
                                               txtPayeeName.Text & "' , '" &
                                               txtCellPhone.Text & "' , " &
                                               cbRecType.SelectedValue & " , '" &
                                               RecPrefix & "' , " &
                                               cbAreas.SelectedValue & " ,'" &
                                               CMBAge.Text & "','" &
                                               CMBGender.Text & "')"
                cmd.ExecuteNonQuery()

            End If

            If PayeeID <> Nothing Then

                cmd.CommandText = "UPDATE [CrDrMaster] SET [DescripName] = '" &
                                                                        txtPayeeName.Text & "' , [CellPhone] = '" &
                                                                        txtCellPhone.Text & "' , [LocID] =  " &
                                                                        cbAreas.SelectedValue & " , [date_birth] = '" &
                                                                        CMBAge.Text & "' , [sex] = '" &
                                                                        CMBGender.Text & "' WHERE [AccountNo] = '" & PayeeID & "'"
                cmd.ExecuteNonQuery()

                cmd.CommandText = "UPDATE [TransactionsMaster] SET [PayeeName] = '" &
                                                                        txtPayeeName.Text & "' WHERE [AccountNo] = '" & PayeeID & "'"
                cmd.ExecuteNonQuery()

            End If

            TransOne.Commit()

            conn.Close()

            Dim FrmSave As New FrmMessageBox

            Result = FrmSave.ShowMessage("Operation Complated Sucessfully", "TMLCC",
                                MessageBoxIcon.Information, MessageBoxButtons.OK, FrmSave)

            search("SELECT * FROM CrDrMaster where DescripName = '" & txtPayeeName.Text & "'")

            If Me.FromVar = 1 Then

                FrmReg.AccountNoVar = AccountNoVar
                FrmReg.TXTPatientName.Text = myreader(1)
                FrmReg.PayeeID = myreader(0)
                FrmReg.PayeeName = myreader(1)

                FrmReg.TXTPatientName.Focus()

            End If

            If FromVar = 2 Then

                frmResultes.AccountNoVar = AccountNoVar
                frmResultes.TXTPatientName.Text = myreader(1)
                frmResultes.PayeeID = myreader(0)
                frmResultes.PayeeName = myreader(1)

                frmResultes.TXTPatientName.Focus()

            End If

            Call btRefresh_Click(sender, e)

            Hide()

        Catch ex As Exception

            Dim FrmError As New FrmMessageBox

            Result = FrmError.ShowMessage(ex.Message, "TMLCC",
                       MessageBoxIcon.Information, MessageBoxButtons.OK, FrmError)

            TransOne.Rollback()

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub cbAreas_Click(sender As Object, e As EventArgs) Handles cbAreas.Click

        Me.cbAreas.DroppedDown = True

    End Sub

    Private Sub CMBAge_Click(sender As Object, e As EventArgs) Handles CMBAge.Click

        Me.CMBAge.DroppedDown = True

    End Sub

    Private Sub CMBAge_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBAge.SelectedIndexChanged

    End Sub

    Private Sub CMBGender_Click(sender As Object, e As EventArgs) Handles CMBGender.Click

        Me.CMBGender.DroppedDown = True

    End Sub

    Private Sub CMBGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBGender.SelectedIndexChanged

    End Sub

    Private Sub frmAddNewPayee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btAddAddress_Click(sender As Object, e As EventArgs) Handles btAddAddress.Click

        Dim Frm As New FrmMessageBox
        Dim Result As String

        If txtAddress.Text = Nothing Then

            Exit Sub

        End If

        search("select * from  BasLocality where LocName = '" & txtAddress.Text & "'")

        If myreader.HasRows Then

            Result = Frm.ShowMessage("Address Already Exist", "TMLCC",
                                 MessageBoxIcon.Information, MessageBoxButtons.OK, Frm)

            Exit Sub

        End If

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try


            cmd.CommandText = "INSERT INTO [BasLocality] ([LocName]) VALUES ('" & txtAddress.Text & "')"

            cmd.ExecuteNonQuery()


            TransOne.Commit()

            conn.Close()

            Dim FrmSave As New FrmMessageBox

            Result = FrmSave.ShowMessage("Operation Complated Sucessfully", "TMLCC",
                                MessageBoxIcon.Information, MessageBoxButtons.OK, FrmSave)

            Call btRefresh_Click(sender, e)

        Catch ex As Exception

            Dim FrmError As New FrmMessageBox

            Result = FrmError.ShowMessage("Please Check Your Data", "TMLCC",
                               MessageBoxIcon.Information, MessageBoxButtons.OK, FrmError)

            TransOne.Rollback()

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub BTClose_Click(sender As Object, e As EventArgs) Handles BTClose.Click

        Hide()

    End Sub

    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub

    Private Sub txtPayeeName_TextChanged(sender As Object, e As EventArgs) Handles txtPayeeName.TextChanged

    End Sub
End Class