Imports System.Data
Imports System.Drawing
Public Class frmPRSMainChart
    Inherits System.Windows.Forms.Form
    Dim dt_Depart, dt_Delete As New DataTable
    Dim IsFind As Boolean
    Dim FindNode As New TreeNode
    Dim SelectNode As New TreeNode
    Dim Bus_MDepart1 As New Bus_MDepart
    Dim nodex As New TreeNode
    Dim node_Click As String
    Dim PosX, PosY As Integer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Dim dt_temp As New DataTable
    Friend dt_Grid As New DataTable
    Dim m As Integer = 0
    Dim nodez As New TreeNode
    Dim buferColor As String
    Friend Enum showMode
        'Insert = 1
        show = 2
    End Enum
    Friend ShowForm As showMode

    Private Sub frmPRSMainChart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("‘„« »Â «Ì‰ ‰—„ «›“«— œ” —”Ì ‰œ«—Ìœ", MsgBoxStyle.Information, "")
            Me.Close()
            ''''„⁄«Ê‰  „«·Ì Ê«œ«—Ì
        ElseIf Activity1.CheckUserAccess(54, 733, LogID) = True Then
            ContextTrvChart.Enabled = False
            ContextGrdPost.Enabled = False
            MenuStrip1.Visible = False
            ''''„œÌ— ¬„Ê“‘
        ElseIf Activity1.CheckUserAccess(54, 735, LogID) = True Then
            ContextTrvChart.Enabled = False
            ContextGrdPost.Enabled = False
            MenuStrip1.Visible = False
            ''''»Ì„Â
        ElseIf Activity1.CheckUserAccess(54, 950, LogID) = True Then
            ContextTrvChart.Enabled = False
            ContextGrdPost.Enabled = False
            MenuStrip1.Visible = False
            ''''Õ”«»—”
        ElseIf Activity1.CheckUserAccess(54, 920, LogID) = True Then
            ContextTrvChart.Enabled = False
            ContextGrdPost.Enabled = False
            MenuStrip1.Visible = False
        End If
        Call FillMyTreeView()
        FillMyGridView()

        ''''‰Ÿ— ”‰ÃÌ

        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub

    Public Sub FillMyTreeView()
        Dim dt As New DataTable
        dt = Bus_MDepart1.GetDepartTreeviewInfo
        nodex = TrvOrganChart.Nodes.Add((Trim(dt.DefaultView.Item(0).Item("DepartName") + " " + dt.DefaultView.Item(0).Item("DepartTypetxt") + " " + dt.DefaultView.Item(0).Item("DepartCode"))))
        TrvOrganChart.Nodes(0).Tag = "0"
        TrvOrganChart.Nodes(0).ForeColor = Color.Green
        FillChart("0", TrvOrganChart.Nodes(0))
        If ShowForm = showMode.show Then
            ContextTrvChart.Enabled = False
            MenuStrip1.Visible = False
            ContextGrdPost.Enabled = False
        End If
    End Sub

    Private Sub FillChart(ByVal UpperID As String, ByVal Nodey As TreeNode)
        Dim DepName As String
        Dim dt1 As New DataTable
        Dim i As Integer
        SqlStr = "Select * from VwHR_DepartTreeview Where UpperCode='" & Nodey.Tag & "'"
        dt1 = Persist1.GetDataTable(ConString, SqlStr)
        For i = 0 To dt1.DefaultView.Count - 1
            DepName = dt1.DefaultView.Item(i).Item("DepartTypetxt") + " " + dt1.DefaultView.Item(i).Item("DepartName") + " " + dt1.DefaultView.Item(i).Item("DepartCode")
            nodez = Nodey.Nodes.Add(Trim(DepName))
            nodez.Tag = dt1.DefaultView.Item(i).Item("DepartCode")
            If dt1.DefaultView.Item(i).Item("Independent") = 1 Then
                nodez.ForeColor = Color.Blue
            Else
                nodez.ForeColor = Color.Black
            End If
            FillChart(nodez.Tag, nodez)
        Next
    End Sub

    Private Sub frmPRSMainChart_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        TrvOrganChart.Nodes.Clear()
    End Sub

    Private Sub frmPRSMainChart_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr("13") Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

  
    Private Sub contextDelNode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextDelNode.Click
        Dim dt_Upper As New DataTable
        Dim dt_Person As New DataTable
        If TrvOrganChart.SelectedNode.Tag = "0" Then
            'Or TrvOrganChart.SelectedNode.Tag = "A0000" Or TrvOrganChart.SelectedNode.Tag = "A1000"
            MsgBox("‘„« „Ã«“ »Â Õ–› «Ì‰ ‘«ŒÂ ‰„Ì »«‘Ìœ", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            dt_Upper = Bus_MDepart1.GetUpperInfo(TrvOrganChart.SelectedNode.Tag)
            dt_Person = Bus_Post1.GetActivePostEmployeeDepartInfo(TrvOrganChart.SelectedNode.Tag)
            If dt_Upper.Rows.Count = 0 Then
                If GrdPost.RowCount = 0 Then
                    If MsgBox(TrvOrganChart.SelectedNode.Text & " ¬Ì« „Ì ŒÊ«ÂÌœ «Ì‰ ‘«ŒÂ —« Õ–› ‰„«ÌÌœ ø ", MsgBoxStyle.OkCancel, "") = MsgBoxResult.Ok Then
                        Bus_MDepart1.UpdateChildActive(TrvOrganChart.SelectedNode.Tag, False)
                        Bus_MDepart1.UpdateActive(TrvOrganChart.SelectedNode.Tag, False)
                        Me.TrvOrganChart.Nodes.Clear()
                        Me.FillMyTreeView()
                        Me.lblDepName.Text = ""
                    Else
                        Exit Sub
                    End If
                Else        'GrdPost.RowCount <> 0
                    MsgBox("«» œ« »«Ìœ Å” Â«Ì ”«“„«‰Ì Ê «›—«œ ‘«€· œ— «Ì‰ Ê«Õœ —« Õ–› ‰„«ÌÌœ", MsgBoxStyle.Information, "")
                    If dt_Person.Rows.Count <> 0 Then
                        Dim frm As New frmPersonInDepart
                        frm.DepartCode = TrvOrganChart.SelectedNode.Tag
                        frm.Text = "Å—”‰· ‘«€· œ—" + lblDepName.Text.Trim
                        frm.ShowDialog()
                    Else
                        MsgBox("ﬂ«›Ì”  Å” Â« —« Õ–› ‰„«ÌÌœ ° Å—”‰·Ì œ— «Ì‰ Ê«Õœ „‘€Ê· »Â ﬂ«— ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
                        Exit Sub
                    End If
                    Exit Sub
                End If
            Else           'dt_Upper.Rows.Count <> 0
                MsgBox("«» œ« »«Ìœ “Ì— ‘«ŒÂ Â«Ì «Ì‰ ‘«ŒÂ —« Õ–› ‰„«ÌÌœ", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        End If
    End Sub
    Private Sub contextAddNode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextAddNode.Click
        Dim dt_DepTypeID As New DataTable
        Dim sqlstr1 As String
        sqlstr1 = "select * from VwHR_DepartTreeview Where DepartCode='" & TrvOrganChart.SelectedNode.Tag & "'"
        dt_DepTypeID = Persist1.GetDataTable(ConString, sqlstr1)
        If dt_DepTypeID.DefaultView.Item(0).Item("DepartTypeID") = 7 Or TrvOrganChart.SelectedNode.Tag = "0" Or TrvOrganChart.SelectedNode.Tag = "A0000" Or TrvOrganChart.SelectedNode.Tag = "A1000" Then
            Dim frm As New frmAddNewUnit
            Dim dt As New DataTable
            Dim sqlstr As String
            sqlstr = "select * from VwHR_DepartTreeview Where DepartCode='" & TrvOrganChart.SelectedNode.Tag & "'"
            dt = Persist1.GetDataTable(ConString, sqlstr)
            frm.UpperCode = TrvOrganChart.SelectedNode.Tag
            frm.Text = "œ—Ã œ—" + "   " + TrvOrganChart.SelectedNode.Text
            frm.frmPRSMainChart1 = Me
            frm.ShowDialog()
            dt.Rows.Clear()
        Else
            Dim frm As New FrmAddNode
            Dim dt As New DataTable
            Dim sqlstr As String
            sqlstr = "select * from VwHR_DepartTreeview Where DepartCode='" & TrvOrganChart.SelectedNode.Tag & "'"
            dt = Persist1.GetDataTable(ConString, sqlstr)
            frm.UpperCode = TrvOrganChart.SelectedNode.Tag
            frm.DepartID = dt.DefaultView.Item(0).Item("DepartID")
            frm.Text = "œ—Ã œ—" + "   " + TrvOrganChart.SelectedNode.Text
            frm.frmPRSMainChart1 = Me
            frm.ShowDialog()
            dt.Rows.Clear()
        End If
    End Sub
    Friend Sub FillMyGridView()
        Dim Janus1 As New JFrameWork.JanusGrid
        dt_Grid.Rows.Clear()
        dt_Grid = Bus_Post1.GetPostGridViewInfo()
        Janus1.GetBindJGrid_DT(dt_Grid, GrdPost, ConString)
        Janus1.setMyJGrid(GrdPost, "PostID", "", 0, , , False)
        Janus1.setMyJGrid(GrdPost, "PostTypeID", "", 0, , , False)
        Janus1.setMyJGrid(GrdPost, "PostTypeCode", "", 0, , , False)
        Janus1.setMyJGrid(GrdPost, "DepartCode", "", 0, , , False)
        Janus1.setMyJGrid(GrdPost, "PostCode", "ﬂœ Å” ", 80)
        Janus1.setMyJGrid(GrdPost, "Posttxt", "‰«„ Å” ", 305)
        Janus1.setMyJGrid(GrdPost, "PostType", "‰Ê⁄ Å” ", 200)
    End Sub
    Private Sub TrvOrganChart_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TrvOrganChart.AfterSelect
        dt_Grid.DefaultView.RowFilter = " DepartCode = '" & TrvOrganChart.SelectedNode.Tag & " ' "
        lblDepName.Text = TrvOrganChart.SelectedNode.Text
    End Sub
    Private Sub contextDelPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextDelPost.Click
        If GrdPost.RowCount = 0 Then
            MsgBox("¬Ì „Ì »—«Ì Õ–› „ÊÃÊœ ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            Dim dt_Person As New DataTable
            dt_Person = Bus_Post1.GetActivePostDepartInfo(GrdPost.GetValue("PostCode"))
            If dt_Person.Rows.Count = 0 Then
                If MsgBox("¬Ì« «“ Õ–› ‘€· " & "(( " & Me.GrdPost.GetValue("Posttxt") & " ))" & "„ÿ„∆‰ Â” Ìœ ø ", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    Bus_Post1.UpdateActivePost(GrdPost.GetValue("PostCode"), 0)
                    FillMyGridView()
                    dt_Grid.DefaultView.RowFilter = " DepartCode = '" & TrvOrganChart.SelectedNode.Tag & " ' "
                End If
            Else
                MsgBox("‘„« ﬁ«œ— »Â Õ–› «Ì‰ ‘€· ‰„Ì »«‘Ìœ ° ‘Œ’ Ì« «‘Œ«’Ì œ— «Ì‰ Å”  „‘€Ê· »Â ﬂ«— „Ì »«‘‰œ", MsgBoxStyle.Information, "")
                Dim frm As New frmPersonInDepart
                frm.PostCode = GrdPost.GetValue("PostCode")
                frm.Text = "Å—”‰· ‘«€· œ—" + lblDepName.Text.Trim
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub contextAddPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextAddPost.Click
        If TrvOrganChart.SelectedNode.Tag = "0" Then
            MsgBox("„Ã«“ »Â œ—Ã Å”  »—«Ì «Ì‰ ‘«ŒÂ ‰„Ì »«‘Ìœ", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            Dim dt As New DataTable
            Dim frm As New FrmAddPost
            frm.Text = "œ—Ã Å”  œ—" + "  " + lblDepName.Text
            dt = Bus_MDepart1.GettbHR_DepartInfo(TrvOrganChart.SelectedNode.Tag)
            frm.lblPostDepartID.Text = dt.DefaultView.Item(0).Item("DepartID")
            frm.DepartID = dt.DefaultView.Item(0).Item("DepartID")
            frm.DepartCode = dt.DefaultView.Item(0).Item("DepartCode")
            frm.lblPostCodePishnahadi.Text = TrvOrganChart.SelectedNode.Tag.Trim + "0000"
            frm.ShowDialog()
            FillMyGridView()
            dt_Grid.DefaultView.RowFilter = " DepartCode = '" & TrvOrganChart.SelectedNode.Tag & " ' "
        End If
    End Sub
    Private Sub Œ—ÊÃToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Œ—ÊÃToolStripMenuItem1.Click
        Me.Close()
    End Sub
    Private Sub œ—ÃToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles œ—ÃToolStripMenuItem.Click
        Dim dt_DepTypeID As New DataTable
        Dim sqlstr1 As String
        sqlstr1 = "select * from VwHR_DepartTreeview Where DepartCode='" & TrvOrganChart.SelectedNode.Tag & "'"
        dt_DepTypeID = Persist1.GetDataTable(ConString, sqlstr1)
        If dt_DepTypeID.DefaultView.Item(0).Item("DepartTypeID") = 7 Or TrvOrganChart.SelectedNode.Tag = "0" Or TrvOrganChart.SelectedNode.Tag = "A0000" Or TrvOrganChart.SelectedNode.Tag = "A1000" Then
            Dim frm As New frmAddNewUnit
            Dim dt As New DataTable
            Dim sqlstr As String
            sqlstr = "select * from VwHR_DepartTreeview Where DepartCode='" & TrvOrganChart.SelectedNode.Tag & "'"
            dt = Persist1.GetDataTable(ConString, sqlstr)
            frm.UpperCode = TrvOrganChart.SelectedNode.Tag
            frm.Text = "œ—Ã œ—" + "   " + TrvOrganChart.SelectedNode.Text
            frm.frmPRSMainChart1 = Me
            frm.ShowDialog()
            dt.Rows.Clear()
        Else
            Dim frm As New FrmAddNode
            Dim dt As New DataTable
            Dim sqlstr As String
            sqlstr = "select * from VwHR_DepartTreeview Where DepartCode='" & TrvOrganChart.SelectedNode.Tag & "'"
            dt = Persist1.GetDataTable(ConString, sqlstr)
            frm.UpperCode = TrvOrganChart.SelectedNode.Tag
            frm.DepartID = dt.DefaultView.Item(0).Item("DepartID")
            frm.Text = "œ—Ã œ—" + "   " + TrvOrganChart.SelectedNode.Text
            frm.frmPRSMainChart1 = Me
            frm.ShowDialog()
            dt.Rows.Clear()
        End If
    End Sub
    Private Sub Õ–›‘«ŒÂToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Õ–›‘«ŒÂToolStripMenuItem.Click
        Dim dt_Upper As New DataTable
        Dim dt_Person As New DataTable
        If TrvOrganChart.SelectedNode.Tag = "0" Then
            'Or TrvOrganChart.SelectedNode.Tag = "A0000" Or TrvOrganChart.SelectedNode.Tag = "A1000"
            MsgBox("‘„« „Ã«“ »Â Õ–› «Ì‰ ‘«ŒÂ ‰„Ì »«‘Ìœ", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            dt_Upper = Bus_MDepart1.GetUpperInfo(TrvOrganChart.SelectedNode.Tag)
            dt_Person = Bus_Post1.GetActivePostEmployeeDepartInfo(TrvOrganChart.SelectedNode.Tag)
            If dt_Upper.Rows.Count = 0 Then
                If GrdPost.RowCount = 0 Then
                    If MsgBox(TrvOrganChart.SelectedNode.Text & " ¬Ì« „Ì ŒÊ«ÂÌœ «Ì‰ ‘«ŒÂ —« Õ–› ‰„«ÌÌœ ø ", MsgBoxStyle.OkCancel, "") = MsgBoxResult.Ok Then
                        Bus_MDepart1.UpdateChildActive(TrvOrganChart.SelectedNode.Tag, False)
                        Bus_MDepart1.UpdateActive(TrvOrganChart.SelectedNode.Tag, False)
                        Me.TrvOrganChart.Nodes.Clear()
                        Me.FillMyTreeView()
                        Me.lblDepName.Text = ""
                    Else
                        Exit Sub
                    End If
                Else        'GrdPost.RowCount <> 0
                    MsgBox("«» œ« »«Ìœ Å” Â«Ì ”«“„«‰Ì Ê «›—«œ ‘«€· œ— «Ì‰ Ê«Õœ —« Õ–› ‰„«ÌÌœ", MsgBoxStyle.Information, "")
                    If dt_Person.Rows.Count <> 0 Then
                        Dim frm As New frmPersonInDepart
                        frm.DepartCode = TrvOrganChart.SelectedNode.Tag
                        frm.Text = "Å—”‰· ‘«€· œ—" + lblDepName.Text.Trim
                        frm.ShowDialog()
                    Else
                        MsgBox("ﬂ«›Ì”  Å” Â« —« Õ–› ‰„«ÌÌœ ° Å—”‰·Ì œ— «Ì‰ Ê«Õœ „‘€Ê· »Â ﬂ«— ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
                        exit Sub 
                    End If
                    Exit Sub
                    End If
            Else           'dt_Upper.Rows.Count <> 0
                    MsgBox("«» œ« »«Ìœ “Ì— ‘«ŒÂ Â«Ì «Ì‰ ‘«ŒÂ —« Õ–› ‰„«ÌÌœ", MsgBoxStyle.Information, "")
                    Exit Sub
            End If
        End If
    End Sub
    Private Sub œ—ÃÅ” ToolStripMenuItem_Click(ByVal e As System.EventArgs, ByVal sender As System.Object) Handles œ—ÃÅ” ToolStripMenuItem.Click
        If TrvOrganChart.SelectedNode.Tag = "0" Then
            MsgBox("„Ã«“ »Â œ—Ã Å”  »—«Ì «Ì‰ ‘«ŒÂ ‰„Ì »«‘Ìœ", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            Dim dt As New DataTable
            Dim frm As New FrmAddPost
            frm.Text = "œ—Ã Å”  œ—" + "  " + lblDepName.Text
            dt = Bus_MDepart1.GettbHR_DepartInfo(TrvOrganChart.SelectedNode.Tag)
            frm.lblPostDepartID.Text = dt.DefaultView.Item(0).Item("DepartID")
            frm.DepartID = dt.DefaultView.Item(0).Item("DepartID")
            frm.DepartCode = dt.DefaultView.Item(0).Item("DepartCode")
            frm.lblPostCodePishnahadi.Text = TrvOrganChart.SelectedNode.Tag.Trim + "0000"
            frm.ShowDialog()
            FillMyGridView()
            dt_Grid.DefaultView.RowFilter = " DepartCode = '" & TrvOrganChart.SelectedNode.Tag & " ' "
        End If
    End Sub
    Private Sub Õ–›Å” ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Õ–›Å” ToolStripMenuItem.Click
        If GrdPost.RowCount = 0 Then
            MsgBox("¬Ì „Ì »—«Ì Õ–› „ÊÃÊœ ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            Dim dt_Person As New DataTable
            dt_Person = Bus_Post1.GetActivePostDepartInfo(GrdPost.GetValue("PostCode"))
            If dt_Person.Rows.Count = 0 Then
                If MsgBox("¬Ì« «“ Õ–› ‘€· " & "(( " & Me.GrdPost.GetValue("Posttxt") & " ))" & "„ÿ„∆‰ Â” Ìœ ø ", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    Bus_Post1.UpdateActivePost(GrdPost.GetValue("PostCode"), 0)
                    FillMyGridView()
                    dt_Grid.DefaultView.RowFilter = " DepartCode = '" & TrvOrganChart.SelectedNode.Tag & " ' "
                End If
            Else
                MsgBox("‘„« ﬁ«œ— »Â Õ–› «Ì‰ ‘€· ‰„Ì »«‘Ìœ ° ‘Œ’ Ì« «‘Œ«’Ì œ— «Ì‰ Å”  „‘€Ê· »Â ﬂ«— „Ì »«‘‰œ", MsgBoxStyle.Information, "")
                Dim frm As New frmPersonInDepart
                frm.PostCode = GrdPost.GetValue("PostCode")
                frm.Text = "Å—”‰· ‘«€· œ—" + lblDepName.Text.Trim
                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub GrdPost_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdPost.DoubleClick
        If ShowForm = showMode.show Then
            Close()
        End If
    End Sub

    Private Sub contextPersonInDepart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextPersonInDepart.Click
        Dim frm As New frmPersonInDepart
        frm.DepartCode = TrvOrganChart.SelectedNode.Tag
        frm.Text = "Å—”‰· ‘«€· œ—" + lblDepName.Text.Trim
        frm.ShowDialog()
    End Sub

    Private Sub Å—”‰·‘«€·œ—Ê«ÕœToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Å—”‰·‘«€·œ—Ê«ÕœToolStripMenuItem.Click
        Dim frm As New frmPersonInDepart
        frm.DepartCode = TrvOrganChart.SelectedNode.Tag
        frm.Text = "Å—”‰· ‘«€· œ—" + lblDepName.Text.Trim
        frm.ShowDialog()
    End Sub

    Private Sub Å—”‰·‘«€·œ—Å” ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Å—”‰·‘«€·œ—Å” ToolStripMenuItem.Click
        Dim frm As New frmPersonInDepart
        frm.PostCode = GrdPost.GetValue("PostCode")
        frm.Text = "Å—”‰· ‘«€· œ—" + lblDepName.Text.Trim
        frm.ShowDialog()
    End Sub

    Private Sub Å—”‰·‘«€·œ—Å” ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Å—”‰·‘«€·œ—Å” ToolStripMenuItem1.Click
        Dim frm As New frmPersonInDepart
        frm.PostCode = GrdPost.GetValue("PostCode")
        frm.Text = "Å—”‰· ‘«€· œ—" + lblDepName.Text.Trim
        frm.ShowDialog()
    End Sub

    Private Sub GrdPost_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GrdPost.FormattingRow

    End Sub

    Private Sub contextPersEzafeInMDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextPersEzafeInMDep.Click
        Dim frm As New frmPRSEzafeKareVahed
        frm.ShowDialog()

    End Sub
End Class
'ﬂœÂ«Ì „—»Êÿ »Â ÊÌ—«Ì‘ Å”  Ê Ê«ÕœÂ«

'Private Sub contextChangeNode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextChangeNode.Click
'    Dim dt As DataTable
'    Dim frm As New FrmChangeNode
'    Dim dt_DepartType As New DataTable
'    dt = Bus_MDepart1.GettbHR_DepartInfo(TrvOrganChart.SelectedNode.Tag)
'    frm.ID = dt.DefaultView.Item(0).Item("DepID")
'    frm.LblDepID.Text = dt.DefaultView.Item(0).Item("DepCode")
'    frm.txtCode.Text = dt.DefaultView.Item(0).Item("DepCode")
'    frm.txtName.Text = dt.DefaultView.Item(0).Item("DepName")
'    frm.DepType = dt.DefaultView.Item(0).Item("DepTypeID")
'    frm.LblUpper.Text = dt.DefaultView.Item(0).Item("UpperCode")
'    frm.UperID = dt.DefaultView.Item(0).Item("UpperCode")
'    frm.Text = "ÊÌ—«Ì‘" + "  " + TrvOrganChart.SelectedNode.Text
'    If dt.DefaultView.Item(0).Item("Independent") = 1 Then
'        frm.chkIndependent.Checked = True
'    Else
'        frm.chkIndependent.Checked = False
'    End If
'    If dt.DefaultView.Item(0).Item("DepID") = 1 Then
'        MsgBox("‘„« ﬁ«œ— »Â ÊÌ—«Ì‘ «Ì‰ ‘«ŒÂ ‰„Ì »«‘Ìœ", MsgBoxStyle.OkOnly, "")
'        frm.Visible = False
'    Else
'        frm.ShowDialog()
'    End If
'End Sub
'--------------------------------------------
'Private Sub contextChangePost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contextChangePost.Click
'    Dim dt As DataTable
'    Dim frm As New FrmChangePost
'    dt = Bus_MDepart1.GettbHR_DepartInfo(TrvOrganChart.SelectedNode.Tag)
'    frm.PostTypeCode = GrdPost.GetValue("PostTypeCode")
'    frm.PostID = GrdPost.GetValue("PostID")
'    frm.lblpostcode.Text = GrdPost.GetValue("PostCode")
'    frm.txtName.Text = GrdPost.GetValue("Posttxt")
'    frm.Text = "ÊÌ—«Ì‘ Å” " + "  " + GrdPost.GetValue("Posttxt")
'    frm.ShowDialog()
'End Sub
