
Imports System.Drawing
Namespace DataAccess
    Public Enum TxtBol As Byte
        Text = 1
        BooleanTxt = 2
    End Enum

    Public Class DataAccess
        Dim gc1 As GC

        'Dim cmd_sp As New SqlClient.SqlCommand

        Public SetMyGridStyle As Boolean = False
        Public ParameterCmd1() As ParameterCmd
        Public ParamCount As Integer = 0

        Public Sub ClearParameter()
            ParamCount = 0
            ReDim ParameterCmd1(0)
        End Sub


        Public Sub GetCnn(ByVal CnnStr As String)
            cnn.Close()
            cnn.ConnectionString = CnnStr
            cnn.Open()
        End Sub

        Public Function OpenRecordSet(ByRef dr As SqlClient.SqlDataReader, ByVal wstr As String, ByVal ConStr As String) As SqlClient.SqlDataReader
            Dim cmd As SqlClient.SqlCommand
            Try
                GetCnn(ConStr)
                cmd = New SqlClient.SqlCommand(wstr, cnn)
                dr = cmd.ExecuteReader
                'dr.Read()
            Catch ex As Exception

            End Try
        End Function

        Public Function FillDataReader(ByRef dr1 As SqlClient.SqlDataReader, ByVal wstr As String, ByVal ConStr As String) As SqlClient.SqlDataReader
            Try


                Dim cmd As SqlClient.SqlCommand
                Dim cnn1 As New SqlClient.SqlConnection
                cnn1.Close()
                cnn1.ConnectionString = ConStr
                cnn1.Open()
                Try
                    'GetCnn(ConStr)
                    cmd = New SqlClient.SqlCommand(wstr, cnn1)
                    dr1 = cmd.ExecuteReader

                Catch ex As Exception

                End Try
            Catch ex As Exception

            End Try
        End Function

        Public Function GetDataAccess(ByVal SQLString As String, ByVal CommandType As Byte, ByVal CnnStr As String, Optional ByVal tbName As String = "", Optional ByVal MyDS As DataSet = Nothing) As SqlClient.SqlDataAdapter
            Dim myConnection As New SqlClient.SqlConnection
            myConnection.ConnectionString = "workstation id=" & myConnection.WorkstationId & ";" & CnnStr
            Dim myDataAdapter As New SqlClient.SqlDataAdapter
            Dim myCommand As New SqlClient.SqlCommand


            Try
                myConnection.Open()
            Catch ex As Exception

            End Try
            'myCommand = New SqlClient.SqlCommand(SQLString, myConnection)

            If CommandType = 1 Then                                               'Select Command
                myCommand = New SqlClient.SqlCommand(SQLString, myConnection)
                myCommand.CommandTimeout = 500
                myDataAdapter.SelectCommand = myCommand
                Try
                    myDataAdapter.Fill(MyDS, "" & tbName & "")
                    GetDataAccess = myDataAdapter
                Catch ex As Exception

                End Try
            ElseIf CommandType = 2 Then                                           'Action Command
                Try
                    myCommand.Connection = myConnection
                    myCommand.CommandType = System.Data.CommandType.Text
                    myCommand.CommandTimeout = 500
                    myCommand.CommandText = SQLString
                    myCommand.ExecuteNonQuery()
                Catch ex As Exception

                    GetErrHandler()
                End Try
            End If
            myConnection.Close()
            myConnection = Nothing
        End Function

        Public Function GetErrHandler()

            If Err.Number = 5 Then
                MsgBox("ãÞÏÇÑ ÊßÑÇÑí æÇÑÏ äãæÏå ÇíÏ", MsgBoxStyle.Critical, "ÎØÇ")
            End If

            Try

            Catch ex As System.DivideByZeroException



            End Try


        End Function



        Public Function GetDataTable(ByVal ConStr, ByVal SqlStr) As DataTable
            Try

                Dim DA As New SqlClient.SqlDataAdapter
            Dim Dt As New DataTable
            Dim cl As New DataAccess
            Dim cn As New SqlClient.SqlConnection
            Dim cmd As New SqlClient.SqlCommand

            cn.ConnectionString = ConStr
            cn.Open()
            With cmd
                .Connection = cn
                .CommandText = SqlStr
                .CommandType = CommandType.Text
            End With
            DA.SelectCommand = cmd
            DA.Fill(Dt)

            cn.Close()
            cn = Nothing
                Return Dt

            Catch ex As Exception
                Dim x As Integer
                x = 0
            End Try
        End Function

        Public Function GetDataReader(ByRef Conection As SqlClient.SqlConnection, ByVal SqlStr As String) As SqlClient.SqlDataReader
            Dim DA As New SqlClient.SqlDataAdapter
            Dim Dt As New DataTable
            Dim cl As New DataAccess
            Dim cn As New SqlClient.SqlConnection
            Dim cmd As New SqlClient.SqlCommand
            With cmd
                .Connection = Conection
                .CommandText = SqlStr
                .CommandType = CommandType.Text
                Return .ExecuteReader
            End With
        End Function

        Public Function ExecuteNoneQuery(ByVal SQLString As String, ByVal CnnStr As String)
            Dim myConnection As New SqlClient.SqlConnection(CnnStr)
            Dim myDataAdapter As New SqlClient.SqlDataAdapter
            Dim myCommand As New SqlClient.SqlCommand
            Try
                myConnection.Open()
            Catch ex As Exception

            End Try
            Try
                myCommand.Connection = myConnection
                myCommand.CommandType = System.Data.CommandType.Text
                myCommand.CommandTimeout = 500
                myCommand.CommandText = SQLString
                myCommand.ExecuteNonQuery()
            Catch ex As Exception


            End Try
            myConnection.Close()
            myConnection = Nothing
        End Function

        Public Function ExecuteScalerQuery(ByVal SQLString As String, ByVal CnnStr As String) As Object
            Dim myConnection As New SqlClient.SqlConnection(CnnStr)
            Dim myDataAdapter As New SqlClient.SqlDataAdapter
            Dim myCommand As New SqlClient.SqlCommand
            Try
                myConnection.Open()
            Catch ex As Exception

            End Try
            Try
                myCommand.Connection = myConnection
                myCommand.CommandType = System.Data.CommandType.Text
                myCommand.CommandTimeout = 500
                myCommand.CommandText = SQLString
                ExecuteScalerQuery = myCommand.ExecuteScalar()
            Catch ex As Exception

                GetErrHandler()
            End Try
            myConnection.Close()
            myConnection = Nothing
        End Function

        Public Function Sp_Exe(ByVal SpName As String, ByVal CnnStr As String, Optional ByVal IsClearParam As Boolean = True) As Boolean
            Dim cnn As New SqlClient.SqlConnection
            cnn.ConnectionString = CnnStr
            Dim cmd As New SqlClient.SqlCommand
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            With cmd
                .Connection = cnn
                .CommandType = CommandType.StoredProcedure
                .CommandText = SpName
                .CommandTimeout = 300
            End With

            Dim i As Integer
            For i = 1 To ParamCount
                Dim SP_Param As New SqlClient.SqlParameter
                With SP_Param
                    .ParameterName = ParameterCmd1(i).ParamName
                    .SqlDbType = ParameterCmd1(i).ParamType
                    .Value = ParameterCmd1(i).ParamValue
                    .Direction = ParameterCmd1(i).Direct
                End With

                With cmd
                    .Parameters.Add(SP_Param)
                End With
            Next
            Try
                cmd.ExecuteNonQuery()

                For i = 1 To ParamCount
                    If ParameterCmd1(i).Direct = ParameterDirection.InputOutput Or ParameterCmd1(i).Direct = ParameterDirection.Output Then
                        ParameterCmd1(i).ParamValue = cmd.Parameters(i - 1).Value
                    End If

                Next

                Sp_Exe = True
            Catch ex As SqlClient.SqlException
                GetErrorrHandler(ex)
                Sp_Exe = False
            Catch ex As Exception

            End Try

            If IsClearParam Then
                ParamCount = 0
                ReDim ParameterCmd1(0)
            End If

            cnn.Close()
            cnn = Nothing
            GC.Collect()

        End Function

        Public Function Sp_Scaler(ByVal SpName As String, ByVal CnnStr As String) As Object
            Dim cnn As New SqlClient.SqlConnection
            cnn.ConnectionString = CnnStr
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If

            'With cmd_sp
            '.Connection = cnn
            '.CommandType = CommandType.StoredProcedure
            '.CommandText = SpName
            'End With

            'Sp_Scaler = cmd_sp.ExecuteScalar()
            cnn.Close()
            cnn = Nothing
        End Function

        Public Function Sp_AddParam(ByVal ParamName As String, ByVal ParamType As SqlDbType, ByVal ParamValue As Object, ByVal Direct As ParameterDirection)
            ParamCount = ParamCount + 1
            ReDim Preserve ParameterCmd1(ParamCount)
            ParameterCmd1(ParamCount).ParamName = ParamName
            ParameterCmd1(ParamCount).ParamType = ParamType
            ParameterCmd1(ParamCount).ParamValue = ParamValue
            ParameterCmd1(ParamCount).Direct = Direct


            'Dim SP_Param As New SqlClient.SqlParameter
            'With SP_Param
            '    .ParameterName = ParamName
            '    .SqlDbType = ParamType
            '    .Value = ParamValue
            '    .Direction = Direct
            'End With

            'With cmd_sp
            '    .Parameters.Add(SP_Param)
            '    .CommandType = CommandType.StoredProcedure
            'End With

        End Function

        Public Function GetErrorrHandler(ByVal ex As SqlClient.SqlException)
            'Dim ErrNumber As Integer = ex.Number
            'If ErrNumber = 2627 Or 2601 Then
            '    MsgBox("ãÞÏÇÑ ÊßÑÇÑí æÇÑÏ äãæÏå ÇíÏ", MsgBoxStyle.Critical, "ÎØÇ2627")
            'ElseIf ErrNumber = 8114 Then
            '    MsgBox("ÇÔßÇá ÏÑ ÊÈÏíá ÏíÊÇÊÇí", MsgBoxStyle.Critical, "ÎØÇ8114")
            'Else

            'End If


        End Function

      
 
        Public Function FillCmb(ByVal dt As DataTable, ByVal CmbName As Object, ByVal ValueMember As String, ByVal DisplayMember As String)
            CmbName.DataSource = dt
            CmbName.DisplayMember = DisplayMember
            CmbName.ValueMember = ValueMember
        End Function

        Public Function GetMAX(ByVal dbName As String, ByVal tbName As String, ByVal fldName As String, ByVal Wstr As String, ByVal cnnStr As String) As Object
            Dim dt1 As DataTable
            Dim sqlstr1 As String
            sqlstr1 = "SELECT MAX(" & fldName & ") as MaxRow FROM " & dbName & ".." & tbName & " WHERE " & Wstr
            dt1 = Me.GetDataTable(cnnStr, sqlstr1)
            If IsDBNull(dt1.DefaultView.Item(0).Item("MaxRow")) Then
                If Right(Wstr, 1) = "'" Then
                    GetMAX = ""
                Else
                    GetMAX = 0
                End If
            Else
                GetMAX = dt1.DefaultView.Item(0).Item("MaxRow")
            End If

        End Function

        Public Function GetMIN(ByVal dbName As String, ByVal tbName As String, ByVal fldName As String, ByVal Wstr As String, ByVal cnnStr As String) As Object
            Dim dt1 As DataTable
            Dim sqlstr1 As String
            sqlstr1 = "SELECT MIN(" & fldName & ") as MinRow FROM " & dbName & ".." & tbName & " WHERE " & Wstr
            dt1 = Me.GetDataTable(cnnStr, sqlstr1)
            If IsDBNull(dt1.DefaultView.Item(0).Item("MinRow")) Then
                If Right(Wstr, 1) = "'" Then
                    GetMIN = ""
                Else
                    GetMIN = 0
                End If
            Else
                GetMIN = dt1.DefaultView.Item(0).Item("MinRow")
            End If
        End Function

        Public Function GetLookUp(ByVal dbName As String, ByVal tbName As String, ByVal fldName As String, ByVal Wstr As String, ByVal cnnStr As String) As Object
            Dim dt1 As DataTable
            Dim sqlstr1 As String
            sqlstr1 = "SELECT " & fldName & " as LookUpRow FROM " & dbName & ".." & tbName & " WHERE " & Wstr
            dt1 = Me.GetDataTable(CnnString, sqlstr1)
            If dt1.DefaultView.Count > 1 Then
                Return "Error"
            Else
                If IsDBNull(dt1.DefaultView.Item(0).Item("LookUpRow")) Then
                    GetLookUp = 0
                Else
                    GetLookUp = dt1.DefaultView.Item(0).Item("LookUpRow")
                End If
            End If

        End Function

    End Class




    'Public Class SP_Process

End Namespace

