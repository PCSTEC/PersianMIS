Imports System.ComponentModel.Win32Exception
Imports System.Windows.Forms
Public Class Ascribe
    Private mAscribeID As Int16
    Private mAscShiftProp As Shift
    Private mAscMDepartID As String
    Private mAscNetWorkTime As Int16
    Private mAscNetBreakTime As Int16
    Private mAscAllTime As Int16
    Private mAcsStateID As Int16
    Private mAscFromDate As String
    Private mAscToDate As String
    Private mAscInShiftMDID As Int16

    Public Property AscribeID() As Int16
        Get
            Return mAscribeID
        End Get
        Set(ByVal Value As Int16)
            mAscribeID = Value
        End Set
    End Property
    Public Property AscShiftProp() As Shift
        Get
            Return mAscShiftProp
        End Get
        Set(ByVal Value As Shift)
            mAscShiftProp = Value
        End Set
    End Property
    Public Property AscMDepartID() As String
        Get
            Return mAscMDepartID
        End Get
        Set(ByVal Value As String)
            mAscMDepartID = Value
        End Set
    End Property
    Public Property AscNetWorkTime() As Int16
        Get
            Return mAscNetWorkTime
        End Get
        Set(ByVal Value As Int16)
            mAscNetWorkTime = Value
        End Set
    End Property
    Public Property AscNetBreakTime() As Int16
        Get
            Return mAscNetBreakTime
        End Get
        Set(ByVal Value As Int16)
            mAscNetBreakTime = Value
        End Set
    End Property
    Public Property AscAllTime() As Int16
        Get
            Return mAscAllTime
        End Get
        Set(ByVal Value As Int16)
            mAscAllTime = Value
        End Set
    End Property
    Public Property AcsStateID() As Int16
        Get
            Return mAcsStateID
        End Get
        Set(ByVal Value As Int16)
            mAcsStateID = Value
        End Set
    End Property
    Public Property AscFromDate() As String
        Get
            Return mAscFromDate
        End Get
        Set(ByVal Value As String)
            mAscFromDate = Value
        End Set
    End Property
    Public Property AscToDate() As String
        Get
            Return mAscToDate
        End Get
        Set(ByVal Value As String)
            mAscToDate = Value
        End Set
    End Property
    Public Property AscInShiftMDID() As Int16
        Get
            Return mAscInShiftMDID
        End Get
        Set(ByVal Value As Int16)
            mAscInShiftMDID = Value
        End Set
    End Property
    Public Function GetShiftAscribeInfo(ByVal MDepartCode As String, ByVal MyHour As String, ByVal cnnStr As String) As Boolean
        Dim dt1 As DataTable
        Dim sqlstr As String
        Dim u1 As New IraniDate.IraniDate.Times


        GetShiftAscribeInfo = False

        'sqlstr = "SELECT AscribeID,AscShiftID,AscMDepartID,AscNetWorkTime,AscNetBreakTime,AscAllTime,ShiftBeginHour,ShiftEndHour " & _
        '    "FROM tbRCL_ShiftAscribe_Machin INNER JOIN " & _
        '    "tbRCL_Shifts ON AscShiftID = ShiftID " & _
        '    "WHERE ShiftBeginHour <=" & u1.GetTimeMinute(MyHour) & " AND ShiftEndHour >=" & u1.GetTimeMinute(MyHour) & " AND AscMDepartID = '" & MDepartCode & "'"

        sqlstr = "SELECT AscribeID, AscShiftID, AscMDepartID, AscNetWorkTime, AscNetBreakTime, AscAllTime, ShiftBeginHour, ShiftEndHour, BeginHour, EndHour " &
                "FROM HumanResource..vwRCL_ShiftMinMaxInMDepart_Machin " &
                "WHERE BeginHour <= " & u1.GetTimeMinute(MyHour) & " AND EndHour >= " & u1.GetTimeMinute(MyHour) & " AND AscMDepartID = '" & MDepartCode & "'"

        Try
            dt1 = ps1.GetDataTable(strConnection, sqlstr)
            Dim sh1 As New Shift
            If dt1.DefaultView.Count > 0 Then
                sh1.GetShiftInfo(dt1.DefaultView.Item(0).Item("AscShiftID"))

                mAscribeID = dt1.DefaultView.Item(0).Item("AscribeID")
                mAscShiftProp = sh1
                mAscMDepartID = dt1.DefaultView.Item(0).Item("AscMDepartID")
                mAscNetWorkTime = dt1.DefaultView.Item(0).Item("AscNetWorkTime")
                mAscNetBreakTime = dt1.DefaultView.Item(0).Item("AscNetBreakTime")
                mAscAllTime = dt1.DefaultView.Item(0).Item("AscAllTime")
                sh1 = Nothing
                GetShiftAscribeInfo = True
            ElseIf dt1.DefaultView.Count = 0 Then
                GetShiftAscribeInfo = False
            End If

        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function GetShiftAscribeInfo(ByVal MDepartCode As String, ByVal MyHour As String, ByVal MyDate As String, ByVal cnnStr As String) As Boolean
        Dim dt1 As DataTable
        Dim sqlstr As String
        Dim u1 As New IraniDate.IraniDate.Times


        GetShiftAscribeInfo = False

        sqlstr = "SELECT AscribeID,AscShiftID,AscMDepartID,AscNetWorkTime,AscNetBreakTime,AscAllTime,ShiftBeginHour,ShiftEndHour " &
            "FROM tbRCL_ShiftAscribe_Machin INNER JOIN " &
            "tbRCL_Shifts ON AscShiftID = ShiftID " &
            "WHERE ShiftBeginHour <=" & u1.GetTimeMinute(MyHour) & " AND ShiftEndHour >=" & u1.GetTimeMinute(MyHour) & " AND AscMDepartID = '" & MDepartCode & "'"

        'sqlstr = "SELECT AscribeID, AscShiftID, AscMDepartID, AscNetWorkTime, AscNetBreakTime, AscAllTime, ShiftBeginHour, ShiftEndHour, BeginHour, EndHour " & _
        '        "FROM HumanResource..vwRCL_ShiftMinMaxInMDepart_Machin " & _
        '        "WHERE BeginHour <= " & u1.GetTimeMinute(MyHour) & " AND EndHour >= " & u1.GetTimeMinute(MyHour) & " AND AscMDepartID = '" & MDepartCode & "'" & _
        '        " AND AscFromDate<='" & MyDate & "' AND (AscToDate>='" & MyDate & " ' OR AscToDate='0')AND (Jaygozin = 'جایگزین')"

        Try
            dt1 = ps1.GetDataTable(strConnection, sqlstr)
            Dim sh1 As New Shift
            If dt1.DefaultView.Count > 0 Then
                sh1.GetShiftInfo(dt1.DefaultView.Item(0).Item("AscShiftID"))

                mAscribeID = dt1.DefaultView.Item(0).Item("AscribeID")
                mAscShiftProp = sh1
                mAscMDepartID = dt1.DefaultView.Item(0).Item("AscMDepartID")
                mAscNetWorkTime = dt1.DefaultView.Item(0).Item("AscNetWorkTime")
                mAscNetBreakTime = dt1.DefaultView.Item(0).Item("AscNetBreakTime")
                mAscAllTime = dt1.DefaultView.Item(0).Item("AscAllTime")
                sh1 = Nothing
                GetShiftAscribeInfo = True
            ElseIf dt1.DefaultView.Count = 0 Then
                GetShiftAscribeInfo = False
            End If

        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function GetShiftAscribeInfo(ByVal MDepartCode As String, ByVal MyHourInMinute As Integer, ByVal MyDate As String, ByVal cnnStr As String) As DataTable


        Dim dt1 As DataTable
        Dim sqlstr As String
        Dim u1 As New IraniDate.IraniDate.Times


        GetShiftAscribeInfo = Nothing

        sqlstr = "SELECT AscribeID,AscShiftID,AscMDepartID,AscNetWorkTime,AscNetBreakTime,AscAllTime,(SELECT CASE ShiftDayStateID WHEN 2 THEN ShiftBeginHour + 1440 ELSE ShiftBeginHour END AS Expr1) as ShiftBeginHour ,(SELECT CASE ShiftToDayStateID WHEN 2 THEN ShiftEndHour + 1440 ELSE ShiftEndHour END AS Expr1) as ShiftEndHour " &
            "FROM tbRCL_ShiftAscribe_Machin INNER JOIN " &
            "tbRCL_Shifts ON AscShiftID = ShiftID " &
            "WHERE (SELECT CASE ShiftToDayStateID WHEN 2 THEN ShiftEndHour + 1440 ELSE ShiftEndHour END AS Expr1) >=" & MyHourInMinute & " AND AscMDepartID = '" & MDepartCode & "'"

        'sqlstr = "SELECT AscribeID, AscShiftID, AscMDepartID, AscNetWorkTime, AscNetBreakTime, AscAllTime, ShiftBeginHour, ShiftEndHour, BeginHour, EndHour " & _
        '        "FROM HumanResource..vwRCL_ShiftMinMaxInMDepart_Machin " & _
        '        "WHERE BeginHour <= " & u1.GetTimeMinute(MyHour) & " AND EndHour >= " & u1.GetTimeMinute(MyHour) & " AND AscMDepartID = '" & MDepartCode & "'" & _
        '        " AND AscFromDate<='" & MyDate & "' AND (AscToDate>='" & MyDate & " ' OR AscToDate='0')AND (Jaygozin = 'جایگزین')"

        Try
            dt1 = ps1.GetDataTable(strConnection, sqlstr)
            Dim sh1 As New Shift
            If dt1.DefaultView.Count > 0 Then
                sh1.GetShiftInfo(dt1.DefaultView.Item(0).Item("AscShiftID"))

                mAscribeID = dt1.DefaultView.Item(0).Item("AscribeID")
                mAscShiftProp = sh1
                mAscMDepartID = dt1.DefaultView.Item(0).Item("AscMDepartID")
                mAscNetWorkTime = dt1.DefaultView.Item(0).Item("AscNetWorkTime")
                mAscNetBreakTime = dt1.DefaultView.Item(0).Item("AscNetBreakTime")
                mAscAllTime = dt1.DefaultView.Item(0).Item("AscAllTime")
                sh1 = Nothing
                GetShiftAscribeInfo = dt1
            ElseIf dt1.DefaultView.Count = 0 Then
                GetShiftAscribeInfo = Nothing
            End If


        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





        'Dim dt1 As DataTable
        'Dim sqlstr As String
        'Dim u1 As New IraniDate.IraniDate.Times

        'CnnString = cnnStr
        'GetShiftAscribeInfo = False

        ''sqlstr = "SELECT AscribeID,AscShiftID,AscMDepartID,AscNetWorkTime,AscNetBreakTime,AscAllTime,ShiftBeginHour,ShiftEndHour " & _
        ''    "FROM tbRCL_ShiftAscribe_Machin INNER JOIN " & _
        ''    "tbRCL_Shifts ON AscShiftID = ShiftID " & _
        ''    "WHERE ShiftBeginHour <=" & u1.GetTimeMinute(MyHour) & " AND ShiftEndHour >=" & u1.GetTimeMinute(MyHour) & " AND AscMDepartID = '" & MDepartCode & "'"

        'sqlstr = "SELECT AscribeID, AscShiftID, AscMDepartID, AscNetWorkTime, AscNetBreakTime, AscAllTime, ShiftBeginHour, ShiftEndHour, BeginHour, EndHour " & _
        '        "FROM HumanResource..vwRCL_ShiftMinMaxInMDepart_Machin " & _
        '        "WHERE BeginHour <= " & MyHourInMinute & " AND EndHour >= " & MyHourInMinute & " AND AscMDepartID = '" & MDepartCode & "'" & _
        '        " AND AscFromDate<='" & MyDate & "' AND (AscToDate>='" & MyDate & " ' OR AscToDate='0')"

        'Try
        '    dt1 = ps1.GetDataTable(CnnString, sqlstr)
        '    Dim sh1 As New Shift
        '    If dt1.DefaultView.Count > 0 Then
        '        sh1.GetShiftInfo(dt1.DefaultView.Item(0).Item("AscShiftID"))

        '        mAscribeID = dt1.DefaultView.Item(0).Item("AscribeID")
        '        mAscShiftProp = sh1
        '        mAscMDepartID = dt1.DefaultView.Item(0).Item("AscMDepartID")
        '        mAscNetWorkTime = dt1.DefaultView.Item(0).Item("AscNetWorkTime")
        '        mAscNetBreakTime = dt1.DefaultView.Item(0).Item("AscNetBreakTime")
        '        mAscAllTime = dt1.DefaultView.Item(0).Item("AscAllTime")
        '        sh1 = Nothing
        '        GetShiftAscribeInfo = True
        '    ElseIf dt1.DefaultView.Count = 0 Then
        '        GetShiftAscribeInfo = False
        '    End If

        'Catch ex As SqlClient.SqlException
        '    MsgBox(ex.Message)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Function


    Friend Function ArchiveAscribeShift(ByVal ToDate As String) As Boolean
        Try
            Dim dt1 As DataTable
            Dim i As Integer
            Dim sqlstr = "SELECT AscMDepartID,AscShiftID FROM HumanResource_Del1..tbRCL_ShiftAscribe_Machin " &
                "WHERE (AcsStateID = 2) AND (AscMDepartID IN (SELECT AscMDepartID FROM tbRCL_ShiftAscribe_Machin " &
                "WHERE AcsStateID = 1))" 'فهرست شيفتهايي كه در وضعيت اجرا هستند

            dt1 = ps1.GetDataTable(strConnection, sqlstr)
            For i = 0 To dt1.DefaultView.Count - 1
                ps1.Sp_AddParam("@MDepartID", SqlDbType.Char, dt1.DefaultView.Item(i).Item("AscMDepartID"), ParameterDirection.Input)
                ps1.Sp_AddParam("@ToDate", SqlDbType.Char, ToDate, ParameterDirection.Input)
                ps1.Sp_AddParam("@ShiftID", SqlDbType.Char, dt1.DefaultView.Item(i).Item("AscShiftID"), ParameterDirection.Input)

                ps1.Sp_Exe("spRCL_ShiftAscribe_ActiveUpd_Machin", strConnection)
            Next

            ArchiveAscribeShift = True

        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Friend Function ActiveAscribeShift() As Boolean
        Try
            Dim dt1 As DataTable
            Dim i As Integer
            Dim sqlstr1 As String
            sqlstr1 = "SELECT AscMDepartID FROM HumanResource..tbRCL_ShiftAscribe_Machin WHERE AcsStateID = 1 " &
            IIf(MDepID = "TT000", " AND (LEFT(AscMDepartID,3)='TO6' OR LEFT(AscMDepartID,3)='QC2' OR LEFT(AscMDepartID,3)='TT')",
            IIf(MDepID = "PC000", " AND Left(AscMDepartID,2)<>'TT' AND Left(AscMDepartID,3)<>'TO6' AND Left(AscMDepartID,3)<>'QC2'", ""))            'فهرست شيفتهايي كه در وضعيت تنظيم هستند

            dt1 = ps1.GetDataTable(strConnection, sqlstr1)
            For i = 0 To dt1.DefaultView.Count - 1
                ps1.Sp_AddParam("@FromDate", SqlDbType.Char, Me.AscFromDate, ParameterDirection.Input)
                ps1.Sp_AddParam("@MDepartID", SqlDbType.Char, dt1.DefaultView.Item(i).Item("AscMDepartID"), ParameterDirection.Input)
                ps1.Sp_Exe("spRCL_ShiftAscribe_ActiveUpd", strConnection)

                'Call UpdateMDShift(dt1.DefaultView.Item(i).Item("AscMDepartID"))

                ActiveAscribeShift = True
            Next
        Catch ex As SqlClient.SqlException

        Catch ex As Exception

        End Try
    End Function

    Public Function AscribeShift(ByVal ShiftID As Int16, ByVal ShiftJaygozinID As Int16, ByVal MDepartID As String, ByVal AscFromDate As String, ByVal ShiftType As Integer) As Boolean
        Dim sqlstr As String
        Dim id As Short
        Dim dt As New DataTable
        Dim BreakTime, BreakTime1, BreakTime2, BreakTime3, BreakTime4, BreakTime5 As Integer
        Dim Middle As Boolean


        sqlstr =
        "SELECT     TOP (1) dbo.tbRCL_ShiftAscribe_Machin.AscShiftID, dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID, dbo.tbRCL_ShiftAscribe_Machin.Ascription,  " &
        "                      dbo.tbRCL_ShiftAscribe_Machin.AscNetWorkTime, dbo.tbRCL_ShiftAscribe_Machin.AscNetBreakTime, dbo.tbRCL_ShiftAscribe_Machin.AscAllTime,  " &
        "                      dbo.tbRCL_ShiftAscribe_Machin.AcsStateID, dbo.tbRCL_ShiftAscribe_Machin.AscFromDate, dbo.tbRCL_ShiftAscribe_Machin.AscToDate,  " &
        "                      dbo.tbRCL_ShiftAscribe_Machin.AscInShiftMDID, dbo.tbRCL_Shifts.ShiftType " &
        "FROM         dbo.tbRCL_ShiftAscribe_Machin INNER JOIN " &
        "                      dbo.tbRCL_Shifts ON dbo.tbRCL_ShiftAscribe_Machin.AscShiftID = dbo.tbRCL_Shifts.ShiftID " &
        "WHERE     (dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID = '" & MDepartID & "') AND (dbo.tbRCL_ShiftAscribe_Machin.AscFromDate <= '" & AscFromDate & "') AND  " &
        "                      (dbo.tbRCL_Shifts.ShiftType =" & ShiftType & ") " &
        "ORDER BY dbo.tbRCL_ShiftAscribe_Machin.AscFromDate DESC"


        dt = ps1.GetDataTable(strConnection, sqlstr)
        If dt.DefaultView.Count > 0 Then
            If ShiftJaygozinID = dt.DefaultView.Item(0).Item("AscShiftID") Then
                MsgBox("شیفت تکراری می باشد شیفت دیگری را انتخاب نمایید", MsgBoxStyle.OkOnly)
                AscribeShift = False
                Exit Function
            End If
        End If

        'sqlstr = "update   tbRCL_ShiftAscribe_Machin set AcsStateID=3,AscToDate='" & date1.GetDateIntToStr_GivenDate(date1.GetPlussToIraniDate(date1.ConvDateStrToInt_GivenDate(AscFromDate), -1)) & "' WHERE     (AscMDepartID = '" & MDepartID & "') AND (AscToDate = '0') AND  (AscShiftType = " & ShiftType & ")"
        'ps1.GetDataAccess(sqlstr, 2, CnnString)


        'sqlstr = " Update   dbo.tbRCL_ShiftAscribe_Machin Set AcsStateID = 3 , AscToDate='" & date1.GetDateIntToStr_GivenDate(date1.GetPlussToIraniDate(date1.ConvDateStrToInt_GivenDate(AscFromDate), -1)) & "'  WHERE     (AscMDepartID = '" & MDepartID & "') AND (AscShiftType  = " & ShiftType & ") AND (AcsStateID = 2)"
        'ps1.GetDataAccess(sqlstr, 2, CnnString)


        sqlstr =
        "SELECT     tbRCL_ShiftAscribe_Machin.AscribeID, tbRCL_ShiftAscribe_Machin.AscShiftID, tbRCL_ShiftAscribe_Machin.AscMDepartID,  " &
        "                      tbRCL_ShiftAscribe_Machin.Ascription, tbRCL_ShiftAscribe_Machin.AscNetWorkTime, tbRCL_ShiftAscribe_Machin.AscNetBreakTime,  " &
        "                      tbRCL_ShiftAscribe_Machin.AscAllTime, tbRCL_ShiftAscribe_Machin.AcsStateID, tbRCL_ShiftAscribe_Machin.AscFromDate,  " &
        "                      tbRCL_ShiftAscribe_Machin.AscToDate, tbRCL_ShiftAscribe_Machin.AscInShiftMDID, tbRCL_Shifts.ShiftType " &
        "FROM         tbRCL_ShiftAscribe_Machin INNER JOIN " &
        "                      tbRCL_Shifts ON tbRCL_ShiftAscribe_Machin.AscShiftID = tbRCL_Shifts.ShiftID " &
        "WHERE  (dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID = '" & MDepartID & "') AND   (tbRCL_ShiftAscribe_Machin.AscFromDate >= '" & AscFromDate & "') AND (tbRCL_Shifts.ShiftType =" & ShiftType & ")"


        dt = ps1.GetDataTable(strConnection, sqlstr)
        If dt.DefaultView.Count = 0 Then
            ps1.ClearParameter()

            ps1.Sp_AddParam("@AscToDate", SqlDbType.Char, date1.GetDateIntToStr_GivenDate(date1.GetPlussToIraniDate(date1.ConvDateStrToInt_GivenDate(AscFromDate), -1)), ParameterDirection.Input)
            ps1.Sp_AddParam("@MDepartID", SqlDbType.Char, MDepartID, ParameterDirection.Input)
            ps1.Sp_AddParam("@ShiftType", SqlDbType.Int, ShiftType, ParameterDirection.Input)
            ps1.Sp_Exe("spRCL_ShiftMachin_Upd", strConnection, False)
            Middle = False
        Else
            Middle = True
        End If












        ps1.ClearParameter()


        sqlstr = "SELECT     ShiftType, ShiftBeginHour, ShiftEndHour, ShiftBeginBreakTime1, ShiftEndBreakTime1, ShiftBeginBreakTime2, ShiftEndBreakTime2, " &
               "     ShiftBeginBreakTime3, ShiftEndBreakTime3, ShiftBeginBreakTime4, ShiftEndBreakTime4, ShiftBeginBreakTime5, ShiftEndBreakTime5 " &
                 "        FROM tbRCL_Shifts     WHERE(ShiftID = " & ShiftJaygozinID & ")"


        dt = ps1.GetDataTable(strConnection, sqlstr)

        If dt.DefaultView.Count > 0 Then
            If dt.DefaultView.Item(0).Item("ShiftBeginHour") > dt.DefaultView.Item(0).Item("ShiftEndHour") Then
                AscAllTime = (dt.DefaultView.Item(0).Item("ShiftEndHour") + 1440) - dt.DefaultView.Item(0).Item("ShiftBeginHour")
            Else
                AscAllTime = dt.DefaultView.Item(0).Item("ShiftEndHour") - dt.DefaultView.Item(0).Item("ShiftBeginHour")
            End If

            If dt.DefaultView.Item(0).Item("ShiftBeginBreakTime1") > dt.DefaultView.Item(0).Item("ShiftEndBreakTime1") Then
                BreakTime1 = (dt.DefaultView.Item(0).Item("ShiftEndBreakTime1") + 1440) - dt.DefaultView.Item(0).Item("ShiftBeginBreakTime1")
            Else
                BreakTime1 = dt.DefaultView.Item(0).Item("ShiftEndBreakTime1") - dt.DefaultView.Item(0).Item("ShiftBeginBreakTime1")
            End If
            If dt.DefaultView.Item(0).Item("ShiftBeginBreakTime2") > dt.DefaultView.Item(0).Item("ShiftEndBreakTime2") Then
                BreakTime2 = (dt.DefaultView.Item(0).Item("ShiftEndBreakTime2") + 1440) - dt.DefaultView.Item(0).Item("ShiftBeginBreakTime2")
            Else
                BreakTime2 = dt.DefaultView.Item(0).Item("ShiftEndBreakTime2") - dt.DefaultView.Item(0).Item("ShiftBeginBreakTime2")
            End If
            If dt.DefaultView.Item(0).Item("ShiftBeginBreakTime3") > dt.DefaultView.Item(0).Item("ShiftEndBreakTime3") Then
                BreakTime3 = (dt.DefaultView.Item(0).Item("ShiftEndBreakTime3") + 1440) - dt.DefaultView.Item(0).Item("ShiftBeginBreakTime3")
            Else
                BreakTime3 = dt.DefaultView.Item(0).Item("ShiftEndBreakTime3") - dt.DefaultView.Item(0).Item("ShiftBeginBreakTime3")
            End If
            If dt.DefaultView.Item(0).Item("ShiftBeginBreakTime4") > dt.DefaultView.Item(0).Item("ShiftEndBreakTime4") Then
                BreakTime4 = (dt.DefaultView.Item(0).Item("ShiftEndBreakTime4") + 1440) - dt.DefaultView.Item(0).Item("ShiftBeginBreakTime4")
            Else
                BreakTime4 = dt.DefaultView.Item(0).Item("ShiftEndBreakTime4") - dt.DefaultView.Item(0).Item("ShiftBeginBreakTime4")
            End If
            If dt.DefaultView.Item(0).Item("ShiftBeginBreakTime5") > dt.DefaultView.Item(0).Item("ShiftEndBreakTime5") Then
                BreakTime5 = (dt.DefaultView.Item(0).Item("ShiftEndBreakTime5") + 1440) - dt.DefaultView.Item(0).Item("ShiftBeginBreakTime5")
            Else
                BreakTime5 = dt.DefaultView.Item(0).Item("ShiftEndBreakTime5") - dt.DefaultView.Item(0).Item("ShiftBeginBreakTime5")
            End If


            BreakTime = BreakTime1 + BreakTime2 + BreakTime3 + BreakTime4 + BreakTime5


            ps1.Sp_AddParam("@AscribeID", SqlDbType.SmallInt, 0, ParameterDirection.Output)
            ps1.Sp_AddParam("@ShiftID", SqlDbType.TinyInt, ShiftJaygozinID, ParameterDirection.Input)
            ps1.Sp_AddParam("@MDepartID", SqlDbType.Char, MDepartID, ParameterDirection.Input)

            ps1.Sp_AddParam("@AscFromDate", SqlDbType.Char, AscFromDate, ParameterDirection.Input)
            ps1.Sp_AddParam("@AscShiftType", SqlDbType.Char, ShiftType, ParameterDirection.Input)


            ps1.Sp_AddParam("@AscAllTime", SqlDbType.Int, AscAllTime, ParameterDirection.Input)
            ps1.Sp_AddParam("@AscNetBreakTime", SqlDbType.Int, BreakTime, ParameterDirection.Input)
            ps1.Sp_AddParam("@AscNetWorkTime", SqlDbType.Int, AscAllTime - BreakTime, ParameterDirection.Input)
            If Middle = True Then
                ps1.Sp_AddParam("@AcsStateID", SqlDbType.Int, 3, ParameterDirection.Input)
            Else
                ps1.Sp_AddParam("@AcsStateID", SqlDbType.Int, 2, ParameterDirection.Input)
            End If


            Try
                ps1.Sp_Exe("spRCL_ShiftAscribeIns_Machin", strConnection, False)

                id = ps1.ParameterCmd1(1).ParamValue
                AscribeShift = True
            Catch ex As Exception
                AscribeShift = False
            End Try
        End If






        'ps1.ClearParameter()

        'If CalculateNetTimes(ShiftID, MDepartID) Then

        'End If

        'ps1.Sp_AddParam("@AscribeID", SqlDbType.Int, id, ParameterDirection.Input)
        'ps1.Sp_Exe("spRCL_ShiftAscribeUpd_MachinState", CnnString, False)
        'AscribeShift = True

    End Function

    Friend Function UnAscribeShift_Machin(ByVal ShiftID As Int16, ByVal MDepartID As String, ByVal StateID As Integer) As Boolean
        ps1.Sp_AddParam("@MDepartID", SqlDbType.Char, MDepartID, ParameterDirection.Input)
        ps1.Sp_AddParam("@CurDate", SqlDbType.Char, Me.AscToDate, ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftID", SqlDbType.TinyInt, ShiftID, ParameterDirection.Input)
        ps1.Sp_AddParam("@AcsStateID", SqlDbType.TinyInt, StateID, ParameterDirection.Input)
        Try
            If ps1.Sp_Exe("spRCL_ShiftUnAscribe_ArchiveUpd_Machin", strConnection) Then
                If Me.ArchiveMDShift_Machin(MDepartID) Then
                    If Me.ReUpdateMDShift(MDepartID) Then
                        UnAscribeShift_Machin = True
                    End If
                End If
            End If
        Catch ex As Exception
            UnAscribeShift_Machin = False
        End Try
    End Function

    Friend Function ArchiveMDShift_Machin(ByVal MDepartID As String) As Boolean
        ps1.Sp_AddParam("@MDepartID", SqlDbType.Char, MDepartID, ParameterDirection.Input)
        ps1.Sp_AddParam("@MDShiftEndDate", SqlDbType.Char, Me.AscToDate, ParameterDirection.Input)

        Try
            If ps1.Sp_Exe("spRCL_ShiftMDepart_ArchiveUpd_Machin", strConnection) Then
                ArchiveMDShift_Machin = True
            End If
        Catch ex As Exception
            ArchiveMDShift_Machin = False
        End Try
    End Function

    Friend Function ReUpdateMDShift(ByVal MDepartID As String) As Boolean
        Dim wstr1, wstr2, wstr3 As String
        Dim i As Integer
        Dim dt1 As DataTable
        Dim dt2 As DataTable
        Dim dt3 As DataTable

        wstr1 = "SELECT AscMDepartID,ShiftBeginHour,ShiftBeginHourTxt,ShiftDayStateID,ShiftEndHour, " &
            "ShiftEndHourTxt,ShiftToDayStateID," &
            "(SELECT COUNT(AscMDepartID) FROM vwRCL_ShiftMinMaxInMDepart_Machin WHERE AcsStateID=2 AND AscMDepartID='" & MDepartID & "')AS Cnt " &
            "FROM vwRCL_ShiftMinMaxInMDepart_Machin " &
            "WHERE (BeginHour=(SELECT MIN(beginhour)" &
                            "FROM vwRCL_ShiftMinMaxInMDepart_Machin WHERE AcsStateID=2 AND AscMDepartID='" & MDepartID & "' ))AND AcsStateID=2 AND (AscMDepartID ='" & MDepartID & "')"

        wstr2 = "SELECT AscMDepartID,ShiftBeginHour,ShiftBeginHourTxt,ShiftDayStateID,ShiftEndHour,ShiftEndHourTxt,ShiftToDayStateID " &
            "FROM vwRCL_ShiftMinMaxInMDepart_Machin " &
            "WHERE AcsStateID=2 AND (AscMDepartID ='" & MDepartID & "') " &
            " AND(EndHour=(SELECT MAX(endhour)FROM vwRCL_ShiftMinMaxInMDepart_Machin " &
                          "WHERE AcsStateID=2 AND AscMDepartID = '" & MDepartID & "'))"

        wstr3 = "SELECT COUNT(MDShiftMDepartID) as Cnt FROM tbRCL_ShiftMDepart_Machin WHERE  MDShiftStatusID = 2 AND MDShiftMDepartID='" & MDepartID & "'"
        Try
            dt1 = ps1.GetDataTable(strConnection, wstr1)
            dt2 = ps1.GetDataTable(strConnection, wstr2)
            dt3 = ps1.GetDataTable(strConnection, wstr3)

            If dt1.DefaultView.Count > 0 Then
                ps1.Sp_AddParam("@MDepartID", SqlDbType.Char, dt1.DefaultView.Item(0).Item("AscMDepartID"), ParameterDirection.Input)
                ps1.Sp_AddParam("@Number", SqlDbType.TinyInt, dt1.DefaultView.Item(0).Item("Cnt"), ParameterDirection.Input)
                ps1.Sp_AddParam("@Begin", SqlDbType.SmallInt, dt1.DefaultView.Item(0).Item("ShiftBeginHour"), ParameterDirection.Input)
                ps1.Sp_AddParam("@BeginTxt", SqlDbType.Char, dt1.DefaultView.Item(0).Item("ShiftBeginHourTxt"), ParameterDirection.Input)
                ps1.Sp_AddParam("@BDayStateID", SqlDbType.TinyInt, dt1.DefaultView.Item(0).Item("ShiftDayStateID"), ParameterDirection.Input)
                ps1.Sp_AddParam("@End", SqlDbType.SmallInt, dt2.DefaultView.Item(0).Item("ShiftEndHour"), ParameterDirection.Input)
                ps1.Sp_AddParam("@EndTxt", SqlDbType.Char, dt2.DefaultView.Item(0).Item("ShiftEndHourTxt"), ParameterDirection.Input)
                ps1.Sp_AddParam("@EDayStateID", SqlDbType.TinyInt, dt2.DefaultView.Item(0).Item("ShiftToDayStateID"), ParameterDirection.Input)
                ps1.Sp_AddParam("@MDShiftStatusID", SqlDbType.TinyInt, 2, ParameterDirection.Input)
                ps1.Sp_AddParam("@MDShiftFromDate", SqlDbType.Char, Me.AscFromDate, ParameterDirection.Input)

                ps1.Sp_Exe("spRCL_ShiftMDepartIns_Machin", strConnection)
            End If

            ReUpdateMDShift = True

        Catch ex As Exception

        End Try

    End Function

    Public Function UpdateMDShift(ByVal MDepartID As String, ByVal AscFromDate As String, ByVal AscToDate As String, ByVal shiftType As Integer) As Boolean
        'Dim ps1 As New Persistent.DataAccess.DataAccess
        Dim wstr1, wstr2, wstr3, wstr4, wstr5 As String
        Dim i As Integer
        Dim dt1 As DataTable
        Dim dt2 As DataTable
        Dim dt3 As DataTable
        Dim dt4 As DataTable
        Dim dt5 As DataTable
        Dim ir1 As New IraniDate.IraniDate.IraniDate

        'wstr4 = "SELECT AscMDepartID FROM vwRCL_ShiftAscribeForGrd_Machin " & _
        '    "WHERE AcsStateID = 2 AND AscMDepartID=0 GROUP BY AscMDepartID"   'فهرست واحدهايي كه شيفتهاي جديد براي آنها تعريف شده و هنوز در جدول شيفت واحد اعمال نشده اند
        'dt4 = ps1.GetDataTable(CnnString, wstr4)

        'If dt4.DefaultView.Count > 0 Then
        ' For i = 0 To dt4.DefaultView.Count - 1
        'MDepartID = dt4.DefaultView.Item(i).Item("AscMDepartID")

        'wstr5 = "SELECT MDShiftMDepartID FROM tbRCL_ShiftMDepart_Machin WHERE MDShiftMDepartID='" & MDepartID & "' AND MDShiftStatusID=2"
        'dt5 = ps1.GetDataTable(CnnString, wstr5)
        'If dt5.DefaultView.Count > 0 Then
        '    ps1.Sp_AddParam("@MDepartID", SqlDbType.Char, dt5.DefaultView.Item(0).Item("MDShiftMDepartID"), ParameterDirection.Input)
        '    ps1.Sp_AddParam("@MDShiftEndDate", SqlDbType.Char, Me.AscToDate, ParameterDirection.Input)

        '    ps1.Sp_Exe("spRCL_ShiftMDepart_ArchiveUpd", CnnString)
        'End If

        ps1.ClearParameter()

        ps1.Sp_AddParam("@MDShiftEndDate", SqlDbType.Char, ir1.StringDate(ir1.GetPlussToIraniDate(ir1.Numericdate(AscFromDate), -1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@shiftType", SqlDbType.Int, shiftType, ParameterDirection.Input)
        ps1.Sp_AddParam("@MDepartID", SqlDbType.Char, MDepartID, ParameterDirection.Input)


        ps1.Sp_Exe("spRCL_ShiftAscribeUpd_MachinState_MDShift", strConnection)





        'wstr1 = "Update tbRCL_ShiftMDepart_Machin set MDShiftStatusID=3 ,MDShiftEndDate ='" & ir1.StringDate(ir1.GetPlussToIraniDate(ir1.Numericdate(AscFromDate), -1)) & "' WHERE  (MDShiftNumber = " & shiftType & ") AND   (MDShiftMDepartID = '" & MDepartID & "') AND (MDShiftEndDate = '0')"
        'ps1.GetDataAccess(wstr1, 2, CnnString)


        wstr1 = "SELECT AscMDepartID,ShiftBeginHour,ShiftBeginHourTxt,ShiftDayStateID,ShiftEndHour, " &
            "ShiftEndHourTxt,ShiftToDayStateID," &
            "(SELECT COUNT(AscMDepartID)FROM vwRCL_ShiftMinMaxInMDepart_Machin WHERE AcsStateID=2 AND AscMDepartID='" & MDepartID & "')AS Cnt " &
            "FROM vwRCL_ShiftMinMaxInMDepart_Machin " &
            "WHERE (BeginHour=(SELECT MIN(beginhour)" &
                            "FROM vwRCL_ShiftMinMaxInMDepart_Machin WHERE AcsStateID=2 AND AscMDepartID='" & MDepartID & "' ))AND AcsStateID=2 AND (AscMDepartID ='" & MDepartID & "')"

        wstr2 = "SELECT AscMDepartID,ShiftBeginHour,ShiftBeginHourTxt,ShiftDayStateID,ShiftEndHour,ShiftEndHourTxt,ShiftToDayStateID " &
            "FROM vwRCL_ShiftMinMaxInMDepart_Machin " &
            "WHERE AcsStateID=2 AND (AscMDepartID ='" & MDepartID & "') " &
            " AND(EndHour=(SELECT MAX(endhour)FROM vwRCL_ShiftMinMaxInMDepart_Machin " &
                          "WHERE AcsStateID=2 AND AscMDepartID = '" & MDepartID & "'))"

        wstr3 = "SELECT COUNT(MDShiftMDepartID) as Cnt FROM tbRCL_ShiftMDepart_Machin WHERE  MDShiftStatusID = 2 AND MDShiftMDepartID='" & MDepartID & "'"
        Try
            dt1 = ps1.GetDataTable(strConnection, wstr1)
            dt2 = ps1.GetDataTable(strConnection, wstr2)
            dt3 = ps1.GetDataTable(strConnection, wstr3)

            If dt1.DefaultView.Count > 0 Then
                ps1.ClearParameter()
                ps1.Sp_AddParam("@MDepartID", SqlDbType.Char, dt1.DefaultView.Item(0).Item("AscMDepartID"), ParameterDirection.Input)
                ps1.Sp_AddParam("@Number", SqlDbType.TinyInt, dt1.DefaultView.Item(0).Item("Cnt"), ParameterDirection.Input)
                ps1.Sp_AddParam("@Begin", SqlDbType.SmallInt, dt1.DefaultView.Item(0).Item("ShiftBeginHour"), ParameterDirection.Input)
                ps1.Sp_AddParam("@BeginTxt", SqlDbType.Char, dt1.DefaultView.Item(0).Item("ShiftBeginHourTxt"), ParameterDirection.Input)
                ps1.Sp_AddParam("@BDayStateID", SqlDbType.TinyInt, dt1.DefaultView.Item(0).Item("ShiftDayStateID"), ParameterDirection.Input)
                ps1.Sp_AddParam("@End", SqlDbType.SmallInt, dt2.DefaultView.Item(0).Item("ShiftEndHour"), ParameterDirection.Input)
                ps1.Sp_AddParam("@EndTxt", SqlDbType.Char, dt2.DefaultView.Item(0).Item("ShiftEndHourTxt"), ParameterDirection.Input)
                ps1.Sp_AddParam("@EDayStateID", SqlDbType.TinyInt, dt2.DefaultView.Item(0).Item("ShiftToDayStateID"), ParameterDirection.Input)
                ps1.Sp_AddParam("@MDShiftStatusID", SqlDbType.TinyInt, 2, ParameterDirection.Input)
                ps1.Sp_AddParam("@MDShiftFromDate", SqlDbType.Char, AscFromDate, ParameterDirection.Input)
                ps1.Sp_AddParam("@MDShiftEndDate", SqlDbType.Char, AscToDate, ParameterDirection.Input)


                ps1.Sp_Exe("spRCL_ShiftMDepartIns_Machin", strConnection)

                'ElseIf dt1.DefaultView.Count = 0 Then
                '    ps1.Sp_AddParam("@MDepartID", SqlDbType.Char, MDepartID, ParameterDirection.Input)
                '    ps1.Sp_Exe("spRCL_ShiftMDepartDel", CnnString)
            End If

            UpdateMDShift = True

        Catch ex As Exception

        End Try
        '    Next
        ' End If
    End Function

    Friend Function CalculateNetTimes(ByVal ShiftID As Int16, ByVal MDepartID As String) As Boolean
        'Dim ps1 As New Persistent.DataAccess.DataAccess
        Dim dt1 As New DataTable
        Dim wstr1 As String
        Dim i As Int16
        Dim BeginHour, EndHour, BBreakTime1, EBreakTime1, BBreakTime2, EBreakTime2 As Int16
        Dim BBreakTime3, EBreakTime3, BBreakTime4, EBreakTime4, BBreakTime5, EBreakTime5 As Int16
        Dim AllTime, AllBreakTime, AllWorkTime As Int16

        wstr1 = "SELECT AscribeID,AscShiftID,AscMDepartID,ShiftBeginHour,ShiftDayStateID,ShiftEndHour,ShiftToDayStateID," &
        "ShiftBeginBreakTime1,ShiftDayState1ID,ShiftEndBreakTime1,ShiftToDayState1ID,ShiftBeginBreakTime2," &
        "ShiftDayState2ID,ShiftEndBreakTime2,ShiftToDayState2ID,ShiftBeginBreakTime3,ShiftDayState3ID," &
        "ShiftEndBreakTime3,ShiftToDayState3ID,ShiftBeginBreakTime4,ShiftDayState4ID,ShiftEndBreakTime4," &
        "ShiftToDayState4ID,ShiftBeginBreakTime5,ShiftDayState5ID,ShiftEndBreakTime5,ShiftToDayState5ID " &
        "FROM  dbo.tbRCL_ShiftAscribe_Machin INNER JOIN tbRCL_Shifts ON AscShiftID = ShiftID " &
        "WHERE AscMDepartID ='" & MDepartID & "' AND AscShiftID =" & ShiftID & " AND AcsStateID = 1"

        dt1 = ps1.GetDataTable(strConnection, wstr1)

        For i = 0 To dt1.DefaultView.Count - 1
            If dt1.DefaultView.Item(i).Item("ShiftDayStateID") = 1 Then
                BeginHour = dt1.DefaultView.Item(i).Item("ShiftBeginHour")
            ElseIf dt1.DefaultView.Item(i).Item("ShiftDayStateID") = 2 Then
                BeginHour = 1440 + dt1.DefaultView.Item(i).Item("ShiftBeginHour")
            End If

            If dt1.DefaultView.Item(i).Item("ShiftToDayStateID") = 1 Then
                EndHour = dt1.DefaultView.Item(i).Item("ShiftEndHour")
            ElseIf dt1.DefaultView.Item(i).Item("ShiftToDayStateID") = 2 Then
                EndHour = 1440 + dt1.DefaultView.Item(i).Item("ShiftEndHour")
            End If

            If dt1.DefaultView.Item(i).Item("ShiftDayState1ID") = 1 Then
                BBreakTime1 = dt1.DefaultView.Item(i).Item("ShiftBeginBreakTime1")
            ElseIf dt1.DefaultView.Item(i).Item("ShiftDayState1ID") = 2 Then
                BBreakTime1 = 1440 + dt1.DefaultView.Item(i).Item("ShiftBeginBreakTime1")
            End If

            If dt1.DefaultView.Item(i).Item("ShiftToDayState1ID") = 1 Then
                EBreakTime1 = dt1.DefaultView.Item(i).Item("ShiftEndBreakTime1")
            ElseIf dt1.DefaultView.Item(i).Item("ShiftToDayState1ID") = 2 Then
                EBreakTime1 = 1440 + dt1.DefaultView.Item(i).Item("ShiftEndBreakTime1")
            End If

            If dt1.DefaultView.Item(i).Item("ShiftDayState2ID") = 1 Then
                BBreakTime2 = dt1.DefaultView.Item(i).Item("ShiftBeginBreakTime2")
            ElseIf dt1.DefaultView.Item(i).Item("ShiftDayState2ID") = 2 Then
                BBreakTime2 = 1440 + dt1.DefaultView.Item(i).Item("ShiftBeginBreakTime2")
            End If

            If dt1.DefaultView.Item(i).Item("ShiftToDayState2ID") = 1 Then
                EBreakTime2 = dt1.DefaultView.Item(i).Item("ShiftEndBreakTime2")
            ElseIf dt1.DefaultView.Item(i).Item("ShiftToDayState2ID") = 2 Then
                EBreakTime2 = 1440 + dt1.DefaultView.Item(i).Item("ShiftEndBreakTime2")
            End If

            If dt1.DefaultView.Item(i).Item("ShiftDayState3ID") = 1 Then
                BBreakTime3 = dt1.DefaultView.Item(i).Item("ShiftBeginBreakTime3")
            ElseIf dt1.DefaultView.Item(i).Item("ShiftDayState3ID") = 2 Then
                BBreakTime3 = 1440 + dt1.DefaultView.Item(i).Item("ShiftBeginBreakTime3")
            End If

            If dt1.DefaultView.Item(i).Item("ShiftToDayState3ID") = 1 Then
                EBreakTime3 = dt1.DefaultView.Item(i).Item("ShiftEndBreakTime3")
            ElseIf dt1.DefaultView.Item(i).Item("ShiftToDayState3ID") = 2 Then
                EBreakTime3 = 1440 + dt1.DefaultView.Item(i).Item("ShiftEndBreakTime3")
            End If

            If dt1.DefaultView.Item(i).Item("ShiftDayState4ID") = 1 Then
                BBreakTime4 = dt1.DefaultView.Item(i).Item("ShiftBeginBreakTime4")
            ElseIf dt1.DefaultView.Item(i).Item("ShiftDayState4ID") = 2 Then
                BBreakTime4 = 1440 + dt1.DefaultView.Item(i).Item("ShiftBeginBreakTime4")
            End If

            If dt1.DefaultView.Item(i).Item("ShiftToDayState4ID") = 1 Then
                EBreakTime4 = dt1.DefaultView.Item(i).Item("ShiftEndBreakTime4")
            ElseIf dt1.DefaultView.Item(i).Item("ShiftToDayState4ID") = 2 Then
                EBreakTime4 = 1440 + dt1.DefaultView.Item(i).Item("ShiftEndBreakTime4")
            End If

            If dt1.DefaultView.Item(i).Item("ShiftDayState5ID") = 1 Then
                BBreakTime5 = dt1.DefaultView.Item(i).Item("ShiftBeginBreakTime5")
            ElseIf dt1.DefaultView.Item(i).Item("ShiftDayState5ID") = 2 Then
                BBreakTime5 = 1440 + dt1.DefaultView.Item(i).Item("ShiftBeginBreakTime5")
            End If

            If dt1.DefaultView.Item(i).Item("ShiftToDayState5ID") = 1 Then
                EBreakTime5 = dt1.DefaultView.Item(i).Item("ShiftEndBreakTime5")
            ElseIf dt1.DefaultView.Item(i).Item("ShiftToDayState5ID") = 2 Then
                EBreakTime5 = 1440 + dt1.DefaultView.Item(i).Item("ShiftEndBreakTime5")
            End If

            AllTime = AllTime + (EndHour - BeginHour)
            AllBreakTime = AllBreakTime + (EBreakTime1 - BBreakTime1) + (EBreakTime2 - BBreakTime2) + (EBreakTime3 - BBreakTime3) + (EBreakTime4 - BBreakTime4) + (EBreakTime5 - BBreakTime5)
            AllWorkTime = AllTime - AllBreakTime

            ps1.Sp_AddParam("@ShiftID", SqlDbType.SmallInt, ShiftID, ParameterDirection.Input)
            ps1.Sp_AddParam("@MDepartID", SqlDbType.Char, MDepartID, ParameterDirection.Input)
            ps1.Sp_AddParam("@NetWorkTime", SqlDbType.SmallInt, AllWorkTime, ParameterDirection.Input)
            ps1.Sp_AddParam("@NetBreakTime", SqlDbType.SmallInt, AllBreakTime, ParameterDirection.Input)
            ps1.Sp_AddParam("@AllTime", SqlDbType.SmallInt, AllTime, ParameterDirection.Input)

            Try
                If ps1.Sp_Exe("spRCL_ShiftAscribeUpd_Machin", strConnection) Then
                    CalculateNetTimes = True
                End If
            Catch ex As Exception

            End Try

        Next i
    End Function
    Public Function GetNetTime(ByVal StartDate As String, ByVal StartHour As String, ByVal StartState As TimeState, ByVal EndDate As String, ByVal EndHour As String, ByVal EndState As TimeState, ByVal MDepartID As String, ByVal cnnStr As String) As String
        Dim dt1 As DataTable
        Dim sqlstr1 As String
        Dim i, n As Integer
        Dim StartDate1, StartHour1, EndDate1, EndHour1 As String
        Dim StartState1, EndState1 As TimeState
        n = 0

        sqlstr1 = "SELECT top(1) MDShiftMDepartID,MDShiftStatusID,MDShiftFromDate,MDShiftEndDate,MDShiftBeginTxt,MDShiftBDayStateID,MDShiftEndTxt,MDShiftEDayStateID " &
            "FROM HumanResource..tbRCL_ShiftMDepart_Machin " &
            "WHERE MDShiftMDepartID='" & MDepartID & "' AND (MDShiftEndDate='0' OR " &
            "MDShiftEndDate >='" & StartDate & "') AND MDShiftFromDate<='" & EndDate & "'"
        dt1 = ps1.GetDataTable(cnnStr, sqlstr1)
        If dt1.DefaultView.Count > 0 Then
            For i = 0 To dt1.DefaultView.Count - 1
                If dt1.DefaultView.Item(i).Item("MDShiftFromDate") <= StartDate Then
                    StartDate1 = StartDate
                    StartHour1 = StartHour
                    StartState1 = StartState
                ElseIf dt1.DefaultView.Item(i).Item("MDShiftFromDate") > StartDate Then
                    StartDate1 = dt1.DefaultView.Item(i).Item("MDShiftFromDate")
                    StartHour1 = dt1.DefaultView.Item(i).Item("MDShiftBeginTxt")
                    StartState1 = dt1.DefaultView.Item(i).Item("MDShiftBDayStateID")
                End If

                If dt1.DefaultView.Item(i).Item("MDShiftEndDate") < EndDate And dt1.DefaultView.Item(i).Item("MDShiftEndDate") <> "0         " Then
                    EndDate1 = dt1.DefaultView.Item(i).Item("MDShiftEndDate")
                    EndHour1 = dt1.DefaultView.Item(i).Item("MDShiftEndTxt")
                    EndState1 = dt1.DefaultView.Item(i).Item("MDShiftEDayStateID")
                ElseIf dt1.DefaultView.Item(i).Item("MDShiftEndDate") >= EndDate Or dt1.DefaultView.Item(i).Item("MDShiftEndDate") = "0         " Then
                    EndDate1 = EndDate
                    EndHour1 = EndHour
                    EndState1 = EndState
                End If

                n = n + tm1.GetTimeMinute(Me.GetNetTime_Detail(StartDate1, StartHour1, StartState1, EndDate1, EndHour1, EndState1, MDepartID, cnnStr))
            Next
            GetNetTime = tm1.GetTimeHour(n)
        End If
    End Function
    Public Function GetNetTime_Detail(ByVal StartDate As String, ByVal StartHour As String, ByVal StartState As TimeState, ByVal EndDate As String, ByVal EndHour As String, ByVal EndState As TimeState, ByVal MDepartID As String, ByVal cnnStr As String) As String
        Dim dt1 As DataTable
        Dim dt2 As DataTable
        Dim dt3 As DataTable
        Dim sqlstr1, sqlstr2, sqlstr3 As String
        Dim WorkDayCnt, NetWorkTimeDay, SHour, EHour, StartFirstShiftHour, EndLastShiftHour As Integer
        Dim NetWorkTimeAllDays, DeficiteFirstShiftHour, DeficiteLastShiftHour As Integer



        If StartDate = "          " Or EndDate = "          " Then
            MsgBox("تاريخ شروع و پايان نامشخص است", MsgBoxStyle.Critical, "خطا")
        ElseIf StartHour = "     " Or StartHour = "" Or EndHour = "     " Or EndHour = "" Then
            MsgBox("ساعت شروع و پايان نامشخص است", MsgBoxStyle.Critical, "خطا")
        Else
            sqlstr1 = "SELECT Count(CalID)as WorkDayCnt FROM HumanResource..tbRCL_Calendar_Machin " &
                "WHERE (CalIraniDate >='" & StartDate & "' AND CalIraniDate <='" & EndDate & "') AND " & IIf(MDepartID = "TT000" Or MDepartID = "TO600", "CalTolidDayStatusID=1", "CalDayStatusID=1") 'تعداد روز هاي كاري ميان دو روز مورد نظر


            ' sqlstr2 = "SELECT        SUM(AscAllTime) AS NetWorkTimeSum  FROM            dbo.tbRCL_ShiftAscribe_Machin WHERE        (AscMDepartID =  '" & MDepartID & "') AND (AscFromDate <= '" & EndDate & "') AND (AscToDate >= '" & StartDate & "' OR                     AscToDate = '0')"


            sqlstr2 =
                    "SELECT     SUM( HumanResource..tbRCL_ShiftAscribe_Machin.AscAllTime) AS NetWorkTimeSum " &
                    "FROM         HumanResource..tbRCL_ShiftAscribe_Machin INNER JOIN " &
                    "                       HumanResource..tbRCL_Shifts ON  HumanResource..tbRCL_ShiftAscribe_Machin.AscShiftID =  HumanResource..tbRCL_Shifts.ShiftID " &
                    "WHERE     ( HumanResource..tbRCL_ShiftAscribe_Machin.AscMDepartID = '" & MDepartID & "') AND (HumanResource..tbRCL_ShiftAscribe_Machin.AscFromDate <= '" & EndDate & "') AND  " &
                    "                      (HumanResource..tbRCL_ShiftAscribe_Machin.AscToDate >= '" & StartDate & "' OR " &
                    "                      HumanResource..tbRCL_ShiftAscribe_Machin.AscToDate = '0') AND (HumanResource..tbRCL_Shifts.Jaygozin = 'جایگزین')"



            sqlstr3 = "SELECT MDShiftMDepartID," &
                "(SELECT MIN(BeginHour)AS MinHour FROM HumanResource..vwRCL_ShiftMinMaxInMDepart_Machin WHERE(AscMDepartID='" & MDepartID & "' AND AscFromDate<='" & StartDate & "' AND (AscToDate>='" & StartDate & "' OR AscToDate='0')AND (Jaygozin = 'جايگزين'))) AS MinHour," &
                "(SELECT MAX(EndHour)AS MaxHour FROM HumanResource..vwRCL_ShiftMinMaxInMDepart_Machin WHERE(AscMDepartID='" & MDepartID & "' AND AscFromDate<='" & StartDate & "' AND (AscToDate>='" & StartDate & "' OR AscToDate='0')AND (Jaygozin = 'جايگزين'))) AS MaxHour " &
                "FROM HumanResource..tbRCL_ShiftMDepart_Machin WHERE MDShiftMDepartID='" & MDepartID & "' AND MDShiftFromDate<='" & StartDate & "' AND (MDShiftEndDate>='" & StartDate & "' OR MDShiftEndDate='0')" 'ساعات شروع اولين شيفت و پايان آخرين شيفت به دقيقه

            Try
                dt1 = ps1.GetDataTable(strConnection, sqlstr1)
                WorkDayCnt = dt1.DefaultView.Item(0).Item("WorkDayCnt") 'تعداد روزهاي كاري ميان دو روز مورد نظر

                dt2 = ps1.GetDataTable(strConnection, sqlstr2)
                NetWorkTimeDay = dt2.DefaultView.Item(0).Item("NetWorkTimeSum") 'مجموع زمان كار خالص(ظرفيت) هر واحد در يك روز

                dt3 = ps1.GetDataTable(strConnection, sqlstr3)
                StartFirstShiftHour = dt3.DefaultView.Item(0).Item("MinHour") 'ساعات شروع اولين شيفت
                EndLastShiftHour = dt3.DefaultView.Item(0).Item("MaxHour") 'ساعت پايان آخرين شيفت

                SHour = tm1.GetTimeMinute(StartHour) 'ساعت شروع به دقيقه
                EHour = tm1.GetTimeMinute(EndHour) 'ساعت پايان به دقيقه

                If StartState = MainModule.TimeState.Tomorrow Then
                    SHour = 1440 + SHour
                    'StartHour = tm1.GetTimeHour(1440 + tm1.GetTimeMinute(StartHour))
                End If

                If EndState = MainModule.TimeState.Tomorrow Then
                    EHour = 1440 + EHour
                    'EndHour = tm1.GetTimeHour(1440 + tm1.GetTimeMinute(EndHour))
                End If

                Dim n, m As Integer
                Dim t As New IraniDate.IraniDate.Times
                Dim dif As String

                n = IIf(SHour - StartFirstShiftHour < 0, 0, SHour - StartFirstShiftHour)

                m = IIf(EndLastShiftHour - EHour < 0, 0, EndLastShiftHour - EHour)

                If m > NetWorkTimeDay Then
                    m = NetWorkTimeDay
                End If

                'n = Me.SumOfBreakTimes4StartHour(MDepartID, SHour, StartDate) 'مجموع زمانهاي استراحت اول شيفت كه در محدوده زماني مورد نظر قرار ندارند و چون در محاسبات قبلا كم شده اند بايست مجددا اضافه گردند
                'm = Me.SumOfBreakTimes4EndHour(MDepartID, EHour, StartDate) 'مجموع زمانهاي استراحت آخر شيفت كه در محدوده زماني مورد نظر قرار ندارند و چون در محاسبات قبلا كم شده اند بايست مجددا اضافه گردند

                'If StartState = MainModule.TimeState.Tomorrow Then
                '    SHour = 1440 + SHour
                'End If

                'If EndState = MainModule.TimeState.Tomorrow Then
                '    EHour = 1440 + EHour
                'End If

                NetWorkTimeAllDays = WorkDayCnt * NetWorkTimeDay 'مجموع زمانهاي كار خالص در چند روز مورد نظر



                GetNetTime_Detail = tm1.GetTimeHour(NetWorkTimeAllDays - (n + m))


                'Dim cl1 As New Calendar.Calendar
                'cl1.IraniDate = StartDate
                'Call cl1.GetDateInfo()
                'If cl1.DayStatusID = 1 Then
                '    'If StartFirstShiftHour >= SHour Then
                '    DeficiteFirstShiftHour = (SHour - StartFirstShiftHour) - n ' كسري اول شيفت
                '    'Else
                '    'DeficiteFirstShiftHour = n
                '    'End If
                'Else
                '    DeficiteFirstShiftHour = 0
                'End If

                'cl1.IraniDate = EndDate
                'Call cl1.GetDateInfo()
                'If cl1.DayStatusID = 1 Then
                '    DeficiteLastShiftHour = (EndLastShiftHour - EHour) - m ' كسري آخر شيفت
                'Else
                '    DeficiteLastShiftHour = 0
                'End If

                'GetNetTime_Detail = tm1.GetTimeHour(IIf(NetWorkTimeAllDays - (DeficiteFirstShiftHour + DeficiteLastShiftHour) < 0, 0, NetWorkTimeAllDays - (DeficiteFirstShiftHour + DeficiteLastShiftHour)))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            dt1.Clear() : dt1 = Nothing
            dt2.Clear() : dt2 = Nothing
            dt3.Clear() : dt3 = Nothing

        End If
    End Function
    Private Sub sumBreakTimeStartHour(ByVal MDepartCode As String, ByVal StartHour As Integer, ByVal MyDate As String)


    End Sub
    Private Function SumOfBreakTimes4StartHour(ByVal MDepartCode As String, ByVal StartHour As Integer, ByVal MyDate As String) As Integer
        Dim SHour As Int16
        Dim ebt1, ebt2, ebt3, ebt4, ebt5, bbt1, bbt2, bbt3, bbt4, bbt5 As Integer
        Dim ebt6, ebt7, ebt8, ebt9, ebt10, bbt6, bbt7, bbt8, bbt9, bbt10 As Integer
        Dim ebt11, ebt12, ebt13, ebt14, ebt15, bbt11, bbt12, bbt13, bbt14, bbt15 As Integer

        If Me.GetShiftAscribeInfo(MDepartCode, "07:30", MyDate, strConnection) Then
            ebt1 = IIf(mAscShiftProp.ToDayState1ID = 2, 1440 + mAscShiftProp.EndBreakTime1, mAscShiftProp.EndBreakTime1)
            ebt2 = IIf(mAscShiftProp.ToDayState2ID = 2, 1440 + mAscShiftProp.EndBreakTime2, mAscShiftProp.EndBreakTime2)
            ebt3 = IIf(mAscShiftProp.ToDayState3ID = 2, 1440 + mAscShiftProp.EndBreakTime3, mAscShiftProp.EndBreakTime3)
            ebt4 = IIf(mAscShiftProp.ToDayState4ID = 2, 1440 + mAscShiftProp.EndBreakTime4, mAscShiftProp.EndBreakTime4)
            ebt5 = IIf(mAscShiftProp.ToDayState5ID = 2, 1440 + mAscShiftProp.EndBreakTime5, mAscShiftProp.EndBreakTime5)
            bbt1 = IIf(mAscShiftProp.DayState1ID = 2, 1440 + mAscShiftProp.BeginBreakTime1, mAscShiftProp.BeginBreakTime1)
            bbt2 = IIf(mAscShiftProp.DayState2ID = 2, 1440 + mAscShiftProp.BeginBreakTime2, mAscShiftProp.BeginBreakTime2)
            bbt3 = IIf(mAscShiftProp.DayState3ID = 2, 1440 + mAscShiftProp.BeginBreakTime3, mAscShiftProp.BeginBreakTime3)
            bbt4 = IIf(mAscShiftProp.DayState4ID = 2, 1440 + mAscShiftProp.BeginBreakTime4, mAscShiftProp.BeginBreakTime4)
            bbt5 = IIf(mAscShiftProp.DayState5ID = 2, 1440 + mAscShiftProp.BeginBreakTime5, mAscShiftProp.BeginBreakTime5)

            Dim sh2 As New Ascribe
            If sh2.GetShiftAscribeInfo(MDepartCode, IIf(mAscShiftProp.ToDayStateID = 2, tm1.GetTimeHour(mAscShiftProp.EndHour + 1 + 1440), tm1.GetTimeHour(mAscShiftProp.EndHour + 1)), MyDate, strConnection) Then
                ebt6 = IIf(sh2.mAscShiftProp.ToDayState1ID = 2, 1440 + sh2.mAscShiftProp.EndBreakTime1, sh2.mAscShiftProp.EndBreakTime1)
                ebt7 = IIf(sh2.mAscShiftProp.ToDayState2ID = 2, 1440 + sh2.mAscShiftProp.EndBreakTime2, sh2.mAscShiftProp.EndBreakTime2)
                ebt8 = IIf(sh2.mAscShiftProp.ToDayState3ID = 2, 1440 + sh2.mAscShiftProp.EndBreakTime3, sh2.mAscShiftProp.EndBreakTime3)
                ebt9 = IIf(sh2.mAscShiftProp.ToDayState4ID = 2, 1440 + sh2.mAscShiftProp.EndBreakTime4, sh2.mAscShiftProp.EndBreakTime4)
                ebt10 = IIf(sh2.mAscShiftProp.ToDayState5ID = 2, 1440 + sh2.mAscShiftProp.EndBreakTime5, sh2.mAscShiftProp.EndBreakTime5)
                bbt6 = IIf(sh2.mAscShiftProp.DayState1ID = 2, 1440 + sh2.mAscShiftProp.BeginBreakTime1, sh2.mAscShiftProp.BeginBreakTime1)
                bbt7 = IIf(sh2.mAscShiftProp.DayState2ID = 2, 1440 + sh2.mAscShiftProp.BeginBreakTime2, sh2.mAscShiftProp.BeginBreakTime2)
                bbt8 = IIf(sh2.mAscShiftProp.DayState3ID = 2, 1440 + sh2.mAscShiftProp.BeginBreakTime3, sh2.mAscShiftProp.BeginBreakTime3)
                bbt9 = IIf(sh2.mAscShiftProp.DayState4ID = 2, 1440 + sh2.mAscShiftProp.BeginBreakTime4, sh2.mAscShiftProp.BeginBreakTime4)
                bbt10 = IIf(sh2.mAscShiftProp.DayState5ID = 2, 1440 + sh2.mAscShiftProp.BeginBreakTime5, sh2.mAscShiftProp.BeginBreakTime5)

                Dim sh3 As New Ascribe
                If sh3.GetShiftAscribeInfo(MDepartCode, IIf(sh2.mAscShiftProp.ToDayStateID = 2, tm1.GetTimeHour(sh2.mAscShiftProp.EndHour + 1 + 1440), tm1.GetTimeHour(sh2.mAscShiftProp.EndHour + 1)), MyDate, strConnection) Then
                    ebt11 = IIf(sh3.mAscShiftProp.ToDayState1ID = 2, 1440 + sh3.mAscShiftProp.EndBreakTime1, sh3.mAscShiftProp.EndBreakTime1)
                    ebt12 = IIf(sh3.mAscShiftProp.ToDayState2ID = 2, 1440 + sh3.mAscShiftProp.EndBreakTime2, sh3.mAscShiftProp.EndBreakTime2)
                    ebt13 = IIf(sh3.mAscShiftProp.ToDayState3ID = 2, 1440 + sh3.mAscShiftProp.EndBreakTime3, sh3.mAscShiftProp.EndBreakTime3)
                    ebt14 = IIf(sh3.mAscShiftProp.ToDayState4ID = 2, 1440 + sh3.mAscShiftProp.EndBreakTime4, sh3.mAscShiftProp.EndBreakTime4)
                    ebt15 = IIf(sh3.mAscShiftProp.ToDayState5ID = 2, 1440 + sh3.mAscShiftProp.EndBreakTime5, sh3.mAscShiftProp.EndBreakTime5)
                    bbt11 = IIf(sh3.mAscShiftProp.DayState1ID = 2, 1440 + sh3.mAscShiftProp.BeginBreakTime1, sh3.mAscShiftProp.BeginBreakTime1)
                    bbt12 = IIf(sh3.mAscShiftProp.DayState2ID = 2, 1440 + sh3.mAscShiftProp.BeginBreakTime2, sh3.mAscShiftProp.BeginBreakTime2)
                    bbt13 = IIf(sh3.mAscShiftProp.DayState3ID = 2, 1440 + sh3.mAscShiftProp.BeginBreakTime3, sh3.mAscShiftProp.BeginBreakTime3)
                    bbt14 = IIf(sh3.mAscShiftProp.DayState4ID = 2, 1440 + sh3.mAscShiftProp.BeginBreakTime4, sh3.mAscShiftProp.BeginBreakTime4)
                    bbt15 = IIf(sh3.mAscShiftProp.DayState5ID = 2, 1440 + sh3.mAscShiftProp.BeginBreakTime5, sh3.mAscShiftProp.BeginBreakTime5)
                End If
            End If




            'SHour = tm1.GetTimeMinute(StartHour) 'ساعت شروع به دقيقه
            SHour = StartHour

            If SHour >= ebt15 And ebt15 > 0 Then
                SumOfBreakTimes4StartHour = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt15 And SHour > bbt15 And ebt15 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour >= ebt14 And ebt14 > 0 Then
                SumOfBreakTimes4StartHour = (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt14 And SHour > bbt14 And ebt14 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour >= ebt13 And ebt13 > 0 Then
                SumOfBreakTimes4StartHour = (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt13 And SHour > bbt13 And ebt13 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour >= ebt12 And ebt12 > 0 Then
                SumOfBreakTimes4StartHour = (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt12 And SHour > bbt12 And ebt12 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour >= ebt11 And ebt11 > 0 Then
                SumOfBreakTimes4StartHour = (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt11 And SHour > bbt11 And ebt11 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)


            ElseIf SHour >= ebt10 And ebt10 > 0 Then
                SumOfBreakTimes4StartHour = (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt10 And SHour > bbt10 And ebt10 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour >= ebt9 And ebt9 > 0 Then
                SumOfBreakTimes4StartHour = (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt9 And SHour > bbt9 And ebt9 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour >= ebt8 And ebt8 > 0 Then
                SumOfBreakTimes4StartHour = (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt8 And SHour > bbt8 And ebt8 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour >= ebt7 And ebt7 > 0 Then
                SumOfBreakTimes4StartHour = (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt7 And SHour > bbt7 And ebt7 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour >= ebt6 And ebt6 > 0 Then
                SumOfBreakTimes4StartHour = (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt6 And SHour > bbt6 And ebt6 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)


            ElseIf SHour >= ebt5 And ebt5 > 0 Then
                SumOfBreakTimes4StartHour = (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt5 And SHour > bbt5 And ebt5 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour >= ebt4 And ebt4 > 0 Then
                SumOfBreakTimes4StartHour = (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt4 And SHour > bbt4 And ebt4 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour >= ebt3 And ebt3 > 0 Then
                SumOfBreakTimes4StartHour = (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt3 And SHour > bbt3 And ebt3 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour >= ebt2 And ebt2 > 0 Then
                SumOfBreakTimes4StartHour = (ebt2 - bbt2) + (ebt1 - bbt1)
            ElseIf SHour < ebt2 And SHour > bbt2 And ebt2 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt2) + (ebt1 - bbt1)
            ElseIf SHour >= ebt1 And ebt1 > 0 Then
                SumOfBreakTimes4StartHour = (ebt1 - bbt1)
            ElseIf SHour < ebt1 And SHour > bbt1 And ebt1 > 0 Then
                SumOfBreakTimes4StartHour = (SHour - bbt1)
            End If
        End If


    End Function
    Private Function SumOfBreakTimes4EndHour(ByVal MDepartCode As String, ByVal EndHour As Integer, ByVal MyDate As String) As Integer
        Dim EHour As Int16
        Dim ebt1, ebt2, ebt3, ebt4, ebt5, bbt1, bbt2, bbt3, bbt4, bbt5 As Integer
        Dim ebt6, ebt7, ebt8, ebt9, ebt10, bbt6, bbt7, bbt8, bbt9, bbt10 As Integer
        Dim ebt11, ebt12, ebt13, ebt14, ebt15, bbt11, bbt12, bbt13, bbt14, bbt15 As Integer
        Dim dt As New DataTable
        Dim i As Integer



        dt = Me.GetShiftAscribeInfo(MDepartCode, EndHour, MyDate, strConnection)

        For i = 0 To dt.DefaultView.Count - 1

            SumOfBreakTimes4EndHour = getBreakInfo(MDepartCode, EndHour, MyDate)
        Next

    End Function
    Private Function getBreakInfo(ByVal MDepartCode As String, ByVal EndHour As Integer, ByVal MyDate As String)
        Dim EHour As Int16
        Dim ebt1, ebt2, ebt3, ebt4, ebt5, bbt1, bbt2, bbt3, bbt4, bbt5 As Integer
        Dim ebt6, ebt7, ebt8, ebt9, ebt10, bbt6, bbt7, bbt8, bbt9, bbt10 As Integer
        Dim ebt11, ebt12, ebt13, ebt14, ebt15, bbt11, bbt12, bbt13, bbt14, bbt15 As Integer


        ebt1 = IIf(mAscShiftProp.ToDayState1ID = 2, 1440 + mAscShiftProp.EndBreakTime1, mAscShiftProp.EndBreakTime1)
        ebt2 = IIf(mAscShiftProp.ToDayState2ID = 2, 1440 + mAscShiftProp.EndBreakTime2, mAscShiftProp.EndBreakTime2)
        ebt3 = IIf(mAscShiftProp.ToDayState3ID = 2, 1440 + mAscShiftProp.EndBreakTime3, mAscShiftProp.EndBreakTime3)
        ebt4 = IIf(mAscShiftProp.ToDayState4ID = 2, 1440 + mAscShiftProp.EndBreakTime4, mAscShiftProp.EndBreakTime4)
        ebt5 = IIf(mAscShiftProp.ToDayState5ID = 2, 1440 + mAscShiftProp.EndBreakTime5, mAscShiftProp.EndBreakTime5)
        bbt1 = IIf(mAscShiftProp.DayState1ID = 2, 1440 + mAscShiftProp.BeginBreakTime1, mAscShiftProp.BeginBreakTime1)
        bbt2 = IIf(mAscShiftProp.DayState2ID = 2, 1440 + mAscShiftProp.BeginBreakTime2, mAscShiftProp.BeginBreakTime2)
        bbt3 = IIf(mAscShiftProp.DayState3ID = 2, 1440 + mAscShiftProp.BeginBreakTime3, mAscShiftProp.BeginBreakTime3)
        bbt4 = IIf(mAscShiftProp.DayState4ID = 2, 1440 + mAscShiftProp.BeginBreakTime4, mAscShiftProp.BeginBreakTime4)
        bbt5 = IIf(mAscShiftProp.DayState5ID = 2, 1440 + mAscShiftProp.BeginBreakTime5, mAscShiftProp.BeginBreakTime5)

        Dim sh2 As New Ascribe
        If sh2.GetShiftAscribeInfo(MDepartCode, IIf(mAscShiftProp.ToDayStateID = 2, tm1.GetTimeHour(mAscShiftProp.EndHour + 1 + 1440), tm1.GetTimeHour(mAscShiftProp.EndHour + 1)), MyDate, strConnection) Then
            ebt6 = IIf(sh2.mAscShiftProp.ToDayState1ID = 2, 1440 + sh2.mAscShiftProp.EndBreakTime1, sh2.mAscShiftProp.EndBreakTime1)
            ebt7 = IIf(sh2.mAscShiftProp.ToDayState2ID = 2, 1440 + sh2.mAscShiftProp.EndBreakTime2, sh2.mAscShiftProp.EndBreakTime2)
            ebt8 = IIf(sh2.mAscShiftProp.ToDayState3ID = 2, 1440 + sh2.mAscShiftProp.EndBreakTime3, sh2.mAscShiftProp.EndBreakTime3)
            ebt9 = IIf(sh2.mAscShiftProp.ToDayState4ID = 2, 1440 + sh2.mAscShiftProp.EndBreakTime4, sh2.mAscShiftProp.EndBreakTime4)
            ebt10 = IIf(sh2.mAscShiftProp.ToDayState5ID = 2, 1440 + sh2.mAscShiftProp.EndBreakTime5, sh2.mAscShiftProp.EndBreakTime5)
            bbt6 = IIf(sh2.mAscShiftProp.DayState1ID = 2, 1440 + sh2.mAscShiftProp.BeginBreakTime1, sh2.mAscShiftProp.BeginBreakTime1)
            bbt7 = IIf(sh2.mAscShiftProp.DayState2ID = 2, 1440 + sh2.mAscShiftProp.BeginBreakTime2, sh2.mAscShiftProp.BeginBreakTime2)
            bbt8 = IIf(sh2.mAscShiftProp.DayState3ID = 2, 1440 + sh2.mAscShiftProp.BeginBreakTime3, sh2.mAscShiftProp.BeginBreakTime3)
            bbt9 = IIf(sh2.mAscShiftProp.DayState4ID = 2, 1440 + sh2.mAscShiftProp.BeginBreakTime4, sh2.mAscShiftProp.BeginBreakTime4)
            bbt10 = IIf(sh2.mAscShiftProp.DayState5ID = 2, 1440 + sh2.mAscShiftProp.BeginBreakTime5, sh2.mAscShiftProp.BeginBreakTime5)

            Dim sh3 As New Ascribe
            If sh3.GetShiftAscribeInfo(MDepartCode, IIf(sh2.mAscShiftProp.ToDayStateID = 2, tm1.GetTimeHour(sh2.mAscShiftProp.EndHour + 1 + 1440), tm1.GetTimeHour(sh2.mAscShiftProp.EndHour + 1)), MyDate, strConnection) Then
                ebt11 = IIf(sh3.mAscShiftProp.ToDayState1ID = 2, 1440 + sh3.mAscShiftProp.EndBreakTime1, sh3.mAscShiftProp.EndBreakTime1)
                ebt12 = IIf(sh3.mAscShiftProp.ToDayState2ID = 2, 1440 + sh3.mAscShiftProp.EndBreakTime2, sh3.mAscShiftProp.EndBreakTime2)
                ebt13 = IIf(sh3.mAscShiftProp.ToDayState3ID = 2, 1440 + sh3.mAscShiftProp.EndBreakTime3, sh3.mAscShiftProp.EndBreakTime3)
                ebt14 = IIf(sh3.mAscShiftProp.ToDayState4ID = 2, 1440 + sh3.mAscShiftProp.EndBreakTime4, sh3.mAscShiftProp.EndBreakTime4)
                ebt15 = IIf(sh3.mAscShiftProp.ToDayState5ID = 2, 1440 + sh3.mAscShiftProp.EndBreakTime5, sh3.mAscShiftProp.EndBreakTime5)
                bbt11 = IIf(sh3.mAscShiftProp.DayState1ID = 2, 1440 + sh3.mAscShiftProp.BeginBreakTime1, sh3.mAscShiftProp.BeginBreakTime1)
                bbt12 = IIf(sh3.mAscShiftProp.DayState2ID = 2, 1440 + sh3.mAscShiftProp.BeginBreakTime2, sh3.mAscShiftProp.BeginBreakTime2)
                bbt13 = IIf(sh3.mAscShiftProp.DayState3ID = 2, 1440 + sh3.mAscShiftProp.BeginBreakTime3, sh3.mAscShiftProp.BeginBreakTime3)
                bbt14 = IIf(sh3.mAscShiftProp.DayState4ID = 2, 1440 + sh3.mAscShiftProp.BeginBreakTime4, sh3.mAscShiftProp.BeginBreakTime4)
                bbt15 = IIf(sh3.mAscShiftProp.DayState5ID = 2, 1440 + sh3.mAscShiftProp.BeginBreakTime5, sh3.mAscShiftProp.BeginBreakTime5)
            End If
        End If

        'EHour = tm1.GetTimeMinute(EndHour) 'ساعت پايان به دقيقه
        EHour = EndHour

        If EHour <= bbt1 And ebt1 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - bbt1)
        ElseIf EHour > bbt1 And EHour < ebt1 And ebt1 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2) + (ebt1 - EHour)
        ElseIf EHour <= bbt2 And ebt2 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - bbt2)
        ElseIf EHour > bbt2 And EHour < ebt2 And ebt2 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3) + (ebt2 - EHour)
        ElseIf EHour <= bbt3 And ebt3 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - bbt3)
        ElseIf EHour < ebt3 And EHour > bbt3 And ebt3 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4) + (ebt3 - EHour)
        ElseIf EHour <= bbt4 And ebt4 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - bbt4)
        ElseIf EHour < ebt4 And EHour > bbt4 And ebt4 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5) + (ebt4 - EHour)
        ElseIf EHour <= bbt5 And ebt5 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - bbt5)
        ElseIf EHour < ebt5 And EHour > bbt5 And ebt5 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6) + (ebt5 - EHour)

        ElseIf EHour <= bbt6 And ebt6 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - bbt6)
        ElseIf EHour > bbt6 And EHour < ebt6 And ebt6 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7) + (ebt6 - EHour)
        ElseIf EHour <= bbt7 And ebt7 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - bbt7)
        ElseIf EHour > bbt7 And EHour < ebt7 And ebt7 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8) + (ebt7 - EHour)
        ElseIf EHour <= bbt8 And ebt8 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - bbt8)
        ElseIf EHour < ebt8 And EHour > bbt8 And ebt8 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9) + (ebt8 - EHour)
        ElseIf EHour <= bbt9 And ebt9 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - bbt9)
        ElseIf EHour < ebt9 And EHour > bbt9 And ebt9 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10) + (ebt9 - EHour)
        ElseIf EHour <= bbt10 And ebt10 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - bbt10)
        ElseIf EHour < ebt10 And EHour > bbt10 And ebt10 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11) + (ebt10 - EHour)

        ElseIf EHour <= bbt11 And ebt11 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - bbt11)
        ElseIf EHour > bbt11 And EHour < ebt11 And ebt11 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12) + (ebt11 - EHour)
        ElseIf EHour <= bbt12 And ebt12 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - bbt12)
        ElseIf EHour > bbt12 And EHour < ebt12 And ebt12 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13) + (ebt12 - EHour)
        ElseIf EHour <= bbt13 And ebt13 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - bbt13)
        ElseIf EHour < ebt13 And EHour > bbt13 And ebt13 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14) + (ebt13 - EHour)
        ElseIf EHour <= bbt14 And ebt14 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - bbt14)
        ElseIf EHour < ebt14 And EHour > bbt14 And ebt14 > 0 Then
            getBreakInfo = (ebt15 - bbt15) + (ebt14 - EHour)
        ElseIf EHour <= bbt15 And ebt15 > 0 Then
            getBreakInfo = (ebt15 - bbt15)
        ElseIf EHour < ebt15 And EHour > bbt15 And ebt15 > 0 Then
            getBreakInfo = (ebt15 - EHour)

        End If

    End Function

    Public Function GetTimeIsInShift() As Boolean

    End Function




    Public Function GetNetTime_WithHolyday(ByVal StartDate As String, ByVal StartHour As String, ByVal StartState As TimeState, ByVal EndDate As String, ByVal EndHour As String, ByVal EndState As TimeState, ByVal MDepartID As String) As String
        Dim dt1 As New DataTable
        Dim sqlstr1 As String
        Dim i, n As Integer
        Dim StartDate1, StartHour1, EndDate1, EndHour1 As String
        Dim StartState1, EndState1 As TimeState
        n = 0

        'sqlstr1 = "SELECT top(1) MDShiftMDepartID,MDShiftStatusID,MDShiftFromDate,MDShiftEndDate,MDShiftBeginTxt,MDShiftBDayStateID,MDShiftEndTxt,MDShiftEDayStateID " & _
        '    "FROM HumanResource.dbo.tbRCL_ShiftMDepart_Machin " & _
        '    "WHERE MDShiftMDepartID='" & MDepartID & "' AND (MDShiftEndDate='0' OR " & _
        '    "MDShiftEndDate >='" & StartDate & "') AND MDShiftFromDate<='" & EndDate & "'"

        'dt1 = ps1.GetDataTable(cnnStr, sqlstr1)


        'If dt1.DefaultView.Count > 0 Then
        '    For i = 0 To dt1.DefaultView.Count - 1
        '        If dt1.DefaultView.Item(i).Item("MDShiftFromDate") <= StartDate Then


        StartDate1 = StartDate
        StartHour1 = StartHour ' CheckTime(StartHour, dt1.DefaultView.Item(i).Item("MDShiftBeginTxt"), dt1.DefaultView.Item(i).Item("MDShiftEndTxt"))
        StartState1 = StartState

        '        ElseIf dt1.DefaultView.Item(i).Item("MDShiftFromDate") > StartDate Then
        'StartDate1 = dt1.DefaultView.Item(i).Item("MDShiftFromDate")
        'StartHour1 = dt1.DefaultView.Item(i).Item("MDShiftBeginTxt")
        'StartState1 = dt1.DefaultView.Item(i).Item("MDShiftBDayStateID")
        '        End If

        'If dt1.DefaultView.Item(i).Item("MDShiftEndDate") < EndDate And dt1.DefaultView.Item(i).Item("MDShiftEndDate") <> "0         " Then
        '    EndDate1 = dt1.DefaultView.Item(i).Item("MDShiftEndDate")
        '    EndHour1 = dt1.DefaultView.Item(i).Item("MDShiftEndTxt")
        '    EndState1 = dt1.DefaultView.Item(i).Item("MDShiftEDayStateID")
        'ElseIf dt1.DefaultView.Item(i).Item("MDShiftEndDate") >= EndDate Or dt1.DefaultView.Item(i).Item("MDShiftEndDate") = "0         " Then


        EndDate1 = EndDate
        EndHour1 = EndHour 'CheckTime(EndHour, dt1.DefaultView.Item(i).Item("MDShiftBeginTxt"), dt1.DefaultView.Item(i).Item("MDShiftEndTxt"))
        EndState1 = EndState


        'End If

        n = n + tm1.GetTimeMinute(Me.GetNetTime_Detail_WithHolyday(StartDate1, StartHour1, StartState1, EndDate1, EndHour1, EndState1, MDepartID, strConnection))
        'Next
        GetNetTime_WithHolyday = tm1.GetTimeHour(n)
        'End If
    End Function

    Public Function GetNetTime_EzafeKari(ByVal StartDate As String, ByVal StartHour As String, ByVal StartState As TimeState, ByVal EndDate As String, ByVal EndHour As String, ByVal EndState As TimeState, ByVal MDepartID As String) As String
        Dim dt1 As New DataTable
        Dim n As Integer
        Dim StartDate1, StartHour1, EndDate1, EndHour1 As String
        Dim StartState1, EndState1 As TimeState
        n = 0

        StartDate1 = StartDate
        StartHour1 = StartHour
        StartState1 = StartState
        EndDate1 = EndDate
        EndHour1 = EndHour
        EndState1 = EndState

        n = n + tm1.GetTimeMinute(Me.GetNetTime_Detail_EzafeKari(StartDate1, StartHour1, StartState1, EndDate1, EndHour1, EndState1, MDepartID, strConnection))

        GetNetTime_EzafeKari = tm1.GetTimeHour(n)

    End Function


    Public Function CheckTime(ByVal CurTime As String, ByVal ShiftBiginTime As String, ByVal ShiftEndTime As String) As String

        If CurTime >= ShiftBiginTime And CurTime <= ShiftBiginTime Then
            CheckTime = CurTime
            Exit Function
        End If

        If CurTime < ShiftBiginTime Then
            CheckTime = ShiftBiginTime
            Exit Function
        End If

        If CurTime >= ShiftEndTime Then
            CheckTime = ShiftEndTime
            Exit Function
        End If


    End Function

    Public Function GetNetTime_Detail_WithHolyday(ByVal StartDate As String, ByVal StartHour As String, ByVal StartState As TimeState, ByVal EndDate As String, ByVal EndHour As String, ByVal EndState As TimeState, ByVal MDepartID As String, ByVal cnnStr As String) As String
        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable
        Dim sqlstr1, sqlstr2, sqlstr3 As String
        Dim WorkDayCnt, NetWorkTimeDay, SHour, EHour, StartFirstShiftHour, EndLastShiftHour As Integer
        Dim NetWorkTimeAllDays, DeficiteFirstShiftHour, DeficiteLastShiftHour As Integer
        Dim i As Integer
        Dim IraniDate1 As New IraniDate.IraniDate.IraniDate



        If StartDate = "          " Or EndDate = "          " Then
            MsgBox("تاريخ شروع و پايان نامشخص است", MsgBoxStyle.Critical, "خطا")
        ElseIf StartHour = "     " Or StartHour = "" Or EndHour = "     " Or EndHour = "" Then
            MsgBox("ساعت شروع و پايان نامشخص است", MsgBoxStyle.Critical, "خطا")
        Else
            sqlstr1 = "SELECT Count(CalID)as WorkDayCnt FROM HumanResource..tbRCL_Calendar_Machin " &
                "WHERE (CalIraniDate >='" & StartDate & "' AND CalIraniDate <='" & EndDate & "')" 'AND " & IIf(MDepartID = "TT000" Or MDepartID = "TO600", "CalTolidDayStatusID=1", "CalDayStatusID=1") 'تعداد روز هاي كاري ميان دو روز مورد نظر

            sqlstr2 = "SELECT SUM(AscNetWorkTime)AS NetWorkTimeSum FROM HumanResource..tbRCL_ShiftAscribe_Machin WHERE AscMDepartID ='" & MDepartID & "'AND AscFromDate<='" & StartDate & "' AND (AscToDate>='" & StartDate & "' OR AscToDate='0')" ' مجموع زمان كار خالص(ظرفيت) هر واحد در يك روز



            Try
                dt1 = ps1.GetDataTable(strConnection, sqlstr1)
                WorkDayCnt = dt1.DefaultView.Item(0).Item("WorkDayCnt") 'تعداد روزهاي كاري ميان دو روز مورد نظر

                For i = 0 To WorkDayCnt - 1
                    dt2 = ps1.GetDataTable(strConnection, sqlstr2)
                    NetWorkTimeDay = dt2.DefaultView.Item(0).Item("NetWorkTimeSum") + NetWorkTimeDay 'مجموع زمان كار خالص(ظرفيت) هر واحد در يك روز

                    sqlstr2 = "SELECT SUM(AscNetWorkTime)AS NetWorkTimeSum FROM HumanResource..tbRCL_ShiftAscribe_Machin WHERE AscMDepartID ='" & MDepartID & "'AND AscFromDate<='" & IraniDate1.StringDate(IraniDate1.GetPlussToIraniDate(IraniDate1.Numericdate(StartDate), i + 1)) & "' AND (AscToDate>='" & IraniDate1.StringDate(IraniDate1.GetPlussToIraniDate(IraniDate1.Numericdate(StartDate), i + 1)) & "' OR AscToDate='0')" ' مجموع زمان كار خالص(ظرفيت) هر واحد در يك روز
                    dt2 = ps1.GetDataTable(strConnection, sqlstr2)

                Next


                sqlstr3 =
                 "SELECT     TOP (1) " &
                 "                          (SELECT     CASE ShiftDayStateID WHEN 2 THEN 1440 + ShiftBeginHour ELSE ShiftBeginHour END AS Expr1) AS MinHour, " &
                 "                          (SELECT     CASE ShiftToDayStateID WHEN 2 THEN 1440 + ShiftEndHour ELSE ShiftEndHour END AS Expr1) AS MaxEndHour,  " &
                 "                      tbRCL_ShiftAscribe_Machin.AscFromDate " &
                 "FROM         tbRCL_ShiftAscribe_Machin INNER JOIN " &
                 "                      tbRCL_Shifts ON tbRCL_ShiftAscribe_Machin.AscShiftID = tbRCL_Shifts.ShiftID " &
                 "WHERE     (tbRCL_ShiftAscribe_Machin.AscMDepartID ='" & MDepartID & "') AND (tbRCL_ShiftAscribe_Machin.AscFromDate <= '" & StartDate & "') " &
                 "ORDER BY dbo.tbRCL_ShiftAscribe_Machin.AscShiftType, dbo.tbRCL_ShiftAscribe_Machin.AscFromDate DESC, MinHour "


                dt3 = ps1.GetDataTable(strConnection, sqlstr3)
                StartFirstShiftHour = dt3.DefaultView.Item(0).Item("MinHour") 'ساعات شروع اولين شيفت

                sqlstr3 =
                        "SELECT     TOP (1) " &
                        "                          (SELECT     CASE ShiftDayStateID WHEN 2 THEN 1440 + ShiftBeginHour ELSE ShiftBeginHour END AS Expr1) AS MinBeginHour, " &
                        "                          (SELECT     CASE ShiftToDayStateID WHEN 2 THEN 1440 + ShiftEndHour ELSE ShiftEndHour END AS Expr1) AS MaxHour,  " &
                        "                      tbRCL_ShiftAscribe_Machin.AscFromDate " &
                        "FROM         tbRCL_ShiftAscribe_Machin INNER JOIN " &
                        "                      tbRCL_Shifts ON tbRCL_ShiftAscribe_Machin.AscShiftID = tbRCL_Shifts.ShiftID " &
                        "WHERE     (tbRCL_ShiftAscribe_Machin.AscMDepartID = '" & MDepartID & "') AND (tbRCL_ShiftAscribe_Machin.AscFromDate <= '" & StartDate & "') " &
                        "ORDER BY dbo.tbRCL_ShiftAscribe_Machin.AscShiftType DESC, dbo.tbRCL_ShiftAscribe_Machin.AscFromDate DESC, MaxHour DESC "

                dt3 = ps1.GetDataTable(strConnection, sqlstr3)

                EndLastShiftHour = dt3.DefaultView.Item(0).Item("MaxHour")  'ساعت پايان آخرين شيفت

                SHour = tm1.GetTimeMinute(StartHour) 'ساعت شروع به دقيقه
                EHour = tm1.GetTimeMinute(EndHour) 'ساعت پايان به دقيقه



                If StartState = MainModule.TimeState.Tomorrow Then
                    SHour = 1440 + SHour
                    'StartHour = tm1.GetTimeHour(1440 + tm1.GetTimeMinute(StartHour))
                End If


                If EndState = MainModule.TimeState.Tomorrow Then
                    EHour = 1440 + EHour
                    'EndHour = tm1.GetTimeHour(1440 + tm1.GetTimeMinute(EndHour))
                End If








                Dim n, m As Integer
                n = BreakStrartTimeCalculate(MDepartID, StartDate, SHour) 'مجموع زمانهاي استراحت اول شيفت كه در محدوده زماني مورد نظر قرار ندارند و چون در محاسبات قبلا كم شده اند بايست مجددا اضافه گردند
                m = BreakEndTimeCalculate(MDepartID, StartDate, EHour) '+ 510 'مجموع زمانهاي استراحت آخر شيفت كه در محدوده زماني مورد نظر قرار ندارند و چون در محاسبات قبلا كم شده اند بايست مجددا اضافه گردند



                NetWorkTimeAllDays = NetWorkTimeDay ' WorkDayCnt * NetWorkTimeDay 'مجموع زمانهاي كار خالص در چند روز مورد نظر

                Dim cl1 As New Calendar.Calendar
                cl1.IraniDate = StartDate
                Call cl1.GetDateInfo()
                'If cl1.DayStatusID = 1 Then
                DeficiteFirstShiftHour = (SHour - StartFirstShiftHour) - n ' كسري اول شيفت
                'Else
                '   DeficiteFirstShiftHour = 0
                'End If

                cl1.IraniDate = EndDate
                Call cl1.GetDateInfo()
                'If cl1.DayStatusID = 1 Then
                DeficiteLastShiftHour = (EndLastShiftHour - EHour) - m ' كسري آخر شيفت
                'Else
                '    DeficiteLastShiftHour = 0
                'End If

                '   GetNetTime_Detail_WithHolyday = tm1.GetTimeHour(IIf(NetWorkTimeAllDays - (0 + DeficiteLastShiftHour) < 0, 0, NetWorkTimeAllDays - (0 + DeficiteLastShiftHour)))

                GetNetTime_Detail_WithHolyday = tm1.GetTimeHour(IIf(NetWorkTimeAllDays - (DeficiteFirstShiftHour + DeficiteLastShiftHour) < 0, 0, NetWorkTimeAllDays - (DeficiteFirstShiftHour + DeficiteLastShiftHour)))

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            dt1.Clear() : dt1 = Nothing
            dt2.Clear() : dt2 = Nothing
            dt3.Clear() : dt3 = Nothing

        End If
    End Function
    Public Function GetNetTime_Detail_EzafeKari(ByVal StartDate As String, ByVal StartHour As String, ByVal StartState As TimeState, ByVal EndDate As String, ByVal EndHour As String, ByVal EndState As TimeState, ByVal MDepartID As String, ByVal cnnStr As String) As String
        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable
        Dim sqlstr1, sqlstr2, sqlstr3 As String
        Dim WorkDayCnt, NetWorkTimeDay, SHour, EHour, StartFirstShiftHour, EndLastShiftHour As Integer
        Dim NetWorkTimeAllDays, DeficiteFirstShiftHour, DeficiteLastShiftHour As Integer
        Dim i As Integer
        Dim IraniDate1 As New IraniDate.IraniDate.IraniDate



        If StartDate = "          " Or EndDate = "          " Then
            MsgBox("تاريخ شروع و پايان نامشخص است", MsgBoxStyle.Critical, "خطا")
        ElseIf StartHour = "     " Or StartHour = "" Or EndHour = "     " Or EndHour = "" Then
            MsgBox("ساعت شروع و پايان نامشخص است", MsgBoxStyle.Critical, "خطا")
        Else
            sqlstr1 = "SELECT Count(CalID)as WorkDayCnt FROM HumanResource..tbRCL_Calendar_Machin " &
                "WHERE (CalIraniDate >='" & StartDate & "' AND CalIraniDate <='" & EndDate & "')" 'AND " & IIf(MDepartID = "TT000" Or MDepartID = "TO600", "CalTolidDayStatusID=1", "CalDayStatusID=1") 'تعداد روز هاي كاري ميان دو روز مورد نظر

            sqlstr2 = "SELECT SUM(AscNetBreakTime)AS NetWorkTimeSum FROM HumanResource..tbRCL_ShiftAscribe_Machin WHERE AscMDepartID ='" & MDepartID & "'AND AscFromDate<='" & StartDate & "' AND (AscToDate>='" & StartDate & "' OR AscToDate='0')" ' مجموع زمان كار خالص(ظرفيت) هر واحد در يك روز


            Try
                dt1 = ps1.GetDataTable(strConnection, sqlstr1)
                WorkDayCnt = dt1.DefaultView.Item(0).Item("WorkDayCnt") 'تعداد روزهاي كاري ميان دو روز مورد نظر

                For i = 0 To WorkDayCnt - 1
                    dt2 = ps1.GetDataTable(strConnection, sqlstr2)
                    NetWorkTimeDay = dt2.DefaultView.Item(0).Item("NetWorkTimeSum") + NetWorkTimeDay 'مجموع زمان كار خالص(ظرفيت) هر واحد در يك روز

                    sqlstr2 = "SELECT SUM(AscNetWorkTime)AS NetWorkTimeSum FROM HumanResource..tbRCL_ShiftAscribe_Machin WHERE AscMDepartID ='" & MDepartID & "'AND AscFromDate<='" & IraniDate1.StringDate(IraniDate1.GetPlussToIraniDate(IraniDate1.Numericdate(StartDate), i + 1)) & "' AND (AscToDate>='" & IraniDate1.StringDate(IraniDate1.GetPlussToIraniDate(IraniDate1.Numericdate(StartDate), i + 1)) & "' OR AscToDate='0')" ' مجموع زمان كار خالص(ظرفيت) هر واحد در يك روز
                    dt2 = ps1.GetDataTable(strConnection, sqlstr2)

                Next

                sqlstr3 = _
                          "SELECT     TOP (1) " & _
                          "                          (SELECT     CASE ShiftDayStateID WHEN 2 THEN 1440 + ShiftBeginHour ELSE ShiftBeginHour END AS Expr1) AS MinHour, " & _
                          "                          (SELECT     CASE ShiftToDayStateID WHEN 2 THEN 1440 + ShiftEndHour ELSE ShiftEndHour END AS Expr1) AS MaxEndHour,  " & _
                          "                      tbRCL_ShiftAscribe_Machin.AscFromDate " & _
                          "FROM         tbRCL_ShiftAscribe_Machin INNER JOIN " & _
                          "                      tbRCL_Shifts ON tbRCL_ShiftAscribe_Machin.AscShiftID = tbRCL_Shifts.ShiftID " & _
                          "WHERE     (tbRCL_ShiftAscribe_Machin.AscMDepartID ='" & MDepartID & "') AND (tbRCL_ShiftAscribe_Machin.AscFromDate <= '" & StartDate & "') " & _
                          "ORDER BY tbRCL_ShiftAscribe_Machin.AscFromDate DESC, MinHour"

                dt3 = ps1.GetDataTable(strConnection, sqlstr3)
                StartFirstShiftHour = dt3.DefaultView.Item(0).Item("MinHour") 'ساعات شروع اولين شيفت

                sqlstr3 = _
                     "SELECT     TOP (1) " & _
                     "                          (SELECT     CASE ShiftDayStateID WHEN 2 THEN 1440 + ShiftBeginHour ELSE ShiftBeginHour END AS Expr1) AS MinBeginHour, " & _
                     "                          (SELECT     CASE ShiftToDayStateID WHEN 2 THEN 1440 + ShiftEndHour ELSE ShiftEndHour END AS Expr1) AS MaxHour,  " & _
                     "                      tbRCL_ShiftAscribe_Machin.AscFromDate " & _
                     "FROM         tbRCL_ShiftAscribe_Machin INNER JOIN " & _
                     "                      tbRCL_Shifts ON tbRCL_ShiftAscribe_Machin.AscShiftID = tbRCL_Shifts.ShiftID " & _
                     "WHERE     (tbRCL_ShiftAscribe_Machin.AscMDepartID = '" & MDepartID & "') AND (tbRCL_ShiftAscribe_Machin.AscFromDate <= '" & StartDate & "') " & _
                     "ORDER BY tbRCL_ShiftAscribe_Machin.AscFromDate DESC, MaxHour DESC "

                dt3 = ps1.GetDataTable(strConnection, sqlstr3)
                EndLastShiftHour = dt3.DefaultView.Item(0).Item("MaxHour") 'ساعت پايان آخرين شيفت

                SHour = tm1.GetTimeMinute(StartHour) 'ساعت شروع به دقيقه
                EHour = tm1.GetTimeMinute(EndHour) 'ساعت پايان به دقيقه

                If StartState = MainModule.TimeState.Tomorrow Then
                    SHour = 1440 + SHour
                End If


                If EndState = MainModule.TimeState.Tomorrow Then
                    EHour = 1440 + EHour
                End If

                Dim n, m As Integer
                n = BreakStrartTimeCalculate(MDepartID, StartDate, SHour) 'مجموع زمانهاي استراحت اول شيفت كه در محدوده زماني مورد نظر قرار ندارند و چون در محاسبات قبلا كم شده اند بايست مجددا اضافه گردند
                m = BreakEndTimeCalculate(MDepartID, StartDate, EHour) '+ 510 'مجموع زمانهاي استراحت آخر شيفت كه در محدوده زماني مورد نظر قرار ندارند و چون در محاسبات قبلا كم شده اند بايست مجددا اضافه گردند


                NetWorkTimeAllDays = NetWorkTimeDay ' WorkDayCnt * NetWorkTimeDay 'مجموع زمانهاي كار خالص در چند روز مورد نظر


                GetNetTime_Detail_EzafeKari = tm1.GetTimeHour(IIf(NetWorkTimeAllDays - (n + m) < 0, 0, NetWorkTimeAllDays - (n + m)))

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            dt1.Clear() : dt1 = Nothing
            dt2.Clear() : dt2 = Nothing
            dt3.Clear() : dt3 = Nothing

        End If
    End Function

    Private Function BreakStrartTimeCalculate(ByVal MDepartCode As String, ByVal Repdate As String, ByVal Reptime As Integer) As Integer
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim pers1 As New Persistent.DataAccess.DataAccess
        sqlstr = _
"SELECT     (SELECT     CASE WHEN " & _
"                                                  ((SELECT     CASE ShiftToDayState1ID WHEN 2 THEN ShiftEndBreakTime1 + 1440 ELSE ShiftEndBreakTime1 END AS Expr1) <= " & Reptime & ")  " & _
"                                              THEN " & _
"                                                  (SELECT     CASE ShiftToDayState1ID WHEN 2 THEN ShiftEndBreakTime1 + 1440 ELSE ShiftEndBreakTime1 END AS Expr1) ELSE " & _
"                                                  (SELECT     CASE WHEN   " & Reptime & " BETWEEN " & _
"                                                                               (SELECT     CASE ShiftDayState1ID WHEN 2 THEN ShiftBeginBreakTime1  + 1440 ELSE ShiftBeginBreakTime1 END AS Expr1) " & _
"                                                                            AND " & _
"                                                                               (SELECT     CASE ShiftToDayState1ID WHEN 2 THEN ShiftEndBreakTime1 + 1440 ELSE ShiftEndBreakTime1 END AS Expr1)  " & _
"                                                                           THEN   " & Reptime & " ELSE 0 END AS Expr1) END AS Expr1) - " & _
"                          (SELECT     CASE WHEN " & _
"                                                       (SELECT     CASE ShiftDayState1ID WHEN 2 THEN ShiftBeginBreakTime1  + 1440 ELSE ShiftBeginBreakTime1 END AS Expr1)  " & _
"                                                   <= " & Reptime & " THEN " & _
"                                                       (SELECT     CASE ShiftDayState1ID WHEN 2 THEN ShiftBeginBreakTime1  + 1440 ELSE ShiftBeginBreakTime1 END AS Expr1)  " & _
"                                                   ELSE 0 END AS Expr1) AS dif1, " & _
"                          (SELECT     CASE WHEN " & _
"                                                       ((SELECT     CASE ShiftToDayState2ID WHEN 2 THEN ShiftEndBreakTime2 + 1440 ELSE ShiftEndBreakTime2 END AS Expr1) <= " & Reptime & ")  " & _
"                                                   THEN " & _
"                                                       (SELECT     CASE ShiftToDayState2ID WHEN 2 THEN ShiftEndBreakTime2 + 1440 ELSE ShiftEndBreakTime2 END AS Expr1)  " & _
"                                                   ELSE " & _
"                                                       (SELECT     CASE WHEN   " & Reptime & " BETWEEN " & _
"                                                                                    (SELECT     CASE ShiftDayState2ID WHEN 2 THEN ShiftBeginBreakTime2 + 1440 ELSE ShiftBeginBreakTime2 END AS Expr1) " & _
"                                                                                 AND " & _
"                                                                                    (SELECT     CASE ShiftToDayState2ID WHEN 2 THEN ShiftEndBreakTime2 + 1440 ELSE ShiftEndBreakTime2 END AS Expr1) " & _
"                                                                                 THEN   " & Reptime & " ELSE 0 END AS Expr1) END AS Expr1) - " & _
"                          (SELECT     CASE WHEN " & _
"                                                       (SELECT     CASE ShiftDayState2ID WHEN 2 THEN ShiftBeginBreakTime2 + 1440 ELSE ShiftBeginBreakTime2 END AS Expr1)  " & _
"                                                   <= " & Reptime & " THEN " & _
"                                                       (SELECT     CASE ShiftDayState2ID WHEN 2 THEN ShiftBeginBreakTime2 + 1440 ELSE ShiftBeginBreakTime2 END AS Expr1)  " & _
"                                                   ELSE 0 END AS Expr1) AS dif2, " & _
"                          (SELECT     CASE WHEN " & _
"                                                       ((SELECT     CASE ShiftToDayState3ID WHEN 2 THEN ShiftEndBreakTime3 + 1440 ELSE ShiftEndBreakTime3 END AS Expr1) <= " & Reptime & ")  " & _
"                                                   THEN " & _
"                                                       (SELECT     CASE ShiftToDayState3ID WHEN 2 THEN ShiftEndBreakTime3 + 1440 ELSE ShiftEndBreakTime3 END AS Expr1)  " & _
"                                                   ELSE " & _
"                                                       (SELECT     CASE WHEN   " & Reptime & " BETWEEN " & _
"                                                                                    (SELECT     CASE ShiftDayState3ID WHEN 2 THEN ShiftBeginBreakTime3 + 1440 ELSE ShiftBeginBreakTime3 END AS Expr1) " & _
"                                                                                 AND " & _
"                                                                                    (SELECT     CASE ShiftToDayState3ID WHEN 2 THEN ShiftEndBreakTime3 + 1440 ELSE ShiftEndBreakTime3 END AS Expr1) " & _
"                                                                                 THEN   " & Reptime & " ELSE 0 END AS Expr1) END AS Expr1) - " & _
"                          (SELECT     CASE WHEN " & _
"                                                       (SELECT     CASE ShiftDayState3ID WHEN 2 THEN ShiftBeginBreakTime3 + 1440 ELSE ShiftBeginBreakTime3 END AS Expr1)  " & _
"                                                   <= " & Reptime & " THEN " & _
"                                                       (SELECT     CASE ShiftDayState3ID WHEN 2 THEN ShiftBeginBreakTime3 + 1440 ELSE ShiftBeginBreakTime3 END AS Expr1)  " & _
"                                                   ELSE 0 END AS Expr1) AS dif3, " & _
"                          (SELECT     CASE WHEN " & _
"                                                       ((SELECT     CASE ShiftToDayState4ID WHEN 2 THEN ShiftEndBreakTime4 + 1440 ELSE ShiftEndBreakTime4 END AS Expr1) <= " & Reptime & ")  " & _
"                                                   THEN " & _
"                                                       (SELECT     CASE ShiftToDayState4ID WHEN 2 THEN ShiftEndBreakTime4 + 1440 ELSE ShiftEndBreakTime4 END AS Expr1)  " & _
"                                                   ELSE " & _
"                                                       (SELECT     CASE WHEN   " & Reptime & " BETWEEN " & _
"                                                                                    (SELECT     CASE ShiftDayState4ID WHEN 2 THEN ShiftBeginBreakTime4 + 1440 ELSE ShiftBeginBreakTime4 END AS Expr1) " & _
"                                                                                 AND " & _
"                                                                                    (SELECT     CASE ShiftToDayState4ID WHEN 2 THEN ShiftEndBreakTime4 + 1440 ELSE ShiftEndBreakTime4 END AS Expr1) " & _
"                                                                                 THEN   " & Reptime & " ELSE 0 END AS Expr1) END AS Expr1) - " & _
"                          (SELECT     CASE WHEN " & _
"                                                       (SELECT     CASE ShiftDayState4ID WHEN 2 THEN ShiftBeginBreakTime4 + 1440 ELSE ShiftBeginBreakTime4 END AS Expr1)  " & _
"                                                   <= " & Reptime & " THEN " & _
"                                                       (SELECT     CASE ShiftDayState4ID WHEN 2 THEN ShiftBeginBreakTime4 + 1440 ELSE ShiftBeginBreakTime4 END AS Expr1)  " & _
"                                                   ELSE 0 END AS Expr1) AS dif4, " & _
"                          (SELECT     CASE WHEN " & _
"                                                       ((SELECT     CASE ShiftToDayState5ID WHEN 2 THEN ShiftEndBreakTime5 + 1440 ELSE ShiftEndBreakTime5 END AS Expr1) <= " & Reptime & ")  " & _
"                                                   THEN " & _
"                                                       (SELECT     CASE ShiftToDayState5ID WHEN 2 THEN ShiftEndBreakTime5 + 1440 ELSE ShiftEndBreakTime5 END AS Expr1)  " & _
"                                                   ELSE " & _
"                                                       (SELECT     CASE WHEN   " & Reptime & " BETWEEN " & _
"                                                                                    (SELECT     CASE ShiftDayState5ID WHEN 2 THEN ShiftBeginBreakTime5 + 1440 ELSE ShiftBeginBreakTime5 END AS Expr1) " & _
"                                                                                 AND " & _
"                                                                                    (SELECT     CASE ShiftToDayState5ID WHEN 2 THEN ShiftEndBreakTime5 + 1440 ELSE ShiftEndBreakTime5 END AS Expr1) " & _
"                                                                                 THEN   " & Reptime & " ELSE 0 END AS Expr1) END AS Expr1) - " & _
"                          (SELECT     CASE WHEN " & _
"                                                       (SELECT     CASE ShiftDayState5ID WHEN 2 THEN ShiftBeginBreakTime5 + 1440 ELSE ShiftBeginBreakTime5 END AS Expr1)  " & _
"                                                   <= " & Reptime & " THEN " & _
"                                                       (SELECT     CASE ShiftDayState5ID WHEN 2 THEN ShiftBeginBreakTime5 + 1440 ELSE ShiftBeginBreakTime5 END AS Expr1)  " & _
"                                                   ELSE 0 END AS Expr1) AS dif5 " & _
"FROM         dbo.tbRCL_ShiftAscribe_Machin INNER JOIN " & _
"                      dbo.tbRCL_Shifts ON dbo.tbRCL_ShiftAscribe_Machin.AscShiftID = dbo.tbRCL_Shifts.ShiftID INNER JOIN " & _
"                      dbo.fn_MaxFromDateOnShift('" & MDepartCode & "', '" & Repdate & "') AS fn_MaxFromDateOnShift_1 ON  " & _
"                      dbo.tbRCL_ShiftAscribe_Machin.AscShiftType = fn_MaxFromDateOnShift_1.AscShiftType AND  " & _
"                      dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID = fn_MaxFromDateOnShift_1.AscMDepartID AND  " & _
"                      dbo.tbRCL_ShiftAscribe_Machin.AscFromDate = fn_MaxFromDateOnShift_1.maxAscFromDate " & _
"WHERE     (dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID = '" & MDepartCode & "') AND (fn_MaxFromDateOnShift_1.maxAscFromDate > '1392/09/22')"
        dt = pers1.GetDataTable(strConnection, sqlstr)

        Dim m, i As Integer


        For i = 0 To dt.DefaultView.Count - 1
            m = dt.DefaultView.Item(i).Item("dif1") + dt.DefaultView.Item(i).Item("dif2") + dt.DefaultView.Item(i).Item("dif3") + dt.DefaultView.Item(i).Item("dif4") + dt.DefaultView.Item(i).Item("dif5") + m
        Next
        BreakStrartTimeCalculate = m
    End Function
    Private Function BreakEndTimeCalculate(ByVal MDepartCode As String, ByVal Repdate As String, ByVal Reptime As Integer) As Integer
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim pers1 As New Persistent.DataAccess.DataAccess


        sqlstr = _
        "SELECT     (SELECT     CASE Jaygozin WHEN 'جايگزين' THEN " & _
        "                                                   shiftEndHour  ELSE " & _
        "                                                  (SELECT     CASE WHEN ShiftEndBreakTime1 <= " & Reptime & " THEN 0 ELSE ShiftEndBreakTime1 END AS Expr1) END AS Expr1) - " & _
        "                          (SELECT     CASE Jaygozin WHEN 'جايگزين' THEN " & _
        "                                                       (SELECT     CASE WHEN " & Reptime & " BETWEEN shiftBeginHour AND ShiftEndHour THEN " & Reptime & " ELSE shiftBeginHour END AS Expr1)  " & _
        "                                                   ELSE " & _
        "                                                       (SELECT     CASE WHEN ShiftEndBreakTime1 <= " & Reptime & " THEN 0 ELSE " & _
        "                                                                                    (SELECT     CASE WHEN " & Reptime & " BETWEEN ShiftBeginBreakTime1 AND  " & _
        "                                                                                                             ShiftEndBreakTime1 THEN " & Reptime & " ELSE ShiftBeginBreakTime1 END AS Expr1) END AS Expr1) END AS Expr1)  " & _
        "                      AS dif1, " & _
        "                          (SELECT     CASE Jaygozin WHEN 'جايگزين' THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN ShiftEndBreakTime2 <= " & Reptime & " THEN 0 ELSE ShiftEndBreakTime2 END AS Expr1) END AS Expr1) - " & _
        "                          (SELECT     CASE Jaygozin WHEN 'جايگزين' THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN ShiftEndBreakTime2 <= " & Reptime & " THEN 0 ELSE " & _
        "                                                                                    (SELECT     CASE WHEN " & Reptime & " BETWEEN ShiftBeginBreakTime2 AND  " & _
        "                                                                                                             ShiftEndBreakTime2 THEN " & Reptime & " ELSE ShiftBeginBreakTime2 END AS Expr1) END AS Expr1) END AS Expr1)  " & _
        "                      AS dif2, " & _
        "                          (SELECT     CASE Jaygozin WHEN 'جايگزين' THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN ShiftEndBreakTime3 <= " & Reptime & " THEN 0 ELSE ShiftEndBreakTime3 END AS Expr1) END AS Expr1) - " & _
        "                          (SELECT     CASE Jaygozin WHEN 'جايگزين' THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN ShiftEndBreakTime3 <= " & Reptime & " THEN 0 ELSE " & _
        "                                                                                    (SELECT     CASE WHEN " & Reptime & " BETWEEN ShiftBeginBreakTime3 AND  " & _
        "                                                                                                             ShiftEndBreakTime3 THEN " & Reptime & " ELSE ShiftBeginBreakTime3 END AS Expr1) END AS Expr1) END AS Expr1)  " & _
        "                      AS dif3, " & _
        "                          (SELECT     CASE Jaygozin WHEN 'جايگزين' THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN ShiftEndBreakTime4 <= " & Reptime & " THEN 0 ELSE ShiftEndBreakTime4 END AS Expr1) END AS Expr1) - " & _
        "                          (SELECT     CASE Jaygozin WHEN 'جايگزين' THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN ShiftEndBreakTime4 <= " & Reptime & " THEN 0 ELSE " & _
        "                                                                                    (SELECT     CASE WHEN " & Reptime & " BETWEEN ShiftBeginBreakTime4 AND  " & _
        "                                                                                                             ShiftEndBreakTime4 THEN " & Reptime & " ELSE ShiftBeginBreakTime4 END AS Expr1) END AS Expr1) END AS Expr1)  " & _
        "                      AS dif4, " & _
        "                          (SELECT     CASE Jaygozin WHEN 'جايگزين' THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN ShiftEndBreakTime5 <= " & Reptime & " THEN 0 ELSE ShiftEndBreakTime5 END AS Expr1) END AS Expr1) - " & _
        "                          (SELECT     CASE Jaygozin WHEN 'جايگزين' THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN ShiftEndBreakTime5 <= " & Reptime & " THEN 0 ELSE " & _
        "                                                                                    (SELECT     CASE WHEN " & Reptime & " BETWEEN ShiftBeginBreakTime5 AND  " & _
        "                                                                                                             ShiftEndBreakTime5 THEN " & Reptime & " ELSE ShiftBeginBreakTime5 END AS Expr1) END AS Expr1) END AS Expr1)  " & _
        "                      AS dif5 " & _
        "FROM         dbo.tbRCL_ShiftAscribe_Machin INNER JOIN " & _
        "                      dbo.fn_MaxFromDateOnShift('" & MDepartCode & "','" & Repdate & "') AS fn_MaxFromDateOnShift_1 ON  " & _
        "                      dbo.tbRCL_ShiftAscribe_Machin.AscShiftType = fn_MaxFromDateOnShift_1.AscShiftType AND  " & _
        "                      dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID = fn_MaxFromDateOnShift_1.AscMDepartID AND  " & _
        "                      dbo.tbRCL_ShiftAscribe_Machin.AscFromDate = fn_MaxFromDateOnShift_1.maxAscFromDate INNER JOIN " & _
        "                      dbo.VwRCL_Shift ON dbo.tbRCL_ShiftAscribe_Machin.AscShiftID = dbo.VwRCL_Shift.ShiftID " & _
        "WHERE     (dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID = '" & MDepartCode & "')"






        sqlstr = _
        "SELECT     (SELECT     CASE WHEN " & _
        "                                                  ((SELECT     CASE ShiftToDayState1ID WHEN 2 THEN ShiftEndBreakTime1 + 1440 ELSE ShiftEndBreakTime1 END AS Expr1) <= " & Reptime & " )  " & _
        "                                              THEN 0 ELSE " & _
        "                                                  (SELECT     CASE WHEN " & Reptime & "  BETWEEN " & _
        "                                                                               (SELECT     CASE ShiftDayState1ID WHEN 2 THEN ShiftBeginBreakTime1  + 1440 ELSE ShiftBeginBreakTime1 END AS Expr1) " & _
        "                                                                            AND " & _
        "                                                                               (SELECT     CASE ShiftToDayState1ID WHEN 2 THEN ShiftEndBreakTime1 + 1440 ELSE ShiftEndBreakTime1 END AS Expr1)  " & _
        "                                                                           THEN    (SELECT     CASE ShiftToDayState1ID WHEN 2 THEN ShiftEndBreakTime1 + 1440 ELSE ShiftEndBreakTime1 END AS Expr1)  ELSE " & _
        "                                                                               (SELECT     CASE ShiftToDayState1ID WHEN 2 THEN ShiftEndBreakTime1 + 1440 ELSE ShiftEndBreakTime1 END AS Expr1)  " & _
        "                                                                            END AS Expr1) END AS Expr1) - " & _
        "                          (SELECT     CASE WHEN " & _
        "                                                       ((SELECT     CASE ShiftToDayState1ID WHEN 2 THEN ShiftEndBreakTime1 + 1440 ELSE ShiftEndBreakTime1 END AS Expr1) <= " & Reptime & " )  " & _
        "                                                   THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN " & Reptime & "  BETWEEN " & _
        "                                                                                    (SELECT     CASE ShiftDayState1ID WHEN 2 THEN ShiftBeginBreakTime1  + 1440 ELSE ShiftBeginBreakTime1 END AS Expr1) " & _
        "                                                                                 AND " & _
        "                                                                                    (SELECT     CASE ShiftToDayState1ID WHEN 2 THEN ShiftEndBreakTime1 + 1440 ELSE ShiftEndBreakTime1 END AS Expr1) " & _
        "                                                                                 THEN " & Reptime & "  ELSE " & _
        "                                                                                    (SELECT     CASE ShiftDayState1ID WHEN 2 THEN ShiftBeginBreakTime1  + 1440 ELSE ShiftBeginBreakTime1 END AS Expr1) " & _
        "                                                                                 END AS Expr1) END AS Expr1) AS dif1, " & _
        "                          (SELECT     CASE WHEN " & _
        "                                                       ((SELECT     CASE ShiftToDayState2ID WHEN 2 THEN ShiftEndBreakTime2 + 1440 ELSE ShiftEndBreakTime2 END AS Expr1) <= " & Reptime & " )  " & _
        "                                                   THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN " & Reptime & "  BETWEEN " & _
        "                                                                                    (SELECT     CASE ShiftDayState2ID WHEN 2 THEN ShiftBeginBreakTime2 + 1440 ELSE ShiftBeginBreaktime2 END AS Expr1) " & _
        "                                                                                 AND " & _
        "                                                                                    (SELECT     CASE ShiftToDayState2ID WHEN 2 THEN ShiftEndBreakTime2 + 1440 ELSE ShiftEndBreakTime2 END AS Expr1) " & _
        "                                                                                 THEN (SELECT     CASE ShiftToDayState2ID WHEN 2 THEN ShiftEndBreakTime2 + 1440 ELSE ShiftEndBreakTime2 END AS Expr1)   ELSE " & _
        "                                                                                    (SELECT     CASE ShiftToDayState2ID WHEN 2 THEN ShiftEndBreakTime2 + 1440 ELSE ShiftEndBreakTime2 END AS Expr1) " & _
        "                                                                                 END AS Expr1) END AS Expr1) - " & _
        "                          (SELECT     CASE WHEN " & _
        "                                                       ((SELECT     CASE ShiftToDayState2ID WHEN 2 THEN ShiftEndBreakTime2 + 1440 ELSE ShiftEndBreakTime2 END AS Expr1) <= " & Reptime & " )  " & _
        "                                                   THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN " & Reptime & "  BETWEEN " & _
        "                                                                                    (SELECT     CASE ShiftDayState2ID WHEN 2 THEN ShiftBeginBreakTime2 + 1440 ELSE ShiftBeginBreakTime2 END AS Expr1) " & _
        "                                                                                 AND " & _
        "                                                                                    (SELECT     CASE ShiftToDayState2ID WHEN 2 THEN ShiftEndBreakTime2 + 1440 ELSE ShiftEndBreakTime2 END AS Expr1) " & _
        "                                                                                 THEN " & Reptime & "  ELSE " & _
        "                                                                                    (SELECT     CASE ShiftDayState2ID WHEN 2 THEN ShiftBeginBreakTime2 + 1440 ELSE ShiftBeginBreakTime2 END AS Expr1) " & _
        "                                                                                 END AS Expr1) END AS Expr1) AS dif2, " & _
        "                          (SELECT     CASE WHEN " & _
        "                                                       ((SELECT     CASE ShiftToDayState3ID WHEN 2 THEN ShiftEndBreakTime3 + 1440 ELSE ShiftEndBreakTime3 END AS Expr1) <= " & Reptime & " )  " & _
        "                                                   THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN " & Reptime & "  BETWEEN " & _
        "                                                                                    (SELECT     CASE ShiftDayState3ID WHEN 2 THEN ShiftBeginBreakTime3 + 1440 ELSE ShiftBeginBreaktime3 END AS Expr1) " & _
        "                                                                                 AND " & _
        "                                                                                    (SELECT     CASE ShiftToDayState3ID WHEN 2 THEN ShiftEndBreakTime3 + 1440 ELSE ShiftEndBreakTime3 END AS Expr1) " & _
        "                                                                                 THEN (SELECT     CASE ShiftToDayState3ID WHEN 2 THEN ShiftEndBreakTime3 + 1440 ELSE ShiftEndBreakTime3 END AS Expr1)  ELSE " & _
        "                                                                                    (SELECT     CASE ShiftToDayState3ID WHEN 2 THEN ShiftEndBreakTime3 + 1440 ELSE ShiftEndBreakTime3 END AS Expr1) " & _
        "                                                                                 END AS Expr1) END AS Expr1) - " & _
        "                          (SELECT     CASE WHEN " & _
        "                                                       ((SELECT     CASE ShiftToDayState3ID WHEN 2 THEN ShiftEndBreakTime3 + 1440 ELSE ShiftEndBreakTime3 END AS Expr1) <= " & Reptime & " )  " & _
        "                                                   THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN " & Reptime & "  BETWEEN " & _
        "                                                                                    (SELECT     CASE ShiftToDayState3ID WHEN 2 THEN ShiftBeginBreakTime3 + 1440 ELSE ShiftBeginBreakTime3 END AS Expr1) " & _
        "                                                                                 AND " & _
        "                                                                                    (SELECT     CASE ShiftToDayState3ID WHEN 2 THEN ShiftEndBreakTime3 + 1440 ELSE ShiftEndBreakTime3 END AS Expr1) " & _
        "                                                                                 THEN " & Reptime & "  ELSE " & _
        "                                                                                    (SELECT     CASE ShiftDayState3ID WHEN 2 THEN ShiftBeginBreakTime3 + 1440 ELSE ShiftBeginBreakTime3 END AS Expr1) " & _
        "                                                                                 END AS Expr1) END AS Expr1) AS dif3, " & _
        "                          (SELECT     CASE WHEN " & _
        "                                                       ((SELECT     CASE ShiftToDayState4ID WHEN 2 THEN ShiftEndBreakTime4 + 1440 ELSE ShiftEndBreakTime4 END AS Expr1) <= " & Reptime & " )  " & _
        "                                                   THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN " & Reptime & "  BETWEEN " & _
        "                                                                                    (SELECT     CASE ShiftDayState4ID WHEN 2 THEN ShiftBeginBreakTime4 + 1440 ELSE ShiftBeginBreaktime4 END AS Expr1) " & _
        "                                                                                 AND " & _
        "                                                                                    (SELECT     CASE ShiftToDayState4ID WHEN 2 THEN ShiftEndBreakTime4 + 1440 ELSE ShiftEndBreakTime4 END AS Expr1) " & _
        "                                                                                 THEN (SELECT     CASE ShiftToDayState4ID WHEN 2 THEN ShiftEndBreakTime4 + 1440 ELSE ShiftEndBreakTime4 END AS Expr1)  ELSE " & _
        "                                                                                    (SELECT     CASE ShiftToDayState4ID WHEN 2 THEN ShiftEndBreakTime4 + 1440 ELSE ShiftEndBreakTime4 END AS Expr1) " & _
        "                                                                                 END AS Expr1) END AS Expr1) - " & _
        "                          (SELECT     CASE WHEN " & _
        "                                                       ((SELECT     CASE ShiftToDayState4ID WHEN 2 THEN ShiftEndBreakTime4 + 1440 ELSE ShiftEndBreakTime4 END AS Expr1) <= " & Reptime & " )  " & _
        "                                                   THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN " & Reptime & "  BETWEEN " & _
        "                                                                                    (SELECT     CASE ShiftDayState4ID WHEN 2 THEN ShiftBeginBreakTime4 + 1440 ELSE ShiftBeginBreakTime4 END AS Expr1) " & _
        "                                                                                 AND " & _
        "                                                                                    (SELECT     CASE ShiftToDayState4ID WHEN 2 THEN ShiftEndBreakTime4 + 1440 ELSE ShiftEndBreakTime4 END AS Expr1) " & _
        "                                                                                 THEN " & Reptime & "  ELSE " & _
        "                                                                                    (SELECT     CASE ShiftDayState4ID WHEN 2 THEN ShiftBeginBreakTime4 + 1440 ELSE ShiftBeginBreakTime4 END AS Expr1) " & _
        "                                                                                 END AS Expr1) END AS Expr1) AS dif4, " & _
        "                          (SELECT     CASE WHEN " & _
        "                                                       ((SELECT     CASE ShiftToDayState5ID WHEN 2 THEN ShiftEndBreakTime5 + 1440 ELSE ShiftEndBreakTime5 END AS Expr1) <= " & Reptime & " )  " & _
        "                                                   THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN " & Reptime & "  BETWEEN " & _
        "                                                                                    (SELECT     CASE ShiftDayState5ID WHEN 2 THEN ShiftBeginBreakTime5 + 1440 ELSE ShiftBeginBreaktime5 END AS Expr1) " & _
        "                                                                                 AND " & _
        "                                                                                    (SELECT     CASE ShiftToDayState5ID WHEN 2 THEN ShiftEndBreakTime5 + 1440 ELSE ShiftEndBreakTime5 END AS Expr1) " & _
        "                                                                                 THEN (SELECT     CASE ShiftToDayState5ID WHEN 2 THEN ShiftEndBreakTime5 + 1440 ELSE ShiftEndBreakTime5 END AS Expr1)   ELSE " & _
        "                                                                                    (SELECT     CASE ShiftToDayState5ID WHEN 2 THEN ShiftEndBreakTime5 + 1440 ELSE ShiftEndBreakTime5 END AS Expr1) " & _
        "                                                                                 END AS Expr1) END AS Expr1) - " & _
        "                          (SELECT     CASE WHEN " & _
        "                                                       ((SELECT     CASE ShiftToDayState5ID WHEN 2 THEN ShiftEndBreakTime5 + 1440 ELSE ShiftEndBreakTime5 END AS Expr1) <= " & Reptime & " )  " & _
        "                                                   THEN 0 ELSE " & _
        "                                                       (SELECT     CASE WHEN " & Reptime & "  BETWEEN " & _
        "                                                                                    (SELECT     CASE ShiftDayState5ID WHEN 2 THEN ShiftBeginBreakTime5 + 1440 ELSE ShiftBeginBreakTime5 END AS Expr1) " & _
        "                                                                                 AND " & _
        "                                                                                    (SELECT     CASE ShiftToDayState5ID WHEN 2 THEN ShiftEndBreakTime5 + 1440 ELSE ShiftEndBreakTime5 END AS Expr1) " & _
        "                                                                                 THEN " & Reptime & "  ELSE " & _
        "                                                                                    (SELECT     CASE ShiftDayState5ID WHEN 2 THEN ShiftBeginBreakTime5 + 1440 ELSE ShiftBeginBreakTime5 END AS Expr1) " & _
        "                                                                                 END AS Expr1) END AS Expr1) AS dif5 " & _
        "FROM         dbo.tbRCL_ShiftAscribe_Machin INNER JOIN " & _
        "                      dbo.tbRCL_Shifts ON dbo.tbRCL_ShiftAscribe_Machin.AscShiftID = dbo.tbRCL_Shifts.ShiftID INNER JOIN " & _
        "                      dbo.fn_MaxFromDateOnShift('" & MDepartCode & "', '" & Repdate & "') AS fn_MaxFromDateOnShift_1 ON  " & _
        "                      dbo.tbRCL_ShiftAscribe_Machin.AscShiftType = fn_MaxFromDateOnShift_1.AscShiftType AND  " & _
        "                      dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID = fn_MaxFromDateOnShift_1.AscMDepartID AND  " & _
        "                      dbo.tbRCL_ShiftAscribe_Machin.AscFromDate = fn_MaxFromDateOnShift_1.maxAscFromDate " & _
        "WHERE     (dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID = '" & MDepartCode & "') AND (fn_MaxFromDateOnShift_1.maxAscFromDate >= '1392/09/22')"


        dt = pers1.GetDataTable(strConnection, sqlstr)

        Dim m, i As Integer


        For i = 0 To dt.DefaultView.Count - 1
            m = dt.DefaultView.Item(i).Item("dif1") + dt.DefaultView.Item(i).Item("dif2") + dt.DefaultView.Item(i).Item("dif3") + dt.DefaultView.Item(i).Item("dif4") + dt.DefaultView.Item(i).Item("dif5") + m
        Next
        BreakEndTimeCalculate = m
    End Function


End Class
