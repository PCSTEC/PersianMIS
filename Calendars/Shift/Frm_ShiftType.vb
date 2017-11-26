Public Class Frm_ShiftType
    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        If (MsgBox("آیا از ویرایش اطلاعات مطمن هستید ؟ ", MessageBoxButtons.YesNo + MsgBoxStyle.Information, "پيام") = DialogResult.Yes) Then
            SqlStr = "update   tbRCL_ShiftType set TypeName='" & Txt_ShiftCaption.Text & "' where TypeID='" & Grd_Main.CurrentRow.Cells("TypeID").Value.ToString() & "'"
            Pers.ExecuteNoneQuery(SqlStr, strConnection)
            MsgBox("اطلاعات با موفقیت بروز رسانی گردید", MsgBoxStyle.Information, "پيام")

            FillDg()
        End If
    End Sub


    Private Sub FillDg()
        SqlStr = "select * from tbRCL_ShiftType "
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        Grd_Main.DataSource = Dt

    End Sub

    Private Sub Btn_Insert_Click(sender As Object, e As EventArgs) Handles Btn_Insert.Click
        SqlStr = "insert into  tbRCL_ShiftType(TypeName)  values ('" & Txt_ShiftCaption.Text & "')"
        Pers.ExecuteNoneQuery(SqlStr, strConnection)
        MsgBox("اطلاعات با موفقیت درج گردید ", MsgBoxStyle.Information, "پيام")
        FillDg()


    End Sub
    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        If (MsgBox("آیا از حذف اطلاعات مطمن هستید ؟ ", MessageBoxButtons.YesNo + MsgBoxStyle.Information, "پيام") = DialogResult.Yes) Then

            SqlStr = "delete from  tbRCL_ShiftType    where TypeID='" & Grd_Main.CurrentRow.Cells("TypeID").Value.ToString() & "'"
            Pers.ExecuteNoneQuery(SqlStr, strConnection)
            MsgBox("اطلاعات با موفقیت حذف گردید", MsgBoxStyle.Information, "پيام")
            FillDg()

        End If
    End Sub
    Private Sub Frm_ShiftType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDg()
    End Sub

    Private Sub Grd_Main_Click(sender As Object, e As EventArgs) Handles Grd_Main.Click
        Txt_ShiftCaption.Text = Grd_Main.CurrentRow.Cells("TypeName").Value.ToString()
    End Sub
End Class
