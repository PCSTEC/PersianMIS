Public Class Dac_City

    Friend Function inserttbHRCountry(ByVal CountryCode As Integer, ByVal Countrytxt As String)
        Persist1.Sp_AddParam("@CountryCode_1", SqlDbType.Int, CountryCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Countrytxt_2", SqlDbType.NVarChar, Countrytxt, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Country", ConString, True)
    End Function

    Friend Function inserttbHRCity(ByVal CityCode As Integer, ByVal Citytxt As String, ByVal CountryID As Integer, ByVal CountryCode As Integer)
        Persist1.Sp_AddParam("@CityCode_1", SqlDbType.Int, CityCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Citytxt_2", SqlDbType.NVarChar, Citytxt, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountryID_3", SqlDbType.Int, CountryID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountryCode_4", SqlDbType.Int, CountryCode, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_City", ConString, True)
    End Function

    Friend Function GetCityIfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_City ORDER BY Citytxt"
        GetCityIfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetCountryInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "SELECT  *  FROM tbHR_Country"
        GetCountryInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetCityInfo(ByVal CountryCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = "SELECT * FROM  tbHR_City  WHERE (CountryCode = " & CountryCode & ")"
        GetCityInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

End Class
