Public Class frmPRSFamily
    Dim Bus_Person1 As New Bus_Person
    Dim dt_Family As DataTable
    Dim _PersonCode, _PersonID As Integer
    Dim dt_City, dt_CityIssue, dt_Affine, dt_Married As New DataTable

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

    Private Sub frmPRSFamily_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmPRSFamily_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("‘„« »Â «Ì‰ ‰—„ «›“«— œ” —”Ì ‰œ«—Ìœ", MsgBoxStyle.Information, "")
            Me.Close()
        Else
            ''''„⁄«Ê‰ „«·Ì Ê «œ«—Ì
            If Activity1.CheckUserAccess(54, 733, LogID) = True Then
                UiGroupBox2.Enabled = False
            End If
        End If

        Call FillMyGridView()
        FillCombo()

        ''''‰Ÿ— ”‰ÃÌ

        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub

    Friend Function FillCombo()
        dt_City = Bus_City1.GetCityIfo()
        Persist1.FillCmb(dt_City, cmbBirthCity, "CityCode", "Citytxt")
        dt_CityIssue = Bus_City1.GetCityIfos()
        Persist1.FillCmb(dt_CityIssue, cmbIssueCity, "CityCode", "Citytxt")
        dt_Affine = Bus_Family1.GetAffineInfo()
        Persist1.FillCmb(dt_Affine, cmbAffine, "AffineID", "AffineTxt")
        dt_Married = Bus_Family1.GetMarriedTypes()
        Persist1.FillCmb(dt_Married, cmbmarried, "MarriedID", "MarriedText")
    End Function

    Friend Function FillMyGridView()
        Dim janus1 As New JFrameWork.JanusGrid
        dt_Family = Bus_Family1.GetFamilyInfo(PersonCode)
        janus1.GetBindJGrid_DT(dt_Family, grdFamily, ConString)
        janus1.setMyJGrid(grdFamily, "FirstName", "‰«„", 125)
        janus1.setMyJGrid(grdFamily, "LastName", "‰«„ Œ«‰Ê«œêÌ", 140)
        janus1.setMyJGrid(grdFamily, "BirthDate", " «—ÌŒ  Ê·œ", 100)
        janus1.setMyJGrid(grdFamily, "IDNum", "‘„«—Â ‘‰«”‰«„Â", 110)
        janus1.setMyJGrid(grdFamily, "CityNameBirthday", "„Õ·  Ê·œ", 75)
        janus1.setMyJGrid(grdFamily, "CityNameIssue", "„Õ· ’œÊ—", 75)
        janus1.setMyJGrid(grdFamily, "AffineTxt", "‰”» ", 75)
        janus1.setMyJGrid(grdFamily, "MarriedText", "Ê÷⁄Ì   «Â·", 100)
        janus1.setMyJGrid(grdFamily, "AffineID", "", 0, , , False)
        janus1.setMyJGrid(grdFamily, "BirthCityID", "", 0, , , False)
        janus1.setMyJGrid(grdFamily, "BirthCityCode", "", 0, , , False)
        janus1.setMyJGrid(grdFamily, "IssueID", "", 0, , , False)
        janus1.setMyJGrid(grdFamily, "IssueCode", "", 0, , , False)
        janus1.setMyJGrid(grdFamily, "NationalCode", "", 0, , , False)
        janus1.setMyJGrid(grdFamily, "FamilyID", "", 0, , , False)
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dt_CityID As New DataTable
        Dim sqlstr1, sqlstr2 As String
        If MsgBox("¬Ì« «“ À»  ›—œ ÃœÌœ „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            sqlstr1 = "select CityID from tbHR_City where CityCode = " & cmbIssueCity.SelectedValue & ""
            dt_CityID = Persist1.GetDataTable(ConString, sqlstr1)
            lblIssueID.Text = ""
            lblIssueID.Text = dt_CityID.DefaultView.Item(0).Item("CityID")
            dt_CityID.Rows.Clear()
            sqlstr2 = "select CityID from tbHR_City where CityCode = " & cmbBirthCity.SelectedValue & ""
            dt_CityID = Persist1.GetDataTable(ConString, sqlstr2)
            lblBirthCityID.Text = ""
            lblBirthCityID.Text = dt_CityID.DefaultView.Item(0).Item("CityID")
            dt_CityID.Rows.Clear()
            If txtBirthDate.Text > IraniDate1.GetIrani8DateStr_CurDate Then
                MsgBox("  «—ÌŒ  Ê·œ «“  «—ÌŒ «„—Ê“ »“—ê — «”   ", MsgBoxStyle.Information, "")
                Exit Sub
            ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtBirthDate.Text)) = True Then
                Exit Sub
            End If
            If txtFirstName.Text.Trim = "" Or txtLastName.Text.Trim = "" Or txtIDNum.Text.Trim = "" Or Len(txtBirthDate.Text.Trim) <> 10 Or cmbBirthCity.Text.Trim = "" Or cmbAffine.Text.Trim = "" Or cmbBirthCity.Text.Trim = "" Then
                MsgBox(" ·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ  ", MsgBoxStyle.Information, "")
                Exit Sub
            Else
                Bus_Family1.InsertFamilyInfo(PersonID, PersonCode, txtFirstName.Text.Trim, txtLastName.Text.Trim, txtBirthDate.Text.Trim, Val(lblBirthCityID.Text.Trim), cmbBirthCity.SelectedValue, txtIDNum.Text.Trim, Val(lblIssueID.Text.Trim), cmbIssueCity.SelectedValue, cmbAffine.SelectedValue, txtNationalcode.Text.Trim, cmbmarried.SelectedValue)
            End If
            Call FillMyGridView()
            MsgBox("—ﬂÊ—œ À»  ‘œ", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        If grdFamily.RowCount <> 0 Then
            txtFirstName.Text = grdFamily.GetValue("FirstName")
            txtLastName.Text = grdFamily.GetValue("LastName")
            txtBirthDate.Text = grdFamily.GetValue("BirthDate")
            txtIDNum.Text = grdFamily.GetValue("IDNum")
            txtNationalcode.Text = grdFamily.GetValue("NationalCode")
            cmbAffine.SelectedValue = grdFamily.GetValue("AffineID")
            cmbBirthCity.SelectedValue = grdFamily.GetValue("BirthCityCode")
            cmbIssueCity.SelectedValue = grdFamily.GetValue("IssueCode")
            btnSaveChange.Visible = True
            btnAdd.Visible = False
            btnChange.Enabled = False
        Else
            MsgBox("«ÿ·«⁄« Ì »—«Ì ÊÌ—«Ì‘ „ÊÃÊœ ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
    End Sub

    Private Sub btnSaveChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChange.Click
        Dim dt_CityID As New DataTable
        Dim sqlstr1, sqlstr2 As String
        sqlstr1 = "select CityID from tbHR_City where CityCode = '" & cmbIssueCity.SelectedValue & "'"
        dt_CityID = Persist1.GetDataTable(ConString, sqlstr1)
        lblIssueID.Text = ""
        lblIssueID.Text = dt_CityID.DefaultView.Item(0).Item("CityID")
        dt_CityID.Rows.Clear()
        sqlstr2 = "select CityID from tbHR_City where CityCode = '" & cmbBirthCity.SelectedValue & "'"
        dt_CityID = Persist1.GetDataTable(ConString, sqlstr2)
        lblBirthCityID.Text = ""
        lblBirthCityID.Text = dt_CityID.DefaultView.Item(0).Item("CityID")
        dt_CityID.Rows.Clear()
        If txtBirthDate.Text > IraniDate1.GetIrani8DateStr_CurDate Then
            MsgBox("  «—ÌŒ  Ê·œ «“  «—ÌŒ «„—Ê“ »“—ê — «”   ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If txtFirstName.Text.Trim = "" Or txtLastName.Text.Trim = "" Or txtIDNum.Text.Trim = "" Or Len(txtBirthDate.Text.Trim) <> 10 Or cmbBirthCity.Text.Trim = "" Or cmbAffine.Text = "" Or cmbBirthCity.Text = "" Then
            MsgBox(" ·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ  ", MsgBoxStyle.Information)
            Exit Sub
        Else
            If MsgBox("¬Ì« «“ À»   €ÌÌ—«  „ÿ„∆‰ Â” Ìœ ø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Bus_Family1.UpdateFamilyInfo(grdFamily.GetValue("FamilyID"), txtFirstName.Text.Trim, txtLastName.Text.Trim, txtBirthDate.Text.Trim, Val(lblBirthCityID.Text.Trim), cmbBirthCity.SelectedValue, txtIDNum.Text.Trim, Val(lblIssueID.Text.Trim), cmbIssueCity.SelectedValue, cmbAffine.SelectedValue, txtNationalcode.Text.Trim, cmbmarried.SelectedValue)
                FillMyGridView()
                btnSaveChange.Visible = False
                btnAdd.Visible = True
                btnChange.Enabled = True
            Else
                Exit Sub
                btnSaveChange.Visible = False
                btnAdd.Visible = True
                btnChange.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grdFamily.RowCount <> 0 Then
            If MsgBox("¬Ì« «“ Õ–› " & "(( " & Me.grdFamily.GetValue("FirstName") & " " & Me.grdFamily.GetValue("LastName") & " ))" & " „ÿ„∆‰ Â” Ìœ ø", MsgBoxStyle.OkCancel, "Â‘œ«—") = MsgBoxResult.Ok Then
                Bus_Family1.DeleteFamilyInfo(Me.grdFamily.GetValue("FamilyID"))
                Call FillMyGridView()
            Else
                Exit Sub
            End If
        Else
            MsgBox("¬Ì „Ì »—«Ì Õ–› „ÊÃÊœ ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Close()
    End Sub
End Class
'Private Sub ÊÌ—«Ì‘ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'End Sub

'Private Sub Õ–›ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    If grdFamily.RowCount <> 0 Then
'        If MsgBox("¬Ì« «“ Õ–› " & "(( " & Me.grdFamily.GetValue("FirstName") & " " & Me.grdFamily.GetValue("LastName") & " ))" & " „ÿ„∆‰ Â” Ìœ ø", MsgBoxStyle.OkCancel, "Â‘œ«—") = MsgBoxResult.Ok Then
'            Bus_Person1.DeleteFamilyInfo(Me.grdFamily.GetValue("FamilyID"))
'            Call FillMyGridView()
'        Else
'            Exit Sub
'        End If
'    Else
'        MsgBox("¬Ì „Ì »—«Ì Õ–› „ÊÃÊœ ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
'    End If
'End Sub



'Private Sub œ—ÃToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    Dim dt_CityID As New DataTable
'    Dim sqlstr1, sqlstr2 As String
'    sqlstr1 = "select CityID from tbHR_City where CityCode = " & cmbIssueCity.SelectedValue & ""
'    dt_CityID = Persist1.GetDataTable(ConString, sqlstr1)
'    lblIssueID.Text = ""
'    lblIssueID.Text = dt_CityID.DefaultView.Item(0).Item("CityID")
'    dt_CityID.Rows.Clear()
'    sqlstr2 = "select CityID from tbHR_City where CityCode = " & cmbBirthCity.SelectedValue & ""
'    dt_CityID = Persist1.GetDataTable(ConString, sqlstr2)
'    lblBirthCityID.Text = ""
'    lblBirthCityID.Text = dt_CityID.DefaultView.Item(0).Item("CityID")
'    dt_CityID.Rows.Clear()
'    If txtBirthDate.Text > IraniDate1.GetIrani8DateStr_CurDate Then
'        MsgBox("  «—ÌŒ  Ê·œ «“  «—ÌŒ «„—Ê“ »“—ê — «”   ", MsgBoxStyle.Information, "")
'        Exit Sub
'    ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtBirthDate.Text)) = True Then
'        Exit Sub
'    End If
'    If txtFirstName.Text = "" Or txtLastName.Text = "" Or txtIDNum.Text = "" Or Len(txtBirthDate.Text) <> 10 Or cmbBirthCity.Text = "" Or cmbAffine.Text = "" Or cmbBirthCity.Text = "" Then
'        MsgBox(" ·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ  ", MsgBoxStyle.Information, "")
'        Exit Sub
'    Else
'        Bus_Person1.InsertFamilyInfo(PersonID, PersonCode, txtFirstName.Text, txtLastName.Text, txtBirthDate.Text, Val(lblBirthCityID.Text), cmbBirthCity.SelectedValue, txtIDNum.Text, Val(lblIssueID.Text), cmbIssueCity.SelectedValue, cmbAffine.SelectedValue, Val(txtNationalcode.Text))
'    End If
'    Call FillMyGridView()
'End Sub


