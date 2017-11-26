Public Class Frm_DefineCalendar
    Private Sub Btn_GenerateCalendar_Click(sender As Object, e As EventArgs) Handles Btn_GenerateCalendar.Click
        Dim frm As New Frm_CreateCalendar
        frm.ShowDialog()

    End Sub

    Private Sub Btn_ShowCalendar_Click(sender As Object, e As EventArgs) Handles Btn_ShowCalendar.Click
        Dim frm As New Frm_ShowCalander
        frm.ShowDialog()

    End Sub

    Private Sub Btn_DeleteCalendar_Click(sender As Object, e As EventArgs) Handles Btn_DeleteCalendar.Click
        Dim frm As New Frm_SelectYearForDelete
        frm.ShowDialog()

    End Sub
End Class
