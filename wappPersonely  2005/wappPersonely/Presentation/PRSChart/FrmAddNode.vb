Public Class FrmAddNode
    Dim Bus_MDepart1 As New Bus_MDepart
    Dim dt_DepartType, dt_MDepart As New DataTable
    Dim DepID As String
    Dim DepName As String
    Dim DepType As Integer
    Dim _UpperCode As String
    Dim createdate As String
    Dim dt_Grid1 As New DataTable
    Dim dt_SafSetadinfo As New DataTable
    Dim dt_MDepartKind As New DataTable
    Dim _DepID As Integer
    Friend frmPRSMainChart1 As frmPRSMainChart
    Friend Property UpperCode() As String
        Get
            Return _UpperCode
        End Get
        Set(ByVal value As String)
            _UpperCode = value
        End Set
    End Property
    Friend Property DepartID() As Integer
        Get
            Return _DepID
        End Get
        Set(ByVal value As Integer)
            _DepID = value
        End Set
    End Property

    Private Sub Fillcombo()
        Dim sqlstr As String
        Dim dt As New DataTable
        dt_MDepartKind = Bus_MDepart1.GetDepartKindInfo()
        Persist1.FillCmb(dt_MDepartKind, cmbKind, "DepartKindID", "DepartKindText")
        dt_SafSetadinfo = Bus_MDepart1.GetSafSetadInfo
        Persist1.FillCmb(dt_SafSetadinfo, cmbSafSetad, "SafSetadID", "SafSetadTxt")
        dt_DepartType = Bus_MDepart1.GetDepartTypeInfo
        Persist1.FillCmb(dt_DepartType, cmbType, "DepartTypeID", "DepartTypetxt")
        dt_MDepart = Bus_MDepart1.GetMDepartInfo
        Persist1.FillCmb(dt_MDepart, cmbMDepart, "DepartCode", "DepartName")
        If UpperCode = "A1000" Then
            cmbMDepart.SelectedValue = "A1000"
        ElseIf UpperCode = "A1100" Then
            cmbMDepart.SelectedValue = "A1100"
        ElseIf UpperCode = "CM110" Then
            cmbMDepart.SelectedValue = "A1000"
        Else
            sqlstr = "select DepartCode from VwHR_MDepart where (SUBSTRING(DepartCode, 1, 2) = '" & Mid(UpperCode, 1, 2) & "')"
            dt = Persist1.GetDataTable(ConString, sqlstr)
            'If dt.Rows.Count = 1 Then
            cmbMDepart.SelectedValue = dt.DefaultView.Item(0).Item("DepartCode")
            'Else
            '    dt.Rows.Clear()
            '    sqlstr = "select DepartCode from VwHR_MDepart where (SUBSTRING(DepartCode, 1, 3) = '" & Mid(UpperCode, 1, 3) & "')"
            '    dt = Persist1.GetDataTable(ConString, sqlstr)
            '    cmbMDepart.SelectedValue = dt.DefaultView.Item(0).Item("DepartCode")
            'End If
        End If
    End Sub
    Private Sub FrmAddNode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub FrmAddNode_Load(ByVal senTabder As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUpperID.Text = UpperCode
        Fillcombo()
        FilllblCode()
    End Sub
    Private Sub BAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim MDepCode As String
        If cmbType.Text = "" Or cmbType.Text = "-" Or txtName.Text = "" Or cmbMDepart.Text = "" Then
            MsgBox("·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.OkOnly, " Œÿ« ")
            Exit Sub
        ElseIf UpperCode = "A1000" Then
            If cmbMDepart.SelectedValue <> "A1000" Then
                MsgBox("·ÿ›« ‰«„ „œÌ—Ì  —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        ElseIf UpperCode = "A1100" Then
            If cmbMDepart.SelectedValue <> "A1100" Then
                MsgBox("·ÿ›« ‰«„ „œÌ—Ì  —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        ElseIf Mid(cmbMDepart.SelectedValue, 1, 2) <> Mid(UpperCode, 1, 2) Then
            'Or Mid(cmbMDepart.SelectedValue, 1, 3) <> Mid(UpperCode, 1, 3)
            MsgBox("·ÿ›« ‰«„ „œÌ—Ì  —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If chkIndependent.Checked = True Then
            MDepCode = lblCodes.Text.Trim
            If MsgBox("¬Ì« «“ À»  «Ì‰ ‘«ŒÂ „ÿ„∆‰ Â” Ìœ ø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Bus_MDepart1.InsertNode(lblCodes.Text, txtName.Text, lblUpperID.Text, cmbType.SelectedValue, True, 1, MDepCode, cmbSafSetad.SelectedValue, cmbKind.SelectedValue)
                MsgBox("—ﬂÊ—œ À»  ê—œÌœ", MsgBoxStyle.Information, "")
            Else
                Exit Sub
            End If
        ElseIf chkIndependent.Checked = False Then
            MDepCode = cmbMDepart.SelectedValue
            If MsgBox("¬Ì« «“ À»  «Ì‰ ‘«ŒÂ „ÿ„∆‰ Â” Ìœ ø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Bus_MDepart1.InsertNode(lblCodes.Text, txtName.Text, lblUpperID.Text, cmbType.SelectedValue, True, 0, MDepCode, 3, cmbKind.SelectedValue)
                MsgBox("—ﬂÊ—œ À»  ê—œÌœ", MsgBoxStyle.Information, "")
            Else
                Exit Sub
            End If
        End If
        Close()
        frmPRSMainChart1.TrvOrganChart.Nodes.Clear()
        frmPRSMainChart1.FillMyTreeView()
        frmPRSMainChart1.lblDepName.Text = ""
    End Sub
    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click, btnCancel.Click
        Close()
    End Sub
    
    Friend sub FilllblCode() 
        Dim i As Integer
        Dim DepConName, DepCode As String
        i = Utility1.GetLastRowNumber("Personely", "tbHR_Depart", "DepartID", "1=1")
        DepConName = Mid(UpperCode, 1, 2)
        If Len(Trim(i)) = 1 Then
            DepCode = DepConName.Trim + "000" + Str(i).Trim
            lblCodes.Text = DepCode
        ElseIf Len(Trim(i)) = 2 Then
            DepCode = DepConName.Trim + "00" + Str(i).Trim
            lblCodes.Text = DepCode
        ElseIf Len(Trim(i)) = 3 Then
            DepCode = DepConName.Trim + "0" + Str(i).Trim
            lblCodes.Text = DepCode
        ElseIf Len(Trim(i)) = 4 Then
            DepCode = DepConName.Trim + Str(i).Trim
            lblCodes.Text = DepCode
        End If
    End Sub

    Private Sub chkIndependent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIndependent.CheckedChanged
        If chkIndependent.Checked = True Then
            lblSafSetad.Visible = True
            cmbSafSetad.Visible = True
        Else
            lblSafSetad.Visible = False
            cmbSafSetad.Visible = False
        End If
    End Sub
End Class
