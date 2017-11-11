Public Class frmBon
    Private DA1 As New SqlClient.SqlDataAdapter

    Private Sub btnList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnList.Click

        Dim dt As New DataTable

        SqlStr = "SELECT   PersonCode, prName,MDepartName, Barcode " & _
                  "  FROM   Vw_Bon  WHERE     (MDepartCode IN " & janus1.get_Collection_String(grdMDepart, 0, 2) & ") ORDER BY LastName"
        dt = Persist1.GetDataTable(ConString, SqlStr)

        Utility1.ExportTo(dt, IKIDUtility.ExportType.Excel)

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        rptReports = New rptBon
        LastRepName = ReportName
        ReportName = "rptBon"

        wstr = " SELECT   PersonCode, prName, LastName,MDepartCode, Barcode, PersonID, Deptxt, EmployeeID, EmployeeCode, DepartID, PostCode" & _
               "  FROM   Vw_Bon  WHERE     (PersonCode IN " & janus1.get_Collection_String(grdPRS, 0, 2) & ") ORDER BY LastName"

        Call rptLoad()

    End Sub

    Private Sub rptLoad()
        If dsReports.Tables.Count > 0 Then
            dsReports.Tables(LastRepName).Clear()
        End If
        DA1 = Persist1.GetDataAccess(wstr, 1, ConString, ReportName, dsReports)
        Dim f1 As New frmReport

        f1.BonDate = txtBonDate.Text.Trim
        f1.BonType = txtBonType.Text.Trim
        f1.rptName = ReportName
       
        f1.Show()
    End Sub

    Private Sub frmBon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmBon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim LID As Integer
        Dim LogText As String
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LID = getLogID(LogText)
        If Activity1.CheckUserAccess(54, 766, LID) = False Then
            Me.Enabled = False
            MsgBox("‘„« »Â «Ì‰ ‰—„ «›“«— œ” —”Ì ‰œ«—Ìœ", MsgBoxStyle.Information, "")
            Me.Close()
            Exit Sub
        End If
        utility1.GetLanguageFarsi()
        Fillgrd()

        ''''‰Ÿ— ”‰ÃÌ

        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub

    Public Function getLogID(ByVal Logon As String) As Integer
        Try
            Dim Sqlstr As String
            Dim DataTable1 As New DataTable
            Sqlstr = "select LoginID from GeneralObjects..tbGen_Logins where LoginName='" & Logon & "' "
            DataTable1 = Persist1.GetDataTable(ConString, Sqlstr)
            Dim x As Integer
            x = DataTable1.DefaultView.Item(0).Item("LoginID")
            getLogID = x
        Catch ex As Exception
            getLogID = 0
        End Try
    End Function

    Friend Sub Fillgrd()
        Dim dt As New DataTable
        SqlStr = _
                " SELECT     DepartCode, MDepartName " & _
                " FROM         VwHR_MDepart " & _
                " WHERE     (Active = 1) AND (DepartCode <> N'0') AND (DepartCode <> N'VV000') AND (DepartCode <> N'XX000') AND (DepartCode <> N'YY000') AND  " & _
                " (DepartCode <> N'ZY000') AND (DepartCode <> N'ZZ000') order by DepartCode"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        janus1.GetBindJGrid_DT(dt, grdMDepart, ConString)
        'Janus1.Add_ColDt(dt)

        Janus1.setMyJGrid(grdMDepart, "DepartCode", "ﬂœ Ê«Õœ", 100, , , True)
        Janus1.setMyJGrid(grdMDepart, "MDepartName", "‰«„ Ê«Õœ", 250, , , True)
        'Janus1.setMyJGrid(grdMDepart, "Sel", "ê“Ì‰‘", 50, Janus.Windows.GridEX.EditType.CheckBox, Janus.Windows.GridEX.ColumnType.CheckBox, True)

    End Sub

    Private Sub grdMDepart_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMDepart.CurrentCellChanged
        Try
            FillgrdPRS()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FillgrdPRS()
        Dim dt_prs As New DataTable
        SqlStr = _
                " SELECT     PersonCode, prName " & _
                " FROM          Vw_Bon WHERE     (MDepartCode = '" & grdMDepart.GetValue("DepartCode") & "') order by prName "
        dt_prs = Persist1.GetDataTable(ConString, SqlStr)
        janus1.GetBindJGrid_DT(dt_prs, grdPRS, ConString)
        janus1.Add_ColDt(dt_prs)

        janus1.setMyJGrid(grdPRS, "PersonCode", "ﬂœ Å—”‰·", 100, , , True)
        janus1.setMyJGrid(grdPRS, "prName", "‰«„", 250, , , True)
        janus1.setMyJGrid(grdPRS, "Sel", "ê“Ì‰‘", 50, Janus.Windows.GridEX.EditType.CheckBox, Janus.Windows.GridEX.ColumnType.CheckBox, True)

    End Sub

End Class
