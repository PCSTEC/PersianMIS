
Public Class Bus_Commode
    Dim Dac_Commode1 As New Dac_Commode

    Public Sub DeleteCommodeNumber(ByVal CommodeNumberID As Integer)
        Dac_Commode1.DeleteCommodeNumber(CommodeNumberID)
    End Sub

    Public Function GetPersonJari() As DataTable
        GetPersonJari = Dac_Commode1.GetPersonJari()
    End Function

    Public Function GetCommodeNumbers() As DataTable
        GetCommodeNumbers = Dac_Commode1.GetCommodeNumbers
    End Function

    Friend Sub InsertCommodeNumber(ByVal CommodeNumber As Integer)
        Dac_Commode1.InsertCommodeNumber(CommodeNumber)
    End Sub

    Friend Function PersonCommodeDaarInfo() As DataTable
        PersonCommodeDaarInfo = Dac_Commode1.PersonCommodeDaarInfo()
    End Function

    Friend Sub inserttbHRCommode(ByVal CommodeNumberID As Integer, ByVal CommodeNumber As Integer, ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal TahvilDate As String, ByVal Active As Boolean)
        Dac_Commode1.inserttbHRCommode(CommodeNumberID, CommodeNumber, PersonID, PersonCode, TahvilDate, Active)
    End Sub

    Friend Sub deletetbHRCommode(ByVal CommodeID As Integer, ByVal Active As Boolean)
        Dac_Commode1.deletetbHRCommode(CommodeID, Active)
    End Sub

    Friend Sub updatetbHRCommode(ByVal CommodeID As Integer, ByVal CommodeNumberID As Integer, ByVal CommodeNumber As Integer, ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal TahvilDate As String, ByVal Active As Boolean)
        Dac_Commode1.updatetbHRCommode(CommodeID, CommodeNumberID, CommodeNumber, PersonID, PersonCode, TahvilDate, Active)
    End Sub

    Friend Function PersonMostaafi() As DataTable
        PersonMostaafi = Dac_Commode1.PersonMostaafi
    End Function
End Class
