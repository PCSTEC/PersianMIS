Public Class frmAddNewUnit
    Dim Bus_MDepart1 As New Bus_MDepart
    Dim dt_DepartType, dt_Unit, dt_Office, dt_MDepart As New DataTable
    'Dim _DepartID As Integer
    Dim _UpperCode As String
    Dim dt_SafSetadinfo As New DataTable
    Friend frmPRSMainChart1 As frmPRSMainChart
    Dim dt_MDepartKind As New DataTable

    Friend Property UpperCode() As String
        Get
            Return _UpperCode
        End Get
        Set(ByVal value As String)
            _UpperCode = value
        End Set
    End Property

    Private Sub frmAddNewUnit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmAddNodeNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUpperID.Text = UpperCode
        i = Utility1.GetLastRowNumber("Personely", "tbHR_Depart", "DepartID", "1=1")
        FillCombo()
    End Sub
    Friend Sub FillCombo()
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim dt_PersonName As New DataTable
        dt_SafSetadinfo = Bus_MDepart1.GetSafSetadInfo
        Persist1.FillCmb(dt_SafSetadinfo, cmbSafSetad, "SafSetadID", "SafSetadTxt")
        dt_MDepartKind = Bus_MDepart1.GetDepartKindInfo()
        Persist1.FillCmb(dt_MDepartKind, cmbKind, "DepartKindID", "DepartKindText")

        sqlstr = "select DepartCode from VwHR_MDepart where (SUBSTRING(DepartCode, 1, 2) = '" & Mid(UpperCode, 1, 2) & "')"
        dt = Persist1.GetDataTable(ConString, sqlstr)
        dt_MDepart = Bus_MDepart1.GetMDepartInfo
        Persist1.FillCmb(dt_MDepart, cmbMDepart, "DepartCode", "DepartName")
        If dt.Rows.Count = 1 Then
            cmbMDepart.SelectedValue = dt.DefaultView.Item(0).Item("DepartCode")
        Else
            dt.Rows.Clear()
            sqlstr = "select DepartCode from VwHR_MDepart where (SUBSTRING(DepartCode, 1, 3) = '" & Mid(UpperCode, 1, 3) & "')"
            dt = Persist1.GetDataTable(ConString, sqlstr)
            cmbMDepart.SelectedValue = dt.DefaultView.Item(0).Item("DepartCode")
        End If
        dt_DepartType = Bus_MDepart1.GetDepartTypeInfo
        Persist1.FillCmb(dt_DepartType, cmbType, "DepartTypeID", "DepartTypetxt")
        dt_Unit = Bus_MDepart1.GettbHRDepartNameContraction()

        sqlstr = "SELECT  PersonCode, Name FROM VwHR_PersonInDepart ORDER BY LastName"
        dt_PersonName = Persist1.GetDataTable(ConString, sqlstr)
        Persist1.FillCmb(dt_PersonName, cmbManagerName, "PersonCode", "Name")

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim DepartID As Integer
        Dim dt_ContractName As New DataTable
        Dim sqlstr, MDepCode As String
        'Dim MdepartID As Integer
        Dim dt_MdepartID As New DataTable
        If cmbType.Text = "" Or cmbType.Text = "-" Or txtName.Text.Trim = "" Or Len(lblCode.Text) <> 6 Or Len(txtContractionName.Text) <> 2 Or cmbMDepart.Text = "" Then
            MsgBox("·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        ElseIf Mid(cmbMDepart.SelectedValue, 1, 2) <> Mid(UpperCode, 1, 2) Or Mid(cmbMDepart.SelectedValue, 1, 3) <> Mid(UpperCode, 1, 3) Then
            MsgBox("·ÿ›« ‰«„ „œÌ—Ì  —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        DepartID = Utility1.GetLastRowNumber("Personely", "tbHR_Depart", "DepartID", "1=1")
        sqlstr = "select DepartContractionName from tbHR_DepartNameContraction"
        dt_ContractName = Persist1.GetDataTable(ConString, sqlstr)
        For i = 0 To dt_ContractName.Rows.Count - 1
            lblContractName.Text = ""
            lblContractName.Text = dt_ContractName.DefaultView.Item(i).Item("DepartContractionName")
            If lblContractName.Text.Trim = txtContractionName.Text.Trim Then
                MsgBox("‰«„ „” ⁄«—  ﬂ—«—Ì Ê«—œ ‰„ÊœÂ «Ìœ", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        Next
        If chkIndependent.Checked = True Then
            MDepCode = lblCode.Text.Trim
            If MsgBox("¬Ì« «“ À»  «Ì‰ Ê«Õœ „ÿ„∆‰ Â” Ìœ ø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Bus_MDepart1.inserttbHRDepartNameContraction(DepartID, UpperCode, txtName.Text.Trim, txtContractionName.Text.Trim)
                Bus_MDepart1.InsertNode(lblCode.Text.Trim, txtName.Text.Trim, UpperCode, cmbType.SelectedValue, True, 1, MDepCode, cmbSafSetad.SelectedValue, cmbKind.SelectedValue)
                'sqlstr = "SELECT DepartID  FROM  tbHR_Depart WHERE (DepartCode = '" & lblCode.Text.Trim & "')"
                'dt_MdepartID = Persist1.GetDataTable(ConString, sqlstr)
                'MdepartID = dt_MDepart.DefaultView.Item(0).Item("DepartID")
                Bus_MDepart1.insert_tbHR_PassWordMdepart(lblCode.Text.Trim, 0, cmbManagerName.SelectedValue, DepartID)
                MsgBox("—ﬂÊ—œ À»  ê—œÌœ", MsgBoxStyle.Information, "")
            Else
                Exit Sub
            End If

        ElseIf chkIndependent.Checked = False Then
            MDepCode = cmbMDepart.SelectedValue
            If MsgBox("¬Ì« «“ À»  «Ì‰ ‘«ŒÂ „ÿ„∆‰ Â” Ìœ ø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Bus_MDepart1.inserttbHRDepartNameContraction(DepartID, UpperCode, txtName.Text, txtContractionName.Text)
                Bus_MDepart1.InsertNode(lblCode.Text.Trim, txtName.Text.Trim, UpperCode, cmbType.SelectedValue, True, 0, MDepCode, 3, cmbKind.SelectedValue)
                'sqlstr = "SELECT DepartID  FROM  tbHR_Depart WHERE (DepartCode = '" & lblCode.Text.Trim & "')"
                'dt_MdepartID = Persist1.GetDataTable(ConString, sqlstr)
                'MdepartID = dt_MDepart.DefaultView.Item(0).Item("DepartID")
                Bus_MDepart1.insert_tbHR_PassWordMdepart(lblCode.Text.Trim, 0, cmbManagerName.SelectedValue, DepartID)
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
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click, btnCancel.Click
        Close()
    End Sub
    Private Sub txtContractionName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContractionName.TextChanged
        If (i <= 9) Then
            lblCode.Text = txtContractionName.Text.Trim + "000" + Str(i).Trim
        ElseIf (i >= 10 And i <= 99) Then
            lblCode.Text = txtContractionName.Text.Trim + "00" + Str(i).Trim
        ElseIf (i >= 100 And i <= 999) Then
            lblCode.Text = txtContractionName.Text.Trim + "0" + Str(i).Trim
        ElseIf (i >= 1000 And i <= 9999) Then
            lblCode.Text = txtContractionName.Text.Trim + Str(i).Trim
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