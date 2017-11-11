Public Class Dac_Training

    Friend Function DeleteTrainingInfo(ByVal TrainingID As Integer)
        Persist1.Sp_AddParam("@TrainingID_1", SqlDbType.Int, TrainingID, ParameterDirection.Input)
        Persist1.Sp_Exe("delete_tbHR_Training", ConString, True)
    End Function

    Friend Function InsertTrainingInfo(ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal CourcePlace As String, ByVal CourceName As String, ByVal CityID As Integer, ByVal CityCode As Integer, ByVal BeginDate As String, ByVal EndDate As String, ByVal SumTime As String, ByVal Average As String, ByVal CourseID As Integer, ByVal CourcePlaceID As Integer)
        Persist1.Sp_AddParam("@PersonID_1", SqlDbType.Int, PersonID, ParameterDirection.Input)
        Persist1.Sp_AddParam("PersonCode_2", SqlDbType.Int, PersonCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CourcePlace_3", SqlDbType.NVarChar, CourcePlace, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CourceName_4", SqlDbType.NVarChar, CourceName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CityID_5", SqlDbType.Int, CityID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CityCode_6", SqlDbType.Int, CityCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BeginDate_7", SqlDbType.Char, BeginDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EndDate_8", SqlDbType.Char, EndDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@SumTime_9", SqlDbType.NVarChar, SumTime, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Average_10", SqlDbType.NVarChar, Average, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CourseID_11", SqlDbType.Int, CourseID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CourcePlaceID_12", SqlDbType.Int, CourcePlaceID, ParameterDirection.Input)

        Persist1.Sp_Exe("insert_tbHR_Training", ConString, True)
    End Function

    Friend Function UpdateTrainingIfo(ByVal TrainingID As Integer, ByVal CourcePlace As String, ByVal CourceName As String, ByVal CityID As Integer, ByVal CityCode As Integer, ByVal BeginDate As String, ByVal EndDate As String, ByVal SumTime As String, ByVal Average As String, ByVal CourseID As Integer, ByVal CourcePlaceID As Integer)
        Persist1.Sp_AddParam("@TrainingID_1", SqlDbType.Int, TrainingID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CourcePlace_2", SqlDbType.NVarChar, CourcePlace, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CourceName_3", SqlDbType.NVarChar, CourceName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CityID_4", SqlDbType.Int, CityID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CityCode_5", SqlDbType.Int, CityCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@BeginDate_6", SqlDbType.Char, BeginDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EndDate_7", SqlDbType.NVarChar, EndDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@SumTime_8", SqlDbType.NVarChar, SumTime, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Average_9", SqlDbType.NVarChar, Average, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CourseID_10", SqlDbType.Int, CourseID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CourcePlaceID_11", SqlDbType.Int, CourcePlaceID, ParameterDirection.Input)

        Persist1.Sp_Exe("update_tbHR_Training", ConString, True)
    End Function

    Friend Function GetTrainingIfo(ByVal PersonCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_TrainingInfo where PersonCode = " & PersonCode & _
            " Union " & _
    " SELECT    Training.dbo.tbTRNCrsLocation.LocationCrsID, Training.dbo.tbTRNCPPerson.PersonID AS Expr1, Training.dbo.tbTRNCPPerson.PersonID,  " & _
            "                      Personely.dbo.tbHR_Person.FirstName + N' ' + Personely.dbo.tbHR_Person.LastName AS name, Training.dbo.tbTRNInstitute.InstituteName,  " & _
            "                      Training.dbo.tbTRNCourse.CourseName, '' AS citycode, '' AS citytxt, Training.dbo.tbTRNCrsLocation.BeginDate, Training.dbo.tbTRNCrsLocation.EndDate, Training.dbo.tbTRNCrsLocation.CycleTime, Training.dbo.tbTRNScoreList.ScoreTxt ,  " & _
            "                      1 AS cityID, 1 AS TypeID " & _
            " FROM         Training.dbo.tbTRNCPPerson INNER JOIN " & _
            "                      Training.dbo.tbTRNCrsLocation ON Training.dbo.tbTRNCPPerson.LocationCrsID = Training.dbo.tbTRNCrsLocation.LocationCrsID INNER JOIN " & _
            "                      Training.dbo.tbTRNCourse ON Training.dbo.tbTRNCrsLocation.CourseID = Training.dbo.tbTRNCourse.CourseID INNER JOIN " & _
            "                      Training.dbo.tbTRNInstitute ON Training.dbo.tbTRNCrsLocation.InstituteID = Training.dbo.tbTRNInstitute.InstituteID INNER JOIN " & _
            "                      Personely.dbo.tbHR_Person ON Training.dbo.tbTRNCPPerson.PersonID = Personely.dbo.tbHR_Person.PersonCode INNER JOIN " & _
            "                      Training.dbo.tbTRNScoreList ON Training.dbo.tbTRNCPPerson.ScoreID = Training.dbo.tbTRNScoreList.ScoreID " & _
            "GROUP BY Training.dbo.tbTRNCPPerson.PersonID, Training.dbo.tbTRNCourse.CourseName, Training.dbo.tbTRNInstitute.InstituteName, Training.dbo.tbTRNCrsLocation.LocationCrsID,  " & _
            "                      Personely.dbo.tbHR_Person.FirstName + N' ' + Personely.dbo.tbHR_Person.LastName, Training.dbo.tbTRNCrsLocation.BeginDate,  " & _
            "                      Training.dbo.tbTRNCrsLocation.EndDate ,Training.dbo.tbTRNCrsLocation.CycleTime, Training.dbo.tbTRNScoreList.ScoreTxt " & _
            "HAVING      (Training.dbo.tbTRNCPPerson.PersonID = " & PersonCode & ")"

        GetTrainingIfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

End Class
