Public Module MainModule
    Friend cnn As New SqlClient.SqlConnection
    Friend Flg_GridStyle As Boolean

    Public CnnString As String = "Data Source=pcstecserver\pcstecserver;Initial Catalog=PCSTEC;User ID=sa;password=afarinesh"
    '  Public CnnString As String = "Data Source=sqlsrv;Initial Catalog=PCSTEC;Integrated Security=True"

    '  Public CnnString As String = "Data Source=.;Initial Catalog=PIASDB;Integrated Security=True"

    Public Structure ParameterCmd
        Public ParamName As String
        Public ParamType As SqlDbType
        Public ParamValue As Object
        Public Direct As ParameterDirection
    End Structure

    'Public ParameterCmd1() As ParameterCmd
    ' Public ParamCount As Integer = 0

End Module
