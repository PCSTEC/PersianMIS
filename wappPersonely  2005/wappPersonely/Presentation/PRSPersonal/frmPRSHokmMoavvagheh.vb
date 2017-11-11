Public Class frmPRSHokmMoavvagheh
    Dim dt_Fee, dt_Post, dt_Posttxt, dt_period, dt_Job, dt_Depart, dt_EmployType, dt_Group, dt_Discribe, dt_EngageType, dt_Person As New DataTable
    Dim Bus_MDepart1 As New Bus_MDepart
    Dim Bus_Person1 As New Bus_Person
    Dim dt_PersonSelTemp As New DataTable
    Dim _PersonCode, _MilitaryStateID, _PersonID, _postID, _Periodid, _JobID, _EngageTypeID, _EmployeeTypeID, _GroupID, _DescribeID, _EmployeeID As Integer
    Dim _postcode As String
    Private DA1 As New SqlClient.SqlDataAdapter
    Friend dt_Employeeinfo As New DataTable

    Friend Property EmployeeID() As Integer
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Integer)
            _EmployeeID = value
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
    Public GradeNum_main As Integer

    Private Sub frmPRSHokmMoavvagheh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmPRSHokmMoavvagheh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblYear.Text = IraniDate1.GetIraniYear_CurDate
        Fillcombo()
        ''''‰Ÿ— ”‰ÃÌ
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

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
        cmbPeriod.Text = IraniDate1.GetYear_GivenDate(IraniDate1.GetIrani8Date_CurDate)
    End Sub
    Private Sub cmbPostType_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            cmbPostCode.SelectedValue = Utility1.NZ(cmbPostType.SelectedValue, 0)
            cmbPostID.SelectedValue = Utility1.NZ(cmbPostType.SelectedValue, 0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmbPostCode_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPostCode.SelectedValueChanged
        Try
            cmbPostType.SelectedValue = Utility1.NZ(cmbPostCode.SelectedValue, 0)
            cmbPostID.SelectedValue = Utility1.NZ(cmbPostCode.SelectedValue, 0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnNewHokm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewHokm.Click
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim i As Integer
        sqlstr = "SELECT EmployeeCode, PriodeID, YearID FROM tbHR_Employee WHERE(YearID = " & IraniDate1.GetYear_GivenDate(IraniDate1.GetIrani8Date_CurDate) & ") ORDER BY EmployeeCode DESC"
        dt = Persist1.GetDataTable(ConString, sqlstr)
        If dt.Rows.Count <> 0 Then
            i = dt.DefaultView.Item(0).Item("EmployeeCode") + 1
            lblEmpCode.Text = Str(i)
        Else
            lblEmpCode.Text = "1"
        End If
        UiGroupBox1.Enabled = True
        btnSave.Visible = True
        btnNewHokm.Visible = False
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Active As Integer
        If cmbJobTitle.SelectedValue < 146 Then
            MsgBox("‘€· ›—œ —« «“ „‘«€· ﬁœÌ„Ì Ê«—œ ‰„ÊœÂ «Ìœ.‘€· —« «“ „‘«€· ÃœÌœ «‰ Œ«» Ê ”Å” À»  ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If txtBeginEmployee.Text > txtEndEmployee.Text Then
            MsgBox("  «—ÌŒ ‘—Ê⁄ «“  «—ÌŒ « „«„ »“—ê — «”   ", MsgBoxStyle.Information, "")
            Exit Sub
        ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtBeginEmployee.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtEndEmployee.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtMoavvaghehDate.Text)) = True Then
            Exit Sub
        ElseIf txtFoodFee.Text = "" Or txtMarriageFee.Text = "" Or txtSoldierFee.Text = "" Or txtHouseFee.Text = "" Or txtSanavatFee.Text = "" Or txtGroupFee.Text = "" Then
            MsgBox(" ·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ  ", MsgBoxStyle.Information)
            Exit Sub
        End If
        '''''' salary '''''
        lblSalary.Text = Val(txtGroupFee.Text) + Val(txtGradeFee.Text) + Val(txtHouseFee.Text) + Val(txtMarriageFee.Text) + Val(txtSoldierFee.Text) + Val(txtFoodFee.Text) + Val(txtOverJazb.Text) + Val(txtOverPost.Text) + Val(txtSanavatFee.Text) + Val(txtDiffer.Text) + Val(txtBarjasteh.Text)
        ''''''''''''''''''''''
        ''''''''''''«Œ—«Ã Ì« „‰›ﬂ ‘œ‰ ›—œ «“ ﬂ«— ''''''''''
        If cmbEmployee.SelectedValue = 16 Or cmbEmployee.SelectedValue = 18 Or cmbEmployee.SelectedValue = 37 Or cmbEmployee.SelectedValue = 38 Or cmbEmployee.SelectedValue = 39 Or cmbEmployee.SelectedValue = 40 Or cmbEmployee.SelectedValue = 41 Then
            Active = 0
        Else
            Active = 1
        End If
        ''''''''''''''''''''''
        If txtHouseFee.Text.Trim = "0" Then
            lblHouseFeeCode.Text = "2"
        End If
        If txtMarriageFee.Text.Trim = "0" Then
            lblMarriagefeeCode.Text = "0"
        End If
        If txtSoldierFee.Text.Trim = "0" Then
            lblSoldierID.Text = "2"
        End If
        If MsgBox("¬Ì« «“ À»  Õﬂ„ „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            If EmployeeID <> 0 Then
                Bus_Employee1.updateActiveEmploy(EmployeeID, False)
            End If
            ''''À»  Õﬂ„ „⁄ÊﬁÂ
            Bus_Employee1.InsertEmployee(Val(lblEmpCode.Text), PersonID, Val(lblPersonCode.Text), cmbPostID.SelectedValue, cmbPostCode.Text, Val(txtUnderTest.Text), cmbGroup.SelectedValue, Val(txtGroupFee.Text), Val(txtGradeFee.Text), Val(lblHouseFeeCode.Text), Val(txtHouseFee.Text), Val(lblMarriagefeeCode.Text), Val(txtMarriageFee.Text), Val(lblSoldierID.Text), Val(txtSoldierFee.Text), Val(lblFoodFeeID.Text), Val(txtFoodFee.Text), Val(txtOverJazb.Text), Val(txtOverPost.Text), Val(txtSanavatFee.Text), Val(txtDiffer.Text), Val(txtBarjasteh.Text), Val(lblSalary.Text), cmbJobTitle.SelectedValue, cmbDescribe.Value, txtEngageDate.Text, cmbEngage.SelectedValue, cmbEmployee.SelectedValue, cmbPeriod.SelectedValue, Val(cmbPeriod.Text), txtBeginEmployee.Text, txtEmissionDate.Text, txtExecDateEmployee.Text, txtMoavvaghehDate.Text, txtEndEmployee.Text, 0, 0, 0, 0, Active, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, txtMandegari.Text, txtBon.Text, 0, 0)
            ''''»—Ê“ —”«‰Ì Õﬂ„Â«Ì „«»Ì‰  «—ÌŒ Õﬂ„ „⁄ÊﬁÂ  « «„—Ê“ 
            For i = 0 To dt_Employeeinfo.Rows.Count - 1
                Dim EmployeeID As Integer
                EmployeeID = dt_Employeeinfo.DefaultView.Item(i).Item("EmployeeID")
                Bus_Employee1.UpdateEmployeeForMoavvaghe(EmployeeID, Val(txtGradeFee.Text), Val(lblMarriagefeeCode.Text), Val(txtMarriageFee.Text), Val(txtOverJazb.Text), Val(txtOverPost.Text), Val(txtSanavatFee.Text), Val(txtDiffer.Text), Val(txtBarjasteh.Text), Val(lblSalary.Text), txtMoavvaghehDate.Text)
            Next
            MsgBox("Õﬂ„ „⁄ÊﬁÂ À»  Ê Õﬂ„Â«Ì „«»Ì‰  «—ÌŒ „⁄ÊﬁÂ  « «„—Ê“ »—Ê“—”«‰Ì ê—œÌœ", MsgBoxStyle.Information, "")
            'btnSave.Visible = False
            'btnNewHokm.Visible = True
            'UiGroupBox1.Enabled = False
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnShowGroupFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowGroupFee.Click
        Dim GroupID As Integer
        Dim dt As New DataTable
        dt_Fee.Rows.Clear()
        If btnShowGroupFee.Text = "+" Then
            GroupID = cmbGroup.SelectedValue
            dt_Fee = Bus_Fee1.GetGroupFeeInfo(GroupID, EngageTypeID)
            janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
            janus1.setMyJGrid(grdFee, "GroupID", "ê—ÊÂ", 50)
            janus1.setMyJGrid(grdFee, "GroupFee", "„“œ ê—ÊÂ", 85)
            janus1.setMyJGrid(grdFee, "Sanvat", "”‰Ê« ", 0, , , False)
            janus1.setMyJGrid(grdFee, "YearID", "”«·", 45)
            btnShowGroupFee.Text = "-"
            btnShowHouseFee.Text = "+"
            btnShowFoodFee.Text = "+"
            btnShowMarriageFee.Text = "+"
            btnShowSoldierFee.Text = "+"
            grdFee.Visible = True
        Else
            dt_Fee.Rows.Clear()
            grdFee.Visible = False
            btnShowGroupFee.Text = "+"
        End If
    End Sub
    Private Sub btnShowHouseFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowHouseFee.Click
        Dim dt_Married As New DataTable
        dt_Fee.Rows.Clear()
        If btnShowHouseFee.Text = "+" Then
            dt_Fee = Bus_Fee1.GetHouseFeeInfo
            dt_Married = Bus_Family1.GetMarriedInfo(lblPersonCode.Text)
            If dt_Married.Rows.Count = 0 Then
                dt_Fee.DefaultView.RowFilter = " HouseFeeCode = 2"
            Else
                dt_Fee.DefaultView.RowFilter = " HouseFeeCode = 1"
            End If
            janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
            janus1.setMyJGrid(grdFee, "Marriage", "‰Ê⁄", 75)
            janus1.setMyJGrid(grdFee, "HouseFee", "Õﬁ „”ﬂ‰", 85)
            janus1.setMyJGrid(grdFee, "YearID", "”«·", 45)
            janus1.setMyJGrid(grdFee, "HouseFeeCode", "", 0, , , False)
            janus1.setMyJGrid(grdFee, "HouseFeeID", "", 0, , , False)
            btnShowGroupFee.Text = "+"
            btnShowHouseFee.Text = "-"
            btnShowFoodFee.Text = "+"
            btnShowMarriageFee.Text = "+"
            btnShowSoldierFee.Text = "+"
            grdFee.Visible = True
        Else
            dt_Fee.Rows.Clear()
            grdFee.Visible = False
            btnShowHouseFee.Text = "+"
        End If
    End Sub
    Private Sub btnShowFoodFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowFoodFee.Click
        dt_Fee.Rows.Clear()
        If btnShowFoodFee.Text = "+" Then
            dt_Fee = Bus_Fee1.GetFoodFeeInfo
            janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
            janus1.setMyJGrid(grdFee, "FoodFee", "ŒÊ«—»«—", 85)
            janus1.setMyJGrid(grdFee, "YearID", "”«·", 45)
            janus1.setMyJGrid(grdFee, "FoodFeeID", "", 0, , , False)
            btnShowFoodFee.Text = "-"
            btnShowGroupFee.Text = "+"
            btnShowHouseFee.Text = "+"
            btnShowMarriageFee.Text = "+"
            btnShowSoldierFee.Text = "+"
            grdFee.Visible = True
        Else
            dt_Fee.Rows.Clear()
            grdFee.Visible = False
            btnShowFoodFee.Text = "+"
        End If
    End Sub

    Private Sub btnShowMarriageFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowMarriageFee.Click
        Dim dt_Marriage As New DataTable
        dt_Fee.Rows.Clear()
        If btnShowMarriageFee.Text = "+" Then
            dt_Marriage = Bus_Employee1.GetamountChildInfo(lblPersonCode.Text)
            If dt_Marriage.Rows.Count = 0 Then
                dt_Fee = Bus_Fee1.GetMarriageFeeInfo(0)
            ElseIf dt_Marriage.Rows.Count = 1 Then
                dt_Fee = Bus_Fee1.GetMarriageFeeInfo(1)
            Else
                dt_Fee = Bus_Fee1.GetMarriageFeeInfo(2)
            End If
            janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
            janus1.setMyJGrid(grdFee, "MarraigeFeeNum", " ⁄œ«œ ›—“‰œ", 100)
            janus1.setMyJGrid(grdFee, "MarriageFee", "⁄«∆·Â „‰œÌ", 85)
            janus1.setMyJGrid(grdFee, "YearID", "”«·", 45)
            janus1.setMyJGrid(grdFee, "MarriageFeeID", "", 0, , , False)
            janus1.setMyJGrid(grdFee, "MarriageFeeCode", "", 0, , , False)
            btnShowMarriageFee.Text = "-"
            btnShowGroupFee.Text = "+"
            btnShowHouseFee.Text = "+"
            btnShowFoodFee.Text = "+"
            btnShowSoldierFee.Text = "+"
            grdFee.Visible = True
        Else
            dt_Fee.Rows.Clear()
            grdFee.Visible = False
            btnShowMarriageFee.Text = "+"
        End If
    End Sub
    Private Sub btnShowSoldierFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSoldierFee.Click
        Dim dt_Soldier As New DataTable
        dt_Fee.Rows.Clear()
        If btnShowSoldierFee.Text = "+" Then
            If MilitaryStateID = 5 Then
                dt_Fee = Bus_Fee1.GetSoldierFeeInfo(cmbGroup.SelectedValue, 1)
            Else
                dt_Fee = Bus_Fee1.GetSoldierFeeInfo(cmbGroup.SelectedValue, 2)
            End If
            janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
            janus1.setMyJGrid(grdFee, "GroupID", "ê—ÊÂ", 50)
            janus1.setMyJGrid(grdFee, "SoldierText", "Ê÷⁄Ì ", 85)
            janus1.setMyJGrid(grdFee, "SoldierFee", "”—»«“Ì", 75)
            janus1.setMyJGrid(grdFee, "YearID", "”«·", 45)
            janus1.setMyJGrid(grdFee, "SoldierID", "", 0, , , False)
            btnShowSoldierFee.Text = "-"
            btnShowMarriageFee.Text = "+"
            btnShowGroupFee.Text = "+"
            btnShowHouseFee.Text = "+"
            btnShowFoodFee.Text = "+"
            grdFee.Visible = True
        Else
            dt_Fee.Rows.Clear()
            grdFee.Visible = False
            btnShowSoldierFee.Text = "+"
        End If
    End Sub
    Private Sub cmbEngage_SelectedValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEngage.SelectedValueChanged
        Try
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
                txtGroupFee.Text = ""
            ElseIf cmbEngage.SelectedValue = 3 Or cmbEngage.SelectedValue = 4 Or cmbEngage.SelectedValue = 6 Or cmbEngage.SelectedValue = 7 Or cmbEngage.SelectedValue = 8 Or cmbEngage.SelectedValue = 9 Or cmbEngage.SelectedValue = 10 Then
                btnShowGroupFee.Enabled = True
                txtGroupFee.Text = "0"
                cmbGroup.SelectedValue = 0
                Label3.Visible = False
                txtUnderTest.Visible = False
                txtUnderTest.Text = "0"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbEmployee_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEmployee.SelectedValueChanged
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
                txtGroupFee.Text = ""
            End If
            If cmbEmployee.SelectedValue = 7 Then
                cmbGroup.Enabled = True
            Else
                cmbGroup.Enabled = False
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
            MsgBox("Å” Ì —« «‰ Œ«» ‰‰„ÊœÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End Try

    End Sub

    Private Sub cmbJobTitle_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbJobTitle.SelectedValueChanged
        Try
            Dim sqlstr As String
            Dim dt As New DataTable
            sqlstr = "select GroupID from tbHR_JobTitle where JobTitleID = " & cmbJobTitle.SelectedValue & ""
            dt = Persist1.GetDataTable(ConString, sqlstr)
            cmbGroup.SelectedValue = Utility1.NZ(dt.DefaultView.Item(0).Item("GroupID"), 0)
            cmbGroup.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdFee_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdFee.DoubleClick

        If btnShowGroupFee.Text = "-" Then
            txtGroupFee.Text = grdFee.GetValue("GroupFee")
            Exit Sub

        ElseIf btnShowHouseFee.Text = "-" Then
            txtHouseFee.Text = grdFee.GetValue("HouseFee")
            lblHouseFeeCode.Text = grdFee.GetValue("HouseFeecode")
            Exit Sub

        ElseIf btnShowFoodFee.Text = "-" Then
            txtFoodFee.Text = grdFee.GetValue("FoodFee")
            lblFoodFeeID.Text = grdFee.GetValue("FoodFeeID")
            Exit Sub

        ElseIf btnShowMarriageFee.Text = "-" Then
            txtMarriageFee.Text = grdFee.GetValue("MarriageFee")
            lblMarriagefeeCode.Text = grdFee.GetValue("MarriageFeeCode")
            Exit Sub

        ElseIf btnShowSoldierFee.Text = "-" Then
            txtSoldierFee.Text = grdFee.GetValue("SoldierFee")
            lblSoldierID.Text = grdFee.GetValue("SoldierID")
            Exit Sub

        End If

    End Sub

End Class