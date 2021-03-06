Public Class frmPRSTraining
    Dim Bus_Person1 As New Bus_Person
    Dim dt_Training, dt_City As New DataTable
    Dim _PersonCode, _PersonID, CityID As Integer
    Friend Flag_View As Boolean
    Friend engagedate As String
    Friend Property PersonCode() As Integer
        Get
            Return _PersonCode
        End Get
        Set(ByVal value As Integer)
            _PersonCode = value
        End Set
    End Property
    Friend Property PersonID() As Integer
        Get
            Return _PersonID
        End Get
        Set(ByVal value As Integer)
            _PersonID = value
        End Set
    End Property

    Private Sub frmPRSTraining_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub frmPRSTraining_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("شما به اين نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Me.Close()


            ''''دسترسي منابع انساني
        ElseIf Activity1.CheckUserAccess(54, 730, LogID) = True Then
            UiGroupBox2.Enabled = False
            ''''دسترسي آموزش 
        ElseIf Activity1.CheckUserAccess(54, 735, LogID) = True Then
            UiGroupBox2.Enabled = True
            'UiButton1.Visible = True
            'Flag_View = False
            ''''دسترسي معاونت مالي اداري
        ElseIf Activity1.CheckUserAccess(54, 733, LogID) = True Then
            UiGroupBox2.Enabled = False

        ElseIf Activity1.CheckUserAccess(54, 950, LogID) = True Then
            UiGroupBox2.Enabled = False
        End If
        FillMyGridView()
        FillCombo()
        ''''نظر سنجي

        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
        If Flag_View = True Then
            UiGroupBox2.Visible = False
        End If
    End Sub
    Friend Function FillCombo()
        Dim dt As New DataTable
        Dim dt1 As New DataTable

        dt_City = Bus_City1.GetCityIfo
        Persist1.FillCmb(dt_City, cmbCity, "CityCode", "Citytxt")

        SqlStr = "SELECT    CourseID,   CourseName  FROM         Training..tbTRNCourse  order by CourseName"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        Persist1.FillCmb(dt, CmbCourceName, "CourseID", "CourseName")

        SqlStr = "SELECT    InstituteID,   InstituteName  FROM         Training..tbTRNInstitute ORDER BY InstituteName"
        dt1 = Persist1.GetDataTable(ConString, SqlStr)
        Persist1.FillCmb(dt1, CmbCourcePlace, "InstituteID", "InstituteName")

    End Function
    Friend Function FillMyGridView()
        Dim janus1 As New JFrameWork.JanusGrid
        dt_Training = Bus_Training1.GetTrainingIfo(PersonCode)


        janus1.GetBindJGrid_DT(dt_Training, grdTraining, ConString)
        janus1.setMyJGrid(grdTraining, "PersonCode", "كد پرسنلي", 0, , , False)
        janus1.setMyJGrid(grdTraining, "CourceName", "نام دوره", 150)
        janus1.setMyJGrid(grdTraining, "CourcePlace", "نام آموزشگاه", 150)
        janus1.setMyJGrid(grdTraining, "Citytxt", "محل برگزاري", 120)
        janus1.setMyJGrid(grdTraining, "BeginDate", "تاريخ شروع", 80)
        janus1.setMyJGrid(grdTraining, "EndDate", "تاريخ پايان", 80)
        janus1.setMyJGrid(grdTraining, "SumTime", "مدت دوره", 55)
        janus1.setMyJGrid(grdTraining, "Average", "نمره", 55)
        janus1.setMyJGrid(grdTraining, "CityID", "", 0, , , False)
        janus1.setMyJGrid(grdTraining, "CityCode", "", 0, , , False)
        janus1.setMyJGrid(grdTraining, "TrainingID", "", 0, , , False)
        janus1.setMyJGrid(grdTraining, "PersonID", "", 0, , , False)
        janus1.setMyJGrid(grdTraining, "TypeID", "", 0, , , False)
        janus1.HighLightRows(grdTraining, "TypeID", Janus.Windows.GridEX.ConditionOperator.Equal, 1, Color.Aqua)
    End Function
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grdTraining.RowCount <> 0 Then
            If MsgBox("مطمئن هستيد ؟ " & "(( " & Me.grdTraining.GetValue("CourceName") & " ))" & "آيا از حذف دوره آموزش ", MsgBoxStyle.OkCancel, "هشدار") = MsgBoxResult.Ok Then
                Bus_Training1.DeleteTrainingInfo(Me.grdTraining.GetValue("TrainingID"))
                Call FillMyGridView()
            Else
                Exit Sub
            End If
        Else
            MsgBox("آيتمي براي حذف موجود نمي باشد", MsgBoxStyle.Information, "")
        End If
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim sqlstr As String
        Dim dt_CityID As New DataTable
        If txtBeginDate.Text > engagedate Then
            MsgBox(" تاریخ شروع بایستی قبل از تاریخ استخدام باشد  ", MsgBoxStyle.Information)
            Exit Sub
        End If
        If CmbCourceName.Text = "" Or CmbCourcePlace.Text = "" Or Len(txtBeginDate.Text) <> 10 Or Len(txtEndDate.Text) <> 10 Or cmbCity.Text = "" Or txtTime.Text = "" Or txtAverage.Text = "" Then
            MsgBox(" لطفا مقادير را درست وارد نماييد  ", MsgBoxStyle.Information)
            Exit Sub
        ElseIf txtBeginDate.Text > txtEndDate.Text Then
            MsgBox(" تاريخ شروع از تاريخ پايان بزرگتر است  ", MsgBoxStyle.Information, "")
            Exit Sub
        ElseIf IraniDate1.TestDate(IraniDate1.Numericdate(txtBeginDate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtEndDate.Text)) = True Then
            Exit Sub
        Else
            sqlstr = "select CityID from tbHR_City where CityCode = " & cmbCity.SelectedValue & ""
            dt_CityID = Persist1.GetDataTable(ConString, sqlstr)
            CityID = dt_CityID.DefaultView.Item(0).Item("CityID")
            If MsgBox("آيا از ثبت ركورد مورد نظر مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Bus_Training1.InsertTrainingInfo(Val(lblPersonID.Text.Trim), Val(lblPersonCode.Text), CmbCourcePlace.Text, CmbCourceName.Text, CityID, cmbCity.SelectedValue, txtBeginDate.Text, txtEndDate.Text, txtTime.Text, txtAverage.Text, CmbCourceName.SelectedValue, CmbCourcePlace.SelectedValue)
                MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
                Call FillMyGridView()
            Else
                Exit Sub
            End If

        End If
    End Sub
    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        If txtBeginDate.Text > engagedate Then
            MsgBox(" تاریخ شروع بایستی قبل از تاریخ استخدام باشد  ", MsgBoxStyle.Information)
            Exit Sub
        End If
        If grdTraining.RowCount <> 0 Then
            txtAverage.Text = grdTraining.GetValue("Average")
            txtBeginDate.Text = grdTraining.GetValue("BeginDate")
            CmbCourceName.Text = grdTraining.GetValue("CourceName")
            CmbCourcePlace.Text = grdTraining.GetValue("CourcePlace")
            txtEndDate.Text = grdTraining.GetValue("EndDate")
            txtTime.Text = grdTraining.GetValue("SumTime")
            cmbCity.SelectedValue = grdTraining.GetValue("CityCode")
            btnAdd.Visible = False
            btnSaveChange.Visible = True
            btnChange.Enabled = False
        Else
            MsgBox("اطلاعاتي براي ويرايش موجود نمي باشد", MsgBoxStyle.Information, "")
            Exit Sub
        End If
    End Sub
    Private Sub btnSaveChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChange.Click
        Dim sqlstr As String
        Dim dt_CityID As New DataTable
        If txtBeginDate.Text > txtEndDate.Text Then
            MsgBox(" تاريخ شروع از تاريخ پايان بزرگتر است  ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If CmbCourceName.Text = "" Or CmbCourcePlace.Text = "" Or Len(txtBeginDate.Text) <> 10 Or Len(txtEndDate.Text) <> 10 Or cmbCity.Text = "" Or txtTime.Text = "" Or txtAverage.Text = "" Then
            MsgBox(" لطفا مقادير را درست وارد نماييد  ", MsgBoxStyle.Information)
            Exit Sub
        Else
            sqlstr = "Select CityID from tbHR_City where CityCode = " & cmbCity.SelectedValue & ""

            dt_CityID = Persist1.GetDataTable(ConString, sqlstr)
            CityID = dt_CityID.DefaultView.Item(0).Item("CityID")
            If MsgBox("آيا از ثبت تغييرات مطمئن هستيد ؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Bus_Training1.UpdateTrainingIfo(grdTraining.GetValue("TrainingID"), CmbCourcePlace.Text, CmbCourceName.Text, CityID, cmbCity.SelectedValue, txtBeginDate.Text, txtEndDate.Text, txtTime.Text, txtAverage.Text, CmbCourceName.SelectedValue, CmbCourcePlace.SelectedValue)
                FillMyGridView()
                btnAdd.Visible = True
                btnSaveChange.Visible = False
                btnChange.Enabled = True
            Else
                btnAdd.Visible = True
                btnSaveChange.Visible = False
                btnChange.Enabled = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub

 
    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click

        Dim frmTraningShow1 As New frmTraningShow
        frmTraningShow1.personcode = PersonCode
        frmTraningShow1.ShowDialog()

    End Sub
End Class
'Private Sub درجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    Dim frm As New frmPRSAddTraining
'    frm.lblPersonCode.Text = Str(PersonCode)
'    frm.PersonID = Me.grdTraining.GetValue("PersonID")
'    frm.ShowDialog()
'    Call FillMyGridView()
'End Sub

'Private Sub ويرايشToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    Dim frm As New frmPRSChangeTraining
'    Try
'        frm.lblPersonCode.Text = Str(Me.grdTraining.GetValue("PersonCode"))
'        frm.TrainingID = Me.grdTraining.GetValue("TrainingID")
'        frm.txtAverage.Text = Me.grdTraining.GetValue("Average")
'        frm.txtBeginDate.Text = Me.grdTraining.GetValue("BeginDate")
'        frm.txtCourceName.Text = Me.grdTraining.GetValue("CourceName")
'        frm.txtCourcePlace.Text = Me.grdTraining.GetValue("CourcePlace")
'        frm.txtEndDate.Text = Me.grdTraining.GetValue("EndDate")
'        frm.txtTime.Text = Me.grdTraining.GetValue("SumTime")
'        frm.CityCode = Me.grdTraining.GetValue("PlaceCode")
'        frm.ShowDialog()
'        Call FillMyGridView()
'    Catch ex As Exception
'        MsgBox("اطلاعاتي براي ويرايش موجود نمي باشد", MsgBoxStyle.Information, "")
'        Exit Sub
'    End Try
'End Sub

'Private Sub حذفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    If grdTraining.RowCount <> 0 Then
'        If MsgBox("مطمئن هستيد ؟ " & "(( " & Me.grdTraining.GetValue("TrainingCourceName") & " ))" & "آيا از حذف دوره آموزش ", MsgBoxStyle.OkCancel, "هشدار") = MsgBoxResult.Ok Then
'            Bus_Person1.DeleteTrainingInfo(Me.grdTraining.GetValue("TrainingID"))
'            Call FillMyGridView()
'        Else
'            Exit Sub
'        End If
'    Else
'        MsgBox("آيتمي براي حذف موجود نمي باشد", MsgBoxStyle.Information, "")
'    End If
'End Sub
