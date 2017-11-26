Public Class ManageAscribe
    Public Function ChkAscFDateIsSmallerEDate_Machin(ByVal AscribeID As Integer, ByRef MyDate As String) As Boolean
        Dim sqlstr1, AscToDateP, AscFromDateP As String
        Dim dt1 As DataTable
        Dim ir1 As New IraniDate.IraniDate.IraniDate

        sqlstr1 = "SELECT AscribeID,AscShiftID,AscMDepartID,AscFromDate,AscToDate,AscInShiftMDID ,AcsStateID,AscShiftType " & _
            "FROM tbRCL_ShiftAscribe_Machin WHERE AscribeID=" & AscribeID
        dt1 = ps1.GetDataTable(strConnection, sqlstr1)

        AscToDateP = dt1.DefaultView.Item(0).Item("AscToDate")
        AscFromDateP = ir1.StringDate(ir1.GetPlussToIraniDate(ir1.Numericdate(dt1.DefaultView.Item(0).Item("AscFromDate")), -1))

        If dt1.DefaultView.Item(0).Item("AcsStateID") = 2 Then
            sqlstr1 = _
            "SELECT     tbRCL_ShiftAscribe_Machin.AscribeID, tbRCL_ShiftAscribe_Machin.AscShiftID, tbRCL_ShiftAscribe_Machin.AscMDepartID,  " & _
            "                      tbRCL_ShiftAscribe_Machin.Ascription, tbRCL_ShiftAscribe_Machin.AscNetWorkTime, tbRCL_ShiftAscribe_Machin.AscNetBreakTime,  " & _
            "                      tbRCL_ShiftAscribe_Machin.AscAllTime, tbRCL_ShiftAscribe_Machin.AcsStateID, tbRCL_ShiftAscribe_Machin.AscFromDate,  " & _
            "                      tbRCL_ShiftAscribe_Machin.AscToDate, tbRCL_ShiftAscribe_Machin.AscInShiftMDID, tbRCL_Shifts.ShiftType " & _
            "FROM         tbRCL_ShiftAscribe_Machin INNER JOIN " & _
            "                      tbRCL_Shifts ON tbRCL_ShiftAscribe_Machin.AscShiftID = tbRCL_Shifts.ShiftID " & _
            "WHERE  (dbo.tbRCL_ShiftAscribe_Machin.AscMDepartID = '" & dt1.DefaultView.Item(0).Item("AscMDepartID") & "') AND   (tbRCL_ShiftAscribe_Machin.AscFromDate <'" & dt1.DefaultView.Item(0).Item("AscFromDate") & "') AND (tbRCL_Shifts.ShiftType =" & dt1.DefaultView.Item(0).Item("AscShiftType") & ")" & _
            " ORDER BY tbRCL_ShiftAscribe_Machin.AscFromDate DESC"

            dt1 = ps1.GetDataTable(strConnection, sqlstr1)

            If dt1.DefaultView.Count > 0 Then
                sqlstr1 = "Update tbRCL_ShiftAscribe_Machin set AcsStateID=2, AscToDate='" & AscToDateP & "' Where AscToDate='" & AscFromDateP & "'"

            End If
        Else
            sqlstr1 = "Update tbRCL_ShiftAscribe_Machin set  AscToDate='" & AscToDateP & "' Where AscToDate='" & AscFromDateP & "'"

        End If



        ps1.GetDataAccess(sqlstr1, 2, strConnection)

        sqlstr1 = "Delete  tbRCL_ShiftAscribe_Machin WHERE AscribeID=" & AscribeID
        ps1.GetDataAccess(sqlstr1, 2, strConnection)

        'If dt1.DefaultView.Item(0).Item("AscToDate") < MyDate Then
        ChkAscFDateIsSmallerEDate_Machin = True
        'Else
        '    ChkAscFDateIsSmallerEDate_Machin = False
        'End If
        'MyDate = dt1.DefaultView.Item(0).Item("AscFromDate")
    End Function

    Friend Function ChkMDFDateIsSmallerEDate_Machin(ByVal MDepartID As String, ByRef MyDate As String) As Boolean
        Dim sqlstr1 As String
        Dim dt1 As DataTable

        sqlstr1 = "SELECT MDShiftID,MDShiftMDepartID,MDShiftNumber,MDShiftStatusID,MDShiftFromDate,MDShiftEndDate " & _
            "FROM tbRCL_ShiftMDepart_Machin WHERE MDShiftMDepartID='" & MDepartID & "' AND MDShiftStatusID=2"
        dt1 = ps1.GetDataTable(strConnection, sqlstr1)
        If dt1.DefaultView.Count > 0 Then
            If dt1.DefaultView.Item(0).Item("MDShiftFromDate") <= MyDate Then
                ChkMDFDateIsSmallerEDate_Machin = True
            Else
                ChkMDFDateIsSmallerEDate_Machin = False
            End If
            MyDate = dt1.DefaultView.Item(0).Item("MDShiftFromDate")
        Else
            ChkMDFDateIsSmallerEDate_Machin = True
        End If
    End Function

    Friend Function ChkUserHavePermission(ByVal MDID As String) As Boolean
        ChkUserHavePermission = False

        If (Mid(MDepID, 1, 2) = "TT" _
            And (Mid(MDID, 1, 2) = "TT" Or Mid(MDID, 1, 3) = "TO6" Or Mid(MDID, 1, 3) = "QC2")) Then

            ChkUserHavePermission = True
        End If

        If (Mid(MDepID, 1, 2) = "PC" _
            And (Mid(MDID, 1, 2) <> "TT" And Mid(MDID, 1, 3) <> "TO6" And Mid(MDID, 1, 3) <> "QC2")) Then

            ChkUserHavePermission = True

        End If

        If Mid(MDepID, 1, 2) = "SI" Then
            ChkUserHavePermission = True
        End If
    End Function

End Class
