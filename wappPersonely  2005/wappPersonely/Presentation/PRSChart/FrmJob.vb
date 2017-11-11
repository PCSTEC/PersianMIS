Public Class FrmJob
    Dim dt_Job, dt_Group, dt_Diplom As DataTable
    Private Sub FrmJob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
        Fillcombo()
    End Sub
    Private Sub Fillcombo()

        SqlStr = "SELECT     JobTitleID, JobTitletxt, GroupID, DiplomaCode, Experience, JobTitleEduScore_ˆDel, JobTitleExpScore_ˆDel, JobTitleTotalScore_ˆDel,    JobTitleJobSel_ˆDel, JobtitleCode_Del FROM         dbo.tbHR_JobTitle"
        dt_Job = Persist1.GetDataTable(ConString, SqlStr)
        Persist1.FillCmb(dt_Job, cmbJobTitle, "JobTitleID", "JobTitletxt")


        SqlStr = "SELECT     GroupID, GroupSelect FROM         dbo.tbHR_Group"
        dt_Group = Persist1.GetDataTable(ConString, SqlStr)
        Persist1.FillCmb(dt_Group, cmbGroup, "GroupID", "GroupID")


        SqlStr = "SELECT     DiplomaID, DiplomaCode, DiplomaName FROM         dbo.tbHR_Diploma"
        dt_Diplom = Persist1.GetDataTable(ConString, SqlStr)
        Persist1.FillCmb(dt_Diplom, CmbDiplom, "DiplomaID", "DiplomaName")


    End Sub
    Private Sub fillgrid()

        Dim janus1 As New JFrameWork.JanusGrid


        SqlStr = "SELECT      tbHR_JobTitle.JobTitleID, tbHR_JobTitle.JobTitletxt, tbHR_JobTitle.GroupID, tbHR_JobTitle.DiplomaCode, tbHR_JobTitle.Experience,  " & _
                 "                      tbHR_Diploma.DiplomaName " & _
                "FROM         tbHR_JobTitle INNER JOIN " & _
                "                      tbHR_Diploma ON tbHR_JobTitle.DiplomaCode = tbHR_Diploma.DiplomaCode"
        dt_Job = Persist1.GetDataTable(ConString, SqlStr)
        janus1.GetBindJGrid_DT(dt_Job, grdPerson, ConString)
        janus1.setMyJGrid(grdPerson, "JobTitleID", "ﬂœ", 75)
        janus1.setMyJGrid(grdPerson, "JobTitletxt", "‰«„ ‘€·", 200)
        janus1.setMyJGrid(grdPerson, "GroupID", "ê—ÊÂ", 95)
        janus1.setMyJGrid(grdPerson, "DiplomaCode", "ﬂœ  Õ’Ì·", 75)
        janus1.setMyJGrid(grdPerson, "DiplomaName", "„œ—ﬂ  Õ’Ì·", 150)
        janus1.setMyJGrid(grdPerson, "Experience", " Ã—»Â", 150)
    End Sub
End Class