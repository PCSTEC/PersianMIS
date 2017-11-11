Public Class Dac_Other
    Friend Function GetJobIfo() As DataTable
        Dim sqlstr As String
        'sqlstr = "select * from tbHR_JobTitle ORDER BY JobTitletxt"
        sqlstr = _
        "SELECT     TOP 100 PERCENT JobTitleID, JobTitletxt + ' _ ' + CAST(JobCode  AS char) AS JobTitletxt " & _
        "FROM         dbo.tbHR_JobTitle " & _
        "ORDER BY JobTitletxt + ' _ ' + CAST(JobtitleCode_Del AS char)"

        GetJobIfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetPeriod() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_Period"
        GetPeriod = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetGroupIfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_Group"
        GetGroupIfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetDescribeIfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_Describ"
        GetDescribeIfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetMilitaryIfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_MilitaryState ORDER BY MilitaryStateName"
        GetMilitaryIfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetAssureInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_Assure"
        GetAssureInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetReportType() As DataTable
        Dim sqlstr As String
        'sqlstr = "select * from tbHR_ReportType_del WHERE (rptGrpName = N'PRSN') order by ReportTitle"
        sqlstr = "SELECT     ReportCode, ReportTitle FROM GeneralObjects.dbo.tbGen_AllReport WHERE     (AppID = 54) AND (ReportCode <> 1)and active = 1 order by ReportTitle"
        GetReportType = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function AlefbaInfo() As DataTable
        Dim SqlStr As String
        SqlStr = "select * from tbHR_Alefba"
        AlefbaInfo = Persist1.GetDataTable(ConString, SqlStr)
    End Function

    Friend Function GetMounthInfo() As DataTable
        SqlStr = "Select * from tbHR_Mounth"
        GetMounthInfo = Persist1.GetDataTable(ConString, SqlStr)
    End Function

    Friend Function insert_tbHR_Describ(ByVal Describtion As String)
        Persist1.Sp_AddParam("@Describtion_2", SqlDbType.NText, Describtion, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Describ", ConString, True)
    End Function

    Friend Function GetSexIfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_Sex ORDER BY Sextxt"
        GetSexIfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function
    Friend Function GetYegan() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tb_Yegan"
        GetYegan = Persist1.GetDataTable(ConString, sqlstr)
    End Function

End Class
