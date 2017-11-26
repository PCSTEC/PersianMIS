Namespace Calendar
    Public Class Calendar
        Public DayStArray(7, 2) As Int16

        Dim mCalID As Int16
        Dim mRemark As String
        Dim mIraniDate As String
        Dim mLatinDate As String
        Dim mDayStatusID As Int16
        Dim mWeekProp As CalendarWeek
        Dim mIraniDayNumInYear As Int16
        Dim mLatinDayNumInYear As Int16
        Dim mIraniYear As Int16
        Dim mLatinYear As Int16
        Dim mIraniMonth As CalendarMonthIrani
        Dim mLatinMonth As CalendarMonthLatin
        Dim mIraniDayNum As Int16
        Dim mLatinDayNum As Int16
        Dim mIraniWeekNum As Int16
        Dim mLatinWeekNum As Int16

        Public Property CalID() As Int16
            Get
                Return mCalID
            End Get
            Set(ByVal Value As Int16)
                mCalID = Value
            End Set
        End Property

        Public Property Remark() As String
            Get
                Return mRemark
            End Get
            Set(ByVal Value As String)
                mRemark = Value
            End Set
        End Property

        Public Property IraniDate() As String
            Get
                Return mIraniDate
            End Get
            Set(ByVal Value As String)
                mIraniDate = Value
            End Set
        End Property

        Public Property LatinDate() As String
            Get
                Return mLatinDate
            End Get
            Set(ByVal Value As String)
                mLatinDate = Value
            End Set
        End Property

        Public Property DayStatusID() As Int16
            Get
                Return mDayStatusID
            End Get
            Set(ByVal Value As Int16)
                mDayStatusID = Value
            End Set
        End Property

        Public Property WeekProp() As CalendarWeek
            Get
                Return mWeekProp
            End Get
            Set(ByVal Value As CalendarWeek)
                mWeekProp = Value
            End Set
        End Property

        Public Property IraniDayNumInYear() As Int16
            Get
                Return mIraniDayNumInYear
            End Get
            Set(ByVal Value As Int16)
                mIraniDayNumInYear = Value
            End Set
        End Property

        Public Property LatinDayNumInYear() As Int16
            Get
                Return mLatinDayNumInYear
            End Get
            Set(ByVal Value As Int16)
                mLatinDayNumInYear = Value
            End Set
        End Property

        Public Property IraniYear() As Int16
            Get
                Return mIraniYear
            End Get
            Set(ByVal Value As Int16)
                mIraniYear = Value
            End Set
        End Property

        Public Property LatinYear() As Int16
            Get
                Return mLatinYear
            End Get
            Set(ByVal Value As Int16)
                mLatinYear = Value
            End Set
        End Property

        Public Property IraniMonth() As CalendarMonthIrani
            Get
                Return mIraniMonth
            End Get
            Set(ByVal Value As CalendarMonthIrani)
                mIraniMonth = Value
            End Set
        End Property

        Public Property LatinMonth() As CalendarMonthLatin
            Get
                Return mLatinMonth
            End Get
            Set(ByVal Value As CalendarMonthLatin)
                mLatinMonth = Value
            End Set
        End Property

        Public Property IraniDayNum() As Int16
            Get
                Return mIraniDayNum
            End Get
            Set(ByVal Value As Int16)
                mIraniDayNum = Value
            End Set
        End Property

        Public Property LatinDayNum() As Int16
            Get
                Return mLatinDayNum
            End Get
            Set(ByVal Value As Int16)
                mLatinDayNum = Value
            End Set
        End Property

        Public Property IraniWeekNum() As Int16
            Get
                Return mIraniWeekNum
            End Get
            Set(ByVal Value As Int16)
                mIraniWeekNum = Value
            End Set
        End Property

        Public Property LatinWeekNum() As Int16
            Get
                Return mLatinWeekNum
            End Get
            Set(ByVal Value As Int16)
                mLatinWeekNum = Value
            End Set
        End Property

        Public Function GetCalendar(ByVal IYear As Int16, ByVal cnnStr As String) As DataTable
            Dim dt1 As New DataTable
            'Dim ps1 As New Persistent.DataAccess.DataAccess
            Dim sqlstr As String = ""
            sqlstr = "SELECT CalID,CalRemark,CalIraniDate,CalLatinDate,CalDayStatusID,DayStatusName,CalWeekID,CalIraniDayNumInYear, " & _
                "CalIraniYearID,CalLatinYearID,CalIraniMonthID,CalLatinMonthID,CalIraniDayNum,CalLatinDayNum,CalIraniWeekNum " & _
                "FROM tbRCL_Calendar_Machin INNER JOIN tbRCL_CalendarDayStatus ON CalDayStatusID=DayStatusID " & _
                "WHERE CalIraniYearID=" & IYear



            Try
                GetCalendar = ps1.GetDataTable(strConnection, sqlstr)
            Catch ex As Exception

            End Try
        End Function

        Public Function GetDayCount(ByVal DateDown As String, ByVal DateUp As String, ByVal DaySt As DayState) As Integer
            Dim sqlstr As String
            Dim dt As New DataTable
            sqlstr = _
            "SELECT     dbo.tbRCL_Calendar_Machin.CalID, dbo.tbRCL_Calendar_Machin.CalRemark, dbo.tbRCL_Calendar_Machin.CalIraniDate, dbo.tbRCL_Calendar_Machin.CalLatinDate,  " & _
            "                      dbo.tbRCL_Calendar_Machin.CalDayStatusID, dbo.tbRCL_CalendarDayStatus.DayStatusName, dbo.tbRCL_Calendar_Machin.CalWeekID,  " & _
            "                      dbo.tbRCL_Calendar_Machin.CalIraniDayNumInYear, dbo.tbRCL_Calendar_Machin.CalIraniYearID, dbo.tbRCL_Calendar_Machin.CalLatinYearID,  " & _
            "                      dbo.tbRCL_Calendar_Machin.CalIraniMonthID, dbo.tbRCL_Calendar_Machin.CalLatinMonthID, dbo.tbRCL_Calendar_Machin.CalIraniDayNum,  " & _
            "                      dbo.tbRCL_Calendar_Machin.CalLatinDayNum, dbo.tbRCL_Calendar_Machin.CalIraniWeekNum " & _
            "FROM         dbo.tbRCL_Calendar_Machin INNER JOIN " & _
            "                      dbo.tbRCL_CalendarDayStatus ON dbo.tbRCL_Calendar_Machin.CalDayStatusID = dbo.tbRCL_CalendarDayStatus.DayStatusID " & _
            "WHERE   (1=1) " & IIf(DaySt = 0, "", " AND  (dbo.tbRCL_Calendar_Machin.CalDayStatusID =" & DaySt & " )") & " AND (dbo.tbRCL_Calendar_Machin.CalIraniDate >= '" & DateDown & "' AND dbo.tbRCL_Calendar_Machin.CalIraniDate <= '" & DateUp & "')"

            dt = ps1.GetDataTable(strConnection, sqlstr)
            GetDayCount = dt.DefaultView.Count
        End Function

        Public Function GetDayMonthCount(ByVal MyDate As String, ByVal DaySt As DayState) As Integer
            Dim sqlstr As String
            Dim dt As New DataTable
            Dim DateDown, DateUp As String
            DateUp = Mid(MyDate, 1, 7) + "/31"
            DateDown = Mid(MyDate, 1, 7) + "/01"
            sqlstr = _
            "SELECT     dbo.tbRCL_Calendar_Machin.CalID, dbo.tbRCL_Calendar_Machin.CalRemark, dbo.tbRCL_Calendar_Machin.CalIraniDate, dbo.tbRCL_Calendar_Machin.CalLatinDate,  " & _
            "                      dbo.tbRCL_Calendar_Machin.CalDayStatusID, dbo.tbRCL_CalendarDayStatus.DayStatusName, dbo.tbRCL_Calendar_Machin.CalWeekID,  " & _
            "                      dbo.tbRCL_Calendar_Machin.CalIraniDayNumInYear, dbo.tbRCL_Calendar_Machin.CalIraniYearID, dbo.tbRCL_Calendar_Machin.CalLatinYearID,  " & _
            "                      dbo.tbRCL_Calendar_Machin.CalIraniMonthID, dbo.tbRCL_Calendar_Machin.CalLatinMonthID, dbo.tbRCL_Calendar_Machin.CalIraniDayNum,  " & _
            "                      dbo.tbRCL_Calendar_Machin.CalLatinDayNum, dbo.tbRCL_Calendar_Machin.CalIraniWeekNum " & _
            "FROM         dbo.tbRCL_Calendar_Machin INNER JOIN " & _
            "                      dbo.tbRCL_CalendarDayStatus ON dbo.tbRCL_Calendar_Machin.CalDayStatusID = dbo.tbRCL_CalendarDayStatus.DayStatusID " & _
            "WHERE   (1=1) " & IIf(DaySt = 0, "", " AND  (dbo.tbRCL_Calendar_Machin.CalDayStatusID =" & DaySt & ")") & " AND (dbo.tbRCL_Calendar_Machin.CalIraniDate >= '" & DateDown & "' AND dbo.tbRCL_Calendar_Machin.CalIraniDate <= '" & DateUp & "')"

            dt = ps1.GetDataTable(strConnection, sqlstr)
            GetDayMonthCount = dt.DefaultView.Count
        End Function

        Public Function GetDateInfo() As DataTable
            Dim dt1 As New DataTable
            'Dim ps1 As New Persistent.DataAccess.DataAccess
            Dim sqlstr As String = ""
            sqlstr = "SELECT CalID,CalRemark,CalIraniDate,CalLatinDate,CalDayStatusID,DayStatusName,CalWeekID,CalIraniDayNumInYear, " & _
                "CalIraniYearID,CalLatinYearID,CalIraniMonthID,CalLatinMonthID,CalIraniDayNum,CalLatinDayNum,CalIraniWeekNum " & _
                "FROM tbRCL_Calendar_Machin INNER JOIN tbRCL_CalendarDayStatus ON CalDayStatusID=DayStatusID " & _
                "WHERE CalIraniDate='" & Me.IraniDate & "'"

            Try
                GetDateInfo = ps1.GetDataTable(strConnection, sqlstr)
                Me.CalID = GetDateInfo.DefaultView.Item(0).Item("CalID")
                Me.Remark = GetDateInfo.DefaultView.Item(0).Item("CalRemark")
                Me.IraniDate = GetDateInfo.DefaultView.Item(0).Item("CalIraniDate")
                Me.LatinDate = GetDateInfo.DefaultView.Item(0).Item("CalLatinDate")
                Me.DayStatusID = GetDateInfo.DefaultView.Item(0).Item("CalDayStatusID")
                'Me.WeekProp = GetDateInfo.DefaultView.Item(0).Item("CalDayStatusID")
                Me.IraniDayNumInYear = GetDateInfo.DefaultView.Item(0).Item("CalIraniDayNumInYear")
                Me.IraniYear = GetDateInfo.DefaultView.Item(0).Item("CalIraniYearID")
                Me.LatinYear = GetDateInfo.DefaultView.Item(0).Item("CalLatinYearID")
                Me.IraniMonth = GetDateInfo.DefaultView.Item(0).Item("CalIraniMonthID")
                Me.LatinMonth = GetDateInfo.DefaultView.Item(0).Item("CalIraniMonthID")
                Me.IraniDayNum = GetDateInfo.DefaultView.Item(0).Item("CalIraniDayNum")
                Me.LatinDayNum = GetDateInfo.DefaultView.Item(0).Item("CalLatinDayNum")
                Me.IraniWeekNum = GetDateInfo.DefaultView.Item(0).Item("CalIraniWeekNum")
            Catch ex As Exception

            End Try
        End Function

        Friend Function CreateCalendar(ByVal IYear As String) As Boolean
            'dim dt1 As New IraniDate.IraniDate.IraniDate
            'Dim ps1 As New Persistent.DataAccess.DataAccess
            Dim IDateNumeric, LDateNumeric As Long
            Dim i, WeekDayNum, IDayNumInYear, LDayNumInYear, IYear1, LYear, IMonth, LMonth, IDay, LDay, IWeekNum, LWeekNum As Int16
            Dim IDate, LDate As String

            IDate = IYear + "/01/01"
            IDateNumeric = date1.ConvDateStrToInt_GivenDate(IDate)
            IYear1 = date1.GetYear_GivenDate(IDateNumeric)
            ps1.Sp_AddParam("@IYear", SqlDbType.SmallInt, IYear1, ParameterDirection.Input)
            If ps1.Sp_Exe("spRCL_CalendarYearIraniUpd", strConnection) Then
                For i = 1 To IIf(date1.TestYearIsKBS(Val(IYear)), 366, 365)
                    IDateNumeric = date1.ConvDateStrToInt_GivenDate(IDate)
                    LDate = date1.GetDateIntToStr_GivenDate(date1.GetLatin_FromIraniDate(IDateNumeric))
                    LDateNumeric = date1.ConvDateStrToInt_GivenDate(LDate)
                    WeekDayNum = date1.GetIraniWeekDayNum_GivenDate(IDateNumeric)
                    IDayNumInYear = date1.GetDayNumInIraniYear_GivenDate(IDateNumeric)
                    LDayNumInYear = 0 'ÊÇÈÚ ãÍÇÓÈå ßääÏå æÌæÏ äÏÇÑÏ
                    IYear1 = date1.GetYear_GivenDate(IDateNumeric)
                    LYear = date1.GetYear_GivenDate(LDateNumeric)
                    IMonth = date1.GetMonthNum_GivenDate(IDateNumeric)
                    LMonth = date1.GetMonthNum_GivenDate(LDateNumeric)
                    IDay = date1.GetDayNum_GivenDate(IDateNumeric)
                    LDay = date1.GetDayNum_GivenDate(LDateNumeric)
                    IWeekNum = date1.GetIraniWeekNumInIraniYear_GivenDate(IDateNumeric)
                    LWeekNum = 0  'ÊÇÈÚ ãÍÇÓÈå ßääÏå æÌæÏ äÏÇÑÏ

                    ps1.Sp_AddParam("@IDate", SqlDbType.Char, IDate, ParameterDirection.Input)
                    ps1.Sp_AddParam("@LDate", SqlDbType.Char, LDate, ParameterDirection.Input)
                    ps1.Sp_AddParam("@WeekDayNum", SqlDbType.TinyInt, WeekDayNum, ParameterDirection.Input)
                    ps1.Sp_AddParam("@IDayNumInYear", SqlDbType.SmallInt, IDayNumInYear, ParameterDirection.Input)
                    ps1.Sp_AddParam("@LDayNumInYear", SqlDbType.SmallInt, LDayNumInYear, ParameterDirection.Input)
                    ps1.Sp_AddParam("@IYear", SqlDbType.SmallInt, IYear1, ParameterDirection.Input)
                    ps1.Sp_AddParam("@LYear", SqlDbType.SmallInt, LYear, ParameterDirection.Input)
                    ps1.Sp_AddParam("@IMonth", SqlDbType.TinyInt, IMonth, ParameterDirection.Input)
                    ps1.Sp_AddParam("@LMonth", SqlDbType.TinyInt, LMonth, ParameterDirection.Input)
                    ps1.Sp_AddParam("@IDay", SqlDbType.SmallInt, IDay, ParameterDirection.Input)
                    ps1.Sp_AddParam("@LDay", SqlDbType.SmallInt, LDay, ParameterDirection.Input)
                    ps1.Sp_AddParam("@IWeekNum", SqlDbType.TinyInt, IWeekNum, ParameterDirection.Input)
                    ps1.Sp_AddParam("@LWeekNum", SqlDbType.TinyInt, LWeekNum, ParameterDirection.Input)

                    Try
                        ps1.Sp_Exe("spRCL_CalendarIns_Machin", strConnection)
                        ps1.ClearParameter()
                    Catch ex As SqlClient.SqlException
                        MsgBox(ex.Message)
                        CreateCalendar = False
                        Exit Function
                    End Try
                    ps1.ClearParameter()

                    IDateNumeric = date1.GetPlussToIraniDate(IDateNumeric, 1)
                    IDate = date1.GetDateIntToStr_GivenDate(IDateNumeric)
                Next i
                ps1.ClearParameter()
                CreateCalendar = True
            End If
        End Function

        Friend Function DelCalendar_machin(ByVal IYear As Int16) As Boolean
            'Dim ps1 As New Persistent.DataAccess.DataAccess
            DelCalendar_machin = False
            ps1.Sp_AddParam("@IYear", SqlDbType.SmallInt, IYear, ParameterDirection.Input)
            If ps1.Sp_Exe("spRCL_CalendarDel_Machin", strConnection) Then
                DelCalendar_machin = True
            End If
            ps1.ClearParameter()
        End Function

        Friend Function SetCalDayStatus_Machin(ByVal IYear As Int16, Optional ByVal CalendarType1 As CalendarType = MainModule.CalendarType.AllDepart) As Boolean
            'Dim ps1 As New Persistent.DataAccess.DataAccess
            'dim dt1 As New IraniDate.IraniDate.IraniDate
            Dim i, j As Int16
            For i = 1 To 7
                For j = 1 To 2 Step 2
                    If DayStArray(i, 2) >= 1 Then
                        ps1.Sp_AddParam("@IYear", SqlDbType.SmallInt, IYear, ParameterDirection.Input)
                        ps1.Sp_AddParam("@DayStatusID", SqlDbType.TinyInt, DayStArray(i, j + 1), ParameterDirection.Input)
                        ps1.Sp_AddParam("@WeekID", SqlDbType.TinyInt, DayStArray(i, j), ParameterDirection.Input)
                        ps1.Sp_AddParam("@CalType", SqlDbType.TinyInt, CalendarType1, ParameterDirection.Input)

                        ps1.Sp_Exe("spRCL_CalendarAllDayStatusUpd_Machin", strConnection)
                        ps1.ClearParameter()
                    End If
                Next j
            Next i
        End Function

        Friend Function EditCalDayStatus_Machin(ByVal CalID As Int16, ByVal DayStatusID As Int16, Optional ByVal CalendarType1 As CalendarType = MainModule.CalendarType.AllDepart) As Boolean
            'Dim ps1 As New Persistent.DataAccess.DataAccess
            ps1.Sp_AddParam("@CalID", SqlDbType.SmallInt, CalID, ParameterDirection.Input)
            ps1.Sp_AddParam("@DayStatusID", SqlDbType.TinyInt, DayStatusID, ParameterDirection.Input)
            ps1.Sp_AddParam("@CalType", SqlDbType.TinyInt, CalendarType1, ParameterDirection.Input)

            ps1.Sp_Exe("spRCL_CalendarOneDayStatusUpd_Machin", strConnection)
            ps1.ClearParameter()
        End Function

        Friend Function CreateIraniYear(ByVal IYear As Int16) As Boolean
            'Dim ps1 As New Persistent.DataAccess.DataAccess
            'dim dt1 As New IraniDate.IraniDate.IraniDate
            Dim YearStatusID As Int16
            Dim wstr1, wstr2 As String
            Dim cnn1 As New SqlClient.SqlConnection
            Dim cnn2 As New SqlClient.SqlConnection
            Dim dr1 As SqlClient.SqlDataReader
            Dim dr2 As SqlClient.SqlDataReader

            cnn1.ConnectionString = strConnection
            cnn2.ConnectionString = strConnection

            wstr1 = "SELECT IraniYearID FROM tbRCL_CalendarYearIrani WHERE IraniYearID=" & IYear & " AND IraniYearIsCreatedID=1"
            wstr2 = "SELECT IraniYearID FROM tbRCL_CalendarYearIrani WHERE IraniYearID=" & IYear
            cnn1.Open()
            cnn2.Open()
            dr1 = ps1.GetDataReader(cnn1, wstr1)
            dr2 = ps1.GetDataReader(cnn2, wstr2)
            dr1.Read()
            dr2.Read()
            If dr1.HasRows Then
                MsgBox("ÈÑÇí ÓÇá ãæÑÏ äÙÑ íÔ ÇÒ Çíä ÊÞæíã ÇíÌÇÏ ÔÏå ÇÓÊ", MsgBoxStyle.Critical, "ÎØÇ")
                CreateIraniYear = False
            ElseIf dr2.HasRows Then
                CreateIraniYear = True
            Else
                YearStatusID = IIf(date1.TestYearIsKBS(IYear), 2, 1)
                Dim LYear As Int16
                LYear = date1.GetYear_GivenDate(date1.GetLatin_FromIraniDate((IYear * 10000) + 101))

                ps1.Sp_AddParam("@IYear", SqlDbType.SmallInt, IYear, ParameterDirection.Input)
                ps1.Sp_AddParam("@YearStatusID", SqlDbType.TinyInt, YearStatusID, ParameterDirection.Input)
                ps1.Sp_AddParam("@LYear", SqlDbType.SmallInt, LYear, ParameterDirection.Input)
                Try
                    If ps1.Sp_Exe("spRCL_CalendarYearIraniIns", strConnection) Then
                        CreateIraniYear = True
                    Else
                        CreateIraniYear = False
                    End If
                Catch ex As SqlClient.SqlException
                    CreateIraniYear = False
                End Try
                ps1.ClearParameter()
            End If
        End Function

        Public Function GetEndDate_WorkDay(ByVal FirstDate As String, ByVal WorkDayNumber As Integer, ByVal MDepartID As String, ByVal CnnStr As String) As String
            Dim m As Integer
            Dim ds1 As New DayStatus
            Dim FDate As Integer

            FDate = date1.Numericdate(FirstDate)

            m = WorkDayNumber

            Do While m > 0
                FDate = date1.GetPlussToIraniDate(FDate, 1)
                If ds1.GetDayStatus(date1.GetDateIntToStr_GivenDate(FDate), MDepartID, CnnStr) = 1 Then
                    m = m - 1
                End If

            Loop
            GetEndDate_WorkDay = date1.GetDateIntToStr_GivenDate(FDate)

        End Function
    End Class

    Public Class CalendarWeek

    End Class

    Public Class CalendarMonthIrani

    End Class

    Public Class CalendarMonthLatin

    End Class

End Namespace