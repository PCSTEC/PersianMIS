Public Class Bus_Parakanesh
    Dim Dac_Parakanesh1 As New Dac_Parakanesh

    Friend Sub insert_tbHR_Parakanesh(ByVal DepartID As Integer, ByVal DepartCode As String, ByVal SafSetadID As Integer, ByVal MDepartName As String, ByVal CountDoctoraSV As Integer, ByVal CountFogLisancSV As Integer, ByVal CountLisancSV As Integer, ByVal CountFogDiplomSV As Integer, ByVal CountDiplomSV As Integer, ByVal CountZirDiplomSV As Integer, ByVal CountDoctoraTV As Integer, ByVal CountFogLisancTV As Integer, ByVal CountLisancTV As Integer, ByVal CountFogDiplomTV As Integer, ByVal CountDiplomTV As Integer, ByVal CountZirDiplomTV As Integer, ByVal CountMan As Integer, ByVal CountWoman As Integer, ByVal AvgDepartAge As Integer, ByVal CountPersonSafTafkik As Integer, ByVal CountPersonSetadTafkik As Integer, ByVal ParakaneshYear As Integer, ByVal ParakaneshMounth As Integer, ByVal CountPersonTV As Integer, ByVal CountPersonSV As Integer, ByVal EngageType As Integer)
        Dac_Parakanesh1.insert_tbHR_Parakanesh(DepartID, DepartCode, SafSetadID, MDepartName, CountDoctoraSV, CountFogLisancSV, CountLisancSV, CountFogDiplomSV, CountDiplomSV, CountZirDiplomSV, CountDoctoraTV, CountFogLisancTV, CountLisancTV, CountFogDiplomTV, CountDiplomTV, CountZirDiplomTV, CountMan, CountWoman, AvgDepartAge, CountPersonSafTafkik, CountPersonSetadTafkik, ParakaneshYear, ParakaneshMounth, CountPersonTV, CountPersonSV, EngageType)
    End Sub

    Friend Function delete_tbHRParakanesh(ByVal ParakaneshID As Integer)
        Dac_Parakanesh1.delete_tbHRParakanesh(ParakaneshID)
    End Function

End Class
