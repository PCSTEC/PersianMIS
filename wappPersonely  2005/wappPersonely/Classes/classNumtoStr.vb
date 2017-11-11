Public Class classNumtoStr
    Public Function ConvNumToAlpha(ByVal cNumber As String) As String
        Dim nLen3Num, nCounter As Integer
        Dim cSubText As String
        Dim cStrNum As String

        acYekGon(0) = "" : acYekGon(1) = " Ìﬂ " : acYekGon(2) = " œÊ" : acYekGon(3) = " ”Â "
        acYekGon(4) = " çÂ«— " : acYekGon(5) = " Å‰Ã " : acYekGon(6) = " ‘‘ " : acYekGon(7) = " Â›  "
        acYekGon(8) = " Â‘  " : acYekGon(9) = " ‰Â "

        acDahGon1(0) = "œÂ " : acDahGon1(1) = " Ì«“œÂ " : acDahGon1(2) = " œÊ«“œÂ " : acDahGon1(3) = " ”Ì“œÂ "
        acDahGon1(4) = " çÂ«—œÂ " : acDahGon1(5) = " Å«‰“œÂ " : acDahGon1(6) = " ‘«‰“œÂ " : acDahGon1(7) = " Â›œÂ "
        acDahGon1(8) = " ÂÃœÂ " : acDahGon1(9) = " ‰Ê“œÂ "

        acDahGon(0) = "" : acDahGon(1) = "" : acDahGon(2) = " »Ì”  " : acDahGon(3) = " ”Ì "
        acDahGon(4) = " çÂ· " : acDahGon(5) = " Å‰Ã«Â " : acDahGon(6) = " ‘’  " : acDahGon(7) = " Â› «œ "
        acDahGon(8) = "Â‘ «œ " : acDahGon(9) = " ‰Êœ "

        acSadGon(0) = "" : acSadGon(1) = " ’œ " : acSadGon(2) = " œÊÌ”  " : acSadGon(3) = " ”Ì’œ "
        acSadGon(4) = " çÂ«—’œ " : acSadGon(5) = " Å«‰’œ " : acSadGon(6) = " ‘‘’œ " : acSadGon(7) = " Â› ’œ "
        acSadGon(8) = "Â‘ ’œ " : acSadGon(9) = " ‰Â’œ "

        acApend(0) = "" : acApend(1) = "" : acApend(2) = " Â“«— " : acApend(3) = " „Ì·ÌÊ‰ "
        acApend(4) = " „Ì·Ì«—œ " : acApend(5) = "  —Ì·ÌÊ‰ "

        '    Num = 0
        cStrNum = ""
        cTextNum = ""

        If Val(cNumber) > 0 Then

            ' ***** —”«‰œ‰ ÿÊ· ⁄œœ »Â „÷—»Ì «“ 3
            cStrNum = LTrim(RTrim(Str(cNumber)))
            Do While (Len(cStrNum) / 3) <> Int(Len(cStrNum) / 3)
                cStrNum = "0" & cStrNum
            Loop

            '******„Õ«”»Â ÿÊ· ⁄œœ  ›ﬂÌﬂ ‘œÂ »Â ”Â —ﬁ„
            nLen3Num = 0
            For nCounter = 1 To Len(cStrNum) Step 3
                nLen3Num = nLen3Num + 1
            Next nCounter

            '******* «—”«· Â—”Â —ﬁ„ ⁄œœ »Â  «»⁄ ÃÂ   ÂÌÂ „ ‰ Œ—ÊÃÌ
            For nCounter = 1 To Len(cStrNum) Step 3
                cSubText = Mid(cStrNum, nCounter, 3)
                Call String3N(cSubText, nLen3Num)
                nLen3Num = nLen3Num - 1
            Next nCounter
            ConvNumToAlpha = cTextNum
        Else
            ConvNumToAlpha = "’›—"
        End If
    End Function

    Private Sub String3N(ByVal cText3 As String, ByVal nConter3 As Integer)
        '''''''''''''''''''
        On Error Resume Next
        '''''''''''''''''''
        Dim cOne
        Dim cTen
        Dim cHan
        Dim c3Num

        cOne = Mid(cText3, 3, 1)
        cTen = Mid(cText3, 2, 1)
        cHan = Mid(cText3, 1, 1)


        If cText3 <> "000" Then
            If Len(LTrim(RTrim(cTextNum))) > 0 Then
                cTextNum = cTextNum + "Ê"
            End If

            c3Num = acSadGon(Int(cHan))

            If Len(LTrim(RTrim((c3Num)))) > 0 And cTen <> "0" Then
                c3Num = c3Num + "Ê"
            End If

            If cTen = "1" Then
                c3Num = c3Num + acDahGon1(Int(cOne))

                c3Num = c3Num + acApend(nConter3)

                cTextNum = cTextNum + c3Num

            Else

                c3Num = c3Num + acDahGon(Int(cTen))

                If Len(LTrim(RTrim((c3Num)))) > 0 And (cOne <> "0" And cTen <> "1") Then
                    c3Num = c3Num + " Ê"
                End If

                If cTen <> "1" Then
                    c3Num = c3Num + acYekGon(Int(cOne))
                End If

                c3Num = c3Num + acApend(nConter3)
                cTextNum = cTextNum + c3Num

            End If
        End If

    End Sub

End Class
