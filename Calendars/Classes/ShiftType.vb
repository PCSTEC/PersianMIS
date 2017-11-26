Public Class ShiftType
    Private mShiftTypeID As Integer
    Private mShiftType As String

    Public Property ShiftTypeID() As Integer
        Get
            Return mShiftTypeID
        End Get
        Set(ByVal Value As Integer)
            mShiftTypeID = Value
        End Set
    End Property

    Public Property ShiftType() As String
        Get
            Return mShiftType
        End Get
        Set(ByVal Value As String)
            mShiftType = Value
        End Set
    End Property

    Public Function GetShiftTypeInfo() As DataTable
        Dim sqlstr1 As String
        Dim dt1 As DataTable

        sqlstr1 = "Select TypeID as ShiftTypeID, TypeName as ShiftType " &
            "FROM HumanResource..tbRCL_ShiftType " &
            "WHERE 1=1 " &
            IIf(nz1.NZ(Me.ShiftTypeID, 0) = 0, "", " AND TypeID=" & Me.ShiftTypeID) &
            IIf(nz1.NZ(Me.ShiftType, "") = "", "", " AND TypeName='" & Me.ShiftType & "'")

        dt1 = ps1.GetDataTable(strConnection, sqlstr1)
        GetShiftTypeInfo = dt1

        If dt1.DefaultView.Count > 0 Then
            Me.ShiftTypeID = nz1.NZ(dt1.DefaultView.Item(0).Item("ShiftTypeID"), "")
            Me.ShiftType = nz1.NZ(dt1.DefaultView.Item(0).Item("ShiftType"), "")
        End If
    End Function
End Class
