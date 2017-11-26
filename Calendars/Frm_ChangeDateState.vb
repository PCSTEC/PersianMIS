Public Class Frm_ChangeDateState
    Private Sub Frm_ChangeDateState_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlStr = "Select DayStatusID,DayStatusName From tbRCL_CalendarDayStatus"
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        Pers.FillCmb(Dt, Cmb_Calendare, "DayStatusID", "DayStatusName")

    End Sub

    Public Property SetLblDate() As Label
        Get
            Return Lbl_Date


        End Get
        Set(value As Label)
            Lbl_Date = value


        End Set
    End Property

    Private Sub Btn_CreateCalendare_Click(sender As Object, e As EventArgs) Handles Btn_CreateCalendare.Click
        If (MsgBox("آیا می خواهید وضعیت روز مورد نظر تغییر کند؟", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "نرم افزار تقویم") = MsgBoxResult.Yes) Then


            SqlStr = "update tbRCL_Calendar_Machin set CalDayStatusID='" & Cmb_Calendare.SelectedValue & "',Description='" & Txt_Description.Text & "' where CalIraniDate='" & Lbl_Date.Text & "'"
            Pers.ExecuteNoneQuery(SqlStr, strConnection)
            MsgBox("اطلاعات با موفقیت بروز رسانی گردید", MsgBoxStyle.Information, "نرم افزار تقویم")

        End If

    End Sub
End Class
