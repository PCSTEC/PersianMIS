Public Class Bus_Employee
    Dim Dac_Employee1 As New Dac_Employee

    Friend Function InsertEmployee(ByVal EmployeeCode As Integer, ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal PostID As Integer, ByVal PostCode As String, ByVal UnderTestFee As Double, ByVal GroupID As Integer, ByVal GroupFee As Double, ByVal GradeFee As Double, ByVal HouseFeeCode As Double, ByVal HouseFee As Double, ByVal MarriageFeeCode As Double, ByVal MarriageFee As Double, ByVal SoldierID As Integer, ByVal SoldierFee As Double, ByVal FoodFeeID As Integer, ByVal FoodFee As Double, ByVal OverJazb As Double, ByVal OverPost As Double, ByVal Sanavat As Double, ByVal Differ As Double, ByVal Barjeste As Double, ByVal Salary As Double, ByVal JobTitleID As Integer, ByVal DescribID As Integer, ByVal EngageDate As String, ByVal EngageTypeID As Integer, ByVal EmployTypeID As Integer, ByVal PeriodID As Integer, ByVal Year As Integer, ByVal BeginDate As String, ByVal EmissionDate As String, ByVal ExecuteDate As String, ByVal MoavagheDate As String, ByVal EndDate As String, ByVal TimeAmountFee As Double, ByVal DayAmountFee As Double, ByVal MaxTime As Integer, ByVal MaxKarkard As Integer, ByVal Active As Integer, ByVal PercentGrade As Integer, ByVal PercentSanavat As Integer, ByVal PercentOverJazb As Integer, ByVal PercentOverPost As Integer, ByVal PercentBarjeste As Integer, ByVal MandegariFee As Integer, ByVal BonFee As Integer, ByVal GradeNUM As Integer, ByVal EndDateEntesab As String)
        InsertEmployee = Dac_Employee1.InsertEmployee(EmployeeCode, PersonID, PersonCode, PostID, PostCode, UnderTestFee, GroupID, GroupFee, GradeFee, HouseFeeCode, HouseFee, MarriageFeeCode, MarriageFee, SoldierID, SoldierFee, FoodFeeID, FoodFee, OverJazb, OverPost, Sanavat, Differ, Barjeste, Salary, JobTitleID, DescribID, EngageDate, EngageTypeID, EmployTypeID, PeriodID, Year, BeginDate, EmissionDate, ExecuteDate, MoavagheDate, EndDate, TimeAmountFee, DayAmountFee, MaxTime, MaxKarkard, Active, PercentGrade, PercentSanavat, PercentOverPost, PercentOverJazb, PercentBarjeste, MandegariFee, BonFee, GradeNUM, EndDateEntesab)
    End Function

    Friend Sub updateEmployActive(ByVal EmployeeID As Integer, ByVal Active As Integer)
        Dac_Employee1.updateEmployActive(EmployeeID, Active)
    End Sub

    Friend Sub updateActiveEmploy(ByVal EmployeeID As Integer, ByVal Active As Integer)
        Dac_Employee1.updateActiveEmploy(EmployeeID, Active)
    End Sub

    Friend Function GetEmployTypeInfo() As DataTable
        GetEmployTypeInfo = Dac_Employee1.GetEmployTypeInfo
    End Function

    Friend Function GetRptHokmInfo(ByVal PersonCode As Integer) As DataTable
        GetRptHokmInfo = Dac_Employee1.GetRptHokmInfo(PersonCode)
    End Function

    Friend Function GetEmployInfo(ByVal PersonCode As Integer) As DataTable
        GetEmployInfo = Dac_Employee1.GetEmployInfo(PersonCode)
    End Function

    Friend Function GetamountChildInfo(ByVal PersonCode As Integer) As DataTable
        GetamountChildInfo = Dac_Employee1.GetamountChildInfo(PersonCode)
    End Function

    Friend Sub UpdateEmployeeForMoavvaghe(ByVal EmployeeID As Integer, ByVal GradeFee As Integer, ByVal MarriageFeeCode As Integer, ByVal MarriageFee As Double, ByVal OverJazb As Double, ByVal OverPost As Double, ByVal Sanavat As Double, ByVal Differ As Double, ByVal Barjeste As Double, ByVal Salary As Double, ByVal MoavagheDate As String)
        Dac_Employee1.UpdateEmployeeForMoavvaghe(EmployeeID, GradeFee, MarriageFeeCode, MarriageFee, OverJazb, OverPost, Sanavat, Differ, Barjeste, Salary, MoavagheDate)
    End Sub
End Class
