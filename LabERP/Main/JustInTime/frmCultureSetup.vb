Imports System.Drawing.Printing

Public Class frmCultureSetup

    Public AccIDVar As Integer
    Public TXTTemp As String = Nothing

    Dim WithEvents mPrintDocument As New PrintDocument
    Dim mPtintBitMap As Bitmap

    Public Sub RetriveCultureCodes()

        Dim x As Integer = 0

        search("select * from BasCultureCodes")

        If myreader.HasRows = True Then

            dgMain.Rows.Clear()

            Do
                dgMain.Rows.Add()

                dgMain.Rows(x).Cells(0).Value = myreader(0)
                dgMain.Rows(x).Cells(1).Value = myreader(1)
                dgMain.Rows(x).Cells(2).Value = myreader(2)

                x += 1

            Loop Until myreader.Read = False

        End If
    End Sub
    Public Sub CreateDGV()

        Call dgvCreate(dgMain, 1, 20, "ID", False)
        Call dgvCreate(dgMain, 1, 100, "Code", True)
        Call dgvCreate(dgMain, 1, 0, "Description", True)
        Call dgvCreate(dgMain, 4, 70, "Remove", True)

    End Sub

    Private Sub frmPricing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmPricing_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Call CreateDGV()
        Call RetriveCultureCodes()

    End Sub

    Private Sub frmPricing_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Dim Frm As New FrmMessageBox
        Dim Result As String

        Dim x As Integer = 0


        Result = Frm.ShowMessage("Do You Save Changes?", "TMLCC",
                                 MessageBoxIcon.Exclamation, MessageBoxButtons.YesNo, Frm)

        If Result = "Yes" Then

            For Each row As DataGridViewRow In dgMain.Rows

                If dgMain.Rows(x).Cells(0).Value <> Nothing Then

                    search("Select * From BasCultureCodes where ID = " & dgMain.Rows(x).Cells(0).Value & "")

                    If myreader.HasRows = True Then

                        operation("UPDATE [BasCultureCodes] SET [CodeID] = '" &
                                      dgMain.Rows(x).Cells(1).Value & "' , [Description] = '" &
                                      dgMain.Rows(x).Cells(2).Value & "' WHERE [ID]= " &
                                      dgMain.Rows(x).Cells(0).Value & "")

                    End If

                End If

                If dgMain.Rows(x).Cells(0).Value = Nothing Then

                    If dgMain.Rows(x).Cells(1).Value <> Nothing Then

                        operation("INSERT INTO [BasCultureCodes] ([CodeID],[Description]) VALUES ( '" &
                                      dgMain.Rows(x).Cells(1).Value & "' , '" &
                                      dgMain.Rows(x).Cells(2).Value & "')")

                    End If

                End If

                x += 1

                'Else

                '    x += 1

                'End If


            Next

            Dim FrmSave As New FrmMessageBox
            Dim ResultSave As String

            ResultSave = FrmSave.ShowMessage("Changes Saved ....", "TMLCC",
                                                    MessageBoxIcon.Exclamation, MessageBoxButtons.OK, FrmSave)


        ElseIf Result = "No" Then

            '_DeleteTemporaryImages()

            'Hide()

            'frmFrontDisk.Show()

        End If


    End Sub

    Private Sub dgMain_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMain.CellContentClick

        If e.ColumnIndex = 3 Then

            If dgMain.Rows(e.RowIndex).Cells(0).Value <> Nothing Then

                operation("Delete From BasCultureCodes where ID = " & dgMain.Rows(e.RowIndex).Cells(0).Value & "")
                dgMain.Rows.RemoveAt(e.RowIndex)

            End If

        End If
    End Sub

    Private Sub dgMain_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgMain.CellEnter

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

    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click

        Call RetriveCultureCodes()

    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Close()
    End Sub

    Private Sub BtMini_Click(sender As Object, e As EventArgs) Handles btMini.Click
        WindowState = FormWindowState.Minimized

        ShowInTaskbar = True
    End Sub
End Class