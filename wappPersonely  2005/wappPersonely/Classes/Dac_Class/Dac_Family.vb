Public Class Dac_Family
    Friend Function InsertFamilyInfo(ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal FirstName As String, ByVal LastName As String, ByVal BirthDate As String, ByVal BirthCityID As Integer, ByVal BirthCityCode As Integer, ByVal IDNum As String, ByVal IssueID As Integer, ByVal IssueCode As Integer, ByVal AffineID As Integer, ByVal NationalCode As String, ByVal MarriedID As Integer)
        Persist1.Sp_AddParam("@PersonID_1", SqlDbType.Int, PersonID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonCode_2", SqlDbType.Int, PersonCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@FirstName_3", SqlDbType.NVarChar, FirstName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@LastName_4", SqlDbType.NVarChar, LastName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthDate_5", SqlDbType.Char, BirthDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthCityID_6", SqlDbType.Int, BirthCityID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthCityCode_7", SqlDbType.Int, BirthCityCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IDNum_8", SqlDbType.NVarChar, IDNum, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IssueID_9", SqlDbType.Int, IssueID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IssueCode_10", SqlDbType.Int, IssueCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AffineID_11", SqlDbType.Int, AffineID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@NationalCode_12", SqlDbType.Char, NationalCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MarriedID_13", SqlDbType.SmallInt, MarriedID, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Family", ConString, True)
    End Function

    Friend Function UpdateFamilyInfo(ByVal FamilyID As Integer, ByVal FirstName As String, ByVal LastName As String, ByVal BirthDate As String, ByVal BirthCityID As Integer, ByVal BirthCityCode As Integer, ByVal IDNum As String, ByVal IssueID As Integer, ByVal IssueCode As Integer, ByVal AffineID As Integer, ByVal NationalCode As String, ByVal MarriedID As Integer)
        Persist1.Sp_AddParam("@FamilyID_1", SqlDbType.Int, FamilyID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@FirstName_2", SqlDbType.NVarChar, FirstName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@LastName_3", SqlDbType.NVarChar, LastName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthDate_4", SqlDbType.Char, BirthDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthCityID_5", SqlDbType.Int, BirthCityID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BirthCityCode_6", SqlDbType.Int, BirthCityCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IDNum_7", SqlDbType.NVarChar, IDNum, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IssueID_8", SqlDbType.Int, IssueID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@IssueCode_9", SqlDbType.Int, IssueCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AffineID_10", SqlDbType.Int, AffineID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@NationalCode_11", SqlDbType.Char, NationalCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MarriedID_12", SqlDbType.SmallInt, MarriedID, ParameterDirection.Input)
        Persist1.Sp_Exe("update_tbHR_Family", ConString, True)
    End Function

    Friend Function DeleteFamilyInfo(ByVal FamilyID As Integer)
        Persist1.Sp_AddParam("@FamilyID_1", SqlDbType.Int, FamilyID, ParameterDirection.Input)
        Persist1.Sp_Exe("delete_tbHR_Family", ConString, True)
    End Function

    Friend Function GetFamilyInfo(ByVal PersonCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_FamilyInfo where PersonCode = " & PersonCode & ""
        GetFamilyInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetMarriedInfo(ByVal PersonCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = _
                   "SELECT     * " & _
                   "FROM         VwHR_Married " & _
                   "WHERE     (PersonCode = " & PersonCode & ") AND (AffineID = 1)"
        GetMarriedInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetMarriedTypes() As DataTable
        Dim sqlstr As String
        sqlstr = _
                   "SELECT     * " & _
                   "FROM         tbHR_married "

        GetMarriedTypes = Persist1.GetDataTable(ConString, sqlstr)
    End Function



    Friend Function GetAffineInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_Affine ORDER BY AffineTxt"
        GetAffineInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

End Class
