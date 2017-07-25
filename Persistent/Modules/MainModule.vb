Public Module MainModule
    Friend cnn As New SqlClient.SqlConnection
    Friend Flg_GridStyle As Boolean

    '   Public CnnString As String = "packet size=4096;integrated security=SSPI;data source=SQLSRV;persist security info=False;initial catalog=GeneralObjects"
    Public CnnString As String = "Data Source=.;Initial Catalog=PIASDB;Integrated Security=True"

    Public Structure ParameterCmd
        Public ParamName As String
        Public ParamType As SqlDbType
        Public ParamValue As Object
        Public Direct As ParameterDirection
    End Structure

    'Public ParameterCmd1() As ParameterCmd
    ' Public ParamCount As Integer = 0

End Module
