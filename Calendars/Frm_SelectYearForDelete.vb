Public Class Frm_SelectYearForDelete
    Private Sub Frm_SelectYearForDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCmb()
    End Sub
    Private Sub FillCmb()
        SqlStr = "Select * From tbRCL_CalendarYearIrani"
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        Pers.FillCmb(Dt, Cmb_Year, "IraniYearID", "IraniYearID")
    End Sub
    Private Sub Btn_DeleteYear_Click(sender As Object, e As EventArgs) Handles Btn_DeleteYear.Click
        If (MsgBox("آیا مطمن هستید از حذف سال انتخابی ؟", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "نرم افزار تقویم") = MsgBoxResult.Yes) Then


            SqlStr = "delete from  tbRCL_CalendarYearIrani where  IraniYearID='" & Cmb_Year.SelectedValue & "'"
            Pers.ExecuteNoneQuery(SqlStr, strConnection)
            MsgBox("اطلاعات با موفقیت حذف گردید", MsgBoxStyle.Information, "نرم افزار تقویم")
            FillCmb()
        End If
    End Sub
End Class
