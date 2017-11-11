Public Class frmPRSStudyPlace
    Dim dt_StudyPlace As New DataTable
    Dim Bus_Person1 As New Bus_Person
    Dim janus1 As New JFrameWork.JanusGrid
    Friend frmPRSEducation1 As frmPRSEducation

    Private Sub frmPRSStudyPlace_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmPRSStudyPlace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillMyGrideView()
    End Sub
    Friend Sub FillMyGrideView()
        dt_StudyPlace.Rows.Clear()
        dt_StudyPlace = Bus_Education1.StudyPlaceInfo()
        janus1.GetBindJGrid_DT(dt_StudyPlace, grdStudyPlace, ConString)
        janus1.setMyJGrid(grdStudyPlace, "StudyPlacetxt", "‰«„ „Õ·  Õ’Ì·", 100)
        janus1.setMyJGrid(grdStudyPlace, "StudyPlaceType", "‰Ê⁄ „Õ·  Õ’Ì·", 100)
        janus1.setMyJGrid(grdStudyPlace, "Citytxt", "‰«„ ‘Â—", 90)
        janus1.setMyJGrid(grdStudyPlace, "Countrytxt", "‰«„ ﬂ‘Ê—", 90)
        janus1.setMyJGrid(grdStudyPlace, "StudyPlaceCode", "", 0, , , False)
        janus1.setMyJGrid(grdStudyPlace, "StudyPlaceID", "", 0, , , False)
    End Sub

    Private Sub btnchoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchoice.Click
        frmPRSEducation1.lblStudyPlace.Text = grdStudyPlace.GetValue("StudyPlacetxt")
        frmPRSEducation1.StudyPlaceCode = grdStudyPlace.GetValue("StudyPlaceCode")
        frmPRSEducation1.lblStudyPlaceCode.Text = Str(grdStudyPlace.GetValue("StudyPlaceCode"))
        frmPRSEducation1.lblStudyPlaceID.Text = Str(grdStudyPlace.GetValue("StudyPlaceID"))
        frmPRSEducation1.StudyPlaceID = grdStudyPlace.GetValue("StudyPlaceID")
        Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class