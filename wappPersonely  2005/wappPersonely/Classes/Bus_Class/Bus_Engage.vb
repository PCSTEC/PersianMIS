Public Class Bus_Engage

    Dim Dac_Engage1 As New Dac_Engage

    Friend Function GetEngageTypeIfo() As DataTable
        GetEngageTypeIfo = Dac_Engage1.GetEngageTypeIfo
    End Function

    Friend Function GetFirstEngagePersonInfo() As DataTable
        GetFirstEngagePersonInfo = Dac_Engage1.GetFirstEngagePersonInfo()
    End Function
End Class
