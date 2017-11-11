Public Class Form1
    Dim DA As New SqlClient.SqlDataAdapter
    Dim dtPerson As New DataTable

    Private Sub btnRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRpt.Click
        wstr = "select * from VwHR_rptManagerPropertyAbstract where personcode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ""
        rptReports = New rptManagerPropertyAbstract
        LastRepName = ReportName
        ReportName = "rptManagerPropertyAbstract"
        rptLoad()
    End Sub

    Friend Sub FillgrdPerson()
        Dim tbs1 As New DataGridTableStyle
        SqlStr = _
             "SELECT  dbo.tbHR_Person.PersonCode, dbo.tbHR_Person.FirstName + '-' + dbo.tbHR_Person.LastName AS prname,  " & _
             "                      dbo.tbHR_PostType.PostType " & _
             "FROM         dbo.tbHR_Employee INNER JOIN " & _
             "                      dbo.tbHR_Person ON dbo.tbHR_Employee.PersonID = dbo.tbHR_Person.PersonID INNER JOIN " & _
             "                      dbo.tbHR_Post ON dbo.tbHR_Employee.PostID = dbo.tbHR_Post.PostID INNER JOIN " & _
             "                      dbo.tbHR_PostType ON dbo.tbHR_Post.PostTypeID = dbo.tbHR_PostType.PostTypeID " & _
              "WHERE     (dbo.tbHR_Employee.Active = 1) AND (dbo.tbHR_PostType.PostTypeCode = 0 OR " & _
              "                      dbo.tbHR_PostType.PostTypeCode = 1 OR " & _
              "                      dbo.tbHR_PostType.PostTypeCode = 2) " & _
              "ORDER BY dbo.tbHR_PostType.PostTypeCode, dbo.tbHR_Person.LastName"
        dtPerson = Persist1.GetDataTable(ConString, SqlStr)
        grdSelect1.Add_ColDt(dtPerson)
        Persist1.GetBindGrid_Dt(grdPerson, ConString, dtPerson)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.BooleanTxt, dtPerson, grdPerson, "sel", "ê“Ì‰‘", 50, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "PersonCode", "ﬂœ Å—”‰·Ì", 55, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "prname", "‰«„ Œ«‰Ê«œêÌ", 200, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "PostType", "‰Ê⁄ Å” ", 150, True, True)
    End Sub

    Private Sub rptLoad()
        Try
            If dsReports.Tables.Count > 0 Then
                dsReports.Tables(LastRepName).Clear()
            End If
            DA = Persist1.GetDataAccess(wstr, 1, ConString, ReportName, dsReports)
            Dim f1 As New frmReport
            f1.CurDate = IraniDate1.GetIraniDayName_CurDate + "  " + IraniDate1.GetIrani8DateStr_CurDate
            f1.Show()
        Catch ex As Exception
            Dim r3 As DialogResult = MessageBox.Show("ﬂ·Ìﬂ ‰„«ÌÌœ Help »— —ÊÌ ”Ì” „ ‘„« ‰’» ‰„Ì »«‘œ »—«Ì ‰’» ‰—„ «›“«— —ÊÌ œﬂ„Â  Crystal Report2005", _
                                                      "Help Caption", MessageBoxButtons.OK, _
                                                      MessageBoxIcon.Question, _
                                                      MessageBoxDefaultButton.Button1, _
                                                      0, "\\Nt_dbms\mis\iso\Help\WareSupply for 2005\CRRedist2005_x86.msi", _
                                                      HelpNavigator.Index)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillgrdPerson()
    End Sub

    Private Sub grdPerson_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPerson.Click
        grdSelect1.Grid_State(grdPerson, 0)
        DgSelect2.DG = grdPerson
        DgSelect2.DT = dtPerson
    End Sub
End Class