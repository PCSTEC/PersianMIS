Public Class Dac_Post

    Friend Function GetPostActiveInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_Post where (Active = 1)"
        GetPostActiveInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetPostInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_Post where (Active = 1) ORDER BY Posttxt"
        GetPostInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetPostTypeIDInfo(ByVal PostTypeCode As Integer, ByVal DepartCode As String) As DataTable
        Dim sqlstr As String
        sqlstr = "SELECT PostTypeID, PostType FROM VwHR_PostGridView WHERE (PostTypeCode = " & PostTypeCode & ")AND(DepartCode = '" & DepartCode & "')"
        GetPostTypeIDInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetPostCodeInfo(ByVal PostCode As String) As DataTable
        Dim sqlstr As String
        sqlstr = _
                   "SELECT     * " & _
                   "FROM         tbHR_Employ " & _
                   "WHERE     (Active = 1) AND (PostCode = '" & PostCode & "')"
        GetPostCodeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetActivePostEmployeeDepartInfo(ByVal DepartCode As String) As DataTable
        Dim sqlstr As String
        sqlstr = "SELECT * FROM VwHR_ActivePostEmployeeDepart where (DepartCode ='" & DepartCode & "' ) or (MDepartCode ='" & DepartCode & "')"
        GetActivePostEmployeeDepartInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetActivePostDepartInfo(ByVal PostCode As String) As DataTable
        Dim sqlstr As String
        sqlstr = "SELECT * FROM VwHR_ActivePostEmployeeDepart where (PostCode ='" & PostCode & "')"
        GetActivePostDepartInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Sub InsertPost(ByVal PostCode As String, ByVal DepartID As Integer, ByVal PostTypeID As Integer, ByVal PostTypeCode As Integer, ByVal Posttxt As String, ByVal Active As Boolean, ByVal DepartCode As String)
        Persist1.Sp_AddParam("@PostCode_1", SqlDbType.NVarChar, PostCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DepartID_2", SqlDbType.Int, DepartID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PostTypeID_3", SqlDbType.Int, PostTypeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PostTypeCode_4", SqlDbType.Int, PostTypeCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Posttxt_5", SqlDbType.NVarChar, Posttxt, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_6", SqlDbType.Bit, Active, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DepartCode_7", SqlDbType.NVarChar, DepartCode, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Post", ConString, True)
        Persist1.ClearParameter()
    End Sub

    Friend Function GetPostTypeInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * , (CAST(PostTypeCode AS nvarchar) + N'-' + PostType) as postTitle from tbHR_PostType ORDER BY PostType"
        GetPostTypeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Sub UpdateChangePost(ByVal PostID As Integer, ByVal PostTypeID As Integer, ByVal PostTypeCode As Integer, ByVal Posttxt As String)
        Persist1.Sp_AddParam("@PostID_1", SqlDbType.Int, PostID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PostTypeID_2", SqlDbType.Int, PostTypeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PostTypeCode_3", SqlDbType.Int, PostTypeCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Posttxt_3", SqlDbType.NVarChar, Posttxt, ParameterDirection.Input)
        Persist1.Sp_Exe("update_tbHR_Post", ConString, True)
        Persist1.ClearParameter()
    End Sub

    Friend Sub UpdateActivePost(ByVal PostCode As String, ByVal Active As Boolean)
        Persist1.Sp_AddParam("@PostCode_1", SqlDbType.NVarChar, PostCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_2", SqlDbType.Bit, Active, ParameterDirection.Input)
        Persist1.Sp_Exe("update_ActivetbHR_Post", ConString, True)
        Persist1.ClearParameter()
    End Sub

    Friend Function GetPostGridViewInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_PostGridView"
        'where DepartCode = " & DepartCode & "
        'ByVal DepartCode As String
        GetPostGridViewInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

End Class
