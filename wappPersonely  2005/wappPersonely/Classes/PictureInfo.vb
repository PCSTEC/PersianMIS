Imports System.IO
Namespace PictureInfo
    Public Class PictureInfo
        Dim PictureBuffer() As Byte
        Dim TempPicture As PictureBox
        Public Function getImageBuffer_Ins(ByVal PictureBox1 As PictureBox) As Byte()
            Dim MS As New MemoryStream
            'PictureBox1.Image.Save(MS, (CType(PictureBox1.Image.ToString, Byte())))
            PictureBuffer = MS.GetBuffer
            MS.Close()
            Return PictureBuffer
        End Function
        Public Function getImageBuffer_Load(ByVal PicVal As System.Array)
            Dim MS As New MemoryStream
            PictureBuffer = CType(PicVal, Byte())
            MS = New MemoryStream(PictureBuffer)
            Return Image.FromStream(MS)
            MS.Close()
        End Function
        Public Function getImageBuffer_Load(ByVal PicVal As System.DBNull)
            Return Nothing
        End Function
    End Class
End Namespace

