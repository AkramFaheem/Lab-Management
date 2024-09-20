Imports System.Data.SqlClient

Public Class frmProfileSetup

    Public AccIDVar As Integer
    Public UserName As String
    Public AccIDType As Integer
    Public UserFullName As String

    Public MonthVar As Integer
    Public YearVar As Integer

    Public SafSelected As String
    Public SafOfUser As String

    Public DisAccVar As String = "Dis1000001"

    Public Prefix As String = "Mov"

    Public ItemIDVar As String = Nothing
    Public LocationNameVar As String

    Public SeedVar As Integer = 1000000

    Public TransInOut As String
    Public LastTransInOut As String
    Public AmountInLetters As String

    Public SafPrefix As String = "Saf"

    Public CashBankVar As String = "Cash"

    Public FromVar As Integer = 0

    Public BankAcc As String

    Dim RateValue As Object
    Dim PercentVar As Object

    Public DollarVar As Object
    Public TransferedDollars As Object

    Public PurInDollarAtChina As Object
    Public PurInSSD As Object

    Public TransID As String
    Public ImportTransID As String

    Public AccountNoVar As String
    Public VenderAccNoVar As String

    Public RecType As Integer
    Public TransType As Integer

    Public TempValue As Double
    Public CoIDVar As Integer

    Public scCustomersAutoComplete As New AutoCompleteStringCollection
    Public scVenderAutoComplete As New AutoCompleteStringCollection

    Public scTransIDAutoComplete As New AutoCompleteStringCollection
    Public scImportAutoComplete As New AutoCompleteStringCollection

    Public scBankNamesAutoComplete As New AutoCompleteStringCollection
    Public scChequeOwnersAutoComplete As New AutoCompleteStringCollection

    Dim MLocation As Point

    Public BranchVar As Integer = 0
    Public BranchTrans As Integer = 0
    Public ChequePrint As Integer = 0

    Public MailBox As String = Nothing
    Public MailClient As String = Nothing
    Public MailPort As Integer = 0
    Public scEmailsAutoComplete As New AutoCompleteStringCollection

    Public FilePath As String = Application.StartupPath & "\temp\" & "Looli.pdf"

    Public _Filename As String = ""
    Public pathname As String = ""

    Public TestID As Integer = Nothing
    Public TestName As String = Nothing

    Public Sub Filldgv(ByVal _TestId As Integer)

        Dim X As Integer = 0

        dgvTestValues.Rows.Clear()

        search("SELECT [TestID],[ValueId],[ValueName],[Ordering] FROM [TestValues] Where [TestID] = " & _TestId & "")

        If myreader.HasRows = True Then

            Do

                dgvTestValues.Rows.Add()

                dgvTestValues.Rows(X).Cells(0).Value = myreader(0)
                dgvTestValues.Rows(X).Cells(1).Value = myreader(1)
                dgvTestValues.Rows(X).Cells(2).Value = myreader(2)
                dgvTestValues.Rows(X).Cells(3).Value = myreader(3)

                X += 1

            Loop Until myreader.Read = False
        End If
    End Sub
    Private Sub ComboFill()

        Call FillCombo(cbTrans, "TestsMaster", "TestName", "TestId", 1)

    End Sub

    Public Sub CreateDGV()

        dgvTestValues.Columns.Clear()

        Call dgvCreate(dgvTestValues, 1, 130, "TestID", False)
        Call dgvCreate(dgvTestValues, 1, 130, "ValueID", False)

        Call dgvCreate(dgvTestValues, 1, 0, "Value Name", True)
        Call dgvCreate(dgvTestValues, 1, 100, "Order", True)

    End Sub

    Private Sub BtMini_Click(sender As Object, e As EventArgs) Handles btMini.Click

        WindowState = FormWindowState.Minimized

        ShowInTaskbar = True

    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles btClose.Click

        Close()

    End Sub

    Private Sub frmTransTypesSetup_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Call ComboFill()
        Call CreateDGV()

    End Sub
    Private Sub cbTrans_Click(sender As Object, e As EventArgs) Handles cbTrans.Click

        cbTrans.DroppedDown = True

    End Sub

    Private Sub cbTrans_DropDownClosed(sender As Object, e As EventArgs) Handles cbTrans.DropDownClosed

        Dim bytImage() As Byte
        pbMain.BackgroundImage = Nothing

        'opencon()

        'TransOne = conn.BeginTransaction

        'cmd.Connection = conn

        'cmd.Transaction = TransOne


        If cbTrans.SelectedValue <> Nothing Then

            search("select RecImage, TestName from TestsMaster where TestId = " & cbTrans.SelectedValue & "")

            Try

                TestID = cbTrans.SelectedValue
                TestName = myreader(1)
                lblTestName.Text = myreader(1)
                txtFamily.Text = myreader(1)

                'If myreader(0) IsNot DBNull.Value Then

                bytImage = CType(myreader(0), Byte())
                Dim ms As New System.IO.MemoryStream(bytImage)
                Dim bmImage As New Bitmap(ms)
                ms.Close()

                pbMain.BackgroundImage = bmImage

                'End If
                'Me.pbEmp.Image = bmImage
                'Me.pbEmp.Refresh()

            Catch ex As Exception

                pbMain.BackgroundImage = Nothing
                'MsgBox(ex.ToString)

            End Try

            Call Filldgv(cbTrans.SelectedValue)




        End If

    End Sub

    Private Sub BtAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click

        Dim Frm As New FrmMessageBox
        Dim Result As String

        If txtFamily.Text = "" Then

            Exit Sub

        End If

        Result = Frm.ShowMessage("Add This Profile", "TMLCC",
                                MessageBoxIcon.Information, MessageBoxButtons.YesNo, Frm)

        If Result = "No" Then

            Exit Sub

        End If

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try



            cmd.CommandText = "INSERT INTO [TestsMaster] ([TestName],[Userid]) VALUES ('" &
                                                         txtFamily.Text & "' , " &
                                                         AccIDVar & ")"

            cmd.ExecuteNonQuery()

            TransOne.Commit()

            conn.Close()

            Dim FrmSave As New FrmMessageBox

            Result = FrmSave.ShowMessage("Profile Added", "TMLCC", MessageBoxIcon.Information, MessageBoxButtons.OK, FrmSave)

            cls()


        Catch ex As Exception

            Dim FrmError As New FrmMessageBox

            Result = FrmError.ShowMessage(ex.Message, "TMLCC", MessageBoxIcon.Information, MessageBoxButtons.OK, FrmError)

            TransOne.Rollback()


        Finally

            conn.Close()

        End Try


    End Sub

    Public Sub cls()

        TestID = Nothing
        TestName = Nothing

        lblTestName.Text = ""
        txtFamily.Text = ""

        Call ComboFill()

        pbMain.BackgroundImage = Nothing
        frmProfilesSetup.GetItemsFamily()

        dgvTestValues.Rows.Clear()

    End Sub

    Private Sub BtExplorer_Click(sender As Object, e As EventArgs) Handles btExplorer.Click

        pbMain.BackgroundImage = Nothing

        Dim _OpenFileDialog As New OpenFileDialog
        Dim _Filter As String = ""

        _Filter = "All Image Files |*.jpg; *.bmp; *.gif; *.png|"
        _Filter &= "*.jpg: JPEG Image |*.jpg|"
        _Filter &= "*.bmp: Windows Bitmap |*.bmp|"
        _Filter &= "*.gif: CompuServe GIF |*.gif|"
        _Filter &= "*.png: Portable Network Graphics |*.png"

        With _OpenFileDialog

            .Filter = _Filter
            .Multiselect = False

            If .ShowDialog(Me) = Windows.Forms.DialogResult.Cancel Then GoTo Exit_Here

            _Filename = .FileName

            If Len(_Filename) = 0 Then GoTo Exit_Here

        End With

        With pbMain

            '.BackgroundImage = Image.FromFile(_Filename)
            .BackgroundImage = Image.FromFile(_Filename)
            .Tag = ""

        End With

        pathname = _Filename

Exit_Here:
    End Sub

    Private Sub BtUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click

        If Not pbMain.BackgroundImage Is Nothing Then

            cmd.CommandText = "UPDATE TestsMaster SET [RecImage] = @ImageData  WHERE TestId = '" & cbTrans.SelectedValue & "'"


            Dim bytImage() As Byte
            Dim ms As New System.IO.MemoryStream
            Dim bmpImage As New Bitmap(pbMain.BackgroundImage)

            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            bytImage = ms.ToArray()
            ms.Close()

            cmd.Parameters.Add(New SqlParameter("@ImageData", DirectCast(bytImage, Object)))
            'cmd.Parameters.Add(New sqlParameter("@RecImage", bytImage))
            'cmd.Parameters("@RecImage").Value = bytImage
            cmd.ExecuteNonQuery()


            cmd.Parameters.Clear()

        End If

    End Sub

    Private Sub DgvTestValues_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTestValues.CellContentClick

    End Sub

    Private Sub dgvTestValues_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTestValues.CellEnter

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

    Private Sub dgvTestValues_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvTestValues.CellBeginEdit


        If e.ColumnIndex = 2 Then

            dgvTestValues.CurrentCell = dgvTestValues(3, e.RowIndex)

        End If

    End Sub

    Private Sub dgvTestValues_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTestValues.CellEndEdit

        If e.ColumnIndex = 3 Then

            Try

                If dgvTestValues.Rows(e.RowIndex).Cells(1).Value <> Nothing Then

                    operation("UPDATE [TestValues] SET [Ordering] = " &
                                             dgvTestValues.Rows(e.RowIndex).Cells(3).Value & " WHERE [ValueId] =  " &
                                             dgvTestValues.Rows(e.RowIndex).Cells(1).Value & "")
                End If

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub CbTrans_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTrans.SelectedIndexChanged

    End Sub

    Private Sub PanelGRUD_Paint(sender As Object, e As PaintEventArgs) Handles PanelGRUD.Paint

    End Sub

    Private Sub BtUpdateName_Click(sender As Object, e As EventArgs) Handles btUpdateName.Click

        Dim Frm As New FrmMessageBox
        Dim Result As String

        If txtFamily.Text = "" Or TestID = Nothing Or TestName = Nothing Then

            Exit Sub

        End If

        If txtFamily.Text = TestName Then

            cls()

            Exit Sub

        End If

        Result = Frm.ShowMessage("Update Above Profile Name", "TMLCC",
                                MessageBoxIcon.Information, MessageBoxButtons.YesNo, Frm)

        If Result = "No" Then

            Exit Sub

        End If

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try



            cmd.CommandText = "Update [TestsMaster] set [TestName] = '" &
                                                         txtFamily.Text & "' where TestID = " &
                                                         TestID & ""

            cmd.ExecuteNonQuery()

            TransOne.Commit()

            conn.Close()

            Dim FrmSave As New FrmMessageBox

            Result = FrmSave.ShowMessage("Profile Updated", "TMLCC", MessageBoxIcon.Information, MessageBoxButtons.OK, FrmSave)

            cls()


        Catch ex As Exception

            Dim FrmError As New FrmMessageBox

            Result = FrmError.ShowMessage(ex.Message, "TMLCC", MessageBoxIcon.Information, MessageBoxButtons.OK, FrmError)

            TransOne.Rollback()


        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub BtDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click

        Dim Frm As New FrmMessageBox
        Dim Result As String

        If TestID = Nothing Or TestName = Nothing Then

            Exit Sub

        End If


        Result = Frm.ShowMessage("Remove Profile and All Related Tests", "TMLCC",
                                MessageBoxIcon.Information, MessageBoxButtons.YesNo, Frm)

        If Result = "No" Then

            Exit Sub

        End If

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try

            cmd.CommandText = "Delete From [TestValues]  where TestID = " & TestID & ""

            cmd.ExecuteNonQuery()

            cmd.CommandText = "Delete From [TestsMaster]  where TestID = " & TestID & ""

            cmd.ExecuteNonQuery()

            TransOne.Commit()

            conn.Close()

            Dim FrmSave As New FrmMessageBox

            Result = FrmSave.ShowMessage("Profile Removed", "TMLCC", MessageBoxIcon.Information, MessageBoxButtons.OK, FrmSave)

            cls()


        Catch ex As Exception

            Dim FrmError As New FrmMessageBox

            Result = FrmError.ShowMessage(ex.Message, "TMLCC", MessageBoxIcon.Information, MessageBoxButtons.OK, FrmError)

            TransOne.Rollback()


        Finally

            conn.Close()

        End Try

    End Sub
End Class