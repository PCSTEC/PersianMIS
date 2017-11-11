Public Class FrmChangePost
    Dim Bus_MDepart1 As New Bus_MDepart
    Dim Dac_MDepart1 As New Dac_MDepart
    Dim dt_PostType As New DataTable
    Dim dt_Postinfo As New DataTable
    Dim _PostID, _PostTypeCode As Integer
    Friend Property PostID() As Integer
        Get
            Return _PostID
        End Get
        Set(ByVal value As Integer)
            _PostID = value
        End Set
    End Property
    Friend Property PostTypeCode() As Integer
        Get
            Return _PostTypeCode
        End Get
        Set(ByVal value As Integer)
            _PostTypeCode = value
        End Set
    End Property
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub FrmChangePost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub FrmChangePost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fillcombo()
        cmbPostType.SelectedValue = PostTypeCode
    End Sub
    Private Sub Fillcombo()
        dt_PostType = Bus_Post1.GetPostTypeInfo
        Persist1.FillCmb(dt_PostType, cmbPostType, "PostTypeCode", "PostType")
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim frmChart As New frmPRSMainChart
        If txtName.Text = "" Or cmbPostType.Text = "" Then
            MsgBox(" ·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ  ", MsgBoxStyle.OkOnly, " Œÿ« ")
            Exit Sub
        End If
        Bus_Post1.UpdateChangePost(PostID, cmbPostType.SelectedValue, cmbPostType.Text, txtName.Text)
        frmChart.FillMyGridView()
        frmChart.dt_Grid.DefaultView.RowFilter = " DepartCode = '" & frmChart.TrvOrganChart.SelectedNode.Tag & "' "
        Close()
    End Sub
End Class