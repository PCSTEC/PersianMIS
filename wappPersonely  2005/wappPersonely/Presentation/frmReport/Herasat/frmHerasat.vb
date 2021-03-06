
Imports System.IO

Public Class frmHerasat
    Dim Bus_Person1 As New Bus_Person
    Dim dt_Sex As New DataTable
    Dim dt_City As New DataTable
    Dim dt_Military As New DataTable
    Dim dt_Engage As New DataTable
    Dim dt_Year As New DataTable
    Dim _SexID As Integer
    Dim _BirthCityID, _BirthCityCode As Integer
    Dim _IDIssueID, _IDIssueCode As Integer
    Dim _MilitaryID, _EngageTypeID As Integer
    Friend frmPRSMain1 As frmPRSMain
    Dim dt_MeedInfo As New DataTable
    Dim dt_Family As New DataTable
    Dim dt_Education As New DataTable
    Dim dtInvolvment As New DataTable
    Dim dtMoarref As New DataTable
    Dim _EyeColor, _HairColor, _FaceColor, _din As Integer

    Friend Property EngageTypeID() As Integer
        Get
            Return _EngageTypeID
        End Get
        Set(ByVal value As Integer)
            _EngageTypeID = value
        End Set
    End Property

    Friend Property IssueCityID() As Integer
        Get
            Return _IDIssueID
        End Get
        Set(ByVal value As Integer)
            _IDIssueID = value
        End Set
    End Property

    Friend Property IssueCityCode() As Integer
        Get
            Return _IDIssueCode
        End Get
        Set(ByVal value As Integer)
            _IDIssueCode = value
        End Set
    End Property

    Friend Property MilitaryID() As Integer
        Get
            Return _MilitaryID
        End Get
        Set(ByVal value As Integer)
            _MilitaryID = value
        End Set
    End Property

    Friend Property SexID() As Integer
        Get
            Return _SexID
        End Get
        Set(ByVal value As Integer)
            _SexID = value
        End Set
    End Property

    Friend Property BirthCityID() As Integer
        Get
            Return _BirthCityID
        End Get
        Set(ByVal value As Integer)
            _BirthCityID = value
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
    Friend Property HairColor() As Integer
        Get
            Return _HairColor
        End Get
        Set(ByVal value As Integer)
            _HairColor = value
        End Set
    End Property
    Friend Property din() As Integer
        Get
            Return _din
        End Get
        Set(ByVal value As Integer)
            _din = value
        End Set
    End Property
    Friend Property EyeColor() As Integer
        Get
            Return _EyeColor
        End Get
        Set(ByVal value As Integer)
            _EyeColor = value
        End Set
    End Property
    Friend Property FaceColor() As Integer
        Get
            Return _FaceColor
        End Get
        Set(ByVal value As Integer)
            _FaceColor = value
        End Set
    End Property


    Private Sub frmHerasatNew_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub


    Private Sub frmHerasatNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''اطلاعاتي كه از نرم افزار پرسنلي ميخواند را فقط بايد مشاهده نمايد
        UiGroupBox2.Enabled = False
        ''''''''
        Utility1.GetLanguageFarsi()
        Fillcombo()
    End Sub

    Private Sub FillGrdDossier()
        Dim dt As New DataTable
        Dim PersonCode As Integer = LBLPERSONCODE.Text.Trim
        dt = Bus_Employee1.GetRptHokmInfo(PersonCode)
        janus1.GetBindJGrid_DT(dt, grdDossier, ConString)
        janus1.setMyJGrid(grdDossier, "EmployeeID", "", 0, , , False)
        janus1.setMyJGrid(grdDossier, "EmployeeCode", "شماره حكم", 65)
        janus1.setMyJGrid(grdDossier, "EmissionDate", "تاريخ صدور", 85)
        janus1.setMyJGrid(grdDossier, "EngageType", "نوع استخدام", 150)
        janus1.setMyJGrid(grdDossier, "DepartName", "واحد سازماني", 225)
        janus1.setMyJGrid(grdDossier, "Posttxt", "پست", 250)
        janus1.setMyJGrid(grdDossier, "FirstName", "نام", 0, , , False)
        janus1.setMyJGrid(grdDossier, "LastName", "نام خانوادگي", 0, , , False)
        janus1.setMyJGrid(grdDossier, "EngageDate", "تاريخ استخدام", 0, , , False)
        janus1.setMyJGrid(grdDossier, "PersonCode", "كد پرسنلي", 0, , , False)
        janus1.setMyJGrid(grdDossier, "EmployeeActive", "EmployeeActive", 0, , , False)
        janus1.setMyJGrid(grdDossier, "EngageTypeID", "", 0, , , False)
        janus1.HighLightRows(grdDossier, "EmployeeActive", Janus.Windows.GridEX.ConditionOperator.Equal, 1, Color.Aqua)
    End Sub

    Private Sub Fillcombo()
        Dim dt_Eyecolor, dt_Haircolor, dt_FaceColor, dt_Din As New DataTable
        Dim dt, dt1, dt2, dt3, dt4, dt5, dt6, dt7, dt8, dt9, dt10 As New DataTable
        SqlStr = "Select * from tbhr_color order by Color"
        dt_Eyecolor = Persist1.GetDataTable(ConString, SqlStr)
        Persist1.FillCmb(dt_Eyecolor, cmbEyeColor, "ColorID", "Color")
        cmbEyeColor.SelectedValue = EyeColor

        dt_Haircolor = Persist1.GetDataTable(ConString, SqlStr)
        Persist1.FillCmb(dt_Haircolor, cmbHairColor, "ColorID", "Color")
        cmbHairColor.SelectedValue = HairColor

        dt_FaceColor = Persist1.GetDataTable(ConString, SqlStr)
        Persist1.FillCmb(dt_FaceColor, cmbFaceColor, "ColorID", "Color")
        cmbFaceColor.SelectedValue = FaceColor

        dt_Year = Bus_Other1.GetPeriod
        Persist1.FillCmb(dt_Year, cmbYear, "PeriodID", "PeriodYearID")
        cmbYear.Text = IraniDate1.GetYear_GivenDate(IraniDate1.GetIrani8Date_CurDate)
        dt_Engage = Bus_Engage1.GetEngageTypeIfo
        Persist1.FillCmb(dt_Engage, cmbEngage, "EngageTypeID", "EngageType")
        cmbEngage.SelectedValue = EngageTypeID
        dt_Sex = Bus_Other1.GetSexIfo
        Persist1.FillCmb(dt_Sex, cmbSex, "SexID", "Sextxt")
        cmbSex.SelectedValue = SexID
        dt_City = Bus_City1.GetCityIfo
        Persist1.FillCmb(dt_City, cmbBirthCity, "CityCode", "Citytxt")
        cmbBirthCity.SelectedValue = BirthCityCode
        dt_City = Bus_City1.GetCityIfos
        Persist1.FillCmb(dt_City, cmbIssueCity, "CityCode", "Citytxt")
        cmbIssueCity.SelectedValue = IssueCityCode
        dt_Military = Bus_Other1.GetMilitaryIfo
        Persist1.FillCmb(dt_Military, cmbMilitary, "MilitaryStateID", "MilitaryStateName")
        cmbMilitary.SelectedValue = MilitaryID
        SqlStr = ""
        SqlStr = "SELECT   Din_ID, Din FROM   tbHR_Din Order By Din"
        dt_Din = Persist1.GetDataTable(ConString, SqlStr)
        Persist1.FillCmb(dt_Din, cmbDin, "Din_ID", "Din")

        cmbDin.SelectedValue = din

        dt4 = Persist1.GetDataTable(ConString, "SELECT     IsarGariTypeID, IsarGariType    FROM         tbHR_IsarGariType  order by isargaritype")
        Persist1.FillCmb(dt4, cmbIsargariType, "IsarGariTypeID", "IsarGariType")

        dt5 = Persist1.GetDataTable(ConString, "SELECT     LanguageNameID, LanguageName   FROM         tbHR_LanguageName")
        Persist1.FillCmb(dt5, cmbLanguageName, "LanguageNameID", "LanguageName")

        dt6 = Persist1.GetDataTable(ConString, "SELECT     MilitaryStateName, SoldierID, MilitaryStateID  FROM         tbHR_MilitaryState")
        Persist1.FillCmb(dt6, cmbMilitaryState, "MilitaryStateID", "MilitaryStateName")

        dt7 = Persist1.GetDataTable(ConString, "SELECT     OrganSarbaziID, OrganSarbazi   FROM         tbHR_OrganSarbazi  order by OrganSarbazi")
        Persist1.FillCmb(dt7, cmbOrgan, "OrganSarbaziID", "OrganSarbazi")

        dt8 = Persist1.GetDataTable(ConString, "SELECT     OrganSarbaziID, OrganSarbazi   FROM         tbHR_OrganSarbazi  order by OrganSarbazi")
        Persist1.FillCmb(dt8, cmbOrganIsar, "OrganSarbaziID", "OrganSarbazi")

        dt9 = Persist1.GetDataTable(ConString, "SELECT      AffineID, AffineTxt   FROM         tbHR_Affine order by AffineTxt   ")
        Persist1.FillCmb(dt9, cmbDependency, "AffineID", "AffineTxt")

        dt10 = Persist1.GetDataTable(ConString, "SELECT   CountryID,  Countrytxt   FROM         tbHR_Country order by Countrytxt   ")
        Persist1.FillCmb(dt10, cmbCountrySafar, "CountryID", "Countrytxt")

    End Sub

    Private Sub clearForm()
        txtLength.Text = ""
        txtWeight.Text = ""
        cmbHairColor.Text = ""
        cmbEyeColor.Text = ""
        cmbFaceColor.Text = ""
        txtSocialSymbol.Text = ""
        txtTabeeaiat.Text = "ايراني"
        cmbDin.Text = ""
        txtMazhab.Text = "شيعه"
        txtOldLastName.Text = ""
        txtMostaarName.Text = ""
        txtOldAddress1.Text = ""
        txtOldAddress2.Text = ""
        txtOldAddress3.Text = ""
        txtOldAddress4.Text = ""

    End Sub

    Private Sub FillgrdGozarname()
        Dim dt As New DataTable
        SqlStr = _
        "SELECT     dbo.tbHR_Gozarnameh.GozarnameID, dbo.tbHR_Gozarnameh.GozarnameCode, dbo.tbHR_Gozarnameh.EmissionDate,  " & _
        "                      dbo.tbHR_Gozarnameh.EmissionPlace, dbo.tbHR_Person.PersonCode,  " & _
        "                      dbo.tbHR_Person.FirstName + '   ' + dbo.tbHR_Person.LastName AS prname " & _
        "FROM         dbo.tbHR_Gozarnameh INNER JOIN " & _
        "                      dbo.tbHR_Person ON dbo.tbHR_Gozarnameh.PersonCode = dbo.tbHR_Person.PersonCode " & _
        "WHERE     (dbo.tbHR_Gozarnameh.PersonCode = " & LBLPERSONCODE.Text.Trim & ")"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If dt.Rows.Count <> 0 Then
            janus1.GetBindJGrid_DT(dt, grdGozarname, ConString)
            janus1.setMyJGrid(grdGozarname, "GozarnameCode", "شماره گذرنامه", 125, , , True)
            janus1.setMyJGrid(grdGozarname, "GozarnameID", "", 0, , , False)
            janus1.setMyJGrid(grdGozarname, "EmissionPlace", "محل صدور گذرنامه", 200, , , True)
            janus1.setMyJGrid(grdGozarname, "PersonCode", "كد پرسنلي", 75, , , True)
            janus1.setMyJGrid(grdGozarname, "prname", "نام و نام خانوادگي", 200, , , True)
        End If

    End Sub

    Private Sub btnAddGozar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddGozar.Click
        If MsgBox("آيا از ثبت گذرنامه جديد فرد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@GozarnameCode_1", SqlDbType.NVarChar, txtGozarnum.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EmissionDate_2", SqlDbType.Char, txtEmissionDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EmissionPlace_3", SqlDbType.NVarChar, txtEmissionPlace.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_4", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EtebarGozarname_5", SqlDbType.Char, txtEtebarGozarname.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_Exe("insert_tbHR_Gozarnameh", ConString, True)
            FillgrdGozarname()
            MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnupGozar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupGozar.Click
        If MsgBox("آيا از ويرايش گذرنامه فرد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@GozarnameCode_1", SqlDbType.NVarChar, txtGozarnum.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EmissionDate_2", SqlDbType.Char, txtEmissionDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EmissionPlace_3", SqlDbType.NVarChar, txtEmissionPlace.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_4", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EtebarGozarname_5", SqlDbType.Char, txtEtebarGozarname.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@GozarnameID_6", SqlDbType.Int, grdGozarname.GetValue("GozarnameID"), ParameterDirection.Input)
            Persist1.Sp_Exe("Update_tbHR_Gozarnameh", ConString, True)
            FillgrdGozarname()
            MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnDelGozar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelGozar.Click
        If MsgBox("آيا از حذف گذرنامه فرد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@GozarnameID_1", SqlDbType.Int, grdGozarname.GetValue("GozarnameID"), ParameterDirection.Input)
            Persist1.Sp_Exe("Delete_tbHR_Gozarnameh", ConString, True)
            FillgrdGozarname()
            MsgBox("ركورد حذف شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnAddSafar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSafar.Click
        If MsgBox("آيا از ثبت ركورد جديد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            If grdGozarname.RecordCount > 0 Then
                Persist1.Sp_AddParam("@SafarDate_1", SqlDbType.Char, txtDateSafar.Text.Trim, ParameterDirection.Input)
                Persist1.Sp_AddParam("@SafarLength_2", SqlDbType.Int, txtSafarLen.Text.Trim, ParameterDirection.Input)
                Persist1.Sp_AddParam("@SafarCountry_3", SqlDbType.Int, cmbCountrySafar.SelectedValue, ParameterDirection.Input)
                Persist1.Sp_AddParam("@SafarGoal_4", SqlDbType.NVarChar, txtHadaf.Text.Trim, ParameterDirection.Input)
                Persist1.Sp_AddParam("@PersonCode_5", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
                Persist1.Sp_AddParam("@GozarnameID_6", SqlDbType.Int, grdGozarname.GetValue("GozarnameID"), ParameterDirection.Input)
                Persist1.Sp_AddParam("@SafarCity_7", SqlDbType.Int, cmbCitySafar.SelectedValue, ParameterDirection.Input)
                Persist1.Sp_Exe("insert_tbHR_Safar", ConString, True)
                FillgrdSafar()
                MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
            Else
                MsgBox("ابتدا گذرنامه را وارد نمایید")
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnUpSafar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpSafar.Click
        If MsgBox("آيا از ويرايش ركورد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@SafarDate_1", SqlDbType.Char, txtDateSafar.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@SafarLength_2", SqlDbType.Int, txtSafarLen.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@SafarCountry_3", SqlDbType.Int, cmbCountrySafar.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@SafarGoal_4", SqlDbType.NVarChar, txtHadaf.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_5", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@GozarnameID_6", SqlDbType.Int, grdSafar.GetValue("GozarnameID"), ParameterDirection.Input)
            Persist1.Sp_AddParam("@SafarCity_7", SqlDbType.Int, cmbCitySafar.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@SafarID_8", SqlDbType.Int, grdSafar.GetValue("SafarID"), ParameterDirection.Input)
            Persist1.Sp_Exe("update_tbHR_Safar", ConString, True)
            FillgrdSafar()
            MsgBox("ركورد ويرايش شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnDeleteSafar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteSafar.Click
        If MsgBox("آيا از حذف ركورد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@SafarID_1", SqlDbType.Int, grdSafar.GetValue("SafarID"), ParameterDirection.Input)
            Persist1.Sp_Exe("Delete_tbHR_Safar", ConString, True)
            FillgrdSafar()
            MsgBox("ركورد حذف شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub
    Private Sub FillgrdSafar()
        Dim dt As New DataTable
        'SqlStr = _
        '   "SELECT     dbo.tbHR_Person.PersonCode, dbo.tbHR_Person.FirstName + '   ' + dbo.tbHR_Person.LastName AS prname, dbo.tbHR_Safar.SafarID,  " & _
        '   "   dbo.tbHR_Safar.SafarDate, dbo.tbHR_Safar.SafarLength, dbo.tbHR_Safar.SafarCountry, dbo.tbHR_Safar.SafarGoal " & _
        '   "FROM         dbo.tbHR_Person INNER JOIN " & _
        '   "  dbo.tbHR_Safar ON dbo.tbHR_Person.PersonCode = dbo.tbHR_Safar.PersonCode " & _
        '   "WHERE     (dbo.tbHR_Person.PersonCode = " & LBLPERSONCODE.Text.Trim & ")"
        SqlStr = _
        "SELECT     dbo.tbHR_Person.PersonCode, dbo.tbHR_Person.FirstName + '   ' + dbo.tbHR_Person.LastName AS prname, dbo.tbHR_Safar.SafarID,  " & _
        "                      dbo.tbHR_Safar.SafarDate, dbo.tbHR_Safar.SafarLength, dbo.tbHR_Safar.SafarCountry, dbo.tbHR_Safar.SafarGoal, dbo.tbHR_Country.Countrytxt,  " & _
        "                      dbo.tbHR_Country.CountryID, dbo.tbHR_Safar.SafarCity, dbo.tbHR_City.Citytxt, dbo.tbHR_Safar.GozarnameID " & _
        "FROM         dbo.tbHR_Person INNER JOIN " & _
        "                      dbo.tbHR_Safar ON dbo.tbHR_Person.PersonCode = dbo.tbHR_Safar.PersonCode INNER JOIN " & _
        "                      dbo.tbHR_Country ON dbo.tbHR_Safar.SafarCountry = dbo.tbHR_Country.CountryID INNER JOIN " & _
        "                      dbo.tbHR_City ON dbo.tbHR_Safar.SafarCity = dbo.tbHR_City.CityID " & _
        "WHERE     (dbo.tbHR_Person.PersonCode =  " & LBLPERSONCODE.Text.Trim & ")"

        dt = Persist1.GetDataTable(ConString, SqlStr)
        If dt.Rows.Count <> 0 Then
            janus1.GetBindJGrid_DT(dt, grdSafar, ConString)
            janus1.setMyJGrid(grdSafar, "PersonCode", "كد پرسنلي", 75, , , True)
            janus1.setMyJGrid(grdSafar, "prname", "نام و نام خانوادگي", 120, , , True)
            janus1.setMyJGrid(grdSafar, "SafarDate", "تاريخ سفر", 75, , , True)
            janus1.setMyJGrid(grdSafar, "Countrytxt", "كشور", 75, , , True)
            janus1.setMyJGrid(grdSafar, "Citytxt", "شهر", 75, , , True)
            janus1.setMyJGrid(grdSafar, "SafarLength", "مدت به روز", 75, , , True)
            janus1.setMyJGrid(grdSafar, "SafarGoal", "هدف از سفر", 150, , , True)
            janus1.setMyJGrid(grdSafar, "SafarID", "", 0, , , False)
        End If

    End Sub

    Private Sub btnAddJanbazi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("آيا از ثبت ركورد جديد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@IsarGariTypeID_1", SqlDbType.Int, cmbIsargariType.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Dependency_2", SqlDbType.Int, cmbDependency.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@JanBaziDarsad_3", SqlDbType.Int, txtDarsadJanbazi.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ModdatEsarat_4", SqlDbType.Int, txtModdatEsarat.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ComputerNumber_5", SqlDbType.NVarChar, txtCompNum.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ModdateJebheh_6", SqlDbType.Int, txtJebhehModdat.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@BoniadName_7", SqlDbType.NVarChar, txtBoniad.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@DateJebheh_8", SqlDbType.Char, txtJanbaziDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_9", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@GavahiNumber_10", SqlDbType.VarChar, txtGavahiNum.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OrganSarbaziID_11", SqlDbType.Int, cmbOrganIsar.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ParvandeNumIsar_12", SqlDbType.Int, txtParvandeNumIsar.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_Exe("insert_tbHR_IsarGari", ConString, True)
            FillgrdJanbazi()
            MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnUpdateIsar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("آيا از ويرايش ركورد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@IsarGariTypeID_1", SqlDbType.Int, cmbIsargariType.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Dependency_2", SqlDbType.Int, cmbDependency.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@JanBaziDarsad_3", SqlDbType.Int, txtDarsadJanbazi.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ModdatEsarat_4", SqlDbType.Int, txtModdatEsarat.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ComputerNumber_5", SqlDbType.NVarChar, txtCompNum.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ModdateJebheh_6", SqlDbType.Int, txtJebhehModdat.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@BoniadName_7", SqlDbType.NVarChar, txtBoniad.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@DateJebheh_8", SqlDbType.Char, txtJanbaziDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@GavahiNumber_10", SqlDbType.VarChar, txtGavahiNum.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OrganSarbaziID_11", SqlDbType.Int, cmbOrganIsar.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@IsarGariID_12", SqlDbType.Int, grdJanbazi.GetValue("IsarGariID"), ParameterDirection.Input)
            Persist1.Sp_AddParam("@ParvandeNumIsar_13", SqlDbType.Int, txtParvandeNumIsar.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_Exe("Update_tbHR_IsarGari", ConString, True)
            FillgrdJanbazi()
            MsgBox("ركورد ويرايش شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnDeleteIsar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("آيا از حذف ركورد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@IsarGariID_12", SqlDbType.Int, grdJanbazi.GetValue("IsarGariID"), ParameterDirection.Input)
            Persist1.Sp_Exe("Delete_tbHR_IsarGari", ConString, True)
            FillgrdJanbazi()
            MsgBox("ركورد حذف شد", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub btnAddLanguage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ReadID, WriteID, ConversationID As Integer
        If RbReadingAali.Checked = True Then
            ReadID = 3
        ElseIf RbReadingKhoob.Checked = True Then
            ReadID = 2
        ElseIf RbReadingZaeef.Checked = True Then
            ReadID = 1
        End If

        If RbWritingAali.Checked = True Then
            WriteID = 3
        ElseIf RbWritingKhoob.Checked = True Then
            WriteID = 2
        ElseIf RbWritingZaeef.Checked = True Then
            WriteID = 1
        End If

        If RbConversationAali.Checked = True Then
            ConversationID = 3
        ElseIf RbConversationKhoob.Checked = True Then
            ConversationID = 2
        ElseIf RbConversationZaeef.Checked = True Then
            ConversationID = 1
        End If

        If MsgBox("آيا از ثبت ركورد جديد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@LanguageNameID_1", SqlDbType.Int, cmbLanguageName.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ReadingTypeID_2", SqlDbType.Int, ReadID, ParameterDirection.Input)
            Persist1.Sp_AddParam("@WriteTypeID_3", SqlDbType.Int, WriteID, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ConversationID_4", SqlDbType.Int, ConversationID, ParameterDirection.Input)
            Persist1.Sp_AddParam("@StateMent_5", SqlDbType.NVarChar, txtStateLanguage.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_6", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@InstitueName_7", SqlDbType.NVarChar, txtInstitue.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@DorehDate_8", SqlDbType.Char, txtLanguagedate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@InstitueTel_9", SqlDbType.Float, txtInstitueTel.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Duration_10", SqlDbType.Int, txtlanguageDuration.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Grade_11", SqlDbType.Int, txtLanguageGrade.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_Exe("insert_tbHR_Language", ConString, True)
            fillgrdLanguage()
            MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnUpdateLanguage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ReadID, WriteID, ConversationID As Integer
        If RbReadingAali.Checked = True Then
            ReadID = 3
        ElseIf RbReadingKhoob.Checked = True Then
            ReadID = 2
        ElseIf RbReadingZaeef.Checked = True Then
            ReadID = 1
        End If

        If RbWritingAali.Checked = True Then
            WriteID = 3
        ElseIf RbWritingKhoob.Checked = True Then
            WriteID = 2
        ElseIf RbWritingZaeef.Checked = True Then
            WriteID = 1
        End If

        If RbConversationAali.Checked = True Then
            ConversationID = 3
        ElseIf RbConversationKhoob.Checked = True Then
            ConversationID = 2
        ElseIf RbConversationZaeef.Checked = True Then
            ConversationID = 1
        End If

        If MsgBox("آيا از ويرايش ركورد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@LanguageNameID_1", SqlDbType.Int, grdLanguage.GetValue("LanguageNameID"), ParameterDirection.Input)
            Persist1.Sp_AddParam("@ReadingTypeID_2", SqlDbType.Int, ReadID, ParameterDirection.Input)
            Persist1.Sp_AddParam("@WriteTypeID_3", SqlDbType.Int, WriteID, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ConversationID_4", SqlDbType.Int, ConversationID, ParameterDirection.Input)
            Persist1.Sp_AddParam("@StateMent_5", SqlDbType.NVarChar, txtStateLanguage.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_6", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@InstitueName_7", SqlDbType.NVarChar, txtInstitue.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@DorehDate_8", SqlDbType.Char, txtLanguagedate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@InstitueTel_9", SqlDbType.Float, txtInstitueTel.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Duration_10", SqlDbType.Int, txtlanguageDuration.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Grade_11", SqlDbType.Int, txtLanguageGrade.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_Exe("Update_tbHR_Language", ConString, True)
            fillgrdLanguage()
            MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnDeleteLanguage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("آيا از حذف ركورد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@PersonCode_1", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@LanguageNameID_2", SqlDbType.Int, grdLanguage.GetValue("LanguageNameID"), ParameterDirection.Input)
            Persist1.Sp_Exe("Delete_tbHR_Language", ConString, True)
            fillgrdLanguage()
            MsgBox("ركورد حذف شد", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub btnAddSoldier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSoldier.Click

        If MsgBox("آيا از ثبت ركورد جديد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@MilitaryStateID_1", SqlDbType.Int, cmbLanguageName.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@BeginDate_2", SqlDbType.Char, txtBeginDateSarbazi.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EndDate_3", SqlDbType.Char, txtEnddateSarbazi.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@CardNumber_4", SqlDbType.NVarChar, txtCardNumSarbazi.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EmissionDate_5", SqlDbType.Char, txtEmissionDateSarbazi.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OrganSarbaziID_6", SqlDbType.Int, cmbOrgan.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_7", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_Exe("insert_tbHR_Sarbazi", ConString, True)
            fillgrdSarbazi()
            MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnUpdateSarbazi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateSarbazi.Click

        If MsgBox("آيا از ويرايش ركورد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@SarbaziID_1", SqlDbType.Int, grdSoldier.GetValue("SarbaziID"), ParameterDirection.Input)
            Persist1.Sp_AddParam("@MilitaryStateID_2", SqlDbType.Int, cmbLanguageName.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@BeginDate_3", SqlDbType.Char, txtBeginDateSarbazi.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EndDate_4", SqlDbType.Char, txtEnddateSarbazi.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@CardNumber_5", SqlDbType.NVarChar, txtCardNumSarbazi.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EmissionDate_6", SqlDbType.Char, txtEmissionDateSarbazi.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OrganSarbaziID_7", SqlDbType.Int, cmbOrgan.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_8", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_Exe("update_tbHR_Sarbazi", ConString, True)
            fillgrdSarbazi()
            MsgBox("ركورد ويرايش شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnDeleteSarbazi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteSarbazi.Click
        If MsgBox("آيا از حذف ركورد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@SarbaziID_1", SqlDbType.Int, grdLanguage.GetValue("SarbaziID"), ParameterDirection.Input)
            Persist1.Sp_Exe("Delete_tbHR_Sarbazi", ConString, True)
            fillgrdSarbazi()
            MsgBox("ركورد حذف شد", MsgBoxStyle.Information, "")
        End If
    End Sub

    Friend Sub fillgrdSarbazi()
        Dim dt As New DataTable
        Try

      
            SqlStr = _
            "SELECT    tbHR_Sarbazi.SarbaziID, tbHR_Person.PersonCode, tbHR_Person.FirstName, tbHR_Person.LastName, tbHR_Sarbazi.BeginDate, tbHR_Sarbazi.EndDate,  " & _
            "                      tbHR_Sarbazi.CardNumber, tbHR_Sarbazi.EmissionDate, tbHR_Sarbazi.OrganSarbaziID,  " & _
            "                      tbHR_MilitaryState.MilitaryStateName, tbHR_OrganSarbazi.OrganSarbazi " & _
            "FROM         tbHR_Sarbazi INNER JOIN " & _
            "                      tbHR_OrganSarbazi ON tbHR_Sarbazi.OrganSarbaziID = tbHR_OrganSarbazi.OrganSarbaziID INNER JOIN " & _
            "                      tbHR_Person ON tbHR_Sarbazi.PersonCode = tbHR_Person.PersonCode INNER JOIN " & _
            "                      tbHR_MilitaryState ON tbHR_Person.MilitaryStateID = tbHR_MilitaryState.MilitaryStateID" & _
            "  where dbo.tbHR_Sarbazi.PersonCode = " & LBLPERSONCODE.Text.Trim & ""
            dt = Persist1.GetDataTable(ConString, SqlStr)
            If dt.Rows.Count <> 0 Then
                dt = Persist1.GetDataTable(ConString, SqlStr)
                janus1.GetBindJGrid_DT(dt, grdSoldier, ConString)
                janus1.setMyJGrid(grdSoldier, "BeginDate", "تاريخ شروع", 150, , , True)
                janus1.setMyJGrid(grdSoldier, "EndDate", "تاريخ پايان", 150, , , True)
                janus1.setMyJGrid(grdSoldier, "CardNumber", "شماره كارت", 100, , , True)
                janus1.setMyJGrid(grdSoldier, "EmissionDate", "تاريخ صدور", 150, , , True)
                janus1.setMyJGrid(grdSoldier, "MilitaryStateName", "وضعيت", 100, , , True)
                janus1.setMyJGrid(grdSoldier, "OrganSarbazi", "نام ارگان", 200, , , True)
                janus1.setMyJGrid(grdSoldier, "SarbaziID", "", 0, , , False)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Friend Sub fillgrdLanguage()
        Dim dt As New DataTable

        SqlStr = _
        "SELECT     tbHR_Language.LanguageNameID, tbHR_Language.ReadingTypeID, tbHR_Language.WriteTypeID, tbHR_Language.ConversationID,  " & _
        "                      tbHR_Language.StateMent, tbHR_Language.PersonCode, tbHR_LanguageName.LanguageName, tbHR_LanguageType.LanguageType AS ReadingType, " & _
        "                       tbHR_LanguageType_2.LanguageType AS WriteType, tbHR_LanguageType_1.LanguageType AS Conversation " & _
        "FROM         tbHR_Language INNER JOIN " & _
        "                      tbHR_LanguageName ON tbHR_Language.LanguageNameID = tbHR_LanguageName.LanguageNameID INNER JOIN " & _
        "                      tbHR_LanguageType ON tbHR_Language.ReadingTypeID = tbHR_LanguageType.LanguageTypeID INNER JOIN " & _
        "                      tbHR_LanguageType tbHR_LanguageType_2 ON tbHR_Language.WriteTypeID = tbHR_LanguageType_2.LanguageTypeID INNER JOIN " & _
        "                      tbHR_LanguageType tbHR_LanguageType_1 ON tbHR_Language.ConversationID = tbHR_LanguageType_1.LanguageTypeID" & _
        "    WHERE     (dbo.tbHR_Language.PersonCode = '" & LBLPERSONCODE.Text.Trim & "')"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If dt.Rows.Count <> 0 Then
            dt = Persist1.GetDataTable(ConString, SqlStr)
            janus1.GetBindJGrid_DT(dt, grdLanguage, ConString)
            janus1.setMyJGrid(grdLanguage, "LanguageName", "زبان", 150, , , True)
            janus1.setMyJGrid(grdLanguage, "ReadingType", "سطح خواندن", 75, , , True)
            janus1.setMyJGrid(grdLanguage, "WriteType", "سطح نوشتن", 75, , , True)
            janus1.setMyJGrid(grdLanguage, "Conversation", "سطح محاوره", 75, , , True)
            janus1.setMyJGrid(grdLanguage, "StateMent", "توضيحات", 200, , , True)
            janus1.setMyJGrid(grdLanguage, "LanguageNameID", "", 0, , , False)
        End If
    End Sub

    Private Sub fillgrdTrainning()
        Dim dt_Training As New DataTable
        Dim janus1 As New JFrameWork.JanusGrid
        Dim PersonCode As Integer = LBLPERSONCODE.Text.Trim
        dt_Training = Bus_Training1.GetTrainingIfo(PersonCode)
        janus1.GetBindJGrid_DT(dt_Training, grdTraining, ConString)
        janus1.setMyJGrid(grdTraining, "PersonCode", "كد پرسنلي", 0, , , False)
        janus1.setMyJGrid(grdTraining, "CourceName", "نام دوره", 150)
        janus1.setMyJGrid(grdTraining, "CourcePlace", "نام آموزشگاه", 150)
        janus1.setMyJGrid(grdTraining, "Citytxt", "محل برگزاري", 120)
        janus1.setMyJGrid(grdTraining, "BeginDate", "تاريخ شروع", 80)
        janus1.setMyJGrid(grdTraining, "EndDate", "تاريخ پايان", 80)
        janus1.setMyJGrid(grdTraining, "SumTime", "مدت دوره", 55)
        janus1.setMyJGrid(grdTraining, "Average", "نمره", 55)
        janus1.setMyJGrid(grdTraining, "CityID", "", 0, , , False)
        janus1.setMyJGrid(grdTraining, "CityCode", "", 0, , , False)
        janus1.setMyJGrid(grdTraining, "TrainingID", "", 0, , , False)
        janus1.setMyJGrid(grdTraining, "PersonID", "", 0, , , False)
    End Sub

    Private Sub FillgrdJanbazi()
        Dim dt As New DataTable
        SqlStr = _
        "SELECT     dbo.tbHR_Person.FirstName + '  ' + dbo.tbHR_Person.LastName AS PrName, dbo.tbHR_IsarGariType.IsarGariType, dbo.tbHR_IsarGari.Dependency,  " & _
        "                      dbo.tbHR_IsarGari.JanBaziDarsad, dbo.tbHR_IsarGari.ModdatEsarat, dbo.tbHR_IsarGari.ComputerNumber, dbo.tbHR_IsarGari.ModdateJebheh,  " & _
        "                      dbo.tbHR_IsarGari.BoniadName, dbo.tbHR_IsarGari.DateJebheh, dbo.tbHR_IsarGariType.IsarGariTypeID, dbo.tbHR_IsarGari.PersonCode,  " & _
        "                      dbo.tbHR_Affine.AffineTxt , dbo.tbHR_IsarGari.IsarGariID , dbo.tbHR_IsarGari.GavahiNumber, dbo.tbHR_IsarGari.OrganSarbaziID" & _
        " FROM         dbo.tbHR_IsarGari INNER JOIN " & _
        "                      dbo.tbHR_IsarGariType ON dbo.tbHR_IsarGari.IsarGariTypeID = dbo.tbHR_IsarGariType.IsarGariTypeID INNER JOIN " & _
        "                      dbo.tbHR_Person ON dbo.tbHR_IsarGari.PersonCode = dbo.tbHR_Person.PersonCode INNER JOIN " & _
        "                      dbo.tbHR_Affine ON dbo.tbHR_IsarGari.Dependency = dbo.tbHR_Affine.AffineID " & _
        "WHERE     (dbo.tbHR_IsarGari.PersonCode =  " & LBLPERSONCODE.Text.Trim & ")"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If dt.Rows.Count <> 0 Then
            janus1.GetBindJGrid_DT(dt, grdJanbazi, ConString)
            janus1.setMyJGrid(grdJanbazi, "PrName", "نام و نام خانوادگي", 150, , , True)
            janus1.setMyJGrid(grdJanbazi, "IsarGariType", "نوع ايثارگري", 75, , , True)
            janus1.setMyJGrid(grdJanbazi, "AffineTxt", "وابستگي", 120, , , True)
            janus1.setMyJGrid(grdJanbazi, "JanBaziDarsad", "درصدجانبازي", 75, , , True)
            janus1.setMyJGrid(grdJanbazi, "ModdatEsarat", "مدت اسارت", 75, , , True)
            janus1.setMyJGrid(grdJanbazi, "ComputerNumber", "شماره كامپيوتري", 75, , , True)
            janus1.setMyJGrid(grdJanbazi, "ModdateJebheh", "مدت جبهه", 75, , , True)
            janus1.setMyJGrid(grdJanbazi, "BoniadName", "نام بنياد", 75, , , True)
            janus1.setMyJGrid(grdJanbazi, "DateJebheh", "تاريخ", 75, , , True)
            janus1.setMyJGrid(grdJanbazi, "OrganSarbaziID", "", 0, , , False)
            janus1.setMyJGrid(grdJanbazi, "GavahiNumber", "شماره گواهي", 75, , , True)
            janus1.setMyJGrid(grdJanbazi, "Dependency", "", 0, , , False)
            janus1.setMyJGrid(grdJanbazi, "IsarGariID", "", 0, , , False)
        End If

    End Sub

    Private Sub cmbCountrySafar_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCountrySafar.SelectedValueChanged
        Dim dt As New DataTable
        Try
            dt = Persist1.GetDataTable(ConString, "SELECT     CityID, Citytxt  FROM  tbHR_City  WHERE     (CountryID = " & cmbCountrySafar.SelectedValue & ")  ORDER BY Citytxt")
            Persist1.FillCmb(dt, cmbCitySafar, "CityID", "Citytxt")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItem3.Click
        FillgrdGozarname()
        FillgrdSafar()
    End Sub

    Private Sub TabItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItem2.Click
        FillGrdDossier()
    End Sub

    Private Sub TabItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItem5.Click
        fillgrdTrainning()
        FillgrdEducation()
        fillgrdLanguage()
    End Sub

    Private Sub TabItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItem7.Click
        fillgrdSarbazi()
        FillgrdJanbazi()
    End Sub

    Friend Sub FillgrdEngageTypeChange()
        Dim dt As New DataTable
        SqlStr = _
        "SELECT     EngageTypeChangeID, EngageTypeOld, EngageTypeOldBDate, EngageTypeOldEDate, EngageTypeNew, EngageTypeNewBDate, PersonCode, prName, " & _
        "                       Description " & _
        "FROM         Vw_EngageTypeChange " & _
        "WHERE     (PersonCode = " & LBLPERSONCODE.Text.Trim & ") " & _
        "ORDER BY EngageTypeOldBDate"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        janus1.GetBindJGrid_DT(dt, grdEngageTypeChange, ConString)
        janus1.setMyJGrid(grdEngageTypeChange, "EngageTypeChangeID", "", 0, , , False)
        janus1.setMyJGrid(grdEngageTypeChange, "prName", "نام", 125, , , True)
        janus1.setMyJGrid(grdEngageTypeChange, "EngageTypeOld", "نوع استخدام قبلي", 100, , , True)
        janus1.setMyJGrid(grdEngageTypeChange, "EngageTypeOldBDate", "شروع استخدام قبلي", 100, , , True)
        janus1.setMyJGrid(grdEngageTypeChange, "EngageTypeOldEDate", "پايان استخدام قبلي", 100, , , True)
        janus1.setMyJGrid(grdEngageTypeChange, "EngageTypeNew", "نوع استخدام جديد", 100, , , True)
        janus1.setMyJGrid(grdEngageTypeChange, "EngageTypeNewBDate", "شروع استخدام فعلي", 100, , , True)
        janus1.setMyJGrid(grdEngageTypeChange, "Description", "توضيحات", 150, , , True)
        janus1.setMyJGrid(grdEngageTypeChange, "PersonCode", "", 0, , , False)
    End Sub

    Private Sub UiButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("آيا از درج ركورد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@EngageTypeOld_1", SqlDbType.VarChar, txtEngageTypeOld.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EngageTypeOldBDate_2", SqlDbType.Char, txtEngageTypeOldBDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EngageTypeOldEDate_3", SqlDbType.Char, txtEngageTypeOldEDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EngageTypeNew_4", SqlDbType.VarChar, txtEngageTypeNew.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EngageTypeNewBDate_5", SqlDbType.Char, txtEngageTypeNewBDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Description_6", SqlDbType.NVarChar, txtEngageTypeNewEDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_7", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_Exe("INSERT_EngageTypeChange", ConString, True)
            FillgrdEngageTypeChange()
            MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub TabItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FillgrdEngageTypeChange()
    End Sub

    Private Sub UiButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("آيا از ويرايش ركورد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@EngageTypeOld_1", SqlDbType.VarChar, txtEngageTypeOld.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EngageTypeOldBDate_2", SqlDbType.Char, txtEngageTypeOldBDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EngageTypeOldEDate_3", SqlDbType.Char, txtEngageTypeOldEDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EngageTypeNew_4", SqlDbType.VarChar, txtEngageTypeNew.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EngageTypeNewBDate_5", SqlDbType.Char, txtEngageTypeNewBDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Description_6", SqlDbType.NVarChar, txtEngageTypeNewEDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_7", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EngageTypeChangeID_8", SqlDbType.Int, grdEngageTypeChange.GetValue("EngageTypeChangeID"), ParameterDirection.Input)
            Persist1.Sp_Exe("Update_EngageTypeChange", ConString, True)
            FillgrdEngageTypeChange()
            MsgBox("ركورد ويرايش شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub UiButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("آيا از حذف ركورد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@EngageTypeChangeID_1", SqlDbType.Int, grdEngageTypeChange.GetValue("EngageTypeChangeID"), ParameterDirection.Input)
            Persist1.Sp_Exe("Delete_EngageTypeChange", ConString, True)
            FillgrdEngageTypeChange()
            MsgBox("ركورد حذف شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If

    End Sub

    Friend Sub FillgrdDossierOld()
        Try
            Dim dt_Dossier As New DataTable
            dt_Dossier = Bus_Dossier1.GetDossierInfo(LBLPERSONCODE.Text.Trim)
            janus1.GetBindJGrid_DT(dt_Dossier, grdDossierOld, ConString)
            janus1.setMyJGrid(grdDossierOld, "JobCo", "نام محل كار", 120)
            janus1.setMyJGrid(grdDossierOld, "Jobtxt", "عنوان شغل", 120)
            janus1.setMyJGrid(grdDossierOld, "Relatedtext", "نوع شغل", 85)
            janus1.setMyJGrid(grdDossierOld, "AssureTxt", "عنوان بيمه", 100)
            janus1.setMyJGrid(grdDossierOld, "Sallary", "حقوق ماهيانه", 75)
            janus1.setMyJGrid(grdDossierOld, "BeginDate", "تاريخ شروع", 80)
            janus1.setMyJGrid(grdDossierOld, "EndDate", "تاريخ پايان", 80)
            janus1.setMyJGrid(grdDossierOld, "DaySum", "سوابق به روز", 75)
            janus1.setMyJGrid(grdDossierOld, "Tarkekar", "علت ترك كار", 80)
            janus1.setMyJGrid(grdDossierOld, "JobType", "نوع كار", 80)
            janus1.setMyJGrid(grdDossierOld, "Adress", "آدرس", 75)
            janus1.setMyJGrid(grdDossierOld, "DossierID", "", 0, , , False)
            janus1.setMyJGrid(grdDossierOld, "AssureID", "", 0, , , False)
            janus1.setMyJGrid(grdDossierOld, "RelatedID", "", 0, , , False)
            janus1.setMyJGrid(grdDossierOld, "PersonCode", "كد پرسنلي", 0, , , False)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TabItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItem8.Click
        FillgrdDossierOld()
        FillgrdMoarref()
    End Sub

    Private Sub btnSaveChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChange.Click
        Dim str As String
        Dim dt As New DataTable

        If MsgBox("آيا از ثبت اطلاعات مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            str = "select * from tbHerasat_Personely where personid = " & lblPRSONID.Text.Trim & ""
            dt = Persist1.GetDataTable(ConString, str)
            If dt.Rows.Count <> 0 Then
                ''''حذف قبلي ها
                ''Persist1.Sp_AddParam("@PersonID_1", SqlDbType.Int, lblPRSONID.Text.Trim, ParameterDirection.Input)
                ''Persist1.Sp_Exe("delete_tbHerasat_Personely", ConString, True)
                MsgBox("قبلا اطلاعات فرد را ثبت نموده ايد.درصورت تمايل اطلاعات را ويرايش نماييد", MsgBoxStyle.YesNo, "")
                Exit Sub
            End If
            ''''ثبت تغييرات
            Persist1.Sp_AddParam("@PersonID_1", SqlDbType.Int, lblPRSONID.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_2", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ParvandeNum_3", SqlDbType.Char, txtParvandeNum.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@MostaarName_4", SqlDbType.NVarChar, txtMostaarName.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OldLastName_5", SqlDbType.NVarChar, txtOldLastName.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Tabeeiat_6", SqlDbType.NVarChar, txtTabeeaiat.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Din_7", SqlDbType.Int, cmbDin.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Mazhab_8", SqlDbType.NVarChar, txtMazhab.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ParvandeCount_9", SqlDbType.Int, txtParvandehCount.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@UpdateTime_10", SqlDbType.Char, txtupdateTime.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Length_11", SqlDbType.Int, txtLength.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Weight_12", SqlDbType.Int, txtWeight.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@HairColor_13", SqlDbType.Int, cmbHairColor.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EyeColor_14", SqlDbType.Int, cmbEyeColor.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@FaceColor_15", SqlDbType.Int, cmbFaceColor.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@SpecificSymbol_16", SqlDbType.NVarChar, txtSocialSymbol.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OldAddress_17", SqlDbType.NVarChar, txtOldAddress1.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OldAddress2_18", SqlDbType.NVarChar, txtOldAddress2.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OldAddress3_19", SqlDbType.NVarChar, txtOldAddress3.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OldAddress4_20", SqlDbType.NVarChar, txtOldAddress4.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_Exe("insert_tbHerasat_Personely", ConString, True)
            MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnUpdateChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateChange.Click
        Dim str As String
        Dim dt As New DataTable

        If MsgBox("آيا از ثبت تغييرات مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            str = "select * from tbHerasat_Personely where personid = " & lblPRSONID.Text.Trim & ""
            dt = Persist1.GetDataTable(ConString, str)
            If dt.Rows.Count <> 0 Then
                ''''حذف قبلي ها
                Persist1.Sp_AddParam("@PersonID_1", SqlDbType.Int, lblPRSONID.Text.Trim, ParameterDirection.Input)
                Persist1.Sp_Exe("delete_tbHerasat_Personely", ConString, True)
            End If
            ''''ثبت تغييرات
            Persist1.Sp_AddParam("@PersonID_1", SqlDbType.Int, lblPRSONID.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_2", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ParvandeNum_3", SqlDbType.Char, txtParvandeNum.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@MostaarName_4", SqlDbType.NVarChar, txtMostaarName.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OldLastName_5", SqlDbType.NVarChar, txtOldLastName.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Tabeeiat_6", SqlDbType.NVarChar, txtTabeeaiat.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Din_7", SqlDbType.Int, cmbDin.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Mazhab_8", SqlDbType.NVarChar, txtMazhab.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@ParvandeCount_9", SqlDbType.Int, txtParvandehCount.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@UpdateTime_10", SqlDbType.Char, txtupdateTime.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Length_11", SqlDbType.Int, txtLength.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Weight_12", SqlDbType.Int, txtWeight.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@HairColor_13", SqlDbType.Int, cmbHairColor.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@EyeColor_14", SqlDbType.Int, cmbEyeColor.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@FaceColor_15", SqlDbType.Int, cmbFaceColor.SelectedValue, ParameterDirection.Input)
            Persist1.Sp_AddParam("@SpecificSymbol_16", SqlDbType.NVarChar, txtSocialSymbol.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OldAddress_17", SqlDbType.NVarChar, txtOldAddress1.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OldAddress2_18", SqlDbType.NVarChar, txtOldAddress2.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OldAddress3_19", SqlDbType.NVarChar, txtOldAddress3.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@OldAddress4_20", SqlDbType.NVarChar, txtOldAddress4.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_Exe("insert_tbHerasat_Personely", ConString, True)
            MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnDeleteInf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteInf.Click
        Dim Str As String
        Dim dt As New DataTable
        If MsgBox("آيا از حذف مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Str = "select * from tbHerasat_Personely where personID = " & lblPRSONID.Text.Trim & ""
            dt = Persist1.GetDataTable(ConString, Str)
            If dt.Rows.Count <> 0 Then
                ''''حذف
                Persist1.Sp_AddParam("@PersonID_1", SqlDbType.Int, lblPRSONID.Text.Trim, ParameterDirection.Input)
                Persist1.Sp_Exe("delete_tbHerasat_Personely", ConString, True)
                MsgBox("اطلاعات حذف شد", MsgBoxStyle.Information, "")
            End If

        End If
    End Sub

    Private Sub btnDossierhr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDossierhr.Click
 
        If MsgBox("آيا مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@Adress_1", SqlDbType.NVarChar, txtDossierAdress.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@JobType_2", SqlDbType.NVarChar, txtJobType.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Tarkekar_3", SqlDbType.NVarChar, txtTarkekar.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@DossierID_4", SqlDbType.Int, grdDossierOld.GetValue("DossierID"), ParameterDirection.Input)
            Persist1.Sp_Exe("update_DossierHR", ConString, True)
            MsgBox("اطلاعات ثبت شد", MsgBoxStyle.Information, "")
        End If


    End Sub

    Private Sub TabItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItem10.Click
        FillgrdMeed()
    End Sub

    Friend Sub FillgrdMeed()
        Try
            dt_MeedInfo.Rows.Clear()
            dt_MeedInfo = Bus_Meed1.MeedInfo(LBLPERSONCODE.Text.Trim)
            janus1.GetBindJGrid_DT(dt_MeedInfo, grdMeed, ConString)
            janus1.setMyJGrid(grdMeed, "MeedTypeText", "نوع", 85)
            janus1.setMyJGrid(grdMeed, "MeedReason", "شرح", 400)
            janus1.setMyJGrid(grdMeed, "MeedDate", "تاريخ", 100)
            janus1.setMyJGrid(grdMeed, "MeedLetterNo", "شماره نامه", 75)
            janus1.setMyJGrid(grdMeed, "MeedID", "", 0, , , False)
            janus1.setMyJGrid(grdMeed, "PersonID", "", 0, , , False)
            janus1.setMyJGrid(grdMeed, "MeedTypeID", "", 0, , , False)
            janus1.setMyJGrid(grdMeed, "PersonCode", "كد پرسنلي", 0, , , False)
        Catch ex As Exception

        End Try

    End Sub

    Friend Sub FillgrdFamily()
        Try
            dt_Family = Bus_Family1.GetFamilyInfo(LBLPERSONCODE.Text.Trim)
            janus1.GetBindJGrid_DT(dt_Family, grdFamily, ConString)
            janus1.setMyJGrid(grdFamily, "FirstName", "نام", 125)
            janus1.setMyJGrid(grdFamily, "LastName", "نام خانوادگي", 140)
            janus1.setMyJGrid(grdFamily, "BirthDate", "تاريخ تولد", 100)
            janus1.setMyJGrid(grdFamily, "IDNum", "شماره شناسنامه", 110)
            janus1.setMyJGrid(grdFamily, "CityNameBirthday", "محل تولد", 75)
            janus1.setMyJGrid(grdFamily, "CityNameIssue", "محل صدور", 75)
            janus1.setMyJGrid(grdFamily, "AffineTxt", "نسبت", 75)
            janus1.setMyJGrid(grdFamily, "AffineID", "", 0, , , False)
            janus1.setMyJGrid(grdFamily, "BirthCityID", "", 0, , , False)
            janus1.setMyJGrid(grdFamily, "BirthCityCode", "", 0, , , False)
            janus1.setMyJGrid(grdFamily, "IssueID", "", 0, , , False)
            janus1.setMyJGrid(grdFamily, "IssueCode", "", 0, , , False)
            janus1.setMyJGrid(grdFamily, "NationalCode", "", 0, , , False)
            janus1.setMyJGrid(grdFamily, "FamilyID", "", 0, , , False)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TabItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItem11.Click
        FillgrdFamily()
    End Sub
    Friend Sub FillgrdEducation()
        Try
            dt_Education = Bus_Education1.GetEducationInfo(LBLPERSONCODE.Text.Trim)
            janus1.GetBindJGrid_DT(dt_Education, grdEducation, ConString)
            janus1.setMyJGrid(grdEducation, "FirstName", "نام", 75)
            janus1.setMyJGrid(grdEducation, "LastName", "نام خانوادگي", 110)
            janus1.setMyJGrid(grdEducation, "DiplomaName", "مدرك", 80)
            janus1.setMyJGrid(grdEducation, "Branchtxt", "شاخه تحصيلي", 85)
            janus1.setMyJGrid(grdEducation, "AttitudeName", "گرايش", 80)
            janus1.setMyJGrid(grdEducation, "StudyPlacetxt", "محل تحصيل", 100)
            janus1.setMyJGrid(grdEducation, "BeginDate", "تاريخ شروع", 85)
            janus1.setMyJGrid(grdEducation, "EndDate", "تاريخ اتمام", 85)
            janus1.setMyJGrid(grdEducation, "Average", "معدل", 50)
            janus1.setMyJGrid(grdEducation, "Citytxt", "نام شهر", 0, , , False)
            janus1.setMyJGrid(grdEducation, "StudyPlaceType", "نوع محل تحصيل", 0, , , False)
            janus1.setMyJGrid(grdEducation, "Active", "", 0, , , False)
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
            janus1.setMyJGrid(grdEducation, "PersonCode", "كد پرسنلي", 0, , , False)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TabItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabItem13.Click
        FillgrdInvolvment()
    End Sub

    Friend Sub FillgrdInvolvment()

        Try
            SqlStr = _
              "SELECT    dbo.tbHR_Involvment.InvolvmentID, dbo.tbHR_Involvment.InvolvmentDate, dbo.tbHR_Involvment.InvolvmentTxt,  " & _
              "  dbo.tbHR_Person.PersonCode, dbo.tbHR_Person.FirstName + '  ' + dbo.tbHR_Person.LastName AS prname " & _
              "FROM         dbo.tbHR_Involvment INNER JOIN " & _
              "   dbo.tbHR_Person ON dbo.tbHR_Involvment.PersonCode = dbo.tbHR_Person.PersonCode " & _
              " where dbo.tbHR_Involvment.PersonCode = " & LBLPERSONCODE.Text.Trim & " " & _
              "ORDER BY dbo.tbHR_Involvment.InvolvmentDate"
            dtInvolvment = Persist1.GetDataTable(ConString, SqlStr)
            janus1.GetBindJGrid_DT(dtInvolvment, grdInvolvment, ConString)
            janus1.setMyJGrid(grdInvolvment, "InvolvmentID", "", 0, , , False)
            janus1.setMyJGrid(grdInvolvment, "InvolvmentDate", "تاريخ", 75)
            janus1.setMyJGrid(grdInvolvment, "InvolvmentTxt", "درگيري", 250)
            janus1.setMyJGrid(grdInvolvment, "prname", "نام", 150)
            janus1.setMyJGrid(grdInvolvment, "PersonCode", "", 0, , , False)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSaveInvolvment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveInvolvment.Click

        If MsgBox("آيا مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@InvolvmentDate_1", SqlDbType.Char, txtInvolvementDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@InvolvmentTxt_2", SqlDbType.NVarChar, txtInvolvementDesc.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_3", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_Exe("insert_tbHR_Involvment", ConString, True)
            FillgrdInvolvment()
            MsgBox("اطلاعات ثبت شد", MsgBoxStyle.Information, "")
        End If

    End Sub

    Private Sub btnUpInvolvment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpInvolvment.Click

        If MsgBox("آيا مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@InvolvmentDate_1", SqlDbType.Char, txtInvolvementDate.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@InvolvmentTxt_2", SqlDbType.NVarChar, txtInvolvementDesc.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCode_3", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@InvolvmentID_4", SqlDbType.Int, grdInvolvment.GetValue("InvolvmentID"), ParameterDirection.Input)
            Persist1.Sp_Exe("Update_tbHR_Involvment", ConString, True)
            FillgrdInvolvment()
            MsgBox("اطلاعات ثبت شد", MsgBoxStyle.Information, "")
        End If

    End Sub

    Private Sub btnDelInvolvment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelInvolvment.Click

        If MsgBox("آيا مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@InvolvmentID_1", SqlDbType.Int, grdInvolvment.GetValue("InvolvmentID"), ParameterDirection.Input)
            Persist1.Sp_Exe("Delete_tbHR_Involvment", ConString, True)
            FillgrdInvolvment()
            MsgBox("اطلاعات حذف شد", MsgBoxStyle.Information, "")
        End If

    End Sub

    Private Sub btnSaveMoarref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveMoarref.Click

        If MsgBox("آيا مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@Maoarref_1", SqlDbType.NVarChar, txtMoarrefType.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Descibe_2", SqlDbType.NVarChar, txtMoarrefDesc.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCdoe_3", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_Exe("Insert_tbHR_Moarref", ConString, True)
            FillgrdMoarref()
            MsgBox("اطلاعات ثبت شد", MsgBoxStyle.Information, "")
        End If

    End Sub

    Friend Sub FillgrdMoarref()
        Try
            SqlStr = _
                    "SELECT     dbo.tbHR_Moarref.MaoarrefID, dbo.tbHR_Moarref.Maoarref, dbo.tbHR_Moarref.Descibe, dbo.tbHR_Moarref.PersonCdoe,  " & _
                    "     dbo.tbHR_Person.FirstName + '   ' + dbo.tbHR_Person.LastName AS prName " & _
                    "FROM         dbo.tbHR_Person INNER JOIN " & _
                    "  dbo.tbHR_Moarref ON dbo.tbHR_Person.PersonCode = dbo.tbHR_Moarref.PersonCdoe" & _
                    " Where PersonCdoe = " & LBLPERSONCODE.Text.Trim & " "

            dtMoarref = Persist1.GetDataTable(ConString, SqlStr)
            janus1.GetBindJGrid_DT(dtMoarref, grdMoarref, ConString)
            janus1.setMyJGrid(grdMoarref, "MaoarrefID", "", 0, , , False)
            janus1.setMyJGrid(grdMoarref, "PersonCdoe", "", 0, , , False)
            janus1.setMyJGrid(grdMoarref, "Maoarref", "نوع معرف", 250)
            janus1.setMyJGrid(grdMoarref, "Descibe", "نام", 150)
            janus1.setMyJGrid(grdMoarref, "PersonCode", "", 0, , , False)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnUpMoarref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpMoarref.Click

        If MsgBox("آيا مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@Maoarref_1", SqlDbType.NVarChar, txtMoarrefType.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Descibe_2", SqlDbType.NVarChar, txtMoarrefDesc.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PersonCdoe_3", SqlDbType.Int, LBLPERSONCODE.Text.Trim, ParameterDirection.Input)
            Persist1.Sp_AddParam("@MaoarrefID_4", SqlDbType.Int, grdMoarref.GetValue("MaoarrefID"), ParameterDirection.Input)
            Persist1.Sp_Exe("Updatet_tbHR_Moarref", ConString, True)
            FillgrdMoarref()
            MsgBox("اطلاعات ثبت شد", MsgBoxStyle.Information, "")
        End If

    End Sub

    Private Sub btnDelMoarref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelMoarref.Click

        If MsgBox("آيا از حذف مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Persist1.Sp_AddParam("@MaoarrefID_1", SqlDbType.Int, grdMoarref.GetValue("MaoarrefID"), ParameterDirection.Input)
            Persist1.Sp_Exe("Delete_tbHR_Moarref", ConString, True)
            FillgrdMoarref()
            MsgBox("اطلاعات حذف شد", MsgBoxStyle.Information, "")
        End If

    End Sub

    Private Sub btnAddJanbazi_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddJanbazi.Click
        SqlStr = "INSERT INTO [dbo].[tbHR_IsarGari]           ([IsarGariTypeID] ,[Dependency],[JanBaziDarsad],[ModdatEsarat],[ComputerNumber],[ModdateJebheh],[BoniadName],[DateJebheh],[PersonCode],[GavahiNumber],[OrganSarbaziID],[ParvandeNumIsar])  " & _
                                                    " VALUES  ('" & cmbIsargariType.SelectedValue & "','" & cmbDependency.SelectedValue & "','" & txtDarsadJanbazi.Text & "','" & txtModdatEsarat.Text & "','" & txtCompNum.Text & "','" & txtJebhehModdat.Text & "','" & txtBoniad.Text & "','" & txtJanbaziDate.Text & "','" & LBLPERSONCODE.Text.Trim & "','" & txtGavahiNum.Text & "','" & cmbOrgan.SelectedValue & "','" & txtParvandeNumIsar.Text & "')"
        Persist1.GetDataAccess(SqlStr, 2, ConString)
    End Sub

    Private Sub btnDeleteIsar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteIsar.Click
        SqlStr = "Delete tbHR_IsarGari where IsarGariID=" & grdJanbazi.GetValue("grdJanbazi")
        Persist1.GetDataAccess(SqlStr, 2, ConString)
    End Sub

    
End Class