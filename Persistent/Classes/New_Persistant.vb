Namespace New_Persistant
    Public Enum TxtBol As Byte
        Text = 1
        BooleanTxt = 2
    End Enum
    Public Class DataAccess

        Public Sub New(Optional ByVal ConnectionString As String = "")
            If ConnectionString <> "" Then
                Cnn = GetCnn(ConnectionString)
            Else
                MsgBox("Wrong Connection String")
            End If
        End Sub
        Dim ConnectionString As String
        Dim mSetMyGridStyle As Boolean = False
        Dim Connection As New System.Data.SqlClient.SqlConnection
        Public Property SetMyGridStyle() As Boolean
            Get
                Return mSetMyGridStyle
            End Get
            Set(ByVal value As Boolean)
                mSetMyGridStyle = value
            End Set
        End Property
        Public Property Cnn() As System.Data.SqlClient.SqlConnection
            Get
                Return Connection
            End Get
            Set(ByVal value As System.Data.SqlClient.SqlConnection)
                Connection = value
            End Set
        End Property
        Public Function GetCnn(ByVal CnnStr As String) As System.Data.SqlClient.SqlConnection
            Dim cnn As New System.Data.SqlClient.SqlConnection
            cnn.Close()
            cnn.ConnectionString = CnnStr
            cnn.Open()
            Return cnn
        End Function
        ''
        Public Function GetDataTable(ByVal SqlStr) As DataTable
            Dim DA As New SqlClient.SqlDataAdapter ' OleDb.OleDbDataAdapter
            Dim Dt As New DataTable
            Dim cmd As New SqlClient.SqlCommand ' OleDb.OleDbCommand
            With cmd
                .Connection = Cnn
                .CommandText = SqlStr
                .CommandType = CommandType.Text
            End With
            DA.SelectCommand = cmd
            DA.Fill(Dt)
            Return Dt
        End Function
        ''
        Public Function ExecuteNoneQuery(ByVal SQLString As String)
            Dim myDataAdapter As New SqlClient.SqlDataAdapter
            Dim myCommand As New SqlClient.SqlCommand
            Try
                myCommand.Connection = Cnn
                myCommand.CommandType = System.Data.CommandType.Text
                myCommand.CommandTimeout = 500
                myCommand.CommandText = SQLString
                myCommand.ExecuteNonQuery()
            Catch ex As Exception

            End Try
        End Function
        ''
        Public Function GetBindGrid_Dt(ByVal DG As System.Windows.Forms.DataGrid, ByVal Dt As DataTable)
            Try
                DG.DataSource = Dt
                DG.SetDataBinding(Dt.DefaultView, "")

            Catch ex As Exception

            End Try
        End Function
        Public Function SetGridStyle_Dt(ByVal TableStyle As System.Windows.Forms.DataGridTableStyle, ByVal TxtBool As TxtBol, ByVal dtCalNewToolIns As DataTable, ByVal DG As System.Windows.Forms.DataGrid, ByVal FldName As String, ByVal CapFld As String, ByVal SizeFld As Integer, ByVal RWFld As Boolean, ByVal EndFld As Boolean)
            If TxtBool = 1 Then
                Dim TextCol1 As New System.Windows.Forms.DataGridTextBoxColumn
                TextCol1.MappingName = dtCalNewToolIns.Columns(FldName).ColumnName
                TextCol1.HeaderText = CapFld
                TextCol1.Width = SizeFld
                TextCol1.ReadOnly = RWFld
                TableStyle.GridColumnStyles.Add(TextCol1)
            ElseIf TxtBool = 2 Then
                Dim TextCol1 As New System.Windows.Forms.DataGridBoolColumn
                TextCol1.MappingName = dtCalNewToolIns.Columns(FldName).ColumnName
                TextCol1.HeaderText = CapFld
                TextCol1.Width = SizeFld
                TextCol1.ReadOnly = RWFld
                TableStyle.GridColumnStyles.Add(TextCol1)
            End If


            If EndFld = True Then
                Try
                    If SetMyGridStyle = True Then
                        TableStyle.HeaderBackColor = System.Drawing.Color.FromArgb(179, 200, 202)
                        TableStyle.AlternatingBackColor = System.Drawing.Color.FromArgb(230, 240, 255)
                    End If
                    DG.TableStyles.Clear()
                    DG.TableStyles.Add(TableStyle)

                    If SetMyGridStyle = True Then
                        DG.CaptionVisible = False
                    End If
                    'Flg_GridStyle = False
                Catch ex As Exception

                End Try

            End If
        End Function
        Public Function ExecuteScalerQuery(ByVal SQLString As String) As Object
            Dim myDataAdapter As New SqlClient.SqlDataAdapter
            Dim myCommand As New SqlClient.SqlCommand
            Try
                myCommand.Connection = Cnn
                myCommand.CommandType = System.Data.CommandType.Text
                myCommand.CommandTimeout = 500
                myCommand.CommandText = SQLString
                Return myCommand.ExecuteScalar()
            Catch ex As Exception

            End Try
        End Function
        Public Function FillCmb(ByVal dt As DataTable, ByVal CmbName As Object, ByVal ValueMember As String, ByVal DisplayMember As String)
            CmbName.DataSource = dt
            CmbName.DisplayMember = DisplayMember
            CmbName.ValueMember = ValueMember
        End Function

    End Class

End Namespace

