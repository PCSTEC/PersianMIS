Public Class Dac_Education

    Friend Function UpdateEducationInfo(ByVal EducationID As Integer, ByVal StudyPlaceID As Integer, ByVal StudyPlaceCode As Integer, ByVal BeginDate As String, ByVal EndDate As String, ByVal DiplomaID As Integer, ByVal DiplomaCode As Integer, ByVal AttitudeID As Integer, ByVal AttitudeCode As Integer, ByVal Average As Double)
        Persist1.Sp_AddParam("@EducationID_1", SqlDbType.Int, EducationID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@StudyPlaceID_2", SqlDbType.Int, StudyPlaceID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@StudyPlaceCode_3", SqlDbType.Int, StudyPlaceCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BeginDate_4", SqlDbType.Char, BeginDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EndDate_5", SqlDbType.Char, EndDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DiplomaID_6", SqlDbType.Int, DiplomaID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DiplomaCode_7", SqlDbType.Int, DiplomaCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AttitudeID_8", SqlDbType.Int, AttitudeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AttitudeCode_9", SqlDbType.Int, AttitudeCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Average_10", SqlDbType.Float, Average, ParameterDirection.Input)
        Persist1.Sp_Exe("update_tbHR_Education", ConString, True)
    End Function

    Friend Function InsertEducationInfo(ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal StudyPlaceID As Integer, ByVal StudyPlaceCode As Integer, ByVal BeginDate As String, ByVal EndDate As String, ByVal DiplomaID As Integer, ByVal DiplomaCode As Integer, ByVal AttitudeID As Integer, ByVal AttitudeCode As Integer, ByVal Average As Double, ByVal Active As Boolean)
        Persist1.Sp_AddParam("@PersonID_1", SqlDbType.Int, PersonID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonCode_2", SqlDbType.Int, PersonCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@StudyPlaceID_3", SqlDbType.Int, StudyPlaceID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@StudyPlaceCode_4", SqlDbType.Int, StudyPlaceCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BeginDate_5", SqlDbType.Char, BeginDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EndDate_6", SqlDbType.Char, EndDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DiplomaID_7", SqlDbType.Int, DiplomaID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DiplomaCode_8", SqlDbType.Int, DiplomaCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AttitudeID_9", SqlDbType.Int, AttitudeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AttitudeCode_10", SqlDbType.Int, AttitudeCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Average_11", SqlDbType.Float, Average, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_12", SqlDbType.TinyInt, Active, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Education", ConString, True)
    End Function

    Friend Function updateActievetbHREducation(ByVal EducationID As Integer, ByVal Active As Boolean)
        Persist1.Sp_AddParam("@EducationID_1", SqlDbType.Int, EducationID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_2", SqlDbType.TinyInt, Active, ParameterDirection.Input)
        Persist1.Sp_Exe("update_ActievetbHR_Education", ConString, True)
    End Function

    Friend Function DeleteEducationInfo(ByVal EducationID As Integer)
        Persist1.Sp_AddParam("@EducationID_1", SqlDbType.Int, EducationID, ParameterDirection.Input)
        Persist1.Sp_Exe("delete_tbHR_Education", ConString, True)
    End Function

    Friend Function GetEducationInfo(ByVal PersonCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_EducationInfo where PersonCode  = " & PersonCode & ""
        GetEducationInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetDiplomaInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_Diploma ORDER BY DiplomaName"
        GetDiplomaInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetEducationTypeInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_EducationType"
        GetEducationTypeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function StudyPlaceInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_StudyPlace"
        StudyPlaceInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GeraieshInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_Geraiesh"
        GeraieshInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function EducationTypeInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "SELECT * FROM  dbo.tbHR_EducationType"
        EducationTypeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetBranchInfo(ByVal EducationTypeCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = "SELECT BranchID, BranchCode, BranchTxt, EducationTypeID, EducationTypeCode FROM tbHR_Branch WHERE (EducationTypeCode = " & EducationTypeCode & ")"
        GetBranchInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetAttitude(ByVal BranchCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = "SELECT AttitudeID, AttitudeCode, AttitudeName, BranchCode, BranchID FROM tbHR_Attitude WHERE (BranchCode = " & BranchCode & ")"
        GetAttitude = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetAttitudeInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_Attitude ORDER BY AttitudeName"
        GetAttitudeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function insert_tbHR_EducationType(ByVal EducationTypeCode As Integer, ByVal EducationTypetxt As String)
        Persist1.Sp_AddParam("@EducationTypeCode_1", SqlDbType.Int, EducationTypeCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EducationTypetxt_2", SqlDbType.NVarChar, EducationTypetxt, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_EducationType", ConString, True)
    End Function

    Friend Function insert_tbHR_Branch(ByVal BranchCode As Integer, ByVal BranchTxt As String, ByVal EducationTypeCode As Integer, ByVal EducationTypeID As Integer)
        Persist1.Sp_AddParam("@BranchCode_1", SqlDbType.SmallInt, BranchCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BranchTxt_2", SqlDbType.NVarChar, BranchTxt, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EducationTypeCode_3", SqlDbType.TinyInt, EducationTypeCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EducationTypeID_4", SqlDbType.Int, EducationTypeID, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Branch", ConString, True)
    End Function

    Friend Function insert_tbHR_Attitude(ByVal AttitudeCode As Integer, ByVal AttitudeName As String, ByVal BranchCode As Integer, ByVal BranchID As Integer)
        Persist1.Sp_AddParam("@AttitudeCode_1", SqlDbType.Int, AttitudeCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AttitudeName_2", SqlDbType.NVarChar, AttitudeName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BranchCode_3", SqlDbType.Int, BranchCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BranchID_4", SqlDbType.Int, BranchID, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Attitude", ConString, True)
    End Function


    Friend Function GetStudyPlaceInfo(ByVal CityCode As Integer, ByVal StudyPlaceTypeCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = "SELECT * FROM  tbHR_StudyPlace WHERE (CityCode = " & CityCode & ") AND (StudyPlaceTypeCode = " & StudyPlaceTypeCode & ")"
        GetStudyPlaceInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetStudyPlaceTypeInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "SELECT * FROM tbHR_StudyPlaceType ORDER BY StudyPlaceType"
        GetStudyPlaceTypeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function inserttbHRStudyPlace(ByVal StudyPlaceCode As Integer, ByVal StudyPlacetxt As String, ByVal StudyPlaceTypeID As Integer, ByVal StudyPlaceTypeCode As Integer, ByVal CityID As Integer, ByVal CityCode As Integer)
        Persist1.Sp_AddParam("@StudyPlaceCode_1", SqlDbType.Int, StudyPlaceCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@StudyPlacetxt_2", SqlDbType.NVarChar, StudyPlacetxt, ParameterDirection.Input)
        Persist1.Sp_AddParam("@StudyPlaceTypeID_3", SqlDbType.Int, StudyPlaceTypeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@StudyPlaceTypeCode_4", SqlDbType.Int, StudyPlaceTypeCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CityID_5", SqlDbType.Int, CityID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CityCode_6", SqlDbType.Int, CityCode, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_StudyPlace", ConString, True)
    End Function

End Class

