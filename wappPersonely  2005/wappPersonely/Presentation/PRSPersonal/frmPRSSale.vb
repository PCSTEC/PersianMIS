
Public Class frmPRSSale
    Public PersonCode As Long

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub fillGrd()
        Dim dt_Person As New DataTable

        SqlStr = _
    "SELECT     TOP (100) PERCENT Personely.dbo.tbHR_Person.PersonCode, Personely.dbo.tbHR_Person.LastName, is_adm.dbo.tbPRSMonth.PrstMText,  " & _
    "                      Personely.dbo.tbHR_Person.LastName + N'  ' + Personely.dbo.tbHR_Person.FirstName AS Expr1, Pay__1.Netpay , Pay__1.Moaveg,  " & _
    "                      Pay__1.Taxable  , Pay__1.Skol1  , Pay__1.Paymozd_3 , Pay__1.Paymozd_4 , Pay__1.paykar_16 ,  " & _
    "                      Pay__1.Totover, Pay__1.Rial_b , Pay__1.Omr1 , Pay__1.vam_3 ,  " & _
    "                      Pay__1.vam_4 , Pay__1.vam_8 , Pay__1.Bimeh , Pay__1.Tax  , Pay__1.vam_1 ,  " & _
    "                      Pay__1.Paymozd_11  " & _
    "FROM         SQLSRVMALI.MALIRAN_20_1395.dbo.Pay_ AS Pay__1 INNER JOIN " & _
    "                      Personely.dbo.tbHR_Card ON Pay__1.EMPNO = Personely.dbo.tbHR_Card.CardNumber INNER JOIN " & _
    "                      Personely.dbo.tbHR_Person ON Personely.dbo.tbHR_Card.PersonID = Personely.dbo.tbHR_Person.PersonID INNER JOIN " & _
    "                      is_adm.dbo.tbPRSMonth ON Pay__1.CODEMAH = is_adm.dbo.tbPRSMonth.PrstMID " & _
    "WHERE     (Personely.dbo.tbHR_Person.PersonCode = " & PersonCode & ") " & _
    "ORDER BY CODEMAH"


        dt_Person = Persist1.GetDataTable(ConString, SqlStr)
        dt_Person.DefaultView.Sort = "LastName"
        janus1.GetBindJGrid_DT(dt_Person, grdPerson, ConString)
        janus1.setMyJGrid(grdPerson, "PrstMText", "ماه", 75)
        janus1.setMyJGrid(grdPerson, "Netpay", "خالص پرداختی", 95)

        janus1.setMyJGrid(grdPerson, "Taxable", "جمع در آمد", 150)
        janus1.setMyJGrid(grdPerson, "Skol1", "حقوق ثابت", 190)
        janus1.setMyJGrid(grdPerson, "Paymozd_3", "خواربار", 90)
        janus1.setMyJGrid(grdPerson, "Paymozd_4", "مسکن", 80)
        janus1.setMyJGrid(grdPerson, "paykar_16", "معوقه", 75, , , True)
        janus1.setMyJGrid(grdPerson, "vam_4", "وام صندوق", 75, , , True)

        janus1.setMyJGrid(grdPerson, "vam_8", "پس انداز تعاونی خاص", 120)
        janus1.setMyJGrid(grdPerson, "Bimeh", "حق بیمه", 75)
        
        janus1.setMyJGrid(grdPerson, "Tax", "مالیات", 75, , , True)
        janus1.setMyJGrid(grdPerson, "vam_1", "وام", 75, , , True)
        janus1.setMyJGrid(grdPerson, "Paymozd_11", "کمک هزینه خانوار", 75, , , True)
        janus1.setMyJGrid(grdPerson, "Rial_b", "اضافه ریال", 75, , , True)
        janus1.setMyJGrid(grdPerson, "Omr1", "بیمه عمر و حوادث", 75, , , True)
        janus1.setMyJGrid(grdPerson, "vam_3", "سپرده صندوق وام", 75, , , True)
       

    End Sub

    Private Sub frmPRSSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillGrd()
    End Sub
End Class