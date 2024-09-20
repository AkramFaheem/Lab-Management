Imports i00SpellCheck

Public Class frmHistoComplate
    Private Sub TxtReport_TextChanged(sender As Object, e As EventArgs) Handles txtReport.TextChanged

    End Sub

    Private Sub ComboFill()

        Call FillCombo(cbCancer, "BasCancers", "InternationalCode", "CanRegID", 1)

    End Sub
    Private Sub frmHistoComplate_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        EnableControlExtensions()

        Call ComboFill()

    End Sub

    Private Sub CbCancer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCancer.SelectedIndexChanged

    End Sub

    Private Sub cbCancer_Click(sender As Object, e As EventArgs) Handles cbCancer.Click

        cbCancer.DroppedDown = True

    End Sub

    Private Sub frmHistoComplate_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        If Visible = False Then

            DisableSpellCheck

        End If

    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        FrmCanregsetup.Show()
    End Sub
End Class