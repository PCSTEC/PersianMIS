Public Class Bus_Family
    Dim Dac_Family1 As New Dac_Family

    Friend Sub InsertFamilyInfo(ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal FirstName As String, ByVal LastName As String, ByVal BirthDate As String, ByVal BirthCityID As Integer, ByVal BirthCityCode As Integer, ByVal IDNum As String, ByVal IssueID As Integer, ByVal IssueCode As Integer, ByVal AffineID As Integer, ByVal NationalCode As String, ByVal MarriedID As Integer)
        Dac_Family1.InsertFamilyInfo(PersonID, PersonCode, FirstName, LastName, BirthDate, BirthCityID, BirthCityCode, IDNum, IssueID, IssueCode, AffineID, NationalCode, MarriedID)
    End Sub

    Friend Sub UpdateFamilyInfo(ByVal FamilyID As Integer, ByVal FirstName As String, ByVal LastName As String, ByVal BirthDate As String, ByVal BirthCityID As Integer, ByVal BirthCityCode As Integer, ByVal IDNum As String, ByVal IssueID As Integer, ByVal IssueCode As Integer, ByVal AffineID As Integer, ByVal NationalCode As String, ByVal MarriedID As Integer)
        Dac_Family1.UpdateFamilyInfo(FamilyID, FirstName, LastName, BirthDate, BirthCityID, BirthCityCode, IDNum, IssueID, IssueCode, AffineID, NationalCode, MarriedID)
    End Sub

    Friend Sub DeleteFamilyInfo(ByVal FamilyID As Integer)
        Dac_Family1.DeleteFamilyInfo(FamilyID)
    End Sub

    Friend Function GetFamilyInfo(ByVal PersonCode As Integer) As DataTable
        GetFamilyInfo = Dac_Family1.GetFamilyInfo(PersonCode)
    End Function
    Friend Function GetMarriedTypes() As DataTable
        GetMarriedTypes = Dac_Family1.GetMarriedTypes()
    End Function
    Friend Function GetMarriedInfo(ByVal PersonCode As Integer) As DataTable
        GetMarriedInfo = Dac_Family1.GetMarriedInfo(PersonCode)
    End Function

    Friend Function GetAffineInfo() As DataTable
        GetAffineInfo = Dac_Family1.GetAffineInfo()
    End Function
End Class
