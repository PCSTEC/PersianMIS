Public Class Dac_Parakanesh
    Friend Sub insert_tbHR_Parakanesh(ByVal DepartID As Integer, ByVal DepartCode As String, ByVal SafSetadID As Integer, ByVal MDepartName As String, ByVal CountDoctoraSV As Integer, ByVal CountFogLisancSV As Integer, ByVal CountLisancSV As Integer, ByVal CountFogDiplomSV As Integer, ByVal CountDiplomSV As Integer, ByVal CountZirDiplomSV As Integer, ByVal CountDoctoraTV As Integer, ByVal CountFogLisancTV As Integer, ByVal CountLisancTV As Integer, ByVal CountFogDiplomTV As Integer, ByVal CountDiplomTV As Integer, ByVal CountZirDiplomTV As Integer, ByVal CountMan As Integer, ByVal CountWoman As Integer, ByVal AvgDepartAge As Integer, ByVal CountPersonSafTafkik As Integer, ByVal CountPersonSetadTafkik As Integer, ByVal ParakaneshYear As Integer, ByVal ParakaneshMounth As Integer, ByVal CountPersonTV As Integer, ByVal CountPersonSV As Integer, ByVal EngageType As Integer)
        Persist1.Sp_AddParam("@DepartID_1", SqlDbType.Int, DepartID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DepartCode_2", SqlDbType.Char, DepartCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@SafSetadID_3", SqlDbType.Int, SafSetadID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MDepartName_4", SqlDbType.NVarChar, MDepartName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountDoctoraSV_5", SqlDbType.Int, CountDoctoraSV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountFogLisancSV_6", SqlDbType.Int, CountFogLisancSV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountLisancSV_7", SqlDbType.Int, CountLisancSV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountFogDiplomSV_8", SqlDbType.Int, CountFogDiplomSV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountDiplomSV_9", SqlDbType.Int, CountDiplomSV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountZirDiplomSV_10", SqlDbType.Int, CountZirDiplomSV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountDoctoraTV_11", SqlDbType.Int, CountDoctoraTV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountFogLisancTV_12", SqlDbType.Int, CountFogLisancTV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountLisancTV_13", SqlDbType.Int, CountLisancTV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountFogDiplomTV_14", SqlDbType.Int, CountFogDiplomTV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountDiplomTV_15", SqlDbType.Int, CountDiplomTV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountZirDiplomTV_16", SqlDbType.Int, CountZirDiplomTV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountMan_17", SqlDbType.Int, CountMan, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountWoman_18", SqlDbType.Int, CountWoman, ParameterDirection.Input)
        Persist1.Sp_AddParam("@AvgDepartAge_19", SqlDbType.Int, AvgDepartAge, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountPersonSafTafkik_20", SqlDbType.Int, CountPersonSafTafkik, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountPersonSetadTafkik_21", SqlDbType.Int, CountPersonSetadTafkik, ParameterDirection.Input)
        Persist1.Sp_AddParam("@ParakaneshYear_22", SqlDbType.Int, ParakaneshYear, ParameterDirection.Input)
        Persist1.Sp_AddParam("@ParakaneshMounth_23", SqlDbType.Int, ParakaneshMounth, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountPersonTV_24", SqlDbType.Int, CountPersonTV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CountPersonSV_25", SqlDbType.Int, CountPersonSV, ParameterDirection.Input)
        Persist1.Sp_AddParam("@EngageType_26", SqlDbType.Int, EngageType, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Parakanesh", ConString, True)
    End Sub

    Friend Function delete_tbHRParakanesh(ByVal ParakaneshID As Integer)
        Persist1.Sp_AddParam("@ParakaneshID_1", SqlDbType.Int, ParakaneshID, ParameterDirection.Input)
        Persist1.Sp_Exe("delete_tbHR_Parakanesh", ConString, True)
    End Function
End Class
