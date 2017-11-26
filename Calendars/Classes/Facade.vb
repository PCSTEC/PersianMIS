Public Class Facade
    Public Function GetDayStatus(ByVal MDate As String, ByVal MDepartID As String) As Integer
        Dim DayStatus1 As New DayStatus
        Return DayStatus1.GetDayStatus(MDate, MDepartID, strConnection)
    End Function
    Public Function GetDayCount(ByVal DateDown As String, ByVal DateUp As String, ByVal DaySt As DayState) As Integer
        Dim Calendar1 As New Calendar.Calendar
        Return Calendar1.GetDayCount(DateDown, DateUp, DaySt)
    End Function

    Public Function GetDayMonthCount(ByVal MyDate As String, ByVal DaySt As DayState) As Integer
        Dim Calendar1 As New Calendar.Calendar
        Return Calendar1.GetDayMonthCount(MyDate, DaySt)
    End Function
End Class
