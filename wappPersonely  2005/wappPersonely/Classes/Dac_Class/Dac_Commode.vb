
Public Class Dac_Commode

    Friend Sub DeleteCommodeNumber(ByVal CommodeNumberID As Integer)
        Persist1.Sp_AddParam("@CommodeNumberID_1", SqlDbType.Int, CommodeNumberID, ParameterDirection.Input)
        Persist1.Sp_Exe("delete_tbHR_CommodeNumber", ConString, True)
    End Sub

    Friend Function GetPersonJari() As DataTable
        SqlStr = "SELECT  PersonID, PersonCode, FirstName, LastName, DepartCode, DepartName, MDepartName  FROM  VwHR_PersonJariForCommode"
        GetPersonJari = Persist1.GetDataTable(ConString, SqlStr)
    End Function

    Friend Function GetCommodeNumbers() As DataTable
        SqlStr = "SELECT  CommodeNumberID, CommodeNumber FROM dbo.tbHR_CommodeNumber WHERE (CommodeNumberID NOT IN  (SELECT CommodeNumberID FROM   tbHR_Commode WHERE     Active = 1)) ORDER BY CommodeNumberID"
        GetCommodeNumbers = Persist1.GetDataTable(ConString, SqlStr)
    End Function

    Friend Sub InsertCommodeNumber(ByVal CommodeNumber As Integer)
        Persist1.Sp_AddParam("@CommodeNumber_1 ", SqlDbType.Int, CommodeNumber, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_CommodeNumber", ConString, True)
    End Sub

    Friend Function PersonCommodeDaarInfo() As DataTable
        SqlStr = "Select * from VwHR_PersonAndCommodes WHERE  (CommodeActive = 1) ORDER BY CommodeID DESC"
        PersonCommodeDaarInfo = Persist1.GetDataTable(ConString, SqlStr)
    End Function

    Friend Sub inserttbHRCommode(ByVal CommodeNumberID As Integer, ByVal CommodeNumber As Integer, ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal TahvilDate As String, ByVal Active As Boolean)
        Persist1.Sp_AddParam("@CommodeNumberID_1", SqlDbType.Int, CommodeNumberID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CommodeNumber_2", SqlDbType.Int, CommodeNumber, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonID_3", SqlDbType.Int, PersonID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonCode_4", SqlDbType.Int, PersonCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@TahvilDate_5", SqlDbType.Char, TahvilDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_6", SqlDbType.Bit, Active, ParameterDirection.Input)
        Persist1.Sp_Exe("insert_tbHR_Commode", ConString, True)
    End Sub

    Friend Sub deletetbHRCommode(ByVal CommodeID As Integer, ByVal Active As Boolean)
        Persist1.Sp_AddParam("@CommodeID_1", SqlDbType.Int, CommodeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_2", SqlDbType.Bit, Active, ParameterDirection.Input)
        Persist1.Sp_Exe("update_tbHR_CommodeActive", ConString, True)
    End Sub

    Friend Sub updatetbHRCommode(ByVal CommodeID As Integer, ByVal CommodeNumberID As Integer, ByVal CommodeNumber As Integer, ByVal PersonID As Integer, ByVal PersonCode As Integer, ByVal TahvilDate As String, ByVal Active As Boolean)
        Persist1.Sp_AddParam("@CommodeID_1", SqlDbType.Int, CommodeID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CommodeNumberID_2", SqlDbType.Int, CommodeNumberID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@CommodeNumber_3", SqlDbType.Int, CommodeNumber, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonID_4", SqlDbType.Int, PersonID, ParameterDirection.Input)
        Persist1.Sp_AddParam("@PersonCode_5", SqlDbType.Int, PersonCode, ParameterDirection.Input)
        Persist1.Sp_AddParam("@TahvilDate_6", SqlDbType.Char, TahvilDate, ParameterDirection.Input)
        Persist1.Sp_AddParam("@Active_7", SqlDbType.Bit, Active, ParameterDirection.Input)
        Persist1.Sp_Exe("update_tbHR_Commode", ConString, True)
    End Sub

    Friend Function PersonMostaafi() As DataTable
        SqlStr = "SELECT *  FROM VwHR_PersonAndCommodes  WHERE(PersonActive = 0)"
        PersonMostaafi = Persist1.GetDataTable(ConString, SqlStr)
    End Function
End Class
