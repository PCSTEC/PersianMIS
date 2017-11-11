Imports System.IO
Public Class frmPRSProperty
    Dim Bus_Person1 As New Bus_Person
    Dim dt_Sex As New DataTable
    Dim dt_City As New DataTable
    Dim dt_Military As New DataTable
    Dim dt_Engage As New DataTable
    Dim dt_Year As New DataTable
    Dim dt_Yegan As New DataTable
    Dim _SexID As Integer
    Dim _BirthCityID, _BirthCityCode As Integer
    Dim _IDIssueID, _IDIssueCode As Integer
    Dim _MilitaryID, _EngageTypeID As Integer
    Dim _YeganId As Integer
    Friend frmPRSMain1 As frmPRSMain
    Friend Property EngageTypeID() As Integer
        Get
            Return _EngageTypeID
        End Get
        Set(ByVal value As Integer)
            _EngageTypeID = value
        End Set
    End Property
    Friend Property IssueCityID() As Integer
        Get
            Return _IDIssueID
        End Get
        Set(ByVal value As Integer)
            _IDIssueID = value
        End Set
    End Property

    Friend Property IssueCityCode() As Integer
        Get
            Return _IDIssueCode
        End Get
        Set(ByVal value As Integer)
            _IDIssueCode = value
        End Set
    End Property
    Friend Property MilitaryID() As Integer
        Get
            Return _MilitaryID
        End Get
        Set(ByVal value As Integer)
            _MilitaryID = value
        End Set
    End Property
    Friend Property SexID() As Integer
        Get
            Return _SexID
        End Get
        Set(ByVal value As Integer)
            _SexID = value
        End Set
    End Property
    Friend Property BirthCityID() As Integer
        Get
            Return _BirthCityID
        End Get
        Set(ByVal value As Integer)
            _BirthCityID = value
        End Set
    End Property
    Friend Property BirthCityCode() As Integer
        Get
            Return _BirthCityCode
        End Get
        Set(ByVal value As Integer)
            _BirthCityCode = value
        End Set
    End Property
    Friend Property YeganId() As Integer
        Get
            Return _YeganId
        End Get
        Set(ByVal value As Integer)
            _YeganId = value
        End Set
    End Property
    Private Sub frmPRSMainProperty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LogText = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
        LogID = getLogID(LogText)
        If LogID = 0 Then
            MsgBox("شما به اين نرم افزار دسترسي نداريد", MsgBoxStyle.Information, "")
            Me.Close()
        Else
            ''''معاون مالي و اداري
            If Activity1.CheckUserAccess(54, 733, LogID) = True Then
                btnSaveChange.Visible = False
                btnChange.Visible = False
                btnPictureChange.Visible = False
            End If
        End If
        Fillcombo()
        ''''نظر سنجي

        JGrade1.SetUserControl(LogID, 54, Me.Name, False)

        ''''
    End Sub
    Private Sub Fillcombo()
        dt_Year = Bus_Other1.GetPeriod
        Persist1.FillCmb(dt_Year, cmbYear, "PeriodID", "PeriodYearID")
        cmbYear.Text = IraniDate1.GetYear_GivenDate(IraniDate1.GetIrani8Date_CurDate)
        dt_Engage = Bus_Engage1.GetEngageTypeIfo
        Persist1.FillCmb(dt_Engage, cmbEngage, "EngageTypeID", "EngageType")
        cmbEngage.SelectedValue = EngageTypeID
        dt_Sex = Bus_Other1.GetSexIfo
        Persist1.FillCmb(dt_Sex, cmbSex, "SexID", "Sextxt")
        cmbSex.SelectedValue = SexID
        dt_City = Bus_City1.GetCityIfo
        Persist1.FillCmb(dt_City, cmbBirthCity, "CityCode", "Citytxt")
        cmbBirthCity.SelectedValue = BirthCityCode
        dt_City = Bus_City1.GetCityIfos
        Persist1.FillCmb(dt_City, cmbIssueCity, "CityCode", "Citytxt")
        cmbIssueCity.SelectedValue = IssueCityCode
        dt_Military = Bus_Other1.GetMilitaryIfo
        Persist1.FillCmb(dt_Military, cmbMilitary, "MilitaryStateID", "MilitaryStateName")
        cmbMilitary.SelectedValue = MilitaryID
        dt_Yegan = Bus_Other1.GetYegan
        Persist1.FillCmb(dt_Yegan, cmbYegan, "YeganId", "YeganType")
        cmbYegan.SelectedValue = YeganId
    End Sub
    Private Sub btnPictureChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPictureChange.Click
        Dim s As Byte()
        Dim sqlstr As String
        Dim dt_Picture As New DataTable
        OpenFileDialog1.Filter = "JPEG|*.jpg|Bitmap|*.bmp|GIF|*.gif"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If MsgBox("آيا از انتخاب عكس فرد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                PictureBox1.Load(OpenFileDialog1.FileName)

                'در تاریخ 23/8/95 روش کد کردن تصویر تعویض گردید 
                '   Dim fileName = Path.GetFileName(OpenFileDialog1.FileName.ToString())
                's = saveAttach()
               
                Using picture As Image = Image.FromFile(OpenFileDialog1.FileName.ToString())
                    'Create an empty stream in memory.'
                    Using stream As New IO.MemoryStream
                        'Fill the stream with the binary data from the Image.'
                        picture.Save(stream, Imaging.ImageFormat.Jpeg)
                        Bus_Person1.UpdatePrsImage(lblprsID.Text, stream.GetBuffer())
                    End Using
                End Using

                sqlstr = "Select PersonImage from tbHR_Person where PersonID = " & lblprsID.Text.Trim & ""
                dt_Picture = Persist1.GetDataTable(ConString, sqlstr)
                PictureBox1.Image = pic1.getImageBuffer_Load(dt_Picture.DefaultView.Item(0).Item("PersonImage"))
                frmPRSMain1.PictureBox1.Image = pic1.getImageBuffer_Load(dt_Picture.DefaultView.Item(0).Item("PersonImage"))
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub
    Private Sub frmPRSProperty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Function ReadFileToByteArray(ByVal FileName As String) As System.Array
 



        'Dim converter As New ImageConverter
        'nRow.Signature = converter.ConvertTo(imgSignature, GetType(Byte()))


        'Dim fs As FileStream = New FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read)
        'Dim Len As Long
        'Len = fs.Length
        'Dim fileAsByte(Len) As Byte
        'fs.Read(fileAsByte, 0, fileAsByte.Length)
        'Dim MemoryStream1 As MemoryStream = New MemoryStream(fileAsByte)
        'Return MemoryStream1.ToArray
    End Function
    Private Function saveAttach() As Byte()
        Dim fileName = Path.GetFileName(OpenFileDialog1.FileName.ToString())
        Dim content As Byte() = ReadFileToByteArray(fileName)
        Return content
    End Function
    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        UiGroupBox2.Enabled = True
        btnPictureChange.Visible = True
        btnChange.Visible = False
        btnSaveChange.Visible = True
    End Sub
    Private Sub btnSaveChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChange.Click
        Dim dt_cityID As New DataTable
        Dim sqlstr1, sqlstr2 As String
        sqlstr1 = "select CityID from  tbHR_City where CityCode = '" & cmbBirthCity.SelectedValue & "'"
        dt_cityID = Persist1.GetDataTable(ConString, sqlstr1)
        lblBirthCityID.Text = ""
        lblBirthCityID.Text = dt_cityID.DefaultView.Item(0).Item("CityID")
        dt_cityID.Rows.Clear()
        sqlstr2 = "select CityID from  tbHR_City where CityCode = '" & cmbIssueCity.SelectedValue & "'"
        dt_cityID = Persist1.GetDataTable(ConString, sqlstr2)
        lblIssueCityID.Text = ""
        lblIssueCityID.Text = dt_cityID.DefaultView.Item(0).Item("CityID")
        dt_cityID.Rows.Clear()
        If txtBirthDate.Text > txtEgageDate.Text Then
            MsgBox(" تاريخ تولد از تاريخ استخدام بزرگتر است  ", MsgBoxStyle.Information, "")
            Exit Sub
        End If
        If txtCode.Text.Trim = "" Or txtName.Text.Trim = "" Or txtLName.Text.Trim = "" Or txtFName.Text.Trim = "" Or Len(txtBirthDate.Text) <> 10 Or txtIDNum.Text.Trim = "" Or Len(txtEgageDate.Text) <> 10 Or txtAddress.Text.Trim = "" Or cmbSex.Text.Trim = "" Or cmbBirthCity.Text.Trim = "" Or cmbBirthCity.Text.Trim = "-" Or cmbMilitary.Text.Trim = "" Then
            MsgBox(" لطفا مقادير را درست وارد نماييد  ", MsgBoxStyle.OkOnly, " خطا ")
            Exit Sub
        End If
        If IraniDate1.TestDate(IraniDate1.Numericdate(txtBirthDate.Text)) = True Or IraniDate1.TestDate(IraniDate1.Numericdate(txtEgageDate.Text)) = True Then
            Exit Sub
        End If
        If MsgBox("آيا از ثبت تغييرات مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Bus_Person1.updatePersonPry(lblprsID.Text.Trim, txtCode.Text.Trim, txtName.Text.Trim, txtLName.Text.Trim, txtFName.Text.Trim, txtBirthDate.Text.Trim, cmbSex.SelectedValue, txtNationalCode.Text.Trim, txtIDNum.Text.Trim, txtIDSerial.Text.Trim, Val(lblBirthCityID.Text.Trim), cmbBirthCity.SelectedValue, Val(lblIssueCityID.Text.Trim), cmbMilitary.SelectedValue, txtEgageDate.Text.Trim, txtWorkID.Text.Trim, txtAssureNum.Text.Trim, txtAddress.Text.Trim, txtTel.Text.Trim, txtMobile.Text.Trim, cmbIssueCity.SelectedValue, txtPostCode.Text.Trim, cmbYegan.SelectedValue)
            MsgBox("ركورد ثبت شد", MsgBoxStyle.Information, "")
            frmPRSMain1.grdPerson.SetValue("FirstName", txtName.Text)
            frmPRSMain1.grdPerson.SetValue("LastName", txtLName.Text)
            UiGroupBox2.Enabled = False
            btnPictureChange.Visible = False
            btnChange.Visible = True
            btnSaveChange.Visible = False
        Else
            Exit Sub
        End If
    End Sub
End Class