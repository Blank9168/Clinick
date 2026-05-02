Module GlobalModule
    Public Service As String
    Public MaxPatients As Integer = 100
    Public CurrentCount As Integer = 0

    ' Requirement: Parallel Arrays
    Public arrID(MaxPatients) As String
    Public arrNames(MaxPatients) As String
    Public arrSex(MaxPatients) As String
    Public arrContact(MaxPatients) As String
    Public arrService(MaxPatients) As String
    Public arrSchedule(MaxPatients) As String
    Public arrStatus(MaxPatients) As String
    Public arrCancelReason(MaxPatients) As String

    'For Dashboard'
    Public RecordCount As Integer = 0
    Public TotalGeneral As Integer = 0
    Public TotalDental As Integer = 0
    Public TotalPedia As Integer = 0



End Module
