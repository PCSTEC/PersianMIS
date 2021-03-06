Public Class FrmOlad_18

    Private Sub FrmOlad_18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrd()
    End Sub

    Private Function FillGrd()
        Dim dt_EducationType As New DataTable
        SqlStr = _
        "SELECT        PersonCode, FirstName, LastName, EngageType, Expr1, Expr2, AffineTxt, Active, BirthDate, AffineID,  " & _
        "                         SUBSTRING(GeneralObjects.dbo.FunGen_MiladiDToShamsiS(SUBSTRING(CONVERT(char(10), GETDATE(), 20), 1, 4) + '/' + SUBSTRING(CONVERT(char(10),  " & _
        "                         GETDATE(), 20), 6, 2) + '/' + SUBSTRING(CONVERT(char(10), GETDATE(), 20), 9, 2)), 1, 4) - CAST(SUBSTRING(BirthDate, 1, 4) AS int) AS age, DepartName " & _
        "FROM            dbo.[02-bime] " & _
        "WHERE        (AffineID = 2 OR " & _
        "                         AffineID = 3) AND (SUBSTRING(GeneralObjects.dbo.FunGen_MiladiDToShamsiS(SUBSTRING(CONVERT(char(10), GETDATE(), 20), 1, 4)  " & _
        "                         + '/' + SUBSTRING(CONVERT(char(10), GETDATE(), 20), 6, 2) + '/' + SUBSTRING(CONVERT(char(10), GETDATE(), 20), 9, 2)), 1, 4) - CAST(SUBSTRING(BirthDate, 1, 4) " & _
        "                          AS int) >= 18)"

        dt_EducationType = Persist1.GetDataTable(ConString, SqlStr)
        janus1.GetBindJGrid_DT(dt_EducationType, grdOlad, ConString)
        janus1.setMyJGrid(grdOlad, "PersonCode", "شماره پرسنلی", 75)
        janus1.setMyJGrid(grdOlad, "FirstName", "نام", 75)
        janus1.setMyJGrid(grdOlad, "LastName", "نام خانوادگی", 75)
        janus1.setMyJGrid(grdOlad, "EngageType", "نوع استخدام", 75)
        janus1.setMyJGrid(grdOlad, "DepartName", "نام واحد", 75)
        janus1.setMyJGrid(grdOlad, "Expr1", "نام فرزند", 75)
        janus1.setMyJGrid(grdOlad, "Expr2", "نام خانوادگی فرزند", 75)
        janus1.setMyJGrid(grdOlad, "AffineTxt", "جنسیت", 75)
        janus1.setMyJGrid(grdOlad, "BirthDate", "تاریخ تولد", 75)
        janus1.setMyJGrid(grdOlad, "age", "سن", 75)

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        SqlStr = _
        "SELECT        PersonCode, FirstName, LastName, EngageType, Expr1, Expr2, AffineTxt, Active, BirthDate, AffineID,  " & _
        "                         SUBSTRING(GeneralObjects.dbo.FunGen_MiladiDToShamsiS(SUBSTRING(CONVERT(char(10), GETDATE(), 20), 1, 4) + '/' + SUBSTRING(CONVERT(char(10),  " & _
        "                         GETDATE(), 20), 6, 2) + '/' + SUBSTRING(CONVERT(char(10), GETDATE(), 20), 9, 2)), 1, 4) - CAST(SUBSTRING(BirthDate, 1, 4) AS int) AS age, DepartName " & _
        "FROM            dbo.[02-bime] " & _
        "WHERE        (AffineID = 2 OR " & _
        "                         AffineID = 3) AND (SUBSTRING(GeneralObjects.dbo.FunGen_MiladiDToShamsiS(SUBSTRING(CONVERT(char(10), GETDATE(), 20), 1, 4)  " & _
        "                         + '/' + SUBSTRING(CONVERT(char(10), GETDATE(), 20), 6, 2) + '/' + SUBSTRING(CONVERT(char(10), GETDATE(), 20), 9, 2)), 1, 4) - CAST(SUBSTRING(BirthDate, 1, 4) " & _
        "                          AS int) >= 18)"
        dt = Persist1.GetDataTable(ConString, SqlStr)
        Utility1.ExportTo(dt, IKIDUtility.ExportType.Excel)
    End Sub
End Class