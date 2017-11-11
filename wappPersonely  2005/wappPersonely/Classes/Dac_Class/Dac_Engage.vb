Public Class Dac_Engage

    Friend Function GetFirstEngagePersonInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_FirstEngagePerson"
        GetFirstEngagePersonInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetEngageTypeIfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_EngageType ORDER BY EngageType"
        GetEngageTypeIfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function
End Class
