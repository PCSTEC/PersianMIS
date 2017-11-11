Public Class Dac_Meed

    Friend Sub InsertMeedInfo(ByVal PersonCode As Integer, ByVal MeedReason As String, ByVal MeedTypeID As Integer, ByVal MeedDate As String, ByVal MeedEndDate As String, ByVal MeedLetterNo As Integer, ByVal PersonID As Integer)
        Persist1.Sp_AddParam("@PersonCode_1", SqlDbType.Int, PersonCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MeedReason_2", SqlDbType.NVarChar, MeedReason, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MeedTypeID_3", SqlDbType.SmallInt, MeedTypeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MeedDate_4", SqlDbType.Char, MeedDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MeedLetterNo_5", SqlDbType.Int, MeedLetterNo, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonID_6", SqlDbType.Int, PersonID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MeedEndDate_7", SqlDbType.Char, MeedEndDate, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Meed", ConString, True)
    End Sub

    Friend Sub UpdateMeedInfo(ByVal MeedID As Integer, ByVal MeedReason As String, ByVal MeedTypeID As Integer, ByVal MeedDate As String, ByVal MeedLetterNo As Integer)
        Persist1.Sp_AddParam("@MeedID_1", SqlDbType.Int, MeedID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MeedReason_2", SqlDbType.NVarChar, MeedReason, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MeedTypeID_3", SqlDbType.SmallInt, MeedTypeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MeedDate_4", SqlDbType.Char, MeedDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MeedLetterNo_5", SqlDbType.Int, MeedLetterNo, ParameterDirection.Input)
        Persist1.Sp_Exe("update_tbHR_Meed", ConString, True)
    End Sub

    Friend Function MeedTypeInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_MeedType"
        MeedTypeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Sub DeleteMeedInfo(ByVal MeedID As Integer)
        Persist1.Sp_AddParam("@MeedID_1", SqlDbType.Int, MeedID, ParameterDirection.Input)
        Persist1.Sp_Exe("delete_tbHR_Meed", ConString, True)
    End Sub

    Friend Function MeedInfo(ByVal PersonCode As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_MeedInfo where PersonCode = " & PersonCode & ""
        MeedInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function
End Class
