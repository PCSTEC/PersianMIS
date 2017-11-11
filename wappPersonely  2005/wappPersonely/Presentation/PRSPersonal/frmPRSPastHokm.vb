Public Class frmPRSPastHokm
    Dim dt_Employeeinfo As DataTable
    Dim Bus_Person1 As New Bus_Person
    Dim _PersonCode As Integer
    Private DA1 As New SqlClient.SqlDataAdapter
    Dim SumAllSalary As Double = 0
    Dim GroupSalary As Double = 0
    Dim SumrootSalary As Double = 0
    Dim MarriageType As String
    Dim ChildCount As Integer

    Friend Property PersonCode() As Integer
        Get
            Return _PersonCode
        End Get
        Set(ByVal value As Integer)
            _PersonCode = value
        End Set
    End Property

    Private Sub frmPRSPastHokm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmPastHokm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If Activity1.CheckUserAccess(54, 959, LogID) = True Then
            btnDeletHokm.Visible = True
            mnudelHokm.Visible = True

        End If


        If Activity1.CheckUserAccess(54, 784, LogID) = False Then
            btnDeletHokm.Visible = False
        End If

        FillMyGridview()
        ''''‰Ÿ— ”‰ÃÌ
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub

    Friend Sub FillMyGridview()
        dt_Employeeinfo = Bus_Employee1.GetRptHokmInfo(PersonCode)
        janus1.GetBindJGrid_DT(dt_Employeeinfo, grdEmployee, ConString)
        janus1.setMyJGrid(grdEmployee, "EmployeeID", "", 0, , , False)
        janus1.setMyJGrid(grdEmployee, "EmployeeCode", "‘„«—Â Õﬂ„", 65)
        janus1.setMyJGrid(grdEmployee, "EmissionDate", " «—ÌŒ ’œÊ—", 85)
        janus1.setMyJGrid(grdEmployee, "ExecDate", " «—ÌŒ «Ã—«", 85)
        janus1.setMyJGrid(grdEmployee, "EmployeeType", "‰Ê⁄ Õﬂ„", 200)
        janus1.setMyJGrid(grdEmployee, "EmployTypeID", "‰Ê⁄ Õﬂ„", 200, , , False)

        janus1.setMyJGrid(grdEmployee, "DepartName", "Ê«Õœ ”«“„«‰Ì", 200)
        janus1.setMyJGrid(grdEmployee, "Posttxt", "Å” ", 225)
        janus1.setMyJGrid(grdEmployee, "FirstName", "‰«„", 0, , , False)
        janus1.setMyJGrid(grdEmployee, "LastName", "‰«„ Œ«‰Ê«œêÌ", 0, , , False)
        janus1.setMyJGrid(grdEmployee, "EngageDate", " «—ÌŒ «” Œœ«„", 0, , , False)
        janus1.setMyJGrid(grdEmployee, "EngageType", "‰Ê⁄ «” Œœ«„", 0, , , False)
        janus1.setMyJGrid(grdEmployee, "PersonCode", "ﬂœ Å—”‰·Ì", 0, , , False)
        janus1.setMyJGrid(grdEmployee, "EmployeeActive", "EmployeeActive", 0, , , False)
        janus1.setMyJGrid(grdEmployee, "EngageTypeID", "", 0, , , False)
        janus1.HighLightRows(grdEmployee, "EmployeeActive", Janus.Windows.GridEX.ConditionOperator.Equal, 1, Color.Aqua)

    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim dt1 As New DataTable
        If grdEmployee.GetValue("EngageTypeID") = 1 Or grdEmployee.GetValue("EngageTypeID") = 2 Or grdEmployee.GetValue("EngageTypeID") = 5 Or grdEmployee.GetValue("EngageTypeID") = 11 Then
            Try
                wstr = "select * from VwHR_RptHokmInfo where EmployeeCode = " & grdEmployee.GetValue("EmployeeCode") & " and PersonCode =  " & grdEmployee.GetValue("PersonCode") & " "


                rptReports = New rptHokmTabaghebandiiiiii
                ReportName = "rptHokmTabaghebandiiiiii"
                LastRepName = ReportName
                dt1 = Persist1.GetDataTable(ConString, wstr)
                SumAllSalary = dt1.DefaultView.Item(0).Item("Barjeste") + dt1.DefaultView.Item(0).Item("Differ") + dt1.DefaultView.Item(0).Item("BON") + dt1.DefaultView.Item(0).Item("Sanavat") + dt1.DefaultView.Item(0).Item("OverPost") + dt1.DefaultView.Item(0).Item("OverJazb") + dt1.DefaultView.Item(0).Item("FoodFee") + dt1.DefaultView.Item(0).Item("SoldierFee") + dt1.DefaultView.Item(0).Item("MarriageFee") + dt1.DefaultView.Item(0).Item("HouseFee") + dt1.DefaultView.Item(0).Item("GradeFee") + dt1.DefaultView.Item(0).Item("UnderTestFee") + dt1.DefaultView.Item(0).Item("GroupFee") + dt1.DefaultView.Item(0).Item("janbazi") + dt1.DefaultView.Item(0).Item("MandegariFee") + dt1.DefaultView.Item(0).Item("TafavoteHoghogh")
                Call rptLoad()
            Catch ex As Exception

            End Try
        Else
            MsgBox("„Ã«“ »Â «‰Ã«„ «Ì‰ ⁄„· ‰„Ì »«‘Ìœ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
    End Sub

    Private Sub ç«ÅÕﬂ„ToolStripMenuItem_Click(ByVal e As System.EventArgs, ByVal sender As System.Object) Handles ç«ÅÕﬂ„ToolStripMenuItem.Click
        Dim dt1 As New DataTable
        If grdEmployee.GetValue("EngageTypeID") = 1 Or grdEmployee.GetValue("EngageTypeID") = 2 Or grdEmployee.GetValue("EngageTypeID") = 5 Or grdEmployee.GetValue("EngageTypeID") = 11 Then
            Try
                wstr = "select * from VwHR_RptHokmInfo where EmployeeCode = " & grdEmployee.GetValue("EmployeeCode") & " and PersonCode =  " & grdEmployee.GetValue("PersonCode") & " "
                rptReports = New rptHokm
                ReportName = "rptHokm"
                LastRepName = ReportName
                dt1 = Persist1.GetDataTable(ConString, wstr)
                SumAllSalary = dt1.DefaultView.Item(0).Item("Barjeste") + dt1.DefaultView.Item(0).Item("Differ") + dt1.DefaultView.Item(0).Item("Sanavat") + dt1.DefaultView.Item(0).Item("OverPost") + dt1.DefaultView.Item(0).Item("OverJazb") + dt1.DefaultView.Item(0).Item("FoodFee") + dt1.DefaultView.Item(0).Item("SoldierFee") + dt1.DefaultView.Item(0).Item("MarriageFee") + dt1.DefaultView.Item(0).Item("HouseFee") + dt1.DefaultView.Item(0).Item("GradeFee") + dt1.DefaultView.Item(0).Item("UnderTestFee") + dt1.DefaultView.Item(0).Item("GroupFee") + dt1.DefaultView.Item(0).Item("janbazi") + dt1.DefaultView.Item(0).Item("MandegariFee") + dt1.DefaultView.Item(0).Item("TafavoteHoghogh")
                Call rptLoad()
            Catch ex As Exception

            End Try
        Else
            MsgBox("„Ã«“ »Â «‰Ã«„ «Ì‰ ⁄„· ‰„Ì »«‘Ìœ", MsgBoxStyle.Information, "")
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
            f1.SumAllSalary = Decimal.Round(SumAllSalary)
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

    Private Sub btnGhararadadPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGhararadadPrint.Click

        Try
            wstr = "SELECT   *  FROM   VwHR_TreatyForLastTreaty WHERE  (PersonCode = " & grdEmployee.GetValue("PersonCode") & ") AND (EmployeeID = " & grdEmployee.GetValue("EmployeeID") & ")"
            ''''ﬁ—«—œ«œ Å—”‰· —”„Ì Ê ﬁ—«—œ«œÌ
            If grdEmployee.GetValue("EngageTypeID") = 2 Or grdEmployee.GetValue("EngageTypeID") = 5 Or grdEmployee.GetValue("EngageTypeID") = 11 Then
                Try
                    rptReports = New rptTreaty
                    LastRepName = ReportName
                    ReportName = "rptTreaty"
                    Call rptLoad()
                Catch ex As Exception
                End Try
                Exit Sub
                ''''ﬁ—«—œ«œ Å—”‰· —”„Ì Ê ﬁ—«—œ«œÌ
            ElseIf grdEmployee.GetValue("EngageTypeID") = 4 Then            ''—Ê“„“œ
                Try
                    rptReports = New rptDailyTreaty
                    LastRepName = ReportName
                    ReportName = "rptDailyTreaty"
                    Call rptLoad()
                Catch ex As Exception

                End Try
                Exit Sub
            ElseIf grdEmployee.GetValue("EngageTypeID") = 7 Then             ''„‘«Ê— Ì« ”«⁄ Ì
                Try
                    rptReports = New rptTimeTreaty
                    LastRepName = ReportName
                    ReportName = "rptTimeTreaty"
                    Call rptLoad()
                Catch ex As Exception
                End Try
                Exit Sub
            Else
                MsgBox("„Ã«“ »Â «‰Ã«„ «Ì‰ ⁄„· ‰„Ì »«‘Ìœ", MsgBoxStyle.Information, "")
                Exit Sub
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ç«Åﬁ—«—œ«œToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ç«Åﬁ—«—œ«œToolStripMenuItem.Click
        Try
            wstr = "SELECT   *  FROM   VwHR_TreatyForLastTreaty WHERE  (PersonCode = " & grdEmployee.GetValue("PersonCode") & ") AND (EmployeeID = " & grdEmployee.GetValue("EmployeeID") & ")"
            ''''ﬁ—«—œ«œ Å—”‰· —”„Ì Ê ﬁ—«—œ«œÌ
            If grdEmployee.GetValue("EngageTypeID") = 1 Or grdEmployee.GetValue("EngageTypeID") = 2 Or grdEmployee.GetValue("EngageTypeID") = 5 Or grdEmployee.GetValue("EngageTypeID") = 11 Then
                Try
                    rptReports = New rptTreaty
                    LastRepName = ReportName
                    ReportName = "rptTreaty"
                    Call rptLoad()
                Catch ex As Exception
                End Try
                Exit Sub
                ''''ﬁ—«—œ«œ Å—”‰· —”„Ì Ê ﬁ—«—œ«œÌ
            ElseIf grdEmployee.GetValue("EngageTypeID") = 4 Then            ''—Ê“„“œ
                Try
                    rptReports = New rptDailyTreaty
                    LastRepName = ReportName
                    ReportName = "rptDailyTreaty"
                    Call rptLoad()
                Catch ex As Exception

                End Try
                Exit Sub
            ElseIf grdEmployee.GetValue("EngageTypeID") = 7 Then             ''„‘«Ê— Ì« ”«⁄ Ì
                Try
                    rptReports = New rptTimeTreaty
                    LastRepName = ReportName
                    ReportName = "rptTimeTreaty"
                    Call rptLoad()
                Catch ex As Exception
                End Try
                Exit Sub
            Else
                MsgBox("„Ã«“ »Â «‰Ã«„ «Ì‰ ⁄„· ‰„Ì »«‘Ìœ", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDeletHokm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletHokm.Click
        Dim dt As New DataTable
        Dim Str As String
        Dim Bus_Employee1 As New Bus_Employee

        If MsgBox("¬Ì« «“ Õ–› «Ì‰ Õﬂ„ „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            ''''Õ–› Õﬂ„ €Ì— Ã«—Ì
            If grdEmployee.GetValue("EmployeeActive") = 0 Then
                Persist1.Sp_AddParam("@EmployeeID", SqlDbType.Int, grdEmployee.GetValue("EmployeeID"), ParameterDirection.Input)
                Persist1.Sp_Exe("Delete_tbHR_Employee", ConString, True)

                ''''Õ–› Õﬂ„ Ã«—Ì
            ElseIf grdEmployee.GetValue("EmployeeActive") = 1 Then
                ''''«» œ« Õﬂ„ —« Õ–› ‰„«Ìœ
                Persist1.Sp_AddParam("@EmployeeID", SqlDbType.Int, grdEmployee.GetValue("EmployeeID"), ParameterDirection.Input)
                Persist1.Sp_Exe("Delete_tbHR_Employee", ConString, True)

                ''''Õ«·« Õﬂ„ ﬁ»·Ì ›—œ —« Ã«—Ì ‰„«Ìœ
                Str = "SELECT MAX(EmployeeID) AS MAXEmployeeID  FROM dbo.tbHR_Employee WHERE (PersonCode = " & grdEmployee.GetValue("PersonCode") & ")"
                dt = Persist1.GetDataTable(ConString, Str)
                Bus_Employee1.updateEmployActive(dt.DefaultView.Item(0).Item("MAXEmployeeID"), 1)
            End If
            FillMyGridview()
            MsgBox("Õ–› ‘œ", MsgBoxStyle.Information, "")
        End If

    End Sub

 

 

    Private Sub mnudelHokm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnudelHokm.Click
        Dim dt As New DataTable
        Dim Str As String
        Dim Bus_Employee1 As New Bus_Employee

        If MsgBox("¬Ì« «“ Õ–› «Ì‰ Õﬂ„ „ÿ„∆‰ Â” Ìœø", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            ''''Õ–› Õﬂ„ €Ì— Ã«—Ì
            If grdEmployee.GetValue("EmployeeActive") = 0 Then
                Persist1.Sp_AddParam("@EmployeeID", SqlDbType.Int, grdEmployee.GetValue("EmployeeID"), ParameterDirection.Input)
                Persist1.Sp_Exe("Delete_tbHR_Employee", ConString, True)

                ''''Õ–› Õﬂ„ Ã«—Ì
            ElseIf grdEmployee.GetValue("EmployeeActive") = 1 Then
                ''''«» œ« Õﬂ„ —« Õ–› ‰„«Ìœ
                Persist1.Sp_AddParam("@EmployeeID", SqlDbType.Int, grdEmployee.GetValue("EmployeeID"), ParameterDirection.Input)
                Persist1.Sp_Exe("Delete_tbHR_Employee", ConString, True)
                ''''Õ«·« Õﬂ„ ﬁ»·Ì ›—œ —« Ã«—Ì ‰„«Ìœ
                Str = "SELECT MAX(EmployeeID) AS MAXEmployeeID  FROM dbo.tbHR_Employee WHERE (PersonCode = " & grdEmployee.GetValue("PersonCode") & ")"
                dt = Persist1.GetDataTable(ConString, Str)
                Bus_Employee1.updateEmployActive(dt.DefaultView.Item(0).Item("MAXEmployeeID"), 1)
            End If
            FillMyGridview()
            MsgBox("Õ–› ‘œ", MsgBoxStyle.Information, "")
        End If
    End Sub

    Private Sub savbegh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savbegh.Click
        Dim dt1 As New DataTable

        Try
            wstr = "select * from VwHR_Employee where  PersonCode =  " & grdEmployee.GetValue("PersonCode") & " "


            rptReports = New RptSavabeghHokm
            ReportName = "RptSavabeghHokm"
            LastRepName = ReportName
            dt1 = Persist1.GetDataTable(ConString, wstr)

            Call rptLoad()
        Catch ex As Exception

        End Try



    End Sub
End Class