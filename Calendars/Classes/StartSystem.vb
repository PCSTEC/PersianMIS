Public Class StartSystem
    Sub New(ByVal newLogID As String, ByVal newLogType As Boolean, ByVal newPasw As String)
        LogID = newLogID
        Pasw = newPasw
        LogType = newLogType



        LogID = Val(newLogID)

        'CnnString = "packet size=4096;user id=sa;Password=afarinesh;data source=SQLSRV;persist security info=False;initial catalog=InfoServices"
        'LogID = 94
    End Sub

    Sub showform()
        'Dim f2 As New frmRollCallMain
        'f2.ShowDialog()
    End Sub
End Class
