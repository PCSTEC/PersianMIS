Public Class frmPRSMain
    Dim dt_Person As New DataTable
    Dim dt_prsImage As New DataTable
    Dim Bus_Person1 As New Bus_Person
    Private DA1 As New SqlClient.SqlDataAdapter
    Dim SumAllSalary As Double = 0
    Dim BaseSalary As Double = 0
    Dim DayCount, DayCountUndertest As Integer
    Dim MarriageType As String
    Dim ChildCount As Integer
    Dim GroupSalary As Double = 0
    Dim SumrootSalary As Double = 0
    Dim SumAll As Double = 0
    Dim Flg_Control As Boolean
    Dim a As Long
    Dim Day As String
    Dim dt_EndTreaty As New DataTable

    Private Sub frmPRSMain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
        janus1.BindJanusNavigator(grdPerson, dt_Person, e)
    End Sub

    Private Sub frmPRSPersonList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''نظر سنجي

        '   JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''

        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)


        If Activity1.CheckUserAccess(54, 1032, LogID) = True Then
            mnuSale.Visible = True
        Else
            mnuSale.Visible = False
        End If


        If LogID = 0 Then
            ''''دسترسي همه پرسنل
            cmsgrdPerson.Enabled = False
            ExplorerBar1.Enabled = False
            '''''دسترسي معاون مالي و اداري
        ElseIf Activity1.CheckUserAccess(54, 733, LogID) = True Then
            ExplorerBar1.Enabled = False
            mnuKholaseRep.Enabled = False
            '''''دسترسي آموزش
        ElseIf Activity1.CheckUserAccess(54, 735, LogID) = True Then
            ExplorerBar1.Enabled = False
            cmsgrdPerson.Items("tsmSodor").Visible = False
            cmsgrdPerson.Items("tsmInformation").Visible = False
            tsmHokmHistory.Visible = False
            tsmEducationHistpry.Visible = False
            tsmJobHistory.Visible = False
            tsmMeedHistory.Visible = False
            Tsmjari.Visible = False
            mnuKholaseRep.Enabled = False
            '''''دسترسي بيمه باقر غفاري
        ElseIf Activity1.CheckUserAccess(54, 950, LogID) = True Then
            ExplorerBar1.Enabled = False
            cmsgrdPerson.Items("tsmSodor").Visible = False
            cmsgrdPerson.Items("tsmInformation").Visible = False
            tsmHokmHistory.Visible = False
            tsmEducationHistpry.Visible = False
            tsmJobHistory.Visible = True
            tsmMeedHistory.Visible = False
            Tsmjari.Visible = False
            tsmTrinningHistory.Visible = False
            tsmHerasat.Visible = False
            mnuKholaseRep.Enabled = False

            ''''دسترسی به گزارش خلاصه وضعیت پرسنلی
        ElseIf Activity1.CheckUserAccess(54, 1019, LogID) = True Then
            ExplorerBar1.Enabled = False
            cmsgrdPerson.Items("tsmSodor").Visible = False
            cmsgrdPerson.Items("tsmInformation").Visible = False
            tsmHokmHistory.Visible = False
            tsmEducationHistpry.Visible = False
            tsmJobHistory.Visible = False
            tsmMeedHistory.Visible = False
            Tsmjari.Visible = False
            tsmTrinningHistory.Visible = False
            tsmHerasat.Visible = False
            mnuKholaseRep.Enabled = False
            mnuKholaseRep.Enabled = True
            tsmHistory.Enabled = False
            '''''دسترسي حسابرس
        ElseIf Activity1.CheckUserAccess(54, 920, LogID) = True Then
            ExplorerBar1.Enabled = False
            cmsgrdPerson.Items("tsmSodor").Visible = False
            cmsgrdPerson.Items("tsmInformation").Visible = False
            tsmHokmHistory.Visible = True
            tsmHistory.Visible = True


            tsmHerasat.Visible = False
            tsmSodor.Visible = False
            tsmHistory.Visible = True
            tsmInformation.Visible = False
            ExplorerBar1.Enabled = False
            ExplorerBar1.Visible = False
            mnuPersonKey.Visible = False

            tsmEducationHistpry.Visible = False
            tsmTrinningHistory.Visible = False
            tsmJobHistory.Visible = False
            tsmMeedHistory.Visible = False
            Tsmjari.Visible = False
            mnuKholaseRep.Enabled = False
        ElseIf Activity1.CheckUserAccess(54, 751, LogID) = True Then
            tsmHerasat.Visible = True
            tsmSodor.Visible = False
            tsmHistory.Visible = False
            tsmInformation.Visible = False
            tsmGeneralrpt.Visible = False
            mnuPersonKey.Visible = False
            mnuKholaseRep.Visible = False
            mnuSale.Visible = False
            لیستاولادبالای18سالToolStripMenuItem.Visible = False
       
        End If

        ''''دسترسي كارگزيني
        If Activity1.CheckUserAccess(54, 730, LogID) = True Then
            ExplorerBar1.Enabled = True
        End If
        ''''دسترسي admin
        If Activity1.CheckUserAccess(54, 736, LogID) = True Then
            ExplorerBar1.Enabled = True
        End If
        If Activity1.CheckUserAccess(54, 898, LogID) = True Then
            mnuPersonKey.Visible = True
        End If
        If Activity1.CheckUserAccess(54, 1082, LogID) = True Then
  
            mnuKholaseRep.Visible = True
        End If

        Flg_Control = False



        FillgrdPerson(SelectStr.Current)




        Flg_Control = True
        a = IraniDate1.GetPlussToIraniDate(IraniDate1.GetIrani8Date_CurDate, 60)
        Day = IraniDate1.GetDateIntToStr_GivenDate(a)
        dt_EndTreaty = Bus_Person1.GetAlarmInfoForShowHide(IraniDate1.GetIrani8DateStr_CurDate, Day)

        If LogID = 565 Then
            tsmGeneralrpt.Visible = True
        End If

        ''''دسترسي Admin
        If Activity1.CheckUserAccess(54, 736, LogID) = True Then
            If dt_EndTreaty.Rows.Count <> 0 Then
                Dim frm As New frmMsgBox
                frm.ShowDialog()
                Exit Sub
            End If
            '''''دسترسي آموزش
        ElseIf Activity1.CheckUserAccess(54, 735, LogID) = True Or Activity1.CheckUserAccess(54, 751, LogID) = True Or Activity1.CheckUserAccess(54, 950, LogID) = True Or Activity1.CheckUserAccess(54, 1019, LogID) = True Or Activity1.CheckUserAccess(54, 920, LogID) = True Then
            ExplorerBar1.Enabled = False
            Exit Sub
        Else
            If dt_EndTreaty.Rows.Count <> 0 Then
                Dim frm As New frmMsgBox
                frm.ShowDialog()
                Exit Sub
            End If
        End If



    End Sub

    Friend Function FilllblDossier()
        Try
            If Flg_Control = True Then
                lblYearCount.Text = grdPerson.GetValue("YearInIkid")
                lblMounthCount.Text = grdPerson.GetValue("MonthInIkid")
                lblDayCount.Text = grdPerson.GetValue("DayInIkid")
                lblYearCountOut.Text = grdPerson.GetValue("YearOutIkid")
                lblMounthCountOut.Text = grdPerson.GetValue("MonthOutIkid")
                lblDayCountOut.Text = grdPerson.GetValue("DayOutIkid")
            Else
                lblYearCount.Text = "-"
                lblMounthCount.Text = "-"
                lblDayCount.Text = "-"
                lblYearCountOut.Text = "-"
                lblMounthCountOut.Text = "-"
                lblDayCountOut.Text = "-"
            End If
        Catch ex As Exception

        End Try

    End Function

    Private Sub btnEmissionHokm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmPRSHokmsocial
        frm.ShowDialog()
    End Sub

    Friend Sub FillgrdPerson(ByVal Sel As SelectStr)
        Dim janus1 As New JFrameWork.JanusGrid
        dt_Person.Rows.Clear()
        If Sel = SelectStr.All Then      ''''''انتخاب همه
            Flg_Control = False
            dt_Person.Rows.Clear()
            SqlStr = "select * from VwHR_PersonListInfo"
            dt_Person = Persist1.GetDataTable(ConString, SqlStr)
            dt_Person.DefaultView.Sort = "LastName"
            janus1.GetBindJGrid_DT(dt_Person, grdPerson, ConString)
            janus1.setMyJGrid(grdPerson, "PersonCode", "كد", 75)
            janus1.setMyJGrid(grdPerson, "FirstName", "نام", 95)
            janus1.setMyJGrid(grdPerson, "LastName", "نام خانوادگي", 120)
            janus1.setMyJGrid(grdPerson, "FatherName", "نام پدر", 75)
            janus1.setMyJGrid(grdPerson, "DepartName", "نام واحد", 150)
            janus1.setMyJGrid(grdPerson, "Posttxt", "عنوان پست", 190)
            janus1.setMyJGrid(grdPerson, "EngageType", "نوع استخدام", 90)
            janus1.setMyJGrid(grdPerson, "EngageDate", "تاريخ استخدام", 80)
            janus1.setMyJGrid(grdPerson, "PersonID", "PersID", 0, , , False)
            janus1.setMyJGrid(grdPerson, "PostID", "PostID", 0, , , False)
            janus1.setMyJGrid(grdPerson, "DepartCode", "كد واحد", 0, , , False)
            janus1.setMyJGrid(grdPerson, "PostCode", "كد پست", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDNum", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "BirthDate", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "SexID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "NationalCode", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDSerial", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "BirthCityID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "BirthCityCode", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDIssueID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDIssueCode", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "EngageTypeID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "MilitaryStateID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "WorkIDNum", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "AssureNum", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "Address", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "Tel", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "Mobile", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "PersonKeyOnPost", "", 0, , , False)
            'janus1.SetGroup(grdPerson, "EngageType")
            janus1.BindJanusNavigator(grdPerson, dt_Person)
        ElseIf Sel = SelectStr.Current Then               ''''''انتخاب جاري
            dt_Person.Rows.Clear()
            dt_Person = Bus_Person1.GetPersonInfo           ' VwHR_PRSEmployee where EmployeeActive = 1
            dt_Person.DefaultView.Sort = "LastName"

            janus1.GetBindJGrid_DT(dt_Person, grdPerson, ConString)
            janus1.setMyJGrid(grdPerson, "PersonCode", "كد پرسنلي", 75)
            janus1.setMyJGrid(grdPerson, "FirstName", "نام", 95)
            janus1.setMyJGrid(grdPerson, "LastName", "نام خانوادگي", 120)
            janus1.setMyJGrid(grdPerson, "FatherName", "نام پدر", 75)
            janus1.setMyJGrid(grdPerson, "MDepartName", "نام واحد", 150)
            janus1.setMyJGrid(grdPerson, "DepartName", "نام اداره", 150)
            janus1.setMyJGrid(grdPerson, "Posttxt", "عنوان پست", 190)
            janus1.setMyJGrid(grdPerson, "EngageType", "نوع استخدام", 90)
            janus1.setMyJGrid(grdPerson, "EngageDate", "تاريخ استخدام", 80)
            'janus1.setMyJGrid(grdPerson, "SumDate", "سابقه به روز", 80)
            janus1.setMyJGrid(grdPerson, "PersonID", "PersonID", 0, , , False)
            janus1.setMyJGrid(grdPerson, "PostID", "PostID", 0, , , False)
            janus1.setMyJGrid(grdPerson, "DepartCode", "كد واحد", 0, , , False)
            janus1.setMyJGrid(grdPerson, "PostCode", "كد پست", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDNum", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "BirthDate", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "SexID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "NationalCode", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDSerial", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "BirthCityID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "BirthCityCode", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDIssueID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDIssueCode", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "EngageTypeID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "MilitaryStateID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "WorkIDNum", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "AssureNum", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "EmployeeID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "EmployeeCode", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "Address", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "Tel", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "Mobile", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "YearInIkid", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "MonthInIkid", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "DayInIkid", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "YearOutIkid", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "MonthOutIkid", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "DayOutIkid", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "PersonKeyOnPost", "", 0, , , False)
            'janus1.setMyJGrid(grdPerson, "SagfEzafe", "سقف اضافه", 80)



            'janus1.SetGroup(grdPerson, "EngageType")
            janus1.BindJanusNavigator(grdPerson, dt_Person)
            Flg_Control = True
            ''''غير جاري
        ElseIf Sel = SelectStr.NotCurrent Then
            Flg_Control = False
            dt_Person.Rows.Clear()
            SqlStr = "SELECT  * FROM dbo.VwHR_PersonListInfo WHERE (EmployTypeID = 16 OR  EmployTypeID = 18 OR  EmployTypeID = 37 OR  EmployTypeID = 38 OR  EmployTypeID = 39 OR  EmployTypeID = 40 OR  EmployTypeID = 41 or  EmployTypeID = 52)"
            dt_Person = Persist1.GetDataTable(ConString, SqlStr)
            dt_Person.DefaultView.Sort = "LastName"
            janus1.GetBindJGrid_DT(dt_Person, grdPerson, ConString)
            janus1.setMyJGrid(grdPerson, "PersonCode", "كد پرسنلی", 100)
            janus1.setMyJGrid(grdPerson, "FirstName", "نام", 100)
            janus1.setMyJGrid(grdPerson, "LastName", "نام خانوادگي", 150)
            janus1.setMyJGrid(grdPerson, "FatherName", "نام پدر", 85)
            janus1.setMyJGrid(grdPerson, "BirthDate", "تاريخ تولد", 100)
            janus1.setMyJGrid(grdPerson, "EngageDate", "تاريخ استخدام", 100)
            janus1.setMyJGrid(grdPerson, "NationalCode", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDNum", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "EngageTypeID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "SexID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDSerial", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "BirthCityID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "BirthCityCode", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDIssueID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "MilitaryStateID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "WorkIDNum", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "AssureNum", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "Address", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "Tel", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "Mobile", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "PersonID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "EngageType", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDIssueCode", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "PersonKeyOnPost", "", 0, , , False)
            '  janus1.setMyJGrid(grdPerson, "EngageType", "", 0, , , False)
            'janus1.SetGroup(grdPerson, "EngageType")
            janus1.BindJanusNavigator(grdPerson, dt_Person)

            Exit Sub
            ''''بدو استخدام
        ElseIf Sel = SelectStr.FirstEngage Then
            Flg_Control = False
            dt_Person.Rows.Clear()
            SqlStr = "select * from VwHR_StartEngage"
            dt_Person = Persist1.GetDataTable(ConString, SqlStr)
            dt_Person.DefaultView.Sort = "LastName"
            janus1.GetBindJGrid_DT(dt_Person, grdPerson, ConString)
            janus1.setMyJGrid(grdPerson, "PersonID", "PersonID", 0, , , False)
            janus1.setMyJGrid(grdPerson, "PersonCode", "كد", 80)
            janus1.setMyJGrid(grdPerson, "FirstName", "نام", 100)
            janus1.setMyJGrid(grdPerson, "LastName", "نام خانوادگي", 150)
            janus1.setMyJGrid(grdPerson, "FatherName", "نام پدر", 85)
            janus1.setMyJGrid(grdPerson, "BirthDate", "تاريخ تولد", 90)
            janus1.setMyJGrid(grdPerson, "NationalCode", "كد ملي", 90)
            janus1.setMyJGrid(grdPerson, "EngageDate", "تاريخ استخدام", 90)
            janus1.setMyJGrid(grdPerson, "IDNum", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "SexID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDSerial", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "BirthCityID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDIssueID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "MilitaryStateID", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "WorkIDNum", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "AssureNum", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "Address", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "Tel", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "Mobile", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "EngageType", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "BirthCityCode", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "IDIssueCode", "", 0, , , False)
            janus1.setMyJGrid(grdPerson, "PersonKeyOnPost", "", 0, , , False)
            'janus1.SetGroup(grdPerson, "EngageType")
            janus1.BindJanusNavigator(grdPerson, dt_Person)

            Exit Sub
        End If

        'janus1.setMyJGrid(grdPerson, "PersonImage", "PersonImage", 100, Janus.Windows.GridEX.EditType.Custom, Janus.Windows.GridEX.ColumnType.BoundImage)
    End Sub

    Private Sub خروجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub فرديToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmPersonInformation.Click
        Dim frm As New frmPRSProperty
        Dim dt_PersonList As DataTable
        dt_prsImage.Rows.Clear()
        If grdPerson.RowCount <> 0 Then
            frm.UiGroupBox2.Enabled = False
            frm.btnPictureChange.Visible = False
            frm.lblprsID.Text = grdPerson.GetValue("PersonID")
            frm.SexID = grdPerson.GetValue("SexID")
            frm.BirthCityCode = Utility1.NZ(grdPerson.GetValue("BirthCityCode"), 0)
            frm.BirthCityID = grdPerson.GetValue("BirthCityID")
            frm.lblBirthCityID.Text = grdPerson.GetValue("BirthCityID")
            frm.IssueCityCode = Utility1.NZ(grdPerson.GetValue("IDIssueCode"), 0)
            frm.IssueCityID = grdPerson.GetValue("IDIssueID")
            frm.lblIssueCityID.Text = grdPerson.GetValue("IDIssueID")
            frm.MilitaryID = grdPerson.GetValue("MilitaryStateID")
            frm.EngageTypeID = grdPerson.GetValue("EngageTypeID")
            SqlStr = "select * from VwHR_PRSEmployee Where PersonID = " & grdPerson.GetValue("PersonID") & ""
            dt_PersonList = Persist1.GetDataTable(ConString, SqlStr)
            frm.txtCode.Text = dt_PersonList.DefaultView.Item(0).Item("PersonCode")
            frm.txtName.Text = dt_PersonList.DefaultView.Item(0).Item("FirstName")
            frm.txtLName.Text = dt_PersonList.DefaultView.Item(0).Item("LastName")
            frm.txtFName.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("FatherName"), "_")
            frm.txtIDNum.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("IDNum"), 0)
            frm.txtBirthDate.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("BirthDate"), 0)
            frm.txtNationalCode.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("NationalCode"), 0)
            frm.txtIDSerial.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("IDSerial"), 0)
            frm.txtEgageDate.Text = dt_PersonList.DefaultView.Item(0).Item("EngageDate")
            frm.txtWorkID.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("WorkIDNum"), 0)
            frm.txtAssureNum.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("AssureNum"), 0)
            frm.txtAddress.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Address"), "_")
            frm.txtTel.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Tel"), 0)
            frm.txtMobile.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Mobile"), 0)
            frm.txtPostCode.Text = dt_PersonList.DefaultView.Item(0).Item("PostalCode")
            dt_prsImage = Persist1.GetDataTable(ConString, "select PersonImage from tbHR_Person where PersonID = " & grdPerson.GetValue("PersonID") & " ")
            Try
                frm.PictureBox1.Image = pic1.getImageBuffer_Load(dt_prsImage.DefaultView.Item(0).Item("PersonImage"))
                dt_prsImage.Rows.Clear()
            Catch ex As Exception
            End Try
            frm.frmPRSMain1 = Me
            frm.ShowDialog()
        Else
            MsgBox("ايتمي براي نمايش موجود نمي باشد", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub خانوادگيToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmFamilyInformation.Click
        Dim frm As New frmPRSFamily
        frm.PersonCode = grdPerson.GetValue("PersonCode")
        frm.lblPersonName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
        frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
        frm.PersonID = grdPerson.GetValue("PersonID")
        frm.ShowDialog()
    End Sub

    Private Sub حكمToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmHokmHistory.Click
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Exit Sub
            '''''دسترسي آموزش
        ElseIf Activity1.CheckUserAccess(54, 735, LogID) = True Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
        ElseIf Activity1.CheckUserAccess(54, 950, LogID) = True Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
        ElseIf Activity1.CheckUserAccess(54, 1019, LogID) = True Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")

            Exit Sub
        End If
        Dim frm As New frmPRSPastHokm
        frm.PersonCode = grdPerson.GetValue("PersonCode")
        frm.lblEngageDate.Text = grdPerson.GetValue("EngageDate")
        frm.lblName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
        frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
        frm.ShowDialog()
    End Sub

    Private Sub تحصيليToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEducationHistpry.Click
        Dim frm As New frmPRSEducation
        frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
        frm.lblName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
        frm.PersonCode = grdPerson.GetValue("PersonCode")
        frm.PersonID = grdPerson.GetValue("PersonID")
        frm.ShowDialog()
    End Sub

    Private Sub استخداميToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmJobHistory.Click
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Exit Sub
            '''''دسترسي آموزش
        ElseIf Activity1.CheckUserAccess(54, 735, LogID) = True Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
       
            Exit Sub
        End If
        Dim frm As New frmPRSDossier
        frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
        frm.PersonCode = grdPerson.GetValue("PersonCode")
        frm.lblPersonID.Text = grdPerson.GetValue("PersonID")
        frm.lblName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
        frm.PersonID = grdPerson.GetValue("PersonID")
        frm.ShowDialog()
    End Sub

    Private Sub آموزشيToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmTrinningHistory.Click
        Dim frm As New frmPRSTraining
        frm.PersonCode = grdPerson.GetValue("PersonCode")
        frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
        frm.lblPersonID.Text = grdPerson.GetValue("PersonID")
        frm.lblPersonName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
        frm.PersonID = grdPerson.GetValue("PersonID")
        frm.engagedate = grdPerson.GetValue("EngageDate")
        frm.ShowDialog()
    End Sub

    Private Sub فرديToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmPersonHokm.Click
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("شما به اين نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Me.Close()
        ElseIf Activity1.CheckUserAccess(54, 730, LogID) = True Then

        ElseIf Activity1.CheckUserAccess(54, 733, LogID) = True Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
        ElseIf Activity1.CheckUserAccess(54, 792, LogID) = True Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Exit Sub
        End If


        If lblVazeeiat.Text.Trim = "جاري" Then
            If grdPerson.GetValue("EngageTypeID") = 3 Or grdPerson.GetValue("EngageTypeID") = 4 Or grdPerson.GetValue("EngageTypeID") = 6 Or grdPerson.GetValue("EngageTypeID") = 7 Then
                ' Or grdPerson.GetValue("EngageTypeID") = 9 Or grdPerson.GetValue("EngageTypeID") = 10 Then
                MsgBox("مجاز به انجام اين عمل نمي باشيد . لطفا از قسمت قرارداد اقدام نماييد", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        End If

        Dim frm As New frmPRSHokm
        Dim dt_Employee As New DataTable
        frm.LogID = LogID
        If grdPerson.GetValue("PersonCode") = Nothing Then
            Exit Sub
        Else
            If lblVazeeiat.Text.Trim = "جاري" Then
                If grdPerson.RowCount <> 0 Then
                    dt_Employee = Bus_Employee1.GetEmployInfo(grdPerson.GetValue("PersonCode"))
                    frm.EmployeeID = dt_Employee.DefaultView.Item(0).Item("EmployeeID")
                    frm.PostID = dt_Employee.DefaultView.Item(0).Item("PostID")
                    frm.postcode = dt_Employee.DefaultView.Item(0).Item("PostCode")
                    frm.JobID = Utility1.NZ(dt_Employee.DefaultView.Item(0).Item("JobTitleID"), 0)
                    frm.EngageTypeID = dt_Employee.DefaultView.Item(0).Item("EngageTypeID")
                    frm.EmployeeTypeID = dt_Employee.DefaultView.Item(0).Item("EmployTypeID")
                    frm.DescribeID = dt_Employee.DefaultView.Item(0).Item("DescribID")
                    frm.GroupID = dt_Employee.DefaultView.Item(0).Item("GroupID")
                    frm.MilitaryStateID = grdPerson.GetValue("MilitaryStateID")
                    frm.lblEmpCode.Text = Str(dt_Employee.DefaultView.Item(0).Item("EmployeeCode"))
                    frm.txtUnderTest.Text = Str(dt_Employee.DefaultView.Item(0).Item("UnderTestFee"))
                    frm.txtGroupFee.Text = Str(Decimal.Round(dt_Employee.DefaultView.Item(0).Item("GroupFee")))
                    frm.txtSanavatFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("Sanavat"))
                    frm.txtGradeFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("GradeFee"))
                    frm.txtEmissionDate.Text = dt_Employee.DefaultView.Item(0).Item("EmissionDate")
                    frm.lblEmissionDate.Text = dt_Employee.DefaultView.Item(0).Item("EmissionDate")
                    frm.txtDiffer.Text = Str(dt_Employee.DefaultView.Item(0).Item("Differ"))
                    frm.txtHouseFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("HouseFee"))
                    frm.txtFoodFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("FoodFee"))
                    frm.txtMarriageFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("MarriageFee"))
                    frm.txtSoldierFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("SoldierFee"))
                    frm.txtOverJazb.Text = Str(dt_Employee.DefaultView.Item(0).Item("OverJazb"))
                    frm.txtOverPost.Text = Str(dt_Employee.DefaultView.Item(0).Item("OverPost"))
                    frm.txtBarjasteh.Text = Str(dt_Employee.DefaultView.Item(0).Item("Barjeste"))
                    frm.txtBeginEmployee.Text = dt_Employee.DefaultView.Item(0).Item("BeginDate")
                    frm.lblBeginDate.Text = dt_Employee.DefaultView.Item(0).Item("BeginDate")
                    frm.txtEndEmployee.Text = dt_Employee.DefaultView.Item(0).Item("EndDate")
                    frm.lblEndDate.Text = dt_Employee.DefaultView.Item(0).Item("EndDate")
                    frm.txtExecDateEmployee.Text = dt_Employee.DefaultView.Item(0).Item("ExecDate")
                    frm.lblSalary.Text = Str(dt_Employee.DefaultView.Item(0).Item("Salary"))
                    frm.txtEngageDate.Text = grdPerson.GetValue("EngageDate")
                    frm.lblHouseFeeCode.Text = dt_Employee.DefaultView.Item(0).Item("HouseFeeCode")
                    frm.lblFoodFeeID.Text = dt_Employee.DefaultView.Item(0).Item("FoodfeeID")
                    frm.lblMarriagefeeCode.Text = dt_Employee.DefaultView.Item(0).Item("MarriageFeeCode")
                    frm.lblSoldierID.Text = dt_Employee.DefaultView.Item(0).Item("SoldierID")
                    frm.Periodid = dt_Employee.DefaultView.Item(0).Item("PriodeID")
                    frm.txtMandegari.Text = dt_Employee.DefaultView.Item(0).Item("MandegariFee")
                    frm.lblGradeNum.Text = dt_Employee.DefaultView.Item(0).Item("GradeNum")
                    ' frm.MandegariFee = Utility1.NZ(dt_Employee.DefaultView.Item(0).Item("MandegariFee"), 0)
                    '   frm.GradeNUM_Main = Utility1.NZ(dt_Employee.DefaultView.Item(0).Item("GradeNUM"), 0)
                    frm.Vazeeiat = 1
                Else
                    MsgBox("فردي را انتخاب ننموده ايد", MsgBoxStyle.Information, "")
                    Exit Sub
                End If
                frm.lblPersonID.Text = grdPerson.GetValue("PersonID")
                frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.PersonID = grdPerson.GetValue("PersonID")
                frm.frmPRSMain1 = Me
                frm.ShowDialog()
                dt_Employee.Rows.Clear()
            ElseIf lblVazeeiat.Text.Trim = "بدو استخدام" Then
                Dim sqlstr As String
                Dim dt As New DataTable
                sqlstr = "select * from tbHR_Person where PersonCode = " & grdPerson.GetValue("PersonCode") & ""
                dt_Employee.Rows.Clear()
                dt_Employee = Persist1.GetDataTable(ConString, sqlstr)
                frm.MilitaryStateID = grdPerson.GetValue("MilitaryStateID")
                frm.txtEngageDate.Text = grdPerson.GetValue("EngageDate")
                frm.lblPersonID.Text = grdPerson.GetValue("PersonID")
                frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.PersonID = grdPerson.GetValue("PersonID")
                frm.DescribeID = 2
                sqlstr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_HouseFee"
                dt = Persist1.GetDataTable(ConString, sqlstr)
                frm.Periodid = dt.DefaultView.Item(0).Item("MAXPriodeID")
                frm.lblFoodFeeID.Text = dt.DefaultView.Item(0).Item("MAXPriodeID")
                frm.lblHouseFeeCode.Text = 0
                frm.lblMarriagefeeCode.Text = 0
                frm.lblSoldierID.Text = 0
                frm.frmPRSMain1 = Me
                frm.Vazeeiat = 1
                '  frm.MandegariFee = 0
                frm.lblGradeNum.Text = 0
                frm.ShowDialog()
                dt_Employee.Rows.Clear()
            End If
        End If
    End Sub

    Private Sub grdPerson_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPerson.CurrentCellChanged
        Dim sqlstr As String
        Dim dt_Image As New DataTable
        Try
            If grdPerson.GetValue("PersonKeyOnPost") = 1 Then
                mnuNotRegPersonKey.Enabled = True
                mnuRegPersonKey.Enabled = False
            Else
                mnuNotRegPersonKey.Enabled = False
                mnuRegPersonKey.Enabled = True
            End If


            PictureBox1.Visible = True
            sqlstr = "select PersonImage,FirstName ,LastName from tbHR_Person where PersonID = " & grdPerson.GetValue("PersonID") & ""
            dt_Image = Persist1.GetDataTable(ConString, sqlstr)
            lblname.Text = dt_Image.DefaultView.Item(0).Item("FirstName") + "  " + dt_Image.DefaultView.Item(0).Item("LastName")
            PictureBox1.Image = pic1.getImageBuffer_Load(dt_Image.DefaultView.Item(0).Item("PersonImage"))
            dt_prsImage.Rows.Clear()

        Catch ex As Exception
            PictureBox1.Image = Nothing
        End Try
        FilllblDossier()

    End Sub

    Private Sub ExplorerBar1_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ExplorerBar.ItemEventArgs) Handles ExplorerBar1.ItemClick
        Select Case e.Item.Key

            Case "btnJobRequest"
                Dim frm As New frmJobRequest
                frm.ShowDialog()


            Case "btnExit"
                Me.Close()

            Case "btnEngage"
                Dim frm As New frmNewPersonProperty
                frm.frmPRSMain1 = Me
                frm.ShowDialog()

            Case "btnHokm"
                If grdPerson.GetValue("EngageTypeID") = 3 Or grdPerson.GetValue("EngageTypeID") = 4 Or grdPerson.GetValue("EngageTypeID") = 6 Or grdPerson.GetValue("EngageTypeID") = 7 Or grdPerson.GetValue("EngageTypeID") = 8 Or grdPerson.GetValue("EngageTypeID") = 9 Or grdPerson.GetValue("EngageTypeID") = 10 Then
                    MsgBox("مجاز به انجام اين عمل نمي باشيد . لطفا از قسمت قرارداد اقدام نماييد", MsgBoxStyle.Information, "")
                    Exit Sub
                End If
                Dim frm As New frmPRSHokm
                Dim dt_Employee As New DataTable
                If grdPerson.GetValue("PersonCode") = Nothing Then
                    Exit Sub
                Else
                    If lblVazeeiat.Text.Trim = "جاري" Then
                        If grdPerson.RowCount <> 0 Then
                            dt_Employee = Bus_Employee1.GetEmployInfo(grdPerson.GetValue("PersonCode"))
                            frm.EmployeeID = dt_Employee.DefaultView.Item(0).Item("EmployeeID")
                            frm.PostID = dt_Employee.DefaultView.Item(0).Item("PostID")
                            frm.postcode = dt_Employee.DefaultView.Item(0).Item("PostCode")
                            frm.JobID = dt_Employee.DefaultView.Item(0).Item("JobTitleID")
                            frm.EngageTypeID = dt_Employee.DefaultView.Item(0).Item("EngageTypeID")
                            frm.EmployeeTypeID = dt_Employee.DefaultView.Item(0).Item("EmployTypeID")
                            frm.DescribeID = dt_Employee.DefaultView.Item(0).Item("DescribID")
                            frm.GroupID = dt_Employee.DefaultView.Item(0).Item("GroupID")
                            frm.MilitaryStateID = grdPerson.GetValue("MilitaryStateID")
                            frm.lblEmpCode.Text = Str(dt_Employee.DefaultView.Item(0).Item("EmployeeCode"))
                            frm.txtUnderTest.Text = Str(dt_Employee.DefaultView.Item(0).Item("UnderTestFee"))
                            frm.txtGroupFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("GroupFee"))
                            frm.txtSanavatFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("Sanavat"))
                            frm.txtGradeFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("GradeFee"))
                            frm.txtEmissionDate.Text = dt_Employee.DefaultView.Item(0).Item("EmissionDate")
                            frm.txtDiffer.Text = Str(dt_Employee.DefaultView.Item(0).Item("Differ"))
                            frm.txtHouseFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("HouseFee"))
                            frm.txtFoodFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("FoodFee"))
                            frm.txtMarriageFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("MarriageFee"))
                            frm.txtSoldierFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("SoldierFee"))
                            frm.txtOverJazb.Text = Str(dt_Employee.DefaultView.Item(0).Item("OverJazb"))
                            frm.txtOverPost.Text = Str(dt_Employee.DefaultView.Item(0).Item("OverPost"))
                            frm.txtBarjasteh.Text = Str(dt_Employee.DefaultView.Item(0).Item("Barjeste"))
                            frm.txtBeginEmployee.Text = dt_Employee.DefaultView.Item(0).Item("BeginDate")
                            frm.txtEndEmployee.Text = dt_Employee.DefaultView.Item(0).Item("EndDate")
                            frm.txtExecDateEmployee.Text = dt_Employee.DefaultView.Item(0).Item("ExecDate")
                            frm.lblSalary.Text = Str(dt_Employee.DefaultView.Item(0).Item("Salary"))
                            frm.txtEngageDate.Text = grdPerson.GetValue("EngageDate")
                            frm.lblHouseFeeCode.Text = dt_Employee.DefaultView.Item(0).Item("HouseFeeCode")
                            frm.lblFoodFeeID.Text = dt_Employee.DefaultView.Item(0).Item("FoodfeeID")
                            frm.lblMarriagefeeCode.Text = dt_Employee.DefaultView.Item(0).Item("MarriageFeeCode")
                            frm.lblSoldierID.Text = dt_Employee.DefaultView.Item(0).Item("SoldierID")
                            frm.Periodid = dt_Employee.DefaultView.Item(0).Item("PriodeID")

                        Else
                            MsgBox("هيچ شخصي را انتخاب نكرده ايد", MsgBoxStyle.Information, "")
                            Exit Sub
                        End If
                        frm.lblPersonID.Text = grdPerson.GetValue("PersonID")
                        frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                        frm.PersonCode = grdPerson.GetValue("PersonCode")
                        frm.PersonID = grdPerson.GetValue("PersonID")
                        frm.frmPRSMain1 = Me
                        frm.ShowDialog()
                        lblVazeeiat.Text = "جاري"
                        dt_Employee.Rows.Clear()
                    Else
                        Dim sqlstr As String
                        sqlstr = "select * from tbHR_Person where PersonCode = " & grdPerson.GetValue("PersonCode") & ""
                        dt_Employee.Rows.Clear()
                        dt_Employee = Persist1.GetDataTable(ConString, sqlstr)
                        frm.MilitaryStateID = grdPerson.GetValue("MilitaryStateID")
                        frm.txtEngageDate.Text = grdPerson.GetValue("EngageDate")
                        frm.lblPersonID.Text = grdPerson.GetValue("PersonID")
                        frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                        frm.PersonCode = grdPerson.GetValue("PersonCode")
                        frm.PersonID = grdPerson.GetValue("PersonID")
                        frm.ShowDialog()
                        FillgrdPerson(SelectStr.Current)
                        lblVazeeiat.Text = "جاري"
                        dt_Employee.Rows.Clear()
                    End If
                End If

            Case "btnMoavvaghehHokm"
                If grdPerson.GetValue("EngageTypeID") = 3 Or grdPerson.GetValue("EngageTypeID") = 4 Or grdPerson.GetValue("EngageTypeID") = 6 Or grdPerson.GetValue("EngageTypeID") = 7 Or grdPerson.GetValue("EngageTypeID") = 8 Or grdPerson.GetValue("EngageTypeID") = 9 Or grdPerson.GetValue("EngageTypeID") = 10 Then
                    MsgBox("مجاز به انجام اين عمل نمي باشيد . لطفا از قسمت قرارداد اقدام نماييد", MsgBoxStyle.Information, "")
                    Exit Sub
                End If
                Dim frm As New frmHokmMoavvagheh
                frm.PersonID = grdPerson.GetValue("PersonID")
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                frm.lblPersonName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
                frm.ShowDialog()
                FillgrdPerson(SelectStr.Current)

            Case "btnGharardad"
                If grdPerson.GetValue("EngageTypeID") = 1 Or grdPerson.GetValue("EngageTypeID") = 3 Or grdPerson.GetValue("EngageTypeID") = 6 Or grdPerson.GetValue("EngageTypeID") = 8 Or grdPerson.GetValue("EngageTypeID") = 9 Or grdPerson.GetValue("EngageTypeID") = 10 Then
                    MsgBox("مجاز به انجام اين كار نمي باشيد", MsgBoxStyle.Information, "")
                    Exit Sub
                End If
                Dim sqlstr4 As String
                Dim dt As New DataTable
                Dim sqlstr5 As String
                Dim dt_EducationControl As New DataTable
                sqlstr5 = "select * from tbHR_Education WHERE  (PersonCode = " & grdPerson.GetValue("PersonCode") & ")"
                dt_EducationControl = Persist1.GetDataTable(ConString, sqlstr5)
                If dt_EducationControl.Rows.Count = 0 Then
                    MsgBox("لطفا اطلاعات تحصيلي فرد را وارد نماييد", MsgBoxStyle.Information, "")
                    Exit Sub
                End If
                sqlstr4 = "select PersonCode from tbHR_Employee where PersonCode = " & grdPerson.GetValue("PersonCode") & ""
                dt = Persist1.GetDataTable(ConString, sqlstr4)
                If dt.Rows.Count = 0 Then
                    MsgBox("براي اين فرد حكم صادر ننموده ايد", MsgBoxStyle.Information, "")
                    Exit Sub
                End If
                If grdPerson.GetValue("EngageTypeID") = 4 Then            ''روزمزد
                    Try
                        wstr = "select * from VwHR_RptTreatyInfo where PersonCode = " & grdPerson.GetValue("PersonCode") & ""
                        rptReports = New rptDailyTreaty
                        LastRepName = ReportName
                        ReportName = "rptDailyTreaty"
                        Call rptLoad()
                    Catch ex As Exception

                    End Try
                    Exit Sub
                ElseIf grdPerson.GetValue("EngageTypeID") = 7 Then             ''مشاور يا ساعتي
                    Try
                        wstr = "select * from VwHR_RptTreatyInfo where PersonCode = " & grdPerson.GetValue("PersonCode") & ""
                        rptReports = New rptTimeTreaty
                        LastRepName = ReportName
                        ReportName = "rptTimeTreaty"
                        Call rptLoad()
                    Catch ex As Exception

                    End Try
                    Exit Sub
                Else
                    Dim dt_RptTreatyInfo As New DataTable     ''''قراردادي
                    Try
                        rptReports = New rptTreaty
                        LastRepName = ReportName
                        ReportName = "rptTreaty"
                        Call rptLoad()
                    Catch ex As Exception

                    End Try
                End If
            Case "btnPastHokm"
                Dim frm As New frmPRSPastHokm
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.ShowDialog()

            Case "btnPastjob"
                Dim frm As New frmPRSDossier
                frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.lblName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
                frm.PersonID = grdPerson.GetValue("PersonID")
                frm.ShowDialog()

            Case "btntraining"
                Dim frm As New frmPRSTraining
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                frm.lblPersonName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
                frm.PersonID = grdPerson.GetValue("PersonID")
                frm.ShowDialog()

            Case "btnEducation"
                Dim frm As New frmPRSEducation
                frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                frm.lblName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.PersonID = grdPerson.GetValue("PersonID")
                frm.ShowDialog()

            Case "btnPersonInformation"
                Dim frm As New frmPRSProperty
                Dim dt_PersonList As DataTable
                dt_prsImage.Rows.Clear()
                If grdPerson.RowCount <> 0 Then
                    frm.UiGroupBox2.Enabled = False
                    frm.btnPictureChange.Visible = False
                    frm.lblprsID.Text = grdPerson.GetValue("PersonID")
                    frm.SexID = grdPerson.GetValue("SexID")
                    frm.BirthCityCode = grdPerson.GetValue("BirthCityCode")
                    frm.BirthCityID = grdPerson.GetValue("BirthCityID")
                    frm.lblBirthCityID.Text = grdPerson.GetValue("BirthCityID")
                    frm.IssueCityCode = grdPerson.GetValue("IDIssueCode")
                    frm.IssueCityID = grdPerson.GetValue("IDIssueID")
                    frm.lblIssueCityID.Text = grdPerson.GetValue("IDIssueID")
                    frm.MilitaryID = grdPerson.GetValue("MilitaryStateID")
                    frm.EngageTypeID = grdPerson.GetValue("EngageTypeID")
                    SqlStr = "select * from VwHR_PRSEmployee Where PersonID = " & grdPerson.GetValue("PersonID") & ""
                    dt_PersonList = Persist1.GetDataTable(ConString, SqlStr)
                    frm.txtCode.Text = dt_PersonList.DefaultView.Item(0).Item("PersonCode")
                    frm.txtName.Text = dt_PersonList.DefaultView.Item(0).Item("FirstName")
                    frm.txtLName.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("LastName"), "_")
                    frm.txtFName.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("FatherName"), "_")
                    frm.txtIDNum.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("IDNum"), 0)
                    frm.txtBirthDate.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("BirthDate"), 0)
                    frm.txtNationalCode.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("NationalCode"), 0)
                    frm.txtIDSerial.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("IDSerial"), 0)
                    frm.txtEgageDate.Text = dt_PersonList.DefaultView.Item(0).Item("EngageDate")
                    frm.txtWorkID.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("WorkIDNum"), 0)
                    frm.txtAssureNum.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("AssureNum"), 0)
                    frm.txtAddress.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Address"), "_")
                    frm.txtTel.Text = dt_PersonList.DefaultView.Item(0).Item("Tel")
                    frm.txtMobile.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Mobile"), 0)
                    frm.txtPostCode.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("PostalCode"), 0)
                    dt_prsImage = Persist1.GetDataTable(ConString, "select PersonImage from tbHR_Person where PersonID = " & grdPerson.GetValue("PersonID") & " ")
                    Try
                        frm.PictureBox1.Image = pic1.getImageBuffer_Load(dt_prsImage.DefaultView.Item(0).Item("PersonImage"))
                        dt_prsImage.Rows.Clear()
                    Catch ex As Exception
                    End Try
                    frm.frmPRSMain1 = Me
                    frm.ShowDialog()
                Else
                    MsgBox("ايتمي براي نمايش موجود نمي باشد", MsgBoxStyle.Information)
                End If

            Case "btnPersonFamily"
                Dim frm As New frmPRSFamily
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.lblPersonName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
                frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                frm.PersonID = grdPerson.GetValue("PersonID")
                frm.ShowDialog()

            Case "btnVwCurrent"
                FillgrdPerson(SelectStr.Current)
                lblVazeeiat.Text = ""
                lblVazeeiat.Text = "جاري"
                ExplorerBar1.Groups.Item("grpWorking").Items("btnEngage").Enabled = True
                ExplorerBar1.Groups.Item("grpSodor").Items("btnHokm").Enabled = True
                ExplorerBar1.Groups.Item("grpSodor").Items("btnGharardad").Enabled = True
                ExplorerBar1.Groups.Item("grpHistory").Items("btnPastHokm").Enabled = True
                ExplorerBar1.Groups.Item("grpHistory").Items("btnPastjob").Enabled = True
                ExplorerBar1.Groups.Item("grpHistory").Items("btnEducation").Enabled = True
                ExplorerBar1.Groups.Item("grpHistory").Items("btnTraining").Enabled = True
                ExplorerBar1.Groups.Item("grpInformation").Items("btnPersonInformation").Enabled = True
                ExplorerBar1.Groups.Item("grpInformation").Items("btnPersonFamily").Enabled = True
                ExplorerBar1.Groups.Item("grpSodor").Items("btnMoavvaghehHokm").Enabled = True
                ExplorerBar1.Groups.Item("grpHistory").Items("btnMeed").Enabled = True

            Case "btnVwFirstEngage"
                FillgrdPerson(SelectStr.FirstEngage)
                lblVazeeiat.Text = ""
                lblVazeeiat.Text = "بدو استخدام"
                ExplorerBar1.Groups.Item("grpWorking").Items("btnEngage").Enabled = True
                ExplorerBar1.Groups.Item("grpSodor").Items("btnHokm").Enabled = True
                ExplorerBar1.Groups.Item("grpSodor").Items("btnGharardad").Enabled = True
                ExplorerBar1.Groups.Item("grpHistory").Items("btnPastHokm").Enabled = False
                ExplorerBar1.Groups.Item("grpHistory").Items("btnPastjob").Enabled = True
                ExplorerBar1.Groups.Item("grpHistory").Items("btnEducation").Enabled = True
                ExplorerBar1.Groups.Item("grpHistory").Items("btnTraining").Enabled = True
                ExplorerBar1.Groups.Item("grpInformation").Items("btnPersonInformation").Enabled = False
                ExplorerBar1.Groups.Item("grpInformation").Items("btnPersonFamily").Enabled = True
                ExplorerBar1.Groups.Item("grpSodor").Items("btnMoavvaghehHokm").Enabled = False
                ExplorerBar1.Groups.Item("grpHistory").Items("btnMeed").Enabled = True

            Case "btnNoCurrent"
                FillgrdPerson(SelectStr.NotCurrent)
                lblVazeeiat.Text = ""
                lblVazeeiat.Text = "غيرجاري"
                ExplorerBar1.Groups.Item("grpWorking").Items("btnEngage").Enabled = False
                ExplorerBar1.Groups.Item("grpSodor").Items("btnHokm").Enabled = False
                ExplorerBar1.Groups.Item("grpSodor").Items("btnGharardad").Enabled = False
                ExplorerBar1.Groups.Item("grpHistory").Items("btnPastHokm").Enabled = False
                ExplorerBar1.Groups.Item("grpHistory").Items("btnPastjob").Enabled = False
                ExplorerBar1.Groups.Item("grpHistory").Items("btnEducation").Enabled = False
                ExplorerBar1.Groups.Item("grpHistory").Items("btnTraining").Enabled = False
                ExplorerBar1.Groups.Item("grpInformation").Items("btnPersonInformation").Enabled = False
                ExplorerBar1.Groups.Item("grpInformation").Items("btnPersonFamily").Enabled = False
                ExplorerBar1.Groups.Item("grpSodor").Items("btnMoavvaghehHokm").Enabled = False
                ExplorerBar1.Groups.Item("grpHistory").Items("btnMeed").Enabled = False




            Case "btnVwAll"
                FillgrdPerson(SelectStr.All)
                lblVazeeiat.Text = ""
                lblVazeeiat.Text = "همه"
                ExplorerBar1.Groups.Item("grpWorking").Items("btnEngage").Enabled = False
                ExplorerBar1.Groups.Item("grpSodor").Items("btnHokm").Enabled = False
                ExplorerBar1.Groups.Item("grpSodor").Items("btnGharardad").Enabled = False
                ExplorerBar1.Groups.Item("grpHistory").Items("btnPastHokm").Enabled = False
                ExplorerBar1.Groups.Item("grpHistory").Items("btnPastjob").Enabled = False
                ExplorerBar1.Groups.Item("grpHistory").Items("btnEducation").Enabled = False
                ExplorerBar1.Groups.Item("grpHistory").Items("btnTraining").Enabled = False
                ExplorerBar1.Groups.Item("grpInformation").Items("btnPersonInformation").Enabled = False
                ExplorerBar1.Groups.Item("grpInformation").Items("btnPersonFamily").Enabled = False
                ExplorerBar1.Groups.Item("grpSodor").Items("btnMoavvaghehHokm").Enabled = False
                ExplorerBar1.Groups.Item("grpHistory").Items("btnMeed").Enabled = False

            Case "btnMeed"
                Dim frm As New frmPRSMeed
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                frm.lblName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
                frm.ShowDialog()

            Case "btnSocialHokm"
                Dim frm As New frmPRSHokmsocial
                frm.frmPRSMain1 = Me
                frm.ShowDialog()
        End Select
    End Sub

    Private Sub lblVazeeiat_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If lblVazeeiat.Text.Trim = "جاري" Then
            PictureBox1.Visible = True
            lblname.Visible = True
            cmsgrdPerson.Enabled = True
            tsmGharardad.Enabled = True
            tsmPersonInformation.Enabled = True
            tsmInformation.Enabled = True
            tsmHistory.Enabled = True
            tsmPersonHokmMoavvaghe.Enabled = True
            tsmHokmHistory.Enabled = True

        ElseIf lblVazeeiat.Text.Trim = "بدو استخدام" Then
            PictureBox1.Visible = False
            lblname.Visible = False
            cmsgrdPerson.Enabled = True
            tsmGharardad.Enabled = True
            tsmInformation.Enabled = True
            tsmHistory.Enabled = True
            tsmHokmHistory.Enabled = False
            tsmPersonInformation.Enabled = False
            tsmPersonHokmMoavvaghe.Enabled = False

        ElseIf lblVazeeiat.Text.Trim = "غيرجاري" Then
            PictureBox1.Visible = False
            lblname.Visible = False
            cmsgrdPerson.Enabled = False
            tsmPersonHokmMoavvaghe.Enabled = False

        ElseIf lblVazeeiat.Text.Trim = "همه" Then
            PictureBox1.Visible = True
            lblname.Visible = True
            cmsgrdPerson.Enabled = False
            tsmPersonHokmMoavvaghe.Enabled = False
        End If
    End Sub

    Private Sub tsmPersonHokmMoavvaghe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmPersonHokmMoavvaghe.Click
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("شما به اين نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Me.Close()
        ElseIf Activity1.CheckUserAccess(54, 730, LogID) = True Then
            'ExplorerBar1.Groups.Item("ManageMent").Visible = True
            'End If
        ElseIf Activity1.CheckUserAccess(54, 733, LogID) = True Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        ''''طبق درخواست آقاي نبيزاده درتاريخ13900331 پرسنل ازمايشي هم ميتوانند حكم معوقه داغشته باشند
        ''''Or grdPerson.GetValue("EngageTypeID") = 5
        If grdPerson.GetValue("EngageTypeID") = 3 Or grdPerson.GetValue("EngageTypeID") = 4 Or grdPerson.GetValue("EngageTypeID") = 6 Or grdPerson.GetValue("EngageTypeID") = 7 Or grdPerson.GetValue("EngageTypeID") = 8 Or grdPerson.GetValue("EngageTypeID") = 9 Or grdPerson.GetValue("EngageTypeID") = 10 Then
            MsgBox("مجاز به انجام اين عمل نمي باشيد . لطفا از قسمت قرارداد اقدام نماييد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If grdPerson.GetValue("PersonID") = Nothing Then
            Exit Sub
        Else
            Dim frm As New frmHokmMoavvagheh
            frm.PersonID = grdPerson.GetValue("PersonID")
            frm.PersonCode = grdPerson.GetValue("PersonCode")
            frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
            frm.lblPersonName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
            frm.ShowDialog()
        End If
    End Sub

    Private Sub tsmMeedHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmMeedHistory.Click
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Exit Sub
            '''''دسترسي آموزش
        ElseIf Activity1.CheckUserAccess(54, 735, LogID) = True Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
        ElseIf Activity1.CheckUserAccess(54, 950, LogID) = True Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
        ElseIf Activity1.CheckUserAccess(54, 1019, LogID) = True Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        Dim frm As New frmPRSMeed
        frm.PersonCode = grdPerson.GetValue("PersonCode")
        frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
        frm.lblPersonID.Text = grdPerson.GetValue("PersonID")
        frm.lblName.Text = grdPerson.GetValue("FirstName") + "  " + grdPerson.GetValue("LastName")
        frm.ShowDialog()
    End Sub

    Private Sub tsmHokmRoozMozd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmHokmRoozMozd.Click
        Dim dt As New DataTable
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("شما به اين نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Me.Close()
        ElseIf Activity1.CheckUserAccess(54, 730, LogID) = True Then
            'ExplorerBar1.Groups.Item("ManageMent").Visible = True
            'End If
        ElseIf Activity1.CheckUserAccess(54, 733, LogID) = True Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        Try
            If grdPerson.GetValue("EngageTypeID") = 1 Or grdPerson.GetValue("EngageTypeID") = 3 Or grdPerson.GetValue("EngageTypeID") = 6 Or grdPerson.GetValue("EngageTypeID") = 8 Or grdPerson.GetValue("EngageTypeID") = 9 Or grdPerson.GetValue("EngageTypeID") = 10 Then
                MsgBox("مجاز به انجام اين عمل نمي باشيد", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        Catch ex As Exception

        End Try

        Dim frm As New frmPRSHokmSaati
        Dim dt_Employee As New DataTable
        If grdPerson.GetValue("PersonCode") = Nothing Then
            Exit Sub
        Else
            If lblVazeeiat.Text.Trim = "جاري" Then
                If grdPerson.RowCount <> 0 Then
                    dt_Employee = Bus_Employee1.GetEmployInfo(grdPerson.GetValue("PersonCode"))
                    frm.EmployeeID = dt_Employee.DefaultView.Item(0).Item("EmployeeID")
                    frm.PostID = dt_Employee.DefaultView.Item(0).Item("PostID")
                    frm.postcode = dt_Employee.DefaultView.Item(0).Item("PostCode")
                    frm.EngageID = dt_Employee.DefaultView.Item(0).Item("EngageTypeID")
                    frm.DescribeID = dt_Employee.DefaultView.Item(0).Item("DescribID")
                    frm.GroupID = dt_Employee.DefaultView.Item(0).Item("GroupID")
                    frm.MilitaryStateID = grdPerson.GetValue("MilitaryStateID")
                    frm.lblEmpCode.Text = Str(dt_Employee.DefaultView.Item(0).Item("EmployeeCode"))
                    frm.txtSanavatFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("Sanavat"))
                    frm.txtGradeFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("GradeFee"))
                    frm.txtEmissionDate.Text = dt_Employee.DefaultView.Item(0).Item("EmissionDate")
                    frm.lblEmissionDate.Text = dt_Employee.DefaultView.Item(0).Item("EmissionDate")
                    frm.txtDiffer.Text = Str(dt_Employee.DefaultView.Item(0).Item("Differ"))
                    frm.txtHouseFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("HouseFee"))
                    frm.txtFoodFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("FoodFee"))
                    frm.txtMarriageFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("MarriageFee"))
                    frm.txtSoldierFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("SoldierFee"))
                    frm.txtOverJazb.Text = Str(dt_Employee.DefaultView.Item(0).Item("OverJazb"))
                    frm.txtOverPost.Text = Str(dt_Employee.DefaultView.Item(0).Item("OverPost"))
                    frm.txtBarjasteh.Text = Str(dt_Employee.DefaultView.Item(0).Item("Barjeste"))
                    frm.txtBeginEmployee.Text = dt_Employee.DefaultView.Item(0).Item("BeginDate")
                    frm.lblBeginDate.Text = dt_Employee.DefaultView.Item(0).Item("BeginDate")
                    frm.txtEndEmployee.Text = dt_Employee.DefaultView.Item(0).Item("EndDate")
                    frm.lblEndDate.Text = dt_Employee.DefaultView.Item(0).Item("EndDate")
                    frm.txtExecDateEmployee.Text = dt_Employee.DefaultView.Item(0).Item("ExecDate")
                    frm.lblSalary.Text = Str(dt_Employee.DefaultView.Item(0).Item("Salary"))
                    frm.txtEngageDate.Text = grdPerson.GetValue("EngageDate")
                    frm.lblHouseFeeCode.Text = dt_Employee.DefaultView.Item(0).Item("HouseFeeCode")
                    frm.lblFoodFeeID.Text = dt_Employee.DefaultView.Item(0).Item("FoodfeeID")
                    frm.lblMarriagefeeCode.Text = dt_Employee.DefaultView.Item(0).Item("MarriageFeeCode")
                    frm.lblSoldierID.Text = dt_Employee.DefaultView.Item(0).Item("SoldierID")
                    frm.txtAmount.Text = Utility1.NZ(dt_Employee.DefaultView.Item(0).Item("DayAmountFee"), 0)
                    frm.lblHouseFeeCode.Text = dt_Employee.DefaultView.Item(0).Item("HouseFeeCode")
                    frm.lblFoodFeeID.Text = dt_Employee.DefaultView.Item(0).Item("FoodfeeID")
                    frm.lblMarriagefeeCode.Text = dt_Employee.DefaultView.Item(0).Item("MarriageFeeCode")
                    frm.lblSoldierID.Text = dt_Employee.DefaultView.Item(0).Item("SoldierID")
                    frm.Periodid = dt_Employee.DefaultView.Item(0).Item("PriodeID")
                    frm.Text = "صدور قرارداد پرسنل روز مزد"
                    frm.EngageTypeID = 4
                Else
                    MsgBox("فردي را انتخاب ننموده ايد", MsgBoxStyle.Information, "")
                    Exit Sub
                End If
                frm.lblPersonID.Text = grdPerson.GetValue("PersonID")
                frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.PersonID = grdPerson.GetValue("PersonID")
                frm.frmPRSMain1 = Me
                frm.ShowDialog()
                dt_Employee.Rows.Clear()
            ElseIf lblVazeeiat.Text.Trim = "بدو استخدام" Then
                Dim sqlstr As String
                sqlstr = "select * from tbHR_Person where PersonCode = " & grdPerson.GetValue("PersonCode") & ""
                dt_Employee.Rows.Clear()
                dt_Employee = Persist1.GetDataTable(ConString, sqlstr)
                frm.MilitaryStateID = grdPerson.GetValue("MilitaryStateID")
                frm.txtEngageDate.Text = grdPerson.GetValue("EngageDate")
                frm.lblPersonID.Text = grdPerson.GetValue("PersonID")
                frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.PersonID = grdPerson.GetValue("PersonID")
                frm.DescribeID = 2
                sqlstr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_HouseFee"
                dt = Persist1.GetDataTable(ConString, sqlstr)
                frm.Periodid = dt.DefaultView.Item(0).Item("MAXPriodeID")
                frm.lblFoodFeeID.Text = dt.DefaultView.Item(0).Item("MAXPriodeID")
                frm.lblHouseFeeCode.Text = 0
                frm.lblMarriagefeeCode.Text = 0
                frm.lblSoldierID.Text = 0
                frm.frmPRSMain1 = Me
                frm.EngageTypeID = 4
                frm.Text = "صدور قرارداد پرسنل روز مزد"
                frm.ShowDialog()
                dt_Employee.Rows.Clear()
            End If
        End If
    End Sub

    Private Sub tsmHokmMoshverehSaati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmHokmMoshverehSaati.Click
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("شما به اين نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Me.Close()
        ElseIf Activity1.CheckUserAccess(54, 730, LogID) = True Then
            'ExplorerBar1.Groups.Item("ManageMent").Visible = True
            'End If
        ElseIf Activity1.CheckUserAccess(54, 733, LogID) = True Then
            MsgBox("شما به اين قسمت نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        Try
            If grdPerson.GetValue("EngageTypeID") = 1 Or grdPerson.GetValue("EngageTypeID") = 3 Or grdPerson.GetValue("EngageTypeID") = 6 Or grdPerson.GetValue("EngageTypeID") = 8 Or grdPerson.GetValue("EngageTypeID") = 9 Or grdPerson.GetValue("EngageTypeID") = 10 Then
                MsgBox("مجاز به انجام اين عمل نمي باشيد", MsgBoxStyle.Information, "")
                Exit Sub
            End If
        Catch ex As Exception

        End Try

        Dim frm As New frmPRSHokmSaati
        Dim dt_Employee As New DataTable
        If grdPerson.GetValue("PersonCode") = Nothing Then
            Exit Sub
        Else
            If lblVazeeiat.Text.Trim = "جاري" Then
                If grdPerson.RowCount <> 0 Then
                    dt_Employee = Bus_Employee1.GetEmployInfo(grdPerson.GetValue("PersonCode"))
                    frm.EmployeeID = dt_Employee.DefaultView.Item(0).Item("EmployeeID")
                    frm.PostID = dt_Employee.DefaultView.Item(0).Item("PostID")
                    frm.postcode = dt_Employee.DefaultView.Item(0).Item("PostCode")
                    frm.EngageID = dt_Employee.DefaultView.Item(0).Item("EngageTypeID")
                    frm.DescribeID = dt_Employee.DefaultView.Item(0).Item("DescribID")
                    frm.GroupID = dt_Employee.DefaultView.Item(0).Item("GroupID")
                    frm.MilitaryStateID = grdPerson.GetValue("MilitaryStateID")
                    frm.lblEmpCode.Text = Str(dt_Employee.DefaultView.Item(0).Item("EmployeeCode"))
                    frm.txtSanavatFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("Sanavat"))
                    frm.txtGradeFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("GradeFee"))
                    frm.txtEmissionDate.Text = dt_Employee.DefaultView.Item(0).Item("EmissionDate")
                    frm.txtDiffer.Text = Str(dt_Employee.DefaultView.Item(0).Item("Differ"))
                    frm.txtHouseFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("HouseFee"))
                    frm.txtFoodFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("FoodFee"))
                    frm.txtMarriageFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("MarriageFee"))
                    frm.txtSoldierFee.Text = Str(dt_Employee.DefaultView.Item(0).Item("SoldierFee"))
                    frm.txtOverJazb.Text = Str(dt_Employee.DefaultView.Item(0).Item("OverJazb"))
                    frm.txtOverPost.Text = Str(dt_Employee.DefaultView.Item(0).Item("OverPost"))
                    frm.txtBarjasteh.Text = Str(dt_Employee.DefaultView.Item(0).Item("Barjeste"))
                    frm.txtBeginEmployee.Text = dt_Employee.DefaultView.Item(0).Item("BeginDate")
                    frm.lblBeginDate.Text = dt_Employee.DefaultView.Item(0).Item("BeginDate")
                    frm.lblEndDate.Text = dt_Employee.DefaultView.Item(0).Item("EndDate")
                    frm.txtEndEmployee.Text = dt_Employee.DefaultView.Item(0).Item("EndDate")
                    frm.txtExecDateEmployee.Text = dt_Employee.DefaultView.Item(0).Item("ExecDate")
                    frm.lblSalary.Text = Str(dt_Employee.DefaultView.Item(0).Item("Salary"))
                    frm.txtEngageDate.Text = grdPerson.GetValue("EngageDate")
                    frm.txtAmount.Text = Utility1.NZ(dt_Employee.DefaultView.Item(0).Item("TimeAmountFee"), 0)
                    frm.EngageTypeID = 7
                    frm.lblHouseFeeCode.Text = dt_Employee.DefaultView.Item(0).Item("HouseFeeCode")
                    frm.lblFoodFeeID.Text = dt_Employee.DefaultView.Item(0).Item("FoodfeeID")
                    frm.lblMarriagefeeCode.Text = dt_Employee.DefaultView.Item(0).Item("MarriageFeeCode")
                    frm.lblSoldierID.Text = dt_Employee.DefaultView.Item(0).Item("SoldierID")
                    frm.Periodid = dt_Employee.DefaultView.Item(0).Item("PriodeID")
                    frm.Text = "ثبت قرارداد پرسنل ساعتي/مشاوره"
                Else
                    MsgBox("فردي را انتخاب ننموده ايد", MsgBoxStyle.Information, "")
                    Exit Sub
                End If
                frm.lblPersonID.Text = grdPerson.GetValue("PersonID")
                frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.PersonID = grdPerson.GetValue("PersonID")
                frm.frmPRSMain1 = Me
                frm.ShowDialog()
                dt_Employee.Rows.Clear()
            ElseIf lblVazeeiat.Text.Trim = "بدو استخدام" Then
                Dim dt As New DataTable
                Dim sqlstr As String
                sqlstr = "select * from tbHR_Person where PersonCode = " & grdPerson.GetValue("PersonCode") & ""
                dt_Employee.Rows.Clear()
                dt_Employee = Persist1.GetDataTable(ConString, sqlstr)
                frm.MilitaryStateID = grdPerson.GetValue("MilitaryStateID")
                frm.txtEngageDate.Text = grdPerson.GetValue("EngageDate")
                frm.lblPersonID.Text = grdPerson.GetValue("PersonID")
                frm.lblPersonCode.Text = grdPerson.GetValue("PersonCode")
                frm.PersonCode = grdPerson.GetValue("PersonCode")
                frm.PersonID = grdPerson.GetValue("PersonID")
                frm.DescribeID = 2
                sqlstr = "SELECT MAX(PeriodID) AS MAXPriodeID FROM  tbHR_HouseFee"
                dt = Persist1.GetDataTable(ConString, sqlstr)
                frm.Periodid = dt.DefaultView.Item(0).Item("MAXPriodeID")
                frm.lblFoodFeeID.Text = dt.DefaultView.Item(0).Item("MAXPriodeID")
                frm.lblHouseFeeCode.Text = 0
                frm.lblMarriagefeeCode.Text = 0
                frm.lblSoldierID.Text = 0
                frm.frmPRSMain1 = Me
                frm.EngageTypeID = 7
                frm.Text = "ثبت قرارداد پرسنل ساعتي/مشاوره"
                frm.ShowDialog()
                dt_Employee.Rows.Clear()
            End If
        End If
    End Sub

    Private Sub tsmPrintHokm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmPrintHokm.Click
        Dim dt1 As New DataTable
        If grdPerson.GetValue("EngageTypeID") = 3 Or grdPerson.GetValue("EngageTypeID") = 4 Or grdPerson.GetValue("EngageTypeID") = 6 Or grdPerson.GetValue("EngageTypeID") = 8 Or grdPerson.GetValue("EngageTypeID") = 9 Or grdPerson.GetValue("EngageTypeID") = 10 Then
            MsgBox("مجاز به انجام اين كار نمي باشيد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        Dim sqlstr4 As String
        Dim dt As New DataTable
        Dim sqlstr5 As String
        Dim dt_EducationControl As New DataTable
        sqlstr5 = "select * from tbHR_Education WHERE  (PersonCode = " & grdPerson.GetValue("PersonCode") & ")"
        dt_EducationControl = Persist1.GetDataTable(ConString, sqlstr5)
        If dt_EducationControl.Rows.Count = 0 Then
            MsgBox("لطفا اطلاعات تحصيلي فرد را وارد نماييد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        sqlstr4 = "select PersonCode from tbHR_Employee where PersonCode = " & grdPerson.GetValue("PersonCode") & ""
        dt = Persist1.GetDataTable(ConString, sqlstr4)
        If dt.Rows.Count = 0 Then
            MsgBox("براي اين فرد حكم صادر ننموده ايد", MsgBoxStyle.Information, "")
            Exit Sub
            End If
        If grdPerson.GetValue("EngageTypeID") = 7 Or grdPerson.GetValue("EngageTypeID") = 4 Then
            MsgBox("براي اين فرد قرارداد صادر نماييد", MsgBoxStyle.Information, "")
            Exit Sub
            End If
        Try
            wstr = "select * from VwHR_RptHokmInfo where PersonCode =  " & grdPerson.GetValue("PersonCode") & " AND (EmployeeActive = 1) "
            ' wstr = "select * from Asghari_Tabaghae where PersonCode =  " & grdPerson.GetValue("PersonCode") & " AND (EmployeeActive = 1) "


            'rptReports = New rptHokm
            'LastRepName = ReportName
            'ReportName = "rptHokm"

            rptReports = New rptHokmTabaghebandiiiiii
            LastRepName = ReportName
            ReportName = "rptHokmTabaghebandiiiiii"


            dt1 = Persist1.GetDataTable(ConString, wstr)
            SumAllSalary = Decimal.Round(dt1.DefaultView.Item(0).Item("Barjeste") + dt1.DefaultView.Item(0).Item("TafavoteHoghogh") + dt1.DefaultView.Item(0).Item("Differ") + dt1.DefaultView.Item(0).Item("MandegariFee") + dt1.DefaultView.Item(0).Item("BON") + dt1.DefaultView.Item(0).Item("Sanavat") + dt1.DefaultView.Item(0).Item("OverPost") + dt1.DefaultView.Item(0).Item("OverJazb") + dt1.DefaultView.Item(0).Item("FoodFee") + dt1.DefaultView.Item(0).Item("SoldierFee") + dt1.DefaultView.Item(0).Item("MarriageFee") + dt1.DefaultView.Item(0).Item("HouseFee") + dt1.DefaultView.Item(0).Item("GradeFee") + dt1.DefaultView.Item(0).Item("UnderTestFee") + dt1.DefaultView.Item(0).Item("GroupFee") + dt1.DefaultView.Item(0).Item("janbazi"))

            Call rptLoad()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsmGharardadFardi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmGharardadFardi.Click
        If grdPerson.GetValue("EngageTypeID") = 1 Or grdPerson.GetValue("EngageTypeID") = 3 Or grdPerson.GetValue("EngageTypeID") = 6 Or grdPerson.GetValue("EngageTypeID") = 8 Or grdPerson.GetValue("EngageTypeID") = 9 Or grdPerson.GetValue("EngageTypeID") = 10 Then
            MsgBox("مجاز به انجام اين كار نمي باشيد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        Dim sqlstr4 As String
        Dim dt As New DataTable
        Dim sqlstr5 As String
        Dim dt_EducationControl As New DataTable
        sqlstr5 = "select * from tbHR_Education WHERE  (PersonCode = " & grdPerson.GetValue("PersonCode") & ")"
        dt_EducationControl = Persist1.GetDataTable(ConString, sqlstr5)
        If dt_EducationControl.Rows.Count = 0 Then
            MsgBox("لطفا اطلاعات تحصيلي فرد را وارد نماييد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        sqlstr4 = "select PersonCode from tbHR_Employee where PersonCode = " & grdPerson.GetValue("PersonCode") & ""
        dt = Persist1.GetDataTable(ConString, sqlstr4)
        If dt.Rows.Count = 0 Then
            MsgBox("براي اين فرد حكم صادر ننموده ايد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        sqlstr4 = ""
        sqlstr4 = "SELECT     *   FROM tbHR_Education    WHERE(PersonCode = " & grdPerson.GetValue("PersonCode") & ")"
        dt.Rows.Clear()
        dt = Persist1.GetDataTable(ConString, sqlstr4)
        If dt.Rows.Count = 0 Then
            MsgBox("براي اين فرد اطلاعات تحصيلي وارد ننموده ايد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If grdPerson.GetValue("EngageTypeID") = 4 Then            ''روزمزد
            Try
                wstr = "select * from VwHR_RptTreatyInfo where PersonCode = " & grdPerson.GetValue("PersonCode") & ""
                rptReports = New rptDailyTreaty
                LastRepName = ReportName
                ReportName = "rptDailyTreaty"
                Call rptLoad()
            Catch ex As Exception

            End Try
            Exit Sub
        ElseIf grdPerson.GetValue("EngageTypeID") = 7 Then             ''مشاور يا ساعتي
            Try
                wstr = "select * from VwHR_RptTreatyInfo where PersonCode = " & grdPerson.GetValue("PersonCode") & ""
                rptReports = New rptTimeTreaty
                LastRepName = ReportName
                ReportName = "rptTimeTreaty"
                Call rptLoad()
            Catch ex As Exception

            End Try
            Exit Sub
        Else
            Dim dt_RptTreatyInfo As New DataTable        ''''قراردادي
            Try
                wstr = "select * from VwHR_RptTreatyInfo where PersonCode = " & grdPerson.GetValue("PersonCode") & ""
                rptReports = New rptTreaty
                LastRepName = ReportName
                ReportName = "rptTreaty"
                Call rptLoad()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub rptLoad()
        Try
            If dsReports.Tables.Count > 0 Then
                dsReports.Tables(LastRepName).Clear()
            End If
            DA1 = Persist1.GetDataAccess(wstr, 1, ConString, ReportName, dsReports)
            Dim f1 As New frmReport

            If ReportName = "rptHokm" Or ReportName = "rptHokmTabaghebandiiiiii" Then
                f1.CurDate = IraniDate1.GetIraniDayName_CurDate + "  " + IraniDate1.GetIrani8DateStr_CurDate
                f1.SumAllSalary = SumAllSalary

            ElseIf ReportName = "rptDailyTreaty" Then
                f1.MarriageType = MarriageType
                f1.DateCount = DayCount

            ElseIf ReportName = "rptTimeTreaty" Then
                f1.MarriageType = MarriageType
                f1.DateCount = DayCount

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

    Private Sub grdPerson_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdPerson.KeyPress
        janus1.BindJanusNavigator(grdPerson, dt_Person)
    End Sub

    Private Sub tsmHerasat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmHerasat.Click
        Dim frm As New frmHerasat
        Dim dt_PersonList As DataTable
        frm.LBLPERSONCODE.Text = grdPerson.GetValue("PersonCode")
        frm.lblPRSONID.Text = grdPerson.GetValue("PersonID")
        dt_prsImage.Rows.Clear()
        If grdPerson.RowCount <> 0 Then
            frm.lblprsID.Text = grdPerson.GetValue("PersonID")
            'frm.lblPRSONID.Text = grdPerson.GetValue("PersonID")
            frm.SexID = grdPerson.GetValue("SexID")
            frm.BirthCityCode = grdPerson.GetValue("BirthCityCode")
            frm.BirthCityID = grdPerson.GetValue("BirthCityID")
            frm.lblBirthCityID.Text = grdPerson.GetValue("BirthCityID")
            frm.IssueCityCode = grdPerson.GetValue("IDIssueCode")
            frm.IssueCityID = grdPerson.GetValue("IDIssueID")
            frm.lblIssueCityID.Text = grdPerson.GetValue("IDIssueID")
            frm.MilitaryID = grdPerson.GetValue("MilitaryStateID")
            frm.EngageTypeID = grdPerson.GetValue("EngageTypeID")
            SqlStr = "select * from VwHR_PRSEmployee Where PersonID = " & grdPerson.GetValue("PersonID") & ""
            dt_PersonList = Persist1.GetDataTable(ConString, SqlStr)
            frm.txtCode.Text = dt_PersonList.DefaultView.Item(0).Item("PersonCode")
            frm.txtCardNom.Text = dt_PersonList.DefaultView.Item(0).Item("CardNumber")
            'frm.LBLPERSONCODE.Text = dt_PersonList.DefaultView.Item(0).Item("PersonCode")
            'frm.txtPersoncode.Text = dt_PersonList.DefaultView.Item(0).Item("PersonCode")
            frm.txtName.Text = dt_PersonList.DefaultView.Item(0).Item("FirstName")
            frm.txtLName.Text = dt_PersonList.DefaultView.Item(0).Item("LastName")
            frm.txtFName.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("FatherName"), "_")
            frm.txtIDNum.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("IDNum"), 0)
            frm.txtBirthDate.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("BirthDate"), 0)
            frm.txtNationalCode.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("NationalCode"), 0)
            frm.txtIDSerial.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("IDSerial"), 0)
            frm.txtEgageDate.Text = dt_PersonList.DefaultView.Item(0).Item("EngageDate")
            frm.txtAddress.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Address"), "_")
            frm.txtTel.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Tel"), 0)
            frm.txtMobile.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Mobile"), 0)
            frm.txtPostCode.Text = dt_PersonList.DefaultView.Item(0).Item("PostalCode")
            frm.txtParvandeNum.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("ParvandeNum"), 0)
            frm.txtMostaarName.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("MostaarName"), "")
            frm.txtOldLastName.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("OldLastName"), "")
            frm.txtTabeeaiat.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Tabeeiat"), "")
            frm.din = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Din"), 0)
            frm.txtMazhab.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Mazhab"), "")
            frm.txtParvandehCount.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("ParvandeCount"), 0)
            frm.txtupdateTime.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("UpdateTime"), "")
            frm.txtLength.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Length"), 0)
            frm.txtWeight.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("Weight"), 0)
            frm.HairColor = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("HairColor"), 0)
            frm.EyeColor = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("EyeColor"), 0)
            frm.FaceColor = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("FaceColor"), 0)
            frm.txtSocialSymbol.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("SpecificSymbol"), "")
            frm.txtOldAddress1.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("OldAddress"), "")
            frm.txtOldAddress2.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("OldAddress2"), "")
            frm.txtOldAddress3.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("OldAddress3"), "")
            frm.txtOldAddress4.Text = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("OldAddress4"), "")
            frm.cmbDin.SelectedValue = Utility1.NZ(dt_PersonList.DefaultView.Item(0).Item("din"), "")

            dt_prsImage = Persist1.GetDataTable(ConString, "select PersonImage from tbHR_Person where PersonID = " & grdPerson.GetValue("PersonID") & " ")
            Try
                frm.PictureBox1.Image = pic1.getImageBuffer_Load(dt_prsImage.DefaultView.Item(0).Item("PersonImage"))
                dt_prsImage.Rows.Clear()
            Catch ex As Exception
            End Try
            frm.frmPRSMain1 = Me
            frm.ShowDialog()
        Else
            MsgBox("ايتمي براي نمايش موجود نمي باشد", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub tsmGeneralrpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmGeneralrpt.Click
        wstr = _
                   "SELECT     *   " & _
                   " FROM         VwHR_PersonProperty " & _
                   " WHERE (PersonCode = " & grdPerson.GetValue("PersonCode") & ") "
        rptReports = New rptGeneralAbstract
        LastRepName = ReportName
        ReportName = "rptGeneralAbstract"
        Call rptLoad()
    End Sub

    Private Sub Tsmjari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tsmjari.Click
        Dim x As String
        x = "update tbHR_Employee set [Active]=1 where PersonCode = " & grdPerson.GetValue("PersonCode") & " "
        ' Persist1.GetDataTable(ConString,)
    End Sub

    Private Sub grdPerson_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles grdPerson.FormattingRow

    End Sub

    Private Sub mnuRegPersonKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegPersonKey.Click
        SqlStr = "update tbHR_Person set PersonKeyOnPost=1 where PersonCode = " & grdPerson.GetValue("PersonCode")
        Persist1.GetDataAccess(SqlStr, 2, ConString)
    End Sub

    Private Sub mnuNotRegPersonKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNotRegPersonKey.Click
        SqlStr = "update tbHR_Person set PersonKeyOnPost=0 where PersonCode = " & grdPerson.GetValue("PersonCode")
        Persist1.GetDataAccess(SqlStr, 2, ConString)
    End Sub

    Private Sub mnuPersEzafe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub mnuKholaseRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuKholaseRep.Click
        wstr = "select * from VwHR_PersonProperty where PersonCode = " & grdPerson.GetValue("PersonCode") & ""

        rptReports = New rptGeneralAbstract
        LastRepName = ReportName
        ReportName = "rptGeneralAbstract"
        Call rptLoad()

        wstr = "select * from VwHR_Employee where PersonCode = " & grdPerson.GetValue("PersonCode") & ""

        rptReports = New RptSavabeghHokm
        LastRepName = ReportName
        ReportName = "RptSavabeghHokm"
        Call rptLoad()

        'wstr = " SELECT     *  FROM         Training.dbo.fnTRNPersonCourse(" & grdPerson.GetValue("PersonCode") & ") AS fnTRNPersonCourse_1"

        'rptReports = New RptPersonCourse
        'LastRepName = ReportName
        'ReportName = "RptPersonCourse"
        'Call rptLoad()

    End Sub

 
    Private Sub tsmPezeshki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmPezeshki.Click
        Dim frm As New FrmPezeshki
        frm.personPezeshkiCode = grdPerson.GetValue("PersonCode")
        frm.ShowDialog()
    End Sub

    Private Sub mnuSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSale.Click
        If Activity1.CheckUserAccess(54, 1032, LogID) = True Then
            Dim frm As New frmPassForSale
            frm.PrCode = grdPerson.GetValue("PersonCode")
            frm.ShowDialog()
        End If

    End Sub

    Private Sub لیستاولادبالای18سالToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles لیستاولادبالای18سالToolStripMenuItem.Click
        If Activity1.CheckUserAccess(54, 1064, LogID) = True Then
            Dim frm As New FrmOlad_18
            frm.ShowDialog()
        End If
    End Sub
End Class
'Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'    Dim column As Janus.Windows.GridEX.GridEXColumn

'    column = grdPerson.RootTable.Columns("LastName")

'    Me.grdPerson.Find(column, Janus.Windows.GridEX.ConditionOperator.Equal, Me.txtSearch.Text, -1, 1)

'End Sub

'Private Sub grdPerson_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPerson.DoubleClick
'    Dim frm As New frmPRSProperty
'    Dim dt_PersonList As DataTable
'    If grdPerson.RowCount <> 0 Then
'        frm.UiGroupBox2.Enabled = False
'        frm.btnSave.Visible = False
'        frm.btnPictureChange.Visible = False
'        frm.lblprsID.Text = grdPerson.GetValue("PrsID")
'        frm.SexID = grdPerson.GetValue("SexID")
'        frm.BirthCityID = grdPerson.GetValue("BirthCityID")
'        frm.IDIssueID = grdPerson.GetValue("IDIssueID")
'        frm.MilitaryID = grdPerson.GetValue("MilitaryID")
'        frm.EngageID = grdPerson.GetValue("EngageTypeID")
'        SqlStr = "select * from VwHR_PRSEmployee Where PrsID = " & grdPerson.GetValue("PrsID") & " "
'        dt_PersonList = Persist1.GetDataTable(ConString, SqlStr)
'        frm.txtCode.Text = dt_PersonList.DefaultView.Item(0).Item("PersonCode")
'        frm.txtName.Text = dt_PersonList.DefaultView.Item(0).Item("FirstName")
'        frm.txtLName.Text = dt_PersonList.DefaultView.Item(0).Item("LastName")
'        frm.txtFName.Text = dt_PersonList.DefaultView.Item(0).Item("FatherName")
'        frm.txtIDNum.Text = dt_PersonList.DefaultView.Item(0).Item("IDNum")
'        frm.txtBirthDate.Text = dt_PersonList.DefaultView.Item(0).Item("BirthDate")
'        frm.txtNationalCode.Text = dt_PersonList.DefaultView.Item(0).Item("NationalCode")
'        frm.txtIDSerial.Text = dt_PersonList.DefaultView.Item(0).Item("IDSerial")
'        frm.txtEgageDate.Text = dt_PersonList.DefaultView.Item(0).Item("EngageDate")
'        frm.txtWorkID.Text = dt_PersonList.DefaultView.Item(0).Item("WorkIDNum")
'        frm.txtAssureNum.Text = dt_PersonList.DefaultView.Item(0).Item("AssureNum")
'        frm.txtAddress.Text = dt_PersonList.DefaultView.Item(0).Item("Address")
'        frm.txtTel.Text = dt_PersonList.DefaultView.Item(0).Item("Tel")
'        frm.txtMobile.Text = dt_PersonList.DefaultView.Item(0).Item("Mobile")
'        frm.txtPostCode.Text = dt_PersonList.DefaultView.Item(0).Item("PostCode")
'        dt = Persist1.GetDataTable(ConString, "select PersonImage from tbHR_Person where PrsID = " & grdPerson.GetValue("PrsID") & " ")
'        Try
'            frm.PictureBox1.Image = pic1.getImageBuffer_Load(dt.DefaultView.Item(0).Item("PersonImage"))
'        Catch ex As Exception

'        End Try
'        frm.ShowDialog()
'    Else
'        MsgBox("ايتمي براي نمايش موجود نمي باشد", MsgBoxStyle.Information)
'    End If
'End Sub
'Private Sub rdbtnAll_Click(ByVal sender As Object, ByVal e As System.EventArgs)
'    Me.Cursor = Cursors.WaitCursor
'    FillgrdPerson(SelectStr.All)
'    Me.Cursor = Cursors.Default
'End Sub
'Private Sub گروهيToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    Dim frm As New frmPRSHokmsocial
'    frm.ShowDialog()
'End Sub