Public Class Frm_CreateCalendar
    Public Calendar1 As New Calendar.Calendar

    Private Sub Btn_CreateCalendare_Click(sender As Object, e As EventArgs) Handles Btn_CreateCalendare.Click
        Cursor.Current = Cursors.WaitCursor


        If String.IsNullOrEmpty(Txt_Year.Text) Or (Txt_Year.Text.Length < 4) Then
            MsgBox("لطفا سال مورد نظر را مشخص نماييد", MsgBoxStyle.Critical, "خطا")
            Exit Sub
        End If
        SqlStr = "select * from tbRCL_CalendarYearIrani where IraniYearID='" & Txt_Year.Text & "'"
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        If (Dt.Rows.Count > 0) Then
            MsgBox("این سال قبلا ساخته شده است", MsgBoxStyle.Critical, "خطا")
            Exit Sub
        End If


        If Calendar1.CreateIraniYear(Txt_Year.Text) Then
            If Calendar1.CreateCalendar(Txt_Year.Text) Then
                Call AssignDayStatus()
                Call Calendar1.SetCalDayStatus_Machin(CInt(Txt_Year.Text))
                MsgBox("تقويم با موفقيت ساخته شد", MsgBoxStyle.Information, "پيام")

            End If
        End If
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub FillCombo()
        SqlStr = "Select DayStatusID,DayStatusName From tbRCL_CalendarDayStatus"
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        Pers.FillCmb(Dt, Cmb_Calendare1, "DayStatusID", "DayStatusName")

        SqlStr = "Select DayStatusID,DayStatusName From tbRCL_CalendarDayStatus"
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        Pers.FillCmb(Dt, Cmb_Calendare2, "DayStatusID", "DayStatusName")

        SqlStr = "Select DayStatusID,DayStatusName From tbRCL_CalendarDayStatus"
        Dt = Pers.GetDataTable(strConnection, SqlStr)

        Pers.FillCmb(Dt, Cmb_Calendare3, "DayStatusID", "DayStatusName")

        SqlStr = "Select DayStatusID,DayStatusName From tbRCL_CalendarDayStatus"
        Dt = Pers.GetDataTable(strConnection, SqlStr)

        Pers.FillCmb(Dt, Cmb_Calendare4, "DayStatusID", "DayStatusName")
        SqlStr = "Select DayStatusID,DayStatusName From tbRCL_CalendarDayStatus"
        Dt = Pers.GetDataTable(strConnection, SqlStr)

        Pers.FillCmb(Dt, Cmb_Calendare5, "DayStatusID", "DayStatusName")
        SqlStr = "Select DayStatusID,DayStatusName From tbRCL_CalendarDayStatus"
        Dt = Pers.GetDataTable(strConnection, SqlStr)

        Pers.FillCmb(Dt, Cmb_Calendare6, "DayStatusID", "DayStatusName")
        SqlStr = "Select DayStatusID,DayStatusName From tbRCL_CalendarDayStatus"
        Dt = Pers.GetDataTable(strConnection, SqlStr)

        Pers.FillCmb(Dt, Cmb_Calendare7, "DayStatusID", "DayStatusName")

    End Sub


    Friend Sub AssignDayStatus()

        Calendar1.DayStArray(1, 1) = 1
        Calendar1.DayStArray(1, 2) = Cmb_Calendare1.SelectedValue
        Calendar1.DayStArray(2, 1) = 2
        Calendar1.DayStArray(2, 2) = Cmb_Calendare2.SelectedValue
        Calendar1.DayStArray(3, 1) = 3
        Calendar1.DayStArray(3, 2) = Cmb_Calendare3.SelectedValue
        Calendar1.DayStArray(4, 1) = 4
        Calendar1.DayStArray(4, 2) = Cmb_Calendare4.SelectedValue
        Calendar1.DayStArray(5, 1) = 5
        Calendar1.DayStArray(5, 2) = Cmb_Calendare5.SelectedValue
        Calendar1.DayStArray(6, 1) = 6
        Calendar1.DayStArray(6, 2) = Cmb_Calendare6.SelectedValue
        Calendar1.DayStArray(7, 1) = 7
        Calendar1.DayStArray(7, 2) = Cmb_Calendare7.SelectedValue
    End Sub

    Private Sub Frm_CreateCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
    End Sub
End Class
