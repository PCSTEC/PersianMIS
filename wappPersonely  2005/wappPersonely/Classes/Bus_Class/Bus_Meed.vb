Public Class Bus_Meed
    Dim Dac_Meed1 As New Dac_Meed

    Friend Sub InsertMeedInfo(ByVal PersonCode As Integer, ByVal MeedReason As String, ByVal MeedTypeID As Integer, ByVal MeedDate As String, ByVal MeedEndDate As String, ByVal MeedLetterNo As Integer, ByVal PersonID As Integer)
        Dac_Meed1.InsertMeedInfo(PersonCode, MeedReason, MeedTypeID, MeedDate, MeedEndDate, MeedLetterNo, PersonID)
    End Sub
    Friend Sub UpdateMeedInfo(ByVal MeedID As Integer, ByVal MeedReason As String, ByVal MeedTypeID As Integer, ByVal MeedDate As String, ByVal MeedLetterNo As Integer)
        Dac_Meed1.UpdateMeedInfo(MeedID, MeedReason, MeedTypeID, MeedDate, MeedLetterNo)
    End Sub

    Friend Function MeedTypeInfo() As DataTable
        MeedTypeInfo = Dac_Meed1.MeedTypeInfo
    End Function

    Friend Sub DeleteMeedInfo(ByVal MeedID As Integer)
        Dac_Meed1.DeleteMeedInfo(MeedID)
    End Sub

    Friend Function MeedInfo(ByVal PersonCode As Integer) As DataTable
        MeedInfo = Dac_Meed1.MeedInfo(PersonCode)
    End Function
End Class
