Public Class frmPRSAlarm
    Dim dt_EndTreaty As New DataTable
    Dim Bus_Person1 As New Bus_Person
    Dim Janus1 As New JFrameWork.JanusGrid
    Dim DA1 As New SqlClient.SqlDataAdapter
    Dim Day As String
    Dim EngageTypeID As Integer

    Private Sub frmPRSAlarm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmPRSAlarm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCombo()
        Try
            FillMyGrideView()
        Catch ex As Exception

        End Try


        ''''نظر سنجي
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub

    Friend Sub FillCombo()
        Dim sqlstr As String
        Dim dt_EngageType As New DataTable
        sqlstr = "SELECT  *  FROM  tbHR_EngageType"
        dt_EngageType = Persist1.GetDataTable(ConString, sqlstr)
        Persist1.FillCmb(dt_EngageType, cmbEngageType, "EngageTypeID", "EngageType")
    End Sub

    Friend Sub FillMyGrideView()

        Dim a As Long
        a = IraniDate1.GetPlussToIraniDate(IraniDate1.GetIrani8Date_CurDate, 70)
        Day = IraniDate1.GetDateIntToStr_GivenDate(a)
        EngageTypeID = cmbEngageType.SelectedValue

        dt_EndTreaty = Bus_Person1.GetAlarmInfo(IraniDate1.GetIrani8DateStr_CurDate, Day, EngageTypeID)

        Janus1.Add_ColDt(dt_EndTreaty)
        Janus1.GetBindJGrid_DT(dt_EndTreaty, grdEmployee, ConString)
        Janus1.setMyJGrid(grdEmployee, "EmployeeCode", "شماره حكم", 50)
        Janus1.setMyJGrid(grdEmployee, "PersonCode", "كد پرسنلي", 75)
        Janus1.setMyJGrid(grdEmployee, "Name", "نام", 125)
        Janus1.setMyJGrid(grdEmployee, "DepartName", "نام اداره", 100)
        Janus1.setMyJGrid(grdEmployee, "MDepartName", "نام واحد", 150)
        Janus1.setMyJGrid(grdEmployee, "EndDate", "تاريخ اتمام", 85)
        Janus1.setMyJGrid(grdEmployee, "Sel", "گزينش", 50, Janus.Windows.GridEX.EditType.CheckBox, Janus.Windows.GridEX.ColumnType.CheckBox)
        Janus1.setMyJGrid(grdEmployee, "EngageTypeID", "", 0, , , False)
        Janus1.setMyJGrid(grdEmployee, "EngageType", "نوع استخدام", 0, , , False)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnPrintAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAll.Click
        If grdEmployee.RowCount <> 0 Then
            Try
                wstr = "select * from dbo.VwHR_EndEmployee where (EndDate BETWEEN '" & IraniDate1.GetIrani8DateStr_CurDate & "' AND '" & Day & "') AND (EngageTypeID = " & cmbEngageType.SelectedValue & ")  AND (PersonCode   in " & Janus1.get_Collection_String(grdEmployee, 1, 6) & ") AND (Groupid<12)"

 
                rptReports = New RptEndEmploee2
                LastRepName = ReportName
                ReportName = "RptEndEmploee2"
                Call rptLoad()
            Catch ex As Exception

            End Try
        Else
            MsgBox("اطلاعاتي براي چاپ موجود نمي باشد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
    End Sub



    Private Sub btnOnePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOnePrint.Click
        Dim PersonCode As Integer
        Dim dt As New DataTable
        If grdEmployee.RowCount <> 0 Then
            PersonCode = grdEmployee.GetValue("PersonCode")
            Try
                wstr = "select * from dbo.VwHR_EndEmployee where (EndDate BETWEEN '" & IraniDate1.GetIrani8DateStr_CurDate & "' AND '" & Day & "') AND (EngageTypeID = " & cmbEngageType.SelectedValue & ")  AND (PersonCode = " & PersonCode & ")"
                dt = Persist1.GetDataTable(ConString, wstr)
                If dt.DefaultView.Item(0).Item("GroupID") >= 12 Then
                    rptReports = New RptEndEmploee
                    LastRepName = ReportName
                    ReportName = "RptEndEmploee"
                Else
                    rptReports = New RptEndEmploee2
                    LastRepName = ReportName
                    ReportName = "RptEndEmploee2"

                End If


               
                Call rptLoad()
            Catch ex As Exception

            End Try
        Else
            MsgBox("اطلاعاتي براي چاپ موجود نمي باشد", MsgBoxStyle.Information, "")
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
            f1.CurDate = IraniDate1.GetIraniDayName_CurDate + "  " + IraniDate1.GetIrani8DateStr_CurDate
            f1.Show()
        Catch ex As Exception
            Dim r3 As DialogResult = MessageBox.Show("كليك نماييد Help بر روي سيستم شما نصب نمي باشد براي نصب نرم افزار روي دكمه  Crystal Report2005", _
                                                      "Help Caption", MessageBoxButtons.OK, _
                                                      MessageBoxIcon.Question, _
                                                      MessageBoxDefaultButton.Button1, _
                                                      0, "\\Nt_dbms\mis\iso\Help\WareSupply for 2005\CRRedist2005_x86.msi", _
                                                      HelpNavigator.Index)
        End Try
    End Sub

    Private Sub cmbEngageType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEngageType.SelectedValueChanged
        Try
            FillMyGrideView()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdEmployee_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEmployee.CurrentCellChanged
        Janus1.BindJanusNavigator(grdEmployee, dt_EndTreaty)
    End Sub

    Private Sub grdEmployee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdEmployee.KeyPress
        Janus1.BindJanusNavigator(grdEmployee, dt_EndTreaty)
    End Sub
 
    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        If grdEmployee.RowCount <> 0 Then
            Try
                wstr = "select * from dbo.VwHR_EndEmployee where (EndDate BETWEEN '" & IraniDate1.GetIrani8DateStr_CurDate & "' AND '" & Day & "') AND (EngageTypeID = " & cmbEngageType.SelectedValue & ")  AND (PersonCode   in " & Janus1.get_Collection_String(grdEmployee, 1, 6) & ") AND (Groupid>=12)"

 
                rptReports = New RptEndEmploee
                LastRepName = ReportName
                ReportName = "RptEndEmploee"
                Call rptLoad()
            Catch ex As Exception

            End Try
        Else
            MsgBox("اطلاعاتي براي چاپ موجود نمي باشد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
    End Sub
End Class