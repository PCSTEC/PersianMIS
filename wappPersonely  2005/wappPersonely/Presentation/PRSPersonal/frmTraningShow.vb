Public Class frmTraningShow
    Public personcode As Long
    Dim dt As New DataTable
    Dim cnt As Integer
    Private Sub frmTraningShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        i = 0
        SqlStr = "SELECT    id, PersonID, PersonImage   FROM training..tbTRNGavihiPicture WHERE(PersonID = " & personcode & ")"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If dt.DefaultView.Count > 0 Then
            PicCertificate.Image = pic1.getImageBuffer_Load(dt.DefaultView.Item(i).Item("PersonImage"))
        End If
        cnt = dt.DefaultView.Count
        Me.Text = Me.Text + "-" + Str(i)


    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If i < 0 Then
            Exit Sub
        End If
        i = i + 1
        If i > cnt - 1 Then
            i = i - 1
            Exit Sub
        End If
        PicCertificate.Image = pic1.getImageBuffer_Load(dt.DefaultView.Item(i).Item("PersonImage"))
        Me.Text = Me.Text + "-" + Str(i)
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        i = i - 1
        If i < 0 Then
            i = i + 1
            Exit Sub
        End If
        If i > cnt Then
            Exit Sub
        End If
        PicCertificate.Image = pic1.getImageBuffer_Load(dt.DefaultView.Item(i).Item("PersonImage"))
        Me.Text = Me.Text + "-" + Str(i)
    End Sub
End Class