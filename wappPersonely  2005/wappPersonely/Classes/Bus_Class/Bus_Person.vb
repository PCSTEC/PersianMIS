Public Class Bus_Person
    Dim Dac_Person1 As New Dac_Person

    Friend Sub insertPerson(ByVal PersonCode As Integer, ByVal FirstName As String, ByVal LastName As String, ByVal FatherName As String, ByVal BirthDate As String, ByVal SexID As Integer, ByVal NationalCode As String, ByVal IDNum As String, ByVal IDSerial As String, ByVal BirthCityID As Integer, ByVal BirthCityCode As Integer, ByVal IDIssueID As Integer, ByVal MilitaryStateID As Integer, ByVal EngageDate As String, ByVal WorkIDNum As String, ByVal AssureNum As String, ByVal Address As String, ByVal Tel As String, ByVal Mobile As String, ByVal IDIssueCode As Integer, ByVal PostalCode As String, ByVal PersonImage() As Byte, ByVal YeganId As Integer)
        Dac_Person1.insertPerson(PersonCode, FirstName, LastName, FatherName, BirthDate, SexID, NationalCode, IDNum, IDSerial, BirthCityID, BirthCityCode, IDIssueID, MilitaryStateID, EngageDate, WorkIDNum, AssureNum, Address, Tel, Mobile, IDIssueCode, PostalCode, PersonImage, YeganId)
    End Sub

    Friend Sub updatePersonPry(ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal FirstName As String, ByVal LastName As String, ByVal FatherName As String, ByVal BirthDate As String, ByVal SexID As Integer, ByVal NationalCode As String, ByVal IDNum As String, ByVal IDSerial As String, ByVal BirthCityID As Integer, ByVal BirthCityCode As Integer, ByVal IDIssueID As Integer, ByVal MilitaryStateID As Integer, ByVal EngageDate As String, ByVal WorkIDNum As String, ByVal AssureNum As String, ByVal Address As String, ByVal Tel As String, ByVal Mobile As String, ByVal IDIssueCode As Integer, ByVal PostalCode As String, ByVal YeganId As Integer)
        Dac_Person1.updatePersonPry(PersonID, PersonCode, FirstName, LastName, FatherName, BirthDate, SexID, NationalCode, IDNum, IDSerial, BirthCityID, BirthCityCode, IDIssueID, MilitaryStateID, EngageDate, WorkIDNum, AssureNum, Address, Tel, Mobile, IDIssueCode, PostalCode, YeganId)
    End Sub
  
    Friend Sub UpdatePrsImage(ByVal PersonID As Integer, ByVal PersonImage As Byte())
        Dac_Person1.UpdatePrsImage(PersonID, PersonImage)
    End Sub
    Friend Sub UpdatePezeshkiImage(ByVal ID As Integer, ByVal PezeshkiImage As Byte())
        Dac_Person1.UpdatePezeshkiImage(ID, PezeshkiImage)
    End Sub
    Friend Function InsertPezeshki(ByVal PersonCode As Integer, ByVal HistDate As String) As Integer
        InsertPezeshki = Dac_Person1.InsertPezeshki(PersonCode, HistDate)
    End Function

    Friend Function GetJobRequestInfo() As DataTable
        GetJobRequestInfo = Dac_Person1.GetJobRequestInfo
    End Function

    Friend Function GetPersonInfo() As DataTable
        GetPersonInfo = Dac_Person1.GetPersonInfo
    End Function

    Friend Function GetPersonInDepartInfo(ByVal UpperCode As String) As DataTable
        GetPersonInDepartInfo = Dac_Person1.GetPersonInDepartInfo(UpperCode)
    End Function

    Friend Sub insert_tbHR_JobRequest(ByVal FormID As Integer, ByVal FillDate As String, ByVal FirstName As String, ByVal LastName As String, ByVal FatherName As String, ByVal IDNumber As String, ByVal NationalCode As String, ByVal BirthDate As String, ByVal BirthCityID As Integer, ByVal Tel As String, ByVal Mobile As String, ByVal DiplomaID As Integer, ByVal EduationTypeID As Integer, ByVal AttitudeID As Integer, ByVal MDepartCode As String, ByVal MilitaryStateID As Integer)
        Dac_Person1.insert_tbHR_JobRequest(FormID, FillDate, FirstName, LastName, FatherName, IDNumber, NationalCode, BirthDate, BirthCityID, Tel, Mobile, DiplomaID, EduationTypeID, AttitudeID, MDepartCode, MilitaryStateID)
    End Sub

    Friend Function GetAlarmInfo(ByVal CurDate As String, ByVal Day As String, ByVal EngageTypeID As Integer) As DataTable
        GetAlarmInfo = Dac_Person1.GetAlarmInfo(CurDate, Day, EngageTypeID)
    End Function

    Friend Function GetAlarmInfoForShowHide(ByVal CurDate As String, ByVal Day As String) As DataTable
        GetAlarmInfoForShowHide = Dac_Person1.GetAlarmInfoForShowHide(CurDate, Day)
    End Function

End Class
