Public Class Bus_Education
    Dim Dac_Education1 As New Dac_Education

    Friend Sub InsertEducationInfo(ByVal PersonID As Integer, ByVal eduPersonCode As Integer, ByVal StudyPlaceID As Integer, ByVal StudyPlaceCode As Integer, ByVal BeginDate As String, ByVal EndDate As String, ByVal DiplomaID As Integer, ByVal DiplomaCode As Integer, ByVal AttitudeID As Integer, ByVal AttitudeCode As Integer, ByVal Average As Double, ByVal Active As Boolean)
        Dac_Education1.InsertEducationInfo(PersonID, eduPersonCode, StudyPlaceID, StudyPlaceCode, BeginDate, EndDate, DiplomaID, DiplomaCode, AttitudeID, AttitudeCode, Average, Active)
    End Sub

    Friend Sub updateActievetbHREducation(ByVal EducationID As Integer, ByVal Active As Boolean)
        Dac_Education1.updateActievetbHREducation(EducationID, Active)
    End Sub

    Friend Function GetEducationTypeInfo() As DataTable
        GetEducationTypeInfo = Dac_Education1.GetEducationTypeInfo()
    End Function

    Friend Sub UpdateEducationInfo(ByVal EducationID As Integer, ByVal StudyPlaceID As Integer, ByVal StudyPlaceCode As Integer, ByVal BeginDate As String, ByVal EndDate As String, ByVal DiplomaID As Integer, ByVal DiplomaCode As Integer, ByVal AttitudeID As Integer, ByVal AttitudeCode As Integer, ByVal Average As Double)
        Dac_Education1.UpdateEducationInfo(EducationID, StudyPlaceID, StudyPlaceCode, BeginDate, EndDate, DiplomaID, DiplomaCode, AttitudeID, AttitudeCode, Average)
    End Sub

    Friend Sub DeleteEducationInfo(ByVal EducationID As Integer)
        Dac_Education1.DeleteEducationInfo(EducationID)
    End Sub
   
    Friend Function GetEducationInfo(ByVal PersonCode As Integer) As DataTable
        GetEducationInfo = Dac_Education1.GetEducationInfo(PersonCode)
    End Function
    Friend Function GetDiplomaInfo() As DataTable
        GetDiplomaInfo = Dac_Education1.GetDiplomaInfo()
    End Function
    Friend Function GetAttitudeInfo() As DataTable
        GetAttitudeInfo = Dac_Education1.GetAttitudeInfo()
    End Function

    Friend Function StudyPlaceInfo() As DataTable
        StudyPlaceInfo = Dac_Education1.StudyPlaceInfo()
    End Function
    Friend Function GeraieshInfo() As DataTable
        GeraieshInfo = Dac_Education1.GeraieshInfo()
    End Function

    Friend Function EducationTypeInfo() As DataTable
        EducationTypeInfo = Dac_Education1.EducationTypeInfo
    End Function

    Friend Function GetBranchInfo(ByVal EducationTypeCode As Integer) As DataTable
        GetBranchInfo = Dac_Education1.GetBranchInfo(EducationTypeCode)
    End Function

    Friend Function GetAttitude(ByVal BranchCode As Integer) As DataTable
        GetAttitude = Dac_Education1.GetAttitude(BranchCode)
    End Function

    Friend Function insert_tbHR_EducationType(ByVal EducationTypeCode As Integer, ByVal EducationTypetxt As String)
        Dac_Education1.insert_tbHR_EducationType(EducationTypeCode, EducationTypetxt)
    End Function

    Friend Function insert_tbHR_Branch(ByVal BranchCode As Integer, ByVal BranchTxt As String, ByVal EducationTypeCode As Integer, ByVal EducationTypeID As Integer)
        Dac_Education1.insert_tbHR_Branch(BranchCode, BranchTxt, EducationTypeCode, EducationTypeID)
    End Function

    Friend Function insert_tbHR_Attitude(ByVal AttitudeCode As Integer, ByVal AttitudeName As String, ByVal BranchCode As Integer, ByVal BranchID As Integer)
        Dac_Education1.insert_tbHR_Attitude(AttitudeCode, AttitudeName, BranchCode, BranchID)
    End Function

    Friend Function GetStudyPlaceInfo(ByVal CityCode As Integer, ByVal StudyPlaceTypeCode As Integer) As DataTable
        GetStudyPlaceInfo = Dac_Education1.GetStudyPlaceInfo(CityCode, StudyPlaceTypeCode)
    End Function

    Friend Function GetStudyPlaceTypeInfo() As DataTable
        GetStudyPlaceTypeInfo = Dac_Education1.GetStudyPlaceTypeInfo
    End Function

    Friend Function inserttbHRStudyPlace(ByVal StudyPlaceCode As Integer, ByVal StudyPlacetxt As String, ByVal StudyPlaceTypeID As Integer, ByVal StudyPlaceTypeCode As Integer, ByVal CityID As Integer, ByVal CityCode As Integer)
        Dac_Education1.inserttbHRStudyPlace(StudyPlaceCode, StudyPlacetxt, StudyPlaceTypeID, StudyPlaceTypeCode, CityID, CityCode)
    End Function
End Class
