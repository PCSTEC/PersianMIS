Public Class frmHoghoghCalculate
    Dim sqlstr As String
    Dim dt_Hoghogh As New DataTable
    Dim dt_SoldierFee As New DataTable
    Dim GroupFee As Double
    Private Sub btnHoghoghCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHoghoghCalculate.Click
        sqlstr = "select * from tbHR_GroupFee where PeriodID = 20"
        dt_Hoghogh = Persist1.GetDataTable(ConString, sqlstr)
        For i = 0 To dt_Hoghogh.DefaultView.Count - 1
            Persist1.Sp_AddParam("@GroupID_1", SqlDbType.Int, dt_Hoghogh.DefaultView.Item(i).Item("GroupID"), ParameterDirection.Input)
            'If dt_Hoghogh.DefaultView.Item(i).Item("EngageTypeID") = 1 Then
            GroupFee = dt_Hoghogh.DefaultView.Item(i).Item("GroupFee") * 1.07 + 362790
            'ElseIf dt_Hoghogh.DefaultView.Item(i).Item("EngageTypeID") = 2 Then
            '    GroupFee = dt_Hoghogh.DefaultView.Item(i).Item("GroupFee") * 1.1 + 450000
            'End If
            Persist1.Sp_AddParam("@GroupFee_2", SqlDbType.Float, GroupFee, ParameterDirection.Input)
            Persist1.Sp_AddParam("@PeriodID_3", SqlDbType.Int, 21, ParameterDirection.Input)
            Persist1.Sp_AddParam("@Sanvat_4", SqlDbType.Float, dt_Hoghogh.DefaultView.Item(i).Item("Sanvat"), ParameterDirection.Input)
            Persist1.Sp_AddParam("@EngageTypeID_5", SqlDbType.Int, dt_Hoghogh.DefaultView.Item(i).Item("EngageTypeID"), ParameterDirection.Input)
            Persist1.Sp_Exe("insert_tbHR_GroupFee_ForNextYear", ConString, True)
        Next
    End Sub

    Private Sub btnSoldierFeeCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSoldierFeeCalculate.Click
        sqlstr = "select * from tbHR_SoldierFee where PeriodID = 20"
        dt_SoldierFee = Persist1.GetDataTable(ConString, sqlstr)
        For i = 0 To dt_SoldierFee.DefaultView.Count - 1
            Persist1.Sp_AddParam("@SoldierFee_1", SqlDbType.Float, dt_SoldierFee.DefaultView.Item(i).Item("SoldierFee"), ParameterDirection.Input)
            Persist1.Sp_AddParam("@SoldierID_2", SqlDbType.Int, dt_SoldierFee.DefaultView.Item(i).Item("SoldierID"), ParameterDirection.Input)
            Persist1.Sp_AddParam("@GroupID_3", SqlDbType.Int, dt_SoldierFee.DefaultView.Item(i).Item("GroupID"), ParameterDirection.Input)
            Persist1.Sp_AddParam("@PeriodID_4", SqlDbType.Int, 21, ParameterDirection.Input)
            Persist1.Sp_Exe("insert_tbHR_SoldierFee", ConString, True)
        Next
    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Dim b As New Cls_ReportFacade
        b.LoadReport("rptDossier")
    End Sub
End Class