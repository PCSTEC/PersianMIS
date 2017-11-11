Public Class frmAddStudyPlace
    Dim Bus_Education1 As New Bus_Education

    Private Sub frmAddStudyPlace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillgrdCountry()
        FillgrdStudyPlaceType()
        ''''‰Ÿ— ”‰ÃÌ
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub

    Friend Function FillgrdCountry()
        Dim dt_Country As New DataTable
        dt_Country = Bus_City1.GetCountryInfo()
        janus1.GetBindJGrid_DT(dt_Country, grdCountry, ConString)
        janus1.setMyJGrid(grdCountry, "CountryID", "", 0, , , False)
        janus1.setMyJGrid(grdCountry, "CountryCode", "ﬂœ ﬂ‘Ê—", 75)
        janus1.setMyJGrid(grdCountry, "Countrytxt", "‰«„ ﬂ‘Ê—", 175)
    End Function

    Friend Function FillgrdCity()
        Dim dt_City As New DataTable
        Dim CountryCode As Integer
        CountryCode = grdCountry.GetValue("CountryCode")
        dt_City = Bus_City1.GetCityInfo(CountryCode)
        janus1.GetBindJGrid_DT(dt_City, grdCity, ConString)
        janus1.setMyJGrid(grdCity, "CityID", "", 0, , , False)
        janus1.setMyJGrid(grdCity, "CountryCode", "ﬂœ ﬂ‘Ê—", 100)
        janus1.setMyJGrid(grdCity, "CityCode", "ﬂœ ‘Â—", 100)
        janus1.setMyJGrid(grdCity, "Citytxt", "‰«„ ‘Â—", 200)
    End Function

    Private Sub grdCountry_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdCountry.CurrentCellChanged
        Try
            FillgrdCity()
        Catch ex As Exception

        End Try
    End Sub

    Friend Function FillgrdStudyPlaceType()
        Dim dt_StudyPlaceType As New DataTable
        dt_StudyPlaceType = Bus_Education1.GetStudyPlaceTypeInfo
        janus1.GetBindJGrid_DT(dt_StudyPlaceType, grdStudyPlaceType, ConString)
        janus1.setMyJGrid(grdStudyPlaceType, "StudyPlaceTypeID", "", 0, , , False)
        janus1.setMyJGrid(grdStudyPlaceType, "StudyPlaceTypeCode", "ﬂœ ‰Ê⁄  Õ’Ì·« ", 100)
        janus1.setMyJGrid(grdStudyPlaceType, "StudyPlaceType", "‰Ê⁄  Õ’Ì·« ", 250)
    End Function

    Friend Function FillgrdStudyPlace()
        Dim dt_StudyPlace As New DataTable
        Dim CityCode, StudyPlaceTypeCode As Integer
        ' StudyPlaceTypeID, StudyPlaceTypeCode, CityID, 
        CityCode = grdCity.GetValue("CityCode")
        StudyPlaceTypeCode = grdStudyPlaceType.GetValue("StudyPlaceTypeCode")
        dt_StudyPlace = Bus_Education1.GetStudyPlaceInfo(CityCode, StudyPlaceTypeCode)
        janus1.GetBindJGrid_DT(dt_StudyPlace, grdStudyPlace, ConString)
        janus1.setMyJGrid(grdStudyPlace, "StudyPlaceID", "", 0, , , False)
        janus1.setMyJGrid(grdStudyPlace, "CityCode", "ﬂœ ‘Â— „Õ·  Õ’Ì·", 0, , , False)
        janus1.setMyJGrid(grdStudyPlace, "StudyPlaceCode", "ﬂœ  Õ’Ì·« ", 100)
        janus1.setMyJGrid(grdStudyPlace, "StudyPlacetxt", "‰«„ „Õ·  Õ’Ì·", 250)
    End Function

    Private Sub grdStudyPlaceType_CurrentCellChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdStudyPlaceType.CurrentCellChanged
        Try
            FillgrdStudyPlace()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddCountry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCountry.Click
        Dim CountryCode As Integer
        Dim dt As New DataTable
        If txtCountrytxt.Text.Trim = "" Then
            MsgBox("·ÿ›« ‰«„ ﬂ‘Ê— —« Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If MsgBox("¬Ì« «“ À»  —ﬂÊ—œ „Ê—œ ‰Ÿ— „ÿ„∆‰ „Ì »«‘Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SqlStr = "SELECT     MAX(CountryCode) AS MaxCountryCode   FROM tbHR_Country"
            dt = Persist1.GetDataTable(ConString, SqlStr)
            CountryCode = dt.DefaultView.Item(0).Item("MaxCountryCode") + 1
            Bus_City1.inserttbHRCountry(CountryCode, txtCountrytxt.Text.Trim)
            FillgrdCountry()
            MsgBox("—ﬂÊ—œ »« „Ê›ﬁÌ  À»  ‘œ", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub btnAddCity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCity.Click
        Dim CityCode, CountryID, CountryCode As Integer
        Dim dt As New DataTable
        If txtCityTxt.Text.Trim = "" Then
            MsgBox("·ÿ›« ‰«„ ‘Â— —« Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If MsgBox("¬Ì« «“ À»  —ﬂÊ—œ „Ê—œ ‰Ÿ— „ÿ„∆‰ „Ì »«‘Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SqlStr = "SELECT     MAX(CityCode) AS MAXCityCode   FROM tbHR_City"
            dt = Persist1.GetDataTable(ConString, SqlStr)
            CityCode = dt.DefaultView.Item(0).Item("MAXCityCode") + 1
            CountryCode = grdCountry.GetValue("CountryCode")
            CountryID = grdCountry.GetValue("CountryID")
            Bus_City1.inserttbHRCity(CityCode, txtCityTxt.Text.Trim, CountryID, CountryCode)
            FillgrdCity()
            MsgBox("—ﬂÊ—œ »« „Ê›ﬁÌ  À»  ‘œ", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub btnAddStudyPlace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStudyPlace.Click
        Dim StudyPlaceCode As Integer
        Dim StudyPlaceCodetxt, CityCode, StudyPlacetypeCode As String
        Dim dt As New DataTable
        If txtStudyPlaceName.Text.Trim = "" Then
            MsgBox("·ÿ›« ‰«„ „Õ·  Õ’Ì· —« Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If MsgBox("¬Ì« «“ À»  —ﬂÊ—œ „Ê—œ ‰Ÿ— „ÿ„∆‰ „Ì »«‘Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            CityCode = Str(grdCity.GetValue("CityCode"))
            StudyPlacetypeCode = Str(grdStudyPlaceType.GetValue("StudyPlacetypeCode"))
            SqlStr = "SELECT    ISNULL(MAX(StudyPlaceCode), 0) AS MAXStudyPlaceCode FROM tbHR_StudyPlace WHERE (CityCode = " & grdCity.GetValue("CityCode") & ") AND (StudyPlaceTypeCode = " & grdStudyPlaceType.GetValue("StudyPlaceTypeCode") & ")"
            dt = Persist1.GetDataTable(ConString, SqlStr)
            If dt.DefaultView.Item(0).Item("MAXStudyPlaceCode") = 0 Then
                StudyPlaceCodetxt = CityCode + StudyPlacetypeCode + "01"
                StudyPlaceCode = Decimal.Round(Val(StudyPlaceCodetxt))
            Else
                StudyPlaceCode = dt.DefaultView.Item(0).Item("MAXStudyPlaceCode") + 1
            End If
            Bus_Education1.inserttbHRStudyPlace(StudyPlaceCode, txtStudyPlaceName.Text.Trim, grdStudyPlaceType.GetValue("StudyPlaceTypeID"), grdStudyPlaceType.GetValue("StudyPlaceTypeCode"), grdCity.GetValue("CityID"), grdCity.GetValue("CityCode"))
            FillgrdStudyPlace()
            MsgBox("—ﬂÊ—œ »« „Ê›ﬁÌ  À»  ‘œ", MsgBoxStyle.Information, "")
        End If
    End Sub
End Class