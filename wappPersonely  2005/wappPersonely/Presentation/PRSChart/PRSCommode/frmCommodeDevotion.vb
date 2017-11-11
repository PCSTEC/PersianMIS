
Public Class frmCommodeDevotion
    Dim Bus_Commode1 As New Bus_Commode
    Dim dt_Person As New DataTable
    Dim dt_CommodeNumber As New DataTable
    Dim dt_PersonAndCommode As New DataTable
    Dim dt_ControlMostaafi As New DataTable

    Private Sub frmCommodeDevotion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
        janus1.BindJanusNavigator(grdPerson, dt_Person, e)
    End Sub

    Private Sub frmCommodeDevotion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt_ControlMostaafi = Bus_Commode1.PersonMostaafi
        If dt_ControlMostaafi.Rows.Count > 0 Then
            If MsgBox("¬Ì« „«Ì· »Â „‘«ÂœÂ «›—«œ „‰›ﬂ ‘œÂ ° ÃÂ  Õ–› ‘„«—Â ﬂ„œ „Ì »«‘Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Dim frm As New frmMostaafiPerson
                frm.ShowDialog()
            End If
        End If
        FillMyPersonGrid()
        FillCommodeNumberGride()
        FillMyGridePersonCommodeDaar()
        txtTahvilDate.Text = IraniDate1.GetIrani8Date_CurDate

        ''''‰Ÿ— ”‰ÃÌ
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''

    End Sub

    Friend Sub FillMyPersonGrid()
        Dim janus1 As New JFrameWork.JanusGrid
        ''''Å— ﬂ—œ‰ ê—Ìœ Å—”‰·
        dt_Person = Bus_Commode1.GetPersonJari()
        janus1.GetBindJGrid_DT(dt_Person, grdPerson, ConString)
        janus1.setMyJGrid(grdPerson, "PersonID", "", 0, , , False)
        janus1.setMyJGrid(grdPerson, "PersonCode", "ﬂœ Å—”‰·Ì", 75)
        janus1.setMyJGrid(grdPerson, "FirstName", "‰«„", 100)
        janus1.setMyJGrid(grdPerson, "LastName", "‰«„ Œ«‰Ê«œêÌ", 120)
        janus1.setMyJGrid(grdPerson, "MDepartName", "‰«„ Ê«Õœ", 160)
        janus1.setMyJGrid(grdPerson, "DepartName", "‰«„ «œ«—Â", 160)
        janus1.BindJanusNavigator(grdPerson, dt_Person)
    End Sub

    Friend Sub FillCommodeNumberGride()
        ''''Å— ﬂ—œ‰ ê—Ìœ ‘„«—Â ﬂ„œÂ«Ì Œ«·Ì
        dt_CommodeNumber = Bus_Commode1.GetCommodeNumbers
        janus1.GetBindJGrid_DT(dt_CommodeNumber, grdCommodeNumber, ConString)
        janus1.setMyJGrid(grdCommodeNumber, "CommodeNumberID", "", 0, , , False)
        janus1.setMyJGrid(grdCommodeNumber, "CommodeNumber", "‘„«—Â ﬂ„œ", 100)
    End Sub

    Friend Sub FillMyGridePersonCommodeDaar()
        ''''Å— ﬂ—œ‰ ê—ÌœÅ—”‰· Ê ﬂ„œÂ«Ì‘«‰
        dt_PersonAndCommode = Bus_Commode1.PersonCommodeDaarInfo
        janus1.GetBindJGrid_DT(dt_PersonAndCommode, grdPersonAndCommode, ConString)
        janus1.setMyJGrid(grdPersonAndCommode, "CommodeID", "", 0, , , False)
        janus1.setMyJGrid(grdPersonAndCommode, "CommodeNumberID", "", 0, , , False)
        janus1.setMyJGrid(grdPersonAndCommode, "CommodeNumber", "‘„«—Â ﬂ„œ", 80)
        janus1.setMyJGrid(grdPersonAndCommode, "PersonID", "", 0, , , False)
        janus1.setMyJGrid(grdPersonAndCommode, "PersonCode", "ﬂœ Å—”‰·Ì", 80)
        janus1.setMyJGrid(grdPersonAndCommode, "TahvilDate", " «—ÌŒ  ÕÊÌ·", 100)
        janus1.setMyJGrid(grdPersonAndCommode, "FirstName", "‰«„", 100)
        janus1.setMyJGrid(grdPersonAndCommode, "LastName", "‰«„ Œ«‰Ê«œêÌ", 175)
        janus1.setMyJGrid(grdPersonAndCommode, "DepartCode", "", 0, , , False)
        janus1.setMyJGrid(grdPersonAndCommode, "MDepartName", "‰«„ Ê«Õœ", 210)
        janus1.setMyJGrid(grdPersonAndCommode, "DepartName", "‰«„ «œ«—Â", 210)
        janus1.BindJanusNavigator(grdPerson, dt_Person)
    End Sub
    Private Sub btnAddCommode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCommode.Click
        Dim dt As New DataTable
        Dim CommodeNumber As Integer
        If txtCommodeNumber.Text.Trim = "" Then
            MsgBox("·ÿ›« „ﬁœ«— Ê«—œ ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        CommodeNumber = Val(txtCommodeNumber.Text.Trim)
        SqlStr = " Select  CommodeNumber FROM tbHR_CommodeNumber   WHERE(CommodeNumber = " & CommodeNumber & ")"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If dt.Rows.Count <> 0 Then
            MsgBox("‘„«—Â Ê«—œ ‘œÂ  ﬂ—«—Ì „Ì »«‘œ", MsgBoxStyle.Information, "")
            Exit Sub
        Else
            If MsgBox("¬Ì« «“ œ—Ã ‘„«—Â ÃœÌœ „ÿ„∆‰ „Ì »«‘Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Bus_Commode1.InsertCommodeNumber(CommodeNumber)
                FillCommodeNumberGride()
                txtCommodeNumber.Text = ""
                MsgBox("—ﬂÊ—œ „Ê—œ ‰Ÿ— »« „Ê›ﬁÌ  À»  ê—œÌœ", MsgBoxStyle.Information, "")
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDeleteCommodeNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCommodeNumber.Click
        If grdCommodeNumber.RowCount = 0 Then
            MsgBox("—ﬂÊ—œÌ »—«Ì Õ–› „ÊÃÊœ ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If MsgBox("¬Ì« «“ Õ–› —ﬂÊ—œ „Ê—œ ‰Ÿ— „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Bus_Commode1.DeleteCommodeNumber(grdCommodeNumber.GetValue("CommodeNumberID"))
            FillCommodeNumberGride()
            MsgBox("—ﬂÊ—œ »« „Ê›ﬁÌ  Õ–› ê—œÌœ", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub grdPerson_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPerson.Click
        janus1.BindJanusNavigator(grdPerson, dt_Person)
    End Sub

    Private Sub grdPerson_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPerson.DoubleClick
        lblPersonCode.Text = grdPerson.GetValue("PersonCode")
        lblPersonID.Text = grdPerson.GetValue("PersonID")
        lblPersonName.Text = grdPerson.GetValue("FirstName") + "  -  " + grdPerson.GetValue("LastName")
    End Sub

    Private Sub grdCommodeNumber_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdCommodeNumber.DoubleClick
        lblCommodeNumberID.Text = grdCommodeNumber.GetValue("CommodeNumberID")
        lblCommodeNumber.Text = grdCommodeNumber.GetValue("CommodeNumber")
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dt As New DataTable
        If lblCommodeNumber.Text.Trim = "" Or lblPersonCode.Text.Trim = "" Or lblPersonName.Text.Trim = "" Or txtTahvilDate.Text.Trim = "" Then
            MsgBox("·ÿ›« Ã«Â«Ì Œ«·Ì —« Å— ‰„«ÌÌœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If IraniDate1.TestDate(IraniDate1.Numericdate(txtTahvilDate.Text.Trim)) = True Then
            Exit Sub
        End If
        SqlStr = "Select  PersonID  FROM tbHR_Commode  WHERE (PersonID = " & Val(lblPersonID.Text.Trim) & " and Active = 1)"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        If dt.Rows.Count > 0 Then
            If MsgBox("›—œ œ«—«Ì ﬂ„œ „Ì »«‘œ . ¬Ì« „Ì ŒÊ«ÂÌœ ﬂ„œ œÌê—Ì »Â «Ê «Œ ’«’ œÂÌœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        If MsgBox("¬Ì« «“ À»  —ﬂÊ—œ „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Bus_Commode1.inserttbHRCommode(Val(lblCommodeNumberID.Text.Trim), Val(lblCommodeNumber.Text.Trim), Val(lblPersonID.Text.Trim), Val(lblPersonCode.Text.Trim), txtTahvilDate.Text.Trim, 1)
            FillCommodeNumberGride()
            FillMyGridePersonCommodeDaar()
            lblCommodeNumber.Text = ""
            lblPersonCode.Text = ""
            lblPersonName.Text = ""
            lblPersonID.Text = ""
            lblCommodeNumberID.Text = ""
            MsgBox("—ﬂÊ—œ »« „Ê›ﬁÌ  À»  ‘œ", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grdPersonAndCommode.RowCount = 0 Then
            MsgBox("—ﬂÊ—œÌ »—«Ì Õ–› „ÊÃÊœ ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If MsgBox("¬Ì« «“ Õ–› —ﬂÊ—œ „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Bus_Commode1.deletetbHRCommode(grdPersonAndCommode.GetValue("CommodeID"), 0)
            FillCommodeNumberGride()
            FillMyGridePersonCommodeDaar()
            MsgBox("—ﬂÊ—œ »« „Ê›ﬁÌ  Õ–› ‘œ", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        lblPersonCode.Text = grdPersonAndCommode.GetValue("PersonCode")
        lblPersonID.Text = grdPersonAndCommode.GetValue("PersonID")
        lblPersonName.Text = grdPersonAndCommode.GetValue("prName")
        lblCommodeNumber.Text = grdPersonAndCommode.GetValue("CommodeNumber")
        lblCommodeNumberID.Text = grdPersonAndCommode.GetValue("CommodeNumberID")
        txtTahvilDate.Text = grdPersonAndCommode.GetValue("TahvilDate")
        lblCommodeID.Text = grdPersonAndCommode.GetValue("CommodeID")
        btnChangeAdd.Visible = True
        btnDelete.Visible = False
        btnAdd.Visible = False
        btnChange.Visible = False
    End Sub

    Private Sub btnChangeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeAdd.Click
        If MsgBox("¬Ì« «“ À»   €ÌÌ—«  „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Bus_Commode1.updatetbHRCommode(Val(lblCommodeID.Text.Trim), Val(lblCommodeNumberID.Text.Trim), Val(lblCommodeNumber.Text.Trim), Val(lblPersonID.Text.Trim), Val(lblPersonCode.Text.Trim), txtTahvilDate.Text.Trim, 1)
            FillCommodeNumberGride()
            FillMyGridePersonCommodeDaar()
            MsgBox(" €ÌÌ—«  »« „Ê›ﬁÌ  À»  ê—œÌœ", MsgBoxStyle.Information, "")
        Else
            Exit Sub
        End If
        lblCommodeID.Text = ""
        lblPersonCode.Text = ""
        lblPersonID.Text = ""
        lblPersonName.Text = ""
        lblCommodeNumber.Text = ""
        lblCommodeNumberID.Text = ""
        'txtTahvilDate.Text = ""
        btnChangeAdd.Visible = False
        btnDelete.Visible = True
        btnAdd.Visible = True
        btnChange.Visible = True
    End Sub

    Private Sub grdPersonAndCommode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPersonAndCommode.Click
        janus1.BindJanusNavigator(grdPersonAndCommode, dt_PersonAndCommode)
    End Sub
End Class