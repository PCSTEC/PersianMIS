Imports System.Drawing

Public Class frmMain
    Dim B As Boolean
    Dim dt As New DataTable
    Dim logtype As Boolean

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim flg As Boolean = True


            ' '' '' '' ' '' '' '''*******''''

            ' '' '' '' '''*****************''''
            ' '' SqlStr = _
            ' ''"SELECT     PersonID , PersonFirstName+'  '+PersonLastName as PrName, NetLoginName " & _
            ' ''"FROM         GeneralObjects.dbo.tbGen_User " & _
            ' ''"WHERE     (NetLoginName = 'mjafari')"
            ' '' '' '' '''******************'''' 
            '''*******''''

            ''LogText = "acc"
            'LogID = 940
            LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
            LogID = getLogID(LogText)
           

            SqlStr = _
                       "SELECT     PersonID , PersonFirstName+'  '+PersonLastName as PrName, NetLoginName " & _
                       "FROM         GeneralObjects.dbo.tbGen_User " & _
                       "WHERE     (NetLoginName = '" & SystemInformation.UserName & "')"





            dt = Persist1.GetDataTable(ConString, SqlStr)
            lblPRSName.Text = dt.DefaultView.Item(0).Item("PrName")
            If LogID = 0 Then
                MsgBox("شما به اين نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
                Me.Close()
            End If
            ''''نظر سنجي

            JGrade1.SetUserControl(LogID, 54, Me.Name, True)

            ' '''
            ''''دسترسي حسابرس
            If Activity1.CheckUserAccess(54, 920, LogID) = True Then
                flg = True
                Me.Opacity = 100
                ExplorerBar1.Groups.Item("grpReprt").Visible = True
                ExplorerBar1.Groups.Item("ManageMent").Visible = False
                ExplorerBar1.Groups.Item("grpOfficeServices").Visible = False
                ExplorerBar1.Groups.Item("grpHelp").Visible = False
                ExplorerBar1.Groups.Item("grpWorking").Visible = True
                ExplorerBar1.Groups.Item("grpHoozoorGhiab").Visible = False
                ExplorerBar1.Groups.Item("grpBon").Visible = False
                ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = False
                ExplorerBar1.Groups.Item("grpWorking").Items("btnChart").Visible = False
                ExplorerBar1.Groups.Item("grpWorking").Items("btnPesonelist").Visible = True

                Exit Sub

            End If



            ''''دسترسي به گزارش خلاصه اطلاعات پرسنل براي تمامي پرسنل
            If Activity1.CheckUserAccess(54, 747, LogID) = True Then
                flg = False
                Me.Opacity = 100
                ExplorerBar1.Groups.Item("ManageMent").Visible = False
                ExplorerBar1.Groups.Item("grpOfficeServices").Visible = False
                ExplorerBar1.Groups.Item("grpReprt").Visible = False
                ExplorerBar1.Groups.Item("grpHelp").Visible = False
                ExplorerBar1.Groups.Item("grpWorking").Visible = False
                ExplorerBar1.Groups.Item("grpHoozoorGhiab").Visible = False
                ExplorerBar1.Groups.Item("grpBon").Visible = False
                ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = True
                'Exit Sub
            End If
            ''''دسترسي معاون مالي  و اداري
            If Activity1.CheckUserAccess(54, 733, LogID) = True Then
                flg = True
                ExplorerBar1.Groups.Item("ManageMent").Visible = False
                ExplorerBar1.Groups.Item("grpOfficeServices").Visible = False
                ExplorerBar1.Groups.Item("grpBon").Visible = False
                ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = True
            End If
            ''''دسترسي مدير آموزش
            If Activity1.CheckUserAccess(54, 735, LogID) = True Then
                flg = True
                ExplorerBar1.Groups.Item("ManageMent").Visible = False
                ExplorerBar1.Groups.Item("grpReprt").Visible = False
                ExplorerBar1.Groups.Item("grpHelp").Visible = False
                ExplorerBar1.Groups.Item("grpOfficeServices").Visible = False
                ExplorerBar1.Groups.Item("grpBon").Visible = False
                ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = True
                ExplorerBar1.Groups.Item("grpWorking").Visible = True
                ExplorerBar1.Groups.Item("grpWorking").Items("btnChart").Visible = False
                ExplorerBar1.Groups.Item("grpWorking").Items("btnPesonelist").Visible = True
                ''''دسترسي بيمه
            ElseIf Activity1.CheckUserAccess(54, 950, LogID) = True Then
                flg = True
                ExplorerBar1.Groups.Item("ManageMent").Visible = False
                ExplorerBar1.Groups.Item("grpReprt").Visible = False
                ExplorerBar1.Groups.Item("grpHelp").Visible = False
                ExplorerBar1.Groups.Item("grpOfficeServices").Visible = False
                ExplorerBar1.Groups.Item("grpBon").Visible = False
                ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = True
                ExplorerBar1.Groups.Item("grpWorking").Visible = True
                ExplorerBar1.Groups.Item("grpWorking").Items("btnChart").Visible = False
                ExplorerBar1.Groups.Item("grpWorking").Items("btnPesonelist").Visible = True
                '' دسترسی به گزارش خلاصه وضعیت پرسنلی
            ElseIf Activity1.CheckUserAccess(54, 1019, LogID) = True Then
                flg = True
                ExplorerBar1.Groups.Item("ManageMent").Visible = False
                ExplorerBar1.Groups.Item("grpReprt").Visible = False
                ExplorerBar1.Groups.Item("grpHelp").Visible = False
                ExplorerBar1.Groups.Item("grpOfficeServices").Visible = False
                ExplorerBar1.Groups.Item("grpBon").Visible = False
                ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = True
                ExplorerBar1.Groups.Item("grpWorking").Visible = True
                ExplorerBar1.Groups.Item("grpWorking").Items("btnChart").Visible = False
                ExplorerBar1.Groups.Item("grpWorking").Items("btnPesonelist").Visible = True

                ''''دسترسي خدمات اداري
            ElseIf Activity1.CheckUserAccess(54, 737, LogID) = True Then
                flg = True
                ExplorerBar1.Groups.Item("ManageMent").Visible = False
                ExplorerBar1.Groups.Item("grpReprt").Visible = False
                ExplorerBar1.Groups.Item("grpHelp").Visible = False
                ExplorerBar1.Groups.Item("grpWorking").Visible = False
                ExplorerBar1.Groups.Item("grpBon").Visible = False
                ExplorerBar1.Groups.Item("grpOfficeServices").Visible = True
                ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = True
            End If
            ''''دسترسي كارگزيني
            If Activity1.CheckUserAccess(54, 730, LogID) = True Then
                flg = True
                ExplorerBar1.Groups.Item("ManageMent").Visible = True
                ExplorerBar1.Groups.Item("grpOfficeServices").Visible = False
                ExplorerBar1.Groups.Item("grpBon").Visible = False
                ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = True
            Else
                If Activity1.CheckUserAccess(54, 736, LogID) = False Then
                    If Activity1.CheckUserAccess(54, 737, LogID) = False Then
                        If Activity1.CheckUserAccess(54, 735, LogID) = False Then
                            If Activity1.CheckUserAccess(54, 950, LogID) = False Then
                                If Activity1.CheckUserAccess(54, 733, LogID) = False Then
                                    If Activity1.CheckUserAccess(54, 747, LogID) = False Then
                                        If Activity1.CheckUserAccess(54, 751, LogID) = False Then
                                            If Activity1.CheckUserAccess(54, 1019, LogID) = False Then

                                                MsgBox("شما به اين نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
                                                Me.Close()
                                                Exit Sub
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If



            ''''دسترسي مدير منابع انساني
            If Activity1.CheckUserAccess(54, 730, LogID) = True And Activity1.CheckUserAccess(54, 737, LogID) = True Then
                flg = True
                ExplorerBar1.Groups.Item("ManageMent").Visible = True
                ExplorerBar1.Groups.Item("grpReprt").Visible = True
                ExplorerBar1.Groups.Item("grpHelp").Visible = True
                ExplorerBar1.Groups.Item("grpWorking").Visible = True
                ExplorerBar1.Groups.Item("grpOfficeServices").Visible = True
                ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = True
                ExplorerBar1.Groups.Item("grpBon").Visible = True
            End If
            ''''دسترسي حراست پرسنلي
            If Activity1.CheckUserAccess(54, 751, LogID) = True Then
                ExplorerBar1.Groups.Item("ManageMent").Visible = False
                ExplorerBar1.Groups.Item("grpOfficeServices").Visible = False
                ExplorerBar1.Groups.Item("grpReprt").Visible = False
                ExplorerBar1.Groups.Item("grpHelp").Visible = False
                ExplorerBar1.Groups.Item("grpWorking").Visible = True
                ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = True
                ExplorerBar1.Groups.Item("grpHoozoorGhiab").Visible = False
                ExplorerBar1.Groups.Item("grpBon").Visible = False
            End If

            ''''دسترسي Admin
            If Activity1.CheckUserAccess(54, 736, LogID) = True Then
                flg = True
                ExplorerBar1.Groups.Item("ManageMent").Visible = True
                ExplorerBar1.Groups.Item("grpOfficeServices").Visible = True
                ExplorerBar1.Groups.Item("grpReprt").Visible = True
                ExplorerBar1.Groups.Item("grpHelp").Visible = True
                ExplorerBar1.Groups.Item("grpWorking").Visible = True
                ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = True
                ExplorerBar1.Groups.Item("grpBon").Visible = True
                logtype = True
            End If

            ''''كاربران نرم افزار بن
            If Activity1.CheckUserAccess(54, 766, LogID) = True Then
                ExplorerBar1.Groups.Item("grpBon").Visible = True
            Else
                ExplorerBar1.Groups.Item("grpBon").Visible = False
            End If


            If flg = True Then
                For i = 20 To 1000
                    Me.Opacity = Me.Opacity + 0.02
                    If Me.Opacity = 1 Then
                        Exit For
                        Me.BringToFront()
                    End If
                Next
            End If
            Timer1.Enabled = True
            lblCurDate.Text = Mid(IraniDate1.GetIrani8Date_CurDate, 1, 4) & "/" & Mid(IraniDate1.GetIrani8Date_CurDate, 5, 2) & "/" & Mid(IraniDate1.GetIrani8Date_CurDate, 7, 2) & "  " & IraniDate1.GetIraniDayName_CurDate

            'ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = False


        Catch ex As Exception
            MsgBox("در ورود به نرم افزار مشکلی وجود دارد ")
            Me.Close()

            ExplorerBar1.Groups.Item("grpGeneralrpt").Visible = False

        End Try
    End Sub

    Private Sub ExplorerBar1_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ExplorerBar.ItemEventArgs) Handles ExplorerBar1.ItemClick

        Select Case e.Item.Key

            ''''چارت سازماني
            Case "btnChart"
                ''''دسترسي حراست
                If Activity1.CheckUserAccess(54, 751, LogID) = True Then
                    Dim frm As New frmPRSMainChart
                    frm.MenuStrip1.Visible = False
                    frm.ContextTrvChart.Enabled = False
                    frm.ContextGrdPost.Enabled = False
                    frm.ShowDialog()
                    ''    ''''******'حذف دسترسي پرسنل كارگزيني طبق نامه 2054-13891011 بجز خود نبي زاده
                    ''ElseIf LogID = 168 Or LogID = 21 Then   ''''نبي زاده و شريفي  DM_PDC2\nabizadeh   
                    ''    Dim frm As New frmPRSMainChart
                    ''    frm.MenuStrip1.Visible = True
                    ''    frm.ContextTrvChart.Enabled = True
                    ''    frm.ContextGrdPost.Enabled = True
                    ''    frm.ShowDialog()

                ElseIf Activity1.CheckUserAccess(54, 730, LogID) = True Then
                    Dim frm As New frmPRSMainChart
                    frm.MenuStrip1.Visible = True
                    frm.ContextTrvChart.Enabled = True
                    frm.ContextGrdPost.Enabled = True
                    frm.ShowDialog()
                    ''''**************'''''
                Else ''''دسترسي بقيه نفرات
                    Dim frmChart As New frmPRSMainChart
                    frmChart.ShowDialog()
                End If


                ''Case "BtnReportChart" ' نمایش صفحه گزارش نمودار
                ''    Dim frm As New FrmChartHoghoogh
                ''    frm.Show()



                ''''پرسنلي
            Case "btnPesonelist"
                ''''دسترسي حراست
                Dim frm As New frmPRSMain
                If Activity1.CheckUserAccess(54, 751, LogID) = True Then
                    frm.tsmHerasat.Visible = True
                    frm.tsmSodor.Visible = False
                    frm.tsmHistory.Visible = False
                    frm.tsmInformation.Visible = False
                    frm.ExplorerBar1.Enabled = False
                    frm.ExplorerBar1.Visible = False

                End If
                ''''دسترسي Admin
                If Activity1.CheckUserAccess(54, 736, LogID) = True Then
                    frm.tsmHerasat.Visible = True
                    frm.tsmSodor.Visible = True
                    frm.tsmHistory.Visible = True
                    frm.tsmInformation.Visible = True
                    frm.ExplorerBar1.Visible = True

                End If

                ''''''دسترسي حسابرس
                If Activity1.CheckUserAccess(54, 920, LogID) = True Then
                    frm.tsmHerasat.Visible = False
                    frm.tsmSodor.Visible = False
                    frm.tsmHistory.Visible = True
                    frm.tsmInformation.Visible = False
                    frm.ExplorerBar1.Enabled = False
                    frm.ExplorerBar1.Visible = False
                    frm.mnuPersonKey.Visible = False

                End If

                frm.ShowDialog()

                ''''گزارشات
            Case "btnMakeReport"
                Dim frm As New frmMakeReport
                frm.ShowDialog()
            Case "btnClose"
                Me.Close()
            Case "btnHelp"
                'Utility1.OpenFile("\\Nt_dbms\MIS\wappPersonely\Help For wappPersonely\User_Guide.pdf")

                Utility1.OpenFile("\\Nt_dbms\wappPersonely\Help For wappPersonely\User_Guide.pdf")

                'System.Diagnostics.Process.Start("\\s1002\d$\User_Guide.pdf")
            Case "btnAbout"
                Dim f1 As New frmPRSAbout
                f1.ShowDialog()

            Case "btnAddDescribe"
                Dim frm As New frmAddDescribe
                frm.ShowDialog()

            Case "btnAddMadrak"
                Dim frm As New frmAddMadrak
                frm.ShowDialog()

            Case "btnAddStudyPlace"
                Dim frm As New frmAddStudyPlace
                frm.ShowDialog()

            Case "btnCommode"
                Dim frm As New frmCommodeMain
                frm.ShowDialog()

            Case "btnGeneralrpt"
                If logtype = True Then
                    wstr = _
                                                  "SELECT     *   " & _
                                                  " FROM         VwHR_PersonProperty " & _
                                                  " WHERE (PersonCode = " & dt.DefaultView.Item(0).Item("PersonID") & ") "
                    rptReports = New rptGeneralAbstract
                    LastRepName = ReportName
                    ReportName = "rptGeneralAbstract"
                    Call rptLoad()

                Else

                    wstr = _
                               "SELECT     *   " & _
                               " FROM         VwHR_PersonProperty " & _
                               " WHERE (PersonCode = " & dt.DefaultView.Item(0).Item("PersonID") & ") "
                    rptReports = New rptPersonPropertyAbstract
                    LastRepName = ReportName
                    ReportName = "rptPersonPropertyAbstract"
                    Call rptLoad()
                End If
6:          Case "btnGenericTraining"
                Dim frm As New frmPRSTraining
                frm.PersonCode = dt.DefaultView.Item(0).Item("PersonID")
                frm.lblPersonCode.Text = dt.DefaultView.Item(0).Item("PersonID")
                frm.lblPersonID.Text = dt.DefaultView.Item(0).Item("PersonID")
                frm.Text = frm.Text + "---" + lblPRSName.Text
                frm.PersonID = dt.DefaultView.Item(0).Item("PersonID")

                frm.grdTraining.Location = New System.Drawing.Point(4, 6)
                frm.grdTraining.Size = New System.Drawing.Size(715, 562)
                frm.Flag_View = True
                frm.ShowDialog()
            Case "btnConvertor"
                Shell("C:\IkidSystems\ConvertOfDailyWorkToOldKara.exe", AppWinStyle.NormalFocus)

            Case "btnBon"
                Dim frm As New frmBon
                frm.ShowDialog()

            Case "btnPaye"
                Dim frm As New FrmJob
                frm.ShowDialog()

        End Select
    End Sub

    Private Sub rptLoad()
        Dim DA1 As SqlClient.SqlDataAdapter
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblCurrentTime.Text = Microsoft.VisualBasic.TimeOfDay()
        ''''تغيير رنگ
        'lblCurDate.ForeColor = Color.FromArgb(CType(i, Byte), CType(j, Byte), CType(k, Byte), CType(l, Byte))
        ' ''lblCurrentTime.ForeColor = Color.FromArgb(CType(l, Byte), CType(k, Byte), CType(j, Byte), CType(i, Byte))
        'If grpTimer.Top > 100 Then
        '    If B = True Then
        '        grpTimer.Top = grpTimer.Top + 1
        '    Else
        '        grpTimer.Top = grpTimer.Top - 1
        '    End If
        'End If
        'If grpTimer.Top = 100 Or grpTimer.Top < 100 Then
        '    B = True
        '    grpTimer.Top = grpTimer.Top + 1
        'End If
        'If grpTimer.Top = 100 Or grpTimer.Top > 100 Then
        '    B = False
        '    grpTimer.Top = grpTimer.Top - 1
        'End If
    End Sub


End Class