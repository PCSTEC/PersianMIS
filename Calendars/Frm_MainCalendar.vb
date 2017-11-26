Public Class Frm_MainCalendar
    Private Sub Btn_DeclareCalendares_Click(sender As Object, e As EventArgs) Handles Btn_DeclareCalendares.Click
        Dim frm As New Frm_DefineCalendar
        frm.ShowDialog()

    End Sub

    Private Sub Btn_DeclareShifts_Click(sender As Object, e As EventArgs) Handles Btn_DeclareShifts.Click
        Dim Frm As New Frm_MainShift
        Frm.ShowDialog()

    End Sub

    Private Sub Btn_SeftShiftsForSection_Click(sender As Object, e As EventArgs) Handles Btn_SeftShiftsForSection.Click
        Dim frm As New Frm_SetShiftToProductLine
        frm.ShowDialog()

    End Sub
End Class
