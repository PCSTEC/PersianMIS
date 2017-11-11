Public Class Bus_Card
    Dim Dac_Card1 As New Dac_Card

    Friend Sub InsertCardInfo(ByVal PersonCode As Integer, ByVal CardTypeID As Integer, ByVal CardNumber As Integer, ByVal CardGetDate As String, ByVal CardBackDate As String, ByVal PersonID As Integer)
        Dac_Card1.InsertCardInfo(PersonCode, CardTypeID, CardNumber, CardGetDate, CardBackDate, PersonID)
    End Sub

    Friend Function CardTypeInfo() As DataTable
        CardTypeInfo = Dac_Card1.CardTypeInfo()
    End Function
End Class
