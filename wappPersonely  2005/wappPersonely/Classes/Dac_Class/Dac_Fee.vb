Public Class Dac_Fee

    Friend Function GetGroupFeeInfo(ByVal GroupID As Integer, ByVal EngageTypeID As Integer) As DataTable
        Dim sqlstr As String
        ''''sqlstr = "select * from VwHR_GroupFee  where (GroupID = " & GroupID & ") AND (PeriodID = " & PeriodID & ")AND (EngageTypeID = " & EngageTypeID & ")"
        ''''ÿ»ﬁ œ—ŒÊ«”  ﬂ«—»— œ—  «—ÌŒ 1390/02/28
        sqlstr = "select * from VwHR_GroupFee  where (GroupID = " & GroupID & ") AND (EngageTypeID = " & EngageTypeID & ") ORDER BY YearID DESC"
        GetGroupFeeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetHouseFeeInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_HouseFee ORDER BY YearID DESC "
        GetHouseFeeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetFoodFeeInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_FoodFee ORDER BY YearID DESC"
        GetFoodFeeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetMarriageFeeInfo(ByVal MarriageFeeCode As Integer) As DataTable
        Dim sqlstr As String
        ''(PeriodID = " & PeriodID & ") and ByVal PeriodID As Integer,
        sqlstr = "select * from VwHR_MarriageFee where (MarriageFeeCode = " & MarriageFeeCode & ") ORDER BY YearID DESC "
        GetMarriageFeeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetSoldierFeeInfo(ByVal GroupID As Integer, ByVal SoldierID As Integer) As DataTable
        Dim sqlstr As String
        ''(PeriodID = " & PeriodID & ") AND  ByVal PeriodID As Integer,
        sqlstr = _
                   "SELECT     * " & _
                   "FROM         VwHR_SoldierFee where  (GroupID = " & GroupID & ") " & _
                    "AND (SoldierID = " & SoldierID & ") ORDER BY YearID DESC"
        GetSoldierFeeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

End Class
