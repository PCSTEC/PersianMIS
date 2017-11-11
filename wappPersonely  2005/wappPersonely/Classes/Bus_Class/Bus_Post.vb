Public Class Bus_Post
    Dim Dac_Post1 As New Dac_Post

    Friend Function GetPostCodeInfo(ByVal PostCode As String) As DataTable
        GetPostCodeInfo = Dac_Post1.GetPostCodeInfo(PostCode)
    End Function

    Friend Function GetPostGridViewInfo() As DataTable
        GetPostGridViewInfo = Dac_Post1.GetPostGridViewInfo()
    End Function

    Friend Function GetPostTypeIDInfo(ByVal PostTypeCode As Integer, ByVal DepartCode As String) As DataTable
        GetPostTypeIDInfo = Dac_Post1.GetPostTypeIDInfo(PostTypeCode, DepartCode)
    End Function

    Friend Function GetActivePostEmployeeDepartInfo(ByVal DepartCode As String) As DataTable
        GetActivePostEmployeeDepartInfo = Dac_Post1.GetActivePostEmployeeDepartInfo(DepartCode)
    End Function

    Friend Function GetActivePostDepartInfo(ByVal PostCode As String) As DataTable
        GetActivePostDepartInfo = Dac_Post1.GetActivePostDepartInfo(PostCode)
    End Function

    Friend Function GetPostActiveInfo() As DataTable
        GetPostActiveInfo = Dac_Post1.GetPostActiveInfo()
    End Function

    Friend Function GetPostInfo() As DataTable
        GetPostInfo = Dac_Post1.GetPostInfo
    End Function

    Friend Function GetPostTypeInfo() As DataTable
        GetPostTypeInfo = Dac_Post1.GetPostTypeInfo
    End Function

    Friend Sub UpdateActivePost(ByVal PostCode As String, ByVal Active As Boolean)
        Dac_Post1.UpdateActivePost(PostCode, Active)
    End Sub

    Friend Sub InsertPost(ByVal PostCode As String, ByVal DepartID As Integer, ByVal PostTypeID As Integer, ByVal PostTypeCode As Integer, ByVal Posttxt As String, ByVal Active As Boolean, ByVal DepartCode As String)
        Dac_Post1.InsertPost(PostCode, DepartID, PostTypeID, PostTypeCode, Posttxt, Active, DepartCode)
    End Sub

    Friend Sub UpdateChangePost(ByVal PostID As Integer, ByVal PostTypeID As Integer, ByVal PostTypeCode As Integer, ByVal Posttxt As String)
        Dac_Post1.UpdateChangePost(PostID, PostTypeID, PostTypeCode, Posttxt)
    End Sub
End Class
