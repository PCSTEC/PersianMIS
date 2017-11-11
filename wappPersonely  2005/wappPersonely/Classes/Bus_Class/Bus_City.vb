Public Class Bus_City

    Dim Dac_City1 As New Dac_City

    Friend Function inserttbHRCountry(ByVal CountryCode As Integer, ByVal Countrytxt As String)
        Dac_City1.inserttbHRCountry(CountryCode, Countrytxt)
    End Function

    Friend Function inserttbHRCity(ByVal CityCode As Integer, ByVal Citytxt As String, ByVal CountryID As Integer, ByVal CountryCode As Integer)
        Dac_City1.inserttbHRCity(CityCode, Citytxt, CountryID, CountryCode)
    End Function

    Friend Function GetCityIfos() As DataTable
        GetCityIfos = Dac_City1.GetCityIfo
    End Function

    Friend Function GetCityIfo() As DataTable
        GetCityIfo = Dac_City1.GetCityIfo
    End Function

    Friend Function GetCountryInfo() As DataTable
        GetCountryInfo = Dac_City1.GetCountryInfo
    End Function

    Friend Function GetCityInfo(ByVal CountryCode As Integer) As DataTable
        GetCityInfo = Dac_City1.GetCityInfo(CountryCode)
    End Function
End Class
