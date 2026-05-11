Module GlobalModule
    Public Service As String
    Public MaxPatients As Integer = 1000
    Public CurrentCount As Integer = 0
    Public MasterCount As Integer = 0

    Public arrID(1000) As String
    Public arrNames(1000) As String
    Public arrSex(1000) As String
    Public arrContact(1000) As String
    Public arrService(1000) As String
    Public arrSchedule(1000) As String
    Public arrStatus(1000) As String
    Public arrCancelReason(1000) As String
    Public arrAge(1000) As Integer
    Public arrBday(1000) As Date
    Public arrDateCreated(1000) As String
    Public arrDateProcessed(1000) As String

    Public arrMasterID(1000) As String
    Public arrMasterName(1000) As String
    Public arrMasterContact(1000) As String
    Public arrMasterSex(1000) As String
    Public arrMasterAge(1000) As Integer
    Public arrMasterBday(1000) As Date

    Public RecordCount As Integer = 0
    Public TotalGeneral As Integer = 0
    Public TotalDental As Integer = 0
    Public TotalPedia As Integer = 0
    Public pending As Integer = 0
    Public completed As Integer = 0
    Public cancelled As Integer = 0

    Public user As String = " "
    Public password As String = " "
    Public CurrentUser As String = ""
End Module