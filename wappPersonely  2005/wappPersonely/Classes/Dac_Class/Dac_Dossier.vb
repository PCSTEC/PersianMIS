Public Class Dac_Dossier
    Friend Function UpdateDossierIfo(ByVal DossierID As Integer, ByVal JobCo As String, ByVal Jobtxt As String, ByVal AssureID As Integer, ByVal Sallary As Double, ByVal BeginDate As String, ByVal EndDate As String, ByVal DaySum As Integer, ByVal Related As Integer)
        Persist1.Sp_AddParam("@DossierID_1 ", SqlDbType.Int, DossierID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@JobCo_2", SqlDbType.NVarChar, JobCo, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Jobtxt_3", SqlDbType.NVarChar, Jobtxt, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AssureID_4", SqlDbType.Int, AssureID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Sallary_5", SqlDbType.Float, Sallary, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BeginDate_6", SqlDbType.Char, BeginDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EndDate_7", SqlDbType.Char, EndDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DaySum_8", SqlDbType.Int, DaySum, ParameterDirection.Input)
        Persist1.Sp_AddParam("@RelatedID_9", SqlDbType.Int, Related, ParameterDirection.Input)
        Persist1.Sp_Exe("update_tbHR_Dossier", ConString, True)
    End Function

    Friend Function InsertDossierInfo(ByVal PersonCode As Integer, ByVal JobCo As String, ByVal Jobtxt As String, ByVal AssureID As Integer, ByVal Sallary As Double, ByVal BeginDate As String, ByVal EndDate As String, ByVal DaySum As Integer, ByVal Related As Integer, ByVal PersonID As Integer)
        Persist1.Sp_AddParam("@PersonCode_1", SqlDbType.Int, PersonCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@JobCo_2", SqlDbType.NVarChar, JobCo, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Jobtxt_3", SqlDbType.NVarChar, Jobtxt, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AssureID_4", SqlDbType.Int, AssureID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Sallary_5", SqlDbType.Float, Sallary, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BeginDate_6", SqlDbType.Char, BeginDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EndDate_7", SqlDbType.Char, EndDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DaySum_8", SqlDbType.Int, DaySum, ParameterDirection.Input)
        Persist1.Sp_AddParam("@RelatedID_9", SqlDbType.Int, Related, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonID_10", SqlDbType.Int, PersonID, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Dossier", ConString, True)
    End Function

    Friend Function DeleteDossierInfo(ByVal DossierID As Integer)
        Persist1.Sp_AddParam("@DossierID_1", SqlDbType.Int, DossierID, ParameterDirection.Input)
        Persist1.Sp_Exe("delete_tbHR_Dossier", ConString, True)
    End Function

    Friend Function GetDossierInfo(ByVal PersonCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_Dossier where PersonCode = " & PersonCode & ""
        GetDossierInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetRelatedInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_Related"
        GetRelatedInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function
End Class
