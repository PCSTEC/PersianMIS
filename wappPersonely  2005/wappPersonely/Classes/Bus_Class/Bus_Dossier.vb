Public Class Bus_Dossier
    Dim Dac_Dossier1 As New Dac_Dossier

    Friend Sub InsertDossierInfo(ByVal PersonCode As Integer, ByVal JobCo As String, ByVal Jobtxt As String, ByVal AssureID As Integer, ByVal Sallary As Double, ByVal BeginDate As String, ByVal EndDate As String, ByVal DaySum As Integer, ByVal Related As Integer, ByVal PersonID As Integer)
        Dac_Dossier1.InsertDossierInfo(PersonCode, JobCo, Jobtxt, AssureID, Sallary, BeginDate, EndDate, DaySum, Related, PersonID)
    End Sub

    Friend Sub DeleteDossierInfo(ByVal DossierID As Integer)
        Dac_Dossier1.DeleteDossierInfo(DossierID)
    End Sub

    Friend Sub UpdateDossierIfo(ByVal DossierID As Integer, ByVal JobCo As String, ByVal Jobtxt As String, ByVal AssureTypeID As Integer, ByVal Sallary As Double, ByVal BeginDate As String, ByVal EndDate As String, ByVal DaySum As Integer, ByVal Related As Integer)
        Dac_Dossier1.UpdateDossierIfo(DossierID, JobCo, Jobtxt, AssureTypeID, Sallary, BeginDate, EndDate, DaySum, Related)
    End Sub

    Friend Function GetDossierInfo(ByVal PersonCode As Integer) As DataTable
        GetDossierInfo = Dac_Dossier1.GetDossierInfo(PersonCode)
    End Function

    Friend Function GetRelatedInfo() As DataTable
        GetRelatedInfo = Dac_Dossier1.GetRelatedInfo()
    End Function

End Class
