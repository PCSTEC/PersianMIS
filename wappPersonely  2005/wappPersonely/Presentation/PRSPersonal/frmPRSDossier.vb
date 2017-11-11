Public Class frmPRSDossier
    Dim dt_Dossier, dt_Related, dt_Assure As New DataTable
    Dim Bus_Person1 As New Bus_Person
    Dim _PersonCode, _PersonID As Integer
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

    Private Sub frmPRSDossier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub frmPRSDossier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("��� �� ��� ��� ����� ������ ������", MsgBoxStyle.Information, "")
            Me.Close()

            ''''����� ���� � �����
        ElseIf Activity1.CheckUserAccess(54, 733, LogID) = True Then
            UiGroupBox2.Enabled = False

            ''''������ ���� �����
        ElseIf Activity1.CheckUserAccess(54, 792, LogID) = True Then
            UiGroupBox2.Enabled = True
        End If



        FillMyGridView()
        FillCombo()


        ''''��� ����
  
        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub
    Friend Sub FillCombo()
        dt_Related = Bus_Dossier1.GetRelatedInfo
        Persist1.FillCmb(dt_Related, cmbRelated, "RelatedId", "Relatedtext")
        dt_Assure = Bus_Other1.GetAssureInfo
        Persist1.FillCmb(dt_Assure, cmbAssure, "AssureID", "Assuretxt")
    End Sub
    Friend Function FillMyGridView()
        Dim janus1 As New JFrameWork.JanusGrid
        dt_Dossier = Bus_Dossier1.GetDossierInfo(PersonCode)
        janus1.GetBindJGrid_DT(dt_Dossier, grdDossier, ConString)
        janus1.setMyJGrid(grdDossier, "JobCo", "��� ��� ���", 120)
        janus1.setMyJGrid(grdDossier, "Jobtxt", "����� ���", 120)
        janus1.setMyJGrid(grdDossier, "Relatedtext", "��� ���", 85)
        janus1.setMyJGrid(grdDossier, "AssureTxt", "����� ����", 100)
        janus1.setMyJGrid(grdDossier, "Sallary", "���� �������", 75)
        janus1.setMyJGrid(grdDossier, "BeginDate", "����� ����", 80)
        janus1.setMyJGrid(grdDossier, "EndDate", "����� �����", 80)
        janus1.setMyJGrid(grdDossier, "DaySum", "����� �� ���", 75)
        janus1.setMyJGrid(grdDossier, "DossierID", "", 0, , , False)
        janus1.setMyJGrid(grdDossier, "AssureID", "", 0, , , False)
        janus1.setMyJGrid(grdDossier, "RelatedID", "", 0, , , False)
        janus1.setMyJGrid(grdDossier, "PersonCode", "�� ������", 0, , , False)
    End Function
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If txtDossierBeginDate.Text > txtDossierEndDate.Text Then
            MsgBox(" ����� ���� �� ����� ����� ��ѐ�� ���  ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If Len(txtDossierBeginDate.Text) <> 10 Or Len(txtDossierEndDate.Text) <> 10 Or txtDossierJob.Text = "" Or txtDossierJobCo.Text = "" Or cmbAssure.Text = "" Or cmbRelated.Text = "" Or txtDossierSallary.Text = "" Then
            MsgBox(" ���� ������ �� ���� ���� ������  ", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            If MsgBox("��� �� ��� ����� ���� ��� ����� ����Ͽ", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Bus_Dossier1.InsertDossierInfo(Val(lblPersonCode.Text), txtDossierJobCo.Text, txtDossierJob.Text, cmbAssure.SelectedValue, txtDossierSallary.Text, txtDossierBeginDate.Text, txtDossierEndDate.Text, Val(txtSumDay.Text.Trim), cmbRelated.SelectedValue, Val(lblPersonID.Text.Trim))
                MsgBox("����� ��� �����", MsgBoxStyle.Information, "")
                Call FillMyGridView()
            Else
                Exit Sub
            End If
        End If
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grdDossier.RowCount <> 0 Then
            If MsgBox("����� ����� �" & "(( " & Me.grdDossier.GetValue("JobCo") & " ))" & " ��� �� ��� ", MsgBoxStyle.OkCancel, "�����") = MsgBoxResult.Ok Then
                Bus_Dossier1.DeleteDossierInfo(Me.grdDossier.GetValue("DossierID"))
                Call FillMyGridView()
            Else
                Exit Sub
            End If
        Else
            MsgBox("����� ���� ��� ����� ��� ����", MsgBoxStyle.Information, "")
        End If
    End Sub
    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        If grdDossier.RowCount <> 0 Then
            btnChange.Enabled = False
            btnAdd.Visible = False
            btnSaveChange.Visible = True
            txtDossierJobCo.Text = Utility1.NZ(grdDossier.GetValue("JobCo"), "-")
            txtDossierJob.Text = Utility1.NZ(grdDossier.GetValue("Jobtxt"), "-")
            txtDossierBeginDate.Text = grdDossier.GetValue("BeginDate")
            txtDossierEndDate.Text = grdDossier.GetValue("EndDate")
            txtSumDay.Text = grdDossier.GetValue("DaySum")
            txtDossierSallary.Text = Str(grdDossier.GetValue("Sallary"))
            cmbRelated.SelectedValue = grdDossier.GetValue("RelatedID")
            cmbAssure.SelectedValue = grdDossier.GetValue("AssureID")
        Else
            MsgBox("����� ���� ������ ����� ��� ����", MsgBoxStyle.Information, "")
            Exit Sub
        End If
    End Sub

    Private Sub btnSaveChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChange.Click
        If txtDossierBeginDate.Text > txtDossierEndDate.Text Then
            MsgBox(" ����� ���� �� ����� ����� ��ѐ�� ���  ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If txtDossierJobCo.Text = "" Or txtDossierJob.Text = "" Or cmbAssure.Text = "" Or txtDossierSallary.Text = "" Or Len(txtDossierBeginDate.Text) <> 10 Or Len(txtDossierEndDate.Text) <> 10 Or cmbRelated.Text = "" Then
            MsgBox(" ���� ������ �� ���� ���� ������  ", MsgBoxStyle.Information)
            Exit Sub
        Else
            If MsgBox("��� �� ��� ������� ����� ����� �", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                'Day = IraniDate1.GetDifIraniDates(IraniDate1.Numericdate(txtDossierBeginDate.Text), IraniDate1.Numericdate(txtDossierEndDate.Text))
                Bus_Dossier1.UpdateDossierIfo(grdDossier.GetValue("DossierID"), txtDossierJobCo.Text, txtDossierJob.Text, cmbAssure.SelectedValue, Val(txtDossierSallary.Text), txtDossierBeginDate.Text, txtDossierEndDate.Text, Val(txtSumDay.Text.Trim), cmbRelated.SelectedValue)
                MsgBox("����� ��� �����", MsgBoxStyle.Information, "")
                FillMyGridView()
                btnChange.Enabled = True
                btnAdd.Visible = True
                btnSaveChange.Visible = False
            Else
                btnChange.Enabled = True
                btnAdd.Visible = True
                btnSaveChange.Visible = False
                Exit Sub
            End If
        End If
    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Me.Close()
    End Sub

    Private Sub txtDossierEndDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDossierEndDate.Leave
        Dim Day As Integer
        Day = IraniDate1.GetDifIraniDates(IraniDate1.Numericdate(txtDossierBeginDate.Text.Trim), IraniDate1.Numericdate(txtDossierEndDate.Text.Trim))
        txtSumDay.Text = Day
    End Sub
End Class

'Private Sub ���ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    Dim Day As Integer
'    If txtDossierBeginDate.Text > txtDossierEndDate.Text Then
'        MsgBox(" ����� ���� �� ����� ����� ��ѐ�� ���  ", MsgBoxStyle.Information, "")
'        Exit Sub
'    End If
'    If Len(txtDossierBeginDate.Text) <> 10 Or Len(txtDossierEndDate.Text) <> 10 Or txtDossierJob.Text = "" Or txtDossierJobCo.Text = "" Or cmbAssure.Text = "" Or cmbRelated.Text = "" Or txtDossierSallary.Text = "" Then
'        MsgBox(" ���� ������ �� ���� ���� ������  ", MsgBoxStyle.Information, "")
'        Exit Sub
'    Else
'        Day = IraniDate1.GetDifIraniDates(IraniDate1.Numericdate(txtDossierBeginDate.Text), IraniDate1.Numericdate(txtDossierEndDate.Text))
'        Bus_Person1.InsertDossierInfo(Val(lblPersonCode.Text), txtDossierJobCo.Text, txtDossierJob.Text, cmbAssure.SelectedValue, txtDossierSallary.Text, txtDossierBeginDate.Text, txtDossierEndDate.Text, Day, cmbRelated.SelectedValue, PersonID)
'        MsgBox("����� ��� �����", MsgBoxStyle.Information, "")
'        Call FillMyGridView()
'    End If
'End Sub

'Private Sub ������ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    btnChange.Enabled = False
'    btnAdd.Visible = False
'    btnSaveChange.Visible = True
'    txtDossierJobCo.Text = grdDossier.GetValue("JobCo")
'    txtDossierJob.Text = grdDossier.GetValue("Jobtxt")
'    txtDossierBeginDate.Text = grdDossier.GetValue("BeginDate")
'    txtDossierEndDate.Text = grdDossier.GetValue("EndDate")
'    txtDossierSallary.Text = Str(grdDossier.GetValue("Sallary"))
'    cmbRelated.SelectedValue = grdDossier.GetValue("RelatedID")
'    cmbAssure.SelectedValue = grdDossier.GetValue("AssureID")
'End Sub

'Private Sub ���ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    If grdDossier.RowCount <> 0 Then
'        If MsgBox("����� ����� �" & "(( " & Me.grdDossier.GetValue("JobCo") & " ))" & " ��� �� ��� ", MsgBoxStyle.OkCancel, "�����") = MsgBoxResult.Ok Then
'            Bus_Person1.DeleteDossierInfo(Me.grdDossier.GetValue("DossierID"))
'            Call FillMyGridView()
'        Else
'            Exit Sub
'        End If
'    Else
'        MsgBox("����� ���� ��� ����� ��� ����", MsgBoxStyle.Information, "")
'        Exit Sub
'    End If
'End Sub
