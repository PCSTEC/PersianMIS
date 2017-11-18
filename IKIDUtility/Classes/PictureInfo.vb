Imports System.IO
Namespace PictureInfo
    Public Class PictureInfo
        Dim PictureBuffer() As Byte
        Dim TempPicture As System.Windows.Forms.PictureBox
        Public Function getImageBuffer_Ins(ByVal PictureBox1 As System.Windows.Forms.PictureBox) As Byte()
            Try
                Dim MS As New MemoryStream
                PictureBox1.Image.Save(MS, PictureBox1.Image.RawFormat)
                PictureBuffer = MS.GetBuffer
                MS.Close()
                Return PictureBuffer
            Catch
                Return Nothing
            End Try
        End Function
        Public Function getImageBuffer_Load(ByVal PicVal As System.Array)
            Dim MS As New MemoryStream
            PictureBuffer = CType(PicVal, Byte())
            MS = New MemoryStream(PictureBuffer)
            Return TempPicture.Image.FromStream(MS)
            MS.Close()
        End Function
        Public Function getImageBuffer_Load(ByVal PicVal As System.DBNull)
            Return Nothing
        End Function
    End Class
End Namespace

