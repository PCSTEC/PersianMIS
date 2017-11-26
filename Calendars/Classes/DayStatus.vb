Public Class DayStatus
    Private mDayStatusID As Int16
    Private mDayStatusName As String

    Public ReadOnly Property DayStatusID()
        Get
            Return mDayStatusID
        End Get

    End Property

    Public ReadOnly Property DayStatusName()
        Get
            Return mDayStatusName
        End Get
    End Property

    Friend Function GetDayStatus(ByVal DayStatusID As Int16, ByVal DayStateID As Int16)
        Dim dt1 As New DataTable
        'Dim ps1 As New Persistent.DataAccess.DataAccess
        Dim sqlstr As String = ""
        'sqlstr = "SELECT DayStateID,DayStateTxt FROM tbRCL_ShiftDayState WHERE DayStateID=" & IYear

        'CnnString = cnnStr

        Try
            GetDayStatus = ps1.GetDataTable(strConnection, sqlstr)
        Catch ex As Exception

        End Try
    End Function

    Public Function GetDayStatus(ByVal MDate As String, ByVal MDepartID As String, ByVal CnnStr As String) As Integer
        Dim dt1 As New DataTable
        Dim sqlstr As String = ""
        If MDepartID = "TT000" Then
            sqlstr = "SELECT CalTolidDayStatusID as DayStatusID,DayStatusName FROM HumanResource..tbRCL_Calendar_Machin INNER JOIN " &
                "HumanResource..tbRCL_CalendarDayStatus ON CalTolidDayStatusID=DayStatusID WHERE CalIraniDate='" & MDate & "'"
        Else
            sqlstr = "SELECT CalDayStatusID as DayStatusID,DayStatusName FROM HumanResource..tbRCL_Calendar_Machin INNER JOIN " &
                "HumanResource..tbRCL_CalendarDayStatus ON CalDayStatusID=DayStatusID WHERE CalIraniDate='" & MDate & "'"
        End If
        dt1 = ps1.GetDataTable(CnnStr, sqlstr)
        GetDayStatus = dt1.DefaultView.Item(0).Item("DayStatusID")
    End Function

    Public Function GetWorkDayNumber(ByVal StartDate As String, ByVal EndDate As String, ByVal MDepartID As String, ByVal CnnStr As String) As Integer
        Dim dt1 As New DataTable
        Dim sqlstr As String = ""
        If MDepartID = "TT000" Then
            sqlstr = "SELECT Count(CalID)as WorkDayCnt FROM HumanResource..tbRCL_Calendar_Machin " &
            "WHERE (CalIraniDate >='" & StartDate & "' AND CalIraniDate <='" & EndDate & "')AND(CalTolidDayStatusID=1)" 'ÊÚÏÇÏ ÑæÒ åÇí ßÇÑí ãíÇä Ïæ ÑæÒ ãæÑÏ äÙÑ ÏÑ æÇÍÏ ÊæáíÏ
        Else
            sqlstr = "SELECT Count(CalID)as WorkDayCnt FROM HumanResource..tbRCL_Calendar_Machin " &
            "WHERE (CalIraniDate >='" & StartDate & "' AND CalIraniDate <='" & EndDate & "')AND(CalDayStatusID=1)" 'ÊÚÏÇÏ ÑæÒ åÇí ßÇÑí ãíÇä Ïæ ÑæÒ ãæÑÏ äÙÑ
        End If
        dt1 = ps1.GetDataTable(CnnStr, sqlstr)
        GetWorkDayNumber = dt1.DefaultView.Item(0).Item("WorkDayCnt")
    End Function

End Class
