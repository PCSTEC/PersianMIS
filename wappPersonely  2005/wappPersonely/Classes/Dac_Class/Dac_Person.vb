Public Class Dac_Person
    Friend Function insertPerson(ByVal PersonCode As Integer, ByVal FirstName As String, ByVal LastName As String, ByVal FatherName As String, ByVal BirthDate As String, ByVal SexID As Integer, ByVal NationalCode As String, ByVal IDNum As String, ByVal IDSerial As String, ByVal BirthCityID As Integer, ByVal BirthCityCode As Integer, ByVal IDIssueID As Integer, ByVal MilitaryStateID As Integer, ByVal EngageDate As String, ByVal WorkIDNum As String, ByVal AssureNum As String, ByVal Address As String, ByVal Tel As String, ByVal Mobile As String, ByVal IDIssueCode As Integer, ByVal PostalCode As String, ByVal PersonImage() As Byte, ByVal YeganId As Integer)
        Persist1.Sp_AddParam("@PersonCode_1", SqlDbType.Int, PersonCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@FirstName_2", SqlDbType.NVarChar, FirstName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@LastName_3", SqlDbType.NVarChar, LastName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@FatherName_4", SqlDbType.NVarChar, FatherName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthDate_5", SqlDbType.Char, BirthDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@SexID_6", SqlDbType.SmallInt, SexID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@NationalCode_7", SqlDbType.VarChar, NationalCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IDNum_8", SqlDbType.VarChar, IDNum, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IDSerial_9", SqlDbType.VarChar, IDSerial, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthCityID_10", SqlDbType.Int, BirthCityID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthCityCode_11", SqlDbType.Int, BirthCityCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IDIssueID_12", SqlDbType.Int, IDIssueID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MilitaryStateID_13", SqlDbType.SmallInt, MilitaryStateID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EngageDate_14", SqlDbType.Char, EngageDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@WorkIDNum_15", SqlDbType.NVarChar, WorkIDNum, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AssureNum_16", SqlDbType.NVarChar, AssureNum, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Address_17", SqlDbType.NVarChar, Address, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Tel_18", SqlDbType.NVarChar, Tel, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Mobile_19", SqlDbType.NVarChar, Mobile, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IDIssueCode_20", SqlDbType.Int, IDIssueCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PostalCode_21", SqlDbType.VarChar, PostalCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonImage_22", SqlDbType.Image, PersonImage, ParameterDirection.Input)
        Persist1.Sp_AddParam("@YeganId_23", SqlDbType.Int, YeganId, ParameterDirection.Input)

        Persist1.Sp_Exe("insert_tbHR_Person", ConString, True)
    End Function

    Friend Function updatePersonPry(ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal FirstName As String, ByVal LastName As String, ByVal FatherName As String, ByVal BirthDate As String, ByVal SexID As Integer, ByVal NationalCode As String, ByVal IDNum As String, ByVal IDSerial As String, ByVal BirthCityID As Integer, ByVal BirthCityCode As Integer, ByVal IDIssueID As Integer, ByVal MilitaryStateID As Integer, ByVal EngageDate As String, ByVal WorkIDNum As String, ByVal AssureNum As String, ByVal Address As String, ByVal Tel As String, ByVal Mobile As String, ByVal IDIssueCode As Integer, ByVal PostalCode As String, ByVal YeganId As Integer)
        Persist1.Sp_AddParam("@PersonID_1", SqlDbType.Int, PersonID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonCode_2", SqlDbType.Int, PersonCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@FirstName_3", SqlDbType.NVarChar, FirstName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@LastName_4", SqlDbType.NVarChar, LastName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@FatherName_5", SqlDbType.NVarChar, FatherName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthDate_6", SqlDbType.Char, BirthDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@SexID_7", SqlDbType.SmallInt, SexID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@NationalCode_8", SqlDbType.VarChar, NationalCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IDNum_9", SqlDbType.VarChar, IDNum, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IDSerial_10", SqlDbType.VarChar, IDSerial, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthCityID_11", SqlDbType.Int, BirthCityID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthCityCode_12", SqlDbType.Int, BirthCityCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IDIssueID_13", SqlDbType.Int, IDIssueID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MilitaryStateID_14", SqlDbType.SmallInt, MilitaryStateID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EngageDate_15", SqlDbType.Char, EngageDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@WorkIDNum_16", SqlDbType.NVarChar, WorkIDNum, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AssureNum_17", SqlDbType.NVarChar, AssureNum, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Address_18", SqlDbType.NVarChar, Address, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Tel_19", SqlDbType.NVarChar, Tel, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Mobile_20", SqlDbType.NVarChar, Mobile, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IDIssueCode_21", SqlDbType.Int, IDIssueCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PostalCode_22", SqlDbType.NVarChar, PostalCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@YeganId_23", SqlDbType.Int, YeganId, ParameterDirection.Input)

        Persist1.Sp_Exe("update_tbHR_Person", ConString, True)
    End Function

    Friend Function InsertPezeshki(ByVal PersonCode As Integer, ByVal HistDate As String) As Integer

        Persist1.ClearParameter()

        Persist1.Sp_AddParam("@id", SqlDbType.Int, 0, ParameterDirection.Output)
        Persist1.Sp_AddParam("@PersonCode", SqlDbType.Int, PersonCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@HistDate", SqlDbType.NVarChar, HistDate, ParameterDirection.Input)


        Persist1.Sp_Exe("Insert_tbPRS_PezeshkHist", ConString, False)
        InsertPezeshki = Persist1.ParameterCmd1(1).ParamValue



    End Function

    Friend Sub insert_tbHR_JobRequest(ByVal FormID As Integer, ByVal FillDate As String, ByVal FirstName As String, ByVal LastName As String, ByVal FatherName As String, ByVal IDNumber As String, ByVal NationalCode As String, ByVal BirthDate As String, ByVal BirthCityID As Integer, ByVal Tel As String, ByVal Mobile As String, ByVal DiplomaID As Integer, ByVal EduationTypeID As Integer, ByVal AttitudeID As Integer, ByVal MDepartCode As String, ByVal MilitaryStateID As Integer)
        Persist1.Sp_AddParam("@FormID_1", SqlDbType.Int, FormID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@FillDate_2", SqlDbType.Char, FillDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@FirstName_3", SqlDbType.NVarChar, FirstName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@LastName_4", SqlDbType.NVarChar, LastName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@FatherName_5", SqlDbType.NVarChar, FatherName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IDNumber_6", SqlDbType.VarChar, IDNumber, ParameterDirection.Input)
        Persist1.Sp_AddParam("@NationalCode_7", SqlDbType.VarChar, NationalCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthDate_8", SqlDbType.Char, BirthDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthCityID_9", SqlDbType.VarChar, BirthCityID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Tel_10", SqlDbType.VarChar, Tel, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Mobile_11", SqlDbType.VarChar, Mobile, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DiplomaID_12", SqlDbType.Int, DiplomaID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EduationTypeID_13", SqlDbType.Int, EduationTypeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AttitudeID_14", SqlDbType.Int, AttitudeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MDepartCode_15", SqlDbType.NVarChar, MDepartCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MilitaryStateID_16", SqlDbType.Int, MilitaryStateID, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_JobRequest", ConString, True)
    End Sub

    Friend Function GetJobRequestInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_JobRequest"
        GetJobRequestInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetPersonInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_PRSEmployee where EmployeeActive = 1 and DepartActive=1 and PostActive=1"
        GetPersonInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function UpdatePrsImage(ByVal PersonID As Integer, ByVal PersonImage As Byte())
        Persist1.Sp_AddParam("@PersonID_1", SqlDbType.Int, PersonID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonImage_2", SqlDbType.Image, PersonImage, ParameterDirection.Input)
        Persist1.Sp_Exe("update_ImagetbPerson", ConString, True)
    End Function
    Friend Function UpdatePezeshkiImage(ByVal PersonID As Integer, ByVal PersonImage As Byte())
        Persist1.ClearParameter()
        Persist1.Sp_AddParam("@ID_1", SqlDbType.Int, PersonID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PezeshkiImage_2", SqlDbType.Image, PersonImage, ParameterDirection.Input)
        Persist1.Sp_Exe("update_ImagetbPezeshki", ConString, True)
    End Function
    Friend Function GetPersonInDepartInfo(ByVal UpperCode As String) As DataTable
        Dim sqlstr As String
        sqlstr = _
                    "SELECT     * " & _
                        "FROM         VwHR_PersonInDepart " & _
                         "WHERE     (substring(DepartCode,1,2) = '" & Mid(UpperCode, 1, 2) & "')"
        GetPersonInDepartInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetAlarmInfo(ByVal CurDate As String, ByVal Day As String, ByVal EngageTypeID As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = "select * from dbo.VwHR_EndEmployee where (EndDate BETWEEN  '" & CurDate & "'   AND '" & Day & "' ) AND (EngageTypeID = " & EngageTypeID & ")"
        GetAlarmInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetAlarmInfoForShowHide(ByVal CurDate As String, ByVal Day As String) As DataTable
        Dim sqlstr As String
        sqlstr = "select * from dbo.VwHR_EndEmployee where (EndDate BETWEEN  '" & CurDate & "'   AND '" & Day & "' )"
        GetAlarmInfoForShowHide = Persist1.GetDataTable(ConString, sqlstr)
    End Function

End Class