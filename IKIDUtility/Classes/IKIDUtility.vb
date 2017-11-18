Imports System.Windows.Forms
Imports System.Drawing
Imports SqlManager.QExport.XLS
Namespace IKIDUtility
    Public Class Formating
        Dim acYekGon(10) As String
        Dim acDahGon1(10) As String
        Dim acDahGon(10) As String
        Dim acSadGon(10) As String
        Dim acApend(6) As String
        Dim cTextNum As String

        Public Function NZ(ByVal Num As Object, ByVal param As Object)
            If IsDBNull(Num) = True Then
                NZ = param
                Exit Function
            ElseIf Trim(Num) = "" Then
                NZ = param
            Else
                NZ = Num
            End If
        End Function

        Public Function GetLanguageFarsi()
            Dim IL As InputLanguage
            For Each IL In InputLanguage.InstalledInputLanguages
                If IL.LayoutName = "Farsi" Then
                    IL.CurrentInputLanguage = IL
                    Exit For
                End If
            Next IL
        End Function

        Public Function GetLanguageLatin()
            Dim IL As InputLanguage
            For Each IL In InputLanguage.InstalledInputLanguages
                If IL.LayoutName = "US" Then
                    IL.CurrentInputLanguage = IL
                    Exit For
                End If
            Next IL
        End Function

        Public Function adjForm(ByVal objName As Object, ByVal objWidth As Integer, ByVal objHeight As Integer, ByVal LocWidth As Integer, ByVal LocHeight As Integer)
            Dim workingRectangle As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
            If TypeOf objName Is Form Then
                objName.Size = New System.Drawing.Size(workingRectangle.Width - objWidth, workingRectangle.Height - objHeight)
                objName.Location = New Point(LocWidth, LocHeight)
            ElseIf TypeOf objName Is PictureBox Then
                objName.Size = New System.Drawing.Size(workingRectangle.Width - objWidth, workingRectangle.Height - objHeight)
                objName.Location = New Point(objWidth, objHeight)
            ElseIf TypeOf objName Is DataGrid Then
                objName.Size = New System.Drawing.Size(workingRectangle.Width - objWidth, workingRectangle.Height - objHeight)
                objName.Location = New Point(objWidth, objHeight)
            ElseIf TypeOf objName Is TextBox Then
                objName.Size = New System.Drawing.Size(workingRectangle.Width - objWidth, workingRectangle.Height - objHeight)
                objName.Location = New Point(objWidth, objHeight)
            End If
        End Function

        'Public Function GetTimeMinute(ByVal Hour As String) As Integer
        '    Dim i, j As Integer
        '    i = Len(Hour)
        '    For j = 1 To i
        '        If Mid(Hour, j, 1) = ":" Then
        '            GetTimeMinute = (Val(Left(Hour, j - 1)) * 60) + (Val(Right(Hour, 2)))
        '            Exit Function
        '        End If
        '    Next
        'End Function

        'Public Function GetTimeHour(ByVal Minute As Integer) As String
        '    GetTimeHour = Format((Minute \ 60), "00") + ":" + Format((Minute Mod 60), "00")
        'End Function

        Public Function ConvNumToAlpha(ByVal cNumber As String) As String
            ' Dim Num As Variant


            Dim nLen3Num, nCounter As Integer
            Dim cSubText As String
            Dim cStrNum As String

            acYekGon(0) = "" : acYekGon(1) = " Ìﬂ " : acYekGon(2) = " œÊ" : acYekGon(3) = " ”Â "
            acYekGon(4) = " çÂ«— " : acYekGon(5) = " Å‰Ã " : acYekGon(6) = " ‘‘ " : acYekGon(7) = " Â›  "
            acYekGon(8) = " Â‘  " : acYekGon(9) = " ‰Â "

            acDahGon1(0) = "œÂ " : acDahGon1(1) = " Ì«“œÂ " : acDahGon1(2) = " œÊ«“œÂ " : acDahGon1(3) = " ”Ì“œÂ "
            acDahGon1(4) = " çÂ«—œÂ " : acDahGon1(5) = " Å«‰“œÂ " : acDahGon1(6) = " ‘«‰—œÂ " : acDahGon1(7) = " Â›œÂ "
            acDahGon1(8) = " ÂçœÂ " : acDahGon1(9) = " ‰Ê“œÂ "

            acDahGon(0) = "" : acDahGon(1) = "" : acDahGon(2) = " »Ì”  " : acDahGon(3) = " ”Ì "
            acDahGon(4) = " çÂ· " : acDahGon(5) = " Å‰Ã«Â " : acDahGon(6) = " ‘’  " : acDahGon(7) = " Â› «œ "
            acDahGon(8) = "Â‘ «œ " : acDahGon(9) = " ‰Êœ "

            acSadGon(0) = "" : acSadGon(1) = " ’œ " : acSadGon(2) = " œÊÌ”  " : acSadGon(3) = " ”Ì’œ "
            acSadGon(4) = " çÂ«—’œ " : acSadGon(5) = " Å«‰’œ " : acSadGon(6) = " ‘‘’œ " : acSadGon(7) = " Â› ’œ "
            acSadGon(8) = "Â‘ ’œ " : acSadGon(9) = " ‰Â’œ "

            acApend(0) = "" : acApend(1) = "" : acApend(2) = " Â“«— " : acApend(3) = " „Ì·ÌÊ‰ "
            acApend(4) = " „Ì·Ì«—œ " : acApend(5) = "  —Ì·ÌÊ‰ "

            '    Num = 0
            cStrNum = ""
            cTextNum = ""

            If Val(cNumber) > 0 Then

                ' ***** —”«‰œ‰ ÿÊ· ⁄œœ »Â „÷—»Ì «“ 3
                cStrNum = LTrim(RTrim(Str(cNumber)))
                Do While (Len(cStrNum) / 3) <> Int(Len(cStrNum) / 3)
                    cStrNum = "0" & cStrNum
                Loop

                '******„Õ«”»Â ÿÊ· ⁄œœ  ›ﬂÌﬂ ‘œÂ »Â ”Â —ﬁ„
                nLen3Num = 0
                For nCounter = 1 To Len(cStrNum) Step 3
                    nLen3Num = nLen3Num + 1
                Next nCounter

                '******* «—”«· Â—”Â —ﬁ„ ⁄œœ »Â  «»⁄ ÃÂ   ÂÌÂ „ ‰ Œ—ÊÃÌ
                For nCounter = 1 To Len(cStrNum) Step 3
                    cSubText = Mid(cStrNum, nCounter, 3)
                    Call String3N(cSubText, nLen3Num)
                    nLen3Num = nLen3Num - 1
                Next nCounter
                ConvNumToAlpha = cTextNum
            Else
                ConvNumToAlpha = "’›—"
            End If
        End Function

        Private Sub String3N(ByVal cText3 As String, ByVal nConter3 As Integer)

            Dim cOne
            Dim cTen
            Dim cHan
            Dim c3Num

            cOne = Mid(cText3, 3, 1)
            cTen = Mid(cText3, 2, 1)
            cHan = Mid(cText3, 1, 1)


            If cText3 <> "000" Then
                If Len(LTrim(RTrim(cTextNum))) > 0 Then
                    cTextNum = cTextNum + "Ê"
                End If

                c3Num = acSadGon(Int(cHan))

                If Len(LTrim(RTrim((c3Num)))) > 0 And cTen <> "0" Then
                    c3Num = c3Num + "Ê"
                End If

                If cTen = "1" Then
                    c3Num = c3Num + acDahGon1(Int(cOne))

                    c3Num = c3Num + acApend(nConter3)

                    cTextNum = cTextNum + c3Num

                Else

                    c3Num = c3Num + acDahGon(Int(cTen))

                    If Len(LTrim(RTrim((c3Num)))) > 0 And (cOne <> "0" And cTen <> "1") Then
                        c3Num = c3Num + " Ê"
                    End If

                    If cTen <> "1" Then
                        c3Num = c3Num + acYekGon(Int(cOne))
                    End If

                    c3Num = c3Num + acApend(nConter3)
                    cTextNum = cTextNum + c3Num

                End If
            End If

        End Sub

        Public Function EmptyControls(ByVal obj As Object)
            Dim objControl As Object

            For Each objControl In obj.Controls
                If objControl.GetType.ToString = "System.Windows.Forms.TextBox" Then
                    objControl.Text = ""
                ElseIf objControl.GetType.ToString = "System.Windows.Forms.ComboBox" Then
                    objControl.Text = ""
                ElseIf objControl.GetType.ToString = "System.Windows.Forms.TabControl" Then
                    EmptyControls(objControl)
                ElseIf objControl.GetType.ToString = "System.Windows.Forms.TabPage" Then
                    EmptyControls(objControl)
                ElseIf objControl.GetType.ToString = "system.Windows.Forms.GroupBox" Then
                    EmptyControls(objControl)
                ElseIf objControl.GetType.ToString = "system.Windows.Forms.Panel" Then
                    EmptyControls(objControl)
                End If

            Next
        End Function

        Public Function FindPosition(ByVal bind As BindingContext, ByVal dg As DataGrid, ByVal dt As DataTable, ByVal ValIf As String)
            Dim i As Integer
            For i = 1 To dt.DefaultView.Count - 1
                If (dg.Item(i, 0)) = ValIf Then
                    dg.UnSelect(dg.CurrentRowIndex)
                    bind(dt.DefaultView).Position = i
                    'bind(ds.Tables(dg.TableStyles(0).MappingName).DefaultView).Position = i
                    dg.UnSelect(dg.CurrentRowIndex)
                    dg.Select(i)
                    Exit For
                End If
            Next
        End Function

        Public Sub SetWlglobalForm(ByVal Bind As BindingContext, ByVal CnnStr As String, ByVal DT As DataTable, ByVal DG As DataGrid, Optional ByVal tbName As String = "", Optional ByVal frm As Form = Nothing)
            Dim w As New WLFormGlobalCtrl_DT.clsPublicProperty
            w.Binding = Bind
            w.CnntStr = CnnStr
            w.DataTable = DT
            w.GridName = DG
            w.TableName = tbName
            w.FrmName = frm
            w.ViewRecordCount()
        End Sub

        Public Function GetInstanceFromDll(ByVal DllPath As String, ByVal RootNamespace As String, ByVal ClassName As String) As Object
            Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.LoadFrom(DllPath)
            Dim mytype As Type = asm.GetType(RootNamespace & "." & ClassName)
            Dim obj As Object = Activator.CreateInstance(mytype)
            '            obj.ShowMessage1()
            Return obj
        End Function

        Public Function GetLastRowNumber(ByVal dbName As String, ByVal tbName As String, ByVal fldName As String, ByVal Wstr As String) As Integer
            Dim dt1 As DataTable
            Dim sqlstr1 As String
            sqlstr1 = "SELECT MAX(" & fldName & ") as MaxRow FROM " & dbName & ".." & tbName & " WHERE " & Wstr
            dt1 = Persist1.GetDataTable(CnnString, sqlstr1)
            If dt1.DefaultView.Count = 0 Then
                GetLastRowNumber = 1
            Else
                GetLastRowNumber = NZ(dt1.DefaultView.Item(0).Item("MaxRow"), 0) + 1
            End If
        End Function
        Public Function ExportTo(ByVal dt As DataTable, ByVal ExportType As MainModule.ExportType)
            Select Case ExportType
                Case MainModule.ExportType.Excel
                    Dim QExportXLS As New SqlManager.QExport.XLS.QExportXLS
                    QExportXLS.ExportSource = SqlManager.QExport.Base.QExportSource.esDataTable
                    QExportXLS.DataTable = dt 'cnnstring'
                    QExportXLS.ExportSource = SqlManager.QExport.Base.QExportSource.esDataTable
                    QExportXLS.FileName = "demo1.xls"
                    QExportXLS.ShowFile = True
                    QExportXLS.Execute()
                Case MainModule.ExportType.Pdf
                    Dim QExportPdf As New SqlManager.QExport.PDF.QExportPDF
                    QExportPdf.ExportSource = SqlManager.QExport.Base.QExportSource.esDataTable
                    QExportPdf.DataTable = dt 'cnnstring'
                    QExportPdf.ExportSource = SqlManager.QExport.Base.QExportSource.esDataTable
                    QExportPdf.FileName = "demo1.pdf"
                    QExportPdf.ShowFile = True
                    QExportPdf.Execute()
                Case MainModule.ExportType.Html
                    Dim QExportHTML As New SqlManager.QExport.HTML.QExportHTML
                    QExportHTML.ExportSource = SqlManager.QExport.Base.QExportSource.esDataTable
                    QExportHTML.DataTable = dt 'cnnstring'
                    QExportHTML.ExportSource = SqlManager.QExport.Base.QExportSource.esDataTable
                    QExportHTML.FileName = "demo1.html"
                    QExportHTML.ShowFile = True
                    QExportHTML.Execute()
                Case MainModule.ExportType.Word
                    Dim QExportWord As New SqlManager.QExport.RTF.QExportRTF
                    QExportWord.ExportSource = SqlManager.QExport.Base.QExportSource.esDataTable
                    QExportWord.DataTable = dt 'cnnstring'
                    QExportWord.ExportSource = SqlManager.QExport.Base.QExportSource.esDataTable
                    QExportWord.FileName = "demo1.rtf"
                    QExportWord.ShowFile = True
                    QExportWord.Execute()
                Case MainModule.ExportType.Txt
                    Dim QExportTxt As New SqlManager.QExport.TXT.QExportTXT
                    QExportTxt.ExportSource = SqlManager.QExport.Base.QExportSource.esDataTable
                    QExportTxt.DataTable = dt 'cnnstring'
                    QExportTxt.ExportSource = SqlManager.QExport.Base.QExportSource.esDataTable
                    QExportTxt.FileName = "demo1.txt"
                    QExportTxt.ShowFile = True
                    QExportTxt.Execute()
            End Select

        End Function
        Public Function OpenFile(ByVal FilePath As String)
            System.Diagnostics.Process.Start(FilePath)
        End Function

    End Class
End Namespace
