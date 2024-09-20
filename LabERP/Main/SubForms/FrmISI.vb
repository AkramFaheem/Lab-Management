Public Class FrmISI
    Public ID As Integer = Nothing
    Public IsActive As Boolean = False
    Private Sub TXTISIValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTISIValue.KeyPress
        'Accept only Decimal number
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))

    End Sub

    Private Sub BTNew_Click(sender As Object, e As EventArgs) Handles BTNew.Click

        BtSave.Enabled = True
        CHKIsActive.CheckState = False
        BTUpdate.Enabled = False
        BTDelete.Enabled = False
        TXTISIValue.Text = Nothing

    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click

        If TXTISIValue.Text = Nothing Then

            MsgBox("Please provide ISI Value", vbOK, "TMLCC Lab system")

            TXTISIValue.Focus()
            Exit Sub

        End If


        If CHKIsActive.CheckState = CheckState.Checked Then

            IsActive = True

            Call RestRec()

            opencon()

            TransOne = conn.BeginTransaction

            cmd.Connection = conn

            cmd.Transaction = TransOne

            Try

                cmd.CommandText = "INSERT INTO [ISIValue] ([IsIValue],[IsActive]) VALUES ('" &
                                                                          TXTISIValue.Text & "' , '" &
                                                                          IsActive & "')"
                cmd.ExecuteNonQuery()

                TransOne.Commit()

                MsgBox("ISI Value Saved successfuly", vbInformation, "TMLCC Lab System")

                Call CLS()


            Catch ex As Exception

                MsgBox(ex.Message, vbInformation, "TMLCC Lab System")

                TransOne.Rollback()

            Finally

                conn.Close()

            End Try
            Exit Sub

        Else

            opencon()

            TransOne = conn.BeginTransaction

            cmd.Connection = conn

            cmd.Transaction = TransOne

            Try

                cmd.CommandText = "INSERT INTO [ISIValue] ([IsIValue],[IsActive]) VALUES ('" &
                                                                          TXTISIValue.Text & "' , '" &
                                                                          IsActive & "')"
                cmd.ExecuteNonQuery()

                TransOne.Commit()

                MsgBox("ISI Value Saved successfuly", vbInformation, "TMLCC Lab System")

                Call CLS()


            Catch ex As Exception

                MsgBox(ex.Message, vbInformation, "TMLCC Lab System")

                TransOne.Rollback()

            Finally

                conn.Close()

            End Try
            Exit Sub

        End If


    End Sub
    Public Sub CLS()

        TXTISIValue.Text = Nothing
        BtSave.Enabled = True
        BTUpdate.Enabled = False
        BTDelete.Enabled = False

        DGVISIValue.Rows.Clear()

        Call GetISIValues()

    End Sub

    Private Sub FrmISI_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated

        Call CreateDGV()
        Call GetISIValues()
        'BtSave.Enabled = True
        'BTUpdate.Enabled = False
        'BTDelete.Enabled = False


    End Sub

    Public Sub CreateDGV()

        DGVISIValue.Columns.Clear()

        Call dgvCreate(DGVISIValue, 1, 40, "ID", True)
        Call dgvCreate(DGVISIValue, 1, 80, "ISI Value", True)
        Call dgvCreate(DGVISIValue, 1, 90, "Is Active", True)
        Call dgvCreate(DGVISIValue, 4, 88, "Select", True)

    End Sub

    Public Sub GetISIValues()

        Dim x As Integer = 0



        search("SELECT [ID],[IsIValue],[IsActive] FROM [ISIValue] ")

        If myreader.HasRows = True Then

            DGVISIValue.Rows.Clear()

            Do

                DGVISIValue.Rows.Add()

                DGVISIValue.Rows(x).Cells(0).Value = myreader(0)
                DGVISIValue.Rows(x).Cells(1).Value = myreader(1)
                DGVISIValue.Rows(x).Cells(2).Value = myreader(2)
                x += 1

            Loop Until myreader.Read = False


        End If

    End Sub

    Private Sub BTUpdate_Click(sender As Object, e As EventArgs) Handles BTUpdate.Click

        If TXTISIValue.Text = Nothing Then

            MsgBox("Please provide ISI Value", vbOK, "TMLCC Lab system")

            TXTISIValue.Focus()
            Exit Sub

        End If

        If CHKIsActive.CheckState = CheckState.Checked Then
            IsActive = True
        End If

        Call RestRec()

        opencon()
        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try


#Region "Saving Data Entered"

            cmd.CommandText = "UPDATE [ISIValue] Set [IsIValue] = '" &
                                             TXTISIValue.Text & "' , [IsActive] ='" &
                                             IsActive & "' WHERE [ID] = " &
                                             ID & ""
            cmd.ExecuteNonQuery()



#End Region

            TransOne.Commit()


            Call CLS()


        Catch ex As Exception

            MsgBox(ex.Message, vbInformation, "TMLCC Lab System")

            TransOne.Rollback()

        Finally

            conn.Close()

        End Try
    End Sub

    Public Sub RestRec()


        openconTemp()

        TransTemp = connTemp.BeginTransaction

        cmd.Connection = connTemp

        cmd.Transaction = TransTemp

        Try




            cmd.CommandText = "UPDATE [ISIValue] Set  [IsActive] ='" &
                                             False & "'"
            cmd.ExecuteNonQuery()


            TransTemp.Commit()

        Catch ex As Exception

            MsgBox(ex.Message, vbInformation, "TMLCC Lab System")

            TransTemp.Rollback()

        Finally

            connTemp.Close()

        End Try


    End Sub

    Private Sub BTDelete_Click(sender As Object, e As EventArgs) Handles BTDelete.Click

        Dim Result As String


        Result = MsgBox("Delete this ISI Value ?", vbYesNoCancel, "TMLCC Lab System")

        If Result = vbNo Or Result = vbCancel Then

            Exit Sub

        End If

        opencon()

        TransOne = conn.BeginTransaction

        cmd.Connection = conn

        cmd.Transaction = TransOne

        Try



#Region "Delete Data"

            cmd.CommandText = "Delete From [ISIValue] WHERE [ID] = " & ID & ""

            cmd.ExecuteNonQuery()



#End Region

            TransOne.Commit()

            Call CLS()

        Catch ex As Exception

            MsgBox(ex.Message, vbInformation, "TMLCC Lab System")

            TransOne.Rollback()

        Finally

            conn.Close()

        End Try
    End Sub

    Private Sub DGVISIValue_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVISIValue.CellContentClick
        Dim x As Integer = 0

        If DGVISIValue.Rows.Count > 0 Then

            x = DGVISIValue.Rows.Count

        End If

        If e.ColumnIndex = 3 Then

            BtSave.Enabled = False
            BTUpdate.Enabled = True
            BTDelete.Enabled = True

            If DGVISIValue.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                search("select * from ISIValue where ID = " & DGVISIValue.Rows(e.RowIndex).Cells(0).Value & "")

                If myreader.HasRows = True Then

                    ID = myreader(0)
                    TXTISIValue.Text = myreader(1).ToString
                    If myreader(2) = True Then

                        CHKIsActive.CheckState = CheckState.Checked
                    Else
                        CHKIsActive.CheckState = CheckState.Unchecked
                    End If

                End If

            End If

        End If
    End Sub

    Private Sub FrmISI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click

        BtSave.Enabled = True
        CHKIsActive.CheckState = False
        BTUpdate.Enabled = False
        BTDelete.Enabled = False
        TXTISIValue.Text = Nothing
    End Sub

    Private Sub BtMini_Click(sender As Object, e As EventArgs) Handles btMini.Click
        WindowState = FormWindowState.Minimized

        ShowInTaskbar = True
    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Close()
    End Sub
End Class