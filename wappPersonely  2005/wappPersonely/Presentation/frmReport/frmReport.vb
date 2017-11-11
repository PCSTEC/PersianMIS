Public Class frmReport
    Friend DepartName, EngageType, MarriageType, MounthName, year, MDeparttxt, LastName, FirstName, CurDate, BeginDate, EndDate, MoveType As String
    Friend ChildCount, DateCount, DayCountUndertest As Integer
    Friend SumrootSalary, GroupSalary, SumAllSalary, BaseSalary, FixAllSalary, SumPerson, AverageEzafeKariVahed As Double
    Friend BonDate As String
    Friend BonType As String
    Friend rptName As String

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        CrystalReportViewer1.DisplayGroupTree = False
        Dim mylogOnInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Try
            mylogOnInfo.ConnectionInfo.Password = "afarinesh"
            mylogOnInfo.ConnectionInfo.UserID = "sa"
            mylogOnInfo.ConnectionInfo.DatabaseName = "personely"
            mylogOnInfo.ConnectionInfo.ServerName = "sqlsrv"
            rptReports.Database.Tables.Item(0).ApplyLogOnInfo(mylogOnInfo)
            rptReports.SetDataSource(dsReports.Tables(ReportName))
            CrystalReportViewer1.ReportSource = rptReports
            CrystalReportViewer1.DisplayGroupTree = False

            Select Case ReportName

                Case "rptHokm", "rptHokmTabaghebandiiiiii"
                    rptReports.setparametervalue("CurDate", CurDate)
                    If SumAllSalary = 0 Then
                        rptReports.setparametervalue("SumAllSalaryToString", "----------------------------------------")

                    Else
                        rptReports.setparametervalue("SumAllSalaryToString", classNumtoStr1.ConvNumToAlpha(SumAllSalary) & "  " & "—Ì«·")
                    End If

                Case "rptPersonAddress"
                    rptReports.setparametervalue("MDeparttxt", "ê“«—‘ ¬œ—” Ê ‘„«—Â  ·›‰")
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonAndPost"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonAndPost"

                    If MDeparttxt <> "" Then
                        rptReports.setparametervalue("MDeparttxt", "ê“«—‘ «›—«œ Ê Å” Â«Ì ”«“„«‰Ì Ê«Õœ" + "  " + MDeparttxt)
                    ElseIf MDeparttxt = "" And FirstName <> "" And LastName <> "" Then
                        rptReports.setparametervalue("MDeparttxt", "ê“«—‘ Å”  ”«“„«‰Ì" + "  " + FirstName + "  " + LastName)
                    Else
                        rptReports.setparametervalue("MDeparttxt", "")
                    End If


                Case "rptPersonEducation"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonIndDepart"
                    rptReports.setparametervalue("DepartName", DepartName)
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonAndGroup"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonAndEngageType"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptDossier"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonProperty"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonAndTrinning"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptMovingPerson"
                    If MoveType <> "" Then
                        rptReports.setparametervalue("MoveType", MoveType)
                    Else
                        rptReports.setparametervalue("MoveType", "")
                    End If
                    rptReports.setparametervalue("CurDate", CurDate)
                    If BeginDate <> "" Then
                        rptReports.setparametervalue("BeginDate", BeginDate)
                    Else
                        rptReports.setparametervalue("BeginDate", "")
                    End If
                    If EndDate <> "" Then
                        rptReports.setparametervalue("EndDate", EndDate)
                    Else
                        rptReports.setparametervalue("EndDate", "")
                    End If
                Case "rptPersonBime"


                    rptReports.setparametervalue("CurDate", CurDate)
                    rptReports.setparametervalue("BeginDate", BeginDate)

                    rptReports.setparametervalue("EndDate", EndDate)
                Case "rptPersonMeed"


                    rptReports.setparametervalue("CurDate", CurDate)
                    rptReports.setparametervalue("BeginDate", BeginDate)

                    rptReports.setparametervalue("EndDate", EndDate)
                Case "rptPostPersonINDepart"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonPropertyAbstract"
                    'Dim crConnectionInfo As New CrystalDecisions.Shared.ConnectionInfo
                    'With crConnectionInfo

                    '    .ServerName = "sqlsrv" 'physical server name

                    '    .DatabaseName = "personely"

                    '    .UserID = "sa"

                    '    .Password = "afarinesh"

                    'End With
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptGeneralAbstract"

                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptDossierTefkik"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptAlarmEndEmployee"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonAndJobTitle"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonOverJazb"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonOverPost"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonCard"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonFamily"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonMeed"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonValuation"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersoInDepartsBetWeenDate"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptMostaafiPersonAndTrinning"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonBeTafkikAlefba"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptMostafeePerson"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptExpertsAndGroup"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonAndTrinningBeTafkik"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonAGE"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptEzafehKariFee"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptHoghooghvaMazaiatafkikVahed"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptTabaghehBandi"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptSazehGostar"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptParakanesh"
                    rptReports.setparametervalue("CurDate", CurDate)
                    rptReports.setparametervalue("Year", year)
                    rptReports.setparametervalue("MounthName", MounthName)
                    rptReports.setparametervalue("EngageType", EngageType)

                Case "rptCommodeAmar"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptCommodeKhali"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonCommodeTafkikVahed"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptGeneralAbstract"
                    rptReports.setparametervalue("CurDate", CurDate)

                Case "rptPersonGradeCount"
                    rptReports.setparametervalue("CurDate", CurDate)

                    'Case "rptManagerPropertyAbstract"
                    '    rptReports.setparametrvalue("CurDate", CurDate)

                Case "rptPersonKhadamati"
                    rptReports.setparametervalue("CurDate", CurDate)
                    rptReports.setparametervalue("BegiDate", BeginDate)
                    rptReports.setparametervalue("EndDate", EndDate)

                Case "rptBon"
                    rptReports.setparametervalue("BonDate", BonDate)
                    rptReports.setparametervalue("BonType", BonType)
                Case "Rpt_TabagheMashaghel_2.rpt"

                    rptReports.setparametervalue("CurDate", CurDate)

                Case "Rpt_TabagheMashaghel_bazneshastegi.rpt"

                    rptReports.setparametervalue("CurDate", CurDate)
                    'rptReports.setparametervalue("BegiDate", BeginDate)
                    rptReports.setparametervalue("ToDate", EndDate)
            End Select
            CrystalReportViewer1.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class