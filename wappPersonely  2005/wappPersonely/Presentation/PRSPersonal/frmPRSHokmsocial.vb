Public Class frmPRSHokmsocial
    Dim Bus_Person1 As New Bus_Person
    Dim dtMDepart As New DataTable
    Dim dtPerson As New DataTable
    Dim dtEmployee As New DataTable
    Dim dt_Year As New DataTable
    Dim dtGroupFe, dtHouseFe, dtMarriageFe, dtSoldierFe, dtFoodFe As New DataTable
    Dim GroupFee, HouseFee, UnderTestFee, FoodFee, DayAmountFee, TimeAmountFee, Barjeste, Differ, Sanavat, OverPost, Salary, OverJazb, GradeFee, MarriageFee, SoldierFee As Double
    Dim Year, PersonID, PersonCode, EngageTypeID, MaxTime, EmployeID_Old, MaxKarkard, YearID, PriodeID, EmployTypeID, PostID, DescribID, JobTitleID, GroupID, HouseFeeCode, MarriageFeeCode, SoldierID, FoodFeeID, mandegari, Bon, GradeNum As Integer
    Dim EndDateEntesab As String
    Dim PostCode, EngageDate, BeginDate, ExecDate, EmissionDate, EndDate, MoavagheDate As String
    Dim Active As Boolean
    Friend frmPRSMain1 As frmPRSMain
    Dim EmployeeCode As Integer
    Dim dt_EmployeeCode As New DataTable
    Dim sqlstr2, sqlstr1 As String
    Dim dt_Family, dt_Employee As New DataTable
    Dim MarriageType, sqlstr3 As String
    Dim ChildCount As Integer
    Dim GroupSalary, SumrootSalary, SumAll As Double
    Private DA1 As New SqlClient.SqlDataAdapter
    Dim dt_EmployeeType As New DataTable
    Dim Bus_MDepart1 As New Bus_MDepart

    Private Sub frmPRSHokmsocial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmPRSHokmsocial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillMyDataGrid()
        FillMyCombo()
        ''''نظر سنجي
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub

    Friend Sub FillMyCombo()
        SqlStr = "Select * From tbHR_Period"
        dt_Year = Persist1.GetDataTable(ConString, SqlStr)
        Persist1.FillCmb(dt_Year, cmbYear, "PeriodID", "YearID")
        SqlStr = "SELECT *  FROM tbHR_EmployeeType  ORDER BY EmployeeType"
        dt_EmployeeType = Persist1.GetDataTable(ConString, SqlStr)
        Persist1.FillCmb(dt_EmployeeType, cmbEmployeeType, "EmployeeTypeID", "EmployeeType")
    End Sub

    Friend Sub FillMyDataGrid()
        '''''پر كردن گريد واحدها
        dtMDepart = Bus_MDepart1.GetMDepartInfo
        grdSelect1.Add_ColDt(dtMDepart)
        Persist1.GetBindGrid_Dt(grdMDepart, ConString, dtMDepart)
        Dim tbs As New DataGridTableStyle
        Persist1.SetGridStyle_Dt(tbs, Persistent.DataAccess.TxtBol.Text, dtMDepart, grdMDepart, "DepartCode", "كد واحد", 90, True, True)
        Persist1.SetGridStyle_Dt(tbs, Persistent.DataAccess.TxtBol.Text, dtMDepart, grdMDepart, "DepartName", "نام واحد", 170, True, True)
        Persist1.SetGridStyle_Dt(tbs, Persistent.DataAccess.TxtBol.BooleanTxt, dtMDepart, grdMDepart, "sel", "گزينش", 60, True, True)
    End Sub

    Friend Sub FillgrdPerson()
        ''''پر كردن گريد پرسنل
        SqlStr = "SELECT   * FROM VwHR_HokmSocial WHERE (MDepartCode  in " & grdSelect1.get_Collection_String(grdMDepart, 0, dtMDepart, 2) & " )"
        dtPerson = Persist1.GetDataTable(ConString, SqlStr)
        grdSelect1.Add_ColDt(dtPerson)
        Persist1.GetBindGrid_Dt(grdPerson, ConString, dtPerson)
        Persist1.GetBindGrid_Dt(grdPerson, ConString, dtPerson)
        Dim tbs1 As New DataGridTableStyle
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "PersonCode", "كد پرسنلي", 70, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "Name", "نام", 190, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.BooleanTxt, dtPerson, grdPerson, "sel", "گزينش", 60, True, True)
    End Sub

    Private Sub grdPerson_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPerson.Click
        grdSelect1.Grid_State(grdPerson, 2)
        DgSelect2.DG = grdPerson
        DgSelect2.DT = dtPerson
    End Sub

    Private Sub grdMDepart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdMDepart.Click
        grdSelect1.Grid_State(grdMDepart, 2)
        DgSelect1.DG = grdMDepart
        DgSelect1.DT = dtMDepart
        FillgrdPerson()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DgSelect1_WlEvent(ByVal sender As Object, ByVal e As IKIDUtility.DgSelect.MyEventArgs) Handles DgSelect1.WlEvent
        grdSelect1.Grid_State(grdMDepart, 2)
        DgSelect1.DG = grdMDepart
        DgSelect1.DT = dtMDepart
        FillgrdPerson()
    End Sub

    Private Sub DgSelect2_WlEvent(ByVal sender As Object, ByVal e As IKIDUtility.DgSelect.MyEventArgs) Handles DgSelect2.WlEvent
        grdSelect1.Grid_State(grdPerson, 2)
        DgSelect2.DG = grdPerson
        DgSelect2.DT = dtPerson
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ''كنترل وجود مقادير حقوق و حق مسكن و ... در جداول
        Dim dtSanavat, dtDayCount As New DataTable
        Dim DayCount As Integer
        Dim sanavatnew As Double
        Dim sanavatforday As Double
        Dim SStr As String
        If ckbHoghooghDate.Checked = True Then
            Dim sqlstr As String
            Dim dt As New DataTable

            sqlstr = "Select * From tbHR_GroupFee where PeriodID = " & cmbYear.SelectedValue & ""
            dt = Persist1.GetDataTable(ConString, sqlstr)

            If dt.DefaultView.Count = 0 Then
                MsgBox("ابتدا بايد حقوق سال بعد را محاسبه و در جدول وارد نماييد", MsgBoxStyle.Information, "")
                Exit Sub
            End If
            sqlstr = "Select * From tbHR_SoldierFee where PeriodID =  " & cmbYear.SelectedValue & ""
            dt.Rows.Clear()
            dt = Persist1.GetDataTable(ConString, sqlstr)
            If dt.DefaultView.Count = 0 Then
                MsgBox("ابتدا بايد حق سربازي سال بعد را محاسبه و در جدول وارد نماييد", MsgBoxStyle.Information, "")
                Exit Sub
            End If
            sqlstr = "Select * From tbHR_MarriageFee where PeriodID =  " & cmbYear.SelectedValue & ""
            dt.Rows.Clear()
            dt = Persist1.GetDataTable(ConString, sqlstr)
            If dt.DefaultView.Count = 0 Then
                MsgBox("ابتدا بايد حق اولاد سال بعد را محاسبه و در جدول وارد نماييد", MsgBoxStyle.Information, "")
                Exit Sub
            End If
            sqlstr = "Select * From tbHR_HouseFee where PeriodID =  " & cmbYear.SelectedValue & ""
            dt.Rows.Clear()
            dt = Persist1.GetDataTable(ConString, sqlstr)
            If dt.DefaultView.Count = 0 Then
                MsgBox("ابتدا بايد حق مسكن سال بعد را محاسبه و در جدول وارد نماييد", MsgBoxStyle.Information, "")
                Exit Sub
            End If
            sqlstr = "Select * From tbHR_FoodFee where PeriodID =  " & cmbYear.SelectedValue & ""
            dt.Rows.Clear()
            dt = Persist1.GetDataTable(ConString, sqlstr)
            If dt.DefaultView.Count = 0 Then
                MsgBox("ابتدا بايد حق خواروبار سال بعد را محاسبه و در جدول وارد نماييد", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        End If
        ''كنترل صحيح بودن تاريخ ها
        If txtBeginDate.Enabled = True Then
            If txtBeginDate.Text > txtEndDate.Text Then
                MsgBox(" تاريخ شروع از تاريخ اتمام بزرگتر است  ", MsgBoxStyle.Information, "")
                Exit Sub

            ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtBeginDate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtEndDate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtEmissionDate.Text)) = True Then
                Exit Sub
            End If
            If chkGharardad.Checked = False Then
                If IraniDate1.TestDate(IraniDate1.Numericdate(txtExecuteDate.Text)) = True Then
                    Exit Sub
                End If
            End If
        End If
        ''صدور حكم
        If MsgBox("آيا از ثبت حكم دسته جمعي مطمئن هستيد ؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SqlStr = ""
            SqlStr = "Select YearID from tbHR_Period where PeriodID = " & cmbYear.SelectedValue & ""
            dt_Year = Persist1.GetDataTable(ConString, SqlStr)
            Year = dt_Year.DefaultView.Item(0).Item("YearID")
            SqlStr = ""
            SqlStr = "Select * From tbHR_Employee WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 0, dtPerson, 2) & " ) AND Active = 1"
            dtEmployee = Persist1.GetDataTable(ConString, SqlStr)
            For i = 0 To dtEmployee.DefaultView.Count - 1
                SqlStr = "SELECT     MAX(EmployeeCode) AS MAXEmployeeCode FROM tbHR_Employee  WHERE(PriodeID = " & cmbYear.SelectedValue & ") GROUP BY PriodeID"
                dt_EmployeeCode = Persist1.GetDataTable(ConString, SqlStr)
                If dt_EmployeeCode.Rows.Count = 0 Then
                    '  EmployeeCode = 1
                    SqlStr = "SELECT     MAX(EmployeeCode) AS MAXEmployeeCode FROM tbHR_Employee  WHERE(PriodeID = " & cmbYear.SelectedValue - 1 & ") GROUP BY PriodeID"
                    dt_EmployeeCode = Persist1.GetDataTable(ConString, SqlStr)

                    EmployeeCode = dt_EmployeeCode.DefaultView.Item(0).Item("MAXEmployeeCode") + 1

                Else
                    EmployeeCode = dt_EmployeeCode.DefaultView.Item(0).Item("MAXEmployeeCode") + 1
                End If
                PersonID = dtEmployee.DefaultView.Item(i).Item("PersonID")
                PersonCode = dtEmployee.DefaultView.Item(i).Item("PersonCode")
                PostID = dtEmployee.DefaultView.Item(i).Item("PostID")
                PostCode = dtEmployee.DefaultView.Item(i).Item("PostCode")
                UnderTestFee = Math.Ceiling(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("UnderTestFee"), 0)) ' Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("UnderTestFee"), 0))
                GroupID = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("GroupID"), 0)
                ''''محاسبه رتبه بايد بر اساس سال صورت بگيرد
                '''''فقط براي وقتيكه حكم اجراي مصوبه مي زند در غير اينصورت بايد فرمول حذف شود فرمول براي سال 92
                'If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد

                'SqlStr = "Select GradeFee From tbHR_GroupFee where GroupID = " & dtEmployee.DefaultView.Item(i).Item("GroupID") & " And PeriodID = " & cmbYear.SelectedValue & " And EngageTypeID = " & dtEmployee.DefaultView.Item(i).Item("EngageTypeID") & ""
                'dtGroupFe = Persist1.GetDataTable(ConString, SqlStr)
                'GradeFee = Math.Ceiling(dtGroupFe.DefaultView.Item(0).Item("GradeFee") * dtEmployee.DefaultView.Item(i).Item("GradeNum"))

                'Else ''''محاسبه طبق سال قدیم
                'GradeFee = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("GradeFee"), 0) * 1.12)
                GradeFee = Math.Ceiling(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("GradeFee"), 0))
                'End If

                ''GradeFee = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("GradeFee"), 0))

                HouseFeeCode = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("HouseFeeCode"), 0)
                MarriageFeeCode = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("MarriageFeeCode"), 0)
                SoldierID = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("SoldierID"), 0)
                FoodFeeID = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("FoodFeeID"), 375)
                ''''محاسبه فوق العاده جذب و فوق العاده پست بايد بر اساس سال صورت بگيرد
                ''''فقط براي وقتيكه حكم اجراي مصوبه مي زند در غير اينصورت بايد فرمول حذف شود فرمول براي سال 93

                OverJazb = Math.Ceiling(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("OverJazb"), 0))
                '' OverJazb = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("OverJazb"), 0) * 1.12)

                If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
                    OverPost = Math.Ceiling(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("OverPost"), 0))
                Else
                    OverPost = Math.Ceiling(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("OverPost"), 0))
                End If
                'OverPost = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("OverPost"), 0) * 1.12)
                'OverJazb = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("OverJazb"), 0))
                'OverPost = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("OverPost"), 0))

                If dtEmployee.DefaultView.Item(i).Item("EngageTypeID") <> 5 Then
                    ''''محاسبه سنوات
                    SqlStr = " Select Sanvat  FROM tbHR_GroupFee WHERE (PeriodID =  " & cmbYear.SelectedValue & ") AND (GroupID = " & dtEmployee.DefaultView.Item(i).Item("GroupID") & ") AND (EngageTypeID = " & dtEmployee.DefaultView.Item(i).Item("EngageTypeID") & ")"
                    dtSanavat = Persist1.GetDataTable(ConString, SqlStr)
                    ''''محاسبه سنوات براي افرادي كه كمتر از يك سال كار نموده اند
                    SStr = _
                    "SELECT     PersonCode, SumDate " & _
                    "FROM         FunDossierInIKID() FunDossierInIKID " & _
                    "WHERE     (PersonCode = " & dtEmployee.DefaultView.Item(i).Item("PersonCode") & ")"
                    dtDayCount = Persist1.GetDataTable(ConString, SStr)
                    DayCount = dtDayCount.DefaultView.Item(0).Item("SumDate")
                    If DayCount < 365 Then
                        SqlStr = " Select Sanvat  FROM tbHR_GroupFee WHERE (PeriodID = 26 ) AND (GroupID = " & dtEmployee.DefaultView.Item(i).Item("GroupID") & ") AND (EngageTypeID = " & dtEmployee.DefaultView.Item(i).Item("EngageTypeID") & ")"
                        dtSanavat = Persist1.GetDataTable(ConString, SqlStr)

                        sanavatforday = (dtSanavat.DefaultView.Item(0).Item("Sanvat")) / 365
                        sanavatnew = sanavatforday * DayCount
                    Else
                        sanavatnew = dtSanavat.DefaultView.Item(0).Item("Sanvat")
                    End If
                    ''''محاسبه سنوات بايد بر اساس سال صورت بگيرد
                    ''''فقط براي وقتيكه حكم اجراي مصوبه مي زند در غير اينصورت بايد فرمول حذف شود فرمول براي سال 92


                    If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
                        ' Sanavat = (Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("Sanavat"), 0) * 1.12) + Math.Ceiling(sanavatnew) ' Decimal.Round(sanavatnew)
                        Sanavat = (Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("Sanavat"), 0))
                    Else
                        Sanavat = (Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("Sanavat"), 0))
                    End If

                End If
                ''''محاسبه تفاوت تطبيق و برجسته بايد بر اساس سال صورت بگيرد
                ''''فقط براي وقتيكه حكم اجراي مصوبه مي زند در غير اينصورت بايد فرمول حذف شود فرمول براي سال 92
                If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
                    Differ = dtEmployee.DefaultView.Item(i).Item("Differ") * 1.12
                Else
                    Differ = dtEmployee.DefaultView.Item(i).Item("Differ")
                End If

                If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
                    Barjeste = Math.Ceiling(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("Barjeste"), 0) * 1.12) ' Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("Barjeste"), 0) * 1.07)
                Else
                    Barjeste = Math.Ceiling(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("Barjeste"), 0))
                End If
                'Differ = dtEmployee.DefaultView.Item(i).Item("Differ")
                'Barjeste = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("Barjeste"), 0))

                Salary = 0
                JobTitleID = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("JobTitleID"), 0)
                DescribID = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("DescribID"), 1)
                EngageDate = dtEmployee.DefaultView.Item(i).Item("EngageDate")
                EngageTypeID = dtEmployee.DefaultView.Item(i).Item("EngageTypeID")







                Bon = dtEmployee.DefaultView.Item(i).Item("Bon")
                GradeNum = dtEmployee.DefaultView.Item(i).Item("GradeNum")
                EndDateEntesab = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("EndDateEntesab"), "")
                If ckbEmployeeCode.Checked = True Then
                    EmployTypeID = cmbEmployeeType.SelectedValue
                Else
                    EmployTypeID = dtEmployee.DefaultView.Item(i).Item("EmployTypeID")
                End If
                PriodeID = cmbYear.SelectedValue
                YearID = Year
                ''''تفاوت بين حكم و قرارداد
                If chkGharardad.Checked = True Then
                    BeginDate = txtBeginDate.Text.Trim
                    EndDate = txtEndDate.Text.Trim
                Else
                    BeginDate = dtEmployee.DefaultView.Item(i).Item("BeginDate")
                    EndDate = dtEmployee.DefaultView.Item(i).Item("EndDate")
                End If
                EmissionDate = txtEmissionDate.Text.Trim

                If chkGharardad.Checked = True Then
                    ExecDate = dtEmployee.DefaultView.Item(i).Item("ExecDate")
                    MoavagheDate = dtEmployee.DefaultView.Item(i).Item("ExecDate")
                Else
                    ExecDate = txtExecuteDate.Text.Trim
                    MoavagheDate = txtExecuteDate.Text.Trim
                End If
                TimeAmountFee = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("TimeAmountFee"), 0)
                DayAmountFee = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("DayAmountFee"), 0)
                MaxTime = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("MaxTime"), 0)
                MaxKarkard = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("MaxKarkard"), 0)
                Active = True
                If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
                    If dtEmployee.DefaultView.Item(i).Item("EngageTypeID") = 1 Or dtEmployee.DefaultView.Item(i).Item("EngageTypeID") = 2 Then
                        SqlStr = ""
                        SqlStr = "Select GroupFee From tbHR_GroupFee where GroupID = " & dtEmployee.DefaultView.Item(i).Item("GroupID") & " And PeriodID = " & cmbYear.SelectedValue & " And EngageTypeID = " & dtEmployee.DefaultView.Item(i).Item("EngageTypeID") & ""
                        dtGroupFe = Persist1.GetDataTable(ConString, SqlStr)
                        GroupFee = Math.Ceiling(dtGroupFe.DefaultView.Item(0).Item("GroupFee")) '  GroupFee = Decimal.Round(dtGroupFe.DefaultView.Item(0).Item("GroupFee"))
                    Else
                        GroupFee = Math.Ceiling(dtEmployee.DefaultView.Item(i).Item("GroupFee")) ' Decimal.Round(dtEmployee.DefaultView.Item(i).Item("GroupFee"))
                    End If
                Else     ''''محاسبه طبق سال گذشته
                    GroupFee = Math.Ceiling(dtEmployee.DefaultView.Item(i).Item("GroupFee")) ' Decimal.Round(dtEmployee.DefaultView.Item(i).Item("GroupFee"))
                End If

                If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
                    SqlStr = ""
                    SqlStr = "Select HouseFeeCode, HouseFee, PeriodID FROM tbHR_HouseFee WHERE (PeriodID = " & cmbYear.SelectedValue & ") AND (HouseFeeCode = " & dtEmployee.DefaultView.Item(i).Item("HouseFeeCode") & ")"
                    dtHouseFe = Persist1.GetDataTable(ConString, SqlStr)
                    HouseFee = Math.Ceiling(dtHouseFe.DefaultView.Item(0).Item("HouseFee")) '  Decimal.Round(dtHouseFe.DefaultView.Item(0).Item("HouseFee"))
                Else     ''''محاسبه طبق سال گذشته
                    HouseFee = Math.Ceiling(dtEmployee.DefaultView.Item(i).Item("HouseFee")) ' Decimal.Round(dtEmployee.DefaultView.Item(i).Item("HouseFee"))
                End If

                If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
                    SqlStr = ""
                    SqlStr = "SELECT MarriageFeeCode, MarriageFee, PeriodID FROM tbHR_MarriageFee WHERE (PeriodID = " & cmbYear.SelectedValue & ") AND (MarriageFeeCode = " & dtEmployee.DefaultView.Item(i).Item("MarriageFeeCode") & ")"
                    dtMarriageFe = Persist1.GetDataTable(ConString, SqlStr)
                    MarriageFee = Math.Ceiling(dtMarriageFe.DefaultView.Item(0).Item("MarriageFee")) ' Decimal.Round(dtMarriageFe.DefaultView.Item(0).Item("MarriageFee"))
                Else     ''''محاسبه طبق سال گذشته
                    MarriageFee = Math.Ceiling(dtEmployee.DefaultView.Item(i).Item("MarriageFee")) ' Decimal.Round(dtEmployee.DefaultView.Item(i).Item("MarriageFee"))
                End If

                If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
                    SqlStr = ""
                    SqlStr = "Select SoldierFee From tbHR_SoldierFee WHERE (PeriodID = " & cmbYear.SelectedValue & ") AND (GroupID = " & dtEmployee.DefaultView.Item(i).Item("GroupID") & ") AND (SoldierID = " & dtEmployee.DefaultView.Item(i).Item("SoldierID") & ")"
                    dtSoldierFe = Persist1.GetDataTable(ConString, SqlStr)
                    SoldierFee = Math.Ceiling(dtSoldierFe.DefaultView.Item(0).Item("SoldierFee")) ' Decimal.Round(dtSoldierFe.DefaultView.Item(0).Item("SoldierFee"))
                Else     ''''محاسبه طبق سال گذشته
                    SoldierFee = Math.Ceiling(dtEmployee.DefaultView.Item(i).Item("SoldierFee")) 'Decimal.Round(dtEmployee.DefaultView.Item(i).Item("SoldierFee"))
                End If

                If ckbHoghooghDate.Checked = True Then    ''''محاسبه طبق سال جديد
                    SqlStr = ""
                    SqlStr = "Select FoodFee FROM tbHR_FoodFee WHERE (PeriodID = " & cmbYear.SelectedValue & ")"
                    dtFoodFe = Persist1.GetDataTable(ConString, SqlStr)
                    FoodFee = Math.Ceiling(dtFoodFe.DefaultView.Item(0).Item("FoodFee")) 'Decimal.Round(dtFoodFe.DefaultView.Item(0).Item("FoodFee"))
                Else   ''''محاسبه طبق سال گذشته
                    FoodFee = Math.Ceiling(dtEmployee.DefaultView.Item(i).Item("FoodFee")) ' Decimal.Round(dtEmployee.DefaultView.Item(i).Item("FoodFee"))
                End If

                If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
                    'mandegari = Decimal.Round((dtEmployee.DefaultView.Item(i).Item("OverPost") * 365 * 5 / 36500 + dtEmployee.DefaultView.Item(i).Item("MandegariFee")) * 1.12)
                    mandegari = dtEmployee.DefaultView.Item(i).Item("MandegariFee")
                Else
                    mandegari = dtEmployee.DefaultView.Item(i).Item("MandegariFee")
                End If
                'mandegari = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("MandegariFee"), 0))


                ''غير فعال كردن حكم قبلي
                Bus_Employee1.updateActiveEmploy(dtEmployee.DefaultView.Item(i).Item("EmployeeID"), False)
                ''ثبت حكم جديد
                ''Bus_Employee1.InsertEmployee(EmployeeCode, PersonID, PersonCode, PostID, PostCode, UnderTestFee, GroupID, GroupFee, GradeFee, HouseFeeCode, HouseFee, MarriageFeeCode, MarriageFee, SoldierID, SoldierFee, FoodFeeID, FoodFee, OverJazb, OverPost, Decimal.Round(Sanavat), Differ, Barjeste, Salary, JobTitleID, DescribID, EngageDate, EngageTypeID, EmployTypeID, PriodeID, YearID, BeginDate, EmissionDate, ExecDate, MoavagheDate, EndDate, TimeAmountFee, DayAmountFee, MaxTime, MaxKarkard, 1, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text)

                Bus_Employee1.InsertEmployee(EmployeeCode, PersonID, PersonCode, PostID, PostCode, UnderTestFee, GroupID, GroupFee, GradeFee, HouseFeeCode, HouseFee, MarriageFeeCode, MarriageFee, SoldierID, SoldierFee, FoodFeeID, FoodFee, OverJazb, OverPost, Decimal.Round(Sanavat), Differ, Barjeste, Salary, JobTitleID, DescribID, EngageDate, EngageTypeID, EmployTypeID, PriodeID, YearID, BeginDate, EmissionDate, ExecDate, MoavagheDate, EndDate, TimeAmountFee, DayAmountFee, MaxTime, MaxKarkard, 1, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, mandegari, Bon, GradeNum, EndDateEntesab)


            Next
            MsgBox("تمامي حكمها ثبت شدند", MsgBoxStyle.Information, "")
            frmPRSMain1.FillgrdPerson(SelectStr.Current)
            frmPRSMain1.lblVazeeiat.Text = "جاري"
        Else
            Exit Sub
        End If





















        ' '' ''كنترل وجود مقادير حقوق و حق مسكن و ... در جداول
        ' ''Dim dtSanavat, dtDayCount As New DataTable
        ' ''Dim DayCount As Integer
        ' ''Dim sanavatnew As Double
        ' ''Dim sanavatforday As Double
        ' ''Dim SStr As String
        ' ''If ckbHoghooghDate.Checked = True Then
        ' ''    Dim sqlstr As String
        ' ''    Dim dt As New DataTable
        ' ''    sqlstr = "Select * From tbHR_GroupFee where PeriodID = " & cmbYear.SelectedValue & ""
        ' ''    dt = Persist1.GetDataTable(ConString, sqlstr)
        ' ''    If dt.DefaultView.Count = 0 Then
        ' ''        MsgBox("ابتدا بايد حقوق سال بعد را محاسبه و در جدول وارد نماييد", MsgBoxStyle.Information, "")
        ' ''        Exit Sub
        ' ''    End If
        ' ''    sqlstr = "Select * From tbHR_SoldierFee where PeriodID =  " & cmbYear.SelectedValue & ""
        ' ''    dt.Rows.Clear()
        ' ''    dt = Persist1.GetDataTable(ConString, sqlstr)
        ' ''    If dt.DefaultView.Count = 0 Then
        ' ''        MsgBox("ابتدا بايد حق سربازي سال بعد را محاسبه و در جدول وارد نماييد", MsgBoxStyle.Information, "")
        ' ''        Exit Sub
        ' ''    End If
        ' ''    sqlstr = "Select * From tbHR_MarriageFee where PeriodID =  " & cmbYear.SelectedValue & ""
        ' ''    dt.Rows.Clear()
        ' ''    dt = Persist1.GetDataTable(ConString, sqlstr)
        ' ''    If dt.DefaultView.Count = 0 Then
        ' ''        MsgBox("ابتدا بايد حق اولاد سال بعد را محاسبه و در جدول وارد نماييد", MsgBoxStyle.Information, "")
        ' ''        Exit Sub
        ' ''    End If
        ' ''    sqlstr = "Select * From tbHR_HouseFee where PeriodID =  " & cmbYear.SelectedValue & ""
        ' ''    dt.Rows.Clear()
        ' ''    dt = Persist1.GetDataTable(ConString, sqlstr)
        ' ''    If dt.DefaultView.Count = 0 Then
        ' ''        MsgBox("ابتدا بايد حق مسكن سال بعد را محاسبه و در جدول وارد نماييد", MsgBoxStyle.Information, "")
        ' ''        Exit Sub
        ' ''    End If
        ' ''    sqlstr = "Select * From tbHR_FoodFee where PeriodID =  " & cmbYear.SelectedValue & ""
        ' ''    dt.Rows.Clear()
        ' ''    dt = Persist1.GetDataTable(ConString, sqlstr)
        ' ''    If dt.DefaultView.Count = 0 Then
        ' ''        MsgBox("ابتدا بايد حق خواروبار سال بعد را محاسبه و در جدول وارد نماييد", MsgBoxStyle.Information, "")
        ' ''        Exit Sub
        ' ''    End If
        ' ''End If
        ' '' ''كنترل صحيح بودن تاريخ ها
        ' ''If txtBeginDate.Enabled = True Then
        ' ''    If txtBeginDate.Text > txtEndDate.Text Then
        ' ''        MsgBox(" تاريخ شروع از تاريخ اتمام بزرگتر است  ", MsgBoxStyle.Information, "")
        ' ''        Exit Sub

        ' ''    ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtBeginDate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtEndDate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtEmissionDate.Text)) = True Then
        ' ''        Exit Sub
        ' ''    End If
        ' ''    If chkGharardad.Checked = False Then
        ' ''        If IraniDate1.TestDate(IraniDate1.Numericdate(txtExecuteDate.Text)) = True Then
        ' ''            Exit Sub
        ' ''        End If
        ' ''    End If
        ' ''End If
        ' '' ''صدور حكم
        ' ''If MsgBox("آيا از ثبت حكم دسته جمعي مطمئن هستيد ؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
        ' ''    SqlStr = ""
        ' ''    SqlStr = "Select YearID from tbHR_Period where PeriodID = " & cmbYear.SelectedValue & ""
        ' ''    dt_Year = Persist1.GetDataTable(ConString, SqlStr)
        ' ''    Year = dt_Year.DefaultView.Item(0).Item("YearID")
        ' ''    SqlStr = ""
        ' ''    SqlStr = "Select * From tbHR_Employee WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 0, dtPerson, 2) & " ) AND Active = 1"
        ' ''    dtEmployee = Persist1.GetDataTable(ConString, SqlStr)
        ' ''    For i = 0 To dtEmployee.DefaultView.Count - 1
        ' ''        SqlStr = "SELECT     MAX(EmployeeCode) AS MAXEmployeeCode FROM tbHR_Employee  WHERE(PriodeID = " & cmbYear.SelectedValue & ") GROUP BY PriodeID"
        ' ''        dt_EmployeeCode = Persist1.GetDataTable(ConString, SqlStr)
        ' ''        If dt_EmployeeCode.Rows.Count = 0 Then
        ' ''            EmployeeCode = 1
        ' ''        Else
        ' ''            EmployeeCode = dt_EmployeeCode.DefaultView.Item(0).Item("MAXEmployeeCode") + 1
        ' ''        End If
        ' ''        PersonID = dtEmployee.DefaultView.Item(i).Item("PersonID")
        ' ''        PersonCode = dtEmployee.DefaultView.Item(i).Item("PersonCode")
        ' ''        PostID = dtEmployee.DefaultView.Item(i).Item("PostID")
        ' ''        PostCode = dtEmployee.DefaultView.Item(i).Item("PostCode")
        ' ''        UnderTestFee = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("UnderTestFee"), 0))
        ' ''        GroupID = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("GroupID"), 0)
        ' ''        ''''محاسبه رتبه بايد بر اساس سال صورت بگيرد
        ' ''        '''''فقط براي وقتيكه حكم اجراي مصوبه مي زند در غير اينصورت بايد فرمول حذف شود فرمول براي سال 90
        ' ''        '''91 برای محاسبه افزایش حقوق در سال جدید      GradeFee = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("GradeFee"), 0) * 1.06)

        ' ''        GradeFee = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("GradeFee"), 0))

        ' ''        HouseFeeCode = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("HouseFeeCode"), 0)
        ' ''        MarriageFeeCode = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("MarriageFeeCode"), 0)
        ' ''        SoldierID = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("SoldierID"), 0)
        ' ''        FoodFeeID = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("FoodFeeID"), 375)
        ' ''        ''''محاسبه فوق العاده جذب و فوق العاده پست بايد بر اساس سال صورت بگيرد
        ' ''        ''''فقط براي وقتيكه حكم اجراي مصوبه مي زند در غير اينصورت بايد فرمول حذف شود فرمول براي سال 90
        ' ''        '91 برای محاسبه افزایش حقوق در سال جدید       OverJazb = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("OverJazb"), 0) * 1.06)
        ' ''        '91 برای محاسبه افزایش حقوق در سال جدید       OverPost = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("OverPost"), 0) * 1.06)
        ' ''        OverJazb = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("OverJazb"), 0))
        ' ''        OverPost = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("OverPost"), 0))

        ' ''        If dtEmployee.DefaultView.Item(i).Item("EngageTypeID") <> 5 Then
        ' ''            ''''محاسبه سنوات
        ' ''            SqlStr = " Select Sanvat  FROM tbHR_GroupFee WHERE (PeriodID =  " & cmbYear.SelectedValue & ") AND (GroupID = " & dtEmployee.DefaultView.Item(i).Item("GroupID") & ") AND (EngageTypeID = " & dtEmployee.DefaultView.Item(i).Item("EngageTypeID") & ")"
        ' ''            dtSanavat = Persist1.GetDataTable(ConString, SqlStr)
        ' ''            ''''محاسبه سنوات براي افرادي كه كمتر از يك سال كار نموده اند
        ' ''            SStr = _
        ' ''            "SELECT     PersonCode, SumDate " & _
        ' ''            "FROM         FunDossierInIKID() FunDossierInIKID " & _
        ' ''            "WHERE     (PersonCode = " & dtEmployee.DefaultView.Item(i).Item("PersonCode") & ")"
        ' ''            dtDayCount = Persist1.GetDataTable(ConString, SStr)
        ' ''            DayCount = dtDayCount.DefaultView.Item(0).Item("SumDate")
        ' ''            If DayCount < 365 Then
        ' ''                sanavatforday = (dtSanavat.DefaultView.Item(0).Item("Sanvat")) / 365
        ' ''                sanavatnew = sanavatforday * DayCount
        ' ''            Else
        ' ''                sanavatnew = dtSanavat.DefaultView.Item(0).Item("Sanvat")
        ' ''            End If
        ' ''            ''''محاسبه سنوات بايد بر اساس سال صورت بگيرد
        ' ''            ''''فقط براي وقتيكه حكم اجراي مصوبه مي زند در غير اينصورت بايد فرمول حذف شود فرمول براي سال 90
        ' ''            '91 برای محاسبه افزایش حقوق در سال جدید   Sanavat = (Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("Sanavat"), 0) * 1.06) + Decimal.Round(sanavatnew)
        ' ''            Sanavat = (Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("Sanavat"), 0))

        ' ''        Else
        ' ''            Sanavat = 0
        ' ''        End If
        ' ''        ''''محاسبه تفاوت تطبيق و برجسته بايد بر اساس سال صورت بگيرد
        ' ''        ''''فقط براي وقتيكه حكم اجراي مصوبه مي زند در غير اينصورت بايد فرمول حذف شود فرمول براي سال 90
        ' ''        '91 برای محاسبه افزایش حقوق در سال جدید  Differ = dtEmployee.DefaultView.Item(i).Item("Differ") * 1.06
        ' ''        '91 برای محاسبه افزایش حقوق در سال جدید          Barjeste = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("Barjeste"), 0) * 1.06)
        ' ''        Differ = dtEmployee.DefaultView.Item(i).Item("Differ")
        ' ''        Barjeste = Decimal.Round(Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("Barjeste"), 0))

        ' ''        Salary = 0
        ' ''        JobTitleID = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("JobTitleID"), 0)
        ' ''        DescribID = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("DescribID"), 1)
        ' ''        EngageDate = dtEmployee.DefaultView.Item(i).Item("EngageDate")
        ' ''        EngageTypeID = dtEmployee.DefaultView.Item(i).Item("EngageTypeID")
        ' ''        If ckbEmployeeCode.Checked = True Then
        ' ''            EmployTypeID = cmbEmployeeType.SelectedValue
        ' ''        Else
        ' ''            EmployTypeID = dtEmployee.DefaultView.Item(i).Item("EmployTypeID")
        ' ''        End If
        ' ''        PriodeID = cmbYear.SelectedValue
        ' ''        YearID = Year
        ' ''        ''''تفاوت بين حكم و قرارداد
        ' ''        If chkGharardad.Checked = True Then
        ' ''            BeginDate = txtBeginDate.Text.Trim
        ' ''            EndDate = txtEndDate.Text.Trim
        ' ''        Else
        ' ''            BeginDate = dtEmployee.DefaultView.Item(i).Item("BeginDate")
        ' ''            EndDate = dtEmployee.DefaultView.Item(i).Item("EndDate")
        ' ''        End If
        ' ''        EmissionDate = txtEmissionDate.Text.Trim

        ' ''        If chkGharardad.Checked = True Then
        ' ''            ExecDate = dtEmployee.DefaultView.Item(i).Item("ExecDate")
        ' ''            MoavagheDate = dtEmployee.DefaultView.Item(i).Item("ExecDate")
        ' ''        Else
        ' ''            ExecDate = txtExecuteDate.Text.Trim
        ' ''            MoavagheDate = txtExecuteDate.Text.Trim
        ' ''        End If
        ' ''        TimeAmountFee = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("TimeAmountFee"), 0)
        ' ''        DayAmountFee = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("DayAmountFee"), 0)
        ' ''        MaxTime = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("MaxTime"), 0)
        ' ''        MaxKarkard = Utility1.NZ(dtEmployee.DefaultView.Item(i).Item("MaxKarkard"), 0)
        ' ''        Active = True
        ' ''        If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
        ' ''            If dtEmployee.DefaultView.Item(i).Item("EngageTypeID") = 1 Or dtEmployee.DefaultView.Item(i).Item("EngageTypeID") = 2 Then
        ' ''                SqlStr = ""
        ' ''                SqlStr = "Select GroupFee From tbHR_GroupFee where GroupID = " & dtEmployee.DefaultView.Item(i).Item("GroupID") & " And PeriodID = " & cmbYear.SelectedValue & " And EngageTypeID = " & dtEmployee.DefaultView.Item(i).Item("EngageTypeID") & ""
        ' ''                dtGroupFe = Persist1.GetDataTable(ConString, SqlStr)
        ' ''                GroupFee = Decimal.Round(dtGroupFe.DefaultView.Item(0).Item("GroupFee"))
        ' ''            Else
        ' ''                GroupFee = Decimal.Round(dtEmployee.DefaultView.Item(i).Item("GroupFee"))
        ' ''            End If
        ' ''        Else     ''''محاسبه طبق سال گذشته
        ' ''            GroupFee = Decimal.Round(dtEmployee.DefaultView.Item(i).Item("GroupFee"))
        ' ''        End If

        ' ''        If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
        ' ''            SqlStr = ""
        ' ''            SqlStr = "Select HouseFeeCode, HouseFee, PeriodID FROM tbHR_HouseFee WHERE (PeriodID = " & cmbYear.SelectedValue & ") AND (HouseFeeCode = " & dtEmployee.DefaultView.Item(i).Item("HouseFeeCode") & ")"
        ' ''            dtHouseFe = Persist1.GetDataTable(ConString, SqlStr)
        ' ''            HouseFee = Decimal.Round(dtHouseFe.DefaultView.Item(0).Item("HouseFee"))
        ' ''        Else     ''''محاسبه طبق سال گذشته
        ' ''            HouseFee = Decimal.Round(dtEmployee.DefaultView.Item(i).Item("HouseFee"))
        ' ''        End If

        ' ''        If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
        ' ''            SqlStr = ""
        ' ''            SqlStr = "SELECT MarriageFeeCode, MarriageFee, PeriodID FROM tbHR_MarriageFee WHERE (PeriodID = " & cmbYear.SelectedValue & ") AND (MarriageFeeCode = " & dtEmployee.DefaultView.Item(i).Item("MarriageFeeCode") & ")"
        ' ''            dtMarriageFe = Persist1.GetDataTable(ConString, SqlStr)
        ' ''            MarriageFee = Decimal.Round(dtMarriageFe.DefaultView.Item(0).Item("MarriageFee"))
        ' ''        Else     ''''محاسبه طبق سال گذشته
        ' ''            MarriageFee = Decimal.Round(dtEmployee.DefaultView.Item(i).Item("MarriageFee"))
        ' ''        End If

        ' ''        If ckbHoghooghDate.Checked = True Then     ''''محاسبه طبق سال جديد
        ' ''            SqlStr = ""
        ' ''            SqlStr = "Select SoldierFee From tbHR_SoldierFee WHERE (PeriodID = " & cmbYear.SelectedValue & ") AND (GroupID = " & dtEmployee.DefaultView.Item(i).Item("GroupID") & ") AND (SoldierID = " & dtEmployee.DefaultView.Item(i).Item("SoldierID") & ")"
        ' ''            dtSoldierFe = Persist1.GetDataTable(ConString, SqlStr)
        ' ''            SoldierFee = Decimal.Round(dtSoldierFe.DefaultView.Item(0).Item("SoldierFee"))
        ' ''        Else     ''''محاسبه طبق سال گذشته
        ' ''            SoldierFee = Decimal.Round(dtEmployee.DefaultView.Item(i).Item("SoldierFee"))
        ' ''        End If

        ' ''        If ckbHoghooghDate.Checked = True Then    ''''محاسبه طبق سال جديد
        ' ''            SqlStr = ""
        ' ''            SqlStr = "Select FoodFee FROM tbHR_FoodFee WHERE (PeriodID = " & cmbYear.SelectedValue & ")"
        ' ''            dtFoodFe = Persist1.GetDataTable(ConString, SqlStr)
        ' ''            FoodFee = Decimal.Round(dtFoodFe.DefaultView.Item(0).Item("FoodFee"))
        ' ''        Else   ''''محاسبه طبق سال گذشته
        ' ''            FoodFee = Decimal.Round(dtEmployee.DefaultView.Item(i).Item("FoodFee"))
        ' ''        End If

        ' ''        ''غير فعال كردن حكم قبلي
        ' ''        Bus_Employee1.updateActiveEmploy(dtEmployee.DefaultView.Item(i).Item("EmployeeID"), False)
        ' ''        ''ثبت حكم جديد
        ' ''        Bus_Employee1.InsertEmployee(EmployeeCode, PersonID, PersonCode, PostID, PostCode, UnderTestFee, GroupID, GroupFee, GradeFee, HouseFeeCode, HouseFee, MarriageFeeCode, MarriageFee, SoldierID, SoldierFee, FoodFeeID, FoodFee, OverJazb, OverPost, Decimal.Round(Sanavat), Differ, Barjeste, Salary, JobTitleID, DescribID, EngageDate, EngageTypeID, EmployTypeID, PriodeID, YearID, BeginDate, EmissionDate, ExecDate, MoavagheDate, EndDate, TimeAmountFee, DayAmountFee, MaxTime, MaxKarkard, 1)

        ' ''    Next
        ' ''    MsgBox("تمامي حكمها ثبت شدند", MsgBoxStyle.Information, "")
        ' ''    frmPRSMain1.FillgrdPerson(SelectStr.Current)
        ' ''    frmPRSMain1.lblVazeeiat.Text = "جاري"
        ' ''Else
        ' ''    Exit Sub
        ' ''End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            wstr = _
            "SELECT     * " & _
            "FROM         dbo.VwHR_RptHokmSocialInfo " & _
            "WHERE    (EngageTypeID = 1 OR " & _
            "         EngageTypeID = 2 OR " & _
            "         EngageTypeID = 5) AND (PersonCode  in " & grdSelect1.get_Collection_String(grdPerson, 0, dtPerson, 2) & ")"

            rptReports = New rptHokmTabaghebandiiiiii
            LastRepName = ReportName
            ReportName = "rptHokmTabaghebandiiiiii"
            Call rptLoad()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTrity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrity.Click
        wstr = "SELECT  *  FROM VwHR_RptTreatyInfo  WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 0, dtPerson, 2) & ")  AND (EngageTypeID = 2)"
        rptReports = New rptTreaty
        LastRepName = ReportName
        ReportName = "rptTreaty"
        Call rptLoad()
    End Sub

    Private Sub rptLoad()
        Try
            If dsReports.Tables.Count > 0 Then
                dsReports.Tables(LastRepName).Clear()
            End If
            DA1 = Persist1.GetDataAccess(wstr, 1, ConString, ReportName, dsReports)
            Dim f1 As New frmReport
            f1.MarriageType = MarriageType
            f1.ChildCount = ChildCount
            f1.SumrootSalary = Decimal.Round(SumrootSalary)
            f1.GroupSalary = Decimal.Round(GroupSalary)
            f1.SumAllSalary = Decimal.Round(SumAll)
            f1.CurDate = IraniDate1.GetIraniDayName_CurDate + "  " + IraniDate1.GetIrani8DateStr_CurDate
            f1.Show()
        Catch ex As Exception
            Dim r3 As DialogResult = MessageBox.Show("كليك نماييد Help بر روي سيستم شما نصب نمي باشد براي نصب نرم افزار روي دكمه  Crystal Report2005", _
                                                      "Help Caption", MessageBoxButtons.OK, _
                                                      MessageBoxIcon.Question, _
                                                      MessageBoxDefaultButton.Button1, _
                                                      0, "\\Nt_dbms\mis\iso\Help\WareSupply for 2005\CRRedist2005_x86.msi", _
                                                      HelpNavigator.Index)
        End Try
    End Sub

    Private Sub chkGharardad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGharardad.CheckedChanged
        If chkGharardad.Checked = True Then
            txtBeginDate.Enabled = True
            txtEndDate.Enabled = True
            txtExecuteDate.Enabled = False
        Else
            txtBeginDate.Enabled = False
            txtEndDate.Enabled = False
            txtExecuteDate.Enabled = True
        End If
    End Sub

End Class
