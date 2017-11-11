Public Class frmPRSPastOfMoavagheh
    Dim _EmployeeID, _PersonCode, _PersonID As Integer
    Dim _MoavvaghehDate As String
    Dim dt_Employeeinfo As New DataTable
    Dim dt_Employee As New DataTable
    Dim Bus_Person1 As New Bus_Person
    Private DA1 As New SqlClient.SqlDataAdapter
    Dim SumrootSalary As Double = 0
    Dim SumAll As Double = 0
    Dim GroupSalary As Double = 0
    Dim MarriageType As String
    Dim ChildCount As Integer
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
    Friend Property EmployeeID() As Integer
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Integer)
            _EmployeeID = value
        End Set
    End Property
    Friend Property MoavvaghehDate() As String
        Get
            Return _MoavvaghehDate
        End Get
        Set(ByVal value As String)
            _MoavvaghehDate = value
        End Set
    End Property

    Private Sub frmPRSPastOfMoavagheh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub frmPRSHokmMoavagheh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCurDate.Text = IraniDate1.GetIrani8DateStr_CurDate
        FillMyDatattable()
        FillMyGridViwe(dt_Employeeinfo)
    End Sub
    Friend Function FillMyDatattable() As DataTable
        Dim sqlstr As String
        sqlstr = _
        "SELECT     * " & _
        "FROM         dbo.VwHR_PRSEmployee " & _
        "WHERE     (PersonCode = " & PersonCode & ") AND (BeginDate BETWEEN '" & lblMoavvaghehDate.Text.Trim & "' AND '" & lblCurDate.Text.Trim & "')"

        dt_Employeeinfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function
    Friend Sub FillMyGridViwe(ByVal dt_Employee As DataTable)
        janus1.GetBindJGrid_DT(dt_Employeeinfo, grdHokm, ConString)
        janus1.setMyJGrid(grdHokm, "EmployeeCode", "‘„«—Â Õﬂ„", 65)
        janus1.setMyJGrid(grdHokm, "FirstName", "‰«„", 65)
        janus1.setMyJGrid(grdHokm, "LastName", "‰«„ Œ«‰Ê«œêÌ", 75)
        janus1.setMyJGrid(grdHokm, "EngageDate", " «—ÌŒ «” Œœ«„", 85)
        janus1.setMyJGrid(grdHokm, "EmissionDate", " «—ÌŒ ’œÊ—", 75)
        janus1.setMyJGrid(grdHokm, "EngageType", "‰Ê⁄ «” Œœ«„", 70)
        janus1.setMyJGrid(grdHokm, "EmployeeType", "‰Ê⁄ Õﬂ„", 100)
        janus1.setMyJGrid(grdHokm, "DepartName", "ﬁ”„ ", 100)
        janus1.setMyJGrid(grdHokm, "Posttxt", "Å” ", 175)
        janus1.setMyJGrid(grdHokm, "PersonID", "", 0, , , False)
        janus1.setMyJGrid(grdHokm, "MilitaryStateID", "Ê÷⁄Ì  ”—»«“Ì", 0, , , False)
        janus1.setMyJGrid(grdHokm, "PersonCode", "ﬂœ Å—”‰·Ì", 0, , , False)
        janus1.setMyJGrid(grdHokm, "EmployeeActive", "EmployeeActive", 0, , , False)
        janus1.HighLightRows(grdHokm, "EmployeeActive", Janus.Windows.GridEX.ConditionOperator.Equal, 1, Color.Aqua)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnNewHokmMoavvaghe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewHokmMoavvaghe.Click
        If grdHokm.RowCount <> 0 Then
            Dim frm As New frmPRSHokmMoavvagheh
            dt_Employee = Bus_Employee1.GetEmployInfo(grdHokm.GetValue("PersonCode"))
            frm.EmployeeID = dt_Employee.DefaultView.Item(0).Item("EmployeeID")
            frm.PostID = dt_Employee.DefaultView.Item(0).Item("PostID")
            frm.postcode = dt_Employee.DefaultView.Item(0).Item("PostCode")
            frm.JobID = dt_Employee.DefaultView.Item(0).Item("JobTitleID")
            frm.EngageTypeID = dt_Employee.DefaultView.Item(0).Item("EngageTypeID")
            frm.EmployeeTypeID = dt_Employee.DefaultView.Item(0).Item("EmployTypeID")
            frm.DescribeID = dt_Employee.DefaultView.Item(0).Item("DescribID")
            frm.GroupID = dt_Employee.DefaultView.Item(0).Item("GroupID")
            frm.MilitaryStateID = grdHokm.GetValue("MilitaryStateID")
            frm.lblEmpCode.Text = Str(dt_Employee.DefaultView.Item(0).Item("EmployeeCode"))
            frm.txtUnderTest.Text = Str(dt_Employee.DefaultView.Item(0).Item("UnderTestFee"))
            frm.txtGroupFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("GroupFee"))
            frm.txtSanavatFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("Sanavat"))
            frm.txtGradeFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("GradeFee"))
            frm.txtEmissionDate.Text = dt_Employee.DefaultView.Item(0).Item("EmissionDate")
            frm.txtDiffer.Text = Str(dt_Employee.DefaultView.Item(0).Item("Differ"))
            frm.txtHouseFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("HouseFee"))
            frm.txtFoodFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("FoodFee"))
            frm.txtMarriageFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("MarriageFee"))
            frm.txtSoldierFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("SoldierFee"))
            frm.txtOverJazb.Text = Str(dt_Employee.DefaultView.Item(0).Item("OverJazb"))
            frm.txtOverPost.Text = Str(dt_Employee.DefaultView.Item(0).Item("OverPost"))
            frm.txtBarjasteh.Text = Str(dt_Employee.DefaultView.Item(0).Item("Barjeste"))
            frm.txtBeginEmployee.Text = dt_Employee.DefaultView.Item(0).Item("BeginDate")
            frm.txtEndEmployee.Text = dt_Employee.DefaultView.Item(0).Item("EndDate")
            frm.txtExecDateEmployee.Text = dt_Employee.DefaultView.Item(0).Item("ExecDate")
            frm.lblSalary.Text = Str(dt_Employee.DefaultView.Item(0).Item("Salary"))
            frm.txtEngageDate.Text = grdHokm.GetValue("EngageDate")
            frm.lblHouseFeeCode.Text = dt_Employee.DefaultView.Item(0).Item("HouseFeeCode")
            frm.lblFoodFeeID.Text = dt_Employee.DefaultView.Item(0).Item("FoodfeeID")
            frm.lblMarriagefeeCode.Text = dt_Employee.DefaultView.Item(0).Item("MarriageFeeCode")
            frm.lblSoldierID.Text = dt_Employee.DefaultView.Item(0).Item("SoldierID")
            frm.Periodid = dt_Employee.DefaultView.Item(0).Item("PriodeID")
            frm.lblID.Text = PersonID
            frm.lblPersonCode.Text = grdHokm.GetValue("PersonCode")
            frm.PersonCode = grdHokm.GetValue("PersonCode")
            frm.PersonID = grdHokm.GetValue("PersonID")
            frm.txtMoavvaghehDate.Text = lblMoavvaghehDate.Text
            frm.dt_Employeeinfo = dt_Employeeinfo

            frm.ShowDialog()
            FillMyDatattable()
            FillMyGridViwe(dt_Employeeinfo)
        Else
            MsgBox("›—œ „«»Ì‰ «Ì‰ œÊ  «—ÌŒ ÂÌç Õﬂ„Ì ‰œ«—œ . ·ÿ›« Õﬂ„ ›—œÌ ÃœÌœ ’«œ— ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
    End Sub

    Private Sub btnPrintHokm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintHokm.Click
        If grdHokm.RowCount <> 0 Then
            Dim dt As New DataTable
            Dim dt_Family As New DataTable
            Dim sqlstr1, sqlstr2, sqlstr3 As String
           
            Try
                'sqlstr2 = "select AffineID from VwHR_FamilyInfo where (PersonCode =  " & grdHokm.GetValue("PersonCode") & ") and (AffineID = " & 1 & ")"
                'dt_Family = Persist1.GetDataTable(ConString, sqlstr2)
                'If dt_Family.Rows.Count = 0 Then
                '    MarriageType = "„Ã—œ"
                'Else
                '    MarriageType = "„ «Â·"
                'End If
                'dt_Family.Clear()
                'sqlstr3 = "select AffineID from VwHR_FamilyInfo where (PersonCode =  " & grdHokm.GetValue("PersonCode") & ") and ((AffineID = " & 2 & ") or (AffineID = " & 3 & "))"
                'dt_Family = Persist1.GetDataTable(ConString, sqlstr3)
                'ChildCount = dt_Family.Rows.Count
                wstr = "select * from VwHR_RptHokmInfo where EmployeeCode = " & grdHokm.GetValue("EmployeeCode") & " and PersonCode =  " & grdHokm.GetValue("PersonCode") & " "
                'sqlstr1 = "select * from VwHR_RptHokmInfo where EmployeeCode = " & grdHokm.GetValue("EmployeeCode") & " and PersonCode =  " & grdHokm.GetValue("PersonCode") & " "
                'dt = Persist1.GetDataTable(ConString, sqlstr1)
                'If dt.DefaultView.Item(0).Item("EmployeeTypeID") = 1 Then
                '    GroupSalary = dt.DefaultView.Item(0).Item("UnderTestFee")
                '    SumrootSalary = GroupSalary + dt.DefaultView.Item(0).Item("Sanavat") + dt.DefaultView.Item(0).Item("GradeFee")
                '    SumAll = GroupSalary + dt.DefaultView.Item(0).Item("Differ") + dt.DefaultView.Item(0).Item("HouseFee") + dt.DefaultView.Item(0).Item("FoodFee") + dt.DefaultView.Item(0).Item("MarriageFee") + dt.DefaultView.Item(0).Item("SoldierFee") + dt.DefaultView.Item(0).Item("OverJazb") + dt.DefaultView.Item(0).Item("OverPost") + dt.DefaultView.Item(0).Item("Barjeste")
                'Else
                '    GroupSalary = dt.DefaultView.Item(0).Item("GroupFee")
                '    SumrootSalary = dt.DefaultView.Item(0).Item("GroupFee") + dt.DefaultView.Item(0).Item("Sanavat") + dt.DefaultView.Item(0).Item("GradeFee")
                '    SumAll = SumrootSalary + dt.DefaultView.Item(0).Item("Differ") + dt.DefaultView.Item(0).Item("HouseFee") + dt.DefaultView.Item(0).Item("FoodFee") + dt.DefaultView.Item(0).Item("MarriageFee") + dt.DefaultView.Item(0).Item("SoldierFee") + dt.DefaultView.Item(0).Item("OverJazb") + dt.DefaultView.Item(0).Item("OverPost") + dt.DefaultView.Item(0).Item("Barjeste")
                'End If
                rptReports = New rptHokm
                ReportName = "rptHokm"
                LastRepName = ReportName
                Call rptLoad()
            Catch ex As Exception

            End Try
        Else
            MsgBox("ÂÌç «ÿ·«⁄« Ì »—«Ì ç«Å „ÊÃÊœ ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
            Exit Sub
        End If

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
            Dim r3 As DialogResult = MessageBox.Show("ﬂ·Ìﬂ ‰„«ÌÌœ Help »— —ÊÌ ”Ì” „ ‘„« ‰’» ‰„Ì »«‘œ »—«Ì ‰’» ‰—„ «›“«— —ÊÌ œﬂ„Â  Crystal Report2005", _
                                                      "Help Caption", MessageBoxButtons.OK, _
                                                      MessageBoxIcon.Question, _
                                                      MessageBoxDefaultButton.Button1, _
                                                      0, "\\Nt_dbms\mis\iso\Help\WareSupply for 2005\CRRedist2005_x86.msi", _
                                                      HelpNavigator.Index)
        End Try
    End Sub
End Class