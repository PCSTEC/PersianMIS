Public Class frmPRSMeed
    Dim _PersonCode As Integer
    Dim dt_MeedInfo As New DataTable
    Dim Bus_Person1 As New Bus_Person
    Dim dt_MeedType As New DataTable
    Enum sabt
        save = 1
        change = 2
    End Enum
    Dim sabt1 As sabt
    Friend Property PersonCode() As Integer
        Get
            Return _PersonCode
        End Get
        Set(ByVal value As Integer)
            _PersonCode = value
        End Set
    End Property

    Private Sub frmPRSMeed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub frmPRSMeed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("شما به اين نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Me.Close()
        Else
            ''''معاون مالي و اداري
            If Activity1.CheckUserAccess(54, 733, LogID) = True Then
                UiGroupBox2.Enabled = False
            End If
        End If
        FillMyGridView()
        FillMyCombo()
        ''''نظر سنجي

        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub
    Friend Sub FillMyCombo()
        dt_MeedType = Bus_Meed1.MeedTypeInfo
        Persist1.FillCmb(dt_MeedType, cmbMeedType, "MeedTypeID", "MeedTypeText")
    End Sub
    Friend Sub FillMyGridView()
        Dim janus1 As New JFrameWork.JanusGrid
        dt_MeedInfo.Rows.Clear()
        dt_MeedInfo = Bus_Meed1.MeedInfo(PersonCode)
        janus1.GetBindJGrid_DT(dt_MeedInfo, grdMeed, ConString)
        janus1.setMyJGrid(grdMeed, "MeedTypeText", "نوع", 85)
        janus1.setMyJGrid(grdMeed, "MeedReason", "شرح", 400)
        janus1.setMyJGrid(grdMeed, "MeedDate", " تاريخ شروع", 100)
        janus1.setMyJGrid(grdMeed, "MeedEndDate", "تاريخ پایان", 100)
        janus1.setMyJGrid(grdMeed, "MeedLetterNo", "شماره نامه", 75)
        janus1.setMyJGrid(grdMeed, "MeedID", "", 0, , , False)
        janus1.setMyJGrid(grdMeed, "PersonID", "", 0, , , False)
        janus1.setMyJGrid(grdMeed, "MeedTypeID", "", 0, , , False)
        janus1.setMyJGrid(grdMeed, "PersonCode", "كد پرسنلي", 0, , , False)
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtLetterNum.Text.Trim = "" Or txtReason.Text.Trim = "" Or Len(txtMeedDate.Text.Trim) <> 10 Then
            MsgBox("لطفا مقادير را درست وارد نماييد", MsgBoxStyle.Information, "")
            Exit Sub
        ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtMeedDate.Text)) = True Then
            Exit Sub
        Else
            If MsgBox("آيا از ثبت اين ركورد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Bus_Meed1.InsertMeedInfo(Val(lblPersonCode.Text.Trim), txtReason.Text.Trim, cmbMeedType.SelectedValue, txtMeedDate.Text.Trim, txtMeedEndDate.Text.Trim, Val(txtLetterNum.Text.Trim), Val(lblPersonID.Text.Trim))
                MsgBox("ركورد ثبت گرديد", MsgBoxStyle.Information, "")
                FillMyGridView()
                txtReason.Text = ""
                txtLetterNum.Text = ""
                txtMeedDate.Text = ""
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        If grdMeed.RowCount = 0 Then
            MsgBox("آيتمي براي ويرايش موجود نمي باشد", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            txtReason.Text = grdMeed.GetValue("MeedReason")
            txtMeedDate.Text = grdMeed.GetValue("MeedDate")
            txtLetterNum.Text = grdMeed.GetValue("MeedLetterNo")
            cmbMeedType.SelectedValue = grdMeed.GetValue("MeedTypeID")
            btnAdd.Visible = False
            btnSaveChange.Visible = True
            btnChange.Enabled = False
        End If
    End Sub

    Private Sub btnSaveChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChange.Click
        If txtLetterNum.Text.Trim <> "" Or txtReason.Text.Trim <> "" Or Len(txtMeedDate.Text.Trim) <> 10 Then
            If MsgBox("آيا از انجام تغييرات مطمئن هستيد ؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Bus_Meed1.UpdateMeedInfo(grdMeed.GetValue("MeedID"), txtReason.Text.Trim, cmbMeedType.SelectedValue, txtMeedDate.Text.Trim, Val(txtLetterNum.Text.Trim))
                MsgBox("تغييرات ثبت گرديد", MsgBoxStyle.Information, "")
                FillMyGridView()
                txtReason.Text = ""
                txtLetterNum.Text = ""
                txtMeedDate.Text = ""
                btnSaveChange.Visible = False
                btnAdd.Visible = True
                btnChange.Enabled = True
            Else
                MsgBox("لطفا مقادير را درست وارد نماييد", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grdMeed.RowCount = 0 Then
            MsgBox("آيتمي براي حذف موجود نمي باشد", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            If MsgBox("آيا ازحذف ركورد مورد نظر مطمئن مي باشيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Bus_Meed1.DeleteMeedInfo(grdMeed.GetValue("MeedID"))
                FillMyGridView()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class