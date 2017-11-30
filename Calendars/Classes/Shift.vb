Public Class Shift
    Public Hours(6, 4) As String

    Private mShiftID As Int16
    Private mShiftTitle As String
    Private mShiftType As Integer
    Private mShiftTypeProp As New ShiftType

    Private mBeginHour As Int16
    Private mBeginHourTxt As String
    Private mEndHour As Int16
    Private mEndHourTxt As String
    Private mDayStateID As Int16
    Private mDayState As String
    Private mToDayStateID As Int16
    Private mToDayState As String

    Private mBeginBreakTime1 As Int16
    Private mBeginBreakTimeTxt1 As String
    Private mDayState1ID As Int16
    Private mDayState1 As String
    Private mEndBreakTime1 As Int16
    Private mEndBreakTimeTxt1 As String
    Private mToDayState1ID As Int16
    Private mToDayState1 As String

    Private mBeginBreakTime2 As Int16
    Private mBeginBreakTimeTxt2 As String
    Private mDayState2ID As Int16
    Private mDayState2 As String
    Private mEndBreakTime2 As Int16
    Private mEndBreakTimeTxt2 As String
    Private mToDayState2ID As Int16
    Private mToDayState2 As String

    Private mBeginBreakTime3 As Int16
    Private mBeginBreakTimeTxt3 As String
    Private mDayState3ID As Int16
    Private mDayState3 As String
    Private mEndBreakTime3 As Int16
    Private mEndBreakTimeTxt3 As String
    Private mToDayState3ID As Int16
    Private mToDayState3 As String

    Private mBeginBreakTime4 As Int16
    Private mBeginBreakTimeTxt4 As String
    Private mDayState4ID As Int16
    Private mDayState4 As String
    Private mEndBreakTime4 As Int16
    Private mEndBreakTimeTxt4 As String
    Private mToDayState4ID As Int16
    Private mToDayState4 As String

    Private mBeginBreakTime5 As Int16
    Private mBeginBreakTimeTxt5 As String
    Private mDayState5ID As Int16
    Private mDayState5 As String
    Private mEndBreakTime5 As Int16
    Private mEndBreakTimeTxt5 As String
    Private mToDayState5ID As Int16
    Private mToDayState5 As String

    Public Property ShiftID() As Int16
        Get
            Return mShiftID
        End Get
        Set(ByVal Value As Int16)
            mShiftID = Value
        End Set
    End Property

    Public ReadOnly Property ShiftTitle() As String
        Get
            Return mShiftTitle
        End Get
    End Property

    Public ReadOnly Property ShiftType() As Integer
        Get
            Return mShiftType
        End Get
    End Property

    Public Property ShiftTypeProp() As ShiftType
        Get
            Return mShiftTypeProp
        End Get
        Set(ByVal Value As ShiftType)
            mShiftTypeProp = Value
        End Set
    End Property


    Public ReadOnly Property BeginHour() As Int16
        Get
            Return mBeginHour
        End Get
    End Property

    Public ReadOnly Property BeginHourTxt() As String
        Get
            Return mBeginHourTxt
        End Get
    End Property

    Public ReadOnly Property EndHour() As Int16
        Get
            Return mEndHour
        End Get
    End Property

    Public ReadOnly Property EndHourTxt() As String
        Get
            Return mEndHourTxt
        End Get
    End Property

    Public ReadOnly Property DayStateID() As Int16
        Get
            Return mDayStateID
        End Get
    End Property

    Public ReadOnly Property DayState() As String
        Get
            Return mDayState
        End Get
    End Property

    Public ReadOnly Property ToDayStateID() As Int16
        Get
            Return mToDayStateID
        End Get
    End Property

    Public ReadOnly Property ToDayState() As String
        Get
            Return mToDayState
        End Get
    End Property


    Public ReadOnly Property BeginBreakTime1() As Int16
        Get
            Return mBeginBreakTime1
        End Get
    End Property

    Public ReadOnly Property BeginBreakTimeTxt1() As String
        Get
            Return mBeginBreakTimeTxt1
        End Get
    End Property

    Public ReadOnly Property DayState1ID() As Int16
        Get
            Return mDayState1ID
        End Get
    End Property

    Public ReadOnly Property DayState1() As String
        Get
            Return mDayState1
        End Get
    End Property

    Public ReadOnly Property EndBreakTime1() As Int16
        Get
            Return mEndBreakTime1
        End Get
    End Property

    Public ReadOnly Property EndBreakTimeTxt1() As String
        Get
            Return mEndBreakTimeTxt1
        End Get
    End Property

    Public ReadOnly Property ToDayState1ID() As Int16
        Get
            Return mToDayState1ID
        End Get
    End Property

    Public ReadOnly Property ToDayState1() As String
        Get
            Return mToDayState1
        End Get
    End Property


    Public ReadOnly Property BeginBreakTime2() As Int16
        Get
            Return mBeginBreakTime2
        End Get
    End Property

    Public ReadOnly Property BeginBreakTimeTxt2() As String
        Get
            Return mBeginBreakTimeTxt2
        End Get
    End Property

    Public ReadOnly Property DayState2ID() As Int16
        Get
            Return mDayState2ID
        End Get
    End Property

    Public ReadOnly Property DayState2() As String
        Get
            Return mDayState2
        End Get
    End Property

    Public ReadOnly Property EndBreakTime2() As Int16
        Get
            Return mEndBreakTime2
        End Get
    End Property

    Public ReadOnly Property EndBreakTimeTxt2() As String
        Get
            Return mEndBreakTimeTxt2
        End Get
    End Property

    Public ReadOnly Property ToDayState2ID() As Int16
        Get
            Return mToDayState2ID
        End Get
    End Property

    Public ReadOnly Property ToDayState2() As String
        Get
            Return mToDayState2
        End Get
    End Property


    Public ReadOnly Property BeginBreakTime3() As Int16
        Get
            Return mBeginBreakTime3
        End Get
    End Property

    Public ReadOnly Property BeginBreakTimeTxt3() As String
        Get
            Return mBeginBreakTimeTxt3
        End Get
    End Property

    Public ReadOnly Property DayState3ID() As Int16
        Get
            Return mDayState3ID
        End Get
    End Property

    Public ReadOnly Property DayState3() As String
        Get
            Return mDayState3
        End Get
    End Property

    Public ReadOnly Property EndBreakTime3() As Int16
        Get
            Return mEndBreakTime3
        End Get
    End Property

    Public ReadOnly Property EndBreakTimeTxt3() As String
        Get
            Return mEndBreakTimeTxt3
        End Get
    End Property

    Public ReadOnly Property ToDayState3ID() As Int16
        Get
            Return mToDayState3ID
        End Get
    End Property

    Public ReadOnly Property ToDayState3() As String
        Get
            Return mToDayState3
        End Get
    End Property


    Public ReadOnly Property BeginBreakTime4() As Int16
        Get
            Return mBeginBreakTime4
        End Get
    End Property

    Public ReadOnly Property BeginBreakTimeTxt4() As String
        Get
            Return mBeginBreakTimeTxt4
        End Get
    End Property

    Public ReadOnly Property DayState4ID() As Int16
        Get
            Return mDayState4ID
        End Get
    End Property

    Public ReadOnly Property DayState4() As String
        Get
            Return mDayState4
        End Get
    End Property

    Public ReadOnly Property EndBreakTime4() As Int16
        Get
            Return mEndBreakTime4
        End Get
    End Property

    Public ReadOnly Property EndBreakTimeTxt4() As String
        Get
            Return mEndBreakTimeTxt4
        End Get
    End Property

    Public ReadOnly Property ToDayState4ID() As Int16
        Get
            Return mToDayState4ID
        End Get
    End Property

    Public ReadOnly Property ToDayState4() As String
        Get
            Return mToDayState4
        End Get
    End Property


    Public ReadOnly Property BeginBreakTime5() As Int16
        Get
            Return mBeginBreakTime5
        End Get
    End Property

    Public ReadOnly Property BeginBreakTimeTxt5() As String
        Get
            Return mBeginBreakTimeTxt5
        End Get
    End Property

    Public ReadOnly Property DayState5ID() As Int16
        Get
            Return mDayState5ID
        End Get
    End Property

    Public ReadOnly Property DayState5() As String
        Get
            Return mDayState5
        End Get
    End Property

    Public ReadOnly Property EndBreakTime5() As Int16
        Get
            Return mEndBreakTime5
        End Get
    End Property

    Public ReadOnly Property EndBreakTimeTxt5() As String
        Get
            Return mEndBreakTimeTxt5
        End Get
    End Property

    Public ReadOnly Property ToDayState5ID() As Int16
        Get
            Return mToDayState5ID
        End Get
    End Property

    Public ReadOnly Property ToDayState5() As String
        Get
            Return mToDayState5
        End Get
    End Property

    Public Function GetShiftList(ByVal MDepartID As String, ByVal cnnStr As String) As DataTable
        Dim dt1 As New DataTable
        'Dim ps1 As New Persistent.DataAccess.DataAccess
        Dim sqlstr As String = ""

        sqlstr = "SELECT ShiftID,ShiftTitle,ShiftType,ShiftBeginHour,ShiftBeginHourTxt,ShiftEndHour,ShiftEndHourTxt,ShiftDayStateID,ShiftToDayStateID, " & _
            "ShiftBeginBreakTime1,ShiftBeginBreakTimeTxt1,ShiftEndBreakTime1,ShiftEndBreakTimeTxt1,ShiftDayState1ID,ShiftToDayState1ID, " & _
            "ShiftBeginBreakTime2,ShiftBeginBreakTimeTxt2,ShiftEndBreakTime2,ShiftEndBreakTimeTxt2,ShiftDayState2ID,ShiftToDayState2ID, " & _
            "ShiftBeginBreakTime3,ShiftBeginBreakTimeTxt3,ShiftEndBreakTime3,ShiftEndBreakTimeTxt3,ShiftDayState3ID,ShiftToDayState3ID, " & _
            "ShiftBeginBreakTime4,ShiftBeginBreakTimeTxt4,ShiftEndBreakTime4,ShiftEndBreakTimeTxt4,ShiftDayState4ID,ShiftToDayState4ID, " & _
            "ShiftBeginBreakTime5,ShiftBeginBreakTimeTxt5,ShiftEndBreakTime5,ShiftEndBreakTimeTxt5,ShiftDayState5ID,ShiftToDayState5ID, " & _
            "dbo.tbRCL_ShiftDayState.DayStateTxt AS DayState, tbRCL_ShiftDayState_1.DayStateTxt AS ToDayState," & _
            "tbRCL_ShiftDayState_2.DayStateTxt AS DayState1, tbRCL_ShiftDayState_3.DayStateTxt AS ToDayState1," & _
            "tbRCL_ShiftDayState_4.DayStateTxt AS DayState2, tbRCL_ShiftDayState_5.DayStateTxt AS ToDayState2," & _
            "tbRCL_ShiftDayState_6.DayStateTxt AS DayState3, tbRCL_ShiftDayState_7.DayStateTxt AS ToDayState3," & _
            "tbRCL_ShiftDayState_8.DayStateTxt AS DayState4, tbRCL_ShiftDayState_9.DayStateTxt AS ToDayState4," & _
            "tbRCL_ShiftDayState_10.DayStateTxt AS DayState5, tbRCL_ShiftDayState_11.DayStateTxt AS ToDayState5 " & _
            "FROM dbo.tbRCL_Shifts INNER JOIN " & _
            "dbo.tbRCL_ShiftDayState ON dbo.tbRCL_Shifts.ShiftDayStateID = dbo.tbRCL_ShiftDayState.DayStateID INNER JOIN " & _
            "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_1 ON dbo.tbRCL_Shifts.ShiftToDayStateID = tbRCL_ShiftDayState_1.DayStateID INNER JOIN " & _
            "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_2 ON dbo.tbRCL_Shifts.ShiftDayState1ID = tbRCL_ShiftDayState_2.DayStateID INNER JOIN " & _
            "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_3 ON dbo.tbRCL_Shifts.ShiftToDayState1ID = tbRCL_ShiftDayState_3.DayStateID INNER JOIN " & _
            "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_4 ON dbo.tbRCL_Shifts.ShiftDayState2ID = tbRCL_ShiftDayState_4.DayStateID INNER JOIN " & _
            "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_5 ON dbo.tbRCL_Shifts.ShiftToDayState2ID = tbRCL_ShiftDayState_5.DayStateID INNER JOIN " & _
            "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_6 ON dbo.tbRCL_Shifts.ShiftDayState3ID = tbRCL_ShiftDayState_6.DayStateID INNER JOIN " & _
            "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_7 ON dbo.tbRCL_Shifts.ShiftToDayState3ID = tbRCL_ShiftDayState_7.DayStateID INNER JOIN " & _
            "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_8 ON dbo.tbRCL_Shifts.ShiftDayState4ID = tbRCL_ShiftDayState_8.DayStateID INNER JOIN " & _
            "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_9 ON dbo.tbRCL_Shifts.ShiftToDayState4ID = tbRCL_ShiftDayState_9.DayStateID INNER JOIN " & _
            "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_10 ON dbo.tbRCL_Shifts.ShiftDayState5ID = tbRCL_ShiftDayState_10.DayStateID INNER JOIN " & _
            "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_11 ON dbo.tbRCL_Shifts.ShiftToDayState5ID = tbRCL_ShiftDayState_11.DayStateID INNER JOIN " & _
            "dbo.tbRCL_ShiftAscribe_Machin ON dbo.tbRCL_Shifts.ShiftID = dbo.tbRCL_ShiftAscribe_Machin.AscShiftID " & _
            "WHERE dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID = '" & MDepartID & "'"

        strConnection = cnnStr
        Try
            GetShiftList = ps1.GetDataTable(strConnection, sqlstr)
        Catch ex As Exception

        End Try

    End Function
    Public Function GetSumKarInAllShift(ByVal MDepCode As String, ByVal Repdate As String) As Long
        Dim sqlstr As String
        Dim dt As New DataTable

        sqlstr = _
            "SELECT     SUM(dbo.tbRCL_ShiftAscribe_Machin.AscNetWorkTime + dbo.tbRCL_ShiftAscribe_Machin.AscNetBreakTime) AS SumKar " & _
            "FROM         dbo.tbRCL_Shifts INNER JOIN " & _
            "                      dbo.tbRCL_ShiftAscribe_Machin ON dbo.tbRCL_Shifts.ShiftID = dbo.tbRCL_ShiftAscribe_Machin.AscShiftID " & _
            "WHERE     (dbo.tbRCL_ShiftAscribe_Machin.AscFromDate <= '" & Repdate & "') AND (dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID = '" & MDepCode & "') AND  " & _
            "                      (dbo.tbRCL_ShiftAscribe_Machin.AscToDate >= '" & Repdate & "') " & _
            "HAVING      (SUM(dbo.tbRCL_ShiftAscribe_Machin.AscNetWorkTime + dbo.tbRCL_ShiftAscribe_Machin.AscNetBreakTime) IS NOT NULL)"

        dt = ps1.GetDataTable(strConnection, sqlstr)
        If dt.DefaultView.Count > 0 Then
            GetSumKarInAllShift = dt.DefaultView.Item(0).Item("SumKar")
        Else
            sqlstr = _
                       "SELECT     SUM(dbo.tbRCL_ShiftAscribe_Machin.AscNetWorkTime + dbo.tbRCL_ShiftAscribe_Machin.AscNetBreakTime) AS SumKar " & _
                       "FROM         dbo.tbRCL_Shifts INNER JOIN " & _
                       "                      dbo.tbRCL_ShiftAscribe_Machin ON dbo.tbRCL_Shifts.ShiftID = dbo.tbRCL_ShiftAscribe_Machin.AscShiftID " & _
                       "WHERE     (dbo.tbRCL_ShiftAscribe_Machin.AscFromDate <= '" & Repdate & "') AND (dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID = '" & MDepCode & "') AND  " & _
                       "                      (dbo.tbRCL_ShiftAscribe_Machin.AscToDate = '0') " & _
                       "HAVING      (SUM(dbo.tbRCL_ShiftAscribe_Machin.AscNetWorkTime + dbo.tbRCL_ShiftAscribe_Machin.AscNetBreakTime) IS NOT NULL)"

            dt = ps1.GetDataTable(strConnection, sqlstr)
            If dt.DefaultView.Count > 0 Then
                GetSumKarInAllShift = dt.DefaultView.Item(0).Item("SumKar")
            Else
                MsgBox("‘Ì›   ⁄—Ì› ‰‘œÂ «” ", MsgBoxStyle.OKOnly)
            End If
        End If


    End Function

    Public Function GetShiftInfo(ByVal ShiftCode As Int16) As Boolean
        Dim dt1 As New DataTable
        'Dim ps1 As New Persistent.DataAccess.DataAccess
        Dim sqlstr As String = ""

        sqlstr = "SELECT ShiftID,ShiftTitle,ShiftType,ShiftBeginHour,ShiftBeginHourTxt,ShiftEndHour,ShiftEndHourTxt,ShiftDayStateID,ShiftToDayStateID, " & _
            "ShiftBeginBreakTime1,ShiftBeginBreakTimeTxt1,ShiftEndBreakTime1,ShiftEndBreakTimeTxt1,ShiftDayState1ID,ShiftToDayState1ID, " & _
            "ShiftBeginBreakTime2,ShiftBeginBreakTimeTxt2,ShiftEndBreakTime2,ShiftEndBreakTimeTxt2,ShiftDayState2ID,ShiftToDayState2ID, " & _
            "ShiftBeginBreakTime3,ShiftBeginBreakTimeTxt3,ShiftEndBreakTime3,ShiftEndBreakTimeTxt3,ShiftDayState3ID,ShiftToDayState3ID, " & _
            "ShiftBeginBreakTime4,ShiftBeginBreakTimeTxt4,ShiftEndBreakTime4,ShiftEndBreakTimeTxt4,ShiftDayState4ID,ShiftToDayState4ID, " & _
            "ShiftBeginBreakTime5,ShiftBeginBreakTimeTxt5,ShiftEndBreakTime5,ShiftEndBreakTimeTxt5,ShiftDayState5ID,ShiftToDayState5ID, " & _
            "dbo.tbRCL_ShiftDayState.DayStateTxt AS DayState, tbRCL_ShiftDayState_1.DayStateTxt AS ToDayState," & _
            "tbRCL_ShiftDayState_2.DayStateTxt AS DayState1, tbRCL_ShiftDayState_3.DayStateTxt AS ToDayState1," & _
            "tbRCL_ShiftDayState_4.DayStateTxt AS DayState2, tbRCL_ShiftDayState_5.DayStateTxt AS ToDayState2," & _
            "tbRCL_ShiftDayState_6.DayStateTxt AS DayState3, tbRCL_ShiftDayState_7.DayStateTxt AS ToDayState3," & _
            "tbRCL_ShiftDayState_8.DayStateTxt AS DayState4, tbRCL_ShiftDayState_9.DayStateTxt AS ToDayState4," & _
            "tbRCL_ShiftDayState_10.DayStateTxt AS DayState5, tbRCL_ShiftDayState_11.DayStateTxt AS ToDayState5 " & _
            "FROM dbo.tbRCL_Shifts INNER JOIN " & _
                "dbo.tbRCL_ShiftDayState ON dbo.tbRCL_Shifts.ShiftDayStateID = dbo.tbRCL_ShiftDayState.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_1 ON dbo.tbRCL_Shifts.ShiftToDayStateID = tbRCL_ShiftDayState_1.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_2 ON dbo.tbRCL_Shifts.ShiftDayState1ID = tbRCL_ShiftDayState_2.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_3 ON dbo.tbRCL_Shifts.ShiftToDayState1ID = tbRCL_ShiftDayState_3.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_4 ON dbo.tbRCL_Shifts.ShiftDayState2ID = tbRCL_ShiftDayState_4.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_5 ON dbo.tbRCL_Shifts.ShiftToDayState2ID = tbRCL_ShiftDayState_5.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_6 ON dbo.tbRCL_Shifts.ShiftDayState3ID = tbRCL_ShiftDayState_6.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_7 ON dbo.tbRCL_Shifts.ShiftToDayState3ID = tbRCL_ShiftDayState_7.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_8 ON dbo.tbRCL_Shifts.ShiftDayState4ID = tbRCL_ShiftDayState_8.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_9 ON dbo.tbRCL_Shifts.ShiftToDayState4ID = tbRCL_ShiftDayState_9.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_10 ON dbo.tbRCL_Shifts.ShiftDayState5ID = tbRCL_ShiftDayState_10.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_11 ON dbo.tbRCL_Shifts.ShiftToDayState5ID = tbRCL_ShiftDayState_11.DayStateID " & _
            "WHERE ShiftID=" & ShiftCode

        Try
            GetShiftInfo = True

            dt1 = ps1.GetDataTable(strConnection, sqlstr)

            mShiftID = dt1.DefaultView.Item(0).Item("ShiftID")
            mShiftTitle = dt1.DefaultView.Item(0).Item("ShiftTitle")
            mShiftType = dt1.DefaultView.Item(0).Item("ShiftType")

            mBeginHour = dt1.DefaultView.Item(0).Item("ShiftBeginHour")
            mBeginHourTxt = dt1.DefaultView.Item(0).Item("ShiftBeginHourTxt")
            mEndHour = dt1.DefaultView.Item(0).Item("ShiftEndHour")
            mEndHourTxt = dt1.DefaultView.Item(0).Item("ShiftEndHourTxt")
            mDayStateID = dt1.DefaultView.Item(0).Item("ShiftDayStateID")
            mDayState = dt1.DefaultView.Item(0).Item("DayState")
            mToDayStateID = dt1.DefaultView.Item(0).Item("ShiftToDayStateID")
            mToDayState = dt1.DefaultView.Item(0).Item("ToDayState")

            mBeginBreakTime1 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime1")
            mBeginBreakTimeTxt1 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt1")
            mDayState1ID = dt1.DefaultView.Item(0).Item("ShiftDayState1ID")
            mDayState1 = dt1.DefaultView.Item(0).Item("DayState1")
            mEndBreakTime1 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime1")
            mEndBreakTimeTxt1 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt1")
            mToDayState1ID = dt1.DefaultView.Item(0).Item("ShiftToDayState1ID")
            mToDayState1 = dt1.DefaultView.Item(0).Item("ToDayState1")

            mBeginBreakTime2 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime2")
            mBeginBreakTimeTxt2 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt2")
            mDayState2ID = dt1.DefaultView.Item(0).Item("ShiftDayState2ID")
            mDayState2 = dt1.DefaultView.Item(0).Item("DayState2")
            mEndBreakTime2 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime2")
            mEndBreakTimeTxt2 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt2")
            mToDayState2ID = dt1.DefaultView.Item(0).Item("ShiftToDayState2ID")
            mToDayState2 = dt1.DefaultView.Item(0).Item("ToDayState2")

            mBeginBreakTime3 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime3")
            mBeginBreakTimeTxt3 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt3")
            mDayState3ID = dt1.DefaultView.Item(0).Item("ShiftDayState3ID")
            mDayState3 = dt1.DefaultView.Item(0).Item("DayState3")
            mEndBreakTime3 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime3")
            mEndBreakTimeTxt3 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt3")
            mToDayState3ID = dt1.DefaultView.Item(0).Item("ShiftToDayState3ID")
            mToDayState3 = dt1.DefaultView.Item(0).Item("ToDayState3")

            mBeginBreakTime4 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime4")
            mBeginBreakTimeTxt4 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt4")
            mDayState4ID = dt1.DefaultView.Item(0).Item("ShiftDayState4ID")
            mDayState4 = dt1.DefaultView.Item(0).Item("DayState4")
            mEndBreakTime4 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime4")
            mEndBreakTimeTxt4 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt4")
            mToDayState4ID = dt1.DefaultView.Item(0).Item("ShiftToDayState4ID")
            mToDayState4 = dt1.DefaultView.Item(0).Item("ToDayState4")

            mBeginBreakTime5 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime5")
            mBeginBreakTimeTxt5 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt5")
            mDayState5ID = dt1.DefaultView.Item(0).Item("ShiftDayState5ID")
            mDayState5 = dt1.DefaultView.Item(0).Item("DayState5")
            mEndBreakTime5 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime5")
            mEndBreakTimeTxt5 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt5")
            mToDayState5ID = dt1.DefaultView.Item(0).Item("ShiftToDayState5ID")
            mToDayState5 = dt1.DefaultView.Item(0).Item("ToDayState5")

        Catch ex As Exception
            GetShiftInfo = False
        End Try

    End Function

    Public Function GetShiftInfo(ByVal MyHour As Integer, ByVal MDepartID As String, ByVal CnnStr As String) As Boolean
        Dim dt1 As New DataTable
        'Dim ps1 As New Persistent.DataAccess.DataAccess


        SqlStr = "SELECT ShiftID,ShiftTitle,ShiftType,ShiftBeginHour,ShiftBeginHourTxt,ShiftEndHour,ShiftEndHourTxt,ShiftDayStateID,ShiftToDayStateID, " & _
            "ShiftBeginBreakTime1,ShiftBeginBreakTimeTxt1,ShiftEndBreakTime1,ShiftEndBreakTimeTxt1,ShiftDayState1ID,ShiftToDayState1ID, " & _
            "ShiftBeginBreakTime2,ShiftBeginBreakTimeTxt2,ShiftEndBreakTime2,ShiftEndBreakTimeTxt2,ShiftDayState2ID,ShiftToDayState2ID, " & _
            "ShiftBeginBreakTime3,ShiftBeginBreakTimeTxt3,ShiftEndBreakTime3,ShiftEndBreakTimeTxt3,ShiftDayState3ID,ShiftToDayState3ID, " & _
            "ShiftBeginBreakTime4,ShiftBeginBreakTimeTxt4,ShiftEndBreakTime4,ShiftEndBreakTimeTxt4,ShiftDayState4ID,ShiftToDayState4ID, " & _
            "ShiftBeginBreakTime5,ShiftBeginBreakTimeTxt5,ShiftEndBreakTime5,ShiftEndBreakTimeTxt5,ShiftDayState5ID,ShiftToDayState5ID, " & _
            "dbo.tbRCL_ShiftDayState.DayStateTxt AS DayState, tbRCL_ShiftDayState_1.DayStateTxt AS ToDayState," & _
            "tbRCL_ShiftDayState_2.DayStateTxt AS DayState1, tbRCL_ShiftDayState_3.DayStateTxt AS ToDayState1," & _
            "tbRCL_ShiftDayState_4.DayStateTxt AS DayState2, tbRCL_ShiftDayState_5.DayStateTxt AS ToDayState2," & _
            "tbRCL_ShiftDayState_6.DayStateTxt AS DayState3, tbRCL_ShiftDayState_7.DayStateTxt AS ToDayState3," & _
            "tbRCL_ShiftDayState_8.DayStateTxt AS DayState4, tbRCL_ShiftDayState_9.DayStateTxt AS ToDayState4," & _
            "tbRCL_ShiftDayState_10.DayStateTxt AS DayState5, tbRCL_ShiftDayState_11.DayStateTxt AS ToDayState5 " & _
            "FROM dbo.tbRCL_Shifts INNER JOIN " & _
                "dbo.tbRCL_ShiftDayState ON dbo.tbRCL_Shifts.ShiftDayStateID = dbo.tbRCL_ShiftDayState.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_1 ON dbo.tbRCL_Shifts.ShiftToDayStateID = tbRCL_ShiftDayState_1.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_2 ON dbo.tbRCL_Shifts.ShiftDayState1ID = tbRCL_ShiftDayState_2.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_3 ON dbo.tbRCL_Shifts.ShiftToDayState1ID = tbRCL_ShiftDayState_3.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_4 ON dbo.tbRCL_Shifts.ShiftDayState2ID = tbRCL_ShiftDayState_4.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_5 ON dbo.tbRCL_Shifts.ShiftToDayState2ID = tbRCL_ShiftDayState_5.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_6 ON dbo.tbRCL_Shifts.ShiftDayState3ID = tbRCL_ShiftDayState_6.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_7 ON dbo.tbRCL_Shifts.ShiftToDayState3ID = tbRCL_ShiftDayState_7.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_8 ON dbo.tbRCL_Shifts.ShiftDayState4ID = tbRCL_ShiftDayState_8.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_9 ON dbo.tbRCL_Shifts.ShiftToDayState4ID = tbRCL_ShiftDayState_9.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_10 ON dbo.tbRCL_Shifts.ShiftDayState5ID = tbRCL_ShiftDayState_10.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_11 ON dbo.tbRCL_Shifts.ShiftToDayState5ID = tbRCL_ShiftDayState_11.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftAscribe_Machin ON dbo.tbRCL_Shifts.ShiftID = dbo.tbRCL_ShiftAscribe_Machin.AscShiftID " & _
            "WHERE  (dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID ='" & MDepartID & "') AND (dbo.tbRCL_Shifts.ShiftBeginHour <=" & MyHour & ") AND (dbo.tbRCL_Shifts.ShiftEndHour >=" & MyHour & ")"

        Try
            GetShiftInfo = True

            dt1 = ps1.GetDataTable(strConnection, sqlstr)

            mShiftID = dt1.DefaultView.Item(0).Item("ShiftID")
            mShiftTitle = dt1.DefaultView.Item(0).Item("ShiftTitle")
            mShiftType = dt1.DefaultView.Item(0).Item("ShiftType")

            mBeginHour = dt1.DefaultView.Item(0).Item("ShiftBeginHour")
            mBeginHourTxt = dt1.DefaultView.Item(0).Item("ShiftBeginHourTxt")
            mEndHour = dt1.DefaultView.Item(0).Item("ShiftEndHour")
            mEndHourTxt = dt1.DefaultView.Item(0).Item("ShiftEndHourTxt")
            mDayStateID = dt1.DefaultView.Item(0).Item("ShiftDayStateID")
            mDayState = dt1.DefaultView.Item(0).Item("DayState")
            mToDayStateID = dt1.DefaultView.Item(0).Item("ShiftToDayStateID")
            mToDayState = dt1.DefaultView.Item(0).Item("ToDayState")

            mBeginBreakTime1 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime1")
            mBeginBreakTimeTxt1 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt1")
            mDayState1ID = dt1.DefaultView.Item(0).Item("ShiftDayState1ID")
            mDayState1 = dt1.DefaultView.Item(0).Item("DayState1")
            mEndBreakTime1 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime1")
            mEndBreakTimeTxt1 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt1")
            mToDayState1ID = dt1.DefaultView.Item(0).Item("ShiftToDayState1ID")
            mToDayState1 = dt1.DefaultView.Item(0).Item("ToDayState1")

            mBeginBreakTime2 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime2")
            mBeginBreakTimeTxt2 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt2")
            mDayState2ID = dt1.DefaultView.Item(0).Item("ShiftDayState2ID")
            mDayState2 = dt1.DefaultView.Item(0).Item("DayState2")
            mEndBreakTime2 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime2")
            mEndBreakTimeTxt2 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt2")
            mToDayState2ID = dt1.DefaultView.Item(0).Item("ShiftToDayState2ID")
            mToDayState2 = dt1.DefaultView.Item(0).Item("ToDayState2")

            mBeginBreakTime3 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime3")
            mBeginBreakTimeTxt3 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt3")
            mDayState3ID = dt1.DefaultView.Item(0).Item("ShiftDayState3ID")
            mDayState3 = dt1.DefaultView.Item(0).Item("DayState3")
            mEndBreakTime3 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime3")
            mEndBreakTimeTxt3 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt3")
            mToDayState3ID = dt1.DefaultView.Item(0).Item("ShiftToDayState3ID")
            mToDayState3 = dt1.DefaultView.Item(0).Item("ToDayState3")

            mBeginBreakTime4 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime4")
            mBeginBreakTimeTxt4 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt4")
            mDayState4ID = dt1.DefaultView.Item(0).Item("ShiftDayState4ID")
            mDayState4 = dt1.DefaultView.Item(0).Item("DayState4")
            mEndBreakTime4 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime4")
            mEndBreakTimeTxt4 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt4")
            mToDayState4ID = dt1.DefaultView.Item(0).Item("ShiftToDayState4ID")
            mToDayState4 = dt1.DefaultView.Item(0).Item("ToDayState4")

            mBeginBreakTime5 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime5")
            mBeginBreakTimeTxt5 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt5")
            mDayState5ID = dt1.DefaultView.Item(0).Item("ShiftDayState5ID")
            mDayState5 = dt1.DefaultView.Item(0).Item("DayState5")
            mEndBreakTime5 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime5")
            mEndBreakTimeTxt5 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt5")
            mToDayState5ID = dt1.DefaultView.Item(0).Item("ShiftToDayState5ID")
            mToDayState5 = dt1.DefaultView.Item(0).Item("ToDayState5")

        Catch ex As Exception
            GetShiftInfo = False
        End Try

    End Function

    Public Function GetShiftInfo(Optional ByVal CnnStr As String = "") As DataTable
        Dim dt1 As New DataTable
        'Dim ps1 As New Persistent.DataAccess.DataAccess



        SqlStr = "SELECT ShiftID,ShiftTitle,ShiftType,ShiftTypeProp,ShiftTypeID,ShiftBeginHour,ShiftBeginHourTxt,ShiftEndHour,ShiftEndHourTxt,ShiftDayStateID,ShiftToDayStateID, " & _
            "ShiftBeginBreakTime1,ShiftBeginBreakTimeTxt1,ShiftEndBreakTime1,ShiftEndBreakTimeTxt1,ShiftDayState1ID,ShiftToDayState1ID, " & _
            "ShiftBeginBreakTime2,ShiftBeginBreakTimeTxt2,ShiftEndBreakTime2,ShiftEndBreakTimeTxt2,ShiftDayState2ID,ShiftToDayState2ID, " & _
            "ShiftBeginBreakTime3,ShiftBeginBreakTimeTxt3,ShiftEndBreakTime3,ShiftEndBreakTimeTxt3,ShiftDayState3ID,ShiftToDayState3ID, " & _
            "ShiftBeginBreakTime4,ShiftBeginBreakTimeTxt4,ShiftEndBreakTime4,ShiftEndBreakTimeTxt4,ShiftDayState4ID,ShiftToDayState4ID, " & _
            "ShiftBeginBreakTime5,ShiftBeginBreakTimeTxt5,ShiftEndBreakTime5,ShiftEndBreakTimeTxt5,ShiftDayState5ID,ShiftToDayState5ID, " & _
            "dbo.tbRCL_ShiftDayState.DayStateTxt AS DayState, tbRCL_ShiftDayState_1.DayStateTxt AS ToDayState," & _
            "tbRCL_ShiftDayState_2.DayStateTxt AS DayState1, tbRCL_ShiftDayState_3.DayStateTxt AS ToDayState1," & _
            "tbRCL_ShiftDayState_4.DayStateTxt AS DayState2, tbRCL_ShiftDayState_5.DayStateTxt AS ToDayState2," & _
            "tbRCL_ShiftDayState_6.DayStateTxt AS DayState3, tbRCL_ShiftDayState_7.DayStateTxt AS ToDayState3," & _
            "tbRCL_ShiftDayState_8.DayStateTxt AS DayState4, tbRCL_ShiftDayState_9.DayStateTxt AS ToDayState4," & _
            "tbRCL_ShiftDayState_10.DayStateTxt AS DayState5, tbRCL_ShiftDayState_11.DayStateTxt AS ToDayState5 " & _
            "FROM dbo.tbRCL_Shifts INNER JOIN " & _
                "dbo.tbRCL_ShiftDayState ON dbo.tbRCL_Shifts.ShiftDayStateID = dbo.tbRCL_ShiftDayState.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_1 ON dbo.tbRCL_Shifts.ShiftToDayStateID = tbRCL_ShiftDayState_1.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_2 ON dbo.tbRCL_Shifts.ShiftDayState1ID = tbRCL_ShiftDayState_2.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_3 ON dbo.tbRCL_Shifts.ShiftToDayState1ID = tbRCL_ShiftDayState_3.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_4 ON dbo.tbRCL_Shifts.ShiftDayState2ID = tbRCL_ShiftDayState_4.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_5 ON dbo.tbRCL_Shifts.ShiftToDayState2ID = tbRCL_ShiftDayState_5.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_6 ON dbo.tbRCL_Shifts.ShiftDayState3ID = tbRCL_ShiftDayState_6.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_7 ON dbo.tbRCL_Shifts.ShiftToDayState3ID = tbRCL_ShiftDayState_7.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_8 ON dbo.tbRCL_Shifts.ShiftDayState4ID = tbRCL_ShiftDayState_8.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_9 ON dbo.tbRCL_Shifts.ShiftToDayState4ID = tbRCL_ShiftDayState_9.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_10 ON dbo.tbRCL_Shifts.ShiftDayState5ID = tbRCL_ShiftDayState_10.DayStateID INNER JOIN " & _
                 "dbo.tbRCL_ShiftDayState tbRCL_ShiftDayState_11 ON dbo.tbRCL_Shifts.ShiftToDayState5ID = tbRCL_ShiftDayState_11.DayStateID " & _
            "WHERE 1=1 " & _
            IIf(nz1.NZ(Me.ShiftID, 0) = 0, "", " AND ShiftID=" & Me.ShiftID) & _
        IIf(nz1.NZ(Me.ShiftTypeProp.ShiftTypeID, 0) = 0, "", " AND ShiftTypeID=" & Me.ShiftTypeProp.ShiftTypeID)

        dt1 = ps1.GetDataTable(strConnection, sqlstr)
        GetShiftInfo = dt1

        If dt1.DefaultView.Count > 0 Then

            mShiftID = dt1.DefaultView.Item(0).Item("ShiftID")
            mShiftTitle = dt1.DefaultView.Item(0).Item("ShiftTitle")
            mShiftType = dt1.DefaultView.Item(0).Item("ShiftType")
            mShiftTypeProp.ShiftTypeID = dt1.DefaultView.Item(0).Item("ShiftTypeID")

            mBeginHour = dt1.DefaultView.Item(0).Item("ShiftBeginHour")
            mBeginHourTxt = dt1.DefaultView.Item(0).Item("ShiftBeginHourTxt")
            mEndHour = dt1.DefaultView.Item(0).Item("ShiftEndHour")
            mEndHourTxt = dt1.DefaultView.Item(0).Item("ShiftEndHourTxt")
            mDayStateID = dt1.DefaultView.Item(0).Item("ShiftDayStateID")
            mDayState = dt1.DefaultView.Item(0).Item("DayState")
            mToDayStateID = dt1.DefaultView.Item(0).Item("ShiftToDayStateID")
            mToDayState = dt1.DefaultView.Item(0).Item("ToDayState")

            mBeginBreakTime1 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime1")
            mBeginBreakTimeTxt1 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt1")
            mDayState1ID = dt1.DefaultView.Item(0).Item("ShiftDayState1ID")
            mDayState1 = dt1.DefaultView.Item(0).Item("DayState1")
            mEndBreakTime1 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime1")
            mEndBreakTimeTxt1 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt1")
            mToDayState1ID = dt1.DefaultView.Item(0).Item("ShiftToDayState1ID")
            mToDayState1 = dt1.DefaultView.Item(0).Item("ToDayState1")

            mBeginBreakTime2 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime2")
            mBeginBreakTimeTxt2 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt2")
            mDayState2ID = dt1.DefaultView.Item(0).Item("ShiftDayState2ID")
            mDayState2 = dt1.DefaultView.Item(0).Item("DayState2")
            mEndBreakTime2 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime2")
            mEndBreakTimeTxt2 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt2")
            mToDayState2ID = dt1.DefaultView.Item(0).Item("ShiftToDayState2ID")
            mToDayState2 = dt1.DefaultView.Item(0).Item("ToDayState2")

            mBeginBreakTime3 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime3")
            mBeginBreakTimeTxt3 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt3")
            mDayState3ID = dt1.DefaultView.Item(0).Item("ShiftDayState3ID")
            mDayState3 = dt1.DefaultView.Item(0).Item("DayState3")
            mEndBreakTime3 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime3")
            mEndBreakTimeTxt3 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt3")
            mToDayState3ID = dt1.DefaultView.Item(0).Item("ShiftToDayState3ID")
            mToDayState3 = dt1.DefaultView.Item(0).Item("ToDayState3")

            mBeginBreakTime4 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime4")
            mBeginBreakTimeTxt4 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt4")
            mDayState4ID = dt1.DefaultView.Item(0).Item("ShiftDayState4ID")
            mDayState4 = dt1.DefaultView.Item(0).Item("DayState4")
            mEndBreakTime4 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime4")
            mEndBreakTimeTxt4 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt4")
            mToDayState4ID = dt1.DefaultView.Item(0).Item("ShiftToDayState4ID")
            mToDayState4 = dt1.DefaultView.Item(0).Item("ToDayState4")

            mBeginBreakTime5 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTime5")
            mBeginBreakTimeTxt5 = dt1.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt5")
            mDayState5ID = dt1.DefaultView.Item(0).Item("ShiftDayState5ID")
            mDayState5 = dt1.DefaultView.Item(0).Item("DayState5")
            mEndBreakTime5 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTime5")
            mEndBreakTimeTxt5 = dt1.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt5")
            mToDayState5ID = dt1.DefaultView.Item(0).Item("ShiftToDayState5ID")
            mToDayState5 = dt1.DefaultView.Item(0).Item("ToDayState5")
        End If
    End Function

    Friend Function NewShift(ByVal ShiftType As Integer, ByVal ShiftTitle As String, ByVal SectionId As Integer, TimeKolEsterahat As Integer, TimeKarkard As Integer, TimeKolKarkard As Integer) As Boolean
        'Dim ps1 As New Persistent.DataAccess.DataAccess
        'Dim tm1 As New IraniDate.IraniDate.Times

        ps1.Sp_AddParam("@ShiftTitle", SqlDbType.VarChar, ShiftTitle, ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftType", SqlDbType.Int, ShiftType, ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginHour", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(1, 1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginHourTxt", SqlDbType.Char, Hours(1, 1), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndHour", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(1, 2)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndHourTxt", SqlDbType.Char, Hours(1, 2), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftDayStateID", SqlDbType.TinyInt, CInt(Hours(1, 3)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftToDayStateID", SqlDbType.TinyInt, CInt(Hours(1, 4)), ParameterDirection.Input)

        ps1.Sp_AddParam("@ShiftBeginBreakTime1", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(2, 1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginBreakTimeTxt1", SqlDbType.Char, Hours(2, 1), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTime1", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(2, 2)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTimeTxt1", SqlDbType.Char, Hours(2, 2), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftDayState1ID", SqlDbType.TinyInt, CInt(Hours(2, 3)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftToDayState1ID", SqlDbType.TinyInt, CInt(Hours(2, 4)), ParameterDirection.Input)

        ps1.Sp_AddParam("@ShiftBeginBreakTime2", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(3, 1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginBreakTimeTxt2", SqlDbType.Char, Hours(3, 1), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTime2", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(3, 2)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTimeTxt2", SqlDbType.Char, Hours(3, 2), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftDayState2ID", SqlDbType.TinyInt, CInt(Hours(3, 3)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftToDayState2ID", SqlDbType.TinyInt, CInt(Hours(3, 4)), ParameterDirection.Input)

        ps1.Sp_AddParam("@ShiftBeginBreakTime3", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(4, 1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginBreakTimeTxt3", SqlDbType.Char, Hours(4, 1), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTime3", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(4, 2)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTimeTxt3", SqlDbType.Char, Hours(4, 2), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftDayState3ID", SqlDbType.TinyInt, CInt(Hours(4, 3)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftToDayState3ID", SqlDbType.TinyInt, CInt(Hours(4, 4)), ParameterDirection.Input)

        ps1.Sp_AddParam("@ShiftBeginBreakTime4", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(5, 1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginBreakTimeTxt4", SqlDbType.Char, Hours(5, 1), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTime4", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(5, 2)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTimeTxt4", SqlDbType.Char, Hours(5, 2), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftDayState4ID", SqlDbType.TinyInt, CInt(Hours(5, 3)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftToDayState4ID", SqlDbType.TinyInt, CInt(Hours(5, 4)), ParameterDirection.Input)

        ps1.Sp_AddParam("@ShiftBeginBreakTime5", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(6, 1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginBreakTimeTxt5", SqlDbType.Char, Hours(6, 1), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTime5", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(6, 2)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTimeTxt5", SqlDbType.Char, Hours(6, 2), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftDayState5ID", SqlDbType.TinyInt, CInt(Hours(6, 3)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftToDayState5ID", SqlDbType.TinyInt, CInt(Hours(6, 4)), ParameterDirection.Input)


        ps1.Sp_AddParam("@TimeKolEsterahat", SqlDbType.Int, TimeKolEsterahat, ParameterDirection.Input)
        ps1.Sp_AddParam("@TimeKarkard", SqlDbType.Int, TimeKarkard, ParameterDirection.Input)
        ps1.Sp_AddParam("@TimeKolKarkard", SqlDbType.Int, TimeKolKarkard, ParameterDirection.Input)



        ps1.Sp_AddParam("@SectionId", SqlDbType.SmallInt, SectionId, ParameterDirection.Input)

        Try
            ps1.Sp_Exe("spRCL_ShiftsIns", strConnection)
            NewShift = True
        Catch ex As Exception
            NewShift = False
        End Try
        ps1.ClearParameter()

    End Function

    Friend Function EditShift(ByVal ShiftID As Int16, ByVal ShiftType As String, ByVal ShiftTitle As String, ByVal SectionId As Int32, TimeKolEsterahat As Integer, TimeKarkard As Integer, TimeKolKarkard As Integer) As Boolean
        'Dim ps1 As New Persistent.DataAccess.DataAccess
        'Dim tm1 As New IraniDate.IraniDate.Times
        Dim breakTime As Integer
        Dim AscAllTime As Integer


        ps1.Sp_AddParam("@SectionId", SqlDbType.TinyInt, SectionId, ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftID", SqlDbType.TinyInt, ShiftID, ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftTitle", SqlDbType.VarChar, ShiftTitle, ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftType", SqlDbType.Char, ShiftType, ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginHour", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(1, 1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginHourTxt", SqlDbType.Char, Hours(1, 1), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndHour", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(1, 2)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndHourTxt", SqlDbType.Char, Hours(1, 2), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftDayStateID", SqlDbType.TinyInt, CInt(Hours(1, 3)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftToDayStateID", SqlDbType.TinyInt, CInt(Hours(1, 4)), ParameterDirection.Input)


        If CInt(Hours(1, 4)) <> CInt(Hours(1, 3)) Then
            AscAllTime = (1440 + tm1.GetTimeMinute(Hours(1, 2))) - tm1.GetTimeMinute(Hours(1, 1))
        Else
            AscAllTime = tm1.GetTimeMinute(Hours(1, 2)) - tm1.GetTimeMinute(Hours(1, 1))
        End If


        ps1.Sp_AddParam("@ShiftBeginBreakTime1", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(2, 1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginBreakTimeTxt1", SqlDbType.Char, Hours(2, 1), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTime1", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(2, 2)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTimeTxt1", SqlDbType.Char, Hours(2, 2), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftDayState1ID", SqlDbType.TinyInt, CInt(Hours(2, 3)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftToDayState1ID", SqlDbType.TinyInt, CInt(Hours(2, 4)), ParameterDirection.Input)

        If CInt(Hours(2, 4)) <> CInt(Hours(2, 3)) Then
            breakTime = (1440 - tm1.GetTimeMinute(Hours(2, 2))) + tm1.GetTimeMinute(Hours(2, 1))
        Else
            breakTime = tm1.GetTimeMinute(Hours(2, 2)) - tm1.GetTimeMinute(Hours(2, 1))
        End If

        ps1.Sp_AddParam("@ShiftBeginBreakTime2", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(3, 1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginBreakTimeTxt2", SqlDbType.Char, Hours(3, 1), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTime2", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(3, 2)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTimeTxt2", SqlDbType.Char, Hours(3, 2), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftDayState2ID", SqlDbType.TinyInt, CInt(Hours(3, 3)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftToDayState2ID", SqlDbType.TinyInt, CInt(Hours(3, 4)), ParameterDirection.Input)

        If CInt(Hours(3, 3)) <> CInt(Hours(3, 4)) Then
            breakTime = (1440 - tm1.GetTimeMinute(Hours(3, 1))) + tm1.GetTimeMinute(Hours(3, 2)) + breakTime
        Else
            breakTime = tm1.GetTimeMinute(Hours(3, 2)) - tm1.GetTimeMinute(Hours(3, 1)) + breakTime
        End If

        ps1.Sp_AddParam("@ShiftBeginBreakTime3", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(4, 1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginBreakTimeTxt3", SqlDbType.Char, Hours(4, 1), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTime3", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(4, 2)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTimeTxt3", SqlDbType.Char, Hours(4, 2), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftDayState3ID", SqlDbType.TinyInt, CInt(Hours(4, 3)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftToDayState3ID", SqlDbType.TinyInt, CInt(Hours(4, 4)), ParameterDirection.Input)


        If CInt(Hours(4, 3)) <> CInt(Hours(4, 4)) Then
            breakTime = (1440 - tm1.GetTimeMinute(Hours(4, 1))) + tm1.GetTimeMinute(Hours(4, 2)) + breakTime
        Else
            breakTime = tm1.GetTimeMinute(Hours(4, 2)) - tm1.GetTimeMinute(Hours(4, 1)) + breakTime
        End If


        ps1.Sp_AddParam("@ShiftBeginBreakTime4", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(5, 1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginBreakTimeTxt4", SqlDbType.Char, Hours(5, 1), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTime4", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(5, 2)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTimeTxt4", SqlDbType.Char, Hours(5, 2), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftDayState4ID", SqlDbType.TinyInt, CInt(Hours(5, 3)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftToDayState4ID", SqlDbType.TinyInt, CInt(Hours(5, 4)), ParameterDirection.Input)


        If CInt(Hours(5, 3)) <> CInt(Hours(5, 4)) Then
            breakTime = (1440 - tm1.GetTimeMinute(Hours(5, 1))) + tm1.GetTimeMinute(Hours(5, 2)) + breakTime
        Else
            breakTime = tm1.GetTimeMinute(Hours(5, 2)) - tm1.GetTimeMinute(Hours(5, 1)) + breakTime
        End If

        ps1.Sp_AddParam("@ShiftBeginBreakTime5", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(6, 1)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftBeginBreakTimeTxt5", SqlDbType.Char, Hours(6, 1), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTime5", SqlDbType.SmallInt, tm1.GetTimeMinute(Hours(6, 2)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftEndBreakTimeTxt5", SqlDbType.Char, Hours(6, 2), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftDayState5ID", SqlDbType.TinyInt, CInt(Hours(6, 3)), ParameterDirection.Input)
        ps1.Sp_AddParam("@ShiftToDayState5ID", SqlDbType.TinyInt, CInt(Hours(6, 4)), ParameterDirection.Input)

        ps1.Sp_AddParam("@TimeKolEsterahat", SqlDbType.Int, TimeKolEsterahat, ParameterDirection.Input)
        ps1.Sp_AddParam("@TimeKarkard", SqlDbType.Int, TimeKarkard, ParameterDirection.Input)
        ps1.Sp_AddParam("@TimeKolKarkard", SqlDbType.Int, TimeKolKarkard, ParameterDirection.Input)



        If CInt(Hours(6, 3)) <> CInt(Hours(6, 4)) Then
            breakTime = (1440 - tm1.GetTimeMinute(Hours(6, 1))) + tm1.GetTimeMinute(Hours(6, 2)) + breakTime
        Else
            breakTime = tm1.GetTimeMinute(Hours(6, 2)) - tm1.GetTimeMinute(Hours(6, 1)) + breakTime
        End If


        ps1.Sp_AddParam("@AscAllTime", SqlDbType.Int, AscAllTime, ParameterDirection.Input)
        ps1.Sp_AddParam("@AscNetBreakTime", SqlDbType.Int, breakTime, ParameterDirection.Input)

        Try

            ps1.Sp_Exe("spRCL_ShiftsUpd", strConnection)


            EditShift = True
        Catch ex As Exception
            EditShift = False
        End Try
        ps1.ClearParameter()
    End Function

    Friend Function DelShift(ByVal ShiftID As Int16) As Boolean
        'Dim ps1 As New Persistent.DataAccess.DataAccess
        ps1.Sp_AddParam("@ShiftID", SqlDbType.TinyInt, ShiftID, ParameterDirection.Input)
        Try
            ps1.Sp_Exe("spRCL_ShiftsDel", strConnection)
            DelShift = True
        Catch ex As Exception
            DelShift = False
        End Try
        ps1.ClearParameter()
    End Function

    Public Function GetEndTime(ByVal BeginHour As String, ByVal TimeLength As String, ByVal MDepartID As String, ByVal cnnStr As String, ByRef DayState As String) As String
        Dim BHour, TLength, EHour As Int16
        Dim id1 As New IraniDate.IraniDate.Times

        Dim dt1 As DataTable
        Dim dt2 As DataTable
        Dim wstr1, wstr2 As String
        'Dim ps1 As New Persistent.DataAccess.DataAccess

        Dim sh1 As New Shift


        DayState = "«„—Ê“"

        BHour = id1.GetTimeMinute(BeginHour)
        TLength = id1.GetTimeMinute(TimeLength)
        EHour = BHour + TLength

        wstr1 = "SELECT ShiftID FROM vwRCL_ShiftMinMaxInMDepart_Machin WHERE BeginHour<=" & EHour & " AND EndHour>=" & EHour & " AND AscMDepartID='" & MDepartID & "'"
        dt1 = ps1.GetDataTable(strConnection, wstr1)

        If dt1.DefaultView.Count > 0 Then

            If sh1.GetShiftInfo(dt1.DefaultView.Item(0).Item("ShiftID")) Then
                If EHour >= 1440 Then
                    EHour = EHour - 1440
                    DayState = "›—œ«"
                End If
                GetEndTime = id1.GetTimeHour(EHour)

            End If
        Else
            wstr2 = "SELECT MDShiftEnd,MDShiftEndTxt,MDShiftEDayStateID FROM tbRCL_ShiftMDepart_Machin WHERE MDShiftMDepartID='" & MDepartID & "'"
            dt2 = ps1.GetDataTable(strConnection, wstr2)
            If EHour > 1440 Then
                EHour = EHour - 1440
                DayState = "›—œ«"
            End If
            GetEndTime = dt2.DefaultView.Item(0).Item("MDShiftEndTxt")
            'If GetEndTime = "24:00" Then
            '    GetEndTime = "00:00"
            'End If
            'GetEndTime = id1.GetTimeHour(EHour)

            MsgBox("”«⁄  Å«Ì«‰ Œ«—Ã «“ ‘Ì›  ﬁ—«— œ«—œ", MsgBoxStyle.Critical, "Œÿ«")
        End If
    End Function

    Public Function GetTimeLength(ByVal BeginHour As String, ByVal EndHour As String) As String ' „œ  “„«‰ »Ì‰ œÊ ”«⁄  —« »—„Ìê—œ«‰œ
        Dim BHour, TLength, EHour As Int16
        Dim id1 As New IraniDate.IraniDate.Times

        BHour = id1.GetTimeMinute(BeginHour)
        EHour = id1.GetTimeMinute(EndHour)

        If EHour < BHour Then
            TLength = (1440 + EHour) - BHour
            GetTimeLength = id1.GetTimeHour(TLength)
        ElseIf EHour >= BHour Then
            TLength = EHour - BHour
            GetTimeLength = id1.GetTimeHour(TLength)
        End If
    End Function


    Public Function GetShiftListWithInfo() As DataTable
        SqlStr = "SELECT  *  FROM [HumanResource].[dbo].[tbRCL_Shifts] "
        Dt = Pers.GetDataTable(strConnection, SqlStr)

        Return Dt

    End Function


    Public Function GetShiftInfoByShiftID(ByVal ShiftID As Integer) As DataTable
        SqlStr = "SELECT  *  FROM [HumanResource].[dbo].[tbRCL_Shifts] where ShiftID='" & ShiftID & "'"
        Dt = Pers.GetDataTable(strConnection, SqlStr)


        Return Dt

    End Function

    Public Function TestHourInShift(ByVal myHour As String, ByVal MDepartID As String, ByVal cnnStr As String) As Boolean '¬“„«Ì‘ „Ì ﬂ‰œ ﬂÂ ”«⁄  Ê«—œ ‘œÂ œ— »«“Â ‘Ì› Â«Ì  ⁄—Ì› ‘œÂ »—«Ì Ê«Õœ »«‘œ
        Dim dt1 As New DataTable
        'Dim ps1 As New Persistent.DataAccess.DataAccess
        Dim sqlstr As String = ""

        Dim MHour As Int16
        Dim id1 As New IraniDate.IraniDate.Times

        MHour = id1.GetTimeMinute(myHour)

        sqlstr = "SELECT COUNT(ShiftID) AS TimeIsInShift FROM vwRCL_ShiftMinMaxInMDepart_Machin " & _
            "WHERE BeginHour <=" & MHour & " AND EndHour >=" & MHour & " AND AscMDepartID ='" & MDepartID & "'"

        Try
            dt1 = ps1.GetDataTable(strConnection, sqlstr)
            If dt1.DefaultView.Item(0).Item("TimeIsInShift") = 1 Then
                TestHourInShift = True
            Else
                TestHourInShift = False
            End If
        Catch ex As Exception

        End Try
    End Function

End Class