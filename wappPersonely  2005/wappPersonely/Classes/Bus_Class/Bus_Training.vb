Public Class Bus_Training
    Dim Dac_Training1 As New Dac_Training

    Friend Sub InsertTrainingInfo(ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal CourcePlace As String, ByVal CourceName As String, ByVal CityID As Integer, ByVal CityCode As Integer, ByVal BeginDate As String, ByVal EndDate As String, ByVal SumTime As String, ByVal Average As String, ByVal CourseID As Integer, ByVal CourcePlaceID As Integer)
        Dac_Training1.InsertTrainingInfo(PersonID, PersonCode, CourcePlace, CourceName, CityID, CityCode, BeginDate, EndDate, SumTime, Average, CourseID, CourcePlaceID)
    End Sub

    Friend Sub UpdateTrainingIfo(ByVal TrainingID As Integer, ByVal CourcePlace As String, ByVal CourceName As String, ByVal CityID As Integer, ByVal CityCode As Integer, ByVal BeginDate As String, ByVal EndDate As String, ByVal SumTime As String, ByVal Average As String, ByVal CourseID As Integer, ByVal CourcePlaceID As Integer)
        Dac_Training1.UpdateTrainingIfo(TrainingID, CourcePlace, CourceName, CityID, CityCode, BeginDate, EndDate, SumTime, Average, CourseID, CourcePlaceID)
    End Sub

    Friend Sub DeleteTrainingInfo(ByVal TrainingID As Integer)
        Dac_Training1.DeleteTrainingInfo(TrainingID)
    End Sub

    Friend Function GetTrainingIfo(ByVal PersonCode As Integer) As DataTable
        GetTrainingIfo = Dac_Training1.GetTrainingIfo(PersonCode)
    End Function
End Class
