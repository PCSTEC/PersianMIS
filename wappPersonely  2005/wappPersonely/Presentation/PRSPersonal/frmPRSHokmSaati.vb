Public Class frmPRSHokmSaati
    Dim dt_Fee, dt_Post, dt_Posttxt, dt_period, dt_Job, dt_Depart, dt_EmployType, dt_Group, dt_Discribe, dt_EngageType, dt_Person As New DataTable
    Dim Bus_MDepart1 As New Bus_MDepart
    Dim Bus_Person1 As New Bus_Person
    Dim _EngageTypeID, _PersonCode, _Periodid, _MilitaryStateID, _PersonID, _postID, _EngageID, _GroupID, _DescribeID, _EmployeeID As Integer
    Dim _postcode As String
    Friend frmPRSMain1 As frmPRSMain
    Private DA1 As New SqlClient.SqlDataAdapter
    Dim SumrootSalary As Double = 0
    Dim SumAll As Double = 0
    Dim GroupSalary As Double = 0
    Dim MarriageType As String
    Dim ChildCount As Integer

    Friend Property Periodid() As Integer
        Get
            Return _Periodid
        End Get
        Set(ByVal value As Integer)
            _Periodid = value
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
    Friend Property EngageID() As Integer
        Get
            Return _EngageID
        End Get
        Set(ByVal value As Integer)
            _EngageID = value
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

    Private Sub frmPRSHokmSaati_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub frmPRSHokmRoozMozd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblYear.Text = IraniDate1.GetIraniYear_CurDate
        If EngageTypeID = 4 Then
            lblAmount.Text = "„“œ —Ê“«‰Â :"
            lblSaghf.Text = "Õœ«ﬂÀ— «÷«›Â ﬂ«— :"
        End If
        Fillcombo()
    End Sub
    Private Sub Fillcombo()
        dt_Post = Bus_Post1.GetPostInfo
        Persist1.FillCmb(dt_Post, cmbPostCode, "PostID", "PostCode")
        Persist1.FillCmb(dt_Post, cmbPostID, "PostID", "PostID")
        Persist1.FillCmb(dt_Post, cmbPostType, "PostID", "Posttxt")
        cmbPostCode.SelectedValue = PostID
        SqlStr = _
        "SELECT     EmployeeTypeID, EmployeeType FROM         tbHR_EmployeeType WHERE     (EmployeeTypeID = 16 OR " & _
        "                      EmployeeTypeID = 17 OR " & _
        "                      EmployeeTypeID = 18 OR " & _
        "                      EmployeeTypeID = 28 OR " & _
        "                      EmployeeTypeID = 29 OR " & _
        "                      EmployeeTypeID = 30 OR " & _
        "                      EmployeeTypeID = 32 OR " & _
        "                      EmployeeTypeID = 37 OR " & _
        "                      EmployeeTypeID = 38 OR " & _
        "                      EmployeeTypeID = 39 OR " & _
         "                      EmployeeTypeID = 4 OR " & _
        "                      EmployeeTypeID = 34 OR " & _
        "                      EmployeeTypeID = 41)  ORDER BY EmployeeType"
        dt_EmployType = Persist1.GetDataTable(ConString, SqlStr)
        Persist1.FillCmb(dt_EmployType, cmbEmpoyeeType, "EmployeeTypeID", "EmployeeType")
        If EngageTypeID = 7 Then      '''' ”«⁄ Ì Ì« „‘«Ê— employeetypeID = 7
            cmbEmpoyeeType.SelectedValue = 28
        ElseIf EngageTypeID = 4 Then         '''' —Ê“„“œ employeetypeID = 4
            cmbEmpoyeeType.SelectedValue = 29
        End If
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

    Private Sub btnShowHouseFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowHouseFee.Click
        Dim dt_Married As New DataTable
        Dim PID As Integer
        Dim dt As New DataTable
        ''''„Õ«”»Â ”«· »—«Ì »œÊ «” Œœ«„
        SqlStr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_HouseFee"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If Periodid = 0 Then
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        '''''„Õ«”»Â ”«· »—«Ì Êﬁ ÌﬂÂ »—«Ì ¬‰ ”«· Â‰Ê“ Õﬁ „”ﬂ‰ „Õ«”»Â ‰‘œÂ «” 
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
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & " and HouseFeeCode = 0"
            Else
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & " and HouseFeeCode = 1"
            End If
            janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
            janus1.setMyJGrid(grdFee, "Marriage", "‰Ê⁄", 75)
            janus1.setMyJGrid(grdFee, "HouseFee", "Õﬁ „”ﬂ‰", 85)
            janus1.setMyJGrid(grdFee, "YearID", "”«·", 45)
            janus1.setMyJGrid(grdFee, "HouseFeeID", "", 0, , , False)
            janus1.setMyJGrid(grdFee, "HouseFeeCode", "", 0, , , False)
            txtHouseFee.Text = dt_Fee.DefaultView.Item(0).Item("HouseFee")
            lblHouseFeeCode.Text = dt_Fee.DefaultView.Item(0).Item("HouseFeeCode")
            btnShowHouseFee.Text = "-"
            btnShowFoodFee.Text = "+"
            btnShowSoldierFee.Text = "+"
            btnShowMarriageFee.Text = "+"
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
        ''''„Õ«”»Â ”«· »—«Ì »œÊ «” Œœ«„
        SqlStr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_FoodFee"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If Periodid = 0 Then
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        '''''„Õ«”»Â ”«· »—«Ì Êﬁ ÌﬂÂ »—«Ì ¬‰ ”«· Â‰Ê“ Õﬁ €–« „Õ«”»Â ‰‘œÂ «” 
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
            janus1.setMyJGrid(grdFee, "FoodFee", "ŒÊ«—»«—", 85)
            janus1.setMyJGrid(grdFee, "YearID", "”«·", 45)
            janus1.setMyJGrid(grdFee, "FoodFeeID", "", 0, , , False)
            txtFoodFee.Text = dt_Fee.DefaultView.Item(0).Item("FoodFee")
            lblFoodFeeID.Text = dt_Fee.DefaultView.Item(0).Item("FoodFeeID")
            btnShowFoodFee.Text = "-"
            btnShowHouseFee.Text = "+"
            btnShowSoldierFee.Text = "+"
            btnShowMarriageFee.Text = "+"
            grdFee.Visible = True
        Else
            dt_Fee.Rows.Clear()
            grdFee.Visible = False
            btnShowFoodFee.Text = "+"
        End If
    End Sub

    Private Sub btnShowSoldierFee_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSoldierFee.Click
        Dim dt_Soldier As New DataTable
        dt_Fee.Rows.Clear()
        Dim PID As Integer
        Dim dt As New DataTable
        ''''„Õ«”»Â ”«· »—«Ì »œÊ «” Œœ«„
        SqlStr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_SoldierFee"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If Periodid = 0 Then
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        '''''„Õ«”»Â ”«· »—«Ì Êﬁ ÌﬂÂ »—«Ì ¬‰ ”«· Â‰Ê“ Õﬁ €–« „Õ«”»Â ‰‘œÂ «” 
        If cmbPeriod.SelectedValue = dt.DefaultView.Item(0).Item("MAXPriodeID") Then
            PID = cmbPeriod.SelectedValue
        Else
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        dt_Fee.Rows.Clear()
        If btnShowSoldierFee.Text = "+" Then
            If MilitaryStateID = 5 Then
                dt_Fee = Bus_Fee1.GetSoldierFeeInfo(0, 1)
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
            Else
                dt_Fee = Bus_Fee1.GetSoldierFeeInfo(0, 2)
                dt_Fee.DefaultView.RowFilter = "PeriodID = " & PID & ""
            End If
            janus1.GetBindJGrid_DT(dt_Fee, grdFee, ConString)
            janus1.setMyJGrid(grdFee, "GroupID", "ê—ÊÂ", 50)
            janus1.setMyJGrid(grdFee, "SoldierText", "Ê÷⁄Ì ", 85)
            janus1.setMyJGrid(grdFee, "SoldierFee", "”—»«“Ì", 75)
            janus1.setMyJGrid(grdFee, "YearID", "”«·", 45)
            janus1.setMyJGrid(grdFee, "SoldierID", "", 0, , , False)
            txtSoldierFee.Text = dt_Fee.DefaultView.Item(0).Item("SoldierFee")
            lblSoldierID.Text = dt_Fee.DefaultView.Item(0).Item("SoldierID")
            btnShowSoldierFee.Text = "-"
            btnShowMarriageFee.Text = "+"
            btnShowHouseFee.Text = "+"
            btnShowFoodFee.Text = "+"
            grdFee.Visible = True
        Else
            dt_Fee.Rows.Clear()
            grdFee.Visible = False
            btnShowSoldierFee.Text = "+"
        End If
    End Sub
    Private Sub btnShowMarriageFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowMarriageFee.Click
        Dim dt_Marriage As New DataTable
        Dim PID As Integer
        Dim dt As New DataTable
        ''''„Õ«”»Â ”«· »—«Ì »œÊ «” Œœ«„
        SqlStr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_MarriageFee"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If Periodid = 0 Then
            PID = dt.DefaultView.Item(0).Item("MAXPriodeID")
        End If
        '''''„Õ«”»Â ”«· »—«Ì Êﬁ ÌﬂÂ »—«Ì ¬‰ ”«· Â‰Ê“ Õﬁ €–« „Õ«”»Â ‰‘œÂ «” 
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
            janus1.setMyJGrid(grdFee, "MarraigeFeeNum", " ⁄œ«œ ›—“‰œ", 100)
            janus1.setMyJGrid(grdFee, "MarriageFee", "⁄«∆·Â „‰œÌ", 85)
            janus1.setMyJGrid(grdFee, "YearID", "”«·", 45)
            janus1.setMyJGrid(grdFee, "MarriageFeeCode", "", 0, , , False)
            janus1.setMyJGrid(grdFee, "MarriageFeeID", "", 0, , , False)

            txtMarriageFee.Text = dt_Fee.DefaultView.Item(0).Item("MarriageFee")
            lblMarriagefeeCode.Text = dt_Fee.DefaultView.Item(0).Item("MarriageFeeCode")
            btnShowMarriageFee.Text = "-"
            btnShowHouseFee.Text = "+"
            btnShowSoldierFee.Text = "+"
            btnShowFoodFee.Text = "+"
            grdFee.Visible = True
        Else
            dt_Fee.Rows.Clear()
            grdFee.Visible = False
            btnShowMarriageFee.Text = "+"
        End If
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
        'txtSanavatFee.Text = ""
        'txtGradeFee.Text = ""
        txtEmissionDate.Text = ""
        txtBeginEmployee.Text = ""
        txtEndEmployee.Text = ""
        txtExecDateEmployee.Text = ""
        'txtDiffer.Text = ""
        'txtHouseFee.Text = ""
        'txtAmount.Text = ""
        'txtFoodFee.Text = ""
        'txtMarriageFee.Text = ""
        'txtSoldierFee.Text = ""
        'txtOverJazb.Text = ""
        'txtOverPost.Text = ""
        'txtBarjasteh.Text = ""
        'txtSaghf.Text = ""
        'cmbDescribe.Text = ""
        btnClose.Visible = True
        btnSave.Visible = True
        btnNewHokm.Visible = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Active As Integer
        Dim Salary As Double
        If txtBeginEmployee.Text > txtEndEmployee.Text Then
            MsgBox("  «—ÌŒ ‘—Ê⁄ «“  «—ÌŒ « „«„ »“—ê — «”   ", MsgBoxStyle.Information, "")
            Exit Sub
        ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtBeginEmployee.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtEndEmployee.Text)) = True Then
            Exit Sub
        ElseIf txtFoodFee.Text = "" Or txtMarriageFee.Text = "" Or txtSoldierFee.Text = "" Or txtHouseFee.Text = "" Or txtSanavatFee.Text = "" Then
            MsgBox(" ·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ  ", MsgBoxStyle.Information)
            Exit Sub
        End If
        If txtEmissionDate.Text.Trim = lblEmissionDate.Text.Trim Or txtEmissionDate.Text.Trim < lblEmissionDate.Text.Trim Then
            MsgBox("  «—ÌŒ ’œÊ— —« «‘ »«Â Ê«—œ ‰„ÊœÂ «Ìœ ", MsgBoxStyle.Information, "")
            Exit Sub
        End If

        If txtBeginEmployee.Text.Trim = lblEndDate.Text.Trim Or txtBeginEmployee.Text.Trim < lblEndDate.Text.Trim Then
            If MsgBox(" ‘Œ’ œ— «Ì‰  «—ÌŒ œ«—«Ì Õﬂ„ „Ì »«‘œ.¬Ì« «“ À»  Õﬂ„ œ— «Ì‰  «—ÌŒ „ÿ„∆‰ „Ì »«‘Ìœø ", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        'If txtExecDateEmployee.Text.Trim = lblEndDate.Text.Trim Or txtExecDateEmployee.Text.Trim < lblEndDate.Text.Trim

        'If MsgBox(" ‘Œ’ œ— «Ì‰  «—ÌŒ œ«—«Ì Õﬂ„ „Ì »«‘œ.¬Ì« «“ À»  Õﬂ„ œ— «Ì‰  «—ÌŒ „ÿ„∆‰ „Ì »«‘Ìœø ", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
        If MsgBox("¬Ì« «“ À»  «Ì‰ Õﬂ„ „ÿ„∆‰ Â” Ìœ ø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            If EmployeeID <> 0 Then
                Bus_Employee1.updateActiveEmploy(EmployeeID, False)
            End If
            If txtHouseFee.Text.Trim = "0" Then
                lblHouseFeeCode.Text = "2"
            End If
            If txtMarriageFee.Text.Trim = "0" Then
                lblMarriagefeeCode.Text = "0"
            End If
            If txtSoldierFee.Text.Trim = "0" Then
                lblSoldierID.Text = "2"
            End If

            If cmbEmpoyeeType.SelectedValue = 18 Or cmbEmpoyeeType.SelectedValue = 37 Or cmbEmpoyeeType.SelectedValue = 38 Or cmbEmpoyeeType.SelectedValue = 39 Or cmbEmpoyeeType.SelectedValue = 41 Then
                Active = 0
            Else
                Active = 1
            End If
            If EngageTypeID = 7 Then                    ''''À»  ”«⁄ Ì Ì« „‘«Ê— employeetypeID = 7
                Salary = Val(txtSaghf.Text.Trim) * Val(txtAmount.Text.Trim)
                Bus_Employee1.InsertEmployee(Val(lblEmpCode.Text.Trim), Val(lblPersonID.Text.Trim), Val(lblPersonCode.Text.Trim), cmbPostID.SelectedValue, cmbPostCode.Text.Trim, 0, 0, 0, 0, Val(lblHouseFeeCode.Text.Trim), Val(txtHouseFee.Text.Trim), Val(lblMarriagefeeCode.Text.Trim), Val(txtMarriageFee.Text.Trim), Val(lblSoldierID.Text.Trim), Val(txtSoldierFee.Text.Trim), Val(lblFoodFeeID.Text.Trim), Val(txtFoodFee.Text.Trim), Val(txtOverJazb.Text.Trim), Val(txtOverPost.Text.Trim), Val(txtSanavatFee.Text.Trim), Val(txtDiffer.Text.Trim), Val(txtBarjasteh.Text.Trim), Salary, 0, cmbDescribe.Value, txtEngageDate.Text, cmbEngage.SelectedValue, cmbEmpoyeeType.SelectedValue, cmbPeriod.SelectedValue, cmbPeriod.Text, txtBeginEmployee.Text, txtEmissionDate.Text, txtExecDateEmployee.Text, txtExecDateEmployee.Text, txtEndEmployee.Text, Val(txtAmount.Text.Trim), 0, 0, Val(txtSaghf.Text.Trim), Active, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, 0, 0, 0, 0)
            ElseIf EngageTypeID = 4 Then                '''''''À»  —Ê“ „“œ employeetypeID = 4
                Salary = 30 * Val(txtAmount.Text.Trim)
                Bus_Employee1.InsertEmployee(Val(lblEmpCode.Text.Trim), Val(lblPersonID.Text.Trim), Val(lblPersonCode.Text.Trim), cmbPostID.SelectedValue, cmbPostCode.Text.Trim, 0, 0, 0, 0, Val(lblHouseFeeCode.Text.Trim), Val(txtHouseFee.Text.Trim), Val(lblMarriagefeeCode.Text.Trim), Val(txtMarriageFee.Text.Trim), Val(lblSoldierID.Text.Trim), Val(txtSoldierFee.Text.Trim), Val(lblFoodFeeID.Text.Trim), Val(txtFoodFee.Text.Trim), Val(txtOverJazb.Text.Trim), Val(txtOverPost.Text.Trim), Val(txtSanavatFee.Text.Trim), Val(txtDiffer.Text.Trim), Val(txtBarjasteh.Text.Trim), Salary, 0, cmbDescribe.Value, txtEngageDate.Text, cmbEngage.SelectedValue, cmbEmpoyeeType.SelectedValue, cmbPeriod.SelectedValue, cmbPeriod.Text, txtBeginEmployee.Text, txtEmissionDate.Text, txtExecDateEmployee.Text, txtExecDateEmployee.Text, txtEndEmployee.Text, 0, Val(txtAmount.Text.Trim), Val(txtSaghf.Text.Trim), 0, Active, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, cmbPercent.Text, 0, 0, 0, 0)
            End If
            btnClose.Visible = False
            btnSave.Visible = False
            btnNewHokm.Visible = True
            UiGroupBox1.Enabled = False
            MsgBox("—ﬂÊ—œ À»  ‘œ", MsgBoxStyle.Information, "")
            frmPRSMain1.FillgrdPerson(SelectStr.Current)
            frmPRSMain1.lblVazeeiat.Text = "Ã«—Ì"
            Me.Close()
        Else
            Exit Sub
        End If
        'Else
        'Exit Sub
        'End If
        'End If
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

End Class