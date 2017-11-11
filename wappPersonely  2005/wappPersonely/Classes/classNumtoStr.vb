Public Class classNumtoStr
    Public Function ConvNumToAlpha(ByVal cNumber As String) As String
        Dim nLen3Num, nCounter As Integer
        Dim cSubText As String
        Dim cStrNum As String

        acYekGon(0) = "" : acYekGon(1) = " �� " : acYekGon(2) = " ��" : acYekGon(3) = " �� "
        acYekGon(4) = " ���� " : acYekGon(5) = " ��� " : acYekGon(6) = " �� " : acYekGon(7) = " ��� "
        acYekGon(8) = " ��� " : acYekGon(9) = " �� "

        acDahGon1(0) = "�� " : acDahGon1(1) = " ����� " : acDahGon1(2) = " ������ " : acDahGon1(3) = " ����� "
        acDahGon1(4) = " ������ " : acDahGon1(5) = " ������ " : acDahGon1(6) = " ������ " : acDahGon1(7) = " ���� "
        acDahGon1(8) = " ���� " : acDahGon1(9) = " ����� "

        acDahGon(0) = "" : acDahGon(1) = "" : acDahGon(2) = " ���� " : acDahGon(3) = " �� "
        acDahGon(4) = " ��� " : acDahGon(5) = " ����� " : acDahGon(6) = " ��� " : acDahGon(7) = " ����� "
        acDahGon(8) = "����� " : acDahGon(9) = " ��� "

        acSadGon(0) = "" : acSadGon(1) = " �� " : acSadGon(2) = " ����� " : acSadGon(3) = " ���� "
        acSadGon(4) = " ������ " : acSadGon(5) = " ����� " : acSadGon(6) = " ���� " : acSadGon(7) = " ����� "
        acSadGon(8) = "����� " : acSadGon(9) = " ���� "

        acApend(0) = "" : acApend(1) = "" : acApend(2) = " ���� " : acApend(3) = " ������ "
        acApend(4) = " ������� " : acApend(5) = " ������� "

        '    Num = 0
        cStrNum = ""
        cTextNum = ""

        If Val(cNumber) > 0 Then

            ' ***** ������ ��� ��� �� ����� �� 3
            cStrNum = LTrim(RTrim(Str(cNumber)))
            Do While (Len(cStrNum) / 3) <> Int(Len(cStrNum) / 3)
                cStrNum = "0" & cStrNum
            Loop

            '******������ ��� ��� ����� ��� �� �� ���
            nLen3Num = 0
            For nCounter = 1 To Len(cStrNum) Step 3
                nLen3Num = nLen3Num + 1
            Next nCounter

            '******* ����� ���� ��� ��� �� ���� ��� ���� ��� �����
            For nCounter = 1 To Len(cStrNum) Step 3
                cSubText = Mid(cStrNum, nCounter, 3)
                Call String3N(cSubText, nLen3Num)
                nLen3Num = nLen3Num - 1
            Next nCounter
            ConvNumToAlpha = cTextNum
        Else
            ConvNumToAlpha = "���"
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
                cTextNum = cTextNum + "�"
            End If

            c3Num = acSadGon(Int(cHan))

            If Len(LTrim(RTrim((c3Num)))) > 0 And cTen <> "0" Then
                c3Num = c3Num + "�"
            End If

            If cTen = "1" Then
                c3Num = c3Num + acDahGon1(Int(cOne))

                c3Num = c3Num + acApend(nConter3)

                cTextNum = cTextNum + c3Num

            Else

                c3Num = c3Num + acDahGon(Int(cTen))

                If Len(LTrim(RTrim((c3Num)))) > 0 And (cOne <> "0" And cTen <> "1") Then
                    c3Num = c3Num + " �"
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
