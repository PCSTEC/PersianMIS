Public Class frmStayParakanesh
    Dim dt_Parakanesh, dt_CountPerson, dt_CountPersonSafTafkik, dt_CountPersonSetadTafkik, dt_AvgPersonAge, dt_CountMan, dt_CountWoman As New DataTable
    Dim sstr, MDepartName, DepartCode As String
    Dim CountMan, _Year, _EngageType, _Mounth, CountPersonSV, CountPersonTV, ParakaneshMounth, ParakaneshYear, CountPersonSafTafkik, CountPersonSetadTafkik, AvgDepartAge, CountZirDiplomTV, CountDiplomTV, CountFogDiplomTV, CountLisancTV, CountFogLisancTV, CountDoctoraTV, CountZirDiplomSV, CountDiplomSV, CountFogDiplomSV, CountLisancSV, CountFogLisancSV, CountDoctoraSV, CountWoman, SafSetadID, DepartID As Integer
    Dim Bus_Parakanesh1 As New Bus_Parakanesh

    Public Property Year()
        Get
            Return _Year
        End Get
        Set(ByVal value)
            _Year = value
        End Set
    End Property

    Public Property Mounth()
        Get
            Return _Mounth
        End Get
        Set(ByVal value)
            _Mounth = value
        End Set
    End Property
    ''اگر 1 باشد براي شركتي ها و اگر 2 باشد براي خدماتي ها
    Public Property EngageType()
        Get
            Return _EngageType
        End Get
        Set(ByVal value)
            _EngageType = value
        End Set
    End Property

    Private Sub frmStay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''''محاسبه پراكنش براي پرسنل شركتي
        If EngageType = 1 Then
            SqlStr = "Select * From VwHR_Parakanesh_SherkatForReport"
            dt_Parakanesh = Persist1.GetDataTable(ConString, SqlStr)
            sstr = ""
            sstr = "select CountSexID from VwHR_Parakanesh_SherkatCountSexID where SexID = 1"
            dt_CountMan = Persist1.GetDataTable(ConString, sstr)
            CountMan = dt_CountMan.DefaultView.Item(0).Item("CountSexID")
            sstr = "'"
            sstr = "select CountSexID from VwHR_Parakanesh_SherkatCountSexID where SexID = 2"
            dt_CountWoman = Persist1.GetDataTable(ConString, sstr)
            CountWoman = dt_CountWoman.DefaultView.Item(0).Item("CountSexID")
            For i = 0 To dt_Parakanesh.Rows.Count - 1
                DepartID = dt_Parakanesh.DefaultView.Item(i).Item("DepartID")
                DepartCode = dt_Parakanesh.DefaultView.Item(i).Item("DepartCode")
                SafSetadID = dt_Parakanesh.DefaultView.Item(i).Item("SafSetadID")
                MDepartName = dt_Parakanesh.DefaultView.Item(i).Item("MDepartName")
                CountDoctoraSV = dt_Parakanesh.DefaultView.Item(i).Item("CountDoctoraSV")
                CountFogLisancSV = dt_Parakanesh.DefaultView.Item(i).Item("CountFogLisancSV")
                CountLisancSV = dt_Parakanesh.DefaultView.Item(i).Item("CountLisancSV")
                CountFogDiplomSV = dt_Parakanesh.DefaultView.Item(i).Item("CountFogDiplomSV")
                CountDiplomSV = dt_Parakanesh.DefaultView.Item(i).Item("CountDiplomSV")
                CountZirDiplomSV = dt_Parakanesh.DefaultView.Item(i).Item("CountZirDiplomSV")
                CountDoctoraTV = dt_Parakanesh.DefaultView.Item(i).Item("CountDoctoraTV")
                CountFogLisancTV = dt_Parakanesh.DefaultView.Item(i).Item("CountFogLisancTV")
                CountLisancTV = dt_Parakanesh.DefaultView.Item(i).Item("CountLisancTV")
                CountFogDiplomTV = dt_Parakanesh.DefaultView.Item(i).Item("CountFogDiplomTV")
                CountDiplomTV = dt_Parakanesh.DefaultView.Item(i).Item("CountDiplomTV")
                CountZirDiplomTV = dt_Parakanesh.DefaultView.Item(i).Item("CountZirDiplomTV")
                sstr = ""
                ''''محاسبه اين واحد تايم اوت مي شود ماهيانه عدد زير عوض شود
                If dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") = "TT500" Then
                    AvgDepartAge = 29
                Else

                    sstr = "SELECT   AVG(Age) AS AvgPersonAge FROM         dbo.VwHR_PersonAge WHERE     (EngageTypeID = 1 OR     EngageTypeID = 2 OR     EngageTypeID = 3 OR        EngageTypeID = 4 OR       EngageTypeID = 5 OR        EngageTypeID = 7 or EngageTypeID = 11) AND (DepartCode ='" & dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") & "') "

                    '  sstr = "Select AvgPersonAge from VwHR_AVGPersonAge where DepartCode = '" & dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") & "' and (EngageTypeID=1 or EngageTypeID=2 or EngageTypeID=3 or EngageTypeID=4 or EngageTypeID=5 or EngageTypeID=7 )"
                    dt_AvgPersonAge = Persist1.GetDataTable(ConString, sstr)
                    AvgDepartAge = Utility1.NZ(dt_AvgPersonAge.DefaultView.Item(0).Item("AvgPersonAge"), 0)
                End If
                sstr = ""
                sstr = _
                "SELECT     dbo.VwHR_CountPerson.CountPerson, dbo.VwHR_CountPerson.MDepartCode, dbo.VwHR_MDepart.SafSetadID " & _
                "FROM         dbo.VwHR_CountPerson INNER JOIN " & _
                "                      dbo.VwHR_MDepart ON dbo.VwHR_CountPerson.MDepartCode = dbo.VwHR_MDepart.DepartCode " & _
                "WHERE     (dbo.VwHR_CountPerson.MDepartCode = '" & dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") & "') AND (dbo.VwHR_MDepart.SafSetadID = 2)"
                dt_CountPersonSetadTafkik = Persist1.GetDataTable(ConString, sstr)
                If dt_CountPersonSetadTafkik.Rows.Count = 0 Then
                    CountPersonSetadTafkik = 0
                Else
                    CountPersonSetadTafkik = dt_CountPersonSetadTafkik.DefaultView.Item(0).Item("CountPerson")
                End If
                sstr = ""
                sstr = _
                "SELECT     dbo.VwHR_CountPerson.CountPerson, dbo.VwHR_CountPerson.MDepartCode, dbo.VwHR_MDepart.SafSetadID " & _
                "FROM         dbo.VwHR_CountPerson INNER JOIN " & _
                "                      dbo.VwHR_MDepart ON dbo.VwHR_CountPerson.MDepartCode = dbo.VwHR_MDepart.DepartCode " & _
                "WHERE     (dbo.VwHR_CountPerson.MDepartCode = '" & dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") & "') AND (dbo.VwHR_MDepart.SafSetadID = 1)"
                dt_CountPersonSafTafkik = Persist1.GetDataTable(ConString, sstr)
                If dt_CountPersonSafTafkik.Rows.Count = 0 Then
                    CountPersonSafTafkik = 0
                Else
                    CountPersonSafTafkik = dt_CountPersonSafTafkik.DefaultView.Item(0).Item("CountPerson")
                End If
                ParakaneshYear = Year
                ParakaneshMounth = Mounth
                ''''تعداد پرسنل تمام وقت هر واحد
                sstr = "SELECT COUNT(DepartCode) AS COUNTPerson FROM VwHR_Parakanesh_Sherkat WHERE (EngageTypeID = 1 OR EngageTypeID = 2 OR EngageTypeID = 5 or EngageTypeID = 7 or EngageTypeID = 11) AND (DepartCode ='" & dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") & "')"
                dt_CountPerson = Persist1.GetDataTable(ConString, sstr)
                CountPersonTV = dt_CountPerson.DefaultView.Item(0).Item("COUNTPerson")
                ''''تعداد پرسنل ساعتي هر واحد
                sstr = "SELECT COUNT(DepartCode) AS COUNTPerson FROM VwHR_Parakanesh_Sherkat WHERE (EngageTypeID = 7 or EngageTypeID = 11) AND (DepartCode = '" & dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") & "')"
                dt_CountPerson = Persist1.GetDataTable(ConString, sstr)
                CountPersonSV = dt_CountPerson.DefaultView.Item(0).Item("COUNTPerson")
                Bus_Parakanesh1.insert_tbHR_Parakanesh(DepartID, DepartCode, SafSetadID, MDepartName, CountDoctoraSV, CountFogLisancSV, CountLisancSV, CountFogDiplomSV, CountDiplomSV, CountZirDiplomSV, CountDoctoraTV, CountFogLisancTV, CountLisancTV, CountFogDiplomTV, CountDiplomTV, CountZirDiplomTV, CountMan, CountWoman, AvgDepartAge, CountPersonSafTafkik, CountPersonSetadTafkik, ParakaneshYear, ParakaneshMounth, CountPersonTV, CountPersonSV, EngageType)
            Next


            SqlStr = _
            "SELECT     AVG(Age) AS AvgPersonAge, DiplomaCategoryName, DiplomCatID ,EngageTypeTxt " & _
            "FROM         dbo.VwHR_PersonAge " & _
            "WHERE     (EngageTypeID = 1 OR " & _
            "                      EngageTypeID = 2 OR " & _
            "                      EngageTypeID = 3 OR " & _
            "                      EngageTypeID = 4 OR " & _
            "                      EngageTypeID = 5 OR " & _
            "                      EngageTypeID = 11 OR " & _
            "                      EngageTypeID = 7) " & _
            "GROUP BY DiplomaCategoryName, DiplomCatID, EngageTypeTxt "

            dt_CountPerson = Persist1.GetDataTable(ConString, SqlStr)

            Dim ParakanshAgeDiplomID As Integer


            If dt_CountPerson.DefaultView.Count > 0 Then
                SqlStr = "INSERT INTO [Personely].[dbo].[tbHR_ParakaneshAgeDiplom]([Year],[Month],[EngageType]) " & _
                                              " VALUES (" & ParakaneshYear & "," & ParakaneshMounth & " ,1)"
                Persist1.GetDataAccess(SqlStr, 2, ConString)
            End If



            For i = 0 To dt_CountPerson.DefaultView.Count - 1

                Select Case dt_CountPerson.DefaultView.Item(i).Item("DiplomCatID")
                    Case 1
                        If dt_CountPerson.DefaultView.Item(i).Item("EngageTypeTxt") = "قراردادي" Then

                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [ZirDiplom] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        Else
                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [ZirDiplomHour] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)
                        End If
                    Case 2
                        If dt_CountPerson.DefaultView.Item(i).Item("EngageTypeTxt") = "قراردادي" Then

                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Diplom] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        Else
                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [DiplomHour] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)
                        End If

                    Case 3
                        If dt_CountPerson.DefaultView.Item(i).Item("EngageTypeTxt") = "قراردادي" Then

                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [FogDiplom] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        Else
                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [FogDiplomHour] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)
                        End If
                    Case 4

                        If dt_CountPerson.DefaultView.Item(i).Item("EngageTypeTxt") = "قراردادي" Then

                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Lisans] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        Else
                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [LisansHour] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        End If
                    Case 5

                        If dt_CountPerson.DefaultView.Item(i).Item("EngageTypeTxt") = "قراردادي" Then

                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [FogLisans] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        Else
                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [FogLisansHour] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)
                        End If
                    Case 6

                        If dt_CountPerson.DefaultView.Item(i).Item("EngageTypeTxt") = "قراردادي" Then

                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Doctra] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        Else
                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [DoctraHour] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)
                        End If




                End Select




            Next

            SqlStr = _
                       "SELECT     AVG(Age) AS AvgPersonAge,SafSetadID " & _
                       "FROM         dbo.VwHR_PersonAge " & _
                       "WHERE     (EngageTypeID = 1 OR " & _
                       "                      EngageTypeID = 2 OR " & _
                       "                      EngageTypeID = 3 OR " & _
                       "                      EngageTypeID = 4 OR " & _
                       "                      EngageTypeID = 5 OR " & _
                       "                      EngageTypeID = 11 OR " & _
                       "                      EngageTypeID = 7) " & _
                       "GROUP BY SafSetadID  "

            dt_CountPerson = Persist1.GetDataTable(ConString, SqlStr)

            For i = 0 To dt_CountPerson.DefaultView.Count - 1

                If dt_CountPerson.DefaultView.Item(i).Item("SafSetadID") = 1 Then

                    SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Saf] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                    Persist1.GetDataAccess(SqlStr, 2, ConString)

                Else
                    SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Setad] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                    Persist1.GetDataAccess(SqlStr, 2, ConString)
                End If
            Next

            SqlStr = _
                                "SELECT     AVG(Age) AS AvgPersonAge,SexID " & _
                                "FROM         dbo.VwHR_PersonAge " & _
                                "WHERE     (EngageTypeID = 1 OR " & _
                                "                      EngageTypeID = 2 OR " & _
                                "                      EngageTypeID = 3 OR " & _
                                "                      EngageTypeID = 4 OR " & _
                                "                      EngageTypeID = 5 OR " & _
                                "                      EngageTypeID = 11 OR " & _
                                "                      EngageTypeID = 7) " & _
                                "GROUP BY SexID  "

            dt_CountPerson = Persist1.GetDataTable(ConString, SqlStr)

            For i = 0 To dt_CountPerson.DefaultView.Count - 1

                If dt_CountPerson.DefaultView.Item(i).Item("SexID") = 1 Then

                    SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Man] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                    Persist1.GetDataAccess(SqlStr, 2, ConString)

                Else
                    SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Women] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                    Persist1.GetDataAccess(SqlStr, 2, ConString)
                End If
            Next




            Me.Close()

            ''''محاسبه پراكنش براي پرسنل خدماتي
        ElseIf EngageType = 2 Then
            SqlStr = "Select * From VwHR_Parakanesh_KhadamatForReport"
            dt_Parakanesh = Persist1.GetDataTable(ConString, SqlStr)
            sstr = ""
            sstr = "select CountSexID from VwHR_Parakanesh_KhadamatCountSexID where SexID = 1"
            dt_CountMan = Persist1.GetDataTable(ConString, sstr)
            CountMan = dt_CountMan.DefaultView.Item(0).Item("CountSexID")
            sstr = ""
            sstr = "select CountSexID from VwHR_Parakanesh_KhadamatCountSexID where SexID = 2"
            dt_CountWoman = Persist1.GetDataTable(ConString, sstr)
            If dt_CountWoman.DefaultView.Count = 0 Then
                CountWoman = 0
            Else
                CountWoman = dt_CountWoman.DefaultView.Item(0).Item("CountSexID")

            End If
            For i = 0 To dt_Parakanesh.Rows.Count - 1
                DepartID = dt_Parakanesh.DefaultView.Item(i).Item("DepartID")
                DepartCode = dt_Parakanesh.DefaultView.Item(i).Item("DepartCode")
                SafSetadID = dt_Parakanesh.DefaultView.Item(i).Item("SafSetadID")
                MDepartName = dt_Parakanesh.DefaultView.Item(i).Item("MDepartName")
                CountDoctoraSV = dt_Parakanesh.DefaultView.Item(i).Item("CountDoctoraSV")
                CountFogLisancSV = dt_Parakanesh.DefaultView.Item(i).Item("CountFogLisancSV")
                CountLisancSV = dt_Parakanesh.DefaultView.Item(i).Item("CountLisancSV")
                CountFogDiplomSV = dt_Parakanesh.DefaultView.Item(i).Item("CountFogDiplomSV")
                CountDiplomSV = dt_Parakanesh.DefaultView.Item(i).Item("CountDiplomSV")
                CountZirDiplomSV = dt_Parakanesh.DefaultView.Item(i).Item("CountZirDiplomSV")
                CountDoctoraTV = dt_Parakanesh.DefaultView.Item(i).Item("CountDoctoraTV")
                CountFogLisancTV = dt_Parakanesh.DefaultView.Item(i).Item("CountFogLisancTV")
                CountLisancTV = dt_Parakanesh.DefaultView.Item(i).Item("CountLisancTV")
                CountFogDiplomTV = dt_Parakanesh.DefaultView.Item(i).Item("CountFogDiplomTV")
                CountDiplomTV = dt_Parakanesh.DefaultView.Item(i).Item("CountDiplomTV")
                CountZirDiplomTV = dt_Parakanesh.DefaultView.Item(i).Item("CountZirDiplomTV")

                ''''محاسبه اين واحد تايم اوت مي شود ماهيانه عدد زير عوض شود
                If dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") = "TT500" Then
                    AvgDepartAge = 29
                Else
                    sstr = "Select AvgPersonAge from VwHR_AVGPersonAge where DepartCode = '" & dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") & "'  and (EngageTypeID=8 or EngageTypeID=9)"
                    dt_AvgPersonAge = Persist1.GetDataTable(ConString, sstr)
                    AvgDepartAge = dt_AvgPersonAge.DefaultView.Item(0).Item("AvgPersonAge")
                End If
                'sstr = ""
                'sstr = "Select AvgPersonAge from VwHR_AVGPersonAge where DepartCode = '" & dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") & "'"
                'dt_AvgPersonAge = Persist1.GetDataTable(ConString, sstr)
                'AvgDepartAge = dt_AvgPersonAge.DefaultView.Item(0).Item("AvgPersonAge")
                sstr = ""
                sstr = _
                "SELECT     dbo.VwHR_CountPersonKhadamat.CountPerson, dbo.VwHR_CountPersonKhadamat.MDepartCode, dbo.VwHR_MDepart.SafSetadID " & _
                "FROM         dbo.VwHR_CountPersonKhadamat INNER JOIN " & _
                "                      dbo.VwHR_MDepart ON dbo.VwHR_CountPersonKhadamat.MDepartCode = dbo.VwHR_MDepart.DepartCode " & _
                "WHERE     (dbo.VwHR_CountPersonKhadamat.MDepartCode = '" & dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") & "') AND (dbo.VwHR_MDepart.SafSetadID = 2)"

                dt_CountPersonSetadTafkik = Persist1.GetDataTable(ConString, sstr)
                If dt_CountPersonSetadTafkik.Rows.Count = 0 Then
                    CountPersonSetadTafkik = 0
                Else
                    CountPersonSetadTafkik = dt_CountPersonSetadTafkik.DefaultView.Item(0).Item("CountPerson")
                End If
                sstr = ""
                sstr = _
                "SELECT     dbo.VwHR_CountPersonKhadamat.CountPerson, dbo.VwHR_CountPersonKhadamat.MDepartCode, dbo.VwHR_MDepart.SafSetadID " & _
                "FROM         dbo.VwHR_CountPersonKhadamat INNER JOIN " & _
                "                      dbo.VwHR_MDepart ON dbo.VwHR_CountPersonKhadamat.MDepartCode = dbo.VwHR_MDepart.DepartCode " & _
                "WHERE     (dbo.VwHR_CountPersonKhadamat.MDepartCode = '" & dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") & "') AND (dbo.VwHR_MDepart.SafSetadID = 1)"

                dt_CountPersonSafTafkik = Persist1.GetDataTable(ConString, sstr)
                If dt_CountPersonSafTafkik.Rows.Count = 0 Then
                    CountPersonSafTafkik = 0
                Else
                    CountPersonSafTafkik = dt_CountPersonSafTafkik.DefaultView.Item(0).Item("CountPerson")
                End If
                ParakaneshYear = Year
                ParakaneshMounth = Mounth
                ''''تعداد پرسنل تمام وقت هر واحد
                sstr = "SELECT COUNT(DepartCode) AS COUNTPerson FROM VwHR_Parakanesh_Khadamat WHERE (EngageTypeID = 9) AND (DepartCode ='" & dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") & "')"
                dt_CountPerson = Persist1.GetDataTable(ConString, sstr)
                CountPersonTV = dt_CountPerson.DefaultView.Item(0).Item("COUNTPerson")
                ''''تعداد پرسنل ساعتي هر واحد
                sstr = "SELECT COUNT(DepartCode) AS COUNTPerson FROM VwHR_Parakanesh_Khadamat WHERE (EngageTypeID = 10) AND (DepartCode = '" & dt_Parakanesh.DefaultView.Item(i).Item("DepartCode") & "')"
                dt_CountPerson = Persist1.GetDataTable(ConString, sstr)
                CountPersonSV = dt_CountPerson.DefaultView.Item(0).Item("COUNTPerson")
                Bus_Parakanesh1.insert_tbHR_Parakanesh(DepartID, DepartCode, SafSetadID, MDepartName, CountDoctoraSV, CountFogLisancSV, CountLisancSV, CountFogDiplomSV, CountDiplomSV, CountZirDiplomSV, CountDoctoraTV, CountFogLisancTV, CountLisancTV, CountFogDiplomTV, CountDiplomTV, CountZirDiplomTV, CountMan, CountWoman, AvgDepartAge, CountPersonSafTafkik, CountPersonSetadTafkik, ParakaneshYear, ParakaneshMounth, CountPersonTV, CountPersonSV, EngageType)
            Next


            SqlStr = _
                    "SELECT     AVG(Age) AS AvgPersonAge, DiplomaCategoryName, DiplomCatID ,EngageTypeTxt " & _
                    "FROM         dbo.VwHR_PersonAge " & _
                    "WHERE    (EngageTypeID=8 or EngageTypeID=9) " & _
                    "GROUP BY DiplomaCategoryName, DiplomCatID, EngageTypeTxt "

            dt_CountPerson = Persist1.GetDataTable(ConString, SqlStr)

            Dim ParakanshAgeDiplomID As Integer


            If dt_CountPerson.DefaultView.Count > 0 Then
                SqlStr = "INSERT INTO [Personely].[dbo].[tbHR_ParakaneshAgeDiplom]([Year],[Month],[EngageType]) " & _
                                              " VALUES (" & ParakaneshYear & "," & ParakaneshMounth & ",2 )"
                Persist1.GetDataAccess(SqlStr, 2, ConString)
            End If



            For i = 0 To dt_CountPerson.DefaultView.Count - 1

                Select Case dt_CountPerson.DefaultView.Item(i).Item("DiplomCatID")
                    Case 1
                        If dt_CountPerson.DefaultView.Item(i).Item("EngageTypeTxt") = "پيمانکاري" Then

                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [ZirDiplom] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        Else
                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [ZirDiplomHour] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)
                        End If
                    Case 2
                        If dt_CountPerson.DefaultView.Item(i).Item("EngageTypeTxt") = "پيمانکاري" Then

                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Diplom] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        Else
                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [DiplomHour] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)
                        End If

                    Case 3
                        If dt_CountPerson.DefaultView.Item(i).Item("EngageTypeTxt") = "پيمانکاري" Then

                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [FogDiplom] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        Else
                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [FogDiplomHour] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)
                        End If
                    Case 4

                        If dt_CountPerson.DefaultView.Item(i).Item("EngageTypeTxt") = "پيمانکاري" Then

                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Lisans] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        Else
                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [LisansHour] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        End If
                    Case 5

                        If dt_CountPerson.DefaultView.Item(i).Item("EngageTypeTxt") = "پيمانکاري" Then

                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [FogLisans] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        Else
                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [FogLisansHour] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)
                        End If
                    Case 6

                        If dt_CountPerson.DefaultView.Item(i).Item("EngageTypeTxt") = "پيمانکاري" Then

                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Doctra] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)

                        Else
                            SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [DoctraHour] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                            Persist1.GetDataAccess(SqlStr, 2, ConString)
                        End If




                End Select




            Next

            SqlStr = _
                       "SELECT     AVG(Age) AS AvgPersonAge,SafSetadID " & _
                       "FROM         dbo.VwHR_PersonAge " & _
                       "WHERE   (EngageTypeID=8 or EngageTypeID=9)" & _
                       "GROUP BY SafSetadID  "

            dt_CountPerson = Persist1.GetDataTable(ConString, SqlStr)

            For i = 0 To dt_CountPerson.DefaultView.Count - 1

                If dt_CountPerson.DefaultView.Item(i).Item("SafSetadID") = 1 Then

                    SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Saf] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                    Persist1.GetDataAccess(SqlStr, 2, ConString)

                Else
                    SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Setad] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                    Persist1.GetDataAccess(SqlStr, 2, ConString)
                End If
            Next

            SqlStr = _
                      "SELECT     AVG(Age) AS AvgPersonAge,SexID " & _
                      "FROM         dbo.VwHR_PersonAge " & _
                      "WHERE   (EngageTypeID=8 or EngageTypeID=9)" & _
                      "GROUP BY SexID  "

            dt_CountPerson = Persist1.GetDataTable(ConString, SqlStr)

            For i = 0 To dt_CountPerson.DefaultView.Count - 1

                If dt_CountPerson.DefaultView.Item(i).Item("SexID") = 1 Then

                    SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Man] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                    Persist1.GetDataAccess(SqlStr, 2, ConString)

                Else
                    SqlStr = "UPDATE [Personely].[dbo].[tbHR_ParakaneshAgeDiplom] SET [Women] = " & dt_CountPerson.DefaultView.Item(i).Item("AvgPersonAge") & "  WHERE Year=" & ParakaneshYear & " AND Month=" & ParakaneshMounth
                    Persist1.GetDataAccess(SqlStr, 2, ConString)
                End If
            Next


            Me.Close()
        End If
    End Sub
End Class