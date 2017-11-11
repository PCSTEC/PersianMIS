Public Class Cls_ReportFacade

    Private DA1 As New SqlClient.SqlDataAdapter
    Dim a As String
    Dim CnnString As String = " Data Source=SQLSRV;Initial Catalog=Personely;Integrated Security=True;Connect Timeout=200 "

    '''   Dim CnnString As String = "packet size=4096;integrated security=SSPI;data source=SQLSRV;persist security info=False;initial catalog=Personely"
    Public Function LoadReport(ByVal ReportName As String)

        Select Case ReportName
            Case "rptPersonAndGroup"
                wstr = "SELECT     * " & _
                        "FROM         VwHR_PersonInDepart " & _
                        "WHERE (PersonCode = 0) order by PostCode"
                rptReports = New rptPersonAndGroup
                LastRepName = ReportName
                ReportName = "rptPersonAndGroup"

            Case "rptPersonAndPost"
                wstr = _
                       "SELECT     * " & _
                      "FROM         VwHR_PersonInDepart " & _
                    "WHERE (MDepartCode  = '" & a & "')order by PostCode"
                rptReports = New rptPersonAndPost
                LastRepName = ReportName
                ReportName = "rptPersonAndPost"


            Case "rptPersonAndEngageType"

                wstr = "SELECT     * " & _
                       "FROM         VwHR_PersonAndEngageType " & _
                       "WHERE (PersonCode = 0) order by PostCode "
                rptReports = New rptPersonAndEngageType
                LastRepName = ReportName
                ReportName = "rptPersonAndEngageType"


            Case "rptPersonAndJobTitle"

                wstr = "SELECT     * " & _
                       "FROM         VwHR_PersonAndJobTitle " & _
                       "WHERE (PersonCode = 0)"
                rptReports = New rptPersonAndJobTitle
                LastRepName = ReportName
                ReportName = "rptPersonAndJobTitle"


            Case "rptPersonOverJazb"

                wstr = "SELECT     * " & _
                       "FROM         VwHR_PersonOverJazb " & _
                       "WHERE (PersonCode = 0)"
                rptReports = New rptPersonOverJazb
                LastRepName = ReportName
                ReportName = "rptPersonOverJazb"


            Case "rptPersonOverPost"

                wstr = "SELECT     * " & _
                       "FROM         VwHR_PersonOverPost " & _
                       "WHERE (PersonCode = 0)"
                rptReports = New rptPersonOverPost
                LastRepName = ReportName
                ReportName = "rptPersonOverPost"



            Case "rptPersonAddress"
                wstr = _
                                     "SELECT     * " & _
                                         "FROM         VwHR_PersonInDepart " & _
                                          "WHERE (PersonCode =0) "
                rptReports = New rptPersonAddress
                LastRepName = ReportName
                ReportName = "rptPersonAddress"


            Case "rptPersonFamily"
                wstr = _
                                     "SELECT     * " & _
                                         "FROM         VwHR_PersonFamily " & _
                                          "WHERE (PersonCode = 0)"
                rptReports = New rptPersonFamily
                LastRepName = ReportName
                ReportName = "rptPersonFamily"


            Case "rptDossier"
                wstr = _
                                     "SELECT     * " & _
                                         "FROM         VwHR_Dossier " & _
                                          "WHERE (PersonCode = 0) "
                rptReports = New rptDossier
                LastRepName = ReportName
                ReportName = "rptDossier"


            Case "rptPersonMeed"
                wstr = _
                           "SELECT     * " & _
                             "FROM         VwHR_PersonMeed " & _
                              "WHERE (PersonCode = 0)"
                rptReports = New rptPersonMeed
                LastRepName = ReportName
                ReportName = "rptPersonMeed"


            Case "rptPersonPropertyAbstract"
                wstr = _
                                     "SELECT     * " & _
                                         "FROM         VwHR_PersonProperty " & _
                                          "WHERE (PersonCode = 0) "
                rptReports = New rptPersonPropertyAbstract
                LastRepName = ReportName
                ReportName = "rptPersonPropertyAbstract"


            Case "rptPersonAndTrinning"
                wstr = _
                                     "SELECT     * " & _
                                         "FROM         VwHR_TrainingInfo " & _
                                          "WHERE (PersonCode = 0) "
                rptReports = New rptPersonAndTrinning
                LastRepName = ReportName
                ReportName = "rptPersonAndTrinning"


            Case "rptPersonEducation"
                wstr = _
                                     "SELECT     * " & _
                                         "FROM         VwHR_EducationInfoForReport " & _
                                          "WHERE (PersonCode = 0) "
                rptReports = New rptPersonEducation
                LastRepName = ReportName
                ReportName = "rptPersonEducation"


            Case "rptPersonProperty"
                wstr = _
                                     "SELECT     * " & _
                                         "FROM         VwHR_PersonPropertyForReport " & _
                                          "WHERE (PersonCode = 0)"
                rptReports = New rptPersonProperty
                LastRepName = ReportName
                ReportName = "rptPersonProperty"


            Case "rptMostaafiPersonAndTrinning"
                wstr = "Select * From VwHR_MostaafiPersonAndTrinning"
                rptReports = New rptMostaafiPersonAndTrinning
                LastRepName = ReportName
                ReportName = "rptMostaafiPersonAndTrinning"


            Case "rptPersonValuation"
                wstr = _
                                     "SELECT     * " & _
                                         "FROM         VwHR_PersonValuation " & _
                                          "WHERE (PersonCode = 0) "
                rptReports = New rptPersonValuation
                LastRepName = ReportName
                ReportName = "rptPersonValuation"


            Case "rptPersoInDepartsBetWeenDate"

                wstr = _
                              "SELECT     * " & _
                              "FROM         dbo.VwHR_PersonEngageDate " & _
                              "WHERE     (PersonCode =0)"
                rptReports = New rptPersoInDepartsBetWeenDate
                LastRepName = ReportName
                ReportName = "rptPersoInDepartsBetWeenDate"



            Case "rptPersonBeTafkikAlefba"
                wstr = _
                                     "SELECT     * " & _
                                         "FROM         VwHR_PersonBeTafkikAlefba " & _
                                          "WHERE (PersonCode = 0) "
                rptReports = New rptPersonBeTafkikAlefba
                LastRepName = ReportName
                ReportName = "rptPersonBeTafkikAlefba"


            Case "rptPersonCard"
                wstr = _
                                     "SELECT     * " & _
                                         "FROM         VwHR_PersonCard " & _
                                          "WHERE (PersonCode = 0) "
                rptReports = New rptPersonCard
                LastRepName = ReportName
                ReportName = "rptPersonCard"


            Case "rptPostPersonINDepart"
                wstr = "SELECT * FROM dbo.VwHR_PostPersonINDepartForReport WHERE (PersonCode = 0)"
                rptReports = New rptPostPersonINDepart
                LastRepName = ReportName
                ReportName = "rptPostPersonINDepart"


            Case "rptMostafeePerson"
                wstr = "SELECT * FROM dbo.VwHR_MostafeePerson WHERE (DepartCode = '" & a & "')"
                rptReports = New rptMostafeePerson
                LastRepName = ReportName
                ReportName = "rptMostafeePerson"


            Case "rptExpertsAndGroup"
                wstr = " SELECT * FROM dbo.VwHR_ExpertsAndGroup WHERE (PersonCode = 0)"
                rptReports = New rptExpertsAndGroup
                LastRepName = ReportName
                ReportName = "rptExpertsAndGroup"


            Case "rptPersonAndTrinningBeTafkik"
                wstr = "SELECT * FROM dbo.VwHR_PersonAndTrinningForReport WHERE (PersonCode = 0)"
                rptReports = New rptPersonAndTrinningBeTafkik
                LastRepName = ReportName
                ReportName = "rptPersonAndTrinningBeTafkik"



            Case "rptPersonAGE"
                wstr = "SELECT * FROM dbo.VwHR_PersonAge WHERE (PersonCode = 0)"
                rptReports = New rptPersonAGE
                LastRepName = ReportName
                ReportName = "rptPersonAGE"


            Case "rptDossierTefkik"
                wstr = _
                                                "SELECT     * " & _
                                                    "FROM         VwHR_DossierForReport " & _
                                                     "WHERE (PersonCode = 0)"
                rptReports = New rptDossierTefkik
                LastRepName = ReportName
                ReportName = "rptDossierTefkik"


            Case "rptEzafehKariFee"
                wstr = _
                            "SELECT  * " & _
                            "FROM     VwHR_EzafehKariVahed " & _
                            "WHERE (PersonCode = 0)"
                rptReports = New rptEzafehKariFee
                LastRepName = ReportName
                ReportName = "rptEzafehKariFee"


            Case "rptHoghooghvaMazaiatafkikVahed"
                wstr = _
                            "SELECT  * " & _
                            "FROM     VwHR_HooghooghMazaiaForReport " & _
                            "WHERE (PersonCode = 0)"
                rptReports = New rptHoghooghvaMazaiatafkikVahed
                LastRepName = ReportName
                ReportName = "rptHoghooghvaMazaiatafkikVahed"



                'ElseIf cmbReportType.SelectedValue = 122 Then
                ''wstr = 

                'rptReports = New rptSazehGostar
                'LastRepName = ReportName
                'ReportName = "rptSazehGostar"

            Case "rptTabaghehBandi"
                wstr = _
                            "SELECT  * " & _
                            "FROM     VwHR_HooghooghMazaiaForReport " & _
                            "WHERE (PersonCode = 0)"
                rptReports = New rptTabaghehBandi
                LastRepName = ReportName
                ReportName = "rptTabaghehBandi"

            Case "rptMovingPerson"
                wstr = _
                         "SELECT     * " & _
                         "FROM         VwHR_MovingPersonForReport " & _
                         "WHERE (PersonCode = 0)"
                rptReports = New rptMovingPerson
                LastRepName = ReportName
                ReportName = "rptMovingPerson"

                rptReports.setparametervalue("CurDate", IraniDate1.GetIraniFullDateTime_CurDate)


        End Select
        Call rptLoad()
    End Function
    Private Sub rptLoad()
        ReportName = LastRepName
        Try
            dsReports.Tables.Clear()
            If dsReports.Tables.Count > 0 Then
                dsReports.Tables(LastRepName).Clear()
            End If
            DA1 = Persist1.GetDataAccess(wstr, 1, ConString, ReportName, dsReports)
            Dim f1 As New frmReport
            f1.CurDate = IraniDate1.GetIraniDayName_CurDate + "  " + IraniDate1.GetIrani8DateStr_CurDate
            f1.Show()
        Catch ex As Exception
            Dim r3 As DialogResult = MessageBox.Show("ﬂ·Ìﬂ ‰„«ÌÌœ Help »— —ÊÌ ”Ì” „ ‘„« ‰’» ‰„Ì »«‘œ »—«Ì ‰’» ‰—„ «›“«— —ÊÌ œﬂ„Â  Crystal Report2005", _
                                                      "Help Caption", MessageBoxButtons.OK, _
                                                      MessageBoxIcon.Question, _
                                                      MessageBoxDefaultButton.Button1, _
                                                      0, "\\Nt_dbms\mis\iso\Help\WareSupply for 2005\CRRedist2005_x86.msi", _
                                                      HelpNavigator.Index)
        End Try
    End Sub



End Class
