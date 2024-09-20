Public Class FrmCanregsetup
    Public CanRegID As Integer = 0
    Public TestId As Integer = 0

    Private Sub BtMini_Click(sender As Object, e As EventArgs) Handles btMini.Click

        WindowState = FormWindowState.Minimized

        ShowInTaskbar = True

    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles btClose.Click

        Close()

    End Sub
    Private Sub ComboFill()

        Call FillCombo(CbProfile, "TestsMaster", "TestName", "TestId", 1, 3, "TestId", 1, "TestId", 2)

    End Sub
    Public Sub CreateDGV()

        DGVCanList.Columns.Clear()

        Call dgvCreate(DGVCanList, 1, 0, "No", False)
        Call dgvCreate(DGVCanList, 1, 100, "Code", True)
        Call dgvCreate(DGVCanList, 1, 0, "Description", True)
        Call dgvCreate(DGVCanList, 4, 70, "Select", True)

    End Sub

    Public Sub GetCanlist()

        Dim x As Integer = 0



        search("SELECT [CanRegID],[InternationalCode],[Description],[TestId] FROM [BasCancers] ")

        If myreader.HasRows = True Then

            DGVCanList.Rows.Clear()

            Do

                DGVCanList.Rows.Add()

                DGVCanList.Rows(x).Cells(0).Value = myreader(0)
                DGVCanList.Rows(x).Cells(1).Value = myreader(1)
                DGVCanList.Rows(x).Cells(2).Value = myreader(2)


                x += 1

            Loop Until myreader.Read = False


        End If

    End Sub
    Private Sub FrmCanregsetup_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated

        Call CreateDGV()
        Call GetCanlist()
        Call ComboFill()
        BtSave.Enabled = True
        BtUpdate.Enabled = False
        BtDelete.Enabled = False
        CbProfile.Text = "Please select profile"
    End Sub

    Private Sub DGVCanList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCanList.CellContentClick

        Dim Frm As New FrmMessageBox

        Dim x As Integer = 0

        If DGVCanList.Rows.Count > 0 Then

            x = DGVCanList.Rows.Count

        End If

        If e.ColumnIndex = 3 Then

            BtSave.Enabled = False
            BtUpdate.Enabled = True
            BtDelete.Enabled = True

            If DGVCanList.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                search("select * from BasCancers where CanRegID = " & DGVCanList.Rows(e.RowIndex).Cells(0).Value & "")

                If myreader.HasRows = True Then

                    CanRegID = myreader(0)
                    TXTDescription.Text = myreader(2).ToString
                    TXTCode.Text = myreader(1).ToString
                    TestId = myreader(4)

                    SerTemp("select TestName from TestsMaster where TestId = " & TestId & "")
                    If TempReader.HasRows Then

                        CbProfile.Text = TempReader(0)

                    End If


                End If

            End If

        End If

    End Sub

    Private Sub BTNew_Click(sender As Object, e As EventArgs) Handles BTNew.Click

        CLS()

    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click

        Dim Frm As New FrmMessageBox
        Dim Result As String


        If TXTDescription.Text = Nothing Or TXTCode.Text = Nothing Or CbProfile.Text = "Please select category" Then

            Result = Frm.ShowMessage("Description,code, Category fields are required! ", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.OK, Frm)

            TXTDescription.Focus()
            Exit Sub

        End If

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try

            Call ShowProgress("Saving new cancer code", MessageDirection.Right, 2000)

            cmd.CommandText = "INSERT INTO [BasCancers] ([InternationalCode],[Description],[TestId]) VALUES ('" &
                                                                      TXTCode.Text & "' , '" &
                                                                      TXTDescription.Text & "' , '" &
                                                                      CbProfile.SelectedValue & "')"
            cmd.ExecuteNonQuery()

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

    Public Sub CLS()

        CanRegID = 0
        TestId = 0
        TXTDescription.Text = Nothing
        TXTCode.Text = Nothing
        CbProfile.Text = "Please select category"
        BtSave.Enabled = True
        BtUpdate.Enabled = False
        BtDelete.Enabled = False

        DGVCanList.Rows.Clear()

        Call GetCanlist()

    End Sub

    Private Sub BtUpdate_Click(sender As Object, e As EventArgs) Handles BtUpdate.Click
        Dim Frm As New FrmMessageBox
        Dim Result As String

        If TXTCode.Text = Nothing Or TXTDescription.Text = Nothing Or CbProfile.Text = "Please select category" Then

            Result = Frm.ShowMessage("Description,code, Category fields are required! ", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.OK, Frm)

            TXTDescription.Focus()
            Exit Sub

        End If


        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try

            Call ShowProgress("Updating cancer code ", MessageDirection.Right, 2000)

#Region "Saving Data Entered"

            cmd.CommandText = "UPDATE [BasCancers] SET [InternationalCode] = '" &
                                             TXTCode.Text & "' , [Description] ='" &
                                             TXTDescription.Text & "' , [TestId] = '" &
                                             CbProfile.SelectedValue & "' WHERE [CanRegID] = " &
                                             CanRegID & ""
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

    Private Sub BtDelete_Click(sender As Object, e As EventArgs) Handles BtDelete.Click
        Dim Frm As New FrmMessageBox
        Dim Result As String


        Result = Frm.ShowMessage("Are you sure you want to delete this code? previous records assinged by this code will not be affected by this operation", "TMLCC",
                            MessageBoxIcon.Warning, MessageBoxButtons.YesNo, Frm)

        If Result = "No" Then

            Exit Sub

        End If

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try

            Call ShowProgress("Deleting cancer registry code", MessageDirection.Right, 2000)

#Region "Delete Data"

            cmd.CommandText = "Delete From [BasCancers] WHERE [CanRegID] = " & CanRegID & ""

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

    Private Sub FrmCanregsetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class