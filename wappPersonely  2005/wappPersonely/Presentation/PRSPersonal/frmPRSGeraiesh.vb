Public Class frmPRSGeraiesh
    Dim dt_Geraiesh As New DataTable
    Dim Bus_Person1 As New Bus_Person
    Friend frmPRSEducation1 As frmPRSEducation

    Private Sub frmPRSGeraiesh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub frmPRSGeraiesh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillMyGrideView()
    End Sub
    Friend Sub FillMyGrideView()
        dt_Geraiesh.Rows.Clear()
        dt_Geraiesh = Bus_Education1.GeraieshInfo()
        janus1.GetBindJGrid_DT(dt_Geraiesh, grdGeraiesh, ConString)
        janus1.setMyJGrid(grdGeraiesh, "AttitudeName", "‰«„ ê—«Ì‘", 110)
        janus1.setMyJGrid(grdGeraiesh, "BranchTxt", "‰«„ —‘ Â", 110)
        janus1.setMyJGrid(grdGeraiesh, "EducationTypetxt", "‰Ê⁄ —‘ Â", 140)
        janus1.setMyJGrid(grdGeraiesh, "AttitudeID", "", 0, , , False)
        janus1.setMyJGrid(grdGeraiesh, "AttitudeCode", "", 0, , , False)
    End Sub

    Private Sub btnchoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchoice.Click
        frmPRSEducation1.lblAtitude.Text = ""
        frmPRSEducation1.lblAtitude.Text = grdGeraiesh.GetValue("AttitudeName")
        frmPRSEducation1.lblAttitudeID.Text = ""
        frmPRSEducation1.lblAttitudeID.Text = grdGeraiesh.GetValue("AttitudeID")
        frmPRSEducation1.AttitudeID = grdGeraiesh.GetValue("AttitudeID")
        frmPRSEducation1.lblAttitudeCode.Text = ""
        frmPRSEducation1.lblAttitudeCode.Text = grdGeraiesh.GetValue("AttitudeCode")
        frmPRSEducation1.AttitudeCode = grdGeraiesh.GetValue("AttitudeCode")
        Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class