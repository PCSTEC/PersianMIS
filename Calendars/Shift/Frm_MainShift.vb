Public Class Frm_MainShift

    Dim mFlgIns, mGridHasRow As Boolean
    Dim dt1, dt2, dt3, dt4, dt5, dt6, dt7, dt8, dt9, dt10, dt11, dt12, dt13 As DataTable
    Dim isEdit As Boolean = False

    Private Sub cmbDayState_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDayState.KeyPress
        If (e.KeyChar = Chr(13)) Then

            jmskEndHour.Focus()


        End If
    End Sub

    Private Sub jmskEndHour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmskEndHour.KeyPress
        If (e.KeyChar = Chr(13)) Then

            cmbToDayState.Focus()

            SendKeys.Send("{F4}")

        End If
    End Sub

    Private Sub cmbToDayState_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbToDayState.KeyPress
        If (e.KeyChar = Chr(13)) Then

            jmskBBreakTime1.Focus()


        End If
    End Sub

    Private Sub cmbDayState1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDayState1.KeyPress
        If (e.KeyChar = Chr(13)) Then

            jmskEBreakTime1.Focus()


        End If
    End Sub

    Private Sub jmskBBreakTime1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmskBBreakTime1.KeyPress
        If (e.KeyChar = Chr(13)) Then

            cmbDayState1.Focus()

            SendKeys.Send("{F4}")
        End If
    End Sub

    Private Sub jmskEBreakTime1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmskEBreakTime1.KeyPress
        If (e.KeyChar = Chr(13)) Then

            cmbToDayState1.Focus()

            SendKeys.Send("{F4}")
        End If
    End Sub

    Private Sub cmbToDayState1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbToDayState1.KeyPress
        If (e.KeyChar = Chr(13)) Then

            jmskBBreakTime2.Focus()


        End If
    End Sub

    Private Sub jmskBBreakTime2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmskBBreakTime2.KeyPress
        If (e.KeyChar = Chr(13)) Then

            cmbDayState2.Focus()

            SendKeys.Send("{F4}")
        End If
    End Sub

    Private Sub cmbDayState2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDayState2.KeyPress
        If (e.KeyChar = Chr(13)) Then

            jmskEBreakTime2.Focus()


        End If
    End Sub

    Private Sub jmskEBreakTime2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmskEBreakTime2.KeyPress
        If (e.KeyChar = Chr(13)) Then

            cmbToDayState2.Focus()

            SendKeys.Send("{F4}")
        End If
    End Sub

    Private Sub cmbToDayState2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbToDayState2.KeyPress
        If (e.KeyChar = Chr(13)) Then

            jmskBBreakTime3.Focus()


        End If
    End Sub

    Private Sub jmskBBreakTime3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmskBBreakTime3.KeyPress
        If (e.KeyChar = Chr(13)) Then

            cmbDayState3.Focus()

            SendKeys.Send("{F4}")
        End If
    End Sub

    Private Sub cmbDayState3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDayState3.KeyPress
        If (e.KeyChar = Chr(13)) Then

            jmskEBreakTime3.Focus()


        End If
    End Sub

    Private Sub jmskEBreakTime3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmskEBreakTime3.KeyPress
        If (e.KeyChar = Chr(13)) Then

            cmbToDayState3.Focus()

            SendKeys.Send("{F4}")
        End If
    End Sub

    Private Sub cmbToDayState3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbToDayState3.KeyPress
        If (e.KeyChar = Chr(13)) Then

            jmskBBreakTime4.Focus()


        End If
    End Sub

    Private Sub jmskBBreakTime4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmskBBreakTime4.KeyPress
        If (e.KeyChar = Chr(13)) Then

            cmbDayState4.Focus()

            SendKeys.Send("{F4}")
        End If
    End Sub

    Private Sub cmbDayState4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDayState4.KeyPress
        If (e.KeyChar = Chr(13)) Then

            jmskEBreakTime4.Focus()

        End If
    End Sub

    Private Sub jmskEBreakTime4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmskEBreakTime4.KeyPress
        If (e.KeyChar = Chr(13)) Then

            cmbToDayState4.Focus()

            SendKeys.Send("{F4}")
        End If
    End Sub

    Private Sub cmbToDayState4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbToDayState4.KeyPress
        If (e.KeyChar = Chr(13)) Then

            jmskBBreakTime5.Focus()

        End If
    End Sub

    Private Sub jmskBBreakTime5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmskBBreakTime5.KeyPress
        If (e.KeyChar = Chr(13)) Then

            cmbDayState5.Focus()

            SendKeys.Send("{F4}")
        End If
    End Sub

    Private Sub cmbDayState5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDayState5.KeyPress
        If (e.KeyChar = Chr(13)) Then

            jmskEBreakTime5.Focus()


        End If
    End Sub

    Private Sub jmskEBreakTime5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmskEBreakTime5.KeyPress
        If (e.KeyChar = Chr(13)) Then

            cmbToDayState5.Focus()

            SendKeys.Send("{F4}")
        End If
    End Sub

    Private Sub cmbToDayState5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbToDayState5.KeyPress
        If (e.KeyChar = Chr(13)) Then

            Btn_SaveShift_Click(e, e)
        End If
    End Sub

    Private Sub Mnu_Edit_Click(sender As Object, e As EventArgs) Handles Mnu_Edit.Click
        SqlStr = "select * from tbRCL_Shifts where ShiftID='" & Grd_ListOfShifts.CurrentRow.Cells("ShiftID").Value.ToString() & "'"
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        If (Dt.Rows.Count > 0) Then

            jmskBeginHour.Text = Dt.DefaultView.Item(0).Item("ShiftBeginHourTxt")
            jmskEndHour.Text = Dt.DefaultView.Item(0).Item("ShiftEndHourTxt")
            cmbDayState.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftDayStateID")
            cmbToDayState.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftToDayStateID")

            jmskBBreakTime1.Text = Dt.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt1")
            jmskEBreakTime1.Text = Dt.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt1")
            cmbDayState1.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftDayState1ID")
            cmbToDayState1.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftToDayState1ID")

            jmskBBreakTime2.Text = Dt.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt2")
            jmskEBreakTime2.Text = Dt.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt2")
            cmbDayState2.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftDayState2ID")
            cmbToDayState2.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftToDayState2ID")

            jmskBBreakTime3.Text = Dt.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt3")
            jmskEBreakTime3.Text = Dt.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt3")
            cmbDayState3.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftDayState3ID")
            cmbToDayState3.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftToDayState3ID")

            jmskBBreakTime4.Text = Dt.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt4")
            jmskEBreakTime4.Text = Dt.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt4")
            cmbDayState4.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftDayState4ID")
            cmbToDayState4.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftToDayState4ID")

            jmskBBreakTime5.Text = Dt.DefaultView.Item(0).Item("ShiftBeginBreakTimeTxt5")
            jmskEBreakTime5.Text = Dt.DefaultView.Item(0).Item("ShiftEndBreakTimeTxt5")
            cmbDayState5.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftDayState5ID")
            cmbToDayState5.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftToDayState5ID")

            Cmb_Section.SelectedValue = Dt.DefaultView.Item(0).Item("SectionId")

            cmbShiftType.SelectedValue = Dt.DefaultView.Item(0).Item("ShiftType")
            txtShiftTitle.Text = Dt.DefaultView.Item(0).Item("ShiftTitle")

            Txt_SumRestTime.Text = Dt.DefaultView.Item(0).Item("TimeKolEsterahat")
            Txt_SumKarkard.Text = Dt.DefaultView.Item(0).Item("TimeKarkard")


            isEdit = True

            Main_Page.SelectedPage = Tab_NewShift




        End If


    End Sub

    Private Sub حذفرکوردانتخابیToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفرکوردانتخابیToolStripMenuItem.Click
        If (MsgBox("آیا از حذف اطلاعات مطمن هستید ؟ ", MessageBoxButtons.YesNo + MsgBoxStyle.Information, "پيام") = DialogResult.Yes) Then

            SqlStr = "delete from  tbRCL_Shifts    where ShiftID='" & Grd_ListOfShifts.CurrentRow.Cells("ShiftID").Value.ToString() & "'"
            Pers.ExecuteNoneQuery(SqlStr, strConnection)
            MsgBox("اطلاعات با موفقیت حذف گردید", MsgBoxStyle.Information, "پيام")
            FillDgListOfShhifts()

        End If
    End Sub

    Private Sub jmskBeginHour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jmskBeginHour.KeyPress
        If (e.KeyChar = Chr(13)) Then

            cmbDayState.Focus()
            SendKeys.Send("{F4}")

        End If
    End Sub

    Private Sub Btn_AddShift_Click(sender As Object, e As EventArgs) Handles Btn_AddShift.Click
        Dim frm As New Frm_ShiftType
        frm.ShowDialog()
        FillCmb_ShiftType()
    End Sub

    Private Sub Btn_AddSection_Click(sender As Object, e As EventArgs) Handles Btn_AddSection.Click
        Dim frm As New Frm_ShiftSections
        frm.ShowDialog()
        FillCmbSection()
    End Sub

    Private Sub FillCmbSection()
        SqlStr = "select * from tbRCL_ShiftSection"
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        Pers.FillCmb(Dt, Cmb_Section, "SectionId", "SectionCaption")
    End Sub

    Private Sub FillCmb_ShiftType()
        SqlStr = "SELECT      TypeID, TypeName FROM         tbRCL_ShiftType "
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        Pers.FillCmb(Dt, cmbShiftType, "TypeID", "TypeName")

    End Sub


    Private Sub fillcmb()
        SqlStr = "Select DayStateID,DayStateTxt From tbRCL_ShiftDayState"

        dt1 = Pers.GetDataTable(strConnection, SqlStr)
        dt2 = Pers.GetDataTable(strConnection, SqlStr)
        dt3 = Pers.GetDataTable(strConnection, SqlStr)
        dt4 = Pers.GetDataTable(strConnection, SqlStr)
        dt5 = Pers.GetDataTable(strConnection, SqlStr)
        dt6 = Pers.GetDataTable(strConnection, SqlStr)
        dt7 = Pers.GetDataTable(strConnection, SqlStr)
        dt8 = Pers.GetDataTable(strConnection, SqlStr)
        dt9 = Pers.GetDataTable(strConnection, SqlStr)
        dt10 = Pers.GetDataTable(strConnection, SqlStr)
        dt11 = Pers.GetDataTable(strConnection, SqlStr)
        dt12 = Pers.GetDataTable(strConnection, SqlStr)

        Pers.FillCmb(dt1, cmbDayState, "DayStateID", "DayStateTxt")
        Pers.FillCmb(dt2, cmbDayState1, "DayStateID", "DayStateTxt")
        Pers.FillCmb(dt3, cmbDayState2, "DayStateID", "DayStateTxt")
        Pers.FillCmb(dt4, cmbDayState3, "DayStateID", "DayStateTxt")
        Pers.FillCmb(dt5, cmbDayState4, "DayStateID", "DayStateTxt")
        Pers.FillCmb(dt6, cmbDayState5, "DayStateID", "DayStateTxt")
        Pers.FillCmb(dt7, cmbToDayState, "DayStateID", "DayStateTxt")
        Pers.FillCmb(dt8, cmbToDayState1, "DayStateID", "DayStateTxt")
        Pers.FillCmb(dt9, cmbToDayState2, "DayStateID", "DayStateTxt")
        Pers.FillCmb(dt10, cmbToDayState3, "DayStateID", "DayStateTxt")
        Pers.FillCmb(dt11, cmbToDayState4, "DayStateID", "DayStateTxt")
        Pers.FillCmb(dt12, cmbToDayState5, "DayStateID", "DayStateTxt")


    End Sub




    Dim shift1 As New Shift
    Dim dataaccess1 As New Persistent.DataAccess.DataAccess


    Private Sub Frm_MainShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDgListOfShhifts()
        FillCmbSection()
        FillCmb_ShiftType()
        fillcmb()
    End Sub


    Private Sub FillDgListOfShhifts()
        SqlStr = "Select * From vwRCL_ShiftsForGrd "
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        Grd_ListOfShifts.DataSource = Dt


    End Sub

    Private Sub jmskEBreakTime3_Click(sender As Object, e As EventArgs) Handles jmskEBreakTime3.Click

    End Sub
    Private Sub AssignHours()



        shift1.Hours(1, 1) = If(jmskBeginHour.Text.Contains("_"), "", jmskBeginHour.Text)
        shift1.Hours(1, 2) = If(jmskEndHour.Text.Contains("_"), "", jmskEndHour.Text)
        shift1.Hours(1, 3) = cmbDayState.SelectedValue
        shift1.Hours(1, 4) = cmbToDayState.SelectedValue

        shift1.Hours(2, 1) = If(jmskBBreakTime1.Text.Contains("_"), "", jmskBBreakTime1.Text)
        shift1.Hours(2, 2) = If(jmskEBreakTime1.Text.Contains("_"), "", jmskEBreakTime1.Text)
        shift1.Hours(2, 3) = cmbDayState1.SelectedValue
        shift1.Hours(2, 4) = cmbToDayState1.SelectedValue

        shift1.Hours(3, 1) = If(jmskBBreakTime2.Text.Contains("_"), "", jmskBBreakTime2.Text)
        shift1.Hours(3, 2) = If(jmskEBreakTime2.Text.Contains("_"), "", jmskEBreakTime2.Text)
        shift1.Hours(3, 3) = cmbDayState2.SelectedValue
        shift1.Hours(3, 4) = cmbToDayState2.SelectedValue

        shift1.Hours(4, 1) = If(jmskBBreakTime3.Text.Contains("_"), "", jmskBBreakTime3.Text)
        shift1.Hours(4, 2) = If(jmskEBreakTime3.Text.Contains("_"), "", jmskEBreakTime3.Text)
        shift1.Hours(4, 3) = cmbDayState3.SelectedValue
        shift1.Hours(4, 4) = cmbToDayState3.SelectedValue

        shift1.Hours(5, 1) = If(jmskBBreakTime4.Text.Contains("_"), "", jmskBBreakTime4.Text)
        shift1.Hours(5, 2) = If(jmskEBreakTime4.Text.Contains("_"), "", jmskEBreakTime4.Text)
        shift1.Hours(5, 3) = cmbDayState4.SelectedValue
        shift1.Hours(5, 4) = cmbToDayState4.SelectedValue

        shift1.Hours(6, 1) = If(jmskBBreakTime5.Text.Contains("_"), "", jmskBBreakTime5.Text)
        shift1.Hours(6, 2) = If(jmskEBreakTime5.Text.Contains("_"), "", jmskEBreakTime5.Text)
        shift1.Hours(6, 3) = cmbDayState5.SelectedValue
        shift1.Hours(6, 4) = cmbToDayState5.SelectedValue


    End Sub


    Private Sub Btn_SaveShift_Click(sender As Object, e As EventArgs) Handles Btn_SaveShift.Click
        Dim sh1 As New Shift
        Call AssignHours()
        '  If mFlgIns Then
        If Not isEdit Then
            If shift1.NewShift(Me.cmbShiftType.SelectedValue, txtShiftTitle.Text, Cmb_Section.SelectedValue, Integer.Parse(Txt_SumRestTime.Text), Integer.Parse(Txt_SumKarkard.Text), Val(Integer.Parse(Txt_SumRestTime.Text)) + Val(Integer.Parse(Txt_SumKarkard.Text))) Then
                MsgBox("شیفت جدید با موفقیت در نرم افزار اضافه گردید", MsgBoxStyle.Information, "نرم افزار تقویم")
                isEdit = False



            End If
        Else
            If (MsgBox("آیا از ویرایش اطلاعات مطمن هستید ؟ ", MessageBoxButtons.YesNo + MsgBoxStyle.Information, "پيام") = DialogResult.Yes) Then
                Dim shid As Int16
                shid = Grd_ListOfShifts.CurrentRow.Cells("ShiftID").Value.ToString()
                If shift1.EditShift(shid, Me.cmbShiftType.SelectedValue, txtShiftTitle.Text, Cmb_Section.SelectedValue, Integer.Parse(Txt_SumRestTime.Text), Integer.Parse(Txt_SumKarkard.Text), Val(Integer.Parse(Txt_SumRestTime.Text)) + Val(Integer.Parse(Txt_SumKarkard.Text))) Then
                    MsgBox("شيفت مورد نظر ويرايش شد", MsgBoxStyle.Information, "پيام")
                    isEdit = False
                End If
            End If




        End If
            FillDgListOfShhifts()
        Main_Page.SelectedPage = Tab_ListOfShifts

        'ElseIf Not mFlgIns Then
        '    Dim shid As Int16
        '    shid = frm1.dgdShifts.Item(frm1.dgdShifts.CurrentCell.RowNumber, 0)
        '    If shift1.EditShift(shid, Me.cmbShiftType.SelectedValue, txtShiftTitle.Text) Then
        '        MsgBox("شيفت مورد نظر ويرايش شد", MsgBoxStyle.Information, "پيام")
        '    End If
        'End If
        'Me.Close()
    End Sub
End Class
