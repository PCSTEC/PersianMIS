Namespace IraniDate

    Public Class IraniDate

        Dim nz1 As New IKIDUtility.IKIDUtility.Formating

        Public Function ConvDateStrToInt_GivenDate(ByVal FDate8v As String) As Long    '—‘ Â 10 ﬂ«—«ﬂ —Ì  «—ÌŒ —« »Â ⁄œœ  »œÌ· „Ìﬂ‰œ 
            ConvDateStrToInt_GivenDate = Val(Left(FDate8v, 4) + Mid(FDate8v, 6, 2) + Right(FDate8v, 2))
        End Function

        Public Function GetDateIntToStr_GivenDate(ByVal FDate8v As String) As String    '  «—ÌŒ ⁄œœÌ 8 —ﬁ„Ì —« »Â ›—„  10 ﬂ«—«ﬂ —Ì  »œÌ· „Ìﬂ‰œ 
            GetDateIntToStr_GivenDate = LTrim(RTrim(Left(FDate8v, 4) + "/" + Mid(FDate8v, 5, 2) + "/" + Right(FDate8v, 2)))
        End Function

        Public Function GetIraniYear_CurDate() As Long '”«· 4 —ﬁ„Ì ﬂ‰Ê‰Ì «Ì—«‰Ì —« »—„Ìê—œ«‰œ
            GetIraniYear_CurDate = IraniDate(1)
        End Function

        Public Function GetYear_GivenDate(ByVal FDate8v As Object) As Long '”«· 4 —ﬁ„Ì —« «“  «—ÌŒÌ ﬂÂ „ÌêÌ—œ »— „Ìê—œ«‰œ
            Dim FDate8 As Long
            Dim nz1 As New IKIDUtility.IKIDUtility.Formating
            FDate8 = nz1.NZ(FDate8v, 0)
            If FDate8 < 1000 Then
                GetYear_GivenDate = 0
            Else
                GetYear_GivenDate = Left(FDate8, 4)
            End If
        End Function

        Public Function GetPassedYear_From1300() As Integer 'ê–‘  ”«·Â«Ì Å” «“ 1300 —« »— „Ìê—œ«‰œ. ‰„Ê‰Â 84 —« »—«Ì ”«· 1384 »— „Ìê—œ«‰œ 
            GetPassedYear_From1300 = GetIraniYear_CurDate() - 1300
        End Function

        Public Function GetIraniMonthNum_CurDate() '⁄œœ „«Â ”«· ﬂ‰Ê‰Ì «Ì—«‰Ì —« »— „Ìê—œ«‰œ. ‰„Ê‰Â 6 —« »—«Ì ‘Â—ÌÊ— „«Â »— „Ìê—œ«‰œ
            GetIraniMonthNum_CurDate = IraniDate(2)
        End Function

        Public Function GetMonthNum_GivenDate(ByVal FDate8v As Object) As Long '⁄œœ „«Â ”«· „Ê—œ ‰Ÿ— —« »— „Ìê—œ«‰œ. ‰„Ê‰Â 6 —« »—«Ì ‘Â—ÌÊ— „«Â ”«· „Ê—œ ‰Ÿ— »— „Ìê—œ«‰œ
            Dim FDate8 As Long
            FDate8 = nz1.NZ(FDate8v, 0)
            If FDate8 < 1000 Then
                GetMonthNum_GivenDate = 0
            Else
                GetMonthNum_GivenDate = Mid(FDate8, 5, 2)
            End If
        End Function

        Public Function GetIraniMonthName_CurDate() As String '‰«„ „«ÂÂ«Ì ”«· «Ì—«‰Ì ﬂ‰Ê‰Ì —« »— „Ìê—œ«‰œ
            GetIraniMonthName_CurDate = IraniMonthName_GivenDate(GetIrani8Date_CurDate)
        End Function

        Public Function GetIraniMonthName_GivenDate(ByVal FDate8v As Object) As String '‰«„ „«ÂÂ«Ì ”«· «Ì—«‰Ì „Ê—œ ‰Ÿ— —« »— „Ìê—œ«‰œ
            Dim FDate8 As Long
            FDate8 = nz1.NZ(FDate8v, 0)
            If FDate8 < 1000 Then
                GetIraniMonthName_GivenDate = ""
            Else
                GetIraniMonthName_GivenDate = IraniMonthName_GivenDate(FDate8)
            End If
        End Function

        Public Function GetIraniMonthYearName_GivenDate(ByVal FDate8v As Object) As String '‰«„ „«ÂÂ«Ì ”«· «Ì—«‰Ì Â„—«Â »« ‘„«—Â ”«· „Ê—œ ‰Ÿ— —« »— „Ìê—œ«‰œ
            Dim FDate8 As Long
            FDate8 = nz1.NZ(FDate8v, 0)
            If FDate8 < 1000 Then
                GetIraniMonthYearName_GivenDate = ""
            Else
                GetIraniMonthYearName_GivenDate = IraniMonthName_GivenDate(FDate8) & " „«Â " & Mid(FDate8v, 1, 4)
            End If
        End Function

        Public Function GetLatinMonthName_CurDate() As String '‰«„ „«ÂÂ«Ì ”«· ·« Ì‰ ﬂ‰Ê‰Ì —« »— „Ìê—œ«‰œ
            GetLatinMonthName_CurDate = LatinMonthName_GivenDate(Val(Format(Date.Today, "YYYYMMDD")))
        End Function

        Public Function GetLatinMonthName_GivenDate(ByVal MDate8v As Object) As String '‰«„ „«ÂÂ«Ì ”«· ·« Ì‰ „Ê—œ ‰Ÿ— —« »— „Ìê—œ«‰œ
            Dim MDate8 As Long
            MDate8 = nz1.NZ(MDate8v, 0)
            If MDate8 < 1000 Then
                GetLatinMonthName_GivenDate = 0
            Else
                GetLatinMonthName_GivenDate = LatinMonthName_GivenDate(MDate8)
            End If
        End Function

        Public Function GetIraniDayNum_CurDate() As Long '‘„«—Â —Ê“ ”«· «Ì—«‰Ì ﬂ‰Ê‰Ì —« »— „Ìê—œ«‰œ
            GetIraniDayNum_CurDate = IraniDate(3)
        End Function

        Public Function GetDayNum_GivenDate(ByVal FDate8v As Object) As Long '‘„«—Â —Ê“ ”«· „Ê—œ ‰Ÿ— —« »— „Ìê—œ«‰œ
            Dim FDate8 As Long
            FDate8 = nz1.NZ(FDate8v, 0)
            If FDate8 < 1000 Then
                GetDayNum_GivenDate = 0
            Else
                GetDayNum_GivenDate = Right(FDate8, 2)
            End If
        End Function

        Public Function GetIrani4Date_CurDate() As Long '‘ﬂ· çÂ«— —ﬁ„Ì  «—ÌŒ ﬂ‰Ê‰Ì —« »— „Ìê—œ«‰œ „«‰‰œ ´0609ª »—«Ì  «—ÌŒ ´13840609ª
            GetIrani4Date_CurDate = IraniDate(4)
        End Function

        Public Function GetIrani6Date_CurDate() As Long '‘ﬂ· ‘‘ —ﬁ„Ì  «—ÌŒ ﬂ‰Ê‰Ì —« »— „Ìê—œ«‰œ „«‰‰œ ´840609ª »—«Ì  «—ÌŒ ´13840609ª
            GetIrani6Date_CurDate = IraniDate(6)
        End Function

        Public Function GetIrani8Date_CurDate() As Long '‘ﬂ· Â‘  —ﬁ„Ì  «—ÌŒ ﬂ‰Ê‰Ì —« »— „Ìê—œ«‰œ „«‰‰œ ´13840609ª »—«Ì  «—ÌŒ ´13840609ª
            GetIrani8Date_CurDate = IraniDate(8)
        End Function  'LastName FDate8()

        Public Function GetIrani8DateStr_CurDate() As String
            GetIrani8DateStr_CurDate = Format(IraniDate(8), "0000/00/00")
        End Function

        Public Function GetIrani_FromLatinDate(ByVal MDate8v As Object) ' ”«· «Ì—«‰Ì »—«»— ”«· ·« Ì‰ „Ê—œ ‰Ÿ— —« »— „Ìê—œ«‰œ
            Dim MDate8 As Long
            MDate8 = nz1.NZ(MDate8v, 0)
            If MDate8 < 1000 Then
                GetIrani_FromLatinDate = 0
            Else
                GetIrani_FromLatinDate = LatinToIraniDate(MDate8)
            End If
        End Function

        Public Function GetLatin_FromIraniDate(ByVal FDate8v As Object) ' ”«· ·« Ì‰ »—«»— ”«· «Ì—«‰Ì „Ê—œ ‰Ÿ— —« »— „Ìê—œ«‰œ
            Dim FDate8 As Long
            FDate8 = nz1.NZ(FDate8v, 0)
            If FDate8 < 1000 Then
                GetLatin_FromIraniDate = 0
            Else
                GetLatin_FromIraniDate = IraniToLatinDate(FDate8)
            End If
        End Function

        Public Function GetPlussToIraniDate(ByVal FDate8v As Object, ByVal n As Long)
            Dim FDate8 As Long
            FDate8 = nz1.NZ(FDate8v, 0)
            If FDate8 < 1000 Then
                GetPlussToIraniDate = 0
            Else
                GetPlussToIraniDate = PlussToIraniDate(FDate8, n)
            End If
        End Function ' ⁄œ«œ —Ê“ „⁄Ì‰Ì —« »Â ”«· «Ì—«‰Ì «›“ÊœÂ Ì« «“ ¬‰ ﬂ„ „Ìﬂ‰œ ° »” Â »Â «Ì‰ﬂÂ ¬—êÊ„«‰ œÊ„ ⁄œœÌ „À»  Ì« „‰›Ì »«‘œ

        Public Function GetDifIraniDates(ByVal StFDate8v As Object, ByVal EdFDate8v As Object) ' ⁄œ«œ —Ê“Â«Ì „Ì«‰ œÊ ”«· «Ì—«‰Ì —« »—„Ìê—œ«‰œ
            Dim StFDate8 As Long, EdFDate8 As Long, SYear As Long, EYear As Long
            StFDate8 = nz1.NZ(StFDate8v, 0)
            EdFDate8 = nz1.NZ(EdFDate8v, 0)
            SYear = Left(StFDate8, 4)
            EYear = Left(EdFDate8, 4)
            '  If TestYearIsKBS(SYear) Then
            GetDifIraniDates = GetDayNumInIraniYear_GivenDate(EdFDate8) - GetDayNumInIraniYear_GivenDate(StFDate8) + (EYear - SYear) * 365 + 1
            '  Else
            '    GetDifIraniDates = GetDayNumInIraniYear_GivenDate(EdFDate8) - GetDayNumInIraniYear_GivenDate(StFDate8) + (EYear - SYear) * 365
            ' End If
            '' must complete
        End Function
        Public Function GetDifIraniDates(ByVal StFDate8v As Object, ByVal StFHour5v As Object, ByVal EdFDate8v As Object, ByVal EdFHour5v As Object)  ' ⁄œ«œ —Ê“Â«Ì „Ì«‰ œÊ ”«· «Ì—«‰Ì —« »—„Ìê—œ«‰œ
            Dim IraniTimes1 As New Times
            Dim sum2 As Integer
            Dim s1, s2 As String

            If StFDate8v > EdFDate8v Then
                MsgBox(" «—ÌŒ ‘—Ê⁄ »“—ê — «“  «—ÌŒ Å«Ì«‰ „Ì »«‘œ", MsgBoxStyle.OKOnly)
                GetDifIraniDates = IraniTimes1.GetTimeHour(0)
                Exit Function
            End If

            sum2 = GetDifIraniDates(Numericdate(StFDate8v), Numericdate(EdFDate8v)) * 24 * 60

            If sum2 = 1440 Then
                If StFHour5v > EdFHour5v Then
                    MsgBox("“„«‰ ‘—Ê⁄ »“—ê — «“ “„«‰ Å«Ì«‰ „Ì »«‘œ", MsgBoxStyle.OKOnly)
                    GetDifIraniDates = IraniTimes1.GetTimeHour(0)
                    Exit Function
                Else
                    sum2 = IraniTimes1.GetTimeMinuteBet2Hour(StFHour5v, EdFHour5v)
                End If
            Else
                s1 = IraniTimes1.TimeDif("00:00", StFHour5v)
                s2 = IraniTimes1.TimeDif(EdFHour5v, "24:00")

                sum2 = sum2 - (IraniTimes1.GetTimeMinute(s1) + IraniTimes1.GetTimeMinute(s2))
            End If

            GetDifIraniDates = IraniTimes1.GetTimeHour(sum2)
        End Function


        Public Function GetIraniWeekNum_CurDate() As Long '‘„«—Â Â› Â ﬂ‰Ê‰Ì —« »— „Ìê—œ«‰œ
            GetIraniWeekNum_CurDate = WeekNumInIraniYear(GetIrani8Date_CurDate)
        End Function

        Public Function GetIraniWeekNumInIraniYear_GivenDate(ByVal FDate8v As Object) As Long '‘„«—Â Â› Â  «—ÌŒ „Ê—œ ‰Ÿ— —« »— „Ìê—œ«‰œ
            Dim FDate8 As Long
            FDate8 = nz1.NZ(FDate8v, 0)
            If FDate8 < 1000 Then
                GetIraniWeekNumInIraniYear_GivenDate = 0
            Else
                GetIraniWeekNumInIraniYear_GivenDate = WeekNumInIraniYear(FDate8)
            End If
        End Function

        Public Function GetIraniWeekDayNum_CurDate() As Long ' ‘„«—Â —Ê“ Â› Â Ã«—Ì —« »— „Ìê—œ«‰œ
            GetIraniWeekDayNum_CurDate = GetDayNumInWeek4GivenDate(GetIrani8Date_CurDate)
        End Function

        Public Function GetIraniWeekDayNum_GivenDate(ByVal FDate8v As Object) As String ' ‘„«—Â —Ê“ Â› Â „Ê—œ ‰Ÿ— —« »— „Ìê—œ«‰œ
            Dim FDate8 As Long
            FDate8 = nz1.NZ(FDate8v, 0)
            If FDate8 < 1000 Then
                GetIraniWeekDayNum_GivenDate = 0
            Else
                GetIraniWeekDayNum_GivenDate = GetDayNumInWeek4GivenDate(FDate8)
            End If
        End Function

        Public Function GetIraniDayName_CurDate() As String '‰«„ —Ê“  ﬂ‰Ê‰Ì —« »— „Ìê—œ«‰œ
            GetIraniDayName_CurDate = IraniDayName(GetIrani8Date_CurDate)
        End Function

        Public Function GetIraniDayName_GivenDate(ByVal FDate8v As Object) As String '‰«„ —Ê“   «—ÌŒ „Ê—œ ‰Ÿ— —« »— „Ìê—œ«‰œ
            Dim FDate8 As Long
            FDate8 = nz1.NZ(FDate8v, 0)
            If FDate8 < 1000 Then
                GetIraniDayName_GivenDate = 0
            Else
                GetIraniDayName_GivenDate = IraniDayName(FDate8)
            End If
        End Function

        Public Function GetIraniFullDateTime_CurDate() As String '  «—ÌŒ ‰«„ —Ê“ Ê ”«⁄  —Ê“ Ê “„«‰ ﬂ‰Ê‰Ì —« »—„Ìê—œ«‰œ
            GetIraniFullDateTime_CurDate = GetIraniDayName_CurDate() & " " & GetIraniDayNum_CurDate() & " " & GetIraniMonthName_CurDate() & " " & GetIraniYear_CurDate() & " ”«⁄  " & Microsoft.VisualBasic.DateAndTime.TimeString
        End Function

        Public Function TestDate(ByVal da As Long) As Object '  «—ÌŒ —« «“ ÃÂ  œ—” Ì  «ÌÅ  ”  „Ìﬂ‰œ
            Dim Y As Long, m As Long, d As Long, s As Long, kkb As Long
            Dim X As Long, w As Long, ym As Long, rp As Long
            If da < 11111111 Or da > 99999999 Then
                Beep()
                TestDate = True
                MsgBox(" «—ÌŒ —« »Â ’Ê—  [YYY/MM/DD] Ê«—œ ﬂ‰Ìœ", 16, " ÊÃÂ")
                Exit Function
            End If
            Y = Fix(da / 10000)
            d = da - (Fix(da / 100) * 100)
            m = Fix(da - ((Y * 10000) + d)) / 100
            If m > 12 Or m < 1 Then
                Beep()
                TestDate = True
                MsgBox("„«Â —« »Ì‰ 1  « 12 Ê«—œ ﬂ‰Ìœ", 16, " ÊÃÂ")
                Exit Function
            End If
            If d > 31 Or d < 1 Then
                Beep()
                TestDate = True
                MsgBox("—Ê“ —« »Ì‰ 1  « 31 Ê«—œ ﬂ‰Ìœ", 16, " ÊÃÂ")
                Exit Function
            End If
            If m > 6 And d > 30 Then
                Beep()
                TestDate = True
                MsgBox("‘‘ „«Â ¬Œ— ”«· «”  —Ê“ »«Ìœ »Ì‰ 1  « 30 »«‘œ", 16, " ÊÃÂ")
                Exit Function
            End If
            s = Fix((Y + 16) / 33)
            kkb = s * 33 - 16
            X = Fix((Y + 15) / 33)
            w = Y - X - 17
            If w Mod 4 <> 0 And m = 12 And d = 30 Then
                Beep()
                TestDate = True
                MsgBox("”«·" & Y & "ﬂ»Ì”Â ‰Ì”  «”›‰œ „«Â »«Ìœ 29 —Ê“Â »«‘œ", 16, " ÊÃÂ")
                Exit Function
            End If
            ym = Y
            X = Int((ym + 16) / 33)
            rp = 0
            w = ym - X - 17

            If kkb + 1 = ym And m = 12 And d = 30 Then
                Beep()
                TestDate = True
                MsgBox("”«·" & Y & "ﬂ»Ì”Â ‰Ì”  «”›‰œ „«Â »«Ìœ 29 —Ê“Â »«‘œ", 16, " ÊÃÂ")
                Exit Function
            End If

            'TestDate = da - (Fix(da / 1000000) * 1000000)
            TestDate = False
        End Function

        Public Function TestDate_Err(ByVal da As Long) As Long
            Dim Y As Long, m As Long, d As Long
            Dim s As Long, kkb As Long, X As Long
            Dim w As Long, ym As Long, rp As Long
            If da < 11111111 Or da > 99999999 Then
                Beep()
                TestDate_Err = 1
                'MsgBox " «—ÌŒ —« »Â ’Ê—  [YYY/MM/DD] Ê«—œ ﬂ‰Ìœ", 16, " ÊÃÂ"
                Exit Function
            End If
            Y = Fix(da / 10000)
            d = da - (Fix(da / 100) * 100)
            m = Fix(da - ((Y * 10000) + d)) / 100
            If m > 12 Or m < 1 Then
                Beep()
                TestDate_Err = 2
                'MsgBox "„«Â —« »Ì‰ 1  « 12 Ê«—œ ﬂ‰Ìœ", 16, " ÊÃÂ"
                Exit Function
            End If
            If d > 31 Or d < 1 Then
                Beep()
                TestDate_Err = 3
                'MsgBox "—Ê“ —« »Ì‰ 1  « 31 Ê«—œ ﬂ‰Ìœ", 16, " ÊÃÂ"
                Exit Function
            End If
            If m > 6 And d > 30 Then
                Beep()
                TestDate_Err = 4
                'MsgBox "‘‘ „«Â ¬Œ— ”«· «”  —Ê“ »«Ìœ »Ì‰ 1  « 30 »«‘œ", 16, " ÊÃÂ"
                Exit Function
            End If
            s = Fix((Y + 16) / 33)
            kkb = s * 33 - 16
            X = Fix((Y + 15) / 33)
            w = Y - X - 17
            If w Mod 4 <> 0 And m = 12 And d = 30 Then
                Beep()
                TestDate_Err = 5
                'MsgBox "”«·" & y & "ﬂ»Ì”Â ‰Ì”  «”›‰œ „«Â »«Ìœ 29 —Ê“Â »«‘œ", 16, " ÊÃÂ"
                Exit Function
            End If
            ym = Y
            X = Int((ym + 16) / 33)
            rp = 0
            w = ym - X - 17

            If kkb + 1 = ym And m = 12 And d = 30 Then
                Beep()
                TestDate_Err = 5
                'MsgBox "”«·" & y & "ﬂ»Ì”Â ‰Ì”  «”›‰œ „«Â »«Ìœ 29 —Ê“Â »«‘œ", 16, " ÊÃÂ"
                Exit Function
            End If
            TestDate_Err = 0
        End Function

        Public Function TestDate_Alarm(ByVal FDate8 As Long) As Long
            Dim prmt As String, Err As Long
            Err = TestDate_Err(FDate8)
            Select Case Err
                Case 1
                    prmt = "·ÿ›«  «—ÌŒ —« »’Ê—  YYYY/MM/DD Ê«—œ ‰„«∆Ìœ"
                Case 2
                    prmt = "·ÿ›« ‘„«—Â „«Â —« »Ì‰ 1  « 12 Ê«—œ ‰„«∆Ìœ"
                Case 3
                    prmt = "·ÿ›« ‘„«—Â —Ê“ —« »Ì‰ 1  « 31 Ê«—œ ‰„«∆Ìœ"
                Case 4
                    prmt = "·ÿ›« ‘„«—Â —Ê“ —« »Ì‰ 1  « 30 Ê«—œ ‰„«∆Ìœ"
                Case 5
                    prmt = "·ÿ›« ‘„«—Â —Ê“ —« »Ì‰ 1  « 29 Ê«—œ ‰„«∆Ìœ"
                Case Else
                    prmt = ""
            End Select
            If prmt <> "" Then
                MsgBox(prmt, vbCritical + vbOKOnly + vbMsgBoxRtlReading + vbMsgBoxRight, "Œÿ«")
            End If
            TestDate_Alarm = IIf(Err = 0, True, False)
        End Function

        Public Function Numericdate(ByVal StringDate As String) As Long
            Dim PkDate As String
            PkDate = PackDate(StringDate)
            Numericdate = Val(PkDate)
        End Function

        Public Function StringDate(ByVal Numericdate As Long) As String
            Dim UnPkDate As String
            If Numericdate > 11110011 Then
                UnPkDate = Trim(Str(Numericdate))
                UnPkDate = Mid(UnPkDate, 1, 4) & "/" & Mid(UnPkDate, 5, 2) & "/" & Mid(UnPkDate, 7, 2)
                StringDate = UnPkDate
            ElseIf Numericdate = 0 Then
                StringDate = "0000/00/00"
            Else
                StringDate = "    /  /  "
            End If
        End Function

        Public Function PackDate(ByVal NormalDate As String) As String
            Dim nLen, i As Integer
            Dim PackDateStr As String
            PackDateStr = ""
            nLen = Len(NormalDate)
            For i = 1 To nLen
                If InStr("0123456789", Mid(NormalDate, i, 1)) > 0 Then
                    PackDateStr = PackDateStr & Mid(NormalDate, i, 1)
                End If
            Next i
            PackDate = PackDateStr
        End Function

        Public Function StringTime(ByVal PackTime As String) As String
            Dim UnPkTime As String
            UnPkTime = Trim(PackTime)
            If Len(UnPkTime) = 1 And Val(Mid(UnPkTime, 1, 1)) < 10 Then

                StringTime = "0" & Mid(UnPkTime, 1, 2) & ":00"
                Exit Function
            End If
            If Len(UnPkTime) = 2 And Val(Mid(UnPkTime, 1, 2)) < 24 Then

                StringTime = Mid(UnPkTime, 1, 2) & ":00"
                Exit Function
            End If
            If Len(UnPkTime) = 2 And Val(Mid(UnPkTime, 1, 2)) = 24 Then

                StringTime = "00:00"
                Exit Function
            End If
            If Len(UnPkTime) = 3 And Val(Mid(UnPkTime, 2, 2)) < 60 Then

                StringTime = "0" & Mid(UnPkTime, 1, 1) & ":" & Mid(UnPkTime, 2, 2)
                Exit Function
            End If
            If Len(UnPkTime) <> 4 Or Val(Mid(UnPkTime, 3, 2)) > 59 Or Val(Mid(UnPkTime, 1, 2)) > 24 Then
                StringTime = "  :  "
                Exit Function
            End If
            If Val(UnPkTime) >= 1 And Val(UnPkTime) < 2401 Then

                StringTime = Mid(UnPkTime, 1, 2) & ":" & Mid(UnPkTime, 3, 2)

            ElseIf Val(PackTime) = 0 Then
                StringTime = "00:00"
            Else
                StringTime = "  :  "
            End If
        End Function

        Public Function PackTime(ByVal NormalTime As String) As String
            Dim nLen, i As Integer
            Dim PackTimeStr As String
            PackTimeStr = ""
            nLen = Len(NormalTime)
            For i = 1 To nLen
                If InStr("0123456789", Mid(NormalTime, i, 1)) > 0 Then
                    PackTimeStr = PackTimeStr & Mid(NormalTime, i, 1)
                End If
            Next i
            PackTime = PackTimeStr
        End Function



        ''''''Privates''''''
        Private Function IraniMonthName_GivenDate(ByVal FDate8 As Long) As String
            Static Month(12) As String
            Month(1) = "›—Ê—œÌ‰"
            Month(2) = "«—œÌ»Â‘ "
            Month(3) = "Œ—œ«œ"
            Month(4) = " Ì—"
            Month(5) = "«„—œ«œ"
            Month(6) = "‘Â—ÌÊ—"
            Month(7) = "„Â—"
            Month(8) = "¬»«‰"
            Month(9) = "¬–—"
            Month(10) = "œÌ"
            Month(11) = "»Â„‰"
            Month(12) = "«”›‰œ"
            IraniMonthName_GivenDate = Month(Mid(FDate8, 5, 2))
        End Function

        Private Function LatinMonthName_GivenDate(ByVal MDate8 As Long) As String
            Static Month(12) As String
            Month(1) = "é«‰ÊÌÂ"
            Month(2) = "›Ê—ÌÂ"
            Month(3) = "„«—”"
            Month(4) = "¬Ê—Ì·"
            Month(5) = "„Ì"
            Month(6) = "éÊ∆‰"
            Month(7) = "éÊ∆ÌÂ"
            Month(8) = "«Ê "
            Month(9) = "”Å «„»—"
            Month(10) = "«ﬂ »—"
            Month(11) = "‰Ê«„»—"
            Month(12) = "œ”«„»—"
            LatinMonthName_GivenDate = Month(Mid(MDate8, 5, 2))
        End Function

        Private Function LatinToIraniDate(ByVal DateMe As Long) As Long
            Static E(12) As Long
            Static d(4, 12) As Long
            Static p(4, 12) As Long
            Static n(2, 12) As Long
            Dim yy, mm, dd, u, rag, h, ym, x, rp, w, s, kkb, i As Long
            Dim z, sd, mn, ls, ye As Long
            Dim ny, r As String
            Dim StrMonth, StrDay As String

            E(1) = 31 : E(2) = 28 : E(3) = 31 : E(4) = 30 : E(5) = 31 : E(6) = 30 : E(7) = 31 : E(8) = 13 : E(9) = 30
            E(10) = 31 : E(11) = 30 : E(12) = 31
            '---------------------------d(1,3)=19
            d(1, 1) = 20 : d(1, 2) = 19 : d(1, 3) = 19 : d(1, 4) = 19 : d(1, 5) = 20 : d(1, 6) = 20 : d(1, 7) = 21 : d(1, 8) = 21 : d(1, 9) = 21 : d(1, 10) = 21 : d(1, 11) = 20 : d(1, 12) = 20
            d(2, 1) = 19 : d(2, 2) = 18 : d(2, 3) = 20 : d(2, 4) = 20 : d(2, 5) = 21 : d(2, 6) = 21 : d(2, 7) = 22 : d(2, 8) = 22 : d(2, 9) = 22 : d(2, 10) = 22 : d(2, 11) = 21 : d(2, 12) = 21
            d(3, 1) = 20 : d(3, 2) = 19 : d(3, 3) = 20 : d(3, 4) = 20 : d(3, 5) = 21 : d(3, 6) = 21 : d(3, 7) = 22 : d(3, 8) = 22 : d(3, 9) = 22 : d(3, 10) = 22 : d(3, 11) = 21 : d(3, 12) = 21
            d(4, 1) = 20 : d(4, 2) = 19 : d(4, 3) = 20 : d(4, 4) = 20 : d(4, 5) = 21 : d(4, 6) = 21 : d(4, 7) = 22 : d(4, 8) = 22 : d(4, 9) = 22 : d(4, 10) = 22 : d(4, 11) = 21 : d(4, 12) = 21
            p(1, 1) = 11 : p(1, 2) = 12 : p(1, 3) = 11 : p(1, 4) = 13 : p(1, 5) = 12 : p(1, 6) = 12 : p(1, 7) = 11 : p(1, 8) = 11 : p(1, 9) = 11 : p(1, 10) = 10 : p(1, 11) = 11 : p(1, 12) = 11
            p(2, 1) = 12 : p(2, 2) = 13 : p(2, 3) = 11 : p(2, 4) = 12 : p(2, 5) = 11 : p(2, 6) = 11 : p(2, 7) = 10 : p(2, 8) = 10 : p(2, 9) = 10 : p(2, 10) = 9 : p(2, 11) = 10 : p(2, 12) = 10
            p(3, 1) = 11 : p(3, 2) = 12 : p(3, 3) = 10 : p(3, 4) = 12 : p(3, 5) = 11 : p(3, 6) = 11 : p(3, 7) = 10 : p(3, 8) = 10 : p(3, 9) = 10 : p(3, 10) = 9 : p(3, 11) = 10 : p(3, 12) = 10
            p(4, 1) = 11 : p(4, 2) = 12 : p(4, 3) = 11 : p(4, 4) = 12 : p(4, 5) = 11 : p(4, 6) = 11 : p(4, 7) = 10 : p(4, 8) = 10 : p(4, 9) = 10 : p(4, 10) = 9 : p(4, 11) = 10 : p(4, 12) = 10
            n(1, 1) = 10 : n(1, 2) = 11 : n(1, 3) = 12 : n(1, 4) = 1 : n(1, 5) = 2 : n(1, 6) = 3 : n(1, 7) = 4 : n(1, 8) = 5 : n(1, 9) = 6 : n(1, 10) = 7 : n(1, 11) = 8 : n(1, 12) = 9
            n(2, 1) = 11 : n(2, 2) = 12 : n(2, 3) = 1 : n(2, 4) = 2 : n(2, 5) = 3 : n(2, 6) = 4 : n(2, 7) = 5 : n(2, 8) = 6 : n(2, 9) = 7 : n(2, 10) = 8 : n(2, 11) = 9 : n(2, 12) = 10
            yy = Mid$(Str(DateMe), 2, 4)
            mm = Mid$(Str(DateMe), 6, 2)
            dd = Mid$(Str(DateMe), 8, 2)
            u = 0

            If yy Mod 4 = 0 Then
                u = 1
            End If

            ny = Str(yy)
            r = Right(ny, 2)
            rag = Val(r)

            If rag = 0 And yy Mod 400 <> 0 Then
                u = 0
            End If

            h = 0

            If mm = 2 And u = 1 Then
                h = 1
            End If

            ym = yy - 622
            'x = Int((ym + 16) / 33)
            x = Int((ym + 15) / 33)
            rp = 0
            w = ym - x - 17

            'rp=0 »Êœ
            If w Mod 4 = 0 Then
                rp = 1
            End If


            s = Int((ym + 16) / 33)
            kkb = s * 33 - 16
            If kkb + 1 = ym Then
                rp = 0
            End If
            If u = 1 And rp = 0 Then
                i = 1
            End If
            If u = 0 And rp = 1 Then
                i = 2
            End If
            If u = 0 And rp = 0 Then
                i = 3
            End If
            If u = 1 And rp = 1 Then
                i = 4
            End If
            z = 0
            If i = 4 And mm = 3 Then
                z = 1
            End If
            If i = 4 Then
                i = 3
            End If

            If 1 <= dd And dd <= d(i, mm) Then
                sd = p(i, mm) + dd + z - 1
                mn = n(1, mm)
                ls = 1
            Else
                sd = dd - d(i, mm)
                mn = n(2, mm)
                ls = 2
            End If
            If mm <= 3 Then
                ye = yy - 622
            End If
            If mm = 3 And ls = 2 Then
                ye = yy - 621
            End If
            If mm > 3 Then
                ye = yy - 621
            End If
            If mn <= 9 Then
                StrMonth = "0" + Str(mn)
            Else
                StrMonth = Str(mn)
            End If
            If sd <= 9 Then
                StrDay = "0" + Str(sd)
            Else
                StrDay = Str(sd)
            End If
            LatinToIraniDate = Val(Str(ye) + StrMonth + StrDay)

        End Function

        Private Function IraniToLatinDate(ByVal DateS As Long) As Long
            Dim yer As Long, m As Long, mm As Long, i As Long, A As Long

            yer = Val(Mid$(Str(DateS), 2, 4)) + 621
            Static E(12) As Long
            Dim y As Long
            E(1) = 31 : E(2) = 29 : E(3) = 31 : E(4) = 30 : E(5) = 31 : E(6) = 30 : E(7) = 31 : E(8) = 31 : E(9) = 30
            E(10) = 31 : E(11) = 30 : E(12) = 31
            For m = 1 To 12
                For mm = 1 To E(m)
                    y = Val(Str(yer) & IIf(m < 10, "0" & m, m) & IIf(mm < 10, "0" & mm, mm))
                    i = LatinToIraniDate(y)
                    If i = DateS Then
                        IraniToLatinDate = y
                        Exit Function
                    End If
                Next
            Next
            yer = yer + 1
            For m = 1 To 12
                For mm = 1 To E(m)
                    y = Val(Str(yer) & IIf(m < 10, "0" & m, m) & IIf(mm < 10, "0" & mm, mm))
                    i = LatinToIraniDate(y)
                    If i = DateS Then
                        IraniToLatinDate = y
                        Exit Function
                    End If
                Next
            Next
            A = TestDate(DateS)
        End Function

        Private Function MakeIraniDate8(ByVal Y As Long, ByVal DD As Long)
            Dim m As Long, d As Long
            If DD <= 0 Then
                MakeIraniDate8 = PlussToIraniDate(MakeIraniDate8(Y, 1), DD - 1)
            Else
                If DD <= 6 * 31 Then
                    m = 1 + ((DD - 1) \ 31)
                    d = DD - (m - 1) * 31
                    MakeIraniDate8 = Val(Str(Y) + Format(m, "00") + Format(d, "00"))
                Else
                    If DD > 365 Then
                        If (DD = 366) And (TestYearIsKBS(Y) = True) Then
                            MakeIraniDate8 = Val(Str(Y) + "1230")
                        Else
                            MakeIraniDate8 = PlussToIraniDate(MakeIraniDate8(Y, 365), DD - 365)
                        End If
                    Else
                        m = 7 + (((DD - 1) - 31 * 6) \ 30)
                        d = DD - (6 * 31) - (m - 7) * 30
                        MakeIraniDate8 = Val(Str(Y) + Format(m, "00") + Format(d, "00"))
                    End If
                End If
            End If
        End Function

        Private Function PlussToIraniDate(ByVal FDate8 As Long, ByVal n As Long) As Long
            Dim d As Long, dd As Long, y As Long, m As Long, is_Kbs As Boolean
            If FDate8 = 0 Then
                PlussToIraniDate = 0
                Exit Function
            End If
            y = Left(FDate8, 4)
            is_Kbs = TestYearIsKBS(y)
            d = GetDayNumInIraniYear_GivenDate(FDate8)
            dd = d + n
            Do While True
                If dd < -365 Then
                    FDate8 = PlussToIraniDate(FDate8, d - 365)
                    y = Left(FDate8, 4)
                    y = y - 1
                    is_Kbs = TestYearIsKBS(y)
                    dd = dd + 365
                ElseIf (is_Kbs = True) And (dd > 366) Then
                    FDate8 = PlussToIraniDate(FDate8, 366 - d)
                    y = y + 1
                    is_Kbs = TestYearIsKBS(y)
                    dd = dd - 366
                ElseIf (is_Kbs = False) And (dd > 365) Then
                    FDate8 = PlussToIraniDate(FDate8, 365 - d)
                    y = y + 1
                    is_Kbs = TestYearIsKBS(y)
                    dd = dd - 365
                Else
                    Exit Do
                End If
            Loop
            If dd <= 0 Then
                y = y - 1
                is_Kbs = TestYearIsKBS(y)
                If is_Kbs = True Then
                    dd = 366 + dd
                Else
                    dd = 365 + dd
                End If
            Else
                If dd = 366 Then
                    If is_Kbs = False Then
                        y = y + 1
                        dd = 1
                    End If
                ElseIf dd > 366 Then
                    If is_Kbs = False Then
                        y = y + 1
                        dd = dd - 366 - 1
                    Else
                        y = y + 1
                        dd = dd - 365 - 1
                    End If
                End If
            End If
            PlussToIraniDate = MakeIraniDate8(y, dd)
        End Function

        Private Function WeekNumInIraniYear(ByVal FDate8 As Long) As Long
            Dim d As Long, y As Long
            y = Left(FDate8, 4)
            d = GetDayNumInIraniYear_GivenDate(FDate8)
            d = d + GetDayNumInWeek4GivenDate(Val(Str(y) + "0101"))
            WeekNumInIraniYear = (d - 1 + 6) \ 7
        End Function

        Private Function GetDayNumInWeek4GivenDate(ByVal FDate8 As Long) As String
            Dim y As Long, m As Long, d As Long, E As Long, w As Long
            Dim w1 As Long, k As Long, b As Long, x As Long, A As Long, l As Long
            y = Left(FDate8, 4)
            m = Mid(FDate8, 5, 2)
            d = Right(FDate8, 2)
            If y <= 421 Then
                k = -36
                x = 1
            End If
            If y > 421 And y <= 846 Then
                k = 422
                x = 3
            End If
            If y > 846 And y <= 1073 Then
                k = 847
                x = 6
            End If
            If y > 1073 And y <= 1465 Then
                k = 1074
                x = 1
            End If
            A = Fix((8 * (y - k + 1)) / 33)
            b = Fix(8 * (y - k) / 33)
            l = 365 + A - b
            E = Int(m / 7)
            w1 = y - k
            w1 = w1 * 365
            w = (w1 + b + (31 * (m - 1)) - (E * (m Mod 7)) + d + x) Mod 7
            GetDayNumInWeek4GivenDate = w + 1
        End Function

        Public Function GetDayNumInIraniYear_GivenDate(ByVal FDate8 As Long) As Long    '‘„«—Â —Ê“  «—ÌŒ „Ê—œ ‰Ÿ— œ— ”«· «Ì—«‰Ì —« »— „Ìê—œ«‰œ
            Dim m As Long, d As Long
            If FDate8 < 1000 Then
                GetDayNumInIraniYear_GivenDate = 0
                Exit Function
            End If
            m = Mid(FDate8, 5, 2)
            d = Right(FDate8, 2)
            Select Case m
                Case Is <= 7
                    GetDayNumInIraniYear_GivenDate = (m - 1) * 31 + d
                Case Else
                    GetDayNumInIraniYear_GivenDate = 6 * 31 + (m - 7) * 30 + d
            End Select
        End Function

        Public Function TestYearIsKBS(ByVal Y) As Object
            Dim S As Long, kkb As Long, X As Long
            Dim w As Long, ym As Long, rp As Long
            S = Fix((Y + 16) / 33)
            kkb = S * 33 - 16
            X = Fix((Y + 15) / 33)
            w = Y - X - 17
            If (w Mod 4) <> 0 Then
                TestYearIsKBS = False
            Else
                ym = Y
                X = Int((ym + 16) / 33)
                rp = 0
                w = ym - X - 17
                If kkb + 1 = ym Then
                    TestYearIsKBS = False
                Else
                    TestYearIsKBS = True
                End If
            End If
        End Function

        Private Function IraniDayName(ByVal FDate8 As Long) As String
            Static day1(7) As String
            Dim w As Long
            day1(1) = "‘‰»Â"
            day1(2) = "Ìﬂ‘‰»Â"
            day1(3) = "œÊ‘‰»Â"
            day1(4) = "”Â ‘‰»Â"
            day1(5) = "çÂ«— ‘‰»Â"
            day1(6) = "Å‰ç ‘‰»Â"
            day1(7) = "Ã„⁄Â"
            w = GetDayNumInWeek4GivenDate(FDate8)
            IraniDayName = day1(w) 'day1(w + 1)
        End Function

        Private Function IraniDate(ByVal cas As Long) As Long
            Static E(12) As Long
            Static d(4, 12) As Long
            Static p(4, 12) As Long
            Static n(2, 12) As Long
            Dim YY, MM, DD, u, rag, h, ym, X, rp, w, s, kkb, i As Long
            Dim z, sd, mn, ls, ye As Long
            Dim ny, r As String
            Dim StrMonth, StrDay As String

            E(1) = 31 : E(2) = 28 : E(3) = 31 : E(4) = 30 : E(5) = 31 : E(6) = 30 : E(7) = 31 : E(8) = 13 : E(9) = 30
            E(10) = 31 : E(11) = 30 : E(12) = 31
            '---------------------------d(1,3)=19
            d(1, 1) = 20 : d(1, 2) = 19 : d(1, 3) = 19 : d(1, 4) = 19 : d(1, 5) = 20 : d(1, 6) = 20 : d(1, 7) = 21 : d(1, 8) = 21 : d(1, 9) = 21 : d(1, 10) = 21 : d(1, 11) = 20 : d(1, 12) = 20
            d(2, 1) = 19 : d(2, 2) = 18 : d(2, 3) = 20 : d(2, 4) = 20 : d(2, 5) = 21 : d(2, 6) = 21 : d(2, 7) = 22 : d(2, 8) = 22 : d(2, 9) = 22 : d(2, 10) = 22 : d(2, 11) = 21 : d(2, 12) = 21
            d(3, 1) = 20 : d(3, 2) = 19 : d(3, 3) = 20 : d(3, 4) = 20 : d(3, 5) = 21 : d(3, 6) = 21 : d(3, 7) = 22 : d(3, 8) = 22 : d(3, 9) = 22 : d(3, 10) = 22 : d(3, 11) = 21 : d(3, 12) = 21
            d(4, 1) = 20 : d(4, 2) = 19 : d(4, 3) = 20 : d(4, 4) = 20 : d(4, 5) = 21 : d(4, 6) = 21 : d(4, 7) = 22 : d(4, 8) = 22 : d(4, 9) = 22 : d(4, 10) = 22 : d(4, 11) = 21 : d(4, 12) = 21
            p(1, 1) = 11 : p(1, 2) = 12 : p(1, 3) = 11 : p(1, 4) = 13 : p(1, 5) = 12 : p(1, 6) = 12 : p(1, 7) = 11 : p(1, 8) = 11 : p(1, 9) = 11 : p(1, 10) = 10 : p(1, 11) = 11 : p(1, 12) = 11
            p(2, 1) = 12 : p(2, 2) = 13 : p(2, 3) = 11 : p(2, 4) = 12 : p(2, 5) = 11 : p(2, 6) = 11 : p(2, 7) = 10 : p(2, 8) = 10 : p(2, 9) = 10 : p(2, 10) = 9 : p(2, 11) = 10 : p(2, 12) = 10
            p(3, 1) = 11 : p(3, 2) = 12 : p(3, 3) = 10 : p(3, 4) = 12 : p(3, 5) = 11 : p(3, 6) = 11 : p(3, 7) = 10 : p(3, 8) = 10 : p(3, 9) = 10 : p(3, 10) = 9 : p(3, 11) = 10 : p(3, 12) = 10
            p(4, 1) = 11 : p(4, 2) = 12 : p(4, 3) = 11 : p(4, 4) = 12 : p(4, 5) = 11 : p(4, 6) = 11 : p(4, 7) = 10 : p(4, 8) = 10 : p(4, 9) = 10 : p(4, 10) = 9 : p(4, 11) = 10 : p(4, 12) = 10
            n(1, 1) = 10 : n(1, 2) = 11 : n(1, 3) = 12 : n(1, 4) = 1 : n(1, 5) = 2 : n(1, 6) = 3 : n(1, 7) = 4 : n(1, 8) = 5 : n(1, 9) = 6 : n(1, 10) = 7 : n(1, 11) = 8 : n(1, 12) = 9
            n(2, 1) = 11 : n(2, 2) = 12 : n(2, 3) = 1 : n(2, 4) = 2 : n(2, 5) = 3 : n(2, 6) = 4 : n(2, 7) = 5 : n(2, 8) = 6 : n(2, 9) = 7 : n(2, 10) = 8 : n(2, 11) = 9 : n(2, 12) = 10

            Dim DR1 As SqlClient.SqlDataReader
            Dim orst1 As New Persistent.DataAccess.DataAccess
            Dim wstr1 = "SELECT YEAR(GETDATE()) AS SvrCurYear, MONTH(GETDATE()) AS SvrCurMonth, DAY(GETDATE()) AS SvrCurDay"
            orst1.FillDataReader(DR1, wstr1, strConnection)
            DR1.Read()

            YY = DR1("SvrCurYear") 'Year(Now)
            MM = DR1("SvrCurMonth") 'Month(Now)
            DD = DR1("SvrCurDay") 'Microsoft.VisualBasic.DateAndTime.Day(Now)

            u = 0

            If YY Mod 4 = 0 Then
                u = 1
            End If

            ny = Str(YY)
            r = Right(ny, 2)
            rag = Val(r)

            If rag = 0 And YY Mod 400 <> 0 Then
                u = 0
            End If

            h = 0

            If MM = 2 And u = 1 Then
                h = 1
            End If

            ym = YY - 622
            X = Int((ym + 16) / 33)
            w = ym - X - 17

            rp = 0
            If w Mod 4 = 0 Then
                rp = 1
            End If

            s = Int((ym + 16) / 33)
            kkb = s * 33 - 16
            If kkb + 1 = ym Then
                rp = 0
            End If
            If u = 1 And rp = 0 Then
                i = 1
            End If
            If u = 0 And rp = 1 Then
                i = 2
            End If
            If u = 0 And rp = 0 Then
                i = 3
            End If
            If u = 1 And rp = 1 Then
                i = 4
            End If
            z = 0
            If i = 4 And MM = 3 Then
                z = 1
            End If
            If i = 4 Then
                i = 3
            End If

            If 1 <= DD And DD <= d(i, MM) Then
                sd = p(i, MM) + DD + z - 1
                mn = n(1, MM)
                ls = 1
            Else
                sd = DD - d(i, MM)
                mn = n(2, MM)
                ls = 2
            End If
            If MM <= 3 Then
                ye = YY - 622
            End If
            If MM = 3 And ls = 2 Then
                ye = YY - 621
            End If
            If MM > 3 Then
                ye = YY - 621
            End If
            Select Case cas
                Case 1
                    IraniDate = ye
                Case 2
                    IraniDate = mn
                Case 3
                    IraniDate = sd
                Case Else
                    If mn <= 9 Then
                        StrMonth = "0" + Str(mn)
                    Else
                        StrMonth = Str(mn)
                    End If
                    If sd <= 9 Then
                        StrDay = "0" + Str(sd)
                    Else
                        StrDay = Str(sd)
                    End If
                    Select Case cas
                        Case 4
                            IraniDate = Val(StrMonth + StrDay)
                        Case 6
                            IraniDate = Val(Right(Str(ye), 2) + StrMonth + StrDay)
                        Case 8
                            IraniDate = Val(Str(ye) + StrMonth + StrDay)
                    End Select
            End Select
        End Function

        Private Function DatefI(ByVal DateMe As Long) As Long
            Static E(12) As Integer
            Static d(4, 12) As Integer
            Static p(4, 12) As Integer
            Static n(2, 12) As Integer
            Dim yy, j, dd, u, rag, h, ym, x, rp, w, s, kkb, i As Integer
            Dim z, sd, mn, ls, ye As Integer
            Dim ny, r, StrMonth, StrDay As String
            E(1) = 31 : E(2) = 28 : E(3) = 31 : E(4) = 30 : E(5) = 31 : E(6) = 30 : E(7) = 31 : E(8) = 13 : E(9) = 30
            E(10) = 31 : E(11) = 30 : E(12) = 31
            '---------------------------d(1,3)=19
            d(1, 1) = 20 : d(1, 2) = 19 : d(1, 3) = 19 : d(1, 4) = 19 : d(1, 5) = 20 : d(1, 6) = 20 : d(1, 7) = 21 : d(1, 8) = 21 : d(1, 9) = 21 : d(1, 10) = 21 : d(1, 11) = 20 : d(1, 12) = 20
            d(2, 1) = 19 : d(2, 2) = 18 : d(2, 3) = 20 : d(2, 4) = 20 : d(2, 5) = 21 : d(2, 6) = 21 : d(2, 7) = 22 : d(2, 8) = 22 : d(2, 9) = 22 : d(2, 10) = 22 : d(2, 11) = 21 : d(2, 12) = 21
            d(3, 1) = 20 : d(3, 2) = 19 : d(3, 3) = 20 : d(3, 4) = 20 : d(3, 5) = 21 : d(3, 6) = 21 : d(3, 7) = 22 : d(3, 8) = 22 : d(3, 9) = 22 : d(3, 10) = 22 : d(3, 11) = 21 : d(3, 12) = 21
            d(4, 1) = 20 : d(4, 2) = 19 : d(4, 3) = 20 : d(4, 4) = 20 : d(4, 5) = 21 : d(4, 6) = 21 : d(4, 7) = 22 : d(4, 8) = 22 : d(4, 9) = 22 : d(4, 10) = 22 : d(4, 11) = 21 : d(4, 12) = 21
            p(1, 1) = 11 : p(1, 2) = 12 : p(1, 3) = 11 : p(1, 4) = 13 : p(1, 5) = 12 : p(1, 6) = 12 : p(1, 7) = 11 : p(1, 8) = 11 : p(1, 9) = 11 : p(1, 10) = 10 : p(1, 11) = 11 : p(1, 12) = 11
            p(2, 1) = 12 : p(2, 2) = 13 : p(2, 3) = 11 : p(2, 4) = 12 : p(2, 5) = 11 : p(2, 6) = 11 : p(2, 7) = 10 : p(2, 8) = 10 : p(2, 9) = 10 : p(2, 10) = 9 : p(2, 11) = 10 : p(2, 12) = 10
            p(3, 1) = 11 : p(3, 2) = 12 : p(3, 3) = 10 : p(3, 4) = 12 : p(3, 5) = 11 : p(3, 6) = 11 : p(3, 7) = 10 : p(3, 8) = 10 : p(3, 9) = 10 : p(3, 10) = 9 : p(3, 11) = 10 : p(3, 12) = 10
            p(4, 1) = 11 : p(4, 2) = 12 : p(4, 3) = 11 : p(4, 4) = 12 : p(4, 5) = 11 : p(4, 6) = 11 : p(4, 7) = 10 : p(4, 8) = 10 : p(4, 9) = 10 : p(4, 10) = 9 : p(4, 11) = 10 : p(4, 12) = 10
            n(1, 1) = 10 : n(1, 2) = 11 : n(1, 3) = 12 : n(1, 4) = 1 : n(1, 5) = 2 : n(1, 6) = 3 : n(1, 7) = 4 : n(1, 8) = 5 : n(1, 9) = 6 : n(1, 10) = 7 : n(1, 11) = 8 : n(1, 12) = 9
            n(2, 1) = 11 : n(2, 2) = 12 : n(2, 3) = 1 : n(2, 4) = 2 : n(2, 5) = 3 : n(2, 6) = 4 : n(2, 7) = 5 : n(2, 8) = 6 : n(2, 9) = 7 : n(2, 10) = 8 : n(2, 11) = 9 : n(2, 12) = 10
            yy = Mid$(Str(DateMe), 2, 4)
            j = Mid$(Str(DateMe), 6, 2)
            dd = Mid$(Str(DateMe), 8, 2)
            u = 0

            If yy Mod 4 = 0 Then
                u = 1
            End If

            ny = Str(yy)
            r = Right(ny, 2)
            rag = Val(r)

            If rag = 0 And yy Mod 400 <> 0 Then
                u = 0
            End If

            h = 0

            If j = 2 And u = 1 Then
                h = 1
            End If

            ym = yy - 622
            'x = Int((ym + 16) / 33)
            x = Int((ym + 15) / 33)
            rp = 0
            w = ym - x - 17

            'rp=0 »Êœ
            If w Mod 4 = 0 Then
                rp = 1
            End If


            s = Int((ym + 16) / 33)
            kkb = s * 33 - 16
            If kkb + 1 = ym Then
                rp = 0
            End If
            If u = 1 And rp = 0 Then
                i = 1
            End If
            If u = 0 And rp = 1 Then
                i = 2
            End If
            If u = 0 And rp = 0 Then
                i = 3
            End If
            If u = 1 And rp = 1 Then
                i = 4
            End If
            z = 0
            If i = 4 And j = 3 Then
                z = 1
            End If
            If i = 4 Then
                i = 3
            End If

            If 1 <= dd And dd <= d(i, j) Then
                sd = p(i, j) + dd + z - 1
                mn = n(1, j)
                ls = 1
            Else
                sd = dd - d(i, j)
                mn = n(2, j)
                ls = 2
            End If
            If j <= 3 Then
                ye = yy - 622
            End If
            If j = 3 And ls = 2 Then
                ye = yy - 621
            End If
            If j > 3 Then
                ye = yy - 621
            End If
            If mn <= 9 Then
                StrMonth = "0" + Str(mn)
            Else
                StrMonth = Str(mn)
            End If
            If sd <= 9 Then
                StrDay = "0" + Str(sd)
            Else
                StrDay = Str(sd)
            End If
            DatefI = Val(Str(ye) + StrMonth + StrDay)

        End Function

        Private Function IraniDayNum(ByVal FDate8 As Long) As Long
            Dim m As Long, d As Long
            If FDate8 < 1000 Then
                IraniDayNum = 0
                Exit Function
            End If
            m = Mid(FDate8, 5, 2)
            d = Right(FDate8, 2)
            Select Case m
                Case Is <= 7
                    IraniDayNum = (m - 1) * 31 + d
                Case Else
                    IraniDayNum = 6 * 31 + (m - 7) * 30 + d
            End Select
        End Function

        Public Function GetWeekDateInfo(ByVal IraniYear As Integer, ByVal IraniWeekNum As Integer) As DataTable ' «ÿ·«⁄«  —Ê“Â«Ì Ìﬂ Â› Â „Ê—œ ‰Ÿ— —« «—«∆Â „Ìﬂ‰œ
            Dim ps1 As New Persistent.DataAccess.DataAccess
            Dim SqlStr As String = ""

            SqlStr = "SELECT CalID,CalIraniDate,CalLatinDate,CalDayStatusID,CalWeekID,CalIraniWeekNum,CalIraniYearID " & _
                "FROM   HumanResource_Del1.dbo.tbRCL_Calendar_Machin " & _
                "WHERE CalIraniWeekNum=" & IraniWeekNum & " And CalIraniYearID=" & IraniYear
            Try
                GetWeekDateInfo = ps1.GetDataTable(strConnection, SqlStr)
            Catch ex As SqlClient.SqlException
                MsgBox(ex.Message)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Function

    End Class ' «»⁄Â«Ì „—»Êÿ »Â  «—ÌŒ

    Public Class Times
        Public Enum TimeState
            ToDay = 1
            Tomorrow = 2
        End Enum

        Public Function GetTimeTxt_Cur() As String
            Dim SCHour, SCMinute, SCSecond As Integer
            Dim DR1 As SqlClient.SqlDataReader
            Dim orst1 As New Persistent.DataAccess.DataAccess
            Dim wstr1 = "SELECT { fn HOUR(GETDATE()) } AS SvrCurHour, { fn MINUTE(GETDATE()) } AS SvrCurMinute, { fn SECOND(GETDATE()) } AS SvrCurSecond"
            orst1.FillDataReader(DR1, wstr1, strConnection)
            DR1.Read()

            SCHour = DR1("SvrCurHour") 'Year(Now)
            SCMinute = DR1("SvrCurMinute") 'Month(Now)
            'SCSecond = DR1("SvrCurSecond")
            'GetTimeTxt_Cur = Format(Val(LTrim(RTrim(Str(Now.Hour)))), "00") + ":" + Format(Val(LTrim(RTrim(Str(Now.Minute)))), "00")
            GetTimeTxt_Cur = Format(SCHour, "00") + ":" + Format(SCMinute, "00")
        End Function '‘ﬂ· ﬂ«—«ﬂ —Ì ”«⁄  ﬂ‰Ê‰Ì —« »—„Ìê—œ«‰œ

        Public Function GetTimeMinute(ByVal Hour As String) As Integer
            Dim i, j As Integer
            i = Len(Hour)
            For j = 1 To i
                If Mid(Hour, j, 1) = ":" Then
                    GetTimeMinute = (Val(Left(Hour, j - 1)) * 60) + (Val(Right(Hour, 2)))
                    Exit Function
                End If
            Next
        End Function

        Public Function GetTimeMinute(ByVal Hour As Object, ByVal DayState As Integer) As Integer ', Optional ByVal DayState As Integer = 1
            Dim i, j As Integer
            i = Len(Hour)
            For j = 1 To i
                If Mid(Hour, j, 1) = ":" Then
                    If DayState = 1 Then
                        GetTimeMinute = (Val(Left(Hour, j - 1)) * 60) + (Val(Right(Hour, 2)))
                        Exit Function
                    ElseIf DayState = 2 Then
                        GetTimeMinute = 1440 + (Val(Left(Hour, j - 1)) * 60) + (Val(Right(Hour, 2)))
                        Exit Function
                    End If
                End If
            Next
        End Function

        Public Function GetTimeHour(ByVal Minute As Integer) As String
            GetTimeHour = Format((Minute \ 60), "00") + ":" + Format((Minute Mod 60), "00")
        End Function

        Public Function GetTimeMinuteBet2Hour(ByVal FHour As String, ByVal EHour As String) As Integer '«Œ ·«› „Ì«‰ œÊ “„«‰ œ— Ìﬂ —Ê“
            Dim EHour1, FHour1 As Integer
            FHour1 = GetTimeMinute(FHour)
            EHour1 = GetTimeMinute(EHour)
            If EHour1 >= FHour1 Then
                GetTimeMinuteBet2Hour = EHour1 - FHour1
            Else
                GetTimeMinuteBet2Hour = -1
            End If
        End Function

        Public Function TimeCheck(ByVal Time1 As String, Optional ByVal ShowError As Boolean = False) As Boolean
            Dim L1 As Boolean = False
            Dim L2 As Boolean = False
            Dim L3 As Boolean = False
            Dim L4 As Boolean = False

            Dim LSeparator As Boolean = False

            If Len(Time1) <> 5 Then
                If ShowError Then
                    MsgBox("”«⁄  €Ì— „⁄ »—")
                End If
                Return False
            End If

            L1 = Microsoft.VisualBasic.IsNumeric(Mid(Time1, 1, 1))
            L2 = Microsoft.VisualBasic.IsNumeric(Mid(Time1, 2, 1))
            L3 = Microsoft.VisualBasic.IsNumeric(Mid(Time1, 4, 1))
            L4 = Microsoft.VisualBasic.IsNumeric(Mid(Time1, 5, 1))
            LSeparator = Mid(Time1, 3, 1) = ":"
            If Not (L1 And L2 And L3 And L4 And LSeparator) Then
                If ShowError Then
                    MsgBox("”«⁄  €Ì— „⁄ »—")
                End If
                Return False
            End If

            If Val(Mid(Time1, 1, 2)) > 24 Then
                If ShowError Then
                    MsgBox("”«⁄  »«Ìœ »Ì‰ 0  « 24 »«‘œ")
                End If
                Return False
            ElseIf Val(Mid(Time1, 1, 2)) = 24 Then
                If Val(Mid(Time1, 4, 2)) <> 0 Then
                    If ShowError Then
                        MsgBox("”«⁄  €Ì— „⁄ »—")
                    End If
                    Return False
                End If
            End If

            If Val(Mid(Time1, 4, 2)) > 59 Then
                If ShowError Then
                    MsgBox("œﬁÌﬁÂ »«Ìœ »Ì‰ 0  « 59 »«‘œ")
                End If
                Return False
            End If

            Return True
        End Function

        Public Function TimeDif(ByVal Time1 As String, ByVal Time2 As String, Optional ByVal ShowError As Boolean = False) As String
            Dim IsNegative As Boolean = False
            Dim Time1Daghigeh As Integer
            Dim Time2Daghigeh As Integer
            Dim DifTime As Integer
            Dim DifDaghigeh As Integer
            Dim DifSaatStr As String
            Dim DifDaghigehStr As String
            Dim DifSaat As Integer

            If (TimeCheck(Time1) = False) Or (TimeCheck(Time2) = False) Then
                If ShowError Then
                    MsgBox("ÌﬂÌ «“ œÊ ”«⁄  €Ì— „⁄ »— „Ì »«‘œ")
                End If
                Return "Error"
            End If

            Time1Daghigeh = Val(Mid(Time1, 1, 2)) * 60 + Val(Mid(Time1, 4, 2))
            Time2Daghigeh = Val(Mid(Time2, 1, 2)) * 60 + Val(Mid(Time2, 4, 2))

            DifTime = Time2Daghigeh - Time1Daghigeh

            If DifTime < 0 Then
                DifTime = -DifTime
                IsNegative = True
            End If

            DifSaat = DifTime \ 60
            DifDaghigeh = DifTime Mod 60

            DifSaatStr = IIf(DifSaat < 10, "0" & Str(DifSaat).Trim, Str(DifSaat).Trim)
            DifDaghigehStr = IIf(DifDaghigeh < 10, "0" & Str(DifDaghigeh).Trim, Str(DifDaghigeh).Trim)

            If IsNegative Then
                Return "-" & DifSaatStr & ":" & DifDaghigehStr
            Else
                Return DifSaatStr & ":" & DifDaghigehStr
            End If

        End Function

        Public Function GetEndHour(ByVal BeginHour As String, ByRef TimeState1 As Integer, ByVal DifTime As Integer, Optional ByVal ShowError As Boolean = False) As String
            Dim BeginMinute, EndMinute As Integer
            'If (TimeCheck(BeginHour) = False) Then
            '    If ShowError Then
            '        MsgBox("”«⁄  €Ì— „⁄ »— „Ì »«‘œ")
            '    End If
            '    Return "Error"
            'End If

            BeginMinute = GetTimeMinute(BeginHour)
            EndMinute = BeginMinute + DifTime

            If EndMinute < 1440 Then
                TimeState1 = 1
                GetEndHour = GetTimeHour(EndMinute)
            ElseIf EndMinute >= 1440 Then
                TimeState1 = 2
                GetEndHour = GetTimeHour(EndMinute - 1440)
            End If
            'GetEndHour = GetTimeHour(EndMinute)
        End Function '”«⁄  Å«Ì«‰ —« »— «”«” ”«⁄  ‘—Ê⁄ Ê „œ  “„«‰  ⁄ÌÌ‰ ‘œÂ »œ”  „ÌœÂœ

        Public Function StringTime(ByVal PackTime As String) As String
            Dim UnPkTime As String
            UnPkTime = Trim(PackTime)
            If Len(UnPkTime) = 1 And Val(Mid(UnPkTime, 1, 1)) < 10 Then

                StringTime = "0" & Mid(UnPkTime, 1, 2) & ":00"
                Exit Function
            End If
            If Len(UnPkTime) = 2 And Val(Mid(UnPkTime, 1, 2)) < 24 Then

                StringTime = Mid(UnPkTime, 1, 2) & ":00"
                Exit Function
            End If
            If Len(UnPkTime) = 2 And Val(Mid(UnPkTime, 1, 2)) = 24 Then

                StringTime = "00:00"
                Exit Function
            End If
            If Len(UnPkTime) = 3 And Val(Mid(UnPkTime, 2, 2)) < 60 Then

                StringTime = "0" & Mid(UnPkTime, 1, 1) & ":" & Mid(UnPkTime, 2, 2)
                Exit Function
            End If
            If Len(UnPkTime) <> 4 Or Val(Mid(UnPkTime, 3, 2)) > 59 Or Val(Mid(UnPkTime, 1, 2)) > 24 Then
                StringTime = "  :  "
                Exit Function
            End If
            If Val(UnPkTime) >= 1 And Val(UnPkTime) < 2401 Then

                StringTime = Mid(UnPkTime, 1, 2) & ":" & Mid(UnPkTime, 3, 2)

            ElseIf Val(PackTime) = 0 Then
                StringTime = "00:00"
            Else
                StringTime = "  :  "
            End If
        End Function

        Public Function PackTime(ByVal NormalTime As String) As String
            Dim nLen, i As Integer
            Dim PackTimeStr As String
            PackTimeStr = ""
            nLen = Len(NormalTime)
            For i = 1 To nLen
                If InStr("0123456789", Mid(NormalTime, i, 1)) > 0 Then
                    PackTimeStr = PackTimeStr & Mid(NormalTime, i, 1)
                End If
            Next i
            PackTime = PackTimeStr
        End Function

    End Class '  «»⁄Â«Ì „—»Êÿ »Â ”«⁄ 



    'Public Class CurrentDate
    '    Public Function CurrentServerShamsiDate() As String
    '        Dim eq As New NSPDataBase.ExecueQuery
    '        CurrentServerShamsiDate = eq.ExcuteScalarQuery(CnWareSupplyStr, _
    '          "Exec generalObjects.dbo.SpGen_CurrentShamsiDateS")
    '    End Function

    '    Public Function CurrentServerTime() As String
    '        Dim eq As New NSPDataBase.ExecueQuery
    '        CurrentServerTime = eq.ExcuteScalarQuery(CnWareSupplyStr, _
    '          "Exec generalObjects.dbo.SpGen_CurrentTimeS")
    '    End Function

    'End Class
End Namespace
