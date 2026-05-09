Module GlobalModule
    Public Service As String
    Public MaxPatients As Integer = 100
    Public CurrentCount As Integer = 0

    ' Requirement: Parallel Arrays — patient data
    Public arrID(MaxPatients) As String
    Public arrNames(MaxPatients) As String
    Public arrSex(MaxPatients) As String
    Public arrContact(MaxPatients) As String
    Public arrService(MaxPatients) As String
    Public arrSchedule(MaxPatients) As String
    Public arrStatus(MaxPatients) As String
    Public arrCancelReason(MaxPatients) As String
    Public arrAge(MaxPatients) As Integer
    Public arrBday(MaxPatients) As Date

    ' History / Transaction Log — parallel arrays
    ' Each index represents one event that happened in the system
    Public MaxHistory As Integer = 500
    Public HistoryCount As Integer = 0
    Public arrHistoryTime(500) As String      ' when it happened
    Public arrHistoryEvent(500) As String     ' what happened (e.g. "Patient Added")
    Public arrHistoryPatient(500) As String   ' which patient was involved
    Public arrHistoryDetails(500) As String   ' extra details (e.g. old → new status)

    ' Logs one event into the history arrays
    ' Called from any form whenever something important happens
    Public Sub LogEvent(eventType As String, patientName As String, details As String)
        If HistoryCount < MaxHistory Then
            arrHistoryTime(HistoryCount) = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
            arrHistoryEvent(HistoryCount) = eventType
            arrHistoryPatient(HistoryCount) = patientName
            arrHistoryDetails(HistoryCount) = details
            HistoryCount += 1
        End If
    End Sub

    ' For Dashboard
    Public RecordCount As Integer = 0
    Public TotalGeneral As Integer = 0
    Public TotalDental As Integer = 0
    Public TotalPedia As Integer = 0


    Public Process As String = ""

End Module