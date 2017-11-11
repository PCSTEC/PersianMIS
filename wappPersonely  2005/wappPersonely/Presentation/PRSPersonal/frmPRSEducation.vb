Public Class frmPRSEducation
    Dim dt_Education, dt_Diploma, dt_Attitude, dt_StudyPlace As New DataTable
    Dim Bus_Person1 As New Bus_Person
    Dim _PersonCode, _PersonID, _StudyPlaceCode, _StudyPlaceID, _AttitudeCode, _AttitudeID As Integer
    Dim EducationID As Integer
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
    Friend Property StudyPlaceCode() As Integer
        Get
            Return _StudyPlaceCode
        End Get
        Set(ByVal value As Integer)
            _StudyPlaceCode = value
        End Set
    End Property
    Friend Property StudyPlaceID() As Integer
        Get
            Return _StudyPlaceID
        End Get
        Set(ByVal value As Integer)
            _StudyPlaceID = value
        End Set
    End Property
    Friend Property AttitudeCode() As Integer
        Get
            Return _AttitudeCode
        End Get
        Set(ByVal value As Integer)
            _AttitudeCode = value
        End Set
    End Property
    Friend Property AttitudeID() As Integer
        Get
            Return _AttitudeID
        End Get
        Set(ByVal value As Integer)
            _AttitudeID = value
        End Set
    End Property

    Private Sub frmPRSEducation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub frmPRSEducation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("‘„« »Â «Ì‰ ‰—„ «›“«— œ” —”Ì ‰œ«—Ìœ", MsgBoxStyle.Information, "")
            Me.Close()
            ''''œ” —”Ì „⁄«Ê‰ „«·Ì  Ê«œ«—Ì
        ElseIf Activity1.CheckUserAccess(54, 733, LogID) = True Then
            UiGroupBox2.Enabled = False
            ''''œ” —”Ì ﬁ”„  ¬„Ê“‘
        ElseIf Activity1.CheckUserAccess(54, 735, LogID) = True Then
            UiGroupBox2.Enabled = False
        ElseIf Activity1.CheckUserAccess(54, 950, LogID) = True Then
            UiGroupBox2.Enabled = False
        End If
        FillMyGridView()
        FillCombo()



        ''''‰Ÿ— ”‰ÃÌ

        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub
    Friend Sub FillCombo()
        dt_Diploma = Bus_Education1.GetDiplomaInfo
        Persist1.FillCmb(dt_Diploma, cmbDiploma, "DiplomaCode", "DiplomaName")
    End Sub
    Friend Sub FillMyGridView()
        Dim janus1 As New JFrameWork.JanusGrid
        dt_Education.Rows.Clear()
        dt_Education = Bus_Education1.GetEducationInfo(PersonCode)
        janus1.GetBindJGrid_DT(dt_Education, grdEducation, ConString)
        janus1.setMyJGrid(grdEducation, "FirstName", "‰«„", 75)
        janus1.setMyJGrid(grdEducation, "LastName", "‰«„ Œ«‰Ê«œêÌ", 110)
        janus1.setMyJGrid(grdEducation, "DiplomaName", "„œ—ﬂ", 80)
        janus1.setMyJGrid(grdEducation, "Branchtxt", "‘«ŒÂ  Õ’Ì·Ì", 85)
        janus1.setMyJGrid(grdEducation, "AttitudeName", "ê—«Ì‘", 80)
        janus1.setMyJGrid(grdEducation, "StudyPlacetxt", "„Õ·  Õ’Ì·", 100)
        janus1.setMyJGrid(grdEducation, "BeginDate", " «—ÌŒ ‘—Ê⁄", 85)
        janus1.setMyJGrid(grdEducation, "EndDate", " «—ÌŒ « „«„", 85)
        janus1.setMyJGrid(grdEducation, "Average", "„⁄œ·", 50)
        janus1.setMyJGrid(grdEducation, "Citytxt", "‰«„ ‘Â—", 0, , , False)
        janus1.setMyJGrid(grdEducation, "StudyPlaceType", "‰Ê⁄ „Õ·  Õ’Ì·", 0, , , False)
        janus1.setMyJGrid(grdEducation, "Active", "«ﬂ ÌÊ", 0, , , False)
        janus1.HighLightRows(grdEducation, "Active", Janus.Windows.GridEX.ConditionOperator.Equal, 1, Color.Aqua)
        janus1.setMyJGrid(grdEducation, "EducationID", "", 0, , , False)
        janus1.setMyJGrid(grdEducation, "StudyPlaceCode", "", 0, , , False)
        janus1.setMyJGrid(grdEducation, "AttitudeCode", "", 0, , , False)
        janus1.setMyJGrid(grdEducation, "Countrytxt", "", 0, , , False)
        janus1.setMyJGrid(grdEducation, "StudyPlaceTypeCode", "", 0, , , False)
        janus1.setMyJGrid(grdEducation, "StudyPlaceID", "", 0, , , False)
        janus1.setMyJGrid(grdEducation, "DiplomaID", "", 0, , , False)
        janus1.setMyJGrid(grdEducation, "DiplomaCode", "", 0, , , False)
        janus1.setMyJGrid(grdEducation, "AttitudeID", "", 0, , , False)
        janus1.setMyJGrid(grdEducation, "PersonCode", "ﬂœ Å—”‰·Ì", 0, , , False)
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dt_ID, dt_EducationID As New DataTable
        Dim sqlstr3, sqlstr4 As String
        Dim i As Integer
        dt_ID.Rows.Clear()
        sqlstr3 = "Select DiplomaID From tbHR_Diploma Where DiplomaCode = '" & cmbDiploma.SelectedValue & "'"
        dt_ID = Persist1.GetDataTable(ConString, sqlstr3)
        lblDiplomaID.Text = ""
        lblDiplomaID.Text = dt_ID.DefaultView.Item(0).Item("DiplomaID")
        If txtBigin.Text > txtEnd.Text Then
            MsgBox("  «—ÌŒ ‘—Ê⁄ «“  «—ÌŒ Å«Ì«‰ »“—ê — «”   ", MsgBoxStyle.Information, "")
            Exit Sub
        ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtBigin.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtEnd.Text)) = True Then
            Exit Sub
        End If
        If txtAverage.Text = "" Or Val(txtAverage.Text.Trim) > 20 Or Len(txtBigin.Text) <> 10 Or Len(txtEnd.Text) <> 10 Or cmbDiploma.Text = "" Or txtAverage.Text = "" Then
            MsgBox(" ·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ  ", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            sqlstr4 = "select EducationID from tbHR_Education where PersonCode = " & Val(lblPersonCode.Text) & ""
            dt_EducationID = Persist1.GetDataTable(ConString, sqlstr4)
            If MsgBox("¬Ì« «“ œ—Ã „œ—ﬂ  Õ’Ì·Ì ÃœÌœ „ÿ„∆‰ Â” Ìœ", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                For i = 0 To dt_EducationID.Rows.Count - 1
                    EducationID = dt_EducationID.DefaultView.Item(i).Item("EducationID")
                    Bus_Education1.updateActievetbHREducation(EducationID, 0)
                Next i
                Bus_Education1.InsertEducationInfo(PersonID, PersonCode, Val(lblStudyPlaceID.Text), Val(lblStudyPlaceCode.Text), txtBigin.Text, txtEnd.Text, Val(lblDiplomaID.Text), cmbDiploma.SelectedValue, Val(lblAttitudeID.Text), Val(lblAttitudeCode.Text), Val(txtAverage.Text), 1)
            Else
                Exit Sub
            End If
        End If
        Call FillMyGridView()
        Cleartxt()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim EducationID1 As Integer
        If grdEducation.RowCount <> 0 Then
            If grdEducation.RowCount = 1 Then
                If MsgBox("¬Ì« «“ Õ–› „œ—ﬂ " & "(( " & Me.grdEducation.GetValue("DiplomaName") & " ))" & " „ÿ„∆‰ Â” Ìœ ø", MsgBoxStyle.OkCancel, "Â‘œ«—") = MsgBoxResult.Ok Then
                    Bus_Education1.DeleteEducationInfo(Me.grdEducation.GetValue("EducationID"))
                    Call FillMyGridView()
                Else
                    Exit Sub
                End If
            Else
                sqlstr = "select Active from tbHR_Education where EducationID = " & grdEducation.GetValue("EducationID") & ""
                dt = Persist1.GetDataTable(ConString, sqlstr)
                If dt.DefaultView.Item(0).Item("Active") = 0 Then
                    Bus_Education1.DeleteEducationInfo(Me.grdEducation.GetValue("EducationID"))
                    dt.Rows.Clear()
                    Call FillMyGridView()
                Else
                    Bus_Education1.DeleteEducationInfo(Me.grdEducation.GetValue("EducationID"))
                    dt.Rows.Clear()
                    sqlstr = ""
                    sqlstr = "Select MAX(EducationID) AS MAXEducationID FROM tbHR_Education GROUP BY PersonCode HAVING (PersonCode = " & grdEducation.GetValue("PersonCode") & ")"
                    dt = Persist1.GetDataTable(ConString, sqlstr)
                    EducationID1 = dt.DefaultView.Item(0).Item("MAXEducationID")
                    Bus_Education1.updateActievetbHREducation(EducationID1, 1)
                    Call FillMyGridView()
                End If
            End If
        Else
            MsgBox("¬Ì „Ì »—«Ì Õ–› „ÊÃÊœ ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        If grdEducation.RowCount <> 0 Then
            Cleartxt()
            txtAverage.Text = grdEducation.GetValue("Average")
            txtBigin.Text = grdEducation.GetValue("BeginDate")
            txtEnd.Text = grdEducation.GetValue("EndDate")
            lblAtitude.Text = grdEducation.GetValue("AttitudeName")
            AttitudeCode = grdEducation.GetValue("AttitudeCode")
            lblAttitudeCode.Text = grdEducation.GetValue("AttitudeCode")
            lblAttitudeID.Text = grdEducation.GetValue("AttitudeID")
            AttitudeID = grdEducation.GetValue("AttitudeID")
            cmbDiploma.SelectedValue = grdEducation.GetValue("DiplomaCode")
            lblStudyPlace.Text = grdEducation.GetValue("StudyPlacetxt")
            StudyPlaceCode = grdEducation.GetValue("StudyPlaceCode")
            StudyPlaceID = grdEducation.GetValue("StudyPlaceID")
            btnAdd.Visible = False
            btnSaveChange.Visible = True
            btnChange.Enabled = False
        Else
            MsgBox("«ÿ·«⁄« Ì »—«Ì ÊÌ—«Ì‘ „ÊÃÊœ ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
    End Sub

    Private Sub btnSaveChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChange.Click
        Dim dt_ID, dt_EducationID As New DataTable
        Dim sqlstr As String
        sqlstr = "Select DiplomaID From tbHR_Diploma Where DiplomaCode = '" & cmbDiploma.SelectedValue & "'"
        dt_ID = Persist1.GetDataTable(ConString, SqlStr)
        lblDiplomaID.Text = ""
        lblDiplomaID.Text = dt_ID.DefaultView.Item(0).Item("DiplomaID")
        If txtBigin.Text > txtEnd.Text Then
            MsgBox("  «—ÌŒ ‘—Ê⁄ «“  «—ÌŒ Å«Ì«‰ »“—ê — «”   ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If txtAverage.Text = "" Or Len(txtBigin.Text) <> 10 Or Len(txtEnd.Text) <> 10 Or cmbDiploma.Text = "" Or txtAverage.Text = "" Then
            MsgBox(" ·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ  ", MsgBoxStyle.Information)
            Exit Sub
        Else
            If MsgBox("¬Ì« «“ ÊÌ—«Ì‘ „œ—ﬂ  Õ’Ì·Ì „ÿ„∆‰ Â” Ìœ", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                EducationID = grdEducation.GetValue("EducationID")
                Bus_Education1.UpdateEducationInfo(EducationID, StudyPlaceID, StudyPlaceCode, txtBigin.Text, txtEnd.Text, Val(lblDiplomaID.Text), cmbDiploma.SelectedValue, AttitudeID, AttitudeCode, txtAverage.Text)
                MsgBox("—ﬂÊ—œ À»  ‘œ", MsgBoxStyle.Information, "")
                FillMyGridView()
                Cleartxt()
                btnAdd.Visible = True
                btnSaveChange.Visible = False
                btnChange.Enabled = True
            Else
                btnAdd.Visible = True
                btnSaveChange.Visible = False
                btnChange.Enabled = True
                Exit Sub
            End If
        End If
    End Sub
    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Close()
    End Sub

    Private Sub btnStudyPlace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudyPlace.Click
        Dim frm As New frmPRSStudyPlace
        frm.frmPRSEducation1 = Me
        frm.ShowDialog()
    End Sub

    Private Sub btnAtitude_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtitude.Click
        Dim frm As New frmPRSGeraiesh
        frm.frmPRSEducation1 = Me
        frm.ShowDialog()
    End Sub
    Friend Sub Cleartxt()
        lblAtitude.Text = ""
        lblStudyPlace.Text = ""
        lblStudyPlaceCode.Text = ""
        lblStudyPlaceID.Text = ""
        lblAttitudeCode.Text = ""
        lblAttitudeID.Text = ""
        lblDiplomaID.Text = ""
        txtAverage.Text = ""
        txtBigin.Text = ""
        txtEnd.Text = ""
    End Sub
End Class
    'Private Sub œ—ÃToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim dt_ID, dt_EducationID As New DataTable
    '    Dim sqlstr1, sqlstr2, sqlstr3, sqlstr4 As String
    '    Dim i As Integer
    '    dt_ID.Rows.Clear()
    '    sqlstr1 = "Select CityID From tbHR_StudyPlace Where (StudyPlaceCode  = '" & cmbStudyPlace.SelectedValue & "')"
    '    dt_ID = Persist1.GetDataTable(ConString, sqlstr1)
    '    lblStudyPlaceID.Text = ""
    '    lblStudyPlaceID.Text = dt_ID.DefaultView.Item(0).Item("CityID")
    '    dt_ID.Rows.Clear()
    '    sqlstr2 = "Select AttitudeID From tbHR_Attitude Where AttitudeCode = '" & cmbAttitude.SelectedValue & "'"
    '    dt_ID = Persist1.GetDataTable(ConString, sqlstr2)
    '    lblAttitudeID.Text = ""
    '    lblAttitudeID.Text = dt_ID.DefaultView.Item(0).Item("AttitudeID")
    '    dt_ID.Rows.Clear()
    '    sqlstr3 = "Select DiplomaID From tbHR_Diploma Where DiplomaCode = '" & cmbDiploma.SelectedValue & "'"
    '    dt_ID = Persist1.GetDataTable(ConString, sqlstr3)
    '    lblDiplomaID.Text = ""
    '    lblDiplomaID.Text = dt_ID.DefaultView.Item(0).Item("DiplomaID")
    '    If txtBigin.Text > txtEnd.Text Then
    '        MsgBox("  «—ÌŒ ‘—Ê⁄ «“  «—ÌŒ Å«Ì«‰ »“—ê — «”   ", MsgBoxStyle.Information, "")
    '        Exit Sub
    '    ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtBigin.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtEnd.Text)) = True Then
    '        Exit Sub
    '    End If
    '    If txtAverage.Text = "" Or Len(txtBigin.Text) <> 10 Or Len(txtEnd.Text) <> 10 Or cmbAttitude.Text = "" Or cmbDiploma.Text = "" Or cmbStudyPlace.Text = "" Or txtAverage.Text = "" Then
    '        MsgBox(" ·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ  ", MsgBoxStyle.Information, "")
    '        Exit Sub
    '    Else
    '        sqlstr4 = "select EducationID from tbHR_Education where PersonCode = " & Val(lblPersonCode.Text) & ""
    '        dt_EducationID = Persist1.GetDataTable(ConString, sqlstr4)
    '        If MsgBox("¬Ì« «“ œ—Ã „œ—ﬂ  Õ’Ì·Ì ÃœÌœ „ÿ„∆‰ Â” Ìœ", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
    '            For i = 0 To dt_EducationID.Rows.Count - 1
    '                EducationID = dt_EducationID.DefaultView.Item(i).Item("EducationID")
    '                Bus_Person1.updateActievetbHREducation(EducationID, 0)
    '            Next i
    '            Bus_Person1.InsertEducationInfo(PersonID, PersonCode, Val(lblStudyPlaceID.Text), cmbStudyPlace.SelectedValue, txtBigin.Text, txtEnd.Text, Val(lblDiplomaID.Text), cmbDiploma.SelectedValue, Val(lblAttitudeID.Text), cmbAttitude.SelectedValue, Val(txtAverage.Text), 1)
    '        Else
    '            Exit Sub
    '        End If
    '    End If
    '    Call FillMyGridView()
    'End Sub

    'Private Sub ÊÌ—«Ì‘ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub Õ–›ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If grdEducation.RowCount <> 0 Then
    '        If MsgBox("¬Ì« «“ Õ–› „œ—ﬂ " & "(( " & Me.grdEducation.GetValue("DiplomaName") & " ))" & " „ÿ„∆‰ Â” Ìœ ø", MsgBoxStyle.OkCancel, "Â‘œ«—") = MsgBoxResult.Ok Then
    '            Bus_Person1.DeleteEducationInfo(Me.grdEducation.GetValue("EducationID"))
    '            Call FillMyGridView()
    '        Else
    '            Exit Sub
    '        End If
    '    Else
    '        MsgBox("¬Ì „Ì »—«Ì Õ–› „ÊÃÊœ ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
    '    End If
    'End Sub

 