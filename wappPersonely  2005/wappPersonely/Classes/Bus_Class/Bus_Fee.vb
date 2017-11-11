Public Class Bus_Fee
    Dim Dac_Fee1 As New Dac_Fee

    Friend Function GetGroupFeeInfo(ByVal GroupID As Integer, ByVal EngageTypeID As Integer) As DataTable
        GetGroupFeeInfo = Dac_Fee1.GetGroupFeeInfo(GroupID, EngageTypeID)
    End Function

    Friend Function GetHouseFeeInfo() As DataTable
        GetHouseFeeInfo = Dac_Fee1.GetHouseFeeInfo()
    End Function

    Friend Function GetFoodFeeInfo() As DataTable
        GetFoodFeeInfo = Dac_Fee1.GetFoodFeeInfo()
    End Function

    Friend Function GetMarriageFeeInfo(ByVal MarriageFeeCode As Integer) As DataTable
        GetMarriageFeeInfo = Dac_Fee1.GetMarriageFeeInfo(MarriageFeeCode)
    End Function

    Friend Function GetSoldierFeeInfo(ByVal SoldierFeeGroupID As Integer, ByVal SoldierFeeSoldierID As Integer) As DataTable
        GetSoldierFeeInfo = Dac_Fee1.GetSoldierFeeInfo(SoldierFeeGroupID, SoldierFeeSoldierID)
    End Function

End Class
