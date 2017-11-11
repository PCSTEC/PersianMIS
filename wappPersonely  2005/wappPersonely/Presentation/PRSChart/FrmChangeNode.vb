Public Class FrmChangeNode
    Dim Bus_MDepart1 As New Bus_MDepart
    Dim dt_DepartType As New DataTable
    Dim dt_DepartType1 As New DataTable
    Dim _ID As Integer
    Dim _DepType As Integer
    Dim _UpperID As String
    Dim sqlstr1 As String
    Dim dt_Child As New DataTable
    Dim i As Integer
    Dim flg As Boolean
    Dim Dac_MDepart1 As New Dac_MDepart

    Friend Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property
    Friend Property DepType() As Integer
        Get
            Return _DepType
        End Get
        Set(ByVal value As Integer)
            _DepType = value
        End Set
    End Property
    Friend Property UpperID() As String
        Get
            Return _UpperID
        End Get
        Set(ByVal value As String)
            _UpperID = value
        End Set
    End Property

    Private Sub Fillcombo()
        dt_DepartType = Bus_MDepart1.GetDepartTypeInfo
        dt_DepartType1 = Bus_MDepart1.GetUpperIDInfo
        Persist1.FillCmb(dt_DepartType, cmbType, "DepartTypeID", "DepartTypetxt")
        cmbType.SelectedValue = DepType
        Persist1.FillCmb(dt_DepartType1, cmbUpper, "DepartID", "DepartCode")
        cmbUpper.Text = UpperID
    End Sub

    Private Sub FrmChangeNode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub FrmChangeNode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblID.Text = ID
        Fillcombo()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dt_temp As New DataTable
        Dim dt1 As New DataTable
        Dim frmChart As New frmPRSMainChart
        If txtName.Text = "" Or txtCode.Text = "" Or cmbType.Text = "" Or cmbUpper.Text = "" Then
            MsgBox(" ·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ  ", MsgBoxStyle.OkOnly, " Œÿ« ")
            Exit Sub
        End If
        Bus_MDepart1.UpdateChangeNode(LblID.Text, txtName.Text, cmbType.SelectedValue)
        If LblUpper.Text <> cmbUpper.Text Then
            Dac_MDepart1.UpdateUpperID(LblID.Text, cmbUpper.Text)
            dt_Child = Dac_MDepart1.GetChildDep(LblDepID.Text)
        End If
        If chkIndependent.Checked = True Then
            Bus_MDepart1.UpdateIndependent(ID, 1)
        Else
            Bus_MDepart1.UpdateIndependent(ID, 0)
        End If
        Me.Close()
        frmChart.TrvOrganChart.Nodes.Clear()
        frmChart.FillMyTreeView()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class