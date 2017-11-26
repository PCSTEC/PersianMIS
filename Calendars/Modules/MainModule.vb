Imports Activities_New
Imports Activities

Public Module MainModule

    Public strConnection = "Data Source=pcstecserver\pcstecserver;Initial Catalog=HumanResource;User ID=sa;password=afarinesh"

    Public cnn As New SqlClient.SqlConnection
    Public logname As String
    Public LogID As Integer = 17
    Public Pasw As String
    Public LogType As Boolean
    Public SqlStr, setdate, sqlstrAsl As String

    Public Dt As New DataTable
    Public ps1, Pers As New Persistent.DataAccess.DataAccess
    Public date1 As New IraniDate.IraniDate.IraniDate
    Public tm1 As New IraniDate.IraniDate.Times
    ' Public Wl1 As New WLFormGlobalCtrl_DT.clsPublicProperty
    Public nz1 As New IKIDUtility.IKIDUtility.Formating
    ' Public act1 As New AppActivities("729461sc75halgygb")
    Public utility1, Utility As New IKIDUtility.IKIDUtility.Formating
    Public irdate As IraniDate.IraniDate.IraniDate

    Public forms As New System.Collections.Hashtable

    Public dsReports As New DataSet
    Public rptReports As Object
    Public ReportName As String
    Public LastRepName As String
    Public MDepID As String

    Public Enum DayState As Integer
        All = 0
        Adi = 1
        GararDadi_Tatil = 2
        Rasmi_Tatil
    End Enum


    Public Enum TimeState
        ToDay = 1
        Tomorrow = 2
    End Enum

    Public Enum CalendarType
        AllDepart = 1
        Tolid = 2
    End Enum

    Public Structure WeekDays
        Public Sat As Int16
        Public Sun As Int16
        Public Mon As Int16
        Public tue As Int16
        Public Wed As Int16
        Public Thu As Int16
        Public Fri As Int16
    End Structure

End Module
