Public Class frmAddMadrak
    Dim bus_Person1 As New Bus_Person
    Dim dt_EducationType As New DataTable
    Dim janus1 As New JFrameWork.JanusGrid
    Dim dt_Branchtxt As New DataTable
    Dim dt_Attitudetxt As New DataTable

    Private Sub frmAddMadrak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrdEducationType()
    End Sub

    Friend Function fillgrdEducationType()
        dt_EducationType = Bus_Education1.EducationTypeInfo()
        janus1.GetBindJGrid_DT(dt_EducationType, grdEducationType, ConString)
        janus1.setMyJGrid(grdEducationType, "EduationTypeID", "", 0, , , False)
        janus1.setMyJGrid(grdEducationType, "EducationTypeCode", "ﬂœ ‰Ê⁄  Õ’Ì·« ", 100)
        janus1.setMyJGrid(grdEducationType, "EducationTypetxt", "‰Ê⁄  Õ’Ì·« ", 200)
    End Function

    Private Sub btnAddEducationType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEducationType.Click
        Dim EducationTypeCode As Integer
        Dim dt_EducationTypeCode As New DataTable
        SqlStr = "SELECT   MAX(EducationTypeCode) AS maxEducationTypeCode FROM tbHR_EducationType"
        dt_EducationTypeCode = Persist1.GetDataTable(ConString, SqlStr)
        EducationTypeCode = dt_EducationTypeCode.DefaultView.Item(0).Item("maxEducationTypeCode") + 1
        If MsgBox("¬Ì« «“ À»  «Ì‰ —ﬂÊ—œ „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Bus_Education1.insert_tbHR_EducationType(EducationTypeCode, txtEducationTypetxt.Text.Trim)
            fillgrdEducationType()
            txtEducationTypetxt.Text = ""
            MsgBox("—ﬂÊ—œ »« „Ê›ﬁÌ  À»  ‘œ", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Friend Function fillgrdBranchTxt()
        dt_Branchtxt = Bus_Education1.GetBranchInfo(grdEducationType.GetValue("EducationTypeCode"))
        janus1.GetBindJGrid_DT(dt_Branchtxt, grdBranchTxt, ConString)
        janus1.setMyJGrid(grdBranchTxt, "BranchID", "", 0, , , False)
        janus1.setMyJGrid(grdBranchTxt, "EducationTypeID", "", 0, , , False)
        janus1.setMyJGrid(grdBranchTxt, "EducationTypeCode", "ﬂœ ‰Ê⁄  Õ’Ì·« ", 100)
        janus1.setMyJGrid(grdBranchTxt, "BranchCode", "ﬂœ —‘ Â", 75)
        janus1.setMyJGrid(grdBranchTxt, "BranchTxt", "—‘ Â", 200)
    End Function

    Private Sub btnAddBranchTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBranchTxt.Click
        If txtBranchTxt.Text.Trim = "" Then
            MsgBox("·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        Dim BranchCode As Integer
        Dim dt_BranchCode As New DataTable
        Dim EducationTypeCode, EducationTypeID As Integer
        EducationTypeID = grdEducationType.GetValue("EduationTypeID")
        EducationTypeCode = grdEducationType.GetValue("EducationTypeCode")
        SqlStr = "SELECT  isnull(MAX(BranchCode),0) AS maxBranchCode FROM tbHR_Branch where (EducationTypeCode = " & EducationTypeCode & ")"
        dt_BranchCode = Persist1.GetDataTable(ConString, SqlStr)
        If dt_BranchCode.DefaultView.Item(0).Item("maxBranchCode") = 0 Then
            BranchCode = EducationTypeCode * 100
        Else
            BranchCode = dt_BranchCode.DefaultView.Item(0).Item("maxBranchCode") + 1
        End If
        If MsgBox("¬Ì« «“ À»  «Ì‰ —ﬂÊ—œ „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Bus_Education1.insert_tbHR_Branch(BranchCode, txtBranchTxt.Text.Trim, EducationTypeCode, EducationTypeID)
            txtBranchTxt.Text = ""
            fillgrdBranchTxt()
            MsgBox("—ﬂÊ—œ »« „Ê›ﬁÌ  À»  ‘œ", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Friend Function fillgrdAttitudeTxt()
        dt_Attitudetxt = Bus_Education1.GetAttitude(grdBranchTxt.GetValue("BranchCode"))
        janus1.GetBindJGrid_DT(dt_Attitudetxt, grdAttitudeName, ConString)
        janus1.setMyJGrid(grdAttitudeName, "BranchID", "", 0, , , False)
        janus1.setMyJGrid(grdAttitudeName, "AttitudeID", "", 0, , , False)
        janus1.setMyJGrid(grdAttitudeName, "BranchCode", "ﬂœ —‘ Â", 75)
        janus1.setMyJGrid(grdAttitudeName, "AttitudeCode", "ﬂœ ‰Ê⁄ ê—«Ì‘", 75)
        janus1.setMyJGrid(grdAttitudeName, "AttitudeName", "‰Ê⁄ ê—«Ì‘", 200)
    End Function

    Private Sub btnAddAttitudeName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAttitudeName.Click
        'insert_tbHR_Attitude()
        If txtAttitudeName.Text.Trim = "" Then
            MsgBox("·ÿ›« „ﬁ«œÌ— —« œ—”  Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        Dim AttitudeCode As Integer
        Dim dt_AttitudeCode As New DataTable

        Dim BranchCode, BranchID As Integer
        BranchID = grdBranchTxt.GetValue("BranchID")
        BranchCode = grdBranchTxt.GetValue("BranchCode")
        SqlStr = "SELECT isnull(MAX(AttitudeCode),0) AS MAXAttitudeCode   FROM  tbHR_Attitude WHERE (BranchCode = " & BranchCode & ")"
        dt_AttitudeCode = Persist1.GetDataTable(ConString, SqlStr)
        If dt_AttitudeCode.DefaultView.Item(0).Item("MAXAttitudeCode") = 0 Then
            AttitudeCode = BranchCode * 100
        Else
            AttitudeCode = dt_AttitudeCode.DefaultView.Item(0).Item("MAXAttitudeCode") + 1
        End If
        If MsgBox("¬Ì« «“ À»  «Ì‰ —ﬂÊ—œ „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Bus_Education1.insert_tbHR_Attitude(AttitudeCode, txtAttitudeName.Text.Trim, BranchCode, BranchID)
            txtBranchTxt.Text = ""
            fillgrdAttitudeTxt()
            MsgBox("—ﬂÊ—œ »« „Ê›ﬁÌ  À»  ‘œ", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub grdEducationType_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdEducationType.CurrentCellChanged
        Try
            fillgrdBranchTxt()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdBranchTxt_CurrentCellChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdBranchTxt.CurrentCellChanged
        Try
            fillgrdAttitudeTxt()
        Catch ex As Exception

        End Try
    End Sub

End Class