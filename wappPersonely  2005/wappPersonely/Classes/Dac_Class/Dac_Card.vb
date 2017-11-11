Public Class Dac_Card

    Friend Sub InsertCardInfo(ByVal PersonCode As Integer, ByVal CardTypeID As Integer, ByVal CardNumber As Integer, ByVal CardGetDate As String, ByVal CardBackDate As String, ByVal PersonID As Integer)
        Persist1.Sp_AddParam("@PersonCode_1", SqlDbType.Int, PersonCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CardTypeID_2", SqlDbType.SmallInt, CardTypeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CardNumber_3", SqlDbType.SmallInt, CardNumber, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CardGetDate_4", SqlDbType.Char, CardGetDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CardBackDate_5", SqlDbType.Char, CardBackDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonID_6", SqlDbType.Int, PersonID, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Card", ConString, True)
    End Sub

    Friend Function CardTypeInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_CardType"
        CardTypeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

End Class
