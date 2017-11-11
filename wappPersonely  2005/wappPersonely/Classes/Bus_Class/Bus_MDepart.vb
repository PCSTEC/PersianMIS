Public Class Bus_MDepart
    Dim Dac_MDepart1 As New Dac_MDepart
    Dim dt_Child As New DataTable
    Dim i As Integer
    Dim Timer1 As New Timer
    Public m As Integer
    Public Property SetTimer()
        Get

        End Get
        Set(ByVal value)
            m = 1
            AddHandler Timer1.Tick, AddressOf Timer1_Tick
        End Set
    End Property
    Friend Function GettbHRDepartNameContraction() As DataTable
        GettbHRDepartNameContraction = Dac_MDepart1.GettbHRDepartNameContraction
    End Function
    Friend Function GettbHRDepartNameContraction(ByVal DepID As Integer) As DataTable
        GettbHRDepartNameContraction = Dac_MDepart1.GettbHRDepartNameContraction(DepID)
    End Function
    Friend Function GetDepartTypeInfo() As DataTable
        GetDepartTypeInfo = Dac_MDepart1.GetDepartTypeInfo
    End Function
    Friend Function GetSafSetadInfo() As DataTable
        GetSafSetadInfo = Dac_MDepart1.GetSafSetadInfo
    End Function

    Friend Function GetDepartKindInfo() As DataTable
        GetDepartKindInfo = Dac_MDepart1.GetDepartKindInfo
    End Function

    Friend Function GetDepartInfo() As DataTable
        GetDepartInfo = Dac_MDepart1.GetDepartInfo
    End Function


    Friend Function GetUpperIDInfo() As DataTable
        GetUpperIDInfo = Dac_MDepart1.GetUpperIDInfo
    End Function


    Friend Function GetUpperInfo(ByVal UpperCode As String) As DataTable
        GetUpperInfo = Dac_MDepart1.GetUpperInfo(UpperCode)
    End Function

    Friend Function GettbHR_DepartInfo(ByVal DepartCode As String) As DataTable
        GettbHR_DepartInfo = Dac_MDepart1.GettbHR_DepartInfo(DepartCode)
    End Function

    Friend Function GetDepartTreeviewInfo() As DataTable
        GetDepartTreeviewInfo = Dac_MDepart1.GetDepartTreeviewInfo
    End Function

    Friend Sub UpdateActive(ByVal DepartCode As String, ByVal Active As Boolean)
        Dac_MDepart1.UpdateActive(DepartCode, Active)
    End Sub

    Friend Sub UpdateChildActive(ByVal DepartCode As String, ByVal Active As Boolean)
        Dac_MDepart1.UpdateChildActive(DepartCode, Active)
    End Sub

    Friend Sub InsertNode(ByVal DepartCode As String, ByVal DepartName As String, ByVal UpperCode As String, ByVal DepartTypeID As Integer, ByVal Active As Boolean, ByVal Independent As Integer, ByVal MDepartCode As String, ByVal SafSetadID As Integer, ByVal DepartKindID As Integer)
        Dac_MDepart1.InsertNode(DepartCode, DepartName, UpperCode, DepartTypeID, Active, Independent, MDepartCode, SafSetadID, DepartKindID)
    End Sub

    Friend Function UpdateChangeNode(ByVal DepartID As Integer, ByVal DepartName As String, ByVal DepartTypeID As Integer) As Boolean
        Dac_MDepart1.UpdateChangeNode(DepartID, DepartName, DepartTypeID)
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SqlStr = "update  tbHR_Depart set CreatDate='" & IraniDate1.StringDate(IraniDate1.GetIrani8DateStr_CurDate) + " " + TimeString & "' Where DepID='" & dt_Child.DefaultView.Item(i).Item("DepID") & "'"
        Persist1.GetDataAccess(SqlStr, 2, ConString)
    End Sub

    Friend Sub UpdateIndependent(ByVal DepartID As String, ByVal Independent As Integer)
        Dac_MDepart1.UpdateIndependent(DepartID, Independent)
    End Sub

    Friend Sub inserttbHRDepartNameContraction(ByVal DepartID As Integer, ByVal UpperCode As String, ByVal DepartName As String, ByVal DepartContractionName As String)
        Dac_MDepart1.inserttbHRDepartNameContraction(DepartID, UpperCode, DepartName, DepartContractionName)
    End Sub

    Friend Function GetMDepartInfo() As DataTable
        GetMDepartInfo = Dac_MDepart1.GetMDepartInfo()
    End Function

    Friend Sub insert_tbHR_PassWordMdepart(ByVal MdepartCode As String, ByVal Password As String, ByVal MDepartManagerID As Integer, ByVal MdepartID As Integer)
        Dac_MDepart1.insert_tbHR_PassWordMdepart(MdepartCode, Password, MDepartManagerID, MdepartID)
    End Sub
End Class
