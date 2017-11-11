Public Class frmMostaafiPerson
    Dim bus_commode1 As New Bus_Commode
    Dim dt_MostaafiPerson As New DataTable
    'Friend frmCommodeDevotion1 As New frmCommodeDevotion
    Private Sub frmAddCommodeNumber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillMyGride()
    End Sub

    Friend Function FillMyGride()
        dt_MostaafiPerson = bus_commode1.PersonMostaafi
        janus1.GetBindJGrid_DT(dt_MostaafiPerson, grdPerson, ConString)
        janus1.setMyJGrid(grdPerson, "PersonCode", "ﬂœ Å—”‰·Ì", 75)
        janus1.setMyJGrid(grdPerson, "prName", "‰«„ Ê ‰«„ Œ«‰Ê«œêÌ", 150)
        janus1.setMyJGrid(grdPerson, "MDepartName", "‰«„ Ê«Õœ", 100)
        janus1.setMyJGrid(grdPerson, "DepartName", "‰«„ «œ«—Â", 100)
        janus1.setMyJGrid(grdPerson, "CommodeNumber", "‘„«—Â ﬂ„œ", 50)
        janus1.setMyJGrid(grdPerson, "TahvilDate", " «—ÌŒ  ÕÊÌ· ﬂ„œ", 75)
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class