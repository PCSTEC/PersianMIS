Imports System.IO
Public Class FrmPezeshki
    Public personPezeshkiCode As Integer
    Dim dt_Picture As New DataTable


    Private Sub btnPicIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPicIns.Click
        Dim s As Byte()
        Dim sqlstr As String

        Dim Bus_Person1 As New Bus_Person
        Dim id As Integer
        id = Bus_Person1.InsertPezeshki(personPezeshkiCode, txtEmissionDate.Text)

        OpenFileDialog1.Filter = "JPEG|*.jpg|Bitmap|*.bmp|GIF|*.gif"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If MsgBox("آيا از انتخاب عكس فرد مطمئن هستيد؟", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                PictureBox1.Load(OpenFileDialog1.FileName)
                Dim fileName = Path.GetFileName(OpenFileDialog1.FileName.ToString())
                s = saveAttach()
                Bus_Person1.UpdatePezeshkiImage(id, s)
                sqlstr = "Select ImageHist from tbPRS_PezeshkHist where ID = " & id & ""
                dt_Picture = Persist1.GetDataTable(ConString, sqlstr)
                PictureBox1.Image = pic1.getImageBuffer_Load(dt_Picture.DefaultView.Item(0).Item("ImageHist"))

                fillGrid()
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub
    Private Function saveAttach() As Byte()
        Dim fileName = Path.GetFileName(OpenFileDialog1.FileName.ToString())
        Dim content As Byte() = ReadFileToByteArray(fileName)
        Return content
    End Function
    Private Function ReadFileToByteArray(ByVal FileName As String) As System.Array
        Dim fs As FileStream = New FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read)
        Dim Len As Long
        Len = fs.Length
        Dim fileAsByte(Len) As Byte
        fs.Read(fileAsByte, 0, fileAsByte.Length)
        Dim MemoryStream1 As MemoryStream = New MemoryStream(fileAsByte)
        Return MemoryStream1.ToArray
    End Function

    Private Sub FrmPezeshki_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillGrid()
    End Sub
    Private Sub fillGrid()
        Dim dt_person As New DataTable
        SqlStr = "Select ImageHist from tbPRS_PezeshkHist where PersonCode =" & personPezeshkiCode
        dt_Person = Persist1.GetDataTable(ConString, SqlStr)

        janus1.GetBindJGrid_DT(dt_Person, grdPerson, ConString)

        janus1.setMyJGrid(grdPerson, "id", "کد", 45)
        janus1.setMyJGrid(grdPerson, "HistDate", "تاریخ", 100)


    End Sub

    Private Sub grdPerson_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPerson.CurrentCellChanged
        Try
            SqlStr = "Select ImageHist from tbPRS_PezeshkHist where ID = " & grdPerson.GetValue("id") & ""
            dt_Picture = Persist1.GetDataTable(ConString, SqlStr)
            PictureBox1.Image = pic1.getImageBuffer_Load(dt_Picture.DefaultView.Item(0).Item("ImageHist"))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdPerson_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles grdPerson.FormattingRow

    End Sub
End Class