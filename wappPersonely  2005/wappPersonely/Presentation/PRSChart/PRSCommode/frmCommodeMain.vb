Public Class frmCommodeMain
    Dim DA1 As New SqlClient.SqlDataAdapter

    Private Sub ExplorerBar1_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ExplorerBar.ItemEventArgs) Handles ExplorerBar1.ItemClick
        Select Case e.Item.Key
            Case "btnClose"
                Me.Close()

            Case "btnAddCommodeNumber"
                Dim frm As New frmMostaafiPerson
                frm.ShowDialog()

            Case "btnCommode"
                Dim frm As New frmCommodeDevotion
                frm.ShowDialog()

            Case "btnCommodeAmar"
                wstr = "SELECT  COUNTCommodeNumber, CountCommodePor FROM   VwHR_CommodeAmar_Report"
                rptReports = New rptCommodeAmar
                LastRepName = ReportName
                ReportName = "rptCommodeAmar"
                Call rptLoad()

            Case "btnCommodeKhali"
                wstr = "SELECT   CommodeNumberID, CommodeNumber  FROM   VwHR_CommodeKhali"
                rptReports = New rptCommodeKhali
                LastRepName = ReportName
                ReportName = "rptCommodeKhali"
                Call rptLoad()

            Case "btnCommodeAndPersonTafkik"
                wstr = "Select * from VwHR_CommodePRSTafkikVahedReport"
                rptReports = New rptPersonCommodeTafkikVahed
                LastRepName = ReportName
                ReportName = "rptPersonCommodeTafkikVahed"
                Call rptLoad()

        End Select
    End Sub
    Private Sub rptLoad()
        Try
            If dsReports.Tables.Count > 0 Then
                dsReports.Tables(LastRepName).Clear()
            End If
            DA1 = Persist1.GetDataAccess(wstr, 1, ConString, ReportName, dsReports)
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

    Private Sub frmCommodeMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''''‰Ÿ— ”‰ÃÌ
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub
End Class