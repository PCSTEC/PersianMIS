

Public Module MainModule
    Public Enum ExportType
        Excel = 1
        Word = 2
        Pdf = 3
        Html = 4
        Txt = 5
    End Enum
    Public Persist1 As New Persistent.DataAccess.DataAccess

    Public CnnString = "Data Source=pcstecserver\pcstecserver;Initial Catalog=GeneralObjects;User ID=sa;password=afarinesh"

    '  Public CnnString As String = "packet size=4096;user id=sa;Password=afarinesh;data source=SQLSRV;persist security info=False;initial catalog=GeneralObjects"

End Module
