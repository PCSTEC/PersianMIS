
Public Class Dac_Employee

    ''''’œÊ— Õﬂ„
    Friend Function InsertEmployee(ByVal EmployeeCode As Integer, ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal PostID As Integer, ByVal PostCode As String, ByVal UnderTestFee As Double, ByVal GroupID As Integer, ByVal GroupFee As Double, ByVal GradeFee As Double, ByVal HouseFeeCode As Double, ByVal HouseFee As Double, ByVal MarriageFeeCode As Double, ByVal MarriageFee As Double, ByVal SoldierID As Integer, ByVal SoldierFee As Double, ByVal FoodFeeID As Integer, ByVal FoodFee As Double, ByVal OverJazb As Double, ByVal OverPost As Double, ByVal Sanavat As Double, ByVal Differ As Double, ByVal Barjeste As Double, ByVal Salary As Double, ByVal JobTitleID As Integer, ByVal DescribID As Integer, ByVal EngageDate As String, ByVal EngageTypeID As Integer, ByVal EmployTypeID As Integer, ByVal PeriodID As Integer, ByVal Year As Integer, ByVal BeginDate As String, ByVal EmissionDate As String, ByVal ExecuteDate As String, ByVal MoavagheDate As String, ByVal EndDate As String, ByVal TimeAmountFee As Double, ByVal DayAmountFee As Double, ByVal MaxTime As Integer, ByVal MaxKarkard As Integer, ByVal Active As Integer, ByVal PercentGrade As Integer, ByVal PercentSanavat As Integer, ByVal PercentOverJazb As Integer, ByVal PercentOverPost As Integer, ByVal PercentBarjeste As Integer, ByVal MandegariFee As Integer, ByVal bonfee As Integer, ByVal GradeNUM As Integer, ByVal EndDateEntesab As String)
        Persist1.Sp_AddParam("@EmployeeID_1", SqlDbType.Int, 0, ParameterDirection.Output)
        Persist1.Sp_AddParam("@EmployeeCode_41", SqlDbType.Int, EmployeeCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonID_2", SqlDbType.Int, PersonID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonCode_3", SqlDbType.Int, PersonCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PostID_4", SqlDbType.Int, PostID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PostCode_5", SqlDbType.NVarChar, PostCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@UnderTestFee_6", SqlDbType.Float, UnderTestFee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@GroupID_7", SqlDbType.Int, GroupID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@GroupFee_8", SqlDbType.Float, GroupFee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@GradeFee_9", SqlDbType.Float, (GradeFee * PercentGrade) / 100 + GradeFee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@HouseFeeCode_10", SqlDbType.Int, HouseFeeCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@HouseFee_11", SqlDbType.Float, HouseFee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MarriageFeeCode_12", SqlDbType.Float, MarriageFeeCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MarriageFee_13", SqlDbType.Float, MarriageFee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@SoldierID_14", SqlDbType.Int, SoldierID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@SoldierFee_15", SqlDbType.Float, SoldierFee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@FoodFeeID_16", SqlDbType.Int, FoodFeeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@FoodFee_17", SqlDbType.Float, FoodFee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@OverJazb_18", SqlDbType.Float, (OverJazb * PercentOverJazb) / 100 + OverJazb, ParameterDirection.Input)
        Persist1.Sp_AddParam("@OverPost_19", SqlDbType.Float, (OverPost * PercentOverPost) / 100 + OverPost, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Sanavat_20", SqlDbType.Float, (Sanavat * PercentSanavat) / 100 + Sanavat, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Differ_21", SqlDbType.Float, Differ, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Barjeste_22", SqlDbType.Float, (Barjeste * PercentBarjeste) / 100 + Barjeste, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Salary_23", SqlDbType.Float, Salary, ParameterDirection.Input)
        Persist1.Sp_AddParam("@JobTitleID_24", SqlDbType.Int, JobTitleID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DescribID_25", SqlDbType.Int, DescribID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EngageDate_26", SqlDbType.Char, EngageDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EngageTypeID_27", SqlDbType.Int, EngageTypeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EmployTypeID_28", SqlDbType.Int, EmployTypeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PriodeID_29", SqlDbType.Int, PeriodID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@YearID_30", SqlDbType.Int, Year, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BeginDate_31", SqlDbType.Char, BeginDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EmissionDate_32", SqlDbType.Char, EmissionDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@ExecDate_33", SqlDbType.Char, ExecuteDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MoavagheDate_34", SqlDbType.Char, MoavagheDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EndDate_35", SqlDbType.Char, EndDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@TimeAmountFee_36", SqlDbType.Float, TimeAmountFee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DayAmountFee_37", SqlDbType.Int, DayAmountFee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MaxTime_38", SqlDbType.Int, MaxTime, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MaxKarkard_39", SqlDbType.Int, MaxKarkard, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_40", SqlDbType.Int, Active, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PercentGrade_42", SqlDbType.Int, PercentGrade, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PercentSanavat_43", SqlDbType.Int, PercentSanavat, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PercentOverPost_44", SqlDbType.Int, PercentOverPost, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PercentOverJazb_45", SqlDbType.Int, PercentOverJazb, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PercentBarjeste_46", SqlDbType.Int, PercentBarjeste, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MandegariFee_47", SqlDbType.Int, MandegariFee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Bon_48", SqlDbType.Int, bonfee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EndDateEntesab_49", SqlDbType.Char, EndDateEntesab, ParameterDirection.Input)

        Persist1.Sp_Exe("insert_tbHR_Employee", ConString, True)


        If EmployTypeID = 8 Or EmployTypeID = 45 Then
            SqlStr = "update tbHR_Employee set GradeNum=" & GradeNUM + 1 & " Where PersonCode=" & PersonCode & " AND Active=1"
            Persist1.GetDataAccess(SqlStr, 2, ConString)
        Else
            SqlStr = "update tbHR_Employee set GradeNum=" & GradeNUM & " Where PersonCode=" & PersonCode & " AND Active=1"
            Persist1.GetDataAccess(SqlStr, 2, ConString)
        End If

        'Dim TbId As Integer

        'TbId = Persist1.ParameterCmd1(1).ParamValue
        'Persist1.ClearParameter()

        'Call inserthistory("tbHR_Employee_insert", TbId, SystemInformation.ComputerName + "-" + LoginInfo1.LoginPrName + "-" + IraniDate1.GetIrani8DateStr_CurDate + "-" + IraniTime1.GetTimeTxt_Cur)


    End Function
    Friend Sub inserthistory(ByVal TbName As String, ByVal TbId As Integer, ByVal Hist As String)
        Persist1.Sp_AddParam("@TbName_2", SqlDbType.NVarChar, TbName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@TbId_3", SqlDbType.Int, TbId, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Hist_4", SqlDbType.NVarChar, Hist, ParameterDirection.Input)
        Persist1.Sp_Exe("Insert_tbHR_History", ConString, False)


    End Sub
    Friend Sub UpdateEmployeeForMoavvaghe(ByVal EmployeeID As Integer, ByVal GradeFee As Integer, ByVal MarriageFeeCode As Integer, ByVal MarriageFee As Double, ByVal OverJazb As Double, ByVal OverPost As Double, ByVal Sanavat As Double, ByVal Differ As Double, ByVal Barjeste As Double, ByVal Salary As Double, ByVal MoavagheDate As String)
        Persist1.Sp_AddParam("@EmployeeID_1", SqlDbType.Int, EmployeeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@GradeFee_2", SqlDbType.Float, GradeFee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MarriageFeeCode_3", SqlDbType.Int, MarriageFeeCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MarriageFee_4", SqlDbType.Float, MarriageFee, ParameterDirection.Input)
        Persist1.Sp_AddParam("@OverJazb_5", SqlDbType.Float, OverJazb, ParameterDirection.Input)
        Persist1.Sp_AddParam("@OverPost_6", SqlDbType.Float, OverPost, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Sanavat_7", SqlDbType.Float, Sanavat, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Differ_8", SqlDbType.Float, Differ, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Barjeste_9", SqlDbType.Float, Barjeste, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Salary_10", SqlDbType.Float, Salary, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MoavagheDate_11", SqlDbType.Char, MoavagheDate, ParameterDirection.Input)
        Persist1.Sp_Exe("update_tbHR_EmployeeForMoavvaghe", ConString, True)

     

    End Sub

    Friend Function updateEmployActive(ByVal EmployeeID As Integer, ByVal Active As Integer)
        Persist1.ClearParameter()
        Persist1.Sp_AddParam("@EmployeeID_1 ", SqlDbType.Int, EmployeeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_2", SqlDbType.Int, Active, ParameterDirection.Input)
        Persist1.Sp_Exe("update_tbHR_EmployeeActive", ConString, True)
        

    End Function

    Friend Function updateActiveEmploy(ByVal EmployeeID As Integer, ByVal Active As Integer)
        Persist1.ClearParameter()
        Persist1.Sp_AddParam("@EmployeeID_1", SqlDbType.Int, EmployeeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_2", SqlDbType.Int, Active, ParameterDirection.Input)
        Persist1.Sp_Exe("update_tbHR_Employee", ConString, True)
        '  Call inserthistory("tbHR_Employee_update", EmployeeID, SystemInformation.ComputerName + "-" + LoginInfo1.LoginPrName + "-" + IraniDate1.GetIrani8DateStr_CurDate + "-" + IraniTime1.GetTimeTxt_Cur)


    End Function

    Friend Function GetEmployTypeInfo() As DataTable
        Dim sqlstr As String
        ''''''''''''' „«„Ì «‰Ê«⁄ Õﬂ„ »Â Ã“ «” Œœ«„ ”«⁄ Ì ° „‘«Ê— ° —Ê“„“œÌ
        sqlstr = "select * from tbHR_EmployeeType ORDER BY EmployeeType"
        'WHERE(EmployeeTypeID <> 28 And EmployeeTypeID <> 29 And EmployeeTypeID <> 32)
        GetEmployTypeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetRptHokmInfo(ByVal PersonCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_RptHokmInfo WHERE (PersonCode = " & PersonCode & ")"
        GetRptHokmInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetEmployInfo(ByVal PersonCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = _
                       "SELECT     * " & _
                       "FROM    dbo.tbHR_Employee WHERE (PersonCode =  " & PersonCode & ") AND (Active = 1)"
        GetEmployInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetamountChildInfo(ByVal PersonCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = _
                   "SELECT     * " & _
                   "FROM         VwHR_Married " & _
                   "WHERE     (PersonCode = " & PersonCode & ") AND (AffineID = 2 or AffineID = 3)"
        GetamountChildInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function
End Class

