Public Class frmPRSHokm
    Dim dt_Fee, dt_Post, dt_Posttxt, dt_period, dt_Job, dt_Depart, dt_EmployType, dt_Group, dt_Discribe, dt_EngageType, dt_Person As New DataTable
    Dim Bus_MDepart1 As New Bus_MDepart
    Dim Bus_Person1 As New Bus_Person
    Dim dt_PersonSelTemp As New DataTable
    Dim _Vazeeiat, _MandegariFee, _PersonCode, _MilitaryStateID, _PersonID, _postID, _JobID, _EngageTypeID, _EmployeeTypeID, _GroupID, _DescribeID, _EmployeeID As Integer
    Dim _postcode As String
    Private DA1 As New SqlClient.SqlDataAdapter
    Dim SumrootSalary As Double = 0
    Dim SumAll As Double = 0
    Dim GroupSalary As Double = 0
    Dim MarriageType As String
    Dim ChildCount As Integer
    Friend frmPRSMain1 As frmPRSMain
    Dim _Periodid, _LogID As Integer
    Dim flg As Boolean = False
    Dim flgload As Boolean = False

    Friend Property MandegariFee() As Integer
        Get
            Return _MandegariFee
        End Get
        Set(ByVal value As Integer)
            _MandegariFee = value
        End Set
    End Property

    Friend Property LogID() As Integer
        Get
            Return _LogID
        End Get
        Set(ByVal value As Integer)
            _LogID = value
        End Set
    End Property

    Friend Property Vazeeiat() As Integer
        Get
            Return _Vazeeiat
        End Get
        Set(ByVal value As Integer)
            _Vazeeiat = value
        End Set
    End Property

    Friend Property Periodid() As Integer
        Get
            Return _Periodid
        End Get
        Set(ByVal value As Integer)
            _Periodid = value
        End Set
    End Property

    Friend Property EmployeeID() As Integer
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Integer)
            _EmployeeID = value
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

    Friend Property PersonCode() As Integer
        Get
            Return _PersonCode
        End Get
        Set(ByVal value As Integer)
            _PersonCode = value
        End Set
    End Property

    Friend Property postcode() As String
        Get
            Return _postcode
        End Get
        Set(ByVal value As String)
            _postcode = value
        End Set
    End Property

    Friend Property PostID() As Integer
        Get
            Return _postID
        End Get
        Set(ByVal value As Integer)
            _postID = value
        End Set
    End Property

    Friend Property JobID() As Integer
        Get
            Return _JobID
        End Get
        Set(ByVal value As Integer)
            _JobID = value
        End Set
    End Property

    Friend Property EngageTypeID() As Integer
        Get
            Return _EngageTypeID
        End Get
        Set(ByVal value As Integer)
            _EngageTypeID = value
        End Set
    End Property

    Friend Property EmployeeTypeID() As Integer
        Get
            Return _EmployeeTypeID
        End Get
        Set(ByVal value As Integer)
            _EmployeeTypeID = value
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

    Friend Property GroupID() As Integer
        Get
            Return _GroupID
        End Get
        Set(ByVal value As Integer)
            _GroupID = value
        End Set
    End Property

    Friend Property DescribeID() As Integer
        Get
            Return _DescribeID
        End Get
        Set(ByVal value As Integer)
            _DescribeID = value
        End Set
    End Property
    Dim sanavat_main As Integer
    Dim GradeFee_main As Integer
    Dim OverPost_main As Integer
    Dim HouseFee_main As Integer
    Dim FoodFee_main As Integer
    Dim Soldier_main As Integer
    Dim MarriageFee_main As Integer


    Private Sub frmPRSHokm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmPRSHokm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sanavat_main = txtSanavatFee.Text
        GradeFee_main = txtGradeFee.Text
        OverPost_main = txtOverPost.Text

        HouseFee_main = txtHouseFee.Text
        MarriageFee_main = txtMarriageFee.Text
        FoodFee_main = txtFoodFee.Text
        Soldier_main = txtSoldierFee.Text

        lblYear.Text = IraniDate1.GetIraniYear_CurDate
        Fillcombo()


        ''''نظر سنجي
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        flgload = True
        ''''
    End Sub

    Private Sub Fillcombo()
        dt_Post = Bus_Post1.GetPostInfo
        Persist1.FillCmb(dt_Post, cmbPostCode, "PostID", "PostCode")
        Persist1.FillCmb(dt_Post, cmbPostID, "PostID", "PostID")
        Persist1.FillCmb(dt_Post, cmbPostType, "PostID", "Posttxt")
        cmbPostCode.SelectedValue = PostID
        dt_Job = Bus_Other1.GetJobIfo
        Persist1.FillCmb(dt_Job, cmbJobTitle, "JobTitleID", "JobTitletxt")
        cmbJobTitle.SelectedValue = JobID
        dt_Group = Bus_Other1.GetGroupIfo
        Persist1.FillCmb(dt_Group, cmbGroup, "GroupID", "GroupID")
        cmbGroup.SelectedValue = GroupID
        dt_EmployType = Bus_Employee1.GetEmployTypeInfo
        Persist1.FillCmb(dt_EmployType, cmbEmployee, "EmployeeTypeID", "EmployeeType")
        cmbEmployee.SelectedValue = EmployeeTypeID
        dt_Discribe = Bus_Other1.GetDescribeIfo
        janus1.FillMultiCombo(cmbDescribe, dt_Discribe, "Describtion", "", 800, False, True, True)
        janus1.FillMultiCombo(cmbDescribe, dt_Discribe, "DescribeID", "", 80, True, False, False)
        cmbDescribe.Value = DescribeID
        dt_EngageType = Bus_Engage1.GetEngageTypeIfo
        Persist1.FillCmb(dt_EngageType, cmbEngage, "EngageTypeID", "EngageType")
        cmbEngage.SelectedValue = EngageTypeID
        dt_period = Bus_Other1.GetPeriod
        Persist1.FillCmb(dt_period, cmbPeriod, "PeriodID", "YearID")
        cmbPeriod.SelectedValue = Periodid
    End Sub

    Private Sub cmbPostType_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If flgload = True Then
            cmbPostCode.SelectedValue = Utility1.NZ(cmbPostType.SelectedValue, 0)
            cmbPostID.SelectedValue = Utility1.NZ(cmbPostType.SelectedValue, 0)
        End If
    End Sub

    Private Sub cmbPostCode_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPostCode.SelectedValueChanged
        If flgload = True Then
            cmbPostType.SelectedValue = Utility1.NZ(cmbPostCode.SelectedValue, 0)
            cmbPostID.SelectedValue = Utility1.NZ(cmbPostCode.SelectedValue, 0)
        End If
    End Sub

    Private Sub btnNewHokm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewHokm.Click
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim i As Integer
        Dim PID As Integer
        If Periodid = 0 Then
            sqlstr = "SELECT  MAX(PriodeID) AS MAXPriodeID FROM tbHR_Employee"
            dt = Persist1.GetDataTable(ConString, sqlstr)
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
            sqlstr = "SELECT max(EmployeeCode) as maxEmployeeCode FROM tbHR_Employee where (PriodeID = " & PID & ")"
        Else
            sqlstr = "SELECT max(EmployeeCode) as maxEmployeeCode FROM tbHR_Employee WHERE(PriodeID = " & cmbPeriod.SelectedValue & ")"
        End If
        dt = Persist1.GetDataTable(ConString, sqlstr)
        If dt.Rows.Count <> 0 Then
            i = dt.DefaultView.Item(0).Item("maxEmployeeCode") + 1
            lblEmpCode.Text = Str(i)
        Else
            lblEmpCode.Text = "1"
        End If
        UiGroupBox1.Enabled = True
        btnClose.Visible = True
        btnSave.Visible = True

        btnNewHokm.Visible = False
        btnPrintHokm.Visible = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Active As Integer
        Dim MoavagheDate As String
        Dim dt As New DataTable
        Dim CardNum As Integer

        ''''''''''''اخراج يا منفك شدن فرد از كار ''''''''''
        If cmbEmployee.SelectedValue = 16 Or cmbEmployee.SelectedValue = 18 Or cmbEmployee.SelectedValue = 37 Or cmbEmployee.SelectedValue = 38 Or cmbEmployee.SelectedValue = 39 Or cmbEmployee.SelectedValue = 40 Or cmbEmployee.SelectedValue = 41 Or cmbEmployee.SelectedValue = 52 Then
            ''''چك كردن اينكه كسي ابزاري تحويلش نباشد'''
            SqlStr = ""
            SqlStr = "SELECT     CardNumber   FROM         tbHR_Card WHERE     (PersonCode = " & lblPersonCode.Text.Trim & ")"
            dt = Persist1.GetDataTable(ConString, SqlStr)
            CardNum = dt.DefaultView.Item(0).Item("CardNumber")
            dt.Rows.Clear()
            '''بنا به درخواست واحد منابع انسانی در تاریخ 27/3/91 اینکار انجام شد'''
            'SqlStr = ""
            'SqlStr = "SELECT   ToolCode   FROM   Is_Calib.dbo.VwCalPersonTools_Rpt   WHERE  (CartNum = " & CardNum & ")"
            'dt = Persist1.GetDataTable(ConString, SqlStr)
            'If dt.Rows.Count <> 0 Then
            '    MsgBox("برخي ابزارهاي شركت تحويل اين شخص مي باشد كه مي بايست آنها را تحويل دهد . با كنترل كيفيت هماهنگ نماييد . مجاز به انجام اين عمل نمي باشيد", MsgBoxStyle.Information, "اخطار")
            '    Exit Sub
            'End If
            Active = 0
        Else
            Active = 1
        End If
        If cmbJobTitle.SelectedValue < 146 Then
            If MsgBox("شغل فرد را از مشاغل قديمي وارد نموده ايد.آيا مايل به ثبت مي باشيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        If cmbEngage.SelectedValue = 4 Or cmbEngage.SelectedValue = 7 Then
            MsgBox("مجاز به صدور اين نوع حكم نمي باشيد . از قسمت ثبت قرارداد ، قرارداد ثبت و صادر نماييد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If txtBeginEmployee.Text > txtEndEmployee.Text Then
            MsgBox(" تاريخ شروع از تاريخ اتمام بزرگتر است  ", MsgBoxStyle.Information, "")
            Exit Sub
        ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtBeginEmployee.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtEndEmployee.Text)) = True Then
            Exit Sub
        ElseIf txtFoodFee.Text = "" Or txtMarriageFee.Text = "" Or txtSoldierFee.Text = "" Or txtHouseFee.Text = "" Or txtSanavatFee.Text = "" Or txtGroupFee.Text = "" Then
            MsgBox(" لطفا مقادير را درست وارد نماييد  ", MsgBoxStyle.Information)
            Exit Sub
        End If

        If txtEmissionDate.Text.Trim = lblEmissionDate.Text.Trim Or txtEmissionDate.Text.Trim < lblEmissionDate.Text.Trim Then
            MsgBox(" تاريخ صدور را اشتباه وارد نموده ايد ", MsgBoxStyle.Information, "")
            Exit Sub
        End If

        If MsgBox("آيا از ثبت اين حكم مطمئن هستيد ؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            If txtBeginEmployee.Text.Trim = lblEndDate.Text.Trim Or txtBeginEmployee.Text.Trim < lblEndDate.Text.Trim Then
                If MsgBox(" شخص در اين تاريخ داراي حكم مي باشد.آيا از ثبت حكم در اين تاريخ مطمئن مي باشيد؟ ", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            If txtExecDateEmployee.Text.Trim = lblEndDate.Text.Trim Or txtExecDateEmployee.Text.Trim < lblEndDate.Text.Trim Then
                If MsgBox(" شخص در اين تاريخ داراي حكم مي باشد.آيا از ثبت حكم در اين تاريخ مطمئن مي باشيد؟ ", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            ''''''''''''''''''''''
            '''''' salary '''''
            lblSalary.Text = Val(txtGroupFee.Text) + Val(txtGradeFee.Text) + Val(txtHouseFee.Text) + Val(txtMarriageFee.Text) + Val(txtSoldierFee.Text) + Val(txtFoodFee.Text) + Val(txtOverJazb.Text) + Val(txtOverPost.Text) + Val(txtSanavatFee.Text) + Val(txtDiffer.Text) + Val(txtBarjasteh.Text)
            If txtHouseFee.Text.Trim = "0" Then
                lblHouseFeeCode.Text = "2"
            End If
            If txtMarriageFee.Text.Trim = "0" Then
                lblMarriagefeeCode.Text = "0"
            End If
            If txtSoldierFee.Text.Trim = "0" Then
                lblSoldierID.Text = "2"
                Bus_Employee1.updateActiveEmploy(EmployeeID, 0)
            End If
            MoavagheDate = txtExecDateEmployee.Text.Trim

            If EmployeeID <> 0 Then
                ' KasreTahsil()
                Bus_Employee1.updateActiveEmploy(EmployeeID, 0)
                'Else
                '    MsgBox("No Record")
                '    Exit Sub
            End If
            ''''استثنا موقع برقراري حكم سازمان جديد شركت يا همان طبقه بندي بي خودي كه انجام شد
            'If flg = True Then
            '    ''''ثبت نوع حكم برقراري رتبه
            '    Bus_Employee1.InsertEmployee(Val(lblEmpCode.Text), PersonID, Val(lblPersonCode.Text), cmbPostID.SelectedValue, cmbPostCode.Text, Val(txtUnderTest.Text), cmbGroup.SelectedValue, Val(txtGroupFee.Text), Val(txtGradeFee.Text), Val(lblHouseFeeCode.Text), Val(txtHouseFee.Text), Val(lblMarriagefeeCode.Text), Val(txtMarriageFee.Text), Val(lblSoldierID.Text), Val(txtSoldierFee.Text), Val(lblFoodFeeID.Text), Val(txtFoodFee.Text), Val(txtOverJazb.Text), Val(txtOverPost.Text), Val(txtSanavatFee.Text), Val(txtDiffer.Text), Val(txtBarjasteh.Text), Val(lblSalary.Text), cmbJobTitle.SelectedValue, cmbDescribe.Value, txtEngageDate.Text, cmbEngage.SelectedValue, 8, cmbPeriod.SelectedValue, Val(cmbPeriod.Text), txtBeginEmployee.Text, txtEmissionDate.Text, txtExecDateEmployee.Text, MoavagheDate, txtEndEmployee.Text, 0, 0, 0, 0, 0)
            '    ''''ثبت حكم جديد
            '    Bus_Employee1.InsertEmployee((Val(lblEmpCode.Text) + 1), PersonID, Val(lblPersonCode.Text), cmbPostID.SelectedValue, cmbPostCode.Text, Val(txtUnderTest.Text), cmbGroup.SelectedValue, Val(txtGroupFee.Text), Val(txtGradeFee.Text), Val(lblHouseFeeCode.Text), Val(txtHouseFee.Text), Val(lblMarriagefeeCode.Text), Val(txtMarriageFee.Text), Val(lblSoldierID.Text), Val(txtSoldierFee.Text), Val(lblFoodFeeID.Text), Val(txtFoodFee.Text), Val(txtOverJazb.Text), Val(txtOverPost.Text), Val(txtSanavatFee.Text), Val(txtDiffer.Text), Val(txtBarjasteh.Text), Val(lblSalary.Text), cmbJobTitle.SelectedValue, cmbDescribe.Value, txtEngageDate.Text, cmbEngage.SelectedValue, cmbEmployee.SelectedValue, cmbPeriod.SelectedValue, Val(cmbPeriod.Text), txtBeginEmployee.Text, txtEmissionDate.Text, txtExecDateEmployee.Text, MoavagheDate, txtEndEmployee.Text, 0, 0, 0, 0, Active)
            'Else
            ''''ثبت حكم جديد


            Bus_Employee1.InsertEmployee(Val(lblEmpCode.Text), PersonID, Val(lblPersonCode.Text), cmbPostID.SelectedValue, cmbPostCode.Text, Val(txtUnderTest.Text), cmbGroup.SelectedValue, Val(txtGroupFee.Text), Val(txtGradeFee.Text), Val(lblHouseFeeCode.Text), Val(txtHouseFee.Text), Val(lblMarriagefeeCode.Text), Val(txtMarriageFee.Text), Val(lblSoldierID.Text), Val(txtSoldierFee.Text), Val(lblFoodFeeID.Text), Val(txtFoodFee.Text), Val(txtOverJazb.Text), Val(txtOverPost.Text), Val(txtSanavatFee.Text), Val(txtDiffer.Text), Val(txtBarjasteh.Text), Val(lblSalary.Text), cmbJobTitle.SelectedValue, cmbDescribe.Value, txtEngageDate.Text, cmbEngage.SelectedValue, cmbEmployee.SelectedValue, cmbPeriod.SelectedValue, Val(cmbPeriod.Text), txtBeginEmployee.Text, txtEmissionDate.Text, txtExecDateEmployee.Text, MoavagheDate, txtEndEmployee.Text, 0, 0, 0, 0, Active, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, txtMandegari.Text, txtBon.Text, lblGradeNum.Text, TxtEndEntesab.Text)
            'End If
            btnClose.Visible = False
            btnSave.Visible = False
            btnNewHokm.Visible = True
            btnPrintHokm.Visible = True
            UiGroupBox1.Enabled = False
            If Active = False Then
                frmPRSMain1.FillgrdPerson(SelectStr.Current)
            End If
            MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
            If Vazeeiat = 0 Then
                frmPRSMain1.grdPerson.SetValue("Posttxt", cmbPostType.Text)
            ElseIf Vazeeiat = 1 Then
                frmPRSMain1.FillgrdPerson(SelectStr.Current)
                frmPRSMain1.lblVazeeiat.Text = "جاري"
            End If
        Else
            Exit Sub
        End If
        flg = False
    End Sub

    Private Sub btnShowHouseFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowHouseFee.Click
        Dim dt_Married As New DataTable
        Dim PID As Integer
        Dim dt As New DataTable
        ''''محاسبه سال براي بدو استخدام
        SqlStr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_HouseFee"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If Periodid = 0 Then
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        '''''محاسبه سال براي وقتيكه براي آن سال هنوز حق مسكن محاسبه نشده است
        If cmbPeriod.SelectedValue = dt.DefaultView.Item(0).Item("MAXPriodeID") Then
            PID = cmbPeriod.SelectedValue
        Else
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        dt_Fee.Rows.Clear()
        If btnShowHouseFee.Text = "+" Then
            dt_Fee = Bus_Fee1.GetHouseFeeInfo
            dt_Married = Bus_Family1.GetMarriedInfo(lblPersonCode.Text)
            If dt_Married.Rows.Count = 0 Then
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & " and HouseFeeCode = 2"
            Else
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & " and HouseFeeCode = 1"
            End If
            janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
            janus1.setMyJGrid(grdFee, "Marriage", "نوع", 75)
            janus1.setMyJGrid(grdFee, "HouseFee", "حق مسكن", 85)
            janus1.setMyJGrid(grdFee, "HouseFeeCode", "", 0, , , False)
            janus1.setMyJGrid(grdFee, "YearID", "سال", 45)
            janus1.setMyJGrid(grdFee, "HouseFeeID", "", 0, , , False)
            txtHouseFee.Text = dt_Fee.DefaultView.Item(0).Item("HouseFee")
            lblHouseFeeCode.Text = dt_Fee.DefaultView.Item(0).Item("HouseFeeCode")
            btnShowGroupFee.Text = "+"
            btnShowHouseFee.Text = "-"
            btnShowFoodFee.Text = "+"
            btnShowMarriageFee.Text = "+"
            btnShowSoldierFee.Text = "+"
            btnShowGradeFee.Text = "+"
            grdFee.Visible = True
        Else
            dt_Fee.Rows.Clear()
            grdFee.Visible = False
            btnShowHouseFee.Text = "+"
        End If
    End Sub

    Private Sub btnShowFoodFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowFoodFee.Click
        Dim PID As Integer
        Dim dt As New DataTable
        ''''محاسبه سال براي بدو استخدام
        SqlStr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_FoodFee"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If Periodid = 0 Then
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        '''''محاسبه سال براي وقتيكه براي آن سال هنوز حق غذا محاسبه نشده است
        If cmbPeriod.SelectedValue = dt.DefaultView.Item(0).Item("MAXPriodeID") Then
            PID = cmbPeriod.SelectedValue
        Else
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        dt_Fee.Rows.Clear()
        If btnShowFoodFee.Text = "+" Then
            dt_Fee = Bus_Fee1.GetFoodFeeInfo
            dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
            janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
            janus1.setMyJGrid(grdFee, "FoodFee", "خواربار", 85)
            janus1.setMyJGrid(grdFee, "YearID", "سال", 45)
            janus1.setMyJGrid(grdFee, "FoodFeeID", "", 0, , , False)
            txtFoodFee.Text = dt_Fee.DefaultView.Item(0).Item("FoodFee")
            lblFoodFeeID.Text = dt_Fee.DefaultView.Item(0).Item("FoodFeeID")
            btnShowFoodFee.Text = "-"
            btnShowGroupFee.Text = "+"
            btnShowHouseFee.Text = "+"
            btnShowMarriageFee.Text = "+"
            btnShowSoldierFee.Text = "+"
            btnShowGradeFee.Text = "+"
            grdFee.Visible = True
        Else
            dt_Fee.Rows.Clear()
            grdFee.Visible = False
            btnShowFoodFee.Text = "+"
        End If
    End Sub

    Private Sub btnShowMarriageFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowMarriageFee.Click
        Dim dt_Marriage As New DataTable
        Dim PID As Integer
        Dim dt As New DataTable
        ''''محاسبه سال براي بدو استخدام
        SqlStr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_MarriageFee"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If Periodid = 0 Then
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        '''''محاسبه سال براي وقتيكه براي آن سال هنوز حق غذا محاسبه نشده است
        If cmbPeriod.SelectedValue = dt.DefaultView.Item(0).Item("MAXPriodeID") Then
            PID = cmbPeriod.SelectedValue
        Else
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        dt_Fee.Rows.Clear()
        If btnShowMarriageFee.Text = "+" Then
            dt_Marriage = Bus_Employee1.GetamountChildInfo(lblPersonCode.Text)
            If dt_Marriage.Rows.Count = 0 Then
                dt_Fee = Bus_Fee1.GetMarriageFeeInfo(0)
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
            ElseIf dt_Marriage.Rows.Count = 1 Then
                dt_Fee = Bus_Fee1.GetMarriageFeeInfo(1)
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
            ElseIf dt_Marriage.Rows.Count = 2 Then
                dt_Fee = Bus_Fee1.GetMarriageFeeInfo(2)
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
            ElseIf dt_Marriage.Rows.Count = 3 Then
                dt_Fee = Bus_Fee1.GetMarriageFeeInfo(3)
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
            ElseIf dt_Marriage.Rows.Count = 4 Then
                dt_Fee = Bus_Fee1.GetMarriageFeeInfo(4)
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
            ElseIf dt_Marriage.Rows.Count = 5 Then
                dt_Fee = Bus_Fee1.GetMarriageFeeInfo(5)
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
            Else
                dt_Fee = Bus_Fee1.GetMarriageFeeInfo(6)
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
            End If
            janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
            janus1.setMyJGrid(grdFee, "MarraigeFeeNum", "تعداد فرزند", 100)
            janus1.setMyJGrid(grdFee, "MarriageFee", "عائله مندي", 85)
            janus1.setMyJGrid(grdFee, "YearID", "سال", 45)
            janus1.setMyJGrid(grdFee, "MarriageFeeCode", "", 0, , , False)
            janus1.setMyJGrid(grdFee, "MarriageFeeID", "", 0, , , False)
            txtMarriageFee.Text = dt_Fee.DefaultView.Item(0).Item("MarriageFee")
            lblMarriagefeeCode.Text = dt_Fee.DefaultView.Item(0).Item("MarriageFeeCode")
            btnShowMarriageFee.Text = "-"
            btnShowGroupFee.Text = "+"
            btnShowHouseFee.Text = "+"
            btnShowFoodFee.Text = "+"
            btnShowSoldierFee.Text = "+"
            btnShowGradeFee.Text = "+"
            grdFee.Visible = True
        Else
            dt_Fee.Rows.Clear()
            grdFee.Visible = False
            btnShowMarriageFee.Text = "+"
        End If
    End Sub

    Private Sub btnShowSoldierFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSoldierFee.Click
        Dim dt_Soldier As New DataTable
        Dim PID As Integer
        Dim dt As New DataTable
        ''''محاسبه سال براي بدو استخدام
        SqlStr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_SoldierFee"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If Periodid = 0 Then
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        '''''محاسبه سال براي وقتيكه براي آن سال هنوز حق غذا محاسبه نشده است
        If cmbPeriod.SelectedValue = dt.DefaultView.Item(0).Item("MAXPriodeID") Then
            PID = cmbPeriod.SelectedValue
        Else
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        dt_Fee.Rows.Clear()
        If btnShowSoldierFee.Text = "+" Then
            If MilitaryStateID = 5 Then
                dt_Fee = Bus_Fee1.GetSoldierFeeInfo(cmbGroup.SelectedValue, 1)
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
            Else
                dt_Fee = Bus_Fee1.GetSoldierFeeInfo(cmbGroup.SelectedValue, 2)
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
            End If
            janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
            janus1.setMyJGrid(grdFee, "GroupID", "گروه", 50)
            janus1.setMyJGrid(grdFee, "SoldierText", "وضعيت", 85)
            janus1.setMyJGrid(grdFee, "SoldierFee", "سربازي", 75)
            janus1.setMyJGrid(grdFee, "YearID", "سال", 45)
            janus1.setMyJGrid(grdFee, "SoldierID", "", 0, , , False)
            txtSoldierFee.Text = Utility1.NZ(dt_Fee.DefaultView.Item(0).Item("SoldierFee"), 0)
            lblSoldierID.Text = Utility1.NZ(dt_Fee.DefaultView.Item(0).Item("SoldierID"), 0)
            btnShowSoldierFee.Text = "-"
            btnShowMarriageFee.Text = "+"
            btnShowGroupFee.Text = "+"
            btnShowHouseFee.Text = "+"
            btnShowFoodFee.Text = "+"
            btnShowGradeFee.Text = "+"
            grdFee.Visible = True
        Else
            dt_Fee.Rows.Clear()
            grdFee.Visible = False
            btnShowSoldierFee.Text = "+"
        End If
    End Sub

    Friend Sub btnPrintHokm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintHokm.Click
        Try
            wstr = "select * from VwHR_RptHokmInfo where EmployeeCode = " & Val(lblEmpCode.Text.Trim) & " and PersonCode =  " & Val(lblPersonCode.Text.Trim) & ""
            rptReports = New rptHokm
            LastRepName = ReportName
            ReportName = "rptHokm"
            Call rptLoad()
        Catch ex As Exception

        End Try
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

    Private Sub cmbEngage_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEngage.SelectedValueChanged
        If flgload = True Then
            If cmbEngage.SelectedValue = 5 Then
                Label3.Visible = True
                txtUnderTest.Visible = True
                btnShowGroupFee.Enabled = False
                txtGroupFee.Text = "0"
            ElseIf cmbEngage.SelectedValue = 1 Or cmbEngage.SelectedValue = 2 Then
                Label3.Visible = False
                txtUnderTest.Visible = False
                txtUnderTest.Text = "0"
                btnShowGroupFee.Enabled = True
            ElseIf cmbEngage.SelectedValue = 3 Or cmbEngage.SelectedValue = 4 Or cmbEngage.SelectedValue = 6 Or cmbEngage.SelectedValue = 7 Or cmbEngage.SelectedValue = 8 Or cmbEngage.SelectedValue = 9 Or cmbEngage.SelectedValue = 10 Then
                btnShowGroupFee.Enabled = True
                txtGroupFee.Text = "0"
                cmbGroup.SelectedValue = 0
                Label3.Visible = False
                txtUnderTest.Visible = False
                txtUnderTest.Text = "0"
            End If
        End If
    End Sub

    Private Sub cmbEmployee_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEmployee.SelectedValueChanged
        Dim dt As New DataTable
        Dim PID As Integer
        Dim childcnt As Integer


        Try
            If cmbEmployee.SelectedValue = 1 Then
                Label3.Visible = True
                txtUnderTest.Visible = True
                btnShowGroupFee.Enabled = False
                txtGroupFee.Text = "0"
            Else
                Label3.Visible = False
                txtUnderTest.Visible = False
                btnShowGroupFee.Enabled = True
            End If
            If cmbEmployee.SelectedValue = 7 Then
                cmbGroup.Enabled = True
            Else
                cmbGroup.Enabled = False
            End If
            ''''cmbEmployee.SelectedValue = 42 Or 
            ''''برقراري حكم رتبه
            If cmbEmployee.SelectedValue = 8 Then
                btnShowGradeFee.Visible = True
            Else
                btnShowGradeFee.Visible = False
            End If

            ''''افزایش رتبه
            If cmbEmployee.SelectedValue = 45 Then
                btnShowGradeFee.Visible = True
            End If

            If flgload = True Then

                If cmbEmployee.SelectedValue = 11 Then

                    SqlStr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_GroupFee"
                    dt = Persist1.GetDataTable(ConString, SqlStr)
                    If Periodid = 0 Then
                        PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
                    End If
                    '''''محاسبه سال براي وقتيكه براي آن سال هنوز مزد گروه محاسبه نشده است


                    If cmbPeriod.SelectedValue = dt.DefaultView.Item(0).Item("MAXPriodeID") Then
                        PID = cmbPeriod.SelectedValue
                    Else
                        PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
                    End If
                    If cmbEngage.SelectedValue = 1 Or cmbEngage.SelectedValue = 2 Then
                        EngageTypeID = cmbEngage.SelectedValue
                    Else
                        EngageTypeID = 1
                        PID = 25
                    End If

                    SqlStr = _
                                                      "SELECT     * " & _
                                                      "FROM         VwHR_JobTitleAndGroupFee " & _
                                                      "WHERE     (JobTitleID =  " & cmbJobTitle.SelectedValue & ") AND (PeriodID = " & PID & ") AND (EngageTypeID = " & EngageTypeID & ")"
                    dt = Persist1.GetDataTable(ConString, SqlStr)

                    cmbGroup.SelectedValue = Utility1.NZ(dt.DefaultView.Item(0).Item("GroupID"), 0)
                    txtGroupFee.Text = Decimal.Round(Utility1.NZ(dt.DefaultView.Item(0).Item("GroupFee"), 0))
                    cmbGroup.Enabled = False

                    txtSanavatFee.Text = Utility1.NZ(dt.DefaultView.Item(0).Item("Sanvat"), 0) + sanavat_main
                    txtGradeFee.Text = GradeFee_main
                    txtOverPost.Text = OverPost_main




                    SqlStr = "SELECT     PeriodID, HouseFee  FROM         dbo.tbHR_HouseFee  WHERE     (PeriodID = " & PID & ")"
                    dt = Persist1.GetDataTable(ConString, SqlStr)
                    txtHouseFee.Text = Utility1.NZ(dt.DefaultView.Item(0).Item("HouseFee"), 0)




                    dt = Bus_Employee1.GetamountChildInfo(lblPersonCode.Text)

                    If dt.DefaultView.Count = 0 Then
                        childcnt = 0
                    Else
                        childcnt = dt.DefaultView.Count
                    End If

                    SqlStr = "SELECT     PeriodID, MarriageFee  FROM     dbo.tbHR_MarriageFee  WHERE   MarriageFeeCode=" & childcnt & " AND (PeriodID = " & PID & ")"
                    dt = Persist1.GetDataTable(ConString, SqlStr)
                    txtMarriageFee.Text = Utility1.NZ(dt.DefaultView.Item(0).Item("MarriageFee"), 0)


                    If MilitaryStateID = 5 Then
                        SqlStr = "SELECT      SoldierFee  FROM         dbo.tbHR_SoldierFee  WHERE     (PeriodID = " & PID & ") AND (GroupID = " & cmbGroup.Text & ") AND (SoldierID = 1)    "

                    Else
                        SqlStr = "SELECT      SoldierFee  FROM         dbo.tbHR_SoldierFee  WHERE     (PeriodID = " & PID & ") AND (GroupID = " & cmbGroup.Text & ") AND (SoldierID = 2)    "

                    End If

                    dt = Persist1.GetDataTable(ConString, SqlStr)
                    txtSoldierFee.Text = Utility1.NZ(dt.DefaultView.Item(0).Item("SoldierFee"), 0)


                    SqlStr = "SELECT     PeriodID, FoodFee  FROM         dbo.tbHR_FoodFee  WHERE    (PeriodID = " & PID & ")"
                    dt = Persist1.GetDataTable(ConString, SqlStr)
                    txtFoodFee.Text = Utility1.NZ(dt.DefaultView.Item(0).Item("FoodFee"), 0)


                Else
                    txtSanavatFee.Text = sanavat_main
                    txtGradeFee.Text = GradeFee_main
                    txtOverPost.Text = OverPost_main
                    txtHouseFee.Text = HouseFee_main
                    txtMarriageFee.Text = MarriageFee_main
                    txtFoodFee.Text = FoodFee_main
                    txtSoldierFee.Text = Soldier_main



                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPost.Click
        Try
            Dim frm As New frmPRSMainChart
            frm.ShowForm = frmPRSMainChart.showMode.show
            frm.ShowDialog()
            cmbPostCode.SelectedValue = frm.GrdPost.GetValue("PostID")
        Catch ex As Exception
            MsgBox("پستي را انتخاب ننموديد", MsgBoxStyle.Information, "")
            Exit Sub
        End Try
    End Sub

    Private Sub cmbJobTitle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbJobTitle.SelectedIndexChanged
        If flgload = True Then
            KasreTahsil()
        End If


    End Sub

    Private Sub cmbJobTitle_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbJobTitle.SelectedValueChanged
        If flgload = True Then
            Dim EngageTypeID, PID As Integer
            Dim dt As New DataTable
            dt_Fee.Rows.Clear()
            ''''محاسبه سال براي بدو استخدام
            SqlStr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_GroupFee"
            dt = Persist1.GetDataTable(ConString, SqlStr)
            If Periodid = 0 Then
                PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
            End If
            '''''محاسبه سال براي وقتيكه براي آن سال هنوز مزد گروه محاسبه نشده است
            If cmbPeriod.SelectedValue = dt.DefaultView.Item(0).Item("MAXPriodeID") Then
                PID = cmbPeriod.SelectedValue
            Else
                PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
            End If
            If cmbEngage.SelectedValue = 1 Or cmbEngage.SelectedValue = 2 Then
                EngageTypeID = cmbEngage.SelectedValue
            Else
                EngageTypeID = 1
                PID = 10
            End If
            Try
                SqlStr = _
                       "SELECT     * " & _
                       "FROM         VwHR_JobTitleAndGroupFee " & _
                       "WHERE     (JobTitleID =  " & cmbJobTitle.SelectedValue & ") AND (PeriodID = " & PID & ") AND (EngageTypeID = " & EngageTypeID & ")"
                dt = Persist1.GetDataTable(ConString, SqlStr)
                cmbGroup.SelectedValue = Utility1.NZ(dt.DefaultView.Item(0).Item("GroupID"), 0)
                txtGroupFee.Text = Decimal.Round(Utility1.NZ(dt.DefaultView.Item(0).Item("GroupFee"), 0))
                cmbGroup.Enabled = False

                If cmbEmployee.SelectedValue = 11 Then
                    txtSanavatFee.Text = Utility1.NZ(dt.DefaultView.Item(0).Item("Sanvat"), 0) + sanavat_main
                    txtGradeFee.Text = Utility1.NZ(dt.DefaultView.Item(0).Item("GradeFee"), 0) + GradeFee_main
                    txtOverPost.Text = OverPost_main
                    SqlStr = "SELECT     PeriodID, HouseFee  FROM         dbo.tbHR_HouseFee  WHERE     (PeriodID = " & PID & ")"
                    dt = Persist1.GetDataTable(ConString, SqlStr)
                    txtHouseFee.Text = Utility1.NZ(dt.DefaultView.Item(0).Item("HouseFee"), 0)

                    SqlStr = "SELECT     PeriodID, MarriageFee  FROM     dbo.tbHR_MarriageFee  WHERE    (PeriodID = " & PID & ")"
                    dt = Persist1.GetDataTable(ConString, SqlStr)
                    txtMarriageFee.Text = Utility1.NZ(dt.DefaultView.Item(0).Item("MarriageFee"), 0)


                    If MilitaryStateID = 5 Then
                        SqlStr = "SELECT      SoldierFee  FROM         dbo.tbHR_SoldierFee  WHERE     (PeriodID = " & PID & ") AND (GroupID = " & cmbGroup.Text & ") AND (SoldierID = 1)    "

                    Else
                        SqlStr = "SELECT      SoldierFee  FROM         dbo.tbHR_SoldierFee  WHERE     (PeriodID = " & PID & ") AND (GroupID = " & cmbGroup.Text & ") AND (SoldierID = 2)    "

                    End If

                    dt = Persist1.GetDataTable(ConString, SqlStr)
                    txtSoldierFee.Text = Utility1.NZ(dt.DefaultView.Item(0).Item("SoldierFee"), 0)


                    SqlStr = "SELECT     PeriodID, FoodFee  FROM         dbo.tbHR_FoodFee  WHERE    (PeriodID = " & PID & ")"
                    dt = Persist1.GetDataTable(ConString, SqlStr)
                    txtFoodFee.Text = Utility1.NZ(dt.DefaultView.Item(0).Item("FoodFee"), 0)

                Else

                    txtSanavatFee.Text = sanavat_main
                    txtGradeFee.Text = GradeFee_main
                    txtOverPost.Text = OverPost_main
                    txtHouseFee.Text = HouseFee_main
                    txtMarriageFee.Text = MarriageFee_main
                    txtFoodFee.Text = FoodFee_main
                    txtSoldierFee.Text = Soldier_main


                End If

            Catch ex As Exception

            End Try

            Try
                If btnSave.Visible = True Then

                    KasreTahsil()
                End If
            Catch ex As Exception

            End Try





        Else
            Exit Sub
        End If
    End Sub
    Private Sub KasreTahsil()
        Dim DiplomaKasr As Integer
        Dim JobDiplomaKasr As Integer
        Dim Dif As Integer
        Dim exprince As Integer
        Dim sanavat As Integer
        Dim Group As Integer
        Dim KasrSanavat As Integer
        Dim dt As New DataTable

        SqlStr = "SELECT     PersonCode, DiplomaKasr  FROM         dbo.View_All_Personel  WHERE     (PersonCode = " & Val(lblPersonCode.Text.Trim) & ")"


        dt = Persist1.GetDataTable(ConString, SqlStr)
        DiplomaKasr = dt.DefaultView.Item(0).Item("DiplomaKasr")

        SqlStr = "Select * from tbHR_JobTitle Where JobTitleID=" & cmbJobTitle.SelectedValue


        dt = Persist1.GetDataTable(ConString, SqlStr)
        JobDiplomaKasr = dt.DefaultView.Item(0).Item("DiplomaCode")
        sanavat = dt.DefaultView.Item(0).Item("DiplomaCode")
        Group = dt.DefaultView.Item(0).Item("GroupID")
        If JobDiplomaKasr > DiplomaKasr Then
            Dif = JobDiplomaKasr - DiplomaKasr
            SqlStr = "SELECT    *  FROM         dbo.VwHR_PRSEmployee  WHERE    (PersonCode = " & Val(lblPersonCode.Text.Trim) & ")AND  (EmployeeActive = 1) AND (DepartActive = 1) AND (PostActive = 1)"
            dt = Persist1.GetDataTable(ConString, SqlStr)
            exprince = dt.DefaultView.Item(0).Item("YearOutIkid") * 365 + dt.DefaultView.Item(0).Item("MonthOutIkid")


            SqlStr = "SELECT     id, YearKasr, MothKasr, SumKasr, FeeKasr  FROM         dbo.tbHR_KasrSanavat WHERE     (SumKasr = " & Dif * 365 - exprince & ")"
            dt = Persist1.GetDataTable(ConString, SqlStr)
            If dt.DefaultView.Count = 0 Then
                MsgBox("كسر تحصيل اين پست تعريف نشده است")
                txtSanavatFee.Text = 0
                Exit Sub
            Else
                KasrSanavat = dt.DefaultView.Item(0).Item("FeeKasr")
            End If
            SqlStr = "SELECT     GroupFeeID, GroupID, GroupFee, PeriodID, GradeFee, Sanvat, EngageTypeID  FROM         dbo.tbHR_GroupFee  WHERE     (GroupID = " & Group & ") AND (PeriodID = " & cmbPeriod.SelectedValue & ") AND (EngageTypeID = " & EngageTypeID & ")"
            dt = Persist1.GetDataTable(ConString, SqlStr)
            txtSanavatFee.Text = dt.DefaultView.Item(0).Item("Sanvat") - KasrSanavat
        End If
    End Sub

    Private Sub btnShowGradeFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowGradeFee.Click
        Dim EngageTypeID, GroupID, PID As Integer
        Dim dt As New DataTable
        Dim GradeFee As Double
        dt_Fee.Rows.Clear()

        If MsgBox("آيا از ثبت رتبه براي فرد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            'If cmbEmployee.SelectedValue = 42 Then
            '    flg = True
            'Else
            '    flg = False
            'End If
            If btnShowGradeFee.Text = "+" Then
                ''''محاسبه سال براي بدو استخدام
                SqlStr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_GroupFee"
                dt = Persist1.GetDataTable(ConString, SqlStr)
                If Periodid = 0 Then
                    PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
                End If
                '''''محاسبه سال براي وقتيكه براي آن سال هنوز رتبه محاسبه نشده است
                If cmbPeriod.SelectedValue = dt.DefaultView.Item(0).Item("MAXPriodeID") Then
                    PID = cmbPeriod.SelectedValue
                Else
                    PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
                End If
                If cmbEngage.SelectedValue = 1 Or cmbEngage.SelectedValue = 2 Then
                    EngageTypeID = cmbEngage.SelectedValue
                    GroupID = cmbGroup.SelectedValue
                Else
                    EngageTypeID = 1
                    PID = 10
                    GroupID = 0
                End If
                dt_Fee = Bus_Fee1.GetGroupFeeInfo(GroupID, EngageTypeID)
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
                janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
                janus1.setMyJGrid(grdFee, "GroupID", "گروه", 50)
                janus1.setMyJGrid(grdFee, "GradeFee", "رتبه", 85)
                janus1.setMyJGrid(grdFee, "YearID", "سال", 45)
                If txtGradeFee.Text.Trim = "0" Then
                    txtGradeFee.Text = Decimal.Round(dt_Fee.DefaultView.Item(0).Item("GradeFee"))
                Else
                    GradeFee = Val(txtGradeFee.Text.Trim) + Decimal.Round(dt_Fee.DefaultView.Item(0).Item("GradeFee"))
                    txtGradeFee.Text = GradeFee
                End If
                btnShowGradeFee.Text = "-"
                btnShowHouseFee.Text = "+"
                btnShowFoodFee.Text = "+"
                btnShowMarriageFee.Text = "+"
                btnShowSoldierFee.Text = "+"
                btnShowGroupFee.Text = "+"
                grdFee.Visible = True
            Else
                dt_Fee.Rows.Clear()
                grdFee.Visible = False
                btnShowGradeFee.Text = "+"
                Exit Sub
            End If
            'Else
            '    flg = False
            '    Exit Sub
        End If
    End Sub

    'Private Sub cmbPostType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPostType.SelectedIndexChanged
    '    Dim dt As New DataTable
    '    Dim PostDateCnt As Integer

    '    If btnSave.Visible = True Then
    '        SqlStr = "SELECT    *     FROM dbo.tbHR_PostSarparastiFee WHERE     (PostID = " & cmbPostType.SelectedValue & ") ORDER BY FeeDateBegin DESC "
    '        dt = Persist1.GetDataTable(ConString, SqlStr)
    '        If dt.DefaultView.Count = 0 Then
    '            txtOverPost.Text = 0
    '        Else
    '            txtOverPost.Text = dt.DefaultView.Item(0).Item("PostSarparstiFee")
    '        End If

    '        'SqlStr = "SELECT     GeneralObjects.dbo.FunGen_Def2ShamsiSDateN(ExecDate, '" & IraniDate1.GetIrani8DateStr_CurDate & "') AS Cnt       FROM dbo.View_All_Personel  WHERE     (PersonCode = " & PersonCode & ") AND (PostID = " & PostID & ")"
    '        'dt = Persist1.GetDataTable(ConString, SqlStr)
    '        'If dt.DefaultView.Count > 0 Then
    '        '    PostDateCnt = dt.DefaultView.Item(0).Item("Cnt")
    '        '    SqlStr = "SELECT    *     FROM dbo.tbHR_PostSarparastiFee WHERE     (PostID = " & PostID & ") ORDER BY FeeDateBegin DESC "
    '        '    dt = Persist1.GetDataTable(ConString, SqlStr)
    '        '    If dt.DefaultView.Count > 0 Then
    '        '        txtMandegari.Text = ((dt.DefaultView.Item(0).Item("PostSarparstiFee") * 5 * PostDateCnt) / 36500) + MandegariFee
    '        '    End If
    '        'End If


    '    End If


    'End Sub



    ''''ويرايش شغل افراد
    'Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
    '    If MsgBox("آيا از ويرايش شغل فرد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
    '        Persist1.Sp_AddParam("@EmployeeID_1", SqlDbType.Int, EmployeeID, ParameterDirection.Input)
    '        Persist1.Sp_AddParam("@JobTitleID_2", SqlDbType.Int, cmbJobTitle.SelectedValue, ParameterDirection.Input)
    '        Persist1.Sp_Exe("update_tbHR_EmployeeForJobTitleID", ConString, True)
    '        MsgBox("تغييرات انجام شد", MsgBoxStyle.Information, "")
    '        Me.Close()
    '    Else
    '        Exit Sub
    '    End If
    'End Sub


    'Private Sub btnShowGroupFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowGroupFee.Click
    '    Dim EngageTypeID, GroupID, PID As Integer
    '    Dim dt As New DataTable
    '    dt_Fee.Rows.Clear()
    '    If btnShowGroupFee.Text = "+" Then
    '        ''''محاسبه سال براي بدو استخدام
    '        SqlStr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_GroupFee"
    '        dt = Persist1.GetDataTable(ConString, SqlStr)
    '        If PeriodID = 0 Then
    '            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
    '        End If
    '        '''''محاسبه سال براي وقتيكه براي آن سال هنوز مزد گروه محاسبه نشده است
    '        If cmbPeriod.SelectedValue = dt.DefaultView.Item(0).Item("MAXPriodeID") Then
    '            PID = cmbPeriod.SelectedValue
    '        Else
    '            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
    '        End If
    '        If cmbEngage.SelectedValue = 1 Or cmbEngage.SelectedValue = 2 Then
    '            EngageTypeID = cmbEngage.SelectedValue
    '            GroupID = cmbGroup.SelectedValue
    '        Else
    '            EngageTypeID = 1
    '            PID = 10
    '            GroupID = 0
    '        End If
    '        dt_Fee = Bus_Employee1.GetGroupFeeInfo(GroupID, PID, EngageTypeID)
    '        janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
    '        janus1.setMyJGrid(grdFee, "GroupID", "گروه", 50)
    '        janus1.setMyJGrid(grdFee, "GroupFee", "مزد گروه", 85)
    '        janus1.setMyJGrid(grdFee, "Sanvat", "سنوات", 75)
    '        janus1.setMyJGrid(grdFee, "YearID", "سال", 45)
    '        txtGroupFee.Text = Decimal.Round(dt_Fee.DefaultView.Item(0).Item("GroupFee"))
    '        btnShowGroupFee.Text = "-"
    '        btnShowHouseFee.Text = "+"
    '        btnShowFoodFee.Text = "+"
    '        btnShowMarriageFee.Text = "+"
    '        btnShowSoldierFee.Text = "+"
    '        btnShowGradeFee.Text = "+"
    '        grdFee.Visible = True
    '    Else
    '        dt_Fee.Rows.Clear()
    '        grdFee.Visible = False
    '        btnShowGroupFee.Text = "+"
    '    End If
    'End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtJanbazi.TextChanged

    End Sub

  
End Class