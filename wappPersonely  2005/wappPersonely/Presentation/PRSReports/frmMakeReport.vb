
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frmMakeReport
    Dim b As New IKIDUtility.IKIDUtility.Formating
    Dim dt_ReportType As New DataTable
    Dim dt_DepartName As New DataTable
    Dim dt_PersonInDepart As New DataTable
    Dim Bus_Person1 As New Bus_Person
    Dim dtPerson As New DataTable
    Dim DA1 As New SqlClient.SqlDataAdapter
    Dim dt_Year, dt_Mounth As New DataTable
    Dim i As Integer
    Dim Bus_Parakanesh1 As New Bus_Parakanesh
    Dim frm As New frmStayParakanesh
    Dim logID_tmp As Integer

    Private Sub frmMakeReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        logID_tmp = LogID
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)

        If LogID = 0 Then
            MsgBox("شما به اين نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Me.Close()
            ''''معاونت مالي و اداري
        ElseIf Activity1.CheckUserAccess(54, 733, LogID) = True Then
            btnParakanesh.Visible = False
        End If
        FillmyCombo()
        FillgrdPerson()
        b.SetWlglobalForm(Me.BindingContext, ConString, dtPerson, grdPerson)
        ''''نظر سنجي

        'JGrade1.SetUserControl(LogID, 54, Me.Name, False)
        '''دسترسي حسابرس به گزارشات
       
        ''''
    End Sub

    Friend Sub FillmyCombo()
        dt_ReportType = Bus_Other1.GetReportType()
        Persist1.FillCmb(dt_ReportType, cmbReportType, "ReportCode", "ReportTitle")
        dt_Year = Bus_Other1.GetPeriod
        Persist1.FillCmb(dt_Year, cmbYear, "YearID", "YearID")
        dt_Mounth = Bus_Other1.GetMounthInfo
        Persist1.FillCmb(dt_Mounth, cmbMounth, "MonthID", "Mounthtxt")
        'dt_EngageType = Bus_Engage1.GetEngageTypeIfo
        'Persist1.FillCmb(dt_EngageType, cmbEngageType, "EngageTypeID", "EngageType")
    End Sub

    Friend Sub FillgrdPerson()
        Dim tbs1 As New DataGridTableStyle
        SqlStr = "SELECT * FROM VwHR_PersonMDepart_Report "
        dtPerson = Persist1.GetDataTable(ConString, SqlStr)
        grdSelect1.Add_ColDt(dtPerson)
        'Persist1.GetBindGrid_Dt(grdPerson, ConString, dtPerson)
        Persist1.GetBindGrid_Dt(grdPerson, ConString, dtPerson)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.BooleanTxt, dtPerson, grdPerson, "sel", "گزينش", 50, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "PersonCode", "كد پرسنلي", 55, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "FirstName", "نام", 70, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "LastName", "نام خانوادگي", 95, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "MDepartCode", "", 0, False, False)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "MDepartName", "نام واحد", 190, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "DepartID", "", 0, False, False)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "DepartCode", "", 0, False, False)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "DepartName", "نام اداره", 190, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "PostID", "", 0, False, False)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "PostCode", "", 0, False, False)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "Posttxt", "نام پست", 165, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "PostType", "نوع پست", 75, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "EngageTypeID", "", 0, False, False)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "EngageType", "نوع استخدام", 55, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "GroupID", "گروه", 40, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "DiplomaCode", "", 0, False, False)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "DiplomaName", "تحصيلات", 75, False, False)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "BranchTxt", "نوع تحصيلات", 75, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "AttitudeName", "گرايش", 75, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "SexID", "", 0, False, False)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "Sextxt", "جنسيت", 55, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "YearInIkid", "سابقه داخل شرکت", 100, True, True)
        Persist1.SetGridStyle_Dt(tbs1, Persistent.DataAccess.TxtBol.Text, dtPerson, grdPerson, "YearOutIkid", "سابقه خارج شرکت", 100, True, True)


    End Sub

    Private Sub btnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintReport.Click
        Dim dt As New DataTable
        '''' نمایش نمودار پرسنل شرکتی'''''

        If cmbReportType.SelectedValue = 134 Then
            Dim frm As New frmMainCalculate
            frm.ReqNum = cmbReportType.SelectedValue
            frm.ShowDialog()
        End If


        If cmbReportType.SelectedValue = 130 Then
            wstr = "SELECT     * " & _
                                "FROM         Vw_ChartPersonTafkik " & _
                                "WHERE (EngageTypeID =1 or EngageTypeID =2 or EngageTypeID =4 or EngageTypeID =5 or EngageTypeID =7 or EngageTypeID =11) "
            rptReports = New rptChartPersonTafkik
            LastRepName = ReportName
            ReportName = "rptChartPersonTafkik"


            '''''نمودار تحصیلات پرسنل شرکتی'''''
        ElseIf cmbReportType.SelectedValue = 131 Then

            wstr = "SELECT     * " & _
                                           "FROM         View_chart_diploma " & _
                                           "WHERE (EngageTypeID =1 or EngageTypeID =2 or EngageTypeID =4 or EngageTypeID =5 or EngageTypeID =7) "
            rptReports = New RptChartDiploma
            LastRepName = ReportName
            ReportName = "RptChartDiploma"

            '''''نمودار تعداد نفرات بر اساس پست زمانی'''''
        ElseIf cmbReportType.SelectedValue = 132 Then

            wstr = "SELECT     * " & _
                                           "FROM         View_chart_Post "
            rptReports = New RptChartPost
            LastRepName = ReportName
            ReportName = "RptChartPost"


        ElseIf cmbReportType.SelectedValue = 36 Then
            ''''افراد به تفكيك گروه شغلي
            wstr = "SELECT     * " & _
                    "FROM         VwHR_PersonInDepart " & _
                    "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & " ) order by PostCode "
            rptReports = New rptPersonAndGroup
            LastRepName = ReportName
            ReportName = "rptPersonAndGroup"
            ''''آمار تعداد نیروی انسانی
        ElseIf cmbReportType.SelectedValue = 92 Then

            wstr = _
                         "SELECT  * " & _
                         "FROM     VwHR_HooghooghMazaiaForReport " & _
                         "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New rptTedadniro
            LastRepName = ReportName
            ReportName = "rptTedadniro"

            ''''آمار میانگین سن -تجربه به تفکیک واحد
        ElseIf cmbReportType.SelectedValue = 91 Then

            wstr = "SELECT * FROM dbo.VwHR_PersonAge WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New rptPersonTajrobe
            LastRepName = ReportName
            ReportName = "rptPersonTajrobe"
            ''''افراد به تفكيك نوع پست
        ElseIf cmbReportType.SelectedValue = 37 Then

            wstr = _
                                         "SELECT     * " & _
                                             "FROM         VwHR_PersonInDepart " & _
                                              "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")order by PostCode"
            rptReports = New rptPersonAndPost
            LastRepName = ReportName
            ReportName = "rptPersonAndPost"

            ''''افراد به تفكيك نوع استخدام
        ElseIf cmbReportType.SelectedValue = 39 Then

            wstr = "SELECT     * " & _
                   "FROM         VwHR_PersonAndEngageType " & _
                   "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & " ) order by PostCode "
            rptReports = New rptPersonAndEngageType
            LastRepName = ReportName
            ReportName = "rptPersonAndEngageType"

            ''''عناوين شغل افراد به تفكيك واحد
        ElseIf cmbReportType.SelectedValue = 43 Then

            wstr = "SELECT     * " & _
                   "FROM         VwHR_PersonAndJobTitle " & _
                   "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & " )"
            rptReports = New rptPersonAndJobTitle
            LastRepName = ReportName
            ReportName = "rptPersonAndJobTitle"

            ''''فوق العاده جذب به ترتيب نزولي
        ElseIf cmbReportType.SelectedValue = 44 Then

            wstr = "SELECT     * " & _
                   "FROM         VwHR_PersonOverJazb " & _
                   "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & " ) order by overjazb desc "
            rptReports = New rptPersonOverJazb
            LastRepName = ReportName
            ReportName = "rptPersonOverJazb"

            ''''فوق العاده پست به ترتيب نزولي
        ElseIf cmbReportType.SelectedValue = 45 Then

            wstr = "SELECT     * " & _
                   "FROM         VwHR_PersonOverPost  " & _
                   "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & " ) order by overpost desc"
            rptReports = New rptPersonOverPost
            LastRepName = ReportName
            ReportName = "rptPersonOverPost"

            ''''آدرس و تلفن
        ElseIf cmbReportType.SelectedValue = 46 Then
            wstr = _
                                 "SELECT     * " & _
                                     "FROM         VwHR_PersonAddress " & _
                                      "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") "
            rptReports = New rptPersonAddress
            LastRepName = ReportName
            ReportName = "rptPersonAddress"

            ''''ليست افراد تحت تكفل
        ElseIf cmbReportType.SelectedValue = 49 Then
            wstr = _
                                 "SELECT     * " & _
                                     "FROM         VwHR_PersonFamily " & _
                                      "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") "
            rptReports = New rptPersonFamily
            LastRepName = ReportName
            ReportName = "rptPersonFamily"

            ''''سوابق استخدامي
        ElseIf cmbReportType.SelectedValue = 51 Then
            wstr = _
                                 "SELECT     * " & _
                                     "FROM         VwHR_Dossier " & _
                                      "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") "
            rptReports = New rptDossier
            LastRepName = ReportName
            ReportName = "rptDossier"

            ''''ليست تشويقات به تفكيك
        ElseIf cmbReportType.SelectedValue = 53 Then
            If txtBegindate.Text = "" Or txtUntilDate.Text = "" Or IraniDate1.TestDate(IraniDate1.Numericdate(txtBegindate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtUntilDate.Text)) = True Then
                MsgBox("تاريخ درست وارد نماييد", MsgBoxStyle.Information, "")
            End If
            wstr = _
                       "SELECT     * " & _
                         "FROM         VwHR_PersonMeed " & _
                          "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") AND (MeedDate BETWEEN '" & txtBegindate.Text & "' AND '" & txtUntilDate.Text & "')"
            rptReports = New rptPersonMeed

            LastRepName = ReportName
            ReportName = "rptPersonMeed"

            ''''خلاصه مشخصات پرسنلي
        ElseIf cmbReportType.SelectedValue = 54 Then
            wstr = _
                     "SELECT     * " & _
                     "FROM         VwHR_PersonProperty " & _
                     "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") "
            rptReports = New rptPersonPropertyAbstract
            LastRepName = ReportName
            ReportName = "rptPersonPropertyAbstract"

            ''''سوابق دوره هاي آموزشي
        ElseIf cmbReportType.SelectedValue = 55 Then
            wstr = _
                                 "SELECT     * " & _
                                     "FROM         VwHR_TrainingInfo " & _
                                      "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") "
            rptReports = New rptPersonAndTrinning
            LastRepName = ReportName
            ReportName = "rptPersonAndTrinning"

            ''''مدرك و محل تحصيل
        ElseIf cmbReportType.SelectedValue = 56 Then
            wstr = _
                                 "SELECT     * " & _
                                     "FROM         VwHR_EducationInfoForReport " & _
                                      "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") "
            rptReports = New rptPersonEducation
            LastRepName = ReportName
            ReportName = "rptPersonEducation"

            ''''مشخصات كلي از پرسنل
        ElseIf cmbReportType.SelectedValue = 57 Then
            wstr = _
                                 "SELECT     * " & _
                                     "FROM         VwHR_PersonPropertyForReport " & _
                                      "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") order by PostCode "
            rptReports = New rptPersonProperty
            LastRepName = ReportName
            ReportName = "rptPersonProperty"

            ''''سوابق دوره هاي آموزشي(مستعفي ها)
        ElseIf cmbReportType.SelectedValue = 58 Then
            wstr = "Select * From VwHR_MostaafiPersonAndTrinning"
            rptReports = New rptMostaafiPersonAndTrinning
            LastRepName = ReportName
            ReportName = "rptMostaafiPersonAndTrinning"

            ''''گزارش عناوين پست و ميانگين ارزيابي افراد
        ElseIf cmbReportType.SelectedValue = 69 Then
            wstr = _
                                 "SELECT     * " & _
                                     "FROM         VwHR_PersonValuation " & _
                                      "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") "
            rptReports = New rptPersonValuation
            LastRepName = ReportName
            ReportName = "rptPersonValuation"

            ''''ليست پرسنل استخدامي در زمان انتخابي
        ElseIf cmbReportType.SelectedValue = 71 Then
            If txtBegindate.Text = "" Or txtUntilDate.Text = "" Or IraniDate1.TestDate(IraniDate1.Numericdate(txtBegindate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtUntilDate.Text)) = True Then
                MsgBox("تاريخ درست وارد نماييد", MsgBoxStyle.Information, "")
                Exit Sub
            Else

                wstr = _
                "SELECT     PersonID, PersonCode, FirstName, LastName, EngageDate, DepartCode, DepartID, MDepartCode, MDepartName, PersonActive, CardNumber,  " & _
                "                      Posttxt " & _
                "FROM         VwHR_PersonListEstekhdamiBetweenDate " & _
                "WHERE     (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") AND (EngageDate BETWEEN '" & txtBegindate.Text & "' AND '" & txtUntilDate.Text & "')"
                rptReports = New rptPersoInDepartsBetWeenDate
                LastRepName = ReportName
                ReportName = "rptPersoInDepartsBetWeenDate"
            End If

            ''''فهرست اسامي پرسنل به تفكيك
        ElseIf cmbReportType.SelectedValue = 72 Then
            wstr = _
                                 "SELECT     * " & _
                                     "FROM         VwHR_PersonBeTafkikAlefba " & _
                                      "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") "
            rptReports = New rptPersonBeTafkikAlefba
            LastRepName = ReportName
            ReportName = "rptPersonBeTafkikAlefba"

            ''''فهرست كارتهاي ارائه شده به افراد به تفكيك واحد
        ElseIf cmbReportType.SelectedValue = 73 Then
            wstr = _
                                 "SELECT     * " & _
                                     "FROM         VwHR_PersonCard " & _
                                      "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") "
            rptReports = New rptPersonCard
            LastRepName = ReportName
            ReportName = "rptPersonCard"

            ''''عناوين پست افراد به تفكيك واحد(مديريت,اداره,قسمت,گروه)
        ElseIf cmbReportType.SelectedValue = 76 Then
            wstr = "SELECT * FROM dbo.VwHR_PostPersonINDepartForReport WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New rptPostPersonINDepart
            LastRepName = ReportName
            ReportName = "rptPostPersonINDepart"

            ''''ليست پرسنل مستعفي به تفكيك واحد
        ElseIf cmbReportType.SelectedValue = 78 Then
            wstr = "SELECT * FROM dbo.VwHR_MostafeePerson WHERE (DepartCode in " & grdSelect1.get_Collection_String(grdPerson, 4, dtPerson, 0) & ") and (EndDate BETWEEN '" & txtBegindate.Text.Trim & "' AND '" & txtUntilDate.Text.Trim & "')"
            rptReports = New rptMostafeePerson
            LastRepName = ReportName
            ReportName = "rptMostafeePerson"

            ''''وضعيت نيروي انساني شركت
        ElseIf cmbReportType.SelectedValue = 133 Then

            If cmbEngageType.Text = "شركتي" Then
                ''''نمايش شركتي ها

                wstr = _
                "SELECT     TOP (100) PERCENT dbo.tbHR_Parakanesh.ParakaneshID, dbo.tbHR_Parakanesh.DepartID, dbo.tbHR_Parakanesh.DepartCode,  " & _
                "                      dbo.tbHR_Parakanesh.SafSetadID, dbo.tbHR_Parakanesh.MDepartName, dbo.tbHR_Parakanesh.CountDoctoraSV,  " & _
                "                      dbo.tbHR_Parakanesh.CountFogLisancSV, dbo.tbHR_Parakanesh.CountLisancSV, dbo.tbHR_Parakanesh.CountFogDiplomSV,  " & _
                "                      dbo.tbHR_Parakanesh.CountDiplomSV, dbo.tbHR_Parakanesh.CountZirDiplomSV, dbo.tbHR_Parakanesh.CountDoctoraTV,  " & _
                "                      dbo.tbHR_Parakanesh.CountFogLisancTV, dbo.tbHR_Parakanesh.CountLisancTV, dbo.tbHR_Parakanesh.CountFogDiplomTV,  " & _
                "                      dbo.tbHR_Parakanesh.CountDiplomTV, dbo.tbHR_Parakanesh.CountZirDiplomTV, dbo.tbHR_Parakanesh.CountMan,  " & _
                "                      dbo.tbHR_Parakanesh.CountWoman, dbo.tbHR_Parakanesh.AvgDepartAge, dbo.tbHR_Parakanesh.CountPersonSafTafkik,  " & _
                "                      dbo.tbHR_Parakanesh.CountPersonSetadTafkik, dbo.tbHR_Parakanesh.ParakaneshYear, dbo.tbHR_Parakanesh.ParakaneshMounth,  " & _
                "                      dbo.tbHR_Parakanesh.CountPersonTV, dbo.tbHR_Parakanesh.CountPersonSV, dbo.tbHR_Parakanesh.EngageType,  " & _
                "                      dbo.tbHR_ParakaneshAgeDiplom.Saf, dbo.tbHR_ParakaneshAgeDiplom.Setad, dbo.tbHR_ParakaneshAgeDiplom.ZirDiplom,  " & _
                "                      dbo.tbHR_ParakaneshAgeDiplom.ZirDiplomHour, dbo.tbHR_ParakaneshAgeDiplom.Diplom, dbo.tbHR_ParakaneshAgeDiplom.DiplomHour,  " & _
                "                      dbo.tbHR_ParakaneshAgeDiplom.FogDiplom, dbo.tbHR_ParakaneshAgeDiplom.FogDiplomHour, dbo.tbHR_ParakaneshAgeDiplom.Lisans,  " & _
                "                      dbo.tbHR_ParakaneshAgeDiplom.LisansHour, dbo.tbHR_ParakaneshAgeDiplom.FogLisans, dbo.tbHR_ParakaneshAgeDiplom.FogLisansHour,  " & _
                "                      dbo.tbHR_ParakaneshAgeDiplom.Doctra, dbo.tbHR_ParakaneshAgeDiplom.DoctraHour, dbo.tbHR_ParakaneshAgeDiplom.Man,  " & _
                "                      dbo.tbHR_ParakaneshAgeDiplom.Women " & _
                " FROM         tbHR_Parakanesh LEFT OUTER JOIN  tbHR_ParakaneshAgeDiplom ON tbHR_Parakanesh.EngageType = tbHR_ParakaneshAgeDiplom.EngageType AND  " & _
                " tbHR_Parakanesh.ParakaneshYear = tbHR_ParakaneshAgeDiplom.Year AND  tbHR_Parakanesh.ParakaneshMounth = tbHR_ParakaneshAgeDiplom.Month " & _
                " WHERE     (dbo.tbHR_Parakanesh.DepartCode IN " & grdSelect1.get_Collection_String(grdPerson, 4, dtPerson, 0) & ") AND (dbo.tbHR_Parakanesh.ParakaneshYear =  " & cmbYear.SelectedValue & ") AND   (dbo.tbHR_Parakanesh.ParakaneshMounth = " & cmbMounth.SelectedValue & ") AND (dbo.tbHR_Parakanesh.EngageType = 1) ORDER BY dbo.tbHR_Parakanesh.DepartCode "


                '   wstr = "SELECT * FROM tbHR_Parakanesh WHERE  (DepartCode  in " & grdSelect1.get_Collection_String(grdPerson, 4, dtPerson, 0) & ")AND (ParakaneshYear = " & cmbYear.SelectedValue & ") AND (ParakaneshMounth = " & cmbMounth.SelectedValue & ")AND (EngageType = 1)  ORDER BY DepartCode"
            Else
                ''''نمايش خدماتي ها
                wstr = _
                            "SELECT     TOP (100) PERCENT dbo.tbHR_Parakanesh.ParakaneshID, dbo.tbHR_Parakanesh.DepartID, dbo.tbHR_Parakanesh.DepartCode,  " & _
                            "                      dbo.tbHR_Parakanesh.SafSetadID, dbo.tbHR_Parakanesh.MDepartName, dbo.tbHR_Parakanesh.CountDoctoraSV,  " & _
                            "                      dbo.tbHR_Parakanesh.CountFogLisancSV, dbo.tbHR_Parakanesh.CountLisancSV, dbo.tbHR_Parakanesh.CountFogDiplomSV,  " & _
                            "                      dbo.tbHR_Parakanesh.CountDiplomSV, dbo.tbHR_Parakanesh.CountZirDiplomSV, dbo.tbHR_Parakanesh.CountDoctoraTV,  " & _
                            "                      dbo.tbHR_Parakanesh.CountFogLisancTV, dbo.tbHR_Parakanesh.CountLisancTV, dbo.tbHR_Parakanesh.CountFogDiplomTV,  " & _
                            "                      dbo.tbHR_Parakanesh.CountDiplomTV, dbo.tbHR_Parakanesh.CountZirDiplomTV, dbo.tbHR_Parakanesh.CountMan,  " & _
                            "                      dbo.tbHR_Parakanesh.CountWoman, dbo.tbHR_Parakanesh.AvgDepartAge, dbo.tbHR_Parakanesh.CountPersonSafTafkik,  " & _
                            "                      dbo.tbHR_Parakanesh.CountPersonSetadTafkik, dbo.tbHR_Parakanesh.ParakaneshYear, dbo.tbHR_Parakanesh.ParakaneshMounth,  " & _
                            "                      dbo.tbHR_Parakanesh.CountPersonTV, dbo.tbHR_Parakanesh.CountPersonSV, dbo.tbHR_Parakanesh.EngageType,  " & _
                            "                      dbo.tbHR_ParakaneshAgeDiplom.Saf, dbo.tbHR_ParakaneshAgeDiplom.Setad, dbo.tbHR_ParakaneshAgeDiplom.ZirDiplom,  " & _
                            "                      dbo.tbHR_ParakaneshAgeDiplom.ZirDiplomHour, dbo.tbHR_ParakaneshAgeDiplom.Diplom, dbo.tbHR_ParakaneshAgeDiplom.DiplomHour,  " & _
                            "                      dbo.tbHR_ParakaneshAgeDiplom.FogDiplom, dbo.tbHR_ParakaneshAgeDiplom.FogDiplomHour, dbo.tbHR_ParakaneshAgeDiplom.Lisans,  " & _
                            "                      dbo.tbHR_ParakaneshAgeDiplom.LisansHour, dbo.tbHR_ParakaneshAgeDiplom.FogLisans, dbo.tbHR_ParakaneshAgeDiplom.FogLisansHour,  " & _
                            "                      dbo.tbHR_ParakaneshAgeDiplom.Doctra, dbo.tbHR_ParakaneshAgeDiplom.DoctraHour, dbo.tbHR_ParakaneshAgeDiplom.Man,  " & _
                            "                      dbo.tbHR_ParakaneshAgeDiplom.Women " & _
                            " FROM         tbHR_Parakanesh LEFT OUTER JOIN  tbHR_ParakaneshAgeDiplom ON tbHR_Parakanesh.EngageType = tbHR_ParakaneshAgeDiplom.EngageType AND  " & _
                            " tbHR_Parakanesh.ParakaneshYear = tbHR_ParakaneshAgeDiplom.Year AND  tbHR_Parakanesh.ParakaneshMounth = tbHR_ParakaneshAgeDiplom.Month " & _
                            " WHERE     (dbo.tbHR_Parakanesh.DepartCode IN " & grdSelect1.get_Collection_String(grdPerson, 4, dtPerson, 0) & ") AND (dbo.tbHR_Parakanesh.ParakaneshYear =  " & cmbYear.SelectedValue & ") AND   (dbo.tbHR_Parakanesh.ParakaneshMounth = " & cmbMounth.SelectedValue & ") AND (dbo.tbHR_Parakanesh.EngageType = 2) ORDER BY dbo.tbHR_Parakanesh.DepartCode "

            End If
            rptReports = New rptParakanesh
            LastRepName = ReportName
            ReportName = "rptParakanesh"

            ''''ليست كارشناسان به تفكيك گروه
        ElseIf cmbReportType.SelectedValue = 93 Then
            wstr = " SELECT * FROM dbo.VwHR_ExpertsAndGroup WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New rptExpertsAndGroup
            LastRepName = ReportName
            ReportName = "rptExpertsAndGroup"

            ''''ليست دوره هاي گذرانده شده توسط پرسنل
        ElseIf cmbReportType.SelectedValue = 98 Then
            wstr = "SELECT * FROM dbo.VwHR_PersonAndTrinningForReport WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New rptPersonAndTrinningBeTafkik
            LastRepName = ReportName
            ReportName = "rptPersonAndTrinningBeTafkik"

            ''''ليست سن افراد
        ElseIf cmbReportType.SelectedValue = 106 Then
            wstr = "SELECT * FROM dbo.VwHR_PersonAge WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New rptPersonAGE
            LastRepName = ReportName
            ReportName = "rptPersonAGE"

            ''''ليست ميزان سوابق پرسنل به تفكيك واحد
        ElseIf cmbReportType.SelectedValue = 107 Then
            wstr = _
                         "SELECT     * " & _
                         "FROM         VwHR_DossierForReport " & _
                         "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New rptDossierTefkik
            LastRepName = ReportName
            ReportName = "rptDossierTefkik"

            ''''نرخ هر ساعت اضافه كاري واحد
        ElseIf cmbReportType.SelectedValue = 113 Then
            wstr = _
                        "SELECT  * " & _
                        "FROM     VwHR_EzafehKariVahed " & _
                        "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New rptEzafehKariFee
            LastRepName = ReportName
            ReportName = "rptEzafehKariFee"

            ''''ليست حقوق و مزاياي پرسنل بر اساس واحد
        ElseIf cmbReportType.SelectedValue = 116 Then
            wstr = _
                        "SELECT  * " & _
                        "FROM     VwHR_HooghooghMazaiaForReport " & _
                        "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New rptHoghooghvaMazaiatafkikVahed
            LastRepName = ReportName
            ReportName = "rptHoghooghvaMazaiatafkikVahed"

            ''''گزارش مشخصات نيروي انساني داراي تحصيلات دانشگاهي
        ElseIf cmbReportType.SelectedValue = 122 Then
            wstr = "Select * From VwHR_SazehGostarForReport where (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New rptSazehGostar
            LastRepName = ReportName
            ReportName = "rptSazehGostar"

            ''''گزارش طبقه بندي
        ElseIf cmbReportType.SelectedValue = 124 Then
            wstr = _
                        "SELECT  * " & _
                        "FROM     VwHR_HooghooghMazaiaForReport " & _
                        "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New rptTabaghehBandi
            LastRepName = ReportName
            ReportName = "rptTabaghehBandi"

            ''''گزارش جابجايي برون واحدي
        ElseIf cmbReportType.SelectedValue = 126 Then
            If txtBegindate.Text = "" Or txtUntilDate.Text = "" Or IraniDate1.TestDate(IraniDate1.Numericdate(txtBegindate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtUntilDate.Text)) = True Then
                MsgBox("تاريخ درست وارد نماييد", MsgBoxStyle.Information, "")
                Exit Sub
            Else
                wstr = _
                         "SELECT     * " & _
                         "FROM         VwHR_MovingPersonForReport " & _
                         "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") and (EmployeeTypeID = 4) and (EmissionDate BETWEEN '" & txtBegindate.Text & "' AND '" & txtUntilDate.Text & "')"
                rptReports = New rptMovingPerson
                LastRepName = ReportName
                ReportName = "rptMovingPerson"
            End If

            ''''گزارش جابجايي درون واحدي
        ElseIf cmbReportType.SelectedValue = 127 Then

            If txtBegindate.Text = "" Or txtUntilDate.Text = "" Or IraniDate1.TestDate(IraniDate1.Numericdate(txtBegindate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtUntilDate.Text)) = True Then
                MsgBox("تاريخ درست وارد نماييد", MsgBoxStyle.Information, "")
                Exit Sub
            Else
                wstr = _
                         "SELECT     * " & _
                         "FROM         VwHR_MovingPersonForReport " & _
                         "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ") and (EmployeeTypeID = 34) and (EmissionDate BETWEEN '" & txtBegindate.Text & "' AND '" & txtUntilDate.Text & "')"
                rptReports = New rptMovingPerson
                LastRepName = ReportName
                ReportName = "rptMovingPerson"
            End If

            ''''گزارش تغییر پست فرشاد
        ElseIf cmbReportType.SelectedValue = 138 Then

            If txtBegindate.Text = "" Or txtUntilDate.Text = "" Or IraniDate1.TestDate(IraniDate1.Numericdate(txtBegindate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtUntilDate.Text)) = True Then
                MsgBox("تاريخ درست وارد نماييد", MsgBoxStyle.Information, "")
                Exit Sub
            Else
                wstr = _
                         "SELECT     * " & _
                         "FROM         View_PersonBimeMashagel " & _
                         "WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")  and (ExecDate BETWEEN '" & txtBegindate.Text & "' AND '" & txtUntilDate.Text & "')"
                rptReports = New rptPersonBime
                LastRepName = ReportName
                ReportName = "rptPersonBime"
            End If

        ElseIf cmbReportType.SelectedValue = 95 Then
            'لیست حقوق ثابت ، فوق العاده پست و گروه شغلی 
            wstr = "select * from Wv_rpt_hoghoogh where (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"

            rptReports = New RptHoghoogh

            LastRepName = ReportName
            ReportName = "RptHoghoogh"

            ''''گزارش تعداد رتبه پرسنل به تفكيك واحد
        ElseIf cmbReportType.SelectedValue = 128 Then
            wstr = "SELECT * FROM  VwHR_PersonGradeCount WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New rptPersonGradeCount
            LastRepName = ReportName
            ReportName = "rptPersonGradeCount"

            ''''گزارش آموزش شعشعاني
        ElseIf cmbReportType.SelectedValue = 135 Then
            wstr = "SELECT * FROM  VwHR_PersonGradeCount WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            rptReports = New RptPersonCourse
            LastRepName = ReportName
            ReportName = "RptPersonCourse"

            '''''گزارش جذب و جابجایی و خروج

        ElseIf cmbReportType.SelectedValue = 137 Then
            Dim dt_pr As New DataTable
            Dim dt_Jab As New DataTable
            Dim dt_Jab_Temp As New DataTable
            Dim mdep_f, mdep_l As String
            Dim k As Integer
            Dim execDate As String
            SqlStr = "Delete tb_Jabejaie_Temp Where ComputerName='" & SystemInformation.ComputerName & "'"
            Persist1.GetDataAccess(SqlStr, 2, ConString)


            SqlStr = "SELECT        dbo.tbHR_Employee.Active, dbo.tbHR_Person.PersonCode  FROM            dbo.tbHR_Person INNER JOIN       dbo.tbHR_Employee ON dbo.tbHR_Person.PersonID = dbo.tbHR_Employee.PersonID       WHERE   (dbo.tbHR_Employee.Active = 1)"


            dt_pr = Persist1.GetDataTable(ConString, SqlStr)

            For i = 0 To dt_pr.DefaultView.Count - 1
                

                SqlStr = " SELECT     DepartName, PersonCode, EmissionDate, MDepartCode, EndDate FROM            dbo.Vw_Jabejaie_List WHERE        (PersonCode = " & dt_pr.DefaultView.Item(i).Item("PersonCode") & ") ORDER BY EmissionDate"

                dt_Jab = Persist1.GetDataTable(ConString, SqlStr)

                mdep_f = dt_Jab.DefaultView.Item(0).Item("MDepartCode")


                For k = 0 To dt_Jab.DefaultView.Count - 1

                    If mdep_f <> dt_Jab.DefaultView.Item(k).Item("MDepartCode") Then
                        SqlStr = "Insert into tb_Jabejaie_Temp ([MDepartCode],[IN_OUT],[PersonCode],[ComputerName],[Year]) values ('" & dt_Jab.DefaultView.Item(k - 1).Item("MDepartCode") & "','OUT'," & dt_Jab.DefaultView.Item(k - 1).Item("PersonCode") & ",'" & SystemInformation.ComputerName & "','" & Mid(dt_Jab.DefaultView.Item(k).Item("EmissionDate"), 1, 4) & "')"
                        Persist1.GetDataAccess(SqlStr, 2, ConString)

                        SqlStr = "Insert into tb_Jabejaie_Temp ([MDepartCode],[IN_OUT],[PersonCode],[ComputerName],[Year]) values ('" & dt_Jab.DefaultView.Item(k).Item("MDepartCode") & "','IN'," & dt_Jab.DefaultView.Item(k).Item("PersonCode") & ", '" & SystemInformation.ComputerName & "','" & Mid(dt_Jab.DefaultView.Item(k).Item("EmissionDate"), 1, 4) & "')"
                        Persist1.GetDataAccess(SqlStr, 2, ConString)

                    End If



                    mdep_f = dt_Jab.DefaultView.Item(k).Item("MDepartCode")


                Next
            Next







            wstr = "  SELECT     tbHR_Depart_1.DepartName, COUNT(dbo.tbHR_Employee.EmployeeID) AS Cnt , SUBSTRING(dbo.tbHR_Employee.EngageDate, 1, 4) AS TypeYear,                        'جذب' AS Type  FROM         dbo.tbHR_Employee INNER JOIN                       Is_ADM.dbo.VwHR_MaxEmployeeID ON dbo.tbHR_Employee.EmployeeID = Is_ADM.dbo.VwHR_MaxEmployeeID.MaxEmployeeID INNER JOIN                       dbo.tbHR_Person ON dbo.tbHR_Employee.PersonID = dbo.tbHR_Person.PersonID INNER JOIN                       dbo.tbHR_Post ON dbo.tbHR_Employee.PostID = dbo.tbHR_Post.PostID INNER JOIN                       dbo.tbHR_Depart ON dbo.tbHR_Post.DepartID = dbo.tbHR_Depart.DepartID INNER JOIN                       dbo.tbHR_Depart AS tbHR_Depart_1 ON dbo.tbHR_Depart.MDepartCode = tbHR_Depart_1.DepartCode INNER JOIN                       dbo.tbHR_DepartType ON dbo.tbHR_Depart.DepartTypeID = dbo.tbHR_DepartType.DepartTypeID GROUP BY tbHR_Depart_1.DepartName, SUBSTRING(dbo.tbHR_Employee.EngageDate, 1, 4)  " & _
                        "union " & _
                        "SELECT     tbHR_Depart_1.DepartName, COUNT(dbo.tbHR_Employee.EmployeeID) AS cnt, SUBSTRING(dbo.tbHR_Employee.ExecDate, 1, 4) AS Year,  " & _
                        "                      'مستعفی' AS Mos " & _
                        "FROM         dbo.tbHR_Employee INNER JOIN " & _
                        "                      Is_ADM.dbo.VwHR_MaxEmployeeID ON dbo.tbHR_Employee.EmployeeID = Is_ADM.dbo.VwHR_MaxEmployeeID.MaxEmployeeID INNER JOIN " & _
                        "                      dbo.tbHR_Person ON dbo.tbHR_Employee.PersonID = dbo.tbHR_Person.PersonID INNER JOIN " & _
                        "                      dbo.tbHR_Post ON dbo.tbHR_Employee.PostID = dbo.tbHR_Post.PostID INNER JOIN " & _
                        "                      dbo.tbHR_Depart ON dbo.tbHR_Post.DepartID = dbo.tbHR_Depart.DepartID INNER JOIN " & _
                        "                      dbo.tbHR_Depart AS tbHR_Depart_1 ON dbo.tbHR_Depart.MDepartCode = tbHR_Depart_1.DepartCode INNER JOIN " & _
                        "                      dbo.tbHR_DepartType ON dbo.tbHR_Depart.DepartTypeID = dbo.tbHR_DepartType.DepartTypeID " & _
                        "WHERE     (dbo.tbHR_Person.EngageDate >= '1111/01/01') AND (dbo.tbHR_Person.EngageDate <= '1396/12/29') AND  " & _
                        "                      (dbo.tbHR_Employee.EmployTypeID = 16 OR " & _
                        "                      dbo.tbHR_Employee.EmployTypeID = 37 OR " & _
                        "                      dbo.tbHR_Employee.EmployTypeID = 38 OR " & _
                        "                      dbo.tbHR_Employee.EmployTypeID = 18 OR " & _
                        "                      dbo.tbHR_Employee.EmployTypeID = 39 OR " & _
                        "                      dbo.tbHR_Employee.EmployTypeID = 40 OR " & _
                        "                      dbo.tbHR_Employee.EmployTypeID = 41 OR dbo.tbHR_Employee.EmployTypeID = 58)   " & _
                        "GROUP BY tbHR_Depart_1.DepartName, SUBSTRING(dbo.tbHR_Employee.ExecDate, 1, 4) " & _
                        " Union " & _
                        " SELECT         tbHR_Depart.DepartName, COUNT(tb_Jabejaie_Temp.IN_OUT) AS cnt, tb_Jabejaie_Temp.Year, 'واده' AS JabM " & _
                        "  FROM            tb_Jabejaie_Temp INNER JOIN   tbHR_Depart ON tb_Jabejaie_Temp.MDepartCode = tbHR_Depart.DepartCode " & _
                        " WHERE       (tb_Jabejaie_Temp.IN_OUT = N'IN') AND   (tb_Jabejaie_Temp.ComputerName = N'" & SystemInformation.ComputerName & "') GROUP BY tbHR_Depart.DepartName, tb_Jabejaie_Temp.Year " & _
                          " Union " & _
                        " SELECT        tbHR_Depart.DepartName, COUNT(tb_Jabejaie_Temp.IN_OUT) AS cnt, tb_Jabejaie_Temp.Year, 'خارجه' AS JabM " & _
                        "  FROM            tb_Jabejaie_Temp INNER JOIN   tbHR_Depart ON tb_Jabejaie_Temp.MDepartCode = tbHR_Depart.DepartCode " & _
                        " WHERE       (tb_Jabejaie_Temp.IN_OUT = N'OUT') AND   (tb_Jabejaie_Temp.ComputerName = N'" & SystemInformation.ComputerName & "') GROUP BY tbHR_Depart.DepartName, tb_Jabejaie_Temp.Year "
            rptReports = New Rpt_JazbMosJab
            LastRepName = ReportName
            ReportName = "Rpt_JazbMosJab"

            Call rptLoad()
            wstr = _
            "SELECT         dbo.tb_Jabejaie_Temp.id, dbo.tb_Jabejaie_Temp.MDepartCode, dbo.tb_Jabejaie_Temp.IN_OUT, dbo.tb_Jabejaie_Temp.PersonCode,  " & _
            "                         dbo.tb_Jabejaie_Temp.ComputerName, dbo.tb_Jabejaie_Temp.Year, dbo.tbHR_Person.FirstName, dbo.tbHR_Person.LastName, dbo.tbHR_Depart.DepartName " & _
            "FROM            dbo.tb_Jabejaie_Temp INNER JOIN " & _
            "                         dbo.tbHR_Person ON dbo.tb_Jabejaie_Temp.PersonCode = dbo.tbHR_Person.PersonCode INNER JOIN " & _
            "                         dbo.tbHR_Depart ON dbo.tb_Jabejaie_Temp.MDepartCode = dbo.tbHR_Depart.DepartCode " & _
            "WHERE        (dbo.tb_Jabejaie_Temp.ComputerName = N'" & SystemInformation.ComputerName & "')"

            rptReports = New Crtjabejaie_Detail
            LastRepName = ReportName
            ReportName = "Crtjabejaie_Detail"



            ''''ليست تردد پرسنل خدماتي
        ElseIf cmbReportType.SelectedValue = 129 Then
            wstr = "SELECT  CardNumber, PersonCode FROM tbHR_Card WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"
            Dim dt_Temp As New DataTable
            dt_Temp = Persist1.GetDataTable(ConString, wstr)
            If dt_Temp.Rows.Count = 0 Then
                MsgBox("فردي را انتخاب ننموده ايد يا شخصي داراي اين شرايط نمي باشد", MsgBoxStyle.Information, "")
            Else
                For i = 0 To dt_Temp.Rows.Count - 1
                    Persist1.Sp_AddParam("@CardNumber_1", SqlDbType.Int, dt_Temp.DefaultView.Item(i).Item("CardNumber"), ParameterDirection.Input)
                    Persist1.Sp_Exe("insert_tempTb_Rep", ConString, True)
                Next
            End If

            wstr = "Select * from FuncAmalkard_PRSKhadamati ('" & Mid(txtBegindate.Text, 3) & "','" & Mid(txtUntilDate.Text, 3) & "')"

            rptReports = New rptPersonKhadamati
            LastRepName = ReportName
            ReportName = "rptPersonKhadamati"

        ElseIf cmbReportType.SelectedValue = 136 Then

            If txtBegindate.Text = "" Or txtUntilDate.Text = "" Or IraniDate1.TestDate(IraniDate1.Numericdate(txtBegindate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtUntilDate.Text)) = True Then
                MsgBox("تاريخ درست وارد نماييد", MsgBoxStyle.Information, "")
                Exit Sub
            Else
                wstr = _
                "SELECT     fn_Bazneshaste_List_1.*, " & _
                "      (SELECT     CASE WHEN age >= 50 AND cnt >= 30 THEN 'بازنشسته' ELSE " & _
                "                                                       (SELECT     CASE WHEN age < 50 AND cnt >= 35 THEN 'بازنشسته' ELSE 'عدم بازنشستگي' END) END AS Expr1) AS  Bazneshaste " & _
                "FROM          dbo.fn_Bazneshaste_List('" & txtUntilDate.Text & "') AS fn_Bazneshaste_List_1 " & _
                " WHERE   ((SELECT     CASE WHEN age >= 50 AND cnt >= 30 THEN 'بازنشسته' ELSE     (SELECT     CASE WHEN age < 50 AND cnt >= 35 THEN 'بازنشسته' ELSE 'عدم بازنشستگي' END) END AS Expr1) = 'بازنشسته') AND (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"


                rptReports = New Rpt_TabagheMashaghel_bazneshastegi
                LastRepName = ReportName
                ReportName = "Rpt_TabagheMashaghel_bazneshastegi.rpt"
                rptReports.setparametervalue("CurDate", IraniDate1.GetIraniFullDateTime_CurDate)
                rptReports.setparametervalue("ToDate", txtUntilDate.Text)
                Call rptLoad()
                Exit Sub
                'End Select
            End If
        End If





        ''''جهت تست اينكه فردي را انتخاب نموده يا خير
        If cmbReportType.SelectedValue <> 129 Then
            If wstr = "" Then
                Exit Sub
            Else
                dt = Persist1.GetDataTable(ConString, wstr)
            End If

            If dt.Rows.Count = 0 Then
                MsgBox("فردي را انتخاب ننموده ايد يا شخصي داراي اين شرايط نمي باشد", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        End If
        Call rptLoad()
        ''''جهت پاك نمودن اطلاعات موجود در جدول temp مربوط به گزارش ليست تردد پرسنل خدماتي
        Dim cnn As New SqlConnection
        Dim cmd As New SqlCommand
        cnn.ConnectionString = ConString
        cmd.CommandText = "Delete  _tempTb_Rep"
        cmd.Connection = cnn
        cnn.Open()
        cmd.ExecuteNonQuery()
        cnn.Close()
        '''''''''*****''''''
    End Sub

    Private Sub rptLoad()
        Try
            If dsReports.Tables.Count > 0 Then
                dsReports.Tables(LastRepName).Clear()
            End If
            DA1 = Persist1.GetDataAccess(wstr, 1, ConString, ReportName, dsReports)
            Dim f1 As New frmReport
            If cmbReportType.SelectedValue = 127 Then
                f1.MoveType = "درون واحدي"
                f1.BeginDate = txtBegindate.Text
                f1.EndDate = txtUntilDate.Text

            ElseIf cmbReportType.SelectedValue = 53 Then
                f1.BeginDate = txtBegindate.Text
                f1.EndDate = txtUntilDate.Text
            ElseIf cmbReportType.SelectedValue = 127 Then
                f1.MoveType = "درون واحدي"
                f1.BeginDate = txtBegindate.Text
                f1.EndDate = txtUntilDate.Text
            ElseIf cmbReportType.SelectedValue = 129 Then
                f1.BeginDate = txtBegindate.Text
                f1.EndDate = txtUntilDate.Text
            ElseIf cmbReportType.SelectedValue = 138 Then
                f1.BeginDate = txtBegindate.Text
                f1.EndDate = txtUntilDate.Text
            ElseIf cmbReportType.SelectedValue = 136 Then
                f1.BeginDate = txtBegindate.Text
                f1.EndDate = txtUntilDate.Text
            ElseIf cmbReportType.SelectedValue = 133 Then
                f1.MounthName = cmbMounth.Text
                f1.year = cmbYear.SelectedValue
                If cmbEngageType.Text = "شركتي" Then
                    f1.EngageType = "رسمي و قراردادي"
                Else
                    f1.EngageType = "خدماتي"
                End If
            End If
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

    Private Sub cmbReportType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbReportType.SelectedValueChanged
        ''فعال كردن محدوده زماني براي گزارشاتي كه به محدوده زماني نيازدارند
        Try
            If cmbReportType.SelectedValue = 126 Or cmbReportType.SelectedValue = 136 Or cmbReportType.SelectedValue = 138 Or cmbReportType.SelectedValue = 129 Or cmbReportType.SelectedValue = 127 Or cmbReportType.SelectedValue = 71 Or cmbReportType.SelectedValue = 78 Or cmbReportType.SelectedValue = 53 Then
                grpBetWeenDate.Enabled = True
            Else
                grpBetWeenDate.Enabled = False
            End If

            If cmbReportType.SelectedValue = 129 Then
                btnExportToExcell.Visible = True
            Else
                btnExportToExcell.Visible = False
            End If

            If cmbReportType.SelectedValue = 133 Then
                grpParakanesh.Visible = True
            Else
                grpParakanesh.Visible = False
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub grdPerson_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPerson.Click
        grdSelect1.Grid_State(grdPerson, 0)
        DgSelect2.DG = grdPerson
        DgSelect2.DT = dtPerson
    End Sub

    Private Sub DgSelect2_WlEvent(ByVal sender As Object, ByVal e As IKIDUtility.DgSelect.MyEventArgs) Handles DgSelect2.WlEvent
        grdSelect1.Grid_State(grdPerson, 20)
        DgSelect2.DG = grdPerson
        DgSelect2.DT = dtPerson
    End Sub

    Private Sub Parakanesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParakanesh.Click
        Dim dt_Parakanesh As New DataTable
        Dim dt_CountPerson As New DataTable
        Dim dt_CountMan, dt_CountWoman, dt_AvgPersonAge As New DataTable
        Dim sstr As String
        Dim dt_CountPersonSetadTafkik, dt_CountPersonSafTafkik As New DataTable
        Dim dt_Control As New DataTable
        sstr = ""
        If cmbEngageType.Text = "شركتي" Then
            sstr = "SELECT ParakaneshID,ParakaneshYear, ParakaneshMounth FROM tbHR_Parakanesh WHERE (ParakaneshYear = " & cmbYear.SelectedValue & ") AND (ParakaneshMounth = " & cmbMounth.SelectedValue & ") AND (EngageType = 1)"
        Else
            sstr = "SELECT ParakaneshID,ParakaneshYear, ParakaneshMounth FROM tbHR_Parakanesh WHERE (ParakaneshYear = " & cmbYear.SelectedValue & ") AND (ParakaneshMounth = " & cmbMounth.SelectedValue & ") AND (EngageType = 2)"
        End If
        dt_Control = Persist1.GetDataTable(ConString, sstr)
        If dt_Control.Rows.Count <> 0 Then
            If MsgBox("مجاز به انجام اين عمل نمي باشيد . قبلا اين پراكنش را محاسبه نموده ايد", MsgBoxStyle.Information, "") Then
                Exit Sub
            End If
            ''''محاسبه ابتدايي پراكنش
        ElseIf dt_Control.Rows.Count = 0 Then
            If cmbYear.SelectedValue <> IraniDate1.GetIraniYear_CurDate Then
                If MsgBox("سال انتخاب شده با سال جاري متفاوت مي باشد . آيا از محاسبه پراكنش در سال انتخابي مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            If cmbMounth.SelectedValue <> IraniDate1.GetIraniMonthNum_CurDate Then
                If MsgBox("ماه انتخاب شده با ماه جاري متفاوت مي باشد . آيا از محاسبه پراكنش در ماه انتخابي مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            If MsgBox("آيا از محاسبه پراكنش مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            Else
                ''''تمامي محاسبات محاسبه پراكنش به frmStayمنتقل شد 
                frm.Year = cmbYear.SelectedValue
                frm.Mounth = cmbMounth.SelectedValue
                If cmbEngageType.Text = "شركتي" Then
                    ''''جهت محاسبه پرسنل قراردادي و رسمي و ساعتي و ازمايشي  
                    frm.EngageType = 1
                Else
                    ''''جهت محاسبه پرسنل خدماتي و جايگزين مرخصي 
                    frm.EngageType = 2
                End If
                frm.ShowDialog()
            End If
            MsgBox("محاسبه پراكنش با موفقيت انجام شد", MsgBoxStyle.Information, "")
            End If
    End Sub

    Private Sub btnExportToExcell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportToExcell.Click
        Dim dt_Temp, dt_Export As New DataTable
        Dim cnn As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            ''''جهت پاك نمودن اطلاعات موجود در جدول temp مربوط به گزارش ليست تردد پرسنل خدماتي
            cnn.ConnectionString = ConString
            cmd.CommandText = "Delete  _tempTb_Rep"
            cmd.Connection = cnn
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()

            wstr = "SELECT  CardNumber, PersonCode FROM tbHR_Card WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & ")"

            dt_Temp = Persist1.GetDataTable(ConString, wstr)
            If dt_Temp.Rows.Count = 0 Then
                MsgBox("فردي را انتخاب ننموده ايد يا شخصي داراي اين شرايط نمي باشد", MsgBoxStyle.Information, "")
            Else
                For i = 0 To dt_Temp.Rows.Count - 1
                    Persist1.Sp_AddParam("@CardNumber_1", SqlDbType.Int, dt_Temp.DefaultView.Item(i).Item("CardNumber"), ParameterDirection.Input)
                    Persist1.Sp_Exe("insert_tempTb_Rep", ConString, True)
                Next
            End If

            wstr = "Select * from FuncAmalkard_PRSKhadamati ('" & Mid(txtBegindate.Text, 3) & "','" & Mid(txtUntilDate.Text, 3) & "')"
            dt_Export = Persist1.GetDataTable(ConString, wstr)
            If dt_Export.Rows.Count > 0 Then
                Utility1.ExportTo(dt_Export, IKIDUtility.ExportType.Excel)
                ''''جهت پاك نمودن اطلاعات موجود در جدول temp مربوط به گزارش ليست تردد پرسنل خدماتي
                cnn.ConnectionString = ConString
                cmd.CommandText = "Delete  _tempTb_Rep"
                cmd.Connection = cnn
                cnn.Open()
                cmd.ExecuteNonQuery()
                cnn.Close()
            Else
                MsgBox("اطلاعاتي براي نمايش وجود ندارد", MsgBoxStyle.Information)
                Exit Sub
            End If

        Catch ex As Exception
            ''''جهت پاك نمودن اطلاعات موجود در جدول temp مربوط به گزارش ليست تردد پرسنل خدماتي
            cnn.ConnectionString = ConString
            cmd.CommandText = "Delete  _tempTb_Rep"
            cmd.Connection = cnn
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
        End Try
    End Sub

    Private Sub cmbReportType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReportType.SelectedIndexChanged

    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Dim dt As New DataTable

        ''SqlStr = "SELECT   PersonCode, prName,MDepartName, Barcode " & _
        ''          "  FROM   Vw_Bon  WHERE     (MDepartCode IN " & janus1.get_Collection_String(grdMDepart, 0, 2) & ") ORDER BY LastName"
        SqlStr = "SELECT * FROM VwHR_PersonMDepart_Report WHERE (PersonCode in " & grdSelect1.get_Collection_String(grdPerson, 1, dtPerson, 0) & " ) "
        dt = Persist1.GetDataTable(ConString, SqlStr)

        Utility1.ExportTo(dt, IKIDUtility.ExportType.Excel)

    End Sub
End Class