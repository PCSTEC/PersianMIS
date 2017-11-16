
Module mdlHResorce
    Public ConString As String = "Data Source=PCSTECSERVER\PCSTECSERVER;Initial Catalog=Personely;User ID=sa;password=afarinesh"

    ''' Public ConString As String = "packet size=4096;integrated security=SSPI;data source=SQLSRV;persist security info=False;initial catalog=Personely"
    Friend Persist1 As New Persistent.DataAccess.DataAccess
    Friend SqlStr As String
    Friend IraniDate1 As New IraniDate.IraniDate.IraniDate
    Friend IraniTime1 As New IraniDate.IraniDate.Times
    Friend i, j, k, l As Integer
    Friend pic1 As New IKIDUtility.PictureInfo.PictureInfo
    Friend Utility1 As New IKIDUtility.IKIDUtility.Formating
    Friend janus1 As New JFrameWork.JanusGrid
    Public ReportName As String
    Public rptReports As Object
    Public dsReports As New DataSet
    Public wstr As String
    Public LastRepName As String
    Public DtGeneral As New DataTable

    Public acYekGon(10) As String
    Public acDahGon1(10) As String
    Public acDahGon(10) As String
    Public acSadGon(10) As String
    Public acApend(6) As String
    Public cTextNum As String
    Public classNumtoStr1 As New classNumtoStr
    Public grdSelect1 As New IKIDUtility.Grd_SELECT
    Public LoginInfo1 As New IKIDSecurity.Information.LoginInfo
    Public Activity1 As New Activities.AppActivities("729461sc75halgygb")
    Public LogText As String
    Public LogID As Integer
    Friend Bus_Employee1 As New Bus_Employee
    Friend Bus_Education1 As New Bus_Education
    Dim currentUser As System.Security.Principal.WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent()
    Public Bus_Fee1 As New Bus_Fee
    Public Dac_Engage1 As New Dac_Engage
    Public Bus_Family1 As New Bus_Family
    Public Bus_Engage1 As New Bus_Engage
    Public Bus_Meed1 As New Bus_Meed
    Public Bus_Dossier1 As New Bus_Dossier
    Public Bus_Post1 As New Bus_Post
    Public Bus_Other1 As New Bus_Other
    Public Bus_Card1 As New Bus_Card
    Public Bus_City1 As New Bus_City
    Public Bus_Training1 As New Bus_Training
    Public MainEndDate As String
    Public wstr_Rep As String

    Friend Enum SelectStr
        All = 1
        Current = 2
        NotCurrent = 3
        FirstEngage = 4
    End Enum

    Public Function getLogID(ByVal Logon As String) As Integer
        Try
            Dim Sqlstr As String
            Dim DataTable1 As New DataTable
            Sqlstr = "select LoginID from GeneralObjects..tbGen_Logins where LoginName='" & Logon & "' "
            DataTable1 = Persist1.GetDataTable(ConString, Sqlstr)
            Dim x As Integer
            x = DataTable1.DefaultView.Item(0).Item("LoginID")
            getLogID = x
        Catch ex As Exception
            getLogID = 0
        End Try
    End Function


End Module
