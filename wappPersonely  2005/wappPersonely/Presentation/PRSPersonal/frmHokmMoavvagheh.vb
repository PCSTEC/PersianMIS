Public Class frmHokmMoavvagheh
    Dim dt_EmployType As New DataTable
    Dim Bus_Person1 As New Bus_Person
    Dim _PersonCode, _PersonID As Integer
    Friend Property PersonCode() As Integer
        Get
            Return _PersonCode
        End Get
        Set(ByVal value As Integer)
            _PersonCode = value
        End Set
    End Property
    Friend Property PersonID() As Integer
        Get
            Return _PersonID
        End Get
        Set(ByVal value As Integer)
            _PersonID = value
        End Set
    End Property

    Private Sub btnNewHokm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewHokm.Click
        If Len(txtMoavvaghehDate.Text) <> 10 Then
            MsgBox("·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        ElseIf txtMoavvaghehDate.Text > IraniDate1.GetIrani8DateStr_CurDate Then
            MsgBox("·ÿ›«  «—ÌŒ „⁄ »— Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            Dim frm As New frmPRSPastOfMoavagheh
            frm.lblPersonCode.Text = lblPersonCode.Text
            frm.lblPersonName.Text = lblPersonName.Text
            frm.lblMoavvaghehDate.Text = txtMoavvaghehDate.Text
            frm.MoavvaghehDate = txtMoavvaghehDate.Text.Trim
            frm.PersonCode = PersonCode
            frm.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmHokmMoavvagheh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class