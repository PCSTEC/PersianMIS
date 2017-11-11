Public Class Bus_Other
    Dim Dac_Other1 As New Dac_Other

    Friend Function GetJobIfo() As DataTable
        GetJobIfo = Dac_Other1.GetJobIfo()
    End Function
    Friend Function GetGroupIfo() As DataTable
        GetGroupIfo = Dac_Other1.GetGroupIfo
    End Function
    Friend Function GetDescribeIfo() As DataTable
        GetDescribeIfo = Dac_Other1.GetDescribeIfo
    End Function

    Friend Function GetSexIfo() As DataTable
        GetSexIfo = Dac_Other1.GetSexIfo
    End Function

    Friend Function GetMilitaryIfo() As DataTable
        GetMilitaryIfo = Dac_Other1.GetMilitaryIfo
    End Function

    Friend Function GetPeriod() As DataTable
        GetPeriod = Dac_Other1.GetPeriod()
    End Function

    Friend Function GetAssureInfo() As DataTable
        GetAssureInfo = Dac_Other1.GetAssureInfo()
    End Function

    Friend Function GetReportType() As DataTable
        GetReportType = Dac_Other1.GetReportType
    End Function

    Friend Function GetMounthInfo() As DataTable
        GetMounthInfo = Dac_Other1.GetMounthInfo()
    End Function

    Friend Function insert_tbHR_Describ(ByVal Describtion As String)
        Dac_Other1.insert_tbHR_Describ(Describtion)
    End Function

    Friend Function AlefbaInfo() As DataTable
        AlefbaInfo = Dac_Other1.AlefbaInfo
    End Function
    Friend Function GetYegan() As DataTable
        GetYegan = Dac_Other1.GetYegan
    End Function

End Class
