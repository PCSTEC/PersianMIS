Public Class frmAddDescribe
    Dim Bus_Person1 As New Bus_Person

    Private Sub frmAddDescribe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If MsgBox("¬Ì« «“ À»  ‘—Õ „Ê—œ ‰Ÿ— „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Bus_Other1.insert_tbHR_Describ(txtDescribe.Text.Trim)
            MsgBox("—ﬂÊ—œ »« „Ê›ﬁÌ  À»  ‘œ", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub
End Class