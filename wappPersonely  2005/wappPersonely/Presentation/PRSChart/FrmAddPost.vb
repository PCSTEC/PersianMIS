Public Class FrmAddPost
    Dim Bus_MDepart1 As New Bus_MDepart
    Dim dt_PostType As New DataTable
    Dim dt_Grid As New DataTable
    Dim dt_Grid1 As New DataTable
    Dim _PostCode As String
    Dim dt_PostTypeCount As DataTable
    Dim _DepartCode As String
    Dim _DepartID As Integer
    Friend Property DepartCode() As String
        Get
            Return _DepartCode
        End Get
        Set(ByVal value As String)
            _DepartCode = value
        End Set
    End Property
    Friend Property DepartID() As Integer
        Get
            Return _DepartID
        End Get
        Set(ByVal value As Integer)
            _DepartID = value
        End Set
    End Property
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or cmbPostType.Text = "" Then
            MsgBox(" áØÝÇ ãÞÇÏíÑ ÑÇ ÏÑÓÊ æÇÑÏ äãÇííÏ ", MsgBoxStyle.Information)
            Exit Sub
        End If
        If MsgBox("ÂíÇ ÇÒ ÏÑÌ ÓÊ " & "(( " & txtName.Text & " ))" & "ãØãÆä åÓÊíÏ ¿ ", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Bus_Post1.InsertPost(lblPostCodePishnahadi.Text.Trim, lblPostDepartID.Text.Trim, Val(lblPostTypeID.Text.Trim), cmbPostType.SelectedValue, txtName.Text.Trim, True, DepartCode)
            Close()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
    Friend Sub Fillcombo()
        dt_PostType = Bus_Post1.GetPostTypeInfo
        Persist1.FillCmb(dt_PostType, cmbPostType, "PostTypeCode", "postTitle")
    End Sub
    Private Sub FrmAddPost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub FrmAddPost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fillcombo()
    End Sub

    Private Sub cmbPostType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPostType.SelectedValueChanged
        Try
            PostCodePishnahadi()
        Catch ex As Exception

        End Try
    End Sub
    Friend Sub PostCodePishnahadi()
        Dim dt As New DataTable
        Dim sqlstr1, sqlstr2 As String
        Dim i As Integer
        sqlstr2 = _
                       "SELECT dbo.tbHR_Post.DepartID, dbo.tbHR_PostType.PostTypeCode " & _
                       "FROM dbo.tbHR_Post INNER JOIN " & _
                       " dbo.tbHR_PostType ON dbo.tbHR_Post.PostTypeID = dbo.tbHR_PostType.PostTypeID " & _
                       "WHERE     (dbo.tbHR_Post.DepartID = " & DepartID & ") AND (dbo.tbHR_PostType.PostTypeCode = " & cmbPostType.SelectedValue & ")"
        dt_PostTypeCount = Persist1.GetDataTable(ConString, sqlstr2)
        sqlstr1 = _
                  "SELECT     PostTypeID " & _
                    "FROM         dbo.tbHR_PostType " & _
                      "WHERE     (PostTypeCode = " & cmbPostType.SelectedValue & ")"
        dt = Persist1.GetDataTable(ConString, sqlstr1)
        lblPostTypeID.Text = dt.DefaultView.Item(0).Item("PostTypeID")
        i = (dt_PostTypeCount.Rows.Count) + 1
        lblPostCodePishnahadi.Visible = True
        If cmbPostType.SelectedValue > 9 And i > 9 Then
            lblPostCodePishnahadi.Text = Mid(lblPostCodePishnahadi.Text, 1, 6).Trim + Str(cmbPostType.SelectedValue).Trim + Str(i).Trim
        ElseIf cmbPostType.SelectedValue <= 9 And i > 9 Then
            lblPostCodePishnahadi.Text = Mid(lblPostCodePishnahadi.Text, 1, 6).Trim + "0" + Str(cmbPostType.SelectedValue).Trim + Str(i).Trim
        ElseIf cmbPostType.SelectedValue <= 9 And i <= 9 Then
            lblPostCodePishnahadi.Text = Mid(lblPostCodePishnahadi.Text, 1, 6).Trim + "0" + Str(cmbPostType.SelectedValue).Trim + "0" + Str(i).Trim
        ElseIf cmbPostType.SelectedValue > 9 And i <= 9 Then
            lblPostCodePishnahadi.Text = Mid(lblPostCodePishnahadi.Text, 1, 6).Trim + Str(cmbPostType.SelectedValue).Trim + "0" + Str(i).Trim
        End If
        dt_PostTypeCount.Rows.Clear()
    End Sub

    Friend Sub FillgrdPerson(ByVal Sel As SelectStr)
        Dim janus1 As New JFrameWork.JanusGrid
        Dim dt_post As New DataTable

        SqlStr = "SELECT     PostsarID, PostID, PostSarparstiFee, FeeDateBegin  FROM         dbo.tbHR_PostSarparastiFee  WHERE     (PostID = " & cmbPostType.SelectedValue & ")"
        dt_post = Persist1.GetDataTable(ConString, SqlStr)

        janus1.GetBindJGrid_DT(dt_post, grdPost, ConString)
        janus1.setMyJGrid(grdPost, "PostsarID", "ßÏ", 75)
        janus1.setMyJGrid(grdPost, "PostSarparstiFee", "ÍÞ ÓÑÑÓÊí", 95)
        janus1.setMyJGrid(grdPost, "FeeDateBegin", "ÊÇÑíÎ ÔÑæÚ", 120)
        
    End Sub

End Class