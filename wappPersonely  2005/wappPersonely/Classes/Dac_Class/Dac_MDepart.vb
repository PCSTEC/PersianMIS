Public Class Dac_MDepart
    Friend Function GetDepartTypeInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_DepartType"
        GetDepartTypeInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetSafSetadInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_SafSet order by SafSetadTxt"
        GetSafSetadInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetDepartKindInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_DepartKind order by DepartKindText"
        GetDepartKindInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetDepartInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_Depart ORDER BY DepartName"
        GetDepartInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetUpperIDInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "SELECT DepartID, DepartCode FROM  VwHR_DepartTreeview"
        GetUpperIDInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetChildDep(ByVal UpperCode As String) As DataTable
        SqlStr = "SELECT * FROM tbHR_Depart WHERE (UpperCode = N'" & UpperCode & "')"
        GetChildDep = Persist1.GetDataTable(ConString, SqlStr)
    End Function

    Friend Function GetUpperInfo(ByVal UpperCode As String) As DataTable
        Dim sqlstr As String
        sqlstr = _
                     "SELECT     * " & _
                     "FROM         tbHR_Depart " & _
                     "WHERE     (Active = 1) AND (UpperCode = '" & UpperCode & "')"
        GetUpperInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function
 
    Friend Function GettbHR_DepartInfo(ByVal DepartCode As String) As DataTable
        Dim sqlstr As String
        sqlstr = _
              "SELECT     * " & _
              "FROM         dbo.tbHR_Depart " & _
              "WHERE     (DepartCode ='" & DepartCode & "')"
        GettbHR_DepartInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GetDepartTreeviewInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from VwHR_DepartTreeview"
        GetDepartTreeviewInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GettbHRDepartNameContraction() As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_DepartNameContraction ORDER BY DepartName"
        GettbHRDepartNameContraction = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Function GettbHRDepartNameContraction(ByVal DepartID As Integer) As DataTable
        Dim sqlstr As String
        sqlstr = "select * from tbHR_DepartNameContraction  where (DepartID ='" & DepartID & "') ORDER BY DepartName"
        GettbHRDepartNameContraction = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Sub UpdateActive(ByVal DepartCode As String, ByVal Active As Boolean)
        Persist1.Sp_AddParam("@DepartCode_1", SqlDbType.NVarChar, DepartCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_2", SqlDbType.Bit, Active, ParameterDirection.Input)
        Persist1.Sp_Exe("Update_ActivetbHR_Depart", ConString, True)
        Persist1.ClearParameter()
    End Sub

    Friend Sub UpdateChildActive(ByVal DepartCode As String, ByVal Active As Boolean)
        Persist1.Sp_AddParam("@DepartCode_1", SqlDbType.NVarChar, DepartCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_2", SqlDbType.Bit, Active, ParameterDirection.Input)
        Persist1.Sp_Exe("update_ChildActivetbHR_Depart", ConString, True)
        Persist1.ClearParameter()
    End Sub

    Friend Sub InsertNode(ByVal DepartCode As String, ByVal DepartName As String, ByVal UpperCode As String, ByVal DepartTypeID As Integer, ByVal Active As Boolean, ByVal Independent As Integer, ByVal MDepartCode As String, ByVal SafSetadID As Integer, ByVal DepartKindID As Integer)
        Persist1.Sp_AddParam("@DepartCode_1", SqlDbType.NVarChar, DepartCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DepartName_2", SqlDbType.NVarChar, DepartName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@UpperCode_3", SqlDbType.NVarChar, UpperCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DepartTypeID_4 ", SqlDbType.SmallInt, DepartTypeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_5", SqlDbType.Bit, Active, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Independent_6", SqlDbType.SmallInt, Independent, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MDepartCode_7", SqlDbType.NVarChar, MDepartCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@SafSetadID_8", SqlDbType.Int, SafSetadID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DepartKindID_9", SqlDbType.Int, DepartKindID, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Depart", ConString, True)
    End Sub

    Friend Sub UpdateChangeNode(ByVal DepartID As Integer, ByVal DepartName As String, ByVal DepartTypeID As Integer)
        Persist1.Sp_AddParam("@DepartID_1 ", SqlDbType.Int, DepartID, ParameterDirection.Input)
        'Persist1.Sp_AddParam("@DepCode_2", SqlDbType.NVarChar, DepCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DepartName_3", SqlDbType.NVarChar, DepartName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DepartTypeID_4", SqlDbType.SmallInt, DepartTypeID, ParameterDirection.Input)
        Persist1.Sp_Exe("update_tbHR_Depart", ConString, True)
        Persist1.ClearParameter()
    End Sub

    Friend Sub UpdateUpperID(ByVal DepartID As String, ByVal UpperCode As String)
        Persist1.Sp_AddParam("@DepartID_1", SqlDbType.NVarChar, DepartID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@UpperCode_2", SqlDbType.NVarChar, UpperCode, ParameterDirection.Input)
        Persist1.Sp_Exe("Update_UppertbHR_Depart", ConString, True)
        Persist1.ClearParameter()
    End Sub

    Friend Sub UpdateIndependent(ByVal DepartID As Integer, ByVal Independent As Integer)
        Persist1.Sp_AddParam("@DepartID_1", SqlDbType.Int, DepartID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Independent_2", SqlDbType.SmallInt, Independent, ParameterDirection.Input)
        Persist1.Sp_Exe("update_IndependenttbHR_Depart", ConString, True)
        Persist1.ClearParameter()
    End Sub

    Friend Sub inserttbHRDepartNameContraction(ByVal UpperID As Integer, ByVal UpperCode As String, ByVal DepartName As String, ByVal DepartContractionName As String)
        Persist1.Sp_AddParam("@DepartID_1", SqlDbType.Int, UpperID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@UpperCode_2", SqlDbType.Char, UpperCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DepartName_3", SqlDbType.NVarChar, DepartName, ParameterDirection.Input)
        Persist1.Sp_AddParam("@DepartContractionName_4", SqlDbType.Char, DepartContractionName, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_DepartNameContraction", ConString, True)
    End Sub

    Friend Function GetMDepartInfo() As DataTable
        Dim sqlstr As String
        sqlstr = "select * From VwHR_MDepart"
        GetMDepartInfo = Persist1.GetDataTable(ConString, sqlstr)
    End Function

    Friend Sub insert_tbHR_PassWordMdepart(ByVal MdepartCode As String, ByVal Password As String, ByVal MDepartManagerID As Integer, ByVal MdepartID As Integer)
        Persist1.Sp_AddParam("@MdepartCode_1", SqlDbType.Char, MdepartCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Password_2", SqlDbType.VarChar, Password, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MDepartManagerID_3", SqlDbType.Int, MDepartManagerID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@MdepartID_4", SqlDbType.Int, MdepartID, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_PassWordMdepart", ConString, True)
    End Sub

End Class
