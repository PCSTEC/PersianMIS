Public Class frmPassForSale
    Public PrCode As Long

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim dt As New DataTable
        SqlStr = "SELECT     TOP (200) id, UserName, Pass  FROM         tbARZ_Pasword  WHERE     (Pass = N'" & TextBox1.Text & "')"

        dt = Persist1.GetDataTable(ConString, SqlStr)

        If dt.DefaultView.Count > 0 Then
            Dim frm As New frmPRSSale
            frm.PersonCode = PrCode
            frm.ShowDialog()
            TextBox1.Text = ""
        Else
            MsgBox("شما مجوز ندارید")
        End If
    End Sub
End Class