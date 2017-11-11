Public Enum SelValue
    AllTrue = 1
    AllFalse = 0
    AllRev = 3
End Enum
Public Class frmReportSakhti
    Dim dt_Person As New DataTable
    Dim dt_MDepart As New DataTable
    Dim Janus3 As New JFrameWork.JanusGrid
    Dim DA1 As New SqlClient.SqlDataAdapter
    Public ReqNum As Integer

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        'sqlstr = "SELECT  ARZDateId, StartArzDate + ' - ' + EndArzDate as Bazeh  FROM tbARZ_Date "
        'dt = persist1.GetDataTable(Cnnstring, sqlstr)
        'persist1.FillCmb(dt, cmbBazeh, "ARZDateId", "Bazeh")
        chkALL.Checked = True
        FillGrid()
        fillgridPost(1)
    End Sub
    Private Sub fillgridPost(ByVal All As Integer)
        Me.Cursor = Cursors.WaitCursor
        If All = 0 Then
            SqlStr = _
        " SELECT     dbo.tbHR_Post.Posttxt, dbo.tbHR_Employee.PersonCode, dbo.tbHR_Post.PostID , dbo.tbHR_Post.HardJob as Sel " & _
        " FROM         dbo.tbHR_Employee INNER JOIN   dbo.tbHR_Post ON dbo.tbHR_Employee.PostID = dbo.tbHR_Post.PostID " & _
        " GROUP BY dbo.tbHR_Post.Posttxt, dbo.tbHR_Employee.PersonCode, dbo.tbHR_Post.PostID ,dbo.tbHR_Post.HardJob" & _
        " HAVING      (dbo.tbHR_Employee.PersonCode IN " & janus1.get_Collection_String(dgdPerson, 1, 0) & ")"
        Else

            sqlstr = "Select *,HardJob as Sel from tbHR_Post"
        End If

        dt_Person = Persist1.GetDataTable(ConString, SqlStr)

        Janus3.GetBindJGrid_DT(dt_Person, dgdPost, ConString)
        Janus3.Add_ColDt(dt_Person)
        Janus3.setMyJGrid(dgdPost, "Sel", "گزينش", 50, Janus.Windows.GridEX.EditType.CheckBox, Janus.Windows.GridEX.ColumnType.CheckBox)
        Janus3.setMyJGrid(dgdPost, "PostID", "کد ", 50, , , True)
        Janus3.setMyJGrid(dgdPost, "PostTxt", "نام  ", 150, , , True)
        'Janus3.setMyJGrid(dgdPerson, "EngageDate", "تاریخ استخدام ", 65, , , True)
        'Janus3.setMyJGrid(dgdPerson, "MDepartName", "نام واحد ", 150, , , True)
        'Janus3.setMyJGrid(dgdPerson, "DepartName", "نام اداره ", 150, , , True)
        'Janus3.setMyJGrid(dgdPerson, "Posttxt", "نام پست ", 150, , , True)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub FillGrid()
        sqlstr = "Select * from VwHR_MDepart"
        dt_MDepart = Persist1.GetDataTable(ConString, SqlStr)

        Janus3.GetBindJGrid_DT(dt_MDepart, dgdMDepart, ConString)
        Janus3.Add_ColDt(dt_MDepart)
        Janus3.setMyJGrid(dgdMDepart, "Sel", "گزينش", 50, Janus.Windows.GridEX.EditType.CheckBox, Janus.Windows.GridEX.ColumnType.CheckBox)
        Janus3.setMyJGrid(dgdMDepart, "MDepartCode", "کد ", 50, , , True)
        Janus3.setMyJGrid(dgdMDepart, "MDepartName", "نام واحد ", 150, , , True)

    End Sub
    Private Sub FillGridPerson()

        Me.Cursor = Cursors.WaitCursor
        sqlstr = "Select * from View_All_Personel Where ( MDepartCode in " & Janus1.get_Collection_String(dgdMDepart, 1, 0) & ")"
        dt_Person = Persist1.GetDataTable(ConString, SqlStr)

        Janus3.GetBindJGrid_DT(dt_Person, dgdPerson, ConString)
        Janus3.Add_ColDt(dt_Person)
        Janus3.setMyJGrid(dgdPerson, "Sel", "گزينش", 50, Janus.Windows.GridEX.EditType.CheckBox, Janus.Windows.GridEX.ColumnType.CheckBox)
        Janus3.setMyJGrid(dgdPerson, "PersonCode", "شماره پرسنلی ", 80, , , True)
        Janus3.setMyJGrid(dgdPerson, "FirstName", "نام ", 80, , , True)
        Janus3.setMyJGrid(dgdPerson, "LastName", "نام خانوادگی ", 90, , , True)
        Janus3.setMyJGrid(dgdPerson, "Posttxt", "نام پست ", 150, , , True)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SelAll(ByVal MyGrid As Janus.Windows.GridEX.GridEX, ByVal SelValue1 As SelValue)
        Dim i As Integer
        Try
            MyGrid.Row = 0
            For i = 0 To MyGrid.RowCount
                If SelValue1 = SelValue.AllRev Then
                    If MyGrid.GetValue(MyGrid.RootTable.Columns("sel").Index) = True Then
                        MyGrid.SetValue(MyGrid.RootTable.Columns("sel").Index, False)
                    Else
                        MyGrid.SetValue(MyGrid.RootTable.Columns("sel").Index, True)
                    End If
                Else
                    MyGrid.SetValue(MyGrid.RootTable.Columns("sel").Index, SelValue1)
                End If
                MyGrid.MoveNext()
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SelAll_Active(ByVal MyGrid As Janus.Windows.GridEX.GridEX, ByVal SelValue1 As SelValue)
        Dim i As Integer
        Try
            MyGrid.Row = 0
            For i = 0 To MyGrid.RowCount
                If SelValue1 = SelValue.AllRev Then
                    If MyGrid.GetValue(MyGrid.RootTable.Columns("sel").Index) = True Then
                        MyGrid.SetValue(MyGrid.RootTable.Columns("sel").Index, False)
                    Else
                        MyGrid.SetValue(MyGrid.RootTable.Columns("sel").Index, True)
                    End If
                Else
                    MyGrid.SetValue(MyGrid.RootTable.Columns("sel").Index, SelValue1)
                End If
                MyGrid.MoveNext()
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rdbtnNone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtnNone.Click
        SelAll(dgdPost, SelValue.AllFalse)
        rdbtnNone.Checked = False

    End Sub
    Private Sub rdbtnAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtnAll.Click
        SelAll(dgdPost, SelValue.AllTrue)
        rdbtnAll.Checked = False
    End Sub
    Private Sub rdbtnRev_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtnRev.Click
        SelAll(dgdPost, SelValue.AllRev)
        rdbtnRev.Checked = False
    End Sub

    Private Sub dgdMDepart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdMDepart.Click
        fillgridPerson()
    End Sub
    Private Sub dgdMDepart_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgdMDepart.MouseUp
        SelOne(dgdMDepart)
        '   fillgridPerson(Janus1.get_Collection_String(dgdMDepart, 1, 0))
    End Sub
    Private Sub SelOne(ByVal MyGrid As Janus.Windows.GridEX.GridEX)
        If MyGrid.GetValue(MyGrid.RootTable.Columns("sel").Index) = True Then
            MyGrid.SetValue(MyGrid.RootTable.Columns("sel").Index, True)
        Else
            MyGrid.SetValue(MyGrid.RootTable.Columns("sel").Index, False)
        End If
    End Sub


    Private Sub rdbtnAllMDep_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtnAllMDep.Click
        SelAll(dgdMDepart, SelValue.AllTrue)
        rdbtnAll.Checked = False
        FillGridPerson()
        '  fillgridPerson(Janus1.get_Collection_String(dgdMDepart, 1, 0))
    End Sub

    Private Sub rdbtnNoneMDep_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtnNoneMDep.Click
        SelAll(dgdMDepart, SelValue.AllFalse)
        rdbtnNone.Checked = False
        FillGridPerson()
        ' fillgridPerson(Janus1.get_Collection_String(dgdMDepart, 1, 0))
    End Sub


    Private Sub rdbtnRevMDep_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtnRevMDep.Click
        SelAll(dgdMDepart, SelValue.AllRev)
        rdbtnRev.Checked = False
        FillGridPerson()
        ' fillgridPerson(Janus1.get_Collection_String(dgdMDepart, 1, 0))
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        'Dim i As New IKIDUtility.IKIDUtility.Formating
        'Dim dt As New DataTable

        'If CheckBox1.Checked = False Then
        '    sqlstr = "Select * from VwARZ_GOZARESH_3 Where ([کد واحد] IN " & Janus1.get_Collection_String(dgdMDepart, 1, 0) & ")"
        '    dt = persist1.GetDataTable(Cnnstring, sqlstr)
        '    i.ExportTo(dt, IKIDUtility.ExportType.Excel)
        'Else
        '    sqlstr = "Select * from VwARZ_GOZARESH_3 Where ([کد واحد] IN " & Janus1.get_Collection_String(dgdMDepart, 1, 0) & ") AND ([کد عنوان پست] IN " & Janus1.get_Collection_String(dgdPerson, 1, 0) & ")"
        '    dt = persist1.GetDataTable(Cnnstring, sqlstr)
        '    i.ExportTo(dt, IKIDUtility.ExportType.Excel)

        'End If



        'Select Case cmbRepList.Text
        '    Case "نمودار ارزیابی"
        '        wstr_Rep = _
        '     "SELECT     VwARZ_SumGrade.ARZDateId, tbARZ_Date.StartArzDate, tbARZ_Date.EndArzDate, tbARZ_Date.Description,  " & _
        '     "                      tbHR_Employee.Active, tbHR_Person.LastName + N' ' + tbHR_Person.FirstName AS prName, tbHR_Post.Posttxt, tbHR_Depart.DepartName,  " & _
        '     "                      tbHR_Depart_1.DepartName AS MDepartName, tbHR_Person.PersonImage, tbHR_Person.PersonCode,   VwARZ_SumGrade.ARZDateId, VwARZ_SumGrade.SumGrade * 100 / tbARZ_Percent.ArzPercent AS SumGrade,     VwARZ_SumGrade.SumFee * 100 / tbARZ_Percent.ArzPercent AS SumFee, " & _
        '     "                      tbARZ_Percent.ArzPercent " & _
        '     "FROM         tbHR_Employee INNER JOIN " & _
        '     "                      tbHR_Person ON tbHR_Employee.PersonID = tbHR_Person.PersonID INNER JOIN " & _
        '     "                      tbHR_Post ON tbHR_Employee.PostID = tbHR_Post.PostID INNER JOIN " & _
        '     "                      tbHR_Depart ON tbHR_Post.DepartID = tbHR_Depart.DepartID INNER JOIN " & _
        '     "                      VwARZ_SumGrade INNER JOIN " & _
        '     "                      tbARZ_Date ON VwARZ_SumGrade.ARZDateId = tbARZ_Date.ARZDateId ON tbHR_Person.PersonCode = VwARZ_SumGrade.PersonCode INNER JOIN " & _
        '     "                      tbHR_Depart AS tbHR_Depart_1 ON tbHR_Depart.MDepartCode = tbHR_Depart_1.DepartCode INNER JOIN " & _
        '     "                      tbARZ_Percent ON tbARZ_Date.ARZDateId = tbARZ_Percent.ARZDateId AND tbHR_Person.PersonCode = tbARZ_Percent.PersonCode " & _
        '     "WHERE     (tbHR_Employee.Active = 1)AND (dbo.tbHR_Person.PersonCode IN " & Janus1.get_Collection_String(dgdPerson, 1, 0) & ")" & IIf(ChkAllDate.Checked = True, "", "AND (dbo.tbARZ_Date.ARZDateId = " & cmbBazeh.SelectedValue & ")")

        '        rptReports = New RptPersonArzeshyabi
        '        LastRepName = ReportName
        '        ReportName = "RptPersonArzeshyabi.rpt"
        '        rptReports.setparametervalue("CurDate", IraniDate1.GetIraniFullDateTime_CurDate)

        '    Case "لیست ارزیابی"

        '        wstr_Rep = _
        '                "SELECT     dbo.tbHR_Employee.Active, dbo.tbHR_Person.LastName + N' ' + dbo.tbHR_Person.FirstName AS prName, dbo.tbHR_Post.Posttxt,  " & _
        '                "                      dbo.tbHR_Depart.DepartName, tbHR_Depart_1.DepartName AS MDepartName, dbo.tbHR_Person.PersonImage, dbo.tbHR_Person.PersonCode, " & _
        '                "                          (SELECT     Grade " & _
        '                "                             FROM         dbo.tbARZ_PersonGrade " & _
        '                "                             WHERE     (PersonCode = dbo.tbHR_Person.PersonCode) AND (ParameterID = 8) AND (ARZDateId = 6)) AS 'حضور به موقع', " & _
        '                "                          (SELECT     Grade " & _
        '                "                             FROM         dbo.tbARZ_PersonGrade AS tbARZ_PersonGrade_4 " & _
        '                "                             WHERE     (PersonCode = dbo.tbHR_Person.PersonCode) AND (ParameterID = 9) AND (ARZDateId = 6)) AS 'رعايت مسايل اخلاق و انضباطي', " & _
        '                "                          (SELECT     Grade " & _
        '                "                             FROM         dbo.tbARZ_PersonGrade AS tbARZ_PersonGrade_3 " & _
        '                "                             WHERE     (PersonCode = dbo.tbHR_Person.PersonCode) AND (ParameterID = 10) AND (ARZDateId = 6)) AS 'فعاليت گروهي', " & _
        '                "                          (SELECT     Grade " & _
        '                "                             FROM         dbo.tbARZ_PersonGrade AS tbARZ_PersonGrade_2 " & _
        '                "                             WHERE     (PersonCode = dbo.tbHR_Person.PersonCode) AND (ParameterID = 11) AND (ARZDateId = 6))  " & _
        '                "                      AS 'پيگيري ، گزارش دهي و انجام امور محوله', " & _
        '                "                          (SELECT     Grade " & _
        '                "                             FROM         dbo.tbARZ_PersonGrade AS tbARZ_PersonGrade_1 " & _
        '                "                             WHERE     (PersonCode = dbo.tbHR_Person.PersonCode) AND (ParameterID = 12) AND (ARZDateId = 6)) AS 'تعداد کارکنان زير مجموعه', " & _
        '                "  (SELECT     Grade " & _
        '                "                             FROM         dbo.tbARZ_PersonGrade AS tbARZ_PersonGrade_1 " & _
        '                "                             WHERE     (PersonCode = dbo.tbHR_Person.PersonCode) AND (ParameterID = 13) AND (ARZDateId = 6)) AS 'ماندگاري در پست سازماني', " & _
        '                "  (SELECT     Grade " & _
        '                "                             FROM         dbo.tbARZ_PersonGrade AS tbARZ_PersonGrade_1 " & _
        '                "                             WHERE     (PersonCode = dbo.tbHR_Person.PersonCode) AND (ParameterID = 14) AND (ARZDateId = 6)) AS 'حضور در شرکت' " & _
        '                "FROM         dbo.tbHR_Employee INNER JOIN " & _
        '                "                      dbo.tbHR_Person ON dbo.tbHR_Employee.PersonID = dbo.tbHR_Person.PersonID INNER JOIN " & _
        '                "                      dbo.tbHR_Post ON dbo.tbHR_Employee.PostID = dbo.tbHR_Post.PostID INNER JOIN " & _
        '                "                      dbo.tbHR_Depart ON dbo.tbHR_Post.DepartID = dbo.tbHR_Depart.DepartID INNER JOIN " & _
        '                "                      dbo.tbHR_Depart AS tbHR_Depart_1 ON dbo.tbHR_Depart.MDepartCode = tbHR_Depart_1.DepartCode " & _
        '                "WHERE     (dbo.tbHR_Employee.Active = 1)AND (dbo.tbHR_Person.PersonCode IN " & Janus1.get_Collection_String(dgdPerson, 1, 0) & ")"


        'wstr_Rep = "select * from VwTAB_Mashaghel_Detail order by cnt desc"
        'rptReports = New Rpt_TabagheMashaghel
        'LastRepName = ReportName
        'ReportName = "Rpt_TabagheMashaghel.rpt"
        'rptReports.setparametervalue("CurDate", IraniDate1.GetIraniFullDateTime_CurDate)
        'End Select


        wstr_Rep = "select * from VwTAB_Mashaghel_Detail where  (PersonCode IN " & janus1.get_Collection_String(dgdPerson, 1, 0) & ") AND  (PostID IN " & janus1.get_Collection_String(dgdPost, 1, 0) & ")    ORDER BY PersonCode, ExecDate"



        '  wstr_Rep = "SELECT     TOP (100) PERCENT PrName, MDepartName, EngageType, PersonCode, Cnt, HistPosttxt, ExecDate, JobOutHist, JobInHist, EngageDate,   MDepartCode FROM         dbo.VwTAB_Mashaghel_Detail  WHERE     (PersonCode IN ('750037', '')) ORDER BY PersonCode, ExecDate "


        rptReports = New Rpt_TabagheMashaghel_2
        LastRepName = ReportName
        ReportName = "Rpt_TabagheMashaghel_2.rpt"
        rptReports.setparametervalue("CurDate", IraniDate1.GetIraniFullDateTime_CurDate)
        'End Select


        Call rptLoad()

    End Sub
    Private Sub rptLoad()
        Try
            If dsReports.Tables.Count > 0 Then
                dsReports.Tables(LastRepName).Clear()
            End If
            DA1 = Persist1.GetDataAccess(wstr_Rep, 1, ConString, ReportName, dsReports)
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



    Private Sub rdbtnNonePerson_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtnNonePerson.Click
        SelAll(dgdPerson, SelValue.AllFalse)
        rdbtnAllPerson.Checked = False
        If chkALL.Checked = False Then
            fillgridPost(0)
        End If
    End Sub
    Private Sub rdbtnRevPerson_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtnRevPerson.Click
        SelAll(dgdPerson, SelValue.AllRev)
        rdbtnAllPerson.Checked = False
        If chkALL.Checked = False Then
            fillgridPost(0)
        End If
    End Sub

    Private Sub rdbtnAllPerson_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtnAllPerson.Click
        SelAll(dgdPerson, SelValue.AllTrue)
        rdbtnAllPerson.Checked = False
        If chkALL.Checked = False Then
            fillgridPost(0)
        End If
    End Sub

    Private Sub dgdPerson_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdPerson.Click
        If chkALL.Checked = False Then
            fillgridPost(0)
        End If
    End Sub


    Private Sub dgdPerson_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgdPerson.MouseUp
        SelOne(dgdPerson)
    End Sub

    Private Sub chkALL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkALL.CheckedChanged

    End Sub
End Class