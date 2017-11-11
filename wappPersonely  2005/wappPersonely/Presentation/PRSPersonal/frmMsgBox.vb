Public Class frmMsgBox

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        Dim frm As New frmPRSAlarm
        frm.ShowDialog()
        Me.Close()
    End Sub
End Class