Public Class frmCulture

    Public Sub FillChkLists(Optional _chk As Integer = 0)

        search("Select * from BasCultureCodes")

        If myreader.HasRows = True Then

            chksensitive.Items.Clear()
            chkresistant.Items.Clear()

            If _chk = 1 Then

                txtCulture.Text = ""
                txtsensitive.Text = ""
                txtresistant.Text = ""

            End If


            Do
                chksensitive.Items.Add(myreader("CodeID"))
                chkresistant.Items.Add(myreader("CodeID"))

            Loop Until myreader.Read() = False


        End If

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Chksensitive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chksensitive.SelectedIndexChanged

    End Sub

    Private Sub chksensitive_Click(sender As Object, e As EventArgs) Handles chksensitive.Click

        chksensitive.CheckOnClick = True

    End Sub

    Private Sub Chkresistant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkresistant.SelectedIndexChanged

    End Sub

    Private Sub chkresistant_Click(sender As Object, e As EventArgs) Handles chkresistant.Click

        chkresistant.CheckOnClick = True

    End Sub

    Private Sub chksensitive_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chksensitive.ItemCheck
        If e.NewValue = CheckState.Checked Then
            search("Select * from BasCultureCodes where CodeID = '" & chksensitive.SelectedItem.ToString() & "'")
            txtsensitive.AppendText(myreader(2))
            txtsensitive.AppendText(vbCrLf)
        End If
    End Sub

    Private Sub frmCulture_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Call FillChkLists()

    End Sub

    Private Sub chkresistant_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkresistant.ItemCheck
        If e.NewValue = CheckState.Checked Then
            search("Select * from BasCultureCodes where CodeID = '" & chkresistant.SelectedItem.ToString() & "'")
            txtresistant.AppendText(myreader(2))
            txtresistant.AppendText(vbCrLf)
        End If
    End Sub

    Private Sub TxtCulture_TextChanged(sender As Object, e As EventArgs) Handles txtCulture.TextChanged

    End Sub

    Private Sub chksensitive_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles chksensitive.PreviewKeyDown

    End Sub
End Class