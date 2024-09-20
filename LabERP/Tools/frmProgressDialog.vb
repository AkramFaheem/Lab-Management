Imports System
Imports System.Windows.Forms

Public Class frmProgressDialog

    Private Async Sub Flash()
        For i = 0 To 2
            Await Task.Delay(500)

            'lblMessage.Visible = Not lblMessage.Visible


            lblMessage.Visible = False

            'lblMessage.Text = "Please Wait"

        Next

        'set .Visible to True just to be sure
        lblMessage.Visible = True

        lblMessage.ForeColor = Color.Black

        'lblMessage.Text = "Please Wait"

    End Sub

    Public Sub UpdateProgress(progress As Integer)
        If progressBar1.InvokeRequired Then
            progressBar1.BeginInvoke(New Action(Function() progressBar1.Value = progress))
        Else
            progressBar1.Value = progress
        End If

    End Sub

    Public Sub SetIndeterminate(isIndeterminate As Boolean)
        If progressBar1.InvokeRequired Then

            progressBar1.BeginInvoke(New Action(Function()
                                                    If isIndeterminate Then
                                                        progressBar1.Style = ProgressBarStyle.Marquee
                                                    Else
                                                        progressBar1.Style = ProgressBarStyle.Blocks
                                                    End If

                                                End Function))
        Else
            If isIndeterminate Then
                progressBar1.Style = ProgressBarStyle.Marquee
            Else
                progressBar1.Style = ProgressBarStyle.Blocks
            End If
        End If

    End Sub

    Private Sub ProgressDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblMessage_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblMessage.LinkClicked

    End Sub
End Class