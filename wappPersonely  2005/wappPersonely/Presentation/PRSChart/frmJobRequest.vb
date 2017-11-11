Public Class frmJobRequest
    Dim Bus_Person1 As New Bus_Person
    Dim Bus_MDepart1 As New Bus_MDepart
    Dim dt_City, dt_Person, dt_EducationType, dt_AttitudeInfo, dt_Military, dt_Diploma, dt_MDepartInfo As New DataTable

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmJobRequest_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmJobRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCombo()
        FillMyGrid()

        ''''‰Ÿ— ”‰ÃÌ
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''

    End Sub

    Friend Sub FillMyGrid()
        dt_Person = Bus_Person1.GetJobRequestInfo
        janus1.GetBindJGrid_DT(dt_Person, grdPerson, ConString)
        janus1.setMyJGrid(grdPerson, "FormID", "‘„«—Â Å—Ê‰œÂ", 75)
        janus1.setMyJGrid(grdPerson, "Name", "‰«„", 125)
        janus1.setMyJGrid(grdPerson, "FatherName", "‰«„ Åœ—", 75)
        janus1.setMyJGrid(grdPerson, "BirthDate", " «—ÌŒ  Ê·œ", 85)
        janus1.setMyJGrid(grdPerson, "IDNumber", "‘„«—Â ‘‰«”‰«„Â", 75)
        janus1.setMyJGrid(grdPerson, "Madrak", " Õ’Ì·« ", 150)
        janus1.setMyJGrid(grdPerson, "MilitaryStateName", "Ê÷⁄Ì  ”—»«“Ì", 75)
        janus1.setMyJGrid(grdPerson, "MDepart", "Ê«Õœ „—»ÊÿÂ", 150)
        janus1.setMyJGrid(grdPerson, "Tel", " ·›‰", 75)
        janus1.setMyJGrid(grdPerson, "Citytxt", "„Õ·  Ê·œ", 0, , , False)
        janus1.setMyJGrid(grdPerson, "FirstName", "‰«„", 0, , , False)
        janus1.setMyJGrid(grdPerson, "LastName", "‰«„ Œ«‰Ê«œêÌ", 0, , , False)
        janus1.setMyJGrid(grdPerson, "CityCode", "ﬂœ ‘Â— „Õ·  Ê·œ", 0, , , False)
        janus1.setMyJGrid(grdPerson, "NationalCode", "ﬂœ „·Ì", 0, , , False)
        janus1.setMyJGrid(grdPerson, "Mobile", "„Ê»«Ì·", 0, , , False)
        janus1.setMyJGrid(grdPerson, "MilitaryStateID", "ﬂœ Ê÷⁄Ì  Œœ„ ", 0, , , False)
    End Sub

    Friend Sub FillCombo()
        dt_City = Bus_City1.GetCityIfos
        Persist1.FillCmb(dt_City, cmbBirthCity, "CityID", "Citytxt")
        dt_Military = Bus_Other1.GetMilitaryIfo
        Persist1.FillCmb(dt_Military, cmbMilitary, "MilitaryStateID", "MilitaryStateName")
        dt_Diploma = Bus_Education1.GetDiplomaInfo
        Persist1.FillCmb(dt_Diploma, cmbDiploma, "DiplomaCode", "DiplomaName")
        dt_MDepartInfo = Bus_MDepart1.GetMDepartInfo
        Persist1.FillCmb(dt_MDepartInfo, cmbMDepartCode, "DepartCode", "DepartName")
        dt_AttitudeInfo = Bus_Education1.GetAttitudeInfo
        Persist1.FillCmb(dt_AttitudeInfo, cmbAttitudeID, "AttitudeID", "AttitudeName")
        dt_EducationType = Bus_Education1.GetEducationTypeInfo
        Persist1.FillCmb(dt_EducationType, cmbEducationType, "EduationTypeID", "EducationTypetxt")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MsgBox("¬Ì« «“ À»  ›—œ „Ê—œ ‰Ÿ— „ÿ„∆‰ Â” Ìœ ø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            If txtFormID.Text.Trim = "" Or txtTel.Text.Trim = "" Or txtNationalCode.Text.Trim = "" Or txtMobile.Text.Trim = "" Or txtDate.Text.Trim = "" Or txtBirthDate.Text.Trim = "" Or txtIDNum.Text.Trim = "" Or txtFName.Text.Trim = "" Or txtLName.Text.Trim = "" Or txtName.Text.Trim = "" Or txtDate.Text.Trim = "" Then
                MsgBox("·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
                Exit Sub
            End If
            If Len(txtDate.Text.Trim) < 10 Or Len(txtBirthDate.Text.Trim) < 10 Or txtBirthDate.Text.Trim > IraniDate1.GetIrani8DateStr_CurDate Or txtDate.Text.Trim > IraniDate1.GetIrani8DateStr_CurDate Then
                MsgBox("·ÿ›«  «—ÌŒÂ« —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
                Exit Sub
            ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtBirthDate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtDate.Text)) = True Then
                Exit Sub
            End If
            Bus_Person1.insert_tbHR_JobRequest(Val(txtFormID.Text), txtDate.Text.Trim, txtName.Text.Trim, txtLName.Text.Trim, txtFName.Text.Trim, txtIDNum.Text.Trim, txtNationalCode.Text.Trim, txtBirthDate.Text.Trim, cmbBirthCity.SelectedValue, txtTel.Text.Trim, txtMobile.Text.Trim, cmbDiploma.SelectedValue, cmbEducationType.SelectedValue, cmbAttitudeID.SelectedValue, cmbMDepartCode.SelectedValue, cmbMilitary.SelectedValue)
            FillMyGrid()
            MsgBox("—ﬂÊ—œ À»  ê—œÌœ", MsgBoxStyle.Information, "")
            txtClear()
        Else
            Exit Sub
        End If
    End Sub

    Friend Sub txtClear()
        txtFormID.Text = ""
        txtName.Text = ""
        txtDate.Text = ""
        txtLName.Text = ""
        txtFName.Text = ""
        txtIDNum.Text = ""
        txtBirthDate.Text = ""
        txtDate.Text = ""
        txtMobile.Text = ""
        txtNationalCode.Text = ""
        txtTel.Text = ""
        cmbAttitudeID.SelectedValue = 1
        cmbBirthCity.SelectedValue = 1
        cmbDiploma.SelectedValue = 1
        cmbEducationType.SelectedValue = 1
        cmbMDepartCode.SelectedValue = 1
        cmbMilitary.SelectedValue = 1
    End Sub

    Private Sub tsmFrmNewPerson_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmFrmNewPerson.Click
        Dim frm As New frmNewPersonProperty
        frm.txtName.Text = grdPerson.GetValue("FirstName")
        frm.txtLName.Text = grdPerson.GetValue("LastName")
        frm.txtFName.Text = grdPerson.GetValue("FatherName")
        frm.txtBirthDate.Text = grdPerson.GetValue("BirthDate")
        frm.txtIDNum.Text = grdPerson.GetValue("IDNumber")
        frm.txtNationalCode.Text = grdPerson.GetValue("NationalCode")
        frm.txtTel.Text = grdPerson.GetValue("Tel")
        frm.txtMobile.Text = grdPerson.GetValue("Mobile")
        frm.BirthCityCode = grdPerson.GetValue("CityCode")
        frm.MilitaryStateID = grdPerson.GetValue("MilitaryStateID")
        frm.test = 1
        frm.ShowDialog()
    End Sub
End Class