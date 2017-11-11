Public Class frmPersonInDepart
    Dim Bus_MDepart1 As New Bus_MDepart
    Dim dt_GridPerson As New DataTable
    Dim _DepartCode, _PostCode As String
    Dim DA1 As SqlClient.SqlDataAdapter
    Friend Property DepartCode() As String
        Get
            Return _DepartCode
        End Get
        Set(ByVal value As String)
            _DepartCode = value
        End Set
    End Property
    Friend Property PostCode() As String
        Get
            Return _PostCode
        End Get
        Set(ByVal value As String)
            _PostCode = value
        End Set
    End Property

    Private Sub frmPersonInDepart_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub frmPersonInDepart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillMyGridView()
        ''''‰Ÿ— ”‰ÃÌ

        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub
    Friend Sub FillMyGridView()
        Dim Janus1 As New JFrameWork.JanusGrid
        If PostCode <> "" Then
            dt_GridPerson = Bus_Post1.GetActivePostDepartInfo(PostCode)
            'dt_GridPerson = Bus_MDepart1.GetActivePostEmployeeDepartInfo(DepartCode)
            wstr = "SELECT * FROM VwHR_ActivePostEmployeeDepart where (PostCode ='" & PostCode & "')"
            Janus1.GetBindJGrid_DT(dt_GridPerson, grdPerson, ConString)
            Janus1.setMyJGrid(grdPerson, "DepartID", "", 0, , , False)
            Janus1.setMyJGrid(grdPerson, "DepartCode", "ﬂœ Ê«Õœ", 0, , , False)
            Janus1.setMyJGrid(grdPerson, "PersonCode", "ﬂœ Å—”‰·Ì", 75)
            Janus1.setMyJGrid(grdPerson, "Name", "‰«„ Ê ‰«„ Œ«‰Ê«œêÌ", 200)
            Janus1.setMyJGrid(grdPerson, "DepartName", "‰«„ Ê«Õœ", 200)
            Janus1.setMyJGrid(grdPerson, "PostCode", "ﬂœ Å” ", 75)
            Janus1.setMyJGrid(grdPerson, "Posttxt", "‰«„ Å” ", 200)
            btnPrintHokm.Enabled = True
            Panel1.Visible = False

        ElseIf DepartCode <> "" Then
            dt_GridPerson = Bus_Post1.GetActivePostEmployeeDepartInfo(DepartCode)

            lblDesc.Text = "   Å—”‰· ‘«€· œ— Ê«Õœ -”ﬁ› «÷«›Â ﬂ«—Ì " + Str(Utility1.NZ(dt_GridPerson.DefaultView.Item(0).Item("SagfVahedEzafe"), 0))
            'If dt_GridPerson.Rows.Count = 0 Then
            '    MsgBox("œ— «Ì‰ Ê«Õœ ﬂ”Ì „‘€Ê· »Â ﬂ«— ‰„Ì »«‘œ", MsgBoxStyle.Information, "")
            '    btnPrintHokm.Enabled = False
            '    Exit Sub
            'Else
            'SUBSTRING(CAST(DepartCode AS char(10)), 1, 2)
            wstr = "SELECT * FROM VwHR_ActivePostEmployeeDepart where (DepartCode ='" & DepartCode & "')or (MDepartCode ='" & DepartCode & "')"
            Janus1.GetBindJGrid_DT(dt_GridPerson, grdPerson, ConString)
            Janus1.setMyJGrid(grdPerson, "PersonCode", "ﬂœ Å—”‰·Ì", 75)
            Janus1.setMyJGrid(grdPerson, "Name", "‰«„ Ê ‰«„ Œ«‰Ê«œêÌ", 200)
            Janus1.setMyJGrid(grdPerson, "DepartName", "‰«„ Ê«Õœ", 200)
            Janus1.setMyJGrid(grdPerson, "DepartID", "", 0, , , False)
            Janus1.setMyJGrid(grdPerson, "DepartCode", "ﬂœ Ê«Õœ", 0, , , False)
            Janus1.setMyJGrid(grdPerson, "PostCode", "ﬂœ Å” ", 75)
            Janus1.setMyJGrid(grdPerson, "Posttxt", "‰«„ Å” ", 200)
            Janus1.setMyJGrid(grdPerson, "SagfEzafe", "«÷«›Â ﬂ«—Ì", 55)
            Janus1.setMyJGrid(grdPerson, "EzafActive", " Œ’Ì’ «÷«›Â ﬂ«—Ì", 45, Janus.Windows.GridEX.EditType.CheckBox, Janus.Windows.GridEX.ColumnType.CheckBox, True)
            btnPrintHokm.Enabled = True
            'End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnPrintHokm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintHokm.Click
        If grdPerson.RowCount <> 0 Then
            rptReports = New rptPersonIndDepart
            LastRepName = ReportName
            ReportName = "rptPersonIndDepart"
            Call rptLoad()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub rptLoad()
        Try
            If dsReports.Tables.Count > 0 Then
                dsReports.Tables(LastRepName).Clear()
            End If
            DA1 = Persist1.GetDataAccess(wstr, 1, ConString, ReportName, dsReports)
            Dim f1 As New frmReport
            f1.DepartName = Me.Text
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

  
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    Dim NafarEzaf As Integer
    Dim i As Integer


        SqlStr = "Update tbHR_Depart set SagfVahedEzafe=" & txtEzafVahed.Text & " Where DepartCode='" & DepartCode & "'"
        Persist1.GetDataAccess(SqlStr, 2, ConString)

        dt_GridPerson.DefaultView.RowFilter = "EzafActive=1"

        NafarEzaf = Val(txtEzafVahed.Text) / dt_GridPerson.DefaultView.Count

        For i = 0 To dt_GridPerson.DefaultView.Count - 1

            SqlStr = "Update tbHR_Person Set SagfEzafe=" & NafarEzaf & " Where PersonCode=" & dt_GridPerson.DefaultView.Item(i).Item("PersonCode")
            Persist1.GetDataAccess(SqlStr, 2, ConString)

        Next


        dt_GridPerson.DefaultView.RowFilter = "EzafActive=0"


        For i = 0 To dt_GridPerson.DefaultView.Count - 1

            SqlStr = "Update tbHR_Person Set SagfEzafe=0 Where PersonCode=" & dt_GridPerson.DefaultView.Item(i).Item("PersonCode")
            Persist1.GetDataAccess(SqlStr, 2, ConString)

        Next

        FillMyGridView()
    End Sub
End Class