Imports BLL

Public Class Frm_SetShiftToProductLine
    Dim Bll_product As New Cls_ProductLines()
    Dim mas1 As New ManageAscribe
    Dim selectedItems As String = "'0'"
    Private Sub Frm_SetShiftToProductLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCmb()
        FillDg()

    End Sub

    Private Sub fillCmb()
        Cmb_ProductLine.DataSource = Bll_product.GetProductLines
        Cmb_ProductLine.DisplayMember = "ProductLineDesc"
        Cmb_ProductLine.ValueMember = "ID"
    End Sub

    Private Sub FillDg()

        SqlStr = "Select * From vwRCL_ShiftsForGrd where active=1"
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        Grd_ListOfShifts.DataSource = Dt



    End Sub

    Private Sub Grd_ListOfShifts_Click(sender As Object, e As EventArgs) Handles Grd_ListOfShifts.Click

    End Sub

    Private Sub Btn_AssignShift_Click(sender As Object, e As EventArgs) Handles Btn_AssignShift.Click

        Dim i As Integer = 0
        Dim j As Integer = 0

        For i = 0 To Cmb_ProductLine.CheckedItems.Count - 1

            For j = 0 To Grd_ListOfShifts.Rows.Count - 1

                If (Grd_ListOfShifts.Rows(j).Cells(0).Value = "1") Then


                    SqlStr =
                    " INSERT INTO  tbRCL_ShiftAscribe_Machin  " &
                    "          ([AscShiftID], [AscMDepartID] ,[AscNetWorkTime],[AscNetBreakTime],[AscAllTime],[AcsStateID],[AscFromDate],[AscToDate],[AscShiftType]) " &
                    "     VALUES (" & Grd_ListOfShifts.Rows(j).Cells("ShiftID").Value & " ,'" & Cmb_ProductLine.CheckedItems(i).Value & "'," & Grd_ListOfShifts.Rows(j).Cells("TimeKolEsterahat").Value & "," & Grd_ListOfShifts.Rows(j).Cells("TimeKarkard").Value & "," & Grd_ListOfShifts.Rows(j).Cells("TimeKolKarkard").Value & ",2,'" & Txt_Date.Text & "',0,3)"
                    Pers.ExecuteNoneQuery(SqlStr, strConnection)


                End If


            Next j
        Next i
        MsgBox("شیفت با موفقیت انتصاب یافت ")
        FillDgAssignShifts()




    End Sub



    Private Sub Cmb_ProductLine_ItemCheckedChanged(sender As Object, e As Telerik.WinControls.UI.RadCheckedListDataItemEventArgs) Handles Cmb_ProductLine.ItemCheckedChanged
        Dim i As Integer = 0
        selectedItems = "'0'"


        For i = 0 To Cmb_ProductLine.SelectedItems.Count - 1

            selectedItems = selectedItems & ",'" & Cmb_ProductLine.SelectedItems(i).Value.ToString & "'"
        Next i

        FillDgAssignShifts()



    End Sub

    Private Sub FillDgAssignShifts()


        SqlStr = "SELECT AscribeID,AscShiftID,ShiftType,ShiftTitle,AscMDepartID,AcsStateID,StateName,AscFromDate,AscToDate FROM vwRCL_ShiftAscribeForGrd_Machin " &
                 "WHERE AscMDepartID IN(" & selectedItems & ")"


        Dt = Pers.GetDataTable(strConnection, SqlStr)
        Grd_AsignShifts.DataSource = Dt

    End Sub



    Private Sub Btn_RemoveAssignShifts_Click(sender As Object, e As EventArgs) Handles Btn_RemoveAssignShifts.Click

        If (MsgBox("آیا از حذف اطلاعات مطمن هستید ؟ ", MessageBoxButtons.YesNo + MsgBoxStyle.Information, "پيام") = DialogResult.Yes) Then

            mas1.ChkAscFDateIsSmallerEDate_Machin(Grd_AsignShifts.CurrentRow.Cells("AscribeID").Value, Txt_Date.Text)
            MsgBox("شیفت انتصاب یافته با موفقیت حذه گردید")
            FillDgAssignShifts()
        End If


    End Sub
End Class
