Imports System.IO
Public Class frmNewPersonProperty
    Dim Bus_Person1 As New Bus_Person
    Dim dt_Sex As New DataTable
    Dim dt_City As New DataTable
    Dim dt_Military As New DataTable
    Dim dt_Engage As New DataTable
    Dim dt_Year As New DataTable
    Dim dt_CardType As New DataTable
    Dim dt_Alefba As New DataTable
    Dim IDSerial As String
    Friend frmPRSMain1 As frmPRSMain
    Dim _BirthCityCode, _test, _MilitaryStateID As Integer

    Friend Property test() As Integer
        Get
            Return _test
        End Get
        Set(ByVal value As Integer)
            _test = value
        End Set
    End Property

    Friend Property BirthCityCode() As Integer
        Get
            Return _BirthCityCode
        End Get
        Set(ByVal value As Integer)
            _BirthCityCode = value
        End Set
    End Property

    Friend Property MilitaryStateID() As Integer
        Get
            Return _MilitaryStateID
        End Get
        Set(ByVal value As Integer)
            _MilitaryStateID = value
        End Set
    End Property

    Private Sub frmPRSProperty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub Fillcombo()
        dt_Year = Bus_Other1.GetPeriod
        Persist1.FillCmb(dt_Year, cmbYear, "PeriodID", "PeriodYearID")
        dt_Sex = Bus_Other1.GetSexIfo
        Persist1.FillCmb(dt_Sex, cmbSex, "SexID", "Sextxt")
        dt_City = Bus_City1.GetCityIfo
        Persist1.FillCmb(dt_City, cmbBirthCity, "CityCode", "Citytxt")
        dt_City = Bus_City1.GetCityIfos
        Persist1.FillCmb(dt_City, cmbIssueCity, "CityCode", "Citytxt")
        dt_Military = Bus_Other1.GetMilitaryIfo
        Persist1.FillCmb(dt_Military, cmbMilitary, "MilitaryStateID", "MilitaryStateName")
        dt_CardType = Bus_Card1.CardTypeInfo
        Persist1.FillCmb(dt_CardType, cmbCardType, "CardTypeID", "CardTypeText")
        dt_Alefba = Bus_Other1.AlefbaInfo
        Persist1.FillCmb(dt_Alefba, cmbAlefba, "AlefbaID", "Alefba")
        If test = 1 Then
            cmbBirthCity.SelectedValue = BirthCityCode
            cmbMilitary.SelectedValue = MilitaryStateID
        End If
    End Sub
    Private Sub frmPRSMainProperty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fillcombo()


        ''''‰Ÿ— ”‰ÃÌ
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Image As Byte()
        Dim dt_CityID, dt_PersonCode, dt_CardNum, dt_PersonID As New DataTable
        Dim sqlstr1, sqlstr2, sqlstr3, sqlstr4, sqlstr5 As String
        Dim PersonID As Integer
        If MsgBox("¬Ì« «“ À»  ›—œ „Ê—œ ‰Ÿ— „ÿ„∆‰ Â” Ìœ ø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            If Len(txtSodorCard.Text.Trim) <> 10 Or Len(txtIDSerial2.Text.Trim) = 0 Or Len(txtIDSerial1.Text.Trim) <> 2 Or Len(txtEtebarCard.Text.Trim) <> 10 Or txtCadrNum.Text.Trim = "" Or cmbCardType.Text.Trim = "" Or txtCode.Text.Trim = "" Or txtName.Text.Trim = "" Or txtLName.Text.Trim = "" Or txtFName.Text.Trim = "" Or Len(txtBirthDate.Text) <> 10 Or txtIDNum.Text.Trim = "" Or Len(txtEgageDate.Text) <> 10 Or txtAddress.Text.Trim = "" Or cmbSex.Text.Trim = "" Or cmbBirthCity.Text.Trim = "" Or cmbBirthCity.Text.Trim = "-" Or cmbMilitary.Text.Trim = "" Then
                MsgBox(" ·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ  ", MsgBoxStyle.OkOnly, " Œÿ« ")
                Exit Sub
            ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtBirthDate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtEgageDate.Text)) = True Then
                Exit Sub
            ElseIf txtBirthDate.Text > IraniDate1.GetIrani8DateStr_CurDate Or txtEgageDate.Text > IraniDate1.GetIrani8DateStr_CurDate Or txtEgageDate.Text < txtBirthDate.Text Then
                MsgBox(" ·ÿ›«  «—ÌŒÂ« —« œ—”  Ê«—œ ‰„«ÌÌœ  ", MsgBoxStyle.OkOnly, "")
                Exit Sub
            End If
            If MsgBox("¬Ì« „«Ì·Ìœ ⁄ﬂ” ›—œ —« Ê«—œ ‰„«ÌÌœ ø", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Image = saveAttach()
                Else
                    Dim B(0) As Byte
                    Image = B
                End If
            Else
                Dim B(0) As Byte
                Image = B
            End If
            sqlstr1 = "select CityID from tbHR_City where CityCode = '" & cmbBirthCity.SelectedValue & "'"
            dt_CityID = Persist1.GetDataTable(ConString, sqlstr1)
            lblBirthCityID.Text = ""
            lblBirthCityID.Text = dt_CityID.DefaultView.Item(0).Item("CityID")
            dt_CityID.Rows.Clear()
            sqlstr2 = "select CityID from tbHR_City where CityCode = '" & cmbIssueCity.SelectedValue & "'"
            dt_CityID = Persist1.GetDataTable(ConString, sqlstr2)
            lblIssueCityID.Text = ""
            lblIssueCityID.Text = dt_CityID.DefaultView.Item(0).Item("CityID")
            dt_CityID.Rows.Clear()
            sqlstr3 = "select PersonCode from tbHR_Person where PersonCode = " & Val(txtCode.Text.Trim) & ""
            dt_PersonCode = Persist1.GetDataTable(ConString, sqlstr3)
            sqlstr4 = "select CardNumber from tbHR_Card where CardNumber = " & Val(txtCadrNum.Text.Trim) & ""
            dt_CardNum = Persist1.GetDataTable(ConString, sqlstr4)
            If ((dt_PersonCode.Rows.Count = 0) And (dt_CardNum.Rows.Count = 0)) Then
                IDSerial = txtIDSerial1.Text.Trim + cmbAlefba.Text.Trim + txtIDSerial2.Text.Trim
                Bus_Person1.insertPerson(txtCode.Text.Trim, txtName.Text.Trim, txtLName.Text.Trim, txtFName.Text.Trim, txtBirthDate.Text.Trim, cmbSex.SelectedValue, txtNationalCode.Text.Trim, txtIDNum.Text.Trim, IDSerial, Val(lblBirthCityID.Text), cmbBirthCity.SelectedValue, Val(lblIssueCityID.Text), cmbMilitary.SelectedValue, txtEgageDate.Text.Trim, txtWorkID.Text.Trim, txtAssureNum.Text.Trim, txtAddress.Text.Trim, txtTel.Text.Trim, txtMobile.Text.Trim, cmbIssueCity.SelectedValue, txtPostCode.Text.Trim, Image, 1)
                sqlstr5 = "SELECT PersonID from tbHR_Person where PersonCode = " & Val(txtCode.Text.Trim) & ""
                dt_PersonID = Persist1.GetDataTable(ConString, sqlstr5)
                PersonID = dt_PersonID.DefaultView.Item(0).Item("PersonID")
                Bus_Card1.InsertCardInfo(txtCode.Text.Trim, cmbCardType.SelectedValue, txtCadrNum.Text.Trim, txtSodorCard.Text.Trim, txtEtebarCard.Text.Trim, PersonID)
                MsgBox("—ﬂÊ—œ À»  ‘œ", MsgBoxStyle.Information, "")
                If test <> 1 Then
                    frmPRSMain1.FillgrdPerson(SelectStr.FirstEngage)
                    frmPRSMain1.lblVazeeiat.Text = "»œÊ «” Œœ«„"
                End If
            ElseIf dt_PersonCode.Rows.Count <> 0 Then
                MsgBox("ﬂœ Å—”‰·Ì  ﬂ—«—Ì Ê«—œ ‰„ÊœÂ «Ìœ", MsgBoxStyle.Information, "")
                Exit Sub
            ElseIf dt_CardNum.Rows.Count <> 0 Then
                MsgBox("‘„«—Â ﬂ«—   ﬂ—«—Ì Ê«—œ ‰„ÊœÂ «Ìœ", MsgBoxStyle.Information, "")
                Exit Sub
            End If
            Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Function ReadFileToByteArray(ByVal FileName As String) As System.Array
        Dim fs As FileStream = New FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read)
        Dim Len As Long
        Len = fs.Length
        Dim fileAsByte(Len) As Byte
        fs.Read(fileAsByte, 0, fileAsByte.Length)
        Dim MemoryStream1 As MemoryStream = New MemoryStream(fileAsByte)
        Return MemoryStream1.ToArray
    End Function

    Private Function saveAttach() As Byte()
        Dim fileName = Path.GetFileName(OpenFileDialog1.FileName.ToString())
        Dim content As Byte() = ReadFileToByteArray(fileName)
        Return content
    End Function
End Class